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
		[Cpp2IlInjected.Address(RVA = "0x8B2AAD0", Offset = "0x8B29ED0", VA = "0x188B2AAD0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x291FE80", Offset = "0x291F280", VA = "0x18291FE80")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class OFKEEJGKGBK : OIBGNPAMNBK, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private struct CDGIDOBMKPA : IAsyncStateMachine
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
		public OFKEEJGKGBK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8B21540", Offset = "0x8B20940", VA = "0x188B21540", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8B21840", Offset = "0x8B20C40", VA = "0x188B21840", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private struct EFEKJJDNKPJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public AsyncTaskMethodBuilder<IMOLFKIAMFH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public OFKEEJGKGBK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public Guid customAvatarItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private TaskAwaiter<IMOLFKIAMFH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8B226A0", Offset = "0x8B21AA0", VA = "0x188B226A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8B22970", Offset = "0x8B21D70", VA = "0x188B22970", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct CLMNIGECKPC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public AsyncTaskMethodBuilder<List<DKGDNEFFHIH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public OFKEEJGKGBK <>4__this;

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
		private List<DKGDNEFFHIH> <results>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private TaskAwaiter<List<EMNLKCIAKAO>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8B218A0", Offset = "0x8B20CA0", VA = "0x188B218A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8B22040", Offset = "0x8B21440", VA = "0x188B22040", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct NMEHCEJFNCG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public AsyncTaskMethodBuilder<List<DKGDNEFFHIH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public OFKEEJGKGBK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public IReadOnlyList<JNLOJNJGNOF> unifiedItemIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public bool convertCustomAvatarItemsToPurchasableGiftDrops;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private Task <watchStorefrontTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private List<EMNLKCIAKAO> <customAvatarItems>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private List<DKGDNEFFHIH> <storeItemsInInitialOrder>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private TaskAwaiter<List<EMNLKCIAKAO>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8B25B10", Offset = "0x8B24F10", VA = "0x188B25B10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8B265A0", Offset = "0x8B259A0", VA = "0x188B265A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct GODHNEKNLKP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public AsyncTaskMethodBuilder<List<EMNLKCIAKAO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public List<EMNLKCIAKAO> customAvatarItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public OFKEEJGKGBK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8B22B60", Offset = "0x8B21F60", VA = "0x188B22B60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8B23050", Offset = "0x8B22450", VA = "0x188B23050", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class GNNJJNFHCMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public JNLOJNJGNOF id;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public GNNJJNFHCMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8B22A60", Offset = "0x8B21E60", VA = "0x188B22A60")]
		internal bool MHMHJOPIFCK(EDABPFABCFN x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8B22AA0", Offset = "0x8B21EA0", VA = "0x188B22AA0")]
		internal bool OBDLJAGEHEO(DKGDNEFFHIH x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class PNIGBDCEOMF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public string itemFriendlyName;

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public PNIGBDCEOMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8B2A8E0", Offset = "0x8B29CE0", VA = "0x188B2A8E0")]
		internal object CFLOMKJAOKH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class JBOLFKGPNOO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public OFKEEJGKGBK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public GiftItemDTO gift;

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public JBOLFKGPNOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8B25AD0", Offset = "0x8B24ED0", VA = "0x188B25AD0")]
		internal void IINKNNCDIKG(BalanceUpdateResponseDTO<FGHKIOLBNJJ> result)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct BFPIBOHLFEH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public AsyncTaskMethodBuilder<JMGMKEEJIFI<BalanceUpdateResponseDTO<FGHKIOLBNJJ>>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public OFKEEJGKGBK <>4__this;

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
		public BKFNKFFICGC storefrontType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public LPMAKBILGPG currencyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private TaskAwaiter<IMOLFKIAMFH> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TaskAwaiter<JMGMKEEJIFI<BalanceUpdateResponseDTO<FGHKIOLBNJJ>>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8B20FD0", Offset = "0x8B203D0", VA = "0x188B20FD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8B214D0", Offset = "0x8B208D0", VA = "0x188B214D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class GCGOAGGDFJG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public OFKEEJGKGBK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public bool handleShowGiftPackage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public bool shouldConsumeGiftBoxImmediately;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public GCGOAGGDFJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8B22A20", Offset = "0x8B21E20", VA = "0x188B22A20")]
		internal void ABFANJIEGNF(BalanceUpdateResponseDTO<FGHKIOLBNJJ> result)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class FKMKCOEFPEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public OFKEEJGKGBK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public GiftItemDTO gift;

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public FKMKCOEFPEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8B229E0", Offset = "0x8B21DE0", VA = "0x188B229E0")]
		internal void PDOMBLJCFNG(BalanceUpdateResponseDTO<FGHKIOLBNJJ> result)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct PEEHDHHBAOB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public AsyncTaskMethodBuilder<List<IMOLFKIAMFH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public IReadOnlyList<Guid> itemIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public OFKEEJGKGBK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private TaskAwaiter<List<NAJMNCODMAO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8B2A470", Offset = "0x8B29870", VA = "0x188B2A470", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8B2A870", Offset = "0x8B29C70", VA = "0x188B2A870", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct EAGOGMNBHHG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public List<DKGDNEFFHIH> storeItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public OFKEEJGKGBK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private int <attemptNumber>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8B220B0", Offset = "0x8B214B0", VA = "0x188B220B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8B22640", Offset = "0x8B21A40", VA = "0x188B22640", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly PKOACAFGIPI<Guid, IMOLFKIAMFH> FBDNPFAACIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private GGPAGPBMOHM IPKGHAJGBDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private FFKHICJBDKL NHJMCCLMAOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private PJOPJNFKKAJ OLENCDNPPNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private IKAEMODMHHC NLFOGHLMNJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private IDJMDLKIOFJ PHFMCLGCHFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private FEGLFIFLMGC JNHBEKDBGJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal OGIIDNDKACI<Guid, IMOLFKIAMFH> BAOEPJDECPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private bool GJNOCMLAONB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private Task HLAOLEKJALA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private CancellationTokenSource EGGMNLAAENP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private List<EDABPFABCFN> BGIMJOHHCIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private DDDAONPIBHA? BMGPPMBAGIF;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static OIBGNPAMNBK OMAABCNJOHH;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private List<EDABPFABCFN> LKEBLBDOBJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8B26B10", Offset = "0x8B25F10", VA = "0x188B26B10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private DDDAONPIBHA OCKPEHGFGAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8B26750", Offset = "0x8B25B50", VA = "0x188B26750")]
		get
		{
			return default(DDDAONPIBHA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static OIBGNPAMNBK NKAKNKMIPPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8B26CB0", Offset = "0x8B260B0", VA = "0x188B26CB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x8B28970", Offset = "0x8B27D70", VA = "0x188B28970")]
	private List<EDABPFABCFN> JLGHHGFKDCG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x8B26960", Offset = "0x8B25D60", VA = "0x188B26960")]
	[MKODAOGKIAA.LAFEFHEHFHN.PPBCBBDKDNB]
	internal static void CBKEIPHIAFB(JFAGCPCLAAF MNCIANLLPKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x8B29FF0", Offset = "0x8B293F0", VA = "0x188B29FF0")]
	[RecRoom.NoEngine.Common.Preserve]
	public OFKEEJGKGBK([PKIHAALFADL(null)] PJOPJNFKKAJ OLENCDNPPNC, [PKIHAALFADL(null)] GGPAGPBMOHM IPKGHAJGBDL, [PKIHAALFADL(null)] FFKHICJBDKL NHJMCCLMAOD, [PKIHAALFADL(null)] IKAEMODMHHC NLFOGHLMNJE, [PKIHAALFADL(null)] IDJMDLKIOFJ PHFMCLGCHFB, [PKIHAALFADL(null)] FEGLFIFLMGC JNHBEKDBGJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x8B28140", Offset = "0x8B27540", VA = "0x188B28140", Slot = "1")]
	~OFKEEJGKGBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x8B275E0", Offset = "0x8B269E0", VA = "0x188B275E0", Slot = "13")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x8B28D40", Offset = "0x8B28140", VA = "0x188B28D40")]
	[AsyncStateMachine(typeof(CDGIDOBMKPA))]
	private Task LKIILMJJEJN(CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x8B29B80", Offset = "0x8B28F80", VA = "0x188B29B80")]
	public void PEHLHPDBPCH(Guid OGNDGGFKAJO, IMOLFKIAMFH IGNLDBAJLCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x8B27650", Offset = "0x8B26A50", VA = "0x188B27650", Slot = "14")]
	public void EENDKCHNEDK(DKGDNEFFHIH JKIDEMPMEIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x8B287C0", Offset = "0x8B27BC0", VA = "0x188B287C0", Slot = "4")]
	public void JCCBCFEBCAE(IEnumerable<DKGDNEFFHIH> HLNKPOCMMJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x8B29140", Offset = "0x8B28540", VA = "0x188B29140", Slot = "15")]
	public IMOLFKIAMFH MNOEIKAHCGD(Guid NPMPEIAPAOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x8B29250", Offset = "0x8B28650", VA = "0x188B29250", Slot = "5")]
	public IMOLFKIAMFH MNOEIKAHCGD(DKGDNEFFHIH JKIDEMPMEIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x8B28230", Offset = "0x8B27630", VA = "0x188B28230", Slot = "16")]
	[AsyncStateMachine(typeof(EFEKJJDNKPJ))]
	public Task<IMOLFKIAMFH> GLFDODHBAGL(Guid NPMPEIAPAOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x8B27E80", Offset = "0x8B27280", VA = "0x188B27E80", Slot = "7")]
	[AsyncStateMachine(typeof(CLMNIGECKPC))]
	public Task<List<DKGDNEFFHIH>> FJBGEADPOOL(string NMEHEEEIEIJ, bool? KONLHCLNPDK, bool? ADMGMOAGCLB, IEnumerable<int> KAHBNLCAIOH, bool BCJFKIHEDOD, bool CCCOOKAGENB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x8B29D00", Offset = "0x8B29100", VA = "0x188B29D00", Slot = "6")]
	public DKGDNEFFHIH PNKOFAODJBA(JNLOJNJGNOF OGNDGGFKAJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x8B26610", Offset = "0x8B25A10", VA = "0x188B26610", Slot = "8")]
	[AsyncStateMachine(typeof(NMEHCEJFNCG))]
	public Task<List<DKGDNEFFHIH>> AGBEGMFJDHM(IReadOnlyList<JNLOJNJGNOF> GFFAHKOOPAL, bool MNKCDKFJJOE = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x8B26A00", Offset = "0x8B25E00", VA = "0x188B26A00")]
	[AsyncStateMachine(typeof(GODHNEKNLKP))]
	private Task<List<EMNLKCIAKAO>> CCBOCLNBNHL(List<EMNLKCIAKAO> HPMPLFMFCHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x8B29460", Offset = "0x8B28860", VA = "0x188B29460")]
	private List<DKGDNEFFHIH> NPPJFINGEBI(IReadOnlyList<JNLOJNJGNOF> ODDAMNHIHDK, IReadOnlyList<EDABPFABCFN> BGFGMBFGBPM, IReadOnlyList<DKGDNEFFHIH> HPMPLFMFCHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x8B28AE0", Offset = "0x8B27EE0", VA = "0x188B28AE0", Slot = "9")]
	public FHMCAMOMJOP<BalanceUpdateResponseDTO<FGHKIOLBNJJ>> LIDFOLOMJGJ(Guid NPMPEIAPAOF, long BIHCLINBKCD, GiftItemDTO EJHLOODJAPA, LPMAKBILGPG JDIPBOIIMNA = LPMAKBILGPG.RecCenterTokens, [Optional] long? HAJBKPPPIPP, BKFNKFFICGC DAFHFGCBPCL = BKFNKFFICGC.None)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x8B27FE0", Offset = "0x8B273E0", VA = "0x188B27FE0")]
	[AsyncStateMachine(typeof(BFPIBOHLFEH))]
	private Task<JMGMKEEJIFI<BalanceUpdateResponseDTO<FGHKIOLBNJJ>>> FMJABMBAFNN(Guid NPMPEIAPAOF, long BIHCLINBKCD, GiftItemDTO EJHLOODJAPA, LPMAKBILGPG JDIPBOIIMNA = LPMAKBILGPG.RecCenterTokens, [Optional] long? HAJBKPPPIPP, BKFNKFFICGC DAFHFGCBPCL = BKFNKFFICGC.None)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x8B28340", Offset = "0x8B27740", VA = "0x188B28340", Slot = "10")]
	public FHMCAMOMJOP<BalanceUpdateResponseDTO<FGHKIOLBNJJ>> HDAHFFCIFCC(BKFNKFFICGC DAFHFGCBPCL, LPMAKBILGPG JDIPBOIIMNA, int BJMOAIPPFNC, long BIHCLINBKCD, long? HAJBKPPPIPP, int ECMAAKHGBMG, bool GIGPMLILJMO = false, bool AONDMDBIHPO = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x8B26DB0", Offset = "0x8B261B0", VA = "0x188B26DB0", Slot = "11")]
	public FHMCAMOMJOP<BalanceUpdateResponseDTO<FGHKIOLBNJJ>> DFOOGCFLENH(BKFNKFFICGC DAFHFGCBPCL, LPMAKBILGPG JDIPBOIIMNA, int BJMOAIPPFNC, long BIHCLINBKCD, long? HAJBKPPPIPP, IReadOnlyCollection<int> BNIEEBOJDAC, string AFDNIPHJHMO, bool LDFBODCNNAN, PGIDFLAKNGN HJAIGIFKEID, int ECMAAKHGBMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x8B27890", Offset = "0x8B26C90", VA = "0x188B27890", Slot = "12")]
	public FHMCAMOMJOP<BalanceUpdateResponseDTO<FGHKIOLBNJJ>> EHNIOJBGCLA(BKFNKFFICGC DAFHFGCBPCL, LPMAKBILGPG JDIPBOIIMNA, IReadOnlyList<JNLOJNJGNOF> CKDMKJCNDMH, IReadOnlyList<long> FBNJMHBBFMG, [Optional] long? HAJBKPPPIPP, [Optional][CanBeNull] GiftItemDTO EJHLOODJAPA, [Optional] Guid? GKOINLEHOIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x8B28680", Offset = "0x8B27A80", VA = "0x188B28680")]
	[AsyncStateMachine(typeof(PEEHDHHBAOB))]
	private Task<List<IMOLFKIAMFH>> JBPICADBPJC(IReadOnlyList<Guid> CKDMKJCNDMH, CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x8B28E30", Offset = "0x8B28230", VA = "0x188B28E30")]
	private void MCMBLPJOGNB(BalanceUpdateResponseDTO<FGHKIOLBNJJ> HGHNDNAANCF, bool ODGAFBJKAOD, bool AONDMDBIHPO, bool GIGPMLILJMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x8B27380", Offset = "0x8B26780", VA = "0x188B27380")]
	private void DJNHFFAJIAL(KGCPCHPAGKE FHMBFLANLEN, bool KJFPJBNAOIF, bool AODEMDOEKNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x8B29A80", Offset = "0x8B28E80", VA = "0x188B29A80")]
	[AsyncStateMachine(typeof(EAGOGMNBHHG))]
	private Task OPAPHJFPLFK(List<DKGDNEFFHIH> HLNKPOCMMJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x8B29CD0", Offset = "0x8B290D0", VA = "0x188B29CD0")]
	[CompilerGenerated]
	private void PGACLLMLGJH(BalanceUpdateResponseDTO<FGHKIOLBNJJ> HJBCDFKDKBA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class IKOLFIMFBDG : BJAEFGAMILJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly IDJMDLKIOFJ CFNDNMDFLCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly AKJEBEPKLNK FEGCDIMNCIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly BNPFAMILPHF ACPEIEGEJIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly BJEKCCPLCKI CIJLDECFCGD;

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x8B237B0", Offset = "0x8B22BB0", VA = "0x188B237B0")]
	[MKODAOGKIAA.LAFEFHEHFHN.PPBCBBDKDNB]
	internal static void EMILKHFAJPJ(JFAGCPCLAAF MNCIANLLPKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x10BB460", Offset = "0x10BA860", VA = "0x1810BB460")]
	[RecRoom.NoEngine.Common.Preserve]
	public IKOLFIMFBDG([PKIHAALFADL(null)] IDJMDLKIOFJ PHFMCLGCHFB, [PKIHAALFADL(null)] AKJEBEPKLNK OLKAKEHAOAO, [PKIHAALFADL(null)] BNPFAMILPHF HPMPLFMFCHD, [PKIHAALFADL(null)] BJEKCCPLCKI CMMNKNCPEGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x8B23820", Offset = "0x8B22C20", VA = "0x188B23820")]
	private bool FACAFEMLJEO(KCPAKJKPIDH FBHILNPOIJK, KCPAKJKPIDH HALFAEFPNJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x8B257E0", Offset = "0x8B24BE0", VA = "0x188B257E0", Slot = "5")]
	public IReadOnlyList<DKGDNEFFHIH> PLBEMNHMJLL(KCPAKJKPIDH GDOCDNNCPKP, OCMMEBNEIHP HCPJBNCDEGH, IReadOnlyList<DKGDNEFFHIH> PHCFLGCBHJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x8B23F70", Offset = "0x8B23370", VA = "0x188B23F70", Slot = "4")]
	public bool IPEGJDEBCNA(KCPAKJKPIDH GDOCDNNCPKP, OCMMEBNEIHP HCPJBNCDEGH, DKGDNEFFHIH GBDPBDHPLOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x8B24CE0", Offset = "0x8B240E0", VA = "0x188B24CE0")]
	private bool JLDJNFAONDB(KCPAKJKPIDH GDOCDNNCPKP, DKGDNEFFHIH GBDPBDHPLOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x8B23A10", Offset = "0x8B22E10", VA = "0x188B23A10")]
	private bool HHKGCADNGBN(KCPAKJKPIDH GDOCDNNCPKP, DKGDNEFFHIH GBDPBDHPLOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x8B23D60", Offset = "0x8B23160", VA = "0x188B23D60")]
	private bool HMBCNHIMMCM(KCPAKJKPIDH GDOCDNNCPKP, DKGDNEFFHIH GBDPBDHPLOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x8B25000", Offset = "0x8B24400", VA = "0x188B25000")]
	public bool MBGDNLLCKDF(DKGDNEFFHIH JKIDEMPMEIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x8B25250", Offset = "0x8B24650", VA = "0x188B25250")]
	public bool MBGDNLLCKDF(PPPMIEAGFIE ENLCIHKPJIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x8B23E60", Offset = "0x8B23260", VA = "0x188B23E60")]
	private bool IEFPMLCLNDI(Guid NPMPEIAPAOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x8B25310", Offset = "0x8B24710", VA = "0x188B25310")]
	private bool MFOHNFGCNAK(KCPAKJKPIDH GDOCDNNCPKP, DKGDNEFFHIH GBDPBDHPLOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x8B24B10", Offset = "0x8B23F10", VA = "0x188B24B10")]
	private bool JCDGEJPHBKA(KCPAKJKPIDH GDOCDNNCPKP, DKGDNEFFHIH GBDPBDHPLOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x8B236B0", Offset = "0x8B22AB0", VA = "0x188B236B0")]
	private bool EDKNAEGKDLJ(KCPAKJKPIDH GDOCDNNCPKP, DKGDNEFFHIH GBDPBDHPLOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x8B25650", Offset = "0x8B24A50", VA = "0x188B25650")]
	private bool OELMIJAFJDN(KCPAKJKPIDH GDOCDNNCPKP, DKGDNEFFHIH GBDPBDHPLOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x8B23150", Offset = "0x8B22550", VA = "0x188B23150")]
	private bool BFJIHFLFLEP(KCPAKJKPIDH GDOCDNNCPKP, DKGDNEFFHIH GBDPBDHPLOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x8B24F00", Offset = "0x8B24300", VA = "0x188B24F00")]
	private bool KNAALBDOGNH(KCPAKJKPIDH GDOCDNNCPKP, DKGDNEFFHIH GBDPBDHPLOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x8B24E00", Offset = "0x8B24200", VA = "0x188B24E00")]
	private bool JPONDKFPFNJ(KCPAKJKPIDH GDOCDNNCPKP, DKGDNEFFHIH GBDPBDHPLOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x8B24C50", Offset = "0x8B24050", VA = "0x188B24C50")]
	private bool JLDIBFKAABA(KCPAKJKPIDH GDOCDNNCPKP, DKGDNEFFHIH GBDPBDHPLOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x8B23560", Offset = "0x8B22960", VA = "0x188B23560")]
	private bool DNHEBODGFEP(KCPAKJKPIDH GDOCDNNCPKP, DKGDNEFFHIH GBDPBDHPLOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x8B23620", Offset = "0x8B22A20", VA = "0x188B23620")]
	private bool ECAKKGIKNAN(KCPAKJKPIDH GDOCDNNCPKP, DKGDNEFFHIH GBDPBDHPLOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x8B23EE0", Offset = "0x8B232E0", VA = "0x188B23EE0")]
	private bool IJKLBAOKNPL(KCPAKJKPIDH GDOCDNNCPKP, DKGDNEFFHIH GBDPBDHPLOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x8B23DD0", Offset = "0x8B231D0", VA = "0x188B23DD0")]
	private bool HMOFONNODBB(KCPAKJKPIDH GDOCDNNCPKP, DKGDNEFFHIH GBDPBDHPLOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x8B24E70", Offset = "0x8B24270", VA = "0x188B24E70")]
	private bool KDNPMOOCEHE(KCPAKJKPIDH GDOCDNNCPKP, DKGDNEFFHIH GBDPBDHPLOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x8B24B30", Offset = "0x8B23F30", VA = "0x188B24B30")]
	private bool JEGKMLOEDII(KCPAKJKPIDH GDOCDNNCPKP, DKGDNEFFHIH GBDPBDHPLOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x8B23720", Offset = "0x8B22B20", VA = "0x188B23720")]
	private bool EEEHKIEIPOD(KCPAKJKPIDH GDOCDNNCPKP, DKGDNEFFHIH GBDPBDHPLOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x8B238F0", Offset = "0x8B22CF0", VA = "0x188B238F0")]
	private bool HAHAJNIAJKN(KCPAKJKPIDH GDOCDNNCPKP, DKGDNEFFHIH GBDPBDHPLOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x8B25A40", Offset = "0x8B24E40", VA = "0x188B25A40")]
	private bool PNDFKLIAMGM(KCPAKJKPIDH GDOCDNNCPKP, DKGDNEFFHIH GBDPBDHPLOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x8B24D70", Offset = "0x8B24170", VA = "0x188B24D70")]
	private bool JNOJDLMIJPI(KCPAKJKPIDH GDOCDNNCPKP, DKGDNEFFHIH GBDPBDHPLOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x8B256C0", Offset = "0x8B24AC0", VA = "0x188B256C0")]
	private bool OFELHLLJDIG(KCPAKJKPIDH GDOCDNNCPKP, DKGDNEFFHIH GBDPBDHPLOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x8B23820", Offset = "0x8B22C20", VA = "0x188B23820")]
	private bool OJGDCFKPMJM(OCMMEBNEIHP FBHILNPOIJK, OCMMEBNEIHP HALFAEFPNJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x8B231C0", Offset = "0x8B225C0", VA = "0x188B231C0")]
	private bool CCBFIEGPNFD(KCPAKJKPIDH GDOCDNNCPKP, OCMMEBNEIHP HCPJBNCDEGH, DKGDNEFFHIH GBDPBDHPLOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x8B23460", Offset = "0x8B22860", VA = "0x188B23460")]
	private bool CHKADNNLHFJ(OCMMEBNEIHP HCPJBNCDEGH, DKGDNEFFHIH GBDPBDHPLOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x8B253D0", Offset = "0x8B247D0", VA = "0x188B253D0")]
	private bool MJFFFJDBNGA(OCMMEBNEIHP HCPJBNCDEGH, DKGDNEFFHIH GBDPBDHPLOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x8B25750", Offset = "0x8B24B50", VA = "0x188B25750")]
	private bool OOEBGPEPNAK(OCMMEBNEIHP HCPJBNCDEGH, DKGDNEFFHIH GBDPBDHPLOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x8B25340", Offset = "0x8B24740", VA = "0x188B25340")]
	private bool MGPNHPPEFIK(OCMMEBNEIHP HCPJBNCDEGH, DKGDNEFFHIH GBDPBDHPLOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x8B24F70", Offset = "0x8B24370", VA = "0x188B24F70")]
	private bool LLOJAJKJKPM(OCMMEBNEIHP HCPJBNCDEGH, DKGDNEFFHIH GBDPBDHPLOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x8B25460", Offset = "0x8B24860", VA = "0x188B25460")]
	private bool MJMCGMDBFGK(OCMMEBNEIHP HCPJBNCDEGH, DKGDNEFFHIH GBDPBDHPLOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x8B24BC0", Offset = "0x8B23FC0", VA = "0x188B24BC0")]
	private bool JGMFPPBBEDN(KCPAKJKPIDH GDOCDNNCPKP, DKGDNEFFHIH GBDPBDHPLOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x8B23830", Offset = "0x8B22C30", VA = "0x188B23830")]
	private bool GNMBDOMPNOL(KCPAKJKPIDH GDOCDNNCPKP, DKGDNEFFHIH GBDPBDHPLOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x8B254F0", Offset = "0x8B248F0", VA = "0x188B254F0")]
	private bool NLAAAFOIKGK(KCPAKJKPIDH GDOCDNNCPKP, DKGDNEFFHIH GBDPBDHPLOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x8B23980", Offset = "0x8B22D80", VA = "0x188B23980")]
	private bool HEMIEOLNEFE(KCPAKJKPIDH GDOCDNNCPKP, DKGDNEFFHIH GBDPBDHPLOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x8B234F0", Offset = "0x8B228F0", VA = "0x188B234F0")]
	private bool DIAKAHAGDAE(KCPAKJKPIDH GDOCDNNCPKP, DKGDNEFFHIH GBDPBDHPLOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x8B230C0", Offset = "0x8B224C0", VA = "0x188B230C0")]
	private bool BEPMONACDCI(KCPAKJKPIDH GDOCDNNCPKP, DKGDNEFFHIH GBDPBDHPLOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x8B255C0", Offset = "0x8B249C0", VA = "0x188B255C0")]
	private bool NNMEGJDKONB(KCPAKJKPIDH GDOCDNNCPKP, DKGDNEFFHIH GBDPBDHPLOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x8B233F0", Offset = "0x8B227F0", VA = "0x188B233F0")]
	private bool CECPMPKLBAA(KCPAKJKPIDH GDOCDNNCPKP, DKGDNEFFHIH GBDPBDHPLOA)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class FCNBKKGCIKA
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public FCNBKKGCIKA()
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
