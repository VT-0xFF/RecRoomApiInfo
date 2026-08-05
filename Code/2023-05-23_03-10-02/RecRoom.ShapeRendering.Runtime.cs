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
public interface HKGJBMGBOJG
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	JOHKBONEMBB KPEHPIIHMEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	AAPFBMGJLLD KPEHPIIHMEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	HFGJEPMCPBH KPEHPIIHMEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class BEOMFALAAMB : LCBFIFLMKEC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private const byte DBNKHNIODFP = byte.MaxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private byte KFBMPCMGNMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly List<SkinnedShapeRenderer>[] GCFIEPJFDDI;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int CMBIFHJFNAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x80EC90", Offset = "0x80E090", VA = "0x18080EC90", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x80EE40", Offset = "0x80E240", VA = "0x18080EE40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int NDGKNDMMPEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x913DB0", Offset = "0x9131B0", VA = "0x180913DB0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xB36340", Offset = "0xB35740", VA = "0x180B36340")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public float PBLDPAFEFAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xAA20B0", Offset = "0xAA14B0", VA = "0x180AA20B0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xAA25B0", Offset = "0xAA19B0", VA = "0x180AA25B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public float MLFEHMIEOPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA8EDB0", Offset = "0xA8E1B0", VA = "0x180A8EDB0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xA8EDE0", Offset = "0xA8E1E0", VA = "0x180A8EDE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public List<SkinnedShapeRenderer> JDKJJLOEMBA
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x61382F0", Offset = "0x61376F0", VA = "0x1861382F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public List<SkinnedShapeRenderer> PHBDGHHKNJO
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x14CA8F0", Offset = "0x14C9CF0", VA = "0x1814CA8F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public GameObject GILDPEKDHCO
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7F1280", Offset = "0x7F0680", VA = "0x1807F1280")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x89EC00", Offset = "0x89E000", VA = "0x18089EC00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public byte EMIKLANHLAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x61384A0", Offset = "0x61378A0", VA = "0x1861384A0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6138640", Offset = "0x6137A40", VA = "0x186138640")]
	public BEOMFALAAMB(List<GGNFMKLFEFA> DBJOGLCHNAP, List<GGNFMKLFEFA> NDNABABDHJK, List<IKNPDLBNFFO> HGBJFEEPMKC, Material MCCMDDPOEBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6138350", Offset = "0x6137750", VA = "0x186138350")]
	private int IFGCLIBNOOE(List<GGNFMKLFEFA> OCMCPPKNJDE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x61384F0", Offset = "0x61378F0", VA = "0x1861384F0")]
	private void PKLNJMMIBBI(int ICGDJCMGIIA, bool BIECHBLBGNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6138250", Offset = "0x6137650", VA = "0x186138250")]
	public void FNKBCILOPDH(Vector3 HJKNKPHHHPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6138120", Offset = "0x6137520", VA = "0x186138120", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6138460", Offset = "0x6137860", VA = "0x186138460")]
	public void KJCIJOAPJKE(Transform MAGOMLHIIGK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
internal class NLOLLKGIFCA : AAPFBMGJLLD
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	private struct CMHKBGGBGDC : BNPNCHIKKCK, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private FALIJOGACGN CKHGFHPLIDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private JobHandle HFEJEKMIDBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private IOFFGGNLLPE KKHMCDAEJIK;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x613C740", Offset = "0x613BB40", VA = "0x18613C740")]
		public CMHKBGGBGDC(FALIJOGACGN CKHGFHPLIDD, JobHandle HFEJEKMIDBM, IOFFGGNLLPE KKHMCDAEJIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x41E1370", Offset = "0x41E0770", VA = "0x1841E1370")]
		public bool BDLONBHMKDC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x613C710", Offset = "0x613BB10", VA = "0x18613C710", Slot = "4")]
		public FALIJOGACGN FABBDADBDAM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x613C6C0", Offset = "0x613BAC0", VA = "0x18613C6C0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public readonly IEMFLHOJCDP AHCBKPNFDAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private int[] OCOLGKDDDDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private float OJJGFJKDOKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private Hash128 ECNAMHKGLPM;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override MAMEDLNPJNI APCJLLDDPDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6147480", Offset = "0x6146880", VA = "0x186147480", Slot = "17")]
		get
		{
			return default(MAMEDLNPJNI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private Vector3 GNANOHDFIFH
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6148A30", Offset = "0x6147E30", VA = "0x186148A30")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	protected override Hash128 HCBHCJMONME
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6148830", Offset = "0x6147C30", VA = "0x186148830", Slot = "22")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6148FB0", Offset = "0x61483B0", VA = "0x186148FB0")]
	public NLOLLKGIFCA(JOHKBONEMBB PFMMNJCIGCA, IEMFLHOJCDP KOCKBILIHNN, bool JLDFOFJCMKJ = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6147BB0", Offset = "0x6146FB0", VA = "0x186147BB0", Slot = "16")]
	public override bool IHPCLLFDIDL(IKNPDLBNFFO PFMMNJCIGCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6147B00", Offset = "0x6146F00", VA = "0x186147B00", Slot = "18")]
	public override int IFGCLIBNOOE(NJEJOLDCKKD HIBHFNPJOBC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x61473D0", Offset = "0x61467D0", VA = "0x1861473D0", Slot = "19")]
	public override int GKIJONKELFA(NJEJOLDCKKD HIBHFNPJOBC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6147850", Offset = "0x6146C50", VA = "0x186147850")]
	private int HLJOOELCIGF(NJEJOLDCKKD HIBHFNPJOBC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6146C40", Offset = "0x6146040", VA = "0x186146C40", Slot = "20")]
	public override void FCAGOIHDMAA(NJEJOLDCKKD HIBHFNPJOBC, BOKAALLHIPE GPMLGGKAOBP, int FJLFDFHGBBD = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6148960", Offset = "0x6147D60", VA = "0x186148960", Slot = "21")]
	public override IKNPDLBNFFO ONIPNJJFPDL()
	{
		return default(IKNPDLBNFFO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6148D90", Offset = "0x6148190", VA = "0x186148D90", Slot = "23")]
	public override LGMKHPADLNN PGFNJEJABGE()
	{
		return default(LGMKHPADLNN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6148010", Offset = "0x6147410", VA = "0x186148010", Slot = "24")]
	public override BNPNCHIKKCK KLIGMOAPDBI(NJEJOLDCKKD HIBHFNPJOBC, JobHandle HFEJEKMIDBM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class JOHKBONEMBB : GJGJIAJAIJK, CMFNIEFHOOG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class MPECCHPHCIF : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public JOHKBONEMBB <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x8117E0", Offset = "0x810BE0", VA = "0x1808117E0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x8117E0", Offset = "0x810BE0", VA = "0x1808117E0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xB93C20", Offset = "0xB93020", VA = "0x180B93C20")]
		[DebuggerHidden]
		public MPECCHPHCIF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x6146B40", Offset = "0x6145F40", VA = "0x186146B40", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6146590", Offset = "0x6145990", VA = "0x186146590", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x61464A0", Offset = "0x61458A0", VA = "0x1861464A0")]
		private void DJGMDMALOCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6146540", Offset = "0x6145940", VA = "0x186146540")]
		private void KPMMGNEJCBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x61464F0", Offset = "0x61458F0", VA = "0x1861464F0")]
		private void KDFEEALHODF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6146B00", Offset = "0x6145F00", VA = "0x186146B00", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6146A60", Offset = "0x6145E60", VA = "0x186146A60", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6146A60", Offset = "0x6145E60", VA = "0x186146A60", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class PIICJIPJDJA : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public JOHKBONEMBB <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x8117E0", Offset = "0x810BE0", VA = "0x1808117E0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x8117E0", Offset = "0x810BE0", VA = "0x1808117E0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xB93C20", Offset = "0xB93020", VA = "0x180B93C20")]
		[DebuggerHidden]
		public PIICJIPJDJA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x61499D0", Offset = "0x6148DD0", VA = "0x1861499D0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x61495C0", Offset = "0x61489C0", VA = "0x1861495C0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6149520", Offset = "0x6148920", VA = "0x186149520")]
		private void DJGMDMALOCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6149570", Offset = "0x6148970", VA = "0x186149570")]
		private void KPMMGNEJCBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6149990", Offset = "0x6148D90", VA = "0x186149990", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x61498F0", Offset = "0x6148CF0", VA = "0x1861498F0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x61498F0", Offset = "0x6148CF0", VA = "0x1861498F0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly BDOPCHBGINJ CMIMHIOINHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly List<AAPFBMGJLLD> PGBFCNIDLDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private List<ClusterMeshRenderer> CHKMHKCCAKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private BatchedMeshRenderer ADIJOOJCLJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private bool NMLGKHDHGIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly bool EGJBBBHIKHI;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IEnumerable<GFLHKNNDKJG> ENLBMPAAHLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8117E0", Offset = "0x810BE0", VA = "0x1808117E0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int JPPKJLOMMMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6143430", Offset = "0x6142830", VA = "0x186143430", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public IKNPDLBNFFO CGDJNECINJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6144940", Offset = "0x6143D40", VA = "0x186144940", Slot = "7")]
		get
		{
			return default(IKNPDLBNFFO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public List<SkinnedShapeRenderer> LPAKJLBGFAB
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7F83B0", Offset = "0x7F77B0", VA = "0x1807F83B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x85D510", Offset = "0x85C910", VA = "0x18085D510")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6144A10", Offset = "0x6143E10", VA = "0x186144A10")]
	private bool PHODFLABDCN(AAPFBMGJLLD KGNIKFPBPIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6144920", Offset = "0x6143D20", VA = "0x186144920")]
	private static bool MPGCIELMLAD(AAPFBMGJLLD KGNIKFPBPIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6144A40", Offset = "0x6143E40", VA = "0x186144A40")]
	public JOHKBONEMBB(BDOPCHBGINJ KOCKBILIHNN, bool KDDDLLLMFKP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6143550", Offset = "0x6142950", VA = "0x186143550", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6144710", Offset = "0x6143B10", VA = "0x186144710")]
	public void MGOOIKEIGMG(AAPFBMGJLLD KGNIKFPBPIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6143300", Offset = "0x6142700", VA = "0x186143300")]
	public void AJCNBIMBJPF(AAPFBMGJLLD KGNIKFPBPIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x61436D0", Offset = "0x6142AD0", VA = "0x1861436D0", Slot = "4")]
	public void ENPDCOANMDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6144430", Offset = "0x6143830", VA = "0x186144430")]
	public void LNCNPCEKGKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6143D40", Offset = "0x6143140", VA = "0x186143D40")]
	private void JDMMMOHHFCC(List<AAPFBMGJLLD> PGBFCNIDLDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6143B70", Offset = "0x6142F70", VA = "0x186143B70")]
	private static Material HKLANPNIHFM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6143CA0", Offset = "0x61430A0", VA = "0x186143CA0")]
	private void JDMMMOHHFCC(AAPFBMGJLLD KGNIKFPBPIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6143BD0", Offset = "0x6142FD0", VA = "0x186143BD0")]
	private void ILKNBDBNIPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6143ED0", Offset = "0x61432D0", VA = "0x186143ED0")]
	public void JMNEFMJIDLO(bool NEPDDHCEJMB, bool IIPCMJCGPKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6144680", Offset = "0x6143A80", VA = "0x186144680")]
	protected void MGJHBPFJCOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6143470", Offset = "0x6142870", VA = "0x186143470")]
	[IteratorStateMachine(typeof(MPECCHPHCIF))]
	public IEnumerable<Renderer> BIEMGEBAEHK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x61434E0", Offset = "0x61428E0", VA = "0x1861434E0")]
	[IteratorStateMachine(typeof(PIICJIPJDJA))]
	public IEnumerable<Renderer> BOONOAJECKM()
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
		[Cpp2IlInjected.Address(RVA = "0x6149AB0", Offset = "0x6148EB0", VA = "0x186149AB0")]
		public ShapeRendererConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[DefaultMember("Item")]
public class INMHKGPANCP : OIINNOCPDBE, IDisposable, HKGJBMGBOJG
{
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static readonly NDPMEMNFALO OLHOJKMAKNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly global::KEJHBNANDMG<IFEJLLDDIAM, JOHKBONEMBB> OAAHABAFHBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly global::KEJHBNANDMG<KOGDOGFJBKE, AAPFBMGJLLD> PGBFCNIDLDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly global::KEJHBNANDMG<AAAELBLCJNB, HFGJEPMCPBH> BLPFNFACJNM;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public JOHKBONEMBB KPEHPIIHMEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6142030", Offset = "0x6141430", VA = "0x186142030", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public AAPFBMGJLLD KPEHPIIHMEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6142090", Offset = "0x6141490", VA = "0x186142090", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public HFGJEPMCPBH KPEHPIIHMEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6141FD0", Offset = "0x61413D0", VA = "0x186141FD0", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public bool KIGNFFJCFKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xA5F540", Offset = "0xA5E940", VA = "0x180A5F540", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0xA287D0", Offset = "0xA27BD0", VA = "0x180A287D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6142E40", Offset = "0x6142240", VA = "0x186142E40")]
	public INMHKGPANCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6142300", Offset = "0x6141700", VA = "0x186142300", Slot = "21")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x61426A0", Offset = "0x6141AA0", VA = "0x1861426A0", Slot = "4")]
	public IFEJLLDDIAM HPHABNFMNNF(BDOPCHBGINJ KOCKBILIHNN)
	{
		return default(IFEJLLDDIAM);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x61426A0", Offset = "0x6141AA0", VA = "0x1861426A0", Slot = "5")]
	public IFEJLLDDIAM HPHABNFMNNF(BDOPCHBGINJ KOCKBILIHNN, bool KDDDLLLMFKP)
	{
		return default(IFEJLLDDIAM);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6142220", Offset = "0x6141620", VA = "0x186142220", Slot = "6")]
	public void CHOLCKMGKIH(IFEJLLDDIAM PFMMNJCIGCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6142280", Offset = "0x6141680", VA = "0x186142280", Slot = "7")]
	public void DMOFFMNEFMK(IFEJLLDDIAM PFMMNJCIGCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x61420F0", Offset = "0x61414F0", VA = "0x1861420F0", Slot = "8")]
	public KOGDOGFJBKE BNDCCBAJDFP(IFEJLLDDIAM PFMMNJCIGCA, IEMFLHOJCDP KOCKBILIHNN)
	{
		return default(KOGDOGFJBKE);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6142410", Offset = "0x6141810", VA = "0x186142410", Slot = "9")]
	public KOGDOGFJBKE EMICAGMPLKM(IFEJLLDDIAM PFMMNJCIGCA, AGKGDGMHLNC KOCKBILIHNN)
	{
		return default(KOGDOGFJBKE);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6142550", Offset = "0x6141950", VA = "0x186142550", Slot = "11")]
	public void EOCEICBBLHM(KOGDOGFJBKE KGNIKFPBPIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6142D50", Offset = "0x6142150", VA = "0x186142D50", Slot = "10")]
	public void PGPMAACMJKL(KOGDOGFJBKE KGNIKFPBPIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x61427B0", Offset = "0x6141BB0", VA = "0x1861427B0", Slot = "20")]
	public IEnumerable<Renderer> JJGADEHPCHI(IFEJLLDDIAM PFMMNJCIGCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6142390", Offset = "0x6141790", VA = "0x186142390", Slot = "12")]
	public AAAELBLCJNB EJGDPIEDAFE(OPLBKKBNPKH KOCKBILIHNN)
	{
		return default(AAAELBLCJNB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6142820", Offset = "0x6141C20", VA = "0x186142820", Slot = "14")]
	public void JPOCHANFALC(AAAELBLCJNB GBIHNMDEKKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6142890", Offset = "0x6141C90", VA = "0x186142890", Slot = "16")]
	public Task LOOHKFOJKIG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x61425E0", Offset = "0x61419E0", VA = "0x1861425E0", Slot = "17")]
	public Task HBKKPFOHPJI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6142CF0", Offset = "0x61420F0", VA = "0x186142CF0", Slot = "18")]
	public Task NPFPIPOJPND()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x340C0C0", Offset = "0x340B4C0", VA = "0x18340C0C0", Slot = "19")]
	public void BLIDOAPMKLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6142640", Offset = "0x6141A40", VA = "0x186142640", Slot = "13")]
	public void HFCNFHGOMCF(AAAELBLCJNB GBIHNMDEKKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x61428F0", Offset = "0x6141CF0", VA = "0x1861428F0", Slot = "25")]
	public NNMDBANNGOB MHFLJHJJJBO(IKNPDLBNFFO IOLANPMBGGL, IEnumerable<KOGDOGFJBKE> PGBFCNIDLDN, int OHIHDLOLIKE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface HEKLKHGCIKB
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FIMOFNPKJGC(FHGCEPLIEKH ONBHBHIHHNE, Renderer NMONBAKIHCO, int JNCJLEJNANI);

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EECNIJCHMFD(Renderer NMONBAKIHCO, KCFKIKEEIMO DNBJADANFOC, Vector3 ACLKIDLFEIP, Vector3 NBAAPCFFLOB, Vector3 ICDMECOLOEI, float KHBFKMAIJAH, float ABNBJAFJOGB, float GBPJOKCLKOO = -1f, [Optional] Color? OGGMNJPGMJE, [Optional] IReadOnlyList<Camera> GILNJNCOILM);

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ELEKIGBHINI(Renderer NMONBAKIHCO, int JNCJLEJNANI);

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int GFOPBBAFINE();

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AFBFJPMJJDH(int GJNKBHJGBIM, IFPAFNCCJJC ONBHBHIHHNE, Renderer NMONBAKIHCO, int JNCJLEJNANI);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class CINDFJKALAC : IJKGIOKEPGE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private class OGLFGEGHCDF : global::KCACNIIKAHC<int>
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6149060", Offset = "0x6148460", VA = "0x186149060")]
		public OGLFGEGHCDF(string LMAOKJPAKEM)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly HEKLKHGCIKB KCPMFENJIEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly HKGJBMGBOJG CIHKCLLEADK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private MeshRenderer CFNGEAPHGLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private OGLFGEGHCDF JEIPKBBMLLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private bool HGPLKJMGGLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private MeshRenderer KBMDMEIPEHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private OGLFGEGHCDF ENBGKCPNJDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private bool IEBBFHFIELO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private MeshRenderer MKIGPIKCIMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private OGLFGEGHCDF CEJKDDCKFCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private bool OLOGLDMJOBK;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x613C670", Offset = "0x613BA70", VA = "0x18613C670")]
	public CINDFJKALAC(HEKLKHGCIKB OAKKNJPJALK, HKGJBMGBOJG CIHKCLLEADK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x613A730", Offset = "0x6139B30", VA = "0x18613A730", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x613C420", Offset = "0x613B820", VA = "0x18613C420")]
	private void OMFJLMGAHAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x613AD30", Offset = "0x613A130", VA = "0x18613AD30", Slot = "4")]
	public void IALBNAPHPOH(IFEJLLDDIAM PFMMNJCIGCA, IFPAFNCCJJC BFKNABEILKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x613AB10", Offset = "0x6139F10", VA = "0x18613AB10", Slot = "5")]
	public void IALBNAPHPOH(KOGDOGFJBKE KGNIKFPBPIO, IFPAFNCCJJC BFKNABEILKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x613A450", Offset = "0x6139850", VA = "0x18613A450", Slot = "6")]
	public void ANGFAMFPKIA(KOGDOGFJBKE KGNIKFPBPIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x613A250", Offset = "0x6139650", VA = "0x18613A250", Slot = "7")]
	public void AIOIDAILLHN(KOGDOGFJBKE KGNIKFPBPIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x613A580", Offset = "0x6139980", VA = "0x18613A580", Slot = "21")]
	public void BEJCPLOJJCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x200BDF0", Offset = "0x200B1F0", VA = "0x18200BDF0", Slot = "8")]
	public void ABMNEFBEEPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x613A5C0", Offset = "0x61399C0", VA = "0x18613A5C0", Slot = "9")]
	public void CJDLNACENMO(IFPAFNCCJJC BFKNABEILKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x613C270", Offset = "0x613B670", VA = "0x18613C270", Slot = "10")]
	public void NEHIJFFGJHO(IFEJLLDDIAM PFMMNJCIGCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x613BF20", Offset = "0x613B320", VA = "0x18613BF20", Slot = "11")]
	public void NEHIJFFGJHO(KOGDOGFJBKE KGNIKFPBPIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x613B210", Offset = "0x613A610", VA = "0x18613B210", Slot = "12")]
	public void KGGMFBECMNO(IFEJLLDDIAM PFMMNJCIGCA, FHGCEPLIEKH ONBHBHIHHNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x613B3D0", Offset = "0x613A7D0", VA = "0x18613B3D0", Slot = "13")]
	public void KGGMFBECMNO(KOGDOGFJBKE KGNIKFPBPIO, FHGCEPLIEKH ONBHBHIHHNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x613A370", Offset = "0x6139770", VA = "0x18613A370", Slot = "22")]
	public void AJFIDNFPHJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x613A3B0", Offset = "0x61397B0", VA = "0x18613A3B0", Slot = "14")]
	public void ALCNFJJMPLP(KOGDOGFJBKE KGNIKFPBPIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x613AF30", Offset = "0x613A330", VA = "0x18613AF30", Slot = "15")]
	public void IGKJKFKMJMC(KOGDOGFJBKE KGNIKFPBPIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x171F410", Offset = "0x171E810", VA = "0x18171F410", Slot = "16")]
	public void FNPEHNDODMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x613A9D0", Offset = "0x6139DD0", VA = "0x18613A9D0", Slot = "17")]
	public void GLDHLEKDOJC(FHGCEPLIEKH ONBHBHIHHNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x613AFC0", Offset = "0x613A3C0", VA = "0x18613AFC0")]
	private void JHELHMPKIAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x613B5C0", Offset = "0x613A9C0", VA = "0x18613B5C0")]
	public void KGGMFBECMNO(KOGDOGFJBKE KGNIKFPBPIO, FHGCEPLIEKH ONBHBHIHHNE, bool BPIMIAGPEON = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x613A900", Offset = "0x6139D00", VA = "0x18613A900")]
	private void FIMOFNPKJGC(FHGCEPLIEKH ONBHBHIHHNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x613BBA0", Offset = "0x613AFA0", VA = "0x18613BBA0", Slot = "18")]
	public void LHLDBCPLKDO(IFEJLLDDIAM PFMMNJCIGCA, Vector3 ACLKIDLFEIP, Vector3 NBAAPCFFLOB, Vector3 ICDMECOLOEI, float KHBFKMAIJAH, float ABNBJAFJOGB, IReadOnlyList<Camera> JEMCCDFKHOG, KCFKIKEEIMO DNBJADANFOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x613B780", Offset = "0x613AB80", VA = "0x18613B780", Slot = "19")]
	public void LHLDBCPLKDO(AAAELBLCJNB GBIHNMDEKKE, Vector3 ACLKIDLFEIP, Vector3 NBAAPCFFLOB, Vector3 ICDMECOLOEI, float KHBFKMAIJAH, float ABNBJAFJOGB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class JOLLKOMIFPK
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class JOIIKKDPNFK : IEnumerable<EAMDEFHDGJC>, IEnumerable, IEnumerator<EAMDEFHDGJC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private EAMDEFHDGJC <>2__current;

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
		private EAMDEFHDGJC System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.PrimitiveShapeMeshData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x8117E0", Offset = "0x810BE0", VA = "0x1808117E0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x8117E0", Offset = "0x810BE0", VA = "0x1808117E0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0xB93C20", Offset = "0xB93020", VA = "0x180B93C20")]
		[DebuggerHidden]
		public JOIIKKDPNFK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x6144B30", Offset = "0x6143F30", VA = "0x186144B30", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6144CA0", Offset = "0x61440A0", VA = "0x186144CA0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6144C10", Offset = "0x6144010", VA = "0x186144C10", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<EAMDEFHDGJC> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.PrimitiveShapeMeshData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x6144C10", Offset = "0x6144010", VA = "0x186144C10", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public const int NBFKHJIFDEI = 3;

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private static EAMDEFHDGJC[][] DAJBKAIJBLG;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private static MAELKICCENM NDKKHOEEOFJ;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public static ShapeRendererConfig IPAIIOECINF;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public static ComputeShader PDCLLDOHFDH
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x61454D0", Offset = "0x61448D0", VA = "0x1861454D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public static SkinnedShapeRenderer MFOKJFDKIFG
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6145990", Offset = "0x6144D90", VA = "0x186145990")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x61458D0", Offset = "0x6144CD0", VA = "0x1861458D0")]
	public static Mesh JIPHMDGAHEN(HLPMIAKMIGG DIKDNHDPLNK, int HIBHFNPJOBC = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6145560", Offset = "0x6144960", VA = "0x186145560")]
	public static int HEPOLMGONKE(HLPMIAKMIGG DIKDNHDPLNK, int HIBHFNPJOBC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6145A10", Offset = "0x6144E10", VA = "0x186145A10")]
	public static MAELKICCENM PBNPNMNHKKI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6144CE0", Offset = "0x61440E0", VA = "0x186144CE0")]
	[IteratorStateMachine(typeof(JOIIKKDPNFK))]
	private static IEnumerable<EAMDEFHDGJC> BHPKPDKLKAO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6145570", Offset = "0x6144970", VA = "0x186145570")]
	public static EAMDEFHDGJC HPKMAKBIDMD(HLPMIAKMIGG DIKDNHDPLNK, int HIBHFNPJOBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6145540", Offset = "0x6144940", VA = "0x186145540")]
	public static bool FFLMJDIFDPL(this HLPMIAKMIGG DIKDNHDPLNK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x6145320", Offset = "0x6144720", VA = "0x186145320")]
	public static void FDHDLNHCEOD(HLPMIAKMIGG DIKDNHDPLNK, float3 NLFOPBCKEMP, out MEKJMOFNHBL CIEMNDOKAJE, out float3 NFMJKJOLIPM, out float AJGJGLNDKPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6144F60", Offset = "0x6144360", VA = "0x186144F60")]
	public static void DNDGBKGHFAE(Vector3 NLFOPBCKEMP, HLPMIAKMIGG DIKDNHDPLNK, out Vector3 NFMJKJOLIPM, out float AJGJGLNDKPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6145A00", Offset = "0x6144E00", VA = "0x186145A00")]
	[KINJKIDOEMP(CHIFGBMHODC.ExitingPlayMode, 0)]
	private static void NOCHCMBIEDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6144D40", Offset = "0x6144140", VA = "0x186144D40")]
	[KINJKIDOEMP(CHIFGBMHODC.ExitingPlayMode, 0)]
	private static void CIGLMKKFFOC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public abstract class AAPFBMGJLLD : FAHPALOMNPE, GFLHKNNDKJG, IFCJNLBIGJD, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public readonly JOHKBONEMBB GILDPEKDHCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	protected Bounds KFIEDIFBALN;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public Bounds LPGIGHJLEDA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x1A32930", Offset = "0x1A31D30", VA = "0x181A32930", Slot = "4")]
		get
		{
			return default(Bounds);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public virtual MAMEDLNPJNI APCJLLDDPDL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x6138030", Offset = "0x6137430", VA = "0x186138030", Slot = "17")]
		get
		{
			return default(MAMEDLNPJNI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public bool EGJBBBHIKHI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x854A40", Offset = "0x853E40", VA = "0x180854A40")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x877EF0", Offset = "0x8772F0", VA = "0x180877EF0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	protected abstract Hash128 HCBHCJMONME
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int ICEHCFCODBF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x7F1DA0", Offset = "0x7F11A0", VA = "0x1807F1DA0", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public LGKFJAPOBDM NBAJOMHAFCL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x7F83B0", Offset = "0x7F77B0", VA = "0x1807F83B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x85D510", Offset = "0x85C910", VA = "0x18085D510")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public bool IBFDMEDCDPA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x9C4470", Offset = "0x9C3870", VA = "0x1809C4470")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x855900", Offset = "0x854D00", VA = "0x180855900")]
	protected AAPFBMGJLLD(JOHKBONEMBB PFMMNJCIGCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6137F00", Offset = "0x6137300", VA = "0x186137F00", Slot = "15")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7F2CD0", Offset = "0x7F20D0", VA = "0x1807F2CD0", Slot = "16")]
	public virtual bool IHPCLLFDIDL(IKNPDLBNFFO PFMMNJCIGCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "18")]
	public abstract int IFGCLIBNOOE(NJEJOLDCKKD HIBHFNPJOBC);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "19")]
	public abstract int GKIJONKELFA(NJEJOLDCKKD HIBHFNPJOBC);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "20")]
	public abstract void FCAGOIHDMAA(NJEJOLDCKKD HIBHFNPJOBC, BOKAALLHIPE GPMLGGKAOBP, int FJLFDFHGBBD = -1);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "21")]
	public abstract IKNPDLBNFFO ONIPNJJFPDL();

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x61380C0", Offset = "0x61374C0", VA = "0x1861380C0", Slot = "11")]
	public Hash128 HFEBDPFOHNF(int HIBHFNPJOBC)
	{
		return default(Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "23")]
	public abstract LGMKHPADLNN PGFNJEJABGE();

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "24")]
	public abstract BNPNCHIKKCK KLIGMOAPDBI(NJEJOLDCKKD HIBHFNPJOBC, JobHandle HFEJEKMIDBM);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x61380F0", Offset = "0x61374F0", VA = "0x1861380F0", Slot = "10")]
	public BNPNCHIKKCK MHFLJHJJJBO(int HIBHFNPJOBC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class CDBGJPBBJGL : AAPFBMGJLLD
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	private struct JGFLPNBBLNA : BNPNCHIKKCK, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private FALIJOGACGN CKHGFHPLIDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private JobHandle HFEJEKMIDBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private GIMEEAGBMAP KKHMCDAEJIK;

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x61432A0", Offset = "0x61426A0", VA = "0x1861432A0")]
		public JGFLPNBBLNA(FALIJOGACGN CKHGFHPLIDD, JobHandle HFEJEKMIDBM, GIMEEAGBMAP KKHMCDAEJIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x41E1370", Offset = "0x41E0770", VA = "0x1841E1370")]
		public bool BDLONBHMKDC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x6143270", Offset = "0x6142670", VA = "0x186143270", Slot = "4")]
		public FALIJOGACGN FABBDADBDAM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x6143220", Offset = "0x6142620", VA = "0x186143220", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private readonly AGKGDGMHLNC FPCOICFPJGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private float OJJGFJKDOKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private Hash128 ECNAMHKGLPM;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	protected override Hash128 HCBHCJMONME
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x6139D80", Offset = "0x6139180", VA = "0x186139D80", Slot = "22")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x613A1A0", Offset = "0x61395A0", VA = "0x18613A1A0")]
	public CDBGJPBBJGL(JOHKBONEMBB PFMMNJCIGCA, AGKGDGMHLNC KOCKBILIHNN, bool KDDDLLLMFKP = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x7F2CD0", Offset = "0x7F20D0", VA = "0x1807F2CD0", Slot = "16")]
	public override bool IHPCLLFDIDL(IKNPDLBNFFO PFMMNJCIGCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x61392D0", Offset = "0x61386D0", VA = "0x1861392D0", Slot = "18")]
	public override int IFGCLIBNOOE(NJEJOLDCKKD HIBHFNPJOBC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x61390E0", Offset = "0x61384E0", VA = "0x1861390E0", Slot = "19")]
	public override int GKIJONKELFA(NJEJOLDCKKD HIBHFNPJOBC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x6138A00", Offset = "0x6137E00", VA = "0x186138A00", Slot = "20")]
	public override void FCAGOIHDMAA(NJEJOLDCKKD HIBHFNPJOBC, BOKAALLHIPE GPMLGGKAOBP, int FJLFDFHGBBD = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x6139EB0", Offset = "0x61392B0", VA = "0x186139EB0", Slot = "21")]
	public override IKNPDLBNFFO ONIPNJJFPDL()
	{
		return default(IKNPDLBNFFO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6139F80", Offset = "0x6139380", VA = "0x186139F80", Slot = "23")]
	public override LGMKHPADLNN PGFNJEJABGE()
	{
		return default(LGMKHPADLNN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x61394C0", Offset = "0x61388C0", VA = "0x1861394C0", Slot = "24")]
	public override BNPNCHIKKCK KLIGMOAPDBI(NJEJOLDCKKD HIBHFNPJOBC, JobHandle HFEJEKMIDBM)
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
		private MaterialPropertyBlock DHIIMECPGKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private GGNFMKLFEFA CKHGFHPLIDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private List<IKNPDLBNFFO> HGBJFEEPMKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private RenderTexture GCJMEMFABIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private ComputeBuffer GCEMDLLFMEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private ComputeShader PIONIHOMFGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private Matrix4x4[] PBNLHMGHBGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private int HPEEBCBINOL;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public MeshRenderer MPOELDHDNNN
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x8117E0", Offset = "0x810BE0", VA = "0x1808117E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x811A60", Offset = "0x810E60", VA = "0x180811A60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public int MKANCKDLMOC
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x614A770", Offset = "0x6149B70", VA = "0x18614A770")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x6149D10", Offset = "0x6149110", VA = "0x186149D10")]
		public static List<SkinnedShapeRenderer> Create(GameObject PFMMNJCIGCA, List<GGNFMKLFEFA> OCMCPPKNJDE, List<IKNPDLBNFFO> HGBJFEEPMKC, Material MCCMDDPOEBN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x6149F60", Offset = "0x6149360", VA = "0x186149F60")]
		public void Init(GGNFMKLFEFA CKHGFHPLIDD, List<IKNPDLBNFFO> HGBJFEEPMKC, Material MCCMDDPOEBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x614A6C0", Offset = "0x6149AC0", VA = "0x18614A6C0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x614A610", Offset = "0x6149A10", VA = "0x18614A610")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x614A5D0", Offset = "0x61499D0", VA = "0x18614A5D0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x6149AE0", Offset = "0x6148EE0", VA = "0x186149AE0")]
		private void AMMNLBMMOAM(ScriptableRenderContext GEKPLLKAIKG, Camera[] KEAFEMBIAAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x614A410", Offset = "0x6149810", VA = "0x18614A410")]
		private void JNMIEDKKIEH(CommandBuffer OCNDHGJCNMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x94E2B0", Offset = "0x94D6B0", VA = "0x18094E2B0")]
		public SkinnedShapeRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface KNOMOBPPCEE
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	bool HHFJEDELDFP
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Material LCGANICDPBM();

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Material HKLANPNIHFM();

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Material PGIFAFAOKJN();

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int JNNOAIINNFE(LBLKEMKOINO GOIHGNHJEJC);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int ABJMNIDPPPI(MONDBANNBDC EKCACBAHOFN);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void MCMDEOIEFOA(GameObject GHHNOPFOGCC);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void IANAMPMLBEL(GameObject GHHNOPFOGCC, bool DFOAEHHOAOO);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class OOCKAJPKMIC
{
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static KNOMOBPPCEE NBHMCHHOJCP;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public static bool HHFJEDELDFP
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x61494C0", Offset = "0x61488C0", VA = "0x1861494C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x6149120", Offset = "0x6148520", VA = "0x186149120")]
	public static void AHDNCCMPFNF(KNOMOBPPCEE DLJHOLLDAIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x6149330", Offset = "0x6148730", VA = "0x186149330")]
	public static Material LCGANICDPBM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x6149170", Offset = "0x6148570", VA = "0x186149170")]
	public static Material HKLANPNIHFM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x6149460", Offset = "0x6148860", VA = "0x186149460")]
	public static Material PGIFAFAOKJN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x61492C0", Offset = "0x61486C0", VA = "0x1861492C0")]
	public static int JNNOAIINNFE(LBLKEMKOINO GOIHGNHJEJC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x61490B0", Offset = "0x61484B0", VA = "0x1861490B0")]
	public static int ABJMNIDPPPI(MONDBANNBDC EKCACBAHOFN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x6149390", Offset = "0x6148790", VA = "0x186149390")]
	public static void MCMDEOIEFOA(GameObject GHHNOPFOGCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x61491D0", Offset = "0x61485D0", VA = "0x1861491D0")]
	public static void IANAMPMLBEL(GameObject GHHNOPFOGCC, bool DFOAEHHOAOO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[DefaultMember("Item")]
public class GEAODEGJGPC : OIINNOCPDBE, IDisposable, HKGJBMGBOJG
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class KGBKFAHLDDB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public GEAODEGJGPC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public KGBKFAHLDDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x6145FE0", Offset = "0x61453E0", VA = "0x186145FE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly global::KEJHBNANDMG<IFEJLLDDIAM, JOHKBONEMBB> OAAHABAFHBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly global::KEJHBNANDMG<KOGDOGFJBKE, AAPFBMGJLLD> PGBFCNIDLDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly global::KEJHBNANDMG<AAAELBLCJNB, HFGJEPMCPBH> BLPFNFACJNM;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public JOHKBONEMBB KPEHPIIHMEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x613C820", Offset = "0x613BC20", VA = "0x18613C820", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public AAPFBMGJLLD KPEHPIIHMEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x613C8E0", Offset = "0x613BCE0", VA = "0x18613C8E0", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public HFGJEPMCPBH KPEHPIIHMEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x613C880", Offset = "0x613BC80", VA = "0x18613C880", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool KIGNFFJCFKB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0xA5F540", Offset = "0xA5E940", VA = "0x180A5F540", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0xA287D0", Offset = "0xA27BD0", VA = "0x180A287D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x613F000", Offset = "0x613E400", VA = "0x18613F000")]
	public GEAODEGJGPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x613D450", Offset = "0x613C850", VA = "0x18613D450", Slot = "21")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x613E130", Offset = "0x613D530", VA = "0x18613E130", Slot = "4")]
	public IFEJLLDDIAM HPHABNFMNNF(BDOPCHBGINJ KOCKBILIHNN)
	{
		return default(IFEJLLDDIAM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x613E140", Offset = "0x613D540", VA = "0x18613E140", Slot = "5")]
	public IFEJLLDDIAM HPHABNFMNNF(BDOPCHBGINJ KOCKBILIHNN, bool KDDDLLLMFKP)
	{
		return default(IFEJLLDDIAM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x613CE40", Offset = "0x613C240", VA = "0x18613CE40", Slot = "6")]
	public void CHOLCKMGKIH(IFEJLLDDIAM PFMMNJCIGCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x613D0C0", Offset = "0x613C4C0", VA = "0x18613D0C0", Slot = "7")]
	public void DMOFFMNEFMK(IFEJLLDDIAM PFMMNJCIGCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x613C940", Offset = "0x613BD40", VA = "0x18613C940", Slot = "8")]
	public KOGDOGFJBKE BNDCCBAJDFP(IFEJLLDDIAM PFMMNJCIGCA, IEMFLHOJCDP KOCKBILIHNN)
	{
		return default(KOGDOGFJBKE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x613D670", Offset = "0x613CA70", VA = "0x18613D670", Slot = "9")]
	public KOGDOGFJBKE EMICAGMPLKM(IFEJLLDDIAM PFMMNJCIGCA, AGKGDGMHLNC KOCKBILIHNN)
	{
		return default(KOGDOGFJBKE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x613DB70", Offset = "0x613CF70", VA = "0x18613DB70", Slot = "11")]
	public void EOCEICBBLHM(KOGDOGFJBKE KGNIKFPBPIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x613ED80", Offset = "0x613E180", VA = "0x18613ED80", Slot = "10")]
	public void PGPMAACMJKL(KOGDOGFJBKE KGNIKFPBPIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x613E3E0", Offset = "0x613D7E0", VA = "0x18613E3E0", Slot = "20")]
	public IEnumerable<Renderer> JJGADEHPCHI(IFEJLLDDIAM PFMMNJCIGCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x613D5F0", Offset = "0x613C9F0", VA = "0x18613D5F0", Slot = "12")]
	public AAAELBLCJNB EJGDPIEDAFE(OPLBKKBNPKH KOCKBILIHNN)
	{
		return default(AAAELBLCJNB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x613E450", Offset = "0x613D850", VA = "0x18613E450", Slot = "14")]
	public void JPOCHANFALC(AAAELBLCJNB GBIHNMDEKKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x613E4C0", Offset = "0x613D8C0", VA = "0x18613E4C0", Slot = "16")]
	public Task LOOHKFOJKIG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x613DF70", Offset = "0x613D370", VA = "0x18613DF70", Slot = "17")]
	public Task HBKKPFOHPJI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x613EC60", Offset = "0x613E060", VA = "0x18613EC60", Slot = "18")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(KGBKFAHLDDB))]
	public Task NPFPIPOJPND()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x613C790", Offset = "0x613BB90", VA = "0x18613C790", Slot = "19")]
	public void BLIDOAPMKLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x613E0D0", Offset = "0x613D4D0", VA = "0x18613E0D0", Slot = "13")]
	public void HFCNFHGOMCF(AAAELBLCJNB GBIHNMDEKKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x613E630", Offset = "0x613DA30", VA = "0x18613E630", Slot = "25")]
	public NNMDBANNGOB MHFLJHJJJBO(IKNPDLBNFFO IOLANPMBGGL, IEnumerable<KOGDOGFJBKE> PGBFCNIDLDN, int OHIHDLOLIKE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class GGNFMKLFEFA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	private struct FHIOOIBJJBO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public BOKAALLHIPE CGIOCLOIKCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public IKNPDLBNFFO EADNKBADPGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public int DLKIJPNOBDC;
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class CICEAAPKEBH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public GGNFMKLFEFA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public int numVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public int numIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public NJEJOLDCKKD lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public List<FHIOOIBJJBO> boneMeshInfos;

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public CICEAAPKEBH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class GKNPMPNMKFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public FALIJOGACGN combinedMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public CICEAAPKEBH CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public GKNPMPNMKFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x6140830", Offset = "0x613FC30", VA = "0x186140830")]
		internal JobHandle BKBEBDHNKAF()
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x6140A10", Offset = "0x613FE10", VA = "0x186140A10")]
		internal void KPJICHJNLGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x61408A0", Offset = "0x613FCA0", VA = "0x1861408A0")]
		internal void CAJNMNLPBDO()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private int[] GGPPIBCPBCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private NIMOJLEOAJI LEGPLNFMBPL;

	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private static Matrix4x4 IMNIONDIEMF;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public Mesh KDGAOLNBAKE
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x856480", Offset = "0x855880", VA = "0x180856480")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x87D040", Offset = "0x87C440", VA = "0x18087D040")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public int JKEMMJPKLMB
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x856570", Offset = "0x855970", VA = "0x180856570")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x86C210", Offset = "0x86B610", VA = "0x18086C210")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x6140070", Offset = "0x613F470", VA = "0x186140070")]
	public void JNMIEDKKIEH(List<IKNPDLBNFFO> LGHHLAPPDII, Matrix4x4[] NEKLNLBKBGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x613F640", Offset = "0x613EA40", VA = "0x18613F640")]
	public static List<GGNFMKLFEFA> EDGHPEHNECD(List<JOHKBONEMBB> MHKPPONCJCL, NJEJOLDCKKD HIBHFNPJOBC, Bounds OFDGOIDMBAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x613FC80", Offset = "0x613F080", VA = "0x18613FC80")]
	private JobHandle FJHNJEHOMNK(FALIJOGACGN KNKPJMFEEIK, int BDDKPHJFIPG, int AMMKFOGBIHF, NJEJOLDCKKD HIBHFNPJOBC, List<FHIOOIBJJBO> CFJJFOCLLIP)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x613F4C0", Offset = "0x613E8C0", VA = "0x18613F4C0")]
	private void DFBCPMNEJCH(List<FHIOOIBJJBO> CFJJFOCLLIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x6140400", Offset = "0x613F800", VA = "0x186140400")]
	private GGNFMKLFEFA(List<FHIOOIBJJBO> CFJJFOCLLIP, int BDDKPHJFIPG, int AMMKFOGBIHF, NJEJOLDCKKD HIBHFNPJOBC, Bounds OFDGOIDMBAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x613F5D0", Offset = "0x613E9D0", VA = "0x18613F5D0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class HFGJEPMCPBH : GJGJIAJAIJK
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class JPCGILOKFDG : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public HFGJEPMCPBH <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x8117E0", Offset = "0x810BE0", VA = "0x1808117E0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x8117E0", Offset = "0x810BE0", VA = "0x1808117E0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0xB93C20", Offset = "0xB93020", VA = "0x180B93C20")]
		[DebuggerHidden]
		public JPCGILOKFDG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x6145F60", Offset = "0x6145360", VA = "0x186145F60", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x6145C60", Offset = "0x6145060", VA = "0x186145C60", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x6145C10", Offset = "0x6145010", VA = "0x186145C10")]
		private void DJGMDMALOCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x6145F20", Offset = "0x6145320", VA = "0x186145F20", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x6145E80", Offset = "0x6145280", VA = "0x186145E80", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x6145E80", Offset = "0x6145280", VA = "0x186145E80", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly OPLBKKBNPKH PLGKLJFBCGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly HKGJBMGBOJG CIHKCLLEADK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private BEOMFALAAMB KKGFJCMJDIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private List<GGNFMKLFEFA> OGBHKDHPGNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private List<GGNFMKLFEFA> NCMLCIGLKAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private GameObject LOECKGFPPEK;

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6141D60", Offset = "0x6141160", VA = "0x186141D60")]
	public static HFGJEPMCPBH OOEOMIPMOEE(OPLBKKBNPKH KOCKBILIHNN, HKGJBMGBOJG CIHKCLLEADK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x6141ED0", Offset = "0x61412D0", VA = "0x186141ED0")]
	private HFGJEPMCPBH(OPLBKKBNPKH KOCKBILIHNN, HKGJBMGBOJG CIHKCLLEADK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x6140AC0", Offset = "0x613FEC0", VA = "0x186140AC0")]
	public void BPGEOBNBMJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x6140A50", Offset = "0x613FE50", VA = "0x186140A50")]
	[IteratorStateMachine(typeof(JPCGILOKFDG))]
	public IEnumerable<Renderer> BIEMGEBAEHK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x6140FD0", Offset = "0x61403D0", VA = "0x186140FD0", Slot = "4")]
	public void ENPDCOANMDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x6141A80", Offset = "0x6140E80", VA = "0x186141A80")]
	private void IDLPJOHHMNA(Vector3 HJKNKPHHHPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x6141B20", Offset = "0x6140F20", VA = "0x186141B20")]
	public void LNCNPCEKGKH()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class AOIEPJGNBNP
{
	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
	public AOIEPJGNBNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x8C6BB0", Offset = "0x8C5FB0", VA = "0x1808C6BB0")]
	public static string NLHKAJNPDJN(byte[] AMGPPENALAL, byte[] DKDGFKIJFBC)
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
