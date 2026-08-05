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
		[Cpp2IlInjected.Address(RVA = "0x85B6160", Offset = "0x85B4F60", VA = "0x1885B6160", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x26D4E40", Offset = "0x26D3C40", VA = "0x1826D4E40")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class MLIALKLCJBO : DJADCCMIHBB, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private struct DENGBCNBFLN : IAsyncStateMachine
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
		public MLIALKLCJBO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x85ADBB0", Offset = "0x85AC9B0", VA = "0x1885ADBB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x85ADEB0", Offset = "0x85ACCB0", VA = "0x1885ADEB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private struct LLMHADABGEM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public AsyncTaskMethodBuilder<ELHHJKFDJGF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public MLIALKLCJBO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public Guid customAvatarItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private TaskAwaiter<ELHHJKFDJGF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x85AF750", Offset = "0x85AE550", VA = "0x1885AF750", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x85AFA20", Offset = "0x85AE820", VA = "0x1885AFA20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct JCHHJLMPAAC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public AsyncTaskMethodBuilder<List<PAJCNFAEALM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public MLIALKLCJBO <>4__this;

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
		private List<PAJCNFAEALM> <results>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private TaskAwaiter<List<BADAFKCAGKI>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x85AE9D0", Offset = "0x85AD7D0", VA = "0x1885AE9D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x85AF190", Offset = "0x85ADF90", VA = "0x1885AF190", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct AEMDCOLOOPH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public AsyncTaskMethodBuilder<List<PAJCNFAEALM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public MLIALKLCJBO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public IReadOnlyList<GOHCGJMKCAB> unifiedItemIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public bool convertCustomAvatarItemsToPurchasableGiftDrops;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private List<PAJCNFAEALM> <storeItemsInInitialOrder>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private TaskAwaiter<List<BADAFKCAGKI>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x85AD170", Offset = "0x85ABF70", VA = "0x1885AD170", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x85ADA40", Offset = "0x85AC840", VA = "0x1885ADA40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct FPGOBKJDOGH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public AsyncTaskMethodBuilder<List<BADAFKCAGKI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public List<BADAFKCAGKI> customAvatarItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public MLIALKLCJBO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x85AE390", Offset = "0x85AD190", VA = "0x1885AE390", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x85AE890", Offset = "0x85AD690", VA = "0x1885AE890", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class CNHECIMDDIH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public GOHCGJMKCAB id;

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public CNHECIMDDIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x85ADAB0", Offset = "0x85AC8B0", VA = "0x1885ADAB0")]
		internal bool FBADJJDALGL(NDLNMHFGBNK x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x85ADAF0", Offset = "0x85AC8F0", VA = "0x1885ADAF0")]
		internal bool KGDNKKDDPPF(PAJCNFAEALM x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class GKBHBGLCPCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public string itemFriendlyName;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public GKBHBGLCPCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x85AE900", Offset = "0x85AD700", VA = "0x1885AE900")]
		internal object PDJKIBNBMCF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class IMIFJGEOCEP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public MLIALKLCJBO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public GiftItemDTO gift;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public IMIFJGEOCEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x85AE990", Offset = "0x85AD790", VA = "0x1885AE990")]
		internal void BJAOAJBKGMH(BalanceUpdateResponseDTO<CHJJJKIEJLA> result)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct PNOLNPLHOMA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public AsyncTaskMethodBuilder<AEMAHMMCBBC<BalanceUpdateResponseDTO<CHJJJKIEJLA>>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public MLIALKLCJBO <>4__this;

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
		public MOKDLLFJIKJ storefrontType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public POKBHADPEGG currencyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private TaskAwaiter<ELHHJKFDJGF> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private TaskAwaiter<AEMAHMMCBBC<BalanceUpdateResponseDTO<CHJJJKIEJLA>>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x85B5A60", Offset = "0x85B4860", VA = "0x1885B5A60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x85B5F40", Offset = "0x85B4D40", VA = "0x1885B5F40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class GNEBBGIANFD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public MLIALKLCJBO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public bool handleShowGiftPackage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public bool shouldConsumeGiftBoxImmediately;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public GNEBBGIANFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x85AE950", Offset = "0x85AD750", VA = "0x1885AE950")]
		internal void OOLNOMBCBDK(BalanceUpdateResponseDTO<CHJJJKIEJLA> result)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct EOABNFLOGHI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public AsyncTaskMethodBuilder<List<ELHHJKFDJGF>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public IReadOnlyList<Guid> itemIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public MLIALKLCJBO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private TaskAwaiter<List<EFEJJNPJICP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x85ADF10", Offset = "0x85ACD10", VA = "0x1885ADF10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x85AE320", Offset = "0x85AD120", VA = "0x1885AE320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct KOHEOPEAKBK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public List<PAJCNFAEALM> storeItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public MLIALKLCJBO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private int <attemptNumber>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x85AF200", Offset = "0x85AE000", VA = "0x1885AF200", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x85AF6F0", Offset = "0x85AE4F0", VA = "0x1885AF6F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly DGHADHMGELA<Guid, ELHHJKFDJGF> DIFGMBLIBPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private NIGONPEOPPE OBOGMKJJNOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private ANMCGAPLEPO EAIIHEDACBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private IFHHEDEDIFI AJBANNJOIDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private LNDGDHNFDLG KBAMBIGJPMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private PMHBGCDIHII GLHBBPJHFOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private MEHFIDNJION MOANACPPHLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal NDJENDDAKLA<Guid, ELHHJKFDJGF> FAHPMKMIIAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private bool EKADHKFOHIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private Task PDPACGLOHPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private CancellationTokenSource EJDAHLLCNNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private List<NDLNMHFGBNK> LJLNJKLDPJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private EANGDPGIDDI? CNHDIKJANBL;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static DJADCCMIHBB JKKCDKLCOPA;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private List<NDLNMHFGBNK> LKNFMPAPEAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x85AFDF0", Offset = "0x85AEBF0", VA = "0x1885AFDF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private EANGDPGIDDI JMOELIJGJDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x85B1D50", Offset = "0x85B0B50", VA = "0x1885B1D50")]
		get
		{
			return default(EANGDPGIDDI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static DJADCCMIHBB ICOFMPPJNFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x85AFCC0", Offset = "0x85AEAC0", VA = "0x1885AFCC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x85B2D50", Offset = "0x85B1B50", VA = "0x1885B2D50")]
	private List<NDLNMHFGBNK> OIKFCEPDGOL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x85B00A0", Offset = "0x85AEEA0", VA = "0x1885B00A0")]
	[ENKLKENGHAE.GHBFDECCGMJ.HGNDHHKALNH]
	internal static void BAEPNPABNEB(NAELDDAANND AHGNCOFKLHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x85B31D0", Offset = "0x85B1FD0", VA = "0x1885B31D0")]
	[RecRoom.NoEngine.Common.Preserve]
	public MLIALKLCJBO([LCNEJNNIOGA(null)] IFHHEDEDIFI AJBANNJOIDD, [LCNEJNNIOGA(null)] NIGONPEOPPE OBOGMKJJNOD, [LCNEJNNIOGA(null)] ANMCGAPLEPO EAIIHEDACBJ, [LCNEJNNIOGA(null)] LNDGDHNFDLG KBAMBIGJPMB, [LCNEJNNIOGA(null)] PMHBGCDIHII GLHBBPJHFOJ, [LCNEJNNIOGA(null)] MEHFIDNJION MOANACPPHLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x85B1530", Offset = "0x85B0330", VA = "0x1885B1530", Slot = "1")]
	~MLIALKLCJBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x85B11C0", Offset = "0x85AFFC0", VA = "0x1885B11C0", Slot = "13")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x85B2C60", Offset = "0x85B1A60", VA = "0x1885B2C60")]
	[AsyncStateMachine(typeof(DENGBCNBFLN))]
	private Task NPPOKNNELMI(CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x85B1080", Offset = "0x85AFE80", VA = "0x1885B1080")]
	public void DNNMLBKLKBL(Guid BPLOOBBHEML, ELHHJKFDJGF MJOKPBDNDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x85AFA90", Offset = "0x85AE890", VA = "0x1885AFA90", Slot = "14")]
	public void ABBJHNMCOPD(PAJCNFAEALM HKJHOBKHAKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x85B2AA0", Offset = "0x85B18A0", VA = "0x1885B2AA0", Slot = "4")]
	public void MBLEEGKOPHB(IEnumerable<PAJCNFAEALM> NBINCMHNOOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x85B06E0", Offset = "0x85AF4E0", VA = "0x1885B06E0", Slot = "15")]
	public ELHHJKFDJGF BPNBNAICMBG(Guid FIBIOFOKNFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x85B04E0", Offset = "0x85AF2E0", VA = "0x1885B04E0", Slot = "5")]
	public ELHHJKFDJGF BPNBNAICMBG(PAJCNFAEALM HKJHOBKHAKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x85B1620", Offset = "0x85B0420", VA = "0x1885B1620", Slot = "16")]
	[AsyncStateMachine(typeof(LLMHADABGEM))]
	public Task<ELHHJKFDJGF> GBFICAOACIF(Guid FIBIOFOKNFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x85B2940", Offset = "0x85B1740", VA = "0x1885B2940", Slot = "7")]
	[AsyncStateMachine(typeof(JCHHJLMPAAC))]
	public Task<List<PAJCNFAEALM>> LFJHJJCOAAI(string CJAMGOLGEHK, bool? GELGOJLJMMG, bool? NOLIIOLOJAD, IEnumerable<int> DPPHPEBLIIP, bool AJJELLKHDFL, bool EHBFDGHKKIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x85B1230", Offset = "0x85B0030", VA = "0x1885B1230", Slot = "6")]
	public PAJCNFAEALM EBANPNGCBCD(GOHCGJMKCAB BPLOOBBHEML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x85B0F40", Offset = "0x85AFD40", VA = "0x1885B0F40", Slot = "8")]
	[AsyncStateMachine(typeof(AEMDCOLOOPH))]
	public Task<List<PAJCNFAEALM>> DAGENDAKNDE(IReadOnlyList<GOHCGJMKCAB> MEHDLIMEPBG, bool ODPCPPMNBKF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x85AFF90", Offset = "0x85AED90", VA = "0x1885AFF90")]
	[AsyncStateMachine(typeof(FPGOBKJDOGH))]
	private Task<List<BADAFKCAGKI>> BAEPIJIEJPL(List<BADAFKCAGKI> DBBCKHLDOFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x85B1730", Offset = "0x85B0530", VA = "0x1885B1730")]
	private List<PAJCNFAEALM> HNAOJCFNFMC(IReadOnlyList<GOHCGJMKCAB> PKODKFBPGOH, IReadOnlyList<NDLNMHFGBNK> FHOMCCHDCMK, IReadOnlyList<PAJCNFAEALM> DBBCKHLDOFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x85B26E0", Offset = "0x85B14E0", VA = "0x1885B26E0", Slot = "9")]
	public HMBEFKLHMDK<BalanceUpdateResponseDTO<CHJJJKIEJLA>> KBIHEFBJMKO(Guid FIBIOFOKNFN, long LNEMGKKPNAE, GiftItemDTO NGCOADOFPJB, POKBHADPEGG KCCJJMPBCCD = POKBHADPEGG.RecCenterTokens, [Optional] long? MHFKFHANFBG, MOKDLLFJIKJ HGELOFJPHBB = MOKDLLFJIKJ.None)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x85B0240", Offset = "0x85AF040", VA = "0x1885B0240")]
	[AsyncStateMachine(typeof(PNOLNPLHOMA))]
	private Task<AEMAHMMCBBC<BalanceUpdateResponseDTO<CHJJJKIEJLA>>> BIMGCAMFCEC(Guid FIBIOFOKNFN, long LNEMGKKPNAE, GiftItemDTO NGCOADOFPJB, POKBHADPEGG KCCJJMPBCCD = POKBHADPEGG.RecCenterTokens, [Optional] long? MHFKFHANFBG, MOKDLLFJIKJ HGELOFJPHBB = MOKDLLFJIKJ.None)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x85B0CE0", Offset = "0x85AFAE0", VA = "0x1885B0CE0", Slot = "10")]
	public HMBEFKLHMDK<BalanceUpdateResponseDTO<CHJJJKIEJLA>> COPHPEIGLEM(MOKDLLFJIKJ HGELOFJPHBB, POKBHADPEGG KCCJJMPBCCD, int HGDCEGNJLGE, long LNEMGKKPNAE, long? MHFKFHANFBG, int MBHFMJNJEFI, bool LPBANJOCBKD = false, bool EHAGKJIBIBG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x85B21F0", Offset = "0x85B0FF0", VA = "0x1885B21F0", Slot = "11")]
	public HMBEFKLHMDK<BalanceUpdateResponseDTO<CHJJJKIEJLA>> JLOIIHDIGHJ(MOKDLLFJIKJ HGELOFJPHBB, POKBHADPEGG KCCJJMPBCCD, int HGDCEGNJLGE, long LNEMGKKPNAE, long? MHFKFHANFBG, IReadOnlyCollection<int> FJCMKHMKAAH, string NJJDPBHNDPA, bool MPKBJFLDNKB, OGMKPJCJPIA KFNCNHCBNPK, int MBHFMJNJEFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x85B07F0", Offset = "0x85AF5F0", VA = "0x1885B07F0", Slot = "12")]
	public HMBEFKLHMDK<BalanceUpdateResponseDTO<CHJJJKIEJLA>> CJDFLLHEINI(MOKDLLFJIKJ HGELOFJPHBB, POKBHADPEGG KCCJJMPBCCD, IReadOnlyList<int> MHEAOILCPAH, IReadOnlyList<long> HNEBIJAKFIF, long? MHFKFHANFBG, int NCCBFPKOIEK, string NJJDPBHNDPA, bool MPKBJFLDNKB, OGMKPJCJPIA KFNCNHCBNPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x85B03A0", Offset = "0x85AF1A0", VA = "0x1885B03A0")]
	[AsyncStateMachine(typeof(EOABNFLOGHI))]
	private Task<List<ELHHJKFDJGF>> BNAIOPPEBFN(IReadOnlyList<Guid> DOPGNGILPIP, CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x85B2EC0", Offset = "0x85B1CC0", VA = "0x1885B2EC0")]
	private void OOEJAAKFAHD(BalanceUpdateResponseDTO<CHJJJKIEJLA> EBLIHNLGKNO, bool AOBJJPCPFML, bool EHAGKJIBIBG, bool LPBANJOCBKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x85B1F70", Offset = "0x85B0D70", VA = "0x1885B1F70")]
	private void JJOHNJJFLHB(CAJGGKMOJIB FJJDMFNAJKC, bool EGDNLFMHINJ, bool MEGHEHMILNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x85B0140", Offset = "0x85AEF40", VA = "0x1885B0140")]
	[AsyncStateMachine(typeof(KOHEOPEAKBK))]
	private Task BCKOAJMNKCH(List<PAJCNFAEALM> NBINCMHNOOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x85AFDC0", Offset = "0x85AEBC0", VA = "0x1885AFDC0")]
	[CompilerGenerated]
	private void AHCPHIMKLFP(BalanceUpdateResponseDTO<CHJJJKIEJLA> BPINCJLADGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x85AFDC0", Offset = "0x85AEBC0", VA = "0x1885AFDC0")]
	[CompilerGenerated]
	private void LNJLMAHBFLE(BalanceUpdateResponseDTO<CHJJJKIEJLA> BPINCJLADGC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class NAHPFNAJAIO : HJALFFPCGOI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly PMHBGCDIHII JLADDPEDOBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly FIGGCIAAKAI LPJECKCINGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly KBBLCKGCAFD CGIHOEEGOGA;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x85B4F80", Offset = "0x85B3D80", VA = "0x1885B4F80")]
	[ENKLKENGHAE.GHBFDECCGMJ.HGNDHHKALNH]
	internal static void JKEPFALEAEN(NAELDDAANND AHGNCOFKLHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0xC59BA0", Offset = "0xC589A0", VA = "0x180C59BA0")]
	[RecRoom.NoEngine.Common.Preserve]
	public NAHPFNAJAIO([LCNEJNNIOGA(null)] PMHBGCDIHII GLHBBPJHFOJ, [LCNEJNNIOGA(null)] FIGGCIAAKAI DOOIPMPKLIL, [LCNEJNNIOGA(null)] KBBLCKGCAFD DBBCKHLDOFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x85B4CC0", Offset = "0x85B3AC0", VA = "0x1885B4CC0")]
	private bool GDNJJHBNBJI(HOLKFBCOLJH MCBGKNIKIFJ, HOLKFBCOLJH PJECDAGIFFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x85B3B20", Offset = "0x85B2920", VA = "0x1885B3B20", Slot = "5")]
	public IReadOnlyList<PAJCNFAEALM> CCIFFANHMBG(HOLKFBCOLJH LMIOFFGJMGF, IReadOnlyList<PAJCNFAEALM> CPGOGHNJEGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x85B3F00", Offset = "0x85B2D00", VA = "0x1885B3F00", Slot = "4")]
	public bool EGEFBCNMHDB(HOLKFBCOLJH LMIOFFGJMGF, PAJCNFAEALM HHHFHHLBBIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x85B59D0", Offset = "0x85B47D0", VA = "0x1885B59D0")]
	private bool PMCACAKAHHD(HOLKFBCOLJH LMIOFFGJMGF, PAJCNFAEALM HHHFHHLBBIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x85B5450", Offset = "0x85B4250", VA = "0x1885B5450")]
	private bool NHHKDMMGGHC(HOLKFBCOLJH LMIOFFGJMGF, PAJCNFAEALM HHHFHHLBBIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x85B4BC0", Offset = "0x85B39C0", VA = "0x1885B4BC0")]
	private bool ENGINIBAFLA(HOLKFBCOLJH LMIOFFGJMGF, PAJCNFAEALM HHHFHHLBBIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x85B3650", Offset = "0x85B2450", VA = "0x1885B3650")]
	public bool AHCPCALKCLA(PAJCNFAEALM HKJHOBKHAKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x85B38A0", Offset = "0x85B26A0", VA = "0x1885B38A0")]
	public bool AHCPCALKCLA(DNPOKPBKAFM LNCLMHOFHOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x85B5190", Offset = "0x85B3F90", VA = "0x1885B5190")]
	private bool LMEEDPGBCLC(Guid FIBIOFOKNFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x85B5060", Offset = "0x85B3E60", VA = "0x1885B5060")]
	private bool KCPMLNKGPMP(HOLKFBCOLJH LMIOFFGJMGF, PAJCNFAEALM HHHFHHLBBIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x85B3A00", Offset = "0x85B2800", VA = "0x1885B3A00")]
	private bool BDHIIFFHMBC(HOLKFBCOLJH LMIOFFGJMGF, PAJCNFAEALM HHHFHHLBBIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x85B4D40", Offset = "0x85B3B40", VA = "0x1885B4D40")]
	private bool GKFJLDNAACJ(HOLKFBCOLJH LMIOFFGJMGF, PAJCNFAEALM HHHFHHLBBIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x85B4DB0", Offset = "0x85B3BB0", VA = "0x1885B4DB0")]
	private bool HJABJKEKAFE(HOLKFBCOLJH LMIOFFGJMGF, PAJCNFAEALM HHHFHHLBBIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x85B4FF0", Offset = "0x85B3DF0", VA = "0x1885B4FF0")]
	private bool JOLBLGCDBMB(HOLKFBCOLJH LMIOFFGJMGF, PAJCNFAEALM HHHFHHLBBIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x85B4CD0", Offset = "0x85B3AD0", VA = "0x1885B4CD0")]
	private bool GECBBELEODD(HOLKFBCOLJH LMIOFFGJMGF, PAJCNFAEALM HHHFHHLBBIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x85B5090", Offset = "0x85B3E90", VA = "0x1885B5090")]
	private bool KPBMCAGCPIF(HOLKFBCOLJH LMIOFFGJMGF, PAJCNFAEALM HHHFHHLBBIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x85B53C0", Offset = "0x85B41C0", VA = "0x1885B53C0")]
	private bool NGAEOCHAINI(HOLKFBCOLJH LMIOFFGJMGF, PAJCNFAEALM HHHFHHLBBIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x85B5880", Offset = "0x85B4680", VA = "0x1885B5880")]
	private bool OJKOCMALIDM(HOLKFBCOLJH LMIOFFGJMGF, PAJCNFAEALM HHHFHHLBBIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x85B4B30", Offset = "0x85B3930", VA = "0x1885B4B30")]
	private bool ENCMLFPLPHE(HOLKFBCOLJH LMIOFFGJMGF, PAJCNFAEALM HHHFHHLBBIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x85B5330", Offset = "0x85B4130", VA = "0x1885B5330")]
	private bool NFHKOEMCMMP(HOLKFBCOLJH LMIOFFGJMGF, PAJCNFAEALM HHHFHHLBBIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x85B52A0", Offset = "0x85B40A0", VA = "0x1885B52A0")]
	private bool MHOOLABBCAI(HOLKFBCOLJH LMIOFFGJMGF, PAJCNFAEALM HHHFHHLBBIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x85B3E00", Offset = "0x85B2C00", VA = "0x1885B3E00")]
	private bool DMGHJIAOKGD(HOLKFBCOLJH LMIOFFGJMGF, PAJCNFAEALM HHHFHHLBBIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x85B3970", Offset = "0x85B2770", VA = "0x1885B3970")]
	private bool BCFNMKDKMFO(HOLKFBCOLJH LMIOFFGJMGF, PAJCNFAEALM HHHFHHLBBIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x85B4C30", Offset = "0x85B3A30", VA = "0x1885B4C30")]
	private bool FJMPHEGDPOD(HOLKFBCOLJH LMIOFFGJMGF, PAJCNFAEALM HHHFHHLBBIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x85B3D70", Offset = "0x85B2B70", VA = "0x1885B3D70")]
	private bool CNPDEBGMODM(HOLKFBCOLJH LMIOFFGJMGF, PAJCNFAEALM HHHFHHLBBIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x85B3A20", Offset = "0x85B2820", VA = "0x1885B3A20")]
	private bool BHELLHGCHHP(HOLKFBCOLJH LMIOFFGJMGF, PAJCNFAEALM HHHFHHLBBIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x85B57F0", Offset = "0x85B45F0", VA = "0x1885B57F0")]
	private bool OINGEBLPKMK(HOLKFBCOLJH LMIOFFGJMGF, PAJCNFAEALM HHHFHHLBBIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x85B4E20", Offset = "0x85B3C20", VA = "0x1885B4E20")]
	private bool HMPCNNLDBKF(HOLKFBCOLJH LMIOFFGJMGF, PAJCNFAEALM HHHFHHLBBIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x85B5210", Offset = "0x85B4010", VA = "0x1885B5210")]
	private bool MDGEDOIPIFE(HOLKFBCOLJH LMIOFFGJMGF, PAJCNFAEALM HHHFHHLBBIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x85B4A70", Offset = "0x85B3870", VA = "0x1885B4A70")]
	private bool EIPKJFBBENL(HOLKFBCOLJH LMIOFFGJMGF, PAJCNFAEALM HHHFHHLBBIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x85B4EB0", Offset = "0x85B3CB0", VA = "0x1885B4EB0")]
	private bool IJKGNIEAEPJ(HOLKFBCOLJH LMIOFFGJMGF, PAJCNFAEALM HHHFHHLBBIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x85B5940", Offset = "0x85B4740", VA = "0x1885B5940")]
	private bool OPKHAPIJIIL(HOLKFBCOLJH LMIOFFGJMGF, PAJCNFAEALM HHHFHHLBBIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x85B3AB0", Offset = "0x85B28B0", VA = "0x1885B3AB0")]
	private bool BPHAIFHJMJJ(HOLKFBCOLJH LMIOFFGJMGF, PAJCNFAEALM HHHFHHLBBIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x85B5100", Offset = "0x85B3F00", VA = "0x1885B5100")]
	private bool LLBJBONPKNH(HOLKFBCOLJH LMIOFFGJMGF, PAJCNFAEALM HHHFHHLBBIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x85B5760", Offset = "0x85B4560", VA = "0x1885B5760")]
	private bool NNODGGMFMFD(HOLKFBCOLJH LMIOFFGJMGF, PAJCNFAEALM HHHFHHLBBIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x85B3E90", Offset = "0x85B2C90", VA = "0x1885B3E90")]
	private bool DOKIOHHPEFE(HOLKFBCOLJH LMIOFFGJMGF, PAJCNFAEALM HHHFHHLBBIL)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class KAMDLADCGCG
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public KAMDLADCGCG()
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
