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
public interface FEFCOAJHEBB
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	APCLIOCKJBL OFCFHOOOGOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	LIIAPCDJDEL OFCFHOOOGOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	IIGFAGIMHCH OFCFHOOOGOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class ONBENFKLKIG : GFOJBNFDANC, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private byte KOHNBLCOHHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly List<SkinnedShapeRenderer>[] HKADDOHOJLI;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int BEACKHDCNGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA71600", Offset = "0xA70A00", VA = "0x180A71600", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xC0E800", Offset = "0xC0DC00", VA = "0x180C0E800")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int FONHLIGNEKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1190BC0", Offset = "0x118FFC0", VA = "0x181190BC0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x12BA4D0", Offset = "0x12B98D0", VA = "0x1812BA4D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public float MHCJIJGOLNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xCCDA40", Offset = "0xCCCE40", VA = "0x180CCDA40", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xCCDA30", Offset = "0xCCCE30", VA = "0x180CCDA30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public float CFMMDLPIBCF
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xFF21A0", Offset = "0xFF15A0", VA = "0x180FF21A0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8FD500", Offset = "0x8FC900", VA = "0x1808FD500")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public List<SkinnedShapeRenderer> GGOJBCELHAN
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5EB49F0", Offset = "0x5EB3DF0", VA = "0x185EB49F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public List<SkinnedShapeRenderer> DIIODDAPOEG
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5EB4A50", Offset = "0x5EB3E50", VA = "0x185EB4A50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public GameObject KABGFLLOEDM
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8BC350", Offset = "0x8BB750", VA = "0x1808BC350")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x940BC0", Offset = "0x93FFC0", VA = "0x180940BC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public byte GFFBCHNDGHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5EB4890", Offset = "0x5EB3C90", VA = "0x185EB4890", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5EB4A90", Offset = "0x5EB3E90", VA = "0x185EB4A90")]
	public ONBENFKLKIG(List<OOAMMBJFAKN> GFFCFNPJFGH, List<OOAMMBJFAKN> PNFEHHEBLPL, List<BCHJJGNIBBC> OMMMDDPFLCJ, Material JMOIMJGFABM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5EB48E0", Offset = "0x5EB3CE0", VA = "0x185EB48E0")]
	private int MACFJJIHDCL(List<OOAMMBJFAKN> FAMPJNHHBCJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5EB4700", Offset = "0x5EB3B00", VA = "0x185EB4700")]
	private void EMAGKHMKNJM(int GPLMGBCPPGJ, bool IDLFGFDILBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5EB4530", Offset = "0x5EB3930", VA = "0x185EB4530")]
	public void BFBDMNJKEGC(Vector3 GKGMFICPCKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5EB45D0", Offset = "0x5EB39D0", VA = "0x185EB45D0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5EB4850", Offset = "0x5EB3C50", VA = "0x185EB4850")]
	public void HFJFJALPLKM(Transform GOFLJMKGPLE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
internal class ACHECEIGBJA : LIIAPCDJDEL
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	private struct PNMMLCPAKJA : AJJFHGLFKIL, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private JOECMCGOEAB JDDLDLKOEPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private JobHandle FPNNHINBDNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private JMHAFODIDDG IPLIMAEPAFO;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x5EB6240", Offset = "0x5EB5640", VA = "0x185EB6240")]
		public PNMMLCPAKJA(JOECMCGOEAB JDDLDLKOEPJ, JobHandle FPNNHINBDNF, JMHAFODIDDG IPLIMAEPAFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5EB6210", Offset = "0x5EB5610", VA = "0x185EB6210", Slot = "4")]
		public JOECMCGOEAB OLKGFACPIPC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5EB61C0", Offset = "0x5EB55C0", VA = "0x185EB61C0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly PDNKFDPIEAN PFGIEBFKMGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private int[] BOLMEENDLAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private Hash128 LENAGOJINOA;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override NJFPOCMMNBI IFKOGCFDLGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5EA6370", Offset = "0x5EA5770", VA = "0x185EA6370", Slot = "16")]
		get
		{
			return default(NJFPOCMMNBI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private Vector3 GHCEGEJPOCO
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5EA6A00", Offset = "0x5EA5E00", VA = "0x185EA6A00")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	protected override Hash128 ODEFOHPJDCN
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5EA7530", Offset = "0x5EA6930", VA = "0x185EA7530", Slot = "21")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5EA7720", Offset = "0x5EA6B20", VA = "0x185EA7720")]
	public ACHECEIGBJA(APCLIOCKJBL COMCNEGAGFF, PDNKFDPIEAN KJFNAECAHBA, bool NCLPGPKFAHA = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5EA6F60", Offset = "0x5EA6360", VA = "0x185EA6F60", Slot = "15")]
	public override bool KPLKJDMPIHL(BCHJJGNIBBC COMCNEGAGFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5EA73D0", Offset = "0x5EA67D0", VA = "0x185EA73D0", Slot = "17")]
	public override int MACFJJIHDCL(KLIDPHGEHON EFOLHNEOCOK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5EA7480", Offset = "0x5EA6880", VA = "0x185EA7480", Slot = "18")]
	public override int MMDLACCCFFC(KLIDPHGEHON EFOLHNEOCOK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5EA6740", Offset = "0x5EA5B40", VA = "0x185EA6740")]
	private int FNMMHLKABEG(KLIDPHGEHON EFOLHNEOCOK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5EA5BE0", Offset = "0x5EA4FE0", VA = "0x185EA5BE0", Slot = "19")]
	public override void BDFLOJCKANH(KLIDPHGEHON EFOLHNEOCOK, IDFGGMEHFCA IPHCOLEMOED, int FNIFACHHFIE = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5EA7650", Offset = "0x5EA6A50", VA = "0x185EA7650", Slot = "20")]
	public override BCHJJGNIBBC PMKLLIGFFND()
	{
		return default(BCHJJGNIBBC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5EA6D40", Offset = "0x5EA6140", VA = "0x185EA6D40", Slot = "22")]
	public override OKMPIFBDOGC KJKFHCLNECO()
	{
		return default(OKMPIFBDOGC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5EA53C0", Offset = "0x5EA47C0", VA = "0x185EA53C0", Slot = "23")]
	public override AJJFHGLFKIL APNNGLFACLF(KLIDPHGEHON EFOLHNEOCOK, JobHandle FPNNHINBDNF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class APCLIOCKJBL : PFJHCGJMEBE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class AIIKHGHCINO : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public APCLIOCKJBL <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x7F3130", Offset = "0x7F2530", VA = "0x1807F3130", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x7F3130", Offset = "0x7F2530", VA = "0x1807F3130", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xB48080", Offset = "0xB47480", VA = "0x180B48080")]
		[DebuggerHidden]
		public AIIKHGHCINO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x5EA7E80", Offset = "0x5EA7280", VA = "0x185EA7E80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x5EA78C0", Offset = "0x5EA6CC0", VA = "0x185EA78C0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x5EA7870", Offset = "0x5EA6C70", VA = "0x185EA7870")]
		private void MIMEIPDHABP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x5EA77D0", Offset = "0x5EA6BD0", VA = "0x185EA77D0")]
		private void HHNPGKLOEAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x5EA7820", Offset = "0x5EA6C20", VA = "0x185EA7820")]
		private void KPEBHLKNEPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x5EA7E40", Offset = "0x5EA7240", VA = "0x185EA7E40", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x5EA7DA0", Offset = "0x5EA71A0", VA = "0x185EA7DA0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x5EA7DA0", Offset = "0x5EA71A0", VA = "0x185EA7DA0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class MENPABJEOKB : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public APCLIOCKJBL <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x7F3130", Offset = "0x7F2530", VA = "0x1807F3130", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x7F3130", Offset = "0x7F2530", VA = "0x1807F3130", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xB48080", Offset = "0xB47480", VA = "0x180B48080")]
		[DebuggerHidden]
		public MENPABJEOKB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x5EB4450", Offset = "0x5EB3850", VA = "0x185EB4450", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x5EB4030", Offset = "0x5EB3430", VA = "0x185EB4030", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x5EB3FE0", Offset = "0x5EB33E0", VA = "0x185EB3FE0")]
		private void MIMEIPDHABP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x5EB3F90", Offset = "0x5EB3390", VA = "0x185EB3F90")]
		private void HHNPGKLOEAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x5EB4410", Offset = "0x5EB3810", VA = "0x185EB4410", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x5EB4370", Offset = "0x5EB3770", VA = "0x185EB4370", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x5EB4370", Offset = "0x5EB3770", VA = "0x185EB4370", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly HCNNDKBMFHP OKKOAJDBCJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly List<LIIAPCDJDEL> EJKBCPIIGMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private List<ClusterMeshRenderer> EEKLNEIPBOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private BatchedMeshRenderer LBKIBFBJCEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private bool LPOPJHGAINF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly bool DKNHIHCPMLF;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IEnumerable<LDLHGGFFDIB> PALIHKFKHEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7F3130", Offset = "0x7F2530", VA = "0x1807F3130", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int GCPEGCDLJDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x5EA8300", Offset = "0x5EA7700", VA = "0x185EA8300", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public BCHJJGNIBBC DEEBLLPIHHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x5EA8240", Offset = "0x5EA7640", VA = "0x185EA8240", Slot = "8")]
		get
		{
			return default(BCHJJGNIBBC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public List<SkinnedShapeRenderer> LGHGFPGHOGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x94BE70", Offset = "0x94B270", VA = "0x18094BE70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x94BE50", Offset = "0x94B250", VA = "0x18094BE50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5EA86F0", Offset = "0x5EA7AF0", VA = "0x185EA86F0")]
	private bool EIBAPIBMCDA(LIIAPCDJDEL HELMOINPHOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5EA93B0", Offset = "0x5EA87B0", VA = "0x185EA93B0")]
	private static bool NKFEOHPFFBA(LIIAPCDJDEL HELMOINPHOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5EA9730", Offset = "0x5EA8B30", VA = "0x185EA9730")]
	public APCLIOCKJBL(HCNNDKBMFHP KJFNAECAHBA, bool PJMCGPGHDEA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5EA8340", Offset = "0x5EA7740", VA = "0x185EA8340", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5EA84C0", Offset = "0x5EA78C0", VA = "0x185EA84C0")]
	public void EBOHBLNDMAL(LIIAPCDJDEL HELMOINPHOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5EA93D0", Offset = "0x5EA87D0", VA = "0x185EA93D0")]
	public void PBDAKCGNFND(LIIAPCDJDEL HELMOINPHOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5EA8F10", Offset = "0x5EA8310", VA = "0x185EA8F10", Slot = "4")]
	public void MHOGELOLFGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5EA7FF0", Offset = "0x5EA73F0", VA = "0x185EA7FF0")]
	public void COCGDBGCNKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5EA95A0", Offset = "0x5EA89A0", VA = "0x185EA95A0")]
	private void PDPBHIHBJKF(List<LIIAPCDJDEL> EJKBCPIIGMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5EA8890", Offset = "0x5EA7C90", VA = "0x185EA8890")]
	private static Material GNKKKIHBICG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5EA9500", Offset = "0x5EA8900", VA = "0x185EA9500")]
	private void PDPBHIHBJKF(LIIAPCDJDEL HELMOINPHOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5EA87B0", Offset = "0x5EA7BB0", VA = "0x185EA87B0")]
	private void FPJBIFPCIKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5EA8960", Offset = "0x5EA7D60", VA = "0x185EA8960")]
	public void KFFMGIJIMDF(bool FCPNPAAEONC, bool IHKKKIDMANB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5EA8720", Offset = "0x5EA7B20", VA = "0x185EA8720")]
	protected void FPDGANHHHMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5EA88F0", Offset = "0x5EA7CF0", VA = "0x185EA88F0")]
	[IteratorStateMachine(typeof(AIIKHGHCINO))]
	public IEnumerable<Renderer> HLJGDKKLEGI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5EA7F80", Offset = "0x5EA7380", VA = "0x185EA7F80")]
	[IteratorStateMachine(typeof(MENPABJEOKB))]
	public IEnumerable<Renderer> BOEGNNCDKEK()
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
		[Cpp2IlInjected.Address(RVA = "0x5EB6290", Offset = "0x5EB5690", VA = "0x185EB6290")]
		public ShapeRendererConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[DefaultMember("Item")]
public class FJFPMGNAFLO : CLBOFGEACDM, IDisposable, FEFCOAJHEBB
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static readonly PILIJFIMAJF FDJKGAAPBBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly ODFOCMPMHCN<OKLEKLIDLMN, APCLIOCKJBL> JCDNANLLLKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly ODFOCMPMHCN<GEDODKLBGBN, LIIAPCDJDEL> EJKBCPIIGMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly ODFOCMPMHCN<OBNMJKICJAH, IIGFAGIMHCH> JGDCNMHKAFK;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public APCLIOCKJBL OFCFHOOOGOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x5EAC520", Offset = "0x5EAB920", VA = "0x185EAC520", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public LIIAPCDJDEL OFCFHOOOGOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x5EAC460", Offset = "0x5EAB860", VA = "0x185EAC460", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public IIGFAGIMHCH OFCFHOOOGOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x5EAC4C0", Offset = "0x5EAB8C0", VA = "0x185EAC4C0", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public bool LGMOPIKEIJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x977980", Offset = "0x976D80", VA = "0x180977980", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x977870", Offset = "0x976C70", VA = "0x180977870")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5EACED0", Offset = "0x5EAC2D0", VA = "0x185EACED0")]
	public FJFPMGNAFLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5EAC660", Offset = "0x5EABA60", VA = "0x185EAC660", Slot = "21")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5EAC6F0", Offset = "0x5EABAF0", VA = "0x185EAC6F0", Slot = "4")]
	public OKLEKLIDLMN ELHDPCJHHPL(HCNNDKBMFHP KJFNAECAHBA)
	{
		return default(OKLEKLIDLMN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5EAC6F0", Offset = "0x5EABAF0", VA = "0x185EAC6F0", Slot = "5")]
	public OKLEKLIDLMN ELHDPCJHHPL(HCNNDKBMFHP KJFNAECAHBA, bool PJMCGPGHDEA)
	{
		return default(OKLEKLIDLMN);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5EAC800", Offset = "0x5EABC00", VA = "0x185EAC800", Slot = "6")]
	public void GNFIBLMFODF(OKLEKLIDLMN COMCNEGAGFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5EAC580", Offset = "0x5EAB980", VA = "0x185EAC580", Slot = "7")]
	public void BKFOCEPJGDA(OKLEKLIDLMN COMCNEGAGFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5EACC40", Offset = "0x5EAC040", VA = "0x185EACC40", Slot = "8")]
	public GEDODKLBGBN PLAOPHKIPFP(OKLEKLIDLMN COMCNEGAGFF, PDNKFDPIEAN KJFNAECAHBA)
	{
		return default(GEDODKLBGBN);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5EAC950", Offset = "0x5EABD50", VA = "0x185EAC950", Slot = "9")]
	public GEDODKLBGBN JIDOIALBPCJ(OKLEKLIDLMN COMCNEGAGFF, ECBBFBMBEDB KJFNAECAHBA)
	{
		return default(GEDODKLBGBN);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5EAC8C0", Offset = "0x5EABCC0", VA = "0x185EAC8C0", Slot = "11")]
	public void ILKAHIDBLHE(GEDODKLBGBN HELMOINPHOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5EACB10", Offset = "0x5EABF10", VA = "0x185EACB10", Slot = "10")]
	public void LBGKNNBEBPI(GEDODKLBGBN HELMOINPHOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x5EACBD0", Offset = "0x5EABFD0", VA = "0x185EACBD0", Slot = "20")]
	public IEnumerable<Renderer> NLPMPLMFMMJ(OKLEKLIDLMN COMCNEGAGFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5EACA90", Offset = "0x5EABE90", VA = "0x185EACA90", Slot = "12")]
	public OBNMJKICJAH JPHMOIMANGJ(KPLDONNJBIM KJFNAECAHBA)
	{
		return default(OBNMJKICJAH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5EACD70", Offset = "0x5EAC170", VA = "0x185EACD70", Slot = "14")]
	public void PLMFJNGPEIJ(OBNMJKICJAH LJNLFDAMGFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x5EAC600", Offset = "0x5EABA00", VA = "0x185EAC600", Slot = "16")]
	public Task DLLEICKEFDP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5EACB70", Offset = "0x5EABF70", VA = "0x185EACB70", Slot = "17")]
	public Task LOPMDMEMBAB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5EACDE0", Offset = "0x5EAC1E0", VA = "0x185EACDE0", Slot = "18")]
	public Task PMKIEDKCMKP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x36903C0", Offset = "0x368F7C0", VA = "0x1836903C0", Slot = "19")]
	public void BELBMMDAMMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5EAC860", Offset = "0x5EABC60", VA = "0x185EAC860", Slot = "13")]
	public void IKGMPLDFBPH(OBNMJKICJAH LJNLFDAMGFF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface EPDAOBONOGJ
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JFIIPCIKOJJ(GEICHFJJNEH JLNNFEOBAMK, Renderer CDGOJIBIIEN, int MDHPKKPNFLB);

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BCFKMIECNID(Renderer CDGOJIBIIEN, LJALOLHLMDP OCIOIKDKNOC, Vector3 PHKNAAELEFN, Vector3 APLMJONIBPJ, Vector3 PIOMJMJFAEF, float KCEGFBDDAPP, float KNLBJOHODJG, float KMAHGPKNLNA = -1f, [Optional] Color? FJGGIOBFKGO, [Optional] IReadOnlyList<Camera> MPLMLBIJBMJ);

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LBBLLICCLLK(Renderer CDGOJIBIIEN, int MDHPKKPNFLB);

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int EPCGFJCBOIG();

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KHDACHMADPD(int HJHEPBBIDEI, ACHEKCMGEOE JLNNFEOBAMK, Renderer CDGOJIBIIEN, int MDHPKKPNFLB);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class DNHDKMAEEAN : MDEKHLOEFLD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private class EABCHNJLGFL : AEOAAIKPEDN<int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x5EABF50", Offset = "0x5EAB350", VA = "0x185EABF50")]
		public EABCHNJLGFL(string DKPHPKDPBCM)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly EPDAOBONOGJ BNFIKNDJDFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly FEFCOAJHEBB LKIPOKIJAAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private MeshRenderer HHCBBMGHNAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private EABCHNJLGFL NBDFNDDKANG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private bool KDLNEBFMHGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private MeshRenderer KKMFILCJMNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private EABCHNJLGFL NJNOCCHMEMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private bool ACKKLGFMPEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private MeshRenderer CPMEJNMEHCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private EABCHNJLGFL CIPCKPDOPMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private bool MMLDFGNKLLJ;

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5EABF00", Offset = "0x5EAB300", VA = "0x185EABF00")]
	public DNHDKMAEEAN(EPDAOBONOGJ OAFHBNBFBHG, FEFCOAJHEBB LKIPOKIJAAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5EAA4C0", Offset = "0x5EA98C0", VA = "0x185EAA4C0", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5EABA90", Offset = "0x5EAAE90", VA = "0x185EABA90")]
	private void LPFJGNLBDJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x5EAAED0", Offset = "0x5EAA2D0", VA = "0x185EAAED0", Slot = "4")]
	public void KENPBPJLLKE(OKLEKLIDLMN COMCNEGAGFF, ACHEKCMGEOE DILPMIKBIBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x5EAACB0", Offset = "0x5EAA0B0", VA = "0x185EAACB0", Slot = "5")]
	public void KENPBPJLLKE(GEDODKLBGBN HELMOINPHOO, ACHEKCMGEOE DILPMIKBIBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x5EAA2C0", Offset = "0x5EA96C0", VA = "0x185EAA2C0", Slot = "6")]
	public void BLKPAFDKBHF(GEDODKLBGBN HELMOINPHOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x5EAA690", Offset = "0x5EA9A90", VA = "0x185EAA690", Slot = "7")]
	public void ENKJFOHEFJM(GEDODKLBGBN HELMOINPHOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x5EABCE0", Offset = "0x5EAB0E0", VA = "0x185EABCE0", Slot = "21")]
	public void MDGPPEMMCAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x993360", Offset = "0x992760", VA = "0x180993360", Slot = "8")]
	public void HPFCDIFKIDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x5EAA150", Offset = "0x5EA9550", VA = "0x185EAA150", Slot = "9")]
	public void AJNFKCJDIOP(ACHEKCMGEOE DILPMIKBIBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x5EAA7B0", Offset = "0x5EA9BB0", VA = "0x185EAA7B0", Slot = "10")]
	public void IAEEOAOLJEH(OKLEKLIDLMN COMCNEGAGFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5EAA960", Offset = "0x5EA9D60", VA = "0x185EAA960", Slot = "11")]
	public void IAEEOAOLJEH(GEDODKLBGBN HELMOINPHOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5EA9DB0", Offset = "0x5EA91B0", VA = "0x185EA9DB0", Slot = "12")]
	public void AFHKPLFAIGC(OKLEKLIDLMN COMCNEGAGFF, GEICHFJJNEH JLNNFEOBAMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x5EA9F60", Offset = "0x5EA9360", VA = "0x185EA9F60", Slot = "13")]
	public void AFHKPLFAIGC(GEDODKLBGBN HELMOINPHOO, GEICHFJJNEH JLNNFEOBAMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x5EAA480", Offset = "0x5EA9880", VA = "0x185EAA480", Slot = "22")]
	public void DDBHJALDJMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x5EABE60", Offset = "0x5EAB260", VA = "0x185EABE60", Slot = "14")]
	public void PLALEMKDHHP(GEDODKLBGBN HELMOINPHOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x5EAA3F0", Offset = "0x5EA97F0", VA = "0x185EAA3F0", Slot = "15")]
	public void CLJFMCCKDEK(GEDODKLBGBN HELMOINPHOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0xB7BBF0", Offset = "0xB7AFF0", VA = "0x180B7BBF0", Slot = "16")]
	public void EGNKPHCMMAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x5EABD20", Offset = "0x5EAB120", VA = "0x185EABD20", Slot = "17")]
	public void MGGPLCJHKFM(GEICHFJJNEH JLNNFEOBAMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x5EAB0D0", Offset = "0x5EAA4D0", VA = "0x185EAB0D0")]
	private void KFEDDJCKFKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x5EAB720", Offset = "0x5EAAB20", VA = "0x185EAB720", Slot = "18")]
	public void KJFIPFMCDAM(OKLEKLIDLMN COMCNEGAGFF, Vector3 PHKNAAELEFN, Vector3 APLMJONIBPJ, Vector3 PIOMJMJFAEF, float KCEGFBDDAPP, float KNLBJOHODJG, IReadOnlyList<Camera> FOMEGEBHNBN, LJALOLHLMDP OCIOIKDKNOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x5EAB320", Offset = "0x5EAA720", VA = "0x185EAB320", Slot = "19")]
	public void KJFIPFMCDAM(OBNMJKICJAH LJNLFDAMGFF, Vector3 PHKNAAELEFN, Vector3 APLMJONIBPJ, Vector3 PIOMJMJFAEF, float KCEGFBDDAPP, float KNLBJOHODJG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class JFPOFHAADNO
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class CCHKLFBLDOK : IEnumerable<BJEAOGEIGKG>, IEnumerable, IEnumerator<BJEAOGEIGKG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private BJEAOGEIGKG <>2__current;

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
		private BJEAOGEIGKG System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.PrimitiveShapeMeshData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x7F3130", Offset = "0x7F2530", VA = "0x1807F3130", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x7F3130", Offset = "0x7F2530", VA = "0x1807F3130", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xB48080", Offset = "0xB47480", VA = "0x180B48080")]
		[DebuggerHidden]
		public CCHKLFBLDOK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x5EA9C00", Offset = "0x5EA9000", VA = "0x185EA9C00", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x5EA9D70", Offset = "0x5EA9170", VA = "0x185EA9D70", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x5EA9CE0", Offset = "0x5EA90E0", VA = "0x185EA9CE0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<BJEAOGEIGKG> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.PrimitiveShapeMeshData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x5EA9CE0", Offset = "0x5EA90E0", VA = "0x185EA9CE0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private static BJEAOGEIGKG[][] JCENFJLPJBP;

	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private static LMEPLEDIAME JMCHFINDMHI;

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public static ShapeRendererConfig AHALCGKHAIE;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public static ComputeShader CGNJCCLFNEL
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x5EB2BE0", Offset = "0x5EB1FE0", VA = "0x185EB2BE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public static SkinnedShapeRenderer ODFCPFOOBEG
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x5EB2B70", Offset = "0x5EB1F70", VA = "0x185EB2B70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x5EB2C60", Offset = "0x5EB2060", VA = "0x185EB2C60")]
	public static Mesh HGGOJJENAOD(LDCBIJHGALF ABHEALFMANJ, int EFOLHNEOCOK = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x5EB2C50", Offset = "0x5EB2050", VA = "0x185EB2C50")]
	public static int EOOJKJHAMOD(LDCBIJHGALF ABHEALFMANJ, int EFOLHNEOCOK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x5EB32F0", Offset = "0x5EB26F0", VA = "0x185EB32F0")]
	public static LMEPLEDIAME LAGKDBBALAI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5EB3270", Offset = "0x5EB2670", VA = "0x185EB3270")]
	[IteratorStateMachine(typeof(CCHKLFBLDOK))]
	private static IEnumerable<BJEAOGEIGKG> IPMIKDNHMJE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x5EB3670", Offset = "0x5EB2A70", VA = "0x185EB3670")]
	public static BJEAOGEIGKG MNIMCAPLMAJ(LDCBIJHGALF ABHEALFMANJ, int EFOLHNEOCOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x5EB32D0", Offset = "0x5EB26D0", VA = "0x185EB32D0")]
	public static bool JJODGEKNHNK(this LDCBIJHGALF ABHEALFMANJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x5EB2D20", Offset = "0x5EB2120", VA = "0x185EB2D20")]
	public static void HINLBJAJMJH(LDCBIJHGALF ABHEALFMANJ, float3 POMFEEHIHLC, out OHBAKDDFIEF DHCOGBJLCOC, out float3 AENPLMGLMGO, out float OJOJPLGKKIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x5EB2ED0", Offset = "0x5EB22D0", VA = "0x185EB2ED0")]
	public static void HOKNGNGPGCN(Vector3 POMFEEHIHLC, LDCBIJHGALF ABHEALFMANJ, out Vector3 AENPLMGLMGO, out float OJOJPLGKKIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x5EB3260", Offset = "0x5EB2660", VA = "0x185EB3260")]
	[MHGALPAFIHA(KJBKGMBJJKK.ExitingPlayMode, 0)]
	private static void IIJCCCMADEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x5EB3450", Offset = "0x5EB2850", VA = "0x185EB3450")]
	[MHGALPAFIHA(KJBKGMBJJKK.ExitingPlayMode, 0)]
	private static void LBMPACBNKBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public abstract class LIIAPCDJDEL : HIICJPEKIGM, LDLHGGFFDIB, ABMDDENJNJF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly APCLIOCKJBL KABGFLLOEDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	protected Bounds LOFFCJPJPGE;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public Bounds FKLGAIPKMEH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x1397B20", Offset = "0x1396F20", VA = "0x181397B20", Slot = "4")]
		get
		{
			return default(Bounds);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public virtual NJFPOCMMNBI IFKOGCFDLGD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x5EB3DF0", Offset = "0x5EB31F0", VA = "0x185EB3DF0", Slot = "16")]
		get
		{
			return default(NJFPOCMMNBI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public bool DKNHIHCPMLF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x8FD060", Offset = "0x8FC460", VA = "0x1808FD060")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x8FD5F0", Offset = "0x8FC9F0", VA = "0x1808FD5F0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	protected abstract Hash128 ODEFOHPJDCN
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int AGJEBPCOEGA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x9EA990", Offset = "0x9E9D90", VA = "0x1809EA990", Slot = "8")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public BAPCPNNNBMO MCOKPIAAHCH
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x94BE70", Offset = "0x94B270", VA = "0x18094BE70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x94BE50", Offset = "0x94B250", VA = "0x18094BE50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public bool CLIPDICBIIM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x321AFE0", Offset = "0x321A3E0", VA = "0x18321AFE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x7FF090", Offset = "0x7FE490", VA = "0x1807FF090")]
	protected LIIAPCDJDEL(APCLIOCKJBL COMCNEGAGFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x5EB3CC0", Offset = "0x5EB30C0", VA = "0x185EB3CC0", Slot = "14")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x7E8C00", Offset = "0x7E8000", VA = "0x1807E8C00", Slot = "15")]
	public virtual bool KPLKJDMPIHL(BCHJJGNIBBC COMCNEGAGFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "17")]
	public abstract int MACFJJIHDCL(KLIDPHGEHON EFOLHNEOCOK);

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "18")]
	public abstract int MMDLACCCFFC(KLIDPHGEHON EFOLHNEOCOK);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "19")]
	public abstract void BDFLOJCKANH(KLIDPHGEHON EFOLHNEOCOK, IDFGGMEHFCA IPHCOLEMOED, int FNIFACHHFIE = -1);

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "20")]
	public abstract BCHJJGNIBBC PMKLLIGFFND();

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x5EB3C90", Offset = "0x5EB3090", VA = "0x185EB3C90", Slot = "10")]
	public Hash128 DPAADCKLDPN(int EFOLHNEOCOK)
	{
		return default(Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "22")]
	public abstract OKMPIFBDOGC KJKFHCLNECO();

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "23")]
	public abstract AJJFHGLFKIL APNNGLFACLF(KLIDPHGEHON EFOLHNEOCOK, JobHandle FPNNHINBDNF);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x5EB3E80", Offset = "0x5EB3280", VA = "0x185EB3E80", Slot = "9")]
	public AJJFHGLFKIL ONINBLCIPAH(int EFOLHNEOCOK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class ILMJNDKHKJM : LIIAPCDJDEL
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	private struct LLCLMKKOGEJ : AJJFHGLFKIL, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private JOECMCGOEAB JDDLDLKOEPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private JobHandle FPNNHINBDNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private HDFIIHHMAMM IPLIMAEPAFO;

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x5EB3F30", Offset = "0x5EB3330", VA = "0x185EB3F30")]
		public LLCLMKKOGEJ(JOECMCGOEAB JDDLDLKOEPJ, JobHandle FPNNHINBDNF, HDFIIHHMAMM IPLIMAEPAFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x5EB3F00", Offset = "0x5EB3300", VA = "0x185EB3F00", Slot = "4")]
		public JOECMCGOEAB OLKGFACPIPC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x5EB3EB0", Offset = "0x5EB32B0", VA = "0x185EB3EB0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private readonly ECBBFBMBEDB PJKCCCKPKCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private float CMDGICELBAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private Hash128 LENAGOJINOA;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	protected override Hash128 ODEFOHPJDCN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x5EB2470", Offset = "0x5EB1870", VA = "0x185EB2470", Slot = "21")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x5EB2660", Offset = "0x5EB1A60", VA = "0x185EB2660")]
	public ILMJNDKHKJM(APCLIOCKJBL COMCNEGAGFF, ECBBFBMBEDB KJFNAECAHBA, bool PJMCGPGHDEA = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x7E8C00", Offset = "0x7E8000", VA = "0x1807E8C00", Slot = "15")]
	public override bool KPLKJDMPIHL(BCHJJGNIBBC COMCNEGAGFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x5EB2090", Offset = "0x5EB1490", VA = "0x185EB2090", Slot = "17")]
	public override int MACFJJIHDCL(KLIDPHGEHON EFOLHNEOCOK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x5EB2280", Offset = "0x5EB1680", VA = "0x185EB2280", Slot = "18")]
	public override int MMDLACCCFFC(KLIDPHGEHON EFOLHNEOCOK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x5EB1790", Offset = "0x5EB0B90", VA = "0x185EB1790", Slot = "19")]
	public override void BDFLOJCKANH(KLIDPHGEHON EFOLHNEOCOK, IDFGGMEHFCA IPHCOLEMOED, int FNIFACHHFIE = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x5EB2590", Offset = "0x5EB1990", VA = "0x185EB2590", Slot = "20")]
	public override BCHJJGNIBBC PMKLLIGFFND()
	{
		return default(BCHJJGNIBBC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x5EB1E70", Offset = "0x5EB1270", VA = "0x185EB1E70", Slot = "22")]
	public override OKMPIFBDOGC KJKFHCLNECO()
	{
		return default(OKMPIFBDOGC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x5EB0ED0", Offset = "0x5EB02D0", VA = "0x185EB0ED0", Slot = "23")]
	public override AJJFHGLFKIL APNNGLFACLF(KLIDPHGEHON EFOLHNEOCOK, JobHandle FPNNHINBDNF)
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
		private MaterialPropertyBlock ANPOLCNHBAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private OOAMMBJFAKN JDDLDLKOEPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private List<BCHJJGNIBBC> OMMMDDPFLCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private RenderTexture KMAHGIJKDPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private ComputeBuffer ICHGELIFNPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private ComputeShader IFFKJMJILNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private Matrix4x4[] GAAFNOAJHNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private int KBJLDKEEMCM;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public MeshRenderer JIGPJJMDIMI
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x7F3130", Offset = "0x7F2530", VA = "0x1807F3130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x7F3110", Offset = "0x7F2510", VA = "0x1807F3110")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public int AOENHPFIJFB
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x5EB6F50", Offset = "0x5EB6350", VA = "0x185EB6F50")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x5EB64F0", Offset = "0x5EB58F0", VA = "0x185EB64F0")]
		public static List<SkinnedShapeRenderer> Create(GameObject COMCNEGAGFF, List<OOAMMBJFAKN> FAMPJNHHBCJ, List<BCHJJGNIBBC> OMMMDDPFLCJ, Material JMOIMJGFABM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x5EB6900", Offset = "0x5EB5D00", VA = "0x185EB6900")]
		public void Init(OOAMMBJFAKN JDDLDLKOEPJ, List<BCHJJGNIBBC> OMMMDDPFLCJ, Material JMOIMJGFABM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x5EB6EA0", Offset = "0x5EB62A0", VA = "0x185EB6EA0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x5EB6DF0", Offset = "0x5EB61F0", VA = "0x185EB6DF0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x5EB6DB0", Offset = "0x5EB61B0", VA = "0x185EB6DB0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x5EB62C0", Offset = "0x5EB56C0", VA = "0x185EB62C0")]
		private void ABGDGBNECEF(ScriptableRenderContext JNNDIHFHMHC, Camera[] OCEJIAIHLCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x5EB6740", Offset = "0x5EB5B40", VA = "0x185EB6740")]
		private void EAAKJDCFEBI(CommandBuffer KCNOFPFHIPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x8CEA50", Offset = "0x8CDE50", VA = "0x1808CEA50")]
		public SkinnedShapeRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface ELIOGMOIBKC
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	bool HAJOFHLCBDN
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Material HBIJGFKIODM();

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Material GNKKKIHBICG();

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Material AMKCPMHMGLM();

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int IFEMHHNOBID(PCJLEJOLJBG GEMDAKCADJP);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int HCKGGMJBKLN(KFDDOGLDHLG IJBOLBJCDDJ);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DCOLPNGDIMJ(GameObject ICNDEPGFBMI);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void MCEANIOCHFL(GameObject ICNDEPGFBMI, bool OPMNKOOFJBA);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class JFDNENNDEMM
{
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private static ELIOGMOIBKC LCKHNIKLMMC;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public static bool HAJOFHLCBDN
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x5EB2770", Offset = "0x5EB1B70", VA = "0x185EB2770")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x5EB28A0", Offset = "0x5EB1CA0", VA = "0x185EB28A0")]
	public static void GMAKHGAEEAN(ELIOGMOIBKC EEFGELNKAAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x5EB2950", Offset = "0x5EB1D50", VA = "0x185EB2950")]
	public static Material HBIJGFKIODM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x5EB28F0", Offset = "0x5EB1CF0", VA = "0x185EB28F0")]
	public static Material GNKKKIHBICG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x5EB2710", Offset = "0x5EB1B10", VA = "0x185EB2710")]
	public static Material AMKCPMHMGLM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x5EB2A20", Offset = "0x5EB1E20", VA = "0x185EB2A20")]
	public static int IFEMHHNOBID(PCJLEJOLJBG GEMDAKCADJP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x5EB29B0", Offset = "0x5EB1DB0", VA = "0x185EB29B0")]
	public static int HCKGGMJBKLN(KFDDOGLDHLG IJBOLBJCDDJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x5EB27D0", Offset = "0x5EB1BD0", VA = "0x185EB27D0")]
	public static void DCOLPNGDIMJ(GameObject ICNDEPGFBMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x5EB2A90", Offset = "0x5EB1E90", VA = "0x185EB2A90")]
	public static void MCEANIOCHFL(GameObject ICNDEPGFBMI, bool OPMNKOOFJBA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[DefaultMember("Item")]
public class GCIOKBMDAEN : CLBOFGEACDM, IDisposable, FEFCOAJHEBB
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class EIECBEGNFGB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public GCIOKBMDAEN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
		public EIECBEGNFGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x5EABFA0", Offset = "0x5EAB3A0", VA = "0x185EABFA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly ODFOCMPMHCN<OKLEKLIDLMN, APCLIOCKJBL> JCDNANLLLKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly ODFOCMPMHCN<GEDODKLBGBN, LIIAPCDJDEL> EJKBCPIIGMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly ODFOCMPMHCN<OBNMJKICJAH, IIGFAGIMHCH> JGDCNMHKAFK;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public APCLIOCKJBL OFCFHOOOGOP
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x5EAD310", Offset = "0x5EAC710", VA = "0x185EAD310", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public LIIAPCDJDEL OFCFHOOOGOP
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x5EAD370", Offset = "0x5EAC770", VA = "0x185EAD370", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public IIGFAGIMHCH OFCFHOOOGOP
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x5EAD2B0", Offset = "0x5EAC6B0", VA = "0x185EAD2B0", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool LGMOPIKEIJC
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x977980", Offset = "0x976D80", VA = "0x180977980", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x977870", Offset = "0x976C70", VA = "0x180977870")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x5EAF4B0", Offset = "0x5EAE8B0", VA = "0x185EAF4B0")]
	public GCIOKBMDAEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x5EAD960", Offset = "0x5EACD60", VA = "0x185EAD960", Slot = "21")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x5EADB00", Offset = "0x5EACF00", VA = "0x185EADB00", Slot = "4")]
	public OKLEKLIDLMN ELHDPCJHHPL(HCNNDKBMFHP KJFNAECAHBA)
	{
		return default(OKLEKLIDLMN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x5EADB10", Offset = "0x5EACF10", VA = "0x185EADB10", Slot = "5")]
	public OKLEKLIDLMN ELHDPCJHHPL(HCNNDKBMFHP KJFNAECAHBA, bool PJMCGPGHDEA)
	{
		return default(OKLEKLIDLMN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x5EADDA0", Offset = "0x5EAD1A0", VA = "0x185EADDA0", Slot = "6")]
	public void GNFIBLMFODF(OKLEKLIDLMN COMCNEGAGFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x5EAD460", Offset = "0x5EAC860", VA = "0x185EAD460", Slot = "7")]
	public void BKFOCEPJGDA(OKLEKLIDLMN COMCNEGAGFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x5EAEE20", Offset = "0x5EAE220", VA = "0x185EAEE20", Slot = "8")]
	public GEDODKLBGBN PLAOPHKIPFP(OKLEKLIDLMN COMCNEGAGFF, PDNKFDPIEAN KJFNAECAHBA)
	{
		return default(GEDODKLBGBN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x5EAE460", Offset = "0x5EAD860", VA = "0x185EAE460", Slot = "9")]
	public GEDODKLBGBN JIDOIALBPCJ(OKLEKLIDLMN COMCNEGAGFF, ECBBFBMBEDB KJFNAECAHBA)
	{
		return default(GEDODKLBGBN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x5EAE070", Offset = "0x5EAD470", VA = "0x185EAE070", Slot = "11")]
	public void ILKAHIDBLHE(GEDODKLBGBN HELMOINPHOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x5EAE9E0", Offset = "0x5EADDE0", VA = "0x185EAE9E0", Slot = "10")]
	public void LBGKNNBEBPI(GEDODKLBGBN HELMOINPHOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x5EAEDB0", Offset = "0x5EAE1B0", VA = "0x185EAEDB0", Slot = "20")]
	public IEnumerable<Renderer> NLPMPLMFMMJ(OKLEKLIDLMN COMCNEGAGFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x5EAE960", Offset = "0x5EADD60", VA = "0x185EAE960", Slot = "12")]
	public OBNMJKICJAH JPHMOIMANGJ(KPLDONNJBIM KJFNAECAHBA)
	{
		return default(OBNMJKICJAH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x5EAF320", Offset = "0x5EAE720", VA = "0x185EAF320", Slot = "14")]
	public void PLMFJNGPEIJ(OBNMJKICJAH LJNLFDAMGFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x5EAD7F0", Offset = "0x5EACBF0", VA = "0x185EAD7F0", Slot = "16")]
	public Task DLLEICKEFDP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x5EAEC50", Offset = "0x5EAE050", VA = "0x185EAEC50", Slot = "17")]
	public Task LOPMDMEMBAB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x5EAF390", Offset = "0x5EAE790", VA = "0x185EAF390", Slot = "18")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(EIECBEGNFGB))]
	public Task PMKIEDKCMKP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x5EAD3D0", Offset = "0x5EAC7D0", VA = "0x185EAD3D0", Slot = "19")]
	public void BELBMMDAMMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x5EAE010", Offset = "0x5EAD410", VA = "0x185EAE010", Slot = "13")]
	public void IKGMPLDFBPH(OBNMJKICJAH LJNLFDAMGFF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class OOAMMBJFAKN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	private struct ICOAIMOPKCF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public IDFGGMEHFCA HBOMFKNIOGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public BCHJJGNIBBC AMPIICAHKBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public int HFHEIHNHJKO;
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class EAGDJHLEPHG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public OOAMMBJFAKN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public int numVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public int numIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public KLIDPHGEHON lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public List<ICOAIMOPKCF> boneMeshInfos;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
		public EAGDJHLEPHG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class KLBADGBONIM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public JOECMCGOEAB combinedMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public EAGDJHLEPHG CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
		public KLBADGBONIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x5EB3C20", Offset = "0x5EB3020", VA = "0x185EB3C20")]
		internal JobHandle MNICOLMCAIE()
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x5EB3BE0", Offset = "0x5EB2FE0", VA = "0x185EB3BE0")]
		internal void KBFMIJFPKDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x5EB3A70", Offset = "0x5EB2E70", VA = "0x185EB3A70")]
		internal void AEDLAEGMGHJ()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private int[] HDKLEGCLHEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private ECGBCFJOHGC FDDHGGODHBE;

	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private static Matrix4x4 KFDABDHDEGF;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public Mesh NJJGCGAFJDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x7E8110", Offset = "0x7E7510", VA = "0x1807E8110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x7F3140", Offset = "0x7F2540", VA = "0x1807F3140")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public int OGOLAABKALA
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x9C0750", Offset = "0x9BFB50", VA = "0x1809C0750")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0xC0C1E0", Offset = "0xC0B5E0", VA = "0x180C0C1E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x5EB4FD0", Offset = "0x5EB43D0", VA = "0x185EB4FD0")]
	public void EAAKJDCFEBI(List<BCHJJGNIBBC> PMKFCEFIKKK, Matrix4x4[] APBMHCKBKDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x5EB5620", Offset = "0x5EB4A20", VA = "0x185EB5620")]
	public static List<OOAMMBJFAKN> OBPHLOEIGIJ(List<APCLIOCKJBL> DFBPADFBGII, KLIDPHGEHON EFOLHNEOCOK, Bounds LJFLOLJGCND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x5EB5230", Offset = "0x5EB4630", VA = "0x185EB5230")]
	private JobHandle LCKGGOBKFBF(JOECMCGOEAB LGMPDFIFFEM, int BEGBLJJJCNA, int BGCHKECHCOF, KLIDPHGEHON EFOLHNEOCOK, List<ICOAIMOPKCF> LFFEJCHPMKO)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x5EB4E50", Offset = "0x5EB4250", VA = "0x185EB4E50")]
	private void DGIIJCMCNHM(List<ICOAIMOPKCF> LFFEJCHPMKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x5EB5D90", Offset = "0x5EB5190", VA = "0x185EB5D90")]
	private OOAMMBJFAKN(List<ICOAIMOPKCF> LFFEJCHPMKO, int BEGBLJJJCNA, int BGCHKECHCOF, KLIDPHGEHON EFOLHNEOCOK, Bounds LJFLOLJGCND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x5EB4F60", Offset = "0x5EB4360", VA = "0x185EB4F60", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class IIGFAGIMHCH : PFJHCGJMEBE
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class BPEJDBJDNPJ : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public IIGFAGIMHCH <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x7F3130", Offset = "0x7F2530", VA = "0x1807F3130", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x7F3130", Offset = "0x7F2530", VA = "0x1807F3130", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0xB48080", Offset = "0xB47480", VA = "0x180B48080")]
		[DebuggerHidden]
		public BPEJDBJDNPJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x5EA9B70", Offset = "0x5EA8F70", VA = "0x185EA9B70", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x5EA9870", Offset = "0x5EA8C70", VA = "0x185EA9870", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x5EA9820", Offset = "0x5EA8C20", VA = "0x185EA9820")]
		private void MIMEIPDHABP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x5EA9B30", Offset = "0x5EA8F30", VA = "0x185EA9B30", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x5EA9A90", Offset = "0x5EA8E90", VA = "0x185EA9A90", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x5EA9A90", Offset = "0x5EA8E90", VA = "0x185EA9A90", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly KPLDONNJBIM KGNOPBLDJNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly FEFCOAJHEBB LKIPOKIJAAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private ONBENFKLKIG COEOFNPAOPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private List<OOAMMBJFAKN> JCMPMFLBNFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private List<OOAMMBJFAKN> LOPPJGLKOGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private GameObject OFKPBKNMEOI;

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x5EB0C60", Offset = "0x5EB0060", VA = "0x185EB0C60")]
	public static IIGFAGIMHCH PJEODNPAEDP(KPLDONNJBIM KJFNAECAHBA, FEFCOAJHEBB LKIPOKIJAAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x5EB0DD0", Offset = "0x5EB01D0", VA = "0x185EB0DD0")]
	private IIGFAGIMHCH(KPLDONNJBIM KJFNAECAHBA, FEFCOAJHEBB LKIPOKIJAAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x5EB07A0", Offset = "0x5EAFBA0", VA = "0x185EB07A0")]
	public void NEAHAFKMCLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x5EAFBB0", Offset = "0x5EAEFB0", VA = "0x185EAFBB0")]
	[IteratorStateMachine(typeof(BPEJDBJDNPJ))]
	public IEnumerable<Renderer> HLJGDKKLEGI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x5EAFCC0", Offset = "0x5EAF0C0", VA = "0x185EAFCC0", Slot = "4")]
	public void MHOGELOLFGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x5EAFC20", Offset = "0x5EAF020", VA = "0x185EAFC20")]
	private void KHGMGLMLOJC(Vector3 GKGMFICPCKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x5EAF970", Offset = "0x5EAED70", VA = "0x185EAF970")]
	public void COCGDBGCNKP()
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
