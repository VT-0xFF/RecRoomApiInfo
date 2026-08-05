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
		[Cpp2IlInjected.Address(RVA = "0xAF57C0", Offset = "0xAF47C0", VA = "0x180AF57C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x85022C0", Offset = "0x85012C0", VA = "0x1885022C0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAF5A10", Offset = "0xAF4A10", VA = "0x180AF5A10")]
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
		[Cpp2IlInjected.Address(RVA = "0xAF5A50", Offset = "0xAF4A50", VA = "0x180AF5A50")]
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
		[Cpp2IlInjected.Address(RVA = "0x8503560", Offset = "0x8502560", VA = "0x188503560", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x279CA70", Offset = "0x279BA70", VA = "0x18279CA70")]
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
	public interface BFXUJDQDCHO<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "0")]
		b UWRALJLCMQI(a a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public interface YRKXFGSARLJ<a> where a : notnull
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
	public interface CHPEKYKBMFJ<a> : XJICVBQGYPX, IVDWVZXHOTZ<a>, KVGNUDPHPWP<a>, LLXHPAHDLNF<a>, LMFVJMUJJVU, IHNXRKPLZLW<a>, XCLWERHQVBS, WSFJELDITOE
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public interface IHNXRKPLZLW<a> where a : notnull
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
	public interface XJICVBQGYPX
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		Bounds CAILWGXYCQW
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		Transform QPPNYEZSQLH
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		Bounds OINYUMEPGEZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		Transform XLSBVWYVGME
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		Vector3 STQCUIHDEFP
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		bool MWEPMBEJIDT
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
	public interface WSFJELDITOE
	{
		[Cpp2IlInjected.Token(Token = "0x17000007")]
		ZUUFDARDSJN FGQYWCSCPIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public interface DWJHNOAOUAR
	{
		[Cpp2IlInjected.Token(Token = "0x17000008")]
		bool MXVKIFFEYIV
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		bool SPLEPPOIEGB
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		bool XZYCLUAQTDV
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
	public interface LLXHPAHDLNF<a> where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		bool FIAEDQTHSPP
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		int MPINTFCEPNE
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		IEnumerable<a> RYEORLXMRFQ
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
	public interface IVDWVZXHOTZ<a> where a : notnull
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
	public interface XCLWERHQVBS
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void OnSelectionPickedUp();

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void OnSelectionReleased();
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public interface LMFVJMUJJVU
	{
		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		bool KCCFJDJUYGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		bool AQGQVZOZRJS
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		bool KHJPAUKYJDR
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		bool LBVLQDQILJY
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
		[Cpp2IlInjected.Address(RVA = "0x5B4AFD0", Offset = "0x5B49FD0", VA = "0x185B4AFD0")]
		public AdjustLightArgs(IEnumerable<TData> targets, bool emit, float? intensity, float? range, float? angle, bool undoable)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public interface DZUHJLSYUSU<a>
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool NEGOEFCNXGK([In] AdjustLightArgs<a> args);
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class MGAXGHEYSQY<a> : RCVSCTCJTDT<DZUHJLSYUSU<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly AdjustLightArgs<a> FBCBWCGGMBY;

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5A8B8E0", Offset = "0x5A8A8E0", VA = "0x185A8B8E0")]
		public MGAXGHEYSQY(IEnumerable<a> a, bool b, float? c, float? d, float? e, bool f, DZUHJLSYUSU<a> g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3D780D0", Offset = "0x3D770D0", VA = "0x183D780D0", Slot = "4")]
		public override bool NEGOEFCNXGK()
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
		[Cpp2IlInjected.Address(RVA = "0x5BBFCA0", Offset = "0x5BBECA0", VA = "0x185BBFCA0")]
		public ApplyImageAtomicArgs(IEnumerable<TData> targets, string imageName, bool isTileable, bool undoable)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface AXOPWCGSPQJ<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool NEGOEFCNXGK([In] ApplyImageAtomicArgs<a> args);
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class UIYFXUYISJL<a> : RCVSCTCJTDT<AXOPWCGSPQJ<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly ApplyImageAtomicArgs<a> FBCBWCGGMBY;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x63CCA80", Offset = "0x63CBA80", VA = "0x1863CCA80")]
		public UIYFXUYISJL(IEnumerable<a> a, string b, bool c, bool d, AXOPWCGSPQJ<a> e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3D780D0", Offset = "0x3D770D0", VA = "0x183D780D0", Slot = "4")]
		public override bool NEGOEFCNXGK()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public abstract class RCVSCTCJTDT<a> : PTLXRABUSYF<a, bool> where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x4239BC0", Offset = "0x4238BC0", VA = "0x184239BC0")]
		public RCVSCTCJTDT(a a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public abstract class USYTRPDDTRC<a, b> : PTLXRABUSYF<a, Task<b>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x4239BC0", Offset = "0x4238BC0", VA = "0x184239BC0")]
		public USYTRPDDTRC(a a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public abstract class PTLXRABUSYF<a, b> where a : notnull where b : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		protected a PCBSVTDGTZE;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x5DCECF0", Offset = "0x5DCDCF0", VA = "0x185DCECF0")]
		public PTLXRABUSYF(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract b NEGOEFCNXGK();
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public abstract class DPGTGWEFDUN<a, b> : PTLXRABUSYF<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x4239BC0", Offset = "0x4238BC0", VA = "0x184239BC0")]
		public DPGTGWEFDUN(a a)
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
		[Cpp2IlInjected.Address(RVA = "0x1CB02F0", Offset = "0x1CAF2F0", VA = "0x181CB02F0")]
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
		[Cpp2IlInjected.Address(RVA = "0xE75140", Offset = "0xE74140", VA = "0x180E75140")]
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
		[Cpp2IlInjected.Address(RVA = "0xC41C50", Offset = "0xC40C50", VA = "0x180C41C50")]
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
		[Cpp2IlInjected.Address(RVA = "0x8501A50", Offset = "0x8500A50", VA = "0x188501A50")]
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
		[Cpp2IlInjected.Address(RVA = "0x257C360", Offset = "0x257B360", VA = "0x18257C360")]
		public CircuitsV2UngroupingArgs(Guid boardNodeId, bool undoable)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public interface UFRFBAWEJQI<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		CreationResult UWYSGFZYLJX(CircuitsV1GroupingArgs<a, b> groupCircuitsArgs);

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "1")]
		CreationResult VEYQVPAFTOQ(CircuitsV1GroupingArgs<a, b> groupCircuitsArgs);

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "2")]
		CreationResult IAFSBCMCNOB(CircuitsV1AddArgs<a, b> groupCircuitsArgs);

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "3")]
		CreationResult SYWBDZYXJKO(CircuitsV1RemoveArgs<a> groupCircuitsArgs);
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public interface HKAGSISMZGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<CreationResult> UWYSGFZYLJX(CircuitsV2GroupingArgs a);

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<CreationResult> VEYQVPAFTOQ(CircuitsV2UngroupingArgs a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class LXRNGAUYMIE<a, b> : DPGTGWEFDUN<UFRFBAWEJQI<a, b>, CreationResult>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly CircuitsV1AddArgs<a, b> MDOWTLXUVKX;

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x5575DF0", Offset = "0x5574DF0", VA = "0x185575DF0")]
		public LXRNGAUYMIE(a a, IEnumerable<b> b, UFRFBAWEJQI<a, b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x5575B80", Offset = "0x5574B80", VA = "0x185575B80", Slot = "4")]
		public override CreationResult NEGOEFCNXGK()
		{
			return default(CreationResult);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class ZRLEJWZPXWQ<a, b> : DPGTGWEFDUN<UFRFBAWEJQI<a, b>, CreationResult>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private readonly CircuitsV1GroupingArgs<a, b> MDOWTLXUVKX;

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x3F4CE00", Offset = "0x3F4BE00", VA = "0x183F4CE00")]
		public ZRLEJWZPXWQ(a a, b b, IEnumerable<b> c, UFRFBAWEJQI<a, b> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x3F4CD30", Offset = "0x3F4BD30", VA = "0x183F4CD30", Slot = "4")]
		public override CreationResult NEGOEFCNXGK()
		{
			return default(CreationResult);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class EQRNSKULUKV<a, b> : DPGTGWEFDUN<UFRFBAWEJQI<a, b>, CreationResult>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private readonly CircuitsV1RemoveArgs<a> MDOWTLXUVKX;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x48E1090", Offset = "0x48E0090", VA = "0x1848E1090")]
		public EQRNSKULUKV(a a, UFRFBAWEJQI<a, b> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x48E0C30", Offset = "0x48DFC30", VA = "0x1848E0C30", Slot = "4")]
		public override CreationResult NEGOEFCNXGK()
		{
			return default(CreationResult);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class HGPPJIPUHCR<a, b> : DPGTGWEFDUN<UFRFBAWEJQI<a, b>, CreationResult>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private readonly CircuitsV1GroupingArgs<a, b> MDOWTLXUVKX;

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x3F4CE00", Offset = "0x3F4BE00", VA = "0x183F4CE00")]
		public HGPPJIPUHCR(a a, b b, IEnumerable<b> c, UFRFBAWEJQI<a, b> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x50B38E0", Offset = "0x50B28E0", VA = "0x1850B38E0", Slot = "4")]
		public override CreationResult NEGOEFCNXGK()
		{
			return default(CreationResult);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class UJZCTCPJAKV : USYTRPDDTRC<HKAGSISMZGD, CreationResult>
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
			public UJZCTCPJAKV <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private TaskAwaiter<CreationResult> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x8502EF0", Offset = "0x8501EF0", VA = "0x188502EF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x8503270", Offset = "0x8502270", VA = "0x188503270", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private CircuitsV2GroupingArgs MDOWTLXUVKX;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x85033D0", Offset = "0x85023D0", VA = "0x1885033D0")]
		public UJZCTCPJAKV(IEnumerable<Guid> a, Guid b, bool c, HKAGSISMZGD d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x85032E0", Offset = "0x85022E0", VA = "0x1885032E0", Slot = "4")]
		[AsyncStateMachine(typeof(<Execute>d__2))]
		public override Task<CreationResult> NEGOEFCNXGK()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class IHOZQNYVBNK : USYTRPDDTRC<HKAGSISMZGD, CreationResult>
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
			public IHOZQNYVBNK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			private TaskAwaiter<CreationResult> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x85029E0", Offset = "0x85019E0", VA = "0x1885029E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x8503190", Offset = "0x8502190", VA = "0x188503190", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private readonly CircuitsV2UngroupingArgs MDOWTLXUVKX;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x8501BA0", Offset = "0x8500BA0", VA = "0x188501BA0")]
		public IHOZQNYVBNK(Guid a, bool b, HKAGSISMZGD c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8501AB0", Offset = "0x8500AB0", VA = "0x188501AB0", Slot = "4")]
		[AsyncStateMachine(typeof(<Execute>d__2))]
		public override Task<CreationResult> NEGOEFCNXGK()
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
		[Cpp2IlInjected.Address(RVA = "0x8501A90", Offset = "0x8500A90", VA = "0x188501A90")]
		public CloneArgs(MirrorArgs mirrorArgs, bool undoable)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public interface UYSDJIGXDAA<a> where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<a> NEGOEFCNXGK(CloneArgs a);
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public class KJKMKQASUDO<a> : USYTRPDDTRC<UYSDJIGXDAA<a>, a> where a : notnull
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
			public KJKMKQASUDO<a> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			private TaskAwaiter<a> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x506BCF0", Offset = "0x506ACF0", VA = "0x18506BCF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x506C460", Offset = "0x506B460", VA = "0x18506C460", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly CloneArgs JQYQQNIYOJH;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x544D030", Offset = "0x544C030", VA = "0x18544D030")]
		public KJKMKQASUDO(MirrorArgs a, bool b, UYSDJIGXDAA<a> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x544CF40", Offset = "0x544BF40", VA = "0x18544CF40", Slot = "4")]
		[AsyncStateMachine(typeof(KJKMKQASUDO<>.<Execute>d__2))]
		public override Task<a> NEGOEFCNXGK()
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
		[Cpp2IlInjected.Address(RVA = "0x8502220", Offset = "0x8501220", VA = "0x188502220")]
		public MirrorArgs(Transform mirror)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x8502290", Offset = "0x8501290", VA = "0x188502290")]
		public MirrorArgs(Vector3 normal, Vector3 position)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x8502170", Offset = "0x8501170", VA = "0x188502170")]
		public static MirrorArgs Clone()
		{
			return default(MirrorArgs);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x85021A0", Offset = "0x85011A0", VA = "0x1885021A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x4163D90", Offset = "0x4162D90", VA = "0x184163D90")]
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
		[Cpp2IlInjected.Address(RVA = "0x4163C10", Offset = "0x4162C10", VA = "0x184163C10")]
		public ConnectFinishArgs(TNode finishNode, TReparentOperations reparentOperations, InteractionType interactionType, bool undoable)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public interface ZJHKAVSUFTW<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool BARESXQJJQG([In] ConnectStartArgs<a> startArgs);

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool CCLPXLCMLMR([In] ConnectFinishArgs<a, b> finishArgs);

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool VBDNXXYOPHW();
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class PSMZDNCKKME<a, b> : RCVSCTCJTDT<ZJHKAVSUFTW<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x3E6A700", Offset = "0x3E69700", VA = "0x183E6A700")]
		public PSMZDNCKKME(ZJHKAVSUFTW<a, b> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x3E6A6B0", Offset = "0x3E696B0", VA = "0x183E6A6B0", Slot = "4")]
		public override bool NEGOEFCNXGK()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public class EANVTQWGJAJ<a, b> : RCVSCTCJTDT<ZJHKAVSUFTW<a, b>>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private readonly ConnectFinishArgs<a, b> DTGNOSZLJLD;

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x489C210", Offset = "0x489B210", VA = "0x18489C210")]
		public EANVTQWGJAJ(a a, b b, InteractionType c, ZJHKAVSUFTW<a, b> d, bool e = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x3D4A850", Offset = "0x3D49850", VA = "0x183D4A850", Slot = "4")]
		public override bool NEGOEFCNXGK()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public class FGKHDYDIKMC<a, b> : RCVSCTCJTDT<ZJHKAVSUFTW<a, b>>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private readonly ConnectStartArgs<a> WDGVRFRYRYQ;

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x4F0BF80", Offset = "0x4F0AF80", VA = "0x184F0BF80")]
		public FGKHDYDIKMC(a a, ZJHKAVSUFTW<a, b> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x3D780D0", Offset = "0x3D770D0", VA = "0x183D780D0", Slot = "4")]
		public override bool NEGOEFCNXGK()
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
		[Cpp2IlInjected.Address(RVA = "0x41737C0", Offset = "0x41727C0", VA = "0x1841737C0")]
		public CreateArgs(TSpawnInfo spawnTypeInformation, Vector3 position, Quaternion rotation, float scale)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public interface IFRNXNINKMQ<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<a> TXYCESTCAYO([In] CreateArgs<b> createArgs, CancellationToken a);
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public class HPETLBKQFNK<a, b> : USYTRPDDTRC<IFRNXNINKMQ<a, b>, a> where a : notnull where b : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private readonly CreateArgs<b> FBCBWCGGMBY;

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x50C0A40", Offset = "0x50BFA40", VA = "0x1850C0A40")]
		public HPETLBKQFNK(b a, Vector3 b, Quaternion c, float d, IFRNXNINKMQ<a, b> e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x50C0770", Offset = "0x50BF770", VA = "0x1850C0770", Slot = "4")]
		public override Task<a> NEGOEFCNXGK()
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
		[Cpp2IlInjected.Address(RVA = "0x4259C80", Offset = "0x4258C80", VA = "0x184259C80")]
		public DeleteArgs(IEnumerable<TData> targets, bool undoable = false, bool deleteFrozenObjects = false, bool removeCurrentSlectionWhenDelete = true)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public interface QKBCKKYUNDY<a> where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<CreationResult> XHUKRSDJEEF([In] DeleteArgs<a> selectArgs, CancellationToken a);
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public class SHKOMLACUTU<a> : USYTRPDDTRC<QKBCKKYUNDY<a>, CreationResult> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private readonly DeleteArgs<a> UVBGFUPNJMF;

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x60D81B0", Offset = "0x60D71B0", VA = "0x1860D81B0")]
		public SHKOMLACUTU(IEnumerable<a> a, bool b, QKBCKKYUNDY<a> c, bool d = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x50C0770", Offset = "0x50BF770", VA = "0x1850C0770", Slot = "4")]
		public override Task<CreationResult> NEGOEFCNXGK()
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
		[Cpp2IlInjected.Address(RVA = "0x41615F0", Offset = "0x41605F0", VA = "0x1841615F0")]
		public EditArgs(T newTarget)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public interface ILYMNDEKVEN<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool BARESXQJJQG([In] EditArgs<a> editArgs);

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool CCLPXLCMLMR();
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public interface TVLFUKGKDVR<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool NEGOEFCNXGK([In] LockArgs<a> lockArgs);
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
		[Cpp2IlInjected.Address(RVA = "0x5A68AC0", Offset = "0x5A67AC0", VA = "0x185A68AC0")]
		public LockArgs(T newTarget, bool isLocked)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public class PNLNCTVIQVM<a> : RCVSCTCJTDT<ILYMNDEKVEN<a>> where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x3E6A700", Offset = "0x3E69700", VA = "0x183E6A700")]
		public PNLNCTVIQVM(ILYMNDEKVEN<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x5DCB540", Offset = "0x5DCA540", VA = "0x185DCB540", Slot = "4")]
		public override bool NEGOEFCNXGK()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public class MJKFZJFBCFP<a> : RCVSCTCJTDT<ILYMNDEKVEN<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private readonly EditArgs<a> TOXOJBTPZTU;

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x5A8EB20", Offset = "0x5A8DB20", VA = "0x185A8EB20")]
		public MJKFZJFBCFP(a a, ILYMNDEKVEN<a> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x3D780D0", Offset = "0x3D770D0", VA = "0x183D780D0", Slot = "4")]
		public override bool NEGOEFCNXGK()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public class NOBXBISJUUH<a> : RCVSCTCJTDT<TVLFUKGKDVR<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private readonly LockArgs<a> IQQQNDXEHJH;

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x5B68E90", Offset = "0x5B67E90", VA = "0x185B68E90")]
		public NOBXBISJUUH(a a, bool b, TVLFUKGKDVR<a> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x3D780D0", Offset = "0x3D770D0", VA = "0x183D780D0", Slot = "4")]
		public override bool NEGOEFCNXGK()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public struct FreezeArgs<TData> where TData : notnull, ZGCUAGYGRLC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public IEnumerable<TData> Targets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public bool willFreeze;

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x4F7A0F0", Offset = "0x4F790F0", VA = "0x184F7A0F0")]
		public FreezeArgs(IEnumerable<TData> newTargets, bool newWillFreeze)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public struct FreezeListArgs<TData> where TData : notnull, ZGCUAGYGRLC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public List<TData> Targets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public List<bool> freezeValues;

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x4F7A9A0", Offset = "0x4F799A0", VA = "0x184F7A9A0")]
		public FreezeListArgs(List<TData> newTargets, List<bool> newFreezeValues)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public interface ZGCUAGYGRLC
	{
		[Cpp2IlInjected.Token(Token = "0x17000012")]
		bool TTMNOURNNTD
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
	public interface GBOLVFRTPHR<a> where a : ZGCUAGYGRLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool NEGOEFCNXGK([In] FreezeArgs<a> freezeArgs);

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void NEGOEFCNXGK([In] FreezeListArgs<a> freezeArgs);
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public interface PNBEYPSGEXG<a> where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool BZPMCCMDFJF(a a);
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public class NKMEYQMOFYP<a> : RCVSCTCJTDT<GBOLVFRTPHR<a>> where a : notnull, ZGCUAGYGRLC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private readonly FreezeArgs<a> LMSRDZPVDQB;

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x5B5D690", Offset = "0x5B5C690", VA = "0x185B5D690")]
		public NKMEYQMOFYP(List<a> a, bool b, GBOLVFRTPHR<a> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x3D780D0", Offset = "0x3D770D0", VA = "0x183D780D0", Slot = "4")]
		public override bool NEGOEFCNXGK()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public class KJEQGIBLJJV<a> : RCVSCTCJTDT<GBOLVFRTPHR<a>> where a : notnull, ZGCUAGYGRLC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private readonly FreezeListArgs<a> LMSRDZPVDQB;

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x5448FA0", Offset = "0x5447FA0", VA = "0x185448FA0")]
		public KJEQGIBLJJV(List<a> a, List<bool> b, GBOLVFRTPHR<a> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x48CDB60", Offset = "0x48CCB60", VA = "0x1848CDB60", Slot = "4")]
		public override bool NEGOEFCNXGK()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public interface HSMDWBPAZOQ : ZGCUAGYGRLC
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public interface TNDSUJZFWYX<a> where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<CreationResult> NEGOEFCNXGK(MergeShapesArgs<a> mergeShapesArgs);
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public class BYUKEMCDULZ<a> : USYTRPDDTRC<TNDSUJZFWYX<a>, CreationResult> where a : notnull
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
			public BYUKEMCDULZ<a> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			private TaskAwaiter<CreationResult> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x506B140", Offset = "0x506A140", VA = "0x18506B140", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x506C640", Offset = "0x506B640", VA = "0x18506C640", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private readonly MergeShapesArgs<a> OLSAXFOEIHR;

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x3D78540", Offset = "0x3D77540", VA = "0x183D78540")]
		public BYUKEMCDULZ(a a, IReadOnlyList<a> b, bool c, TNDSUJZFWYX<a> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x3D78340", Offset = "0x3D77340", VA = "0x183D78340", Slot = "4")]
		[AsyncStateMachine(typeof(BYUKEMCDULZ<>.<Execute>d__2))]
		public override Task<CreationResult> NEGOEFCNXGK()
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
		[Cpp2IlInjected.Address(RVA = "0xF9AC20", Offset = "0xF99C20", VA = "0x180F9AC20")]
		public MergeShapesArgs(TData destinationContainer, IReadOnlyList<TData> shapesToMerge, bool undoable)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public interface MHQXJUMLDTC<a>
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool NEGOEFCNXGK([In] RecolorAtomicArgs<a> recolorArgs);
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public interface RENIAJRMMVW<a>
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void NEGOEFCNXGK([In] RecolorAtomicSpecificArgs<a> recolorArgs);
	}
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public interface PTTJCJDDSTY<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool MOHTAFSDHFN([In] RecolorContinuousArgs<a> recolorArgs);

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void CCLPXLCMLMR();
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public class OGLWXJCKLQA<a> : RCVSCTCJTDT<MHQXJUMLDTC<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private readonly RecolorAtomicArgs<a> SVKKCWINPBC;

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x5CA2930", Offset = "0x5CA1930", VA = "0x185CA2930")]
		public OGLWXJCKLQA(IEnumerable<a> a, ShapeColor b, ShapeMaterial c, float d, string? imageName, bool e, bool f, MHQXJUMLDTC<a> g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x3D780D0", Offset = "0x3D770D0", VA = "0x183D780D0", Slot = "4")]
		public override bool NEGOEFCNXGK()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public class LUTTBSNFOJG<a> : RCVSCTCJTDT<RENIAJRMMVW<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private readonly RecolorAtomicSpecificArgs<a> SVKKCWINPBC;

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x5573E60", Offset = "0x5572E60", VA = "0x185573E60")]
		public LUTTBSNFOJG(a[] a, ShapeColor[] b, ShapeMaterial[] c, float[] d, RENIAJRMMVW<a> e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x3F475B0", Offset = "0x3F465B0", VA = "0x183F475B0", Slot = "4")]
		public override bool NEGOEFCNXGK()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public class HBKGJVLMDKO<a> : RCVSCTCJTDT<PTTJCJDDSTY<a>> where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x3E6A700", Offset = "0x3E69700", VA = "0x183E6A700")]
		public HBKGJVLMDKO(PTTJCJDDSTY<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x50ACE90", Offset = "0x50ABE90", VA = "0x1850ACE90", Slot = "4")]
		public override bool NEGOEFCNXGK()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public class ZLORGHXYMYV<a> : RCVSCTCJTDT<PTTJCJDDSTY<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private readonly RecolorContinuousArgs<a> SVKKCWINPBC;

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x3F47660", Offset = "0x3F46660", VA = "0x183F47660")]
		public ZLORGHXYMYV(IEnumerable<a> a, ShapeColor b, ShapeMaterial c, float d, PTTJCJDDSTY<a> e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x3F475B0", Offset = "0x3F465B0", VA = "0x183F475B0", Slot = "4")]
		public override bool NEGOEFCNXGK()
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
		[Cpp2IlInjected.Address(RVA = "0x60417F0", Offset = "0x60407F0", VA = "0x1860417F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6041F50", Offset = "0x6040F50", VA = "0x186041F50")]
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
		[Cpp2IlInjected.Address(RVA = "0x60424B0", Offset = "0x60414B0", VA = "0x1860424B0")]
		public RecolorContinuousArgs(IEnumerable<TData> targets, ShapeColor color, ShapeMaterial material, float uvScale)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public interface KVGNUDPHPWP<a> where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool IAFSBCMCNOB([In] SelectArgs<a> selectArgs);

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void SYWBDZYXJKO([In] SelectArgs<a> selectArgs);

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void XGUGTNICOXV([In] bool undoAble);

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool KSNVCIIOGZL([In] SelectArgs<a> selectArgs);

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void KOSBOSOAHGV();

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool UGQMFUGINLI([In] a itemInCache);
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public class HIDPIHMVWDW<a> : RCVSCTCJTDT<KVGNUDPHPWP<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private readonly SelectArgs<a> ZJIJFHWHSDE;

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x50B6280", Offset = "0x50B5280", VA = "0x1850B6280")]
		public HIDPIHMVWDW(List<a> a, KVGNUDPHPWP<a> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x3D780D0", Offset = "0x3D770D0", VA = "0x183D780D0", Slot = "4")]
		public override bool NEGOEFCNXGK()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public class ENEZSFUDEDG<a> : RCVSCTCJTDT<KVGNUDPHPWP<a>> where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x3E6A700", Offset = "0x3E69700", VA = "0x183E6A700")]
		public ENEZSFUDEDG(KVGNUDPHPWP<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x48CDDE0", Offset = "0x48CCDE0", VA = "0x1848CDDE0", Slot = "4")]
		public override bool NEGOEFCNXGK()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public class AGMUVDGBEFU<a> : RCVSCTCJTDT<KVGNUDPHPWP<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private readonly bool ZFMRMVDHYNH;

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x58B2060", Offset = "0x58B1060", VA = "0x1858B2060")]
		public AGMUVDGBEFU(bool a, KVGNUDPHPWP<a> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x58B1FB0", Offset = "0x58B0FB0", VA = "0x1858B1FB0", Slot = "4")]
		public override bool NEGOEFCNXGK()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public class EMLTODLOGTB<a> : RCVSCTCJTDT<KVGNUDPHPWP<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private readonly SelectArgs<a> ZJIJFHWHSDE;

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x48CDD50", Offset = "0x48CCD50", VA = "0x1848CDD50")]
		public EMLTODLOGTB(List<a> a, bool b, KVGNUDPHPWP<a> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x48CDB60", Offset = "0x48CCB60", VA = "0x1848CDB60", Slot = "4")]
		public override bool NEGOEFCNXGK()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public class QLTGASQSEIL<a> : RCVSCTCJTDT<KVGNUDPHPWP<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private readonly a VLNSNDHITST;

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x5E38FC0", Offset = "0x5E37FC0", VA = "0x185E38FC0")]
		public QLTGASQSEIL(a a, KVGNUDPHPWP<a> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x5E38E20", Offset = "0x5E37E20", VA = "0x185E38E20", Slot = "4")]
		public override bool NEGOEFCNXGK()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public class QCKSCZLPOVS<a> : RCVSCTCJTDT<KVGNUDPHPWP<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private readonly SelectArgs<a> ZJIJFHWHSDE;

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x5E36160", Offset = "0x5E35160", VA = "0x185E36160")]
		public QCKSCZLPOVS(IEnumerable<a> a, KVGNUDPHPWP<a> b, bool c = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x5E35F70", Offset = "0x5E34F70", VA = "0x185E35F70", Slot = "4")]
		public override bool NEGOEFCNXGK()
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
		[Cpp2IlInjected.Address(RVA = "0x60F8370", Offset = "0x60F7370", VA = "0x1860F8370")]
		public SelectArgs(IEnumerable<TData> newTargets, bool newUndoable = false)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public interface XALSHZGDKRS
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<CreationResult> NEGOEFCNXGK(SplitShapesArgs a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public class KECLSRKQOZC : USYTRPDDTRC<XALSHZGDKRS, CreationResult>
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
			public KECLSRKQOZC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			private TaskAwaiter<CreationResult> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x8502C80", Offset = "0x8501C80", VA = "0x188502C80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x8503200", Offset = "0x8502200", VA = "0x188503200", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private readonly SplitShapesArgs UGXNUJGPSHJ;

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x8501D10", Offset = "0x8500D10", VA = "0x188501D10")]
		public KECLSRKQOZC(bool a, XALSHZGDKRS b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x8501C20", Offset = "0x8500C20", VA = "0x188501C20", Slot = "4")]
		[AsyncStateMachine(typeof(<Execute>d__2))]
		public override Task<CreationResult> NEGOEFCNXGK()
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
		[Cpp2IlInjected.Address(RVA = "0x248B3F0", Offset = "0x248A3F0", VA = "0x18248B3F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x672A940", Offset = "0x6729940", VA = "0x18672A940")]
		public AlignArgs(bool translate, bool rotate, bool scale, bool undoable)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x8501A40", Offset = "0x8500A40", VA = "0x188501A40")]
		public AlignArgs(bool rotate, bool undoable)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public interface QESMIZJCYSH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool FARHXHROBLZ(AlignArgs a);

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool TXLZHZMBKSO(AlignArgs a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public class TQMSQKNTFPR : RCVSCTCJTDT<QESMIZJCYSH>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private readonly AlignArgs AEWYILNTCTT;

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x8502500", Offset = "0x8501500", VA = "0x188502500")]
		public TQMSQKNTFPR(bool a, bool b, bool c, bool d, QESMIZJCYSH e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x85024B0", Offset = "0x85014B0", VA = "0x1885024B0", Slot = "4")]
		public override bool NEGOEFCNXGK()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public class WEERYRRMVQG : RCVSCTCJTDT<QESMIZJCYSH>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private readonly AlignArgs AEWYILNTCTT;

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x85034E0", Offset = "0x85024E0", VA = "0x1885034E0")]
		public WEERYRRMVQG(bool a, bool b, QESMIZJCYSH c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x8503490", Offset = "0x8502490", VA = "0x188503490", Slot = "4")]
		public override bool NEGOEFCNXGK()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public interface WXEKBTVMETE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void NEGOEFCNXGK([In] TransformArgs transformArgs);
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public class ADNOWKQZXIW : RCVSCTCJTDT<WXEKBTVMETE>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private readonly TransformArgs PLXCRGFKFNC;

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x8501660", Offset = "0x8500660", VA = "0x188501660")]
		public ADNOWKQZXIW(Guid[] a, Vector3[] b, Quaternion[] c, float[] d, Dictionary<Guid, Vector3> e, WXEKBTVMETE f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x85015B0", Offset = "0x85005B0", VA = "0x1885015B0", Slot = "4")]
		public override bool NEGOEFCNXGK()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public interface KFGELCPRUVY<a>
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool BARESXQJJQG([In] ManipulateStartArgs<a> startArgs);

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool MOHTAFSDHFN([In] ManipulateSetAspectRatioArgs updateArgs);

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool MOHTAFSDHFN([In] ManipulateSetCurvePointPositionAndRadiusArgs updateArgs);

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool CCLPXLCMLMR();
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public class PSHHURPAXSC<a> : RCVSCTCJTDT<KFGELCPRUVY<a>> where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x3E6A700", Offset = "0x3E69700", VA = "0x183E6A700")]
		public PSHHURPAXSC(KFGELCPRUVY<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x5DCEAA0", Offset = "0x5DCDAA0", VA = "0x185DCEAA0", Slot = "4")]
		public override bool NEGOEFCNXGK()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public class WTVZXZUTFXZ<a> : RCVSCTCJTDT<KFGELCPRUVY<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private readonly ManipulateSetAspectRatioArgs VSFJICQKYQW;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x6870D80", Offset = "0x686FD80", VA = "0x186870D80")]
		public WTVZXZUTFXZ(Vector3 a, bool b, KFGELCPRUVY<a> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x4F120A0", Offset = "0x4F110A0", VA = "0x184F120A0", Slot = "4")]
		public override bool NEGOEFCNXGK()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public class OCXVGJZLFJJ<a> : RCVSCTCJTDT<KFGELCPRUVY<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private readonly ManipulateSetCurvePointPositionAndRadiusArgs VSFJICQKYQW;

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x5C9CDE0", Offset = "0x5C9BDE0", VA = "0x185C9CDE0")]
		public OCXVGJZLFJJ(Guid a, int b, Vector3 c, Quaternion d, float e, bool f, KFGELCPRUVY<a> g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x5C9CC30", Offset = "0x5C9BC30", VA = "0x185C9CC30", Slot = "4")]
		public override bool NEGOEFCNXGK()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public class JCMSHIWWNSF<a> : RCVSCTCJTDT<KFGELCPRUVY<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private readonly ManipulateStartArgs<a> VSFJICQKYQW;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x52A45D0", Offset = "0x52A35D0", VA = "0x1852A45D0")]
		public JCMSHIWWNSF(a a, bool b, KFGELCPRUVY<a> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x3D780D0", Offset = "0x3D770D0", VA = "0x183D780D0", Slot = "4")]
		public override bool NEGOEFCNXGK()
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
		[Cpp2IlInjected.Address(RVA = "0x8502110", Offset = "0x8501110", VA = "0x188502110")]
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
		[Cpp2IlInjected.Address(RVA = "0x8502130", Offset = "0x8501130", VA = "0x188502130")]
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
		[Cpp2IlInjected.Address(RVA = "0x5AD1BD0", Offset = "0x5AD0BD0", VA = "0x185AD1BD0")]
		public ManipulateStartArgs(TData target, bool undoable)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public interface FMRHYTDBJAZ<a>
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool NEGOEFCNXGK([In] MoveArgs<a> moveArgs);

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool NEGOEFCNXGK([In] MoveToArgs<a> moveArgs);
	}
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public interface WARMQQKPLKP<a>
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool BARESXQJJQG([In] MoveStartArgs<a> moveStartArgs);

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool MOHTAFSDHFN([In] MoveUpdateArgs updateArgs);

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool CCLPXLCMLMR();
	}
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public class EVIEWWWFUOZ<a> : RCVSCTCJTDT<FMRHYTDBJAZ<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private readonly MoveArgs<a> RMHLPFYJCVV;

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x48E22F0", Offset = "0x48E12F0", VA = "0x1848E22F0")]
		public EVIEWWWFUOZ(IEnumerable<a> a, Vector3 b, bool c, FMRHYTDBJAZ<a> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x3D780D0", Offset = "0x3D770D0", VA = "0x183D780D0", Slot = "4")]
		public override bool NEGOEFCNXGK()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public class CAIOHLBEPAP<a> : RCVSCTCJTDT<WARMQQKPLKP<a>> where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x3E6A700", Offset = "0x3E69700", VA = "0x183E6A700")]
		public CAIOHLBEPAP(WARMQQKPLKP<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x3E6A6B0", Offset = "0x3E696B0", VA = "0x183E6A6B0", Slot = "4")]
		public override bool NEGOEFCNXGK()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public class BUEXTHSKGPM<a> : RCVSCTCJTDT<WARMQQKPLKP<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private readonly MoveStartArgs<a> RMHLPFYJCVV;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x3D78220", Offset = "0x3D77220", VA = "0x183D78220")]
		public BUEXTHSKGPM(IEnumerable<a> a, bool b, WARMQQKPLKP<a> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x3D780D0", Offset = "0x3D770D0", VA = "0x183D780D0", Slot = "4")]
		public override bool NEGOEFCNXGK()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public class YYPPHGXPXGQ<a> : RCVSCTCJTDT<FMRHYTDBJAZ<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private readonly MoveToArgs<a> RMHLPFYJCVV;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x3F314C0", Offset = "0x3F304C0", VA = "0x183F314C0")]
		public YYPPHGXPXGQ(IEnumerable<a> a, Vector3 b, TransformVec3Filter c, bool d, FMRHYTDBJAZ<a> e, Space f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x3D4A850", Offset = "0x3D49850", VA = "0x183D4A850", Slot = "4")]
		public override bool NEGOEFCNXGK()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public class KRKPKZSLEZP<a> : RCVSCTCJTDT<WARMQQKPLKP<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private readonly MoveUpdateArgs RMHLPFYJCVV;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x5461880", Offset = "0x5460880", VA = "0x185461880")]
		public KRKPKZSLEZP(Vector3 a, WARMQQKPLKP<a> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x4F120A0", Offset = "0x4F110A0", VA = "0x184F120A0", Slot = "4")]
		public override bool NEGOEFCNXGK()
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
		[Cpp2IlInjected.Address(RVA = "0x5AFD0E0", Offset = "0x5AFC0E0", VA = "0x185AFD0E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5AFD1C0", Offset = "0x5AFC1C0", VA = "0x185AFD1C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5AFDC30", Offset = "0x5AFCC30", VA = "0x185AFDC30")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B739D0", Offset = "0x2B729D0", VA = "0x182B739D0")]
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
	public interface MMTXRACBHQR
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool NEGOEFCNXGK([In] PivotArgs pivotArgs);
	}
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	public class PXEWYJYJOWR : RCVSCTCJTDT<MMTXRACBHQR>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private readonly PivotArgs IEOTHTEWVDC;

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x85023F0", Offset = "0x85013F0", VA = "0x1885023F0")]
		public PXEWYJYJOWR(bool a, MMTXRACBHQR b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x8502340", Offset = "0x8501340", VA = "0x188502340", Slot = "4")]
		public override bool NEGOEFCNXGK()
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
		[Cpp2IlInjected.Address(RVA = "0x248B3F0", Offset = "0x248A3F0", VA = "0x18248B3F0")]
		public PivotArgs(bool undoable)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	public interface CDRLRGFNFTV<a>
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool NEGOEFCNXGK([In] RotateArgs<a> rotateArgs);

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool NEGOEFCNXGK([In] RotateToArgs<a> rotateArgs);
	}
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	public interface PBXRQPKDLFL<a>
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool BARESXQJJQG([In] RotateStartArgs<a> startArgs);

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool MOHTAFSDHFN([In] RotateUpdateArgs updateArgs);

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool CCLPXLCMLMR();
	}
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public class RXIGEWZBCYX<a> : RCVSCTCJTDT<CDRLRGFNFTV<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private readonly RotateArgs<a> POQGSOITFUV;

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x5EA3EC0", Offset = "0x5EA2EC0", VA = "0x185EA3EC0")]
		public RXIGEWZBCYX(IEnumerable<a> a, Quaternion b, Vector3? c, bool d, bool e, CDRLRGFNFTV<a> f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x3D780D0", Offset = "0x3D770D0", VA = "0x183D780D0", Slot = "4")]
		public override bool NEGOEFCNXGK()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public class DNQODBCHIKV<a> : RCVSCTCJTDT<PBXRQPKDLFL<a>> where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x3E6A700", Offset = "0x3E69700", VA = "0x183E6A700")]
		public DNQODBCHIKV(PBXRQPKDLFL<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x3E6A6B0", Offset = "0x3E696B0", VA = "0x183E6A6B0", Slot = "4")]
		public override bool NEGOEFCNXGK()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public class CNPWIESSWFO<a> : RCVSCTCJTDT<PBXRQPKDLFL<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private readonly RotateStartArgs<a> POQGSOITFUV;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x3ED0F00", Offset = "0x3ECFF00", VA = "0x183ED0F00")]
		public CNPWIESSWFO(IEnumerable<a> a, bool b, PBXRQPKDLFL<a> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x3D780D0", Offset = "0x3D770D0", VA = "0x183D780D0", Slot = "4")]
		public override bool NEGOEFCNXGK()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public class BEZSXUDRTNY<a> : RCVSCTCJTDT<CDRLRGFNFTV<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private readonly RotateToArgs<a> POQGSOITFUV;

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x3D4AA70", Offset = "0x3D49A70", VA = "0x183D4AA70")]
		public BEZSXUDRTNY(IEnumerable<a> a, Quaternion b, TransformVec3Filter c, Vector3? d, bool e, bool f, Space g, CDRLRGFNFTV<a> h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x3D4A850", Offset = "0x3D49850", VA = "0x183D4A850", Slot = "4")]
		public override bool NEGOEFCNXGK()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public class FOLVIDPCXSD<a> : RCVSCTCJTDT<PBXRQPKDLFL<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private readonly RotateUpdateArgs POQGSOITFUV;

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x4F121F0", Offset = "0x4F111F0", VA = "0x184F121F0")]
		public FOLVIDPCXSD(Quaternion a, Vector3? b, bool c, PBXRQPKDLFL<a> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x4F120A0", Offset = "0x4F110A0", VA = "0x184F120A0", Slot = "4")]
		public override bool NEGOEFCNXGK()
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
		[Cpp2IlInjected.Address(RVA = "0x60CF210", Offset = "0x60CE210", VA = "0x1860CF210")]
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
		[Cpp2IlInjected.Address(RVA = "0x60CF300", Offset = "0x60CE300", VA = "0x1860CF300")]
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
		[Cpp2IlInjected.Address(RVA = "0x60CFC60", Offset = "0x60CEC60", VA = "0x1860CFC60")]
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
		[Cpp2IlInjected.Address(RVA = "0x66D2B30", Offset = "0x66D1B30", VA = "0x1866D2B30")]
		public RotateUpdateArgs(Quaternion displacement, Vector3? pivotPoint, bool rotateInPlace)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public interface MJRQOZOABWI<a>
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool BARESXQJJQG([In] ScaleStartArgs<a> startArgs);

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool MOHTAFSDHFN([In] ScaleUniformUpdateArgs updateArgs);

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool MOHTAFSDHFN([In] ScaleToUniformUpdateArgs updateArgs);

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool MOHTAFSDHFN([In] ScaleDeformInDirectionUpdateArgs updateArgs);

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool CCLPXLCMLMR();
	}
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	public class NVADYVVLTBN<a> : RCVSCTCJTDT<MJRQOZOABWI<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private readonly ScaleDeformInDirectionUpdateArgs TBKKMCFGAFQ;

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x5B71CB0", Offset = "0x5B70CB0", VA = "0x185B71CB0")]
		public NVADYVVLTBN(Vector3 a, float b, Vector3 c, bool d, bool e, MJRQOZOABWI<a> f, Space g = Space.Self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x5B71C50", Offset = "0x5B70C50", VA = "0x185B71C50", Slot = "4")]
		public override bool NEGOEFCNXGK()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	public class XLTYHCXQOPO<a> : RCVSCTCJTDT<MJRQOZOABWI<a>> where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x3E6A700", Offset = "0x3E69700", VA = "0x183E6A700")]
		public XLTYHCXQOPO(MJRQOZOABWI<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x3E97880", Offset = "0x3E96880", VA = "0x183E97880", Slot = "4")]
		public override bool NEGOEFCNXGK()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	public class VNEWFDYUVJJ<a> : RCVSCTCJTDT<MJRQOZOABWI<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private readonly ScaleStartArgs<a> TBKKMCFGAFQ;

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x64E55A0", Offset = "0x64E45A0", VA = "0x1864E55A0")]
		public VNEWFDYUVJJ(IEnumerable<a> a, bool b, MJRQOZOABWI<a> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x3D780D0", Offset = "0x3D770D0", VA = "0x183D780D0", Slot = "4")]
		public override bool NEGOEFCNXGK()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public class UFUSUOCJOAH<a> : RCVSCTCJTDT<MJRQOZOABWI<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private readonly ScaleToUniformUpdateArgs TBKKMCFGAFQ;

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x63B4C80", Offset = "0x63B3C80", VA = "0x1863B4C80")]
		public UFUSUOCJOAH(float a, bool b, Vector3 c, MJRQOZOABWI<a> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x5C9CC30", Offset = "0x5C9BC30", VA = "0x185C9CC30", Slot = "4")]
		public override bool NEGOEFCNXGK()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	public class AROZMFSJUQK<a> : RCVSCTCJTDT<MJRQOZOABWI<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private readonly ScaleUniformUpdateArgs TBKKMCFGAFQ;

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x58B6D00", Offset = "0x58B5D00", VA = "0x1858B6D00")]
		public AROZMFSJUQK(float a, Vector3 b, MJRQOZOABWI<a> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x4F120A0", Offset = "0x4F110A0", VA = "0x184F120A0", Slot = "4")]
		public override bool NEGOEFCNXGK()
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
		[Cpp2IlInjected.Address(RVA = "0x8502450", Offset = "0x8501450", VA = "0x188502450")]
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
		[Cpp2IlInjected.Address(RVA = "0x60F37F0", Offset = "0x60F27F0", VA = "0x1860F37F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8502490", Offset = "0x8501490", VA = "0x188502490")]
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
		[Cpp2IlInjected.Address(RVA = "0x669C2F0", Offset = "0x669B2F0", VA = "0x18669C2F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8502750", Offset = "0x8501750", VA = "0x188502750")]
		public TransformArgs(Guid[] objectGuids, Vector3[] positions, Quaternion[] rotations, float[] scales, Dictionary<Guid, Vector3> deformations, bool hasRotations = true, bool hasScales = true, bool hasDeformations = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x8502590", Offset = "0x8501590", VA = "0x188502590")]
		private static void PYPRYZFPWLM(Dictionary<Guid, Vector3> a, int b)
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
			public KTJKRWFMICD Container;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000DC")]
			public KTJKRWFMICD CachedParentContainer;
		}

		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private static MakerContainerBackingData CNFMUBENVFS;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static CancellationToken OCHREYSWFNW
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x8501F70", Offset = "0x8500F70", VA = "0x188501F70")]
			get
			{
				return default(CancellationToken);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		internal static KTJKRWFMICD OVSNGMHVFQW
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x8501F90", Offset = "0x8500F90", VA = "0x188501F90")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x8501D70", Offset = "0x8500D70", VA = "0x188501D70")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x8502020", Offset = "0x8501020", VA = "0x188502020")]
		[WUCJGMLKEDZ.Room]
		internal static void XCTAHDYJEMH(KTJKRWFMICD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x8501E20", Offset = "0x8500E20", VA = "0x188501E20")]
		public static void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x8501DD0", Offset = "0x8500DD0", VA = "0x188501DD0")]
		private static KTJKRWFMICD PDORPYVKZFU(KTJKRWFMICD a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public static class ZKHHAIFXIHA
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
		[Cpp2IlInjected.Address(RVA = "0x3C8B0C0", Offset = "0x3C8A0C0", VA = "0x183C8B0C0")]
		public static void YNOBOKKSWXH<a>(a a, MakerDataType b) where a : class
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x3C8B050", Offset = "0x3C8A050", VA = "0x183C8B050")]
		public static void YNOBOKKSWXH<b>(b a) where b : class
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x3C8B000", Offset = "0x3C8A000", VA = "0x183C8B000")]
		public static void YNOBOKKSWXH<c, TImpl, c>() where c : class where TImpl : notnull, c where c : class
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x3C8AD40", Offset = "0x3C89D40", VA = "0x183C8AD40")]
		public static void HZTNYCECFRQ<d>(d a) where d : class
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x3C8ACA0", Offset = "0x3C89CA0", VA = "0x183C8ACA0")]
		public static T Get<T>(MakerDataType type) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x3C8AE10", Offset = "0x3C89E10", VA = "0x183C8AE10")]
		public static bool VVXEDHRPFIY<f>(MakerDataType a, f? failval, [Out][NotNullWhen(true)][MaybeNullWhen(false)] f retval) where f : class
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x3C8A9B0", Offset = "0x3C899B0", VA = "0x183C8A9B0")]
		public static bool DZLEVHOYGUX<g>(MakerDataType a, [Out][NotNullWhen(true)][MaybeNullWhen(false)] g foundService) where g : class
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x3C8AB80", Offset = "0x3C89B80", VA = "0x183C8AB80")]
		public static bool EBQXJZPTZAD<h>(MakerDataType a) where h : class
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x3C8AC60", Offset = "0x3C89C60", VA = "0x183C8AC60")]
		public static T Get<T>() where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x3C8AF40", Offset = "0x3C89F40", VA = "0x183C8AF40")]
		public static bool VVXEDHRPFIY<i>(i a, [Out] i b) where i : class
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x3C8AC20", Offset = "0x3C89C20", VA = "0x183C8AC20")]
		public static bool EBQXJZPTZAD<j>() where j : class
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009E")]
	internal static class ADQETKYAKMV
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x8501820", Offset = "0x8500820", VA = "0x188501820")]
		public static void QQQVSPQNPXQ(IEnumerable a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x30C69B0", Offset = "0x30C59B0", VA = "0x1830C69B0")]
		public static void QQQVSPQNPXQ<T>(T[] a) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x30C6DE0", Offset = "0x30C5DE0", VA = "0x1830C6DE0")]
		public static void QQQVSPQNPXQ<T>(T a) where T : notnull, Enum
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
