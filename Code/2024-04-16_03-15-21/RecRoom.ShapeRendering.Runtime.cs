using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using RecRoom.ClusterLODs;
using RecRoom.Core.Creation.Shapes;
using RecRoom.Logging.Attributes;
using RecRoom.ShapeRendering;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Rendering;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_ShapeRendering_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Preserve]
	public class LogRegistrationIndex : JICBOCPMGEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x69F5EE0", Offset = "0x69F50E0", VA = "0x1869F5EE0", Slot = "4")]
		public override void OEPCKJDAMHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7DEA50", Offset = "0x7DDC50", VA = "0x1807DEA50")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class JLMGDMJJKLF : LFNFGIAMGLH, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private byte CGJPOMIBNEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly List<SkinnedShapeRenderer>[] NOEJMDLPJDH;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int OHPHHEFLCKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x95D910", Offset = "0x95CB10", VA = "0x18095D910", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x95D920", Offset = "0x95CB20", VA = "0x18095D920")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int LMHFJLNOPAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7F41B0", Offset = "0x7F33B0", VA = "0x1807F41B0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7F3FE0", Offset = "0x7F31E0", VA = "0x1807F3FE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public float PFCFFKKNDBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x971F70", Offset = "0x971170", VA = "0x180971F70", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x86C3D0", Offset = "0x86B5D0", VA = "0x18086C3D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float CHMJBKNGACA
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x971F80", Offset = "0x971180", VA = "0x180971F80", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x972510", Offset = "0x971710", VA = "0x180972510")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public List<SkinnedShapeRenderer> LGHLJNGFIAL
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x69F3020", Offset = "0x69F2220", VA = "0x1869F3020")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public List<SkinnedShapeRenderer> BKBJHAKFDEG
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x69F3070", Offset = "0x69F2270", VA = "0x1869F3070")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public GameObject NECEBBLCHMG
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7B4170", Offset = "0x7B3370", VA = "0x1807B4170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7B4100", Offset = "0x7B3300", VA = "0x1807B4100")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public byte MKEACGKNPBP
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x69F2D70", Offset = "0x69F1F70", VA = "0x1869F2D70", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x69F3350", Offset = "0x69F2550", VA = "0x1869F3350")]
	public JLMGDMJJKLF(List<EBNEHDGPCOG> BDNLNDGELFB, List<EBNEHDGPCOG> CCCDLKOKDLM, List<AFMLJEGJNBJ> AICGOEIIJJM, Material ODNKEDBIBDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x69F30E0", Offset = "0x69F22E0", VA = "0x1869F30E0")]
	private int OCJCNDLHDAF(List<EBNEHDGPCOG> PHDIIJOJFNC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x69F2DC0", Offset = "0x69F1FC0", VA = "0x1869F2DC0")]
	private void CLEDGILJHML(int BLPBJOFGLBO, bool IKGCBKDCEAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x69F3200", Offset = "0x69F2400", VA = "0x1869F3200")]
	public void ODPAEGGLIFB(Vector3 FHMICDCPNGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x69F2F20", Offset = "0x69F2120", VA = "0x1869F2F20", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x69F30A0", Offset = "0x69F22A0", VA = "0x1869F30A0")]
	public void NIIAGPKIHEM(Transform CPLEPDKMJLG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class BHPJBMLMACF : LDBLLJMEEFH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private sealed class PHIJDLDHOEM : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private Renderer <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public BHPJBMLMACF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private List<ClusterMeshRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private IEnumerator<Renderer> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private IEnumerator<MeshRenderer> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x7B4160", Offset = "0x7B3360", VA = "0x1807B4160", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x7B4160", Offset = "0x7B3360", VA = "0x1807B4160", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x80AF90", Offset = "0x80A190", VA = "0x18080AF90")]
		[DebuggerHidden]
		public PHIJDLDHOEM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x69F75D0", Offset = "0x69F67D0", VA = "0x1869F75D0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x69F6FC0", Offset = "0x69F61C0", VA = "0x1869F6FC0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x69F6F70", Offset = "0x69F6170", VA = "0x1869F6F70")]
		private void KNOPPBKNOBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x69F6F20", Offset = "0x69F6120", VA = "0x1869F6F20")]
		private void KEKJABDJFPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x69F6ED0", Offset = "0x69F60D0", VA = "0x1869F6ED0")]
		private void FNEMFHPMODH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x69F7580", Offset = "0x69F6780", VA = "0x1869F7580", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x69F74D0", Offset = "0x69F66D0", VA = "0x1869F74D0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x69F74D0", Offset = "0x69F66D0", VA = "0x1869F74D0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class CHAIJNCFBKO : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private Renderer <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public BHPJBMLMACF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private IEnumerator<Renderer> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x7B4160", Offset = "0x7B3360", VA = "0x1807B4160", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x7B4160", Offset = "0x7B3360", VA = "0x1807B4160", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x80AF90", Offset = "0x80A190", VA = "0x18080AF90")]
		[DebuggerHidden]
		public CHAIJNCFBKO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x69E7F00", Offset = "0x69E7100", VA = "0x1869E7F00", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x69E7A90", Offset = "0x69E6C90", VA = "0x1869E7A90", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x69E7A40", Offset = "0x69E6C40", VA = "0x1869E7A40")]
		private void KNOPPBKNOBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x69E79F0", Offset = "0x69E6BF0", VA = "0x1869E79F0")]
		private void KEKJABDJFPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x69E7EB0", Offset = "0x69E70B0", VA = "0x1869E7EB0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x69E7E00", Offset = "0x69E7000", VA = "0x1869E7E00", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x69E7E00", Offset = "0x69E7000", VA = "0x1869E7E00", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly FHKDPKLBJJK IONGJKOKPIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly List<FMOKCGCLILK> LLOMAPHPCBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private List<ClusterMeshRenderer> PIEBKKAGOJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private BatchedMeshRenderer EAHLBNIBDMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private bool KKNDDCOGDNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public readonly bool BPIEMDKCOIJ;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IEnumerable<MKMNAFELPND> OEFJCDILHFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7B4160", Offset = "0x7B3360", VA = "0x1807B4160", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int BMFIJCCEIAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x69E7670", Offset = "0x69E6870", VA = "0x1869E7670", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public AFMLJEGJNBJ OHFICBOBPJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x69E6130", Offset = "0x69E5330", VA = "0x1869E6130", Slot = "8")]
		get
		{
			return default(AFMLJEGJNBJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public List<SkinnedShapeRenderer> JJBBHIDOCIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7B7560", Offset = "0x7B6760", VA = "0x1807B7560")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7B7530", Offset = "0x7B6730", VA = "0x1807B7530")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x69E6960", Offset = "0x69E5B60", VA = "0x1869E6960")]
	private bool CFDBBMGGKIA(FMOKCGCLILK NKFGLIJJHIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x69E7030", Offset = "0x69E6230", VA = "0x1869E7030")]
	private static bool IIPPNFAKGOF(FMOKCGCLILK NKFGLIJJHIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x69E7900", Offset = "0x69E6B00", VA = "0x1869E7900")]
	public BHPJBMLMACF(FHKDPKLBJJK MJGHOBDIDHD, bool GNIGAIAOGDJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x69E6A00", Offset = "0x69E5C00", VA = "0x1869E6A00", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x69E6E30", Offset = "0x69E6030", VA = "0x1869E6E30")]
	public void GHBEENLPKLN(FMOKCGCLILK NKFGLIJJHIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x69E6D10", Offset = "0x69E5F10", VA = "0x1869E6D10")]
	public void FBCLMIGJMFH(FMOKCGCLILK NKFGLIJJHIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x69E6460", Offset = "0x69E5660", VA = "0x1869E6460", Slot = "4")]
	public void BLEBCABFAOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x69E76B0", Offset = "0x69E68B0", VA = "0x1869E76B0")]
	public void MOLHGBBEJOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x69E61F0", Offset = "0x69E53F0", VA = "0x1869E61F0")]
	private void ANICOIPKKFD(List<FMOKCGCLILK> LLOMAPHPCBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x69E5B20", Offset = "0x69E4D20", VA = "0x1869E5B20")]
	private static Material AFFJPCJEMAH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x69E63B0", Offset = "0x69E55B0", VA = "0x1869E63B0")]
	private void ANICOIPKKFD(FMOKCGCLILK NKFGLIJJHIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x69E6B80", Offset = "0x69E5D80", VA = "0x1869E6B80")]
	private void EAAPIJBEHKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x69E70D0", Offset = "0x69E62D0", VA = "0x1869E70D0")]
	public void KMGEGKNNFOP(bool DEDPDBEMDNE, bool CCDGCIJBABA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x69E6C50", Offset = "0x69E5E50", VA = "0x1869E6C50")]
	protected void EOBDCHGEBKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x69E6980", Offset = "0x69E5B80", VA = "0x1869E6980")]
	[IteratorStateMachine(typeof(PHIJDLDHOEM))]
	public IEnumerable<Renderer> DONGCAPLOMG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x69E7050", Offset = "0x69E6250", VA = "0x1869E7050")]
	[IteratorStateMachine(typeof(CHAIJNCFBKO))]
	public IEnumerable<Renderer> KKGPMPIGEDO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal class GIGMABAJKON : FMOKCGCLILK
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private struct OBEFFFIDKAC : EFMBMEBALKM, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private FEEDCIOJNFD PLFOEDLJILP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private JobHandle IFPDAOGJICE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private JINFJHEEKBB BPLNOJOJPOF;

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x69F6E70", Offset = "0x69F6070", VA = "0x1869F6E70")]
		public OBEFFFIDKAC(FEEDCIOJNFD PLFOEDLJILP, JobHandle IFPDAOGJICE, JINFJHEEKBB BPLNOJOJPOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x69F6E40", Offset = "0x69F6040", VA = "0x1869F6E40", Slot = "4")]
		public FEEDCIOJNFD MHOCMODHEJI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x69F6DF0", Offset = "0x69F5FF0", VA = "0x1869F6DF0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly HJEAALBNHHM FMKJJLHOHNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private Hash128 HBJODEDKFLL;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	protected override Hash128 DPDJLLOJEDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x69F06E0", Offset = "0x69EF8E0", VA = "0x1869F06E0", Slot = "25")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x69F0800", Offset = "0x69EFA00", VA = "0x1869F0800")]
	public GIGMABAJKON(BHPJBMLMACF MFIBAFBMCBA, HJEAALBNHHM MJGHOBDIDHD, bool GNIGAIAOGDJ = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7FCE90", Offset = "0x7FC090", VA = "0x1807FCE90", Slot = "17")]
	public override bool HGMOMKHKADB(AFMLJEGJNBJ MFIBAFBMCBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x69F0510", Offset = "0x69EF710", VA = "0x1869F0510", Slot = "19")]
	public override int OCJCNDLHDAF(LJPLHCMPBCM MCCIEIKDMFF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x69EF310", Offset = "0x69EE510", VA = "0x1869EF310", Slot = "20")]
	public override int GFKKECLIPBB(LJPLHCMPBCM MCCIEIKDMFF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x69EF690", Offset = "0x69EE890", VA = "0x1869EF690", Slot = "21")]
	public override Bounds LFGCOBIKCAP()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x860BD0", Offset = "0x85FDD0", VA = "0x180860BD0", Slot = "22")]
	public override float ADGMCALGGAJ()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x69EEBF0", Offset = "0x69EDDF0", VA = "0x1869EEBF0", Slot = "23")]
	public override void CABLHPEMLMA(LJPLHCMPBCM MCCIEIKDMFF, NGABOLFNHJB BAAPAGBCKHO, int FFEAEKCELAG = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x69EFB30", Offset = "0x69EED30", VA = "0x1869EFB30", Slot = "24")]
	public override AFMLJEGJNBJ LGMEKIBGLBI()
	{
		return default(AFMLJEGJNBJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x69EF4E0", Offset = "0x69EE6E0", VA = "0x1869EF4E0", Slot = "26")]
	public override MMCFFOPIKCK IBDCFKPAGMN()
	{
		return default(MMCFFOPIKCK);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x69EFC00", Offset = "0x69EEE00", VA = "0x1869EFC00", Slot = "27")]
	public override EFMBMEBALKM MKFNIBPOFHH(LJPLHCMPBCM MCCIEIKDMFF, JobHandle IFPDAOGJICE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[DefaultMember("Item")]
public interface PHGBMAOMOKF
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	BHPJBMLMACF KFIAMJJGJCP
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	FMOKCGCLILK KFIAMJJGJCP
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	GCGIHEPIJBM KFIAMJJGJCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[DefaultMember("Item")]
public class GIKHOCAHIAK : GAFEFIOOPCM, IDisposable, PHGBMAOMOKF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct FADDFPBIFHO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public GIKHOCAHIAK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x69E9720", Offset = "0x69E8920", VA = "0x1869E9720", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x69E9C20", Offset = "0x69E8E20", VA = "0x1869E9C20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly CELKONIIPPD<GAANJEIKMIE, BHPJBMLMACF> LKEHNDIFPBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly CELKONIIPPD<JDJHKBJECJO, FMOKCGCLILK> LLOMAPHPCBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly CELKONIIPPD<GBFNOIADDPJ, GCGIHEPIJBM> NINALAKHGBP;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public BHPJBMLMACF KFIAMJJGJCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x69F1C90", Offset = "0x69F0E90", VA = "0x1869F1C90", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public FMOKCGCLILK KFIAMJJGJCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x69F1C30", Offset = "0x69F0E30", VA = "0x1869F1C30", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public GCGIHEPIJBM KFIAMJJGJCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x69F1CF0", Offset = "0x69F0EF0", VA = "0x1869F1CF0", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool MBLIHEFFPPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x8F7890", Offset = "0x8F6A90", VA = "0x1808F7890", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x9EA2D0", Offset = "0x9E94D0", VA = "0x1809EA2D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x69F28F0", Offset = "0x69F1AF0", VA = "0x1869F28F0")]
	public GIKHOCAHIAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x69F1510", Offset = "0x69F0710", VA = "0x1869F1510", Slot = "21")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x69F0B20", Offset = "0x69EFD20", VA = "0x1869F0B20", Slot = "4")]
	public GAANJEIKMIE AEAKJKBBFOD(FHKDPKLBJJK MJGHOBDIDHD)
	{
		return default(GAANJEIKMIE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x69F08B0", Offset = "0x69EFAB0", VA = "0x1869F08B0", Slot = "5")]
	public GAANJEIKMIE AEAKJKBBFOD(FHKDPKLBJJK MJGHOBDIDHD, bool GNIGAIAOGDJ)
	{
		return default(GAANJEIKMIE);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x69F17D0", Offset = "0x69F09D0", VA = "0x1869F17D0", Slot = "6")]
	public void JPMKHNOEMEF(GAANJEIKMIE MFIBAFBMCBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x69F24E0", Offset = "0x69F16E0", VA = "0x1869F24E0", Slot = "7")]
	public void PKKPHGBDMNI(GAANJEIKMIE MFIBAFBMCBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x69F0B30", Offset = "0x69EFD30", VA = "0x1869F0B30", Slot = "8")]
	public JDJHKBJECJO CDJDIHGCFIP(GAANJEIKMIE MFIBAFBMCBA, OMOAPGBLBBK MJGHOBDIDHD)
	{
		return default(JDJHKBJECJO);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x69F1DD0", Offset = "0x69F0FD0", VA = "0x1869F1DD0", Slot = "9")]
	public JDJHKBJECJO OCEDHBDOAGM(GAANJEIKMIE MFIBAFBMCBA, HJEAALBNHHM MJGHOBDIDHD)
	{
		return default(JDJHKBJECJO);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x69F0FF0", Offset = "0x69F01F0", VA = "0x1869F0FF0", Slot = "11")]
	public void DFJDIPCCBIA(JDJHKBJECJO NKFGLIJJHIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x69F2290", Offset = "0x69F1490", VA = "0x1869F2290", Slot = "10")]
	public void PAFNHFCAIOD(JDJHKBJECJO NKFGLIJJHIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x69F1760", Offset = "0x69F0960", VA = "0x1869F1760", Slot = "20")]
	public IEnumerable<Renderer> JNLLMAJHMNF(GAANJEIKMIE MFIBAFBMCBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x69F1D50", Offset = "0x69F0F50", VA = "0x1869F1D50", Slot = "12")]
	public GBFNOIADDPJ NGJKBLIDMPK(DDEICIKGNFL MJGHOBDIDHD)
	{
		return default(GBFNOIADDPJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x69F16F0", Offset = "0x69F08F0", VA = "0x1869F16F0", Slot = "14")]
	public void FJCDCKAIIIM(GBFNOIADDPJ ONCDCCFIGLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x69F1390", Offset = "0x69F0590", VA = "0x1869F1390", Slot = "16")]
	public Task DJCJPAGLIEP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x69F1AB0", Offset = "0x69F0CB0", VA = "0x1869F1AB0", Slot = "17")]
	public Task LNAFOBLMCGB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x69F2820", Offset = "0x69F1A20", VA = "0x1869F2820", Slot = "18")]
	[AsyncStateMachine(typeof(FADDFPBIFHO))]
	public Task PMCKFLJGJKB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x69F1A20", Offset = "0x69F0C20", VA = "0x1869F1A20", Slot = "19")]
	public void KEFIGMCOOBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x69F1690", Offset = "0x69F0890", VA = "0x1869F1690", Slot = "13")]
	public void FDMHEBBLCJM(GBFNOIADDPJ ONCDCCFIGLK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
internal class FLBJONJHAIN : FMOKCGCLILK
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private struct LPLMOCGAGEJ : EFMBMEBALKM, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private FEEDCIOJNFD PLFOEDLJILP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private JobHandle IFPDAOGJICE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private HGMBDHNLOFE BPLNOJOJPOF;

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x69F5E90", Offset = "0x69F5090", VA = "0x1869F5E90")]
		public LPLMOCGAGEJ(FEEDCIOJNFD PLFOEDLJILP, JobHandle IFPDAOGJICE, HGMBDHNLOFE BPLNOJOJPOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x69F5E60", Offset = "0x69F5060", VA = "0x1869F5E60", Slot = "4")]
		public FEEDCIOJNFD MHOCMODHEJI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x69F5E10", Offset = "0x69F5010", VA = "0x1869F5E10", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly OMOAPGBLBBK FHDMPGOGOOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private int[] IAKIMLKDBKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private Hash128 HBJODEDKFLL;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public override KDKAKNKHEHB LCFPMOAODMI
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x69EA810", Offset = "0x69E9A10", VA = "0x1869EA810", Slot = "18")]
		get
		{
			return default(KDKAKNKHEHB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	private Vector3 CJEHDMMNKMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x69EABD0", Offset = "0x69E9DD0", VA = "0x1869EABD0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	protected override Hash128 DPDJLLOJEDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x69EC5E0", Offset = "0x69EB7E0", VA = "0x1869EC5E0", Slot = "25")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x69EC700", Offset = "0x69EB900", VA = "0x1869EC700")]
	public FLBJONJHAIN(BHPJBMLMACF MFIBAFBMCBA, OMOAPGBLBBK MJGHOBDIDHD, bool FBLPKKDOADB = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x69EAFD0", Offset = "0x69EA1D0", VA = "0x1869EAFD0", Slot = "17")]
	public override bool HGMOMKHKADB(AFMLJEGJNBJ MFIBAFBMCBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x69EC540", Offset = "0x69EB740", VA = "0x1869EC540", Slot = "19")]
	public override int OCJCNDLHDAF(LJPLHCMPBCM MCCIEIKDMFF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x69EAF30", Offset = "0x69EA130", VA = "0x1869EAF30", Slot = "20")]
	public override int GFKKECLIPBB(LJPLHCMPBCM MCCIEIKDMFF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x69EB840", Offset = "0x69EAA40", VA = "0x1869EB840", Slot = "21")]
	public override Bounds LFGCOBIKCAP()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x69E9E80", Offset = "0x69E9080", VA = "0x1869E9E80", Slot = "22")]
	public override float ADGMCALGGAJ()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x69EB990", Offset = "0x69EAB90", VA = "0x1869EB990")]
	private int LNIJEMIGLIJ(LJPLHCMPBCM MCCIEIKDMFF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x69E9F70", Offset = "0x69E9170", VA = "0x1869E9F70", Slot = "23")]
	public override void CABLHPEMLMA(LJPLHCMPBCM MCCIEIKDMFF, NGABOLFNHJB BAAPAGBCKHO, int FFEAEKCELAG = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x69EB8C0", Offset = "0x69EAAC0", VA = "0x1869EB8C0", Slot = "24")]
	public override AFMLJEGJNBJ LGMEKIBGLBI()
	{
		return default(AFMLJEGJNBJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x69EB690", Offset = "0x69EA890", VA = "0x1869EB690", Slot = "26")]
	public override MMCFFOPIKCK IBDCFKPAGMN()
	{
		return default(MMCFFOPIKCK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x69EBC00", Offset = "0x69EAE00", VA = "0x1869EBC00", Slot = "27")]
	public override EFMBMEBALKM MKFNIBPOFHH(LJPLHCMPBCM MCCIEIKDMFF, JobHandle IFPDAOGJICE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface MCAKJFEAJKA
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OPINNAIEOJE(FACIIGAFJII MJMAEGDPBNJ, Renderer FBFNLOOEGJA, int ICNEFBAMEAP);

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KMIJPCCNCNI(Renderer FBFNLOOEGJA, KBDADMCHHJA HFHFGCMEBKK, Vector3 BJMPJFAKGBA, Vector3 IMOIJNKOHNF, Vector3 MILKLCPBCJI, float NABBLMKCMAL, float BKMCFOHNALK, float OOIJGOEEDBF = -1f, [Optional] Color? CMIODFEAKCF, [Optional] IReadOnlyList<Camera> EAGLMOHAAHB);

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NIELCOBANIC(Renderer FBFNLOOEGJA, int ICNEFBAMEAP);

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int LLAIFOIJAJO();

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DPBPBJKDGPM(int OADDHMKCMPC, NJFLAEHPIGP MJMAEGDPBNJ, Renderer FBFNLOOEGJA, int ICNEFBAMEAP);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class LCDCBLLGIFK : GLAEAADPLNP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	private class BDOMDOHHPCC : DHIENJMEOAM<int>
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x69E60E0", Offset = "0x69E52E0", VA = "0x1869E60E0")]
		public BDOMDOHHPCC(string MPENHPFDCDK)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly MCAKJFEAJKA KJCLIAHKINJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly PHGBMAOMOKF BAOJLOCPMGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private MeshRenderer IHDIKADPOFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private BDOMDOHHPCC HDGHENANDCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private bool NDCDNCLNNAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private MeshRenderer OGIDBKLHIDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private BDOMDOHHPCC CDOMLPPBHBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private bool JNAOJHKOAGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private MeshRenderer FPGLLDADGGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private BDOMDOHHPCC MLJAHFALNGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private bool PNNKKFEBJEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private bool KABNGLCHEKD;

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x7B8ED0", Offset = "0x7B80D0", VA = "0x1807B8ED0")]
	public LCDCBLLGIFK(MCAKJFEAJKA NLDLABCIIJC, PHGBMAOMOKF BAOJLOCPMGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x69F4530", Offset = "0x69F3730", VA = "0x1869F4530", Slot = "23")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x69F4010", Offset = "0x69F3210", VA = "0x1869F4010")]
	private void DHIOLLKDPNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x69F58F0", Offset = "0x69F4AF0", VA = "0x1869F58F0", Slot = "4")]
	public void POBJLGLNAHM(GAANJEIKMIE MFIBAFBMCBA, NJFLAEHPIGP NBINPNLDMFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x69F5BF0", Offset = "0x69F4DF0", VA = "0x1869F5BF0", Slot = "5")]
	public void POBJLGLNAHM(JDJHKBJECJO NKFGLIJJHIJ, NJFLAEHPIGP NBINPNLDMFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x69F4E10", Offset = "0x69F4010", VA = "0x1869F4E10", Slot = "6")]
	public void KFONEHDFHBN(JDJHKBJECJO NKFGLIJJHIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x69F4770", Offset = "0x69F3970", VA = "0x1869F4770", Slot = "7")]
	public void FIFHGLCKHOF(JDJHKBJECJO NKFGLIJJHIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x69F5070", Offset = "0x69F4270", VA = "0x1869F5070", Slot = "24")]
	public void OMLDLIFPLCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x94B670", Offset = "0x94A870", VA = "0x18094B670", Slot = "8")]
	public void MDICGEOCKPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x69F4B70", Offset = "0x69F3D70", VA = "0x1869F4B70", Slot = "9")]
	public void HHPDIGOGFON(NJFLAEHPIGP NBINPNLDMFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x69F39E0", Offset = "0x69F2BE0", VA = "0x1869F39E0", Slot = "10")]
	public void CJNCNKGHHPP(GAANJEIKMIE MFIBAFBMCBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x69F3CC0", Offset = "0x69F2EC0", VA = "0x1869F3CC0", Slot = "11")]
	public void CJNCNKGHHPP(JDJHKBJECJO NKFGLIJJHIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x69F4CE0", Offset = "0x69F3EE0", VA = "0x1869F4CE0", Slot = "12")]
	public void INJLKCCBDPN(JDJHKBJECJO NKFGLIJJHIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x69F46E0", Offset = "0x69F38E0", VA = "0x1869F46E0", Slot = "13")]
	public void EIADOKGDACJ(JDJHKBJECJO NKFGLIJJHIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x69F4920", Offset = "0x69F3B20", VA = "0x1869F4920")]
	private void GDLLEJPFNLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x10C10D0", Offset = "0x10C02D0", VA = "0x1810C10D0", Slot = "14")]
	public void HEIDOMIMAIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x69F38C0", Offset = "0x69F2AC0", VA = "0x1869F38C0", Slot = "15")]
	public void BGLLDPGKOIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x69F4260", Offset = "0x69F3460", VA = "0x1869F4260", Slot = "16")]
	public void DNLHIJIFEMF(GAANJEIKMIE MFIBAFBMCBA, FACIIGAFJII MJMAEGDPBNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x69F4880", Offset = "0x69F3A80", VA = "0x1869F4880", Slot = "17")]
	public void FKCNCHOCAEJ(JDJHKBJECJO NKFGLIJJHIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x69F4D80", Offset = "0x69F3F80", VA = "0x1869F4D80", Slot = "18")]
	public void KBJKDMAGIOA(JDJHKBJECJO NKFGLIJJHIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x910DF0", Offset = "0x90FFF0", VA = "0x180910DF0", Slot = "19")]
	public void COOMKHHDCJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x69F4F40", Offset = "0x69F4140", VA = "0x1869F4F40", Slot = "20")]
	public void NGDBKOACFOD(FACIIGAFJII MJMAEGDPBNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x69F3660", Offset = "0x69F2860", VA = "0x1869F3660")]
	private void AFNLNACLADA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x69F5530", Offset = "0x69F4730", VA = "0x1869F5530", Slot = "21")]
	public void PAGMFFIBIOF(GAANJEIKMIE MFIBAFBMCBA, Vector3 BJMPJFAKGBA, Vector3 IMOIJNKOHNF, Vector3 MILKLCPBCJI, float NABBLMKCMAL, float BKMCFOHNALK, IReadOnlyList<Camera> LEPCAMDDLNN, KBDADMCHHJA HFHFGCMEBKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x69F50B0", Offset = "0x69F42B0", VA = "0x1869F50B0", Slot = "22")]
	public void PAGMFFIBIOF(GBFNOIADDPJ ONCDCCFIGLK, Vector3 BJMPJFAKGBA, Vector3 IMOIJNKOHNF, Vector3 MILKLCPBCJI, float NABBLMKCMAL, float BKMCFOHNALK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public abstract class FMOKCGCLILK : DHGKCDLLHHI, MKMNAFELPND, LNPEAAKGBPN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly BHPJBMLMACF NECEBBLCHMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	protected Bounds FLFKDCMFCLF;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public Bounds OHOAFKHBALF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0xEC98F0", Offset = "0xEC8AF0", VA = "0x180EC98F0", Slot = "4")]
		get
		{
			return default(Bounds);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public virtual KDKAKNKHEHB LCFPMOAODMI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x69EC7B0", Offset = "0x69EB9B0", VA = "0x1869EC7B0", Slot = "18")]
		get
		{
			return default(KDKAKNKHEHB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool BPIEMDKCOIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x880780", Offset = "0x87F980", VA = "0x180880780")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x95D8F0", Offset = "0x95CAF0", VA = "0x18095D8F0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	protected abstract Hash128 DPDJLLOJEDA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int IEIFGLKMLDI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x879D40", Offset = "0x878F40", VA = "0x180879D40", Slot = "10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public BEHJALGIBCP CIKBDFGMFFA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x7B7560", Offset = "0x7B6760", VA = "0x1807B7560")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x7B7530", Offset = "0x7B6730", VA = "0x1807B7530")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public bool EJFGMPCDEME
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x1290870", Offset = "0x128FA70", VA = "0x181290870")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x7C19B0", Offset = "0x7C0BB0", VA = "0x1807C19B0")]
	protected FMOKCGCLILK(BHPJBMLMACF MFIBAFBMCBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x69EC840", Offset = "0x69EBA40", VA = "0x1869EC840", Slot = "16")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x7FCE90", Offset = "0x7FC090", VA = "0x1807FCE90", Slot = "17")]
	public virtual bool HGMOMKHKADB(AFMLJEGJNBJ MFIBAFBMCBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "19")]
	public abstract int OCJCNDLHDAF(LJPLHCMPBCM MCCIEIKDMFF);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "20")]
	public abstract int GFKKECLIPBB(LJPLHCMPBCM MCCIEIKDMFF);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "21")]
	public abstract Bounds LFGCOBIKCAP();

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "22")]
	public abstract float ADGMCALGGAJ();

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "23")]
	public abstract void CABLHPEMLMA(LJPLHCMPBCM MCCIEIKDMFF, NGABOLFNHJB BAAPAGBCKHO, int FFEAEKCELAG = -1);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "24")]
	public abstract AFMLJEGJNBJ LGMEKIBGLBI();

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x69EC9A0", Offset = "0x69EBBA0", VA = "0x1869EC9A0", Slot = "12")]
	public Hash128 NJJNALMLALA(int MCCIEIKDMFF)
	{
		return default(Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "26")]
	public abstract MMCFFOPIKCK IBDCFKPAGMN();

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "27")]
	public abstract EFMBMEBALKM MKFNIBPOFHH(LJPLHCMPBCM MCCIEIKDMFF, JobHandle IFPDAOGJICE);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x69EC970", Offset = "0x69EBB70", VA = "0x1869EC970", Slot = "11")]
	public EFMBMEBALKM LCLCMGBKPNC(int MCCIEIKDMFF)
	{
		return null;
	}
}
namespace RecRoom.ShapeRendering
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class ShapeRendererConfig : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		public struct ShapeMeshConfigData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			[HideInInspector]
			public string EditorLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public Mesh[] Meshes;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public ShapeMeshConfigData[] MeshConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[Header("Bevels")]
		public float SmallBevelSizeMeters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public float RoundedBevelSizeMeters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public float BoxAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public float WedgeAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public float PyramidAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[Tooltip("Smaller dimensions will not exceed sqrt(bevel percent) percent")]
		public bool BevelSizeBasedOnLargestPossibleDimension;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public ComputeShader CopyBonesComputeShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public SkinnedShapeRenderer SkinnedRendererPrefab;

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x69F77C0", Offset = "0x69F69C0", VA = "0x1869F77C0")]
		public ShapeRendererConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class GFODJJEIPEK
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class BDDLJGEODMN : IEnumerable<JLLJPCCFDKK>, IEnumerable, IEnumerator<JLLJPCCFDKK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private JLLJPCCFDKK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private int <p>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private int <l>5__3;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		private JLLJPCCFDKK System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.PrimitiveShapeMeshData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x7B4160", Offset = "0x7B3360", VA = "0x1807B4160", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x7B4160", Offset = "0x7B3360", VA = "0x1807B4160", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x80AF90", Offset = "0x80A190", VA = "0x18080AF90")]
		[DebuggerHidden]
		public BDDLJGEODMN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x7B3620", Offset = "0x7B2820", VA = "0x1807B3620", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x69E5F20", Offset = "0x69E5120", VA = "0x1869E5F20", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x69E6090", Offset = "0x69E5290", VA = "0x1869E6090", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x69E5FF0", Offset = "0x69E51F0", VA = "0x1869E5FF0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<JLLJPCCFDKK> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.PrimitiveShapeMeshData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x69E5FF0", Offset = "0x69E51F0", VA = "0x1869E5FF0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private static JLLJPCCFDKK[][] HEGNMFJOIAE;

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private static CAIAAPKPAMM FCJKJPPFEDE;

	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public static ShapeRendererConfig FOHALGICABP;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public static ComputeShader EIHHLBGDGLD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x69EDE30", Offset = "0x69ED030", VA = "0x1869EDE30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public static SkinnedShapeRenderer HEIEHJLFCOO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x69EDE90", Offset = "0x69ED090", VA = "0x1869EDE90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x69EDF60", Offset = "0x69ED160", VA = "0x1869EDF60")]
	public static Mesh ECEBBHJGDHD(IIMLOMPLGMB FBBPLKFIDAN, int MCCIEIKDMFF = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x69EEB30", Offset = "0x69EDD30", VA = "0x1869EEB30")]
	public static int PPJCKIFJKJB(IIMLOMPLGMB FBBPLKFIDAN, int MCCIEIKDMFF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x69EE590", Offset = "0x69ED790", VA = "0x1869EE590")]
	public static CAIAAPKPAMM NMCJMJGNOLF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x69EDEF0", Offset = "0x69ED0F0", VA = "0x1869EDEF0")]
	[IteratorStateMachine(typeof(BDDLJGEODMN))]
	private static IEnumerable<JLLJPCCFDKK> BAJGHKHJDGM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x69EE6D0", Offset = "0x69ED8D0", VA = "0x1869EE6D0")]
	public static JLLJPCCFDKK NOKLNHHNFAM(IIMLOMPLGMB FBBPLKFIDAN, int MCCIEIKDMFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x69EE570", Offset = "0x69ED770", VA = "0x1869EE570")]
	public static bool LDBOGPLLIDO(this IIMLOMPLGMB FBBPLKFIDAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x69EE3C0", Offset = "0x69ED5C0", VA = "0x1869EE3C0")]
	public static void GNIEJIPDGCA(IIMLOMPLGMB FBBPLKFIDAN, float3 EDLCHFGMOFC, [Out] GBGANMJNOPB FNFDNMJGPEN, [Out] float3 PINAGPEECJG, [Out] float EHBDGFMKMLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x69EE000", Offset = "0x69ED200", VA = "0x1869EE000")]
	public static void GHLPOGHCPFD(Vector3 EDLCHFGMOFC, IIMLOMPLGMB FBBPLKFIDAN, [Out] Vector3 PINAGPEECJG, [Out] float EHBDGFMKMLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x69EDF50", Offset = "0x69ED150", VA = "0x1869EDF50")]
	[LHFECMPNHNO(0)]
	[LOEDIHPHLOK(JJHPCOMEMKL.ExitingPlayMode, 0)]
	private static void BJHGFJCDNHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x69EE970", Offset = "0x69EDB70", VA = "0x1869EE970")]
	[LOEDIHPHLOK(JJHPCOMEMKL.ExitingPlayMode, 0)]
	[LHFECMPNHNO(0)]
	private static void ONEGBFMIHKK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[DefaultMember("Item")]
public class NKHLJGLKLFN : GAFEFIOOPCM, IDisposable, PHGBMAOMOKF
{
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static readonly IOBNAOMELJK AOBMECMACLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly CELKONIIPPD<GAANJEIKMIE, BHPJBMLMACF> LKEHNDIFPBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly CELKONIIPPD<JDJHKBJECJO, FMOKCGCLILK> LLOMAPHPCBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly CELKONIIPPD<GBFNOIADDPJ, GCGIHEPIJBM> NINALAKHGBP;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public BHPJBMLMACF KFIAMJJGJCP
	{
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x69F6610", Offset = "0x69F5810", VA = "0x1869F6610", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public FMOKCGCLILK KFIAMJJGJCP
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x69F65B0", Offset = "0x69F57B0", VA = "0x1869F65B0", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public GCGIHEPIJBM KFIAMJJGJCP
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x69F6550", Offset = "0x69F5750", VA = "0x1869F6550", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool MBLIHEFFPPA
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x8F7890", Offset = "0x8F6A90", VA = "0x1808F7890", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x9EA2D0", Offset = "0x9E94D0", VA = "0x1809EA2D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x69F6A30", Offset = "0x69F5C30", VA = "0x1869F6A30")]
	public NKHLJGLKLFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x69F6280", Offset = "0x69F5480", VA = "0x1869F6280", Slot = "21")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x69F5F70", Offset = "0x69F5170", VA = "0x1869F5F70", Slot = "4")]
	public GAANJEIKMIE AEAKJKBBFOD(FHKDPKLBJJK MJGHOBDIDHD)
	{
		return default(GAANJEIKMIE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x69F5F70", Offset = "0x69F5170", VA = "0x1869F5F70", Slot = "5")]
	public GAANJEIKMIE AEAKJKBBFOD(FHKDPKLBJJK MJGHOBDIDHD, bool GNIGAIAOGDJ)
	{
		return default(GAANJEIKMIE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x69F6450", Offset = "0x69F5650", VA = "0x1869F6450", Slot = "6")]
	public void JPMKHNOEMEF(GAANJEIKMIE MFIBAFBMCBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x69F6890", Offset = "0x69F5A90", VA = "0x1869F6890", Slot = "7")]
	public void PKKPHGBDMNI(GAANJEIKMIE MFIBAFBMCBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x69F6010", Offset = "0x69F5210", VA = "0x1869F6010", Slot = "8")]
	public JDJHKBJECJO CDJDIHGCFIP(GAANJEIKMIE MFIBAFBMCBA, OMOAPGBLBBK MJGHOBDIDHD)
	{
		return default(JDJHKBJECJO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x69F66F0", Offset = "0x69F58F0", VA = "0x1869F66F0", Slot = "9")]
	public JDJHKBJECJO OCEDHBDOAGM(GAANJEIKMIE MFIBAFBMCBA, HJEAALBNHHM MJGHOBDIDHD)
	{
		return default(JDJHKBJECJO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x69F6150", Offset = "0x69F5350", VA = "0x1869F6150", Slot = "11")]
	public void DFJDIPCCBIA(JDJHKBJECJO NKFGLIJJHIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x69F6830", Offset = "0x69F5A30", VA = "0x1869F6830", Slot = "10")]
	public void PAFNHFCAIOD(JDJHKBJECJO NKFGLIJJHIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x69F63E0", Offset = "0x69F55E0", VA = "0x1869F63E0", Slot = "20")]
	public IEnumerable<Renderer> JNLLMAJHMNF(GAANJEIKMIE MFIBAFBMCBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x69F6670", Offset = "0x69F5870", VA = "0x1869F6670", Slot = "12")]
	public GBFNOIADDPJ NGJKBLIDMPK(DDEICIKGNFL MJGHOBDIDHD)
	{
		return default(GBFNOIADDPJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x69F6370", Offset = "0x69F5570", VA = "0x1869F6370", Slot = "14")]
	public void FJCDCKAIIIM(GBFNOIADDPJ ONCDCCFIGLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x69F61E0", Offset = "0x69F53E0", VA = "0x1869F61E0", Slot = "16")]
	public Task DJCJPAGLIEP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x69F64B0", Offset = "0x69F56B0", VA = "0x1869F64B0", Slot = "17")]
	public Task LNAFOBLMCGB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x69F6910", Offset = "0x69F5B10", VA = "0x1869F6910", Slot = "18")]
	public Task PMCKFLJGJKB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x1D2A730", Offset = "0x1D29930", VA = "0x181D2A730", Slot = "19")]
	public void KEFIGMCOOBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x69F6310", Offset = "0x69F5510", VA = "0x1869F6310", Slot = "13")]
	public void FDMHEBBLCJM(GBFNOIADDPJ ONCDCCFIGLK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface AJFGKMDMJMH
{
	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	bool ALJGHEEKGHE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Material IKCJMLNIJAC();

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Material AFFJPCJEMAH();

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Material KDELHMPLGFN();

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int ACONCHALGNP(LJFEFAMPPFH MJGOEAJIMBB);

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int OJIKFAGPGDL(FPEFJDMPECH JANHINCOMHB);

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void MDPPDDIPJKG(GameObject GLMGCMELGFD);

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void BCNKGDHHCKK(GameObject GLMGCMELGFD, bool NIOGBJAIBIC);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class AHILOMIMKPH
{
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static AJFGKMDMJMH HMEKKAINJCD;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public static bool ALJGHEEKGHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x69E5C60", Offset = "0x69E4E60", VA = "0x1869E5C60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x69E5ED0", Offset = "0x69E50D0", VA = "0x1869E5ED0")]
	public static void OMELMHEJICP(AJFGKMDMJMH DKFBKIIFAKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x69E5CC0", Offset = "0x69E4EC0", VA = "0x1869E5CC0")]
	public static Material IKCJMLNIJAC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x69E5B20", Offset = "0x69E4D20", VA = "0x1869E5B20")]
	public static Material AFFJPCJEMAH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x69E5D20", Offset = "0x69E4F20", VA = "0x1869E5D20")]
	public static Material KDELHMPLGFN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x69E5AB0", Offset = "0x69E4CB0", VA = "0x1869E5AB0")]
	public static int ACONCHALGNP(LJFEFAMPPFH MJGOEAJIMBB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x69E5E60", Offset = "0x69E5060", VA = "0x1869E5E60")]
	public static int OJIKFAGPGDL(FPEFJDMPECH JANHINCOMHB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x69E5D80", Offset = "0x69E4F80", VA = "0x1869E5D80")]
	public static void MDPPDDIPJKG(GameObject GLMGCMELGFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x69E5B80", Offset = "0x69E4D80", VA = "0x1869E5B80")]
	public static void BCNKGDHHCKK(GameObject GLMGCMELGFD, bool NIOGBJAIBIC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class GCGIHEPIJBM : LDBLLJMEEFH
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class EJEOPOLAPHC : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private Renderer <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public GCGIHEPIJBM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x7B4160", Offset = "0x7B3360", VA = "0x1807B4160", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x7B4160", Offset = "0x7B3360", VA = "0x1807B4160", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x80AF90", Offset = "0x80A190", VA = "0x18080AF90")]
		[DebuggerHidden]
		public EJEOPOLAPHC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x69E9690", Offset = "0x69E8890", VA = "0x1869E9690", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x69E9370", Offset = "0x69E8570", VA = "0x1869E9370", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x69E9320", Offset = "0x69E8520", VA = "0x1869E9320")]
		private void KNOPPBKNOBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x69E9640", Offset = "0x69E8840", VA = "0x1869E9640", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x69E9590", Offset = "0x69E8790", VA = "0x1869E9590", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x69E9590", Offset = "0x69E8790", VA = "0x1869E9590", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private readonly DDEICIKGNFL ILDPCCIMOID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private readonly PHGBMAOMOKF BAOJLOCPMGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private JLMGDMJJKLF HCHEPLDAFBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private List<EBNEHDGPCOG> GAPHPJOKHPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private List<EBNEHDGPCOG> BEEMMALDOEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private GameObject LFOJIENLFCH;

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x69ED9B0", Offset = "0x69ECBB0", VA = "0x1869ED9B0")]
	public static GCGIHEPIJBM JKKJCIOOCAJ(DDEICIKGNFL MJGHOBDIDHD, PHGBMAOMOKF BAOJLOCPMGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x69EDD50", Offset = "0x69ECF50", VA = "0x1869EDD50")]
	private GCGIHEPIJBM(DDEICIKGNFL MJGHOBDIDHD, PHGBMAOMOKF BAOJLOCPMGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x69ED530", Offset = "0x69EC730", VA = "0x1869ED530")]
	public void FMINDOPCMII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x69ED4B0", Offset = "0x69EC6B0", VA = "0x1869ED4B0")]
	[IteratorStateMachine(typeof(EJEOPOLAPHC))]
	public IEnumerable<Renderer> DONGCAPLOMG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x69EC9D0", Offset = "0x69EBBD0", VA = "0x1869EC9D0", Slot = "4")]
	public void BLEBCABFAOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x69ED480", Offset = "0x69EC680", VA = "0x1869ED480")]
	private void DCAHDMLEFCI(Vector3 FHMICDCPNGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x69EDB00", Offset = "0x69ECD00", VA = "0x1869EDB00")]
	public void MOLHGBBEJOJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class EBNEHDGPCOG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private struct JOEGAEKMJIO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public NGABOLFNHJB KHBFIGONKJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public AFMLJEGJNBJ OOCCPJBHMLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public int HMAMLLFGODC;
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class FGLNHFADPAA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public EBNEHDGPCOG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public int numVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public int numIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public LJPLHCMPBCM lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public List<JOEGAEKMJIO> boneMeshInfos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public FEEDCIOJNFD combinedMesh;

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
		public FGLNHFADPAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x69E9E20", Offset = "0x69E9020", VA = "0x1869E9E20")]
		internal JobHandle GKHFFIHJBKA()
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x69E9DF0", Offset = "0x69E8FF0", VA = "0x1869E9DF0")]
		internal void EHOPPBADEDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x69E9C80", Offset = "0x69E8E80", VA = "0x1869E9C80")]
		internal void DFLDMGIOADD()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private int[] DPKEAHPBMOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private MIJMPOGKIMM CIKPAHIGODJ;

	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private static Matrix4x4 KBCMNCDEGFM;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public Mesh ADAAJOKAAFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x7B4140", Offset = "0x7B3340", VA = "0x1807B4140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x7B4120", Offset = "0x7B3320", VA = "0x1807B4120")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public int OLOLPMMJCCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x7B8F20", Offset = "0x7B8120", VA = "0x1807B8F20")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x7B9670", Offset = "0x7B8870", VA = "0x1807B9670")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x69E8030", Offset = "0x69E7230", VA = "0x1869E8030")]
	public void CFOHPONHAAI(List<AFMLJEGJNBJ> PCCFBLKLJDE, Matrix4x4[] OHIPKDDIODG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x69E8210", Offset = "0x69E7410", VA = "0x1869E8210")]
	public static List<EBNEHDGPCOG> DMOLILFLBFL(List<BHPJBMLMACF> JFAPECDHEKC, LJPLHCMPBCM MCCIEIKDMFF, Bounds HEHPMCCLDKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x69E8A10", Offset = "0x69E7C10", VA = "0x1869E8A10")]
	private JobHandle KFOBMLBAJPH(FEEDCIOJNFD FFBGDFDEJOJ, int FBKLIOFGODI, int JAPDIMAHDHK, LJPLHCMPBCM MCCIEIKDMFF, List<JOEGAEKMJIO> NKCMHIKFKKP)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x69E88A0", Offset = "0x69E7AA0", VA = "0x1869E88A0")]
	private void DOCNPBCIIAC(List<JOEGAEKMJIO> NKCMHIKFKKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x69E8F00", Offset = "0x69E8100", VA = "0x1869E8F00")]
	private EBNEHDGPCOG(List<JOEGAEKMJIO> NKCMHIKFKKP, int FBKLIOFGODI, int JAPDIMAHDHK, LJPLHCMPBCM MCCIEIKDMFF, Bounds HEHPMCCLDKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x69E8980", Offset = "0x69E7B80", VA = "0x1869E8980", Slot = "4")]
	public void Dispose()
	{
	}
}
namespace RecRoom.ShapeRendering
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class SkinnedShapeRenderer : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private MaterialPropertyBlock FCPLMPFNLOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private EBNEHDGPCOG PLFOEDLJILP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private List<AFMLJEGJNBJ> AICGOEIIJJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private RenderTexture PBDCKHHLGAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private ComputeBuffer GPGGNHCOANK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private ComputeShader APCMOGOCMMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private Matrix4x4[] GOMDCBIDIFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private int KCBHBCMNKJB;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public MeshRenderer JLCILBAIOAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x7B4160", Offset = "0x7B3360", VA = "0x1807B4160")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x7B40F0", Offset = "0x7B32F0", VA = "0x1807B40F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public int JJCMHDJOMLC
		{
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x69F8520", Offset = "0x69F7720", VA = "0x1869F8520")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x69F7B60", Offset = "0x69F6D60", VA = "0x1869F7B60")]
		public static List<SkinnedShapeRenderer> Create(GameObject MFIBAFBMCBA, List<EBNEHDGPCOG> PHDIIJOJFNC, List<AFMLJEGJNBJ> AICGOEIIJJM, Material ODNKEDBIBDH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x69F7E50", Offset = "0x69F7050", VA = "0x1869F7E50")]
		public void Init(EBNEHDGPCOG PLFOEDLJILP, List<AFMLJEGJNBJ> AICGOEIIJJM, Material ODNKEDBIBDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x69F8480", Offset = "0x69F7680", VA = "0x1869F8480")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x69F83E0", Offset = "0x69F75E0", VA = "0x1869F83E0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x69F83A0", Offset = "0x69F75A0", VA = "0x1869F83A0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x69F82E0", Offset = "0x69F74E0", VA = "0x1869F82E0")]
		private void JAPDLOJLJBE(ScriptableRenderContext DPGBKIGAHAN, Camera[] GGNGAHFGLEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x69F77F0", Offset = "0x69F69F0", VA = "0x1869F77F0")]
		private void CFOHPONHAAI(CommandBuffer PLCLLNHOEDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x7B5BE0", Offset = "0x7B4DE0", VA = "0x1807B5BE0")]
		public SkinnedShapeRenderer()
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
