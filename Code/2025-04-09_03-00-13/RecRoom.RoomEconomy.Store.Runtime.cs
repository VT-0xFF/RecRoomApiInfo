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
		[Cpp2IlInjected.Address(RVA = "0x806D780", Offset = "0x806CB80", VA = "0x18806D780", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2553680", Offset = "0x2552A80", VA = "0x182553680")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class OLLKMPDLOFP : LEOONCFCODI, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private struct HFMIKJMIBPL : IAsyncStateMachine
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
		public OLLKMPDLOFP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8066710", Offset = "0x8065B10", VA = "0x188066710", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8066A10", Offset = "0x8065E10", VA = "0x188066A10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private struct KMDINDMMGGF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public AsyncTaskMethodBuilder<JKBNOMMHCNP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public OLLKMPDLOFP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public Guid customAvatarItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private TaskAwaiter<JKBNOMMHCNP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8066EE0", Offset = "0x80662E0", VA = "0x188066EE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x80671B0", Offset = "0x80665B0", VA = "0x1880671B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct EJJAFCOGKKF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public AsyncTaskMethodBuilder<List<CJONIHPBPHK>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public OLLKMPDLOFP <>4__this;

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
		private List<CJONIHPBPHK> <results>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private TaskAwaiter<List<HEOFMDKPJDJ>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8065090", Offset = "0x8064490", VA = "0x188065090", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8065840", Offset = "0x8064C40", VA = "0x188065840", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct FPJIOJOIMKL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public AsyncTaskMethodBuilder<List<CJONIHPBPHK>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public OLLKMPDLOFP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public IReadOnlyList<BLIEKJLPENN> unifiedItemIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public bool convertCustomAvatarItemsToPurchasableGiftDrops;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private List<CJONIHPBPHK> <storeItemsInInitialOrder>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private TaskAwaiter<List<HEOFMDKPJDJ>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x80658B0", Offset = "0x8064CB0", VA = "0x1880658B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8066150", Offset = "0x8065550", VA = "0x188066150", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct PJPEMGCMMLO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public AsyncTaskMethodBuilder<List<HEOFMDKPJDJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public List<HEOFMDKPJDJ> customAvatarItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public OLLKMPDLOFP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x806D090", Offset = "0x806C490", VA = "0x18806D090", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x806D580", Offset = "0x806C980", VA = "0x18806D580", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class NCBEHFNMOHE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public BLIEKJLPENN id;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public NCBEHFNMOHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x80697B0", Offset = "0x8068BB0", VA = "0x1880697B0")]
		internal bool LEAAHLJLCAH(LNOHEAIIHPN x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x80696F0", Offset = "0x8068AF0", VA = "0x1880696F0")]
		internal bool CLEJHDFHEPE(CJONIHPBPHK x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class OGHDAFEPMNJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public string itemFriendlyName;

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public OGHDAFEPMNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x80697F0", Offset = "0x8068BF0", VA = "0x1880697F0")]
		internal object LGDDNMBNCMH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class LFPDKNMIKPA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public OLLKMPDLOFP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public GiftItemDTO gift;

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public LFPDKNMIKPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8067220", Offset = "0x8066620", VA = "0x188067220")]
		internal void FNFMJEILJEE(BalanceUpdateResponseDTO<BPHDLNILAAI> result)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct CICNAFCFDMD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public AsyncTaskMethodBuilder<ADGLJICCJCO<BalanceUpdateResponseDTO<BPHDLNILAAI>>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public OLLKMPDLOFP <>4__this;

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
		public KAPAKINLJNB storefrontType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public JMJFIJCEBKJ currencyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private TaskAwaiter<JKBNOMMHCNP> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private TaskAwaiter<ADGLJICCJCO<BalanceUpdateResponseDTO<BPHDLNILAAI>>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8064B40", Offset = "0x8063F40", VA = "0x188064B40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8065020", Offset = "0x8064420", VA = "0x188065020", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class NBKOEANHEOE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public OLLKMPDLOFP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public bool handleShowGiftPackage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public bool shouldConsumeGiftBoxImmediately;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public NBKOEANHEOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x80696B0", Offset = "0x8068AB0", VA = "0x1880696B0")]
		internal void MHFIJPCCKOM(BalanceUpdateResponseDTO<BPHDLNILAAI> result)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct HIEAMJKDCNB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public AsyncTaskMethodBuilder<List<JKBNOMMHCNP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public IReadOnlyList<Guid> itemIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public OLLKMPDLOFP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private TaskAwaiter<List<AECNAAHPLCJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8066A70", Offset = "0x8065E70", VA = "0x188066A70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8066E70", Offset = "0x8066270", VA = "0x188066E70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct GKBFBNEKNJD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public List<CJONIHPBPHK> storeItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public OLLKMPDLOFP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private int <attemptNumber>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x80661C0", Offset = "0x80655C0", VA = "0x1880661C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x80666B0", Offset = "0x8065AB0", VA = "0x1880666B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly FDHHDLDLLOD<Guid, JKBNOMMHCNP> IDHEDJNOBKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private JBKHHJPCACA MFJJDIDOLLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private PIOPPMOOMMD KFJIBMLDNME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private FDLGHKBFDFJ FBFPHGFBKEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private EPEOEOGNDLB JDOLGMAMJGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private LIJOGIGJHBL FOCEHAPAJKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private KKKJLBLOICG EJMCLPMBLBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal GDHFCHKNKML<Guid, JKBNOMMHCNP> NDPNCMDEDOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private bool EKDCONIHOMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private Task ADMPFHEBBBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private CancellationTokenSource HODGNKANLED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private List<LNOHEAIIHPN> FFHLFEHGDBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private FIKHNGFKIGJ? DNPLNNFPCHB;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static LEOONCFCODI CIGDLNGNHMF;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private List<LNOHEAIIHPN> JGMBGJKPLLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x806C770", Offset = "0x806BB70", VA = "0x18806C770")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private FIKHNGFKIGJ LNDOEMOEGPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x806B900", Offset = "0x806AD00", VA = "0x18806B900")]
		get
		{
			return default(FIKHNGFKIGJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static LEOONCFCODI DNEPPKLGBFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x806BB10", Offset = "0x806AF10", VA = "0x18806BB10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x806ABA0", Offset = "0x8069FA0", VA = "0x18806ABA0")]
	private List<LNOHEAIIHPN> GLJIOGJBJFB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x806BF70", Offset = "0x806B370", VA = "0x18806BF70")]
	[NOCPMGCIOME.GCMOABIIJJA.PIPKKKEJKGP]
	internal static void OGCPPBNKBAK(DHLGDCALOEP NKMJDOBLHGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x806CC20", Offset = "0x806C020", VA = "0x18806CC20")]
	[RecRoom.NoEngine.Common.Preserve]
	public OLLKMPDLOFP([CMKKAFOAFJE(null)] FDLGHKBFDFJ FBFPHGFBKEP, [CMKKAFOAFJE(null)] JBKHHJPCACA MFJJDIDOLLB, [CMKKAFOAFJE(null)] PIOPPMOOMMD KFJIBMLDNME, [CMKKAFOAFJE(null)] EPEOEOGNDLB JDOLGMAMJGE, [CMKKAFOAFJE(null)] LIJOGIGJHBL FOCEHAPAJKO, [CMKKAFOAFJE(null)] KKKJLBLOICG EJMCLPMBLBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x806A970", Offset = "0x8069D70", VA = "0x18806A970", Slot = "1")]
	~OLLKMPDLOFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x806A5E0", Offset = "0x80699E0", VA = "0x18806A5E0", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x806A880", Offset = "0x8069C80", VA = "0x18806A880")]
	[AsyncStateMachine(typeof(HFMIKJMIBPL))]
	private Task EICHNCLEGFJ(CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x806C010", Offset = "0x806B410", VA = "0x18806C010")]
	public void OLNDALEFIIN(Guid NGNKEIBNEND, JKBNOMMHCNP FCAJBDHBFLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x806A650", Offset = "0x8069A50", VA = "0x18806A650", Slot = "13")]
	public void EAKCHEAJCFC(CJONIHPBPHK GINDAKCEFBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x806AD10", Offset = "0x806A110", VA = "0x18806AD10", Slot = "4")]
	public void GOJFJGLBDDK(IEnumerable<CJONIHPBPHK> OLKJELILBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x806B4F0", Offset = "0x806A8F0", VA = "0x18806B4F0", Slot = "14")]
	public JKBNOMMHCNP JMAKKFGFNBH(Guid LMGCOEEBLBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x806B5F0", Offset = "0x806A9F0", VA = "0x18806B5F0", Slot = "5")]
	public JKBNOMMHCNP JMAKKFGFNBH(CJONIHPBPHK GINDAKCEFBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x806BC00", Offset = "0x806B000", VA = "0x18806BC00", Slot = "15")]
	[AsyncStateMachine(typeof(KMDINDMMGGF))]
	public Task<JKBNOMMHCNP> LKNEOJOAJGD(Guid LMGCOEEBLBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x8069840", Offset = "0x8068C40", VA = "0x188069840", Slot = "6")]
	[AsyncStateMachine(typeof(EJJAFCOGKKF))]
	public Task<List<CJONIHPBPHK>> AALGOCEKHMP(string CHHIMIDMPFM, bool? OEMPMOJBBJL, bool? FIDNFHOOFMF, IEnumerable<int> EADGEJJADEB, bool AMPKFGOPAGN, bool IMHKKFBMCJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x806AA60", Offset = "0x8069E60", VA = "0x18806AA60", Slot = "7")]
	[AsyncStateMachine(typeof(FPJIOJOIMKL))]
	public Task<List<CJONIHPBPHK>> GFFOKGNKGAG(IReadOnlyList<BLIEKJLPENN> ELFACGAHAMA, bool BECFKIAGFFK = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x806B7F0", Offset = "0x806ABF0", VA = "0x18806B7F0")]
	[AsyncStateMachine(typeof(PJPEMGCMMLO))]
	private Task<List<HEOFMDKPJDJ>> JMHEDGOFONA(List<HEOFMDKPJDJ> DOEAEOCODNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x806C150", Offset = "0x806B550", VA = "0x18806C150")]
	private List<CJONIHPBPHK> ONEOFDKDIHO(IReadOnlyList<BLIEKJLPENN> PEEBJLNFKEI, IReadOnlyList<LNOHEAIIHPN> AIGMLCEBGLF, IReadOnlyList<CJONIHPBPHK> DOEAEOCODNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x806BD10", Offset = "0x806B110", VA = "0x18806BD10", Slot = "8")]
	public GOBMEFCJDOP<BalanceUpdateResponseDTO<BPHDLNILAAI>> LLFLCIFLIPM(Guid LMGCOEEBLBC, long LHMMCFNMFHK, GiftItemDTO BNOOGHLPMIJ, JMJFIJCEBKJ KMICBDLIHGF = JMJFIJCEBKJ.RecCenterTokens, [Optional] long? CFKIBLGCNPD, KAPAKINLJNB BJOJJMEFCAJ = KAPAKINLJNB.None)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x80699A0", Offset = "0x8068DA0", VA = "0x1880699A0")]
	[AsyncStateMachine(typeof(CICNAFCFDMD))]
	private Task<ADGLJICCJCO<BalanceUpdateResponseDTO<BPHDLNILAAI>>> ALJPFFOFOOC(Guid LMGCOEEBLBC, long LHMMCFNMFHK, GiftItemDTO BNOOGHLPMIJ, JMJFIJCEBKJ KMICBDLIHGF = JMJFIJCEBKJ.RecCenterTokens, [Optional] long? CFKIBLGCNPD, KAPAKINLJNB BJOJJMEFCAJ = KAPAKINLJNB.None)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x806A0E0", Offset = "0x80694E0", VA = "0x18806A0E0", Slot = "9")]
	public GOBMEFCJDOP<BalanceUpdateResponseDTO<BPHDLNILAAI>> CLOLDKCMFFD(KAPAKINLJNB BJOJJMEFCAJ, JMJFIJCEBKJ KMICBDLIHGF, int JFPNPBEOJIC, long LHMMCFNMFHK, long? CFKIBLGCNPD, int GPCNCLKGHHE, bool APOHMELMCDJ = false, bool OHDFCPDCILJ = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x806AEC0", Offset = "0x806A2C0", VA = "0x18806AEC0", Slot = "10")]
	public GOBMEFCJDOP<BalanceUpdateResponseDTO<BPHDLNILAAI>> IHGPLPKDHFE(KAPAKINLJNB BJOJJMEFCAJ, JMJFIJCEBKJ KMICBDLIHGF, int JFPNPBEOJIC, long LHMMCFNMFHK, long? CFKIBLGCNPD, IReadOnlyCollection<int> IAFENCNAOED, string DAMFJFKKFBI, bool BPMOGMAPOGP, CJEELAAIIDE LDHEDJCJGMK, int GPCNCLKGHHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x8069B00", Offset = "0x8068F00", VA = "0x188069B00", Slot = "11")]
	public GOBMEFCJDOP<BalanceUpdateResponseDTO<BPHDLNILAAI>> AMKHKLAOIKI(KAPAKINLJNB BJOJJMEFCAJ, JMJFIJCEBKJ KMICBDLIHGF, IReadOnlyList<int> DAJHJNHIAFN, IReadOnlyList<long> AGJEIDIAAKF, long? CFKIBLGCNPD, int JECAMNCMGAO, string DAMFJFKKFBI, bool BPMOGMAPOGP, CJEELAAIIDE LDHEDJCJGMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x806B3B0", Offset = "0x806A7B0", VA = "0x18806B3B0")]
	[AsyncStateMachine(typeof(HIEAMJKDCNB))]
	private Task<List<JKBNOMMHCNP>> IMJOPGKNLGN(IReadOnlyList<Guid> CJEIBHFDKEI, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x806C910", Offset = "0x806BD10", VA = "0x18806C910")]
	private void PODEHGLKBJF(BalanceUpdateResponseDTO<BPHDLNILAAI> DLNNHCPPFNB, bool BGOHEPLINOG, bool OHDFCPDCILJ, bool APOHMELMCDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x806A370", Offset = "0x8069770", VA = "0x18806A370")]
	private void DOMPMINCOLP(HLDNPMEHLBF ELDKIKEONAE, bool COJPNKLNCAH, bool ABAAGPEILLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x8069FE0", Offset = "0x80693E0", VA = "0x188069FE0")]
	[AsyncStateMachine(typeof(GKBFBNEKNJD))]
	private Task BEPAJFEFFLP(List<CJONIHPBPHK> OLKJELILBBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x806A340", Offset = "0x8069740", VA = "0x18806A340")]
	[CompilerGenerated]
	private void NMNCLEFFFHJ(BalanceUpdateResponseDTO<BPHDLNILAAI> HBALBIOOGIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x806A340", Offset = "0x8069740", VA = "0x18806A340")]
	[CompilerGenerated]
	private void DEFGPGJMFAP(BalanceUpdateResponseDTO<BPHDLNILAAI> HBALBIOOGIJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class MKODHBGHGCH : LHCODJPAKGI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly LIJOGIGJHBL DJDODIJIJBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly NHHFHOCOGEC OJGMDKGOKBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly CMJJFFBOJOO KEMDLEHOKIN;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x80682D0", Offset = "0x80676D0", VA = "0x1880682D0")]
	[NOCPMGCIOME.GCMOABIIJJA.PIPKKKEJKGP]
	internal static void FJKHLPMEJLC(DHLGDCALOEP NKMJDOBLHGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0xBA82B0", Offset = "0xBA76B0", VA = "0x180BA82B0")]
	[RecRoom.NoEngine.Common.Preserve]
	public MKODHBGHGCH([CMKKAFOAFJE(null)] LIJOGIGJHBL FOCEHAPAJKO, [CMKKAFOAFJE(null)] NHHFHOCOGEC DNDEINMDIFI, [CMKKAFOAFJE(null)] CMJJFFBOJOO DOEAEOCODNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x80682C0", Offset = "0x80676C0", VA = "0x1880682C0")]
	private bool FFAJNOEDICD(NLJANFOAFJJ LHBGKGAFGJO, NLJANFOAFJJ MIPBHMAKNFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x8068B90", Offset = "0x8067F90", VA = "0x188068B90", Slot = "5")]
	public IReadOnlyList<CJONIHPBPHK> KGAHGODOEEM(NLJANFOAFJJ EPAFBKOOOLI, IReadOnlyList<CJONIHPBPHK> KKIPPMFKGPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x8067530", Offset = "0x8066930", VA = "0x188067530", Slot = "4")]
	public bool CHPMIANEPOM(NLJANFOAFJJ EPAFBKOOOLI, CJONIHPBPHK MGCEJOCCONP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x80695A0", Offset = "0x80689A0", VA = "0x1880695A0")]
	private bool PCBANOOJBJL(NLJANFOAFJJ EPAFBKOOOLI, CJONIHPBPHK MGCEJOCCONP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x8068730", Offset = "0x8067B30", VA = "0x188068730")]
	private bool JHNAKHMNEDJ(NLJANFOAFJJ EPAFBKOOOLI, CJONIHPBPHK MGCEJOCCONP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x8069370", Offset = "0x8068770", VA = "0x188069370")]
	private bool NCOLCKMPDOK(NLJANFOAFJJ EPAFBKOOOLI, CJONIHPBPHK MGCEJOCCONP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x8069120", Offset = "0x8068520", VA = "0x188069120")]
	public bool NAMEKLIIEOK(CJONIHPBPHK GINDAKCEFBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x8069060", Offset = "0x8068460", VA = "0x188069060")]
	public bool NAMEKLIIEOK(FLKKIGJEGDH KNJBJLBPDBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x8069630", Offset = "0x8068A30", VA = "0x188069630")]
	private bool PDGBIIDOJLE(Guid LMGCOEEBLBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x8068DE0", Offset = "0x80681E0", VA = "0x188068DE0")]
	private bool LFJHJOEFHHC(NLJANFOAFJJ EPAFBKOOOLI, CJONIHPBPHK MGCEJOCCONP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x8068340", Offset = "0x8067740", VA = "0x188068340")]
	private bool GHEPKBMILMM(NLJANFOAFJJ EPAFBKOOOLI, CJONIHPBPHK MGCEJOCCONP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x8068A90", Offset = "0x8067E90", VA = "0x188068A90")]
	private bool JNGFKEKJFGG(NLJANFOAFJJ EPAFBKOOOLI, CJONIHPBPHK MGCEJOCCONP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x8068360", Offset = "0x8067760", VA = "0x188068360")]
	private bool GHKABGGJFLG(NLJANFOAFJJ EPAFBKOOOLI, CJONIHPBPHK MGCEJOCCONP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x8068630", Offset = "0x8067A30", VA = "0x188068630")]
	private bool HKFEDDABGGK(NLJANFOAFJJ EPAFBKOOOLI, CJONIHPBPHK MGCEJOCCONP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x8068F60", Offset = "0x8068360", VA = "0x188068F60")]
	private bool MLIGMKKJIPH(NLJANFOAFJJ EPAFBKOOOLI, CJONIHPBPHK MGCEJOCCONP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x80680A0", Offset = "0x80674A0", VA = "0x1880680A0")]
	private bool CKHGKDNNIFE(NLJANFOAFJJ EPAFBKOOOLI, CJONIHPBPHK MGCEJOCCONP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x8067260", Offset = "0x8066660", VA = "0x188067260")]
	private bool ADKPOCMHMLN(NLJANFOAFJJ EPAFBKOOOLI, CJONIHPBPHK MGCEJOCCONP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x80693E0", Offset = "0x80687E0", VA = "0x1880693E0")]
	private bool OADCCNGIKDD(NLJANFOAFJJ EPAFBKOOOLI, CJONIHPBPHK MGCEJOCCONP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x80674A0", Offset = "0x80668A0", VA = "0x1880674A0")]
	private bool BPMIHDKMJPO(NLJANFOAFJJ EPAFBKOOOLI, CJONIHPBPHK MGCEJOCCONP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x80694A0", Offset = "0x80688A0", VA = "0x1880694A0")]
	private bool OBJFHHCOPCA(NLJANFOAFJJ EPAFBKOOOLI, CJONIHPBPHK MGCEJOCCONP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x8068FD0", Offset = "0x80683D0", VA = "0x188068FD0")]
	private bool MPEIGFNNDLB(NLJANFOAFJJ EPAFBKOOOLI, CJONIHPBPHK MGCEJOCCONP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x8068230", Offset = "0x8067630", VA = "0x188068230")]
	private bool FBJDODJHGNI(NLJANFOAFJJ EPAFBKOOOLI, CJONIHPBPHK MGCEJOCCONP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x8068110", Offset = "0x8067510", VA = "0x188068110")]
	private bool DAFJKBCEHMI(NLJANFOAFJJ EPAFBKOOOLI, CJONIHPBPHK MGCEJOCCONP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x80681A0", Offset = "0x80675A0", VA = "0x1880681A0")]
	private bool DGLFIPFCHDK(NLJANFOAFJJ EPAFBKOOOLI, CJONIHPBPHK MGCEJOCCONP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x8067410", Offset = "0x8066810", VA = "0x188067410")]
	private bool BDGDPDFLFOL(NLJANFOAFJJ EPAFBKOOOLI, CJONIHPBPHK MGCEJOCCONP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x80672F0", Offset = "0x80666F0", VA = "0x1880672F0")]
	private bool AIOIFACBKKP(NLJANFOAFJJ EPAFBKOOOLI, CJONIHPBPHK MGCEJOCCONP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x8068B00", Offset = "0x8067F00", VA = "0x188068B00")]
	private bool JOPHOAAHINK(NLJANFOAFJJ EPAFBKOOOLI, CJONIHPBPHK MGCEJOCCONP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x8068ED0", Offset = "0x80682D0", VA = "0x188068ED0")]
	private bool MCCCOEANCCO(NLJANFOAFJJ EPAFBKOOOLI, CJONIHPBPHK MGCEJOCCONP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x80684A0", Offset = "0x80678A0", VA = "0x1880684A0")]
	private bool GPJDCKIOLGG(NLJANFOAFJJ EPAFBKOOOLI, CJONIHPBPHK MGCEJOCCONP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x8068E10", Offset = "0x8068210", VA = "0x188068E10")]
	private bool LICIHHDNOEG(NLJANFOAFJJ EPAFBKOOOLI, CJONIHPBPHK MGCEJOCCONP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x80683D0", Offset = "0x80677D0", VA = "0x1880683D0")]
	private bool GIDFOGHJPKD(NLJANFOAFJJ EPAFBKOOOLI, CJONIHPBPHK MGCEJOCCONP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x8067380", Offset = "0x8066780", VA = "0x188067380")]
	private bool AOMMEKPOOKD(NLJANFOAFJJ EPAFBKOOOLI, CJONIHPBPHK MGCEJOCCONP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x8068530", Offset = "0x8067930", VA = "0x188068530")]
	private bool HBDJMGLPPLC(NLJANFOAFJJ EPAFBKOOOLI, CJONIHPBPHK MGCEJOCCONP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x80685A0", Offset = "0x80679A0", VA = "0x1880685A0")]
	private bool HJCEHNONIEL(NLJANFOAFJJ EPAFBKOOOLI, CJONIHPBPHK MGCEJOCCONP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x80686A0", Offset = "0x8067AA0", VA = "0x1880686A0")]
	private bool IPKOOAFFGEC(NLJANFOAFJJ EPAFBKOOOLI, CJONIHPBPHK MGCEJOCCONP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x8069530", Offset = "0x8068930", VA = "0x188069530")]
	private bool OKFMIOLAJMD(NLJANFOAFJJ EPAFBKOOOLI, CJONIHPBPHK MGCEJOCCONP)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class PLEFJCMKMIM
{
	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
	public PLEFJCMKMIM()
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
