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
		[Cpp2IlInjected.Address(RVA = "0x84096A0", Offset = "0x8407CA0", VA = "0x1884096A0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2645EC0", Offset = "0x26444C0", VA = "0x182645EC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x84048F0", Offset = "0x8402EF0", VA = "0x1884048F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8404BF0", Offset = "0x84031F0", VA = "0x188404BF0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x84091C0", Offset = "0x84077C0", VA = "0x1884091C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8409490", Offset = "0x8407A90", VA = "0x188409490", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x84012A0", Offset = "0x83FF8A0", VA = "0x1884012A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8401A50", Offset = "0x8400050", VA = "0x188401A50", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x84088B0", Offset = "0x8406EB0", VA = "0x1884088B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8409150", Offset = "0x8407750", VA = "0x188409150", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x84007A0", Offset = "0x83FEDA0", VA = "0x1884007A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8400CA0", Offset = "0x83FF2A0", VA = "0x188400CA0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public NJLIKKLLFPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x84087B0", Offset = "0x8406DB0", VA = "0x1884087B0")]
		internal bool AJCIKCNFIHJ(FOFJDAOJGHL x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x84087F0", Offset = "0x8406DF0", VA = "0x1884087F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public JGOKKCAJDIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x84024B0", Offset = "0x8400AB0", VA = "0x1884024B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public BEJOAAMFIEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8401260", Offset = "0x83FF860", VA = "0x188401260")]
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
		[Cpp2IlInjected.Address(RVA = "0x8400D10", Offset = "0x83FF310", VA = "0x188400D10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x84011F0", Offset = "0x83FF7F0", VA = "0x1884011F0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public GNFHPLDILIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8402470", Offset = "0x8400A70", VA = "0x188402470")]
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
		[Cpp2IlInjected.Address(RVA = "0x8401AC0", Offset = "0x84000C0", VA = "0x188401AC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8401EB0", Offset = "0x84004B0", VA = "0x188401EB0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x8401F20", Offset = "0x8400520", VA = "0x188401F20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8402410", Offset = "0x8400A10", VA = "0x188402410", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x8407A90", Offset = "0x8406090", VA = "0x188407A90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private HLIAJHAKCLG FNGFBNCGLLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8406670", Offset = "0x8404C70", VA = "0x188406670")]
		get
		{
			return default(HLIAJHAKCLG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static DNCHAJGLDGG MLIJHBGBMKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8405F30", Offset = "0x8404530", VA = "0x188405F30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x8407C30", Offset = "0x8406230", VA = "0x188407C30")]
	private List<FOFJDAOJGHL> OFDPPNFBPHN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x84079F0", Offset = "0x8405FF0", VA = "0x1884079F0")]
	[AOJMKBDAFKB.CMNMOAIAENM.GMCOOAPNBEN]
	internal static void OBMBKBPHDCG(AINJBKKEAIL NELIKBMJKPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x8408340", Offset = "0x8406940", VA = "0x188408340")]
	[RecRoom.NoEngine.Common.Preserve]
	public KPIJLJGHOMP([DJIFKCCBBND(null)] LDBCIIKLAGJ EKPGCGJEGDB, [DJIFKCCBBND(null)] HGPCKPIAKLB HCKHHIJHPNM, [DJIFKCCBBND(null)] GBNOFKCLMED PMFBAEBMBGM, [DJIFKCCBBND(null)] GAFFDOHFOOF MFDAEADPNAA, [DJIFKCCBBND(null)] OHBNFOFIAOK IJHMDBKFLOH, [DJIFKCCBBND(null)] LPGGOLFFKPF NNAMEELADIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x8406480", Offset = "0x8404A80", VA = "0x188406480", Slot = "1")]
	~KPIJLJGHOMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x8405A00", Offset = "0x8404000", VA = "0x188405A00", Slot = "13")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x8404E10", Offset = "0x8403410", VA = "0x188404E10")]
	[AsyncStateMachine(typeof(KDJFOMHFBLP))]
	private Task CNGGCLLFMMO(CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x8407EE0", Offset = "0x84064E0", VA = "0x188407EE0")]
	public void PGAPBLEMCCH(Guid JPEKMHAKLEC, GBONMBHCOAE IJPFNOMPLPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x84068C0", Offset = "0x8404EC0", VA = "0x1884068C0", Slot = "14")]
	public void JKGALEILAFD(FBAKIBIPOMC MNNJNEDMNKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x8404C50", Offset = "0x8403250", VA = "0x188404C50", Slot = "4")]
	public void ALCCOBCNCOO(IEnumerable<FBAKIBIPOMC> HMGKLOBCDMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x8406380", Offset = "0x8404980", VA = "0x188406380", Slot = "15")]
	public GBONMBHCOAE FOHOLBDCNNB(Guid DGPIPOJOJGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x8406180", Offset = "0x8404780", VA = "0x188406180", Slot = "5")]
	public GBONMBHCOAE FOHOLBDCNNB(FBAKIBIPOMC MNNJNEDMNKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x8407420", Offset = "0x8405A20", VA = "0x188407420", Slot = "16")]
	[AsyncStateMachine(typeof(PHAHLBAHPNO))]
	public Task<GBONMBHCOAE> MENOKAOHGHI(Guid DGPIPOJOJGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x8406020", Offset = "0x8404620", VA = "0x188406020", Slot = "7")]
	[AsyncStateMachine(typeof(FBDFNHINFHF))]
	public Task<List<FBAKIBIPOMC>> FOAMECILJEI(string AEBOBCGKFDJ, bool? JMAKELIFMIN, bool? MDOGCOKBHBO, IEnumerable<int> JKJKPEPJPBB, bool HOKILBDDENB, bool MGHBAALHKKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x8406AF0", Offset = "0x84050F0", VA = "0x188406AF0", Slot = "6")]
	public FBAKIBIPOMC LNEJKIEIELJ(LDJBIDEBIAE JPEKMHAKLEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x8405A70", Offset = "0x8404070", VA = "0x188405A70", Slot = "8")]
	[AsyncStateMachine(typeof(OAGFHGHFNGB))]
	public Task<List<FBAKIBIPOMC>> EHAHEHICDGA(IReadOnlyList<LDJBIDEBIAE> OIOABLHANAP, bool CKECLPONKPH = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x8405BB0", Offset = "0x84041B0", VA = "0x188405BB0")]
	[AsyncStateMachine(typeof(ACBEKPBEDOB))]
	private Task<List<EHGDCJFOLHP>> ELGPMPGAAHL(List<EHGDCJFOLHP> GLELOIJPLDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x8404F00", Offset = "0x8403500", VA = "0x188404F00")]
	private List<FBAKIBIPOMC> COPAFEEGHKG(IReadOnlyList<LDJBIDEBIAE> EFPIPLPGCON, IReadOnlyList<FOFJDAOJGHL> KDBBENJMIBE, IReadOnlyList<FBAKIBIPOMC> GLELOIJPLDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x8407790", Offset = "0x8405D90", VA = "0x188407790", Slot = "9")]
	public KGAPFDAFEHM<BalanceUpdateResponseDTO<GLJLLBFCNKJ>> NEBINCJFPLD(Guid DGPIPOJOJGM, long GAFFJGMGEBD, GiftItemDTO BMIKDHDIMIN, COAFHABICNE JIIJIDFJIGK = COAFHABICNE.RecCenterTokens, [Optional] long? FNNPIONLMMD, NDHNCEHANCH JLKOEGKPAAA = NDHNCEHANCH.None)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x8406DE0", Offset = "0x84053E0", VA = "0x188406DE0")]
	[AsyncStateMachine(typeof(ADLCDKDKDNA))]
	private Task<BBMBJJIMEEM<BalanceUpdateResponseDTO<GLJLLBFCNKJ>>> LPEIJOHLBDH(Guid DGPIPOJOJGM, long GAFFJGMGEBD, GiftItemDTO BMIKDHDIMIN, COAFHABICNE JIIJIDFJIGK = COAFHABICNE.RecCenterTokens, [Optional] long? FNNPIONLMMD, NDHNCEHANCH JLKOEGKPAAA = NDHNCEHANCH.None)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x8407530", Offset = "0x8405B30", VA = "0x188407530", Slot = "10")]
	public KGAPFDAFEHM<BalanceUpdateResponseDTO<GLJLLBFCNKJ>> NCOMHCCCMJH(NDHNCEHANCH JLKOEGKPAAA, COAFHABICNE JIIJIDFJIGK, int LADFILOPOFK, long GAFFJGMGEBD, long? FNNPIONLMMD, int BILIHFEFION, bool DEKLHPHLMKC = false, bool LPNJNDLOAMB = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x8406F40", Offset = "0x8405540", VA = "0x188406F40", Slot = "11")]
	public KGAPFDAFEHM<BalanceUpdateResponseDTO<GLJLLBFCNKJ>> MCGDCDIINHA(NDHNCEHANCH JLKOEGKPAAA, COAFHABICNE JIIJIDFJIGK, int LADFILOPOFK, long GAFFJGMGEBD, long? FNNPIONLMMD, IReadOnlyCollection<int> NJDPMKBMLJF, string NAAMEAFIHJI, bool HKJCMAMGEGN, IPAJFKBAJFI EOOLAKPCMOC, int BILIHFEFION)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x8405520", Offset = "0x8403B20", VA = "0x188405520", Slot = "12")]
	public KGAPFDAFEHM<BalanceUpdateResponseDTO<GLJLLBFCNKJ>> DLMEKPEIJOH(NDHNCEHANCH JLKOEGKPAAA, COAFHABICNE JIIJIDFJIGK, IReadOnlyList<int> JDKDODPOOCK, IReadOnlyList<long> PPCENPGOKME, long? FNNPIONLMMD, int NKJGLIMFDBJ, string NAAMEAFIHJI, bool HKJCMAMGEGN, IPAJFKBAJFI EOOLAKPCMOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x8407DA0", Offset = "0x84063A0", VA = "0x188407DA0")]
	[AsyncStateMachine(typeof(FPHHPMBOCBL))]
	private Task<List<GBONMBHCOAE>> PDKNNILAFFA(IReadOnlyList<Guid> KKBBCHMNGDG, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x8408030", Offset = "0x8406630", VA = "0x188408030")]
	private void POJEKHHMGCH(BalanceUpdateResponseDTO<GLJLLBFCNKJ> CGKDHHEHGIL, bool CAIJHGIFKPO, bool LPNJNDLOAMB, bool DEKLHPHLMKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x8405CC0", Offset = "0x84042C0", VA = "0x188405CC0")]
	private void FLJPLEKENHH(BAAIMDALMOP ENIPCLDJPLC, bool AGNDAKKEMCF, bool AMDGMFMLBJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x8406570", Offset = "0x8404B70", VA = "0x188406570")]
	[AsyncStateMachine(typeof(GIJNAKFOOND))]
	private Task GPBPNHELLNE(List<FBAKIBIPOMC> HMGKLOBCDMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x8406890", Offset = "0x8404E90", VA = "0x188406890")]
	[CompilerGenerated]
	private void JGFPMGJMKEB(BalanceUpdateResponseDTO<GLJLLBFCNKJ> OBOOAPELMPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x8406890", Offset = "0x8404E90", VA = "0x188406890")]
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
	[Cpp2IlInjected.Address(RVA = "0x8404210", Offset = "0x8402810", VA = "0x188404210")]
	[AOJMKBDAFKB.CMNMOAIAENM.GMCOOAPNBEN]
	internal static void MAKIPFCGLCJ(AINJBKKEAIL NELIKBMJKPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0xC46E90", Offset = "0xC45490", VA = "0x180C46E90")]
	[RecRoom.NoEngine.Common.Preserve]
	public JHFNOONNNHE([DJIFKCCBBND(null)] OHBNFOFIAOK IJHMDBKFLOH, [DJIFKCCBBND(null)] HBLAEJNBENG DLDECNJKBCP, [DJIFKCCBBND(null)] GJDJGBKCOMH GLELOIJPLDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x8404850", Offset = "0x8402E50", VA = "0x188404850")]
	private bool PCAHEMMEFFG(JOHNAICEDOD HGPOHMFCGAA, JOHNAICEDOD HMLGNLCCDBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x8403490", Offset = "0x8401A90", VA = "0x188403490", Slot = "5")]
	public IReadOnlyList<FBAKIBIPOMC> EILHABNHMDO(JOHNAICEDOD LJJLMOOCPPM, IReadOnlyList<FBAKIBIPOMC> OLCBBPLHPLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x84028C0", Offset = "0x8400EC0", VA = "0x1884028C0", Slot = "4")]
	public bool COKPILGCCAD(JOHNAICEDOD LJJLMOOCPPM, FBAKIBIPOMC HOJKNIMMINF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x8403750", Offset = "0x8401D50", VA = "0x188403750")]
	private bool FCIODHLALJN(JOHNAICEDOD LJJLMOOCPPM, FBAKIBIPOMC HOJKNIMMINF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x8403F10", Offset = "0x8402510", VA = "0x188403F10")]
	private bool MACEHCMCEBJ(JOHNAICEDOD LJJLMOOCPPM, FBAKIBIPOMC HOJKNIMMINF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x84039C0", Offset = "0x8401FC0", VA = "0x1884039C0")]
	private bool GLGENBHKCAC(JOHNAICEDOD LJJLMOOCPPM, FBAKIBIPOMC HOJKNIMMINF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x8403CC0", Offset = "0x84022C0", VA = "0x188403CC0")]
	public bool MAAKCAMNPEC(FBAKIBIPOMC MNNJNEDMNKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x8403BF0", Offset = "0x84021F0", VA = "0x188403BF0")]
	public bool MAAKCAMNPEC(DKAFOOLLHHG AICNKCKFJCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x8402500", Offset = "0x8400B00", VA = "0x188402500")]
	private bool BCLKIMCDIJO(Guid DGPIPOJOJGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x8403AC0", Offset = "0x84020C0", VA = "0x188403AC0")]
	private bool IAFNFMAAFDM(JOHNAICEDOD LJJLMOOCPPM, FBAKIBIPOMC HOJKNIMMINF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x8404830", Offset = "0x8402E30", VA = "0x188404830")]
	private bool PBAABKLPJAC(JOHNAICEDOD LJJLMOOCPPM, FBAKIBIPOMC HOJKNIMMINF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x8404310", Offset = "0x8402910", VA = "0x188404310")]
	private bool MBLIGLLDBFF(JOHNAICEDOD LJJLMOOCPPM, FBAKIBIPOMC HOJKNIMMINF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x84036E0", Offset = "0x8401CE0", VA = "0x1884036E0")]
	private bool FABPDLOHBBL(JOHNAICEDOD LJJLMOOCPPM, FBAKIBIPOMC HOJKNIMMINF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x8403420", Offset = "0x8401A20", VA = "0x188403420")]
	private bool DKBALFDAKGF(JOHNAICEDOD LJJLMOOCPPM, FBAKIBIPOMC HOJKNIMMINF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x8403AF0", Offset = "0x84020F0", VA = "0x188403AF0")]
	private bool IBOKDIALDGH(JOHNAICEDOD LJJLMOOCPPM, FBAKIBIPOMC HOJKNIMMINF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x8404410", Offset = "0x8402A10", VA = "0x188404410")]
	private bool NBPNJPOPOCN(JOHNAICEDOD LJJLMOOCPPM, FBAKIBIPOMC HOJKNIMMINF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x8404860", Offset = "0x8402E60", VA = "0x188404860")]
	private bool PMGLJNNNJOL(JOHNAICEDOD LJJLMOOCPPM, FBAKIBIPOMC HOJKNIMMINF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x84045E0", Offset = "0x8402BE0", VA = "0x1884045E0")]
	private bool OHNDDHJADDF(JOHNAICEDOD LJJLMOOCPPM, FBAKIBIPOMC HOJKNIMMINF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x84047A0", Offset = "0x8402DA0", VA = "0x1884047A0")]
	private bool OPJPAHGLILC(JOHNAICEDOD LJJLMOOCPPM, FBAKIBIPOMC HOJKNIMMINF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x8404480", Offset = "0x8402A80", VA = "0x188404480")]
	private bool NIJHOIOPPEJ(JOHNAICEDOD LJJLMOOCPPM, FBAKIBIPOMC HOJKNIMMINF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x84037E0", Offset = "0x8401DE0", VA = "0x1884037E0")]
	private bool GBFLJCOFHFN(JOHNAICEDOD LJJLMOOCPPM, FBAKIBIPOMC HOJKNIMMINF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x8404280", Offset = "0x8402880", VA = "0x188404280")]
	private bool MBCOGNGHAMB(JOHNAICEDOD LJJLMOOCPPM, FBAKIBIPOMC HOJKNIMMINF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x8403B60", Offset = "0x8402160", VA = "0x188403B60")]
	private bool KONIINILHCG(JOHNAICEDOD LJJLMOOCPPM, FBAKIBIPOMC HOJKNIMMINF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x84046A0", Offset = "0x8402CA0", VA = "0x1884046A0")]
	private bool OIBHEIFICAC(JOHNAICEDOD LJJLMOOCPPM, FBAKIBIPOMC HOJKNIMMINF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x8402610", Offset = "0x8400C10", VA = "0x188402610")]
	private bool BFIBOELDJNO(JOHNAICEDOD LJJLMOOCPPM, FBAKIBIPOMC HOJKNIMMINF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x8404380", Offset = "0x8402980", VA = "0x188404380")]
	private bool MCINMNGAMDC(JOHNAICEDOD LJJLMOOCPPM, FBAKIBIPOMC HOJKNIMMINF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x84026A0", Offset = "0x8400CA0", VA = "0x1884026A0")]
	private bool BJPHGOBDJOJ(JOHNAICEDOD LJJLMOOCPPM, FBAKIBIPOMC HOJKNIMMINF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x8402580", Offset = "0x8400B80", VA = "0x188402580")]
	private bool BDKLEICMHNE(JOHNAICEDOD LJJLMOOCPPM, FBAKIBIPOMC HOJKNIMMINF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x84027C0", Offset = "0x8400DC0", VA = "0x1884027C0")]
	private bool CJDCPBLNMCF(JOHNAICEDOD LJJLMOOCPPM, FBAKIBIPOMC HOJKNIMMINF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x8403870", Offset = "0x8401E70", VA = "0x188403870")]
	private bool GCJBKDKDLCL(JOHNAICEDOD LJJLMOOCPPM, FBAKIBIPOMC HOJKNIMMINF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x8404510", Offset = "0x8402B10", VA = "0x188404510")]
	private bool NPMNEKLDAPK(JOHNAICEDOD LJJLMOOCPPM, FBAKIBIPOMC HOJKNIMMINF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x8403930", Offset = "0x8401F30", VA = "0x188403930")]
	private bool GJHBLKOPBIE(JOHNAICEDOD LJJLMOOCPPM, FBAKIBIPOMC HOJKNIMMINF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x8402850", Offset = "0x8400E50", VA = "0x188402850")]
	private bool CKKLHMANADM(JOHNAICEDOD LJJLMOOCPPM, FBAKIBIPOMC HOJKNIMMINF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x8403A30", Offset = "0x8402030", VA = "0x188403A30")]
	private bool GMEKMIMIHJG(JOHNAICEDOD LJJLMOOCPPM, FBAKIBIPOMC HOJKNIMMINF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x8402730", Offset = "0x8400D30", VA = "0x188402730")]
	private bool BOILGPDHGDG(JOHNAICEDOD LJJLMOOCPPM, FBAKIBIPOMC HOJKNIMMINF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x8404730", Offset = "0x8402D30", VA = "0x188404730")]
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
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
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
