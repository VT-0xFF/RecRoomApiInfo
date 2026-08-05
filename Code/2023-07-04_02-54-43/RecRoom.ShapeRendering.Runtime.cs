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
public interface PBONPNHJBDI
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	PNANKMAHAII KCHGKMPBAJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	AGLNCJKAOKJ KCHGKMPBAJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	GEGBLCNJOAO KCHGKMPBAJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class AOEMALMPDDL : ECGBJMIJCHB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private const byte MKDPJOHIODB = byte.MaxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private byte KFELHLANOAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly List<SkinnedShapeRenderer>[] JMHIKFCNLLH;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int OLJNMBGGJMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9B80A0", Offset = "0x9B66A0", VA = "0x1809B80A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xA3CD60", Offset = "0xA3B360", VA = "0x180A3CD60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int PCEEEKJHCEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9B6140", Offset = "0x9B4740", VA = "0x1809B6140", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x11C1700", Offset = "0x11BFD00", VA = "0x1811C1700")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public float DGLFNCJECFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xBC8AB0", Offset = "0xBC70B0", VA = "0x180BC8AB0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xBC8AC0", Offset = "0xBC70C0", VA = "0x180BC8AC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public float OBOOHBLNJBM
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x958230", Offset = "0x956830", VA = "0x180958230", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x958360", Offset = "0x956960", VA = "0x180958360")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public List<SkinnedShapeRenderer> HGMBBDHONDK
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5ED7D20", Offset = "0x5ED6320", VA = "0x185ED7D20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public List<SkinnedShapeRenderer> PEJBMNIHNIE
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5ED7DC0", Offset = "0x5ED63C0", VA = "0x185ED7DC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public GameObject PACKEMKPJIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x86F1C0", Offset = "0x86D7C0", VA = "0x18086F1C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA3CD70", Offset = "0xA3B370", VA = "0x180A3CD70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public byte OKMNBBGLAEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5ED7BC0", Offset = "0x5ED61C0", VA = "0x185ED7BC0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5ED7E00", Offset = "0x5ED6400", VA = "0x185ED7E00")]
	public AOEMALMPDDL(List<LBHHKKKNGJP> DJEBDPNFKNK, List<LBHHKKKNGJP> BOCPAPEDNGJ, List<BCMKHJJBBNL> PCNGFFMIJCF, Material GMIIJPABJKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5ED7C10", Offset = "0x5ED6210", VA = "0x185ED7C10")]
	private int IPDPBAEOOGB(List<LBHHKKKNGJP> IDFMOKEDHMP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5ED7940", Offset = "0x5ED5F40", VA = "0x185ED7940")]
	private void CHOMCPGOOGM(int JJFMGIPDJAG, bool FGOINGEANAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5ED78A0", Offset = "0x5ED5EA0", VA = "0x185ED78A0")]
	public void BKBKPAEHFKK(Vector3 NFGJCANCOPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5ED7A90", Offset = "0x5ED6090", VA = "0x185ED7A90", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5ED7D80", Offset = "0x5ED6380", VA = "0x185ED7D80")]
	public void MANEJBGMPCA(Transform EFCFPEEEKJH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
internal class IENGFCCHEBH : AGLNCJKAOKJ
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	private struct DHHFAFNOMHA : JAAEDJCPHGC, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private NFOKMFLBKAE BIDOMMGPLKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private JobHandle OAGOIKMJJAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private LGKJKEDBLNF NKHNHFEPEIF;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x5EDF720", Offset = "0x5EDDD20", VA = "0x185EDF720")]
		public DHHFAFNOMHA(NFOKMFLBKAE BIDOMMGPLKN, JobHandle OAGOIKMJJAE, LGKJKEDBLNF NKHNHFEPEIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x37A36D0", Offset = "0x37A1CD0", VA = "0x1837A36D0")]
		public bool EGOPANFHJLK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5EDF6F0", Offset = "0x5EDDCF0", VA = "0x185EDF6F0", Slot = "4")]
		public NFOKMFLBKAE LOJGLKLMFMO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x5EDF6A0", Offset = "0x5EDDCA0", VA = "0x185EDF6A0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public readonly IAIPLPDKNJH DFGNNPLGGHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private int[] CFCAKNCILOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private float JAMDIMGLLJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private Hash128 GABJAPKDGOL;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override IJLHFJFPNEI MCJNEDEMCIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5EE1DA0", Offset = "0x5EE03A0", VA = "0x185EE1DA0", Slot = "17")]
		get
		{
			return default(IJLHFJFPNEI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private Vector3 DBDOJPAEODH
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5EE2DD0", Offset = "0x5EE13D0", VA = "0x185EE2DD0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	protected override Hash128 ILGJJOMADLF
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5EE3110", Offset = "0x5EE1710", VA = "0x185EE3110", Slot = "22")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5EE3230", Offset = "0x5EE1830", VA = "0x185EE3230")]
	public IENGFCCHEBH(PNANKMAHAII MPEICFNBKOF, IAIPLPDKNJH GOMDNNCBLHP, bool MLABPPIGNNK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5EE1930", Offset = "0x5EDFF30", VA = "0x185EE1930", Slot = "16")]
	public override bool DENGKAKNCDG(BCMKHJJBBNL MPEICFNBKOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5EE2990", Offset = "0x5EE0F90", VA = "0x185EE2990", Slot = "18")]
	public override int IPDPBAEOOGB(AJMIIENAIMD NMBGPIJJDOH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5EE0ED0", Offset = "0x5EDF4D0", VA = "0x185EE0ED0", Slot = "19")]
	public override int AHBJANNINLD(AJMIIENAIMD NMBGPIJJDOH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5EE2B10", Offset = "0x5EE1110", VA = "0x185EE2B10")]
	private int KOENPOAJDOD(AJMIIENAIMD NMBGPIJJDOH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5EE11A0", Offset = "0x5EDF7A0", VA = "0x185EE11A0", Slot = "20")]
	public override void DCCNCGEHENP(AJMIIENAIMD NMBGPIJJDOH, NAANNFELKCE MBKPMDNMPHF, int CAMOHJDBANN = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5EE2A40", Offset = "0x5EE1040", VA = "0x185EE2A40", Slot = "21")]
	public override BCMKHJJBBNL JKDPHLFMBOE()
	{
		return default(BCMKHJJBBNL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5EE0F80", Offset = "0x5EDF580", VA = "0x185EE0F80", Slot = "23")]
	public override NBKBKHALLBP CLFNDCPKCLD()
	{
		return default(NBKBKHALLBP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5EE2170", Offset = "0x5EE0770", VA = "0x185EE2170", Slot = "24")]
	public override JAAEDJCPHGC FHKCOFAMMKE(AJMIIENAIMD NMBGPIJJDOH, JobHandle OAGOIKMJJAE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class PNANKMAHAII : KFJPLLHMCBD, ABFFBOBFCEA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class OMMNGLJKHHD : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public PNANKMAHAII <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x86F2B0", Offset = "0x86D8B0", VA = "0x18086F2B0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x86F2B0", Offset = "0x86D8B0", VA = "0x18086F2B0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x9F3CA0", Offset = "0x9F22A0", VA = "0x1809F3CA0")]
		[DebuggerHidden]
		public OMMNGLJKHHD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x5EE78A0", Offset = "0x5EE5EA0", VA = "0x185EE78A0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x5EE7290", Offset = "0x5EE5890", VA = "0x185EE7290", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x5EE7770", Offset = "0x5EE5D70", VA = "0x185EE7770")]
		private void PIAHDKPIMOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x5EE7240", Offset = "0x5EE5840", VA = "0x185EE7240")]
		private void MIAFNIDKODF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x5EE71F0", Offset = "0x5EE57F0", VA = "0x185EE71F0")]
		private void JKNKKKGJODF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x5EE7860", Offset = "0x5EE5E60", VA = "0x185EE7860", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x5EE77C0", Offset = "0x5EE5DC0", VA = "0x185EE77C0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x5EE77C0", Offset = "0x5EE5DC0", VA = "0x185EE77C0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class NDCBGAALMJD : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public PNANKMAHAII <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x86F2B0", Offset = "0x86D8B0", VA = "0x18086F2B0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x86F2B0", Offset = "0x86D8B0", VA = "0x18086F2B0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x9F3CA0", Offset = "0x9F22A0", VA = "0x1809F3CA0")]
		[DebuggerHidden]
		public NDCBGAALMJD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x5EE7110", Offset = "0x5EE5710", VA = "0x185EE7110", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x5EE6CA0", Offset = "0x5EE52A0", VA = "0x185EE6CA0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x5EE6FE0", Offset = "0x5EE55E0", VA = "0x185EE6FE0")]
		private void PIAHDKPIMOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x5EE6C50", Offset = "0x5EE5250", VA = "0x185EE6C50")]
		private void MIAFNIDKODF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x5EE70D0", Offset = "0x5EE56D0", VA = "0x185EE70D0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x5EE7030", Offset = "0x5EE5630", VA = "0x185EE7030", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x5EE7030", Offset = "0x5EE5630", VA = "0x185EE7030", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly IMPMDELOJIC ELCDNMAJGOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly List<AGLNCJKAOKJ> IDMEBNGIDBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private List<ClusterMeshRenderer> LINICJEKCPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private BatchedMeshRenderer JBCDFLNNAOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private bool BHFCKKLOMLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly bool AMIOMNHJJAD;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IEnumerable<MKFBHDAPPLM> BGLFBGKDJKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x86F2B0", Offset = "0x86D8B0", VA = "0x18086F2B0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int PENMAKACAKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x5EE8200", Offset = "0x5EE6800", VA = "0x185EE8200", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public BCMKHJJBBNL KHLDNGFIPFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x5EE8240", Offset = "0x5EE6840", VA = "0x185EE8240", Slot = "7")]
		get
		{
			return default(BCMKHJJBBNL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public List<SkinnedShapeRenderer> BKNKHIHPAPD
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x944080", Offset = "0x942680", VA = "0x180944080")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x943FA0", Offset = "0x9425A0", VA = "0x180943FA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5EE7EB0", Offset = "0x5EE64B0", VA = "0x185EE7EB0")]
	private bool DENIALLLIPO(AGLNCJKAOKJ DMDEOMEMHBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5EE9130", Offset = "0x5EE7730", VA = "0x185EE9130")]
	private static bool PFCCJMPJLON(AGLNCJKAOKJ DMDEOMEMHBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5EE9150", Offset = "0x5EE7750", VA = "0x185EE9150")]
	public PNANKMAHAII(IMPMDELOJIC GOMDNNCBLHP, bool IKBGFEODAKO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5EE7EE0", Offset = "0x5EE64E0", VA = "0x185EE7EE0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5EE8F00", Offset = "0x5EE7500", VA = "0x185EE8F00")]
	public void PEECNHFNIGK(AGLNCJKAOKJ DMDEOMEMHBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5EE8060", Offset = "0x5EE6660", VA = "0x185EE8060")]
	public void FAKCPBGGFBC(AGLNCJKAOKJ DMDEOMEMHBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5EE8A60", Offset = "0x5EE7060", VA = "0x185EE8A60", Slot = "4")]
	public void PBGPAOKIAAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5EE7C60", Offset = "0x5EE6260", VA = "0x185EE7C60")]
	public void BNCEMHGMHAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5EE7A30", Offset = "0x5EE6030", VA = "0x185EE7A30")]
	private void BCEGLNODBKD(List<AGLNCJKAOKJ> IDMEBNGIDBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5EE8A00", Offset = "0x5EE7000", VA = "0x185EE8A00")]
	private static Material ODJJDGJACHD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5EE7BC0", Offset = "0x5EE61C0", VA = "0x185EE7BC0")]
	private void BCEGLNODBKD(AGLNCJKAOKJ DMDEOMEMHBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5EE8370", Offset = "0x5EE6970", VA = "0x185EE8370")]
	private void MINEBJJLCHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5EE8450", Offset = "0x5EE6A50", VA = "0x185EE8450")]
	public void NNMIJFAAEEE(bool CNCJMDJPDJA, bool KEJONGIFAPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5EE79A0", Offset = "0x5EE5FA0", VA = "0x185EE79A0")]
	protected void ANCKDKKEHJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5EE8300", Offset = "0x5EE6900", VA = "0x185EE8300")]
	[IteratorStateMachine(typeof(OMMNGLJKHHD))]
	public IEnumerable<Renderer> LKCFNGCCPFP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5EE8190", Offset = "0x5EE6790", VA = "0x185EE8190")]
	[IteratorStateMachine(typeof(NDCBGAALMJD))]
	public IEnumerable<Renderer> HNMDMOFAJON()
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
		[Cpp2IlInjected.Address(RVA = "0x5EE9240", Offset = "0x5EE7840", VA = "0x185EE9240")]
		public ShapeRendererConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[DefaultMember("Item")]
public class NBNEOHCNDEK : PAANCIHNAEA, IDisposable, PBONPNHJBDI
{
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static readonly CMJEFMOJNAO NJCJMLIIBBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly PBEEGGOPKBM<OIMANMOLEGK, PNANKMAHAII> IAPIPHANKKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly PBEEGGOPKBM<JEMILGJEDAD, AGLNCJKAOKJ> IDMEBNGIDBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly PBEEGGOPKBM<DNGODNIGKOG, GEGBLCNJOAO> IDCNLENPLKJ;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public PNANKMAHAII KCHGKMPBAJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x5EE5AD0", Offset = "0x5EE40D0", VA = "0x185EE5AD0", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public AGLNCJKAOKJ KCHGKMPBAJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x5EE5A70", Offset = "0x5EE4070", VA = "0x185EE5A70", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public GEGBLCNJOAO KCHGKMPBAJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x5EE5A10", Offset = "0x5EE4010", VA = "0x185EE5A10", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public bool MLFENMPCFPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xA62EC0", Offset = "0xA614C0", VA = "0x180A62EC0", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0xA63250", Offset = "0xA61850", VA = "0x180A63250")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5EE6870", Offset = "0x5EE4E70", VA = "0x185EE6870")]
	public NBNEOHCNDEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5EE5C00", Offset = "0x5EE4200", VA = "0x185EE5C00", Slot = "21")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5EE6300", Offset = "0x5EE4900", VA = "0x185EE6300", Slot = "4")]
	public OIMANMOLEGK LLBEOGNNJON(IMPMDELOJIC GOMDNNCBLHP)
	{
		return default(OIMANMOLEGK);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5EE6300", Offset = "0x5EE4900", VA = "0x185EE6300", Slot = "5")]
	public OIMANMOLEGK LLBEOGNNJON(IMPMDELOJIC GOMDNNCBLHP, bool IKBGFEODAKO)
	{
		return default(OIMANMOLEGK);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5EE5BA0", Offset = "0x5EE41A0", VA = "0x185EE5BA0", Slot = "6")]
	public void CDJAEFGGBFF(OIMANMOLEGK MPEICFNBKOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5EE64D0", Offset = "0x5EE4AD0", VA = "0x185EE64D0", Slot = "7")]
	public void MOGCAGPABHD(OIMANMOLEGK MPEICFNBKOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5EE5CF0", Offset = "0x5EE42F0", VA = "0x185EE5CF0", Slot = "8")]
	public JEMILGJEDAD ENNDKMJGGHB(OIMANMOLEGK MPEICFNBKOF, IAIPLPDKNJH GOMDNNCBLHP)
	{
		return default(JEMILGJEDAD);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5EE66A0", Offset = "0x5EE4CA0", VA = "0x185EE66A0", Slot = "9")]
	public JEMILGJEDAD PJMPLEGKBMI(OIMANMOLEGK MPEICFNBKOF, OCKEKKALGGN GOMDNNCBLHP)
	{
		return default(JEMILGJEDAD);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5EE6610", Offset = "0x5EE4C10", VA = "0x185EE6610", Slot = "11")]
	public void OBGBCOCEIBG(JEMILGJEDAD DMDEOMEMHBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x5EE65B0", Offset = "0x5EE4BB0", VA = "0x185EE65B0", Slot = "10")]
	public void NJJGPMJKPMA(JEMILGJEDAD DMDEOMEMHBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5EE6210", Offset = "0x5EE4810", VA = "0x185EE6210", Slot = "20")]
	public IEnumerable<Renderer> IJHPLCHOGHC(OIMANMOLEGK MPEICFNBKOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5EE6280", Offset = "0x5EE4880", VA = "0x185EE6280", Slot = "12")]
	public DNGODNIGKOG JECLCGJBNNC(JCFPDLIAMHL GOMDNNCBLHP)
	{
		return default(DNGODNIGKOG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x5EE5B30", Offset = "0x5EE4130", VA = "0x185EE5B30", Slot = "14")]
	public void BIIBGGIMFMM(DNGODNIGKOG JPFJNDAJMLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5EE6410", Offset = "0x5EE4A10", VA = "0x185EE6410", Slot = "16")]
	public Task LNCOLDCFDJO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5EE5C90", Offset = "0x5EE4290", VA = "0x185EE5C90", Slot = "17")]
	public Task EHPFAIHEPCI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5EE6550", Offset = "0x5EE4B50", VA = "0x185EE6550", Slot = "18")]
	public Task NBPGIJDEIEG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x3798AC0", Offset = "0x37970C0", VA = "0x183798AC0", Slot = "19")]
	public void MEFCAFPPCNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5EE6470", Offset = "0x5EE4A70", VA = "0x185EE6470", Slot = "13")]
	public void LOPBHDDPLEI(DNGODNIGKOG JPFJNDAJMLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5EE5E20", Offset = "0x5EE4420", VA = "0x185EE5E20", Slot = "25")]
	public CBNDEKAKIED FKIIEJCGBJI(BCMKHJJBBNL CCEOLMAOMBL, IEnumerable<JEMILGJEDAD> IDMEBNGIDBL, int KPBIJIGNNAH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface INGMDJJLCIJ
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NAJCEJDDPPM(CJIPLNKDHLJ LFBJHCMDIAE, Renderer JBALEODCGHB, int GKFIMJBKFJA);

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EBCPDBKLBGN(Renderer JBALEODCGHB, BMIPBFFJFLC NBHCEJNEIJK, Vector3 LEMFACOEOBJ, Vector3 IHNNAJAEDFM, Vector3 GHBLLDLOCIH, float LADEPNLNEBB, float GCHGJDPJJML, float FCDMONOEHLC = -1f, [Optional] Color? OOJLGEBJDPI, [Optional] IReadOnlyList<Camera> GKKJMCFGAAM);

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NAKHAKLOGMA(Renderer JBALEODCGHB, int GKFIMJBKFJA);

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int CJOKCCAJILA();

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OACCCKIKLJF(int HDAJBNGFIFE, CCEOOFIGOLM LFBJHCMDIAE, Renderer JBALEODCGHB, int GKFIMJBKFJA);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class DEAEKMECJFL : BOLAEFFCJHJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private class HBPFJIEKCKG : EIIBMGCHBKN<int>
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x5EE0E80", Offset = "0x5EDF480", VA = "0x185EE0E80")]
		public HBPFJIEKCKG(string HNPIEGONNBC)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly INGMDJJLCIJ LILLGJLCKEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly PBONPNHJBDI BNHBCNEMEMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private MeshRenderer PADLMIIIOPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private HBPFJIEKCKG DBGDGNIFGKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private bool DHBPBILBCAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private MeshRenderer HPICOKNEALL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private HBPFJIEKCKG BJCHGIEIFKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private bool EJALHNNDEKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private MeshRenderer KHHALFNAPHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private HBPFJIEKCKG IEPHPGBJNME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private bool OCBEMDEOMOL;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5EDF650", Offset = "0x5EDDC50", VA = "0x185EDF650")]
	public DEAEKMECJFL(INGMDJJLCIJ CHDDFNBHKOL, PBONPNHJBDI BNHBCNEMEMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x5EDDD50", Offset = "0x5EDC350", VA = "0x185EDDD50", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x5EDEB80", Offset = "0x5EDD180", VA = "0x185EDEB80")]
	private void LAGAHADNEKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x5EDDF20", Offset = "0x5EDC520", VA = "0x185EDDF20", Slot = "4")]
	public void FKLNGIDCJEG(OIMANMOLEGK MPEICFNBKOF, CCEOOFIGOLM NGNOCIABAAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x5EDE120", Offset = "0x5EDC720", VA = "0x185EDE120", Slot = "5")]
	public void FKLNGIDCJEG(JEMILGJEDAD DMDEOMEMHBE, CCEOOFIGOLM NGNOCIABAAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x5EDDC20", Offset = "0x5EDC220", VA = "0x185EDDC20", Slot = "6")]
	public void DHNEHIAIAEI(JEMILGJEDAD DMDEOMEMHBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x5EDE980", Offset = "0x5EDCF80", VA = "0x185EDE980", Slot = "7")]
	public void IKHOFJJICHE(JEMILGJEDAD DMDEOMEMHBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x5EDEAA0", Offset = "0x5EDD0A0", VA = "0x185EDEAA0", Slot = "21")]
	public void KMOIBOOMKLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x129B5B0", Offset = "0x1299BB0", VA = "0x18129B5B0", Slot = "8")]
	public void KPAGLCOOJEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5EDDAB0", Offset = "0x5EDC0B0", VA = "0x185EDDAB0", Slot = "9")]
	public void AODINBECIBE(CCEOOFIGOLM NGNOCIABAAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5EDE480", Offset = "0x5EDCA80", VA = "0x185EDE480", Slot = "10")]
	public void IKGPEOGLGLN(OIMANMOLEGK MPEICFNBKOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x5EDE630", Offset = "0x5EDCC30", VA = "0x185EDE630", Slot = "11")]
	public void IKGPEOGLGLN(JEMILGJEDAD DMDEOMEMHBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x5EDEF90", Offset = "0x5EDD590", VA = "0x185EDEF90", Slot = "12")]
	public void MLAOCLDLPFD(OIMANMOLEGK MPEICFNBKOF, CJIPLNKDHLJ LFBJHCMDIAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x5EDF140", Offset = "0x5EDD740", VA = "0x185EDF140", Slot = "13")]
	public void MLAOCLDLPFD(JEMILGJEDAD DMDEOMEMHBE, CJIPLNKDHLJ LFBJHCMDIAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x5EDDA70", Offset = "0x5EDC070", VA = "0x185EDDA70", Slot = "22")]
	public void AKJJLNDBPIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x5EDEAE0", Offset = "0x5EDD0E0", VA = "0x185EDEAE0", Slot = "14")]
	public void KPKFFCMNEBF(JEMILGJEDAD DMDEOMEMHBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x5EDD270", Offset = "0x5EDB870", VA = "0x185EDD270", Slot = "15")]
	public void AGENCJDNGBE(JEMILGJEDAD DMDEOMEMHBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0xADA4E0", Offset = "0xAD8AE0", VA = "0x180ADA4E0", Slot = "16")]
	public void PCHJJEDBEEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x5EDE340", Offset = "0x5EDC940", VA = "0x185EDE340", Slot = "17")]
	public void HPGPBMLDLPO(CJIPLNKDHLJ LFBJHCMDIAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x5EDF330", Offset = "0x5EDD930", VA = "0x185EDF330")]
	private void NACNJNMCKKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x5EDEDD0", Offset = "0x5EDD3D0", VA = "0x185EDEDD0")]
	public void MLAOCLDLPFD(JEMILGJEDAD DMDEOMEMHBE, CJIPLNKDHLJ LFBJHCMDIAE, bool OJLIHLDLBPE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x5EDF580", Offset = "0x5EDDB80", VA = "0x185EDF580")]
	private void NAJCEJDDPPM(CJIPLNKDHLJ LFBJHCMDIAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x5EDD700", Offset = "0x5EDBD00", VA = "0x185EDD700", Slot = "18")]
	public void AHGJCMGLABF(OIMANMOLEGK MPEICFNBKOF, Vector3 LEMFACOEOBJ, Vector3 IHNNAJAEDFM, Vector3 GHBLLDLOCIH, float LADEPNLNEBB, float GCHGJDPJJML, IReadOnlyList<Camera> KHPMPNAJBKO, BMIPBFFJFLC NBHCEJNEIJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x5EDD300", Offset = "0x5EDB900", VA = "0x185EDD300", Slot = "19")]
	public void AHGJCMGLABF(DNGODNIGKOG JPFJNDAJMLM, Vector3 LEMFACOEOBJ, Vector3 IHNNAJAEDFM, Vector3 GHBLLDLOCIH, float LADEPNLNEBB, float GCHGJDPJJML)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class MCBOMLOBMNL
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class GCGMLLJPLCH : IEnumerable<CLFBOBCDBKD>, IEnumerable, IEnumerator<CLFBOBCDBKD>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private CLFBOBCDBKD <>2__current;

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
		private CLFBOBCDBKD System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.PrimitiveShapeMeshData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x86F2B0", Offset = "0x86D8B0", VA = "0x18086F2B0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x86F2B0", Offset = "0x86D8B0", VA = "0x18086F2B0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x9F3CA0", Offset = "0x9F22A0", VA = "0x1809F3CA0")]
		[DebuggerHidden]
		public GCGMLLJPLCH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x5EDF770", Offset = "0x5EDDD70", VA = "0x185EDF770", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x5EDF8E0", Offset = "0x5EDDEE0", VA = "0x185EDF8E0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x5EDF850", Offset = "0x5EDDE50", VA = "0x185EDF850", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<CLFBOBCDBKD> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.PrimitiveShapeMeshData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x5EDF850", Offset = "0x5EDDE50", VA = "0x185EDF850", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public const int FGANEOPNIFF = 3;

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private static CLFBOBCDBKD[][] PACCABINHGK;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private static KKHEBCBKOFM CLDGJLFMKPD;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public static ShapeRendererConfig HAINCBIDJGD;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public static ComputeShader BGEKPFLAPJP
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x5EE5420", Offset = "0x5EE3A20", VA = "0x185EE5420")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public static SkinnedShapeRenderer COEADBKJPIB
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x5EE48C0", Offset = "0x5EE2EC0", VA = "0x185EE48C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x5EE4650", Offset = "0x5EE2C50", VA = "0x185EE4650")]
	public static Mesh ANFAOAKKHNA(OFIALCJJJEA EDICJKNDIHG, int NMBGPIJJDOH = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x5EE5240", Offset = "0x5EE3840", VA = "0x185EE5240")]
	public static int GBPCIKBEBOI(OFIALCJJJEA EDICJKNDIHG, int NMBGPIJJDOH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x5EE52C0", Offset = "0x5EE38C0", VA = "0x185EE52C0")]
	public static KKHEBCBKOFM LCMIBEOOLGK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x5EE5260", Offset = "0x5EE3860", VA = "0x185EE5260")]
	[IteratorStateMachine(typeof(GCGMLLJPLCH))]
	private static IEnumerable<CLFBOBCDBKD> LADKJOHEILE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x5EE4CC0", Offset = "0x5EE32C0", VA = "0x185EE4CC0")]
	public static CLFBOBCDBKD DNAKMHLDKMJ(OFIALCJJJEA EDICJKNDIHG, int NMBGPIJJDOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x5EE5490", Offset = "0x5EE3A90", VA = "0x185EE5490")]
	public static bool PLCNMEPPHGN(this OFIALCJJJEA EDICJKNDIHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x5EE4710", Offset = "0x5EE2D10", VA = "0x185EE4710")]
	public static void BELMDHBMAEB(OFIALCJJJEA EDICJKNDIHG, float3 PLFNJFGJPKM, out HNEJDDEAABK HFOPCAIDIGH, out float3 AEBKOKMDNNM, out float MGJDEEPMOLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x5EE4930", Offset = "0x5EE2F30", VA = "0x185EE4930")]
	public static void DJFMGEJGHIH(Vector3 PLFNJFGJPKM, OFIALCJJJEA EDICJKNDIHG, out Vector3 AEBKOKMDNNM, out float MGJDEEPMOLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x5EE5250", Offset = "0x5EE3850", VA = "0x185EE5250")]
	[BEIEJGBHBAP(HEKNLLBMOLL.ExitingPlayMode, 0)]
	private static void INPAMEAFCEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x5EE5020", Offset = "0x5EE3620", VA = "0x185EE5020")]
	[BEIEJGBHBAP(HEKNLLBMOLL.ExitingPlayMode, 0)]
	private static void FAFLBPDGKJJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public abstract class AGLNCJKAOKJ : INCOBILLEHJ, MKFBHDAPPLM, KBBJMIAJCBN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public readonly PNANKMAHAII PACKEMKPJIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	protected Bounds CNEPEGBLDLL;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public Bounds PPFJBPLBLCI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x1187EE0", Offset = "0x11864E0", VA = "0x181187EE0", Slot = "4")]
		get
		{
			return default(Bounds);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public virtual IJLHFJFPNEI MCJNEDEMCIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x5ED77E0", Offset = "0x5ED5DE0", VA = "0x185ED77E0", Slot = "17")]
		get
		{
			return default(IJLHFJFPNEI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public bool AMIOMNHJJAD
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x9584D0", Offset = "0x956AD0", VA = "0x1809584D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x958220", Offset = "0x956820", VA = "0x180958220")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	protected abstract Hash128 ILGJJOMADLF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int AJMICFDENII
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x923800", Offset = "0x921E00", VA = "0x180923800", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public BFAIFGPPKON IOPOAIJNKOL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x944080", Offset = "0x942680", VA = "0x180944080")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x943FA0", Offset = "0x9425A0", VA = "0x180943FA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public bool KPOIHIHCPPM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x2793560", Offset = "0x2791B60", VA = "0x182793560")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x959E30", Offset = "0x958430", VA = "0x180959E30")]
	protected AGLNCJKAOKJ(PNANKMAHAII MPEICFNBKOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x5ED7680", Offset = "0x5ED5C80", VA = "0x185ED7680", Slot = "15")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x921810", Offset = "0x91FE10", VA = "0x180921810", Slot = "16")]
	public virtual bool DENGKAKNCDG(BCMKHJJBBNL MPEICFNBKOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "18")]
	public abstract int IPDPBAEOOGB(AJMIIENAIMD NMBGPIJJDOH);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "19")]
	public abstract int AHBJANNINLD(AJMIIENAIMD NMBGPIJJDOH);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "20")]
	public abstract void DCCNCGEHENP(AJMIIENAIMD NMBGPIJJDOH, NAANNFELKCE MBKPMDNMPHF, int CAMOHJDBANN = -1);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "21")]
	public abstract BCMKHJJBBNL JKDPHLFMBOE();

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x5ED77B0", Offset = "0x5ED5DB0", VA = "0x185ED77B0", Slot = "11")]
	public Hash128 EPKKJDMKNGB(int NMBGPIJJDOH)
	{
		return default(Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "23")]
	public abstract NBKBKHALLBP CLFNDCPKCLD();

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "24")]
	public abstract JAAEDJCPHGC FHKCOFAMMKE(AJMIIENAIMD NMBGPIJJDOH, JobHandle OAGOIKMJJAE);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x5ED7870", Offset = "0x5ED5E70", VA = "0x185ED7870", Slot = "10")]
	public JAAEDJCPHGC FKIIEJCGBJI(int NMBGPIJJDOH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class CGEEHPBOCJD : AGLNCJKAOKJ
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	private struct MJPOEJMBJNJ : JAAEDJCPHGC, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private NFOKMFLBKAE BIDOMMGPLKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private JobHandle OAGOIKMJJAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private HBNBEOPKJGP NKHNHFEPEIF;

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x5EE55D0", Offset = "0x5EE3BD0", VA = "0x185EE55D0")]
		public MJPOEJMBJNJ(NFOKMFLBKAE BIDOMMGPLKN, JobHandle OAGOIKMJJAE, HBNBEOPKJGP NKHNHFEPEIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x37A36D0", Offset = "0x37A1CD0", VA = "0x1837A36D0")]
		public bool EGOPANFHJLK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x5EE55A0", Offset = "0x5EE3BA0", VA = "0x185EE55A0", Slot = "4")]
		public NFOKMFLBKAE LOJGLKLMFMO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x5EE5550", Offset = "0x5EE3B50", VA = "0x185EE5550", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private readonly OCKEKKALGGN NKPCEGLKLAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private float JAMDIMGLLJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private Hash128 GABJAPKDGOL;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	protected override Hash128 ILGJJOMADLF
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x5EDC550", Offset = "0x5EDAB50", VA = "0x185EDC550", Slot = "22")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x5EDC670", Offset = "0x5EDAC70", VA = "0x185EDC670")]
	public CGEEHPBOCJD(PNANKMAHAII MPEICFNBKOF, OCKEKKALGGN GOMDNNCBLHP, bool IKBGFEODAKO = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x921810", Offset = "0x91FE10", VA = "0x180921810", Slot = "16")]
	public override bool DENGKAKNCDG(BCMKHJJBBNL MPEICFNBKOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x5EDC290", Offset = "0x5EDA890", VA = "0x185EDC290", Slot = "18")]
	public override int IPDPBAEOOGB(AJMIIENAIMD NMBGPIJJDOH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x5EDAEE0", Offset = "0x5ED94E0", VA = "0x185EDAEE0", Slot = "19")]
	public override int AHBJANNINLD(AJMIIENAIMD NMBGPIJJDOH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x5EDB2F0", Offset = "0x5ED98F0", VA = "0x185EDB2F0", Slot = "20")]
	public override void DCCNCGEHENP(AJMIIENAIMD NMBGPIJJDOH, NAANNFELKCE MBKPMDNMPHF, int CAMOHJDBANN = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x5EDC480", Offset = "0x5EDAA80", VA = "0x185EDC480", Slot = "21")]
	public override BCMKHJJBBNL JKDPHLFMBOE()
	{
		return default(BCMKHJJBBNL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x5EDB0D0", Offset = "0x5ED96D0", VA = "0x185EDB0D0", Slot = "23")]
	public override NBKBKHALLBP CLFNDCPKCLD()
	{
		return default(NBKBKHALLBP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x5EDB9D0", Offset = "0x5ED9FD0", VA = "0x185EDB9D0", Slot = "24")]
	public override JAAEDJCPHGC FHKCOFAMMKE(AJMIIENAIMD NMBGPIJJDOH, JobHandle OAGOIKMJJAE)
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
		private MaterialPropertyBlock HCFCNEFPDGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private LBHHKKKNGJP BIDOMMGPLKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private List<BCMKHJJBBNL> PCNGFFMIJCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private RenderTexture JCJJIOCDFAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private ComputeBuffer NOMHFIFIJLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private ComputeShader CBKKBDKPBMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private Matrix4x4[] MKBMADDJOKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private int ALBNBFOHDKC;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public MeshRenderer BAHKHODHPIM
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x86F2B0", Offset = "0x86D8B0", VA = "0x18086F2B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x920EA0", Offset = "0x91F4A0", VA = "0x180920EA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public int FJOLPMIMCKK
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x5EE9F00", Offset = "0x5EE8500", VA = "0x185EE9F00")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x5EE9270", Offset = "0x5EE7870", VA = "0x185EE9270")]
		public static List<SkinnedShapeRenderer> Create(GameObject MPEICFNBKOF, List<LBHHKKKNGJP> IDFMOKEDHMP, List<BCMKHJJBBNL> PCNGFFMIJCF, Material GMIIJPABJKD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x5EE9680", Offset = "0x5EE7C80", VA = "0x185EE9680")]
		public void Init(LBHHKKKNGJP BIDOMMGPLKN, List<BCMKHJJBBNL> PCNGFFMIJCF, Material GMIIJPABJKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x5EE9E50", Offset = "0x5EE8450", VA = "0x185EE9E50")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x5EE9DA0", Offset = "0x5EE83A0", VA = "0x185EE9DA0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x5EE9D60", Offset = "0x5EE8360", VA = "0x185EE9D60")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x5EE9B30", Offset = "0x5EE8130", VA = "0x185EE9B30")]
		private void LKKNGNBICEI(ScriptableRenderContext JHAKINLMMJL, Camera[] LCDHDMBFNMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x5EE94C0", Offset = "0x5EE7AC0", VA = "0x185EE94C0")]
		private void FCAJLFMKDJD(CommandBuffer NPMFBINEJGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x996120", Offset = "0x994720", VA = "0x180996120")]
		public SkinnedShapeRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface BIHHCGNIEBK
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	bool OLHNFCNJNNB
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Material KFCGEFJMNPP();

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Material ODJJDGJACHD();

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Material AHJHGJKIBLM();

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int CAINBDAEILI(GJALNGNNDJP FMMKEJNICFM);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int FJMBAIHGLLP(FGDIOILOGNO FMNPIGMHLPF);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OFNKGDDCAKM(GameObject IAMEECMGPIF);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void HHJFJMOMNLG(GameObject IAMEECMGPIF, bool CLKAHLMHGKK);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class CKGKOMNGCAJ
{
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static BIHHCGNIEBK EGHMJNHBHOI;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public static bool OLHNFCNJNNB
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x5EDC8B0", Offset = "0x5EDAEB0", VA = "0x185EDC8B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x5EDC860", Offset = "0x5EDAE60", VA = "0x185EDC860")]
	public static void GIAKJNOFFEF(BIHHCGNIEBK HNHGLOJGDEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x5EDC9F0", Offset = "0x5EDAFF0", VA = "0x185EDC9F0")]
	public static Material KFCGEFJMNPP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x5EDCA50", Offset = "0x5EDB050", VA = "0x185EDCA50")]
	public static Material ODJJDGJACHD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x5EDC720", Offset = "0x5EDAD20", VA = "0x185EDC720")]
	public static Material AHJHGJKIBLM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x5EDC780", Offset = "0x5EDAD80", VA = "0x185EDC780")]
	public static int CAINBDAEILI(GJALNGNNDJP FMMKEJNICFM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x5EDC7F0", Offset = "0x5EDADF0", VA = "0x185EDC7F0")]
	public static int FJMBAIHGLLP(FGDIOILOGNO FMNPIGMHLPF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x5EDCAB0", Offset = "0x5EDB0B0", VA = "0x185EDCAB0")]
	public static void OFNKGDDCAKM(GameObject IAMEECMGPIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x5EDC910", Offset = "0x5EDAF10", VA = "0x185EDC910")]
	public static void HHJFJMOMNLG(GameObject IAMEECMGPIF, bool CLKAHLMHGKK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[DefaultMember("Item")]
public class BJJCEBAPIIG : PAANCIHNAEA, IDisposable, PBONPNHJBDI
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class DCJKKGPMMPH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public BJJCEBAPIIG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public DCJKKGPMMPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x5EDCDA0", Offset = "0x5EDB3A0", VA = "0x185EDCDA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly PBEEGGOPKBM<OIMANMOLEGK, PNANKMAHAII> IAPIPHANKKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly PBEEGGOPKBM<JEMILGJEDAD, AGLNCJKAOKJ> IDMEBNGIDBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly PBEEGGOPKBM<DNGODNIGKOG, GEGBLCNJOAO> IDCNLENPLKJ;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public PNANKMAHAII KCHGKMPBAJO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x5ED8220", Offset = "0x5ED6820", VA = "0x185ED8220", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public AGLNCJKAOKJ KCHGKMPBAJO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x5ED81C0", Offset = "0x5ED67C0", VA = "0x185ED81C0", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public GEGBLCNJOAO KCHGKMPBAJO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x5ED8280", Offset = "0x5ED6880", VA = "0x185ED8280", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool MLFENMPCFPD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0xA62EC0", Offset = "0xA614C0", VA = "0x180A62EC0", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0xA63250", Offset = "0xA61850", VA = "0x180A63250")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x5EDAA20", Offset = "0x5ED9020", VA = "0x185EDAA20")]
	public BJJCEBAPIIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x5ED85D0", Offset = "0x5ED6BD0", VA = "0x185ED85D0", Slot = "21")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x5ED94E0", Offset = "0x5ED7AE0", VA = "0x185ED94E0", Slot = "4")]
	public OIMANMOLEGK LLBEOGNNJON(IMPMDELOJIC GOMDNNCBLHP)
	{
		return default(OIMANMOLEGK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x5ED94F0", Offset = "0x5ED7AF0", VA = "0x185ED94F0", Slot = "5")]
	public OIMANMOLEGK LLBEOGNNJON(IMPMDELOJIC GOMDNNCBLHP, bool IKBGFEODAKO)
	{
		return default(OIMANMOLEGK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x5ED8350", Offset = "0x5ED6950", VA = "0x185ED8350", Slot = "6")]
	public void CDJAEFGGBFF(OIMANMOLEGK MPEICFNBKOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x5ED99F0", Offset = "0x5ED7FF0", VA = "0x185ED99F0", Slot = "7")]
	public void MOGCAGPABHD(OIMANMOLEGK MPEICFNBKOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x5ED88D0", Offset = "0x5ED6ED0", VA = "0x185ED88D0", Slot = "8")]
	public JEMILGJEDAD ENNDKMJGGHB(OIMANMOLEGK MPEICFNBKOF, IAIPLPDKNJH GOMDNNCBLHP)
	{
		return default(JEMILGJEDAD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x5EDA520", Offset = "0x5ED8B20", VA = "0x185EDA520", Slot = "9")]
	public JEMILGJEDAD PJMPLEGKBMI(OIMANMOLEGK MPEICFNBKOF, OCKEKKALGGN GOMDNNCBLHP)
	{
		return default(JEMILGJEDAD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x5EDA120", Offset = "0x5ED8720", VA = "0x185EDA120", Slot = "11")]
	public void OBGBCOCEIBG(JEMILGJEDAD DMDEOMEMHBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x5ED9EA0", Offset = "0x5ED84A0", VA = "0x185ED9EA0", Slot = "10")]
	public void NJJGPMJKPMA(JEMILGJEDAD DMDEOMEMHBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x5ED93F0", Offset = "0x5ED79F0", VA = "0x185ED93F0", Slot = "20")]
	public IEnumerable<Renderer> IJHPLCHOGHC(OIMANMOLEGK MPEICFNBKOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x5ED9460", Offset = "0x5ED7A60", VA = "0x185ED9460", Slot = "12")]
	public DNGODNIGKOG JECLCGJBNNC(JCFPDLIAMHL GOMDNNCBLHP)
	{
		return default(DNGODNIGKOG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x5ED82E0", Offset = "0x5ED68E0", VA = "0x185ED82E0", Slot = "14")]
	public void BIIBGGIMFMM(DNGODNIGKOG JPFJNDAJMLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x5ED9790", Offset = "0x5ED7D90", VA = "0x185ED9790", Slot = "16")]
	public Task LNCOLDCFDJO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x5ED8770", Offset = "0x5ED6D70", VA = "0x185ED8770", Slot = "17")]
	public Task EHPFAIHEPCI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x5ED9D80", Offset = "0x5ED8380", VA = "0x185ED9D80", Slot = "18")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DCJKKGPMMPH))]
	public Task NBPGIJDEIEG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x5ED9960", Offset = "0x5ED7F60", VA = "0x185ED9960", Slot = "19")]
	public void MEFCAFPPCNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x5ED9900", Offset = "0x5ED7F00", VA = "0x185ED9900", Slot = "13")]
	public void LOPBHDDPLEI(DNGODNIGKOG JPFJNDAJMLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x5ED8DD0", Offset = "0x5ED73D0", VA = "0x185ED8DD0", Slot = "25")]
	public CBNDEKAKIED FKIIEJCGBJI(BCMKHJJBBNL CCEOLMAOMBL, IEnumerable<JEMILGJEDAD> IDMEBNGIDBL, int KPBIJIGNNAH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class LBHHKKKNGJP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	private struct NDIDNLEFBBK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public NAANNFELKCE FLMBHGOIJIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public BCMKHJJBBNL OINHGJKNJGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public int GHHLMPKDPPA;
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class OIPLPLEDBDK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public LBHHKKKNGJP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public int numVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public int numIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public AJMIIENAIMD lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public List<NDIDNLEFBBK> boneMeshInfos;

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public OIPLPLEDBDK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class CKHFOILFPMF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public NFOKMFLBKAE combinedMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public OIPLPLEDBDK CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public CKHFOILFPMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x5EDCB80", Offset = "0x5EDB180", VA = "0x185EDCB80")]
		internal JobHandle BLEGJCHBHJP()
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x5EDCD60", Offset = "0x5EDB360", VA = "0x185EDCD60")]
		internal void OPNIPNLCDAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x5EDCBF0", Offset = "0x5EDB1F0", VA = "0x185EDCBF0")]
		internal void IFGGBDDONII()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private int[] KIMIBJKDMAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private CDKIGDAAPNL HDOPAIMECAJ;

	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private static Matrix4x4 DCIAGLCKPHD;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public Mesh KFMKIIPNGIA
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x86D400", Offset = "0x86BA00", VA = "0x18086D400")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x943F50", Offset = "0x942550", VA = "0x180943F50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public int EPDNMCKBADG
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x944070", Offset = "0x942670", VA = "0x180944070")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x9440A0", Offset = "0x9426A0", VA = "0x1809440A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x5EE3350", Offset = "0x5EE1950", VA = "0x185EE3350")]
	public void FCAJLFMKDJD(List<BCMKHJJBBNL> ICJJCJMBKKE, Matrix4x4[] FFCGMHDNDJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x5EE36C0", Offset = "0x5EE1CC0", VA = "0x185EE36C0")]
	public static List<LBHHKKKNGJP> PJDMJLOGMBM(List<PNANKMAHAII> ICEBBKHBCND, AJMIIENAIMD NMBGPIJJDOH, Bounds DIHAGLJEBCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x5EE3D00", Offset = "0x5EE2300", VA = "0x185EE3D00")]
	private JobHandle PPFOPBMGOGP(NFOKMFLBKAE CMCFJKGKIBB, int NGAJGMAMGLO, int GGGBAIMJLOM, AJMIIENAIMD NMBGPIJJDOH, List<NDIDNLEFBBK> DCBDBFBCLMK)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x5EE35B0", Offset = "0x5EE1BB0", VA = "0x185EE35B0")]
	private void GDAMCHBEBBA(List<NDIDNLEFBBK> DCBDBFBCLMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x5EE4220", Offset = "0x5EE2820", VA = "0x185EE4220")]
	private LBHHKKKNGJP(List<NDIDNLEFBBK> DCBDBFBCLMK, int NGAJGMAMGLO, int GGGBAIMJLOM, AJMIIENAIMD NMBGPIJJDOH, Bounds DIHAGLJEBCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x5EE32E0", Offset = "0x5EE18E0", VA = "0x185EE32E0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class GEGBLCNJOAO : KFJPLLHMCBD
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class MNGEJFFMPJB : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public GEGBLCNJOAO <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x86F2B0", Offset = "0x86D8B0", VA = "0x18086F2B0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x86F2B0", Offset = "0x86D8B0", VA = "0x18086F2B0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x9F3CA0", Offset = "0x9F22A0", VA = "0x1809F3CA0")]
		[DebuggerHidden]
		public MNGEJFFMPJB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x5EE5980", Offset = "0x5EE3F80", VA = "0x185EE5980", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x5EE5630", Offset = "0x5EE3C30", VA = "0x185EE5630", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x5EE5850", Offset = "0x5EE3E50", VA = "0x185EE5850")]
		private void PIAHDKPIMOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x5EE5940", Offset = "0x5EE3F40", VA = "0x185EE5940", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x5EE58A0", Offset = "0x5EE3EA0", VA = "0x185EE58A0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x5EE58A0", Offset = "0x5EE3EA0", VA = "0x185EE58A0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly JCFPDLIAMHL BJLJDBFHMNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly PBONPNHJBDI BNHBCNEMEMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private AOEMALMPDDL JMPEBCEFGIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private List<LBHHKKKNGJP> GOJFGDJPBCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private List<LBHHKKKNGJP> LCBGEOAOPDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private GameObject FIHIAPKPFJN;

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x5EE0130", Offset = "0x5EDE730", VA = "0x185EE0130")]
	public static GEGBLCNJOAO OMIKNPIFEOP(JCFPDLIAMHL GOMDNNCBLHP, PBONPNHJBDI BNHBCNEMEMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x5EE0D80", Offset = "0x5EDF380", VA = "0x185EE0D80")]
	private GEGBLCNJOAO(JCFPDLIAMHL GOMDNNCBLHP, PBONPNHJBDI BNHBCNEMEMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x5EDFB60", Offset = "0x5EDE160", VA = "0x185EDFB60")]
	public void IBHEPNJODHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x5EE00C0", Offset = "0x5EDE6C0", VA = "0x185EE00C0")]
	[IteratorStateMachine(typeof(MNGEJFFMPJB))]
	public IEnumerable<Renderer> LKCFNGCCPFP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x5EE02A0", Offset = "0x5EDE8A0", VA = "0x185EE02A0", Slot = "4")]
	public void PBGPAOKIAAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x5EE0020", Offset = "0x5EDE620", VA = "0x185EE0020")]
	private void IBJDPMAFJBJ(Vector3 NFGJCANCOPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x5EDF920", Offset = "0x5EDDF20", VA = "0x185EDF920")]
	public void BNCEMHGMHAM()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class IMLHFCPJGKL
{
	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
	public IMLHFCPJGKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD111C0", VA = "0x180D12BC0")]
	public static string GOMDFOEHABF(byte[] CEBGDHINIFO, byte[] FGJCLMKLDKK)
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
