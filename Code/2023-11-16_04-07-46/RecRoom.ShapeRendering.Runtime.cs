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
public class ECOPDDFOFBG : IGKLNLHPGIF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private byte PAPGMEFFNFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly List<SkinnedShapeRenderer>[] ECDPEOHMJFJ;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int PGBEKMDLNIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8620A0", Offset = "0x8610A0", VA = "0x1808620A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8620C0", Offset = "0x8610C0", VA = "0x1808620C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int MMNKMEEELKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7B13F0", Offset = "0x7B03F0", VA = "0x1807B13F0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7B0F30", Offset = "0x7AFF30", VA = "0x1807B0F30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public float ONFDNNCIGLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7BEB00", Offset = "0x7BDB00", VA = "0x1807BEB00", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7BF2B0", Offset = "0x7BE2B0", VA = "0x1807BF2B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float DKLGBLEJNCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7BEC50", Offset = "0x7BDC50", VA = "0x1807BEC50", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7BF2A0", Offset = "0x7BE2A0", VA = "0x1807BF2A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public List<SkinnedShapeRenderer> CHDBKOBPEGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x64FD3B0", Offset = "0x64FC3B0", VA = "0x1864FD3B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public List<SkinnedShapeRenderer> OIGNAELBKDB
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x64FCFB0", Offset = "0x64FBFB0", VA = "0x1864FCFB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public GameObject FMAEDMDFLJE
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x76F1D0", Offset = "0x76E1D0", VA = "0x18076F1D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x76F220", Offset = "0x76E220", VA = "0x18076F220")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public byte LAOMEGDGAOE
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x64FCE60", Offset = "0x64FBE60", VA = "0x1864FCE60", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x64FD400", Offset = "0x64FC400", VA = "0x1864FD400")]
	public ECOPDDFOFBG(List<JIJKEMGHEJM> MDFEDEPLMFD, List<JIJKEMGHEJM> EJEPJKJLHFP, List<OHLMKILJLIL> ANCDDNAIFMK, Material DMOCGBANHDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x64FD290", Offset = "0x64FC290", VA = "0x1864FD290")]
	private int IMCHOFPFGJC(List<JIJKEMGHEJM> NAMALKCJBIH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x64FD130", Offset = "0x64FC130", VA = "0x1864FD130")]
	private void IEJJNMCMKPJ(int DDBCHFIOONB, bool GFHFKCIIDHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x64FCFE0", Offset = "0x64FBFE0", VA = "0x1864FCFE0")]
	public void FGMAABLMGJB(Vector3 EIAMKMBCPKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x64FCEB0", Offset = "0x64FBEB0", VA = "0x1864FCEB0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x64FCE20", Offset = "0x64FBE20", VA = "0x1864FCE20")]
	public void AKDECMHCJJB(Transform BGLOKHKLHJN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class LNEEPFHLJNI : DLDEGKGNELE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private sealed class BFNKCHFKBOB : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public LNEEPFHLJNI <>4__this;

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
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x76F210", Offset = "0x76E210", VA = "0x18076F210", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x76F210", Offset = "0x76E210", VA = "0x18076F210", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8C0A40", Offset = "0x8BFA40", VA = "0x1808C0A40")]
		[DebuggerHidden]
		public BFNKCHFKBOB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x64F7940", Offset = "0x64F6940", VA = "0x1864F7940", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x64F72E0", Offset = "0x64F62E0", VA = "0x1864F72E0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x64F7290", Offset = "0x64F6290", VA = "0x1864F7290")]
		private void GDOLLNLODDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x64F7240", Offset = "0x64F6240", VA = "0x1864F7240")]
		private void CPPLOHGLGKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x64F77F0", Offset = "0x64F67F0", VA = "0x1864F77F0")]
		private void POJIANEGOPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x64F78F0", Offset = "0x64F68F0", VA = "0x1864F78F0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x64F7840", Offset = "0x64F6840", VA = "0x1864F7840", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x64F7840", Offset = "0x64F6840", VA = "0x1864F7840", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private sealed class EFGKAIJBANM : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public LNEEPFHLJNI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private IEnumerator<Renderer> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x76F210", Offset = "0x76E210", VA = "0x18076F210", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x76F210", Offset = "0x76E210", VA = "0x18076F210", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8C0A40", Offset = "0x8BFA40", VA = "0x1808C0A40")]
		[DebuggerHidden]
		public EFGKAIJBANM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x64FDC20", Offset = "0x64FCC20", VA = "0x1864FDC20", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x64FD7B0", Offset = "0x64FC7B0", VA = "0x1864FD7B0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x64FD760", Offset = "0x64FC760", VA = "0x1864FD760")]
		private void GDOLLNLODDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x64FD710", Offset = "0x64FC710", VA = "0x1864FD710")]
		private void CPPLOHGLGKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x64FDBD0", Offset = "0x64FCBD0", VA = "0x1864FDBD0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x64FDB20", Offset = "0x64FCB20", VA = "0x1864FDB20", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x64FDB20", Offset = "0x64FCB20", VA = "0x1864FDB20", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly OMDGJAHDNOG DDIKIEEAAOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly List<EFNAFEGMLEE> MHMIKFMMPCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private List<ClusterMeshRenderer> IFIPFNGLIDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private BatchedMeshRenderer HNLOGEDMFGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private bool DPHLPIELOFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public readonly bool HLADNHKAHLP;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IEnumerable<OHPLDJJBEHJ> NHEPNPBFLMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x76F210", Offset = "0x76E210", VA = "0x18076F210", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int AKMFKGOBBJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6506C00", Offset = "0x6505C00", VA = "0x186506C00", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public OHLMKILJLIL JKPABFOFLPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6506C40", Offset = "0x6505C40", VA = "0x186506C40", Slot = "8")]
		get
		{
			return default(OHLMKILJLIL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public List<SkinnedShapeRenderer> POFELALMHPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x774F60", Offset = "0x773F60", VA = "0x180774F60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x774F80", Offset = "0x773F80", VA = "0x180774F80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6506310", Offset = "0x6505310", VA = "0x186506310")]
	private bool JLDKNKDAPAP(EFNAFEGMLEE EJIGKCIHDDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6505D00", Offset = "0x6504D00", VA = "0x186505D00")]
	private static bool DOCOACDFHGI(EFNAFEGMLEE EJIGKCIHDDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6506D90", Offset = "0x6505D90", VA = "0x186506D90")]
	public LNEEPFHLJNI(OMDGJAHDNOG FCLEEDACIMH, bool CPNNIFLMKJH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6505D20", Offset = "0x6504D20", VA = "0x186505D20", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6505F20", Offset = "0x6504F20", VA = "0x186505F20")]
	public void GPDFOMDKBKK(EFNAFEGMLEE EJIGKCIHDDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6506AE0", Offset = "0x6505AE0", VA = "0x186506AE0")]
	public void MOJJDBCCFOB(EFNAFEGMLEE EJIGKCIHDDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x65065E0", Offset = "0x65055E0", VA = "0x1865065E0", Slot = "4")]
	public void MFIBBPDPCKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x65060C0", Offset = "0x65050C0", VA = "0x1865060C0")]
	public void HOEJNKLEAPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x65063B0", Offset = "0x65053B0", VA = "0x1865063B0")]
	private void LGODLCEAIOC(List<EFNAFEGMLEE> MHMIKFMMPCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x64F7110", Offset = "0x64F6110", VA = "0x1864F7110")]
	private static Material OEALPCFDGJN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6506540", Offset = "0x6505540", VA = "0x186506540")]
	private void LGODLCEAIOC(EFNAFEGMLEE EJIGKCIHDDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6505C40", Offset = "0x6504C40", VA = "0x186505C40")]
	private void CGAGMAHOPDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6505690", Offset = "0x6504690", VA = "0x186505690")]
	public void CAGOKECEKEO(bool NDGDFODNAFI, bool OPPMBEAFIIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6505EA0", Offset = "0x6504EA0", VA = "0x186505EA0")]
	protected void GHKDJHICCFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6506330", Offset = "0x6505330", VA = "0x186506330")]
	[IteratorStateMachine(typeof(BFNKCHFKBOB))]
	public IEnumerable<Renderer> KKOJOGBNIHG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6506D10", Offset = "0x6505D10", VA = "0x186506D10")]
	[IteratorStateMachine(typeof(EFGKAIJBANM))]
	public IEnumerable<Renderer> PDBOMILEJFP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal class KPLLBGOBOML : EFNAFEGMLEE
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private struct CADNFNGKIHB : CCLBPPIKLFP, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private KPDLEIFKJLD KBKBNNLDMCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private JobHandle KHPBICCBDEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private LCDOPJEMFME LBFDBFKAMIJ;

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x64F7D70", Offset = "0x64F6D70", VA = "0x1864F7D70")]
		public CADNFNGKIHB(KPDLEIFKJLD KBKBNNLDMCD, JobHandle KHPBICCBDEG, LCDOPJEMFME LBFDBFKAMIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x64F7D40", Offset = "0x64F6D40", VA = "0x1864F7D40", Slot = "4")]
		public KPDLEIFKJLD FAMMDIJKGAD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x64F7CF0", Offset = "0x64F6CF0", VA = "0x1864F7CF0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly MBPIEAIMJBL AKKKIKILEBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private float IFGDMEBEOKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private Hash128 NKCCCFOABGN;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	protected override Hash128 PEAEAENLKEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6502A00", Offset = "0x6501A00", VA = "0x186502A00", Slot = "21")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6503250", Offset = "0x6502250", VA = "0x186503250")]
	public KPLLBGOBOML(LNEEPFHLJNI GLACNLFCFNI, MBPIEAIMJBL FCLEEDACIMH, bool CPNNIFLMKJH = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7BA2E0", Offset = "0x7B92E0", VA = "0x1807BA2E0", Slot = "15")]
	public override bool KBHDPMLGCDE(OHLMKILJLIL GLACNLFCFNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6502830", Offset = "0x6501830", VA = "0x186502830", Slot = "17")]
	public override int IMCHOFPFGJC(PCCEMNFLDAL KBODLDDGOHA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6502590", Offset = "0x6501590", VA = "0x186502590", Slot = "18")]
	public override int FFALJLPBLOO(PCCEMNFLDAL KBODLDDGOHA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6502B30", Offset = "0x6501B30", VA = "0x186502B30", Slot = "19")]
	public override void PLJHGNOFKIH(PCCEMNFLDAL KBODLDDGOHA, MKNGMLEHKNN DGJNPDDCCIA, int JHIPOMGDCAK = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6502760", Offset = "0x6501760", VA = "0x186502760", Slot = "20")]
	public override OHLMKILJLIL FKGJFKLEPBD()
	{
		return default(OHLMKILJLIL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x65023E0", Offset = "0x65013E0", VA = "0x1865023E0", Slot = "22")]
	public override PAAKEFABMDD FBJMOHIEKHG()
	{
		return default(PAAKEFABMDD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6501AC0", Offset = "0x6500AC0", VA = "0x186501AC0", Slot = "23")]
	public override CCLBPPIKLFP DNJIHENBIBD(PCCEMNFLDAL KBODLDDGOHA, JobHandle KHPBICCBDEG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[DefaultMember("Item")]
public interface PIFPICJOEAH
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	LNEEPFHLJNI KHIKFGEKFJI
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	EFNAFEGMLEE KHIKFGEKFJI
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	DDNEBEBFNHH KHIKFGEKFJI
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[DefaultMember("Item")]
public class ELCDODFLAGE : JFAHHOFNEID, IDisposable, PIFPICJOEAH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct CGCEFKDNCCN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public ELCDODFLAGE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x64F7DD0", Offset = "0x64F6DD0", VA = "0x1864F7DD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x64F82F0", Offset = "0x64F72F0", VA = "0x1864F82F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly NAIOGHHNDAP<DPANOCKJNJO, LNEEPFHLJNI> EKGOLNMOPCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly NAIOGHHNDAP<BBCEEBOCHLI, EFNAFEGMLEE> MHMIKFMMPCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly NAIOGHHNDAP<IFCPJPGGOMN, DDNEBEBFNHH> MGJBALJEBJL;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public LNEEPFHLJNI KHIKFGEKFJI
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x64FE9D0", Offset = "0x64FD9D0", VA = "0x1864FE9D0", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public EFNAFEGMLEE KHIKFGEKFJI
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x64FE970", Offset = "0x64FD970", VA = "0x1864FE970", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public DDNEBEBFNHH KHIKFGEKFJI
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x64FEA30", Offset = "0x64FDA30", VA = "0x1864FEA30", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool HLOCOIDPAAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x81F7E0", Offset = "0x81E7E0", VA = "0x18081F7E0", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x8D7190", Offset = "0x8D6190", VA = "0x1808D7190")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6500080", Offset = "0x64FF080", VA = "0x186500080")]
	public ELCDODFLAGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x64FE400", Offset = "0x64FD400", VA = "0x1864FE400", Slot = "21")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x64FF150", Offset = "0x64FE150", VA = "0x1864FF150", Slot = "4")]
	public DPANOCKJNJO MFIBLPOIDLD(OMDGJAHDNOG FCLEEDACIMH)
	{
		return default(DPANOCKJNJO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x64FEED0", Offset = "0x64FDED0", VA = "0x1864FEED0", Slot = "5")]
	public DPANOCKJNJO MFIBLPOIDLD(OMDGJAHDNOG FCLEEDACIMH, bool CPNNIFLMKJH)
	{
		return default(DPANOCKJNJO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x64FE590", Offset = "0x64FD590", VA = "0x1864FE590", Slot = "6")]
	public void EHBOPGNFNCE(DPANOCKJNJO GLACNLFCFNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x64FF840", Offset = "0x64FE840", VA = "0x1864FF840", Slot = "7")]
	public void OKHFMKECLEB(DPANOCKJNJO GLACNLFCFNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x64FFBA0", Offset = "0x64FEBA0", VA = "0x1864FFBA0", Slot = "8")]
	public BBCEEBOCHLI OOBIHEEMCDI(DPANOCKJNJO GLACNLFCFNI, PJIBALOECAB FCLEEDACIMH)
	{
		return default(BBCEEBOCHLI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x64FF360", Offset = "0x64FE360", VA = "0x1864FF360", Slot = "9")]
	public BBCEEBOCHLI NCFBNOKLJED(DPANOCKJNJO GLACNLFCFNI, MBPIEAIMJBL FCLEEDACIMH)
	{
		return default(BBCEEBOCHLI);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x64FE040", Offset = "0x64FD040", VA = "0x1864FE040", Slot = "11")]
	public void BNALKMBKKDF(BBCEEBOCHLI EJIGKCIHDDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x64FEAF0", Offset = "0x64FDAF0", VA = "0x1864FEAF0", Slot = "10")]
	public void JOIAOPKCGNC(BBCEEBOCHLI EJIGKCIHDDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x64FF160", Offset = "0x64FE160", VA = "0x1864FF160", Slot = "20")]
	public IEnumerable<Renderer> MJGANIJOBGC(DPANOCKJNJO GLACNLFCFNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x64FE7F0", Offset = "0x64FD7F0", VA = "0x1864FE7F0", Slot = "12")]
	public IFCPJPGGOMN GHOPCKCGIEK(HNODKHDDIGK FCLEEDACIMH)
	{
		return default(IFCPJPGGOMN);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x64FE900", Offset = "0x64FD900", VA = "0x1864FE900", Slot = "14")]
	public void IEMHINPFIEH(IFCPJPGGOMN OJCBILEGNAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x64FF1D0", Offset = "0x64FE1D0", VA = "0x1864FF1D0", Slot = "16")]
	public Task MPKCKPFEOBG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x64FED50", Offset = "0x64FDD50", VA = "0x1864FED50", Slot = "17")]
	public Task KJFLJJEFCBK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x64FDF70", Offset = "0x64FCF70", VA = "0x1864FDF70", Slot = "18")]
	[AsyncStateMachine(typeof(CGCEFKDNCCN))]
	public Task AJOFLMDLKEG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x64FE870", Offset = "0x64FD870", VA = "0x1864FE870", Slot = "19")]
	public void HLDFDDICKFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x64FEA90", Offset = "0x64FDA90", VA = "0x1864FEA90", Slot = "13")]
	public void IPBEHOEFIBO(IFCPJPGGOMN OJCBILEGNAO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal class LKGKBPNFKFO : EFNAFEGMLEE
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	private struct AKJCKNFAFOB : CCLBPPIKLFP, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private KPDLEIFKJLD KBKBNNLDMCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private JobHandle KHPBICCBDEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private LMDLDIAMBIO LBFDBFKAMIJ;

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x64F71F0", Offset = "0x64F61F0", VA = "0x1864F71F0")]
		public AKJCKNFAFOB(KPDLEIFKJLD KBKBNNLDMCD, JobHandle KHPBICCBDEG, LMDLDIAMBIO LBFDBFKAMIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x64F71C0", Offset = "0x64F61C0", VA = "0x1864F71C0", Slot = "4")]
		public KPDLEIFKJLD FAMMDIJKGAD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x64F7170", Offset = "0x64F6170", VA = "0x1864F7170", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly PJIBALOECAB ALHHFFKAKHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private int[] CJPJKHCOLMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private Hash128 NKCCCFOABGN;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public override CHNCAHOPNCO EAFIDPNHGEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x6504A90", Offset = "0x6503A90", VA = "0x186504A90", Slot = "16")]
		get
		{
			return default(CHNCAHOPNCO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	private Vector3 ODDOAEDPBIH
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6503B40", Offset = "0x6502B40", VA = "0x186503B40")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	protected override Hash128 PEAEAENLKEM
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6504960", Offset = "0x6503960", VA = "0x186504960", Slot = "21")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x65055E0", Offset = "0x65045E0", VA = "0x1865055E0")]
	public LKGKBPNFKFO(LNEEPFHLJNI GLACNLFCFNI, PJIBALOECAB FCLEEDACIMH, bool JBBGCEOPDIK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x65044D0", Offset = "0x65034D0", VA = "0x1865044D0", Slot = "15")]
	public override bool KBHDPMLGCDE(OHLMKILJLIL GLACNLFCFNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6504430", Offset = "0x6503430", VA = "0x186504430", Slot = "17")]
	public override int IMCHOFPFGJC(PCCEMNFLDAL KBODLDDGOHA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x65042C0", Offset = "0x65032C0", VA = "0x1865042C0", Slot = "18")]
	public override int FFALJLPBLOO(PCCEMNFLDAL KBODLDDGOHA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6503EC0", Offset = "0x6502EC0", VA = "0x186503EC0")]
	private int EONPOJIKJOO(PCCEMNFLDAL KBODLDDGOHA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6504E50", Offset = "0x6503E50", VA = "0x186504E50", Slot = "19")]
	public override void PLJHGNOFKIH(PCCEMNFLDAL KBODLDDGOHA, MKNGMLEHKNN DGJNPDDCCIA, int JHIPOMGDCAK = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6504360", Offset = "0x6503360", VA = "0x186504360", Slot = "20")]
	public override OHLMKILJLIL FKGJFKLEPBD()
	{
		return default(OHLMKILJLIL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6504110", Offset = "0x6503110", VA = "0x186504110", Slot = "22")]
	public override PAAKEFABMDD FBJMOHIEKHG()
	{
		return default(PAAKEFABMDD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6503300", Offset = "0x6502300", VA = "0x186503300", Slot = "23")]
	public override CCLBPPIKLFP DNJIHENBIBD(PCCEMNFLDAL KBODLDDGOHA, JobHandle KHPBICCBDEG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface ADMIDGKIHOP
{
	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NDALOAJKIKN(GLFEDOAPKAG CFGJPNBLNDJ, Renderer CHHDBJPKECN, int GADMPMOLAFI);

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JHECKKFIACN(Renderer CHHDBJPKECN, DNACHGPMOGB HIPMFOBJAAK, Vector3 EGODLLPBKDI, Vector3 HFCBOKLBCNL, Vector3 NCPDOFIOLIO, float EHEJEEHBJDG, float CNGCELDFLPM, float HAMFBKFIDIB = -1f, [Optional] Color? NGFEKFKHCIJ, [Optional] IReadOnlyList<Camera> LEDKEAPIKJM);

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OMOKNMNCCCM(Renderer CHHDBJPKECN, int GADMPMOLAFI);

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int IICKJGMEDCG();

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IDMICFNEHDN(int CLLIEEKFOJD, CLOECILAMCC CFGJPNBLNDJ, Renderer CHHDBJPKECN, int GADMPMOLAFI);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class DOKILCMEDME : DHMELNEEOBH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	private class FBPABEJOPLP : KGFANBEBBPD<int>
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x6500530", Offset = "0x64FF530", VA = "0x186500530")]
		public FBPABEJOPLP(string JNMEJDHMADI)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly ADMIDGKIHOP IMEEPHFLHIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly PIFPICJOEAH CPMHDHDCJKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private MeshRenderer HCAFAMGJKMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private FBPABEJOPLP CFJDOFJOGIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private bool BHJBACDJMJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private MeshRenderer MOAHJECCPEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private FBPABEJOPLP MBJNMELGGMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private bool MJJCPDAFCFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private MeshRenderer LGFAMEONJCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private FBPABEJOPLP MCJGPFMINOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private bool IMLKIPNMKJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private bool BKIGCJKEOGE;

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x77EB20", Offset = "0x77DB20", VA = "0x18077EB20")]
	public DOKILCMEDME(ADMIDGKIHOP PBMKNADGCFO, PIFPICJOEAH CPMHDHDCJKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x64FAB30", Offset = "0x64F9B30", VA = "0x1864FAB30", Slot = "23")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x64FCA10", Offset = "0x64FBA10", VA = "0x1864FCA10")]
	private void OMOEDEPJKEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x64FB5F0", Offset = "0x64FA5F0", VA = "0x1864FB5F0", Slot = "4")]
	public void IFBAHENJMCA(DPANOCKJNJO GLACNLFCFNI, CLOECILAMCC AADFGDGLCCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x64FB8F0", Offset = "0x64FA8F0", VA = "0x1864FB8F0", Slot = "5")]
	public void IFBAHENJMCA(BBCEEBOCHLI EJIGKCIHDDG, CLOECILAMCC AADFGDGLCCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x64FCC50", Offset = "0x64FBC50", VA = "0x1864FCC50", Slot = "6")]
	public void PBIPMCEGIAK(BBCEEBOCHLI EJIGKCIHDDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x64FC900", Offset = "0x64FB900", VA = "0x1864FC900", Slot = "7")]
	public void NAFGIHHBJFM(BBCEEBOCHLI EJIGKCIHDDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x64FBEC0", Offset = "0x64FAEC0", VA = "0x1864FBEC0", Slot = "24")]
	public void IIKDOBEPEHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x86D7F0", Offset = "0x86C7F0", VA = "0x18086D7F0", Slot = "8")]
	public void ELFPGFGNKJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x64FBB10", Offset = "0x64FAB10", VA = "0x1864FBB10", Slot = "9")]
	public void IFDIIHOJEAF(CLOECILAMCC AADFGDGLCCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x64FC140", Offset = "0x64FB140", VA = "0x1864FC140", Slot = "10")]
	public void JIIMOBGDAFG(DPANOCKJNJO GLACNLFCFNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x64FC420", Offset = "0x64FB420", VA = "0x1864FC420", Slot = "11")]
	public void JIIMOBGDAFG(BBCEEBOCHLI EJIGKCIHDDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x64FCD80", Offset = "0x64FBD80", VA = "0x1864FCD80", Slot = "12")]
	public void PHPMHHIEKMJ(BBCEEBOCHLI EJIGKCIHDDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x64FAAA0", Offset = "0x64F9AA0", VA = "0x1864FAAA0", Slot = "13")]
	public void CONGKKBAODJ(BBCEEBOCHLI EJIGKCIHDDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x64FBC80", Offset = "0x64FAC80", VA = "0x1864FBC80")]
	private void IGMHLDBDMKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0xF71A90", Offset = "0xF70A90", VA = "0x180F71A90", Slot = "14")]
	public void HPKHCKIDGCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x64FC7E0", Offset = "0x64FB7E0", VA = "0x1864FC7E0", Slot = "15")]
	public void KPNKLFPEACB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x64FA7D0", Offset = "0x64F97D0", VA = "0x1864FA7D0", Slot = "16")]
	public void BIGKKJAHINC(DPANOCKJNJO GLACNLFCFNI, GLFEDOAPKAG CFGJPNBLNDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x64FACE0", Offset = "0x64F9CE0", VA = "0x1864FACE0", Slot = "17")]
	public void GLFJHNHEDAP(BBCEEBOCHLI EJIGKCIHDDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x64FC750", Offset = "0x64FB750", VA = "0x1864FC750", Slot = "18")]
	public void KEKBJLGGIMF(BBCEEBOCHLI EJIGKCIHDDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x81FF70", Offset = "0x81EF70", VA = "0x18081FF70", Slot = "19")]
	public void ELODCBONBHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x64FA6A0", Offset = "0x64F96A0", VA = "0x1864FA6A0", Slot = "20")]
	public void AEPECGLPJOH(GLFEDOAPKAG CFGJPNBLNDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x64FBF00", Offset = "0x64FAF00", VA = "0x1864FBF00")]
	private void JBOIJPEONCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x64FB220", Offset = "0x64FA220", VA = "0x1864FB220", Slot = "21")]
	public void HHCNLFNKOPB(DPANOCKJNJO GLACNLFCFNI, Vector3 EGODLLPBKDI, Vector3 HFCBOKLBCNL, Vector3 NCPDOFIOLIO, float EHEJEEHBJDG, float CNGCELDFLPM, IReadOnlyList<Camera> LKIDKILMIMG, DNACHGPMOGB HIPMFOBJAAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x64FAD80", Offset = "0x64F9D80", VA = "0x1864FAD80", Slot = "22")]
	public void HHCNLFNKOPB(IFCPJPGGOMN OJCBILEGNAO, Vector3 EGODLLPBKDI, Vector3 HFCBOKLBCNL, Vector3 NCPDOFIOLIO, float EHEJEEHBJDG, float CNGCELDFLPM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public abstract class EFNAFEGMLEE : PMDMEMFOKPL, OHPLDJJBEHJ, ACADDCJHMIO, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly LNEEPFHLJNI FMAEDMDFLJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	protected Bounds ACJOHCKGFIN;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public Bounds FPIKJNNJFLB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0xDC27A0", Offset = "0xDC17A0", VA = "0x180DC27A0", Slot = "4")]
		get
		{
			return default(Bounds);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public virtual CHNCAHOPNCO EAFIDPNHGEP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x64FDEE0", Offset = "0x64FCEE0", VA = "0x1864FDEE0", Slot = "16")]
		get
		{
			return default(CHNCAHOPNCO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool HLADNHKAHLP
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7BEB30", Offset = "0x7BDB30", VA = "0x1807BEB30")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x7BEB10", Offset = "0x7BDB10", VA = "0x1807BEB10")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	protected abstract Hash128 PEAEAENLKEM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int MNFMBGMPNLL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x834600", Offset = "0x833600", VA = "0x180834600", Slot = "8")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public AMBLDLPMMOP ABHINAKIIMM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x774F60", Offset = "0x773F60", VA = "0x180774F60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x774F80", Offset = "0x773F80", VA = "0x180774F80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public bool NPHJLPJOIHM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x11454E0", Offset = "0x11444E0", VA = "0x1811454E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x77EBC0", Offset = "0x77DBC0", VA = "0x18077EBC0")]
	protected EFNAFEGMLEE(LNEEPFHLJNI GLACNLFCFNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x64FDD50", Offset = "0x64FCD50", VA = "0x1864FDD50", Slot = "14")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x7BA2E0", Offset = "0x7B92E0", VA = "0x1807BA2E0", Slot = "15")]
	public virtual bool KBHDPMLGCDE(OHLMKILJLIL GLACNLFCFNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "17")]
	public abstract int IMCHOFPFGJC(PCCEMNFLDAL KBODLDDGOHA);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "18")]
	public abstract int FFALJLPBLOO(PCCEMNFLDAL KBODLDDGOHA);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "19")]
	public abstract void PLJHGNOFKIH(PCCEMNFLDAL KBODLDDGOHA, MKNGMLEHKNN DGJNPDDCCIA, int JHIPOMGDCAK = -1);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "20")]
	public abstract OHLMKILJLIL FKGJFKLEPBD();

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x64FDE80", Offset = "0x64FCE80", VA = "0x1864FDE80", Slot = "10")]
	public Hash128 GJPBIFBBODC(int KBODLDDGOHA)
	{
		return default(Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "22")]
	public abstract PAAKEFABMDD FBJMOHIEKHG();

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "23")]
	public abstract CCLBPPIKLFP DNJIHENBIBD(PCCEMNFLDAL KBODLDDGOHA, JobHandle KHPBICCBDEG);

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x64FDEB0", Offset = "0x64FCEB0", VA = "0x1864FDEB0", Slot = "9")]
	public CCLBPPIKLFP JJKODFABMLK(int KBODLDDGOHA)
	{
		return null;
	}
}
namespace RecRoom.ShapeRendering
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class ShapeRendererConfig : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		public struct ShapeMeshConfigData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			[HideInInspector]
			public string EditorLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public Mesh[] Meshes;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public ShapeMeshConfigData[] MeshConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		[Header("Bevels")]
		public float SmallBevelSizeMeters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public float RoundedBevelSizeMeters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public float BoxAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public float WedgeAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public float PyramidAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		[Tooltip("Smaller dimensions will not exceed sqrt(bevel percent) percent")]
		public bool BevelSizeBasedOnLargestPossibleDimension;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public ComputeShader CopyBonesComputeShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public SkinnedShapeRenderer SkinnedRendererPrefab;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6508080", Offset = "0x6507080", VA = "0x186508080")]
		public ShapeRendererConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class PFOKEPGBPBB
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class BKFBNNELBLM : IEnumerable<ONPEPHNBEHJ>, IEnumerable, IEnumerator<ONPEPHNBEHJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private ONPEPHNBEHJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private int <p>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private int <l>5__3;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		private ONPEPHNBEHJ System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.PrimitiveShapeMeshData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x76F210", Offset = "0x76E210", VA = "0x18076F210", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x76F210", Offset = "0x76E210", VA = "0x18076F210", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x8C0A40", Offset = "0x8BFA40", VA = "0x1808C0A40")]
		[DebuggerHidden]
		public BKFBNNELBLM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x64F7B30", Offset = "0x64F6B30", VA = "0x1864F7B30", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x64F7CA0", Offset = "0x64F6CA0", VA = "0x1864F7CA0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x64F7C00", Offset = "0x64F6C00", VA = "0x1864F7C00", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<ONPEPHNBEHJ> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.PrimitiveShapeMeshData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x64F7C00", Offset = "0x64F6C00", VA = "0x1864F7C00", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private static ONPEPHNBEHJ[][] GHOMCNBPIDM;

	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private static DCOALNMPKOI AHBFOEONFFE;

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public static ShapeRendererConfig BECMHGCGOHO;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public static ComputeShader CLFDIGAILEI
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x65076C0", Offset = "0x65066C0", VA = "0x1865076C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public static SkinnedShapeRenderer EPMCAJCNBNN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6507950", Offset = "0x6506950", VA = "0x186507950")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x6507F30", Offset = "0x6506F30", VA = "0x186507F30")]
	public static Mesh PKPHGBGNFJP(MOENKJEKCPC JGBAEEPJJMB, int KBODLDDGOHA = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x65076A0", Offset = "0x65066A0", VA = "0x1865076A0")]
	public static int FFPGJAAKKNE(MOENKJEKCPC JGBAEEPJJMB, int KBODLDDGOHA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6507550", Offset = "0x6506550", VA = "0x186507550")]
	public static DCOALNMPKOI DHCAHJLJMBB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x65078F0", Offset = "0x65068F0", VA = "0x1865078F0")]
	[IteratorStateMachine(typeof(BKFBNNELBLM))]
	private static IEnumerable<ONPEPHNBEHJ> MLGKDHAFDCF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x6507280", Offset = "0x6506280", VA = "0x186507280")]
	public static ONPEPHNBEHJ AHDLEOPBALJ(MOENKJEKCPC JGBAEEPJJMB, int KBODLDDGOHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x6507530", Offset = "0x6506530", VA = "0x186507530")]
	public static bool DANJLBLKNPM(this MOENKJEKCPC JGBAEEPJJMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x65079B0", Offset = "0x65069B0", VA = "0x1865079B0")]
	public static void PBLINCOBMLA(MOENKJEKCPC JGBAEEPJJMB, float3 PJDEIPAHBPA, [Out] BJLNIDGLICL DIIAIIDAPJA, [Out] float3 GCCMKKDIMLK, [Out] float GIALBJNEGLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x6507B60", Offset = "0x6506B60", VA = "0x186507B60")]
	public static void PECKIILEAGD(Vector3 PJDEIPAHBPA, MOENKJEKCPC JGBAEEPJJMB, [Out] Vector3 GCCMKKDIMLK, [Out] float GIALBJNEGLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x65076B0", Offset = "0x65066B0", VA = "0x1865076B0")]
	[NBFFNNAJFGL(NAPENKJMHBJ.ExitingPlayMode, 0)]
	[DNMDKNDKFKI(0)]
	private static void GDCEDKADNPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x6507720", Offset = "0x6506720", VA = "0x186507720")]
	[NBFFNNAJFGL(NAPENKJMHBJ.ExitingPlayMode, 0)]
	[DNMDKNDKFKI(0)]
	private static void LEHNEBPNNLK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[DefaultMember("Item")]
public class DLGMDADHMPI : JFAHHOFNEID, IDisposable, PIFPICJOEAH
{
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static readonly IMFBLHALHMN DJHKLFMABMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly NAIOGHHNDAP<DPANOCKJNJO, LNEEPFHLJNI> EKGOLNMOPCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly NAIOGHHNDAP<BBCEEBOCHLI, EFNAFEGMLEE> MHMIKFMMPCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly NAIOGHHNDAP<IFCPJPGGOMN, DDNEBEBFNHH> MGJBALJEBJL;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public LNEEPFHLJNI KHIKFGEKFJI
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x64F9BB0", Offset = "0x64F8BB0", VA = "0x1864F9BB0", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public EFNAFEGMLEE KHIKFGEKFJI
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x64F9AF0", Offset = "0x64F8AF0", VA = "0x1864F9AF0", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public DDNEBEBFNHH KHIKFGEKFJI
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x64F9B50", Offset = "0x64F8B50", VA = "0x1864F9B50", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool HLOCOIDPAAM
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x81F7E0", Offset = "0x81E7E0", VA = "0x18081F7E0", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x8D7190", Offset = "0x8D6190", VA = "0x1808D7190")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x64FA2B0", Offset = "0x64F92B0", VA = "0x1864FA2B0")]
	public DLGMDADHMPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x64F9910", Offset = "0x64F8910", VA = "0x1864F9910", Slot = "21")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x64F9D70", Offset = "0x64F8D70", VA = "0x1864F9D70", Slot = "4")]
	public DPANOCKJNJO MFIBLPOIDLD(OMDGJAHDNOG FCLEEDACIMH)
	{
		return default(DPANOCKJNJO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x64F9D70", Offset = "0x64F8D70", VA = "0x1864F9D70", Slot = "5")]
	public DPANOCKJNJO MFIBLPOIDLD(OMDGJAHDNOG FCLEEDACIMH, bool CPNNIFLMKJH)
	{
		return default(DPANOCKJNJO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x64F99A0", Offset = "0x64F89A0", VA = "0x1864F99A0", Slot = "6")]
	public void EHBOPGNFNCE(DPANOCKJNJO GLACNLFCFNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x64FA060", Offset = "0x64F9060", VA = "0x1864FA060", Slot = "7")]
	public void OKHFMKECLEB(DPANOCKJNJO GLACNLFCFNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x64FA0E0", Offset = "0x64F90E0", VA = "0x1864FA0E0", Slot = "8")]
	public BBCEEBOCHLI OOBIHEEMCDI(DPANOCKJNJO GLACNLFCFNI, PJIBALOECAB FCLEEDACIMH)
	{
		return default(BBCEEBOCHLI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x64F9F20", Offset = "0x64F8F20", VA = "0x1864F9F20", Slot = "9")]
	public BBCEEBOCHLI NCFBNOKLJED(DPANOCKJNJO GLACNLFCFNI, MBPIEAIMJBL FCLEEDACIMH)
	{
		return default(BBCEEBOCHLI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x64F9880", Offset = "0x64F8880", VA = "0x1864F9880", Slot = "11")]
	public void BNALKMBKKDF(BBCEEBOCHLI EJIGKCIHDDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x64F9C70", Offset = "0x64F8C70", VA = "0x1864F9C70", Slot = "10")]
	public void JOIAOPKCGNC(BBCEEBOCHLI EJIGKCIHDDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x64F9E10", Offset = "0x64F8E10", VA = "0x1864F9E10", Slot = "20")]
	public IEnumerable<Renderer> MJGANIJOBGC(DPANOCKJNJO GLACNLFCFNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x64F9A00", Offset = "0x64F8A00", VA = "0x1864F9A00", Slot = "12")]
	public IFCPJPGGOMN GHOPCKCGIEK(HNODKHDDIGK FCLEEDACIMH)
	{
		return default(IFCPJPGGOMN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x64F9A80", Offset = "0x64F8A80", VA = "0x1864F9A80", Slot = "14")]
	public void IEMHINPFIEH(IFCPJPGGOMN OJCBILEGNAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x64F9E80", Offset = "0x64F8E80", VA = "0x1864F9E80", Slot = "16")]
	public Task MPKCKPFEOBG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x64F9CD0", Offset = "0x64F8CD0", VA = "0x1864F9CD0", Slot = "17")]
	public Task KJFLJJEFCBK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x64F97E0", Offset = "0x64F87E0", VA = "0x1864F97E0", Slot = "18")]
	public Task AJOFLMDLKEG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x1BEAA60", Offset = "0x1BE9A60", VA = "0x181BEAA60", Slot = "19")]
	public void HLDFDDICKFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x64F9C10", Offset = "0x64F8C10", VA = "0x1864F9C10", Slot = "13")]
	public void IPBEHOEFIBO(IFCPJPGGOMN OJCBILEGNAO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface OJNNFNACCKO
{
	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	bool KHKGKBFDCNM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Material NNGCIHCOMEM();

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Material OEALPCFDGJN();

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Material JNLOEGJCLKK();

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int LCDOJLKEILE(DICKJAHDJCD DPICNHLGKEB);

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int JPLCGIOJGEI(ONHJKJKPMHM DLIDDOCHNFF);

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KCFEGIJGNPD(GameObject GPCHHCACPPJ);

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void JECBGAFNPEB(GameObject GPCHHCACPPJ, bool OILLICJENDN);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class AFGMDAJFADF
{
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static OJNNFNACCKO KKOFNCEIKDA;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public static bool KHKGKBFDCNM
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x64F6D40", Offset = "0x64F5D40", VA = "0x1864F6D40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x64F6CE0", Offset = "0x64F5CE0", VA = "0x1864F6CE0")]
	public static void FOALNHBBIFK(OJNNFNACCKO ACLINLBPOGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x64F70B0", Offset = "0x64F60B0", VA = "0x1864F70B0")]
	public static Material NNGCIHCOMEM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x64F7110", Offset = "0x64F6110", VA = "0x1864F7110")]
	public static Material OEALPCFDGJN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x64F6E90", Offset = "0x64F5E90", VA = "0x1864F6E90")]
	public static Material JNLOEGJCLKK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x64F7040", Offset = "0x64F6040", VA = "0x1864F7040")]
	public static int LCDOJLKEILE(DICKJAHDJCD DPICNHLGKEB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x64F6EF0", Offset = "0x64F5EF0", VA = "0x1864F6EF0")]
	public static int JPLCGIOJGEI(ONHJKJKPMHM DLIDDOCHNFF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x64F6F60", Offset = "0x64F5F60", VA = "0x1864F6F60")]
	public static void KCFEGIJGNPD(GameObject GPCHHCACPPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x64F6DA0", Offset = "0x64F5DA0", VA = "0x1864F6DA0")]
	public static void JECBGAFNPEB(GameObject GPCHHCACPPJ, bool OILLICJENDN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class DDNEBEBFNHH : DLDEGKGNELE
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class OLIFLFHGDNK : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private Renderer <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public DDNEBEBFNHH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x76F210", Offset = "0x76E210", VA = "0x18076F210", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x76F210", Offset = "0x76E210", VA = "0x18076F210", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x8C0A40", Offset = "0x8BFA40", VA = "0x1808C0A40")]
		[DebuggerHidden]
		public OLIFLFHGDNK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x65071F0", Offset = "0x65061F0", VA = "0x1865071F0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x6506ED0", Offset = "0x6505ED0", VA = "0x186506ED0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x6506E80", Offset = "0x6505E80", VA = "0x186506E80")]
		private void GDOLLNLODDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x65071A0", Offset = "0x65061A0", VA = "0x1865071A0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x65070F0", Offset = "0x65060F0", VA = "0x1865070F0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x65070F0", Offset = "0x65060F0", VA = "0x1865070F0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private readonly HNODKHDDIGK BAKNBNILHNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private readonly PIFPICJOEAH CPMHDHDCJKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private ECOPDDFOFBG ALBJFPMLIMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private List<JIJKEMGHEJM> IPPBAFHBOAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private List<JIJKEMGHEJM> OJPHINJGGBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private GameObject CDGJHKAJIED;

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x64F8350", Offset = "0x64F7350", VA = "0x1864F8350")]
	public static DDNEBEBFNHH HKBJDNPOBIP(HNODKHDDIGK FCLEEDACIMH, PIFPICJOEAH CPMHDHDCJKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x64F9700", Offset = "0x64F8700", VA = "0x1864F9700")]
	private DDNEBEBFNHH(HNODKHDDIGK FCLEEDACIMH, PIFPICJOEAH CPMHDHDCJKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x64F9270", Offset = "0x64F8270", VA = "0x1864F9270")]
	public void NIDAGEDDLKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x64F86F0", Offset = "0x64F76F0", VA = "0x1864F86F0")]
	[IteratorStateMachine(typeof(OLIFLFHGDNK))]
	public IEnumerable<Renderer> KKOJOGBNIHG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x64F8770", Offset = "0x64F7770", VA = "0x1864F8770", Slot = "4")]
	public void MFIBBPDPCKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x64F9240", Offset = "0x64F8240", VA = "0x1864F9240")]
	private void NHGMMJAACBJ(Vector3 EIAMKMBCPKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x64F84A0", Offset = "0x64F74A0", VA = "0x1864F84A0")]
	public void HOEJNKLEAPP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class JIJKEMGHEJM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	private struct APGJCJKGJJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public MKNGMLEHKNN HCHAJLPEJAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public OHLMKILJLIL MEGFKIAKDFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public int GGICECMGCLF;
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class FOJFAGFPNHP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public JIJKEMGHEJM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public int numVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public int numIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public PCCEMNFLDAL lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public List<APGJCJKGJJD> boneMeshInfos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public KPDLEIFKJLD combinedMesh;

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public FOJFAGFPNHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x6500720", Offset = "0x64FF720", VA = "0x186500720")]
		internal JobHandle OOPOJJJHBLC()
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x65006F0", Offset = "0x64FF6F0", VA = "0x1865006F0")]
		internal void EIPCPEHLLJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x6500580", Offset = "0x64FF580", VA = "0x186500580")]
		internal void AKJCFNMEJNG()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private int[] PBBDFLJDHKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private JOOIFJIJIHN DDOCBHKPEDF;

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private static Matrix4x4 AJJAPMLJPIN;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public Mesh MMHDKPJDGAO
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E200", VA = "0x18076F200")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x76F1B0", Offset = "0x76E1B0", VA = "0x18076F1B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public int GCEFKOJKPBO
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x775DA0", Offset = "0x774DA0", VA = "0x180775DA0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x777FA0", Offset = "0x776FA0", VA = "0x180777FA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x6501300", Offset = "0x6500300", VA = "0x186501300")]
	public void NNANOFEOHJO(List<OHLMKILJLIL> LKGHLJLFOIH, Matrix4x4[] KOKEMLKEDOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x6500780", Offset = "0x64FF780", VA = "0x186500780")]
	public static List<JIJKEMGHEJM> BJANKEDJCNP(List<LNEEPFHLJNI> NKOODAOOHFM, PCCEMNFLDAL KBODLDDGOHA, Bounds DMOFALMOLIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x6500F90", Offset = "0x64FFF90", VA = "0x186500F90")]
	private JobHandle LDDAOLHEHPK(KPDLEIFKJLD MPPAEOCLDCD, int DOHOPADJJJH, int CBCODDJCNOL, PCCEMNFLDAL KBODLDDGOHA, List<APGJCJKGJJD> FAHGGAECEFL)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x6500EB0", Offset = "0x64FFEB0", VA = "0x186500EB0")]
	private void GJCPFPDKFFO(List<APGJCJKGJJD> FAHGGAECEFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x6501690", Offset = "0x6500690", VA = "0x186501690")]
	private JIJKEMGHEJM(List<APGJCJKGJJD> FAHGGAECEFL, int DOHOPADJJJH, int CBCODDJCNOL, PCCEMNFLDAL KBODLDDGOHA, Bounds DMOFALMOLIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x6500E10", Offset = "0x64FFE10", VA = "0x186500E10", Slot = "4")]
	public void Dispose()
	{
	}
}
namespace RecRoom.ShapeRendering
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class SkinnedShapeRenderer : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private MaterialPropertyBlock MBJJBLEGMGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private JIJKEMGHEJM KBKBNNLDMCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private List<OHLMKILJLIL> ANCDDNAIFMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private RenderTexture HFAPHLLONMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private ComputeBuffer DECKKPBDLFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private ComputeShader GLCIGPJBJBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private Matrix4x4[] AEEENFBPGEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private int GFGJDIIMEOK;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public MeshRenderer MFFAGPLNFDI
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x76F210", Offset = "0x76E210", VA = "0x18076F210")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x76F1A0", Offset = "0x76E1A0", VA = "0x18076F1A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public int ANFAEBGGILE
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x6508D80", Offset = "0x6507D80", VA = "0x186508D80")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x65080B0", Offset = "0x65070B0", VA = "0x1865080B0")]
		public static List<SkinnedShapeRenderer> Create(GameObject GLACNLFCFNI, List<JIJKEMGHEJM> NAMALKCJBIH, List<OHLMKILJLIL> ANCDDNAIFMK, Material DMOCGBANHDO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x6508340", Offset = "0x6507340", VA = "0x186508340")]
		public void Init(JIJKEMGHEJM KBKBNNLDMCD, List<OHLMKILJLIL> ANCDDNAIFMK, Material DMOCGBANHDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x6508CE0", Offset = "0x6507CE0", VA = "0x186508CE0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x6508C40", Offset = "0x6507C40", VA = "0x186508C40")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x6508C00", Offset = "0x6507C00", VA = "0x186508C00")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x6508B40", Offset = "0x6507B40", VA = "0x186508B40")]
		private void OOJIACIPKHB(ScriptableRenderContext ACJODAOHIHK, Camera[] AKDDHEDGHEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x65087D0", Offset = "0x65077D0", VA = "0x1865087D0")]
		private void NNANOFEOHJO(CommandBuffer ABAMJLEGHLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x770CA0", Offset = "0x76FCA0", VA = "0x180770CA0")]
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
