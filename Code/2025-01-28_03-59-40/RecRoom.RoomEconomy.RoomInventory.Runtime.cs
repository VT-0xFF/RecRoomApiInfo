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
		[Cpp2IlInjected.Address(RVA = "0x793B860", Offset = "0x793AA60", VA = "0x18793B860", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x23EA930", Offset = "0x23E9B30", VA = "0x1823EA930")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface MAJCJNHHKOM : IJKNABPGECG
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	GAJGIJLJEIC LCPOBPBABGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[DefaultMember("Item")]
public class GILENIMONNH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly Dictionary<Guid, IAMBANIFFDN> CJBKFOBNHJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly Dictionary<string, IAMBANIFFDN> HLIPAPGHBMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private bool? JCNIPLFGILE;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private long KLKOLHDJPGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8FB0F0", Offset = "0x8FA2F0", VA = "0x1808FB0F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public IAMBANIFFDN FJMFIOCLMJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7934A20", Offset = "0x7933C20", VA = "0x187934A20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7934B20", Offset = "0x7933D20", VA = "0x187934B20")]
	public void LHHJHHPPLGK(long MOMKFNIIPAA, IEnumerable<GMJADDEKEDF> EHOIICFGOLK, IEnumerable<JCMDBMOMBND> GGIFHBMKMPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7934660", Offset = "0x7933860", VA = "0x187934660")]
	public bool GCGAHOINONA(Guid ILFGDHPADPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7934710", Offset = "0x7933910", VA = "0x187934710")]
	public bool GMODDBABBFK(Guid ILFGDHPADPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7934730", Offset = "0x7933930", VA = "0x187934730")]
	public bool HBGMFFNKNLO(GMJADDEKEDF LAIDLDIKLBB, [Out] GMJADDEKEDF KDFDJMKDEAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x79346C0", Offset = "0x79338C0", VA = "0x1879346C0")]
	public IEnumerable<IAMBANIFFDN> GLPMGHHHMFA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7935210", Offset = "0x7934410", VA = "0x187935210")]
	public IEnumerable<GMJADDEKEDF> NKAPONOOABP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7934510", Offset = "0x7933710", VA = "0x187934510")]
	public IEnumerable<JCMDBMOMBND> EKBEGDMNCMB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x79355B0", Offset = "0x79347B0", VA = "0x1879355B0")]
	public bool POAGFJBJLGB(Guid ILFGDHPADPC, [Out] GMJADDEKEDF OJMLLDDMBCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7934A80", Offset = "0x7933C80", VA = "0x187934A80")]
	public bool KHPFFOCCMKH(string GOKPOHPINOK, [Out] GMJADDEKEDF OJMLLDDMBCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7934210", Offset = "0x7933410", VA = "0x187934210")]
	public bool CHCFAPBAFFF(Guid ILFGDHPADPC, [Out] JCMDBMOMBND FHHHBJFGJGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7935170", Offset = "0x7934370", VA = "0x187935170")]
	public bool MENDCJGNDGA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x79349A0", Offset = "0x7933BA0", VA = "0x1879349A0")]
	private bool JICJAICEHIC(GMJADDEKEDF FAKLBLICCDK, GMJADDEKEDF OMEGHEHDIOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7935360", Offset = "0x7934560", VA = "0x187935360")]
	private void PKPNPFMMCKL(Guid CPLNODNGKGB, IAMBANIFFDN JMAIBBGBKMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x79342C0", Offset = "0x79334C0", VA = "0x1879342C0")]
	private bool EBHNCGJNKIB(Guid CPLNODNGKGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7933F40", Offset = "0x7933140", VA = "0x187933F40")]
	private void AGHAHHHHIME(GMJADDEKEDF PHBMJLDOKMG, [Optional] GMJADDEKEDF MGLFNDCJDFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7934030", Offset = "0x7933230", VA = "0x187934030")]
	private bool BLBJPOMBNGN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7934960", Offset = "0x7933B60", VA = "0x187934960")]
	private static bool INDDIPBBLFG(GMJADDEKEDF OCLIEIADJMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7935660", Offset = "0x7934860", VA = "0x187935660")]
	public GILENIMONNH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class GAJGIJLJEIC : KIBNGCONGMI, IDNFFLHGDCH, IDisposable, OOODPOPMHJD
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private struct FGMHGGMCOPG : IEquatable<FGMHGGMCOPG>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public long KLKOLHDJPGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public Guid GLELBGDDEHK;

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x49CAB20", Offset = "0x49C9D20", VA = "0x1849CAB20")]
		public FGMHGGMCOPG(long MOMKFNIIPAA, Guid ILFGDHPADPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x792A8B0", Offset = "0x7929AB0", VA = "0x18792A8B0", Slot = "4")]
		public bool Equals(FGMHGGMCOPG JAINJPLCLDO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x792A750", Offset = "0x7929950", VA = "0x18792A750", Slot = "0")]
		public override bool Equals(object LCACGJDNDHA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x792A9B0", Offset = "0x7929BB0", VA = "0x18792A9B0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct NNMGLAEINHM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public AsyncTaskMethodBuilder<EBOICGKKPAM<GMJADDEKEDF, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public GAJGIJLJEIC <>4__this;

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
		public List<ENCKFHMJACH> newTags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public bool allowRename;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private TaskAwaiter<HPOHMINJNDB<DMJIEILHNHN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x7937D80", Offset = "0x7936F80", VA = "0x187937D80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x7938280", Offset = "0x7937480", VA = "0x187938280", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct FOAKOFHBNOJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncTaskMethodBuilder<EBOICGKKPAM<GMJADDEKEDF, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public GAJGIJLJEIC <>4__this;

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
		private TaskAwaiter<HPOHMINJNDB<DMJIEILHNHN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x792AA30", Offset = "0x7929C30", VA = "0x18792AA30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x792B280", Offset = "0x792A480", VA = "0x18792B280", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct OPFIHAONCOL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public AsyncTaskMethodBuilder<EBOICGKKPAM<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public GAJGIJLJEIC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private GMJADDEKEDF <itemToDelete>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private MFILBIBCNFI <result>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private TaskAwaiter<MFILBIBCNFI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x7939B60", Offset = "0x7938D60", VA = "0x187939B60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x793A360", Offset = "0x7939560", VA = "0x18793A360", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct GIGCNDJHKOL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public GAJGIJLJEIC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public IAGJLFEFIKH player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private TaskAwaiter<int> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7933B50", Offset = "0x7932D50", VA = "0x187933B50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x7933ED0", Offset = "0x79330D0", VA = "0x187933ED0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct NCEPAFJDMOE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public AsyncTaskMethodBuilder<HJHFCFILJDJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public GAJGIJLJEIC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public IAGJLFEFIKH recipient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public int quantity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private TaskAwaiter<HJHFCFILJDJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x79378B0", Offset = "0x7936AB0", VA = "0x1879378B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7937D10", Offset = "0x7936F10", VA = "0x187937D10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct CJJKCKPKNBD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public AsyncTaskMethodBuilder<EBOICGKKPAM<JEGPAEGHOJE, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public GAJGIJLJEIC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public long tagId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public RoomInventoryTagClientProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private JEGPAEGHOJE <newTag>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private TaskAwaiter<TaskStatus> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7927DA0", Offset = "0x7926FA0", VA = "0x187927DA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x7928220", Offset = "0x7927420", VA = "0x187928220", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct PCECLOGPOIO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public AsyncTaskMethodBuilder<EBOICGKKPAM<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public GAJGIJLJEIC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public long tagId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private List<JEGPAEGHOJE>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private TaskAwaiter<EBOICGKKPAM<JEGPAEGHOJE, string>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private TaskAwaiter<MFILBIBCNFI> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x793A3D0", Offset = "0x79395D0", VA = "0x18793A3D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x793AFE0", Offset = "0x793A1E0", VA = "0x18793AFE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct OILDPKKBFBG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public AsyncTaskMethodBuilder<EBOICGKKPAM<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public GAJGIJLJEIC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public bool isEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private TaskAwaiter<MFILBIBCNFI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x79395D0", Offset = "0x79387D0", VA = "0x1879395D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x7939AF0", Offset = "0x7938CF0", VA = "0x187939AF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct GEOIECLEHKH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public AsyncTaskMethodBuilder<Dictionary<long, ENCKFHMJACH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public Dictionary<long, int> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public GAJGIJLJEIC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private TaskAwaiter<HPOHMINJNDB<List<ENCKFHMJACH>>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x7933120", Offset = "0x7932320", VA = "0x187933120", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x7933AE0", Offset = "0x7932CE0", VA = "0x187933AE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct GGMKGNLGPBP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public GAJGIJLJEIC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public JCMDBMOMBND playerRoomInventoryItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public int quantity;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct LACNBAJBKEB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public AsyncTaskMethodBuilder<HJHFCFILJDJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public GAJGIJLJEIC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public int quantity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private GGMKGNLGPBP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public IAGJLFEFIKH awardingPlayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public Guid remoteOperationId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private TaskAwaiter<EJCLPLKNICF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x79373F0", Offset = "0x79365F0", VA = "0x1879373F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x7937840", Offset = "0x7936A40", VA = "0x187937840", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private struct KCDPBJDNIDC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public Dictionary<FGMHGGMCOPG, int> idsAndQuantities;
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class IOIDFDPCECH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public EJCLPLKNICF result;

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public IOIDFDPCECH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x7936840", Offset = "0x7935A40", VA = "0x187936840")]
		internal NPADAINJJHG NKFBJFPAIFE(FGMHGGMCOPG id)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct KFOAIPJEMPH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public AsyncTaskMethodBuilder<Dictionary<FGMHGGMCOPG, NPADAINJJHG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public Dictionary<FGMHGGMCOPG, int> idsAndQuantities;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public GAJGIJLJEIC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private KCDPBJDNIDC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private TaskAwaiter<List<NPADAINJJHG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x79368B0", Offset = "0x7935AB0", VA = "0x1879368B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x7937380", Offset = "0x7936580", VA = "0x187937380", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct CNIEMIFPDLF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public AsyncTaskMethodBuilder<List<NPADAINJJHG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public Dictionary<FGMHGGMCOPG, int> idsAndQuantities;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public GAJGIJLJEIC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private List<NPADAINJJHG> <results>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private int <attemptNumber>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private TaskAwaiter<List<NPADAINJJHG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x7928570", Offset = "0x7927770", VA = "0x187928570", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x79294D0", Offset = "0x79286D0", VA = "0x1879294D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct OEHBFEIBOEE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public GAJGIJLJEIC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private Task<List<DMJIEILHNHN>> <roomInventoryTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private Task<List<HLIDOOJFBON>> <playerRoomInventoryTask>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private Task<List<ENCKFHMJACH>> <roomInventoryTagsTask>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private Task<NJDFPIMGEOG> <roomConfigsTask>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private IEnumerable<GMJADDEKEDF> <roomInventoryItems>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private IEnumerable<JCMDBMOMBND> <playerRoomInventoryItems>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private List<JEGPAEGHOJE> <roomInventoryTags>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private TaskAwaiter<List<DMJIEILHNHN>> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private TaskAwaiter<List<HLIDOOJFBON>> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private TaskAwaiter<List<ENCKFHMJACH>> <>u__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private TaskAwaiter<NJDFPIMGEOG> <>u__5;

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x7938330", Offset = "0x7937530", VA = "0x187938330", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x7939570", Offset = "0x7938770", VA = "0x187939570", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private struct HDGDJKNOEFF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public GAJGIJLJEIC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private TaskAwaiter<Task> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x7935740", Offset = "0x7934940", VA = "0x187935740", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x7935DD0", Offset = "0x7934FD0", VA = "0x187935DD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private struct FPCICIDOBAF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public GAJGIJLJEIC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public IAGJLFEFIKH player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private TaskAwaiter<int> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x792B2F0", Offset = "0x792A4F0", VA = "0x18792B2F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x792B7E0", Offset = "0x792A9E0", VA = "0x18792B7E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private struct PHIJCCIAAIF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public AsyncTaskMethodBuilder<HJHFCFILJDJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public GAJGIJLJEIC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public IAGJLFEFIKH player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public int quantity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private TaskAwaiter<HJHFCFILJDJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x793B050", Offset = "0x793A250", VA = "0x18793B050", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x793B550", Offset = "0x793A750", VA = "0x18793B550", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private struct HKJICEMJNHG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public GMJADDEKEDF itemToDelete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public GAJGIJLJEIC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private Dictionary<long, bool>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private TaskAwaiter<EBOICGKKPAM<bool, string>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x7935E30", Offset = "0x7935030", VA = "0x187935E30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x79367E0", Offset = "0x79359E0", VA = "0x1879367E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly TimeSpan MNKLOLECONP;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private const float DBIPKJAOANK = 10f;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private const float DGMIOEGNBOB = 3f;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal const int OMPMIIFEAGJ = 3;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	internal const string LBCKEJJHJOB = "econ_room_inventory_gate";

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	internal const string MACHCLCMOOI = "experiences_room_inventory_tags_gate";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly CFNMFLCDOAH IGPMKDABNGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly LEOEOMDONGL BHBPFAACLLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly LIKPJCBIAEH LEIFKANEEPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly PIJBAIOLPJE PLNNGKHENGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly NCBJLIBIHFL CHFEAEKEACI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly MAJCJNHHKOM JKPOPCMIMEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly DEGKPLDMDPH FFIHFEFPIBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly PPLBMKLEFAI FBJIMEHDKAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly KPJFLMIHCDF DFMLAAKOBDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly GILENIMONNH HJHMNOJDDBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly DDDMHLKEFJO PGOIHKJJONH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly OBKKLLEJPHH ACCEJLBOILD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly CancellationTokenSource BAOGJFHDACO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly NEKCAEMCMGC<FGMHGGMCOPG, NPADAINJJHG> BOLMDLJHHFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly NEKCAEMCMGC<long, ENCKFHMJACH> HEOHBBMKHOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly ALKJMKFIGEB JOOLPAOLICC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly IDisposable NPELOHOANDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private Task IAGBKKAMCON;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private CancellationTokenSource LDMDAMMKEPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private long BHKJIBJHAME;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private bool HAOFCOOGPMB;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private ONDOGBNIGJM EALDHHCLOHM
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x79306C0", Offset = "0x792F8C0", VA = "0x1879306C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public AEJLNDNFINA ILFOCPGFFEB
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xBD1840", Offset = "0xBD0A40", VA = "0x180BD1840", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xBD1850", Offset = "0xBD0A50", VA = "0x180BD1850", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public DBOBDIFJBBN<GMJADDEKEDF> OHCIIHJKEMP
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xB79D60", Offset = "0xB78F60", VA = "0x180B79D60", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xF88D30", Offset = "0xF87F30", VA = "0x180F88D30", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public DBOBDIFJBBN<Guid> CMEIDLMMMAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xB65170", Offset = "0xB64370", VA = "0x180B65170", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xBE88E0", Offset = "0xBE7AE0", VA = "0x180BE88E0", Slot = "9")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public NJGCEGGLBKK<JCMDBMOMBND, int> NMIFIOGLLHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xA48560", Offset = "0xA47760", VA = "0x180A48560", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xA483C0", Offset = "0xA475C0", VA = "0x180A483C0", Slot = "11")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public DBOBDIFJBBN<JEGPAEGHOJE> BLIGCAACMNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8F7860", Offset = "0x8F6A60", VA = "0x1808F7860", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8F7810", Offset = "0x8F6A10", VA = "0x1808F7810", Slot = "13")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public DBOBDIFJBBN<long> HFHNLEMJCIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xA03FA0", Offset = "0xA031A0", VA = "0x180A03FA0", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xA39B30", Offset = "0xA38D30", VA = "0x180A39B30", Slot = "15")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public AEJLNDNFINA PDFDGHGLFMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x995AF0", Offset = "0x994CF0", VA = "0x180995AF0", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xA4B1C0", Offset = "0xA4A3C0", VA = "0x180A4B1C0", Slot = "17")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public AEJLNDNFINA DAKIPHMACII
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x963CF0", Offset = "0x962EF0", VA = "0x180963CF0", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xA4B8E0", Offset = "0xA4AAE0", VA = "0x180A4B8E0", Slot = "19")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x792D7E0", Offset = "0x792C9E0", VA = "0x18792D7E0")]
	[NAOGKPPNIGE.AGGBMPJIOLK.IPOKDFJKKKA]
	internal static void EEMNDALIEKO(JBPONICDCIO CKNPDKKKGFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x79325A0", Offset = "0x79317A0", VA = "0x1879325A0")]
	[RecRoom.NoEngine.Common.Preserve]
	public GAJGIJLJEIC([FMJHJHHALCB(null)] CFNMFLCDOAH IGPMKDABNGK, [FMJHJHHALCB(null)] LEOEOMDONGL BHBPFAACLLH, [FMJHJHHALCB(null)] LIKPJCBIAEH LEIFKANEEPK, [FMJHJHHALCB(null)] PIJBAIOLPJE PLNNGKHENGN, [FMJHJHHALCB(null)] MEKMCOEEPLL NGAGNLPFNFJ, [FMJHJHHALCB(null)] NCBJLIBIHFL CHFEAEKEACI, [FMJHJHHALCB(null)] MAJCJNHHKOM JKPOPCMIMEK, [FMJHJHHALCB(null)] GCDBGIBDGCK AABHLNIIAGC, [FMJHJHHALCB(null)] JICJPHGNKHG KLDCPBGFHEK, [FMJHJHHALCB(null)] DEGKPLDMDPH FFIHFEFPIBD, [FMJHJHHALCB(null)] PPLBMKLEFAI FBJIMEHDKAA, [FMJHJHHALCB(null)] KPJFLMIHCDF DFMLAAKOBDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x792D5C0", Offset = "0x792C7C0", VA = "0x18792D5C0", Slot = "53")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x79301D0", Offset = "0x792F3D0", VA = "0x1879301D0", Slot = "52")]
	public Task KLALIOKPECD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x792E8D0", Offset = "0x792DAD0", VA = "0x18792E8D0", Slot = "20")]
	[AsyncStateMachine(typeof(NNMGLAEINHM))]
	public Task<EBOICGKKPAM<GMJADDEKEDF, string>> GMAIDPEKPOG(Guid? DHPHDCFNNCF, long MOMKFNIIPAA, string LMOANCJLHKC, string MEAHMKBIOJN, string JEBBABKCJNJ, RoomInventoryItemProperties LJAGDLAELPK, byte OIEMAHGGLND, int HCHFCFNLIAI, [Optional] List<long> KNKOGPGGDFA, [Optional] List<ENCKFHMJACH> ABBPONKCADN, bool NIDAEAENDAB = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x792E0D0", Offset = "0x792D2D0", VA = "0x18792E0D0", Slot = "21")]
	[AsyncStateMachine(typeof(FOAKOFHBNOJ))]
	public Task<EBOICGKKPAM<GMJADDEKEDF, string>> FKIJBCDEHDG(Guid ILFGDHPADPC, long MOMKFNIIPAA, [Optional] string LMOANCJLHKC, [Optional] string MEAHMKBIOJN, [Optional] string JEBBABKCJNJ, [Optional] List<long> KNKOGPGGDFA, [Optional] Dictionary<string, RoomInventoryTagClientProperties> ABBPONKCADN, [Optional] RoomInventoryItemProperties LJAGDLAELPK, [Optional] byte? OIEMAHGGLND, [Optional] int? HCHFCFNLIAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7931900", Offset = "0x7930B00", VA = "0x187931900", Slot = "22")]
	[AsyncStateMachine(typeof(OPFIHAONCOL))]
	public Task<EBOICGKKPAM<bool, string>> PKMCJEKJECB(Guid ILFGDHPADPC, long MOMKFNIIPAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7930710", Offset = "0x792F910", VA = "0x187930710", Slot = "23")]
	public IReadOnlyList<GMJADDEKEDF> NKIDMGAGIDD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x792F390", Offset = "0x792E590", VA = "0x18792F390", Slot = "24")]
	public IReadOnlyList<GMJADDEKEDF> IDBMIEKAPHH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7930270", Offset = "0x792F470", VA = "0x187930270", Slot = "25")]
	public bool KNNJCDMIJPO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7931A30", Offset = "0x7930C30", VA = "0x187931A30", Slot = "26")]
	public bool POAGFJBJLGB(Guid ILFGDHPADPC, [Out] GMJADDEKEDF OJMLLDDMBCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7930040", Offset = "0x792F240", VA = "0x187930040", Slot = "27")]
	public bool KHPFFOCCMKH(string JFCFHPDIMOF, [Out] GMJADDEKEDF OJMLLDDMBCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x792D200", Offset = "0x792C400", VA = "0x18792D200", Slot = "28")]
	public IReadOnlyList<JCMDBMOMBND> DFHMLDLIBKC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x792CA90", Offset = "0x792BC90", VA = "0x18792CA90", Slot = "29")]
	public bool CHCFAPBAFFF(Guid ILFGDHPADPC, [Out] JCMDBMOMBND FHHHBJFGJGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x792F200", Offset = "0x792E400", VA = "0x18792F200", Slot = "30")]
	public long? HPCNKNDHGOG(Guid ILFGDHPADPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x792DBA0", Offset = "0x792CDA0", VA = "0x18792DBA0", Slot = "51")]
	public void EIHGLGKGLDF(IEnumerable<HLIDOOJFBON> GGIFHBMKMPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x792BDA0", Offset = "0x792AFA0", VA = "0x18792BDA0", Slot = "31")]
	[AsyncStateMachine(typeof(GIGCNDJHKOL))]
	public Task<int> APPLHBJDMBE(IAGJLFEFIKH IBFPGGCAJBP, Guid ILFGDHPADPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x792F0B0", Offset = "0x792E2B0", VA = "0x18792F0B0", Slot = "32")]
	[AsyncStateMachine(typeof(NCEPAFJDMOE))]
	public Task<HJHFCFILJDJ> HKEHNBFOEIL(IAGJLFEFIKH DEOEIKMIEMJ, Guid ILFGDHPADPC, int OFNKBDKEKAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x792D3F0", Offset = "0x792C5F0", VA = "0x18792D3F0", Slot = "33")]
	public string DFNFBFFMHDM(EJCLPLKNICF NJFLHCEDIDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x792FEC0", Offset = "0x792F0C0", VA = "0x18792FEC0", Slot = "34")]
	public bool KDFNOFNGKMA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7930DE0", Offset = "0x792FFE0", VA = "0x187930DE0", Slot = "38")]
	[AsyncStateMachine(typeof(CJJKCKPKNBD))]
	public Task<EBOICGKKPAM<JEGPAEGHOJE, string>> OKAELFBIBEE(long AILCBPLGMIC, RoomInventoryTagClientProperties LJAGDLAELPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7930AF0", Offset = "0x792FCF0", VA = "0x187930AF0", Slot = "39")]
	[AsyncStateMachine(typeof(PCECLOGPOIO))]
	public Task<EBOICGKKPAM<bool, string>> OCPIDMNECGA(long AILCBPLGMIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x792E3B0", Offset = "0x792D5B0", VA = "0x18792E3B0", Slot = "42")]
	public List<(long, int)> FNHIANBKKHB(long NBMMIONENNG, int EKKCEONGFLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x792E720", Offset = "0x792D920", VA = "0x18792E720", Slot = "43")]
	public bool GKPBPJJCMDE(long AILCBPLGMIC, [Out] JEGPAEGHOJE PIPILCIMFDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x792E690", Offset = "0x792D890", VA = "0x18792E690", Slot = "44")]
	public bool GGFIEGODDCL(string BJEBIKGHCNC, [Out] JEGPAEGHOJE PIPILCIMFDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7931B50", Offset = "0x7930D50", VA = "0x187931B50", Slot = "45")]
	public bool PPMCMBCALJM(long AILCBPLGMIC, Guid AMNCDCGNEJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x792B990", Offset = "0x792AB90", VA = "0x18792B990", Slot = "46")]
	public IReadOnlyList<JEGPAEGHOJE> AEJMGDJMFFK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x792BD10", Offset = "0x792AF10", VA = "0x18792BD10", Slot = "47")]
	public List<JEGPAEGHOJE> AOJBGGFLLIJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x792C330", Offset = "0x792B530", VA = "0x18792C330", Slot = "48")]
	public IReadOnlyList<JEGPAEGHOJE> BEMKBNPIDOA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7931690", Offset = "0x7930890", VA = "0x187931690", Slot = "41")]
	public bool PGCNBHPCCFB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7930F10", Offset = "0x7930110", VA = "0x187930F10", Slot = "49")]
	public IReadOnlyList<GMJADDEKEDF> PBMLFNHHKEL(long AILCBPLGMIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x79317E0", Offset = "0x79309E0", VA = "0x1879317E0", Slot = "40")]
	[AsyncStateMachine(typeof(OILDPKKBFBG))]
	public Task<EBOICGKKPAM<bool, string>> PKAMPNEJDCN(long MOMKFNIIPAA, bool OINJAKJLDFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x792D190", Offset = "0x792C390", VA = "0x18792D190", Slot = "54")]
	public bool DCGDKMJPKFA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x79311E0", Offset = "0x79303E0", VA = "0x1879311E0", Slot = "50")]
	public bool PCANCIPMEKD(string BJEBIKGHCNC, [Out] IReadOnlyList<GMJADDEKEDF> OODDBEGHBAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x792FC10", Offset = "0x792EE10", VA = "0x18792FC10")]
	[AsyncStateMachine(typeof(GEOIECLEHKH))]
	private Task<Dictionary<long, ENCKFHMJACH>> IMMONAICBMH(Dictionary<long, int> JHPJFCHDMIL, CancellationToken BGEKICMONBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x79309A0", Offset = "0x792FBA0", VA = "0x1879309A0")]
	[AsyncStateMachine(typeof(LACNBAJBKEB))]
	private Task<HJHFCFILJDJ> NOCKDGAPHPP(Guid ILFGDHPADPC, int OFNKBDKEKAP, [Optional] Guid ICEDELNKIHH, [Optional] IAGJLFEFIKH NKIANJJLOGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x792EA90", Offset = "0x792DC90", VA = "0x18792EA90")]
	[AsyncStateMachine(typeof(KFOAIPJEMPH))]
	private Task<Dictionary<FGMHGGMCOPG, NPADAINJJHG>> GPCHNEFFENC(Dictionary<FGMHGGMCOPG, int> HAOMOAHEGKM, CancellationToken BGEKICMONBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x792C6E0", Offset = "0x792B8E0", VA = "0x18792C6E0")]
	[AsyncStateMachine(typeof(CNIEMIFPDLF))]
	private Task<List<NPADAINJJHG>> BIMMKICPEEK(Dictionary<FGMHGGMCOPG, int> HAOMOAHEGKM, CancellationToken BGEKICMONBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x792C960", Offset = "0x792BB60", VA = "0x18792C960")]
	[AsyncStateMachine(typeof(OEHBFEIBOEE))]
	private Task CDLILNMLENP(long MOMKFNIIPAA, CancellationToken BGEKICMONBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x792CD30", Offset = "0x792BF30", VA = "0x18792CD30")]
	private Task CMBDFNBDEPA(GHIJJJNKODG OKBEKNPNPIM, CancellationToken BGEKICMONBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7931710", Offset = "0x7930910", VA = "0x187931710")]
	[AsyncStateMachine(typeof(HDGDJKNOEFF))]
	private Task PJAHPOMBJOB(GHIJJJNKODG OKBEKNPNPIM, CancellationToken LNMFPHPCKDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x792E290", Offset = "0x792D490", VA = "0x18792E290")]
	private void FNGMBJIEGCK(DMJIEILHNHN GEMPPMNGBII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7932080", Offset = "0x7931280", VA = "0x187932080")]
	[PJJGKPLBHMG]
	private void RpcOnNotifiedOfRoomInventoryItemCreatedOrUpdated(string IMGPAEEEJMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x792FD50", Offset = "0x792EF50", VA = "0x18792FD50")]
	private void JDJCBPDMFFC(Guid ILFGDHPADPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x79321C0", Offset = "0x79313C0", VA = "0x1879321C0")]
	[PJJGKPLBHMG]
	private void RpcOnNotifiedOfRoomInventoryItemDeleted(Guid ILFGDHPADPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x792B850", Offset = "0x792AA50", VA = "0x18792B850")]
	[AsyncStateMachine(typeof(FPCICIDOBAF))]
	private Task<int> ABFBGDPLABA(IAGJLFEFIKH IBFPGGCAJBP, Guid ILFGDHPADPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7931EA0", Offset = "0x79310A0", VA = "0x187931EA0")]
	[PJJGKPLBHMG]
	internal void RpcGetPlayerRoomInventoryCount(Guid DHNJGGKJENC, Guid ILFGDHPADPC, NMKKDMLHEPN AFIJJNIIMIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7931E20", Offset = "0x7931020", VA = "0x187931E20")]
	[PJJGKPLBHMG]
	internal void RpcGetPlayerRoomInventoryCountResponse(Guid DHNJGGKJENC, int EOKNBJLIKEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x792DE10", Offset = "0x792D010", VA = "0x18792DE10")]
	[AsyncStateMachine(typeof(PHIJCCIAAIF))]
	private Task<HJHFCFILJDJ> EIINICCDMCJ(IAGJLFEFIKH IBFPGGCAJBP, Guid ILFGDHPADPC, int OFNKBDKEKAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7931D50", Offset = "0x7930F50", VA = "0x187931D50")]
	[PJJGKPLBHMG]
	internal void RpcAddOrRemovePlayerRoomInventoryRequest(Guid DHNJGGKJENC, Guid ILFGDHPADPC, int OFNKBDKEKAP, NMKKDMLHEPN AFIJJNIIMIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x792EE80", Offset = "0x792E080", VA = "0x18792EE80")]
	private void HGKHJJODIGL(IAGJLFEFIKH DEOEIKMIEMJ, Guid DHNJGGKJENC, EJCLPLKNICF NJFLHCEDIDN, long MDNJIOCEIEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7932470", Offset = "0x7931670", VA = "0x187932470")]
	[PJJGKPLBHMG]
	internal void RpcSendAddOrRemovePlayerRoomInventoryResultToPlayer(Guid DHNJGGKJENC, int NJFLHCEDIDN, long MDNJIOCEIEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x792DF60", Offset = "0x792D160", VA = "0x18792DF60")]
	private void FJEDFLFLPPK(bool OINJAKJLDFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7932410", Offset = "0x7931610", VA = "0x187932410")]
	[PJJGKPLBHMG]
	private void RpcOnNotifiedOfSortingTabIsEnabledToggled(bool PHNMGMOOMNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x792E7B0", Offset = "0x792D9B0", VA = "0x18792E7B0")]
	private void GLIINCMALNH(List<ENCKFHMJACH> FJAPPKLNFFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7932260", Offset = "0x7931460", VA = "0x187932260")]
	[PJJGKPLBHMG]
	private void RpcOnNotifiedOfRoomInventoryTagUpdates(string LILALFFIMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x792CBC0", Offset = "0x792BDC0", VA = "0x18792CBC0")]
	private void CIKKPFLBLKI(long AILCBPLGMIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x79321F0", Offset = "0x79313F0", VA = "0x1879321F0")]
	[PJJGKPLBHMG]
	private void RpcOnNotifiedOfRoomInventoryTagDeleted(long AILCBPLGMIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7930430", Offset = "0x792F630", VA = "0x187930430")]
	private GMJADDEKEDF LGEANMAFJHC(DMJIEILHNHN GEMPPMNGBII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x79307C0", Offset = "0x792F9C0", VA = "0x1879307C0")]
	private List<JEGPAEGHOJE> NLLAEAJOKKA(List<ENCKFHMJACH> FJAPPKLNFFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x792D850", Offset = "0x792CA50", VA = "0x18792D850")]
	private List<JEGPAEGHOJE> EFCOOABJFPM(IEnumerable<ENCKFHMJACH> FJAPPKLNFFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x792F7E0", Offset = "0x792E9E0", VA = "0x18792F7E0", Slot = "36")]
	public RoomInventoryItemProperties IIMEBPMDAFK(string IBBKKHMBIEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x792EBD0", Offset = "0x792DDD0", VA = "0x18792EBD0")]
	private GMJADDEKEDF HCOHFIBJAGA(DMJIEILHNHN GEMPPMNGBII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x792C820", Offset = "0x792BA20", VA = "0x18792C820", Slot = "35")]
	public DMJIEILHNHN BPNLBPCEIKJ(GMJADDEKEDF FJNONMALGEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x792BA80", Offset = "0x792AC80", VA = "0x18792BA80")]
	private JEGPAEGHOJE AKBPGBOAMFP(ENCKFHMJACH GEMPPMNGBII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7930160", Offset = "0x792F360", VA = "0x187930160")]
	private void KIIKPALHLEL(JCMDBMOMBND FHHHBJFGJGC, int DDEJCMINJLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7930650", Offset = "0x792F850", VA = "0x187930650")]
	private void MMLKOBBACPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x792F660", Offset = "0x792E860", VA = "0x18792F660")]
	private Task IECPKEIFDJJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x792F040", Offset = "0x792E240", VA = "0x18792F040")]
	private void HILFMFEBMKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7930370", Offset = "0x792F570", VA = "0x187930370")]
	private void KOLMJJEOCLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x792FF30", Offset = "0x792F130", VA = "0x18792FF30")]
	private void KGMPJMKMDBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x792ED70", Offset = "0x792DF70", VA = "0x18792ED70")]
	[AsyncStateMachine(typeof(HKJICEMJNHG))]
	private Task HFPCGPDDINM(GMJADDEKEDF KILCJEPEDCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x792BA60", Offset = "0x792AC60", VA = "0x18792BA60")]
	[CompilerGenerated]
	private void AJIEMFMNLGK(Task<TaskStatus> JPPEAAIELKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x792BEE0", Offset = "0x792B0E0", VA = "0x18792BEE0")]
	[CompilerGenerated]
	private Task<EJCLPLKNICF> BBDNMCGCLMA(GGMKGNLGPBP P_0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7930C10", Offset = "0x792FE10", VA = "0x187930C10")]
	[CompilerGenerated]
	internal static Dictionary<FGMHGGMCOPG, NPADAINJJHG> ODGLJIKJNLG(EJCLPLKNICF NJFLHCEDIDN, KCDPBJDNIDC P_1)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class OBKKLLEJPHH : Dictionary<string, RoomInventoryItemProperties>
{
	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x79382F0", Offset = "0x79374F0", VA = "0x1879382F0")]
	public OBKKLLEJPHH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface JICJPHGNKHG
{
	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GILENIMONNH OLCJBELIFDB();

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	OBKKLLEJPHH AGPBLJJLLGP();

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	DDDMHLKEFJO PPKBHJNDHEG();
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class CMLJKHIGAKL : JICJPHGNKHG
{
	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x7928300", Offset = "0x7927500", VA = "0x187928300")]
	[NAOGKPPNIGE.AGGBMPJIOLK.IPOKDFJKKKA]
	internal static void EEMNDALIEKO(JBPONICDCIO CKNPDKKKGFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
	[RecRoom.NoEngine.Common.Preserve]
	public CMLJKHIGAKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x7928370", Offset = "0x7927570", VA = "0x187928370", Slot = "4")]
	public GILENIMONNH OLCJBELIFDB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x7928290", Offset = "0x7927490", VA = "0x187928290", Slot = "5")]
	public OBKKLLEJPHH AGPBLJJLLGP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x7928480", Offset = "0x7927680", VA = "0x187928480", Slot = "6")]
	public DDDMHLKEFJO PPKBHJNDHEG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class DDDMHLKEFJO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly Dictionary<long, JEGPAEGHOJE> JJHGNGDGLNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private readonly JEGPAEGHOJE[] DHJNCGJPLHC;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool KGHIKKDHHFD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0xB24780", Offset = "0xB23980", VA = "0x180B24780")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0xB24BA0", Offset = "0xB23DA0", VA = "0x180B24BA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int NKLFLGIDANE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x7929B70", Offset = "0x7928D70", VA = "0x187929B70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	private long CHNBHBICJAB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x8FB0F0", Offset = "0x8FA2F0", VA = "0x1808FB0F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x7929E50", Offset = "0x7929050", VA = "0x187929E50")]
	public void LHHJHHPPLGK(long MOMKFNIIPAA, IEnumerable<JEGPAEGHOJE> FIHHAAIJGPL, bool FHLCLCACGOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x7929CA0", Offset = "0x7928EA0", VA = "0x187929CA0")]
	public IReadOnlyList<JEGPAEGHOJE> INEKBNDHODJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0xB24BA0", Offset = "0xB23DA0", VA = "0x180B24BA0")]
	public void KPLEBFGLNOI(bool OINJAKJLDFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x7929540", Offset = "0x7928740", VA = "0x187929540")]
	public bool AHDFMOCELFG(long AILCBPLGMIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x79296C0", Offset = "0x79288C0", VA = "0x1879296C0")]
	public bool CMGAMIKJJEM(JEGPAEGHOJE BLGIIPGDOIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x792A310", Offset = "0x7929510", VA = "0x18792A310")]
	public bool MFMOKJLALMN(List<JEGPAEGHOJE> GLJHNJAOJGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x7929620", Offset = "0x7928820", VA = "0x187929620")]
	public bool BBPLEFEDHGN(long AILCBPLGMIC, [Out] JEGPAEGHOJE ODABBBAHLHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x7929880", Offset = "0x7928A80", VA = "0x187929880")]
	public bool DBPCALIHGOI(string LMOANCJLHKC, [Out] JEGPAEGHOJE ODABBBAHLHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x7929BD0", Offset = "0x7928DD0", VA = "0x187929BD0")]
	public List<JEGPAEGHOJE> IHDIJIEKPIJ(int CPLNODNGKGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x7929A30", Offset = "0x7928C30", VA = "0x187929A30")]
	public List<JEGPAEGHOJE> DPGNPGGEKLP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x74E86D0", Offset = "0x74E78D0", VA = "0x1874E86D0")]
	public JEGPAEGHOJE FAEEBNCJBHP(int CPLNODNGKGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x792A630", Offset = "0x7929830", VA = "0x18792A630")]
	public IReadOnlyList<JEGPAEGHOJE> PMHOIANOPMG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x792A690", Offset = "0x7929890", VA = "0x18792A690")]
	public DDDMHLKEFJO()
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
