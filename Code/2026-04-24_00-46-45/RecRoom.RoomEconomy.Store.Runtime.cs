using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using JetBrains.Annotations;
using Microsoft.CodeAnalysis;
using RecNet;
using RecRoom.Analytics.Statsig;
using RecRoom.Async;
using RecRoom.Avatars;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Initialization;
using RecRoom.NoEngine.Common;
using RecRoom.NoEngine.DataStructures.Caching;
using RecRoom.RoomEconomy.Store;
using RecRoom.Storefronts;
using UJect;
using UJect.Injection;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xD3AE50", Offset = "0xD39850", VA = "0x180D3AE50")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xD3B3B0", Offset = "0xD39DB0", VA = "0x180D3B3B0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD3B3F0", Offset = "0xD39DF0", VA = "0x180D3B3F0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[CompilerGenerated]
[EditorBrowsable(EditorBrowsableState.Never)]
[GeneratedCode("Unity.MonoScriptGenerator.MonoScriptInfoGenerator", null)]
internal class YKXBFGPKFMQ
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	private struct MonoScriptData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public byte[] FilePathsData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public byte[] TypesData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public int TotalTypes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public int TotalFiles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public bool IsEditorOnly;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
	public YKXBFGPKFMQ()
	{
	}
}
namespace _AssemblyRegistry.RecRoom_RoomEconomy_Store_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	[Obfuscation(ApplyToMembers = false)]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xA1EE200", Offset = "0xA1ECC00", VA = "0x18A1EE200", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2A2E140", Offset = "0x2A2CB40", VA = "0x182A2E140")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.Avatars.Data.Shared
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class XBVXWXHEANS
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xA1EDE40", Offset = "0xA1EC840", VA = "0x18A1EDE40")]
		public static StoreItemFilters NPMSPNFOBOA(this OutfitType a)
		{
			return default(StoreItemFilters);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xA1EE000", Offset = "0xA1ECA00", VA = "0x18A1EE000")]
		public static RoomieStoreItemFilters TWNTVIJLMNF(this OutfitType a)
		{
			return default(RoomieStoreItemFilters);
		}
	}
}
namespace RecRoom.RoomEconomy.Store
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class EBNUIOQAVMQ : OXIWAYTRFBT, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private sealed class ZXYYBHYRMKZ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public UnifiedItemId AHOEUBSZLYP;

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public ZXYYBHYRMKZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xA1EE1C0", Offset = "0xA1ECBC0", VA = "0x18A1EE1C0")]
			internal bool YAGMXWUFZXD(PurchasableGiftDrop a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xA1EE100", Offset = "0xA1ECB00", VA = "0x18A1EE100")]
			internal bool YABGAQAIQLU(RGVAIZZYLEJ a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class ZXTREBEUCZQ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public string EUXHLVVIQFT;

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public ZXTREBEUCZQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xA1EE0B0", Offset = "0xA1ECAB0", VA = "0x18A1EE0B0")]
			internal object XZVZDJGLHAL()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class PWWETPDHWHU
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public EBNUIOQAVMQ TICTAVAJHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public GiftItemDTO WGQVHZRWNWM;

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public PWWETPDHWHU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xA1E8160", Offset = "0xA1E6B60", VA = "0x18A1E8160")]
			internal void XDIRSKAAPKH(BalanceUpdateResponseDTO<BulkPurchaseItemsBalanceUpdateResponseDataDTO> a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class GJVVVMJZXYR
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public EBNUIOQAVMQ TICTAVAJHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public bool JSSMEYOJCSN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public bool AWCULGIDSFM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1A")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public bool MGJDBRTYPVD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public Vector3? CFKHWOXMGNP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public Quaternion? OYRPTTSNEIM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public float? KUBPKUPJUAD;

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public GJVVVMJZXYR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xA1E7F30", Offset = "0xA1E6930", VA = "0x18A1E7F30")]
			internal void EYNFDZXBJCN(BalanceUpdateResponseDTO<BulkPurchaseItemsBalanceUpdateResponseDataDTO> a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class AQMBBZTLGDS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public long EKRRRXHLBQX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public StorefrontTypes CAQJZYCOGTQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public CurrencyType IRMWYCBSTQB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public long? OROIKRSITLE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public int WWCUWUMPBSH;

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public AQMBBZTLGDS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0xA1E3800", Offset = "0xA1E2200", VA = "0x18A1E3800")]
			internal void PGFMGXEPPHY(BalanceUpdateResponseDTO<BulkPurchaseItemsBalanceUpdateResponseDataDTO> a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class BTYIIVPTFJQ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public EBNUIOQAVMQ TICTAVAJHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public GiftItemDTO WGQVHZRWNWM;

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public BTYIIVPTFJQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0xA1E3C40", Offset = "0xA1E2640", VA = "0x18A1E3C40")]
			internal void ZUXERFJABJK(BalanceUpdateResponseDTO<BulkPurchaseItemsBalanceUpdateResponseDataDTO> a)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private struct <ConvertCustomAvatarItemsToPurchasableItemsIfApplicable>d__45 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public AsyncTaskMethodBuilder<List<RGVAIZZYLEJ>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public List<CustomAvatarItem> customAvatarItems;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public EBNUIOQAVMQ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			private List<RGVAIZZYLEJ> <output>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0xA1E81B0", Offset = "0xA1E6BB0", VA = "0x18A1E81B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0xA1E83C0", Offset = "0xA1E6DC0", VA = "0x18A1E83C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private struct <GetItemPurchaseInfoAsync>d__33 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public AsyncTaskMethodBuilder<WYXBEHGPGKZ> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			public EBNUIOQAVMQ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public Guid customAvatarItemId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			private TaskAwaiter<WYXBEHGPGKZ?> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xA1E8430", Offset = "0xA1E6E30", VA = "0x18A1E8430", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xA1E8700", Offset = "0xA1E7100", VA = "0x18A1E8700", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private struct <GetItemPurchaseInfoServiceCall>d__46 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public AsyncTaskMethodBuilder<List<WYXBEHGPGKZ>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public IReadOnlyList<Guid> itemIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public EBNUIOQAVMQ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			private TaskAwaiter<List<ItemPurchaseInfoDTO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xA1E8770", Offset = "0xA1E7170", VA = "0x18A1E8770", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xA1E8B70", Offset = "0xA1E7570", VA = "0x18A1E8B70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private struct <GetSearchedCustomAvatarItems>d__34 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public AsyncTaskMethodBuilder<List<RGVAIZZYLEJ>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			public EBNUIOQAVMQ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			public string searchQuery;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			public bool? isOwned;

			[Cpp2IlInjected.FieldOffset(Offset = "0x32")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			public bool? isFeatured;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public IEnumerable<int> outfitTypes;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			public bool includeCoachItems;

			[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			public bool prefillResultsWithGiftBoxes;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			private List<RGVAIZZYLEJ> <results>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			private TaskAwaiter<List<CustomAvatarItem>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xA1E8BE0", Offset = "0xA1E75E0", VA = "0x18A1E8BE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0xA1E9220", Offset = "0xA1E7C20", VA = "0x18A1E9220", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private struct <GetStoreItemsByIdsAsync>d__36 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			public AsyncTaskMethodBuilder<List<RGVAIZZYLEJ>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public EBNUIOQAVMQ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public IReadOnlyList<UnifiedItemId> unifiedItemIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public bool convertCustomAvatarItemsToPurchasableGiftDrops;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			private Task <watchStorefrontTask>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			private List<CustomAvatarItem> <customAvatarItems>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			private List<RGVAIZZYLEJ> <storeItemsInInitialOrder>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			private TaskAwaiter<List<CustomAvatarItem>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			private TaskAwaiter<List<PurchasableGiftDrop>> <>u__3;

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xA1E9290", Offset = "0xA1E7C90", VA = "0x18A1E9290", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xA1E9E70", Offset = "0xA1E8870", VA = "0x18A1E9E70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private struct <GetUnknownThenFilterOutUnapprovedAvatarItems>d__37 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public AsyncTaskMethodBuilder<List<CustomAvatarItem>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public List<CustomAvatarItem> customAvatarItems;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public EBNUIOQAVMQ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xA1E9EE0", Offset = "0xA1E88E0", VA = "0x18A1E9EE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0xA1EA3F0", Offset = "0xA1E8DF0", VA = "0x18A1EA3F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private struct <InlineConvertItemsToPurchasableItemsIfApplicable>d__49 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public List<RGVAIZZYLEJ> storeItems;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public EBNUIOQAVMQ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			private int <attemptNumber>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0xA1EA460", Offset = "0xA1E8E60", VA = "0x18A1EA460", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0xA1EA9E0", Offset = "0xA1E93E0", VA = "0x18A1EA9E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		[CompilerGenerated]
		private struct <PeriodicallyPurgeCacheTask>d__27 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public EBNUIOQAVMQ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0xA1EAA40", Offset = "0xA1E9440", VA = "0x18A1EAA40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xA1EAD40", Offset = "0xA1E9740", VA = "0x18A1EAD40", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[CompilerGenerated]
		private struct <PurchaseAvatarItemAsync>d__40 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			public AsyncTaskMethodBuilder<RecNetResultObject<BalanceUpdateResponseDTO<BulkPurchaseItemsBalanceUpdateResponseDataDTO>>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			public EBNUIOQAVMQ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public Guid customAvatarItemId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public long requestedPrice;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public GiftItemDTO gift;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public long? couponConsumablePlayerMappingId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public StorefrontTypes storefrontType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public CurrencyType currencyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			private TaskAwaiter<WYXBEHGPGKZ> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			private TaskAwaiter<RecNetResultObject<BalanceUpdateResponseDTO<BulkPurchaseItemsBalanceUpdateResponseDataDTO>>> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xA1EADA0", Offset = "0xA1E97A0", VA = "0x18A1EADA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xA1EB290", Offset = "0xA1E9C90", VA = "0x18A1EB290", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly EYFPVTEQPBU<Guid, WYXBEHGPGKZ> AEYOGFWGJQC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private NDWYIVYPAVB TOJSGKKTWYS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private DDQMZQWVUXJ LPEVZTIYQWO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private DYOATXWIIJP UZUVLNGKBEU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private AGWZWBTZDHM KUMGHQNTNQH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private UXPETPKGJMZ NBYPQDWOOIY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private GXIDENQQQUA VCTNXGHSMON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		internal FWVAIRCWSGZ<Guid, WYXBEHGPGKZ> EQWEWUETPGQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private bool JHVCKNKMFHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private Task NFJECQWSGVI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private CancellationTokenSource QYEPCNEVSVI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private List<PurchasableGiftDrop> YQREKQXVIMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private CustomAvatarItemSearchOrdering? UNVDQBZUZJB;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static OXIWAYTRFBT XDUFRHRJMAY;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private List<PurchasableGiftDrop> KMURGJNVFUC
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xA1E6320", Offset = "0xA1E4D20", VA = "0x18A1E6320")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private CustomAvatarItemSearchOrdering NLCMYOLXETU
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xA1E5170", Offset = "0xA1E3B70", VA = "0x18A1E5170")]
			get
			{
				return default(CustomAvatarItemSearchOrdering);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public static OXIWAYTRFBT UIOXUQVVXGJ
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xA1E67C0", Offset = "0xA1E51C0", VA = "0x18A1E67C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA1E6B30", Offset = "0xA1E5530", VA = "0x18A1E6B30")]
		private List<PurchasableGiftDrop> WFKLFLPYGAF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xA1E4180", Offset = "0xA1E2B80", VA = "0x18A1E4180")]
		[BRMSZAJTATI.Session.GameOnly]
		internal static void FFUYQKNEPOZ(ZUKUOYIIEVW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA1E7AE0", Offset = "0xA1E64E0", VA = "0x18A1E7AE0")]
		[RecRoom.NoEngine.Common.Preserve]
		public EBNUIOQAVMQ([Inject(null)] DYOATXWIIJP recNetStorefronts, [Inject(null)] NDWYIVYPAVB recNetGifts, [Inject(null)] DDQMZQWVUXJ recNetCustomAvatarItemsInternal, [Inject(null)] AGWZWBTZDHM giftManager, [Inject(null)] UXPETPKGJMZ outfitManager, [Inject(null)] GXIDENQQQUA statsig)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA1E4220", Offset = "0xA1E2C20", VA = "0x18A1E4220", Slot = "1")]
		~EBNUIOQAVMQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA1E4110", Offset = "0xA1E2B10", VA = "0x18A1E4110", Slot = "15")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA1E6360", Offset = "0xA1E4D60", VA = "0x18A1E6360")]
		[AsyncStateMachine(typeof(<PeriodicallyPurgeCacheTask>d__27))]
		private Task VLYQSCVNYDN(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xA1E5370", Offset = "0xA1E3D70", VA = "0x18A1E5370")]
		public void OIFIDYRIFBV(Guid a, WYXBEHGPGKZ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xA1E57D0", Offset = "0xA1E41D0", VA = "0x18A1E57D0", Slot = "16")]
		public void OYQAWMGIZJS(RGVAIZZYLEJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xA1E4D40", Offset = "0xA1E3740", VA = "0x18A1E4D40", Slot = "4")]
		public void LJIECBGMDMF(IEnumerable<RGVAIZZYLEJ> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xA1E4C30", Offset = "0xA1E3630", VA = "0x18A1E4C30", Slot = "17")]
		public WYXBEHGPGKZ LDXFUCWPRZK(Guid a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xA1E4A40", Offset = "0xA1E3440", VA = "0x18A1E4A40", Slot = "5")]
		public WYXBEHGPGKZ LDXFUCWPRZK(RGVAIZZYLEJ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xA1E5060", Offset = "0xA1E3A60", VA = "0x18A1E5060", Slot = "18")]
		[AsyncStateMachine(typeof(<GetItemPurchaseInfoAsync>d__33))]
		public Task<WYXBEHGPGKZ> NLEBUAGKMCO(Guid a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xA1E48E0", Offset = "0xA1E32E0", VA = "0x18A1E48E0", Slot = "7")]
		[AsyncStateMachine(typeof(<GetSearchedCustomAvatarItems>d__34))]
		public Task<List<RGVAIZZYLEJ>> GetSearchedCustomAvatarItems(string searchQuery, bool? isOwned, bool? isFeatured, IEnumerable<int> outfitTypes, bool includeCoachItems, bool prefillResultsWithGiftBoxes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xA1E5D60", Offset = "0xA1E4760", VA = "0x18A1E5D60", Slot = "6")]
		public RGVAIZZYLEJ QQMWQLTOGUC(UnifiedItemId a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xA1E5C10", Offset = "0xA1E4610", VA = "0x18A1E5C10", Slot = "8")]
		[AsyncStateMachine(typeof(<GetStoreItemsByIdsAsync>d__36))]
		public Task<List<RGVAIZZYLEJ>> QNRFLZFDIFQ(IReadOnlyList<UnifiedItemId> a, bool b = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xA1E73E0", Offset = "0xA1E5DE0", VA = "0x18A1E73E0")]
		[AsyncStateMachine(typeof(<GetUnknownThenFilterOutUnapprovedAvatarItems>d__37))]
		private Task<List<CustomAvatarItem>> YEDZXOENMLI(List<CustomAvatarItem> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xA1E4310", Offset = "0xA1E2D10", VA = "0x18A1E4310")]
		private List<RGVAIZZYLEJ> GXHMEIEPBJH(IReadOnlyList<UnifiedItemId> a, IReadOnlyList<PurchasableGiftDrop> b, IReadOnlyList<RGVAIZZYLEJ> c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xA1E60C0", Offset = "0xA1E4AC0", VA = "0x18A1E60C0", Slot = "9")]
		public AUAMWGBNBSF<BalanceUpdateResponseDTO<BulkPurchaseItemsBalanceUpdateResponseDataDTO>> SFWNKGMNFLR(Guid a, long b, GiftItemDTO c, CurrencyType d = CurrencyType.RecCenterTokens, [Optional] long? e, StorefrontTypes f = StorefrontTypes.None)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xA1E4F00", Offset = "0xA1E3900", VA = "0x18A1E4F00")]
		[AsyncStateMachine(typeof(<PurchaseAvatarItemAsync>d__40))]
		private Task<RecNetResultObject<BalanceUpdateResponseDTO<BulkPurchaseItemsBalanceUpdateResponseDataDTO>>> MPJNFDIBGKZ(Guid a, long b, GiftItemDTO c, CurrencyType d = CurrencyType.RecCenterTokens, [Optional] long? e, StorefrontTypes f = StorefrontTypes.None)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xA1E6450", Offset = "0xA1E4E50", VA = "0x18A1E6450", Slot = "10")]
		public AUAMWGBNBSF<BalanceUpdateResponseDTO<BulkPurchaseItemsBalanceUpdateResponseDataDTO>> VPFWKGPDWWJ(StorefrontTypes a, CurrencyType b, int c, long d, long? e, int f, bool g = false, bool h = true, bool i = false, [Optional] Vector3? j, [Optional] Quaternion? k, [Optional] float? l)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xA1E5A00", Offset = "0xA1E4400", VA = "0x18A1E5A00", Slot = "11")]
		public AUAMWGBNBSF<BalanceUpdateResponseDTO<BulkPurchaseItemsBalanceUpdateResponseDataDTO>> PBLKIMDSBUE(StorefrontTypes a, CurrencyType b, int c, long d, long? e, int f = 1, bool g = false, bool h = true, bool i = false, [Optional] Vector3? j, [Optional] Quaternion? k, [Optional] float? l)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xA1E6E10", Offset = "0xA1E5810", VA = "0x18A1E6E10", Slot = "12")]
		public AUAMWGBNBSF<BalanceUpdateResponseDTO<BulkPurchaseItemsBalanceUpdateResponseDataDTO>> WOGDRNXEQEA(StorefrontTypes a, CurrencyType b, int c, long d, long? e, IReadOnlyCollection<int> f, string g, bool h, GiftContext i, int j)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xA1E74F0", Offset = "0xA1E5EF0", VA = "0x18A1E74F0", Slot = "13")]
		public AUAMWGBNBSF<BalanceUpdateResponseDTO<BulkPurchaseItemsBalanceUpdateResponseDataDTO>> YOTBNXKDZGS(StorefrontTypes a, CurrencyType b, IReadOnlyList<UnifiedItemId> c, IReadOnlyList<long> d, [Optional] long? e, [Optional][CanBeNull] GiftItemDTO gift, [Optional] Guid? f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xA1E3FF0", Offset = "0xA1E29F0", VA = "0x18A1E3FF0", Slot = "14")]
		[AsyncStateMachine(typeof(<ConvertCustomAvatarItemsToPurchasableItemsIfApplicable>d__45))]
		public Task<List<RGVAIZZYLEJ>> BMKMVBAQGJQ(List<CustomAvatarItem> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xA1E69C0", Offset = "0xA1E53C0", VA = "0x18A1E69C0")]
		[AsyncStateMachine(typeof(<GetItemPurchaseInfoServiceCall>d__46))]
		private Task<List<WYXBEHGPGKZ>> VWRFUEZNMIB(IReadOnlyList<Guid> a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xA1E54B0", Offset = "0xA1E3EB0", VA = "0x18A1E54B0")]
		private void OJNAJTCJXMU(BalanceUpdateResponseDTO<BulkPurchaseItemsBalanceUpdateResponseDataDTO> a, bool b, bool c, bool d, bool e = false, [Optional] XJAAUVQUVTM f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xA1E3C80", Offset = "0xA1E2680", VA = "0x18A1E3C80")]
		private void AYRNWKZKIYX(GiftPackage a, bool b, bool c, XJAAUVQUVTM d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xA1E68C0", Offset = "0xA1E52C0", VA = "0x18A1E68C0")]
		[AsyncStateMachine(typeof(<InlineConvertItemsToPurchasableItemsIfApplicable>d__49))]
		private Task VSCFEOKPWMZ(List<RGVAIZZYLEJ> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xA1E6B00", Offset = "0xA1E5500", VA = "0x18A1E6B00")]
		[CompilerGenerated]
		private void VZIUGKVFNME(BalanceUpdateResponseDTO<BulkPurchaseItemsBalanceUpdateResponseDataDTO> a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class WFQQJNUMUBL : XRXJKNQSORW
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[CompilerGenerated]
		private sealed class GKDQTSDTQBS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public WFQQJNUMUBL TICTAVAJHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public RoomieStoreItemFilters IHHNSEFVFJU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public RGVAIZZYLEJ GTISBUTNDPD;

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public GKDQTSDTQBS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0xA1E8020", Offset = "0xA1E6A20", VA = "0x18A1E8020")]
			internal bool WKIOWUJFEHV(OutfitType a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private readonly UXPETPKGJMZ PTDMTIAFYFZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private readonly TXDNUFJDCFG TFEGVZLHYRI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private readonly AUVIZVKCUJA FTTGBKNDBXB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private readonly OQANCHGSTQL UUQZVLBSNIV;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0xA1EB8F0", Offset = "0xA1EA2F0", VA = "0x18A1EB8F0")]
		[BRMSZAJTATI.Session.GameOnly]
		internal static void BRMSZAJTATI(ZUKUOYIIEVW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x111E6D0", Offset = "0x111D0D0", VA = "0x18111E6D0")]
		[RecRoom.NoEngine.Common.Preserve]
		public WFQQJNUMUBL([Inject(null)] UXPETPKGJMZ outfitManager, [Inject(null)] TXDNUFJDCFG storefrontManager, [Inject(null)] AUVIZVKCUJA customAvatarItems, [Inject(null)] OQANCHGSTQL storeBridge)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xA1EDA10", Offset = "0xA1EC410", VA = "0x18A1EDA10")]
		private bool UDAVLFBTTKV(StoreItemFilters a, StoreItemFilters b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xA1EBA60", Offset = "0xA1EA460", VA = "0x18A1EBA60", Slot = "5")]
		public IReadOnlyList<RGVAIZZYLEJ> CHESBMMZYMB(StoreItemFilters a, RoomieStoreItemFilters b, IReadOnlyList<RGVAIZZYLEJ> c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xA1EC760", Offset = "0xA1EB160", VA = "0x18A1EC760", Slot = "4")]
		public bool LFTOZFGGOCL(StoreItemFilters a, RoomieStoreItemFilters b, RGVAIZZYLEJ c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0xA1EBE20", Offset = "0xA1EA820", VA = "0x18A1EBE20")]
		private bool EBVZPAVMPKX(StoreItemFilters a, RGVAIZZYLEJ b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xA1EC360", Offset = "0xA1EAD60", VA = "0x18A1EC360")]
		private bool KJOYJNGELEV(StoreItemFilters a, RGVAIZZYLEJ b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xA1ED7A0", Offset = "0xA1EC1A0", VA = "0x18A1ED7A0")]
		private bool OVGSOOKGDYI(StoreItemFilters a, RGVAIZZYLEJ b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xA1EB5D0", Offset = "0xA1E9FD0", VA = "0x18A1EB5D0")]
		public bool BLPFXECEGET(RGVAIZZYLEJ a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xA1EB820", Offset = "0xA1EA220", VA = "0x18A1EB820")]
		public bool BLPFXECEGET(StorefrontGiftDrop a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xA1EDB40", Offset = "0xA1EC540", VA = "0x18A1EDB40")]
		private bool WAIJYVTLFUQ(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0xA1EB510", Offset = "0xA1E9F10", VA = "0x18A1EB510")]
		private bool BETTZVMIIZN(StoreItemFilters a, RGVAIZZYLEJ b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0xA1EDCE0", Offset = "0xA1EC6E0", VA = "0x18A1EDCE0")]
		private bool YYKKFKHOMPU(StoreItemFilters a, RGVAIZZYLEJ b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xA1EBEB0", Offset = "0xA1EA8B0", VA = "0x18A1EBEB0")]
		private bool ECFKANTHJMY(StoreItemFilters a, RGVAIZZYLEJ b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xA1EB960", Offset = "0xA1EA360", VA = "0x18A1EB960")]
		private bool BUAZHGURMOR(StoreItemFilters a, RGVAIZZYLEJ b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xA1EBFE0", Offset = "0xA1EA9E0", VA = "0x18A1EBFE0")]
		private bool EXQHALFKKEO(StoreItemFilters a, RGVAIZZYLEJ b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xA1EB4A0", Offset = "0xA1E9EA0", VA = "0x18A1EB4A0")]
		private bool AUZYVWUJICL(StoreItemFilters a, RGVAIZZYLEJ b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xA1ED810", Offset = "0xA1EC210", VA = "0x18A1ED810")]
		private bool PAPUZSKFFRC(StoreItemFilters a, RGVAIZZYLEJ b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xA1EDA20", Offset = "0xA1EC420", VA = "0x18A1EDA20")]
		private bool UGXMLLJEUES(StoreItemFilters a, RGVAIZZYLEJ b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xA1EBD60", Offset = "0xA1EA760", VA = "0x18A1EBD60")]
		private bool DKKXYLATIJC(StoreItemFilters a, RGVAIZZYLEJ b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xA1EDBC0", Offset = "0xA1EC5C0", VA = "0x18A1EDBC0")]
		private bool YAKVGDACIOO(StoreItemFilters a, RGVAIZZYLEJ b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xA1EC170", Offset = "0xA1EAB70", VA = "0x18A1EC170")]
		private bool IIQLUVGGHCL(StoreItemFilters a, RGVAIZZYLEJ b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xA1EDAB0", Offset = "0xA1EC4B0", VA = "0x18A1EDAB0")]
		private bool VYCRVOQGDYT(StoreItemFilters a, RGVAIZZYLEJ b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0xA1EC660", Offset = "0xA1EB060", VA = "0x18A1EC660")]
		private bool LCUPJCGVPQO(StoreItemFilters a, RGVAIZZYLEJ b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xA1EB540", Offset = "0xA1E9F40", VA = "0x18A1EB540")]
		private bool BHRBAAVDVYT(StoreItemFilters a, RGVAIZZYLEJ b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xA1EB9D0", Offset = "0xA1EA3D0", VA = "0x18A1EB9D0")]
		private bool CFIJKJHDGPU(StoreItemFilters a, RGVAIZZYLEJ b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xA1ED8F0", Offset = "0xA1EC2F0", VA = "0x18A1ED8F0")]
		private bool QWZRRBUXSIK(StoreItemFilters a, RGVAIZZYLEJ b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xA1EDC50", Offset = "0xA1EC650", VA = "0x18A1EDC50")]
		private bool YQXAZQZIVDB(StoreItemFilters a, RGVAIZZYLEJ b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xA1ED980", Offset = "0xA1EC380", VA = "0x18A1ED980")]
		private bool SBZCZEDXQWX(StoreItemFilters a, RGVAIZZYLEJ b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA1EC050", Offset = "0xA1EAA50", VA = "0x18A1EC050")]
		private bool FHXFLBSUPPH(StoreItemFilters a, RGVAIZZYLEJ b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xA1ED5A0", Offset = "0xA1EBFA0", VA = "0x18A1ED5A0")]
		private bool MUWFLGPASVD(StoreItemFilters a, RoomieStoreItemFilters b, RGVAIZZYLEJ c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xA1ED710", Offset = "0xA1EC110", VA = "0x18A1ED710")]
		private bool NIUHMHYJSSG(RoomieStoreItemFilters a, RGVAIZZYLEJ b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xA1EDD00", Offset = "0xA1EC700", VA = "0x18A1EDD00")]
		private bool ZLVPDLUELDN(RoomieStoreItemFilters a, RGVAIZZYLEJ b, OutfitType c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xA1ED410", Offset = "0xA1EBE10", VA = "0x18A1ED410")]
		private bool LSYJZDABQMH(RoomieStoreItemFilters a, RGVAIZZYLEJ b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0xA1ED510", Offset = "0xA1EBF10", VA = "0x18A1ED510")]
		private bool MPUXJAASGFR(StoreItemFilters a, RGVAIZZYLEJ b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xA1EBF20", Offset = "0xA1EA920", VA = "0x18A1EBF20")]
		private bool EMFCEXQVAHM(StoreItemFilters a, RGVAIZZYLEJ b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xA1EC290", Offset = "0xA1EAC90", VA = "0x18A1EC290")]
		private bool KJDRCTOQBYV(StoreItemFilters a, RGVAIZZYLEJ b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xA1EC0E0", Offset = "0xA1EAAE0", VA = "0x18A1EC0E0")]
		private bool HYRZZKATFCB(StoreItemFilters a, RGVAIZZYLEJ b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xA1ED880", Offset = "0xA1EC280", VA = "0x18A1ED880")]
		private bool PISMSKGLJGA(StoreItemFilters a, RGVAIZZYLEJ b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xA1EBCD0", Offset = "0xA1EA6D0", VA = "0x18A1EBCD0")]
		private bool CWNKTOUOTBA(StoreItemFilters a, RGVAIZZYLEJ b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xA1EC200", Offset = "0xA1EAC00", VA = "0x18A1EC200")]
		private bool IZOGGSISVYB(StoreItemFilters a, RGVAIZZYLEJ b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xA1EC6F0", Offset = "0xA1EB0F0", VA = "0x18A1EC6F0")]
		private bool LEPQOFNOXFF(StoreItemFilters a, RGVAIZZYLEJ b)
		{
			return default(bool);
		}
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
