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
public class FHDECFCCCKI : JKEAAGLCGBP
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface EFPJGBKLCBP
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		IEnumerable<FMPDDPPOCDE> CCBGGBFGJBH
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		IReadOnlyList<EKKHLMMIDGN> FIIJKLHHJFE
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		int BHAABFOOLLP
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface EGMCEBLFCJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<EFPJGBKLCBP> DDNGJIEMDCJ();
	}

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class OOAJANNHNOJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public Predicate<FMPDDPPOCDE> predicate;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public OOAJANNHNOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6FDC180", Offset = "0x6FDA980", VA = "0x186FDC180")]
		internal bool AJGGDIHDCKC(FMPDDPPOCDE challenge)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class NOGAEMECOCI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public FHDECFCCCKI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private EFPJGBKLCBP <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private IEnumerator<FMPDDPPOCDE> <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private FMPDDPPOCDE <challenge>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private TaskAwaiter<EFPJGBKLCBP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public NOGAEMECOCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6FDBBF0", Offset = "0x6FDA3F0", VA = "0x186FDBBF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly OJHFBMHNBAK NJBPGOHOFNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly EGMCEBLFCJK NMGALIEBJPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private EFPJGBKLCBP ICJFFHPGLBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private IReadOnlyList<EKKHLMMIDGN> KANKGBGHMFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private IEnumerable<FMPDDPPOCDE> IACOFKINEPN;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool IDJGHGCJLFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6FDB900", Offset = "0x6FDA100", VA = "0x186FDB900", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool GPPNEHHGDCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6FDADF0", Offset = "0x6FD95F0", VA = "0x186FDADF0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool CDEBPNMFFNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6FDB7D0", Offset = "0x6FD9FD0", VA = "0x186FDB7D0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IReadOnlyList<EKKHLMMIDGN> FIIJKLHHJFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7F2CE0", Offset = "0x7F14E0", VA = "0x1807F2CE0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<FMPDDPPOCDE> PGIDOOOOFIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6FDB090", Offset = "0x6FD9890", VA = "0x186FDB090", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6FDAFF0", Offset = "0x6FD97F0", VA = "0x186FDAFF0", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6FDBA30", Offset = "0x6FDA230", VA = "0x186FDBA30")]
	[Preserve]
	public FHDECFCCCKI([NotNull][ACEKLAKDMBL(null)] OJHFBMHNBAK NJBPGOHOFNG, [NotNull][ACEKLAKDMBL(null)] EGMCEBLFCJK NMGALIEBJPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6FDABE0", Offset = "0x6FD93E0", VA = "0x186FDABE0", Slot = "12")]
	public IEnumerable<FMPDDPPOCDE> EJMJFCLHENN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6FDB130", Offset = "0x6FD9930", VA = "0x186FDB130", Slot = "10")]
	public IEnumerable<FMPDDPPOCDE> JCAIJEIONAB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6FDAAE0", Offset = "0x6FD92E0", VA = "0x186FDAAE0", Slot = "9")]
	public FMPDDPPOCDE ALIINPGDHFE(Predicate<FMPDDPPOCDE> GKMOGNDGOID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6FDB950", Offset = "0x6FDA150", VA = "0x186FDB950")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(NOGAEMECOCI))]
	private void PFEFGBHIJLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6FDB510", Offset = "0x6FD9D10", VA = "0x186FDB510")]
	private void LGLGFCMPOOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6FDB2C0", Offset = "0x6FD9AC0", VA = "0x186FDB2C0")]
	private void JOHIHKCCOEI(FMPDDPPOCDE LFDCEOOOGKA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface FMPDDPPOCDE
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public interface FLACJBCAFEF
	{
		[Cpp2IlInjected.Token(Token = "0x17000011")]
		Sprite LKPDDJFGIJC
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	int PFFGLFDKNHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool BJBGJBHEHBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	string JAIHBJHBALG
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	FCMLKCJIAOA PIPPPNPGCGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	string HPKGPMAJDAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	Texture2D NEJJBNGMFOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	Sprite MDEALJJGIDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool IAPLCEJKDNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	bool BCIDLILPMOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<FMPDDPPOCDE> OGAPGBOMGJH;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "12")]
	EILHPPDHBHH BCHMADBHFBE();

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "13")]
	global::NBFPPJGKGOH<bool> DOKKLFGMLCN();
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface JKEAAGLCGBP
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool IDJGHGCJLFM
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	bool GPPNEHHGDCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool CDEBPNMFFNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action<FMPDDPPOCDE> PGIDOOOOFIN;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "5")]
	FMPDDPPOCDE ALIINPGDHFE(Predicate<FMPDDPPOCDE> GKMOGNDGOID);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "6")]
	IEnumerable<FMPDDPPOCDE> JCAIJEIONAB();
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class FCMLKCJIAOA : ReadOnlyCollection<FMPDDPPOCDE>, EKKHLMMIDGN, IReadOnlyCollection<FMPDDPPOCDE>, IEnumerable<FMPDDPPOCDE>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public string EKPDCEFJBCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8ACF00", Offset = "0x8AB700", VA = "0x1808ACF00", Slot = "35")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public Sprite MDEALJJGIDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7F2CE0", Offset = "0x7F14E0", VA = "0x1807F2CE0", Slot = "36")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6FDAA00", Offset = "0x6FD9200", VA = "0x186FDAA00")]
	public FCMLKCJIAOA([NotNull] string BPOKAAOBIOI, [NotNull] IList<FMPDDPPOCDE> IFADMANLNLG, [NotNull] Sprite BKAONKILAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6FDA8C0", Offset = "0x6FD90C0", VA = "0x186FDA8C0", Slot = "37")]
	public bool FNFOLGAFHOL(FMPDDPPOCDE LFDCEOOOGKA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface EKKHLMMIDGN : IReadOnlyCollection<FMPDDPPOCDE>, IEnumerable<FMPDDPPOCDE>, IEnumerable
{
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface OBIEAKMGPLO
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool BOPECIDJAII
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action DNNFOIDNPIE;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event Action EGFPLLIFOFC;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DHNABAHGKLP();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DNDOLGLMHLG();
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public enum DHMJEACHHKG
{
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	Mobile,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	Screens,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	VR
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class PLHIMGDDHAI : OBIEAKMGPLO
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public interface FBJLAPIEOJN
	{
		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		int FBHFDKGOEBO
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public interface PNIIPMJEPCM
	{
		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		int ALNJPKFPPDK
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
	private readonly PNIIPMJEPCM FAFFEONDOFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly JKEAAGLCGBP OCHICJINGGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly int EFECGKPMHAJ;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	private int EOOLCKPBCJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6FDC570", Offset = "0x6FDAD70", VA = "0x186FDC570")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool BOPECIDJAII
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6FDC660", Offset = "0x6FDAE60", VA = "0x186FDC660", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action DNNFOIDNPIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6FDC5C0", Offset = "0x6FDADC0", VA = "0x186FDC5C0", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6FDC1E0", Offset = "0x6FDA9E0", VA = "0x186FDC1E0", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action EGFPLLIFOFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6FDC4D0", Offset = "0x6FDACD0", VA = "0x186FDC4D0", Slot = "9")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6FDC280", Offset = "0x6FDAA80", VA = "0x186FDC280", Slot = "10")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6FDC6F0", Offset = "0x6FDAEF0", VA = "0x186FDC6F0")]
	[Preserve]
	public PLHIMGDDHAI([NotNull][ACEKLAKDMBL(null)] FBJLAPIEOJN NHDPMDDKIPK, [NotNull][ACEKLAKDMBL(null)] PNIIPMJEPCM FAFFEONDOFJ, [NotNull][ACEKLAKDMBL(null)] JKEAAGLCGBP OCHICJINGGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6FDC320", Offset = "0x6FDAB20", VA = "0x186FDC320", Slot = "5")]
	public void DHNABAHGKLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6FDC3F0", Offset = "0x6FDABF0", VA = "0x186FDC3F0", Slot = "6")]
	public void DNDOLGLMHLG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface APDIGMPFLNJ
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "0")]
	DHMJEACHHKG DOMOAOCAMID();
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface OJHFBMHNBAK
{
	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool NFKCDLBLNIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool MNHNJJOJLPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event Action BAGINCCBELH;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action GCENNAGEOMB;
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
