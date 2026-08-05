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
public class IELDENEJDHN : ACJIOEEBMBJ
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface ABJDIOKJPPC
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		IEnumerable<ABMPFGKCGAM> ECAJALGDBLN
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		IReadOnlyList<PONPJNGKNCP> JKACFJEMPOD
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		int IKGNKDFFABG
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface NADCEEFANIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<ABJDIOKJPPC> MNPKEBFEMKJ();
	}

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class ONFLPDEFOKD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public Predicate<ABMPFGKCGAM> predicate;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public ONFLPDEFOKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6FCDAF0", Offset = "0x6FCCEF0", VA = "0x186FCDAF0")]
		internal bool JJPCCCLACMH(ABMPFGKCGAM challenge)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class JHHCEKDGODC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public IELDENEJDHN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private ABJDIOKJPPC <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private IEnumerator<ABMPFGKCGAM> <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private ABMPFGKCGAM <challenge>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private TaskAwaiter<ABJDIOKJPPC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public JHHCEKDGODC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6FCCF00", Offset = "0x6FCC300", VA = "0x186FCCF00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly KHBBDIPFMIC MJHENDPKAOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly NADCEEFANIB CLKEBPEJHLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private ABJDIOKJPPC CMCPMNIPCGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private IReadOnlyList<PONPJNGKNCP> IKGAPCDKEEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private IEnumerable<ABMPFGKCGAM> JNHDFNEJLAE;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool LAICLFKAMIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6FCC7E0", Offset = "0x6FCBBE0", VA = "0x186FCC7E0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool HOHDGMLLHGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6FCCB40", Offset = "0x6FCBF40", VA = "0x186FCCB40", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool DGJLGLBAJBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6FCC910", Offset = "0x6FCBD10", VA = "0x186FCC910", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IReadOnlyList<PONPJNGKNCP> JKACFJEMPOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7F8B00", Offset = "0x7F7F00", VA = "0x1807F8B00", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<ABMPFGKCGAM> FJAJHLKNCIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6FCBF80", Offset = "0x6FCB380", VA = "0x186FCBF80", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6FCC480", Offset = "0x6FCB880", VA = "0x186FCC480", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6FCCD40", Offset = "0x6FCC140", VA = "0x186FCCD40")]
	[Preserve]
	public IELDENEJDHN([NotNull][KFMNGACPMHN(null)] KHBBDIPFMIC MJHENDPKAOK, [NotNull][KFMNGACPMHN(null)] NADCEEFANIB CLKEBPEJHLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6FCC270", Offset = "0x6FCB670", VA = "0x186FCC270", Slot = "12")]
	public IEnumerable<ABMPFGKCGAM> HHIEFKDNPBP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6FCBDF0", Offset = "0x6FCB1F0", VA = "0x186FCBDF0", Slot = "10")]
	public IEnumerable<ABMPFGKCGAM> AOLIFMBLOON()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6FCCA40", Offset = "0x6FCBE40", VA = "0x186FCCA40", Slot = "9")]
	public ABMPFGKCGAM PDPICLNOCJN(Predicate<ABMPFGKCGAM> EBNIKPBJGHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6FCC830", Offset = "0x6FCBC30", VA = "0x186FCC830")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JHHCEKDGODC))]
	private void NPNHGPLADJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6FCC520", Offset = "0x6FCB920", VA = "0x186FCC520")]
	private void MGHDDNMJGFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6FCC020", Offset = "0x6FCB420", VA = "0x186FCC020")]
	private void HCABHHDKAIA(ABMPFGKCGAM GEEKGLGLELG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface ABMPFGKCGAM
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public interface KBJNICCAMHB
	{
		[Cpp2IlInjected.Token(Token = "0x17000011")]
		Sprite FBLDDJFMFKM
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	int KFAAADEAEOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool BHIAALBPDMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	string MMFJONPJLOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	ACBDBALALOP BMGOEMGIHEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	string DBPMKEJJAKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	Texture2D LHHBKDKCLIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	Sprite LONJDCAADHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool HGMKIFELGCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	bool ECCICFEDGAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<ABMPFGKCGAM> AJDOCNKPLDI;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "12")]
	FKADHPEOOEO DLLCKAALLLP();

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "13")]
	global::CBFHNKNAJIN<bool> CBCOFNLIDOI();
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface ACJIOEEBMBJ
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool LAICLFKAMIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	bool HOHDGMLLHGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool DGJLGLBAJBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action<ABMPFGKCGAM> FJAJHLKNCIM;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "5")]
	ABMPFGKCGAM PDPICLNOCJN(Predicate<ABMPFGKCGAM> EBNIKPBJGHC);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "6")]
	IEnumerable<ABMPFGKCGAM> AOLIFMBLOON();
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class ACBDBALALOP : ReadOnlyCollection<ABMPFGKCGAM>, PONPJNGKNCP, IReadOnlyCollection<ABMPFGKCGAM>, IEnumerable<ABMPFGKCGAM>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public string EKGMLAPMPFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x855AE0", Offset = "0x854EE0", VA = "0x180855AE0", Slot = "35")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public Sprite LONJDCAADHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7F8B00", Offset = "0x7F7F00", VA = "0x1807F8B00", Slot = "36")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6FCBD10", Offset = "0x6FCB110", VA = "0x186FCBD10")]
	public ACBDBALALOP([NotNull] string LMAOKJPAKEM, [NotNull] IList<ABMPFGKCGAM> FGINDFDIDLG, [NotNull] Sprite IHFMGONDFJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6FCBBD0", Offset = "0x6FCAFD0", VA = "0x186FCBBD0", Slot = "37")]
	public bool NOMDCCLBOIB(ABMPFGKCGAM GEEKGLGLELG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface PONPJNGKNCP : IReadOnlyCollection<ABMPFGKCGAM>, IEnumerable<ABMPFGKCGAM>, IEnumerable
{
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface KNOHKJCEAID
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool GBBDBOOMHOK
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action BJLPAKBOBJP;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event Action IDDENBBGANC;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void POPMKEDECDH();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NAMONBHJOEJ();
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public enum JGPNFLEPFBL
{
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	Mobile,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	Screens,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	VR
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class NOAEDKHKBGO : KNOHKJCEAID
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public interface HLJNIFLMOKF
	{
		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		int AOPBCGJJEMJ
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public interface NDPIFDNLFKJ
	{
		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		int ICCICBKKADE
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
	private readonly NDPIFDNLFKJ KEABJEBDFEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly ACJIOEEBMBJ CNHLINHNGGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly int JLMCPHKOEOL;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	private int DDKLIGOHNKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6FCD7E0", Offset = "0x6FCCBE0", VA = "0x186FCD7E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool GBBDBOOMHOK
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6FCD490", Offset = "0x6FCC890", VA = "0x186FCD490", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action BJLPAKBOBJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6FCD5C0", Offset = "0x6FCC9C0", VA = "0x186FCD5C0", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6FCD660", Offset = "0x6FCCA60", VA = "0x186FCD660", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action IDDENBBGANC
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6FCD830", Offset = "0x6FCCC30", VA = "0x186FCD830", Slot = "9")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6FCD520", Offset = "0x6FCC920", VA = "0x186FCD520", Slot = "10")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6FCD9A0", Offset = "0x6FCCDA0", VA = "0x186FCD9A0")]
	[Preserve]
	public NOAEDKHKBGO([NotNull][KFMNGACPMHN(null)] HLJNIFLMOKF CCDOJJFLLCK, [NotNull][KFMNGACPMHN(null)] NDPIFDNLFKJ KEABJEBDFEL, [NotNull][KFMNGACPMHN(null)] ACJIOEEBMBJ CNHLINHNGGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6FCD8D0", Offset = "0x6FCCCD0", VA = "0x186FCD8D0", Slot = "5")]
	public void POPMKEDECDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6FCD700", Offset = "0x6FCCB00", VA = "0x186FCD700", Slot = "6")]
	public void NAMONBHJOEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface FNPMFCDKMNF
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JGPNFLEPFBL PLCGPNCJALH();
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface KHBBDIPFMIC
{
	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool PLFGLMAJFBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool MCJKKPFNFFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event Action JIPJFIJJMIH;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action POCHGFKIEOP;
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
