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
		[Cpp2IlInjected.Address(RVA = "0x896A070", Offset = "0x8968C70", VA = "0x18896A070", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x28B3880", Offset = "0x28B2480", VA = "0x1828B3880")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class IICJEOGIEBP : BKCMLNBFGFC, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private struct AGBBOAIHHLF : IAsyncStateMachine
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
		public IICJEOGIEBP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8960A30", Offset = "0x895F630", VA = "0x188960A30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8960D30", Offset = "0x895F930", VA = "0x188960D30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private struct AJFLCMIPCIE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public AsyncTaskMethodBuilder<CKPFFCIJEDH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public IICJEOGIEBP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public Guid customAvatarItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private TaskAwaiter<CKPFFCIJEDH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8960D90", Offset = "0x895F990", VA = "0x188960D90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8961060", Offset = "0x895FC60", VA = "0x188961060", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct GOCFIGEIGHN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public AsyncTaskMethodBuilder<List<ENIOBPLBCEN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public IICJEOGIEBP <>4__this;

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
		private List<ENIOBPLBCEN> <results>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private TaskAwaiter<List<MLJBIFMBPOL>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8964700", Offset = "0x8963300", VA = "0x188964700", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8964EB0", Offset = "0x8963AB0", VA = "0x188964EB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct EHLLGCAPPIP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public AsyncTaskMethodBuilder<List<ENIOBPLBCEN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public IICJEOGIEBP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public IReadOnlyList<MBCHAJLOPLD> unifiedItemIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public bool convertCustomAvatarItemsToPurchasableGiftDrops;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private Task <watchStorefrontTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private List<MLJBIFMBPOL> <customAvatarItems>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private List<ENIOBPLBCEN> <storeItemsInInitialOrder>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private TaskAwaiter<List<MLJBIFMBPOL>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x89616D0", Offset = "0x89602D0", VA = "0x1889616D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8962170", Offset = "0x8960D70", VA = "0x188962170", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct MJENDKGKMPJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public AsyncTaskMethodBuilder<List<MLJBIFMBPOL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public List<MLJBIFMBPOL> customAvatarItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public IICJEOGIEBP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8969910", Offset = "0x8968510", VA = "0x188969910", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8969E10", Offset = "0x8968A10", VA = "0x188969E10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class APPEHHOPJIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public MBCHAJLOPLD id;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public APPEHHOPJIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8961190", Offset = "0x895FD90", VA = "0x188961190")]
		internal bool FMOLHNMPMEC(DAPFJOECAIO x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x89610D0", Offset = "0x895FCD0", VA = "0x1889610D0")]
		internal bool FFKONGCGCIN(ENIOBPLBCEN x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class FPBAKNMGGKA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public string itemFriendlyName;

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public FPBAKNMGGKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x89621E0", Offset = "0x8960DE0", VA = "0x1889621E0")]
		internal object BJNECIOFIGO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class ONOAKPHLCKK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public IICJEOGIEBP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public GiftItemDTO gift;

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public ONOAKPHLCKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8969E80", Offset = "0x8968A80", VA = "0x188969E80")]
		internal void FMNFLIMICPP(BalanceUpdateResponseDTO<GDALHNHECCP> result)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct KJDMBGMPJIN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public AsyncTaskMethodBuilder<LBECHKOPJFH<BalanceUpdateResponseDTO<GDALHNHECCP>>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public IICJEOGIEBP <>4__this;

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
		public BDNNOMAEPNN storefrontType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public GOIKMNKDKIA currencyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private TaskAwaiter<CKPFFCIJEDH> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TaskAwaiter<LBECHKOPJFH<BalanceUpdateResponseDTO<GDALHNHECCP>>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x89693A0", Offset = "0x8967FA0", VA = "0x1889693A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x89698A0", Offset = "0x89684A0", VA = "0x1889698A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class CLJEOCDAJCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public IICJEOGIEBP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public bool handleShowGiftPackage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public bool shouldConsumeGiftBoxImmediately;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public CLJEOCDAJCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8961690", Offset = "0x8960290", VA = "0x188961690")]
		internal void KACCPGKOBLB(BalanceUpdateResponseDTO<GDALHNHECCP> result)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class CAHCHLNPNPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public IICJEOGIEBP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public GiftItemDTO gift;

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public CAHCHLNPNPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x89611D0", Offset = "0x895FDD0", VA = "0x1889611D0")]
		internal void JMHOKEBBPMI(BalanceUpdateResponseDTO<GDALHNHECCP> result)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct CAKFLCHJDPM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public AsyncTaskMethodBuilder<List<CKPFFCIJEDH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public IReadOnlyList<Guid> itemIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public IICJEOGIEBP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private TaskAwaiter<List<DINPALELGEA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8961210", Offset = "0x895FE10", VA = "0x188961210", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8961620", Offset = "0x8960220", VA = "0x188961620", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct JMHAEJADEMO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public List<ENIOBPLBCEN> storeItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public IICJEOGIEBP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private int <attemptNumber>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8968DB0", Offset = "0x89679B0", VA = "0x188968DB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8969340", Offset = "0x8967F40", VA = "0x188969340", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly POKPLCPAKEI<Guid, CKPFFCIJEDH> MGNBANCBFJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private BGFMEDCIGJB NBIBGELPJGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private OEJLGPDFJPD AAEHEJECLEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private MDHEJJOELKA FBMJJMABGKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private KOENLJOALBF FKBDLGJKFEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private IPADCJFEADJ HMFDDNHKFLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private PEHHKHACOAC MBMIIEAOJOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal BGFCJDALAHK<Guid, CKPFFCIJEDH> GKKEPFPGNLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private bool BNHFKKOIPKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private Task NHCAGMMPJNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private CancellationTokenSource AKAOPMPAHFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private List<DAPFJOECAIO> JACJEKBKIJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private NFOPFCBHLPB? KJEBHKOACMC;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static BKCMLNBFGFC CFLGCHMMNOH;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private List<DAPFJOECAIO> NLDICFGJKAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8965030", Offset = "0x8963C30", VA = "0x188965030")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private NFOPFCBHLPB HAJALAKPICB
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8967490", Offset = "0x8966090", VA = "0x188967490")]
		get
		{
			return default(NFOPFCBHLPB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static BKCMLNBFGFC MFAGMJBMEEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x89662E0", Offset = "0x8964EE0", VA = "0x1889662E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x8966960", Offset = "0x8965560", VA = "0x188966960")]
	private List<DAPFJOECAIO> KLDAEMDHACD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x89667B0", Offset = "0x89653B0", VA = "0x1889667B0")]
	[HHMPGEJNNFC.LMFNECDEKKH.PMAKKEDIOOO]
	internal static void KGIELNFJPKP(LGPCNHIHIDJ EHEGCBFMKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x8968930", Offset = "0x8967530", VA = "0x188968930")]
	[RecRoom.NoEngine.Common.Preserve]
	public IICJEOGIEBP([HAKCNCGPHPD(null)] MDHEJJOELKA FBMJJMABGKK, [HAKCNCGPHPD(null)] BGFMEDCIGJB NBIBGELPJGE, [HAKCNCGPHPD(null)] OEJLGPDFJPD AAEHEJECLEB, [HAKCNCGPHPD(null)] KOENLJOALBF FKBDLGJKFEK, [HAKCNCGPHPD(null)] IPADCJFEADJ HMFDDNHKFLB, [HAKCNCGPHPD(null)] PEHHKHACOAC MBMIIEAOJOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x8965A70", Offset = "0x8964670", VA = "0x188965A70", Slot = "1")]
	~IICJEOGIEBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x8965490", Offset = "0x8964090", VA = "0x188965490", Slot = "13")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x89680F0", Offset = "0x8966CF0", VA = "0x1889680F0")]
	[AsyncStateMachine(typeof(AGBBOAIHHLF))]
	private Task PCLALNKHEFH(CancellationToken JHCOCAANJDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x89681E0", Offset = "0x8966DE0", VA = "0x1889681E0")]
	public void PICOGGHHBLB(Guid DFNJJBHJBLK, CKPFFCIJEDH NHBCOKHNGHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x8966C10", Offset = "0x8965810", VA = "0x188966C10", Slot = "14")]
	public void MJHNJIKOEKB(ENIOBPLBCEN PIDILNPOPJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x89652D0", Offset = "0x8963ED0", VA = "0x1889652D0", Slot = "4")]
	public void DNFMMKMPBDH(IEnumerable<ENIOBPLBCEN> CIKKCOBLDCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x8967040", Offset = "0x8965C40", VA = "0x188967040", Slot = "15")]
	public CKPFFCIJEDH NIHFCJEDOHH(Guid COGDOHLDAFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x8966E40", Offset = "0x8965A40", VA = "0x188966E40", Slot = "5")]
	public CKPFFCIJEDH NIHFCJEDOHH(ENIOBPLBCEN PIDILNPOPJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x8966850", Offset = "0x8965450", VA = "0x188966850", Slot = "16")]
	[AsyncStateMachine(typeof(AJFLCMIPCIE))]
	public Task<CKPFFCIJEDH> KGPKFNNGLKP(Guid COGDOHLDAFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x8965B60", Offset = "0x8964760", VA = "0x188965B60", Slot = "7")]
	[AsyncStateMachine(typeof(GOCFIGEIGHN))]
	public Task<List<ENIOBPLBCEN>> HBAIJPKCOAA(string KPOMHHMFMBE, bool? EPODMHHDMLK, bool? ECPKAIPLAKM, IEnumerable<int> EEKCLAEDNIF, bool PBPNDHEEGBO, bool CJOBHLJIBEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x8967820", Offset = "0x8966420", VA = "0x188967820", Slot = "6")]
	public ENIOBPLBCEN OMHMBKLEHIP(MBCHAJLOPLD DFNJJBHJBLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x8966AD0", Offset = "0x89656D0", VA = "0x188966AD0", Slot = "8")]
	[AsyncStateMachine(typeof(EHLLGCAPPIP))]
	public Task<List<ENIOBPLBCEN>> LEOBFCCKEBG(IReadOnlyList<MBCHAJLOPLD> IHAAOLOPBJG, bool NCPHDMFEDGF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x8964F20", Offset = "0x8963B20", VA = "0x188964F20")]
	[AsyncStateMachine(typeof(MJENDKGKMPJ))]
	private Task<List<MLJBIFMBPOL>> CBFPGAAJILE(List<MLJBIFMBPOL> ONFOJPOCPDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x8965CC0", Offset = "0x89648C0", VA = "0x188965CC0")]
	private List<ENIOBPLBCEN> HCJCCAHABCA(IReadOnlyList<MBCHAJLOPLD> LOOJAPBGDDN, IReadOnlyList<DAPFJOECAIO> EHIHBIEPDIN, IReadOnlyList<ENIOBPLBCEN> ONFOJPOCPDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x8965810", Offset = "0x8964410", VA = "0x188965810", Slot = "9")]
	public AIDGEFHMIOM<BalanceUpdateResponseDTO<GDALHNHECCP>> EGEDCBHLLEM(Guid COGDOHLDAFA, long PDOGFJKABAO, GiftItemDTO KKLMKPNDKKK, GOIKMNKDKIA MNNONNHAEBL = GOIKMNKDKIA.RecCenterTokens, [Optional] long? HDAKEAPPDAC, BDNNOMAEPNN LKBKOIFJLBC = BDNNOMAEPNN.None)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x8966650", Offset = "0x8965250", VA = "0x188966650")]
	[AsyncStateMachine(typeof(KJDMBGMPJIN))]
	private Task<LBECHKOPJFH<BalanceUpdateResponseDTO<GDALHNHECCP>>> JBNPODIFODF(Guid COGDOHLDAFA, long PDOGFJKABAO, GiftItemDTO KKLMKPNDKKK, GOIKMNKDKIA MNNONNHAEBL = GOIKMNKDKIA.RecCenterTokens, [Optional] long? HDAKEAPPDAC, BDNNOMAEPNN LKBKOIFJLBC = BDNNOMAEPNN.None)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x8967150", Offset = "0x8965D50", VA = "0x188967150", Slot = "10")]
	public AIDGEFHMIOM<BalanceUpdateResponseDTO<GDALHNHECCP>> OCLNGBDGHLJ(BDNNOMAEPNN LKBKOIFJLBC, GOIKMNKDKIA MNNONNHAEBL, int PPHKGAAJGGM, long PDOGFJKABAO, long? HDAKEAPPDAC, int AMOELAJGNML, bool MCFEDBNGENH = false, bool BJOOBHJCGJM = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x8967B10", Offset = "0x8966710", VA = "0x188967B10", Slot = "11")]
	public AIDGEFHMIOM<BalanceUpdateResponseDTO<GDALHNHECCP>> OPOHGLHGNGN(BDNNOMAEPNN LKBKOIFJLBC, GOIKMNKDKIA MNNONNHAEBL, int PPHKGAAJGGM, long PDOGFJKABAO, long? HDAKEAPPDAC, IReadOnlyCollection<int> JPBGEABKONK, string HLMEMBFCHLD, bool BDJKFGFNHHB, CJOAAGIEEAK PFOBBGPCOEJ, int AMOELAJGNML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x8968320", Offset = "0x8966F20", VA = "0x188968320", Slot = "12")]
	public AIDGEFHMIOM<BalanceUpdateResponseDTO<GDALHNHECCP>> PPNPHNACLPC(BDNNOMAEPNN LKBKOIFJLBC, GOIKMNKDKIA MNNONNHAEBL, IReadOnlyList<MBCHAJLOPLD> GEOCJLPGELO, IReadOnlyList<long> LACLCMMHNCC, [Optional] long? HDAKEAPPDAC, [Optional][CanBeNull] GiftItemDTO KKLMKPNDKKK, [Optional] Guid? PLNBOHNIPCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x89676E0", Offset = "0x89662E0", VA = "0x1889676E0")]
	[AsyncStateMachine(typeof(CAKFLCHJDPM))]
	private Task<List<CKPFFCIJEDH>> OGKIBHMKBPG(IReadOnlyList<Guid> GEOCJLPGELO, CancellationToken JHCOCAANJDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x8965500", Offset = "0x8964100", VA = "0x188965500")]
	private void EBNEGGPGLLP(BalanceUpdateResponseDTO<GDALHNHECCP> FLHCCHCJDKE, bool ILIEGLPPJEI, bool BJOOBHJCGJM, bool MCFEDBNGENH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x89663E0", Offset = "0x8964FE0", VA = "0x1889663E0")]
	private void JBBNGGFFFBM(HCGMPGFOLNI DEBHBMLFOJM, bool EOCJDEACIHP, bool EJOAAFBBHPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x89651D0", Offset = "0x8963DD0", VA = "0x1889651D0")]
	[AsyncStateMachine(typeof(JMHAEJADEMO))]
	private Task DKGPFPOOECA(List<ENIOBPLBCEN> CIKKCOBLDCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x89676B0", Offset = "0x89662B0", VA = "0x1889676B0")]
	[CompilerGenerated]
	private void OGJMBPACNNH(BalanceUpdateResponseDTO<GDALHNHECCP> ABEFNIJCBBN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class GNFLMDLMJDA : LHHMOEOEFLE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly IPADCJFEADJ DDDGKMLGKNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly FMOPLFDGOJL NECMADDMCBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly BGGHJLDFJDD MDFICNIBMMB;

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x8962580", Offset = "0x8961180", VA = "0x188962580")]
	[HHMPGEJNNFC.LMFNECDEKKH.PMAKKEDIOOO]
	internal static void AMOEJCEGAKO(LGPCNHIHIDJ EHEGCBFMKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0xD56060", Offset = "0xD54C60", VA = "0x180D56060")]
	[RecRoom.NoEngine.Common.Preserve]
	public GNFLMDLMJDA([HAKCNCGPHPD(null)] IPADCJFEADJ HMFDDNHKFLB, [HAKCNCGPHPD(null)] FMOPLFDGOJL GPNPECGNIDF, [HAKCNCGPHPD(null)] BGGHJLDFJDD ONFOJPOCPDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x8963480", Offset = "0x8962080", VA = "0x188963480")]
	private bool IOICMACDAIO(DNIDHNKGLEC PNAIBFMAJJL, DNIDHNKGLEC FKMFHJKFAJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x89622A0", Offset = "0x8960EA0", VA = "0x1889622A0", Slot = "5")]
	public IReadOnlyList<ENIOBPLBCEN> AGEPDMPEEHD(DNIDHNKGLEC NKJOCFMOGPK, IReadOnlyList<ENIOBPLBCEN> LNODOELCPNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x8963570", Offset = "0x8962170", VA = "0x188963570", Slot = "4")]
	public bool KAKMIGBHHGJ(DNIDHNKGLEC NKJOCFMOGPK, ENIOBPLBCEN BHNJKAEPJMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x89641B0", Offset = "0x8962DB0", VA = "0x1889641B0")]
	private bool KJDDMOEBDAP(DNIDHNKGLEC NKJOCFMOGPK, ENIOBPLBCEN BHNJKAEPJMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x8964400", Offset = "0x8963000", VA = "0x188964400")]
	private bool OFLGJPFCJBP(DNIDHNKGLEC NKJOCFMOGPK, ENIOBPLBCEN BHNJKAEPJMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x8963490", Offset = "0x8962090", VA = "0x188963490")]
	private bool JKDCOGAMNBB(DNIDHNKGLEC NKJOCFMOGPK, ENIOBPLBCEN BHNJKAEPJMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x89626C0", Offset = "0x89612C0", VA = "0x1889626C0")]
	public bool AODFNEHMLGM(ENIOBPLBCEN PIDILNPOPJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x89625F0", Offset = "0x89611F0", VA = "0x1889625F0")]
	public bool AODFNEHMLGM(KOCKKNOECBG ELIHGFABPOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x8962F50", Offset = "0x8961B50", VA = "0x188962F50")]
	private bool GNEGAEIAFKP(Guid COGDOHLDAFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x8964240", Offset = "0x8962E40", VA = "0x188964240")]
	private bool LFNNGLKCIAD(DNIDHNKGLEC NKJOCFMOGPK, ENIOBPLBCEN BHNJKAEPJMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x8964370", Offset = "0x8962F70", VA = "0x188964370")]
	private bool NEPLMHKINCN(DNIDHNKGLEC NKJOCFMOGPK, ENIOBPLBCEN BHNJKAEPJMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x8964300", Offset = "0x8962F00", VA = "0x188964300")]
	private bool MKOFPPLIJGM(DNIDHNKGLEC NKJOCFMOGPK, ENIOBPLBCEN BHNJKAEPJMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x8962230", Offset = "0x8960E30", VA = "0x188962230")]
	private bool ADPFCKIFMMJ(DNIDHNKGLEC NKJOCFMOGPK, ENIOBPLBCEN BHNJKAEPJMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x8963500", Offset = "0x8962100", VA = "0x188963500")]
	private bool JLAALIAMLML(DNIDHNKGLEC NKJOCFMOGPK, ENIOBPLBCEN BHNJKAEPJMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x8962AF0", Offset = "0x89616F0", VA = "0x188962AF0")]
	private bool DANFFMGIIGP(DNIDHNKGLEC NKJOCFMOGPK, ENIOBPLBCEN BHNJKAEPJMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x8962C60", Offset = "0x8961860", VA = "0x188962C60")]
	private bool DLJOPCGBKHN(DNIDHNKGLEC NKJOCFMOGPK, ENIOBPLBCEN BHNJKAEPJMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x8962CD0", Offset = "0x89618D0", VA = "0x188962CD0")]
	private bool ECCIKOCBIAL(DNIDHNKGLEC NKJOCFMOGPK, ENIOBPLBCEN BHNJKAEPJMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x89629A0", Offset = "0x89615A0", VA = "0x1889629A0")]
	private bool BJHNAJAAFGI(DNIDHNKGLEC NKJOCFMOGPK, ENIOBPLBCEN BHNJKAEPJMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x89630F0", Offset = "0x8961CF0", VA = "0x1889630F0")]
	private bool HHMFBEHDAKG(DNIDHNKGLEC NKJOCFMOGPK, ENIOBPLBCEN BHNJKAEPJMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x8964270", Offset = "0x8962E70", VA = "0x188964270")]
	private bool MCHEMKOMCFB(DNIDHNKGLEC NKJOCFMOGPK, ENIOBPLBCEN BHNJKAEPJMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x89633F0", Offset = "0x8961FF0", VA = "0x1889633F0")]
	private bool IHHJPKGOMOL(DNIDHNKGLEC NKJOCFMOGPK, ENIOBPLBCEN BHNJKAEPJMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x8962DF0", Offset = "0x89619F0", VA = "0x188962DF0")]
	private bool FKOHBBEFKPJ(DNIDHNKGLEC NKJOCFMOGPK, ENIOBPLBCEN BHNJKAEPJMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x8964120", Offset = "0x8962D20", VA = "0x188964120")]
	private bool KILAKDIIKIL(DNIDHNKGLEC NKJOCFMOGPK, ENIOBPLBCEN BHNJKAEPJMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x8962A60", Offset = "0x8961660", VA = "0x188962A60")]
	private bool CDOAHDFPICI(DNIDHNKGLEC NKJOCFMOGPK, ENIOBPLBCEN BHNJKAEPJMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x8962D60", Offset = "0x8961960", VA = "0x188962D60")]
	private bool EDDMHCFLHFA(DNIDHNKGLEC NKJOCFMOGPK, ENIOBPLBCEN BHNJKAEPJMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x8962FD0", Offset = "0x8961BD0", VA = "0x188962FD0")]
	private bool HDEGFAGKKJO(DNIDHNKGLEC NKJOCFMOGPK, ENIOBPLBCEN BHNJKAEPJMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x8963210", Offset = "0x8961E10", VA = "0x188963210")]
	private bool HPCDLKLNLHH(DNIDHNKGLEC NKJOCFMOGPK, ENIOBPLBCEN BHNJKAEPJMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x8962BD0", Offset = "0x89617D0", VA = "0x188962BD0")]
	private bool DEPKOPNDGHM(DNIDHNKGLEC NKJOCFMOGPK, ENIOBPLBCEN BHNJKAEPJMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x89632A0", Offset = "0x8961EA0", VA = "0x1889632A0")]
	private bool ICFJNEHINLE(DNIDHNKGLEC NKJOCFMOGPK, ENIOBPLBCEN BHNJKAEPJMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x8962910", Offset = "0x8961510", VA = "0x188962910")]
	private bool BJEPADODDIB(DNIDHNKGLEC NKJOCFMOGPK, ENIOBPLBCEN BHNJKAEPJMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x8963330", Offset = "0x8961F30", VA = "0x188963330")]
	private bool IFEMLBGNAJA(DNIDHNKGLEC NKJOCFMOGPK, ENIOBPLBCEN BHNJKAEPJMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x8962E80", Offset = "0x8961A80", VA = "0x188962E80")]
	private bool GMHAONADLMN(DNIDHNKGLEC NKJOCFMOGPK, ENIOBPLBCEN BHNJKAEPJMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x8963180", Offset = "0x8961D80", VA = "0x188963180")]
	private bool HKHGKDBEDJJ(DNIDHNKGLEC NKJOCFMOGPK, ENIOBPLBCEN BHNJKAEPJMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x8962B60", Offset = "0x8961760", VA = "0x188962B60")]
	private bool DDOHAOGDABJ(DNIDHNKGLEC NKJOCFMOGPK, ENIOBPLBCEN BHNJKAEPJMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x89624F0", Offset = "0x89610F0", VA = "0x1889624F0")]
	private bool AGFMNFKDDMH(DNIDHNKGLEC NKJOCFMOGPK, ENIOBPLBCEN BHNJKAEPJMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x8963060", Offset = "0x8961C60", VA = "0x188963060")]
	private bool HEHAADBHAAH(DNIDHNKGLEC NKJOCFMOGPK, ENIOBPLBCEN BHNJKAEPJMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x8964390", Offset = "0x8962F90", VA = "0x188964390")]
	private bool NPCHLILKPDC(DNIDHNKGLEC NKJOCFMOGPK, ENIOBPLBCEN BHNJKAEPJMN)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class MBCOCJPKMMG
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
	public MBCOCJPKMMG()
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
