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
		[Cpp2IlInjected.Address(RVA = "0x80ECA0", Offset = "0x80D4A0", VA = "0x18080ECA0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x80EE50", Offset = "0x80D650", VA = "0x18080EE50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int EFMDAIFBNCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8CDBD0", Offset = "0x8CC3D0", VA = "0x1808CDBD0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xB20BA0", Offset = "0xB1F3A0", VA = "0x180B20BA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public float ELGEACOKBIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xA64350", Offset = "0xA62B50", VA = "0x180A64350", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xA64850", Offset = "0xA63050", VA = "0x180A64850")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public float BHDEKKKNCLL
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA51050", Offset = "0xA4F850", VA = "0x180A51050", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xA51080", Offset = "0xA4F880", VA = "0x180A51080")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public List<SkinnedShapeRenderer> LAKDIELFAAH
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6205E50", Offset = "0x6204650", VA = "0x186205E50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public List<SkinnedShapeRenderer> PHJFLDNOHEF
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x142DFD0", Offset = "0x142C7D0", VA = "0x18142DFD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public GameObject ODFEIMILGMP
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7F2A40", Offset = "0x7F1240", VA = "0x1807F2A40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x919F90", Offset = "0x918790", VA = "0x180919F90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public byte CFAKIHAGNDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6205B40", Offset = "0x6204340", VA = "0x186205B40", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6206060", Offset = "0x6204860", VA = "0x186206060")]
	public DJNPCDEHLMO(List<LHKAAMMOLAK> NLCOCHFOFEF, List<LHKAAMMOLAK> GMABNMFHOBC, List<MLOGLFPJNHJ> MMMOCGAEDDF, Material IJIKACDMPFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6205F50", Offset = "0x6204750", VA = "0x186205F50")]
	private int PIGMFMKOFNH(List<LHKAAMMOLAK> LPHCKCIFKKH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6205B90", Offset = "0x6204390", VA = "0x186205B90")]
	private void DAJKCCPDAPB(int LKHEAPMCOFA, bool JACPCCGHLHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6205EB0", Offset = "0x62046B0", VA = "0x186205EB0")]
	public void PCFJLFJEMDG(Vector3 JCLAAMDIJKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6205CE0", Offset = "0x62044E0", VA = "0x186205CE0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6205E10", Offset = "0x6204610", VA = "0x186205E10")]
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
		[Cpp2IlInjected.Address(RVA = "0x6207260", Offset = "0x6205A60", VA = "0x186207260")]
		public FPIOLJLFEIB(MOIGNMENBCE BJKOLELNNLB, JobHandle KHHIMFIIKFD, APJCKIKOKLF MCMHLAPNIFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x41E08E0", Offset = "0x41DF0E0", VA = "0x1841E08E0")]
		public bool MMKBNABBBLH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6207230", Offset = "0x6205A30", VA = "0x186207230", Slot = "4")]
		public MOIGNMENBCE KOGMCNBOFCI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x62071E0", Offset = "0x62059E0", VA = "0x1862071E0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x6211180", Offset = "0x620F980", VA = "0x186211180", Slot = "17")]
		get
		{
			return default(PFLMCMOEDJL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private Vector3 GFBHMCOCFGI
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6210A40", Offset = "0x620F240", VA = "0x186210A40")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	protected override Hash128 CNMCPELMMBI
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6211050", Offset = "0x620F850", VA = "0x186211050", Slot = "22")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6211600", Offset = "0x620FE00", VA = "0x186211600")]
	public OPCBBMMPEAE(CGPIBIJBJEL PMBNHDHBMIA, BHCMHKPEBIK PHBHEFAPHDL, bool MPPDPIKPBCA = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x620F290", Offset = "0x620DA90", VA = "0x18620F290", Slot = "16")]
	public override bool DGGJLCEDPMD(MLOGLFPJNHJ PMBNHDHBMIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6211550", Offset = "0x620FD50", VA = "0x186211550", Slot = "18")]
	public override int PIGMFMKOFNH(OGIGLGNLAOI MFKHINKPOED)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6210990", Offset = "0x620F190", VA = "0x186210990", Slot = "19")]
	public override int LLGPBEAPAOA(OGIGLGNLAOI MFKHINKPOED)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6210DA0", Offset = "0x620F5A0", VA = "0x186210DA0")]
	private int MPOLKANKBNC(OGIGLGNLAOI MFKHINKPOED)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x620FF10", Offset = "0x620E710", VA = "0x18620FF10", Slot = "20")]
	public override void FDBHJOEAGLN(OGIGLGNLAOI MFKHINKPOED, KFLBACAHLKD JPNIJBMMAEI, int FGLENPDGBPO = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x62108C0", Offset = "0x620F0C0", VA = "0x1862108C0", Slot = "21")]
	public override MLOGLFPJNHJ KDDJEDGHFKH()
	{
		return default(MLOGLFPJNHJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x62106A0", Offset = "0x620EEA0", VA = "0x1862106A0", Slot = "23")]
	public override IDEKBKDIJGL JPLDNOGCCBD()
	{
		return default(IDEKBKDIJGL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x620F6F0", Offset = "0x620DEF0", VA = "0x18620F6F0", Slot = "24")]
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
			[Cpp2IlInjected.Address(RVA = "0x8117F0", Offset = "0x80FFF0", VA = "0x1808117F0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x8117F0", Offset = "0x80FFF0", VA = "0x1808117F0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xB955D0", Offset = "0xB93DD0", VA = "0x180B955D0")]
		[DebuggerHidden]
		public ECDMMLHMMIM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x6206AC0", Offset = "0x62052C0", VA = "0x186206AC0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6206470", Offset = "0x6204C70", VA = "0x186206470", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6206420", Offset = "0x6204C20", VA = "0x186206420")]
		private void EHFOANOMIIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6206940", Offset = "0x6205140", VA = "0x186206940")]
		private void NDPBPNJDDHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6206990", Offset = "0x6205190", VA = "0x186206990")]
		private void PFJGOFLDFDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6206A80", Offset = "0x6205280", VA = "0x186206A80", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x62069E0", Offset = "0x62051E0", VA = "0x1862069E0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x62069E0", Offset = "0x62051E0", VA = "0x1862069E0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x8117F0", Offset = "0x80FFF0", VA = "0x1808117F0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x8117F0", Offset = "0x80FFF0", VA = "0x1808117F0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xB955D0", Offset = "0xB93DD0", VA = "0x180B955D0")]
		[DebuggerHidden]
		public CAPLPIHFBGK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6204150", Offset = "0x6202950", VA = "0x186204150", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6203CF0", Offset = "0x62024F0", VA = "0x186203CF0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6203CA0", Offset = "0x62024A0", VA = "0x186203CA0")]
		private void EHFOANOMIIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6204020", Offset = "0x6202820", VA = "0x186204020")]
		private void NDPBPNJDDHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6204110", Offset = "0x6202910", VA = "0x186204110", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6204070", Offset = "0x6202870", VA = "0x186204070", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6204070", Offset = "0x6202870", VA = "0x186204070", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x8117F0", Offset = "0x80FFF0", VA = "0x1808117F0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int CEMBDEKPEED
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6204FB0", Offset = "0x62037B0", VA = "0x186204FB0", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public MLOGLFPJNHJ KBGCOCFPMCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6204EE0", Offset = "0x62036E0", VA = "0x186204EE0", Slot = "7")]
		get
		{
			return default(MLOGLFPJNHJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public List<SkinnedShapeRenderer> KJLNJDFIDBP
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7F3660", Offset = "0x7F1E60", VA = "0x1807F3660")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8B4920", Offset = "0x8B3120", VA = "0x1808B4920")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6205570", Offset = "0x6203D70", VA = "0x186205570")]
	private bool JPHOFKEEEKN(JCAKCJAPNMN MBMINLKOPLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6205550", Offset = "0x6203D50", VA = "0x186205550")]
	private static bool JLFJDHHPALO(JCAKCJAPNMN MBMINLKOPLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6205970", Offset = "0x6204170", VA = "0x186205970")]
	public CGPIBIJBJEL(DNGJCLCDCLI PHBHEFAPHDL, bool MCLKPMDPNHH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6204D60", Offset = "0x6203560", VA = "0x186204D60", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6204230", Offset = "0x6202A30", VA = "0x186204230")]
	public void CAILCKFFJIK(JCAKCJAPNMN MBMINLKOPLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6204BC0", Offset = "0x62033C0", VA = "0x186204BC0")]
	public void CPPHPNNFPKL(JCAKCJAPNMN MBMINLKOPLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6204690", Offset = "0x6202E90", VA = "0x186204690", Slot = "4")]
	public void CEMJONFHNGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6204440", Offset = "0x6202C40", VA = "0x186204440")]
	public void CCMEEJNHHBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x62056B0", Offset = "0x6203EB0", VA = "0x1862056B0")]
	private void LJCILHJCKGO(List<JCAKCJAPNMN> HNGPCMIMBEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6205840", Offset = "0x6204040", VA = "0x186205840")]
	private static Material OALKKFBJLAM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6205610", Offset = "0x6203E10", VA = "0x186205610")]
	private void LJCILHJCKGO(JCAKCJAPNMN MBMINLKOPLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x62058A0", Offset = "0x62040A0", VA = "0x1862058A0")]
	private void PMHLGKHIMJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6204FF0", Offset = "0x62037F0", VA = "0x186204FF0")]
	public void JHBBHOKKGIE(bool KAGOBCEBCHO, bool CKEHPGKKHMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6204B30", Offset = "0x6203330", VA = "0x186204B30")]
	protected void CFPECMFDENF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x62055A0", Offset = "0x6203DA0", VA = "0x1862055A0")]
	[IteratorStateMachine(typeof(ECDMMLHMMIM))]
	public IEnumerable<Renderer> KCELAAPDHFG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6204CF0", Offset = "0x62034F0", VA = "0x186204CF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6212900", Offset = "0x6211100", VA = "0x186212900")]
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
		[Cpp2IlInjected.Address(RVA = "0x6211AB0", Offset = "0x62102B0", VA = "0x186211AB0", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public JCAKCJAPNMN OILDPKEFAJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6211A50", Offset = "0x6210250", VA = "0x186211A50", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public OCHICALHIDA OILDPKEFAJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x62119F0", Offset = "0x62101F0", VA = "0x1862119F0", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public bool EJMCPDCOIFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xA217D0", Offset = "0xA1FFD0", VA = "0x180A217D0", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x9EAA60", Offset = "0x9E9260", VA = "0x1809EAA60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6212520", Offset = "0x6210D20", VA = "0x186212520")]
	public PALOEJCHOAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6211850", Offset = "0x6210050", VA = "0x186211850", Slot = "21")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x62118E0", Offset = "0x62100E0", VA = "0x1862118E0", Slot = "4")]
	public KEDHEOJCMED ELKLHAMMJDB(DNGJCLCDCLI PHBHEFAPHDL)
	{
		return default(KEDHEOJCMED);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x62118E0", Offset = "0x62100E0", VA = "0x1862118E0", Slot = "5")]
	public KEDHEOJCMED ELKLHAMMJDB(DNGJCLCDCLI PHBHEFAPHDL, bool MCLKPMDPNHH)
	{
		return default(KEDHEOJCMED);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6212430", Offset = "0x6210C30", VA = "0x186212430", Slot = "6")]
	public void PALAJGEGMBL(KEDHEOJCMED PMBNHDHBMIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6211CD0", Offset = "0x62104D0", VA = "0x186211CD0", Slot = "7")]
	public void HCHGKENDMIH(KEDHEOJCMED PMBNHDHBMIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6211B10", Offset = "0x6210310", VA = "0x186211B10", Slot = "8")]
	public ELFHHNBICDJ GKLFNBKMJLN(KEDHEOJCMED PMBNHDHBMIA, BHCMHKPEBIK PHBHEFAPHDL)
	{
		return default(ELFHHNBICDJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x62116B0", Offset = "0x620FEB0", VA = "0x1862116B0", Slot = "9")]
	public ELFHHNBICDJ ABGJEAGDPNH(KEDHEOJCMED PMBNHDHBMIA, AKEPPGNBIKJ PHBHEFAPHDL)
	{
		return default(ELFHHNBICDJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6211C40", Offset = "0x6210440", VA = "0x186211C40", Slot = "11")]
	public void GOIJOIBGOLJ(ELFHHNBICDJ MBMINLKOPLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x62123D0", Offset = "0x6210BD0", VA = "0x1862123D0", Slot = "10")]
	public void NFMCMHBDPAB(ELFHHNBICDJ MBMINLKOPLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6212360", Offset = "0x6210B60", VA = "0x186212360", Slot = "20")]
	public IEnumerable<Renderer> MFOPHOEELHB(KEDHEOJCMED PMBNHDHBMIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x62122E0", Offset = "0x6210AE0", VA = "0x1862122E0", Slot = "12")]
	public CMKAKNMPFLJ LNAIPJHODMF(FBHOACDOOMO PHBHEFAPHDL)
	{
		return default(CMKAKNMPFLJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6212270", Offset = "0x6210A70", VA = "0x186212270", Slot = "14")]
	public void LJLMFGJLFMB(CMKAKNMPFLJ FAEDFCAKBGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x62117F0", Offset = "0x620FFF0", VA = "0x1862117F0", Slot = "16")]
	public Task CLEMKFNPGKN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6211D50", Offset = "0x6210550", VA = "0x186211D50", Slot = "17")]
	public Task HMNMIJCBGAE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6212210", Offset = "0x6210A10", VA = "0x186212210", Slot = "18")]
	public Task LCGCOJCCPOO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x32E1A00", Offset = "0x32E0200", VA = "0x1832E1A00", Slot = "19")]
	public void KIJHGJPIFLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x62121B0", Offset = "0x62109B0", VA = "0x1862121B0", Slot = "13")]
	public void IIEFJPGCPEM(CMKAKNMPFLJ FAEDFCAKBGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6211DB0", Offset = "0x62105B0", VA = "0x186211DB0", Slot = "25")]
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
		[Cpp2IlInjected.Address(RVA = "0x6208ED0", Offset = "0x62076D0", VA = "0x186208ED0")]
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
	[Cpp2IlInjected.Address(RVA = "0x620C490", Offset = "0x620AC90", VA = "0x18620C490")]
	public JKPNMCGPONA(OCDMIMHKKFF MGCHHMKAMOF, LPEOPNPNMLE GLHCHJGKEGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x620A240", Offset = "0x6208A40", VA = "0x18620A240", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x620B100", Offset = "0x6209900", VA = "0x18620B100")]
	private void KLEIJMJJIOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x620A410", Offset = "0x6208C10", VA = "0x18620A410", Slot = "4")]
	public void EBOHCNDCLJL(KEDHEOJCMED PMBNHDHBMIA, IJMHEDAFOOI ADFOOOIPFKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x620A610", Offset = "0x6208E10", VA = "0x18620A610", Slot = "5")]
	public void EBOHCNDCLJL(ELFHHNBICDJ MBMINLKOPLO, IJMHEDAFOOI ADFOOOIPFKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x620C240", Offset = "0x620AA40", VA = "0x18620C240", Slot = "6")]
	public void NBMHJJPHPPP(ELFHHNBICDJ MBMINLKOPLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x620C370", Offset = "0x620AB70", VA = "0x18620C370", Slot = "7")]
	public void PKPLKNIPHCJ(ELFHHNBICDJ MBMINLKOPLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x620A900", Offset = "0x6209100", VA = "0x18620A900", Slot = "21")]
	public void INABOOPGAAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x1A81D70", Offset = "0x1A80570", VA = "0x181A81D70", Slot = "8")]
	public void CDOLPFGLKJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x620B350", Offset = "0x6209B50", VA = "0x18620B350", Slot = "9")]
	public void KPLALFPPOEG(IJMHEDAFOOI ADFOOOIPFKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x620B8F0", Offset = "0x620A0F0", VA = "0x18620B8F0", Slot = "10")]
	public void LOPHOEGFNKK(KEDHEOJCMED PMBNHDHBMIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x620B5A0", Offset = "0x6209DA0", VA = "0x18620B5A0", Slot = "11")]
	public void LOPHOEGFNKK(ELFHHNBICDJ MBMINLKOPLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x620ACF0", Offset = "0x62094F0", VA = "0x18620ACF0", Slot = "12")]
	public void JMPIKOBLEFG(KEDHEOJCMED PMBNHDHBMIA, COJBHKILGJI FIJCKHKKDCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x620A940", Offset = "0x6209140", VA = "0x18620A940", Slot = "13")]
	public void JMPIKOBLEFG(ELFHHNBICDJ MBMINLKOPLO, COJBHKILGJI FIJCKHKKDCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x620B4C0", Offset = "0x6209CC0", VA = "0x18620B4C0", Slot = "22")]
	public void LDJKEPEDLHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x620B500", Offset = "0x6209D00", VA = "0x18620B500", Slot = "14")]
	public void LMDAADLFJKK(ELFHHNBICDJ MBMINLKOPLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x620A1B0", Offset = "0x62089B0", VA = "0x18620A1B0", Slot = "15")]
	public void DIJBFJKOKNH(ELFHHNBICDJ MBMINLKOPLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x19190B0", Offset = "0x19178B0", VA = "0x1819190B0", Slot = "16")]
	public void AECJMHMEDCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x620A070", Offset = "0x6208870", VA = "0x18620A070", Slot = "17")]
	public void BFKDEANBBFD(COJBHKILGJI FIJCKHKKDCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x620AEB0", Offset = "0x62096B0", VA = "0x18620AEB0")]
	private void KIEDMLCDAHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x620AB30", Offset = "0x6209330", VA = "0x18620AB30")]
	public void JMPIKOBLEFG(ELFHHNBICDJ MBMINLKOPLO, COJBHKILGJI FIJCKHKKDCC, bool GNEKPFMEPJN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x620A830", Offset = "0x6209030", VA = "0x18620A830")]
	private void EGIDNMMFKMJ(COJBHKILGJI FIJCKHKKDCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x620BEC0", Offset = "0x620A6C0", VA = "0x18620BEC0", Slot = "18")]
	public void MPBDINPBFLA(KEDHEOJCMED PMBNHDHBMIA, Vector3 LEFBDNKEACA, Vector3 MOGIINDOPIF, Vector3 HCODGFDNEBK, float JINCPBNOHDM, float HHLKDKLECBK, IReadOnlyList<Camera> HCHGJGFNJHN, NOEKBONKFIJ CPFFFMGLAJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x620BAA0", Offset = "0x620A2A0", VA = "0x18620BAA0", Slot = "19")]
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
			[Cpp2IlInjected.Address(RVA = "0x8117F0", Offset = "0x80FFF0", VA = "0x1808117F0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x8117F0", Offset = "0x80FFF0", VA = "0x1808117F0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0xB955D0", Offset = "0xB93DD0", VA = "0x180B955D0")]
		[DebuggerHidden]
		public EIJABAMHHNC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x6206BC0", Offset = "0x62053C0", VA = "0x186206BC0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6206D30", Offset = "0x6205530", VA = "0x186206D30", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6206CA0", Offset = "0x62054A0", VA = "0x186206CA0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<GAPMGKACAGA> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.PrimitiveShapeMeshData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x6206CA0", Offset = "0x62054A0", VA = "0x186206CA0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x6209D40", Offset = "0x6208540", VA = "0x186209D40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public static SkinnedShapeRenderer MNGGPPHDPLB
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6209640", Offset = "0x6207E40", VA = "0x186209640")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6209C70", Offset = "0x6208470", VA = "0x186209C70")]
	public static Mesh PAPPIDJLBPF(IBDNLIPCINH ACHIOCIDHJO, int MFKHINKPOED = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x62096B0", Offset = "0x6207EB0", VA = "0x1862096B0")]
	public static int JCKAGFDIDBJ(IBDNLIPCINH ACHIOCIDHJO, int MFKHINKPOED)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x62098F0", Offset = "0x62080F0", VA = "0x1862098F0")]
	public static PMBGFHHLLEO MFOLFNBABDF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6209890", Offset = "0x6208090", VA = "0x186209890")]
	[IteratorStateMachine(typeof(EIJABAMHHNC))]
	private static IEnumerable<GAPMGKACAGA> MALEPKCJENO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x62092E0", Offset = "0x6207AE0", VA = "0x1862092E0")]
	public static GAPMGKACAGA FHDANIOJBPD(IBDNLIPCINH ACHIOCIDHJO, int MFKHINKPOED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6209870", Offset = "0x6208070", VA = "0x186209870")]
	public static bool LOJOIIAPCOE(this IBDNLIPCINH ACHIOCIDHJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x62096C0", Offset = "0x6207EC0", VA = "0x1862096C0")]
	public static void KHLJDMKCLJJ(IBDNLIPCINH ACHIOCIDHJO, float3 DNKLKODKFKG, out HMLACCMOANJ AOMPMJILGLN, out float3 EHIOBOBOOEM, out float CPCAGNCDFFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6208F20", Offset = "0x6207720", VA = "0x186208F20")]
	public static void BAKCJDPFCPE(Vector3 DNKLKODKFKG, IBDNLIPCINH ACHIOCIDHJO, out Vector3 EHIOBOBOOEM, out float CPCAGNCDFFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6209D30", Offset = "0x6208530", VA = "0x186209D30")]
	[AGOCEKPENPF(ANODGEDDMCH.ExitingPlayMode, 0)]
	private static void PLAHBKALEGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6209A50", Offset = "0x6208250", VA = "0x186209A50")]
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
		[Cpp2IlInjected.Address(RVA = "0x1E170E0", Offset = "0x1E158E0", VA = "0x181E170E0", Slot = "4")]
		get
		{
			return default(Bounds);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public virtual PFLMCMOEDJL DKMOCDALKGK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x6209FE0", Offset = "0x62087E0", VA = "0x186209FE0", Slot = "17")]
		get
		{
			return default(PFLMCMOEDJL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public bool ODGBCGFPPPI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE60", Offset = "0x8AA660", VA = "0x1808ABE60")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0xDA40B0", Offset = "0xDA28B0", VA = "0x180DA40B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7F2890", Offset = "0x7F1090", VA = "0x1807F2890", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public ELHACHOPMGA OGMGCEBOGLD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x7F3660", Offset = "0x7F1E60", VA = "0x1807F3660")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x8B4920", Offset = "0x8B3120", VA = "0x1808B4920")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public bool NPCCINLAOAM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x97E320", Offset = "0x97CB20", VA = "0x18097E320")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x8ACD20", Offset = "0x8AB520", VA = "0x1808ACD20")]
	protected JCAKCJAPNMN(CGPIBIJBJEL PMBNHDHBMIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6209E50", Offset = "0x6208650", VA = "0x186209E50", Slot = "15")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7F35F0", Offset = "0x7F1DF0", VA = "0x1807F35F0", Slot = "16")]
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
	[Cpp2IlInjected.Address(RVA = "0x6209F80", Offset = "0x6208780", VA = "0x186209F80", Slot = "11")]
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
	[Cpp2IlInjected.Address(RVA = "0x6209FB0", Offset = "0x62087B0", VA = "0x186209FB0", Slot = "10")]
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
		[Cpp2IlInjected.Address(RVA = "0x6205AE0", Offset = "0x62042E0", VA = "0x186205AE0")]
		public DDDCFKEJMBE(MOIGNMENBCE BJKOLELNNLB, JobHandle KHHIMFIIKFD, HKLFDJPGKNH MCMHLAPNIFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x41E08E0", Offset = "0x41DF0E0", VA = "0x1841E08E0")]
		public bool MMKBNABBBLH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x6205AB0", Offset = "0x62042B0", VA = "0x186205AB0", Slot = "4")]
		public MOIGNMENBCE KOGMCNBOFCI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x6205A60", Offset = "0x6204260", VA = "0x186205A60", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x6208730", Offset = "0x6206F30", VA = "0x186208730", Slot = "22")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x6208A50", Offset = "0x6207250", VA = "0x186208A50")]
	public GOIJJKFGAOK(CGPIBIJBJEL PMBNHDHBMIA, AKEPPGNBIKJ PHBHEFAPHDL, bool MCLKPMDPNHH = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x7F35F0", Offset = "0x7F1DF0", VA = "0x1807F35F0", Slot = "16")]
	public override bool DGGJLCEDPMD(MLOGLFPJNHJ PMBNHDHBMIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x6208860", Offset = "0x6207060", VA = "0x186208860", Slot = "18")]
	public override int PIGMFMKOFNH(OGIGLGNLAOI MFKHINKPOED)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x6208540", Offset = "0x6206D40", VA = "0x186208540", Slot = "19")]
	public override int LLGPBEAPAOA(OGIGLGNLAOI MFKHINKPOED)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x6207B70", Offset = "0x6206370", VA = "0x186207B70", Slot = "20")]
	public override void FDBHJOEAGLN(OGIGLGNLAOI MFKHINKPOED, KFLBACAHLKD JPNIJBMMAEI, int FGLENPDGBPO = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x6208470", Offset = "0x6206C70", VA = "0x186208470", Slot = "21")]
	public override MLOGLFPJNHJ KDDJEDGHFKH()
	{
		return default(MLOGLFPJNHJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6208250", Offset = "0x6206A50", VA = "0x186208250", Slot = "23")]
	public override IDEKBKDIJGL JPLDNOGCCBD()
	{
		return default(IDEKBKDIJGL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x62072B0", Offset = "0x6205AB0", VA = "0x1862072B0", Slot = "24")]
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
			[Cpp2IlInjected.Address(RVA = "0x8117F0", Offset = "0x80FFF0", VA = "0x1808117F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x811A70", Offset = "0x810270", VA = "0x180811A70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public int JAPAIBMOOBD
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x62135C0", Offset = "0x6211DC0", VA = "0x1862135C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x6212930", Offset = "0x6211130", VA = "0x186212930")]
		public static List<SkinnedShapeRenderer> Create(GameObject PMBNHDHBMIA, List<LHKAAMMOLAK> LPHCKCIFKKH, List<MLOGLFPJNHJ> MMMOCGAEDDF, Material IJIKACDMPFI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x6212DB0", Offset = "0x62115B0", VA = "0x186212DB0")]
		public void Init(LHKAAMMOLAK BJKOLELNNLB, List<MLOGLFPJNHJ> MMMOCGAEDDF, Material IJIKACDMPFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x6213510", Offset = "0x6211D10", VA = "0x186213510")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x6213460", Offset = "0x6211C60", VA = "0x186213460")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x6213420", Offset = "0x6211C20", VA = "0x186213420")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x6212B80", Offset = "0x6211380", VA = "0x186212B80")]
		private void DOOFBBDPBAP(ScriptableRenderContext JFDMKPDIBDL, Camera[] EFPGFHCBMKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x6213260", Offset = "0x6211A60", VA = "0x186213260")]
		private void LKLOIPFCPAN(CommandBuffer ONOCOAPIMAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x9080F0", Offset = "0x9068F0", VA = "0x1809080F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6206D70", Offset = "0x6205570", VA = "0x186206D70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x6207130", Offset = "0x6205930", VA = "0x186207130")]
	public static void LPLDBEPABHL(COMIMHJPBAI BOAIEEHIGLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x6206DD0", Offset = "0x62055D0", VA = "0x186206DD0")]
	public static Material FBGINAJDLKN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x6207180", Offset = "0x6205980", VA = "0x186207180")]
	public static Material OALKKFBJLAM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x6207000", Offset = "0x6205800", VA = "0x186207000")]
	public static Material LCFMGMFMEFA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x6206E30", Offset = "0x6205630", VA = "0x186206E30")]
	public static int HKCCFIFDDMB(MFJEBBFONBC PCPDIHBJMFG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x6206EA0", Offset = "0x62056A0", VA = "0x186206EA0")]
	public static int JJFEDHOIBHD(BIFNIOGHPEJ KKDMOBFFDAE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x6207060", Offset = "0x6205860", VA = "0x186207060")]
	public static void LIDBDOENDLA(GameObject HHNPCHNMLMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x6206F10", Offset = "0x6205710", VA = "0x186206F10")]
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
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public OOFHNNGDHKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x620EDD0", Offset = "0x620D5D0", VA = "0x18620EDD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x6201870", Offset = "0x6200070", VA = "0x186201870", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public JCAKCJAPNMN OILDPKEFAJI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x6201810", Offset = "0x6200010", VA = "0x186201810", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public OCHICALHIDA OILDPKEFAJI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x62018D0", Offset = "0x62000D0", VA = "0x1862018D0", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool EJMCPDCOIFE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0xA217D0", Offset = "0xA1FFD0", VA = "0x180A217D0", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x9EAA60", Offset = "0x9E9260", VA = "0x1809EAA60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x62035C0", Offset = "0x6201DC0", VA = "0x1862035C0")]
	public BOMLMLONGAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x62013C0", Offset = "0x61FFBC0", VA = "0x1862013C0", Slot = "21")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x6201560", Offset = "0x61FFD60", VA = "0x186201560", Slot = "4")]
	public KEDHEOJCMED ELKLHAMMJDB(DNGJCLCDCLI PHBHEFAPHDL)
	{
		return default(KEDHEOJCMED);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x6201570", Offset = "0x61FFD70", VA = "0x186201570", Slot = "5")]
	public KEDHEOJCMED ELKLHAMMJDB(DNGJCLCDCLI PHBHEFAPHDL, bool MCLKPMDPNHH)
	{
		return default(KEDHEOJCMED);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x6203340", Offset = "0x6201B40", VA = "0x186203340", Slot = "6")]
	public void PALAJGEGMBL(KEDHEOJCMED PMBNHDHBMIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x6202230", Offset = "0x6200A30", VA = "0x186202230", Slot = "7")]
	public void HCHGKENDMIH(KEDHEOJCMED PMBNHDHBMIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x6201930", Offset = "0x6200130", VA = "0x186201930", Slot = "8")]
	public ELFHHNBICDJ GKLFNBKMJLN(KEDHEOJCMED PMBNHDHBMIA, BHCMHKPEBIK PHBHEFAPHDL)
	{
		return default(ELFHHNBICDJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x6200D50", Offset = "0x61FF550", VA = "0x186200D50", Slot = "9")]
	public ELFHHNBICDJ ABGJEAGDPNH(KEDHEOJCMED PMBNHDHBMIA, AKEPPGNBIKJ PHBHEFAPHDL)
	{
		return default(ELFHHNBICDJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x6201E30", Offset = "0x6200630", VA = "0x186201E30", Slot = "11")]
	public void GOIJOIBGOLJ(ELFHHNBICDJ MBMINLKOPLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x62030C0", Offset = "0x62018C0", VA = "0x1862030C0", Slot = "10")]
	public void NFMCMHBDPAB(ELFHHNBICDJ MBMINLKOPLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x6203050", Offset = "0x6201850", VA = "0x186203050", Slot = "20")]
	public IEnumerable<Renderer> MFOPHOEELHB(KEDHEOJCMED PMBNHDHBMIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x6202FD0", Offset = "0x62017D0", VA = "0x186202FD0", Slot = "12")]
	public CMKAKNMPFLJ LNAIPJHODMF(FBHOACDOOMO PHBHEFAPHDL)
	{
		return default(CMKAKNMPFLJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x6202F60", Offset = "0x6201760", VA = "0x186202F60", Slot = "14")]
	public void LJLMFGJLFMB(CMKAKNMPFLJ FAEDFCAKBGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x6201250", Offset = "0x61FFA50", VA = "0x186201250", Slot = "16")]
	public Task CLEMKFNPGKN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x62025C0", Offset = "0x6200DC0", VA = "0x1862025C0", Slot = "17")]
	public Task HMNMIJCBGAE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x6202E40", Offset = "0x6201640", VA = "0x186202E40", Slot = "18")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(OOFHNNGDHKJ))]
	public Task LCGCOJCCPOO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x6202DB0", Offset = "0x62015B0", VA = "0x186202DB0", Slot = "19")]
	public void KIJHGJPIFLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x6202D50", Offset = "0x6201550", VA = "0x186202D50", Slot = "13")]
	public void IIEFJPGCPEM(CMKAKNMPFLJ FAEDFCAKBGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x6202720", Offset = "0x6200F20", VA = "0x186202720", Slot = "25")]
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
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
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
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public BPBFAJPNHLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x6203A80", Offset = "0x6202280", VA = "0x186203A80")]
		internal JobHandle CMOMFNDMDFO()
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x6203AF0", Offset = "0x62022F0", VA = "0x186203AF0")]
		internal void HPOPKBBAEKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x6203B30", Offset = "0x6202330", VA = "0x186203B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x85D1E0", Offset = "0x85B9E0", VA = "0x18085D1E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x8CCF80", Offset = "0x8CB780", VA = "0x1808CCF80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public int MPMABLLJLPE
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x8AD980", Offset = "0x8AC180", VA = "0x1808AD980")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x90E360", Offset = "0x90CB60", VA = "0x18090E360")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x620D090", Offset = "0x620B890", VA = "0x18620D090")]
	public void LKLOIPFCPAN(List<MLOGLFPJNHJ> KABDHDOKPBI, Matrix4x4[] JIMMKDGNPDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x620CA50", Offset = "0x620B250", VA = "0x18620CA50")]
	public static List<LHKAAMMOLAK> JLAKJAPJOGA(List<CGPIBIJBJEL> JMCDKPBIJCA, OGIGLGNLAOI MFKHINKPOED, Bounds NDJAACEKCOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x620C660", Offset = "0x620AE60", VA = "0x18620C660")]
	private JobHandle EHMMKIBGDNF(MOIGNMENBCE GOHPDNLDOCE, int APKINBBAHBB, int ONNPEHPDEML, OGIGLGNLAOI MFKHINKPOED, List<AJEDEHFJDDK> NJOJBONCPAE)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x620C4E0", Offset = "0x620ACE0", VA = "0x18620C4E0")]
	private void BPKBELIDFBK(List<AJEDEHFJDDK> NJOJBONCPAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x620D420", Offset = "0x620BC20", VA = "0x18620D420")]
	private LHKAAMMOLAK(List<AJEDEHFJDDK> NJOJBONCPAE, int APKINBBAHBB, int ONNPEHPDEML, OGIGLGNLAOI MFKHINKPOED, Bounds NDJAACEKCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x620C5F0", Offset = "0x620ADF0", VA = "0x18620C5F0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x8117F0", Offset = "0x80FFF0", VA = "0x1808117F0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x8117F0", Offset = "0x80FFF0", VA = "0x1808117F0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0xB955D0", Offset = "0xB93DD0", VA = "0x180B955D0")]
		[DebuggerHidden]
		public HHLMCKEGGGO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x6208E50", Offset = "0x6207650", VA = "0x186208E50", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x6208B50", Offset = "0x6207350", VA = "0x186208B50", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x6208B00", Offset = "0x6207300", VA = "0x186208B00")]
		private void EHFOANOMIIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x6208E10", Offset = "0x6207610", VA = "0x186208E10", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x6208D70", Offset = "0x6207570", VA = "0x186208D70", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x6208D70", Offset = "0x6207570", VA = "0x186208D70", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x620D850", Offset = "0x620C050", VA = "0x18620D850")]
	public static OCHICALHIDA BICODEPLJOC(FBHOACDOOMO PHBHEFAPHDL, LPEOPNPNMLE GLHCHJGKEGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x620ECD0", Offset = "0x620D4D0", VA = "0x18620ECD0")]
	private OCHICALHIDA(FBHOACDOOMO PHBHEFAPHDL, LPEOPNPNMLE GLHCHJGKEGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x620E7C0", Offset = "0x620CFC0", VA = "0x18620E7C0")]
	public void LIEFKNGBAEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x620E750", Offset = "0x620CF50", VA = "0x18620E750")]
	[IteratorStateMachine(typeof(HHLMCKEGGGO))]
	public IEnumerable<Renderer> KCELAAPDHFG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x620DC00", Offset = "0x620C400", VA = "0x18620DC00", Slot = "4")]
	public void CEMJONFHNGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x620E6B0", Offset = "0x620CEB0", VA = "0x18620E6B0")]
	private void JHMKMDJBEJC(Vector3 JCLAAMDIJKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x620D9C0", Offset = "0x620C1C0", VA = "0x18620D9C0")]
	public void CCMEEJNHHBN()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class PFBBJKPLBFC
{
	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
	public PFBBJKPLBFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0xBC23C0", Offset = "0xBC0BC0", VA = "0x180BC23C0")]
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
