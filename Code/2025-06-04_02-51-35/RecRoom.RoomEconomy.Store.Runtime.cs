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
		[Cpp2IlInjected.Address(RVA = "0x87C2C30", Offset = "0x87C1430", VA = "0x1887C2C30", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2731690", Offset = "0x272FE90", VA = "0x182731690")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class PFMBPGELICJ : DBJKPIMIJJF, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private struct AEMNECEOHBL : IAsyncStateMachine
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
		public PFMBPGELICJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x87B9D70", Offset = "0x87B8570", VA = "0x1887B9D70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x87BA070", Offset = "0x87B8870", VA = "0x1887BA070", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private struct NDGDCFEPGOF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public AsyncTaskMethodBuilder<MPAEOKMMPNG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public PFMBPGELICJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public Guid customAvatarItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private TaskAwaiter<MPAEOKMMPNG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x87BC820", Offset = "0x87BB020", VA = "0x1887BC820", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x87BCAF0", Offset = "0x87BB2F0", VA = "0x1887BCAF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct BOBDEHLPLMB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public AsyncTaskMethodBuilder<List<PNBLFFBKHJH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public PFMBPGELICJ <>4__this;

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
		private List<PNBLFFBKHJH> <results>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private TaskAwaiter<List<GFAGOKJKJAJ>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x87BA0D0", Offset = "0x87B88D0", VA = "0x1887BA0D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x87BA870", Offset = "0x87B9070", VA = "0x1887BA870", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct JNNKFCMHCJD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public AsyncTaskMethodBuilder<List<PNBLFFBKHJH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public PFMBPGELICJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public IReadOnlyList<GNKIJBCJIGH> unifiedItemIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public bool convertCustomAvatarItemsToPurchasableGiftDrops;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private List<PNBLFFBKHJH> <storeItemsInInitialOrder>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private TaskAwaiter<List<GFAGOKJKJAJ>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x87BB520", Offset = "0x87B9D20", VA = "0x1887BB520", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x87BBDC0", Offset = "0x87BA5C0", VA = "0x1887BBDC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct HMEPHIGLNAP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public AsyncTaskMethodBuilder<List<GFAGOKJKJAJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public List<GFAGOKJKJAJ> customAvatarItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public PFMBPGELICJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x87BAF80", Offset = "0x87B9780", VA = "0x1887BAF80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x87BB470", Offset = "0x87B9C70", VA = "0x1887BB470", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class FBKGHEJHCHI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public GNKIJBCJIGH id;

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public FBKGHEJHCHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x87BAE80", Offset = "0x87B9680", VA = "0x1887BAE80")]
		internal bool ANBCBMHMCOL(ADAGNOEBGPC x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x87BAEC0", Offset = "0x87B96C0", VA = "0x1887BAEC0")]
		internal bool PDMEMHFLJPG(PNBLFFBKHJH x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class CIIFFOPEFJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public string itemFriendlyName;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public CIIFFOPEFJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x87BA8E0", Offset = "0x87B90E0", VA = "0x1887BA8E0")]
		internal object GINACJAJBFK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class HNHLDFCLMJK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public PFMBPGELICJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public GiftItemDTO gift;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public HNHLDFCLMJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x87BB4E0", Offset = "0x87B9CE0", VA = "0x1887BB4E0")]
		internal void JINCFCPFFGM(BalanceUpdateResponseDTO<BGJILMKKEPD> result)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct KCKHBJJNCEE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public AsyncTaskMethodBuilder<LBDOGLKEAGE<BalanceUpdateResponseDTO<BGJILMKKEPD>>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public PFMBPGELICJ <>4__this;

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
		public ANEPECIFGOK storefrontType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public AFALINLHGMI currencyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private TaskAwaiter<MPAEOKMMPNG> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private TaskAwaiter<LBDOGLKEAGE<BalanceUpdateResponseDTO<BGJILMKKEPD>>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x87BBE30", Offset = "0x87BA630", VA = "0x1887BBE30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x87BC310", Offset = "0x87BAB10", VA = "0x1887BC310", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class KNCODGAHLKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public PFMBPGELICJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public bool handleShowGiftPackage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public bool shouldConsumeGiftBoxImmediately;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public KNCODGAHLKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x87BC380", Offset = "0x87BAB80", VA = "0x1887BC380")]
		internal void BONBKGFNLIN(BalanceUpdateResponseDTO<BGJILMKKEPD> result)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct LIENOOGLIDP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public AsyncTaskMethodBuilder<List<MPAEOKMMPNG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public IReadOnlyList<Guid> itemIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public PFMBPGELICJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private TaskAwaiter<List<IFBALPNNAHD>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x87BC3C0", Offset = "0x87BABC0", VA = "0x1887BC3C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x87BC7B0", Offset = "0x87BAFB0", VA = "0x1887BC7B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct DIFKDIJBBHE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public List<PNBLFFBKHJH> storeItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public PFMBPGELICJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private int <attemptNumber>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x87BA930", Offset = "0x87B9130", VA = "0x1887BA930", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x87BAE20", Offset = "0x87B9620", VA = "0x1887BAE20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly CAFKMIHJMIN<Guid, MPAEOKMMPNG> FNOIAONKKLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private DCLKEJLJDPN OCLBOPAIHNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private CLMIFOCNCHP HPCPAHAPBEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private FEAPIENHOEM ILCIONEPKIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private BFMIBIDENPC AOIFJPKBGAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private DGALOKBDEJI KONNHIKNEBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private OKNMANBEBON ANOIHLPEACA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal EHFEBOBIOIL<Guid, MPAEOKMMPNG> IGMLAIEMECP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private bool LKNCKMOIEPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private Task IMEEDPOGEMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private CancellationTokenSource INBDONLAHHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private List<ADAGNOEBGPC> AOKONJJBEDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private LBNMPPJPHEJ? DFEFMCFIBHD;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static DBJKPIMIJJF FEFEOFOJOHE;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private List<ADAGNOEBGPC> DGFONOPBONM
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x87C1090", Offset = "0x87BF890", VA = "0x1887C1090")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private LBNMPPJPHEJ CHJHMOJHPNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x87C1850", Offset = "0x87C0050", VA = "0x1887C1850")]
		get
		{
			return default(LBNMPPJPHEJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static DBJKPIMIJJF HPECEAELCLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x87BEF90", Offset = "0x87BD790", VA = "0x1887BEF90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x87C0010", Offset = "0x87BE810", VA = "0x1887C0010")]
	private List<ADAGNOEBGPC> GNCDOHBJPPN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x87BFE30", Offset = "0x87BE630", VA = "0x1887BFE30")]
	[NOOFMBJKOEL.KNDBLKJENBF.CEKCOAHLABB]
	internal static void GIPKHEKFDMP(OIKNHNBNAFI MBKOPLBCEJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x87C2630", Offset = "0x87C0E30", VA = "0x1887C2630")]
	[RecRoom.NoEngine.Common.Preserve]
	public PFMBPGELICJ([FAPODKMFODF(null)] FEAPIENHOEM ILCIONEPKIN, [FAPODKMFODF(null)] DCLKEJLJDPN OCLBOPAIHNG, [FAPODKMFODF(null)] CLMIFOCNCHP HPCPAHAPBEO, [FAPODKMFODF(null)] BFMIBIDENPC AOIFJPKBGAP, [FAPODKMFODF(null)] DGALOKBDEJI KONNHIKNEBM, [FAPODKMFODF(null)] OKNMANBEBON ANOIHLPEACA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x87BFAE0", Offset = "0x87BE2E0", VA = "0x1887BFAE0", Slot = "1")]
	~PFMBPGELICJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x87BF6C0", Offset = "0x87BDEC0", VA = "0x1887BF6C0", Slot = "13")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x87BF730", Offset = "0x87BDF30", VA = "0x1887BF730")]
	[AsyncStateMachine(typeof(AEMNECEOHBL))]
	private Task EOGDEOFMMDC(CancellationToken GMEAHOBHMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x87BF080", Offset = "0x87BD880", VA = "0x1887BF080")]
	public void BGFNAEGCIAD(Guid OLOLBHBJOCA, MPAEOKMMPNG PKEOAHDMCPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x87BF1C0", Offset = "0x87BD9C0", VA = "0x1887BF1C0", Slot = "14")]
	public void BNNDGGMPLCI(PNBLFFBKHJH OCPCNBBDGCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x87BF820", Offset = "0x87BE020", VA = "0x1887BF820", Slot = "4")]
	public void FCPBJBDFNNE(IEnumerable<PNBLFFBKHJH> LEBPFJEOGDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x87C0B30", Offset = "0x87BF330", VA = "0x1887C0B30", Slot = "15")]
	public MPAEOKMMPNG JFLKAABGOIO(Guid FLLEHMEKPHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x87C0C30", Offset = "0x87BF430", VA = "0x1887C0C30", Slot = "5")]
	public MPAEOKMMPNG JFLKAABGOIO(PNBLFFBKHJH OCPCNBBDGCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x87C0180", Offset = "0x87BE980", VA = "0x1887C0180", Slot = "16")]
	[AsyncStateMachine(typeof(NDGDCFEPGOF))]
	public Task<MPAEOKMMPNG> GNDICKJBMGP(Guid FLLEHMEKPHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x87BF420", Offset = "0x87BDC20", VA = "0x1887BF420", Slot = "7")]
	[AsyncStateMachine(typeof(BOBDEHLPLMB))]
	public Task<List<PNBLFFBKHJH>> DBPGKIMKCJF(string BPMGKPFJEGJ, bool? FHHNDIKPMLB, bool? FNIBDDNKLDN, IEnumerable<int> AEMCEGEONNN, bool ILDIFGMHOKD, bool KILNOEAOLKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x87C1F30", Offset = "0x87C0730", VA = "0x1887C1F30", Slot = "6")]
	public PNBLFFBKHJH OLICHPKOHNP(GNKIJBCJIGH OLOLBHBJOCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x87BFED0", Offset = "0x87BE6D0", VA = "0x1887BFED0", Slot = "8")]
	[AsyncStateMachine(typeof(JNNKFCMHCJD))]
	public Task<List<PNBLFFBKHJH>> GMGIIKEHJNM(IReadOnlyList<GNKIJBCJIGH> ILIMMKIHIHN, bool LKNILGNOFDE = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x87BF9D0", Offset = "0x87BE1D0", VA = "0x1887BF9D0")]
	[AsyncStateMachine(typeof(HMEPHIGLNAP))]
	private Task<List<GFAGOKJKJAJ>> FNHIGCPLJMK(List<GFAGOKJKJAJ> OIKDMPJFCOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x87C1230", Offset = "0x87BFA30", VA = "0x1887C1230")]
	private List<PNBLFFBKHJH> MGNONCJIGJH(IReadOnlyList<GNKIJBCJIGH> ILGKDOCOKNN, IReadOnlyList<ADAGNOEBGPC> LCEKNGHFKBN, IReadOnlyList<PNBLFFBKHJH> OIKDMPJFCOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x87C08D0", Offset = "0x87BF0D0", VA = "0x1887C08D0", Slot = "9")]
	public BFIFKPBFBML<BalanceUpdateResponseDTO<BGJILMKKEPD>> IKEPBNOMPHM(Guid FLLEHMEKPHP, long DAOMOCCAFDN, GiftItemDTO PLCAJAONHMH, AFALINLHGMI BMLDAGLDFMB = AFALINLHGMI.RecCenterTokens, [Optional] long? FBLGJDILBKA, ANEPECIFGOK AEFPEPBMHMM = ANEPECIFGOK.None)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x87C0770", Offset = "0x87BEF70", VA = "0x1887C0770")]
	[AsyncStateMachine(typeof(KCKHBJJNCEE))]
	private Task<LBDOGLKEAGE<BalanceUpdateResponseDTO<BGJILMKKEPD>>> HOCDCJKACKI(Guid FLLEHMEKPHP, long DAOMOCCAFDN, GiftItemDTO PLCAJAONHMH, AFALINLHGMI BMLDAGLDFMB = AFALINLHGMI.RecCenterTokens, [Optional] long? FBLGJDILBKA, ANEPECIFGOK AEFPEPBMHMM = ANEPECIFGOK.None)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x87C0E30", Offset = "0x87BF630", VA = "0x1887C0E30", Slot = "10")]
	public BFIFKPBFBML<BalanceUpdateResponseDTO<BGJILMKKEPD>> JKEJDAHILEF(ANEPECIFGOK AEFPEPBMHMM, AFALINLHGMI BMLDAGLDFMB, int MCFDLOCHDBO, long DAOMOCCAFDN, long? FBLGJDILBKA, int HFJDLKNNLHA, bool DCGGLOPAHNC = false, bool FGADMKBLPFJ = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x87C0290", Offset = "0x87BEA90", VA = "0x1887C0290", Slot = "11")]
	public BFIFKPBFBML<BalanceUpdateResponseDTO<BGJILMKKEPD>> HENNOBILEHI(ANEPECIFGOK AEFPEPBMHMM, AFALINLHGMI BMLDAGLDFMB, int MCFDLOCHDBO, long DAOMOCCAFDN, long? FBLGJDILBKA, IReadOnlyCollection<int> GPFEICJGIFI, string ILBALOOKKCP, bool NNEBAJIMCEN, BBENDLFLDLL EGCCMFHIEFJ, int HFJDLKNNLHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x87C1A60", Offset = "0x87C0260", VA = "0x1887C1A60", Slot = "12")]
	public BFIFKPBFBML<BalanceUpdateResponseDTO<BGJILMKKEPD>> OFAGEGDILHB(ANEPECIFGOK AEFPEPBMHMM, AFALINLHGMI BMLDAGLDFMB, IReadOnlyList<int> OEBAIDHANFP, IReadOnlyList<long> IAFKJMAECBB, long? FBLGJDILBKA, int MJDKLNNDANP, string ILBALOOKKCP, bool NNEBAJIMCEN, BBENDLFLDLL EGCCMFHIEFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x87BF580", Offset = "0x87BDD80", VA = "0x1887BF580")]
	[AsyncStateMachine(typeof(LIENOOGLIDP))]
	private Task<List<MPAEOKMMPNG>> DJJAOCLLGOJ(IReadOnlyList<Guid> EBLAHNNMPCK, CancellationToken GMEAHOBHMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x87C2320", Offset = "0x87C0B20", VA = "0x1887C2320")]
	private void PNIDPLLIGCF(BalanceUpdateResponseDTO<BGJILMKKEPD> NONMNKHNEAF, bool KIDPIIOFLCK, bool FGADMKBLPFJ, bool DCGGLOPAHNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x87BFBD0", Offset = "0x87BE3D0", VA = "0x1887BFBD0")]
	private void GEPMFCBELFD(DEFMBGIMAIE NCOJJFPJFEJ, bool PHHECPPGFHO, bool KMOCAACJNPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x87C2220", Offset = "0x87C0A20", VA = "0x1887C2220")]
	[AsyncStateMachine(typeof(DIFKDIJBBHE))]
	private Task OMLAHLPAEDP(List<PNBLFFBKHJH> LEBPFJEOGDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x87BF3F0", Offset = "0x87BDBF0", VA = "0x1887BF3F0")]
	[CompilerGenerated]
	private void LNNHMIAKFHG(BalanceUpdateResponseDTO<BGJILMKKEPD> KJCFPPKBAOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x87BF3F0", Offset = "0x87BDBF0", VA = "0x1887BF3F0")]
	[CompilerGenerated]
	private void CNCIAFHPADI(BalanceUpdateResponseDTO<BGJILMKKEPD> KJCFPPKBAOB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class OACICJMNCEN : KNODCLEKIHN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly DGALOKBDEJI KHGDMKJCKCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly JEFBABGOAKF IONDGOAGFLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly COFHIHHMDIO NMBOHIJLEKM;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x87BDA20", Offset = "0x87BC220", VA = "0x1887BDA20")]
	[NOOFMBJKOEL.KNDBLKJENBF.CEKCOAHLABB]
	internal static void BGEJLCAAPFF(OIKNHNBNAFI MBKOPLBCEJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0xCC0080", Offset = "0xCBE880", VA = "0x180CC0080")]
	[RecRoom.NoEngine.Common.Preserve]
	public OACICJMNCEN([FAPODKMFODF(null)] DGALOKBDEJI KONNHIKNEBM, [FAPODKMFODF(null)] JEFBABGOAKF HLEIAPMBPDI, [FAPODKMFODF(null)] COFHIHHMDIO OIKDMPJFCOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x87BE470", Offset = "0x87BCC70", VA = "0x1887BE470")]
	private bool KNKCHGKHCAK(DLHNHIPOOHM LPJGFHNPGML, DLHNHIPOOHM CGLFEDOLDAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x87BE820", Offset = "0x87BD020", VA = "0x1887BE820", Slot = "5")]
	public IReadOnlyList<PNBLFFBKHJH> LGGOMJBOAOL(DLHNHIPOOHM KFPECMCBFDP, IReadOnlyList<PNBLFFBKHJH> DBAICDFECAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x87BCEC0", Offset = "0x87BB6C0", VA = "0x1887BCEC0", Slot = "4")]
	public bool BEAJILIKHFI(DLHNHIPOOHM KFPECMCBFDP, PNBLFFBKHJH NAGJHHJDFPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x87BEA60", Offset = "0x87BD260", VA = "0x1887BEA60")]
	private bool LNCKPMCPIPL(DLHNHIPOOHM KFPECMCBFDP, PNBLFFBKHJH NAGJHHJDFPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x87BCB60", Offset = "0x87BB360", VA = "0x1887BCB60")]
	private bool BAIAHIOCNPH(DLHNHIPOOHM KFPECMCBFDP, PNBLFFBKHJH NAGJHHJDFPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x87BDDF0", Offset = "0x87BC5F0", VA = "0x1887BDDF0")]
	private bool GPHNLIFEHDJ(DLHNHIPOOHM KFPECMCBFDP, PNBLFFBKHJH NAGJHHJDFPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x87BE510", Offset = "0x87BCD10", VA = "0x1887BE510")]
	public bool LCDHDMGKMJB(PNBLFFBKHJH OCPCNBBDGCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x87BE760", Offset = "0x87BCF60", VA = "0x1887BE760")]
	public bool LCDHDMGKMJB(MCHGFEJGFNI KDDHFAPDBIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x87BDF80", Offset = "0x87BC780", VA = "0x1887BDF80")]
	private bool HJHPJFLLKMF(Guid FLLEHMEKPHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x87BEAF0", Offset = "0x87BD2F0", VA = "0x1887BEAF0")]
	private bool MIOKBHMOMPE(DLHNHIPOOHM KFPECMCBFDP, PNBLFFBKHJH NAGJHHJDFPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x87BEB90", Offset = "0x87BD390", VA = "0x1887BEB90")]
	private bool NOELLFHEDFC(DLHNHIPOOHM KFPECMCBFDP, PNBLFFBKHJH NAGJHHJDFPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x87BED90", Offset = "0x87BD590", VA = "0x1887BED90")]
	private bool ONLDCLMFHEO(DLHNHIPOOHM KFPECMCBFDP, PNBLFFBKHJH NAGJHHJDFPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x87BEB20", Offset = "0x87BD320", VA = "0x1887BEB20")]
	private bool NGFMLGHEOJL(DLHNHIPOOHM KFPECMCBFDP, PNBLFFBKHJH NAGJHHJDFPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x87BE070", Offset = "0x87BC870", VA = "0x1887BE070")]
	private bool IIMJKCLMDEH(DLHNHIPOOHM KFPECMCBFDP, PNBLFFBKHJH NAGJHHJDFPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x87BEF20", Offset = "0x87BD720", VA = "0x1887BEF20")]
	private bool PJBBCACEHEI(DLHNHIPOOHM KFPECMCBFDP, PNBLFFBKHJH NAGJHHJDFPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x87BE000", Offset = "0x87BC800", VA = "0x1887BE000")]
	private bool IFGHPNNGCGP(DLHNHIPOOHM KFPECMCBFDP, PNBLFFBKHJH NAGJHHJDFPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x87BDA90", Offset = "0x87BC290", VA = "0x1887BDA90")]
	private bool CGFJHBNDPJM(DLHNHIPOOHM KFPECMCBFDP, PNBLFFBKHJH NAGJHHJDFPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x87BE340", Offset = "0x87BCB40", VA = "0x1887BE340")]
	private bool KKMBKHKNCPN(DLHNHIPOOHM KFPECMCBFDP, PNBLFFBKHJH NAGJHHJDFPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x87BDBB0", Offset = "0x87BC3B0", VA = "0x1887BDBB0")]
	private bool DEAMDHNOPIG(DLHNHIPOOHM KFPECMCBFDP, PNBLFFBKHJH NAGJHHJDFPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x87BE2B0", Offset = "0x87BCAB0", VA = "0x1887BE2B0")]
	private bool KKGHMBPDNHH(DLHNHIPOOHM KFPECMCBFDP, PNBLFFBKHJH NAGJHHJDFPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x87BED00", Offset = "0x87BD500", VA = "0x1887BED00")]
	private bool OEGJCAIOBBC(DLHNHIPOOHM KFPECMCBFDP, PNBLFFBKHJH NAGJHHJDFPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x87BEE90", Offset = "0x87BD690", VA = "0x1887BEE90")]
	private bool PFPBNEECAFH(DLHNHIPOOHM KFPECMCBFDP, PNBLFFBKHJH NAGJHHJDFPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x87BDC40", Offset = "0x87BC440", VA = "0x1887BDC40")]
	private bool ELCOJDMCMLK(DLHNHIPOOHM KFPECMCBFDP, PNBLFFBKHJH NAGJHHJDFPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x87BDE60", Offset = "0x87BC660", VA = "0x1887BDE60")]
	private bool HDDDAOGCGNG(DLHNHIPOOHM KFPECMCBFDP, PNBLFFBKHJH NAGJHHJDFPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x87BDCD0", Offset = "0x87BC4D0", VA = "0x1887BDCD0")]
	private bool FLOBMMGHCMB(DLHNHIPOOHM KFPECMCBFDP, PNBLFFBKHJH NAGJHHJDFPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x87BEE00", Offset = "0x87BD600", VA = "0x1887BEE00")]
	private bool PBGGLJJPGHE(DLHNHIPOOHM KFPECMCBFDP, PNBLFFBKHJH NAGJHHJDFPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x87BDD60", Offset = "0x87BC560", VA = "0x1887BDD60")]
	private bool FMLEAHLDAHM(DLHNHIPOOHM KFPECMCBFDP, PNBLFFBKHJH NAGJHHJDFPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x87BE0E0", Offset = "0x87BC8E0", VA = "0x1887BE0E0")]
	private bool IOKBBFALMNH(DLHNHIPOOHM KFPECMCBFDP, PNBLFFBKHJH NAGJHHJDFPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x87BE480", Offset = "0x87BCC80", VA = "0x1887BE480")]
	private bool KOFCNELCPPC(DLHNHIPOOHM KFPECMCBFDP, PNBLFFBKHJH NAGJHHJDFPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x87BEBB0", Offset = "0x87BD3B0", VA = "0x1887BEBB0")]
	private bool OADKHKPBIHJ(DLHNHIPOOHM KFPECMCBFDP, PNBLFFBKHJH NAGJHHJDFPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x87BE1E0", Offset = "0x87BC9E0", VA = "0x1887BE1E0")]
	private bool JNLAICIGIFI(DLHNHIPOOHM KFPECMCBFDP, PNBLFFBKHJH NAGJHHJDFPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x87BEC70", Offset = "0x87BD470", VA = "0x1887BEC70")]
	private bool OBEGGANJNLO(DLHNHIPOOHM KFPECMCBFDP, PNBLFFBKHJH NAGJHHJDFPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x87BE170", Offset = "0x87BC970", VA = "0x1887BE170")]
	private bool JHOMCHEINHM(DLHNHIPOOHM KFPECMCBFDP, PNBLFFBKHJH NAGJHHJDFPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x87BDB20", Offset = "0x87BC320", VA = "0x1887BDB20")]
	private bool CIKCJIGBKOC(DLHNHIPOOHM KFPECMCBFDP, PNBLFFBKHJH NAGJHHJDFPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x87BDEF0", Offset = "0x87BC6F0", VA = "0x1887BDEF0")]
	private bool HEOINNMADFO(DLHNHIPOOHM KFPECMCBFDP, PNBLFFBKHJH NAGJHHJDFPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x87BE400", Offset = "0x87BCC00", VA = "0x1887BE400")]
	private bool KMCGGIHPPKO(DLHNHIPOOHM KFPECMCBFDP, PNBLFFBKHJH NAGJHHJDFPB)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class LBHJJCIMPIK
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public LBHJJCIMPIK()
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
