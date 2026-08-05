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
		[Cpp2IlInjected.Address(RVA = "0x82B3B50", Offset = "0x82B2F50", VA = "0x1882B3B50", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x25D0340", Offset = "0x25CF740", VA = "0x1825D0340")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class BLOLAFFHEAA : IMEHNAMBNDD, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private struct KCPMBJKNHPH : IAsyncStateMachine
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
		public BLOLAFFHEAA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x82B07F0", Offset = "0x82AFBF0", VA = "0x1882B07F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x82B0AF0", Offset = "0x82AFEF0", VA = "0x1882B0AF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private struct EPOKCAAKBBG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public AsyncTaskMethodBuilder<DGJPLIFDNMH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public BLOLAFFHEAA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public Guid customAvatarItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private TaskAwaiter<DGJPLIFDNMH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x82AF140", Offset = "0x82AE540", VA = "0x1882AF140", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x82AF410", Offset = "0x82AE810", VA = "0x1882AF410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct FBFJKHCOFDC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public AsyncTaskMethodBuilder<List<IECDCEFECPJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public BLOLAFFHEAA <>4__this;

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
		private List<IECDCEFECPJ> <results>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private TaskAwaiter<List<MKPOOCCADGL>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x82AF480", Offset = "0x82AE880", VA = "0x1882AF480", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x82AFC40", Offset = "0x82AF040", VA = "0x1882AFC40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct OEAMMPCMMCC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public AsyncTaskMethodBuilder<List<IECDCEFECPJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public BLOLAFFHEAA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public IReadOnlyList<MEKHGINHFPB> unifiedItemIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public bool convertCustomAvatarItemsToPurchasableGiftDrops;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private List<IECDCEFECPJ> <storeItemsInInitialOrder>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private TaskAwaiter<List<MKPOOCCADGL>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x82B3060", Offset = "0x82B2460", VA = "0x1882B3060", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x82B3930", Offset = "0x82B2D30", VA = "0x1882B3930", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct IAEICLADAKK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public AsyncTaskMethodBuilder<List<MKPOOCCADGL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public List<MKPOOCCADGL> customAvatarItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public BLOLAFFHEAA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x82B0240", Offset = "0x82AF640", VA = "0x1882B0240", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x82B0740", Offset = "0x82AFB40", VA = "0x1882B0740", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class LPNMFJNGCJI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public MEKHGINHFPB id;

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public LPNMFJNGCJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x82B2F60", Offset = "0x82B2360", VA = "0x1882B2F60")]
		internal bool LINFFGKJHFI(OJCLFNBBNMB x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x82B2FA0", Offset = "0x82B23A0", VA = "0x1882B2FA0")]
		internal bool NMFEPGLJCCA(IECDCEFECPJ x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class DFIGFPEBBAJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public string itemFriendlyName;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public DFIGFPEBBAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x82AF0F0", Offset = "0x82AE4F0", VA = "0x1882AF0F0")]
		internal object CKEPOLEBMPG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class ICLAACNJLHG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public BLOLAFFHEAA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public GiftItemDTO gift;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public ICLAACNJLHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x82B07B0", Offset = "0x82AFBB0", VA = "0x1882B07B0")]
		internal void AEIFLKEIMKH(BalanceUpdateResponseDTO<IEMKIMGLPII> result)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct BLJCNELFAJE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public AsyncTaskMethodBuilder<EOFBFBMKEKI<BalanceUpdateResponseDTO<IEMKIMGLPII>>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public BLOLAFFHEAA <>4__this;

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
		public DMBFOMPAHCH storefrontType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public JMOBIALPBAE currencyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private TaskAwaiter<DGJPLIFDNMH> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private TaskAwaiter<EOFBFBMKEKI<BalanceUpdateResponseDTO<IEMKIMGLPII>>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x82AAFE0", Offset = "0x82AA3E0", VA = "0x1882AAFE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x82AB4C0", Offset = "0x82AA8C0", VA = "0x1882AB4C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class FLPEGINJKJI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public BLOLAFFHEAA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public bool handleShowGiftPackage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public bool shouldConsumeGiftBoxImmediately;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public FLPEGINJKJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x82B0200", Offset = "0x82AF600", VA = "0x1882B0200")]
		internal void HOLJKHIGNKP(BalanceUpdateResponseDTO<IEMKIMGLPII> result)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct AIAMFJIDGEH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public AsyncTaskMethodBuilder<List<DGJPLIFDNMH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public IReadOnlyList<Guid> itemIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public BLOLAFFHEAA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private TaskAwaiter<List<MBODJAJBNFH>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x82AAB60", Offset = "0x82A9F60", VA = "0x1882AAB60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x82AAF70", Offset = "0x82AA370", VA = "0x1882AAF70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct FLEGOPBKJBA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public List<IECDCEFECPJ> storeItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public BLOLAFFHEAA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private int <attemptNumber>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x82AFCB0", Offset = "0x82AF0B0", VA = "0x1882AFCB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x82B01A0", Offset = "0x82AF5A0", VA = "0x1882B01A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly APLNMPNGECH<Guid, DGJPLIFDNMH> DAMBDPOFAFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private POPFADOCJMD DODOHMBJPGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private CPNPLFKFFME OGGGJBKCKGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private HGDDNOGHJKG DKMIMCFJBLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private JOBJPBNLDCJ KNIJKHNCHGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private IOFFCGADLEI JJEGGNDKAIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private MGDFFFNAIOO LHEFKPIDAHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal DBCKBHEENGK<Guid, DGJPLIFDNMH> KNKFIOJMIOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private bool LLMGCACGBCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private Task CIJPFFOKGPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private CancellationTokenSource DAEMJCIGOOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private List<OJCLFNBBNMB> GIIFDENJLID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private PEJGKLIMLCJ? EPNAIIGJEOJ;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static IMEHNAMBNDD KIADLHDJGGO;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private List<OJCLFNBBNMB> INNEHKINKMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x82AD9D0", Offset = "0x82ACDD0", VA = "0x1882AD9D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private PEJGKLIMLCJ EEJABJAACFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x82AD2C0", Offset = "0x82AC6C0", VA = "0x1882AD2C0")]
		get
		{
			return default(PEJGKLIMLCJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static IMEHNAMBNDD IADGMEFIGGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x82ADB70", Offset = "0x82ACF70", VA = "0x1882ADB70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x82AC560", Offset = "0x82AB960", VA = "0x1882AC560")]
	private List<OJCLFNBBNMB> ENNEPFMIHJN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x82AE270", Offset = "0x82AD670", VA = "0x1882AE270")]
	[ACPGCKDGGJH.EECHBLLBGJE.IPGDONABLJD]
	internal static void MDKHJOIDCIP(NPCGGDCACLM INELJPKBMLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x82AEC70", Offset = "0x82AE070", VA = "0x1882AEC70")]
	[RecRoom.NoEngine.Common.Preserve]
	public BLOLAFFHEAA([MGCCDFKFGBG(null)] HGDDNOGHJKG DKMIMCFJBLD, [MGCCDFKFGBG(null)] POPFADOCJMD DODOHMBJPGF, [MGCCDFKFGBG(null)] CPNPLFKFFME OGGGJBKCKGE, [MGCCDFKFGBG(null)] JOBJPBNLDCJ KNIJKHNCHGL, [MGCCDFKFGBG(null)] IOFFCGADLEI JJEGGNDKAIG, [MGCCDFKFGBG(null)] MGDFFFNAIOO LHEFKPIDAHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x82ACEC0", Offset = "0x82AC2C0", VA = "0x1882ACEC0", Slot = "1")]
	~BLOLAFFHEAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x82AC4C0", Offset = "0x82AB8C0", VA = "0x1882AC4C0", Slot = "13")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x82AE930", Offset = "0x82ADD30", VA = "0x1882AE930")]
	[AsyncStateMachine(typeof(KCPMBJKNHPH))]
	private Task NHCCNOOKHOH(CancellationToken JDDHIJBJNHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x82ABA10", Offset = "0x82AAE10", VA = "0x1882ABA10")]
	public void BDNGJGMPBGN(Guid OFMELAFEMHB, DGJPLIFDNMH CBGCILBDPND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x82ABD10", Offset = "0x82AB110", VA = "0x1882ABD10", Slot = "14")]
	public void BMLCFAJEAIF(IECDCEFECPJ KGANLJLBDJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x82ABB50", Offset = "0x82AAF50", VA = "0x1882ABB50", Slot = "4")]
	public void BFAMCBIJPCI(IEnumerable<IECDCEFECPJ> IADDJJJOCPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x82AD1B0", Offset = "0x82AC5B0", VA = "0x1882AD1B0", Slot = "15")]
	public DGJPLIFDNMH GKGHFIEJFBO(Guid LHMBLLKGLHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x82ACFB0", Offset = "0x82AC3B0", VA = "0x1882ACFB0", Slot = "5")]
	public DGJPLIFDNMH GKGHFIEJFBO(IECDCEFECPJ KGANLJLBDJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x82AEA20", Offset = "0x82ADE20", VA = "0x1882AEA20", Slot = "16")]
	[AsyncStateMachine(typeof(EPOKCAAKBBG))]
	public Task<DGJPLIFDNMH> OKANMLNKKKL(Guid LHMBLLKGLHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x82AC050", Offset = "0x82AB450", VA = "0x1882AC050", Slot = "7")]
	[AsyncStateMachine(typeof(FBFJKHCOFDC))]
	public Task<List<IECDCEFECPJ>> DHIFMMPKOKG(string CANIMBCOLCM, bool? GBCGELOBFNC, bool? KLINGMDKKBJ, IEnumerable<int> CLMGJKGJMHM, bool HOIAFPIEPIA, bool NBDCMJEFLOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x82ACBC0", Offset = "0x82ABFC0", VA = "0x1882ACBC0", Slot = "6")]
	public IECDCEFECPJ FHOBLEDAILJ(MEKHGINHFPB OFMELAFEMHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x82AE130", Offset = "0x82AD530", VA = "0x1882AE130", Slot = "8")]
	[AsyncStateMachine(typeof(OEAMMPCMMCC))]
	public Task<List<IECDCEFECPJ>> LECPMHINFJP(IReadOnlyList<MEKHGINHFPB> CHPFLPILGLG, bool GMPOIBBLNGI = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x82ABF40", Offset = "0x82AB340", VA = "0x1882ABF40")]
	[AsyncStateMachine(typeof(IAEICLADAKK))]
	private Task<List<MKPOOCCADGL>> DCKFEEDIGKA(List<MKPOOCCADGL> MIKADHKHCBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x82AE310", Offset = "0x82AD710", VA = "0x1882AE310")]
	private List<IECDCEFECPJ> NFKIPGKPIBA(IReadOnlyList<MEKHGINHFPB> OIAONLJMFPC, IReadOnlyList<OJCLFNBBNMB> CPHPANPOJCI, IReadOnlyList<IECDCEFECPJ> MIKADHKHCBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x82AB530", Offset = "0x82AA930", VA = "0x1882AB530", Slot = "9")]
	public NDJGFNKMCGL<BalanceUpdateResponseDTO<IEMKIMGLPII>> AIIPGACPBGG(Guid LHMBLLKGLHN, long GLGHCLOJKDE, GiftItemDTO JHGBAACOEFN, JMOBIALPBAE NBMAOFBFJAP = JMOBIALPBAE.RecCenterTokens, [Optional] long? MNBEKAEJIEK, DMBFOMPAHCH GMLFGDBLLAL = DMBFOMPAHCH.None)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x82ADC70", Offset = "0x82AD070", VA = "0x1882ADC70")]
	[AsyncStateMachine(typeof(BLJCNELFAJE))]
	private Task<EOFBFBMKEKI<BalanceUpdateResponseDTO<IEMKIMGLPII>>> JAJKDLEFGBI(Guid LHMBLLKGLHN, long GLGHCLOJKDE, GiftItemDTO JHGBAACOEFN, JMOBIALPBAE NBMAOFBFJAP = JMOBIALPBAE.RecCenterTokens, [Optional] long? MNBEKAEJIEK, DMBFOMPAHCH GMLFGDBLLAL = DMBFOMPAHCH.None)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x82ADED0", Offset = "0x82AD2D0", VA = "0x1882ADED0", Slot = "10")]
	public NDJGFNKMCGL<BalanceUpdateResponseDTO<IEMKIMGLPII>> KLMKKCAGJJE(DMBFOMPAHCH GMLFGDBLLAL, JMOBIALPBAE NBMAOFBFJAP, int BIMIGOBGGFM, long GLGHCLOJKDE, long? MNBEKAEJIEK, int PFGFNBDMAOJ, bool FPDEMOLGJFC = false, bool CEGHABPCHKE = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x82AD4E0", Offset = "0x82AC8E0", VA = "0x1882AD4E0", Slot = "11")]
	public NDJGFNKMCGL<BalanceUpdateResponseDTO<IEMKIMGLPII>> HKPBNBMJHHA(DMBFOMPAHCH GMLFGDBLLAL, JMOBIALPBAE NBMAOFBFJAP, int BIMIGOBGGFM, long GLGHCLOJKDE, long? MNBEKAEJIEK, IReadOnlyCollection<int> JMFKHPBKPKI, string FGEBHLNNMNH, bool KIEEFGIIOHA, MHCMHLOBBIK JPKCKHBKCLA, int PFGFNBDMAOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x82AC6D0", Offset = "0x82ABAD0", VA = "0x1882AC6D0", Slot = "12")]
	public NDJGFNKMCGL<BalanceUpdateResponseDTO<IEMKIMGLPII>> FCMMIDAJLGI(DMBFOMPAHCH GMLFGDBLLAL, JMOBIALPBAE NBMAOFBFJAP, IReadOnlyList<int> IGPFMECAMNP, IReadOnlyList<long> KINCBKEOHPH, long? MNBEKAEJIEK, int BMAINOPIPHE, string FGEBHLNNMNH, bool KIEEFGIIOHA, MHCMHLOBBIK JPKCKHBKCLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x82AEB30", Offset = "0x82ADF30", VA = "0x1882AEB30")]
	[AsyncStateMachine(typeof(AIAMFJIDGEH))]
	private Task<List<DGJPLIFDNMH>> PMCFFIHDAGI(IReadOnlyList<Guid> HJOBDFOOFLH, CancellationToken JDDHIJBJNHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x82AC1B0", Offset = "0x82AB5B0", VA = "0x1882AC1B0")]
	private void DOGOKPKIEMF(BalanceUpdateResponseDTO<IEMKIMGLPII> HLOOCNBHHBK, bool PEGPNABPDAJ, bool CEGHABPCHKE, bool FPDEMOLGJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x82AB790", Offset = "0x82AAB90", VA = "0x1882AB790")]
	private void ALHEJKKPNLL(NGBAACAAEGB AFIHHNCOGHA, bool ANOEJHHBELI, bool LGCPJJCHNCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x82ADDD0", Offset = "0x82AD1D0", VA = "0x1882ADDD0")]
	[AsyncStateMachine(typeof(FLEGOPBKJBA))]
	private Task KJFACGNLCIB(List<IECDCEFECPJ> IADDJJJOCPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x82AC530", Offset = "0x82AB930", VA = "0x1882AC530")]
	[CompilerGenerated]
	private void EEDDELGCHKO(BalanceUpdateResponseDTO<IEMKIMGLPII> APLCGCDLEGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x82AC530", Offset = "0x82AB930", VA = "0x1882AC530")]
	[CompilerGenerated]
	private void IMEAAEGNBOG(BalanceUpdateResponseDTO<IEMKIMGLPII> APLCGCDLEGH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class KKCLNHKELDA : KJGFHNDFGCN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly IOFFCGADLEI NHCKLABBEME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly NPIEHAMCDLN ODLOJCGPNFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly BIGJDBCHBNK FPCEPMPLIKG;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x82B0D70", Offset = "0x82B0170", VA = "0x1882B0D70")]
	[ACPGCKDGGJH.EECHBLLBGJE.IPGDONABLJD]
	internal static void BIBAMGIFFDO(NPCGGDCACLM INELJPKBMLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0xC237D0", Offset = "0xC22BD0", VA = "0x180C237D0")]
	[RecRoom.NoEngine.Common.Preserve]
	public KKCLNHKELDA([MGCCDFKFGBG(null)] IOFFCGADLEI JJEGGNDKAIG, [MGCCDFKFGBG(null)] NPIEHAMCDLN DMMDNDDDOGH, [MGCCDFKFGBG(null)] BIGJDBCHBNK MIKADHKHCBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x82B26E0", Offset = "0x82B1AE0", VA = "0x1882B26E0")]
	private bool JHMAGJOKFLB(MJFABMMHCNC FPINKFJBENA, MJFABMMHCNC KDOANEFDKKD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x82B2200", Offset = "0x82B1600", VA = "0x1882B2200", Slot = "5")]
	public IReadOnlyList<IECDCEFECPJ> HONNPPFIFIP(MJFABMMHCNC AHLCGCLKPBM, IReadOnlyList<IECDCEFECPJ> IMPJLIJJJPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x82B1590", Offset = "0x82B0990", VA = "0x1882B1590", Slot = "4")]
	public bool HLKHJIEJOPP(MJFABMMHCNC AHLCGCLKPBM, IECDCEFECPJ NNAMOJMJBHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x82B1490", Offset = "0x82B0890", VA = "0x1882B1490")]
	private bool GIOPEICKDKH(MJFABMMHCNC AHLCGCLKPBM, IECDCEFECPJ NNAMOJMJBHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x82B29A0", Offset = "0x82B1DA0", VA = "0x1882B29A0")]
	private bool OCAIJNJEONN(MJFABMMHCNC AHLCGCLKPBM, IECDCEFECPJ NNAMOJMJBHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x82B0E50", Offset = "0x82B0250", VA = "0x1882B0E50")]
	private bool CPIKNHBEPNA(MJFABMMHCNC AHLCGCLKPBM, IECDCEFECPJ NNAMOJMJBHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x82B11B0", Offset = "0x82B05B0", VA = "0x1882B11B0")]
	public bool FDEJOAIHJED(IECDCEFECPJ KGANLJLBDJG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x82B10E0", Offset = "0x82B04E0", VA = "0x1882B10E0")]
	public bool FDEJOAIHJED(KOOMIAIMMNH JHELAPHOIPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x82B2EE0", Offset = "0x82B22E0", VA = "0x1882B2EE0")]
	private bool PEOGKIODILK(Guid LHMBLLKGLHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x82B0B50", Offset = "0x82AFF50", VA = "0x1882B0B50")]
	private bool AHBPDFGCAMF(MJFABMMHCNC AHLCGCLKPBM, IECDCEFECPJ NNAMOJMJBHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x82B2630", Offset = "0x82B1A30", VA = "0x1882B2630")]
	private bool IPGLLDJJHIL(MJFABMMHCNC AHLCGCLKPBM, IECDCEFECPJ NNAMOJMJBHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x82B2930", Offset = "0x82B1D30", VA = "0x1882B2930")]
	private bool NJPPNCFGDOL(MJFABMMHCNC AHLCGCLKPBM, IECDCEFECPJ NNAMOJMJBHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x82B2CB0", Offset = "0x82B20B0", VA = "0x1882B2CB0")]
	private bool OFHBCEAKHOB(MJFABMMHCNC AHLCGCLKPBM, IECDCEFECPJ NNAMOJMJBHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x82B0DE0", Offset = "0x82B01E0", VA = "0x1882B0DE0")]
	private bool BNMJCMCMNKI(MJFABMMHCNC AHLCGCLKPBM, IECDCEFECPJ NNAMOJMJBHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x82B1520", Offset = "0x82B0920", VA = "0x1882B1520")]
	private bool GKCDGEKKDEH(MJFABMMHCNC AHLCGCLKPBM, IECDCEFECPJ NNAMOJMJBHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x82B2190", Offset = "0x82B1590", VA = "0x1882B2190")]
	private bool HOMNNCCBLIK(MJFABMMHCNC AHLCGCLKPBM, IECDCEFECPJ NNAMOJMJBHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x82B2810", Offset = "0x82B1C10", VA = "0x1882B2810")]
	private bool LCGIJFBJJJC(MJFABMMHCNC AHLCGCLKPBM, IECDCEFECPJ NNAMOJMJBHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x82B2E20", Offset = "0x82B2220", VA = "0x1882B2E20")]
	private bool ONPKDOJHEBL(MJFABMMHCNC AHLCGCLKPBM, IECDCEFECPJ NNAMOJMJBHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x82B26F0", Offset = "0x82B1AF0", VA = "0x1882B26F0")]
	private bool JIPBDEEOMGG(MJFABMMHCNC AHLCGCLKPBM, IECDCEFECPJ NNAMOJMJBHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x82B2510", Offset = "0x82B1910", VA = "0x1882B2510")]
	private bool IKFDEPAIMBO(MJFABMMHCNC AHLCGCLKPBM, IECDCEFECPJ NNAMOJMJBHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x82B0CE0", Offset = "0x82B00E0", VA = "0x1882B0CE0")]
	private bool ANKPFPKIHDE(MJFABMMHCNC AHLCGCLKPBM, IECDCEFECPJ NNAMOJMJBHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x82B2650", Offset = "0x82B1A50", VA = "0x1882B2650")]
	private bool JDLCHLJDFPN(MJFABMMHCNC AHLCGCLKPBM, IECDCEFECPJ NNAMOJMJBHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x82B2780", Offset = "0x82B1B80", VA = "0x1882B2780")]
	private bool KAKMPOJHGBE(MJFABMMHCNC AHLCGCLKPBM, IECDCEFECPJ NNAMOJMJBHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x82B2D20", Offset = "0x82B2120", VA = "0x1882B2D20")]
	private bool OHOEFLAGPBL(MJFABMMHCNC AHLCGCLKPBM, IECDCEFECPJ NNAMOJMJBHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x82B1400", Offset = "0x82B0800", VA = "0x1882B1400")]
	private bool GDCCKHFDGGM(MJFABMMHCNC AHLCGCLKPBM, IECDCEFECPJ NNAMOJMJBHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x82B0EC0", Offset = "0x82B02C0", VA = "0x1882B0EC0")]
	private bool CPJOJCKKMID(MJFABMMHCNC AHLCGCLKPBM, IECDCEFECPJ NNAMOJMJBHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x82B28A0", Offset = "0x82B1CA0", VA = "0x1882B28A0")]
	private bool LJOGPNOLPCD(MJFABMMHCNC AHLCGCLKPBM, IECDCEFECPJ NNAMOJMJBHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x82B0FC0", Offset = "0x82B03C0", VA = "0x1882B0FC0")]
	private bool DHALFNCANCG(MJFABMMHCNC AHLCGCLKPBM, IECDCEFECPJ NNAMOJMJBHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x82B0C50", Offset = "0x82B0050", VA = "0x1882B0C50")]
	private bool ALHEEHBLDOF(MJFABMMHCNC AHLCGCLKPBM, IECDCEFECPJ NNAMOJMJBHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x82B2450", Offset = "0x82B1850", VA = "0x1882B2450")]
	private bool IHKGHNMMKDC(MJFABMMHCNC AHLCGCLKPBM, IECDCEFECPJ NNAMOJMJBHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x82B0B80", Offset = "0x82AFF80", VA = "0x1882B0B80")]
	private bool AIDCFOJFEEG(MJFABMMHCNC AHLCGCLKPBM, IECDCEFECPJ NNAMOJMJBHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x82B1050", Offset = "0x82B0450", VA = "0x1882B1050")]
	private bool EONLBKLKLIJ(MJFABMMHCNC AHLCGCLKPBM, IECDCEFECPJ NNAMOJMJBHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x82B0F50", Offset = "0x82B0350", VA = "0x1882B0F50")]
	private bool DFNDKEMPKKP(MJFABMMHCNC AHLCGCLKPBM, IECDCEFECPJ NNAMOJMJBHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x82B2100", Offset = "0x82B1500", VA = "0x1882B2100")]
	private bool HLPDFMDAHJK(MJFABMMHCNC AHLCGCLKPBM, IECDCEFECPJ NNAMOJMJBHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x82B25A0", Offset = "0x82B19A0", VA = "0x1882B25A0")]
	private bool INLPPGGJMFO(MJFABMMHCNC AHLCGCLKPBM, IECDCEFECPJ NNAMOJMJBHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x82B2DB0", Offset = "0x82B21B0", VA = "0x1882B2DB0")]
	private bool OKJBNAIJJHC(MJFABMMHCNC AHLCGCLKPBM, IECDCEFECPJ NNAMOJMJBHC)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class PBFMMKCDNDG
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
	public PBFMMKCDNDG()
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
