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
		[Cpp2IlInjected.Address(RVA = "0x8BF2E80", Offset = "0x8BF1C80", VA = "0x188BF2E80", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2941360", Offset = "0x2940160", VA = "0x182941360")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class FMOOGAAGBGL : GKIGJPCJCGA, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private struct BABBHGBDMAP : IAsyncStateMachine
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
		public FMOOGAAGBGL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8BE9460", Offset = "0x8BE8260", VA = "0x188BE9460", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8BE9760", Offset = "0x8BE8560", VA = "0x188BE9760", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private struct NFPIEKJFOMB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public AsyncTaskMethodBuilder<ECFDNOLKKJI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public FMOOGAAGBGL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public Guid customAvatarItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private TaskAwaiter<ECFDNOLKKJI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8BF29A0", Offset = "0x8BF17A0", VA = "0x188BF29A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8BF2C70", Offset = "0x8BF1A70", VA = "0x188BF2C70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct MOKGHCAGJGE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public AsyncTaskMethodBuilder<List<OBCKBDNDNAI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public FMOOGAAGBGL <>4__this;

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
		private List<OBCKBDNDNAI> <results>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private TaskAwaiter<List<FAFHAGKOPBD>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8BF1CB0", Offset = "0x8BF0AB0", VA = "0x188BF1CB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8BF2470", Offset = "0x8BF1270", VA = "0x188BF2470", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct CGCOLNOLANO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public AsyncTaskMethodBuilder<List<OBCKBDNDNAI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public FMOOGAAGBGL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public IReadOnlyList<KLAOHEICPLP> unifiedItemIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public bool convertCustomAvatarItemsToPurchasableGiftDrops;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private Task <watchStorefrontTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private List<FAFHAGKOPBD> <customAvatarItems>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private List<OBCKBDNDNAI> <storeItemsInInitialOrder>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private TaskAwaiter<List<FAFHAGKOPBD>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8BE97C0", Offset = "0x8BE85C0", VA = "0x188BE97C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8BEA240", Offset = "0x8BE9040", VA = "0x188BEA240", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct EAPAMJCPHOP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public AsyncTaskMethodBuilder<List<FAFHAGKOPBD>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public List<FAFHAGKOPBD> customAvatarItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public FMOOGAAGBGL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8BEA9A0", Offset = "0x8BE97A0", VA = "0x188BEA9A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8BEAEA0", Offset = "0x8BE9CA0", VA = "0x188BEAEA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class CJFBAPJKHGB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public KLAOHEICPLP id;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public CJFBAPJKHGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8BEA370", Offset = "0x8BE9170", VA = "0x188BEA370")]
		internal bool MOKNMEGCPJF(FEMEFNJLDFL x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8BEA2B0", Offset = "0x8BE90B0", VA = "0x188BEA2B0")]
		internal bool LNCGLDIKKFP(OBCKBDNDNAI x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class NDHJPCJANHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public string itemFriendlyName;

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public NDHJPCJANHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8BF2950", Offset = "0x8BF1750", VA = "0x188BF2950")]
		internal object BLFHLBCHNBH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class JFFCFAADMFG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public FMOOGAAGBGL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public GiftItemDTO gift;

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public JFFCFAADMFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8BEF200", Offset = "0x8BEE000", VA = "0x188BEF200")]
		internal void PGOBBBOJKCG(BalanceUpdateResponseDTO<CJJJLJHDAJJ> result)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct FIDGKFEEBEI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public AsyncTaskMethodBuilder<LBBCKEKMIBK<BalanceUpdateResponseDTO<CJJJLJHDAJJ>>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public FMOOGAAGBGL <>4__this;

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
		public BKMPEOKAHJC storefrontType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public COKNLBOGDAO currencyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private TaskAwaiter<ECFDNOLKKJI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TaskAwaiter<LBBCKEKMIBK<BalanceUpdateResponseDTO<CJJJLJHDAJJ>>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8BEAF10", Offset = "0x8BE9D10", VA = "0x188BEAF10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8BEB410", Offset = "0x8BEA210", VA = "0x188BEB410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class JMHJHNEJMHB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public FMOOGAAGBGL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public bool handleShowGiftPackage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public bool shouldConsumeGiftBoxImmediately;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public JMHJHNEJMHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8BEF240", Offset = "0x8BEE040", VA = "0x188BEF240")]
		internal void OFEAJADHLIL(BalanceUpdateResponseDTO<CJJJLJHDAJJ> result)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class MAABJAKBNOO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public FMOOGAAGBGL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public GiftItemDTO gift;

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public MAABJAKBNOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8BF1C70", Offset = "0x8BF0A70", VA = "0x188BF1C70")]
		internal void OHIFIAAEOJK(BalanceUpdateResponseDTO<CJJJLJHDAJJ> result)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct NDBCGLMENKK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public AsyncTaskMethodBuilder<List<ECFDNOLKKJI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public IReadOnlyList<Guid> itemIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public FMOOGAAGBGL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private TaskAwaiter<List<HCAAEADMMIL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8BF24E0", Offset = "0x8BF12E0", VA = "0x188BF24E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8BF28E0", Offset = "0x8BF16E0", VA = "0x188BF28E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct CMOHFHDMAAL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public List<OBCKBDNDNAI> storeItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public FMOOGAAGBGL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private int <attemptNumber>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8BEA3B0", Offset = "0x8BE91B0", VA = "0x188BEA3B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8BEA940", Offset = "0x8BE9740", VA = "0x188BEA940", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly FBCMHJDGNAL<Guid, ECFDNOLKKJI> FPLPMBIMEKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private ELAOGMGNFOO KFOIDAEMKKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private MDEEJJPMKJA DBONJGCDFLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private KIBCJDIOIPA HHJGKIGNEEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private MBFJIKCPDPI ANOIFEJLDJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private HEJDANFBOBB DBJHBADFBLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private HCNPPOOIDEE PCFBHCOALKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal JHCBDKPEMLJ<Guid, ECFDNOLKKJI> MLOBEBLBFJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private bool JAABGCKHGLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private Task MFBEHHBHPDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private CancellationTokenSource OBJGAGMGGKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private List<FEMEFNJLDFL> CABLILBCDLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private ADFIBKKDCBC? MOABGBDIKLJ;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static GKIGJPCJCGA IBKIAAFDJAN;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private List<FEMEFNJLDFL> MPNNEFNPDPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8BEDC20", Offset = "0x8BECA20", VA = "0x188BEDC20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private ADFIBKKDCBC PANLHOMINEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8BEB5C0", Offset = "0x8BEA3C0", VA = "0x188BEB5C0")]
		get
		{
			return default(ADFIBKKDCBC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static GKIGJPCJCGA MOIOIMEFPHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8BEEAE0", Offset = "0x8BED8E0", VA = "0x188BEEAE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x8BEE330", Offset = "0x8BED130", VA = "0x188BEE330")]
	private List<FEMEFNJLDFL> JIFNOCMKEON()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x8BEC1D0", Offset = "0x8BEAFD0", VA = "0x188BEC1D0")]
	[NKOKDPHOKEP.EPFIDDHPHJC.MBGBOEIIBBL]
	internal static void DBCFEKMBJDE(HJFNEHLLJBB HPOMHCIJOHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x8BEED90", Offset = "0x8BEDB90", VA = "0x188BEED90")]
	[RecRoom.NoEngine.Common.Preserve]
	public FMOOGAAGBGL([POMNKOCGGBN(null)] KIBCJDIOIPA HHJGKIGNEEF, [POMNKOCGGBN(null)] ELAOGMGNFOO KFOIDAEMKKE, [POMNKOCGGBN(null)] MDEEJJPMKJA DBONJGCDFLI, [POMNKOCGGBN(null)] MBFJIKCPDPI ANOIFEJLDJA, [POMNKOCGGBN(null)] HEJDANFBOBB DBJHBADFBLJ, [POMNKOCGGBN(null)] HCNPPOOIDEE PCFBHCOALKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x8BECFC0", Offset = "0x8BEBDC0", VA = "0x188BECFC0", Slot = "1")]
	~FMOOGAAGBGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x8BEC570", Offset = "0x8BEB370", VA = "0x188BEC570", Slot = "13")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x8BED560", Offset = "0x8BEC360", VA = "0x188BED560")]
	[AsyncStateMachine(typeof(BABBHGBDMAP))]
	private Task HMPCPKBEPOI(CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x8BED420", Offset = "0x8BEC220", VA = "0x188BED420")]
	public void HIKJIBEDCFP(Guid NNHDOHLBMKN, ECFDNOLKKJI CMMHNDNJKGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x8BEE4A0", Offset = "0x8BED2A0", VA = "0x188BEE4A0", Slot = "14")]
	public void LHBBFDFGACE(OBCKBDNDNAI OMLNADHFEFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x8BEEBD0", Offset = "0x8BED9D0", VA = "0x188BEEBD0", Slot = "4")]
	public void POKLPPENMNC(IEnumerable<OBCKBDNDNAI> AGIIFDCNHJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x8BEE8D0", Offset = "0x8BED6D0", VA = "0x188BEE8D0", Slot = "15")]
	public ECFDNOLKKJI LHNKEKDPAND(Guid PJJIOIOLAMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x8BEE6D0", Offset = "0x8BED4D0", VA = "0x188BEE6D0", Slot = "5")]
	public ECFDNOLKKJI LHNKEKDPAND(OBCKBDNDNAI OMLNADHFEFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x8BEE9D0", Offset = "0x8BED7D0", VA = "0x188BEE9D0", Slot = "16")]
	[AsyncStateMachine(typeof(NFPIEKJFOMB))]
	public Task<ECFDNOLKKJI> MOBAMGGHLFO(Guid PJJIOIOLAMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x8BED1C0", Offset = "0x8BEBFC0", VA = "0x188BED1C0", Slot = "7")]
	[AsyncStateMachine(typeof(MOKGHCAGJGE))]
	public Task<List<OBCKBDNDNAI>> GNHGBAINANA(string DPALDEBMGBP, bool? MMHFPFCKBHE, bool? DNKJPOHGDGD, IEnumerable<int> ADNPMLAAADK, bool BLDDIPKFMAD, bool APFFHGECEAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x8BEC270", Offset = "0x8BEB070", VA = "0x188BEC270", Slot = "6")]
	public OBCKBDNDNAI DNAPLBGOHAA(KLAOHEICPLP NNHDOHLBMKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x8BEB480", Offset = "0x8BEA280", VA = "0x188BEB480", Slot = "8")]
	[AsyncStateMachine(typeof(CGCOLNOLANO))]
	public Task<List<OBCKBDNDNAI>> ANFCHFPHALE(IReadOnlyList<KLAOHEICPLP> MAMMCPABMBE, bool OHAPHFJNHPO = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x8BED0B0", Offset = "0x8BEBEB0", VA = "0x188BED0B0")]
	[AsyncStateMachine(typeof(EAPAMJCPHOP))]
	private Task<List<FAFHAGKOPBD>> GIDCKFINBDF(List<FAFHAGKOPBD> MHOHKDCDHOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x8BEB7E0", Offset = "0x8BEA5E0", VA = "0x188BEB7E0")]
	private List<OBCKBDNDNAI> BGIOPEBJNPA(IReadOnlyList<KLAOHEICPLP> BOMNDAOLFEP, IReadOnlyList<FEMEFNJLDFL> MPKOEPKEIOI, IReadOnlyList<OBCKBDNDNAI> MHOHKDCDHOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x8BEBF70", Offset = "0x8BEAD70", VA = "0x188BEBF70", Slot = "9")]
	public AIKJELDGMEB<BalanceUpdateResponseDTO<CJJJLJHDAJJ>> CGIKDAMOILO(Guid PJJIOIOLAMC, long FHHAGIABJGI, GiftItemDTO PLAEHGJHGJO, COKNLBOGDAO EGEEBANPJFL = COKNLBOGDAO.RecCenterTokens, [Optional] long? CJLLIGONALN, BKMPEOKAHJC DFJCPOCMFHP = BKMPEOKAHJC.None)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x8BECE60", Offset = "0x8BEBC60", VA = "0x188BECE60")]
	[AsyncStateMachine(typeof(FIDGKFEEBEI))]
	private Task<LBBCKEKMIBK<BalanceUpdateResponseDTO<CJJJLJHDAJJ>>> FKHHFAGPOBG(Guid PJJIOIOLAMC, long FHHAGIABJGI, GiftItemDTO PLAEHGJHGJO, COKNLBOGDAO EGEEBANPJFL = COKNLBOGDAO.RecCenterTokens, [Optional] long? CJLLIGONALN, BKMPEOKAHJC DFJCPOCMFHP = BKMPEOKAHJC.None)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x8BEC5E0", Offset = "0x8BEB3E0", VA = "0x188BEC5E0", Slot = "10")]
	public AIKJELDGMEB<BalanceUpdateResponseDTO<CJJJLJHDAJJ>> EAIELPJCMMB(BKMPEOKAHJC DFJCPOCMFHP, COKNLBOGDAO EGEEBANPJFL, int DAOECODEBJJ, long FHHAGIABJGI, long? CJLLIGONALN, int HNMGLFCIJHN, bool NNNMFPODHAK = false, bool OBONDJMOCAC = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x8BEDDC0", Offset = "0x8BECBC0", VA = "0x188BEDDC0", Slot = "11")]
	public AIKJELDGMEB<BalanceUpdateResponseDTO<CJJJLJHDAJJ>> JGMLCHLPIIL(BKMPEOKAHJC DFJCPOCMFHP, COKNLBOGDAO EGEEBANPJFL, int DAOECODEBJJ, long FHHAGIABJGI, long? CJLLIGONALN, IReadOnlyCollection<int> PIICIFLPGIN, string JDFCBBCKOGJ, bool MGPHNJBOFHL, LBBELABPADG EDKJLAAAKAD, int HNMGLFCIJHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x8BED650", Offset = "0x8BEC450", VA = "0x188BED650", Slot = "12")]
	public AIKJELDGMEB<BalanceUpdateResponseDTO<CJJJLJHDAJJ>> IGEOJFGGEPC(BKMPEOKAHJC DFJCPOCMFHP, COKNLBOGDAO EGEEBANPJFL, IReadOnlyList<KLAOHEICPLP> JMEFKNCLGAG, IReadOnlyList<long> MFFPJONPGJE, [Optional] long? CJLLIGONALN, [Optional][CanBeNull] GiftItemDTO PLAEHGJHGJO, [Optional] Guid? ANONDBJLEOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x8BEBE00", Offset = "0x8BEAC00", VA = "0x188BEBE00")]
	[AsyncStateMachine(typeof(NDBCGLMENKK))]
	private Task<List<ECFDNOLKKJI>> BOFBKGNCING(IReadOnlyList<Guid> JMEFKNCLGAG, CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x8BECB50", Offset = "0x8BEB950", VA = "0x188BECB50")]
	private void FFLACPFAKFF(BalanceUpdateResponseDTO<CJJJLJHDAJJ> PNCENNMICLF, bool EOJOICJAANE, bool OBONDJMOCAC, bool NNNMFPODHAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x8BEC8D0", Offset = "0x8BEB6D0", VA = "0x188BEC8D0")]
	private void EOOAGHHLJAI(DELIHCCELHP HDGLGKJIFHJ, bool KIAKEDGCNNC, bool KJCDNOKEIPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x8BED320", Offset = "0x8BEC120", VA = "0x188BED320")]
	[AsyncStateMachine(typeof(CMOHFHDMAAL))]
	private Task GPKPNDIBMBF(List<OBCKBDNDNAI> AGIIFDCNHJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x8BEBF40", Offset = "0x8BEAD40", VA = "0x188BEBF40")]
	[CompilerGenerated]
	private void CCNCPECDKFA(BalanceUpdateResponseDTO<CJJJLJHDAJJ> MOBFLOHJOKJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class LLFOANJHDGI : BMAFMDIIGKJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly HEJDANFBOBB CCMBBBPGDLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly IICNAAJFEHA MEBELJJKHLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly KOOIAMFAOOJ OAFGHGEFEBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly JHFOOENJJGH JJNIHOBHKNK;

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x8BEFCD0", Offset = "0x8BEEAD0", VA = "0x188BEFCD0")]
	[NKOKDPHOKEP.EPFIDDHPHJC.MBGBOEIIBBL]
	internal static void DKLHNMBDELP(HJFNEHLLJBB HPOMHCIJOHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x10F4000", Offset = "0x10F2E00", VA = "0x1810F4000")]
	[RecRoom.NoEngine.Common.Preserve]
	public LLFOANJHDGI([POMNKOCGGBN(null)] HEJDANFBOBB DBJHBADFBLJ, [POMNKOCGGBN(null)] IICNAAJFEHA BCIIKEJLELG, [POMNKOCGGBN(null)] KOOIAMFAOOJ MHOHKDCDHOE, [POMNKOCGGBN(null)] JHFOOENJJGH IMNAHHCMLFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x8BF0000", Offset = "0x8BEEE00", VA = "0x188BF0000")]
	private bool KAKHCOOEAEG(OPCIILJLAIG EPHINKGMBEH, OPCIILJLAIG FGNIIONMKMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x8BF12C0", Offset = "0x8BF00C0", VA = "0x188BF12C0", Slot = "5")]
	public IReadOnlyList<OBCKBDNDNAI> IFPJEDMBGID(OPCIILJLAIG FGPKFAEEMAA, EHDNNINMPDM GLJMGBFFLDG, IReadOnlyList<OBCKBDNDNAI> LJHCADEPBBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x8BF0560", Offset = "0x8BEF360", VA = "0x188BF0560", Slot = "4")]
	public bool GOMCEOJIBCB(OPCIILJLAIG FGPKFAEEMAA, EHDNNINMPDM GLJMGBFFLDG, OBCKBDNDNAI IIHDHELGAFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x8BEF800", Offset = "0x8BEE600", VA = "0x188BEF800")]
	private bool CJCHJAGIKIN(OPCIILJLAIG FGPKFAEEMAA, OBCKBDNDNAI IIHDHELGAFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x8BEF380", Offset = "0x8BEE180", VA = "0x188BEF380")]
	private bool BIKDHNIEJHP(OPCIILJLAIG FGPKFAEEMAA, OBCKBDNDNAI IIHDHELGAFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x8BF02B0", Offset = "0x8BEF0B0", VA = "0x188BF02B0")]
	private bool GBMEHKNNAHI(OPCIILJLAIG FGPKFAEEMAA, OBCKBDNDNAI IIHDHELGAFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x8BEF9B0", Offset = "0x8BEE7B0", VA = "0x188BEF9B0")]
	public bool DILNPFHHAIM(OBCKBDNDNAI OMLNADHFEFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x8BEFC00", Offset = "0x8BEEA00", VA = "0x188BEFC00")]
	public bool DILNPFHHAIM(FHKJPADBPKM IHCNIMKNMIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x8BF0130", Offset = "0x8BEEF30", VA = "0x188BF0130")]
	private bool EOPINPAKOHD(Guid PJJIOIOLAMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x8BF18B0", Offset = "0x8BF06B0", VA = "0x188BF18B0")]
	private bool LFINGDMHFNP(OPCIILJLAIG FGPKFAEEMAA, OBCKBDNDNAI IIHDHELGAFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x8BF1B00", Offset = "0x8BF0900", VA = "0x188BF1B00")]
	private bool OIMNALDOEDK(OPCIILJLAIG FGPKFAEEMAA, OBCKBDNDNAI IIHDHELGAFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x8BF01B0", Offset = "0x8BEEFB0", VA = "0x188BF01B0")]
	private bool FKHHKGOEMGI(OPCIILJLAIG FGPKFAEEMAA, OBCKBDNDNAI IIHDHELGAFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x8BF1C00", Offset = "0x8BF0A00", VA = "0x188BF1C00")]
	private bool POIINKLNNNC(OPCIILJLAIG FGPKFAEEMAA, OBCKBDNDNAI IIHDHELGAFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x8BF17B0", Offset = "0x8BF05B0", VA = "0x188BF17B0")]
	private bool KFFCFPMKPKK(OPCIILJLAIG FGPKFAEEMAA, OBCKBDNDNAI IIHDHELGAFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x8BF1B90", Offset = "0x8BF0990", VA = "0x188BF1B90")]
	private bool PJMBGKILGAI(OPCIILJLAIG FGPKFAEEMAA, OBCKBDNDNAI IIHDHELGAFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x8BF1B20", Offset = "0x8BF0920", VA = "0x188BF1B20")]
	private bool OKFPIOOPLFC(OPCIILJLAIG FGPKFAEEMAA, OBCKBDNDNAI IIHDHELGAFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x8BF03B0", Offset = "0x8BEF1B0", VA = "0x188BF03B0")]
	private bool GHIBNFFAADJ(OPCIILJLAIG FGPKFAEEMAA, OBCKBDNDNAI IIHDHELGAFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x8BEF740", Offset = "0x8BEE540", VA = "0x188BEF740")]
	private bool CGBEODNLGEE(OPCIILJLAIG FGPKFAEEMAA, OBCKBDNDNAI IIHDHELGAFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x8BEF920", Offset = "0x8BEE720", VA = "0x188BEF920")]
	private bool CONOECKNPLF(OPCIILJLAIG FGPKFAEEMAA, OBCKBDNDNAI IIHDHELGAFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x8BF1530", Offset = "0x8BF0330", VA = "0x188BF1530")]
	private bool IICGIBEPJIE(OPCIILJLAIG FGPKFAEEMAA, OBCKBDNDNAI IIHDHELGAFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x8BF1970", Offset = "0x8BF0770", VA = "0x188BF1970")]
	private bool MLGPJBCFAEL(OPCIILJLAIG FGPKFAEEMAA, OBCKBDNDNAI IIHDHELGAFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x8BEFD40", Offset = "0x8BEEB40", VA = "0x188BEFD40")]
	private bool ECAONAAFHAB(OPCIILJLAIG FGPKFAEEMAA, OBCKBDNDNAI IIHDHELGAFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x8BF0440", Offset = "0x8BEF240", VA = "0x188BF0440")]
	private bool GLOAOELHKJG(OPCIILJLAIG FGPKFAEEMAA, OBCKBDNDNAI IIHDHELGAFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x8BF1110", Offset = "0x8BEFF10", VA = "0x188BF1110")]
	private bool HCOCBCPNDDA(OPCIILJLAIG FGPKFAEEMAA, OBCKBDNDNAI IIHDHELGAFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x8BF04D0", Offset = "0x8BEF2D0", VA = "0x188BF04D0")]
	private bool GOIAKNLGLPH(OPCIILJLAIG FGPKFAEEMAA, OBCKBDNDNAI IIHDHELGAFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x8BF0220", Offset = "0x8BEF020", VA = "0x188BF0220")]
	private bool FPLMNFHICKE(OPCIILJLAIG FGPKFAEEMAA, OBCKBDNDNAI IIHDHELGAFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x8BF1230", Offset = "0x8BF0030", VA = "0x188BF1230")]
	private bool ICCIFPKAJKL(OPCIILJLAIG FGPKFAEEMAA, OBCKBDNDNAI IIHDHELGAFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x8BF1720", Offset = "0x8BF0520", VA = "0x188BF1720")]
	private bool JFDCFDHNOGP(OPCIILJLAIG FGPKFAEEMAA, OBCKBDNDNAI IIHDHELGAFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x8BF0000", Offset = "0x8BEEE00", VA = "0x188BF0000")]
	private bool EINEMCJHEOC(EHDNNINMPDM EPHINKGMBEH, EHDNNINMPDM FGNIIONMKMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x8BEFDD0", Offset = "0x8BEEBD0", VA = "0x188BEFDD0")]
	private bool EHAOKNEBJKD(OPCIILJLAIG FGPKFAEEMAA, EHDNNINMPDM GLJMGBFFLDG, OBCKBDNDNAI IIHDHELGAFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x8BF18E0", Offset = "0x8BF06E0", VA = "0x188BF18E0")]
	private bool LOPCHGHJKEA(EHDNNINMPDM GLJMGBFFLDG, OBCKBDNDNAI IIHDHELGAFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x8BF0010", Offset = "0x8BEEE10", VA = "0x188BF0010")]
	private bool ELGKKBKKFNC(EHDNNINMPDM GLJMGBFFLDG, OBCKBDNDNAI IIHDHELGAFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x8BEF890", Offset = "0x8BEE690", VA = "0x188BEF890")]
	private bool CNIBGBCCPAA(EHDNNINMPDM GLJMGBFFLDG, OBCKBDNDNAI IIHDHELGAFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x8BF1A00", Offset = "0x8BF0800", VA = "0x188BF1A00")]
	private bool OAEOIDFEGBJ(EHDNNINMPDM GLJMGBFFLDG, OBCKBDNDNAI IIHDHELGAFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x8BF15C0", Offset = "0x8BF03C0", VA = "0x188BF15C0")]
	private bool IKHPOBJGJKN(EHDNNINMPDM GLJMGBFFLDG, OBCKBDNDNAI IIHDHELGAFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x8BF1820", Offset = "0x8BF0620", VA = "0x188BF1820")]
	private bool KLEFCDHBKJG(EHDNNINMPDM GLJMGBFFLDG, OBCKBDNDNAI IIHDHELGAFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x8BF00A0", Offset = "0x8BEEEA0", VA = "0x188BF00A0")]
	private bool ENHNEFDJONL(OPCIILJLAIG FGPKFAEEMAA, OBCKBDNDNAI IIHDHELGAFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x8BEF680", Offset = "0x8BEE480", VA = "0x188BEF680")]
	private bool CFNJFAHBLDD(OPCIILJLAIG FGPKFAEEMAA, OBCKBDNDNAI IIHDHELGAFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x8BF1650", Offset = "0x8BF0450", VA = "0x188BF1650")]
	private bool JEGKPNALMCF(OPCIILJLAIG FGPKFAEEMAA, OBCKBDNDNAI IIHDHELGAFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x8BF0320", Offset = "0x8BEF120", VA = "0x188BF0320")]
	private bool GGODMCHFFEI(OPCIILJLAIG FGPKFAEEMAA, OBCKBDNDNAI IIHDHELGAFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x8BF1A90", Offset = "0x8BF0890", VA = "0x188BF1A90")]
	private bool OCMKFMPFDNG(OPCIILJLAIG FGPKFAEEMAA, OBCKBDNDNAI IIHDHELGAFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x8BEF2F0", Offset = "0x8BEE0F0", VA = "0x188BEF2F0")]
	private bool BFMOMMCDONP(OPCIILJLAIG FGPKFAEEMAA, OBCKBDNDNAI IIHDHELGAFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x8BF11A0", Offset = "0x8BEFFA0", VA = "0x188BF11A0")]
	private bool HEKBHODAFEG(OPCIILJLAIG FGPKFAEEMAA, OBCKBDNDNAI IIHDHELGAFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x8BEF280", Offset = "0x8BEE080", VA = "0x188BEF280")]
	private bool AMBGKEDCLNK(OPCIILJLAIG FGPKFAEEMAA, OBCKBDNDNAI IIHDHELGAFA)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class EDFFLPDHNEN
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public EDFFLPDHNEN()
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
