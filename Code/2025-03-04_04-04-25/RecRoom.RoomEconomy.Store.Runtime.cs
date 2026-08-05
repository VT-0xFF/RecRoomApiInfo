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
		[Cpp2IlInjected.Address(RVA = "0x7C941D0", Offset = "0x7C927D0", VA = "0x187C941D0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x245DCB0", Offset = "0x245C2B0", VA = "0x18245DCB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C92EF0", Offset = "0x7C914F0", VA = "0x187C92EF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7C931F0", Offset = "0x7C917F0", VA = "0x187C931F0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C8E350", Offset = "0x7C8C950", VA = "0x187C8E350", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7C8E660", Offset = "0x7C8CC60", VA = "0x187C8E660", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C93800", Offset = "0x7C91E00", VA = "0x187C93800", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7C93FB0", Offset = "0x7C925B0", VA = "0x187C93FB0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C8D8D0", Offset = "0x7C8BED0", VA = "0x187C8D8D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7C8E1A0", Offset = "0x7C8C7A0", VA = "0x187C8E1A0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C93290", Offset = "0x7C91890", VA = "0x187C93290", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7C93790", Offset = "0x7C91D90", VA = "0x187C93790", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public BNPNCCAGMBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7C8E2D0", Offset = "0x7C8C8D0", VA = "0x187C8E2D0")]
		internal bool DNKNBEBKBHB(BEIGBIHPIEI x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7C8E210", Offset = "0x7C8C810", VA = "0x187C8E210")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public NMDCHFOPMDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7C92EA0", Offset = "0x7C914A0", VA = "0x187C92EA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public HEGMACDDJIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7C8E310", Offset = "0x7C8C910", VA = "0x187C8E310")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C8EB50", Offset = "0x7C8D150", VA = "0x187C8EB50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7C8F030", Offset = "0x7C8D630", VA = "0x187C8F030", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public OGNICMNODPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7C93250", Offset = "0x7C91850", VA = "0x187C93250")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C8E6D0", Offset = "0x7C8CCD0", VA = "0x187C8E6D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7C8EAE0", Offset = "0x7C8D0E0", VA = "0x187C8EAE0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C8F0A0", Offset = "0x7C8D6A0", VA = "0x187C8F0A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7C8F560", Offset = "0x7C8DB60", VA = "0x187C8F560", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C90F30", Offset = "0x7C8F530", VA = "0x187C90F30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private OPFPMKKDLIE COAENMFFHJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7C90AB0", Offset = "0x7C8F0B0", VA = "0x187C90AB0")]
		get
		{
			return default(OPFPMKKDLIE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static FLEGLJCJMGB IMFIEPMCPDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7C919F0", Offset = "0x7C8FFF0", VA = "0x187C919F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7C90DC0", Offset = "0x7C8F3C0", VA = "0x187C90DC0")]
	private List<BEIGBIHPIEI> GNAAPNDPKOF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7C8F800", Offset = "0x7C8DE00", VA = "0x187C8F800")]
	[HLOHOCOKELO.CMBCHPAFDOL.DIAIOJMELDA]
	internal static void APJICGAGHJP(GFKEMDIOCPC MGOKPJKELJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7C92A20", Offset = "0x7C91020", VA = "0x187C92A20")]
	[RecRoom.NoEngine.Common.Preserve]
	public NLDFCHNCLFE([IBJCGEMJMJL(null)] KLHECNJFMMO AOMNFIDCDEK, [IBJCGEMJMJL(null)] OKEMOHPNDNB DCEMBCAMKNJ, [IBJCGEMJMJL(null)] EKHKHBHDDIK MIJAIAOJKJK, [IBJCGEMJMJL(null)] KOFIPGLIJKN OONKFKAIMJL, [IBJCGEMJMJL(null)] NBLGDMHJAEN PDLAIAJBAKN, [IBJCGEMJMJL(null)] CHDNBFGGGBI DIKLELHCODJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7C908B0", Offset = "0x7C8EEB0", VA = "0x187C908B0", Slot = "1")]
	~NLDFCHNCLFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7C90840", Offset = "0x7C8EE40", VA = "0x187C90840", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7C90CD0", Offset = "0x7C8F2D0", VA = "0x187C90CD0")]
	[AsyncStateMachine(typeof(NNMMEFBLDBG))]
	private Task GJOFILIDMPK(CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7C8F780", Offset = "0x7C8DD80", VA = "0x187C8F780")]
	public void AODCLMLGBBG(Guid GOBDDMLNCNK, KOPMHHENCNP BFEIEHGLKKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7C8FE50", Offset = "0x7C8E450", VA = "0x187C8FE50", Slot = "13")]
	public void DIKDBCJEBBD(MOBJPBHHADI IMBPCMFEPCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7C8F5C0", Offset = "0x7C8DBC0", VA = "0x187C8F5C0", Slot = "4")]
	public void ACIMKIMDIHE(IEnumerable<MOBJPBHHADI> PHPLCLJIOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7C92440", Offset = "0x7C90A40", VA = "0x187C92440", Slot = "14")]
	public KOPMHHENCNP NKNPEMGBLFF(Guid PJNPLPPKBKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7C92230", Offset = "0x7C90830", VA = "0x187C92230", Slot = "5")]
	public KOPMHHENCNP NKNPEMGBLFF(MOBJPBHHADI IMBPCMFEPCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7C91470", Offset = "0x7C8FA70", VA = "0x187C91470", Slot = "15")]
	[AsyncStateMachine(typeof(LKAKEEKEKNE))]
	public Task<KOPMHHENCNP> KAONOGIPAAB(Guid PJNPLPPKBKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7C91580", Offset = "0x7C8FB80", VA = "0x187C91580", Slot = "6")]
	[AsyncStateMachine(typeof(OMCFOABGJBK))]
	public Task<List<MOBJPBHHADI>> KGCJGKPJNDG(string LMEMKNINDBF, bool? EMEKHBMBEEI, bool? FKCHMMOCIFN, IEnumerable<int> DLGIBNMNPCG, bool MGFBOHDDNJH, bool PMFKMGIBOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7C90720", Offset = "0x7C8ED20", VA = "0x187C90720", Slot = "7")]
	[AsyncStateMachine(typeof(ANNGAHOPDML))]
	public Task<List<MOBJPBHHADI>> DOEDNOKBDGB(IReadOnlyList<JEJKIPMLEEI> KKGLPNLEJJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7C909A0", Offset = "0x7C8EFA0", VA = "0x187C909A0")]
	[AsyncStateMachine(typeof(OKMNPCHGDMA))]
	private Task<List<HKAOEDINFKI>> GJDDGALMAFA(List<HKAOEDINFKI> NOFLCGFLKMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7C90100", Offset = "0x7C8E700", VA = "0x187C90100")]
	private List<MOBJPBHHADI> DLLPLKBBNKG(IReadOnlyList<JEJKIPMLEEI> CMKFKBEIKJD, IReadOnlyList<BEIGBIHPIEI> GGEOBPMIEEB, IReadOnlyList<MOBJPBHHADI> NOFLCGFLKMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7C910D0", Offset = "0x7C8F6D0", VA = "0x187C910D0", Slot = "8")]
	public NEEPBAPEEOL<BalanceUpdateResponseDTO<JJFOMBGHIEB>> HNAKMCALHDP(Guid PJNPLPPKBKJ, long ODPGPODGLMG, GiftItemDTO KFPKCKNBPOD, FBCPBGGDIHI EJGELNCAGAO = FBCPBGGDIHI.RecCenterTokens, [Optional] long? PJOEJJABEEO, JDDLHNCCFFA FDOLPPAKHDB = JDDLHNCCFFA.None)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7C91AF0", Offset = "0x7C900F0", VA = "0x187C91AF0")]
	[AsyncStateMachine(typeof(MOPDHDDJFMH))]
	private Task<GGMEEPGDLCG<BalanceUpdateResponseDTO<JJFOMBGHIEB>>> MOKOMFFMPEP(Guid PJNPLPPKBKJ, long ODPGPODGLMG, GiftItemDTO KFPKCKNBPOD, FBCPBGGDIHI EJGELNCAGAO = FBCPBGGDIHI.RecCenterTokens, [Optional] long? PJOEJJABEEO, JDDLHNCCFFA FDOLPPAKHDB = JDDLHNCCFFA.None)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7C927C0", Offset = "0x7C90DC0", VA = "0x187C927C0", Slot = "9")]
	public NEEPBAPEEOL<BalanceUpdateResponseDTO<JJFOMBGHIEB>> PHAKMOLGGDP(JDDLHNCCFFA FDOLPPAKHDB, FBCPBGGDIHI EJGELNCAGAO, int KHDGPOHCJFA, long ODPGPODGLMG, long? PJOEJJABEEO, int ANFKLMBEEDK, bool FLIDAPCKHGP = false, bool OJMMABDPBFM = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7C8F940", Offset = "0x7C8DF40", VA = "0x187C8F940", Slot = "10")]
	public NEEPBAPEEOL<BalanceUpdateResponseDTO<JJFOMBGHIEB>> BEDEEHOGJBG(JDDLHNCCFFA FDOLPPAKHDB, FBCPBGGDIHI EJGELNCAGAO, int KHDGPOHCJFA, long ODPGPODGLMG, long? PJOEJJABEEO, IReadOnlyCollection<int> CPCFIPMJOCL, string MIALAMIFNLM, bool HLCCAFKJBCH, MGINFBHLBGH OIBHDJGFPKM, int ANFKLMBEEDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7C91D50", Offset = "0x7C90350", VA = "0x187C91D50", Slot = "11")]
	public NEEPBAPEEOL<BalanceUpdateResponseDTO<JJFOMBGHIEB>> NCAFNNMLGGH(JDDLHNCCFFA FDOLPPAKHDB, FBCPBGGDIHI EJGELNCAGAO, IReadOnlyList<int> MODGKGPDPEJ, IReadOnlyList<long> JOKHJHLBJDD, long? PJOEJJABEEO, int BBPIIHOGLAJ, string MIALAMIFNLM, bool HLCCAFKJBCH, MGINFBHLBGH OIBHDJGFPKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7C91330", Offset = "0x7C8F930", VA = "0x187C91330")]
	[AsyncStateMachine(typeof(LNOCHOCCDEN))]
	private Task<List<KOPMHHENCNP>> JNJFJKIHIEF(IReadOnlyList<Guid> PDALGOKECBO, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7C916E0", Offset = "0x7C8FCE0", VA = "0x187C916E0")]
	private void LAMEIIIEOPB(BalanceUpdateResponseDTO<JJFOMBGHIEB> GIBMLNMIEIO, bool CGPFEOOIGAC, bool OJMMABDPBFM, bool FLIDAPCKHGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7C92550", Offset = "0x7C90B50", VA = "0x187C92550")]
	private void OANDNDKKNOG(MNEFDGDOLIH HGIPNEPCOAD, bool HJDLJNHEFCO, bool GPIJNBINCFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7C91C50", Offset = "0x7C90250", VA = "0x187C91C50")]
	[AsyncStateMachine(typeof(NJCCFJPJCKF))]
	private Task MPGPKLCPIFO(List<MOBJPBHHADI> PHPLCLJIOHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7C8FE20", Offset = "0x7C8E420", VA = "0x187C8FE20")]
	[CompilerGenerated]
	private void EEOLNBJDFAD(BalanceUpdateResponseDTO<JJFOMBGHIEB> BIEIOPPGBOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7C8FE20", Offset = "0x7C8E420", VA = "0x187C8FE20")]
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
	[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
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
