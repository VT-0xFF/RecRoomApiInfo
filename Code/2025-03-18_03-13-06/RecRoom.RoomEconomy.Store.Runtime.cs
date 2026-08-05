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
		[Cpp2IlInjected.Address(RVA = "0x7D865A0", Offset = "0x7D857A0", VA = "0x187D865A0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2493E30", Offset = "0x2493030", VA = "0x182493E30")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class BKOKELELHDJ : EBFFFHNOALK, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private struct JADMHLLCHFD : IAsyncStateMachine
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
		public BKOKELELHDJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7D84540", Offset = "0x7D83740", VA = "0x187D84540", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7D84840", Offset = "0x7D83A40", VA = "0x187D84840", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private struct LEPLHBDNGOG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public AsyncTaskMethodBuilder<MPGDFPCDODM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public BKOKELELHDJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public Guid customAvatarItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private TaskAwaiter<MPGDFPCDODM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7D852A0", Offset = "0x7D844A0", VA = "0x187D852A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7D855B0", Offset = "0x7D847B0", VA = "0x187D855B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct PLJHGAAOFCD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public AsyncTaskMethodBuilder<List<JHNNDMCAFNP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public BKOKELELHDJ <>4__this;

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
		private List<JHNNDMCAFNP> <results>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private TaskAwaiter<List<LGFILEBPNEG>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7D85BE0", Offset = "0x7D84DE0", VA = "0x187D85BE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7D86390", Offset = "0x7D85590", VA = "0x187D86390", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct JEEOKGBFOJH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public AsyncTaskMethodBuilder<List<JHNNDMCAFNP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public BKOKELELHDJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public IReadOnlyList<PPCIFNMBIEC> unifiedItemIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private List<JHNNDMCAFNP> <storeItemsInInitialOrder>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private TaskAwaiter<List<LGFILEBPNEG>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7D848A0", Offset = "0x7D83AA0", VA = "0x187D848A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7D85130", Offset = "0x7D84330", VA = "0x187D85130", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct NNJKFAGGPIF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public AsyncTaskMethodBuilder<List<LGFILEBPNEG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public List<LGFILEBPNEG> customAvatarItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public BKOKELELHDJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x7D85620", Offset = "0x7D84820", VA = "0x187D85620", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7D85B20", Offset = "0x7D84D20", VA = "0x187D85B20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class KINMGNIHPGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public PPCIFNMBIEC id;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public KINMGNIHPGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7D851A0", Offset = "0x7D843A0", VA = "0x187D851A0")]
		internal bool OPFGNAGDALB(MLGHNEKKPDB x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7D851E0", Offset = "0x7D843E0", VA = "0x187D851E0")]
		internal bool PKMPCEDCOOK(JHNNDMCAFNP x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class OBGGKNKGICA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public string itemFriendlyName;

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public OBGGKNKGICA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7D85B90", Offset = "0x7D84D90", VA = "0x187D85B90")]
		internal object OAIDGBMOIEK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class FJFDPEONFNG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public BKOKELELHDJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public GiftItemDTO gift;

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public FJFDPEONFNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7D83B50", Offset = "0x7D82D50", VA = "0x187D83B50")]
		internal void KNGODPCEJGO(BalanceUpdateResponseDTO<NDEJMMFMFEK> result)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct HMMLKHEMJCB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncTaskMethodBuilder<HCHPKNGIGFA<BalanceUpdateResponseDTO<NDEJMMFMFEK>>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public BKOKELELHDJ <>4__this;

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
		public JOJCOALEHPO storefrontType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public BOBIMJKOHAM currencyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private TaskAwaiter<MPGDFPCDODM> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private TaskAwaiter<HCHPKNGIGFA<BalanceUpdateResponseDTO<NDEJMMFMFEK>>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7D83B90", Offset = "0x7D82D90", VA = "0x187D83B90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7D84070", Offset = "0x7D83270", VA = "0x187D84070", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class BJJFLMOJJII
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public BKOKELELHDJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public bool handleShowGiftPackage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public bool shouldConsumeGiftBoxImmediately;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public BJJFLMOJJII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7D7FD60", Offset = "0x7D7EF60", VA = "0x187D7FD60")]
		internal void FOHGDEMDJPC(BalanceUpdateResponseDTO<NDEJMMFMFEK> result)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct HOPNIFPHICA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public AsyncTaskMethodBuilder<List<MPGDFPCDODM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public IReadOnlyList<Guid> itemIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public BKOKELELHDJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private TaskAwaiter<List<CDBFKHDAKBO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x7D840E0", Offset = "0x7D832E0", VA = "0x187D840E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7D844D0", Offset = "0x7D836D0", VA = "0x187D844D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct BLBCAHDLBAO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public List<JHNNDMCAFNP> storeItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public BKOKELELHDJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private int <attemptNumber>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7D83630", Offset = "0x7D82830", VA = "0x187D83630", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7D83AF0", Offset = "0x7D82CF0", VA = "0x187D83AF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly JODFJFCACLB<Guid, MPGDFPCDODM> MLBMONLCAHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private DHIOAPMJDOP MLDCKNNNINN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private JKDJGNOOBMN GABHMAOLEBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private FIDLPHPBEKK GJEICPBEFIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private POIMMNLFJPP CAIJFDHMBNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private GIKFDCNEIFA MCOPABLMNHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private FHHIANONFNH MDKMPMLAPBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal OFPMMIIHGKO<Guid, MPGDFPCDODM> JCIFEKAMBIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private bool JPJEOEDAIGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private Task OGDBJKGONKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private CancellationTokenSource GDAJPGGACAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private List<MLGHNEKKPDB> EDGOBOLOMLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private ANHPKLPMBNF? EFAOLNJIDLK;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static EBFFFHNOALK HHMBLIEFNMJ;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private List<MLGHNEKKPDB> JFMOMMIDLAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7D828E0", Offset = "0x7D81AE0", VA = "0x187D828E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private ANHPKLPMBNF BEKMOHDGMAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7D80FB0", Offset = "0x7D801B0", VA = "0x187D80FB0")]
		get
		{
			return default(ANHPKLPMBNF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static EBFFFHNOALK JLGHKLNHGNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7D81DA0", Offset = "0x7D80FA0", VA = "0x187D81DA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7D817D0", Offset = "0x7D809D0", VA = "0x187D817D0")]
	private List<MLGHNEKKPDB> JABHJOJEOOH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7D81E90", Offset = "0x7D81090", VA = "0x187D81E90")]
	[LDKBBAENJDF.GEEMEPAJEEA.KFNNKBLDKPF]
	internal static void LMOFFJNLCLN(ANOENEDKKHA GFOILLNHEFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7D831C0", Offset = "0x7D823C0", VA = "0x187D831C0")]
	[RecRoom.NoEngine.Common.Preserve]
	public BKOKELELHDJ([KMMHIEIDBEA(null)] FIDLPHPBEKK GJEICPBEFIC, [KMMHIEIDBEA(null)] DHIOAPMJDOP MLDCKNNNINN, [KMMHIEIDBEA(null)] JKDJGNOOBMN GABHMAOLEBB, [KMMHIEIDBEA(null)] POIMMNLFJPP CAIJFDHMBNA, [KMMHIEIDBEA(null)] GIKFDCNEIFA MCOPABLMNHG, [KMMHIEIDBEA(null)] FHHIANONFNH MDKMPMLAPBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7D80BB0", Offset = "0x7D7FDB0", VA = "0x187D80BB0", Slot = "1")]
	~BKOKELELHDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7D80B10", Offset = "0x7D7FD10", VA = "0x187D80B10", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7D811D0", Offset = "0x7D803D0", VA = "0x187D811D0")]
	[AsyncStateMachine(typeof(JADMHLLCHFD))]
	private Task HGDLOKIJKOI(CancellationToken KPIINMODKFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7D82860", Offset = "0x7D81A60", VA = "0x187D82860")]
	public void MIPGPKHPIOE(Guid BJDEDKEAADM, MPGDFPCDODM LMAJHPFAFAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7D81940", Offset = "0x7D80B40", VA = "0x187D81940", Slot = "13")]
	public void JMIDACKCDFC(JHNNDMCAFNP PDNDPCPEFBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7D81BE0", Offset = "0x7D80DE0", VA = "0x187D81BE0", Slot = "4")]
	public void LAICEEGEHCK(IEnumerable<JHNNDMCAFNP> CGGMENPHCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7D814C0", Offset = "0x7D806C0", VA = "0x187D814C0", Slot = "14")]
	public MPGDFPCDODM HHLNHBOPHEN(Guid DLBJLJBGNMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7D812C0", Offset = "0x7D804C0", VA = "0x187D812C0", Slot = "5")]
	public MPGDFPCDODM HHLNHBOPHEN(JHNNDMCAFNP PDNDPCPEFBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7D82750", Offset = "0x7D81950", VA = "0x187D82750", Slot = "15")]
	[AsyncStateMachine(typeof(LEPLHBDNGOG))]
	public Task<MPGDFPCDODM> MAFFPJCOLIB(Guid DLBJLJBGNMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7D825F0", Offset = "0x7D817F0", VA = "0x187D825F0", Slot = "6")]
	[AsyncStateMachine(typeof(PLJHGAAOFCD))]
	public Task<List<JHNNDMCAFNP>> LPPLICLCFIH(string FPHDKBBNDNE, bool? HOKJAFNFLLB, bool? HGGLMFEMOHA, IEnumerable<int> GOIEJIDMKLI, bool POBANDIJKJL, bool JNACIBIAIOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7D830A0", Offset = "0x7D822A0", VA = "0x187D830A0", Slot = "7")]
	[AsyncStateMachine(typeof(JEEOKGBFOJH))]
	public Task<List<JHNNDMCAFNP>> POHIBPEIGCL(IReadOnlyList<PPCIFNMBIEC> ABDHBJNIOCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7D816C0", Offset = "0x7D808C0", VA = "0x187D816C0")]
	[AsyncStateMachine(typeof(NNJKFAGGPIF))]
	private Task<List<LGFILEBPNEG>> IEPOHNMIIGB(List<LGFILEBPNEG> DFDDJAMNKNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7D81FD0", Offset = "0x7D811D0", VA = "0x187D81FD0")]
	private List<JHNNDMCAFNP> LNBJPFPFMNL(IReadOnlyList<PPCIFNMBIEC> DAHCIFLKLOM, IReadOnlyList<MLGHNEKKPDB> ANGMNJINGEC, IReadOnlyList<JHNNDMCAFNP> DFDDJAMNKNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7D82BE0", Offset = "0x7D81DE0", VA = "0x187D82BE0", Slot = "8")]
	public JBBNLHPJHLB<BalanceUpdateResponseDTO<NDEJMMFMFEK>> ODEJGLDAJLP(Guid DLBJLJBGNMD, long POBIMLMMJMA, GiftItemDTO OEJDCBPELEM, BOBIMJKOHAM MFDPCLOJDHA = BOBIMJKOHAM.RecCenterTokens, [Optional] long? EDDKHFGBMFB, JOJCOALEHPO IHNLJACAGEM = JOJCOALEHPO.None)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7D82A80", Offset = "0x7D81C80", VA = "0x187D82A80")]
	[AsyncStateMachine(typeof(HMMLKHEMJCB))]
	private Task<HCHPKNGIGFA<BalanceUpdateResponseDTO<NDEJMMFMFEK>>> NCBHMLPPHBO(Guid DLBJLJBGNMD, long POBIMLMMJMA, GiftItemDTO OEJDCBPELEM, BOBIMJKOHAM MFDPCLOJDHA = BOBIMJKOHAM.RecCenterTokens, [Optional] long? EDDKHFGBMFB, JOJCOALEHPO IHNLJACAGEM = JOJCOALEHPO.None)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7D82E40", Offset = "0x7D82040", VA = "0x187D82E40", Slot = "9")]
	public JBBNLHPJHLB<BalanceUpdateResponseDTO<NDEJMMFMFEK>> OHAKFAIHGMM(JOJCOALEHPO IHNLJACAGEM, BOBIMJKOHAM MFDPCLOJDHA, int DHBJFOJNPKL, long POBIMLMMJMA, long? EDDKHFGBMFB, int BEDKPGPFHLI, bool FKLGOMCAMHP = false, bool PBMNEDLHFGE = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7D7FDA0", Offset = "0x7D7EFA0", VA = "0x187D7FDA0", Slot = "10")]
	public JBBNLHPJHLB<BalanceUpdateResponseDTO<NDEJMMFMFEK>> AKNGGCDCDHP(JOJCOALEHPO IHNLJACAGEM, BOBIMJKOHAM MFDPCLOJDHA, int DHBJFOJNPKL, long POBIMLMMJMA, long? EDDKHFGBMFB, IReadOnlyCollection<int> CBMJHKLBJHK, string DCEACFEGBDC, bool JAIPGGNBGIG, BJMCILGJIBE KBNLCBOBMGF, int BEDKPGPFHLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7D80280", Offset = "0x7D7F480", VA = "0x187D80280", Slot = "11")]
	public JBBNLHPJHLB<BalanceUpdateResponseDTO<NDEJMMFMFEK>> BGNEEBLMFME(JOJCOALEHPO IHNLJACAGEM, BOBIMJKOHAM MFDPCLOJDHA, IReadOnlyList<int> DBBGLLENMOF, IReadOnlyList<long> CJPIFFJHDIK, long? EDDKHFGBMFB, int FIGLFBNEMJP, string DCEACFEGBDC, bool JAIPGGNBGIG, BJMCILGJIBE KBNLCBOBMGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7D809D0", Offset = "0x7D7FBD0", VA = "0x187D809D0")]
	[AsyncStateMachine(typeof(HOPNIFPHICA))]
	private Task<List<MPGDFPCDODM>> DMOOJHJIOIC(IReadOnlyList<Guid> JFFJIGMBDLH, CancellationToken KPIINMODKFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7D80CA0", Offset = "0x7D7FEA0", VA = "0x187D80CA0")]
	private void GKGPEIILHDH(BalanceUpdateResponseDTO<NDEJMMFMFEK> IOIAEEJHBDN, bool NLDPLNHDOJC, bool PBMNEDLHFGE, bool FKLGOMCAMHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7D80760", Offset = "0x7D7F960", VA = "0x187D80760")]
	private void BJLODDDLCDI(DINOAJOKBHF MINFGJIBBII, bool JNMIKNLJDHC, bool KGGFCMDKAFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7D815C0", Offset = "0x7D807C0", VA = "0x187D815C0")]
	[AsyncStateMachine(typeof(BLBCAHDLBAO))]
	private Task IBOFMPMHGHF(List<JHNNDMCAFNP> CGGMENPHCOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7D80B80", Offset = "0x7D7FD80", VA = "0x187D80B80")]
	[CompilerGenerated]
	private void FOCLNKGEFDK(BalanceUpdateResponseDTO<NDEJMMFMFEK> CMLOHOMLNDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7D80B80", Offset = "0x7D7FD80", VA = "0x187D80B80")]
	[CompilerGenerated]
	private void LEHJFLCDLKG(BalanceUpdateResponseDTO<NDEJMMFMFEK> CMLOHOMLNDL)
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class DCKHMIAOKJO
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
	public DCKHMIAOKJO()
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
