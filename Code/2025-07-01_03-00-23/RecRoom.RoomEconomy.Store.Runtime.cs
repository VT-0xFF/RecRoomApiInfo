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
		[Cpp2IlInjected.Address(RVA = "0x87F6BD0", Offset = "0x87F51D0", VA = "0x1887F6BD0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x282D140", Offset = "0x282B740", VA = "0x18282D140")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class FGCMOHPGGMG : JFIECHFAEEI, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private struct LLBIFHIPFNC : IAsyncStateMachine
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
		public FGCMOHPGGMG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x87F5E60", Offset = "0x87F4460", VA = "0x1887F5E60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x87F6160", Offset = "0x87F4760", VA = "0x1887F6160", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private struct DLLNCCGHBGD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public AsyncTaskMethodBuilder<EEAIJCFNHCK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public FGCMOHPGGMG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public Guid customAvatarItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private TaskAwaiter<EEAIJCFNHCK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x87EE120", Offset = "0x87EC720", VA = "0x1887EE120", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x87EE3F0", Offset = "0x87EC9F0", VA = "0x1887EE3F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct POAOFAONGLK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public AsyncTaskMethodBuilder<List<FDFGOOFMOHM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public FGCMOHPGGMG <>4__this;

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
		private List<FDFGOOFMOHM> <results>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private TaskAwaiter<List<MGOOJHEAKEA>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x87F6210", Offset = "0x87F4810", VA = "0x1887F6210", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x87F69C0", Offset = "0x87F4FC0", VA = "0x1887F69C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct GKLHOKBCKKF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public AsyncTaskMethodBuilder<List<FDFGOOFMOHM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public FGCMOHPGGMG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public IReadOnlyList<JCHINFKCNJI> unifiedItemIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public bool convertCustomAvatarItemsToPurchasableGiftDrops;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private Task <watchStorefrontTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private List<MGOOJHEAKEA> <customAvatarItems>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private List<FDFGOOFMOHM> <storeItemsInInitialOrder>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private TaskAwaiter<List<MGOOJHEAKEA>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x87F2880", Offset = "0x87F0E80", VA = "0x1887F2880", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x87F3320", Offset = "0x87F1920", VA = "0x1887F3320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct APPMNCMJKBP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public AsyncTaskMethodBuilder<List<MGOOJHEAKEA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public List<MGOOJHEAKEA> customAvatarItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public FGCMOHPGGMG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x87EDBC0", Offset = "0x87EC1C0", VA = "0x1887EDBC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x87EE0B0", Offset = "0x87EC6B0", VA = "0x1887EE0B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class EGHHPHDBMHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public JCHINFKCNJI id;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public EGHHPHDBMHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x87EE4A0", Offset = "0x87ECAA0", VA = "0x1887EE4A0")]
		internal bool KOMGAOHKKII(OGBJFFEMEGB x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x87EE4E0", Offset = "0x87ECAE0", VA = "0x1887EE4E0")]
		internal bool LIIPHJHOPPO(FDFGOOFMOHM x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class PHLFPPGOOEC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public string itemFriendlyName;

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public PHLFPPGOOEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x87F61C0", Offset = "0x87F47C0", VA = "0x1887F61C0")]
		internal object GJCPIAAHAOM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class DOBHCLEKCCC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public FGCMOHPGGMG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public GiftItemDTO gift;

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public DOBHCLEKCCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x87EE460", Offset = "0x87ECA60", VA = "0x1887EE460")]
		internal void BCHLPMEGMOC(BalanceUpdateResponseDTO<CJCBLCLCIEP> result)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct ELMNMBGFKJI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public AsyncTaskMethodBuilder<GNFLAJOEABN<BalanceUpdateResponseDTO<CJCBLCLCIEP>>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public FGCMOHPGGMG <>4__this;

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
		public DJOBOOACBNK storefrontType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public MEPDKFDNMHJ currencyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private TaskAwaiter<EEAIJCFNHCK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TaskAwaiter<GNFLAJOEABN<BalanceUpdateResponseDTO<CJCBLCLCIEP>>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x87EE5A0", Offset = "0x87ECBA0", VA = "0x1887EE5A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x87EEAA0", Offset = "0x87ED0A0", VA = "0x1887EEAA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class KBLAGIJBCKG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public FGCMOHPGGMG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public bool handleShowGiftPackage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public bool shouldConsumeGiftBoxImmediately;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public KBLAGIJBCKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x87F5E20", Offset = "0x87F4420", VA = "0x1887F5E20")]
		internal void IBBMEDJNFMN(BalanceUpdateResponseDTO<CJCBLCLCIEP> result)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class JNOHGKBDBOM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public FGCMOHPGGMG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public GiftItemDTO gift;

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public JNOHGKBDBOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x87F5DE0", Offset = "0x87F43E0", VA = "0x1887F5DE0")]
		internal void DBLCGELMHMB(BalanceUpdateResponseDTO<CJCBLCLCIEP> result)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct ADNODKNGHDL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public AsyncTaskMethodBuilder<List<EEAIJCFNHCK>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public IReadOnlyList<Guid> itemIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public FGCMOHPGGMG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private TaskAwaiter<List<CFBLIONAPIL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x87ED750", Offset = "0x87EBD50", VA = "0x1887ED750", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x87EDB50", Offset = "0x87EC150", VA = "0x1887EDB50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct IEOFFCMJFEP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public List<FDFGOOFMOHM> storeItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public FGCMOHPGGMG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private int <attemptNumber>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x87F3390", Offset = "0x87F1990", VA = "0x1887F3390", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x87F3920", Offset = "0x87F1F20", VA = "0x1887F3920", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly NCGAAIJBEJA<Guid, EEAIJCFNHCK> CNOANKDHNKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private CLCHHNPEFDM IGOMEHBDBHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private ADDABIIDDAJ DNLFBNMAEPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private KKLMHFHACEF APMJPFKJFAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private OKIKLBIEJBK LALMBFBFEGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private DHONNKDKFCL PAAAEMKHMFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private JLBKHMODKCK AHHPFJAALPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal GMAPHMCBPAK<Guid, EEAIJCFNHCK> LOOIAMBBFFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private bool DNDJADKEJII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private Task LIOIDMAFCCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private CancellationTokenSource FJCCEILBPJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private List<OGBJFFEMEGB> BLANLPDMPAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private LGBEPIEGBBF? MEKLOFKOIHE;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static JFIECHFAEEI CNPKAEPPLJM;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private List<OGBJFFEMEGB> IJMNIMGIMPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x87F2260", Offset = "0x87F0860", VA = "0x1887F2260")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private LGBEPIEGBBF KCEOCNFNMHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x87EF0C0", Offset = "0x87ED6C0", VA = "0x1887EF0C0")]
		get
		{
			return default(LGBEPIEGBBF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static JFIECHFAEEI FNIBPMLJKFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x87F1630", Offset = "0x87EFC30", VA = "0x1887F1630")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x87F1280", Offset = "0x87EF880", VA = "0x1887F1280")]
	private List<OGBJFFEMEGB> KIEMGOLECEL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x87F1B10", Offset = "0x87F0110", VA = "0x1887F1B10")]
	[BNHIEDNKDNA.PMDFMFCJKCH.JJHNPGAJPOD]
	internal static void ODEMOKCFLLI(DCNOMJHNEOK FAIEEFHMPLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x87F2400", Offset = "0x87F0A00", VA = "0x1887F2400")]
	[RecRoom.NoEngine.Common.Preserve]
	public FGCMOHPGGMG([GGNLMCAPMLP(null)] KKLMHFHACEF APMJPFKJFAC, [GGNLMCAPMLP(null)] CLCHHNPEFDM IGOMEHBDBHG, [GGNLMCAPMLP(null)] ADDABIIDDAJ DNLFBNMAEPB, [GGNLMCAPMLP(null)] OKIKLBIEJBK LALMBFBFEGG, [GGNLMCAPMLP(null)] DHONNKDKFCL PAAAEMKHMFP, [GGNLMCAPMLP(null)] JLBKHMODKCK AHHPFJAALPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x87F0500", Offset = "0x87EEB00", VA = "0x1887F0500", Slot = "1")]
	~FGCMOHPGGMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x87EFF10", Offset = "0x87EE510", VA = "0x1887EFF10", Slot = "13")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x87F1730", Offset = "0x87EFD30", VA = "0x1887F1730")]
	[AsyncStateMachine(typeof(LLBIFHIPFNC))]
	private Task NMNBNNDCKFH(CancellationToken KMHHNOGHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x87F1BB0", Offset = "0x87F01B0", VA = "0x1887F1BB0")]
	public void OEOJGJCALJD(Guid CFEMHJOKDLP, EEAIJCFNHCK DCMIIMDJNCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x87EF570", Offset = "0x87EDB70", VA = "0x1887EF570", Slot = "14")]
	public void DFAIKLOBPDP(FDFGOOFMOHM HGPDAJIKNGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x87F10D0", Offset = "0x87EF6D0", VA = "0x1887F10D0", Slot = "4")]
	public void JKFBPJEFMDM(IEnumerable<FDFGOOFMOHM> HKHADGOLNJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x87F01E0", Offset = "0x87EE7E0", VA = "0x1887F01E0", Slot = "15")]
	public EEAIJCFNHCK ELGKIKGOCNL(Guid BCMAFCIPNGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x87F02F0", Offset = "0x87EE8F0", VA = "0x1887F02F0", Slot = "5")]
	public EEAIJCFNHCK ELGKIKGOCNL(FDFGOOFMOHM HGPDAJIKNGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x87F0900", Offset = "0x87EEF00", VA = "0x1887F0900", Slot = "16")]
	[AsyncStateMachine(typeof(DLLNCCGHBGD))]
	public Task<EEAIJCFNHCK> HGHHPAOKJFL(Guid BCMAFCIPNGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x87EF410", Offset = "0x87EDA10", VA = "0x1887EF410", Slot = "7")]
	[AsyncStateMachine(typeof(POAOFAONGLK))]
	public Task<List<FDFGOOFMOHM>> DCFJCJDFHND(string HAHDADBCIEF, bool? FBKPMPCFNDE, bool? NELMAAEMEFN, IEnumerable<int> ABAFAGNGJPE, bool FFKLEODBJOJ, bool KDHBECJLEAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x87F1F70", Offset = "0x87F0570", VA = "0x1887F1F70", Slot = "6")]
	public FDFGOOFMOHM PJKCCDFHOBG(JCHINFKCNJI CFEMHJOKDLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x87EFDD0", Offset = "0x87EE3D0", VA = "0x1887EFDD0", Slot = "8")]
	[AsyncStateMachine(typeof(GKLHOKBCKKF))]
	public Task<List<FDFGOOFMOHM>> DNODLEMDLFC(IReadOnlyList<JCHINFKCNJI> BMMCDDMKALO, bool ONDHKPFHJCE = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x87EF300", Offset = "0x87ED900", VA = "0x1887EF300")]
	[AsyncStateMachine(typeof(APPMNCMJKBP))]
	private Task<List<MGOOJHEAKEA>> CCFHMBDJIEI(List<MGOOJHEAKEA> NGAFGAMLNEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x87EF7B0", Offset = "0x87EDDB0", VA = "0x1887EF7B0")]
	private List<FDFGOOFMOHM> DHHGLPMJJKN(IReadOnlyList<JCHINFKCNJI> KDHAJNEHCPC, IReadOnlyList<OGBJFFEMEGB> NFAOKGJMBHB, IReadOnlyList<FDFGOOFMOHM> NGAFGAMLNEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x87EFF80", Offset = "0x87EE580", VA = "0x1887EFF80", Slot = "9")]
	public EHBLMFNEKIG<BalanceUpdateResponseDTO<CJCBLCLCIEP>> EIGGLNGEJMN(Guid BCMAFCIPNGO, long HONKDHANCMN, GiftItemDTO FLFKEEHCLAH, MEPDKFDNMHJ PEOJMNNJEJM = MEPDKFDNMHJ.RecCenterTokens, [Optional] long? DKFJBCKFNEF, DJOBOOACBNK KBIIPMNNGMC = DJOBOOACBNK.None)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x87F0A10", Offset = "0x87EF010", VA = "0x1887F0A10")]
	[AsyncStateMachine(typeof(ELMNMBGFKJI))]
	private Task<GNFLAJOEABN<BalanceUpdateResponseDTO<CJCBLCLCIEP>>> HKOLCBCLALD(Guid BCMAFCIPNGO, long HONKDHANCMN, GiftItemDTO FLFKEEHCLAH, MEPDKFDNMHJ PEOJMNNJEJM = MEPDKFDNMHJ.RecCenterTokens, [Optional] long? DKFJBCKFNEF, DJOBOOACBNK KBIIPMNNGMC = DJOBOOACBNK.None)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x87F1820", Offset = "0x87EFE20", VA = "0x1887F1820", Slot = "10")]
	public EHBLMFNEKIG<BalanceUpdateResponseDTO<CJCBLCLCIEP>> OCOPEECLFKP(DJOBOOACBNK KBIIPMNNGMC, MEPDKFDNMHJ PEOJMNNJEJM, int CLMNEDNIJMP, long HONKDHANCMN, long? DKFJBCKFNEF, int NOIFFBHNGIC, bool HAJMDNPPBII = false, bool JABNILLDLLE = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x87F0B70", Offset = "0x87EF170", VA = "0x1887F0B70", Slot = "11")]
	public EHBLMFNEKIG<BalanceUpdateResponseDTO<CJCBLCLCIEP>> IADJGDELCGH(DJOBOOACBNK KBIIPMNNGMC, MEPDKFDNMHJ PEOJMNNJEJM, int CLMNEDNIJMP, long HONKDHANCMN, long? DKFJBCKFNEF, IReadOnlyCollection<int> KBPGHJAHHPF, string CJIMOMNMAGD, bool CKLFEEHLLKK, MDMIDLEFCPL EIDJFNAEJOF, int NOIFFBHNGIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x87EEB10", Offset = "0x87ED110", VA = "0x1887EEB10", Slot = "12")]
	public EHBLMFNEKIG<BalanceUpdateResponseDTO<CJCBLCLCIEP>> BALGFKODHAE(DJOBOOACBNK KBIIPMNNGMC, MEPDKFDNMHJ PEOJMNNJEJM, IReadOnlyList<JCHINFKCNJI> COJDGCDKOFL, IReadOnlyList<long> HPECKKFJJPO, [Optional] long? DKFJBCKFNEF, [Optional][CanBeNull] GiftItemDTO FLFKEEHCLAH, [Optional] Guid? ILPDEGHOOFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x87F13F0", Offset = "0x87EF9F0", VA = "0x1887F13F0")]
	[AsyncStateMachine(typeof(ADNODKNGHDL))]
	private Task<List<EEAIJCFNHCK>> KINMBOIEMKJ(IReadOnlyList<Guid> COJDGCDKOFL, CancellationToken KMHHNOGHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x87F05F0", Offset = "0x87EEBF0", VA = "0x1887F05F0")]
	private void GLGPKNINHEK(BalanceUpdateResponseDTO<CJCBLCLCIEP> AIOFBMIEPCB, bool KCBPDEEKCMF, bool JABNILLDLLE, bool HAJMDNPPBII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x87F1D00", Offset = "0x87F0300", VA = "0x1887F1D00")]
	private void ONCJAPOCHKE(DHFODADIHHB PIGEACALHPC, bool GFCMIGLEGCF, bool ABBCKCIINJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x87F1530", Offset = "0x87EFB30", VA = "0x1887F1530")]
	[AsyncStateMachine(typeof(IEOFFCMJFEP))]
	private Task LPKJHIILKOK(List<FDFGOOFMOHM> HKHADGOLNJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x87EF2D0", Offset = "0x87ED8D0", VA = "0x1887EF2D0")]
	[CompilerGenerated]
	private void BPDBDDDOPPO(BalanceUpdateResponseDTO<CJCBLCLCIEP> HPCDHGHHCOO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class IJKOLFOEJMK : OFHADIIIAIK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly DHONNKDKFCL NGHDMJEGPBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly OMOKHHNAINK AMGHBJHCEHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly KBMLOIHNEGG CELLJHJLBEM;

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x87F5350", Offset = "0x87F3950", VA = "0x1887F5350")]
	[BNHIEDNKDNA.PMDFMFCJKCH.JJHNPGAJPOD]
	internal static void GLAOIPJFGAH(DCNOMJHNEOK FAIEEFHMPLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0xCFEAB0", Offset = "0xCFD0B0", VA = "0x180CFEAB0")]
	[RecRoom.NoEngine.Common.Preserve]
	public IJKOLFOEJMK([GGNLMCAPMLP(null)] DHONNKDKFCL PAAAEMKHMFP, [GGNLMCAPMLP(null)] OMOKHHNAINK GKDONLMEFDJ, [GGNLMCAPMLP(null)] KBMLOIHNEGG NGAFGAMLNEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x87F4E00", Offset = "0x87F3400", VA = "0x1887F4E00")]
	private bool EEMALOBKMCJ(BBNLEGCCMDL IOGGMOBJINN, BBNLEGCCMDL LDNGPFDBLKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x87F4680", Offset = "0x87F2C80", VA = "0x1887F4680", Slot = "5")]
	public IReadOnlyList<FDFGOOFMOHM> APJKKFDHIML(BBNLEGCCMDL EODNMKIDAMH, IReadOnlyList<FDFGOOFMOHM> LKKBHMIMCBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x87F3A10", Offset = "0x87F2010", VA = "0x1887F3A10", Slot = "4")]
	public bool AHCMLBJLNNF(BBNLEGCCMDL EODNMKIDAMH, FDFGOOFMOHM GANFJJCKLGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x87F52C0", Offset = "0x87F38C0", VA = "0x1887F52C0")]
	private bool GIKPLMNPONB(BBNLEGCCMDL EODNMKIDAMH, FDFGOOFMOHM GANFJJCKLGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x87F4EE0", Offset = "0x87F34E0", VA = "0x1887F4EE0")]
	private bool EONICOFJEFO(BBNLEGCCMDL EODNMKIDAMH, FDFGOOFMOHM GANFJJCKLGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x87F5550", Offset = "0x87F3B50", VA = "0x1887F5550")]
	private bool KDMFPPCIPGC(BBNLEGCCMDL EODNMKIDAMH, FDFGOOFMOHM GANFJJCKLGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x87F55C0", Offset = "0x87F3BC0", VA = "0x1887F55C0")]
	public bool KKBPGCBJPPL(FDFGOOFMOHM HGPDAJIKNGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x87F5810", Offset = "0x87F3E10", VA = "0x1887F5810")]
	public bool KKBPGCBJPPL(NGAKIONNNAB NPDFEFFMJAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x87F4CF0", Offset = "0x87F32F0", VA = "0x1887F4CF0")]
	private bool DPIGEEMDIHG(Guid BCMAFCIPNGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x87F5D20", Offset = "0x87F4320", VA = "0x1887F5D20")]
	private bool NDBEDPKKCKN(BBNLEGCCMDL EODNMKIDAMH, FDFGOOFMOHM GANFJJCKLGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x87F48D0", Offset = "0x87F2ED0", VA = "0x1887F48D0")]
	private bool BDCEAMAOAHM(BBNLEGCCMDL EODNMKIDAMH, FDFGOOFMOHM GANFJJCKLGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x87F4A40", Offset = "0x87F3040", VA = "0x1887F4A40")]
	private bool BINAHENGEGL(BBNLEGCCMDL EODNMKIDAMH, FDFGOOFMOHM GANFJJCKLGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x87F54E0", Offset = "0x87F3AE0", VA = "0x1887F54E0")]
	private bool JDJFLGHJBFB(BBNLEGCCMDL EODNMKIDAMH, FDFGOOFMOHM GANFJJCKLGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x87F5250", Offset = "0x87F3850", VA = "0x1887F5250")]
	private bool FJEGIKBPBME(BBNLEGCCMDL EODNMKIDAMH, FDFGOOFMOHM GANFJJCKLGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x87F5A00", Offset = "0x87F4000", VA = "0x1887F5A00")]
	private bool LFAADJIEDAC(BBNLEGCCMDL EODNMKIDAMH, FDFGOOFMOHM GANFJJCKLGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x87F4580", Offset = "0x87F2B80", VA = "0x1887F4580")]
	private bool AIKDJOIPAGG(BBNLEGCCMDL EODNMKIDAMH, FDFGOOFMOHM GANFJJCKLGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x87F3980", Offset = "0x87F1F80", VA = "0x1887F3980")]
	private bool AHAPEBCNLLP(BBNLEGCCMDL EODNMKIDAMH, FDFGOOFMOHM GANFJJCKLGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x87F4980", Offset = "0x87F2F80", VA = "0x1887F4980")]
	private bool BIAOJJIPJPI(BBNLEGCCMDL EODNMKIDAMH, FDFGOOFMOHM GANFJJCKLGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x87F4D70", Offset = "0x87F3370", VA = "0x1887F4D70")]
	private bool EDDFLPGNEHI(BBNLEGCCMDL EODNMKIDAMH, FDFGOOFMOHM GANFJJCKLGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x87F4BD0", Offset = "0x87F31D0", VA = "0x1887F4BD0")]
	private bool COOGHCKEHNA(BBNLEGCCMDL EODNMKIDAMH, FDFGOOFMOHM GANFJJCKLGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x87F5D50", Offset = "0x87F4350", VA = "0x1887F5D50")]
	private bool NIANEEMKAJP(BBNLEGCCMDL EODNMKIDAMH, FDFGOOFMOHM GANFJJCKLGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x87F5C00", Offset = "0x87F4200", VA = "0x1887F5C00")]
	private bool MIKLLDOHKDF(BBNLEGCCMDL EODNMKIDAMH, FDFGOOFMOHM GANFJJCKLGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x87F48F0", Offset = "0x87F2EF0", VA = "0x1887F48F0")]
	private bool BFCMGCBNJIG(BBNLEGCCMDL EODNMKIDAMH, FDFGOOFMOHM GANFJJCKLGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x87F5B70", Offset = "0x87F4170", VA = "0x1887F5B70")]
	private bool MIADMCMCHDM(BBNLEGCCMDL EODNMKIDAMH, FDFGOOFMOHM GANFJJCKLGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x87F45F0", Offset = "0x87F2BF0", VA = "0x1887F45F0")]
	private bool AMMGDEAFOKO(BBNLEGCCMDL EODNMKIDAMH, FDFGOOFMOHM GANFJJCKLGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x87F5450", Offset = "0x87F3A50", VA = "0x1887F5450")]
	private bool IFLAEJFMKFI(BBNLEGCCMDL EODNMKIDAMH, FDFGOOFMOHM GANFJJCKLGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x87F53C0", Offset = "0x87F39C0", VA = "0x1887F53C0")]
	private bool HLFCCCKFBKE(BBNLEGCCMDL EODNMKIDAMH, FDFGOOFMOHM GANFJJCKLGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x87F4AB0", Offset = "0x87F30B0", VA = "0x1887F4AB0")]
	private bool BJBNGNFLPGJ(BBNLEGCCMDL EODNMKIDAMH, FDFGOOFMOHM GANFJJCKLGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x87F5A70", Offset = "0x87F4070", VA = "0x1887F5A70")]
	private bool LOFEGPCGIIC(BBNLEGCCMDL EODNMKIDAMH, FDFGOOFMOHM GANFJJCKLGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x87F58D0", Offset = "0x87F3ED0", VA = "0x1887F58D0")]
	private bool KOGPKHEKIMC(BBNLEGCCMDL EODNMKIDAMH, FDFGOOFMOHM GANFJJCKLGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x87F4E10", Offset = "0x87F3410", VA = "0x1887F4E10")]
	private bool EOHJDOAIDHE(BBNLEGCCMDL EODNMKIDAMH, FDFGOOFMOHM GANFJJCKLGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x87F4B40", Offset = "0x87F3140", VA = "0x1887F4B40")]
	private bool CCMNHOAHLOA(BBNLEGCCMDL EODNMKIDAMH, FDFGOOFMOHM GANFJJCKLGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x87F5B00", Offset = "0x87F4100", VA = "0x1887F5B00")]
	private bool LOJELHLCHNL(BBNLEGCCMDL EODNMKIDAMH, FDFGOOFMOHM GANFJJCKLGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x87F5C90", Offset = "0x87F4290", VA = "0x1887F5C90")]
	private bool MKLJHNFNFDI(BBNLEGCCMDL EODNMKIDAMH, FDFGOOFMOHM GANFJJCKLGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x87F4C60", Offset = "0x87F3260", VA = "0x1887F4C60")]
	private bool DBELECPAGNM(BBNLEGCCMDL EODNMKIDAMH, FDFGOOFMOHM GANFJJCKLGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x87F5990", Offset = "0x87F3F90", VA = "0x1887F5990")]
	private bool KPPNEACALPJ(BBNLEGCCMDL EODNMKIDAMH, FDFGOOFMOHM GANFJJCKLGF)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class ILCOKFFEKFJ
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public ILCOKFFEKFJ()
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
