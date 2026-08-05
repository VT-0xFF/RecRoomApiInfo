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
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public OOAJANNHNOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6FC3020", Offset = "0x6FC1C20", VA = "0x186FC3020")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public NOGAEMECOCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6FC2A90", Offset = "0x6FC1690", VA = "0x186FC2A90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x6FC27A0", Offset = "0x6FC13A0", VA = "0x186FC27A0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool GPPNEHHGDCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6FC1C90", Offset = "0x6FC0890", VA = "0x186FC1C90", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool CDEBPNMFFNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6FC2670", Offset = "0x6FC1270", VA = "0x186FC2670", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IReadOnlyList<EKKHLMMIDGN> FIIJKLHHJFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7F0240", Offset = "0x7EEE40", VA = "0x1807F0240", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<FMPDDPPOCDE> PGIDOOOOFIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6FC1F30", Offset = "0x6FC0B30", VA = "0x186FC1F30", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6FC1E90", Offset = "0x6FC0A90", VA = "0x186FC1E90", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6FC28D0", Offset = "0x6FC14D0", VA = "0x186FC28D0")]
	[Preserve]
	public FHDECFCCCKI([NotNull][ACEKLAKDMBL(null)] OJHFBMHNBAK NJBPGOHOFNG, [NotNull][ACEKLAKDMBL(null)] EGMCEBLFCJK NMGALIEBJPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6FC1A80", Offset = "0x6FC0680", VA = "0x186FC1A80", Slot = "12")]
	public IEnumerable<FMPDDPPOCDE> EJMJFCLHENN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6FC1FD0", Offset = "0x6FC0BD0", VA = "0x186FC1FD0", Slot = "10")]
	public IEnumerable<FMPDDPPOCDE> JCAIJEIONAB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6FC1980", Offset = "0x6FC0580", VA = "0x186FC1980", Slot = "9")]
	public FMPDDPPOCDE ALIINPGDHFE(Predicate<FMPDDPPOCDE> GKMOGNDGOID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6FC27F0", Offset = "0x6FC13F0", VA = "0x186FC27F0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(NOGAEMECOCI))]
	private void PFEFGBHIJLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6FC23B0", Offset = "0x6FC0FB0", VA = "0x186FC23B0")]
	private void LGLGFCMPOOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6FC2160", Offset = "0x6FC0D60", VA = "0x186FC2160")]
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
		[Cpp2IlInjected.Address(RVA = "0x8370C0", Offset = "0x835CC0", VA = "0x1808370C0", Slot = "35")]
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
		[Cpp2IlInjected.Address(RVA = "0x7F0240", Offset = "0x7EEE40", VA = "0x1807F0240", Slot = "36")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6FC18A0", Offset = "0x6FC04A0", VA = "0x186FC18A0")]
	public FCMLKCJIAOA([NotNull] string BPOKAAOBIOI, [NotNull] IList<FMPDDPPOCDE> IFADMANLNLG, [NotNull] Sprite BKAONKILAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6FC1760", Offset = "0x6FC0360", VA = "0x186FC1760", Slot = "37")]
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
		[Cpp2IlInjected.Address(RVA = "0x6FC3410", Offset = "0x6FC2010", VA = "0x186FC3410")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool BOPECIDJAII
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6FC3500", Offset = "0x6FC2100", VA = "0x186FC3500", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action DNNFOIDNPIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6FC3460", Offset = "0x6FC2060", VA = "0x186FC3460", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6FC3080", Offset = "0x6FC1C80", VA = "0x186FC3080", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action EGFPLLIFOFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6FC3370", Offset = "0x6FC1F70", VA = "0x186FC3370", Slot = "9")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6FC3120", Offset = "0x6FC1D20", VA = "0x186FC3120", Slot = "10")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6FC3590", Offset = "0x6FC2190", VA = "0x186FC3590")]
	[Preserve]
	public PLHIMGDDHAI([NotNull][ACEKLAKDMBL(null)] FBJLAPIEOJN NHDPMDDKIPK, [NotNull][ACEKLAKDMBL(null)] PNIIPMJEPCM FAFFEONDOFJ, [NotNull][ACEKLAKDMBL(null)] JKEAAGLCGBP OCHICJINGGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6FC31C0", Offset = "0x6FC1DC0", VA = "0x186FC31C0", Slot = "5")]
	public void DHNABAHGKLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6FC3290", Offset = "0x6FC1E90", VA = "0x186FC3290", Slot = "6")]
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
