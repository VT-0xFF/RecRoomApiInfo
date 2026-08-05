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
		[Cpp2IlInjected.Address(RVA = "0x890E760", Offset = "0x890D560", VA = "0x18890E760", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x286F3E0", Offset = "0x286E1E0", VA = "0x18286F3E0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class MFGDOKMKBNB : DHEAOBFIAIG, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private struct LFEMDAGIBIO : IAsyncStateMachine
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
		public MFGDOKMKBNB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8907B50", Offset = "0x8906950", VA = "0x188907B50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8907E50", Offset = "0x8906C50", VA = "0x188907E50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private struct DIEPGJJBFKJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public AsyncTaskMethodBuilder<NPPCPBJJKDA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public MFGDOKMKBNB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public Guid customAvatarItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private TaskAwaiter<NPPCPBJJKDA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8905450", Offset = "0x8904250", VA = "0x188905450", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8905720", Offset = "0x8904520", VA = "0x188905720", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct DLOMNCHOLJH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public AsyncTaskMethodBuilder<List<AMBIDEBMCDP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public MFGDOKMKBNB <>4__this;

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
		private List<AMBIDEBMCDP> <results>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private TaskAwaiter<List<FNHOEBPLBMN>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8905790", Offset = "0x8904590", VA = "0x188905790", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8905F40", Offset = "0x8904D40", VA = "0x188905F40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct KOJDGJGIDJF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public AsyncTaskMethodBuilder<List<AMBIDEBMCDP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public MFGDOKMKBNB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public IReadOnlyList<OPNNALLJDAD> unifiedItemIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public bool convertCustomAvatarItemsToPurchasableGiftDrops;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private Task <watchStorefrontTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private List<FNHOEBPLBMN> <customAvatarItems>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private List<AMBIDEBMCDP> <storeItemsInInitialOrder>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private TaskAwaiter<List<FNHOEBPLBMN>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8907040", Offset = "0x8905E40", VA = "0x188907040", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8907AE0", Offset = "0x89068E0", VA = "0x188907AE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct KHOMIHCNCKH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public AsyncTaskMethodBuilder<List<FNHOEBPLBMN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public List<FNHOEBPLBMN> customAvatarItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public MFGDOKMKBNB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8906AE0", Offset = "0x89058E0", VA = "0x188906AE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8906FD0", Offset = "0x8905DD0", VA = "0x188906FD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class CENOJBHCAAH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public OPNNALLJDAD id;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public CENOJBHCAAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8905350", Offset = "0x8904150", VA = "0x188905350")]
		internal bool AMNIOPIENJK(CBOBHFCKHLA x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8905390", Offset = "0x8904190", VA = "0x188905390")]
		internal bool JKCCLJDJCDB(AMBIDEBMCDP x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class JFDJNCEOOFE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public string itemFriendlyName;

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public JFDJNCEOOFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8906A90", Offset = "0x8905890", VA = "0x188906A90")]
		internal object CGFIIENNILK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class IKOJPOEDOAJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public MFGDOKMKBNB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public GiftItemDTO gift;

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public IKOJPOEDOAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8906A10", Offset = "0x8905810", VA = "0x188906A10")]
		internal void NCKPIDMGCMI(BalanceUpdateResponseDTO<KOAPLDEEFIF> result)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct MGKLLAFCILE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public AsyncTaskMethodBuilder<GALFEJAJFIM<BalanceUpdateResponseDTO<KOAPLDEEFIF>>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public MFGDOKMKBNB <>4__this;

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
		public MKHKBBDILNJ storefrontType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public CPLLFGEHMIB currencyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private TaskAwaiter<NPPCPBJJKDA> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TaskAwaiter<GALFEJAJFIM<BalanceUpdateResponseDTO<KOAPLDEEFIF>>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x890E050", Offset = "0x890CE50", VA = "0x18890E050", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x890E550", Offset = "0x890D350", VA = "0x18890E550", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class ILCGDBKBHIN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public MFGDOKMKBNB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public bool handleShowGiftPackage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public bool shouldConsumeGiftBoxImmediately;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public ILCGDBKBHIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8906A50", Offset = "0x8905850", VA = "0x188906A50")]
		internal void DGEEMJJHFAP(BalanceUpdateResponseDTO<KOAPLDEEFIF> result)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class ALPLNKFLLNG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public MFGDOKMKBNB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public GiftItemDTO gift;

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public ALPLNKFLLNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8905310", Offset = "0x8904110", VA = "0x188905310")]
		internal void DPGLBINIBAM(BalanceUpdateResponseDTO<KOAPLDEEFIF> result)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct GIAICOCHPBP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public AsyncTaskMethodBuilder<List<NPPCPBJJKDA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public IReadOnlyList<Guid> itemIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public MFGDOKMKBNB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private TaskAwaiter<List<GNGPFFMAHKH>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x89065A0", Offset = "0x89053A0", VA = "0x1889065A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x89069A0", Offset = "0x89057A0", VA = "0x1889069A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct DMIIHELCIMP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public List<AMBIDEBMCDP> storeItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public MFGDOKMKBNB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private int <attemptNumber>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8905FB0", Offset = "0x8904DB0", VA = "0x188905FB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8906540", Offset = "0x8905340", VA = "0x188906540", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly CAKDOJGIGBN<Guid, NPPCPBJJKDA> BKGILEGJPCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private ECACGNCICMH PKLMKAJLNOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private DENAJJEEBDC APECDPDECKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private OLNPKPHMNNE ENGNGPMGAHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private JNCNLGHKCPJ JBIBJAGEMKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private OAGLLEEAHJE LONPDLLHPJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private HGFOMCHGKEH NJOCDKGDILE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal DAOBLECFCHP<Guid, NPPCPBJJKDA> OBIOMGNLIMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private bool HDGGIMAAJCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private Task FECKALNOMIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private CancellationTokenSource KADKJLBPCOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private List<CBOBHFCKHLA> NMMBPFGNDBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private EFPKENHMFAD? ODAOEGDGCNH;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static DHEAOBFIAIG DIPJLOIABCD;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private List<CBOBHFCKHLA> FPGKNNANJDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x890CEE0", Offset = "0x890BCE0", VA = "0x18890CEE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private EFPKENHMFAD MGBIMDIPMIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x890BBD0", Offset = "0x890A9D0", VA = "0x18890BBD0")]
		get
		{
			return default(EFPKENHMFAD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static DHEAOBFIAIG ODAOEPEFKDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x890CCA0", Offset = "0x890BAA0", VA = "0x18890CCA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x890C820", Offset = "0x890B620", VA = "0x18890C820")]
	private List<CBOBHFCKHLA> JLMPCDJLDKB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x890ACF0", Offset = "0x8909AF0", VA = "0x18890ACF0")]
	[ONLJNMLDJBD.JLHCPMFEMHB.IONMKBJJIGG]
	internal static void DKGNAIFEGAN(LOAHJOOKLEP CHDHLAGMCKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x890DBD0", Offset = "0x890C9D0", VA = "0x18890DBD0")]
	[RecRoom.NoEngine.Common.Preserve]
	public MFGDOKMKBNB([OLOAAHJODHH(null)] OLNPKPHMNNE ENGNGPMGAHN, [OLOAAHJODHH(null)] ECACGNCICMH PKLMKAJLNOJ, [OLOAAHJODHH(null)] DENAJJEEBDC APECDPDECKE, [OLOAAHJODHH(null)] JNCNLGHKCPJ JBIBJAGEMKK, [OLOAAHJODHH(null)] OAGLLEEAHJE LONPDLLHPJF, [OLOAAHJODHH(null)] HGFOMCHGKEH NJOCDKGDILE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x890B440", Offset = "0x890A240", VA = "0x18890B440", Slot = "1")]
	~MFGDOKMKBNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x890AD90", Offset = "0x8909B90", VA = "0x18890AD90", Slot = "13")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x890D080", Offset = "0x890BE80", VA = "0x18890D080")]
	[AsyncStateMachine(typeof(LFEMDAGIBIO))]
	private Task OEOGFIPFOOF(CancellationToken HIMDFBHMPLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x890D170", Offset = "0x890BF70", VA = "0x18890D170")]
	public void PDMMBPPPAOE(Guid NENMJCEFFAO, NPPCPBJJKDA AOKDMDLOLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x890B210", Offset = "0x890A010", VA = "0x18890B210", Slot = "14")]
	public void FCEHANMKDOD(AMBIDEBMCDP HIDKIFCOPJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x890AE00", Offset = "0x8909C00", VA = "0x18890AE00", Slot = "4")]
	public void EGHCFJHOFIJ(IEnumerable<AMBIDEBMCDP> FFGBADGFNKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x890CB90", Offset = "0x890B990", VA = "0x18890CB90", Slot = "15")]
	public NPPCPBJJKDA KCBLENEEJJH(Guid AIGIABENOBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x890C990", Offset = "0x890B790", VA = "0x18890C990", Slot = "5")]
	public NPPCPBJJKDA KCBLENEEJJH(AMBIDEBMCDP HIDKIFCOPJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x890BDE0", Offset = "0x890ABE0", VA = "0x18890BDE0", Slot = "16")]
	[AsyncStateMachine(typeof(DIEPGJJBFKJ))]
	public Task<NPPCPBJJKDA> GPMFICCFMEF(Guid AIGIABENOBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x890D970", Offset = "0x890C770", VA = "0x18890D970", Slot = "7")]
	[AsyncStateMachine(typeof(DLOMNCHOLJH))]
	public Task<List<AMBIDEBMCDP>> PLJGOHGFJPD(string MNDMGBEDAFK, bool? FMPIANAGKPD, bool? IHMBPLIPEED, IEnumerable<int> CIHOFOFJGBJ, bool AMNDCFJPBCG, bool IEGBHFLIBCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x890A600", Offset = "0x8909400", VA = "0x18890A600", Slot = "6")]
	public AMBIDEBMCDP BGBIFOPGAEL(OPNNALLJDAD NENMJCEFFAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x890CDA0", Offset = "0x890BBA0", VA = "0x18890CDA0", Slot = "8")]
	[AsyncStateMachine(typeof(KOJDGJGIDJF))]
	public Task<List<AMBIDEBMCDP>> LGKOHMDIOIK(IReadOnlyList<OPNNALLJDAD> DGMGDKAOELK, bool GIBPBAGJGEG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x890D2B0", Offset = "0x890C0B0", VA = "0x18890D2B0")]
	[AsyncStateMachine(typeof(KHOMIHCNCKH))]
	private Task<List<FNHOEBPLBMN>> PGFGDPBEHIH(List<FNHOEBPLBMN> EPCMJFMMJNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x890C200", Offset = "0x890B000", VA = "0x18890C200")]
	private List<AMBIDEBMCDP> JKHKGMPKGAJ(IReadOnlyList<OPNNALLJDAD> CKEGENKLFPI, IReadOnlyList<CBOBHFCKHLA> DCGNIGNNHAM, IReadOnlyList<AMBIDEBMCDP> EPCMJFMMJNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x890AFB0", Offset = "0x8909DB0", VA = "0x18890AFB0", Slot = "9")]
	public CEBCBDBEPBJ<BalanceUpdateResponseDTO<KOAPLDEEFIF>> EKLCCAAGKOP(Guid AIGIABENOBD, long BFEFNAJNOEK, GiftItemDTO DOLPAAEMPHG, CPLLFGEHMIB JKEBOOMJBEM = CPLLFGEHMIB.RecCenterTokens, [Optional] long? ELHNLGFIJLB, MKHKBBDILNJ EHCAMONKEKN = MKHKBBDILNJ.None)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x890AB90", Offset = "0x8909990", VA = "0x18890AB90")]
	[AsyncStateMachine(typeof(MGKLLAFCILE))]
	private Task<GALFEJAJFIM<BalanceUpdateResponseDTO<KOAPLDEEFIF>>> DFHEIIOFMFN(Guid AIGIABENOBD, long BFEFNAJNOEK, GiftItemDTO DOLPAAEMPHG, CPLLFGEHMIB JKEBOOMJBEM = CPLLFGEHMIB.RecCenterTokens, [Optional] long? ELHNLGFIJLB, MKHKBBDILNJ EHCAMONKEKN = MKHKBBDILNJ.None)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x890A310", Offset = "0x8909110", VA = "0x18890A310", Slot = "10")]
	public CEBCBDBEPBJ<BalanceUpdateResponseDTO<KOAPLDEEFIF>> AMJPKHLKFJB(MKHKBBDILNJ EHCAMONKEKN, CPLLFGEHMIB JKEBOOMJBEM, int ODIHMGLNBFC, long BFEFNAJNOEK, long? ELHNLGFIJLB, int JFIPLHFJNFN, bool KOMCGEOKMNL = false, bool HAGFKFFGDBL = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x890B530", Offset = "0x890A330", VA = "0x18890B530", Slot = "11")]
	public CEBCBDBEPBJ<BalanceUpdateResponseDTO<KOAPLDEEFIF>> GDPDBMJMOFC(MKHKBBDILNJ EHCAMONKEKN, CPLLFGEHMIB JKEBOOMJBEM, int ODIHMGLNBFC, long BFEFNAJNOEK, long? ELHNLGFIJLB, IReadOnlyCollection<int> DBHMKOENMLL, string IIHOFBLPONF, bool OFHFDKICAII, KCJNALNJGNJ MNKDOBJMLJL, int JFIPLHFJNFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x890D3C0", Offset = "0x890C1C0", VA = "0x18890D3C0", Slot = "12")]
	public CEBCBDBEPBJ<BalanceUpdateResponseDTO<KOAPLDEEFIF>> PGHDDHIHLGJ(MKHKBBDILNJ EHCAMONKEKN, CPLLFGEHMIB JKEBOOMJBEM, IReadOnlyList<OPNNALLJDAD> OJKDHKGIGNM, IReadOnlyList<long> MOPMBFJBNFH, [Optional] long? ELHNLGFIJLB, [Optional][CanBeNull] GiftItemDTO DOLPAAEMPHG, [Optional] Guid? BKJIHHAJOBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x890BA90", Offset = "0x890A890", VA = "0x18890BA90")]
	[AsyncStateMachine(typeof(GIAICOCHPBP))]
	private Task<List<NPPCPBJJKDA>> GFOKDFNCDOI(IReadOnlyList<Guid> OJKDHKGIGNM, CancellationToken HIMDFBHMPLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x890BEF0", Offset = "0x890ACF0", VA = "0x18890BEF0")]
	private void IINNEFKIIOI(BalanceUpdateResponseDTO<KOAPLDEEFIF> OOMHGCGFMGO, bool GGNCDGBLCOJ, bool HAGFKFFGDBL, bool KOMCGEOKMNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x890A8F0", Offset = "0x89096F0", VA = "0x18890A8F0")]
	private void BMLEOOBMBLJ(ALNKEGAOCKD JGIGPOOJLFC, bool FFHLKCHIDOB, bool FPHHBAEBBOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x890DAD0", Offset = "0x890C8D0", VA = "0x18890DAD0")]
	[AsyncStateMachine(typeof(DMIIHELCIMP))]
	private Task POHBMOILBJP(List<AMBIDEBMCDP> FFGBADGFNKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x890AB60", Offset = "0x8909960", VA = "0x18890AB60")]
	[CompilerGenerated]
	private void DDAAOHPGABG(BalanceUpdateResponseDTO<KOAPLDEEFIF> OHLBIIOAJDL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class LHCPOFAACMK : FPPKBINEIDA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly OAGLLEEAHJE NNPIJGDJHFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly ADJKJNNEFOL EANLIOIACCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly EAEOLKENPLA MDHEPEBLKAC;

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x890A200", Offset = "0x8909000", VA = "0x18890A200")]
	[ONLJNMLDJBD.JLHCPMFEMHB.IONMKBJJIGG]
	internal static void NPDNKFNEHEP(LOAHJOOKLEP CHDHLAGMCKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0xD42A30", Offset = "0xD41830", VA = "0x180D42A30")]
	[RecRoom.NoEngine.Common.Preserve]
	public LHCPOFAACMK([OLOAAHJODHH(null)] OAGLLEEAHJE LONPDLLHPJF, [OLOAAHJODHH(null)] ADJKJNNEFOL JHAJHLFJFJD, [OLOAAHJODHH(null)] EAEOLKENPLA EPCMJFMMJNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x890A300", Offset = "0x8909100", VA = "0x18890A300")]
	private bool PMIBLDDFHIF(KMJNGAEKLCL CLHGLLPMAEL, KMJNGAEKLCL OJPMOAFECJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x89093E0", Offset = "0x89081E0", VA = "0x1889093E0", Slot = "5")]
	public IReadOnlyList<AMBIDEBMCDP> DPGDPHLCBDP(KMJNGAEKLCL LCAFMLMCLOE, IReadOnlyList<AMBIDEBMCDP> HPGGKMKJGLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x8908870", Offset = "0x8907670", VA = "0x188908870", Slot = "4")]
	public bool CBCEFGGJIAF(KMJNGAEKLCL LCAFMLMCLOE, AMBIDEBMCDP EHKDLJBBGDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x8909BE0", Offset = "0x89089E0", VA = "0x188909BE0")]
	private bool LKMEKHJKKCE(KMJNGAEKLCL LCAFMLMCLOE, AMBIDEBMCDP EHKDLJBBGDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x8907EB0", Offset = "0x8906CB0", VA = "0x188907EB0")]
	private bool ANADDPHOFNA(KMJNGAEKLCL LCAFMLMCLOE, AMBIDEBMCDP EHKDLJBBGDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x89086E0", Offset = "0x89074E0", VA = "0x1889086E0")]
	private bool BLBKHGCKHEF(KMJNGAEKLCL LCAFMLMCLOE, AMBIDEBMCDP EHKDLJBBGDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x8908220", Offset = "0x8907020", VA = "0x188908220")]
	public bool BANKAIFFAOF(AMBIDEBMCDP HIDKIFCOPJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x8908470", Offset = "0x8907270", VA = "0x188908470")]
	public bool BANKAIFFAOF(KNCBLIHIANP GCPCKKDFCNK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x8909AD0", Offset = "0x89088D0", VA = "0x188909AD0")]
	private bool JPKAMKMNAMC(Guid AIGIABENOBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x8909950", Offset = "0x8908750", VA = "0x188909950")]
	private bool GHEGJFLHDDE(KMJNGAEKLCL LCAFMLMCLOE, AMBIDEBMCDP EHKDLJBBGDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x8909810", Offset = "0x8908610", VA = "0x188909810")]
	private bool FJJOKLGKOIF(KMJNGAEKLCL LCAFMLMCLOE, AMBIDEBMCDP EHKDLJBBGDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x8909FA0", Offset = "0x8908DA0", VA = "0x188909FA0")]
	private bool NHLKGGOMNMK(KMJNGAEKLCL LCAFMLMCLOE, AMBIDEBMCDP EHKDLJBBGDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x89099F0", Offset = "0x89087F0", VA = "0x1889099F0")]
	private bool HLONLMCCIPH(KMJNGAEKLCL LCAFMLMCLOE, AMBIDEBMCDP EHKDLJBBGDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x8909EA0", Offset = "0x8908CA0", VA = "0x188909EA0")]
	private bool NAEAJOOLGOK(KMJNGAEKLCL LCAFMLMCLOE, AMBIDEBMCDP EHKDLJBBGDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x8909E30", Offset = "0x8908C30", VA = "0x188909E30")]
	private bool MDNIOHOFCED(KMJNGAEKLCL LCAFMLMCLOE, AMBIDEBMCDP EHKDLJBBGDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x8909980", Offset = "0x8908780", VA = "0x188909980")]
	private bool HEPAANBAEHM(KMJNGAEKLCL LCAFMLMCLOE, AMBIDEBMCDP EHKDLJBBGDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x8908750", Offset = "0x8907550", VA = "0x188908750")]
	private bool BPBOKBDIHIN(KMJNGAEKLCL LCAFMLMCLOE, AMBIDEBMCDP EHKDLJBBGDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x89096C0", Offset = "0x89084C0", VA = "0x1889096C0")]
	private bool FCFLJNKGDLB(KMJNGAEKLCL LCAFMLMCLOE, AMBIDEBMCDP EHKDLJBBGDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x89098C0", Offset = "0x89086C0", VA = "0x1889098C0")]
	private bool FLGKNHMKAMP(KMJNGAEKLCL LCAFMLMCLOE, AMBIDEBMCDP EHKDLJBBGDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x89085C0", Offset = "0x89073C0", VA = "0x1889085C0")]
	private bool BBOBCJBKLNO(KMJNGAEKLCL LCAFMLMCLOE, AMBIDEBMCDP EHKDLJBBGDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x89087E0", Offset = "0x89075E0", VA = "0x1889087E0")]
	private bool BPEFLIKBLMK(KMJNGAEKLCL LCAFMLMCLOE, AMBIDEBMCDP EHKDLJBBGDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x890A010", Offset = "0x8908E10", VA = "0x18890A010")]
	private bool NKIAJFJMJHM(KMJNGAEKLCL LCAFMLMCLOE, AMBIDEBMCDP EHKDLJBBGDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x8909F10", Offset = "0x8908D10", VA = "0x188909F10")]
	private bool NCAJIHJLOFI(KMJNGAEKLCL LCAFMLMCLOE, AMBIDEBMCDP EHKDLJBBGDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x890A0A0", Offset = "0x8908EA0", VA = "0x18890A0A0")]
	private bool NNBEFENOHMM(KMJNGAEKLCL LCAFMLMCLOE, AMBIDEBMCDP EHKDLJBBGDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x8909D30", Offset = "0x8908B30", VA = "0x188909D30")]
	private bool LNNKOPFENKN(KMJNGAEKLCL LCAFMLMCLOE, AMBIDEBMCDP EHKDLJBBGDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x8909780", Offset = "0x8908580", VA = "0x188909780")]
	private bool FILDBBJFJFH(KMJNGAEKLCL LCAFMLMCLOE, AMBIDEBMCDP EHKDLJBBGDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x8908530", Offset = "0x8907330", VA = "0x188908530")]
	private bool BBEMKEODJAG(KMJNGAEKLCL LCAFMLMCLOE, AMBIDEBMCDP EHKDLJBBGDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x8909B50", Offset = "0x8908950", VA = "0x188909B50")]
	private bool KNPOLBBIIMD(KMJNGAEKLCL LCAFMLMCLOE, AMBIDEBMCDP EHKDLJBBGDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x8908650", Offset = "0x8907450", VA = "0x188908650")]
	private bool BKCCAJANANH(KMJNGAEKLCL LCAFMLMCLOE, AMBIDEBMCDP EHKDLJBBGDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x8909C70", Offset = "0x8908A70", VA = "0x188909C70")]
	private bool LMAMOIKAEOO(KMJNGAEKLCL LCAFMLMCLOE, AMBIDEBMCDP EHKDLJBBGDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x890A130", Offset = "0x8908F30", VA = "0x18890A130")]
	private bool NNCONJFPCKP(KMJNGAEKLCL LCAFMLMCLOE, AMBIDEBMCDP EHKDLJBBGDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x8909630", Offset = "0x8908430", VA = "0x188909630")]
	private bool EFMMCAGIKAO(KMJNGAEKLCL LCAFMLMCLOE, AMBIDEBMCDP EHKDLJBBGDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x8909DC0", Offset = "0x8908BC0", VA = "0x188909DC0")]
	private bool MCCOLHNNGOO(KMJNGAEKLCL LCAFMLMCLOE, AMBIDEBMCDP EHKDLJBBGDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x8909830", Offset = "0x8908630", VA = "0x188909830")]
	private bool FJMJPNGHDAA(KMJNGAEKLCL LCAFMLMCLOE, AMBIDEBMCDP EHKDLJBBGDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x890A270", Offset = "0x8909070", VA = "0x18890A270")]
	private bool ONKOEDADCKA(KMJNGAEKLCL LCAFMLMCLOE, AMBIDEBMCDP EHKDLJBBGDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x8909A60", Offset = "0x8908860", VA = "0x188909A60")]
	private bool JLBHOAONEOB(KMJNGAEKLCL LCAFMLMCLOE, AMBIDEBMCDP EHKDLJBBGDB)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class GNLNCCKEALF
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
	public GNLNCCKEALF()
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
