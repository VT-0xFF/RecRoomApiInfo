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
using RecRoom.ShapeRendering;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Rendering;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[DefaultMember("Item")]
public interface NAIOGIJNOEH
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	OCDJKLPJODF JOJAFGMMIDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	GJBHHHLOMOE JOJAFGMMIDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	KGCOILOMCLD JOJAFGMMIDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class CHLNEHAEPJE : EECPDIMAJPG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private byte DGJEIJJIFJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly List<SkinnedShapeRenderer>[] PBBCMKBLHLI;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int FKHDLDCFJFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8B2840", Offset = "0x8B1A40", VA = "0x1808B2840", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x9298F0", Offset = "0x928AF0", VA = "0x1809298F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int ECNAIBCMDCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8B1370", Offset = "0x8B0570", VA = "0x1808B1370", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x9298D0", Offset = "0x928AD0", VA = "0x1809298D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public float FBJOKNMFBMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xB6EE10", Offset = "0xB6E010", VA = "0x180B6EE10", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xB6EB50", Offset = "0xB6DD50", VA = "0x180B6EB50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public float GGGCJELNMKE
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x10F9730", Offset = "0x10F8930", VA = "0x1810F9730", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x10F97C0", Offset = "0x10F89C0", VA = "0x1810F97C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public List<SkinnedShapeRenderer> PENOHCFOGPH
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5EDC420", Offset = "0x5EDB620", VA = "0x185EDC420")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public List<SkinnedShapeRenderer> ADCKIEPGOFG
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5EDC160", Offset = "0x5EDB360", VA = "0x185EDC160")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public GameObject NMFNLMEMDBG
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x890860", Offset = "0x88FA60", VA = "0x180890860")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8D3DD0", Offset = "0x8D2FD0", VA = "0x1808D3DD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public byte HNFKDGLLMBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5EDC480", Offset = "0x5EDB680", VA = "0x185EDC480", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5EDC6C0", Offset = "0x5EDB8C0", VA = "0x185EDC6C0")]
	public CHLNEHAEPJE(List<BNDFGBKNKGO> FLNACEICOPK, List<BNDFGBKNKGO> MDBOPHKEHBH, List<HCKALGFFMDC> DAHOGDMPGBB, Material GMJJKHGKCAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5EDC4D0", Offset = "0x5EDB6D0", VA = "0x185EDC4D0")]
	private int HOGAOHMEJEJ(List<BNDFGBKNKGO> KPAFIAIKPMC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5EDC1A0", Offset = "0x5EDB3A0", VA = "0x185EDC1A0")]
	private void BEPFBBFCJPK(int GALEGPFLAPC, bool GMKKJGOMPLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5EDC620", Offset = "0x5EDB820", VA = "0x185EDC620")]
	public void OGENOJINDLP(Vector3 HFONEINEIGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5EDC2F0", Offset = "0x5EDB4F0", VA = "0x185EDC2F0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5EDC5E0", Offset = "0x5EDB7E0", VA = "0x185EDC5E0")]
	public void IENNIKGCHJP(Transform ODIBJJHFKML)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
internal class AJOEFKJADDL : GJBHHHLOMOE
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	private struct IPEGHFBDMHF : KPJPPHCAEEE, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private PKDAECFHHCE BNHDDEIBJPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private JobHandle FHGDOMMIJLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private MKLCOHFMPKK OICLJHELJBL;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x5EDFAA0", Offset = "0x5EDECA0", VA = "0x185EDFAA0")]
		public IPEGHFBDMHF(PKDAECFHHCE BNHDDEIBJPG, JobHandle FHGDOMMIJLE, MKLCOHFMPKK OICLJHELJBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5EDFA70", Offset = "0x5EDEC70", VA = "0x185EDFA70", Slot = "4")]
		public PKDAECFHHCE OJAKBINLFPA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5EDFA20", Offset = "0x5EDEC20", VA = "0x185EDFA20", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly OHHKPPKECEG LEHIJMHIJLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private int[] KCONAFODBAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private Hash128 LFHGPEHDBNK;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override LMLBNBMDBKO LKCGMOMFLLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5EDA440", Offset = "0x5ED9640", VA = "0x185EDA440", Slot = "16")]
		get
		{
			return default(LMLBNBMDBKO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private Vector3 CBHONPKIFGN
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5EDA930", Offset = "0x5ED9B30", VA = "0x185EDA930")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	protected override Hash128 IGLBFAMLIPN
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5EDA810", Offset = "0x5ED9A10", VA = "0x185EDA810", Slot = "21")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5EDAD40", Offset = "0x5ED9F40", VA = "0x185EDAD40")]
	public AJOEFKJADDL(OCDJKLPJODF MKADPIPCNMO, OHHKPPKECEG JFGIPFOFKHL, bool FMFHBIKCPEJ = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5ED9200", Offset = "0x5ED8400", VA = "0x185ED9200", Slot = "15")]
	public override bool CCADANBDDAM(HCKALGFFMDC MKADPIPCNMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5EDA390", Offset = "0x5ED9590", VA = "0x185EDA390", Slot = "17")]
	public override int HOGAOHMEJEJ(HCDDACOAFJC HFMGLEOIGIG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5ED9E00", Offset = "0x5ED9000", VA = "0x185ED9E00", Slot = "18")]
	public override int EHOMEJPJEHH(HCDDACOAFJC HFMGLEOIGIG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5ED9EB0", Offset = "0x5ED90B0", VA = "0x185ED9EB0")]
	private int FLHEKOHBMFO(HCDDACOAFJC HFMGLEOIGIG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5ED9670", Offset = "0x5ED8870", VA = "0x185ED9670", Slot = "19")]
	public override void DABMOBMHDAB(HCDDACOAFJC HFMGLEOIGIG, OGBJFEMDOMJ AFHELHLEMFN, int EEEBJPENFPC = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5EDAC70", Offset = "0x5ED9E70", VA = "0x185EDAC70", Slot = "20")]
	public override HCKALGFFMDC PPPHIBONNGL()
	{
		return default(HCKALGFFMDC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5EDA170", Offset = "0x5ED9370", VA = "0x185EDA170", Slot = "22")]
	public override ELNHKDKCLHF FPIFKOGNLDK()
	{
		return default(ELNHKDKCLHF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5ED89E0", Offset = "0x5ED7BE0", VA = "0x185ED89E0", Slot = "23")]
	public override KPJPPHCAEEE BBBPKIGPKCG(HCDDACOAFJC HFMGLEOIGIG, JobHandle FHGDOMMIJLE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class OCDJKLPJODF : CMMIBNNOCGE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class FDKJLKDBLHG : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private Renderer <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public OCDJKLPJODF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private List<ClusterMeshRenderer>.Enumerator <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private ClusterMeshRenderer <c>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private IEnumerator<Renderer> <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private Renderer <r>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private IEnumerator<MeshRenderer> <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private MeshRenderer <b>5__6;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x7EBAF0", Offset = "0x7EACF0", VA = "0x1807EBAF0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x7EBAF0", Offset = "0x7EACF0", VA = "0x1807EBAF0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xA122A0", Offset = "0xA114A0", VA = "0x180A122A0")]
		[DebuggerHidden]
		public FDKJLKDBLHG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x5EDD180", Offset = "0x5EDC380", VA = "0x185EDD180", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x5EDCB70", Offset = "0x5EDBD70", VA = "0x185EDCB70", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x5EDCAD0", Offset = "0x5EDBCD0", VA = "0x185EDCAD0")]
		private void DNBEPMOBGPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x5EDD050", Offset = "0x5EDC250", VA = "0x185EDD050")]
		private void OGHDDOHNOGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x5EDCB20", Offset = "0x5EDBD20", VA = "0x185EDCB20")]
		private void EBCHNDNOFOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x5EDD140", Offset = "0x5EDC340", VA = "0x185EDD140", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x5EDD0A0", Offset = "0x5EDC2A0", VA = "0x185EDD0A0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x5EDD0A0", Offset = "0x5EDC2A0", VA = "0x185EDD0A0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class JJIGGMKGBHD : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private Renderer <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public OCDJKLPJODF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private IEnumerator<Renderer> <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private Renderer <r>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private List<SkinnedShapeRenderer>.Enumerator <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private SkinnedShapeRenderer <b>5__4;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x7EBAF0", Offset = "0x7EACF0", VA = "0x1807EBAF0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x7EBAF0", Offset = "0x7EACF0", VA = "0x1807EBAF0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xA122A0", Offset = "0xA114A0", VA = "0x180A122A0")]
		[DebuggerHidden]
		public JJIGGMKGBHD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x5EDFFB0", Offset = "0x5EDF1B0", VA = "0x185EDFFB0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x5EDFB40", Offset = "0x5EDED40", VA = "0x185EDFB40", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x5EDFAF0", Offset = "0x5EDECF0", VA = "0x185EDFAF0")]
		private void DNBEPMOBGPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x5EDFE80", Offset = "0x5EDF080", VA = "0x185EDFE80")]
		private void OGHDDOHNOGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x5EDFF70", Offset = "0x5EDF170", VA = "0x185EDFF70", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x5EDFED0", Offset = "0x5EDF0D0", VA = "0x185EDFED0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x5EDFED0", Offset = "0x5EDF0D0", VA = "0x185EDFED0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly GPFKOIGOAJP LCJFJCHKPIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly List<GJBHHHLOMOE> BJFDLBAAIMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private List<ClusterMeshRenderer> HFLHIPDNPCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private BatchedMeshRenderer ILOBDGNEHBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private bool ICKHDAOCNDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly bool HNEBIGMCAJM;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IEnumerable<AEJINIDDPDG> KGAOGLJMHBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7EBAF0", Offset = "0x7EACF0", VA = "0x1807EBAF0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int LOGKBGDEOOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x5EE6250", Offset = "0x5EE5450", VA = "0x185EE6250", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public HCKALGFFMDC POGHLKBPCLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x5EE70A0", Offset = "0x5EE62A0", VA = "0x185EE70A0", Slot = "8")]
		get
		{
			return default(HCKALGFFMDC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public List<SkinnedShapeRenderer> JDBALFOBEFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x89B300", Offset = "0x89A500", VA = "0x18089B300")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x89B1F0", Offset = "0x89A3F0", VA = "0x18089B1F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5EE6E90", Offset = "0x5EE6090", VA = "0x185EE6E90")]
	private bool GBPHGKEAJNI(GJBHHHLOMOE BFCABOCHBCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5EE6EC0", Offset = "0x5EE60C0", VA = "0x185EE6EC0")]
	private static bool GDNNGGDGFGE(GJBHHHLOMOE BFCABOCHBCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5EE7990", Offset = "0x5EE6B90", VA = "0x185EE7990")]
	public OCDJKLPJODF(GPFKOIGOAJP JFGIPFOFKHL, bool KBEDJILCCGB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5EE6530", Offset = "0x5EE5730", VA = "0x185EE6530", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5EE6300", Offset = "0x5EE5500", VA = "0x185EE6300")]
	public void CKPKOIJGHLD(GJBHHHLOMOE BFCABOCHBCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5EE6F70", Offset = "0x5EE6170", VA = "0x185EE6F70")]
	public void HCICIMHFKFM(GJBHHHLOMOE BFCABOCHBCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5EE74F0", Offset = "0x5EE66F0", VA = "0x185EE74F0", Slot = "4")]
	public void PHAPLECIJJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5EE7160", Offset = "0x5EE6360", VA = "0x185EE7160")]
	public void KGILAIAHHCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5EE66B0", Offset = "0x5EE58B0", VA = "0x185EE66B0")]
	private void EFEOMCAACAM(List<GJBHHHLOMOE> BJFDLBAAIMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5EE73B0", Offset = "0x5EE65B0", VA = "0x185EE73B0")]
	private static Material MMEEDHFAFLI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5EE6840", Offset = "0x5EE5A40", VA = "0x185EE6840")]
	private void EFEOMCAACAM(GJBHHHLOMOE BFCABOCHBCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5EE7410", Offset = "0x5EE6610", VA = "0x185EE7410")]
	private void PBCBGDKCOGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5EE68E0", Offset = "0x5EE5AE0", VA = "0x185EE68E0")]
	public void FFPDPEBALJB(bool BCNBBBCGGOI, bool JELDCKFFEKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5EE6EE0", Offset = "0x5EE60E0", VA = "0x185EE6EE0")]
	protected void GIJFCFDNKEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5EE61E0", Offset = "0x5EE53E0", VA = "0x185EE61E0")]
	[IteratorStateMachine(typeof(FDKJLKDBLHG))]
	public IEnumerable<Renderer> AFPEBGGIDPN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5EE6290", Offset = "0x5EE5490", VA = "0x185EE6290")]
	[IteratorStateMachine(typeof(JJIGGMKGBHD))]
	public IEnumerable<Renderer> CKODPBKCGDF()
	{
		return null;
	}
}
namespace RecRoom.ShapeRendering
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class ShapeRendererConfig : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public struct ShapeMeshConfigData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			[HideInInspector]
			public string EditorLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public Mesh[] Meshes;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public ShapeMeshConfigData[] MeshConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		[Header("Bevels")]
		public float SmallBevelSizeMeters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public float RoundedBevelSizeMeters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public float BoxAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public float WedgeAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public float PyramidAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		[Tooltip("Smaller dimensions will not exceed sqrt(bevel percent) percent")]
		public bool BevelSizeBasedOnLargestPossibleDimension;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public ComputeShader CopyBonesComputeShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public SkinnedShapeRenderer SkinnedRendererPrefab;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x5EE89B0", Offset = "0x5EE7BB0", VA = "0x185EE89B0")]
		public ShapeRendererConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[DefaultMember("Item")]
public class OGFHNNFFPNJ : CADEDIIOKBN, IDisposable, NAIOGIJNOEH
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static readonly PEKDFCFCENH LHCMKIAHBCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly KAELLJOCCLI<LIIJACJPKCA, OCDJKLPJODF> OFNHBJAMLID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly KAELLJOCCLI<NBKCBPOCILE, GJBHHHLOMOE> BJFDLBAAIMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly KAELLJOCCLI<FAIOOLDBMIH, KGCOILOMCLD> NGAJFHFFHDL;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public OCDJKLPJODF JOJAFGMMIDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x5EE8210", Offset = "0x5EE7410", VA = "0x185EE8210", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public GJBHHHLOMOE JOJAFGMMIDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x5EE82D0", Offset = "0x5EE74D0", VA = "0x185EE82D0", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public KGCOILOMCLD JOJAFGMMIDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x5EE8270", Offset = "0x5EE7470", VA = "0x185EE8270", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public bool MNEIBBJIFKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x7EBAC0", Offset = "0x7EACC0", VA = "0x1807EBAC0", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x7EB9E0", Offset = "0x7EABE0", VA = "0x1807EB9E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5EE84F0", Offset = "0x5EE76F0", VA = "0x185EE84F0")]
	public OGFHNNFFPNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5EE7C50", Offset = "0x5EE6E50", VA = "0x185EE7C50", Slot = "21")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5EE7B40", Offset = "0x5EE6D40", VA = "0x185EE7B40", Slot = "4")]
	public LIIJACJPKCA DADOIDGEKJB(GPFKOIGOAJP JFGIPFOFKHL)
	{
		return default(LIIJACJPKCA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5EE7B40", Offset = "0x5EE6D40", VA = "0x185EE7B40", Slot = "5")]
	public LIIJACJPKCA DADOIDGEKJB(GPFKOIGOAJP JFGIPFOFKHL, bool KBEDJILCCGB)
	{
		return default(LIIJACJPKCA);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5EE8400", Offset = "0x5EE7600", VA = "0x185EE8400", Slot = "6")]
	public void PCCMKKHECEE(LIIJACJPKCA MKADPIPCNMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5EE7CE0", Offset = "0x5EE6EE0", VA = "0x185EE7CE0", Slot = "7")]
	public void EFCGFHJBBNI(LIIJACJPKCA MKADPIPCNMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5EE8070", Offset = "0x5EE7270", VA = "0x185EE8070", Slot = "8")]
	public NBKCBPOCILE JCGKHHMPMLF(LIIJACJPKCA MKADPIPCNMO, OHHKPPKECEG JFGIPFOFKHL)
	{
		return default(NBKCBPOCILE);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5EE7DC0", Offset = "0x5EE6FC0", VA = "0x185EE7DC0", Slot = "9")]
	public NBKCBPOCILE FFLCAEMPDAA(LIIJACJPKCA MKADPIPCNMO, EIJJFHIOKKF JFGIPFOFKHL)
	{
		return default(NBKCBPOCILE);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5EE7FE0", Offset = "0x5EE71E0", VA = "0x185EE7FE0", Slot = "11")]
	public void IHEKHNPMIHM(NBKCBPOCILE BFCABOCHBCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5EE7D60", Offset = "0x5EE6F60", VA = "0x185EE7D60", Slot = "10")]
	public void EOMPADKAHCI(NBKCBPOCILE BFCABOCHBCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x5EE8390", Offset = "0x5EE7590", VA = "0x185EE8390", Slot = "20")]
	public IEnumerable<Renderer> OFOCDBBCMDE(LIIJACJPKCA MKADPIPCNMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5EE7F60", Offset = "0x5EE7160", VA = "0x185EE7F60", Slot = "12")]
	public FAIOOLDBMIH IFILIFEBMHO(PPCHLICLNCA JFGIPFOFKHL)
	{
		return default(FAIOOLDBMIH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5EE81A0", Offset = "0x5EE73A0", VA = "0x185EE81A0", Slot = "14")]
	public void JGDNGJFANDM(FAIOOLDBMIH ANAPJIFAFBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x5EE7AE0", Offset = "0x5EE6CE0", VA = "0x185EE7AE0", Slot = "16")]
	public Task CFABGMCGBPA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5EE7A80", Offset = "0x5EE6C80", VA = "0x185EE7A80", Slot = "17")]
	public Task AGKKACJKDKN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5EE7F00", Offset = "0x5EE7100", VA = "0x185EE7F00", Slot = "18")]
	public Task HJIKKLIJLEC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x2A53140", Offset = "0x2A52340", VA = "0x182A53140", Slot = "19")]
	public void PFIFIALJHAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5EE8330", Offset = "0x5EE7530", VA = "0x185EE8330", Slot = "13")]
	public void NCGPDIBECBC(FAIOOLDBMIH ANAPJIFAFBP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface EDOAAGPDPDB
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OBCIOKPJJNO(LLKOGLCAJBN FBNKHAJKFLM, Renderer DENAECCDCEI, int LIEKIEFOOGL);

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GOMCIFJOIDP(Renderer DENAECCDCEI, OCJBCNFPLFL GOBLNCJKDHH, Vector3 NADAIPAFPDB, Vector3 LHJAPLFOAFA, Vector3 DMHEJHIIGAK, float HAKMPNFEKBO, float JLKNBHOEMJN, float EONAPEOJBKN = -1f, [Optional] Color? GGJPGIMIKJF, [Optional] IReadOnlyList<Camera> EAFKGLHBKCB);

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OHKLNDKKLOO(Renderer DENAECCDCEI, int LIEKIEFOOGL);

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int FNJBAEGLLEG();

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GGEKEGHOBBI(int CGIFEHPMNJO, BLPFGIECEBB FBNKHAJKFLM, Renderer DENAECCDCEI, int LIEKIEFOOGL);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class GIDGFDKKEPJ : CEFCOHEOOAA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private class CMMEOANDDBM : AOOLOOEFJNG<int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x5EDCA80", Offset = "0x5EDBC80", VA = "0x185EDCA80")]
		public CMMEOANDDBM(string JPKENOAMLIN)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly EDOAAGPDPDB CLBGHIGEANA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly NAIOGIJNOEH GMDFDKMGPHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private MeshRenderer LNAIELLKEJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private CMMEOANDDBM DJADABJMMNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private bool CMDMICGNING;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private MeshRenderer HOLGCNFEBEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private CMMEOANDDBM EDAJOAHIDKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private bool OFEMEDFNJLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private MeshRenderer HINDLGNCIGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private CMMEOANDDBM MIIBMAAMHIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private bool OLAIFPCFFLF;

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5EDF7B0", Offset = "0x5EDE9B0", VA = "0x185EDF7B0")]
	public GIDGFDKKEPJ(EDOAAGPDPDB KLKDDONILKP, NAIOGIJNOEH GMDFDKMGPHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5EDE490", Offset = "0x5EDD690", VA = "0x185EDE490", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5EDED80", Offset = "0x5EDDF80", VA = "0x185EDED80")]
	private void NMMMFFPOMPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x5EDDDD0", Offset = "0x5EDCFD0", VA = "0x185EDDDD0", Slot = "4")]
	public void AJPLPMNFDKG(LIIJACJPKCA MKADPIPCNMO, BLPFGIECEBB DPBBKDNKPAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x5EDDFD0", Offset = "0x5EDD1D0", VA = "0x185EDDFD0", Slot = "5")]
	public void AJPLPMNFDKG(NBKCBPOCILE BFCABOCHBCH, BLPFGIECEBB DPBBKDNKPAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x5EDE1F0", Offset = "0x5EDD3F0", VA = "0x185EDE1F0", Slot = "6")]
	public void CFGGDOBJDAH(NBKCBPOCILE BFCABOCHBCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x5EDE6A0", Offset = "0x5EDD8A0", VA = "0x185EDE6A0", Slot = "7")]
	public void HNEALBBOEJJ(NBKCBPOCILE BFCABOCHBCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x5EDE660", Offset = "0x5EDD860", VA = "0x185EDE660", Slot = "21")]
	public void EIAHGOKHDMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x127D6B0", Offset = "0x127C8B0", VA = "0x18127D6B0", Slot = "8")]
	public void FFMMPKDOGCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x5EDE320", Offset = "0x5EDD520", VA = "0x185EDE320", Slot = "9")]
	public void DDDOADKFBGJ(BLPFGIECEBB DPBBKDNKPAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x5EDF2B0", Offset = "0x5EDE4B0", VA = "0x185EDF2B0", Slot = "10")]
	public void OPCNLGHJCNH(LIIJACJPKCA MKADPIPCNMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5EDF460", Offset = "0x5EDE660", VA = "0x185EDF460", Slot = "11")]
	public void OPCNLGHJCNH(NBKCBPOCILE BFCABOCHBCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5EDEA50", Offset = "0x5EDDC50", VA = "0x185EDEA50", Slot = "12")]
	public void JFKKLHABBGC(LIIJACJPKCA MKADPIPCNMO, LLKOGLCAJBN FBNKHAJKFLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x5EDE860", Offset = "0x5EDDA60", VA = "0x185EDE860", Slot = "13")]
	public void JFKKLHABBGC(NBKCBPOCILE BFCABOCHBCH, LLKOGLCAJBN FBNKHAJKFLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x5EDEC00", Offset = "0x5EDDE00", VA = "0x185EDEC00", Slot = "22")]
	public void JJAHBOGNFOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x5EDE7C0", Offset = "0x5EDD9C0", VA = "0x185EDE7C0", Slot = "14")]
	public void JABMBLBMDLE(NBKCBPOCILE BFCABOCHBCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x5EDEFD0", Offset = "0x5EDE1D0", VA = "0x185EDEFD0", Slot = "15")]
	public void NNFGHPMLFGD(NBKCBPOCILE BFCABOCHBCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0xD134C0", Offset = "0xD126C0", VA = "0x180D134C0", Slot = "16")]
	public void LHFIIHFDKPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x5EDEC40", Offset = "0x5EDDE40", VA = "0x185EDEC40", Slot = "17")]
	public void KDDJBIAEBPH(LLKOGLCAJBN FBNKHAJKFLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x5EDF060", Offset = "0x5EDE260", VA = "0x185EDF060")]
	private void OJGLBCLKEOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x5EDDA60", Offset = "0x5EDCC60", VA = "0x185EDDA60", Slot = "18")]
	public void ACAJBFLGJNK(LIIJACJPKCA MKADPIPCNMO, Vector3 NADAIPAFPDB, Vector3 LHJAPLFOAFA, Vector3 DMHEJHIIGAK, float HAKMPNFEKBO, float JLKNBHOEMJN, IReadOnlyList<Camera> FNJMMEKCNDG, OCJBCNFPLFL GOBLNCJKDHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x5EDD660", Offset = "0x5EDC860", VA = "0x185EDD660", Slot = "19")]
	public void ACAJBFLGJNK(FAIOOLDBMIH ANAPJIFAFBP, Vector3 NADAIPAFPDB, Vector3 LHJAPLFOAFA, Vector3 DMHEJHIIGAK, float HAKMPNFEKBO, float JLKNBHOEMJN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class AHMOJLDJOAD
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class JKHCPOEFMMF : IEnumerable<PDKLMPLPPNP>, IEnumerable, IEnumerator<PDKLMPLPPNP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private PDKLMPLPPNP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private int <p>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private int <l>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		private PDKLMPLPPNP System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.PrimitiveShapeMeshData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x7EBAF0", Offset = "0x7EACF0", VA = "0x1807EBAF0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x7EBAF0", Offset = "0x7EACF0", VA = "0x1807EBAF0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xA122A0", Offset = "0xA114A0", VA = "0x180A122A0")]
		[DebuggerHidden]
		public JKHCPOEFMMF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x5EE0090", Offset = "0x5EDF290", VA = "0x185EE0090", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x5EE0200", Offset = "0x5EDF400", VA = "0x185EE0200", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x5EE0170", Offset = "0x5EDF370", VA = "0x185EE0170", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<PDKLMPLPPNP> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.PrimitiveShapeMeshData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x5EE0170", Offset = "0x5EDF370", VA = "0x185EE0170", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private static PDKLMPLPPNP[][] AMAGMEBDFJD;

	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private static ENHOHHNNCDO JHKPFHFNEAE;

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public static ShapeRendererConfig HMDNLIAGOBB;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public static ComputeShader POCEMNPIHDN
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x5ED7D50", Offset = "0x5ED6F50", VA = "0x185ED7D50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public static SkinnedShapeRenderer FMLOILLMJGC
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x5ED8150", Offset = "0x5ED7350", VA = "0x185ED8150")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x5ED7AE0", Offset = "0x5ED6CE0", VA = "0x185ED7AE0")]
	public static Mesh BMICPECBLEI(JFNHOKLDIOK COLHOCMIMJN, int HFMGLEOIGIG = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x5ED8240", Offset = "0x5ED7440", VA = "0x185ED8240")]
	public static int NCBDMOBNDFB(JFNHOKLDIOK COLHOCMIMJN, int HFMGLEOIGIG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x5ED7FF0", Offset = "0x5ED71F0", VA = "0x185ED7FF0")]
	public static ENHOHHNNCDO HJHLJDICLMC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5ED81E0", Offset = "0x5ED73E0", VA = "0x185ED81E0")]
	[IteratorStateMachine(typeof(JKHCPOEFMMF))]
	private static IEnumerable<PDKLMPLPPNP> LIBFCAANABE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x5ED8250", Offset = "0x5ED7450", VA = "0x185ED8250")]
	public static PDKLMPLPPNP OBCELEDHJAN(JFNHOKLDIOK COLHOCMIMJN, int HFMGLEOIGIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x5ED81C0", Offset = "0x5ED73C0", VA = "0x185ED81C0")]
	public static bool KPFHHGPKEHJ(this JFNHOKLDIOK COLHOCMIMJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x5ED7BA0", Offset = "0x5ED6DA0", VA = "0x185ED7BA0")]
	public static void CCEAJBFLOEO(JFNHOKLDIOK COLHOCMIMJN, float3 LLLJBGGAGLK, out ALFGHKHKNLH OPCECKIDOJA, out float3 LBOGNKOIHKJ, out float KJPHIENKDGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x5ED85B0", Offset = "0x5ED77B0", VA = "0x185ED85B0")]
	public static void ONLELFBINNA(Vector3 LLLJBGGAGLK, JFNHOKLDIOK COLHOCMIMJN, out Vector3 LBOGNKOIHKJ, out float KJPHIENKDGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x5ED7FE0", Offset = "0x5ED71E0", VA = "0x185ED7FE0")]
	[EEIOFBLGGPF(JGEIHADJKJD.ExitingPlayMode, 0)]
	private static void FNNJFJIMPIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x5ED7DC0", Offset = "0x5ED6FC0", VA = "0x185ED7DC0")]
	[EEIOFBLGGPF(JGEIHADJKJD.ExitingPlayMode, 0)]
	private static void EKDFHOCMAHM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public abstract class GJBHHHLOMOE : DHCDEBMFICA, AEJINIDDPDG, BIODEMEHOID, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly OCDJKLPJODF NMFNLMEMDBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	protected Bounds KBOAKFOHFBL;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public Bounds PMDAMLJDGEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x11D01D0", Offset = "0x11CF3D0", VA = "0x1811D01D0", Slot = "4")]
		get
		{
			return default(Bounds);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public virtual LMLBNBMDBKO LKCGMOMFLLB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x5EDF960", Offset = "0x5EDEB60", VA = "0x185EDF960", Slot = "16")]
		get
		{
			return default(LMLBNBMDBKO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public bool HNEBIGMCAJM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x929880", Offset = "0x928A80", VA = "0x180929880")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x9298C0", Offset = "0x928AC0", VA = "0x1809298C0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	protected abstract Hash128 IGLBFAMLIPN
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int PGJDKFIEBEN
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x890110", Offset = "0x88F310", VA = "0x180890110", Slot = "8")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public BPPBMBELPAB MKIEJFIDEAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x89B300", Offset = "0x89A500", VA = "0x18089B300")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x89B1F0", Offset = "0x89A3F0", VA = "0x18089B1F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public bool FHDGIOPNHIO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x31658C0", Offset = "0x3164AC0", VA = "0x1831658C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x8888D0", Offset = "0x887AD0", VA = "0x1808888D0")]
	protected GJBHHHLOMOE(OCDJKLPJODF MKADPIPCNMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x5EDF830", Offset = "0x5EDEA30", VA = "0x185EDF830", Slot = "14")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x929790", Offset = "0x928990", VA = "0x180929790", Slot = "15")]
	public virtual bool CCADANBDDAM(HCKALGFFMDC MKADPIPCNMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "17")]
	public abstract int HOGAOHMEJEJ(HCDDACOAFJC HFMGLEOIGIG);

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "18")]
	public abstract int EHOMEJPJEHH(HCDDACOAFJC HFMGLEOIGIG);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "19")]
	public abstract void DABMOBMHDAB(HCDDACOAFJC HFMGLEOIGIG, OGBJFEMDOMJ AFHELHLEMFN, int EEEBJPENFPC = -1);

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "20")]
	public abstract HCKALGFFMDC PPPHIBONNGL();

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x5EDF9F0", Offset = "0x5EDEBF0", VA = "0x185EDF9F0", Slot = "10")]
	public Hash128 PNFNICCJCDA(int HFMGLEOIGIG)
	{
		return default(Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "22")]
	public abstract ELNHKDKCLHF FPIFKOGNLDK();

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "23")]
	public abstract KPJPPHCAEEE BBBPKIGPKCG(HCDDACOAFJC HFMGLEOIGIG, JobHandle FHGDOMMIJLE);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x5EDF800", Offset = "0x5EDEA00", VA = "0x185EDF800", Slot = "9")]
	public KPJPPHCAEEE AFKCEGGEBEB(int HFMGLEOIGIG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class KCKOPBMFFEI : GJBHHHLOMOE
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	private struct PLOHDMBNNEB : KPJPPHCAEEE, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private PKDAECFHHCE BNHDDEIBJPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private JobHandle FHGDOMMIJLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private CJNOLOALDGK OICLJHELJBL;

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x5EE8950", Offset = "0x5EE7B50", VA = "0x185EE8950")]
		public PLOHDMBNNEB(PKDAECFHHCE BNHDDEIBJPG, JobHandle FHGDOMMIJLE, CJNOLOALDGK OICLJHELJBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x5EE8920", Offset = "0x5EE7B20", VA = "0x185EE8920", Slot = "4")]
		public PKDAECFHHCE OJAKBINLFPA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x5EE88D0", Offset = "0x5EE7AD0", VA = "0x185EE88D0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private readonly EIJJFHIOKKF DPOIOCLIHGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private float LCFFCCCKIIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private Hash128 LFHGPEHDBNK;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	protected override Hash128 IGLBFAMLIPN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x5EE3EA0", Offset = "0x5EE30A0", VA = "0x185EE3EA0", Slot = "21")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x5EE4090", Offset = "0x5EE3290", VA = "0x185EE4090")]
	public KCKOPBMFFEI(OCDJKLPJODF MKADPIPCNMO, EIJJFHIOKKF JFGIPFOFKHL, bool KBEDJILCCGB = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x929790", Offset = "0x928990", VA = "0x180929790", Slot = "15")]
	public override bool CCADANBDDAM(HCKALGFFMDC MKADPIPCNMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x5EE3CB0", Offset = "0x5EE2EB0", VA = "0x185EE3CB0", Slot = "17")]
	public override int HOGAOHMEJEJ(HCDDACOAFJC HFMGLEOIGIG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x5EE38A0", Offset = "0x5EE2AA0", VA = "0x185EE38A0", Slot = "18")]
	public override int EHOMEJPJEHH(HCDDACOAFJC HFMGLEOIGIG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x5EE31C0", Offset = "0x5EE23C0", VA = "0x185EE31C0", Slot = "19")]
	public override void DABMOBMHDAB(HCDDACOAFJC HFMGLEOIGIG, OGBJFEMDOMJ AFHELHLEMFN, int EEEBJPENFPC = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x5EE3FC0", Offset = "0x5EE31C0", VA = "0x185EE3FC0", Slot = "20")]
	public override HCKALGFFMDC PPPHIBONNGL()
	{
		return default(HCKALGFFMDC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x5EE3A90", Offset = "0x5EE2C90", VA = "0x185EE3A90", Slot = "22")]
	public override ELNHKDKCLHF FPIFKOGNLDK()
	{
		return default(ELNHKDKCLHF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x5EE2900", Offset = "0x5EE1B00", VA = "0x185EE2900", Slot = "23")]
	public override KPJPPHCAEEE BBBPKIGPKCG(HCDDACOAFJC HFMGLEOIGIG, JobHandle FHGDOMMIJLE)
	{
		return null;
	}
}
namespace RecRoom.ShapeRendering
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class SkinnedShapeRenderer : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private MaterialPropertyBlock FJDKDDCJPLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private BNDFGBKNKGO BNHDDEIBJPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private List<HCKALGFFMDC> DAHOGDMPGBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private RenderTexture CANCHJHOJDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private ComputeBuffer PILOBPCPPNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private ComputeShader LABBHNHFKLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private Matrix4x4[] AANNAKFIJKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private int HGHBNDCCABK;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public MeshRenderer MNDBIPBJALM
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x7EBAF0", Offset = "0x7EACF0", VA = "0x1807EBAF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x909DA0", Offset = "0x908FA0", VA = "0x180909DA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public int CMKIELKBPBI
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x5EE9670", Offset = "0x5EE8870", VA = "0x185EE9670")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x5EE89E0", Offset = "0x5EE7BE0", VA = "0x185EE89E0")]
		public static List<SkinnedShapeRenderer> Create(GameObject MKADPIPCNMO, List<BNDFGBKNKGO> KPAFIAIKPMC, List<HCKALGFFMDC> DAHOGDMPGBB, Material GMJJKHGKCAP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x5EE9020", Offset = "0x5EE8220", VA = "0x185EE9020")]
		public void Init(BNDFGBKNKGO BNHDDEIBJPG, List<HCKALGFFMDC> DAHOGDMPGBB, Material GMJJKHGKCAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x5EE95C0", Offset = "0x5EE87C0", VA = "0x185EE95C0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x5EE9510", Offset = "0x5EE8710", VA = "0x185EE9510")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x5EE94D0", Offset = "0x5EE86D0", VA = "0x185EE94D0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x5EE8C30", Offset = "0x5EE7E30", VA = "0x185EE8C30")]
		private void FNFAOGJFPPE(ScriptableRenderContext JDFBABENAGD, Camera[] ECFBAHCBHMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x5EE8E60", Offset = "0x5EE8060", VA = "0x185EE8E60")]
		private void GEGBPGKBJEE(CommandBuffer PBDAHPGBNEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x89BCA0", Offset = "0x89AEA0", VA = "0x18089BCA0")]
		public SkinnedShapeRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface AGPLBNAEIIH
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	bool GGOFCHJOCHP
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Material NLPOLJBOJJM();

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Material MMEEDHFAFLI();

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Material JCDNIDDNAJI();

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int PAJIMKPBNKE(HJGGJBIGLCH JBPKHBMCLEL);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int CHKHHDGDOOI(AFKEAPAJDHP FPFCFLELOLM);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void FCBMBPMPJOB(GameObject PPNJOAJJOFF);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void MGLAALOMABL(GameObject PPNJOAJJOFF, bool GIJHPPEFJAA);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class MODPDHCICEN
{
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private static AGPLBNAEIIH KPCECNDHFND;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public static bool GGOFCHJOCHP
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x5EE5930", Offset = "0x5EE4B30", VA = "0x185EE5930")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x5EE5A60", Offset = "0x5EE4C60", VA = "0x185EE5A60")]
	public static void HMDMMNLEHIK(AGPLBNAEIIH GEPLDOAMEFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x5EE5C50", Offset = "0x5EE4E50", VA = "0x185EE5C50")]
	public static Material NLPOLJBOJJM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x5EE5BF0", Offset = "0x5EE4DF0", VA = "0x185EE5BF0")]
	public static Material MMEEDHFAFLI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x5EE5AB0", Offset = "0x5EE4CB0", VA = "0x185EE5AB0")]
	public static Material JCDNIDDNAJI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x5EE5CB0", Offset = "0x5EE4EB0", VA = "0x185EE5CB0")]
	public static int PAJIMKPBNKE(HJGGJBIGLCH JBPKHBMCLEL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x5EE58C0", Offset = "0x5EE4AC0", VA = "0x185EE58C0")]
	public static int CHKHHDGDOOI(AFKEAPAJDHP FPFCFLELOLM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x5EE5990", Offset = "0x5EE4B90", VA = "0x185EE5990")]
	public static void FCBMBPMPJOB(GameObject PPNJOAJJOFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x5EE5B10", Offset = "0x5EE4D10", VA = "0x185EE5B10")]
	public static void MGLAALOMABL(GameObject PPNJOAJJOFF, bool GIJHPPEFJAA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[DefaultMember("Item")]
public class JPINFHLGAOL : CADEDIIOKBN, IDisposable, NAIOGIJNOEH
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class NPPAOBCEFII : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public JPINFHLGAOL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public NPPAOBCEFII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x5EE5D20", Offset = "0x5EE4F20", VA = "0x185EE5D20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly KAELLJOCCLI<LIIJACJPKCA, OCDJKLPJODF> OFNHBJAMLID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly KAELLJOCCLI<NBKCBPOCILE, GJBHHHLOMOE> BJFDLBAAIMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly KAELLJOCCLI<FAIOOLDBMIH, KGCOILOMCLD> NGAJFHFFHDL;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public OCDJKLPJODF JOJAFGMMIDN
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x5EE1F50", Offset = "0x5EE1150", VA = "0x185EE1F50", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public GJBHHHLOMOE JOJAFGMMIDN
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x5EE1FB0", Offset = "0x5EE11B0", VA = "0x185EE1FB0", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public KGCOILOMCLD JOJAFGMMIDN
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x5EE2010", Offset = "0x5EE1210", VA = "0x185EE2010", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool MNEIBBJIFKF
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x7EBAC0", Offset = "0x7EACC0", VA = "0x1807EBAC0", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x7EB9E0", Offset = "0x7EABE0", VA = "0x1807EB9E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x5EE2440", Offset = "0x5EE1640", VA = "0x185EE2440")]
	public JPINFHLGAOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x5EE07B0", Offset = "0x5EDF9B0", VA = "0x185EE07B0", Slot = "21")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x5EE0510", Offset = "0x5EDF710", VA = "0x185EE0510", Slot = "4")]
	public LIIJACJPKCA DADOIDGEKJB(GPFKOIGOAJP JFGIPFOFKHL)
	{
		return default(LIIJACJPKCA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x5EE0520", Offset = "0x5EDF720", VA = "0x185EE0520", Slot = "5")]
	public LIIJACJPKCA DADOIDGEKJB(GPFKOIGOAJP JFGIPFOFKHL, bool KBEDJILCCGB)
	{
		return default(LIIJACJPKCA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x5EE2140", Offset = "0x5EE1340", VA = "0x185EE2140", Slot = "6")]
	public void PCCMKKHECEE(LIIJACJPKCA MKADPIPCNMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x5EE0950", Offset = "0x5EDFB50", VA = "0x185EE0950", Slot = "7")]
	public void EFCGFHJBBNI(LIIJACJPKCA MKADPIPCNMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x5EE19E0", Offset = "0x5EE0BE0", VA = "0x185EE19E0", Slot = "8")]
	public NBKCBPOCILE JCGKHHMPMLF(LIIJACJPKCA MKADPIPCNMO, OHHKPPKECEG JFGIPFOFKHL)
	{
		return default(NBKCBPOCILE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x5EE0F50", Offset = "0x5EE0150", VA = "0x185EE0F50", Slot = "9")]
	public NBKCBPOCILE FFLCAEMPDAA(LIIJACJPKCA MKADPIPCNMO, EIJJFHIOKKF JFGIPFOFKHL)
	{
		return default(NBKCBPOCILE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x5EE15F0", Offset = "0x5EE07F0", VA = "0x185EE15F0", Slot = "11")]
	public void IHEKHNPMIHM(NBKCBPOCILE BFCABOCHBCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x5EE0CE0", Offset = "0x5EDFEE0", VA = "0x185EE0CE0", Slot = "10")]
	public void EOMPADKAHCI(NBKCBPOCILE BFCABOCHBCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x5EE20D0", Offset = "0x5EE12D0", VA = "0x185EE20D0", Slot = "20")]
	public IEnumerable<Renderer> OFOCDBBCMDE(LIIJACJPKCA MKADPIPCNMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x5EE1570", Offset = "0x5EE0770", VA = "0x185EE1570", Slot = "12")]
	public FAIOOLDBMIH IFILIFEBMHO(PPCHLICLNCA JFGIPFOFKHL)
	{
		return default(FAIOOLDBMIH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x5EE1EE0", Offset = "0x5EE10E0", VA = "0x185EE1EE0", Slot = "14")]
	public void JGDNGJFANDM(FAIOOLDBMIH ANAPJIFAFBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x5EE03A0", Offset = "0x5EDF5A0", VA = "0x185EE03A0", Slot = "16")]
	public Task CFABGMCGBPA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x5EE0240", Offset = "0x5EDF440", VA = "0x185EE0240", Slot = "17")]
	public Task AGKKACJKDKN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x5EE1450", Offset = "0x5EE0650", VA = "0x185EE1450", Slot = "18")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(NPPAOBCEFII))]
	public Task HJIKKLIJLEC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x5EE23B0", Offset = "0x5EE15B0", VA = "0x185EE23B0", Slot = "19")]
	public void PFIFIALJHAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x5EE2070", Offset = "0x5EE1270", VA = "0x185EE2070", Slot = "13")]
	public void NCGPDIBECBC(FAIOOLDBMIH ANAPJIFAFBP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class BNDFGBKNKGO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	private struct NNPNCHOKCDO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public OGBJFEMDOMJ PLFICBBBNJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public HCKALGFFMDC HIDABGJMENO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public int KFBHBDNCAJC;
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class IODLIEDNEND
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public BNDFGBKNKGO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public int numVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public int numIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public HCDDACOAFJC lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public List<NNPNCHOKCDO> boneMeshInfos;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public IODLIEDNEND()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class KEICIHAMCDO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public PKDAECFHHCE combinedMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public IODLIEDNEND CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public KEICIHAMCDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x5EE4180", Offset = "0x5EE3380", VA = "0x185EE4180")]
		internal JobHandle EAOJLJMDMMC()
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x5EE4140", Offset = "0x5EE3340", VA = "0x185EE4140")]
		internal void BCIDNGHIKBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x5EE41F0", Offset = "0x5EE33F0", VA = "0x185EE41F0")]
		internal void KLCBDMDNNBA()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private int[] PFGCAKFOBHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private LFLKHGBPEJN OIPFBLNJKNB;

	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private static Matrix4x4 CHEFGENBJKI;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public Mesh AAFJJOIFAMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x7E2110", Offset = "0x7E1310", VA = "0x1807E2110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x902EE0", Offset = "0x9020E0", VA = "0x180902EE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public int PLFLELIAPFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x8C8C20", Offset = "0x8C7E20", VA = "0x1808C8C20")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x902EF0", Offset = "0x9020F0", VA = "0x180902EF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x5EDAE60", Offset = "0x5EDA060", VA = "0x185EDAE60")]
	public void GEGBPGKBJEE(List<HCKALGFFMDC> KJPOGEABFFA, Matrix4x4[] LIFAHDFMJBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x5EDB0C0", Offset = "0x5EDA2C0", VA = "0x185EDB0C0")]
	public static List<BNDFGBKNKGO> JKAAGGANCJG(List<OCDJKLPJODF> JOCLPGNDDJC, HCDDACOAFJC HFMGLEOIGIG, Bounds GOCOAPIJJOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x5EDB700", Offset = "0x5EDA900", VA = "0x185EDB700")]
	private JobHandle NPGELPNKNFO(PKDAECFHHCE NJDDJDDHDEI, int PBJHGEBCDNO, int FDCGHBCCEDF, HCDDACOAFJC HFMGLEOIGIG, List<NNPNCHOKCDO> MFKCCMANDEI)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x5EDBAF0", Offset = "0x5EDACF0", VA = "0x185EDBAF0")]
	private void OECMHPBEDAI(List<NNPNCHOKCDO> MFKCCMANDEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x5EDBD30", Offset = "0x5EDAF30", VA = "0x185EDBD30")]
	private BNDFGBKNKGO(List<NNPNCHOKCDO> MFKCCMANDEI, int PBJHGEBCDNO, int FDCGHBCCEDF, HCDDACOAFJC HFMGLEOIGIG, Bounds GOCOAPIJJOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x5EDADF0", Offset = "0x5ED9FF0", VA = "0x185EDADF0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class KGCOILOMCLD : CMMIBNNOCGE
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class FGJMGLHCBGF : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private Renderer <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public KGCOILOMCLD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private List<SkinnedShapeRenderer>.Enumerator <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private SkinnedShapeRenderer <r>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x7EBAF0", Offset = "0x7EACF0", VA = "0x1807EBAF0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x7EBAF0", Offset = "0x7EACF0", VA = "0x1807EBAF0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0xA122A0", Offset = "0xA114A0", VA = "0x180A122A0")]
		[DebuggerHidden]
		public FGJMGLHCBGF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x5EDD5D0", Offset = "0x5EDC7D0", VA = "0x185EDD5D0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x5EDD2D0", Offset = "0x5EDC4D0", VA = "0x185EDD2D0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x5EDD280", Offset = "0x5EDC480", VA = "0x185EDD280")]
		private void DNBEPMOBGPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x5EDD590", Offset = "0x5EDC790", VA = "0x185EDD590", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x5EDD4F0", Offset = "0x5EDC6F0", VA = "0x185EDD4F0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x5EDD4F0", Offset = "0x5EDC6F0", VA = "0x185EDD4F0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly PPCHLICLNCA AEFMOHDEDFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly NAIOGIJNOEH GMDFDKMGPHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private CHLNEHAEPJE CHCMCGGNMCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private List<BNDFGBKNKGO> BBGCECLMLGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private List<BNDFGBKNKGO> JIDCDAFILDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private GameObject LMEHDLJKABI;

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x5EE4930", Offset = "0x5EE3B30", VA = "0x185EE4930")]
	public static KGCOILOMCLD KDOPJIPMDIE(PPCHLICLNCA JFGIPFOFKHL, NAIOGIJNOEH GMDFDKMGPHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x5EE57C0", Offset = "0x5EE49C0", VA = "0x185EE57C0")]
	private KGCOILOMCLD(PPCHLICLNCA JFGIPFOFKHL, NAIOGIJNOEH GMDFDKMGPHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x5EE4470", Offset = "0x5EE3670", VA = "0x185EE4470")]
	public void DFBADGMPLED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x5EE4360", Offset = "0x5EE3560", VA = "0x185EE4360")]
	[IteratorStateMachine(typeof(FGJMGLHCBGF))]
	public IEnumerable<Renderer> AFPEBGGIDPN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x5EE4CE0", Offset = "0x5EE3EE0", VA = "0x185EE4CE0", Slot = "4")]
	public void PHAPLECIJJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x5EE43D0", Offset = "0x5EE35D0", VA = "0x185EE43D0")]
	private void CPNMJDMAMEE(Vector3 HFONEINEIGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x5EE4AA0", Offset = "0x5EE3CA0", VA = "0x185EE4AA0")]
	public void KGILAIAHHCE()
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
