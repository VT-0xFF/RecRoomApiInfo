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
public class BMKFENBHLHG : MJCKKMLEMNE
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface BIGJOPBMJEN
	{
		[Cpp2IlInjected.Token(Token = "0x17000007")]
		IEnumerable<GMMPHJAGMAL> PFCLDHAIKOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		IReadOnlyList<FAPFMKDFEJP> MLCAFJBBHFB
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		int NHHAOFCFLNE
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface MGEAFEBFNBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<BIGJOPBMJEN> BBHDFJHBOLA();
	}

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class EAFDEEGDKJG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public Predicate<GMMPHJAGMAL> predicate;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public EAFDEEGDKJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7296B70", Offset = "0x7295B70", VA = "0x187296B70")]
		internal bool BGKALIBAMOP(GMMPHJAGMAL challenge)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class KEKPAHDAFMH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public BMKFENBHLHG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private BIGJOPBMJEN <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private IEnumerator<GMMPHJAGMAL> <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private GMMPHJAGMAL <challenge>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private TaskAwaiter<BIGJOPBMJEN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public KEKPAHDAFMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7296DF0", Offset = "0x7295DF0", VA = "0x187296DF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly BKJAFCGMIAF MPMJELJIOGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly MGEAFEBFNBE DHKBHGHKFMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private BIGJOPBMJEN ELIOKEFCLMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private IReadOnlyList<FAPFMKDFEJP> LGPFJBCPLBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private IEnumerable<GMMPHJAGMAL> CKFOBMCAPMJ;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool DNCPOPHIONI
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7295CE0", Offset = "0x7294CE0", VA = "0x187295CE0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool CIBGHPHMBFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7296230", Offset = "0x7295230", VA = "0x187296230", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool NGAHGLEGNBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7296100", Offset = "0x7295100", VA = "0x187296100", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool BJMCLKNHMPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7296660", Offset = "0x7295660", VA = "0x187296660", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int BCCBOBKPPFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7296430", Offset = "0x7295430", VA = "0x187296430", Slot = "8")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public IReadOnlyList<FAPFMKDFEJP> MLCAFJBBHFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x91FD50", Offset = "0x91ED50", VA = "0x18091FD50", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<GMMPHJAGMAL> NNNEPJALBPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7296870", Offset = "0x7295870", VA = "0x187296870", Slot = "9")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7296910", Offset = "0x7295910", VA = "0x187296910", Slot = "10")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x72969B0", Offset = "0x72959B0", VA = "0x1872969B0")]
	[Preserve]
	public BMKFENBHLHG([NotNull][KMDNJCFAMOJ(null)] BKJAFCGMIAF MPMJELJIOGJ, [NotNull][KMDNJCFAMOJ(null)] MGEAFEBFNBE DHKBHGHKFMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7295810", Offset = "0x7294810", VA = "0x187295810", Slot = "14")]
	public IEnumerable<GMMPHJAGMAL> ADMHHJNNKPI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7295D30", Offset = "0x7294D30", VA = "0x187295D30", Slot = "12")]
	public IEnumerable<GMMPHJAGMAL> EMEAKOCMJEG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7296560", Offset = "0x7295560", VA = "0x187296560", Slot = "11")]
	public GMMPHJAGMAL KDLACHHINLO(Predicate<GMMPHJAGMAL> EOOJLCJHMJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7296790", Offset = "0x7295790", VA = "0x187296790")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(KEKPAHDAFMH))]
	private void LFPOMGOPNJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7295A20", Offset = "0x7294A20", VA = "0x187295A20")]
	private void BECNKFOFGIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7295EC0", Offset = "0x7294EC0", VA = "0x187295EC0")]
	private void FPHJFPBNPCE(GMMPHJAGMAL KFAIKLEOPNB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface GMMPHJAGMAL
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public interface ENAPOHGNDCJ
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		Sprite MHGKOCLHDAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	int LCACJEDBCEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool PHLFECMHCBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	string GBCALCPDECA
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	FODKALEOBHB FMDIEMMLOKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	string NDCAMHCDOCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	Texture2D BOEIFDJLIFF
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	Sprite KADLOAGKDOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	FEKHENMHGPA OCAHHABJLKB
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool AHFLLBNAIPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	bool KMMILJAOLBI
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<GMMPHJAGMAL> GCAAICDKGDP;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "13")]
	FHJJKILLDME AMHEHLDBAHE();

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "14")]
	LJAJHHFEMAM<bool> KGAENLAIEFG();
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface MJCKKMLEMNE
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool DNCPOPHIONI
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool CIBGHPHMBFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool NGAHGLEGNBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool BJMCLKNHMPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	int BCCBOBKPPFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action<GMMPHJAGMAL> NNNEPJALBPI;

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "7")]
	GMMPHJAGMAL KDLACHHINLO(Predicate<GMMPHJAGMAL> EOOJLCJHMJA);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IEnumerable<GMMPHJAGMAL> EMEAKOCMJEG();
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class FODKALEOBHB : ReadOnlyCollection<GMMPHJAGMAL>, FAPFMKDFEJP, IReadOnlyCollection<GMMPHJAGMAL>, IEnumerable<GMMPHJAGMAL>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public string EDEDJHKMHBI
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x91FD40", Offset = "0x91ED40", VA = "0x18091FD40", Slot = "35")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public Sprite KADLOAGKDOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x91FD50", Offset = "0x91ED50", VA = "0x18091FD50", Slot = "36")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7296D10", Offset = "0x7295D10", VA = "0x187296D10")]
	public FODKALEOBHB([NotNull] string OKONKHNEMOO, [NotNull] IList<GMMPHJAGMAL> IHMGNIOOIJN, [NotNull] Sprite HJEPGNPFOCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7296BD0", Offset = "0x7295BD0", VA = "0x187296BD0", Slot = "37")]
	public bool FPDPEIINCKA(GMMPHJAGMAL KFAIKLEOPNB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface FAPFMKDFEJP : IReadOnlyCollection<GMMPHJAGMAL>, IEnumerable<GMMPHJAGMAL>, IEnumerable
{
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface PJEACLFNIJF
{
	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool KNCNEKIFEGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action NLNKMGJKFEB;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event Action EGODNLLCNBA;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FCNEAOLDKOO();

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NINILIABFMP();
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public enum CJCFIPGABLL
{
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	Mobile,
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	Screens,
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	VR
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class AAPJCHPJONN : PJEACLFNIJF
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public interface OKGACCEBFKI
	{
		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		int KJGJAHIEOLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public interface BHPJEKMABBO
	{
		[Cpp2IlInjected.Token(Token = "0x17000020")]
		int GMIAIDCIKKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly BHPJEKMABBO BBBJFKNPFFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly MJCKKMLEMNE FAGNMOFDCBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly int FBCDICMBOJC;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private int DIKCLEFBGPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x72951B0", Offset = "0x72941B0", VA = "0x1872951B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool KNCNEKIFEGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x7295200", Offset = "0x7294200", VA = "0x187295200", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action NLNKMGJKFEB
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7295290", Offset = "0x7294290", VA = "0x187295290", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x7295540", Offset = "0x7294540", VA = "0x187295540", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action EGODNLLCNBA
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7295400", Offset = "0x7294400", VA = "0x187295400", Slot = "9")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x72954A0", Offset = "0x72944A0", VA = "0x1872954A0", Slot = "10")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x72956C0", Offset = "0x72946C0", VA = "0x1872956C0")]
	[Preserve]
	public AAPJCHPJONN([NotNull][KMDNJCFAMOJ(null)] OKGACCEBFKI ANOHMKLJKNF, [NotNull][KMDNJCFAMOJ(null)] BHPJEKMABBO BBBJFKNPFFO, [NotNull][KMDNJCFAMOJ(null)] MJCKKMLEMNE FAGNMOFDCBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7295330", Offset = "0x7294330", VA = "0x187295330", Slot = "5")]
	public void FCNEAOLDKOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x72955E0", Offset = "0x72945E0", VA = "0x1872955E0", Slot = "6")]
	public void NINILIABFMP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface MGHHENKHPLH
{
	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CJCFIPGABLL GNJCJIDGDBM();
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface BKJAFCGMIAF
{
	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool GKPDPDPHIIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool IMANKOHILMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	TimeSpan DGAHABCJAJP
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event Action ECJJAAFCANJ;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action MGFAJAEEPMB;
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
