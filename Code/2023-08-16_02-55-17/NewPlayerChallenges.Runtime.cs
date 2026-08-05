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
public class HJLAGJCAPGJ : MGNLMOMPJDC
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface NOOEIJGKJJF
	{
		[Cpp2IlInjected.Token(Token = "0x17000008")]
		IEnumerable<PPOFNENNLPI> MBJNNOKFDDP
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		IReadOnlyList<LHAJMLPOPAN> BNIHFAKPBEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		int LFIPJGKOADL
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface LEJPGAGPDOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<NOOEIJGKJJF> NHKKMFJOEHM(MGNLMOMPJDC MJAMCOFMONB);
	}

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class EABGCAFLIAE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public Predicate<PPOFNENNLPI> predicate;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public EABGCAFLIAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6F44F10", Offset = "0x6F44110", VA = "0x186F44F10")]
		internal bool OALIEDIDAEF(PPOFNENNLPI challenge)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class GJGKGOOCBCA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public HJLAGJCAPGJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private NOOEIJGKJJF <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private IEnumerator<PPOFNENNLPI> <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private PPOFNENNLPI <challenge>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private TaskAwaiter<NOOEIJGKJJF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public GJGKGOOCBCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6F44F70", Offset = "0x6F44170", VA = "0x186F44F70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly FMLNEDEBPLC PKKLBLANDIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly LEJPGAGPDOG KGDLKOPAMKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private NOOEIJGKJJF EBBJLGDAAFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private IReadOnlyList<LHAJMLPOPAN> JEIJENCIHFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private IEnumerable<PPOFNENNLPI> LGCDCBCGGGF;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool ANLELIINLLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6F45EF0", Offset = "0x6F450F0", VA = "0x186F45EF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool CAOPAGOGDEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6F461F0", Offset = "0x6F453F0", VA = "0x186F461F0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool LAJMECLPLCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6F46590", Offset = "0x6F45790", VA = "0x186F46590", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool CLIJJBJBPBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6F45530", Offset = "0x6F44730", VA = "0x186F45530", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool KLBPMLKMACE
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6F46280", Offset = "0x6F45480", VA = "0x186F46280", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int PLBDCEOKJJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6F460C0", Offset = "0x6F452C0", VA = "0x186F460C0", Slot = "8")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public IReadOnlyList<LHAJMLPOPAN> BNIHFAKPBEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8B1CC0", Offset = "0x8B0EC0", VA = "0x1808B1CC0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<PPOFNENNLPI> PKLBGHHKEKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6F465F0", Offset = "0x6F457F0", VA = "0x186F465F0", Slot = "9")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6F46020", Offset = "0x6F45220", VA = "0x186F46020", Slot = "10")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6F46690", Offset = "0x6F45890", VA = "0x186F46690")]
	[Preserve]
	public HJLAGJCAPGJ([NotNull][NDGONEEEGIA(null)] FMLNEDEBPLC PKKLBLANDIM, [NotNull][NDGONEEEGIA(null)] LEJPGAGPDOG KGDLKOPAMKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6F45660", Offset = "0x6F44860", VA = "0x186F45660", Slot = "14")]
	public IEnumerable<PPOFNENNLPI> BKFAOKHEKHG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6F463B0", Offset = "0x6F455B0", VA = "0x186F463B0", Slot = "12")]
	public IEnumerable<PPOFNENNLPI> MMMBGGFIGGA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6F45B10", Offset = "0x6F44D10", VA = "0x186F45B10", Slot = "11")]
	public PPOFNENNLPI DNBLPFCCCKN(Predicate<PPOFNENNLPI> MCOBJMPEFEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6F45F40", Offset = "0x6F45140", VA = "0x186F45F40")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(GJGKGOOCBCA))]
	private void GONKLMIGAIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6F45C60", Offset = "0x6F44E60", VA = "0x186F45C60")]
	private void DOPJIOMNKIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6F458D0", Offset = "0x6F44AD0", VA = "0x186F458D0")]
	private void CHPJHCNDBKC(PPOFNENNLPI KFKCEALDPBB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface PPOFNENNLPI
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public interface EGOKLOJENKA
	{
		[Cpp2IlInjected.Token(Token = "0x17000015")]
		Sprite GHDJLDEANPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	int LGLKBNOIMEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool KKOJJMAABJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	string JNLFDIPLAMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	NCJJKPEJMDD BDBHCDOCIJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	string JLGKEANHKBB
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	Texture2D MNAPAKDGFOP
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	Sprite AFCBKPDMCAB
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	ILHOFJKPAFK GAIEPMICGLL
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	bool NHHAGFLLOBO
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool JAPNBMCGLHC
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<PPOFNENNLPI> EBBHNKFJEHA;

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "13")]
	GIOBGNHJLID KAKDBEPLHOA();

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "14")]
	OOMFLHAHLDK<bool> PNDACJMILGF();
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface MGNLMOMPJDC
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool CAOPAGOGDEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool LAJMECLPLCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool CLIJJBJBPBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool KLBPMLKMACE
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	int PLBDCEOKJJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action<PPOFNENNLPI> PKLBGHHKEKJ;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	PPOFNENNLPI DNBLPFCCCKN(Predicate<PPOFNENNLPI> MCOBJMPEFEM);

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IEnumerable<PPOFNENNLPI> MMMBGGFIGGA();
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class NCJJKPEJMDD : ReadOnlyCollection<PPOFNENNLPI>, LHAJMLPOPAN, IReadOnlyCollection<PPOFNENNLPI>, IEnumerable<PPOFNENNLPI>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public string GCLEOCLMMPM
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x7EBAE0", Offset = "0x7EACE0", VA = "0x1807EBAE0", Slot = "35")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public Sprite AFCBKPDMCAB
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8B1CC0", Offset = "0x8B0EC0", VA = "0x1808B1CC0", Slot = "36")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6F46FF0", Offset = "0x6F461F0", VA = "0x186F46FF0")]
	public NCJJKPEJMDD([NotNull] string JPKENOAMLIN, [NotNull] IList<PPOFNENNLPI> MLEOGHHEJOI, [NotNull] Sprite HPHGGBLBNBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6F46EB0", Offset = "0x6F460B0", VA = "0x186F46EB0", Slot = "37")]
	public bool AONINFIBCEF(PPOFNENNLPI KFKCEALDPBB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface LHAJMLPOPAN : IReadOnlyCollection<PPOFNENNLPI>, IEnumerable<PPOFNENNLPI>, IEnumerable
{
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface PBBGOPGMIID
{
	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool EGGMGDMBKFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action DBMIAOJOBPB;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event Action KABBPLPNNDB;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MHGFIEBJICN();

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NJLEAMNPHCM();
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public enum MJPNHKDKHCK
{
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	Mobile,
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	Screens,
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	VR
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class KMDFCDOIGHD : PBBGOPGMIID
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public interface BJLKEDOHGLD
	{
		[Cpp2IlInjected.Token(Token = "0x17000020")]
		int GLMABKKGNCM
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public interface AEOBIHLLEHG
	{
		[Cpp2IlInjected.Token(Token = "0x17000021")]
		int ICJOGMEBPNI
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
	private readonly AEOBIHLLEHG DGGHACCBDLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly MGNLMOMPJDC MJAMCOFMONB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly int KKIDAGDJCFK;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	private int HBDLNCHNEPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6F46AC0", Offset = "0x6F45CC0", VA = "0x186F46AC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool EGGMGDMBKFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6F468F0", Offset = "0x6F45AF0", VA = "0x186F468F0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action DBMIAOJOBPB
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6F46B10", Offset = "0x6F45D10", VA = "0x186F46B10", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6F46850", Offset = "0x6F45A50", VA = "0x186F46850", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action KABBPLPNNDB
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6F46980", Offset = "0x6F45B80", VA = "0x186F46980", Slot = "9")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6F46A20", Offset = "0x6F45C20", VA = "0x186F46A20", Slot = "10")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6F46D60", Offset = "0x6F45F60", VA = "0x186F46D60")]
	[Preserve]
	public KMDFCDOIGHD([NotNull][NDGONEEEGIA(null)] BJLKEDOHGLD BCAJAOGPNBC, [NotNull][NDGONEEEGIA(null)] AEOBIHLLEHG DGGHACCBDLA, [NotNull][NDGONEEEGIA(null)] MGNLMOMPJDC MJAMCOFMONB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6F46BB0", Offset = "0x6F45DB0", VA = "0x186F46BB0", Slot = "5")]
	public void MHGFIEBJICN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6F46C80", Offset = "0x6F45E80", VA = "0x186F46C80", Slot = "6")]
	public void NJLEAMNPHCM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface KEBEOKICIAB
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MJPNHKDKHCK LECLOPOOABA();
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface FMLNEDEBPLC
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool BMJHJNCEDBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	bool DGAODBJFOIB
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool ANLELIINLLP
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	TimeSpan LKJLHGPLFBD
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event Action JGICLHHEHIF;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action GPIGIGNGLAE;
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
