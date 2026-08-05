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
		[Cpp2IlInjected.Address(RVA = "0x8423600", Offset = "0x8422600", VA = "0x188423600", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2643640", Offset = "0x2642640", VA = "0x182643640")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class KPIJLJGHOMP : DNCHAJGLDGG, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private struct KDJFOMHFBLP : IAsyncStateMachine
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
		public KPIJLJGHOMP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x841E800", Offset = "0x841D800", VA = "0x18841E800", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x841EB00", Offset = "0x841DB00", VA = "0x18841EB00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private struct PHAHLBAHPNO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public AsyncTaskMethodBuilder<GBONMBHCOAE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public KPIJLJGHOMP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public Guid customAvatarItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private TaskAwaiter<GBONMBHCOAE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8423110", Offset = "0x8422110", VA = "0x188423110", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x84233E0", Offset = "0x84223E0", VA = "0x1884233E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct FBDFNHINFHF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public AsyncTaskMethodBuilder<List<FBAKIBIPOMC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public KPIJLJGHOMP <>4__this;

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
		private List<FBAKIBIPOMC> <results>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private TaskAwaiter<List<EHGDCJFOLHP>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x841B190", Offset = "0x841A190", VA = "0x18841B190", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x841B940", Offset = "0x841A940", VA = "0x18841B940", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct OAGFHGHFNGB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public AsyncTaskMethodBuilder<List<FBAKIBIPOMC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public KPIJLJGHOMP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public IReadOnlyList<LDJBIDEBIAE> unifiedItemIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public bool convertCustomAvatarItemsToPurchasableGiftDrops;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private List<FBAKIBIPOMC> <storeItemsInInitialOrder>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private TaskAwaiter<List<EHGDCJFOLHP>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x84227D0", Offset = "0x84217D0", VA = "0x1884227D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x84230A0", Offset = "0x84220A0", VA = "0x1884230A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct ACBEKPBEDOB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public AsyncTaskMethodBuilder<List<EHGDCJFOLHP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public List<EHGDCJFOLHP> customAvatarItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public KPIJLJGHOMP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x841A690", Offset = "0x8419690", VA = "0x18841A690", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x841AB90", Offset = "0x8419B90", VA = "0x18841AB90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class NJLIKKLLFPH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public LDJBIDEBIAE id;

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public NJLIKKLLFPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x84226D0", Offset = "0x84216D0", VA = "0x1884226D0")]
		internal bool AJCIKCNFIHJ(FOFJDAOJGHL x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8422710", Offset = "0x8421710", VA = "0x188422710")]
		internal bool HDPMAKAIPIM(FBAKIBIPOMC x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class JGOKKCAJDIG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public string itemFriendlyName;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public JGOKKCAJDIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x841C3C0", Offset = "0x841B3C0", VA = "0x18841C3C0")]
		internal object OCJLJJNIGOO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class BEJOAAMFIEH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public KPIJLJGHOMP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public GiftItemDTO gift;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public BEJOAAMFIEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x841B150", Offset = "0x841A150", VA = "0x18841B150")]
		internal void EINOGFNGAOP(BalanceUpdateResponseDTO<GLJLLBFCNKJ> result)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct ADLCDKDKDNA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public AsyncTaskMethodBuilder<BBMBJJIMEEM<BalanceUpdateResponseDTO<GLJLLBFCNKJ>>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public KPIJLJGHOMP <>4__this;

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
		public NDHNCEHANCH storefrontType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public COAFHABICNE currencyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private TaskAwaiter<GBONMBHCOAE> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private TaskAwaiter<BBMBJJIMEEM<BalanceUpdateResponseDTO<GLJLLBFCNKJ>>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x841AC00", Offset = "0x8419C00", VA = "0x18841AC00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x841B0E0", Offset = "0x841A0E0", VA = "0x18841B0E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class GNFHPLDILIN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public KPIJLJGHOMP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public bool handleShowGiftPackage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public bool shouldConsumeGiftBoxImmediately;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public GNFHPLDILIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x841C380", Offset = "0x841B380", VA = "0x18841C380")]
		internal void APHDGLOPLCD(BalanceUpdateResponseDTO<GLJLLBFCNKJ> result)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct FPHHPMBOCBL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public AsyncTaskMethodBuilder<List<GBONMBHCOAE>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public IReadOnlyList<Guid> itemIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public KPIJLJGHOMP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private TaskAwaiter<List<PIGJKMDEGFL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x841B9B0", Offset = "0x841A9B0", VA = "0x18841B9B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x841BDC0", Offset = "0x841ADC0", VA = "0x18841BDC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct GIJNAKFOOND : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public List<FBAKIBIPOMC> storeItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public KPIJLJGHOMP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private int <attemptNumber>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x841BE30", Offset = "0x841AE30", VA = "0x18841BE30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x841C320", Offset = "0x841B320", VA = "0x18841C320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly CJAMBCKLEOP<Guid, GBONMBHCOAE> KEIDJFPGJLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private HGPCKPIAKLB HCKHHIJHPNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private GBNOFKCLMED PMFBAEBMBGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private LDBCIIKLAGJ EKPGCGJEGDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private GAFFDOHFOOF MFDAEADPNAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private OHBNFOFIAOK IJHMDBKFLOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private LPGGOLFFKPF NNAMEELADIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal FAKLKHOBCAF<Guid, GBONMBHCOAE> NNFKNMFANLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private bool DPFEMHMCJBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private Task IBHDKLCGMNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private CancellationTokenSource NNKAOINCDGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private List<FOFJDAOJGHL> EBECOKHDJBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private HLIAJHAKCLG? NEAMBHJGLGB;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static DNCHAJGLDGG KCIKNNAECHN;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private List<FOFJDAOJGHL> OPCANCPJGME
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x84219B0", Offset = "0x84209B0", VA = "0x1884219B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private HLIAJHAKCLG FNGFBNCGLLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x84205A0", Offset = "0x841F5A0", VA = "0x1884205A0")]
		get
		{
			return default(HLIAJHAKCLG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static DNCHAJGLDGG MLIJHBGBMKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x841FE40", Offset = "0x841EE40", VA = "0x18841FE40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x8421B50", Offset = "0x8420B50", VA = "0x188421B50")]
	private List<FOFJDAOJGHL> OFDPPNFBPHN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x8421910", Offset = "0x8420910", VA = "0x188421910")]
	[AOJMKBDAFKB.CMNMOAIAENM.GMCOOAPNBEN]
	internal static void OBMBKBPHDCG(AINJBKKEAIL NELIKBMJKPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x8422250", Offset = "0x8421250", VA = "0x188422250")]
	[RecRoom.NoEngine.Common.Preserve]
	public KPIJLJGHOMP([DJIFKCCBBND(null)] LDBCIIKLAGJ EKPGCGJEGDB, [DJIFKCCBBND(null)] HGPCKPIAKLB HCKHHIJHPNM, [DJIFKCCBBND(null)] GBNOFKCLMED PMFBAEBMBGM, [DJIFKCCBBND(null)] GAFFDOHFOOF MFDAEADPNAA, [DJIFKCCBBND(null)] OHBNFOFIAOK IJHMDBKFLOH, [DJIFKCCBBND(null)] LPGGOLFFKPF NNAMEELADIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x84203B0", Offset = "0x841F3B0", VA = "0x1884203B0", Slot = "1")]
	~KPIJLJGHOMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x841F910", Offset = "0x841E910", VA = "0x18841F910", Slot = "13")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x841ED20", Offset = "0x841DD20", VA = "0x18841ED20")]
	[AsyncStateMachine(typeof(KDJFOMHFBLP))]
	private Task CNGGCLLFMMO(CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x8421E00", Offset = "0x8420E00", VA = "0x188421E00")]
	public void PGAPBLEMCCH(Guid JPEKMHAKLEC, GBONMBHCOAE IJPFNOMPLPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x84207E0", Offset = "0x841F7E0", VA = "0x1884207E0", Slot = "14")]
	public void JKGALEILAFD(FBAKIBIPOMC MNNJNEDMNKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x841EB60", Offset = "0x841DB60", VA = "0x18841EB60", Slot = "4")]
	public void ALCCOBCNCOO(IEnumerable<FBAKIBIPOMC> HMGKLOBCDMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x84202A0", Offset = "0x841F2A0", VA = "0x1884202A0", Slot = "15")]
	public GBONMBHCOAE FOHOLBDCNNB(Guid DGPIPOJOJGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x84200A0", Offset = "0x841F0A0", VA = "0x1884200A0", Slot = "5")]
	public GBONMBHCOAE FOHOLBDCNNB(FBAKIBIPOMC MNNJNEDMNKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x8421340", Offset = "0x8420340", VA = "0x188421340", Slot = "16")]
	[AsyncStateMachine(typeof(PHAHLBAHPNO))]
	public Task<GBONMBHCOAE> MENOKAOHGHI(Guid DGPIPOJOJGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x841FF40", Offset = "0x841EF40", VA = "0x18841FF40", Slot = "7")]
	[AsyncStateMachine(typeof(FBDFNHINFHF))]
	public Task<List<FBAKIBIPOMC>> FOAMECILJEI(string AEBOBCGKFDJ, bool? JMAKELIFMIN, bool? MDOGCOKBHBO, IEnumerable<int> JKJKPEPJPBB, bool HOKILBDDENB, bool MGHBAALHKKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x8420A10", Offset = "0x841FA10", VA = "0x188420A10", Slot = "6")]
	public FBAKIBIPOMC LNEJKIEIELJ(LDJBIDEBIAE JPEKMHAKLEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x841F980", Offset = "0x841E980", VA = "0x18841F980", Slot = "8")]
	[AsyncStateMachine(typeof(OAGFHGHFNGB))]
	public Task<List<FBAKIBIPOMC>> EHAHEHICDGA(IReadOnlyList<LDJBIDEBIAE> OIOABLHANAP, bool CKECLPONKPH = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x841FAC0", Offset = "0x841EAC0", VA = "0x18841FAC0")]
	[AsyncStateMachine(typeof(ACBEKPBEDOB))]
	private Task<List<EHGDCJFOLHP>> ELGPMPGAAHL(List<EHGDCJFOLHP> GLELOIJPLDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x841EE10", Offset = "0x841DE10", VA = "0x18841EE10")]
	private List<FBAKIBIPOMC> COPAFEEGHKG(IReadOnlyList<LDJBIDEBIAE> EFPIPLPGCON, IReadOnlyList<FOFJDAOJGHL> KDBBENJMIBE, IReadOnlyList<FBAKIBIPOMC> GLELOIJPLDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x84216B0", Offset = "0x84206B0", VA = "0x1884216B0", Slot = "9")]
	public KGAPFDAFEHM<BalanceUpdateResponseDTO<GLJLLBFCNKJ>> NEBINCJFPLD(Guid DGPIPOJOJGM, long GAFFJGMGEBD, GiftItemDTO BMIKDHDIMIN, COAFHABICNE JIIJIDFJIGK = COAFHABICNE.RecCenterTokens, [Optional] long? FNNPIONLMMD, NDHNCEHANCH JLKOEGKPAAA = NDHNCEHANCH.None)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x8420D00", Offset = "0x841FD00", VA = "0x188420D00")]
	[AsyncStateMachine(typeof(ADLCDKDKDNA))]
	private Task<BBMBJJIMEEM<BalanceUpdateResponseDTO<GLJLLBFCNKJ>>> LPEIJOHLBDH(Guid DGPIPOJOJGM, long GAFFJGMGEBD, GiftItemDTO BMIKDHDIMIN, COAFHABICNE JIIJIDFJIGK = COAFHABICNE.RecCenterTokens, [Optional] long? FNNPIONLMMD, NDHNCEHANCH JLKOEGKPAAA = NDHNCEHANCH.None)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x8421450", Offset = "0x8420450", VA = "0x188421450", Slot = "10")]
	public KGAPFDAFEHM<BalanceUpdateResponseDTO<GLJLLBFCNKJ>> NCOMHCCCMJH(NDHNCEHANCH JLKOEGKPAAA, COAFHABICNE JIIJIDFJIGK, int LADFILOPOFK, long GAFFJGMGEBD, long? FNNPIONLMMD, int BILIHFEFION, bool DEKLHPHLMKC = false, bool LPNJNDLOAMB = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x8420E60", Offset = "0x841FE60", VA = "0x188420E60", Slot = "11")]
	public KGAPFDAFEHM<BalanceUpdateResponseDTO<GLJLLBFCNKJ>> MCGDCDIINHA(NDHNCEHANCH JLKOEGKPAAA, COAFHABICNE JIIJIDFJIGK, int LADFILOPOFK, long GAFFJGMGEBD, long? FNNPIONLMMD, IReadOnlyCollection<int> NJDPMKBMLJF, string NAAMEAFIHJI, bool HKJCMAMGEGN, IPAJFKBAJFI EOOLAKPCMOC, int BILIHFEFION)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x841F430", Offset = "0x841E430", VA = "0x18841F430", Slot = "12")]
	public KGAPFDAFEHM<BalanceUpdateResponseDTO<GLJLLBFCNKJ>> DLMEKPEIJOH(NDHNCEHANCH JLKOEGKPAAA, COAFHABICNE JIIJIDFJIGK, IReadOnlyList<int> JDKDODPOOCK, IReadOnlyList<long> PPCENPGOKME, long? FNNPIONLMMD, int NKJGLIMFDBJ, string NAAMEAFIHJI, bool HKJCMAMGEGN, IPAJFKBAJFI EOOLAKPCMOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x8421CC0", Offset = "0x8420CC0", VA = "0x188421CC0")]
	[AsyncStateMachine(typeof(FPHHPMBOCBL))]
	private Task<List<GBONMBHCOAE>> PDKNNILAFFA(IReadOnlyList<Guid> KKBBCHMNGDG, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x8421F40", Offset = "0x8420F40", VA = "0x188421F40")]
	private void POJEKHHMGCH(BalanceUpdateResponseDTO<GLJLLBFCNKJ> CGKDHHEHGIL, bool CAIJHGIFKPO, bool LPNJNDLOAMB, bool DEKLHPHLMKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x841FBD0", Offset = "0x841EBD0", VA = "0x18841FBD0")]
	private void FLJPLEKENHH(BAAIMDALMOP ENIPCLDJPLC, bool AGNDAKKEMCF, bool AMDGMFMLBJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x84204A0", Offset = "0x841F4A0", VA = "0x1884204A0")]
	[AsyncStateMachine(typeof(GIJNAKFOOND))]
	private Task GPBPNHELLNE(List<FBAKIBIPOMC> HMGKLOBCDMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x84207B0", Offset = "0x841F7B0", VA = "0x1884207B0")]
	[CompilerGenerated]
	private void JGFPMGJMKEB(BalanceUpdateResponseDTO<GLJLLBFCNKJ> OBOOAPELMPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x84207B0", Offset = "0x841F7B0", VA = "0x1884207B0")]
	[CompilerGenerated]
	private void KHPGMGAGHMG(BalanceUpdateResponseDTO<GLJLLBFCNKJ> OBOOAPELMPF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class JHFNOONNNHE : OKAKCNIMFAN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly OHBNFOFIAOK GHENBACDLJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly HBLAEJNBENG CLFPOJCJDOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly GJDJGBKCOMH MEGCAAEPDAH;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x841E120", Offset = "0x841D120", VA = "0x18841E120")]
	[AOJMKBDAFKB.CMNMOAIAENM.GMCOOAPNBEN]
	internal static void MAKIPFCGLCJ(AINJBKKEAIL NELIKBMJKPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0xC47F60", Offset = "0xC46F60", VA = "0x180C47F60")]
	[RecRoom.NoEngine.Common.Preserve]
	public JHFNOONNNHE([DJIFKCCBBND(null)] OHBNFOFIAOK IJHMDBKFLOH, [DJIFKCCBBND(null)] HBLAEJNBENG DLDECNJKBCP, [DJIFKCCBBND(null)] GJDJGBKCOMH GLELOIJPLDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x841E760", Offset = "0x841D760", VA = "0x18841E760")]
	private bool PCAHEMMEFFG(JOHNAICEDOD HGPOHMFCGAA, JOHNAICEDOD HMLGNLCCDBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x841D3A0", Offset = "0x841C3A0", VA = "0x18841D3A0", Slot = "5")]
	public IReadOnlyList<FBAKIBIPOMC> EILHABNHMDO(JOHNAICEDOD LJJLMOOCPPM, IReadOnlyList<FBAKIBIPOMC> OLCBBPLHPLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x841C7D0", Offset = "0x841B7D0", VA = "0x18841C7D0", Slot = "4")]
	public bool COKPILGCCAD(JOHNAICEDOD LJJLMOOCPPM, FBAKIBIPOMC HOJKNIMMINF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x841D660", Offset = "0x841C660", VA = "0x18841D660")]
	private bool FCIODHLALJN(JOHNAICEDOD LJJLMOOCPPM, FBAKIBIPOMC HOJKNIMMINF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x841DE20", Offset = "0x841CE20", VA = "0x18841DE20")]
	private bool MACEHCMCEBJ(JOHNAICEDOD LJJLMOOCPPM, FBAKIBIPOMC HOJKNIMMINF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x841D8D0", Offset = "0x841C8D0", VA = "0x18841D8D0")]
	private bool GLGENBHKCAC(JOHNAICEDOD LJJLMOOCPPM, FBAKIBIPOMC HOJKNIMMINF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x841DBD0", Offset = "0x841CBD0", VA = "0x18841DBD0")]
	public bool MAAKCAMNPEC(FBAKIBIPOMC MNNJNEDMNKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x841DB00", Offset = "0x841CB00", VA = "0x18841DB00")]
	public bool MAAKCAMNPEC(DKAFOOLLHHG AICNKCKFJCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x841C410", Offset = "0x841B410", VA = "0x18841C410")]
	private bool BCLKIMCDIJO(Guid DGPIPOJOJGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x841D9D0", Offset = "0x841C9D0", VA = "0x18841D9D0")]
	private bool IAFNFMAAFDM(JOHNAICEDOD LJJLMOOCPPM, FBAKIBIPOMC HOJKNIMMINF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x841E740", Offset = "0x841D740", VA = "0x18841E740")]
	private bool PBAABKLPJAC(JOHNAICEDOD LJJLMOOCPPM, FBAKIBIPOMC HOJKNIMMINF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x841E220", Offset = "0x841D220", VA = "0x18841E220")]
	private bool MBLIGLLDBFF(JOHNAICEDOD LJJLMOOCPPM, FBAKIBIPOMC HOJKNIMMINF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x841D5F0", Offset = "0x841C5F0", VA = "0x18841D5F0")]
	private bool FABPDLOHBBL(JOHNAICEDOD LJJLMOOCPPM, FBAKIBIPOMC HOJKNIMMINF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x841D330", Offset = "0x841C330", VA = "0x18841D330")]
	private bool DKBALFDAKGF(JOHNAICEDOD LJJLMOOCPPM, FBAKIBIPOMC HOJKNIMMINF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x841DA00", Offset = "0x841CA00", VA = "0x18841DA00")]
	private bool IBOKDIALDGH(JOHNAICEDOD LJJLMOOCPPM, FBAKIBIPOMC HOJKNIMMINF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x841E320", Offset = "0x841D320", VA = "0x18841E320")]
	private bool NBPNJPOPOCN(JOHNAICEDOD LJJLMOOCPPM, FBAKIBIPOMC HOJKNIMMINF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x841E770", Offset = "0x841D770", VA = "0x18841E770")]
	private bool PMGLJNNNJOL(JOHNAICEDOD LJJLMOOCPPM, FBAKIBIPOMC HOJKNIMMINF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x841E4F0", Offset = "0x841D4F0", VA = "0x18841E4F0")]
	private bool OHNDDHJADDF(JOHNAICEDOD LJJLMOOCPPM, FBAKIBIPOMC HOJKNIMMINF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x841E6B0", Offset = "0x841D6B0", VA = "0x18841E6B0")]
	private bool OPJPAHGLILC(JOHNAICEDOD LJJLMOOCPPM, FBAKIBIPOMC HOJKNIMMINF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x841E390", Offset = "0x841D390", VA = "0x18841E390")]
	private bool NIJHOIOPPEJ(JOHNAICEDOD LJJLMOOCPPM, FBAKIBIPOMC HOJKNIMMINF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x841D6F0", Offset = "0x841C6F0", VA = "0x18841D6F0")]
	private bool GBFLJCOFHFN(JOHNAICEDOD LJJLMOOCPPM, FBAKIBIPOMC HOJKNIMMINF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x841E190", Offset = "0x841D190", VA = "0x18841E190")]
	private bool MBCOGNGHAMB(JOHNAICEDOD LJJLMOOCPPM, FBAKIBIPOMC HOJKNIMMINF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x841DA70", Offset = "0x841CA70", VA = "0x18841DA70")]
	private bool KONIINILHCG(JOHNAICEDOD LJJLMOOCPPM, FBAKIBIPOMC HOJKNIMMINF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x841E5B0", Offset = "0x841D5B0", VA = "0x18841E5B0")]
	private bool OIBHEIFICAC(JOHNAICEDOD LJJLMOOCPPM, FBAKIBIPOMC HOJKNIMMINF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x841C520", Offset = "0x841B520", VA = "0x18841C520")]
	private bool BFIBOELDJNO(JOHNAICEDOD LJJLMOOCPPM, FBAKIBIPOMC HOJKNIMMINF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x841E290", Offset = "0x841D290", VA = "0x18841E290")]
	private bool MCINMNGAMDC(JOHNAICEDOD LJJLMOOCPPM, FBAKIBIPOMC HOJKNIMMINF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x841C5B0", Offset = "0x841B5B0", VA = "0x18841C5B0")]
	private bool BJPHGOBDJOJ(JOHNAICEDOD LJJLMOOCPPM, FBAKIBIPOMC HOJKNIMMINF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x841C490", Offset = "0x841B490", VA = "0x18841C490")]
	private bool BDKLEICMHNE(JOHNAICEDOD LJJLMOOCPPM, FBAKIBIPOMC HOJKNIMMINF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x841C6D0", Offset = "0x841B6D0", VA = "0x18841C6D0")]
	private bool CJDCPBLNMCF(JOHNAICEDOD LJJLMOOCPPM, FBAKIBIPOMC HOJKNIMMINF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x841D780", Offset = "0x841C780", VA = "0x18841D780")]
	private bool GCJBKDKDLCL(JOHNAICEDOD LJJLMOOCPPM, FBAKIBIPOMC HOJKNIMMINF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x841E420", Offset = "0x841D420", VA = "0x18841E420")]
	private bool NPMNEKLDAPK(JOHNAICEDOD LJJLMOOCPPM, FBAKIBIPOMC HOJKNIMMINF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x841D840", Offset = "0x841C840", VA = "0x18841D840")]
	private bool GJHBLKOPBIE(JOHNAICEDOD LJJLMOOCPPM, FBAKIBIPOMC HOJKNIMMINF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x841C760", Offset = "0x841B760", VA = "0x18841C760")]
	private bool CKKLHMANADM(JOHNAICEDOD LJJLMOOCPPM, FBAKIBIPOMC HOJKNIMMINF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x841D940", Offset = "0x841C940", VA = "0x18841D940")]
	private bool GMEKMIMIHJG(JOHNAICEDOD LJJLMOOCPPM, FBAKIBIPOMC HOJKNIMMINF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x841C640", Offset = "0x841B640", VA = "0x18841C640")]
	private bool BOILGPDHGDG(JOHNAICEDOD LJJLMOOCPPM, FBAKIBIPOMC HOJKNIMMINF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x841E640", Offset = "0x841D640", VA = "0x18841E640")]
	private bool OKALODMFIFF(JOHNAICEDOD LJJLMOOCPPM, FBAKIBIPOMC HOJKNIMMINF)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class PPHBBBBMJHN
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public PPHBBBBMJHN()
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
