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
		[Cpp2IlInjected.Address(RVA = "0x8021910", Offset = "0x8020D10", VA = "0x188021910", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x254E750", Offset = "0x254DB50", VA = "0x18254E750")]
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
		[Cpp2IlInjected.Address(RVA = "0x801A800", Offset = "0x8019C00", VA = "0x18801A800", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x801AB00", Offset = "0x8019F00", VA = "0x18801AB00", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x801AFE0", Offset = "0x801A3E0", VA = "0x18801AFE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x801B2B0", Offset = "0x801A6B0", VA = "0x18801B2B0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x8019140", Offset = "0x8018540", VA = "0x188019140", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8019900", Offset = "0x8018D00", VA = "0x188019900", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x8019970", Offset = "0x8018D70", VA = "0x188019970", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x801A240", Offset = "0x8019640", VA = "0x18801A240", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x80211F0", Offset = "0x80205F0", VA = "0x1880211F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x80216F0", Offset = "0x8020AF0", VA = "0x1880216F0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public NCBEHFNMOHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x801D870", Offset = "0x801CC70", VA = "0x18801D870")]
		internal bool LEAAHLJLCAH(LNOHEAIIHPN x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x801D7B0", Offset = "0x801CBB0", VA = "0x18801D7B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public OGHDAFEPMNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x801D8B0", Offset = "0x801CCB0", VA = "0x18801D8B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public LFPDKNMIKPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x801B320", Offset = "0x801A720", VA = "0x18801B320")]
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
		[Cpp2IlInjected.Address(RVA = "0x8018BF0", Offset = "0x8017FF0", VA = "0x188018BF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x80190D0", Offset = "0x80184D0", VA = "0x1880190D0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public NBKOEANHEOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x801D770", Offset = "0x801CB70", VA = "0x18801D770")]
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
		[Cpp2IlInjected.Address(RVA = "0x801AB60", Offset = "0x8019F60", VA = "0x18801AB60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x801AF70", Offset = "0x801A370", VA = "0x18801AF70", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x801A2B0", Offset = "0x80196B0", VA = "0x18801A2B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x801A7A0", Offset = "0x8019BA0", VA = "0x18801A7A0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x80208C0", Offset = "0x801FCC0", VA = "0x1880208C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private FIKHNGFKIGJ LNDOEMOEGPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x801FA20", Offset = "0x801EE20", VA = "0x18801FA20")]
		get
		{
			return default(FIKHNGFKIGJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static LEOONCFCODI DNEPPKLGBFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x801FC40", Offset = "0x801F040", VA = "0x18801FC40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x801EC90", Offset = "0x801E090", VA = "0x18801EC90")]
	private List<LNOHEAIIHPN> GLJIOGJBJFB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x80200B0", Offset = "0x801F4B0", VA = "0x1880200B0")]
	[NOCPMGCIOME.GCMOABIIJJA.PIPKKKEJKGP]
	internal static void OGCPPBNKBAK(DHLGDCALOEP NKMJDOBLHGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x8020D70", Offset = "0x8020170", VA = "0x188020D70")]
	[RecRoom.NoEngine.Common.Preserve]
	public OLLKMPDLOFP([CMKKAFOAFJE(null)] FDLGHKBFDFJ FBFPHGFBKEP, [CMKKAFOAFJE(null)] JBKHHJPCACA MFJJDIDOLLB, [CMKKAFOAFJE(null)] PIOPPMOOMMD KFJIBMLDNME, [CMKKAFOAFJE(null)] EPEOEOGNDLB JDOLGMAMJGE, [CMKKAFOAFJE(null)] LIJOGIGJHBL FOCEHAPAJKO, [CMKKAFOAFJE(null)] KKKJLBLOICG EJMCLPMBLBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x801EA60", Offset = "0x801DE60", VA = "0x18801EA60", Slot = "1")]
	~OLLKMPDLOFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x801E6C0", Offset = "0x801DAC0", VA = "0x18801E6C0", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x801E970", Offset = "0x801DD70", VA = "0x18801E970")]
	[AsyncStateMachine(typeof(HFMIKJMIBPL))]
	private Task EICHNCLEGFJ(CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x8020150", Offset = "0x801F550", VA = "0x188020150")]
	public void OLNDALEFIIN(Guid NGNKEIBNEND, JKBNOMMHCNP FCAJBDHBFLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x801E730", Offset = "0x801DB30", VA = "0x18801E730", Slot = "13")]
	public void EAKCHEAJCFC(CJONIHPBPHK GINDAKCEFBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x801EE00", Offset = "0x801E200", VA = "0x18801EE00", Slot = "4")]
	public void GOJFJGLBDDK(IEnumerable<CJONIHPBPHK> OLKJELILBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x801F5F0", Offset = "0x801E9F0", VA = "0x18801F5F0", Slot = "14")]
	public JKBNOMMHCNP JMAKKFGFNBH(Guid LMGCOEEBLBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x801F700", Offset = "0x801EB00", VA = "0x18801F700", Slot = "5")]
	public JKBNOMMHCNP JMAKKFGFNBH(CJONIHPBPHK GINDAKCEFBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x801FD40", Offset = "0x801F140", VA = "0x18801FD40", Slot = "15")]
	[AsyncStateMachine(typeof(KMDINDMMGGF))]
	public Task<JKBNOMMHCNP> LKNEOJOAJGD(Guid LMGCOEEBLBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x801D900", Offset = "0x801CD00", VA = "0x18801D900", Slot = "6")]
	[AsyncStateMachine(typeof(EJJAFCOGKKF))]
	public Task<List<CJONIHPBPHK>> AALGOCEKHMP(string CHHIMIDMPFM, bool? OEMPMOJBBJL, bool? FIDNFHOOFMF, IEnumerable<int> EADGEJJADEB, bool AMPKFGOPAGN, bool IMHKKFBMCJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x801EB50", Offset = "0x801DF50", VA = "0x18801EB50", Slot = "7")]
	[AsyncStateMachine(typeof(FPJIOJOIMKL))]
	public Task<List<CJONIHPBPHK>> GFFOKGNKGAG(IReadOnlyList<BLIEKJLPENN> ELFACGAHAMA, bool BECFKIAGFFK = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x801F910", Offset = "0x801ED10", VA = "0x18801F910")]
	[AsyncStateMachine(typeof(PJPEMGCMMLO))]
	private Task<List<HEOFMDKPJDJ>> JMHEDGOFONA(List<HEOFMDKPJDJ> DOEAEOCODNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x80202A0", Offset = "0x801F6A0", VA = "0x1880202A0")]
	private List<CJONIHPBPHK> ONEOFDKDIHO(IReadOnlyList<BLIEKJLPENN> PEEBJLNFKEI, IReadOnlyList<LNOHEAIIHPN> AIGMLCEBGLF, IReadOnlyList<CJONIHPBPHK> DOEAEOCODNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x801FE50", Offset = "0x801F250", VA = "0x18801FE50", Slot = "8")]
	public GOBMEFCJDOP<BalanceUpdateResponseDTO<BPHDLNILAAI>> LLFLCIFLIPM(Guid LMGCOEEBLBC, long LHMMCFNMFHK, GiftItemDTO BNOOGHLPMIJ, JMJFIJCEBKJ KMICBDLIHGF = JMJFIJCEBKJ.RecCenterTokens, [Optional] long? CFKIBLGCNPD, KAPAKINLJNB BJOJJMEFCAJ = KAPAKINLJNB.None)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x801DA60", Offset = "0x801CE60", VA = "0x18801DA60")]
	[AsyncStateMachine(typeof(CICNAFCFDMD))]
	private Task<ADGLJICCJCO<BalanceUpdateResponseDTO<BPHDLNILAAI>>> ALJPFFOFOOC(Guid LMGCOEEBLBC, long LHMMCFNMFHK, GiftItemDTO BNOOGHLPMIJ, JMJFIJCEBKJ KMICBDLIHGF = JMJFIJCEBKJ.RecCenterTokens, [Optional] long? CFKIBLGCNPD, KAPAKINLJNB BJOJJMEFCAJ = KAPAKINLJNB.None)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x801E1B0", Offset = "0x801D5B0", VA = "0x18801E1B0", Slot = "9")]
	public GOBMEFCJDOP<BalanceUpdateResponseDTO<BPHDLNILAAI>> CLOLDKCMFFD(KAPAKINLJNB BJOJJMEFCAJ, JMJFIJCEBKJ KMICBDLIHGF, int JFPNPBEOJIC, long LHMMCFNMFHK, long? CFKIBLGCNPD, int GPCNCLKGHHE, bool APOHMELMCDJ = false, bool OHDFCPDCILJ = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x801EFC0", Offset = "0x801E3C0", VA = "0x18801EFC0", Slot = "10")]
	public GOBMEFCJDOP<BalanceUpdateResponseDTO<BPHDLNILAAI>> IHGPLPKDHFE(KAPAKINLJNB BJOJJMEFCAJ, JMJFIJCEBKJ KMICBDLIHGF, int JFPNPBEOJIC, long LHMMCFNMFHK, long? CFKIBLGCNPD, IReadOnlyCollection<int> IAFENCNAOED, string DAMFJFKKFBI, bool BPMOGMAPOGP, CJEELAAIIDE LDHEDJCJGMK, int GPCNCLKGHHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x801DBC0", Offset = "0x801CFC0", VA = "0x18801DBC0", Slot = "11")]
	public GOBMEFCJDOP<BalanceUpdateResponseDTO<BPHDLNILAAI>> AMKHKLAOIKI(KAPAKINLJNB BJOJJMEFCAJ, JMJFIJCEBKJ KMICBDLIHGF, IReadOnlyList<int> DAJHJNHIAFN, IReadOnlyList<long> AGJEIDIAAKF, long? CFKIBLGCNPD, int JECAMNCMGAO, string DAMFJFKKFBI, bool BPMOGMAPOGP, CJEELAAIIDE LDHEDJCJGMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x801F4B0", Offset = "0x801E8B0", VA = "0x18801F4B0")]
	[AsyncStateMachine(typeof(HIEAMJKDCNB))]
	private Task<List<JKBNOMMHCNP>> IMJOPGKNLGN(IReadOnlyList<Guid> CJEIBHFDKEI, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x8020A60", Offset = "0x801FE60", VA = "0x188020A60")]
	private void PODEHGLKBJF(BalanceUpdateResponseDTO<BPHDLNILAAI> DLNNHCPPFNB, bool BGOHEPLINOG, bool OHDFCPDCILJ, bool APOHMELMCDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x801E440", Offset = "0x801D840", VA = "0x18801E440")]
	private void DOMPMINCOLP(HLDNPMEHLBF ELDKIKEONAE, bool COJPNKLNCAH, bool ABAAGPEILLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x801E0B0", Offset = "0x801D4B0", VA = "0x18801E0B0")]
	[AsyncStateMachine(typeof(GKBFBNEKNJD))]
	private Task BEPAJFEFFLP(List<CJONIHPBPHK> OLKJELILBBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x801E410", Offset = "0x801D810", VA = "0x18801E410")]
	[CompilerGenerated]
	private void NMNCLEFFFHJ(BalanceUpdateResponseDTO<BPHDLNILAAI> HBALBIOOGIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x801E410", Offset = "0x801D810", VA = "0x18801E410")]
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
	[Cpp2IlInjected.Address(RVA = "0x801C3D0", Offset = "0x801B7D0", VA = "0x18801C3D0")]
	[NOCPMGCIOME.GCMOABIIJJA.PIPKKKEJKGP]
	internal static void FJKHLPMEJLC(DHLGDCALOEP NKMJDOBLHGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0xBA0FD0", Offset = "0xBA03D0", VA = "0x180BA0FD0")]
	[RecRoom.NoEngine.Common.Preserve]
	public MKODHBGHGCH([CMKKAFOAFJE(null)] LIJOGIGJHBL FOCEHAPAJKO, [CMKKAFOAFJE(null)] NHHFHOCOGEC DNDEINMDIFI, [CMKKAFOAFJE(null)] CMJJFFBOJOO DOEAEOCODNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x801C3C0", Offset = "0x801B7C0", VA = "0x18801C3C0")]
	private bool FFAJNOEDICD(NLJANFOAFJJ LHBGKGAFGJO, NLJANFOAFJJ MIPBHMAKNFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x801CC40", Offset = "0x801C040", VA = "0x18801CC40", Slot = "5")]
	public IReadOnlyList<CJONIHPBPHK> KGAHGODOEEM(NLJANFOAFJJ EPAFBKOOOLI, IReadOnlyList<CJONIHPBPHK> KKIPPMFKGPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x801B630", Offset = "0x801AA30", VA = "0x18801B630", Slot = "4")]
	public bool CHPMIANEPOM(NLJANFOAFJJ EPAFBKOOOLI, CJONIHPBPHK MGCEJOCCONP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x801D660", Offset = "0x801CA60", VA = "0x18801D660")]
	private bool PCBANOOJBJL(NLJANFOAFJJ EPAFBKOOOLI, CJONIHPBPHK MGCEJOCCONP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x801C830", Offset = "0x801BC30", VA = "0x18801C830")]
	private bool JHNAKHMNEDJ(NLJANFOAFJJ EPAFBKOOOLI, CJONIHPBPHK MGCEJOCCONP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x801D430", Offset = "0x801C830", VA = "0x18801D430")]
	private bool NCOLCKMPDOK(NLJANFOAFJJ EPAFBKOOOLI, CJONIHPBPHK MGCEJOCCONP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x801D1E0", Offset = "0x801C5E0", VA = "0x18801D1E0")]
	public bool NAMEKLIIEOK(CJONIHPBPHK GINDAKCEFBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x801D110", Offset = "0x801C510", VA = "0x18801D110")]
	public bool NAMEKLIIEOK(FLKKIGJEGDH KNJBJLBPDBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x801D6F0", Offset = "0x801CAF0", VA = "0x18801D6F0")]
	private bool PDGBIIDOJLE(Guid LMGCOEEBLBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x801CE90", Offset = "0x801C290", VA = "0x18801CE90")]
	private bool LFJHJOEFHHC(NLJANFOAFJJ EPAFBKOOOLI, CJONIHPBPHK MGCEJOCCONP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x801C440", Offset = "0x801B840", VA = "0x18801C440")]
	private bool GHEPKBMILMM(NLJANFOAFJJ EPAFBKOOOLI, CJONIHPBPHK MGCEJOCCONP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x801CB40", Offset = "0x801BF40", VA = "0x18801CB40")]
	private bool JNGFKEKJFGG(NLJANFOAFJJ EPAFBKOOOLI, CJONIHPBPHK MGCEJOCCONP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x801C460", Offset = "0x801B860", VA = "0x18801C460")]
	private bool GHKABGGJFLG(NLJANFOAFJJ EPAFBKOOOLI, CJONIHPBPHK MGCEJOCCONP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x801C730", Offset = "0x801BB30", VA = "0x18801C730")]
	private bool HKFEDDABGGK(NLJANFOAFJJ EPAFBKOOOLI, CJONIHPBPHK MGCEJOCCONP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x801D010", Offset = "0x801C410", VA = "0x18801D010")]
	private bool MLIGMKKJIPH(NLJANFOAFJJ EPAFBKOOOLI, CJONIHPBPHK MGCEJOCCONP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x801C1A0", Offset = "0x801B5A0", VA = "0x18801C1A0")]
	private bool CKHGKDNNIFE(NLJANFOAFJJ EPAFBKOOOLI, CJONIHPBPHK MGCEJOCCONP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x801B360", Offset = "0x801A760", VA = "0x18801B360")]
	private bool ADKPOCMHMLN(NLJANFOAFJJ EPAFBKOOOLI, CJONIHPBPHK MGCEJOCCONP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x801D4A0", Offset = "0x801C8A0", VA = "0x18801D4A0")]
	private bool OADCCNGIKDD(NLJANFOAFJJ EPAFBKOOOLI, CJONIHPBPHK MGCEJOCCONP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x801B5A0", Offset = "0x801A9A0", VA = "0x18801B5A0")]
	private bool BPMIHDKMJPO(NLJANFOAFJJ EPAFBKOOOLI, CJONIHPBPHK MGCEJOCCONP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x801D560", Offset = "0x801C960", VA = "0x18801D560")]
	private bool OBJFHHCOPCA(NLJANFOAFJJ EPAFBKOOOLI, CJONIHPBPHK MGCEJOCCONP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x801D080", Offset = "0x801C480", VA = "0x18801D080")]
	private bool MPEIGFNNDLB(NLJANFOAFJJ EPAFBKOOOLI, CJONIHPBPHK MGCEJOCCONP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x801C330", Offset = "0x801B730", VA = "0x18801C330")]
	private bool FBJDODJHGNI(NLJANFOAFJJ EPAFBKOOOLI, CJONIHPBPHK MGCEJOCCONP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x801C210", Offset = "0x801B610", VA = "0x18801C210")]
	private bool DAFJKBCEHMI(NLJANFOAFJJ EPAFBKOOOLI, CJONIHPBPHK MGCEJOCCONP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x801C2A0", Offset = "0x801B6A0", VA = "0x18801C2A0")]
	private bool DGLFIPFCHDK(NLJANFOAFJJ EPAFBKOOOLI, CJONIHPBPHK MGCEJOCCONP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x801B510", Offset = "0x801A910", VA = "0x18801B510")]
	private bool BDGDPDFLFOL(NLJANFOAFJJ EPAFBKOOOLI, CJONIHPBPHK MGCEJOCCONP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x801B3F0", Offset = "0x801A7F0", VA = "0x18801B3F0")]
	private bool AIOIFACBKKP(NLJANFOAFJJ EPAFBKOOOLI, CJONIHPBPHK MGCEJOCCONP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x801CBB0", Offset = "0x801BFB0", VA = "0x18801CBB0")]
	private bool JOPHOAAHINK(NLJANFOAFJJ EPAFBKOOOLI, CJONIHPBPHK MGCEJOCCONP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x801CF80", Offset = "0x801C380", VA = "0x18801CF80")]
	private bool MCCCOEANCCO(NLJANFOAFJJ EPAFBKOOOLI, CJONIHPBPHK MGCEJOCCONP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x801C5A0", Offset = "0x801B9A0", VA = "0x18801C5A0")]
	private bool GPJDCKIOLGG(NLJANFOAFJJ EPAFBKOOOLI, CJONIHPBPHK MGCEJOCCONP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x801CEC0", Offset = "0x801C2C0", VA = "0x18801CEC0")]
	private bool LICIHHDNOEG(NLJANFOAFJJ EPAFBKOOOLI, CJONIHPBPHK MGCEJOCCONP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x801C4D0", Offset = "0x801B8D0", VA = "0x18801C4D0")]
	private bool GIDFOGHJPKD(NLJANFOAFJJ EPAFBKOOOLI, CJONIHPBPHK MGCEJOCCONP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x801B480", Offset = "0x801A880", VA = "0x18801B480")]
	private bool AOMMEKPOOKD(NLJANFOAFJJ EPAFBKOOOLI, CJONIHPBPHK MGCEJOCCONP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x801C630", Offset = "0x801BA30", VA = "0x18801C630")]
	private bool HBDJMGLPPLC(NLJANFOAFJJ EPAFBKOOOLI, CJONIHPBPHK MGCEJOCCONP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x801C6A0", Offset = "0x801BAA0", VA = "0x18801C6A0")]
	private bool HJCEHNONIEL(NLJANFOAFJJ EPAFBKOOOLI, CJONIHPBPHK MGCEJOCCONP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x801C7A0", Offset = "0x801BBA0", VA = "0x18801C7A0")]
	private bool IPKOOAFFGEC(NLJANFOAFJJ EPAFBKOOOLI, CJONIHPBPHK MGCEJOCCONP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x801D5F0", Offset = "0x801C9F0", VA = "0x18801D5F0")]
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
	[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
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
