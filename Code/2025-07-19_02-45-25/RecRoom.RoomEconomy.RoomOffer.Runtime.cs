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
		[Cpp2IlInjected.Address(RVA = "0x89D9170", Offset = "0x89D8170", VA = "0x1889D9170", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x28D9760", Offset = "0x28D8760", VA = "0x1828D9760")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface BLGFGFGNMBJ : OODGCKEAHFM
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	KIKDKFJDLEH PFAPMMNGKGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface HANIEAIPLIC
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ILEJKPCMKFI ILGNAFOFFLA();
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class FAEFPEAFFON : HANIEAIPLIC
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x89D1E70", Offset = "0x89D0E70", VA = "0x1889D1E70")]
	[GOMLKAICHII.JENKOCGKLOO.LCLJJMFJJCN]
	internal static void EKOODCFGNGC(CBHAAKGBAOP PFJIPDCNGCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	[RecRoom.NoEngine.Common.Preserve]
	public FAEFPEAFFON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x89D1EE0", Offset = "0x89D0EE0", VA = "0x1889D1EE0", Slot = "4")]
	public ILEJKPCMKFI ILGNAFOFFLA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[NMAHPGPJLGN]
public class KIKDKFJDLEH : PLAPMNHDKCA, IDisposable, HOCNAJGAJIL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct DFIOBAPFJDF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public AsyncTaskMethodBuilder<DAFIFKKNPFP<ICAHHIJFAHD, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public KIKDKFJDLEH <>4__this;

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
		public ONKHINELMKK roomOfferType;

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
		private TaskAwaiter<FFOENOGPGNH<ICAHHIJFAHD>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x89D1460", Offset = "0x89D0460", VA = "0x1889D1460", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x89D1990", Offset = "0x89D0990", VA = "0x1889D1990", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct AIPPOHLIPCC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public AsyncTaskMethodBuilder<DAFIFKKNPFP<ICAHHIJFAHD, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public KIKDKFJDLEH <>4__this;

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
		public ONKHINELMKK roomOfferType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public Dictionary<Guid, int> roomInventoryItemMappings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public Guid? priceUnitId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private TaskAwaiter<FFOENOGPGNH<ICAHHIJFAHD>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x89CFFA0", Offset = "0x89CEFA0", VA = "0x1889CFFA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x89D0540", Offset = "0x89CF540", VA = "0x1889D0540", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct HKFLBEMCBEH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public AsyncTaskMethodBuilder<DAFIFKKNPFP<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public KIKDKFJDLEH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public Guid roomOfferId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private ICAHHIJFAHD <existingRoomOffer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private TaskAwaiter<JFNAKFCGDAO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x89D1FA0", Offset = "0x89D0FA0", VA = "0x1889D1FA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x89D2500", Offset = "0x89D1500", VA = "0x1889D2500", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct EHCPHKJOKOB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public AsyncTaskMethodBuilder<List<OLMCOEMFCBJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public KIKDKFJDLEH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TaskAwaiter<FFOENOGPGNH<List<OLMCOEMFCBJ>>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x89D1A00", Offset = "0x89D0A00", VA = "0x1889D1A00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x89D1E00", Offset = "0x89D0E00", VA = "0x1889D1E00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct NNDOABJHCID : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public KIKDKFJDLEH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public IALDHONKEJC player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public Guid roomOfferId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private TaskAwaiter<int> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x89D7B70", Offset = "0x89D6B70", VA = "0x1889D7B70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x89D7F10", Offset = "0x89D6F10", VA = "0x1889D7F10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct CDPLNHFBONJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public AsyncTaskMethodBuilder<DAFIFKKNPFP<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public KIKDKFJDLEH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public ICAHHIJFAHD roomOffer;

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
		private TaskAwaiter<DAFIFKKNPFP<bool, string>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x89D07C0", Offset = "0x89CF7C0", VA = "0x1889D07C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x89D0D10", Offset = "0x89CFD10", VA = "0x1889D0D10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct MGJKMIOKMOH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public AsyncTaskMethodBuilder<DAFIFKKNPFP<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int quantity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public KIKDKFJDLEH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public ICAHHIJFAHD roomOffer;

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
		private LBBAIFDHLDD <operationResult>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private int <attemptNumber>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private APJINCEIKDL <response>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private TaskAwaiter<APJINCEIKDL> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x89D71D0", Offset = "0x89D61D0", VA = "0x1889D71D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x89D7B00", Offset = "0x89D6B00", VA = "0x1889D7B00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class ANOLEFAGLEM
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
			public ANOLEFAGLEM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public Guid itemId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x89D8DA0", Offset = "0x89D7DA0", VA = "0x1889D8DA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x89D9110", Offset = "0x89D8110", VA = "0x1889D9110", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public KIKDKFJDLEH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public int expectedTotalPrice;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public ANOLEFAGLEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x89D06D0", Offset = "0x89CF6D0", VA = "0x1889D06D0")]
		[AsyncStateMachine(typeof(<<SendRecNetRoomOfferPurchaseRequest>g__FlushPendingInventoryItemUpdatesIfNeeded|0>d))]
		internal Task APJCLPEJJNB(Guid itemId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x89D05B0", Offset = "0x89CF5B0", VA = "0x1889D05B0")]
		internal Guid? ALAJCFIIALD(Guid itemId)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct AEMKCCCDPPK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public AsyncTaskMethodBuilder<APJINCEIKDL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public KIKDKFJDLEH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public int requestedPrice;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public int quantity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public ICAHHIJFAHD roomOffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private ANOLEFAGLEM <>8__1;

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
		private TaskAwaiter<APJINCEIKDL> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x89CF270", Offset = "0x89CE270", VA = "0x1889CF270", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x89CFF30", Offset = "0x89CEF30", VA = "0x1889CFF30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct PNJELFPLFAI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public KIKDKFJDLEH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private Task<FFOENOGPGNH<List<OOKDOMPGLJO>>> <purchaseCountsTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private TaskAwaiter<List<ICAHHIJFAHD>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private TaskAwaiter<FFOENOGPGNH<List<OOKDOMPGLJO>>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x89D8550", Offset = "0x89D7550", VA = "0x1889D8550", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x89D8D40", Offset = "0x89D7D40", VA = "0x1889D8D40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct CFMAOFNNBOH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public KIKDKFJDLEH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private TaskAwaiter<Task> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x89D0D80", Offset = "0x89CFD80", VA = "0x1889D0D80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x89D1400", Offset = "0x89D0400", VA = "0x1889D1400", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct OBGGDIAALEJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public KIKDKFJDLEH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public IALDHONKEJC player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private TaskAwaiter<int> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x89D7F80", Offset = "0x89D6F80", VA = "0x1889D7F80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x89D84E0", Offset = "0x89D74E0", VA = "0x1889D84E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly TimeSpan ACHJHEAPGML;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public const string IBPDLAABDEA = "econ_room_offer_gate";

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private const string BPHAEHLMAFK = "Unknown error occured. If this persists, please contact us at recroom.zendesk.com";

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private const string MDGIFPEHNFM = "CV2_Purchase_Prompt_Chip";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly NHJEKIDELDP GKHDOCGOOBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly KPPGAAACGAM JCOAFMOPGKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly JGOBEBEEPIE KOHFHJFDJAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly MCIAFEMJFEE FEOBKHBKLPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly CKDPPAOFMKH HMNHONMLLGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly BLGFGFGNMBJ KAJGGMOPNJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly CJFABEEGFPK JMDACFLNFAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly LEKELPMOABO ELOHLFLHKDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly LOPPHNNDFGE CNPGJHPOPEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly DDLFFNNGKJA LHIDBCNIHLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly ILEJKPCMKFI JBNBJAHJLPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private Dictionary<Guid, int> OLNPEHPDDPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly IDisposable IGIDAJLHJAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private Task HPDDOKKIMEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private CancellationTokenSource PHDIADAIOKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private long ENKGOADNBIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool MCHGOAKENIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly CGHAKILDGOB JHKEEFLLCII;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private PIFHPGJAAJP CONGFNFMFDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x89D4ED0", Offset = "0x89D3ED0", VA = "0x1889D4ED0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public LELKCPPPMEI CNEKGKDADEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xAC9300", Offset = "0xAC8300", VA = "0x180AC9300", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xB11FD0", Offset = "0xB10FD0", VA = "0x180B11FD0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public FHLIAIDPCMK<ICAHHIJFAHD> PJEAMHPOAHE
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xA62800", Offset = "0xA61800", VA = "0x180A62800", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xA628C0", Offset = "0xA618C0", VA = "0x180A628C0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public FHLIAIDPCMK<Guid> CEBNFCABBKI
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xB12000", Offset = "0xB11000", VA = "0x180B12000", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xB12440", Offset = "0xB11440", VA = "0x180B12440", Slot = "9")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x89D3700", Offset = "0x89D2700", VA = "0x1889D3700")]
	[GOMLKAICHII.JENKOCGKLOO.LCLJJMFJJCN]
	internal static void EKOODCFGNGC(CBHAAKGBAOP PFJIPDCNGCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x89D6AA0", Offset = "0x89D5AA0", VA = "0x1889D6AA0")]
	[RecRoom.NoEngine.Common.Preserve]
	public KIKDKFJDLEH([KELEGLJPNHI(null)] NHJEKIDELDP GKHDOCGOOBA, [KELEGLJPNHI(null)] KPPGAAACGAM JCOAFMOPGKM, [KELEGLJPNHI(null)] DDAPLCBMGDI JCLJEPFEBAL, [KELEGLJPNHI(null)] JGOBEBEEPIE KOHFHJFDJAE, [KELEGLJPNHI(null)] HANIEAIPLIC KJFLMKGPLCF, [KELEGLJPNHI(null)] MCIAFEMJFEE FEOBKHBKLPO, [KELEGLJPNHI("ShowPurchasePromptRateLimiter")] CKDPPAOFMKH HMNHONMLLGL, [KELEGLJPNHI(null)] BLGFGFGNMBJ KAJGGMOPNJP, [KELEGLJPNHI(null)] CKLJENKILGE BCMABIEFDCA, [KELEGLJPNHI(null)] CJFABEEGFPK JMDACFLNFAD, [KELEGLJPNHI(null)] LEKELPMOABO ELOHLFLHKDA, [KELEGLJPNHI(null)] LOPPHNNDFGE CNPGJHPOPEB, [KELEGLJPNHI(null)] DDLFFNNGKJA LHIDBCNIHLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x89D3480", Offset = "0x89D2480", VA = "0x1889D3480", Slot = "23")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x89D3FB0", Offset = "0x89D2FB0", VA = "0x1889D3FB0", Slot = "10")]
	[AsyncStateMachine(typeof(DFIOBAPFJDF))]
	public Task<DAFIFKKNPFP<ICAHHIJFAHD, string>> HFMADBBBABG(Guid? FFGLKCFBAJA, long DJJNJEHBMJK, string HJLBILHBIIC, string GAPCMICLLJD, string IMHEEBEEIJH, int FJMCJCMNJIL, ONKHINELMKK HMAKFCNDHON, [Optional] Dictionary<Guid, int> MBBOGCJLBEA, [Optional] Guid? BLCOBKGOHGH, bool BNOMIEFKLPG = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x89D5280", Offset = "0x89D4280", VA = "0x1889D5280", Slot = "11")]
	[AsyncStateMachine(typeof(AIPPOHLIPCC))]
	public Task<DAFIFKKNPFP<ICAHHIJFAHD, string>> KOFCOKONICG(Guid DFPKNAPNGHC, long DJJNJEHBMJK, string HJLBILHBIIC, string GAPCMICLLJD, string IMHEEBEEIJH, int FJMCJCMNJIL, ONKHINELMKK HMAKFCNDHON, [Optional] Dictionary<Guid, int> MBBOGCJLBEA, [Optional] Guid? BLCOBKGOHGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x89D5DB0", Offset = "0x89D4DB0", VA = "0x1889D5DB0", Slot = "12")]
	[AsyncStateMachine(typeof(HKFLBEMCBEH))]
	public Task<DAFIFKKNPFP<bool, string>> MCJHIDIGMOG(Guid MGNBKMGEAEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x89D60E0", Offset = "0x89D50E0", VA = "0x1889D60E0", Slot = "13")]
	public IEnumerable<ICAHHIJFAHD> NMBPGLOFPDE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x89D2E20", Offset = "0x89D1E20", VA = "0x1889D2E20", Slot = "14")]
	[AsyncStateMachine(typeof(EHCPHKJOKOB))]
	public Task<List<OLMCOEMFCBJ>> DCIMDAFAJJO(long DJJNJEHBMJK, [Optional] CancellationToken KGALDHLEDNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x89D5EE0", Offset = "0x89D4EE0", VA = "0x1889D5EE0", Slot = "17")]
	public bool NACLBMAFHPD(Guid MGNBKMGEAEF, int MDJLFOANLMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x89D3770", Offset = "0x89D2770", VA = "0x1889D3770", Slot = "15")]
	public bool FINLKNOPDDI(Guid MGNBKMGEAEF, [Out] ICAHHIJFAHD AELMLOGGPLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x89D5810", Offset = "0x89D4810", VA = "0x1889D5810", Slot = "16")]
	public bool LFEJNIEKPEN(string HJLBILHBIIC, [Out] ICAHHIJFAHD AELMLOGGPLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x89D2F50", Offset = "0x89D1F50", VA = "0x1889D2F50", Slot = "18")]
	public void DPIOJKMLAEF(IALDHONKEJC MFOAOKBDIIM, Guid MGNBKMGEAEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x89D3850", Offset = "0x89D2850", VA = "0x1889D3850", Slot = "19")]
	[AsyncStateMachine(typeof(NNDOABJHCID))]
	public Task<int> FNPFECEFDAE(IALDHONKEJC MFOAOKBDIIM, Guid MGNBKMGEAEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x89D5A70", Offset = "0x89D4A70", VA = "0x1889D5A70", Slot = "20")]
	public bool LGMGKPNGCCG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x89D47C0", Offset = "0x89D37C0", VA = "0x1889D47C0", Slot = "21")]
	public bool JBMNMIENLJH(Guid PMKCJLJOEAA, [Out] List<string> IAEHAGMAOFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x89D42C0", Offset = "0x89D32C0", VA = "0x1889D42C0", Slot = "22")]
	[AsyncStateMachine(typeof(CDPLNHFBONJ))]
	public Task<DAFIFKKNPFP<bool, string>> ICIJHIAJDOB(ICAHHIJFAHD AELMLOGGPLB, long NFLPOBMAEIC, int KGCCFJCBKGO, string FDCDDOHBNHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x89D4160", Offset = "0x89D3160", VA = "0x1889D4160")]
	[AsyncStateMachine(typeof(MGJKMIOKMOH))]
	private Task<DAFIFKKNPFP<bool, string>> HLFOHEADPFF(ICAHHIJFAHD AELMLOGGPLB, long NFLPOBMAEIC, long JJGHHHPJDKP, string FDCDDOHBNHN, int KGCCFJCBKGO = 1)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x89D4420", Offset = "0x89D3420", VA = "0x1889D4420")]
	[AsyncStateMachine(typeof(AEMKCCCDPPK))]
	private Task<APJINCEIKDL> IHALPGIOJOP(ICAHHIJFAHD AELMLOGGPLB, int KGCCFJCBKGO, int NFLPOBMAEIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x89D3130", Offset = "0x89D2130", VA = "0x1889D3130")]
	private bool DPPHAADPJMJ(IEnumerable<OCOMMAHLAAD> JGMGEFBIENL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x89D6190", Offset = "0x89D5190", VA = "0x1889D6190")]
	private void NPAAFDHEOBG(ICAHHIJFAHD AELMLOGGPLB, long JJGHHHPJDKP, int KGCCFJCBKGO, string FDCDDOHBNHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x89D5B50", Offset = "0x89D4B50", VA = "0x1889D5B50")]
	private string LLIPPCBNCMG(ICAHHIJFAHD AELMLOGGPLB, int KGCCFJCBKGO, string FDCDDOHBNHN, [Optional] LBBAIFDHLDD? BGOCMPMGKKI, [Optional] IIFPJCBKPKN? BPPJLAPPBAG, [Optional] string IAGEDNEDFLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x89D4C30", Offset = "0x89D3C30", VA = "0x1889D4C30")]
	private LBBAIFDHLDD JIGLPPJKBHI(ICAHHIJFAHD CPGOBAEGHLM, int JICLIBEGPOF, [Out] long JJGHHHPJDKP)
	{
		return default(LBBAIFDHLDD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x89D46B0", Offset = "0x89D36B0", VA = "0x1889D46B0")]
	[AsyncStateMachine(typeof(PNJELFPLFAI))]
	private Task JACFJMHCLGM(long DJJNJEHBMJK, CancellationToken KGALDHLEDNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x89D5420", Offset = "0x89D4420", VA = "0x1889D5420")]
	private Task KOGJJCFJMIL(OCFEIKJADOO DELLHDJPKBE, CancellationToken KGALDHLEDNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x89D3EE0", Offset = "0x89D2EE0", VA = "0x1889D3EE0")]
	[AsyncStateMachine(typeof(CFMAOFNNBOH))]
	private Task GIJLPOCPOBE(OCFEIKJADOO DELLHDJPKBE, CancellationToken CIMHKOOFHCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x89D4F20", Offset = "0x89D3F20", VA = "0x1889D4F20")]
	private static Dictionary<Guid, int> JNGAMJPAJBA(FFOENOGPGNH<List<OOKDOMPGLJO>> IFPJNLKHMGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x89D5ED0", Offset = "0x89D4ED0", VA = "0x1889D5ED0")]
	private void MGHHIDIJFCB(ICAHHIJFAHD AELMLOGGPLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x89D4BC0", Offset = "0x89D3BC0", VA = "0x1889D4BC0")]
	private void JFOLAIPHCMD(Guid MGNBKMGEAEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x89D6840", Offset = "0x89D5840", VA = "0x1889D6840")]
	[DMLIGKAMJGD]
	internal void RpcOfferShowPurchasePrompt(Guid MGNBKMGEAEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x89D2CE0", Offset = "0x89D1CE0", VA = "0x1889D2CE0")]
	[AsyncStateMachine(typeof(OBGGDIAALEJ))]
	private Task<int> DBPCNGCOAHO(IALDHONKEJC MFOAOKBDIIM, Guid PMKCJLJOEAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x89D6650", Offset = "0x89D5650", VA = "0x1889D6650")]
	[DMLIGKAMJGD]
	internal void RpcGetPlayerRoomOfferPurchaseCount(Guid NGMLHKBJDHL, Guid MGNBKMGEAEF, CFLNMMPBLFL OGECODCBMEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x89D65D0", Offset = "0x89D55D0", VA = "0x1889D65D0")]
	[DMLIGKAMJGD]
	internal void RpcGetPlayerRoomOfferPurchaseCountResponse(Guid NGMLHKBJDHL, int MFFPIAPMHCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x89D3990", Offset = "0x89D2990", VA = "0x1889D3990", Slot = "24")]
	public string GGFGIAKFGOC(LBBAIFDHLDD BGOCMPMGKKI, [Optional] IIFPJCBKPKN? CPPABFECGGL, [Optional] BalanceResponseDTO HFHIIJAGCFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x89D2BF0", Offset = "0x89D1BF0", VA = "0x1889D2BF0")]
	private static string BDFONCFOHFM(IIFPJCBKPKN CPPABFECGGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x89D3D40", Offset = "0x89D2D40", VA = "0x1889D3D40")]
	private ICAHHIJFAHD GHGAIDIFLNB(ICAHHIJFAHD OFNBMHFAAGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x89D6560", Offset = "0x89D5560", VA = "0x1889D6560")]
	private void PFFLGCJCEAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x89D4580", Offset = "0x89D3580", VA = "0x1889D4580")]
	private void IINIJMEOJHN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[DefaultMember("Item")]
public class ILEJKPCMKFI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly Dictionary<Guid, ICAHHIJFAHD> HMLPKMOGHLI;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private long ANKPNEKDDOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0xDAD320", Offset = "0xDAC320", VA = "0x180DAD320")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x89D25D0", Offset = "0x89D15D0", VA = "0x1889D25D0")]
	public void BFIGLCFHFAO(long DJJNJEHBMJK, IEnumerable<ICAHHIJFAHD> JKFHPAMHLLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x89D2570", Offset = "0x89D1570", VA = "0x1889D2570")]
	public bool BFHBDDPLBBF(Guid MGNBKMGEAEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x89D2AB0", Offset = "0x89D1AB0", VA = "0x1889D2AB0")]
	public bool LKIPLGLLFFP(Guid MGNBKMGEAEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x89D2860", Offset = "0x89D1860", VA = "0x1889D2860")]
	public bool CJAGABALFDJ(ICAHHIJFAHD NKAJFGAABMN, [Out] ICAHHIJFAHD IOLIPIFEJBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x89D2B10", Offset = "0x89D1B10", VA = "0x1889D2B10")]
	public IEnumerable<ICAHHIJFAHD> NPDODGHEFHC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x89D2A40", Offset = "0x89D1A40", VA = "0x1889D2A40")]
	public bool FINLKNOPDDI(Guid MGNBKMGEAEF, [Out] ICAHHIJFAHD AELMLOGGPLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x89D29C0", Offset = "0x89D19C0", VA = "0x1889D29C0")]
	private bool DBMAPFFBPMO(ICAHHIJFAHD MNBECLGJOEJ, ICAHHIJFAHD LEJOFEIMONO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x89D2B60", Offset = "0x89D1B60", VA = "0x1889D2B60")]
	public ILEJKPCMKFI()
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
