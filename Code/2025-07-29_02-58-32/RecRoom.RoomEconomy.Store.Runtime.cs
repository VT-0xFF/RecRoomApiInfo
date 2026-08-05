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
		[Cpp2IlInjected.Address(RVA = "0x8B71C60", Offset = "0x8B70660", VA = "0x188B71C60", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2906C90", Offset = "0x2905690", VA = "0x182906C90")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class PKBKFHACFBM : AMJDBAGDGBB, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private struct GKLAOLNPICE : IAsyncStateMachine
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
		public PKBKFHACFBM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8B6BFD0", Offset = "0x8B6A9D0", VA = "0x188B6BFD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8B6C2D0", Offset = "0x8B6ACD0", VA = "0x188B6C2D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private struct GEJHACEAKOB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public AsyncTaskMethodBuilder<NEJCKGIEOFF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public PKBKFHACFBM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public Guid customAvatarItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private TaskAwaiter<NEJCKGIEOFF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8B6BC90", Offset = "0x8B6A690", VA = "0x188B6BC90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8B6BF60", Offset = "0x8B6A960", VA = "0x188B6BF60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct OEGEKGGJGBN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public AsyncTaskMethodBuilder<List<DCGEDIHFEKC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public PKBKFHACFBM <>4__this;

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
		private List<DCGEDIHFEKC> <results>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private TaskAwaiter<List<FKCOEBBJFAO>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8B6CF70", Offset = "0x8B6B970", VA = "0x188B6CF70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8B6D720", Offset = "0x8B6C120", VA = "0x188B6D720", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct EPPPKHLBLJN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public AsyncTaskMethodBuilder<List<DCGEDIHFEKC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public PKBKFHACFBM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public IReadOnlyList<LDKLCMHOOFP> unifiedItemIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public bool convertCustomAvatarItemsToPurchasableGiftDrops;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private Task <watchStorefrontTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private List<FKCOEBBJFAO> <customAvatarItems>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private List<DCGEDIHFEKC> <storeItemsInInitialOrder>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private TaskAwaiter<List<FKCOEBBJFAO>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8B68830", Offset = "0x8B67230", VA = "0x188B68830", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8B692D0", Offset = "0x8B67CD0", VA = "0x188B692D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct OGMDHNPNOBL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public AsyncTaskMethodBuilder<List<FKCOEBBJFAO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public List<FKCOEBBJFAO> customAvatarItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public PKBKFHACFBM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8B6D790", Offset = "0x8B6C190", VA = "0x188B6D790", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8B6DC90", Offset = "0x8B6C690", VA = "0x188B6DC90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class KOAHHGPMANA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public LDKLCMHOOFP id;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public KOAHHGPMANA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8B6C8B0", Offset = "0x8B6B2B0", VA = "0x188B6C8B0")]
		internal bool ODOIMDANONO(MOFDJMNJIAK x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8B6C7F0", Offset = "0x8B6B1F0", VA = "0x188B6C7F0")]
		internal bool MOLMAIKHPDO(DCGEDIHFEKC x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class LEJNNHIEIDJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public string itemFriendlyName;

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public LEJNNHIEIDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8B6C8F0", Offset = "0x8B6B2F0", VA = "0x188B6C8F0")]
		internal object HNFCMKGGKLP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class LIMDFLONGJI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public PKBKFHACFBM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public GiftItemDTO gift;

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public LIMDFLONGJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8B6C940", Offset = "0x8B6B340", VA = "0x188B6C940")]
		internal void OFENEKLBPGH(BalanceUpdateResponseDTO<NIKNBBJKNMM> result)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct DKCFGDDGANJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public AsyncTaskMethodBuilder<AMBDMJNECED<BalanceUpdateResponseDTO<NIKNBBJKNMM>>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public PKBKFHACFBM <>4__this;

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
		public FKDMLAMDOEN storefrontType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public OICCDKGHIEL currencyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private TaskAwaiter<NEJCKGIEOFF> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TaskAwaiter<AMBDMJNECED<BalanceUpdateResponseDTO<NIKNBBJKNMM>>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8B68280", Offset = "0x8B66C80", VA = "0x188B68280", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8B68780", Offset = "0x8B67180", VA = "0x188B68780", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class KBJKACCELLD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public PKBKFHACFBM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public bool handleShowGiftPackage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public bool shouldConsumeGiftBoxImmediately;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public KBJKACCELLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8B6C7B0", Offset = "0x8B6B1B0", VA = "0x188B6C7B0")]
		internal void GIMHEBGHOEM(BalanceUpdateResponseDTO<NIKNBBJKNMM> result)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class ELLMKEPNLNC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public PKBKFHACFBM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public GiftItemDTO gift;

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public ELLMKEPNLNC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8B687F0", Offset = "0x8B671F0", VA = "0x188B687F0")]
		internal void AJLACKPJNAE(BalanceUpdateResponseDTO<NIKNBBJKNMM> result)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct JNMFDIIFBEA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public AsyncTaskMethodBuilder<List<NEJCKGIEOFF>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public IReadOnlyList<Guid> itemIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public PKBKFHACFBM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private TaskAwaiter<List<KJAHAIAPOIE>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8B6C330", Offset = "0x8B6AD30", VA = "0x188B6C330", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8B6C740", Offset = "0x8B6B140", VA = "0x188B6C740", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct ODEIDDCPMPG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public List<DCGEDIHFEKC> storeItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public PKBKFHACFBM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private int <attemptNumber>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8B6C980", Offset = "0x8B6B380", VA = "0x188B6C980", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8B6CF10", Offset = "0x8B6B910", VA = "0x188B6CF10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly PFJEGDIPHEJ<Guid, NEJCKGIEOFF> LBPNNNMOFGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private KGFKJFFLCNF FHMECNNMBBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private HIADKNDPPNB LHFOJDMNFGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private FAKECEEIPGB DIPEEFGFEAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private LDODDNGNDCL NIGIOPBAAGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private ENNJHPPJHKH AJKFHJAPIHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private OADOONOPPPN LJLGJHJNHOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal JNGKBOCCLBG<Guid, NEJCKGIEOFF> DOBAOAKFFPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private bool JAFNIEKLOJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private Task PHPCIPNIBCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private CancellationTokenSource IHBEHADFIEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private List<MOFDJMNJIAK> ANFGFGLNJEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private NEMEIANKENG? LHGNIEEFJDH;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static AMJDBAGDGBB PJHDALLIBIP;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private List<MOFDJMNJIAK> LPOLCKBEKNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8B71010", Offset = "0x8B6FA10", VA = "0x188B71010")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private NEMEIANKENG MLGCMABFPHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8B6F990", Offset = "0x8B6E390", VA = "0x188B6F990")]
		get
		{
			return default(NEMEIANKENG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static AMJDBAGDGBB NDAIDGNOFDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8B6F520", Offset = "0x8B6DF20", VA = "0x188B6F520")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x8B711B0", Offset = "0x8B6FBB0", VA = "0x188B711B0")]
	private List<MOFDJMNJIAK> OLOOOEBCGNA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x8B6F7E0", Offset = "0x8B6E1E0", VA = "0x188B6F7E0")]
	[PPMDKOHJEBA.MBAKIOAAHOM.JHIOBJALHKC]
	internal static void INJFIJEPFFK(CFAMNNNCHJA JBOIKIICKBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x8B71630", Offset = "0x8B70030", VA = "0x188B71630")]
	[RecRoom.NoEngine.Common.Preserve]
	public PKBKFHACFBM([LNLOHEINMEO(null)] FAKECEEIPGB DIPEEFGFEAM, [LNLOHEINMEO(null)] KGFKJFFLCNF FHMECNNMBBF, [LNLOHEINMEO(null)] HIADKNDPPNB LHFOJDMNFGE, [LNLOHEINMEO(null)] LDODDNGNDCL NIGIOPBAAGA, [LNLOHEINMEO(null)] ENNJHPPJHKH AJKFHJAPIHN, [LNLOHEINMEO(null)] OADOONOPPPN LJLGJHJNHOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x8B6E720", Offset = "0x8B6D120", VA = "0x188B6E720", Slot = "1")]
	~PKBKFHACFBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x8B6DF50", Offset = "0x8B6C950", VA = "0x188B6DF50", Slot = "13")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x8B6DD00", Offset = "0x8B6C700", VA = "0x188B6DD00")]
	[AsyncStateMachine(typeof(GKLAOLNPICE))]
	private Task BPGCFLCKNIO(CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x8B6E5D0", Offset = "0x8B6CFD0", VA = "0x188B6E5D0")]
	public void EOMLLHLEENO(Guid LKBBCEFGAEA, NEJCKGIEOFF GCNLJKDBEJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x8B70DA0", Offset = "0x8B6F7A0", VA = "0x188B70DA0", Slot = "14")]
	public void NAOPKIFCHGA(DCGEDIHFEKC JGMLIFGKPEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x8B6F620", Offset = "0x8B6E020", VA = "0x188B6F620", Slot = "4")]
	public void IKCKPPLLEGH(IEnumerable<DCGEDIHFEKC> MJCCHEIGDII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x8B6DFC0", Offset = "0x8B6C9C0", VA = "0x188B6DFC0", Slot = "15")]
	public NEJCKGIEOFF EEMEIINPBNP(Guid DMABDIEKAKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x8B6E0D0", Offset = "0x8B6CAD0", VA = "0x188B6E0D0", Slot = "5")]
	public NEJCKGIEOFF EEMEIINPBNP(DCGEDIHFEKC JGMLIFGKPEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x8B6F880", Offset = "0x8B6E280", VA = "0x188B6F880", Slot = "16")]
	[AsyncStateMachine(typeof(GEJHACEAKOB))]
	public Task<NEJCKGIEOFF> JCKHKJEKEGJ(Guid DMABDIEKAKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x8B6DDF0", Offset = "0x8B6C7F0", VA = "0x188B6DDF0", Slot = "7")]
	[AsyncStateMachine(typeof(OEGEKGGJGBN))]
	public Task<List<DCGEDIHFEKC>> BPHPJGCGFLH(string INCHJAJPNAD, bool? DHLJKCIPFJD, bool? BAGJBHIEPJD, IEnumerable<int> PCMGCLEHKJL, bool DELJBFHOMMA, bool DFBAMFEJLHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x8B6E810", Offset = "0x8B6D210", VA = "0x188B6E810", Slot = "6")]
	public DCGEDIHFEKC GEKLKLGIKHD(LDKLCMHOOFP LKBBCEFGAEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x8B6F3E0", Offset = "0x8B6DDE0", VA = "0x188B6F3E0", Slot = "8")]
	[AsyncStateMachine(typeof(EPPPKHLBLJN))]
	public Task<List<DCGEDIHFEKC>> HJHHKACDECH(IReadOnlyList<LDKLCMHOOFP> EEIMJPALGHN, bool EHEJEHBCKDH = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x8B6FBB0", Offset = "0x8B6E5B0", VA = "0x188B6FBB0")]
	[AsyncStateMachine(typeof(OGMDHNPNOBL))]
	private Task<List<FKCOEBBJFAO>> KLBHHLFIFFJ(List<FKCOEBBJFAO> EMGBIJEAFPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x8B70780", Offset = "0x8B6F180", VA = "0x188B70780")]
	private List<DCGEDIHFEKC> MOOILCAICIC(IReadOnlyList<LDKLCMHOOFP> JGMMFFJJKDH, IReadOnlyList<MOFDJMNJIAK> PJGHIADNCJC, IReadOnlyList<DCGEDIHFEKC> EMGBIJEAFPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x8B6FE20", Offset = "0x8B6E820", VA = "0x188B6FE20", Slot = "9")]
	public DPMDGLGHBHJ<BalanceUpdateResponseDTO<NIKNBBJKNMM>> LNBKJHFLNAK(Guid DMABDIEKAKJ, long LJOHGKNMJLN, GiftItemDTO JFKANPIFAOG, OICCDKGHIEL FNONEKHIKKF = OICCDKGHIEL.RecCenterTokens, [Optional] long? JHHJEFFDCFG, FKDMLAMDOEN NMLLEDFBKMM = FKDMLAMDOEN.None)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x8B6FCC0", Offset = "0x8B6E6C0", VA = "0x188B6FCC0")]
	[AsyncStateMachine(typeof(DKCFGDDGANJ))]
	private Task<AMBDMJNECED<BalanceUpdateResponseDTO<NIKNBBJKNMM>>> LHEGMFEBBDO(Guid DMABDIEKAKJ, long LJOHGKNMJLN, GiftItemDTO JFKANPIFAOG, OICCDKGHIEL FNONEKHIKKF = OICCDKGHIEL.RecCenterTokens, [Optional] long? JHHJEFFDCFG, FKDMLAMDOEN NMLLEDFBKMM = FKDMLAMDOEN.None)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x8B6E2E0", Offset = "0x8B6CCE0", VA = "0x188B6E2E0", Slot = "10")]
	public DPMDGLGHBHJ<BalanceUpdateResponseDTO<NIKNBBJKNMM>> EFPAGIBCKLO(FKDMLAMDOEN NMLLEDFBKMM, OICCDKGHIEL FNONEKHIKKF, int LGJONAGGGAP, long LJOHGKNMJLN, long? JHHJEFFDCFG, int KPLOFCPOHJM, bool IPEMJMKBJME = false, bool FGLBCJBLDGG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x8B6EB00", Offset = "0x8B6D500", VA = "0x188B6EB00", Slot = "11")]
	public DPMDGLGHBHJ<BalanceUpdateResponseDTO<NIKNBBJKNMM>> GHBIKKLHLDJ(FKDMLAMDOEN NMLLEDFBKMM, OICCDKGHIEL FNONEKHIKKF, int LGJONAGGGAP, long LJOHGKNMJLN, long? JHHJEFFDCFG, IReadOnlyCollection<int> LGFNONIKPGA, string ONGDPODJNBL, bool PIKCIKJGCNE, APJEKMFCMFG DNAMIFDHCIH, int KPLOFCPOHJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x8B70080", Offset = "0x8B6EA80", VA = "0x188B70080", Slot = "12")]
	public DPMDGLGHBHJ<BalanceUpdateResponseDTO<NIKNBBJKNMM>> LNIFLGKIALD(FKDMLAMDOEN NMLLEDFBKMM, OICCDKGHIEL FNONEKHIKKF, IReadOnlyList<LDKLCMHOOFP> ENJMPELPIBE, IReadOnlyList<long> OCNMAFNMFLC, [Optional] long? JHHJEFFDCFG, [Optional][CanBeNull] GiftItemDTO JFKANPIFAOG, [Optional] Guid? HFPLHKPBLGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x8B70640", Offset = "0x8B6F040", VA = "0x188B70640")]
	[AsyncStateMachine(typeof(JNMFDIIFBEA))]
	private Task<List<NEJCKGIEOFF>> LOJIAAOCMDH(IReadOnlyList<Guid> ENJMPELPIBE, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x8B71320", Offset = "0x8B6FD20", VA = "0x188B71320")]
	private void PNEBCBMACJA(BalanceUpdateResponseDTO<NIKNBBJKNMM> FNAGPCFFJAJ, bool PMGEEKNCMDF, bool FGLBCJBLDGG, bool IPEMJMKBJME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x8B6F170", Offset = "0x8B6DB70", VA = "0x188B6F170")]
	private void HGFMBKKAFII(PKPHPAIKFAL JAKBHMCDMPE, bool KCKDGHCKFEO, bool IMCCIKLHDFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x8B6F070", Offset = "0x8B6DA70", VA = "0x188B6F070")]
	[AsyncStateMachine(typeof(ODEIDDCPMPG))]
	private Task GNPCJNGJMPF(List<DCGEDIHFEKC> MJCCHEIGDII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x8B70FE0", Offset = "0x8B6F9E0", VA = "0x188B70FE0")]
	[CompilerGenerated]
	private void NFJDLENDKKB(BalanceUpdateResponseDTO<NIKNBBJKNMM> AEAMJGPOBKI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class FADHGFCIGEL : AEDANMKLFGC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly ENNJHPPJHKH NKGCECOKOIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly GIJGNMIJPFI JAILHOBONNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly FALMICBHLHE FBCCMMOKLNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly HACKCJENPAN AGFBMOBIOCB;

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x8B69700", Offset = "0x8B68100", VA = "0x188B69700")]
	[PPMDKOHJEBA.MBAKIOAAHOM.JHIOBJALHKC]
	internal static void CPNCCEEHJEL(CFAMNNNCHJA JBOIKIICKBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x10D4760", Offset = "0x10D3160", VA = "0x1810D4760")]
	[RecRoom.NoEngine.Common.Preserve]
	public FADHGFCIGEL([LNLOHEINMEO(null)] ENNJHPPJHKH AJKFHJAPIHN, [LNLOHEINMEO(null)] GIJGNMIJPFI KBAKPPLFLKG, [LNLOHEINMEO(null)] FALMICBHLHE EMGBIJEAFPI, [LNLOHEINMEO(null)] HACKCJENPAN AFDCDAMIBKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x8B69560", Offset = "0x8B67F60", VA = "0x188B69560")]
	private bool CEHMGGDNBIG(ECGDCAGLEME KGKAOIGPGHJ, ECGDCAGLEME HAEKLKDCKDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x8B6B750", Offset = "0x8B6A150", VA = "0x188B6B750", Slot = "5")]
	public IReadOnlyList<DCGEDIHFEKC> NDLKNBNBGOF(ECGDCAGLEME KDFCJCGDFKM, GABBBPEHDNM EMNKKPKJDGL, IReadOnlyList<DCGEDIHFEKC> AKIPGEFJGDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x8B6A950", Offset = "0x8B69350", VA = "0x188B6A950", Slot = "4")]
	public bool MHLCGPILLFN(ECGDCAGLEME KDFCJCGDFKM, GABBBPEHDNM EMNKKPKJDGL, DCGEDIHFEKC HNLFGCKBFGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x8B69BC0", Offset = "0x8B685C0", VA = "0x188B69BC0")]
	private bool FHBHOEJOJFM(ECGDCAGLEME KDFCJCGDFKM, DCGEDIHFEKC HNLFGCKBFGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x8B69770", Offset = "0x8B68170", VA = "0x188B69770")]
	private bool DNMIGDBLMLG(ECGDCAGLEME KDFCJCGDFKM, DCGEDIHFEKC HNLFGCKBFGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x8B6BC20", Offset = "0x8B6A620", VA = "0x188B6BC20")]
	private bool OHIICOPLCND(ECGDCAGLEME KDFCJCGDFKM, DCGEDIHFEKC HNLFGCKBFGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x8B6A1B0", Offset = "0x8B68BB0", VA = "0x188B6A1B0")]
	public bool JMHFKBPJOIB(DCGEDIHFEKC JGMLIFGKPEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x8B6A400", Offset = "0x8B68E00", VA = "0x188B6A400")]
	public bool JMHFKBPJOIB(HHHICHALPEE JBMOIEEPDAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x8B6BBA0", Offset = "0x8B6A5A0", VA = "0x188B6BBA0")]
	private bool OEDPGOCPDLP(Guid DMABDIEKAKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x8B69530", Offset = "0x8B67F30", VA = "0x188B69530")]
	private bool CCNEBGCPCAM(ECGDCAGLEME KDFCJCGDFKM, DCGEDIHFEKC HNLFGCKBFGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x8B6A930", Offset = "0x8B69330", VA = "0x188B6A930")]
	private bool MELDKKAPCDH(ECGDCAGLEME KDFCJCGDFKM, DCGEDIHFEKC HNLFGCKBFGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x8B69C50", Offset = "0x8B68650", VA = "0x188B69C50")]
	private bool GGMHGAGEKHH(ECGDCAGLEME KDFCJCGDFKM, DCGEDIHFEKC HNLFGCKBFGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x8B69B50", Offset = "0x8B68550", VA = "0x188B69B50")]
	private bool EFILCBLDGGE(ECGDCAGLEME KDFCJCGDFKM, DCGEDIHFEKC HNLFGCKBFGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x8B69690", Offset = "0x8B68090", VA = "0x188B69690")]
	private bool CMLDMNDHNBJ(ECGDCAGLEME KDFCJCGDFKM, DCGEDIHFEKC HNLFGCKBFGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x8B6A140", Offset = "0x8B68B40", VA = "0x188B6A140")]
	private bool JLLLIHIBEID(ECGDCAGLEME KDFCJCGDFKM, DCGEDIHFEKC HNLFGCKBFGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x8B6B620", Offset = "0x8B6A020", VA = "0x188B6B620")]
	private bool MKODLOPNGIN(ECGDCAGLEME KDFCJCGDFKM, DCGEDIHFEKC HNLFGCKBFGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x8B69600", Offset = "0x8B68000", VA = "0x188B69600")]
	private bool CLGBOEGAOJJ(ECGDCAGLEME KDFCJCGDFKM, DCGEDIHFEKC HNLFGCKBFGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x8B6BAE0", Offset = "0x8B6A4E0", VA = "0x188B6BAE0")]
	private bool OAFJINABADK(ECGDCAGLEME KDFCJCGDFKM, DCGEDIHFEKC HNLFGCKBFGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x8B6A4D0", Offset = "0x8B68ED0", VA = "0x188B6A4D0")]
	private bool KBLLDMPIOIK(ECGDCAGLEME KDFCJCGDFKM, DCGEDIHFEKC HNLFGCKBFGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x8B69570", Offset = "0x8B67F70", VA = "0x188B69570")]
	private bool CIOLIAOHCEC(ECGDCAGLEME KDFCJCGDFKM, DCGEDIHFEKC HNLFGCKBFGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x8B6B9C0", Offset = "0x8B6A3C0", VA = "0x188B6B9C0")]
	private bool NLANPCGFCCM(ECGDCAGLEME KDFCJCGDFKM, DCGEDIHFEKC HNLFGCKBFGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x8B69DE0", Offset = "0x8B687E0", VA = "0x188B69DE0")]
	private bool HAKGGIJEHCN(ECGDCAGLEME KDFCJCGDFKM, DCGEDIHFEKC HNLFGCKBFGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x8B69D50", Offset = "0x8B68750", VA = "0x188B69D50")]
	private bool GJNHGPJOIMI(ECGDCAGLEME KDFCJCGDFKM, DCGEDIHFEKC HNLFGCKBFGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x8B6A8A0", Offset = "0x8B692A0", VA = "0x188B6A8A0")]
	private bool LLMCDNDBDPO(ECGDCAGLEME KDFCJCGDFKM, DCGEDIHFEKC HNLFGCKBFGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x8B69F00", Offset = "0x8B68900", VA = "0x188B69F00")]
	private bool HHCHJOJMCNE(ECGDCAGLEME KDFCJCGDFKM, DCGEDIHFEKC HNLFGCKBFGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x8B6BA50", Offset = "0x8B6A450", VA = "0x188B6BA50")]
	private bool NNBJJPBDCFL(ECGDCAGLEME KDFCJCGDFKM, DCGEDIHFEKC HNLFGCKBFGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x8B694A0", Offset = "0x8B67EA0", VA = "0x188B694A0")]
	private bool BAIAIMAJPJE(ECGDCAGLEME KDFCJCGDFKM, DCGEDIHFEKC HNLFGCKBFGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x8B69CC0", Offset = "0x8B686C0", VA = "0x188B69CC0")]
	private bool GHPBGBCEEPM(ECGDCAGLEME KDFCJCGDFKM, DCGEDIHFEKC HNLFGCKBFGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x8B69560", Offset = "0x8B67F60", VA = "0x188B69560")]
	private bool MIBEOLDFJCA(GABBBPEHDNM KGKAOIGPGHJ, GABBBPEHDNM HAEKLKDCKDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x8B6A5F0", Offset = "0x8B68FF0", VA = "0x188B6A5F0")]
	private bool KFBMICMLPPL(ECGDCAGLEME KDFCJCGDFKM, GABBBPEHDNM EMNKKPKJDGL, DCGEDIHFEKC HNLFGCKBFGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x8B6A810", Offset = "0x8B69210", VA = "0x188B6A810")]
	private bool LIKINCLOLIL(GABBBPEHDNM EMNKKPKJDGL, DCGEDIHFEKC HNLFGCKBFGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x8B6A020", Offset = "0x8B68A20", VA = "0x188B6A020")]
	private bool HPJDGMDJPEK(GABBBPEHDNM EMNKKPKJDGL, DCGEDIHFEKC HNLFGCKBFGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x8B6A560", Offset = "0x8B68F60", VA = "0x188B6A560")]
	private bool KEMNGMPFHGE(GABBBPEHDNM EMNKKPKJDGL, DCGEDIHFEKC HNLFGCKBFGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x8B6A0B0", Offset = "0x8B68AB0", VA = "0x188B6A0B0")]
	private bool JKCOFLOKIAF(GABBBPEHDNM EMNKKPKJDGL, DCGEDIHFEKC HNLFGCKBFGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x8B6A780", Offset = "0x8B69180", VA = "0x188B6A780")]
	private bool KLOGKADCCCG(ECGDCAGLEME KDFCJCGDFKM, DCGEDIHFEKC HNLFGCKBFGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x8B6B690", Offset = "0x8B6A090", VA = "0x188B6B690")]
	private bool NBPHCNKKIMB(ECGDCAGLEME KDFCJCGDFKM, DCGEDIHFEKC HNLFGCKBFGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x8B69340", Offset = "0x8B67D40", VA = "0x188B69340")]
	private bool ACHOCAHLFHL(ECGDCAGLEME KDFCJCGDFKM, DCGEDIHFEKC HNLFGCKBFGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x8B69F90", Offset = "0x8B68990", VA = "0x188B69F90")]
	private bool HHMEPOGHICF(ECGDCAGLEME KDFCJCGDFKM, DCGEDIHFEKC HNLFGCKBFGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x8B69A70", Offset = "0x8B68470", VA = "0x188B69A70")]
	private bool DOCLIGJLFOH(ECGDCAGLEME KDFCJCGDFKM, DCGEDIHFEKC HNLFGCKBFGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x8B69E70", Offset = "0x8B68870", VA = "0x188B69E70")]
	private bool HCCEJKOFBBC(ECGDCAGLEME KDFCJCGDFKM, DCGEDIHFEKC HNLFGCKBFGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x8B69410", Offset = "0x8B67E10", VA = "0x188B69410")]
	private bool BAGOHBONMLF(ECGDCAGLEME KDFCJCGDFKM, DCGEDIHFEKC HNLFGCKBFGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x8B69AE0", Offset = "0x8B684E0", VA = "0x188B69AE0")]
	private bool EBCOCHEKAIH(ECGDCAGLEME KDFCJCGDFKM, DCGEDIHFEKC HNLFGCKBFGI)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class IFNBIANOKDF
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public IFNBIANOKDF()
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
