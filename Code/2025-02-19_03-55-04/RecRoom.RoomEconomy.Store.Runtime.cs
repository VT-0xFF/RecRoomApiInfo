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
		[Cpp2IlInjected.Address(RVA = "0x7C16AE0", Offset = "0x7C156E0", VA = "0x187C16AE0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x240ECE0", Offset = "0x240D8E0", VA = "0x18240ECE0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class LIGNKHBIILE : BBAJJJDICEC, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private struct DFGBPFMDHEK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public LIGNKHBIILE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7C12650", Offset = "0x7C11250", VA = "0x187C12650", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7C12950", Offset = "0x7C11550", VA = "0x187C12950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private struct BEIALHNFPAI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public AsyncTaskMethodBuilder<MJJAMNJPJNF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public LIGNKHBIILE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public Guid customAvatarItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private TaskAwaiter<MJJAMNJPJNF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7C115B0", Offset = "0x7C101B0", VA = "0x187C115B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7C118C0", Offset = "0x7C104C0", VA = "0x187C118C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct NKOIPIJDGCC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public AsyncTaskMethodBuilder<List<LPCEEOAFMAN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public LIGNKHBIILE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public string searchQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public bool? isOwned;

		[Cpp2IlInjected.FieldOffset(Offset = "0x32")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public bool? isFeatured;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public IEnumerable<int> outfitTypes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public bool includeCoachItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public Func<List<GIGCGBBOIBH>, Task<List<GIGCGBBOIBH>>> filterCustomAvatarItemsFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private List<LPCEEOAFMAN> <results>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private TaskAwaiter<List<GIGCGBBOIBH>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7C162D0", Offset = "0x7C14ED0", VA = "0x187C162D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7C168D0", Offset = "0x7C154D0", VA = "0x187C168D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct AJPEDLCHMOL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public AsyncTaskMethodBuilder<List<LPCEEOAFMAN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public LIGNKHBIILE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public IReadOnlyList<NAFDJPEFHNC> unifiedItemIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public Func<List<GIGCGBBOIBH>, Task<List<GIGCGBBOIBH>>> filterCustomAvatarItemsFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private TaskAwaiter<List<GIGCGBBOIBH>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private TaskAwaiter<List<LPCEEOAFMAN>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7C10B60", Offset = "0x7C0F760", VA = "0x187C10B60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7C11540", Offset = "0x7C10140", VA = "0x187C11540", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class MHHFIDAJOOK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public NAFDJPEFHNC id;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public MHHFIDAJOOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7C16290", Offset = "0x7C14E90", VA = "0x187C16290")]
		internal bool GLLPOHNMGIF(KCAPGKEMGAO x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7C16230", Offset = "0x7C14E30", VA = "0x187C16230")]
		internal bool AKGLMAAPKPJ(GIGCGBBOIBH x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class BKDILOLFGNK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public string itemFriendlyName;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public BKDILOLFGNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7C11930", Offset = "0x7C10530", VA = "0x187C11930")]
		internal object JLEBDAINMBA()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct CGIENKCCCIJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public AsyncTaskMethodBuilder<List<LPCEEOAFMAN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public IReadOnlyList<NAFDJPEFHNC> expectedItemIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public IReadOnlyList<KCAPGKEMGAO> purchasableGiftDrops;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public IReadOnlyList<GIGCGBBOIBH> customAvatarItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public LIGNKHBIILE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private List<LPCEEOAFMAN> <results>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7C11DE0", Offset = "0x7C109E0", VA = "0x187C11DE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7C125E0", Offset = "0x7C111E0", VA = "0x187C125E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class FJMPHKEOAOM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public LIGNKHBIILE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public GiftItemDTO gift;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public FJMPHKEOAOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7C12F10", Offset = "0x7C11B10", VA = "0x187C12F10")]
		internal void BIBBCHMIGCM(BalanceUpdateResponseDTO<ALNNNIINCND> result)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct KDBHFDCBPCH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncTaskMethodBuilder<KMNBFOMNBJE<BalanceUpdateResponseDTO<ALNNNIINCND>>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public LIGNKHBIILE <>4__this;

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
		public MANGHFFICCB storefrontType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public EPJAFMLNIDE currencyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private TaskAwaiter<MJJAMNJPJNF> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private TaskAwaiter<KMNBFOMNBJE<BalanceUpdateResponseDTO<ALNNNIINCND>>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7C12F50", Offset = "0x7C11B50", VA = "0x187C12F50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7C13430", Offset = "0x7C12030", VA = "0x187C13430", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class DKJDEBGDLFD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public LIGNKHBIILE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public bool handleShowGiftPackage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public bool shouldConsumeGiftBoxImmediately;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public DKJDEBGDLFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7C129B0", Offset = "0x7C115B0", VA = "0x187C129B0")]
		internal void KCCEJEJGNFP(BalanceUpdateResponseDTO<ALNNNIINCND> result)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct CEIIMLJDDNG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public AsyncTaskMethodBuilder<List<MJJAMNJPJNF>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public IReadOnlyList<Guid> itemIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public LIGNKHBIILE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private TaskAwaiter<List<LPOFCJFLMMF>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7C11980", Offset = "0x7C10580", VA = "0x187C11980", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7C11D70", Offset = "0x7C10970", VA = "0x187C11D70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct FGABFKFOHBD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public List<LPCEEOAFMAN> storeItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public LIGNKHBIILE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private int <attemptNumber>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7C129F0", Offset = "0x7C115F0", VA = "0x187C129F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x7C12EB0", Offset = "0x7C11AB0", VA = "0x187C12EB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly JOJCEGLIEBP<Guid, MJJAMNJPJNF> GHJGMPHODEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private POBEOJFOKLB JBGDHOMBHKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private IHEDLFOMGBD NKCHOONLJOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private LPDMPLOJFPD AFIHDONCFHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private AALCBNDMPIM LAHJLHLMHNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal MJFHCEFLNCG<Guid, MJJAMNJPJNF> FKCHFFOJJKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private bool EIHBPFOIIHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private Task MKHDPHNHKMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private CancellationTokenSource JACIFKJPDCH;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static BBAJJJDICEC JHOMDMKMMKD;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static BBAJJJDICEC FFLNCJPMHOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7C158D0", Offset = "0x7C144D0", VA = "0x187C158D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7C15C30", Offset = "0x7C14830", VA = "0x187C15C30")]
	[DMDJPIBKEJJ.OPKFCOALFMB.IBOCCFBJPBC]
	internal static void OPGDNJLIDJN(KPLLBHIBBNH AGGFAPJEEEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7C15DF0", Offset = "0x7C149F0", VA = "0x187C15DF0")]
	[RecRoom.NoEngine.Common.Preserve]
	public LIGNKHBIILE([GJMNBPKNJPO(null)] LPDMPLOJFPD AFIHDONCFHG, [GJMNBPKNJPO(null)] POBEOJFOKLB JBGDHOMBHKP, [GJMNBPKNJPO(null)] IHEDLFOMGBD NKCHOONLJOA, [GJMNBPKNJPO(null)] AALCBNDMPIM LAHJLHLMHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7C14460", Offset = "0x7C13060", VA = "0x187C14460", Slot = "1")]
	~LIGNKHBIILE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7C14020", Offset = "0x7C12C20", VA = "0x187C14020", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7C151D0", Offset = "0x7C13DD0", VA = "0x187C151D0")]
	[AsyncStateMachine(typeof(DFGBPFMDHEK))]
	private Task LBKIGOGBMNI(CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7C15D70", Offset = "0x7C14970", VA = "0x187C15D70")]
	public void PLMPDDKKFDD(Guid NDMNLGHHJKE, MJJAMNJPJNF JMHPGKHBMDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7C14690", Offset = "0x7C13290", VA = "0x187C14690", Slot = "13")]
	public void IGGJPHMEKHN(LPCEEOAFMAN BKFPPBFDIMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7C13720", Offset = "0x7C12320", VA = "0x187C13720", Slot = "4")]
	public void CGFLBGGNLJI(IEnumerable<LPCEEOAFMAN> KCCMCIEBMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7C155D0", Offset = "0x7C141D0", VA = "0x187C155D0", Slot = "14")]
	public MJJAMNJPJNF NGBKIABKJEL(Guid PCIMFMHGJDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7C156D0", Offset = "0x7C142D0", VA = "0x187C156D0", Slot = "5")]
	public MJJAMNJPJNF NGBKIABKJEL(LPCEEOAFMAN BKFPPBFDIMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7C134A0", Offset = "0x7C120A0", VA = "0x187C134A0", Slot = "15")]
	[AsyncStateMachine(typeof(BEIALHNFPAI))]
	public Task<MJJAMNJPJNF> BICBKAMJHBH(Guid PCIMFMHGJDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7C14090", Offset = "0x7C12C90", VA = "0x187C14090", Slot = "6")]
	[AsyncStateMachine(typeof(NKOIPIJDGCC))]
	public Task<List<LPCEEOAFMAN>> EKLMFLNGBOO(string JGFLIPDEPGF, bool? FFCMBLJKLLO, bool? HJPPANIEIEC, IEnumerable<int> IEONCMBADKD, bool IJIEDPCENLI, Func<List<GIGCGBBOIBH>, Task<List<GIGCGBBOIBH>>> APADJGCJCOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7C135B0", Offset = "0x7C121B0", VA = "0x187C135B0", Slot = "7")]
	[AsyncStateMachine(typeof(AJPEDLCHMOL))]
	public Task<List<LPCEEOAFMAN>> BLCEKPPAMFG(IReadOnlyList<NAFDJPEFHNC> KBDGPEEICEE, Func<List<GIGCGBBOIBH>, Task<List<GIGCGBBOIBH>>> APADJGCJCOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7C14B90", Offset = "0x7C13790", VA = "0x187C14B90")]
	[AsyncStateMachine(typeof(CGIENKCCCIJ))]
	private Task<List<LPCEEOAFMAN>> IKDICMBOILH(IReadOnlyList<NAFDJPEFHNC> BDMEMDCIJLL, IReadOnlyList<KCAPGKEMGAO> LBJJJBEDIGM, IReadOnlyList<GIGCGBBOIBH> CCPNLHGKJML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7C14930", Offset = "0x7C13530", VA = "0x187C14930", Slot = "8")]
	public JOIICJDLMNO<BalanceUpdateResponseDTO<ALNNNIINCND>> IGKJFIELBCO(Guid PCIMFMHGJDE, long EKNFNCMCLFL, GiftItemDTO AELKLAJNIFP, EPJAFMLNIDE EOPHMAPELAL = EPJAFMLNIDE.RecCenterTokens, [Optional] long? FDDOOHHHMGB, MANGHFFICCB CINFOJPBEMD = MANGHFFICCB.None)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7C13DC0", Offset = "0x7C129C0", VA = "0x187C13DC0")]
	[AsyncStateMachine(typeof(KDBHFDCBPCH))]
	private Task<KMNBFOMNBJE<BalanceUpdateResponseDTO<ALNNNIINCND>>> COJBKNENBFP(Guid PCIMFMHGJDE, long EKNFNCMCLFL, GiftItemDTO AELKLAJNIFP, EPJAFMLNIDE EOPHMAPELAL = EPJAFMLNIDE.RecCenterTokens, [Optional] long? FDDOOHHHMGB, MANGHFFICCB CINFOJPBEMD = MANGHFFICCB.None)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7C14200", Offset = "0x7C12E00", VA = "0x187C14200", Slot = "9")]
	public JOIICJDLMNO<BalanceUpdateResponseDTO<ALNNNIINCND>> FBAIPCONNGJ(MANGHFFICCB CINFOJPBEMD, EPJAFMLNIDE EOPHMAPELAL, int HPGMFNHMFOA, long EKNFNCMCLFL, long? FDDOOHHHMGB, int CCFDOCHGFLO, bool OGHFLGIEMIK = false, bool OCHHPIKNELG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7C138E0", Offset = "0x7C124E0", VA = "0x187C138E0", Slot = "10")]
	public JOIICJDLMNO<BalanceUpdateResponseDTO<ALNNNIINCND>> CIKFOAHJFIK(MANGHFFICCB CINFOJPBEMD, EPJAFMLNIDE EOPHMAPELAL, int HPGMFNHMFOA, long EKNFNCMCLFL, long? FDDOOHHHMGB, IReadOnlyCollection<int> AOMLHCILGDO, string KBPDEFFIKOJ, bool MDLICJDHHAO, HFEIOFNECBI GBMCPNKHLII, int CCFDOCHGFLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7C14CF0", Offset = "0x7C138F0", VA = "0x187C14CF0", Slot = "11")]
	public JOIICJDLMNO<BalanceUpdateResponseDTO<ALNNNIINCND>> KGPLBGANBPP(MANGHFFICCB CINFOJPBEMD, EPJAFMLNIDE EOPHMAPELAL, IReadOnlyList<int> AEOIJCCLPKI, IReadOnlyList<long> GFIPDIHKNBP, long? FDDOOHHHMGB, int GHCHKOGMCKK, string KBPDEFFIKOJ, bool MDLICJDHHAO, HFEIOFNECBI GBMCPNKHLII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7C14550", Offset = "0x7C13150", VA = "0x187C14550")]
	[AsyncStateMachine(typeof(CEIIMLJDDNG))]
	private Task<List<MJJAMNJPJNF>> HBANKDMELGN(IReadOnlyList<Guid> ONBGIAEBCIB, CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7C152C0", Offset = "0x7C13EC0", VA = "0x187C152C0")]
	private void LBMNFJLOCIL(BalanceUpdateResponseDTO<ALNNNIINCND> EBDLOACCNAO, bool MPLHOJDIPGH, bool OCHHPIKNELG, bool OGHFLGIEMIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7C159C0", Offset = "0x7C145C0", VA = "0x187C159C0")]
	private void ONLNICADCCG(KABAKBKCMCP IABFIPEOOOD, bool DBIGMABDNFP, bool DHOCPLHCKJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7C13F20", Offset = "0x7C12B20", VA = "0x187C13F20")]
	[AsyncStateMachine(typeof(FGABFKFOHBD))]
	private Task COOEJFBGOFD(List<LPCEEOAFMAN> KCCMCIEBMHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7C136F0", Offset = "0x7C122F0", VA = "0x187C136F0")]
	[CompilerGenerated]
	private void MIPFNPKFFMF(BalanceUpdateResponseDTO<ALNNNIINCND> HBANOBDOKBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7C136F0", Offset = "0x7C122F0", VA = "0x187C136F0")]
	[CompilerGenerated]
	private void BLLCJPOMAJI(BalanceUpdateResponseDTO<ALNNNIINCND> HBANOBDOKBJ)
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class DLABOHGMBLK
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
	public DLABOHGMBLK()
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
