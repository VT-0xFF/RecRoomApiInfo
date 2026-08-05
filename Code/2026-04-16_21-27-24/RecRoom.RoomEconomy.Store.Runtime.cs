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
		[Cpp2IlInjected.Address(RVA = "0xD0FDB0", Offset = "0xD0EBB0", VA = "0x180D0FDB0")]
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
		[Cpp2IlInjected.Address(RVA = "0xD10080", Offset = "0xD0EE80", VA = "0x180D10080")]
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
		[Cpp2IlInjected.Address(RVA = "0xD100C0", Offset = "0xD0EEC0", VA = "0x180D100C0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[CompilerGenerated]
[EditorBrowsable(EditorBrowsableState.Never)]
[GeneratedCode("Unity.MonoScriptGenerator.MonoScriptInfoGenerator", null)]
internal class IXBFVIJSSFJ
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
	[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
	public IXBFVIJSSFJ()
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
		[Cpp2IlInjected.Address(RVA = "0xA063EB0", Offset = "0xA062CB0", VA = "0x18A063EB0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x29EF0F0", Offset = "0x29EDEF0", VA = "0x1829EF0F0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.Avatars.Data.Shared
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class VOJOTRTSVAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xA061320", Offset = "0xA060120", VA = "0x18A061320")]
		public static StoreItemFilters MADYYCBBIDZ(this OutfitType a)
		{
			return default(StoreItemFilters);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xA061270", Offset = "0xA060070", VA = "0x18A061270")]
		public static RoomieStoreItemFilters EOCJRIKDKCM(this OutfitType a)
		{
			return default(RoomieStoreItemFilters);
		}
	}
}
namespace RecRoom.RoomEconomy.Store
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class NCLKETRUOVL : ODLLBFGOTBU, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private sealed class JBZQKAOMTYU
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public UnifiedItemId TJCXSZDZKKY;

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public JBZQKAOMTYU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xA0597C0", Offset = "0xA0585C0", VA = "0x18A0597C0")]
			internal bool WUGHVXPXGNG(PurchasableGiftDrop a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xA059800", Offset = "0xA058600", VA = "0x18A059800")]
			internal bool WULOTEJUPYP(MGOMCQBUHGC a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class JCEXHHIKDKD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public string QFNWANBGBMC;

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public JCEXHHIKDKD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xA0598C0", Offset = "0xA0586C0", VA = "0x18A0598C0")]
			internal object WUQVQLDRZJY()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class FPTOQSACGGX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public NCLKETRUOVL XRWOWCJVPDZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public GiftItemDTO VESAOKWQZTZ;

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public FPTOQSACGGX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xA059680", Offset = "0xA058480", VA = "0x18A059680")]
			internal void CGFRPMQOGLS(BalanceUpdateResponseDTO<BulkPurchaseItemsBalanceUpdateResponseDataDTO> a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class GZMCYESLXTC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public NCLKETRUOVL XRWOWCJVPDZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public bool UDWNWZVJPCI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public bool UAGDKIHWKID;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1A")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public bool OAMPPJDIDGM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public Vector3? BUBFHNGVGPY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public Quaternion? YQPQRLXVZUH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public float? GZFJJOMMOOW;

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public GZMCYESLXTC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xA0596D0", Offset = "0xA0584D0", VA = "0x18A0596D0")]
			internal void ILDVQXJXFSW(BalanceUpdateResponseDTO<BulkPurchaseItemsBalanceUpdateResponseDataDTO> a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class TUWJXWJDEHL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public long HOWLMDBVMMY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public StorefrontTypes RHIWLDXYNKV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public CurrencyType BUNEZZKLAPE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public long? ZMJEAAHUNZX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public int MNGJAMSAHEE;

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public TUWJXWJDEHL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0xA05DB90", Offset = "0xA05C990", VA = "0x18A05DB90")]
			internal void YPDICRXZRTJ(BalanceUpdateResponseDTO<BulkPurchaseItemsBalanceUpdateResponseDataDTO> a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class LIXDUMZZAJB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public NCLKETRUOVL XRWOWCJVPDZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public GiftItemDTO VESAOKWQZTZ;

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public LIXDUMZZAJB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0xA059910", Offset = "0xA058710", VA = "0x18A059910")]
			internal void MGMBKZRNQAN(BalanceUpdateResponseDTO<BulkPurchaseItemsBalanceUpdateResponseDataDTO> a)
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
			public AsyncTaskMethodBuilder<List<MGOMCQBUHGC>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public List<CustomAvatarItem> customAvatarItems;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public NCLKETRUOVL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			private List<MGOMCQBUHGC> <output>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0xA05DFD0", Offset = "0xA05CDD0", VA = "0x18A05DFD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0xA05E1E0", Offset = "0xA05CFE0", VA = "0x18A05E1E0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<AXIUZBXADAA> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			public NCLKETRUOVL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public Guid customAvatarItemId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			private TaskAwaiter<AXIUZBXADAA?> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xA05E250", Offset = "0xA05D050", VA = "0x18A05E250", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xA05E520", Offset = "0xA05D320", VA = "0x18A05E520", Slot = "5")]
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
			public AsyncTaskMethodBuilder<List<AXIUZBXADAA>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public IReadOnlyList<Guid> itemIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public NCLKETRUOVL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			private TaskAwaiter<List<ItemPurchaseInfoDTO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xA05E590", Offset = "0xA05D390", VA = "0x18A05E590", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xA05E980", Offset = "0xA05D780", VA = "0x18A05E980", Slot = "5")]
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
			public AsyncTaskMethodBuilder<List<MGOMCQBUHGC>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			public NCLKETRUOVL <>4__this;

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
			private List<MGOMCQBUHGC> <results>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			private TaskAwaiter<List<CustomAvatarItem>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xA05E9F0", Offset = "0xA05D7F0", VA = "0x18A05E9F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0xA05F020", Offset = "0xA05DE20", VA = "0x18A05F020", Slot = "5")]
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
			public AsyncTaskMethodBuilder<List<MGOMCQBUHGC>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public NCLKETRUOVL <>4__this;

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
			private List<MGOMCQBUHGC> <storeItemsInInitialOrder>5__4;

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
			[Cpp2IlInjected.Address(RVA = "0xA05F090", Offset = "0xA05DE90", VA = "0x18A05F090", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xA05FC70", Offset = "0xA05EA70", VA = "0x18A05FC70", Slot = "5")]
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
			public NCLKETRUOVL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xA05FCE0", Offset = "0xA05EAE0", VA = "0x18A05FCE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0xA0601D0", Offset = "0xA05EFD0", VA = "0x18A0601D0", Slot = "5")]
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
			public List<MGOMCQBUHGC> storeItems;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public NCLKETRUOVL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			private int <attemptNumber>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0xA060240", Offset = "0xA05F040", VA = "0x18A060240", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0xA0607C0", Offset = "0xA05F5C0", VA = "0x18A0607C0", Slot = "5")]
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
			public NCLKETRUOVL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0xA060820", Offset = "0xA05F620", VA = "0x18A060820", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xA060B20", Offset = "0xA05F920", VA = "0x18A060B20", Slot = "5")]
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
			public NCLKETRUOVL <>4__this;

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
			private TaskAwaiter<AXIUZBXADAA> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			private TaskAwaiter<RecNetResultObject<BalanceUpdateResponseDTO<BulkPurchaseItemsBalanceUpdateResponseDataDTO>>> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xA060B80", Offset = "0xA05F980", VA = "0x18A060B80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xA061070", Offset = "0xA05FE70", VA = "0x18A061070", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly UQDTLASZWDH<Guid, AXIUZBXADAA> CYHTUCANVZN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private GXQDDUADVVS GXKUGBOAHRJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private YHGICGVLXJK DVEGDCLYGWP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private BDWBDCBOPVM YPWULAVXQKR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private TZWLJGXBICZ HDTEYDKDJOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private ZTRGYEFJHNU ASEPTXKOQXD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private SOLRGSEENKD HWZGIQVSYVK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		internal ERQEZVDMCAS<Guid, AXIUZBXADAA> SMUVEUMNZCR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private bool DZPJVTCESGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private Task WKTBJOCSQVP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private CancellationTokenSource MKXSCXNAVPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private List<PurchasableGiftDrop> IQDDKCFNIFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private CustomAvatarItemSearchOrdering? YWBXJYMFESK;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static ODLLBFGOTBU HBCZULAESVD;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private List<PurchasableGiftDrop> DTAROHNXTJN
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xA059950", Offset = "0xA058750", VA = "0x18A059950")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private CustomAvatarItemSearchOrdering TRTVLAFKRAN
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xA05A870", Offset = "0xA059670", VA = "0x18A05A870")]
			get
			{
				return default(CustomAvatarItemSearchOrdering);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public static ODLLBFGOTBU GFQGJWBHKJM
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xA05C1D0", Offset = "0xA05AFD0", VA = "0x18A05C1D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA05B4E0", Offset = "0xA05A2E0", VA = "0x18A05B4E0")]
		private List<PurchasableGiftDrop> MHUMZTOOSSU()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xA059FB0", Offset = "0xA058DB0", VA = "0x18A059FB0")]
		[CXDXQIFYXBD.Session.GameOnly]
		internal static void EOQBVPFENUW(MZEBANDYSXL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA05D740", Offset = "0xA05C540", VA = "0x18A05D740")]
		[RecRoom.NoEngine.Common.Preserve]
		public NCLKETRUOVL([Inject(null)] BDWBDCBOPVM recNetStorefronts, [Inject(null)] GXQDDUADVVS recNetGifts, [Inject(null)] YHGICGVLXJK recNetCustomAvatarItemsInternal, [Inject(null)] TZWLJGXBICZ giftManager, [Inject(null)] ZTRGYEFJHNU outfitManager, [Inject(null)] SOLRGSEENKD statsig)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA05A620", Offset = "0xA059420", VA = "0x18A05A620", Slot = "1")]
		~NCLKETRUOVL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA059F40", Offset = "0xA058D40", VA = "0x18A059F40", Slot = "15")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA05C2D0", Offset = "0xA05B0D0", VA = "0x18A05C2D0")]
		[AsyncStateMachine(typeof(<PeriodicallyPurgeCacheTask>d__27))]
		private Task RHWUOTLVKUQ(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xA05B080", Offset = "0xA059E80", VA = "0x18A05B080")]
		public void JTMXALZERJY(Guid a, AXIUZBXADAA b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xA05BFA0", Offset = "0xA05ADA0", VA = "0x18A05BFA0", Slot = "16")]
		public void PTQGPLDCRHJ(MGOMCQBUHGC a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xA05C6F0", Offset = "0xA05B4F0", VA = "0x18A05C6F0", Slot = "4")]
		public void RPFRHCFXRMM(IEnumerable<MGOMCQBUHGC> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xA05C3F0", Offset = "0xA05B1F0", VA = "0x18A05C3F0", Slot = "17")]
		public AXIUZBXADAA RKLVZSYDWQJ(Guid a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xA05C500", Offset = "0xA05B300", VA = "0x18A05C500", Slot = "5")]
		public AXIUZBXADAA RKLVZSYDWQJ(MGOMCQBUHGC a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xA05BE90", Offset = "0xA05AC90", VA = "0x18A05BE90", Slot = "18")]
		[AsyncStateMachine(typeof(<GetItemPurchaseInfoAsync>d__33))]
		public Task<AXIUZBXADAA> OXPGSZMFGAF(Guid a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xA05AF20", Offset = "0xA059D20", VA = "0x18A05AF20", Slot = "7")]
		[AsyncStateMachine(typeof(<GetSearchedCustomAvatarItems>d__34))]
		public Task<List<MGOMCQBUHGC>> GetSearchedCustomAvatarItems(string searchQuery, bool? isOwned, bool? isFeatured, IEnumerable<int> outfitTypes, bool includeCoachItems, bool prefillResultsWithGiftBoxes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xA05D3E0", Offset = "0xA05C1E0", VA = "0x18A05D3E0", Slot = "6")]
		public MGOMCQBUHGC ZSJCLDFBNUJ(UnifiedItemId a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xA05C8A0", Offset = "0xA05B6A0", VA = "0x18A05C8A0", Slot = "8")]
		[AsyncStateMachine(typeof(<GetStoreItemsByIdsAsync>d__36))]
		public Task<List<MGOMCQBUHGC>> TGDGNEBTJFF(IReadOnlyList<UnifiedItemId> a, bool b = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xA05CAF0", Offset = "0xA05B8F0", VA = "0x18A05CAF0")]
		[AsyncStateMachine(typeof(<GetUnknownThenFilterOutUnapprovedAvatarItems>d__37))]
		private Task<List<CustomAvatarItem>> WEJKPHMFXXD(List<CustomAvatarItem> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xA05A050", Offset = "0xA058E50", VA = "0x18A05A050")]
		private List<MGOMCQBUHGC> FHCJIEKSVNW(IReadOnlyList<UnifiedItemId> a, IReadOnlyList<PurchasableGiftDrop> b, IReadOnlyList<MGOMCQBUHGC> c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xA05D180", Offset = "0xA05BF80", VA = "0x18A05D180", Slot = "9")]
		public CCAFLELIKTY<BalanceUpdateResponseDTO<BulkPurchaseItemsBalanceUpdateResponseDataDTO>> ZOPVXCUEOSU(Guid a, long b, GiftItemDTO c, CurrencyType d = CurrencyType.RecCenterTokens, [Optional] long? e, StorefrontTypes f = StorefrontTypes.None)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xA05A710", Offset = "0xA059510", VA = "0x18A05A710")]
		[AsyncStateMachine(typeof(<PurchaseAvatarItemAsync>d__40))]
		private Task<RecNetResultObject<BalanceUpdateResponseDTO<BulkPurchaseItemsBalanceUpdateResponseDataDTO>>> GBULZYHGSDO(Guid a, long b, GiftItemDTO c, CurrencyType d = CurrencyType.RecCenterTokens, [Optional] long? e, StorefrontTypes f = StorefrontTypes.None)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xA05CE10", Offset = "0xA05BC10", VA = "0x18A05CE10", Slot = "10")]
		public CCAFLELIKTY<BalanceUpdateResponseDTO<BulkPurchaseItemsBalanceUpdateResponseDataDTO>> ZFNZHVEJOKW(StorefrontTypes a, CurrencyType b, int c, long d, long? e, int f, bool g = false, bool h = true, bool i = false, [Optional] Vector3? j, [Optional] Quaternion? k, [Optional] float? l)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xA05CC00", Offset = "0xA05BA00", VA = "0x18A05CC00", Slot = "11")]
		public CCAFLELIKTY<BalanceUpdateResponseDTO<BulkPurchaseItemsBalanceUpdateResponseDataDTO>> ZEVDUGEKQSB(StorefrontTypes a, CurrencyType b, int c, long d, long? e, int f = 1, bool g = false, bool h = true, bool i = false, [Optional] Vector3? j, [Optional] Quaternion? k, [Optional] float? l)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xA059990", Offset = "0xA058790", VA = "0x18A059990", Slot = "12")]
		public CCAFLELIKTY<BalanceUpdateResponseDTO<BulkPurchaseItemsBalanceUpdateResponseDataDTO>> DEXCBZPCWNZ(StorefrontTypes a, CurrencyType b, int c, long d, long? e, IReadOnlyCollection<int> f, string g, bool h, GiftContext i, int j)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xA05B7B0", Offset = "0xA05A5B0", VA = "0x18A05B7B0", Slot = "13")]
		public CCAFLELIKTY<BalanceUpdateResponseDTO<BulkPurchaseItemsBalanceUpdateResponseDataDTO>> NVNLFIZXMMD(StorefrontTypes a, CurrencyType b, IReadOnlyList<UnifiedItemId> c, IReadOnlyList<long> d, [Optional] long? e, [Optional][CanBeNull] GiftItemDTO gift, [Optional] Guid? f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xA05BD70", Offset = "0xA05AB70", VA = "0x18A05BD70", Slot = "14")]
		[AsyncStateMachine(typeof(<ConvertCustomAvatarItemsToPurchasableItemsIfApplicable>d__45))]
		public Task<List<MGOMCQBUHGC>> NYRJYIKQRSR(List<CustomAvatarItem> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xA05AA70", Offset = "0xA059870", VA = "0x18A05AA70")]
		[AsyncStateMachine(typeof(<GetItemPurchaseInfoServiceCall>d__46))]
		private Task<List<AXIUZBXADAA>> GNAYPMKNUWW(IReadOnlyList<Guid> a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xA05B1C0", Offset = "0xA059FC0", VA = "0x18A05B1C0")]
		private void KEAATGXBPGX(BalanceUpdateResponseDTO<BulkPurchaseItemsBalanceUpdateResponseDataDTO> a, bool b, bool c, bool d, bool e = false, [Optional] XREVULJJRMH f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xA05ABB0", Offset = "0xA0599B0", VA = "0x18A05ABB0")]
		private void GUSULDYPGPW(GiftPackage a, bool b, bool c, XREVULJJRMH d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xA05C9F0", Offset = "0xA05B7F0", VA = "0x18A05C9F0")]
		[AsyncStateMachine(typeof(<InlineConvertItemsToPurchasableItemsIfApplicable>d__49))]
		private Task VUFRQYBXXZE(List<MGOMCQBUHGC> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xA05C3C0", Offset = "0xA05B1C0", VA = "0x18A05C3C0")]
		[CompilerGenerated]
		private void RJLIFRAREGN(BalanceUpdateResponseDTO<BulkPurchaseItemsBalanceUpdateResponseDataDTO> a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class YCJDRFTIQYU : MHBVHTJDTXB
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[CompilerGenerated]
		private sealed class EFEPWUJFGHT
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public YCJDRFTIQYU XRWOWCJVPDZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public RoomieStoreItemFilters UXEZZGLLKBB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public MGOMCQBUHGC JVFFLBVCSQK;

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public EFEPWUJFGHT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0xA059540", Offset = "0xA058340", VA = "0x18A059540")]
			internal bool BWKFLCEBOIU(OutfitType a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private readonly ZTRGYEFJHNU CZBGCFHQVZW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private readonly HESKTCYGSDN WBAOPZHPONH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private readonly FIEOYKFCXLD PTMJDJYKZAY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private readonly MDEYPOZXUSY EXDIXBHIHLA;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0xA0616F0", Offset = "0xA0604F0", VA = "0x18A0616F0")]
		[CXDXQIFYXBD.Session.GameOnly]
		internal static void CXDXQIFYXBD(MZEBANDYSXL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x1117370", Offset = "0x1116170", VA = "0x181117370")]
		[RecRoom.NoEngine.Common.Preserve]
		public YCJDRFTIQYU([Inject(null)] ZTRGYEFJHNU outfitManager, [Inject(null)] HESKTCYGSDN storefrontManager, [Inject(null)] FIEOYKFCXLD customAvatarItems, [Inject(null)] MDEYPOZXUSY storeBridge)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xA0634F0", Offset = "0xA0622F0", VA = "0x18A0634F0")]
		private bool PRGTQUGSXCQ(StoreItemFilters a, StoreItemFilters b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xA0638E0", Offset = "0xA0626E0", VA = "0x18A0638E0", Slot = "5")]
		public IReadOnlyList<MGOMCQBUHGC> VTJPKKIDSTG(StoreItemFilters a, RoomieStoreItemFilters b, IReadOnlyList<MGOMCQBUHGC> c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xA0623D0", Offset = "0xA0611D0", VA = "0x18A0623D0", Slot = "4")]
		public bool NVVBGQSXXAQ(StoreItemFilters a, RoomieStoreItemFilters b, MGOMCQBUHGC c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0xA061B30", Offset = "0xA060930", VA = "0x18A061B30")]
		private bool HHPEHDXQXHA(StoreItemFilters a, MGOMCQBUHGC b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xA0631A0", Offset = "0xA061FA0", VA = "0x18A0631A0")]
		private bool ORCFLAFNCRU(StoreItemFilters a, MGOMCQBUHGC b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xA061C30", Offset = "0xA060A30", VA = "0x18A061C30")]
		private bool IRKTVPVEZBB(StoreItemFilters a, MGOMCQBUHGC b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xA061EF0", Offset = "0xA060CF0", VA = "0x18A061EF0")]
		public bool MEUWVTDBOSE(MGOMCQBUHGC a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xA062140", Offset = "0xA060F40", VA = "0x18A062140")]
		public bool MEUWVTDBOSE(StorefrontGiftDrop a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xA061570", Offset = "0xA060370", VA = "0x18A061570")]
		private bool BFSCPZIJLJD(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0xA061CA0", Offset = "0xA060AA0", VA = "0x18A061CA0")]
		private bool JBLVOBIICAM(StoreItemFilters a, MGOMCQBUHGC b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0xA061760", Offset = "0xA060560", VA = "0x18A061760")]
		private bool DOPSNAPVSCR(StoreItemFilters a, MGOMCQBUHGC b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xA061680", Offset = "0xA060480", VA = "0x18A061680")]
		private bool COMVHDWOCPR(StoreItemFilters a, MGOMCQBUHGC b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xA061BC0", Offset = "0xA0609C0", VA = "0x18A061BC0")]
		private bool IQIDJKWODPA(StoreItemFilters a, MGOMCQBUHGC b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xA062290", Offset = "0xA061090", VA = "0x18A062290")]
		private bool NDWBWLICCZX(StoreItemFilters a, MGOMCQBUHGC b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xA061A30", Offset = "0xA060830", VA = "0x18A061A30")]
		private bool GAEKEAQPUOQ(StoreItemFilters a, MGOMCQBUHGC b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xA063700", Offset = "0xA062500", VA = "0x18A063700")]
		private bool SSFVXSOMTMP(StoreItemFilters a, MGOMCQBUHGC b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xA063B40", Offset = "0xA062940", VA = "0x18A063B40")]
		private bool VTOXDTMQNOF(StoreItemFilters a, MGOMCQBUHGC b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xA063D60", Offset = "0xA062B60", VA = "0x18A063D60")]
		private bool YDYKVJWJTAP(StoreItemFilters a, MGOMCQBUHGC b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xA0619A0", Offset = "0xA0607A0", VA = "0x18A0619A0")]
		private bool FWERTLQMMHP(StoreItemFilters a, MGOMCQBUHGC b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xA0614E0", Offset = "0xA0602E0", VA = "0x18A0614E0")]
		private bool AKNJUXDLVBK(StoreItemFilters a, MGOMCQBUHGC b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xA061CD0", Offset = "0xA060AD0", VA = "0x18A061CD0")]
		private bool JNRUCOUGPBO(StoreItemFilters a, MGOMCQBUHGC b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0xA061AA0", Offset = "0xA0608A0", VA = "0x18A061AA0")]
		private bool GKRMAMEQDBH(StoreItemFilters a, MGOMCQBUHGC b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xA061780", Offset = "0xA060580", VA = "0x18A061780")]
		private bool FCDMPIMIQWY(StoreItemFilters a, MGOMCQBUHGC b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xA061DF0", Offset = "0xA060BF0", VA = "0x18A061DF0")]
		private bool JTIKVQXLYNZ(StoreItemFilters a, MGOMCQBUHGC b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xA063E20", Offset = "0xA062C20", VA = "0x18A063E20")]
		private bool YIJQXXMAIFX(StoreItemFilters a, MGOMCQBUHGC b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xA0615F0", Offset = "0xA0603F0", VA = "0x18A0615F0")]
		private bool BOBVIQEQMEA(StoreItemFilters a, MGOMCQBUHGC b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xA063080", Offset = "0xA061E80", VA = "0x18A063080")]
		private bool OJNZOMETROC(StoreItemFilters a, MGOMCQBUHGC b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA063110", Offset = "0xA061F10", VA = "0x18A063110")]
		private bool OMFQNDIQRCM(StoreItemFilters a, MGOMCQBUHGC b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xA063770", Offset = "0xA062570", VA = "0x18A063770")]
		private bool VMFYMGDFNMC(StoreItemFilters a, RoomieStoreItemFilters b, MGOMCQBUHGC c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xA061810", Offset = "0xA060610", VA = "0x18A061810")]
		private bool FMZGKERQCZZ(RoomieStoreItemFilters a, MGOMCQBUHGC b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xA063500", Offset = "0xA062300", VA = "0x18A063500")]
		private bool QBGDQLBXGSO(RoomieStoreItemFilters a, MGOMCQBUHGC b, OutfitType c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xA0618A0", Offset = "0xA0606A0", VA = "0x18A0618A0")]
		private bool FSSPZVEIRZC(RoomieStoreItemFilters a, MGOMCQBUHGC b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0xA063C40", Offset = "0xA062A40", VA = "0x18A063C40")]
		private bool WYSDBDKISLI(StoreItemFilters a, MGOMCQBUHGC b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xA063640", Offset = "0xA062440", VA = "0x18A063640")]
		private bool RIMQMPSUXTN(StoreItemFilters a, MGOMCQBUHGC b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xA062300", Offset = "0xA061100", VA = "0x18A062300")]
		private bool NLNSDKBZOTY(StoreItemFilters a, MGOMCQBUHGC b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xA063CD0", Offset = "0xA062AD0", VA = "0x18A063CD0")]
		private bool XBRPNRTBVQA(StoreItemFilters a, MGOMCQBUHGC b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xA061E80", Offset = "0xA060C80", VA = "0x18A061E80")]
		private bool KZAEEDYYSWP(StoreItemFilters a, MGOMCQBUHGC b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xA062200", Offset = "0xA061000", VA = "0x18A062200")]
		private bool MKGSDHOSSUP(StoreItemFilters a, MGOMCQBUHGC b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xA061D60", Offset = "0xA060B60", VA = "0x18A061D60")]
		private bool JOGYVVCWQQC(StoreItemFilters a, MGOMCQBUHGC b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xA063BD0", Offset = "0xA0629D0", VA = "0x18A063BD0")]
		private bool WMRBBYDJSOA(StoreItemFilters a, MGOMCQBUHGC b)
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
