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
		[Cpp2IlInjected.Address(RVA = "0x8600920", Offset = "0x85FF520", VA = "0x188600920", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x27CE7F0", Offset = "0x27CD3F0", VA = "0x1827CE7F0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class OHNPGKHHJJF : NHGPNFHMOLO, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private struct ANOLAPPDEEL : IAsyncStateMachine
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
		public OHNPGKHHJJF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x85F79F0", Offset = "0x85F65F0", VA = "0x1885F79F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x85F7CF0", Offset = "0x85F68F0", VA = "0x1885F7CF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private struct ABKFAMMKPFM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public AsyncTaskMethodBuilder<OPABKCAANGP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public OHNPGKHHJJF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public Guid customAvatarItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private TaskAwaiter<OPABKCAANGP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x85F76B0", Offset = "0x85F62B0", VA = "0x1885F76B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x85F7980", Offset = "0x85F6580", VA = "0x1885F7980", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct GKMBIPPCLAL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public AsyncTaskMethodBuilder<List<KDBKLMKLCNH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public OHNPGKHHJJF <>4__this;

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
		private List<KDBKLMKLCNH> <results>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private TaskAwaiter<List<DOIGMHDFEGI>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x85F8A10", Offset = "0x85F7610", VA = "0x1885F8A10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x85F91C0", Offset = "0x85F7DC0", VA = "0x1885F91C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct NPONGEOGPLF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public AsyncTaskMethodBuilder<List<KDBKLMKLCNH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public OHNPGKHHJJF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public IReadOnlyList<FDPPFDIGHCK> unifiedItemIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public bool convertCustomAvatarItemsToPurchasableGiftDrops;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private Task <watchStorefrontTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private List<DOIGMHDFEGI> <customAvatarItems>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private List<KDBKLMKLCNH> <storeItemsInInitialOrder>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private TaskAwaiter<List<DOIGMHDFEGI>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x85FC040", Offset = "0x85FAC40", VA = "0x1885FC040", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x85FCAC0", Offset = "0x85FB6C0", VA = "0x1885FCAC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct MADPLMFHCOE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public AsyncTaskMethodBuilder<List<DOIGMHDFEGI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public List<DOIGMHDFEGI> customAvatarItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public OHNPGKHHJJF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x85F9690", Offset = "0x85F8290", VA = "0x1885F9690", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x85F9B90", Offset = "0x85F8790", VA = "0x1885F9B90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class EHCPAEIPDOJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public FDPPFDIGHCK id;

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public EHCPAEIPDOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x85F8380", Offset = "0x85F6F80", VA = "0x1885F8380")]
		internal bool GJLCILMKEDF(ELBHACMOKDM x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x85F83C0", Offset = "0x85F6FC0", VA = "0x1885F83C0")]
		internal bool PLIOCCJCOKI(KDBKLMKLCNH x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class MMIBIEEIGPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public string itemFriendlyName;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public MMIBIEEIGPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x85F9C00", Offset = "0x85F8800", VA = "0x1885F9C00")]
		internal object IJOMPKLBGIB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class BIIFLFJIAHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public OHNPGKHHJJF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public GiftItemDTO gift;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public BIIFLFJIAHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x85F8340", Offset = "0x85F6F40", VA = "0x1885F8340")]
		internal void NPJGEACJLPL(BalanceUpdateResponseDTO<KAIMCOJOBEB> result)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct EJOKPBDPELB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public AsyncTaskMethodBuilder<ALLNJJBFKMK<BalanceUpdateResponseDTO<KAIMCOJOBEB>>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public OHNPGKHHJJF <>4__this;

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
		public CNFHKDPOPCB storefrontType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public LCIBBKHKFDM currencyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private TaskAwaiter<OPABKCAANGP> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TaskAwaiter<ALLNJJBFKMK<BalanceUpdateResponseDTO<KAIMCOJOBEB>>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x85F8480", Offset = "0x85F7080", VA = "0x1885F8480", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x85F8960", Offset = "0x85F7560", VA = "0x1885F8960", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class GHLCOMLDLMM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public OHNPGKHHJJF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public bool handleShowGiftPackage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public bool shouldConsumeGiftBoxImmediately;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public GHLCOMLDLMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x85F89D0", Offset = "0x85F75D0", VA = "0x1885F89D0")]
		internal void IJBCEFDNCPL(BalanceUpdateResponseDTO<KAIMCOJOBEB> result)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct IDACIGGPHCM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public AsyncTaskMethodBuilder<List<OPABKCAANGP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public IReadOnlyList<Guid> itemIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public OHNPGKHHJJF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private TaskAwaiter<List<HPFGCHMOFKB>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x85F9230", Offset = "0x85F7E30", VA = "0x1885F9230", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x85F9620", Offset = "0x85F8220", VA = "0x1885F9620", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct BGLCGIEPPGI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public List<KDBKLMKLCNH> storeItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public OHNPGKHHJJF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private int <attemptNumber>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x85F7D50", Offset = "0x85F6950", VA = "0x1885F7D50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x85F82E0", Offset = "0x85F6EE0", VA = "0x1885F82E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly NOGAPAGBMOJ<Guid, OPABKCAANGP> CFMJJMNFHDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private ICBOPEHOHOA FMGIFFECKIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private PDBEJEAKDAH KJOIFAMMHAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private ODAJJOAKOPA DHLCDOJOEAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private KBBKAPLIFBM BHAGIEDNLME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private EEHKELBBLDP AFGGAEFCDEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private AHEAEJOKBNI BKHLAMDGECL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal BFMIMIINNAC<Guid, OPABKCAANGP> PHJANIIHKMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private bool HPDIEOLMMOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private Task LHNCKAAJHCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private CancellationTokenSource OIHOFOJADMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private List<ELBHACMOKDM> LFNPFEAMNAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private AFBCFJFPJGH? GKDMJJCNBBN;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static NHGPNFHMOLO GHEKJPIMJLD;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private List<ELBHACMOKDM> NJKFCHKGHHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x85FF170", Offset = "0x85FDD70", VA = "0x1885FF170")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private AFBCFJFPJGH LEADHDCFBJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x85FE490", Offset = "0x85FD090", VA = "0x1885FE490")]
		get
		{
			return default(AFBCFJFPJGH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static NHGPNFHMOLO LBPNLDGACAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x85FCB30", Offset = "0x85FB730", VA = "0x1885FCB30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x85FCC20", Offset = "0x85FB820", VA = "0x1885FCC20")]
	private List<ELBHACMOKDM> BFFOLEDNDEN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x8600270", Offset = "0x85FEE70", VA = "0x188600270")]
	[IGNGJLOKDFM.CHOHDINDLHJ.JBEAKNHCNNG]
	internal static void OMKCNNEBHOD(PFGPAPHADOM MHCMGFKMEEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x8600310", Offset = "0x85FEF10", VA = "0x188600310")]
	[RecRoom.NoEngine.Common.Preserve]
	public OHNPGKHHJJF([GFNPNOLPMKK(null)] ODAJJOAKOPA DHLCDOJOEAI, [GFNPNOLPMKK(null)] ICBOPEHOHOA FMGIFFECKIH, [GFNPNOLPMKK(null)] PDBEJEAKDAH KJOIFAMMHAM, [GFNPNOLPMKK(null)] KBBKAPLIFBM BHAGIEDNLME, [GFNPNOLPMKK(null)] EEHKELBBLDP AFGGAEFCDEL, [GFNPNOLPMKK(null)] AHEAEJOKBNI BKHLAMDGECL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x85FE1A0", Offset = "0x85FCDA0", VA = "0x1885FE1A0", Slot = "1")]
	~OHNPGKHHJJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x85FD140", Offset = "0x85FBD40", VA = "0x1885FD140", Slot = "13")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x85FE3A0", Offset = "0x85FCFA0", VA = "0x1885FE3A0")]
	[AsyncStateMachine(typeof(ANOLAPPDEEL))]
	private Task GJGAGHFPLFH(CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x85FCFD0", Offset = "0x85FBBD0", VA = "0x1885FCFD0")]
	public void CJMDDCHADHN(Guid DGLGMEAJHHO, OPABKCAANGP OOBJMPOODGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x85FDF70", Offset = "0x85FCB70", VA = "0x1885FDF70", Slot = "14")]
	public void FKGFGHJNHGJ(KDBKLMKLCNH GCAAIHKGLKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x85FD4C0", Offset = "0x85FC0C0", VA = "0x1885FD4C0", Slot = "4")]
	public void EONFJNCEMHI(IEnumerable<KDBKLMKLCNH> ECECCIIPJMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x85FEB20", Offset = "0x85FD720", VA = "0x1885FEB20", Slot = "15")]
	public OPABKCAANGP IKNAIIPAMDD(Guid BONHDLJDKPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x85FE920", Offset = "0x85FD520", VA = "0x1885FE920", Slot = "5")]
	public OPABKCAANGP IKNAIIPAMDD(KDBKLMKLCNH GCAAIHKGLKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x85FD680", Offset = "0x85FC280", VA = "0x1885FD680", Slot = "16")]
	[AsyncStateMachine(typeof(ABKFAMMKPFM))]
	public Task<OPABKCAANGP> FBHKJFOONMN(Guid BONHDLJDKPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x85FD790", Offset = "0x85FC390", VA = "0x1885FD790", Slot = "7")]
	[AsyncStateMachine(typeof(GKMBIPPCLAL))]
	public Task<List<KDBKLMKLCNH>> FEHKMJDAFGF(string BDAGCMHDAHC, bool? JLNGNIOLIBJ, bool? BCGHLLDHAHF, IEnumerable<int> EAPECAEOAJI, bool BDLKGJEHJPP, bool HKHAHCGEGFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x85FF6B0", Offset = "0x85FE2B0", VA = "0x1885FF6B0", Slot = "6")]
	public KDBKLMKLCNH MJLGGMGJPPA(FDPPFDIGHCK DGLGMEAJHHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x85FF310", Offset = "0x85FDF10", VA = "0x1885FF310", Slot = "8")]
	[AsyncStateMachine(typeof(NPONGEOGPLF))]
	public Task<List<KDBKLMKLCNH>> JLMEBCNIGHK(IReadOnlyList<FDPPFDIGHCK> EBCHKCGOFHB, bool CFIKLONAGCN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x85FE290", Offset = "0x85FCE90", VA = "0x1885FE290")]
	[AsyncStateMachine(typeof(MADPLMFHCOE))]
	private Task<List<DOIGMHDFEGI>> GHPCIKGNLEC(List<DOIGMHDFEGI> NIEADMJLLKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x85FF9A0", Offset = "0x85FE5A0", VA = "0x1885FF9A0")]
	private List<KDBKLMKLCNH> NNOLCGGIKKE(IReadOnlyList<FDPPFDIGHCK> JPNLJNFALFC, IReadOnlyList<ELBHACMOKDM> GHJDHDPMNGH, IReadOnlyList<KDBKLMKLCNH> NIEADMJLLKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x85FF450", Offset = "0x85FE050", VA = "0x1885FF450", Slot = "9")]
	public KLHBLGBFFDH<BalanceUpdateResponseDTO<KAIMCOJOBEB>> MJKGJLEIECC(Guid BONHDLJDKPI, long FKFFAOOEBPM, GiftItemDTO MPGFHAHPDAG, LCIBBKHKFDM ICNOCECLEOB = LCIBBKHKFDM.RecCenterTokens, [Optional] long? ECLIHGNCBNL, CNFHKDPOPCB CEJPAANJMMG = CNFHKDPOPCB.None)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x85FD8F0", Offset = "0x85FC4F0", VA = "0x1885FD8F0")]
	[AsyncStateMachine(typeof(EJOKPBDPELB))]
	private Task<ALLNJJBFKMK<BalanceUpdateResponseDTO<KAIMCOJOBEB>>> FJGJIBEPPOK(Guid BONHDLJDKPI, long FKFFAOOEBPM, GiftItemDTO MPGFHAHPDAG, LCIBBKHKFDM ICNOCECLEOB = LCIBBKHKFDM.RecCenterTokens, [Optional] long? ECLIHGNCBNL, CNFHKDPOPCB CEJPAANJMMG = CNFHKDPOPCB.None)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x85FFFC0", Offset = "0x85FEBC0", VA = "0x1885FFFC0", Slot = "10")]
	public KLHBLGBFFDH<BalanceUpdateResponseDTO<KAIMCOJOBEB>> OLPJKHPAOKN(CNFHKDPOPCB CEJPAANJMMG, LCIBBKHKFDM ICNOCECLEOB, int MCLJGAMAJCN, long FKFFAOOEBPM, long? ECLIHGNCBNL, int DOBHAFGJFKB, bool LMBKIEDLHBJ = false, bool PFBIMPAGHCJ = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x85FEC20", Offset = "0x85FD820", VA = "0x1885FEC20", Slot = "11")]
	public KLHBLGBFFDH<BalanceUpdateResponseDTO<KAIMCOJOBEB>> JAANKPNHAHN(CNFHKDPOPCB CEJPAANJMMG, LCIBBKHKFDM ICNOCECLEOB, int MCLJGAMAJCN, long FKFFAOOEBPM, long? ECLIHGNCBNL, IReadOnlyCollection<int> FDPGIPLHEDF, string FNFIPKNHEOF, bool LLPIKAKNOOG, MCBMEFFIOFP BPIFODJOJND, int DOBHAFGJFKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x85FDA50", Offset = "0x85FC650", VA = "0x1885FDA50", Slot = "12")]
	public KLHBLGBFFDH<BalanceUpdateResponseDTO<KAIMCOJOBEB>> FJKAGIMFMOF(CNFHKDPOPCB CEJPAANJMMG, LCIBBKHKFDM ICNOCECLEOB, IReadOnlyList<int> GCABOFCPLOC, IReadOnlyList<long> LBNDDOCDKGM, long? ECLIHGNCBNL, int IINIFBPLADE, string FNFIPKNHEOF, bool LLPIKAKNOOG, MCBMEFFIOFP BPIFODJOJND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x85FCE90", Offset = "0x85FBA90", VA = "0x1885FCE90")]
	[AsyncStateMachine(typeof(IDACIGGPHCM))]
	private Task<List<OPABKCAANGP>> CDELBDPKMDD(IReadOnlyList<Guid> PLMOCNAPOCP, CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x85FD1B0", Offset = "0x85FBDB0", VA = "0x1885FD1B0")]
	private void EJDDPIHLEFK(BalanceUpdateResponseDTO<KAIMCOJOBEB> KLLFGGKFBFO, bool KNNKJPMMIEO, bool PFBIMPAGHCJ, bool LMBKIEDLHBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x85FE6B0", Offset = "0x85FD2B0", VA = "0x1885FE6B0")]
	private void ICFKJGNAINF(IPABDLAJPJF BFAMGJFGGIP, bool APHDJBHHFMF, bool GPKOEMGGDLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x85FCD90", Offset = "0x85FB990", VA = "0x1885FCD90")]
	[AsyncStateMachine(typeof(BGLCGIEPPGI))]
	private Task CBPLFAAOKCK(List<KDBKLMKLCNH> ECECCIIPJMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x85FD110", Offset = "0x85FBD10", VA = "0x1885FD110")]
	[CompilerGenerated]
	private void DANMEHOGAPJ(BalanceUpdateResponseDTO<KAIMCOJOBEB> DBJBIPJCIKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x85FD110", Offset = "0x85FBD10", VA = "0x1885FD110")]
	[CompilerGenerated]
	private void PJFOLNMMCOJ(BalanceUpdateResponseDTO<KAIMCOJOBEB> DBJBIPJCIKA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class NHIHNPFJONG : JLMAHBBIALA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly EEHKELBBLDP AKLGHFECICN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly OJBKGFGPJKC JEEPLOLKEDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly AJODNFFKMAA AILJFDJHBJJ;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x85FB770", Offset = "0x85FA370", VA = "0x1885FB770")]
	[IGNGJLOKDFM.CHOHDINDLHJ.JBEAKNHCNNG]
	internal static void MACELCFKDEA(PFGPAPHADOM MHCMGFKMEEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0xCEAF50", Offset = "0xCE9B50", VA = "0x180CEAF50")]
	[RecRoom.NoEngine.Common.Preserve]
	public NHIHNPFJONG([GFNPNOLPMKK(null)] EEHKELBBLDP AFGGAEFCDEL, [GFNPNOLPMKK(null)] OJBKGFGPJKC MDNMLJAODAC, [GFNPNOLPMKK(null)] AJODNFFKMAA NIEADMJLLKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x85FBA20", Offset = "0x85FA620", VA = "0x1885FBA20")]
	private bool MJKIHIFHJDP(LONIDNALMFG JFHAAJINOIF, LONIDNALMFG CAJADMOILAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x85FB3F0", Offset = "0x85F9FF0", VA = "0x1885FB3F0", Slot = "5")]
	public IReadOnlyList<KDBKLMKLCNH> JICNIMGAGBE(LONIDNALMFG DLLLPOOPJLC, IReadOnlyList<KDBKLMKLCNH> OGLPOFDOMIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x85F9D60", Offset = "0x85F8960", VA = "0x1885F9D60", Slot = "4")]
	public bool AFDDDBGPBKK(LONIDNALMFG DLLLPOOPJLC, KDBKLMKLCNH ONKLOOMCJOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x85FA930", Offset = "0x85F9530", VA = "0x1885FA930")]
	private bool BBOAKCLGKAM(LONIDNALMFG DLLLPOOPJLC, KDBKLMKLCNH ONKLOOMCJOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x85FB060", Offset = "0x85F9C60", VA = "0x1885FB060")]
	private bool JFOCJPADGEE(LONIDNALMFG DLLLPOOPJLC, KDBKLMKLCNH ONKLOOMCJOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x85FB6D0", Offset = "0x85FA2D0", VA = "0x1885FB6D0")]
	private bool KBKIGMPDBPE(LONIDNALMFG DLLLPOOPJLC, KDBKLMKLCNH ONKLOOMCJOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x85FBCB0", Offset = "0x85FA8B0", VA = "0x1885FBCB0")]
	public bool PAFGFPCILBH(KDBKLMKLCNH GCAAIHKGLKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x85FBF00", Offset = "0x85FAB00", VA = "0x1885FBF00")]
	public bool PAFGFPCILBH(IGJKBFHNFPI CPDACKADFEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x85F9C50", Offset = "0x85F8850", VA = "0x1885F9C50")]
	private bool ABFLJFMADDP(Guid BONHDLJDKPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x85FB740", Offset = "0x85FA340", VA = "0x1885FB740")]
	private bool LJGNCKBICIH(LONIDNALMFG DLLLPOOPJLC, KDBKLMKLCNH ONKLOOMCJOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x85FAE00", Offset = "0x85F9A00", VA = "0x1885FAE00")]
	private bool GIEFGDFKIGE(LONIDNALMFG DLLLPOOPJLC, KDBKLMKLCNH ONKLOOMCJOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x85FB940", Offset = "0x85FA540", VA = "0x1885FB940")]
	private bool MFLHJJJBHKC(LONIDNALMFG DLLLPOOPJLC, KDBKLMKLCNH ONKLOOMCJOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x85FBFD0", Offset = "0x85FABD0", VA = "0x1885FBFD0")]
	private bool PHFIPDDOHNN(LONIDNALMFG DLLLPOOPJLC, KDBKLMKLCNH ONKLOOMCJOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x85FBC40", Offset = "0x85FA840", VA = "0x1885FBC40")]
	private bool NLLKICDGCPN(LONIDNALMFG DLLLPOOPJLC, KDBKLMKLCNH ONKLOOMCJOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x85FA8C0", Offset = "0x85F94C0", VA = "0x1885FA8C0")]
	private bool AKBFMPLEJDA(LONIDNALMFG DLLLPOOPJLC, KDBKLMKLCNH ONKLOOMCJOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x85FAD00", Offset = "0x85F9900", VA = "0x1885FAD00")]
	private bool GEJCFDEPNPP(LONIDNALMFG DLLLPOOPJLC, KDBKLMKLCNH ONKLOOMCJOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x85FB640", Offset = "0x85FA240", VA = "0x1885FB640")]
	private bool JNHLGAIHJHH(LONIDNALMFG DLLLPOOPJLC, KDBKLMKLCNH ONKLOOMCJOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x85FBAF0", Offset = "0x85FA6F0", VA = "0x1885FBAF0")]
	private bool NCPHNHPEGMA(LONIDNALMFG DLLLPOOPJLC, KDBKLMKLCNH ONKLOOMCJOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x85FAFD0", Offset = "0x85F9BD0", VA = "0x1885FAFD0")]
	private bool JFBDCDMABEP(LONIDNALMFG DLLLPOOPJLC, KDBKLMKLCNH ONKLOOMCJOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x85F9CD0", Offset = "0x85F88D0", VA = "0x1885F9CD0")]
	private bool ADEFFCOPMFJ(LONIDNALMFG DLLLPOOPJLC, KDBKLMKLCNH ONKLOOMCJOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x85FAC70", Offset = "0x85F9870", VA = "0x1885FAC70")]
	private bool DHPFPFKEKHD(LONIDNALMFG DLLLPOOPJLC, KDBKLMKLCNH ONKLOOMCJOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x85FAEB0", Offset = "0x85F9AB0", VA = "0x1885FAEB0")]
	private bool IKEIEFFEHDG(LONIDNALMFG DLLLPOOPJLC, KDBKLMKLCNH ONKLOOMCJOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x85FBBB0", Offset = "0x85FA7B0", VA = "0x1885FBBB0")]
	private bool NHFMKOBLIAL(LONIDNALMFG DLLLPOOPJLC, KDBKLMKLCNH ONKLOOMCJOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x85FA9C0", Offset = "0x85F95C0", VA = "0x1885FA9C0")]
	private bool BEOCCPBJODM(LONIDNALMFG DLLLPOOPJLC, KDBKLMKLCNH ONKLOOMCJOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x85FAAC0", Offset = "0x85F96C0", VA = "0x1885FAAC0")]
	private bool CKHINBKAKCA(LONIDNALMFG DLLLPOOPJLC, KDBKLMKLCNH ONKLOOMCJOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x85FB7E0", Offset = "0x85FA3E0", VA = "0x1885FB7E0")]
	private bool MCCCJEGKHBH(LONIDNALMFG DLLLPOOPJLC, KDBKLMKLCNH ONKLOOMCJOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x85FAE20", Offset = "0x85F9A20", VA = "0x1885FAE20")]
	private bool IFHKMNNNCBP(LONIDNALMFG DLLLPOOPJLC, KDBKLMKLCNH ONKLOOMCJOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x85FAF40", Offset = "0x85F9B40", VA = "0x1885FAF40")]
	private bool JCBHNFMBMBL(LONIDNALMFG DLLLPOOPJLC, KDBKLMKLCNH ONKLOOMCJOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x85FAD70", Offset = "0x85F9970", VA = "0x1885FAD70")]
	private bool GHLPCAEFGFK(LONIDNALMFG DLLLPOOPJLC, KDBKLMKLCNH ONKLOOMCJOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x85FBA30", Offset = "0x85FA630", VA = "0x1885FBA30")]
	private bool MOAEAOOBHFP(LONIDNALMFG DLLLPOOPJLC, KDBKLMKLCNH ONKLOOMCJOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x85FB870", Offset = "0x85FA470", VA = "0x1885FB870")]
	private bool MENMOKPAABB(LONIDNALMFG DLLLPOOPJLC, KDBKLMKLCNH ONKLOOMCJOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x85FAB50", Offset = "0x85F9750", VA = "0x1885FAB50")]
	private bool CNGGFJGEGEL(LONIDNALMFG DLLLPOOPJLC, KDBKLMKLCNH ONKLOOMCJOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x85FAA50", Offset = "0x85F9650", VA = "0x1885FAA50")]
	private bool BGKNHGIFEPK(LONIDNALMFG DLLLPOOPJLC, KDBKLMKLCNH ONKLOOMCJOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x85FABE0", Offset = "0x85F97E0", VA = "0x1885FABE0")]
	private bool DBEBOKGILFO(LONIDNALMFG DLLLPOOPJLC, KDBKLMKLCNH ONKLOOMCJOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x85FB360", Offset = "0x85F9F60", VA = "0x1885FB360")]
	private bool JHDEPNHEBOP(LONIDNALMFG DLLLPOOPJLC, KDBKLMKLCNH ONKLOOMCJOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x85FB9B0", Offset = "0x85FA5B0", VA = "0x1885FB9B0")]
	private bool MHFOBFAKIOI(LONIDNALMFG DLLLPOOPJLC, KDBKLMKLCNH ONKLOOMCJOM)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class GCLFJLNKBGD
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
	public GCLFJLNKBGD()
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
