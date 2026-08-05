using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class LMKBMDHNCCI : KCMCHPIHHPF
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface FKAOECFMBMK
	{
		[Cpp2IlInjected.Token(Token = "0x17000008")]
		IEnumerable<AHDNNECGMHF> PBGHCDJEOKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		IReadOnlyList<JJGFBLLCOIC> MCPHDGODCMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		int GAPOEDKDCMK
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface HGKMBFIAFGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<FKAOECFMBMK> APHMPIKCGIL(KCMCHPIHHPF BANENEHPJBO);
	}

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class MHCGNDDINKO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public Predicate<AHDNNECGMHF> predicate;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public MHCGNDDINKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6EF4950", Offset = "0x6EF3150", VA = "0x186EF4950")]
		internal bool ALDGJGIHMBE(AHDNNECGMHF challenge)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class BKKKMAHNAEA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public LMKBMDHNCCI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private FKAOECFMBMK <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private IEnumerator<AHDNNECGMHF> <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private AHDNNECGMHF <challenge>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private TaskAwaiter<FKAOECFMBMK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public BKKKMAHNAEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6EF27F0", Offset = "0x6EF0FF0", VA = "0x186EF27F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly HEAIIIHAKAK ILMAPBDJNIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly HGKMBFIAFGA EKACFDEDFFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private FKAOECFMBMK HHHHKPIPAJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private IReadOnlyList<JJGFBLLCOIC> CPFGCFOCOFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private IEnumerable<AHDNNECGMHF> CDEDMDNCAOF;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool HGPLMBHOBLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6EF4560", Offset = "0x6EF2D60", VA = "0x186EF4560")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool OABOMHPGLCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6EF43F0", Offset = "0x6EF2BF0", VA = "0x186EF43F0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool DGOCBLKIDGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6EF4390", Offset = "0x6EF2B90", VA = "0x186EF4390", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool DIGKOIGCBMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6EF3D90", Offset = "0x6EF2590", VA = "0x186EF3D90", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool MBKGEBFKAEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6EF3C60", Offset = "0x6EF2460", VA = "0x186EF3C60", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int EHIBEJDGMBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6EF38A0", Offset = "0x6EF20A0", VA = "0x186EF38A0", Slot = "8")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public IReadOnlyList<JJGFBLLCOIC> MCPHDGODCMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8A5F80", Offset = "0x8A4780", VA = "0x1808A5F80", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<AHDNNECGMHF> EILGMNLMCPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6EF3B20", Offset = "0x6EF2320", VA = "0x186EF3B20", Slot = "9")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6EF3BC0", Offset = "0x6EF23C0", VA = "0x186EF3BC0", Slot = "10")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6EF4790", Offset = "0x6EF2F90", VA = "0x186EF4790")]
	[Preserve]
	public LMKBMDHNCCI([NotNull][JHPEMCNOMHI(null)] HEAIIIHAKAK ILMAPBDJNIH, [NotNull][JHPEMCNOMHI(null)] HGKMBFIAFGA EKACFDEDFFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6EF3630", Offset = "0x6EF1E30", VA = "0x186EF3630", Slot = "14")]
	public IEnumerable<AHDNNECGMHF> AAFEPEDGMHE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6EF45B0", Offset = "0x6EF2DB0", VA = "0x186EF45B0", Slot = "12")]
	public IEnumerable<AHDNNECGMHF> POGIIPCBCNO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6EF39D0", Offset = "0x6EF21D0", VA = "0x186EF39D0", Slot = "11")]
	public AHDNNECGMHF BFLJBJFOBJG(Predicate<AHDNNECGMHF> PLKOLLLEBGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6EF4480", Offset = "0x6EF2C80", VA = "0x186EF4480")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(BKKKMAHNAEA))]
	private void NGPOHCAGCEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6EF3EC0", Offset = "0x6EF26C0", VA = "0x186EF3EC0")]
	private void HEDHKPGEIKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6EF4150", Offset = "0x6EF2950", VA = "0x186EF4150")]
	private void HHLHIBOPGKE(AHDNNECGMHF FGDAOBINKJC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface AHDNNECGMHF
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public interface LJJBCOKJNIN
	{
		[Cpp2IlInjected.Token(Token = "0x17000015")]
		Sprite NJCDFALCGEC
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	int ADNPGIMLOCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool PHLCEBHEFLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	string LKIEICODGFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	ELCDCGBINGK EBHKCGDLBLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	string PHJJNBOEBNO
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	Texture2D PGLKJCHAIKG
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	Sprite JNKGLEECOHH
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	KIHPFHFLGKI EPEDDGINHOL
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	bool PGEBABEAKCO
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool FJOACOHAPGC
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<AHDNNECGMHF> BJLJOPFKMKE;

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "13")]
	GHJKEMFHLHG KGNPHJHGFKA();

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "14")]
	JJMNNLLBAJO<bool> MCHECOIOCKK();
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface KCMCHPIHHPF
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool OABOMHPGLCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool DGOCBLKIDGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool DIGKOIGCBMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool MBKGEBFKAEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	int EHIBEJDGMBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action<AHDNNECGMHF> EILGMNLMCPJ;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	AHDNNECGMHF BFLJBJFOBJG(Predicate<AHDNNECGMHF> PLKOLLLEBGA);

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IEnumerable<AHDNNECGMHF> POGIIPCBCNO();
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class ELCDCGBINGK : ReadOnlyCollection<AHDNNECGMHF>, JJGFBLLCOIC, IReadOnlyCollection<AHDNNECGMHF>, IEnumerable<AHDNNECGMHF>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public string EHNKIECOKGD
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x7EC6C0", Offset = "0x7EAEC0", VA = "0x1807EC6C0", Slot = "35")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public Sprite JNKGLEECOHH
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8A5F80", Offset = "0x8A4780", VA = "0x1808A5F80", Slot = "36")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6EF3550", Offset = "0x6EF1D50", VA = "0x186EF3550")]
	public ELCDCGBINGK([NotNull] string MDOAADHDBMA, [NotNull] IList<AHDNNECGMHF> DFMKDLJIHMN, [NotNull] Sprite KNPIEPFPOHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6EF3410", Offset = "0x6EF1C10", VA = "0x186EF3410", Slot = "37")]
	public bool NCFDGOFBMGE(AHDNNECGMHF FGDAOBINKJC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface JJGFBLLCOIC : IReadOnlyCollection<AHDNNECGMHF>, IEnumerable<AHDNNECGMHF>, IEnumerable
{
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface NFGBOGLPKEO
{
	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool DLKHPNBPPJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action FBKKHLCGGIL;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event Action CJNMMBKNMPB;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EOJAGOBFLGC();

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GLIAKFMGAEP();
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public enum DLJJGCNKIJA
{
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	Mobile,
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	Screens,
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	VR
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class EILEBCDIPGB : NFGBOGLPKEO
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public interface ONLDFCBADKF
	{
		[Cpp2IlInjected.Token(Token = "0x17000020")]
		int BCDIGNAMHHD
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public interface DDHOOCMPELJ
	{
		[Cpp2IlInjected.Token(Token = "0x17000021")]
		int OCNLOPMPFFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly DDHOOCMPELJ NGFOBDLNLNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly KCMCHPIHHPF BANENEHPJBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly int BMIIPBECJKG;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	private int PPCGMNGAOLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6EF3270", Offset = "0x6EF1A70", VA = "0x186EF3270")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool DLKHPNBPPJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6EF2EF0", Offset = "0x6EF16F0", VA = "0x186EF2EF0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action FBKKHLCGGIL
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6EF2E50", Offset = "0x6EF1650", VA = "0x186EF2E50", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6EF2DB0", Offset = "0x6EF15B0", VA = "0x186EF2DB0", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action CJNMMBKNMPB
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6EF31D0", Offset = "0x6EF19D0", VA = "0x186EF31D0", Slot = "9")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6EF3130", Offset = "0x6EF1930", VA = "0x186EF3130", Slot = "10")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6EF32C0", Offset = "0x6EF1AC0", VA = "0x186EF32C0")]
	[Preserve]
	public EILEBCDIPGB([NotNull][JHPEMCNOMHI(null)] ONLDFCBADKF ANFLNBMDHAK, [NotNull][JHPEMCNOMHI(null)] DDHOOCMPELJ NGFOBDLNLNG, [NotNull][JHPEMCNOMHI(null)] KCMCHPIHHPF BANENEHPJBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6EF2F80", Offset = "0x6EF1780", VA = "0x186EF2F80", Slot = "5")]
	public void EOJAGOBFLGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6EF3050", Offset = "0x6EF1850", VA = "0x186EF3050", Slot = "6")]
	public void GLIAKFMGAEP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface MKHOLMMGHLB
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "0")]
	DLJJGCNKIJA CDONLDKFENN();
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface HEAIIIHAKAK
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool FHNKHKNMKFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	bool OGNAKEFPHMN
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool HGPLMBHOBLK
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	TimeSpan HNMLFLFBEMB
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event Action PABCAIOLHJD;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action MMECPHANLOE;
}
namespace Cpp2IlInjected;

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
