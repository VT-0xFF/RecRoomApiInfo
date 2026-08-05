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
using RecRoom.Configs;
using RecRoom.Core.Creation.Shapes;
using RecRoom.Foundation.Mathematics;
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
	public class LogRegistrationIndex : IGBHOMLLHLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x779AE30", Offset = "0x7799830", VA = "0x18779AE30", Slot = "4")]
		public override void KFMGLABNFNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8D6960", Offset = "0x8D5360", VA = "0x1808D6960")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class OIBHDAJHBAF : LCEOEFEEDBM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private byte JLAHJIDPLDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly List<SkinnedShapeRenderer>[] IGCDJBLFHMC;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int IECBLCEEJIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9826F0", Offset = "0x9810F0", VA = "0x1809826F0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xAAE210", Offset = "0xAACC10", VA = "0x180AAE210")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int CDCDMOALFCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8ED140", Offset = "0x8EBB40", VA = "0x1808ED140", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8ECDB0", Offset = "0x8EB7B0", VA = "0x1808ECDB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public float JELEONLDMEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xAA7030", Offset = "0xAA5A30", VA = "0x180AA7030", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xD30B10", Offset = "0xD2F510", VA = "0x180D30B10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float OGBILDCCBNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xAA7020", Offset = "0xAA5A20", VA = "0x180AA7020", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x16327C0", Offset = "0x16311C0", VA = "0x1816327C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public List<SkinnedShapeRenderer> KANHMFDDDKF
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x77A2DB0", Offset = "0x77A17B0", VA = "0x1877A2DB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public List<SkinnedShapeRenderer> DCLBHNAMMEG
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x77A3320", Offset = "0x77A1D20", VA = "0x1877A3320")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public GameObject BPFDMKBMANG
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8B00E0", Offset = "0x8AEAE0", VA = "0x1808B00E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8B4D30", Offset = "0x8B3730", VA = "0x1808B4D30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public byte NLPGLGEJJKN
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x77A2F00", Offset = "0x77A1900", VA = "0x1877A2F00", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x77A3390", Offset = "0x77A1D90", VA = "0x1877A3390")]
	public OIBHDAJHBAF(List<DKOGJFCDGLM> ABIAKDFOJKD, List<DKOGJFCDGLM> NFEANNHHDDE, List<EFEILIAEILL> IMDKMCGLKCN, Material FLBCMGELMBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x77A3200", Offset = "0x77A1C00", VA = "0x1877A3200")]
	private int LIEFELFHCFC(List<DKOGJFCDGLM> ALOGMMHJILN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x77A30A0", Offset = "0x77A1AA0", VA = "0x1877A30A0")]
	private void KPCEOBOOEEG(int NIBIBINBLGN, bool EHKJPKOFIKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x77A2F50", Offset = "0x77A1950", VA = "0x1877A2F50")]
	public void KOEMHFMPBJG(Vector3 HGNPDGKBMDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x77A2E00", Offset = "0x77A1800", VA = "0x1877A2E00", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x77A3350", Offset = "0x77A1D50", VA = "0x1877A3350")]
	public void NJFBDOLNOOE(Transform JMPNAEHNMOO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class MMKGNFEHJDA : OKEJDOFNJIJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private sealed class HGMGEDOIIHK : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public MMKGNFEHJDA <>4__this;

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
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x8AD540", Offset = "0x8ABF40", VA = "0x1808AD540", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x8AD540", Offset = "0x8ABF40", VA = "0x1808AD540", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8FD7C0", Offset = "0x8FC1C0", VA = "0x1808FD7C0")]
		[DebuggerHidden]
		public HGMGEDOIIHK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7799950", Offset = "0x7798350", VA = "0x187799950", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x77992F0", Offset = "0x7797CF0", VA = "0x1877992F0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7799250", Offset = "0x7797C50", VA = "0x187799250")]
		private void BFPHAGOPJMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7799800", Offset = "0x7798200", VA = "0x187799800")]
		private void OKCPBNJHCGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x77992A0", Offset = "0x7797CA0", VA = "0x1877992A0")]
		private void JPNHKNOJEJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7799900", Offset = "0x7798300", VA = "0x187799900", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7799850", Offset = "0x7798250", VA = "0x187799850", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7799850", Offset = "0x7798250", VA = "0x187799850", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class FOFFGGNOKFL : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public MMKGNFEHJDA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private IEnumerator<Renderer> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x8AD540", Offset = "0x8ABF40", VA = "0x1808AD540", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x8AD540", Offset = "0x8ABF40", VA = "0x1808AD540", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8FD7C0", Offset = "0x8FC1C0", VA = "0x1808FD7C0")]
		[DebuggerHidden]
		public FOFFGGNOKFL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7798BB0", Offset = "0x77975B0", VA = "0x187798BB0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x77986F0", Offset = "0x77970F0", VA = "0x1877986F0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x77986A0", Offset = "0x77970A0", VA = "0x1877986A0")]
		private void BFPHAGOPJMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7798A60", Offset = "0x7797460", VA = "0x187798A60")]
		private void OKCPBNJHCGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7798B60", Offset = "0x7797560", VA = "0x187798B60", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7798AB0", Offset = "0x77974B0", VA = "0x187798AB0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7798AB0", Offset = "0x77974B0", VA = "0x187798AB0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly KAKPHEFMJLI JNFLHLMGFNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly List<BELJIOCOFFL> HMMLIAKAEBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private List<ClusterMeshRenderer> KIEPCFDKBKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private BatchedMeshRenderer KAIGJHMDMKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private bool IFEAEJADMPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public readonly bool FPEOONHADIN;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IEnumerable<HKEHBNJPOEG> LNAAKBEJKOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8AD540", Offset = "0x8ABF40", VA = "0x1808AD540", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int JGBGFEECCBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x779DE60", Offset = "0x779C860", VA = "0x18779DE60", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public EFEILIAEILL CODMCEDNNJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x779DC30", Offset = "0x779C630", VA = "0x18779DC30", Slot = "8")]
		get
		{
			return default(EFEILIAEILL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public List<SkinnedShapeRenderer> EBCNIKNOHJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8AD530", Offset = "0x8ABF30", VA = "0x1808AD530")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8B00F0", Offset = "0x8AEAF0", VA = "0x1808B00F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x779E110", Offset = "0x779CB10", VA = "0x18779E110")]
	private bool OHDDKBJJMGK(BELJIOCOFFL LDNKIGHNFBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x779DD00", Offset = "0x779C700", VA = "0x18779DD00")]
	private static bool LOGGKDBGPIB(BELJIOCOFFL LDNKIGHNFBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x779E2D0", Offset = "0x779CCD0", VA = "0x18779E2D0")]
	public MMKGNFEHJDA(KAKPHEFMJLI GGEMPJLCHFC, bool ICOFIGGANEI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x779CB00", Offset = "0x779B500", VA = "0x18779CB00", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x779DEA0", Offset = "0x779C8A0", VA = "0x18779DEA0")]
	public void NOEGDDICEDP(BELJIOCOFFL LDNKIGHNFBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x779E1B0", Offset = "0x779CBB0", VA = "0x18779E1B0")]
	public void PJOABDGMIKH(BELJIOCOFFL LDNKIGHNFBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x779CCC0", Offset = "0x779B6C0", VA = "0x18779CCC0", Slot = "4")]
	public void ECMIDIMNLGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x779D1C0", Offset = "0x779BBC0", VA = "0x18779D1C0")]
	public void HIEHKMNLIKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x779D9C0", Offset = "0x779C3C0", VA = "0x18779D9C0")]
	private void JHCDFJOPCJC(List<BELJIOCOFFL> HMMLIAKAEBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x779ABD0", Offset = "0x77995D0", VA = "0x18779ABD0")]
	private static Material JINCKPPOLEI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x779DB80", Offset = "0x779C580", VA = "0x18779DB80")]
	private void JHCDFJOPCJC(BELJIOCOFFL LDNKIGHNFBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x779E040", Offset = "0x779CA40", VA = "0x18779E040")]
	private void OAEJGMLFPNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x779D410", Offset = "0x779BE10", VA = "0x18779D410")]
	public void IABKEEJDMFM(bool AEGOIAEGBPI, bool JHNMPPHBEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x779DD20", Offset = "0x779C720", VA = "0x18779DD20")]
	protected void MLMLNFKBJLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x779CA80", Offset = "0x779B480", VA = "0x18779CA80")]
	public void BBKMJNOCOOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x779E130", Offset = "0x779CB30", VA = "0x18779E130")]
	[IteratorStateMachine(typeof(HGMGEDOIIHK))]
	public IEnumerable<Renderer> PBGOJNPKLLO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x779DDE0", Offset = "0x779C7E0", VA = "0x18779DDE0")]
	[IteratorStateMachine(typeof(FOFFGGNOKFL))]
	public IEnumerable<Renderer> NBLDMCHMDFH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal class MJDOBLBHIIH : BELJIOCOFFL
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private struct NOMMMMOIPBE : FJABOJCJDOC, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private PNGDONJJIBJ JMPEEMGIIHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private JobHandle FGPOBPGGBEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private NNAMHLNIEFK JPFJNNANFHA;

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x77A0890", Offset = "0x779F290", VA = "0x1877A0890")]
		public NOMMMMOIPBE(PNGDONJJIBJ JMPEEMGIIHN, JobHandle FGPOBPGGBEF, NNAMHLNIEFK JPFJNNANFHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x77A0810", Offset = "0x779F210", VA = "0x1877A0810", Slot = "4")]
		public PNGDONJJIBJ BFPGNFDAILF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x77A0840", Offset = "0x779F240", VA = "0x1877A0840", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal readonly BBDCBAJEODB GMNFLCMHGGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private float OLPGBMDLIJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private Hash128 JMNHJKOFBII;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	protected override Hash128 ACNPJDGAMBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x779BBD0", Offset = "0x779A5D0", VA = "0x18779BBD0", Slot = "25")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x779C900", Offset = "0x779B300", VA = "0x18779C900")]
	public MJDOBLBHIIH(MMKGNFEHJDA ELFANOAFHKM, BBDCBAJEODB GGEMPJLCHFC, bool ICOFIGGANEI = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x8F5BB0", Offset = "0x8F45B0", VA = "0x1808F5BB0", Slot = "18")]
	public override bool LGMNEEPBNCO(EFEILIAEILL ELFANOAFHKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x779C730", Offset = "0x779B130", VA = "0x18779C730", Slot = "19")]
	public override int LIEFELFHCFC(JMOMLIAKNIG CDLBFFAEOBG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x779BD00", Offset = "0x779A700", VA = "0x18779BD00", Slot = "20")]
	public override int HPPBEPBGHMI(JMOMLIAKNIG CDLBFFAEOBG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x779AEC0", Offset = "0x77998C0", VA = "0x18779AEC0", Slot = "21")]
	public override Bounds AKCDLKJDBLE()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0xBBD460", Offset = "0xBBBE60", VA = "0x180BBD460", Slot = "22")]
	public override float ICBNOCGFLLD()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x779C150", Offset = "0x779AB50", VA = "0x18779C150", Slot = "23")]
	public override void LACAPFDFODD(JMOMLIAKNIG CDLBFFAEOBG, GJOHKPHJKBE PEKBIFNLJPI, int DEGEPGIHNKN = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x779C080", Offset = "0x779AA80", VA = "0x18779C080", Slot = "24")]
	public override EFEILIAEILL JPGNCGECCIP()
	{
		return default(EFEILIAEILL);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x779BED0", Offset = "0x779A8D0", VA = "0x18779BED0", Slot = "26")]
	public override BPAPKFIPBKF JAGEHCOBGGI()
	{
		return default(BPAPKFIPBKF);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x779B400", Offset = "0x7799E00", VA = "0x18779B400", Slot = "27")]
	public override FJABOJCJDOC AMOCOPKOBLI(JMOMLIAKNIG CDLBFFAEOBG, JobHandle FGPOBPGGBEF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[DefaultMember("Item")]
public interface AMLKEGIAHAH
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	MMKGNFEHJDA CEHHCMJMIPC
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	BELJIOCOFFL CEHHCMJMIPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	FKPBGPOGDDP CEHHCMJMIPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[DefaultMember("Item")]
public class OBENEIIHHEK : ECLOEEPLPLF, IDisposable, AMLKEGIAHAH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct GCOAIIMOLKD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public OBENEIIHHEK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x7798CE0", Offset = "0x77976E0", VA = "0x187798CE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x77991F0", Offset = "0x7797BF0", VA = "0x1877991F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly GKNBBFOKGOE<FCPANGHFKNK, MMKGNFEHJDA> IFPOGMBOOEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly GKNBBFOKGOE<IHNAJDHMCNF, BELJIOCOFFL> HMMLIAKAEBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly GKNBBFOKGOE<IGEHCIPOMMD, FKPBGPOGDDP> JIJIOPFJBBI;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public MMKGNFEHJDA CEHHCMJMIPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x77A16D0", Offset = "0x77A00D0", VA = "0x1877A16D0", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public BELJIOCOFFL CEHHCMJMIPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x77A1610", Offset = "0x77A0010", VA = "0x1877A1610", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public FKPBGPOGDDP CEHHCMJMIPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x77A1670", Offset = "0x77A0070", VA = "0x1877A1670", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool DIPBJEJNNBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x9A2DD0", Offset = "0x9A17D0", VA = "0x1809A2DD0", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x9A2C90", Offset = "0x9A1690", VA = "0x1809A2C90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x77A2930", Offset = "0x77A1330", VA = "0x1877A2930")]
	public OBENEIIHHEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x77A09E0", Offset = "0x779F3E0", VA = "0x1877A09E0", Slot = "21")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x77A23D0", Offset = "0x77A0DD0", VA = "0x1877A23D0", Slot = "4")]
	public FCPANGHFKNK MCFEMGCBKHD(KAKPHEFMJLI GGEMPJLCHFC)
	{
		return default(FCPANGHFKNK);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x77A23E0", Offset = "0x77A0DE0", VA = "0x1877A23E0", Slot = "5")]
	public FCPANGHFKNK MCFEMGCBKHD(KAKPHEFMJLI GGEMPJLCHFC, bool ICOFIGGANEI)
	{
		return default(FCPANGHFKNK);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x77A1C60", Offset = "0x77A0660", VA = "0x1877A1C60", Slot = "6")]
	public void ICCFKDGBMBF(FCPANGHFKNK ELFANOAFHKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x77A1EB0", Offset = "0x77A08B0", VA = "0x1877A1EB0", Slot = "7")]
	public void IELMDOLOJPK(FCPANGHFKNK ELFANOAFHKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x77A1150", Offset = "0x779FB50", VA = "0x1877A1150", Slot = "8")]
	public IHNAJDHMCNF FFOKHBLFOBO(FCPANGHFKNK ELFANOAFHKM, ENGPPEFOKOD GGEMPJLCHFC)
	{
		return default(IHNAJDHMCNF);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x77A1730", Offset = "0x77A0130", VA = "0x1877A1730", Slot = "9")]
	public IHNAJDHMCNF GILFMPHNGJJ(FCPANGHFKNK ELFANOAFHKM, BBDCBAJEODB GGEMPJLCHFC)
	{
		return default(IHNAJDHMCNF);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x77A0C30", Offset = "0x779F630", VA = "0x1877A0C30", Slot = "11")]
	public void EGMFHGKHFOK(IHNAJDHMCNF LDNKIGHNFBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x77A2650", Offset = "0x77A1050", VA = "0x1877A2650", Slot = "10")]
	public void MNAAOFKGLGD(IHNAJDHMCNF LDNKIGHNFBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x77A08F0", Offset = "0x779F2F0", VA = "0x1877A08F0", Slot = "20")]
	public IEnumerable<Renderer> ALDKGIGJIJJ(FCPANGHFKNK ELFANOAFHKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x77A0960", Offset = "0x779F360", VA = "0x1877A0960", Slot = "12")]
	public IGEHCIPOMMD CBPDAMKKMME(KOBNNPMDHML GGEMPJLCHFC)
	{
		return default(IGEHCIPOMMD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x77A1BF0", Offset = "0x77A05F0", VA = "0x1877A1BF0", Slot = "14")]
	public void HIMJLJJEEFG(IGEHCIPOMMD GOJMPHJGKHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x77A0FD0", Offset = "0x779F9D0", VA = "0x1877A0FD0", Slot = "16")]
	public Task FBLOPJJNICD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x77A2250", Offset = "0x77A0C50", VA = "0x1877A2250", Slot = "17")]
	public Task LALGNCLKLII()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x77A0B60", Offset = "0x779F560", VA = "0x1877A0B60", Slot = "18")]
	[AsyncStateMachine(typeof(GCOAIIMOLKD))]
	public Task EDAJEHODNGN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x77A28A0", Offset = "0x77A12A0", VA = "0x1877A28A0", Slot = "19")]
	public void OMNMHGMONMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x77A21F0", Offset = "0x77A0BF0", VA = "0x1877A21F0", Slot = "13")]
	public void KCCAJLBNCKC(IGEHCIPOMMD GOJMPHJGKHN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
internal class NNMKCNGPPPM : BELJIOCOFFL
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private struct MMIECDFFCEM : FJABOJCJDOC, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private PNGDONJJIBJ JMPEEMGIIHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private JobHandle FGPOBPGGBEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private JLDOJCCJGDM JPFJNNANFHA;

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x779CA30", Offset = "0x779B430", VA = "0x18779CA30")]
		public MMIECDFFCEM(PNGDONJJIBJ JMPEEMGIIHN, JobHandle FGPOBPGGBEF, JLDOJCCJGDM JPFJNNANFHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x779C9B0", Offset = "0x779B3B0", VA = "0x18779C9B0", Slot = "4")]
		public PNGDONJJIBJ BFPGNFDAILF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x779C9E0", Offset = "0x779B3E0", VA = "0x18779C9E0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly ENGPPEFOKOD DKIFFIMODLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private int[] EHDLKPEHGJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private Hash128 JMNHJKOFBII;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private Vector3 PFMKLPGFENM
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x77A0530", Offset = "0x779EF30", VA = "0x1877A0530")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	protected override Hash128 ACNPJDGAMBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x779EBA0", Offset = "0x779D5A0", VA = "0x18779EBA0", Slot = "25")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x77A0760", Offset = "0x779F160", VA = "0x1877A0760")]
	public NNMKCNGPPPM(MMKGNFEHJDA ELFANOAFHKM, ENGPPEFOKOD GGEMPJLCHFC, bool HJGAMNBOKAJ = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x779FB70", Offset = "0x779E570", VA = "0x18779FB70", Slot = "18")]
	public override bool LGMNEEPBNCO(EFEILIAEILL ELFANOAFHKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x77A0330", Offset = "0x779ED30", VA = "0x1877A0330")]
	private GEJKOMGADBH MBDGJPAADKA([In] UniformTRS GGFNOHHIJCM, [In] float3 POMAECCMPFI)
	{
		return default(GEJKOMGADBH);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x77A0290", Offset = "0x779EC90", VA = "0x1877A0290", Slot = "19")]
	public override int LIEFELFHCFC(JMOMLIAKNIG CDLBFFAEOBG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x779EF40", Offset = "0x779D940", VA = "0x18779EF40", Slot = "20")]
	public override int HPPBEPBGHMI(JMOMLIAKNIG CDLBFFAEOBG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x779E3C0", Offset = "0x779CDC0", VA = "0x18779E3C0", Slot = "21")]
	public override Bounds AKCDLKJDBLE()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x779EFE0", Offset = "0x779D9E0", VA = "0x18779EFE0", Slot = "22")]
	public override float ICBNOCGFLLD()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x779ECD0", Offset = "0x779D6D0", VA = "0x18779ECD0")]
	private int HALKCFODOPO(JMOMLIAKNIG CDLBFFAEOBG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x779F350", Offset = "0x779DD50", VA = "0x18779F350", Slot = "23")]
	public override void LACAPFDFODD(JMOMLIAKNIG CDLBFFAEOBG, GJOHKPHJKBE PEKBIFNLJPI, int DEGEPGIHNKN = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x779F280", Offset = "0x779DC80", VA = "0x18779F280", Slot = "24")]
	public override EFEILIAEILL JPGNCGECCIP()
	{
		return default(EFEILIAEILL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x779F0D0", Offset = "0x779DAD0", VA = "0x18779F0D0", Slot = "26")]
	public override BPAPKFIPBKF JAGEHCOBGGI()
	{
		return default(BPAPKFIPBKF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x779E440", Offset = "0x779CE40", VA = "0x18779E440", Slot = "27")]
	public override FJABOJCJDOC AMOCOPKOBLI(JMOMLIAKNIG CDLBFFAEOBG, JobHandle FGPOBPGGBEF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface GKNIEFNJFPC
{
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BLOJMNDNDBN(EBLHPNHPCDN BKKHBFLPOHJ, Renderer OJIILOMBDFN, int NGBGHOJIJHH);

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HJFKKFIGIOC(Renderer OJIILOMBDFN, MPLMMDENOEO AIGEHILOBEC, Vector3 HJAFMJBMJIG, Vector3 CLCBGLBFGEB, Vector3 ILPIBIEHDPL, float EFCBFDCHJEH, float JFMFBLKAOPH, float LFJHMCCBOBN = -1f, [Optional] Color? GNADFIPFMAK, [Optional] IReadOnlyList<Camera> CKDNAKMOHFJ);

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ADNAIJKNMKP(Renderer OJIILOMBDFN, int NGBGHOJIJHH);

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int NONGDLJEACF();

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PMLDPNOAFHN(int EPFFFHHAPLF, FFJCINHIICI BKKHBFLPOHJ, Renderer OJIILOMBDFN, int NGBGHOJIJHH);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class BKHNBDGNADA : EKJOIMJKNJH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	private class DNHJLFKELDC : KNNCPEOEEOG<int>
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x7796BF0", Offset = "0x77955F0", VA = "0x187796BF0")]
		public DNHJLFKELDC(string JHJFHDOAMLG)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly GKNIEFNJFPC KCMDGEDCFHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly AMLKEGIAHAH KABJAMGMMBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private MeshRenderer AAFMALMNHEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private DNHJLFKELDC OBGAKAKDFCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private bool JAKAHKKHFGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private MeshRenderer GHGAGBGFNIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private DNHJLFKELDC INMJOBEDFEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private bool MLIEPGGDAHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private MeshRenderer KLNMJCJPNDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private DNHJLFKELDC OFOEMBMCECG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private bool JDLOCAGEEDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private bool MOGBFDJDEOF;

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x8BB0D0", Offset = "0x8B9AD0", VA = "0x1808BB0D0")]
	public BKHNBDGNADA(GKNIEFNJFPC FCIFPLNDEBP, AMLKEGIAHAH KABJAMGMMBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x7793410", Offset = "0x7791E10", VA = "0x187793410", Slot = "23")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x7792890", Offset = "0x7791290", VA = "0x187792890")]
	private void BJMCACFFBCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x77921F0", Offset = "0x7790BF0", VA = "0x1877921F0", Slot = "4")]
	public void ADLMNADEKMB(FCPANGHFKNK ELFANOAFHKM, FFJCINHIICI DBMKAIFBMAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x7792500", Offset = "0x7790F00", VA = "0x187792500", Slot = "5")]
	public void ADLMNADEKMB(IHNAJDHMCNF LDNKIGHNFBK, FFJCINHIICI DBMKAIFBMAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x77944F0", Offset = "0x7792EF0", VA = "0x1877944F0", Slot = "6")]
	public void GMDCBJBGKLD(IHNAJDHMCNF LDNKIGHNFBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x7794930", Offset = "0x7793330", VA = "0x187794930", Slot = "7")]
	public void MPJGFPLEDGL(IHNAJDHMCNF LDNKIGHNFBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x7793B70", Offset = "0x7792570", VA = "0x187793B70", Slot = "24")]
	public void FBCGNPGBDJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0xBE1A70", Offset = "0xBE0470", VA = "0x180BE1A70", Slot = "8")]
	public void NFAHPEKEMNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x7792720", Offset = "0x7791120", VA = "0x187792720", Slot = "9")]
	public void AKIAGOCIFFF(FFJCINHIICI DBMKAIFBMAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x7792E60", Offset = "0x7791860", VA = "0x187792E60", Slot = "10")]
	public void BMKNMJICELE(FCPANGHFKNK ELFANOAFHKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x7792B00", Offset = "0x7791500", VA = "0x187792B00", Slot = "11")]
	public void BMKNMJICELE(IHNAJDHMCNF LDNKIGHNFBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x7794420", Offset = "0x7792E20", VA = "0x187794420", Slot = "12")]
	public void GFDNFPMMFOH(IHNAJDHMCNF LDNKIGHNFBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x77935C0", Offset = "0x7791FC0", VA = "0x1877935C0", Slot = "13")]
	public void EBEDHDHDANK(IHNAJDHMCNF LDNKIGHNFBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x7793690", Offset = "0x7792090", VA = "0x187793690")]
	private void ECECCMLBPIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0xCBEAA0", Offset = "0xCBD4A0", VA = "0x180CBEAA0", Slot = "14")]
	public void COGABANCGBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x77920D0", Offset = "0x7790AD0", VA = "0x1877920D0", Slot = "15")]
	public void AADBPGMINLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x7794650", Offset = "0x7793050", VA = "0x187794650", Slot = "16")]
	public void KMEPCBABPHG(FCPANGHFKNK ELFANOAFHKM, EBLHPNHPCDN BKKHBFLPOHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7793340", Offset = "0x7791D40", VA = "0x187793340", Slot = "17")]
	public void DBLEAIOPFOH(IHNAJDHMCNF LDNKIGHNFBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7793140", Offset = "0x7791B40", VA = "0x187793140", Slot = "18")]
	public void BPPNPNIECHK(IHNAJDHMCNF LDNKIGHNFBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x93E840", Offset = "0x93D240", VA = "0x18093E840", Slot = "19")]
	public void HEIDJFHJGEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x7793210", Offset = "0x7791C10", VA = "0x187793210", Slot = "20")]
	public void CADLKJIHCLP(EBLHPNHPCDN BKKHBFLPOHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x7793900", Offset = "0x7792300", VA = "0x187793900")]
	private void EFEAPOIIHDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x7793BB0", Offset = "0x77925B0", VA = "0x187793BB0", Slot = "21")]
	public void FPGKPBNIHEL(FCPANGHFKNK ELFANOAFHKM, Vector3 HJAFMJBMJIG, Vector3 CLCBGLBFGEB, Vector3 ILPIBIEHDPL, float EFCBFDCHJEH, float JFMFBLKAOPH, IReadOnlyList<Camera> NOIBENIIIFK, MPLMMDENOEO AIGEHILOBEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x7793F80", Offset = "0x7792980", VA = "0x187793F80", Slot = "22")]
	public void FPGKPBNIHEL(IGEHCIPOMMD GOJMPHJGKHN, Vector3 HJAFMJBMJIG, Vector3 CLCBGLBFGEB, Vector3 ILPIBIEHDPL, float EFCBFDCHJEH, float JFMFBLKAOPH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public abstract class BELJIOCOFFL : OIHACEDCJKJ, HKEHBNJPOEG, IGFEPDENIEO, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly MMKGNFEHJDA BPFDMKBMANG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private int PEILIIDKEOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	protected Bounds IDKPLBCIGPK;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public Bounds LBDPICGCDNM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x7791F10", Offset = "0x7790910", VA = "0x187791F10", Slot = "4")]
		get
		{
			return default(Bounds);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public bool FPEOONHADIN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x932F20", Offset = "0x931920", VA = "0x180932F20")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x933500", Offset = "0x931F00", VA = "0x180933500")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	protected abstract Hash128 ACNPJDGAMBG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int PNAABLJILHB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x941F40", Offset = "0x940940", VA = "0x180941F40", Slot = "11")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public HPALFIDFAJC MPOEOMKMAIC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x8AD530", Offset = "0x8ABF30", VA = "0x1808AD530")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x8B00F0", Offset = "0x8AEAF0", VA = "0x1808B00F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool FPOCHNDFLDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0xD6F8C0", Offset = "0xD6E2C0", VA = "0x180D6F8C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x8B23B0", Offset = "0x8B0DB0", VA = "0x1808B23B0")]
	protected BELJIOCOFFL(MMKGNFEHJDA ELFANOAFHKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x7791F30", Offset = "0x7790930", VA = "0x187791F30", Slot = "17")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x8F5BB0", Offset = "0x8F45B0", VA = "0x1808F5BB0", Slot = "18")]
	public virtual bool LGMNEEPBNCO(EFEILIAEILL ELFANOAFHKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x77920C0", Offset = "0x7790AC0", VA = "0x1877920C0", Slot = "10")]
	public int KKDCFOIAKNA(int BLFLEPGMCKH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "19")]
	public abstract int LIEFELFHCFC(JMOMLIAKNIG CDLBFFAEOBG);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "20")]
	public abstract int HPPBEPBGHMI(JMOMLIAKNIG CDLBFFAEOBG);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "21")]
	public abstract Bounds AKCDLKJDBLE();

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "22")]
	public abstract float ICBNOCGFLLD();

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "23")]
	public abstract void LACAPFDFODD(JMOMLIAKNIG CDLBFFAEOBG, GJOHKPHJKBE PEKBIFNLJPI, int DEGEPGIHNKN = -1);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "24")]
	public abstract EFEILIAEILL JPGNCGECCIP();

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x7792060", Offset = "0x7790A60", VA = "0x187792060", Slot = "13")]
	public Hash128 EEAKDHELBKJ(int CDLBFFAEOBG)
	{
		return default(Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "26")]
	public abstract BPAPKFIPBKF JAGEHCOBGGI();

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "27")]
	public abstract FJABOJCJDOC AMOCOPKOBLI(JMOMLIAKNIG CDLBFFAEOBG, JobHandle FGPOBPGGBEF);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x7792090", Offset = "0x7790A90", VA = "0x187792090", Slot = "12")]
	public FJABOJCJDOC KIILGKAMIIJ(int CDLBFFAEOBG)
	{
		return null;
	}
}
namespace RecRoom.ShapeRendering
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class ShapeRendererConfig : SingletonScriptableObject<ShapeRendererConfig>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		public struct ShapeMeshConfigData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			[HideInInspector]
			public string EditorLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public Mesh[] Meshes;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public ShapeMeshConfigData[] MeshConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		[Header("Bevels")]
		public float SmallBevelSizeMeters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public float RoundedBevelSizeMeters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public float BoxAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public float WedgeAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public float PyramidAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		[Tooltip("Smaller dimensions will not exceed sqrt(bevel percent) percent")]
		public bool BevelSizeBasedOnLargestPossibleDimension;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public ComputeShader CopyBonesComputeShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public SkinnedShapeRenderer SkinnedRendererPrefab;

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x77A36A0", Offset = "0x77A20A0", VA = "0x1877A36A0")]
		public ShapeRendererConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class DIFJDGOPCHA
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class AGMOBHDBDCB : IEnumerable<LBFGMBFJHOP>, IEnumerable, IEnumerator<LBFGMBFJHOP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private LBFGMBFJHOP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private int <p>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private int <l>5__3;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		private LBFGMBFJHOP System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.PrimitiveShapeMeshData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x8AD540", Offset = "0x8ABF40", VA = "0x1808AD540", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x8AD540", Offset = "0x8ABF40", VA = "0x1808AD540", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x8FD7C0", Offset = "0x8FC1C0", VA = "0x1808FD7C0")]
		[DebuggerHidden]
		public AGMOBHDBDCB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x7791D50", Offset = "0x7790750", VA = "0x187791D50", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x7791EC0", Offset = "0x77908C0", VA = "0x187791EC0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x7791E20", Offset = "0x7790820", VA = "0x187791E20", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<LBFGMBFJHOP> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.PrimitiveShapeMeshData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x7791E20", Offset = "0x7790820", VA = "0x187791E20", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private static LBFGMBFJHOP[][] GJKCDCHPLCB;

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private static HPFPLICIJGC GLCFICEAACG;

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public static ShapeRendererConfig HPGJMNAOGJC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x7794A80", Offset = "0x7793480", VA = "0x187794A80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public static ComputeShader IODPHBPGHHN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x7795270", Offset = "0x7793C70", VA = "0x187795270")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public static SkinnedShapeRenderer EJLFFPKFGJE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x7794EA0", Offset = "0x77938A0", VA = "0x187794EA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x77951C0", Offset = "0x7793BC0", VA = "0x1877951C0")]
	public static Mesh KNCINKNDKBG(BHMPMJEBGAJ HCKEFJFNKHF, int CDLBFFAEOBG = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x7794F10", Offset = "0x7793910", VA = "0x187794F10")]
	public static int HHLKNOPEBCL(BHMPMJEBGAJ HCKEFJFNKHF, int CDLBFFAEOBG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x77952E0", Offset = "0x7793CE0", VA = "0x1877952E0")]
	public static HPFPLICIJGC MBMDMKDOONN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x7794AB0", Offset = "0x77934B0", VA = "0x187794AB0")]
	[IteratorStateMachine(typeof(AGMOBHDBDCB))]
	private static IEnumerable<LBFGMBFJHOP> DLHPOCNJPIJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x7794F20", Offset = "0x7793920", VA = "0x187794F20")]
	public static LBFGMBFJHOP IMCIHPGNCJE(BHMPMJEBGAJ HCKEFJFNKHF, int CDLBFFAEOBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x7794CD0", Offset = "0x77936D0", VA = "0x187794CD0")]
	public static bool EHAFNLGALMA(this BHMPMJEBGAJ HCKEFJFNKHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x7794CF0", Offset = "0x77936F0", VA = "0x187794CF0")]
	public static void EHPNJHAKIIM(BHMPMJEBGAJ HCKEFJFNKHF, float3 FCIICHBIGJK, [Out] MCAJEAPMGEB PAAEHEFEPBJ, [Out] float3 GEOLBDDMBEM, [Out] float GAMIHNMCOPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x7795430", Offset = "0x7793E30", VA = "0x187795430")]
	public static void PFOEPDJGPDC(Vector3 FCIICHBIGJK, BHMPMJEBGAJ HCKEFJFNKHF, [Out] Vector3 GEOLBDDMBEM, [Out] float GAMIHNMCOPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x7795420", Offset = "0x7793E20", VA = "0x187795420")]
	[MDNJIPDCAGH(CHEIGNPGAPJ.ExitingPlayMode, 0)]
	[GEIJFCOPIJN(0)]
	private static void OEOAKFENCIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x7794B10", Offset = "0x7793510", VA = "0x187794B10")]
	[MDNJIPDCAGH(CHEIGNPGAPJ.ExitingPlayMode, 0)]
	[GEIJFCOPIJN(0)]
	private static void EAELBMINAEP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[DefaultMember("Item")]
public class HKLMILLPMDF : ECLOEEPLPLF, IDisposable, AMLKEGIAHAH
{
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static readonly KLEHBGEJMBN DAKGLLFOGCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly GKNBBFOKGOE<FCPANGHFKNK, MMKGNFEHJDA> IFPOGMBOOEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly GKNBBFOKGOE<IHNAJDHMCNF, BELJIOCOFFL> HMMLIAKAEBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly GKNBBFOKGOE<IGEHCIPOMMD, FKPBGPOGDDP> JIJIOPFJBBI;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public MMKGNFEHJDA CEHHCMJMIPC
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x7799FD0", Offset = "0x77989D0", VA = "0x187799FD0", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public BELJIOCOFFL CEHHCMJMIPC
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x779A090", Offset = "0x7798A90", VA = "0x18779A090", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public FKPBGPOGDDP CEHHCMJMIPC
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x779A030", Offset = "0x7798A30", VA = "0x18779A030", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool DIPBJEJNNBC
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x9A2DD0", Offset = "0x9A17D0", VA = "0x1809A2DD0", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x9A2C90", Offset = "0x9A1690", VA = "0x1809A2C90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x779A600", Offset = "0x7799000", VA = "0x18779A600")]
	public HKLMILLPMDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x7799C30", Offset = "0x7798630", VA = "0x187799C30", Slot = "21")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x779A480", Offset = "0x7798E80", VA = "0x18779A480", Slot = "4")]
	public FCPANGHFKNK MCFEMGCBKHD(KAKPHEFMJLI GGEMPJLCHFC)
	{
		return default(FCPANGHFKNK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x779A480", Offset = "0x7798E80", VA = "0x18779A480", Slot = "5")]
	public FCPANGHFKNK MCFEMGCBKHD(KAKPHEFMJLI GGEMPJLCHFC, bool ICOFIGGANEI)
	{
		return default(FCPANGHFKNK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x779A2A0", Offset = "0x7798CA0", VA = "0x18779A2A0", Slot = "6")]
	public void ICCFKDGBMBF(FCPANGHFKNK ELFANOAFHKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x779A300", Offset = "0x7798D00", VA = "0x18779A300", Slot = "7")]
	public void IELMDOLOJPK(FCPANGHFKNK ELFANOAFHKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x7799E90", Offset = "0x7798890", VA = "0x187799E90", Slot = "8")]
	public IHNAJDHMCNF FFOKHBLFOBO(FCPANGHFKNK ELFANOAFHKM, ENGPPEFOKOD GGEMPJLCHFC)
	{
		return default(IHNAJDHMCNF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x779A0F0", Offset = "0x7798AF0", VA = "0x18779A0F0", Slot = "9")]
	public IHNAJDHMCNF GILFMPHNGJJ(FCPANGHFKNK ELFANOAFHKM, BBDCBAJEODB GGEMPJLCHFC)
	{
		return default(IHNAJDHMCNF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x7799D60", Offset = "0x7798760", VA = "0x187799D60", Slot = "11")]
	public void EGMFHGKHFOK(IHNAJDHMCNF LDNKIGHNFBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x779A520", Offset = "0x7798F20", VA = "0x18779A520", Slot = "10")]
	public void MNAAOFKGLGD(IHNAJDHMCNF LDNKIGHNFBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x7799B40", Offset = "0x7798540", VA = "0x187799B40", Slot = "20")]
	public IEnumerable<Renderer> ALDKGIGJIJJ(FCPANGHFKNK ELFANOAFHKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x7799BB0", Offset = "0x77985B0", VA = "0x187799BB0", Slot = "12")]
	public IGEHCIPOMMD CBPDAMKKMME(KOBNNPMDHML GGEMPJLCHFC)
	{
		return default(IGEHCIPOMMD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x779A230", Offset = "0x7798C30", VA = "0x18779A230", Slot = "14")]
	public void HIMJLJJEEFG(IGEHCIPOMMD GOJMPHJGKHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x7799DF0", Offset = "0x77987F0", VA = "0x187799DF0", Slot = "16")]
	public Task FBLOPJJNICD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x779A3E0", Offset = "0x7798DE0", VA = "0x18779A3E0", Slot = "17")]
	public Task LALGNCLKLII()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x7799CC0", Offset = "0x77986C0", VA = "0x187799CC0", Slot = "18")]
	public Task EDAJEHODNGN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x2192630", Offset = "0x2191030", VA = "0x182192630", Slot = "19")]
	public void OMNMHGMONMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x779A380", Offset = "0x7798D80", VA = "0x18779A380", Slot = "13")]
	public void KCCAJLBNCKC(IGEHCIPOMMD GOJMPHJGKHN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface ELCEHFMNPLE
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool GCKLIALDFIM
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Material HICKDACMJAB();

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Material JINCKPPOLEI();

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Material HJNKIBDMNLK();

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int OMBAFMNFGLH(JKHIHEHMHKN AKDANOPEPEO);

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int ECEAPJMCLMC(AJGLBKGCGHL LLACAMHLMPI);

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NODAOHCNLAK(GameObject BBNKFKDCOLP);

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void FDEIBKDOPPF(GameObject BBNKFKDCOLP, bool CALFBAHGADA);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class HPGJIGAJDIB
{
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static ELCEHFMNPLE OAAFMJBAJGL;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public static bool GCKLIALDFIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x779AC80", Offset = "0x7799680", VA = "0x18779AC80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x779AC30", Offset = "0x7799630", VA = "0x18779AC30")]
	public static void KMGCACJDLOP(ELCEHFMNPLE GAJNDAOCOPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x779AB10", Offset = "0x7799510", VA = "0x18779AB10")]
	public static Material HICKDACMJAB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x779ABD0", Offset = "0x77995D0", VA = "0x18779ABD0")]
	public static Material JINCKPPOLEI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x779AB70", Offset = "0x7799570", VA = "0x18779AB70")]
	public static Material HJNKIBDMNLK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x779ADC0", Offset = "0x77997C0", VA = "0x18779ADC0")]
	public static int OMBAFMNFGLH(JKHIHEHMHKN AKDANOPEPEO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x779A9C0", Offset = "0x77993C0", VA = "0x18779A9C0")]
	public static int ECEAPJMCLMC(AJGLBKGCGHL LLACAMHLMPI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x779ACE0", Offset = "0x77996E0", VA = "0x18779ACE0")]
	public static void NODAOHCNLAK(GameObject BBNKFKDCOLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x779AA30", Offset = "0x7799430", VA = "0x18779AA30")]
	public static void FDEIBKDOPPF(GameObject BBNKFKDCOLP, bool CALFBAHGADA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class FKPBGPOGDDP : OKEJDOFNJIJ
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class DPGNNDFCNGK : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public FKPBGPOGDDP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x8AD540", Offset = "0x8ABF40", VA = "0x1808AD540", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x8AD540", Offset = "0x8ABF40", VA = "0x1808AD540", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x8FD7C0", Offset = "0x8FC1C0", VA = "0x1808FD7C0")]
		[DebuggerHidden]
		public DPGNNDFCNGK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x7796FB0", Offset = "0x77959B0", VA = "0x187796FB0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x7796C90", Offset = "0x7795690", VA = "0x187796C90", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x7796C40", Offset = "0x7795640", VA = "0x187796C40")]
		private void BFPHAGOPJMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x7796F60", Offset = "0x7795960", VA = "0x187796F60", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x7796EB0", Offset = "0x77958B0", VA = "0x187796EB0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x7796EB0", Offset = "0x77958B0", VA = "0x187796EB0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private readonly KOBNNPMDHML GCMAPFHFJMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private readonly AMLKEGIAHAH KABJAMGMMBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private OIBHDAJHBAF EKCAKGMIDLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private List<DKOGJFCDGLM> MELLCNCMNMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private List<DKOGJFCDGLM> AAAAAPCDBND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private GameObject HPPELKJGGLA;

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x77983F0", Offset = "0x7796DF0", VA = "0x1877983F0")]
	public static FKPBGPOGDDP LPKOKNBNEGI(KOBNNPMDHML GGEMPJLCHFC, AMLKEGIAHAH KABJAMGMMBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x77985C0", Offset = "0x7796FC0", VA = "0x1877985C0")]
	private FKPBGPOGDDP(KOBNNPMDHML GGEMPJLCHFC, AMLKEGIAHAH KABJAMGMMBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x7797F70", Offset = "0x7796970", VA = "0x187797F70")]
	public void JFMJGMNFMJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x7798540", Offset = "0x7796F40", VA = "0x187798540")]
	[IteratorStateMachine(typeof(DPGNNDFCNGK))]
	public IEnumerable<Renderer> PBGOJNPKLLO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x7797240", Offset = "0x7795C40", VA = "0x187797240", Slot = "4")]
	public void ECMIDIMNLGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x7797CF0", Offset = "0x77966F0", VA = "0x187797CF0")]
	private void EEICGBLLJLH(Vector3 HGNPDGKBMDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x7797D20", Offset = "0x7796720", VA = "0x187797D20")]
	public void HIEHKMNLIKI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class DKOGJFCDGLM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private struct EBFFGNJIFOE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public GJOHKPHJKBE ADGCCIOBMPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public EFEILIAEILL IEANCNGJPNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public int PENIINLGJHJ;
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class EIIPGNKENDP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public DKOGJFCDGLM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public int numVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public int numIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public JMOMLIAKNIG lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public List<EBFFGNJIFOE> boneMeshInfos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public PNGDONJJIBJ combinedMesh;

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public EIIPGNKENDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x77971B0", Offset = "0x7795BB0", VA = "0x1877971B0")]
		internal JobHandle LNCAOAEDEDK()
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x7797210", Offset = "0x7795C10", VA = "0x187797210")]
		internal void PMIMDKICEIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x7797040", Offset = "0x7795A40", VA = "0x187797040")]
		internal void JKFGGDCMCDB()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private int[] FEDOPMKIIIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private CNBDOENGMLA FJKJJNONCFC;

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private static Matrix4x4 DMIGKHBAJNL;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public Mesh IANNELJHPEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x8AD560", Offset = "0x8ABF60", VA = "0x1808AD560")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x8AD970", Offset = "0x8AC370", VA = "0x1808AD970")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public int DJPFGJHLGJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x8B4D20", Offset = "0x8B3720", VA = "0x1808B4D20")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x8B4D40", Offset = "0x8B3740", VA = "0x1808B4D40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x77958F0", Offset = "0x77942F0", VA = "0x1877958F0")]
	public void DIGECABNHHC(List<EFEILIAEILL> NHOBMNMCLJH, Matrix4x4[] FJAKHEKEOPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x7795FB0", Offset = "0x77949B0", VA = "0x187795FB0")]
	public static List<DKOGJFCDGLM> LNCAGMGJJFK(List<MMKGNFEHJDA> FKLJIHONHEK, JMOMLIAKNIG CDLBFFAEOBG, Bounds BFFLGPOAEBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x7795C50", Offset = "0x7794650", VA = "0x187795C50")]
	private JobHandle KNMHFMOEMNK(PNGDONJJIBJ MDGANPFDNDH, int BOFHDFDPMPJ, int LGDPPAPEBMO, JMOMLIAKNIG CDLBFFAEOBG, List<EBFFGNJIFOE> DBJPBOEHKJI)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x7795B70", Offset = "0x7794570", VA = "0x187795B70")]
	private void JJBKGNIHIIJ(List<EBFFGNJIFOE> DBJPBOEHKJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x77967D0", Offset = "0x77951D0", VA = "0x1877967D0")]
	private DKOGJFCDGLM(List<EBFFGNJIFOE> DBJPBOEHKJI, int BOFHDFDPMPJ, int LGDPPAPEBMO, JMOMLIAKNIG CDLBFFAEOBG, Bounds BFFLGPOAEBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x7795AD0", Offset = "0x77944D0", VA = "0x187795AD0", Slot = "4")]
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
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private MaterialPropertyBlock OLJLLPFCMHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private DKOGJFCDGLM JMPEEMGIIHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private List<EFEILIAEILL> IMDKMCGLKCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private RenderTexture EODPCDMGPJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private ComputeBuffer IOOJBCDBMKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private ComputeShader AINDKNCMPOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private Matrix4x4[] FHHGLLJBCEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private int IDEKMOHDFLF;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public MeshRenderer KLEJBMDEPED
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x8AD540", Offset = "0x8ABF40", VA = "0x1808AD540")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x8ADB10", Offset = "0x8AC510", VA = "0x1808ADB10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public int MMFEFHIPJAG
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x77A4410", Offset = "0x77A2E10", VA = "0x1877A4410")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x77A3700", Offset = "0x77A2100", VA = "0x1877A3700")]
		public static List<SkinnedShapeRenderer> Create(GameObject ELFANOAFHKM, List<DKOGJFCDGLM> ALOGMMHJILN, List<EFEILIAEILL> IMDKMCGLKCN, Material FLBCMGELMBF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x77A3D20", Offset = "0x77A2720", VA = "0x1877A3D20")]
		public void Init(DKOGJFCDGLM JMPEEMGIIHN, List<EFEILIAEILL> IMDKMCGLKCN, Material FLBCMGELMBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x77A4370", Offset = "0x77A2D70", VA = "0x1877A4370")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x77A42D0", Offset = "0x77A2CD0", VA = "0x1877A42D0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x77A4290", Offset = "0x77A2C90", VA = "0x1877A4290")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x77A41D0", Offset = "0x77A2BD0", VA = "0x1877A41D0")]
		private void NGHBMCLDIEB(ScriptableRenderContext KMDNOIPDFGB, Camera[] HKJBCOCFACO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x77A39B0", Offset = "0x77A23B0", VA = "0x1877A39B0")]
		private void DIGECABNHHC(CommandBuffer LJPLEKNFOKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x8ACA40", Offset = "0x8AB440", VA = "0x1808ACA40")]
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
