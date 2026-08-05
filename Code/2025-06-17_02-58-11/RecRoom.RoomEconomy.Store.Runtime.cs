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
		[Cpp2IlInjected.Address(RVA = "0x857D610", Offset = "0x857C010", VA = "0x18857D610", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2796C60", Offset = "0x2795660", VA = "0x182796C60")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class CPLHGJNFMNP : PIKLDCBAIDM, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private struct EEGFFBDJFFH : IAsyncStateMachine
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
		public CPLHGJNFMNP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8578850", Offset = "0x8577250", VA = "0x188578850", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8578B50", Offset = "0x8577550", VA = "0x188578B50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private struct AJDKCBIEFMG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public AsyncTaskMethodBuilder<HMFFDFOIHGO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public CPLHGJNFMNP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public Guid customAvatarItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private TaskAwaiter<HMFFDFOIHGO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8574370", Offset = "0x8572D70", VA = "0x188574370", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8574640", Offset = "0x8573040", VA = "0x188574640", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct JBPKGPDAKDL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public AsyncTaskMethodBuilder<List<LLJFOPOCGJJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public CPLHGJNFMNP <>4__this;

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
		private List<LLJFOPOCGJJ> <results>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private TaskAwaiter<List<GNDDLPACFNL>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x85797A0", Offset = "0x85781A0", VA = "0x1885797A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8579F50", Offset = "0x8578950", VA = "0x188579F50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct JHIEOBAFFBL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public AsyncTaskMethodBuilder<List<LLJFOPOCGJJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public CPLHGJNFMNP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public IReadOnlyList<CGLIDIKFDHJ> unifiedItemIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public bool convertCustomAvatarItemsToPurchasableGiftDrops;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private Task <watchStorefrontTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private List<GNDDLPACFNL> <customAvatarItems>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private List<LLJFOPOCGJJ> <storeItemsInInitialOrder>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private TaskAwaiter<List<GNDDLPACFNL>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8579FC0", Offset = "0x85789C0", VA = "0x188579FC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x857AA20", Offset = "0x8579420", VA = "0x18857AA20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct NNMKBMHAAKN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public AsyncTaskMethodBuilder<List<GNDDLPACFNL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public List<GNDDLPACFNL> customAvatarItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public CPLHGJNFMNP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x857CF20", Offset = "0x857B920", VA = "0x18857CF20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x857D410", Offset = "0x857BE10", VA = "0x18857D410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class IBPMNMODNKB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public CGLIDIKFDHJ id;

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public IBPMNMODNKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x85791F0", Offset = "0x8577BF0", VA = "0x1885791F0")]
		internal bool DLGDIHFELHI(JNPHMLACLHJ x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8579230", Offset = "0x8577C30", VA = "0x188579230")]
		internal bool JIGCNHOIGOF(LLJFOPOCGJJ x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class EPDBEFNPKGG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public string itemFriendlyName;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public EPDBEFNPKGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8578BB0", Offset = "0x85775B0", VA = "0x188578BB0")]
		internal object NFCPKPPPGEK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class IEIKILKGDCD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public CPLHGJNFMNP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public GiftItemDTO gift;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public IEIKILKGDCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x85792F0", Offset = "0x8577CF0", VA = "0x1885792F0")]
		internal void LPJAFDMINNI(BalanceUpdateResponseDTO<IMMJIDNEKKE> result)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct BOPLOACKGBG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public AsyncTaskMethodBuilder<LBACEDKNOPC<BalanceUpdateResponseDTO<IMMJIDNEKKE>>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public CPLHGJNFMNP <>4__this;

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
		public LJDHGOJBBKP storefrontType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public BNIFAHGCPKG currencyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private TaskAwaiter<HMFFDFOIHGO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TaskAwaiter<LBACEDKNOPC<BalanceUpdateResponseDTO<IMMJIDNEKKE>>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x85746B0", Offset = "0x85730B0", VA = "0x1885746B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8574B90", Offset = "0x8573590", VA = "0x188574B90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class NIBLJCHBKCF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public CPLHGJNFMNP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public bool handleShowGiftPackage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public bool shouldConsumeGiftBoxImmediately;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public NIBLJCHBKCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x857CEE0", Offset = "0x857B8E0", VA = "0x18857CEE0")]
		internal void GHIAADOBPMD(BalanceUpdateResponseDTO<IMMJIDNEKKE> result)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct IJKIEDJEKLO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public AsyncTaskMethodBuilder<List<HMFFDFOIHGO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public IReadOnlyList<Guid> itemIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public CPLHGJNFMNP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private TaskAwaiter<List<JAGIDPFOFHL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8579330", Offset = "0x8577D30", VA = "0x188579330", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8579730", Offset = "0x8578130", VA = "0x188579730", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct GDAJLBLEKLO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public List<LLJFOPOCGJJ> storeItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public CPLHGJNFMNP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private int <attemptNumber>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8578C00", Offset = "0x8577600", VA = "0x188578C00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8579190", Offset = "0x8577B90", VA = "0x188579190", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly GFEMDEFLCJM<Guid, HMFFDFOIHGO> HONFBAGKPHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private DCCIEDHPKOJ JEBDMANDAOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private GOHCAEHOLFM GCHEONKDNDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private KFPAFNJKJID JMMBHCFJMCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private HFHCBMCAFCL CFDGMDEOBIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private AAKFNIIOLKM GGOFFGNEPLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private NDICJCLBPMH DGDCHCJJMID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal NLGJDJPALEH<Guid, HMFFDFOIHGO> LOLIGBKPKMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private bool KJMPONALMPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private Task MIFOAFNPLIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private CancellationTokenSource ANKHAILKJCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private List<JNPHMLACLHJ> BLJLONNNNKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private PJMELMCPOKO? CMIALKGDBNE;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static PIKLDCBAIDM IAPMLBGOKMC;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private List<JNPHMLACLHJ> CFHKPCPKNOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8575EC0", Offset = "0x85748C0", VA = "0x188575EC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private PJMELMCPOKO CPHIHGPHDNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x85761D0", Offset = "0x8574BD0", VA = "0x1885761D0")]
		get
		{
			return default(PJMELMCPOKO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static PIKLDCBAIDM FDCAMNOGINK
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8576FD0", Offset = "0x85759D0", VA = "0x188576FD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x8576A60", Offset = "0x8575460", VA = "0x188576A60")]
	private List<JNPHMLACLHJ> FIIIOJBLLKI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x8578250", Offset = "0x8576C50", VA = "0x188578250")]
	[CGLGNCLDKHN.DMOOKONHNLA.CCDNIDCBBNI]
	internal static void NBDHNJGHJEB(MHGNCMHMEKD DJGDNAKMFCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x85783E0", Offset = "0x8576DE0", VA = "0x1885783E0")]
	[RecRoom.NoEngine.Common.Preserve]
	public CPLHGJNFMNP([CNHMBDDCGKB(null)] KFPAFNJKJID JMMBHCFJMCL, [CNHMBDDCGKB(null)] DCCIEDHPKOJ JEBDMANDAOH, [CNHMBDDCGKB(null)] GOHCAEHOLFM GCHEONKDNDC, [CNHMBDDCGKB(null)] HFHCBMCAFCL CFDGMDEOBIP, [CNHMBDDCGKB(null)] AAKFNIIOLKM GGOFFGNEPLC, [CNHMBDDCGKB(null)] NDICJCLBPMH DGDCHCJJMID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x8576EE0", Offset = "0x85758E0", VA = "0x188576EE0", Slot = "1")]
	~CPLHGJNFMNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x8576060", Offset = "0x8574A60", VA = "0x188576060", Slot = "13")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x85782F0", Offset = "0x8576CF0", VA = "0x1885782F0")]
	[AsyncStateMachine(typeof(EEGFFBDJFFH))]
	private Task PFHEKPEAMLP(CancellationToken JKPNCAGHEDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x8578100", Offset = "0x8576B00", VA = "0x188578100")]
	public void MIIGJHAJMPI(Guid FOLIMMBLOPB, HMFFDFOIHGO OAOONCIIFPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x85763E0", Offset = "0x8574DE0", VA = "0x1885763E0", Slot = "14")]
	public void FEDLMLBCDBM(LLJFOPOCGJJ CFKGAHDINDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x85779E0", Offset = "0x85763E0", VA = "0x1885779E0", Slot = "4")]
	public void IONNIPNPNKG(IEnumerable<LLJFOPOCGJJ> KMKFAPJNFKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x8577B90", Offset = "0x8576590", VA = "0x188577B90", Slot = "15")]
	public HMFFDFOIHGO IPEPLBKECDG(Guid LPOCINEMHOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x8577C90", Offset = "0x8576690", VA = "0x188577C90", Slot = "5")]
	public HMFFDFOIHGO IPEPLBKECDG(LLJFOPOCGJJ CFKGAHDINDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x8575890", Offset = "0x8574290", VA = "0x188575890", Slot = "16")]
	[AsyncStateMachine(typeof(AJDKCBIEFMG))]
	public Task<HMFFDFOIHGO> CLFFFACHGOI(Guid LPOCINEMHOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x8576610", Offset = "0x8575010", VA = "0x188576610", Slot = "7")]
	[AsyncStateMachine(typeof(JBPKGPDAKDL))]
	public Task<List<LLJFOPOCGJJ>> FGHPKJFJHDG(string DDNLFAADKOP, bool? ICJCFHNKABJ, bool? KBMMOAGMKGC, IEnumerable<int> MNIKBBOJEGJ, bool LMLOKHLOCOP, bool ADEOCJCGLFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x8576770", Offset = "0x8575170", VA = "0x188576770", Slot = "6")]
	public LLJFOPOCGJJ FICNJFMGJEO(CGLIDIKFDHJ FOLIMMBLOPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x8574D60", Offset = "0x8573760", VA = "0x188574D60", Slot = "8")]
	[AsyncStateMachine(typeof(JHIEOBAFFBL))]
	public Task<List<LLJFOPOCGJJ>> AOOIGOFBAHO(IReadOnlyList<CGLIDIKFDHJ> LCLIAAKCKAO, bool BKABCFNHBLF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x8577370", Offset = "0x8575D70", VA = "0x188577370")]
	[AsyncStateMachine(typeof(NNMKBMHAAKN))]
	private Task<List<GNDDLPACFNL>> HIINGHDEGAF(List<GNDDLPACFNL> FEOFNCKAHON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x8575270", Offset = "0x8573C70", VA = "0x188575270")]
	private List<LLJFOPOCGJJ> CBEJPCNMDBG(IReadOnlyList<CGLIDIKFDHJ> PLPLCEDDBFO, IReadOnlyList<JNPHMLACLHJ> KNLKLJAGIPA, IReadOnlyList<LLJFOPOCGJJ> FEOFNCKAHON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x8574ED0", Offset = "0x85738D0", VA = "0x188574ED0", Slot = "9")]
	public MPBOGDMHBIL<BalanceUpdateResponseDTO<IMMJIDNEKKE>> BKGPNJLLLKF(Guid LPOCINEMHOG, long KHIJBJOADGF, GiftItemDTO BBJKJDDNFFP, BNIFAHGCPKG HOALEGLICGN = BNIFAHGCPKG.RecCenterTokens, [Optional] long? LBDNLKPDPIO, LJDHGOJBBKP BPOGMBKNFOG = LJDHGOJBBKP.None)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x8574C00", Offset = "0x8573600", VA = "0x188574C00")]
	[AsyncStateMachine(typeof(BOPLOACKGBG))]
	private Task<LBACEDKNOPC<BalanceUpdateResponseDTO<IMMJIDNEKKE>>> ALENDOJJNEA(Guid LPOCINEMHOG, long KHIJBJOADGF, GiftItemDTO BBJKJDDNFFP, BNIFAHGCPKG HOALEGLICGN = BNIFAHGCPKG.RecCenterTokens, [Optional] long? LBDNLKPDPIO, LJDHGOJBBKP BPOGMBKNFOG = LJDHGOJBBKP.None)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x85770C0", Offset = "0x8575AC0", VA = "0x1885770C0", Slot = "10")]
	public MPBOGDMHBIL<BalanceUpdateResponseDTO<IMMJIDNEKKE>> HHHJNPGFFMD(LJDHGOJBBKP BPOGMBKNFOG, BNIFAHGCPKG HOALEGLICGN, int EBPOEEFPKPL, long KHIJBJOADGF, long? LBDNLKPDPIO, int AIBLLMCMFMJ, bool BHMEDGIBDKO = false, bool CFJEIKOAJAH = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x8577480", Offset = "0x8575E80", VA = "0x188577480", Slot = "11")]
	public MPBOGDMHBIL<BalanceUpdateResponseDTO<IMMJIDNEKKE>> INCPPMNCEFO(LJDHGOJBBKP BPOGMBKNFOG, BNIFAHGCPKG HOALEGLICGN, int EBPOEEFPKPL, long KHIJBJOADGF, long? LBDNLKPDPIO, IReadOnlyCollection<int> PBOKAPKGBBN, string IJOJGNJMCGP, bool EPINGHNHPGM, GJCFPCHPCFH GBLADIMMHIK, int AIBLLMCMFMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x85759A0", Offset = "0x85743A0", VA = "0x1885759A0", Slot = "12")]
	public MPBOGDMHBIL<BalanceUpdateResponseDTO<IMMJIDNEKKE>> CMBLCCBBCCJ(LJDHGOJBBKP BPOGMBKNFOG, BNIFAHGCPKG HOALEGLICGN, IReadOnlyList<int> BNBGGEPHOPL, IReadOnlyList<long> OCJBGODBNCD, long? LBDNLKPDPIO, int PMIBMAFBCAK, string IJOJGNJMCGP, bool EPINGHNHPGM, GJCFPCHPCFH GBLADIMMHIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x8575130", Offset = "0x8573B30", VA = "0x188575130")]
	[AsyncStateMachine(typeof(IJKIEDJEKLO))]
	private Task<List<HMFFDFOIHGO>> BLBGDMBKCKM(IReadOnlyList<Guid> PHPBLDMPNJG, CancellationToken JKPNCAGHEDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x8576BD0", Offset = "0x85755D0", VA = "0x188576BD0")]
	private void FLOANFAKMEN(BalanceUpdateResponseDTO<IMMJIDNEKKE> COBBCGIHJAA, bool CAFBFPCNLOH, bool CFJEIKOAJAH, bool BHMEDGIBDKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x8577E90", Offset = "0x8576890", VA = "0x188577E90")]
	private void LOJCHPOCOCI(LGFBOBOEBPH ADBONEFNDLJ, bool AMFJEKIINPN, bool OPGNNIFIJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x85760D0", Offset = "0x8574AD0", VA = "0x1885760D0")]
	[AsyncStateMachine(typeof(GDAJLBLEKLO))]
	private Task EABIEEHDJHN(List<LLJFOPOCGJJ> KMKFAPJNFKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x8574EA0", Offset = "0x85738A0", VA = "0x188574EA0")]
	[CompilerGenerated]
	private void BFIEEJGGMPC(BalanceUpdateResponseDTO<IMMJIDNEKKE> MGJNMKLFKCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x8574EA0", Offset = "0x85738A0", VA = "0x188574EA0")]
	[CompilerGenerated]
	private void PFGOABJJOMG(BalanceUpdateResponseDTO<IMMJIDNEKKE> MGJNMKLFKCJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class MOBFHEDDCNA : IBFHOALAKDK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly AAKFNIIOLKM HHNDDNEEHMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly IGMDPHEOLOC ILDDEDMMKAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly AAJALCFIDHF HFKDHLCACAO;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x857C870", Offset = "0x857B270", VA = "0x18857C870")]
	[CGLGNCLDKHN.DMOOKONHNLA.CCDNIDCBBNI]
	internal static void JGOIPALGEOO(MHGNCMHMEKD DJGDNAKMFCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0xCC55F0", Offset = "0xCC3FF0", VA = "0x180CC55F0")]
	[RecRoom.NoEngine.Common.Preserve]
	public MOBFHEDDCNA([CNHMBDDCGKB(null)] AAKFNIIOLKM GGOFFGNEPLC, [CNHMBDDCGKB(null)] IGMDPHEOLOC EMOGAMHMCGI, [CNHMBDDCGKB(null)] AAJALCFIDHF FEOFNCKAHON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x857AC80", Offset = "0x8579680", VA = "0x18857AC80")]
	private bool BCEPAHGJDBA(CNIDGMAJNFF DIKPACIGBNO, CNIDGMAJNFF APLEAEFAEFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x857BE80", Offset = "0x857A880", VA = "0x18857BE80", Slot = "5")]
	public IReadOnlyList<LLJFOPOCGJJ> FANGKCMCNCP(CNIDGMAJNFF AOICMKBKAEN, IReadOnlyList<LLJFOPOCGJJ> PCNLBIOPFBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x857ADB0", Offset = "0x85797B0", VA = "0x18857ADB0", Slot = "4")]
	public bool CCMMFOPLIGB(CNIDGMAJNFF AOICMKBKAEN, LLJFOPOCGJJ HMJJODPHKCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x857C950", Offset = "0x857B350", VA = "0x18857C950")]
	private bool LKKOGACEOKD(CNIDGMAJNFF AOICMKBKAEN, LLJFOPOCGJJ HMJJODPHKCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x857BB20", Offset = "0x857A520", VA = "0x18857BB20")]
	private bool EOLLKIEOANF(CNIDGMAJNFF AOICMKBKAEN, LLJFOPOCGJJ HMJJODPHKCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x857C6B0", Offset = "0x857B0B0", VA = "0x18857C6B0")]
	private bool HDBJPMFGHIM(CNIDGMAJNFF AOICMKBKAEN, LLJFOPOCGJJ HMJJODPHKCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x857C280", Offset = "0x857AC80", VA = "0x18857C280")]
	public bool GAEANFFOIFL(LLJFOPOCGJJ CFKGAHDINDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x857C4D0", Offset = "0x857AED0", VA = "0x18857C4D0")]
	public bool GAEANFFOIFL(BNPOPJMGFNP LAENKPKKOAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x857CB40", Offset = "0x857B540", VA = "0x18857CB40")]
	private bool MINLEFEGPNB(Guid LPOCINEMHOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x857ABE0", Offset = "0x85795E0", VA = "0x18857ABE0")]
	private bool AGBKLOPMFAG(CNIDGMAJNFF AOICMKBKAEN, LLJFOPOCGJJ HMJJODPHKCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x857AD90", Offset = "0x8579790", VA = "0x18857AD90")]
	private bool CCDFGAMMFJN(CNIDGMAJNFF AOICMKBKAEN, LLJFOPOCGJJ HMJJODPHKCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x857CE00", Offset = "0x857B800", VA = "0x18857CE00")]
	private bool PCDFGCOAJFI(CNIDGMAJNFF AOICMKBKAEN, LLJFOPOCGJJ HMJJODPHKCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x857AC10", Offset = "0x8579610", VA = "0x18857AC10")]
	private bool AGNNGJOJJKC(CNIDGMAJNFF AOICMKBKAEN, LLJFOPOCGJJ HMJJODPHKCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x857CE70", Offset = "0x857B870", VA = "0x18857CE70")]
	private bool PLKLHEKIHCB(CNIDGMAJNFF AOICMKBKAEN, LLJFOPOCGJJ HMJJODPHKCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x857BA20", Offset = "0x857A420", VA = "0x18857BA20")]
	private bool EKBFACBLDMJ(CNIDGMAJNFF AOICMKBKAEN, LLJFOPOCGJJ HMJJODPHKCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x857AD20", Offset = "0x8579720", VA = "0x18857AD20")]
	private bool BOFHGECMNMN(CNIDGMAJNFF AOICMKBKAEN, LLJFOPOCGJJ HMJJODPHKCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x857AC90", Offset = "0x8579690", VA = "0x18857AC90")]
	private bool BKCNDIMBKBE(CNIDGMAJNFF AOICMKBKAEN, LLJFOPOCGJJ HMJJODPHKCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x857AB20", Offset = "0x8579520", VA = "0x18857AB20")]
	private bool AEKPNJDOHFP(CNIDGMAJNFF AOICMKBKAEN, LLJFOPOCGJJ HMJJODPHKCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x857C620", Offset = "0x857B020", VA = "0x18857C620")]
	private bool GPGCBGDIJGH(CNIDGMAJNFF AOICMKBKAEN, LLJFOPOCGJJ HMJJODPHKCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x857CC50", Offset = "0x857B650", VA = "0x18857CC50")]
	private bool NJMBDJFPFIN(CNIDGMAJNFF AOICMKBKAEN, LLJFOPOCGJJ HMJJODPHKCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x857C590", Offset = "0x857AF90", VA = "0x18857C590")]
	private bool GNBEAAJACMN(CNIDGMAJNFF AOICMKBKAEN, LLJFOPOCGJJ HMJJODPHKCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x857C720", Offset = "0x857B120", VA = "0x18857C720")]
	private bool HHOHMNDAJLJ(CNIDGMAJNFF AOICMKBKAEN, LLJFOPOCGJJ HMJJODPHKCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x857AA90", Offset = "0x8579490", VA = "0x18857AA90")]
	private bool ACDHFKJIGEJ(CNIDGMAJNFF AOICMKBKAEN, LLJFOPOCGJJ HMJJODPHKCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x857C1F0", Offset = "0x857ABF0", VA = "0x18857C1F0")]
	private bool FFGGGJGLPKP(CNIDGMAJNFF AOICMKBKAEN, LLJFOPOCGJJ HMJJODPHKCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x857C160", Offset = "0x857AB60", VA = "0x18857C160")]
	private bool FCONHGDPBOA(CNIDGMAJNFF AOICMKBKAEN, LLJFOPOCGJJ HMJJODPHKCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x857CAB0", Offset = "0x857B4B0", VA = "0x18857CAB0")]
	private bool MGCEFOMDOPC(CNIDGMAJNFF AOICMKBKAEN, LLJFOPOCGJJ HMJJODPHKCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x857CD70", Offset = "0x857B770", VA = "0x18857CD70")]
	private bool OOKNBKDEKPL(CNIDGMAJNFF AOICMKBKAEN, LLJFOPOCGJJ HMJJODPHKCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x857C0D0", Offset = "0x857AAD0", VA = "0x18857C0D0")]
	private bool FCGDMMADJIK(CNIDGMAJNFF AOICMKBKAEN, LLJFOPOCGJJ HMJJODPHKCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x857CBC0", Offset = "0x857B5C0", VA = "0x18857CBC0")]
	private bool NDFPOCKKLPE(CNIDGMAJNFF AOICMKBKAEN, LLJFOPOCGJJ HMJJODPHKCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x857C7B0", Offset = "0x857B1B0", VA = "0x18857C7B0")]
	private bool ILHCOHLENBA(CNIDGMAJNFF AOICMKBKAEN, LLJFOPOCGJJ HMJJODPHKCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x857C9E0", Offset = "0x857B3E0", VA = "0x18857C9E0")]
	private bool MEKGGDECFIH(CNIDGMAJNFF AOICMKBKAEN, LLJFOPOCGJJ HMJJODPHKCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x857CCE0", Offset = "0x857B6E0", VA = "0x18857CCE0")]
	private bool NMFLBIGABDM(CNIDGMAJNFF AOICMKBKAEN, LLJFOPOCGJJ HMJJODPHKCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x857B920", Offset = "0x857A320", VA = "0x18857B920")]
	private bool CCOOIIHNLDB(CNIDGMAJNFF AOICMKBKAEN, LLJFOPOCGJJ HMJJODPHKCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x857B990", Offset = "0x857A390", VA = "0x18857B990")]
	private bool DDKBICDMCPF(CNIDGMAJNFF AOICMKBKAEN, LLJFOPOCGJJ HMJJODPHKCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x857BA90", Offset = "0x857A490", VA = "0x18857BA90")]
	private bool EKCHNBHCDKF(CNIDGMAJNFF AOICMKBKAEN, LLJFOPOCGJJ HMJJODPHKCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x857C8E0", Offset = "0x857B2E0", VA = "0x18857C8E0")]
	private bool KHIKGNDGILI(CNIDGMAJNFF AOICMKBKAEN, LLJFOPOCGJJ HMJJODPHKCG)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class IBFGABBDLJO
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
	public IBFGABBDLJO()
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
