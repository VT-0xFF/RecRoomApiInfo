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
public class JMDCBHLOECL : FCNOGOLFHJL
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface HCHPIJFLNLO
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		IEnumerable<POJKGKOIOJL> OHMAFBHGNGM
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		IReadOnlyList<AIELHKHKDGL> OKHBHGPIKNO
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		int ELFOEIAKCJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface KNBKNFHJPGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<HCHPIJFLNLO> JDFKLKBLPBN();
	}

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class KKPCNDLKDMF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public Predicate<POJKGKOIOJL> predicate;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public KKPCNDLKDMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x70EF2F0", Offset = "0x70EE4F0", VA = "0x1870EF2F0")]
		internal bool JOFBJAINOEE(POJKGKOIOJL challenge)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class DLOPFPJFDIH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public JMDCBHLOECL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private HCHPIJFLNLO <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private IEnumerator<POJKGKOIOJL> <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private POJKGKOIOJL <challenge>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private TaskAwaiter<HCHPIJFLNLO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public DLOPFPJFDIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x70ED3D0", Offset = "0x70EC5D0", VA = "0x1870ED3D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly FLECGHHBGPK BKBLEJHNGHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly KNBKNFHJPGH DFHAJDGPMFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private HCHPIJFLNLO GOBAAJBCACG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private IReadOnlyList<AIELHKHKDGL> AEMMABCCDOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private IEnumerable<POJKGKOIOJL> CAHMDLLJDEG;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool GBKDCFEOMCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x70EE430", Offset = "0x70ED630", VA = "0x1870EE430", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool HECMGEEHOAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x70EE730", Offset = "0x70ED930", VA = "0x1870EE730", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool GLILHAPALII
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x70EEA10", Offset = "0x70EDC10", VA = "0x1870EEA10", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IReadOnlyList<AIELHKHKDGL> OKHBHGPIKNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x82A5F0", Offset = "0x8297F0", VA = "0x18082A5F0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<POJKGKOIOJL> BGIBBIINNNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x70EEE00", Offset = "0x70EE000", VA = "0x1870EEE00", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x70EE690", Offset = "0x70ED890", VA = "0x1870EE690", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x70EF130", Offset = "0x70EE330", VA = "0x1870EF130")]
	[Preserve]
	public JMDCBHLOECL([NotNull][IDNKOMINBGM(null)] FLECGHHBGPK BKBLEJHNGHC, [NotNull][IDNKOMINBGM(null)] KNBKNFHJPGH DFHAJDGPMFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x70EE480", Offset = "0x70ED680", VA = "0x1870EE480", Slot = "12")]
	public IEnumerable<POJKGKOIOJL> DIHGMPIFLLP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x70EEFA0", Offset = "0x70EE1A0", VA = "0x1870EEFA0", Slot = "10")]
	public IEnumerable<POJKGKOIOJL> NOMLJBDCFGM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x70EEEA0", Offset = "0x70EE0A0", VA = "0x1870EEEA0", Slot = "9")]
	public POJKGKOIOJL NOJDCKAINLE(Predicate<POJKGKOIOJL> EPCCIGFNMOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x70EE930", Offset = "0x70EDB30", VA = "0x1870EE930")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DLOPFPJFDIH))]
	private void MIIOJNGIJIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x70EEB40", Offset = "0x70EDD40", VA = "0x1870EEB40")]
	private void NDKEGGIKEDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x70EE1F0", Offset = "0x70ED3F0", VA = "0x1870EE1F0")]
	private void AHGLMPNBMLB(POJKGKOIOJL CPGLDAMAJMA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface POJKGKOIOJL
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public interface MDOHDPLKICA
	{
		[Cpp2IlInjected.Token(Token = "0x17000011")]
		Sprite PFHDGDHLJAG
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	int MCHAHIBGMJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool FHFDNOGINBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	string NELILPDIEDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	HNAAFAFBHJB DGACPBCCJIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	string FBNILOOKPLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	Texture2D NIODHDFJLOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	Sprite JOEMOGNLBGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool HMJJJJFHPHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	bool NBCMKFJCLKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<POJKGKOIOJL> CKOMDFLBGBF;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "12")]
	OOPPNGPPPLE OHBLCNEOKJJ();

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "13")]
	NHJDNADPIAN<bool> FEDGBHOKDBF();
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface FCNOGOLFHJL
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool GBKDCFEOMCO
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	bool HECMGEEHOAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool GLILHAPALII
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action<POJKGKOIOJL> BGIBBIINNNN;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "5")]
	POJKGKOIOJL NOJDCKAINLE(Predicate<POJKGKOIOJL> EPCCIGFNMOG);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "6")]
	IEnumerable<POJKGKOIOJL> NOMLJBDCFGM();
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class HNAAFAFBHJB : ReadOnlyCollection<POJKGKOIOJL>, AIELHKHKDGL, IReadOnlyCollection<POJKGKOIOJL>, IEnumerable<POJKGKOIOJL>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public string AOPINHAKJMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8D7C00", Offset = "0x8D6E00", VA = "0x1808D7C00", Slot = "35")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public Sprite JOEMOGNLBGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x82A5F0", Offset = "0x8297F0", VA = "0x18082A5F0", Slot = "36")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x70EDAB0", Offset = "0x70ECCB0", VA = "0x1870EDAB0")]
	public HNAAFAFBHJB([NotNull] string PCKMHBLNCII, [NotNull] IList<POJKGKOIOJL> IEKCFDAIBOJ, [NotNull] Sprite LGKMMMNLKJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x70ED970", Offset = "0x70ECB70", VA = "0x1870ED970", Slot = "37")]
	public bool PHAJFJAPDJP(POJKGKOIOJL CPGLDAMAJMA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface AIELHKHKDGL : IReadOnlyCollection<POJKGKOIOJL>, IEnumerable<POJKGKOIOJL>, IEnumerable
{
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface AGOCJMOHDLL
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool FJFJLELEDDP
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action BJIPGAIINAE;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event Action CIAKLLDBDEL;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GILIHFLHIOI();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JNNFHHDJCCE();
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public enum PKEENOKEAAC
{
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	Mobile,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	Screens,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	VR
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class JFHHEHGKIHG : AGOCJMOHDLL
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public interface HCBDGPPKHKN
	{
		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		int ECOBKNIDIFD
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public interface PIAANOLHNFF
	{
		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		int EBKEKDCIFOA
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
	private readonly PIAANOLHNFF EEJAEPEDIEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly FCNOGOLFHJL BNIFHHJMEGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly int GDCJOJKNOGH;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	private int JMCKGCCLJIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x70EDE00", Offset = "0x70ED000", VA = "0x1870EDE00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool FJFJLELEDDP
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x70EDC30", Offset = "0x70ECE30", VA = "0x1870EDC30", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action BJIPGAIINAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x70EDCC0", Offset = "0x70ECEC0", VA = "0x1870EDCC0", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x70EDD60", Offset = "0x70ECF60", VA = "0x1870EDD60", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action CIAKLLDBDEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x70EE000", Offset = "0x70ED200", VA = "0x1870EE000", Slot = "9")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x70EDB90", Offset = "0x70ECD90", VA = "0x1870EDB90", Slot = "10")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x70EE0A0", Offset = "0x70ED2A0", VA = "0x1870EE0A0")]
	[Preserve]
	public JFHHEHGKIHG([NotNull][IDNKOMINBGM(null)] HCBDGPPKHKN GPNCDFDBEDA, [NotNull][IDNKOMINBGM(null)] PIAANOLHNFF EEJAEPEDIEB, [NotNull][IDNKOMINBGM(null)] FCNOGOLFHJL BNIFHHJMEGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x70EDE50", Offset = "0x70ED050", VA = "0x1870EDE50", Slot = "5")]
	public void GILIHFLHIOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x70EDF20", Offset = "0x70ED120", VA = "0x1870EDF20", Slot = "6")]
	public void JNNFHHDJCCE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface FEKBOLLHFEM
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PKEENOKEAAC NLAFNCPJKOP();
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface FLECGHHBGPK
{
	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool NGGDPEJHOEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool LNPGPKENINC
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event Action JJPIMGJPFIB;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action GGCDGKCANNH;
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
