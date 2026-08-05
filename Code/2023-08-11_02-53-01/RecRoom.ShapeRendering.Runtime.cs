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
public interface ALNADFFBMPF
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	DLPKAPBCMJD ODGMKJGOOKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	OIODMPKPAKL ODGMKJGOOKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	LADMPFKCMJB ODGMKJGOOKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class OIFKDNFFMPH : DFGLLCLHPPB, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private byte EGKHFHDAOKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly List<SkinnedShapeRenderer>[] HKOGCBNFAJE;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int BAEHEKNJJPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7DFD10", Offset = "0x7DE510", VA = "0x1807DFD10", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x95DB20", Offset = "0x95C320", VA = "0x18095DB20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int LEBOCKJECAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xB7C7C0", Offset = "0xB7AFC0", VA = "0x180B7C7C0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xF6D980", Offset = "0xF6C180", VA = "0x180F6D980")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public float CEHOHAJPFPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7ECB80", Offset = "0x7EB380", VA = "0x1807ECB80", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7ED560", Offset = "0x7EBD60", VA = "0x1807ED560")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public float CFCCGBJNBFH
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7ECDC0", Offset = "0x7EB5C0", VA = "0x1807ECDC0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7ECD70", Offset = "0x7EB570", VA = "0x1807ECD70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public List<SkinnedShapeRenderer> OMDIJHEEMMI
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5E60280", Offset = "0x5E5EA80", VA = "0x185E60280")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public List<SkinnedShapeRenderer> IFFFOMDDGFM
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5E60240", Offset = "0x5E5EA40", VA = "0x185E60240")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public GameObject AELGKCJPGAK
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7F3350", Offset = "0x7F1B50", VA = "0x1807F3350")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x95DB30", Offset = "0x95C330", VA = "0x18095DB30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public byte FPLBFGCKONE
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5E60060", Offset = "0x5E5E860", VA = "0x185E60060", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5E602E0", Offset = "0x5E5EAE0", VA = "0x185E602E0")]
	public OIFKDNFFMPH(List<BHDPMKKJLPI> BCAAKGJJBNK, List<BHDPMKKJLPI> GJAECMKLMCK, List<FCGLJAMFFMC> LAEEAJBOPBC, Material KKNFKPKFEJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5E5FD80", Offset = "0x5E5E580", VA = "0x185E5FD80")]
	private int CKIKHOEJGOO(List<BHDPMKKJLPI> HOLNCNOEMOK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5E600F0", Offset = "0x5E5E8F0", VA = "0x185E600F0")]
	private void MIKHDBOICPC(int ABKFDLNFKCK, bool LLMANHIAOLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5E5FFC0", Offset = "0x5E5E7C0", VA = "0x185E5FFC0")]
	public void EBNDOFGDJKH(Vector3 MPLMODKDGHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5E5FE90", Offset = "0x5E5E690", VA = "0x185E5FE90", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5E600B0", Offset = "0x5E5E8B0", VA = "0x185E600B0")]
	public void KGPJFCJOHDM(Transform DEGOJGLGGBF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
internal class CHDJAMNLBID : OIODMPKPAKL
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	private struct JBONAPMKHHO : EIEOOLMCIPN, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private NCAKMOEEJMF IGPKJFHDBNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private JobHandle LELCJDGAKHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private AEOGDFKMBMN IMIIEAJIFDB;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x5E58840", Offset = "0x5E57040", VA = "0x185E58840")]
		public JBONAPMKHHO(NCAKMOEEJMF IGPKJFHDBNF, JobHandle LELCJDGAKHL, AEOGDFKMBMN IMIIEAJIFDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5E58810", Offset = "0x5E57010", VA = "0x185E58810", Slot = "4")]
		public NCAKMOEEJMF HEIMLJKPJJI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5E587C0", Offset = "0x5E56FC0", VA = "0x185E587C0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly CAJLCABNGEO AHNOMKDBOML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private int[] POHHNAJHHOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private Hash128 KBOEGKPAFIE;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override IANJMDIEMBN LKFEGFBIOHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5E53BA0", Offset = "0x5E523A0", VA = "0x185E53BA0", Slot = "16")]
		get
		{
			return default(IANJMDIEMBN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private Vector3 GCOBAHPJFEN
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5E54D40", Offset = "0x5E53540", VA = "0x185E54D40")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	protected override Hash128 JPANEKKNLEE
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5E55DE0", Offset = "0x5E545E0", VA = "0x185E55DE0", Slot = "21")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5E55F00", Offset = "0x5E54700", VA = "0x185E55F00")]
	public CHDJAMNLBID(DLPKAPBCMJD CEABICNIABB, CAJLCABNGEO NFBDMLCENEN, bool IIDDIHLEHCD = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5E55080", Offset = "0x5E53880", VA = "0x185E55080", Slot = "15")]
	public override bool KCMJFMKLBPG(FCGLJAMFFMC CEABICNIABB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5E53F70", Offset = "0x5E52770", VA = "0x185E53F70", Slot = "17")]
	public override int CKIKHOEJGOO(DKFNPGPEPHH FKDENDKGOLN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5E54240", Offset = "0x5E52A40", VA = "0x185E54240", Slot = "18")]
	public override int GNPIAOBCPHI(DKFNPGPEPHH FKDENDKGOLN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5E542F0", Offset = "0x5E52AF0", VA = "0x185E542F0")]
	private int HBKOKCOMOOJ(DKFNPGPEPHH FKDENDKGOLN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5E545B0", Offset = "0x5E52DB0", VA = "0x185E545B0", Slot = "19")]
	public override void HGPAJHMGJDD(DKFNPGPEPHH FKDENDKGOLN, EEJHEOFEIKI IGBLCNCCGJO, int HDHJKBFCGOB = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5E55D10", Offset = "0x5E54510", VA = "0x185E55D10", Slot = "20")]
	public override FCGLJAMFFMC LPJIDHLJEIH()
	{
		return default(FCGLJAMFFMC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5E54020", Offset = "0x5E52820", VA = "0x185E54020", Slot = "22")]
	public override LBNGBBDCEAJ DGBEHGOHKGG()
	{
		return default(LBNGBBDCEAJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5E554F0", Offset = "0x5E53CF0", VA = "0x185E554F0", Slot = "23")]
	public override EIEOOLMCIPN LLGNCADGEEO(DKFNPGPEPHH FKDENDKGOLN, JobHandle LELCJDGAKHL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class DLPKAPBCMJD : NEMLOEFJBKA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class ABIEPIILGFD : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public DLPKAPBCMJD <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x7DFD30", Offset = "0x7DE530", VA = "0x1807DFD30", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x7DFD30", Offset = "0x7DE530", VA = "0x1807DFD30", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xABFAA0", Offset = "0xABE2A0", VA = "0x180ABFAA0")]
		[DebuggerHidden]
		public ABIEPIILGFD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x5E500A0", Offset = "0x5E4E8A0", VA = "0x185E500A0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x5E4FA40", Offset = "0x5E4E240", VA = "0x185E4FA40", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x5E4FF70", Offset = "0x5E4E770", VA = "0x185E4FF70")]
		private void PPLJHCFFCFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x5E4FF20", Offset = "0x5E4E720", VA = "0x185E4FF20")]
		private void OFDJPHBKOEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x5E4F9F0", Offset = "0x5E4E1F0", VA = "0x185E4F9F0")]
		private void FCHIGNBKGGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x5E50060", Offset = "0x5E4E860", VA = "0x185E50060", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x5E4FFC0", Offset = "0x5E4E7C0", VA = "0x185E4FFC0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x5E4FFC0", Offset = "0x5E4E7C0", VA = "0x185E4FFC0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class DMPBCMBDDPE : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public DLPKAPBCMJD <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x7DFD30", Offset = "0x7DE530", VA = "0x1807DFD30", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x7DFD30", Offset = "0x7DE530", VA = "0x1807DFD30", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xABFAA0", Offset = "0xABE2A0", VA = "0x180ABFAA0")]
		[DebuggerHidden]
		public DMPBCMBDDPE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x5E57D10", Offset = "0x5E56510", VA = "0x185E57D10", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x5E57850", Offset = "0x5E56050", VA = "0x185E57850", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x5E57BE0", Offset = "0x5E563E0", VA = "0x185E57BE0")]
		private void PPLJHCFFCFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x5E57B90", Offset = "0x5E56390", VA = "0x185E57B90")]
		private void OFDJPHBKOEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x5E57CD0", Offset = "0x5E564D0", VA = "0x185E57CD0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x5E57C30", Offset = "0x5E56430", VA = "0x185E57C30", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x5E57C30", Offset = "0x5E56430", VA = "0x185E57C30", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly NOBMKEEGALB KKFNLGBAEPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly List<OIODMPKPAKL> LDJKDMAEAHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private List<ClusterMeshRenderer> PHONOCDBIOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private BatchedMeshRenderer PBIKENHMLFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private bool GJHLCGBAHMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly bool POKGGAOELDL;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IEnumerable<CPINGGDDOGC> HKFCFBPIBHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7DFD30", Offset = "0x7DE530", VA = "0x1807DFD30", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int NGNPPKDKNLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x5E57210", Offset = "0x5E55A10", VA = "0x185E57210", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public FCGLJAMFFMC DPDLNEHOCFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x5E56B10", Offset = "0x5E55310", VA = "0x185E56B10", Slot = "8")]
		get
		{
			return default(FCGLJAMFFMC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public List<SkinnedShapeRenderer> CPFCAIDCPIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7ED740", Offset = "0x7EBF40", VA = "0x1807ED740")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7ED730", Offset = "0x7EBF30", VA = "0x1807ED730")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5E57180", Offset = "0x5E55980", VA = "0x185E57180")]
	private bool HHNJNEBELBI(OIODMPKPAKL PPGDJFEKKLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5E56BD0", Offset = "0x5E553D0", VA = "0x185E56BD0")]
	private static bool FCGJPIPECKP(OIODMPKPAKL PPGDJFEKKLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5E57760", Offset = "0x5E55F60", VA = "0x185E57760")]
	public DLPKAPBCMJD(NOBMKEEGALB NFBDMLCENEN, bool DHPKFHJEDBK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5E56920", Offset = "0x5E55120", VA = "0x185E56920", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5E56D20", Offset = "0x5E55520", VA = "0x185E56D20")]
	public void GLILACFFLBJ(OIODMPKPAKL PPGDJFEKKLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5E56BF0", Offset = "0x5E553F0", VA = "0x185E56BF0")]
	public void FNJGHMKCCPI(OIODMPKPAKL PPGDJFEKKLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5E572C0", Offset = "0x5E55AC0", VA = "0x185E572C0", Slot = "4")]
	public void OIFMGHNFIBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5E566D0", Offset = "0x5E54ED0", VA = "0x185E566D0")]
	public void DNNKNEBJAJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5E56F50", Offset = "0x5E55750", VA = "0x185E56F50")]
	private void HEIDGDJLAJK(List<OIODMPKPAKL> LDJKDMAEAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5E571B0", Offset = "0x5E559B0", VA = "0x185E571B0")]
	private static Material KFLLPIIBNPD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5E570E0", Offset = "0x5E558E0", VA = "0x185E570E0")]
	private void HEIDGDJLAJK(OIODMPKPAKL PPGDJFEKKLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5E56560", Offset = "0x5E54D60", VA = "0x185E56560")]
	private void DBHDFPICJKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5E55FB0", Offset = "0x5E547B0", VA = "0x185E55FB0")]
	public void CNMFJOCPALE(bool BCLDAHNJPMM, bool CBGKOIIKMCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5E56640", Offset = "0x5E54E40", VA = "0x185E56640")]
	protected void DBKLAMJOPMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5E56AA0", Offset = "0x5E552A0", VA = "0x185E56AA0")]
	[IteratorStateMachine(typeof(ABIEPIILGFD))]
	public IEnumerable<Renderer> EDANMEPPELP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5E57250", Offset = "0x5E55A50", VA = "0x185E57250")]
	[IteratorStateMachine(typeof(DMPBCMBDDPE))]
	public IEnumerable<Renderer> NPHGEAOPODF()
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
		[Cpp2IlInjected.Address(RVA = "0x5E608C0", Offset = "0x5E5F0C0", VA = "0x185E608C0")]
		public ShapeRendererConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[DefaultMember("Item")]
public class ALBCNBFANHB : IENGMMMKEAP, IDisposable, ALNADFFBMPF
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static readonly JNGNMMOLKFF MBNJNNGOKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly DMDEOHJBDAJ<DALIHHPCPCG, DLPKAPBCMJD> NHCNNCOLOAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly DMDEOHJBDAJ<ANJBNEOMFCE, OIODMPKPAKL> LDJKDMAEAHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly DMDEOHJBDAJ<MOMHPNHAPLP, LADMPFKCMJB> FLFLAKJHKIM;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public DLPKAPBCMJD ODGMKJGOOKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x5E50260", Offset = "0x5E4EA60", VA = "0x185E50260", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public OIODMPKPAKL ODGMKJGOOKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x5E50200", Offset = "0x5E4EA00", VA = "0x185E50200", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public LADMPFKCMJB ODGMKJGOOKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x5E501A0", Offset = "0x5E4E9A0", VA = "0x185E501A0", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public bool GMBLANGPOIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x951EF0", Offset = "0x9506F0", VA = "0x180951EF0", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x951E10", Offset = "0x950610", VA = "0x180951E10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5E50C10", Offset = "0x5E4F410", VA = "0x185E50C10")]
	public ALBCNBFANHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5E50400", Offset = "0x5E4EC00", VA = "0x185E50400", Slot = "21")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5E50580", Offset = "0x5E4ED80", VA = "0x185E50580", Slot = "4")]
	public DALIHHPCPCG KENBNOPGEKE(NOBMKEEGALB NFBDMLCENEN)
	{
		return default(DALIHHPCPCG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5E50580", Offset = "0x5E4ED80", VA = "0x185E50580", Slot = "5")]
	public DALIHHPCPCG KENBNOPGEKE(NOBMKEEGALB NFBDMLCENEN, bool DHPKFHJEDBK)
	{
		return default(DALIHHPCPCG);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5E50340", Offset = "0x5E4EB40", VA = "0x185E50340", Slot = "6")]
	public void CFGIBNNALGE(DALIHHPCPCG CEABICNIABB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5E502C0", Offset = "0x5E4EAC0", VA = "0x185E502C0", Slot = "7")]
	public void BABCGJOJNIC(DALIHHPCPCG CEABICNIABB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5E50690", Offset = "0x5E4EE90", VA = "0x185E50690", Slot = "8")]
	public ANJBNEOMFCE LBAPPGJPPDD(DALIHHPCPCG CEABICNIABB, CAJLCABNGEO NFBDMLCENEN)
	{
		return default(ANJBNEOMFCE);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5E50980", Offset = "0x5E4F180", VA = "0x185E50980", Slot = "9")]
	public ANJBNEOMFCE OJLEEGKDMMC(DALIHHPCPCG CEABICNIABB, LOFGABNDNFF NFBDMLCENEN)
	{
		return default(ANJBNEOMFCE);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5E50830", Offset = "0x5E4F030", VA = "0x185E50830", Slot = "11")]
	public void MJMMOCCCCJE(ANJBNEOMFCE PPGDJFEKKLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5E508C0", Offset = "0x5E4F0C0", VA = "0x185E508C0", Slot = "10")]
	public void NKKLJCOKFAC(ANJBNEOMFCE PPGDJFEKKLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x5E507C0", Offset = "0x5E4EFC0", VA = "0x185E507C0", Slot = "20")]
	public IEnumerable<Renderer> LMPMDBCMJDD(DALIHHPCPCG CEABICNIABB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5E50500", Offset = "0x5E4ED00", VA = "0x185E50500", Slot = "12")]
	public MOMHPNHAPLP JGEMAAHCGFO(ABEPKKMHMBM NFBDMLCENEN)
	{
		return default(MOMHPNHAPLP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5E50490", Offset = "0x5E4EC90", VA = "0x185E50490", Slot = "14")]
	public void GELOMBODBAM(MOMHPNHAPLP GMHOBLHFELM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x5E50920", Offset = "0x5E4F120", VA = "0x185E50920", Slot = "16")]
	public Task OCKHLCEINAA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5E50B20", Offset = "0x5E4F320", VA = "0x185E50B20", Slot = "17")]
	public Task PLGEOALJFON()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5E503A0", Offset = "0x5E4EBA0", VA = "0x185E503A0", Slot = "18")]
	public Task DIJAGLBAJBI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x270DF40", Offset = "0x270C740", VA = "0x18270DF40", Slot = "19")]
	public void ALJOEPLFANJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5E50AC0", Offset = "0x5E4F2C0", VA = "0x185E50AC0", Slot = "13")]
	public void PGFMOHJGIGI(MOMHPNHAPLP GMHOBLHFELM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface ECLIIBHHFEC
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LDPFCANJGAD(KJCKPCKEGIG EIOLDDJPDLH, Renderer ELFIBKIDJLE, int NLEJBLMNFDB);

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HJMPFJCBKLJ(Renderer ELFIBKIDJLE, CIMOBNLPLNK DPOLNPPBIKM, Vector3 ACAJLGGLEGC, Vector3 KFCKCHEDNLL, Vector3 INLOFAPIGLO, float HPPGAMGKFEA, float ACIOBGNDEEB, float BIPMBGJMPOD = -1f, [Optional] Color? JIINIIPALJJ, [Optional] IReadOnlyList<Camera> OIAGLPNAJPM);

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ICFBGCJKHJC(Renderer ELFIBKIDJLE, int NLEJBLMNFDB);

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int IFOGDDJJIHD();

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GGCMBDHPOCA(int OLJJNFKDEFI, FMCIPOPBHDP EIOLDDJPDLH, Renderer ELFIBKIDJLE, int NLEJBLMNFDB);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class MMLJHOJMJLN : FCPCEKOLEJP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private class ILGBMGCFDEH : IJNIPPKHIAK<int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x5E58770", Offset = "0x5E56F70", VA = "0x185E58770")]
		public ILGBMGCFDEH(string MDOAADHDBMA)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly ECLIIBHHFEC OKDJNHMKMEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly ALNADFFBMPF KKGPEFABKBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private MeshRenderer DABGAGDDPMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private ILGBMGCFDEH AFALIEFHOEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private bool GJBFIPBIKKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private MeshRenderer HLOFACMIJJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private ILGBMGCFDEH JCMMAAPMAHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private bool ILMOGMLMPOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private MeshRenderer PHCEGEANHJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private ILGBMGCFDEH BDCFOCMFPPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private bool PMADFOMNIPK;

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5E5C310", Offset = "0x5E5AB10", VA = "0x185E5C310")]
	public MMLJHOJMJLN(ECLIIBHHFEC GGMMMJCLMPP, ALNADFFBMPF KKGPEFABKBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5E5A5E0", Offset = "0x5E58DE0", VA = "0x185E5A5E0", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5E5B700", Offset = "0x5E59F00", VA = "0x185E5B700")]
	private void JEMDLMBIHHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x5E5A3E0", Offset = "0x5E58BE0", VA = "0x185E5A3E0", Slot = "4")]
	public void BKILLDNCFAA(DALIHHPCPCG CEABICNIABB, FMCIPOPBHDP FPMLPGBBOFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x5E5A1C0", Offset = "0x5E589C0", VA = "0x185E5A1C0", Slot = "5")]
	public void BKILLDNCFAA(ANJBNEOMFCE PPGDJFEKKLN, FMCIPOPBHDP FPMLPGBBOFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x5E5BB10", Offset = "0x5E5A310", VA = "0x185E5BB10", Slot = "6")]
	public void LDLLIMLEIID(ANJBNEOMFCE PPGDJFEKKLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x5E5BC40", Offset = "0x5E5A440", VA = "0x185E5BC40", Slot = "7")]
	public void LIPEGCJMBGO(ANJBNEOMFCE PPGDJFEKKLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x5E5B950", Offset = "0x5E5A150", VA = "0x185E5B950", Slot = "21")]
	public void KFFEAKIGGDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x13BFF20", Offset = "0x13BE720", VA = "0x1813BFF20", Slot = "8")]
	public void HKEBAJMGDAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x5E5C1A0", Offset = "0x5E5A9A0", VA = "0x185E5C1A0", Slot = "9")]
	public void OPEEBKBCENA(FMCIPOPBHDP FPMLPGBBOFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x5E5B200", Offset = "0x5E59A00", VA = "0x185E5B200", Slot = "10")]
	public void JDKBIAMAEKI(DALIHHPCPCG CEABICNIABB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5E5B3B0", Offset = "0x5E59BB0", VA = "0x185E5B3B0", Slot = "11")]
	public void JDKBIAMAEKI(ANJBNEOMFCE PPGDJFEKKLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5E5BE00", Offset = "0x5E5A600", VA = "0x185E5BE00", Slot = "12")]
	public void OIHOFFLKBED(DALIHHPCPCG CEABICNIABB, KJCKPCKEGIG EIOLDDJPDLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x5E5BFB0", Offset = "0x5E5A7B0", VA = "0x185E5BFB0", Slot = "13")]
	public void OIHOFFLKBED(ANJBNEOMFCE PPGDJFEKKLN, KJCKPCKEGIG EIOLDDJPDLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x5E5B990", Offset = "0x5E5A190", VA = "0x185E5B990", Slot = "22")]
	public void KGDOKIHEMHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x5E5BD60", Offset = "0x5E5A560", VA = "0x185E5BD60", Slot = "14")]
	public void NBFKBHFHKPH(ANJBNEOMFCE PPGDJFEKKLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x5E5AA00", Offset = "0x5E59200", VA = "0x185E5AA00", Slot = "15")]
	public void HBLHDCMGIIL(ANJBNEOMFCE PPGDJFEKKLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x9E7B60", Offset = "0x9E6360", VA = "0x1809E7B60", Slot = "16")]
	public void EONPLJFPOBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x5E5B9D0", Offset = "0x5E5A1D0", VA = "0x185E5B9D0", Slot = "17")]
	public void KPGMHLCDIFF(KJCKPCKEGIG EIOLDDJPDLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x5E5A7B0", Offset = "0x5E58FB0", VA = "0x185E5A7B0")]
	private void EBOPIDOCAKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x5E5AE90", Offset = "0x5E59690", VA = "0x185E5AE90", Slot = "18")]
	public void IDMJFDCMIJB(DALIHHPCPCG CEABICNIABB, Vector3 ACAJLGGLEGC, Vector3 KFCKCHEDNLL, Vector3 INLOFAPIGLO, float HPPGAMGKFEA, float ACIOBGNDEEB, IReadOnlyList<Camera> AHJEOLMMDMG, CIMOBNLPLNK DPOLNPPBIKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x5E5AA90", Offset = "0x5E59290", VA = "0x185E5AA90", Slot = "19")]
	public void IDMJFDCMIJB(MOMHPNHAPLP GMHOBLHFELM, Vector3 ACAJLGGLEGC, Vector3 KFCKCHEDNLL, Vector3 INLOFAPIGLO, float HPPGAMGKFEA, float ACIOBGNDEEB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class NNINDJCHAOH
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class LMKIHBFMDCL : IEnumerable<PHEEMJBBGNH>, IEnumerable, IEnumerator<PHEEMJBBGNH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private PHEEMJBBGNH <>2__current;

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
		private PHEEMJBBGNH System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.PrimitiveShapeMeshData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x7DFD30", Offset = "0x7DE530", VA = "0x1807DFD30", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x7DFD30", Offset = "0x7DE530", VA = "0x1807DFD30", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xABFAA0", Offset = "0xABE2A0", VA = "0x180ABFAA0")]
		[DebuggerHidden]
		public LMKIHBFMDCL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x5E5A010", Offset = "0x5E58810", VA = "0x185E5A010", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x5E5A180", Offset = "0x5E58980", VA = "0x185E5A180", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x5E5A0F0", Offset = "0x5E588F0", VA = "0x185E5A0F0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<PHEEMJBBGNH> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.PrimitiveShapeMeshData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x5E5A0F0", Offset = "0x5E588F0", VA = "0x185E5A0F0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private static PHEEMJBBGNH[][] AMEOEJJCIMK;

	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private static MLCEFHIPOCO JDDKOBNBOPG;

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public static ShapeRendererConfig MJDEGMPIIJP;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public static ComputeShader FMKFDMIEBFC
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x5E5F440", Offset = "0x5E5DC40", VA = "0x185E5F440")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public static SkinnedShapeRenderer AOLEIHNLNAB
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x5E5F950", Offset = "0x5E5E150", VA = "0x185E5F950")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x5E5F4B0", Offset = "0x5E5DCB0", VA = "0x185E5F4B0")]
	public static Mesh GHKMMNCMBKK(CBDLPCPLEAM AKBEBLONBKH, int FKDENDKGOLN = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x5E5F9C0", Offset = "0x5E5E1C0", VA = "0x185E5F9C0")]
	public static int NGJGDNALKNC(CBDLPCPLEAM AKBEBLONBKH, int FKDENDKGOLN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x5E5FB80", Offset = "0x5E5E380", VA = "0x185E5FB80")]
	public static MLCEFHIPOCO POPEIDDCPCG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5E5F570", Offset = "0x5E5DD70", VA = "0x185E5F570")]
	[IteratorStateMachine(typeof(LMKIHBFMDCL))]
	private static IEnumerable<PHEEMJBBGNH> HCEPNLMBCJE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x5E5F5D0", Offset = "0x5E5DDD0", VA = "0x185E5F5D0")]
	public static PHEEMJBBGNH IDIHFBLHHJP(CBDLPCPLEAM AKBEBLONBKH, int FKDENDKGOLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x5E5F930", Offset = "0x5E5E130", VA = "0x185E5F930")]
	public static bool KBENNCIICBC(this CBDLPCPLEAM AKBEBLONBKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x5E5F9D0", Offset = "0x5E5E1D0", VA = "0x185E5F9D0")]
	public static void PDMHJPLHHLC(CBDLPCPLEAM AKBEBLONBKH, float3 JCHFALMEICG, out ADGMIJJHGGK BBJNPJIFKHK, out float3 FNCNIBFBBMP, out float JNCKNBGBHIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x5E5F0A0", Offset = "0x5E5D8A0", VA = "0x185E5F0A0")]
	public static void BBLMMLDLLLG(Vector3 JCHFALMEICG, CBDLPCPLEAM AKBEBLONBKH, out Vector3 FNCNIBFBBMP, out float JNCKNBGBHIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x5E5F430", Offset = "0x5E5DC30", VA = "0x185E5F430")]
	[MJIBHDEGBGP(LPNMEKMJEJD.ExitingPlayMode, 0)]
	private static void BGIMKKJOGPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x5E5EE80", Offset = "0x5E5D680", VA = "0x185E5EE80")]
	[MJIBHDEGBGP(LPNMEKMJEJD.ExitingPlayMode, 0)]
	private static void ABMNPGGLMKG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public abstract class OIODMPKPAKL : NHMOHFCGBEA, CPINGGDDOGC, EAABNJECAEG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly DLPKAPBCMJD AELGKCJPGAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	protected Bounds IJHIEIGHNLM;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public Bounds OIGHKMLDFJE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x125D2A0", Offset = "0x125BAA0", VA = "0x18125D2A0", Slot = "4")]
		get
		{
			return default(Bounds);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public virtual IANJMDIEMBN LKFEGFBIOHD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x5E606A0", Offset = "0x5E5EEA0", VA = "0x185E606A0", Slot = "16")]
		get
		{
			return default(IANJMDIEMBN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public bool POKGGAOELDL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x7ECD80", Offset = "0x7EB580", VA = "0x1807ECD80")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x7ECD90", Offset = "0x7EB590", VA = "0x1807ECD90")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	protected abstract Hash128 JPANEKKNLEE
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int HGBFFFNOECO
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x7F0C80", Offset = "0x7EF480", VA = "0x1807F0C80", Slot = "8")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public IPJFKLIEPCN PBHMKEODBAN
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7ED740", Offset = "0x7EBF40", VA = "0x1807ED740")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x7ED730", Offset = "0x7EBF30", VA = "0x1807ED730")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public bool MKIBLFIJDGF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x31CEF60", Offset = "0x31CD760", VA = "0x1831CEF60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x8BA230", Offset = "0x8B8A30", VA = "0x1808BA230")]
	protected OIODMPKPAKL(DLPKAPBCMJD CEABICNIABB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x5E60730", Offset = "0x5E5EF30", VA = "0x185E60730", Slot = "14")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x8A3C30", Offset = "0x8A2430", VA = "0x1808A3C30", Slot = "15")]
	public virtual bool KCMJFMKLBPG(FCGLJAMFFMC CEABICNIABB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "17")]
	public abstract int CKIKHOEJGOO(DKFNPGPEPHH FKDENDKGOLN);

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "18")]
	public abstract int GNPIAOBCPHI(DKFNPGPEPHH FKDENDKGOLN);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "19")]
	public abstract void HGPAJHMGJDD(DKFNPGPEPHH FKDENDKGOLN, EEJHEOFEIKI IGBLCNCCGJO, int HDHJKBFCGOB = -1);

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "20")]
	public abstract FCGLJAMFFMC LPJIDHLJEIH();

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x5E60860", Offset = "0x5E5F060", VA = "0x185E60860", Slot = "10")]
	public Hash128 FHEEHNAOFIN(int FKDENDKGOLN)
	{
		return default(Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "22")]
	public abstract LBNGBBDCEAJ DGBEHGOHKGG();

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "23")]
	public abstract EIEOOLMCIPN LLGNCADGEEO(DKFNPGPEPHH FKDENDKGOLN, JobHandle LELCJDGAKHL);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x5E60890", Offset = "0x5E5F090", VA = "0x185E60890", Slot = "9")]
	public EIEOOLMCIPN JMBFDMGOLGD(int FKDENDKGOLN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class BKBEBNPMGOP : OIODMPKPAKL
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	private struct IJGJKEDHMGD : EIEOOLMCIPN, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private NCAKMOEEJMF IGPKJFHDBNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private JobHandle LELCJDGAKHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private HBDABHOHAHL IMIIEAJIFDB;

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x5E58710", Offset = "0x5E56F10", VA = "0x185E58710")]
		public IJGJKEDHMGD(NCAKMOEEJMF IGPKJFHDBNF, JobHandle LELCJDGAKHL, HBDABHOHAHL IMIIEAJIFDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x5E586E0", Offset = "0x5E56EE0", VA = "0x185E586E0", Slot = "4")]
		public NCAKMOEEJMF HEIMLJKPJJI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x5E58690", Offset = "0x5E56E90", VA = "0x185E58690", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private readonly LOFGABNDNFF PCABHAGACNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private float PLJPOAJHEFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private Hash128 KBOEGKPAFIE;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	protected override Hash128 JPANEKKNLEE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x5E539D0", Offset = "0x5E521D0", VA = "0x185E539D0", Slot = "21")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x5E53AF0", Offset = "0x5E522F0", VA = "0x185E53AF0")]
	public BKBEBNPMGOP(DLPKAPBCMJD CEABICNIABB, LOFGABNDNFF NFBDMLCENEN, bool DHPKFHJEDBK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x8A3C30", Offset = "0x8A2430", VA = "0x1808A3C30", Slot = "15")]
	public override bool KCMJFMKLBPG(FCGLJAMFFMC CEABICNIABB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x5E52360", Offset = "0x5E50B60", VA = "0x185E52360", Slot = "17")]
	public override int CKIKHOEJGOO(DKFNPGPEPHH FKDENDKGOLN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x5E52770", Offset = "0x5E50F70", VA = "0x185E52770", Slot = "18")]
	public override int GNPIAOBCPHI(DKFNPGPEPHH FKDENDKGOLN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x5E52960", Offset = "0x5E51160", VA = "0x185E52960", Slot = "19")]
	public override void HGPAJHMGJDD(DKFNPGPEPHH FKDENDKGOLN, EEJHEOFEIKI IGBLCNCCGJO, int HDHJKBFCGOB = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x5E53900", Offset = "0x5E52100", VA = "0x185E53900", Slot = "20")]
	public override FCGLJAMFFMC LPJIDHLJEIH()
	{
		return default(FCGLJAMFFMC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x5E52550", Offset = "0x5E50D50", VA = "0x185E52550", Slot = "22")]
	public override LBNGBBDCEAJ DGBEHGOHKGG()
	{
		return default(LBNGBBDCEAJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x5E53040", Offset = "0x5E51840", VA = "0x185E53040", Slot = "23")]
	public override EIEOOLMCIPN LLGNCADGEEO(DKFNPGPEPHH FKDENDKGOLN, JobHandle LELCJDGAKHL)
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
		private MaterialPropertyBlock IPDADACENAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private BHDPMKKJLPI IGPKJFHDBNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private List<FCGLJAMFFMC> LAEEAJBOPBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private RenderTexture LKEIALJGIGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private ComputeBuffer HKHAEDJJADH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private ComputeShader HBFAOEGAKAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private Matrix4x4[] GNFCELAMNPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private int EJLHLBGHGIB;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public MeshRenderer FPMDLMCPGLD
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x7DFD30", Offset = "0x7DE530", VA = "0x1807DFD30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x8E7480", Offset = "0x8E5C80", VA = "0x1808E7480")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public int ILOIONPACOL
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x5E61580", Offset = "0x5E5FD80", VA = "0x185E61580")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x5E60B20", Offset = "0x5E5F320", VA = "0x185E60B20")]
		public static List<SkinnedShapeRenderer> Create(GameObject CEABICNIABB, List<BHDPMKKJLPI> HOLNCNOEMOK, List<FCGLJAMFFMC> LAEEAJBOPBC, Material KKNFKPKFEJH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x5E60F30", Offset = "0x5E5F730", VA = "0x185E60F30")]
		public void Init(BHDPMKKJLPI IGPKJFHDBNF, List<FCGLJAMFFMC> LAEEAJBOPBC, Material KKNFKPKFEJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x5E614D0", Offset = "0x5E5FCD0", VA = "0x185E614D0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x5E61420", Offset = "0x5E5FC20", VA = "0x185E61420")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x5E613E0", Offset = "0x5E5FBE0", VA = "0x185E613E0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x5E608F0", Offset = "0x5E5F0F0", VA = "0x185E608F0")]
		private void ANIMAPNHDKO(ScriptableRenderContext HNBDDLBIIOF, Camera[] NNPFPOJFEBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x5E60D70", Offset = "0x5E5F570", VA = "0x185E60D70")]
		private void ELODNHEKCCH(CommandBuffer HHGPEMBDGCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x90A150", Offset = "0x908950", VA = "0x18090A150")]
		public SkinnedShapeRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface MJCPJIIFKHG
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	bool OKEMPMNPMAB
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Material FBCBLDMFBGD();

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Material KFLLPIIBNPD();

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Material BCEBKFLPLBP();

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int MAIKMFNDAEK(HKLBLNKGABG JOGKLMKACMD);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int AJIAJJIAEAK(HALJELNOGOG HAKMOCKENOE);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OJGLCBDOADG(GameObject CEPDEAHBHLF);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void HKHILKNHLCH(GameObject CEPDEAHBHLF, bool EIOGJEKIPPF);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class NCIKOKFGEOC
{
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private static MJCPJIIFKHG PBDNMEDOHIG;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public static bool OKEMPMNPMAB
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x5E5C570", Offset = "0x5E5AD70", VA = "0x185E5C570")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x5E5C630", Offset = "0x5E5AE30", VA = "0x185E5C630")]
	public static void MABKCIGLBDL(MJCPJIIFKHG CJJHJPMOMDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x5E5C430", Offset = "0x5E5AC30", VA = "0x185E5C430")]
	public static Material FBCBLDMFBGD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x5E5C5D0", Offset = "0x5E5ADD0", VA = "0x185E5C5D0")]
	public static Material KFLLPIIBNPD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x5E5C3D0", Offset = "0x5E5ABD0", VA = "0x185E5C3D0")]
	public static Material BCEBKFLPLBP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x5E5C680", Offset = "0x5E5AE80", VA = "0x185E5C680")]
	public static int MAIKMFNDAEK(HKLBLNKGABG JOGKLMKACMD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x5E5C360", Offset = "0x5E5AB60", VA = "0x185E5C360")]
	public static int AJIAJJIAEAK(HALJELNOGOG HAKMOCKENOE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x5E5C6F0", Offset = "0x5E5AEF0", VA = "0x185E5C6F0")]
	public static void OJGLCBDOADG(GameObject CEPDEAHBHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x5E5C490", Offset = "0x5E5AC90", VA = "0x185E5C490")]
	public static void HKHILKNHLCH(GameObject CEPDEAHBHLF, bool EIOGJEKIPPF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[DefaultMember("Item")]
public class NKCNNEGOEOG : IENGMMMKEAP, IDisposable, ALNADFFBMPF
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class HDMMONLNLIE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public NKCNNEGOEOG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public HDMMONLNLIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x5E581D0", Offset = "0x5E569D0", VA = "0x185E581D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly DMDEOHJBDAJ<DALIHHPCPCG, DLPKAPBCMJD> NHCNNCOLOAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly DMDEOHJBDAJ<ANJBNEOMFCE, OIODMPKPAKL> LDJKDMAEAHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly DMDEOHJBDAJ<MOMHPNHAPLP, LADMPFKCMJB> FLFLAKJHKIM;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public DLPKAPBCMJD ODGMKJGOOKN
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x5E5C820", Offset = "0x5E5B020", VA = "0x185E5C820", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public OIODMPKPAKL ODGMKJGOOKN
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x5E5C880", Offset = "0x5E5B080", VA = "0x185E5C880", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public LADMPFKCMJB ODGMKJGOOKN
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x5E5C7C0", Offset = "0x5E5AFC0", VA = "0x185E5C7C0", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool GMBLANGPOIC
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x951EF0", Offset = "0x9506F0", VA = "0x180951EF0", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x951E10", Offset = "0x950610", VA = "0x180951E10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x5E5E9C0", Offset = "0x5E5D1C0", VA = "0x185E5E9C0")]
	public NKCNNEGOEOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x5E5D090", Offset = "0x5E5B890", VA = "0x185E5D090", Slot = "21")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x5E5D320", Offset = "0x5E5BB20", VA = "0x185E5D320", Slot = "4")]
	public DALIHHPCPCG KENBNOPGEKE(NOBMKEEGALB NFBDMLCENEN)
	{
		return default(DALIHHPCPCG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x5E5D330", Offset = "0x5E5BB30", VA = "0x185E5D330", Slot = "5")]
	public DALIHHPCPCG KENBNOPGEKE(NOBMKEEGALB NFBDMLCENEN, bool DHPKFHJEDBK)
	{
		return default(DALIHHPCPCG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x5E5CD00", Offset = "0x5E5B500", VA = "0x185E5CD00", Slot = "6")]
	public void CFGIBNNALGE(DALIHHPCPCG CEABICNIABB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x5E5C970", Offset = "0x5E5B170", VA = "0x185E5C970", Slot = "7")]
	public void BABCGJOJNIC(DALIHHPCPCG CEABICNIABB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x5E5D5C0", Offset = "0x5E5BDC0", VA = "0x185E5D5C0", Slot = "8")]
	public ANJBNEOMFCE LBAPPGJPPDD(DALIHHPCPCG CEABICNIABB, CAJLCABNGEO NFBDMLCENEN)
	{
		return default(ANJBNEOMFCE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x5E5E300", Offset = "0x5E5CB00", VA = "0x185E5E300", Slot = "9")]
	public ANJBNEOMFCE OJLEEGKDMMC(DALIHHPCPCG CEABICNIABB, LOFGABNDNFF NFBDMLCENEN)
	{
		return default(ANJBNEOMFCE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x5E5DB30", Offset = "0x5E5C330", VA = "0x185E5DB30", Slot = "11")]
	public void MJMMOCCCCJE(ANJBNEOMFCE PPGDJFEKKLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x5E5DF20", Offset = "0x5E5C720", VA = "0x185E5DF20", Slot = "10")]
	public void NKKLJCOKFAC(ANJBNEOMFCE PPGDJFEKKLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x5E5DAC0", Offset = "0x5E5C2C0", VA = "0x185E5DAC0", Slot = "20")]
	public IEnumerable<Renderer> LMPMDBCMJDD(DALIHHPCPCG CEABICNIABB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x5E5D2A0", Offset = "0x5E5BAA0", VA = "0x185E5D2A0", Slot = "12")]
	public MOMHPNHAPLP JGEMAAHCGFO(ABEPKKMHMBM NFBDMLCENEN)
	{
		return default(MOMHPNHAPLP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x5E5D230", Offset = "0x5E5BA30", VA = "0x185E5D230", Slot = "14")]
	public void GELOMBODBAM(MOMHPNHAPLP GMHOBLHFELM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x5E5E190", Offset = "0x5E5C990", VA = "0x185E5E190", Slot = "16")]
	public Task OCKHLCEINAA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x5E5E860", Offset = "0x5E5D060", VA = "0x185E5E860", Slot = "17")]
	public Task PLGEOALJFON()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x5E5CF70", Offset = "0x5E5B770", VA = "0x185E5CF70", Slot = "18")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(HDMMONLNLIE))]
	public Task DIJAGLBAJBI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x5E5C8E0", Offset = "0x5E5B0E0", VA = "0x185E5C8E0", Slot = "19")]
	public void ALJOEPLFANJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x5E5E800", Offset = "0x5E5D000", VA = "0x185E5E800", Slot = "13")]
	public void PGFMOHJGIGI(MOMHPNHAPLP GMHOBLHFELM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class BHDPMKKJLPI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	private struct CFFIPJOEAFD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public EEJHEOFEIKI LAPAIBANHIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public FCGLJAMFFMC IMEMEIIDCAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public int AAKHGHDCBPD;
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class DAJDEFGDDKN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public BHDPMKKJLPI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public int numVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public int numIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public DKFNPGPEPHH lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public List<CFFIPJOEAFD> boneMeshInfos;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public DAJDEFGDDKN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class JNCAHOGGNLK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public NCAKMOEEJMF combinedMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public DAJDEFGDDKN CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public JNCAHOGGNLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x5E588D0", Offset = "0x5E570D0", VA = "0x185E588D0")]
		internal JobHandle DCAPKAENBHC()
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x5E58890", Offset = "0x5E57090", VA = "0x185E58890")]
		internal void AFBKOBLJPLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x5E58940", Offset = "0x5E57140", VA = "0x185E58940")]
		internal void HLKJEHOPEEL()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private int[] CLHOAJLHBNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private PFPDGGIFENC LJCPPJIHONN;

	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private static Matrix4x4 GBMMOCJNCHF;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public Mesh DJKHBGLICBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x7DF170", Offset = "0x7DD970", VA = "0x1807DF170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x892CB0", Offset = "0x8914B0", VA = "0x180892CB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public int FLAGBEGBCIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x90BAA0", Offset = "0x90A2A0", VA = "0x18090BAA0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x979F40", Offset = "0x978740", VA = "0x180979F40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x5E51060", Offset = "0x5E4F860", VA = "0x185E51060")]
	public void ELODNHEKCCH(List<FCGLJAMFFMC> PMNKGBMKPOG, Matrix4x4[] JNINBHOEHBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x5E517C0", Offset = "0x5E4FFC0", VA = "0x185E517C0")]
	public static List<BHDPMKKJLPI> OIAKNFDBOOD(List<DLPKAPBCMJD> OFAMIMOGMOA, DKFNPGPEPHH FKDENDKGOLN, Bounds LMFHKKKEDAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x5E513D0", Offset = "0x5E4FBD0", VA = "0x185E513D0")]
	private JobHandle NJEGMEGCHFC(NCAKMOEEJMF FEEBBEPPKFH, int FCNCIGMFJGD, int FHCJEHJAPHF, DKFNPGPEPHH FKDENDKGOLN, List<CFFIPJOEAFD> EFEDAPJNODP)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x5E512C0", Offset = "0x5E4FAC0", VA = "0x185E512C0")]
	private void MANGHCNIKDL(List<CFFIPJOEAFD> EFEDAPJNODP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x5E51F30", Offset = "0x5E50730", VA = "0x185E51F30")]
	private BHDPMKKJLPI(List<CFFIPJOEAFD> EFEDAPJNODP, int FCNCIGMFJGD, int FHCJEHJAPHF, DKFNPGPEPHH FKDENDKGOLN, Bounds LMFHKKKEDAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x5E50FF0", Offset = "0x5E4F7F0", VA = "0x185E50FF0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class LADMPFKCMJB : NEMLOEFJBKA
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class HBDLKAKKLIN : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public LADMPFKCMJB <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x7DFD30", Offset = "0x7DE530", VA = "0x1807DFD30", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x7DFD30", Offset = "0x7DE530", VA = "0x1807DFD30", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0xABFAA0", Offset = "0xABE2A0", VA = "0x180ABFAA0")]
		[DebuggerHidden]
		public HBDLKAKKLIN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x5E58140", Offset = "0x5E56940", VA = "0x185E58140", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x5E57DF0", Offset = "0x5E565F0", VA = "0x185E57DF0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x5E58010", Offset = "0x5E56810", VA = "0x185E58010")]
		private void PPLJHCFFCFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x5E58100", Offset = "0x5E56900", VA = "0x185E58100", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x5E58060", Offset = "0x5E56860", VA = "0x185E58060", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x5E58060", Offset = "0x5E56860", VA = "0x185E58060", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly ABEPKKMHMBM FFPFLMJKCEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly ALNADFFBMPF KKGPEFABKBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private OIFKDNFFMPH FMJOKNDMLOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private List<BHDPMKKJLPI> HHFIBEKPNNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private List<BHDPMKKJLPI> IFHNNIJJGCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private GameObject DMMPBNNLPDJ;

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x5E592C0", Offset = "0x5E57AC0", VA = "0x185E592C0")]
	public static LADMPFKCMJB NBKFHJLOJEK(ABEPKKMHMBM NFBDMLCENEN, ALNADFFBMPF KKGPEFABKBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x5E59F10", Offset = "0x5E58710", VA = "0x185E59F10")]
	private LADMPFKCMJB(ABEPKKMHMBM NFBDMLCENEN, ALNADFFBMPF KKGPEFABKBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x5E58D60", Offset = "0x5E57560", VA = "0x185E58D60")]
	public void FEIFDLJJPLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x5E58CF0", Offset = "0x5E574F0", VA = "0x185E58CF0")]
	[IteratorStateMachine(typeof(HBDLKAKKLIN))]
	public IEnumerable<Renderer> EDANMEPPELP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x5E59430", Offset = "0x5E57C30", VA = "0x185E59430", Slot = "4")]
	public void OIFMGHNFIBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x5E59220", Offset = "0x5E57A20", VA = "0x185E59220")]
	private void JJPAECBFNGO(Vector3 MPLMODKDGHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x5E58AB0", Offset = "0x5E572B0", VA = "0x185E58AB0")]
	public void DNNKNEBJAJP()
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
