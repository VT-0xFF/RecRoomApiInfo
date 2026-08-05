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
using RecRoom.RoomEconomy.RoomInventory;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface OMNGBEMPOHD : NDPCJMCHCCH
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	JFNKDDIHJNA AINOHILPLID
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[DefaultMember("Item")]
public class JKACIKMJING
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly Dictionary<Guid, PCMOKIFDKGG> FNFFBGBDPIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly Dictionary<string, PCMOKIFDKGG> CKLAAFEODAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private bool? MGJNFPFDAHO;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private long HLEBPLLIAAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7AD150", Offset = "0x7ABF50", VA = "0x1807AD150")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public PCMOKIFDKGG LKDOJBHIIBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x65863A0", Offset = "0x65851A0", VA = "0x1865863A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6585740", Offset = "0x6584540", VA = "0x186585740")]
	public void AAPHEENLIGC(long CGIDLDOBHII, IEnumerable<CLCMFNBBMOD> HCGCPIPJMNI, IEnumerable<HIBMLJHJECJ> OPKCFFKGCDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6586340", Offset = "0x6585140", VA = "0x186586340")]
	public bool HPGNAGPLFOD(Guid HPIMOBDLJLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x65864A0", Offset = "0x65852A0", VA = "0x1865864A0")]
	public bool JJGPDDBMEBN(Guid HPIMOBDLJLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x65860D0", Offset = "0x6584ED0", VA = "0x1865860D0")]
	public bool FPHDMLNGDAN(CLCMFNBBMOD ICKFJMLDFBM, [Out] CLCMFNBBMOD BJMGCHAAHLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6586000", Offset = "0x6584E00", VA = "0x186586000")]
	public IEnumerable<PCMOKIFDKGG> EHPCBMJKKIC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6585EB0", Offset = "0x6584CB0", VA = "0x186585EB0")]
	public IEnumerable<CLCMFNBBMOD> EGLHNFLHDNN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6586560", Offset = "0x6585360", VA = "0x186586560")]
	public IEnumerable<HIBMLJHJECJ> KPILDMOCKMO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6586AE0", Offset = "0x65858E0", VA = "0x186586AE0")]
	public bool NMDNHLAOGHC(Guid HPIMOBDLJLG, [Out] CLCMFNBBMOD ICJLNODCCIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6586400", Offset = "0x6585200", VA = "0x186586400")]
	public bool IIDPACLHAID(string IKDPFENBMKM, [Out] CLCMFNBBMOD ICJLNODCCIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6586B90", Offset = "0x6585990", VA = "0x186586B90")]
	public bool PALCBCNLNNP(Guid HPIMOBDLJLG, [Out] HIBMLJHJECJ PHFLPJPFAHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x65864C0", Offset = "0x65852C0", VA = "0x1865864C0")]
	public bool JMAELDIJFBH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6586050", Offset = "0x6584E50", VA = "0x186586050")]
	private bool EMEEKJKGFIH(CLCMFNBBMOD OAIFDBCCKDL, CLCMFNBBMOD EMAOLNIJLHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x65866B0", Offset = "0x65854B0", VA = "0x1865866B0")]
	private void MHHGKIIDHID(Guid ENPOKNEMOMH, PCMOKIFDKGG NPMCKNMCABH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6586C40", Offset = "0x6585A40", VA = "0x186586C40")]
	private bool PNMACNADDHJ(Guid ENPOKNEMOMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6585DC0", Offset = "0x6584BC0", VA = "0x186585DC0")]
	private void BOJLINPFEDC(CLCMFNBBMOD DICHOGNHJBG, [Optional] CLCMFNBBMOD PALIMHGJDPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6586900", Offset = "0x6585700", VA = "0x186586900")]
	private bool MKDKJGDFMBE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6586300", Offset = "0x6585100", VA = "0x186586300")]
	private static bool HOOFFANOIGK(CLCMFNBBMOD PEFIMPHEJCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6586E80", Offset = "0x6585C80", VA = "0x186586E80")]
	public JKACIKMJING()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class JFNKDDIHJNA : MLNGFPMOKEL, HLJGGPKNINM, IDisposable, HDDHAKCFELD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private struct ONMKDFBECHP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public AsyncTaskMethodBuilder<FBEPHKHKLJE<CLCMFNBBMOD, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public JFNKDDIHJNA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public RoomInventoryItemProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public string description;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public string imageName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private TaskAwaiter<BCAGGENGADC<PEOMHNHBAFF>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x658AEF0", Offset = "0x6589CF0", VA = "0x18658AEF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x658B300", Offset = "0x658A100", VA = "0x18658B300", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct NBLGPPABGOK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public AsyncTaskMethodBuilder<FBEPHKHKLJE<CLCMFNBBMOD, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public JFNKDDIHJNA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public RoomInventoryItemProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public string description;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public string imageName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public List<long> tagIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private TaskAwaiter<BCAGGENGADC<PEOMHNHBAFF>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6588A40", Offset = "0x6587840", VA = "0x186588A40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6588F60", Offset = "0x6587D60", VA = "0x186588F60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct AHIBBPJPLMD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncTaskMethodBuilder<FBEPHKHKLJE<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public JFNKDDIHJNA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private TaskAwaiter<LALALCEBIGO> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x657C190", Offset = "0x657AF90", VA = "0x18657C190", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x657C9B0", Offset = "0x657B7B0", VA = "0x18657C9B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct OCNLNJOGPKG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public JFNKDDIHJNA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public MNFCKJNKANA player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private TaskAwaiter<int> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6589E60", Offset = "0x6588C60", VA = "0x186589E60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x658A1E0", Offset = "0x6588FE0", VA = "0x18658A1E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct DHGKMMPCOCM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public AsyncTaskMethodBuilder<GNOMJNELBFE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public JFNKDDIHJNA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public MNFCKJNKANA recipient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public int quantity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private TaskAwaiter<GNOMJNELBFE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x657D440", Offset = "0x657C240", VA = "0x18657D440", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x657D8A0", Offset = "0x657C6A0", VA = "0x18657D8A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct HCHFBDLJBIE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public AsyncTaskMethodBuilder<FBEPHKHKLJE<PFLJAPLHCPJ, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public JFNKDDIHJNA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public long tagId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public RoomInventoryTagClientProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private PFLJAPLHCPJ <tag>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private TaskAwaiter<TaskStatus> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x657F440", Offset = "0x657E240", VA = "0x18657F440", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x657F8C0", Offset = "0x657E6C0", VA = "0x18657F8C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct OJGHCNBJMKE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public AsyncTaskMethodBuilder<FBEPHKHKLJE<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public JFNKDDIHJNA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public long tagId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private List<PFLJAPLHCPJ>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private TaskAwaiter<FBEPHKHKLJE<PFLJAPLHCPJ, string>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private TaskAwaiter<LALALCEBIGO> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x658A250", Offset = "0x6589050", VA = "0x18658A250", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x658AE80", Offset = "0x6589C80", VA = "0x18658AE80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct ACDCLHFKPGF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public AsyncTaskMethodBuilder<Dictionary<long, IJAKEMICEPB>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public Dictionary<long, int> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public JFNKDDIHJNA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private TaskAwaiter<List<BCAGGENGADC<IJAKEMICEPB>>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x657B890", Offset = "0x657A690", VA = "0x18657B890", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x657C120", Offset = "0x657AF20", VA = "0x18657C120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct KDFFNGPPGEK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public JFNKDDIHJNA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public HIBMLJHJECJ playerRoomInventoryItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public int quantity;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct BOPBPOFNEIL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public AsyncTaskMethodBuilder<GNOMJNELBFE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public JFNKDDIHJNA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public int quantity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private KDFFNGPPGEK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public MNFCKJNKANA awardingPlayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public Guid remoteOperationId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private TaskAwaiter<LKDGAHAPKLI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x657CA20", Offset = "0x657B820", VA = "0x18657CA20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x657CE70", Offset = "0x657BC70", VA = "0x18657CE70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct NHPAHEIGCAG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public Dictionary<Guid, int> idsAndQuantities;
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class GHHKHDCMKCI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public LKDGAHAPKLI result;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public GHHKHDCMKCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x657E9E0", Offset = "0x657D7E0", VA = "0x18657E9E0")]
		internal JONEFCHPOJJ HNAIHAGNBCP(Guid id)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct IIIAMAJMBBF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public AsyncTaskMethodBuilder<Dictionary<Guid, JONEFCHPOJJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public Dictionary<Guid, int> idsAndQuantities;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public JFNKDDIHJNA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private NHPAHEIGCAG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private TaskAwaiter<List<JONEFCHPOJJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x657F930", Offset = "0x657E730", VA = "0x18657F930", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6580370", Offset = "0x657F170", VA = "0x186580370", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class EBFNCOBNCJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public JFNKDDIHJNA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public Dictionary<Guid, int> idsAndQuantities;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public Func<KeyValuePair<Guid, int>, NAFCBPEPAIL> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public EBFNCOBNCJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x657D910", Offset = "0x657C710", VA = "0x18657D910")]
		internal NAFCBPEPAIL AMHBGAPHHLB(KeyValuePair<Guid, int> kvp)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private struct MNBMHBFAPHJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public AsyncTaskMethodBuilder<List<JONEFCHPOJJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public JFNKDDIHJNA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public Dictionary<Guid, int> idsAndQuantities;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private EBFNCOBNCJD <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private List<JONEFCHPOJJ> <results>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private int <attemptNumber>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private TaskAwaiter<List<JONEFCHPOJJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6587EB0", Offset = "0x6586CB0", VA = "0x186587EB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x65889D0", Offset = "0x65877D0", VA = "0x1865889D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct FCIFKFKADMM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public JFNKDDIHJNA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private Task<List<PEOMHNHBAFF>> <roomInventoryTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private Task<List<PAIGFBGCFNP>> <playerRoomInventoryTask>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private Task<List<IJAKEMICEPB>> <roomInventoryTagsTask>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private IEnumerable<CLCMFNBBMOD> <roomInventoryItems>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private IEnumerable<HIBMLJHJECJ> <playerRoomInventoryItems>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private TaskAwaiter<List<PEOMHNHBAFF>> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private TaskAwaiter<List<PAIGFBGCFNP>> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private TaskAwaiter<List<IJAKEMICEPB>> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x657DBD0", Offset = "0x657C9D0", VA = "0x18657DBD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x657E980", Offset = "0x657D780", VA = "0x18657E980", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct DEEJLEDFMLG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public JFNKDDIHJNA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x657CF20", Offset = "0x657BD20", VA = "0x18657CF20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x657D3E0", Offset = "0x657C1E0", VA = "0x18657D3E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct MLANHACEIDF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public JFNKDDIHJNA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private TaskAwaiter<Task> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x65877D0", Offset = "0x65865D0", VA = "0x1865877D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6587E50", Offset = "0x6586C50", VA = "0x186587E50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private struct NKCBPPGHHOC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public JFNKDDIHJNA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public MNFCKJNKANA player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private TaskAwaiter<int> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6588FD0", Offset = "0x6587DD0", VA = "0x186588FD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x65894D0", Offset = "0x65882D0", VA = "0x1865894D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private struct LLBACGMALLK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public AsyncTaskMethodBuilder<GNOMJNELBFE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public JFNKDDIHJNA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public MNFCKJNKANA player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public int quantity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private TaskAwaiter<GNOMJNELBFE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6587240", Offset = "0x6586040", VA = "0x186587240", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6587760", Offset = "0x6586560", VA = "0x186587760", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private struct HCGMPOBMOIF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public CLCMFNBBMOD itemToDelete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public JFNKDDIHJNA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private Dictionary<long, bool>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private TaskAwaiter<FBEPHKHKLJE<bool, string>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x657EA50", Offset = "0x657D850", VA = "0x18657EA50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x657F3E0", Offset = "0x657E1E0", VA = "0x18657F3E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly TimeSpan CNCHAGMGBPH;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private const float HKKFLIHNLBB = 10f;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private const float KPMKNFGBJAM = 3f;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal const int DCOGJHIBDEC = 3;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	internal const string ACMCNOLKOBN = "econ_room_inventory_gate";

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	internal const string KIFPCDKHMGF = "experiences_room_inventory_tags_gate";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly FANGOFEHCIG PONICNKLJLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly FCICABCCLLA DLPPCNILOBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly BAOGECDAMOO BLJFPJNGPLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly BKDAEJIBJAK NBKILBHMBFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly OMNGBEMPOHD MFJFKBENBJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly LPDDOMPGFNK DFHPPDBAGOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly GMGDKFAGIOK CGALCAMGCEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly MBOOKNNJOGN LJCNDCGOHNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly JKACIKMJING AMDJAPKKANK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly NKNKAHFMBGL CHOBCFFMCGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly DCJHGJNDBHN NKJMOGKAJGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly CancellationTokenSource OBGPLIJOKAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly AONCABGFHOD<Guid, JONEFCHPOJJ> COLLJFCMPLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly AONCABGFHOD<long, IJAKEMICEPB> HOMFFFEFKGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly BLABNGBIGFB NJNNGMPFEKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly IDisposable GOGMMPPJHBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private Task GPBEGJLBJDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private CancellationTokenSource MNBLLDDCJIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private long BKLMDGKDCLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private bool FCGEEBKFDBI;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private EGNIENKHAKB KGMDPOBKKIA
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x65823C0", Offset = "0x65811C0", VA = "0x1865823C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public BHHPLLLFBGO MCLKCHALIHI
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x9A6070", Offset = "0x9A4E70", VA = "0x1809A6070", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x9B2690", Offset = "0x9B1490", VA = "0x1809B2690", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public EOPEMIILONN<CLCMFNBBMOD> GHAFNALMKOA
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9B2520", Offset = "0x9B1320", VA = "0x1809B2520", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9B26D0", Offset = "0x9B14D0", VA = "0x1809B26D0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public EOPEMIILONN<Guid> KPLMIIKLCCB
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x888960", Offset = "0x887760", VA = "0x180888960", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x9B25F0", Offset = "0x9B13F0", VA = "0x1809B25F0", Slot = "9")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public FOEHHLKMAJF<HIBMLJHJECJ, int> KDLFOMNDEGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7FEDD0", Offset = "0x7FDBD0", VA = "0x1807FEDD0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7FCB20", Offset = "0x7FB920", VA = "0x1807FCB20", Slot = "11")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public EOPEMIILONN<PFLJAPLHCPJ> LGKMFCJKDGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7FEDA0", Offset = "0x7FDBA0", VA = "0x1807FEDA0", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public EOPEMIILONN<long> BBGKOHPCKMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x7AF6A0", Offset = "0x7AE4A0", VA = "0x1807AF6A0", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public BHHPLLLFBGO ICDLEPKEDHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8951C0", Offset = "0x893FC0", VA = "0x1808951C0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8BA220", Offset = "0x8B9020", VA = "0x1808BA220", Slot = "13")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x65840A0", Offset = "0x6582EA0", VA = "0x1865840A0")]
	[NAAAALLPNIA(KMIEHGCCHON.Session, PBKIGNPNCFO.GameOnly)]
	private static void PMDBOALDHOL(IBPIJCMLLGH PPDHICBEIFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6584B80", Offset = "0x6583980", VA = "0x186584B80")]
	[Preserve]
	public JFNKDDIHJNA([LICAMFFCLCL(null)] FANGOFEHCIG PONICNKLJLH, [LICAMFFCLCL(null)] FCICABCCLLA DLPPCNILOBP, [LICAMFFCLCL(null)] BAOGECDAMOO BLJFPJNGPLG, [LICAMFFCLCL(null)] CGDMBOAPDIA LMIOPABPBEI, [LICAMFFCLCL(null)] BKDAEJIBJAK NBKILBHMBFG, [LICAMFFCLCL(null)] OMNGBEMPOHD MFJFKBENBJO, [LICAMFFCLCL(null)] OGGLGNECAHK CMEIPDHENEC, [LICAMFFCLCL(null)] LFHGADAIJAJ OCEHABDOMFN, [LICAMFFCLCL(null)] LPDDOMPGFNK DFHPPDBAGOB, [LICAMFFCLCL(null)] GMGDKFAGIOK CGALCAMGCEA, [LICAMFFCLCL(null)] MBOOKNNJOGN LJCNDCGOHNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6580F50", Offset = "0x657FD50", VA = "0x186580F50", Slot = "30")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6581960", Offset = "0x6580760", VA = "0x186581960", Slot = "14")]
	[AsyncStateMachine(typeof(ONMKDFBECHP))]
	public Task<FBEPHKHKLJE<CLCMFNBBMOD, string>> GBIEDJOMOKB(long CGIDLDOBHII, string OHHBGJPCFJD, string JFBABPIJMOE, string DCHICAAFAFA, RoomInventoryItemProperties GGBBBBDBDBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6584110", Offset = "0x6582F10", VA = "0x186584110", Slot = "15")]
	[AsyncStateMachine(typeof(NBLGPPABGOK))]
	public Task<FBEPHKHKLJE<CLCMFNBBMOD, string>> PMDNCNONHHM(Guid HPIMOBDLJLG, [Optional] string OHHBGJPCFJD, [Optional] string JFBABPIJMOE, [Optional] string DCHICAAFAFA, [Optional] List<long> JHJCPGOOBJG, [Optional] RoomInventoryItemProperties GGBBBBDBDBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6581EA0", Offset = "0x6580CA0", VA = "0x186581EA0", Slot = "16")]
	[AsyncStateMachine(typeof(AHIBBPJPLMD))]
	public Task<FBEPHKHKLJE<bool, string>> HPKHPHCEFLA(Guid HPIMOBDLJLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6581C00", Offset = "0x6580A00", VA = "0x186581C00", Slot = "17")]
	public IReadOnlyList<CLCMFNBBMOD> GGCJHLGEDDN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6581690", Offset = "0x6580490", VA = "0x186581690", Slot = "18")]
	public IReadOnlyList<CLCMFNBBMOD> GAMJABHACGD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6583C00", Offset = "0x6582A00", VA = "0x186583C00", Slot = "19")]
	public bool OHJLBIGLGFC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6583AE0", Offset = "0x65828E0", VA = "0x186583AE0", Slot = "20")]
	public bool NMDNHLAOGHC(Guid HPIMOBDLJLG, [Out] CLCMFNBBMOD ICJLNODCCIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6582080", Offset = "0x6580E80", VA = "0x186582080", Slot = "21")]
	public bool IIDPACLHAID(string IAOGLEHICNL, [Out] CLCMFNBBMOD ICJLNODCCIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6583770", Offset = "0x6582570", VA = "0x186583770", Slot = "22")]
	public IReadOnlyList<HIBMLJHJECJ> NHGKPOAHMCK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6583F70", Offset = "0x6582D70", VA = "0x186583F70", Slot = "23")]
	public bool PALCBCNLNNP(Guid HPIMOBDLJLG, [Out] HIBMLJHJECJ PHFLPJPFAHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6580A50", Offset = "0x657F850", VA = "0x186580A50", Slot = "29")]
	public void DDNLDAHEEOK(IEnumerable<PAIGFBGCFNP> OPKCFFKGCDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6582840", Offset = "0x6581640", VA = "0x186582840", Slot = "24")]
	[AsyncStateMachine(typeof(OCNLNJOGPKG))]
	public Task<int> JIGLOPACEMH(MNFCKJNKANA ACNHNLBOPON, Guid HPIMOBDLJLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6583330", Offset = "0x6582130", VA = "0x186583330", Slot = "25")]
	[AsyncStateMachine(typeof(DHGKMMPCOCM))]
	public Task<GNOMJNELBFE> NADBDCDPDEP(MNFCKJNKANA CBDCCHIADKM, Guid HPIMOBDLJLG, int LBCEMAMCEGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6583DA0", Offset = "0x6582BA0", VA = "0x186583DA0", Slot = "26")]
	public string OPIFCLEOKBO(LKDGAHAPKLI BGCCPJGDEGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6581170", Offset = "0x657FF70", VA = "0x186581170", Slot = "27")]
	public bool EEAMMDAGBAF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6581AD0", Offset = "0x65808D0", VA = "0x186581AD0", Slot = "33")]
	[AsyncStateMachine(typeof(HCHFBDLJBIE))]
	public Task<FBEPHKHKLJE<PFLJAPLHCPJ, string>> GDPNFNLLJGH(long NDCOMELLJGN, RoomInventoryTagClientProperties GGBBBBDBDBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6583120", Offset = "0x6581F20", VA = "0x186583120", Slot = "34")]
	[AsyncStateMachine(typeof(OJGHCNBJMKE))]
	public Task<FBEPHKHKLJE<bool, string>> MDHLEJOCEGJ(long NDCOMELLJGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x65803E0", Offset = "0x657F1E0", VA = "0x1865803E0", Slot = "35")]
	public bool BABCGAONGGG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6581550", Offset = "0x6580350", VA = "0x186581550")]
	[AsyncStateMachine(typeof(ACDCLHFKPGF))]
	private Task<Dictionary<long, IJAKEMICEPB>> FGMDGDIFGLN(Dictionary<long, int> CMCBMKAJBPJ, CancellationToken HHBHDBLGMFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6582410", Offset = "0x6581210", VA = "0x186582410")]
	[AsyncStateMachine(typeof(BOPBPOFNEIL))]
	private Task<GNOMJNELBFE> IOKHOLMOCAO(Guid HPIMOBDLJLG, int LBCEMAMCEGO, [Optional] Guid GCLMECLCKFM, [Optional] MNFCKJNKANA OJMBKJKEIJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x65811D0", Offset = "0x657FFD0", VA = "0x1865811D0")]
	[AsyncStateMachine(typeof(IIIAMAJMBBF))]
	private Task<Dictionary<Guid, JONEFCHPOJJ>> ELCLMECLJLC(Dictionary<Guid, int> PFKDJNCJEIL, CancellationToken HHBHDBLGMFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6580440", Offset = "0x657F240", VA = "0x186580440")]
	[AsyncStateMachine(typeof(MNBMHBFAPHJ))]
	private Task<List<JONEFCHPOJJ>> BCAPBKEAACN(Dictionary<Guid, int> PFKDJNCJEIL, CancellationToken HHBHDBLGMFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6580E30", Offset = "0x657FC30", VA = "0x186580E30")]
	[AsyncStateMachine(typeof(FCIFKFKADMM))]
	private Task DLLNHHINPMK(long CGIDLDOBHII, CancellationToken HHBHDBLGMFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6583240", Offset = "0x6582040", VA = "0x186583240")]
	[AsyncStateMachine(typeof(DEEJLEDFMLG))]
	private Task MLJCBPKMAND(LMCJHJIAIGC BBFBHKMAMKC, CancellationToken HHBHDBLGMFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x65821A0", Offset = "0x6580FA0", VA = "0x1865821A0")]
	[AsyncStateMachine(typeof(MLANHACEIDF))]
	private Task IMCFPICLNCL(LMCJHJIAIGC BBFBHKMAMKC, CancellationToken KEIBMFPLBLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6580930", Offset = "0x657F730", VA = "0x186580930")]
	private void BKCIOKDACLI(PEOMHNHBAFF MCIJEAMJACL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x65846F0", Offset = "0x65834F0", VA = "0x1865846F0")]
	[MKMMCNOMLCG]
	private void RpcOnNotifiedOfRoomInventoryItemCreatedOrUpdated(string CGIGBIEFFCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6583960", Offset = "0x6582760", VA = "0x186583960")]
	private void NJFOKNNCCED(Guid HPIMOBDLJLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6584810", Offset = "0x6583610", VA = "0x186584810")]
	[MKMMCNOMLCG]
	private void RpcOnNotifiedOfRoomInventoryItemDeleted(Guid HPIMOBDLJLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6582EB0", Offset = "0x6581CB0", VA = "0x186582EB0")]
	[AsyncStateMachine(typeof(NKCBPPGHHOC))]
	private Task<int> KHCBMEBICMF(MNFCKJNKANA ACNHNLBOPON, Guid HPIMOBDLJLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6584500", Offset = "0x6583300", VA = "0x186584500")]
	[MKMMCNOMLCG]
	internal void RpcGetPlayerRoomInventoryCount(Guid MBCGHBNLJEN, Guid HPIMOBDLJLG, DPDKFPKEKBM LINKNNNEGKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6584480", Offset = "0x6583280", VA = "0x186584480")]
	[MKMMCNOMLCG]
	internal void RpcGetPlayerRoomInventoryCountResponse(Guid MBCGHBNLJEN, int BPFMGMBDOBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6582270", Offset = "0x6581070", VA = "0x186582270")]
	[AsyncStateMachine(typeof(LLBACGMALLK))]
	private Task<GNOMJNELBFE> INBLEKCIMHH(MNFCKJNKANA ACNHNLBOPON, Guid HPIMOBDLJLG, int LBCEMAMCEGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x65843B0", Offset = "0x65831B0", VA = "0x1865843B0")]
	[MKMMCNOMLCG]
	internal void RpcAddOrRemovePlayerRoomInventoryRequest(Guid MBCGHBNLJEN, Guid HPIMOBDLJLG, int LBCEMAMCEGO, DPDKFPKEKBM LINKNNNEGKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6582560", Offset = "0x6581360", VA = "0x186582560")]
	private void JFOCOLMCBLG(MNFCKJNKANA CBDCCHIADKM, Guid MBCGHBNLJEN, LKDGAHAPKLI BGCCPJGDEGH, long LIHAFEMNIBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6584A50", Offset = "0x6583850", VA = "0x186584A50")]
	[MKMMCNOMLCG]
	internal void RpcSendAddOrRemovePlayerRoomInventoryResultToPlayer(Guid MBCGHBNLJEN, int BGCCPJGDEGH, long LIHAFEMNIBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6582720", Offset = "0x6581520", VA = "0x186582720")]
	private void JIBBDPKGNBF(IJAKEMICEPB MCIJEAMJACL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6584840", Offset = "0x6583640", VA = "0x186584840")]
	[MKMMCNOMLCG]
	private void RpcOnNotifiedOfRoomInventoryTagCreateOrUpdate(string IGHDJLEGMEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6580CC0", Offset = "0x657FAC0", VA = "0x186580CC0")]
	private void DLHICACCMIC(long NDCOMELLJGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x65849F0", Offset = "0x65837F0", VA = "0x1865849F0")]
	[MKMMCNOMLCG]
	private void RpcOnNotifiedOfRoomInventoryTagDeleted(long NDCOMELLJGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6582980", Offset = "0x6581780", VA = "0x186582980")]
	private CLCMFNBBMOD JJDGDPLNCKN(PEOMHNHBAFF MCIJEAMJACL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6583D10", Offset = "0x6582B10", VA = "0x186583D10")]
	private PFLJAPLHCPJ OLDABMOABDH(IJAKEMICEPB MCIJEAMJACL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6580590", Offset = "0x657F390", VA = "0x186580590")]
	private CLCMFNBBMOD BEBBJJIBLGM(PEOMHNHBAFF MCIJEAMJACL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6583480", Offset = "0x6582280", VA = "0x186583480")]
	private PFLJAPLHCPJ NDCALKKBAKK(IJAKEMICEPB MCIJEAMJACL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x65814E0", Offset = "0x65802E0", VA = "0x1865814E0")]
	private void FEMGLKNCAGP(HIBMLJHJECJ PHFLPJPFAHA, int AILEHIHNLJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6582E40", Offset = "0x6581C40", VA = "0x186582E40")]
	private void JMLGFGDFHML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6581CB0", Offset = "0x6580AB0", VA = "0x186581CB0")]
	private Task GOKJPJAIILE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6581E30", Offset = "0x6580C30", VA = "0x186581E30")]
	private void HIMKOLIDFML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6581FC0", Offset = "0x6580DC0", VA = "0x186581FC0")]
	private void IAMLIMDGLLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x65842A0", Offset = "0x65830A0", VA = "0x1865842A0")]
	private void POICJOHOJBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6582FF0", Offset = "0x6581DF0", VA = "0x186582FF0")]
	[AsyncStateMachine(typeof(HCGMPOBMOIF))]
	private Task LDFOKGLJLOJ(CLCMFNBBMOD ONCHNJLFIFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6583100", Offset = "0x6581F00", VA = "0x186583100")]
	[CompilerGenerated]
	private void LHCIPGDCPJN(Task<TaskStatus> IMKKNGNMOEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6582A20", Offset = "0x6581820", VA = "0x186582A20")]
	[CompilerGenerated]
	private Task<LKDGAHAPKLI> JJIANCHBNMM(KDFFNGPPGEK P_0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6581310", Offset = "0x6580110", VA = "0x186581310")]
	[CompilerGenerated]
	internal static Dictionary<Guid, JONEFCHPOJJ> EOLJDJDHEMP(LKDGAHAPKLI BGCCPJGDEGH, NHPAHEIGCAG P_1)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class DCJHGJNDBHN : Dictionary<string, RoomInventoryItemProperties>
{
	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x657CEE0", Offset = "0x657BCE0", VA = "0x18657CEE0")]
	public DCJHGJNDBHN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface LFHGADAIJAJ
{
	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JKACIKMJING HJJHGPAIBKI();

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "1")]
	DCJHGJNDBHN EJBHMGHHCNI();

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NKNKAHFMBGL JNJFLFIICLH();
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class KOKAKLOFJKK : LFHGADAIJAJ
{
	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x65871D0", Offset = "0x6585FD0", VA = "0x1865871D0")]
	[NAAAALLPNIA(KMIEHGCCHON.Session, PBKIGNPNCFO.GameOnly)]
	private static void PMDBOALDHOL(IBPIJCMLLGH PPDHICBEIFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	[Preserve]
	public KOKAKLOFJKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x6586FD0", Offset = "0x6585DD0", VA = "0x186586FD0", Slot = "4")]
	public JKACIKMJING HJJHGPAIBKI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6586F60", Offset = "0x6585D60", VA = "0x186586F60", Slot = "5")]
	public DCJHGJNDBHN EJBHMGHHCNI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x65870E0", Offset = "0x6585EE0", VA = "0x1865870E0", Slot = "6")]
	public NKNKAHFMBGL JNJFLFIICLH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class NKNKAHFMBGL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private readonly Dictionary<long, PFLJAPLHCPJ> NHCAKBMIDEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private readonly PFLJAPLHCPJ[] EJCPNIBPMIN;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int EDGNCGIDCBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6589B20", Offset = "0x6588920", VA = "0x186589B20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private long JNDBMCBKAMG
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0xE64300", Offset = "0xE63100", VA = "0x180E64300")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6589540", Offset = "0x6588340", VA = "0x186589540")]
	public void AAPHEENLIGC(long CGIDLDOBHII, IEnumerable<PFLJAPLHCPJ> JAKMGJIIIFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6589B80", Offset = "0x6588980", VA = "0x186589B80")]
	public bool KCPAMPAAOOM(long NDCOMELLJGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6589BE0", Offset = "0x65889E0", VA = "0x186589BE0")]
	public bool KHONBGPFKBG(PFLJAPLHCPJ ALLEGMBHFMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x6589A80", Offset = "0x6588880", VA = "0x186589A80")]
	public bool BIPJCBEGNLP(long NDCOMELLJGN, [Out] PFLJAPLHCPJ HEMGNEANHEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x65899B0", Offset = "0x65887B0", VA = "0x1865899B0")]
	public List<PFLJAPLHCPJ> APIDKGCMENB(int ENPOKNEMOMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6589DA0", Offset = "0x6588BA0", VA = "0x186589DA0")]
	public NKNKAHFMBGL()
	{
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
