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
public interface DKINFGCHPFD
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HIJIOHOKEPK LGCCNOGMAIE();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class PAEKJOKLFLK : DKINFGCHPFD
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x63A9CA0", Offset = "0x63A8AA0", VA = "0x1863A9CA0")]
	[IBKPEPPEMNJ(INBBGMADPCI.Session, MIBJABCBNEH.GameOnly)]
	private static void KBMJKMKMJBP(KIDCBAFLGEK FEKKHCCBLJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	[Preserve]
	public PAEKJOKLFLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x63A9D10", Offset = "0x63A8B10", VA = "0x1863A9D10", Slot = "4")]
	public HIJIOHOKEPK LGCCNOGMAIE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class NJCDJJPGMIP : PGBKJFEMJGC, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private struct KBGMLNKLLIO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public AsyncTaskMethodBuilder<EFFPFBGFCJB<APANCMLALFB, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public NJCDJJPGMIP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public string description;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public string imageName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public int price;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public MLJKOAJPDMI roomOfferType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public Dictionary<Guid, int> roomInventoryItemMappings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private TaskAwaiter<FOICKPDLPOE<APANCMLALFB>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x63A6AD0", Offset = "0x63A58D0", VA = "0x1863A6AD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x63A6EC0", Offset = "0x63A5CC0", VA = "0x1863A6EC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private struct MBHDGFMGPIO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public AsyncTaskMethodBuilder<EFFPFBGFCJB<APANCMLALFB, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public NJCDJJPGMIP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public Guid roomOfferId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public string description;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public string imageName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public int price;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public MLJKOAJPDMI roomOfferType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public Dictionary<Guid, int> roomInventoryItemMappings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private TaskAwaiter<FOICKPDLPOE<APANCMLALFB>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x63A6F30", Offset = "0x63A5D30", VA = "0x1863A6F30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x63A73F0", Offset = "0x63A61F0", VA = "0x1863A73F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct OMGBIOOJDLO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public AsyncTaskMethodBuilder<EFFPFBGFCJB<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public NJCDJJPGMIP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public Guid roomOfferId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private TaskAwaiter<DILNHDFMKKD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x63A9760", Offset = "0x63A8560", VA = "0x1863A9760", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x63A9C30", Offset = "0x63A8A30", VA = "0x1863A9C30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct MLJJIKAMLNF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public NJCDJJPGMIP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private TaskAwaiter<List<APANCMLALFB>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x63A7460", Offset = "0x63A6260", VA = "0x1863A7460", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x63A79E0", Offset = "0x63A67E0", VA = "0x1863A79E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct HCMMDHDFHPO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public NJCDJJPGMIP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private TaskAwaiter<Task> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x63A5CC0", Offset = "0x63A4AC0", VA = "0x1863A5CC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x63A6330", Offset = "0x63A5130", VA = "0x1863A6330", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly TimeSpan PHDEKDNFLMF;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public const string PEGNGMCAAJN = "econ_room_offer_gate";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly JFBPADCCPPB GGJPIICGOIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly GIFLBCMOLON OLLIODOFMLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly NJHNNMMEIIF MKABELFIEGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly MNPAFMDHOOO FKMKJBIFKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly HIJIOHOKEPK EOOLDDMEIII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly IDisposable MLFJBEACOKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private Task NKKLJLMEKFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private CancellationTokenSource FFGKCPBCDCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private long JHPIJHHJHFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private bool JJLFBNEDAFO;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public INNFNKFCEKE KHFIICGIJCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x76FF20", Offset = "0x76ED20", VA = "0x18076FF20", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x76FF30", Offset = "0x76ED30", VA = "0x18076FF30", Slot = "16")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public BJPKLEOBMLD<APANCMLALFB> PJHIBGHEFGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x773C10", Offset = "0x772A10", VA = "0x180773C10", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x773C20", Offset = "0x772A20", VA = "0x180773C20", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public BJPKLEOBMLD<Guid> EEPBOFKLBMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x773BF0", Offset = "0x7729F0", VA = "0x180773BF0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x773C00", Offset = "0x772A00", VA = "0x180773C00", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x63A8F40", Offset = "0x63A7D40", VA = "0x1863A8F40")]
	[IBKPEPPEMNJ(INBBGMADPCI.Session, MIBJABCBNEH.GameOnly)]
	private static void KBMJKMKMJBP(KIDCBAFLGEK FEKKHCCBLJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x63A90F0", Offset = "0x63A7EF0", VA = "0x1863A90F0")]
	[Preserve]
	public NJCDJJPGMIP([HOHGLGKGFHE(null)] JFBPADCCPPB GGJPIICGOIH, [HOHGLGKGFHE(null)] GIFLBCMOLON OLLIODOFMLP, [HOHGLGKGFHE(null)] AFEKCHCOFLH HAAFMKNCKIM, [HOHGLGKGFHE(null)] NJHNNMMEIIF MKABELFIEGL, [HOHGLGKGFHE(null)] DKINFGCHPFD GPNMHFHMHIE, [HOHGLGKGFHE(null)] MNPAFMDHOOO FKMKJBIFKFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x63A84D0", Offset = "0x63A72D0", VA = "0x1863A84D0", Slot = "14")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x63A8CE0", Offset = "0x63A7AE0", VA = "0x1863A8CE0", Slot = "8")]
	[AsyncStateMachine(typeof(KBGMLNKLLIO))]
	public Task<EFFPFBGFCJB<APANCMLALFB, string>> GDKMMOHCLCA(long GCFELHFPIGG, string NDLLBBKGIJD, string HBNFGFDAEMN, string JJGDEEOHCJI, int CGIIKGHBKIM, MLJKOAJPDMI JNACNBMPHFA, [Optional] Dictionary<Guid, int> HGOIKODANBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x63A8350", Offset = "0x63A7150", VA = "0x1863A8350", Slot = "9")]
	[AsyncStateMachine(typeof(MBHDGFMGPIO))]
	public Task<EFFPFBGFCJB<APANCMLALFB, string>> DPCPHIDPCEF(Guid KCFLIJIFDIF, string NDLLBBKGIJD, string HBNFGFDAEMN, string JJGDEEOHCJI, int CGIIKGHBKIM, MLJKOAJPDMI JNACNBMPHFA, [Optional] Dictionary<Guid, int> HGOIKODANBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x63A8BC0", Offset = "0x63A79C0", VA = "0x1863A8BC0", Slot = "10")]
	[AsyncStateMachine(typeof(OMGBIOOJDLO))]
	public Task<EFFPFBGFCJB<bool, string>> FHMEHKEANFI(Guid KCFLIJIFDIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x63A7DF0", Offset = "0x63A6BF0", VA = "0x1863A7DF0", Slot = "11")]
	public IEnumerable<APANCMLALFB> BKGNEJHHBNM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x63A8AF0", Offset = "0x63A78F0", VA = "0x1863A8AF0", Slot = "12")]
	public bool FHICKBGNGDO(Guid KCFLIJIFDIF, [Out] APANCMLALFB EILIDKJAKIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x63A7D10", Offset = "0x63A6B10", VA = "0x1863A7D10", Slot = "17")]
	public bool BIPJIDKOECI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x63A8720", Offset = "0x63A7520", VA = "0x1863A8720", Slot = "13")]
	public bool FDHNEGKJLPE(Guid EFLGAAKBPNM, [Out] List<string> OKNMLFFCPAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x63A7EA0", Offset = "0x63A6CA0", VA = "0x1863A7EA0")]
	[AsyncStateMachine(typeof(MLJJIKAMLNF))]
	private Task CGCADHLDFNF(long GCFELHFPIGG, CancellationToken ELPOPHCEGNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x63A7FB0", Offset = "0x63A6DB0", VA = "0x1863A7FB0")]
	private Task CLKHKLAENEB(JMBBGLBCMAK BONEGMDLPMG, CancellationToken ELPOPHCEGNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x63A8FB0", Offset = "0x63A7DB0", VA = "0x1863A8FB0")]
	[AsyncStateMachine(typeof(HCMMDHDFHPO))]
	private Task LCFPEJGLNKL(JMBBGLBCMAK BONEGMDLPMG, CancellationToken IOMFFABLJLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x63A8CD0", Offset = "0x63A7AD0", VA = "0x1863A8CD0")]
	private void FPADNOKHDDN(APANCMLALFB EILIDKJAKIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x63A8E60", Offset = "0x63A7C60", VA = "0x1863A8E60")]
	private void HCIHKEAPIAN(Guid KCFLIJIFDIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x63A7B70", Offset = "0x63A6970", VA = "0x1863A7B70")]
	private APANCMLALFB ANELKHFBCAH(APANCMLALFB EFAINFPKKCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x63A8ED0", Offset = "0x63A7CD0", VA = "0x1863A8ED0")]
	private void JJMJEDGCMJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x63A7A40", Offset = "0x63A6840", VA = "0x1863A7A40")]
	private void ACKBHIEBLLN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[DefaultMember("Item")]
public class HIJIOHOKEPK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly Dictionary<Guid, APANCMLALFB> AGPPNFKJGDJ;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public long BAGGFIANPJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x772C20", Offset = "0x771A20", VA = "0x180772C20")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xD92FB0", Offset = "0xD91DB0", VA = "0x180D92FB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public APANCMLALFB LNGAKLGPPKB
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x63A69E0", Offset = "0x63A57E0", VA = "0x1863A69E0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x63A68F0", Offset = "0x63A56F0", VA = "0x1863A68F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x63A63F0", Offset = "0x63A51F0", VA = "0x1863A63F0")]
	public void CLLCILFEKKD(long GCFELHFPIGG, IEnumerable<APANCMLALFB> DPDBCNCAIPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x63A66F0", Offset = "0x63A54F0", VA = "0x1863A66F0")]
	public bool KNNPICLCDFA(Guid KCFLIJIFDIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x63A6390", Offset = "0x63A5190", VA = "0x1863A6390")]
	public bool BFKGBCINJJC(Guid KCFLIJIFDIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x63A6750", Offset = "0x63A5550", VA = "0x1863A6750")]
	public bool MGDDOFAOJEE(APANCMLALFB LHEMICNMMCI, [Out] APANCMLALFB IGBLKOMINPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x63A68A0", Offset = "0x63A56A0", VA = "0x1863A68A0")]
	public IEnumerable<APANCMLALFB> MNJNOJDHIAO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x63A6680", Offset = "0x63A5480", VA = "0x1863A6680")]
	public bool FHICKBGNGDO(Guid KCFLIJIFDIF, [Out] APANCMLALFB EILIDKJAKIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x63A6960", Offset = "0x63A5760", VA = "0x1863A6960")]
	private bool OBMJPMCANIB(APANCMLALFB IBLOAPAOIFJ, APANCMLALFB GFGPODALOPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x63A6A40", Offset = "0x63A5840", VA = "0x1863A6A40")]
	public HIJIOHOKEPK()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class DBFEEPAPMKO
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	public DBFEEPAPMKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x55D8720", Offset = "0x55D7520", VA = "0x1855D8720")]
	public static string MNBLOPEKEGH(byte[] CLLEBIDEBLB, byte[] JINDDDAPFKP)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class __BB_OBFUSCATOR_VERSION_3_10_0
	{
	}
}
namespace Cpp2IlInjected
{
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
}
