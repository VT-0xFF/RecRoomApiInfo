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
		[Cpp2IlInjected.Address(RVA = "0x7F0230", Offset = "0x7EEE30", VA = "0x1807F0230", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7F03F0", Offset = "0x7EEFF0", VA = "0x1807F03F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int EFMDAIFBNCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x857DE0", Offset = "0x8569E0", VA = "0x180857DE0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xA82AD0", Offset = "0xA816D0", VA = "0x180A82AD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public float ELGEACOKBIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9EE810", Offset = "0x9ED410", VA = "0x1809EE810", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9EED10", Offset = "0x9ED910", VA = "0x1809EED10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public float BHDEKKKNCLL
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9DB510", Offset = "0x9DA110", VA = "0x1809DB510", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x9DB540", Offset = "0x9DA140", VA = "0x1809DB540")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public List<SkinnedShapeRenderer> LAKDIELFAAH
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x60CBAD0", Offset = "0x60CA6D0", VA = "0x1860CBAD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public List<SkinnedShapeRenderer> PHJFLDNOHEF
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x11C08B0", Offset = "0x11BF4B0", VA = "0x1811C08B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public GameObject ODFEIMILGMP
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x84D780", Offset = "0x84C380", VA = "0x18084D780")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8A4420", Offset = "0x8A3020", VA = "0x1808A4420")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public byte CFAKIHAGNDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x60CB7C0", Offset = "0x60CA3C0", VA = "0x1860CB7C0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x60CBCE0", Offset = "0x60CA8E0", VA = "0x1860CBCE0")]
	public DJNPCDEHLMO(List<LHKAAMMOLAK> NLCOCHFOFEF, List<LHKAAMMOLAK> GMABNMFHOBC, List<MLOGLFPJNHJ> MMMOCGAEDDF, Material IJIKACDMPFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x60CBBD0", Offset = "0x60CA7D0", VA = "0x1860CBBD0")]
	private int PIGMFMKOFNH(List<LHKAAMMOLAK> LPHCKCIFKKH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x60CB810", Offset = "0x60CA410", VA = "0x1860CB810")]
	private void DAJKCCPDAPB(int LKHEAPMCOFA, bool JACPCCGHLHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x60CBB30", Offset = "0x60CA730", VA = "0x1860CBB30")]
	public void PCFJLFJEMDG(Vector3 JCLAAMDIJKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x60CB960", Offset = "0x60CA560", VA = "0x1860CB960", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x60CBA90", Offset = "0x60CA690", VA = "0x1860CBA90")]
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
		[Cpp2IlInjected.Address(RVA = "0x60CCEE0", Offset = "0x60CBAE0", VA = "0x1860CCEE0")]
		public FPIOLJLFEIB(MOIGNMENBCE BJKOLELNNLB, JobHandle KHHIMFIIKFD, APJCKIKOKLF MCMHLAPNIFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3F5C390", Offset = "0x3F5AF90", VA = "0x183F5C390")]
		public bool MMKBNABBBLH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x60CCEB0", Offset = "0x60CBAB0", VA = "0x1860CCEB0", Slot = "4")]
		public MOIGNMENBCE KOGMCNBOFCI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x60CCE60", Offset = "0x60CBA60", VA = "0x1860CCE60", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x60D6E00", Offset = "0x60D5A00", VA = "0x1860D6E00", Slot = "17")]
		get
		{
			return default(PFLMCMOEDJL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private Vector3 GFBHMCOCFGI
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x60D66C0", Offset = "0x60D52C0", VA = "0x1860D66C0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	protected override Hash128 CNMCPELMMBI
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x60D6CD0", Offset = "0x60D58D0", VA = "0x1860D6CD0", Slot = "22")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x60D7280", Offset = "0x60D5E80", VA = "0x1860D7280")]
	public OPCBBMMPEAE(CGPIBIJBJEL PMBNHDHBMIA, BHCMHKPEBIK PHBHEFAPHDL, bool MPPDPIKPBCA = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x60D4F10", Offset = "0x60D3B10", VA = "0x1860D4F10", Slot = "16")]
	public override bool DGGJLCEDPMD(MLOGLFPJNHJ PMBNHDHBMIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x60D71D0", Offset = "0x60D5DD0", VA = "0x1860D71D0", Slot = "18")]
	public override int PIGMFMKOFNH(OGIGLGNLAOI MFKHINKPOED)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x60D6610", Offset = "0x60D5210", VA = "0x1860D6610", Slot = "19")]
	public override int LLGPBEAPAOA(OGIGLGNLAOI MFKHINKPOED)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x60D6A20", Offset = "0x60D5620", VA = "0x1860D6A20")]
	private int MPOLKANKBNC(OGIGLGNLAOI MFKHINKPOED)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x60D5B90", Offset = "0x60D4790", VA = "0x1860D5B90", Slot = "20")]
	public override void FDBHJOEAGLN(OGIGLGNLAOI MFKHINKPOED, KFLBACAHLKD JPNIJBMMAEI, int FGLENPDGBPO = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x60D6540", Offset = "0x60D5140", VA = "0x1860D6540", Slot = "21")]
	public override MLOGLFPJNHJ KDDJEDGHFKH()
	{
		return default(MLOGLFPJNHJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x60D6320", Offset = "0x60D4F20", VA = "0x1860D6320", Slot = "23")]
	public override IDEKBKDIJGL JPLDNOGCCBD()
	{
		return default(IDEKBKDIJGL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x60D5370", Offset = "0x60D3F70", VA = "0x1860D5370", Slot = "24")]
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
			[Cpp2IlInjected.Address(RVA = "0x7F2DB0", Offset = "0x7F19B0", VA = "0x1807F2DB0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x7F2DB0", Offset = "0x7F19B0", VA = "0x1807F2DB0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xAF7620", Offset = "0xAF6220", VA = "0x180AF7620")]
		[DebuggerHidden]
		public ECDMMLHMMIM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x60CC740", Offset = "0x60CB340", VA = "0x1860CC740", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x60CC0F0", Offset = "0x60CACF0", VA = "0x1860CC0F0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x60CC0A0", Offset = "0x60CACA0", VA = "0x1860CC0A0")]
		private void EHFOANOMIIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x60CC5C0", Offset = "0x60CB1C0", VA = "0x1860CC5C0")]
		private void NDPBPNJDDHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x60CC610", Offset = "0x60CB210", VA = "0x1860CC610")]
		private void PFJGOFLDFDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x60CC700", Offset = "0x60CB300", VA = "0x1860CC700", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x60CC660", Offset = "0x60CB260", VA = "0x1860CC660", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x60CC660", Offset = "0x60CB260", VA = "0x1860CC660", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x7F2DB0", Offset = "0x7F19B0", VA = "0x1807F2DB0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x7F2DB0", Offset = "0x7F19B0", VA = "0x1807F2DB0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xAF7620", Offset = "0xAF6220", VA = "0x180AF7620")]
		[DebuggerHidden]
		public CAPLPIHFBGK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x60C9DD0", Offset = "0x60C89D0", VA = "0x1860C9DD0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x60C9970", Offset = "0x60C8570", VA = "0x1860C9970", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x60C9920", Offset = "0x60C8520", VA = "0x1860C9920")]
		private void EHFOANOMIIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x60C9CA0", Offset = "0x60C88A0", VA = "0x1860C9CA0")]
		private void NDPBPNJDDHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x60C9D90", Offset = "0x60C8990", VA = "0x1860C9D90", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x60C9CF0", Offset = "0x60C88F0", VA = "0x1860C9CF0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x60C9CF0", Offset = "0x60C88F0", VA = "0x1860C9CF0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7F2DB0", Offset = "0x7F19B0", VA = "0x1807F2DB0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int CEMBDEKPEED
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x60CAC30", Offset = "0x60C9830", VA = "0x1860CAC30", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public MLOGLFPJNHJ KBGCOCFPMCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x60CAB60", Offset = "0x60C9760", VA = "0x1860CAB60", Slot = "7")]
		get
		{
			return default(MLOGLFPJNHJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public List<SkinnedShapeRenderer> KJLNJDFIDBP
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x83EB00", Offset = "0x83D700", VA = "0x18083EB00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x83EB20", Offset = "0x83D720", VA = "0x18083EB20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x60CB1F0", Offset = "0x60C9DF0", VA = "0x1860CB1F0")]
	private bool JPHOFKEEEKN(JCAKCJAPNMN MBMINLKOPLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x60CB1D0", Offset = "0x60C9DD0", VA = "0x1860CB1D0")]
	private static bool JLFJDHHPALO(JCAKCJAPNMN MBMINLKOPLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x60CB5F0", Offset = "0x60CA1F0", VA = "0x1860CB5F0")]
	public CGPIBIJBJEL(DNGJCLCDCLI PHBHEFAPHDL, bool MCLKPMDPNHH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x60CA9E0", Offset = "0x60C95E0", VA = "0x1860CA9E0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x60C9EB0", Offset = "0x60C8AB0", VA = "0x1860C9EB0")]
	public void CAILCKFFJIK(JCAKCJAPNMN MBMINLKOPLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x60CA840", Offset = "0x60C9440", VA = "0x1860CA840")]
	public void CPPHPNNFPKL(JCAKCJAPNMN MBMINLKOPLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x60CA310", Offset = "0x60C8F10", VA = "0x1860CA310", Slot = "4")]
	public void CEMJONFHNGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x60CA0C0", Offset = "0x60C8CC0", VA = "0x1860CA0C0")]
	public void CCMEEJNHHBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x60CB330", Offset = "0x60C9F30", VA = "0x1860CB330")]
	private void LJCILHJCKGO(List<JCAKCJAPNMN> HNGPCMIMBEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x60CB4C0", Offset = "0x60CA0C0", VA = "0x1860CB4C0")]
	private static Material OALKKFBJLAM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x60CB290", Offset = "0x60C9E90", VA = "0x1860CB290")]
	private void LJCILHJCKGO(JCAKCJAPNMN MBMINLKOPLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x60CB520", Offset = "0x60CA120", VA = "0x1860CB520")]
	private void PMHLGKHIMJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x60CAC70", Offset = "0x60C9870", VA = "0x1860CAC70")]
	public void JHBBHOKKGIE(bool KAGOBCEBCHO, bool CKEHPGKKHMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x60CA7B0", Offset = "0x60C93B0", VA = "0x1860CA7B0")]
	protected void CFPECMFDENF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x60CB220", Offset = "0x60C9E20", VA = "0x1860CB220")]
	[IteratorStateMachine(typeof(ECDMMLHMMIM))]
	public IEnumerable<Renderer> KCELAAPDHFG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x60CA970", Offset = "0x60C9570", VA = "0x1860CA970")]
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
		[Cpp2IlInjected.Address(RVA = "0x60D8580", Offset = "0x60D7180", VA = "0x1860D8580")]
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
	private readonly global::JKCGGPMKPAM<KEDHEOJCMED, CGPIBIJBJEL> LIECKGJDKOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly global::JKCGGPMKPAM<ELFHHNBICDJ, JCAKCJAPNMN> HNGPCMIMBEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly global::JKCGGPMKPAM<CMKAKNMPFLJ, OCHICALHIDA> IGMMHLLAMFO;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public CGPIBIJBJEL OILDPKEFAJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x60D7730", Offset = "0x60D6330", VA = "0x1860D7730", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public JCAKCJAPNMN OILDPKEFAJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x60D76D0", Offset = "0x60D62D0", VA = "0x1860D76D0", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public OCHICALHIDA OILDPKEFAJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x60D7670", Offset = "0x60D6270", VA = "0x1860D7670", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public bool EJMCPDCOIFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x9ABC90", Offset = "0x9AA890", VA = "0x1809ABC90", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x974F20", Offset = "0x973B20", VA = "0x180974F20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x60D81A0", Offset = "0x60D6DA0", VA = "0x1860D81A0")]
	public PALOEJCHOAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x60D74D0", Offset = "0x60D60D0", VA = "0x1860D74D0", Slot = "21")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x60D7560", Offset = "0x60D6160", VA = "0x1860D7560", Slot = "4")]
	public KEDHEOJCMED ELKLHAMMJDB(DNGJCLCDCLI PHBHEFAPHDL)
	{
		return default(KEDHEOJCMED);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x60D7560", Offset = "0x60D6160", VA = "0x1860D7560", Slot = "5")]
	public KEDHEOJCMED ELKLHAMMJDB(DNGJCLCDCLI PHBHEFAPHDL, bool MCLKPMDPNHH)
	{
		return default(KEDHEOJCMED);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x60D80B0", Offset = "0x60D6CB0", VA = "0x1860D80B0", Slot = "6")]
	public void PALAJGEGMBL(KEDHEOJCMED PMBNHDHBMIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x60D7950", Offset = "0x60D6550", VA = "0x1860D7950", Slot = "7")]
	public void HCHGKENDMIH(KEDHEOJCMED PMBNHDHBMIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x60D7790", Offset = "0x60D6390", VA = "0x1860D7790", Slot = "8")]
	public ELFHHNBICDJ GKLFNBKMJLN(KEDHEOJCMED PMBNHDHBMIA, BHCMHKPEBIK PHBHEFAPHDL)
	{
		return default(ELFHHNBICDJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x60D7330", Offset = "0x60D5F30", VA = "0x1860D7330", Slot = "9")]
	public ELFHHNBICDJ ABGJEAGDPNH(KEDHEOJCMED PMBNHDHBMIA, AKEPPGNBIKJ PHBHEFAPHDL)
	{
		return default(ELFHHNBICDJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x60D78C0", Offset = "0x60D64C0", VA = "0x1860D78C0", Slot = "11")]
	public void GOIJOIBGOLJ(ELFHHNBICDJ MBMINLKOPLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x60D8050", Offset = "0x60D6C50", VA = "0x1860D8050", Slot = "10")]
	public void NFMCMHBDPAB(ELFHHNBICDJ MBMINLKOPLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x60D7FE0", Offset = "0x60D6BE0", VA = "0x1860D7FE0", Slot = "20")]
	public IEnumerable<Renderer> MFOPHOEELHB(KEDHEOJCMED PMBNHDHBMIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x60D7F60", Offset = "0x60D6B60", VA = "0x1860D7F60", Slot = "12")]
	public CMKAKNMPFLJ LNAIPJHODMF(FBHOACDOOMO PHBHEFAPHDL)
	{
		return default(CMKAKNMPFLJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x60D7EF0", Offset = "0x60D6AF0", VA = "0x1860D7EF0", Slot = "14")]
	public void LJLMFGJLFMB(CMKAKNMPFLJ FAEDFCAKBGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x60D7470", Offset = "0x60D6070", VA = "0x1860D7470", Slot = "16")]
	public Task CLEMKFNPGKN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x60D79D0", Offset = "0x60D65D0", VA = "0x1860D79D0", Slot = "17")]
	public Task HMNMIJCBGAE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x60D7E90", Offset = "0x60D6A90", VA = "0x1860D7E90", Slot = "18")]
	public Task LCGCOJCCPOO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x46898F0", Offset = "0x46884F0", VA = "0x1846898F0", Slot = "19")]
	public void KIJHGJPIFLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x60D7E30", Offset = "0x60D6A30", VA = "0x1860D7E30", Slot = "13")]
	public void IIEFJPGCPEM(CMKAKNMPFLJ FAEDFCAKBGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x60D7A30", Offset = "0x60D6630", VA = "0x1860D7A30", Slot = "25")]
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
	private class IALNGEJAMCF : global::BOAPEJOJDAD<int>
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x60CEB50", Offset = "0x60CD750", VA = "0x1860CEB50")]
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
	[Cpp2IlInjected.Address(RVA = "0x60D2110", Offset = "0x60D0D10", VA = "0x1860D2110")]
	public JKPNMCGPONA(OCDMIMHKKFF MGCHHMKAMOF, LPEOPNPNMLE GLHCHJGKEGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x60CFEC0", Offset = "0x60CEAC0", VA = "0x1860CFEC0", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x60D0D80", Offset = "0x60CF980", VA = "0x1860D0D80")]
	private void KLEIJMJJIOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x60D0090", Offset = "0x60CEC90", VA = "0x1860D0090", Slot = "4")]
	public void EBOHCNDCLJL(KEDHEOJCMED PMBNHDHBMIA, IJMHEDAFOOI ADFOOOIPFKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x60D0290", Offset = "0x60CEE90", VA = "0x1860D0290", Slot = "5")]
	public void EBOHCNDCLJL(ELFHHNBICDJ MBMINLKOPLO, IJMHEDAFOOI ADFOOOIPFKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x60D1EC0", Offset = "0x60D0AC0", VA = "0x1860D1EC0", Slot = "6")]
	public void NBMHJJPHPPP(ELFHHNBICDJ MBMINLKOPLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x60D1FF0", Offset = "0x60D0BF0", VA = "0x1860D1FF0", Slot = "7")]
	public void PKPLKNIPHCJ(ELFHHNBICDJ MBMINLKOPLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x60D0580", Offset = "0x60CF180", VA = "0x1860D0580", Slot = "21")]
	public void INABOOPGAAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x17A5720", Offset = "0x17A4320", VA = "0x1817A5720", Slot = "8")]
	public void CDOLPFGLKJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x60D0FD0", Offset = "0x60CFBD0", VA = "0x1860D0FD0", Slot = "9")]
	public void KPLALFPPOEG(IJMHEDAFOOI ADFOOOIPFKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x60D1570", Offset = "0x60D0170", VA = "0x1860D1570", Slot = "10")]
	public void LOPHOEGFNKK(KEDHEOJCMED PMBNHDHBMIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x60D1220", Offset = "0x60CFE20", VA = "0x1860D1220", Slot = "11")]
	public void LOPHOEGFNKK(ELFHHNBICDJ MBMINLKOPLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x60D0970", Offset = "0x60CF570", VA = "0x1860D0970", Slot = "12")]
	public void JMPIKOBLEFG(KEDHEOJCMED PMBNHDHBMIA, COJBHKILGJI FIJCKHKKDCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x60D05C0", Offset = "0x60CF1C0", VA = "0x1860D05C0", Slot = "13")]
	public void JMPIKOBLEFG(ELFHHNBICDJ MBMINLKOPLO, COJBHKILGJI FIJCKHKKDCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x60D1140", Offset = "0x60CFD40", VA = "0x1860D1140", Slot = "22")]
	public void LDJKEPEDLHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x60D1180", Offset = "0x60CFD80", VA = "0x1860D1180", Slot = "14")]
	public void LMDAADLFJKK(ELFHHNBICDJ MBMINLKOPLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x60CFE30", Offset = "0x60CEA30", VA = "0x1860CFE30", Slot = "15")]
	public void DIJBFJKOKNH(ELFHHNBICDJ MBMINLKOPLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x163C7F0", Offset = "0x163B3F0", VA = "0x18163C7F0", Slot = "16")]
	public void AECJMHMEDCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x60CFCF0", Offset = "0x60CE8F0", VA = "0x1860CFCF0", Slot = "17")]
	public void BFKDEANBBFD(COJBHKILGJI FIJCKHKKDCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x60D0B30", Offset = "0x60CF730", VA = "0x1860D0B30")]
	private void KIEDMLCDAHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x60D07B0", Offset = "0x60CF3B0", VA = "0x1860D07B0")]
	public void JMPIKOBLEFG(ELFHHNBICDJ MBMINLKOPLO, COJBHKILGJI FIJCKHKKDCC, bool GNEKPFMEPJN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x60D04B0", Offset = "0x60CF0B0", VA = "0x1860D04B0")]
	private void EGIDNMMFKMJ(COJBHKILGJI FIJCKHKKDCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x60D1B40", Offset = "0x60D0740", VA = "0x1860D1B40", Slot = "18")]
	public void MPBDINPBFLA(KEDHEOJCMED PMBNHDHBMIA, Vector3 LEFBDNKEACA, Vector3 MOGIINDOPIF, Vector3 HCODGFDNEBK, float JINCPBNOHDM, float HHLKDKLECBK, IReadOnlyList<Camera> HCHGJGFNJHN, NOEKBONKFIJ CPFFFMGLAJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x60D1720", Offset = "0x60D0320", VA = "0x1860D1720", Slot = "19")]
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
			[Cpp2IlInjected.Address(RVA = "0x7F2DB0", Offset = "0x7F19B0", VA = "0x1807F2DB0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x7F2DB0", Offset = "0x7F19B0", VA = "0x1807F2DB0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0xAF7620", Offset = "0xAF6220", VA = "0x180AF7620")]
		[DebuggerHidden]
		public EIJABAMHHNC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x60CC840", Offset = "0x60CB440", VA = "0x1860CC840", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x60CC9B0", Offset = "0x60CB5B0", VA = "0x1860CC9B0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x60CC920", Offset = "0x60CB520", VA = "0x1860CC920", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<GAPMGKACAGA> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.PrimitiveShapeMeshData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x60CC920", Offset = "0x60CB520", VA = "0x1860CC920", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x60CF9C0", Offset = "0x60CE5C0", VA = "0x1860CF9C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public static SkinnedShapeRenderer MNGGPPHDPLB
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x60CF2C0", Offset = "0x60CDEC0", VA = "0x1860CF2C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x60CF8F0", Offset = "0x60CE4F0", VA = "0x1860CF8F0")]
	public static Mesh PAPPIDJLBPF(IBDNLIPCINH ACHIOCIDHJO, int MFKHINKPOED = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x60CF330", Offset = "0x60CDF30", VA = "0x1860CF330")]
	public static int JCKAGFDIDBJ(IBDNLIPCINH ACHIOCIDHJO, int MFKHINKPOED)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x60CF570", Offset = "0x60CE170", VA = "0x1860CF570")]
	public static PMBGFHHLLEO MFOLFNBABDF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x60CF510", Offset = "0x60CE110", VA = "0x1860CF510")]
	[IteratorStateMachine(typeof(EIJABAMHHNC))]
	private static IEnumerable<GAPMGKACAGA> MALEPKCJENO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x60CEF60", Offset = "0x60CDB60", VA = "0x1860CEF60")]
	public static GAPMGKACAGA FHDANIOJBPD(IBDNLIPCINH ACHIOCIDHJO, int MFKHINKPOED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x60CF4F0", Offset = "0x60CE0F0", VA = "0x1860CF4F0")]
	public static bool LOJOIIAPCOE(this IBDNLIPCINH ACHIOCIDHJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x60CF340", Offset = "0x60CDF40", VA = "0x1860CF340")]
	public static void KHLJDMKCLJJ(IBDNLIPCINH ACHIOCIDHJO, float3 DNKLKODKFKG, out HMLACCMOANJ AOMPMJILGLN, out float3 EHIOBOBOOEM, out float CPCAGNCDFFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x60CEBA0", Offset = "0x60CD7A0", VA = "0x1860CEBA0")]
	public static void BAKCJDPFCPE(Vector3 DNKLKODKFKG, IBDNLIPCINH ACHIOCIDHJO, out Vector3 EHIOBOBOOEM, out float CPCAGNCDFFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x60CF9B0", Offset = "0x60CE5B0", VA = "0x1860CF9B0")]
	[AGOCEKPENPF(ANODGEDDMCH.ExitingPlayMode, 0)]
	private static void PLAHBKALEGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x60CF6D0", Offset = "0x60CE2D0", VA = "0x1860CF6D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1B319A0", Offset = "0x1B305A0", VA = "0x181B319A0", Slot = "4")]
		get
		{
			return default(Bounds);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public virtual PFLMCMOEDJL DKMOCDALKGK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x60CFC60", Offset = "0x60CE860", VA = "0x1860CFC60", Slot = "17")]
		get
		{
			return default(PFLMCMOEDJL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public bool ODGBCGFPPPI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x836010", Offset = "0x834C10", VA = "0x180836010")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0xCAC080", Offset = "0xCAAC80", VA = "0x180CAC080")]
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
		[Cpp2IlInjected.Address(RVA = "0x85DA90", Offset = "0x85C690", VA = "0x18085DA90", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public ELHACHOPMGA OGMGCEBOGLD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x83EB00", Offset = "0x83D700", VA = "0x18083EB00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x83EB20", Offset = "0x83D720", VA = "0x18083EB20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public bool NPCCINLAOAM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x9087B0", Offset = "0x9073B0", VA = "0x1809087B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x836EE0", Offset = "0x835AE0", VA = "0x180836EE0")]
	protected JCAKCJAPNMN(CGPIBIJBJEL PMBNHDHBMIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x60CFAD0", Offset = "0x60CE6D0", VA = "0x1860CFAD0", Slot = "15")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7F0460", Offset = "0x7EF060", VA = "0x1807F0460", Slot = "16")]
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
	[Cpp2IlInjected.Address(RVA = "0x60CFC00", Offset = "0x60CE800", VA = "0x1860CFC00", Slot = "11")]
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
	[Cpp2IlInjected.Address(RVA = "0x60CFC30", Offset = "0x60CE830", VA = "0x1860CFC30", Slot = "10")]
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
		[Cpp2IlInjected.Address(RVA = "0x60CB760", Offset = "0x60CA360", VA = "0x1860CB760")]
		public DDDCFKEJMBE(MOIGNMENBCE BJKOLELNNLB, JobHandle KHHIMFIIKFD, HKLFDJPGKNH MCMHLAPNIFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x3F5C390", Offset = "0x3F5AF90", VA = "0x183F5C390")]
		public bool MMKBNABBBLH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x60CB730", Offset = "0x60CA330", VA = "0x1860CB730", Slot = "4")]
		public MOIGNMENBCE KOGMCNBOFCI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x60CB6E0", Offset = "0x60CA2E0", VA = "0x1860CB6E0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x60CE3B0", Offset = "0x60CCFB0", VA = "0x1860CE3B0", Slot = "22")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x60CE6D0", Offset = "0x60CD2D0", VA = "0x1860CE6D0")]
	public GOIJJKFGAOK(CGPIBIJBJEL PMBNHDHBMIA, AKEPPGNBIKJ PHBHEFAPHDL, bool MCLKPMDPNHH = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x7F0460", Offset = "0x7EF060", VA = "0x1807F0460", Slot = "16")]
	public override bool DGGJLCEDPMD(MLOGLFPJNHJ PMBNHDHBMIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x60CE4E0", Offset = "0x60CD0E0", VA = "0x1860CE4E0", Slot = "18")]
	public override int PIGMFMKOFNH(OGIGLGNLAOI MFKHINKPOED)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x60CE1C0", Offset = "0x60CCDC0", VA = "0x1860CE1C0", Slot = "19")]
	public override int LLGPBEAPAOA(OGIGLGNLAOI MFKHINKPOED)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x60CD7F0", Offset = "0x60CC3F0", VA = "0x1860CD7F0", Slot = "20")]
	public override void FDBHJOEAGLN(OGIGLGNLAOI MFKHINKPOED, KFLBACAHLKD JPNIJBMMAEI, int FGLENPDGBPO = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x60CE0F0", Offset = "0x60CCCF0", VA = "0x1860CE0F0", Slot = "21")]
	public override MLOGLFPJNHJ KDDJEDGHFKH()
	{
		return default(MLOGLFPJNHJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x60CDED0", Offset = "0x60CCAD0", VA = "0x1860CDED0", Slot = "23")]
	public override IDEKBKDIJGL JPLDNOGCCBD()
	{
		return default(IDEKBKDIJGL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x60CCF30", Offset = "0x60CBB30", VA = "0x1860CCF30", Slot = "24")]
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
			[Cpp2IlInjected.Address(RVA = "0x7F2DB0", Offset = "0x7F19B0", VA = "0x1807F2DB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x7F3030", Offset = "0x7F1C30", VA = "0x1807F3030")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public int JAPAIBMOOBD
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x60D9240", Offset = "0x60D7E40", VA = "0x1860D9240")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x60D85B0", Offset = "0x60D71B0", VA = "0x1860D85B0")]
		public static List<SkinnedShapeRenderer> Create(GameObject PMBNHDHBMIA, List<LHKAAMMOLAK> LPHCKCIFKKH, List<MLOGLFPJNHJ> MMMOCGAEDDF, Material IJIKACDMPFI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x60D8A30", Offset = "0x60D7630", VA = "0x1860D8A30")]
		public void Init(LHKAAMMOLAK BJKOLELNNLB, List<MLOGLFPJNHJ> MMMOCGAEDDF, Material IJIKACDMPFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x60D9190", Offset = "0x60D7D90", VA = "0x1860D9190")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x60D90E0", Offset = "0x60D7CE0", VA = "0x1860D90E0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x60D90A0", Offset = "0x60D7CA0", VA = "0x1860D90A0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x60D8800", Offset = "0x60D7400", VA = "0x1860D8800")]
		private void DOOFBBDPBAP(ScriptableRenderContext JFDMKPDIBDL, Camera[] EFPGFHCBMKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x60D8EE0", Offset = "0x60D7AE0", VA = "0x1860D8EE0")]
		private void LKLOIPFCPAN(CommandBuffer ONOCOAPIMAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x892580", Offset = "0x891180", VA = "0x180892580")]
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
		[Cpp2IlInjected.Address(RVA = "0x60CC9F0", Offset = "0x60CB5F0", VA = "0x1860CC9F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x60CCDB0", Offset = "0x60CB9B0", VA = "0x1860CCDB0")]
	public static void LPLDBEPABHL(COMIMHJPBAI BOAIEEHIGLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x60CCA50", Offset = "0x60CB650", VA = "0x1860CCA50")]
	public static Material FBGINAJDLKN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x60CCE00", Offset = "0x60CBA00", VA = "0x1860CCE00")]
	public static Material OALKKFBJLAM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x60CCC80", Offset = "0x60CB880", VA = "0x1860CCC80")]
	public static Material LCFMGMFMEFA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x60CCAB0", Offset = "0x60CB6B0", VA = "0x1860CCAB0")]
	public static int HKCCFIFDDMB(MFJEBBFONBC PCPDIHBJMFG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x60CCB20", Offset = "0x60CB720", VA = "0x1860CCB20")]
	public static int JJFEDHOIBHD(BIFNIOGHPEJ KKDMOBFFDAE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x60CCCE0", Offset = "0x60CB8E0", VA = "0x1860CCCE0")]
	public static void LIDBDOENDLA(GameObject HHNPCHNMLMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x60CCB90", Offset = "0x60CB790", VA = "0x1860CCB90")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public OOFHNNGDHKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x60D4A50", Offset = "0x60D3650", VA = "0x1860D4A50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly global::JKCGGPMKPAM<KEDHEOJCMED, CGPIBIJBJEL> LIECKGJDKOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly global::JKCGGPMKPAM<ELFHHNBICDJ, JCAKCJAPNMN> HNGPCMIMBEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly global::JKCGGPMKPAM<CMKAKNMPFLJ, OCHICALHIDA> IGMMHLLAMFO;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public CGPIBIJBJEL OILDPKEFAJI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x60C74F0", Offset = "0x60C60F0", VA = "0x1860C74F0", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public JCAKCJAPNMN OILDPKEFAJI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x60C7490", Offset = "0x60C6090", VA = "0x1860C7490", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public OCHICALHIDA OILDPKEFAJI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x60C7550", Offset = "0x60C6150", VA = "0x1860C7550", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool EJMCPDCOIFE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x9ABC90", Offset = "0x9AA890", VA = "0x1809ABC90", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x974F20", Offset = "0x973B20", VA = "0x180974F20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x60C9240", Offset = "0x60C7E40", VA = "0x1860C9240")]
	public BOMLMLONGAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x60C7040", Offset = "0x60C5C40", VA = "0x1860C7040", Slot = "21")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x60C71E0", Offset = "0x60C5DE0", VA = "0x1860C71E0", Slot = "4")]
	public KEDHEOJCMED ELKLHAMMJDB(DNGJCLCDCLI PHBHEFAPHDL)
	{
		return default(KEDHEOJCMED);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x60C71F0", Offset = "0x60C5DF0", VA = "0x1860C71F0", Slot = "5")]
	public KEDHEOJCMED ELKLHAMMJDB(DNGJCLCDCLI PHBHEFAPHDL, bool MCLKPMDPNHH)
	{
		return default(KEDHEOJCMED);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x60C8FC0", Offset = "0x60C7BC0", VA = "0x1860C8FC0", Slot = "6")]
	public void PALAJGEGMBL(KEDHEOJCMED PMBNHDHBMIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x60C7EB0", Offset = "0x60C6AB0", VA = "0x1860C7EB0", Slot = "7")]
	public void HCHGKENDMIH(KEDHEOJCMED PMBNHDHBMIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x60C75B0", Offset = "0x60C61B0", VA = "0x1860C75B0", Slot = "8")]
	public ELFHHNBICDJ GKLFNBKMJLN(KEDHEOJCMED PMBNHDHBMIA, BHCMHKPEBIK PHBHEFAPHDL)
	{
		return default(ELFHHNBICDJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x60C69D0", Offset = "0x60C55D0", VA = "0x1860C69D0", Slot = "9")]
	public ELFHHNBICDJ ABGJEAGDPNH(KEDHEOJCMED PMBNHDHBMIA, AKEPPGNBIKJ PHBHEFAPHDL)
	{
		return default(ELFHHNBICDJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x60C7AB0", Offset = "0x60C66B0", VA = "0x1860C7AB0", Slot = "11")]
	public void GOIJOIBGOLJ(ELFHHNBICDJ MBMINLKOPLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x60C8D40", Offset = "0x60C7940", VA = "0x1860C8D40", Slot = "10")]
	public void NFMCMHBDPAB(ELFHHNBICDJ MBMINLKOPLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x60C8CD0", Offset = "0x60C78D0", VA = "0x1860C8CD0", Slot = "20")]
	public IEnumerable<Renderer> MFOPHOEELHB(KEDHEOJCMED PMBNHDHBMIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x60C8C50", Offset = "0x60C7850", VA = "0x1860C8C50", Slot = "12")]
	public CMKAKNMPFLJ LNAIPJHODMF(FBHOACDOOMO PHBHEFAPHDL)
	{
		return default(CMKAKNMPFLJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x60C8BE0", Offset = "0x60C77E0", VA = "0x1860C8BE0", Slot = "14")]
	public void LJLMFGJLFMB(CMKAKNMPFLJ FAEDFCAKBGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x60C6ED0", Offset = "0x60C5AD0", VA = "0x1860C6ED0", Slot = "16")]
	public Task CLEMKFNPGKN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x60C8240", Offset = "0x60C6E40", VA = "0x1860C8240", Slot = "17")]
	public Task HMNMIJCBGAE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x60C8AC0", Offset = "0x60C76C0", VA = "0x1860C8AC0", Slot = "18")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(OOFHNNGDHKJ))]
	public Task LCGCOJCCPOO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x60C8A30", Offset = "0x60C7630", VA = "0x1860C8A30", Slot = "19")]
	public void KIJHGJPIFLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x60C89D0", Offset = "0x60C75D0", VA = "0x1860C89D0", Slot = "13")]
	public void IIEFJPGCPEM(CMKAKNMPFLJ FAEDFCAKBGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x60C83A0", Offset = "0x60C6FA0", VA = "0x1860C83A0", Slot = "25")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public BPBFAJPNHLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x60C9700", Offset = "0x60C8300", VA = "0x1860C9700")]
		internal JobHandle CMOMFNDMDFO()
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x60C9770", Offset = "0x60C8370", VA = "0x1860C9770")]
		internal void HPOPKBBAEKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x60C97B0", Offset = "0x60C83B0", VA = "0x1860C97B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x837A60", Offset = "0x836660", VA = "0x180837A60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x857190", Offset = "0x855D90", VA = "0x180857190")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public int MPMABLLJLPE
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x837B50", Offset = "0x836750", VA = "0x180837B50")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x8987F0", Offset = "0x8973F0", VA = "0x1808987F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x60D2D10", Offset = "0x60D1910", VA = "0x1860D2D10")]
	public void LKLOIPFCPAN(List<MLOGLFPJNHJ> KABDHDOKPBI, Matrix4x4[] JIMMKDGNPDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x60D26D0", Offset = "0x60D12D0", VA = "0x1860D26D0")]
	public static List<LHKAAMMOLAK> JLAKJAPJOGA(List<CGPIBIJBJEL> JMCDKPBIJCA, OGIGLGNLAOI MFKHINKPOED, Bounds NDJAACEKCOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x60D22E0", Offset = "0x60D0EE0", VA = "0x1860D22E0")]
	private JobHandle EHMMKIBGDNF(MOIGNMENBCE GOHPDNLDOCE, int APKINBBAHBB, int ONNPEHPDEML, OGIGLGNLAOI MFKHINKPOED, List<AJEDEHFJDDK> NJOJBONCPAE)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x60D2160", Offset = "0x60D0D60", VA = "0x1860D2160")]
	private void BPKBELIDFBK(List<AJEDEHFJDDK> NJOJBONCPAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x60D30A0", Offset = "0x60D1CA0", VA = "0x1860D30A0")]
	private LHKAAMMOLAK(List<AJEDEHFJDDK> NJOJBONCPAE, int APKINBBAHBB, int ONNPEHPDEML, OGIGLGNLAOI MFKHINKPOED, Bounds NDJAACEKCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x60D2270", Offset = "0x60D0E70", VA = "0x1860D2270", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7F2DB0", Offset = "0x7F19B0", VA = "0x1807F2DB0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x7F2DB0", Offset = "0x7F19B0", VA = "0x1807F2DB0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0xAF7620", Offset = "0xAF6220", VA = "0x180AF7620")]
		[DebuggerHidden]
		public HHLMCKEGGGO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x60CEAD0", Offset = "0x60CD6D0", VA = "0x1860CEAD0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x60CE7D0", Offset = "0x60CD3D0", VA = "0x1860CE7D0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x60CE780", Offset = "0x60CD380", VA = "0x1860CE780")]
		private void EHFOANOMIIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x60CEA90", Offset = "0x60CD690", VA = "0x1860CEA90", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x60CE9F0", Offset = "0x60CD5F0", VA = "0x1860CE9F0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x60CE9F0", Offset = "0x60CD5F0", VA = "0x1860CE9F0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x60D34D0", Offset = "0x60D20D0", VA = "0x1860D34D0")]
	public static OCHICALHIDA BICODEPLJOC(FBHOACDOOMO PHBHEFAPHDL, LPEOPNPNMLE GLHCHJGKEGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x60D4950", Offset = "0x60D3550", VA = "0x1860D4950")]
	private OCHICALHIDA(FBHOACDOOMO PHBHEFAPHDL, LPEOPNPNMLE GLHCHJGKEGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x60D4440", Offset = "0x60D3040", VA = "0x1860D4440")]
	public void LIEFKNGBAEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x60D43D0", Offset = "0x60D2FD0", VA = "0x1860D43D0")]
	[IteratorStateMachine(typeof(HHLMCKEGGGO))]
	public IEnumerable<Renderer> KCELAAPDHFG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x60D3880", Offset = "0x60D2480", VA = "0x1860D3880", Slot = "4")]
	public void CEMJONFHNGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x60D4330", Offset = "0x60D2F30", VA = "0x1860D4330")]
	private void JHMKMDJBEJC(Vector3 JCLAAMDIJKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x60D3640", Offset = "0x60D2240", VA = "0x1860D3640")]
	public void CCMEEJNHHBN()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class PFBBJKPLBFC
{
	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
	public PFBBJKPLBFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x1DDAC60", Offset = "0x1DD9860", VA = "0x181DDAC60")]
	public static string NIMNBIGPMKB(byte[] DCFEDNINKHD, byte[] LFMKEJPAGIF)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class __BB_OBFUSCATOR_VERSION_3_9_9
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
