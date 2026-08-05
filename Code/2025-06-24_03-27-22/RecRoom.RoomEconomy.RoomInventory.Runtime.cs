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
		[Cpp2IlInjected.Address(RVA = "0x85ED380", Offset = "0x85EBF80", VA = "0x1885ED380", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x27CE7F0", Offset = "0x27CD3F0", VA = "0x1827CE7F0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface LHAEFBLJOIP : GJIKNNHIOKP
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	HHFGHOMMNCG HMFPAIPHGJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[DefaultMember("Item")]
public class GPFJMDLJAGI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly Dictionary<Guid, BAOMAEMIGFM> CCCJPKCNELE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly Dictionary<string, BAOMAEMIGFM> AJEGCIGMHFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private bool? APMCKMMEKBJ;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private long PAKBEKGHOMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA24640", Offset = "0xA23240", VA = "0x180A24640")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public BAOMAEMIGFM HHFPMPGGMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x85E07B0", Offset = "0x85DF3B0", VA = "0x1885E07B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x85E0A00", Offset = "0x85DF600", VA = "0x1885E0A00")]
	public void NPNNKAIMHMM(long JKJNCHGDMGL, IEnumerable<LPACJBIKOCG> OKNOMGLOIBH, IEnumerable<CLOOIGHANAN> FNJJINJOLOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x85DFCC0", Offset = "0x85DE8C0", VA = "0x1885DFCC0")]
	public bool ACGBFIOIKPM(Guid BMFFGEKEBGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x85E04C0", Offset = "0x85DF0C0", VA = "0x1885E04C0")]
	public bool HMCNGGMNMHK(Guid BMFFGEKEBGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x85E11B0", Offset = "0x85DFDB0", VA = "0x1885E11B0")]
	public bool PMKGFNELIIA(LPACJBIKOCG GBAADDMCPJO, [Out] LPACJBIKOCG KDPEFPEEMOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x85E09B0", Offset = "0x85DF5B0", VA = "0x1885E09B0")]
	public IEnumerable<BAOMAEMIGFM> NAECNGNNGLP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x85DFDD0", Offset = "0x85DE9D0", VA = "0x1885DFDD0")]
	public IEnumerable<LPACJBIKOCG> BMIAHGJIJKF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x85E1070", Offset = "0x85DFC70", VA = "0x1885E1070")]
	public IEnumerable<CLOOIGHANAN> OGABHGHOFFO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x85E0900", Offset = "0x85DF500", VA = "0x1885E0900")]
	public bool MNDJGAGGCFI(Guid BMFFGEKEBGJ, [Out] LPACJBIKOCG PELMIOLCCEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x85E0130", Offset = "0x85DED30", VA = "0x1885E0130")]
	public bool GAHHJEEDEBC(string JFGJJFJLNNK, [Out] LPACJBIKOCG PELMIOLCCEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x85DFD20", Offset = "0x85DE920", VA = "0x1885DFD20")]
	public bool BFKABCKFAHB(Guid BMFFGEKEBGJ, [Out] CLOOIGHANAN NBIGLNEIPOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x85E01D0", Offset = "0x85DEDD0", VA = "0x1885E01D0")]
	public bool GLLHPMKHKCJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x85E0730", Offset = "0x85DF330", VA = "0x1885E0730")]
	private bool IFLOECHFKLD(LPACJBIKOCG LFLPFMMDGLM, LPACJBIKOCG FHLOHBNEJIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x85E0270", Offset = "0x85DEE70", VA = "0x1885E0270")]
	private void HJPAGICDCBN(Guid EMMACFPOKFB, BAOMAEMIGFM KFODEJKFNAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x85E04E0", Offset = "0x85DF0E0", VA = "0x1885E04E0")]
	private bool IDDIBIOHFLB(Guid EMMACFPOKFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x85E0810", Offset = "0x85DF410", VA = "0x1885E0810")]
	private void LIFBBLNDDKG(LPACJBIKOCG ACJNMPFKOEC, [Optional] LPACJBIKOCG NBOJPCBHHNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x85DFF50", Offset = "0x85DEB50", VA = "0x1885DFF50")]
	private bool FMCADNKNAIM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x85DFF10", Offset = "0x85DEB10", VA = "0x1885DFF10")]
	private static bool FDOMCCHDCMJ(LPACJBIKOCG ONKLOOMCJOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x85E13E0", Offset = "0x85DFFE0", VA = "0x1885E13E0")]
	public GPFJMDLJAGI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class HHFGHOMMNCG : DANMLDGLMDF, IPDJKJLBCFN, IDisposable, KMNPOEKIMFF
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private struct OIMPALIIPEE : IEquatable<OIMPALIIPEE>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public long PAKBEKGHOMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public Guid CBIOKKNGCHJ;

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x52744A0", Offset = "0x52730A0", VA = "0x1852744A0")]
		public OIMPALIIPEE(long JKJNCHGDMGL, Guid BMFFGEKEBGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x85ECA70", Offset = "0x85EB670", VA = "0x1885ECA70", Slot = "4")]
		public bool Equals(OIMPALIIPEE GMNGNCHKEBK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x85EC910", Offset = "0x85EB510", VA = "0x1885EC910", Slot = "0")]
		public override bool Equals(object KDKJDFFGNJJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x85ECB70", Offset = "0x85EB770", VA = "0x1885ECB70", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct LKCINKPFEPA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public AsyncTaskMethodBuilder<MDDPJNIIBBI<LPACJBIKOCG, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public HHFGHOMMNCG <>4__this;

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
		public List<IJFGFFFBAIM> newTags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public bool allowRename;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private TaskAwaiter<FGHPMEFECDA<AIJGIKBKOMO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x85EB6A0", Offset = "0x85EA2A0", VA = "0x1885EB6A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x85EBBB0", Offset = "0x85EA7B0", VA = "0x1885EBBB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct AKGPDOHIJJD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncTaskMethodBuilder<MDDPJNIIBBI<LPACJBIKOCG, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public HHFGHOMMNCG <>4__this;

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
		private TaskAwaiter<FGHPMEFECDA<AIJGIKBKOMO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x85DAED0", Offset = "0x85D9AD0", VA = "0x1885DAED0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x85DB720", Offset = "0x85DA320", VA = "0x1885DB720", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct ININHIHHCCG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public AsyncTaskMethodBuilder<MDDPJNIIBBI<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public HHFGHOMMNCG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private LPACJBIKOCG <itemToDelete>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private GMNOLBMCLHL <result>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private TaskAwaiter<GMNOLBMCLHL> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x85EA1A0", Offset = "0x85E8DA0", VA = "0x1885EA1A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x85EA9B0", Offset = "0x85E95B0", VA = "0x1885EA9B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct HMLJNGNHEKE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public HHFGHOMMNCG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public BJCCECIKIFB player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private TaskAwaiter<int> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x85E9DB0", Offset = "0x85E89B0", VA = "0x1885E9DB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x85EA130", Offset = "0x85E8D30", VA = "0x1885EA130", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct ACJAJGONIPP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public AsyncTaskMethodBuilder<LFMNGOHGFBP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public HHFGHOMMNCG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public BJCCECIKIFB recipient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public int quantity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private TaskAwaiter<LFMNGOHGFBP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x85D97F0", Offset = "0x85D83F0", VA = "0x1885D97F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x85D9C50", Offset = "0x85D8850", VA = "0x1885D9C50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct ANNILLBJMFN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public AsyncTaskMethodBuilder<MDDPJNIIBBI<PPILCDEIOKE, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public HHFGHOMMNCG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public long tagId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public RoomInventoryTagClientProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private PPILCDEIOKE <newTag>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private TaskAwaiter<TaskStatus> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x85DB790", Offset = "0x85DA390", VA = "0x1885DB790", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x85DBC10", Offset = "0x85DA810", VA = "0x1885DBC10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct KNJNKMIHGIE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public AsyncTaskMethodBuilder<MDDPJNIIBBI<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public HHFGHOMMNCG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public long tagId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private List<PPILCDEIOKE>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private TaskAwaiter<MDDPJNIIBBI<PPILCDEIOKE, string>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private TaskAwaiter<GMNOLBMCLHL> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x85EAA20", Offset = "0x85E9620", VA = "0x1885EAA20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x85EB630", Offset = "0x85EA230", VA = "0x1885EB630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct GAPHEJHDOGM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public AsyncTaskMethodBuilder<MDDPJNIIBBI<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public HHFGHOMMNCG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public bool isEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private TaskAwaiter<GMNOLBMCLHL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x85DE670", Offset = "0x85DD270", VA = "0x1885DE670", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x85DEB90", Offset = "0x85DD790", VA = "0x1885DEB90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct BEIEIMAIGEA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public AsyncTaskMethodBuilder<Dictionary<long, IJFGFFFBAIM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public Dictionary<long, int> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public HHFGHOMMNCG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private TaskAwaiter<FGHPMEFECDA<List<IJFGFFFBAIM>>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x85DBC80", Offset = "0x85DA880", VA = "0x1885DBC80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x85DC6B0", Offset = "0x85DB2B0", VA = "0x1885DC6B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct OCGINJFFDJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public HHFGHOMMNCG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public CLOOIGHANAN playerRoomInventoryItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public int quantity;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct OODKBIHPCDC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public AsyncTaskMethodBuilder<LFMNGOHGFBP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public HHFGHOMMNCG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public int quantity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private OCGINJFFDJL <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public BJCCECIKIFB awardingPlayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public Guid remoteOperationId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private TaskAwaiter<DCNAIOCEDNO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x85ECBF0", Offset = "0x85EB7F0", VA = "0x1885ECBF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x85ED040", Offset = "0x85EBC40", VA = "0x1885ED040", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private struct KJFMBGIIEHC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public Dictionary<OIMPALIIPEE, int> idsAndQuantities;
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class OPKJJDDEEBK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public DCNAIOCEDNO result;

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public OPKJJDDEEBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x85ED0B0", Offset = "0x85EBCB0", VA = "0x1885ED0B0")]
		internal IBMNHCBMCFA AHMCANIJHLG(OIMPALIIPEE id)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct GDEABMEACJE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public AsyncTaskMethodBuilder<Dictionary<OIMPALIIPEE, IBMNHCBMCFA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public Dictionary<OIMPALIIPEE, int> idsAndQuantities;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public HHFGHOMMNCG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private KJFMBGIIEHC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private TaskAwaiter<List<IBMNHCBMCFA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x85DEC00", Offset = "0x85DD800", VA = "0x1885DEC00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x85DF6B0", Offset = "0x85DE2B0", VA = "0x1885DF6B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct HFMPOJDGAAB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public AsyncTaskMethodBuilder<List<IBMNHCBMCFA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public Dictionary<OIMPALIIPEE, int> idsAndQuantities;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public HHFGHOMMNCG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private List<IBMNHCBMCFA> <results>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private int <attemptNumber>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private TaskAwaiter<List<IBMNHCBMCFA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x85E14C0", Offset = "0x85E00C0", VA = "0x1885E14C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x85E2420", Offset = "0x85E1020", VA = "0x1885E2420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct DGGNGIFBCHC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public HHFGHOMMNCG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private Task<List<AIJGIKBKOMO>> <roomInventoryTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private Task<List<PDDGPOPHPGK>> <playerRoomInventoryTask>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private Task<List<IJFGFFFBAIM>> <roomInventoryTagsTask>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private Task<PKFKFPAJEMG> <roomConfigsTask>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private IEnumerable<LPACJBIKOCG> <roomInventoryItems>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private IEnumerable<CLOOIGHANAN> <playerRoomInventoryItems>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private List<PPILCDEIOKE> <roomInventoryTags>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private TaskAwaiter<List<AIJGIKBKOMO>> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private TaskAwaiter<List<PDDGPOPHPGK>> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private TaskAwaiter<List<IJFGFFFBAIM>> <>u__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private TaskAwaiter<PKFKFPAJEMG> <>u__5;

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x85DCC90", Offset = "0x85DB890", VA = "0x1885DCC90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x85DDF20", Offset = "0x85DCB20", VA = "0x1885DDF20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private struct EIMCDAIBENJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public HHFGHOMMNCG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private TaskAwaiter<Task> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x85DDF80", Offset = "0x85DCB80", VA = "0x1885DDF80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x85DE610", Offset = "0x85DD210", VA = "0x1885DE610", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private struct GJMHHABGKME : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public HHFGHOMMNCG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public BJCCECIKIFB player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private TaskAwaiter<int> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x85DF760", Offset = "0x85DE360", VA = "0x1885DF760", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x85DFC50", Offset = "0x85DE850", VA = "0x1885DFC50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private struct CFIEBACMMAA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public AsyncTaskMethodBuilder<LFMNGOHGFBP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public HHFGHOMMNCG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public BJCCECIKIFB player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public int quantity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private TaskAwaiter<LFMNGOHGFBP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x85DC720", Offset = "0x85DB320", VA = "0x1885DC720", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x85DCC20", Offset = "0x85DB820", VA = "0x1885DCC20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private struct NOMJPOKHDOP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public LPACJBIKOCG itemToDelete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public HHFGHOMMNCG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private Dictionary<long, bool>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private TaskAwaiter<MDDPJNIIBBI<bool, string>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x85EBF00", Offset = "0x85EAB00", VA = "0x1885EBF00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x85EC8B0", Offset = "0x85EB4B0", VA = "0x1885EC8B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly TimeSpan JENEMOGDMPF;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private const float PGHILAFJFID = 10f;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private const float DIGAJHAPDPD = 3f;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal const int BGCONFGGLHB = 3;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	internal const string ECLJDOHBGIJ = "econ_room_inventory_gate";

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	internal const string GMDHKFNGHEL = "experiences_room_inventory_tags_gate";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly BKOJGMCIJOC BPEDAEHLABH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly FPOMFNDMKKF IBIBKHLMHCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly OHEHODJEPDD DDAEDILAJAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly KAHDDFIODAM ACNBOJPOFGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly BHBKAOHPBKK AHGAKCIMJPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly LHAEFBLJOIP AHJNHAOBMPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly AHEAEJOKBNI BKHLAMDGECL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly ELKCKADMKBB FNECCOEGIML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly NFGJHGBPOHN BMNBJLFOKLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly GPFJMDLJAGI EFMCBHEFCDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly AGMGCNJAKAP ABOOIJKDCBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly GJENPKGAAKD DBHBAELGGFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly CancellationTokenSource DBINMCLOPGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly DLFKKEEKONA<OIMPALIIPEE, IBMNHCBMCFA> DNABBLFMPFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly DLFKKEEKONA<long, IJFGFFFBAIM> HADPJMHNBGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly AOPFHIJAPGH HCHFJJKJKAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly IDisposable IHCKHMHDJFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private Task HCEJACLBHPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private CancellationTokenSource DCCGCJKFCJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private long FLPHAIHFIPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private bool HPDIEOLMMOM;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private GJAPKLOLFLN JMDMDFHNKAF
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x85E5D80", Offset = "0x85E4980", VA = "0x1885E5D80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public HBAAEHCBNNO LKOFJHFPJEC
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xAC42F0", Offset = "0xAC2EF0", VA = "0x180AC42F0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xAC4320", Offset = "0xAC2F20", VA = "0x180AC4320", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public PJAJEBBNNBK<LPACJBIKOCG> FMEHAFIFHNO
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xA9A050", Offset = "0xA98C50", VA = "0x180A9A050", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xAC4300", Offset = "0xAC2F00", VA = "0x180AC4300", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public PJAJEBBNNBK<Guid> FLOHOLMCHHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xA9A0D0", Offset = "0xA98CD0", VA = "0x180A9A0D0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xA9A010", Offset = "0xA98C10", VA = "0x180A9A010", Slot = "9")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public BICCMPNJHAK<CLOOIGHANAN, int> KHILMONOBPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xA86340", Offset = "0xA84F40", VA = "0x180A86340", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xA85A60", Offset = "0xA84660", VA = "0x180A85A60", Slot = "11")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public PJAJEBBNNBK<PPILCDEIOKE> LLPPCFEKHIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xA2A510", Offset = "0xA29110", VA = "0x180A2A510", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xA2A4B0", Offset = "0xA290B0", VA = "0x180A2A4B0", Slot = "13")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public PJAJEBBNNBK<long> KEGNHPKEIMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xA86350", Offset = "0xA84F50", VA = "0x180A86350", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xA85F40", Offset = "0xA84B40", VA = "0x180A85F40", Slot = "15")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public HBAAEHCBNNO LJBHBOCFFDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xA8C600", Offset = "0xA8B200", VA = "0x180A8C600", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xA8CF30", Offset = "0xA8BB30", VA = "0x180A8CF30", Slot = "17")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public HBAAEHCBNNO LJHCMKLKNIH
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xA8C610", Offset = "0xA8B210", VA = "0x180A8C610", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xB50730", Offset = "0xB4F330", VA = "0x180B50730", Slot = "19")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x85E8640", Offset = "0x85E7240", VA = "0x1885E8640")]
	[IGNGJLOKDFM.CHOHDINDLHJ.JBEAKNHCNNG]
	internal static void OMKCNNEBHOD(PFGPAPHADOM MHCMGFKMEEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x85E9230", Offset = "0x85E7E30", VA = "0x1885E9230")]
	[RecRoom.NoEngine.Common.Preserve]
	public HHFGHOMMNCG([GFNPNOLPMKK(null)] BKOJGMCIJOC BPEDAEHLABH, [GFNPNOLPMKK(null)] FPOMFNDMKKF IBIBKHLMHCC, [GFNPNOLPMKK(null)] OHEHODJEPDD DDAEDILAJAD, [GFNPNOLPMKK(null)] KAHDDFIODAM ACNBOJPOFGO, [GFNPNOLPMKK(null)] PPDHIJNIFFF IKNMBFJPHDE, [GFNPNOLPMKK(null)] BHBKAOHPBKK AHGAKCIMJPD, [GFNPNOLPMKK(null)] LHAEFBLJOIP AHJNHAOBMPO, [GFNPNOLPMKK(null)] KDFCOCHKBIK DAGGFFCOOJP, [GFNPNOLPMKK(null)] IFBHIHCLBJA KPIDMAMHHFG, [GFNPNOLPMKK(null)] AHEAEJOKBNI BKHLAMDGECL, [GFNPNOLPMKK(null)] ELKCKADMKBB FNECCOEGIML, [GFNPNOLPMKK(null)] NFGJHGBPOHN BMNBJLFOKLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x85E4620", Offset = "0x85E3220", VA = "0x1885E4620", Slot = "53")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x85E7170", Offset = "0x85E5D70", VA = "0x1885E7170", Slot = "52")]
	public Task MIHEPDLKPGO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x85E52E0", Offset = "0x85E3EE0", VA = "0x1885E52E0", Slot = "20")]
	[AsyncStateMachine(typeof(LKCINKPFEPA))]
	public Task<MDDPJNIIBBI<LPACJBIKOCG, string>> FEADPFKGKGG(Guid? LFJGGIIPHOD, long JKJNCHGDMGL, string LAOCJKNALFF, string NFKNKHBBLBH, string PJOILBBKCNO, RoomInventoryItemProperties JBCEKMOHDPK, byte DAAJJNMMALF, int GCKOLKABAJC, [Optional] List<long> CHJKEHFENAJ, [Optional] List<IJFGFFFBAIM> PPKMKBEKAHK, bool EICPJEALOFL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x85E4950", Offset = "0x85E3550", VA = "0x1885E4950", Slot = "21")]
	[AsyncStateMachine(typeof(AKGPDOHIJJD))]
	public Task<MDDPJNIIBBI<LPACJBIKOCG, string>> EHGEJNMHFPG(Guid BMFFGEKEBGJ, long JKJNCHGDMGL, [Optional] string LAOCJKNALFF, [Optional] string NFKNKHBBLBH, [Optional] string PJOILBBKCNO, [Optional] List<long> CHJKEHFENAJ, [Optional] Dictionary<string, RoomInventoryTagClientProperties> PPKMKBEKAHK, [Optional] RoomInventoryItemProperties JBCEKMOHDPK, [Optional] byte? DAAJJNMMALF, [Optional] int? GCKOLKABAJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x85E7E00", Offset = "0x85E6A00", VA = "0x1885E7E00", Slot = "22")]
	[AsyncStateMachine(typeof(ININHIHHCCG))]
	public Task<MDDPJNIIBBI<bool, string>> NNLCBLMGLCI(Guid BMFFGEKEBGJ, long JKJNCHGDMGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x85E87F0", Offset = "0x85E73F0", VA = "0x1885E87F0", Slot = "23")]
	public IReadOnlyList<LPACJBIKOCG> PJODCMOMODH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x85E8390", Offset = "0x85E6F90", VA = "0x1885E8390", Slot = "24")]
	public IReadOnlyList<LPACJBIKOCG> OIMIFHFNILB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x85E7070", Offset = "0x85E5C70", VA = "0x1885E7070", Slot = "25")]
	public bool MGLIEBJLHFJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x85E7390", Offset = "0x85E5F90", VA = "0x1885E7390", Slot = "26")]
	public bool MNDJGAGGCFI(Guid BMFFGEKEBGJ, [Out] LPACJBIKOCG PELMIOLCCEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x85E5C60", Offset = "0x85E4860", VA = "0x1885E5C60", Slot = "27")]
	public bool GAHHJEEDEBC(string GOPDMIIPKDO, [Out] LPACJBIKOCG PELMIOLCCEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x85E79D0", Offset = "0x85E65D0", VA = "0x1885E79D0", Slot = "28")]
	public IReadOnlyList<CLOOIGHANAN> NDFGJPFIAPH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x85E2BB0", Offset = "0x85E17B0", VA = "0x1885E2BB0", Slot = "29")]
	public bool BFKABCKFAHB(Guid BMFFGEKEBGJ, [Out] CLOOIGHANAN NBIGLNEIPOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x85E4B10", Offset = "0x85E3710", VA = "0x1885E4B10", Slot = "30")]
	public long? EKINNEDACLG(Guid BMFFGEKEBGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x85E58D0", Offset = "0x85E44D0", VA = "0x1885E58D0", Slot = "51")]
	public void FIKHPOILPBI(IEnumerable<PDDGPOPHPGK> FNJJINJOLOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x85E31B0", Offset = "0x85E1DB0", VA = "0x1885E31B0", Slot = "31")]
	[AsyncStateMachine(typeof(HMLJNGNHEKE))]
	public Task<int> BLBPGMMNFHL(BJCCECIKIFB NEOGODNGJJE, Guid BMFFGEKEBGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x85E4DC0", Offset = "0x85E39C0", VA = "0x1885E4DC0", Slot = "32")]
	[AsyncStateMachine(typeof(ACJAJGONIPP))]
	public Task<LFMNGOHGFBP> ENMDJNLNKBD(BJCCECIKIFB MIIGAPBBILG, Guid BMFFGEKEBGJ, int KCCIFDBLGOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x85E5DD0", Offset = "0x85E49D0", VA = "0x1885E5DD0", Slot = "33")]
	public string HDONEPNBPLG(DCNAIOCEDNO DBJBIPJCIKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x85E8780", Offset = "0x85E7380", VA = "0x1885E8780", Slot = "34")]
	public bool PIDHGCIAGIJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x85E3E80", Offset = "0x85E2A80", VA = "0x1885E3E80", Slot = "38")]
	[AsyncStateMachine(typeof(ANNILLBJMFN))]
	public Task<MDDPJNIIBBI<PPILCDEIOKE, string>> CPIOELDGECL(long KMPFOKILEFG, RoomInventoryTagClientProperties JBCEKMOHDPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x85E4500", Offset = "0x85E3100", VA = "0x1885E4500", Slot = "39")]
	[AsyncStateMachine(typeof(KNJNKMIHGIE))]
	public Task<MDDPJNIIBBI<bool, string>> DPOOIBMOPDF(long KMPFOKILEFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x85E6890", Offset = "0x85E5490", VA = "0x1885E6890", Slot = "42")]
	public List<(long, int)> JPDHJHLHCML(long BIAPDGOGHCD, int KODPJDLEDNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x85E2B20", Offset = "0x85E1720", VA = "0x1885E2B20", Slot = "43")]
	public bool APOJKLOMLKC(long KMPFOKILEFG, [Out] PPILCDEIOKE LOIABIMJAEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x85E7BB0", Offset = "0x85E67B0", VA = "0x1885E7BB0", Slot = "44")]
	public bool NFHPEJOHJPA(string CMOCKOGCDGG, [Out] PPILCDEIOKE LOIABIMJAEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x85E77D0", Offset = "0x85E63D0", VA = "0x1885E77D0", Slot = "45")]
	public bool NCCPIMPPGFI(long KMPFOKILEFG, Guid OKHMGBHOOHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x85E86B0", Offset = "0x85E72B0", VA = "0x1885E86B0", Slot = "46")]
	public IReadOnlyList<PPILCDEIOKE> PAAFNDFCKOB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x85E42B0", Offset = "0x85E2EB0", VA = "0x1885E42B0", Slot = "47")]
	public List<PPILCDEIOKE> DKNFNGJLHNJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x85E2490", Offset = "0x85E1090", VA = "0x1885E2490", Slot = "48")]
	public IReadOnlyList<PPILCDEIOKE> ADADCMKLCDE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x85E2CE0", Offset = "0x85E18E0", VA = "0x1885E2CE0", Slot = "41")]
	public bool BFNPEICDOPG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x85E2840", Offset = "0x85E1440", VA = "0x1885E2840", Slot = "49")]
	public IReadOnlyList<LPACJBIKOCG> APBOAODIEDE(long KMPFOKILEFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x85E4CA0", Offset = "0x85E38A0", VA = "0x1885E4CA0", Slot = "40")]
	[AsyncStateMachine(typeof(GAPHEJHDOGM))]
	public Task<MDDPJNIIBBI<bool, string>> EMGBHCALDEI(long JKJNCHGDMGL, bool BBEABHHBLEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x85E5FA0", Offset = "0x85E4BA0", VA = "0x1885E5FA0", Slot = "54")]
	public bool HLGHGGPDLIO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x85E63E0", Offset = "0x85E4FE0", VA = "0x1885E63E0", Slot = "50")]
	public bool INGNAJBLNAJ(string CMOCKOGCDGG, [Out] IReadOnlyList<LPACJBIKOCG> FCHOLMIONBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x85E7690", Offset = "0x85E6290", VA = "0x1885E7690")]
	[AsyncStateMachine(typeof(BEIEIMAIGEA))]
	private Task<Dictionary<long, IJFGFFFBAIM>> MPBDNKNKCKJ(Dictionary<long, int> MEDKCOHHKEH, CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x85E6E90", Offset = "0x85E5A90", VA = "0x1885E6E90")]
	[AsyncStateMachine(typeof(OODKBIHPCDC))]
	private Task<LFMNGOHGFBP> LHPEDOFGHDG(Guid BMFFGEKEBGJ, int KCCIFDBLGOI, [Optional] Guid DHPBDPIKEOP, [Optional] BJCCECIKIFB JDKBDAMGGJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x85E6160", Offset = "0x85E4D60", VA = "0x1885E6160")]
	[AsyncStateMachine(typeof(GDEABMEACJE))]
	private Task<Dictionary<OIMPALIIPEE, IBMNHCBMCFA>> IIENIKGBOGA(Dictionary<OIMPALIIPEE, int> IDCGHKKLBLL, CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x85E62A0", Offset = "0x85E4EA0", VA = "0x1885E62A0")]
	[AsyncStateMachine(typeof(HFMPOJDGAAB))]
	private Task<List<IBMNHCBMCFA>> IIKHFGHCMJD(Dictionary<OIMPALIIPEE, int> IDCGHKKLBLL, CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x85E88A0", Offset = "0x85E74A0", VA = "0x1885E88A0")]
	[AsyncStateMachine(typeof(DGGNGIFBCHC))]
	private Task PKOBAIKGADO(long JKJNCHGDMGL, CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x85E2D60", Offset = "0x85E1960", VA = "0x1885E2D60")]
	private Task BGCIMHLNLAD(KGGEOPPOKLC FABPHEFJGGN, CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x85E6B70", Offset = "0x85E5770", VA = "0x1885E6B70")]
	[AsyncStateMachine(typeof(EIMCDAIBENJ))]
	private Task JPHEEANCNEN(KGGEOPPOKLC FABPHEFJGGN, CancellationToken ILPOOHPAJGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x85E4F10", Offset = "0x85E3B10", VA = "0x1885E4F10")]
	private void FAFBKDHKHBA(AIJGIKBKOMO FAFKNMGMBCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x85E8D10", Offset = "0x85E7910", VA = "0x1885E8D10")]
	[CHIJNBOPIHK]
	private void RpcOnNotifiedOfRoomInventoryItemCreatedOrUpdated(string EAOJIOBHIAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x85E7210", Offset = "0x85E5E10", VA = "0x1885E7210")]
	private void MKFGGJEELPK(Guid BMFFGEKEBGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x85E8E50", Offset = "0x85E7A50", VA = "0x1885E8E50")]
	[CHIJNBOPIHK]
	private void RpcOnNotifiedOfRoomInventoryItemDeleted(Guid BMFFGEKEBGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x85E51A0", Offset = "0x85E3DA0", VA = "0x1885E51A0")]
	[AsyncStateMachine(typeof(GJMHHABGKME))]
	private Task<int> FCIBNIBDKEA(BJCCECIKIFB NEOGODNGJJE, Guid BMFFGEKEBGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x85E8B20", Offset = "0x85E7720", VA = "0x1885E8B20")]
	[CHIJNBOPIHK]
	internal void RpcGetPlayerRoomInventoryCount(Guid DIPCJMNHKDB, Guid BMFFGEKEBGJ, ALHJKKHMHIP JGFKHBPEKHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x85E8AA0", Offset = "0x85E76A0", VA = "0x1885E8AA0")]
	[CHIJNBOPIHK]
	internal void RpcGetPlayerRoomInventoryCountResponse(Guid DIPCJMNHKDB, int DPOOEAFKIHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x85E6010", Offset = "0x85E4C10", VA = "0x1885E6010")]
	[AsyncStateMachine(typeof(CFIEBACMMAA))]
	private Task<LFMNGOHGFBP> HNDOHFONMIH(BJCCECIKIFB NEOGODNGJJE, Guid BMFFGEKEBGJ, int KCCIFDBLGOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x85E89D0", Offset = "0x85E75D0", VA = "0x1885E89D0")]
	[CHIJNBOPIHK]
	internal void RpcAddOrRemovePlayerRoomInventoryRequest(Guid DIPCJMNHKDB, Guid BMFFGEKEBGJ, int KCCIFDBLGOI, ALHJKKHMHIP JGFKHBPEKHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x85E4340", Offset = "0x85E2F40", VA = "0x1885E4340")]
	private void DNMMLHIEOKF(BJCCECIKIFB MIIGAPBBILG, Guid DIPCJMNHKDB, DCNAIOCEDNO DBJBIPJCIKA, long GAGNACOLJIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x85E9100", Offset = "0x85E7D00", VA = "0x1885E9100")]
	[CHIJNBOPIHK]
	internal void RpcSendAddOrRemovePlayerRoomInventoryResultToPlayer(Guid DIPCJMNHKDB, int DBJBIPJCIKA, long GAGNACOLJIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x85E36B0", Offset = "0x85E22B0", VA = "0x1885E36B0")]
	private void BPAAELJJIEG(bool BBEABHHBLEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x85E90A0", Offset = "0x85E7CA0", VA = "0x1885E90A0")]
	[CHIJNBOPIHK]
	private void RpcOnNotifiedOfSortingTabIsEnabledToggled(bool DOEKEDCHLFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x85E5B40", Offset = "0x85E4740", VA = "0x1885E5B40")]
	private void FKAMPGKEJLM(List<IJFGFFFBAIM> BBOLLPAPLFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x85E8EF0", Offset = "0x85E7AF0", VA = "0x1885E8EF0")]
	[CHIJNBOPIHK]
	private void RpcOnNotifiedOfRoomInventoryTagUpdates(string KECBKMLIACK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x85E5030", Offset = "0x85E3C30", VA = "0x1885E5030")]
	private void FBIFOMDPFFG(long KMPFOKILEFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x85E8E80", Offset = "0x85E7A80", VA = "0x1885E8E80")]
	[CHIJNBOPIHK]
	private void RpcOnNotifiedOfRoomInventoryTagDeleted(long KMPFOKILEFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x85E7F30", Offset = "0x85E6B30", VA = "0x1885E7F30")]
	private LPACJBIKOCG OAGCJKHFNIP(AIJGIKBKOMO FAFKNMGMBCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x85E74B0", Offset = "0x85E60B0", VA = "0x1885E74B0")]
	private List<PPILCDEIOKE> MNIINLCMKPI(List<IJFGFFFBAIM> BBOLLPAPLFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x85E32F0", Offset = "0x85E1EF0", VA = "0x1885E32F0")]
	private List<PPILCDEIOKE> BMCKGMJDJHE(IEnumerable<IJFGFFFBAIM> BBOLLPAPLFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x85E54A0", Offset = "0x85E40A0", VA = "0x1885E54A0", Slot = "36")]
	public RoomInventoryItemProperties FHGBAFKPCKF(string HJILONNILNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x85E3820", Offset = "0x85E2420", VA = "0x1885E3820")]
	private LPACJBIKOCG CJCHLEAMBML(AIJGIKBKOMO FAFKNMGMBCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x85E6C40", Offset = "0x85E5840", VA = "0x1885E6C40", Slot = "35")]
	public AIJGIKBKOMO KHFJAADEGAI(LPACJBIKOCG KHHBHJANMNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x85E4020", Offset = "0x85E2C20", VA = "0x1885E4020")]
	private PPILCDEIOKE DENFKLDJLEP(IJFGFFFBAIM FAFKNMGMBCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x85E3E10", Offset = "0x85E2A10", VA = "0x1885E3E10")]
	private void CPFIDCFIFJB(CLOOIGHANAN NBIGLNEIPOG, int APBIOAODJID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x85E3FB0", Offset = "0x85E2BB0", VA = "0x1885E3FB0")]
	private void CPKAKBMEODC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x85E8150", Offset = "0x85E6D50", VA = "0x1885E8150")]
	private Task ODMKEGLBJGI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x85E6FE0", Offset = "0x85E5BE0", VA = "0x1885E6FE0")]
	private void LMNELMMKDDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x85E82D0", Offset = "0x85E6ED0", VA = "0x1885E82D0")]
	private void OIKAOAKOCBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x85E6D80", Offset = "0x85E5980", VA = "0x1885E6D80")]
	private void LBBNPIBGGMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x85E4840", Offset = "0x85E3440", VA = "0x1885E4840")]
	[AsyncStateMachine(typeof(NOMJPOKHDOP))]
	private Task EFHJEBKCLIM(LPACJBIKOCG GENMMHJHFBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x85E7050", Offset = "0x85E5C50", VA = "0x1885E7050")]
	[CompilerGenerated]
	private void LNAAFINPEDI(Task<TaskStatus> NKDMFOKACBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x85E39C0", Offset = "0x85E25C0", VA = "0x1885E39C0")]
	[CompilerGenerated]
	private Task<DCNAIOCEDNO> CJCLLIEKNOI(OCGINJFFDJL P_0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x85E7C40", Offset = "0x85E6840", VA = "0x1885E7C40")]
	[CompilerGenerated]
	internal static Dictionary<OIMPALIIPEE, IBMNHCBMCFA> NLPKFGKOEDH(DCNAIOCEDNO DBJBIPJCIKA, KJFMBGIIEHC P_1)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class GJENPKGAAKD : Dictionary<string, RoomInventoryItemProperties>
{
	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x85DF720", Offset = "0x85DE320", VA = "0x1885DF720")]
	public GJENPKGAAKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface IFBHIHCLBJA
{
	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GPFJMDLJAGI MMKIDLNIMAE();

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GJENPKGAAKD GLENAEEOFLH();

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	AGMGCNJAKAP ONECFFOMPCN();
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class NMKEFOBGKAL : IFBHIHCLBJA
{
	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x85EBDA0", Offset = "0x85EA9A0", VA = "0x1885EBDA0")]
	[IGNGJLOKDFM.CHOHDINDLHJ.JBEAKNHCNNG]
	internal static void OMKCNNEBHOD(PFGPAPHADOM MHCMGFKMEEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
	[RecRoom.NoEngine.Common.Preserve]
	public NMKEFOBGKAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x85EBC90", Offset = "0x85EA890", VA = "0x1885EBC90", Slot = "4")]
	public GPFJMDLJAGI MMKIDLNIMAE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x85EBC20", Offset = "0x85EA820", VA = "0x1885EBC20", Slot = "5")]
	public GJENPKGAAKD GLENAEEOFLH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x85EBE10", Offset = "0x85EAA10", VA = "0x1885EBE10", Slot = "6")]
	public AGMGCNJAKAP ONECFFOMPCN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class AGMGCNJAKAP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly Dictionary<long, PPILCDEIOKE> KDGFPHGBLLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private readonly PPILCDEIOKE[] NNGODEJOKCK;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool OIFAGOGOFKO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0xAA8AD0", Offset = "0xAA76D0", VA = "0x180AA8AD0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0xAA8AE0", Offset = "0xAA76E0", VA = "0x180AA8AE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int CGNCDGAIIEF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x85DA950", Offset = "0x85D9550", VA = "0x1885DA950")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	private long FCFIKPIBHJA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xA24640", Offset = "0xA23240", VA = "0x180A24640")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x85DA490", Offset = "0x85D9090", VA = "0x1885DA490")]
	public void NPNNKAIMHMM(long JKJNCHGDMGL, IEnumerable<PPILCDEIOKE> FHDDDNNLNCN, bool GICNBOEIKHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x85D9D90", Offset = "0x85D8990", VA = "0x1885D9D90")]
	public IReadOnlyList<PPILCDEIOKE> BKFLONNLGAC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0xAA8AE0", Offset = "0xAA76E0", VA = "0x180AA8AE0")]
	public void GGDIPPAIKKG(bool BBEABHHBLEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x85DA0F0", Offset = "0x85D8CF0", VA = "0x1885DA0F0")]
	public bool EADHBPOHKED(long KMPFOKILEFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x85DA230", Offset = "0x85D8E30", VA = "0x1885DA230")]
	public bool JPGAIEDJJIN(PPILCDEIOKE EOENAECBAHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x85DAAF0", Offset = "0x85D96F0", VA = "0x1885DAAF0")]
	public bool PBIAMOGMKAG(List<PPILCDEIOKE> IPJABGFEOHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x85DA3F0", Offset = "0x85D8FF0", VA = "0x1885DA3F0")]
	public bool NDAPBKPEJIJ(long KMPFOKILEFG, [Out] PPILCDEIOKE GPIJFOKHGBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x85D9F40", Offset = "0x85D8B40", VA = "0x1885D9F40")]
	public bool DLPFCEBHBEB(string LAOCJKNALFF, [Out] PPILCDEIOKE GPIJFOKHGBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x85D9CC0", Offset = "0x85D88C0", VA = "0x1885D9CC0")]
	public List<PPILCDEIOKE> BADAAMPLPNF(int EMMACFPOKFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x85DA9B0", Offset = "0x85D95B0", VA = "0x1885DA9B0")]
	public List<PPILCDEIOKE> PADLINGJFLC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x6C49E30", Offset = "0x6C48A30", VA = "0x186C49E30")]
	public PPILCDEIOKE JDEPBNNABEP(int EMMACFPOKFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x85DA1D0", Offset = "0x85D8DD0", VA = "0x1885DA1D0")]
	public IReadOnlyList<PPILCDEIOKE> GHANFPENJHK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x85DAE10", Offset = "0x85D9A10", VA = "0x1885DAE10")]
	public AGMGCNJAKAP()
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
