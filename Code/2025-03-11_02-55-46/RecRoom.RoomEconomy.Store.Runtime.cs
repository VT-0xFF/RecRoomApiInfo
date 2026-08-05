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
		[Cpp2IlInjected.Address(RVA = "0x7D71840", Offset = "0x7D70C40", VA = "0x187D71840", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2491CF0", Offset = "0x24910F0", VA = "0x182491CF0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class PIMIEPHADLN : IOLBAKBOGFO, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private struct HEBKJPDHEGF : IAsyncStateMachine
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
		public PIMIEPHADLN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7D6BEC0", Offset = "0x7D6B2C0", VA = "0x187D6BEC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7D6C1C0", Offset = "0x7D6B5C0", VA = "0x187D6C1C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private struct LEGLDNFMBMH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public AsyncTaskMethodBuilder<EHAKHNGPPPO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public PIMIEPHADLN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public Guid customAvatarItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private TaskAwaiter<EHAKHNGPPPO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7D6CC60", Offset = "0x7D6C060", VA = "0x187D6CC60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7D6CF70", Offset = "0x7D6C370", VA = "0x187D6CF70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct BPDAPJMEEBA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public AsyncTaskMethodBuilder<List<AOBLIEEPFME>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public PIMIEPHADLN <>4__this;

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
		private List<AOBLIEEPFME> <results>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private TaskAwaiter<List<HJGPJCOEBAN>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7D6B030", Offset = "0x7D6A430", VA = "0x187D6B030", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7D6B7E0", Offset = "0x7D6ABE0", VA = "0x187D6B7E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct NOFHBBHKPKL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public AsyncTaskMethodBuilder<List<AOBLIEEPFME>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public PIMIEPHADLN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public IReadOnlyList<CPPPGIHAECF> unifiedItemIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private List<AOBLIEEPFME> <storeItemsInInitialOrder>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private TaskAwaiter<List<HJGPJCOEBAN>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7D6D540", Offset = "0x7D6C940", VA = "0x187D6D540", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7D6DDD0", Offset = "0x7D6D1D0", VA = "0x187D6DDD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct MOACHHPNCOH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public AsyncTaskMethodBuilder<List<HJGPJCOEBAN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public List<HJGPJCOEBAN> customAvatarItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public PIMIEPHADLN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x7D6CFE0", Offset = "0x7D6C3E0", VA = "0x187D6CFE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7D6D4D0", Offset = "0x7D6C8D0", VA = "0x187D6D4D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class DPAHHEOCIPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public CPPPGIHAECF id;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public DPAHHEOCIPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7D6B850", Offset = "0x7D6AC50", VA = "0x187D6B850")]
		internal bool GOJHIIKPALM(AFGCOAHEJLA x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7D6B890", Offset = "0x7D6AC90", VA = "0x187D6B890")]
		internal bool IFBAEKOMKPK(AOBLIEEPFME x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class FEFOOPAJLDB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public string itemFriendlyName;

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public FEFOOPAJLDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7D6BE70", Offset = "0x7D6B270", VA = "0x187D6BE70")]
		internal object GNACBMMLNND()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class JFHGFHNKIND
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public PIMIEPHADLN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public GiftItemDTO gift;

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public JFHGFHNKIND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7D6C220", Offset = "0x7D6B620", VA = "0x187D6C220")]
		internal void OCDGAGDGMDJ(BalanceUpdateResponseDTO<NJMMBEADCGF> result)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct KGKEBPMPKLB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncTaskMethodBuilder<IMLBJHIHONB<BalanceUpdateResponseDTO<NJMMBEADCGF>>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public PIMIEPHADLN <>4__this;

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
		public PHKGDBEFEIP storefrontType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public LMNPJOLMEFF currencyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private TaskAwaiter<EHAKHNGPPPO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private TaskAwaiter<IMLBJHIHONB<BalanceUpdateResponseDTO<NJMMBEADCGF>>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7D6C710", Offset = "0x7D6BB10", VA = "0x187D6C710", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7D6CBF0", Offset = "0x7D6BFF0", VA = "0x187D6CBF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class JHNCFCFHFME
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public PIMIEPHADLN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public bool handleShowGiftPackage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public bool shouldConsumeGiftBoxImmediately;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public JHNCFCFHFME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7D6C260", Offset = "0x7D6B660", VA = "0x187D6C260")]
		internal void CCNNENAFHPO(BalanceUpdateResponseDTO<NJMMBEADCGF> result)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct JIEMFCLLMFE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public AsyncTaskMethodBuilder<List<EHAKHNGPPPO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public IReadOnlyList<Guid> itemIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public PIMIEPHADLN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private TaskAwaiter<List<BLCAHJFMLNC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x7D6C2A0", Offset = "0x7D6B6A0", VA = "0x187D6C2A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7D6C6A0", Offset = "0x7D6BAA0", VA = "0x187D6C6A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct FAMHDGIPNCE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public List<AOBLIEEPFME> storeItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public PIMIEPHADLN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private int <attemptNumber>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7D6B950", Offset = "0x7D6AD50", VA = "0x187D6B950", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7D6BE10", Offset = "0x7D6B210", VA = "0x187D6BE10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly AGFEFEBLEAJ<Guid, EHAKHNGPPPO> AFPHELBMABE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private BOONHAPKPMH OEBNGBGGEOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private JOCMHOFMNAB BIEOKAPHPPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private GLHAJNDABIP CJEPBHGPJKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private PPPBCKBOHAP ALNGHDDIIBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private GEMEMDDPCDF IDHFELMMAEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private HKNCEKAFBLB OANGCDEFDJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal EFINIOEALEL<Guid, EHAKHNGPPPO> BGIAFBMJNFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private bool MPODDHPAEGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private Task MAPEHPLCAOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private CancellationTokenSource GLOFLNBKEEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private List<AFGCOAHEJLA> DAENFECLBLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private COLGPENAOJI? NIEAIBAEHPK;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static IOLBAKBOGFO OBMKHALAGDN;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private List<AFGCOAHEJLA> IBGIFBPGHJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7D70520", Offset = "0x7D6F920", VA = "0x187D70520")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private COLGPENAOJI LGKMCLOMPFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7D6E500", Offset = "0x7D6D900", VA = "0x187D6E500")]
		get
		{
			return default(COLGPENAOJI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static IOLBAKBOGFO AJPLFLPAHGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7D70BB0", Offset = "0x7D6FFB0", VA = "0x187D70BB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7D6E710", Offset = "0x7D6DB10", VA = "0x187D6E710")]
	private List<AFGCOAHEJLA> EIHNKJIMMNL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7D71110", Offset = "0x7D70510", VA = "0x187D71110")]
	[AEDFFNEEAKJ.LKOFKMOGMGJ.KBJNMFOOFMD]
	internal static void OOLIJHLPGJB(LEPFMCICNAK EOMAFKDOFHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7D71240", Offset = "0x7D70640", VA = "0x187D71240")]
	[RecRoom.NoEngine.Common.Preserve]
	public PIMIEPHADLN([PNFCCJKFMBH(null)] GLHAJNDABIP CJEPBHGPJKB, [PNFCCJKFMBH(null)] BOONHAPKPMH OEBNGBGGEOP, [PNFCCJKFMBH(null)] JOCMHOFMNAB BIEOKAPHPPG, [PNFCCJKFMBH(null)] PPPBCKBOHAP ALNGHDDIIBG, [PNFCCJKFMBH(null)] GEMEMDDPCDF IDHFELMMAEF, [PNFCCJKFMBH(null)] HKNCEKAFBLB OANGCDEFDJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7D6EC40", Offset = "0x7D6E040", VA = "0x187D6EC40", Slot = "1")]
	~PIMIEPHADLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7D6E3A0", Offset = "0x7D6D7A0", VA = "0x187D6E3A0", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7D6E410", Offset = "0x7D6D810", VA = "0x187D6E410")]
	[AsyncStateMachine(typeof(HEBKJPDHEGF))]
	private Task EBPHIAPJEAO(CancellationToken MLAPMBKLAOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7D70080", Offset = "0x7D6F480", VA = "0x187D70080")]
	public void IHACAPLHKMK(Guid KIBDOOPIGIB, EHAKHNGPPPO GPNOGGNHPHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7D70910", Offset = "0x7D6FD10", VA = "0x187D70910", Slot = "13")]
	public void NEGFMHIFNOG(AOBLIEEPFME PBLIBPBBABN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7D70100", Offset = "0x7D6F500", VA = "0x187D70100", Slot = "4")]
	public void KOMMAPDOIFB(IEnumerable<AOBLIEEPFME> DPPCNDDOFAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7D6E2A0", Offset = "0x7D6D6A0", VA = "0x187D6E2A0", Slot = "14")]
	public EHAKHNGPPPO DLBFKDKNIMJ(Guid BNFNDCGCFGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7D6E0A0", Offset = "0x7D6D4A0", VA = "0x187D6E0A0", Slot = "5")]
	public EHAKHNGPPPO DLBFKDKNIMJ(AOBLIEEPFME PBLIBPBBABN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7D6E8B0", Offset = "0x7D6DCB0", VA = "0x187D6E8B0", Slot = "15")]
	[AsyncStateMachine(typeof(LEGLDNFMBMH))]
	public Task<EHAKHNGPPPO> FADEFDNOMFK(Guid BNFNDCGCFGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7D70FB0", Offset = "0x7D703B0", VA = "0x187D70FB0", Slot = "6")]
	[AsyncStateMachine(typeof(BPDAPJMEEBA))]
	public Task<List<AOBLIEEPFME>> OGONJBIDGLM(string KAFIFCHGCBM, bool? GJPDCFIEPNL, bool? LPLEJFEIOPH, IEnumerable<int> PLEHOGCEJOK, bool KKAJCDAJNJO, bool HKGPMECHIKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7D6EB20", Offset = "0x7D6DF20", VA = "0x187D6EB20", Slot = "7")]
	[AsyncStateMachine(typeof(NOFHBBHKPKL))]
	public Task<List<AOBLIEEPFME>> FLHLNLNAIJH(IReadOnlyList<CPPPGIHAECF> AACOEBLCKGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7D706C0", Offset = "0x7D6FAC0", VA = "0x187D706C0")]
	[AsyncStateMachine(typeof(MOACHHPNCOH))]
	private Task<List<HJGPJCOEBAN>> MIMEOLBIDGO(List<HJGPJCOEBAN> CKFGAKGEIMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7D6F220", Offset = "0x7D6E620", VA = "0x187D6F220")]
	private List<AOBLIEEPFME> GODPNMOPNHE(IReadOnlyList<CPPPGIHAECF> PJFELPIGAEO, IReadOnlyList<AFGCOAHEJLA> LMMJFAEFLLN, IReadOnlyList<AOBLIEEPFME> CKFGAKGEIMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7D6DE40", Offset = "0x7D6D240", VA = "0x187D6DE40", Slot = "8")]
	public HHPFDJMLPAL<BalanceUpdateResponseDTO<NJMMBEADCGF>> BOKFOCACIKG(Guid BNFNDCGCFGH, long EDGFACHOEOC, GiftItemDTO IMOCCDGIDFE, LMNPJOLMEFF HDODMFJNNAG = LMNPJOLMEFF.RecCenterTokens, [Optional] long? ODCBJACFGKB, PHKGDBEFEIP IJKLAMLPMIA = PHKGDBEFEIP.None)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7D6E9C0", Offset = "0x7D6DDC0", VA = "0x187D6E9C0")]
	[AsyncStateMachine(typeof(KGKEBPMPKLB))]
	private Task<IMLBJHIHONB<BalanceUpdateResponseDTO<NJMMBEADCGF>>> FHLHFKCGDKC(Guid BNFNDCGCFGH, long EDGFACHOEOC, GiftItemDTO IMOCCDGIDFE, LMNPJOLMEFF HDODMFJNNAG = LMNPJOLMEFF.RecCenterTokens, [Optional] long? ODCBJACFGKB, PHKGDBEFEIP IJKLAMLPMIA = PHKGDBEFEIP.None)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7D6F940", Offset = "0x7D6ED40", VA = "0x187D6F940", Slot = "9")]
	public HHPFDJMLPAL<BalanceUpdateResponseDTO<NJMMBEADCGF>> HLLNHJJNDBI(PHKGDBEFEIP IJKLAMLPMIA, LMNPJOLMEFF HDODMFJNNAG, int JHGOHHOIEGP, long EDGFACHOEOC, long? ODCBJACFGKB, int CILACHINJHL, bool FCJGLENMBIN = false, bool GKAADKCEMHH = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7D6ED30", Offset = "0x7D6E130", VA = "0x187D6ED30", Slot = "10")]
	public HHPFDJMLPAL<BalanceUpdateResponseDTO<NJMMBEADCGF>> GNBCOBMDPKJ(PHKGDBEFEIP IJKLAMLPMIA, LMNPJOLMEFF HDODMFJNNAG, int JHGOHHOIEGP, long EDGFACHOEOC, long? ODCBJACFGKB, IReadOnlyCollection<int> NIINJCOLDDH, string LPIFIOEEOGF, bool OMHCGDGDACJ, AIBJOFIAIJG KKCKAOKJHHJ, int CILACHINJHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7D6FBA0", Offset = "0x7D6EFA0", VA = "0x187D6FBA0", Slot = "11")]
	public HHPFDJMLPAL<BalanceUpdateResponseDTO<NJMMBEADCGF>> IBLKLKCEHJG(PHKGDBEFEIP IJKLAMLPMIA, LMNPJOLMEFF HDODMFJNNAG, IReadOnlyList<int> FFNDNBMECIN, IReadOnlyList<long> JKFFFMPKCHO, long? ODCBJACFGKB, int EGMGKPDEOMA, string LPIFIOEEOGF, bool OMHCGDGDACJ, AIBJOFIAIJG KKCKAOKJHHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7D707D0", Offset = "0x7D6FBD0", VA = "0x187D707D0")]
	[AsyncStateMachine(typeof(JIEMFCLLMFE))]
	private Task<List<EHAKHNGPPPO>> NBFEIFBFNLB(IReadOnlyList<Guid> ABCBNKFJHMF, CancellationToken MLAPMBKLAOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7D70CA0", Offset = "0x7D700A0", VA = "0x187D70CA0")]
	private void NNCCGJDFGDI(BalanceUpdateResponseDTO<NJMMBEADCGF> GLGDOFEFILE, bool EONBCDJAGKO, bool GKAADKCEMHH, bool FCJGLENMBIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7D702B0", Offset = "0x7D6F6B0", VA = "0x187D702B0")]
	private void LDGMILBALFM(OFOAMKHMBCJ IOIAAAJCJGC, bool OFCFDHPDMCD, bool KJMKKCAMFDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7D6F840", Offset = "0x7D6EC40", VA = "0x187D6F840")]
	[AsyncStateMachine(typeof(FAMHDGIPNCE))]
	private Task HDNLBEDNLBJ(List<AOBLIEEPFME> DPPCNDDOFAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7D6E880", Offset = "0x7D6DC80", VA = "0x187D6E880")]
	[CompilerGenerated]
	private void EMNFPJKBNNB(BalanceUpdateResponseDTO<NJMMBEADCGF> HOCIBOCHCFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7D6E880", Offset = "0x7D6DC80", VA = "0x187D6E880")]
	[CompilerGenerated]
	private void OOBBMHNLHFJ(BalanceUpdateResponseDTO<NJMMBEADCGF> HOCIBOCHCFJ)
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class FKHLMKNECEB
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
	public FKHLMKNECEB()
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
