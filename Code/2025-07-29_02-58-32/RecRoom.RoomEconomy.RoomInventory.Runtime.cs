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
		[Cpp2IlInjected.Address(RVA = "0x8B5DEE0", Offset = "0x8B5C8E0", VA = "0x188B5DEE0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2906C90", Offset = "0x2905690", VA = "0x182906C90")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface AHAEPJAJIPB : PFFNENGNHBH
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	PHMLINLICDB IKBPBJLDCDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[DefaultMember("Item")]
public class PFMHJLNGINF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly Dictionary<Guid, NGHAOLMOIKA> JDHAMLPMADF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly Dictionary<string, NGHAOLMOIKA> BOEJKELINGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private bool? FFCDFPFBBPN;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private long EDCJBBOOIBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA882F0", Offset = "0xA86CF0", VA = "0x180A882F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public NGHAOLMOIKA EFLOLIACEGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8B551B0", Offset = "0x8B53BB0", VA = "0x188B551B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x8B548F0", Offset = "0x8B532F0", VA = "0x188B548F0")]
	public void GJGLLBFGINF(long DKMPIOFKFMN, IEnumerable<FOOBNMBKKFO> GGBDFDNADKM, IEnumerable<NHMIKDMPHEO> HJAHGKDOGPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x8B540F0", Offset = "0x8B52AF0", VA = "0x188B540F0")]
	public bool AKNACCCBALA(Guid KFBBNBEBFKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x8B542A0", Offset = "0x8B52CA0", VA = "0x188B542A0")]
	public bool BBOPECIHIDA(Guid KFBBNBEBFKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x8B55470", Offset = "0x8B53E70", VA = "0x188B55470")]
	public bool OFAANNPKKNN(FOOBNMBKKFO MDPEOHLGAEM, [Out] FOOBNMBKKFO HBHKOLCAIME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x8B55210", Offset = "0x8B53C10", VA = "0x188B55210")]
	public IEnumerable<NGHAOLMOIKA> KJNECIDIGHO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x8B54150", Offset = "0x8B52B50", VA = "0x188B54150")]
	public IEnumerable<FOOBNMBKKFO> ANFKFOHHPEM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x8B542C0", Offset = "0x8B52CC0", VA = "0x188B542C0")]
	public IEnumerable<NHMIKDMPHEO> BGNAIOENKFE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x8B545F0", Offset = "0x8B52FF0", VA = "0x188B545F0")]
	public bool EAOHKNDKHFD(Guid KFBBNBEBFKM, [Out] FOOBNMBKKFO ACIOEHDMEEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x8B553D0", Offset = "0x8B53DD0", VA = "0x188B553D0")]
	public bool NDJGIFNJCGG(string DDLLBKHCCDE, [Out] FOOBNMBKKFO ACIOEHDMEEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x8B552E0", Offset = "0x8B53CE0", VA = "0x188B552E0")]
	public bool KPKGNNIKAID(Guid KFBBNBEBFKM, [Out] NHMIKDMPHEO AICEMMPOODE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x8B55790", Offset = "0x8B54190", VA = "0x188B55790")]
	public bool PAIJAMHEHIO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x8B55260", Offset = "0x8B53C60", VA = "0x188B55260")]
	private bool KKAPJOGPCLL(FOOBNMBKKFO OIKPBCOOHJG, FOOBNMBKKFO IDJLFIHEALI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x8B546A0", Offset = "0x8B530A0", VA = "0x188B546A0")]
	private void EJMJAKNGIED(Guid FILGHJLFKAL, NGHAOLMOIKA HKOIKFHLAAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x8B54F60", Offset = "0x8B53960", VA = "0x188B54F60")]
	private bool JMNGDEEFCMK(Guid FILGHJLFKAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x8B556A0", Offset = "0x8B540A0", VA = "0x188B556A0")]
	private void ONIELPNLJHA(FOOBNMBKKFO BEDJHLIBPCD, [Optional] FOOBNMBKKFO POJHMFDGJKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x8B54410", Offset = "0x8B52E10", VA = "0x188B54410")]
	private bool DFEGPOCLKFN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x8B55390", Offset = "0x8B53D90", VA = "0x188B55390")]
	private static bool LHHDFPIFMKJ(FOOBNMBKKFO HNLFGCKBFGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x8B55830", Offset = "0x8B54230", VA = "0x188B55830")]
	public PFMHJLNGINF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class PHMLINLICDB : DCDBDAPMOKO, HOEEPIFFMCC, IDisposable, LLBCKFDJPMP
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private struct IAPAGLPMOGC : IEquatable<IAPAGLPMOGC>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public long EDCJBBOOIBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public Guid EOGDNKBPBAL;

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x5576340", Offset = "0x5574D40", VA = "0x185576340")]
		public IAPAGLPMOGC(long DKMPIOFKFMN, Guid KFBBNBEBFKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x8B4F800", Offset = "0x8B4E200", VA = "0x188B4F800", Slot = "4")]
		public bool Equals(IAPAGLPMOGC EFNHKCDKOGH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x8B4F900", Offset = "0x8B4E300", VA = "0x188B4F900", Slot = "0")]
		public override bool Equals(object CEFJEHJNIAP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8B4FA60", Offset = "0x8B4E460", VA = "0x188B4FA60", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct GDDGILGDMBJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public AsyncTaskMethodBuilder<DOHEMIFBILP<FOOBNMBKKFO, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public PHMLINLICDB <>4__this;

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
		public List<LNJIDIAMKGO> newTags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public bool allowRename;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private TaskAwaiter<PCJOEEHNGHJ<BMANFJNADNB>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8B4DB80", Offset = "0x8B4C580", VA = "0x188B4DB80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8B4E090", Offset = "0x8B4CA90", VA = "0x188B4E090", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct JBGDMLNPFDM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncTaskMethodBuilder<DOHEMIFBILP<FOOBNMBKKFO, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public PHMLINLICDB <>4__this;

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
		private TaskAwaiter<PCJOEEHNGHJ<BMANFJNADNB>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8B4FAE0", Offset = "0x8B4E4E0", VA = "0x188B4FAE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x8B50330", Offset = "0x8B4ED30", VA = "0x188B50330", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct BKFLNOOEAKK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public AsyncTaskMethodBuilder<DOHEMIFBILP<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public PHMLINLICDB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private FOOBNMBKKFO <itemToDelete>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private OONMGGAOEHG <result>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private TaskAwaiter<OONMGGAOEHG> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x8B4A870", Offset = "0x8B49270", VA = "0x188B4A870", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x8B4B080", Offset = "0x8B49A80", VA = "0x188B4B080", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct EMGCDNAEKMH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public PHMLINLICDB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public POIAKMBAMML player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private TaskAwaiter<int> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8B4D790", Offset = "0x8B4C190", VA = "0x188B4D790", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8B4DB10", Offset = "0x8B4C510", VA = "0x188B4DB10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct PNKGEJMPIMJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public AsyncTaskMethodBuilder<DLAJENKJHBA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public PHMLINLICDB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public POIAKMBAMML recipient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public int quantity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private TaskAwaiter<DLAJENKJHBA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8B5D790", Offset = "0x8B5C190", VA = "0x188B5D790", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8B5DBF0", Offset = "0x8B5C5F0", VA = "0x188B5DBF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct GEGJHPHKIJA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public AsyncTaskMethodBuilder<DOHEMIFBILP<DEINKIKCKAG, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public PHMLINLICDB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public long tagId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public RoomInventoryTagClientProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private DEINKIKCKAG <newTag>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private TaskAwaiter<TaskStatus> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8B4E100", Offset = "0x8B4CB00", VA = "0x188B4E100", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x8B4E580", Offset = "0x8B4CF80", VA = "0x188B4E580", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct LGDJBNHPDKL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public AsyncTaskMethodBuilder<DOHEMIFBILP<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public PHMLINLICDB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public long tagId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private List<DEINKIKCKAG>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private TaskAwaiter<DOHEMIFBILP<DEINKIKCKAG, string>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private TaskAwaiter<OONMGGAOEHG> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x8B52910", Offset = "0x8B51310", VA = "0x188B52910", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x8B53520", Offset = "0x8B51F20", VA = "0x188B53520", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct MIBFBFJPMAN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public AsyncTaskMethodBuilder<DOHEMIFBILP<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public PHMLINLICDB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public bool isEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private TaskAwaiter<OONMGGAOEHG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x8B53590", Offset = "0x8B51F90", VA = "0x188B53590", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x8B53AB0", Offset = "0x8B524B0", VA = "0x188B53AB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct BMDPFNBJFIN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public AsyncTaskMethodBuilder<Dictionary<long, LNJIDIAMKGO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public Dictionary<long, int> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public PHMLINLICDB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private TaskAwaiter<PCJOEEHNGHJ<List<LNJIDIAMKGO>>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x8B4B0F0", Offset = "0x8B49AF0", VA = "0x188B4B0F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x8B4BAB0", Offset = "0x8B4A4B0", VA = "0x188B4BAB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct MAKKEDPAEHP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public PHMLINLICDB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public NHMIKDMPHEO playerRoomInventoryItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public int quantity;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct ACPNGLFNHIO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public AsyncTaskMethodBuilder<DLAJENKJHBA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public PHMLINLICDB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public int quantity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private MAKKEDPAEHP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public POIAKMBAMML awardingPlayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public Guid remoteOperationId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private TaskAwaiter<ANGICLMMAKO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x8B4A3B0", Offset = "0x8B48DB0", VA = "0x188B4A3B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x8B4A800", Offset = "0x8B49200", VA = "0x188B4A800", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private struct IPCHFBMEEJG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public Dictionary<IAPAGLPMOGC, int> idsAndQuantities;
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class NGNCBGEJHGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public ANGICLMMAKO result;

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public NGNCBGEJHGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x8B53B20", Offset = "0x8B52520", VA = "0x188B53B20")]
		internal LGEBMNLJFAI JIJHHBCCAFN(IAPAGLPMOGC id)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct KHLAEIDPBBF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public AsyncTaskMethodBuilder<Dictionary<IAPAGLPMOGC, LGEBMNLJFAI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public Dictionary<IAPAGLPMOGC, int> idsAndQuantities;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public PHMLINLICDB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private IPCHFBMEEJG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private TaskAwaiter<List<LGEBMNLJFAI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x8B503E0", Offset = "0x8B4EDE0", VA = "0x188B503E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x8B50EB0", Offset = "0x8B4F8B0", VA = "0x188B50EB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct KNOGEEDBBIM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public AsyncTaskMethodBuilder<List<LGEBMNLJFAI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public Dictionary<IAPAGLPMOGC, int> idsAndQuantities;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public PHMLINLICDB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private List<LGEBMNLJFAI> <results>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private int <attemptNumber>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private TaskAwaiter<List<LGEBMNLJFAI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x8B51930", Offset = "0x8B50330", VA = "0x188B51930", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x8B528A0", Offset = "0x8B512A0", VA = "0x188B528A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct DJBBKGMNILC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public PHMLINLICDB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private Task<List<BMANFJNADNB>> <roomInventoryTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private Task<List<KOGOPPAKDMG>> <playerRoomInventoryTask>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private Task<List<LNJIDIAMKGO>> <roomInventoryTagsTask>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private Task<ONEPCLGLMAM> <roomConfigsTask>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private IEnumerable<FOOBNMBKKFO> <roomInventoryItems>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private IEnumerable<NHMIKDMPHEO> <playerRoomInventoryItems>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private List<DEINKIKCKAG> <roomInventoryTags>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private TaskAwaiter<List<BMANFJNADNB>> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private TaskAwaiter<List<KOGOPPAKDMG>> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private TaskAwaiter<List<LNJIDIAMKGO>> <>u__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private TaskAwaiter<ONEPCLGLMAM> <>u__5;

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x8B4C4F0", Offset = "0x8B4AEF0", VA = "0x188B4C4F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x8B4D730", Offset = "0x8B4C130", VA = "0x188B4D730", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private struct CBOLLLCAMEA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public PHMLINLICDB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private TaskAwaiter<Task> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x8B4BB20", Offset = "0x8B4A520", VA = "0x188B4BB20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x8B4C1B0", Offset = "0x8B4ABB0", VA = "0x188B4C1B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private struct OKCBOMOJCCN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public PHMLINLICDB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public POIAKMBAMML player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private TaskAwaiter<int> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x8B53B90", Offset = "0x8B52590", VA = "0x188B53B90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x8B54080", Offset = "0x8B52A80", VA = "0x188B54080", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private struct PJABLCGNPDG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public AsyncTaskMethodBuilder<DLAJENKJHBA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public PHMLINLICDB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public POIAKMBAMML player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public int quantity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private TaskAwaiter<DLAJENKJHBA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x8B5D220", Offset = "0x8B5BC20", VA = "0x188B5D220", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x8B5D720", Offset = "0x8B5C120", VA = "0x188B5D720", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private struct KIFEDBPHJDN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public FOOBNMBKKFO itemToDelete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public PHMLINLICDB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private Dictionary<long, bool>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private TaskAwaiter<DOHEMIFBILP<bool, string>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x8B50F20", Offset = "0x8B4F920", VA = "0x188B50F20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x8B518D0", Offset = "0x8B502D0", VA = "0x188B518D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly TimeSpan LHLMMAFLGNJ;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private const float IEJPNENJIIM = 10f;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private const float NGPJBAGMIHP = 3f;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal const int APKANCEMFAF = 3;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	internal const string OKNNEMGCHKK = "econ_room_inventory_gate";

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	internal const string MBJDEHMHGKG = "experiences_room_inventory_tags_gate";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly BILDFMDHIHC PMJCCNBJNGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly GCKLGHGMFCJ JDAFLPMKOEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly DPFJJIPFGLN KFILBFPCCBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly JFAKEFFKLPM IJAGCLBIPED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly DJPCBEIFFMH BHOPGPAOKHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly AHAEPJAJIPB OLBLDJJMDLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly OADOONOPPPN LJLGJHJNHOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly HHDJONNLLPC ALJIPBBHOJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly MLKFEOENEPL MIABIFLBNOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly PFMHJLNGINF HMPKONKAHBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly GEGNDDJFLJP KOBFCJCAEFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly KHGBNOAPEIG LBLCFGCHFPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly CancellationTokenSource JGBOHHAAGID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly BIJOFPINOOE<IAPAGLPMOGC, LGEBMNLJFAI> EMEFPJPKHLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly BIJOFPINOOE<long, LNJIDIAMKGO> DIPPOBHPCBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly NLGKOGCJCGM BMKNPCHKLKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly IDisposable KHKBDLEGOGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private Task DGGOOJGJAEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private CancellationTokenSource BEJNDNEGHBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private long PBLFNFLAEFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private bool JAFNIEKLOJN;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private IGAEHEBIPKL HLNCMFCIMFF
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8B55D10", Offset = "0x8B54710", VA = "0x188B55D10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public HPDJJKCNBLF IKAHCMFINDK
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xE93590", Offset = "0xE91F90", VA = "0x180E93590", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xE935A0", Offset = "0xE91FA0", VA = "0x180E935A0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public ECMKKKEPCGP<FOOBNMBKKFO> IHDEJGKCPON
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xB40610", Offset = "0xB3F010", VA = "0x180B40610", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xB68BC0", Offset = "0xB675C0", VA = "0x180B68BC0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public ECMKKKEPCGP<Guid> OOAFPFFIECB
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xB40660", Offset = "0xB3F060", VA = "0x180B40660", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xB405D0", Offset = "0xB3EFD0", VA = "0x180B405D0", Slot = "9")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public NCMMNGPOLDF<NHMIKDMPHEO, int> CCMJIGEOJBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xAFE330", Offset = "0xAFCD30", VA = "0x180AFE330", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xB013C0", Offset = "0xAFFDC0", VA = "0x180B013C0", Slot = "11")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public ECMKKKEPCGP<DEINKIKCKAG> HCNFOFJHCNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xA89E90", Offset = "0xA88890", VA = "0x180A89E90", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xA89E10", Offset = "0xA88810", VA = "0x180A89E10", Slot = "13")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public ECMKKKEPCGP<long> LDJAHPJHEKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xB02020", Offset = "0xB00A20", VA = "0x180B02020", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xB01370", Offset = "0xAFFD70", VA = "0x180B01370", Slot = "15")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public HPDJJKCNBLF MPMBEOMPIED
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xB02010", Offset = "0xB00A10", VA = "0x180B02010", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xB01630", Offset = "0xB00030", VA = "0x180B01630", Slot = "17")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public HPDJJKCNBLF IBPAPLCLMBL
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xAFCCC0", Offset = "0xAFB6C0", VA = "0x180AFCCC0", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xAFC800", Offset = "0xAFB200", VA = "0x180AFC800", Slot = "19")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x8B58FB0", Offset = "0x8B579B0", VA = "0x188B58FB0")]
	[PPMDKOHJEBA.MBAKIOAAHOM.JHIOBJALHKC]
	internal static void INJFIJEPFFK(CFAMNNNCHJA JBOIKIICKBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x8B5C690", Offset = "0x8B5B090", VA = "0x188B5C690")]
	[RecRoom.NoEngine.Common.Preserve]
	public PHMLINLICDB([LNLOHEINMEO(null)] BILDFMDHIHC PMJCCNBJNGA, [LNLOHEINMEO(null)] GCKLGHGMFCJ JDAFLPMKOEE, [LNLOHEINMEO(null)] DPFJJIPFGLN KFILBFPCCBF, [LNLOHEINMEO(null)] JFAKEFFKLPM IJAGCLBIPED, [LNLOHEINMEO(null)] JPFNCIEFDND CKOPEGDGOOO, [LNLOHEINMEO(null)] DJPCBEIFFMH BHOPGPAOKHO, [LNLOHEINMEO(null)] AHAEPJAJIPB OLBLDJJMDLF, [LNLOHEINMEO(null)] ANCNJFFHDMH FILDDBJAIFC, [LNLOHEINMEO(null)] FEBPOJMMJBB HOANIBECHGG, [LNLOHEINMEO(null)] OADOONOPPPN LJLGJHJNHOB, [LNLOHEINMEO(null)] HHDJONNLLPC ALJIPBBHOJJ, [LNLOHEINMEO(null)] MLKFEOENEPL MIABIFLBNOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x8B567E0", Offset = "0x8B551E0", VA = "0x188B567E0", Slot = "53")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x8B59130", Offset = "0x8B57B30", VA = "0x188B59130", Slot = "52")]
	public Task JFBHKDNHPMC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x8B5B350", Offset = "0x8B59D50", VA = "0x188B5B350", Slot = "20")]
	[AsyncStateMachine(typeof(GDDGILGDMBJ))]
	public Task<DOHEMIFBILP<FOOBNMBKKFO, string>> OKMEOEDHGCO(Guid? JPMACAOCOMP, long DKMPIOFKFMN, string FLBFBHGDBLM, string IGEOMPONAKK, string OCELNAFHMKB, RoomInventoryItemProperties FNPCEKCMMCN, byte EBOPBDPOAOK, int EDNHAEBPHJD, [Optional] List<long> EPAHKBBMOBN, [Optional] List<LNJIDIAMKGO> BMBMIACEPHL, bool DJJDOLPBAFF = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x8B5BB40", Offset = "0x8B5A540", VA = "0x188B5BB40", Slot = "21")]
	[AsyncStateMachine(typeof(JBGDMLNPFDM))]
	public Task<DOHEMIFBILP<FOOBNMBKKFO, string>> PBBGHIBNPGE(Guid KFBBNBEBFKM, long DKMPIOFKFMN, [Optional] string FLBFBHGDBLM, [Optional] string IGEOMPONAKK, [Optional] string OCELNAFHMKB, [Optional] List<long> EPAHKBBMOBN, [Optional] Dictionary<string, RoomInventoryTagClientProperties> BMBMIACEPHL, [Optional] RoomInventoryItemProperties FNPCEKCMMCN, [Optional] byte? EBOPBDPOAOK, [Optional] int? EDNHAEBPHJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x8B58730", Offset = "0x8B57130", VA = "0x188B58730", Slot = "22")]
	[AsyncStateMachine(typeof(BKFLNOOEAKK))]
	public Task<DOHEMIFBILP<bool, string>> HJJILNKFILL(Guid KFBBNBEBFKM, long DKMPIOFKFMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x8B59CC0", Offset = "0x8B586C0", VA = "0x188B59CC0", Slot = "23")]
	public IReadOnlyList<FOOBNMBKKFO> KKEPOPHIBHE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x8B59240", Offset = "0x8B57C40", VA = "0x188B59240", Slot = "24")]
	public IReadOnlyList<FOOBNMBKKFO> JPCAJDBEGOM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x8B58630", Offset = "0x8B57030", VA = "0x188B58630", Slot = "25")]
	public bool HICMDAJMAIE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x8B56E60", Offset = "0x8B55860", VA = "0x188B56E60", Slot = "26")]
	public bool EAOHKNDKHFD(Guid KFBBNBEBFKM, [Out] FOOBNMBKKFO ACIOEHDMEEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x8B5AB00", Offset = "0x8B59500", VA = "0x188B5AB00", Slot = "27")]
	public bool NDJGIFNJCGG(string NIJJCDKCLMD, [Out] FOOBNMBKKFO ACIOEHDMEEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x8B59870", Offset = "0x8B58270", VA = "0x188B59870", Slot = "28")]
	public IReadOnlyList<NHMIKDMPHEO> KCPIJELKPKC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x8B59D70", Offset = "0x8B58770", VA = "0x188B59D70", Slot = "29")]
	public bool KPKGNNIKAID(Guid KFBBNBEBFKM, [Out] NHMIKDMPHEO AICEMMPOODE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x8B57760", Offset = "0x8B56160", VA = "0x188B57760", Slot = "30")]
	public long? FCPBEMGFNOG(Guid KFBBNBEBFKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x8B5AC20", Offset = "0x8B59620", VA = "0x188B5AC20", Slot = "51")]
	public void NMKMDFEMHEK(IEnumerable<KOGOPPAKDMG> HJAHGKDOGPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x8B57FB0", Offset = "0x8B569B0", VA = "0x188B57FB0", Slot = "31")]
	[AsyncStateMachine(typeof(EMGCDNAEKMH))]
	public Task<int> GALMJBFGNPL(POIAKMBAMML JGGGINODJOB, Guid KFBBNBEBFKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x8B55EA0", Offset = "0x8B548A0", VA = "0x188B55EA0", Slot = "32")]
	[AsyncStateMachine(typeof(PNKGEJMPIMJ))]
	public Task<DLAJENKJHBA> BFFLHOIKFGD(POIAKMBAMML HLINIPHJNLL, Guid KFBBNBEBFKM, int BOILODJDIKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x8B56280", Offset = "0x8B54C80", VA = "0x188B56280", Slot = "33")]
	public string CBBJAEGNIJG(ANGICLMMAKO AEAMJGPOBKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x8B5AA90", Offset = "0x8B59490", VA = "0x188B5AA90", Slot = "34")]
	public bool NAMBKCHHGPH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x8B56590", Offset = "0x8B54F90", VA = "0x188B56590", Slot = "38")]
	[AsyncStateMachine(typeof(GEGJHPHKIJA))]
	public Task<DOHEMIFBILP<DEINKIKCKAG, string>> DHBPPEMKGKK(long NIKKFIAPLHL, RoomInventoryTagClientProperties FNPCEKCMMCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x8B566C0", Offset = "0x8B550C0", VA = "0x188B566C0", Slot = "39")]
	[AsyncStateMachine(typeof(LGDJBNHPDKL))]
	public Task<DOHEMIFBILP<bool, string>> DPCCOCLGLPA(long NIKKFIAPLHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x8B55910", Offset = "0x8B54310", VA = "0x188B55910", Slot = "42")]
	public List<(long, int)> AAKDKGBJFAJ(long HMLJKBAAGNI, int NIHKJBDKOOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x8B55C80", Offset = "0x8B54680", VA = "0x188B55C80", Slot = "43")]
	public bool ALBAIDFALFO(long NIKKFIAPLHL, [Out] DEINKIKCKAG CGOFHNFEKKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x8B55BF0", Offset = "0x8B545F0", VA = "0x188B55BF0", Slot = "44")]
	public bool AFBBOIPKDLE(string NMFOJFOGIDI, [Out] DEINKIKCKAG CGOFHNFEKKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x8B58860", Offset = "0x8B57260", VA = "0x188B58860", Slot = "45")]
	public bool HJLJIPCPKGE(long NIKKFIAPLHL, Guid FNKOGKDEHPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x8B5B730", Offset = "0x8B5A130", VA = "0x188B5B730", Slot = "46")]
	public IReadOnlyList<DEINKIKCKAG> ONEAHGNGMLH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x8B59EC0", Offset = "0x8B588C0", VA = "0x188B59EC0", Slot = "47")]
	public List<DEINKIKCKAG> LLKJNPLFDKF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x8B56F80", Offset = "0x8B55980", VA = "0x188B56F80", Slot = "48")]
	public IReadOnlyList<DEINKIKCKAG> EEHCHMHEPMK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x8B58F30", Offset = "0x8B57930", VA = "0x188B58F30", Slot = "41")]
	public bool IKNCCBOIIOF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x8B58AD0", Offset = "0x8B574D0", VA = "0x188B58AD0", Slot = "49")]
	public IReadOnlyList<FOOBNMBKKFO> IAOBICIFBDA(long NIKKFIAPLHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x8B5AE90", Offset = "0x8B59890", VA = "0x188B5AE90", Slot = "40")]
	[AsyncStateMachine(typeof(MIBFBFJPMAN))]
	public Task<DOHEMIFBILP<bool, string>> NPOJLEKBOND(long DKMPIOFKFMN, bool IKNDNACEPNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x8B58A60", Offset = "0x8B57460", VA = "0x188B58A60", Slot = "54")]
	public bool HNFKENMNJIM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x8B59F50", Offset = "0x8B58950", VA = "0x188B59F50", Slot = "50")]
	public bool MCAJLGMKOCH(string NMFOJFOGIDI, [Out] IReadOnlyList<FOOBNMBKKFO> PLBGHCBHIBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x8B57480", Offset = "0x8B55E80", VA = "0x188B57480")]
	[AsyncStateMachine(typeof(BMDPFNBJFIN))]
	private Task<Dictionary<long, LNJIDIAMKGO>> ELHODMNPDEK(Dictionary<long, int> AMKMJDEHLNE, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x8B57330", Offset = "0x8B55D30", VA = "0x188B57330")]
	[AsyncStateMachine(typeof(ACPNGLFNHIO))]
	private Task<DLAJENKJHBA> EGIBGDKEEED(Guid KFBBNBEBFKM, int BOILODJDIKH, [Optional] Guid MBIFOOPNCFM, [Optional] POIAKMBAMML EPNONPMHOHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x8B59B80", Offset = "0x8B58580", VA = "0x188B59B80")]
	[AsyncStateMachine(typeof(KHLAEIDPBBF))]
	private Task<Dictionary<IAPAGLPMOGC, LGEBMNLJFAI>> KIDKNFMIIEE(Dictionary<IAPAGLPMOGC, int> ALGEGLAJCFB, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x8B578F0", Offset = "0x8B562F0", VA = "0x188B578F0")]
	[AsyncStateMachine(typeof(KNOGEEDBBIM))]
	private Task<List<LGEBMNLJFAI>> FHOKIIMOCCI(Dictionary<IAPAGLPMOGC, int> ALGEGLAJCFB, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x8B5A960", Offset = "0x8B59360", VA = "0x188B5A960")]
	[AsyncStateMachine(typeof(DJBBKGMNILC))]
	private Task MPGIPHNIEOA(long DKMPIOFKFMN, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x8B56A00", Offset = "0x8B55400", VA = "0x188B56A00")]
	private Task EADDMBPLGDN(ALPHANGLKLD GACFFBLMJOF, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x8B597A0", Offset = "0x8B581A0", VA = "0x188B597A0")]
	[AsyncStateMachine(typeof(CBOLLLCAMEA))]
	private Task KAIBHMBOBJM(ALPHANGLKLD GACFFBLMJOF, CancellationToken AOMIIBHGLCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x8B56160", Offset = "0x8B54B60", VA = "0x188B56160")]
	private void BKIIIGGGPAP(BMANFJNADNB LEDIFLMCGEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x8B5C170", Offset = "0x8B5AB70", VA = "0x188B5C170")]
	[IBFCMPGKLPH]
	private void RpcOnNotifiedOfRoomInventoryItemCreatedOrUpdated(string AHJKKNIFNMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x8B58DB0", Offset = "0x8B577B0", VA = "0x188B58DB0")]
	private void IHICDLDAFBI(Guid KFBBNBEBFKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x8B5C2B0", Offset = "0x8B5ACB0", VA = "0x188B5C2B0")]
	[IBFCMPGKLPH]
	private void RpcOnNotifiedOfRoomInventoryItemDeleted(Guid KFBBNBEBFKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x8B55D60", Offset = "0x8B54760", VA = "0x188B55D60")]
	[AsyncStateMachine(typeof(OKCBOMOJCCN))]
	private Task<int> BDBLGKAKPFI(POIAKMBAMML JGGGINODJOB, Guid KFBBNBEBFKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x8B5BF80", Offset = "0x8B5A980", VA = "0x188B5BF80")]
	[IBFCMPGKLPH]
	internal void RpcGetPlayerRoomInventoryCount(Guid BJGNCPGGOCA, Guid KFBBNBEBFKM, IIMDHKOLHCE LJOFOOFMAON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x8B5BF00", Offset = "0x8B5A900", VA = "0x188B5BF00")]
	[IBFCMPGKLPH]
	internal void RpcGetPlayerRoomInventoryCountResponse(Guid BJGNCPGGOCA, int CDCPIGCEABM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x8B57A30", Offset = "0x8B56430", VA = "0x188B57A30")]
	[AsyncStateMachine(typeof(PJABLCGNPDG))]
	private Task<DLAJENKJHBA> FNAIMJKGKGD(POIAKMBAMML JGGGINODJOB, Guid KFBBNBEBFKM, int BOILODJDIKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x8B5BE30", Offset = "0x8B5A830", VA = "0x188B5BE30")]
	[IBFCMPGKLPH]
	internal void RpcAddOrRemovePlayerRoomInventoryRequest(Guid BJGNCPGGOCA, Guid KFBBNBEBFKM, int BOILODJDIKH, IIMDHKOLHCE LJOFOOFMAON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x8B5AFB0", Offset = "0x8B599B0", VA = "0x188B5AFB0")]
	private void OCOKJGKKNEP(POIAKMBAMML HLINIPHJNLL, Guid BJGNCPGGOCA, ANGICLMMAKO AEAMJGPOBKI, long HCMIJGDANAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x8B5C560", Offset = "0x8B5AF60", VA = "0x188B5C560")]
	[IBFCMPGKLPH]
	internal void RpcSendAddOrRemovePlayerRoomInventoryResultToPlayer(Guid BJGNCPGGOCA, int AEAMJGPOBKI, long HCMIJGDANAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x8B55FF0", Offset = "0x8B549F0", VA = "0x188B55FF0")]
	private void BKAGEFHBDMJ(bool IKNDNACEPNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x8B5C500", Offset = "0x8B5AF00", VA = "0x188B5C500")]
	[IBFCMPGKLPH]
	private void RpcOnNotifiedOfSortingTabIsEnabledToggled(bool NLAMLLNNOBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x8B59A60", Offset = "0x8B58460", VA = "0x188B59A60")]
	private void KEBOMJEJINJ(List<LNJIDIAMKGO> MOGJHLJOIKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x8B5C350", Offset = "0x8B5AD50", VA = "0x188B5C350")]
	[IBFCMPGKLPH]
	private void RpcOnNotifiedOfRoomInventoryTagUpdates(string KIJJMOIKIFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x8B5B9D0", Offset = "0x8B5A3D0", VA = "0x188B5B9D0")]
	private void OPMJLPFJOAM(long NIKKFIAPLHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x8B5C2E0", Offset = "0x8B5ACE0", VA = "0x188B5C2E0")]
	[IBFCMPGKLPH]
	private void RpcOnNotifiedOfRoomInventoryTagDeleted(long NIKKFIAPLHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x8B5B510", Offset = "0x8B59F10", VA = "0x188B5B510")]
	private FOOBNMBKKFO OMLMCMDJMDK(BMANFJNADNB LEDIFLMCGEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x8B5B170", Offset = "0x8B59B70", VA = "0x188B5B170")]
	private List<DEINKIKCKAG> OINAMAILJNO(List<LNJIDIAMKGO> MOGJHLJOIKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x8B582E0", Offset = "0x8B56CE0", VA = "0x188B582E0")]
	private List<DEINKIKCKAG> HDGFKMKCNKI(IEnumerable<LNJIDIAMKGO> MOGJHLJOIKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x8B57B80", Offset = "0x8B56580", VA = "0x188B57B80", Slot = "36")]
	public RoomInventoryItemProperties GAFAIOPDGFE(string HDCNCOLBBHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x8B575C0", Offset = "0x8B55FC0", VA = "0x188B575C0")]
	private FOOBNMBKKFO ENLBAOMNHJJ(BMANFJNADNB LEDIFLMCGEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x8B56450", Offset = "0x8B54E50", VA = "0x188B56450", Slot = "35")]
	public BMANFJNADNB CMKBPLLOFJM(FOOBNMBKKFO BKHNOLNIJOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x8B59510", Offset = "0x8B57F10", VA = "0x188B59510")]
	private DEINKIKCKAG JPJHKLAMJNE(LNJIDIAMKGO LEDIFLMCGEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x8B591D0", Offset = "0x8B57BD0", VA = "0x188B591D0")]
	private void JICJBGCCOKC(NHMIKDMPHEO AICEMMPOODE, int GBBKMKODMGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x8B580F0", Offset = "0x8B56AF0", VA = "0x188B580F0")]
	private void GNJGCGNBAFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x8B58160", Offset = "0x8B56B60", VA = "0x188B58160")]
	private Task HAPCMFEMBCK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x8B5BD00", Offset = "0x8B5A700", VA = "0x188B5BD00")]
	private void PEFHFIAJNKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x8B5BD70", Offset = "0x8B5A770", VA = "0x188B5BD70")]
	private void PMAJNKPIHEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x8B5A400", Offset = "0x8B58E00", VA = "0x188B5A400")]
	private void MJFDPAGNIKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x8B59020", Offset = "0x8B57A20", VA = "0x188B59020")]
	[AsyncStateMachine(typeof(KIFEDBPHJDN))]
	private Task JAFMGMMEFMM(FOOBNMBKKFO IOPNJGGMFFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x8B59EA0", Offset = "0x8B588A0", VA = "0x188B59EA0")]
	[CompilerGenerated]
	private void KPKOFCNEHGM(Task<TaskStatus> AIPCFMDLKCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x8B5A510", Offset = "0x8B58F10", VA = "0x188B5A510")]
	[CompilerGenerated]
	private Task<ANGICLMMAKO> MOHMELKNOJP(MAKKEDPAEHP P_0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x8B5B800", Offset = "0x8B5A200", VA = "0x188B5B800")]
	[CompilerGenerated]
	internal static Dictionary<IAPAGLPMOGC, LGEBMNLJFAI> OOBHJPOOFBC(ANGICLMMAKO AEAMJGPOBKI, IPCHFBMEEJG P_1)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class KHGBNOAPEIG : Dictionary<string, RoomInventoryItemProperties>
{
	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x8B503A0", Offset = "0x8B4EDA0", VA = "0x188B503A0")]
	public KHGBNOAPEIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface FEBPOJMMJBB
{
	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PFMHJLNGINF MFANLJPECHF();

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	KHGBNOAPEIG NAAKHMJFNCB();

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GEGNDDJFLJP IPAPEINAGPK();
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class CLHDNFHIPKL : FEBPOJMMJBB
{
	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x8B4C210", Offset = "0x8B4AC10", VA = "0x188B4C210")]
	[PPMDKOHJEBA.MBAKIOAAHOM.JHIOBJALHKC]
	internal static void INJFIJEPFFK(CFAMNNNCHJA JBOIKIICKBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	[RecRoom.NoEngine.Common.Preserve]
	public CLHDNFHIPKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x8B4C370", Offset = "0x8B4AD70", VA = "0x188B4C370", Slot = "4")]
	public PFMHJLNGINF MFANLJPECHF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x8B4C480", Offset = "0x8B4AE80", VA = "0x188B4C480", Slot = "5")]
	public KHGBNOAPEIG NAAKHMJFNCB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x8B4C280", Offset = "0x8B4AC80", VA = "0x188B4C280", Slot = "6")]
	public GEGNDDJFLJP IPAPEINAGPK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class GEGNDDJFLJP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly Dictionary<long, DEINKIKCKAG> DFACLCDOAEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private readonly DEINKIKCKAG[] BBBHFAMFDBF;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool EGPJPNEILGO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0xB50B70", Offset = "0xB4F570", VA = "0x180B50B70")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0xB50B50", Offset = "0xB4F550", VA = "0x180B50B50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int ONHBNGOPJEH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x8B4E650", Offset = "0x8B4D050", VA = "0x188B4E650")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	private long KNNIINJJJNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xA882F0", Offset = "0xA86CF0", VA = "0x180A882F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x8B4EDB0", Offset = "0x8B4D7B0", VA = "0x188B4EDB0")]
	public void GJGLLBFGINF(long DKMPIOFKFMN, IEnumerable<DEINKIKCKAG> PGEBFDGIMJK, bool GGKBDAIFGIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x8B4EA20", Offset = "0x8B4D420", VA = "0x188B4EA20")]
	public IReadOnlyList<DEINKIKCKAG> EFOBEBOOBCB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0xB50B50", Offset = "0xB4F550", VA = "0x180B50B50")]
	public void MJLCGGHDLAC(bool IKNDNACEPNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x8B4F590", Offset = "0x8B4DF90", VA = "0x188B4F590")]
	public bool KDCHGEFHDFA(long NIKKFIAPLHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x8B4E6B0", Offset = "0x8B4D0B0", VA = "0x188B4E6B0")]
	public bool CBCCLKDLGID(DEINKIKCKAG HJGCDAMCCFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x8B4F270", Offset = "0x8B4DC70", VA = "0x188B4F270")]
	public bool IJBENIPNFNF(List<DEINKIKCKAG> GCEAKCJGAGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x8B4ED10", Offset = "0x8B4D710", VA = "0x188B4ED10")]
	public bool FPCGMDONBHN(long NIKKFIAPLHL, [Out] DEINKIKCKAG FLFLJCMPPBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x8B4E870", Offset = "0x8B4D270", VA = "0x188B4E870")]
	public bool EAGLAJMGFKP(string FLBFBHGDBLM, [Out] DEINKIKCKAG FLFLJCMPPBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x8B4F670", Offset = "0x8B4E070", VA = "0x188B4F670")]
	public List<DEINKIKCKAG> NHGKOEHOOHD(int FILGHJLFKAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x8B4EBD0", Offset = "0x8B4D5D0", VA = "0x188B4EBD0")]
	public List<DEINKIKCKAG> ELMLJFBFKKP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x7130640", Offset = "0x712F040", VA = "0x187130640")]
	public DEINKIKCKAG LGNBJONFGFF(int FILGHJLFKAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x8B4E5F0", Offset = "0x8B4CFF0", VA = "0x188B4E5F0")]
	public IReadOnlyList<DEINKIKCKAG> AEKHBPPOIHJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x8B4F740", Offset = "0x8B4E140", VA = "0x188B4F740")]
	public GEGNDDJFLJP()
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
