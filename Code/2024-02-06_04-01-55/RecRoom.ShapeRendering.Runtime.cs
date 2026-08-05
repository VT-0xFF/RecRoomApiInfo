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
public class DKDDLDNOMGH : ANMBKNFOENA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private byte HCLJHGADIAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly List<SkinnedShapeRenderer>[] DDNOOJNCLJJ;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int MPECGNGBHIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8BDD90", Offset = "0x8BD190", VA = "0x1808BDD90", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8BDDA0", Offset = "0x8BD1A0", VA = "0x1808BDDA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int AKFBHHKGLIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7DEC20", Offset = "0x7DE020", VA = "0x1807DEC20", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7DEA50", Offset = "0x7DDE50", VA = "0x1807DEA50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public float DBLNGHLDPOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7EC900", Offset = "0x7EBD00", VA = "0x1807EC900", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7EC2F0", Offset = "0x7EB6F0", VA = "0x1807EC2F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float ACFFHAIMAFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7EC100", Offset = "0x7EB500", VA = "0x1807EC100", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7EC3A0", Offset = "0x7EB7A0", VA = "0x1807EC3A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public List<SkinnedShapeRenderer> NIMJHJLNHLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x67C1420", Offset = "0x67C0820", VA = "0x1867C1420")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public List<SkinnedShapeRenderer> KDBOJIJFMAL
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x67C1870", Offset = "0x67C0C70", VA = "0x1867C1870")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public GameObject OPHGKOLAGBH
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7A26C0", Offset = "0x7A1AC0", VA = "0x1807A26C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7A26B0", Offset = "0x7A1AB0", VA = "0x1807A26B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public byte IGGCAEFAFBI
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x67C16C0", Offset = "0x67C0AC0", VA = "0x1867C16C0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x67C1A00", Offset = "0x67C0E00", VA = "0x1867C1A00")]
	public DKDDLDNOMGH(List<PIMAHIDANFJ> OMHABANPDGB, List<PIMAHIDANFJ> CDKDOICDIGK, List<NKGPPJOONDJ> PPBEMPFFJNI, Material LNKFECCMIIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x67C18A0", Offset = "0x67C0CA0", VA = "0x1867C18A0")]
	private int JJMFNCOHHKE(List<PIMAHIDANFJ> AOPBLIMBHCD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x67C1710", Offset = "0x67C0B10", VA = "0x1867C1710")]
	private void HKIKEHIOGAL(int KNLONPGCMIM, bool NAPMNDMEGPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x67C1470", Offset = "0x67C0870", VA = "0x1867C1470")]
	public void BEHGFPEELNE(Vector3 BMNCOMBKEBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x67C15C0", Offset = "0x67C09C0", VA = "0x1867C15C0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x67C19C0", Offset = "0x67C0DC0", VA = "0x1867C19C0")]
	public void PMPPKAAHICF(Transform JIAMJOHJJLH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class BKEOHLKCNNG : ECCPCGEPLFM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private sealed class PCFOCIJNLPE : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public BKEOHLKCNNG <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x7A2690", Offset = "0x7A1A90", VA = "0x1807A2690", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x7A2690", Offset = "0x7A1A90", VA = "0x1807A2690", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x92DDA0", Offset = "0x92D1A0", VA = "0x18092DDA0")]
		[DebuggerHidden]
		public PCFOCIJNLPE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x67CF640", Offset = "0x67CEA40", VA = "0x1867CF640", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x67CF030", Offset = "0x67CE430", VA = "0x1867CF030", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x67CEF90", Offset = "0x67CE390", VA = "0x1867CEF90")]
		private void JIKMBFFNLEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x67CEF40", Offset = "0x67CE340", VA = "0x1867CEF40")]
		private void DNFFEPBIMEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x67CEFE0", Offset = "0x67CE3E0", VA = "0x1867CEFE0")]
		private void JLPNAMOJFPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x67CF5F0", Offset = "0x67CE9F0", VA = "0x1867CF5F0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x67CF540", Offset = "0x67CE940", VA = "0x1867CF540", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x67CF540", Offset = "0x67CE940", VA = "0x1867CF540", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private sealed class NALCKENFDGG : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public BKEOHLKCNNG <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x7A2690", Offset = "0x7A1A90", VA = "0x1807A2690", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x7A2690", Offset = "0x7A1A90", VA = "0x1807A2690", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x92DDA0", Offset = "0x92D1A0", VA = "0x18092DDA0")]
		[DebuggerHidden]
		public NALCKENFDGG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x67CA0D0", Offset = "0x67C94D0", VA = "0x1867CA0D0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x67C9C60", Offset = "0x67C9060", VA = "0x1867C9C60", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x67C9C10", Offset = "0x67C9010", VA = "0x1867C9C10")]
		private void JIKMBFFNLEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x67C9BC0", Offset = "0x67C8FC0", VA = "0x1867C9BC0")]
		private void DNFFEPBIMEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x67CA080", Offset = "0x67C9480", VA = "0x1867CA080", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x67C9FD0", Offset = "0x67C93D0", VA = "0x1867C9FD0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x67C9FD0", Offset = "0x67C93D0", VA = "0x1867C9FD0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly FLBLNHEDKMB IEOLFELCNDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly List<JFGHNOFDLGO> CHHPOBOHFKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private List<ClusterMeshRenderer> KDKENEJAOFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private BatchedMeshRenderer FNMOMJGJMPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private bool JNAHMFPAEJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public readonly bool PGPFDFDLEFC;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IEnumerable<KEHANMPPLDL> AOCEOBIGMAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7A2690", Offset = "0x7A1A90", VA = "0x1807A2690", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int ELOPLDIKPGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x67C04B0", Offset = "0x67BF8B0", VA = "0x1867C04B0", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public NKGPPJOONDJ DDLDMAPPNLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x67BF940", Offset = "0x67BED40", VA = "0x1867BF940", Slot = "8")]
		get
		{
			return default(NKGPPJOONDJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public List<SkinnedShapeRenderer> DAJCPIPOPEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7A4970", Offset = "0x7A3D70", VA = "0x1807A4970")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7A5A10", Offset = "0x7A4E10", VA = "0x1807A5A10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x67BF920", Offset = "0x67BED20", VA = "0x1867BF920")]
	private bool CPOHNMIEGNO(JFGHNOFDLGO FLMAMNCFLMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x67C0F10", Offset = "0x67C0310", VA = "0x1867C0F10")]
	private static bool PAPAOLBAPFM(JFGHNOFDLGO FLMAMNCFLMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x67C0F30", Offset = "0x67C0330", VA = "0x1867C0F30")]
	public BKEOHLKCNNG(FLBLNHEDKMB ALPLHOOHPEL, bool FIJEMLHFNMB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x67BFB10", Offset = "0x67BEF10", VA = "0x1867BFB10", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x67BF780", Offset = "0x67BEB80", VA = "0x1867BF780")]
	public void AFPNFDHLNMK(JFGHNOFDLGO FLMAMNCFLMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x67C04F0", Offset = "0x67BF8F0", VA = "0x1867C04F0")]
	public void JJHPGEAJNEC(JFGHNOFDLGO FLMAMNCFLMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x67C0610", Offset = "0x67BFA10", VA = "0x1867C0610", Slot = "4")]
	public void LAFCMLOHACH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x67C0CC0", Offset = "0x67C00C0", VA = "0x1867C0CC0")]
	public void NEPLKJNDANP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x67BFD40", Offset = "0x67BF140", VA = "0x1867BFD40")]
	private void FHFOPDDACKO(List<JFGHNOFDLGO> CHHPOBOHFKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x67C0B90", Offset = "0x67BFF90", VA = "0x1867C0B90")]
	private static Material LPLPNCJIPFL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x67BFC90", Offset = "0x67BF090", VA = "0x1867BFC90")]
	private void FHFOPDDACKO(JFGHNOFDLGO FLMAMNCFLMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x67C0BF0", Offset = "0x67BFFF0", VA = "0x1867C0BF0")]
	private void MNODJBCJGLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x67BFF00", Offset = "0x67BF300", VA = "0x1867BFF00")]
	public void IHEIOGIIPKL(bool CLEMANBMHJK, bool NGFDBLKLDJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x67BFA90", Offset = "0x67BEE90", VA = "0x1867BFA90")]
	protected void DOHFPBLKOFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x67C0B10", Offset = "0x67BFF10", VA = "0x1867C0B10")]
	[IteratorStateMachine(typeof(PCFOCIJNLPE))]
	public IEnumerable<Renderer> LHJBBEEMBAB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x67BFA10", Offset = "0x67BEE10", VA = "0x1867BFA10")]
	[IteratorStateMachine(typeof(NALCKENFDGG))]
	public IEnumerable<Renderer> DLELPMOEDLO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal class JMAHPOEFOHI : JFGHNOFDLGO
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private struct FBMMNDJHGEE : FAKPMLLHIBL, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private IIBGMLIJNCJ FEBNKEJJFPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private JobHandle POBBNOHNBCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private FLJAOEMFLMF LJCFIHJLGIK;

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x67C2310", Offset = "0x67C1710", VA = "0x1867C2310")]
		public FBMMNDJHGEE(IIBGMLIJNCJ FEBNKEJJFPJ, JobHandle POBBNOHNBCI, FLJAOEMFLMF LJCFIHJLGIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x67C2290", Offset = "0x67C1690", VA = "0x1867C2290", Slot = "4")]
		public IIBGMLIJNCJ DMBFJJDECOC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x67C22C0", Offset = "0x67C16C0", VA = "0x1867C22C0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly EOBDMAABGDF FPOBBIONCPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private float JLAMCEECDKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private Hash128 PJMNGLJKPCM;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	protected override Hash128 OCDGACMEAPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x67C7390", Offset = "0x67C6790", VA = "0x1867C7390", Slot = "21")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x67C8A50", Offset = "0x67C7E50", VA = "0x1867C8A50")]
	public JMAHPOEFOHI(BKEOHLKCNNG DHHBNGOGOPD, EOBDMAABGDF ALPLHOOHPEL, bool FIJEMLHFNMB = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7E7780", Offset = "0x7E6B80", VA = "0x1807E7780", Slot = "15")]
	public override bool GOKOIEEMBHL(NKGPPJOONDJ DHHBNGOGOPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x67C74C0", Offset = "0x67C68C0", VA = "0x1867C74C0", Slot = "17")]
	public override int JJMFNCOHHKE(ECCMJPDPIEF DBHMHAHLCPM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x67C7F60", Offset = "0x67C7360", VA = "0x1867C7F60", Slot = "18")]
	public override int PDDLFMJFEBJ(ECCMJPDPIEF DBHMHAHLCPM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x67C7840", Offset = "0x67C6C40", VA = "0x1867C7840", Slot = "19")]
	public override void MEMHJIINJJC(ECCMJPDPIEF DBHMHAHLCPM, KILMAMMLMFP POCCMIKDLPB, int DHOIJHBLAFE = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x67C72C0", Offset = "0x67C66C0", VA = "0x1867C72C0", Slot = "20")]
	public override NKGPPJOONDJ GKJAAFCLFLD()
	{
		return default(NKGPPJOONDJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x67C7690", Offset = "0x67C6A90", VA = "0x1867C7690", Slot = "22")]
	public override LFLIEAICBMH LNOBFHMHKGP()
	{
		return default(LFLIEAICBMH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x67C8130", Offset = "0x67C7530", VA = "0x1867C8130", Slot = "23")]
	public override FAKPMLLHIBL PLGMKBCNBBH(ECCMJPDPIEF DBHMHAHLCPM, JobHandle POBBNOHNBCI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[DefaultMember("Item")]
public interface LGAOIPEDPOL
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	BKEOHLKCNNG LANLGIDAOPG
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	JFGHNOFDLGO LANLGIDAOPG
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	JKCKIMPHOGD LANLGIDAOPG
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[DefaultMember("Item")]
public class PAKMIHEHGGK : IPAOBGLAFFA, IDisposable, LGAOIPEDPOL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct EJDFAHGICPM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public PAKMIHEHGGK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x67C1D10", Offset = "0x67C1110", VA = "0x1867C1D10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x67C2230", Offset = "0x67C1630", VA = "0x1867C2230", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly DBNJDALBBCB<FAKFMHONLAF, BKEOHLKCNNG> GLPOIDFCMDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly DBNJDALBBCB<IDLIHOLLEII, JFGHNOFDLGO> CHHPOBOHFKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly DBNJDALBBCB<LAOHBAMIBMH, JKCKIMPHOGD> DJOPPIJNBCO;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public BKEOHLKCNNG LANLGIDAOPG
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x67CC980", Offset = "0x67CBD80", VA = "0x1867CC980", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public JFGHNOFDLGO LANLGIDAOPG
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x67CCA40", Offset = "0x67CBE40", VA = "0x1867CCA40", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public JKCKIMPHOGD LANLGIDAOPG
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x67CC9E0", Offset = "0x67CBDE0", VA = "0x1867CC9E0", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool HKCKGDFGOJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x87DA20", Offset = "0x87CE20", VA = "0x18087DA20", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x936260", Offset = "0x935660", VA = "0x180936260")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x67CEA90", Offset = "0x67CDE90", VA = "0x1867CEA90")]
	public PAKMIHEHGGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x67CD830", Offset = "0x67CCC30", VA = "0x1867CD830", Slot = "21")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x67CEA20", Offset = "0x67CDE20", VA = "0x1867CEA20", Slot = "4")]
	public FAKFMHONLAF NLFMBHGIGIG(FLBLNHEDKMB ALPLHOOHPEL)
	{
		return default(FAKFMHONLAF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x67CE7A0", Offset = "0x67CDBA0", VA = "0x1867CE7A0", Slot = "5")]
	public FAKFMHONLAF NLFMBHGIGIG(FLBLNHEDKMB ALPLHOOHPEL, bool FIJEMLHFNMB)
	{
		return default(FAKFMHONLAF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x67CCB20", Offset = "0x67CBF20", VA = "0x1867CCB20", Slot = "6")]
	public void BGJPKAAKBOA(FAKFMHONLAF DHHBNGOGOPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x67CD9C0", Offset = "0x67CCDC0", VA = "0x1867CD9C0", Slot = "7")]
	public void EFCAODNGOOF(FAKFMHONLAF DHHBNGOGOPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x67CE110", Offset = "0x67CD510", VA = "0x1867CE110", Slot = "8")]
	public IDLIHOLLEII IHLMPPBAHGJ(FAKFMHONLAF DHHBNGOGOPD, FAJNGDEKOJP ALPLHOOHPEL)
	{
		return default(IDLIHOLLEII);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x67CD350", Offset = "0x67CC750", VA = "0x1867CD350", Slot = "9")]
	public IDLIHOLLEII DLOAFDDBHKD(FAKFMHONLAF DHHBNGOGOPD, EOBDMAABGDF ALPLHOOHPEL)
	{
		return default(IDLIHOLLEII);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x67CCF90", Offset = "0x67CC390", VA = "0x1867CCF90", Slot = "11")]
	public void DHCGPANJGON(IDLIHOLLEII FLMAMNCFLMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x67CDD20", Offset = "0x67CD120", VA = "0x1867CDD20", Slot = "10")]
	public void GLDMGFAOPJO(IDLIHOLLEII FLMAMNCFLMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x67CE730", Offset = "0x67CDB30", VA = "0x1867CE730", Slot = "20")]
	public IEnumerable<Renderer> LAKLMOIHKBL(FAKFMHONLAF DHHBNGOGOPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x67CCAA0", Offset = "0x67CBEA0", VA = "0x1867CCAA0", Slot = "12")]
	public LAOHBAMIBMH AONECIJCFFH(ANCKKNKPDAB ALPLHOOHPEL)
	{
		return default(LAOHBAMIBMH);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x67CE5F0", Offset = "0x67CD9F0", VA = "0x1867CE5F0", Slot = "14")]
	public void ILEBFEPPNFO(LAOHBAMIBMH JMDNGKNPOLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x67CDF80", Offset = "0x67CD380", VA = "0x1867CDF80", Slot = "16")]
	public Task HJOHIALLDIE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x67CCD80", Offset = "0x67CC180", VA = "0x1867CCD80", Slot = "17")]
	public Task BJBLMJKDLBA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x67CE660", Offset = "0x67CDA60", VA = "0x1867CE660", Slot = "18")]
	[AsyncStateMachine(typeof(EJDFAHGICPM))]
	public Task JALIIDIAKCB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x67CCF00", Offset = "0x67CC300", VA = "0x1867CCF00", Slot = "19")]
	public void CKNNPBBJCPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x67CEA30", Offset = "0x67CDE30", VA = "0x1867CEA30", Slot = "13")]
	public void NPKCOAAMNIL(LAOHBAMIBMH JMDNGKNPOLB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal class FEAAKIILLKE : JFGHNOFDLGO
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	private struct IKGJCLHCEEF : FAKPMLLHIBL, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private IIBGMLIJNCJ FEBNKEJJFPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private JobHandle POBBNOHNBCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private EPHOBMLGKGO LJCFIHJLGIK;

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x67C5BC0", Offset = "0x67C4FC0", VA = "0x1867C5BC0")]
		public IKGJCLHCEEF(IIBGMLIJNCJ FEBNKEJJFPJ, JobHandle POBBNOHNBCI, EPHOBMLGKGO LJCFIHJLGIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x67C5B40", Offset = "0x67C4F40", VA = "0x1867C5B40", Slot = "4")]
		public IIBGMLIJNCJ DMBFJJDECOC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x67C5B70", Offset = "0x67C4F70", VA = "0x1867C5B70", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly FAJNGDEKOJP NCANEPOJAJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private int[] AMIOIIKDJIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private Hash128 PJMNGLJKPCM;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public override JGLEGABGFEJ IPIHIOHDHJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x67C2E20", Offset = "0x67C2220", VA = "0x1867C2E20", Slot = "16")]
		get
		{
			return default(JGLEGABGFEJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	private Vector3 OOHPPBGDBDA
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x67C2370", Offset = "0x67C1770", VA = "0x1867C2370")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	protected override Hash128 OCDGACMEAPN
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x67C2C50", Offset = "0x67C2050", VA = "0x1867C2C50", Slot = "21")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x67C4650", Offset = "0x67C3A50", VA = "0x1867C4650")]
	public FEAAKIILLKE(BKEOHLKCNNG DHHBNGOGOPD, FAJNGDEKOJP ALPLHOOHPEL, bool DGOFCIGOJEM = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x67C27C0", Offset = "0x67C1BC0", VA = "0x1867C27C0", Slot = "15")]
	public override bool GOKOIEEMBHL(NKGPPJOONDJ DHHBNGOGOPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x67C2D80", Offset = "0x67C2180", VA = "0x1867C2D80", Slot = "17")]
	public override int JJMFNCOHHKE(ECCMJPDPIEF DBHMHAHLCPM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x67C3D70", Offset = "0x67C3170", VA = "0x1867C3D70", Slot = "18")]
	public override int PDDLFMJFEBJ(ECCMJPDPIEF DBHMHAHLCPM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x67C3B20", Offset = "0x67C2F20", VA = "0x1867C3B20")]
	private int OPMPLEEPIIM(ECCMJPDPIEF DBHMHAHLCPM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x67C3390", Offset = "0x67C2790", VA = "0x1867C3390", Slot = "19")]
	public override void MEMHJIINJJC(ECCMJPDPIEF DBHMHAHLCPM, KILMAMMLMFP POCCMIKDLPB, int DHOIJHBLAFE = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x67C26F0", Offset = "0x67C1AF0", VA = "0x1867C26F0", Slot = "20")]
	public override NKGPPJOONDJ GKJAAFCLFLD()
	{
		return default(NKGPPJOONDJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x67C31E0", Offset = "0x67C25E0", VA = "0x1867C31E0", Slot = "22")]
	public override LFLIEAICBMH LNOBFHMHKGP()
	{
		return default(LFLIEAICBMH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x67C3E10", Offset = "0x67C3210", VA = "0x1867C3E10", Slot = "23")]
	public override FAKPMLLHIBL PLGMKBCNBBH(ECCMJPDPIEF DBHMHAHLCPM, JobHandle POBBNOHNBCI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface BFGPLADBIDF
{
	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ICLBADFPLJL(INGFDOACPCK FICJMFBEBIN, Renderer PFFFLMMGJDB, int CAEPMIFBNDC);

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DHJMPDGDOLJ(Renderer PFFFLMMGJDB, OJNFCBEFFCD HIEJGLDFDFJ, Vector3 FIKHJJGIGII, Vector3 MMEIFBBNGCP, Vector3 OIMBFODOALB, float ECLPBBJBLFJ, float BBIDOHGAAFH, float LIPODOIGOBJ = -1f, [Optional] Color? MNHFMCFPMMK, [Optional] IReadOnlyList<Camera> MMJGJPBLGOD);

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HNMKEKKDFGK(Renderer PFFFLMMGJDB, int CAEPMIFBNDC);

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int PKPLFGHADKJ();

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CNEFGFEHEBE(int NCPPHJKAGGI, PBFAHIGAOLI FICJMFBEBIN, Renderer PFFFLMMGJDB, int CAEPMIFBNDC);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class OAHNHPNAAHC : PEPEGHHKMCG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	private class GFKIOFJAICI : CELOOHMGOGA<int>
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x67C5930", Offset = "0x67C4D30", VA = "0x1867C5930")]
		public GFKIOFJAICI(string GFBABMFGHOJ)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly BFGPLADBIDF NNHBBCMBMDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly LGAOIPEDPOL DFHEKKBGHAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private MeshRenderer HIIJEEJNOHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private GFKIOFJAICI BCIOKMPPCJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private bool CKHHEDPEFPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private MeshRenderer AHMCGKPAIJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private GFKIOFJAICI IKJGONNAEPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private bool CEICENKAFND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private MeshRenderer ALKILIBDHOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private GFKIOFJAICI KEDABFOAPBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private bool MAJPLCAILFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private bool KAJILOPLFHP;

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x7A4380", Offset = "0x7A3780", VA = "0x1807A4380")]
	public OAHNHPNAAHC(BFGPLADBIDF EOEMCPCDELD, LGAOIPEDPOL DFHEKKBGHAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x67CAA90", Offset = "0x67C9E90", VA = "0x1867CAA90", Slot = "23")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x67CA720", Offset = "0x67C9B20", VA = "0x1867CA720")]
	private void BKKPJDHAGHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x67CA200", Offset = "0x67C9600", VA = "0x1867CA200", Slot = "4")]
	public void BFHDHLPPGNK(FAKFMHONLAF DHHBNGOGOPD, PBFAHIGAOLI DBDNECKMLBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x67CA500", Offset = "0x67C9900", VA = "0x1867CA500", Slot = "5")]
	public void BFHDHLPPGNK(IDLIHOLLEII FLMAMNCFLMF, PBFAHIGAOLI DBDNECKMLBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x67CC850", Offset = "0x67CBC50", VA = "0x1867CC850", Slot = "6")]
	public void PKMCEMFHDKC(IDLIHOLLEII FLMAMNCFLMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x67CC740", Offset = "0x67CBB40", VA = "0x1867CC740", Slot = "7")]
	public void OJMNDHDHKFN(IDLIHOLLEII FLMAMNCFLMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x67CAF10", Offset = "0x67CA310", VA = "0x1867CAF10", Slot = "24")]
	public void EMOFIONHAMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x8CEF60", Offset = "0x8CE360", VA = "0x1808CEF60", Slot = "8")]
	public void JNKLJKMHOFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x67CB600", Offset = "0x67CAA00", VA = "0x1867CB600", Slot = "9")]
	public void GLIAFOMANJG(PBFAHIGAOLI DBDNECKMLBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x67CB320", Offset = "0x67CA720", VA = "0x1867CB320", Slot = "10")]
	public void GJGAMCAKMPJ(FAKFMHONLAF DHHBNGOGOPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x67CAFF0", Offset = "0x67CA3F0", VA = "0x1867CAFF0", Slot = "11")]
	public void GJGAMCAKMPJ(IDLIHOLLEII FLMAMNCFLMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x67CAF50", Offset = "0x67CA350", VA = "0x1867CAF50", Slot = "12")]
	public void GFMCNPFAAJN(IDLIHOLLEII FLMAMNCFLMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x67CAA00", Offset = "0x67C9E00", VA = "0x1867CAA00", Slot = "13")]
	public void DMPPBMKGLCN(IDLIHOLLEII FLMAMNCFLMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x67CAC40", Offset = "0x67CA040", VA = "0x1867CAC40")]
	private void EECHNNCKFAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0xFEE7B0", Offset = "0xFEDBB0", VA = "0x180FEE7B0", Slot = "14")]
	public void FKCEIKMLAJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x67CB8A0", Offset = "0x67CACA0", VA = "0x1867CB8A0", Slot = "15")]
	public void JCBKBJFCIKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x67CBC00", Offset = "0x67CB000", VA = "0x1867CBC00", Slot = "16")]
	public void MCOJLGIPJCI(FAKFMHONLAF DHHBNGOGOPD, INGFDOACPCK FICJMFBEBIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x67CA960", Offset = "0x67C9D60", VA = "0x1867CA960", Slot = "17")]
	public void DGFLNOMINKK(IDLIHOLLEII FLMAMNCFLMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x67CAE80", Offset = "0x67CA280", VA = "0x1867CAE80", Slot = "18")]
	public void EGOPEAIBBJO(IDLIHOLLEII FLMAMNCFLMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x88BBB0", Offset = "0x88AFB0", VA = "0x18088BBB0", Slot = "19")]
	public void JJFNGDGDMII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x67CB770", Offset = "0x67CAB70", VA = "0x1867CB770", Slot = "20")]
	public void IMEJMKOPOGG(INGFDOACPCK FICJMFBEBIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x67CB9C0", Offset = "0x67CADC0", VA = "0x1867CB9C0")]
	private void KAECFBMIFHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x67CBED0", Offset = "0x67CB2D0", VA = "0x1867CBED0", Slot = "21")]
	public void NMNPNJLOAHG(FAKFMHONLAF DHHBNGOGOPD, Vector3 FIKHJJGIGII, Vector3 MMEIFBBNGCP, Vector3 OIMBFODOALB, float ECLPBBJBLFJ, float BBIDOHGAAFH, IReadOnlyList<Camera> MLOOKCEPMBG, OJNFCBEFFCD HIEJGLDFDFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x67CC2A0", Offset = "0x67CB6A0", VA = "0x1867CC2A0", Slot = "22")]
	public void NMNPNJLOAHG(LAOHBAMIBMH JMDNGKNPOLB, Vector3 FIKHJJGIGII, Vector3 MMEIFBBNGCP, Vector3 OIMBFODOALB, float ECLPBBJBLFJ, float BBIDOHGAAFH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public abstract class JFGHNOFDLGO : IOBPIOAJGIN, KEHANMPPLDL, NJAOPACGICL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly BKEOHLKCNNG OPHGKOLAGBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	protected Bounds EBMGIPGJJAE;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public Bounds HFHKKCNCDOI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0xE47360", Offset = "0xE46760", VA = "0x180E47360", Slot = "4")]
		get
		{
			return default(Bounds);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public virtual JGLEGABGFEJ IPIHIOHDHJK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x67C5DA0", Offset = "0x67C51A0", VA = "0x1867C5DA0", Slot = "16")]
		get
		{
			return default(JGLEGABGFEJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool PGPFDFDLEFC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7EC380", Offset = "0x7EB780", VA = "0x1807EC380")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x7EC910", Offset = "0x7EBD10", VA = "0x1807EC910")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	protected abstract Hash128 OCDGACMEAPN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int MLFJOONEMOL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x7EB4F0", Offset = "0x7EA8F0", VA = "0x1807EB4F0", Slot = "8")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public PFIMOLJJLAM CJIAOAJHKEG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x7A4970", Offset = "0x7A3D70", VA = "0x1807A4970")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x7A5A10", Offset = "0x7A4E10", VA = "0x1807A5A10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public bool PDOLIHKKCAN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x11B4D90", Offset = "0x11B4190", VA = "0x1811B4D90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7AAC60", Offset = "0x7AA060", VA = "0x1807AAC60")]
	protected JFGHNOFDLGO(BKEOHLKCNNG DHHBNGOGOPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x67C5C10", Offset = "0x67C5010", VA = "0x1867C5C10", Slot = "14")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x7E7780", Offset = "0x7E6B80", VA = "0x1807E7780", Slot = "15")]
	public virtual bool GOKOIEEMBHL(NKGPPJOONDJ DHHBNGOGOPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "17")]
	public abstract int JJMFNCOHHKE(ECCMJPDPIEF DBHMHAHLCPM);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "18")]
	public abstract int PDDLFMJFEBJ(ECCMJPDPIEF DBHMHAHLCPM);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "19")]
	public abstract void MEMHJIINJJC(ECCMJPDPIEF DBHMHAHLCPM, KILMAMMLMFP POCCMIKDLPB, int DHOIJHBLAFE = -1);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "20")]
	public abstract NKGPPJOONDJ GKJAAFCLFLD();

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x67C5D70", Offset = "0x67C5170", VA = "0x1867C5D70", Slot = "10")]
	public Hash128 GPIHIJFHLDJ(int DBHMHAHLCPM)
	{
		return default(Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "22")]
	public abstract LFLIEAICBMH LNOBFHMHKGP();

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "23")]
	public abstract FAKPMLLHIBL PLGMKBCNBBH(ECCMJPDPIEF DBHMHAHLCPM, JobHandle POBBNOHNBCI);

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x67C5D40", Offset = "0x67C5140", VA = "0x1867C5D40", Slot = "9")]
	public FAKPMLLHIBL FEANCGLIFKK(int DBHMHAHLCPM)
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
		[Cpp2IlInjected.Address(RVA = "0x67D0B70", Offset = "0x67CFF70", VA = "0x1867D0B70")]
		public ShapeRendererConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class FKGEOFCMKOB
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class HBFIELIDDFD : IEnumerable<FPNDIDHEHDF>, IEnumerable, IEnumerator<FPNDIDHEHDF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private FPNDIDHEHDF <>2__current;

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
		private FPNDIDHEHDF System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.PrimitiveShapeMeshData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x7A2690", Offset = "0x7A1A90", VA = "0x1807A2690", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x7A2690", Offset = "0x7A1A90", VA = "0x1807A2690", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x92DDA0", Offset = "0x92D1A0", VA = "0x18092DDA0")]
		[DebuggerHidden]
		public HBFIELIDDFD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x67C5980", Offset = "0x67C4D80", VA = "0x1867C5980", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x67C5AF0", Offset = "0x67C4EF0", VA = "0x1867C5AF0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x67C5A50", Offset = "0x67C4E50", VA = "0x1867C5A50", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<FPNDIDHEHDF> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.PrimitiveShapeMeshData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x67C5A50", Offset = "0x67C4E50", VA = "0x1867C5A50", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private static FPNDIDHEHDF[][] FIAOJMFKIGH;

	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private static JFHLEFPFCKO BEGLJOHBADH;

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public static ShapeRendererConfig BFFLFOFOIOA;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public static ComputeShader LCEBHGCKCGA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x67C5820", Offset = "0x67C4C20", VA = "0x1867C5820")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public static SkinnedShapeRenderer LDECHIBDJJG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x67C4BD0", Offset = "0x67C3FD0", VA = "0x1867C4BD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x67C4B30", Offset = "0x67C3F30", VA = "0x1867C4B30")]
	public static Mesh AEILMDKLIHM(NCNGGCJOHPL IIIIMFENOFG, int DBHMHAHLCPM = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x67C4C30", Offset = "0x67C4030", VA = "0x1867C4C30")]
	public static int CLLCKHNECLJ(NCNGGCJOHPL IIIIMFENOFG, int DBHMHAHLCPM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x67C5520", Offset = "0x67C4920", VA = "0x1867C5520")]
	public static JFHLEFPFCKO NPHLDKAAFPI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x67C54A0", Offset = "0x67C48A0", VA = "0x1867C54A0")]
	[IteratorStateMachine(typeof(HBFIELIDDFD))]
	private static IEnumerable<FPNDIDHEHDF> NGGPBGEJBNE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x67C4C40", Offset = "0x67C4040", VA = "0x1867C4C40")]
	public static FPNDIDHEHDF IHAPIIJINFG(NCNGGCJOHPL IIIIMFENOFG, int DBHMHAHLCPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x67C5500", Offset = "0x67C4900", VA = "0x1867C5500")]
	public static bool NIMIKMHCKGL(this NCNGGCJOHPL IIIIMFENOFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x67C5670", Offset = "0x67C4A70", VA = "0x1867C5670")]
	public static void ONKGINHGDGM(NCNGGCJOHPL IIIIMFENOFG, float3 KAFHMAAAGMA, [Out] NOAKNDBOBFM MFKBKCBOOIE, [Out] float3 ONGINJPPNOJ, [Out] float OCCGGHMEPFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x67C50C0", Offset = "0x67C44C0", VA = "0x1867C50C0")]
	public static void LNMNJGLFGEF(Vector3 KAFHMAAAGMA, NCNGGCJOHPL IIIIMFENOFG, [Out] Vector3 ONGINJPPNOJ, [Out] float OCCGGHMEPFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x67C5490", Offset = "0x67C4890", VA = "0x1867C5490")]
	[AFMMEBJJOHC(EHBEGHACGPO.ExitingPlayMode, 0)]
	[BIJJCFFILDL(0)]
	private static void MAKCCCENKCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x67C4EF0", Offset = "0x67C42F0", VA = "0x1867C4EF0")]
	[AFMMEBJJOHC(EHBEGHACGPO.ExitingPlayMode, 0)]
	[BIJJCFFILDL(0)]
	private static void KNLNMPECKDA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[DefaultMember("Item")]
public class MKLCCBJAFKK : IPAOBGLAFFA, IDisposable, LGAOIPEDPOL
{
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static readonly OKECMMGLCGL ECHPFBNKINH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly DBNJDALBBCB<FAKFMHONLAF, BKEOHLKCNNG> GLPOIDFCMDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly DBNJDALBBCB<IDLIHOLLEII, JFGHNOFDLGO> CHHPOBOHFKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly DBNJDALBBCB<LAOHBAMIBMH, JKCKIMPHOGD> DJOPPIJNBCO;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public BKEOHLKCNNG LANLGIDAOPG
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x67C8D60", Offset = "0x67C8160", VA = "0x1867C8D60", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public JFGHNOFDLGO LANLGIDAOPG
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x67C8D00", Offset = "0x67C8100", VA = "0x1867C8D00", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public JKCKIMPHOGD LANLGIDAOPG
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x67C8DC0", Offset = "0x67C81C0", VA = "0x1867C8DC0", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool HKCKGDFGOJO
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x87DA20", Offset = "0x87CE20", VA = "0x18087DA20", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x936260", Offset = "0x935660", VA = "0x180936260")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x67C97D0", Offset = "0x67C8BD0", VA = "0x1867C97D0")]
	public MKLCCBJAFKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x67C9170", Offset = "0x67C8570", VA = "0x1867C9170", Slot = "21")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x67C9640", Offset = "0x67C8A40", VA = "0x1867C9640", Slot = "4")]
	public FAKFMHONLAF NLFMBHGIGIG(FLBLNHEDKMB ALPLHOOHPEL)
	{
		return default(FAKFMHONLAF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x67C9640", Offset = "0x67C8A40", VA = "0x1867C9640", Slot = "5")]
	public FAKFMHONLAF NLFMBHGIGIG(FLBLNHEDKMB ALPLHOOHPEL, bool FIJEMLHFNMB)
	{
		return default(FAKFMHONLAF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x67C8EA0", Offset = "0x67C82A0", VA = "0x1867C8EA0", Slot = "6")]
	public void BGJPKAAKBOA(FAKFMHONLAF DHHBNGOGOPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x67C9200", Offset = "0x67C8600", VA = "0x1867C9200", Slot = "7")]
	public void EFCAODNGOOF(FAKFMHONLAF DHHBNGOGOPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x67C9380", Offset = "0x67C8780", VA = "0x1867C9380", Slot = "8")]
	public IDLIHOLLEII IHLMPPBAHGJ(FAKFMHONLAF DHHBNGOGOPD, FAJNGDEKOJP ALPLHOOHPEL)
	{
		return default(IDLIHOLLEII);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x67C9030", Offset = "0x67C8430", VA = "0x1867C9030", Slot = "9")]
	public IDLIHOLLEII DLOAFDDBHKD(FAKFMHONLAF DHHBNGOGOPD, EOBDMAABGDF ALPLHOOHPEL)
	{
		return default(IDLIHOLLEII);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x67C8FA0", Offset = "0x67C83A0", VA = "0x1867C8FA0", Slot = "11")]
	public void DHCGPANJGON(IDLIHOLLEII FLMAMNCFLMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x67C9280", Offset = "0x67C8680", VA = "0x1867C9280", Slot = "10")]
	public void GLDMGFAOPJO(IDLIHOLLEII FLMAMNCFLMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x67C95D0", Offset = "0x67C89D0", VA = "0x1867C95D0", Slot = "20")]
	public IEnumerable<Renderer> LAKLMOIHKBL(FAKFMHONLAF DHHBNGOGOPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x67C8E20", Offset = "0x67C8220", VA = "0x1867C8E20", Slot = "12")]
	public LAOHBAMIBMH AONECIJCFFH(ANCKKNKPDAB ALPLHOOHPEL)
	{
		return default(LAOHBAMIBMH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x67C94C0", Offset = "0x67C88C0", VA = "0x1867C94C0", Slot = "14")]
	public void ILEBFEPPNFO(LAOHBAMIBMH JMDNGKNPOLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x67C92E0", Offset = "0x67C86E0", VA = "0x1867C92E0", Slot = "16")]
	public Task HJOHIALLDIE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x67C8F00", Offset = "0x67C8300", VA = "0x1867C8F00", Slot = "17")]
	public Task BJBLMJKDLBA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x67C9530", Offset = "0x67C8930", VA = "0x1867C9530", Slot = "18")]
	public Task JALIIDIAKCB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x1C6B100", Offset = "0x1C6A500", VA = "0x181C6B100", Slot = "19")]
	public void CKNNPBBJCPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x67C96E0", Offset = "0x67C8AE0", VA = "0x1867C96E0", Slot = "13")]
	public void NPKCOAAMNIL(LAOHBAMIBMH JMDNGKNPOLB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface CDCEDPEGMNO
{
	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	bool FPIBDKKIPEN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Material KDGHEIODGKA();

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Material LPLPNCJIPFL();

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Material CBCBCIOPAPN();

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int CKBOEPAAHOJ(CCPEEPBGDGI EFIGNALHDDN);

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int KLOBIKJBOEP(DEEJPCOLBIH DOENGLHCLOB);

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KCNACMOIOPH(GameObject BHPOPDOKECN);

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void EDJDGAPFDFO(GameObject BHPOPDOKECN, bool DIPPELKPKPP);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class FFHAGNFJGCA
{
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static CDCEDPEGMNO FBIBFNALIEI;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public static bool FPIBDKKIPEN
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x67C4AD0", Offset = "0x67C3ED0", VA = "0x1867C4AD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x67C48C0", Offset = "0x67C3CC0", VA = "0x1867C48C0")]
	public static void IBMFPKEOJJG(CDCEDPEGMNO OAILCILMHFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x67C4A00", Offset = "0x67C3E00", VA = "0x1867C4A00")]
	public static Material KDGHEIODGKA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x67C0B90", Offset = "0x67BFF90", VA = "0x1867C0B90")]
	public static Material LPLPNCJIPFL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x67C4700", Offset = "0x67C3B00", VA = "0x1867C4700")]
	public static Material CBCBCIOPAPN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x67C4760", Offset = "0x67C3B60", VA = "0x1867C4760")]
	public static int CKBOEPAAHOJ(CCPEEPBGDGI EFIGNALHDDN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x67C4A60", Offset = "0x67C3E60", VA = "0x1867C4A60")]
	public static int KLOBIKJBOEP(DEEJPCOLBIH DOENGLHCLOB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x67C4920", Offset = "0x67C3D20", VA = "0x1867C4920")]
	public static void KCNACMOIOPH(GameObject BHPOPDOKECN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x67C47D0", Offset = "0x67C3BD0", VA = "0x1867C47D0")]
	public static void EDJDGAPFDFO(GameObject BHPOPDOKECN, bool DIPPELKPKPP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class JKCKIMPHOGD : ECCPCGEPLFM
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class CBGJBCKAMNG : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public JKCKIMPHOGD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x7A2690", Offset = "0x7A1A90", VA = "0x1807A2690", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x7A2690", Offset = "0x7A1A90", VA = "0x1807A2690", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x92DDA0", Offset = "0x92D1A0", VA = "0x18092DDA0")]
		[DebuggerHidden]
		public CBGJBCKAMNG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x67C1390", Offset = "0x67C0790", VA = "0x1867C1390", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x67C1070", Offset = "0x67C0470", VA = "0x1867C1070", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x67C1020", Offset = "0x67C0420", VA = "0x1867C1020")]
		private void JIKMBFFNLEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x67C1340", Offset = "0x67C0740", VA = "0x1867C1340", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x67C1290", Offset = "0x67C0690", VA = "0x1867C1290", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x67C1290", Offset = "0x67C0690", VA = "0x1867C1290", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private readonly ANCKKNKPDAB ADHFNKHMFOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private readonly LGAOIPEDPOL DFHEKKBGHAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private DKDDLDNOMGH NECHIIKEDNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private List<PIMAHIDANFJ> KLFEAHCLFHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private List<PIMAHIDANFJ> KOGLBPNBPOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private GameObject DPGOBLLOIEP;

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x67C62F0", Offset = "0x67C56F0", VA = "0x1867C62F0")]
	public static JKCKIMPHOGD KHNLMCPMGKN(ANCKKNKPDAB ALPLHOOHPEL, LGAOIPEDPOL DFHEKKBGHAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x67C71E0", Offset = "0x67C65E0", VA = "0x1867C71E0")]
	private JKCKIMPHOGD(ANCKKNKPDAB ALPLHOOHPEL, LGAOIPEDPOL DFHEKKBGHAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x67C5E60", Offset = "0x67C5260", VA = "0x1867C5E60")]
	public void IEJPDCFHNJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x67C6F10", Offset = "0x67C6310", VA = "0x1867C6F10")]
	[IteratorStateMachine(typeof(CBGJBCKAMNG))]
	public IEnumerable<Renderer> LHJBBEEMBAB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x67C6440", Offset = "0x67C5840", VA = "0x1867C6440", Slot = "4")]
	public void LAFCMLOHACH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x67C5E30", Offset = "0x67C5230", VA = "0x1867C5E30")]
	private void GEOPIACNNJE(Vector3 BMNCOMBKEBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x67C6F90", Offset = "0x67C6390", VA = "0x1867C6F90")]
	public void NEPLKJNDANP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class PIMAHIDANFJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	private struct CEDKKFPGCJI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public KILMAMMLMFP PBOGGGCJGAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public NKGPPJOONDJ ELALALDBPML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public int HMNKMLAPJIC;
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class MDMFOHCGCIH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public PIMAHIDANFJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public int numVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public int numIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public ECCMJPDPIEF lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public List<CEDKKFPGCJI> boneMeshInfos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public IIBGMLIJNCJ combinedMesh;

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
		public MDMFOHCGCIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x67C8B00", Offset = "0x67C7F00", VA = "0x1867C8B00")]
		internal JobHandle BOHAJKGCMGE()
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x67C8B60", Offset = "0x67C7F60", VA = "0x1867C8B60")]
		internal void MAMCHPDOEPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x67C8B90", Offset = "0x67C7F90", VA = "0x1867C8B90")]
		internal void NKIEJLBLBJO()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private int[] PNBAPIMFIAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private BKOCPAPMJEF ADFPIDNHOCA;

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private static Matrix4x4 PPHIJJGDKJI;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public Mesh FGOOIBKPIIC
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x7A26D0", Offset = "0x7A1AD0", VA = "0x1807A26D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x7A26E0", Offset = "0x7A1AE0", VA = "0x1807A26E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public int JIPENEKAMNG
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x79E7B0", Offset = "0x79DBB0", VA = "0x18079E7B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x7A8DD0", Offset = "0x7A81D0", VA = "0x1807A8DD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x67D03B0", Offset = "0x67CF7B0", VA = "0x1867D03B0")]
	public void PALLMGBCPPC(List<NKGPPJOONDJ> BMNEMNCFDJH, Matrix4x4[] DAEKBNJELHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x67CFD20", Offset = "0x67CF120", VA = "0x1867CFD20")]
	public static List<PIMAHIDANFJ> HDHFILGDDKG(List<BKEOHLKCNNG> CJNJNFADAGO, ECCMJPDPIEF DBHMHAHLCPM, Bounds FEBMGBNBBPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x67CF9B0", Offset = "0x67CEDB0", VA = "0x1867CF9B0")]
	private JobHandle FKKNNHPCCCP(IIBGMLIJNCJ FLHOCEIGFKK, int EJHKCNMMALE, int DIEKCCMMDCD, ECCMJPDPIEF DBHMHAHLCPM, List<CEDKKFPGCJI> OONBCIFAAHO)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x67CF830", Offset = "0x67CEC30", VA = "0x1867CF830")]
	private void CGOCFINONGI(List<CEDKKFPGCJI> OONBCIFAAHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x67D0740", Offset = "0x67CFB40", VA = "0x1867D0740")]
	private PIMAHIDANFJ(List<CEDKKFPGCJI> OONBCIFAAHO, int EJHKCNMMALE, int DIEKCCMMDCD, ECCMJPDPIEF DBHMHAHLCPM, Bounds FEBMGBNBBPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x67CF910", Offset = "0x67CED10", VA = "0x1867CF910", Slot = "4")]
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
		private MaterialPropertyBlock GNBDMHIOFJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private PIMAHIDANFJ FEBNKEJJFPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private List<NKGPPJOONDJ> PPBEMPFFJNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private RenderTexture PMAEPAMKHKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private ComputeBuffer IOGBOEEMDIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private ComputeShader OPGPALEIMEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private Matrix4x4[] PHBKBFMGHGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private int IHGAOHMHLME;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public MeshRenderer GNHPLCGEAIE
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x7A2690", Offset = "0x7A1A90", VA = "0x1807A2690")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x7A2700", Offset = "0x7A1B00", VA = "0x1807A2700")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public int CADCFICPILK
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x67D1870", Offset = "0x67D0C70", VA = "0x1867D1870")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x67D0BA0", Offset = "0x67CFFA0", VA = "0x1867D0BA0")]
		public static List<SkinnedShapeRenderer> Create(GameObject DHHBNGOGOPD, List<PIMAHIDANFJ> AOPBLIMBHCD, List<NKGPPJOONDJ> PPBEMPFFJNI, Material LNKFECCMIIP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x67D0E30", Offset = "0x67D0230", VA = "0x1867D0E30")]
		public void Init(PIMAHIDANFJ FEBNKEJJFPJ, List<NKGPPJOONDJ> PPBEMPFFJNI, Material LNKFECCMIIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x67D1460", Offset = "0x67D0860", VA = "0x1867D1460")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x67D13C0", Offset = "0x67D07C0", VA = "0x1867D13C0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x67D1380", Offset = "0x67D0780", VA = "0x1867D1380")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x67D12C0", Offset = "0x67D06C0", VA = "0x1867D12C0")]
		private void KHJCGELNEMC(ScriptableRenderContext HFPPGLCONIA, Camera[] DBOHGNGAMEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x67D1500", Offset = "0x67D0900", VA = "0x1867D1500")]
		private void PALLMGBCPPC(CommandBuffer INICGLDLNHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x7A08F0", Offset = "0x79FCF0", VA = "0x1807A08F0")]
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
