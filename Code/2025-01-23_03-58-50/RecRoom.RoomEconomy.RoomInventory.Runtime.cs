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
		[Cpp2IlInjected.Address(RVA = "0x7656A50", Offset = "0x7655250", VA = "0x187656A50", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x21F3FE0", Offset = "0x21F27E0", VA = "0x1821F3FE0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface DHDAJFAELLF : ODKBKKGKKLB
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	ANECLHJHIDI NPBKJEIDIMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[DefaultMember("Item")]
public class GPMNJIAMOPE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly Dictionary<Guid, KAEHOPMHDBC> JBJNEAGNKCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly Dictionary<string, KAEHOPMHDBC> FEOGFPHBOJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private bool? OEKGKNCEENH;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private long FMJKOMLKOEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8BB020", Offset = "0x8B9820", VA = "0x1808BB020")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public KAEHOPMHDBC DBNKEBOPCEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7650180", Offset = "0x764E980", VA = "0x187650180")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x76501E0", Offset = "0x764E9E0", VA = "0x1876501E0")]
	public void OHHHDMGDIOD(long NKDNOGOOODN, IEnumerable<CEFHKFDMFIL> KHJALAOKJEJ, IEnumerable<FPBJCHLAPPB> CCFCLAECIMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x764F830", Offset = "0x764E030", VA = "0x18764F830")]
	public bool EAPLDICGPLC(Guid JBDEJHNEIJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x764F810", Offset = "0x764E010", VA = "0x18764F810")]
	public bool CGFLGFPAOEK(Guid JBDEJHNEIJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x764F110", Offset = "0x764D910", VA = "0x18764F110")]
	public bool ACKLPFGPMCD(CEFHKFDMFIL DDBEBKOPPII, [Out] CEFHKFDMFIL FKNHCJFBEFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x764FE00", Offset = "0x764E600", VA = "0x18764FE00")]
	public IEnumerable<KAEHOPMHDBC> IGNPPNFLNKP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x764FC30", Offset = "0x764E430", VA = "0x18764FC30")]
	public IEnumerable<CEFHKFDMFIL> HOPODIDKBBA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x764FE50", Offset = "0x764E650", VA = "0x18764FE50")]
	public IEnumerable<FPBJCHLAPPB> JJGPFKJGBJG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x764F930", Offset = "0x764E130", VA = "0x18764F930")]
	public bool GCPPHIFEEDA(Guid JBDEJHNEIJJ, [Out] CEFHKFDMFIL FNKEDEBOPKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x764F770", Offset = "0x764DF70", VA = "0x18764F770")]
	public bool BKGIBKGPAOO(string IDOHMDLMDFL, [Out] CEFHKFDMFIL FNKEDEBOPKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x764FFE0", Offset = "0x764E7E0", VA = "0x18764FFE0")]
	public bool KMFKLFJKCDN(Guid JBDEJHNEIJJ, [Out] FPBJCHLAPPB EJJDLGLKJKD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x764F890", Offset = "0x764E090", VA = "0x18764F890")]
	public bool FLHFAIOMADN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x764FD80", Offset = "0x764E580", VA = "0x18764FD80")]
	private bool IGEHMCACOEK(CEFHKFDMFIL HJMMFMOBFMP, CEFHKFDMFIL EFGILEBJOIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x764F9E0", Offset = "0x764E1E0", VA = "0x18764F9E0")]
	private void GEOJBIMJLHJ(Guid ECDOOAABOPD, KAEHOPMHDBC JKLGODGPFPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x764F520", Offset = "0x764DD20", VA = "0x18764F520")]
	private bool BECLLIBHPPM(Guid ECDOOAABOPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7650090", Offset = "0x764E890", VA = "0x187650090")]
	private void KOBBHPOANCA(CEFHKFDMFIL BJDDIHJGIDI, [Optional] CEFHKFDMFIL JIBBIAHFJPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x764F340", Offset = "0x764DB40", VA = "0x18764F340")]
	private bool AHKPKKMGJBF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x764FFA0", Offset = "0x764E7A0", VA = "0x18764FFA0")]
	private static bool KLBGCPKBPON(CEFHKFDMFIL DEDDGCENOOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7650830", Offset = "0x764F030", VA = "0x187650830")]
	public GPMNJIAMOPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class ANECLHJHIDI : OIMBFMJJBEE, FJNBPPDGJPA, IDisposable, OJOFKFJKPOJ
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private struct PIBGCCPPOKK : IEquatable<PIBGCCPPOKK>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public long FMJKOMLKOEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public Guid OKMEAKFPMLD;

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x46D6380", Offset = "0x46D4B80", VA = "0x1846D6380")]
		public PIBGCCPPOKK(long NKDNOGOOODN, Guid JBDEJHNEIJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x7656630", Offset = "0x7654E30", VA = "0x187656630", Slot = "4")]
		public bool Equals(PIBGCCPPOKK LIHCAHPMPHD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x76564D0", Offset = "0x7654CD0", VA = "0x1876564D0", Slot = "0")]
		public override bool Equals(object INCBEIDOHDO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x7656730", Offset = "0x7654F30", VA = "0x187656730", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct FGJLAIDKGAK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public AsyncTaskMethodBuilder<DNFCNMKAMCE<CEFHKFDMFIL, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public ANECLHJHIDI <>4__this;

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
		public List<LFBCALJHPGG> newTags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public bool allowRename;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private TaskAwaiter<MKPPIINILAK<IFEBHLBMMMJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x764CD40", Offset = "0x764B540", VA = "0x18764CD40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x764D240", Offset = "0x764BA40", VA = "0x18764D240", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct IOHPGOPAOMI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncTaskMethodBuilder<DNFCNMKAMCE<CEFHKFDMFIL, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public ANECLHJHIDI <>4__this;

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
		private TaskAwaiter<MKPPIINILAK<IFEBHLBMMMJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x7651F30", Offset = "0x7650730", VA = "0x187651F30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x7652780", Offset = "0x7650F80", VA = "0x187652780", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct JPLCIELLFEA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public AsyncTaskMethodBuilder<DNFCNMKAMCE<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public ANECLHJHIDI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private CEFHKFDMFIL <itemToDelete>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private BIIFNDDLCPA <result>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private TaskAwaiter<BIIFNDDLCPA> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x76527F0", Offset = "0x7650FF0", VA = "0x1876527F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x7652FF0", Offset = "0x76517F0", VA = "0x187652FF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct AIKJNFHMKHE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public ANECLHJHIDI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public OEDKOGGDKCO player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private TaskAwaiter<int> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7643C10", Offset = "0x7642410", VA = "0x187643C10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x7643F90", Offset = "0x7642790", VA = "0x187643F90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct PHKHGEDKHMP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public AsyncTaskMethodBuilder<NIDFFOKILOC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public ANECLHJHIDI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public OEDKOGGDKCO recipient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public int quantity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private TaskAwaiter<NIDFFOKILOC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7656000", Offset = "0x7654800", VA = "0x187656000", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7656460", Offset = "0x7654C60", VA = "0x187656460", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct EMJEPJGBPBF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public AsyncTaskMethodBuilder<DNFCNMKAMCE<PMKLBAJPLGH, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public ANECLHJHIDI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public long tagId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public RoomInventoryTagClientProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private PMKLBAJPLGH <newTag>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private TaskAwaiter<TaskStatus> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x764C850", Offset = "0x764B050", VA = "0x18764C850", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x764CCD0", Offset = "0x764B4D0", VA = "0x18764CCD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct AFIALNEPJBM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public AsyncTaskMethodBuilder<DNFCNMKAMCE<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public ANECLHJHIDI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public long tagId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private List<PMKLBAJPLGH>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private TaskAwaiter<DNFCNMKAMCE<PMKLBAJPLGH, string>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private TaskAwaiter<BIIFNDDLCPA> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x7642F90", Offset = "0x7641790", VA = "0x187642F90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x7643BA0", Offset = "0x76423A0", VA = "0x187643BA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct MHLOEADJMPB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public AsyncTaskMethodBuilder<DNFCNMKAMCE<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public ANECLHJHIDI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public bool isEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private TaskAwaiter<BIIFNDDLCPA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x7653060", Offset = "0x7651860", VA = "0x187653060", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x7653580", Offset = "0x7651D80", VA = "0x187653580", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct HAKIOCDNDBI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public AsyncTaskMethodBuilder<Dictionary<long, LFBCALJHPGG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public Dictionary<long, int> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public ANECLHJHIDI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private TaskAwaiter<MKPPIINILAK<List<LFBCALJHPGG>>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x7650910", Offset = "0x764F110", VA = "0x187650910", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x76512D0", Offset = "0x764FAD0", VA = "0x1876512D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct FKLPFMNGHGC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public ANECLHJHIDI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public FPBJCHLAPPB playerRoomInventoryItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public int quantity;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct PCJPAFFDDCF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public AsyncTaskMethodBuilder<NIDFFOKILOC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public ANECLHJHIDI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public int quantity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private FKLPFMNGHGC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public OEDKOGGDKCO awardingPlayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public Guid remoteOperationId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private TaskAwaiter<FJANAPFOKNF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x76538D0", Offset = "0x76520D0", VA = "0x1876538D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x7653D20", Offset = "0x7652520", VA = "0x187653D20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private struct MHBJMDCGHNB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public Dictionary<PIBGCCPPOKK, int> idsAndQuantities;
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class HPHNNKKGKMM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public FJANAPFOKNF result;

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public HPHNNKKGKMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x7651EC0", Offset = "0x76506C0", VA = "0x187651EC0")]
		internal NAILJMDAFCD EKKBNCMPKJN(PIBGCCPPOKK id)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct HONJFOHJDDN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public AsyncTaskMethodBuilder<Dictionary<PIBGCCPPOKK, NAILJMDAFCD>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public Dictionary<PIBGCCPPOKK, int> idsAndQuantities;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public ANECLHJHIDI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private MHBJMDCGHNB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private TaskAwaiter<List<NAILJMDAFCD>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x7651380", Offset = "0x764FB80", VA = "0x187651380", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x7651E50", Offset = "0x7650650", VA = "0x187651E50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct PFOEMILPAGF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public AsyncTaskMethodBuilder<List<NAILJMDAFCD>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public Dictionary<PIBGCCPPOKK, int> idsAndQuantities;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public ANECLHJHIDI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private List<NAILJMDAFCD> <results>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private int <attemptNumber>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private TaskAwaiter<List<NAILJMDAFCD>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x7653D90", Offset = "0x7652590", VA = "0x187653D90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x7654CF0", Offset = "0x76534F0", VA = "0x187654CF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct PGFLODABPGA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public ANECLHJHIDI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private Task<List<IFEBHLBMMMJ>> <roomInventoryTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private Task<List<DKDHHAGBMMD>> <playerRoomInventoryTask>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private Task<List<LFBCALJHPGG>> <roomInventoryTagsTask>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private Task<INGPJFANNNJ> <roomConfigsTask>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private IEnumerable<CEFHKFDMFIL> <roomInventoryItems>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private IEnumerable<FPBJCHLAPPB> <playerRoomInventoryItems>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private List<PMKLBAJPLGH> <roomInventoryTags>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private TaskAwaiter<List<IFEBHLBMMMJ>> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private TaskAwaiter<List<DKDHHAGBMMD>> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private TaskAwaiter<List<LFBCALJHPGG>> <>u__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private TaskAwaiter<INGPJFANNNJ> <>u__5;

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x7654D60", Offset = "0x7653560", VA = "0x187654D60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x7655FA0", Offset = "0x76547A0", VA = "0x187655FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private struct GMMBPFGKEEL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public ANECLHJHIDI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private TaskAwaiter<Task> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x764EA20", Offset = "0x764D220", VA = "0x18764EA20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x764F0B0", Offset = "0x764D8B0", VA = "0x18764F0B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private struct FHNGGMALEKO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public ANECLHJHIDI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public OEDKOGGDKCO player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private TaskAwaiter<int> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x764D2B0", Offset = "0x764BAB0", VA = "0x18764D2B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x764D7A0", Offset = "0x764BFA0", VA = "0x18764D7A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private struct AOBJELPILAJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public AsyncTaskMethodBuilder<NIDFFOKILOC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public ANECLHJHIDI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public OEDKOGGDKCO player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public int quantity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private TaskAwaiter<NIDFFOKILOC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x764B8D0", Offset = "0x764A0D0", VA = "0x18764B8D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x764BDD0", Offset = "0x764A5D0", VA = "0x18764BDD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private struct EIHEKILCJNP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public CEFHKFDMFIL itemToDelete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public ANECLHJHIDI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private Dictionary<long, bool>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private TaskAwaiter<DNFCNMKAMCE<bool, string>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x764BE40", Offset = "0x764A640", VA = "0x18764BE40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x764C7F0", Offset = "0x764AFF0", VA = "0x18764C7F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly TimeSpan HKCBNFBIFDM;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private const float FCANNBNMLFL = 10f;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private const float GPDDNAONCLJ = 3f;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal const int IGPIPPLMPMC = 3;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	internal const string KBEBCCGENJA = "econ_room_inventory_gate";

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	internal const string PNHNMDJOELK = "experiences_room_inventory_tags_gate";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly FAGJNEBIIDJ JHHNOHKBCAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly IEINLKOEIPI GAAJEJJHDMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly DLGOAIJFHCN NGBBABOBMNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly HGKHIOLHJPP LEJEECBGKEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly GJJDONCPPAE NHIOFEPMPGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly DHDAJFAELLF IJCBIDCPDMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly KHOLIEJJFCA PDNGGKANKHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly GBIGPPKDPBM HAMKICKFBIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly AHGKHMPHOLL DCJDJCGFMMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly GPMNJIAMOPE IKAOBACCOOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly GEHPHHHMGJH FIJJPIDHGFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly HBBGLOJCOEF JJHIOFCHNMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly CancellationTokenSource DGJHGLNBJFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly FAMNCALBPCD<PIBGCCPPOKK, NAILJMDAFCD> GFMDOLKAJJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly FAMNCALBPCD<long, LFBCALJHPGG> KLMIFIFBPLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly NJFKCDEIMBN MBHDHEACNOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly IDisposable PHJIEBMHAOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private Task LGHICKEKPJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private CancellationTokenSource MBBKOEGALCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private long FGCNLFGENPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private bool BCEDAPNKMCC;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private POEJJOMFIEC EONOMLBIKCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7647620", Offset = "0x7645E20", VA = "0x187647620")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public GCOJJNPJFGN PJFMNIDIPED
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x96DD80", Offset = "0x96C580", VA = "0x18096DD80", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x96DD90", Offset = "0x96C590", VA = "0x18096DD90", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public ANHAMBLCGDC<CEFHKFDMFIL> GELDIFLJBEK
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9DB540", Offset = "0x9D9D40", VA = "0x1809DB540", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xD0BF00", Offset = "0xD0A700", VA = "0x180D0BF00", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public ANHAMBLCGDC<Guid> GIBJCGDCEAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9DB530", Offset = "0x9D9D30", VA = "0x1809DB530", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9851F0", Offset = "0x9839F0", VA = "0x1809851F0", Slot = "9")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public BHNOANLGPMK<FPBJCHLAPPB, int> IMLELFCMBDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9DB340", Offset = "0x9D9B40", VA = "0x1809DB340", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xADBAA0", Offset = "0xADA2A0", VA = "0x180ADBAA0", Slot = "11")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public ANHAMBLCGDC<PMKLBAJPLGH> HABJMAOFJEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8C0CA0", Offset = "0x8BF4A0", VA = "0x1808C0CA0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8C0CF0", Offset = "0x8BF4F0", VA = "0x1808C0CF0", Slot = "13")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public ANHAMBLCGDC<long> POCDGHAKIIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x9DB4E0", Offset = "0x9D9CE0", VA = "0x1809DB4E0", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xF68360", Offset = "0xF66B60", VA = "0x180F68360", Slot = "15")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public GCOJJNPJFGN JEFDJOPMGCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x9DB4D0", Offset = "0x9D9CD0", VA = "0x1809DB4D0", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xD92420", Offset = "0xD90C20", VA = "0x180D92420", Slot = "17")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public GCOJJNPJFGN IPGLOJICGIA
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x984640", Offset = "0x982E40", VA = "0x180984640", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x984430", Offset = "0x982C30", VA = "0x180984430", Slot = "19")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7644C60", Offset = "0x7643460", VA = "0x187644C60")]
	[PDAMAKFHAHC.ELHPMEBKNPF.EOFCJBJBGID]
	internal static void ANCFBKBPAGI(CMONJLKOOCI MFHCHOKEAIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x764AD50", Offset = "0x7649550", VA = "0x18764AD50")]
	[RecRoom.NoEngine.Common.Preserve]
	public ANECLHJHIDI([NDCFMLCHJCI(null)] FAGJNEBIIDJ JHHNOHKBCAO, [NDCFMLCHJCI(null)] IEINLKOEIPI GAAJEJJHDMH, [NDCFMLCHJCI(null)] DLGOAIJFHCN NGBBABOBMNP, [NDCFMLCHJCI(null)] HGKHIOLHJPP LEJEECBGKEO, [NDCFMLCHJCI(null)] DLEJEIAEBAP PMFNDHNLNNO, [NDCFMLCHJCI(null)] GJJDONCPPAE NHIOFEPMPGJ, [NDCFMLCHJCI(null)] DHDAJFAELLF IJCBIDCPDMF, [NDCFMLCHJCI(null)] MEJCKJGIGIH IOGLKJMAJLK, [NDCFMLCHJCI(null)] EMOMNBKNBIH EHGBFEMOALD, [NDCFMLCHJCI(null)] KHOLIEJJFCA PDNGGKANKHA, [NDCFMLCHJCI(null)] GBIGPPKDPBM HAMKICKFBIP, [NDCFMLCHJCI(null)] AHGKHMPHOLL DCJDJCGFMMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x76460F0", Offset = "0x76448F0", VA = "0x1876460F0", Slot = "53")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x76470E0", Offset = "0x76458E0", VA = "0x1876470E0", Slot = "52")]
	public Task GHGGCIMCKPB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7649270", Offset = "0x7647A70", VA = "0x187649270", Slot = "20")]
	[AsyncStateMachine(typeof(FGJLAIDKGAK))]
	public Task<DNFCNMKAMCE<CEFHKFDMFIL, string>> LCLOELNHIAN(Guid? HJJKIPAJDBE, long NKDNOGOOODN, string IKMKCMDHFDC, string GIMKNCGKHFF, string DFDGAJNBHBE, RoomInventoryItemProperties DABHNNJBAFE, byte LJMPACNDPEI, int LCDEMOPFJEN, [Optional] List<long> HLODAEEPKPK, [Optional] List<LFBCALJHPGG> BDFCJHGHMEK, bool BDDIGPLKNCP = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7644AA0", Offset = "0x76432A0", VA = "0x187644AA0", Slot = "21")]
	[AsyncStateMachine(typeof(IOHPGOPAOMI))]
	public Task<DNFCNMKAMCE<CEFHKFDMFIL, string>> AKNEOEDBLLC(Guid JBDEJHNEIJJ, long NKDNOGOOODN, [Optional] string IKMKCMDHFDC, [Optional] string GIMKNCGKHFF, [Optional] string DFDGAJNBHBE, [Optional] List<long> HLODAEEPKPK, [Optional] Dictionary<string, RoomInventoryTagClientProperties> BDFCJHGHMEK, [Optional] RoomInventoryItemProperties DABHNNJBAFE, [Optional] byte? LJMPACNDPEI, [Optional] int? LCDEMOPFJEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7649430", Offset = "0x7647C30", VA = "0x187649430", Slot = "22")]
	[AsyncStateMachine(typeof(JPLCIELLFEA))]
	public Task<DNFCNMKAMCE<bool, string>> LDBFJOOLGHE(Guid JBDEJHNEIJJ, long NKDNOGOOODN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7645D30", Offset = "0x7644530", VA = "0x187645D30", Slot = "23")]
	public IReadOnlyList<CEFHKFDMFIL> DKFFLOHODIB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7648580", Offset = "0x7646D80", VA = "0x187648580", Slot = "24")]
	public IReadOnlyList<CEFHKFDMFIL> IOKPBKEOHGO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7646310", Offset = "0x7644B10", VA = "0x187646310", Slot = "25")]
	public bool EEOGNHCNLCO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7646FC0", Offset = "0x76457C0", VA = "0x187646FC0", Slot = "26")]
	public bool GCPPHIFEEDA(Guid JBDEJHNEIJJ, [Out] CEFHKFDMFIL FNKEDEBOPKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7645010", Offset = "0x7643810", VA = "0x187645010", Slot = "27")]
	public bool BKGIBKGPAOO(string ICMBPAJIKBH, [Out] CEFHKFDMFIL FNKEDEBOPKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7647430", Offset = "0x7645C30", VA = "0x187647430", Slot = "28")]
	public IReadOnlyList<FPBJCHLAPPB> HKKPMEHCAOK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7649140", Offset = "0x7647940", VA = "0x187649140", Slot = "29")]
	public bool KMFKLFJKCDN(Guid JBDEJHNEIJJ, [Out] FPBJCHLAPPB EJJDLGLKJKD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x764A1B0", Offset = "0x76489B0", VA = "0x18764A1B0", Slot = "30")]
	public long? OLGEPEBJFEE(Guid JBDEJHNEIJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7648B20", Offset = "0x7647320", VA = "0x187648B20", Slot = "51")]
	public void KALOELGHCJO(IEnumerable<DKDHHAGBMMD> CCFCLAECIMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x76499E0", Offset = "0x76481E0", VA = "0x1876499E0", Slot = "31")]
	[AsyncStateMachine(typeof(AIKJNFHMKHE))]
	public Task<int> LPJENNDHMCK(OEDKOGGDKCO FGIHDJGGIMF, Guid JBDEJHNEIJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x764A340", Offset = "0x7648B40", VA = "0x18764A340", Slot = "32")]
	[AsyncStateMachine(typeof(PHKHGEDKHMP))]
	public Task<NIDFFOKILOC> ONNBPLALJAM(OEDKOGGDKCO OJEALAPMAJH, Guid JBDEJHNEIJJ, int CEHMFIFBHOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7645B60", Offset = "0x7644360", VA = "0x187645B60", Slot = "33")]
	public string DJIAMLANJMJ(FJANAPFOKNF HANDIANDCDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x76454A0", Offset = "0x7643CA0", VA = "0x1876454A0", Slot = "34")]
	public bool DAPMHGKGKKK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7649B20", Offset = "0x7648320", VA = "0x187649B20", Slot = "38")]
	[AsyncStateMachine(typeof(EMJEPJGBPBF))]
	public Task<DNFCNMKAMCE<PMKLBAJPLGH, string>> MJMINGHHGGD(long DKAEPLEJMII, RoomInventoryTagClientProperties DABHNNJBAFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7645130", Offset = "0x7643930", VA = "0x187645130", Slot = "39")]
	[AsyncStateMachine(typeof(AFIALNEPJBM))]
	public Task<DNFCNMKAMCE<bool, string>> BKPKFCMEIGB(long DKAEPLEJMII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7646550", Offset = "0x7644D50", VA = "0x187646550", Slot = "42")]
	public List<(long, int)> EJODJBAAOEJ(long EABLHEFEBBM, int ONNHGIDDOJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7647DB0", Offset = "0x76465B0", VA = "0x187647DB0", Slot = "43")]
	public bool IBHMJHACAFO(long DKAEPLEJMII, [Out] PMKLBAJPLGH NJOFMLJFGME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7646060", Offset = "0x7644860", VA = "0x187646060", Slot = "44")]
	public bool DOMEICMDEEI(string GIHEFEHAKAF, [Out] PMKLBAJPLGH NJOFMLJFGME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7645960", Offset = "0x7644160", VA = "0x187645960", Slot = "45")]
	public bool DEKIMMDHGGI(long DKAEPLEJMII, Guid AIHFDFMJDOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7647180", Offset = "0x7645980", VA = "0x187647180", Slot = "46")]
	public IReadOnlyList<PMKLBAJPLGH> HHGIFDDDIDP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x76452E0", Offset = "0x7643AE0", VA = "0x1876452E0", Slot = "47")]
	public List<PMKLBAJPLGH> CNIJDFOLJLN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7648D90", Offset = "0x7647590", VA = "0x187648D90", Slot = "48")]
	public IReadOnlyList<PMKLBAJPLGH> KKOJCJHKLFG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x76488C0", Offset = "0x76470C0", VA = "0x1876488C0", Slot = "41")]
	public bool JBMKCMOIHEA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7649EE0", Offset = "0x76486E0", VA = "0x187649EE0", Slot = "49")]
	public IReadOnlyList<CEFHKFDMFIL> NIIFDLBDHNC(long DKAEPLEJMII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7647C90", Offset = "0x7646490", VA = "0x187647C90", Slot = "40")]
	[AsyncStateMachine(typeof(MHLOEADJMPB))]
	public Task<DNFCNMKAMCE<bool, string>> HNPDMFCGCMF(long NKDNOGOOODN, bool MDKHOHFGOEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7648850", Offset = "0x7647050", VA = "0x187648850", Slot = "54")]
	public bool JBIPMJKADBL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x76477E0", Offset = "0x7645FE0", VA = "0x1876477E0", Slot = "50")]
	public bool HLOEPINFJDI(string GIHEFEHAKAF, [Out] IReadOnlyList<CEFHKFDMFIL> EHOMMMMHDBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7645DE0", Offset = "0x76445E0", VA = "0x187645DE0")]
	[AsyncStateMachine(typeof(HAKIOCDNDBI))]
	private Task<Dictionary<long, LFBCALJHPGG>> DKOEKKHEHMD(Dictionary<long, int> OGGNALBGGIL, CancellationToken ALKEMFHOMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7646DB0", Offset = "0x76455B0", VA = "0x187646DB0")]
	[AsyncStateMachine(typeof(PCJPAFFDDCF))]
	private Task<NIDFFOKILOC> FLONIDNFLMJ(Guid JBDEJHNEIJJ, int CEHMFIFBHOE, [Optional] Guid DJCGBABKHID, [Optional] OEDKOGGDKCO GKFEHMBNHNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7645F20", Offset = "0x7644720", VA = "0x187645F20")]
	[AsyncStateMachine(typeof(HONJFOHJDDN))]
	private Task<Dictionary<PIBGCCPPOKK, NAILJMDAFCD>> DMABCLJFIBO(Dictionary<PIBGCCPPOKK, int> CHJEPNMKFKC, CancellationToken ALKEMFHOMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7648270", Offset = "0x7646A70", VA = "0x187648270")]
	[AsyncStateMachine(typeof(PFOEMILPAGF))]
	private Task<List<NAILJMDAFCD>> IMHHPNNCFFM(Dictionary<PIBGCCPPOKK, int> CHJEPNMKFKC, CancellationToken ALKEMFHOMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7645370", Offset = "0x7643B70", VA = "0x187645370")]
	[AsyncStateMachine(typeof(PGFLODABPGA))]
	private Task DAKHJIBKOLH(long NKDNOGOOODN, CancellationToken ALKEMFHOMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7644480", Offset = "0x7642C80", VA = "0x187644480")]
	private Task AHIFBLDDBDF(DLBOGIKOAJL GIOJKAECAOO, CancellationToken ALKEMFHOMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7648940", Offset = "0x7647140", VA = "0x187648940")]
	[AsyncStateMachine(typeof(GMMBPFGKEEL))]
	private Task JFNDEHHMICC(DLBOGIKOAJL GIOJKAECAOO, CancellationToken PGAPJEGCHID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7644CD0", Offset = "0x76434D0", VA = "0x187644CD0")]
	private void BDCLBHIKMHI(IFEBHLBMMMJ DNGJLLAGICH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x764A830", Offset = "0x7649030", VA = "0x18764A830")]
	[HCPJMGGDDLG]
	private void RpcOnNotifiedOfRoomInventoryItemCreatedOrUpdated(string LAHCAPPKABF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7644310", Offset = "0x7642B10", VA = "0x187644310")]
	private void ADLCGLMEHCG(Guid JBDEJHNEIJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x764A970", Offset = "0x7649170", VA = "0x18764A970")]
	[HCPJMGGDDLG]
	private void RpcOnNotifiedOfRoomInventoryItemDeleted(Guid JBDEJHNEIJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7646410", Offset = "0x7644C10", VA = "0x187646410")]
	[AsyncStateMachine(typeof(FHNGGMALEKO))]
	private Task<int> EHGFEEOOKLA(OEDKOGGDKCO FGIHDJGGIMF, Guid JBDEJHNEIJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x764A650", Offset = "0x7648E50", VA = "0x18764A650")]
	[HCPJMGGDDLG]
	internal void RpcGetPlayerRoomInventoryCount(Guid PHACDDBECOP, Guid JBDEJHNEIJJ, LCKFECCLALB FONMOIDIMHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x764A5D0", Offset = "0x7648DD0", VA = "0x18764A5D0")]
	[HCPJMGGDDLG]
	internal void RpcGetPlayerRoomInventoryCountResponse(Guid PHACDDBECOP, int NELOIEKKMHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7649C50", Offset = "0x7648450", VA = "0x187649C50")]
	[AsyncStateMachine(typeof(AOBJELPILAJ))]
	private Task<NIDFFOKILOC> MMHKPGGLELL(OEDKOGGDKCO FGIHDJGGIMF, Guid JBDEJHNEIJJ, int CEHMFIFBHOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x764A500", Offset = "0x7648D00", VA = "0x18764A500")]
	[HCPJMGGDDLG]
	internal void RpcAddOrRemovePlayerRoomInventoryRequest(Guid PHACDDBECOP, Guid JBDEJHNEIJJ, int CEHMFIFBHOE, LCKFECCLALB FONMOIDIMHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x76448E0", Offset = "0x76430E0", VA = "0x1876448E0")]
	private void AJAGLBCBJJB(OEDKOGGDKCO OJEALAPMAJH, Guid PHACDDBECOP, FJANAPFOKNF HANDIANDCDI, long JHIGGIHBAKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x764AC20", Offset = "0x7649420", VA = "0x18764AC20")]
	[HCPJMGGDDLG]
	internal void RpcSendAddOrRemovePlayerRoomInventoryResultToPlayer(Guid PHACDDBECOP, int HANDIANDCDI, long JHIGGIHBAKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7644000", Offset = "0x7642800", VA = "0x187644000")]
	private void ACIFJOIEEOL(bool MDKHOHFGOEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x764ABC0", Offset = "0x76493C0", VA = "0x18764ABC0")]
	[HCPJMGGDDLG]
	private void RpcOnNotifiedOfSortingTabIsEnabledToggled(bool NDAJFOINHKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7646830", Offset = "0x7645030", VA = "0x187646830")]
	private void ELGKIKBCNIN(List<LFBCALJHPGG> COGLGOGKOCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x764AA10", Offset = "0x7649210", VA = "0x18764AA10")]
	[HCPJMGGDDLG]
	private void RpcOnNotifiedOfRoomInventoryTagUpdates(string PBILFDMFDDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7647670", Offset = "0x7645E70", VA = "0x187647670")]
	private void HLGFKOEAOML(long DKAEPLEJMII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x764A9A0", Offset = "0x76491A0", VA = "0x18764A9A0")]
	[HCPJMGGDDLG]
	private void RpcOnNotifiedOfRoomInventoryTagDeleted(long DKAEPLEJMII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7644DF0", Offset = "0x76435F0", VA = "0x187644DF0")]
	private CEFHKFDMFIL BJILPMHHLKA(IFEBHLBMMMJ DNGJLLAGICH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7647250", Offset = "0x7645A50", VA = "0x187647250")]
	private List<PMKLBAJPLGH> HKKMKLHIJFB(List<LFBCALJHPGG> COGLGOGKOCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7646950", Offset = "0x7645150", VA = "0x187646950")]
	private List<PMKLBAJPLGH> FDMOKPBPDBI(IEnumerable<LFBCALJHPGG> COGLGOGKOCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x7647E40", Offset = "0x7646640", VA = "0x187647E40", Slot = "36")]
	public RoomInventoryItemProperties IMBOIALMNDA(string CHCBEMINJOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7644170", Offset = "0x7642970", VA = "0x187644170")]
	private CEFHKFDMFIL ADFEEBMKDHK(IFEBHLBMMMJ DNGJLLAGICH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7649DA0", Offset = "0x76485A0", VA = "0x187649DA0", Slot = "35")]
	public IFEBHLBMMMJ MMKKJHKKALD(CEFHKFDMFIL KDGJNKEIKID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x76495D0", Offset = "0x7647DD0", VA = "0x1876495D0")]
	private PMKLBAJPLGH LOPFPAMOCMJ(LFBCALJHPGG DNGJLLAGICH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7649560", Offset = "0x7647D60", VA = "0x187649560")]
	private void LNBICMHMONE(FPBJCHLAPPB EJJDLGLKJKD, int INMMFFMHHAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x764A490", Offset = "0x7648C90", VA = "0x18764A490")]
	private void PIFFBOIHFAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x7649860", Offset = "0x7648060", VA = "0x187649860")]
	private Task LPHEANELFII()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x7645250", Offset = "0x7643A50", VA = "0x187645250")]
	private void CHMNPAAOEIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7646F00", Offset = "0x7645700", VA = "0x187646F00")]
	private void FMPILDCOBKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7648A10", Offset = "0x7647210", VA = "0x187648A10")]
	private void JGFLFONFIPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x7646CA0", Offset = "0x76454A0", VA = "0x187646CA0")]
	[AsyncStateMachine(typeof(EIHEKILCJNP))]
	private Task FLLBKANPHLG(CEFHKFDMFIL BNEHJIFDOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x76452C0", Offset = "0x7643AC0", VA = "0x1876452C0")]
	[CompilerGenerated]
	private void CJDBHHMNKLI(Task<TaskStatus> DIGFCMIOIEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7645510", Offset = "0x7643D10", VA = "0x187645510")]
	[CompilerGenerated]
	private Task<FJANAPFOKNF> DDCOPMCIECE(FKLPFMNGHGC P_0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x76483B0", Offset = "0x7646BB0", VA = "0x1876483B0")]
	[CompilerGenerated]
	internal static Dictionary<PIBGCCPPOKK, NAILJMDAFCD> INCPJBFJBDB(FJANAPFOKNF HANDIANDCDI, MHBJMDCGHNB P_1)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class HBBGLOJCOEF : Dictionary<string, RoomInventoryItemProperties>
{
	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x7651340", Offset = "0x764FB40", VA = "0x187651340")]
	public HBBGLOJCOEF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface EMOMNBKNBIH
{
	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GPMNJIAMOPE MHMBKMIECLG();

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	HBBGLOJCOEF BPAFFONPMNP();

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GEHPHHHMGJH COMCOBANHCM();
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class NAFJJDCCGPJ : EMOMNBKNBIH
{
	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x76535F0", Offset = "0x7651DF0", VA = "0x1876535F0")]
	[PDAMAKFHAHC.ELHPMEBKNPF.EOFCJBJBGID]
	internal static void ANCFBKBPAGI(CMONJLKOOCI MFHCHOKEAIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
	[RecRoom.NoEngine.Common.Preserve]
	public NAFJJDCCGPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x76537C0", Offset = "0x7651FC0", VA = "0x1876537C0", Slot = "4")]
	public GPMNJIAMOPE MHMBKMIECLG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x7653660", Offset = "0x7651E60", VA = "0x187653660", Slot = "5")]
	public HBBGLOJCOEF BPAFFONPMNP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x76536D0", Offset = "0x7651ED0", VA = "0x1876536D0", Slot = "6")]
	public GEHPHHHMGJH COMCOBANHCM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class GEHPHHHMGJH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly Dictionary<long, PMKLBAJPLGH> PFFAGENFIOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private readonly PMKLBAJPLGH[] GJOPNFJOGCB;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool BLINMNGJKEF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x95C5D0", Offset = "0x95ADD0", VA = "0x18095C5D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x95C5F0", Offset = "0x95ADF0", VA = "0x18095C5F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int JJHGLMCLHAP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x764E440", Offset = "0x764CC40", VA = "0x18764E440")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	private long CAPHCJMMPAP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x8BB020", Offset = "0x8B9820", VA = "0x1808BB020")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x764E4A0", Offset = "0x764CCA0", VA = "0x18764E4A0")]
	public void OHHHDMGDIOD(long NKDNOGOOODN, IEnumerable<PMKLBAJPLGH> LJIMCKDEHJA, bool FDHFEIGEIMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x764DDB0", Offset = "0x764C5B0", VA = "0x18764DDB0")]
	public IReadOnlyList<PMKLBAJPLGH> IPMKPOLMKGD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x95C5F0", Offset = "0x95ADF0", VA = "0x18095C5F0")]
	public void NLDMGCFCLNC(bool MDKHOHFGOEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x764DCD0", Offset = "0x764C4D0", VA = "0x18764DCD0")]
	public bool EPJDHEOIDAK(long DKAEPLEJMII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x764E110", Offset = "0x764C910", VA = "0x18764E110")]
	public bool KMJPEKFOALD(PMKLBAJPLGH CBBMJGPMIKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x764D810", Offset = "0x764C010", VA = "0x18764D810")]
	public bool AEJJDHHFBHH(List<PMKLBAJPLGH> CKAJKAALPPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x764E2D0", Offset = "0x764CAD0", VA = "0x18764E2D0")]
	public bool LEEMNHPJMAP(long DKAEPLEJMII, [Out] PMKLBAJPLGH LJMDFKCKKHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x764DF60", Offset = "0x764C760", VA = "0x18764DF60")]
	public bool KGGDABJKJLA(string IKMKCMDHFDC, [Out] PMKLBAJPLGH LJMDFKCKKHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x764E370", Offset = "0x764CB70", VA = "0x18764E370")]
	public List<PMKLBAJPLGH> LEPGJHDICAE(int ECDOOAABOPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x764DB90", Offset = "0x764C390", VA = "0x18764DB90")]
	public List<PMKLBAJPLGH> DKBAEAEAPMD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x71FBAC0", Offset = "0x71FA2C0", VA = "0x1871FBAC0")]
	public PMKLBAJPLGH DHHIEEAPBAD(int ECDOOAABOPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x764DB30", Offset = "0x764C330", VA = "0x18764DB30")]
	public IReadOnlyList<PMKLBAJPLGH> CIDHIDONFNK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x764E960", Offset = "0x764D160", VA = "0x18764E960")]
	public GEHPHHHMGJH()
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
