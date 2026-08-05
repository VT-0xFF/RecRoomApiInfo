using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using JetBrains.Annotations;
using RecNet;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.NoEngine.Common;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _AssemblyRegistry.RecRoom_RoomEconomy_Store_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x89E2A40", Offset = "0x89E1A40", VA = "0x1889E2A40", Slot = "8")]
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
public class MBNLJPBLFAF : NDFKHFMKMJC, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private struct DJNIIGCMINM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public MBNLJPBLFAF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x89DA6F0", Offset = "0x89D96F0", VA = "0x1889DA6F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x89DA9F0", Offset = "0x89D99F0", VA = "0x1889DA9F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private struct NCJGONJFBHJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public AsyncTaskMethodBuilder<BJFANCFIFED> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public MBNLJPBLFAF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public Guid customAvatarItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private TaskAwaiter<BJFANCFIFED> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x89E2410", Offset = "0x89E1410", VA = "0x1889E2410", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x89E26E0", Offset = "0x89E16E0", VA = "0x1889E26E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct CEBILCADMJL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public AsyncTaskMethodBuilder<List<HCJBFOICEDA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public MBNLJPBLFAF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public string searchQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public bool? isOwned;

		[Cpp2IlInjected.FieldOffset(Offset = "0x32")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public bool? isFeatured;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public IEnumerable<int> outfitTypes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public bool includeCoachItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public bool prefillResultsWithGiftBoxes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private List<HCJBFOICEDA> <results>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private TaskAwaiter<List<GICBMFJFHLI>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x89D93C0", Offset = "0x89D83C0", VA = "0x1889D93C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x89D9B70", Offset = "0x89D8B70", VA = "0x1889D9B70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct CNHPBNPPIPD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public AsyncTaskMethodBuilder<List<HCJBFOICEDA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public MBNLJPBLFAF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public IReadOnlyList<DFKJCABFMCH> unifiedItemIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public bool convertCustomAvatarItemsToPurchasableGiftDrops;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private Task <watchStorefrontTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private List<GICBMFJFHLI> <customAvatarItems>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private List<HCJBFOICEDA> <storeItemsInInitialOrder>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private TaskAwaiter<List<GICBMFJFHLI>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x89D9BE0", Offset = "0x89D8BE0", VA = "0x1889D9BE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x89DA680", Offset = "0x89D9680", VA = "0x1889DA680", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct KODKKHPCNOA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public AsyncTaskMethodBuilder<List<GICBMFJFHLI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public List<GICBMFJFHLI> customAvatarItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public MBNLJPBLFAF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x89DB590", Offset = "0x89DA590", VA = "0x1889DB590", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x89DBA90", Offset = "0x89DAA90", VA = "0x1889DBA90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class OJPCCDHIBLB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public DFKJCABFMCH id;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public OJPCCDHIBLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x89E2810", Offset = "0x89E1810", VA = "0x1889E2810")]
		internal bool OKCOKGBDICB(GBEBEEFLKJP x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x89E2750", Offset = "0x89E1750", VA = "0x1889E2750")]
		internal bool FBJEJIEKLFM(HCJBFOICEDA x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class HOKLLHBAEDO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public string itemFriendlyName;

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public HOKLLHBAEDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x89DAF50", Offset = "0x89D9F50", VA = "0x1889DAF50")]
		internal object PBHPGLDIHED()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class PBPJDNNCEKH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public MBNLJPBLFAF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public GiftItemDTO gift;

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public PBPJDNNCEKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x89E2850", Offset = "0x89E1850", VA = "0x1889E2850")]
		internal void EMBBAADJLMH(BalanceUpdateResponseDTO<MHKNNBHBKJI> result)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct LNGLHDOHJGK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public AsyncTaskMethodBuilder<KGOJLHJNIOD<BalanceUpdateResponseDTO<MHKNNBHBKJI>>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public MBNLJPBLFAF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public Guid customAvatarItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public long requestedPrice;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public GiftItemDTO gift;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public long? couponConsumablePlayerMappingId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public PNOBDCBDLNP storefrontType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public PJBEJGJLLLM currencyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private TaskAwaiter<BJFANCFIFED> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TaskAwaiter<KGOJLHJNIOD<BalanceUpdateResponseDTO<MHKNNBHBKJI>>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x89DE010", Offset = "0x89DD010", VA = "0x1889DE010", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x89DE510", Offset = "0x89DD510", VA = "0x1889DE510", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class GCCGIHLLPJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public MBNLJPBLFAF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public bool handleShowGiftPackage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public bool shouldConsumeGiftBoxImmediately;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public GCCGIHLLPJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x89DAA50", Offset = "0x89D9A50", VA = "0x1889DAA50")]
		internal void BEACKCJKDIC(BalanceUpdateResponseDTO<MHKNNBHBKJI> result)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class GHJIGDEADJM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public MBNLJPBLFAF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public GiftItemDTO gift;

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public GHJIGDEADJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x89DAA90", Offset = "0x89D9A90", VA = "0x1889DAA90")]
		internal void IJPCBOIFEEE(BalanceUpdateResponseDTO<MHKNNBHBKJI> result)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct HKPFMDDOJOI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public AsyncTaskMethodBuilder<List<BJFANCFIFED>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public IReadOnlyList<Guid> itemIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public MBNLJPBLFAF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private TaskAwaiter<List<ODENGGBLDCP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x89DAAD0", Offset = "0x89D9AD0", VA = "0x1889DAAD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x89DAEE0", Offset = "0x89D9EE0", VA = "0x1889DAEE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct JIJHLNAJKID : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public List<HCJBFOICEDA> storeItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public MBNLJPBLFAF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private int <attemptNumber>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x89DAFA0", Offset = "0x89D9FA0", VA = "0x1889DAFA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x89DB530", Offset = "0x89DA530", VA = "0x1889DB530", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly IMAGJAIKIPF<Guid, BJFANCFIFED> HAHBAGCCEIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private LBIOJOKOPKD OKINKNMAEOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private ELDAHADGLDP KEPIDKFDBJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private LOPPHNNDFGE CNPGJHPOPEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private ECANHCAGJNA FCCGEKCKNHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private KELDEDMALLB BGMMAGLAOGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private MCIAFEMJFEE FEOBKHBKLPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal JNNLABIDEOO<Guid, BJFANCFIFED> GDEJDCOHOPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private bool MCHGOAKENIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private Task FOFNDKDLEIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private CancellationTokenSource CEJCKDGDMNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private List<GBEBEEFLKJP> CAPLJJNGDMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private PBFFECJMOHO? BAPGIFOPNOJ;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static NDFKHFMKMJC CDKAGGBGIII;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private List<GBEBEEFLKJP> PPFHMNFDPFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x89DE890", Offset = "0x89DD890", VA = "0x1889DE890")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private PBFFECJMOHO EIJBKCDMCDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x89E1C80", Offset = "0x89E0C80", VA = "0x1889E1C80")]
		get
		{
			return default(PBFFECJMOHO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static NDFKHFMKMJC KONBGMLOLPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x89DF510", Offset = "0x89DE510", VA = "0x1889DF510")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x89DEA30", Offset = "0x89DDA30", VA = "0x1889DEA30")]
	private List<GBEBEEFLKJP> CMBAKEDGEJO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x89DF470", Offset = "0x89DE470", VA = "0x1889DF470")]
	[GOMLKAICHII.JENKOCGKLOO.LCLJJMFJJCN]
	internal static void EKOODCFGNGC(CBHAAKGBAOP PFJIPDCNGCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x89E1F90", Offset = "0x89E0F90", VA = "0x1889E1F90")]
	[RecRoom.NoEngine.Common.Preserve]
	public MBNLJPBLFAF([KELEGLJPNHI(null)] LOPPHNNDFGE CNPGJHPOPEB, [KELEGLJPNHI(null)] LBIOJOKOPKD OKINKNMAEOF, [KELEGLJPNHI(null)] ELDAHADGLDP KEPIDKFDBJD, [KELEGLJPNHI(null)] ECANHCAGJNA FCCGEKCKNHG, [KELEGLJPNHI(null)] KELDEDMALLB BGMMAGLAOGG, [KELEGLJPNHI(null)] MCIAFEMJFEE FEOBKHBKLPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x89DFDF0", Offset = "0x89DEDF0", VA = "0x1889DFDF0", Slot = "1")]
	~MBNLJPBLFAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x89DF1D0", Offset = "0x89DE1D0", VA = "0x1889DF1D0", Slot = "13")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x89E1EA0", Offset = "0x89E0EA0", VA = "0x1889E1EA0")]
	[AsyncStateMachine(typeof(DJNIIGCMINM))]
	private Task PHPIIKJBGBO(CancellationToken KGALDHLEDNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x89E05F0", Offset = "0x89DF5F0", VA = "0x1889E05F0")]
	public void MDIFEOEMKJL(Guid FFMOKGCBEEL, BJFANCFIFED IIJDGKMPHPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x89DF240", Offset = "0x89DE240", VA = "0x1889DF240", Slot = "14")]
	public void EDMKNNIJPCJ(HCJBFOICEDA IHOBJNBBHBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x89DFC30", Offset = "0x89DEC30", VA = "0x1889DFC30", Slot = "4")]
	public void FOIFGDNFIJJ(IEnumerable<HCJBFOICEDA> HLMPLIIKJDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x89DE580", Offset = "0x89DD580", VA = "0x1889DE580", Slot = "15")]
	public BJFANCFIFED BPOHJCLPKAF(Guid GKOPHJCJIFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x89DE690", Offset = "0x89DD690", VA = "0x1889DE690", Slot = "5")]
	public BJFANCFIFED BPOHJCLPKAF(HCJBFOICEDA IHOBJNBBHBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x89E0E50", Offset = "0x89DFE50", VA = "0x1889E0E50", Slot = "16")]
	[AsyncStateMachine(typeof(NCJGONJFBHJ))]
	public Task<BJFANCFIFED> MPEGDAFADEG(Guid GKOPHJCJIFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x89E1B20", Offset = "0x89E0B20", VA = "0x1889E1B20", Slot = "7")]
	[AsyncStateMachine(typeof(CEBILCADMJL))]
	public Task<List<HCJBFOICEDA>> PAOFLDLGHFK(string GDAOPPIJIHN, bool? BJEJLEMCCOM, bool? CFJFPMJNNGI, IEnumerable<int> AIBHDDKBJGE, bool PGMPIEFGBKP, bool LJJNMGIDJPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x89DEBA0", Offset = "0x89DDBA0", VA = "0x1889DEBA0", Slot = "6")]
	public HCJBFOICEDA DAHPAENLOOP(DFKJCABFMCH FFMOKGCBEEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x89E0D10", Offset = "0x89DFD10", VA = "0x1889E0D10", Slot = "8")]
	[AsyncStateMachine(typeof(CNHPBNPPIPD))]
	public Task<List<HCJBFOICEDA>> MGGJKDCNBFB(IReadOnlyList<DFKJCABFMCH> CMFDFDCHLAP, bool JBCAJBMNJHL = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x89E04E0", Offset = "0x89DF4E0", VA = "0x1889E04E0")]
	[AsyncStateMachine(typeof(KODKKHPCNOA))]
	private Task<List<GICBMFJFHLI>> MDFKKINNLNI(List<GICBMFJFHLI> OEDKMLBBBAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x89DF610", Offset = "0x89DE610", VA = "0x1889DF610")]
	private List<HCJBFOICEDA> FOCMOPJCIFH(IReadOnlyList<DFKJCABFMCH> LGDCMAHAADM, IReadOnlyList<GBEBEEFLKJP> MFBFPFCFMJB, IReadOnlyList<HCJBFOICEDA> OEDKMLBBBAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x89E0180", Offset = "0x89DF180", VA = "0x1889E0180", Slot = "9")]
	public KPIPLFECKNC<BalanceUpdateResponseDTO<MHKNNBHBKJI>> IIOHHNIBBGH(Guid GKOPHJCJIFA, long NFLPOBMAEIC, GiftItemDTO NJOIGDNEPCO, PJBEJGJLLLM LKGMMBJLAOE = PJBEJGJLLLM.RecCenterTokens, [Optional] long? NOFHFFFNLCJ, PNOBDCBDLNP DFOCFJFGDFE = PNOBDCBDLNP.None)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x89E0020", Offset = "0x89DF020", VA = "0x1889E0020")]
	[AsyncStateMachine(typeof(LNGLHDOHJGK))]
	private Task<KGOJLHJNIOD<BalanceUpdateResponseDTO<MHKNNBHBKJI>>> HJICNBAAGDO(Guid GKOPHJCJIFA, long NFLPOBMAEIC, GiftItemDTO NJOIGDNEPCO, PJBEJGJLLLM LKGMMBJLAOE = PJBEJGJLLLM.RecCenterTokens, [Optional] long? NOFHFFFNLCJ, PNOBDCBDLNP DFOCFJFGDFE = PNOBDCBDLNP.None)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x89E17E0", Offset = "0x89E07E0", VA = "0x1889E17E0", Slot = "10")]
	public KPIPLFECKNC<BalanceUpdateResponseDTO<MHKNNBHBKJI>> NFMLNFFAEMC(PNOBDCBDLNP DFOCFJFGDFE, PJBEJGJLLLM LKGMMBJLAOE, int NCFHPMBOLBI, long NFLPOBMAEIC, long? NOFHFFFNLCJ, int HLGGGGJKEKE, bool MLLKAKBIPAM = false, bool HFKNPEMCOKE = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x89E0730", Offset = "0x89DF730", VA = "0x1889E0730", Slot = "11")]
	public KPIPLFECKNC<BalanceUpdateResponseDTO<MHKNNBHBKJI>> MENJBJNKHKO(PNOBDCBDLNP DFOCFJFGDFE, PJBEJGJLLLM LKGMMBJLAOE, int NCFHPMBOLBI, long NFLPOBMAEIC, long? NOFHFFFNLCJ, IReadOnlyCollection<int> IOANGDKEBJJ, string OBCNAJEENCI, bool GBFIFLENGGP, EHFKNLKDDIE NMFHPFNAAFJ, int HLGGGGJKEKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x89E0F60", Offset = "0x89DFF60", VA = "0x1889E0F60", Slot = "12")]
	public KPIPLFECKNC<BalanceUpdateResponseDTO<MHKNNBHBKJI>> NCDNHMDLAEI(PNOBDCBDLNP DFOCFJFGDFE, PJBEJGJLLLM LKGMMBJLAOE, IReadOnlyList<DFKJCABFMCH> GHJPMELOBEF, IReadOnlyList<long> JFDKGLEDPBI, [Optional] long? NOFHFFFNLCJ, [Optional][CanBeNull] GiftItemDTO NJOIGDNEPCO, [Optional] Guid? PGMAKHCMJKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x89DFEE0", Offset = "0x89DEEE0", VA = "0x1889DFEE0")]
	[AsyncStateMachine(typeof(HKPFMDDOJOI))]
	private Task<List<BJFANCFIFED>> HENGMMGCOIL(IReadOnlyList<Guid> GHJPMELOBEF, CancellationToken KGALDHLEDNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x89DEE90", Offset = "0x89DDE90", VA = "0x1889DEE90")]
	private void DBGDNHDLAHM(BalanceUpdateResponseDTO<MHKNNBHBKJI> GLGHOKJGILM, bool OCPGINNDHGH, bool HFKNPEMCOKE, bool MLLKAKBIPAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x89E1570", Offset = "0x89E0570", VA = "0x1889E1570")]
	private void NDMBHMLCKIG(JKKPLHHIIHB KNLHPFPAMIB, bool MCAJOMFGAEK, bool NAMBFMLBEON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x89E03E0", Offset = "0x89DF3E0", VA = "0x1889E03E0")]
	[AsyncStateMachine(typeof(JIJHLNAJKID))]
	private Task LECOIBFHIAO(List<HCJBFOICEDA> HLMPLIIKJDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x89DF1A0", Offset = "0x89DE1A0", VA = "0x1889DF1A0")]
	[CompilerGenerated]
	private void DEHMAHBONEK(BalanceUpdateResponseDTO<MHKNNBHBKJI> BGOCMPMGKKI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class LDKOKECADID : DBGGDJNCPDM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly KELDEDMALLB ENHDKPHPAMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly BBPDOCPMPJE NPHJPHBEMCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly GBGKNBEMNGP DJOBLLKEGLG;

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x89DDE70", Offset = "0x89DCE70", VA = "0x1889DDE70")]
	[GOMLKAICHII.JENKOCGKLOO.LCLJJMFJJCN]
	internal static void PHNOHKBOJEP(CBHAAKGBAOP PFJIPDCNGCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0xD64110", Offset = "0xD63110", VA = "0x180D64110")]
	[RecRoom.NoEngine.Common.Preserve]
	public LDKOKECADID([KELEGLJPNHI(null)] KELDEDMALLB BGMMAGLAOGG, [KELEGLJPNHI(null)] BBPDOCPMPJE DLNBGEHLLCP, [KELEGLJPNHI(null)] GBGKNBEMNGP OEDKMLBBBAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x89DD7A0", Offset = "0x89DC7A0", VA = "0x1889DD7A0")]
	private bool LHAAHCKHDKI(DFMOEODODKE PLIKMCGPKPH, DFMOEODODKE IBJLMGJHJPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x89DDB20", Offset = "0x89DCB20", VA = "0x1889DDB20", Slot = "5")]
	public IReadOnlyList<HCJBFOICEDA> OBMFDJLINOK(DFMOEODODKE ICNBHEPLHLF, IReadOnlyList<HCJBFOICEDA> NKOHPCLOFJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x89DBF40", Offset = "0x89DAF40", VA = "0x1889DBF40", Slot = "4")]
	public bool DNBLOJFLALK(DFMOEODODKE ICNBHEPLHLF, HCJBFOICEDA ADPMEPGEIDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x89DBD20", Offset = "0x89DAD20", VA = "0x1889DBD20")]
	private bool AOGDDIMKLCG(DFMOEODODKE ICNBHEPLHLF, HCJBFOICEDA ADPMEPGEIDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x89DD100", Offset = "0x89DC100", VA = "0x1889DD100")]
	private bool HNMBGIAPENF(DFMOEODODKE ICNBHEPLHLF, HCJBFOICEDA ADPMEPGEIDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x89DCB10", Offset = "0x89DBB10", VA = "0x1889DCB10")]
	private bool ECMHCGBJFCP(DFMOEODODKE ICNBHEPLHLF, HCJBFOICEDA ADPMEPGEIDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x89DCC10", Offset = "0x89DBC10", VA = "0x1889DCC10")]
	public bool FDCAKPAEELK(HCJBFOICEDA IHOBJNBBHBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x89DCE60", Offset = "0x89DBE60", VA = "0x1889DCE60")]
	public bool FDCAKPAEELK(FLMDJANAGJA EGNGCCDPPKD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x89DDA10", Offset = "0x89DCA10", VA = "0x1889DDA10")]
	private bool NPNLNMBOLFF(Guid GKOPHJCJIFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x89DD690", Offset = "0x89DC690", VA = "0x1889DD690")]
	private bool KIGNDKIEEAB(DFMOEODODKE ICNBHEPLHLF, HCJBFOICEDA ADPMEPGEIDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x89DD8D0", Offset = "0x89DC8D0", VA = "0x1889DD8D0")]
	private bool MFFHDIFMEDH(DFMOEODODKE ICNBHEPLHLF, HCJBFOICEDA ADPMEPGEIDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x89DD6C0", Offset = "0x89DC6C0", VA = "0x1889DD6C0")]
	private bool LAFCCHEMJPH(DFMOEODODKE ICNBHEPLHLF, HCJBFOICEDA ADPMEPGEIDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x89DD730", Offset = "0x89DC730", VA = "0x1889DD730")]
	private bool LGMILGILPKM(DFMOEODODKE ICNBHEPLHLF, HCJBFOICEDA ADPMEPGEIDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x89DCF30", Offset = "0x89DBF30", VA = "0x1889DCF30")]
	private bool FNLNIHALICJ(DFMOEODODKE ICNBHEPLHLF, HCJBFOICEDA ADPMEPGEIDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x89DDE00", Offset = "0x89DCE00", VA = "0x1889DDE00")]
	private bool PEFEMCPEBPJ(DFMOEODODKE ICNBHEPLHLF, HCJBFOICEDA ADPMEPGEIDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x89DBC20", Offset = "0x89DAC20", VA = "0x1889DBC20")]
	private bool AHOFMJAJMHM(DFMOEODODKE ICNBHEPLHLF, HCJBFOICEDA ADPMEPGEIDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x89DBC90", Offset = "0x89DAC90", VA = "0x1889DBC90")]
	private bool AJDHIPAAFAM(DFMOEODODKE ICNBHEPLHLF, HCJBFOICEDA ADPMEPGEIDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x89DDF50", Offset = "0x89DCF50", VA = "0x1889DDF50")]
	private bool PPNFPPHCEIE(DFMOEODODKE ICNBHEPLHLF, HCJBFOICEDA ADPMEPGEIDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x89DD600", Offset = "0x89DC600", VA = "0x1889DD600")]
	private bool KEMBMNLHCFM(DFMOEODODKE ICNBHEPLHLF, HCJBFOICEDA ADPMEPGEIDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x89DDD70", Offset = "0x89DCD70", VA = "0x1889DDD70")]
	private bool OMODLAKLPHD(DFMOEODODKE ICNBHEPLHLF, HCJBFOICEDA ADPMEPGEIDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x89DBEB0", Offset = "0x89DAEB0", VA = "0x1889DBEB0")]
	private bool BKEKNCCFFHO(DFMOEODODKE ICNBHEPLHLF, HCJBFOICEDA ADPMEPGEIDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x89DD400", Offset = "0x89DC400", VA = "0x1889DD400")]
	private bool IDFPPEMALIK(DFMOEODODKE ICNBHEPLHLF, HCJBFOICEDA ADPMEPGEIDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x89DBE20", Offset = "0x89DAE20", VA = "0x1889DBE20")]
	private bool BBDAOJHHIEH(DFMOEODODKE ICNBHEPLHLF, HCJBFOICEDA ADPMEPGEIDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x89DD070", Offset = "0x89DC070", VA = "0x1889DD070")]
	private bool HEOIIDBMABJ(DFMOEODODKE ICNBHEPLHLF, HCJBFOICEDA ADPMEPGEIDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x89DD8F0", Offset = "0x89DC8F0", VA = "0x1889DD8F0")]
	private bool NNABIFHJBIJ(DFMOEODODKE ICNBHEPLHLF, HCJBFOICEDA ADPMEPGEIDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x89DDA90", Offset = "0x89DCA90", VA = "0x1889DDA90")]
	private bool OBBKKFKMAOC(DFMOEODODKE ICNBHEPLHLF, HCJBFOICEDA ADPMEPGEIDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x89DBB90", Offset = "0x89DAB90", VA = "0x1889DBB90")]
	private bool AFNFEEAENLB(DFMOEODODKE ICNBHEPLHLF, HCJBFOICEDA ADPMEPGEIDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x89DD980", Offset = "0x89DC980", VA = "0x1889DD980")]
	private bool NOLOAELBNKF(DFMOEODODKE ICNBHEPLHLF, HCJBFOICEDA ADPMEPGEIDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x89DD550", Offset = "0x89DC550", VA = "0x1889DD550")]
	private bool KDICCPPBJCC(DFMOEODODKE ICNBHEPLHLF, HCJBFOICEDA ADPMEPGEIDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x89DBB00", Offset = "0x89DAB00", VA = "0x1889DBB00")]
	private bool ABHPKEMAGHL(DFMOEODODKE ICNBHEPLHLF, HCJBFOICEDA ADPMEPGEIDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x89DD490", Offset = "0x89DC490", VA = "0x1889DD490")]
	private bool IKGMBFMCOFL(DFMOEODODKE ICNBHEPLHLF, HCJBFOICEDA ADPMEPGEIDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x89DCFA0", Offset = "0x89DBFA0", VA = "0x1889DCFA0")]
	private bool GEEIPBHCEJK(DFMOEODODKE ICNBHEPLHLF, HCJBFOICEDA ADPMEPGEIDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x89DD840", Offset = "0x89DC840", VA = "0x1889DD840")]
	private bool MEOJMNOFHIK(DFMOEODODKE ICNBHEPLHLF, HCJBFOICEDA ADPMEPGEIDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x89DBDB0", Offset = "0x89DADB0", VA = "0x1889DBDB0")]
	private bool APKCHNNLPOG(DFMOEODODKE ICNBHEPLHLF, HCJBFOICEDA ADPMEPGEIDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x89DCB80", Offset = "0x89DBB80", VA = "0x1889DCB80")]
	private bool EDLLBOPJPJN(DFMOEODODKE ICNBHEPLHLF, HCJBFOICEDA ADPMEPGEIDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x89DD7B0", Offset = "0x89DC7B0", VA = "0x1889DD7B0")]
	private bool LNDGGFDDKFF(DFMOEODODKE ICNBHEPLHLF, HCJBFOICEDA ADPMEPGEIDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x89DDEE0", Offset = "0x89DCEE0", VA = "0x1889DDEE0")]
	private bool PIADJCDGFAN(DFMOEODODKE ICNBHEPLHLF, HCJBFOICEDA ADPMEPGEIDH)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class HLGNEFPMHEK
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public HLGNEFPMHEK()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class __BB_OBFUSCATOR_VERSION_3_10_0
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
