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
public class JNCCKKGNCPL : ICNAJEFDIFC
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface DKEDBFBEBCD
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		IEnumerable<BMOKIAFEMCO> MEIMJPILIDI
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		IReadOnlyList<LPCJDAGBEFA> IPGPDLBMPGG
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		int BMDDGONEGAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface NJCLDGOIBLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<DKEDBFBEBCD> DBALHDALEEL();
	}

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class JOAJHHEOCKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public Predicate<BMOKIAFEMCO> predicate;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public JOAJHHEOCKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6FF54A0", Offset = "0x6FF42A0", VA = "0x186FF54A0")]
		internal bool FKIFLJMFEAL(BMOKIAFEMCO challenge)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class FNAKALMJHHB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public JNCCKKGNCPL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private DKEDBFBEBCD <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private IEnumerator<BMOKIAFEMCO> <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private BMOKIAFEMCO <challenge>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private TaskAwaiter<DKEDBFBEBCD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public FNAKALMJHHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6FF3E00", Offset = "0x6FF2C00", VA = "0x186FF3E00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly FICMPGNPIIF PKFPPGNGNFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly NJCLDGOIBLN KOIJBKJBGIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private DKEDBFBEBCD JFNNLICKHBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private IReadOnlyList<LPCJDAGBEFA> EJBABFEOLLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private IEnumerable<BMOKIAFEMCO> OPHNOACILMJ;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool JIMBFKKOCCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6FF4E50", Offset = "0x6FF3C50", VA = "0x186FF4E50", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool PDBPMLPDICE
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6FF4B70", Offset = "0x6FF3970", VA = "0x186FF4B70", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool LOHMICAAJGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6FF47F0", Offset = "0x6FF35F0", VA = "0x186FF47F0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IReadOnlyList<LPCJDAGBEFA> IPGPDLBMPGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x81B570", Offset = "0x81A370", VA = "0x18081B570", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<BMOKIAFEMCO> JBFEEDLOBJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6FF5240", Offset = "0x6FF4040", VA = "0x186FF5240", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6FF4390", Offset = "0x6FF3190", VA = "0x186FF4390", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6FF52E0", Offset = "0x6FF40E0", VA = "0x186FF52E0")]
	[Preserve]
	public JNCCKKGNCPL([NotNull][DNPFPOCMFCA(null)] FICMPGNPIIF PKFPPGNGNFO, [NotNull][DNPFPOCMFCA(null)] NJCLDGOIBLN KOIJBKJBGIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6FF4EA0", Offset = "0x6FF3CA0", VA = "0x186FF4EA0", Slot = "12")]
	public IEnumerable<BMOKIAFEMCO> LFBLDGBNFFE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6FF50B0", Offset = "0x6FF3EB0", VA = "0x186FF50B0", Slot = "10")]
	public IEnumerable<BMOKIAFEMCO> MHBCKIDDPHP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6FF46F0", Offset = "0x6FF34F0", VA = "0x186FF46F0", Slot = "9")]
	public BMOKIAFEMCO EFPJPCBCOAC(Predicate<BMOKIAFEMCO> MIMEEOMMODG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6FF4D70", Offset = "0x6FF3B70", VA = "0x186FF4D70")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(FNAKALMJHHB))]
	private void KGPLMEKFHAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6FF4430", Offset = "0x6FF3230", VA = "0x186FF4430")]
	private void BINIDCOGIHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6FF4920", Offset = "0x6FF3720", VA = "0x186FF4920")]
	private void HJFMAMGOHLA(BMOKIAFEMCO AEKGBJAEMNK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface BMOKIAFEMCO
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public interface ECCJOHIGLCE
	{
		[Cpp2IlInjected.Token(Token = "0x17000011")]
		Sprite FFCBMNKHBKN
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	int GPMBNBBIPFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool DPJCJMGKKMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	string KLJJLLIEMIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	FFGJNDCLKAO NMCPKDGHEKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	string GIPIJLGAENG
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	Texture2D HIODNDHCAPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	Sprite IIDBAOHJHKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool KEPIONDNGIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	bool AFDJCBGMJPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<BMOKIAFEMCO> FCBBGALPCFP;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "12")]
	NONMCJIBNII CCMMPOEEBME();

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "13")]
	AHPDIJDJLKD<bool> DPGFEJNIAPP();
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface ICNAJEFDIFC
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool JIMBFKKOCCM
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	bool PDBPMLPDICE
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool LOHMICAAJGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action<BMOKIAFEMCO> JBFEEDLOBJN;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "5")]
	BMOKIAFEMCO EFPJPCBCOAC(Predicate<BMOKIAFEMCO> MIMEEOMMODG);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "6")]
	IEnumerable<BMOKIAFEMCO> MHBCKIDDPHP();
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class FFGJNDCLKAO : ReadOnlyCollection<BMOKIAFEMCO>, LPCJDAGBEFA, IReadOnlyCollection<BMOKIAFEMCO>, IEnumerable<BMOKIAFEMCO>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public string KGBBPCBIOMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8FAD40", Offset = "0x8F9B40", VA = "0x1808FAD40", Slot = "35")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public Sprite IIDBAOHJHKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x81B570", Offset = "0x81A370", VA = "0x18081B570", Slot = "36")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6FF3D20", Offset = "0x6FF2B20", VA = "0x186FF3D20")]
	public FFGJNDCLKAO([NotNull] string PPPOJKMOIGD, [NotNull] IList<BMOKIAFEMCO> IPGDFFNNILJ, [NotNull] Sprite EINKAKPADCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6FF3BE0", Offset = "0x6FF29E0", VA = "0x186FF3BE0", Slot = "37")]
	public bool MKIGJBDBJOK(BMOKIAFEMCO AEKGBJAEMNK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface LPCJDAGBEFA : IReadOnlyCollection<BMOKIAFEMCO>, IEnumerable<BMOKIAFEMCO>, IEnumerable
{
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface OMIDDOIIFDC
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool PGMCFEFELIA
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action JHAHHJBJBNH;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event Action CEEDAKACLNJ;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PKHKGPNOICB();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BHDBKCJGJGF();
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public enum JKAILMBIAHO
{
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	Mobile,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	Screens,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	VR
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class OAJFMOOLIFJ : OMIDDOIIFDC
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public interface LOEELEFOOIL
	{
		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		int GPIKGIIAKHE
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public interface MHLFNKBPHIM
	{
		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		int JFAKHEPAHDE
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly MHLFNKBPHIM NKCEJINGAEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly ICNAJEFDIFC NKANKALCGGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly int CIHPKDNKHIK;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	private int MIMHPECFFBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6FF5850", Offset = "0x6FF4650", VA = "0x186FF5850")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool PGMCFEFELIA
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6FF5720", Offset = "0x6FF4520", VA = "0x186FF5720", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action JHAHHJBJBNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6FF55E0", Offset = "0x6FF43E0", VA = "0x186FF55E0", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6FF57B0", Offset = "0x6FF45B0", VA = "0x186FF57B0", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action CEEDAKACLNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6FF5680", Offset = "0x6FF4480", VA = "0x186FF5680", Slot = "9")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6FF5970", Offset = "0x6FF4770", VA = "0x186FF5970", Slot = "10")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6FF5A10", Offset = "0x6FF4810", VA = "0x186FF5A10")]
	[Preserve]
	public OAJFMOOLIFJ([NotNull][DNPFPOCMFCA(null)] LOEELEFOOIL MLIOOLHOHEN, [NotNull][DNPFPOCMFCA(null)] MHLFNKBPHIM NKCEJINGAEK, [NotNull][DNPFPOCMFCA(null)] ICNAJEFDIFC NKANKALCGGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6FF58A0", Offset = "0x6FF46A0", VA = "0x186FF58A0", Slot = "5")]
	public void PKHKGPNOICB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6FF5500", Offset = "0x6FF4300", VA = "0x186FF5500", Slot = "6")]
	public void BHDBKCJGJGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface LPNKHHPGGCJ
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JKAILMBIAHO ONEINIHOGNN();
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface FICMPGNPIIF
{
	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool CAJBHPENAEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool OFDGEHLGABE
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event Action BMCPJOINPLN;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action BPGLBAILJAB;
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
