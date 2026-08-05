using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using RecRoom.NoEngine.Common;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface ALPNFPJEHOD : FCCJJMJDBAH
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	CABOKMJMJPM OIGIAKPAIFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[DefaultMember("Item")]
public class CBPODKAPDDB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly Dictionary<Guid, BANHOEFHKIE> OGPEIJFPBNA;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private long HHAPKNDFDMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xCC9B00", Offset = "0xCC8F00", VA = "0x180CC9B00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public BANHOEFHKIE ICGOOEBDNOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6236F30", Offset = "0x6236330", VA = "0x186236F30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6236F90", Offset = "0x6236390", VA = "0x186236F90")]
	public void PGIICCDGOMJ(long BLPLCJENHDJ, IEnumerable<HOBNCJMMBMM> OLKPCLEEBNF, IEnumerable<AGNGDMKODAE> AGKBPJFCOEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6236E80", Offset = "0x6236280", VA = "0x186236E80")]
	public bool CGGDAIIFFAN(Guid CGPMILIKOKE, [Out] AGNGDMKODAE MCDANOAELPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x62375E0", Offset = "0x62369E0", VA = "0x1862375E0")]
	public CBPODKAPDDB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class CABOKMJMJPM : MANOBDPPPID, IDisposable, OJELBCAGFBN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private struct EDLHFFEBMGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public Dictionary<Guid, int> idsAndQuantities;
	}

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class ABBLEJFJMLP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public MBDEJMGFADB result;

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public ABBLEJFJMLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x62357D0", Offset = "0x6234BD0", VA = "0x1862357D0")]
		internal JDGCCNLEBPG FBFBGJLIKGN(Guid id)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct JEAOKPOBHBF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public AsyncTaskMethodBuilder<Dictionary<Guid, JDGCCNLEBPG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public Dictionary<Guid, int> idsAndQuantities;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public CABOKMJMJPM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private EDLHFFEBMGJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private TaskAwaiter<List<JDGCCNLEBPG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x62384C0", Offset = "0x62378C0", VA = "0x1862384C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6238EA0", Offset = "0x62382A0", VA = "0x186238EA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class DEBMGCFPGDB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public CABOKMJMJPM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public Dictionary<Guid, int> idsAndQuantities;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public Func<KeyValuePair<Guid, int>, ELEPDPOMION> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public DEBMGCFPGDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6237670", Offset = "0x6236A70", VA = "0x186237670")]
		internal ELEPDPOMION CBOKNFOFHGM(KeyValuePair<Guid, int> kvp)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct IBOJKCMANBJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public AsyncTaskMethodBuilder<List<JDGCCNLEBPG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public CABOKMJMJPM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public Dictionary<Guid, int> idsAndQuantities;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private DEBMGCFPGDB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private List<JDGCCNLEBPG> <results>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private int <attemptNumber>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private TaskAwaiter<List<JDGCCNLEBPG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6237930", Offset = "0x6236D30", VA = "0x186237930", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6238450", Offset = "0x6237850", VA = "0x186238450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct NEPJCOHMKPI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public CABOKMJMJPM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private Task<List<MHKANANGIFE>> <roomInventoryTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private Task<List<DANLGBPHHAN>> <playerRoomInventoryTask>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private IEnumerable<HOBNCJMMBMM> <roomInventoryItems>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TaskAwaiter<List<MHKANANGIFE>> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private TaskAwaiter<List<DANLGBPHHAN>> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6239490", Offset = "0x6238890", VA = "0x186239490", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6239F80", Offset = "0x6239380", VA = "0x186239F80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct LADOEGNHEFO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public CABOKMJMJPM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6238F10", Offset = "0x6238310", VA = "0x186238F10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x62393F0", Offset = "0x62387F0", VA = "0x1862393F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct PAENIFKMOIP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public CABOKMJMJPM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private TaskAwaiter<Task> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x623A180", Offset = "0x6239580", VA = "0x18623A180", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x623A7C0", Offset = "0x6239BC0", VA = "0x18623A7C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly TimeSpan EFPCFJOPOAE;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private const float ODFCCIPBCGO = 10f;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal const int NNOACMLDMGF = 3;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal const string FAOHMMPHGIF = "econ_room_inventory_gate";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly EJGAIDJPIBN PKDMBGNFCIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly CFGKCJKMNMI ELMCIEEHCGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly ALJIBKCPHPH GFMMAILOGJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly ALPNFPJEHOD FGBIEGKGKAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly OEDPDKKLCHP IDPFDAGEDIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly JAGOKJPGBDD BEGCCPNJIAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly CNPEPFCFPHF LDCLGAJBLKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly CBPODKAPDDB PJLAPJGFIJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly MGHAKAEDNKP PFDABMBHGOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly CancellationTokenSource CBMILIGEANH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly KNAPPOKFMCB<Guid, JDGCCNLEBPG> CEBKNAJHBAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly ONHOONCBLDP KHBFPHBLKGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly IDisposable BLAMIGLEHNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private Task IECFAOKDAKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private CancellationTokenSource EFGNCPFPCFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private long IECNEMLPGFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private bool LDCMHPNHJNB;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Action NJMDJGIGIBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7653F0", Offset = "0x7647F0", VA = "0x1807653F0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6235FE0", Offset = "0x62353E0", VA = "0x186235FE0")]
	[DCEDJGMCFCN(HKDEIDHACLB.Session, IIPPAMCLFBJ.GameOnly)]
	private static void KNIANBDCMAC(BFGBHKPNKEI MIPCMNILFEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x62366A0", Offset = "0x6235AA0", VA = "0x1862366A0")]
	[Preserve]
	public CABOKMJMJPM([LMAFJMDCBJO(null)] EJGAIDJPIBN PKDMBGNFCIJ, [LMAFJMDCBJO(null)] CFGKCJKMNMI ELMCIEEHCGF, [LMAFJMDCBJO(null)] AAKCMELOLHA IDFCGAPFFMK, [LMAFJMDCBJO(null)] ALJIBKCPHPH GFMMAILOGJB, [LMAFJMDCBJO(null)] ALPNFPJEHOD FGBIEGKGKAM, [LMAFJMDCBJO(null)] AAMMNFMHEOA FDNBMPHFABH, [LMAFJMDCBJO(null)] HFAPHCHLBBK HNDAMAMCAGI, [LMAFJMDCBJO(null)] OEDPDKKLCHP IDPFDAGEDIN, [LMAFJMDCBJO(null)] JAGOKJPGBDD BEGCCPNJIAE, [LMAFJMDCBJO(null)] CNPEPFCFPHF LDCLGAJBLKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6235C60", Offset = "0x6235060", VA = "0x186235C60", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6236320", Offset = "0x6235720", VA = "0x186236320")]
	[AsyncStateMachine(typeof(JEAOKPOBHBF))]
	private Task<Dictionary<Guid, JDGCCNLEBPG>> OKPOPIMINLL(Dictionary<Guid, int> KJLEHFIDFDE, CancellationToken OMFABMCIOAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6235E90", Offset = "0x6235290", VA = "0x186235E90")]
	[AsyncStateMachine(typeof(IBOJKCMANBJ))]
	private Task<List<JDGCCNLEBPG>> HKDBGDEBDLJ(Dictionary<Guid, int> KJLEHFIDFDE, CancellationToken OMFABMCIOAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x62361B0", Offset = "0x62355B0", VA = "0x1862361B0")]
	[AsyncStateMachine(typeof(NEPJCOHMKPI))]
	private Task MODCFNLHNNG(long BLPLCJENHDJ, CancellationToken OMFABMCIOAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6236050", Offset = "0x6235450", VA = "0x186236050")]
	[AsyncStateMachine(typeof(LADOEGNHEFO))]
	private Task LNNOBNNJLHB(OKOIPJPAMDA LHPGBFGMEDK, CancellationToken OMFABMCIOAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6235840", Offset = "0x6234C40", VA = "0x186235840")]
	[AsyncStateMachine(typeof(PAENIFKMOIP))]
	private Task AOJCNOHBIIE(OKOIPJPAMDA LHPGBFGMEDK, CancellationToken NFLCIFHPFNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6235910", Offset = "0x6234D10", VA = "0x186235910")]
	private HOBNCJMMBMM BEOCKGEGAAJ(MHKANANGIFE LKELLJHHPFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x62362D0", Offset = "0x62356D0", VA = "0x1862362D0")]
	private void NEFBJLIKEKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6236140", Offset = "0x6235540", VA = "0x186236140")]
	private Task MIBKHIDBAEN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6236190", Offset = "0x6235590", VA = "0x186236190")]
	[CompilerGenerated]
	private void MLIIHLDJJKJ(Task<TaskStatus> DJNEDNIILKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6236460", Offset = "0x6235860", VA = "0x186236460")]
	[CompilerGenerated]
	internal static Dictionary<Guid, JDGCCNLEBPG> PMANMCBGIEI(MBDEJMGFADB BBHPNPGLHIG, EDLHFFEBMGJ P_1)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class MGHAKAEDNKP : Dictionary<string, KJACDDCPJLE>
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6239450", Offset = "0x6238850", VA = "0x186239450")]
	public MGHAKAEDNKP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface HFAPHCHLBBK
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CBPODKAPDDB CAJEEHHFACB();

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MGHAKAEDNKP DGAICIGJELD();
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class NPDNKAAGOMJ : HFAPHCHLBBK
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x623A110", Offset = "0x6239510", VA = "0x18623A110")]
	[DCEDJGMCFCN(HKDEIDHACLB.Session, IIPPAMCLFBJ.GameOnly)]
	private static void KNIANBDCMAC(BFGBHKPNKEI MIPCMNILFEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	[Preserve]
	public NPDNKAAGOMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6239FE0", Offset = "0x62393E0", VA = "0x186239FE0", Slot = "4")]
	public CBPODKAPDDB CAJEEHHFACB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x623A0A0", Offset = "0x62394A0", VA = "0x18623A0A0", Slot = "5")]
	public MGHAKAEDNKP DGAICIGJELD()
	{
		return null;
	}
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
