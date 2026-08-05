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
		[Cpp2IlInjected.Address(RVA = "0xACE190", Offset = "0xACD590", VA = "0x180ACE190")]
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
		[Cpp2IlInjected.Address(RVA = "0x82ED220", Offset = "0x82EC620", VA = "0x1882ED220")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xACEB40", Offset = "0xACDF40", VA = "0x180ACEB40")]
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
		[Cpp2IlInjected.Address(RVA = "0xACEB80", Offset = "0xACDF80", VA = "0x180ACEB80")]
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
		[Cpp2IlInjected.Address(RVA = "0x82EE450", Offset = "0x82ED850", VA = "0x1882EE450", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x26F2710", Offset = "0x26F1B10", VA = "0x1826F2710")]
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
	public interface DGLLOQQFSZH<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "0")]
		b IOUTBMDEHWZ(a a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public interface ETDMRSKGUYM<a> where a : notnull
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
	public interface MHYMAFXIAHC<a> : FLXWPVJMIOM, XCZUGIGZWXG<a>, XXVZRVFMTDE<a>, RAEFLYNUPDS<a>, VMWLUFETJJX, UCAUUKBAPHJ<a>, PEKBZCJVTDT, GKFKZZELSEH
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public interface UCAUUKBAPHJ<a> where a : notnull
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
	public interface FLXWPVJMIOM
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		Bounds ZERGONYKTVL
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		Transform IGOYXFRXHVO
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		Bounds PAPMUDOOFPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		Transform XXOCEGIHHQX
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		Vector3 LPNZSONGSCQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		bool EZZRKRTXVCA
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
	public interface GKFKZZELSEH
	{
		[Cpp2IlInjected.Token(Token = "0x17000007")]
		NHBLQESUHLS TITJRBSNNFG
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public interface PVCDOIFQIXQ
	{
		[Cpp2IlInjected.Token(Token = "0x17000008")]
		bool KDICEEHXCEI
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		bool HECFLGYRLNQ
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		bool FUJAHSUQGJU
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
	public interface RAEFLYNUPDS<a> where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		bool AMRMIXPMMMQ
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		int ZCINLAWDRUD
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		IEnumerable<a> UUNARLXDUNJ
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
	public interface XCZUGIGZWXG<a> where a : notnull
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
	public interface PEKBZCJVTDT
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void OnSelectionPickedUp();

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void OnSelectionReleased();
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public interface VMWLUFETJJX
	{
		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		bool FXKYOQENYTU
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		bool RXQZYLBFYJR
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		bool DCVMDPSLHPU
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		bool MNKEFDRWBDD
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
		[Cpp2IlInjected.Address(RVA = "0x5697400", Offset = "0x5696800", VA = "0x185697400")]
		public AdjustLightArgs(IEnumerable<TData> targets, bool emit, float? intensity, float? range, float? angle, bool undoable)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public interface FVVLIJOVIXL<a>
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool UYRAXZXWIPH([In] AdjustLightArgs<a> args);
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class NWTKPDUUDQH<a> : OXYWNMCKRNS<FVVLIJOVIXL<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly AdjustLightArgs<a> QBYWFKQMVWH;

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5863400", Offset = "0x5862800", VA = "0x185863400")]
		public NWTKPDUUDQH(IEnumerable<a> a, bool b, float? c, float? d, float? e, bool f, FVVLIJOVIXL<a> g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x4D8C6E0", Offset = "0x4D8BAE0", VA = "0x184D8C6E0", Slot = "4")]
		public override bool UYRAXZXWIPH()
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
		[Cpp2IlInjected.Address(RVA = "0x572BB90", Offset = "0x572AF90", VA = "0x18572BB90")]
		public ApplyImageAtomicArgs(IEnumerable<TData> targets, string imageName, bool isTileable, bool undoable)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface IHRQCXFMIXM<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool UYRAXZXWIPH([In] ApplyImageAtomicArgs<a> args);
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class KRAIFSAHVUM<a> : OXYWNMCKRNS<IHRQCXFMIXM<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly ApplyImageAtomicArgs<a> QBYWFKQMVWH;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x524FC20", Offset = "0x524F020", VA = "0x18524FC20")]
		public KRAIFSAHVUM(IEnumerable<a> a, string b, bool c, bool d, IHRQCXFMIXM<a> e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x4D8C6E0", Offset = "0x4D8BAE0", VA = "0x184D8C6E0", Slot = "4")]
		public override bool UYRAXZXWIPH()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public abstract class OXYWNMCKRNS<a> : WUTSJZDVXPO<a, bool> where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x3F4BF20", Offset = "0x3F4B320", VA = "0x183F4BF20")]
		public OXYWNMCKRNS(a a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public abstract class ZZXIBPVTPVR<a, b> : WUTSJZDVXPO<a, Task<b>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3F4BF20", Offset = "0x3F4B320", VA = "0x183F4BF20")]
		public ZZXIBPVTPVR(a a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public abstract class WUTSJZDVXPO<a, b> where a : notnull where b : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		protected a MCYMNUWHCMD;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x65C61F0", Offset = "0x65C55F0", VA = "0x1865C61F0")]
		public WUTSJZDVXPO(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract b UYRAXZXWIPH();
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public abstract class LABKHOTQWSG<a, b> : WUTSJZDVXPO<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x3F4BF20", Offset = "0x3F4B320", VA = "0x183F4BF20")]
		public LABKHOTQWSG(a a)
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
		[Cpp2IlInjected.Address(RVA = "0x1B6F5A0", Offset = "0x1B6E9A0", VA = "0x181B6F5A0")]
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
		[Cpp2IlInjected.Address(RVA = "0xDDEE90", Offset = "0xDDE290", VA = "0x180DDEE90")]
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
		[Cpp2IlInjected.Address(RVA = "0xBB8570", Offset = "0xBB7970", VA = "0x180BB8570")]
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
		[Cpp2IlInjected.Address(RVA = "0x82EC600", Offset = "0x82EBA00", VA = "0x1882EC600")]
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
		[Cpp2IlInjected.Address(RVA = "0x2471790", Offset = "0x2470B90", VA = "0x182471790")]
		public CircuitsV2UngroupingArgs(Guid boardNodeId, bool undoable)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public interface UKKFQKPVJMX<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		CreationResult ZNKJPTUVVOM(CircuitsV1GroupingArgs<a, b> groupCircuitsArgs);

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "1")]
		CreationResult ZJRKJPKMHBP(CircuitsV1GroupingArgs<a, b> groupCircuitsArgs);

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "2")]
		CreationResult RPWVGINZQNC(CircuitsV1AddArgs<a, b> groupCircuitsArgs);

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "3")]
		CreationResult HYJHWEPPGXP(CircuitsV1RemoveArgs<a> groupCircuitsArgs);
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public interface DCHPSFEMVCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<CreationResult> ZNKJPTUVVOM(CircuitsV2GroupingArgs a);

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<CreationResult> ZJRKJPKMHBP(CircuitsV2UngroupingArgs a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class NSETOZPMTKL<a, b> : LABKHOTQWSG<UKKFQKPVJMX<a, b>, CreationResult>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly CircuitsV1AddArgs<a, b> MENSRRLBIUQ;

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x58589B0", Offset = "0x5857DB0", VA = "0x1858589B0")]
		public NSETOZPMTKL(a a, IEnumerable<b> b, UKKFQKPVJMX<a, b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x58587B0", Offset = "0x5857BB0", VA = "0x1858587B0", Slot = "4")]
		public override CreationResult UYRAXZXWIPH()
		{
			return default(CreationResult);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class LYTWZUCEGXZ<a, b> : LABKHOTQWSG<UKKFQKPVJMX<a, b>, CreationResult>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private readonly CircuitsV1GroupingArgs<a, b> MENSRRLBIUQ;

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x5309540", Offset = "0x5308940", VA = "0x185309540")]
		public LYTWZUCEGXZ(a a, b b, IEnumerable<b> c, UKKFQKPVJMX<a, b> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x53091F0", Offset = "0x53085F0", VA = "0x1853091F0", Slot = "4")]
		public override CreationResult UYRAXZXWIPH()
		{
			return default(CreationResult);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class CWLGBPWLYGM<a, b> : LABKHOTQWSG<UKKFQKPVJMX<a, b>, CreationResult>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private readonly CircuitsV1RemoveArgs<a> MENSRRLBIUQ;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x3E33960", Offset = "0x3E32D60", VA = "0x183E33960")]
		public CWLGBPWLYGM(a a, UKKFQKPVJMX<a, b> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x3E33660", Offset = "0x3E32A60", VA = "0x183E33660", Slot = "4")]
		public override CreationResult UYRAXZXWIPH()
		{
			return default(CreationResult);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class PGFQTZGEZLM<a, b> : LABKHOTQWSG<UKKFQKPVJMX<a, b>, CreationResult>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private readonly CircuitsV1GroupingArgs<a, b> MENSRRLBIUQ;

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x5A4D460", Offset = "0x5A4C860", VA = "0x185A4D460")]
		public PGFQTZGEZLM(a a, b b, IEnumerable<b> c, UKKFQKPVJMX<a, b> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x5A4D380", Offset = "0x5A4C780", VA = "0x185A4D380", Slot = "4")]
		public override CreationResult UYRAXZXWIPH()
		{
			return default(CreationResult);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class PZXFQUFOLKK : ZZXIBPVTPVR<DCHPSFEMVCE, CreationResult>
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
			public PZXFQUFOLKK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private TaskAwaiter<CreationResult> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x82ED9E0", Offset = "0x82ECDE0", VA = "0x1882ED9E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x82EE270", Offset = "0x82ED670", VA = "0x1882EE270", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private CircuitsV2GroupingArgs MENSRRLBIUQ;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x82ED390", Offset = "0x82EC790", VA = "0x1882ED390")]
		public PZXFQUFOLKK(IEnumerable<Guid> a, Guid b, bool c, DCHPSFEMVCE d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x82ED2A0", Offset = "0x82EC6A0", VA = "0x1882ED2A0", Slot = "4")]
		[AsyncStateMachine(typeof(<Execute>d__2))]
		public override Task<CreationResult> UYRAXZXWIPH()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class VNHMDCCJBGD : ZZXIBPVTPVR<DCHPSFEMVCE, CreationResult>
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
			public VNHMDCCJBGD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			private TaskAwaiter<CreationResult> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x82EDC80", Offset = "0x82ED080", VA = "0x1882EDC80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x82EE190", Offset = "0x82ED590", VA = "0x1882EE190", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private readonly CircuitsV2UngroupingArgs MENSRRLBIUQ;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x82EE3D0", Offset = "0x82ED7D0", VA = "0x1882EE3D0")]
		public VNHMDCCJBGD(Guid a, bool b, DCHPSFEMVCE c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x82EE2E0", Offset = "0x82ED6E0", VA = "0x1882EE2E0", Slot = "4")]
		[AsyncStateMachine(typeof(<Execute>d__2))]
		public override Task<CreationResult> UYRAXZXWIPH()
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
		[Cpp2IlInjected.Address(RVA = "0x82EC640", Offset = "0x82EBA40", VA = "0x1882EC640")]
		public CloneArgs(MirrorArgs mirrorArgs, bool undoable)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public interface TCOGHAEARND<a> where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<a> UYRAXZXWIPH(CloneArgs a);
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public class VRIHIMGFYEL<a> : ZZXIBPVTPVR<TCOGHAEARND<a>, a> where a : notnull
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
			public VRIHIMGFYEL<a> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			private TaskAwaiter<a> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x4EA3BE0", Offset = "0x4EA2FE0", VA = "0x184EA3BE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x4EA4090", Offset = "0x4EA3490", VA = "0x184EA4090", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly CloneArgs PUUJFEFBOEW;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6253F20", Offset = "0x6253320", VA = "0x186253F20")]
		public VRIHIMGFYEL(MirrorArgs a, bool b, TCOGHAEARND<a> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6253D70", Offset = "0x6253170", VA = "0x186253D70", Slot = "4")]
		[AsyncStateMachine(typeof(VRIHIMGFYEL<>.<Execute>d__2))]
		public override Task<a> UYRAXZXWIPH()
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
		[Cpp2IlInjected.Address(RVA = "0x82ED180", Offset = "0x82EC580", VA = "0x1882ED180")]
		public MirrorArgs(Transform mirror)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x82ED1F0", Offset = "0x82EC5F0", VA = "0x1882ED1F0")]
		public MirrorArgs(Vector3 normal, Vector3 position)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x82ED0D0", Offset = "0x82EC4D0", VA = "0x1882ED0D0")]
		public static MirrorArgs Clone()
		{
			return default(MirrorArgs);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x82ED100", Offset = "0x82EC500", VA = "0x1882ED100")]
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
		[Cpp2IlInjected.Address(RVA = "0x4121950", Offset = "0x4120D50", VA = "0x184121950")]
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
		[Cpp2IlInjected.Address(RVA = "0x41217D0", Offset = "0x4120BD0", VA = "0x1841217D0")]
		public ConnectFinishArgs(TNode finishNode, TReparentOperations reparentOperations, InteractionType interactionType, bool undoable)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public interface PZLVPMITVIZ<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool HXUCHMWNIEH([In] ConnectStartArgs<a> startArgs);

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool RQWDERDZSZQ([In] ConnectFinishArgs<a, b> finishArgs);

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool ZTFGNYUFDWT();
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class DPYKRSWGPAX<a, b> : OXYWNMCKRNS<PZLVPMITVIZ<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x414FDF0", Offset = "0x414F1F0", VA = "0x18414FDF0")]
		public DPYKRSWGPAX(PZLVPMITVIZ<a, b> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x414FD60", Offset = "0x414F160", VA = "0x18414FD60", Slot = "4")]
		public override bool UYRAXZXWIPH()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public class QZYSBTROOUG<a, b> : OXYWNMCKRNS<PZLVPMITVIZ<a, b>>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private readonly ConnectFinishArgs<a, b> BNBBLUHWIZO;

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x5AF4580", Offset = "0x5AF3980", VA = "0x185AF4580")]
		public QZYSBTROOUG(a a, b b, InteractionType c, PZLVPMITVIZ<a, b> d, bool e = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x3E34500", Offset = "0x3E33900", VA = "0x183E34500", Slot = "4")]
		public override bool UYRAXZXWIPH()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public class OSBDGHEPASD<a, b> : OXYWNMCKRNS<PZLVPMITVIZ<a, b>>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private readonly ConnectStartArgs<a> ZCUWDHYWSVN;

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x599F4B0", Offset = "0x599E8B0", VA = "0x18599F4B0")]
		public OSBDGHEPASD(a a, PZLVPMITVIZ<a, b> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x4D8C6E0", Offset = "0x4D8BAE0", VA = "0x184D8C6E0", Slot = "4")]
		public override bool UYRAXZXWIPH()
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
		[Cpp2IlInjected.Address(RVA = "0x41306A0", Offset = "0x412FAA0", VA = "0x1841306A0")]
		public CreateArgs(TSpawnInfo spawnTypeInformation, Vector3 position, Quaternion rotation, float scale)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public interface LECUECOODEP<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<a> DTWPXICSYAV([In] CreateArgs<b> createArgs, CancellationToken a);
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public class XTYHLTXTWAB<a, b> : ZZXIBPVTPVR<LECUECOODEP<a, b>, a> where a : notnull where b : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private readonly CreateArgs<b> QBYWFKQMVWH;

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x3DBDC10", Offset = "0x3DBD010", VA = "0x183DBDC10")]
		public XTYHLTXTWAB(b a, Vector3 b, Quaternion c, float d, LECUECOODEP<a, b> e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x3DBD930", Offset = "0x3DBCD30", VA = "0x183DBD930", Slot = "4")]
		public override Task<a> UYRAXZXWIPH()
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
		[Cpp2IlInjected.Address(RVA = "0x416F880", Offset = "0x416EC80", VA = "0x18416F880")]
		public DeleteArgs(IEnumerable<TData> targets, bool undoable = false, bool deleteFrozenObjects = false, bool removeCurrentSlectionWhenDelete = true)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public interface YHQTORGPSYJ<a> where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<CreationResult> NQHUXPAVFTY([In] DeleteArgs<a> selectArgs, CancellationToken a);
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public class POKBZOXXOIT<a> : ZZXIBPVTPVR<YHQTORGPSYJ<a>, CreationResult> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private readonly DeleteArgs<a> KLAIGHBNSQY;

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x5A59110", Offset = "0x5A58510", VA = "0x185A59110")]
		public POKBZOXXOIT(IEnumerable<a> a, bool b, YHQTORGPSYJ<a> c, bool d = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x3DBD930", Offset = "0x3DBCD30", VA = "0x183DBD930", Slot = "4")]
		public override Task<CreationResult> UYRAXZXWIPH()
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
		[Cpp2IlInjected.Address(RVA = "0x411F230", Offset = "0x411E630", VA = "0x18411F230")]
		public EditArgs(T newTarget)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public interface KXHBHUGBHTY<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool HXUCHMWNIEH([In] EditArgs<a> editArgs);

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool RQWDERDZSZQ();
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public interface SSUCUSURLPM<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool UYRAXZXWIPH([In] LockArgs<a> lockArgs);
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
		[Cpp2IlInjected.Address(RVA = "0x57967A0", Offset = "0x5795BA0", VA = "0x1857967A0")]
		public LockArgs(T newTarget, bool isLocked)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public class THXKCZHMRAH<a> : OXYWNMCKRNS<KXHBHUGBHTY<a>> where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x414FDF0", Offset = "0x414F1F0", VA = "0x18414FDF0")]
		public THXKCZHMRAH(KXHBHUGBHTY<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x5EEE910", Offset = "0x5EEDD10", VA = "0x185EEE910", Slot = "4")]
		public override bool UYRAXZXWIPH()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public class RQQIGJGFKNY<a> : OXYWNMCKRNS<KXHBHUGBHTY<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private readonly EditArgs<a> JCKWLACJWHN;

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x5B8BDE0", Offset = "0x5B8B1E0", VA = "0x185B8BDE0")]
		public RQQIGJGFKNY(a a, KXHBHUGBHTY<a> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x4D8C6E0", Offset = "0x4D8BAE0", VA = "0x184D8C6E0", Slot = "4")]
		public override bool UYRAXZXWIPH()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public class VBBBDJANNVG<a> : OXYWNMCKRNS<SSUCUSURLPM<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private readonly LockArgs<a> JAGVJBPJECM;

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x62495A0", Offset = "0x62489A0", VA = "0x1862495A0")]
		public VBBBDJANNVG(a a, bool b, SSUCUSURLPM<a> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x4D8C6E0", Offset = "0x4D8BAE0", VA = "0x184D8C6E0", Slot = "4")]
		public override bool UYRAXZXWIPH()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public struct FreezeArgs<TData> where TData : notnull, SPJBMKWLZTJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public IEnumerable<TData> Targets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public bool willFreeze;

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x4DF9A50", Offset = "0x4DF8E50", VA = "0x184DF9A50")]
		public FreezeArgs(IEnumerable<TData> newTargets, bool newWillFreeze)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public struct FreezeListArgs<TData> where TData : notnull, SPJBMKWLZTJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public List<TData> Targets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public List<bool> freezeValues;

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x4DFA2D0", Offset = "0x4DF96D0", VA = "0x184DFA2D0")]
		public FreezeListArgs(List<TData> newTargets, List<bool> newFreezeValues)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public interface SPJBMKWLZTJ
	{
		[Cpp2IlInjected.Token(Token = "0x17000012")]
		bool LYBCQUTALFC
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
	public interface BQKDUNYBPRA<a> where a : SPJBMKWLZTJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool UYRAXZXWIPH([In] FreezeArgs<a> freezeArgs);

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void UYRAXZXWIPH([In] FreezeListArgs<a> freezeArgs);
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public interface SISYSPGNSYD<a> where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool UIVYKWNWQYU(a a);
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public class HWKWBHEJOWI<a> : OXYWNMCKRNS<BQKDUNYBPRA<a>> where a : notnull, SPJBMKWLZTJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private readonly FreezeArgs<a> QNXCKRILBTC;

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x4F4B8B0", Offset = "0x4F4ACB0", VA = "0x184F4B8B0")]
		public HWKWBHEJOWI(List<a> a, bool b, BQKDUNYBPRA<a> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x4D8C6E0", Offset = "0x4D8BAE0", VA = "0x184D8C6E0", Slot = "4")]
		public override bool UYRAXZXWIPH()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public class ZNWYUZEAKYU<a> : OXYWNMCKRNS<BQKDUNYBPRA<a>> where a : notnull, SPJBMKWLZTJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private readonly FreezeListArgs<a> QNXCKRILBTC;

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x3F0AA60", Offset = "0x3F09E60", VA = "0x183F0AA60")]
		public ZNWYUZEAKYU(List<a> a, List<bool> b, BQKDUNYBPRA<a> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x3F0A9A0", Offset = "0x3F09DA0", VA = "0x183F0A9A0", Slot = "4")]
		public override bool UYRAXZXWIPH()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public interface VTZGVBZQJCC<a> where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<CreationResult> UYRAXZXWIPH(MergeShapesArgs<a> mergeShapesArgs);
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public class VLEIDEWKNVS<a> : ZZXIBPVTPVR<VTZGVBZQJCC<a>, CreationResult> where a : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004E")]
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
			public VLEIDEWKNVS<a> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			private TaskAwaiter<CreationResult> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x4EA2CC0", Offset = "0x4EA20C0", VA = "0x184EA2CC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x4EA4130", Offset = "0x4EA3530", VA = "0x184EA4130", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private readonly MergeShapesArgs<a> XFXPDRKXYAG;

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x624F780", Offset = "0x624EB80", VA = "0x18624F780")]
		public VLEIDEWKNVS(a a, IReadOnlyList<a> b, bool c, VTZGVBZQJCC<a> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x624F680", Offset = "0x624EA80", VA = "0x18624F680", Slot = "4")]
		[AsyncStateMachine(typeof(VLEIDEWKNVS<>.<Execute>d__2))]
		public override Task<CreationResult> UYRAXZXWIPH()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
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
		[Cpp2IlInjected.Address(RVA = "0xF02FF0", Offset = "0xF023F0", VA = "0x180F02FF0")]
		public MergeShapesArgs(TData destinationContainer, IReadOnlyList<TData> shapesToMerge, bool undoable)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public interface ILYSMLZQADT<a>
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool UYRAXZXWIPH([In] RecolorAtomicArgs<a> recolorArgs);
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public interface DTXPLUKGCEJ<a>
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void UYRAXZXWIPH([In] RecolorAtomicSpecificArgs<a> recolorArgs);
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public interface WWWUBAQQAAT<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool CZAIGJHDMGI([In] RecolorContinuousArgs<a> recolorArgs);

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void RQWDERDZSZQ();
	}
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public class UZMRWXJDHZV<a> : OXYWNMCKRNS<ILYSMLZQADT<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private readonly RecolorAtomicArgs<a> SGPQCWOSDYH;

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x614E3C0", Offset = "0x614D7C0", VA = "0x18614E3C0")]
		public UZMRWXJDHZV(IEnumerable<a> a, ShapeColor b, ShapeMaterial c, float d, string? imageName, bool e, bool f, ILYSMLZQADT<a> g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x4D8C6E0", Offset = "0x4D8BAE0", VA = "0x184D8C6E0", Slot = "4")]
		public override bool UYRAXZXWIPH()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public class UKOVRSHMAUT<a> : OXYWNMCKRNS<DTXPLUKGCEJ<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private readonly RecolorAtomicSpecificArgs<a> SGPQCWOSDYH;

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x612CC20", Offset = "0x612C020", VA = "0x18612CC20")]
		public UKOVRSHMAUT(a[] a, ShapeColor[] b, ShapeMaterial[] c, float[] d, DTXPLUKGCEJ<a> e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x502EEA0", Offset = "0x502E2A0", VA = "0x18502EEA0", Slot = "4")]
		public override bool UYRAXZXWIPH()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public class BYBASQNOWVL<a> : OXYWNMCKRNS<WWWUBAQQAAT<a>> where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x414FDF0", Offset = "0x414F1F0", VA = "0x18414FDF0")]
		public BYBASQNOWVL(WWWUBAQQAAT<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x6F72750", Offset = "0x6F71B50", VA = "0x186F72750", Slot = "4")]
		public override bool UYRAXZXWIPH()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public class IWHKNCANXIQ<a> : OXYWNMCKRNS<WWWUBAQQAAT<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private readonly RecolorContinuousArgs<a> SGPQCWOSDYH;

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x502EF50", Offset = "0x502E350", VA = "0x18502EF50")]
		public IWHKNCANXIQ(IEnumerable<a> a, ShapeColor b, ShapeMaterial c, float d, WWWUBAQQAAT<a> e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x502EEA0", Offset = "0x502E2A0", VA = "0x18502EEA0", Slot = "4")]
		public override bool UYRAXZXWIPH()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
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
		[Cpp2IlInjected.Address(RVA = "0x5D39790", Offset = "0x5D38B90", VA = "0x185D39790")]
		public RecolorAtomicArgs(IEnumerable<TData> targets, ShapeColor color, ShapeMaterial material, float uvScale, string? imageName, bool? imageTileable, bool undoable)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000058")]
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
		[Cpp2IlInjected.Address(RVA = "0x5D39EC0", Offset = "0x5D392C0", VA = "0x185D39EC0")]
		public RecolorAtomicSpecificArgs(TData[] targets, ShapeColor[] color, ShapeMaterial[] material, float[] uvScale)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
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
		[Cpp2IlInjected.Address(RVA = "0x5D3A400", Offset = "0x5D39800", VA = "0x185D3A400")]
		public RecolorContinuousArgs(IEnumerable<TData> targets, ShapeColor color, ShapeMaterial material, float uvScale)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public interface XXVZRVFMTDE<a> where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool RPWVGINZQNC([In] SelectArgs<a> selectArgs);

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void HYJHWEPPGXP([In] SelectArgs<a> selectArgs);

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void TYELEVTRQQS([In] bool undoAble);

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool KRQTGPLCZGW([In] SelectArgs<a> selectArgs);

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void XSSLJQIQNUG();

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool TXFFDQHTTJD([In] a itemInCache);
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public class SHLAQAQDZYZ<a> : OXYWNMCKRNS<XXVZRVFMTDE<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private readonly SelectArgs<a> TNFVGECMAHJ;

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x5DDCB20", Offset = "0x5DDBF20", VA = "0x185DDCB20")]
		public SHLAQAQDZYZ(List<a> a, XXVZRVFMTDE<a> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x4D8C6E0", Offset = "0x4D8BAE0", VA = "0x184D8C6E0", Slot = "4")]
		public override bool UYRAXZXWIPH()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public class TMWASKSCKTB<a> : OXYWNMCKRNS<XXVZRVFMTDE<a>> where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x414FDF0", Offset = "0x414F1F0", VA = "0x18414FDF0")]
		public TMWASKSCKTB(XXVZRVFMTDE<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x5F00500", Offset = "0x5EFF900", VA = "0x185F00500", Slot = "4")]
		public override bool UYRAXZXWIPH()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public class FUZACEYPZLB<a> : OXYWNMCKRNS<XXVZRVFMTDE<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private readonly bool AKGFUPOANWE;

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x4DA4AD0", Offset = "0x4DA3ED0", VA = "0x184DA4AD0")]
		public FUZACEYPZLB(bool a, XXVZRVFMTDE<a> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x4DA4A70", Offset = "0x4DA3E70", VA = "0x184DA4A70", Slot = "4")]
		public override bool UYRAXZXWIPH()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public class QIYGAUISLAE<a> : OXYWNMCKRNS<XXVZRVFMTDE<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private readonly SelectArgs<a> TNFVGECMAHJ;

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x5AE7670", Offset = "0x5AE6A70", VA = "0x185AE7670")]
		public QIYGAUISLAE(List<a> a, bool b, XXVZRVFMTDE<a> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x3F0A9A0", Offset = "0x3F09DA0", VA = "0x183F0A9A0", Slot = "4")]
		public override bool UYRAXZXWIPH()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public class UHXBYHMFLVW<a> : OXYWNMCKRNS<XXVZRVFMTDE<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private readonly a IWAODDDFVXS;

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x612A410", Offset = "0x6129810", VA = "0x18612A410")]
		public UHXBYHMFLVW(a a, XXVZRVFMTDE<a> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x612A270", Offset = "0x6129670", VA = "0x18612A270", Slot = "4")]
		public override bool UYRAXZXWIPH()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public class GWTCHYLCIRJ<a> : OXYWNMCKRNS<XXVZRVFMTDE<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private readonly SelectArgs<a> TNFVGECMAHJ;

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x4EDD720", Offset = "0x4EDCB20", VA = "0x184EDD720")]
		public GWTCHYLCIRJ(IEnumerable<a> a, XXVZRVFMTDE<a> b, bool c = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x4EDD660", Offset = "0x4EDCA60", VA = "0x184EDD660", Slot = "4")]
		public override bool UYRAXZXWIPH()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public struct SelectArgs<TData> where TData : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public IEnumerable<TData> Targets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public bool undoable;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x5E11F10", Offset = "0x5E11310", VA = "0x185E11F10")]
		public SelectArgs(IEnumerable<TData> newTargets, bool newUndoable = false)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public interface PPWVRWVSFPP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<CreationResult> UYRAXZXWIPH(SplitShapesArgs a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public class APHPJHFXUQD : ZZXIBPVTPVR<PPWVRWVSFPP, CreationResult>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000064")]
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
			public APHPJHFXUQD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			private TaskAwaiter<CreationResult> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x82EDF20", Offset = "0x82ED320", VA = "0x1882EDF20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x82EE200", Offset = "0x82ED600", VA = "0x1882EE200", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private readonly SplitShapesArgs MIENXMOBPJY;

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x82EC590", Offset = "0x82EB990", VA = "0x1882EC590")]
		public APHPJHFXUQD(bool a, PPWVRWVSFPP b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x82EC4A0", Offset = "0x82EB8A0", VA = "0x1882EC4A0", Slot = "4")]
		[AsyncStateMachine(typeof(<Execute>d__2))]
		public override Task<CreationResult> UYRAXZXWIPH()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct SplitShapesArgs
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public bool Undoable;

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x2AC7A40", Offset = "0x2AC6E40", VA = "0x182AC7A40")]
		public SplitShapesArgs(bool undoable)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
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
		[Cpp2IlInjected.Address(RVA = "0x6478120", Offset = "0x6477520", VA = "0x186478120")]
		public AlignArgs(bool translate, bool rotate, bool scale, bool undoable)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x82EC5F0", Offset = "0x82EB9F0", VA = "0x1882EC5F0")]
		public AlignArgs(bool rotate, bool undoable)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public interface UWGDWHEPRJE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool KVCQXUAFQYO(AlignArgs a);

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool NSJMSYLHVSJ(AlignArgs a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public class QKADTEOZUWU : OXYWNMCKRNS<UWGDWHEPRJE>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private readonly AlignArgs NLPRWZGEHOS;

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x82ED4A0", Offset = "0x82EC8A0", VA = "0x1882ED4A0")]
		public QKADTEOZUWU(bool a, bool b, bool c, bool d, UWGDWHEPRJE e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x82ED450", Offset = "0x82EC850", VA = "0x1882ED450", Slot = "4")]
		public override bool UYRAXZXWIPH()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public class IDONIULEHEX : OXYWNMCKRNS<UWGDWHEPRJE>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private readonly AlignArgs NLPRWZGEHOS;

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x82ECA30", Offset = "0x82EBE30", VA = "0x1882ECA30")]
		public IDONIULEHEX(bool a, bool b, UWGDWHEPRJE c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x82EC9E0", Offset = "0x82EBDE0", VA = "0x1882EC9E0", Slot = "4")]
		public override bool UYRAXZXWIPH()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public interface DRJIRDAWNDF
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void UYRAXZXWIPH([In] TransformArgs transformArgs);
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public class GIQPWYUXJPT : OXYWNMCKRNS<DRJIRDAWNDF>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private readonly TransformArgs AXQTPAJEKSD;

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x82EC820", Offset = "0x82EBC20", VA = "0x1882EC820")]
		public GIQPWYUXJPT(Guid[] a, Vector3[] b, Quaternion[] c, float[] d, Dictionary<Guid, Vector3> e, DRJIRDAWNDF f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x82EC770", Offset = "0x82EBB70", VA = "0x1882EC770", Slot = "4")]
		public override bool UYRAXZXWIPH()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public interface ANNLILVZNGJ<a>
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool HXUCHMWNIEH([In] ManipulateStartArgs<a> startArgs);

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool CZAIGJHDMGI([In] ManipulateSetAspectRatioArgs updateArgs);

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool CZAIGJHDMGI([In] ManipulateSetCurvePointPositionAndRadiusArgs updateArgs);

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool RQWDERDZSZQ();
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public class KXWXSPRQPBF<a> : OXYWNMCKRNS<ANNLILVZNGJ<a>> where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x414FDF0", Offset = "0x414F1F0", VA = "0x18414FDF0")]
		public KXWXSPRQPBF(ANNLILVZNGJ<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x5254330", Offset = "0x5253730", VA = "0x185254330", Slot = "4")]
		public override bool UYRAXZXWIPH()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public class DZOSURQPMXQ<a> : OXYWNMCKRNS<ANNLILVZNGJ<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private readonly ManipulateSetAspectRatioArgs NMYHFWDSXMD;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x4153AC0", Offset = "0x4152EC0", VA = "0x184153AC0")]
		public DZOSURQPMXQ(Vector3 a, bool b, ANNLILVZNGJ<a> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x41405C0", Offset = "0x413F9C0", VA = "0x1841405C0", Slot = "4")]
		public override bool UYRAXZXWIPH()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public class NUNLKGLRJVM<a> : OXYWNMCKRNS<ANNLILVZNGJ<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private readonly ManipulateSetCurvePointPositionAndRadiusArgs NMYHFWDSXMD;

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x585BE50", Offset = "0x585B250", VA = "0x18585BE50")]
		public NUNLKGLRJVM(Guid a, int b, Vector3 c, Quaternion d, float e, bool f, ANNLILVZNGJ<a> g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x585BCA0", Offset = "0x585B0A0", VA = "0x18585BCA0", Slot = "4")]
		public override bool UYRAXZXWIPH()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public class KTJTBTRWAZA<a> : OXYWNMCKRNS<ANNLILVZNGJ<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private readonly ManipulateStartArgs<a> NMYHFWDSXMD;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x5253870", Offset = "0x5252C70", VA = "0x185253870")]
		public KTJTBTRWAZA(a a, bool b, ANNLILVZNGJ<a> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x4D8C6E0", Offset = "0x4D8BAE0", VA = "0x184D8C6E0", Slot = "4")]
		public override bool UYRAXZXWIPH()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public struct ManipulateSetAspectRatioArgs
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public readonly Vector3 aspectRatio;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public readonly bool broadcastChangesOverNetwork;

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x82ED070", Offset = "0x82EC470", VA = "0x1882ED070")]
		public ManipulateSetAspectRatioArgs(Vector3 aspectRatio, bool broadcastChangesOverNetwork)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
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
		[Cpp2IlInjected.Address(RVA = "0x82ED090", Offset = "0x82EC490", VA = "0x1882ED090")]
		public ManipulateSetCurvePointPositionAndRadiusArgs(Guid curveShapeId, int index, Vector3 position, Quaternion rotation, float radius, bool broadcastChangesOverNetwork)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public struct ManipulateStartArgs<TData> where TData : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public readonly TData target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public readonly bool undoable;

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x5815880", Offset = "0x5814C80", VA = "0x185815880")]
		public ManipulateStartArgs(TData target, bool undoable)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public interface WFLFPPYSLQS<a>
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool UYRAXZXWIPH([In] MoveArgs<a> moveArgs);

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool UYRAXZXWIPH([In] MoveToArgs<a> moveArgs);
	}
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public interface VMXZXPZKOCM<a>
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool HXUCHMWNIEH([In] MoveStartArgs<a> moveStartArgs);

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool CZAIGJHDMGI([In] MoveUpdateArgs updateArgs);

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool RQWDERDZSZQ();
	}
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public class UIWWLINCUFO<a> : OXYWNMCKRNS<WFLFPPYSLQS<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private readonly MoveArgs<a> RUZHRLPKQCK;

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x612BF90", Offset = "0x612B390", VA = "0x18612BF90")]
		public UIWWLINCUFO(IEnumerable<a> a, Vector3 b, bool c, WFLFPPYSLQS<a> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x4D8C6E0", Offset = "0x4D8BAE0", VA = "0x184D8C6E0", Slot = "4")]
		public override bool UYRAXZXWIPH()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public class TMERQHCECPM<a> : OXYWNMCKRNS<VMXZXPZKOCM<a>> where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x414FDF0", Offset = "0x414F1F0", VA = "0x18414FDF0")]
		public TMERQHCECPM(VMXZXPZKOCM<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x414FD60", Offset = "0x414F160", VA = "0x18414FD60", Slot = "4")]
		public override bool UYRAXZXWIPH()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public class FARJSIJOYSR<a> : OXYWNMCKRNS<VMXZXPZKOCM<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private readonly MoveStartArgs<a> RUZHRLPKQCK;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x4D8C790", Offset = "0x4D8BB90", VA = "0x184D8C790")]
		public FARJSIJOYSR(IEnumerable<a> a, bool b, VMXZXPZKOCM<a> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x4D8C6E0", Offset = "0x4D8BAE0", VA = "0x184D8C6E0", Slot = "4")]
		public override bool UYRAXZXWIPH()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public class FSFTZKRZLWN<a> : OXYWNMCKRNS<WFLFPPYSLQS<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private readonly MoveToArgs<a> RUZHRLPKQCK;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x4DA2B60", Offset = "0x4DA1F60", VA = "0x184DA2B60")]
		public FSFTZKRZLWN(IEnumerable<a> a, Vector3 b, TransformVec3Filter c, bool d, WFLFPPYSLQS<a> e, Space f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x3E34500", Offset = "0x3E33900", VA = "0x183E34500", Slot = "4")]
		public override bool UYRAXZXWIPH()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public class ELXMYOMUBPO<a> : OXYWNMCKRNS<VMXZXPZKOCM<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private readonly MoveUpdateArgs RUZHRLPKQCK;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x476ECC0", Offset = "0x476E0C0", VA = "0x18476ECC0")]
		public ELXMYOMUBPO(Vector3 a, VMXZXPZKOCM<a> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x41405C0", Offset = "0x413F9C0", VA = "0x1841405C0", Slot = "4")]
		public override bool UYRAXZXWIPH()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
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
		[Cpp2IlInjected.Address(RVA = "0x5841080", Offset = "0x5840480", VA = "0x185841080")]
		public MoveArgs(IEnumerable<TData> targets, Vector3 displacement, bool undoable)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public struct MoveStartArgs<TData> where TData : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public readonly IEnumerable<TData> targets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public readonly bool undoable;

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x5841160", Offset = "0x5840560", VA = "0x185841160")]
		public MoveStartArgs(IEnumerable<TData> targets, bool undoable)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
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
		[Cpp2IlInjected.Address(RVA = "0x5841B90", Offset = "0x5840F90", VA = "0x185841B90")]
		public MoveToArgs(IEnumerable<TData> targets, Vector3 worldSpaceDestination, TransformVec3Filter moveToType, bool undoable, Space relativeTo)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	public struct MoveUpdateArgs
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public readonly Vector3 displacement;

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x2AC7790", Offset = "0x2AC6B90", VA = "0x182AC7790")]
		public MoveUpdateArgs(Vector3 displacement)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007F")]
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
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public interface KHPEGFOYFMI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool UYRAXZXWIPH([In] PivotArgs pivotArgs);
	}
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public class GALEOUFICQG : OXYWNMCKRNS<KHPEGFOYFMI>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private readonly PivotArgs DCBRFUIDZRJ;

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x82EC710", Offset = "0x82EBB10", VA = "0x1882EC710")]
		public GALEOUFICQG(bool a, KHPEGFOYFMI b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x82EC660", Offset = "0x82EBA60", VA = "0x1882EC660", Slot = "4")]
		public override bool UYRAXZXWIPH()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	public readonly struct PivotArgs
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public readonly bool undoable;

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x2AC7A40", Offset = "0x2AC6E40", VA = "0x182AC7A40")]
		public PivotArgs(bool undoable)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public interface TBDGSTVRTCM<a>
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool UYRAXZXWIPH([In] RotateArgs<a> rotateArgs);

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool UYRAXZXWIPH([In] RotateToArgs<a> rotateArgs);
	}
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	public interface RBJJZIAKICC<a>
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool HXUCHMWNIEH([In] RotateStartArgs<a> startArgs);

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool CZAIGJHDMGI([In] RotateUpdateArgs updateArgs);

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool RQWDERDZSZQ();
	}
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	public class KHVMXPDWEWC<a> : OXYWNMCKRNS<TBDGSTVRTCM<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private readonly RotateArgs<a> RLKWEGZEHFG;

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x5219B00", Offset = "0x5218F00", VA = "0x185219B00")]
		public KHVMXPDWEWC(IEnumerable<a> a, Quaternion b, Vector3? c, bool d, bool e, TBDGSTVRTCM<a> f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x4D8C6E0", Offset = "0x4D8BAE0", VA = "0x184D8C6E0", Slot = "4")]
		public override bool UYRAXZXWIPH()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public class PHDMKHHYRXK<a> : OXYWNMCKRNS<RBJJZIAKICC<a>> where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x414FDF0", Offset = "0x414F1F0", VA = "0x18414FDF0")]
		public PHDMKHHYRXK(RBJJZIAKICC<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x414FD60", Offset = "0x414F160", VA = "0x18414FD60", Slot = "4")]
		public override bool UYRAXZXWIPH()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public class KQZONNUADSP<a> : OXYWNMCKRNS<RBJJZIAKICC<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private readonly RotateStartArgs<a> RLKWEGZEHFG;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x524F980", Offset = "0x524ED80", VA = "0x18524F980")]
		public KQZONNUADSP(IEnumerable<a> a, bool b, RBJJZIAKICC<a> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x4D8C6E0", Offset = "0x4D8BAE0", VA = "0x184D8C6E0", Slot = "4")]
		public override bool UYRAXZXWIPH()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public class CWRMJNILZBJ<a> : OXYWNMCKRNS<TBDGSTVRTCM<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private readonly RotateToArgs<a> RLKWEGZEHFG;

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x3E345C0", Offset = "0x3E339C0", VA = "0x183E345C0")]
		public CWRMJNILZBJ(IEnumerable<a> a, Quaternion b, TransformVec3Filter c, Vector3? d, bool e, bool f, Space g, TBDGSTVRTCM<a> h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x3E34500", Offset = "0x3E33900", VA = "0x183E34500", Slot = "4")]
		public override bool UYRAXZXWIPH()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public class LHVGGHXAWHY<a> : OXYWNMCKRNS<RBJJZIAKICC<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private readonly RotateUpdateArgs RLKWEGZEHFG;

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x52FB6E0", Offset = "0x52FAAE0", VA = "0x1852FB6E0")]
		public LHVGGHXAWHY(Quaternion a, Vector3? b, bool c, RBJJZIAKICC<a> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x41405C0", Offset = "0x413F9C0", VA = "0x1841405C0", Slot = "4")]
		public override bool UYRAXZXWIPH()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
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
		[Cpp2IlInjected.Address(RVA = "0x5DB9020", Offset = "0x5DB8420", VA = "0x185DB9020")]
		public RotateArgs(IEnumerable<TData> targets, Quaternion displacement, Vector3? pivotPoint, bool rotateInPlace, bool undoable)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public struct RotateStartArgs<TData> where TData : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public readonly IEnumerable<TData> targets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public readonly bool undoable;

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x5DB9100", Offset = "0x5DB8500", VA = "0x185DB9100")]
		public RotateStartArgs(IEnumerable<TData> targets, bool undoable)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008C")]
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
		[Cpp2IlInjected.Address(RVA = "0x5DB9A20", Offset = "0x5DB8E20", VA = "0x185DB9A20")]
		public RotateToArgs(IEnumerable<TData> targets, Quaternion targetRotation, TransformVec3Filter rotateToType, Vector3? pivotPoint, bool rotateInPlace, bool undoable, Space relativeTo)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008D")]
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
		[Cpp2IlInjected.Address(RVA = "0x642B060", Offset = "0x642A460", VA = "0x18642B060")]
		public RotateUpdateArgs(Quaternion displacement, Vector3? pivotPoint, bool rotateInPlace)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	public interface ZVACHJHZGHP<a>
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool HXUCHMWNIEH([In] ScaleStartArgs<a> startArgs);

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool CZAIGJHDMGI([In] ScaleUniformUpdateArgs updateArgs);

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool CZAIGJHDMGI([In] ScaleToUniformUpdateArgs updateArgs);

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool CZAIGJHDMGI([In] ScaleDeformInDirectionUpdateArgs updateArgs);

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool RQWDERDZSZQ();
	}
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public class GNTKJCWPULM<a> : OXYWNMCKRNS<ZVACHJHZGHP<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private readonly ScaleDeformInDirectionUpdateArgs EWIYLDCYRVL;

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x4ED1EA0", Offset = "0x4ED12A0", VA = "0x184ED1EA0")]
		public GNTKJCWPULM(Vector3 a, float b, Vector3 c, bool d, bool e, ZVACHJHZGHP<a> f, Space g = Space.Self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x4ED1D20", Offset = "0x4ED1120", VA = "0x184ED1D20", Slot = "4")]
		public override bool UYRAXZXWIPH()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	public class BJPIDOBJTXN<a> : OXYWNMCKRNS<ZVACHJHZGHP<a>> where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x414FDF0", Offset = "0x414F1F0", VA = "0x18414FDF0")]
		public BJPIDOBJTXN(ZVACHJHZGHP<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x6F67180", Offset = "0x6F66580", VA = "0x186F67180", Slot = "4")]
		public override bool UYRAXZXWIPH()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	public class GELINSJTLFI<a> : OXYWNMCKRNS<ZVACHJHZGHP<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private readonly ScaleStartArgs<a> EWIYLDCYRVL;

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x4EBD8B0", Offset = "0x4EBCCB0", VA = "0x184EBD8B0")]
		public GELINSJTLFI(IEnumerable<a> a, bool b, ZVACHJHZGHP<a> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x4D8C6E0", Offset = "0x4D8BAE0", VA = "0x184D8C6E0", Slot = "4")]
		public override bool UYRAXZXWIPH()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	public class TRDHQZADJSO<a> : OXYWNMCKRNS<ZVACHJHZGHP<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private readonly ScaleToUniformUpdateArgs EWIYLDCYRVL;

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x5F080B0", Offset = "0x5F074B0", VA = "0x185F080B0")]
		public TRDHQZADJSO(float a, bool b, Vector3 c, ZVACHJHZGHP<a> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x585BCA0", Offset = "0x585B0A0", VA = "0x18585BCA0", Slot = "4")]
		public override bool UYRAXZXWIPH()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public class DINQKADHVXZ<a> : OXYWNMCKRNS<ZVACHJHZGHP<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private readonly ScaleUniformUpdateArgs EWIYLDCYRVL;

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x4140620", Offset = "0x413FA20", VA = "0x184140620")]
		public DINQKADHVXZ(float a, Vector3 b, ZVACHJHZGHP<a> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x41405C0", Offset = "0x413F9C0", VA = "0x1841405C0", Slot = "4")]
		public override bool UYRAXZXWIPH()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000094")]
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
		[Cpp2IlInjected.Address(RVA = "0x82ED530", Offset = "0x82EC930", VA = "0x1882ED530")]
		public ScaleDeformInDirectionUpdateArgs(Vector3 scaleDirection, float scaleFactor, Vector3 pivotPoint, bool broadcastChangesOverNetwork, bool scalingUsingAxes, Space relativeTo = Space.Self)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	public struct ScaleStartArgs<TData> where TData : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public readonly IEnumerable<TData> targets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public readonly bool undoable;

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x5E0D4C0", Offset = "0x5E0C8C0", VA = "0x185E0D4C0")]
		public ScaleStartArgs(IEnumerable<TData> targets, bool undoable)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000096")]
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
		[Cpp2IlInjected.Address(RVA = "0x82ED570", Offset = "0x82EC970", VA = "0x1882ED570")]
		public ScaleToUniformUpdateArgs(float newScale, bool scaleInPlace, Vector3 pivotPoint)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	public struct ScaleUniformUpdateArgs
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public readonly float scaleFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public readonly Vector3 pivotPoint;

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x63F47E0", Offset = "0x63F3BE0", VA = "0x1863F47E0")]
		public ScaleUniformUpdateArgs(float scaleFactor, Vector3 pivotPoint)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000098")]
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
		[Cpp2IlInjected.Address(RVA = "0x82ED750", Offset = "0x82ECB50", VA = "0x1882ED750")]
		public TransformArgs(Guid[] objectGuids, Vector3[] positions, Quaternion[] rotations, float[] scales, Dictionary<Guid, Vector3> deformations, bool hasRotations = true, bool hasScales = true, bool hasDeformations = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x82ED590", Offset = "0x82EC990", VA = "0x1882ED590")]
		private static void HNGVTVROCUD(Dictionary<Guid, Vector3> a, int b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	public static class MakerContainer
	{
		[Cpp2IlInjected.Token(Token = "0x200009A")]
		private struct MakerContainerBackingData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DA")]
			public bool isValid;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000DB")]
			public XRSJVGYQFTW Container;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000DC")]
			public XRSJVGYQFTW CachedParentContainer;
		}

		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private static MakerContainerBackingData AMLIGCMHUGH;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static CancellationToken SPHJVOAGGSP
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x82ECCD0", Offset = "0x82EC0D0", VA = "0x1882ECCD0")]
			get
			{
				return default(CancellationToken);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		internal static XRSJVGYQFTW QODWXULLMIF
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x82ECCF0", Offset = "0x82EC0F0", VA = "0x1882ECCF0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x82ECD80", Offset = "0x82EC180", VA = "0x1882ECD80")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x82ECF30", Offset = "0x82EC330", VA = "0x1882ECF30")]
		[CVOOPLRRRUK.Room]
		internal static void VIZGFABUYZU(XRSJVGYQFTW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x82ECDE0", Offset = "0x82EC1E0", VA = "0x1882ECDE0")]
		public static void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x82ED020", Offset = "0x82EC420", VA = "0x1882ED020")]
		private static XRSJVGYQFTW ZZFDUUGWGIR(XRSJVGYQFTW a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	public static class SJZCFSQJFBD
	{
		[Cpp2IlInjected.Token(Token = "0x200009C")]
		public enum MakerDataType
		{
			[Cpp2IlInjected.Token(Token = "0x40000DE")]
			ICreationContextObject,
			[Cpp2IlInjected.Token(Token = "0x40000DF")]
			Guid
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x3A5C5D0", Offset = "0x3A5B9D0", VA = "0x183A5C5D0")]
		public static void CXBFDNSVAME<a>(a a, MakerDataType b) where a : class
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x3A5C720", Offset = "0x3A5BB20", VA = "0x183A5C720")]
		public static void CXBFDNSVAME<b>(b a) where b : class
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x3A5C580", Offset = "0x3A5B980", VA = "0x183A5C580")]
		public static void CXBFDNSVAME<c, TImpl, c>() where c : class where TImpl : notnull, c where c : class
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x3A5C790", Offset = "0x3A5BB90", VA = "0x183A5C790")]
		public static void FHNSZOPRMTN<d>(d a) where d : class
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x3A5C940", Offset = "0x3A5BD40", VA = "0x183A5C940")]
		public static T Get<T>(MakerDataType type) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x3A5CA20", Offset = "0x3A5BE20", VA = "0x183A5CA20")]
		public static bool ICFBJHCLOJX<f>(MakerDataType a, f? failval, [Out][NotNullWhen(true)][MaybeNullWhen(false)] f retval) where f : class
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x3A5CC10", Offset = "0x3A5C010", VA = "0x183A5CC10")]
		public static bool PGJHINATPUE<g>(MakerDataType a, [Out][NotNullWhen(true)][MaybeNullWhen(false)] g foundService) where g : class
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x3A5C8A0", Offset = "0x3A5BCA0", VA = "0x183A5C8A0")]
		public static bool FXKJCVIESWG<h>(MakerDataType a) where h : class
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x3A5C9E0", Offset = "0x3A5BDE0", VA = "0x183A5C9E0")]
		public static T Get<T>() where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x3A5CB50", Offset = "0x3A5BF50", VA = "0x183A5CB50")]
		public static bool ICFBJHCLOJX<i>(i a, [Out] i b) where i : class
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x3A5C860", Offset = "0x3A5BC60", VA = "0x183A5C860")]
		public static bool FXKJCVIESWG<j>() where j : class
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	internal static class KCBYULNHUTE
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x82ECAB0", Offset = "0x82EBEB0", VA = "0x1882ECAB0")]
		public static void ODPAUZMISTJ(IEnumerable a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x37122E0", Offset = "0x37116E0", VA = "0x1837122E0")]
		public static void ODPAUZMISTJ<T>(T[] a) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x3712710", Offset = "0x3711B10", VA = "0x183712710")]
		public static void ODPAUZMISTJ<T>(T a) where T : notnull, Enum
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
