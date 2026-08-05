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
		[Cpp2IlInjected.Address(RVA = "0x84813A0", Offset = "0x84805A0", VA = "0x1884813A0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2675970", Offset = "0x2674B70", VA = "0x182675970")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class BAODJOCFLFH : EACMFHDPBBP, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private struct HMGCMBEEJNL : IAsyncStateMachine
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
		public BAODJOCFLFH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x847CEA0", Offset = "0x847C0A0", VA = "0x18847CEA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x847D1A0", Offset = "0x847C3A0", VA = "0x18847D1A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private struct HNPFKBLOICG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public AsyncTaskMethodBuilder<IKCLLFELIOF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public BAODJOCFLFH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public Guid customAvatarItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private TaskAwaiter<IKCLLFELIOF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x847D200", Offset = "0x847C400", VA = "0x18847D200", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x847D4D0", Offset = "0x847C6D0", VA = "0x18847D4D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct OCNMFALMPKI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public AsyncTaskMethodBuilder<List<JMGCHNCFNHB>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public BAODJOCFLFH <>4__this;

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
		private List<JMGCHNCFNHB> <results>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private TaskAwaiter<List<ECGLABHDGNK>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x84808E0", Offset = "0x847FAE0", VA = "0x1884808E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8481090", Offset = "0x8480290", VA = "0x188481090", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct BGMPLNNBFKD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public AsyncTaskMethodBuilder<List<JMGCHNCFNHB>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public BAODJOCFLFH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public IReadOnlyList<OCLLJFMDPPK> unifiedItemIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public bool convertCustomAvatarItemsToPurchasableGiftDrops;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private List<JMGCHNCFNHB> <storeItemsInInitialOrder>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private TaskAwaiter<List<ECGLABHDGNK>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x847C000", Offset = "0x847B200", VA = "0x18847C000", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x847C8A0", Offset = "0x847BAA0", VA = "0x18847C8A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct KMPEDDFGGIP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public AsyncTaskMethodBuilder<List<ECGLABHDGNK>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public List<ECGLABHDGNK> customAvatarItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public BAODJOCFLFH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x847FDE0", Offset = "0x847EFE0", VA = "0x18847FDE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x84802E0", Offset = "0x847F4E0", VA = "0x1884802E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class PHOBHCEBMBF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public OCLLJFMDPPK id;

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public PHOBHCEBMBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x84811C0", Offset = "0x84803C0", VA = "0x1884811C0")]
		internal bool JBLPLDEIPJE(MHAJHFKDDCD x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8481100", Offset = "0x8480300", VA = "0x188481100")]
		internal bool AFDIKBIHEGL(JMGCHNCFNHB x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class IEJGHOAPFCK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public string itemFriendlyName;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public IEJGHOAPFCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x847F930", Offset = "0x847EB30", VA = "0x18847F930")]
		internal object GHDHCBDJBDP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class MEOBJHGGBCH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public BAODJOCFLFH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public GiftItemDTO gift;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public MEOBJHGGBCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8480350", Offset = "0x847F550", VA = "0x188480350")]
		internal void APBHPIKJGEM(BalanceUpdateResponseDTO<PPJBNCHIOGE> result)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct EGMHCODPGJD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public AsyncTaskMethodBuilder<DEOBABMLFHH<BalanceUpdateResponseDTO<PPJBNCHIOGE>>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public BAODJOCFLFH <>4__this;

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
		public DAJCBAEDADB storefrontType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public CIHMKPKBLFN currencyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private TaskAwaiter<IKCLLFELIOF> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private TaskAwaiter<DEOBABMLFHH<BalanceUpdateResponseDTO<PPJBNCHIOGE>>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x847C910", Offset = "0x847BB10", VA = "0x18847C910", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x847CDF0", Offset = "0x847BFF0", VA = "0x18847CDF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class EKKCIPMNPEG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public BAODJOCFLFH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public bool handleShowGiftPackage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public bool shouldConsumeGiftBoxImmediately;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public EKKCIPMNPEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x847CE60", Offset = "0x847C060", VA = "0x18847CE60")]
		internal void PLCCDKOKCJI(BalanceUpdateResponseDTO<PPJBNCHIOGE> result)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct JCLFBJEFOJP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public AsyncTaskMethodBuilder<List<IKCLLFELIOF>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public IReadOnlyList<Guid> itemIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public BAODJOCFLFH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private TaskAwaiter<List<OBNDCIGENOG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x847F980", Offset = "0x847EB80", VA = "0x18847F980", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x847FD70", Offset = "0x847EF70", VA = "0x18847FD70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct MPAKEOKEFAP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public List<JMGCHNCFNHB> storeItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public BAODJOCFLFH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private int <attemptNumber>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8480390", Offset = "0x847F590", VA = "0x188480390", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8480880", Offset = "0x847FA80", VA = "0x188480880", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly NKNGJHPMKGM<Guid, IKCLLFELIOF> FCDCAEMAKGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private GLLIIHCJKOA GGCLFNKAIGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private OLFODKFDKMO MMHBELIGGKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private OPOKCJLOHBC BPBACNMDAIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private FLKBLKEIMBH DOILOMPAOCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private LININKIOLPA OACDOHJMHIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private HCDMAMCBAKB GEFFKAEDCDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal JBIBALGPAGF<Guid, IKCLLFELIOF> INCGHOAMJNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private bool KBCJGENOOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private Task PGEPAPLLBMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private CancellationTokenSource FPEGAEEKCBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private List<MHAJHFKDDCD> JAIHEEJDIIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private ECHPHHPENOM? DFAHHDDBFOM;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static EACMFHDPBBP DGHGLEFLLGO;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private List<MHAJHFKDDCD> ANHLOMIDDPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x847B360", Offset = "0x847A560", VA = "0x18847B360")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private ECHPHHPENOM PCIPBKMOOJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8479CD0", Offset = "0x8478ED0", VA = "0x188479CD0")]
		get
		{
			return default(ECHPHHPENOM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static EACMFHDPBBP NDDGJHHDBNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8479AC0", Offset = "0x8478CC0", VA = "0x188479AC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x8479EF0", Offset = "0x84790F0", VA = "0x188479EF0")]
	private List<MHAJHFKDDCD> HBCKBKMFGDP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x847B060", Offset = "0x847A260", VA = "0x18847B060")]
	[DBIDCJGLKKO.GKLMLMNDHKE.BABOHFKFEPH]
	internal static void LNFJKPHMEBL(HILJAABEPDC NPCDKJJJIDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x847BB90", Offset = "0x847AD90", VA = "0x18847BB90")]
	[RecRoom.NoEngine.Common.Preserve]
	public BAODJOCFLFH([ALHAHLCGLLK(null)] OPOKCJLOHBC BPBACNMDAIP, [ALHAHLCGLLK(null)] GLLIIHCJKOA GGCLFNKAIGH, [ALHAHLCGLLK(null)] OLFODKFDKMO MMHBELIGGKB, [ALHAHLCGLLK(null)] FLKBLKEIMBH DOILOMPAOCF, [ALHAHLCGLLK(null)] LININKIOLPA OACDOHJMHIP, [ALHAHLCGLLK(null)] HCDMAMCBAKB GEFFKAEDCDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x8479BE0", Offset = "0x8478DE0", VA = "0x188479BE0", Slot = "1")]
	~BAODJOCFLFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x8479A50", Offset = "0x8478C50", VA = "0x188479A50", Slot = "13")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x8478F00", Offset = "0x8478100", VA = "0x188478F00")]
	[AsyncStateMachine(typeof(HMGCMBEEJNL))]
	private Task APAEAIFFGPP(CancellationToken HCELDNOKOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x8478FF0", Offset = "0x84781F0", VA = "0x188478FF0")]
	public void BGMBDILGOJA(Guid PJEBGIFFKDF, IKCLLFELIOF ECKDCJDAJJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x847A370", Offset = "0x8479570", VA = "0x18847A370", Slot = "14")]
	public void LFKKCHOBGNF(JMGCHNCFNHB JFPIEPHOIPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x84792A0", Offset = "0x84784A0", VA = "0x1884792A0", Slot = "4")]
	public void CPBHFHLENIP(IEnumerable<JMGCHNCFNHB> PIBPOKJANCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x8478C00", Offset = "0x8477E00", VA = "0x188478C00", Slot = "15")]
	public IKCLLFELIOF AMFPAHMMFBA(Guid NFCMKJPGKGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x8478D00", Offset = "0x8477F00", VA = "0x188478D00", Slot = "5")]
	public IKCLLFELIOF AMFPAHMMFBA(JMGCHNCFNHB JFPIEPHOIPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x8479940", Offset = "0x8478B40", VA = "0x188479940", Slot = "16")]
	[AsyncStateMachine(typeof(HNPFKBLOICG))]
	public Task<IKCLLFELIOF> DOGGAMMOEPB(Guid NFCMKJPGKGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x8479140", Offset = "0x8478340", VA = "0x188479140", Slot = "7")]
	[AsyncStateMachine(typeof(OCNMFALMPKI))]
	public Task<List<JMGCHNCFNHB>> BMBCLOEBKMP(string HDOBPCHMLFH, bool? PEPGFADIDGN, bool? DKJNEGCCGDF, IEnumerable<int> FENPFOFCPPP, bool IEPBMECMKDG, bool LDNPMBPOINF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x847B640", Offset = "0x847A840", VA = "0x18847B640", Slot = "6")]
	public JMGCHNCFNHB NIODABGNFIB(OCLLJFMDPPK PJEBGIFFKDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x84784A0", Offset = "0x84776A0", VA = "0x1884784A0", Slot = "8")]
	[AsyncStateMachine(typeof(BGMPLNNBFKD))]
	public Task<List<JMGCHNCFNHB>> ABMACHCIJEO(IReadOnlyList<OCLLJFMDPPK> NICBEGMPKNF, bool CKCLOIABDOK = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x847AF50", Offset = "0x847A150", VA = "0x18847AF50")]
	[AsyncStateMachine(typeof(KMPEDDFGGIP))]
	private Task<List<ECGLABHDGNK>> LLKCMLAJJPD(List<ECGLABHDGNK> KGFMNFNGEKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x84785E0", Offset = "0x84777E0", VA = "0x1884785E0")]
	private List<JMGCHNCFNHB> AJIFOOGLIOC(IReadOnlyList<OCLLJFMDPPK> PJOFBHIOFKM, IReadOnlyList<MHAJHFKDDCD> JIKGEICBNJJ, IReadOnlyList<JMGCHNCFNHB> KGFMNFNGEKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x847B100", Offset = "0x847A300", VA = "0x18847B100", Slot = "9")]
	public CMEBMOPMCFP<BalanceUpdateResponseDTO<PPJBNCHIOGE>> MDLMPNLIKML(Guid NFCMKJPGKGP, long PMMDPJNEPEE, GiftItemDTO MDODNKHHNEN, CIHMKPKBLFN FPBMLOPCHIM = CIHMKPKBLFN.RecCenterTokens, [Optional] long? FLIHMCFFMPK, DAJCBAEDADB ALFOCLJBJFM = DAJCBAEDADB.None)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x847B930", Offset = "0x847AB30", VA = "0x18847B930")]
	[AsyncStateMachine(typeof(EGMHCODPGJD))]
	private Task<DEOBABMLFHH<BalanceUpdateResponseDTO<PPJBNCHIOGE>>> OFELLFBIOND(Guid NFCMKJPGKGP, long PMMDPJNEPEE, GiftItemDTO MDODNKHHNEN, CIHMKPKBLFN FPBMLOPCHIM = CIHMKPKBLFN.RecCenterTokens, [Optional] long? FLIHMCFFMPK, DAJCBAEDADB ALFOCLJBJFM = DAJCBAEDADB.None)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x847A5A0", Offset = "0x84797A0", VA = "0x18847A5A0", Slot = "10")]
	public CMEBMOPMCFP<BalanceUpdateResponseDTO<PPJBNCHIOGE>> LGLDDONLMBL(DAJCBAEDADB ALFOCLJBJFM, CIHMKPKBLFN FPBMLOPCHIM, int EFCDCBJBHHC, long PMMDPJNEPEE, long? FLIHMCFFMPK, int EFBHJGDEKHC, bool HEDAJEAKGFJ = false, bool IJHHLAFAFEC = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x847AA70", Offset = "0x8479C70", VA = "0x18847AA70", Slot = "11")]
	public CMEBMOPMCFP<BalanceUpdateResponseDTO<PPJBNCHIOGE>> LJHCLLHENGJ(DAJCBAEDADB ALFOCLJBJFM, CIHMKPKBLFN FPBMLOPCHIM, int EFCDCBJBHHC, long PMMDPJNEPEE, long? FLIHMCFFMPK, IReadOnlyCollection<int> BENGKNHBEGF, string BDAAPBJEHGD, bool IIPLHDAFFKN, BAACIDJNIFD BPPECIGFAGM, int EFBHJGDEKHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x8479460", Offset = "0x8478660", VA = "0x188479460", Slot = "12")]
	public CMEBMOPMCFP<BalanceUpdateResponseDTO<PPJBNCHIOGE>> DHOIMKKBCPD(DAJCBAEDADB ALFOCLJBJFM, CIHMKPKBLFN FPBMLOPCHIM, IReadOnlyList<int> COPNDAFIBCO, IReadOnlyList<long> JKAGGAMECOP, long? FLIHMCFFMPK, int DEDGCMPNMDP, string BDAAPBJEHGD, bool IIPLHDAFFKN, BAACIDJNIFD BPPECIGFAGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x847B500", Offset = "0x847A700", VA = "0x18847B500")]
	[AsyncStateMachine(typeof(JCLFBJEFOJP))]
	private Task<List<IKCLLFELIOF>> NDMBHFCCECH(IReadOnlyList<Guid> JLHAFAJDDGD, CancellationToken HCELDNOKOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x847A060", Offset = "0x8479260", VA = "0x18847A060")]
	private void IOJOOPJFBBK(BalanceUpdateResponseDTO<PPJBNCHIOGE> FFKACEKODPA, bool KLFAJEPNKHG, bool IJHHLAFAFEC, bool HEDAJEAKGFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x847A800", Offset = "0x8479A00", VA = "0x18847A800")]
	private void LHJNIPNEPNG(GHKJMIKCPFE CDMOHKDIADF, bool NKHMDLKGIDO, bool BFOAPCMMIMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x847BA90", Offset = "0x847AC90", VA = "0x18847BA90")]
	[AsyncStateMachine(typeof(MPAKEOKEFAP))]
	private Task POBNKEEHNBD(List<JMGCHNCFNHB> PIBPOKJANCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x8479BB0", Offset = "0x8478DB0", VA = "0x188479BB0")]
	[CompilerGenerated]
	private void PAHMGMGGIAK(BalanceUpdateResponseDTO<PPJBNCHIOGE> IGGKBIDIAJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x8479BB0", Offset = "0x8478DB0", VA = "0x188479BB0")]
	[CompilerGenerated]
	private void FLPNNMEFBLB(BalanceUpdateResponseDTO<PPJBNCHIOGE> IGGKBIDIAJL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class ICDBKNEJHGJ : LLJICJAOPDC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly LININKIOLPA DPCIMMMHANO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly PLIGANGDPHD MEAHJGJLOGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly FNEKJGAMJKK KHPFCGFLMKL;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x847F530", Offset = "0x847E730", VA = "0x18847F530")]
	[DBIDCJGLKKO.GKLMLMNDHKE.BABOHFKFEPH]
	internal static void NPCFNJKLMBL(HILJAABEPDC NPCDKJJJIDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0xC40420", Offset = "0xC3F620", VA = "0x180C40420")]
	[RecRoom.NoEngine.Common.Preserve]
	public ICDBKNEJHGJ([ALHAHLCGLLK(null)] LININKIOLPA OACDOHJMHIP, [ALHAHLCGLLK(null)] PLIGANGDPHD DLLAGJGMJFP, [ALHAHLCGLLK(null)] FNEKJGAMJKK KGFMNFNGEKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x847DD80", Offset = "0x847CF80", VA = "0x18847DD80")]
	private bool HHFNPHDMGOJ(DJIDIBIHPNB PBEFEMDGIBN, DJIDIBIHPNB OFGJLNIOMPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x847E4D0", Offset = "0x847D6D0", VA = "0x18847E4D0", Slot = "5")]
	public IReadOnlyList<JMGCHNCFNHB> LDHNKHCLCCC(DJIDIBIHPNB NNFICHHFHGN, IReadOnlyList<JMGCHNCFNHB> FOLAIIIFFFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x847E7B0", Offset = "0x847D9B0", VA = "0x18847E7B0", Slot = "4")]
	public bool LIJIAEJONFE(DJIDIBIHPNB NNFICHHFHGN, JMGCHNCFNHB CKEIAGIGCJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x847D540", Offset = "0x847C740", VA = "0x18847D540")]
	private bool ADKKMBOOFJN(DJIDIBIHPNB NNFICHHFHGN, JMGCHNCFNHB CKEIAGIGCJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x847F630", Offset = "0x847E830", VA = "0x18847F630")]
	private bool PEHFPBPMJDJ(DJIDIBIHPNB NNFICHHFHGN, JMGCHNCFNHB CKEIAGIGCJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x847D700", Offset = "0x847C900", VA = "0x18847D700")]
	private bool DKHFMAMGDBC(DJIDIBIHPNB NNFICHHFHGN, JMGCHNCFNHB CKEIAGIGCJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x847DF50", Offset = "0x847D150", VA = "0x18847DF50")]
	public bool IGDAPJJJNNM(JMGCHNCFNHB JFPIEPHOIPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x847E1A0", Offset = "0x847D3A0", VA = "0x18847E1A0")]
	public bool IGDAPJJJNNM(CPPOBCPJMCA EIBJIBMOIHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x847E270", Offset = "0x847D470", VA = "0x18847E270")]
	private bool JPAOOALNPID(Guid NFCMKJPGKGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x847D6D0", Offset = "0x847C8D0", VA = "0x18847D6D0")]
	private bool DJGPHKGIBLN(DJIDIBIHPNB NNFICHHFHGN, JMGCHNCFNHB CKEIAGIGCJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x847DBD0", Offset = "0x847CDD0", VA = "0x18847DBD0")]
	private bool FMCCKPCGKAG(DJIDIBIHPNB NNFICHHFHGN, JMGCHNCFNHB CKEIAGIGCJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x847D770", Offset = "0x847C970", VA = "0x18847D770")]
	private bool EABBNCBNKAN(DJIDIBIHPNB NNFICHHFHGN, JMGCHNCFNHB CKEIAGIGCJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x847F4C0", Offset = "0x847E6C0", VA = "0x18847F4C0")]
	private bool NMPHIKJJIAA(DJIDIBIHPNB NNFICHHFHGN, JMGCHNCFNHB CKEIAGIGCJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x847D870", Offset = "0x847CA70", VA = "0x18847D870")]
	private bool ECLCAPJIKPH(DJIDIBIHPNB NNFICHHFHGN, JMGCHNCFNHB CKEIAGIGCJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x847DB60", Offset = "0x847CD60", VA = "0x18847DB60")]
	private bool FKMPEDBJJNN(DJIDIBIHPNB NNFICHHFHGN, JMGCHNCFNHB CKEIAGIGCJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x847DEE0", Offset = "0x847D0E0", VA = "0x18847DEE0")]
	private bool IDLGEGBPKFE(DJIDIBIHPNB NNFICHHFHGN, JMGCHNCFNHB CKEIAGIGCJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x847F310", Offset = "0x847E510", VA = "0x18847F310")]
	private bool LMMDHOGOPKF(DJIDIBIHPNB NNFICHHFHGN, JMGCHNCFNHB CKEIAGIGCJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x847E2F0", Offset = "0x847D4F0", VA = "0x18847E2F0")]
	private bool KCJKDCAMBNH(DJIDIBIHPNB NNFICHHFHGN, JMGCHNCFNHB CKEIAGIGCJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x847D8E0", Offset = "0x847CAE0", VA = "0x18847D8E0")]
	private bool EHOPNBIJODG(DJIDIBIHPNB NNFICHHFHGN, JMGCHNCFNHB CKEIAGIGCJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x847F430", Offset = "0x847E630", VA = "0x18847F430")]
	private bool MLGKHBCKOPP(DJIDIBIHPNB NNFICHHFHGN, JMGCHNCFNHB CKEIAGIGCJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x847F5A0", Offset = "0x847E7A0", VA = "0x18847F5A0")]
	private bool OFJJLNIOLOE(DJIDIBIHPNB NNFICHHFHGN, JMGCHNCFNHB CKEIAGIGCJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x847F3A0", Offset = "0x847E5A0", VA = "0x18847F3A0")]
	private bool MAEFLOOCJAL(DJIDIBIHPNB NNFICHHFHGN, JMGCHNCFNHB CKEIAGIGCJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x847DD90", Offset = "0x847CF90", VA = "0x18847DD90")]
	private bool HOEKGOBCJPP(DJIDIBIHPNB NNFICHHFHGN, JMGCHNCFNHB CKEIAGIGCJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x847D640", Offset = "0x847C840", VA = "0x18847D640")]
	private bool ALMEMJGPHKI(DJIDIBIHPNB NNFICHHFHGN, JMGCHNCFNHB CKEIAGIGCJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x847DC80", Offset = "0x847CE80", VA = "0x18847DC80")]
	private bool GCCJLOANFBN(DJIDIBIHPNB NNFICHHFHGN, JMGCHNCFNHB CKEIAGIGCJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x847D970", Offset = "0x847CB70", VA = "0x18847D970")]
	private bool EMBPHHJFMJE(DJIDIBIHPNB NNFICHHFHGN, JMGCHNCFNHB CKEIAGIGCJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x847DAD0", Offset = "0x847CCD0", VA = "0x18847DAD0")]
	private bool FIHFNBIFJLO(DJIDIBIHPNB NNFICHHFHGN, JMGCHNCFNHB CKEIAGIGCJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x847E440", Offset = "0x847D640", VA = "0x18847E440")]
	private bool LAONDJIFOCO(DJIDIBIHPNB NNFICHHFHGN, JMGCHNCFNHB CKEIAGIGCJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x847D7E0", Offset = "0x847C9E0", VA = "0x18847D7E0")]
	private bool EBKCKELGGEP(DJIDIBIHPNB NNFICHHFHGN, JMGCHNCFNHB CKEIAGIGCJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x847DE20", Offset = "0x847D020", VA = "0x18847DE20")]
	private bool IDGAGLPJBDG(DJIDIBIHPNB NNFICHHFHGN, JMGCHNCFNHB CKEIAGIGCJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x847DA00", Offset = "0x847CC00", VA = "0x18847DA00")]
	private bool FCNGBFMGJEM(DJIDIBIHPNB NNFICHHFHGN, JMGCHNCFNHB CKEIAGIGCJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x847E3B0", Offset = "0x847D5B0", VA = "0x18847E3B0")]
	private bool KLKBLOOOHBA(DJIDIBIHPNB NNFICHHFHGN, JMGCHNCFNHB CKEIAGIGCJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x847DD10", Offset = "0x847CF10", VA = "0x18847DD10")]
	private bool GOCBKMEJOIA(DJIDIBIHPNB NNFICHHFHGN, JMGCHNCFNHB CKEIAGIGCJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x847E720", Offset = "0x847D920", VA = "0x18847E720")]
	private bool LFCKFOMDEEG(DJIDIBIHPNB NNFICHHFHGN, JMGCHNCFNHB CKEIAGIGCJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x847DBF0", Offset = "0x847CDF0", VA = "0x18847DBF0")]
	private bool FNFLNABCCNA(DJIDIBIHPNB NNFICHHFHGN, JMGCHNCFNHB CKEIAGIGCJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x847D5D0", Offset = "0x847C7D0", VA = "0x18847D5D0")]
	private bool AKGEKKICFIH(DJIDIBIHPNB NNFICHHFHGN, JMGCHNCFNHB CKEIAGIGCJK)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class HKJKGJGAGLN
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public HKJKGJGAGLN()
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
