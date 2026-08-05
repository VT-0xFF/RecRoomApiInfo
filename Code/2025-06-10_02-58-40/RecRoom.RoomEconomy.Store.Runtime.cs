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
		[Cpp2IlInjected.Address(RVA = "0x847C090", Offset = "0x847B290", VA = "0x18847C090", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x274B560", Offset = "0x274A760", VA = "0x18274B560")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class CAHKHEBINML : DHHLGGPJHID, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private struct CLIBFCGPBNA : IAsyncStateMachine
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
		public CAHKHEBINML <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8477310", Offset = "0x8476510", VA = "0x188477310", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8477610", Offset = "0x8476810", VA = "0x188477610", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private struct EIKHCFLCLBP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public AsyncTaskMethodBuilder<KEHCAJCNDBN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public CAHKHEBINML <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public Guid customAvatarItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private TaskAwaiter<KEHCAJCNDBN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x84787B0", Offset = "0x84779B0", VA = "0x1884787B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8478A80", Offset = "0x8477C80", VA = "0x188478A80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct BBNLLFKHALN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public AsyncTaskMethodBuilder<List<NCBBJMJOCON>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public CAHKHEBINML <>4__this;

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
		private List<NCBBJMJOCON> <results>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private TaskAwaiter<List<IDCBGKCDNPH>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8472E50", Offset = "0x8472050", VA = "0x188472E50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8473610", Offset = "0x8472810", VA = "0x188473610", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct DOANBCDOLME : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public AsyncTaskMethodBuilder<List<NCBBJMJOCON>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public CAHKHEBINML <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public IReadOnlyList<JLPNILENCPC> unifiedItemIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public bool convertCustomAvatarItemsToPurchasableGiftDrops;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private Task <watchStorefrontTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private List<IDCBGKCDNPH> <customAvatarItems>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private List<NCBBJMJOCON> <storeItemsInInitialOrder>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private TaskAwaiter<List<IDCBGKCDNPH>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8477BC0", Offset = "0x8476DC0", VA = "0x188477BC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8478640", Offset = "0x8477840", VA = "0x188478640", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct IMAIODFNGGO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public AsyncTaskMethodBuilder<List<IDCBGKCDNPH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public List<IDCBGKCDNPH> customAvatarItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public CAHKHEBINML <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x847AF40", Offset = "0x847A140", VA = "0x18847AF40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x847B440", Offset = "0x847A640", VA = "0x18847B440", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class ECOAIJHJDNE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public JLPNILENCPC id;

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public ECOAIJHJDNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8478770", Offset = "0x8477970", VA = "0x188478770")]
		internal bool CHDMJHDFOLL(GEMNLGFAGEN x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x84786B0", Offset = "0x84778B0", VA = "0x1884786B0")]
		internal bool BHMJIKAMNOC(NCBBJMJOCON x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class ICGJJFCHOLP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public string itemFriendlyName;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public ICGJJFCHOLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x847AEF0", Offset = "0x847A0F0", VA = "0x18847AEF0")]
		internal object NAMFDNMGMAL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class KAKKOECEAID
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public CAHKHEBINML <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public GiftItemDTO gift;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public KAKKOECEAID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x847B4B0", Offset = "0x847A6B0", VA = "0x18847B4B0")]
		internal void AHMBANANFGB(BalanceUpdateResponseDTO<JCECGDGKJFD> result)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct DABNCECGNDE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public AsyncTaskMethodBuilder<FIHEJIGJMJL<BalanceUpdateResponseDTO<JCECGDGKJFD>>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public CAHKHEBINML <>4__this;

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
		public NIBILLLKFND storefrontType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public HJNAAGOKCBC currencyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private TaskAwaiter<KEHCAJCNDBN> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TaskAwaiter<FIHEJIGJMJL<BalanceUpdateResponseDTO<JCECGDGKJFD>>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8477670", Offset = "0x8476870", VA = "0x188477670", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8477B50", Offset = "0x8476D50", VA = "0x188477B50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class PEJIOGMCHAD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public CAHKHEBINML <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public bool handleShowGiftPackage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public bool shouldConsumeGiftBoxImmediately;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public PEJIOGMCHAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x847BEB0", Offset = "0x847B0B0", VA = "0x18847BEB0")]
		internal void EBBCOMLKICK(BalanceUpdateResponseDTO<JCECGDGKJFD> result)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct LNKBHKNNKNG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public AsyncTaskMethodBuilder<List<KEHCAJCNDBN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public IReadOnlyList<Guid> itemIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public CAHKHEBINML <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private TaskAwaiter<List<DPBJKMGNKDC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x847BA40", Offset = "0x847AC40", VA = "0x18847BA40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x847BE40", Offset = "0x847B040", VA = "0x18847BE40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct LFEIFIBJBPO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public List<NCBBJMJOCON> storeItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public CAHKHEBINML <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private int <attemptNumber>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x847B4F0", Offset = "0x847A6F0", VA = "0x18847B4F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x847B9E0", Offset = "0x847ABE0", VA = "0x18847B9E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly DAIEFINLKKC<Guid, KEHCAJCNDBN> CAJLDNJMNAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private LHGAOOLBKEB FICGBLBBAND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private BOBHHGEDHMP LFCGLNMDLCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private AACKACLGNHJ EBAAIMJBJPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private ICOJLGCOGHE OHOPFNEMPNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private LMCMPHNNPJK LBILAOFHOKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private ABCAKKCKJPM BFEDBNCCFGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal EIDHCHLOOHL<Guid, KEHCAJCNDBN> HJEAICEHIKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private bool JDKAOICAPKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private Task AKDDBLCEDHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private CancellationTokenSource LBBGJMAJLFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private List<GEMNLGFAGEN> HMECOIPBHAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private FBAECNJOJAA? OLPODMFPFCG;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static DHHLGGPJHID OMHJJKGOGGP;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private List<GEMNLGFAGEN> INCJLBAICCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x84742E0", Offset = "0x84734E0", VA = "0x1884742E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private FBAECNJOJAA OOCPEOJALKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8475EC0", Offset = "0x84750C0", VA = "0x188475EC0")]
		get
		{
			return default(FBAECNJOJAA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static DHHLGGPJHID AIBLJDBPKAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x84737C0", Offset = "0x84729C0", VA = "0x1884737C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x8475410", Offset = "0x8474610", VA = "0x188475410")]
	private List<GEMNLGFAGEN> GKGDMLCJCFD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x8474600", Offset = "0x8473800", VA = "0x188474600")]
	[MGCKGAIBEHC.MJEHAAIJGKF.HELJMGKJDLB]
	internal static void EFOCMBOIKDL(FJCFOKJAKFO MBLPEFIMNGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x8476EA0", Offset = "0x84760A0", VA = "0x188476EA0")]
	[RecRoom.NoEngine.Common.Preserve]
	public CAHKHEBINML([NGLIAOPBMFM(null)] AACKACLGNHJ EBAAIMJBJPK, [NGLIAOPBMFM(null)] LHGAOOLBKEB FICGBLBBAND, [NGLIAOPBMFM(null)] BOBHHGEDHMP LFCGLNMDLCM, [NGLIAOPBMFM(null)] ICOJLGCOGHE OHOPFNEMPNA, [NGLIAOPBMFM(null)] LMCMPHNNPJK LBILAOFHOKH, [NGLIAOPBMFM(null)] ABCAKKCKJPM BFEDBNCCFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x8474C30", Offset = "0x8473E30", VA = "0x188474C30", Slot = "1")]
	~CAHKHEBINML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x8474590", Offset = "0x8473790", VA = "0x188474590", Slot = "13")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x8476340", Offset = "0x8475540", VA = "0x188476340")]
	[AsyncStateMachine(typeof(CLIBFCGPBNA))]
	private Task NKDIAJEGDPJ(CancellationToken FHBCOAHILMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x8474890", Offset = "0x8473A90", VA = "0x188474890")]
	public void FMIDLHKBPNL(Guid LNHCNANPEGB, KEHCAJCNDBN KGEILNBBLGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x8476C70", Offset = "0x8475E70", VA = "0x188476C70", Slot = "14")]
	public void OODHJFPGGHH(NCBBJMJOCON CDKABHNDBDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x84746A0", Offset = "0x84738A0", VA = "0x1884746A0", Slot = "4")]
	public void FEGHLPBCIKP(IEnumerable<NCBBJMJOCON> FNKAEPCDCOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x8473BC0", Offset = "0x8472DC0", VA = "0x188473BC0", Slot = "15")]
	public KEHCAJCNDBN BGEOPMFHCKO(Guid BFKMEDKGNMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x84739C0", Offset = "0x8472BC0", VA = "0x1884739C0", Slot = "5")]
	public KEHCAJCNDBN BGEOPMFHCKO(NCBBJMJOCON CDKABHNDBDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x84738B0", Offset = "0x8472AB0", VA = "0x1884738B0", Slot = "16")]
	[AsyncStateMachine(typeof(EIKHCFLCLBP))]
	public Task<KEHCAJCNDBN> AKMMPJBDIKD(Guid BFKMEDKGNMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x8475800", Offset = "0x8474A00", VA = "0x188475800", Slot = "7")]
	[AsyncStateMachine(typeof(BBNLLFKHALN))]
	public Task<List<NCBBJMJOCON>> ILFHCGEPONI(string FEKAGJBPEDB, bool? LBDDNKFOGAI, bool? KILFLPKHDDF, IEnumerable<int> CNHLBBNDHDO, bool BFMKCHDDJMJ, bool KKAAEODDLPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x8474E60", Offset = "0x8474060", VA = "0x188474E60", Slot = "6")]
	public NCBBJMJOCON GICMLIOMCPP(JLPNILENCPC LNHCNANPEGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x8474D20", Offset = "0x8473F20", VA = "0x188474D20", Slot = "8")]
	[AsyncStateMachine(typeof(DOANBCDOLME))]
	public Task<List<NCBBJMJOCON>> GHFKNGAJEHN(IReadOnlyList<JLPNILENCPC> PNPILAELDNF, bool EANAOCKOFNN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x8474480", Offset = "0x8473680", VA = "0x188474480")]
	[AsyncStateMachine(typeof(IMAIODFNGGO))]
	private Task<List<IDCBGKCDNPH>> DEBOLDBLDDN(List<IDCBGKCDNPH> KCLJCNKKKGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x8473CC0", Offset = "0x8472EC0", VA = "0x188473CC0")]
	private List<NCBBJMJOCON> BHLBKEDFCII(IReadOnlyList<JLPNILENCPC> FBJDEFKDMLF, IReadOnlyList<GEMNLGFAGEN> GHHGNDEENJC, IReadOnlyList<NCBBJMJOCON> KCLJCNKKKGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x84749D0", Offset = "0x8473BD0", VA = "0x1884749D0", Slot = "9")]
	public GFHJFJDJPFP<BalanceUpdateResponseDTO<JCECGDGKJFD>> FNIPIBIBNBN(Guid BFKMEDKGNMB, long KAFKBJCONCP, GiftItemDTO MLHKCENANMN, HJNAAGOKCBC DBBEINAPBBL = HJNAAGOKCBC.RecCenterTokens, [Optional] long? CNPFJLLMENI, NIBILLLKFND LHKCDMFPPCO = NIBILLLKFND.None)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x84761E0", Offset = "0x84753E0", VA = "0x1884761E0")]
	[AsyncStateMachine(typeof(DABNCECGNDE))]
	private Task<FIHEJIGJMJL<BalanceUpdateResponseDTO<JCECGDGKJFD>>> NCIKJBFKCNM(Guid BFKMEDKGNMB, long KAFKBJCONCP, GiftItemDTO MLHKCENANMN, HJNAAGOKCBC DBBEINAPBBL = HJNAAGOKCBC.RecCenterTokens, [Optional] long? CNPFJLLMENI, NIBILLLKFND LHKCDMFPPCO = NIBILLLKFND.None)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x8475160", Offset = "0x8474360", VA = "0x188475160", Slot = "10")]
	public GFHJFJDJPFP<BalanceUpdateResponseDTO<JCECGDGKJFD>> GJEONEHDJBI(NIBILLLKFND LHKCDMFPPCO, HJNAAGOKCBC DBBEINAPBBL, int LLKKDDNMHMO, long KAFKBJCONCP, long? CNPFJLLMENI, int FBEMCDBOPDD, bool PLPNGCEDFDF = false, bool IHEBCHPHMKO = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x8475960", Offset = "0x8474B60", VA = "0x188475960", Slot = "11")]
	public GFHJFJDJPFP<BalanceUpdateResponseDTO<JCECGDGKJFD>> JEPDNIKMMCF(NIBILLLKFND LHKCDMFPPCO, HJNAAGOKCBC DBBEINAPBBL, int LLKKDDNMHMO, long KAFKBJCONCP, long? CNPFJLLMENI, IReadOnlyCollection<int> JLIFMBFPMDP, string NPEJLHCJPAI, bool OCAHPFABKPH, PLCLHOKODBE BMIGIEJHBEN, int FBEMCDBOPDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x8476430", Offset = "0x8475630", VA = "0x188476430", Slot = "12")]
	public GFHJFJDJPFP<BalanceUpdateResponseDTO<JCECGDGKJFD>> NKHENLBGDKK(NIBILLLKFND LHKCDMFPPCO, HJNAAGOKCBC DBBEINAPBBL, IReadOnlyList<int> OFKPNHNABAN, IReadOnlyList<long> FCHBKBIPFBD, long? CNPFJLLMENI, int CPLPKANPEHH, string NPEJLHCJPAI, bool OCAHPFABKPH, PLCLHOKODBE BMIGIEJHBEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x8473680", Offset = "0x8472880", VA = "0x188473680")]
	[AsyncStateMachine(typeof(LNKBHKNNKNG))]
	private Task<List<KEHCAJCNDBN>> AAHPKNLKGOD(IReadOnlyList<Guid> CJEDPOCHBPJ, CancellationToken FHBCOAHILMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x8476960", Offset = "0x8475B60", VA = "0x188476960")]
	private void ONAOAMDGKMH(BalanceUpdateResponseDTO<JCECGDGKJFD> CGIFBLJGGGB, bool EDOKAJHEKII, bool IHEBCHPHMKO, bool PLPNGCEDFDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x8475580", Offset = "0x8474780", VA = "0x188475580")]
	private void GPJHGMEFEKO(KIPODGCLHDN JJMEIBMHGHK, bool LJNJMBHEPHD, bool OHCKKAKHJHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x84760E0", Offset = "0x84752E0", VA = "0x1884760E0")]
	[AsyncStateMachine(typeof(LFEIFIBJBPO))]
	private Task JNBMKCKIDCJ(List<NCBBJMJOCON> FNKAEPCDCOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x8474860", Offset = "0x8473A60", VA = "0x188474860")]
	[CompilerGenerated]
	private void OMGHMCFKFBB(BalanceUpdateResponseDTO<JCECGDGKJFD> ACALKMLJJOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x8474860", Offset = "0x8473A60", VA = "0x188474860")]
	[CompilerGenerated]
	private void FFEONJPHEND(BalanceUpdateResponseDTO<JCECGDGKJFD> ACALKMLJJOL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class GLAAJGMKDOO : DNOJHCMDFMF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly LMCMPHNNPJK IEHEDAJICIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly JKNFMCKPNHB JPEGJNMOPBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly FOHNNEODOGB DLJCLEGCPPF;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x8479370", Offset = "0x8478570", VA = "0x188479370")]
	[MGCKGAIBEHC.MJEHAAIJGKF.HELJMGKJDLB]
	internal static void CNMFKDBOHKK(FJCFOKJAKFO MBLPEFIMNGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0xC9C830", Offset = "0xC9BA30", VA = "0x180C9C830")]
	[RecRoom.NoEngine.Common.Preserve]
	public GLAAJGMKDOO([NGLIAOPBMFM(null)] LMCMPHNNPJK LBILAOFHOKH, [NGLIAOPBMFM(null)] JKNFMCKPNHB LILOKELBBCO, [NGLIAOPBMFM(null)] FOHNNEODOGB KCLJCNKKKGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x847A070", Offset = "0x8479270", VA = "0x18847A070")]
	private bool LLBJBKDOEJG(BFCEDEKDJKD LIHCHBECCJF, BFCEDEKDJKD LHPFFOKDGHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x8479010", Offset = "0x8478210", VA = "0x188479010", Slot = "5")]
	public IReadOnlyList<NCBBJMJOCON> CEIJJKGJMGA(BFCEDEKDJKD FCOHFIGPGJB, IReadOnlyList<NCBBJMJOCON> ICAAOCBKPPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x847A080", Offset = "0x8479280", VA = "0x18847A080", Slot = "4")]
	public bool LLFDLBPKGLL(BFCEDEKDJKD FCOHFIGPGJB, NCBBJMJOCON LHNFJLFIPMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x8479A30", Offset = "0x8478C30", VA = "0x188479A30")]
	private bool GEOLCELCOEL(BFCEDEKDJKD FCOHFIGPGJB, NCBBJMJOCON LHNFJLFIPMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x8478C80", Offset = "0x8477E80", VA = "0x188478C80")]
	private bool CANFBNDJNLH(BFCEDEKDJKD FCOHFIGPGJB, NCBBJMJOCON LHNFJLFIPMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x847AE80", Offset = "0x847A080", VA = "0x18847AE80")]
	private bool PNFKFAJACEK(BFCEDEKDJKD FCOHFIGPGJB, NCBBJMJOCON LHNFJLFIPMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x84797E0", Offset = "0x84789E0", VA = "0x1884797E0")]
	public bool GEOJCAMCKOC(NCBBJMJOCON CDKABHNDBDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x8479710", Offset = "0x8478910", VA = "0x188479710")]
	public bool GEOJCAMCKOC(HCEOCKHFPAP AFJMICIPEMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x84792F0", Offset = "0x84784F0", VA = "0x1884792F0")]
	private bool CHNDBJKFNFP(Guid BFKMEDKGNMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x84793E0", Offset = "0x84785E0", VA = "0x1884793E0")]
	private bool EANNHDGHLAP(BFCEDEKDJKD FCOHFIGPGJB, NCBBJMJOCON LHNFJLFIPMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x8479F30", Offset = "0x8479130", VA = "0x188479F30")]
	private bool KGMCMDODILO(BFCEDEKDJKD FCOHFIGPGJB, NCBBJMJOCON LHNFJLFIPMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x847ABF0", Offset = "0x8479DF0", VA = "0x18847ABF0")]
	private bool LLGHOFHKLOG(BFCEDEKDJKD FCOHFIGPGJB, NCBBJMJOCON LHNFJLFIPMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x84796A0", Offset = "0x84788A0", VA = "0x1884796A0")]
	private bool GBCJNNCEPGK(BFCEDEKDJKD FCOHFIGPGJB, NCBBJMJOCON LHNFJLFIPMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x8479E30", Offset = "0x8479030", VA = "0x188479E30")]
	private bool KCDPBEALCGD(BFCEDEKDJKD FCOHFIGPGJB, NCBBJMJOCON LHNFJLFIPMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x847AD80", Offset = "0x8479F80", VA = "0x18847AD80")]
	private bool OPBHOPCLAHN(BFCEDEKDJKD FCOHFIGPGJB, NCBBJMJOCON LHNFJLFIPMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x8478AF0", Offset = "0x8477CF0", VA = "0x188478AF0")]
	private bool AFMLGCDOMEC(BFCEDEKDJKD FCOHFIGPGJB, NCBBJMJOCON LHNFJLFIPMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x847ADF0", Offset = "0x8479FF0", VA = "0x18847ADF0")]
	private bool PFFOFOEOJFO(BFCEDEKDJKD FCOHFIGPGJB, NCBBJMJOCON LHNFJLFIPMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x8479BC0", Offset = "0x8478DC0", VA = "0x188479BC0")]
	private bool HLPDNMNDCDA(BFCEDEKDJKD FCOHFIGPGJB, NCBBJMJOCON LHNFJLFIPMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x8478BF0", Offset = "0x8477DF0", VA = "0x188478BF0")]
	private bool BCJAANFDLGC(BFCEDEKDJKD FCOHFIGPGJB, NCBBJMJOCON LHNFJLFIPMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x8479B30", Offset = "0x8478D30", VA = "0x188479B30")]
	private bool HCOCINMPEFA(BFCEDEKDJKD FCOHFIGPGJB, NCBBJMJOCON LHNFJLFIPMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x8479DA0", Offset = "0x8478FA0", VA = "0x188479DA0")]
	private bool JNECDEDADMM(BFCEDEKDJKD FCOHFIGPGJB, NCBBJMJOCON LHNFJLFIPMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x8479260", Offset = "0x8478460", VA = "0x188479260")]
	private bool CFGAOMOOKLG(BFCEDEKDJKD FCOHFIGPGJB, NCBBJMJOCON LHNFJLFIPMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x8479EA0", Offset = "0x84790A0", VA = "0x188479EA0")]
	private bool KFKELFNONFD(BFCEDEKDJKD FCOHFIGPGJB, NCBBJMJOCON LHNFJLFIPMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x8479F50", Offset = "0x8479150", VA = "0x188479F50")]
	private bool KHNDJKCMODG(BFCEDEKDJKD FCOHFIGPGJB, NCBBJMJOCON LHNFJLFIPMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x8479D10", Offset = "0x8478F10", VA = "0x188479D10")]
	private bool JKGDGGIHIAO(BFCEDEKDJKD FCOHFIGPGJB, NCBBJMJOCON LHNFJLFIPMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x8479C80", Offset = "0x8478E80", VA = "0x188479C80")]
	private bool IJBIJGNJLLP(BFCEDEKDJKD FCOHFIGPGJB, NCBBJMJOCON LHNFJLFIPMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x8478F80", Offset = "0x8478180", VA = "0x188478F80")]
	private bool CCEDFKODGJE(BFCEDEKDJKD FCOHFIGPGJB, NCBBJMJOCON LHNFJLFIPMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x8479610", Offset = "0x8478810", VA = "0x188479610")]
	private bool GALGEKKPCPJ(BFCEDEKDJKD FCOHFIGPGJB, NCBBJMJOCON LHNFJLFIPMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x847ACF0", Offset = "0x8479EF0", VA = "0x18847ACF0")]
	private bool OANKGJFKEBB(BFCEDEKDJKD FCOHFIGPGJB, NCBBJMJOCON LHNFJLFIPMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x8479550", Offset = "0x8478750", VA = "0x188479550")]
	private bool FKJPBCJIPBH(BFCEDEKDJKD FCOHFIGPGJB, NCBBJMJOCON LHNFJLFIPMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x8479410", Offset = "0x8478610", VA = "0x188479410")]
	private bool EBIOGEECPGO(BFCEDEKDJKD FCOHFIGPGJB, NCBBJMJOCON LHNFJLFIPMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x8478B60", Offset = "0x8477D60", VA = "0x188478B60")]
	private bool AKKFJAOOCEJ(BFCEDEKDJKD FCOHFIGPGJB, NCBBJMJOCON LHNFJLFIPMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x84794E0", Offset = "0x84786E0", VA = "0x1884794E0")]
	private bool FGANBMIPGMD(BFCEDEKDJKD FCOHFIGPGJB, NCBBJMJOCON LHNFJLFIPMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x8479FE0", Offset = "0x84791E0", VA = "0x188479FE0")]
	private bool LBOPFNEOPLB(BFCEDEKDJKD FCOHFIGPGJB, NCBBJMJOCON LHNFJLFIPMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x847AC60", Offset = "0x8479E60", VA = "0x18847AC60")]
	private bool LMMJOIMIHFK(BFCEDEKDJKD FCOHFIGPGJB, NCBBJMJOCON LHNFJLFIPMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x8479AC0", Offset = "0x8478CC0", VA = "0x188479AC0")]
	private bool GMFGKHBKBBK(BFCEDEKDJKD FCOHFIGPGJB, NCBBJMJOCON LHNFJLFIPMG)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class JIMOOFOMAIG
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
	public JIMOOFOMAIG()
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
