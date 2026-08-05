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
using RecRoom.Avatars;
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
		[Cpp2IlInjected.Address(RVA = "0x8D81790", Offset = "0x8D80190", VA = "0x188D81790", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x29CDED0", Offset = "0x29CC8D0", VA = "0x1829CDED0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class KIKANJFIFKG
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x8D813E0", Offset = "0x8D7FDE0", VA = "0x188D813E0")]
	public static MKKCGKNNCCB HDFPEABBMKH(this OutfitType KCPLHLPCIAE)
	{
		return default(MKKCGKNNCCB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x8D81330", Offset = "0x8D7FD30", VA = "0x188D81330")]
	public static LPLFJNHNCDE FAIPPCBOOFB(this OutfitType KCPLHLPCIAE)
	{
		return default(LPLFJNHNCDE);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class BKEHLHELGNA : LAOLKOOCHBG, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private struct BOHAHLAJJFB : IAsyncStateMachine
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
		public BKEHLHELGNA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8D7B940", Offset = "0x8D7A340", VA = "0x188D7B940", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8D7BC40", Offset = "0x8D7A640", VA = "0x188D7BC40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct GKDPMKLFAED : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public AsyncTaskMethodBuilder<LGHAMIPCGHL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public BKEHLHELGNA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public Guid customAvatarItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private TaskAwaiter<LGHAMIPCGHL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8D7CEE0", Offset = "0x8D7B8E0", VA = "0x188D7CEE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8D7D1B0", Offset = "0x8D7BBB0", VA = "0x188D7D1B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct HBMMKCOAEEN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public AsyncTaskMethodBuilder<List<JJNPIFNJJFP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public BKEHLHELGNA <>4__this;

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
		private List<JJNPIFNJJFP> <results>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private TaskAwaiter<List<HJLACLGONDN>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8D7D790", Offset = "0x8D7C190", VA = "0x188D7D790", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8D7DF40", Offset = "0x8D7C940", VA = "0x188D7DF40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct CHBMBEAIBMI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public AsyncTaskMethodBuilder<List<JJNPIFNJJFP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public BKEHLHELGNA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public IReadOnlyList<CKAJELFPLEM> unifiedItemIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public bool convertCustomAvatarItemsToPurchasableGiftDrops;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private Task <watchStorefrontTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private List<HJLACLGONDN> <customAvatarItems>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private List<JJNPIFNJJFP> <storeItemsInInitialOrder>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private TaskAwaiter<List<HJLACLGONDN>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8D7BCE0", Offset = "0x8D7A6E0", VA = "0x188D7BCE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8D7C780", Offset = "0x8D7B180", VA = "0x188D7C780", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct HCPFAHHOFAO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public AsyncTaskMethodBuilder<List<HJLACLGONDN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public List<HJLACLGONDN> customAvatarItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public BKEHLHELGNA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8D7DFB0", Offset = "0x8D7C9B0", VA = "0x188D7DFB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8D7E4A0", Offset = "0x8D7CEA0", VA = "0x188D7E4A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class FLPFPMHEIIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public CKAJELFPLEM id;

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public FLPFPMHEIIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8D7CEA0", Offset = "0x8D7B8A0", VA = "0x188D7CEA0")]
		internal bool IMEPDMHPCMA(ENCDNBIIIKJ x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8D7CDE0", Offset = "0x8D7B7E0", VA = "0x188D7CDE0")]
		internal bool HJADOOGHMFG(JJNPIFNJJFP x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class OEGDHHGPGGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public string itemFriendlyName;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public OEGDHHGPGGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8D815A0", Offset = "0x8D7FFA0", VA = "0x188D815A0")]
		internal object CDPLNCENDHD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class CDAHPLGFHIN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public BKEHLHELGNA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public GiftItemDTO gift;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public CDAHPLGFHIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8D7BCA0", Offset = "0x8D7A6A0", VA = "0x188D7BCA0")]
		internal void FJFPKLMCECJ(BalanceUpdateResponseDTO<EEPEABGHNJH> result)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct GLCFMNGKLGP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public AsyncTaskMethodBuilder<IHPFBOBMIJI<BalanceUpdateResponseDTO<EEPEABGHNJH>>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public BKEHLHELGNA <>4__this;

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
		public MNKKBGFEDOF storefrontType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public LMFNPHDGODM currencyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private TaskAwaiter<LGHAMIPCGHL> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TaskAwaiter<IHPFBOBMIJI<BalanceUpdateResponseDTO<EEPEABGHNJH>>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8D7D220", Offset = "0x8D7BC20", VA = "0x188D7D220", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8D7D720", Offset = "0x8D7C120", VA = "0x188D7D720", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class PFLCIFCINKF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public BKEHLHELGNA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public bool handleShowGiftPackage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public bool shouldConsumeGiftBoxImmediately;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public PFLCIFCINKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8D815F0", Offset = "0x8D7FFF0", VA = "0x188D815F0")]
		internal void MHGADBDGJIJ(BalanceUpdateResponseDTO<EEPEABGHNJH> result)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class IBLPAGFEEBP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public BKEHLHELGNA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public GiftItemDTO gift;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public IBLPAGFEEBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8D7E8F0", Offset = "0x8D7D2F0", VA = "0x188D7E8F0")]
		internal void PDMKPPJFBPM(BalanceUpdateResponseDTO<EEPEABGHNJH> result)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct IAOLOAACFCK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public AsyncTaskMethodBuilder<List<JJNPIFNJJFP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public List<HJLACLGONDN> customAvatarItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public BKEHLHELGNA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private List<JJNPIFNJJFP> <output>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8D7E510", Offset = "0x8D7CF10", VA = "0x188D7E510", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x8D7E740", Offset = "0x8D7D140", VA = "0x188D7E740", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct AIBHEHEGIGM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public AsyncTaskMethodBuilder<List<LGHAMIPCGHL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public IReadOnlyList<Guid> itemIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public BKEHLHELGNA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private TaskAwaiter<List<HPHKLJMNEEE>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8D77670", Offset = "0x8D76070", VA = "0x188D77670", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8D77A70", Offset = "0x8D76470", VA = "0x188D77A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct DCEBNGCLHNH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public List<JJNPIFNJJFP> storeItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public BKEHLHELGNA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private int <attemptNumber>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x8D7C7F0", Offset = "0x8D7B1F0", VA = "0x188D7C7F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x8D7CD80", Offset = "0x8D7B780", VA = "0x188D7CD80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly HDMHNNDAPOA<Guid, LGHAMIPCGHL> MOIKDGLDOBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private MCGGGBGPEPF DNJDIACKINJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private DJNPBPBKLAM PAAKIMDJFOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private DHAIBAFNOKJ BMGAFLHELHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private JAIABCMKAFE IHDIPNNKBII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private MNBFGPHNFDP JCCNKPOHPKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private CMANBFFCBML FGKLNKPJLFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal CMLAJHKJHAI<Guid, LGHAMIPCGHL> CLABBJNMAMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private bool JPNPFIIDGCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private Task NNBHOCDBDJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private CancellationTokenSource OIADOBHMDOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private List<ENCDNBIIIKJ> CGHAAPBBFLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private GBKBEHIPFBD? INJIIPMHAGP;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static LAOLKOOCHBG GHBNEILHBAO;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private List<ENCDNBIIIKJ> OIJAOHOPKNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8D7B320", Offset = "0x8D79D20", VA = "0x188D7B320")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private GBKBEHIPFBD CFGCPOEIANH
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8D79DD0", Offset = "0x8D787D0", VA = "0x188D79DD0")]
		get
		{
			return default(GBKBEHIPFBD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static LAOLKOOCHBG FLGHCDNLMND
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8D7AF00", Offset = "0x8D79900", VA = "0x188D7AF00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x8D77AE0", Offset = "0x8D764E0", VA = "0x188D77AE0")]
	private List<ENCDNBIIIKJ> ANCHDEIAPFK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x8D77C50", Offset = "0x8D76650", VA = "0x188D77C50")]
	[DMKNBLIJJON.FLOPHDCKCCN.LAPOKDABJFJ]
	internal static void BHAGPFKLBNG(JBJKIIKOACK KLIEGJHNGPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x8D7B4C0", Offset = "0x8D79EC0", VA = "0x188D7B4C0")]
	[RecRoom.NoEngine.Common.Preserve]
	public BKEHLHELGNA([BMCONCJPCIA(null)] DHAIBAFNOKJ BMGAFLHELHL, [BMCONCJPCIA(null)] MCGGGBGPEPF DNJDIACKINJ, [BMCONCJPCIA(null)] DJNPBPBKLAM PAAKIMDJFOC, [BMCONCJPCIA(null)] JAIABCMKAFE IHDIPNNKBII, [BMCONCJPCIA(null)] MNBFGPHNFDP JCCNKPOHPKO, [BMCONCJPCIA(null)] CMANBFFCBML FGKLNKPJLFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x8D78760", Offset = "0x8D77160", VA = "0x188D78760", Slot = "1")]
	~BKEHLHELGNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x8D78590", Offset = "0x8D76F90", VA = "0x188D78590", Slot = "14")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x8D7B230", Offset = "0x8D79C30", VA = "0x188D7B230")]
	[AsyncStateMachine(typeof(BOHAHLAJJFB))]
	private Task NHCNOKPBADG(CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x8D79C90", Offset = "0x8D78690", VA = "0x188D79C90")]
	public void JPACOHJAGIF(Guid JNHMLCINHNO, LGHAMIPCGHL LEKLGPPMKAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x8D7B000", Offset = "0x8D79A00", VA = "0x188D7B000", Slot = "15")]
	public void NGJKMEBNEDB(JJNPIFNJJFP DNLBJOMGDED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x8D78B40", Offset = "0x8D77540", VA = "0x188D78B40", Slot = "4")]
	public void HMDKJJBIIOG(IEnumerable<JJNPIFNJJFP> KBAMBKOMANG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x8D78280", Offset = "0x8D76C80", VA = "0x188D78280", Slot = "16")]
	public LGHAMIPCGHL DHHGJICDODP(Guid PCPOOIGHMLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x8D78390", Offset = "0x8D76D90", VA = "0x188D78390", Slot = "5")]
	public LGHAMIPCGHL DHHGJICDODP(JJNPIFNJJFP DNLBJOMGDED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x8D7ADF0", Offset = "0x8D797F0", VA = "0x188D7ADF0", Slot = "17")]
	[AsyncStateMachine(typeof(GKDPMKLFAED))]
	public Task<LGHAMIPCGHL> MPBDPPKHEOK(Guid PCPOOIGHMLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x8D78600", Offset = "0x8D77000", VA = "0x188D78600", Slot = "7")]
	[AsyncStateMachine(typeof(HBMMKCOAEEN))]
	public Task<List<JJNPIFNJJFP>> FLJPMMIMLCO(string HBOFFCJLNHK, bool? HLBHPDNOKCM, bool? EGBBIODKLHK, IEnumerable<int> CGLMHBAPNKB, bool IBLAPKODGOJ, bool KJNCAPBJIJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x8D78850", Offset = "0x8D77250", VA = "0x188D78850", Slot = "6")]
	public JJNPIFNJJFP HGJOJGOCMEP(CKAJELFPLEM JNHMLCINHNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x8D79B50", Offset = "0x8D78550", VA = "0x188D79B50", Slot = "8")]
	[AsyncStateMachine(typeof(CHBMBEAIBMI))]
	public Task<List<JJNPIFNJJFP>> JNNALHLCFBK(IReadOnlyList<CKAJELFPLEM> BAAAEFKOJPB, bool NBNEKMIGFFG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x8D79FE0", Offset = "0x8D789E0", VA = "0x188D79FE0")]
	[AsyncStateMachine(typeof(HCPFAHHOFAO))]
	private Task<List<HJLACLGONDN>> LDBIBAMPFFC(List<HJLACLGONDN> EODEMANNLNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x8D79530", Offset = "0x8D77F30", VA = "0x188D79530")]
	private List<JJNPIFNJJFP> JACGPKHBHFC(IReadOnlyList<CKAJELFPLEM> DGNJFAONJKB, IReadOnlyList<ENCDNBIIIKJ> NKCIJAANPOH, IReadOnlyList<JJNPIFNJJFP> EODEMANNLNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x8D7A0F0", Offset = "0x8D78AF0", VA = "0x188D7A0F0", Slot = "9")]
	public FKFADEBPFBK<BalanceUpdateResponseDTO<EEPEABGHNJH>> LILEOPLMEKJ(Guid PCPOOIGHMLK, long MCIFNPFIHOD, GiftItemDTO GPLPEJGDGAD, LMFNPHDGODM MPANHJMLCKL = LMFNPHDGODM.RecCenterTokens, [Optional] long? FPNNJGOGIJD, MNKKBGFEDOF GDOALLFDIEI = MNKKBGFEDOF.None)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x8D7A900", Offset = "0x8D79300", VA = "0x188D7A900")]
	[AsyncStateMachine(typeof(GLCFMNGKLGP))]
	private Task<IHPFBOBMIJI<BalanceUpdateResponseDTO<EEPEABGHNJH>>> MBPLCMBIDPB(Guid PCPOOIGHMLK, long MCIFNPFIHOD, GiftItemDTO GPLPEJGDGAD, LMFNPHDGODM MPANHJMLCKL = LMFNPHDGODM.RecCenterTokens, [Optional] long? FPNNJGOGIJD, MNKKBGFEDOF GDOALLFDIEI = MNKKBGFEDOF.None)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x8D78CF0", Offset = "0x8D776F0", VA = "0x188D78CF0", Slot = "10")]
	public FKFADEBPFBK<BalanceUpdateResponseDTO<EEPEABGHNJH>> HNMHDMBBKIP(MNKKBGFEDOF GDOALLFDIEI, LMFNPHDGODM MPANHJMLCKL, int CBKJMCCIGII, long MCIFNPFIHOD, long? FPNNJGOGIJD, int FNALNEELHDE, bool OEHGMBDMCNH = false, bool OBIKINGJAPF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x8D77D20", Offset = "0x8D76720", VA = "0x188D77D20", Slot = "11")]
	public FKFADEBPFBK<BalanceUpdateResponseDTO<EEPEABGHNJH>> DEHBGPCLLKC(MNKKBGFEDOF GDOALLFDIEI, LMFNPHDGODM MPANHJMLCKL, int CBKJMCCIGII, long MCIFNPFIHOD, long? FPNNJGOGIJD, IReadOnlyCollection<int> AFDBGGKKDOP, string JEBOHIALEMJ, bool GGNALBLNCIL, OMIDHABEBNI OHNDMPKIDEO, int FNALNEELHDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x8D7A350", Offset = "0x8D78D50", VA = "0x188D7A350", Slot = "12")]
	public FKFADEBPFBK<BalanceUpdateResponseDTO<EEPEABGHNJH>> LODIALIMIBG(MNKKBGFEDOF GDOALLFDIEI, LMFNPHDGODM MPANHJMLCKL, IReadOnlyList<CKAJELFPLEM> NHOFHONJCIJ, IReadOnlyList<long> IOFMILLCKOD, [Optional] long? FPNNJGOGIJD, [Optional][CanBeNull] GiftItemDTO GPLPEJGDGAD, [Optional] Guid? CMEFKHGDGEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x8D7ACD0", Offset = "0x8D796D0", VA = "0x188D7ACD0", Slot = "13")]
	[AsyncStateMachine(typeof(IAOLOAACFCK))]
	public Task<List<JJNPIFNJJFP>> MLLGIHKNLCN(List<HJLACLGONDN> EODEMANNLNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x8D792F0", Offset = "0x8D77CF0", VA = "0x188D792F0")]
	[AsyncStateMachine(typeof(AIBHEHEGIGM))]
	private Task<List<LGHAMIPCGHL>> IHGBKOBIKCP(IReadOnlyList<Guid> NHOFHONJCIJ, CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x8D78FE0", Offset = "0x8D779E0", VA = "0x188D78FE0")]
	private void IDOMNNLJAIP(BalanceUpdateResponseDTO<EEPEABGHNJH> EKMCEDIJMDM, bool MGENHNCANAB, bool OBIKINGJAPF, bool OEHGMBDMCNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x8D7AA60", Offset = "0x8D79460", VA = "0x188D7AA60")]
	private void MIHCLJGBLPJ(NDAMNDNBEKH PFCAIPJMNNH, bool FHICGHINEAA, bool GMMFHCCABCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x8D79430", Offset = "0x8D77E30", VA = "0x188D79430")]
	[AsyncStateMachine(typeof(DCEBNGCLHNH))]
	private Task IJIONPFJONO(List<JJNPIFNJJFP> KBAMBKOMANG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x8D77CF0", Offset = "0x8D766F0", VA = "0x188D77CF0")]
	[CompilerGenerated]
	private void BMKAAPDDAOL(BalanceUpdateResponseDTO<EEPEABGHNJH> GGIKEMCHAAA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class IKBFJPLCMEH : AFGHELJBOHL
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class IAPGPHHADIK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public IKBFJPLCMEH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public LPLFJNHNCDE roomieFilters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public JJNPIFNJJFP item;

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public IAPGPHHADIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8D7E7B0", Offset = "0x8D7D1B0", VA = "0x188D7E7B0")]
		internal bool EAKFFKLAFBA(OutfitType outfitType)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly MNBFGPHNFDP JBBGPJGCNKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly LHGPGFCMLKM GBDHFBBLKFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly MLFEKNKEPFA FJNNOJCAKKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly GHLHJJKHGDN EGLFPNAENGO;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x8D7F770", Offset = "0x8D7E170", VA = "0x188D7F770")]
	[DMKNBLIJJON.FLOPHDCKCCN.LAPOKDABJFJ]
	internal static void HFPMPAAENFC(JBJKIIKOACK KLIEGJHNGPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x112D030", Offset = "0x112BA30", VA = "0x18112D030")]
	[RecRoom.NoEngine.Common.Preserve]
	public IKBFJPLCMEH([BMCONCJPCIA(null)] MNBFGPHNFDP JCCNKPOHPKO, [BMCONCJPCIA(null)] LHGPGFCMLKM NKMEHEKPBJH, [BMCONCJPCIA(null)] MLFEKNKEPFA EODEMANNLNK, [BMCONCJPCIA(null)] GHLHJJKHGDN CEPJPJBBHME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x8D7EB80", Offset = "0x8D7D580", VA = "0x188D7EB80")]
	private bool CFJCHKICCEP(MKKCGKNNCCB JIMLJPHCIOE, MKKCGKNNCCB NNPIEFJFEDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x8D7F920", Offset = "0x8D7E320", VA = "0x188D7F920", Slot = "5")]
	public IReadOnlyList<JJNPIFNJJFP> IDLMMECLONN(MKKCGKNNCCB HDCHKNCHHAA, LPLFJNHNCDE CGDNEHPMPNB, IReadOnlyList<JJNPIFNJJFP> GLPDKCPPLJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x8D7FE80", Offset = "0x8D7E880", VA = "0x188D7FE80", Slot = "4")]
	public bool KBKNLBHAPPL(MKKCGKNNCCB HDCHKNCHHAA, LPLFJNHNCDE CGDNEHPMPNB, JJNPIFNJJFP EOJOFJJBHLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x8D80E10", Offset = "0x8D7F810", VA = "0x188D80E10")]
	private bool LFIKCJGOFBG(MKKCGKNNCCB HDCHKNCHHAA, JJNPIFNJJFP EOJOFJJBHLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x8D7F0F0", Offset = "0x8D7DAF0", VA = "0x188D7F0F0")]
	private bool FOCKKFHFLOJ(MKKCGKNNCCB HDCHKNCHHAA, JJNPIFNJJFP EOJOFJJBHLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x8D7EA80", Offset = "0x8D7D480", VA = "0x188D7EA80")]
	private bool BMBCEHNPMKG(MKKCGKNNCCB HDCHKNCHHAA, JJNPIFNJJFP EOJOFJJBHLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x8D7F460", Offset = "0x8D7DE60", VA = "0x188D7F460")]
	public bool GPEEBBCOPAH(JJNPIFNJJFP DNLBJOMGDED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x8D7F6B0", Offset = "0x8D7E0B0", VA = "0x188D7F6B0")]
	public bool GPEEBBCOPAH(KICGLGIDEMP DEIBHACIKGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x8D80D90", Offset = "0x8D7F790", VA = "0x188D80D90")]
	private bool KMPBKEKFCMF(Guid PCPOOIGHMLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x8D7EA50", Offset = "0x8D7D450", VA = "0x188D7EA50")]
	private bool BBMKJGHPHEA(MKKCGKNNCCB HDCHKNCHHAA, JJNPIFNJJFP EOJOFJJBHLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x8D81010", Offset = "0x8D7FA10", VA = "0x188D81010")]
	private bool NDEGINOELMH(MKKCGKNNCCB HDCHKNCHHAA, JJNPIFNJJFP EOJOFJJBHLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x8D7F7E0", Offset = "0x8D7E1E0", VA = "0x188D7F7E0")]
	private bool HLOOBIOOBLN(MKKCGKNNCCB HDCHKNCHHAA, JJNPIFNJJFP EOJOFJJBHLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x8D7F080", Offset = "0x8D7DA80", VA = "0x188D7F080")]
	private bool FHEKKEHLGOI(MKKCGKNNCCB HDCHKNCHHAA, JJNPIFNJJFP EOJOFJJBHLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x8D80F10", Offset = "0x8D7F910", VA = "0x188D80F10")]
	private bool MCNIFCBELOK(MKKCGKNNCCB HDCHKNCHHAA, JJNPIFNJJFP EOJOFJJBHLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x8D80C60", Offset = "0x8D7F660", VA = "0x188D80C60")]
	private bool KKFBNIAPCKH(MKKCGKNNCCB HDCHKNCHHAA, JJNPIFNJJFP EOJOFJJBHLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x8D80EA0", Offset = "0x8D7F8A0", VA = "0x188D80EA0")]
	private bool LIMCPDCACDD(MKKCGKNNCCB HDCHKNCHHAA, JJNPIFNJJFP EOJOFJJBHLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x8D7E9C0", Offset = "0x8D7D3C0", VA = "0x188D7E9C0")]
	private bool AMJJLADHKJP(MKKCGKNNCCB HDCHKNCHHAA, JJNPIFNJJFP EOJOFJJBHLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x8D80CD0", Offset = "0x8D7F6D0", VA = "0x188D80CD0")]
	private bool KKONNNKFFED(MKKCGKNNCCB HDCHKNCHHAA, JJNPIFNJJFP EOJOFJJBHLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x8D7E930", Offset = "0x8D7D330", VA = "0x188D7E930")]
	private bool ABHAHNHGGFH(MKKCGKNNCCB HDCHKNCHHAA, JJNPIFNJJFP EOJOFJJBHLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x8D810C0", Offset = "0x8D7FAC0", VA = "0x188D810C0")]
	private bool OLPGPIKALHB(MKKCGKNNCCB HDCHKNCHHAA, JJNPIFNJJFP EOJOFJJBHLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x8D7ED60", Offset = "0x8D7D760", VA = "0x188D7ED60")]
	private bool CNEKOGOINFO(MKKCGKNNCCB HDCHKNCHHAA, JJNPIFNJJFP EOJOFJJBHLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x8D812A0", Offset = "0x8D7FCA0", VA = "0x188D812A0")]
	private bool PNBEKMPDNBG(MKKCGKNNCCB HDCHKNCHHAA, JJNPIFNJJFP EOJOFJJBHLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x8D7EF80", Offset = "0x8D7D980", VA = "0x188D7EF80")]
	private bool EFJOELLFOPC(MKKCGKNNCCB HDCHKNCHHAA, JJNPIFNJJFP EOJOFJJBHLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x8D80F80", Offset = "0x8D7F980", VA = "0x188D80F80")]
	private bool MLCCGICKJAN(MKKCGKNNCCB HDCHKNCHHAA, JJNPIFNJJFP EOJOFJJBHLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x8D80B40", Offset = "0x8D7F540", VA = "0x188D80B40")]
	private bool KGEAHMGHOFO(MKKCGKNNCCB HDCHKNCHHAA, JJNPIFNJJFP EOJOFJJBHLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x8D81210", Offset = "0x8D7FC10", VA = "0x188D81210")]
	private bool PKKHDKGPHOK(MKKCGKNNCCB HDCHKNCHHAA, JJNPIFNJJFP EOJOFJJBHLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x8D7FD60", Offset = "0x8D7E760", VA = "0x188D7FD60")]
	private bool IKBGIJDLAOM(MKKCGKNNCCB HDCHKNCHHAA, JJNPIFNJJFP EOJOFJJBHLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x8D81030", Offset = "0x8D7FA30", VA = "0x188D81030")]
	private bool OIICEFABOAC(MKKCGKNNCCB HDCHKNCHHAA, JJNPIFNJJFP EOJOFJJBHLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x8D7FBF0", Offset = "0x8D7E5F0", VA = "0x188D7FBF0")]
	private bool IGDNGHDDNIB(MKKCGKNNCCB HDCHKNCHHAA, LPLFJNHNCDE CGDNEHPMPNB, JJNPIFNJJFP EOJOFJJBHLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x8D80BD0", Offset = "0x8D7F5D0", VA = "0x188D80BD0")]
	private bool KKCOEHIJIIL(LPLFJNHNCDE CGDNEHPMPNB, JJNPIFNJJFP EOJOFJJBHLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x8D7EB90", Offset = "0x8D7D590", VA = "0x188D7EB90")]
	private bool CGONNMKDBCG(LPLFJNHNCDE CGDNEHPMPNB, JJNPIFNJJFP EOJOFJJBHLN, OutfitType KCPLHLPCIAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x8D7EE80", Offset = "0x8D7D880", VA = "0x188D7EE80")]
	private bool DKKDHLJJPFO(LPLFJNHNCDE CGDNEHPMPNB, JJNPIFNJJFP EOJOFJJBHLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x8D7EAF0", Offset = "0x8D7D4F0", VA = "0x188D7EAF0")]
	private bool CBBKPMEICHH(MKKCGKNNCCB HDCHKNCHHAA, JJNPIFNJJFP EOJOFJJBHLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x8D81150", Offset = "0x8D7FB50", VA = "0x188D81150")]
	private bool ONLLLGJIFAM(MKKCGKNNCCB HDCHKNCHHAA, JJNPIFNJJFP EOJOFJJBHLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x8D7F850", Offset = "0x8D7E250", VA = "0x188D7F850")]
	private bool IAPKEIOCDOK(MKKCGKNNCCB HDCHKNCHHAA, JJNPIFNJJFP EOJOFJJBHLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x8D7EDF0", Offset = "0x8D7D7F0", VA = "0x188D7EDF0")]
	private bool DCGEPOKMDMK(MKKCGKNNCCB HDCHKNCHHAA, JJNPIFNJJFP EOJOFJJBHLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x8D7FB80", Offset = "0x8D7E580", VA = "0x188D7FB80")]
	private bool IFDFCCMICOM(MKKCGKNNCCB HDCHKNCHHAA, JJNPIFNJJFP EOJOFJJBHLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x8D7FDF0", Offset = "0x8D7E7F0", VA = "0x188D7FDF0")]
	private bool JGMKNOJNKJA(MKKCGKNNCCB HDCHKNCHHAA, JJNPIFNJJFP EOJOFJJBHLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x8D7ECD0", Offset = "0x8D7D6D0", VA = "0x188D7ECD0")]
	private bool CIFDIELJAIM(MKKCGKNNCCB HDCHKNCHHAA, JJNPIFNJJFP EOJOFJJBHLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x8D7F010", Offset = "0x8D7DA10", VA = "0x188D7F010")]
	private bool FEEHDLINIOD(MKKCGKNNCCB HDCHKNCHHAA, JJNPIFNJJFP EOJOFJJBHLN)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class HOMBPOKEPHI
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public HOMBPOKEPHI()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
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
