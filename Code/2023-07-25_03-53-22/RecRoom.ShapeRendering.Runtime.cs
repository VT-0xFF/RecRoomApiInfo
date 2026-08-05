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
public interface NKCLLGNMIJD
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	HENOGOOCAMO CLDBOBAGHND
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	OFBKNODCNKF CLDBOBAGHND
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	NGHAAMCFHMH CLDBOBAGHND
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class NEGKMIGABFA : GHDLBNMAPLC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private const byte BACOFOODOKB = byte.MaxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private byte OGJFCBMKJFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly List<SkinnedShapeRenderer>[] EDANMHCABOG;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int DOPBOOCCACB
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xBB0410", Offset = "0xBAF410", VA = "0x180BB0410", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xBF6220", Offset = "0xBF5220", VA = "0x180BF6220")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int JCEJLJDGPFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xD76220", Offset = "0xD75220", VA = "0x180D76220", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x11BE2F0", Offset = "0x11BD2F0", VA = "0x1811BE2F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public float IAILECHGHGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8650D0", Offset = "0x8640D0", VA = "0x1808650D0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x864DA0", Offset = "0x863DA0", VA = "0x180864DA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public float BCBMHBLJCHD
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x90AC00", Offset = "0x909C00", VA = "0x18090AC00", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x90A7B0", Offset = "0x9097B0", VA = "0x18090A7B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public List<SkinnedShapeRenderer> APCMDJBMIDC
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5FBA500", Offset = "0x5FB9500", VA = "0x185FBA500")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public List<SkinnedShapeRenderer> CHBNDJJDKAL
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5FBA930", Offset = "0x5FB9930", VA = "0x185FBA930")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public GameObject LGIBJPCGOGH
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9132C0", Offset = "0x9122C0", VA = "0x1809132C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA8F810", Offset = "0xA8E810", VA = "0x180A8F810")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public byte HLCOCGBGPNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5FBA4B0", Offset = "0x5FB94B0", VA = "0x185FBA4B0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5FBAA10", Offset = "0x5FB9A10", VA = "0x185FBAA10")]
	public NEGKMIGABFA(List<IAOILCHOBPE> NIPOADEPPBC, List<IAOILCHOBPE> HAIIDBBNHPN, List<ACILLLOIMMI> OAGPGHOCMHI, Material HDEIKJNIFFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5FBA6D0", Offset = "0x5FB96D0", VA = "0x185FBA6D0")]
	private int JICOMBGOCJC(List<IAOILCHOBPE> HGLOFKKOHCA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5FBA7E0", Offset = "0x5FB97E0", VA = "0x185FBA7E0")]
	private void JMAOIGJHHDP(int PNEMDEDMCIC, bool MHCBMAAPDGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5FBA970", Offset = "0x5FB9970", VA = "0x185FBA970")]
	public void ONHIGBAEPOL(Vector3 NPDFNOJGKKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5FBA560", Offset = "0x5FB9560", VA = "0x185FBA560", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5FBA690", Offset = "0x5FB9690", VA = "0x185FBA690")]
	public void GNBABPEMADK(Transform OJEBBODHEAJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
internal class GEPAJBCLHHH : OFBKNODCNKF
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	private struct FMPJOCCDJKK : MHGJOOJMMIJ, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private GKDOHBEKBBP CAFDMHFNNHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private JobHandle AAPDDMNNEHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private NJBBAHHIJGL OJLOHBNBAMO;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x5FB16E0", Offset = "0x5FB06E0", VA = "0x185FB16E0")]
		public FMPJOCCDJKK(GKDOHBEKBBP CAFDMHFNNHI, JobHandle AAPDDMNNEHG, NJBBAHHIJGL OJLOHBNBAMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x37467D0", Offset = "0x37457D0", VA = "0x1837467D0")]
		public bool PHDAMLHGKHI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5FB1660", Offset = "0x5FB0660", VA = "0x185FB1660", Slot = "4")]
		public GKDOHBEKBBP DGCOAPBJKNO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x5FB1690", Offset = "0x5FB0690", VA = "0x185FB1690", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public readonly CJADDPALMFO ILJIPNHLBGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private int[] HHOHNBBAJPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private float LMBOOFOFFBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private Hash128 PDHOMPALHND;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override EBAGCCGNCIL NNPJNCBNBFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5FB2CD0", Offset = "0x5FB1CD0", VA = "0x185FB2CD0", Slot = "17")]
		get
		{
			return default(EBAGCCGNCIL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private Vector3 MDOBCPKNJJB
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5FB30A0", Offset = "0x5FB20A0", VA = "0x185FB30A0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	protected override Hash128 GBDNONHINKA
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5FB3970", Offset = "0x5FB2970", VA = "0x185FB3970", Slot = "22")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5FB3A90", Offset = "0x5FB2A90", VA = "0x185FB3A90")]
	public GEPAJBCLHHH(HENOGOOCAMO EMIPEAKIENF, CJADDPALMFO HHCEHFFEAKN, bool KMBBKGFMAFF = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5FB2860", Offset = "0x5FB1860", VA = "0x185FB2860", Slot = "16")]
	public override bool EOGAIECIADI(ACILLLOIMMI EMIPEAKIENF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5FB33E0", Offset = "0x5FB23E0", VA = "0x185FB33E0", Slot = "18")]
	public override int JICOMBGOCJC(DFCJNAGAOHO MIIMEHOHOHP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5FB27B0", Offset = "0x5FB17B0", VA = "0x185FB27B0", Slot = "19")]
	public override int EHOEKGOBFKE(DFCJNAGAOHO MIIMEHOHOHP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5FB3490", Offset = "0x5FB2490", VA = "0x185FB3490")]
	private int JJGPOPNEJNG(DFCJNAGAOHO MIIMEHOHOHP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5FB1730", Offset = "0x5FB0730", VA = "0x185FB1730", Slot = "20")]
	public override void DHBKEKLMDMK(DFCJNAGAOHO MIIMEHOHOHP, GFJOMOPMDPO NADNFMJCGMD, int OCJLFGBNHEM = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5FB1EC0", Offset = "0x5FB0EC0", VA = "0x185FB1EC0", Slot = "21")]
	public override ACILLLOIMMI DODBFEMHKIE()
	{
		return default(ACILLLOIMMI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5FB3750", Offset = "0x5FB2750", VA = "0x185FB3750", Slot = "23")]
	public override KGKCLAPONIK KCKAGANMAKM()
	{
		return default(KGKCLAPONIK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5FB1F90", Offset = "0x5FB0F90", VA = "0x185FB1F90", Slot = "24")]
	public override MHGJOOJMMIJ EBMPBHGEHJB(DFCJNAGAOHO MIIMEHOHOHP, JobHandle AAPDDMNNEHG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class HENOGOOCAMO : LLEGFGPJOLH, EJKMAIOPJFK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class EBALOMCKDHJ : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public HENOGOOCAMO <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xC531B0", Offset = "0xC521B0", VA = "0x180C531B0")]
		[DebuggerHidden]
		public EBALOMCKDHJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x5FB1180", Offset = "0x5FB0180", VA = "0x185FB1180", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x5FB0BC0", Offset = "0x5FAFBC0", VA = "0x185FB0BC0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x5FB0B70", Offset = "0x5FAFB70", VA = "0x185FB0B70")]
		private void MHEJAKKMIEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x5FB0AD0", Offset = "0x5FAFAD0", VA = "0x185FB0AD0")]
		private void CAIKJCDFNNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x5FB0B20", Offset = "0x5FAFB20", VA = "0x185FB0B20")]
		private void GKGCPCCNJOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x5FB1140", Offset = "0x5FB0140", VA = "0x185FB1140", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x5FB10A0", Offset = "0x5FB00A0", VA = "0x185FB10A0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x5FB10A0", Offset = "0x5FB00A0", VA = "0x185FB10A0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class KEDFACIFKEE : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public HENOGOOCAMO <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xC531B0", Offset = "0xC521B0", VA = "0x180C531B0")]
		[DebuggerHidden]
		public KEDFACIFKEE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x5FB8C80", Offset = "0x5FB7C80", VA = "0x185FB8C80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x5FB8860", Offset = "0x5FB7860", VA = "0x185FB8860", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x5FB8810", Offset = "0x5FB7810", VA = "0x185FB8810")]
		private void MHEJAKKMIEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x5FB87C0", Offset = "0x5FB77C0", VA = "0x185FB87C0")]
		private void CAIKJCDFNNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x5FB8C40", Offset = "0x5FB7C40", VA = "0x185FB8C40", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x5FB8BA0", Offset = "0x5FB7BA0", VA = "0x185FB8BA0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x5FB8BA0", Offset = "0x5FB7BA0", VA = "0x185FB8BA0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly FOEIFBHKJKA AIBMOJDPOPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly List<OFBKNODCNKF> GFKPHCLKMJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private List<ClusterMeshRenderer> LDCCKOHKOAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private BatchedMeshRenderer GMBALDCFFAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private bool EJBNMAPGLNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly bool AHJFANNBPFD;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IEnumerable<DENCHOJPCHA> OPMIFLLBFLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int GPPGEGPDKNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x5FB5D50", Offset = "0x5FB4D50", VA = "0x185FB5D50", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public ACILLLOIMMI OALABEBKNED
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x5FB67C0", Offset = "0x5FB57C0", VA = "0x185FB67C0", Slot = "7")]
		get
		{
			return default(ACILLLOIMMI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public List<SkinnedShapeRenderer> NGDEJELHKNH
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x871190", Offset = "0x870190", VA = "0x180871190")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x871150", Offset = "0x870150", VA = "0x180871150")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5FB5D20", Offset = "0x5FB4D20", VA = "0x185FB5D20")]
	private bool EDKMHFICBFP(OFBKNODCNKF GFPPIEEIIPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5FB6880", Offset = "0x5FB5880", VA = "0x185FB6880")]
	private static bool LBOPJKBKBFO(OFBKNODCNKF GFPPIEEIIPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5FB6F90", Offset = "0x5FB5F90", VA = "0x185FB6F90")]
	public HENOGOOCAMO(FOEIFBHKJKA HHCEHFFEAKN, bool MIAGKLJNADD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5FB5BA0", Offset = "0x5FB4BA0", VA = "0x185FB5BA0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5FB5840", Offset = "0x5FB4840", VA = "0x185FB5840")]
	public void AMLBOIMHPGF(OFBKNODCNKF GFPPIEEIIPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5FB5A70", Offset = "0x5FB4A70", VA = "0x185FB5A70")]
	public void DNDEJFPIDIA(OFBKNODCNKF GFPPIEEIIPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5FB6AF0", Offset = "0x5FB5AF0", VA = "0x185FB6AF0", Slot = "4")]
	public void OFEEDNLDJAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5FB68A0", Offset = "0x5FB58A0", VA = "0x185FB68A0")]
	public void MCCBAFPODDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5FB5EC0", Offset = "0x5FB4EC0", VA = "0x185FB5EC0")]
	private void GMNLJECPDMA(List<OFBKNODCNKF> GFKPHCLKMJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5FB57E0", Offset = "0x5FB47E0", VA = "0x185FB57E0")]
	private static Material AECBMEKNCGD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5FB5E20", Offset = "0x5FB4E20", VA = "0x185FB5E20")]
	private void GMNLJECPDMA(OFBKNODCNKF GFPPIEEIIPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5FB6050", Offset = "0x5FB5050", VA = "0x185FB6050")]
	private void ILMFAIJAJNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5FB6210", Offset = "0x5FB5210", VA = "0x185FB6210")]
	public void JGHPMLMDGMO(bool GNOMGKDFKLI, bool GLKMFIOJKIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5FB5D90", Offset = "0x5FB4D90", VA = "0x185FB5D90")]
	protected void GKKLLGNEELP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5FB6130", Offset = "0x5FB5130", VA = "0x185FB6130")]
	[IteratorStateMachine(typeof(EBALOMCKDHJ))]
	public IEnumerable<Renderer> IMAFJDBDBFA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5FB61A0", Offset = "0x5FB51A0", VA = "0x185FB61A0")]
	[IteratorStateMachine(typeof(KEDFACIFKEE))]
	public IEnumerable<Renderer> JENLKNALAMD()
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
		[Cpp2IlInjected.Address(RVA = "0x5FBC630", Offset = "0x5FBB630", VA = "0x185FBC630")]
		public ShapeRendererConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[DefaultMember("Item")]
public class KMPJHKEDBHP : LIILGGONCFG, IDisposable, NKCLLGNMIJD
{
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static readonly HPPHLHFLMDP CGJPMMKJEHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly GMNKDMGLAMH<AKLCAEFHFBP, HENOGOOCAMO> CGIPOFGABNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly GMNKDMGLAMH<NNOBDEBBKFG, OFBKNODCNKF> GFKPHCLKMJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly GMNKDMGLAMH<HLIJEBGPFIJ, NGHAAMCFHMH> HJLFCPJLCDB;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public HENOGOOCAMO CLDBOBAGHND
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x5FB91B0", Offset = "0x5FB81B0", VA = "0x185FB91B0", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public OFBKNODCNKF CLDBOBAGHND
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x5FB90F0", Offset = "0x5FB80F0", VA = "0x185FB90F0", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public NGHAAMCFHMH CLDBOBAGHND
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x5FB9150", Offset = "0x5FB8150", VA = "0x185FB9150", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public bool DHJCMKDPBPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x967710", Offset = "0x966710", VA = "0x180967710", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x967960", Offset = "0x966960", VA = "0x180967960")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5FB9BC0", Offset = "0x5FB8BC0", VA = "0x185FB9BC0")]
	public KMPJHKEDBHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5FB8F00", Offset = "0x5FB7F00", VA = "0x185FB8F00", Slot = "21")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5FB99C0", Offset = "0x5FB89C0", VA = "0x185FB99C0", Slot = "4")]
	public AKLCAEFHFBP OEMBDDJKBML(FOEIFBHKJKA HHCEHFFEAKN)
	{
		return default(AKLCAEFHFBP);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5FB99C0", Offset = "0x5FB89C0", VA = "0x185FB99C0", Slot = "5")]
	public AKLCAEFHFBP OEMBDDJKBML(FOEIFBHKJKA HHCEHFFEAKN, bool MIAGKLJNADD)
	{
		return default(AKLCAEFHFBP);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5FB8E40", Offset = "0x5FB7E40", VA = "0x185FB8E40", Slot = "6")]
	public void CHGAMPDKFCE(AKLCAEFHFBP EMIPEAKIENF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5FB8F90", Offset = "0x5FB7F90", VA = "0x185FB8F90", Slot = "7")]
	public void FDBGLBAJPAP(AKLCAEFHFBP EMIPEAKIENF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5FB9210", Offset = "0x5FB8210", VA = "0x185FB9210", Slot = "8")]
	public NNOBDEBBKFG IJNNBPKBMPN(AKLCAEFHFBP EMIPEAKIENF, CJADDPALMFO HHCEHFFEAKN)
	{
		return default(NNOBDEBBKFG);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5FB9490", Offset = "0x5FB8490", VA = "0x185FB9490", Slot = "9")]
	public NNOBDEBBKFG OBFCGHBFOKI(AKLCAEFHFBP EMIPEAKIENF, APHDNBMIAEE HHCEHFFEAKN)
	{
		return default(NNOBDEBBKFG);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5FB9340", Offset = "0x5FB8340", VA = "0x185FB9340", Slot = "11")]
	public void KGKJCGBHFEO(NNOBDEBBKFG GFPPIEEIIPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x5FB93D0", Offset = "0x5FB83D0", VA = "0x185FB93D0", Slot = "10")]
	public void KJILCCOFPDC(NNOBDEBBKFG GFPPIEEIIPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5FB9080", Offset = "0x5FB8080", VA = "0x185FB9080", Slot = "20")]
	public IEnumerable<Renderer> GEFGKOONKNL(AKLCAEFHFBP EMIPEAKIENF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5FB8D60", Offset = "0x5FB7D60", VA = "0x185FB8D60", Slot = "12")]
	public HLIJEBGPFIJ AHPMLJNNCFG(LDPKPLKGLJC HHCEHFFEAKN)
	{
		return default(HLIJEBGPFIJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x5FB9010", Offset = "0x5FB8010", VA = "0x185FB9010", Slot = "14")]
	public void FGLKJNKLLIO(HLIJEBGPFIJ FINGNOGBGLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5FB8DE0", Offset = "0x5FB7DE0", VA = "0x185FB8DE0", Slot = "16")]
	public Task BGKFEDKGJCI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5FB9430", Offset = "0x5FB8430", VA = "0x185FB9430", Slot = "17")]
	public Task LNPLFDHJFML()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5FB9AD0", Offset = "0x5FB8AD0", VA = "0x185FB9AD0", Slot = "18")]
	public Task PFBFKAEMMEO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x202F9E0", Offset = "0x202E9E0", VA = "0x18202F9E0", Slot = "19")]
	public void EEEDKFEADMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5FB8EA0", Offset = "0x5FB7EA0", VA = "0x185FB8EA0", Slot = "13")]
	public void CPOGFJIMIFI(HLIJEBGPFIJ FINGNOGBGLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5FB95D0", Offset = "0x5FB85D0", VA = "0x185FB95D0", Slot = "25")]
	public HJFPJEFIOCE OBIKEMALLBA(ACILLLOIMMI PADEFKCDJKB, IEnumerable<NNOBDEBBKFG> GFKPHCLKMJB, int HEBAEOBIHEM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface ENNEDANDICL
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EDOKNOGGNKH(PIMHGPGHACE DPPJBLOOGOO, Renderer ELPJNGIEOGG, int EJEOOOFNHAL);

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EOMPGDLOKLO(Renderer ELPJNGIEOGG, NPADONEKPIO POJMCIAMNGD, Vector3 JHNNMDPKAFD, Vector3 ABLDLLLMMGI, Vector3 HJBDKPLCPOB, float PGNCBHODLFK, float HOHPELNKOOM, float MFGECGLKLAB = -1f, [Optional] Color? IFAEOGGHLKI, [Optional] IReadOnlyList<Camera> OHDJGAJGJGM);

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AJJNJKFDPDG(Renderer ELPJNGIEOGG, int EJEOOOFNHAL);

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int JGLNMPGCBLK();

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HCBEIPAMAGO(int BLBGBGHDLNK, PIHMDDPJOEG DPPJBLOOGOO, Renderer ELPJNGIEOGG, int EJEOOOFNHAL);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class DCCECCANIGL : GCDOOFPGHGD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private class MKMJBGKHIOI : EFHPOMFPJBG<int>
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x5FBA460", Offset = "0x5FB9460", VA = "0x185FBA460")]
		public MKMJBGKHIOI(string OALFIBFPPAC)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly ENNEDANDICL FFDOMIHFEOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly NKCLLGNMIJD PEJLBJDNNPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private MeshRenderer GPIAKJIBILJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private MKMJBGKHIOI PBCCPMIAJKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private bool PBIHMDNJKMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private MeshRenderer MPGJCGILJLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private MKMJBGKHIOI BKCKONLOOMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private bool GKCNCNHJHEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private MeshRenderer APODFMJNFGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private MKMJBGKHIOI NJDNGHFNFOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private bool GPPEICIHMBJ;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5FAFB80", Offset = "0x5FAEB80", VA = "0x185FAFB80")]
	public DCCECCANIGL(ENNEDANDICL GMNEGCALHOD, NKCLLGNMIJD PEJLBJDNNPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x5FAE260", Offset = "0x5FAD260", VA = "0x185FAE260", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x5FAE670", Offset = "0x5FAD670", VA = "0x185FAE670")]
	private void FIKBOJCJHDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x5FADE40", Offset = "0x5FACE40", VA = "0x185FADE40", Slot = "4")]
	public void DDIOJGEKEEC(AKLCAEFHFBP EMIPEAKIENF, PIHMDDPJOEG OCBHNJLEKLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x5FAE040", Offset = "0x5FAD040", VA = "0x185FAE040", Slot = "5")]
	public void DDIOJGEKEEC(NNOBDEBBKFG GFPPIEEIIPL, PIHMDDPJOEG OCBHNJLEKLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x5FAFA50", Offset = "0x5FAEA50", VA = "0x185FAFA50", Slot = "6")]
	public void PFFFHJKHBIL(NNOBDEBBKFG GFPPIEEIIPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x5FAF0A0", Offset = "0x5FAE0A0", VA = "0x185FAF0A0", Slot = "7")]
	public void INCFKMDONIN(NNOBDEBBKFG GFPPIEEIIPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x5FAF1C0", Offset = "0x5FAE1C0", VA = "0x185FAF1C0", Slot = "21")]
	public void JEMCPCDEEKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x11318F0", Offset = "0x11308F0", VA = "0x1811318F0", Slot = "8")]
	public void PIPEIGHLPON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5FAE500", Offset = "0x5FAD500", VA = "0x185FAE500", Slot = "9")]
	public void FHNOHMEEJMJ(PIHMDDPJOEG OCBHNJLEKLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5FAE950", Offset = "0x5FAD950", VA = "0x185FAE950", Slot = "10")]
	public void HBNNAMJFAIO(AKLCAEFHFBP EMIPEAKIENF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x5FAEB00", Offset = "0x5FADB00", VA = "0x185FAEB00", Slot = "11")]
	public void HBNNAMJFAIO(NNOBDEBBKFG GFPPIEEIIPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x5FADAD0", Offset = "0x5FACAD0", VA = "0x185FADAD0", Slot = "12")]
	public void CPNHBHLLHBF(AKLCAEFHFBP EMIPEAKIENF, PIMHGPGHACE DPPJBLOOGOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x5FAD8E0", Offset = "0x5FAC8E0", VA = "0x185FAD8E0", Slot = "13")]
	public void CPNHBHLLHBF(NNOBDEBBKFG GFPPIEEIIPL, PIMHGPGHACE DPPJBLOOGOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x5FAF200", Offset = "0x5FAE200", VA = "0x185FAF200", Slot = "22")]
	public void JHABMFOIGPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x5FAF240", Offset = "0x5FAE240", VA = "0x185FAF240", Slot = "14")]
	public void KDENDHDHAIL(NNOBDEBBKFG GFPPIEEIIPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x5FAE8C0", Offset = "0x5FAD8C0", VA = "0x185FAE8C0", Slot = "15")]
	public void GFLOOECLNPF(NNOBDEBBKFG GFPPIEEIIPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0xA39B60", Offset = "0xA38B60", VA = "0x180A39B60", Slot = "16")]
	public void HPNDGNMEFFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x5FAD7A0", Offset = "0x5FAC7A0", VA = "0x185FAD7A0", Slot = "17")]
	public void BNBPCEHHMCK(PIMHGPGHACE DPPJBLOOGOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x5FAEE50", Offset = "0x5FADE50", VA = "0x185FAEE50")]
	private void HGEFIDGLCHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x5FADC80", Offset = "0x5FACC80", VA = "0x185FADC80")]
	public void CPNHBHLLHBF(NNOBDEBBKFG GFPPIEEIIPL, PIMHGPGHACE DPPJBLOOGOO, bool OMKLDDGDFHL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x5FAE430", Offset = "0x5FAD430", VA = "0x185FAE430")]
	private void EDOKNOGGNKH(PIMHGPGHACE DPPJBLOOGOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x5FAF2E0", Offset = "0x5FAE2E0", VA = "0x185FAF2E0", Slot = "18")]
	public void NEEGIAEPOEK(AKLCAEFHFBP EMIPEAKIENF, Vector3 JHNNMDPKAFD, Vector3 ABLDLLLMMGI, Vector3 HJBDKPLCPOB, float PGNCBHODLFK, float HOHPELNKOOM, IReadOnlyList<Camera> JGMLJEHPKJF, NPADONEKPIO POJMCIAMNGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x5FAF650", Offset = "0x5FAE650", VA = "0x185FAF650", Slot = "19")]
	public void NEEGIAEPOEK(HLIJEBGPFIJ FINGNOGBGLO, Vector3 JHNNMDPKAFD, Vector3 ABLDLLLMMGI, Vector3 HJBDKPLCPOB, float PGNCBHODLFK, float HOHPELNKOOM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class DPEGGLHFHKE
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class JJOFOPHAPKP : IEnumerable<FBCKJPNJLOA>, IEnumerable, IEnumerator<FBCKJPNJLOA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private FBCKJPNJLOA <>2__current;

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
		private FBCKJPNJLOA System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.PrimitiveShapeMeshData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0xC531B0", Offset = "0xC521B0", VA = "0x180C531B0")]
		[DebuggerHidden]
		public JJOFOPHAPKP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x5FB8610", Offset = "0x5FB7610", VA = "0x185FB8610", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x5FB8780", Offset = "0x5FB7780", VA = "0x185FB8780", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x5FB86F0", Offset = "0x5FB76F0", VA = "0x185FB86F0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<FBCKJPNJLOA> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.PrimitiveShapeMeshData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x5FB86F0", Offset = "0x5FB76F0", VA = "0x185FB86F0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public const int GAMONFKCIGG = 3;

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private static FBCKJPNJLOA[][] PCGDKJMKBON;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private static CLAAONOHOMC DJGGKOOLJKE;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public static ShapeRendererConfig IBBNBOEIDHH;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public static ComputeShader LJCDGDOHPLG
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x5FB02F0", Offset = "0x5FAF2F0", VA = "0x185FB02F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public static SkinnedShapeRenderer BADPLIGEBDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x5FAFD40", Offset = "0x5FAED40", VA = "0x185FAFD40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x5FB05E0", Offset = "0x5FAF5E0", VA = "0x185FB05E0")]
	public static Mesh OJIGAOIGMDG(INJOGMFMJMF GCOLHDNAMDD, int MIIMEHOHOHP = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x5FAFD30", Offset = "0x5FAED30", VA = "0x185FAFD30")]
	public static int APHGADOJKAA(INJOGMFMJMF GCOLHDNAMDD, int MIIMEHOHOHP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x5FAFBD0", Offset = "0x5FAEBD0", VA = "0x185FAFBD0")]
	public static CLAAONOHOMC ALMNBIBBMCI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x5FB0360", Offset = "0x5FAF360", VA = "0x185FB0360")]
	[IteratorStateMachine(typeof(JJOFOPHAPKP))]
	private static IEnumerable<FBCKJPNJLOA> MKFMDBLHIHE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x5FAFF60", Offset = "0x5FAEF60", VA = "0x185FAFF60")]
	public static FBCKJPNJLOA JDEIINLHPFO(INJOGMFMJMF GCOLHDNAMDD, int MIIMEHOHOHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x5FB02D0", Offset = "0x5FAF2D0", VA = "0x185FB02D0")]
	public static bool LFDALDCFMLA(this INJOGMFMJMF GCOLHDNAMDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x5FAFDB0", Offset = "0x5FAEDB0", VA = "0x185FAFDB0")]
	public static void HPACCJBIDHF(INJOGMFMJMF GCOLHDNAMDD, float3 ACAMPKDJMNG, out FEIKCCHCAPN KGLCKMFNJPL, out float3 GLEOCFBGHFG, out float ODOJJHOHODI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x5FB06A0", Offset = "0x5FAF6A0", VA = "0x185FB06A0")]
	public static void ONMHNAKPFOE(Vector3 ACAMPKDJMNG, INJOGMFMJMF GCOLHDNAMDD, out Vector3 GLEOCFBGHFG, out float ODOJJHOHODI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x5FB02C0", Offset = "0x5FAF2C0", VA = "0x185FB02C0")]
	[JOOLBCFGFFN(LLJHODDJBDJ.ExitingPlayMode, 0)]
	private static void KJJBJDEGFBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x5FB03C0", Offset = "0x5FAF3C0", VA = "0x185FB03C0")]
	[JOOLBCFGFFN(LLJHODDJBDJ.ExitingPlayMode, 0)]
	private static void NLEMCALNDOJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public abstract class OFBKNODCNKF : INEOICAMCJM, DENCHOJPCHA, DKMLPHJKMAB, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public readonly HENOGOOCAMO LGIBJPCGOGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	protected Bounds LCDINHEGGAG;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public Bounds CKMEDMIOMAA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x125E2A0", Offset = "0x125D2A0", VA = "0x18125E2A0", Slot = "4")]
		get
		{
			return default(Bounds);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public virtual EBAGCCGNCIL NNPJNCBNBFE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x5FBC540", Offset = "0x5FBB540", VA = "0x185FBC540", Slot = "17")]
		get
		{
			return default(EBAGCCGNCIL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public bool AHJFANNBPFD
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x90AA90", Offset = "0x909A90", VA = "0x18090AA90")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x90AAA0", Offset = "0x909AA0", VA = "0x18090AAA0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	protected abstract Hash128 GBDNONHINKA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int MONNOPMPIOO
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x90AF50", Offset = "0x909F50", VA = "0x18090AF50", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public NLIFOJGJFBH ENEJIJBFPBD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x871190", Offset = "0x870190", VA = "0x180871190")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x871150", Offset = "0x870150", VA = "0x180871150")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public bool HOEFNGAOIEK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x34D3890", Offset = "0x34D2890", VA = "0x1834D3890")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x919D70", Offset = "0x918D70", VA = "0x180919D70")]
	protected OFBKNODCNKF(HENOGOOCAMO EMIPEAKIENF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x5FBC410", Offset = "0x5FBB410", VA = "0x185FBC410", Slot = "15")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x98E270", Offset = "0x98D270", VA = "0x18098E270", Slot = "16")]
	public virtual bool EOGAIECIADI(ACILLLOIMMI EMIPEAKIENF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "18")]
	public abstract int JICOMBGOCJC(DFCJNAGAOHO MIIMEHOHOHP);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "19")]
	public abstract int EHOEKGOBFKE(DFCJNAGAOHO MIIMEHOHOHP);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "20")]
	public abstract void DHBKEKLMDMK(DFCJNAGAOHO MIIMEHOHOHP, GFJOMOPMDPO NADNFMJCGMD, int OCJLFGBNHEM = -1);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "21")]
	public abstract ACILLLOIMMI DODBFEMHKIE();

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x5FBC600", Offset = "0x5FBB600", VA = "0x185FBC600", Slot = "11")]
	public Hash128 PJIMLALLHOF(int MIIMEHOHOHP)
	{
		return default(Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "23")]
	public abstract KGKCLAPONIK KCKAGANMAKM();

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "24")]
	public abstract MHGJOOJMMIJ EBMPBHGEHJB(DFCJNAGAOHO MIIMEHOHOHP, JobHandle AAPDDMNNEHG);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x5FBC5D0", Offset = "0x5FBB5D0", VA = "0x185FBC5D0", Slot = "10")]
	public MHGJOOJMMIJ OBIKEMALLBA(int MIIMEHOHOHP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class GJKFMNALECJ : OFBKNODCNKF
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	private struct NNHCBAOPFJJ : MHGJOOJMMIJ, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private GKDOHBEKBBP CAFDMHFNNHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private JobHandle AAPDDMNNEHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private BIJNMMHGIDB OJLOHBNBAMO;

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x5FBC3B0", Offset = "0x5FBB3B0", VA = "0x185FBC3B0")]
		public NNHCBAOPFJJ(GKDOHBEKBBP CAFDMHFNNHI, JobHandle AAPDDMNNEHG, BIJNMMHGIDB OJLOHBNBAMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x37467D0", Offset = "0x37457D0", VA = "0x1837467D0")]
		public bool PHDAMLHGKHI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x5FBC330", Offset = "0x5FBB330", VA = "0x185FBC330", Slot = "4")]
		public GKDOHBEKBBP DGCOAPBJKNO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x5FBC360", Offset = "0x5FBB360", VA = "0x185FBC360", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private readonly APHDNBMIAEE LADCHHKJMOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private float LMBOOFOFFBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private Hash128 PDHOMPALHND;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	protected override Hash128 GBDNONHINKA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x5FB51B0", Offset = "0x5FB41B0", VA = "0x185FB51B0", Slot = "22")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x5FB52D0", Offset = "0x5FB42D0", VA = "0x185FB52D0")]
	public GJKFMNALECJ(HENOGOOCAMO EMIPEAKIENF, APHDNBMIAEE HHCEHFFEAKN, bool MIAGKLJNADD = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x98E270", Offset = "0x98D270", VA = "0x18098E270", Slot = "16")]
	public override bool EOGAIECIADI(ACILLLOIMMI EMIPEAKIENF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x5FB4DA0", Offset = "0x5FB3DA0", VA = "0x185FB4DA0", Slot = "18")]
	public override int JICOMBGOCJC(DFCJNAGAOHO MIIMEHOHOHP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x5FB4BB0", Offset = "0x5FB3BB0", VA = "0x185FB4BB0", Slot = "19")]
	public override int EHOEKGOBFKE(DFCJNAGAOHO MIIMEHOHOHP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x5FB3B40", Offset = "0x5FB2B40", VA = "0x185FB3B40", Slot = "20")]
	public override void DHBKEKLMDMK(DFCJNAGAOHO MIIMEHOHOHP, GFJOMOPMDPO NADNFMJCGMD, int OCJLFGBNHEM = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x5FB4220", Offset = "0x5FB3220", VA = "0x185FB4220", Slot = "21")]
	public override ACILLLOIMMI DODBFEMHKIE()
	{
		return default(ACILLLOIMMI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x5FB4F90", Offset = "0x5FB3F90", VA = "0x185FB4F90", Slot = "23")]
	public override KGKCLAPONIK KCKAGANMAKM()
	{
		return default(KGKCLAPONIK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x5FB42F0", Offset = "0x5FB32F0", VA = "0x185FB42F0", Slot = "24")]
	public override MHGJOOJMMIJ EBMPBHGEHJB(DFCJNAGAOHO MIIMEHOHOHP, JobHandle AAPDDMNNEHG)
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
		private MaterialPropertyBlock GMOJKGCFDDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private IAOILCHOBPE CAFDMHFNNHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private List<ACILLLOIMMI> OAGPGHOCMHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private RenderTexture GCDDAKGFBLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private ComputeBuffer DLNNDFBKEHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private ComputeShader EIDCHPLLACP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private Matrix4x4[] DOKENCEBLIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private int DMFEOFJDLIG;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public MeshRenderer JHABGEALIEA
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x9132E0", Offset = "0x9122E0", VA = "0x1809132E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public int DMGBFPHHFMP
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x5FBD2F0", Offset = "0x5FBC2F0", VA = "0x185FBD2F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x5FBC660", Offset = "0x5FBB660", VA = "0x185FBC660")]
		public static List<SkinnedShapeRenderer> Create(GameObject EMIPEAKIENF, List<IAOILCHOBPE> HGLOFKKOHCA, List<ACILLLOIMMI> OAGPGHOCMHI, Material HDEIKJNIFFB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x5FBCCA0", Offset = "0x5FBBCA0", VA = "0x185FBCCA0")]
		public void Init(IAOILCHOBPE CAFDMHFNNHI, List<ACILLLOIMMI> OAGPGHOCMHI, Material HDEIKJNIFFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x5FBD240", Offset = "0x5FBC240", VA = "0x185FBD240")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x5FBD190", Offset = "0x5FBC190", VA = "0x185FBD190")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x5FBD150", Offset = "0x5FBC150", VA = "0x185FBD150")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x5FBCA70", Offset = "0x5FBBA70", VA = "0x185FBCA70")]
		private void IEPOLOFEKAM(ScriptableRenderContext AEOEKGNDHFM, Camera[] NNFCIDDKAOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x5FBC8B0", Offset = "0x5FBB8B0", VA = "0x185FBC8B0")]
		private void FPEHEHBPPGI(CommandBuffer GILLNIMAFKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x85F0C0", Offset = "0x85E0C0", VA = "0x18085F0C0")]
		public SkinnedShapeRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface JODELCPIGHA
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	bool KPMCOMMLILO
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Material KKIICCHFLBD();

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Material AECBMEKNCGD();

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Material ADFNOGDLPKJ();

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int HKHCDJELKNA(KADGINDIKPL ABNBGNGEODI);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int LLGMOAFPHPD(BACGCBKMFNG KHFMHNNILJD);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ECCBONCOKCP(GameObject EOHGDDIECBJ);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void IKJCKPJJDPH(GameObject EOHGDDIECBJ, bool FBLFOGOKFMF);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class GKEHCBLGCGE
{
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static JODELCPIGHA HBKAFCIHEAM;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public static bool KPMCOMMLILO
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x5FB5780", Offset = "0x5FB4780", VA = "0x185FB5780")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x5FB5440", Offset = "0x5FB4440", VA = "0x185FB5440")]
	public static void DIGJMFIMJMN(JODELCPIGHA OEDOAHPAFHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x5FB56B0", Offset = "0x5FB46B0", VA = "0x185FB56B0")]
	public static Material KKIICCHFLBD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x5FB53E0", Offset = "0x5FB43E0", VA = "0x185FB53E0")]
	public static Material AECBMEKNCGD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x5FB5380", Offset = "0x5FB4380", VA = "0x185FB5380")]
	public static Material ADFNOGDLPKJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x5FB5560", Offset = "0x5FB4560", VA = "0x185FB5560")]
	public static int HKHCDJELKNA(KADGINDIKPL ABNBGNGEODI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x5FB5710", Offset = "0x5FB4710", VA = "0x185FB5710")]
	public static int LLGMOAFPHPD(BACGCBKMFNG KHFMHNNILJD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x5FB5490", Offset = "0x5FB4490", VA = "0x185FB5490")]
	public static void ECCBONCOKCP(GameObject EOHGDDIECBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x5FB55D0", Offset = "0x5FB45D0", VA = "0x185FB55D0")]
	public static void IKJCKPJJDPH(GameObject EOHGDDIECBJ, bool FBLFOGOKFMF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[DefaultMember("Item")]
public class CDNDPFFMEKK : LIILGGONCFG, IDisposable, NKCLLGNMIJD
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class LKICMHOFIMC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public CDNDPFFMEKK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public LKICMHOFIMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x5FB9FA0", Offset = "0x5FB8FA0", VA = "0x185FB9FA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly GMNKDMGLAMH<AKLCAEFHFBP, HENOGOOCAMO> CGIPOFGABNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly GMNKDMGLAMH<NNOBDEBBKFG, OFBKNODCNKF> GFKPHCLKMJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly GMNKDMGLAMH<HLIJEBGPFIJ, NGHAAMCFHMH> HJLFCPJLCDB;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public HENOGOOCAMO CLDBOBAGHND
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x5FAB620", Offset = "0x5FAA620", VA = "0x185FAB620", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public OFBKNODCNKF CLDBOBAGHND
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x5FAB680", Offset = "0x5FAA680", VA = "0x185FAB680", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public NGHAAMCFHMH CLDBOBAGHND
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x5FAB6E0", Offset = "0x5FAA6E0", VA = "0x185FAB6E0", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool DHJCMKDPBPL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x967710", Offset = "0x966710", VA = "0x180967710", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x967960", Offset = "0x966960", VA = "0x180967960")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x5FAD2E0", Offset = "0x5FAC2E0", VA = "0x185FAD2E0")]
	public CDNDPFFMEKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x5FAAF80", Offset = "0x5FA9F80", VA = "0x185FAAF80", Slot = "21")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x5FAD1B0", Offset = "0x5FAC1B0", VA = "0x185FAD1B0", Slot = "4")]
	public AKLCAEFHFBP OEMBDDJKBML(FOEIFBHKJKA HHCEHFFEAKN)
	{
		return default(AKLCAEFHFBP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x5FACF20", Offset = "0x5FABF20", VA = "0x185FACF20", Slot = "5")]
	public AKLCAEFHFBP OEMBDDJKBML(FOEIFBHKJKA HHCEHFFEAKN, bool MIAGKLJNADD)
	{
		return default(AKLCAEFHFBP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x5FAACB0", Offset = "0x5FA9CB0", VA = "0x185FAACB0", Slot = "6")]
	public void CHGAMPDKFCE(AKLCAEFHFBP EMIPEAKIENF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x5FAB1B0", Offset = "0x5FAA1B0", VA = "0x185FAB1B0", Slot = "7")]
	public void FDBGLBAJPAP(AKLCAEFHFBP EMIPEAKIENF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x5FAB740", Offset = "0x5FAA740", VA = "0x185FAB740", Slot = "8")]
	public NNOBDEBBKFG IJNNBPKBMPN(AKLCAEFHFBP EMIPEAKIENF, CJADDPALMFO HHCEHFFEAKN)
	{
		return default(NNOBDEBBKFG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x5FAC400", Offset = "0x5FAB400", VA = "0x185FAC400", Slot = "9")]
	public NNOBDEBBKFG OBFCGHBFOKI(AKLCAEFHFBP EMIPEAKIENF, APHDNBMIAEE HHCEHFFEAKN)
	{
		return default(NNOBDEBBKFG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x5FABC40", Offset = "0x5FAAC40", VA = "0x185FABC40", Slot = "11")]
	public void KGKJCGBHFEO(NNOBDEBBKFG GFPPIEEIIPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x5FAC030", Offset = "0x5FAB030", VA = "0x185FAC030", Slot = "10")]
	public void KJILCCOFPDC(NNOBDEBBKFG GFPPIEEIIPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x5FAB5B0", Offset = "0x5FAA5B0", VA = "0x185FAB5B0", Slot = "20")]
	public IEnumerable<Renderer> GEFGKOONKNL(AKLCAEFHFBP EMIPEAKIENF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x5FAAAC0", Offset = "0x5FA9AC0", VA = "0x185FAAAC0", Slot = "12")]
	public HLIJEBGPFIJ AHPMLJNNCFG(LDPKPLKGLJC HHCEHFFEAKN)
	{
		return default(HLIJEBGPFIJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x5FAB540", Offset = "0x5FAA540", VA = "0x185FAB540", Slot = "14")]
	public void FGLKJNKLLIO(HLIJEBGPFIJ FINGNOGBGLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x5FAAB40", Offset = "0x5FA9B40", VA = "0x185FAAB40", Slot = "16")]
	public Task BGKFEDKGJCI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x5FAC2A0", Offset = "0x5FAB2A0", VA = "0x185FAC2A0", Slot = "17")]
	public Task LNPLFDHJFML()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x5FAD1C0", Offset = "0x5FAC1C0", VA = "0x185FAD1C0", Slot = "18")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LKICMHOFIMC))]
	public Task PFBFKAEMMEO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x5FAB120", Offset = "0x5FAA120", VA = "0x185FAB120", Slot = "19")]
	public void EEEDKFEADMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x5FAAF20", Offset = "0x5FA9F20", VA = "0x185FAAF20", Slot = "13")]
	public void CPOGFJIMIFI(HLIJEBGPFIJ FINGNOGBGLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x5FAC900", Offset = "0x5FAB900", VA = "0x185FAC900", Slot = "25")]
	public HJFPJEFIOCE OBIKEMALLBA(ACILLLOIMMI PADEFKCDJKB, IEnumerable<NNOBDEBBKFG> GFKPHCLKMJB, int HEBAEOBIHEM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class IAOILCHOBPE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	private struct JKOJDCIMKPP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public GFJOMOPMDPO GOMEFKLJPAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public ACILLLOIMMI LPLHCJPGDFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public int FKDJJNGGBAN;
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class MLBBBGLDGGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public IAOILCHOBPE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public int numVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public int numIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public DFCJNAGAOHO lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public List<JKOJDCIMKPP> boneMeshInfos;

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public MLBBBGLDGGM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class HNDFBECNNOI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public GKDOHBEKBBP combinedMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public MLBBBGLDGGM CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public HNDFBECNNOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x5FB71F0", Offset = "0x5FB61F0", VA = "0x185FB71F0")]
		internal JobHandle CKJNPEBKMCD()
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x5FB7260", Offset = "0x5FB6260", VA = "0x185FB7260")]
		internal void MJJEDNNJMFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x5FB7080", Offset = "0x5FB6080", VA = "0x185FB7080")]
		internal void ADLILJDDLPK()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private int[] MPDGAKJHELC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private HKHCKEGFFGD MLNOMIAGILE;

	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private static Matrix4x4 LFKCMNGJIHC;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public Mesh JHBJADCDBMI
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x85E070", Offset = "0x85D070", VA = "0x18085E070")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x9132F0", Offset = "0x9122F0", VA = "0x1809132F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public int LMCKHBKBMBM
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x9AEAB0", Offset = "0x9ADAB0", VA = "0x1809AEAB0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x9AEAC0", Offset = "0x9ADAC0", VA = "0x1809AEAC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x5FB7310", Offset = "0x5FB6310", VA = "0x185FB7310")]
	public void FPEHEHBPPGI(List<ACILLLOIMMI> ICBICJKJKNI, Matrix4x4[] GPFJBAOHLMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x5FB7960", Offset = "0x5FB6960", VA = "0x185FB7960")]
	public static List<IAOILCHOBPE> HFOCJEBDOBL(List<HENOGOOCAMO> LIKNALIBAFD, DFCJNAGAOHO MIIMEHOHOHP, Bounds EFLBJLIBMOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x5FB7570", Offset = "0x5FB6570", VA = "0x185FB7570")]
	private JobHandle GKNIFMBDLGE(GKDOHBEKBBP BDDIJICADGF, int PKDDMNPFIME, int BKDICOGELCP, DFCJNAGAOHO MIIMEHOHOHP, List<JKOJDCIMKPP> EAIMNGPFEFF)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x5FB7FA0", Offset = "0x5FB6FA0", VA = "0x185FB7FA0")]
	private void KDCAAJMJCBG(List<JKOJDCIMKPP> EAIMNGPFEFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x5FB81E0", Offset = "0x5FB71E0", VA = "0x185FB81E0")]
	private IAOILCHOBPE(List<JKOJDCIMKPP> EAIMNGPFEFF, int PKDDMNPFIME, int BKDICOGELCP, DFCJNAGAOHO MIIMEHOHOHP, Bounds EFLBJLIBMOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x5FB72A0", Offset = "0x5FB62A0", VA = "0x185FB72A0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class NGHAAMCFHMH : LLEGFGPJOLH
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class FMHHHKLBONI : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public NGHAAMCFHMH <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0xC531B0", Offset = "0xC521B0", VA = "0x180C531B0")]
		[DebuggerHidden]
		public FMHHHKLBONI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x5FB15D0", Offset = "0x5FB05D0", VA = "0x185FB15D0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x5FB12D0", Offset = "0x5FB02D0", VA = "0x185FB12D0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x5FB1280", Offset = "0x5FB0280", VA = "0x185FB1280")]
		private void MHEJAKKMIEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x5FB1590", Offset = "0x5FB0590", VA = "0x185FB1590", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x5FB14F0", Offset = "0x5FB04F0", VA = "0x185FB14F0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x5FB14F0", Offset = "0x5FB04F0", VA = "0x185FB14F0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly LDPKPLKGLJC EHHJPBNJING;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly NKCLLGNMIJD PEJLBJDNNPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private NEGKMIGABFA KBGFLFJCBGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private List<IAOILCHOBPE> IFOBILOIFKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private List<IAOILCHOBPE> NKBFPFHMGDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private GameObject BLNFHCGEPMF;

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x5FBAEE0", Offset = "0x5FB9EE0", VA = "0x185FBAEE0")]
	public static NGHAAMCFHMH LNKIAHGKMCA(LDPKPLKGLJC HHCEHFFEAKN, NKCLLGNMIJD PEJLBJDNNPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x5FBC230", Offset = "0x5FBB230", VA = "0x185FBC230")]
	private NGHAAMCFHMH(LDPKPLKGLJC HHCEHFFEAKN, NKCLLGNMIJD PEJLBJDNNPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x5FBBD70", Offset = "0x5FBAD70", VA = "0x185FBBD70")]
	public void OJEHGLDDBNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x5FBADD0", Offset = "0x5FB9DD0", VA = "0x185FBADD0")]
	[IteratorStateMachine(typeof(FMHHHKLBONI))]
	public IEnumerable<Renderer> IMAFJDBDBFA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x5FBB290", Offset = "0x5FBA290", VA = "0x185FBB290", Slot = "4")]
	public void OFEEDNLDJAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x5FBAE40", Offset = "0x5FB9E40", VA = "0x185FBAE40")]
	private void LKNHKHHEGFJ(Vector3 NPDFNOJGKKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x5FBB050", Offset = "0x5FBA050", VA = "0x185FBB050")]
	public void MCCBAFPODDI()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class MHGFMJKAFPI
{
	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
	public MHGFMJKAFPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0xBB9C20", Offset = "0xBB8C20", VA = "0x180BB9C20")]
	public static string KILOLNAHAFI(byte[] BKIADALNNFJ, byte[] EEICCMPLMOJ)
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
