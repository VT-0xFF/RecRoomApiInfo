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
public interface JLLLFLOENCH
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	JFPAPFGNHHF IPBJHMOANMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	FOAEPBDLBNK IPBJHMOANMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	NJCOKLJJMJN IPBJHMOANMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class LNLIMCMNPCA : GKGNKAKOKPC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private const byte BDNAFHLJPII = byte.MaxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private byte CCMMBPMJECM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly List<SkinnedShapeRenderer>[] EGBLEBBHCBI;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int EKBOLDOGMJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA74E00", Offset = "0xA73E00", VA = "0x180A74E00", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xBE6AC0", Offset = "0xBE5AC0", VA = "0x180BE6AC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int ILFHGGJNMPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA4DA60", Offset = "0xA4CA60", VA = "0x180A4DA60", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xA4B2B0", Offset = "0xA4A2B0", VA = "0x180A4B2B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public float OJKEBEAOJJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x97F070", Offset = "0x97E070", VA = "0x18097F070", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x97F010", Offset = "0x97E010", VA = "0x18097F010")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public float IECIHKDNPFM
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1031FA0", Offset = "0x1030FA0", VA = "0x181031FA0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x1032050", Offset = "0x1031050", VA = "0x181032050")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public List<SkinnedShapeRenderer> CELJLEBHDPH
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5F9C080", Offset = "0x5F9B080", VA = "0x185F9C080")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public List<SkinnedShapeRenderer> GIEGIIMLCNM
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5F9C340", Offset = "0x5F9B340", VA = "0x185F9C340")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public GameObject EDABIFLHHKC
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x936350", Offset = "0x935350", VA = "0x180936350")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x9F7120", Offset = "0x9F6120", VA = "0x1809F7120")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public byte KGCCOLKGKJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5F9BE20", Offset = "0x5F9AE20", VA = "0x185F9BE20", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5F9C380", Offset = "0x5F9B380", VA = "0x185F9C380")]
	public LNLIMCMNPCA(List<NLLBNGLDCLO> NCHJPPLMPEG, List<NLLBNGLDCLO> HAIELNGHBHL, List<ILAKCHBHFNG> IPKEGFKMCOE, Material AKEPBJIDOFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5F9C0E0", Offset = "0x5F9B0E0", VA = "0x185F9C0E0")]
	private int HPBLMPOMAKJ(List<NLLBNGLDCLO> DCDMEMEMELG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5F9C1F0", Offset = "0x5F9B1F0", VA = "0x185F9C1F0")]
	private void ILFAOAKHKDM(int OIIMLCNHFMO, bool LEOEHJANNDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5F9BFE0", Offset = "0x5F9AFE0", VA = "0x185F9BFE0")]
	public void EPDLPEFCNPC(Vector3 DHKECFFBNOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5F9BEB0", Offset = "0x5F9AEB0", VA = "0x185F9BEB0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5F9BE70", Offset = "0x5F9AE70", VA = "0x185F9BE70")]
	public void CNCGDJMCAMM(Transform ADFLHLKIPFC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
internal class EMKDFBONDDG : FOAEPBDLBNK
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	private struct GBJBIONOOEG : EEFKANFHKOI, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private FCGJCEDPGBP DHAKOBAHEEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private JobHandle IPAONMLGDFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private DGKIJOKKHHN OLELJPAECBJ;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x5F99670", Offset = "0x5F98670", VA = "0x185F99670")]
		public GBJBIONOOEG(FCGJCEDPGBP DHAKOBAHEEC, JobHandle IPAONMLGDFN, DGKIJOKKHHN OLELJPAECBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x376A0F0", Offset = "0x37690F0", VA = "0x18376A0F0")]
		public bool NGNLIOBNBBA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5F99640", Offset = "0x5F98640", VA = "0x185F99640", Slot = "4")]
		public FCGJCEDPGBP OHNMHKDFAKC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x5F995F0", Offset = "0x5F985F0", VA = "0x185F995F0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public readonly ALDHKGMJCAI KBOOCNEMIKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private int[] CDHMEMNHNAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private float JOMFHOEGFLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private Hash128 NIJHKBLCOBI;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override EHNACCNKGJD CIIABJLMODM
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5F92780", Offset = "0x5F91780", VA = "0x185F92780", Slot = "17")]
		get
		{
			return default(EHNACCNKGJD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private Vector3 IKJAHJBOACC
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5F92B50", Offset = "0x5F91B50", VA = "0x185F92B50")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	protected override Hash128 KHAMGLICLAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5F940F0", Offset = "0x5F930F0", VA = "0x185F940F0", Slot = "22")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5F94210", Offset = "0x5F93210", VA = "0x185F94210")]
	public EMKDFBONDDG(JFPAPFGNHHF FMNCHFNIOHH, ALDHKGMJCAI HCKNMLENIIG, bool JEBPCMIONIJ = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5F93990", Offset = "0x5F92990", VA = "0x185F93990", Slot = "16")]
	public override bool IOBLECOPNPD(ILAKCHBHFNG FMNCHFNIOHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5F93620", Offset = "0x5F92620", VA = "0x185F93620", Slot = "18")]
	public override int HPBLMPOMAKJ(MMODIMNGPPH KOHNHJGAEDJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5F91EB0", Offset = "0x5F90EB0", VA = "0x185F91EB0", Slot = "19")]
	public override int BDFPKGEIPEG(MMODIMNGPPH KOHNHJGAEDJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5F936D0", Offset = "0x5F926D0", VA = "0x185F936D0")]
	private int IBCJFHMAGMO(MMODIMNGPPH KOHNHJGAEDJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5F92E90", Offset = "0x5F91E90", VA = "0x185F92E90", Slot = "20")]
	public override void FANMBBEPJIP(MMODIMNGPPH KOHNHJGAEDJ, HOAEDJKLOGH CIJIBKFPBIK, int JDBELPAKDNH = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5F93E00", Offset = "0x5F92E00", VA = "0x185F93E00", Slot = "21")]
	public override ILAKCHBHFNG JGNEABKAIHJ()
	{
		return default(ILAKCHBHFNG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5F93ED0", Offset = "0x5F92ED0", VA = "0x185F93ED0", Slot = "23")]
	public override IOGDEBMHCAI LOJLHNBHJJC()
	{
		return default(IOGDEBMHCAI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5F91F60", Offset = "0x5F90F60", VA = "0x185F91F60", Slot = "24")]
	public override EEFKANFHKOI BILPJGIOBND(MMODIMNGPPH KOHNHJGAEDJ, JobHandle IPAONMLGDFN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class JFPAPFGNHHF : ECAMNINAFMF, EPNAJDOKGGB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class BJGGJHKEMCL : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public JFPAPFGNHHF <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x927DF0", Offset = "0x926DF0", VA = "0x180927DF0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x927DF0", Offset = "0x926DF0", VA = "0x180927DF0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xB730E0", Offset = "0xB720E0", VA = "0x180B730E0")]
		[DebuggerHidden]
		public BJGGJHKEMCL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x5F8DF70", Offset = "0x5F8CF70", VA = "0x185F8DF70", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x5F8D910", Offset = "0x5F8C910", VA = "0x185F8D910", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x5F8D8C0", Offset = "0x5F8C8C0", VA = "0x185F8D8C0")]
		private void JIJNIFIPMPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x5F8DE40", Offset = "0x5F8CE40", VA = "0x185F8DE40")]
		private void PJBNDPOBDFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x5F8DDF0", Offset = "0x5F8CDF0", VA = "0x185F8DDF0")]
		private void NKHJIHMLEJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x5F8DF30", Offset = "0x5F8CF30", VA = "0x185F8DF30", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x5F8DE90", Offset = "0x5F8CE90", VA = "0x185F8DE90", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x5F8DE90", Offset = "0x5F8CE90", VA = "0x185F8DE90", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class LHGKKFDMIMC : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public JFPAPFGNHHF <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x927DF0", Offset = "0x926DF0", VA = "0x180927DF0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x927DF0", Offset = "0x926DF0", VA = "0x180927DF0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xB730E0", Offset = "0xB720E0", VA = "0x180B730E0")]
		[DebuggerHidden]
		public LHGKKFDMIMC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x5F9BD40", Offset = "0x5F9AD40", VA = "0x185F9BD40", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x5F9B8D0", Offset = "0x5F9A8D0", VA = "0x185F9B8D0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x5F9B880", Offset = "0x5F9A880", VA = "0x185F9B880")]
		private void JIJNIFIPMPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x5F9BC10", Offset = "0x5F9AC10", VA = "0x185F9BC10")]
		private void PJBNDPOBDFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x5F9BD00", Offset = "0x5F9AD00", VA = "0x185F9BD00", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x5F9BC60", Offset = "0x5F9AC60", VA = "0x185F9BC60", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x5F9BC60", Offset = "0x5F9AC60", VA = "0x185F9BC60", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly DJBBCAMOLKN AHCOFOGMOCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly List<FOAEPBDLBNK> JFPKLDIMKCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private List<ClusterMeshRenderer> NJDMBJIGKOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private BatchedMeshRenderer JOHIBHGGFPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private bool GCOJNLKAMMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly bool FACEDNFPBLL;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IEnumerable<KMEKOEKANMC> DKICICFKPPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x927DF0", Offset = "0x926DF0", VA = "0x180927DF0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int OIMEGEGHHCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x5F9A2B0", Offset = "0x5F992B0", VA = "0x185F9A2B0", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public ILAKCHBHFNG IAAHOEBPJGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x5F9A1F0", Offset = "0x5F991F0", VA = "0x185F9A1F0", Slot = "7")]
		get
		{
			return default(ILAKCHBHFNG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public List<SkinnedShapeRenderer> JFCKNJALDDO
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x944E10", Offset = "0x943E10", VA = "0x180944E10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x960880", Offset = "0x95F880", VA = "0x180960880")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5F9B150", Offset = "0x5F9A150", VA = "0x185F9B150")]
	private bool LFKEDNEIFBI(FOAEPBDLBNK MMMIJMMKPFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5F99BB0", Offset = "0x5F98BB0", VA = "0x185F99BB0")]
	private static bool BMAFBKNNEIP(FOAEPBDLBNK MMMIJMMKPFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5F9B2D0", Offset = "0x5F9A2D0", VA = "0x185F9B2D0")]
	public JFPAPFGNHHF(DJBBCAMOLKN HCKNMLENIIG, bool MDOGAEOKDKI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5F99BD0", Offset = "0x5F98BD0", VA = "0x185F99BD0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5F9AF20", Offset = "0x5F99F20", VA = "0x185F9AF20")]
	public void KKDPLFKFCJN(FOAEPBDLBNK MMMIJMMKPFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5F9A360", Offset = "0x5F99360", VA = "0x185F9A360")]
	public void HBPDDHHFGHN(FOAEPBDLBNK MMMIJMMKPFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5F99D50", Offset = "0x5F98D50", VA = "0x185F99D50", Slot = "4")]
	public void FOIIPDCDMGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5F9A490", Offset = "0x5F99490", VA = "0x185F9A490")]
	public void IAKPNNGGIIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5F9AD30", Offset = "0x5F99D30", VA = "0x185F9AD30")]
	private void JJOANICIKMF(List<FOAEPBDLBNK> JFPKLDIMKCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5F9AEC0", Offset = "0x5F99EC0", VA = "0x185F9AEC0")]
	private static Material JNAMHIEMOAB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5F9AC90", Offset = "0x5F99C90", VA = "0x185F9AC90")]
	private void JJOANICIKMF(FOAEPBDLBNK MMMIJMMKPFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5F9B1F0", Offset = "0x5F9A1F0", VA = "0x185F9B1F0")]
	private void PGMGKIFGCCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5F9A6E0", Offset = "0x5F996E0", VA = "0x185F9A6E0")]
	public void IDGCKHBBHHA(bool PAPPHHBKDCJ, bool CNAEBCAMKMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5F99B20", Offset = "0x5F98B20", VA = "0x185F99B20")]
	protected void ABDHBJEAHDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5F9A2F0", Offset = "0x5F992F0", VA = "0x185F9A2F0")]
	[IteratorStateMachine(typeof(BJGGJHKEMCL))]
	public IEnumerable<Renderer> GOGKGDHGEIE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5F9B180", Offset = "0x5F9A180", VA = "0x185F9B180")]
	[IteratorStateMachine(typeof(LHGKKFDMIMC))]
	public IEnumerable<Renderer> OEODBMEOABA()
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
		[Cpp2IlInjected.Address(RVA = "0x5F9F230", Offset = "0x5F9E230", VA = "0x185F9F230")]
		public ShapeRendererConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[DefaultMember("Item")]
public class EMGGJMAIFFN : GAHNJLMAFHI, IDisposable, JLLLFLOENCH
{
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static readonly FACALIAHOGE IHHCPPEACEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly DFLFBAKLKAC<FDEEDPFGKHB, JFPAPFGNHHF> FGMJLNBMKBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly DFLFBAKLKAC<APDDHIFAEFF, FOAEPBDLBNK> JFPKLDIMKCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly DFLFBAKLKAC<ALDEJIMEPDN, NJCOKLJJMJN> ENNDDICMGCA;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public JFPAPFGNHHF IPBJHMOANMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x5F90DB0", Offset = "0x5F8FDB0", VA = "0x185F90DB0", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public FOAEPBDLBNK IPBJHMOANMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x5F90E10", Offset = "0x5F8FE10", VA = "0x185F90E10", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public NJCOKLJJMJN IPBJHMOANMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x5F90D50", Offset = "0x5F8FD50", VA = "0x185F90D50", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public bool LMHCKLDBPGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x944220", Offset = "0x943220", VA = "0x180944220", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x944420", Offset = "0x943420", VA = "0x180944420")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5F91AD0", Offset = "0x5F90AD0", VA = "0x185F91AD0")]
	public EMGGJMAIFFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5F90E70", Offset = "0x5F8FE70", VA = "0x185F90E70", Slot = "21")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5F90F70", Offset = "0x5F8FF70", VA = "0x185F90F70", Slot = "4")]
	public FDEEDPFGKHB GJFBOJJFIHH(DJBBCAMOLKN HCKNMLENIIG)
	{
		return default(FDEEDPFGKHB);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5F90F70", Offset = "0x5F8FF70", VA = "0x185F90F70", Slot = "5")]
	public FDEEDPFGKHB GJFBOJJFIHH(DJBBCAMOLKN HCKNMLENIIG, bool MDOGAEOKDKI)
	{
		return default(FDEEDPFGKHB);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5F91970", Offset = "0x5F90970", VA = "0x185F91970", Slot = "6")]
	public void PIIKFOJFIOO(FDEEDPFGKHB FMNCHFNIOHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5F90C70", Offset = "0x5F8FC70", VA = "0x185F90C70", Slot = "7")]
	public void ANACLDHAPLB(FDEEDPFGKHB FMNCHFNIOHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5F913F0", Offset = "0x5F903F0", VA = "0x185F913F0", Slot = "8")]
	public APDDHIFAEFF LABKGHGFGHF(FDEEDPFGKHB FMNCHFNIOHH, ALDHKGMJCAI HCKNMLENIIG)
	{
		return default(APDDHIFAEFF);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5F91080", Offset = "0x5F90080", VA = "0x185F91080", Slot = "9")]
	public APDDHIFAEFF GKGBEEBIABN(FDEEDPFGKHB FMNCHFNIOHH, GHBLIDIILJF HCKNMLENIIG)
	{
		return default(APDDHIFAEFF);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5F91360", Offset = "0x5F90360", VA = "0x185F91360", Slot = "11")]
	public void KGOCLKEPOOI(APDDHIFAEFF MMMIJMMKPFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x5F91910", Offset = "0x5F90910", VA = "0x185F91910", Slot = "10")]
	public void NAHMLDCGCAC(APDDHIFAEFF MMMIJMMKPFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5F90F00", Offset = "0x5F8FF00", VA = "0x185F90F00", Slot = "20")]
	public IEnumerable<Renderer> FPMAOPAACCH(FDEEDPFGKHB FMNCHFNIOHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5F912E0", Offset = "0x5F902E0", VA = "0x185F912E0", Slot = "12")]
	public ALDEJIMEPDN KAGINFLEEOH(MHCCGAJOFBH HCKNMLENIIG)
	{
		return default(ALDEJIMEPDN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x5F919D0", Offset = "0x5F909D0", VA = "0x185F919D0", Slot = "14")]
	public void PLCMDCBCJOH(ALDEJIMEPDN AECGKOMJOLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5F91280", Offset = "0x5F90280", VA = "0x185F91280", Slot = "16")]
	public Task JLFFDBFGPOC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5F91220", Offset = "0x5F90220", VA = "0x185F91220", Slot = "17")]
	public Task HDOPEFLAOAP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5F911C0", Offset = "0x5F901C0", VA = "0x185F911C0", Slot = "18")]
	public Task GKPOLINNKPD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x2E34000", Offset = "0x2E33000", VA = "0x182E34000", Slot = "19")]
	public void CINKPDHFMMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5F90CF0", Offset = "0x5F8FCF0", VA = "0x185F90CF0", Slot = "13")]
	public void BELJMOKABMA(ALDEJIMEPDN AECGKOMJOLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5F91520", Offset = "0x5F90520", VA = "0x185F91520", Slot = "25")]
	public FCOGJPCHMEG LEGIPJPDCFL(ILAKCHBHFNG OGHPMJBPMMC, IEnumerable<APDDHIFAEFF> JFPKLDIMKCD, int MDBGAKLFFFJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface IAJCLIPGGOC
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NMJBKCBEMAG(JOJGLDNKBNG FLAJIGGIBOB, Renderer KEIBCBDBMJF, int KIJGMCLEDLK);

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FKLLBENCBMP(Renderer KEIBCBDBMJF, PBFKAKAGAIJ MILEKKHNKLI, Vector3 MHJCHFLOAOF, Vector3 NLGDGJDHHCN, Vector3 KMFPMFMFFIG, float FDBODHIJCLK, float FILFGJPBLNL, float EMKEKAFMJKM = -1f, [Optional] Color? OAIMCLIJEAP, [Optional] IReadOnlyList<Camera> AJPFFKBBJFJ);

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NPDIGLDMNCN(Renderer KEIBCBDBMJF, int KIJGMCLEDLK);

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int KCGNEKGCPAF();

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ILDFKGFNCLC(int AHMPJKAJBAJ, KKAMNNCNEEM FLAJIGGIBOB, Renderer KEIBCBDBMJF, int KIJGMCLEDLK);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class FCMIJCAFKAP : HPJDNKFIOEH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private class AKFHNILAAIH : PODMHLLCHNH<int>
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x5F8D6C0", Offset = "0x5F8C6C0", VA = "0x185F8D6C0")]
		public AKFHNILAAIH(string OKONKHNEMOO)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly IAJCLIPGGOC GKECFLAKJCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly JLLLFLOENCH DPHLOCJJBPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private MeshRenderer FDFHJCIEEDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private AKFHNILAAIH EJPALACPPII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private bool BFFNMOECOBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private MeshRenderer NDOKCCFJMHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private AKFHNILAAIH CMMFFINJNHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private bool EKJDNAGCPNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private MeshRenderer IMCHBFMGNJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private AKFHNILAAIH CBHBNEKEPDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private bool LOOPOECADGB;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5F966A0", Offset = "0x5F956A0", VA = "0x185F966A0")]
	public FCMIJCAFKAP(IAJCLIPGGOC BBDEGLIAEJP, JLLLFLOENCH DPHLOCJJBPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x5F94800", Offset = "0x5F93800", VA = "0x185F94800", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x5F95A60", Offset = "0x5F94A60", VA = "0x185F95A60")]
	private void JPNJELNBGPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x5F95860", Offset = "0x5F94860", VA = "0x185F95860", Slot = "4")]
	public void JPDGJCDKIAL(FDEEDPFGKHB FMNCHFNIOHH, KKAMNNCNEEM AOGHJNLEEHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x5F95640", Offset = "0x5F94640", VA = "0x185F95640", Slot = "5")]
	public void JPDGJCDKIAL(APDDHIFAEFF MMMIJMMKPFM, KKAMNNCNEEM AOGHJNLEEHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x5F942C0", Offset = "0x5F932C0", VA = "0x185F942C0", Slot = "6")]
	public void BOOKIFOEAOM(APDDHIFAEFF MMMIJMMKPFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x5F94530", Offset = "0x5F93530", VA = "0x185F94530", Slot = "7")]
	public void DBPLDKAPLHE(APDDHIFAEFF MMMIJMMKPFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x5F96660", Offset = "0x5F95660", VA = "0x185F96660", Slot = "21")]
	public void PJPOCNDCBGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x1393120", Offset = "0x1392120", VA = "0x181393120", Slot = "8")]
	public void NLEMHBOCPHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5F94690", Offset = "0x5F93690", VA = "0x185F94690", Slot = "9")]
	public void DOMFKMMFHPM(KKAMNNCNEEM AOGHJNLEEHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5F95140", Offset = "0x5F94140", VA = "0x185F95140", Slot = "10")]
	public void JMFGAJMOFFB(FDEEDPFGKHB FMNCHFNIOHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x5F952F0", Offset = "0x5F942F0", VA = "0x185F952F0", Slot = "11")]
	public void JMFGAJMOFFB(APDDHIFAEFF MMMIJMMKPFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x5F95F30", Offset = "0x5F94F30", VA = "0x185F95F30", Slot = "12")]
	public void LNHLEHHMFNF(FDEEDPFGKHB FMNCHFNIOHH, JOJGLDNKBNG FLAJIGGIBOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x5F95D40", Offset = "0x5F94D40", VA = "0x185F95D40", Slot = "13")]
	public void LNHLEHHMFNF(APDDHIFAEFF MMMIJMMKPFM, JOJGLDNKBNG FLAJIGGIBOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x5F94650", Offset = "0x5F93650", VA = "0x185F94650", Slot = "22")]
	public void DFKPJKGNBPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x5F962A0", Offset = "0x5F952A0", VA = "0x185F962A0", Slot = "14")]
	public void NMGAKDHOGGI(APDDHIFAEFF MMMIJMMKPFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x5F95CB0", Offset = "0x5F94CB0", VA = "0x185F95CB0", Slot = "15")]
	public void LNGPIBOFLHG(APDDHIFAEFF MMMIJMMKPFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x851A10", Offset = "0x850A10", VA = "0x180851A10", Slot = "16")]
	public void NJFGGMDMAJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x5F943F0", Offset = "0x5F933F0", VA = "0x185F943F0", Slot = "17")]
	public void CDODGEEMBLP(JOJGLDNKBNG FLAJIGGIBOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x5F96410", Offset = "0x5F95410", VA = "0x185F96410")]
	private void OKGMONGNBFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x5F960E0", Offset = "0x5F950E0", VA = "0x185F960E0")]
	public void LNHLEHHMFNF(APDDHIFAEFF MMMIJMMKPFM, JOJGLDNKBNG FLAJIGGIBOB, bool OPKENHMJOFC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x5F96340", Offset = "0x5F95340", VA = "0x185F96340")]
	private void NMJBKCBEMAG(JOJGLDNKBNG FLAJIGGIBOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x5F949D0", Offset = "0x5F939D0", VA = "0x185F949D0", Slot = "18")]
	public void EALNBAPFJNO(FDEEDPFGKHB FMNCHFNIOHH, Vector3 MHJCHFLOAOF, Vector3 NLGDGJDHHCN, Vector3 KMFPMFMFFIG, float FDBODHIJCLK, float FILFGJPBLNL, IReadOnlyList<Camera> EOAEMGOFOCC, PBFKAKAGAIJ MILEKKHNKLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x5F94D40", Offset = "0x5F93D40", VA = "0x185F94D40", Slot = "19")]
	public void EALNBAPFJNO(ALDEJIMEPDN AECGKOMJOLE, Vector3 MHJCHFLOAOF, Vector3 NLGDGJDHHCN, Vector3 KMFPMFMFFIG, float FDBODHIJCLK, float FILFGJPBLNL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class CEFGMKELEEP
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class BHMLFMKJKCA : IEnumerable<FCMOBMEGEBG>, IEnumerable, IEnumerator<FCMOBMEGEBG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private FCMOBMEGEBG <>2__current;

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
		private FCMOBMEGEBG System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.PrimitiveShapeMeshData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x927DF0", Offset = "0x926DF0", VA = "0x180927DF0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x927DF0", Offset = "0x926DF0", VA = "0x180927DF0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0xB730E0", Offset = "0xB720E0", VA = "0x180B730E0")]
		[DebuggerHidden]
		public BHMLFMKJKCA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x5F8D710", Offset = "0x5F8C710", VA = "0x185F8D710", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x5F8D880", Offset = "0x5F8C880", VA = "0x185F8D880", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x5F8D7F0", Offset = "0x5F8C7F0", VA = "0x185F8D7F0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<FCMOBMEGEBG> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.PrimitiveShapeMeshData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x5F8D7F0", Offset = "0x5F8C7F0", VA = "0x185F8D7F0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public const int ECJEICHHKLP = 3;

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private static FCMOBMEGEBG[][] PDHPPJMBNEL;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private static FDEDOLFCFFH FGEBKJHJIBH;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public static ShapeRendererConfig HFGEODDMCEC;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public static ComputeShader BCLFIIGDPPN
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x5F8EBD0", Offset = "0x5F8DBD0", VA = "0x185F8EBD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public static SkinnedShapeRenderer HODGECHFOFB
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x5F8EC50", Offset = "0x5F8DC50", VA = "0x185F8EC50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x5F8E560", Offset = "0x5F8D560", VA = "0x185F8E560")]
	public static Mesh CIEJNHFKLKL(IBAFDJCDMKA MGLKKKNNHMF, int KOHNHJGAEDJ = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x5F8E620", Offset = "0x5F8D620", VA = "0x185F8E620")]
	public static int CPMICMIIOFE(IBAFDJCDMKA MGLKKKNNHMF, int KOHNHJGAEDJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x5F8E400", Offset = "0x5F8D400", VA = "0x185F8E400")]
	public static FDEDOLFCFFH BOKMKANDEKC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x5F8EE70", Offset = "0x5F8DE70", VA = "0x185F8EE70")]
	[IteratorStateMachine(typeof(BHMLFMKJKCA))]
	private static IEnumerable<FCMOBMEGEBG> PBNAJHJJKHI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x5F8E850", Offset = "0x5F8D850", VA = "0x185F8E850")]
	public static FCMOBMEGEBG GPEHJFHBFIF(IBAFDJCDMKA MGLKKKNNHMF, int KOHNHJGAEDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x5F8EBB0", Offset = "0x5F8DBB0", VA = "0x185F8EBB0")]
	public static bool HANHMEJMIKA(this IBAFDJCDMKA MGLKKKNNHMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x5F8ECC0", Offset = "0x5F8DCC0", VA = "0x185F8ECC0")]
	public static void OPMPKDFCAFL(IBAFDJCDMKA MGLKKKNNHMF, float3 KFNODIAOFMN, out LCIKAMHAEKC LCMMMKKDNDO, out float3 PNGFJKKBLKP, out float FINODEPNAJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x5F8E070", Offset = "0x5F8D070", VA = "0x185F8E070")]
	public static void BLLNJKHGOHF(Vector3 KFNODIAOFMN, IBAFDJCDMKA MGLKKKNNHMF, out Vector3 PNGFJKKBLKP, out float FINODEPNAJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x5F8EC40", Offset = "0x5F8DC40", VA = "0x185F8EC40")]
	[PPMJBBHKDPA(BIABBNOAALP.ExitingPlayMode, 0)]
	private static void JNACBKDMCJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x5F8E630", Offset = "0x5F8D630", VA = "0x185F8E630")]
	[PPMJBBHKDPA(BIABBNOAALP.ExitingPlayMode, 0)]
	private static void FFAPALEIKMJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public abstract class FOAEPBDLBNK : EBGHMAHLFAN, KMEKOEKANMC, IEAIGJFCEGG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public readonly JFPAPFGNHHF EDABIFLHHKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	protected Bounds KFHNIDJJBFP;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public Bounds PLDNLCPMGPH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0xBA7810", Offset = "0xBA6810", VA = "0x180BA7810", Slot = "4")]
		get
		{
			return default(Bounds);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public virtual EHNACCNKGJD CIIABJLMODM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x5F96720", Offset = "0x5F95720", VA = "0x185F96720", Slot = "17")]
		get
		{
			return default(EHNACCNKGJD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public bool FACEDNFPBLL
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x1031E00", Offset = "0x1030E00", VA = "0x181031E00")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x960870", Offset = "0x95F870", VA = "0x180960870")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	protected abstract Hash128 KHAMGLICLAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int GMCEJAGEDOM
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x842FC0", Offset = "0x841FC0", VA = "0x180842FC0", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public KPAJPMPHMPC KIEPBBADMJO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x944E10", Offset = "0x943E10", VA = "0x180944E10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x960880", Offset = "0x95F880", VA = "0x180960880")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public bool ADNLJCHEAJC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x34CA210", Offset = "0x34C9210", VA = "0x1834CA210")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x934550", Offset = "0x933550", VA = "0x180934550")]
	protected FOAEPBDLBNK(JFPAPFGNHHF FMNCHFNIOHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x5F967B0", Offset = "0x5F957B0", VA = "0x185F967B0", Slot = "15")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x84F1E0", Offset = "0x84E1E0", VA = "0x18084F1E0", Slot = "16")]
	public virtual bool IOBLECOPNPD(ILAKCHBHFNG FMNCHFNIOHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "18")]
	public abstract int HPBLMPOMAKJ(MMODIMNGPPH KOHNHJGAEDJ);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "19")]
	public abstract int BDFPKGEIPEG(MMODIMNGPPH KOHNHJGAEDJ);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "20")]
	public abstract void FANMBBEPJIP(MMODIMNGPPH KOHNHJGAEDJ, HOAEDJKLOGH CIJIBKFPBIK, int JDBELPAKDNH = -1);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "21")]
	public abstract ILAKCHBHFNG JGNEABKAIHJ();

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x5F966F0", Offset = "0x5F956F0", VA = "0x185F966F0", Slot = "11")]
	public Hash128 BHHNLNIINNG(int KOHNHJGAEDJ)
	{
		return default(Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "23")]
	public abstract IOGDEBMHCAI LOJLHNBHJJC();

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "24")]
	public abstract EEFKANFHKOI BILPJGIOBND(MMODIMNGPPH KOHNHJGAEDJ, JobHandle IPAONMLGDFN);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x5F968E0", Offset = "0x5F958E0", VA = "0x185F968E0", Slot = "10")]
	public EEFKANFHKOI LEGIPJPDCFL(int KOHNHJGAEDJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class EKELNIEJBMN : FOAEPBDLBNK
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	private struct LDLMADOOEBC : EEFKANFHKOI, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private FCGJCEDPGBP DHAKOBAHEEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private JobHandle IPAONMLGDFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private NFLEFPHAPMC OLELJPAECBJ;

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x5F9B820", Offset = "0x5F9A820", VA = "0x185F9B820")]
		public LDLMADOOEBC(FCGJCEDPGBP DHAKOBAHEEC, JobHandle IPAONMLGDFN, NFLEFPHAPMC OLELJPAECBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x376A0F0", Offset = "0x37690F0", VA = "0x18376A0F0")]
		public bool NGNLIOBNBBA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x5F9B7F0", Offset = "0x5F9A7F0", VA = "0x185F9B7F0", Slot = "4")]
		public FCGJCEDPGBP OHNMHKDFAKC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x5F9B7A0", Offset = "0x5F9A7A0", VA = "0x185F9B7A0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private readonly GHBLIDIILJF FIBGICIPBBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private float JOMFHOEGFLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private Hash128 NIJHKBLCOBI;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	protected override Hash128 KHAMGLICLAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x5F90AA0", Offset = "0x5F8FAA0", VA = "0x185F90AA0", Slot = "22")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x5F90BC0", Offset = "0x5F8FBC0", VA = "0x185F90BC0")]
	public EKELNIEJBMN(JFPAPFGNHHF FMNCHFNIOHH, GHBLIDIILJF HCKNMLENIIG, bool MDOGAEOKDKI = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x84F1E0", Offset = "0x84E1E0", VA = "0x18084F1E0", Slot = "16")]
	public override bool IOBLECOPNPD(ILAKCHBHFNG FMNCHFNIOHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x5F905C0", Offset = "0x5F8F5C0", VA = "0x185F905C0", Slot = "18")]
	public override int HPBLMPOMAKJ(MMODIMNGPPH KOHNHJGAEDJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x5F8F430", Offset = "0x5F8E430", VA = "0x185F8F430", Slot = "19")]
	public override int BDFPKGEIPEG(MMODIMNGPPH KOHNHJGAEDJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x5F8FEE0", Offset = "0x5F8EEE0", VA = "0x185F8FEE0", Slot = "20")]
	public override void FANMBBEPJIP(MMODIMNGPPH KOHNHJGAEDJ, HOAEDJKLOGH CIJIBKFPBIK, int JDBELPAKDNH = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x5F907B0", Offset = "0x5F8F7B0", VA = "0x185F907B0", Slot = "21")]
	public override ILAKCHBHFNG JGNEABKAIHJ()
	{
		return default(ILAKCHBHFNG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x5F90880", Offset = "0x5F8F880", VA = "0x185F90880", Slot = "23")]
	public override IOGDEBMHCAI LOJLHNBHJJC()
	{
		return default(IOGDEBMHCAI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x5F8F620", Offset = "0x5F8E620", VA = "0x185F8F620", Slot = "24")]
	public override EEFKANFHKOI BILPJGIOBND(MMODIMNGPPH KOHNHJGAEDJ, JobHandle IPAONMLGDFN)
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
		private MaterialPropertyBlock HCKKHBDACEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private NLLBNGLDCLO DHAKOBAHEEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private List<ILAKCHBHFNG> IPKEGFKMCOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private RenderTexture PHAHPBHJDPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private ComputeBuffer LPMBNNFNCHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private ComputeShader HHMHFHAMGHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private Matrix4x4[] MICCGPJAONM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private int BGGIAJHHMCN;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public MeshRenderer JAAPOFFMLPC
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x927DF0", Offset = "0x926DF0", VA = "0x180927DF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x92E3F0", Offset = "0x92D3F0", VA = "0x18092E3F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public int PBCFAOEFBEI
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x5F9FEF0", Offset = "0x5F9EEF0", VA = "0x185F9FEF0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x5F9F260", Offset = "0x5F9E260", VA = "0x185F9F260")]
		public static List<SkinnedShapeRenderer> Create(GameObject FMNCHFNIOHH, List<NLLBNGLDCLO> DCDMEMEMELG, List<ILAKCHBHFNG> IPKEGFKMCOE, Material AKEPBJIDOFF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x5F9F8A0", Offset = "0x5F9E8A0", VA = "0x185F9F8A0")]
		public void Init(NLLBNGLDCLO DHAKOBAHEEC, List<ILAKCHBHFNG> IPKEGFKMCOE, Material AKEPBJIDOFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x5F9FE40", Offset = "0x5F9EE40", VA = "0x185F9FE40")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x5F9FD90", Offset = "0x5F9ED90", VA = "0x185F9FD90")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x5F9FD50", Offset = "0x5F9ED50", VA = "0x185F9FD50")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x5F9F4B0", Offset = "0x5F9E4B0", VA = "0x185F9F4B0")]
		private void DEDCOJOLLOM(ScriptableRenderContext HBLIBBFCHOD, Camera[] PEBMDFFJLFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x5F9F6E0", Offset = "0x5F9E6E0", VA = "0x185F9F6E0")]
		private void DIHJCDBCPDL(CommandBuffer HCNFLBIOGOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x966250", Offset = "0x965250", VA = "0x180966250")]
		public SkinnedShapeRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface PHNBJBLLFJJ
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	bool FEABAANJNED
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Material GNLIACKLINO();

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Material JNAMHIEMOAB();

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Material AJEFMGOJBNN();

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int NEELIJCGPIE(EABGJBJDCKI HHJIAEJDIHA);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int EKCBOHLNCFA(EDOGAFJMIEH FBHICPOFCFK);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JFHHNKHNOAD(GameObject DCGPCJKHCOO);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void GHBDAPKLBHA(GameObject DCGPCJKHCOO, bool KGGOOHMHIEL);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class GEPDINFBEOB
{
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static PHNBJBLLFJJ DAHEHNAMFLD;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public static bool FEABAANJNED
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x5F99A50", Offset = "0x5F98A50", VA = "0x185F99A50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x5F996C0", Offset = "0x5F986C0", VA = "0x185F996C0")]
	public static void AIJPFOJJKFN(PHNBJBLLFJJ IBDLNKFOENF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x5F998C0", Offset = "0x5F988C0", VA = "0x185F998C0")]
	public static Material GNLIACKLINO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x5F999F0", Offset = "0x5F989F0", VA = "0x185F999F0")]
	public static Material JNAMHIEMOAB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x5F99710", Offset = "0x5F98710", VA = "0x185F99710")]
	public static Material AJEFMGOJBNN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x5F99AB0", Offset = "0x5F98AB0", VA = "0x185F99AB0")]
	public static int NEELIJCGPIE(EABGJBJDCKI HHJIAEJDIHA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x5F99770", Offset = "0x5F98770", VA = "0x185F99770")]
	public static int EKCBOHLNCFA(EDOGAFJMIEH FBHICPOFCFK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x5F99920", Offset = "0x5F98920", VA = "0x185F99920")]
	public static void JFHHNKHNOAD(GameObject DCGPCJKHCOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x5F997E0", Offset = "0x5F987E0", VA = "0x185F997E0")]
	public static void GHBDAPKLBHA(GameObject DCGPCJKHCOO, bool KGGOOHMHIEL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[DefaultMember("Item")]
public class GALMIMAAHFK : GAHNJLMAFHI, IDisposable, JLLLFLOENCH
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class EELONGLLHKN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public GALMIMAAHFK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public EELONGLLHKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x5F8EF70", Offset = "0x5F8DF70", VA = "0x185F8EF70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly DFLFBAKLKAC<FDEEDPFGKHB, JFPAPFGNHHF> FGMJLNBMKBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly DFLFBAKLKAC<APDDHIFAEFF, FOAEPBDLBNK> JFPKLDIMKCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly DFLFBAKLKAC<ALDEJIMEPDN, NJCOKLJJMJN> ENNDDICMGCA;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public JFPAPFGNHHF IPBJHMOANMK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x5F96D60", Offset = "0x5F95D60", VA = "0x185F96D60", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public FOAEPBDLBNK IPBJHMOANMK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x5F96DC0", Offset = "0x5F95DC0", VA = "0x185F96DC0", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public NJCOKLJJMJN IPBJHMOANMK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x5F96D00", Offset = "0x5F95D00", VA = "0x185F96D00", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool LMHCKLDBPGP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x944220", Offset = "0x943220", VA = "0x180944220", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x944420", Offset = "0x943420", VA = "0x180944420")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x5F99130", Offset = "0x5F98130", VA = "0x185F99130")]
	public GALMIMAAHFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x5F96EB0", Offset = "0x5F95EB0", VA = "0x185F96EB0", Slot = "21")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x5F970C0", Offset = "0x5F960C0", VA = "0x185F970C0", Slot = "4")]
	public FDEEDPFGKHB GJFBOJJFIHH(DJBBCAMOLKN HCKNMLENIIG)
	{
		return default(FDEEDPFGKHB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x5F970D0", Offset = "0x5F960D0", VA = "0x185F970D0", Slot = "5")]
	public FDEEDPFGKHB GJFBOJJFIHH(DJBBCAMOLKN HCKNMLENIIG, bool MDOGAEOKDKI)
	{
		return default(FDEEDPFGKHB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x5F98E50", Offset = "0x5F97E50", VA = "0x185F98E50", Slot = "6")]
	public void PIIKFOJFIOO(FDEEDPFGKHB FMNCHFNIOHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x5F96910", Offset = "0x5F95910", VA = "0x185F96910", Slot = "7")]
	public void ANACLDHAPLB(FDEEDPFGKHB FMNCHFNIOHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x5F980C0", Offset = "0x5F970C0", VA = "0x185F980C0", Slot = "8")]
	public APDDHIFAEFF LABKGHGFGHF(FDEEDPFGKHB FMNCHFNIOHH, ALDHKGMJCAI HCKNMLENIIG)
	{
		return default(APDDHIFAEFF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x5F97360", Offset = "0x5F96360", VA = "0x185F97360", Slot = "9")]
	public APDDHIFAEFF GKGBEEBIABN(FDEEDPFGKHB FMNCHFNIOHH, GHBLIDIILJF HCKNMLENIIG)
	{
		return default(APDDHIFAEFF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x5F97CD0", Offset = "0x5F96CD0", VA = "0x185F97CD0", Slot = "11")]
	public void KGOCLKEPOOI(APDDHIFAEFF MMMIJMMKPFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x5F98BE0", Offset = "0x5F97BE0", VA = "0x185F98BE0", Slot = "10")]
	public void NAHMLDCGCAC(APDDHIFAEFF MMMIJMMKPFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x5F97050", Offset = "0x5F96050", VA = "0x185F97050", Slot = "20")]
	public IEnumerable<Renderer> FPMAOPAACCH(FDEEDPFGKHB FMNCHFNIOHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x5F97C50", Offset = "0x5F96C50", VA = "0x185F97C50", Slot = "12")]
	public ALDEJIMEPDN KAGINFLEEOH(MHCCGAJOFBH HCKNMLENIIG)
	{
		return default(ALDEJIMEPDN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x5F990C0", Offset = "0x5F980C0", VA = "0x185F990C0", Slot = "14")]
	public void PLCMDCBCJOH(ALDEJIMEPDN AECGKOMJOLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x5F97AE0", Offset = "0x5F96AE0", VA = "0x185F97AE0", Slot = "16")]
	public Task JLFFDBFGPOC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x5F97980", Offset = "0x5F96980", VA = "0x185F97980", Slot = "17")]
	public Task HDOPEFLAOAP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x5F97860", Offset = "0x5F96860", VA = "0x185F97860", Slot = "18")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(EELONGLLHKN))]
	public Task GKPOLINNKPD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x5F96E20", Offset = "0x5F95E20", VA = "0x185F96E20", Slot = "19")]
	public void CINKPDHFMMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x5F96CA0", Offset = "0x5F95CA0", VA = "0x185F96CA0", Slot = "13")]
	public void BELJMOKABMA(ALDEJIMEPDN AECGKOMJOLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x5F985C0", Offset = "0x5F975C0", VA = "0x185F985C0", Slot = "25")]
	public FCOGJPCHMEG LEGIPJPDCFL(ILAKCHBHFNG OGHPMJBPMMC, IEnumerable<APDDHIFAEFF> JFPKLDIMKCD, int MDBGAKLFFFJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class NLLBNGLDCLO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	private struct LKILJKHPLLB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public HOAEDJKLOGH LBJDACMPONA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public ILAKCHBHFNG EIPMIDGGBGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public int EOEDPFIJELM;
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class MBMDAPNHPPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public NLLBNGLDCLO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public int numVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public int numIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public MMODIMNGPPH lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public List<LKILJKHPLLB> boneMeshInfos;

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public MBMDAPNHPPB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class MPNCMLHDNCA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public FCGJCEDPGBP combinedMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public MBMDAPNHPPB CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public MPNCMLHDNCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x5F9C740", Offset = "0x5F9B740", VA = "0x185F9C740")]
		internal JobHandle AMPEBIDKAFP()
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x5F9C7B0", Offset = "0x5F9B7B0", VA = "0x185F9C7B0")]
		internal void DFBJNOFIBEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x5F9C7F0", Offset = "0x5F9B7F0", VA = "0x185F9C7F0")]
		internal void MCILLHEKNJJ()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private int[] FCACBGGDBEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private IGGNJKNFPCB EOAPHGFDEKI;

	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private static Matrix4x4 AGLHBBADDOA;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public Mesh HAHMHHGIIJB
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x83A5D0", Offset = "0x8395D0", VA = "0x18083A5D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x92FA60", Offset = "0x92EA60", VA = "0x18092FA60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public int KDAEBODJJBH
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x999690", Offset = "0x998690", VA = "0x180999690")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0xC33780", Offset = "0xC32780", VA = "0x180C33780")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x5F9DFD0", Offset = "0x5F9CFD0", VA = "0x185F9DFD0")]
	public void DIHJCDBCPDL(List<ILAKCHBHFNG> ICIOEAEOLKG, Matrix4x4[] KPGDBOPMOII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x5F9E2A0", Offset = "0x5F9D2A0", VA = "0x185F9E2A0")]
	public static List<NLLBNGLDCLO> GGPPECCFBMF(List<JFPAPFGNHHF> CGMKFOJELFH, MMODIMNGPPH KOHNHJGAEDJ, Bounds ADPLHOIKHIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x5F9E8E0", Offset = "0x5F9D8E0", VA = "0x185F9E8E0")]
	private JobHandle NDCHAANGFNF(FCGJCEDPGBP PFMPNLFAIKG, int NDBJNGGEKOA, int AJMFLNBOGKN, MMODIMNGPPH KOHNHJGAEDJ, List<LKILJKHPLLB> ILDKENDBMKL)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x5F9DEC0", Offset = "0x5F9CEC0", VA = "0x185F9DEC0")]
	private void AIKJHOFCHIC(List<LKILJKHPLLB> ILDKENDBMKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x5F9EE00", Offset = "0x5F9DE00", VA = "0x185F9EE00")]
	private NLLBNGLDCLO(List<LKILJKHPLLB> ILDKENDBMKL, int NDBJNGGEKOA, int AJMFLNBOGKN, MMODIMNGPPH KOHNHJGAEDJ, Bounds ADPLHOIKHIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x5F9E230", Offset = "0x5F9D230", VA = "0x185F9E230", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class NJCOKLJJMJN : ECAMNINAFMF
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class KEGFEGGOCBN : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public NJCOKLJJMJN <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x927DF0", Offset = "0x926DF0", VA = "0x180927DF0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x927DF0", Offset = "0x926DF0", VA = "0x180927DF0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0xB730E0", Offset = "0xB720E0", VA = "0x180B730E0")]
		[DebuggerHidden]
		public KEGFEGGOCBN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x5F9B710", Offset = "0x5F9A710", VA = "0x185F9B710", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x5F9B410", Offset = "0x5F9A410", VA = "0x185F9B410", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x5F9B3C0", Offset = "0x5F9A3C0", VA = "0x185F9B3C0")]
		private void JIJNIFIPMPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x5F9B6D0", Offset = "0x5F9A6D0", VA = "0x185F9B6D0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x5F9B630", Offset = "0x5F9A630", VA = "0x185F9B630", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x5F9B630", Offset = "0x5F9A630", VA = "0x185F9B630", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly MHCCGAJOFBH KPIAGIPDANI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly JLLLFLOENCH DPHLOCJJBPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private LNLIMCMNPCA AOKPCEBFBIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private List<NLLBNGLDCLO> NNIGLADHJPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private List<NLLBNGLDCLO> GHDPDPIIDAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private GameObject NIPICEIPFBK;

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x5F9CE20", Offset = "0x5F9BE20", VA = "0x185F9CE20")]
	public static NJCOKLJJMJN CEIBENHKKMG(MHCCGAJOFBH HCKNMLENIIG, JLLLFLOENCH DPHLOCJJBPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x5F9DDC0", Offset = "0x5F9CDC0", VA = "0x185F9DDC0")]
	private NJCOKLJJMJN(MHCCGAJOFBH HCKNMLENIIG, JLLLFLOENCH DPHLOCJJBPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x5F9C960", Offset = "0x5F9B960", VA = "0x185F9C960")]
	public void BHAMNPKBJIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x5F9DA70", Offset = "0x5F9CA70", VA = "0x185F9DA70")]
	[IteratorStateMachine(typeof(KEGFEGGOCBN))]
	public IEnumerable<Renderer> GOGKGDHGEIE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x5F9CF90", Offset = "0x5F9BF90", VA = "0x185F9CF90", Slot = "4")]
	public void FOIIPDCDMGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x5F9DD20", Offset = "0x5F9CD20", VA = "0x185F9DD20")]
	private void MCPFDMOGMIP(Vector3 DHKECFFBNOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x5F9DAE0", Offset = "0x5F9CAE0", VA = "0x185F9DAE0")]
	public void IAKPNNGGIIJ()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class FDBBNKLFMFL
{
	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
	public FDBBNKLFMFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x12847F0", Offset = "0x12837F0", VA = "0x1812847F0")]
	public static string PBLDHIKHPMH(byte[] IHGCJCCJPMA, byte[] NBKBACBBOJK)
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
