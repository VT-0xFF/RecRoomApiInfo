using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.Components;
using RecRoom.DataLayer;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Foundation.Collections;
using RecRoom.Foundation.ComponentSystems;
using RecRoom.Foundation.Mathematics;
using RecRoom.Foundation.Service;
using RecRoom.Foundation.Transforms;
using RecRoom.Logging;
using RecRoom.Logging.Attributes;
using RecRoom.ObjectModel.Entities;
using RecRoom.ObjectModel.Systems;
using RecRoom.RendererV1;
using RecRoom.RendererV1.DataProviders;
using Unity.Burst;
using Unity.Burst.Intrinsics;
using Unity.Collections;
using Unity.Entities;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Scripting;

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
	internal sealed class IsUnmanagedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xACE190", Offset = "0xACD590", VA = "0x180ACE190")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace _LogRegistration.RecRoom_ObjectModel_RendererV1_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Obfuscation(ApplyToMembers = false)]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : RecRoom.Logging.LogRegistrationIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8487220", Offset = "0x8486620", VA = "0x188487220", Slot = "4")]
		public override void SHWXSEAJSCT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xACE190", Offset = "0xACD590", VA = "0x180ACE190")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_ObjectModel_RendererV1_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	[Obfuscation(ApplyToMembers = false)]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private int[] DTCBHPALRHU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private ServiceBitset GTGGRGPIZNX;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xAAA820", Offset = "0xAA9C20", VA = "0x180AAA820", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x843DDF0", Offset = "0x843D1F0", VA = "0x18843DDF0", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x84962B0", Offset = "0x84956B0", VA = "0x1884962B0")]
		private void RGTQLMDRHIR(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8496830", Offset = "0x8495C30", VA = "0x188496830", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8496890", Offset = "0x8495C90", VA = "0x188496890")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class WDWYUYFGPCR
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8494D80", Offset = "0x8494180", VA = "0x188494D80")]
		public static Quaternion BLVQSQMMVIU([In] this RRObjectSplinePoint splinePoint, [In] Vector3 direction)
		{
			return default(Quaternion);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class LRDUYABKDWC
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x84850C0", Offset = "0x84844C0", VA = "0x1884850C0")]
		public static bool CEJWBKMMVIM(this RRObjectShapeSpline a, ShapeConfigFlags b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8486AB0", Offset = "0x8485EB0", VA = "0x188486AB0")]
		public static bool TDLEMRFANFI(this RRObjectShapeSpline a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8486E10", Offset = "0x8486210", VA = "0x188486E10")]
		public static bool YQMQZDJWQOV(this RRObjectShapeSpline a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8485E80", Offset = "0x8485280", VA = "0x188485E80")]
		public static void MUXBVCGUGFY(this RRObjectShapeSpline a, Vector3 b, Quaternion c, float d, bool e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8485270", Offset = "0x8484670", VA = "0x188485270")]
		public static void GGUMXLQGMLW(this RRObjectShapeSpline a, Vector3 b, Quaternion c, float d, int e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8485100", Offset = "0x8484500", VA = "0x188485100")]
		public static void CJGMSMTLPCE(this RRObjectShapeSpline a, int b, Vector3 c, Quaternion d, float e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8485220", Offset = "0x8484620", VA = "0x188485220")]
		public static void FYHNAUGNVBJ(this RRObjectShapeSpline a, Vector3 b, Quaternion c, float d, bool e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8485FB0", Offset = "0x84853B0", VA = "0x188485FB0")]
		private static void PHRZOAWDIBK(this RRObjectShapeSpline a, Vector3 b, Quaternion c, float d, bool e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8486900", Offset = "0x8485D00", VA = "0x188486900")]
		private static void PQHMSZTFFFK(this RRObjectShapeSpline a, Vector3 b, Quaternion c, float d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x84854F0", Offset = "0x84848F0", VA = "0x1884854F0")]
		private static void HQYAUVCLLRY(this RRObjectShapeSpline a, int b, Vector3 c, Quaternion d, float e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8485E50", Offset = "0x8485250", VA = "0x188485E50")]
		private static bool LDCWZZRDNUM(this RRObjectShapeSpline a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x84856D0", Offset = "0x8484AD0", VA = "0x1884856D0")]
		private static void JFWDEAEISHA(this RRObjectShapeSpline a, int b, Vector3 c, Quaternion d, float e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8485960", Offset = "0x8484D60", VA = "0x188485960")]
		public static Vector3 JIOCAKLXSNL(this RRObjectShapeSpline a, int b)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8486D00", Offset = "0x8486100", VA = "0x188486D00")]
		public static Quaternion YMOCWVXOEZA(this RRObjectShapeSpline a, int b)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8486AE0", Offset = "0x8485EE0", VA = "0x188486AE0")]
		public static Vector3 XSDWJUREJEZ(ShapeConfigFlags a, Vector3 b, Vector3? c, Vector3 d)
		{
			return default(Vector3);
		}
	}
}
namespace RecRoom.ObjectModel.RendererV1
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	internal interface ZXZSNFXTKMO
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void OFBIDMHVFDP(EntityQuery a, EntityManager b, OHDUGSVEQRB c, RQXJVWCHGME d);
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	internal interface LSXTYEPUCTY
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		ComponentType PUDFYGPPCOF
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void PXYFHFEZPYZ(EntityQuery a, IHTOZJMDENQ b);

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void BHXAWIKYEVK(EntityQuery a, IHTOZJMDENQ b);

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void PQWFWMMBSGU(IHTOZJMDENQ a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	internal class CSIKUJBGIQD : ZXZSNFXTKMO
	{
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static readonly Log HONKOTEDSFS;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x847D690", Offset = "0x847CA90", VA = "0x18847D690", Slot = "4")]
		public void OFBIDMHVFDP(EntityQuery a, EntityManager b, OHDUGSVEQRB c, RQXJVWCHGME d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public CSIKUJBGIQD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	internal class LHNKQOWGYPF : ZXZSNFXTKMO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly SelectionEffectType XFYBNPABVMX;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xAB07E0", Offset = "0xAAFBE0", VA = "0x180AB07E0")]
		public LHNKQOWGYPF(SelectionEffectType a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x8484960", Offset = "0x8483D60", VA = "0x188484960", Slot = "4")]
		public void OFBIDMHVFDP(EntityQuery a, EntityManager b, OHDUGSVEQRB c, RQXJVWCHGME d)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	internal class MBMBNFBTGBJ : ZXZSNFXTKMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8487610", Offset = "0x8486A10", VA = "0x188487610", Slot = "4")]
		public void OFBIDMHVFDP(EntityQuery a, EntityManager b, OHDUGSVEQRB c, RQXJVWCHGME d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public MBMBNFBTGBJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class KETDNBYZLTX : LSXTYEPUCTY
	{
		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public ComponentType PUDFYGPPCOF
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x8484900", Offset = "0x8483D00", VA = "0x188484900", Slot = "4")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8484660", Offset = "0x8483A60", VA = "0x188484660", Slot = "5")]
		public void PXYFHFEZPYZ(EntityQuery a, IHTOZJMDENQ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8484370", Offset = "0x8483770", VA = "0x188484370", Slot = "6")]
		public void BHXAWIKYEVK(EntityQuery a, IHTOZJMDENQ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8484610", Offset = "0x8483A10", VA = "0x188484610", Slot = "7")]
		public void PQWFWMMBSGU(IHTOZJMDENQ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public KETDNBYZLTX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class QXYVVZRUNGF : LSXTYEPUCTY
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public ComponentType PUDFYGPPCOF
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x8490D30", Offset = "0x8490130", VA = "0x188490D30", Slot = "4")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8490A90", Offset = "0x848FE90", VA = "0x188490A90", Slot = "5")]
		public void PXYFHFEZPYZ(EntityQuery a, IHTOZJMDENQ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x84907A0", Offset = "0x848FBA0", VA = "0x1884907A0", Slot = "6")]
		public void BHXAWIKYEVK(EntityQuery a, IHTOZJMDENQ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8490A40", Offset = "0x848FE40", VA = "0x188490A40", Slot = "7")]
		public void PQWFWMMBSGU(IHTOZJMDENQ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public QXYVVZRUNGF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class LMTDNOOHPVX : LSXTYEPUCTY
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public ComponentType PUDFYGPPCOF
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x8485060", Offset = "0x8484460", VA = "0x188485060", Slot = "4")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8484DC0", Offset = "0x84841C0", VA = "0x188484DC0", Slot = "5")]
		public void PXYFHFEZPYZ(EntityQuery a, IHTOZJMDENQ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8484AD0", Offset = "0x8483ED0", VA = "0x188484AD0", Slot = "6")]
		public void BHXAWIKYEVK(EntityQuery a, IHTOZJMDENQ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8484D70", Offset = "0x8484170", VA = "0x188484D70", Slot = "7")]
		public void PQWFWMMBSGU(IHTOZJMDENQ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public LMTDNOOHPVX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal class SHHBDOPBXMU : NOHBMPGHBDW, UFLUIPVILQU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private OHDUGSVEQRB AWBSSZSCGNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private LZYDIMTSOON UXCZUOGXBYZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private RQXJVWCHGME COEGFNPFNNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private List<(EntityQuery query, ZXZSNFXTKMO adapter)> WNAQZKMNDXW;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8493720", Offset = "0x8492B20", VA = "0x188493720", Slot = "15")]
		public virtual void InitReferences(SAMXOKXXSFT services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x84937B0", Offset = "0x8492BB0", VA = "0x1884937B0", Slot = "5")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8493C20", Offset = "0x8493020", VA = "0x188493C20")]
		private void WZPUIKJLIHO(EntityQueryDesc a, ZXZSNFXTKMO b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x84939A0", Offset = "0x8492DA0", VA = "0x1884939A0", Slot = "13")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x2B1A950", Offset = "0x2B19D50", VA = "0x182B1A950")]
		[UnityEngine.Scripting.Preserve]
		public SHHBDOPBXMU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[SystemEnabledLifetime(Lifetime.LoadInstance)]
	internal class RenderShapeEffectsSystem : NOHBMPGHBDW, UFLUIPVILQU
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		private class Effect
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public EntityQuery EXMYOJNKRVV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public EntityQuery YSYYLEYPADL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public EntityQuery HQETNIQIGEG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public EntityQuery ALZTXLFFGZI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public EntityQuery IDEQHNCODXM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public EntityQuery EUOXUWKBMQL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public EntityQuery XNHONIMLQYT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public LSXTYEPUCTY HAPARALAYJM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public ComponentType MSSKPQYJJGZ;

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public Effect()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly Log HONKOTEDSFS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private OHDUGSVEQRB AWBSSZSCGNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private RQXJVWCHGME COEGFNPFNNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private LZYDIMTSOON UXCZUOGXBYZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private List<Effect> WNAQZKMNDXW;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x84926E0", Offset = "0x8491AE0", VA = "0x1884926E0", Slot = "14")]
		public void InitReferences(SAMXOKXXSFT services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8492770", Offset = "0x8491B70", VA = "0x188492770", Slot = "5")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x84928F0", Offset = "0x8491CF0", VA = "0x1884928F0", Slot = "13")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8492B00", Offset = "0x8491F00", VA = "0x188492B00")]
		private void UDUAVOBRRDV(Effect a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8492F70", Offset = "0x8492370", VA = "0x188492F70")]
		private void WZPUIKJLIHO(LSXTYEPUCTY a, ComponentType b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x2B1A950", Offset = "0x2B19D50", VA = "0x182B1A950")]
		[UnityEngine.Scripting.Preserve]
		public RenderShapeEffectsSystem()
		{
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[TypeManager.ForcedStableTypeHash(14336554891096525153uL)]
	internal struct HoverEffectRenderedTag : ICleanupComponentData, IComponentData
	{
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[TypeManager.ForcedStableTypeHash(3939343835747908767uL)]
	internal struct SelectionEffectRenderedTag : ICleanupComponentData, IComponentData
	{
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[TypeManager.ForcedStableTypeHash(9697228609905595395uL)]
	internal struct WorldFadeEffectRenderedTag : ICleanupComponentData, IComponentData
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[RegisterService(typeof(RQXJVWCHGME), new string[] { })]
	public class ALCVBRLACBF : RQXJVWCHGME
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public OutlineEffectType CUMSCZQTLEX
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xAA3110", Offset = "0xAA2510", VA = "0x180AA3110", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(OutlineEffectType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1D0", Offset = "0xAAA5D0", VA = "0x180AAB1D0", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public ALCVBRLACBF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[RegisterService(typeof(JWIZMKKQBVY), new string[] { })]
	public class WPSLUKQOXDZ : JWIZMKKQBVY, BIXPVXTLAFJ, RDQXTNNVCSB, EMBMQMXGZNX, LGPJMXYAVLB, TUMMHZEQETT, LZXVIVBNZGR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[DependsOn]
		private LGFWOCXQZYC GRICFEWTJKS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[DependsOn]
		private OHDUGSVEQRB AWBSSZSCGNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		[DependsOn]
		private LNGQTCAXYFX KXOASIDQTQO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private EntityQuery KJQCWGVHIGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private EntityQuery UBLEOOIGHWS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private bool ZFIWQTWPVEQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private Entity IRRDFKHTWIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private RootHandle PJXFUZWHMJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private Entity XPEYSYFSKPS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private RootHandle ITTNKCJRZAK;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private EntityManager CCPMMFHJJYI
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x8495800", Offset = "0x8494C00", VA = "0x188495800")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public int VYYPFRYCRTI
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x8494E60", Offset = "0x8494260", VA = "0x188494E60", Slot = "7")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int SNEXTAOYUAV
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x8495A60", Offset = "0x8494E60", VA = "0x188495A60", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x8495910", Offset = "0x8494D10", VA = "0x188495910", Slot = "4")]
		public bool SGKZXTMJAQX(ObjectLocalId a, MutableRef b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x8495420", Offset = "0x8494820", VA = "0x188495420", Slot = "5")]
		public RootHandle JTMFTVTWSDF()
		{
			return default(RootHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8494E80", Offset = "0x8494280", VA = "0x188494E80", Slot = "6")]
		public RootHandle DBZDTHSQCKW()
		{
			return default(RootHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x84952F0", Offset = "0x84946F0", VA = "0x1884952F0", Slot = "9")]
		public void InitExternal(SAMXOKXXSFT services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x84958D0", Offset = "0x8494CD0", VA = "0x1884958D0", Slot = "11")]
		public void RWVOXCJLGEZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x8495A80", Offset = "0x8494E80", VA = "0x188495A80", Slot = "10")]
		public void WBQZJJFAQZN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8495260", Offset = "0x8494660", VA = "0x188495260", Slot = "12")]
		private void EEVWSJPJMZT(SAMXOKXXSFT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x108E760", Offset = "0x108DB60", VA = "0x18108E760", Slot = "13")]
		private void BFZHWFFBFON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public WPSLUKQOXDZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[RegisterService(typeof(PPSPAXFXRPV), new string[] { })]
	public class DABKHYOYCXA : PPSPAXFXRPV
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x847EA70", Offset = "0x847DE70", VA = "0x18847EA70", Slot = "4")]
		public void SXWGIVODGJX(World a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x847E080", Offset = "0x847D480", VA = "0x18847E080", Slot = "5")]
		public void ENHODVILUVN(World a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x847E030", Offset = "0x847D430", VA = "0x18847E030", Slot = "6")]
		public ComponentSystemBase DHDVQTSXXTU(World a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x847EA10", Offset = "0x847DE10", VA = "0x18847EA10", Slot = "7")]
		public void QCGWRZGIDZQ(World a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x847E950", Offset = "0x847DD50", VA = "0x18847E950", Slot = "8")]
		public void NDQALEMXWYJ(World a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x847E9B0", Offset = "0x847DDB0", VA = "0x18847E9B0", Slot = "9")]
		public void PPWGWRVMTQQ(World a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x847EB00", Offset = "0x847DF00", VA = "0x18847EB00", Slot = "10")]
		public void VFASYRZLAGF(World a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x847E0D0", Offset = "0x847D4D0", VA = "0x18847E0D0", Slot = "11")]
		public NativeParallelHashSet<ComponentTypeIndex> HGCEYUYASWM()
		{
			return default(NativeParallelHashSet<ComponentTypeIndex>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public DABKHYOYCXA()
		{
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[TypeManager.ForcedStableTypeHash(8022771283198464153uL)]
	public struct KeepRenderRootHandleWithoutChildrenTag : IComponentData
	{
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[TypeManager.ForcedStableTypeHash(7787318400023670087uL)]
	public struct LoneShapeRenderedTag : IComponentData
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class DGKXPXBYXCC : IComponentData, ICloneable, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public HOCVRBALVUS EUIJKBTMTXZ
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FC0", Offset = "0xAA53C0", VA = "0x180AA5FC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x847EBE0", Offset = "0x847DFE0", VA = "0x18847EBE0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x847EB70", Offset = "0x847DF70", VA = "0x18847EB70", Slot = "4")]
		public object Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		[UnityEngine.Scripting.Preserve]
		public DGKXPXBYXCC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[TypeManager.ForcedStableTypeHash(9578575130884295287uL)]
	public struct RenderRootHandleData : ICleanupComponentData, IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public RootHandle rootHandle;

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xD01B00", Offset = "0xD00F00", VA = "0x180D01B00")]
		public static implicit operator RenderRootHandleData(RootHandle handle)
		{
			return default(RenderRootHandleData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public class AMEMZAXGTDX : ICleanupComponentData, IComponentData, ICloneable
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public IEYTHGWWKIN NEDIHSOBUQC
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FC0", Offset = "0xAA53C0", VA = "0x180AA5FC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8476A50", Offset = "0x8475E50", VA = "0x188476A50", Slot = "4")]
		public object Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		[UnityEngine.Scripting.Preserve]
		public AMEMZAXGTDX()
		{
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[TypeManager.ForcedStableTypeHash(10815538147163088674uL)]
	public struct ShapeBatchedWithRoomTag : IComponentData
	{
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[TypeManager.ForcedStableTypeHash(10815538147163088675uL)]
	public struct ShapeBatchedWithSelectionTag : IComponentData
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[TypeManager.ForcedStableTypeHash(10245696125477899514uL)]
	public struct ShapeHandleData : ICleanupComponentData, IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public ShapeHandle shapeHandle;

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xD01B00", Offset = "0xD00F00", VA = "0x180D01B00")]
		public static implicit operator ShapeHandleData(ShapeHandle handle)
		{
			return default(ShapeHandleData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[TypeManager.ForcedStableTypeHash(10129251117493878592uL)]
	public struct ShapeRootHandleData : ICleanupComponentData, IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public RootHandle rootHandle;

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xD01B00", Offset = "0xD00F00", VA = "0x180D01B00")]
		public static implicit operator ShapeRootHandleData(RootHandle handle)
		{
			return default(ShapeRootHandleData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class WZMWSNGPCEW : IComponentData, ICloneable, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public EWMJKAHDSWA ZCDZBISNKDD
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FC0", Offset = "0xAA53C0", VA = "0x180AA5FC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x8495DD0", Offset = "0x84951D0", VA = "0x188495DD0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8495D60", Offset = "0x8495160", VA = "0x188495D60", Slot = "4")]
		public object Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		[UnityEngine.Scripting.Preserve]
		public WZMWSNGPCEW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public class GJNJISJPQAB : LQLZJCXQYHL, HOCVRBALVUS, WFQTCQGVRCW, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public PrimitiveShapeMeshType YYOBJSIMLJF
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xBB86C0", Offset = "0xBB7AC0", VA = "0x180BB86C0", Slot = "27")]
			[CompilerGenerated]
			get
			{
				return default(PrimitiveShapeMeshType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool JFRGFDGGPCZ
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x1317310", Offset = "0x1316710", VA = "0x181317310", Slot = "28")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public float3 DHQCBDPQVGD
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0xFAA7D0", Offset = "0xFA9BD0", VA = "0x180FAA7D0", Slot = "29")]
			[CompilerGenerated]
			get
			{
				return default(float3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x847F530", Offset = "0x847E930", VA = "0x18847F530")]
		public GJNJISJPQAB(UniformTRS a, RRObject b, float c, float3 d, ShapeColor e, ShapeMaterial f, PrimitiveShapeMeshType g, float3 h, bool i)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x847F4D0", Offset = "0x847E8D0", VA = "0x18847F4D0", Slot = "25")]
		public override UnityEngine.Hash128 ComputeHash()
		{
			return default(UnityEngine.Hash128);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "26")]
		public override void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class RUCMUYHOERN : LQLZJCXQYHL, EWMJKAHDSWA, WFQTCQGVRCW, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private NativeArray<CurvePointData> KIWHORPVJRE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private readonly SplineParameterFlags RIHXAMNYMMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private readonly float NOMYWVFXIWT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private readonly int RQFTVVPNNVL;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool XNTUQAFWQVE
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x8490F00", Offset = "0x8490300", VA = "0x188490F00", Slot = "27")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool EANEFJMKNWC
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x8490F20", Offset = "0x8490320", VA = "0x188490F20", Slot = "28")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool UHNAMKBCMPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x8490F10", Offset = "0x8490310", VA = "0x188490F10", Slot = "31")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public int OPEAUVBYXUY
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xBF7910", Offset = "0xBF6D10", VA = "0x180BF7910", Slot = "32")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public float LAGVNPNOJOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xB22510", Offset = "0xB21910", VA = "0x180B22510", Slot = "29")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public int EDDXXOUUNTX
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xB0E8C0", Offset = "0xB0DCC0", VA = "0x180B0E8C0", Slot = "30")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8490E60", Offset = "0x8490260", VA = "0x188490E60")]
		public RUCMUYHOERN(UniformTRS a, RRObject b, float c, float3 d, ShapeColor e, ShapeMaterial f, SplineParameterFlags g, float h, int i, NativeArray<CurvePointData> j)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xC17E40", Offset = "0xC17240", VA = "0x180C17E40", Slot = "33")]
		public NativeArray<CurvePointData> GetNativeCurvePoints()
		{
			return default(NativeArray<CurvePointData>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x8490D90", Offset = "0x8490190", VA = "0x188490D90", Slot = "25")]
		public override UnityEngine.Hash128 ComputeHash()
		{
			return default(UnityEngine.Hash128);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "26")]
		public override void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class PrimitiveWrapper : CTGVHNSLJPU, HOCVRBALVUS, WFQTCQGVRCW, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static readonly Log HONKOTEDSFS;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private static readonly Dictionary<PrimitiveShapeType, PrimitiveShapeMeshType> DICEGHOMEPZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private PrimitiveShapeMeshType RHSNYZWECWX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private bool FZNFNOGVQRX;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private PrimitiveShapeMeshType EYNFXJJBYDQ
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xAD4020", Offset = "0xAD3420", VA = "0x180AD4020", Slot = "28")]
			get
			{
				return default(PrimitiveShapeMeshType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private bool EFSADWMVLFK
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xBEE6C0", Offset = "0xBEDAC0", VA = "0x180BEE6C0", Slot = "29")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public float3 DHQCBDPQVGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x84906D0", Offset = "0x848FAD0", VA = "0x1884906D0", Slot = "30")]
			get
			{
				return default(float3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x84906B0", Offset = "0x848FAB0", VA = "0x1884906B0")]
		public PrimitiveWrapper(ObjectLocalId objectLocalId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x848FFA0", Offset = "0x848F3A0", VA = "0x18848FFA0", Slot = "27")]
		public override UnityEngine.Hash128 ComputeHash()
		{
			return default(UnityEngine.Hash128);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x848FFF0", Offset = "0x848F3F0", VA = "0x18848FFF0", Slot = "26")]
		public override void Update()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class VYQAUJTMMMJ : JMODSBNSABQ, IEYTHGWWKIN, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private GameObject CCLWYLFVTQK;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public GameObject QYWBNTWUNOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x8494920", Offset = "0x8493D20", VA = "0x188494920")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public RRTransform SFEPHHTYQFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x84949E0", Offset = "0x8493DE0", VA = "0x1884949E0", Slot = "15")]
			get
			{
				return default(RRTransform);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public RootFlags NCSWCUMXQHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x8494C20", Offset = "0x8494020", VA = "0x188494C20", Slot = "16")]
			get
			{
				return default(RootFlags);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x8494AE0", Offset = "0x8493EE0", VA = "0x188494AE0")]
		public VYQAUJTMMMJ(ObjectLocalId a, bool b = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x8494640", Offset = "0x8493A40", VA = "0x188494640")]
		public void ADVWJPVCITX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x84949E0", Offset = "0x8493DE0", VA = "0x1884949E0")]
		protected RRTransform NBEFOVOIPYG()
		{
			return default(RRTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x84947D0", Offset = "0x8493BD0", VA = "0x1884947D0")]
		private static bool ALZKHJXHIZN(ObjectLocalId a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x84949B0", Offset = "0x8493DB0", VA = "0x1884949B0", Slot = "18")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class FVPJUCIXJRI : CTGVHNSLJPU, EWMJKAHDSWA, WFQTCQGVRCW, IDisposable, FPHGYRGZIWF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private NativeList<CurvePointData> KIWHORPVJRE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private bool BIVXBZSDWTI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private bool RKKGHCAYQVA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private float NOMYWVFXIWT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private int RQFTVVPNNVL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private bool VTEHKPLCPTT;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private bool JXVUJQHPUCP
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0xC6B720", Offset = "0xC6AB20", VA = "0x180C6B720", Slot = "28")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		private bool SZSQEKDNOUX
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x12AD950", Offset = "0x12ACD50", VA = "0x1812AD950", Slot = "29")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private float LWBDLPZIFCI
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xAF53B0", Offset = "0xAF47B0", VA = "0x180AF53B0", Slot = "30")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private int LKHZLBJZBVK
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0xCDFFD0", Offset = "0xCDF3D0", VA = "0x180CDFFD0", Slot = "31")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		private bool UKVDVBTTQUY
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0xDAE780", Offset = "0xDADB80", VA = "0x180DAE780", Slot = "32")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private int PDMCIKPXWQP
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x847EF20", Offset = "0x847E320", VA = "0x18847EF20", Slot = "33")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		private int PLTWYVVYPIQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x847F190", Offset = "0x847E590", VA = "0x18847F190", Slot = "38")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x847F4A0", Offset = "0x847E8A0", VA = "0x18847F4A0")]
		public FVPJUCIXJRI(ObjectLocalId a, [Optional] NativeList<CurvePointData> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x847F3D0", Offset = "0x847E7D0", VA = "0x18847F3D0", Slot = "26")]
		public override void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x847EC30", Offset = "0x847E030", VA = "0x18847EC30", Slot = "27")]
		public override UnityEngine.Hash128 ComputeHash()
		{
			return default(UnityEngine.Hash128);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x847ED20", Offset = "0x847E120", VA = "0x18847ED20", Slot = "25")]
		public override void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x847F130", Offset = "0x847E530", VA = "0x18847F130")]
		public void TBMKTYKYZIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x847ED80", Offset = "0x847E180", VA = "0x18847ED80", Slot = "34")]
		public NativeArray<CurvePointData> GetNativeCurvePoints()
		{
			return default(NativeArray<CurvePointData>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x847F2B0", Offset = "0x847E6B0", VA = "0x18847F2B0", Slot = "35")]
		private Vector3 UNPKZJEPMKH(int a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x847F280", Offset = "0x847E680", VA = "0x18847F280", Slot = "36")]
		private Quaternion TUFHGWWGRFA(int a)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x847EFB0", Offset = "0x847E3B0", VA = "0x18847EFB0", Slot = "37")]
		private float KQDCKRVMIQG(int a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x847EF40", Offset = "0x847E340", VA = "0x18847EF40")]
		private NativeArray<Entity> IPFZVBUWKSQ()
		{
			return default(NativeArray<Entity>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[SystemEnabledLifetime(Lifetime.LoadInstance)]
	internal sealed class YNMLQYNIGKG : WZPOVSFZUJN
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x8495E30", Offset = "0x8495230", VA = "0x188495E30", Slot = "15")]
		protected override ComponentSystemBase UAUEFFJSODK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x8495E20", Offset = "0x8495220", VA = "0x188495E20", Slot = "13")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x84962A0", Offset = "0x84956A0", VA = "0x1884962A0")]
		[UnityEngine.Scripting.Preserve]
		public YNMLQYNIGKG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[DebugAlwaysUpdateSystem]
	public sealed class AddRemoveRenderRootSystem : TMKBBNALKNG
	{
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private static readonly Log HONKOTEDSFS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private EntityQuery FEFDCNQGTTV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private EntityQuery WIXNCLTZOGR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private EntityQuery PLCDLVFSJGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private EntityQuery KGPGQSQWSYG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private EntityQuery PNHSPYVYZDK;

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x8476F90", Offset = "0x8476390", VA = "0x188476F90", Slot = "5")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x84772C0", Offset = "0x84766C0", VA = "0x1884772C0", Slot = "13")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x8476B30", Offset = "0x8475F30", VA = "0x188476B30")]
		private void GMVEXSPYITP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x8476E60", Offset = "0x8476260", VA = "0x188476E60")]
		private void OQMGKULPRQH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x8477350", Offset = "0x8476750", VA = "0x188477350")]
		private void XCFXZEXEHAZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x8476D30", Offset = "0x8476130", VA = "0x188476D30")]
		private void ONHRRYGFEEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x8477590", Offset = "0x8476990", VA = "0x188477590")]
		private void YFTBWZVQDQT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x8477300", Offset = "0x8476700", VA = "0x188477300")]
		private NativeList<Entity> QJXGGGRTMSZ(NativeArray<Entity> a)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x8477540", Offset = "0x8476940", VA = "0x188477540")]
		private NativeList<Entity> XJHFEXMABPG(NativeArray<Entity> a)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x8476AC0", Offset = "0x8475EC0", VA = "0x188476AC0")]
		private void GMLDMIZOOPL(NativeArray<Entity> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x2DBCE90", Offset = "0x2DBC290", VA = "0x182DBCE90")]
		[UnityEngine.Scripting.Preserve]
		public AddRemoveRenderRootSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[DebugAlwaysUpdateSystem]
	[CompilerGenerated]
	public sealed class AddRemoveShapeRenderersSystem : TMKBBNALKNG, UFLUIPVILQU
	{
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private static readonly Log HONKOTEDSFS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private EntityQuery LTFCMCFQCVD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private EntityQuery QNHOURMCQRJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private EntityQuery HQETNIQIGEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private JWIZMKKQBVY UQBMGLFJGAX;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x8477DB0", Offset = "0x84771B0", VA = "0x188477DB0", Slot = "5")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x8477980", Offset = "0x8476D80", VA = "0x188477980", Slot = "15")]
		public override void InitReferences(SAMXOKXXSFT services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x8477F60", Offset = "0x8477360", VA = "0x188477F60", Slot = "13")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x84779E0", Offset = "0x8476DE0", VA = "0x1884779E0")]
		private void OPYYFUUKQCT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x8477F80", Offset = "0x8477380", VA = "0x188477F80")]
		private void POEWYLTCWYP(NativeParallelHashSet<RootHandle> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x84786F0", Offset = "0x8477AF0", VA = "0x1884786F0")]
		private void UAIRHMXILJP(NativeParallelHashSet<RootHandle> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x8478DB0", Offset = "0x84781B0", VA = "0x188478DB0")]
		private void WBETIRBVDHS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x8478640", Offset = "0x8477A40", VA = "0x188478640")]
		private bool QJQZFZPNQJU(Entity a, [Out] RootHandle b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x8477740", Offset = "0x8476B40", VA = "0x188477740")]
		internal bool DEVIWZXWBVE(Entity a, [Out] RootHandle b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x2DBCE90", Offset = "0x2DBC290", VA = "0x182DBCE90")]
		[UnityEngine.Scripting.Preserve]
		public AddRemoveShapeRenderersSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[DebugAlwaysUpdateSystem]
	public sealed class AddShapeWrapperSystem : TMKBBNALKNG
	{
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private static readonly Log HONKOTEDSFS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private EntityQuery NEYSQTQPQMS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private EntityQuery FVFWEONINDO;

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x8479240", Offset = "0x8478640", VA = "0x188479240", Slot = "5")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x8479370", Offset = "0x8478770", VA = "0x188479370", Slot = "13")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x8479390", Offset = "0x8478790", VA = "0x188479390")]
		private void POEWYLTCWYP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x84796C0", Offset = "0x8478AC0", VA = "0x1884796C0")]
		private void UAIRHMXILJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x2DBCE90", Offset = "0x2DBC290", VA = "0x182DBCE90")]
		[UnityEngine.Scripting.Preserve]
		public AddShapeWrapperSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	public class ApplyShapeModificationsToShapesAndRenderRootsSystem : TMKBBNALKNG, UFLUIPVILQU
	{
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		[BurstCompile]
		private struct CollectUpdatedShapesAndRenderersJob : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public EntityQueryInJob splineChangedQuery;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public EntityQueryInJob primitiveChangedQuery;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public EntityQueryInJob splineL2pChangedQuery;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public EntityQueryInJob primitiveL2pChangedQuery;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			[ReadOnly]
			public EntityTypeHandle entityHandleRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			[ReadOnly]
			public ComponentTypeHandle<ShapeRootHandleData> shapeRootHandleRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public NativeParallelHashSet<RootHandle> modifiedContainers;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public NativeList<Entity> modifiedPrimitives;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public NativeList<Entity> modifiedSplines;

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x847DEE0", Offset = "0x847D2E0", VA = "0x18847DEE0", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x847DF40", Offset = "0x847D340", VA = "0x18847DF40")]
			private void YTERKRLRNXJ(EntityQueryInJob a, NativeList<Entity> b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002E")]
		private struct CollectRootsAndShapesFromShapesSubJob : IQueryInJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			[ReadOnly]
			public EntityTypeHandle entityHandleRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			[ReadOnly]
			public ComponentTypeHandle<ShapeRootHandleData> shapeRootHandleRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public NativeParallelHashSet<RootHandle> modifiedContainers;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public NativeList<Entity> modifiedShapes;

			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x847DA10", Offset = "0x847CE10", VA = "0x18847DA10")]
			public void UYRAXZXWIPH([In] ArchetypeChunk chunk, int a, bool b, [In] v128 chunkEnabledMask)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x847DA00", Offset = "0x847CE00", VA = "0x18847DA00", Slot = "4")]
			private void JQUQTOSAZKV([In] ArchetypeChunk chunk, int a, bool b, [In] v128 chunkEnabledMask)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private static readonly Log HONKOTEDSFS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private EntityQuery HIQZXKPALYX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private EntityQuery NYJXSIXVQFV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private EntityQuery CEXWPJASEPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private EntityQuery DEIIMDUETVF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private EntityQuery ANBZSAJIYAI;

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x8479E10", Offset = "0x8479210", VA = "0x188479E10", Slot = "5")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x847A220", Offset = "0x8479620", VA = "0x18847A220", Slot = "13")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x847A5F0", Offset = "0x84799F0", VA = "0x18847A5F0")]
		private void PDALXCEPTKS(NativeParallelHashSet<RootHandle> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x8479A70", Offset = "0x8478E70", VA = "0x188479A70")]
		private void JUHRHXFTCFE(NativeParallelHashSet<RootHandle> a, int b, int c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x2DBCE90", Offset = "0x2DBC290", VA = "0x182DBCE90")]
		[UnityEngine.Scripting.Preserve]
		public ApplyShapeModificationsToShapesAndRenderRootsSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	public class ApplyShapeMoveBetweenBatchedMeshesSystem : TMKBBNALKNG
	{
		[Cpp2IlInjected.Token(Token = "0x2000030")]
		[BurstCompile]
		private struct CollectShapesAndContainersWithChangedParentsAndUpdateShapeRootHandleJob : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			[ReadOnly]
			public EntityTypeHandle entityHandleRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			[ReadOnly]
			public ComponentTypeHandle<ParentData> parentHandleRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			[ReadOnly]
			public ComponentTypeHandle<ShapeHandleData> shapeHandleRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			[ReadOnly]
			public ComponentLookup<RenderRootHandleData> renderRootHandleFromEntityRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			[ReadOnly]
			public ComponentLookup<RecRoom.Components.SelectionDescendantTag> selectionDescendantFromEntityRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			public ComponentTypeHandle<ShapeRootHandleData> shapeRootHandleRW;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			public NativeParallelHashSet<RootHandle> modifiedContainers;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public NativeList<Entity> movedShapes;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public NativeList<ShapeHandleData> invalidatedShapeHandles;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public NativeList<RootHandle> newShapeRoots;

			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x847DBE0", Offset = "0x847CFE0", VA = "0x18847DBE0")]
			public void UYRAXZXWIPH([In] ArchetypeChunk chunk, int a, bool b, [In] v128 chunkEnabledMask)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x847DED0", Offset = "0x847D2D0", VA = "0x18847DED0", Slot = "4")]
			private void VYTCQEQFCRW([In] ArchetypeChunk chunk, int a, bool b, [In] v128 chunkEnabledMask)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private static readonly Log HONKOTEDSFS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private EntityQuery GTVNDTOMUVN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private EntityQuery HJEPRBMBITN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private EntityQuery MKJOIYVUQQB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private EntityQuery FXGMSWJJZMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private EntityQuery ZNJNHCPLBUW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private JWIZMKKQBVY DKFYRTLEYZZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private AddRemoveShapeRenderersSystem OPDQYUORLWT;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x847BDD0", Offset = "0x847B1D0", VA = "0x18847BDD0", Slot = "5")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x847AC20", Offset = "0x847A020", VA = "0x18847AC20", Slot = "15")]
		public override void InitReferences(SAMXOKXXSFT services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x847C190", Offset = "0x847B590", VA = "0x18847C190", Slot = "13")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x847AC80", Offset = "0x847A080", VA = "0x18847AC80")]
		private void JCOQSSOGBZX(NativeParallelHashSet<RootHandle> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x847B4D0", Offset = "0x847A8D0", VA = "0x18847B4D0")]
		private void JONDYOPNIZM(NativeParallelHashSet<RootHandle> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x847B970", Offset = "0x847AD70", VA = "0x18847B970")]
		private void KFHJIHHABUK(NativeParallelHashSet<RootHandle> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x847A770", Offset = "0x8479B70", VA = "0x18847A770")]
		private void HOVHFQWAXIW(NativeParallelHashSet<RootHandle> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x847C5A0", Offset = "0x847B9A0", VA = "0x18847C5A0")]
		private void TWNIRZIBYFF(NativeParallelHashSet<RootHandle> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x847CAC0", Offset = "0x847BEC0", VA = "0x18847CAC0")]
		private void ZAYSINCBNNG(Entity a, ShapeHandle b, RootHandle c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x2DBCE90", Offset = "0x2DBC290", VA = "0x182DBCE90")]
		[UnityEngine.Scripting.Preserve]
		public ApplyShapeMoveBetweenBatchedMeshesSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public sealed class AttachRenderProxyToEmbodiedContainerSystem : TMKBBNALKNG
	{
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private static readonly Log HONKOTEDSFS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private EntityQuery NNEUOBRZKBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private EntityQuery QKXIJZRFNEG;

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x847CD30", Offset = "0x847C130", VA = "0x18847CD30", Slot = "5")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x847CF50", Offset = "0x847C350", VA = "0x18847CF50", Slot = "13")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x2DBCE90", Offset = "0x2DBC290", VA = "0x182DBCE90")]
		[UnityEngine.Scripting.Preserve]
		public AttachRenderProxyToEmbodiedContainerSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public class TKJDJILBOSC : TMKBBNALKNG
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		[TypeManager.ForcedStableTypeHash(13972172025007325174uL)]
		private struct RemovedFromClusterLodTag : IComponentData
		{
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private EntityQuery PAJIMCEDFFA;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x8494130", Offset = "0x8493530", VA = "0x188494130", Slot = "5")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x8494260", Offset = "0x8493660", VA = "0x188494260", Slot = "13")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x2DBCE90", Offset = "0x2DBC290", VA = "0x182DBCE90")]
		[UnityEngine.Scripting.Preserve]
		public TKJDJILBOSC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[DebugAlwaysUpdateSystem]
	internal class RemoveShapeEffectsSystem : TMKBBNALKNG
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		private class Effect
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public EntityQuery GOFTEBPRUOE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public EntityQuery GKNTXQUBKZL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public RemoveEffect KSMAMNAZRTN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public ComponentType UDUKZGGXOJE;

			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public Effect()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000037")]
		private delegate void RemoveEffect(NativeArray<ShapeHandle> handle, IHTOZJMDENQ shapeEffectManager);

		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private static readonly Log HONKOTEDSFS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private List<Effect> WNAQZKMNDXW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private LZYDIMTSOON UXCZUOGXBYZ;

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x8491540", Offset = "0x8490940", VA = "0x188491540", Slot = "15")]
		public override void InitReferences(SAMXOKXXSFT services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x84915A0", Offset = "0x84909A0", VA = "0x1884915A0", Slot = "5")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x8491850", Offset = "0x8490C50", VA = "0x188491850", Slot = "13")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x3A3C900", Offset = "0x3A3BD00", VA = "0x183A3C900")]
		private void WZPUIKJLIHO<a>(RemoveEffect a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x8491F40", Offset = "0x8491340", VA = "0x188491F40")]
		private static void USZVWQHDJVG(NativeArray<ShapeHandle> a, IHTOZJMDENQ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x8491D70", Offset = "0x8491170", VA = "0x188491D70")]
		private static void TBAFKMUBLEM(NativeArray<ShapeHandle> a, IHTOZJMDENQ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x8491370", Offset = "0x8490770", VA = "0x188491370")]
		private static void GWBDLJQXTFK(NativeArray<ShapeHandle> a, IHTOZJMDENQ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x2DBCE90", Offset = "0x2DBC290", VA = "0x182DBCE90")]
		[UnityEngine.Scripting.Preserve]
		public RemoveShapeEffectsSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[DebugAlwaysUpdateSystem]
	public sealed class RemoveShapesFromShapeRenderer : TMKBBNALKNG
	{
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private static readonly Log HONKOTEDSFS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private EntityQuery ATKRDESKCXU;

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x8492190", Offset = "0x8491590", VA = "0x188492190", Slot = "5")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x8492250", Offset = "0x8491650", VA = "0x188492250", Slot = "13")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x2DBCE90", Offset = "0x2DBC290", VA = "0x182DBCE90")]
		[UnityEngine.Scripting.Preserve]
		public RemoveShapesFromShapeRenderer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public struct BakedPrimitiveData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public UniformTRS parentFromLocalTRS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public StandardRenderableVisualData visualData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public PrimitiveShapeMeshType primitiveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public float3 deformationRatio;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public bool dynamicUVProjection;
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[MessageLifetime(Lifetime.LoadInstance)]
	public struct BakedPrimitiveMessage : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public Entity scene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public NativeList<Entity> entities;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public NativeList<Entity> parents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public NativeParallelHashSet<Entity> uniqueParents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public NativeList<BakedPrimitiveData> primitiveData;

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x847D520", Offset = "0x847C920", VA = "0x18847D520", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[RegisterService(typeof(AKJUGDYNWZL), new string[] { })]
	[ServiceLifetime(Lifetime.OMRoom)]
	internal class AKJUGDYNWZL : UFLUIPVILQU, LGPJMXYAVLB, TUMMHZEQETT, LZXVIVBNZGR
	{
		[Cpp2IlInjected.Token(Token = "0x200003C")]
		public readonly struct SplineMessageQueueScope : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000090")]
			private readonly AKJUGDYNWZL parent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			private readonly bool disposePointData;

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x17DCB20", Offset = "0x17DBF20", VA = "0x1817DCB20")]
			public SplineMessageQueueScope(AKJUGDYNWZL parent, bool disposePointData)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x8494090", Offset = "0x8493490", VA = "0x188494090")]
			public Queue<BakedSplinesMessage>.Enumerator GetEnumerator()
			{
				return default(Queue<BakedSplinesMessage>.Enumerator);
			}

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x8493DE0", Offset = "0x84931E0", VA = "0x188493DE0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private static readonly Log HONKOTEDSFS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		[DependsOn]
		private LNGQTCAXYFX MBTMJLHIZKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		[DependsOn]
		private SBBKFEIPZJV ZZRYQPHNQAS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private List<NativeList<CurvePointData>> BJXCNCWBXPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private List<(Entity, List<GameObject>)> NYMJIXSNWAX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private NativeList<ShapeHandle> HXZKSTFYJCS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private GCUFCDBIDBX<BakedSplinesMessage> WXNPFPZLXBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private GCUFCDBIDBX<BakedPrimitiveMessage> AVKISTXJNVX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private GCUFCDBIDBX<BakedShapeColliderMessage> XVTDSAAXWMS;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x8475BA0", Offset = "0x8474FA0", VA = "0x188475BA0", Slot = "4")]
		public void InitReferences(SAMXOKXXSFT services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x8476640", Offset = "0x8475A40", VA = "0x188476640")]
		public void QDWDWVQELYP(NativeList<CurvePointData> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x8476890", Offset = "0x8475C90", VA = "0x188476890")]
		public void WDKELORZZNM(Entity a, [In] PATPBQUPMIT<GameObject> inColliders)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x8476810", Offset = "0x8475C10", VA = "0x188476810")]
		public void VFVANUSRMKC(NativeList<ShapeHandle> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x8476410", Offset = "0x8475810", VA = "0x188476410")]
		public void PPWGWRVMTQQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x8475DF0", Offset = "0x84751F0", VA = "0x188475DF0")]
		public void MKJXMSAPUQL(PDKFUQTKNFO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x8476370", Offset = "0x8475770", VA = "0x188476370")]
		public JobHandle OLEQVQOEYOU([In] BakedSplinesMessage message, JobHandle a)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x84762D0", Offset = "0x84756D0", VA = "0x1884762D0")]
		public JobHandle OLEQVQOEYOU([In] BakedPrimitiveMessage message, JobHandle a)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x8111700", Offset = "0x8110B00", VA = "0x188111700")]
		public SplineMessageQueueScope HETEKSZYJEZ(bool a)
		{
			return default(SplineMessageQueueScope);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x84767C0", Offset = "0x8475BC0", VA = "0x1884767C0")]
		public MessageQueueScope<BakedPrimitiveMessage> TQJLKDVXXKJ()
		{
			return default(MessageQueueScope<BakedPrimitiveMessage>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x8475DA0", Offset = "0x84751A0", VA = "0x188475DA0")]
		public MessageQueueScope<BakedShapeColliderMessage> LKDDELQRKYE()
		{
			return default(MessageQueueScope<BakedShapeColliderMessage>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x8475910", Offset = "0x8474D10", VA = "0x188475910")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x84766E0", Offset = "0x8475AE0", VA = "0x1884766E0", Slot = "5")]
		public void RWVOXCJLGEZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x8475B30", Offset = "0x8474F30", VA = "0x188475B30", Slot = "6")]
		private void EEVWSJPJMZT(SAMXOKXXSFT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0xD15010", Offset = "0xD14410", VA = "0x180D15010", Slot = "7")]
		private void BFZHWFFBFON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public AKJUGDYNWZL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public struct BakedSplineData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public UniformTRS parentFromLocalTRS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public StandardRenderableVisualData visualData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public SplineParameters parameters;
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[MessageLifetime(Lifetime.LoadInstance)]
	public struct BakedSplinesMessage : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public Entity scene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public NativeList<Entity> entities;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public NativeList<Entity> parents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public NativeParallelHashSet<Entity> uniqueParents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public NativeList<RecRoom.Foundation.Collections.Range> pointRanges;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public NativeList<CurvePointData> pointData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public NativeList<BakedSplineData> splineData;

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x847D5B0", Offset = "0x847C9B0", VA = "0x18847D5B0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x847D5C0", Offset = "0x847C9C0", VA = "0x18847D5C0")]
		public void Dispose(bool disposePointData)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[RegisterService(typeof(HIVVIGXDDHI), new string[] { })]
	[ServiceLifetime(Lifetime.LoadInstance)]
	internal class HIVVIGXDDHI : DUFVPRZKCTS, TUMMHZEQETT, LZXVIVBNZGR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		[DependsOn]
		private AKJUGDYNWZL YLDTICSQSFL;

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x84842E0", Offset = "0x84836E0", VA = "0x1884842E0", Slot = "4")]
		public void ShutdownReferences()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x8484290", Offset = "0x8483690", VA = "0x188484290", Slot = "5")]
		private void EEVWSJPJMZT(SAMXOKXXSFT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0xC5AA40", Offset = "0xC59E40", VA = "0x180C5AA40", Slot = "6")]
		private void BFZHWFFBFON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public HIVVIGXDDHI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[SystemEnabledLifetime(Lifetime.OMRoom)]
	[CompilerGenerated]
	public class PostDeserializeBakeShapesSystem : TMKBBNALKNG, UFLUIPVILQU
	{
		[Cpp2IlInjected.Token(Token = "0x2000041")]
		[BurstCompile]
		private struct GatherBakedPrimitiveDataJob : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			[ReadOnly]
			public ComponentTypeHandle<StandardRenderableVisualData> visualTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			[ReadOnly]
			public ComponentTypeHandle<AuthoredLocalPoseData> poseTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			[ReadOnly]
			public ComponentTypeHandle<AuthoredLocalUniformScaleData> scaleTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			[ReadOnly]
			public ComponentTypeHandle<LocalDeformableScaleData> deformationScaleTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			[ReadOnly]
			public ComponentTypeHandle<ShapeConfigData> configTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			[ReadOnly]
			public ComponentTypeHandle<PrimitiveShapeData> shapeDataTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			[ReadOnly]
			public NativeParallelHashMap<int, PrimitiveShapeMeshType> primitiveToMeshTypeRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			[ReadOnly]
			public NativeArray<int> chunkBaseEntityIndicies;

			[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			[NativeDisableParallelForRestriction]
			public NativeArray<BakedPrimitiveData> primitiveDataRW;

			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x847F5D0", Offset = "0x847E9D0", VA = "0x18847F5D0")]
			public void UYRAXZXWIPH([In] ArchetypeChunk chunk, int a, bool b, [In] v128 chunkEnabledMask)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x847F950", Offset = "0x847ED50", VA = "0x18847F950", Slot = "4")]
			private void VYTCQEQFCRW([In] ArchetypeChunk chunk, int a, bool b, [In] v128 chunkEnabledMask)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000042")]
		[BurstCompile]
		private struct GatherBakedSplineDataJob : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			[ReadOnly]
			public ComponentTypeHandle<SplineShapeData> splineShapeTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			[ReadOnly]
			public ComponentTypeHandle<StandardRenderableVisualData> visualTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			[ReadOnly]
			public ComponentTypeHandle<AuthoredLocalPoseData> poseTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			[ReadOnly]
			public ComponentTypeHandle<AuthoredLocalUniformScaleData> scaleTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			[ReadOnly]
			public NativeArray<CurvePointData> splinePointDataRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			[ReadOnly]
			public NativeArray<RecRoom.Foundation.Collections.Range> splinePointRangesRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			[ReadOnly]
			public NativeArray<int> chunkBaseEntityIndicies;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			[NativeDisableParallelForRestriction]
			public NativeArray<BakedSplineData> bakedSplineDataRW;

			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x847F960", Offset = "0x847ED60", VA = "0x18847F960")]
			public void UYRAXZXWIPH([In] ArchetypeChunk chunk, int a, bool b, [In] v128 chunkEnabledMask)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x847FC80", Offset = "0x847F080", VA = "0x18847FC80", Slot = "4")]
			private void VYTCQEQFCRW([In] ArchetypeChunk chunk, int a, bool b, [In] v128 chunkEnabledMask)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000043")]
		[BurstCompile]
		internal struct CalculateSplinePointEstimateJob : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			[ReadOnly]
			public BufferTypeHandle<LinkedEntityGroup> linkedEntityGroup;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			public NativeArray<int> pointEstimate;

			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x847D8B0", Offset = "0x847CCB0", VA = "0x18847D8B0")]
			public void UYRAXZXWIPH([In] ArchetypeChunk batchInChunk, int a, bool b, [In] v128 chunkEnabledMask)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x847D9F0", Offset = "0x847CDF0", VA = "0x18847D9F0", Slot = "4")]
			private void VYTCQEQFCRW([In] ArchetypeChunk chunk, int a, bool b, [In] v128 chunkEnabledMask)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000044")]
		[BurstCompile]
		private struct GeneratePointsJob : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x2000045")]
			private struct PointSrcData
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000C8")]
				public float3 Position;

				[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
				[Cpp2IlInjected.Token(Token = "0x40000C9")]
				public quaternion Rotation;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
				[Cpp2IlInjected.Token(Token = "0x40000CA")]
				public float Radius;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000CB")]
				public quaternion BlendedRotation;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40000CC")]
				public float BendAngle;

				[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
				[Cpp2IlInjected.Token(Token = "0x40000CD")]
				public float BendRadius;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40000CE")]
				public float DistanceToNext;

				[Cpp2IlInjected.Token(Token = "0x17000023")]
				public float3 RVAEWTVXHWD
				{
					[Cpp2IlInjected.Token(Token = "0x600013E")]
					[Cpp2IlInjected.Address(RVA = "0x8487A80", Offset = "0x8486E80", VA = "0x188487A80")]
					get
					{
						return default(float3);
					}
					[Cpp2IlInjected.Token(Token = "0x600013F")]
					[Cpp2IlInjected.Address(RVA = "0x8487AA0", Offset = "0x8486EA0", VA = "0x188487AA0")]
					set
					{
					}
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000046")]
			private interface QSSHGTFFJLK
			{
				[Cpp2IlInjected.Token(Token = "0x6000140")]
				[Cpp2IlInjected.Address(Slot = "0")]
				float3 BUCJWXBSGFG(quaternion a);
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000047")]
			private struct LegacyDirectionFromRotation : QSSHGTFFJLK
			{
				[Cpp2IlInjected.Token(Token = "0x6000141")]
				[Cpp2IlInjected.Address(RVA = "0x8486E80", Offset = "0x8486280", VA = "0x188486E80", Slot = "5")]
				public float3 PZZQSNVFMQV(quaternion a)
				{
					return default(float3);
				}

				[Cpp2IlInjected.Token(Token = "0x6000142")]
				[Cpp2IlInjected.Address(RVA = "0x8486E40", Offset = "0x8486240", VA = "0x188486E40", Slot = "4")]
				public float3 BUCJWXBSGFG(quaternion a)
				{
					return default(float3);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000048")]
			private struct NewDirectionFromRotation : QSSHGTFFJLK
			{
				[Cpp2IlInjected.Token(Token = "0x6000143")]
				[Cpp2IlInjected.Address(RVA = "0x8487760", Offset = "0x8486B60", VA = "0x188487760", Slot = "4")]
				public float3 BUCJWXBSGFG(quaternion a)
				{
					return default(float3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			private static readonly float3 Up;

			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			private static readonly float3 DirectionAxis;

			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			private static readonly float3 NormalAxis;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			[ReadOnly]
			public EntityTypeHandle entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			[ReadOnly]
			public BufferTypeHandle<LinkedEntityGroup> pointsByEntity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			[ReadOnly]
			public ComponentTypeHandle<ShapeConfigData> shapeConfigTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			[ReadOnly]
			public ComponentTypeHandle<SplineShapeData> splineParametersTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			[ReadOnly]
			public ComponentLookup<SplinePointPositionData> pointPositions;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			[ReadOnly]
			public ComponentLookup<SplinePointRotationData> pointRotations;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			[ReadOnly]
			public ComponentLookup<SplinePointScaleData> pointScales;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			[ReadOnly]
			public NativeArray<int> chunkBaseEntityIndicies;

			[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			[NativeDisableParallelForRestriction]
			public NativeArray<RecRoom.Foundation.Collections.Range> splinePointRangesRW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			[NativeDisableParallelForRestriction]
			public NativeArray<CurvePointData> splinePointDataRW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			[NativeDisableParallelForRestriction]
			public NativeArray<int> pointCountRW;

			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x8482480", Offset = "0x8481880", VA = "0x188482480")]
			public void UYRAXZXWIPH([In] ArchetypeChunk chunk, int a, bool b, [In] v128 chunkEnabledMask)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x84804E0", Offset = "0x847F8E0", VA = "0x1884804E0")]
			private void HLTPVEZXFNT(NativeList<PointSrcData> a, NativeList<CurvePointData> b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x8482C80", Offset = "0x8482080", VA = "0x188482C80")]
			public static Vector3 WMIGTCBBHRS(Vector3 a, Vector3 b, Vector3 c)
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x8481F70", Offset = "0x8481370", VA = "0x188481F70")]
			public static quaternion OKYCKPQHCBX(float3 a, float3 b)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x84801E0", Offset = "0x847F5E0", VA = "0x1884801E0")]
			private static quaternion FOYITGMYSCN(float3 a, float b, quaternion c)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x8484030", Offset = "0x8483430", VA = "0x188484030")]
			private static float3 ZWFZGXMNLXX(float3 a, float b, float3 c)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x8482240", Offset = "0x8481640", VA = "0x188482240")]
			private static quaternion RRAJSNEMAJI(float3 a, float b)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x8481470", Offset = "0x8480870", VA = "0x188481470")]
			private static CurvePointData JODNGRSYBOA(int a, NativeList<PointSrcData> b)
			{
				return default(CurvePointData);
			}

			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x3C5A060", Offset = "0x3C59460", VA = "0x183C5A060")]
			private void JITRFRKEYEL<a>(NativeArray<Entity> a, NativeList<PointSrcData> b, float c, a d) where a : struct, QSSHGTFFJLK
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x8483090", Offset = "0x8482490", VA = "0x188483090")]
			private void ZNMDQUZVIVU(NativeList<PointSrcData> a, NativeList<CurvePointData> b, float c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x8481DF0", Offset = "0x84811F0", VA = "0x188481DF0")]
			public static float OBYEVLGLSAJ(float3 a, float3 b, float3 c)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x8481C00", Offset = "0x8481000", VA = "0x188481C00")]
			private static quaternion Lerp(quaternion q1, quaternion q2, float t)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x8482AD0", Offset = "0x8481ED0", VA = "0x188482AD0")]
			private static CurvePointData VAMCWGDULXX(PointSrcData a)
			{
				return default(CurvePointData);
			}

			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x8482A40", Offset = "0x8481E40", VA = "0x188482A40")]
			private static CurvePointData VAMCWGDULXX(float3 a, quaternion b, float c)
			{
				return default(CurvePointData);
			}

			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x8481FF0", Offset = "0x84813F0", VA = "0x188481FF0")]
			private static bool PVZBPGNHIIK(float3 a, float b, [Out] float3 c)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x8480410", Offset = "0x847F810", VA = "0x188480410")]
			private static float3 FVMQJUVRXPL(float3 a, float b)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x84822D0", Offset = "0x84816D0", VA = "0x1884822D0")]
			public static float3 TBPIKXTRAHF(quaternion a)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0x8482090", Offset = "0x8481490", VA = "0x188482090")]
			public static float3 PZZQSNVFMQV(quaternion a)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x84817A0", Offset = "0x8480BA0", VA = "0x1884817A0")]
			private static quaternion JVZMZJDLABG(quaternion a, float3 b)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x8480070", Offset = "0x847F470", VA = "0x188480070")]
			private static float Angle(float3 from, float3 to)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0x8482BF0", Offset = "0x8481FF0", VA = "0x188482BF0", Slot = "4")]
			private void VYTCQEQFCRW([In] ArchetypeChunk chunk, int a, bool b, [In] v128 chunkEnabledMask)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000049")]
		[NoAlias]
		[BurstCompile]
		private struct PostDeserializeBakeShapesSystem_7201168C_LambdaJob_0_Job : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			[ReadOnly]
			public NativeArray<int> __ChunkBaseEntityIndices;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			public EntityCommandBuffer.ParallelWriter ecbWriter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			public BufferTypeHandle<LinkedEntityGroup> __splineAndPointsTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0x8487AF0", Offset = "0x8486EF0", VA = "0x188487AF0")]
			private void KLLLJNUDNQC(DynamicBuffer<LinkedEntityGroup> a, int b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(RVA = "0x8487BD0", Offset = "0x8486FD0", VA = "0x188487BD0")]
			[CompilerGenerated]
			public void UYRAXZXWIPH([In] ArchetypeChunk chunk, int a, bool b, [In] v128 chunkEnabledMask)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x8488040", Offset = "0x8487440", VA = "0x188488040", Slot = "4")]
			private void VYTCQEQFCRW([In] ArchetypeChunk chunk, int a, bool b, [In] v128 chunkEnabledMask)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004A")]
		[NoAlias]
		[BurstCompile]
		private struct TrimSplinePointExcess_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			[ReadOnly]
			public NativeArray<int> pointCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			public NativeList<CurvePointData> splinePointData;

			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0x84944B0", Offset = "0x84938B0", VA = "0x1884944B0")]
			private void KLLLJNUDNQC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0x84944A0", Offset = "0x84938A0", VA = "0x1884944A0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004B")]
		[NoAlias]
		[BurstCompile]
		private struct SetSplinePointCapacity_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D4")]
			public NativeList<CurvePointData> splinePointData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			[ReadOnly]
			public NativeArray<int> pointEstimate;

			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0x8493D90", Offset = "0x8493190", VA = "0x188493D90")]
			private void KLLLJNUDNQC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0x8493D80", Offset = "0x8493180", VA = "0x188493D80", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004C")]
		[NoAlias]
		[BurstCompile]
		private struct GatherPrimitivesAndUniqueParents_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			public EntityQueryInJob queryInJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000D7")]
			[ReadOnly]
			public EntityTypeHandle entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			[ReadOnly]
			public ComponentTypeHandle<ParentData> parentTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			public NativeList<Entity> entities;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000DA")]
			public NativeList<Entity> parents;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000DB")]
			public NativeParallelHashSet<Entity> uniqueParents;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40000DC")]
			public NativeList<BakedPrimitiveData> data;

			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x847FCA0", Offset = "0x847F0A0", VA = "0x18847FCA0")]
			private void KLLLJNUDNQC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0x847FC90", Offset = "0x847F090", VA = "0x18847FC90", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004D")]
		[NoAlias]
		[BurstCompile]
		private struct GatherSplinesAndUniqueParents_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DD")]
			public EntityQueryInJob queryInJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000DE")]
			[ReadOnly]
			public EntityTypeHandle entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000DF")]
			[ReadOnly]
			public ComponentTypeHandle<ParentData> parentTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000E0")]
			public NativeList<Entity> splines;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000E1")]
			public NativeList<Entity> parents;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000E2")]
			public NativeParallelHashSet<Entity> uniqueParents;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			public NativeList<RecRoom.Foundation.Collections.Range> ranges;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			public NativeList<BakedSplineData> bakedData;

			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0x847FE70", Offset = "0x847F270", VA = "0x18847FE70")]
			private void KLLLJNUDNQC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x847FE60", Offset = "0x847F260", VA = "0x18847FE60", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004E")]
		[NoAlias]
		[BurstCompile]
		private struct RemoveDestroyedEntitiesFromParents_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			[ReadOnly]
			public NativeList<Entity> splineParents;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			[ReadOnly]
			public NativeList<Entity> splineEntities;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			public EntityCommandBuffer ecb;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			public BufferLookup<ChildBuffer> childrenFromEntity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			public BufferLookup<AuthoredChildBuffer> authoredChildrenFromEntity;

			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0x8490F40", Offset = "0x8490340", VA = "0x188490F40")]
			private void KLLLJNUDNQC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x8490F30", Offset = "0x8490330", VA = "0x188490F30", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004F")]
		private struct TypeHandle
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			public BufferTypeHandle<LinkedEntityGroup> __Unity_Entities_LinkedEntityGroup_RW_BufferTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0x8494510", Offset = "0x8493910", VA = "0x188494510")]
			public void YWIETSBIDIU(SystemState a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private static readonly Log HONKOTEDSFS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private EntityQuery GZIIHJPKDGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private EntityQuery KRPVOPFQNXX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private ZBLNVVVSLGF ZBAZKUJTMUL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private LNGQTCAXYFX MBTMJLHIZKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private AKJUGDYNWZL YLDTICSQSFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private PostDeserializeECB WVNLZXYFSGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private TypeHandle IHBZCKRRGNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private EntityQuery ZKHZSXVKIJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private EntityQuery ZKNGQEPHRUP;

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x8488CE0", Offset = "0x84880E0", VA = "0x188488CE0", Slot = "15")]
		public override void InitReferences(SAMXOKXXSFT services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x848A200", Offset = "0x8489600", VA = "0x18848A200", Slot = "5")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x848A2D0", Offset = "0x84896D0", VA = "0x18848A2D0", Slot = "6")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x848A330", Offset = "0x8489730", VA = "0x18848A330", Slot = "13")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x848AC00", Offset = "0x848A000", VA = "0x18848AC00")]
		private JobHandle USJKYIFYAVP(EntityQuery a, Entity b, JobHandle c)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x8489A10", Offset = "0x8488E10", VA = "0x188489A10")]
		private JobHandle OCALLIANBTZ(EntityQuery a, Entity b, JobHandle c)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x848A700", Offset = "0x8489B00", VA = "0x18848A700")]
		private JobHandle SDRDEDEXLDO(NativeArray<int> a, NativeList<CurvePointData> b, JobHandle c)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x8488C40", Offset = "0x8488040", VA = "0x188488C40")]
		private JobHandle IZKYBIDQBAP(NativeList<CurvePointData> a, NativeArray<int> b, JobHandle c)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x8488430", Offset = "0x8487830", VA = "0x188488430")]
		private JobHandle GHNKGBQJHYW(EntityQuery a, NativeList<RecRoom.Foundation.Collections.Range> b, NativeList<CurvePointData> c, NativeArray<int> d, JobHandle e)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x848AF00", Offset = "0x848A300", VA = "0x18848AF00")]
		private JobHandle WGRCDRLYYFU(EntityCommandBuffer a, JobHandle b)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x848A5D0", Offset = "0x84899D0", VA = "0x18848A5D0")]
		private JobHandle SDLMLWJQGLX(NativeArray<int> a, JobHandle b)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x8488980", Offset = "0x8487D80", VA = "0x188488980")]
		private JobHandle HXNCCLIZFEQ(EntityQuery a, [Out] NativeList<Entity> b, [Out] NativeList<Entity> c, [Out] NativeList<BakedPrimitiveData> d, [Out] NativeParallelHashSet<Entity> e, JobHandle f, Allocator g = Allocator.TempJob)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x8488160", Offset = "0x8487560", VA = "0x188488160")]
		private JobHandle ENUMMYCWLHM(EntityQuery a, [Out] NativeList<Entity> b, [Out] NativeList<Entity> c, [Out] NativeList<RecRoom.Foundation.Collections.Range> d, [Out] NativeList<BakedSplineData> e, [Out] NativeParallelHashSet<Entity> f, JobHandle g, Allocator h = Allocator.TempJob)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x8489320", Offset = "0x8488720", VA = "0x188489320")]
		private JobHandle NDINXGUBXLV(NativeList<Entity> a, NativeList<Entity> b, EntityCommandBuffer c, JobHandle d)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x8488D80", Offset = "0x8488180", VA = "0x188488D80")]
		private JobHandle MPAHBORVEFL(EntityQuery a, NativeList<BakedPrimitiveData> b, JobHandle c)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x848B0D0", Offset = "0x848A4D0", VA = "0x18848B0D0")]
		private static NativeParallelHashMap<int, PrimitiveShapeMeshType> YIEWDVVOBMX()
		{
			return default(NativeParallelHashMap<int, PrimitiveShapeMeshType>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x848A7B0", Offset = "0x8489BB0", VA = "0x18848A7B0")]
		private JobHandle TCCACERJSAV(EntityQuery a, NativeList<RecRoom.Foundation.Collections.Range> b, NativeList<CurvePointData> c, NativeList<BakedSplineData> d, JobHandle e)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x848B620", Offset = "0x848AA20", VA = "0x18848B620")]
		private JobHandle ZDUSHJABOVS(EntityCommandBuffer.ParallelWriter a, JobHandle b)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x848A700", Offset = "0x8489B00", VA = "0x18848A700")]
		private JobHandle WZYARJRHOGE(NativeArray<int> a, NativeList<CurvePointData> b, JobHandle c)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x8488C40", Offset = "0x8488040", VA = "0x188488C40")]
		private JobHandle YXBHUSYATIX(NativeList<CurvePointData> a, NativeArray<int> b, JobHandle c)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x8488050", Offset = "0x8487450", VA = "0x188488050")]
		private JobHandle EKBNEHEQIGY(EntityQueryInJob a, EntityTypeHandle b, ComponentTypeHandle<ParentData> c, NativeList<Entity> d, NativeList<Entity> e, NativeParallelHashSet<Entity> f, NativeList<BakedPrimitiveData> g, JobHandle h)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x848A4A0", Offset = "0x84898A0", VA = "0x18848A4A0")]
		private JobHandle QYRENPBKODQ(EntityQueryInJob a, EntityTypeHandle b, ComponentTypeHandle<ParentData> c, NativeList<Entity> d, NativeList<Entity> e, NativeParallelHashSet<Entity> f, NativeList<RecRoom.Foundation.Collections.Range> g, NativeList<BakedSplineData> h, JobHandle i)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x848B4F0", Offset = "0x848A8F0", VA = "0x18848B4F0")]
		private JobHandle YKQRWHHNUHJ(NativeList<Entity> a, NativeList<Entity> b, EntityCommandBuffer c, BufferLookup<ChildBuffer> d, BufferLookup<AuthoredChildBuffer> e, JobHandle f)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x8489620", Offset = "0x8488A20", VA = "0x188489620")]
		private void NFLBUEDBKVB(SystemState a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x848A170", Offset = "0x8489570", VA = "0x18848A170", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x2DBCE90", Offset = "0x2DBC290", VA = "0x182DBCE90")]
		[UnityEngine.Scripting.Preserve]
		public PostDeserializeBakeShapesSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public class JGXNUFPSUZY : NOHBMPGHBDW, UFLUIPVILQU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private AKJUGDYNWZL YLDTICSQSFL;

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x8484300", Offset = "0x8483700", VA = "0x188484300", Slot = "14")]
		public void InitReferences(SAMXOKXXSFT services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x8484350", Offset = "0x8483750", VA = "0x188484350", Slot = "13")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x2B1A950", Offset = "0x2B19D50", VA = "0x182B1A950")]
		[UnityEngine.Scripting.Preserve]
		public JGXNUFPSUZY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[SystemEnabledLifetime(Lifetime.LoadInstance)]
	[CompilerGenerated]
	public class PostLoadCreateBakedShapesWrappersSystem : TMKBBNALKNG, UFLUIPVILQU
	{
		[Cpp2IlInjected.Token(Token = "0x2000052")]
		private struct DescriptorSetEnumerator<T> where T : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F0")]
			private EntityManager entityManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F1")]
			private EntityDataArrays<T> set;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F2")]
			private NativeArray<EntityRemapUtility.EntityRemapInfo> entityRemapping;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			private int index;

			[Cpp2IlInjected.Token(Token = "0x17000024")]
			public (Entity parent, Transform containerWrapper, NativeArray<T> descriptors) QBLKRTGOVAT
			{
				[Cpp2IlInjected.Token(Token = "0x6000169")]
				[Cpp2IlInjected.Address(RVA = "0x41762B0", Offset = "0x41756B0", VA = "0x1841762B0")]
				get
				{
					return default((Entity, Transform, NativeArray<T>));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x4176C00", Offset = "0x4176000", VA = "0x184176C00")]
			public DescriptorSetEnumerator(EntityManager entityManager, EntityDataArrays<T> set, NativeArray<EntityRemapUtility.EntityRemapInfo> entityRemapping)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x412F350", Offset = "0x412E750", VA = "0x18412F350")]
			public DescriptorSetEnumerator<T> GetEnumerator()
			{
				return default(DescriptorSetEnumerator<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x4176AE0", Offset = "0x4175EE0", VA = "0x184176AE0")]
			public bool MoveNext()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private static readonly Log HONKOTEDSFS;

		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private static readonly Log JXSFMXAZLVK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private SBBKFEIPZJV ZZRYQPHNQAS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private AKJUGDYNWZL YLDTICSQSFL;

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x848C5B0", Offset = "0x848B9B0", VA = "0x18848C5B0", Slot = "15")]
		public override void InitReferences(SAMXOKXXSFT services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x848F080", Offset = "0x848E480", VA = "0x18848F080")]
		public void VFASYRZLAGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x848C9E0", Offset = "0x848BDE0", VA = "0x18848C9E0", Slot = "13")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x848F0B0", Offset = "0x848E4B0", VA = "0x18848F0B0")]
		private void ZCEPYHLHZXR(BakedShapeColliderMessage a, Mesh[] b, NativeArray<EntityRemapUtility.EntityRemapInfo> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x3916620", Offset = "0x3915A20", VA = "0x183916620")]
		private DescriptorSetEnumerator<T> UEQNBYWZDSM<T>(EntityDataArrays<T> a, NativeArray<EntityRemapUtility.EntityRemapInfo> b) where T : struct
		{
			return default(DescriptorSetEnumerator<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x848B830", Offset = "0x848AC30", VA = "0x18848B830")]
		private void ATWCXVGKETK(Transform a, NativeArray<SphereDescriptor> b, PATPBQUPMIT<GameObject> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x848EC10", Offset = "0x848E010", VA = "0x18848EC10")]
		private void VDUMNSITHNC(Transform a, NativeArray<BoxDescriptor> b, PATPBQUPMIT<GameObject> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x848C630", Offset = "0x848BA30", VA = "0x18848C630")]
		private void NYVUIKAJXTY(Transform a, NativeArray<CapsuleDescriptor> b, PATPBQUPMIT<GameObject> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x848E800", Offset = "0x848DC00", VA = "0x18848E800")]
		private void TSRHMWEKFEY(Transform a, NativeArray<MeshDescriptor> b, Mesh[] c, PATPBQUPMIT<GameObject> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x848C180", Offset = "0x848B580", VA = "0x18848C180")]
		private static void DYMQOMJUVWV(NativeParallelHashSet<Entity> a, NativeParallelHashSet<Entity> b, NativeArray<EntityRemapUtility.EntityRemapInfo> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x848C4A0", Offset = "0x848B8A0", VA = "0x18848C4A0")]
		private static void IKLEHLGMWMB(NativeList<Entity> a, NativeArray<EntityRemapUtility.EntityRemapInfo> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x848D7A0", Offset = "0x848CBA0", VA = "0x18848D7A0")]
		private NativeParallelHashMap<Entity, RenderRootHandleData> PRTFCWZWVAF(AKJUGDYNWZL.SplineMessageQueueScope a, MessageQueueScope<BakedPrimitiveMessage> b, List<GameObject> c)
		{
			return default(NativeParallelHashMap<Entity, RenderRootHandleData>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x848C390", Offset = "0x848B790", VA = "0x18848C390")]
		private NativeArray<EntityRemapUtility.EntityRemapInfo> HQFGRIVRCMC(Entity a)
		{
			return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x848BB90", Offset = "0x848AF90", VA = "0x18848BB90")]
		private void CIQFULAHGZR(NativeList<Entity> a, NativeList<Entity> b, NativeParallelHashMap<Entity, RenderRootHandleData> c, NativeList<RecRoom.Foundation.Collections.Range> d, NativeList<CurvePointData> e, NativeList<BakedSplineData> f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x848E360", Offset = "0x848D760", VA = "0x18848E360")]
		private void RQQYIRHFGVF(NativeList<Entity> a, NativeList<Entity> b, NativeParallelHashMap<Entity, RenderRootHandleData> c, NativeList<BakedPrimitiveData> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x2DBCE90", Offset = "0x2DBC290", VA = "0x182DBCE90")]
		[UnityEngine.Scripting.Preserve]
		public PostLoadCreateBakedShapesWrappersSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public abstract class ZEIDTILHGOH : JYLMVZHIIJR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public readonly UniformTRS XCJTFIKWBRO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private readonly RRObject ORUDLVOERZA;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		private GameObject YEGLUTYJMPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0xAA4920", Offset = "0xAA3D20", VA = "0x180AA4920", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public UniformTRS WBQALHZJLPA
		{
			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x8499510", Offset = "0x8498910", VA = "0x188499510", Slot = "8")]
			get
			{
				return default(UniformTRS);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		private Vector3 LRZJUJQQOHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0x8499630", Offset = "0x8498A30", VA = "0x188499630", Slot = "10")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		private Matrix4x4 WPXBPEQTGBT
		{
			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x84995F0", Offset = "0x84989F0", VA = "0x1884995F0", Slot = "9")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		private Vector3 JHQWIGSIDMR
		{
			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x8499410", Offset = "0x8498810", VA = "0x188499410", Slot = "4")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x84993D0", Offset = "0x84987D0", VA = "0x1884993D0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		private Quaternion KZOBLRVTHQU
		{
			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x8499350", Offset = "0x8498750", VA = "0x188499350", Slot = "6")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x8499450", Offset = "0x8498850", VA = "0x188499450", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		private Vector3 BMKTIBBAUTY
		{
			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x8499490", Offset = "0x8498890", VA = "0x188499490", Slot = "11")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		private Vector3 THRPIXEUVWX
		{
			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x84994D0", Offset = "0x84988D0", VA = "0x1884994D0", Slot = "13")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		private Vector3 SGQVPDPDBCH
		{
			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x8499390", Offset = "0x8498790", VA = "0x188499390", Slot = "14")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x8499670", Offset = "0x8498A70", VA = "0x188499670")]
		public ZEIDTILHGOH(UniformTRS a, RRObject b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public abstract class LQLZJCXQYHL : ZEIDTILHGOH, WFQTCQGVRCW, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private readonly float LRQMPFLLMYJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private readonly float3 FPFHSGIETGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private readonly ShapeColor OBQWHMLIZIW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private readonly ShapeMaterial ZQXHFFSOHEO;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		private RRTransform XZWYADFZUKT
		{
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x84981E0", Offset = "0x84975E0", VA = "0x1884981E0", Slot = "17")]
			get
			{
				return default(RRTransform);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		private UniformTRS LJMTVXNKOKZ
		{
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x8498220", Offset = "0x8497620", VA = "0x188498220", Slot = "18")]
			get
			{
				return default(UniformTRS);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		private float BKTQCZFTNXC
		{
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0xB781E0", Offset = "0xB775E0", VA = "0x180B781E0", Slot = "19")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		private Vector3 JOVIEBIOLKR
		{
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x8498190", Offset = "0x8497590", VA = "0x188498190", Slot = "20")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		private ShapeColor FXJNHVKIRZP
		{
			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0xCDFFD0", Offset = "0xCDF3D0", VA = "0x180CDFFD0", Slot = "21")]
			get
			{
				return default(ShapeColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		private ShapeMaterial ICTNGFWYERF
		{
			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x11F0980", Offset = "0x11EFD80", VA = "0x1811F0980", Slot = "22")]
			get
			{
				return default(ShapeMaterial);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		private bool BITDRWFYWYY
		{
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0xAED770", Offset = "0xAECB70", VA = "0x180AED770", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool LFJFHELAXEC
		{
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0xAED770", Offset = "0xAECB70", VA = "0x180AED770", Slot = "15")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910")]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x8498300", Offset = "0x8497700", VA = "0x188498300")]
		protected LQLZJCXQYHL(UniformTRS a, RRObject b, float c, float3 d, ShapeColor e, ShapeMaterial f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(Slot = "25")]
		public abstract UnityEngine.Hash128 ComputeHash();

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(Slot = "26")]
		public abstract void Dispose();
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public abstract class JMODSBNSABQ : JYLMVZHIIJR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		protected readonly ObjectLocalId CPECBVXQPYM;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		protected RRObject ADSRXIMGFER
		{
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x103AAC0", Offset = "0x1039EC0", VA = "0x18103AAC0")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		protected Entity FFSULPYVRFP
		{
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x8497F10", Offset = "0x8497310", VA = "0x188497F10")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		protected LNGQTCAXYFX AATZZAXDLVU
		{
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x8497690", Offset = "0x8496A90", VA = "0x188497690")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		protected GOMKIGGGEKL IAFKJHOAUDG
		{
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x8497520", Offset = "0x8496920", VA = "0x188497520")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		protected GFLRQANDFVQ GKRWRCUWZGP
		{
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x84976A0", Offset = "0x8496AA0", VA = "0x1884976A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		private GameObject YEGLUTYJMPB
		{
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x8497A60", Offset = "0x8496E60", VA = "0x188497A60", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public UniformTRS WBQALHZJLPA
		{
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x1055200", Offset = "0x1054600", VA = "0x181055200", Slot = "8")]
			get
			{
				return default(UniformTRS);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		private Vector3 LRZJUJQQOHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x8497E20", Offset = "0x8497220", VA = "0x188497E20", Slot = "10")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		private Matrix4x4 WPXBPEQTGBT
		{
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x8497CB0", Offset = "0x84970B0", VA = "0x188497CB0", Slot = "9")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		private Vector3 JHQWIGSIDMR
		{
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x8497730", Offset = "0x8496B30", VA = "0x188497730", Slot = "4")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x8497580", Offset = "0x8496980", VA = "0x188497580", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		private Quaternion KZOBLRVTHQU
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x84971E0", Offset = "0x84965E0", VA = "0x1884971E0", Slot = "6")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x8497860", Offset = "0x8496C60", VA = "0x188497860", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		private Vector3 BMKTIBBAUTY
		{
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x8497970", Offset = "0x8496D70", VA = "0x188497970", Slot = "11")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		private Vector3 THRPIXEUVWX
		{
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x8497A90", Offset = "0x8496E90", VA = "0x188497A90", Slot = "13")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		private Vector3 SGQVPDPDBCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x8497300", Offset = "0x8496700", VA = "0x188497300", Slot = "14")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0xC91140", Offset = "0xC90540", VA = "0x180C91140")]
		protected JMODSBNSABQ(ObjectLocalId a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x8496D10", Offset = "0x8496110", VA = "0x188496D10")]
		public static implicit operator RRTransform(JMODSBNSABQ t)
		{
			return default(RRTransform);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public static class CXDQOJFOZVT
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x8496F80", Offset = "0x8496380", VA = "0x188496F80")]
		public static void QYIWLUNPBNM(NativeArray<Entity> a, EntityManager b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public static class MBGSTWCUXVK
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x84989B0", Offset = "0x8497DB0", VA = "0x1884989B0")]
		public static void XWHXMIMSGVI(NativeArray<Entity> a, EntityManager b, PDKFUQTKNFO c, LNGQTCAXYFX d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x84983B0", Offset = "0x84977B0", VA = "0x1884983B0")]
		public static void QLWUNLONSUT(NativeArray<Entity> a, EntityManager b, PDKFUQTKNFO c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x84986D0", Offset = "0x8497AD0", VA = "0x1884986D0")]
		public static NativeList<Entity> XJHFEXMABPG(NativeArray<Entity> a, EntityManager b)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x8498380", Offset = "0x8497780", VA = "0x188498380")]
		public static NativeList<Entity> QJXGGGRTMSZ(NativeArray<Entity> a, EntityManager b)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x8498700", Offset = "0x8497B00", VA = "0x188498700")]
		private static NativeList<Entity> XJHFEXMABPG(NativeArray<Entity> a, EntityManager b, bool c)
		{
			return default(NativeList<Entity>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public abstract class CTGVHNSLJPU : JMODSBNSABQ, WFQTCQGVRCW, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private float LRQMPFLLMYJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private Vector3 FPFHSGIETGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private ShapeColor OBQWHMLIZIW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private ShapeMaterial ZQXHFFSOHEO;

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		protected EntityManager CCPMMFHJJYI
		{
			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x8496BC0", Offset = "0x8495FC0", VA = "0x188496BC0")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		protected LGFWOCXQZYC WPFNJXTJEAK
		{
			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x8496960", Offset = "0x8495D60", VA = "0x188496960")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		protected ShapeConfigData DZVVYBJSBFT
		{
			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x84969F0", Offset = "0x8495DF0", VA = "0x1884969F0")]
			get
			{
				return default(ShapeConfigData);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		private RRTransform XZWYADFZUKT
		{
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x8496D10", Offset = "0x8496110", VA = "0x188496D10", Slot = "17")]
			get
			{
				return default(RRTransform);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		private float BKTQCZFTNXC
		{
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0xB05AA0", Offset = "0xB04EA0", VA = "0x180B05AA0", Slot = "19")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		private Vector3 JOVIEBIOLKR
		{
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x1146270", Offset = "0x1145670", VA = "0x181146270", Slot = "20")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		private ShapeColor FXJNHVKIRZP
		{
			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1A0", Offset = "0xAAA5A0", VA = "0x180AAB1A0", Slot = "21")]
			get
			{
				return default(ShapeColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		private ShapeMaterial ICTNGFWYERF
		{
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0xC4E8F0", Offset = "0xC4DCF0", VA = "0x180C4E8F0", Slot = "22")]
			get
			{
				return default(ShapeMaterial);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		private UniformTRS LJMTVXNKOKZ
		{
			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x1055200", Offset = "0x1054600", VA = "0x181055200", Slot = "18")]
			get
			{
				return default(UniformTRS);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public bool LFJFHELAXEC
		{
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0xAF9F90", Offset = "0xAF9390", VA = "0x180AF9F90", Slot = "15")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0xAF9170", Offset = "0xAF8570", VA = "0x180AF9170")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		private bool BITDRWFYWYY
		{
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0xAED770", Offset = "0xAECB70", VA = "0x180AED770", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x8496F40", Offset = "0x8496340", VA = "0x188496F40")]
		protected CTGVHNSLJPU(ObjectLocalId a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "25")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x8496D40", Offset = "0x8496140", VA = "0x188496D40", Slot = "26")]
		public virtual void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(Slot = "27")]
		public abstract UnityEngine.Hash128 ComputeHash();
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[SystemEnabledLifetime(Lifetime.LoadInstance)]
	public abstract class TMKBBNALKNG : NOHBMPGHBDW, UFLUIPVILQU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		protected LNGQTCAXYFX KXOASIDQTQO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private OHDUGSVEQRB AWBSSZSCGNB;

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		protected PDKFUQTKNFO VYOUMBVVRLB
		{
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x8498F50", Offset = "0x8498350", VA = "0x188498F50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		protected IHTOZJMDENQ VZPWNSLVLBP
		{
			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x8498DD0", Offset = "0x84981D0", VA = "0x188498DD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		protected bool NCNFLZTOAJY
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x8498E90", Offset = "0x8498290", VA = "0x188498E90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x8498E20", Offset = "0x8498220", VA = "0x188498E20", Slot = "15")]
		public virtual void InitReferences(SAMXOKXXSFT services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x2B1A950", Offset = "0x2B19D50", VA = "0x182B1A950")]
		[UnityEngine.Scripting.Preserve]
		protected TMKBBNALKNG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public static class KAWXPOSZCCB
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x8497F30", Offset = "0x8497330", VA = "0x188497F30")]
		public static void VHUEOWBQLJL(NativeArray<Entity> a, EntityManager b)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__3360862398
{
	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x84996D0", Offset = "0x8498AD0", VA = "0x1884996D0")]
	public static void ZKRXGWNKWSY()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x84996C0", Offset = "0x8498AC0", VA = "0x1884996C0")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	public static void EarlyInit()
	{
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
