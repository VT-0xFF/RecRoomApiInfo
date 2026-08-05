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
		[Cpp2IlInjected.Address(RVA = "0x82CC890", Offset = "0x82CB090", VA = "0x1882CC890", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2612DF0", Offset = "0x26115F0", VA = "0x182612DF0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface PHKKHHDPFDP : GLCDJNAENDJ
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	FBPLMLHKBDA OIOBKMJNMDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface OCEGHOGLNEH
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LMMNLHLJEMA BGAOOFKCPFB();
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class MNNDADEPOAK : OCEGHOGLNEH
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x82CB3A0", Offset = "0x82C9BA0", VA = "0x1882CB3A0")]
	[PJMOOJOMMCC.IIIJEBEMPMI.HIHGDIHOODG]
	internal static void ADFMLLHPKEO(HHDGAAFLDEF PMKEELMHMLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	[RecRoom.NoEngine.Common.Preserve]
	public MNNDADEPOAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x82CB410", Offset = "0x82C9C10", VA = "0x1882CB410", Slot = "4")]
	public LMMNLHLJEMA BGAOOFKCPFB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[DBBJMDENMLB]
public class FBPLMLHKBDA : MAOFMNBDEAB, IDisposable, NFBKCCOFLBJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct DHJGINIJPHO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public AsyncTaskMethodBuilder<HCGBMJDNFKJ<JFPJFPPIPDF, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public FBPLMLHKBDA <>4__this;

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
		public GCFCGMIOOKJ roomOfferType;

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
		private TaskAwaiter<NJALFJAOODE<JFPJFPPIPDF>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x82C3800", Offset = "0x82C2000", VA = "0x1882C3800", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x82C3D30", Offset = "0x82C2530", VA = "0x1882C3D30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct PEOLANJLFIB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public AsyncTaskMethodBuilder<HCGBMJDNFKJ<JFPJFPPIPDF, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public FBPLMLHKBDA <>4__this;

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
		public GCFCGMIOOKJ roomOfferType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public Dictionary<Guid, int> roomInventoryItemMappings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public Guid? priceUnitId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private TaskAwaiter<NJALFJAOODE<JFPJFPPIPDF>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x82CBEB0", Offset = "0x82CA6B0", VA = "0x1882CBEB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x82CC450", Offset = "0x82CAC50", VA = "0x1882CC450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct JJANKPNLMAJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public AsyncTaskMethodBuilder<HCGBMJDNFKJ<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public FBPLMLHKBDA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public Guid roomOfferId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private JFPJFPPIPDF <existingRoomOffer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private TaskAwaiter<KFNGEGFGHNK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x82CA540", Offset = "0x82C8D40", VA = "0x1882CA540", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x82CAAA0", Offset = "0x82C92A0", VA = "0x1882CAAA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct AMLJODOGOLG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public AsyncTaskMethodBuilder<List<NEPIBHNNPJN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public FBPLMLHKBDA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TaskAwaiter<NJALFJAOODE<List<NEPIBHNNPJN>>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x82C2A00", Offset = "0x82C1200", VA = "0x1882C2A00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x82C2DF0", Offset = "0x82C15F0", VA = "0x1882C2DF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct ONCHIOPJLDK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public FBPLMLHKBDA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public GFEBJDBBDID player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public Guid roomOfferId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private TaskAwaiter<int> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x82CB4D0", Offset = "0x82C9CD0", VA = "0x1882CB4D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x82CB870", Offset = "0x82CA070", VA = "0x1882CB870", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct GLLJKAEOHEL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public AsyncTaskMethodBuilder<HCGBMJDNFKJ<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public FBPLMLHKBDA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public JFPJFPPIPDF roomOffer;

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
		private TaskAwaiter<HCGBMJDNFKJ<bool, string>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x82C9730", Offset = "0x82C7F30", VA = "0x1882C9730", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x82C9C80", Offset = "0x82C8480", VA = "0x1882C9C80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct BIHMEHLHOIL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public AsyncTaskMethodBuilder<HCGBMJDNFKJ<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int quantity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public FBPLMLHKBDA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public JFPJFPPIPDF roomOffer;

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
		private GLMHIPLNDOP <operationResult>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private int <attemptNumber>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private DGOCPJLDHFO <response>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private TaskAwaiter<DGOCPJLDHFO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x82C2E60", Offset = "0x82C1660", VA = "0x1882C2E60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x82C3790", Offset = "0x82C1F90", VA = "0x1882C3790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class LANMHNJAFOJ
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
			public LANMHNJAFOJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public Guid itemId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x82CC4C0", Offset = "0x82CACC0", VA = "0x1882CC4C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x82CC830", Offset = "0x82CB030", VA = "0x1882CC830", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public FBPLMLHKBDA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public int expectedTotalPrice;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public LANMHNJAFOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x82CAC30", Offset = "0x82C9430", VA = "0x1882CAC30")]
		[AsyncStateMachine(typeof(<<SendRecNetRoomOfferPurchaseRequest>g__FlushPendingInventoryItemUpdatesIfNeeded|0>d))]
		internal Task GLBDPHFFCLO(Guid itemId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x82CAB10", Offset = "0x82C9310", VA = "0x1882CAB10")]
		internal Guid? BFELKHNKKAB(Guid itemId)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct EKHDGJIEIGN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public AsyncTaskMethodBuilder<DGOCPJLDHFO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public FBPLMLHKBDA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public int requestedPrice;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public int quantity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public JFPJFPPIPDF roomOffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private LANMHNJAFOJ <>8__1;

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
		private TaskAwaiter<DGOCPJLDHFO> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x82C3DA0", Offset = "0x82C25A0", VA = "0x1882C3DA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x82C4A60", Offset = "0x82C3260", VA = "0x1882C4A60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct JGIBEDKDDAA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public FBPLMLHKBDA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private Task<NJALFJAOODE<List<HGOMMDFEGNA>>> <purchaseCountsTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private TaskAwaiter<List<JFPJFPPIPDF>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private TaskAwaiter<NJALFJAOODE<List<HGOMMDFEGNA>>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x82C9CF0", Offset = "0x82C84F0", VA = "0x1882C9CF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x82CA4E0", Offset = "0x82C8CE0", VA = "0x1882CA4E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct FAKCJNPFAMI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public FBPLMLHKBDA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private TaskAwaiter<Task> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x82C4AD0", Offset = "0x82C32D0", VA = "0x1882C4AD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x82C5140", Offset = "0x82C3940", VA = "0x1882C5140", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct PEBKKIHNOHF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public FBPLMLHKBDA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public GFEBJDBBDID player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private TaskAwaiter<int> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x82CB8E0", Offset = "0x82CA0E0", VA = "0x1882CB8E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x82CBE40", Offset = "0x82CA640", VA = "0x1882CBE40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly TimeSpan EEKDGMDJNGF;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public const string OFCENBNOELD = "econ_room_offer_gate";

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private const string HIMJNNFLEDF = "Unknown error occured. If this persists, please contact us at recroom.zendesk.com";

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private const string NDCGLFKIMIG = "CV2_Purchase_Prompt_Chip";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly IGOFIAMJLAI LBFBMIKKKBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly IKIGIOAMAFP LBDHOOKKIED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly NIIJIBHLHFA MLHODHKGKEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly MKLIBFLPPKJ ANGPHDLCABJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly KHLPMELLNOA CBKIHIBAAII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly PHKKHHDPFDP JMPHAIIKFEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly MEJMOFFFFPE LMJFACKNPAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly HLIHGPANEKM FOBMOKOBPAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly NNIMGBPGDIF CPOJFCFCEPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly CHLALMGBIDN DHEJOBGKIOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly LMMNLHLJEMA KGAGGEHIAFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private Dictionary<Guid, int> HAAJDAPFECG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly IDisposable HGJNLOOJGEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private Task JEPCAFGDFAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private CancellationTokenSource EHMPNABMANA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private long DGJBMAKKKIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool IHDAJILAEEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly NMCLOAPPAGI EOPLJDJOOOG;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private DDBKFFNIOEI DNKPKNGFNNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x82C6270", Offset = "0x82C4A70", VA = "0x1882C6270")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public FIEKIAHLEMJ EFLFKECHCJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xCAB0D0", Offset = "0xCA98D0", VA = "0x180CAB0D0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xE18B30", Offset = "0xE17330", VA = "0x180E18B30", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public HOPADDCECBJ<JFPJFPPIPDF> JPLHEFBMGBM
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x9E71A0", Offset = "0x9E59A0", VA = "0x1809E71A0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x9E7180", Offset = "0x9E5980", VA = "0x1809E7180", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public HOPADDCECBJ<Guid> LONAEHDEHDN
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xBF9060", Offset = "0xBF7860", VA = "0x180BF9060", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xE28C10", Offset = "0xE27410", VA = "0x180E28C10", Slot = "9")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x82C53A0", Offset = "0x82C3BA0", VA = "0x1882C53A0")]
	[PJMOOJOMMCC.IIIJEBEMPMI.HIHGDIHOODG]
	internal static void ADFMLLHPKEO(HHDGAAFLDEF PMKEELMHMLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x82C9010", Offset = "0x82C7810", VA = "0x1882C9010")]
	[RecRoom.NoEngine.Common.Preserve]
	public FBPLMLHKBDA([LDAFGEHKDJK(null)] IGOFIAMJLAI LBFBMIKKKBI, [LDAFGEHKDJK(null)] IKIGIOAMAFP LBDHOOKKIED, [LDAFGEHKDJK(null)] KGOPFPAOFEK ILOBEJMDKPD, [LDAFGEHKDJK(null)] NIIJIBHLHFA MLHODHKGKEC, [LDAFGEHKDJK(null)] OCEGHOGLNEH AGLBOILHKMA, [LDAFGEHKDJK(null)] MKLIBFLPPKJ ANGPHDLCABJ, [LDAFGEHKDJK("ShowPurchasePromptRateLimiter")] KHLPMELLNOA CBKIHIBAAII, [LDAFGEHKDJK(null)] PHKKHHDPFDP JMPHAIIKFEO, [LDAFGEHKDJK(null)] FBKFHNFAGBI MBHPCHLHNLN, [LDAFGEHKDJK(null)] MEJMOFFFFPE LMJFACKNPAI, [LDAFGEHKDJK(null)] HLIHGPANEKM FOBMOKOBPAH, [LDAFGEHKDJK(null)] NNIMGBPGDIF CPOJFCFCEPM, [LDAFGEHKDJK(null)] CHLALMGBIDN DHEJOBGKIOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x82C62C0", Offset = "0x82C4AC0", VA = "0x1882C62C0", Slot = "23")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x82C5970", Offset = "0x82C4170", VA = "0x1882C5970", Slot = "10")]
	[AsyncStateMachine(typeof(DHJGINIJPHO))]
	public Task<HCGBMJDNFKJ<JFPJFPPIPDF, string>> BPJMPNLNDOM(Guid? NJHJECCCGDO, long MDLDCACFGIB, string GLGOHIJMLFB, string NIAMDMBDIJG, string LJANIECHELJ, int BBCMDPJPAOE, GCFCGMIOOKJ KFCFICFFEGM, [Optional] Dictionary<Guid, int> KNDAJKFINHI, [Optional] Guid? OBDKEHDOHMD, bool BNDADHGIJAI = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x82C5B20", Offset = "0x82C4320", VA = "0x1882C5B20", Slot = "11")]
	[AsyncStateMachine(typeof(PEOLANJLFIB))]
	public Task<HCGBMJDNFKJ<JFPJFPPIPDF, string>> CFOCFLCAIHD(Guid GBKHLEIHNJJ, long MDLDCACFGIB, string GLGOHIJMLFB, string NIAMDMBDIJG, string LJANIECHELJ, int BBCMDPJPAOE, GCFCGMIOOKJ KFCFICFFEGM, [Optional] Dictionary<Guid, int> KNDAJKFINHI, [Optional] Guid? OBDKEHDOHMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x82C7FA0", Offset = "0x82C67A0", VA = "0x1882C7FA0", Slot = "12")]
	[AsyncStateMachine(typeof(JJANKPNLMAJ))]
	public Task<HCGBMJDNFKJ<bool, string>> MIEJIAFDECN(Guid IKMCJGPNODF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x82C8580", Offset = "0x82C6D80", VA = "0x1882C8580", Slot = "13")]
	public IEnumerable<JFPJFPPIPDF> NOIDDGMBOKO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x82C73E0", Offset = "0x82C5BE0", VA = "0x1882C73E0", Slot = "14")]
	[AsyncStateMachine(typeof(AMLJODOGOLG))]
	public Task<List<NEPIBHNNPJN>> KEDJHDGHKKH(long MDLDCACFGIB, [Optional] CancellationToken DNHBNMHIDAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x82C51A0", Offset = "0x82C39A0", VA = "0x1882C51A0", Slot = "17")]
	public bool ADDKHHMBAFN(Guid IKMCJGPNODF, int DDGFKCHCCKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x82C7510", Offset = "0x82C5D10", VA = "0x1882C7510", Slot = "15")]
	public bool KNPLOLHDGKO(Guid IKMCJGPNODF, [Out] JFPJFPPIPDF GBEJOBPDFOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x82C6520", Offset = "0x82C4D20", VA = "0x1882C6520", Slot = "16")]
	public bool FAPPDLELBJE(string GLGOHIJMLFB, [Out] JFPJFPPIPDF GBEJOBPDFOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x82C76C0", Offset = "0x82C5EC0", VA = "0x1882C76C0", Slot = "18")]
	public void MBLHDOLBFFL(GFEBJDBBDID PPBALHIMPIH, Guid IKMCJGPNODF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x82C54F0", Offset = "0x82C3CF0", VA = "0x1882C54F0", Slot = "19")]
	[AsyncStateMachine(typeof(ONCHIOPJLDK))]
	public Task<int> APABDLCNLKC(GFEBJDBBDID PPBALHIMPIH, Guid IKMCJGPNODF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x82C5410", Offset = "0x82C3C10", VA = "0x1882C5410", Slot = "20")]
	public bool AJMJIFDMDGM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x82C6B90", Offset = "0x82C5390", VA = "0x1882C6B90", Slot = "21")]
	public bool HPCFHNMKLEP(Guid MAOEEMAEHGL, [Out] List<string> MJFJPNMPMNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x82C6780", Offset = "0x82C4F80", VA = "0x1882C6780", Slot = "22")]
	[AsyncStateMachine(typeof(GLLJKAEOHEL))]
	public Task<HCGBMJDNFKJ<bool, string>> FCMIMEPEGBK(JFPJFPPIPDF GBEJOBPDFOK, long NNJMLCCPAMG, int JBLCDPEEHBE, string DAALJEAMJLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x82C80C0", Offset = "0x82C68C0", VA = "0x1882C80C0")]
	[AsyncStateMachine(typeof(BIHMEHLHOIL))]
	private Task<HCGBMJDNFKJ<bool, string>> NKCGLKELABG(JFPJFPPIPDF GBEJOBPDFOK, long NNJMLCCPAMG, long LPEMDKHFCKJ, string DAALJEAMJLA, int JBLCDPEEHBE = 1)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x82C5CC0", Offset = "0x82C44C0", VA = "0x1882C5CC0")]
	[AsyncStateMachine(typeof(EKHDGJIEIGN))]
	private Task<DGOCPJLDHFO> CHHIIFELCNO(JFPJFPPIPDF GBEJOBPDFOK, int JBLCDPEEHBE, int NNJMLCCPAMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x82C7C50", Offset = "0x82C6450", VA = "0x1882C7C50")]
	private bool MICEDBNPFHD(IEnumerable<DHKFIBAHAEL> ELOJGLDOJNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x82C8770", Offset = "0x82C6F70", VA = "0x1882C8770")]
	private void OPFDMIJAHNC(JFPJFPPIPDF GBEJOBPDFOK, long LPEMDKHFCKJ, int JBLCDPEEHBE, string DAALJEAMJLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x82C5630", Offset = "0x82C3E30", VA = "0x1882C5630")]
	private string BDBKPNLDIHP(JFPJFPPIPDF GBEJOBPDFOK, int JBLCDPEEHBE, string DAALJEAMJLA, [Optional] GLMHIPLNDOP? HLPIAOANGMD, [Optional] EBHFKFFGGPP? PJAANHBCCFJ, [Optional] string NKOPOCMHONA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x82C6F90", Offset = "0x82C5790", VA = "0x1882C6F90")]
	private GLMHIPLNDOP IOEIOLJIKGA(JFPJFPPIPDF AKKIAGNIOAI, int CJOIMAOEODE, [Out] long LPEMDKHFCKJ)
	{
		return default(GLMHIPLNDOP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x82C6A80", Offset = "0x82C5280", VA = "0x1882C6A80")]
	[AsyncStateMachine(typeof(JGIBEDKDDAA))]
	private Task HMDEKBPLNEN(long MDLDCACFGIB, CancellationToken DNHBNMHIDAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x82C5E90", Offset = "0x82C4690", VA = "0x1882C5E90")]
	private Task CPJIHLDJFIF(CCOEKIMEHPP FHMAIKMLNLH, CancellationToken DNHBNMHIDAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x82C75F0", Offset = "0x82C5DF0", VA = "0x1882C75F0")]
	[AsyncStateMachine(typeof(FAKCJNPFAMI))]
	private Task LLAGKHDPFLD(CCOEKIMEHPP FHMAIKMLNLH, CancellationToken HJPJAFEJNKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x82C8220", Offset = "0x82C6A20", VA = "0x1882C8220")]
	private static Dictionary<Guid, int> NLFGKKMGHKD(NJALFJAOODE<List<HGOMMDFEGNA>> FGMOEAFAPEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x82C73D0", Offset = "0x82C5BD0", VA = "0x1882C73D0")]
	private void JGBGOFNGNKP(JFPJFPPIPDF GBEJOBPDFOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x82C5E20", Offset = "0x82C4620", VA = "0x1882C5E20")]
	private void CIIILKKGNPN(Guid IKMCJGPNODF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x82C8DB0", Offset = "0x82C75B0", VA = "0x1882C8DB0")]
	[FNNKNPEGGMF]
	internal void RpcOfferShowPurchasePrompt(Guid IKMCJGPNODF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x82C8630", Offset = "0x82C6E30", VA = "0x1882C8630")]
	[AsyncStateMachine(typeof(PEBKKIHNOHF))]
	private Task<int> OKEHPDEIHBE(GFEBJDBBDID PPBALHIMPIH, Guid MAOEEMAEHGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x82C8BC0", Offset = "0x82C73C0", VA = "0x1882C8BC0")]
	[FNNKNPEGGMF]
	internal void RpcGetPlayerRoomOfferPurchaseCount(Guid KJHDGFKNPKN, Guid IKMCJGPNODF, FKGLIIJKAOO DMLFPKLKPFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x82C8B40", Offset = "0x82C7340", VA = "0x1882C8B40")]
	[FNNKNPEGGMF]
	internal void RpcGetPlayerRoomOfferPurchaseCountResponse(Guid KJHDGFKNPKN, int PCFOAHIEPDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x82C78A0", Offset = "0x82C60A0", VA = "0x1882C78A0", Slot = "24")]
	public string MHCKPOGJFNM(GLMHIPLNDOP HLPIAOANGMD, [Optional] EBHFKFFGGPP? OPMAANBLEMK, [Optional] BalanceResponseDTO HJKNDFAAIDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x82C5880", Offset = "0x82C4080", VA = "0x1882C5880")]
	private static string BPIOCMFPKAA(EBHFKFFGGPP OPMAANBLEMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x82C68E0", Offset = "0x82C50E0", VA = "0x1882C68E0")]
	private JFPJFPPIPDF HALOPDNGIPG(JFPJFPPIPDF BCIDKJANIHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x82C7360", Offset = "0x82C5B60", VA = "0x1882C7360")]
	private void JDANFPIEILH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x82C7230", Offset = "0x82C5A30", VA = "0x1882C7230")]
	private void JAEJBHFJKCF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[DefaultMember("Item")]
public class LMMNLHLJEMA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly Dictionary<Guid, JFPJFPPIPDF> JCIIFEEGFBE;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private long MPBMECOMGLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0xC57CB0", Offset = "0xC564B0", VA = "0x180C57CB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x82CAFB0", Offset = "0x82C97B0", VA = "0x1882CAFB0")]
	public void NCEGDKLJFEH(long MDLDCACFGIB, IEnumerable<JFPJFPPIPDF> FBGLBPCKAGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x82CAEE0", Offset = "0x82C96E0", VA = "0x1882CAEE0")]
	public bool EBKAEPKBMCD(Guid IKMCJGPNODF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x82CAD20", Offset = "0x82C9520", VA = "0x1882CAD20")]
	public bool AHELLINFOCL(Guid IKMCJGPNODF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x82CAD80", Offset = "0x82C9580", VA = "0x1882CAD80")]
	public bool DBKLBEAGHLN(JFPJFPPIPDF EPHACNFHPLF, [Out] JFPJFPPIPDF FPIMBJKKFCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x82CB240", Offset = "0x82C9A40", VA = "0x1882CB240")]
	public IEnumerable<JFPJFPPIPDF> NMKIFKOLOCP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x82CAF40", Offset = "0x82C9740", VA = "0x1882CAF40")]
	public bool KNPLOLHDGKO(Guid IKMCJGPNODF, [Out] JFPJFPPIPDF GBEJOBPDFOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x82CB290", Offset = "0x82C9A90", VA = "0x1882CB290")]
	private bool PPFDOLPBIJE(JFPJFPPIPDF BOCGDEDFMLC, JFPJFPPIPDF GDEOHNFFMMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x82CB310", Offset = "0x82C9B10", VA = "0x1882CB310")]
	public LMMNLHLJEMA()
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
