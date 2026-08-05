using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using RecNet;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.NoEngine.Common;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _AssemblyRegistry.RecRoom_RoomEconomy_RoomOffer_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x87B9B30", Offset = "0x87B8330", VA = "0x1887B9B30", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2731690", Offset = "0x272FE90", VA = "0x182731690")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface AFIIJDEHAHF : CHFDJGPAGJJ
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	JJLOKKBOCEE CHOPFOIMOFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface EPPOEFGBAMM
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CGAGOPHJDOL FLNONEIPHCF();
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class NODCJKHHGDF : EPPOEFGBAMM
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x87B96F0", Offset = "0x87B7EF0", VA = "0x1887B96F0")]
	[NOOFMBJKOEL.KNDBLKJENBF.CEKCOAHLABB]
	internal static void GIPKHEKFDMP(OIKNHNBNAFI MBKOPLBCEJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	[RecRoom.NoEngine.Common.Preserve]
	public NODCJKHHGDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x87B9630", Offset = "0x87B7E30", VA = "0x1887B9630", Slot = "4")]
	public CGAGOPHJDOL FLNONEIPHCF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[DIADIMJDNBG]
public class JJLOKKBOCEE : MBLDBNGILJJ, IDisposable, AHHPCEBMDAG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct HHLHNOKDNDH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public AsyncTaskMethodBuilder<AOGODOAGAAO<CJENCPGHKCL, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public JJLOKKBOCEE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public Guid? originId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public string description;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public string imageName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public int price;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public CEIOGMEMBOM roomOfferType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public Dictionary<Guid, int> roomInventoryItemMappings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public Guid? priceUnitId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public bool allowRename;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private TaskAwaiter<KBEFGPMPCJE<CJENCPGHKCL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x87B1D90", Offset = "0x87B0590", VA = "0x1887B1D90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x87B22C0", Offset = "0x87B0AC0", VA = "0x1887B22C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct HKFIBIIFDFH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public AsyncTaskMethodBuilder<AOGODOAGAAO<CJENCPGHKCL, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public JJLOKKBOCEE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public Guid roomOfferOriginId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public string description;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public string imageName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public int price;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public CEIOGMEMBOM roomOfferType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public Dictionary<Guid, int> roomInventoryItemMappings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public Guid? priceUnitId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private TaskAwaiter<KBEFGPMPCJE<CJENCPGHKCL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x87B2330", Offset = "0x87B0B30", VA = "0x1887B2330", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x87B28D0", Offset = "0x87B10D0", VA = "0x1887B28D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct LPCFIDKCOIO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public AsyncTaskMethodBuilder<AOGODOAGAAO<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public JJLOKKBOCEE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public Guid roomOfferId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private CJENCPGHKCL <existingRoomOffer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private TaskAwaiter<ABCLBNPPLCC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x87B9070", Offset = "0x87B7870", VA = "0x1887B9070", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x87B95C0", Offset = "0x87B7DC0", VA = "0x1887B95C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct EJOPBMMOHPK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public AsyncTaskMethodBuilder<List<OCIONGJHJCB>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public JJLOKKBOCEE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TaskAwaiter<KBEFGPMPCJE<List<OCIONGJHJCB>>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x87B1930", Offset = "0x87B0130", VA = "0x1887B1930", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x87B1D20", Offset = "0x87B0520", VA = "0x1887B1D20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct DEFDJIMFLEL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public JJLOKKBOCEE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public EIGONBNGIIK player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public Guid roomOfferId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private TaskAwaiter<int> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x87B0F50", Offset = "0x87AF750", VA = "0x1887B0F50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x87B12F0", Offset = "0x87AFAF0", VA = "0x1887B12F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct CEHNDPJDHOJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public AsyncTaskMethodBuilder<AOGODOAGAAO<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public JJLOKKBOCEE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public CJENCPGHKCL roomOffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public int quantity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public string purchaseSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public long requestedPrice;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private TaskAwaiter<AOGODOAGAAO<bool, string>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x87AFC50", Offset = "0x87AE450", VA = "0x1887AFC50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x87B01A0", Offset = "0x87AE9A0", VA = "0x1887B01A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct LJNGBKGMDNN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public AsyncTaskMethodBuilder<AOGODOAGAAO<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int quantity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public JJLOKKBOCEE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public CJENCPGHKCL roomOffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public string purchaseSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public long requestedPrice;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public long initialBalance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private OAFHOPCBMLG <operationResult>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private int <attemptNumber>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private CGAPFFNHJNI <response>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private TaskAwaiter<CGAPFFNHJNI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x87B86D0", Offset = "0x87B6ED0", VA = "0x1887B86D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x87B9000", Offset = "0x87B7800", VA = "0x1887B9000", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class JOMJEPDJPIM
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		private struct <<SendRecNetRoomOfferPurchaseRequest>g__FlushPendingInventoryItemUpdatesIfNeeded|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public JOMJEPDJPIM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public Guid itemId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x87B9760", Offset = "0x87B7F60", VA = "0x1887B9760", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x87B9AD0", Offset = "0x87B82D0", VA = "0x1887B9AD0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public JJLOKKBOCEE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public int expectedTotalPrice;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public JOMJEPDJPIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x87B6F40", Offset = "0x87B5740", VA = "0x1887B6F40")]
		[AsyncStateMachine(typeof(<<SendRecNetRoomOfferPurchaseRequest>g__FlushPendingInventoryItemUpdatesIfNeeded|0>d))]
		internal Task CNCKNPGCCLL(Guid itemId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x87B7030", Offset = "0x87B5830", VA = "0x1887B7030")]
		internal Guid? NEJJCENPAMK(Guid itemId)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct JPIAFILOLLJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public AsyncTaskMethodBuilder<CGAPFFNHJNI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public JJLOKKBOCEE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public int requestedPrice;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public int quantity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public CJENCPGHKCL roomOffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private JOMJEPDJPIM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private Dictionary<Guid, Guid?> <concurrencyCodeByItemIdMap>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private Guid <itemId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private TaskAwaiter<CGAPFFNHJNI> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x87B7150", Offset = "0x87B5950", VA = "0x1887B7150", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x87B7E10", Offset = "0x87B6610", VA = "0x1887B7E10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct KBCGEDKHABJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public JJLOKKBOCEE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private Task<KBEFGPMPCJE<List<HDBLDOMEOMG>>> <purchaseCountsTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private TaskAwaiter<List<CJENCPGHKCL>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private TaskAwaiter<KBEFGPMPCJE<List<HDBLDOMEOMG>>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x87B7E80", Offset = "0x87B6680", VA = "0x1887B7E80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x87B8670", Offset = "0x87B6E70", VA = "0x1887B8670", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct CLGCHOPMAJO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public JJLOKKBOCEE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private TaskAwaiter<Task> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x87B0880", Offset = "0x87AF080", VA = "0x1887B0880", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x87B0EF0", Offset = "0x87AF6F0", VA = "0x1887B0EF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct ECBGAJKAONN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public JJLOKKBOCEE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public EIGONBNGIIK player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private TaskAwaiter<int> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x87B1360", Offset = "0x87AFB60", VA = "0x1887B1360", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x87B18C0", Offset = "0x87B00C0", VA = "0x1887B18C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly TimeSpan JMAKJFAAGGH;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public const string MHKFHLLHAJC = "econ_room_offer_gate";

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private const string KNLALCOPLKL = "Unknown error occured. If this persists, please contact us at recroom.zendesk.com";

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private const string NHOBPJINLJN = "CV2_Purchase_Prompt_Chip";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly CKIHFLNIBIM JOLIIACCDMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly CLPMKNHLPCN LNNANJEPCEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly KFEPJAFNPGM PBHONBJDMJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly OKNMANBEBON ANOIHLPEACA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly KEPFCCDBCHI EAJAPJIJBMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly AFIIJDEHAHF BEJJCKOMLAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly MOLCMOLMINK PJHMONPOPCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly HCPIDJLKNNN ODOOBNNKFAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly FEAPIENHOEM ILCIONEPKIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly FKEACPHKBJP DHJDPACKPOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly CGAGOPHJDOL PPGNAMHMGAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private Dictionary<Guid, int> GIJLCNKNHOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly IDisposable OHBPNFPMNGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private Task PBNONDGLLDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private CancellationTokenSource EAGJDNEELJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private long OGHPNFLALBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool LKNCKMOIEPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly HNMGKCJHCKG KJDHGOAKCBA;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private MCENAIEHOIL MPHHBBDCNDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x87B4A00", Offset = "0x87B3200", VA = "0x1887B4A00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public KECNPIDOCPH DJPAAFABOFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xA8E350", Offset = "0xA8CB50", VA = "0x180A8E350", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xEEFE60", Offset = "0xEEE660", VA = "0x180EEFE60", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public LBOAOFAOKMM<CJENCPGHKCL> EIIKPIBBIAF
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xA2B840", Offset = "0xA2A040", VA = "0x180A2B840", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xA2B7E0", Offset = "0xA29FE0", VA = "0x180A2B7E0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public LBOAOFAOKMM<Guid> OEMEKLNHDMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xDF01C0", Offset = "0xDEE9C0", VA = "0x180DF01C0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xEF9690", Offset = "0xEF7E90", VA = "0x180EF9690", Slot = "9")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x87B4740", Offset = "0x87B2F40", VA = "0x1887B4740")]
	[NOOFMBJKOEL.KNDBLKJENBF.CEKCOAHLABB]
	internal static void GIPKHEKFDMP(OIKNHNBNAFI MBKOPLBCEJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x87B6820", Offset = "0x87B5020", VA = "0x1887B6820")]
	[RecRoom.NoEngine.Common.Preserve]
	public JJLOKKBOCEE([FAPODKMFODF(null)] CKIHFLNIBIM JOLIIACCDMG, [FAPODKMFODF(null)] CLPMKNHLPCN LNNANJEPCEJ, [FAPODKMFODF(null)] FNBFDEKMNMG ELFBOFKBFJF, [FAPODKMFODF(null)] KFEPJAFNPGM PBHONBJDMJA, [FAPODKMFODF(null)] EPPOEFGBAMM LDCCGKMIPEF, [FAPODKMFODF(null)] OKNMANBEBON ANOIHLPEACA, [FAPODKMFODF("ShowPurchasePromptRateLimiter")] KEPFCCDBCHI EAJAPJIJBMI, [FAPODKMFODF(null)] AFIIJDEHAHF BEJJCKOMLAH, [FAPODKMFODF(null)] CAEONDNKLHG ONMNPBNFIOC, [FAPODKMFODF(null)] MOLCMOLMINK PJHMONPOPCI, [FAPODKMFODF(null)] HCPIDJLKNNN ODOOBNNKFAC, [FAPODKMFODF(null)] FEAPIENHOEM ILCIONEPKIN, [FAPODKMFODF(null)] FKEACPHKBJP DHJDPACKPOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x87B41B0", Offset = "0x87B29B0", VA = "0x1887B41B0", Slot = "23")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x87B2E20", Offset = "0x87B1620", VA = "0x1887B2E20", Slot = "10")]
	[AsyncStateMachine(typeof(HHLHNOKDNDH))]
	public Task<AOGODOAGAAO<CJENCPGHKCL, string>> AGIJOOBMBFH(Guid? LOEJBFFHLNB, long GFHIJAKOMMI, string HPANEBBHGAC, string LLAMBGFCPPC, string FLCIMENMGDL, int BIALCILCFBL, CEIOGMEMBOM FAHKMFNKDCA, [Optional] Dictionary<Guid, int> GFHKKGNJCKD, [Optional] Guid? IFDGEOCAELE, bool DGBBFPCCGCI = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x87B4DF0", Offset = "0x87B35F0", VA = "0x1887B4DF0", Slot = "11")]
	[AsyncStateMachine(typeof(HKFIBIIFDFH))]
	public Task<AOGODOAGAAO<CJENCPGHKCL, string>> JGOPNKDFHPC(Guid NDKAGDDHHMA, long GFHIJAKOMMI, string HPANEBBHGAC, string LLAMBGFCPPC, string FLCIMENMGDL, int BIALCILCFBL, CEIOGMEMBOM FAHKMFNKDCA, [Optional] Dictionary<Guid, int> GFHKKGNJCKD, [Optional] Guid? IFDGEOCAELE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x87B5F40", Offset = "0x87B4740", VA = "0x1887B5F40", Slot = "12")]
	[AsyncStateMachine(typeof(LPCFIDKCOIO))]
	public Task<AOGODOAGAAO<bool, string>> NGKAADBIPKL(Guid NDLIOGEDEPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x87B4620", Offset = "0x87B2E20", VA = "0x1887B4620", Slot = "13")]
	public IEnumerable<CJENCPGHKCL> FEIHHDNFBJK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x87B4410", Offset = "0x87B2C10", VA = "0x1887B4410", Slot = "14")]
	[AsyncStateMachine(typeof(EJOPBMMOHPK))]
	public Task<List<OCIONGJHJCB>> ECIICNFCKAH(long GFHIJAKOMMI, [Optional] CancellationToken GMEAHOBHMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x87B3C60", Offset = "0x87B2460", VA = "0x1887B3C60", Slot = "17")]
	public bool DHICKLCFDPD(Guid NDLIOGEDEPM, int FGDJEIODDLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x87B37F0", Offset = "0x87B1FF0", VA = "0x1887B37F0", Slot = "15")]
	public bool BCKEADMGCKD(Guid NDLIOGEDEPM, [Out] CJENCPGHKCL JGGCFNPHPOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x87B4A50", Offset = "0x87B3250", VA = "0x1887B4A50", Slot = "16")]
	public bool IIEJPMMPPJB(string HPANEBBHGAC, [Out] CJENCPGHKCL JGGCFNPHPOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x87B5C90", Offset = "0x87B4490", VA = "0x1887B5C90", Slot = "18")]
	public void MNGFBPLEHLD(EIGONBNGIIK OINLJEGCCDI, Guid NDLIOGEDEPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x87B4CB0", Offset = "0x87B34B0", VA = "0x1887B4CB0", Slot = "19")]
	[AsyncStateMachine(typeof(DEFDJIMFLEL))]
	public Task<int> JBEICAMEMIG(EIGONBNGIIK OINLJEGCCDI, Guid NDLIOGEDEPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x87B4540", Offset = "0x87B2D40", VA = "0x1887B4540", Slot = "20")]
	public bool EHJOCINGJHK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x87B5890", Offset = "0x87B4090", VA = "0x1887B5890", Slot = "21")]
	public bool LJIDEMFHMFM(Guid INKJJAKOHOG, [Out] List<string> JEHIOCPHKDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x87B5230", Offset = "0x87B3A30", VA = "0x1887B5230", Slot = "22")]
	[AsyncStateMachine(typeof(CEHNDPJDHOJ))]
	public Task<AOGODOAGAAO<bool, string>> KDBIMFLLLPI(CJENCPGHKCL JGGCFNPHPOE, long DAOMOCCAFDN, int LMIFGKAMFNG, string IPABDMAGDGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x87B39C0", Offset = "0x87B21C0", VA = "0x1887B39C0")]
	[AsyncStateMachine(typeof(LJNGBKGMDNN))]
	private Task<AOGODOAGAAO<bool, string>> CCDHPGBGFON(CJENCPGHKCL JGGCFNPHPOE, long DAOMOCCAFDN, long IMBNJLMAOFD, string IPABDMAGDGB, int LMIFGKAMFNG = 1)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x87B60E0", Offset = "0x87B48E0", VA = "0x1887B60E0")]
	[AsyncStateMachine(typeof(JPIAFILOLLJ))]
	private Task<CGAPFFNHJNI> OOOIAOOHGGK(CJENCPGHKCL JGGCFNPHPOE, int LMIFGKAMFNG, int DAOMOCCAFDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x87B3E60", Offset = "0x87B2660", VA = "0x1887B3E60")]
	private bool DMBJMPLMDPD(IEnumerable<GABLDAGFLGO> NHEEOMKGNCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x87B2FD0", Offset = "0x87B17D0", VA = "0x1887B2FD0")]
	private void AGJNLCBHGBC(CJENCPGHKCL JGGCFNPHPOE, long IMBNJLMAOFD, int LMIFGKAMFNG, string IPABDMAGDGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x87B47B0", Offset = "0x87B2FB0", VA = "0x1887B47B0")]
	private string GMNMHPMMAJA(CJENCPGHKCL JGGCFNPHPOE, int LMIFGKAMFNG, string IPABDMAGDGB, [Optional] OAFHOPCBMLG? KJCFPPKBAOB, [Optional] KBBBLGAOJOB? LADPIHCDMEM, [Optional] string BIMJKFGEANO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x87B4F90", Offset = "0x87B3790", VA = "0x1887B4F90")]
	private OAFHOPCBMLG JKBOKFEABKJ(CJENCPGHKCL LIFCFIEPOLL, int BCDNKJMGOEG, [Out] long IMBNJLMAOFD)
	{
		return default(OAFHOPCBMLG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x87B6240", Offset = "0x87B4A40", VA = "0x1887B6240")]
	[AsyncStateMachine(typeof(KBCGEDKHABJ))]
	private Task PPFKJCEJDIB(long GFHIJAKOMMI, CancellationToken GMEAHOBHMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x87B3410", Offset = "0x87B1C10", VA = "0x1887B3410")]
	private Task AJPIGFMNGJJ(HDBLPJBDELH JALDLFHONHH, CancellationToken GMEAHOBHMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x87B5E70", Offset = "0x87B4670", VA = "0x1887B5E70")]
	[AsyncStateMachine(typeof(CLGCHOPMAJO))]
	private Task NCHMFGAOKIH(HDBLPJBDELH JALDLFHONHH, CancellationToken ONMCJDLNCAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x87B5530", Offset = "0x87B3D30", VA = "0x1887B5530")]
	private static Dictionary<Guid, int> LIPIEKPKNBO(KBEFGPMPCJE<List<HDBLDOMEOMG>> BMLALPACDFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x87B6060", Offset = "0x87B4860", VA = "0x1887B6060")]
	private void NKOCEKKNHDA(CJENCPGHKCL JGGCFNPHPOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x87B6070", Offset = "0x87B4870", VA = "0x1887B6070")]
	private void NNPDFBLIFBH(Guid NDLIOGEDEPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x87B65C0", Offset = "0x87B4DC0", VA = "0x1887B65C0")]
	[KFLNGMOCLGM]
	internal void RpcOfferShowPurchasePrompt(Guid NDLIOGEDEPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x87B3B20", Offset = "0x87B2320", VA = "0x1887B3B20")]
	[AsyncStateMachine(typeof(ECBGAJKAONN))]
	private Task<int> DHBFBGEBDMP(EIGONBNGIIK OINLJEGCCDI, Guid INKJJAKOHOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x87B63D0", Offset = "0x87B4BD0", VA = "0x1887B63D0")]
	[KFLNGMOCLGM]
	internal void RpcGetPlayerRoomOfferPurchaseCount(Guid GKMDGNFGEOO, Guid NDLIOGEDEPM, ACNLMKJJPMB NGABBABGLLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x87B6350", Offset = "0x87B4B50", VA = "0x1887B6350")]
	[KFLNGMOCLGM]
	internal void RpcGetPlayerRoomOfferPurchaseCountResponse(Guid GKMDGNFGEOO, int FMGALNGIOGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x87B2940", Offset = "0x87B1140", VA = "0x1887B2940", Slot = "24")]
	public string AEACBCHAECJ(OAFHOPCBMLG KJCFPPKBAOB, [Optional] KBBBLGAOJOB? LDPMMHJOGGA, [Optional] BalanceResponseDTO PGJNIJMLEPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x87B38D0", Offset = "0x87B20D0", VA = "0x1887B38D0")]
	private static string BPACJPIABFE(KBBBLGAOJOB LDPMMHJOGGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x87B5390", Offset = "0x87B3B90", VA = "0x1887B5390")]
	private CJENCPGHKCL KJPGJJMLNPB(CJENCPGHKCL ANLDCHLHLAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x87B46D0", Offset = "0x87B2ED0", VA = "0x1887B46D0")]
	private void FJPMJKFBDMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x87B2CF0", Offset = "0x87B14F0", VA = "0x1887B2CF0")]
	private void AFFHNMJIDOP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[DefaultMember("Item")]
public class CGAGOPHJDOL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly Dictionary<Guid, CJENCPGHKCL> LPHLJKPCIAD;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private long OKEIHPDKJML
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0xCE5900", Offset = "0xCE4100", VA = "0x180CE5900")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x87B02E0", Offset = "0x87AEAE0", VA = "0x1887B02E0")]
	public void GNOGEFLGECM(long GFHIJAKOMMI, IEnumerable<CJENCPGHKCL> IHOKMPBMFON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x87B0280", Offset = "0x87AEA80", VA = "0x1887B0280")]
	public bool GNGHNJDOIDO(Guid NDLIOGEDEPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x87B0560", Offset = "0x87AED60", VA = "0x1887B0560")]
	public bool HKOLMKDGPPH(Guid NDLIOGEDEPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x87B0690", Offset = "0x87AEE90", VA = "0x1887B0690")]
	public bool OICFAGHDCOF(CJENCPGHKCL APNLCCAGGKH, [Out] CJENCPGHKCL CGLKGMHFBFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x87B05C0", Offset = "0x87AEDC0", VA = "0x1887B05C0")]
	public IEnumerable<CJENCPGHKCL> KGKOKGIDDME()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x87B0210", Offset = "0x87AEA10", VA = "0x1887B0210")]
	public bool BCKEADMGCKD(Guid NDLIOGEDEPM, [Out] CJENCPGHKCL JGGCFNPHPOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x87B0610", Offset = "0x87AEE10", VA = "0x1887B0610")]
	private bool MHHNHPMBFCJ(CJENCPGHKCL AHKAAJJNOPN, CJENCPGHKCL PNCGFMPKAMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x87B07F0", Offset = "0x87AEFF0", VA = "0x1887B07F0")]
	public CGAGOPHJDOL()
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
