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
		[Cpp2IlInjected.Address(RVA = "0x80A8A00", Offset = "0x80A7400", VA = "0x1880A8A00", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2571680", Offset = "0x2570080", VA = "0x182571680")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class KLAAMANKFBH : DBLBJNNJBIA, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private struct HNHJLCJJIFL : IAsyncStateMachine
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
		public KLAAMANKFBH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x80A3780", Offset = "0x80A2180", VA = "0x1880A3780", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x80A3A80", Offset = "0x80A2480", VA = "0x1880A3A80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private struct FFIFPDJLKOL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public AsyncTaskMethodBuilder<DDGIJFCOHNN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public KLAAMANKFBH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public Guid customAvatarItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private TaskAwaiter<DDGIJFCOHNN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x80A0AA0", Offset = "0x809F4A0", VA = "0x1880A0AA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x80A0D70", Offset = "0x809F770", VA = "0x1880A0D70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct AFJLNGFCDDF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public AsyncTaskMethodBuilder<List<IBDLCAGKBBC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public KLAAMANKFBH <>4__this;

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
		private List<IBDLCAGKBBC> <results>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private TaskAwaiter<List<ILGGPNNKPBL>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x809FDC0", Offset = "0x809E7C0", VA = "0x18809FDC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x80A0570", Offset = "0x809EF70", VA = "0x1880A0570", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct PJGKCCMBKHM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public AsyncTaskMethodBuilder<List<IBDLCAGKBBC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public KLAAMANKFBH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public IReadOnlyList<LMEDGHCCMPL> unifiedItemIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public bool convertCustomAvatarItemsToPurchasableGiftDrops;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private List<IBDLCAGKBBC> <storeItemsInInitialOrder>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private TaskAwaiter<List<ILGGPNNKPBL>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x80A7E60", Offset = "0x80A6860", VA = "0x1880A7E60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x80A8700", Offset = "0x80A7100", VA = "0x1880A8700", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct MFMAFNKKAIP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public AsyncTaskMethodBuilder<List<ILGGPNNKPBL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public List<ILGGPNNKPBL> customAvatarItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public KLAAMANKFBH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x80A7880", Offset = "0x80A6280", VA = "0x1880A7880", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x80A7D70", Offset = "0x80A6770", VA = "0x1880A7D70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class PPNPICGNKEK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public LMEDGHCCMPL id;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public PPNPICGNKEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x80A8770", Offset = "0x80A7170", VA = "0x1880A8770")]
		internal bool CJAGEADNPOM(ENADPMLNGFD x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x80A87B0", Offset = "0x80A71B0", VA = "0x1880A87B0")]
		internal bool LJDOGOPDDJG(IBDLCAGKBBC x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class EDCANAFHKGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public string itemFriendlyName;

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public EDCANAFHKGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x80A05E0", Offset = "0x809EFE0", VA = "0x1880A05E0")]
		internal object BKBJKDAMDIN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class OCKEPCFLPGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public KLAAMANKFBH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public GiftItemDTO gift;

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public OCKEPCFLPGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x80A7E20", Offset = "0x80A6820", VA = "0x1880A7E20")]
		internal void LFIAEICIOOF(BalanceUpdateResponseDTO<MJINEIMEFND> result)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct GPOKJCKHCDE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public AsyncTaskMethodBuilder<FDNIKCICCGL<BalanceUpdateResponseDTO<MJINEIMEFND>>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public KLAAMANKFBH <>4__this;

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
		public DHELJFMKHFJ storefrontType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public HINNIBAPJEH currencyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private TaskAwaiter<DDGIJFCOHNN> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private TaskAwaiter<FDNIKCICCGL<BalanceUpdateResponseDTO<MJINEIMEFND>>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x80A0DE0", Offset = "0x809F7E0", VA = "0x1880A0DE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x80A12C0", Offset = "0x809FCC0", VA = "0x1880A12C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class MGPGNBNEILD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public KLAAMANKFBH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public bool handleShowGiftPackage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public bool shouldConsumeGiftBoxImmediately;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public MGPGNBNEILD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x80A7DE0", Offset = "0x80A67E0", VA = "0x1880A7DE0")]
		internal void EEHLFGLCBAE(BalanceUpdateResponseDTO<MJINEIMEFND> result)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct EPDBDNEABBP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public AsyncTaskMethodBuilder<List<DDGIJFCOHNN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public IReadOnlyList<Guid> itemIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public KLAAMANKFBH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private TaskAwaiter<List<PBLFEIBOBFB>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x80A0630", Offset = "0x809F030", VA = "0x1880A0630", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x80A0A30", Offset = "0x809F430", VA = "0x1880A0A30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct IEPPGEKBHOD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public List<IBDLCAGKBBC> storeItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public KLAAMANKFBH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private int <attemptNumber>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x80A3AE0", Offset = "0x80A24E0", VA = "0x1880A3AE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x80A3FD0", Offset = "0x80A29D0", VA = "0x1880A3FD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly AEKPPAJMFLM<Guid, DDGIJFCOHNN> NDHFKPINHHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private ENFPEIKBNKC MGOKAJOEFFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private HCNHDFFLBIJ JKPPAKFPAOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private GENCKGAJCEJ ENNPCNKHKGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private CLNMPOLJIGK JGHOCNDKNOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private DBIACDJFABC PMCNMEPOAIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private OLFIBAGDMNG AHGNNPDGDGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal AKJHEKJEJOA<Guid, DDGIJFCOHNN> EGGGBDCIOEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private bool FIMHNIKAAJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private Task GLOFDFDNCIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private CancellationTokenSource KFNFKKODAHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private List<ENADPMLNGFD> HFCLAEOBABI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private PAPPIAAGFFF? HCMKLCGJOKP;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static DBLBJNNJBIA HLFNBBPIHNM;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private List<ENADPMLNGFD> JMKGFDPLICH
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x80A66F0", Offset = "0x80A50F0", VA = "0x1880A66F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private PAPPIAAGFFF OLGBCPCEIEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x80A4530", Offset = "0x80A2F30", VA = "0x1880A4530")]
		get
		{
			return default(PAPPIAAGFFF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static DBLBJNNJBIA LALLOKGAEJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x80A6600", Offset = "0x80A5000", VA = "0x1880A6600")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x80A72A0", Offset = "0x80A5CA0", VA = "0x1880A72A0")]
	private List<ENADPMLNGFD> PCHNCNNPBEP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x80A4740", Offset = "0x80A3140", VA = "0x1880A4740")]
	[EFEOGKEOEKD.NFFKHFKJNGH.EEKBBBNAJHI]
	internal static void CEMBNDEBLBN(LKOLOODKMPF MCJDMILNGAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x80A7410", Offset = "0x80A5E10", VA = "0x1880A7410")]
	[RecRoom.NoEngine.Common.Preserve]
	public KLAAMANKFBH([GJJKIKPKKBJ(null)] GENCKGAJCEJ ENNPCNKHKGK, [GJJKIKPKKBJ(null)] ENFPEIKBNKC MGOKAJOEFFN, [GJJKIKPKKBJ(null)] HCNHDFFLBIJ JKPPAKFPAOK, [GJJKIKPKKBJ(null)] CLNMPOLJIGK JGHOCNDKNOO, [GJJKIKPKKBJ(null)] DBIACDJFABC PMCNMEPOAIN, [GJJKIKPKKBJ(null)] OLFIBAGDMNG AHGNNPDGDGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x80A56E0", Offset = "0x80A40E0", VA = "0x1880A56E0", Slot = "1")]
	~KLAAMANKFBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x80A4E30", Offset = "0x80A3830", VA = "0x1880A4E30", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x80A6510", Offset = "0x80A4F10", VA = "0x1880A6510")]
	[AsyncStateMachine(typeof(HNHJLCJJIFL))]
	private Task JHGMFIJLOLE(CancellationToken BJEPDCCBCHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x80A6890", Offset = "0x80A5290", VA = "0x1880A6890")]
	public void MAFHBFLILME(Guid OFPOOCKAALP, DDGIJFCOHNN ODBFPAJOACN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x80A54B0", Offset = "0x80A3EB0", VA = "0x1880A54B0", Slot = "13")]
	public void FGFFNPNJDNL(IBDLCAGKBBC EMJEDBNDJMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x80A69D0", Offset = "0x80A53D0", VA = "0x1880A69D0", Slot = "4")]
	public void MEIHFLNMDKH(IEnumerable<IBDLCAGKBBC> IAMGLFDKFLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x80A4EA0", Offset = "0x80A38A0", VA = "0x1880A4EA0", Slot = "14")]
	public DDGIJFCOHNN EMAEGJFMCEB(Guid NJBMCDEDLGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x80A4FA0", Offset = "0x80A39A0", VA = "0x1880A4FA0", Slot = "5")]
	public DDGIJFCOHNN EMAEGJFMCEB(IBDLCAGKBBC EMJEDBNDJMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x80A6B80", Offset = "0x80A5580", VA = "0x1880A6B80", Slot = "15")]
	[AsyncStateMachine(typeof(FFIFPDJLKOL))]
	public Task<DDGIJFCOHNN> MODFODCHKHH(Guid NJBMCDEDLGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x80A63B0", Offset = "0x80A4DB0", VA = "0x1880A63B0", Slot = "6")]
	[AsyncStateMachine(typeof(AFJLNGFCDDF))]
	public Task<List<IBDLCAGKBBC>> JBJNILAFMIM(string CHFCHOEBOGG, bool? OKBDGFIMAKG, bool? KJLKCIMIKIG, IEnumerable<int> HLCGBPMOHMH, bool CONAKACOALB, bool PHHGALDPNPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x80A43F0", Offset = "0x80A2DF0", VA = "0x1880A43F0", Slot = "7")]
	[AsyncStateMachine(typeof(PJGKCCMBKHM))]
	public Task<List<IBDLCAGKBBC>> BALELKLIHCJ(IReadOnlyList<LMEDGHCCMPL> MIODDMKJIKF, bool PAKDIFFJHJI = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x80A61A0", Offset = "0x80A4BA0", VA = "0x1880A61A0")]
	[AsyncStateMachine(typeof(MFMAFNKKAIP))]
	private Task<List<ILGGPNNKPBL>> HGNMDBOAKMF(List<ILGGPNNKPBL> GMEMBAMNEME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x80A47E0", Offset = "0x80A31E0", VA = "0x1880A47E0")]
	private List<IBDLCAGKBBC> CIFOFECNHLO(IReadOnlyList<LMEDGHCCMPL> OMOAEOPLPHI, IReadOnlyList<ENADPMLNGFD> BELJOFDBKLB, IReadOnlyList<IBDLCAGKBBC> GMEMBAMNEME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x80A6C90", Offset = "0x80A5690", VA = "0x1880A6C90", Slot = "8")]
	public ECHAPNAJEJF<BalanceUpdateResponseDTO<MJINEIMEFND>> NEKHJKFMOCE(Guid NJBMCDEDLGE, long KEPIKOGFBEN, GiftItemDTO GGAAPHAEIPO, HINNIBAPJEH OGKGDLBBNEL = HINNIBAPJEH.RecCenterTokens, [Optional] long? MPIKGKALMGC, DHELJFMKHFJ OKLCHMDADCD = DHELJFMKHFJ.None)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x80A4290", Offset = "0x80A2C90", VA = "0x1880A4290")]
	[AsyncStateMachine(typeof(GPOKJCKHCDE))]
	private Task<FDNIKCICCGL<BalanceUpdateResponseDTO<MJINEIMEFND>>> ALGIOFBKGJL(Guid NJBMCDEDLGE, long KEPIKOGFBEN, GiftItemDTO GGAAPHAEIPO, HINNIBAPJEH OGKGDLBBNEL = HINNIBAPJEH.RecCenterTokens, [Optional] long? MPIKGKALMGC, DHELJFMKHFJ OKLCHMDADCD = DHELJFMKHFJ.None)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x80A4030", Offset = "0x80A2A30", VA = "0x1880A4030", Slot = "9")]
	public ECHAPNAJEJF<BalanceUpdateResponseDTO<MJINEIMEFND>> ACDCFLCEOOP(DHELJFMKHFJ OKLCHMDADCD, HINNIBAPJEH OGKGDLBBNEL, int DHIFLABFMOL, long KEPIKOGFBEN, long? MPIKGKALMGC, int NOCPAFBPCKL, bool EPILAHAPPGE = false, bool CHJEPGFMDAF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x80A57D0", Offset = "0x80A41D0", VA = "0x1880A57D0", Slot = "10")]
	public ECHAPNAJEJF<BalanceUpdateResponseDTO<MJINEIMEFND>> GICOODGOIED(DHELJFMKHFJ OKLCHMDADCD, HINNIBAPJEH OGKGDLBBNEL, int DHIFLABFMOL, long KEPIKOGFBEN, long? MPIKGKALMGC, IReadOnlyCollection<int> IJGBGOMNDBF, string FLPDJFEEMLN, bool ONOODAKPDII, PHLKILLMMMD MHLFEBCHDEB, int NOCPAFBPCKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x80A5CC0", Offset = "0x80A46C0", VA = "0x1880A5CC0", Slot = "11")]
	public ECHAPNAJEJF<BalanceUpdateResponseDTO<MJINEIMEFND>> HAEMFNGJMPM(DHELJFMKHFJ OKLCHMDADCD, HINNIBAPJEH OGKGDLBBNEL, IReadOnlyList<int> JCCBLAOJMCN, IReadOnlyList<long> FJPKNCOJJPN, long? MPIKGKALMGC, int DODGOEHCFCL, string FLPDJFEEMLN, bool ONOODAKPDII, PHLKILLMMMD MHLFEBCHDEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x80A6EF0", Offset = "0x80A58F0", VA = "0x1880A6EF0")]
	[AsyncStateMachine(typeof(EPDBDNEABBP))]
	private Task<List<DDGIJFCOHNN>> NKDPOJALFPH(IReadOnlyList<Guid> PPIJENINJAL, CancellationToken BJEPDCCBCHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x80A51A0", Offset = "0x80A3BA0", VA = "0x1880A51A0")]
	private void FGCGCIBHCMF(BalanceUpdateResponseDTO<MJINEIMEFND> KDAAKPFEOEP, bool KOHDNGIMMOG, bool CHJEPGFMDAF, bool EPILAHAPPGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x80A7030", Offset = "0x80A5A30", VA = "0x1880A7030")]
	private void OHKBJMIFPMG(LJFIFIAEEED PJGKBLDPEBG, bool ODEOJGOFOIL, bool MKBGMFLKBKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x80A62B0", Offset = "0x80A4CB0", VA = "0x1880A62B0")]
	[AsyncStateMachine(typeof(IEPPGEKBHOD))]
	private Task INMEPJNONHC(List<IBDLCAGKBBC> IAMGLFDKFLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x80A4E00", Offset = "0x80A3800", VA = "0x1880A4E00")]
	[CompilerGenerated]
	private void FOKDMBIJOIP(BalanceUpdateResponseDTO<MJINEIMEFND> FFBEKAFHIDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x80A4E00", Offset = "0x80A3800", VA = "0x1880A4E00")]
	[CompilerGenerated]
	private void CNGHJHKCHFG(BalanceUpdateResponseDTO<MJINEIMEFND> FFBEKAFHIDB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class HABGJHKLJOI : OLIHKFKKBPA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly DBIACDJFABC NKNKNMDGCPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly JNACJGHHJLP BBDELECJBOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly JHOCGKKBGOK CGEGFIDLCPP;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x80A32F0", Offset = "0x80A1CF0", VA = "0x1880A32F0")]
	[EFEOGKEOEKD.NFFKHFKJNGH.EEKBBBNAJHI]
	internal static void LMIBOGDHNKD(LKOLOODKMPF MCJDMILNGAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0xBD8D10", Offset = "0xBD7710", VA = "0x180BD8D10")]
	[RecRoom.NoEngine.Common.Preserve]
	public HABGJHKLJOI([GJJKIKPKKBJ(null)] DBIACDJFABC PMCNMEPOAIN, [GJJKIKPKKBJ(null)] JNACJGHHJLP AGHBFMAGFKE, [GJJKIKPKKBJ(null)] JHOCGKKBGOK GMEMBAMNEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x80A3360", Offset = "0x80A1D60", VA = "0x1880A3360")]
	private bool MCFMNCADCOH(FFANFHDCBDL LJKDNEBFNMH, FFANFHDCBDL BPAAOMLLCIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x80A2EF0", Offset = "0x80A18F0", VA = "0x1880A2EF0", Slot = "5")]
	public IReadOnlyList<IBDLCAGKBBC> KHLLLDECKEE(FFANFHDCBDL BBOOLDJCPCC, IReadOnlyList<IBDLCAGKBBC> NNLLAHLBLIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x80A22F0", Offset = "0x80A0CF0", VA = "0x1880A22F0", Slot = "4")]
	public bool JMPJKOAEIIK(FFANFHDCBDL BBOOLDJCPCC, IBDLCAGKBBC OIBJKKOCOBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x80A31D0", Offset = "0x80A1BD0", VA = "0x1880A31D0")]
	private bool LALKFFPDCBC(FFANFHDCBDL BBOOLDJCPCC, IBDLCAGKBBC OIBJKKOCOBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x80A1F00", Offset = "0x80A0900", VA = "0x1880A1F00")]
	private bool JACMIDJIANI(FFANFHDCBDL BBOOLDJCPCC, IBDLCAGKBBC OIBJKKOCOBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x80A3600", Offset = "0x80A2000", VA = "0x1880A3600")]
	private bool OPBDNCFKACO(FFANFHDCBDL BBOOLDJCPCC, IBDLCAGKBBC OIBJKKOCOBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x80A18D0", Offset = "0x80A02D0", VA = "0x1880A18D0")]
	public bool ENLLBCLHGPH(IBDLCAGKBBC EMJEDBNDJMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x80A1810", Offset = "0x80A0210", VA = "0x1880A1810")]
	public bool ENLLBCLHGPH(FDDIMECDMGP LHIILLOPFBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x80A3700", Offset = "0x80A2100", VA = "0x1880A3700")]
	private bool PMEBHKAPGLA(Guid NJBMCDEDLGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x80A1E40", Offset = "0x80A0840", VA = "0x1880A1E40")]
	private bool HKHIGODLCAE(FFANFHDCBDL BBOOLDJCPCC, IBDLCAGKBBC OIBJKKOCOBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x80A1E20", Offset = "0x80A0820", VA = "0x1880A1E20")]
	private bool HENNIGOIAKN(FFANFHDCBDL BBOOLDJCPCC, IBDLCAGKBBC OIBJKKOCOBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x80A1DB0", Offset = "0x80A07B0", VA = "0x1880A1DB0")]
	private bool GPHKNLIMPDD(FFANFHDCBDL BBOOLDJCPCC, IBDLCAGKBBC OIBJKKOCOBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x80A1CB0", Offset = "0x80A06B0", VA = "0x1880A1CB0")]
	private bool GCCHGCIOOAL(FFANFHDCBDL BBOOLDJCPCC, IBDLCAGKBBC OIBJKKOCOBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x80A3400", Offset = "0x80A1E00", VA = "0x1880A3400")]
	private bool NNNJPJCICLO(FFANFHDCBDL BBOOLDJCPCC, IBDLCAGKBBC OIBJKKOCOBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x80A3470", Offset = "0x80A1E70", VA = "0x1880A3470")]
	private bool NPNNFBPAAGL(FFANFHDCBDL BBOOLDJCPCC, IBDLCAGKBBC OIBJKKOCOBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x80A16E0", Offset = "0x80A00E0", VA = "0x1880A16E0")]
	private bool DGAFHGDIHJH(FFANFHDCBDL BBOOLDJCPCC, IBDLCAGKBBC OIBJKKOCOBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x80A3670", Offset = "0x80A2070", VA = "0x1880A3670")]
	private bool PFHPFMCINDJ(FFANFHDCBDL BBOOLDJCPCC, IBDLCAGKBBC OIBJKKOCOBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x80A1470", Offset = "0x809FE70", VA = "0x1880A1470")]
	private bool CKLEAPOEEHG(FFANFHDCBDL BBOOLDJCPCC, IBDLCAGKBBC OIBJKKOCOBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x80A34E0", Offset = "0x80A1EE0", VA = "0x1880A34E0")]
	private bool OAJBNANPONO(FFANFHDCBDL BBOOLDJCPCC, IBDLCAGKBBC OIBJKKOCOBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x80A1E70", Offset = "0x80A0870", VA = "0x1880A1E70")]
	private bool IPMMFDGACGG(FFANFHDCBDL BBOOLDJCPCC, IBDLCAGKBBC OIBJKKOCOBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x80A3140", Offset = "0x80A1B40", VA = "0x1880A3140")]
	private bool KJFGALMNEHF(FFANFHDCBDL BBOOLDJCPCC, IBDLCAGKBBC OIBJKKOCOBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x80A2260", Offset = "0x80A0C60", VA = "0x1880A2260")]
	private bool JDEFGBGIOMK(FFANFHDCBDL BBOOLDJCPCC, IBDLCAGKBBC OIBJKKOCOBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x80A1530", Offset = "0x809FF30", VA = "0x1880A1530")]
	private bool CLOJILHKJPE(FFANFHDCBDL BBOOLDJCPCC, IBDLCAGKBBC OIBJKKOCOBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x80A1B20", Offset = "0x80A0520", VA = "0x1880A1B20")]
	private bool EPHHMIINIAM(FFANFHDCBDL BBOOLDJCPCC, IBDLCAGKBBC OIBJKKOCOBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x80A3570", Offset = "0x80A1F70", VA = "0x1880A3570")]
	private bool OCBIMHFLBDO(FFANFHDCBDL BBOOLDJCPCC, IBDLCAGKBBC OIBJKKOCOBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x80A3260", Offset = "0x80A1C60", VA = "0x1880A3260")]
	private bool LFEPBABGNOE(FFANFHDCBDL BBOOLDJCPCC, IBDLCAGKBBC OIBJKKOCOBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x80A1650", Offset = "0x80A0050", VA = "0x1880A1650")]
	private bool CPDHKKIMDMG(FFANFHDCBDL BBOOLDJCPCC, IBDLCAGKBBC OIBJKKOCOBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x80A3370", Offset = "0x80A1D70", VA = "0x1880A3370")]
	private bool MGMLPLFBNDJ(FFANFHDCBDL BBOOLDJCPCC, IBDLCAGKBBC OIBJKKOCOBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x80A1BB0", Offset = "0x80A05B0", VA = "0x1880A1BB0")]
	private bool FPIMALPGCEF(FFANFHDCBDL BBOOLDJCPCC, IBDLCAGKBBC OIBJKKOCOBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x80A1750", Offset = "0x80A0150", VA = "0x1880A1750")]
	private bool DJBFJNINOCE(FFANFHDCBDL BBOOLDJCPCC, IBDLCAGKBBC OIBJKKOCOBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x80A13A0", Offset = "0x809FDA0", VA = "0x1880A13A0")]
	private bool BMJMHCEFPDK(FFANFHDCBDL BBOOLDJCPCC, IBDLCAGKBBC OIBJKKOCOBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x80A15C0", Offset = "0x809FFC0", VA = "0x1880A15C0")]
	private bool CPCLOMGEJBC(FFANFHDCBDL BBOOLDJCPCC, IBDLCAGKBBC OIBJKKOCOBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x80A1C40", Offset = "0x80A0640", VA = "0x1880A1C40")]
	private bool GBGHMKBBLGK(FFANFHDCBDL BBOOLDJCPCC, IBDLCAGKBBC OIBJKKOCOBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x80A2E60", Offset = "0x80A1860", VA = "0x1880A2E60")]
	private bool JOCADNCBMGG(FFANFHDCBDL BBOOLDJCPCC, IBDLCAGKBBC OIBJKKOCOBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x80A1D20", Offset = "0x80A0720", VA = "0x1880A1D20")]
	private bool GFLBEPCDPAN(FFANFHDCBDL BBOOLDJCPCC, IBDLCAGKBBC OIBJKKOCOBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x80A1330", Offset = "0x809FD30", VA = "0x1880A1330")]
	private bool BHFBBJAJAJN(FFANFHDCBDL BBOOLDJCPCC, IBDLCAGKBBC OIBJKKOCOBE)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class LPHLOPHCPMO
{
	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
	public LPHLOPHCPMO()
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
