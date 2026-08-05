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
		[Cpp2IlInjected.Address(RVA = "0xACD060", Offset = "0xACC460", VA = "0x180ACD060")]
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
		[Cpp2IlInjected.Address(RVA = "0x827ACB0", Offset = "0x827A0B0", VA = "0x18827ACB0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xACDAC0", Offset = "0xACCEC0", VA = "0x180ACDAC0")]
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
		[Cpp2IlInjected.Address(RVA = "0xACDB00", Offset = "0xACCF00", VA = "0x180ACDB00")]
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
		[Cpp2IlInjected.Address(RVA = "0x827C110", Offset = "0x827B510", VA = "0x18827C110", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x273B290", Offset = "0x273A690", VA = "0x18273B290")]
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
	public interface NTXWMKZLGTH<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "0")]
		b LVHBJGMDMPX(a a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public interface SEQFQFKFJWY<a> where a : notnull
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
	public interface AFIWRYUZNZO<a> : CPOBIKBGYNK, EFXXCUBMKQQ<a>, VAYGUHWJISO<a>, DYHHPQWOUTC<a>, LIENPZJGVLP, TLTRCNHXFMT<a>, HTITRBEIVLP, RQVRVMZCXDR
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public interface TLTRCNHXFMT<a> where a : notnull
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
	public interface CPOBIKBGYNK
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		Bounds ZZYXJYGYBTD
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		Transform WPDBPDTIEYA
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		Bounds SVPCVBOJOTG
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		Transform CYXRPBRSYNF
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		Vector3 BIZBUIOQRIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		bool ZFLHVFNIHEI
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
	public interface RQVRVMZCXDR
	{
		[Cpp2IlInjected.Token(Token = "0x17000007")]
		OAGBKHNZSHS LLCECLXAJHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public interface SZFGBAFVGTE
	{
		[Cpp2IlInjected.Token(Token = "0x17000008")]
		bool LVAQDMOMQBS
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		bool UZEZVTMVVEW
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		bool WEUQNDZXTWK
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
	public interface DYHHPQWOUTC<a> where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		bool MCMJKBKKTTC
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		int NKVYZAMQWBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		IEnumerable<a> MTMTDWGERDF
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
	public interface EFXXCUBMKQQ<a> where a : notnull
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
	public interface HTITRBEIVLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void OnSelectionPickedUp();

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void OnSelectionReleased();
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public interface LIENPZJGVLP
	{
		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		bool HBGXJGVZRDU
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		bool DVDXFKFYBZJ
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		bool RYDZNDBRLXA
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		bool PWKWNESRRNT
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
		[Cpp2IlInjected.Address(RVA = "0x55E7800", Offset = "0x55E6C00", VA = "0x1855E7800")]
		public AdjustLightArgs(IEnumerable<TData> targets, bool emit, float? intensity, float? range, float? angle, bool undoable)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public interface LYZGAHVRGAV<a>
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool CDXZOOQETHP([In] AdjustLightArgs<a> args);
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class IZMWPAEXPQT<a> : FNFNHTVWISA<LYZGAHVRGAV<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly AdjustLightArgs<a> JJFISTBIRZV;

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5032C80", Offset = "0x5032080", VA = "0x185032C80")]
		public IZMWPAEXPQT(IEnumerable<a> a, bool b, float? c, float? d, float? e, bool f, LYZGAHVRGAV<a> g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3CC4E00", Offset = "0x3CC4200", VA = "0x183CC4E00", Slot = "4")]
		public override bool CDXZOOQETHP()
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
		[Cpp2IlInjected.Address(RVA = "0x567F5D0", Offset = "0x567E9D0", VA = "0x18567F5D0")]
		public ApplyImageAtomicArgs(IEnumerable<TData> targets, string imageName, bool isTileable, bool undoable)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface HERZKOAOTEK<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool CDXZOOQETHP([In] ApplyImageAtomicArgs<a> args);
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class OOOOCPWDJCE<a> : FNFNHTVWISA<HERZKOAOTEK<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly ApplyImageAtomicArgs<a> JJFISTBIRZV;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5989170", Offset = "0x5988570", VA = "0x185989170")]
		public OOOOCPWDJCE(IEnumerable<a> a, string b, bool c, bool d, HERZKOAOTEK<a> e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3CC4E00", Offset = "0x3CC4200", VA = "0x183CC4E00", Slot = "4")]
		public override bool CDXZOOQETHP()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public abstract class FNFNHTVWISA<a> : CQPZPRRXRWU<a, bool> where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x4D659F0", Offset = "0x4D64DF0", VA = "0x184D659F0")]
		public FNFNHTVWISA(a a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public abstract class VCXVYLTNMFZ<a, b> : CQPZPRRXRWU<a, Task<b>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x4D659F0", Offset = "0x4D64DF0", VA = "0x184D659F0")]
		public VCXVYLTNMFZ(a a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public abstract class CQPZPRRXRWU<a, b> where a : notnull where b : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		protected a VZQXGMKYIHZ;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x3CFA630", Offset = "0x3CF9A30", VA = "0x183CFA630")]
		public CQPZPRRXRWU(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract b CDXZOOQETHP();
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public abstract class MZHIYQBDMPY<a, b> : CQPZPRRXRWU<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x4D659F0", Offset = "0x4D64DF0", VA = "0x184D659F0")]
		public MZHIYQBDMPY(a a)
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
		[Cpp2IlInjected.Address(RVA = "0x1BB53E0", Offset = "0x1BB47E0", VA = "0x181BB53E0")]
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
		[Cpp2IlInjected.Address(RVA = "0xE16830", Offset = "0xE15C30", VA = "0x180E16830")]
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
		[Cpp2IlInjected.Address(RVA = "0xBEF470", Offset = "0xBEE870", VA = "0x180BEF470")]
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
		[Cpp2IlInjected.Address(RVA = "0x827A3E0", Offset = "0x82797E0", VA = "0x18827A3E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x24F4140", Offset = "0x24F3540", VA = "0x1824F4140")]
		public CircuitsV2UngroupingArgs(Guid boardNodeId, bool undoable)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public interface OLZGSZMITLF<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		CreationResult VQSDIUWTNOQ(CircuitsV1GroupingArgs<a, b> groupCircuitsArgs);

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "1")]
		CreationResult ZVTPCMOAXWB(CircuitsV1GroupingArgs<a, b> groupCircuitsArgs);

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "2")]
		CreationResult YQLZQDLKUFW(CircuitsV1AddArgs<a, b> groupCircuitsArgs);

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "3")]
		CreationResult LBYNNNOQMBX(CircuitsV1RemoveArgs<a> groupCircuitsArgs);
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public interface IYYZXOJJBSQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<CreationResult> VQSDIUWTNOQ(CircuitsV2GroupingArgs a);

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<CreationResult> ZVTPCMOAXWB(CircuitsV2UngroupingArgs a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class FPYMBXHHEEH<a, b> : MZHIYQBDMPY<OLZGSZMITLF<a, b>, CreationResult>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly CircuitsV1AddArgs<a, b> MJTTHGNCCGY;

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x4D66E80", Offset = "0x4D66280", VA = "0x184D66E80")]
		public FPYMBXHHEEH(a a, IEnumerable<b> b, OLZGSZMITLF<a, b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x4D66C30", Offset = "0x4D66030", VA = "0x184D66C30", Slot = "4")]
		public override CreationResult CDXZOOQETHP()
		{
			return default(CreationResult);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class CBMMITLWPEH<a, b> : MZHIYQBDMPY<OLZGSZMITLF<a, b>, CreationResult>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private readonly CircuitsV1GroupingArgs<a, b> MJTTHGNCCGY;

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x3CC6120", Offset = "0x3CC5520", VA = "0x183CC6120")]
		public CBMMITLWPEH(a a, b b, IEnumerable<b> c, OLZGSZMITLF<a, b> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x3CC5CA0", Offset = "0x3CC50A0", VA = "0x183CC5CA0", Slot = "4")]
		public override CreationResult CDXZOOQETHP()
		{
			return default(CreationResult);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class ADLWGPLTVLC<a, b> : MZHIYQBDMPY<OLZGSZMITLF<a, b>, CreationResult>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private readonly CircuitsV1RemoveArgs<a> MJTTHGNCCGY;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x407FA30", Offset = "0x407EE30", VA = "0x18407FA30")]
		public ADLWGPLTVLC(a a, OLZGSZMITLF<a, b> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x53A1490", Offset = "0x53A0890", VA = "0x1853A1490", Slot = "4")]
		public override CreationResult CDXZOOQETHP()
		{
			return default(CreationResult);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class UABFKVDDXIO<a, b> : MZHIYQBDMPY<OLZGSZMITLF<a, b>, CreationResult>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private readonly CircuitsV1GroupingArgs<a, b> MJTTHGNCCGY;

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x3CC6120", Offset = "0x3CC5520", VA = "0x183CC6120")]
		public UABFKVDDXIO(a a, b b, IEnumerable<b> c, OLZGSZMITLF<a, b> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x60E6990", Offset = "0x60E5D90", VA = "0x1860E6990", Slot = "4")]
		public override CreationResult CDXZOOQETHP()
		{
			return default(CreationResult);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class SHLECPTHPFI : VCXVYLTNMFZ<IYYZXOJJBSQ, CreationResult>
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
			public SHLECPTHPFI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private TaskAwaiter<CreationResult> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x827B9F0", Offset = "0x827ADF0", VA = "0x18827B9F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x827BD70", Offset = "0x827B170", VA = "0x18827BD70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private CircuitsV2GroupingArgs MJTTHGNCCGY;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x827AF70", Offset = "0x827A370", VA = "0x18827AF70")]
		public SHLECPTHPFI(IEnumerable<Guid> a, Guid b, bool c, IYYZXOJJBSQ d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x827AE80", Offset = "0x827A280", VA = "0x18827AE80", Slot = "4")]
		[AsyncStateMachine(typeof(<Execute>d__2))]
		public override Task<CreationResult> CDXZOOQETHP()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class NLPWVJBVGFN : VCXVYLTNMFZ<IYYZXOJJBSQ, CreationResult>
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
			public NLPWVJBVGFN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			private TaskAwaiter<CreationResult> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x827B750", Offset = "0x827AB50", VA = "0x18827B750", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x827BD00", Offset = "0x827B100", VA = "0x18827BD00", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private readonly CircuitsV2UngroupingArgs MJTTHGNCCGY;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x827AC30", Offset = "0x827A030", VA = "0x18827AC30")]
		public NLPWVJBVGFN(Guid a, bool b, IYYZXOJJBSQ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x827AB40", Offset = "0x8279F40", VA = "0x18827AB40", Slot = "4")]
		[AsyncStateMachine(typeof(<Execute>d__2))]
		public override Task<CreationResult> CDXZOOQETHP()
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
		[Cpp2IlInjected.Address(RVA = "0x827A420", Offset = "0x8279820", VA = "0x18827A420")]
		public CloneArgs(MirrorArgs mirrorArgs, bool undoable)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public interface VKIORWAQRXL<a> where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<a> CDXZOOQETHP(CloneArgs a);
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public class CDIOTILDQKT<a> : VCXVYLTNMFZ<VKIORWAQRXL<a>, a> where a : notnull
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
			public CDIOTILDQKT<a> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			private TaskAwaiter<a> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x4E5DD80", Offset = "0x4E5D180", VA = "0x184E5DD80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x4E5F0F0", Offset = "0x4E5E4F0", VA = "0x184E5F0F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly CloneArgs JXGTJVDVJIG;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x3CC8D10", Offset = "0x3CC8110", VA = "0x183CC8D10")]
		public CDIOTILDQKT(MirrorArgs a, bool b, VKIORWAQRXL<a> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x3CC8C20", Offset = "0x3CC8020", VA = "0x183CC8C20", Slot = "4")]
		[AsyncStateMachine(typeof(CDIOTILDQKT<>.<Execute>d__2))]
		public override Task<a> CDXZOOQETHP()
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
		[Cpp2IlInjected.Address(RVA = "0x827AAA0", Offset = "0x8279EA0", VA = "0x18827AAA0")]
		public MirrorArgs(Transform mirror)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x827AB10", Offset = "0x8279F10", VA = "0x18827AB10")]
		public MirrorArgs(Vector3 normal, Vector3 position)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x827A9F0", Offset = "0x8279DF0", VA = "0x18827A9F0")]
		public static MirrorArgs Clone()
		{
			return default(MirrorArgs);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x827AA20", Offset = "0x8279E20", VA = "0x18827AA20")]
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
		[Cpp2IlInjected.Address(RVA = "0x4055FC0", Offset = "0x40553C0", VA = "0x184055FC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x4055E40", Offset = "0x4055240", VA = "0x184055E40")]
		public ConnectFinishArgs(TNode finishNode, TReparentOperations reparentOperations, InteractionType interactionType, bool undoable)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public interface NVQJBSRPYIR<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool YWRGYOGOFUX([In] ConnectStartArgs<a> startArgs);

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool HSCUPLUGFES([In] ConnectFinishArgs<a, b> finishArgs);

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool VPYIXBRJOMH();
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class DOOLVQJKDCX<a, b> : FNFNHTVWISA<NVQJBSRPYIR<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x3DE88E0", Offset = "0x3DE7CE0", VA = "0x183DE88E0")]
		public DOOLVQJKDCX(NVQJBSRPYIR<a, b> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x3EABCC0", Offset = "0x3EAB0C0", VA = "0x183EABCC0", Slot = "4")]
		public override bool CDXZOOQETHP()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public class JQJDBAWNUHU<a, b> : FNFNHTVWISA<NVQJBSRPYIR<a, b>>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private readonly ConnectFinishArgs<a, b> MFGYCYHCWRC;

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x50F50E0", Offset = "0x50F44E0", VA = "0x1850F50E0")]
		public JQJDBAWNUHU(a a, b b, InteractionType c, NVQJBSRPYIR<a, b> d, bool e = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x473D320", Offset = "0x473C720", VA = "0x18473D320", Slot = "4")]
		public override bool CDXZOOQETHP()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public class BREEEXDWGAL<a, b> : FNFNHTVWISA<NVQJBSRPYIR<a, b>>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private readonly ConnectStartArgs<a> DSDWKBIHNGD;

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6E74EF0", Offset = "0x6E742F0", VA = "0x186E74EF0")]
		public BREEEXDWGAL(a a, NVQJBSRPYIR<a, b> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x3CC4E00", Offset = "0x3CC4200", VA = "0x183CC4E00", Slot = "4")]
		public override bool CDXZOOQETHP()
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
		[Cpp2IlInjected.Address(RVA = "0x40651F0", Offset = "0x40645F0", VA = "0x1840651F0")]
		public CreateArgs(TSpawnInfo spawnTypeInformation, Vector3 position, Quaternion rotation, float scale)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public interface TTMAIQPGWDZ<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<a> LYQZNLJWWFH([In] CreateArgs<b> createArgs, CancellationToken a);
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public class ILVVNHHOFYR<a, b> : VCXVYLTNMFZ<TTMAIQPGWDZ<a, b>, a> where a : notnull where b : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private readonly CreateArgs<b> JJFISTBIRZV;

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x5016480", Offset = "0x5015880", VA = "0x185016480")]
		public ILVVNHHOFYR(b a, Vector3 b, Quaternion c, float d, TTMAIQPGWDZ<a, b> e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x4D5BDC0", Offset = "0x4D5B1C0", VA = "0x184D5BDC0", Slot = "4")]
		public override Task<a> CDXZOOQETHP()
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
		[Cpp2IlInjected.Address(RVA = "0x409B170", Offset = "0x409A570", VA = "0x18409B170")]
		public DeleteArgs(IEnumerable<TData> targets, bool undoable = false, bool deleteFrozenObjects = false, bool removeCurrentSlectionWhenDelete = true)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public interface ZAWSQPMASIV<a> where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<CreationResult> NNRFYHNBWFU([In] DeleteArgs<a> selectArgs, CancellationToken a);
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public class FDFTYBFUDCP<a> : VCXVYLTNMFZ<ZAWSQPMASIV<a>, CreationResult> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private readonly DeleteArgs<a> INKMLDHVNVW;

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x4D5BEA0", Offset = "0x4D5B2A0", VA = "0x184D5BEA0")]
		public FDFTYBFUDCP(IEnumerable<a> a, bool b, ZAWSQPMASIV<a> c, bool d = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x4D5BDC0", Offset = "0x4D5B1C0", VA = "0x184D5BDC0", Slot = "4")]
		public override Task<CreationResult> CDXZOOQETHP()
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
		[Cpp2IlInjected.Address(RVA = "0x4053950", Offset = "0x4052D50", VA = "0x184053950")]
		public EditArgs(T newTarget)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public interface DRHDFXYSXBA<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool YWRGYOGOFUX([In] EditArgs<a> editArgs);

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool HSCUPLUGFES();
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public interface VCZYYEKERWS<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool CDXZOOQETHP([In] LockArgs<a> lockArgs);
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
		[Cpp2IlInjected.Address(RVA = "0x57B6CE0", Offset = "0x57B60E0", VA = "0x1857B6CE0")]
		public LockArgs(T newTarget, bool isLocked)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public class YBWHXBYBZOH<a> : FNFNHTVWISA<DRHDFXYSXBA<a>> where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x3DE88E0", Offset = "0x3DE7CE0", VA = "0x183DE88E0")]
		public YBWHXBYBZOH(DRHDFXYSXBA<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x3DE8890", Offset = "0x3DE7C90", VA = "0x183DE8890", Slot = "4")]
		public override bool CDXZOOQETHP()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public class DVDWOFGJNFI<a> : FNFNHTVWISA<DRHDFXYSXBA<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private readonly EditArgs<a> DUFLESOHVHV;

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x407FA90", Offset = "0x407EE90", VA = "0x18407FA90")]
		public DVDWOFGJNFI(a a, DRHDFXYSXBA<a> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x3CC4E00", Offset = "0x3CC4200", VA = "0x183CC4E00", Slot = "4")]
		public override bool CDXZOOQETHP()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public class TRKUTQWDJUE<a> : FNFNHTVWISA<VCZYYEKERWS<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private readonly LockArgs<a> OFZUANVCLBO;

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x5EC5140", Offset = "0x5EC4540", VA = "0x185EC5140")]
		public TRKUTQWDJUE(a a, bool b, VCZYYEKERWS<a> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x3CC4E00", Offset = "0x3CC4200", VA = "0x183CC4E00", Slot = "4")]
		public override bool CDXZOOQETHP()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public struct FreezeArgs<TData> where TData : notnull, GEYGYBNFNHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public IEnumerable<TData> Targets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public bool willFreeze;

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x4DC4220", Offset = "0x4DC3620", VA = "0x184DC4220")]
		public FreezeArgs(IEnumerable<TData> newTargets, bool newWillFreeze)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public struct FreezeListArgs<TData> where TData : notnull, GEYGYBNFNHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public List<TData> Targets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public List<bool> freezeValues;

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x4DC4AA0", Offset = "0x4DC3EA0", VA = "0x184DC4AA0")]
		public FreezeListArgs(List<TData> newTargets, List<bool> newFreezeValues)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public interface GEYGYBNFNHN
	{
		[Cpp2IlInjected.Token(Token = "0x17000012")]
		bool LASFECMFNZO
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
	public interface DWLRAPJGCLU<a> where a : GEYGYBNFNHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool CDXZOOQETHP([In] FreezeArgs<a> freezeArgs);

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void CDXZOOQETHP([In] FreezeListArgs<a> freezeArgs);
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public interface WTFYPATOXTN<a> where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool BNKSSBCYFTW(a a);
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public class BQLLDDRXBPG<a> : FNFNHTVWISA<DWLRAPJGCLU<a>> where a : notnull, GEYGYBNFNHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private readonly FreezeArgs<a> TJUNXJRVUJG;

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6E6FC30", Offset = "0x6E6F030", VA = "0x186E6FC30")]
		public BQLLDDRXBPG(List<a> a, bool b, DWLRAPJGCLU<a> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x3CC4E00", Offset = "0x3CC4200", VA = "0x183CC4E00", Slot = "4")]
		public override bool CDXZOOQETHP()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public class RWDREKLAHSA<a> : FNFNHTVWISA<DWLRAPJGCLU<a>> where a : notnull, GEYGYBNFNHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private readonly FreezeListArgs<a> TJUNXJRVUJG;

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x5B84EC0", Offset = "0x5B842C0", VA = "0x185B84EC0")]
		public RWDREKLAHSA(List<a> a, List<bool> b, DWLRAPJGCLU<a> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x597AA70", Offset = "0x5979E70", VA = "0x18597AA70", Slot = "4")]
		public override bool CDXZOOQETHP()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public interface GGXHRFBAWGK<a> where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<CreationResult> CDXZOOQETHP(MergeShapesArgs<a> mergeShapesArgs);
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public class HVFMBBCNDHK<a> : VCXVYLTNMFZ<GGXHRFBAWGK<a>, CreationResult> where a : notnull
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
			public HVFMBBCNDHK<a> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			private TaskAwaiter<CreationResult> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x4E5ED30", Offset = "0x4E5E130", VA = "0x184E5ED30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x4E5F080", Offset = "0x4E5E480", VA = "0x184E5F080", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private readonly MergeShapesArgs<a> OUFFRCHWSKG;

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x4F510A0", Offset = "0x4F504A0", VA = "0x184F510A0")]
		public HVFMBBCNDHK(a a, IReadOnlyList<a> b, bool c, GGXHRFBAWGK<a> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x4F50CF0", Offset = "0x4F500F0", VA = "0x184F50CF0", Slot = "4")]
		[AsyncStateMachine(typeof(HVFMBBCNDHK<>.<Execute>d__2))]
		public override Task<CreationResult> CDXZOOQETHP()
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
		[Cpp2IlInjected.Address(RVA = "0xF3DD60", Offset = "0xF3D160", VA = "0x180F3DD60")]
		public MergeShapesArgs(TData destinationContainer, IReadOnlyList<TData> shapesToMerge, bool undoable)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public interface HCVRWMUSOUV<a>
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool CDXZOOQETHP([In] RecolorAtomicArgs<a> recolorArgs);
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public interface UTNBARVJLNH<a>
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void CDXZOOQETHP([In] RecolorAtomicSpecificArgs<a> recolorArgs);
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public interface TWHIJVQQHVJ<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool PSLNJMJGTGI([In] RecolorContinuousArgs<a> recolorArgs);

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void HSCUPLUGFES();
	}
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public class CKAOFVRGUKL<a> : FNFNHTVWISA<HCVRWMUSOUV<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private readonly RecolorAtomicArgs<a> PMRNPNZIASD;

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x3CF9580", Offset = "0x3CF8980", VA = "0x183CF9580")]
		public CKAOFVRGUKL(IEnumerable<a> a, ShapeColor b, ShapeMaterial c, float d, string? imageName, bool e, bool f, HCVRWMUSOUV<a> g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x3CC4E00", Offset = "0x3CC4200", VA = "0x183CC4E00", Slot = "4")]
		public override bool CDXZOOQETHP()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public class LAFVQPUONRJ<a> : FNFNHTVWISA<UTNBARVJLNH<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private readonly RecolorAtomicSpecificArgs<a> PMRNPNZIASD;

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x531F310", Offset = "0x531E710", VA = "0x18531F310")]
		public LAFVQPUONRJ(a[] a, ShapeColor[] b, ShapeMaterial[] c, float[] d, UTNBARVJLNH<a> e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x531F180", Offset = "0x531E580", VA = "0x18531F180", Slot = "4")]
		public override bool CDXZOOQETHP()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public class UOFTVVXPHQV<a> : FNFNHTVWISA<TWHIJVQQHVJ<a>> where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x3DE88E0", Offset = "0x3DE7CE0", VA = "0x183DE88E0")]
		public UOFTVVXPHQV(TWHIJVQQHVJ<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x6101CF0", Offset = "0x61010F0", VA = "0x186101CF0", Slot = "4")]
		public override bool CDXZOOQETHP()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public class UALDVGNFETC<a> : FNFNHTVWISA<TWHIJVQQHVJ<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private readonly RecolorContinuousArgs<a> PMRNPNZIASD;

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x60E6BB0", Offset = "0x60E5FB0", VA = "0x1860E6BB0")]
		public UALDVGNFETC(IEnumerable<a> a, ShapeColor b, ShapeMaterial c, float d, TWHIJVQQHVJ<a> e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x531F180", Offset = "0x531E580", VA = "0x18531F180", Slot = "4")]
		public override bool CDXZOOQETHP()
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
		[Cpp2IlInjected.Address(RVA = "0x5D1B5A0", Offset = "0x5D1A9A0", VA = "0x185D1B5A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5D1BCD0", Offset = "0x5D1B0D0", VA = "0x185D1BCD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5D1C210", Offset = "0x5D1B610", VA = "0x185D1C210")]
		public RecolorContinuousArgs(IEnumerable<TData> targets, ShapeColor color, ShapeMaterial material, float uvScale)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public interface VAYGUHWJISO<a> where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool YQLZQDLKUFW([In] SelectArgs<a> selectArgs);

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void LBYNNNOQMBX([In] SelectArgs<a> selectArgs);

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void YPDPPDGCIDI([In] bool undoAble);

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool ESJNZUXZBVE([In] SelectArgs<a> selectArgs);

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void TNPOLJNBJHM();

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool HYPTQEAZFXD([In] a itemInCache);
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public class ESDFXJESJDP<a> : FNFNHTVWISA<VAYGUHWJISO<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private readonly SelectArgs<a> IGPKAYGWQZR;

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x474FC80", Offset = "0x474F080", VA = "0x18474FC80")]
		public ESDFXJESJDP(List<a> a, VAYGUHWJISO<a> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x3CC4E00", Offset = "0x3CC4200", VA = "0x183CC4E00", Slot = "4")]
		public override bool CDXZOOQETHP()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public class WLWMDDASMAT<a> : FNFNHTVWISA<VAYGUHWJISO<a>> where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x3DE88E0", Offset = "0x3DE7CE0", VA = "0x183DE88E0")]
		public WLWMDDASMAT(VAYGUHWJISO<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x65BDBA0", Offset = "0x65BCFA0", VA = "0x1865BDBA0", Slot = "4")]
		public override bool CDXZOOQETHP()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public class UCLYXBDFUAP<a> : FNFNHTVWISA<VAYGUHWJISO<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private readonly bool CVQKAHFSSAA;

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x60EDB20", Offset = "0x60ECF20", VA = "0x1860EDB20")]
		public UCLYXBDFUAP(bool a, VAYGUHWJISO<a> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x60EDAC0", Offset = "0x60ECEC0", VA = "0x1860EDAC0", Slot = "4")]
		public override bool CDXZOOQETHP()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public class OESDNPMMJNW<a> : FNFNHTVWISA<VAYGUHWJISO<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private readonly SelectArgs<a> IGPKAYGWQZR;

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x597AC60", Offset = "0x597A060", VA = "0x18597AC60")]
		public OESDNPMMJNW(List<a> a, bool b, VAYGUHWJISO<a> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x597AA70", Offset = "0x5979E70", VA = "0x18597AA70", Slot = "4")]
		public override bool CDXZOOQETHP()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public class WFJJZNQQQTS<a> : FNFNHTVWISA<VAYGUHWJISO<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private readonly a EPANPKIJBTO;

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x65B9610", Offset = "0x65B8A10", VA = "0x1865B9610")]
		public WFJJZNQQQTS(a a, VAYGUHWJISO<a> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x65B9360", Offset = "0x65B8760", VA = "0x1865B9360", Slot = "4")]
		public override bool CDXZOOQETHP()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public class NEPLFTBBBNR<a> : FNFNHTVWISA<VAYGUHWJISO<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private readonly SelectArgs<a> IGPKAYGWQZR;

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x5842AA0", Offset = "0x5841EA0", VA = "0x185842AA0")]
		public NEPLFTBBBNR(IEnumerable<a> a, VAYGUHWJISO<a> b, bool c = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x58429E0", Offset = "0x5841DE0", VA = "0x1858429E0", Slot = "4")]
		public override bool CDXZOOQETHP()
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
		[Cpp2IlInjected.Address(RVA = "0x5DC4A00", Offset = "0x5DC3E00", VA = "0x185DC4A00")]
		public SelectArgs(IEnumerable<TData> newTargets, bool newUndoable = false)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public interface WTCPOMZWEHX
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<CreationResult> CDXZOOQETHP(SplitShapesArgs a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public class OXFHBGRVBMD : VCXVYLTNMFZ<WTCPOMZWEHX, CreationResult>
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
			public OXFHBGRVBMD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			private TaskAwaiter<CreationResult> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x827B4E0", Offset = "0x827A8E0", VA = "0x18827B4E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x827BC90", Offset = "0x827B090", VA = "0x18827BC90", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private readonly SplitShapesArgs HYFGRLNVIWW;

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x827AE20", Offset = "0x827A220", VA = "0x18827AE20")]
		public OXFHBGRVBMD(bool a, WTCPOMZWEHX b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x827AD30", Offset = "0x827A130", VA = "0x18827AD30", Slot = "4")]
		[AsyncStateMachine(typeof(<Execute>d__2))]
		public override Task<CreationResult> CDXZOOQETHP()
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
		[Cpp2IlInjected.Address(RVA = "0x2401840", Offset = "0x2400C40", VA = "0x182401840")]
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
		[Cpp2IlInjected.Address(RVA = "0x649AF80", Offset = "0x649A380", VA = "0x18649AF80")]
		public AlignArgs(bool translate, bool rotate, bool scale, bool undoable)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x827A160", Offset = "0x8279560", VA = "0x18827A160")]
		public AlignArgs(bool rotate, bool undoable)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public interface MVQDCGIGRIK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool JVGUXGZEVTY(AlignArgs a);

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool DAJFMQXRTON(AlignArgs a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public class LFFPTJXTRUQ : FNFNHTVWISA<MVQDCGIGRIK>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private readonly AlignArgs BKJFGUDZQIO;

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x827A560", Offset = "0x8279960", VA = "0x18827A560")]
		public LFFPTJXTRUQ(bool a, bool b, bool c, bool d, MVQDCGIGRIK e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x827A510", Offset = "0x8279910", VA = "0x18827A510", Slot = "4")]
		public override bool CDXZOOQETHP()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public class INYLFQOIRQT : FNFNHTVWISA<MVQDCGIGRIK>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private readonly AlignArgs BKJFGUDZQIO;

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x827A490", Offset = "0x8279890", VA = "0x18827A490")]
		public INYLFQOIRQT(bool a, bool b, MVQDCGIGRIK c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x827A440", Offset = "0x8279840", VA = "0x18827A440", Slot = "4")]
		public override bool CDXZOOQETHP()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public interface TXZNUGCJNFN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void CDXZOOQETHP([In] TransformArgs transformArgs);
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public class BBBGIWKQGAJ : FNFNHTVWISA<TXZNUGCJNFN>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private readonly TransformArgs BMBDBWVNIOX;

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x827A220", Offset = "0x8279620", VA = "0x18827A220")]
		public BBBGIWKQGAJ(Guid[] a, Vector3[] b, Quaternion[] c, float[] d, Dictionary<Guid, Vector3> e, TXZNUGCJNFN f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x827A170", Offset = "0x8279570", VA = "0x18827A170", Slot = "4")]
		public override bool CDXZOOQETHP()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public interface BCQHCJSWPJX<a>
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool YWRGYOGOFUX([In] ManipulateStartArgs<a> startArgs);

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool PSLNJMJGTGI([In] ManipulateSetAspectRatioArgs updateArgs);

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool PSLNJMJGTGI([In] ManipulateSetCurvePointPositionAndRadiusArgs updateArgs);

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool HSCUPLUGFES();
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public class SKIGIPTDEOD<a> : FNFNHTVWISA<BCQHCJSWPJX<a>> where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x3DE88E0", Offset = "0x3DE7CE0", VA = "0x183DE88E0")]
		public SKIGIPTDEOD(BCQHCJSWPJX<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x5DAD9A0", Offset = "0x5DACDA0", VA = "0x185DAD9A0", Slot = "4")]
		public override bool CDXZOOQETHP()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public class SQVUUHUHWSG<a> : FNFNHTVWISA<BCQHCJSWPJX<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private readonly ManipulateSetAspectRatioArgs GYDUXNDDERR;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x5DBA420", Offset = "0x5DB9820", VA = "0x185DBA420")]
		public SQVUUHUHWSG(Vector3 a, bool b, BCQHCJSWPJX<a> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x3DE0330", Offset = "0x3DDF730", VA = "0x183DE0330", Slot = "4")]
		public override bool CDXZOOQETHP()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public class GKZMJNPCUPA<a> : FNFNHTVWISA<BCQHCJSWPJX<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private readonly ManipulateSetCurvePointPositionAndRadiusArgs GYDUXNDDERR;

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x4E95D10", Offset = "0x4E95110", VA = "0x184E95D10")]
		public GKZMJNPCUPA(Guid a, int b, Vector3 c, Quaternion d, float e, bool f, BCQHCJSWPJX<a> g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x4E95B60", Offset = "0x4E94F60", VA = "0x184E95B60", Slot = "4")]
		public override bool CDXZOOQETHP()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public class LLEEWHDFDXE<a> : FNFNHTVWISA<BCQHCJSWPJX<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private readonly ManipulateStartArgs<a> GYDUXNDDERR;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x5323070", Offset = "0x5322470", VA = "0x185323070")]
		public LLEEWHDFDXE(a a, bool b, BCQHCJSWPJX<a> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x3CC4E00", Offset = "0x3CC4200", VA = "0x183CC4E00", Slot = "4")]
		public override bool CDXZOOQETHP()
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
		[Cpp2IlInjected.Address(RVA = "0x827A990", Offset = "0x8279D90", VA = "0x18827A990")]
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
		[Cpp2IlInjected.Address(RVA = "0x827A9B0", Offset = "0x8279DB0", VA = "0x18827A9B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x580FD10", Offset = "0x580F110", VA = "0x18580FD10")]
		public ManipulateStartArgs(TData target, bool undoable)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public interface SEPXOUWSYWO<a>
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool CDXZOOQETHP([In] MoveArgs<a> moveArgs);

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool CDXZOOQETHP([In] MoveToArgs<a> moveArgs);
	}
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public interface FYGAKNPTAXG<a>
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool YWRGYOGOFUX([In] MoveStartArgs<a> moveStartArgs);

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool PSLNJMJGTGI([In] MoveUpdateArgs updateArgs);

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool HSCUPLUGFES();
	}
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public class IYOBLVIYXUA<a> : FNFNHTVWISA<SEPXOUWSYWO<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private readonly MoveArgs<a> VSAXKPPTWNY;

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x5021950", Offset = "0x5020D50", VA = "0x185021950")]
		public IYOBLVIYXUA(IEnumerable<a> a, Vector3 b, bool c, SEPXOUWSYWO<a> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x3CC4E00", Offset = "0x3CC4200", VA = "0x183CC4E00", Slot = "4")]
		public override bool CDXZOOQETHP()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public class ZHLSZGIAGJE<a> : FNFNHTVWISA<FYGAKNPTAXG<a>> where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x3DE88E0", Offset = "0x3DE7CE0", VA = "0x183DE88E0")]
		public ZHLSZGIAGJE(FYGAKNPTAXG<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x3EABCC0", Offset = "0x3EAB0C0", VA = "0x183EABCC0", Slot = "4")]
		public override bool CDXZOOQETHP()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public class RBZVZBWBJNL<a> : FNFNHTVWISA<FYGAKNPTAXG<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private readonly MoveStartArgs<a> VSAXKPPTWNY;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x5B523C0", Offset = "0x5B517C0", VA = "0x185B523C0")]
		public RBZVZBWBJNL(IEnumerable<a> a, bool b, FYGAKNPTAXG<a> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x3CC4E00", Offset = "0x3CC4200", VA = "0x183CC4E00", Slot = "4")]
		public override bool CDXZOOQETHP()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public class EEXJYFDXFMN<a> : FNFNHTVWISA<SEPXOUWSYWO<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private readonly MoveToArgs<a> VSAXKPPTWNY;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x473D3E0", Offset = "0x473C7E0", VA = "0x18473D3E0")]
		public EEXJYFDXFMN(IEnumerable<a> a, Vector3 b, TransformVec3Filter c, bool d, SEPXOUWSYWO<a> e, Space f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x473D320", Offset = "0x473C720", VA = "0x18473D320", Slot = "4")]
		public override bool CDXZOOQETHP()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public class OFYEZCZYZIQ<a> : FNFNHTVWISA<FYGAKNPTAXG<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private readonly MoveUpdateArgs VSAXKPPTWNY;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x597C460", Offset = "0x597B860", VA = "0x18597C460")]
		public OFYEZCZYZIQ(Vector3 a, FYGAKNPTAXG<a> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x3DE0330", Offset = "0x3DDF730", VA = "0x183DE0330", Slot = "4")]
		public override bool CDXZOOQETHP()
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
		[Cpp2IlInjected.Address(RVA = "0x583CB80", Offset = "0x583BF80", VA = "0x18583CB80")]
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
		[Cpp2IlInjected.Address(RVA = "0x583CC60", Offset = "0x583C060", VA = "0x18583CC60")]
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
		[Cpp2IlInjected.Address(RVA = "0x583D620", Offset = "0x583CA20", VA = "0x18583D620")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B2CF40", Offset = "0x2B2C340", VA = "0x182B2CF40")]
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
	public interface WLMQPCCHCWM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool CDXZOOQETHP([In] PivotArgs pivotArgs);
	}
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public class ZYQODUSNJDQ : FNFNHTVWISA<WLMQPCCHCWM>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private readonly PivotArgs YKXVPXIAQGP;

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x827C0B0", Offset = "0x827B4B0", VA = "0x18827C0B0")]
		public ZYQODUSNJDQ(bool a, WLMQPCCHCWM b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x827C000", Offset = "0x827B400", VA = "0x18827C000", Slot = "4")]
		public override bool CDXZOOQETHP()
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
		[Cpp2IlInjected.Address(RVA = "0x2401840", Offset = "0x2400C40", VA = "0x182401840")]
		public PivotArgs(bool undoable)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public interface GXBEJZHLVGY<a>
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool CDXZOOQETHP([In] RotateArgs<a> rotateArgs);

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool CDXZOOQETHP([In] RotateToArgs<a> rotateArgs);
	}
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	public interface JHAIMAHRQZA<a>
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool YWRGYOGOFUX([In] RotateStartArgs<a> startArgs);

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool PSLNJMJGTGI([In] RotateUpdateArgs updateArgs);

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool HSCUPLUGFES();
	}
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	public class CAKWYFIYWKW<a> : FNFNHTVWISA<GXBEJZHLVGY<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private readonly RotateArgs<a> HJHNRNOZORW;

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x3CC4FD0", Offset = "0x3CC43D0", VA = "0x183CC4FD0")]
		public CAKWYFIYWKW(IEnumerable<a> a, Quaternion b, Vector3? c, bool d, bool e, GXBEJZHLVGY<a> f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x3CC4E00", Offset = "0x3CC4200", VA = "0x183CC4E00", Slot = "4")]
		public override bool CDXZOOQETHP()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public class UUYLHNSHPME<a> : FNFNHTVWISA<JHAIMAHRQZA<a>> where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x3DE88E0", Offset = "0x3DE7CE0", VA = "0x183DE88E0")]
		public UUYLHNSHPME(JHAIMAHRQZA<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x3EABCC0", Offset = "0x3EAB0C0", VA = "0x183EABCC0", Slot = "4")]
		public override bool CDXZOOQETHP()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public class VXEPUXXMKJB<a> : FNFNHTVWISA<JHAIMAHRQZA<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private readonly RotateStartArgs<a> HJHNRNOZORW;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x6269510", Offset = "0x6268910", VA = "0x186269510")]
		public VXEPUXXMKJB(IEnumerable<a> a, bool b, JHAIMAHRQZA<a> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x3CC4E00", Offset = "0x3CC4200", VA = "0x183CC4E00", Slot = "4")]
		public override bool CDXZOOQETHP()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public class LKYASSGUATV<a> : FNFNHTVWISA<GXBEJZHLVGY<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private readonly RotateToArgs<a> HJHNRNOZORW;

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x5322DE0", Offset = "0x53221E0", VA = "0x185322DE0")]
		public LKYASSGUATV(IEnumerable<a> a, Quaternion b, TransformVec3Filter c, Vector3? d, bool e, bool f, Space g, GXBEJZHLVGY<a> h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x473D320", Offset = "0x473C720", VA = "0x18473D320", Slot = "4")]
		public override bool CDXZOOQETHP()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public class YBHMNZYYCMS<a> : FNFNHTVWISA<JHAIMAHRQZA<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private readonly RotateUpdateArgs HJHNRNOZORW;

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x3DE0390", Offset = "0x3DDF790", VA = "0x183DE0390")]
		public YBHMNZYYCMS(Quaternion a, Vector3? b, bool c, JHAIMAHRQZA<a> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x3DE0330", Offset = "0x3DDF730", VA = "0x183DE0330", Slot = "4")]
		public override bool CDXZOOQETHP()
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
		[Cpp2IlInjected.Address(RVA = "0x5DA46E0", Offset = "0x5DA3AE0", VA = "0x185DA46E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5DA47C0", Offset = "0x5DA3BC0", VA = "0x185DA47C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5DA50E0", Offset = "0x5DA44E0", VA = "0x185DA50E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x644F360", Offset = "0x644E760", VA = "0x18644F360")]
		public RotateUpdateArgs(Quaternion displacement, Vector3? pivotPoint, bool rotateInPlace)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	public interface HREALNCCSTT<a>
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool YWRGYOGOFUX([In] ScaleStartArgs<a> startArgs);

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool PSLNJMJGTGI([In] ScaleUniformUpdateArgs updateArgs);

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool PSLNJMJGTGI([In] ScaleToUniformUpdateArgs updateArgs);

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool PSLNJMJGTGI([In] ScaleDeformInDirectionUpdateArgs updateArgs);

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool HSCUPLUGFES();
	}
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public class CRUSLPEIIVU<a> : FNFNHTVWISA<HREALNCCSTT<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private readonly ScaleDeformInDirectionUpdateArgs LTHAFVEANUJ;

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x3CFA850", Offset = "0x3CF9C50", VA = "0x183CFA850")]
		public CRUSLPEIIVU(Vector3 a, float b, Vector3 c, bool d, bool e, HREALNCCSTT<a> f, Space g = Space.Self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x3CFA7F0", Offset = "0x3CF9BF0", VA = "0x183CFA7F0", Slot = "4")]
		public override bool CDXZOOQETHP()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	public class UVFPGDZDINB<a> : FNFNHTVWISA<HREALNCCSTT<a>> where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x3DE88E0", Offset = "0x3DE7CE0", VA = "0x183DE88E0")]
		public UVFPGDZDINB(HREALNCCSTT<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x61099E0", Offset = "0x6108DE0", VA = "0x1861099E0", Slot = "4")]
		public override bool CDXZOOQETHP()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	public class ALCKZUUXVPI<a> : FNFNHTVWISA<HREALNCCSTT<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private readonly ScaleStartArgs<a> LTHAFVEANUJ;

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x53AC770", Offset = "0x53ABB70", VA = "0x1853AC770")]
		public ALCKZUUXVPI(IEnumerable<a> a, bool b, HREALNCCSTT<a> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x3CC4E00", Offset = "0x3CC4200", VA = "0x183CC4E00", Slot = "4")]
		public override bool CDXZOOQETHP()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	public class IIAOJKTRWXM<a> : FNFNHTVWISA<HREALNCCSTT<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private readonly ScaleToUniformUpdateArgs LTHAFVEANUJ;

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x5015C10", Offset = "0x5015010", VA = "0x185015C10")]
		public IIAOJKTRWXM(float a, bool b, Vector3 c, HREALNCCSTT<a> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x4E95B60", Offset = "0x4E94F60", VA = "0x184E95B60", Slot = "4")]
		public override bool CDXZOOQETHP()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public class SSWLKRDRCGT<a> : FNFNHTVWISA<HREALNCCSTT<a>> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private readonly ScaleUniformUpdateArgs LTHAFVEANUJ;

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x5DBA540", Offset = "0x5DB9940", VA = "0x185DBA540")]
		public SSWLKRDRCGT(float a, Vector3 b, HREALNCCSTT<a> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x3DE0330", Offset = "0x3DDF730", VA = "0x183DE0330", Slot = "4")]
		public override bool CDXZOOQETHP()
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
		[Cpp2IlInjected.Address(RVA = "0x827B030", Offset = "0x827A430", VA = "0x18827B030")]
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
		[Cpp2IlInjected.Address(RVA = "0x5DC00A0", Offset = "0x5DBF4A0", VA = "0x185DC00A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x827B070", Offset = "0x827A470", VA = "0x18827B070")]
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
		[Cpp2IlInjected.Address(RVA = "0x640E980", Offset = "0x640DD80", VA = "0x18640E980")]
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
		[Cpp2IlInjected.Address(RVA = "0x827B250", Offset = "0x827A650", VA = "0x18827B250")]
		public TransformArgs(Guid[] objectGuids, Vector3[] positions, Quaternion[] rotations, float[] scales, Dictionary<Guid, Vector3> deformations, bool hasRotations = true, bool hasScales = true, bool hasDeformations = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x827B090", Offset = "0x827A490", VA = "0x18827B090")]
		private static void QZZJSJHETXN(Dictionary<Guid, Vector3> a, int b)
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
			public NAWAUUZVKFS Container;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000DC")]
			public NAWAUUZVKFS CachedParentContainer;
		}

		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private static MakerContainerBackingData DBTUTQACOWT;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static CancellationToken RUIIPENJFET
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x827A5F0", Offset = "0x82799F0", VA = "0x18827A5F0")]
			get
			{
				return default(CancellationToken);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		internal static NAWAUUZVKFS IKCCGBMLNTX
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x827A8A0", Offset = "0x8279CA0", VA = "0x18827A8A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x827A930", Offset = "0x8279D30", VA = "0x18827A930")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x827A610", Offset = "0x8279A10", VA = "0x18827A610")]
		[JKCTBFVRGVY.Room]
		internal static void GYUZIXOGRLY(NAWAUUZVKFS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x827A750", Offset = "0x8279B50", VA = "0x18827A750")]
		public static void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x827A700", Offset = "0x8279B00", VA = "0x18827A700")]
		private static NAWAUUZVKFS PBRONSHMVLD(NAWAUUZVKFS a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	public static class FOBRTNRKSND
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
		[Cpp2IlInjected.Address(RVA = "0x36AD8E0", Offset = "0x36ACCE0", VA = "0x1836AD8E0")]
		public static void LUTLTXEAQQY<a>(a a, MakerDataType b) where a : class
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x36ADA30", Offset = "0x36ACE30", VA = "0x1836ADA30")]
		public static void LUTLTXEAQQY<b>(b a) where b : class
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x36AD890", Offset = "0x36ACC90", VA = "0x1836AD890")]
		public static void LUTLTXEAQQY<c, TImpl, c>() where c : class where TImpl : notnull, c where c : class
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x36ADC90", Offset = "0x36AD090", VA = "0x1836ADC90")]
		public static void SLMVOONEUKD<d>(d a) where d : class
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x36AD7F0", Offset = "0x36ACBF0", VA = "0x1836AD7F0")]
		public static T Get<T>(MakerDataType type) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x36ADB60", Offset = "0x36ACF60", VA = "0x1836ADB60")]
		public static bool ORPWUCEHZPT<f>(MakerDataType a, f? failval, [Out][NotNullWhen(true)][MaybeNullWhen(false)] f retval) where f : class
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x36AD5E0", Offset = "0x36AC9E0", VA = "0x1836AD5E0")]
		public static bool FEQLVGPVXRG<g>(MakerDataType a, [Out][NotNullWhen(true)][MaybeNullWhen(false)] g foundService) where g : class
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x36ADDA0", Offset = "0x36AD1A0", VA = "0x1836ADDA0")]
		public static bool SOQPRXPAMEW<h>(MakerDataType a) where h : class
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x36AD7B0", Offset = "0x36ACBB0", VA = "0x1836AD7B0")]
		public static T Get<T>() where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x36ADAA0", Offset = "0x36ACEA0", VA = "0x1836ADAA0")]
		public static bool ORPWUCEHZPT<i>(i a, [Out] i b) where i : class
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x36ADD60", Offset = "0x36AD160", VA = "0x1836ADD60")]
		public static bool SOQPRXPAMEW<j>() where j : class
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	internal static class UOONBKVEBBY
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x827BDE0", Offset = "0x827B1E0", VA = "0x18827BDE0")]
		public static void DHJIULDWSBJ(IEnumerable a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x3B79CC0", Offset = "0x3B790C0", VA = "0x183B79CC0")]
		public static void DHJIULDWSBJ<T>(T[] a) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x3B7A0F0", Offset = "0x3B794F0", VA = "0x183B7A0F0")]
		public static void DHJIULDWSBJ<T>(T a) where T : notnull, Enum
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
