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

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xAE81C0", Offset = "0xAE6FC0", VA = "0x180AE81C0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAE8B20", Offset = "0xAE7920", VA = "0x180AE8B20")]
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
		[Cpp2IlInjected.Address(RVA = "0xAE8B60", Offset = "0xAE7960", VA = "0x180AE8B60")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[CompilerGenerated]
[EditorBrowsable(EditorBrowsableState.Never)]
[GeneratedCode("Unity.MonoScriptGenerator.MonoScriptInfoGenerator", null)]
internal class MUPXUODILAN
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
	[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
	public MUPXUODILAN()
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
		[Cpp2IlInjected.Address(RVA = "0x8D9A820", Offset = "0x8D99620", VA = "0x188D9A820", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2963E60", Offset = "0x2962C60", VA = "0x182963E60")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.Avatars.Data.Shared
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class JGBDRXOCMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8D909A0", Offset = "0x8D8F7A0", VA = "0x188D909A0")]
		public static StoreItemFilters MTLMSYRMEIB(this OutfitType a)
		{
			return default(StoreItemFilters);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8D908F0", Offset = "0x8D8F6F0", VA = "0x188D908F0")]
		public static RoomieStoreItemFilters BIHCMEVADVI(this OutfitType a)
		{
			return default(RoomieStoreItemFilters);
		}
	}
}
namespace RecRoom.RoomEconomy.Store
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class JYGOBPNPILR : XGSQIMTNZVC, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private sealed class NFLQUMCVUOO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public UnifiedItemId HPCDEAFZVKK;

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public NFLQUMCVUOO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x8D97460", Offset = "0x8D96260", VA = "0x188D97460")]
			internal bool ZAMGQJCLVOW(PurchasableGiftDrop a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x8D974A0", Offset = "0x8D962A0", VA = "0x188D974A0")]
			internal bool ZARNNPWJFAF(NSVNCQQULFO a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class NFQXRSWTDZX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public string KMGUYMWYNII;

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public NFQXRSWTDZX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x8D97560", Offset = "0x8D96360", VA = "0x188D97560")]
			internal object ZABSVVORCSE()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class ISMHEPYBEOZ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public JYGOBPNPILR WFAEFPOXIOJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public GiftItemDTO QHQQLWLDCMB;

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public ISMHEPYBEOZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x8D908B0", Offset = "0x8D8F6B0", VA = "0x188D908B0")]
			internal void VWRNNYLXCAC(BalanceUpdateResponseDTO<BulkPurchaseItemsBalanceUpdateResponseDataDTO> a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class KYRZKHTQGJA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public JYGOBPNPILR WFAEFPOXIOJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public bool CDJFOYVQQPA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public bool SUJSTEVMRZX;

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public KYRZKHTQGJA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x8D94A30", Offset = "0x8D93830", VA = "0x188D94A30")]
			internal void FRQNOVASTEE(BalanceUpdateResponseDTO<BulkPurchaseItemsBalanceUpdateResponseDataDTO> a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class LCGIDVQXTSQ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public JYGOBPNPILR WFAEFPOXIOJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public GiftItemDTO QHQQLWLDCMB;

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public LCGIDVQXTSQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x8D94A70", Offset = "0x8D93870", VA = "0x188D94A70")]
			internal void FQHTNWIYGIX(BalanceUpdateResponseDTO<BulkPurchaseItemsBalanceUpdateResponseDataDTO> a)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private struct <ConvertCustomAvatarItemsToPurchasableItemsIfApplicable>d__44 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public AsyncTaskMethodBuilder<List<NSVNCQQULFO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public List<CustomAvatarItem> customAvatarItems;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public JYGOBPNPILR <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private List<NSVNCQQULFO> <output>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x8D975B0", Offset = "0x8D963B0", VA = "0x188D975B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x8D977C0", Offset = "0x8D965C0", VA = "0x188D977C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private struct <GetItemPurchaseInfoAsync>d__33 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public AsyncTaskMethodBuilder<XIVKWLCGGPQ> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public JYGOBPNPILR <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public Guid customAvatarItemId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			private TaskAwaiter<XIVKWLCGGPQ?> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x8D97830", Offset = "0x8D96630", VA = "0x188D97830", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x8D97B00", Offset = "0x8D96900", VA = "0x188D97B00", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private struct <GetItemPurchaseInfoServiceCall>d__45 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public AsyncTaskMethodBuilder<List<XIVKWLCGGPQ>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public IReadOnlyList<Guid> itemIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public JYGOBPNPILR <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			private TaskAwaiter<List<ItemPurchaseInfoDTO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x8D97B70", Offset = "0x8D96970", VA = "0x188D97B70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x8D97F60", Offset = "0x8D96D60", VA = "0x188D97F60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private struct <GetSearchedCustomAvatarItems>d__34 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			public AsyncTaskMethodBuilder<List<NSVNCQQULFO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public JYGOBPNPILR <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			public string searchQuery;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			public bool? isOwned;

			[Cpp2IlInjected.FieldOffset(Offset = "0x32")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public bool? isFeatured;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public IEnumerable<int> outfitTypes;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public bool includeCoachItems;

			[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			public bool prefillResultsWithGiftBoxes;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			private List<NSVNCQQULFO> <results>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			private TaskAwaiter<List<CustomAvatarItem>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x8D97FD0", Offset = "0x8D96DD0", VA = "0x188D97FD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x8D98770", Offset = "0x8D97570", VA = "0x188D98770", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private struct <GetStoreItemsByIdsAsync>d__36 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			public AsyncTaskMethodBuilder<List<NSVNCQQULFO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			public JYGOBPNPILR <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			public IReadOnlyList<UnifiedItemId> unifiedItemIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public bool convertCustomAvatarItemsToPurchasableGiftDrops;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			private Task <watchStorefrontTask>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			private List<CustomAvatarItem> <customAvatarItems>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			private List<NSVNCQQULFO> <storeItemsInInitialOrder>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			private TaskAwaiter<List<CustomAvatarItem>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x8D987E0", Offset = "0x8D975E0", VA = "0x188D987E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x8D99230", Offset = "0x8D98030", VA = "0x188D99230", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private struct <GetUnknownThenFilterOutUnapprovedAvatarItems>d__37 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			public AsyncTaskMethodBuilder<List<CustomAvatarItem>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public List<CustomAvatarItem> customAvatarItems;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public JYGOBPNPILR <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x8D992A0", Offset = "0x8D980A0", VA = "0x188D992A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x8D997B0", Offset = "0x8D985B0", VA = "0x188D997B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private struct <InlineConvertItemsToPurchasableItemsIfApplicable>d__48 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public List<NSVNCQQULFO> storeItems;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public JYGOBPNPILR <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			private int <attemptNumber>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x8D99820", Offset = "0x8D98620", VA = "0x188D99820", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x8D99DA0", Offset = "0x8D98BA0", VA = "0x188D99DA0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private struct <PeriodicallyPurgeCacheTask>d__27 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public JYGOBPNPILR <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x8D99E00", Offset = "0x8D98C00", VA = "0x188D99E00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x8D9A100", Offset = "0x8D98F00", VA = "0x188D9A100", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		[CompilerGenerated]
		private struct <PurchaseAvatarItemAsync>d__40 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public AsyncTaskMethodBuilder<RecNetResultObject<BalanceUpdateResponseDTO<BulkPurchaseItemsBalanceUpdateResponseDataDTO>>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public JYGOBPNPILR <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public Guid customAvatarItemId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public long requestedPrice;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public GiftItemDTO gift;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public long? couponConsumablePlayerMappingId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public StorefrontTypes storefrontType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public CurrencyType currencyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			private TaskAwaiter<XIVKWLCGGPQ> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			private TaskAwaiter<RecNetResultObject<BalanceUpdateResponseDTO<BulkPurchaseItemsBalanceUpdateResponseDataDTO>>> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x8D9A160", Offset = "0x8D98F60", VA = "0x188D9A160", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x8D9A650", Offset = "0x8D99450", VA = "0x188D9A650", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly WXAPRKMBRBF<Guid, XIVKWLCGGPQ> JJNTLQZBVNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private YWRRCWZAAWC SQEVKQFPWBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private QHENSOZTUGK WPURWMCGPUJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private SHDIMMQKFWM MVVUKKZMXEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private FCXREHOGZPV JUSYFPPMAJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private VHELIJUXLCE KAQXEVWEWPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private DINTWZBUUTH MFUQMRTEKYC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		internal SUNTVRHFSNW<Guid, XIVKWLCGGPQ> CAHAFKHRBXR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private bool IYRJDGYKKCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private Task QIZIAUUECAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private CancellationTokenSource GEZWYVMAZVP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private List<PurchasableGiftDrop> AXXOHTLHPKY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private CustomAvatarItemSearchOrdering? MOFMVHYRAXC;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static XGSQIMTNZVC TXFHNVNCYQD;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private List<PurchasableGiftDrop> FLUOCDYVLXH
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x8D92B30", Offset = "0x8D91930", VA = "0x188D92B30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private CustomAvatarItemSearchOrdering SHGEGPNGLPZ
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x8D927C0", Offset = "0x8D915C0", VA = "0x188D927C0")]
			get
			{
				return default(CustomAvatarItemSearchOrdering);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public static XGSQIMTNZVC GUIRZRNRSLG
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x8D90E50", Offset = "0x8D8FC50", VA = "0x188D90E50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8D91670", Offset = "0x8D90470", VA = "0x188D91670")]
		private List<PurchasableGiftDrop> DVJIBJYLSCS()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8D94250", Offset = "0x8D93050", VA = "0x188D94250")]
		[FDNTPBIGLET.Session.GameOnly]
		internal static void XWYNCRUHYPG(FDTRVDFSBYT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8D945F0", Offset = "0x8D933F0", VA = "0x188D945F0")]
		[RecRoom.NoEngine.Common.Preserve]
		public JYGOBPNPILR([Inject(null)] SHDIMMQKFWM recNetStorefronts, [Inject(null)] YWRRCWZAAWC recNetGifts, [Inject(null)] QHENSOZTUGK recNetCustomAvatarItemsInternal, [Inject(null)] FCXREHOGZPV giftManager, [Inject(null)] VHELIJUXLCE outfitManager, [Inject(null)] DINTWZBUUTH statsig)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8D91960", Offset = "0x8D90760", VA = "0x188D91960", Slot = "1")]
		~JYGOBPNPILR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8D917E0", Offset = "0x8D905E0", VA = "0x188D917E0", Slot = "14")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8D90F40", Offset = "0x8D8FD40", VA = "0x188D90F40")]
		[AsyncStateMachine(typeof(<PeriodicallyPurgeCacheTask>d__27))]
		private Task AZIMHVFRFBE(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8D938A0", Offset = "0x8D926A0", VA = "0x188D938A0")]
		public void VEQPPYCZFGY(Guid a, XIVKWLCGGPQ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8D933F0", Offset = "0x8D921F0", VA = "0x188D933F0", Slot = "15")]
		public void SZZLTMRQSKJ(NSVNCQQULFO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8D91170", Offset = "0x8D8FF70", VA = "0x188D91170", Slot = "4")]
		public void DPPGTQJDXIO(IEnumerable<NSVNCQQULFO> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8D90D50", Offset = "0x8D8FB50", VA = "0x188D90D50", Slot = "16")]
		public XIVKWLCGGPQ AIXUXYEGILZ(Guid a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8D90B60", Offset = "0x8D8F960", VA = "0x188D90B60", Slot = "5")]
		public XIVKWLCGGPQ AIXUXYEGILZ(NSVNCQQULFO a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8D920C0", Offset = "0x8D90EC0", VA = "0x188D920C0", Slot = "17")]
		[AsyncStateMachine(typeof(<GetItemPurchaseInfoAsync>d__33))]
		public Task<XIVKWLCGGPQ> KHFBGSGQWJR(Guid a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8D93FB0", Offset = "0x8D92DB0", VA = "0x188D93FB0", Slot = "7")]
		[AsyncStateMachine(typeof(<GetSearchedCustomAvatarItems>d__34))]
		public Task<List<NSVNCQQULFO>> WSXPTHMVDQO(string a, bool? b, bool? c, IEnumerable<int> d, bool e, bool f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8D942F0", Offset = "0x8D930F0", VA = "0x188D942F0", Slot = "6")]
		public NSVNCQQULFO YRXBBQMULQD(UnifiedItemId a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8D91030", Offset = "0x8D8FE30", VA = "0x188D91030", Slot = "8")]
		[AsyncStateMachine(typeof(<GetStoreItemsByIdsAsync>d__36))]
		public Task<List<NSVNCQQULFO>> BYCLZOQQKXH(IReadOnlyList<UnifiedItemId> a, bool b = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8D91850", Offset = "0x8D90650", VA = "0x188D91850")]
		[AsyncStateMachine(typeof(<GetUnknownThenFilterOutUnapprovedAvatarItems>d__37))]
		private Task<List<CustomAvatarItem>> EUADEBTJCIT(List<CustomAvatarItem> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8D92D00", Offset = "0x8D91B00", VA = "0x188D92D00")]
		private List<NSVNCQQULFO> RKSVUXNEPXY(IReadOnlyList<UnifiedItemId> a, IReadOnlyList<PurchasableGiftDrop> b, IReadOnlyList<NSVNCQQULFO> c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8D91E60", Offset = "0x8D90C60", VA = "0x188D91E60", Slot = "9")]
		public YLZUVDOLRNC<BalanceUpdateResponseDTO<BulkPurchaseItemsBalanceUpdateResponseDataDTO>> IARTEIVLFSK(Guid a, long b, GiftItemDTO c, CurrencyType d = CurrencyType.RecCenterTokens, [Optional] long? e, StorefrontTypes f = StorefrontTypes.None)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8D929D0", Offset = "0x8D917D0", VA = "0x188D929D0")]
		[AsyncStateMachine(typeof(<PurchaseAvatarItemAsync>d__40))]
		private Task<RecNetResultObject<BalanceUpdateResponseDTO<BulkPurchaseItemsBalanceUpdateResponseDataDTO>>> NFJDPDJMTYS(Guid a, long b, GiftItemDTO c, CurrencyType d = CurrencyType.RecCenterTokens, [Optional] long? e, StorefrontTypes f = StorefrontTypes.None)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8D91330", Offset = "0x8D90130", VA = "0x188D91330", Slot = "10")]
		public YLZUVDOLRNC<BalanceUpdateResponseDTO<BulkPurchaseItemsBalanceUpdateResponseDataDTO>> DQPFTRZDAXW(StorefrontTypes a, CurrencyType b, int c, long d, long? e, int f, bool g = false, bool h = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8D939E0", Offset = "0x8D927E0", VA = "0x188D939E0", Slot = "11")]
		public YLZUVDOLRNC<BalanceUpdateResponseDTO<BulkPurchaseItemsBalanceUpdateResponseDataDTO>> WRYXIHJSRGV(StorefrontTypes a, CurrencyType b, int c, long d, long? e, IReadOnlyCollection<int> f, string g, bool h, GiftContext i, int j)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8D921D0", Offset = "0x8D90FD0", VA = "0x188D921D0", Slot = "12")]
		public YLZUVDOLRNC<BalanceUpdateResponseDTO<BulkPurchaseItemsBalanceUpdateResponseDataDTO>> LTUNNNUSQSJ(StorefrontTypes a, CurrencyType b, IReadOnlyList<UnifiedItemId> c, IReadOnlyList<long> d, [Optional] long? e, [Optional][CanBeNull] GiftItemDTO gift, [Optional] Guid? f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8D932D0", Offset = "0x8D920D0", VA = "0x188D932D0", Slot = "13")]
		[AsyncStateMachine(typeof(<ConvertCustomAvatarItemsToPurchasableItemsIfApplicable>d__44))]
		public Task<List<NSVNCQQULFO>> SYILUEYTSCL(List<CustomAvatarItem> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x8D94110", Offset = "0x8D92F10", VA = "0x188D94110")]
		[AsyncStateMachine(typeof(<GetItemPurchaseInfoServiceCall>d__45))]
		private Task<List<XIVKWLCGGPQ>> XADFRHHZEZG(IReadOnlyList<Guid> a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8D91A50", Offset = "0x8D90850", VA = "0x188D91A50")]
		private void HAWIWINLCVH(BalanceUpdateResponseDTO<BulkPurchaseItemsBalanceUpdateResponseDataDTO> a, bool b, bool c, bool d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8D93620", Offset = "0x8D92420", VA = "0x188D93620")]
		private void TPMPYMJFZCW(GiftPackage a, bool b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8D91D60", Offset = "0x8D90B60", VA = "0x188D91D60")]
		[AsyncStateMachine(typeof(<InlineConvertItemsToPurchasableItemsIfApplicable>d__48))]
		private Task HGVOPRDTPBW(List<NSVNCQQULFO> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8D92CD0", Offset = "0x8D91AD0", VA = "0x188D92CD0")]
		[CompilerGenerated]
		private void RIHDQBVRECQ(BalanceUpdateResponseDTO<BulkPurchaseItemsBalanceUpdateResponseDataDTO> a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class LJRXUKFYOSS : NSRZAGUZBGB
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class AFGQJODGXZR
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public LJRXUKFYOSS WFAEFPOXIOJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public RoomieStoreItemFilters SRRRJKRRXMJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public NSVNCQQULFO TRCZVHNQMBW;

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public AFGQJODGXZR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x8D90770", Offset = "0x8D8F570", VA = "0x188D90770")]
			internal bool NKCATHTGPDY(OutfitType a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private readonly VHELIJUXLCE XEHCTNVIISO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private readonly NREGPJIAXTX SRIUNQLWSWX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private readonly UOLJTZWNVKH EDWANINPNUC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private readonly DUATHTOIDXA AVBUQPZEJWM;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x8D95130", Offset = "0x8D93F30", VA = "0x188D95130")]
		[FDNTPBIGLET.Session.GameOnly]
		internal static void FDNTPBIGLET(FDTRVDFSBYT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x111AC60", Offset = "0x1119A60", VA = "0x18111AC60")]
		[RecRoom.NoEngine.Common.Preserve]
		public LJRXUKFYOSS([Inject(null)] VHELIJUXLCE outfitManager, [Inject(null)] NREGPJIAXTX storefrontManager, [Inject(null)] UOLJTZWNVKH customAvatarItems, [Inject(null)] DUATHTOIDXA storeBridge)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8D97300", Offset = "0x8D96100", VA = "0x188D97300")]
		private bool VYZSQYQTNWG(StoreItemFilters a, StoreItemFilters b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x8D97090", Offset = "0x8D95E90", VA = "0x188D97090", Slot = "5")]
		public IReadOnlyList<NSVNCQQULFO> VWOBQAURRWG(StoreItemFilters a, RoomieStoreItemFilters b, IReadOnlyList<NSVNCQQULFO> c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x8D95510", Offset = "0x8D94310", VA = "0x188D95510", Slot = "4")]
		public bool JINZESSBQBA(StoreItemFilters a, RoomieStoreItemFilters b, NSVNCQQULFO c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8D96A40", Offset = "0x8D95840", VA = "0x188D96A40")]
		private bool PVAZAUMEREQ(StoreItemFilters a, NSVNCQQULFO b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x8D96640", Offset = "0x8D95440", VA = "0x188D96640")]
		private bool ORBEQZSEFPS(StoreItemFilters a, NSVNCQQULFO b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x8D952A0", Offset = "0x8D940A0", VA = "0x188D952A0")]
		private bool GKPLAHITYQR(StoreItemFilters a, NSVNCQQULFO b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x8D94C40", Offset = "0x8D93A40", VA = "0x188D94C40")]
		public bool ANKWQOJORPY(NSVNCQQULFO a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8D94E90", Offset = "0x8D93C90", VA = "0x188D94E90")]
		public bool ANKWQOJORPY(StorefrontGiftDrop a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8D96CB0", Offset = "0x8D95AB0", VA = "0x188D96CB0")]
		private bool VHWEPQRFTYL(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x8D97430", Offset = "0x8D96230", VA = "0x188D97430")]
		private bool ZVLPEMCGODU(StoreItemFilters a, NSVNCQQULFO b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8D96590", Offset = "0x8D95390", VA = "0x188D96590")]
		private bool OMNCXVSWNBJ(StoreItemFilters a, NSVNCQQULFO b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x8D962B0", Offset = "0x8D950B0", VA = "0x188D962B0")]
		private bool JVZJFRRZVOV(StoreItemFilters a, NSVNCQQULFO b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x8D94AB0", Offset = "0x8D938B0", VA = "0x188D94AB0")]
		private bool ADWYKDUDXLC(StoreItemFilters a, NSVNCQQULFO b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x8D96240", Offset = "0x8D95040", VA = "0x188D96240")]
		private bool JVVGFRHMKED(StoreItemFilters a, NSVNCQQULFO b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x8D969D0", Offset = "0x8D957D0", VA = "0x188D969D0")]
		private bool PSKVCVQITYW(StoreItemFilters a, NSVNCQQULFO b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x8D950C0", Offset = "0x8D93EC0", VA = "0x188D950C0")]
		private bool EPOAIKLMWYR(StoreItemFilters a, NSVNCQQULFO b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x8D96440", Offset = "0x8D95240", VA = "0x188D96440")]
		private bool MMEKLGGOUDF(StoreItemFilters a, NSVNCQQULFO b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x8D96B60", Offset = "0x8D95960", VA = "0x188D96B60")]
		private bool UEUAXNMROVX(StoreItemFilters a, NSVNCQQULFO b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x8D97310", Offset = "0x8D96110", VA = "0x188D97310")]
		private bool WNUGZJFTJDN(StoreItemFilters a, NSVNCQQULFO b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8D963B0", Offset = "0x8D951B0", VA = "0x188D963B0")]
		private bool MBXNALYCOSK(StoreItemFilters a, NSVNCQQULFO b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x8D96C20", Offset = "0x8D95A20", VA = "0x188D96C20")]
		private bool UURLGGVOUBE(StoreItemFilters a, NSVNCQQULFO b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x8D95480", Offset = "0x8D94280", VA = "0x188D95480")]
		private bool IRBCDDLEFYP(StoreItemFilters a, NSVNCQQULFO b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x8D96320", Offset = "0x8D95120", VA = "0x188D96320")]
		private bool LVYVGVVFHRQ(StoreItemFilters a, NSVNCQQULFO b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x8D96AD0", Offset = "0x8D958D0", VA = "0x188D96AD0")]
		private bool SVRIBTHKCYJ(StoreItemFilters a, NSVNCQQULFO b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x8D97000", Offset = "0x8D95E00", VA = "0x188D97000")]
		private bool VNZPRFZWYYX(StoreItemFilters a, NSVNCQQULFO b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x8D95030", Offset = "0x8D93E30", VA = "0x188D95030")]
		private bool DMOYEFHHZJI(StoreItemFilters a, NSVNCQQULFO b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8D96E70", Offset = "0x8D95C70", VA = "0x188D96E70")]
		private bool VKNPIYBXXKA(StoreItemFilters a, NSVNCQQULFO b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x8D94BB0", Offset = "0x8D939B0", VA = "0x188D94BB0")]
		private bool AHVEIIHUYDU(StoreItemFilters a, NSVNCQQULFO b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x8D95310", Offset = "0x8D94110", VA = "0x188D95310")]
		private bool HNSJMZFSDWU(StoreItemFilters a, RoomieStoreItemFilters b, NSVNCQQULFO c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8D965B0", Offset = "0x8D953B0", VA = "0x188D965B0")]
		private bool OMPQXXBCKEF(RoomieStoreItemFilters a, NSVNCQQULFO b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x8D96D30", Offset = "0x8D95B30", VA = "0x188D96D30")]
		private bool VIPBARKQAYQ(RoomieStoreItemFilters a, NSVNCQQULFO b, OutfitType c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x8D96F00", Offset = "0x8D95D00", VA = "0x188D96F00")]
		private bool VNYNHYEROPQ(RoomieStoreItemFilters a, NSVNCQQULFO b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8D973A0", Offset = "0x8D961A0", VA = "0x188D973A0")]
		private bool ZTHSJXPYSPW(StoreItemFilters a, NSVNCQQULFO b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8D964D0", Offset = "0x8D952D0", VA = "0x188D964D0")]
		private bool MQIIUUMVTYZ(StoreItemFilters a, NSVNCQQULFO b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8D94F60", Offset = "0x8D93D60", VA = "0x188D94F60")]
		private bool CRYDCDOSOYA(StoreItemFilters a, NSVNCQQULFO b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x8D95210", Offset = "0x8D94010", VA = "0x188D95210")]
		private bool FZNEUQLBPGK(StoreItemFilters a, NSVNCQQULFO b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x8D951A0", Offset = "0x8D93FA0", VA = "0x188D951A0")]
		private bool FDWNZOKXGDL(StoreItemFilters a, NSVNCQQULFO b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8D94B20", Offset = "0x8D93920", VA = "0x188D94B20")]
		private bool AEGVNZTRVRH(StoreItemFilters a, NSVNCQQULFO b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8D96940", Offset = "0x8D95740", VA = "0x188D96940")]
		private bool PNJOLDCREII(StoreItemFilters a, NSVNCQQULFO b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8D961D0", Offset = "0x8D94FD0", VA = "0x188D961D0")]
		private bool JTEKSWAPRTM(StoreItemFilters a, NSVNCQQULFO b)
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
