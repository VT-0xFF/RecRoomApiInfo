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
		[Cpp2IlInjected.Address(RVA = "0xB3E190", Offset = "0xB3CD90", VA = "0x180B3E190")]
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
		[Cpp2IlInjected.Address(RVA = "0xB3EE00", Offset = "0xB3DA00", VA = "0x180B3EE00")]
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
		[Cpp2IlInjected.Address(RVA = "0xB3EE40", Offset = "0xB3DA40", VA = "0x180B3EE40")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[CompilerGenerated]
[EditorBrowsable(EditorBrowsableState.Never)]
[GeneratedCode("Unity.MonoScriptGenerator.MonoScriptInfoGenerator", null)]
internal class DZISONAGUEP
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
	[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
	public DZISONAGUEP()
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
		[Cpp2IlInjected.Address(RVA = "0x9251920", Offset = "0x9250520", VA = "0x189251920", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2C401F0", Offset = "0x2C3EDF0", VA = "0x182C401F0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.RoomEconomy.Store
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class KAUZUMYGAPT : HDPNCWIIQRM, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class EQBRRJLPZVW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public UnifiedItemId KGOJFCHDRGI;

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public EQBRRJLPZVW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x9247F80", Offset = "0x9246B80", VA = "0x189247F80")]
			internal bool KUJVREHFNDC(PurchasableGiftDrop a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x9247FC0", Offset = "0x9246BC0", VA = "0x189247FC0")]
			internal bool KUPCOLBCWOL(HSUCUPBTDYC a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private sealed class EQGYOQFNJHF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public string XWJYLSZQYTE;

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public EQGYOQFNJHF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x9248080", Offset = "0x9246C80", VA = "0x189248080")]
			internal object KUUJLRVAFZU()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class SOYFXWYPFQD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public KAUZUMYGAPT VISDDFDIKLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public GiftItemDTO BSWXYBORRGX;

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public SOYFXWYPFQD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x924BF20", Offset = "0x924AB20", VA = "0x18924BF20")]
			internal void YARKKTJVZZG(BalanceUpdateResponseDTO<BulkPurchaseItemsBalanceUpdateResponseDataDTO> a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class KMGJAZPMHOI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public KAUZUMYGAPT VISDDFDIKLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public bool HLYHOAFCTJW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public bool BYMHISWSMLB;

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public KMGJAZPMHOI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x924BEE0", Offset = "0x924AAE0", VA = "0x18924BEE0")]
			internal void SHNIXLLRZSS(BalanceUpdateResponseDTO<BulkPurchaseItemsBalanceUpdateResponseDataDTO> a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class JPGOKMFXYHM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public KAUZUMYGAPT VISDDFDIKLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public GiftItemDTO BSWXYBORRGX;

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public JPGOKMFXYHM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x92480D0", Offset = "0x9246CD0", VA = "0x1892480D0")]
			internal void DWKPDMEFUAB(BalanceUpdateResponseDTO<BulkPurchaseItemsBalanceUpdateResponseDataDTO> a)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private struct <GetItemPurchaseInfoAsync>d__33 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public AsyncTaskMethodBuilder<AAWMHMBXNJK> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public KAUZUMYGAPT <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public Guid customAvatarItemId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private TaskAwaiter<AAWMHMBXNJK?> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x924BF60", Offset = "0x924AB60", VA = "0x18924BF60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x924C230", Offset = "0x924AE30", VA = "0x18924C230", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private struct <GetItemPurchaseInfoServiceCall>d__44 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public AsyncTaskMethodBuilder<List<AAWMHMBXNJK>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public IReadOnlyList<Guid> itemIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public KAUZUMYGAPT <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			private TaskAwaiter<List<ItemPurchaseInfoDTO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x924C2A0", Offset = "0x924AEA0", VA = "0x18924C2A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x924C690", Offset = "0x924B290", VA = "0x18924C690", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private struct <GetSearchedCustomAvatarItems>d__34 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public AsyncTaskMethodBuilder<List<HSUCUPBTDYC>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public KAUZUMYGAPT <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public string searchQuery;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public bool? isOwned;

			[Cpp2IlInjected.FieldOffset(Offset = "0x32")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public bool? isFeatured;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public IEnumerable<int> outfitTypes;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			public bool includeCoachItems;

			[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public bool prefillResultsWithGiftBoxes;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			private List<HSUCUPBTDYC> <results>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			private TaskAwaiter<List<CustomAvatarItem>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x924C700", Offset = "0x924B300", VA = "0x18924C700", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x924CE90", Offset = "0x924BA90", VA = "0x18924CE90", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private struct <GetStoreItemsByIdsAsync>d__36 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public AsyncTaskMethodBuilder<List<HSUCUPBTDYC>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			public KAUZUMYGAPT <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			public IReadOnlyList<UnifiedItemId> unifiedItemIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			public bool convertCustomAvatarItemsToPurchasableGiftDrops;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			private Task <watchStorefrontTask>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			private List<CustomAvatarItem> <customAvatarItems>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			private List<HSUCUPBTDYC> <storeItemsInInitialOrder>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			private TaskAwaiter<List<CustomAvatarItem>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x924CF00", Offset = "0x924BB00", VA = "0x18924CF00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x924D960", Offset = "0x924C560", VA = "0x18924D960", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private struct <GetUnknownThenFilterOutUnapprovedAvatarItems>d__37 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			public AsyncTaskMethodBuilder<List<CustomAvatarItem>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			public List<CustomAvatarItem> customAvatarItems;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			public KAUZUMYGAPT <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x924D9D0", Offset = "0x924C5D0", VA = "0x18924D9D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x924DEC0", Offset = "0x924CAC0", VA = "0x18924DEC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private struct <InlineConvertItemsToPurchasableItemsIfApplicable>d__47 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			public List<HSUCUPBTDYC> storeItems;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public KAUZUMYGAPT <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			private int <attemptNumber>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x924DF30", Offset = "0x924CB30", VA = "0x18924DF30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x924E4C0", Offset = "0x924D0C0", VA = "0x18924E4C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private struct <PeriodicallyPurgeCacheTask>d__27 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public KAUZUMYGAPT <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x924E520", Offset = "0x924D120", VA = "0x18924E520", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x924E820", Offset = "0x924D420", VA = "0x18924E820", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private struct <PurchaseAvatarItemAsync>d__40 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public AsyncTaskMethodBuilder<RecNetResultObject<BalanceUpdateResponseDTO<BulkPurchaseItemsBalanceUpdateResponseDataDTO>>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public KAUZUMYGAPT <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public Guid customAvatarItemId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public long requestedPrice;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public GiftItemDTO gift;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public long? couponConsumablePlayerMappingId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public StorefrontTypes storefrontType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public CurrencyType currencyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			private TaskAwaiter<AAWMHMBXNJK> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			private TaskAwaiter<RecNetResultObject<BalanceUpdateResponseDTO<BulkPurchaseItemsBalanceUpdateResponseDataDTO>>> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x924E880", Offset = "0x924D480", VA = "0x18924E880", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x924ED70", Offset = "0x924D970", VA = "0x18924ED70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly FMPXMUVRGXL<Guid, AAWMHMBXNJK> GAETUJOFSMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private ONTHUGEFZLK WQNAFEINTEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private VJTJDKWPBTK IDSYXKSJWMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private JSVQCMRLQIG JUDUGCCBWRP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private UUVRLQLCWWV RGHRJBJHYRU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private TJADAJZHTIK OYBCJTTTCOZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private NADKVDSFRLV ODWNDRWWAAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		internal UBZYVBBYOSS<Guid, AAWMHMBXNJK> NEVXHNYDARL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private bool JDQGFFMCCEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private Task OHCFOPVVONT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private CancellationTokenSource ZFNYNKKHVVB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private List<PurchasableGiftDrop> VPUGIGNLDRY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private CustomAvatarItemSearchOrdering? FHXJXKVENSS;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static HDPNCWIIQRM FWICIAVHZHH;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private List<PurchasableGiftDrop> MBURFJAROKT
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x9249B00", Offset = "0x9248700", VA = "0x189249B00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private CustomAvatarItemSearchOrdering POUEZAIMYFT
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x924B470", Offset = "0x924A070", VA = "0x18924B470")]
			get
			{
				return default(CustomAvatarItemSearchOrdering);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public static HDPNCWIIQRM CFGULCWBBYG
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x924A410", Offset = "0x9249010", VA = "0x18924A410")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9248110", Offset = "0x9246D10", VA = "0x189248110")]
		private List<PurchasableGiftDrop> ADZXOFZBOCA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x924A510", Offset = "0x9249110", VA = "0x18924A510")]
		[IFIZWETSKCB.Session.GameOnly]
		internal static void RIWNJSDCBRY(DiContainer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x924BA90", Offset = "0x924A690", VA = "0x18924BA90")]
		[RecRoom.NoEngine.Common.Preserve]
		public KAUZUMYGAPT([Inject(null)] JSVQCMRLQIG recNetStorefronts, [Inject(null)] ONTHUGEFZLK recNetGifts, [Inject(null)] VJTJDKWPBTK recNetCustomAvatarItemsInternal, [Inject(null)] UUVRLQLCWWV giftManager, [Inject(null)] TJADAJZHTIK outfitManager, [Inject(null)] NADKVDSFRLV statsig)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x9248460", Offset = "0x9247060", VA = "0x189248460", Slot = "1")]
		~KAUZUMYGAPT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x92483F0", Offset = "0x9246FF0", VA = "0x1892483F0", Slot = "13")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x924B380", Offset = "0x9249F80", VA = "0x18924B380")]
		[AsyncStateMachine(typeof(<PeriodicallyPurgeCacheTask>d__27))]
		private Task WSXTUUBMXWM(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x92488F0", Offset = "0x92474F0", VA = "0x1892488F0")]
		public void GVNRUMVSLMG(Guid a, AAWMHMBXNJK b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x9248550", Offset = "0x9247150", VA = "0x189248550", Slot = "14")]
		public void GROTSJURBGP(HSUCUPBTDYC a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x9249CA0", Offset = "0x92488A0", VA = "0x189249CA0", Slot = "4")]
		public void OATZYFYEYAM(IEnumerable<HSUCUPBTDYC> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x924B680", Offset = "0x924A280", VA = "0x18924B680", Slot = "15")]
		public AAWMHMBXNJK YZERQKJRYKZ(Guid a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x924B790", Offset = "0x924A390", VA = "0x18924B790", Slot = "5")]
		public AAWMHMBXNJK YZERQKJRYKZ(HSUCUPBTDYC a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x9249270", Offset = "0x9247E70", VA = "0x189249270", Slot = "16")]
		[AsyncStateMachine(typeof(<GetItemPurchaseInfoAsync>d__33))]
		public Task<AAWMHMBXNJK> KDJVSLFDIFH(Guid a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x924A820", Offset = "0x9249420", VA = "0x18924A820", Slot = "7")]
		[AsyncStateMachine(typeof(<GetSearchedCustomAvatarItems>d__34))]
		public Task<List<HSUCUPBTDYC>> SCOPAAGATCA(string a, bool? b, bool? c, IEnumerable<int> d, bool e, bool f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x924B050", Offset = "0x9249C50", VA = "0x18924B050", Slot = "6")]
		public HSUCUPBTDYC VFOJZIGHLCR(UnifiedItemId a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x92496B0", Offset = "0x92482B0", VA = "0x1892496B0", Slot = "8")]
		[AsyncStateMachine(typeof(<GetStoreItemsByIdsAsync>d__36))]
		public Task<List<HSUCUPBTDYC>> NADQVFFXXQL(IReadOnlyList<UnifiedItemId> a, bool b = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x924B980", Offset = "0x924A580", VA = "0x18924B980")]
		[AsyncStateMachine(typeof(<GetUnknownThenFilterOutUnapprovedAvatarItems>d__37))]
		private Task<List<CustomAvatarItem>> ZWLHNZMPRHH(List<CustomAvatarItem> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x924A980", Offset = "0x9249580", VA = "0x18924A980")]
		private List<HSUCUPBTDYC> TTRSWMTTKUY(IReadOnlyList<UnifiedItemId> a, IReadOnlyList<PurchasableGiftDrop> b, IReadOnlyList<HSUCUPBTDYC> c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x9248A40", Offset = "0x9247640", VA = "0x189248A40", Slot = "9")]
		public EWYSBGHBSNQ<BalanceUpdateResponseDTO<BulkPurchaseItemsBalanceUpdateResponseDataDTO>> HTWYZANYRYA(Guid a, long b, GiftItemDTO c, CurrencyType d = CurrencyType.RecCenterTokens, [Optional] long? e, StorefrontTypes f = StorefrontTypes.None)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x9248790", Offset = "0x9247390", VA = "0x189248790")]
		[AsyncStateMachine(typeof(<PurchaseAvatarItemAsync>d__40))]
		private Task<RecNetResultObject<BalanceUpdateResponseDTO<BulkPurchaseItemsBalanceUpdateResponseDataDTO>>> GTXNVGWZFYM(Guid a, long b, GiftItemDTO c, CurrencyType d = CurrencyType.RecCenterTokens, [Optional] long? e, StorefrontTypes f = StorefrontTypes.None)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9249380", Offset = "0x9247F80", VA = "0x189249380", Slot = "10")]
		public EWYSBGHBSNQ<BalanceUpdateResponseDTO<BulkPurchaseItemsBalanceUpdateResponseDataDTO>> MUDTCGHVMVM(StorefrontTypes a, CurrencyType b, int c, long d, long? e, int f, bool g = false, bool h = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9249E50", Offset = "0x9248A50", VA = "0x189249E50", Slot = "11")]
		public EWYSBGHBSNQ<BalanceUpdateResponseDTO<BulkPurchaseItemsBalanceUpdateResponseDataDTO>> OEBYPFOUMFV(StorefrontTypes a, CurrencyType b, int c, long d, long? e, IReadOnlyCollection<int> f, string g, bool h, GiftContext i, int j)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9248CA0", Offset = "0x92478A0", VA = "0x189248CA0", Slot = "12")]
		public EWYSBGHBSNQ<BalanceUpdateResponseDTO<BulkPurchaseItemsBalanceUpdateResponseDataDTO>> JFWODHIPYLB(StorefrontTypes a, CurrencyType b, IReadOnlyList<UnifiedItemId> c, IReadOnlyList<long> d, [Optional] long? e, [Optional][CanBeNull] GiftItemDTO gift, [Optional] Guid? f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x92482B0", Offset = "0x9246EB0", VA = "0x1892482B0")]
		[AsyncStateMachine(typeof(<GetItemPurchaseInfoServiceCall>d__44))]
		private Task<List<AAWMHMBXNJK>> BOLHTYMSRGW(IReadOnlyList<Guid> a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x92497F0", Offset = "0x92483F0", VA = "0x1892497F0")]
		private void NKWDGSKGBZV(BalanceUpdateResponseDTO<BulkPurchaseItemsBalanceUpdateResponseDataDTO> a, bool b, bool c, bool d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x924A5B0", Offset = "0x92491B0", VA = "0x18924A5B0")]
		private void RVYKWOTRIFG(GiftPackage a, bool b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x924AF50", Offset = "0x9249B50", VA = "0x18924AF50")]
		[AsyncStateMachine(typeof(<InlineConvertItemsToPurchasableItemsIfApplicable>d__47))]
		private Task TXNCFVMDWVM(List<HSUCUPBTDYC> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x9248280", Offset = "0x9246E80", VA = "0x189248280")]
		[CompilerGenerated]
		private void BJDIUMQUXFU(BalanceUpdateResponseDTO<BulkPurchaseItemsBalanceUpdateResponseDataDTO> a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class ZDLHXJAJARG : NVKHKMOQRFR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private readonly TJADAJZHTIK AZKVMLSIWQI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private readonly ZNWGWWQQHUD LRFEJMDQSGR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private readonly CTHAAJUENRD SVOVTETSBTW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private readonly QETFABLTPHW QLKALFJMRMS;

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x9250420", Offset = "0x924F020", VA = "0x189250420")]
		[IFIZWETSKCB.Session.GameOnly]
		internal static void IFIZWETSKCB(DiContainer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x11F0770", Offset = "0x11EF370", VA = "0x1811F0770")]
		[RecRoom.NoEngine.Common.Preserve]
		public ZDLHXJAJARG([Inject(null)] TJADAJZHTIK outfitManager, [Inject(null)] ZNWGWWQQHUD storefrontManager, [Inject(null)] CTHAAJUENRD customAvatarItems, [Inject(null)] QETFABLTPHW storeBridge)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x92504B0", Offset = "0x924F0B0", VA = "0x1892504B0")]
		private bool LOKGCNXTNEI(StoreItemFilters a, StoreItemFilters b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x92509C0", Offset = "0x924F5C0", VA = "0x1892509C0", Slot = "5")]
		public IReadOnlyList<HSUCUPBTDYC> KTOWSRSLGGU(StoreItemFilters a, RoomieStoreItemFilters b, IReadOnlyList<HSUCUPBTDYC> c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x924F540", Offset = "0x924E140", VA = "0x18924F540", Slot = "4")]
		public bool EFADFPSCGJO(StoreItemFilters a, RoomieStoreItemFilters b, HSUCUPBTDYC c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x9251040", Offset = "0x924FC40", VA = "0x189251040")]
		private bool OWPGHICMGHA(StoreItemFilters a, HSUCUPBTDYC b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x9250530", Offset = "0x924F130", VA = "0x189250530")]
		private bool JMTDYFIVZPI(StoreItemFilters a, HSUCUPBTDYC b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x9250DD0", Offset = "0x924F9D0", VA = "0x189250DD0")]
		private bool MTMQGFDUOKH(StoreItemFilters a, HSUCUPBTDYC b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x924EF70", Offset = "0x924DB70", VA = "0x18924EF70")]
		public bool BGPDUEZMHHC(HSUCUPBTDYC a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x924F1C0", Offset = "0x924DDC0", VA = "0x18924F1C0")]
		public bool BGPDUEZMHHC(StorefrontGiftDrop a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x9251190", Offset = "0x924FD90", VA = "0x189251190")]
		private bool PVHWXLUKTMR(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x92510D0", Offset = "0x924FCD0", VA = "0x1892510D0")]
		private bool PTDPEPJPWKM(StoreItemFilters a, HSUCUPBTDYC b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x9250490", Offset = "0x924F090", VA = "0x189250490")]
		private bool IMXVCYMMCGN(StoreItemFilters a, HSUCUPBTDYC b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x924F280", Offset = "0x924DE80", VA = "0x18924F280")]
		private bool BIJXUCCHMUL(StoreItemFilters a, HSUCUPBTDYC b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x9250F40", Offset = "0x924FB40", VA = "0x189250F40")]
		private bool OCYARFPTYVE(StoreItemFilters a, HSUCUPBTDYC b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x9250220", Offset = "0x924EE20", VA = "0x189250220")]
		private bool HDFCHLMRYIN(StoreItemFilters a, HSUCUPBTDYC b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x9250E40", Offset = "0x924FA40", VA = "0x189250E40")]
		private bool MVFUDVCBPTW(StoreItemFilters a, HSUCUPBTDYC b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x924F380", Offset = "0x924DF80", VA = "0x18924F380")]
		private bool BLCIQTPWMMP(StoreItemFilters a, HSUCUPBTDYC b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x9250C20", Offset = "0x924F820", VA = "0x189250C20")]
		private bool LMUPTHFXIWN(StoreItemFilters a, HSUCUPBTDYC b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x924F480", Offset = "0x924E080", VA = "0x18924F480")]
		private bool DZJRYXFCEVN(StoreItemFilters a, HSUCUPBTDYC b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x924F3F0", Offset = "0x924DFF0", VA = "0x18924F3F0")]
		private bool DCEKMKRAZOR(StoreItemFilters a, HSUCUPBTDYC b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x92513C0", Offset = "0x924FFC0", VA = "0x1892513C0")]
		private bool RXIXILEDBDS(StoreItemFilters a, HSUCUPBTDYC b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x92508A0", Offset = "0x924F4A0", VA = "0x1892508A0")]
		private bool KDAFUUZMGJG(StoreItemFilters a, HSUCUPBTDYC b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x92517C0", Offset = "0x92503C0", VA = "0x1892517C0")]
		private bool XEJTXFRHIYZ(StoreItemFilters a, HSUCUPBTDYC b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x92515E0", Offset = "0x92501E0", VA = "0x1892515E0")]
		private bool SPRNIOGVUKU(StoreItemFilters a, HSUCUPBTDYC b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x9250930", Offset = "0x924F530", VA = "0x189250930")]
		private bool KJTUTCJOZCX(StoreItemFilters a, HSUCUPBTDYC b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x9250320", Offset = "0x924EF20", VA = "0x189250320")]
		private bool HVVUQEVAZUZ(StoreItemFilters a, HSUCUPBTDYC b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x9251670", Offset = "0x9250270", VA = "0x189251670")]
		private bool TYMOJNHYXDS(StoreItemFilters a, HSUCUPBTDYC b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x9250CB0", Offset = "0x924F8B0", VA = "0x189250CB0")]
		private bool LXEXRMZNWHA(StoreItemFilters a, HSUCUPBTDYC b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x9250290", Offset = "0x924EE90", VA = "0x189250290")]
		private bool HSUDWVDZTTO(StoreItemFilters a, HSUCUPBTDYC b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x92504B0", Offset = "0x924F0B0", VA = "0x1892504B0")]
		private bool IMYGLWFQZMH(RoomieStoreItemFilters a, RoomieStoreItemFilters b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x9251450", Offset = "0x9250050", VA = "0x189251450")]
		private bool RYNBZXOBSEC(StoreItemFilters a, RoomieStoreItemFilters b, HSUCUPBTDYC c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x92512A0", Offset = "0x924FEA0", VA = "0x1892512A0")]
		private bool RHGQZCJVKCT(RoomieStoreItemFilters a, HSUCUPBTDYC b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x9251330", Offset = "0x924FF30", VA = "0x189251330")]
		private bool RWKRBUULXES(RoomieStoreItemFilters a, HSUCUPBTDYC b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x9250FB0", Offset = "0x924FBB0", VA = "0x189250FB0")]
		private bool OEJUXAGTPET(RoomieStoreItemFilters a, HSUCUPBTDYC b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x924F2F0", Offset = "0x924DEF0", VA = "0x18924F2F0")]
		private bool BIWHSUPBWJE(RoomieStoreItemFilters a, HSUCUPBTDYC b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x9251100", Offset = "0x924FD00", VA = "0x189251100")]
		private bool PTOQPGBKPIG(StoreItemFilters a, HSUCUPBTDYC b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x9251700", Offset = "0x9250300", VA = "0x189251700")]
		private bool WINEKWTYQLV(StoreItemFilters a, HSUCUPBTDYC b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x9251850", Offset = "0x9250450", VA = "0x189251850")]
		private bool XVBXMPTJOPU(StoreItemFilters a, HSUCUPBTDYC b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x9250D40", Offset = "0x924F940", VA = "0x189250D40")]
		private bool MQWWJRKZKOM(StoreItemFilters a, HSUCUPBTDYC b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x92503B0", Offset = "0x924EFB0", VA = "0x1892503B0")]
		private bool HXGBGIRCKPJ(StoreItemFilters a, HSUCUPBTDYC b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x9251210", Offset = "0x924FE10", VA = "0x189251210")]
		private bool QTYMUJCHBSL(StoreItemFilters a, HSUCUPBTDYC b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x9250EB0", Offset = "0x924FAB0", VA = "0x189250EB0")]
		private bool NBQLEBVVCCK(StoreItemFilters a, HSUCUPBTDYC b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x92504C0", Offset = "0x924F0C0", VA = "0x1892504C0")]
		private bool JEYEFEVXHAM(StoreItemFilters a, HSUCUPBTDYC b)
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
