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
		[Cpp2IlInjected.Address(RVA = "0x7BEFB40", Offset = "0x7BEEF40", VA = "0x187BEFB40", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x242AF30", Offset = "0x242A330", VA = "0x18242AF30")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class NLDFCHNCLFE : FLEGLJCJMGB, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private struct NNMMEFBLDBG : IAsyncStateMachine
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
		public NLDFCHNCLFE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7BEE860", Offset = "0x7BEDC60", VA = "0x187BEE860", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7BEEB60", Offset = "0x7BEDF60", VA = "0x187BEEB60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private struct LKAKEEKEKNE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public AsyncTaskMethodBuilder<KOPMHHENCNP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public NLDFCHNCLFE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public Guid customAvatarItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private TaskAwaiter<KOPMHHENCNP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7BE9CC0", Offset = "0x7BE90C0", VA = "0x187BE9CC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7BE9FD0", Offset = "0x7BE93D0", VA = "0x187BE9FD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct OMCFOABGJBK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public AsyncTaskMethodBuilder<List<MOBJPBHHADI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public NLDFCHNCLFE <>4__this;

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
		private List<MOBJPBHHADI> <results>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private TaskAwaiter<List<HKAOEDINFKI>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7BEF170", Offset = "0x7BEE570", VA = "0x187BEF170", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7BEF920", Offset = "0x7BEED20", VA = "0x187BEF920", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct ANNGAHOPDML : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public AsyncTaskMethodBuilder<List<MOBJPBHHADI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public NLDFCHNCLFE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public IReadOnlyList<JEJKIPMLEEI> unifiedItemIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private List<MOBJPBHHADI> <storeItemsInInitialOrder>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private TaskAwaiter<List<HKAOEDINFKI>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7BE9240", Offset = "0x7BE8640", VA = "0x187BE9240", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7BE9B10", Offset = "0x7BE8F10", VA = "0x187BE9B10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct OKMNPCHGDMA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public AsyncTaskMethodBuilder<List<HKAOEDINFKI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public List<HKAOEDINFKI> customAvatarItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public NLDFCHNCLFE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x7BEEC00", Offset = "0x7BEE000", VA = "0x187BEEC00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7BEF100", Offset = "0x7BEE500", VA = "0x187BEF100", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class BNPNCCAGMBC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public JEJKIPMLEEI id;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public BNPNCCAGMBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7BE9C40", Offset = "0x7BE9040", VA = "0x187BE9C40")]
		internal bool DNKNBEBKBHB(BEIGBIHPIEI x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7BE9B80", Offset = "0x7BE8F80", VA = "0x187BE9B80")]
		internal bool BIHOGMOIOAM(MOBJPBHHADI x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class NMDCHFOPMDG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public string itemFriendlyName;

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public NMDCHFOPMDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7BEE810", Offset = "0x7BEDC10", VA = "0x187BEE810")]
		internal object JEIJNHPEIPA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class HEGMACDDJIH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public NLDFCHNCLFE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public GiftItemDTO gift;

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public HEGMACDDJIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7BE9C80", Offset = "0x7BE9080", VA = "0x187BE9C80")]
		internal void EKLEMOMKMGB(BalanceUpdateResponseDTO<JJFOMBGHIEB> result)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct MOPDHDDJFMH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncTaskMethodBuilder<GGMEEPGDLCG<BalanceUpdateResponseDTO<JJFOMBGHIEB>>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public NLDFCHNCLFE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public Guid customAvatarItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public long requestedPrice;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public GiftItemDTO gift;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public long? couponConsumablePlayerMappingId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public JDDLHNCCFFA storefrontType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public FBCPBGGDIHI currencyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private TaskAwaiter<KOPMHHENCNP> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private TaskAwaiter<GGMEEPGDLCG<BalanceUpdateResponseDTO<JJFOMBGHIEB>>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7BEA4C0", Offset = "0x7BE98C0", VA = "0x187BEA4C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7BEA9A0", Offset = "0x7BE9DA0", VA = "0x187BEA9A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class OGNICMNODPE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public NLDFCHNCLFE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public bool handleShowGiftPackage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public bool shouldConsumeGiftBoxImmediately;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public OGNICMNODPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7BEEBC0", Offset = "0x7BEDFC0", VA = "0x187BEEBC0")]
		internal void KJFEKGHBJMD(BalanceUpdateResponseDTO<JJFOMBGHIEB> result)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct LNOCHOCCDEN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public AsyncTaskMethodBuilder<List<KOPMHHENCNP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public IReadOnlyList<Guid> itemIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public NLDFCHNCLFE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private TaskAwaiter<List<JCDIGJCIAND>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x7BEA040", Offset = "0x7BE9440", VA = "0x187BEA040", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7BEA450", Offset = "0x7BE9850", VA = "0x187BEA450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct NJCCFJPJCKF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public List<MOBJPBHHADI> storeItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public NLDFCHNCLFE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private int <attemptNumber>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7BEAA10", Offset = "0x7BE9E10", VA = "0x187BEAA10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7BEAED0", Offset = "0x7BEA2D0", VA = "0x187BEAED0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly DKPIIJOPIDM<Guid, KOPMHHENCNP> HDIMOIKAHOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private OKEMOHPNDNB DCEMBCAMKNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private EKHKHBHDDIK MIJAIAOJKJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private KLHECNJFMMO AOMNFIDCDEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private KOFIPGLIJKN OONKFKAIMJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private NBLGDMHJAEN PDLAIAJBAKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private CHDNBFGGGBI DIKLELHCODJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal HNFGOLPBJLN<Guid, KOPMHHENCNP> OCBFPENONEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private bool NLNPPHMOFNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private Task ECBFIHLBIKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private CancellationTokenSource BEPNNCKNKPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private List<BEIGBIHPIEI> MFIIOHHABMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private OPFPMKKDLIE? AJBKIMBEPKE;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static FLEGLJCJMGB NHILJKJCKFJ;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private List<BEIGBIHPIEI> GPKEAJLODNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7BEC8A0", Offset = "0x7BEBCA0", VA = "0x187BEC8A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private OPFPMKKDLIE COAENMFFHJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7BEC420", Offset = "0x7BEB820", VA = "0x187BEC420")]
		get
		{
			return default(OPFPMKKDLIE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static FLEGLJCJMGB IMFIEPMCPDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7BED360", Offset = "0x7BEC760", VA = "0x187BED360")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7BEC730", Offset = "0x7BEBB30", VA = "0x187BEC730")]
	private List<BEIGBIHPIEI> GNAAPNDPKOF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7BEB170", Offset = "0x7BEA570", VA = "0x187BEB170")]
	[HLOHOCOKELO.CMBCHPAFDOL.DIAIOJMELDA]
	internal static void APJICGAGHJP(GFKEMDIOCPC MGOKPJKELJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7BEE390", Offset = "0x7BED790", VA = "0x187BEE390")]
	[RecRoom.NoEngine.Common.Preserve]
	public NLDFCHNCLFE([IBJCGEMJMJL(null)] KLHECNJFMMO AOMNFIDCDEK, [IBJCGEMJMJL(null)] OKEMOHPNDNB DCEMBCAMKNJ, [IBJCGEMJMJL(null)] EKHKHBHDDIK MIJAIAOJKJK, [IBJCGEMJMJL(null)] KOFIPGLIJKN OONKFKAIMJL, [IBJCGEMJMJL(null)] NBLGDMHJAEN PDLAIAJBAKN, [IBJCGEMJMJL(null)] CHDNBFGGGBI DIKLELHCODJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7BEC220", Offset = "0x7BEB620", VA = "0x187BEC220", Slot = "1")]
	~NLDFCHNCLFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7BEC1B0", Offset = "0x7BEB5B0", VA = "0x187BEC1B0", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7BEC640", Offset = "0x7BEBA40", VA = "0x187BEC640")]
	[AsyncStateMachine(typeof(NNMMEFBLDBG))]
	private Task GJOFILIDMPK(CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7BEB0F0", Offset = "0x7BEA4F0", VA = "0x187BEB0F0")]
	public void AODCLMLGBBG(Guid GOBDDMLNCNK, KOPMHHENCNP BFEIEHGLKKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7BEB7C0", Offset = "0x7BEABC0", VA = "0x187BEB7C0", Slot = "13")]
	public void DIKDBCJEBBD(MOBJPBHHADI IMBPCMFEPCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7BEAF30", Offset = "0x7BEA330", VA = "0x187BEAF30", Slot = "4")]
	public void ACIMKIMDIHE(IEnumerable<MOBJPBHHADI> PHPLCLJIOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7BEDDB0", Offset = "0x7BED1B0", VA = "0x187BEDDB0", Slot = "14")]
	public KOPMHHENCNP NKNPEMGBLFF(Guid PJNPLPPKBKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7BEDBA0", Offset = "0x7BECFA0", VA = "0x187BEDBA0", Slot = "5")]
	public KOPMHHENCNP NKNPEMGBLFF(MOBJPBHHADI IMBPCMFEPCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7BECDE0", Offset = "0x7BEC1E0", VA = "0x187BECDE0", Slot = "15")]
	[AsyncStateMachine(typeof(LKAKEEKEKNE))]
	public Task<KOPMHHENCNP> KAONOGIPAAB(Guid PJNPLPPKBKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7BECEF0", Offset = "0x7BEC2F0", VA = "0x187BECEF0", Slot = "6")]
	[AsyncStateMachine(typeof(OMCFOABGJBK))]
	public Task<List<MOBJPBHHADI>> KGCJGKPJNDG(string LMEMKNINDBF, bool? EMEKHBMBEEI, bool? FKCHMMOCIFN, IEnumerable<int> DLGIBNMNPCG, bool MGFBOHDDNJH, bool PMFKMGIBOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7BEC090", Offset = "0x7BEB490", VA = "0x187BEC090", Slot = "7")]
	[AsyncStateMachine(typeof(ANNGAHOPDML))]
	public Task<List<MOBJPBHHADI>> DOEDNOKBDGB(IReadOnlyList<JEJKIPMLEEI> KKGLPNLEJJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7BEC310", Offset = "0x7BEB710", VA = "0x187BEC310")]
	[AsyncStateMachine(typeof(OKMNPCHGDMA))]
	private Task<List<HKAOEDINFKI>> GJDDGALMAFA(List<HKAOEDINFKI> NOFLCGFLKMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7BEBA70", Offset = "0x7BEAE70", VA = "0x187BEBA70")]
	private List<MOBJPBHHADI> DLLPLKBBNKG(IReadOnlyList<JEJKIPMLEEI> CMKFKBEIKJD, IReadOnlyList<BEIGBIHPIEI> GGEOBPMIEEB, IReadOnlyList<MOBJPBHHADI> NOFLCGFLKMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7BECA40", Offset = "0x7BEBE40", VA = "0x187BECA40", Slot = "8")]
	public NEEPBAPEEOL<BalanceUpdateResponseDTO<JJFOMBGHIEB>> HNAKMCALHDP(Guid PJNPLPPKBKJ, long ODPGPODGLMG, GiftItemDTO KFPKCKNBPOD, FBCPBGGDIHI EJGELNCAGAO = FBCPBGGDIHI.RecCenterTokens, [Optional] long? PJOEJJABEEO, JDDLHNCCFFA FDOLPPAKHDB = JDDLHNCCFFA.None)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7BED460", Offset = "0x7BEC860", VA = "0x187BED460")]
	[AsyncStateMachine(typeof(MOPDHDDJFMH))]
	private Task<GGMEEPGDLCG<BalanceUpdateResponseDTO<JJFOMBGHIEB>>> MOKOMFFMPEP(Guid PJNPLPPKBKJ, long ODPGPODGLMG, GiftItemDTO KFPKCKNBPOD, FBCPBGGDIHI EJGELNCAGAO = FBCPBGGDIHI.RecCenterTokens, [Optional] long? PJOEJJABEEO, JDDLHNCCFFA FDOLPPAKHDB = JDDLHNCCFFA.None)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7BEE130", Offset = "0x7BED530", VA = "0x187BEE130", Slot = "9")]
	public NEEPBAPEEOL<BalanceUpdateResponseDTO<JJFOMBGHIEB>> PHAKMOLGGDP(JDDLHNCCFFA FDOLPPAKHDB, FBCPBGGDIHI EJGELNCAGAO, int KHDGPOHCJFA, long ODPGPODGLMG, long? PJOEJJABEEO, int ANFKLMBEEDK, bool FLIDAPCKHGP = false, bool OJMMABDPBFM = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7BEB2B0", Offset = "0x7BEA6B0", VA = "0x187BEB2B0", Slot = "10")]
	public NEEPBAPEEOL<BalanceUpdateResponseDTO<JJFOMBGHIEB>> BEDEEHOGJBG(JDDLHNCCFFA FDOLPPAKHDB, FBCPBGGDIHI EJGELNCAGAO, int KHDGPOHCJFA, long ODPGPODGLMG, long? PJOEJJABEEO, IReadOnlyCollection<int> CPCFIPMJOCL, string MIALAMIFNLM, bool HLCCAFKJBCH, MGINFBHLBGH OIBHDJGFPKM, int ANFKLMBEEDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7BED6C0", Offset = "0x7BECAC0", VA = "0x187BED6C0", Slot = "11")]
	public NEEPBAPEEOL<BalanceUpdateResponseDTO<JJFOMBGHIEB>> NCAFNNMLGGH(JDDLHNCCFFA FDOLPPAKHDB, FBCPBGGDIHI EJGELNCAGAO, IReadOnlyList<int> MODGKGPDPEJ, IReadOnlyList<long> JOKHJHLBJDD, long? PJOEJJABEEO, int BBPIIHOGLAJ, string MIALAMIFNLM, bool HLCCAFKJBCH, MGINFBHLBGH OIBHDJGFPKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7BECCA0", Offset = "0x7BEC0A0", VA = "0x187BECCA0")]
	[AsyncStateMachine(typeof(LNOCHOCCDEN))]
	private Task<List<KOPMHHENCNP>> JNJFJKIHIEF(IReadOnlyList<Guid> PDALGOKECBO, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7BED050", Offset = "0x7BEC450", VA = "0x187BED050")]
	private void LAMEIIIEOPB(BalanceUpdateResponseDTO<JJFOMBGHIEB> GIBMLNMIEIO, bool CGPFEOOIGAC, bool OJMMABDPBFM, bool FLIDAPCKHGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7BEDEC0", Offset = "0x7BED2C0", VA = "0x187BEDEC0")]
	private void OANDNDKKNOG(MNEFDGDOLIH HGIPNEPCOAD, bool HJDLJNHEFCO, bool GPIJNBINCFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7BED5C0", Offset = "0x7BEC9C0", VA = "0x187BED5C0")]
	[AsyncStateMachine(typeof(NJCCFJPJCKF))]
	private Task MPGPKLCPIFO(List<MOBJPBHHADI> PHPLCLJIOHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7BEB790", Offset = "0x7BEAB90", VA = "0x187BEB790")]
	[CompilerGenerated]
	private void EEOLNBJDFAD(BalanceUpdateResponseDTO<JJFOMBGHIEB> BIEIOPPGBOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7BEB790", Offset = "0x7BEAB90", VA = "0x187BEB790")]
	[CompilerGenerated]
	private void DGGHLCDLOCD(BalanceUpdateResponseDTO<JJFOMBGHIEB> BIEIOPPGBOB)
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class OKEBKGOCPLK
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
	public OKEBKGOCPLK()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
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
