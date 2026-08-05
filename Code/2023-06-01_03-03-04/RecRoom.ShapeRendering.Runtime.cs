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
public interface LPEOPNPNMLE
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	CGPIBIJBJEL OILDPKEFAJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	JCAKCJAPNMN OILDPKEFAJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	OCHICALHIDA OILDPKEFAJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class DJNPCDEHLMO : HBDJOEFDAKK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private const byte NLOKNFBPLIM = byte.MaxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private byte LHKOABOCPDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly List<SkinnedShapeRenderer>[] HNADENCONBF;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int LGOOMGCBDHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7F3230", Offset = "0x7F1E30", VA = "0x1807F3230", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7F33F0", Offset = "0x7F1FF0", VA = "0x1807F33F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int EFMDAIFBNCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8436A0", Offset = "0x8422A0", VA = "0x1808436A0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xA35F40", Offset = "0xA34B40", VA = "0x180A35F40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public float ELGEACOKBIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9A1940", Offset = "0x9A0540", VA = "0x1809A1940", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9A1E40", Offset = "0x9A0A40", VA = "0x1809A1E40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public float BHDEKKKNCLL
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x98E640", Offset = "0x98D240", VA = "0x18098E640", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x98E670", Offset = "0x98D270", VA = "0x18098E670")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public List<SkinnedShapeRenderer> LAKDIELFAAH
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5FE7A80", Offset = "0x5FE6680", VA = "0x185FE7A80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public List<SkinnedShapeRenderer> PHJFLDNOHEF
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5FE7780", Offset = "0x5FE6380", VA = "0x185FE7780")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public GameObject ODFEIMILGMP
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x838FF0", Offset = "0x837BF0", VA = "0x180838FF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x88FE20", Offset = "0x88EA20", VA = "0x18088FE20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public byte CFAKIHAGNDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5FE7730", Offset = "0x5FE6330", VA = "0x185FE7730", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5FE7C90", Offset = "0x5FE6890", VA = "0x185FE7C90")]
	public DJNPCDEHLMO(List<LHKAAMMOLAK> NLCOCHFOFEF, List<LHKAAMMOLAK> GMABNMFHOBC, List<MLOGLFPJNHJ> MMMOCGAEDDF, Material IJIKACDMPFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5FE7B80", Offset = "0x5FE6780", VA = "0x185FE7B80")]
	private int PIGMFMKOFNH(List<LHKAAMMOLAK> LPHCKCIFKKH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5FE77C0", Offset = "0x5FE63C0", VA = "0x185FE77C0")]
	private void DAJKCCPDAPB(int LKHEAPMCOFA, bool JACPCCGHLHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5FE7AE0", Offset = "0x5FE66E0", VA = "0x185FE7AE0")]
	public void PCFJLFJEMDG(Vector3 JCLAAMDIJKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5FE7910", Offset = "0x5FE6510", VA = "0x185FE7910", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5FE7A40", Offset = "0x5FE6640", VA = "0x185FE7A40")]
	public void HHAOONHFNFM(Transform PNIEJGHJADA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
internal class OPCBBMMPEAE : JCAKCJAPNMN
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	private struct FPIOLJLFEIB : FIGLIEJIIFD, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private MOIGNMENBCE BJKOLELNNLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private JobHandle KHHIMFIIKFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private APJCKIKOKLF MCMHLAPNIFP;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x5FE8E90", Offset = "0x5FE7A90", VA = "0x185FE8E90")]
		public FPIOLJLFEIB(MOIGNMENBCE BJKOLELNNLB, JobHandle KHHIMFIIKFD, APJCKIKOKLF MCMHLAPNIFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3D14260", Offset = "0x3D12E60", VA = "0x183D14260")]
		public bool MMKBNABBBLH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5FE8E60", Offset = "0x5FE7A60", VA = "0x185FE8E60", Slot = "4")]
		public MOIGNMENBCE KOGMCNBOFCI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x5FE8E10", Offset = "0x5FE7A10", VA = "0x185FE8E10", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public readonly BHCMHKPEBIK PFNMBPHLPKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private int[] ENPFKHMJGDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private float AHFNPKPGBMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private Hash128 KDLALGHHHBN;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override PFLMCMOEDJL DKMOCDALKGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5FF2DB0", Offset = "0x5FF19B0", VA = "0x185FF2DB0", Slot = "17")]
		get
		{
			return default(PFLMCMOEDJL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private Vector3 GFBHMCOCFGI
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5FF2670", Offset = "0x5FF1270", VA = "0x185FF2670")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	protected override Hash128 CNMCPELMMBI
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5FF2C80", Offset = "0x5FF1880", VA = "0x185FF2C80", Slot = "22")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5FF3230", Offset = "0x5FF1E30", VA = "0x185FF3230")]
	public OPCBBMMPEAE(CGPIBIJBJEL PMBNHDHBMIA, BHCMHKPEBIK PHBHEFAPHDL, bool MPPDPIKPBCA = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5FF0EC0", Offset = "0x5FEFAC0", VA = "0x185FF0EC0", Slot = "16")]
	public override bool DGGJLCEDPMD(MLOGLFPJNHJ PMBNHDHBMIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5FF3180", Offset = "0x5FF1D80", VA = "0x185FF3180", Slot = "18")]
	public override int PIGMFMKOFNH(OGIGLGNLAOI MFKHINKPOED)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5FF25C0", Offset = "0x5FF11C0", VA = "0x185FF25C0", Slot = "19")]
	public override int LLGPBEAPAOA(OGIGLGNLAOI MFKHINKPOED)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5FF29D0", Offset = "0x5FF15D0", VA = "0x185FF29D0")]
	private int MPOLKANKBNC(OGIGLGNLAOI MFKHINKPOED)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5FF1B40", Offset = "0x5FF0740", VA = "0x185FF1B40", Slot = "20")]
	public override void FDBHJOEAGLN(OGIGLGNLAOI MFKHINKPOED, KFLBACAHLKD JPNIJBMMAEI, int FGLENPDGBPO = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5FF24F0", Offset = "0x5FF10F0", VA = "0x185FF24F0", Slot = "21")]
	public override MLOGLFPJNHJ KDDJEDGHFKH()
	{
		return default(MLOGLFPJNHJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5FF22D0", Offset = "0x5FF0ED0", VA = "0x185FF22D0", Slot = "23")]
	public override IDEKBKDIJGL JPLDNOGCCBD()
	{
		return default(IDEKBKDIJGL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5FF1320", Offset = "0x5FEFF20", VA = "0x185FF1320", Slot = "24")]
	public override FIGLIEJIIFD FBGCLKILDAK(OGIGLGNLAOI MFKHINKPOED, JobHandle KHHIMFIIKFD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class CGPIBIJBJEL : PLBEAOBPKHC, AMAMOGGOAAL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class ECDMMLHMMIM : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private Renderer <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public CGPIBIJBJEL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private List<ClusterMeshRenderer>.Enumerator <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private ClusterMeshRenderer <c>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private IEnumerator<Renderer> <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private Renderer <r>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private IEnumerator<MeshRenderer> <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private MeshRenderer <b>5__6;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x7F5DB0", Offset = "0x7F49B0", VA = "0x1807F5DB0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x7F5DB0", Offset = "0x7F49B0", VA = "0x1807F5DB0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xC9F550", Offset = "0xC9E150", VA = "0x180C9F550")]
		[DebuggerHidden]
		public ECDMMLHMMIM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x5FE86F0", Offset = "0x5FE72F0", VA = "0x185FE86F0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x5FE80A0", Offset = "0x5FE6CA0", VA = "0x185FE80A0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x5FE8050", Offset = "0x5FE6C50", VA = "0x185FE8050")]
		private void EHFOANOMIIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x5FE8570", Offset = "0x5FE7170", VA = "0x185FE8570")]
		private void NDPBPNJDDHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x5FE85C0", Offset = "0x5FE71C0", VA = "0x185FE85C0")]
		private void PFJGOFLDFDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x5FE86B0", Offset = "0x5FE72B0", VA = "0x185FE86B0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x5FE8610", Offset = "0x5FE7210", VA = "0x185FE8610", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x5FE8610", Offset = "0x5FE7210", VA = "0x185FE8610", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class CAPLPIHFBGK : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private Renderer <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public CGPIBIJBJEL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private IEnumerator<Renderer> <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private Renderer <r>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private List<SkinnedShapeRenderer>.Enumerator <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private SkinnedShapeRenderer <b>5__4;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x7F5DB0", Offset = "0x7F49B0", VA = "0x1807F5DB0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x7F5DB0", Offset = "0x7F49B0", VA = "0x1807F5DB0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xC9F550", Offset = "0xC9E150", VA = "0x180C9F550")]
		[DebuggerHidden]
		public CAPLPIHFBGK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x5FE5D40", Offset = "0x5FE4940", VA = "0x185FE5D40", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x5FE58E0", Offset = "0x5FE44E0", VA = "0x185FE58E0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x5FE5890", Offset = "0x5FE4490", VA = "0x185FE5890")]
		private void EHFOANOMIIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x5FE5C10", Offset = "0x5FE4810", VA = "0x185FE5C10")]
		private void NDPBPNJDDHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x5FE5D00", Offset = "0x5FE4900", VA = "0x185FE5D00", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x5FE5C60", Offset = "0x5FE4860", VA = "0x185FE5C60", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x5FE5C60", Offset = "0x5FE4860", VA = "0x185FE5C60", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly DNGJCLCDCLI BNHNDNBILAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly List<JCAKCJAPNMN> HNGPCMIMBEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private List<ClusterMeshRenderer> LKKGOJICPJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private BatchedMeshRenderer EICKOAIOPIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private bool KJDCLHANBON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly bool ODGBCGFPPPI;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IEnumerable<IBMEAOPPNNO> DHFAFNLIJGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7F5DB0", Offset = "0x7F49B0", VA = "0x1807F5DB0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int CEMBDEKPEED
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x5FE6BA0", Offset = "0x5FE57A0", VA = "0x185FE6BA0", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public MLOGLFPJNHJ KBGCOCFPMCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x5FE6AD0", Offset = "0x5FE56D0", VA = "0x185FE6AD0", Slot = "7")]
		get
		{
			return default(MLOGLFPJNHJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public List<SkinnedShapeRenderer> KJLNJDFIDBP
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x843910", Offset = "0x842510", VA = "0x180843910")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x843920", Offset = "0x842520", VA = "0x180843920")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5FE7160", Offset = "0x5FE5D60", VA = "0x185FE7160")]
	private bool JPHOFKEEEKN(JCAKCJAPNMN MBMINLKOPLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5FE7140", Offset = "0x5FE5D40", VA = "0x185FE7140")]
	private static bool JLFJDHHPALO(JCAKCJAPNMN MBMINLKOPLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5FE7560", Offset = "0x5FE6160", VA = "0x185FE7560")]
	public CGPIBIJBJEL(DNGJCLCDCLI PHBHEFAPHDL, bool MCLKPMDPNHH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5FE6950", Offset = "0x5FE5550", VA = "0x185FE6950", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5FE5E20", Offset = "0x5FE4A20", VA = "0x185FE5E20")]
	public void CAILCKFFJIK(JCAKCJAPNMN MBMINLKOPLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5FE67B0", Offset = "0x5FE53B0", VA = "0x185FE67B0")]
	public void CPPHPNNFPKL(JCAKCJAPNMN MBMINLKOPLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5FE6280", Offset = "0x5FE4E80", VA = "0x185FE6280", Slot = "4")]
	public void CEMJONFHNGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5FE6030", Offset = "0x5FE4C30", VA = "0x185FE6030")]
	public void CCMEEJNHHBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5FE72A0", Offset = "0x5FE5EA0", VA = "0x185FE72A0")]
	private void LJCILHJCKGO(List<JCAKCJAPNMN> HNGPCMIMBEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5FE7430", Offset = "0x5FE6030", VA = "0x185FE7430")]
	private static Material OALKKFBJLAM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5FE7200", Offset = "0x5FE5E00", VA = "0x185FE7200")]
	private void LJCILHJCKGO(JCAKCJAPNMN MBMINLKOPLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5FE7490", Offset = "0x5FE6090", VA = "0x185FE7490")]
	private void PMHLGKHIMJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5FE6BE0", Offset = "0x5FE57E0", VA = "0x185FE6BE0")]
	public void JHBBHOKKGIE(bool KAGOBCEBCHO, bool CKEHPGKKHMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5FE6720", Offset = "0x5FE5320", VA = "0x185FE6720")]
	protected void CFPECMFDENF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5FE7190", Offset = "0x5FE5D90", VA = "0x185FE7190")]
	[IteratorStateMachine(typeof(ECDMMLHMMIM))]
	public IEnumerable<Renderer> KCELAAPDHFG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5FE68E0", Offset = "0x5FE54E0", VA = "0x185FE68E0")]
	[IteratorStateMachine(typeof(CAPLPIHFBGK))]
	public IEnumerable<Renderer> DMLGBJGPCOK()
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
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			[HideInInspector]
			public string EditorLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public Mesh[] Meshes;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public ShapeMeshConfigData[] MeshConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		[Header("Bevels")]
		public float SmallBevelSizeMeters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public float RoundedBevelSizeMeters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public float BoxAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public float WedgeAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public float PyramidAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		[Tooltip("Smaller dimensions will not exceed sqrt(bevel percent) percent")]
		public bool BevelSizeBasedOnLargestPossibleDimension;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public ComputeShader CopyBonesComputeShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public SkinnedShapeRenderer SkinnedRendererPrefab;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x5FF4530", Offset = "0x5FF3130", VA = "0x185FF4530")]
		public ShapeRendererConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[DefaultMember("Item")]
public class PALOEJCHOAN : MFAPMCMFMOM, IDisposable, LPEOPNPNMLE
{
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static readonly MFFHLJHLBIG HGFFDKCANPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly JKCGGPMKPAM<KEDHEOJCMED, CGPIBIJBJEL> LIECKGJDKOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly JKCGGPMKPAM<ELFHHNBICDJ, JCAKCJAPNMN> HNGPCMIMBEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly JKCGGPMKPAM<CMKAKNMPFLJ, OCHICALHIDA> IGMMHLLAMFO;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public CGPIBIJBJEL OILDPKEFAJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x5FF36E0", Offset = "0x5FF22E0", VA = "0x185FF36E0", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public JCAKCJAPNMN OILDPKEFAJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x5FF3680", Offset = "0x5FF2280", VA = "0x185FF3680", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public OCHICALHIDA OILDPKEFAJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x5FF3620", Offset = "0x5FF2220", VA = "0x185FF3620", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public bool EJMCPDCOIFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x95ED60", Offset = "0x95D960", VA = "0x18095ED60", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x927C10", Offset = "0x926810", VA = "0x180927C10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5FF4150", Offset = "0x5FF2D50", VA = "0x185FF4150")]
	public PALOEJCHOAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5FF3480", Offset = "0x5FF2080", VA = "0x185FF3480", Slot = "21")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5FF3510", Offset = "0x5FF2110", VA = "0x185FF3510", Slot = "4")]
	public KEDHEOJCMED ELKLHAMMJDB(DNGJCLCDCLI PHBHEFAPHDL)
	{
		return default(KEDHEOJCMED);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5FF3510", Offset = "0x5FF2110", VA = "0x185FF3510", Slot = "5")]
	public KEDHEOJCMED ELKLHAMMJDB(DNGJCLCDCLI PHBHEFAPHDL, bool MCLKPMDPNHH)
	{
		return default(KEDHEOJCMED);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5FF4060", Offset = "0x5FF2C60", VA = "0x185FF4060", Slot = "6")]
	public void PALAJGEGMBL(KEDHEOJCMED PMBNHDHBMIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5FF3900", Offset = "0x5FF2500", VA = "0x185FF3900", Slot = "7")]
	public void HCHGKENDMIH(KEDHEOJCMED PMBNHDHBMIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5FF3740", Offset = "0x5FF2340", VA = "0x185FF3740", Slot = "8")]
	public ELFHHNBICDJ GKLFNBKMJLN(KEDHEOJCMED PMBNHDHBMIA, BHCMHKPEBIK PHBHEFAPHDL)
	{
		return default(ELFHHNBICDJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5FF32E0", Offset = "0x5FF1EE0", VA = "0x185FF32E0", Slot = "9")]
	public ELFHHNBICDJ ABGJEAGDPNH(KEDHEOJCMED PMBNHDHBMIA, AKEPPGNBIKJ PHBHEFAPHDL)
	{
		return default(ELFHHNBICDJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5FF3870", Offset = "0x5FF2470", VA = "0x185FF3870", Slot = "11")]
	public void GOIJOIBGOLJ(ELFHHNBICDJ MBMINLKOPLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x5FF4000", Offset = "0x5FF2C00", VA = "0x185FF4000", Slot = "10")]
	public void NFMCMHBDPAB(ELFHHNBICDJ MBMINLKOPLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5FF3F90", Offset = "0x5FF2B90", VA = "0x185FF3F90", Slot = "20")]
	public IEnumerable<Renderer> MFOPHOEELHB(KEDHEOJCMED PMBNHDHBMIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5FF3F10", Offset = "0x5FF2B10", VA = "0x185FF3F10", Slot = "12")]
	public CMKAKNMPFLJ LNAIPJHODMF(FBHOACDOOMO PHBHEFAPHDL)
	{
		return default(CMKAKNMPFLJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x5FF3EA0", Offset = "0x5FF2AA0", VA = "0x185FF3EA0", Slot = "14")]
	public void LJLMFGJLFMB(CMKAKNMPFLJ FAEDFCAKBGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5FF3420", Offset = "0x5FF2020", VA = "0x185FF3420", Slot = "16")]
	public Task CLEMKFNPGKN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5FF3980", Offset = "0x5FF2580", VA = "0x185FF3980", Slot = "17")]
	public Task HMNMIJCBGAE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5FF3E40", Offset = "0x5FF2A40", VA = "0x185FF3E40", Slot = "18")]
	public Task LCGCOJCCPOO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x2984210", Offset = "0x2982E10", VA = "0x182984210", Slot = "19")]
	public void KIJHGJPIFLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5FF3DE0", Offset = "0x5FF29E0", VA = "0x185FF3DE0", Slot = "13")]
	public void IIEFJPGCPEM(CMKAKNMPFLJ FAEDFCAKBGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5FF39E0", Offset = "0x5FF25E0", VA = "0x185FF39E0", Slot = "25")]
	public ABNLLEGGBLC IBBCAKMIAEA(MLOGLFPJNHJ GIKHMDFMMPA, IEnumerable<ELFHHNBICDJ> HNGPCMIMBEG, int NAJLEPELBGL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface OCDMIMHKKFF
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EGIDNMMFKMJ(COJBHKILGJI FIJCKHKKDCC, Renderer HNDABHJLKOB, int KCOHAGBFDKC);

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EHPAMCKFOON(Renderer HNDABHJLKOB, NOEKBONKFIJ CPFFFMGLAJK, Vector3 LEFBDNKEACA, Vector3 MOGIINDOPIF, Vector3 HCODGFDNEBK, float JINCPBNOHDM, float HHLKDKLECBK, float NKNKLIGEGPL = -1f, [Optional] Color? OPOEPBAFNOG, [Optional] IReadOnlyList<Camera> CLBGBCOIIAG);

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PFJJENMELCD(Renderer HNDABHJLKOB, int KCOHAGBFDKC);

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int HLLLCKLJNKE();

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EBGNOPKFKPJ(int LCLDPPLNJGE, IJMHEDAFOOI FIJCKHKKDCC, Renderer HNDABHJLKOB, int KCOHAGBFDKC);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class JKPNMCGPONA : JNACKMOFADO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private class IALNGEJAMCF : BOAPEJOJDAD<int>
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x5FEAB00", Offset = "0x5FE9700", VA = "0x185FEAB00")]
		public IALNGEJAMCF(string BPOKAAOBIOI)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly OCDMIMHKKFF POLHPAMNOLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly LPEOPNPNMLE GLHCHJGKEGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private MeshRenderer GKPAGCJKABF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private IALNGEJAMCF JDCADMLJAFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private bool EHNAOCEAHKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private MeshRenderer AMNOJDCHFBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private IALNGEJAMCF MOLNGPKMCFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private bool PNCBANFHJAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private MeshRenderer NNEFKELGMMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private IALNGEJAMCF LIBEIACNNFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private bool FNDAICJNELC;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5FEE0C0", Offset = "0x5FECCC0", VA = "0x185FEE0C0")]
	public JKPNMCGPONA(OCDMIMHKKFF MGCHHMKAMOF, LPEOPNPNMLE GLHCHJGKEGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x5FEBE70", Offset = "0x5FEAA70", VA = "0x185FEBE70", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x5FECD30", Offset = "0x5FEB930", VA = "0x185FECD30")]
	private void KLEIJMJJIOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x5FEC040", Offset = "0x5FEAC40", VA = "0x185FEC040", Slot = "4")]
	public void EBOHCNDCLJL(KEDHEOJCMED PMBNHDHBMIA, IJMHEDAFOOI ADFOOOIPFKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x5FEC240", Offset = "0x5FEAE40", VA = "0x185FEC240", Slot = "5")]
	public void EBOHCNDCLJL(ELFHHNBICDJ MBMINLKOPLO, IJMHEDAFOOI ADFOOOIPFKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x5FEDE70", Offset = "0x5FECA70", VA = "0x185FEDE70", Slot = "6")]
	public void NBMHJJPHPPP(ELFHHNBICDJ MBMINLKOPLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x5FEDFA0", Offset = "0x5FECBA0", VA = "0x185FEDFA0", Slot = "7")]
	public void PKPLKNIPHCJ(ELFHHNBICDJ MBMINLKOPLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x5FEC530", Offset = "0x5FEB130", VA = "0x185FEC530", Slot = "21")]
	public void INABOOPGAAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x157A2D0", Offset = "0x1578ED0", VA = "0x18157A2D0", Slot = "8")]
	public void CDOLPFGLKJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5FECF80", Offset = "0x5FEBB80", VA = "0x185FECF80", Slot = "9")]
	public void KPLALFPPOEG(IJMHEDAFOOI ADFOOOIPFKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5FED520", Offset = "0x5FEC120", VA = "0x185FED520", Slot = "10")]
	public void LOPHOEGFNKK(KEDHEOJCMED PMBNHDHBMIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x5FED1D0", Offset = "0x5FEBDD0", VA = "0x185FED1D0", Slot = "11")]
	public void LOPHOEGFNKK(ELFHHNBICDJ MBMINLKOPLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x5FEC920", Offset = "0x5FEB520", VA = "0x185FEC920", Slot = "12")]
	public void JMPIKOBLEFG(KEDHEOJCMED PMBNHDHBMIA, COJBHKILGJI FIJCKHKKDCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x5FEC570", Offset = "0x5FEB170", VA = "0x185FEC570", Slot = "13")]
	public void JMPIKOBLEFG(ELFHHNBICDJ MBMINLKOPLO, COJBHKILGJI FIJCKHKKDCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x5FED0F0", Offset = "0x5FEBCF0", VA = "0x185FED0F0", Slot = "22")]
	public void LDJKEPEDLHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x5FED130", Offset = "0x5FEBD30", VA = "0x185FED130", Slot = "14")]
	public void LMDAADLFJKK(ELFHHNBICDJ MBMINLKOPLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x5FEBDE0", Offset = "0x5FEA9E0", VA = "0x185FEBDE0", Slot = "15")]
	public void DIJBFJKOKNH(ELFHHNBICDJ MBMINLKOPLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x1430D20", Offset = "0x142F920", VA = "0x181430D20", Slot = "16")]
	public void AECJMHMEDCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x5FEBCA0", Offset = "0x5FEA8A0", VA = "0x185FEBCA0", Slot = "17")]
	public void BFKDEANBBFD(COJBHKILGJI FIJCKHKKDCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x5FECAE0", Offset = "0x5FEB6E0", VA = "0x185FECAE0")]
	private void KIEDMLCDAHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x5FEC760", Offset = "0x5FEB360", VA = "0x185FEC760")]
	public void JMPIKOBLEFG(ELFHHNBICDJ MBMINLKOPLO, COJBHKILGJI FIJCKHKKDCC, bool GNEKPFMEPJN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x5FEC460", Offset = "0x5FEB060", VA = "0x185FEC460")]
	private void EGIDNMMFKMJ(COJBHKILGJI FIJCKHKKDCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x5FEDAF0", Offset = "0x5FEC6F0", VA = "0x185FEDAF0", Slot = "18")]
	public void MPBDINPBFLA(KEDHEOJCMED PMBNHDHBMIA, Vector3 LEFBDNKEACA, Vector3 MOGIINDOPIF, Vector3 HCODGFDNEBK, float JINCPBNOHDM, float HHLKDKLECBK, IReadOnlyList<Camera> HCHGJGFNJHN, NOEKBONKFIJ CPFFFMGLAJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x5FED6D0", Offset = "0x5FEC2D0", VA = "0x185FED6D0", Slot = "19")]
	public void MPBDINPBFLA(CMKAKNMPFLJ FAEDFCAKBGJ, Vector3 LEFBDNKEACA, Vector3 MOGIINDOPIF, Vector3 HCODGFDNEBK, float JINCPBNOHDM, float HHLKDKLECBK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class IMBCNBJGAFE
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class EIJABAMHHNC : IEnumerable<GAPMGKACAGA>, IEnumerable, IEnumerator<GAPMGKACAGA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private GAPMGKACAGA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private int <p>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private int <l>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		private GAPMGKACAGA System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.PrimitiveShapeMeshData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x7F5DB0", Offset = "0x7F49B0", VA = "0x1807F5DB0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x7F5DB0", Offset = "0x7F49B0", VA = "0x1807F5DB0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0xC9F550", Offset = "0xC9E150", VA = "0x180C9F550")]
		[DebuggerHidden]
		public EIJABAMHHNC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x5FE87F0", Offset = "0x5FE73F0", VA = "0x185FE87F0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x5FE8960", Offset = "0x5FE7560", VA = "0x185FE8960", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x5FE88D0", Offset = "0x5FE74D0", VA = "0x185FE88D0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<GAPMGKACAGA> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.PrimitiveShapeMeshData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x5FE88D0", Offset = "0x5FE74D0", VA = "0x185FE88D0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public const int GMKHFFLGHBI = 3;

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private static GAPMGKACAGA[][] PPIFJGPGIFC;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private static PMBGFHHLLEO FBKCKBKHJNF;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public static ShapeRendererConfig KFGIMJIKEJD;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public static ComputeShader BGBKLPBEJDM
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x5FEB970", Offset = "0x5FEA570", VA = "0x185FEB970")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public static SkinnedShapeRenderer MNGGPPHDPLB
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x5FEB270", Offset = "0x5FE9E70", VA = "0x185FEB270")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x5FEB8A0", Offset = "0x5FEA4A0", VA = "0x185FEB8A0")]
	public static Mesh PAPPIDJLBPF(IBDNLIPCINH ACHIOCIDHJO, int MFKHINKPOED = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x5FEB2E0", Offset = "0x5FE9EE0", VA = "0x185FEB2E0")]
	public static int JCKAGFDIDBJ(IBDNLIPCINH ACHIOCIDHJO, int MFKHINKPOED)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x5FEB520", Offset = "0x5FEA120", VA = "0x185FEB520")]
	public static PMBGFHHLLEO MFOLFNBABDF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x5FEB4C0", Offset = "0x5FEA0C0", VA = "0x185FEB4C0")]
	[IteratorStateMachine(typeof(EIJABAMHHNC))]
	private static IEnumerable<GAPMGKACAGA> MALEPKCJENO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x5FEAF10", Offset = "0x5FE9B10", VA = "0x185FEAF10")]
	public static GAPMGKACAGA FHDANIOJBPD(IBDNLIPCINH ACHIOCIDHJO, int MFKHINKPOED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x5FEB4A0", Offset = "0x5FEA0A0", VA = "0x185FEB4A0")]
	public static bool LOJOIIAPCOE(this IBDNLIPCINH ACHIOCIDHJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x5FEB2F0", Offset = "0x5FE9EF0", VA = "0x185FEB2F0")]
	public static void KHLJDMKCLJJ(IBDNLIPCINH ACHIOCIDHJO, float3 DNKLKODKFKG, out HMLACCMOANJ AOMPMJILGLN, out float3 EHIOBOBOOEM, out float CPCAGNCDFFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x5FEAB50", Offset = "0x5FE9750", VA = "0x185FEAB50")]
	public static void BAKCJDPFCPE(Vector3 DNKLKODKFKG, IBDNLIPCINH ACHIOCIDHJO, out Vector3 EHIOBOBOOEM, out float CPCAGNCDFFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x5FEB960", Offset = "0x5FEA560", VA = "0x185FEB960")]
	[AGOCEKPENPF(ANODGEDDMCH.ExitingPlayMode, 0)]
	private static void PLAHBKALEGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x5FEB680", Offset = "0x5FEA280", VA = "0x185FEB680")]
	[AGOCEKPENPF(ANODGEDDMCH.ExitingPlayMode, 0)]
	private static void MJIBCIMAMOM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public abstract class JCAKCJAPNMN : FODGCJMIAJO, IBMEAOPPNNO, EGOMHCLAMIJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public readonly CGPIBIJBJEL ODFEIMILGMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	protected Bounds LKMKMMIKCNH;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public Bounds IKLCIFEAHOE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x19164C0", Offset = "0x19150C0", VA = "0x1819164C0", Slot = "4")]
		get
		{
			return default(Bounds);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public virtual PFLMCMOEDJL DKMOCDALKGK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x5FEBC10", Offset = "0x5FEA810", VA = "0x185FEBC10", Slot = "17")]
		get
		{
			return default(PFLMCMOEDJL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public bool ODGBCGFPPPI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0xC214A0", Offset = "0xC200A0", VA = "0x180C214A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0xC21520", Offset = "0xC20120", VA = "0x180C21520")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	protected abstract Hash128 CNMCPELMMBI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int MOEPELHGHCA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x8493B0", Offset = "0x847FB0", VA = "0x1808493B0", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public ELHACHOPMGA OGMGCEBOGLD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x843910", Offset = "0x842510", VA = "0x180843910")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x843920", Offset = "0x842520", VA = "0x180843920")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public bool NPCCINLAOAM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x8DCCB0", Offset = "0x8DB8B0", VA = "0x1808DCCB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x85C810", Offset = "0x85B410", VA = "0x18085C810")]
	protected JCAKCJAPNMN(CGPIBIJBJEL PMBNHDHBMIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x5FEBA80", Offset = "0x5FEA680", VA = "0x185FEBA80", Slot = "15")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7F3460", Offset = "0x7F2060", VA = "0x1807F3460", Slot = "16")]
	public virtual bool DGGJLCEDPMD(MLOGLFPJNHJ PMBNHDHBMIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "18")]
	public abstract int PIGMFMKOFNH(OGIGLGNLAOI MFKHINKPOED);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "19")]
	public abstract int LLGPBEAPAOA(OGIGLGNLAOI MFKHINKPOED);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "20")]
	public abstract void FDBHJOEAGLN(OGIGLGNLAOI MFKHINKPOED, KFLBACAHLKD JPNIJBMMAEI, int FGLENPDGBPO = -1);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "21")]
	public abstract MLOGLFPJNHJ KDDJEDGHFKH();

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x5FEBBB0", Offset = "0x5FEA7B0", VA = "0x185FEBBB0", Slot = "11")]
	public Hash128 FHBGOKGMICC(int MFKHINKPOED)
	{
		return default(Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "23")]
	public abstract IDEKBKDIJGL JPLDNOGCCBD();

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "24")]
	public abstract FIGLIEJIIFD FBGCLKILDAK(OGIGLGNLAOI MFKHINKPOED, JobHandle KHHIMFIIKFD);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x5FEBBE0", Offset = "0x5FEA7E0", VA = "0x185FEBBE0", Slot = "10")]
	public FIGLIEJIIFD IBBCAKMIAEA(int MFKHINKPOED)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class GOIJJKFGAOK : JCAKCJAPNMN
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	private struct DDDCFKEJMBE : FIGLIEJIIFD, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private MOIGNMENBCE BJKOLELNNLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private JobHandle KHHIMFIIKFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private HKLFDJPGKNH MCMHLAPNIFP;

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x5FE76D0", Offset = "0x5FE62D0", VA = "0x185FE76D0")]
		public DDDCFKEJMBE(MOIGNMENBCE BJKOLELNNLB, JobHandle KHHIMFIIKFD, HKLFDJPGKNH MCMHLAPNIFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x3D14260", Offset = "0x3D12E60", VA = "0x183D14260")]
		public bool MMKBNABBBLH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x5FE76A0", Offset = "0x5FE62A0", VA = "0x185FE76A0", Slot = "4")]
		public MOIGNMENBCE KOGMCNBOFCI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x5FE7650", Offset = "0x5FE6250", VA = "0x185FE7650", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private readonly AKEPPGNBIKJ KEHMMJMCJOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private float AHFNPKPGBMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private Hash128 KDLALGHHHBN;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	protected override Hash128 CNMCPELMMBI
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x5FEA360", Offset = "0x5FE8F60", VA = "0x185FEA360", Slot = "22")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x5FEA680", Offset = "0x5FE9280", VA = "0x185FEA680")]
	public GOIJJKFGAOK(CGPIBIJBJEL PMBNHDHBMIA, AKEPPGNBIKJ PHBHEFAPHDL, bool MCLKPMDPNHH = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x7F3460", Offset = "0x7F2060", VA = "0x1807F3460", Slot = "16")]
	public override bool DGGJLCEDPMD(MLOGLFPJNHJ PMBNHDHBMIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x5FEA490", Offset = "0x5FE9090", VA = "0x185FEA490", Slot = "18")]
	public override int PIGMFMKOFNH(OGIGLGNLAOI MFKHINKPOED)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x5FEA170", Offset = "0x5FE8D70", VA = "0x185FEA170", Slot = "19")]
	public override int LLGPBEAPAOA(OGIGLGNLAOI MFKHINKPOED)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x5FE97A0", Offset = "0x5FE83A0", VA = "0x185FE97A0", Slot = "20")]
	public override void FDBHJOEAGLN(OGIGLGNLAOI MFKHINKPOED, KFLBACAHLKD JPNIJBMMAEI, int FGLENPDGBPO = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x5FEA0A0", Offset = "0x5FE8CA0", VA = "0x185FEA0A0", Slot = "21")]
	public override MLOGLFPJNHJ KDDJEDGHFKH()
	{
		return default(MLOGLFPJNHJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x5FE9E80", Offset = "0x5FE8A80", VA = "0x185FE9E80", Slot = "23")]
	public override IDEKBKDIJGL JPLDNOGCCBD()
	{
		return default(IDEKBKDIJGL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x5FE8EE0", Offset = "0x5FE7AE0", VA = "0x185FE8EE0", Slot = "24")]
	public override FIGLIEJIIFD FBGCLKILDAK(OGIGLGNLAOI MFKHINKPOED, JobHandle KHHIMFIIKFD)
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
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private MaterialPropertyBlock KBGKGJFHAKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private LHKAAMMOLAK BJKOLELNNLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private List<MLOGLFPJNHJ> MMMOCGAEDDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private RenderTexture OJIPJMLKFLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private ComputeBuffer PBFPNDKHIIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private ComputeShader GODODFKPMHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private Matrix4x4[] EEELHLFIMOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private int BNKEOLMCIGL;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public MeshRenderer BNHMLIDHNGA
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x7F5DB0", Offset = "0x7F49B0", VA = "0x1807F5DB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x7F6030", Offset = "0x7F4C30", VA = "0x1807F6030")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public int JAPAIBMOOBD
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x5FF51F0", Offset = "0x5FF3DF0", VA = "0x185FF51F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x5FF4560", Offset = "0x5FF3160", VA = "0x185FF4560")]
		public static List<SkinnedShapeRenderer> Create(GameObject PMBNHDHBMIA, List<LHKAAMMOLAK> LPHCKCIFKKH, List<MLOGLFPJNHJ> MMMOCGAEDDF, Material IJIKACDMPFI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x5FF49E0", Offset = "0x5FF35E0", VA = "0x185FF49E0")]
		public void Init(LHKAAMMOLAK BJKOLELNNLB, List<MLOGLFPJNHJ> MMMOCGAEDDF, Material IJIKACDMPFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x5FF5140", Offset = "0x5FF3D40", VA = "0x185FF5140")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x5FF5090", Offset = "0x5FF3C90", VA = "0x185FF5090")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x5FF5050", Offset = "0x5FF3C50", VA = "0x185FF5050")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x5FF47B0", Offset = "0x5FF33B0", VA = "0x185FF47B0")]
		private void DOOFBBDPBAP(ScriptableRenderContext JFDMKPDIBDL, Camera[] EFPGFHCBMKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x5FF4E90", Offset = "0x5FF3A90", VA = "0x185FF4E90")]
		private void LKLOIPFCPAN(CommandBuffer ONOCOAPIMAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x87DF50", Offset = "0x87CB50", VA = "0x18087DF50")]
		public SkinnedShapeRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface COMIMHJPBAI
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	bool DDNEPMLDIMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Material FBGINAJDLKN();

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Material OALKKFBJLAM();

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Material LCFMGMFMEFA();

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int HKCCFIFDDMB(MFJEBBFONBC PCPDIHBJMFG);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int JJFEDHOIBHD(BIFNIOGHPEJ KKDMOBFFDAE);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LIDBDOENDLA(GameObject HHNPCHNMLMA);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void JNONDKJOJMI(GameObject HHNPCHNMLMA, bool NALOCHFLGNA);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class EPGMHIFKCPB
{
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static COMIMHJPBAI NHIFGJKHMEC;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public static bool DDNEPMLDIMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x5FE89A0", Offset = "0x5FE75A0", VA = "0x185FE89A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x5FE8D60", Offset = "0x5FE7960", VA = "0x185FE8D60")]
	public static void LPLDBEPABHL(COMIMHJPBAI BOAIEEHIGLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x5FE8A00", Offset = "0x5FE7600", VA = "0x185FE8A00")]
	public static Material FBGINAJDLKN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x5FE8DB0", Offset = "0x5FE79B0", VA = "0x185FE8DB0")]
	public static Material OALKKFBJLAM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x5FE8C30", Offset = "0x5FE7830", VA = "0x185FE8C30")]
	public static Material LCFMGMFMEFA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x5FE8A60", Offset = "0x5FE7660", VA = "0x185FE8A60")]
	public static int HKCCFIFDDMB(MFJEBBFONBC PCPDIHBJMFG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x5FE8AD0", Offset = "0x5FE76D0", VA = "0x185FE8AD0")]
	public static int JJFEDHOIBHD(BIFNIOGHPEJ KKDMOBFFDAE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x5FE8C90", Offset = "0x5FE7890", VA = "0x185FE8C90")]
	public static void LIDBDOENDLA(GameObject HHNPCHNMLMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x5FE8B40", Offset = "0x5FE7740", VA = "0x185FE8B40")]
	public static void JNONDKJOJMI(GameObject HHNPCHNMLMA, bool NALOCHFLGNA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[DefaultMember("Item")]
public class BOMLMLONGAL : MFAPMCMFMOM, IDisposable, LPEOPNPNMLE
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class OOFHNNGDHKJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public BOMLMLONGAL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public OOFHNNGDHKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x5FF0A00", Offset = "0x5FEF600", VA = "0x185FF0A00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly JKCGGPMKPAM<KEDHEOJCMED, CGPIBIJBJEL> LIECKGJDKOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly JKCGGPMKPAM<ELFHHNBICDJ, JCAKCJAPNMN> HNGPCMIMBEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly JKCGGPMKPAM<CMKAKNMPFLJ, OCHICALHIDA> IGMMHLLAMFO;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public CGPIBIJBJEL OILDPKEFAJI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x5FE3460", Offset = "0x5FE2060", VA = "0x185FE3460", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public JCAKCJAPNMN OILDPKEFAJI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x5FE3400", Offset = "0x5FE2000", VA = "0x185FE3400", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public OCHICALHIDA OILDPKEFAJI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x5FE34C0", Offset = "0x5FE20C0", VA = "0x185FE34C0", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool EJMCPDCOIFE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x95ED60", Offset = "0x95D960", VA = "0x18095ED60", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x927C10", Offset = "0x926810", VA = "0x180927C10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x5FE51B0", Offset = "0x5FE3DB0", VA = "0x185FE51B0")]
	public BOMLMLONGAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x5FE2FB0", Offset = "0x5FE1BB0", VA = "0x185FE2FB0", Slot = "21")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x5FE3150", Offset = "0x5FE1D50", VA = "0x185FE3150", Slot = "4")]
	public KEDHEOJCMED ELKLHAMMJDB(DNGJCLCDCLI PHBHEFAPHDL)
	{
		return default(KEDHEOJCMED);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x5FE3160", Offset = "0x5FE1D60", VA = "0x185FE3160", Slot = "5")]
	public KEDHEOJCMED ELKLHAMMJDB(DNGJCLCDCLI PHBHEFAPHDL, bool MCLKPMDPNHH)
	{
		return default(KEDHEOJCMED);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x5FE4F30", Offset = "0x5FE3B30", VA = "0x185FE4F30", Slot = "6")]
	public void PALAJGEGMBL(KEDHEOJCMED PMBNHDHBMIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x5FE3E20", Offset = "0x5FE2A20", VA = "0x185FE3E20", Slot = "7")]
	public void HCHGKENDMIH(KEDHEOJCMED PMBNHDHBMIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x5FE3520", Offset = "0x5FE2120", VA = "0x185FE3520", Slot = "8")]
	public ELFHHNBICDJ GKLFNBKMJLN(KEDHEOJCMED PMBNHDHBMIA, BHCMHKPEBIK PHBHEFAPHDL)
	{
		return default(ELFHHNBICDJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x5FE2940", Offset = "0x5FE1540", VA = "0x185FE2940", Slot = "9")]
	public ELFHHNBICDJ ABGJEAGDPNH(KEDHEOJCMED PMBNHDHBMIA, AKEPPGNBIKJ PHBHEFAPHDL)
	{
		return default(ELFHHNBICDJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x5FE3A20", Offset = "0x5FE2620", VA = "0x185FE3A20", Slot = "11")]
	public void GOIJOIBGOLJ(ELFHHNBICDJ MBMINLKOPLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x5FE4CB0", Offset = "0x5FE38B0", VA = "0x185FE4CB0", Slot = "10")]
	public void NFMCMHBDPAB(ELFHHNBICDJ MBMINLKOPLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x5FE4C40", Offset = "0x5FE3840", VA = "0x185FE4C40", Slot = "20")]
	public IEnumerable<Renderer> MFOPHOEELHB(KEDHEOJCMED PMBNHDHBMIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x5FE4BC0", Offset = "0x5FE37C0", VA = "0x185FE4BC0", Slot = "12")]
	public CMKAKNMPFLJ LNAIPJHODMF(FBHOACDOOMO PHBHEFAPHDL)
	{
		return default(CMKAKNMPFLJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x5FE4B50", Offset = "0x5FE3750", VA = "0x185FE4B50", Slot = "14")]
	public void LJLMFGJLFMB(CMKAKNMPFLJ FAEDFCAKBGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x5FE2E40", Offset = "0x5FE1A40", VA = "0x185FE2E40", Slot = "16")]
	public Task CLEMKFNPGKN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x5FE41B0", Offset = "0x5FE2DB0", VA = "0x185FE41B0", Slot = "17")]
	public Task HMNMIJCBGAE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x5FE4A30", Offset = "0x5FE3630", VA = "0x185FE4A30", Slot = "18")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(OOFHNNGDHKJ))]
	public Task LCGCOJCCPOO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x5FE49A0", Offset = "0x5FE35A0", VA = "0x185FE49A0", Slot = "19")]
	public void KIJHGJPIFLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x5FE4940", Offset = "0x5FE3540", VA = "0x185FE4940", Slot = "13")]
	public void IIEFJPGCPEM(CMKAKNMPFLJ FAEDFCAKBGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x5FE4310", Offset = "0x5FE2F10", VA = "0x185FE4310", Slot = "25")]
	public ABNLLEGGBLC IBBCAKMIAEA(MLOGLFPJNHJ GIKHMDFMMPA, IEnumerable<ELFHHNBICDJ> HNGPCMIMBEG, int NAJLEPELBGL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class LHKAAMMOLAK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	private struct AJEDEHFJDDK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public KFLBACAHLKD ABHOHLIPLNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public MLOGLFPJNHJ LMOMPICLACK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public int GDMBLDLDFCG;
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class FIJBKJGCJLD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public LHKAAMMOLAK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public int numVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public int numIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public OGIGLGNLAOI lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public List<AJEDEHFJDDK> boneMeshInfos;

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public FIJBKJGCJLD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class BPBFAJPNHLB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public MOIGNMENBCE combinedMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public FIJBKJGCJLD CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public BPBFAJPNHLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x5FE5670", Offset = "0x5FE4270", VA = "0x185FE5670")]
		internal JobHandle CMOMFNDMDFO()
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x5FE56E0", Offset = "0x5FE42E0", VA = "0x185FE56E0")]
		internal void HPOPKBBAEKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x5FE5720", Offset = "0x5FE4320", VA = "0x185FE5720")]
		internal void JGMGLCEADLH()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private int[] DCAEPAPLFNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private GEGBCPCIGBJ DNOCJNLLHHM;

	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private static Matrix4x4 CGGKJHMOPAN;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public Mesh CBFMJEEJION
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x839000", Offset = "0x837C00", VA = "0x180839000")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x842A50", Offset = "0x841650", VA = "0x180842A50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public int MPMABLLJLPE
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x87CCA0", Offset = "0x87B8A0", VA = "0x18087CCA0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x8841C0", Offset = "0x882DC0", VA = "0x1808841C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x5FEECC0", Offset = "0x5FED8C0", VA = "0x185FEECC0")]
	public void LKLOIPFCPAN(List<MLOGLFPJNHJ> KABDHDOKPBI, Matrix4x4[] JIMMKDGNPDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x5FEE680", Offset = "0x5FED280", VA = "0x185FEE680")]
	public static List<LHKAAMMOLAK> JLAKJAPJOGA(List<CGPIBIJBJEL> JMCDKPBIJCA, OGIGLGNLAOI MFKHINKPOED, Bounds NDJAACEKCOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x5FEE290", Offset = "0x5FECE90", VA = "0x185FEE290")]
	private JobHandle EHMMKIBGDNF(MOIGNMENBCE GOHPDNLDOCE, int APKINBBAHBB, int ONNPEHPDEML, OGIGLGNLAOI MFKHINKPOED, List<AJEDEHFJDDK> NJOJBONCPAE)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x5FEE110", Offset = "0x5FECD10", VA = "0x185FEE110")]
	private void BPKBELIDFBK(List<AJEDEHFJDDK> NJOJBONCPAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x5FEF050", Offset = "0x5FEDC50", VA = "0x185FEF050")]
	private LHKAAMMOLAK(List<AJEDEHFJDDK> NJOJBONCPAE, int APKINBBAHBB, int ONNPEHPDEML, OGIGLGNLAOI MFKHINKPOED, Bounds NDJAACEKCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x5FEE220", Offset = "0x5FECE20", VA = "0x185FEE220", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class OCHICALHIDA : PLBEAOBPKHC
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class HHLMCKEGGGO : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private Renderer <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public OCHICALHIDA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private List<SkinnedShapeRenderer>.Enumerator <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private SkinnedShapeRenderer <r>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x7F5DB0", Offset = "0x7F49B0", VA = "0x1807F5DB0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x7F5DB0", Offset = "0x7F49B0", VA = "0x1807F5DB0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0xC9F550", Offset = "0xC9E150", VA = "0x180C9F550")]
		[DebuggerHidden]
		public HHLMCKEGGGO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x5FEAA80", Offset = "0x5FE9680", VA = "0x185FEAA80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x5FEA780", Offset = "0x5FE9380", VA = "0x185FEA780", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x5FEA730", Offset = "0x5FE9330", VA = "0x185FEA730")]
		private void EHFOANOMIIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x5FEAA40", Offset = "0x5FE9640", VA = "0x185FEAA40", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x5FEA9A0", Offset = "0x5FE95A0", VA = "0x185FEA9A0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x5FEA9A0", Offset = "0x5FE95A0", VA = "0x185FEA9A0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly FBHOACDOOMO DNFLJOLDMLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly LPEOPNPNMLE GLHCHJGKEGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private DJNPCDEHLMO GGDFILCOAGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private List<LHKAAMMOLAK> ADGFKDHJHDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private List<LHKAAMMOLAK> CMHDHDHPFHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private GameObject IJKOIBELGOE;

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x5FEF480", Offset = "0x5FEE080", VA = "0x185FEF480")]
	public static OCHICALHIDA BICODEPLJOC(FBHOACDOOMO PHBHEFAPHDL, LPEOPNPNMLE GLHCHJGKEGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x5FF0900", Offset = "0x5FEF500", VA = "0x185FF0900")]
	private OCHICALHIDA(FBHOACDOOMO PHBHEFAPHDL, LPEOPNPNMLE GLHCHJGKEGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x5FF03F0", Offset = "0x5FEEFF0", VA = "0x185FF03F0")]
	public void LIEFKNGBAEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x5FF0380", Offset = "0x5FEEF80", VA = "0x185FF0380")]
	[IteratorStateMachine(typeof(HHLMCKEGGGO))]
	public IEnumerable<Renderer> KCELAAPDHFG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x5FEF830", Offset = "0x5FEE430", VA = "0x185FEF830", Slot = "4")]
	public void CEMJONFHNGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x5FF02E0", Offset = "0x5FEEEE0", VA = "0x185FF02E0")]
	private void JHMKMDJBEJC(Vector3 JCLAAMDIJKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x5FEF5F0", Offset = "0x5FEE1F0", VA = "0x185FEF5F0")]
	public void CCMEEJNHHBN()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class PFBBJKPLBFC
{
	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
	public PFBBJKPLBFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x1901CE0", Offset = "0x19008E0", VA = "0x181901CE0")]
	public static string NIMNBIGPMKB(byte[] DCFEDNINKHD, byte[] LFMKEJPAGIF)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class __BB_OBFUSCATOR_VERSION_3_10_0
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
