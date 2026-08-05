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
		[Cpp2IlInjected.Address(RVA = "0x7FA6C80", Offset = "0x7FA6080", VA = "0x187FA6C80", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x251F7B0", Offset = "0x251EBB0", VA = "0x18251F7B0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class ENJCCNAJLHP : DJFJBFCGIBE, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private struct DCFGJJLOPIH : IAsyncStateMachine
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
		public ENJCCNAJLHP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7FA1050", Offset = "0x7FA0450", VA = "0x187FA1050", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7FA1350", Offset = "0x7FA0750", VA = "0x187FA1350", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private struct IIDNEFJHDIF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public AsyncTaskMethodBuilder<KPJMPHJIKLH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public ENJCCNAJLHP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public Guid customAvatarItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private TaskAwaiter<KPJMPHJIKLH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7FA6660", Offset = "0x7FA5A60", VA = "0x187FA6660", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7FA6930", Offset = "0x7FA5D30", VA = "0x187FA6930", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct AAINKPKFDJP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public AsyncTaskMethodBuilder<List<HECAOJHPFAL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public ENJCCNAJLHP <>4__this;

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
		private List<HECAOJHPFAL> <results>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private TaskAwaiter<List<PBIPCIHMMEN>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7FA03B0", Offset = "0x7F9F7B0", VA = "0x187FA03B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7FA0B70", Offset = "0x7F9FF70", VA = "0x187FA0B70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct DDMOHGGMNEH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public AsyncTaskMethodBuilder<List<HECAOJHPFAL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public ENJCCNAJLHP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public IReadOnlyList<HFPMMFEHCHI> unifiedItemIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private List<HECAOJHPFAL> <storeItemsInInitialOrder>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private TaskAwaiter<List<PBIPCIHMMEN>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7FA1900", Offset = "0x7FA0D00", VA = "0x187FA1900", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7FA2190", Offset = "0x7FA1590", VA = "0x187FA2190", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct DNMMHJGOOCP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public AsyncTaskMethodBuilder<List<PBIPCIHMMEN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public List<PBIPCIHMMEN> customAvatarItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public ENJCCNAJLHP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x7FA27A0", Offset = "0x7FA1BA0", VA = "0x187FA27A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7FA2CA0", Offset = "0x7FA20A0", VA = "0x187FA2CA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class LCABLNDABLP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public HFPMMFEHCHI id;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public LCABLNDABLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7FA6A60", Offset = "0x7FA5E60", VA = "0x187FA6A60")]
		internal bool PBALPEBONOI(FPBJNCGCAAE x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7FA69A0", Offset = "0x7FA5DA0", VA = "0x187FA69A0")]
		internal bool DHDFLCIJIID(HECAOJHPFAL x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class DDOGPOFDKLG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public string itemFriendlyName;

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public DDOGPOFDKLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7FA2200", Offset = "0x7FA1600", VA = "0x187FA2200")]
		internal object IJJPPKNPPMI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class IIBKANOMHCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public ENJCCNAJLHP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public GiftItemDTO gift;

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public IIBKANOMHCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7FA6620", Offset = "0x7FA5A20", VA = "0x187FA6620")]
		internal void AFJKBBIINBM(BalanceUpdateResponseDTO<PDHABEAHIOD> result)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct DCFPOILAFBP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncTaskMethodBuilder<AGMCELHPBEM<BalanceUpdateResponseDTO<PDHABEAHIOD>>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public ENJCCNAJLHP <>4__this;

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
		public KPMNADCIPPD storefrontType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public OHDCEIDAPAG currencyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private TaskAwaiter<KPJMPHJIKLH> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private TaskAwaiter<AGMCELHPBEM<BalanceUpdateResponseDTO<PDHABEAHIOD>>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7FA13B0", Offset = "0x7FA07B0", VA = "0x187FA13B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7FA1890", Offset = "0x7FA0C90", VA = "0x187FA1890", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class NIEIDOFDANA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public ENJCCNAJLHP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public bool handleShowGiftPackage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public bool shouldConsumeGiftBoxImmediately;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public NIEIDOFDANA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7FA6AA0", Offset = "0x7FA5EA0", VA = "0x187FA6AA0")]
		internal void IBDGKOGFAHM(BalanceUpdateResponseDTO<PDHABEAHIOD> result)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct CELNHMEKDIB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public AsyncTaskMethodBuilder<List<KPJMPHJIKLH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public IReadOnlyList<Guid> itemIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public ENJCCNAJLHP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private TaskAwaiter<List<BKGFNCNDDNI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x7FA0BE0", Offset = "0x7F9FFE0", VA = "0x187FA0BE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7FA0FE0", Offset = "0x7FA03E0", VA = "0x187FA0FE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct DHNDPNBHMIK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public List<HECAOJHPFAL> storeItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public ENJCCNAJLHP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private int <attemptNumber>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7FA2250", Offset = "0x7FA1650", VA = "0x187FA2250", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7FA2740", Offset = "0x7FA1B40", VA = "0x187FA2740", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly JNDPPKEBKJL<Guid, KPJMPHJIKLH> DLIMLJOIKHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private OKCPJJMIFAC KHMELAKOBLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private AKBOMLLDMEO AKJJPPBKIJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private ABHODGNCBEB PCEIOHFAAEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private HKFMMKHJKKL ECHOPLHECHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private NKLMCHAGBIN PAENCDHCMNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private HNAFBHEKIKK JHNCNOHACNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal NENMPGKCOOL<Guid, KPJMPHJIKLH> FMACCLPEDLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private bool MIGDMPFDAHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private Task CKNNPGIDPOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private CancellationTokenSource LINDGADEJGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private List<FPBJNCGCAAE> HPDDKHPMDBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private HOEJAMMNOOE? NADIAOBMFDA;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static DJFJBFCGIBE JOAALLKFIIK;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private List<FPBJNCGCAAE> GGBPOCIJDHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7FA5A00", Offset = "0x7FA4E00", VA = "0x187FA5A00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private HOEJAMMNOOE HEHBGFDMAHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7FA3BD0", Offset = "0x7FA2FD0", VA = "0x187FA3BD0")]
		get
		{
			return default(HOEJAMMNOOE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static DJFJBFCGIBE DMADMDPHOOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7FA60C0", Offset = "0x7FA54C0", VA = "0x187FA60C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7FA3800", Offset = "0x7FA2C00", VA = "0x187FA3800")]
	private List<FPBJNCGCAAE> BOJAIJGHKMA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7FA4760", Offset = "0x7FA3B60", VA = "0x187FA4760")]
	[BOBPNFIGGBE.FIPHDKCKMAJ.LALHFPBIBCF]
	internal static void HEACPKLJJEL(NPIEGGOELNH PHDMEDCBLHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7FA61B0", Offset = "0x7FA55B0", VA = "0x187FA61B0")]
	[RecRoom.NoEngine.Common.Preserve]
	public ENJCCNAJLHP([GKAMHFFOHNI(null)] ABHODGNCBEB PCEIOHFAAEF, [GKAMHFFOHNI(null)] OKCPJJMIFAC KHMELAKOBLE, [GKAMHFFOHNI(null)] AKBOMLLDMEO AKJJPPBKIJF, [GKAMHFFOHNI(null)] HKFMMKHJKKL ECHOPLHECHA, [GKAMHFFOHNI(null)] NKLMCHAGBIN PAENCDHCMNN, [GKAMHFFOHNI(null)] HNAFBHEKIKK JHNCNOHACNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7FA4180", Offset = "0x7FA3580", VA = "0x187FA4180", Slot = "1")]
	~ENJCCNAJLHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7FA3B60", Offset = "0x7FA2F60", VA = "0x187FA3B60", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7FA48A0", Offset = "0x7FA3CA0", VA = "0x187FA48A0")]
	[AsyncStateMachine(typeof(DCFGJJLOPIH))]
	private Task HEJEGGKLEAA(CancellationToken BLABAMPAGAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7FA36C0", Offset = "0x7FA2AC0", VA = "0x187FA36C0")]
	public void BANLFOHJGMB(Guid BLEHHCPCAAJ, KPJMPHJIKLH IBJIBFINJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7FA3DF0", Offset = "0x7FA31F0", VA = "0x187FA3DF0", Slot = "13")]
	public void EGJLHHKAFHC(HECAOJHPFAL PBOGFELIJFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7FA39A0", Offset = "0x7FA2DA0", VA = "0x187FA39A0", Slot = "4")]
	public void DMDEEOALGJL(IEnumerable<HECAOJHPFAL> IJIKHLNPMDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7FA5DA0", Offset = "0x7FA51A0", VA = "0x187FA5DA0", Slot = "14")]
	public KPJMPHJIKLH NKAKELBHCGF(Guid DIFAHGJHFEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7FA5BA0", Offset = "0x7FA4FA0", VA = "0x187FA5BA0", Slot = "5")]
	public KPJMPHJIKLH NKAKELBHCGF(HECAOJHPFAL PBOGFELIJFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7FA4E00", Offset = "0x7FA4200", VA = "0x187FA4E00", Slot = "15")]
	[AsyncStateMachine(typeof(IIDNEFJHDIF))]
	public Task<KPJMPHJIKLH> KLBPBAHDGHH(Guid DIFAHGJHFEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7FA4020", Offset = "0x7FA3420", VA = "0x187FA4020", Slot = "6")]
	[AsyncStateMachine(typeof(AAINKPKFDJP))]
	public Task<List<HECAOJHPFAL>> FCABBOAMPLC(string NJBELPODFFG, bool? BBFLDLLAFFL, bool? LDEFFINNMMH, IEnumerable<int> IIFAEKOJFIO, bool DHOMOCOCMHJ, bool JKBAPIOEMNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7FA5FA0", Offset = "0x7FA53A0", VA = "0x187FA5FA0", Slot = "7")]
	[AsyncStateMachine(typeof(DDMOHGGMNEH))]
	public Task<List<HECAOJHPFAL>> NPKJOBBLAEL(IReadOnlyList<HFPMMFEHCHI> BCNBMCOKKKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7FA35B0", Offset = "0x7FA29B0", VA = "0x187FA35B0")]
	[AsyncStateMachine(typeof(DNMMHJGOOCP))]
	private Task<List<PBIPCIHMMEN>> AOOCBDBEOMG(List<PBIPCIHMMEN> LIONHABEEGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7FA2F90", Offset = "0x7FA2390", VA = "0x187FA2F90")]
	private List<HECAOJHPFAL> AKPDPCEGBAO(IReadOnlyList<HFPMMFEHCHI> DPHGIJNAEJM, IReadOnlyList<FPBJNCGCAAE> NDOKMDJGGAH, IReadOnlyList<HECAOJHPFAL> LIONHABEEGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7FA5400", Offset = "0x7FA4800", VA = "0x187FA5400", Slot = "8")]
	public COLCOEKKCIF<BalanceUpdateResponseDTO<PDHABEAHIOD>> LBKKCGPPNFD(Guid DIFAHGJHFEP, long LEJKIBGJJLI, GiftItemDTO JIKOCGPFMOG, OHDCEIDAPAG DEABODKOIAD = OHDCEIDAPAG.RecCenterTokens, [Optional] long? PPKAIAHMPMA, KPMNADCIPPD BKKLEKALCJB = KPMNADCIPPD.None)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7FA4CA0", Offset = "0x7FA40A0", VA = "0x187FA4CA0")]
	[AsyncStateMachine(typeof(DCFPOILAFBP))]
	private Task<AGMCELHPBEM<BalanceUpdateResponseDTO<PDHABEAHIOD>>> ICOGABLGEEJ(Guid DIFAHGJHFEP, long LEJKIBGJJLI, GiftItemDTO JIKOCGPFMOG, OHDCEIDAPAG DEABODKOIAD = OHDCEIDAPAG.RecCenterTokens, [Optional] long? PPKAIAHMPMA, KPMNADCIPPD BKKLEKALCJB = KPMNADCIPPD.None)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7FA5660", Offset = "0x7FA4A60", VA = "0x187FA5660", Slot = "9")]
	public COLCOEKKCIF<BalanceUpdateResponseDTO<PDHABEAHIOD>> LEELJFOFBAM(KPMNADCIPPD BKKLEKALCJB, OHDCEIDAPAG DEABODKOIAD, int LKOAJMNGMNC, long LEJKIBGJJLI, long? PPKAIAHMPMA, int BAOAOHHBBCO, bool KPLNNPBFHKE = false, bool GBNCAPHAKJC = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7FA4F10", Offset = "0x7FA4310", VA = "0x187FA4F10", Slot = "10")]
	public COLCOEKKCIF<BalanceUpdateResponseDTO<PDHABEAHIOD>> LAOCKMNIAAA(KPMNADCIPPD BKKLEKALCJB, OHDCEIDAPAG DEABODKOIAD, int LKOAJMNGMNC, long LEJKIBGJJLI, long? PPKAIAHMPMA, IReadOnlyCollection<int> OHMOFONDLEN, string EIGJGBPHOMK, bool JNMOEGKBLOJ, FNEFDFLLFBO EJJJICAGKBM, int BAOAOHHBBCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7FA4270", Offset = "0x7FA3670", VA = "0x187FA4270", Slot = "11")]
	public COLCOEKKCIF<BalanceUpdateResponseDTO<PDHABEAHIOD>> GKHOAHDFCHL(KPMNADCIPPD BKKLEKALCJB, OHDCEIDAPAG DEABODKOIAD, IReadOnlyList<int> DACHFNKEEPD, IReadOnlyList<long> MGFFBIGAIOP, long? PPKAIAHMPMA, int JIMKKBLBBGE, string EIGJGBPHOMK, bool JNMOEGKBLOJ, FNEFDFLLFBO EJJJICAGKBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7FA58C0", Offset = "0x7FA4CC0", VA = "0x187FA58C0")]
	[AsyncStateMachine(typeof(CELNHMEKDIB))]
	private Task<List<KPJMPHJIKLH>> LJPMJKIKOGB(IReadOnlyList<Guid> DKCCLAHCPGM, CancellationToken BLABAMPAGAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7FA4990", Offset = "0x7FA3D90", VA = "0x187FA4990")]
	private void HIOCBPOPDBF(BalanceUpdateResponseDTO<PDHABEAHIOD> FOICCHKEEHL, bool CPHLELANAFM, bool GBNCAPHAKJC, bool KPLNNPBFHKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7FA2D10", Offset = "0x7FA2110", VA = "0x187FA2D10")]
	private void AKMLHMHLBNI(DHHLNLKMNOA DJFHGKPBFKB, bool LNIHKOGHOOL, bool LJKHJBCMGLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7FA5EA0", Offset = "0x7FA52A0", VA = "0x187FA5EA0")]
	[AsyncStateMachine(typeof(DHNDPNBHMIK))]
	private Task NMFNGGJMDJL(List<HECAOJHPFAL> IJIKHLNPMDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7FA3970", Offset = "0x7FA2D70", VA = "0x187FA3970")]
	[CompilerGenerated]
	private void DDKOJKOJBBE(BalanceUpdateResponseDTO<PDHABEAHIOD> KGODHHBLJOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7FA3970", Offset = "0x7FA2D70", VA = "0x187FA3970")]
	[CompilerGenerated]
	private void NGCEDCMBGOA(BalanceUpdateResponseDTO<PDHABEAHIOD> KGODHHBLJOE)
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class DAKAGJPPDPP
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
	public DAKAGJPPDPP()
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
