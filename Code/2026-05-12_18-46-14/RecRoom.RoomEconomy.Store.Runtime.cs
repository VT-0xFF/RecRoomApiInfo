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
		[Cpp2IlInjected.Address(RVA = "0xD341B0", Offset = "0xD32BB0", VA = "0x180D341B0")]
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
		[Cpp2IlInjected.Address(RVA = "0xD34A80", Offset = "0xD33480", VA = "0x180D34A80")]
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
		[Cpp2IlInjected.Address(RVA = "0xD34AC0", Offset = "0xD334C0", VA = "0x180D34AC0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[CompilerGenerated]
[EditorBrowsable(EditorBrowsableState.Never)]
[GeneratedCode("Unity.MonoScriptGenerator.MonoScriptInfoGenerator", null)]
internal class TMRYTQGXOHE
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
	[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
	public TMRYTQGXOHE()
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
		[Cpp2IlInjected.Address(RVA = "0xA1B9A70", Offset = "0xA1B8470", VA = "0x18A1B9A70", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2A16AE0", Offset = "0x2A154E0", VA = "0x182A16AE0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.Avatars.Data.Shared
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class SUPLAHATLKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xA1B61D0", Offset = "0xA1B4BD0", VA = "0x18A1B61D0")]
		public static StoreItemFilters ONUOMYTTKCG(this OutfitType a)
		{
			return default(StoreItemFilters);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xA1B6120", Offset = "0xA1B4B20", VA = "0x18A1B6120")]
		public static RoomieStoreItemFilters COEMUDMDBUZ(this OutfitType a)
		{
			return default(RoomieStoreItemFilters);
		}
	}
}
namespace RecRoom.RoomEconomy.Store
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class ANIDAXYBRZA : PRJHEOOIRTF, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private sealed class FLJTJMZJRWX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public UnifiedItemId VESCSVYEOMZ;

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
			public FLJTJMZJRWX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xA1B3470", Offset = "0xA1B1E70", VA = "0x18A1B3470")]
			internal bool OPJNKSVHTLZ(PurchasableGiftDrop a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xA1B33B0", Offset = "0xA1B1DB0", VA = "0x18A1B33B0")]
			internal bool OPEGNMBKKAQ(BRRULFGEELR a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class FLEMMGFMILO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public string GTTTGIZSVCL;

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
			public FLEMMGFMILO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xA1B3360", Offset = "0xA1B1D60", VA = "0x18A1B3360")]
			internal object OPUBFGJCMIR()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class KEVPPRQXXVO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public ANIDAXYBRZA AFKVCRAYCVS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public GiftItemDTO SLABNRRITKC;

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
			public KEVPPRQXXVO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xA1B34B0", Offset = "0xA1B1EB0", VA = "0x18A1B34B0")]
			internal void MVRBOVDRROZ(BalanceUpdateResponseDTO<BulkPurchaseItemsBalanceUpdateResponseDataDTO> a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class QKZLPXVXSSX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public ANIDAXYBRZA AFKVCRAYCVS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public bool LTGQTDEBCJF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public bool AESQGURNIPK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1A")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public bool LUVLFDZDUID;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public Vector3? LDVTTSFVELJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public Quaternion? UTSYCWCIFVU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public float? QWGRXDIZFVT;

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
			public QKZLPXVXSSX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xA1B6030", Offset = "0xA1B4A30", VA = "0x18A1B6030")]
			internal void LEABQRMKMIP(BalanceUpdateResponseDTO<BulkPurchaseItemsBalanceUpdateResponseDataDTO> a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class VAWZCOQELHY
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public long LEOAWDWTERP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public StorefrontTypes AKGLYJZRYSU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public CurrencyType PCLYHCYKPEL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public long? MGEOQWDTRTC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public int BMZDANIBWIF;

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
			public VAWZCOQELHY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0xA1B9600", Offset = "0xA1B8000", VA = "0x18A1B9600")]
			internal void PMSTDNGKSFS(BalanceUpdateResponseDTO<BulkPurchaseItemsBalanceUpdateResponseDataDTO> a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class VEGDJQDXTAI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public ANIDAXYBRZA AFKVCRAYCVS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public GiftItemDTO SLABNRRITKC;

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
			public VEGDJQDXTAI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0xA1B9A30", Offset = "0xA1B8430", VA = "0x18A1B9A30")]
			internal void SFQQBHKOYNQ(BalanceUpdateResponseDTO<BulkPurchaseItemsBalanceUpdateResponseDataDTO> a)
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
			public AsyncTaskMethodBuilder<List<BRRULFGEELR>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public List<CustomAvatarItem> customAvatarItems;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public ANIDAXYBRZA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			private List<BRRULFGEELR> <output>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0xA1B6390", Offset = "0xA1B4D90", VA = "0x18A1B6390", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0xA1B65A0", Offset = "0xA1B4FA0", VA = "0x18A1B65A0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<FTODDDFOVTN> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			public ANIDAXYBRZA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public Guid customAvatarItemId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			private TaskAwaiter<FTODDDFOVTN?> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xA1B6610", Offset = "0xA1B5010", VA = "0x18A1B6610", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xA1B68E0", Offset = "0xA1B52E0", VA = "0x18A1B68E0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<List<FTODDDFOVTN>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public IReadOnlyList<Guid> itemIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public ANIDAXYBRZA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			private TaskAwaiter<List<ItemPurchaseInfoDTO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xA1B6950", Offset = "0xA1B5350", VA = "0x18A1B6950", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xA1B6D40", Offset = "0xA1B5740", VA = "0x18A1B6D40", Slot = "5")]
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
			public AsyncTaskMethodBuilder<List<BRRULFGEELR>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			public ANIDAXYBRZA <>4__this;

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
			private List<BRRULFGEELR> <results>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			private TaskAwaiter<List<CustomAvatarItem>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xA1B6DB0", Offset = "0xA1B57B0", VA = "0x18A1B6DB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0xA1B73E0", Offset = "0xA1B5DE0", VA = "0x18A1B73E0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<List<BRRULFGEELR>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public ANIDAXYBRZA <>4__this;

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
			private List<BRRULFGEELR> <storeItemsInInitialOrder>5__4;

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
			[Cpp2IlInjected.Address(RVA = "0xA1B7450", Offset = "0xA1B5E50", VA = "0x18A1B7450", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xA1B7FF0", Offset = "0xA1B69F0", VA = "0x18A1B7FF0", Slot = "5")]
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
			public ANIDAXYBRZA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xA1B8060", Offset = "0xA1B6A60", VA = "0x18A1B8060", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0xA1B8550", Offset = "0xA1B6F50", VA = "0x18A1B8550", Slot = "5")]
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
			public List<BRRULFGEELR> storeItems;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public ANIDAXYBRZA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			private int <attemptNumber>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0xA1B85C0", Offset = "0xA1B6FC0", VA = "0x18A1B85C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0xA1B8B50", Offset = "0xA1B7550", VA = "0x18A1B8B50", Slot = "5")]
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
			public ANIDAXYBRZA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0xA1B8BB0", Offset = "0xA1B75B0", VA = "0x18A1B8BB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xA1B8EB0", Offset = "0xA1B78B0", VA = "0x18A1B8EB0", Slot = "5")]
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
			public ANIDAXYBRZA <>4__this;

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
			private TaskAwaiter<FTODDDFOVTN> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			private TaskAwaiter<RecNetResultObject<BalanceUpdateResponseDTO<BulkPurchaseItemsBalanceUpdateResponseDataDTO>>> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xA1B8F10", Offset = "0xA1B7910", VA = "0x18A1B8F10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xA1B9400", Offset = "0xA1B7E00", VA = "0x18A1B9400", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly MNLGCORXIOE<Guid, FTODDDFOVTN> IACUTCCQFTG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private PEQQHDUOSKN SPFURWJYYEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private SYHGLOEMIRD WNYLSBVARBW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private ZTRLAKMWPAP QRUYNTUCFQK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private GBNUOLQFEOE IPKMEDFDHGZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private ZYZKVIZKJNR NFNXAPZIEYO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private XYNTEJINREW VIXJKUCOCQX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		internal TCLCQNCIIAT<Guid, FTODDDFOVTN> ZSIXJTWKHPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private bool MLELKNOQAUT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private Task BYVDIDBMVYI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private CancellationTokenSource GXAJWIFBSIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private List<PurchasableGiftDrop> JNIEKBRTVPR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private CustomAvatarItemSearchOrdering? EXHLPOHQJCB;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static PRJHEOOIRTF YAMBAODJEJM;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private List<PurchasableGiftDrop> JKELWAMWWIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xA1B1640", Offset = "0xA1B0040", VA = "0x18A1B1640")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private CustomAvatarItemSearchOrdering AADLKFQYVFO
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xA1B05A0", Offset = "0xA1AEFA0", VA = "0x18A1B05A0")]
			get
			{
				return default(CustomAvatarItemSearchOrdering);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public static PRJHEOOIRTF IWMDTGRRYAH
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xA1B14B0", Offset = "0xA1AFEB0", VA = "0x18A1B14B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA1B2970", Offset = "0xA1B1370", VA = "0x18A1B2970")]
		private List<PurchasableGiftDrop> ZBOIVCHIUTF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xA1B15A0", Offset = "0xA1AFFA0", VA = "0x18A1B15A0")]
		[ONTQUCAGRJW.Session.GameOnly]
		internal static void NVOLZDRLLVN(KLUMUBWDFVY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA1B2F20", Offset = "0xA1B1920", VA = "0x18A1B2F20")]
		[RecRoom.NoEngine.Common.Preserve]
		public ANIDAXYBRZA([Inject(null)] ZTRLAKMWPAP recNetStorefronts, [Inject(null)] PEQQHDUOSKN recNetGifts, [Inject(null)] SYHGLOEMIRD recNetCustomAvatarItemsInternal, [Inject(null)] GBNUOLQFEOE giftManager, [Inject(null)] ZYZKVIZKJNR outfitManager, [Inject(null)] XYNTEJINREW statsig)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA1AFB40", Offset = "0xA1AE540", VA = "0x18A1AFB40", Slot = "1")]
		~ANIDAXYBRZA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA1AF650", Offset = "0xA1AE050", VA = "0x18A1AF650", Slot = "15")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA1B2880", Offset = "0xA1B1280", VA = "0x18A1B2880")]
		[AsyncStateMachine(typeof(<PeriodicallyPurgeCacheTask>d__27))]
		private Task YNCCMNTMIAN(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xA1B1680", Offset = "0xA1B0080", VA = "0x18A1B1680")]
		public void PHOECSJUNLD(Guid a, FTODDDFOVTN b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xA1AF270", Offset = "0xA1ADC70", VA = "0x18A1AF270", Slot = "16")]
		public void CUPKNSONQFY(BRRULFGEELR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xA1AF4A0", Offset = "0xA1ADEA0", VA = "0x18A1AF4A0", Slot = "4")]
		public void DSPKTLJTKQT(IEnumerable<BRRULFGEELR> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xA1B2C30", Offset = "0xA1B1630", VA = "0x18A1B2C30", Slot = "17")]
		public FTODDDFOVTN ZQHLIZIDCBE(Guid a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xA1B2D30", Offset = "0xA1B1730", VA = "0x18A1B2D30", Slot = "5")]
		public FTODDDFOVTN ZQHLIZIDCBE(BRRULFGEELR a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xA1B2320", Offset = "0xA1B0D20", VA = "0x18A1B2320", Slot = "18")]
		[AsyncStateMachine(typeof(<GetItemPurchaseInfoAsync>d__33))]
		public Task<FTODDDFOVTN> TALJFMPEBTO(Guid a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xA1AFC30", Offset = "0xA1AE630", VA = "0x18A1AFC30", Slot = "7")]
		[AsyncStateMachine(typeof(<GetSearchedCustomAvatarItems>d__34))]
		public Task<List<BRRULFGEELR>> GetSearchedCustomAvatarItems(string searchQuery, bool? isOwned, bool? isFeatured, IEnumerable<int> outfitTypes, bool includeCoachItems, bool prefillResultsWithGiftBoxes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xA1AF7E0", Offset = "0xA1AE1E0", VA = "0x18A1AF7E0", Slot = "6")]
		public BRRULFGEELR FGCIOSPCZQY(UnifiedItemId a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xA1B07B0", Offset = "0xA1AF1B0", VA = "0x18A1B07B0", Slot = "8")]
		[AsyncStateMachine(typeof(<GetStoreItemsByIdsAsync>d__36))]
		public Task<List<BRRULFGEELR>> ITTHUHMXWEE(IReadOnlyList<UnifiedItemId> a, bool b = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xA1B0350", Offset = "0xA1AED50", VA = "0x18A1B0350")]
		[AsyncStateMachine(typeof(<GetUnknownThenFilterOutUnapprovedAvatarItems>d__37))]
		private Task<List<CustomAvatarItem>> HOOESMUIYHW(List<CustomAvatarItem> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xA1B17D0", Offset = "0xA1B01D0", VA = "0x18A1B17D0")]
		private List<BRRULFGEELR> REPOOSPDQUL(IReadOnlyList<UnifiedItemId> a, IReadOnlyList<PurchasableGiftDrop> b, IReadOnlyList<BRRULFGEELR> c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xA1B0900", Offset = "0xA1AF300", VA = "0x18A1B0900", Slot = "9")]
		public MPVTAJGPRUT<BalanceUpdateResponseDTO<BulkPurchaseItemsBalanceUpdateResponseDataDTO>> LVDJAQVMWDP(Guid a, long b, GiftItemDTO c, CurrencyType d = CurrencyType.RecCenterTokens, [Optional] long? e, StorefrontTypes f = StorefrontTypes.None)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xA1AF110", Offset = "0xA1ADB10", VA = "0x18A1AF110")]
		[AsyncStateMachine(typeof(<PurchaseAvatarItemAsync>d__40))]
		private Task<RecNetResultObject<BalanceUpdateResponseDTO<BulkPurchaseItemsBalanceUpdateResponseDataDTO>>> BVUQJGZMKQX(Guid a, long b, GiftItemDTO c, CurrencyType d = CurrencyType.RecCenterTokens, [Optional] long? e, StorefrontTypes f = StorefrontTypes.None)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xA1B1FB0", Offset = "0xA1B09B0", VA = "0x18A1B1FB0", Slot = "10")]
		public MPVTAJGPRUT<BalanceUpdateResponseDTO<BulkPurchaseItemsBalanceUpdateResponseDataDTO>> STOPQSFBMTB(StorefrontTypes a, CurrencyType b, int c, long d, long? e, int f, bool g = false, bool h = true, bool i = false, [Optional] Vector3? j, [Optional] Quaternion? k, [Optional] float? l)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xA1B1DA0", Offset = "0xA1B07A0", VA = "0x18A1B1DA0", Slot = "11")]
		public MPVTAJGPRUT<BalanceUpdateResponseDTO<BulkPurchaseItemsBalanceUpdateResponseDataDTO>> SJCZKATTVUO(StorefrontTypes a, CurrencyType b, int c, long d, long? e, int f = 1, bool g = false, bool h = true, bool i = false, [Optional] Vector3? j, [Optional] Quaternion? k, [Optional] float? l)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xA1AFD90", Offset = "0xA1AE790", VA = "0x18A1AFD90", Slot = "12")]
		public MPVTAJGPRUT<BalanceUpdateResponseDTO<BulkPurchaseItemsBalanceUpdateResponseDataDTO>> HLMUINBVBOK(StorefrontTypes a, CurrencyType b, int c, long d, long? e, IReadOnlyCollection<int> f, string g, bool h, GiftContext i, int j)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xA1B0B60", Offset = "0xA1AF560", VA = "0x18A1B0B60", Slot = "13")]
		public MPVTAJGPRUT<BalanceUpdateResponseDTO<BulkPurchaseItemsBalanceUpdateResponseDataDTO>> MBHBOMXYABC(StorefrontTypes a, CurrencyType b, IReadOnlyList<UnifiedItemId> c, IReadOnlyList<long> d, [Optional] long? e, [Optional][CanBeNull] GiftItemDTO gift, [Optional] Guid? f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xA1AF6C0", Offset = "0xA1AE0C0", VA = "0x18A1AF6C0", Slot = "14")]
		[AsyncStateMachine(typeof(<ConvertCustomAvatarItemsToPurchasableItemsIfApplicable>d__45))]
		public Task<List<BRRULFGEELR>> EYLMTICOULC(List<CustomAvatarItem> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xA1B0460", Offset = "0xA1AEE60", VA = "0x18A1B0460")]
		[AsyncStateMachine(typeof(<GetItemPurchaseInfoServiceCall>d__46))]
		private Task<List<FTODDDFOVTN>> HRKHNRQJMHB(IReadOnlyList<Guid> a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xA1B2430", Offset = "0xA1B0E30", VA = "0x18A1B2430")]
		private void UCZHMAIOKFQ(BalanceUpdateResponseDTO<BulkPurchaseItemsBalanceUpdateResponseDataDTO> a, bool b, bool c, bool d, bool e = false, [Optional] ZNVWHOXMVLK f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xA1B1130", Offset = "0xA1AFB30", VA = "0x18A1B1130")]
		private void MGYCRBINHOJ(GiftPackage a, bool b, bool c, ZNVWHOXMVLK d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xA1B2750", Offset = "0xA1B1150", VA = "0x18A1B2750")]
		[AsyncStateMachine(typeof(<InlineConvertItemsToPurchasableItemsIfApplicable>d__49))]
		private Task VRQJENOVOCX(List<BRRULFGEELR> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xA1B2850", Offset = "0xA1B1250", VA = "0x18A1B2850")]
		[CompilerGenerated]
		private void YBXBTWAEXTU(BalanceUpdateResponseDTO<BulkPurchaseItemsBalanceUpdateResponseDataDTO> a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class MZFJCZMKNFB : XXRJFKPPUHA
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[CompilerGenerated]
		private sealed class LIHWWNNFXBM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public MZFJCZMKNFB AFKVCRAYCVS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public RoomieStoreItemFilters IVNEYBTXWWQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public BRRULFGEELR JPJDSZELJGD;

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
			public LIHWWNNFXBM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0xA1B3500", Offset = "0xA1B1F00", VA = "0x18A1B3500")]
			internal bool GCUQVDMEIGV(OutfitType a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private readonly ZYZKVIZKJNR YVTEETMUYXL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private readonly QVTYUHUQZYK SJQLABXKFZG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private readonly LNAABYIASSY PGOPCLCSZER;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private readonly IDIKGPICWHX JRVNPRKDZYP;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0xA1B4E20", Offset = "0xA1B3820", VA = "0x18A1B4E20")]
		[ONTQUCAGRJW.Session.GameOnly]
		internal static void ONTQUCAGRJW(KLUMUBWDFVY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x11609F0", Offset = "0x115F3F0", VA = "0x1811609F0")]
		[RecRoom.NoEngine.Common.Preserve]
		public MZFJCZMKNFB([Inject(null)] ZYZKVIZKJNR outfitManager, [Inject(null)] QVTYUHUQZYK storefrontManager, [Inject(null)] LNAABYIASSY customAvatarItems, [Inject(null)] IDIKGPICWHX storeBridge)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xA1B4CA0", Offset = "0xA1B36A0", VA = "0x18A1B4CA0")]
		private bool NMCLXMJLPLJ(StoreItemFilters a, StoreItemFilters b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xA1B5C10", Offset = "0xA1B4610", VA = "0x18A1B5C10", Slot = "5")]
		public IReadOnlyList<BRRULFGEELR> UQJXPUFZEDV(StoreItemFilters a, RoomieStoreItemFilters b, IReadOnlyList<BRRULFGEELR> c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xA1B36D0", Offset = "0xA1B20D0", VA = "0x18A1B36D0", Slot = "4")]
		public bool BOCNHOJWTXD(StoreItemFilters a, RoomieStoreItemFilters b, BRRULFGEELR c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0xA1B4400", Offset = "0xA1B2E00", VA = "0x18A1B4400")]
		private bool DLOMAGVPFOZ(StoreItemFilters a, BRRULFGEELR b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xA1B5750", Offset = "0xA1B4150", VA = "0x18A1B5750")]
		private bool TXBBYDJSPSP(StoreItemFilters a, BRRULFGEELR b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xA1B51B0", Offset = "0xA1B3BB0", VA = "0x18A1B51B0")]
		private bool QTXXDVAPYDA(StoreItemFilters a, BRRULFGEELR b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xA1B53B0", Offset = "0xA1B3DB0", VA = "0x18A1B53B0")]
		public bool SVOSEAWDHDT(BRRULFGEELR a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xA1B5600", Offset = "0xA1B4000", VA = "0x18A1B5600")]
		public bool SVOSEAWDHDT(StorefrontGiftDrop a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xA1B5B70", Offset = "0xA1B4570", VA = "0x18A1B5B70")]
		private bool TZDAQUWCUMC(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0xA1B5040", Offset = "0xA1B3A40", VA = "0x18A1B5040")]
		private bool PWVGVWRSSPH(StoreItemFilters a, BRRULFGEELR b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0xA1B5BF0", Offset = "0xA1B45F0", VA = "0x18A1B5BF0")]
		private bool UHDXPKDWSBC(StoreItemFilters a, BRRULFGEELR b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xA1B4860", Offset = "0xA1B3260", VA = "0x18A1B4860")]
		private bool GPEFDUWLLXI(StoreItemFilters a, BRRULFGEELR b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xA1B49D0", Offset = "0xA1B33D0", VA = "0x18A1B49D0")]
		private bool IJOQXPEAPNB(StoreItemFilters a, BRRULFGEELR b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xA1B5140", Offset = "0xA1B3B40", VA = "0x18A1B5140")]
		private bool QTAIBYRVPHW(StoreItemFilters a, BRRULFGEELR b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xA1B45B0", Offset = "0xA1B2FB0", VA = "0x18A1B45B0")]
		private bool EEHSZSAILVP(StoreItemFilters a, BRRULFGEELR b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xA1B4390", Offset = "0xA1B2D90", VA = "0x18A1B4390")]
		private bool DGQZRYTMALY(StoreItemFilters a, BRRULFGEELR b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xA1B47D0", Offset = "0xA1B31D0", VA = "0x18A1B47D0")]
		private bool GOXIEGORQTC(StoreItemFilters a, BRRULFGEELR b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xA1B5F00", Offset = "0xA1B4900", VA = "0x18A1B5F00")]
		private bool VKFTVERZLRE(StoreItemFilters a, BRRULFGEELR b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xA1B3640", Offset = "0xA1B2040", VA = "0x18A1B3640")]
		private bool AUQXITBRHXK(StoreItemFilters a, BRRULFGEELR b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xA1B4740", Offset = "0xA1B3140", VA = "0x18A1B4740")]
		private bool GDXFWFRLGZX(StoreItemFilters a, BRRULFGEELR b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xA1B4490", Offset = "0xA1B2E90", VA = "0x18A1B4490")]
		private bool EAXEWSGQMYR(StoreItemFilters a, BRRULFGEELR b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0xA1B4E90", Offset = "0xA1B3890", VA = "0x18A1B4E90")]
		private bool OSRYTEPMJXO(StoreItemFilters a, BRRULFGEELR b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xA1B5E70", Offset = "0xA1B4870", VA = "0x18A1B5E70")]
		private bool UWIHPYZVPQF(StoreItemFilters a, BRRULFGEELR b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xA1B56C0", Offset = "0xA1B40C0", VA = "0x18A1B56C0")]
		private bool TJVHLHSCSKM(StoreItemFilters a, BRRULFGEELR b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xA1B4F20", Offset = "0xA1B3920", VA = "0x18A1B4F20")]
		private bool PKLIYJWMYDS(StoreItemFilters a, BRRULFGEELR b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xA1B4620", Offset = "0xA1B3020", VA = "0x18A1B4620")]
		private bool FOXBMLDQZZT(StoreItemFilters a, BRRULFGEELR b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xA1B4C10", Offset = "0xA1B3610", VA = "0x18A1B4C10")]
		private bool LYCKBJRMMLT(StoreItemFilters a, BRRULFGEELR b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA1B5320", Offset = "0xA1B3D20", VA = "0x18A1B5320")]
		private bool SNXOZTBCNZJ(StoreItemFilters a, BRRULFGEELR b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xA1B4CB0", Offset = "0xA1B36B0", VA = "0x18A1B4CB0")]
		private bool OLVOHOURQRB(StoreItemFilters a, RoomieStoreItemFilters b, BRRULFGEELR c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xA1B4FB0", Offset = "0xA1B39B0", VA = "0x18A1B4FB0")]
		private bool PLGXNGCXCOQ(RoomieStoreItemFilters a, BRRULFGEELR b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xA1B4AD0", Offset = "0xA1B34D0", VA = "0x18A1B4AD0")]
		private bool LHUFYXOLGKZ(RoomieStoreItemFilters a, BRRULFGEELR b, OutfitType c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xA1B48D0", Offset = "0xA1B32D0", VA = "0x18A1B48D0")]
		private bool GUTDOASMALH(RoomieStoreItemFilters a, BRRULFGEELR b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0xA1B5290", Offset = "0xA1B3C90", VA = "0x18A1B5290")]
		private bool SNENLVFNJVL(StoreItemFilters a, BRRULFGEELR b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xA1B5AB0", Offset = "0xA1B44B0", VA = "0x18A1B5AB0")]
		private bool TXBODPKUENO(StoreItemFilters a, BRRULFGEELR b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xA1B5070", Offset = "0xA1B3A70", VA = "0x18A1B5070")]
		private bool QBABFKNMWUD(StoreItemFilters a, BRRULFGEELR b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xA1B46B0", Offset = "0xA1B30B0", VA = "0x18A1B46B0")]
		private bool FREIYHNCZUL(StoreItemFilters a, BRRULFGEELR b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xA1B5FC0", Offset = "0xA1B49C0", VA = "0x18A1B5FC0")]
		private bool WTCQAMBDFMS(StoreItemFilters a, BRRULFGEELR b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xA1B4A40", Offset = "0xA1B3440", VA = "0x18A1B4A40")]
		private bool KOXEKWRKWBK(StoreItemFilters a, BRRULFGEELR b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xA1B4520", Offset = "0xA1B2F20", VA = "0x18A1B4520")]
		private bool EBVRRDSQSHV(StoreItemFilters a, BRRULFGEELR b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xA1B5220", Offset = "0xA1B3C20", VA = "0x18A1B5220")]
		private bool RGZMEZAJJEB(StoreItemFilters a, BRRULFGEELR b)
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
