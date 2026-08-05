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
public interface GOHGPPMJBPM
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	BAIMDHIKFJN LOKIFJEIJCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	FALBGBLJBHC LOKIFJEIJCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	PAPAHADOAGD LOKIFJEIJCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class KDLABOBFFBI : NBPJGEHIKCH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private const byte IDAMDCIPPLG = byte.MaxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private byte DPPOJADLJFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly List<SkinnedShapeRenderer>[] HEPLNAIPENI;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int LNFLHGHBDHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x841C90", Offset = "0x840E90", VA = "0x180841C90", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x841E40", Offset = "0x841040", VA = "0x180841E40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int CKAKLPNOINK
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8F8970", Offset = "0x8F7B70", VA = "0x1808F8970", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x981950", Offset = "0x980B50", VA = "0x180981950")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public float FAIBNMCAILK
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xB0D690", Offset = "0xB0C890", VA = "0x180B0D690", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xB0DB90", Offset = "0xB0CD90", VA = "0x180B0DB90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public float LKJKCFHBMDF
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xAC3990", Offset = "0xAC2B90", VA = "0x180AC3990", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xAC39A0", Offset = "0xAC2BA0", VA = "0x180AC39A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public List<SkinnedShapeRenderer> GKNPGNCDEOO
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x60A3D30", Offset = "0x60A2F30", VA = "0x1860A3D30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public List<SkinnedShapeRenderer> CCDCBINLKMA
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x13CB2C0", Offset = "0x13CA4C0", VA = "0x1813CB2C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public GameObject HOKLBIFFMCO
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x825260", Offset = "0x824460", VA = "0x180825260")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x943020", Offset = "0x942220", VA = "0x180943020")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public byte CBGGNEANJLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x60A3DD0", Offset = "0x60A2FD0", VA = "0x1860A3DD0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x60A3E20", Offset = "0x60A3020", VA = "0x1860A3E20")]
	public KDLABOBFFBI(List<ELMCOBIOFOA> NCGHHGGNKBG, List<ELMCOBIOFOA> DNCIICKBBDN, List<PPNEKCJPIML> DCLLBMFALAJ, Material LGBCNNOGHMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x60A3900", Offset = "0x60A2B00", VA = "0x1860A3900")]
	private int CGCNCBIADOE(List<ELMCOBIOFOA> KPNONMDMBNA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x60A3B40", Offset = "0x60A2D40", VA = "0x1860A3B40")]
	private void EKPFDPGKMOG(int CKDKPDKALAL, bool KENJFDFJIKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x60A3C90", Offset = "0x60A2E90", VA = "0x1860A3C90")]
	public void GJPEMCAEKAO(Vector3 GJDHBCFOMBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x60A3A10", Offset = "0x60A2C10", VA = "0x1860A3A10", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x60A3D90", Offset = "0x60A2F90", VA = "0x1860A3D90")]
	public void MEDEKEGFEDP(Transform FLPFJNPPDNJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
internal class LFHHJNIGLIH : FALBGBLJBHC
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	private struct ODKKFOLLANF : IMEOKEOGFCN, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private PAHCOOGOOKI BOIPJLCFOOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private JobHandle JAKIGJLIHJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private LCINCKGNGGC GLIABMOAIGI;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x60AD550", Offset = "0x60AC750", VA = "0x1860AD550")]
		public ODKKFOLLANF(PAHCOOGOOKI BOIPJLCFOOL, JobHandle JAKIGJLIHJN, LCINCKGNGGC GLIABMOAIGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x41C0380", Offset = "0x41BF580", VA = "0x1841C0380")]
		public bool APOMBNLPNLG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x60AD520", Offset = "0x60AC720", VA = "0x1860AD520", Slot = "4")]
		public PAHCOOGOOKI HEEDEOJNDNP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x60AD4D0", Offset = "0x60AC6D0", VA = "0x1860AD4D0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public readonly FJEACKOCPJC PEFMNDEAOIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private int[] PMFLGAKCKII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private float AHGGGMOOALJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private Hash128 FGADBCIHFLB;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override KOLHDOIAKCN GMKGFALANAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x60A5550", Offset = "0x60A4750", VA = "0x1860A5550", Slot = "17")]
		get
		{
			return default(KOLHDOIAKCN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private Vector3 FHEHKGFAEDP
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x60A5BE0", Offset = "0x60A4DE0", VA = "0x1860A5BE0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	protected override Hash128 OCEKFMBADKF
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x60A5430", Offset = "0x60A4630", VA = "0x1860A5430", Slot = "22")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x60A69A0", Offset = "0x60A5BA0", VA = "0x1860A69A0")]
	public LFHHJNIGLIH(BAIMDHIKFJN NPDELNKHCNM, FJEACKOCPJC JCEJEOAKGOJ, bool ELBPMEHALGN = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x60A4E60", Offset = "0x60A4060", VA = "0x1860A4E60", Slot = "16")]
	public override bool BDKPNOGPEBN(PPNEKCJPIML NPDELNKHCNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x60A52D0", Offset = "0x60A44D0", VA = "0x1860A52D0", Slot = "18")]
	public override int CGCNCBIADOE(LGEOKOLGIOB DPIMGBNDIHM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x60A5380", Offset = "0x60A4580", VA = "0x1860A5380", Slot = "19")]
	public override int CMAPBIJOKPB(LGEOKOLGIOB DPIMGBNDIHM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x60A5920", Offset = "0x60A4B20", VA = "0x1860A5920")]
	private int GKAGNDMJOMI(LGEOKOLGIOB DPIMGBNDIHM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x60A6140", Offset = "0x60A5340", VA = "0x1860A6140", Slot = "20")]
	public override void JDMLOAPGBLL(LGEOKOLGIOB DPIMGBNDIHM, EDKEEFGEFAM BMBJLJBMCBK, int CGKDBDEIJHD = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x60A68D0", Offset = "0x60A5AD0", VA = "0x1860A68D0", Slot = "21")]
	public override PPNEKCJPIML MACLBGJCOOG()
	{
		return default(PPNEKCJPIML);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x60A5F20", Offset = "0x60A5120", VA = "0x1860A5F20", Slot = "23")]
	public override LMDKCNHOEKM IPDDJOOPFIC()
	{
		return default(LMDKCNHOEKM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x60A4640", Offset = "0x60A3840", VA = "0x1860A4640", Slot = "24")]
	public override IMEOKEOGFCN BCONAPFBNDP(LGEOKOLGIOB DPIMGBNDIHM, JobHandle JAKIGJLIHJN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class BAIMDHIKFJN : IMBEBLBNAAF, GLLMMNODFIN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class JDACAFOGBOF : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public BAIMDHIKFJN <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x844820", Offset = "0x843A20", VA = "0x180844820", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x844820", Offset = "0x843A20", VA = "0x180844820", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xECAD80", Offset = "0xEC9F80", VA = "0x180ECAD80")]
		[DebuggerHidden]
		public JDACAFOGBOF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x60A3800", Offset = "0x60A2A00", VA = "0x1860A3800", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x60A31F0", Offset = "0x60A23F0", VA = "0x1860A31F0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x60A31A0", Offset = "0x60A23A0", VA = "0x1860A31A0")]
		private void LNJGNFIDMML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x60A36D0", Offset = "0x60A28D0", VA = "0x1860A36D0")]
		private void PKFPAMEJFLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x60A3150", Offset = "0x60A2350", VA = "0x1860A3150")]
		private void LFOLLMCCMBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x60A37C0", Offset = "0x60A29C0", VA = "0x1860A37C0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x60A3720", Offset = "0x60A2920", VA = "0x1860A3720", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x60A3720", Offset = "0x60A2920", VA = "0x1860A3720", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class FJJCKJLLFAG : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public BAIMDHIKFJN <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x844820", Offset = "0x843A20", VA = "0x180844820", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x844820", Offset = "0x843A20", VA = "0x180844820", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xECAD80", Offset = "0xEC9F80", VA = "0x180ECAD80")]
		[DebuggerHidden]
		public FJJCKJLLFAG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x60A2120", Offset = "0x60A1320", VA = "0x1860A2120", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x60A1CB0", Offset = "0x60A0EB0", VA = "0x1860A1CB0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x60A1C60", Offset = "0x60A0E60", VA = "0x1860A1C60")]
		private void LNJGNFIDMML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x60A1FF0", Offset = "0x60A11F0", VA = "0x1860A1FF0")]
		private void PKFPAMEJFLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x60A20E0", Offset = "0x60A12E0", VA = "0x1860A20E0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x60A2040", Offset = "0x60A1240", VA = "0x1860A2040", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x60A2040", Offset = "0x60A1240", VA = "0x1860A2040", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly NIIPFPEJDIN DCNFGFDMDJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly List<FALBGBLJBHC> LKKPNMNDLOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private List<ClusterMeshRenderer> OFLNILAGBDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private BatchedMeshRenderer FEJJHIIDGAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private bool NKBJMAFDJEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly bool LPIHDBFONFF;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IEnumerable<IGFGOMOAFHG> JGDOGCINIMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x844820", Offset = "0x843A20", VA = "0x180844820", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int HHLCDBOEBAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x609D5F0", Offset = "0x609C7F0", VA = "0x18609D5F0", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public PPNEKCJPIML FHHHDKAHHLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x609E120", Offset = "0x609D320", VA = "0x18609E120", Slot = "7")]
		get
		{
			return default(PPNEKCJPIML);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public List<SkinnedShapeRenderer> APPLEDOLJFG
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8293D0", Offset = "0x8285D0", VA = "0x1808293D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8DF660", Offset = "0x8DE860", VA = "0x1808DF660")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x609E0F0", Offset = "0x609D2F0", VA = "0x18609E0F0")]
	private bool LDMKPCLBPCE(FALBGBLJBHC GJJEEFKHLDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x609E1E0", Offset = "0x609D3E0", VA = "0x18609E1E0")]
	private static bool PDMIBIIADIP(FALBGBLJBHC GJJEEFKHLDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x609EB10", Offset = "0x609DD10", VA = "0x18609EB10")]
	public BAIMDHIKFJN(NIIPFPEJDIN JCEJEOAKGOJ, bool HPFIINHEDHE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x609D960", Offset = "0x609CB60", VA = "0x18609D960", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x609E8E0", Offset = "0x609DAE0", VA = "0x18609E8E0")]
	public void PPMBLONPHPF(FALBGBLJBHC GJJEEFKHLDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x609E7B0", Offset = "0x609D9B0", VA = "0x18609E7B0")]
	public void PLKCAALIKKA(FALBGBLJBHC GJJEEFKHLDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x609DAE0", Offset = "0x609CCE0", VA = "0x18609DAE0", Slot = "4")]
	public void FHLBCHIOALE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x609D630", Offset = "0x609C830", VA = "0x18609D630")]
	public void BOOFGHHIEIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x609D400", Offset = "0x609C600", VA = "0x18609D400")]
	private void ACLKHJAMNOK(List<FALBGBLJBHC> LKKPNMNDLOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x609D590", Offset = "0x609C790", VA = "0x18609D590")]
	private static Material BCAGKCNMLEK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x609D360", Offset = "0x609C560", VA = "0x18609D360")]
	private void ACLKHJAMNOK(FALBGBLJBHC GJJEEFKHLDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x609D880", Offset = "0x609CA80", VA = "0x18609D880")]
	private void DMDMHCMJLCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x609E200", Offset = "0x609D400", VA = "0x18609E200")]
	public void PHEFPGNHIBP(bool NPNICLNKEGK, bool MNOIGGPLBNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x609DF80", Offset = "0x609D180", VA = "0x18609DF80")]
	protected void HAFGNGBJICM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x609E010", Offset = "0x609D210", VA = "0x18609E010")]
	[IteratorStateMachine(typeof(JDACAFOGBOF))]
	public IEnumerable<Renderer> JLNPBOFCOLA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x609E080", Offset = "0x609D280", VA = "0x18609E080")]
	[IteratorStateMachine(typeof(FJJCKJLLFAG))]
	public IEnumerable<Renderer> KGFNPEKFMKK()
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
		[Cpp2IlInjected.Address(RVA = "0x60AEEE0", Offset = "0x60AE0E0", VA = "0x1860AEEE0")]
		public ShapeRendererConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[DefaultMember("Item")]
public class LNGHDBLHHKG : MKADNKAIDEE, IDisposable, GOHGPPMJBPM
{
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static readonly ENGBMBNJAKF OEBNJDFJMBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly LKIJABNIHDP<OBCOGHABANN, BAIMDHIKFJN> IEJJIJNPLKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly LKIJABNIHDP<DNJEFBDMNFL, FALBGBLJBHC> LKKPNMNDLOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly LKIJABNIHDP<JEFJLDGLEPC, PAPAHADOAGD> OBCDGOHEFNF;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public BAIMDHIKFJN LOKIFJEIJCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x60A74F0", Offset = "0x60A66F0", VA = "0x1860A74F0", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public FALBGBLJBHC LOKIFJEIJCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x60A7550", Offset = "0x60A6750", VA = "0x1860A7550", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public PAPAHADOAGD LOKIFJEIJCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x60A75B0", Offset = "0x60A67B0", VA = "0x1860A75B0", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public bool GFBECHKFFKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x98C9A0", Offset = "0x98BBA0", VA = "0x18098C9A0", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x98C990", Offset = "0x98BB90", VA = "0x18098C990")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x60A78B0", Offset = "0x60A6AB0", VA = "0x1860A78B0")]
	public LNGHDBLHHKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x60A6B20", Offset = "0x60A5D20", VA = "0x1860A6B20", Slot = "21")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x60A7030", Offset = "0x60A6230", VA = "0x1860A7030", Slot = "4")]
	public OBCOGHABANN HJGANGDFONB(NIIPFPEJDIN JCEJEOAKGOJ)
	{
		return default(OBCOGHABANN);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x60A7030", Offset = "0x60A6230", VA = "0x1860A7030", Slot = "5")]
	public OBCOGHABANN HJGANGDFONB(NIIPFPEJDIN JCEJEOAKGOJ, bool HPFIINHEDHE)
	{
		return default(OBCOGHABANN);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x60A7140", Offset = "0x60A6340", VA = "0x1860A7140", Slot = "6")]
	public void IBPFAPCDJBF(OBCOGHABANN NPDELNKHCNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x60A71A0", Offset = "0x60A63A0", VA = "0x1860A71A0", Slot = "7")]
	public void IDFKPIHFMMF(OBCOGHABANN NPDELNKHCNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x60A7220", Offset = "0x60A6420", VA = "0x1860A7220", Slot = "8")]
	public DNJEFBDMNFL JDMCGCGALPD(OBCOGHABANN NPDELNKHCNM, FJEACKOCPJC JCEJEOAKGOJ)
	{
		return default(DNJEFBDMNFL);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x60A76E0", Offset = "0x60A68E0", VA = "0x1860A76E0", Slot = "9")]
	public DNJEFBDMNFL ONCIFGKCKFG(OBCOGHABANN NPDELNKHCNM, IEBOKOPFDFD JCEJEOAKGOJ)
	{
		return default(DNJEFBDMNFL);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x60A6FA0", Offset = "0x60A61A0", VA = "0x1860A6FA0", Slot = "11")]
	public void ELOKIANMIJA(DNJEFBDMNFL GJJEEFKHLDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x60A7350", Offset = "0x60A6550", VA = "0x1860A7350", Slot = "10")]
	public void KKLFEKKCONC(DNJEFBDMNFL GJJEEFKHLDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x60A7670", Offset = "0x60A6870", VA = "0x1860A7670", Slot = "20")]
	public IEnumerable<Renderer> OIONFJNNNOA(OBCOGHABANN NPDELNKHCNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x60A7470", Offset = "0x60A6670", VA = "0x1860A7470", Slot = "12")]
	public JEFJLDGLEPC LOHNJLKBEIG(DCEJANKMKPD JCEJEOAKGOJ)
	{
		return default(JEFJLDGLEPC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x60A6A50", Offset = "0x60A5C50", VA = "0x1860A6A50", Slot = "14")]
	public void ADPMMBLGHJG(JEFJLDGLEPC HHGEEMGLLNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x60A73B0", Offset = "0x60A65B0", VA = "0x1860A73B0", Slot = "16")]
	public Task KLJKOHEBLBO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x60A7410", Offset = "0x60A6610", VA = "0x1860A7410", Slot = "17")]
	public Task LIBKAHAKOGA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x60A7610", Offset = "0x60A6810", VA = "0x1860A7610", Slot = "18")]
	public Task NOHHFJBCCNH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x4C20650", Offset = "0x4C1F850", VA = "0x184C20650", Slot = "19")]
	public void LJKAGFDNFPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x60A6AC0", Offset = "0x60A5CC0", VA = "0x1860A6AC0", Slot = "13")]
	public void DGDDKIBKPND(JEFJLDGLEPC HHGEEMGLLNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x60A6BB0", Offset = "0x60A5DB0", VA = "0x1860A6BB0", Slot = "25")]
	public IOJHHBINLPD EJJLKPPEJLN(PPNEKCJPIML ODAELDOHFOA, IEnumerable<DNJEFBDMNFL> LKKPNMNDLOP, int ANDODKPMAIE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface HJPLKIKGMOH
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IINBEABIENN(EKBJCFCOELA JAACLLLIGMF, Renderer MEIDGKDNIIE, int CJJKHPJHJFF);

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FCJENHLJEKP(Renderer MEIDGKDNIIE, GDHJMALDFOF FNHGCKIEKGC, Vector3 GAKAKEGCIGF, Vector3 DHFHNDACNNK, Vector3 KOODKJCGOEN, float IMCMAFDJOEC, float DJBCJCNKKJN, float FEKCOLAANMH = -1f, [Optional] Color? MBOFNGAOJFM, [Optional] IReadOnlyList<Camera> OHPNOELJGPP);

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PJFFFJBJBIC(Renderer MEIDGKDNIIE, int CJJKHPJHJFF);

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int FKPFGODAFEE();

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GEJFPKGMIIJ(int PNDCBHFLMHA, HJJHEHOPHGJ JAACLLLIGMF, Renderer MEIDGKDNIIE, int CJJKHPJHJFF);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class NIFGCONCDND : MGAKDJBGALI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private class IGMFJOKJDBI : FFLFAINHPLD<int>
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x60A3100", Offset = "0x60A2300", VA = "0x1860A3100")]
		public IGMFJOKJDBI(string PCKMHBLNCII)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly HJPLKIKGMOH AOJJFIOENBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly GOHGPPMJBPM OEGDMCCLIKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private MeshRenderer BKHHBBLIIKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private IGMFJOKJDBI OOEKNNHDLGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private bool OGBKFMBLDAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private MeshRenderer PCPEPNJMCMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private IGMFJOKJDBI CJLODEKBGOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private bool KIEBELKEHCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private MeshRenderer GCPLNBLGOLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private IGMFJOKJDBI BKEEAFBNGOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private bool MIGKAMNMNKG;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x60ACD90", Offset = "0x60ABF90", VA = "0x1860ACD90")]
	public NIFGCONCDND(HJPLKIKGMOH PJCENIGMDDE, GOHGPPMJBPM OEGDMCCLIKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x60AB200", Offset = "0x60AA400", VA = "0x1860AB200", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x60AC990", Offset = "0x60ABB90", VA = "0x1860AC990")]
	private void MGCMAHEHILJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x60AB5F0", Offset = "0x60AA7F0", VA = "0x1860AB5F0", Slot = "4")]
	public void ELGLHOGEEJN(OBCOGHABANN NPDELNKHCNM, HJJHEHOPHGJ INMFCIONCCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x60AB3D0", Offset = "0x60AA5D0", VA = "0x1860AB3D0", Slot = "5")]
	public void ELGLHOGEEJN(DNJEFBDMNFL GJJEEFKHLDM, HJJHEHOPHGJ INMFCIONCCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x60AB7F0", Offset = "0x60AA9F0", VA = "0x1860AB7F0", Slot = "6")]
	public void GOELBICALCI(DNJEFBDMNFL GJJEEFKHLDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x60ACC70", Offset = "0x60ABE70", VA = "0x1860ACC70", Slot = "7")]
	public void OPBBNACCPLJ(DNJEFBDMNFL GJJEEFKHLDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x60AB120", Offset = "0x60AA320", VA = "0x1860AB120", Slot = "21")]
	public void BPGPMFGIHFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x1A739B0", Offset = "0x1A72BB0", VA = "0x181A739B0", Slot = "8")]
	public void DHFGBADMHDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x60ABE80", Offset = "0x60AB080", VA = "0x1860ABE80", Slot = "9")]
	public void HPAHDECHPGO(HJJHEHOPHGJ INMFCIONCCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x60AC590", Offset = "0x60AB790", VA = "0x1860AC590", Slot = "10")]
	public void LFMBJCGCPPN(OBCOGHABANN NPDELNKHCNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x60AC240", Offset = "0x60AB440", VA = "0x1860AC240", Slot = "11")]
	public void LFMBJCGCPPN(DNJEFBDMNFL GJJEEFKHLDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x60AB920", Offset = "0x60AAB20", VA = "0x1860AB920", Slot = "12")]
	public void HKJFOONHJHO(OBCOGHABANN NPDELNKHCNM, EKBJCFCOELA JAACLLLIGMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x60ABC90", Offset = "0x60AAE90", VA = "0x1860ABC90", Slot = "13")]
	public void HKJFOONHJHO(DNJEFBDMNFL GJJEEFKHLDM, EKBJCFCOELA JAACLLLIGMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x60AC200", Offset = "0x60AB400", VA = "0x1860AC200", Slot = "22")]
	public void LFHNCNIEEFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x60AB160", Offset = "0x60AA360", VA = "0x1860AB160", Slot = "14")]
	public void DGCGPHNMGKG(DNJEFBDMNFL GJJEEFKHLDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x60ACBE0", Offset = "0x60ABDE0", VA = "0x1860ACBE0", Slot = "15")]
	public void NLEOBCEIBOL(DNJEFBDMNFL GJJEEFKHLDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x1852A50", Offset = "0x1851C50", VA = "0x181852A50", Slot = "16")]
	public void HNECPJNLBBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x60AC0C0", Offset = "0x60AB2C0", VA = "0x1860AC0C0", Slot = "17")]
	public void IOLPHEHIJMM(EKBJCFCOELA JAACLLLIGMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x60AC740", Offset = "0x60AB940", VA = "0x1860AC740")]
	private void MEDHJFMBENE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x60ABAD0", Offset = "0x60AACD0", VA = "0x1860ABAD0")]
	public void HKJFOONHJHO(DNJEFBDMNFL GJJEEFKHLDM, EKBJCFCOELA JAACLLLIGMF, bool NGPOKMKPHEJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x60ABFF0", Offset = "0x60AB1F0", VA = "0x1860ABFF0")]
	private void IINBEABIENN(EKBJCFCOELA JAACLLLIGMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x60AADB0", Offset = "0x60A9FB0", VA = "0x1860AADB0", Slot = "18")]
	public void BMBEBEFIHBO(OBCOGHABANN NPDELNKHCNM, Vector3 GAKAKEGCIGF, Vector3 DHFHNDACNNK, Vector3 KOODKJCGOEN, float IMCMAFDJOEC, float DJBCJCNKKJN, IReadOnlyList<Camera> CNHMJELEEBO, GDHJMALDFOF FNHGCKIEKGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x60AA9B0", Offset = "0x60A9BB0", VA = "0x1860AA9B0", Slot = "19")]
	public void BMBEBEFIHBO(JEFJLDGLEPC HHGEEMGLLNM, Vector3 GAKAKEGCIGF, Vector3 DHFHNDACNNK, Vector3 KOODKJCGOEN, float IMCMAFDJOEC, float DJBCJCNKKJN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class GCLNCJDOKGD
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class FHFFINBMMEJ : IEnumerable<JCHMKKJPLHK>, IEnumerable, IEnumerator<JCHMKKJPLHK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private JCHMKKJPLHK <>2__current;

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
		private JCHMKKJPLHK System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.PrimitiveShapeMeshData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x844820", Offset = "0x843A20", VA = "0x180844820", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x844820", Offset = "0x843A20", VA = "0x180844820", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0xECAD80", Offset = "0xEC9F80", VA = "0x180ECAD80")]
		[DebuggerHidden]
		public FHFFINBMMEJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x60A1AB0", Offset = "0x60A0CB0", VA = "0x1860A1AB0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x60A1C20", Offset = "0x60A0E20", VA = "0x1860A1C20", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x60A1B90", Offset = "0x60A0D90", VA = "0x1860A1B90", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<JCHMKKJPLHK> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.PrimitiveShapeMeshData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x60A1B90", Offset = "0x60A0D90", VA = "0x1860A1B90", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public const int JHHEMONCJOP = 3;

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private static JCHMKKJPLHK[][] LCDNPILMFNN;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private static IHOCNNFBFCM NEICMBFEAME;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public static ShapeRendererConfig HBNFGGJOPAP;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public static ComputeShader EFFEDBPLIHE
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x60A2FC0", Offset = "0x60A21C0", VA = "0x1860A2FC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public static SkinnedShapeRenderer KGAFAANIBEE
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x60A2D30", Offset = "0x60A1F30", VA = "0x1860A2D30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x60A2F00", Offset = "0x60A2100", VA = "0x1860A2F00")]
	public static Mesh HEHNJPPBGDI(ODOEDPKGEFP MOKCCKAEHGG, int DPIMGBNDIHM = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x60A3050", Offset = "0x60A2250", VA = "0x1860A3050")]
	public static int PCHBCEKBBHD(ODOEDPKGEFP MOKCCKAEHGG, int DPIMGBNDIHM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x60A2DA0", Offset = "0x60A1FA0", VA = "0x1860A2DA0")]
	public static IHOCNNFBFCM GJPPBKDBMMF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x60A2CD0", Offset = "0x60A1ED0", VA = "0x1860A2CD0")]
	[IteratorStateMachine(typeof(FHFFINBMMEJ))]
	private static IEnumerable<JCHMKKJPLHK> DPPNPCPHBLB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x60A27B0", Offset = "0x60A19B0", VA = "0x1860A27B0")]
	public static JCHMKKJPLHK AICCKFEOOAK(ODOEDPKGEFP MOKCCKAEHGG, int DPIMGBNDIHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x60A3030", Offset = "0x60A2230", VA = "0x1860A3030")]
	public static bool MJHBMABHHLN(this ODOEDPKGEFP MOKCCKAEHGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x60A2B20", Offset = "0x60A1D20", VA = "0x1860A2B20")]
	public static void DFIBPDNFPHI(ODOEDPKGEFP MOKCCKAEHGG, float3 PMJFKNCOLMH, out HFDDGBHMKAG KLOLBKBPFJH, out float3 FPMBJELMJCC, out float FIKDLGFHJLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x60A2420", Offset = "0x60A1620", VA = "0x1860A2420")]
	public static void AADHJDDGKHC(Vector3 PMJFKNCOLMH, ODOEDPKGEFP MOKCCKAEHGG, out Vector3 FPMBJELMJCC, out float FIKDLGFHJLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x60A2B10", Offset = "0x60A1D10", VA = "0x1860A2B10")]
	[GCPIAKNECPG(DFCDCLLOMEG.ExitingPlayMode, 0)]
	private static void ANOFMNAMCOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x60A2200", Offset = "0x60A1400", VA = "0x1860A2200")]
	[GCPIAKNECPG(DFCDCLLOMEG.ExitingPlayMode, 0)]
	private static void AADCJEDCLHF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public abstract class FALBGBLJBHC : OPBJJFBIALM, IGFGOMOAFHG, FNLKINFBFLO, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public readonly BAIMDHIKFJN HOKLBIFFMCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	protected Bounds OIBODKEAFEO;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public Bounds BHLIDBMFOFG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x18EA610", Offset = "0x18E9810", VA = "0x1818EA610", Slot = "4")]
		get
		{
			return default(Bounds);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public virtual KOLHDOIAKCN GMKGFALANAO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x60A1A20", Offset = "0x60A0C20", VA = "0x1860A1A20", Slot = "17")]
		get
		{
			return default(KOLHDOIAKCN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public bool LPIHDBFONFF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x8D6B70", Offset = "0x8D5D70", VA = "0x1808D6B70")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0xABB080", Offset = "0xABA280", VA = "0x180ABB080")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	protected abstract Hash128 OCEKFMBADKF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int LDBKIAEGCIF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x825660", Offset = "0x824860", VA = "0x180825660", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public EDLPAEBCJAD BKALCAFGBDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x8293D0", Offset = "0x8285D0", VA = "0x1808293D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x8DF660", Offset = "0x8DE860", VA = "0x1808DF660")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public bool JECAEBJPDCI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x9D3C20", Offset = "0x9D2E20", VA = "0x1809D3C20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x8D7A20", Offset = "0x8D6C20", VA = "0x1808D7A20")]
	protected FALBGBLJBHC(BAIMDHIKFJN NPDELNKHCNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x60A18C0", Offset = "0x60A0AC0", VA = "0x1860A18C0", Slot = "15")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x826280", Offset = "0x825480", VA = "0x180826280", Slot = "16")]
	public virtual bool BDKPNOGPEBN(PPNEKCJPIML NPDELNKHCNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "18")]
	public abstract int CGCNCBIADOE(LGEOKOLGIOB DPIMGBNDIHM);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "19")]
	public abstract int CMAPBIJOKPB(LGEOKOLGIOB DPIMGBNDIHM);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "20")]
	public abstract void JDMLOAPGBLL(LGEOKOLGIOB DPIMGBNDIHM, EDKEEFGEFAM BMBJLJBMCBK, int CGKDBDEIJHD = -1);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "21")]
	public abstract PPNEKCJPIML MACLBGJCOOG();

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x60A1890", Offset = "0x60A0A90", VA = "0x1860A1890", Slot = "11")]
	public Hash128 BBEGJDAMFLB(int DPIMGBNDIHM)
	{
		return default(Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "23")]
	public abstract LMDKCNHOEKM IPDDJOOPFIC();

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "24")]
	public abstract IMEOKEOGFCN BCONAPFBNDP(LGEOKOLGIOB DPIMGBNDIHM, JobHandle JAKIGJLIHJN);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x60A19F0", Offset = "0x60A0BF0", VA = "0x1860A19F0", Slot = "10")]
	public IMEOKEOGFCN EJJLKPPEJLN(int DPIMGBNDIHM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class EGACCEEIHEK : FALBGBLJBHC
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	private struct BIPFFHOHCEF : IMEOKEOGFCN, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private PAHCOOGOOKI BOIPJLCFOOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private JobHandle JAKIGJLIHJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private FFPGHIOOJDM GLIABMOAIGI;

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x609EC80", Offset = "0x609DE80", VA = "0x18609EC80")]
		public BIPFFHOHCEF(PAHCOOGOOKI BOIPJLCFOOL, JobHandle JAKIGJLIHJN, FFPGHIOOJDM GLIABMOAIGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x41C0380", Offset = "0x41BF580", VA = "0x1841C0380")]
		public bool APOMBNLPNLG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x609EC50", Offset = "0x609DE50", VA = "0x18609EC50", Slot = "4")]
		public PAHCOOGOOKI HEEDEOJNDNP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x609EC00", Offset = "0x609DE00", VA = "0x18609EC00", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private readonly IEBOKOPFDFD DNMKBBJCGDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private float AHGGGMOOALJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private Hash128 FGADBCIHFLB;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	protected override Hash128 OCEKFMBADKF
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x609F980", Offset = "0x609EB80", VA = "0x18609F980", Slot = "22")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x60A0470", Offset = "0x609F670", VA = "0x1860A0470")]
	public EGACCEEIHEK(BAIMDHIKFJN NPDELNKHCNM, IEBOKOPFDFD JCEJEOAKGOJ, bool HPFIINHEDHE = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x826280", Offset = "0x825480", VA = "0x180826280", Slot = "16")]
	public override bool BDKPNOGPEBN(PPNEKCJPIML NPDELNKHCNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x609F5A0", Offset = "0x609E7A0", VA = "0x18609F5A0", Slot = "18")]
	public override int CGCNCBIADOE(LGEOKOLGIOB DPIMGBNDIHM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x609F790", Offset = "0x609E990", VA = "0x18609F790", Slot = "19")]
	public override int CMAPBIJOKPB(LGEOKOLGIOB DPIMGBNDIHM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x609FCC0", Offset = "0x609EEC0", VA = "0x18609FCC0", Slot = "20")]
	public override void JDMLOAPGBLL(LGEOKOLGIOB DPIMGBNDIHM, EDKEEFGEFAM BMBJLJBMCBK, int CGKDBDEIJHD = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x60A03A0", Offset = "0x609F5A0", VA = "0x1860A03A0", Slot = "21")]
	public override PPNEKCJPIML MACLBGJCOOG()
	{
		return default(PPNEKCJPIML);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x609FAA0", Offset = "0x609ECA0", VA = "0x18609FAA0", Slot = "23")]
	public override LMDKCNHOEKM IPDDJOOPFIC()
	{
		return default(LMDKCNHOEKM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x609ECE0", Offset = "0x609DEE0", VA = "0x18609ECE0", Slot = "24")]
	public override IMEOKEOGFCN BCONAPFBNDP(LGEOKOLGIOB DPIMGBNDIHM, JobHandle JAKIGJLIHJN)
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
		private MaterialPropertyBlock PPLKMMAFLAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private ELMCOBIOFOA BOIPJLCFOOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private List<PPNEKCJPIML> DCLLBMFALAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private RenderTexture JONCCAFJCAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private ComputeBuffer IBLKJPPKODK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private ComputeShader FMENMDJEPKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private Matrix4x4[] JGOKOMJBPEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private int EAGDKDEICBP;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public MeshRenderer LADKOMKKMCP
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x844820", Offset = "0x843A20", VA = "0x180844820")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x844AA0", Offset = "0x843CA0", VA = "0x180844AA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public int PEJIHCNNNPF
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x60AFBA0", Offset = "0x60AEDA0", VA = "0x1860AFBA0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x60AEF10", Offset = "0x60AE110", VA = "0x1860AEF10")]
		public static List<SkinnedShapeRenderer> Create(GameObject NPDELNKHCNM, List<ELMCOBIOFOA> KPNONMDMBNA, List<PPNEKCJPIML> DCLLBMFALAJ, Material LGBCNNOGHMI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x60AF390", Offset = "0x60AE590", VA = "0x1860AF390")]
		public void Init(ELMCOBIOFOA BOIPJLCFOOL, List<PPNEKCJPIML> DCLLBMFALAJ, Material LGBCNNOGHMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x60AFAF0", Offset = "0x60AECF0", VA = "0x1860AFAF0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x60AFA40", Offset = "0x60AEC40", VA = "0x1860AFA40")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x60AFA00", Offset = "0x60AEC00", VA = "0x1860AFA00")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x60AF160", Offset = "0x60AE360", VA = "0x1860AF160")]
		private void HBHEJIDALKE(ScriptableRenderContext APPLJOFCBIB, Camera[] CDKMOBNFFDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x60AF840", Offset = "0x60AEA40", VA = "0x1860AF840")]
		private void LHGOAOKGOMN(CommandBuffer LDMKFFMELDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x931070", Offset = "0x930270", VA = "0x180931070")]
		public SkinnedShapeRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface FLGPFHBLGDF
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	bool AGBHEJPOIJL
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Material KDNHNALGIHL();

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Material BCAGKCNMLEK();

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Material GJMMNCNFHGN();

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int HDALDCHBDLD(LNOPPDJFMPP NBBPFFFJANG);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int BNAFGECCPEO(FACFKJMCFHH NHBEFCBGOHG);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JMHPIJGCHPJ(GameObject BHEOHCEHIBM);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void DMKHLLOBDEG(GameObject BHEOHCEHIBM, bool PFJFAPEEAND);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class KIPGALJMCCJ
{
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static FLGPFHBLGDF NKLFKPOOEFB;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public static bool AGBHEJPOIJL
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x60A43F0", Offset = "0x60A35F0", VA = "0x1860A43F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x60A45F0", Offset = "0x60A37F0", VA = "0x1860A45F0")]
	public static void LDFCOMKFFKO(FLGPFHBLGDF DFOMPLKIIOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x60A4590", Offset = "0x60A3790", VA = "0x1860A4590")]
	public static Material KDNHNALGIHL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x60A41E0", Offset = "0x60A33E0", VA = "0x1860A41E0")]
	public static Material BCAGKCNMLEK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x60A4390", Offset = "0x60A3590", VA = "0x1860A4390")]
	public static Material GJMMNCNFHGN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x60A4450", Offset = "0x60A3650", VA = "0x1860A4450")]
	public static int HDALDCHBDLD(LNOPPDJFMPP NBBPFFFJANG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x60A4240", Offset = "0x60A3440", VA = "0x1860A4240")]
	public static int BNAFGECCPEO(FACFKJMCFHH NHBEFCBGOHG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x60A44C0", Offset = "0x60A36C0", VA = "0x1860A44C0")]
	public static void JMHPIJGCHPJ(GameObject BHEOHCEHIBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x60A42B0", Offset = "0x60A34B0", VA = "0x1860A42B0")]
	public static void DMKHLLOBDEG(GameObject BHEOHCEHIBM, bool PFJFAPEEAND)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[DefaultMember("Item")]
public class MMNPIELOJME : MKADNKAIDEE, IDisposable, GOHGPPMJBPM
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class NNDNDEHNKAK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public MMNPIELOJME <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public NNDNDEHNKAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x60AD000", Offset = "0x60AC200", VA = "0x1860AD000", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly LKIJABNIHDP<OBCOGHABANN, BAIMDHIKFJN> IEJJIJNPLKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly LKIJABNIHDP<DNJEFBDMNFL, FALBGBLJBHC> LKKPNMNDLOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly LKIJABNIHDP<JEFJLDGLEPC, PAPAHADOAGD> OBCDGOHEFNF;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public BAIMDHIKFJN LOKIFJEIJCG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x60A9DA0", Offset = "0x60A8FA0", VA = "0x1860A9DA0", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public FALBGBLJBHC LOKIFJEIJCG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x60A9D40", Offset = "0x60A8F40", VA = "0x1860A9D40", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public PAPAHADOAGD LOKIFJEIJCG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x60A9E00", Offset = "0x60A9000", VA = "0x1860A9E00", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool GFBECHKFFKL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x98C9A0", Offset = "0x98BBA0", VA = "0x18098C9A0", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x98C990", Offset = "0x98BB90", VA = "0x18098C990")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x60AA4F0", Offset = "0x60A96F0", VA = "0x1860AA4F0")]
	public MMNPIELOJME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x60A7D60", Offset = "0x60A6F60", VA = "0x1860A7D60", Slot = "21")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x60A8BC0", Offset = "0x60A7DC0", VA = "0x1860A8BC0", Slot = "4")]
	public OBCOGHABANN HJGANGDFONB(NIIPFPEJDIN JCEJEOAKGOJ)
	{
		return default(OBCOGHABANN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x60A8920", Offset = "0x60A7B20", VA = "0x1860A8920", Slot = "5")]
	public OBCOGHABANN HJGANGDFONB(NIIPFPEJDIN JCEJEOAKGOJ, bool HPFIINHEDHE)
	{
		return default(OBCOGHABANN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x60A8BD0", Offset = "0x60A7DD0", VA = "0x1860A8BD0", Slot = "6")]
	public void IBPFAPCDJBF(OBCOGHABANN NPDELNKHCNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x60A8E50", Offset = "0x60A8050", VA = "0x1860A8E50", Slot = "7")]
	public void IDFKPIHFMMF(OBCOGHABANN NPDELNKHCNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x60A91E0", Offset = "0x60A83E0", VA = "0x1860A91E0", Slot = "8")]
	public DNJEFBDMNFL JDMCGCGALPD(OBCOGHABANN NPDELNKHCNM, FJEACKOCPJC JCEJEOAKGOJ)
	{
		return default(DNJEFBDMNFL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x60A9FF0", Offset = "0x60A91F0", VA = "0x1860A9FF0", Slot = "9")]
	public DNJEFBDMNFL ONCIFGKCKFG(OBCOGHABANN NPDELNKHCNM, IEBOKOPFDFD JCEJEOAKGOJ)
	{
		return default(DNJEFBDMNFL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x60A8520", Offset = "0x60A7720", VA = "0x1860A8520", Slot = "11")]
	public void ELOKIANMIJA(DNJEFBDMNFL GJJEEFKHLDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x60A96E0", Offset = "0x60A88E0", VA = "0x1860A96E0", Slot = "10")]
	public void KKLFEKKCONC(DNJEFBDMNFL GJJEEFKHLDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x60A9F80", Offset = "0x60A9180", VA = "0x1860A9F80", Slot = "20")]
	public IEnumerable<Renderer> OIONFJNNNOA(OBCOGHABANN NPDELNKHCNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x60A9CC0", Offset = "0x60A8EC0", VA = "0x1860A9CC0", Slot = "12")]
	public JEFJLDGLEPC LOHNJLKBEIG(DCEJANKMKPD JCEJEOAKGOJ)
	{
		return default(JEFJLDGLEPC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x60A7C90", Offset = "0x60A6E90", VA = "0x1860A7C90", Slot = "14")]
	public void ADPMMBLGHJG(JEFJLDGLEPC HHGEEMGLLNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x60A9960", Offset = "0x60A8B60", VA = "0x1860A9960", Slot = "16")]
	public Task KLJKOHEBLBO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x60A9AD0", Offset = "0x60A8CD0", VA = "0x1860A9AD0", Slot = "17")]
	public Task LIBKAHAKOGA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x60A9E60", Offset = "0x60A9060", VA = "0x1860A9E60", Slot = "18")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(NNDNDEHNKAK))]
	public Task NOHHFJBCCNH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x60A9C30", Offset = "0x60A8E30", VA = "0x1860A9C30", Slot = "19")]
	public void LJKAGFDNFPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x60A7D00", Offset = "0x60A6F00", VA = "0x1860A7D00", Slot = "13")]
	public void DGDDKIBKPND(JEFJLDGLEPC HHGEEMGLLNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x60A7F00", Offset = "0x60A7100", VA = "0x1860A7F00", Slot = "25")]
	public IOJHHBINLPD EJJLKPPEJLN(PPNEKCJPIML ODAELDOHFOA, IEnumerable<DNJEFBDMNFL> LKKPNMNDLOP, int ANDODKPMAIE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class ELMCOBIOFOA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	private struct PAHPMLFMCGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public EDKEEFGEFAM PHMJPMGHPEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public PPNEKCJPIML KOJJIOPHAFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public int IEFKOFKIKEA;
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class AELBJJBENCG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public ELMCOBIOFOA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public int numVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public int numIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public LGEOKOLGIOB lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public List<PAHPMLFMCGD> boneMeshInfos;

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public AELBJJBENCG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class NMFOGLOKKKF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public PAHCOOGOOKI combinedMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public AELBJJBENCG CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public NMFOGLOKKKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x60ACF90", Offset = "0x60AC190", VA = "0x1860ACF90")]
		internal JobHandle JLAGHHAIHJM()
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x60ACF50", Offset = "0x60AC150", VA = "0x1860ACF50")]
		internal void EDGMKHOMBFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x60ACDE0", Offset = "0x60ABFE0", VA = "0x1860ACDE0")]
		internal void ADEGEGOKAKO()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private int[] JFBNGLOICOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private JOAIBGKHHLM NBIAOBLCGOD;

	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private static Matrix4x4 MEAOKDOOENG;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public Mesh FMNAFHECIKN
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x8D4AB0", Offset = "0x8D3CB0", VA = "0x1808D4AB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x8F7D20", Offset = "0x8F6F20", VA = "0x1808F7D20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public int KPKKJDOHFFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x8D86B0", Offset = "0x8D78B0", VA = "0x1808D86B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x937370", Offset = "0x936570", VA = "0x180937370")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x60A06A0", Offset = "0x609F8A0", VA = "0x1860A06A0")]
	public void LHGOAOKGOMN(List<PPNEKCJPIML> AIONCEAPOJO, Matrix4x4[] IHEJFMPPHFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x60A0900", Offset = "0x609FB00", VA = "0x1860A0900")]
	public static List<ELMCOBIOFOA> LNIGJBIDADO(List<BAIMDHIKFJN> IINPHIIEHGH, LGEOKOLGIOB DPIMGBNDIHM, Bounds NNBJBMNKACK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x60A0F40", Offset = "0x60A0140", VA = "0x1860A0F40")]
	private JobHandle PIPPAMIHPBO(PAHCOOGOOKI LMJKGLCIGGE, int GLPOCELGENI, int IGCPDMHABIG, LGEOKOLGIOB DPIMGBNDIHM, List<PAHPMLFMCGD> NBNBDAFLOBD)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x60A0590", Offset = "0x609F790", VA = "0x1860A0590")]
	private void HFEHKEMCJEI(List<PAHPMLFMCGD> NBNBDAFLOBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x60A1460", Offset = "0x60A0660", VA = "0x1860A1460")]
	private ELMCOBIOFOA(List<PAHPMLFMCGD> NBNBDAFLOBD, int GLPOCELGENI, int IGCPDMHABIG, LGEOKOLGIOB DPIMGBNDIHM, Bounds NNBJBMNKACK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x60A0520", Offset = "0x609F720", VA = "0x1860A0520", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class PAPAHADOAGD : IMBEBLBNAAF
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class OMDPNILMMGC : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public PAPAHADOAGD <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x844820", Offset = "0x843A20", VA = "0x180844820", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x844820", Offset = "0x843A20", VA = "0x180844820", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0xECAD80", Offset = "0xEC9F80", VA = "0x180ECAD80")]
		[DebuggerHidden]
		public OMDPNILMMGC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x60AD8F0", Offset = "0x60ACAF0", VA = "0x1860AD8F0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x60AD5F0", Offset = "0x60AC7F0", VA = "0x1860AD5F0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x60AD5A0", Offset = "0x60AC7A0", VA = "0x1860AD5A0")]
		private void LNJGNFIDMML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x60AD8B0", Offset = "0x60ACAB0", VA = "0x1860AD8B0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x60AD810", Offset = "0x60ACA10", VA = "0x1860AD810", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x60AD810", Offset = "0x60ACA10", VA = "0x1860AD810", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly DCEJANKMKPD MKONIIDECHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly GOHGPPMJBPM OEGDMCCLIKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private KDLABOBFFBI MEDBCDFEJHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private List<ELMCOBIOFOA> MAKFAOCLCIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private List<ELMCOBIOFOA> HMEIGMFNCAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private GameObject OEEKBLNOBCE;

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x60AEC70", Offset = "0x60ADE70", VA = "0x1860AEC70")]
	public static PAPAHADOAGD NAHGPIJPMMB(DCEJANKMKPD JCEJEOAKGOJ, GOHGPPMJBPM OEGDMCCLIKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x60AEDE0", Offset = "0x60ADFE0", VA = "0x1860AEDE0")]
	private PAPAHADOAGD(DCEJANKMKPD JCEJEOAKGOJ, GOHGPPMJBPM OEGDMCCLIKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x60AE6A0", Offset = "0x60AD8A0", VA = "0x1860AE6A0")]
	public void JKAFMKKGOFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x60AEB60", Offset = "0x60ADD60", VA = "0x1860AEB60")]
	[IteratorStateMachine(typeof(OMDPNILMMGC))]
	public IEnumerable<Renderer> JLNPBOFCOLA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x60ADBC0", Offset = "0x60ACDC0", VA = "0x1860ADBC0", Slot = "4")]
	public void FHLBCHIOALE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x60AEBD0", Offset = "0x60ADDD0", VA = "0x1860AEBD0")]
	private void KPILABOLBMO(Vector3 GJDHBCFOMBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x60AD980", Offset = "0x60ACB80", VA = "0x1860AD980")]
	public void BOOFGHHIEIL()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class CGEPNPBBKEG
{
	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
	public CGEPNPBBKEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x892120", Offset = "0x891320", VA = "0x180892120")]
	public static string AADLLEBJPEC(byte[] MJAMHAEGDEA, byte[] ELNJHIHGPEE)
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
