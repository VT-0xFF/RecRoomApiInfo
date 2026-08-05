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
		[Cpp2IlInjected.Address(RVA = "0x74C6E60", Offset = "0x74C5860", VA = "0x1874C6E60", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2164780", Offset = "0x2163180", VA = "0x182164780")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface KALNJCBNKEN : PKGKOCCKPPE
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	GGBEDAGLPGM PPJMGDKIBFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface IAILKNPIDLF
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "0")]
	DGLGPMPDNLG CGCMKFHDJHA();
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class EKPMMKLMHEO : IAILKNPIDLF
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x74BE890", Offset = "0x74BD290", VA = "0x1874BE890")]
	[EPFHFFCDLIN.PIOGMKDDBAI.EFFOPIDOPOD]
	internal static void GHMBFHCIJHC(KNPHAFHLPCE DNJEODDCEHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
	[RecRoom.NoEngine.Common.Preserve]
	public EKPMMKLMHEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x74BE7D0", Offset = "0x74BD1D0", VA = "0x1874BE7D0", Slot = "4")]
	public DGLGPMPDNLG CGCMKFHDJHA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AOOPPFIKPBO]
public class GGBEDAGLPGM : LLGLKLDLHDM, IDisposable, PLNLGIDKEKJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct JMBGEMCIBIG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public AsyncTaskMethodBuilder<OKPKCEBGDLD<KFEFKCGCBID, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public GGBEDAGLPGM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public string description;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public string imageName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public int price;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public CBDBLFLCAKJ roomOfferType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public Dictionary<Guid, int> roomInventoryItemMappings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public Guid? priceUnitId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private TaskAwaiter<GOBJOEKKLAP<KFEFKCGCBID>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x74C4C20", Offset = "0x74C3620", VA = "0x1874C4C20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x74C50F0", Offset = "0x74C3AF0", VA = "0x1874C50F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct PKEFIEHLMGA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public AsyncTaskMethodBuilder<OKPKCEBGDLD<KFEFKCGCBID, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public GGBEDAGLPGM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public Guid roomOfferOriginId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public string description;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public string imageName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public int price;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public CBDBLFLCAKJ roomOfferType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public Dictionary<Guid, int> roomInventoryItemMappings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public Guid? priceUnitId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private TaskAwaiter<GOBJOEKKLAP<KFEFKCGCBID>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x74C6470", Offset = "0x74C4E70", VA = "0x1874C6470", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x74C6A10", Offset = "0x74C5410", VA = "0x1874C6A10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct BKNPONIBNGJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public AsyncTaskMethodBuilder<OKPKCEBGDLD<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public GGBEDAGLPGM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public Guid roomOfferId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private KFEFKCGCBID <existingRoomOffer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private TaskAwaiter<GOOALFLCKJC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x74BCFD0", Offset = "0x74BB9D0", VA = "0x1874BCFD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x74BD530", Offset = "0x74BBF30", VA = "0x1874BD530", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct GIBOKEMOOEL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public AsyncTaskMethodBuilder<List<MGLIIBIJFBP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public GGBEDAGLPGM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private TaskAwaiter<GOBJOEKKLAP<List<MGLIIBIJFBP>>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x74C3480", Offset = "0x74C1E80", VA = "0x1874C3480", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x74C3880", Offset = "0x74C2280", VA = "0x1874C3880", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct IIDKMNHGLPD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public GGBEDAGLPGM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public OGOAPNICIIH player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public Guid roomOfferId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private TaskAwaiter<int> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x74C4810", Offset = "0x74C3210", VA = "0x1874C4810", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x74C4BB0", Offset = "0x74C35B0", VA = "0x1874C4BB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct JOKJAOLBGBM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public AsyncTaskMethodBuilder<OKPKCEBGDLD<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public GGBEDAGLPGM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public KFEFKCGCBID roomOffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public int quantity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public string purchaseSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public long requestedPrice;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private TaskAwaiter<OKPKCEBGDLD<bool, string>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x74C5160", Offset = "0x74C3B60", VA = "0x1874C5160", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x74C56B0", Offset = "0x74C40B0", VA = "0x1874C56B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct DILFDONFANB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public AsyncTaskMethodBuilder<OKPKCEBGDLD<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public int quantity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public GGBEDAGLPGM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public KFEFKCGCBID roomOffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public string purchaseSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public long requestedPrice;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public long initialBalance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private IAAHLMDMAIE <operationResult>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private int <attemptNumber>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private FNAIAEENFJB <response>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private TaskAwaiter<FNAIAEENFJB> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x74BDC20", Offset = "0x74BC620", VA = "0x1874BDC20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x74BE550", Offset = "0x74BCF50", VA = "0x1874BE550", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class DLLPGKPMPFG
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		private struct <<SendRecNetRoomOfferPurchaseRequest>g__FlushPendingInventoryItemUpdatesIfNeeded|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public DLLPGKPMPFG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public Guid itemId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x74C6A80", Offset = "0x74C5480", VA = "0x1874C6A80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x74C6E00", Offset = "0x74C5800", VA = "0x1874C6E00", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public GGBEDAGLPGM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public int expectedTotalPrice;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public DLLPGKPMPFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x74BE6E0", Offset = "0x74BD0E0", VA = "0x1874BE6E0")]
		[AsyncStateMachine(typeof(<<SendRecNetRoomOfferPurchaseRequest>g__FlushPendingInventoryItemUpdatesIfNeeded|0>d))]
		internal Task HHALKMCCCAB(Guid itemId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x74BE5C0", Offset = "0x74BCFC0", VA = "0x1874BE5C0")]
		internal Guid? HDKBAJODELI(Guid itemId)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct KAEIMPAOCHG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public AsyncTaskMethodBuilder<FNAIAEENFJB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public GGBEDAGLPGM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public int requestedPrice;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public int quantity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public KFEFKCGCBID roomOffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private DLLPGKPMPFG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private Dictionary<Guid, Guid?> <concurrencyCodeByItemIdMap>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private Guid <itemId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private TaskAwaiter<FNAIAEENFJB> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x74C5720", Offset = "0x74C4120", VA = "0x1874C5720", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x74C6400", Offset = "0x74C4E00", VA = "0x1874C6400", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct HDAIOCMJHLN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public GGBEDAGLPGM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private Task<GOBJOEKKLAP<List<BLPLJCNHDMG>>> <purchaseCountsTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private TaskAwaiter<List<KFEFKCGCBID>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private TaskAwaiter<GOBJOEKKLAP<List<BLPLJCNHDMG>>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x74C3FC0", Offset = "0x74C29C0", VA = "0x1874C3FC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x74C47B0", Offset = "0x74C31B0", VA = "0x1874C47B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct GPKECDMEOGC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public GGBEDAGLPGM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private TaskAwaiter<Task> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x74C38F0", Offset = "0x74C22F0", VA = "0x1874C38F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x74C3F60", Offset = "0x74C2960", VA = "0x1874C3F60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct GECACCFKKIA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public GGBEDAGLPGM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public OGOAPNICIIH player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private TaskAwaiter<int> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x74BE900", Offset = "0x74BD300", VA = "0x1874BE900", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x74BEE80", Offset = "0x74BD880", VA = "0x1874BEE80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly TimeSpan HCLMCNCPBLJ;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public const string KAJEIELBJOC = "econ_room_offer_gate";

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private const string MIJHFOIEKDO = "Unknown error occured. If this persists, please contact us at recroom.zendesk.com";

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private const string MJIFHEKCKMA = "CV2_Purchase_Prompt_Chip";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly IMNPLDOMOKL IEJFJDGBJPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly OALDAIIAOFB CGMKLAALGJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly CJCAEHNADAH JIPHNMKEKCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly NBJKPJCPFJP HLMIPNCJNLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly GDJPPADHBHH JLBNNDOMHHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly KALNJCBNKEN PHMDGDCONHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly CBHIPKFFGCD LPMHKEAJABJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly MHJCOHCOMMG ICONFAKONIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly OCFLCBNDEHD AMLHAEKDDJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly PKCJNCMMMAN ANHDMKEMIFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly DGLGPMPDNLG BLFPFKAILED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private Dictionary<Guid, int> CGABHFJEFKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly IDisposable EJNPJLEIAIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private Task NDKNLIKEPKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private CancellationTokenSource CIIDBOIJBFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private long DEFGPHJJPJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool MOGBFDJDEOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly OGJEMNBOAMG PCGALBKIAOP;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private IAOBALHKALH POBIKCLKGEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x74C12E0", Offset = "0x74BFCE0", VA = "0x1874C12E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public APNHDGDPKOI PIAIMOFIPOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9FF200", Offset = "0x9FDC00", VA = "0x1809FF200", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9FF250", Offset = "0x9FDC50", VA = "0x1809FF250", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public ABIBNEMCANM<KFEFKCGCBID> GBBIKGFCBCC
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8B69A0", Offset = "0x8B53A0", VA = "0x1808B69A0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8B6910", Offset = "0x8B5310", VA = "0x1808B6910", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ABIBNEMCANM<Guid> CJMODBDEIKC
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x9824B0", Offset = "0x980EB0", VA = "0x1809824B0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA0F4D0", Offset = "0xA0DED0", VA = "0x180A0F4D0", Slot = "9")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x74C0530", Offset = "0x74BEF30", VA = "0x1874C0530")]
	[EPFHFFCDLIN.PIOGMKDDBAI.EFFOPIDOPOD]
	internal static void GHMBFHCIJHC(KNPHAFHLPCE DNJEODDCEHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x74C2D60", Offset = "0x74C1760", VA = "0x1874C2D60")]
	[RecRoom.NoEngine.Common.Preserve]
	public GGBEDAGLPGM([CCLEDEMDDDH(null)] IMNPLDOMOKL IEJFJDGBJPP, [CCLEDEMDDDH(null)] OALDAIIAOFB CGMKLAALGJK, [CCLEDEMDDDH(null)] OIJGODLJCJF GFHJCFNDBGP, [CCLEDEMDDDH(null)] CJCAEHNADAH JIPHNMKEKCK, [CCLEDEMDDDH(null)] IAILKNPIDLF ACHHGDHFFOH, [CCLEDEMDDDH(null)] NBJKPJCPFJP HLMIPNCJNLM, [CCLEDEMDDDH("ShowPurchasePromptRateLimiter")] GDJPPADHBHH JLBNNDOMHHH, [CCLEDEMDDDH(null)] KALNJCBNKEN PHMDGDCONHJ, [CCLEDEMDDDH(null)] ECEEBMJJPLJ KLKJIFAHCIE, [CCLEDEMDDDH(null)] CBHIPKFFGCD LPMHKEAJABJ, [CCLEDEMDDDH(null)] MHJCOHCOMMG ICONFAKONIF, [CCLEDEMDDDH(null)] OCFLCBNDEHD AMLHAEKDDJB, [CCLEDEMDDDH(null)] PKCJNCMMMAN ANHDMKEMIFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x74BFFD0", Offset = "0x74BE9D0", VA = "0x1874BFFD0", Slot = "23")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x74BFD30", Offset = "0x74BE730", VA = "0x1874BFD30", Slot = "10")]
	[AsyncStateMachine(typeof(JMBGEMCIBIG))]
	public Task<OKPKCEBGDLD<KFEFKCGCBID, string>> CJCBDIBBGKC(long NPGHGEFGHLA, string JHJFHDOAMLG, string IGIOLLIFOOJ, string FHFCJEAFMJC, int NOMOMKEEIKH, CBDBLFLCAKJ LGNONGANKDO, [Optional] Dictionary<Guid, int> LBJLKLBNGJO, [Optional] Guid? FFOKKCGOKGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x74C0230", Offset = "0x74BEC30", VA = "0x1874C0230", Slot = "11")]
	[AsyncStateMachine(typeof(PKEFIEHLMGA))]
	public Task<OKPKCEBGDLD<KFEFKCGCBID, string>> ELKPKMGAEAF(Guid CNNDEEBINDC, long NPGHGEFGHLA, string JHJFHDOAMLG, string IGIOLLIFOOJ, string FHFCJEAFMJC, int NOMOMKEEIKH, CBDBLFLCAKJ LGNONGANKDO, [Optional] Dictionary<Guid, int> LBJLKLBNGJO, [Optional] Guid? FFOKKCGOKGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x74C11C0", Offset = "0x74BFBC0", VA = "0x1874C11C0", Slot = "12")]
	[AsyncStateMachine(typeof(BKNPONIBNGJ))]
	public Task<OKPKCEBGDLD<bool, string>> JHOCAAMENFG(Guid KLGKNBMEEHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x74C1A70", Offset = "0x74C0470", VA = "0x1874C1A70", Slot = "13")]
	public IEnumerable<KFEFKCGCBID> LIADBKCKFNO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x74C2750", Offset = "0x74C1150", VA = "0x1874C2750", Slot = "14")]
	[AsyncStateMachine(typeof(GIBOKEMOOEL))]
	public Task<List<MGLIIBIJFBP>> PMHNOPMFPGG(long NPGHGEFGHLA, [Optional] CancellationToken PPLDCJFFMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x74BEEF0", Offset = "0x74BD8F0", VA = "0x1874BEEF0", Slot = "17")]
	public bool ABDHGMMLFKD(Guid KLGKNBMEEHF, int CLDENMKBOGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x74C0CB0", Offset = "0x74BF6B0", VA = "0x1874C0CB0", Slot = "15")]
	public bool HPACNKICJDE(Guid KLGKNBMEEHF, [Out] KFEFKCGCBID CBNBKKAHFGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x74C24F0", Offset = "0x74C0EF0", VA = "0x1874C24F0", Slot = "16")]
	public bool PABGNPGAOLM(string JHJFHDOAMLG, [Out] KFEFKCGCBID CBNBKKAHFGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x74BF290", Offset = "0x74BDC90", VA = "0x1874BF290", Slot = "18")]
	public void BGECIDOPLKC(OGOAPNICIIH JOCAMECBDHO, Guid KLGKNBMEEHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x74C1930", Offset = "0x74C0330", VA = "0x1874C1930", Slot = "19")]
	[AsyncStateMachine(typeof(IIDKMNHGLPD))]
	public Task<int> LHKEECANANN(OGOAPNICIIH JOCAMECBDHO, Guid KLGKNBMEEHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x74C0980", Offset = "0x74BF380", VA = "0x1874C0980", Slot = "20")]
	public bool HHAPIEAPHGE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x74BF840", Offset = "0x74BE240", VA = "0x1874BF840", Slot = "21")]
	public bool CDAPMFAHKDK(Guid PMAKHKBNMPF, [Out] List<string> HMKMALFKOJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x74C1FC0", Offset = "0x74C09C0", VA = "0x1874C1FC0", Slot = "22")]
	[AsyncStateMachine(typeof(JOKJAOLBGBM))]
	public Task<OKPKCEBGDLD<bool, string>> OEHOGHCOENP(KFEFKCGCBID CBNBKKAHFGO, long GOMPJMKMNGF, int DIKJGKCBPOL, string KELKGGAOEHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x74C03D0", Offset = "0x74BEDD0", VA = "0x1874C03D0")]
	[AsyncStateMachine(typeof(DILFDONFANB))]
	private Task<OKPKCEBGDLD<bool, string>> GFKBAPMBOHB(KFEFKCGCBID CBNBKKAHFGO, long GOMPJMKMNGF, long BJFFNHCDIIA, string KELKGGAOEHK, int DIKJGKCBPOL = 1)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x74BF540", Offset = "0x74BDF40", VA = "0x1874BF540")]
	[AsyncStateMachine(typeof(KAEIMPAOCHG))]
	private Task<FNAIAEENFJB> BKHMDMKJPLA(KFEFKCGCBID CBNBKKAHFGO, int DIKJGKCBPOL, int GOMPJMKMNGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x74C1330", Offset = "0x74BFD30", VA = "0x1874C1330")]
	private bool JPBCBIDKPFJ(IEnumerable<MDDBCCHCHHA> GNHGMGFHAIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x74C2120", Offset = "0x74C0B20", VA = "0x1874C2120")]
	private void ONMENNMOOPG(KFEFKCGCBID CBNBKKAHFGO, long BJFFNHCDIIA, int DIKJGKCBPOL, string KELKGGAOEHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x74C0A60", Offset = "0x74BF460", VA = "0x1874C0A60")]
	private string HKFGAEBMLFO(KFEFKCGCBID CBNBKKAHFGO, int DIKJGKCBPOL, string KELKGGAOEHK, [Optional] IAAHLMDMAIE? KIBAOEBFCJF, [Optional] HBOIANIJLGA? MDKHIGLMAFB, [Optional] string GCLPKBPMILI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x74C1690", Offset = "0x74C0090", VA = "0x1874C1690")]
	private IAAHLMDMAIE LGNDIOAOKLC(KFEFKCGCBID CHOIAKDJMHB, int KBGPKILEBJM, [Out] long BJFFNHCDIIA)
	{
		return default(IAAHLMDMAIE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x74BFEC0", Offset = "0x74BE8C0", VA = "0x1874BFEC0")]
	[AsyncStateMachine(typeof(HDAIOCMJHLN))]
	private Task DKNBHBEJBCP(long NPGHGEFGHLA, CancellationToken PPLDCJFFMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x74C05A0", Offset = "0x74BEFA0", VA = "0x1874C05A0")]
	private Task GLIACGDBDNM(LKMBJDMKDPJ LPLPEHNKFMM, CancellationToken PPLDCJFFMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x74BF470", Offset = "0x74BDE70", VA = "0x1874BF470")]
	[AsyncStateMachine(typeof(GPKECDMEOGC))]
	private Task BJJNOKILBND(LKMBJDMKDPJ LPLPEHNKFMM, CancellationToken MDAHKKOMGCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x74C1B20", Offset = "0x74C0520", VA = "0x1874C1B20")]
	private static Dictionary<Guid, int> LNMPHADCNLJ(GOBJOEKKLAP<List<BLPLJCNHDMG>> PDGPBCFJIEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x74C0E00", Offset = "0x74BF800", VA = "0x1874C0E00")]
	private void IOBNNDLFJID(KFEFKCGCBID CBNBKKAHFGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x74BF6A0", Offset = "0x74BE0A0", VA = "0x1874BF6A0")]
	private void BNBPEOKAFFF(Guid KLGKNBMEEHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x74C2AF0", Offset = "0x74C14F0", VA = "0x1874C2AF0")]
	[KJDFAECKLJG]
	internal void RpcOfferShowPurchasePrompt(Guid KLGKNBMEEHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x74C1E80", Offset = "0x74C0880", VA = "0x1874C1E80")]
	[AsyncStateMachine(typeof(GECACCFKKIA))]
	private Task<int> MPPFPFJKFIH(OGOAPNICIIH JOCAMECBDHO, Guid PMAKHKBNMPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x74C2900", Offset = "0x74C1300", VA = "0x1874C2900")]
	[KJDFAECKLJG]
	internal void RpcGetPlayerRoomOfferPurchaseCount(Guid GGNKLHDGNDO, Guid KLGKNBMEEHF, EPBMCJPHALC NMAECNIBAJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x74C2880", Offset = "0x74C1280", VA = "0x1874C2880")]
	[KJDFAECKLJG]
	internal void RpcGetPlayerRoomOfferPurchaseCountResponse(Guid GGNKLHDGNDO, int FPDJICFHLGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x74C0E10", Offset = "0x74BF810", VA = "0x1874C0E10", Slot = "24")]
	public string JBKKIKMHHPF(IAAHLMDMAIE KIBAOEBFCJF, [Optional] HBOIANIJLGA? BMDHDEOGCNM, [Optional] BalanceResponseDTO ANMGNKEMCBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x74BFC40", Offset = "0x74BE640", VA = "0x1874BFC40")]
	private static string CGFBJFLOJKC(HBOIANIJLGA BMDHDEOGCNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x74BF0F0", Offset = "0x74BDAF0", VA = "0x1874BF0F0")]
	private KFEFKCGCBID ACKJBOEPOPE(KFEFKCGCBID DPEJPGLPAEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x74C0D90", Offset = "0x74BF790", VA = "0x1874C0D90")]
	private void ICIFGFICEGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x74BF710", Offset = "0x74BE110", VA = "0x1874BF710")]
	private void BOMDCDBPKEC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[DefaultMember("Item")]
public class DGLGPMPDNLG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private readonly Dictionary<Guid, KFEFKCGCBID> CAMFPBAFKPB;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private long FFMKJNBFCOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x13920B0", Offset = "0x1390AB0", VA = "0x1813920B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x74BD700", Offset = "0x74BC100", VA = "0x1874BD700")]
	public void BMGKNHOJOBG(long NPGHGEFGHLA, IEnumerable<KFEFKCGCBID> NNDOIJCKABH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x74BDA60", Offset = "0x74BC460", VA = "0x1874BDA60")]
	public bool HMOHHFFOLHP(Guid KLGKNBMEEHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x74BDB30", Offset = "0x74BC530", VA = "0x1874BDB30")]
	public bool PJOABDGMIKH(Guid KLGKNBMEEHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x74BD5A0", Offset = "0x74BBFA0", VA = "0x1874BD5A0")]
	public bool BCMKDCGBLLD(KFEFKCGCBID JEOLGOBHJCB, [Out] KFEFKCGCBID FOPGMKKMLJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x74BD990", Offset = "0x74BC390", VA = "0x1874BD990")]
	public IEnumerable<KFEFKCGCBID> BOMPEHKELGJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x74BDAC0", Offset = "0x74BC4C0", VA = "0x1874BDAC0")]
	public bool HPACNKICJDE(Guid KLGKNBMEEHF, [Out] KFEFKCGCBID CBNBKKAHFGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x74BD9E0", Offset = "0x74BC3E0", VA = "0x1874BD9E0")]
	private bool HMFMPNBHHJK(KFEFKCGCBID IBFLAGMGMLI, KFEFKCGCBID ADDBJKLLJPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x74BDB90", Offset = "0x74BC590", VA = "0x1874BDB90")]
	public DGLGPMPDNLG()
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
