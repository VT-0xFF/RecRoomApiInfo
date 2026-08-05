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
public interface MICNAHOIGGO
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	OJPJMMKBPGM ONEIGHFFEDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	NGHLHCMPELE ONEIGHFFEDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	HHIAHHMFLKP ONEIGHFFEDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class CIDBLIBJMKA : CDNHOFHAJBO, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private byte ONKMFANFMHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly List<SkinnedShapeRenderer>[] MDMEFNHPPHH;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int HJJPGMHNMIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA0C050", Offset = "0xA0B450", VA = "0x180A0C050", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xA1F6B0", Offset = "0xA1EAB0", VA = "0x180A1F6B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int DOGJBPPAOIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1062550", Offset = "0x1061950", VA = "0x181062550", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1578940", Offset = "0x1577D40", VA = "0x181578940")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public float NBPDOHLDKCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xB7E890", Offset = "0xB7DC90", VA = "0x180B7E890", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xB7E560", Offset = "0xB7D960", VA = "0x180B7E560")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public float CIFNIKDKJKH
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xDC1120", Offset = "0xDC0520", VA = "0x180DC1120", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xDC11B0", Offset = "0xDC05B0", VA = "0x180DC11B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public List<SkinnedShapeRenderer> MLCMEBCLFKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x60B27C0", Offset = "0x60B1BC0", VA = "0x1860B27C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public List<SkinnedShapeRenderer> FACFGAPHLNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x60B2820", Offset = "0x60B1C20", VA = "0x1860B2820")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public GameObject LECOLGFBNJB
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x823B60", Offset = "0x822F60", VA = "0x180823B60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8BA4C0", Offset = "0x8B98C0", VA = "0x1808BA4C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public byte MMPLDCBDOKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x60B24F0", Offset = "0x60B18F0", VA = "0x1860B24F0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x60B2A50", Offset = "0x60B1E50", VA = "0x1860B2A50")]
	public CIDBLIBJMKA(List<PLJJKNALDHC> EJJKHLHJFNA, List<PLJJKNALDHC> KDGJPLHANEF, List<JANGGNCGNFH> GBNCCHKANIH, Material NKAMKIHOODJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x60B26B0", Offset = "0x60B1AB0", VA = "0x1860B26B0")]
	private int EDIOAMLCFLA(List<PLJJKNALDHC> CIANENKIHIP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x60B2860", Offset = "0x60B1C60", VA = "0x1860B2860")]
	private void JIGIMNJNIAN(int OBHPCAGBPHB, bool BHEFCHPMIBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x60B29B0", Offset = "0x60B1DB0", VA = "0x1860B29B0")]
	public void NCBNLCAANBH(Vector3 DPGDBHOHLBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x60B2540", Offset = "0x60B1940", VA = "0x1860B2540", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x60B2670", Offset = "0x60B1A70", VA = "0x1860B2670")]
	public void EBOHBJHLMEB(Transform AHCJPELLMLH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
internal class NINFJDNJLEH : NGHLHCMPELE
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	private struct NFBJKJOEMEF : PHDEKLKFGKD, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private INHGOODGDOJ CAFJEBPKAHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private JobHandle PDLPHPDOMPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private JJPNHOHFCNM NICDDDKHMDJ;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x60B9490", Offset = "0x60B8890", VA = "0x1860B9490")]
		public NFBJKJOEMEF(INHGOODGDOJ CAFJEBPKAHB, JobHandle PDLPHPDOMPP, JJPNHOHFCNM NICDDDKHMDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x60B9460", Offset = "0x60B8860", VA = "0x1860B9460", Slot = "4")]
		public INHGOODGDOJ LKEHBOFLELP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x60B9410", Offset = "0x60B8810", VA = "0x1860B9410", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly KOIJLKOCPOH MLLMENDGMLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private int[] BIHGGHIKDPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private Hash128 FEINOJOKIMC;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override BJDCFCAIPAA MOGEACKNJPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x60BB690", Offset = "0x60BAA90", VA = "0x1860BB690", Slot = "16")]
		get
		{
			return default(BJDCFCAIPAA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private Vector3 CAOBDKNFOCI
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x60B9700", Offset = "0x60B8B00", VA = "0x1860B9700")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	protected override Hash128 EEOFPBCNJJG
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x60BAD50", Offset = "0x60BA150", VA = "0x1860BAD50", Slot = "21")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x60BBA60", Offset = "0x60BAE60", VA = "0x1860BBA60")]
	public NINFJDNJLEH(OJPJMMKBPGM AOCBEEBNJPK, KOIJLKOCPOH CLCAIFLMLCJ, bool CEDECMIDPJB = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x60BA8E0", Offset = "0x60B9CE0", VA = "0x1860BA8E0", Slot = "15")]
	public override bool JFCBDKMOGGO(JANGGNCGNFH AOCBEEBNJPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x60BA1D0", Offset = "0x60B95D0", VA = "0x1860BA1D0", Slot = "17")]
	public override int EDIOAMLCFLA(IGEIGLNCBEG KAKLPEGFBNK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x60BA830", Offset = "0x60B9C30", VA = "0x1860BA830", Slot = "18")]
	public override int IAMNCPIAMDH(IGEIGLNCBEG KAKLPEGFBNK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x60BA570", Offset = "0x60B9970", VA = "0x1860BA570")]
	private int HEKGECIBIHI(IGEIGLNCBEG KAKLPEGFBNK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x60B9A40", Offset = "0x60B8E40", VA = "0x1860B9A40", Slot = "19")]
	public override void CKLHJDLLMCB(IGEIGLNCBEG KAKLPEGFBNK, IEJCGBJOGBN EJKGDDPADAK, int HCJIIJFJOAC = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x60BA280", Offset = "0x60B9680", VA = "0x1860BA280", Slot = "20")]
	public override JANGGNCGNFH EFFKIBNCGJI()
	{
		return default(JANGGNCGNFH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x60BA350", Offset = "0x60B9750", VA = "0x1860BA350", Slot = "22")]
	public override OIEEHEHCBED EGHPIPDAHGA()
	{
		return default(OIEEHEHCBED);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x60BAE70", Offset = "0x60BA270", VA = "0x1860BAE70", Slot = "23")]
	public override PHDEKLKFGKD KCMOCNJHEAB(IGEIGLNCBEG KAKLPEGFBNK, JobHandle PDLPHPDOMPP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class OJPJMMKBPGM : JJLEPMELJNA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class BBDFOIIEGMO : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public OJPJMMKBPGM <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x823C00", Offset = "0x823000", VA = "0x180823C00", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x823C00", Offset = "0x823000", VA = "0x180823C00", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x9C1680", Offset = "0x9C0A80", VA = "0x1809C1680")]
		[DebuggerHidden]
		public BBDFOIIEGMO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x60B23A0", Offset = "0x60B17A0", VA = "0x1860B23A0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x60B1D40", Offset = "0x60B1140", VA = "0x1860B1D40", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x60B2270", Offset = "0x60B1670", VA = "0x1860B2270")]
		private void PPOPDODPNIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x60B1CF0", Offset = "0x60B10F0", VA = "0x1860B1CF0")]
		private void MKCFKGNFONF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x60B2220", Offset = "0x60B1620", VA = "0x1860B2220")]
		private void NEDLFKOLCEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x60B2360", Offset = "0x60B1760", VA = "0x1860B2360", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x60B22C0", Offset = "0x60B16C0", VA = "0x1860B22C0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x60B22C0", Offset = "0x60B16C0", VA = "0x1860B22C0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class OGHMNIAENAA : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public OJPJMMKBPGM <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x823C00", Offset = "0x823000", VA = "0x180823C00", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x823C00", Offset = "0x823000", VA = "0x180823C00", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x9C1680", Offset = "0x9C0A80", VA = "0x1809C1680")]
		[DebuggerHidden]
		public OGHMNIAENAA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x60BBFD0", Offset = "0x60BB3D0", VA = "0x1860BBFD0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x60BBB60", Offset = "0x60BAF60", VA = "0x1860BBB60", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x60BBEA0", Offset = "0x60BB2A0", VA = "0x1860BBEA0")]
		private void PPOPDODPNIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x60BBB10", Offset = "0x60BAF10", VA = "0x1860BBB10")]
		private void MKCFKGNFONF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x60BBF90", Offset = "0x60BB390", VA = "0x1860BBF90", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x60BBEF0", Offset = "0x60BB2F0", VA = "0x1860BBEF0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x60BBEF0", Offset = "0x60BB2F0", VA = "0x1860BBEF0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly JMPOKKHIFAB AILHKIJGOOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly List<NGHLHCMPELE> NLFNAOJEBBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private List<ClusterMeshRenderer> ELGJKJKDHLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private BatchedMeshRenderer MFHJLKHHDHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private bool HDNJKEODENN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly bool HIEGONPBMMD;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IEnumerable<DEMCNIICMBE> CMDIFPDJGKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x823C00", Offset = "0x823000", VA = "0x180823C00", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int JOLEJEPMAJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x60BE770", Offset = "0x60BDB70", VA = "0x1860BE770", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public JANGGNCGNFH BMBBIGAGPBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x60BEEE0", Offset = "0x60BE2E0", VA = "0x1860BEEE0", Slot = "8")]
		get
		{
			return default(JANGGNCGNFH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public List<SkinnedShapeRenderer> BCBMKCLCCNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x9857F0", Offset = "0x984BF0", VA = "0x1809857F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8D0170", Offset = "0x8CF570", VA = "0x1808D0170")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x60BEC60", Offset = "0x60BE060", VA = "0x1860BEC60")]
	private bool GDLGFCKNHBI(NGHLHCMPELE FJDLLHJPBKD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x60BF010", Offset = "0x60BE410", VA = "0x1860BF010")]
	private static bool KNODPCFCFFM(NGHLHCMPELE FJDLLHJPBKD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x60BFF20", Offset = "0x60BF320", VA = "0x1860BFF20")]
	public OJPJMMKBPGM(JMPOKKHIFAB CLCAIFLMLCJ, bool CENENPGGACI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x60BEAE0", Offset = "0x60BDEE0", VA = "0x1860BEAE0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x60BFCF0", Offset = "0x60BF0F0", VA = "0x1860BFCF0")]
	public void NNFBEGDMHOD(NGHLHCMPELE FJDLLHJPBKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x60BF640", Offset = "0x60BEA40", VA = "0x1860BF640")]
	public void LOBOHMPHNJE(NGHLHCMPELE FJDLLHJPBKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x60BF770", Offset = "0x60BEB70", VA = "0x1860BF770", Slot = "4")]
	public void MPJMNCEIBJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x60BEC90", Offset = "0x60BE090", VA = "0x1860BEC90")]
	public void GLINDFMMGLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x60BE8B0", Offset = "0x60BDCB0", VA = "0x1860BE8B0")]
	private void CJFJPLBIJPG(List<NGHLHCMPELE> NLFNAOJEBBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x60BF5E0", Offset = "0x60BE9E0", VA = "0x1860BF5E0")]
	private static Material LMFKAMKAEPN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x60BEA40", Offset = "0x60BDE40", VA = "0x1860BEA40")]
	private void CJFJPLBIJPG(NGHLHCMPELE FJDLLHJPBKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x60BFC10", Offset = "0x60BF010", VA = "0x1860BFC10")]
	private void NEJDDCPDDJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x60BF030", Offset = "0x60BE430", VA = "0x1860BF030")]
	public void LKPEDIEAEOA(bool JKPBNAOFIJF, bool OADAJJKLICD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x60BE820", Offset = "0x60BDC20", VA = "0x1860BE820")]
	protected void BLLMDGOECGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x60BE7B0", Offset = "0x60BDBB0", VA = "0x1860BE7B0")]
	[IteratorStateMachine(typeof(BBDFOIIEGMO))]
	public IEnumerable<Renderer> AIINKCIKOFF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x60BEFA0", Offset = "0x60BE3A0", VA = "0x1860BEFA0")]
	[IteratorStateMachine(typeof(OGHMNIAENAA))]
	public IEnumerable<Renderer> KICGICJONBM()
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
		[Cpp2IlInjected.Address(RVA = "0x60C2BC0", Offset = "0x60C1FC0", VA = "0x1860C2BC0")]
		public ShapeRendererConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[DefaultMember("Item")]
public class CMAPFELBPML : MADGLDNBLBE, IDisposable, MICNAHOIGGO
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static readonly EHKEPJIBENP IGCLICKKCHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly MPLJAOACHEK<NAFBJEJAOEH, OJPJMMKBPGM> GGDHPGMOAFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly MPLJAOACHEK<IDCFBDIAJKK, NGHLHCMPELE> NLFNAOJEBBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly MPLJAOACHEK<HDJNPHNJDGA, HHIAHHMFLKP> LFPNMEPEKNI;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public OJPJMMKBPGM ONEIGHFFEDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x60B3060", Offset = "0x60B2460", VA = "0x1860B3060", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public NGHLHCMPELE ONEIGHFFEDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x60B3000", Offset = "0x60B2400", VA = "0x1860B3000", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public HHIAHHMFLKP ONEIGHFFEDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x60B30C0", Offset = "0x60B24C0", VA = "0x1860B30C0", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public bool GKIKJNNIEHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x8C8440", Offset = "0x8C7840", VA = "0x1808C8440", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x8C84B0", Offset = "0x8C78B0", VA = "0x1808C84B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x60B3880", Offset = "0x60B2C80", VA = "0x1860B3880")]
	public CMAPFELBPML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x60B2EA0", Offset = "0x60B22A0", VA = "0x1860B2EA0", Slot = "21")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x60B3200", Offset = "0x60B2600", VA = "0x1860B3200", Slot = "4")]
	public NAFBJEJAOEH HBCJCIOHIGJ(JMPOKKHIFAB CLCAIFLMLCJ)
	{
		return default(NAFBJEJAOEH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x60B3200", Offset = "0x60B2600", VA = "0x1860B3200", Slot = "5")]
	public NAFBJEJAOEH HBCJCIOHIGJ(JMPOKKHIFAB CLCAIFLMLCJ, bool CENENPGGACI)
	{
		return default(NAFBJEJAOEH);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x60B3790", Offset = "0x60B2B90", VA = "0x1860B3790", Slot = "6")]
	public void PLDPIMKEIMC(NAFBJEJAOEH AOCBEEBNJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x60B3180", Offset = "0x60B2580", VA = "0x1860B3180", Slot = "7")]
	public void GBNKCMIGEOO(NAFBJEJAOEH AOCBEEBNJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x60B3600", Offset = "0x60B2A00", VA = "0x1860B3600", Slot = "8")]
	public IDCFBDIAJKK NBHJDDAENMN(NAFBJEJAOEH AOCBEEBNJPK, KOIJLKOCPOH CLCAIFLMLCJ)
	{
		return default(IDCFBDIAJKK);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x60B3310", Offset = "0x60B2710", VA = "0x1860B3310", Slot = "9")]
	public IDCFBDIAJKK HCDINJIBKPA(NAFBJEJAOEH AOCBEEBNJPK, NALENNKFPII CLCAIFLMLCJ)
	{
		return default(IDCFBDIAJKK);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x60B2E10", Offset = "0x60B2210", VA = "0x1860B2E10", Slot = "11")]
	public void CJJJHDDHPON(IDCFBDIAJKK FJDLLHJPBKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x60B34D0", Offset = "0x60B28D0", VA = "0x1860B34D0", Slot = "10")]
	public void HMNAFNHONMJ(IDCFBDIAJKK FJDLLHJPBKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x60B3530", Offset = "0x60B2930", VA = "0x1860B3530", Slot = "20")]
	public IEnumerable<Renderer> IKONLBFIOAC(NAFBJEJAOEH AOCBEEBNJPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x60B3450", Offset = "0x60B2850", VA = "0x1860B3450", Slot = "12")]
	public HDJNPHNJDGA HLLFCLHLGKF(EMLGFNKPOKK CLCAIFLMLCJ)
	{
		return default(HDJNPHNJDGA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x60B2F30", Offset = "0x60B2330", VA = "0x1860B2F30", Slot = "14")]
	public void ECPMPIANBIB(HDJNPHNJDGA JFCFLCJPILB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x60B3730", Offset = "0x60B2B30", VA = "0x1860B3730", Slot = "16")]
	public Task PFKEMJLGBDF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x60B3120", Offset = "0x60B2520", VA = "0x1860B3120", Slot = "17")]
	public Task GAGDJJLBILC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x60B2FA0", Offset = "0x60B23A0", VA = "0x1860B2FA0", Slot = "18")]
	public Task FAFCHLLLCBP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x2A40300", Offset = "0x2A3F700", VA = "0x182A40300", Slot = "19")]
	public void JPJEDEALLHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x60B35A0", Offset = "0x60B29A0", VA = "0x1860B35A0", Slot = "13")]
	public void JHBEPHKKJOI(HDJNPHNJDGA JFCFLCJPILB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface FFDHAPMKAHD
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HIOBPEKOPKM(FBALIINALIE GANFKPHKNKH, Renderer NECBJECEJAA, int OHBCJOOMAGG);

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BIAKKFOGPNL(Renderer NECBJECEJAA, INPKLHICICA GAMNLNNCHBK, Vector3 MPMBPPMCIGE, Vector3 OKBNNGCFHNI, Vector3 BOOIMLFPIID, float NAJPGLKBHID, float LFKNAGILCHF, float POLEBJNFNDC = -1f, [Optional] Color? DEJOCIOKOBF, [Optional] IReadOnlyList<Camera> MBMIKOBEKMP);

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CAIOOOIIPIG(Renderer NECBJECEJAA, int OHBCJOOMAGG);

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int LOOCCMPKFPI();

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KMMKKBNEPHH(int ACOCDPBCJGK, KKFFAKHFGOF GANFKPHKNKH, Renderer NECBJECEJAA, int OHBCJOOMAGG);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class FGOKNPEHBIE : IHJJJPNMOBB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private class CHICBINNMJP : ILNGGDKDLHB<int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x60B24A0", Offset = "0x60B18A0", VA = "0x1860B24A0")]
		public CHICBINNMJP(string GDKOBCHHFLB)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly FFDHAPMKAHD OMNEOEHPKAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly MICNAHOIGGO HOHEMPIIMBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private MeshRenderer FBOHPJFMKAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private CHICBINNMJP EDCCIGNICLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private bool EIPJIFJJNKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private MeshRenderer HHBFEIAHIFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private CHICBINNMJP DPIPHFGCAFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private bool HONHGMNFFFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private MeshRenderer BPNPLMCKDJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private CHICBINNMJP CFJNNFCPKNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private bool JOEDCLMPFFI;

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x60B5F60", Offset = "0x60B5360", VA = "0x1860B5F60")]
	public FGOKNPEHBIE(FFDHAPMKAHD BNBFBKGLLNF, MICNAHOIGGO HOHEMPIIMBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x60B3EF0", Offset = "0x60B32F0", VA = "0x1860B3EF0", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x60B44E0", Offset = "0x60B38E0", VA = "0x1860B44E0")]
	private void EFFGKHELGDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x60B42E0", Offset = "0x60B36E0", VA = "0x1860B42E0", Slot = "4")]
	public void EBLIKOEBNON(NAFBJEJAOEH AOCBEEBNJPK, KKFFAKHFGOF EFDJMBALOBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x60B40C0", Offset = "0x60B34C0", VA = "0x1860B40C0", Slot = "5")]
	public void EBLIKOEBNON(IDCFBDIAJKK FJDLLHJPBKD, KKFFAKHFGOF EFDJMBALOBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x60B5AA0", Offset = "0x60B4EA0", VA = "0x1860B5AA0", Slot = "6")]
	public void OBJEFBKMGDH(IDCFBDIAJKK FJDLLHJPBKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x60B55E0", Offset = "0x60B49E0", VA = "0x1860B55E0", Slot = "7")]
	public void IDBFLODFBOA(IDCFBDIAJKK FJDLLHJPBKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x60B4F30", Offset = "0x60B4330", VA = "0x1860B4F30", Slot = "21")]
	public void GJFEEBDABHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x134FF40", Offset = "0x134F340", VA = "0x18134FF40", Slot = "8")]
	public void PDBAEMPOEKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x60B4F70", Offset = "0x60B4370", VA = "0x1860B4F70", Slot = "9")]
	public void HCGFNDFMGJP(KKFFAKHFGOF EFDJMBALOBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x60B5430", Offset = "0x60B4830", VA = "0x1860B5430", Slot = "10")]
	public void HPINAEFHDGP(NAFBJEJAOEH AOCBEEBNJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x60B50E0", Offset = "0x60B44E0", VA = "0x1860B50E0", Slot = "11")]
	public void HPINAEFHDGP(IDCFBDIAJKK FJDLLHJPBKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x60B58F0", Offset = "0x60B4CF0", VA = "0x1860B58F0", Slot = "12")]
	public void NMCHEBADBFL(NAFBJEJAOEH AOCBEEBNJPK, FBALIINALIE GANFKPHKNKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x60B5700", Offset = "0x60B4B00", VA = "0x1860B5700", Slot = "13")]
	public void NMCHEBADBFL(IDCFBDIAJKK FJDLLHJPBKD, FBALIINALIE GANFKPHKNKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x60B3E10", Offset = "0x60B3210", VA = "0x1860B3E10", Slot = "22")]
	public void BCKCBLABNDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x60B3E50", Offset = "0x60B3250", VA = "0x1860B3E50", Slot = "14")]
	public void CGDFLBIPFMB(IDCFBDIAJKK FJDLLHJPBKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x60B4EA0", Offset = "0x60B42A0", VA = "0x1860B4EA0", Slot = "15")]
	public void FIAMNMJLMGG(IDCFBDIAJKK FJDLLHJPBKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0xBF33E0", Offset = "0xBF27E0", VA = "0x180BF33E0", Slot = "16")]
	public void NHAAIAECMFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x60B5E20", Offset = "0x60B5220", VA = "0x1860B5E20", Slot = "17")]
	public void PAKBGKGHMKA(FBALIINALIE GANFKPHKNKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x60B5BD0", Offset = "0x60B4FD0", VA = "0x1860B5BD0")]
	private void PACJFKIJPAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x60B4730", Offset = "0x60B3B30", VA = "0x1860B4730", Slot = "18")]
	public void EKDONPNPMMB(NAFBJEJAOEH AOCBEEBNJPK, Vector3 MPMBPPMCIGE, Vector3 OKBNNGCFHNI, Vector3 BOOIMLFPIID, float NAJPGLKBHID, float LFKNAGILCHF, IReadOnlyList<Camera> HIFANLCNCIE, INPKLHICICA GAMNLNNCHBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x60B4AA0", Offset = "0x60B3EA0", VA = "0x1860B4AA0", Slot = "19")]
	public void EKDONPNPMMB(HDJNPHNJDGA JFCFLCJPILB, Vector3 MPMBPPMCIGE, Vector3 OKBNNGCFHNI, Vector3 BOOIMLFPIID, float NAJPGLKBHID, float LFKNAGILCHF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class JHAKDCINEON
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class EAOJPKGGHAH : IEnumerable<BLGMFFFFKMD>, IEnumerable, IEnumerator<BLGMFFFFKMD>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private BLGMFFFFKMD <>2__current;

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
		private BLGMFFFFKMD System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.PrimitiveShapeMeshData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x823C00", Offset = "0x823000", VA = "0x180823C00", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x823C00", Offset = "0x823000", VA = "0x180823C00", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x9C1680", Offset = "0x9C0A80", VA = "0x1809C1680")]
		[DebuggerHidden]
		public EAOJPKGGHAH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x60B3C60", Offset = "0x60B3060", VA = "0x1860B3C60", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x60B3DD0", Offset = "0x60B31D0", VA = "0x1860B3DD0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x60B3D40", Offset = "0x60B3140", VA = "0x1860B3D40", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<BLGMFFFFKMD> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.PrimitiveShapeMeshData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x60B3D40", Offset = "0x60B3140", VA = "0x1860B3D40", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private static BLGMFFFFKMD[][] FDFGPAJMOCG;

	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private static HINCKEHNMGE OBPHMFKEIKA;

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public static ShapeRendererConfig CBHHHDBKOHK;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public static ComputeShader KPINDKCLGFC
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x60B7D80", Offset = "0x60B7180", VA = "0x1860B7D80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public static SkinnedShapeRenderer EOIAMDIAFCM
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x60B78F0", Offset = "0x60B6CF0", VA = "0x1860B78F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x60B7DF0", Offset = "0x60B71F0", VA = "0x1860B7DF0")]
	public static Mesh MEENMLJDILP(BCJDKCCJIIB KOLCCLAMJPD, int KAKLPEGFBNK = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x60B7D70", Offset = "0x60B7170", VA = "0x1860B7D70")]
	public static int LOMFFKLGGKJ(BCJDKCCJIIB KOLCCLAMJPD, int KAKLPEGFBNK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x60B79F0", Offset = "0x60B6DF0", VA = "0x1860B79F0")]
	public static HINCKEHNMGE FPFIBMDGOEP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x60B7990", Offset = "0x60B6D90", VA = "0x1860B7990")]
	[IteratorStateMachine(typeof(EAOJPKGGHAH))]
	private static IEnumerable<BLGMFFFFKMD> FMKOHBAIPNG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x60B7EB0", Offset = "0x60B72B0", VA = "0x1860B7EB0")]
	public static BLGMFFFFKMD NBJPBMCEKPC(BCJDKCCJIIB KOLCCLAMJPD, int KAKLPEGFBNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x60B7960", Offset = "0x60B6D60", VA = "0x1860B7960")]
	public static bool DOLOCFPENIO(this BCJDKCCJIIB KOLCCLAMJPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x60B8210", Offset = "0x60B7610", VA = "0x1860B8210")]
	public static void NFBLECIDPGO(BCJDKCCJIIB KOLCCLAMJPD, float3 JMAEKAAIEMJ, out KFNIPGLOKPK MNIPCHJCPNN, out float3 JOKIHBJHBAF, out float OLCAKKIBAKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x60B83C0", Offset = "0x60B77C0", VA = "0x1860B83C0")]
	public static void NGCAMJMKFCI(Vector3 JMAEKAAIEMJ, BCJDKCCJIIB KOLCCLAMJPD, out Vector3 JOKIHBJHBAF, out float OLCAKKIBAKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x60B7980", Offset = "0x60B6D80", VA = "0x1860B7980")]
	[JBOBMCDMAPA(LNELBDJPNNB.ExitingPlayMode, 0)]
	private static void FHHAANDCHJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x60B7B50", Offset = "0x60B6F50", VA = "0x1860B7B50")]
	[JBOBMCDMAPA(LNELBDJPNNB.ExitingPlayMode, 0)]
	private static void ILFABNIGPIP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public abstract class NGHLHCMPELE : IMDDGIGNJNJ, DEMCNIICMBE, PPFAEBHKHBB, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly OJPJMMKBPGM LECOLGFBNJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	protected Bounds HOAAOECDHOM;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public Bounds OMBFOIPLBOL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x1122D70", Offset = "0x1122170", VA = "0x181122D70", Slot = "4")]
		get
		{
			return default(Bounds);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public virtual BJDCFCAIPAA MOGEACKNJPM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x60B9670", Offset = "0x60B8A70", VA = "0x1860B9670", Slot = "16")]
		get
		{
			return default(BJDCFCAIPAA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public bool HIEGONPBMMD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x11AA2E0", Offset = "0x11A96E0", VA = "0x1811AA2E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x11B7640", Offset = "0x11B6A40", VA = "0x1811B7640")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	protected abstract Hash128 EEOFPBCNJJG
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int DMDCLIODPJK
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x822D80", Offset = "0x822180", VA = "0x180822D80", Slot = "8")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public FLMHMPIHAFK FEJHHHKHBHH
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x9857F0", Offset = "0x984BF0", VA = "0x1809857F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x8D0170", Offset = "0x8CF570", VA = "0x1808D0170")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public bool GDFOLHNAAOA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x28E0FD0", Offset = "0x28E03D0", VA = "0x1828E0FD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x8C4170", Offset = "0x8C3570", VA = "0x1808C4170")]
	protected NGHLHCMPELE(OJPJMMKBPGM AOCBEEBNJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x60B9510", Offset = "0x60B8910", VA = "0x1860B9510", Slot = "14")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x8228B0", Offset = "0x821CB0", VA = "0x1808228B0", Slot = "15")]
	public virtual bool JFCBDKMOGGO(JANGGNCGNFH AOCBEEBNJPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "17")]
	public abstract int EDIOAMLCFLA(IGEIGLNCBEG KAKLPEGFBNK);

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "18")]
	public abstract int IAMNCPIAMDH(IGEIGLNCBEG KAKLPEGFBNK);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "19")]
	public abstract void CKLHJDLLMCB(IGEIGLNCBEG KAKLPEGFBNK, IEJCGBJOGBN EJKGDDPADAK, int HCJIIJFJOAC = -1);

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "20")]
	public abstract JANGGNCGNFH EFFKIBNCGJI();

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x60B9640", Offset = "0x60B8A40", VA = "0x1860B9640", Slot = "10")]
	public Hash128 GGOPPHJNCAH(int KAKLPEGFBNK)
	{
		return default(Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "22")]
	public abstract OIEEHEHCBED EGHPIPDAHGA();

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "23")]
	public abstract PHDEKLKFGKD KCMOCNJHEAB(IGEIGLNCBEG KAKLPEGFBNK, JobHandle PDLPHPDOMPP);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x60B94E0", Offset = "0x60B88E0", VA = "0x1860B94E0", Slot = "9")]
	public PHDEKLKFGKD BIMEMDKNFJL(int KAKLPEGFBNK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class PLHLEODGEBP : NGHLHCMPELE
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	private struct JIFAIIMLCED : PHDEKLKFGKD, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private INHGOODGDOJ CAFJEBPKAHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private JobHandle PDLPHPDOMPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private IABPKIMCPLJ NICDDDKHMDJ;

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x60B8870", Offset = "0x60B7C70", VA = "0x1860B8870")]
		public JIFAIIMLCED(INHGOODGDOJ CAFJEBPKAHB, JobHandle PDLPHPDOMPP, IABPKIMCPLJ NICDDDKHMDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x60B8840", Offset = "0x60B7C40", VA = "0x1860B8840", Slot = "4")]
		public INHGOODGDOJ LKEHBOFLELP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x60B87F0", Offset = "0x60B7BF0", VA = "0x1860B87F0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private readonly NALENNKFPII BDKAELKFGJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private float JOOIGGCAENH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private Hash128 FEINOJOKIMC;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	protected override Hash128 EEOFPBCNJJG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x60C0DC0", Offset = "0x60C01C0", VA = "0x1860C0DC0", Slot = "21")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x60C17A0", Offset = "0x60C0BA0", VA = "0x1860C17A0")]
	public PLHLEODGEBP(OJPJMMKBPGM AOCBEEBNJPK, NALENNKFPII CLCAIFLMLCJ, bool CENENPGGACI = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x8228B0", Offset = "0x821CB0", VA = "0x1808228B0", Slot = "15")]
	public override bool JFCBDKMOGGO(JANGGNCGNFH AOCBEEBNJPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x60C06F0", Offset = "0x60BFAF0", VA = "0x1860C06F0", Slot = "17")]
	public override int EDIOAMLCFLA(IGEIGLNCBEG KAKLPEGFBNK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x60C0BD0", Offset = "0x60BFFD0", VA = "0x1860C0BD0", Slot = "18")]
	public override int IAMNCPIAMDH(IGEIGLNCBEG KAKLPEGFBNK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x60C0010", Offset = "0x60BF410", VA = "0x1860C0010", Slot = "19")]
	public override void CKLHJDLLMCB(IGEIGLNCBEG KAKLPEGFBNK, IEJCGBJOGBN EJKGDDPADAK, int HCJIIJFJOAC = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x60C08E0", Offset = "0x60BFCE0", VA = "0x1860C08E0", Slot = "20")]
	public override JANGGNCGNFH EFFKIBNCGJI()
	{
		return default(JANGGNCGNFH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x60C09B0", Offset = "0x60BFDB0", VA = "0x1860C09B0", Slot = "22")]
	public override OIEEHEHCBED EGHPIPDAHGA()
	{
		return default(OIEEHEHCBED);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x60C0EE0", Offset = "0x60C02E0", VA = "0x1860C0EE0", Slot = "23")]
	public override PHDEKLKFGKD KCMOCNJHEAB(IGEIGLNCBEG KAKLPEGFBNK, JobHandle PDLPHPDOMPP)
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
		private MaterialPropertyBlock HDDKOAGKNJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private PLJJKNALDHC CAFJEBPKAHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private List<JANGGNCGNFH> GBNCCHKANIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private RenderTexture EEMGNENJFJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private ComputeBuffer DPKHCHBDFOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private ComputeShader LFCIJNDMHDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private Matrix4x4[] CGABFIBFLFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private int PMCIOHLEFJO;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public MeshRenderer JKCCCHODFCF
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x823C00", Offset = "0x823000", VA = "0x180823C00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x8C5080", Offset = "0x8C4480", VA = "0x1808C5080")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public int AOKCGJHEJAL
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x60C3880", Offset = "0x60C2C80", VA = "0x1860C3880")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x60C2E20", Offset = "0x60C2220", VA = "0x1860C2E20")]
		public static List<SkinnedShapeRenderer> Create(GameObject AOCBEEBNJPK, List<PLJJKNALDHC> CIANENKIHIP, List<JANGGNCGNFH> GBNCCHKANIH, Material NKAMKIHOODJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x60C3070", Offset = "0x60C2470", VA = "0x1860C3070")]
		public void Init(PLJJKNALDHC CAFJEBPKAHB, List<JANGGNCGNFH> GBNCCHKANIH, Material NKAMKIHOODJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x60C37D0", Offset = "0x60C2BD0", VA = "0x1860C37D0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x60C3720", Offset = "0x60C2B20", VA = "0x1860C3720")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x60C36E0", Offset = "0x60C2AE0", VA = "0x1860C36E0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x60C2BF0", Offset = "0x60C1FF0", VA = "0x1860C2BF0")]
		private void CBMOCICIEAD(ScriptableRenderContext AKPCLGIGABA, Camera[] NJKJLLEJICB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x60C3520", Offset = "0x60C2920", VA = "0x1860C3520")]
		private void KKLJILIMDMD(CommandBuffer ODIPEDMFHNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x976820", Offset = "0x975C20", VA = "0x180976820")]
		public SkinnedShapeRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface IMLCOCIKFPC
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	bool CJKNHJJKGCH
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Material PHKLNDFMMNG();

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Material LMFKAMKAEPN();

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Material OAJOFKIFCCG();

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int CNHFABKCFCK(PFDECMCNJAL NFGBCJAEKAM);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int NGJFDHNELIP(OMFCOLBDGKP BBAKFNHHDBO);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LMGMPDLJDDP(GameObject HFAGBIOODHL);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void KIBCOJMMKCG(GameObject HFAGBIOODHL, bool OBDMBDBJCNC);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class MHLIKPHDADJ
{
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private static IMLCOCIKFPC JGNMLMMCBGP;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public static bool CJKNHJJKGCH
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x60B9070", Offset = "0x60B8470", VA = "0x1860B9070")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x60B8FB0", Offset = "0x60B83B0", VA = "0x1860B8FB0")]
	public static void BGCFEBAFHNB(IMLCOCIKFPC MIAPEDAHCKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x60B93B0", Offset = "0x60B87B0", VA = "0x1860B93B0")]
	public static Material PHKLNDFMMNG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x60B91B0", Offset = "0x60B85B0", VA = "0x1860B91B0")]
	public static Material LMFKAMKAEPN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x60B9350", Offset = "0x60B8750", VA = "0x1860B9350")]
	public static Material OAJOFKIFCCG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x60B9000", Offset = "0x60B8400", VA = "0x1860B9000")]
	public static int CNHFABKCFCK(PFDECMCNJAL NFGBCJAEKAM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x60B92E0", Offset = "0x60B86E0", VA = "0x1860B92E0")]
	public static int NGJFDHNELIP(OMFCOLBDGKP BBAKFNHHDBO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x60B9210", Offset = "0x60B8610", VA = "0x1860B9210")]
	public static void LMGMPDLJDDP(GameObject HFAGBIOODHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x60B90D0", Offset = "0x60B84D0", VA = "0x1860B90D0")]
	public static void KIBCOJMMKCG(GameObject HFAGBIOODHL, bool OBDMBDBJCNC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[DefaultMember("Item")]
public class OICOBABNDBO : MADGLDNBLBE, IDisposable, MICNAHOIGGO
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class LEAFMEMDPEN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public OICOBABNDBO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public LEAFMEMDPEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x60B8AF0", Offset = "0x60B7EF0", VA = "0x1860B8AF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly MPLJAOACHEK<NAFBJEJAOEH, OJPJMMKBPGM> GGDHPGMOAFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly MPLJAOACHEK<IDCFBDIAJKK, NGHLHCMPELE> NLFNAOJEBBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly MPLJAOACHEK<HDJNPHNJDGA, HHIAHHMFLKP> LFPNMEPEKNI;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public OJPJMMKBPGM ONEIGHFFEDC
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x60BC7D0", Offset = "0x60BBBD0", VA = "0x1860BC7D0", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public NGHLHCMPELE ONEIGHFFEDC
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x60BC890", Offset = "0x60BBC90", VA = "0x1860BC890", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public HHIAHHMFLKP ONEIGHFFEDC
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x60BC830", Offset = "0x60BBC30", VA = "0x1860BC830", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool GKIKJNNIEHD
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x8C8440", Offset = "0x8C7840", VA = "0x1808C8440", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x8C84B0", Offset = "0x8C78B0", VA = "0x1808C84B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x60BE2B0", Offset = "0x60BD6B0", VA = "0x1860BE2B0")]
	public OICOBABNDBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x60BC4A0", Offset = "0x60BB8A0", VA = "0x1860BC4A0", Slot = "21")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x60BD070", Offset = "0x60BC470", VA = "0x1860BD070", Slot = "4")]
	public NAFBJEJAOEH HBCJCIOHIGJ(JMPOKKHIFAB CLCAIFLMLCJ)
	{
		return default(NAFBJEJAOEH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x60BCDE0", Offset = "0x60BC1E0", VA = "0x1860BCDE0", Slot = "5")]
	public NAFBJEJAOEH HBCJCIOHIGJ(JMPOKKHIFAB CLCAIFLMLCJ, bool CENENPGGACI)
	{
		return default(NAFBJEJAOEH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x60BE040", Offset = "0x60BD440", VA = "0x1860BE040", Slot = "6")]
	public void PLDPIMKEIMC(NAFBJEJAOEH AOCBEEBNJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x60BCA50", Offset = "0x60BBE50", VA = "0x1860BCA50", Slot = "7")]
	public void GBNKCMIGEOO(NAFBJEJAOEH AOCBEEBNJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x60BD9D0", Offset = "0x60BCDD0", VA = "0x1860BD9D0", Slot = "8")]
	public IDCFBDIAJKK NBHJDDAENMN(NAFBJEJAOEH AOCBEEBNJPK, KOIJLKOCPOH CLCAIFLMLCJ)
	{
		return default(IDCFBDIAJKK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x60BD080", Offset = "0x60BC480", VA = "0x1860BD080", Slot = "9")]
	public IDCFBDIAJKK HCDINJIBKPA(NAFBJEJAOEH AOCBEEBNJPK, NALENNKFPII CLCAIFLMLCJ)
	{
		return default(IDCFBDIAJKK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x60BC0B0", Offset = "0x60BB4B0", VA = "0x1860BC0B0", Slot = "11")]
	public void CJJJHDDHPON(IDCFBDIAJKK FJDLLHJPBKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x60BD600", Offset = "0x60BCA00", VA = "0x1860BD600", Slot = "10")]
	public void HMNAFNHONMJ(IDCFBDIAJKK FJDLLHJPBKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x60BD870", Offset = "0x60BCC70", VA = "0x1860BD870", Slot = "20")]
	public IEnumerable<Renderer> IKONLBFIOAC(NAFBJEJAOEH AOCBEEBNJPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x60BD580", Offset = "0x60BC980", VA = "0x1860BD580", Slot = "12")]
	public HDJNPHNJDGA HLLFCLHLGKF(EMLGFNKPOKK CLCAIFLMLCJ)
	{
		return default(HDJNPHNJDGA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x60BC640", Offset = "0x60BBA40", VA = "0x1860BC640", Slot = "14")]
	public void ECPMPIANBIB(HDJNPHNJDGA JFCFLCJPILB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x60BDED0", Offset = "0x60BD2D0", VA = "0x1860BDED0", Slot = "16")]
	public Task PFKEMJLGBDF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x60BC8F0", Offset = "0x60BBCF0", VA = "0x1860BC8F0", Slot = "17")]
	public Task GAGDJJLBILC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x60BC6B0", Offset = "0x60BBAB0", VA = "0x1860BC6B0", Slot = "18")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LEAFMEMDPEN))]
	public Task FAFCHLLLCBP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x60BD940", Offset = "0x60BCD40", VA = "0x1860BD940", Slot = "19")]
	public void JPJEDEALLHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x60BD8E0", Offset = "0x60BCCE0", VA = "0x1860BD8E0", Slot = "13")]
	public void JHBEPHKKJOI(HDJNPHNJDGA JFCFLCJPILB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class PLJJKNALDHC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	private struct FIPJABDGKGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public IEJCGBJOGBN CEKCHPEMGLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public JANGGNCGNFH HGBNAHDHKBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public int FAEFNCNDIIH;
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class ONKJAOIPEDC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public PLJJKNALDHC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public int numVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public int numIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public IGEIGLNCBEG lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public List<FIPJABDGKGF> boneMeshInfos;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public ONKJAOIPEDC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class KHHPOJEANLJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public INHGOODGDOJ combinedMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public ONKJAOIPEDC CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public KHHPOJEANLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x60B88D0", Offset = "0x60B7CD0", VA = "0x1860B88D0")]
		internal JobHandle GOINEOOFNLD()
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x60B8AB0", Offset = "0x60B7EB0", VA = "0x1860B8AB0")]
		internal void OBEEBMHBCEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x60B8940", Offset = "0x60B7D40", VA = "0x1860B8940")]
		internal void NPOEGFKJKPN()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private int[] MMENCHNCDMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private ILCMHKIPGLM FABCHNOKPBI;

	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private static Matrix4x4 CEAJMJGAPCD;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public Mesh KFCENIHDGPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x81F0B0", Offset = "0x81E4B0", VA = "0x18081F0B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x8BBD20", Offset = "0x8BB120", VA = "0x1808BBD20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public int ECGEBEFGDBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x978170", Offset = "0x977570", VA = "0x180978170")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x8BBD50", Offset = "0x8BB150", VA = "0x1808BBD50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x60C2010", Offset = "0x60C1410", VA = "0x1860C2010")]
	public void KKLJILIMDMD(List<JANGGNCGNFH> POPBHLJJKNG, Matrix4x4[] ADNHHMNFCAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x60C1850", Offset = "0x60C0C50", VA = "0x1860C1850")]
	public static List<PLJJKNALDHC> DEDAFMGEJMH(List<OJPJMMKBPGM> GJDHEIMIJKL, IGEIGLNCBEG KAKLPEGFBNK, Bounds CHMGFONJEKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x60C2270", Offset = "0x60C1670", VA = "0x1860C2270")]
	private JobHandle OJIIDIFMICM(INHGOODGDOJ GOODBMFKKJK, int ABNIOCBPOBC, int GEBNIOGANPP, IGEIGLNCBEG KAKLPEGFBNK, List<FIPJABDGKGF> EIHJDJGNPLL)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x60C1F00", Offset = "0x60C1300", VA = "0x1860C1F00")]
	private void JIFIFHJMKGN(List<FIPJABDGKGF> EIHJDJGNPLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x60C2790", Offset = "0x60C1B90", VA = "0x1860C2790")]
	private PLJJKNALDHC(List<FIPJABDGKGF> EIHJDJGNPLL, int ABNIOCBPOBC, int GEBNIOGANPP, IGEIGLNCBEG KAKLPEGFBNK, Bounds CHMGFONJEKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x60C1E90", Offset = "0x60C1290", VA = "0x1860C1E90", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class HHIAHHMFLKP : JJLEPMELJNA
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class GDEEGMOHACI : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public HHIAHHMFLKP <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x823C00", Offset = "0x823000", VA = "0x180823C00", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x823C00", Offset = "0x823000", VA = "0x180823C00", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x9C1680", Offset = "0x9C0A80", VA = "0x1809C1680")]
		[DebuggerHidden]
		public GDEEGMOHACI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x60B6300", Offset = "0x60B5700", VA = "0x1860B6300", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x60B5FB0", Offset = "0x60B53B0", VA = "0x1860B5FB0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x60B61D0", Offset = "0x60B55D0", VA = "0x1860B61D0")]
		private void PPOPDODPNIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x60B62C0", Offset = "0x60B56C0", VA = "0x1860B62C0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x60B6220", Offset = "0x60B5620", VA = "0x1860B6220", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x60B6220", Offset = "0x60B5620", VA = "0x1860B6220", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly EMLGFNKPOKK FDFMMAMLGPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly MICNAHOIGGO HOHEMPIIMBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private CIDBLIBJMKA GKLJGLHPJJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private List<PLJJKNALDHC> GNOPGMLGKGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private List<PLJJKNALDHC> EFMMMDAPMIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private GameObject JJBCHDJLFPG;

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x60B6640", Offset = "0x60B5A40", VA = "0x1860B6640")]
	public static HHIAHHMFLKP HNDCCAOHGDO(EMLGFNKPOKK CLCAIFLMLCJ, MICNAHOIGGO HOHEMPIIMBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x60B77F0", Offset = "0x60B6BF0", VA = "0x1860B77F0")]
	private HHIAHHMFLKP(EMLGFNKPOKK CLCAIFLMLCJ, MICNAHOIGGO HOHEMPIIMBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x60B6850", Offset = "0x60B5C50", VA = "0x1860B6850")]
	public void KAEENGGDABJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x60B6390", Offset = "0x60B5790", VA = "0x1860B6390")]
	[IteratorStateMachine(typeof(GDEEGMOHACI))]
	public IEnumerable<Renderer> AIINKCIKOFF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x60B6D10", Offset = "0x60B6110", VA = "0x1860B6D10", Slot = "4")]
	public void MPJMNCEIBJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x60B67B0", Offset = "0x60B5BB0", VA = "0x1860B67B0")]
	private void JMJENKBOEDL(Vector3 DPGDBHOHLBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x60B6400", Offset = "0x60B5800", VA = "0x1860B6400")]
	public void GLINDFMMGLK()
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
