using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.NoEngine.Common;
using RecRoom.RoomEconomy.RoomInventory;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _AssemblyRegistry.RecRoom_RoomEconomy_RoomInventory_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8D72A20", Offset = "0x8D71020", VA = "0x188D72A20", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x29CB0D0", Offset = "0x29C96D0", VA = "0x1829CB0D0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface KPFOJNFMMHH : LCGIJPNGIOA
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	PPFOLCGCPPB LMJPLGGDDPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[DefaultMember("Item")]
public class LABKABHHDOJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly Dictionary<Guid, CGONGICDMMN> GNNBHGIPFIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly Dictionary<string, CGONGICDMMN> NLALHLNMHDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private bool? EINHLPGNKAK;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private long DLJLNOEPAHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xAA55A0", Offset = "0xAA3BA0", VA = "0x180AA55A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public CGONGICDMMN LAJHLDAJFPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8D66D80", Offset = "0x8D65380", VA = "0x188D66D80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x8D65FA0", Offset = "0x8D645A0", VA = "0x188D65FA0")]
	public void FLAIMHDCCGN(long DDLHEHAKJGF, IEnumerable<OOODIGLCBPD> HOLPGKGOGKJ, IEnumerable<PKCCCJLJCIK> HDBMFHADOCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x8D66D20", Offset = "0x8D65320", VA = "0x188D66D20")]
	public bool MLPBBEOCNDA(Guid JJPCOICIDAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x8D65C60", Offset = "0x8D64260", VA = "0x188D65C60")]
	public bool CBELOMAGFLH(Guid JJPCOICIDAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x8D66770", Offset = "0x8D64D70", VA = "0x188D66770")]
	public bool ILHACIJAJOE(OOODIGLCBPD OFCAHCLNFEH, [Out] OOODIGLCBPD NFCKBOJJDFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x8D65BD0", Offset = "0x8D641D0", VA = "0x188D65BD0")]
	public IEnumerable<CGONGICDMMN> BDLAGCCCMAO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x8D65E50", Offset = "0x8D64450", VA = "0x188D65E50")]
	public IEnumerable<OOODIGLCBPD> ELGIAFDLMBO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x8D66620", Offset = "0x8D64C20", VA = "0x188D66620")]
	public IEnumerable<PKCCCJLJCIK> HLKMIBNAADO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x8D669A0", Offset = "0x8D64FA0", VA = "0x188D669A0")]
	public bool KODAFPKJJNO(Guid JJPCOICIDAP, [Out] OOODIGLCBPD DIOJOOPADAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x8D65B30", Offset = "0x8D64130", VA = "0x188D65B30")]
	public bool AADOKMJHDPM(string OKHNBALHMFA, [Out] OOODIGLCBPD DIOJOOPADAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x8D65C80", Offset = "0x8D64280", VA = "0x188D65C80")]
	public bool DLGCGMCDABC(Guid JJPCOICIDAP, [Out] PKCCCJLJCIK LILAFPOFAMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x8D65D30", Offset = "0x8D64330", VA = "0x188D65D30")]
	public bool DLKALGMGDPN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x8D65DD0", Offset = "0x8D643D0", VA = "0x188D65DD0")]
	private bool EBBHHOJOKKO(OOODIGLCBPD JCAFAFAHHEP, OOODIGLCBPD NOHACJENFBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x8D67030", Offset = "0x8D65630", VA = "0x188D67030")]
	private void PLFOIBABMJD(Guid PMIGBJGNLLP, CGONGICDMMN GDEFNFIDMGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x8D66DE0", Offset = "0x8D653E0", VA = "0x188D66DE0")]
	private bool PDENPBNPBJP(Guid PMIGBJGNLLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x8D66C30", Offset = "0x8D65230", VA = "0x188D66C30")]
	private void MJFIGFJJKGK(OOODIGLCBPD BGNNGNLDHNC, [Optional] OOODIGLCBPD JMENKPIGPOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x8D66A50", Offset = "0x8D65050", VA = "0x188D66A50")]
	private bool LJAPFCPHNAO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x8D65C20", Offset = "0x8D64220", VA = "0x188D65C20")]
	private static bool BKJCPHFCCEF(OOODIGLCBPD NANHMPOBBLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x8D67280", Offset = "0x8D65880", VA = "0x188D67280")]
	public LABKABHHDOJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class PPFOLCGCPPB : CACAJPCCJHI, KOMDDJGIAPB, IDisposable, CGBFDMEMEEL
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private struct ENFEMCDOING : IEquatable<ENFEMCDOING>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public long DLJLNOEPAHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public Guid CMMJGAPDHAC;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x57AFB10", Offset = "0x57AE110", VA = "0x1857AFB10")]
		public ENFEMCDOING(long DDLHEHAKJGF, Guid JJPCOICIDAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x8D5FA30", Offset = "0x8D5E030", VA = "0x188D5FA30", Slot = "4")]
		public bool Equals(ENFEMCDOING AAGCKLPFJME)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8D5F8D0", Offset = "0x8D5DED0", VA = "0x188D5F8D0", Slot = "0")]
		public override bool Equals(object MPIDDJPOOMJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8D5FB30", Offset = "0x8D5E130", VA = "0x188D5FB30", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct KIINLKCPFLK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public AsyncTaskMethodBuilder<CKPAOGHIJHA<OOODIGLCBPD, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public PPFOLCGCPPB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public RoomInventoryItemProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public Guid? originId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public string description;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public string imageName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public byte shape;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public int color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public List<long> tagIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public List<JJNEJFACBPF> newTags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public bool allowRename;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private TaskAwaiter<IPLCGLKKMAF<APPKKLFKBDG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8D651C0", Offset = "0x8D637C0", VA = "0x188D651C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8D656D0", Offset = "0x8D63CD0", VA = "0x188D656D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct NIPNBBEIEAA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncTaskMethodBuilder<CKPAOGHIJHA<OOODIGLCBPD, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public PPFOLCGCPPB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public Dictionary<string, RoomInventoryTagClientProperties> newTags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public RoomInventoryItemProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public string description;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public string imageName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public List<long> tagIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public byte? shape;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public int? color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TaskAwaiter<IPLCGLKKMAF<APPKKLFKBDG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x8D67960", Offset = "0x8D65F60", VA = "0x188D67960", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x8D681B0", Offset = "0x8D667B0", VA = "0x188D681B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct JGDPMDPMHKJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public AsyncTaskMethodBuilder<CKPAOGHIJHA<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public PPFOLCGCPPB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private OOODIGLCBPD <itemToDelete>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private IAIGMINPBFN <result>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private TaskAwaiter<IAIGMINPBFN> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x8D624C0", Offset = "0x8D60AC0", VA = "0x188D624C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x8D62CD0", Offset = "0x8D612D0", VA = "0x188D62CD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct KOGOKKCOHLA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public PPFOLCGCPPB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public MEINMPIOLGA player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private TaskAwaiter<int> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8D65740", Offset = "0x8D63D40", VA = "0x188D65740", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8D65AC0", Offset = "0x8D640C0", VA = "0x188D65AC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct EKFCKOLBACO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public AsyncTaskMethodBuilder<JGFKPAIMKGI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public PPFOLCGCPPB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public MEINMPIOLGA recipient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public int quantity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private TaskAwaiter<JGFKPAIMKGI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8D5F400", Offset = "0x8D5DA00", VA = "0x188D5F400", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8D5F860", Offset = "0x8D5DE60", VA = "0x188D5F860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct NNJHHGJJPCL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public AsyncTaskMethodBuilder<CKPAOGHIJHA<DBKLPHJCAEE, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public PPFOLCGCPPB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public long tagId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public RoomInventoryTagClientProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private DBKLPHJCAEE <newTag>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private TaskAwaiter<TaskStatus> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x8D68220", Offset = "0x8D66820", VA = "0x188D68220", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x8D686A0", Offset = "0x8D66CA0", VA = "0x188D686A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct GNCBKANPHKN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public AsyncTaskMethodBuilder<CKPAOGHIJHA<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public PPFOLCGCPPB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public long tagId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private List<DBKLPHJCAEE>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private TaskAwaiter<CKPAOGHIJHA<DBKLPHJCAEE, string>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private TaskAwaiter<IAIGMINPBFN> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x8D605C0", Offset = "0x8D5EBC0", VA = "0x188D605C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x8D611D0", Offset = "0x8D5F7D0", VA = "0x188D611D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct BONOLDFHCEE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public AsyncTaskMethodBuilder<CKPAOGHIJHA<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public PPFOLCGCPPB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public bool isEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private TaskAwaiter<IAIGMINPBFN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x8D5EE70", Offset = "0x8D5D470", VA = "0x188D5EE70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x8D5F390", Offset = "0x8D5D990", VA = "0x188D5F390", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct JAFKGDPBDNC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public AsyncTaskMethodBuilder<Dictionary<long, JJNEJFACBPF>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public Dictionary<long, int> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public PPFOLCGCPPB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private TaskAwaiter<IPLCGLKKMAF<List<JJNEJFACBPF>>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x8D61A90", Offset = "0x8D60090", VA = "0x188D61A90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x8D62450", Offset = "0x8D60A50", VA = "0x188D62450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct HJCIADOPBIO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public PPFOLCGCPPB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public PKCCCJLJCIK playerRoomInventoryItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public int quantity;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct PMBKEPILIIB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public AsyncTaskMethodBuilder<JGFKPAIMKGI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public PPFOLCGCPPB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public int quantity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private HJCIADOPBIO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public MEINMPIOLGA awardingPlayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public Guid remoteOperationId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private TaskAwaiter<AKIGLGGMAFG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x8D6A9A0", Offset = "0x8D68FA0", VA = "0x188D6A9A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x8D6ADF0", Offset = "0x8D693F0", VA = "0x188D6ADF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private struct FELDKGNEGKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public Dictionary<ENFEMCDOING, int> idsAndQuantities;
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class NGDHPHPCFFB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public AKIGLGGMAFG result;

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public NGDHPHPCFFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x8D678F0", Offset = "0x8D65EF0", VA = "0x188D678F0")]
		internal DEOIBONDKHH LAIGEAIACJK(ENFEMCDOING id)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct JOCGEDNNBIF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public AsyncTaskMethodBuilder<Dictionary<ENFEMCDOING, DEOIBONDKHH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public Dictionary<ENFEMCDOING, int> idsAndQuantities;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public PPFOLCGCPPB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private FELDKGNEGKM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private TaskAwaiter<List<DEOIBONDKHH>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x8D63430", Offset = "0x8D61A30", VA = "0x188D63430", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x8D63F00", Offset = "0x8D62500", VA = "0x188D63F00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct OIDKEAHEPAK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public AsyncTaskMethodBuilder<List<DEOIBONDKHH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public Dictionary<ENFEMCDOING, int> idsAndQuantities;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public PPFOLCGCPPB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private List<DEOIBONDKHH> <results>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private int <attemptNumber>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private TaskAwaiter<List<DEOIBONDKHH>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x8D699C0", Offset = "0x8D67FC0", VA = "0x188D699C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x8D6A930", Offset = "0x8D68F30", VA = "0x188D6A930", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct OENGGNPOJHB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public PPFOLCGCPPB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private Task<List<APPKKLFKBDG>> <roomInventoryTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private Task<List<FCCCHAHAFNG>> <playerRoomInventoryTask>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private Task<List<JJNEJFACBPF>> <roomInventoryTagsTask>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private Task<GFBBJLIAGLB> <roomConfigsTask>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private IEnumerable<OOODIGLCBPD> <roomInventoryItems>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private IEnumerable<PKCCCJLJCIK> <playerRoomInventoryItems>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private List<DBKLPHJCAEE> <roomInventoryTags>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private TaskAwaiter<List<APPKKLFKBDG>> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private TaskAwaiter<List<FCCCHAHAFNG>> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private TaskAwaiter<List<JJNEJFACBPF>> <>u__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private TaskAwaiter<GFBBJLIAGLB> <>u__5;

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x8D68710", Offset = "0x8D66D10", VA = "0x188D68710", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x8D69960", Offset = "0x8D67F60", VA = "0x188D69960", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private struct JLJGDGGBNMC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public PPFOLCGCPPB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private TaskAwaiter<Task> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x8D62D40", Offset = "0x8D61340", VA = "0x188D62D40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x8D633D0", Offset = "0x8D619D0", VA = "0x188D633D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private struct IKPJIGICCJN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public PPFOLCGCPPB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public MEINMPIOLGA player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private TaskAwaiter<int> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x8D61240", Offset = "0x8D5F840", VA = "0x188D61240", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x8D61740", Offset = "0x8D5FD40", VA = "0x188D61740", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private struct NDHANFADODF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public AsyncTaskMethodBuilder<JGFKPAIMKGI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public PPFOLCGCPPB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public MEINMPIOLGA player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public int quantity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private TaskAwaiter<JGFKPAIMKGI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x8D67360", Offset = "0x8D65960", VA = "0x188D67360", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x8D67880", Offset = "0x8D65E80", VA = "0x188D67880", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private struct EPIBFMPMMCG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public OOODIGLCBPD itemToDelete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public PPFOLCGCPPB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private Dictionary<long, bool>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private TaskAwaiter<CKPAOGHIJHA<bool, string>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x8D5FBB0", Offset = "0x8D5E1B0", VA = "0x188D5FBB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x8D60560", Offset = "0x8D5EB60", VA = "0x188D60560", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly TimeSpan PNPIEBLJKEF;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private const float JKGNADOPKJG = 10f;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private const float GGNGIPLAHCG = 3f;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal const int BHIKAOLHJMF = 3;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	internal const string BJILFJEAAIM = "econ_room_inventory_gate";

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	internal const string ELCELNIBKPJ = "experiences_room_inventory_tags_gate";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly KDDKCMNCFNO JMBMGEJPIED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly AMPDPDPJLMF LLGGEAIGLNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly FGDHCAAGOFD CHAACLFPACK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly KFAJOGFMPAC BBDBIGBKGGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly DNLMIGCBEIM LIKEKMCHKOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly KPFOJNFMMHH PPKBBLCGGEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly FDLKGNCJCMC IPEKJJONPLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly GCGIFCEMEGI EFJAFCFKPCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly JCCGKNMBLGM FBFMDHGOFMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly LABKABHHDOJ NOHCAAOANFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly KCOOEGJEHHL DHKHNEACGJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly KBDIGLODFMP FENCGJCMBPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly CancellationTokenSource BFFKAAOFENA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly GGMAPPNKLCP<ENFEMCDOING, DEOIBONDKHH> ODHPELNPEOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly GGMAPPNKLCP<long, JJNEJFACBPF> IEKDLANHEDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly ABMKCEAPLOF KNKJJDKFGGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly IDisposable CCHMGIAMEHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private Task MABCNGHDMCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private CancellationTokenSource EBJIOALLEDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private long LGMLGGKFGEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private bool AJNGKKLNKMJ;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private NKNGDLOHPMN AKCNGNFLEDI
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8D6B9A0", Offset = "0x8D69FA0", VA = "0x188D6B9A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public HLLOFHFLNHG IIPBDPJAFCA
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xEDC690", Offset = "0xEDAC90", VA = "0x180EDC690", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xEDC6A0", Offset = "0xEDACA0", VA = "0x180EDC6A0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public PKBDHHCMFJK<OOODIGLCBPD> BNENNNDMDFF
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xB78BD0", Offset = "0xB771D0", VA = "0x180B78BD0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xBA1690", Offset = "0xB9FC90", VA = "0x180BA1690", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public PKBDHHCMFJK<Guid> AKKDCMNAHKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xB78FC0", Offset = "0xB775C0", VA = "0x180B78FC0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xB78B70", Offset = "0xB77170", VA = "0x180B78B70", Slot = "9")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public FCCGMMLDHAB<PKCCCJLJCIK, int> KOEJFBPPHAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xB364E0", Offset = "0xB34AE0", VA = "0x180B364E0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xB39500", Offset = "0xB37B00", VA = "0x180B39500", Slot = "11")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public PKBDHHCMFJK<DBKLPHJCAEE> PANOCACEMFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xAAEEA0", Offset = "0xAAD4A0", VA = "0x180AAEEA0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xAAEEB0", Offset = "0xAAD4B0", VA = "0x180AAEEB0", Slot = "13")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public PKBDHHCMFJK<long> FOAJJFGDGKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xB3A1D0", Offset = "0xB387D0", VA = "0x180B3A1D0", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xB394C0", Offset = "0xB37AC0", VA = "0x180B394C0", Slot = "15")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public HLLOFHFLNHG AGJECDGIFMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xB3A1C0", Offset = "0xB387C0", VA = "0x180B3A1C0", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xB394A0", Offset = "0xB37AA0", VA = "0x180B394A0", Slot = "17")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public HLLOFHFLNHG HLANLFNJLLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xB34C40", Offset = "0xB33240", VA = "0x180B34C40", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xB34990", Offset = "0xB32F90", VA = "0x180B34990", Slot = "19")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x8D6F1A0", Offset = "0x8D6D7A0", VA = "0x188D6F1A0")]
	[EGNICHGEFDG.FKEMGOBKAHC.CJJMBHGCOLI]
	internal static void KHFEDOGILIL(NMNJFHODGJA JBBCAANONNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x8D71C10", Offset = "0x8D70210", VA = "0x188D71C10")]
	[RecRoom.NoEngine.Common.Preserve]
	public PPFOLCGCPPB([EDHLHMEHMKO(null)] KDDKCMNCFNO JMBMGEJPIED, [EDHLHMEHMKO(null)] AMPDPDPJLMF LLGGEAIGLNO, [EDHLHMEHMKO(null)] FGDHCAAGOFD CHAACLFPACK, [EDHLHMEHMKO(null)] KFAJOGFMPAC BBDBIGBKGGK, [EDHLHMEHMKO(null)] BIDKKAOMJIC FGNBHLKJJPP, [EDHLHMEHMKO(null)] DNLMIGCBEIM LIKEKMCHKOI, [EDHLHMEHMKO(null)] KPFOJNFMMHH PPKBBLCGGEO, [EDHLHMEHMKO(null)] BLNFFCEJHPB PJMBMOIINPD, [EDHLHMEHMKO(null)] APIHPADIELE BOHCNOEAPBA, [EDHLHMEHMKO(null)] FDLKGNCJCMC IPEKJJONPLO, [EDHLHMEHMKO(null)] GCGIFCEMEGI EFJAFCFKPCC, [EDHLHMEHMKO(null)] JCCGKNMBLGM FBFMDHGOFMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x8D6CAA0", Offset = "0x8D6B0A0", VA = "0x188D6CAA0", Slot = "53")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x8D6F410", Offset = "0x8D6DA10", VA = "0x188D6F410", Slot = "52")]
	public Task KJAFBCEKKGO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x8D6CE90", Offset = "0x8D6B490", VA = "0x188D6CE90", Slot = "20")]
	[AsyncStateMachine(typeof(KIINLKCPFLK))]
	public Task<CKPAOGHIJHA<OOODIGLCBPD, string>> EHJDOIHHFCN(Guid? BKJKAJIMPMA, long DDLHEHAKJGF, string NDIENANOGEK, string NGPLKKDGJMB, string IPHPNMCAICN, RoomInventoryItemProperties MGIBLGJBEDG, byte KOJIMAFGDLP, int FPHNLEHIJEM, [Optional] List<long> MHFKCEAFKOA, [Optional] List<JJNEJFACBPF> CKPDAOKKLNO, bool ECHMDIKFKLC = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x8D6D0C0", Offset = "0x8D6B6C0", VA = "0x188D6D0C0", Slot = "21")]
	[AsyncStateMachine(typeof(NIPNBBEIEAA))]
	public Task<CKPAOGHIJHA<OOODIGLCBPD, string>> ELFPKJHKGJF(Guid JJPCOICIDAP, long DDLHEHAKJGF, [Optional] string NDIENANOGEK, [Optional] string NGPLKKDGJMB, [Optional] string IPHPNMCAICN, [Optional] List<long> MHFKCEAFKOA, [Optional] Dictionary<string, RoomInventoryTagClientProperties> CKPDAOKKLNO, [Optional] RoomInventoryItemProperties MGIBLGJBEDG, [Optional] byte? KOJIMAFGDLP, [Optional] int? FPHNLEHIJEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x8D6FBC0", Offset = "0x8D6E1C0", VA = "0x188D6FBC0", Slot = "22")]
	[AsyncStateMachine(typeof(JGDPMDPMHKJ))]
	public Task<CKPAOGHIJHA<bool, string>> LKEHPDFOCBJ(Guid JJPCOICIDAP, long DDLHEHAKJGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x8D6CDE0", Offset = "0x8D6B3E0", VA = "0x188D6CDE0", Slot = "23")]
	public IReadOnlyList<OOODIGLCBPD> ECDEJBIBDNK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x8D6C430", Offset = "0x8D6AA30", VA = "0x188D6C430")]
	private List<OOODIGLCBPD> CMCOIPAFGNG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x8D71280", Offset = "0x8D6F880", VA = "0x188D71280", Slot = "24")]
	public IReadOnlyList<OOODIGLCBPD> PKMAANADEGD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x8D6DCB0", Offset = "0x8D6C2B0", VA = "0x188D6DCB0", Slot = "25")]
	public bool FIMMILGCHDC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x8D6F660", Offset = "0x8D6DC60", VA = "0x188D6F660", Slot = "26")]
	public bool KODAFPKJJNO(Guid JJPCOICIDAP, [Out] OOODIGLCBPD DIOJOOPADAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x8D6AE60", Offset = "0x8D69460", VA = "0x188D6AE60", Slot = "27")]
	public bool AADOKMJHDPM(string NDKBODCOEGA, [Out] OOODIGLCBPD DIOJOOPADAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x8D6FF70", Offset = "0x8D6E570", VA = "0x188D6FF70", Slot = "28")]
	public IReadOnlyList<PKCCCJLJCIK> NBFGDCJKBMA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x8D6C8E0", Offset = "0x8D6AEE0", VA = "0x188D6C8E0", Slot = "29")]
	public bool DLGCGMCDABC(Guid JJPCOICIDAP, [Out] PKCCCJLJCIK LILAFPOFAMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x8D6E460", Offset = "0x8D6CA60", VA = "0x188D6E460", Slot = "30")]
	public long? GDGDHIDPHID(Guid JJPCOICIDAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x8D6F780", Offset = "0x8D6DD80", VA = "0x188D6F780", Slot = "51")]
	public void KOLBKANJLOM(IEnumerable<FCCCHAHAFNG> HDBMFHADOCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x8D70B50", Offset = "0x8D6F150", VA = "0x188D70B50", Slot = "31")]
	[AsyncStateMachine(typeof(KOGOKKCOHLA))]
	public Task<int> ODAIJEMJDIO(MEINMPIOLGA AGIMJJDFEAF, Guid JJPCOICIDAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x8D6FCF0", Offset = "0x8D6E2F0", VA = "0x188D6FCF0", Slot = "32")]
	[AsyncStateMachine(typeof(EKFCKOLBACO))]
	public Task<JGFKPAIMKGI> MIMCKOOIAKB(MEINMPIOLGA CPHAJCPEFCH, Guid JJPCOICIDAP, int CJHNGJDMKKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x8D6EFD0", Offset = "0x8D6D5D0", VA = "0x188D6EFD0", Slot = "33")]
	public string JMEICCAJBMD(AKIGLGGMAFG FAKHJBCPGHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x8D6F4B0", Offset = "0x8D6DAB0", VA = "0x188D6F4B0", Slot = "34")]
	public bool KKODDEKNLOG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x8D6FE40", Offset = "0x8D6E440", VA = "0x188D6FE40", Slot = "38")]
	[AsyncStateMachine(typeof(NNJHHGJJPCL))]
	public Task<CKPAOGHIJHA<DBKLPHJCAEE, string>> MOPLICAJGDN(long NALIEDCLPFA, RoomInventoryTagClientProperties MGIBLGJBEDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x8D70750", Offset = "0x8D6ED50", VA = "0x188D70750", Slot = "39")]
	[AsyncStateMachine(typeof(GNCBKANPHKN))]
	public Task<CKPAOGHIJHA<bool, string>> NOHPHOKFHOC(long NALIEDCLPFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x8D703A0", Offset = "0x8D6E9A0", VA = "0x188D703A0", Slot = "42")]
	public List<(long, int)> NLKKCDAHOGC(long FGGLBNAGGNI, int BGHMJLCBIHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x8D6CA10", Offset = "0x8D6B010", VA = "0x188D6CA10", Slot = "43")]
	public bool DPADNLJMAEF(long NALIEDCLPFA, [Out] DBKLPHJCAEE AJKLDJMHEMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x8D6EB80", Offset = "0x8D6D180", VA = "0x188D6EB80", Slot = "44")]
	public bool IHLCOPKOIAM(string OGEMEPLANJD, [Out] DBKLPHJCAEE AJKLDJMHEMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x8D6F210", Offset = "0x8D6D810", VA = "0x188D6F210", Slot = "45")]
	public bool KIMEDLFPGPH(long NALIEDCLPFA, Guid HMHKKKPBPKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x8D6D630", Offset = "0x8D6BC30", VA = "0x188D6D630", Slot = "46")]
	public IReadOnlyList<DBKLPHJCAEE> ENPGABKKGCO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x8D6FB30", Offset = "0x8D6E130", VA = "0x188D6FB30", Slot = "47")]
	public List<DBKLPHJCAEE> LDIJBFFGEOP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x8D6D280", Offset = "0x8D6B880", VA = "0x188D6D280", Slot = "48")]
	public IReadOnlyList<DBKLPHJCAEE> ENHKEMJIANI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x8D6EB00", Offset = "0x8D6D100", VA = "0x188D6EB00", Slot = "41")]
	public bool IEHONFLFDEM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x8D70870", Offset = "0x8D6EE70", VA = "0x188D70870", Slot = "49")]
	public IReadOnlyList<OOODIGLCBPD> OAMGNDBCNAL(long NALIEDCLPFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x8D6CCC0", Offset = "0x8D6B2C0", VA = "0x188D6CCC0", Slot = "40")]
	[AsyncStateMachine(typeof(BONOLDFHCEE))]
	public Task<CKPAOGHIJHA<bool, string>> EAFJFONCKEJ(long DDLHEHAKJGF, bool EHGAKGFIEHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x8D70160", Offset = "0x8D6E760", VA = "0x188D70160", Slot = "54")]
	public bool NJFDBGBBOIH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x8D70DC0", Offset = "0x8D6F3C0", VA = "0x188D70DC0", Slot = "50")]
	public bool PGGEMKEENAO(string OGEMEPLANJD, [Out] IReadOnlyList<OOODIGLCBPD> BAPPECANPJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x8D6F9F0", Offset = "0x8D6DFF0", VA = "0x188D6F9F0")]
	[AsyncStateMachine(typeof(JAFKGDPBDNC))]
	private Task<Dictionary<long, JJNEJFACBPF>> LDCBMFHEDLA(Dictionary<long, int> IMIEBDIIGMK, CancellationToken PJCIHHKJKBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x8D6B630", Offset = "0x8D69C30", VA = "0x188D6B630")]
	[AsyncStateMachine(typeof(PMBKEPILIIB))]
	private Task<JGFKPAIMKGI> ALECIJPGJCD(Guid JJPCOICIDAP, int CJHNGJDMKKM, [Optional] Guid KEKGDCHDAII, [Optional] MEINMPIOLGA ANJHLJJPBOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x8D6D9F0", Offset = "0x8D6BFF0", VA = "0x188D6D9F0")]
	[AsyncStateMachine(typeof(JOCGEDNNBIF))]
	private Task<Dictionary<ENFEMCDOING, DEOIBONDKHH>> FIHADIMKLNC(Dictionary<ENFEMCDOING, int> BGJEKPOLKED, CancellationToken PJCIHHKJKBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x8D6F520", Offset = "0x8D6DB20", VA = "0x188D6F520")]
	[AsyncStateMachine(typeof(OIDKEAHEPAK))]
	private Task<List<DEOIBONDKHH>> KMCMLIIKADL(Dictionary<ENFEMCDOING, int> BGJEKPOLKED, CancellationToken PJCIHHKJKBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x8D6EEA0", Offset = "0x8D6D4A0", VA = "0x188D6EEA0")]
	[AsyncStateMachine(typeof(OENGGNPOJHB))]
	private Task JJMOIIBLNKL(long DDLHEHAKJGF, CancellationToken PJCIHHKJKBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x8D6AF80", Offset = "0x8D69580", VA = "0x188D6AF80")]
	private Task AEFCMLFKPKO(GNGDPEPAGOH PNGANGECEEL, CancellationToken PJCIHHKJKBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x8D70680", Offset = "0x8D6EC80", VA = "0x188D70680")]
	[AsyncStateMachine(typeof(JLJGDGGBNMC))]
	private Task NNILIOMGDDL(GNGDPEPAGOH PNGANGECEEL, CancellationToken HIBFLBKIPDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x8D6C7C0", Offset = "0x8D6ADC0", VA = "0x188D6C7C0")]
	private void DKFHJOCBJMG(APPKKLFKBDG FJBNDOOPLMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x8D716F0", Offset = "0x8D6FCF0", VA = "0x188D716F0")]
	[FPDADGGBBPP]
	private void RpcOnNotifiedOfRoomInventoryItemCreatedOrUpdated(string CJBDAMGMMEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x8D6DDB0", Offset = "0x8D6C3B0", VA = "0x188D6DDB0")]
	private void FJPJLNFLFMH(Guid JJPCOICIDAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x8D71830", Offset = "0x8D6FE30", VA = "0x188D71830")]
	[FPDADGGBBPP]
	private void RpcOnNotifiedOfRoomInventoryItemDeleted(Guid JJPCOICIDAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x8D6E800", Offset = "0x8D6CE00", VA = "0x188D6E800")]
	[AsyncStateMachine(typeof(IKPJIGICCJN))]
	private Task<int> HMNBHEMJLFA(MEINMPIOLGA AGIMJJDFEAF, Guid JJPCOICIDAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x8D71500", Offset = "0x8D6FB00", VA = "0x188D71500")]
	[FPDADGGBBPP]
	internal void RpcGetPlayerRoomInventoryCount(Guid KBIKPAMBBCL, Guid JJPCOICIDAP, KFPLHECPDME PCLIBIJEFPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x8D71480", Offset = "0x8D6FA80", VA = "0x188D71480")]
	[FPDADGGBBPP]
	internal void RpcGetPlayerRoomInventoryCountResponse(Guid KBIKPAMBBCL, int LMJBLNOIBOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x8D6E9B0", Offset = "0x8D6CFB0", VA = "0x188D6E9B0")]
	[AsyncStateMachine(typeof(NDHANFADODF))]
	private Task<JGFKPAIMKGI> HPHEFMMDEAO(MEINMPIOLGA AGIMJJDFEAF, Guid JJPCOICIDAP, int CJHNGJDMKKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x8D713B0", Offset = "0x8D6F9B0", VA = "0x188D713B0")]
	[FPDADGGBBPP]
	internal void RpcAddOrRemovePlayerRoomInventoryRequest(Guid KBIKPAMBBCL, Guid JJPCOICIDAP, int CJHNGJDMKKM, KFPLHECPDME PCLIBIJEFPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x8D6C270", Offset = "0x8D6A870", VA = "0x188D6C270")]
	private void CHCCMHKOFOL(MEINMPIOLGA CPHAJCPEFCH, Guid KBIKPAMBBCL, AKIGLGGMAFG FAKHJBCPGHO, long EFHCOKOABIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x8D71AE0", Offset = "0x8D700E0", VA = "0x188D71AE0")]
	[FPDADGGBBPP]
	internal void RpcSendAddOrRemovePlayerRoomInventoryResultToPlayer(Guid KBIKPAMBBCL, int FAKHJBCPGHO, long EFHCOKOABIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x8D6D870", Offset = "0x8D6BE70", VA = "0x188D6D870")]
	private void FECKDFLEOCC(bool EHGAKGFIEHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x8D71A80", Offset = "0x8D70080", VA = "0x188D71A80")]
	[FPDADGGBBPP]
	private void RpcOnNotifiedOfSortingTabIsEnabledToggled(bool DDLDFLICLAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x8D71290", Offset = "0x8D6F890", VA = "0x188D71290")]
	private void PKPIJHNKIED(List<JJNEJFACBPF> CDJEPCBALKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x8D718D0", Offset = "0x8D6FED0", VA = "0x188D718D0")]
	[FPDADGGBBPP]
	private void RpcOnNotifiedOfRoomInventoryTagUpdates(string DMBILMGPPNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x8D6D700", Offset = "0x8D6BD00", VA = "0x188D6D700")]
	private void FCDPEAGOLKH(long NALIEDCLPFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x8D71860", Offset = "0x8D6FE60", VA = "0x188D71860")]
	[FPDADGGBBPP]
	private void RpcOnNotifiedOfRoomInventoryTagDeleted(long NALIEDCLPFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x8D6B780", Offset = "0x8D69D80", VA = "0x188D6B780")]
	private OOODIGLCBPD BECOIAELIJN(APPKKLFKBDG FJBNDOOPLMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x8D6E280", Offset = "0x8D6C880", VA = "0x188D6E280")]
	private List<DBKLPHJCAEE> FPEPGMOEIBO(List<JJNEJFACBPF> CDJEPCBALKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x8D6DF30", Offset = "0x8D6C530", VA = "0x188D6DF30")]
	private List<DBKLPHJCAEE> FLNMIOJCKKP(IEnumerable<JJNEJFACBPF> CDJEPCBALKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x8D6BE40", Offset = "0x8D6A440", VA = "0x188D6BE40", Slot = "36")]
	public RoomInventoryItemProperties CFLKGBMPAFJ(string MMBIDCFHPEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x8D6E5F0", Offset = "0x8D6CBF0", VA = "0x188D6E5F0")]
	private OOODIGLCBPD GFJENJGEBKG(APPKKLFKBDG FJBNDOOPLMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x8D6B3E0", Offset = "0x8D699E0", VA = "0x188D6B3E0", Slot = "35")]
	public APPKKLFKBDG AEHJBKBBNMM(OOODIGLCBPD JBEKOKJBODB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x8D6EC10", Offset = "0x8D6D210", VA = "0x188D6EC10")]
	private DBKLPHJCAEE IPKHNPOFFKJ(JJNEJFACBPF FJBNDOOPLMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x8D6D050", Offset = "0x8D6B650", VA = "0x188D6D050")]
	private void EJABNIALPBI(PKCCCJLJCIK LILAFPOFAMK, int PHCLECNOGMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x8D6E790", Offset = "0x8D6CD90", VA = "0x188D6E790")]
	private void HMHCPDMOOKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x8D6DB30", Offset = "0x8D6C130", VA = "0x188D6DB30")]
	private Task FIINENFIELH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x8D6E940", Offset = "0x8D6CF40", VA = "0x188D6E940")]
	private void HNMOLIADBBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x8D6C700", Offset = "0x8D6AD00", VA = "0x188D6C700")]
	private void DCLLKKPDCID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x8D6B520", Offset = "0x8D69B20", VA = "0x188D6B520")]
	private void AINPPCAPNKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x8D70CB0", Offset = "0x8D6F2B0", VA = "0x188D70CB0")]
	[AsyncStateMachine(typeof(EPIBFMPMMCG))]
	private Task OOLPJCIPDAB(OOODIGLCBPD JILLNAEJPCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x8D70C90", Offset = "0x8D6F290", VA = "0x188D70C90")]
	[CompilerGenerated]
	private void OLAOHPIJOEK(Task<TaskStatus> DIAHJIAKEPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x8D6B9F0", Offset = "0x8D69FF0", VA = "0x188D6B9F0")]
	[CompilerGenerated]
	private Task<AKIGLGGMAFG> BJABMMMGBNM(HJCIADOPBIO P_0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x8D701D0", Offset = "0x8D6E7D0", VA = "0x188D701D0")]
	[CompilerGenerated]
	internal static Dictionary<ENFEMCDOING, DEOIBONDKHH> NJHCEIFOPMH(AKIGLGGMAFG FAKHJBCPGHO, FELDKGNEGKM P_1)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class KBDIGLODFMP : Dictionary<string, RoomInventoryItemProperties>
{
	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x8D63F70", Offset = "0x8D62570", VA = "0x188D63F70")]
	public KBDIGLODFMP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface APIHPADIELE
{
	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LABKABHHDOJ BAHFDHOHDHM();

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	KBDIGLODFMP JGOBMNPNMHN();

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	KCOOEGJEHHL NMBLLKKMCOJ();
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class ILDOGOIADIJ : APIHPADIELE
{
	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x8D61930", Offset = "0x8D5FF30", VA = "0x188D61930")]
	[EGNICHGEFDG.FKEMGOBKAHC.CJJMBHGCOLI]
	internal static void KHFEDOGILIL(NMNJFHODGJA JBBCAANONNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	[RecRoom.NoEngine.Common.Preserve]
	public ILDOGOIADIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x8D617B0", Offset = "0x8D5FDB0", VA = "0x188D617B0", Slot = "4")]
	public LABKABHHDOJ BAHFDHOHDHM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x8D618C0", Offset = "0x8D5FEC0", VA = "0x188D618C0", Slot = "5")]
	public KBDIGLODFMP JGOBMNPNMHN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x8D619A0", Offset = "0x8D5FFA0", VA = "0x188D619A0", Slot = "6")]
	public KCOOEGJEHHL NMBLLKKMCOJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class KCOOEGJEHHL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly Dictionary<long, DBKLPHJCAEE> DAGAPICMIBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private readonly DBKLPHJCAEE[] NKNOOLCKLJI;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool MBHDGKGGIOA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0xAFE8C0", Offset = "0xAFCEC0", VA = "0x180AFE8C0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0xB82B90", Offset = "0xB81190", VA = "0x180B82B90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int PNBKBOPLKEF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x8D64450", Offset = "0x8D62A50", VA = "0x188D64450")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	private long KJAJMKCMKII
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xAA55A0", Offset = "0xAA3BA0", VA = "0x180AA55A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x8D644B0", Offset = "0x8D62AB0", VA = "0x188D644B0")]
	public void FLAIMHDCCGN(long DDLHEHAKJGF, IEnumerable<DBKLPHJCAEE> GFELOCNKDDG, bool LDFCEAGGEIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x8D64F50", Offset = "0x8D63550", VA = "0x188D64F50")]
	public IReadOnlyList<DBKLPHJCAEE> ODAJBIMHNEE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0xB82B90", Offset = "0xB81190", VA = "0x180B82B90")]
	public void FBHKAOHKAOH(bool EHGAKGFIEHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x8D63FB0", Offset = "0x8D625B0", VA = "0x188D63FB0")]
	public bool AKCGABMMKPB(long NALIEDCLPFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x8D64D90", Offset = "0x8D63390", VA = "0x188D64D90")]
	public bool MKPENEOPLAO(DBKLPHJCAEE ILCJFBMKOOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x8D64A70", Offset = "0x8D63070", VA = "0x188D64A70")]
	public bool IDHJIKICCDF(List<DBKLPHJCAEE> AJAEKKCJHBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x8D64970", Offset = "0x8D62F70", VA = "0x188D64970")]
	public bool GNFBHFBDBHI(long NALIEDCLPFA, [Out] DBKLPHJCAEE PEIEJMGOHLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x8D642A0", Offset = "0x8D628A0", VA = "0x188D642A0")]
	public bool CDKIBOLNCON(string NDIENANOGEK, [Out] DBKLPHJCAEE PEIEJMGOHLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x8D641D0", Offset = "0x8D627D0", VA = "0x188D641D0")]
	public List<DBKLPHJCAEE> BJNCHKIAEAM(int PMIGBJGNLLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x8D64090", Offset = "0x8D62690", VA = "0x188D64090")]
	public List<DBKLPHJCAEE> BIKLDMEKGHE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x72F1410", Offset = "0x72EFA10", VA = "0x1872F1410")]
	public DBKLPHJCAEE LFENHBJNHCK(int PMIGBJGNLLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x8D64A10", Offset = "0x8D63010", VA = "0x188D64A10")]
	public IReadOnlyList<DBKLPHJCAEE> HLOEGCMOIFI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x8D65100", Offset = "0x8D63700", VA = "0x188D65100")]
	public KCOOEGJEHHL()
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
