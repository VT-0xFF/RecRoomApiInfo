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
public class IKIJLNKHDML : FDHPECBKBFM
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface CIOHIHDPAEK
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		IEnumerable<DEMAIGEBKPG> HHMIDKLKBLK
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		IReadOnlyList<PGJGIJJLKCA> GOBEFBPLJAO
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		int EKIPLNKACMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface MJAEGKBKPDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<CIOHIHDPAEK> OPPDLOLMEHD();
	}

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class BECNEJIJPIG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public Predicate<DEMAIGEBKPG> predicate;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public BECNEJIJPIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x723CD50", Offset = "0x723B350", VA = "0x18723CD50")]
		internal bool FGEBPAHNENM(DEMAIGEBKPG challenge)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class OANPFLCPGIB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public IKIJLNKHDML <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private CIOHIHDPAEK <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private IEnumerator<DEMAIGEBKPG> <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private DEMAIGEBKPG <challenge>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private TaskAwaiter<CIOHIHDPAEK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public OANPFLCPGIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x723E730", Offset = "0x723CD30", VA = "0x18723E730", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly KLFKKIABKME HBBIOLJHOAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly MJAEGKBKPDK JFLHKJOKAJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private CIOHIHDPAEK KMNMEMJNFDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private IReadOnlyList<PGJGIJJLKCA> BOLNKKFNLJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private IEnumerable<DEMAIGEBKPG> FEGEKDPCHOK;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool JNAPJBBIKBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x723E0E0", Offset = "0x723C6E0", VA = "0x18723E0E0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool EEFABLOFEDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x723DCA0", Offset = "0x723C2A0", VA = "0x18723DCA0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool OIALDGFIHAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x723D8E0", Offset = "0x723BEE0", VA = "0x18723D8E0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IReadOnlyList<PGJGIJJLKCA> GOBEFBPLJAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x86F230", Offset = "0x86D830", VA = "0x18086F230", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<DEMAIGEBKPG> MBHLLAODONL
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x723E1D0", Offset = "0x723C7D0", VA = "0x18723E1D0", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x723E130", Offset = "0x723C730", VA = "0x18723E130", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x723E350", Offset = "0x723C950", VA = "0x18723E350")]
	[Preserve]
	public IKIJLNKHDML([NotNull][NALHKAIJJND(null)] KLFKKIABKME HBBIOLJHOAN, [NotNull][NALHKAIJJND(null)] MJAEGKBKPDK JFLHKJOKAJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x723D6D0", Offset = "0x723BCD0", VA = "0x18723D6D0", Slot = "12")]
	public IEnumerable<DEMAIGEBKPG> DBACNMADKPP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x723DB10", Offset = "0x723C110", VA = "0x18723DB10", Slot = "10")]
	public IEnumerable<DEMAIGEBKPG> GIMCOIDIOJH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x723DA10", Offset = "0x723C010", VA = "0x18723DA10", Slot = "9")]
	public DEMAIGEBKPG ELIMGOMPGGN(Predicate<DEMAIGEBKPG> DMBCKDLEKGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x723E270", Offset = "0x723C870", VA = "0x18723E270")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(OANPFLCPGIB))]
	private void NLBGCJABHAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x723D410", Offset = "0x723BA10", VA = "0x18723D410")]
	private void CNEOLPFIFAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x723DEA0", Offset = "0x723C4A0", VA = "0x18723DEA0")]
	private void JGAJIBPOHPC(DEMAIGEBKPG DLEHEIKFFBC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface DEMAIGEBKPG
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public interface KMMLECPJJKB
	{
		[Cpp2IlInjected.Token(Token = "0x17000011")]
		Sprite GNANMKENHJI
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	int MFJKIAEGIHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool LOGKDENGELF
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	string DHJNLBPEBJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	NFGIHCMCIML OEHIKECPGFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	string MHDBODLDKCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	Texture2D LMCJCEJDMLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	Sprite GOCJEPDGJDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool JMGDPEMOMAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	bool BFKAMJIJPIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<DEMAIGEBKPG> KFFIBEILNKJ;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "12")]
	ADCACBFKFKM HBEIMMAHGPI();

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "13")]
	LEKACFEIBBA<bool> IOCIFOHBNLN();
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface FDHPECBKBFM
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool JNAPJBBIKBI
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	bool EEFABLOFEDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool OIALDGFIHAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action<DEMAIGEBKPG> MBHLLAODONL;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "5")]
	DEMAIGEBKPG ELIMGOMPGGN(Predicate<DEMAIGEBKPG> DMBCKDLEKGI);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "6")]
	IEnumerable<DEMAIGEBKPG> GIMCOIDIOJH();
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class NFGIHCMCIML : ReadOnlyCollection<DEMAIGEBKPG>, PGJGIJJLKCA, IReadOnlyCollection<DEMAIGEBKPG>, IEnumerable<DEMAIGEBKPG>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public string NHAFHGAJCFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x86F2A0", Offset = "0x86D8A0", VA = "0x18086F2A0", Slot = "35")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public Sprite GOCJEPDGJDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x86F230", Offset = "0x86D830", VA = "0x18086F230", Slot = "36")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x723E650", Offset = "0x723CC50", VA = "0x18723E650")]
	public NFGIHCMCIML([NotNull] string HNPIEGONNBC, [NotNull] IList<DEMAIGEBKPG> EKFNNDEBOAK, [NotNull] Sprite CFCOIDNLMKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x723E510", Offset = "0x723CB10", VA = "0x18723E510", Slot = "37")]
	public bool DAONIKMFNKL(DEMAIGEBKPG DLEHEIKFFBC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface PGJGIJJLKCA : IReadOnlyCollection<DEMAIGEBKPG>, IEnumerable<DEMAIGEBKPG>, IEnumerable
{
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface PIJJMIDFDFG
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool ANCAMLNEDHO
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action LKECBCPNFMP;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event Action NMNJGFDMJHA;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PDGGGNNMGII();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BGMKDJCDAPP();
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public enum BGFNPFDACPE
{
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	Mobile,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	Screens,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	VR
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class GPAKJKDPBKK : PIJJMIDFDFG
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public interface CNJCDBEALAH
	{
		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		int OAOOBGMPFHO
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public interface FPLBGBBNGIG
	{
		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		int HJEKEDEAGKF
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
	private readonly FPLBGBBNGIG KOLFOPFDLND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly FDHPECBKBFM CBMCNPJPMEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly int HGANDDHKBAK;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	private int JDBKHODNEHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x723D060", Offset = "0x723B660", VA = "0x18723D060")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool ANCAMLNEDHO
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x723CF30", Offset = "0x723B530", VA = "0x18723CF30", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action LKECBCPNFMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x723CE90", Offset = "0x723B490", VA = "0x18723CE90", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x723CFC0", Offset = "0x723B5C0", VA = "0x18723CFC0", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action NMNJGFDMJHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x723D220", Offset = "0x723B820", VA = "0x18723D220", Slot = "9")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x723D0B0", Offset = "0x723B6B0", VA = "0x18723D0B0", Slot = "10")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x723D2C0", Offset = "0x723B8C0", VA = "0x18723D2C0")]
	[Preserve]
	public GPAKJKDPBKK([NotNull][NALHKAIJJND(null)] CNJCDBEALAH PNAFBPFLGPO, [NotNull][NALHKAIJJND(null)] FPLBGBBNGIG KOLFOPFDLND, [NotNull][NALHKAIJJND(null)] FDHPECBKBFM CBMCNPJPMEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x723D150", Offset = "0x723B750", VA = "0x18723D150", Slot = "5")]
	public void PDGGGNNMGII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x723CDB0", Offset = "0x723B3B0", VA = "0x18723CDB0", Slot = "6")]
	public void BGMKDJCDAPP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface PFBOONPNPLN
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BGFNPFDACPE NOMHBAHHNKI();
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface KLFKKIABKME
{
	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool LJKICNFFNBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool DEADABFJGHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event Action FEGPLPPFGCP;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action BLMKNNIBDNM;
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
