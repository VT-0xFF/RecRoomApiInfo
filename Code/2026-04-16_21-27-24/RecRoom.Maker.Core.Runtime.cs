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
		[Cpp2IlInjected.Address(RVA = "0x98A99D0", Offset = "0x98A87D0", VA = "0x1898A99D0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
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

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xD100C0", Offset = "0xD0EEC0", VA = "0x180D100C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x98AB050", Offset = "0x98A9E50", VA = "0x1898AB050", Slot = "8")]
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
	public interface ETZWUSXLUAW<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "0")]
		b BAJFVADEEXI(a a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public interface POHQAMKHGNL<a> where a : notnull
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
	public interface XPXDKOGUNEN<a> : EKESPOUZSEH, YDAAXMKLRHD<a>, YILZWWYYDIZ<a>, NUXNHQJFOMV<a>, BGLNUSAEOJO, QETPPFTMQIO<a>, SXNWBFNAQNI, GQCYBPPKEDY
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public interface QETPPFTMQIO<a> where a : notnull
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
	public interface EKESPOUZSEH
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		Bounds IEENEGEGMCQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		Transform SVRXLKXCJIT
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		Bounds LNRRBCWLERR
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		Transform BPZRWUYJWRQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		Vector3 FNDPDCOCFWT
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		bool MPHETTBVWQH
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
	public interface GQCYBPPKEDY
	{
		[Cpp2IlInjected.Token(Token = "0x17000007")]
		DYNHRMPGIXT VDWUVTQFBYB
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public interface EXDXDQTCGEH
	{
		[Cpp2IlInjected.Token(Token = "0x17000008")]
		bool KHPCXQNQYYT
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		bool CDDYOSTQYSH
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		bool LBHGITLLYPT
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
	public interface NUXNHQJFOMV<a> where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		bool TSYAQHOSRGL
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		int DTDHTHYFPVS
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		IEnumerable<a> OSUUOUFWUIQ
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
	public interface YDAAXMKLRHD<a> where a : notnull
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
	public interface SXNWBFNAQNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void OnSelectionPickedUp();

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void OnSelectionReleased();
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public interface BGLNUSAEOJO
	{
		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		bool HCAJLYPSUGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		bool AMSNMHAJJYC
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		bool TPCFVFOWEIN
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		bool DVZAWUBEXTG
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
		[Cpp2IlInjected.Address(RVA = "0x7352000", Offset = "0x7350E00", VA = "0x187352000")]
		public AdjustLightArgs(IEnumerable<TData> targets, bool emit, float? intensity, float? range, float? angle, bool undoable)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public interface DBQYGNHLFQG<a>
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool XCHLOJVPVOU([In] AdjustLightArgs<a> args);
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class OATYRTGIHUK<a> : GCXBNYMHZQH<DBQYGNHLFQG<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly AdjustLightArgs<a> OTKBBGEHCVG;

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x728FD10", Offset = "0x728EB10", VA = "0x18728FD10")]
		public OATYRTGIHUK(IEnumerable<a> a, bool b, float? c, float? d, float? e, bool f, DBQYGNHLFQG<a> g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x5100C10", Offset = "0x50FFA10", VA = "0x185100C10", Slot = "4")]
		public override bool XCHLOJVPVOU()
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
		[Cpp2IlInjected.Address(RVA = "0x745BA70", Offset = "0x745A870", VA = "0x18745BA70")]
		public ApplyImageAtomicArgs(IEnumerable<TData> targets, string imageName, bool isTileable, bool undoable)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface TTANSNBHNHZ<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool XCHLOJVPVOU([In] ApplyImageAtomicArgs<a> args);
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class ZDTYBQYBIOD<a> : GCXBNYMHZQH<TTANSNBHNHZ<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly ApplyImageAtomicArgs<a> OTKBBGEHCVG;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5100DA0", Offset = "0x50FFBA0", VA = "0x185100DA0")]
		public ZDTYBQYBIOD(IEnumerable<a> a, string b, bool c, bool d, TTANSNBHNHZ<a> e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5100C10", Offset = "0x50FFA10", VA = "0x185100C10", Slot = "4")]
		public override bool XCHLOJVPVOU()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public abstract class GCXBNYMHZQH<a> : SOACTAXVIBF<a, bool> where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x4FFEF20", Offset = "0x4FFDD20", VA = "0x184FFEF20")]
		public GCXBNYMHZQH(a a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public abstract class CQDUWAQPBBE<a, b> : SOACTAXVIBF<a, Task<b>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x4FFEF20", Offset = "0x4FFDD20", VA = "0x184FFEF20")]
		public CQDUWAQPBBE(a a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public abstract class SOACTAXVIBF<a, b> where a : notnull where b : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		protected a HUZHHAGZELO;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x78B1A50", Offset = "0x78B0850", VA = "0x1878B1A50")]
		public SOACTAXVIBF(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract b XCHLOJVPVOU();
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public abstract class UUGWFEMTZFB<a, b> : SOACTAXVIBF<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x4FFEF20", Offset = "0x4FFDD20", VA = "0x184FFEF20")]
		public UUGWFEMTZFB(a a)
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
		[Cpp2IlInjected.Address(RVA = "0x1F2BCE0", Offset = "0x1F2AAE0", VA = "0x181F2BCE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x10D4C40", Offset = "0x10D3A40", VA = "0x1810D4C40")]
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
		[Cpp2IlInjected.Address(RVA = "0xEBF7D0", Offset = "0xEBE5D0", VA = "0x180EBF7D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x98A90A0", Offset = "0x98A7EA0", VA = "0x1898A90A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2817A30", Offset = "0x2816830", VA = "0x182817A30")]
		public CircuitsV2UngroupingArgs(Guid boardNodeId, bool undoable)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public interface FMMHJLEZBZU<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		CreationResult IHFMGIRIMTB(CircuitsV1GroupingArgs<a, b> groupCircuitsArgs);

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "1")]
		CreationResult QNIDFUGFPYS(CircuitsV1GroupingArgs<a, b> groupCircuitsArgs);

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "2")]
		CreationResult OCBGMGSVVHV(CircuitsV1AddArgs<a, b> groupCircuitsArgs);

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "3")]
		CreationResult QNDICFUSHUY(CircuitsV1RemoveArgs<a> groupCircuitsArgs);
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public interface NQINUUPDYYJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<CreationResult> IHFMGIRIMTB(CircuitsV2GroupingArgs a);

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<CreationResult> QNIDFUGFPYS(CircuitsV2UngroupingArgs a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class VTTPSHLQWDQ<a, b> : UUGWFEMTZFB<FMMHJLEZBZU<a, b>, CreationResult>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly CircuitsV1AddArgs<a, b> NCAGPLMUPGV;

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7EBFCD0", Offset = "0x7EBEAD0", VA = "0x187EBFCD0")]
		public VTTPSHLQWDQ(a a, IEnumerable<b> b, FMMHJLEZBZU<a, b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7EBF940", Offset = "0x7EBE740", VA = "0x187EBF940", Slot = "4")]
		public override CreationResult XCHLOJVPVOU()
		{
			return default(CreationResult);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class ZXSODPZECGC<a, b> : UUGWFEMTZFB<FMMHJLEZBZU<a, b>, CreationResult>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private readonly CircuitsV1GroupingArgs<a, b> NCAGPLMUPGV;

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x5093E00", Offset = "0x5092C00", VA = "0x185093E00")]
		public ZXSODPZECGC(a a, b b, IEnumerable<b> c, FMMHJLEZBZU<a, b> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x512FB20", Offset = "0x512E920", VA = "0x18512FB20", Slot = "4")]
		public override CreationResult XCHLOJVPVOU()
		{
			return default(CreationResult);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class DGOHTFNBRWT<a, b> : UUGWFEMTZFB<FMMHJLEZBZU<a, b>, CreationResult>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private readonly CircuitsV1RemoveArgs<a> NCAGPLMUPGV;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x532E010", Offset = "0x532CE10", VA = "0x18532E010")]
		public DGOHTFNBRWT(a a, FMMHJLEZBZU<a, b> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x532DD20", Offset = "0x532CB20", VA = "0x18532DD20", Slot = "4")]
		public override CreationResult XCHLOJVPVOU()
		{
			return default(CreationResult);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class YACWXIJSBGT<a, b> : UUGWFEMTZFB<FMMHJLEZBZU<a, b>, CreationResult>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private readonly CircuitsV1GroupingArgs<a, b> NCAGPLMUPGV;

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x5093E00", Offset = "0x5092C00", VA = "0x185093E00")]
		public YACWXIJSBGT(a a, b b, IEnumerable<b> c, FMMHJLEZBZU<a, b> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x5093AB0", Offset = "0x50928B0", VA = "0x185093AB0", Slot = "4")]
		public override CreationResult XCHLOJVPVOU()
		{
			return default(CreationResult);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class MZQXZQSJUOL : CQDUWAQPBBE<NQINUUPDYYJ, CreationResult>
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
			public MZQXZQSJUOL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private TaskAwaiter<CreationResult> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x98AA6D0", Offset = "0x98A94D0", VA = "0x1898AA6D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x98AA960", Offset = "0x98A9760", VA = "0x1898AA960", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private CircuitsV2GroupingArgs NCAGPLMUPGV;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x98A93A0", Offset = "0x98A81A0", VA = "0x1898A93A0")]
		public MZQXZQSJUOL(IEnumerable<Guid> a, Guid b, bool c, NQINUUPDYYJ d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x98A92B0", Offset = "0x98A80B0", VA = "0x1898A92B0", Slot = "4")]
		[AsyncStateMachine(typeof(<Execute>d__2))]
		public override Task<CreationResult> XCHLOJVPVOU()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class PTRLAMTTOHU : CQDUWAQPBBE<NQINUUPDYYJ, CreationResult>
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
			public PTRLAMTTOHU <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			private TaskAwaiter<CreationResult> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x98AA430", Offset = "0x98A9230", VA = "0x1898AA430", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x98AA9D0", Offset = "0x98A97D0", VA = "0x1898AA9D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private readonly CircuitsV2UngroupingArgs NCAGPLMUPGV;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x98A9B40", Offset = "0x98A8940", VA = "0x1898A9B40")]
		public PTRLAMTTOHU(Guid a, bool b, NQINUUPDYYJ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x98A9A50", Offset = "0x98A8850", VA = "0x1898A9A50", Slot = "4")]
		[AsyncStateMachine(typeof(<Execute>d__2))]
		public override Task<CreationResult> XCHLOJVPVOU()
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
		[Cpp2IlInjected.Address(RVA = "0x98A90E0", Offset = "0x98A7EE0", VA = "0x1898A90E0")]
		public CloneArgs(MirrorArgs mirrorArgs, bool undoable)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public interface TPBECRINXLE<a> where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<a> XCHLOJVPVOU(CloneArgs a);
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public class EFWYLYLSHFE<a> : CQDUWAQPBBE<TPBECRINXLE<a>, a> where a : notnull
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
			public EFWYLYLSHFE<a> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			private TaskAwaiter<a> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x66177F0", Offset = "0x66165F0", VA = "0x1866177F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x6617F20", Offset = "0x6616D20", VA = "0x186617F20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly CloneArgs MTQDBUVQAYH;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x5A831D0", Offset = "0x5A81FD0", VA = "0x185A831D0")]
		public EFWYLYLSHFE(MirrorArgs a, bool b, TPBECRINXLE<a> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x5A82EF0", Offset = "0x5A81CF0", VA = "0x185A82EF0", Slot = "4")]
		[AsyncStateMachine(typeof(EFWYLYLSHFE<>.<Execute>d__2))]
		public override Task<a> XCHLOJVPVOU()
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
		[Cpp2IlInjected.Address(RVA = "0x98A9930", Offset = "0x98A8730", VA = "0x1898A9930")]
		public MirrorArgs(Transform mirror)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x98A99A0", Offset = "0x98A87A0", VA = "0x1898A99A0")]
		public MirrorArgs(Vector3 normal, Vector3 position)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x98A9870", Offset = "0x98A8670", VA = "0x1898A9870")]
		public static MirrorArgs Clone()
		{
			return default(MirrorArgs);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x98A98A0", Offset = "0x98A86A0", VA = "0x1898A98A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x52EF140", Offset = "0x52EDF40", VA = "0x1852EF140")]
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
		[Cpp2IlInjected.Address(RVA = "0x52EEFC0", Offset = "0x52EDDC0", VA = "0x1852EEFC0")]
		public ConnectFinishArgs(TNode finishNode, TReparentOperations reparentOperations, InteractionType interactionType, bool undoable)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public interface OAOBFQEAJYS<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool CIPJVSHWXAU([In] ConnectStartArgs<a> startArgs);

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool KMKHQFVZPIH([In] ConnectFinishArgs<a, b> finishArgs);

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool EMOVCMSHZYS();
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class VJMVXWNLGHM<a, b> : GCXBNYMHZQH<OAOBFQEAJYS<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6795600", Offset = "0x6794400", VA = "0x186795600")]
		public VJMVXWNLGHM(OAOBFQEAJYS<a, b> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x71B4680", Offset = "0x71B3480", VA = "0x1871B4680", Slot = "4")]
		public override bool XCHLOJVPVOU()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public class VOZTUPHKZAP<a, b> : GCXBNYMHZQH<OAOBFQEAJYS<a, b>>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private readonly ConnectFinishArgs<a, b> JIXOQJWKHZJ;

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x7EA5FA0", Offset = "0x7EA4DA0", VA = "0x187EA5FA0")]
		public VOZTUPHKZAP(a a, b b, InteractionType c, OAOBFQEAJYS<a, b> d, bool e = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x4EDB0E0", Offset = "0x4ED9EE0", VA = "0x184EDB0E0", Slot = "4")]
		public override bool XCHLOJVPVOU()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public class PSKUZRQTUQI<a, b> : GCXBNYMHZQH<OAOBFQEAJYS<a, b>>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private readonly ConnectStartArgs<a> UITTSVDZBYC;

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x73B7320", Offset = "0x73B6120", VA = "0x1873B7320")]
		public PSKUZRQTUQI(a a, OAOBFQEAJYS<a, b> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x5100C10", Offset = "0x50FFA10", VA = "0x185100C10", Slot = "4")]
		public override bool XCHLOJVPVOU()
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
		[Cpp2IlInjected.Address(RVA = "0x5304A90", Offset = "0x5303890", VA = "0x185304A90")]
		public CreateArgs(TSpawnInfo spawnTypeInformation, Vector3 position, Quaternion rotation, float scale)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public interface HKJIFVTBFGG<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<a> YPCKTJTGPJC([In] CreateArgs<b> createArgs, CancellationToken a);
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public class OJUALSHUCMK<a, b> : CQDUWAQPBBE<HKJIFVTBFGG<a, b>, a> where a : notnull where b : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private readonly CreateArgs<b> OTKBBGEHCVG;

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x72996A0", Offset = "0x72984A0", VA = "0x1872996A0")]
		public OJUALSHUCMK(b a, Vector3 b, Quaternion c, float d, HKJIFVTBFGG<a, b> e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x4FDA130", Offset = "0x4FD8F30", VA = "0x184FDA130", Slot = "4")]
		public override Task<a> XCHLOJVPVOU()
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
		[Cpp2IlInjected.Address(RVA = "0x5354AF0", Offset = "0x53538F0", VA = "0x185354AF0")]
		public DeleteArgs(IEnumerable<TData> targets, bool undoable = false, bool deleteFrozenObjects = false, bool removeCurrentSlectionWhenDelete = true)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public interface CIYXXQBLZAQ<a> where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<CreationResult> QMFRGLAMFFB([In] DeleteArgs<a> selectArgs, CancellationToken a);
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public class CBEOIGVAKVW<a> : CQDUWAQPBBE<CIYXXQBLZAQ<a>, CreationResult> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private readonly DeleteArgs<a> ZWBEMGZRVNZ;

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x4FDA210", Offset = "0x4FD9010", VA = "0x184FDA210")]
		public CBEOIGVAKVW(IEnumerable<a> a, bool b, CIYXXQBLZAQ<a> c, bool d = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x4FDA130", Offset = "0x4FD8F30", VA = "0x184FDA130", Slot = "4")]
		public override Task<CreationResult> XCHLOJVPVOU()
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
		[Cpp2IlInjected.Address(RVA = "0x52ECA80", Offset = "0x52EB880", VA = "0x1852ECA80")]
		public EditArgs(T newTarget)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public interface MBMMAZAZNDR<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool CIPJVSHWXAU([In] EditArgs<a> editArgs);

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool KMKHQFVZPIH();
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public interface NKJWEWVPSUF<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool XCHLOJVPVOU([In] LockArgs<a> lockArgs);
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
		[Cpp2IlInjected.Address(RVA = "0x6EBDDC0", Offset = "0x6EBCBC0", VA = "0x186EBDDC0")]
		public LockArgs(T newTarget, bool isLocked)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public class UTYXXDHQZIE<a> : GCXBNYMHZQH<MBMMAZAZNDR<a>> where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x6795600", Offset = "0x6794400", VA = "0x186795600")]
		public UTYXXDHQZIE(MBMMAZAZNDR<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x7D8B130", Offset = "0x7D89F30", VA = "0x187D8B130", Slot = "4")]
		public override bool XCHLOJVPVOU()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public class DIRBZOVNBWT<a> : GCXBNYMHZQH<MBMMAZAZNDR<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private readonly EditArgs<a> UNWJRYDGQFS;

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x532E630", Offset = "0x532D430", VA = "0x18532E630")]
		public DIRBZOVNBWT(a a, MBMMAZAZNDR<a> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x5100C10", Offset = "0x50FFA10", VA = "0x185100C10", Slot = "4")]
		public override bool XCHLOJVPVOU()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public class FBHKSZWPIYB<a> : GCXBNYMHZQH<NKJWEWVPSUF<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private readonly LockArgs<a> GNMSGYDSCRN;

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x62957B0", Offset = "0x62945B0", VA = "0x1862957B0")]
		public FBHKSZWPIYB(a a, bool b, NKJWEWVPSUF<a> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x5100C10", Offset = "0x50FFA10", VA = "0x185100C10", Slot = "4")]
		public override bool XCHLOJVPVOU()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public struct FreezeArgs<TData> where TData : notnull, ACAWWOFRNYS
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public IEnumerable<TData> Targets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public bool willFreeze;

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6307100", Offset = "0x6305F00", VA = "0x186307100")]
		public FreezeArgs(IEnumerable<TData> newTargets, bool newWillFreeze)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public struct FreezeListArgs<TData> where TData : notnull, ACAWWOFRNYS
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public List<TData> Targets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public List<bool> freezeValues;

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6307980", Offset = "0x6306780", VA = "0x186307980")]
		public FreezeListArgs(List<TData> newTargets, List<bool> newFreezeValues)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public interface ACAWWOFRNYS
	{
		[Cpp2IlInjected.Token(Token = "0x17000012")]
		bool VMLLIVKIXUT
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
	public interface FDSQNLOIQUJ<a> where a : ACAWWOFRNYS
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool XCHLOJVPVOU([In] FreezeArgs<a> freezeArgs);

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void XCHLOJVPVOU([In] FreezeListArgs<a> freezeArgs);
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public interface BRSZFGJBSDU<a> where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool YNVZKOSOIMZ(a a);
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public class SDAUJWTDTUR<a> : GCXBNYMHZQH<FDSQNLOIQUJ<a>> where a : notnull, ACAWWOFRNYS
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private readonly FreezeArgs<a> PUKORMFWJET;

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x78A8D30", Offset = "0x78A7B30", VA = "0x1878A8D30")]
		public SDAUJWTDTUR(List<a> a, bool b, FDSQNLOIQUJ<a> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x5100C10", Offset = "0x50FFA10", VA = "0x185100C10", Slot = "4")]
		public override bool XCHLOJVPVOU()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public class BJVEWKTQFIV<a> : GCXBNYMHZQH<FDSQNLOIQUJ<a>> where a : notnull, ACAWWOFRNYS
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private readonly FreezeListArgs<a> PUKORMFWJET;

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x4ED8050", Offset = "0x4ED6E50", VA = "0x184ED8050")]
		public BJVEWKTQFIV(List<a> a, List<bool> b, FDSQNLOIQUJ<a> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x4ED7F00", Offset = "0x4ED6D00", VA = "0x184ED7F00", Slot = "4")]
		public override bool XCHLOJVPVOU()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public interface MXICEBJFTKO : ACAWWOFRNYS
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public interface ILHSKYONHOF<a> where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<CreationResult> XCHLOJVPVOU(MergeShapesArgs<a> mergeShapesArgs);
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public class NJEANZSRBUF<a> : CQDUWAQPBBE<ILHSKYONHOF<a>, CreationResult> where a : notnull
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
			public NJEANZSRBUF<a> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			private TaskAwaiter<CreationResult> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x6617510", Offset = "0x6616310", VA = "0x186617510", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x6618090", Offset = "0x6616E90", VA = "0x186618090", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private readonly MergeShapesArgs<a> AZPYTJWCAYR;

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x710A7B0", Offset = "0x71095B0", VA = "0x18710A7B0")]
		public NJEANZSRBUF(a a, IReadOnlyList<a> b, bool c, ILHSKYONHOF<a> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x710A6B0", Offset = "0x71094B0", VA = "0x18710A6B0", Slot = "4")]
		[AsyncStateMachine(typeof(NJEANZSRBUF<>.<Execute>d__2))]
		public override Task<CreationResult> XCHLOJVPVOU()
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
		[Cpp2IlInjected.Address(RVA = "0x1212AE0", Offset = "0x12118E0", VA = "0x181212AE0")]
		public MergeShapesArgs(TData destinationContainer, IReadOnlyList<TData> shapesToMerge, bool undoable)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public interface IYDUMYBVXSW<a>
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool XCHLOJVPVOU([In] RecolorAtomicArgs<a> recolorArgs);
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public interface ENQUZTRTDZU<a>
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void XCHLOJVPVOU([In] RecolorAtomicSpecificArgs<a> recolorArgs);
	}
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public interface YXFRALIJDGY<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool VTWGDNJNRAB([In] RecolorContinuousArgs<a> recolorArgs);

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void KMKHQFVZPIH();
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public class VVTGSBKTERQ<a> : GCXBNYMHZQH<IYDUMYBVXSW<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private readonly RecolorAtomicArgs<a> EFMVYOIWMUO;

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x7EBFFF0", Offset = "0x7EBEDF0", VA = "0x187EBFFF0")]
		public VVTGSBKTERQ(IEnumerable<a> a, ShapeColor b, ShapeMaterial c, float d, string? imageName, bool e, bool f, IYDUMYBVXSW<a> g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x5100C10", Offset = "0x50FFA10", VA = "0x185100C10", Slot = "4")]
		public override bool XCHLOJVPVOU()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public class PJAMHPFIOMG<a> : GCXBNYMHZQH<ENQUZTRTDZU<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private readonly RecolorAtomicSpecificArgs<a> EFMVYOIWMUO;

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x73AF9E0", Offset = "0x73AE7E0", VA = "0x1873AF9E0")]
		public PJAMHPFIOMG(a[] a, ShapeColor[] b, ShapeMaterial[] c, float[] d, ENQUZTRTDZU<a> e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x73AF930", Offset = "0x73AE730", VA = "0x1873AF930", Slot = "4")]
		public override bool XCHLOJVPVOU()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public class OQGVBJUBXSY<a> : GCXBNYMHZQH<YXFRALIJDGY<a>> where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6795600", Offset = "0x6794400", VA = "0x186795600")]
		public OQGVBJUBXSY(YXFRALIJDGY<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x729C370", Offset = "0x729B170", VA = "0x18729C370", Slot = "4")]
		public override bool XCHLOJVPVOU()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public class QXVYKDQBRCP<a> : GCXBNYMHZQH<YXFRALIJDGY<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private readonly RecolorContinuousArgs<a> EFMVYOIWMUO;

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x75FCF80", Offset = "0x75FBD80", VA = "0x1875FCF80")]
		public QXVYKDQBRCP(IEnumerable<a> a, ShapeColor b, ShapeMaterial c, float d, YXFRALIJDGY<a> e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x73AF930", Offset = "0x73AE730", VA = "0x1873AF930", Slot = "4")]
		public override bool XCHLOJVPVOU()
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
		[Cpp2IlInjected.Address(RVA = "0x78210D0", Offset = "0x781FED0", VA = "0x1878210D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7821800", Offset = "0x7820600", VA = "0x187821800")]
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
		[Cpp2IlInjected.Address(RVA = "0x7821D40", Offset = "0x7820B40", VA = "0x187821D40")]
		public RecolorContinuousArgs(IEnumerable<TData> targets, ShapeColor color, ShapeMaterial material, float uvScale)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public interface YILZWWYYDIZ<a> where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool OCBGMGSVVHV([In] SelectArgs<a> selectArgs);

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void QNDICFUSHUY([In] SelectArgs<a> selectArgs);

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void CAAOAYHRMQJ([In] bool undoAble);

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool EUAFXIRDSXB([In] SelectArgs<a> selectArgs);

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void ANVAOVDNOUX();

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool SYAWJPOUDSA([In] a itemInCache);
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public class STYTVYJZQUS<a> : GCXBNYMHZQH<YILZWWYYDIZ<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private readonly SelectArgs<a> LVHJHYZNGQA;

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x78C07F0", Offset = "0x78BF5F0", VA = "0x1878C07F0")]
		public STYTVYJZQUS(List<a> a, YILZWWYYDIZ<a> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x5100C10", Offset = "0x50FFA10", VA = "0x185100C10", Slot = "4")]
		public override bool XCHLOJVPVOU()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public class LNRDIQKIATA<a> : GCXBNYMHZQH<YILZWWYYDIZ<a>> where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6795600", Offset = "0x6794400", VA = "0x186795600")]
		public LNRDIQKIATA(YILZWWYYDIZ<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x68BC510", Offset = "0x68BB310", VA = "0x1868BC510", Slot = "4")]
		public override bool XCHLOJVPVOU()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public class QOVRSWTPFJO<a> : GCXBNYMHZQH<YILZWWYYDIZ<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private readonly bool WDGPZHENEFV;

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x75F95A0", Offset = "0x75F83A0", VA = "0x1875F95A0")]
		public QOVRSWTPFJO(bool a, YILZWWYYDIZ<a> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x75F9540", Offset = "0x75F8340", VA = "0x1875F9540", Slot = "4")]
		public override bool XCHLOJVPVOU()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public class QPPGSTZMQGR<a> : GCXBNYMHZQH<YILZWWYYDIZ<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private readonly SelectArgs<a> LVHJHYZNGQA;

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x75F9760", Offset = "0x75F8560", VA = "0x1875F9760")]
		public QPPGSTZMQGR(List<a> a, bool b, YILZWWYYDIZ<a> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x4ED7F00", Offset = "0x4ED6D00", VA = "0x184ED7F00", Slot = "4")]
		public override bool XCHLOJVPVOU()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public class ITFPUOGFLBD<a> : GCXBNYMHZQH<YILZWWYYDIZ<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private readonly a LHAWRQSFVTT;

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x658A2B0", Offset = "0x65890B0", VA = "0x18658A2B0")]
		public ITFPUOGFLBD(a a, YILZWWYYDIZ<a> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x6589F30", Offset = "0x6588D30", VA = "0x186589F30", Slot = "4")]
		public override bool XCHLOJVPVOU()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public class OGQCBJIZYDY<a> : GCXBNYMHZQH<YILZWWYYDIZ<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private readonly SelectArgs<a> LVHJHYZNGQA;

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x7295BD0", Offset = "0x72949D0", VA = "0x187295BD0")]
		public OGQCBJIZYDY(IEnumerable<a> a, YILZWWYYDIZ<a> b, bool c = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7295A80", Offset = "0x7294880", VA = "0x187295A80", Slot = "4")]
		public override bool XCHLOJVPVOU()
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
		[Cpp2IlInjected.Address(RVA = "0x78CD2F0", Offset = "0x78CC0F0", VA = "0x1878CD2F0")]
		public SelectArgs(IEnumerable<TData> newTargets, bool newUndoable = false)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public interface OYSNYWCWSNE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<CreationResult> XCHLOJVPVOU(SplitShapesArgs a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public class RUHCXPOUJVM : CQDUWAQPBBE<OYSNYWCWSNE, CreationResult>
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
			public RUHCXPOUJVM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			private TaskAwaiter<CreationResult> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x98AA1C0", Offset = "0x98A8FC0", VA = "0x1898AA1C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x98AAA40", Offset = "0x98A9840", VA = "0x1898AAA40", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private readonly SplitShapesArgs UMFOHXSHWYV;

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x98A9CB0", Offset = "0x98A8AB0", VA = "0x1898A9CB0")]
		public RUHCXPOUJVM(bool a, OYSNYWCWSNE b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x98A9BC0", Offset = "0x98A89C0", VA = "0x1898A9BC0", Slot = "4")]
		[AsyncStateMachine(typeof(<Execute>d__2))]
		public override Task<CreationResult> XCHLOJVPVOU()
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
		[Cpp2IlInjected.Address(RVA = "0x2717CC0", Offset = "0x2716AC0", VA = "0x182717CC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x82D81E0", Offset = "0x82D6FE0", VA = "0x1882D81E0")]
		public AlignArgs(bool translate, bool rotate, bool scale, bool undoable)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x98A9090", Offset = "0x98A7E90", VA = "0x1898A9090")]
		public AlignArgs(bool rotate, bool undoable)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public interface QZZQVHRCOHL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool RMFIJDIGHNL(AlignArgs a);

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool WWXZZUMQXZK(AlignArgs a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public class MQVQNVETMIV : GCXBNYMHZQH<QZZQVHRCOHL>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private readonly AlignArgs ULPSZJSUOCH;

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x98A9220", Offset = "0x98A8020", VA = "0x1898A9220")]
		public MQVQNVETMIV(bool a, bool b, bool c, bool d, QZZQVHRCOHL e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x98A91D0", Offset = "0x98A7FD0", VA = "0x1898A91D0", Slot = "4")]
		public override bool XCHLOJVPVOU()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public class KJTMWACICUU : GCXBNYMHZQH<QZZQVHRCOHL>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private readonly AlignArgs ULPSZJSUOCH;

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x98A9150", Offset = "0x98A7F50", VA = "0x1898A9150")]
		public KJTMWACICUU(bool a, bool b, QZZQVHRCOHL c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x98A9100", Offset = "0x98A7F00", VA = "0x1898A9100", Slot = "4")]
		public override bool XCHLOJVPVOU()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public interface MNWCGUZQLZS
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void XCHLOJVPVOU([In] TransformArgs transformArgs);
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public class YMBOVZRPPVG : GCXBNYMHZQH<MNWCGUZQLZS>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private readonly TransformArgs YPCEZFNRFRU;

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x98AAC70", Offset = "0x98A9A70", VA = "0x1898AAC70")]
		public YMBOVZRPPVG(Guid[] a, Vector3[] b, Quaternion[] c, float[] d, Dictionary<Guid, Vector3> e, MNWCGUZQLZS f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x98AABC0", Offset = "0x98A99C0", VA = "0x1898AABC0", Slot = "4")]
		public override bool XCHLOJVPVOU()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public interface XZUGXWUPMUQ<a>
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool CIPJVSHWXAU([In] ManipulateStartArgs<a> startArgs);

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool VTWGDNJNRAB([In] ManipulateSetAspectRatioArgs updateArgs);

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool VTWGDNJNRAB([In] ManipulateSetCurvePointPositionAndRadiusArgs updateArgs);

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool KMKHQFVZPIH();
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public class KOYNIAMZAPC<a> : GCXBNYMHZQH<XZUGXWUPMUQ<a>> where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x6795600", Offset = "0x6794400", VA = "0x186795600")]
		public KOYNIAMZAPC(XZUGXWUPMUQ<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x6795570", Offset = "0x6794370", VA = "0x186795570", Slot = "4")]
		public override bool XCHLOJVPVOU()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public class DZNYSNKRHMF<a> : GCXBNYMHZQH<XZUGXWUPMUQ<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private readonly ManipulateSetAspectRatioArgs TMJBHBTNWZG;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x53391A0", Offset = "0x5337FA0", VA = "0x1853391A0")]
		public DZNYSNKRHMF(Vector3 a, bool b, XZUGXWUPMUQ<a> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x5088DB0", Offset = "0x5087BB0", VA = "0x185088DB0", Slot = "4")]
		public override bool XCHLOJVPVOU()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public class LPMGYEFAUYF<a> : GCXBNYMHZQH<XZUGXWUPMUQ<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private readonly ManipulateSetCurvePointPositionAndRadiusArgs TMJBHBTNWZG;

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x68BE7A0", Offset = "0x68BD5A0", VA = "0x1868BE7A0")]
		public LPMGYEFAUYF(Guid a, int b, Vector3 c, Quaternion d, float e, bool f, XZUGXWUPMUQ<a> g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x68BE740", Offset = "0x68BD540", VA = "0x1868BE740", Slot = "4")]
		public override bool XCHLOJVPVOU()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public class LEWTXAMZBHB<a> : GCXBNYMHZQH<XZUGXWUPMUQ<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private readonly ManipulateStartArgs<a> TMJBHBTNWZG;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x68A39C0", Offset = "0x68A27C0", VA = "0x1868A39C0")]
		public LEWTXAMZBHB(a a, bool b, XZUGXWUPMUQ<a> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x5100C10", Offset = "0x50FFA10", VA = "0x185100C10", Slot = "4")]
		public override bool XCHLOJVPVOU()
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
		[Cpp2IlInjected.Address(RVA = "0x815EC60", Offset = "0x815DA60", VA = "0x18815EC60")]
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
		[Cpp2IlInjected.Address(RVA = "0x98A9830", Offset = "0x98A8630", VA = "0x1898A9830")]
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
		[Cpp2IlInjected.Address(RVA = "0x6F2D450", Offset = "0x6F2C250", VA = "0x186F2D450")]
		public ManipulateStartArgs(TData target, bool undoable)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public interface QIXMISKWCVF<a>
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool XCHLOJVPVOU([In] MoveArgs<a> moveArgs);

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool XCHLOJVPVOU([In] MoveToArgs<a> moveArgs);
	}
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public interface YKWXAZIYOYZ<a>
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool CIPJVSHWXAU([In] MoveStartArgs<a> moveStartArgs);

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool VTWGDNJNRAB([In] MoveUpdateArgs updateArgs);

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool KMKHQFVZPIH();
	}
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public class GSJBFLKVMRJ<a> : GCXBNYMHZQH<QIXMISKWCVF<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private readonly MoveArgs<a> NYJJJOKYWGB;

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x638B4D0", Offset = "0x638A2D0", VA = "0x18638B4D0")]
		public GSJBFLKVMRJ(IEnumerable<a> a, Vector3 b, bool c, QIXMISKWCVF<a> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x5100C10", Offset = "0x50FFA10", VA = "0x185100C10", Slot = "4")]
		public override bool XCHLOJVPVOU()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public class ABJLCKINNWV<a> : GCXBNYMHZQH<YKWXAZIYOYZ<a>> where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x6795600", Offset = "0x6794400", VA = "0x186795600")]
		public ABJLCKINNWV(YKWXAZIYOYZ<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x71B4680", Offset = "0x71B3480", VA = "0x1871B4680", Slot = "4")]
		public override bool XCHLOJVPVOU()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public class MSOSIKDHTKU<a> : GCXBNYMHZQH<YKWXAZIYOYZ<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private readonly MoveStartArgs<a> NYJJJOKYWGB;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x6EE9DB0", Offset = "0x6EE8BB0", VA = "0x186EE9DB0")]
		public MSOSIKDHTKU(IEnumerable<a> a, bool b, YKWXAZIYOYZ<a> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x5100C10", Offset = "0x50FFA10", VA = "0x185100C10", Slot = "4")]
		public override bool XCHLOJVPVOU()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public class BSBHHDYSBBU<a> : GCXBNYMHZQH<QIXMISKWCVF<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private readonly MoveToArgs<a> NYJJJOKYWGB;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x4EDB290", Offset = "0x4EDA090", VA = "0x184EDB290")]
		public BSBHHDYSBBU(IEnumerable<a> a, Vector3 b, TransformVec3Filter c, bool d, QIXMISKWCVF<a> e, Space f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x4EDB0E0", Offset = "0x4ED9EE0", VA = "0x184EDB0E0", Slot = "4")]
		public override bool XCHLOJVPVOU()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public class ANOIPMAAUPJ<a> : GCXBNYMHZQH<YKWXAZIYOYZ<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private readonly MoveUpdateArgs NYJJJOKYWGB;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x71BB5D0", Offset = "0x71BA3D0", VA = "0x1871BB5D0")]
		public ANOIPMAAUPJ(Vector3 a, YKWXAZIYOYZ<a> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x5088DB0", Offset = "0x5087BB0", VA = "0x185088DB0", Slot = "4")]
		public override bool XCHLOJVPVOU()
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
		[Cpp2IlInjected.Address(RVA = "0x7100BF0", Offset = "0x70FF9F0", VA = "0x187100BF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7100CD0", Offset = "0x70FFAD0", VA = "0x187100CD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7101700", Offset = "0x7100500", VA = "0x187101700")]
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
		[Cpp2IlInjected.Address(RVA = "0x2DCB990", Offset = "0x2DCA790", VA = "0x182DCB990")]
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
	public interface QJGARSMBHYD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool XCHLOJVPVOU([In] PivotArgs pivotArgs);
	}
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	public class YJHTHKMBXAX : GCXBNYMHZQH<QJGARSMBHYD>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private readonly PivotArgs XRGOFBXOBWO;

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x98AAB60", Offset = "0x98A9960", VA = "0x1898AAB60")]
		public YJHTHKMBXAX(bool a, QJGARSMBHYD b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x98AAAB0", Offset = "0x98A98B0", VA = "0x1898AAAB0", Slot = "4")]
		public override bool XCHLOJVPVOU()
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
		[Cpp2IlInjected.Address(RVA = "0x2717CC0", Offset = "0x2716AC0", VA = "0x182717CC0")]
		public PivotArgs(bool undoable)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	public interface CXUQZHSWPBL<a>
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool XCHLOJVPVOU([In] RotateArgs<a> rotateArgs);

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool XCHLOJVPVOU([In] RotateToArgs<a> rotateArgs);
	}
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	public interface PAGHTWEWQOX<a>
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool CIPJVSHWXAU([In] RotateStartArgs<a> startArgs);

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool VTWGDNJNRAB([In] RotateUpdateArgs updateArgs);

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool KMKHQFVZPIH();
	}
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public class ZVJTJTQYZZP<a> : GCXBNYMHZQH<CXUQZHSWPBL<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private readonly RotateArgs<a> HPKQVJMJTUL;

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x512F1A0", Offset = "0x512DFA0", VA = "0x18512F1A0")]
		public ZVJTJTQYZZP(IEnumerable<a> a, Quaternion b, Vector3? c, bool d, bool e, CXUQZHSWPBL<a> f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x5100C10", Offset = "0x50FFA10", VA = "0x185100C10", Slot = "4")]
		public override bool XCHLOJVPVOU()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public class PLFQSVXQOBZ<a> : GCXBNYMHZQH<PAGHTWEWQOX<a>> where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x6795600", Offset = "0x6794400", VA = "0x186795600")]
		public PLFQSVXQOBZ(PAGHTWEWQOX<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x71B4680", Offset = "0x71B3480", VA = "0x1871B4680", Slot = "4")]
		public override bool XCHLOJVPVOU()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public class NBJQVTFTAPM<a> : GCXBNYMHZQH<PAGHTWEWQOX<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private readonly RotateStartArgs<a> HPKQVJMJTUL;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x7106520", Offset = "0x7105320", VA = "0x187106520")]
		public NBJQVTFTAPM(IEnumerable<a> a, bool b, PAGHTWEWQOX<a> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x5100C10", Offset = "0x50FFA10", VA = "0x185100C10", Slot = "4")]
		public override bool XCHLOJVPVOU()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public class SIHKJLAPZEM<a> : GCXBNYMHZQH<CXUQZHSWPBL<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private readonly RotateToArgs<a> HPKQVJMJTUL;

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x78AE4E0", Offset = "0x78AD2E0", VA = "0x1878AE4E0")]
		public SIHKJLAPZEM(IEnumerable<a> a, Quaternion b, TransformVec3Filter c, Vector3? d, bool e, bool f, Space g, CXUQZHSWPBL<a> h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x4EDB0E0", Offset = "0x4ED9EE0", VA = "0x184EDB0E0", Slot = "4")]
		public override bool XCHLOJVPVOU()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public class XUFLPPJCWMR<a> : GCXBNYMHZQH<PAGHTWEWQOX<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private readonly RotateUpdateArgs HPKQVJMJTUL;

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x5088EF0", Offset = "0x5087CF0", VA = "0x185088EF0")]
		public XUFLPPJCWMR(Quaternion a, Vector3? b, bool c, PAGHTWEWQOX<a> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x5088DB0", Offset = "0x5087BB0", VA = "0x185088DB0", Slot = "4")]
		public override bool XCHLOJVPVOU()
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
		[Cpp2IlInjected.Address(RVA = "0x78A49E0", Offset = "0x78A37E0", VA = "0x1878A49E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x78A4AC0", Offset = "0x78A38C0", VA = "0x1878A4AC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x78A5370", Offset = "0x78A4170", VA = "0x1878A5370")]
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
		[Cpp2IlInjected.Address(RVA = "0x81B53E0", Offset = "0x81B41E0", VA = "0x1881B53E0")]
		public RotateUpdateArgs(Quaternion displacement, Vector3? pivotPoint, bool rotateInPlace)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public interface DTALZSWNADA<a>
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool CIPJVSHWXAU([In] ScaleStartArgs<a> startArgs);

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool VTWGDNJNRAB([In] ScaleUniformUpdateArgs updateArgs);

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool VTWGDNJNRAB([In] ScaleToUniformUpdateArgs updateArgs);

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool VTWGDNJNRAB([In] ScaleDeformInDirectionUpdateArgs updateArgs);

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool KMKHQFVZPIH();
	}
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	public class YDHOIKHEFYN<a> : GCXBNYMHZQH<DTALZSWNADA<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private readonly ScaleDeformInDirectionUpdateArgs IVUUCBKBCVS;

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x5093F20", Offset = "0x5092D20", VA = "0x185093F20")]
		public YDHOIKHEFYN(Vector3 a, float b, Vector3 c, bool d, bool e, DTALZSWNADA<a> f, Space g = Space.Self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x5093EC0", Offset = "0x5092CC0", VA = "0x185093EC0", Slot = "4")]
		public override bool XCHLOJVPVOU()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	public class VFFALTHGYFQ<a> : GCXBNYMHZQH<DTALZSWNADA<a>> where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x6795600", Offset = "0x6794400", VA = "0x186795600")]
		public VFFALTHGYFQ(DTALZSWNADA<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x7E92560", Offset = "0x7E91360", VA = "0x187E92560", Slot = "4")]
		public override bool XCHLOJVPVOU()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	public class MIPEPYVXNWV<a> : GCXBNYMHZQH<DTALZSWNADA<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private readonly ScaleStartArgs<a> IVUUCBKBCVS;

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x6ED43E0", Offset = "0x6ED31E0", VA = "0x186ED43E0")]
		public MIPEPYVXNWV(IEnumerable<a> a, bool b, DTALZSWNADA<a> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x5100C10", Offset = "0x50FFA10", VA = "0x185100C10", Slot = "4")]
		public override bool XCHLOJVPVOU()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public class ATHKQRTYYWV<a> : GCXBNYMHZQH<DTALZSWNADA<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private readonly ScaleToUniformUpdateArgs IVUUCBKBCVS;

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x71FC200", Offset = "0x71FB000", VA = "0x1871FC200")]
		public ATHKQRTYYWV(float a, bool b, Vector3 c, DTALZSWNADA<a> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x68BE740", Offset = "0x68BD540", VA = "0x1868BE740", Slot = "4")]
		public override bool XCHLOJVPVOU()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	public class TDNJXPGGUFG<a> : GCXBNYMHZQH<DTALZSWNADA<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private readonly ScaleUniformUpdateArgs IVUUCBKBCVS;

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x7A08370", Offset = "0x7A07170", VA = "0x187A08370")]
		public TDNJXPGGUFG(float a, Vector3 b, DTALZSWNADA<a> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x5088DB0", Offset = "0x5087BB0", VA = "0x185088DB0", Slot = "4")]
		public override bool XCHLOJVPVOU()
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
		[Cpp2IlInjected.Address(RVA = "0x98A9D10", Offset = "0x98A8B10", VA = "0x1898A9D10")]
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
		[Cpp2IlInjected.Address(RVA = "0x78C8920", Offset = "0x78C7720", VA = "0x1878C8920")]
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
		[Cpp2IlInjected.Address(RVA = "0x98A9D50", Offset = "0x98A8B50", VA = "0x1898A9D50")]
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
		[Cpp2IlInjected.Address(RVA = "0x685EF20", Offset = "0x685DD20", VA = "0x18685EF20")]
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
		[Cpp2IlInjected.Address(RVA = "0x98A9F30", Offset = "0x98A8D30", VA = "0x1898A9F30")]
		public TransformArgs(Guid[] objectGuids, Vector3[] positions, Quaternion[] rotations, float[] scales, Dictionary<Guid, Vector3> deformations, bool hasRotations = true, bool hasScales = true, bool hasDeformations = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x98A9D70", Offset = "0x98A8B70", VA = "0x1898A9D70")]
		private static void CSMWHQYCONW(Dictionary<Guid, Vector3> a, int b)
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
			public MZEBANDYSXL Container;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000DC")]
			public MZEBANDYSXL CachedParentContainer;
		}

		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private static MakerContainerBackingData JISPHFATJGS;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static CancellationToken JKGMCIRUCDI
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x98A9810", Offset = "0x98A8610", VA = "0x1898A9810")]
			get
			{
				return default(CancellationToken);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		internal static MZEBANDYSXL DXKJZRWEENK
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x98A9620", Offset = "0x98A8420", VA = "0x1898A9620")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x98A9560", Offset = "0x98A8360", VA = "0x1898A9560")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x98A9460", Offset = "0x98A8260", VA = "0x1898A9460")]
		[CXDXQIFYXBD.Room]
		internal static void AORJPAUYZAF(MZEBANDYSXL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x98A96B0", Offset = "0x98A84B0", VA = "0x1898A96B0")]
		public static void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x98A95D0", Offset = "0x98A83D0", VA = "0x1898A95D0")]
		private static MZEBANDYSXL OXELSMEUQME(MZEBANDYSXL a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public static class LFQSMBOJHAQ
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
		[Cpp2IlInjected.Address(RVA = "0x3BCB540", Offset = "0x3BCA340", VA = "0x183BCB540")]
		public static void XOXAKHKAXOH<a>(a a, MakerDataType b) where a : class
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x3BCB680", Offset = "0x3BCA480", VA = "0x183BCB680")]
		public static void XOXAKHKAXOH<b>(b a) where b : class
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x3BCB4F0", Offset = "0x3BCA2F0", VA = "0x183BCB4F0")]
		public static void XOXAKHKAXOH<c, TImpl, c>() where c : class where TImpl : notnull, c where c : class
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x3BCB420", Offset = "0x3BCA220", VA = "0x183BCB420")]
		public static void QHGTCKPXIJS<d>(d a) where d : class
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x3BCB150", Offset = "0x3BC9F50", VA = "0x183BCB150")]
		public static T Get<T>(MakerDataType type) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x3BCB2F0", Offset = "0x3BCA0F0", VA = "0x183BCB2F0")]
		public static bool PDPXSMPKQPY<f>(MakerDataType a, f? failval, [Out][NotNullWhen(true)][MaybeNullWhen(false)] f retval) where f : class
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x3BCAF80", Offset = "0x3BC9D80", VA = "0x183BCAF80")]
		public static bool EFGFCUDRQBD<g>(MakerDataType a, [Out][NotNullWhen(true)][MaybeNullWhen(false)] g foundService) where g : class
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x3BCAEE0", Offset = "0x3BC9CE0", VA = "0x183BCAEE0")]
		public static bool BDDLIYBAOOR<h>(MakerDataType a) where h : class
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x3BCB1F0", Offset = "0x3BC9FF0", VA = "0x183BCB1F0")]
		public static T Get<T>() where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x3BCB230", Offset = "0x3BCA030", VA = "0x183BCB230")]
		public static bool PDPXSMPKQPY<i>(i a, [Out] i b) where i : class
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x3BCAEA0", Offset = "0x3BC9CA0", VA = "0x183BCAEA0")]
		public static bool BDDLIYBAOOR<j>() where j : class
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009E")]
	internal static class YXBLLBMUMZB
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x98AAE30", Offset = "0x98A9C30", VA = "0x1898AAE30")]
		public static void YTRLFBIAUYE(IEnumerable a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x411CA70", Offset = "0x411B870", VA = "0x18411CA70")]
		public static void YTRLFBIAUYE<T>(T[] a) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x411CEA0", Offset = "0x411BCA0", VA = "0x18411CEA0")]
		public static void YTRLFBIAUYE<T>(T a) where T : notnull, Enum
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
