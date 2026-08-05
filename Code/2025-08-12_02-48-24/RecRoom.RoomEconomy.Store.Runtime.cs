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
		[Cpp2IlInjected.Address(RVA = "0x8CE4420", Offset = "0x8CE2A20", VA = "0x188CE4420", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2960290", Offset = "0x295E890", VA = "0x182960290")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class AJEFMBAIHGM : BKJNAENGDNC, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private struct CKPCIKEFKON : IAsyncStateMachine
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
		public AJEFMBAIHGM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8CDE880", Offset = "0x8CDCE80", VA = "0x188CDE880", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8CDEB80", Offset = "0x8CDD180", VA = "0x188CDEB80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private struct EAIFGDKGKOI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public AsyncTaskMethodBuilder<NMBBKLCKGLJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public AJEFMBAIHGM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public Guid customAvatarItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private TaskAwaiter<NMBBKLCKGLJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8CDEBE0", Offset = "0x8CDD1E0", VA = "0x188CDEBE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8CDEEB0", Offset = "0x8CDD4B0", VA = "0x188CDEEB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct MNFLPECIKMG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public AsyncTaskMethodBuilder<List<NOCNMFAMICC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public AJEFMBAIHGM <>4__this;

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
		private List<NOCNMFAMICC> <results>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private TaskAwaiter<List<LJCEPDOBDJL>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8CE0490", Offset = "0x8CDEA90", VA = "0x188CE0490", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8CE0C40", Offset = "0x8CDF240", VA = "0x188CE0C40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct MLJOJMLCPDE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public AsyncTaskMethodBuilder<List<NOCNMFAMICC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public AJEFMBAIHGM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public IReadOnlyList<MLCFDBKEEGL> unifiedItemIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public bool convertCustomAvatarItemsToPurchasableGiftDrops;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private Task <watchStorefrontTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private List<LJCEPDOBDJL> <customAvatarItems>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private List<NOCNMFAMICC> <storeItemsInInitialOrder>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private TaskAwaiter<List<LJCEPDOBDJL>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8CDF980", Offset = "0x8CDDF80", VA = "0x188CDF980", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8CE0420", Offset = "0x8CDEA20", VA = "0x188CE0420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct OJBPIDJPFKP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public AsyncTaskMethodBuilder<List<LJCEPDOBDJL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public List<LJCEPDOBDJL> customAvatarItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public AJEFMBAIHGM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8CE12E0", Offset = "0x8CDF8E0", VA = "0x188CE12E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8CE17D0", Offset = "0x8CDFDD0", VA = "0x188CE17D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class AJODKPAAMHF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public MLCFDBKEEGL id;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public AJODKPAAMHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8CDE7F0", Offset = "0x8CDCDF0", VA = "0x188CDE7F0")]
		internal bool CNFMECAGEAL(BFPIOAANHKC x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8CDE730", Offset = "0x8CDCD30", VA = "0x188CDE730")]
		internal bool BFDHJOKAMIE(NOCNMFAMICC x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class BJICEFBAFFN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public string itemFriendlyName;

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public BJICEFBAFFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8CDE830", Offset = "0x8CDCE30", VA = "0x188CDE830")]
		internal object MFPDAJNFKBN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class GEEFMNOCCNF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AJEFMBAIHGM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public GiftItemDTO gift;

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public GEEFMNOCCNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8CDEF60", Offset = "0x8CDD560", VA = "0x188CDEF60")]
		internal void DHNLCFELLDB(BalanceUpdateResponseDTO<LOOOEICNEDE> result)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct GEHDOMGIAHH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public AsyncTaskMethodBuilder<FPEHGGCGONO<BalanceUpdateResponseDTO<LOOOEICNEDE>>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public AJEFMBAIHGM <>4__this;

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
		public LKJBAEHKLIH storefrontType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public PGOJGHPEBGE currencyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private TaskAwaiter<NMBBKLCKGLJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TaskAwaiter<FPEHGGCGONO<BalanceUpdateResponseDTO<LOOOEICNEDE>>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8CDEFA0", Offset = "0x8CDD5A0", VA = "0x188CDEFA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8CDF4A0", Offset = "0x8CDDAA0", VA = "0x188CDF4A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class FLBDFOHPMFL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public AJEFMBAIHGM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public bool handleShowGiftPackage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public bool shouldConsumeGiftBoxImmediately;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public FLBDFOHPMFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8CDEF20", Offset = "0x8CDD520", VA = "0x188CDEF20")]
		internal void NPBJKNCEPMH(BalanceUpdateResponseDTO<LOOOEICNEDE> result)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class NICEMNNKDJI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public AJEFMBAIHGM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public GiftItemDTO gift;

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public NICEMNNKDJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8CE0CB0", Offset = "0x8CDF2B0", VA = "0x188CE0CB0")]
		internal void MJNLNGLDENI(BalanceUpdateResponseDTO<LOOOEICNEDE> result)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct HKKOMHAPCOJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public AsyncTaskMethodBuilder<List<NMBBKLCKGLJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public IReadOnlyList<Guid> itemIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public AJEFMBAIHGM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private TaskAwaiter<List<GFKBGHMDNDB>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8CDF510", Offset = "0x8CDDB10", VA = "0x188CDF510", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8CDF910", Offset = "0x8CDDF10", VA = "0x188CDF910", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct NPOLACCFPNO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public List<NOCNMFAMICC> storeItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public AJEFMBAIHGM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private int <attemptNumber>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8CE0CF0", Offset = "0x8CDF2F0", VA = "0x188CE0CF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8CE1280", Offset = "0x8CDF880", VA = "0x188CE1280", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly AHDPAODPDCP<Guid, NMBBKLCKGLJ> HAJLIJCDBJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private KGNHCANDILK AFPNEGGDGPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private PCJLGBCHNLC BBPMMEPBPFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private AHFAHDPONGL DNGKJLPAODJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private BLOINGLAABO OBCIJONCIKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private NMPCJCHOINP FFPPHACFLKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private BDAGHMMFHLO ANHHCBNKCPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal NOICILHGILI<Guid, NMBBKLCKGLJ> HLCOAENIDPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private bool OPDBEINFGEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private Task OCJBFBJPEBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private CancellationTokenSource BIIOAJKHCNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private List<BFPIOAANHKC> IEAPIFCOAJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private JKOJFAAODCF? AFGOEFDGINC;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static BKJNAENGDNC MDCEPNGNCGO;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private List<BFPIOAANHKC> IJBIDDAOIBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8CDC360", Offset = "0x8CDA960", VA = "0x188CDC360")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private JKOJFAAODCF HIFKMPKAICD
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8CDBE40", Offset = "0x8CDA440", VA = "0x188CDBE40")]
		get
		{
			return default(JKOJFAAODCF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static BKJNAENGDNC DOBPPELCKJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8CDD3D0", Offset = "0x8CDB9D0", VA = "0x188CDD3D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x8CDDC00", Offset = "0x8CDC200", VA = "0x188CDDC00")]
	private List<BFPIOAANHKC> ODJNIGOGENL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x8CDA9C0", Offset = "0x8CD8FC0", VA = "0x188CDA9C0")]
	[LAFCEDCMNGK.LDGLOLCMPLF.AALIAIEKGHF]
	internal static void AAICCAKCFCJ(CFPMHDJNIAH LOLOEONEEKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x8CDE2B0", Offset = "0x8CDC8B0", VA = "0x188CDE2B0")]
	[RecRoom.NoEngine.Common.Preserve]
	public AJEFMBAIHGM([OEKMEJFDAAI(null)] AHFAHDPONGL DNGKJLPAODJ, [OEKMEJFDAAI(null)] KGNHCANDILK AFPNEGGDGPJ, [OEKMEJFDAAI(null)] PCJLGBCHNLC BBPMMEPBPFM, [OEKMEJFDAAI(null)] BLOINGLAABO OBCIJONCIKA, [OEKMEJFDAAI(null)] NMPCJCHOINP FFPPHACFLKB, [OEKMEJFDAAI(null)] BDAGHMMFHLO ANHHCBNKCPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x8CDC640", Offset = "0x8CDAC40", VA = "0x188CDC640", Slot = "1")]
	~AJEFMBAIHGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x8CDBDD0", Offset = "0x8CDA3D0", VA = "0x188CDBDD0", Slot = "13")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x8CDDD70", Offset = "0x8CDC370", VA = "0x188CDDD70")]
	[AsyncStateMachine(typeof(CKPCIKEFKON))]
	private Task OGCKNKMFMJA(CancellationToken MEKNAIONNND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x8CDDAB0", Offset = "0x8CDC0B0", VA = "0x188CDDAB0")]
	public void NFHLDBJAKIB(Guid HFMNEOLFGJA, NMBBKLCKGLJ PIELOPOBKDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x8CDB8A0", Offset = "0x8CD9EA0", VA = "0x188CDB8A0", Slot = "14")]
	public void CCBGPIPODEM(NOCNMFAMICC BNNDDPIJNIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x8CDC050", Offset = "0x8CDA650", VA = "0x188CDC050", Slot = "4")]
	public void FABFMBHENGC(IEnumerable<NOCNMFAMICC> HJFMKAHIOGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x8CDC730", Offset = "0x8CDAD30", VA = "0x188CDC730", Slot = "15")]
	public NMBBKLCKGLJ HGAHANLNGDH(Guid MECFNLMOEBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x8CDC840", Offset = "0x8CDAE40", VA = "0x188CDC840", Slot = "5")]
	public NMBBKLCKGLJ HGAHANLNGDH(NOCNMFAMICC BNNDDPIJNIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x8CDD2C0", Offset = "0x8CDB8C0", VA = "0x188CDD2C0", Slot = "16")]
	[AsyncStateMachine(typeof(EAIFGDKGKOI))]
	public Task<NMBBKLCKGLJ> IHGNNCONGPF(Guid MECFNLMOEBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x8CDC200", Offset = "0x8CDA800", VA = "0x188CDC200", Slot = "7")]
	[AsyncStateMachine(typeof(MNFLPECIKMG))]
	public Task<List<NOCNMFAMICC>> FLAJKGMHALF(string BGKJDEEJDFG, bool? PIMBDEKFBIL, bool? EEFLEPJFDEE, IEnumerable<int> JHIGCDIDGBJ, bool JOLHAIANLGD, bool EIMDMHBODNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x8CDDE60", Offset = "0x8CDC460", VA = "0x188CDDE60", Slot = "6")]
	public NOCNMFAMICC OIGHIEIGDGD(MLCFDBKEEGL HFMNEOLFGJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x8CDC500", Offset = "0x8CDAB00", VA = "0x188CDC500", Slot = "8")]
	[AsyncStateMachine(typeof(MLJOJMLCPDE))]
	public Task<List<NOCNMFAMICC>> FMPLLOICNKL(IReadOnlyList<MLCFDBKEEGL> NJAKCMIJEDA, bool CPKOLHDFEJA = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x8CDD4D0", Offset = "0x8CDBAD0", VA = "0x188CDD4D0")]
	[AsyncStateMachine(typeof(OJBPIDJPFKP))]
	private Task<List<LJCEPDOBDJL>> KPGAKJOFMAI(List<LJCEPDOBDJL> HAADBCFMFEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x8CDB280", Offset = "0x8CD9880", VA = "0x188CDB280")]
	private List<NOCNMFAMICC> BOLIGOFKDFK(IReadOnlyList<MLCFDBKEEGL> ONDDMCBIHKE, IReadOnlyList<BFPIOAANHKC> CCAPHKFDLBE, IReadOnlyList<NOCNMFAMICC> HAADBCFMFEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x8CDD6E0", Offset = "0x8CDBCE0", VA = "0x188CDD6E0", Slot = "9")]
	public LDNIFFJFEMD<BalanceUpdateResponseDTO<LOOOEICNEDE>> MBLABNAJBGC(Guid MECFNLMOEBM, long AAAJLJAAJIM, GiftItemDTO ANAJMBOIHMA, PGOJGHPEBGE ECAHMHDPJME = PGOJGHPEBGE.RecCenterTokens, [Optional] long? NEOLJBOHKDF, LKJBAEHKLIH KPDCODBGJCJ = LKJBAEHKLIH.None)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x8CDE150", Offset = "0x8CDC750", VA = "0x188CDE150")]
	[AsyncStateMachine(typeof(GEHDOMGIAHH))]
	private Task<FPEHGGCGONO<BalanceUpdateResponseDTO<LOOOEICNEDE>>> PHHGBFMEPIB(Guid MECFNLMOEBM, long AAAJLJAAJIM, GiftItemDTO ANAJMBOIHMA, PGOJGHPEBGE ECAHMHDPJME = PGOJGHPEBGE.RecCenterTokens, [Optional] long? NEOLJBOHKDF, LKJBAEHKLIH KPDCODBGJCJ = LKJBAEHKLIH.None)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x8CDBAE0", Offset = "0x8CDA0E0", VA = "0x188CDBAE0", Slot = "10")]
	public LDNIFFJFEMD<BalanceUpdateResponseDTO<LOOOEICNEDE>> CNIOMJAGJPO(LKJBAEHKLIH KPDCODBGJCJ, PGOJGHPEBGE ECAHMHDPJME, int IDALAIEKKKK, long AAAJLJAAJIM, long? NEOLJBOHKDF, int PBDPLHCCLON, bool NPLNIDNJJBJ = false, bool ENOMENGDDHA = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x8CDCD60", Offset = "0x8CDB360", VA = "0x188CDCD60", Slot = "11")]
	public LDNIFFJFEMD<BalanceUpdateResponseDTO<LOOOEICNEDE>> HKEENAKOJNE(LKJBAEHKLIH KPDCODBGJCJ, PGOJGHPEBGE ECAHMHDPJME, int IDALAIEKKKK, long AAAJLJAAJIM, long? NEOLJBOHKDF, IReadOnlyCollection<int> EDFHACLBGAF, string IFEHDCDCFPK, bool CHAIBEPCOMH, LLODCHIGJPE NIFMMFBFCAM, int PBDPLHCCLON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x8CDAA60", Offset = "0x8CD9060", VA = "0x188CDAA60", Slot = "12")]
	public LDNIFFJFEMD<BalanceUpdateResponseDTO<LOOOEICNEDE>> AFMBJJKJJBP(LKJBAEHKLIH KPDCODBGJCJ, PGOJGHPEBGE ECAHMHDPJME, IReadOnlyList<MLCFDBKEEGL> PFMLHCLCMGF, IReadOnlyList<long> MPDLMPFNAJJ, [Optional] long? NEOLJBOHKDF, [Optional][CanBeNull] GiftItemDTO ANAJMBOIHMA, [Optional] Guid? JANBOFBHOBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x8CDD970", Offset = "0x8CDBF70", VA = "0x188CDD970")]
	[AsyncStateMachine(typeof(HKKOMHAPCOJ))]
	private Task<List<NMBBKLCKGLJ>> NBPDMMKNFFE(IReadOnlyList<Guid> PFMLHCLCMGF, CancellationToken MEKNAIONNND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x8CDCA50", Offset = "0x8CDB050", VA = "0x188CDCA50")]
	private void HGPLJEGAGOK(BalanceUpdateResponseDTO<LOOOEICNEDE> LEFGFCJGALC, bool IIGCBDEIMHG, bool ENOMENGDDHA, bool NPLNIDNJJBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x8CDB010", Offset = "0x8CD9610", VA = "0x188CDB010")]
	private void BGDHCIBLKEO(MGDIHOEKGMD JIPDMDLHHFM, bool HNDBBBKEDGB, bool HOHFJFJJCKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x8CDD5E0", Offset = "0x8CDBBE0", VA = "0x188CDD5E0")]
	[AsyncStateMachine(typeof(NPOLACCFPNO))]
	private Task LODEANNMJCL(List<NOCNMFAMICC> HJFMKAHIOGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x8CDD940", Offset = "0x8CDBF40", VA = "0x188CDD940")]
	[CompilerGenerated]
	private void NAKMAOMHKBC(BalanceUpdateResponseDTO<LOOOEICNEDE> CENCPMGPALN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class PBGKOLKOHKK : CPOJNOIEGJA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly NMPCJCHOINP FJCCLACNHLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly AOJALDDEOBI GNJHIBBBECG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly IPKIIGDPKAO CBMGIICCLAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly DHAJJGEOODE AOIFPAKCIAG;

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x8CE2170", Offset = "0x8CE0770", VA = "0x188CE2170")]
	[LAFCEDCMNGK.LDGLOLCMPLF.AALIAIEKGHF]
	internal static void EBJPFNJLIPM(CFPMHDJNIAH LOLOEONEEKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x1101990", Offset = "0x10FFF90", VA = "0x181101990")]
	[RecRoom.NoEngine.Common.Preserve]
	public PBGKOLKOHKK([OEKMEJFDAAI(null)] NMPCJCHOINP FFPPHACFLKB, [OEKMEJFDAAI(null)] AOJALDDEOBI FMJGPDBOGAC, [OEKMEJFDAAI(null)] IPKIIGDPKAO HAADBCFMFEP, [OEKMEJFDAAI(null)] DHAJJGEOODE KCMCJPANLEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x8CE22B0", Offset = "0x8CE08B0", VA = "0x188CE22B0")]
	private bool JPKKNENCINF(GAMJIOCPOML JPAIBNMACGM, GAMJIOCPOML CNBAIILCHLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x8CE3300", Offset = "0x8CE1900", VA = "0x188CE3300", Slot = "5")]
	public IReadOnlyList<NOCNMFAMICC> JAGJLGDGOBG(GAMJIOCPOML JDALAPOBOMB, FEPPAFNANFB AGMOBCDONLO, IReadOnlyList<NOCNMFAMICC> HLOMEJLEMOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x8CE2450", Offset = "0x8CE0A50", VA = "0x188CE2450", Slot = "4")]
	public bool HAIEOCNBGCO(GAMJIOCPOML JDALAPOBOMB, FEPPAFNANFB AGMOBCDONLO, NOCNMFAMICC KGKOGFAMIIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x8CE31E0", Offset = "0x8CE17E0", VA = "0x188CE31E0")]
	private bool IHAFJGECBHN(GAMJIOCPOML JDALAPOBOMB, NOCNMFAMICC KGKOGFAMIIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x8CE18D0", Offset = "0x8CDFED0", VA = "0x188CE18D0")]
	private bool APFIHKANJJG(GAMJIOCPOML JDALAPOBOMB, NOCNMFAMICC KGKOGFAMIIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x8CE37D0", Offset = "0x8CE1DD0", VA = "0x188CE37D0")]
	private bool LHMNKMAKNCO(GAMJIOCPOML JDALAPOBOMB, NOCNMFAMICC KGKOGFAMIIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x8CE3AC0", Offset = "0x8CE20C0", VA = "0x188CE3AC0")]
	public bool MLNHMOGDIPL(NOCNMFAMICC BNNDDPIJNIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x8CE3A00", Offset = "0x8CE2000", VA = "0x188CE3A00")]
	public bool MLNHMOGDIPL(FKDLHHCMNMO JIHGHFEMEHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x8CE2060", Offset = "0x8CE0660", VA = "0x188CE2060")]
	private bool DNDANOBKBKH(Guid MECFNLMOEBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x8CE3680", Offset = "0x8CE1C80", VA = "0x188CE3680")]
	private bool KHPJIDHFBDB(GAMJIOCPOML JDALAPOBOMB, NOCNMFAMICC KGKOGFAMIIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x8CE4260", Offset = "0x8CE2860", VA = "0x188CE4260")]
	private bool PPAEBDGNNDJ(GAMJIOCPOML JDALAPOBOMB, NOCNMFAMICC KGKOGFAMIIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x8CE3D10", Offset = "0x8CE2310", VA = "0x188CE3D10")]
	private bool NFDFNDCHNDL(GAMJIOCPOML JDALAPOBOMB, NOCNMFAMICC KGKOGFAMIIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x8CE38D0", Offset = "0x8CE1ED0", VA = "0x188CE38D0")]
	private bool MINBOAANKEH(GAMJIOCPOML JDALAPOBOMB, NOCNMFAMICC KGKOGFAMIIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x8CE1DB0", Offset = "0x8CE03B0", VA = "0x188CE1DB0")]
	private bool CDDGIHNEBKL(GAMJIOCPOML JDALAPOBOMB, NOCNMFAMICC KGKOGFAMIIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x8CE2350", Offset = "0x8CE0950", VA = "0x188CE2350")]
	private bool FCGMDBOOIAM(GAMJIOCPOML JDALAPOBOMB, NOCNMFAMICC KGKOGFAMIIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x8CE1CD0", Offset = "0x8CE02D0", VA = "0x188CE1CD0")]
	private bool BLFKBLPBGHJ(GAMJIOCPOML JDALAPOBOMB, NOCNMFAMICC KGKOGFAMIIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x8CE23C0", Offset = "0x8CE09C0", VA = "0x188CE23C0")]
	private bool GBLNOLDHCNF(GAMJIOCPOML JDALAPOBOMB, NOCNMFAMICC KGKOGFAMIIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x8CE3120", Offset = "0x8CE1720", VA = "0x188CE3120")]
	private bool IBNPLLOABAJ(GAMJIOCPOML JDALAPOBOMB, NOCNMFAMICC KGKOGFAMIIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x8CE1C40", Offset = "0x8CE0240", VA = "0x188CE1C40")]
	private bool BGBPLFMOEBM(GAMJIOCPOML JDALAPOBOMB, NOCNMFAMICC KGKOGFAMIIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x8CE4040", Offset = "0x8CE2640", VA = "0x188CE4040")]
	private bool PAOIPHBAOBC(GAMJIOCPOML JDALAPOBOMB, NOCNMFAMICC KGKOGFAMIIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x8CE1F40", Offset = "0x8CE0540", VA = "0x188CE1F40")]
	private bool DCMAHFPBPMD(GAMJIOCPOML JDALAPOBOMB, NOCNMFAMICC KGKOGFAMIIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x8CE3270", Offset = "0x8CE1870", VA = "0x188CE3270")]
	private bool IJFGDFBNAGA(GAMJIOCPOML JDALAPOBOMB, NOCNMFAMICC KGKOGFAMIIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x8CE3740", Offset = "0x8CE1D40", VA = "0x188CE3740")]
	private bool KKKMPFKOIEO(GAMJIOCPOML JDALAPOBOMB, NOCNMFAMICC KGKOGFAMIIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x8CE3840", Offset = "0x8CE1E40", VA = "0x188CE3840")]
	private bool MHDOPLLJMLM(GAMJIOCPOML JDALAPOBOMB, NOCNMFAMICC KGKOGFAMIIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x8CE1FD0", Offset = "0x8CE05D0", VA = "0x188CE1FD0")]
	private bool DHLFHJJNFOA(GAMJIOCPOML JDALAPOBOMB, NOCNMFAMICC KGKOGFAMIIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x8CE36B0", Offset = "0x8CE1CB0", VA = "0x188CE36B0")]
	private bool KILBMCIOKCI(GAMJIOCPOML JDALAPOBOMB, NOCNMFAMICC KGKOGFAMIIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x8CE1EB0", Offset = "0x8CE04B0", VA = "0x188CE1EB0")]
	private bool CHEKMMEAFDJ(GAMJIOCPOML JDALAPOBOMB, NOCNMFAMICC KGKOGFAMIIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x8CE4140", Offset = "0x8CE2740", VA = "0x188CE4140")]
	private bool PJCLJJNKOEA(GAMJIOCPOML JDALAPOBOMB, NOCNMFAMICC KGKOGFAMIIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x8CE22B0", Offset = "0x8CE08B0", VA = "0x188CE22B0")]
	private bool EFHDHOOPHFN(FEPPAFNANFB JPAIBNMACGM, FEPPAFNANFB CNBAIILCHLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x8CE3D80", Offset = "0x8CE2380", VA = "0x188CE3D80")]
	private bool NIMPNIOPNHL(GAMJIOCPOML JDALAPOBOMB, FEPPAFNANFB AGMOBCDONLO, NOCNMFAMICC KGKOGFAMIIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x8CE35F0", Offset = "0x8CE1BF0", VA = "0x188CE35F0")]
	private bool JPGLFLCNLPC(FEPPAFNANFB AGMOBCDONLO, NOCNMFAMICC KGKOGFAMIIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x8CE20E0", Offset = "0x8CE06E0", VA = "0x188CE20E0")]
	private bool EALBGINHNEC(FEPPAFNANFB AGMOBCDONLO, NOCNMFAMICC KGKOGFAMIIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x8CE22C0", Offset = "0x8CE08C0", VA = "0x188CE22C0")]
	private bool ELHOFCFNEAK(FEPPAFNANFB AGMOBCDONLO, NOCNMFAMICC KGKOGFAMIIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x8CE3560", Offset = "0x8CE1B60", VA = "0x188CE3560")]
	private bool JJNFLCHFGBE(FEPPAFNANFB AGMOBCDONLO, NOCNMFAMICC KGKOGFAMIIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x8CE1840", Offset = "0x8CDFE40", VA = "0x188CE1840")]
	private bool AKBJIJNNNAL(FEPPAFNANFB AGMOBCDONLO, NOCNMFAMICC KGKOGFAMIIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x8CE3000", Offset = "0x8CE1600", VA = "0x188CE3000")]
	private bool HGBCLEKOPBM(FEPPAFNANFB AGMOBCDONLO, NOCNMFAMICC KGKOGFAMIIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x8CE1E20", Offset = "0x8CE0420", VA = "0x188CE1E20")]
	private bool CGHNMOPADDD(GAMJIOCPOML JDALAPOBOMB, NOCNMFAMICC KGKOGFAMIIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x8CE3940", Offset = "0x8CE1F40", VA = "0x188CE3940")]
	private bool MJCBLFJOMFJ(GAMJIOCPOML JDALAPOBOMB, NOCNMFAMICC KGKOGFAMIIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x8CE21E0", Offset = "0x8CE07E0", VA = "0x188CE21E0")]
	private bool EDGFIKFPMEL(GAMJIOCPOML JDALAPOBOMB, NOCNMFAMICC KGKOGFAMIIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x8CE41D0", Offset = "0x8CE27D0", VA = "0x188CE41D0")]
	private bool PKPDOPFDOJB(GAMJIOCPOML JDALAPOBOMB, NOCNMFAMICC KGKOGFAMIIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x8CE40D0", Offset = "0x8CE26D0", VA = "0x188CE40D0")]
	private bool PBOJBFIEBLL(GAMJIOCPOML JDALAPOBOMB, NOCNMFAMICC KGKOGFAMIIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x8CE3FB0", Offset = "0x8CE25B0", VA = "0x188CE3FB0")]
	private bool NMCOBAOPKOJ(GAMJIOCPOML JDALAPOBOMB, NOCNMFAMICC KGKOGFAMIIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x8CE3090", Offset = "0x8CE1690", VA = "0x188CE3090")]
	private bool HJENLEEDECM(GAMJIOCPOML JDALAPOBOMB, NOCNMFAMICC KGKOGFAMIIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x8CE1D40", Offset = "0x8CE0340", VA = "0x188CE1D40")]
	private bool CADFGNJOCBI(GAMJIOCPOML JDALAPOBOMB, NOCNMFAMICC KGKOGFAMIIC)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class CMLEPANJLDE
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public CMLEPANJLDE()
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
