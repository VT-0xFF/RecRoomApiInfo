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
namespace _AssemblyRegistry.RecRoom_RoomEconomy_Store_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x82D59D0", Offset = "0x82D41D0", VA = "0x1882D59D0", Slot = "8")]
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
public class GOACFBMGBPP : JEHBLHCOCBF, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private struct LIMNCFJIEFF : IAsyncStateMachine
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
		public GOACFBMGBPP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x82D4420", Offset = "0x82D2C20", VA = "0x1882D4420", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x82D4720", Offset = "0x82D2F20", VA = "0x1882D4720", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private struct LLCEEOPCPPH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public AsyncTaskMethodBuilder<FMGFJMMDKNG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public GOACFBMGBPP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public Guid customAvatarItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private TaskAwaiter<FMGFJMMDKNG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x82D4780", Offset = "0x82D2F80", VA = "0x1882D4780", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x82D4A50", Offset = "0x82D3250", VA = "0x1882D4A50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct MIKGBJPBKID : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public AsyncTaskMethodBuilder<List<CPKMEDMFFBO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public GOACFBMGBPP <>4__this;

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
		private List<CPKMEDMFFBO> <results>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private TaskAwaiter<List<ACFMHBIMNNI>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x82D4AC0", Offset = "0x82D32C0", VA = "0x1882D4AC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x82D5270", Offset = "0x82D3A70", VA = "0x1882D5270", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct AMIPILAADIE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public AsyncTaskMethodBuilder<List<CPKMEDMFFBO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public GOACFBMGBPP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public IReadOnlyList<BNHEKEPANBN> unifiedItemIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public bool convertCustomAvatarItemsToPurchasableGiftDrops;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private List<CPKMEDMFFBO> <storeItemsInInitialOrder>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private TaskAwaiter<List<ACFMHBIMNNI>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x82CCAE0", Offset = "0x82CB2E0", VA = "0x1882CCAE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x82CD380", Offset = "0x82CBB80", VA = "0x1882CD380", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct DMOOGBNAJDI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public AsyncTaskMethodBuilder<List<ACFMHBIMNNI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public List<ACFMHBIMNNI> customAvatarItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public GOACFBMGBPP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x82CD3F0", Offset = "0x82CBBF0", VA = "0x1882CD3F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x82CD8F0", Offset = "0x82CC0F0", VA = "0x1882CD8F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class FCICKGMEBDI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public BNHEKEPANBN id;

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public FCICKGMEBDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x82CDA20", Offset = "0x82CC220", VA = "0x1882CDA20")]
		internal bool OCAKDFMHMBO(KJNLAEJHIKH x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x82CD960", Offset = "0x82CC160", VA = "0x1882CD960")]
		internal bool NGIIHIJDIKP(CPKMEDMFFBO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class HLHJNILDOPA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public string itemFriendlyName;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public HLHJNILDOPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x82D15F0", Offset = "0x82CFDF0", VA = "0x1882D15F0")]
		internal object LEHOILJAOGH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class IIANDMLNNML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public GOACFBMGBPP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public GiftItemDTO gift;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public IIANDMLNNML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x82D1640", Offset = "0x82CFE40", VA = "0x1882D1640")]
		internal void EEINJJJNPID(BalanceUpdateResponseDTO<DEHHLKOFBNB> result)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct LCCNANILPEA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public AsyncTaskMethodBuilder<MLGCIODNMCL<BalanceUpdateResponseDTO<DEHHLKOFBNB>>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public GOACFBMGBPP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public Guid customAvatarItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public long requestedPrice;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public GiftItemDTO gift;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public long? couponConsumablePlayerMappingId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public JDGPNLOGLBE storefrontType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public FIEOJKLGOND currencyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private TaskAwaiter<FMGFJMMDKNG> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private TaskAwaiter<MLGCIODNMCL<BalanceUpdateResponseDTO<DEHHLKOFBNB>>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x82D1AE0", Offset = "0x82D02E0", VA = "0x1882D1AE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x82D1FC0", Offset = "0x82D07C0", VA = "0x1882D1FC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class FFMMIHHIIDC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public GOACFBMGBPP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public bool handleShowGiftPackage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public bool shouldConsumeGiftBoxImmediately;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public FFMMIHHIIDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x82CDA60", Offset = "0x82CC260", VA = "0x1882CDA60")]
		internal void BNAAAPJGGHN(BalanceUpdateResponseDTO<DEHHLKOFBNB> result)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct JBDLLJKAKPK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public AsyncTaskMethodBuilder<List<FMGFJMMDKNG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public IReadOnlyList<Guid> itemIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public GOACFBMGBPP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private TaskAwaiter<List<AMOFOKFIPOB>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x82D1680", Offset = "0x82CFE80", VA = "0x1882D1680", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x82D1A70", Offset = "0x82D0270", VA = "0x1882D1A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct NKOEDJKNJKJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public List<CPKMEDMFFBO> storeItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public GOACFBMGBPP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private int <attemptNumber>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x82D52E0", Offset = "0x82D3AE0", VA = "0x1882D52E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x82D57D0", Offset = "0x82D3FD0", VA = "0x1882D57D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly BECLBAKAPOB<Guid, FMGFJMMDKNG> DDOJPHANEMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private IOLAPEOHCCL MCDMGKHLNON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private HGFLDAPNKJG GEBIBMNHJHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private NNIMGBPGDIF CPOJFCFCEPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private IFEJMNCJPLP AKPFMKNAJCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private HBHFGIBIHMH NFDMAMAOHAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private MKLIBFLPPKJ ANGPHDLCABJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal KIIGOKDGLEA<Guid, FMGFJMMDKNG> GMOHPEGIFJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private bool IHDAJILAEEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private Task OCGFPLEBBMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private CancellationTokenSource NOFAMKLONKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private List<KJNLAEJHIKH> AODFANDNODP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private EPMINODABBD? HPJECNDJNJH;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static JEHBLHCOCBF GHLJPPEGBLN;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private List<KJNLAEJHIKH> GKNCCNCCNHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x82CFF30", Offset = "0x82CE730", VA = "0x1882CFF30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private EPMINODABBD JIFGAKKIKNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x82D0440", Offset = "0x82CEC40", VA = "0x1882D0440")]
		get
		{
			return default(EPMINODABBD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static JEHBLHCOCBF DJLOIKDDKCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x82D0F90", Offset = "0x82CF790", VA = "0x1882D0F90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x82CF400", Offset = "0x82CDC00", VA = "0x1882CF400")]
	private List<KJNLAEJHIKH> HDDOEAHFKOJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x82CDAA0", Offset = "0x82CC2A0", VA = "0x1882CDAA0")]
	[PJMOOJOMMCC.IIIJEBEMPMI.HIHGDIHOODG]
	internal static void ADFMLLHPKEO(HHDGAAFLDEF PMKEELMHMLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x82D1180", Offset = "0x82CF980", VA = "0x1882D1180")]
	[RecRoom.NoEngine.Common.Preserve]
	public GOACFBMGBPP([LDAFGEHKDJK(null)] NNIMGBPGDIF CPOJFCFCEPM, [LDAFGEHKDJK(null)] IOLAPEOHCCL MCDMGKHLNON, [LDAFGEHKDJK(null)] HGFLDAPNKJG GEBIBMNHJHD, [LDAFGEHKDJK(null)] IFEJMNCJPLP AKPFMKNAJCO, [LDAFGEHKDJK(null)] HBHFGIBIHMH NFDMAMAOHAC, [LDAFGEHKDJK(null)] MKLIBFLPPKJ ANGPHDLCABJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x82CF310", Offset = "0x82CDB10", VA = "0x1882CF310", Slot = "1")]
	~GOACFBMGBPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x82CED40", Offset = "0x82CD540", VA = "0x1882CED40", Slot = "13")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x82CDC50", Offset = "0x82CC450", VA = "0x1882CDC50")]
	[AsyncStateMachine(typeof(LIMNCFJIEFF))]
	private Task AHNBKHLIPEA(CancellationToken DNHBNMHIDAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x82CF1D0", Offset = "0x82CD9D0", VA = "0x1882CF1D0")]
	public void FGHJNFHJEAP(Guid PJFNCPIJCFE, FMGFJMMDKNG OKPDLCKNHLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x82D0210", Offset = "0x82CEA10", VA = "0x1882D0210", Slot = "14")]
	public void NFJLEJPGFFK(CPKMEDMFFBO KEPCINOIHOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x82CEDB0", Offset = "0x82CD5B0", VA = "0x1882CEDB0", Slot = "4")]
	public void EMJJCNJGJNC(IEnumerable<CPKMEDMFFBO> CGMOJFKNEAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x82CF8D0", Offset = "0x82CE0D0", VA = "0x1882CF8D0", Slot = "15")]
	public FMGFJMMDKNG KHALOILEKJC(Guid KAAGPNJIINH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x82CF6D0", Offset = "0x82CDED0", VA = "0x1882CF6D0", Slot = "5")]
	public FMGFJMMDKNG KHALOILEKJC(CPKMEDMFFBO KEPCINOIHOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x82CDB40", Offset = "0x82CC340", VA = "0x1882CDB40", Slot = "16")]
	[AsyncStateMachine(typeof(LLCEEOPCPPH))]
	public Task<FMGFJMMDKNG> ADMPPCDOJAI(Guid KAAGPNJIINH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x82CFCC0", Offset = "0x82CE4C0", VA = "0x1882CFCC0", Slot = "7")]
	[AsyncStateMachine(typeof(MIKGBJPBKID))]
	public Task<List<CPKMEDMFFBO>> LDKGEJHAIIL(string EAOLGCJOBCB, bool? CEBIBFKJLEG, bool? JLKHFAKNIDK, IEnumerable<int> MFGMADBFBOK, bool IDLBNCDLLEK, bool LIBMHHPPFPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x82CF9D0", Offset = "0x82CE1D0", VA = "0x1882CF9D0", Slot = "6")]
	public CPKMEDMFFBO KLGGPACOECJ(BNHEKEPANBN PJFNCPIJCFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x82D0E50", Offset = "0x82CF650", VA = "0x1882D0E50", Slot = "8")]
	[AsyncStateMachine(typeof(AMIPILAADIE))]
	public Task<List<CPKMEDMFFBO>> OEBABCLJIGG(IReadOnlyList<BNHEKEPANBN> FBFAOLJBCDC, bool MCJBCENKDGF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x82CFE20", Offset = "0x82CE620", VA = "0x1882CFE20")]
	[AsyncStateMachine(typeof(DMOOGBNAJDI))]
	private Task<List<ACFMHBIMNNI>> MDGCJGOOPFO(List<ACFMHBIMNNI> GHKFMKIMMNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x82CE220", Offset = "0x82CCA20", VA = "0x1882CE220")]
	private List<CPKMEDMFFBO> CCAELIKIIFB(IReadOnlyList<BNHEKEPANBN> APMNADPAPEB, IReadOnlyList<KJNLAEJHIKH> KNAAHFGGPHN, IReadOnlyList<CPKMEDMFFBO> GHKFMKIMMNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x82CEF70", Offset = "0x82CD770", VA = "0x1882CEF70", Slot = "9")]
	public KJPDFMLMKLI<BalanceUpdateResponseDTO<DEHHLKOFBNB>> FALJGKBGBNM(Guid KAAGPNJIINH, long NNJMLCCPAMG, GiftItemDTO DNFCMOGKFGA, FIEOJKLGOND NEJHFIOGEEJ = FIEOJKLGOND.RecCenterTokens, [Optional] long? EAONCAHKMKB, JDGPNLOGLBE KOMCFMMPJNL = JDGPNLOGLBE.None)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x82CF570", Offset = "0x82CDD70", VA = "0x1882CF570")]
	[AsyncStateMachine(typeof(LCCNANILPEA))]
	private Task<MLGCIODNMCL<BalanceUpdateResponseDTO<DEHHLKOFBNB>>> HFCNHGDOGFP(Guid KAAGPNJIINH, long NNJMLCCPAMG, GiftItemDTO DNFCMOGKFGA, FIEOJKLGOND NEJHFIOGEEJ = FIEOJKLGOND.RecCenterTokens, [Optional] long? EAONCAHKMKB, JDGPNLOGLBE KOMCFMMPJNL = JDGPNLOGLBE.None)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x82CEAE0", Offset = "0x82CD2E0", VA = "0x1882CEAE0", Slot = "10")]
	public KJPDFMLMKLI<BalanceUpdateResponseDTO<DEHHLKOFBNB>> DLBLDCHAONK(JDGPNLOGLBE KOMCFMMPJNL, FIEOJKLGOND NEJHFIOGEEJ, int IECNOABADIC, long NNJMLCCPAMG, long? EAONCAHKMKB, int GFCKEFAGOCA, bool KJIJLEMBJLF = false, bool FOGNBGBCAAI = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x82CDD40", Offset = "0x82CC540", VA = "0x1882CDD40", Slot = "11")]
	public KJPDFMLMKLI<BalanceUpdateResponseDTO<DEHHLKOFBNB>> BPGHBGMAFBI(JDGPNLOGLBE KOMCFMMPJNL, FIEOJKLGOND NEJHFIOGEEJ, int IECNOABADIC, long NNJMLCCPAMG, long? EAONCAHKMKB, IReadOnlyCollection<int> AKFCHAGLKKD, string NJAAPDELBNN, bool BMCKDIPEEFA, AKGOFIOCCAL AEPJNOOFHEK, int GFCKEFAGOCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x82D0970", Offset = "0x82CF170", VA = "0x1882D0970", Slot = "12")]
	public KJPDFMLMKLI<BalanceUpdateResponseDTO<DEHHLKOFBNB>> OBLLFAFLCHO(JDGPNLOGLBE KOMCFMMPJNL, FIEOJKLGOND NEJHFIOGEEJ, IReadOnlyList<int> EIOKGJMLMAE, IReadOnlyList<long> ENFDLFCLLKG, long? EAONCAHKMKB, int NFLOJKBINAD, string NJAAPDELBNN, bool BMCKDIPEEFA, AKGOFIOCCAL AEPJNOOFHEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x82D00D0", Offset = "0x82CE8D0", VA = "0x1882D00D0")]
	[AsyncStateMachine(typeof(JBDLLJKAKPK))]
	private Task<List<FMGFJMMDKNG>> NFCBDNOMEKP(IReadOnlyList<Guid> FNPNKLHNPFH, CancellationToken DNHBNMHIDAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x82D0660", Offset = "0x82CEE60", VA = "0x1882D0660")]
	private void OAAHJKIDBGK(BalanceUpdateResponseDTO<DEHHLKOFBNB> DIHOEBLBNKE, bool KGMOMHNLEEP, bool FOGNBGBCAAI, bool KJIJLEMBJLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x82CE870", Offset = "0x82CD070", VA = "0x1882CE870")]
	private void DKKEKHEADFB(DCIOEOOBAMK FECKFIDGPEK, bool LMOABPOHOCA, bool JMNGEOPIAMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x82D1080", Offset = "0x82CF880", VA = "0x1882D1080")]
	[AsyncStateMachine(typeof(NKOEDJKNJKJ))]
	private Task PGLJPJEKEAN(List<CPKMEDMFFBO> CGMOJFKNEAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x82CE840", Offset = "0x82CD040", VA = "0x1882CE840")]
	[CompilerGenerated]
	private void CMOPANGNPDE(BalanceUpdateResponseDTO<DEHHLKOFBNB> HLPIAOANGMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x82CE840", Offset = "0x82CD040", VA = "0x1882CE840")]
	[CompilerGenerated]
	private void NDAEBHDBLAI(BalanceUpdateResponseDTO<DEHHLKOFBNB> HLPIAOANGMD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class LHBMAFLCGLP : IDKDFHNCIKA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly HBHFGIBIHMH CEIIMLIODAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly GBJPDBLPGFK FGJGINOIFHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly FKBNDNINJIB LBEPCHFDAEA;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x82D28F0", Offset = "0x82D10F0", VA = "0x1882D28F0")]
	[PJMOOJOMMCC.IIIJEBEMPMI.HIHGDIHOODG]
	internal static void FGFPGKKONLH(HHDGAAFLDEF PMKEELMHMLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0xC2FD30", Offset = "0xC2E530", VA = "0x180C2FD30")]
	[RecRoom.NoEngine.Common.Preserve]
	public LHBMAFLCGLP([LDAFGEHKDJK(null)] HBHFGIBIHMH NFDMAMAOHAC, [LDAFGEHKDJK(null)] GBJPDBLPGFK DECJJILFAAA, [LDAFGEHKDJK(null)] FKBNDNINJIB GHKFMKIMMNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x82D3280", Offset = "0x82D1A80", VA = "0x1882D3280")]
	private bool JBODMEFBOPH(EFGNMLJHBNJ FMMGGIGDDKD, EFGNMLJHBNJ JGOMIAPAHFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x82D2110", Offset = "0x82D0910", VA = "0x1882D2110", Slot = "5")]
	public IReadOnlyList<CPKMEDMFFBO> CGBLCDIJJEJ(EFGNMLJHBNJ FBOIBMKLBAD, IReadOnlyList<CPKMEDMFFBO> ECFHLCJLIHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x82D37A0", Offset = "0x82D1FA0", VA = "0x1882D37A0", Slot = "4")]
	public bool OHCNGJCFODH(EFGNMLJHBNJ FBOIBMKLBAD, CPKMEDMFFBO BLFLGKHLJNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x82D2C50", Offset = "0x82D1450", VA = "0x1882D2C50")]
	private bool HGPIFAFKILN(EFGNMLJHBNJ FBOIBMKLBAD, CPKMEDMFFBO BLFLGKHLJNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x82D2D50", Offset = "0x82D1550", VA = "0x1882D2D50")]
	private bool IADMLNMKOAL(EFGNMLJHBNJ FBOIBMKLBAD, CPKMEDMFFBO BLFLGKHLJNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x82D2A80", Offset = "0x82D1280", VA = "0x1882D2A80")]
	private bool GHHMBCDPKAM(EFGNMLJHBNJ FBOIBMKLBAD, CPKMEDMFFBO BLFLGKHLJNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x82D26A0", Offset = "0x82D0EA0", VA = "0x1882D26A0")]
	public bool ENAIAJEEINB(CPKMEDMFFBO KEPCINOIHOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x82D25D0", Offset = "0x82D0DD0", VA = "0x1882D25D0")]
	public bool ENAIAJEEINB(MMGOMNCCKOC LMGNCCMHOHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x82D3170", Offset = "0x82D1970", VA = "0x1882D3170")]
	private bool IHBKAFOMDFO(Guid KAAGPNJIINH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x82D33C0", Offset = "0x82D1BC0", VA = "0x1882D33C0")]
	private bool KHJGAHFOKBO(EFGNMLJHBNJ FBOIBMKLBAD, CPKMEDMFFBO BLFLGKHLJNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x82D2360", Offset = "0x82D0B60", VA = "0x1882D2360")]
	private bool CMOPKAAOLOI(EFGNMLJHBNJ FBOIBMKLBAD, CPKMEDMFFBO BLFLGKHLJNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x82D2560", Offset = "0x82D0D60", VA = "0x1882D2560")]
	private bool ELFJPIALDAK(EFGNMLJHBNJ FBOIBMKLBAD, CPKMEDMFFBO BLFLGKHLJNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x82D36A0", Offset = "0x82D1EA0", VA = "0x1882D36A0")]
	private bool OCADDDMDAJG(EFGNMLJHBNJ FBOIBMKLBAD, CPKMEDMFFBO BLFLGKHLJNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x82D2030", Offset = "0x82D0830", VA = "0x1882D2030")]
	private bool ABAOHEKIHAO(EFGNMLJHBNJ FBOIBMKLBAD, CPKMEDMFFBO BLFLGKHLJNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x82D2CE0", Offset = "0x82D14E0", VA = "0x1882D2CE0")]
	private bool HMCEDLIAIKG(EFGNMLJHBNJ FBOIBMKLBAD, CPKMEDMFFBO BLFLGKHLJNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x82D3480", Offset = "0x82D1C80", VA = "0x1882D3480")]
	private bool LOJHFGKHHGA(EFGNMLJHBNJ FBOIBMKLBAD, CPKMEDMFFBO BLFLGKHLJNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x82D4300", Offset = "0x82D2B00", VA = "0x1882D4300")]
	private bool OJICIPJJFKD(EFGNMLJHBNJ FBOIBMKLBAD, CPKMEDMFFBO BLFLGKHLJNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x82D3290", Offset = "0x82D1A90", VA = "0x1882D3290")]
	private bool JFACJJOBMPO(EFGNMLJHBNJ FBOIBMKLBAD, CPKMEDMFFBO BLFLGKHLJNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x82D30E0", Offset = "0x82D18E0", VA = "0x1882D30E0")]
	private bool IGOODDKJHOJ(EFGNMLJHBNJ FBOIBMKLBAD, CPKMEDMFFBO BLFLGKHLJNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x82D3610", Offset = "0x82D1E10", VA = "0x1882D3610")]
	private bool NIBFAJCCNDC(EFGNMLJHBNJ FBOIBMKLBAD, CPKMEDMFFBO BLFLGKHLJNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x82D3710", Offset = "0x82D1F10", VA = "0x1882D3710")]
	private bool OGIPACEPBKP(EFGNMLJHBNJ FBOIBMKLBAD, CPKMEDMFFBO BLFLGKHLJNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x82D2440", Offset = "0x82D0C40", VA = "0x1882D2440")]
	private bool EENKHBLABPG(EFGNMLJHBNJ FBOIBMKLBAD, CPKMEDMFFBO BLFLGKHLJNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x82D24D0", Offset = "0x82D0CD0", VA = "0x1882D24D0")]
	private bool ELENPGHPKBK(EFGNMLJHBNJ FBOIBMKLBAD, CPKMEDMFFBO BLFLGKHLJNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x82D2960", Offset = "0x82D1160", VA = "0x1882D2960")]
	private bool GBHOHOAKFIA(EFGNMLJHBNJ FBOIBMKLBAD, CPKMEDMFFBO BLFLGKHLJNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x82D3050", Offset = "0x82D1850", VA = "0x1882D3050")]
	private bool ICEEOOLDDNK(EFGNMLJHBNJ FBOIBMKLBAD, CPKMEDMFFBO BLFLGKHLJNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x82D33F0", Offset = "0x82D1BF0", VA = "0x1882D33F0")]
	private bool LNEIKLMOOPD(EFGNMLJHBNJ FBOIBMKLBAD, CPKMEDMFFBO BLFLGKHLJNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x82D4390", Offset = "0x82D2B90", VA = "0x1882D4390")]
	private bool PDACFIPPFGL(EFGNMLJHBNJ FBOIBMKLBAD, CPKMEDMFFBO BLFLGKHLJNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x82D31F0", Offset = "0x82D19F0", VA = "0x1882D31F0")]
	private bool IHDIHOHNPMK(EFGNMLJHBNJ FBOIBMKLBAD, CPKMEDMFFBO BLFLGKHLJNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x82D3580", Offset = "0x82D1D80", VA = "0x1882D3580")]
	private bool NHNJBFGGLDJ(EFGNMLJHBNJ FBOIBMKLBAD, CPKMEDMFFBO BLFLGKHLJNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x82D2380", Offset = "0x82D0B80", VA = "0x1882D2380")]
	private bool DNOPNGIEGAM(EFGNMLJHBNJ FBOIBMKLBAD, CPKMEDMFFBO BLFLGKHLJNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x82D2AF0", Offset = "0x82D12F0", VA = "0x1882D2AF0")]
	private bool GHNOJHLHBDL(EFGNMLJHBNJ FBOIBMKLBAD, CPKMEDMFFBO BLFLGKHLJNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x82D34F0", Offset = "0x82D1CF0", VA = "0x1882D34F0")]
	private bool NDPFPGLCCJD(EFGNMLJHBNJ FBOIBMKLBAD, CPKMEDMFFBO BLFLGKHLJNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x82D20A0", Offset = "0x82D08A0", VA = "0x1882D20A0")]
	private bool CAFPJFNIOEE(EFGNMLJHBNJ FBOIBMKLBAD, CPKMEDMFFBO BLFLGKHLJNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x82D29F0", Offset = "0x82D11F0", VA = "0x1882D29F0")]
	private bool GDCMPFCBIAB(EFGNMLJHBNJ FBOIBMKLBAD, CPKMEDMFFBO BLFLGKHLJNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x82D2BC0", Offset = "0x82D13C0", VA = "0x1882D2BC0")]
	private bool HALMIBAPGGP(EFGNMLJHBNJ FBOIBMKLBAD, CPKMEDMFFBO BLFLGKHLJNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x82D3350", Offset = "0x82D1B50", VA = "0x1882D3350")]
	private bool KABJOEBNCNJ(EFGNMLJHBNJ FBOIBMKLBAD, CPKMEDMFFBO BLFLGKHLJNB)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class AICHEIEOLIK
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public AICHEIEOLIK()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
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
