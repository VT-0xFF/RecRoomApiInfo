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
		[Cpp2IlInjected.Address(RVA = "0x7BEFAF0", Offset = "0x7BEEEF0", VA = "0x187BEFAF0", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x7BEE810", Offset = "0x7BEDC10", VA = "0x187BEE810", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7BEEB10", Offset = "0x7BEDF10", VA = "0x187BEEB10", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7BE9C70", Offset = "0x7BE9070", VA = "0x187BE9C70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7BE9F80", Offset = "0x7BE9380", VA = "0x187BE9F80", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7BEF120", Offset = "0x7BEE520", VA = "0x187BEF120", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7BEF8D0", Offset = "0x7BEECD0", VA = "0x187BEF8D0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7BE91F0", Offset = "0x7BE85F0", VA = "0x187BE91F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7BE9AC0", Offset = "0x7BE8EC0", VA = "0x187BE9AC0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7BEEBB0", Offset = "0x7BEDFB0", VA = "0x187BEEBB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7BEF0B0", Offset = "0x7BEE4B0", VA = "0x187BEF0B0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7BE9BF0", Offset = "0x7BE8FF0", VA = "0x187BE9BF0")]
		internal bool DNKNBEBKBHB(BEIGBIHPIEI x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7BE9B30", Offset = "0x7BE8F30", VA = "0x187BE9B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x7BEE7C0", Offset = "0x7BEDBC0", VA = "0x187BEE7C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7BE9C30", Offset = "0x7BE9030", VA = "0x187BE9C30")]
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
		[Cpp2IlInjected.Address(RVA = "0x7BEA470", Offset = "0x7BE9870", VA = "0x187BEA470", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7BEA950", Offset = "0x7BE9D50", VA = "0x187BEA950", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7BEEB70", Offset = "0x7BEDF70", VA = "0x187BEEB70")]
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
		[Cpp2IlInjected.Address(RVA = "0x7BE9FF0", Offset = "0x7BE93F0", VA = "0x187BE9FF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7BEA400", Offset = "0x7BE9800", VA = "0x187BEA400", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7BEA9C0", Offset = "0x7BE9DC0", VA = "0x187BEA9C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7BEAE80", Offset = "0x7BEA280", VA = "0x187BEAE80", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7BEC850", Offset = "0x7BEBC50", VA = "0x187BEC850")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private OPFPMKKDLIE COAENMFFHJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7BEC3D0", Offset = "0x7BEB7D0", VA = "0x187BEC3D0")]
		get
		{
			return default(OPFPMKKDLIE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static FLEGLJCJMGB IMFIEPMCPDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7BED310", Offset = "0x7BEC710", VA = "0x187BED310")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7BEC6E0", Offset = "0x7BEBAE0", VA = "0x187BEC6E0")]
	private List<BEIGBIHPIEI> GNAAPNDPKOF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7BEB120", Offset = "0x7BEA520", VA = "0x187BEB120")]
	[HLOHOCOKELO.CMBCHPAFDOL.DIAIOJMELDA]
	internal static void APJICGAGHJP(GFKEMDIOCPC MGOKPJKELJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7BEE340", Offset = "0x7BED740", VA = "0x187BEE340")]
	[RecRoom.NoEngine.Common.Preserve]
	public NLDFCHNCLFE([IBJCGEMJMJL(null)] KLHECNJFMMO AOMNFIDCDEK, [IBJCGEMJMJL(null)] OKEMOHPNDNB DCEMBCAMKNJ, [IBJCGEMJMJL(null)] EKHKHBHDDIK MIJAIAOJKJK, [IBJCGEMJMJL(null)] KOFIPGLIJKN OONKFKAIMJL, [IBJCGEMJMJL(null)] NBLGDMHJAEN PDLAIAJBAKN, [IBJCGEMJMJL(null)] CHDNBFGGGBI DIKLELHCODJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7BEC1D0", Offset = "0x7BEB5D0", VA = "0x187BEC1D0", Slot = "1")]
	~NLDFCHNCLFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7BEC160", Offset = "0x7BEB560", VA = "0x187BEC160", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7BEC5F0", Offset = "0x7BEB9F0", VA = "0x187BEC5F0")]
	[AsyncStateMachine(typeof(NNMMEFBLDBG))]
	private Task GJOFILIDMPK(CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7BEB0A0", Offset = "0x7BEA4A0", VA = "0x187BEB0A0")]
	public void AODCLMLGBBG(Guid GOBDDMLNCNK, KOPMHHENCNP BFEIEHGLKKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7BEB770", Offset = "0x7BEAB70", VA = "0x187BEB770", Slot = "13")]
	public void DIKDBCJEBBD(MOBJPBHHADI IMBPCMFEPCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7BEAEE0", Offset = "0x7BEA2E0", VA = "0x187BEAEE0", Slot = "4")]
	public void ACIMKIMDIHE(IEnumerable<MOBJPBHHADI> PHPLCLJIOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7BEDD60", Offset = "0x7BED160", VA = "0x187BEDD60", Slot = "14")]
	public KOPMHHENCNP NKNPEMGBLFF(Guid PJNPLPPKBKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7BEDB50", Offset = "0x7BECF50", VA = "0x187BEDB50", Slot = "5")]
	public KOPMHHENCNP NKNPEMGBLFF(MOBJPBHHADI IMBPCMFEPCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7BECD90", Offset = "0x7BEC190", VA = "0x187BECD90", Slot = "15")]
	[AsyncStateMachine(typeof(LKAKEEKEKNE))]
	public Task<KOPMHHENCNP> KAONOGIPAAB(Guid PJNPLPPKBKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7BECEA0", Offset = "0x7BEC2A0", VA = "0x187BECEA0", Slot = "6")]
	[AsyncStateMachine(typeof(OMCFOABGJBK))]
	public Task<List<MOBJPBHHADI>> KGCJGKPJNDG(string LMEMKNINDBF, bool? EMEKHBMBEEI, bool? FKCHMMOCIFN, IEnumerable<int> DLGIBNMNPCG, bool MGFBOHDDNJH, bool PMFKMGIBOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7BEC040", Offset = "0x7BEB440", VA = "0x187BEC040", Slot = "7")]
	[AsyncStateMachine(typeof(ANNGAHOPDML))]
	public Task<List<MOBJPBHHADI>> DOEDNOKBDGB(IReadOnlyList<JEJKIPMLEEI> KKGLPNLEJJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7BEC2C0", Offset = "0x7BEB6C0", VA = "0x187BEC2C0")]
	[AsyncStateMachine(typeof(OKMNPCHGDMA))]
	private Task<List<HKAOEDINFKI>> GJDDGALMAFA(List<HKAOEDINFKI> NOFLCGFLKMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7BEBA20", Offset = "0x7BEAE20", VA = "0x187BEBA20")]
	private List<MOBJPBHHADI> DLLPLKBBNKG(IReadOnlyList<JEJKIPMLEEI> CMKFKBEIKJD, IReadOnlyList<BEIGBIHPIEI> GGEOBPMIEEB, IReadOnlyList<MOBJPBHHADI> NOFLCGFLKMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7BEC9F0", Offset = "0x7BEBDF0", VA = "0x187BEC9F0", Slot = "8")]
	public NEEPBAPEEOL<BalanceUpdateResponseDTO<JJFOMBGHIEB>> HNAKMCALHDP(Guid PJNPLPPKBKJ, long ODPGPODGLMG, GiftItemDTO KFPKCKNBPOD, FBCPBGGDIHI EJGELNCAGAO = FBCPBGGDIHI.RecCenterTokens, [Optional] long? PJOEJJABEEO, JDDLHNCCFFA FDOLPPAKHDB = JDDLHNCCFFA.None)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7BED410", Offset = "0x7BEC810", VA = "0x187BED410")]
	[AsyncStateMachine(typeof(MOPDHDDJFMH))]
	private Task<GGMEEPGDLCG<BalanceUpdateResponseDTO<JJFOMBGHIEB>>> MOKOMFFMPEP(Guid PJNPLPPKBKJ, long ODPGPODGLMG, GiftItemDTO KFPKCKNBPOD, FBCPBGGDIHI EJGELNCAGAO = FBCPBGGDIHI.RecCenterTokens, [Optional] long? PJOEJJABEEO, JDDLHNCCFFA FDOLPPAKHDB = JDDLHNCCFFA.None)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7BEE0E0", Offset = "0x7BED4E0", VA = "0x187BEE0E0", Slot = "9")]
	public NEEPBAPEEOL<BalanceUpdateResponseDTO<JJFOMBGHIEB>> PHAKMOLGGDP(JDDLHNCCFFA FDOLPPAKHDB, FBCPBGGDIHI EJGELNCAGAO, int KHDGPOHCJFA, long ODPGPODGLMG, long? PJOEJJABEEO, int ANFKLMBEEDK, bool FLIDAPCKHGP = false, bool OJMMABDPBFM = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7BEB260", Offset = "0x7BEA660", VA = "0x187BEB260", Slot = "10")]
	public NEEPBAPEEOL<BalanceUpdateResponseDTO<JJFOMBGHIEB>> BEDEEHOGJBG(JDDLHNCCFFA FDOLPPAKHDB, FBCPBGGDIHI EJGELNCAGAO, int KHDGPOHCJFA, long ODPGPODGLMG, long? PJOEJJABEEO, IReadOnlyCollection<int> CPCFIPMJOCL, string MIALAMIFNLM, bool HLCCAFKJBCH, MGINFBHLBGH OIBHDJGFPKM, int ANFKLMBEEDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7BED670", Offset = "0x7BECA70", VA = "0x187BED670", Slot = "11")]
	public NEEPBAPEEOL<BalanceUpdateResponseDTO<JJFOMBGHIEB>> NCAFNNMLGGH(JDDLHNCCFFA FDOLPPAKHDB, FBCPBGGDIHI EJGELNCAGAO, IReadOnlyList<int> MODGKGPDPEJ, IReadOnlyList<long> JOKHJHLBJDD, long? PJOEJJABEEO, int BBPIIHOGLAJ, string MIALAMIFNLM, bool HLCCAFKJBCH, MGINFBHLBGH OIBHDJGFPKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7BECC50", Offset = "0x7BEC050", VA = "0x187BECC50")]
	[AsyncStateMachine(typeof(LNOCHOCCDEN))]
	private Task<List<KOPMHHENCNP>> JNJFJKIHIEF(IReadOnlyList<Guid> PDALGOKECBO, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7BED000", Offset = "0x7BEC400", VA = "0x187BED000")]
	private void LAMEIIIEOPB(BalanceUpdateResponseDTO<JJFOMBGHIEB> GIBMLNMIEIO, bool CGPFEOOIGAC, bool OJMMABDPBFM, bool FLIDAPCKHGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7BEDE70", Offset = "0x7BED270", VA = "0x187BEDE70")]
	private void OANDNDKKNOG(MNEFDGDOLIH HGIPNEPCOAD, bool HJDLJNHEFCO, bool GPIJNBINCFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7BED570", Offset = "0x7BEC970", VA = "0x187BED570")]
	[AsyncStateMachine(typeof(NJCCFJPJCKF))]
	private Task MPGPKLCPIFO(List<MOBJPBHHADI> PHPLCLJIOHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7BEB740", Offset = "0x7BEAB40", VA = "0x187BEB740")]
	[CompilerGenerated]
	private void EEOLNBJDFAD(BalanceUpdateResponseDTO<JJFOMBGHIEB> BIEIOPPGBOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7BEB740", Offset = "0x7BEAB40", VA = "0x187BEB740")]
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
