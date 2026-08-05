using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.Core.Creation;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Initialization;
using RecRoom.RendererV1;
using RecRoom.Tools;
using RecRoom.Tools.MakerPenTools;
using UJect;
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
		[Cpp2IlInjected.Address(RVA = "0x9A34800", Offset = "0x9A33200", VA = "0x189A34800")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
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

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xD3B3F0", Offset = "0xD39DF0", VA = "0x180D3B3F0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_Maker_Core_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	[Preserve]
	[Obfuscation(ApplyToMembers = false)]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x9A35740", Offset = "0x9A34140", VA = "0x189A35740", Slot = "8")]
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
namespace RecRoom.Maker.Core
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public enum SearchRestrictionOption
	{
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		ShowFreeInventionsInR2PaletteSearch
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public enum SortOption
	{
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		NameAZ,
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		NameZA,
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		InkCostAsc,
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		InkCostDesc,
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		Oldest,
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		Newest
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public interface HXSZZSPVIIJ<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "0")]
		b RWJODKQGFEF(a a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public interface PBZHORFCVQY<a> where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void ClearHoverTarget(ToolMode toolMode);

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool SetHoverTarget(a target, Collider hitCollider, ToolMode toolMode, [Optional] OutlineEffectType? outlineEffectTypeOverride);

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool TryGetHoverTarget([Out] a target);

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool TryGetHoverCollider([Out] Collider hitCollider);
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface BMPNBFKSHPG<a> : EVOUIWBRGKE, EOMXYLAOSQU<a>, SSRYIIWEMTA<a>, KVRDEEWOKOY<a>, TQQLJLXHXWN, LSMTJIBWKPN<a>, TQOMKXSCJSN, VGKONGTSTUL
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public interface LSMTJIBWKPN<a> where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool Raycast(Vector3 origin, Vector3 direction, float maxDistance, [Out] a hitObj, [Out] Vector3 hitPos, [Out] Collider hitCollider);

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int SpherecastPick(Vector3 origin, Vector3 direction, float sphereRadius, float maxDistance, a[] pickedResults, [Out] Vector3 closestHit, [Out] Collider closestCollider);

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		int SpherePick(Vector3 origin, float sphereRadius, Vector3 restrictedPos, a[] pickedResults);

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool TryGetObjectFromColliderInCurrentScope(Collider collider, [Out] a objectFromCollider);
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public interface EVOUIWBRGKE
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		Bounds AIRTIXXIUJP
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		Transform GLNRVMZCGSY
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		Bounds OUPYOWLZAFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		Transform DXEDIKCSLDR
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		Vector3 AXTRPQZVDPS
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		bool QGUWXKCYFGQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void UpdateLocalSelectionBounds();

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void SetSelectionBoundsDirty(bool dirtyLocalBounds = true, int frameCount = 0);

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void ShouldHideSelectionBoundsPreview(bool shouldHide, object token);
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public interface VGKONGTSTUL
	{
		[Cpp2IlInjected.Token(Token = "0x17000007")]
		JOLHGBMRDLK UPZYWZUVJUA
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public interface HVKHOAEEMNE
	{
		[Cpp2IlInjected.Token(Token = "0x17000008")]
		bool SIOACHDPDDO
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		bool TXEHEQCICUW
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		bool LRGYHMOGEAG
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Dictionary<Guid, Guid> TryGetPreviousCloneMapping();

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void TrySetPreviousCloneMapping(Dictionary<Guid, Guid> cloneMapping);
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface KVRDEEWOKOY<a> where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		bool TIOFGRZKFYU
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		int XQLKJTZHYMX
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		IEnumerable<a> YQAPFOGPPDB
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool IsSelected(a item);

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool IsSelectable(a item);
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface EOMXYLAOSQU<a> where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void RenderHoverHighlight(a obj, [Optional] OutlineEffectType? outlineType, bool triggerHighlightEvents = true);

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void RenderHoverHighlight(int count, IEnumerable<a> collection, bool triggerHighlightEvents = true);

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void RenderHoverHighlight(int count, IEnumerable<a> collection, OutlineEffectType outlineType, bool triggerHighlightEvents = true);
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public interface TQOMKXSCJSN
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void OnSelectionPickedUp();

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void OnSelectionReleased();
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public interface TQQLJLXHXWN
	{
		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		bool PIOILEWZCHU
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		bool RHEVMHLFJNV
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		bool LNSNKZXRBYS
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		bool PWOWXUIXBWN
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public struct AdjustLightParams
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public bool Emit;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public float? Intensity;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public float? Range;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public float? Angle;
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public struct AdjustLightArgs<TData> where TData : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public IEnumerable<TData> Targets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public AdjustLightParams Params;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public bool undoable;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x73B3110", Offset = "0x73B1B10", VA = "0x1873B3110")]
		public AdjustLightArgs(IEnumerable<TData> targets, bool emit, float? intensity, float? range, float? angle, bool undoable)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public interface CWXXAQNIDZT<a>
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool SSIYIMJVZWF([In] AdjustLightArgs<a> args);
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class ORNHYFDBKAD<a> : STZHUMRZXEM<CWXXAQNIDZT<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly AdjustLightArgs<a> ZBDNDGMOHKX;

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x72DCB80", Offset = "0x72DB580", VA = "0x1872DCB80")]
		public ORNHYFDBKAD(IEnumerable<a> a, bool b, float? c, float? d, float? e, bool f, CWXXAQNIDZT<a> g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x4EFBCE0", Offset = "0x4EFA6E0", VA = "0x184EFBCE0", Slot = "4")]
		public override bool SSIYIMJVZWF()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public struct ApplyImageAtomicArgs<TData> where TData : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public IEnumerable<TData> Targets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public string ImageName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public bool IsTileable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public bool undoable;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x744F1B0", Offset = "0x744DBB0", VA = "0x18744F1B0")]
		public ApplyImageAtomicArgs(IEnumerable<TData> targets, string imageName, bool isTileable, bool undoable)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface MWFAQINEQFQ<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool SSIYIMJVZWF([In] ApplyImageAtomicArgs<a> args);
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class LALKKECCQNO<a> : STZHUMRZXEM<MWFAQINEQFQ<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly ApplyImageAtomicArgs<a> ZBDNDGMOHKX;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x68BFAC0", Offset = "0x68BE4C0", VA = "0x1868BFAC0")]
		public LALKKECCQNO(IEnumerable<a> a, string b, bool c, bool d, MWFAQINEQFQ<a> e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x4EFBCE0", Offset = "0x4EFA6E0", VA = "0x184EFBCE0", Slot = "4")]
		public override bool SSIYIMJVZWF()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public abstract class STZHUMRZXEM<a> : ENBAWIABGMA<a, bool> where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x62FFB60", Offset = "0x62FE560", VA = "0x1862FFB60")]
		public STZHUMRZXEM(a a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public abstract class FJQWTOBADPF<a, b> : ENBAWIABGMA<a, Task<b>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x62FFB60", Offset = "0x62FE560", VA = "0x1862FFB60")]
		public FJQWTOBADPF(a a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public abstract class ENBAWIABGMA<a, b> where a : notnull where b : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		protected a QLMUZXVXNBV;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x5B49140", Offset = "0x5B47B40", VA = "0x185B49140")]
		public ENBAWIABGMA(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract b SSIYIMJVZWF();
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public abstract class HIFNZLBVWJY<a, b> : ENBAWIABGMA<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x62FFB60", Offset = "0x62FE560", VA = "0x1862FFB60")]
		public HIFNZLBVWJY(a a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public struct CircuitsV1GroupingArgs<TGroup, TData> where TGroup : notnull where TData : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public TGroup CircuitGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public TData GroupParent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public IEnumerable<TData> Targets;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x1F64830", Offset = "0x1F63230", VA = "0x181F64830")]
		public CircuitsV1GroupingArgs(TGroup circuitGroup, TData groupParent, IEnumerable<TData> targets)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public struct CircuitsV1AddArgs<TGroup, TData> where TGroup : notnull where TData : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public TGroup CircuitGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public IEnumerable<TData> Targets;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x111A430", Offset = "0x1118E30", VA = "0x18111A430")]
		public CircuitsV1AddArgs(TGroup circuitGroup, IEnumerable<TData> targets)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public struct CircuitsV1RemoveArgs<TGroup> where TGroup : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public TGroup CircuitGroup;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xEF9580", Offset = "0xEF7F80", VA = "0x180EF9580")]
		public CircuitsV1RemoveArgs(TGroup circuitGroup)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public struct CircuitsV2GroupingArgs
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public IEnumerable<Guid> Targets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public Guid BoardNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public readonly bool Undoable;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x9A33780", Offset = "0x9A32180", VA = "0x189A33780")]
		public CircuitsV2GroupingArgs(IEnumerable<Guid> targets, Guid boardNodeId, bool undoable)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public struct CircuitsV2UngroupingArgs
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public Guid BoardNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public readonly bool Undoable;

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x28575C0", Offset = "0x2855FC0", VA = "0x1828575C0")]
		public CircuitsV2UngroupingArgs(Guid boardNodeId, bool undoable)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public interface JYXUOXVUIQL<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		CreationResult OMRCQHJOEIE(CircuitsV1GroupingArgs<a, b> groupCircuitsArgs);

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "1")]
		CreationResult EYURQDQGDZP(CircuitsV1GroupingArgs<a, b> groupCircuitsArgs);

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "2")]
		CreationResult PYUCWWGPDVW(CircuitsV1AddArgs<a, b> groupCircuitsArgs);

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "3")]
		CreationResult TGRVQBNGUKB(CircuitsV1RemoveArgs<a> groupCircuitsArgs);
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public interface VYDDLMSRHXC
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<CreationResult> OMRCQHJOEIE(CircuitsV2GroupingArgs a);

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<CreationResult> EYURQDQGDZP(CircuitsV2UngroupingArgs a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class QEPWAKEIEXV<a, b> : HIFNZLBVWJY<JYXUOXVUIQL<a, b>, CreationResult>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly CircuitsV1AddArgs<a, b> DFGIMYITOOE;

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7600010", Offset = "0x75FEA10", VA = "0x187600010")]
		public QEPWAKEIEXV(a a, IEnumerable<b> b, JYXUOXVUIQL<a, b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x75FFC50", Offset = "0x75FE650", VA = "0x1875FFC50", Slot = "4")]
		public override CreationResult SSIYIMJVZWF()
		{
			return default(CreationResult);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class OSULHTHYFEL<a, b> : HIFNZLBVWJY<JYXUOXVUIQL<a, b>, CreationResult>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private readonly CircuitsV1GroupingArgs<a, b> DFGIMYITOOE;

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x5142580", Offset = "0x5140F80", VA = "0x185142580")]
		public OSULHTHYFEL(a a, b b, IEnumerable<b> c, JYXUOXVUIQL<a, b> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x72E9620", Offset = "0x72E8020", VA = "0x1872E9620", Slot = "4")]
		public override CreationResult SSIYIMJVZWF()
		{
			return default(CreationResult);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class DILDLQOVIGM<a, b> : HIFNZLBVWJY<JYXUOXVUIQL<a, b>, CreationResult>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private readonly CircuitsV1RemoveArgs<a> DFGIMYITOOE;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x51437F0", Offset = "0x51421F0", VA = "0x1851437F0")]
		public DILDLQOVIGM(a a, JYXUOXVUIQL<a, b> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x53B1530", Offset = "0x53AFF30", VA = "0x1853B1530", Slot = "4")]
		public override CreationResult SSIYIMJVZWF()
		{
			return default(CreationResult);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class XXLFTADKIYO<a, b> : HIFNZLBVWJY<JYXUOXVUIQL<a, b>, CreationResult>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private readonly CircuitsV1GroupingArgs<a, b> DFGIMYITOOE;

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x5142580", Offset = "0x5140F80", VA = "0x185142580")]
		public XXLFTADKIYO(a a, b b, IEnumerable<b> c, JYXUOXVUIQL<a, b> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x5142350", Offset = "0x5140D50", VA = "0x185142350", Slot = "4")]
		public override CreationResult SSIYIMJVZWF()
		{
			return default(CreationResult);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class NSLMUSIVJSK : FJQWTOBADPF<VYDDLMSRHXC, CreationResult>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002A")]
		[CompilerGenerated]
		private struct <Execute>d__2 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public AsyncTaskMethodBuilder<CreationResult> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public NSLMUSIVJSK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private TaskAwaiter<CreationResult> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x9A35250", Offset = "0x9A33C50", VA = "0x189A35250", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x9A354E0", Offset = "0x9A33EE0", VA = "0x189A354E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private CircuitsV2GroupingArgs DFGIMYITOOE;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x9A34670", Offset = "0x9A33070", VA = "0x189A34670")]
		public NSLMUSIVJSK(IEnumerable<Guid> a, Guid b, bool c, VYDDLMSRHXC d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x9A34580", Offset = "0x9A32F80", VA = "0x189A34580", Slot = "4")]
		[AsyncStateMachine(typeof(<Execute>d__2))]
		public override Task<CreationResult> SSIYIMJVZWF()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class DLRPHHOSOBZ : FJQWTOBADPF<VYDDLMSRHXC, CreationResult>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002C")]
		[CompilerGenerated]
		private struct <Execute>d__2 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public AsyncTaskMethodBuilder<CreationResult> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public DLRPHHOSOBZ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			private TaskAwaiter<CreationResult> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x9A34FB0", Offset = "0x9A339B0", VA = "0x189A34FB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x9A355C0", Offset = "0x9A33FC0", VA = "0x189A355C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private readonly CircuitsV2UngroupingArgs DFGIMYITOOE;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x9A338D0", Offset = "0x9A322D0", VA = "0x189A338D0")]
		public DLRPHHOSOBZ(Guid a, bool b, VYDDLMSRHXC c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x9A337E0", Offset = "0x9A321E0", VA = "0x189A337E0", Slot = "4")]
		[AsyncStateMachine(typeof(<Execute>d__2))]
		public override Task<CreationResult> SSIYIMJVZWF()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public readonly struct CloneArgs
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public readonly MirrorArgs MirrorArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public readonly bool Undoable;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x9A337C0", Offset = "0x9A321C0", VA = "0x189A337C0")]
		public CloneArgs(MirrorArgs mirrorArgs, bool undoable)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public interface SOQNMBAZHFD<a> where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<a> SSIYIMJVZWF(CloneArgs a);
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public class YTTRHODGTWD<a> : FJQWTOBADPF<SOQNMBAZHFD<a>, a> where a : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000030")]
		[CompilerGenerated]
		private struct <Execute>d__2 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			public AsyncTaskMethodBuilder<a> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public YTTRHODGTWD<a> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			private TaskAwaiter<a> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x66909D0", Offset = "0x668F3D0", VA = "0x1866909D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x6691CF0", Offset = "0x66906F0", VA = "0x186691CF0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly CloneArgs OGACGZGZNAC;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x5150F40", Offset = "0x514F940", VA = "0x185150F40")]
		public YTTRHODGTWD(MirrorArgs a, bool b, SOQNMBAZHFD<a> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x5150C50", Offset = "0x514F650", VA = "0x185150C50", Slot = "4")]
		[AsyncStateMachine(typeof(YTTRHODGTWD<>.<Execute>d__2))]
		public override Task<a> SSIYIMJVZWF()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public readonly struct MirrorArgs
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public readonly bool IsClone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public readonly Vector3 Normal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public readonly Vector3 Position;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x9A34120", Offset = "0x9A32B20", VA = "0x189A34120")]
		public MirrorArgs(Transform mirror)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x9A34190", Offset = "0x9A32B90", VA = "0x189A34190")]
		public MirrorArgs(Vector3 normal, Vector3 position)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x9A34060", Offset = "0x9A32A60", VA = "0x189A34060")]
		public static MirrorArgs Clone()
		{
			return default(MirrorArgs);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x9A34090", Offset = "0x9A32A90", VA = "0x189A34090")]
		private MirrorArgs(bool isClone)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public struct ConnectStartArgs<TNode> where TNode : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public TNode StartNode;

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x535DEF0", Offset = "0x535C8F0", VA = "0x18535DEF0")]
		public ConnectStartArgs(TNode StartNode)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public struct ConnectFinishArgs<TNode, TReparentOperations> where TNode : notnull where TReparentOperations : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public TNode finishNode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public TReparentOperations reparentOperations;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public InteractionType interactionType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public readonly bool Undoable;

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x535DD70", Offset = "0x535C770", VA = "0x18535DD70")]
		public ConnectFinishArgs(TNode finishNode, TReparentOperations reparentOperations, InteractionType interactionType, bool undoable)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public interface SMLGBSJDCCB<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool KYELVKQQLMD([In] ConnectStartArgs<a> startArgs);

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool UMZNXNVQQJQ([In] ConnectFinishArgs<a, b> finishArgs);

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool DMZOPPZRAXF();
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class AFXBENBELSD<a, b> : STZHUMRZXEM<SMLGBSJDCCB<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x4F2F960", Offset = "0x4F2E360", VA = "0x184F2F960")]
		public AFXBENBELSD(SMLGBSJDCCB<a, b> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x50A3090", Offset = "0x50A1A90", VA = "0x1850A3090", Slot = "4")]
		public override bool SSIYIMJVZWF()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public class XEXAPVDERDU<a, b> : STZHUMRZXEM<SMLGBSJDCCB<a, b>>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private readonly ConnectFinishArgs<a, b> SOIPCKAXPTG;

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x511A320", Offset = "0x5118D20", VA = "0x18511A320")]
		public XEXAPVDERDU(a a, b b, InteractionType c, SMLGBSJDCCB<a, b> d, bool e = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x511A1E0", Offset = "0x5118BE0", VA = "0x18511A1E0", Slot = "4")]
		public override bool SSIYIMJVZWF()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public class XDVVQIKNOTR<a, b> : STZHUMRZXEM<SMLGBSJDCCB<a, b>>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private readonly ConnectStartArgs<a> XMDQUJWKOPJ;

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x5115F00", Offset = "0x5114900", VA = "0x185115F00")]
		public XDVVQIKNOTR(a a, SMLGBSJDCCB<a, b> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x4EFBCE0", Offset = "0x4EFA6E0", VA = "0x184EFBCE0", Slot = "4")]
		public override bool SSIYIMJVZWF()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public struct CreateArgs<TSpawnInfo> where TSpawnInfo : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public TSpawnInfo spawnTypeInformation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public Vector3 position;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public Quaternion rotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public float scale;

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x5373CA0", Offset = "0x53726A0", VA = "0x185373CA0")]
		public CreateArgs(TSpawnInfo spawnTypeInformation, Vector3 position, Quaternion rotation, float scale)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public interface KBYRIJJKZXJ<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<a> RZECKMTPYSZ([In] CreateArgs<b> createArgs, CancellationToken a);
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public class LYNCHLAVIAJ<a, b> : FJQWTOBADPF<KBYRIJJKZXJ<a, b>, a> where a : notnull where b : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private readonly CreateArgs<b> ZBDNDGMOHKX;

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x68F8910", Offset = "0x68F7310", VA = "0x1868F8910")]
		public LYNCHLAVIAJ(b a, Vector3 b, Quaternion c, float d, KBYRIJJKZXJ<a, b> e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x68F8440", Offset = "0x68F6E40", VA = "0x1868F8440", Slot = "4")]
		public override Task<a> SSIYIMJVZWF()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public readonly struct DeleteArgs<TData> where TData : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public readonly IEnumerable<TData> Targets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public readonly bool Undoable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public readonly bool DeleteFrozenObjects;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public readonly bool RemoveCurrentSelectionWhenDelete;

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x53D94A0", Offset = "0x53D7EA0", VA = "0x1853D94A0")]
		public DeleteArgs(IEnumerable<TData> targets, bool undoable = false, bool deleteFrozenObjects = false, bool removeCurrentSlectionWhenDelete = true)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public interface KQWOQBAEZQF<a> where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<CreationResult> JYWDVNTIGWO([In] DeleteArgs<a> selectArgs, CancellationToken a);
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public class UPAPENLJRFV<a> : FJQWTOBADPF<KQWOQBAEZQF<a>, CreationResult> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private readonly DeleteArgs<a> HOEZGGATUMI;

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7D275E0", Offset = "0x7D25FE0", VA = "0x187D275E0")]
		public UPAPENLJRFV(IEnumerable<a> a, bool b, KQWOQBAEZQF<a> c, bool d = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x68F8440", Offset = "0x68F6E40", VA = "0x1868F8440", Slot = "4")]
		public override Task<CreationResult> SSIYIMJVZWF()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public struct EditArgs<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public readonly T target;

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x535B700", Offset = "0x535A100", VA = "0x18535B700")]
		public EditArgs(T newTarget)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public interface WZBXXQHHYVQ<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool KYELVKQQLMD([In] EditArgs<a> editArgs);

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool UMZNXNVQQJQ();
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public interface LZXLAQWPWMO<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool SSIYIMJVZWF([In] LockArgs<a> lockArgs);
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public struct LockArgs<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public readonly T target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public readonly bool setLocked;

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6F1B8C0", Offset = "0x6F1A2C0", VA = "0x186F1B8C0")]
		public LockArgs(T newTarget, bool isLocked)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public class DJKYVYJSOOH<a> : STZHUMRZXEM<WZBXXQHHYVQ<a>> where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x4F2F960", Offset = "0x4F2E360", VA = "0x184F2F960")]
		public DJKYVYJSOOH(WZBXXQHHYVQ<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x53B6130", Offset = "0x53B4B30", VA = "0x1853B6130", Slot = "4")]
		public override bool SSIYIMJVZWF()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public class XZPJKBPVUXM<a> : STZHUMRZXEM<WZBXXQHHYVQ<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private readonly EditArgs<a> BQCWYVAQOUT;

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x5143850", Offset = "0x5142250", VA = "0x185143850")]
		public XZPJKBPVUXM(a a, WZBXXQHHYVQ<a> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x4EFBCE0", Offset = "0x4EFA6E0", VA = "0x184EFBCE0", Slot = "4")]
		public override bool SSIYIMJVZWF()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public class JBGQKJVIHCU<a> : STZHUMRZXEM<LZXLAQWPWMO<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private readonly LockArgs<a> UPZWHIMDACM;

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x66CD8A0", Offset = "0x66CC2A0", VA = "0x1866CD8A0")]
		public JBGQKJVIHCU(a a, bool b, LZXLAQWPWMO<a> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x4EFBCE0", Offset = "0x4EFA6E0", VA = "0x184EFBCE0", Slot = "4")]
		public override bool SSIYIMJVZWF()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public struct FreezeArgs<TData> where TData : notnull, IOBOVHCNGIT
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public IEnumerable<TData> Targets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public bool willFreeze;

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x63DDFF0", Offset = "0x63DC9F0", VA = "0x1863DDFF0")]
		public FreezeArgs(IEnumerable<TData> newTargets, bool newWillFreeze)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public struct FreezeListArgs<TData> where TData : notnull, IOBOVHCNGIT
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public List<TData> Targets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public List<bool> freezeValues;

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x63DE8A0", Offset = "0x63DD2A0", VA = "0x1863DE8A0")]
		public FreezeListArgs(List<TData> newTargets, List<bool> newFreezeValues)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public interface IOBOVHCNGIT
	{
		[Cpp2IlInjected.Token(Token = "0x17000012")]
		bool PNQOCNKRJDW
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public interface VKCVFPDOBMS<a> where a : IOBOVHCNGIT
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool SSIYIMJVZWF([In] FreezeArgs<a> freezeArgs);

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void SSIYIMJVZWF([In] FreezeListArgs<a> freezeArgs);
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public interface RYZABLKKTOL<a> where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool VVMQJNZDKYU(a a);
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public class DGFLEOQJBUA<a> : STZHUMRZXEM<VKCVFPDOBMS<a>> where a : notnull, IOBOVHCNGIT
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private readonly FreezeArgs<a> AZWJJLWOZNW;

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x53AE4B0", Offset = "0x53ACEB0", VA = "0x1853AE4B0")]
		public DGFLEOQJBUA(List<a> a, bool b, VKCVFPDOBMS<a> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x4EFBCE0", Offset = "0x4EFA6E0", VA = "0x184EFBCE0", Slot = "4")]
		public override bool SSIYIMJVZWF()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public class TAEZICWYBKU<a> : STZHUMRZXEM<VKCVFPDOBMS<a>> where a : notnull, IOBOVHCNGIT
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private readonly FreezeListArgs<a> AZWJJLWOZNW;

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7A41E80", Offset = "0x7A40880", VA = "0x187A41E80")]
		public TAEZICWYBKU(List<a> a, List<bool> b, VKCVFPDOBMS<a> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x5B9A8F0", Offset = "0x5B992F0", VA = "0x185B9A8F0", Slot = "4")]
		public override bool SSIYIMJVZWF()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public interface TMMMFAVACXF : IOBOVHCNGIT
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public interface IIGUROQLNEG<a> where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<CreationResult> SSIYIMJVZWF(MergeShapesArgs<a> mergeShapesArgs);
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public class FRNXFLSSYNG<a> : FJQWTOBADPF<IIGUROQLNEG<a>, CreationResult> where a : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004F")]
		[CompilerGenerated]
		private struct <Execute>d__2 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public AsyncTaskMethodBuilder<CreationResult> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public FRNXFLSSYNG<a> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			private TaskAwaiter<CreationResult> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x6691A10", Offset = "0x6690410", VA = "0x186691A10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x6691D90", Offset = "0x6690790", VA = "0x186691D90", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private readonly MergeShapesArgs<a> LRXHIBIFXGO;

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6343DB0", Offset = "0x63427B0", VA = "0x186343DB0")]
		public FRNXFLSSYNG(a a, IReadOnlyList<a> b, bool c, IIGUROQLNEG<a> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x63439F0", Offset = "0x63423F0", VA = "0x1863439F0", Slot = "4")]
		[AsyncStateMachine(typeof(FRNXFLSSYNG<>.<Execute>d__2))]
		public override Task<CreationResult> SSIYIMJVZWF()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public struct MergeShapesArgs<TData> where TData : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public TData DestinationContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public IReadOnlyList<TData> ShapesToMerge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public bool Undoable;

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x124FCD0", Offset = "0x124E6D0", VA = "0x18124FCD0")]
		public MergeShapesArgs(TData destinationContainer, IReadOnlyList<TData> shapesToMerge, bool undoable)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public interface WLWSYWRVIHT<a>
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool SSIYIMJVZWF([In] RecolorAtomicArgs<a> recolorArgs);
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public interface UUXAUKZHIOF<a>
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void SSIYIMJVZWF([In] RecolorAtomicSpecificArgs<a> recolorArgs);
	}
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public interface JPMBYLMSYID<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool ACJLVWAKAZS([In] RecolorContinuousArgs<a> recolorArgs);

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void UMZNXNVQQJQ();
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public class BAHGSWXYFRV<a> : STZHUMRZXEM<WLWSYWRVIHT<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private readonly RecolorAtomicArgs<a> GOKMZYPFQQL;

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x4EFC040", Offset = "0x4EFAA40", VA = "0x184EFC040")]
		public BAHGSWXYFRV(IEnumerable<a> a, ShapeColor b, ShapeMaterial c, float d, string? imageName, bool e, bool f, WLWSYWRVIHT<a> g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x4EFBCE0", Offset = "0x4EFA6E0", VA = "0x184EFBCE0", Slot = "4")]
		public override bool SSIYIMJVZWF()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public class TDEUSNKAFQH<a> : STZHUMRZXEM<UUXAUKZHIOF<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private readonly RecolorAtomicSpecificArgs<a> GOKMZYPFQQL;

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x7A42950", Offset = "0x7A41350", VA = "0x187A42950")]
		public TDEUSNKAFQH(a[] a, ShapeColor[] b, ShapeMaterial[] c, float[] d, UUXAUKZHIOF<a> e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x67F08A0", Offset = "0x67EF2A0", VA = "0x1867F08A0", Slot = "4")]
		public override bool SSIYIMJVZWF()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public class SYYNXCFANWV<a> : STZHUMRZXEM<JPMBYLMSYID<a>> where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x4F2F960", Offset = "0x4F2E360", VA = "0x184F2F960")]
		public SYYNXCFANWV(JPMBYLMSYID<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x7911A10", Offset = "0x7910410", VA = "0x187911A10", Slot = "4")]
		public override bool SSIYIMJVZWF()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public class KVWUYMVDRLK<a> : STZHUMRZXEM<JPMBYLMSYID<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private readonly RecolorContinuousArgs<a> GOKMZYPFQQL;

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x67F0A50", Offset = "0x67EF450", VA = "0x1867F0A50")]
		public KVWUYMVDRLK(IEnumerable<a> a, ShapeColor b, ShapeMaterial c, float d, JPMBYLMSYID<a> e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x67F08A0", Offset = "0x67EF2A0", VA = "0x1867F08A0", Slot = "4")]
		public override bool SSIYIMJVZWF()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public struct RecolorAtomicArgs<TData> where TData : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public IEnumerable<TData> Targets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public ShapeColor Color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public ShapeMaterial Material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public float UVScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public string? ImageName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public bool? ImageTileable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public bool Undoable;

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x78639F0", Offset = "0x78623F0", VA = "0x1878639F0")]
		public RecolorAtomicArgs(IEnumerable<TData> targets, ShapeColor color, ShapeMaterial material, float uvScale, string? imageName, bool? imageTileable, bool undoable)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public struct RecolorAtomicSpecificArgs<TData> where TData : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public TData[] Targets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public ShapeColor[] Color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public ShapeMaterial[] Material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public float[] uvScale;

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x7864150", Offset = "0x7862B50", VA = "0x187864150")]
		public RecolorAtomicSpecificArgs(TData[] targets, ShapeColor[] color, ShapeMaterial[] material, float[] uvScale)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public struct RecolorContinuousArgs<TData> where TData : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public IEnumerable<TData> Targets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public ShapeColor Color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public ShapeMaterial Material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public float uvScale;

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x78646B0", Offset = "0x78630B0", VA = "0x1878646B0")]
		public RecolorContinuousArgs(IEnumerable<TData> targets, ShapeColor color, ShapeMaterial material, float uvScale)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public interface SSRYIIWEMTA<a> where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool PYUCWWGPDVW([In] SelectArgs<a> selectArgs);

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void TGRVQBNGUKB([In] SelectArgs<a> selectArgs);

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void IIJBZUIEOMK([In] bool undoAble);

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool KCVDZFGFBOO([In] SelectArgs<a> selectArgs);

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void EJLNFENGOFY();

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool QVXVNRYGWGN([In] a itemInCache);
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public class LGQBBWZUYLH<a> : STZHUMRZXEM<SSRYIIWEMTA<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private readonly SelectArgs<a> TANGJCVRIKT;

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x68C01F0", Offset = "0x68BEBF0", VA = "0x1868C01F0")]
		public LGQBBWZUYLH(List<a> a, SSRYIIWEMTA<a> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x4EFBCE0", Offset = "0x4EFA6E0", VA = "0x184EFBCE0", Slot = "4")]
		public override bool SSIYIMJVZWF()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public class BFJUOTPXDWH<a> : STZHUMRZXEM<SSRYIIWEMTA<a>> where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x4F2F960", Offset = "0x4F2E360", VA = "0x184F2F960")]
		public BFJUOTPXDWH(SSRYIIWEMTA<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x4F2F910", Offset = "0x4F2E310", VA = "0x184F2F910", Slot = "4")]
		public override bool SSIYIMJVZWF()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public class XGYTGDWRNRV<a> : STZHUMRZXEM<SSRYIIWEMTA<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private readonly bool UXVIDWNEWGA;

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x511B8A0", Offset = "0x511A2A0", VA = "0x18511B8A0")]
		public XGYTGDWRNRV(bool a, SSRYIIWEMTA<a> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x511B840", Offset = "0x511A240", VA = "0x18511B840", Slot = "4")]
		public override bool SSIYIMJVZWF()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public class EZRGOIPCMAA<a> : STZHUMRZXEM<SSRYIIWEMTA<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private readonly SelectArgs<a> TANGJCVRIKT;

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x5B9AA50", Offset = "0x5B99450", VA = "0x185B9AA50")]
		public EZRGOIPCMAA(List<a> a, bool b, SSRYIIWEMTA<a> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x5B9A8F0", Offset = "0x5B992F0", VA = "0x185B9A8F0", Slot = "4")]
		public override bool SSIYIMJVZWF()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public class UWKPSFYCXTC<a> : STZHUMRZXEM<SSRYIIWEMTA<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private readonly a WCPICLAZABC;

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x7D2C900", Offset = "0x7D2B300", VA = "0x187D2C900")]
		public UWKPSFYCXTC(a a, SSRYIIWEMTA<a> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x7D2C630", Offset = "0x7D2B030", VA = "0x187D2C630", Slot = "4")]
		public override bool SSIYIMJVZWF()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public class QVTVNEXYEPN<a> : STZHUMRZXEM<SSRYIIWEMTA<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private readonly SelectArgs<a> TANGJCVRIKT;

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x760CE90", Offset = "0x760B890", VA = "0x18760CE90")]
		public QVTVNEXYEPN(IEnumerable<a> a, SSRYIIWEMTA<a> b, bool c = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x760CCA0", Offset = "0x760B6A0", VA = "0x18760CCA0", Slot = "4")]
		public override bool SSIYIMJVZWF()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public struct SelectArgs<TData> where TData : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public IEnumerable<TData> Targets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public bool undoable;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x7916CD0", Offset = "0x79156D0", VA = "0x187916CD0")]
		public SelectArgs(IEnumerable<TData> newTargets, bool newUndoable = false)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public interface UVUITMMYLAN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<CreationResult> SSIYIMJVZWF(SplitShapesArgs a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public class NLZPNVVWUHF : FJQWTOBADPF<UVUITMMYLAN, CreationResult>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000065")]
		[CompilerGenerated]
		private struct <Execute>d__2 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public AsyncTaskMethodBuilder<CreationResult> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public NLZPNVVWUHF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			private TaskAwaiter<CreationResult> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x9A34D30", Offset = "0x9A33730", VA = "0x189A34D30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x9A35550", Offset = "0x9A33F50", VA = "0x189A35550", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private readonly SplitShapesArgs CUZVYGSPKDI;

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x9A342B0", Offset = "0x9A32CB0", VA = "0x189A342B0")]
		public NLZPNVVWUHF(bool a, UVUITMMYLAN b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x9A341C0", Offset = "0x9A32BC0", VA = "0x189A341C0", Slot = "4")]
		[AsyncStateMachine(typeof(<Execute>d__2))]
		public override Task<CreationResult> SSIYIMJVZWF()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public struct SplitShapesArgs
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public bool Undoable;

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x2757BF0", Offset = "0x27565F0", VA = "0x182757BF0")]
		public SplitShapesArgs(bool undoable)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public readonly struct AlignArgs
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public readonly bool translate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public readonly bool rotate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public readonly bool scale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public readonly bool undoable;

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x83F9AE0", Offset = "0x83F84E0", VA = "0x1883F9AE0")]
		public AlignArgs(bool translate, bool rotate, bool scale, bool undoable)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x9A33770", Offset = "0x9A32170", VA = "0x189A33770")]
		public AlignArgs(bool rotate, bool undoable)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public interface QRBZGGVCXBE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool NGKLJQPJOYW(AlignArgs a);

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool WPLJZRABJEV(AlignArgs a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public class JPLUPSONEGE : STZHUMRZXEM<QRBZGGVCXBE>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private readonly AlignArgs GYATNQVBJBU;

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x9A33BC0", Offset = "0x9A325C0", VA = "0x189A33BC0")]
		public JPLUPSONEGE(bool a, bool b, bool c, bool d, QRBZGGVCXBE e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x9A33B70", Offset = "0x9A32570", VA = "0x189A33B70", Slot = "4")]
		public override bool SSIYIMJVZWF()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public class NSWBYUYGCNR : STZHUMRZXEM<QRBZGGVCXBE>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private readonly AlignArgs GYATNQVBJBU;

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x9A34780", Offset = "0x9A33180", VA = "0x189A34780")]
		public NSWBYUYGCNR(bool a, bool b, QRBZGGVCXBE c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x9A34730", Offset = "0x9A33130", VA = "0x189A34730", Slot = "4")]
		public override bool SSIYIMJVZWF()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public interface GEHTOQVBVYL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void SSIYIMJVZWF([In] TransformArgs transformArgs);
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public class NOQXBNUXCVD : STZHUMRZXEM<GEHTOQVBVYL>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private readonly TransformArgs UXYIXTEKHWX;

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x9A343C0", Offset = "0x9A32DC0", VA = "0x189A343C0")]
		public NOQXBNUXCVD(Guid[] a, Vector3[] b, Quaternion[] c, float[] d, Dictionary<Guid, Vector3> e, GEHTOQVBVYL f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x9A34310", Offset = "0x9A32D10", VA = "0x189A34310", Slot = "4")]
		public override bool SSIYIMJVZWF()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public interface IIEKCDREEOV<a>
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool KYELVKQQLMD([In] ManipulateStartArgs<a> startArgs);

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool ACJLVWAKAZS([In] ManipulateSetAspectRatioArgs updateArgs);

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool ACJLVWAKAZS([In] ManipulateSetCurvePointPositionAndRadiusArgs updateArgs);

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool UMZNXNVQQJQ();
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public class NAAJIFZMIJB<a> : STZHUMRZXEM<IIEKCDREEOV<a>> where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x4F2F960", Offset = "0x4F2E360", VA = "0x184F2F960")]
		public NAAJIFZMIJB(IIEKCDREEOV<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x7147360", Offset = "0x7145D60", VA = "0x187147360", Slot = "4")]
		public override bool SSIYIMJVZWF()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public class KOQHERRFOVM<a> : STZHUMRZXEM<IIEKCDREEOV<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private readonly ManipulateSetAspectRatioArgs WPVAXJWAYGL;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x67E3DC0", Offset = "0x67E27C0", VA = "0x1867E3DC0")]
		public KOQHERRFOVM(Vector3 a, bool b, IIEKCDREEOV<a> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x67E3D60", Offset = "0x67E2760", VA = "0x1867E3D60", Slot = "4")]
		public override bool SSIYIMJVZWF()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public class FBMXXYDNZGC<a> : STZHUMRZXEM<IIEKCDREEOV<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private readonly ManipulateSetCurvePointPositionAndRadiusArgs WPVAXJWAYGL;

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x62F9380", Offset = "0x62F7D80", VA = "0x1862F9380")]
		public FBMXXYDNZGC(Guid a, int b, Vector3 c, Quaternion d, float e, bool f, IIEKCDREEOV<a> g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x62F9320", Offset = "0x62F7D20", VA = "0x1862F9320", Slot = "4")]
		public override bool SSIYIMJVZWF()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public class BXIRXIIUGZY<a> : STZHUMRZXEM<IIEKCDREEOV<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private readonly ManipulateStartArgs<a> WPVAXJWAYGL;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x4F42270", Offset = "0x4F40C70", VA = "0x184F42270")]
		public BXIRXIIUGZY(a a, bool b, IIEKCDREEOV<a> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x4EFBCE0", Offset = "0x4EFA6E0", VA = "0x184EFBCE0", Slot = "4")]
		public override bool SSIYIMJVZWF()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public struct ManipulateSetAspectRatioArgs
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public readonly Vector3 aspectRatio;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public readonly bool broadcastChangesOverNetwork;

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x8258AF0", Offset = "0x82574F0", VA = "0x188258AF0")]
		public ManipulateSetAspectRatioArgs(Vector3 aspectRatio, bool broadcastChangesOverNetwork)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public struct ManipulateSetCurvePointPositionAndRadiusArgs
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public readonly Guid curveShapeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public readonly int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public readonly Vector3 position;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public readonly Quaternion rotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public readonly float radius;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public readonly bool broadcastChangesOverNetwork;

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x9A34020", Offset = "0x9A32A20", VA = "0x189A34020")]
		public ManipulateSetCurvePointPositionAndRadiusArgs(Guid curveShapeId, int index, Vector3 position, Quaternion rotation, float radius, bool broadcastChangesOverNetwork)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public struct ManipulateStartArgs<TData> where TData : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public readonly TData target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public readonly bool undoable;

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x6F78F00", Offset = "0x6F77900", VA = "0x186F78F00")]
		public ManipulateStartArgs(TData target, bool undoable)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public interface XETLHWUYKYG<a>
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool SSIYIMJVZWF([In] MoveArgs<a> moveArgs);

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool SSIYIMJVZWF([In] MoveToArgs<a> moveArgs);
	}
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public interface SQIFLAPCVWY<a>
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool KYELVKQQLMD([In] MoveStartArgs<a> moveStartArgs);

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool ACJLVWAKAZS([In] MoveUpdateArgs updateArgs);

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool UMZNXNVQQJQ();
	}
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public class RDBJWYMGTAU<a> : STZHUMRZXEM<XETLHWUYKYG<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private readonly MoveArgs<a> FKTNPKZJDRQ;

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x7643F70", Offset = "0x7642970", VA = "0x187643F70")]
		public RDBJWYMGTAU(IEnumerable<a> a, Vector3 b, bool c, XETLHWUYKYG<a> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x4EFBCE0", Offset = "0x4EFA6E0", VA = "0x184EFBCE0", Slot = "4")]
		public override bool SSIYIMJVZWF()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public class CLBMPGNONXA<a> : STZHUMRZXEM<SQIFLAPCVWY<a>> where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x4F2F960", Offset = "0x4F2E360", VA = "0x184F2F960")]
		public CLBMPGNONXA(SQIFLAPCVWY<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x50A3090", Offset = "0x50A1A90", VA = "0x1850A3090", Slot = "4")]
		public override bool SSIYIMJVZWF()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public class CGNXDHTJXOV<a> : STZHUMRZXEM<SQIFLAPCVWY<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private readonly MoveStartArgs<a> FKTNPKZJDRQ;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x5069040", Offset = "0x5067A40", VA = "0x185069040")]
		public CGNXDHTJXOV(IEnumerable<a> a, bool b, SQIFLAPCVWY<a> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x4EFBCE0", Offset = "0x4EFA6E0", VA = "0x184EFBCE0", Slot = "4")]
		public override bool SSIYIMJVZWF()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public class ZDZOEBDKNGN<a> : STZHUMRZXEM<XETLHWUYKYG<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private readonly MoveToArgs<a> FKTNPKZJDRQ;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x5155D80", Offset = "0x5154780", VA = "0x185155D80")]
		public ZDZOEBDKNGN(IEnumerable<a> a, Vector3 b, TransformVec3Filter c, bool d, XETLHWUYKYG<a> e, Space f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x511A1E0", Offset = "0x5118BE0", VA = "0x18511A1E0", Slot = "4")]
		public override bool SSIYIMJVZWF()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public class AWLRSMXKEMA<a> : STZHUMRZXEM<SQIFLAPCVWY<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private readonly MoveUpdateArgs FKTNPKZJDRQ;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x7220950", Offset = "0x721F350", VA = "0x187220950")]
		public AWLRSMXKEMA(Vector3 a, SQIFLAPCVWY<a> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x67E3D60", Offset = "0x67E2760", VA = "0x1867E3D60", Slot = "4")]
		public override bool SSIYIMJVZWF()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public struct MoveArgs<TData> where TData : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public readonly IEnumerable<TData> targets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public readonly Vector3 displacement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public readonly bool undoable;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x7142320", Offset = "0x7140D20", VA = "0x187142320")]
		public MoveArgs(IEnumerable<TData> targets, Vector3 displacement, bool undoable)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public struct MoveStartArgs<TData> where TData : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public readonly IEnumerable<TData> targets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public readonly bool undoable;

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x7142400", Offset = "0x7140E00", VA = "0x187142400")]
		public MoveStartArgs(IEnumerable<TData> targets, bool undoable)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	public struct MoveToArgs<TData> where TData : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public readonly IEnumerable<TData> targets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public readonly Vector3 worldSpaceDestination;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public readonly TransformVec3Filter moveToType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public readonly bool undoable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public readonly Space relativeTo;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x7142E70", Offset = "0x7141870", VA = "0x187142E70")]
		public MoveToArgs(IEnumerable<TData> targets, Vector3 worldSpaceDestination, TransformVec3Filter moveToType, bool undoable, Space relativeTo)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public struct MoveUpdateArgs
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public readonly Vector3 displacement;

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x2E08DF0", Offset = "0x2E077F0", VA = "0x182E08DF0")]
		public MoveUpdateArgs(Vector3 displacement)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public enum TransformVec3Filter
	{
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		XYZ,
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		X_only,
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		Y_only,
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		Z_only
	}
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public interface WRZIIWKVRCE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool SSIYIMJVZWF([In] PivotArgs pivotArgs);
	}
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	public class XKWJJPMLGUW : STZHUMRZXEM<WRZIIWKVRCE>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private readonly PivotArgs GTMOVERCWQX;

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x9A356E0", Offset = "0x9A340E0", VA = "0x189A356E0")]
		public XKWJJPMLGUW(bool a, WRZIIWKVRCE b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x9A35630", Offset = "0x9A34030", VA = "0x189A35630", Slot = "4")]
		public override bool SSIYIMJVZWF()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public readonly struct PivotArgs
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public readonly bool undoable;

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x2757BF0", Offset = "0x27565F0", VA = "0x182757BF0")]
		public PivotArgs(bool undoable)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	public interface LNGGURXYHVG<a>
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool SSIYIMJVZWF([In] RotateArgs<a> rotateArgs);

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool SSIYIMJVZWF([In] RotateToArgs<a> rotateArgs);
	}
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	public interface OMPMYHOSAGK<a>
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool KYELVKQQLMD([In] RotateStartArgs<a> startArgs);

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool ACJLVWAKAZS([In] RotateUpdateArgs updateArgs);

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool UMZNXNVQQJQ();
	}
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public class PSGFPMTRHEC<a> : STZHUMRZXEM<LNGGURXYHVG<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private readonly RotateArgs<a> EABLLFFIDNW;

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x73F1910", Offset = "0x73F0310", VA = "0x1873F1910")]
		public PSGFPMTRHEC(IEnumerable<a> a, Quaternion b, Vector3? c, bool d, bool e, LNGGURXYHVG<a> f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x4EFBCE0", Offset = "0x4EFA6E0", VA = "0x184EFBCE0", Slot = "4")]
		public override bool SSIYIMJVZWF()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public class DRQNKBZARJG<a> : STZHUMRZXEM<OMPMYHOSAGK<a>> where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x4F2F960", Offset = "0x4F2E360", VA = "0x184F2F960")]
		public DRQNKBZARJG(OMPMYHOSAGK<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x50A3090", Offset = "0x50A1A90", VA = "0x1850A3090", Slot = "4")]
		public override bool SSIYIMJVZWF()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public class ZHKJAWMRDWP<a> : STZHUMRZXEM<OMPMYHOSAGK<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private readonly RotateStartArgs<a> EABLLFFIDNW;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x515BEB0", Offset = "0x515A8B0", VA = "0x18515BEB0")]
		public ZHKJAWMRDWP(IEnumerable<a> a, bool b, OMPMYHOSAGK<a> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x4EFBCE0", Offset = "0x4EFA6E0", VA = "0x184EFBCE0", Slot = "4")]
		public override bool SSIYIMJVZWF()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public class JQIXKXOEZNZ<a> : STZHUMRZXEM<LNGGURXYHVG<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private readonly RotateToArgs<a> EABLLFFIDNW;

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x66D97E0", Offset = "0x66D81E0", VA = "0x1866D97E0")]
		public JQIXKXOEZNZ(IEnumerable<a> a, Quaternion b, TransformVec3Filter c, Vector3? d, bool e, bool f, Space g, LNGGURXYHVG<a> h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x511A1E0", Offset = "0x5118BE0", VA = "0x18511A1E0", Slot = "4")]
		public override bool SSIYIMJVZWF()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public class MRCVNWVGOTA<a> : STZHUMRZXEM<OMPMYHOSAGK<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private readonly RotateUpdateArgs EABLLFFIDNW;

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x6F3D440", Offset = "0x6F3BE40", VA = "0x186F3D440")]
		public MRCVNWVGOTA(Quaternion a, Vector3? b, bool c, OMPMYHOSAGK<a> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x67E3D60", Offset = "0x67E2760", VA = "0x1867E3D60", Slot = "4")]
		public override bool SSIYIMJVZWF()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public struct RotateArgs<TData> where TData : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public readonly IEnumerable<TData> targets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public readonly Quaternion displacement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public readonly Vector3? pivotPoint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public readonly bool rotateInPlace;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public readonly bool undoable;

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x78EAD10", Offset = "0x78E9710", VA = "0x1878EAD10")]
		public RotateArgs(IEnumerable<TData> targets, Quaternion displacement, Vector3? pivotPoint, bool rotateInPlace, bool undoable)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	public struct RotateStartArgs<TData> where TData : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public readonly IEnumerable<TData> targets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public readonly bool undoable;

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x78EAE00", Offset = "0x78E9800", VA = "0x1878EAE00")]
		public RotateStartArgs(IEnumerable<TData> targets, bool undoable)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	public struct RotateToArgs<TData> where TData : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public readonly IEnumerable<TData> targets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public readonly Quaternion targetRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public readonly TransformVec3Filter rotateToType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public readonly Vector3? pivotPoint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public readonly bool rotateInPlace;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public readonly bool undoable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public readonly Space relativeTo;

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x78EB6F0", Offset = "0x78EA0F0", VA = "0x1878EB6F0")]
		public RotateToArgs(IEnumerable<TData> targets, Quaternion targetRotation, TransformVec3Filter rotateToType, Vector3? pivotPoint, bool rotateInPlace, bool undoable, Space relativeTo)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	public struct RotateUpdateArgs
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public readonly Quaternion displacement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public readonly Vector3? pivotPoint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public readonly bool rotateInPlace;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x82CE530", Offset = "0x82CCF30", VA = "0x1882CE530")]
		public RotateUpdateArgs(Quaternion displacement, Vector3? pivotPoint, bool rotateInPlace)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public interface GJTNEMFIGGB<a>
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool KYELVKQQLMD([In] ScaleStartArgs<a> startArgs);

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool ACJLVWAKAZS([In] ScaleUniformUpdateArgs updateArgs);

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool ACJLVWAKAZS([In] ScaleToUniformUpdateArgs updateArgs);

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool ACJLVWAKAZS([In] ScaleDeformInDirectionUpdateArgs updateArgs);

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool UMZNXNVQQJQ();
	}
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	public class EEMDBJTTXTQ<a> : STZHUMRZXEM<GJTNEMFIGGB<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private readonly ScaleDeformInDirectionUpdateArgs FQQMATLTUQJ;

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x5B45B00", Offset = "0x5B44500", VA = "0x185B45B00")]
		public EEMDBJTTXTQ(Vector3 a, float b, Vector3 c, bool d, bool e, GJTNEMFIGGB<a> f, Space g = Space.Self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x5B45970", Offset = "0x5B44370", VA = "0x185B45970", Slot = "4")]
		public override bool SSIYIMJVZWF()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	public class KVXQJQSRADB<a> : STZHUMRZXEM<GJTNEMFIGGB<a>> where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x4F2F960", Offset = "0x4F2E360", VA = "0x184F2F960")]
		public KVXQJQSRADB(GJTNEMFIGGB<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x67F0B20", Offset = "0x67EF520", VA = "0x1867F0B20", Slot = "4")]
		public override bool SSIYIMJVZWF()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	public class KHDBINGAAVM<a> : STZHUMRZXEM<GJTNEMFIGGB<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private readonly ScaleStartArgs<a> FQQMATLTUQJ;

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x67DE1D0", Offset = "0x67DCBD0", VA = "0x1867DE1D0")]
		public KHDBINGAAVM(IEnumerable<a> a, bool b, GJTNEMFIGGB<a> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x4EFBCE0", Offset = "0x4EFA6E0", VA = "0x184EFBCE0", Slot = "4")]
		public override bool SSIYIMJVZWF()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public class AYFVZZDMOSS<a> : STZHUMRZXEM<GJTNEMFIGGB<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private readonly ScaleToUniformUpdateArgs FQQMATLTUQJ;

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x7220A70", Offset = "0x721F470", VA = "0x187220A70")]
		public AYFVZZDMOSS(float a, bool b, Vector3 c, GJTNEMFIGGB<a> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x62F9320", Offset = "0x62F7D20", VA = "0x1862F9320", Slot = "4")]
		public override bool SSIYIMJVZWF()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	public class UPEEWCTQQXV<a> : STZHUMRZXEM<GJTNEMFIGGB<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private readonly ScaleUniformUpdateArgs FQQMATLTUQJ;

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x7D277E0", Offset = "0x7D261E0", VA = "0x187D277E0")]
		public UPEEWCTQQXV(float a, Vector3 b, GJTNEMFIGGB<a> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x67E3D60", Offset = "0x67E2760", VA = "0x1867E3D60", Slot = "4")]
		public override bool SSIYIMJVZWF()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	public struct ScaleDeformInDirectionUpdateArgs
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public readonly Vector3 scaleDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public readonly float scaleFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public readonly Vector3 pivotPoint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public readonly bool broadcastChangesOverNetwork;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public readonly Space relativeTo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public readonly bool scalingAlongFixedAxis;

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x9A34880", Offset = "0x9A33280", VA = "0x189A34880")]
		public ScaleDeformInDirectionUpdateArgs(Vector3 scaleDirection, float scaleFactor, Vector3 pivotPoint, bool broadcastChangesOverNetwork, bool scalingUsingAxes, Space relativeTo = Space.Self)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public struct ScaleStartArgs<TData> where TData : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public readonly IEnumerable<TData> targets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public readonly bool undoable;

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x79120E0", Offset = "0x7910AE0", VA = "0x1879120E0")]
		public ScaleStartArgs(IEnumerable<TData> targets, bool undoable)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	public struct ScaleToUniformUpdateArgs
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public readonly float newScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public readonly bool scaleInPlace;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public readonly Vector3 pivotPoint;

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x9A348C0", Offset = "0x9A332C0", VA = "0x189A348C0")]
		public ScaleToUniformUpdateArgs(float newScale, bool scaleInPlace, Vector3 pivotPoint)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	public struct ScaleUniformUpdateArgs
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public readonly float scaleFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public readonly Vector3 pivotPoint;

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x68B84E0", Offset = "0x68B6EE0", VA = "0x1868B84E0")]
		public ScaleUniformUpdateArgs(float scaleFactor, Vector3 pivotPoint)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	public struct TransformArgs
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public readonly Guid[] targets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public readonly bool hasRotations;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public readonly bool hasScales;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public readonly bool hasDeformations;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public readonly Vector3[] positions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public readonly Quaternion[] rotations;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public readonly float[] scales;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public readonly Dictionary<Guid, Vector3> deformations;

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x9A34AA0", Offset = "0x9A334A0", VA = "0x189A34AA0")]
		public TransformArgs(Guid[] objectGuids, Vector3[] positions, Quaternion[] rotations, float[] scales, Dictionary<Guid, Vector3> deformations, bool hasRotations = true, bool hasScales = true, bool hasDeformations = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x9A348E0", Offset = "0x9A332E0", VA = "0x189A348E0")]
		private static void UXLBVXMBELN(Dictionary<Guid, Vector3> a, int b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	public static class MakerContainer
	{
		[Cpp2IlInjected.Token(Token = "0x200009B")]
		private struct MakerContainerBackingData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DA")]
			public bool isValid;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000DB")]
			public ZUKUOYIIEVW Container;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000DC")]
			public ZUKUOYIIEVW CachedParentContainer;
		}

		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private static MakerContainerBackingData VJWGCSRNSIL;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static CancellationToken SOUCDIKPLPR
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x9A33CE0", Offset = "0x9A326E0", VA = "0x189A33CE0")]
			get
			{
				return default(CancellationToken);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		internal static ZUKUOYIIEVW XVSRBKGSWYF
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x9A33C50", Offset = "0x9A32650", VA = "0x189A33C50")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x9A33D00", Offset = "0x9A32700", VA = "0x189A33D00")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x9A33DC0", Offset = "0x9A327C0", VA = "0x189A33DC0")]
		[BRMSZAJTATI.Room]
		internal static void RVLHKCZZZLE(ZUKUOYIIEVW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x9A33EC0", Offset = "0x9A328C0", VA = "0x189A33EC0")]
		public static void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x9A33D70", Offset = "0x9A32770", VA = "0x189A33D70")]
		private static ZUKUOYIIEVW KRFJLWQWSUZ(ZUKUOYIIEVW a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public static class OYXBTSLLRJT
	{
		[Cpp2IlInjected.Token(Token = "0x200009D")]
		public enum MakerDataType
		{
			[Cpp2IlInjected.Token(Token = "0x40000DE")]
			ICreationContextObject,
			[Cpp2IlInjected.Token(Token = "0x40000DF")]
			Guid
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x3D98A80", Offset = "0x3D97480", VA = "0x183D98A80")]
		public static void EWFLDILZCAU<a>(a a, MakerDataType b) where a : class
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x3D98BD0", Offset = "0x3D975D0", VA = "0x183D98BD0")]
		public static void EWFLDILZCAU<b>(b a) where b : class
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x3D98A30", Offset = "0x3D97430", VA = "0x183D98A30")]
		public static void EWFLDILZCAU<c, TImpl, c>() where c : class where TImpl : notnull, c where c : class
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x3D98D20", Offset = "0x3D97720", VA = "0x183D98D20")]
		public static void PUGSUAMAZRV<d>(d a) where d : class
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x3D98C80", Offset = "0x3D97680", VA = "0x183D98C80")]
		public static T Get<T>(MakerDataType type) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x3D98730", Offset = "0x3D97130", VA = "0x183D98730")]
		public static bool AYXHVHWMWNX<f>(MakerDataType a, f? failval, [Out][NotNullWhen(true)][MaybeNullWhen(false)] f retval) where f : class
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x3D98860", Offset = "0x3D97260", VA = "0x183D98860")]
		public static bool BFHSQUOPEQI<g>(MakerDataType a, [Out][NotNullWhen(true)][MaybeNullWhen(false)] g foundService) where g : class
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x3D98DF0", Offset = "0x3D977F0", VA = "0x183D98DF0")]
		public static bool TXVHKMUVWOO<h>(MakerDataType a) where h : class
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x3D98C40", Offset = "0x3D97640", VA = "0x183D98C40")]
		public static T Get<T>() where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x3D98670", Offset = "0x3D97070", VA = "0x183D98670")]
		public static bool AYXHVHWMWNX<i>(i a, [Out] i b) where i : class
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x3D98E90", Offset = "0x3D97890", VA = "0x183D98E90")]
		public static bool TXVHKMUVWOO<j>() where j : class
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009E")]
	internal static class GPHBFTCDOEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x9A33950", Offset = "0x9A32350", VA = "0x189A33950")]
		public static void EMREQZUPRUL(IEnumerable a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x3B0B950", Offset = "0x3B0A350", VA = "0x183B0B950")]
		public static void EMREQZUPRUL<T>(T[] a) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x3B0BD80", Offset = "0x3B0A780", VA = "0x183B0BD80")]
		public static void EMREQZUPRUL<T>(T a) where T : notnull, Enum
		{
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
