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
		[Cpp2IlInjected.Address(RVA = "0xAC98A0", Offset = "0xAC80A0", VA = "0x180AC98A0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAC98A0", Offset = "0xAC80A0", VA = "0x180AC98A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8431750", Offset = "0x842FF50", VA = "0x188431750", Slot = "4")]
		public override void JIBLBJTHOBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xAC98A0", Offset = "0xAC80A0", VA = "0x180AC98A0")]
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
		private int[] TVXWIVSLKTH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private ServiceBitset EJWMBZOWMVA;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xAA15F0", Offset = "0xA9FDF0", VA = "0x180AA15F0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x83EA140", Offset = "0x83E8940", VA = "0x1883EA140", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x84426D0", Offset = "0x8440ED0", VA = "0x1884426D0")]
		private void ANRTHLCVEKO(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8442C30", Offset = "0x8441430", VA = "0x188442C30", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8442C90", Offset = "0x8441490", VA = "0x188442C90")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class YSXTQEFRJSG
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8440B40", Offset = "0x843F340", VA = "0x188440B40")]
		public static Quaternion KUSOYILMOHZ([In] this RRObjectSplinePoint splinePoint, [In] Vector3 direction)
		{
			return default(Quaternion);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class XYGCJQKKCEZ
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x843FF00", Offset = "0x843E700", VA = "0x18843FF00")]
		public static bool WWOGEWKQVJV(this RRObjectShapeSpline a, ShapeConfigFlags b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x843FED0", Offset = "0x843E6D0", VA = "0x18843FED0")]
		public static bool WCQIUXIJZPV(this RRObjectShapeSpline a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x843FF40", Offset = "0x843E740", VA = "0x18843FF40")]
		public static bool XCKXJXVNSEC(this RRObjectShapeSpline a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x843EEE0", Offset = "0x843D6E0", VA = "0x18843EEE0")]
		public static void BYCGTMRAOTD(this RRObjectShapeSpline a, Vector3 b, Quaternion c, float d, bool e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x843FF70", Offset = "0x843E770", VA = "0x18843FF70")]
		public static void YQIVWPQUZFX(this RRObjectShapeSpline a, Vector3 b, Quaternion c, float d, int e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x843EDC0", Offset = "0x843D5C0", VA = "0x18843EDC0")]
		public static void AREYZTWRTAZ(this RRObjectShapeSpline a, int b, Vector3 c, Quaternion d, float e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x843F7E0", Offset = "0x843DFE0", VA = "0x18843F7E0")]
		public static void JJACJVJENXC(this RRObjectShapeSpline a, Vector3 b, Quaternion c, float d, bool e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x84401F0", Offset = "0x843E9F0", VA = "0x1884401F0")]
		private static void YTVZICHZSBT(this RRObjectShapeSpline a, Vector3 b, Quaternion c, float d, bool e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x843FD20", Offset = "0x843E520", VA = "0x18843FD20")]
		private static void TJVSTWRETCT(this RRObjectShapeSpline a, Vector3 b, Quaternion c, float d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x843F3B0", Offset = "0x843DBB0", VA = "0x18843F3B0")]
		private static void HAYQFAGRHED(this RRObjectShapeSpline a, int b, Vector3 c, Quaternion d, float e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x843F590", Offset = "0x843DD90", VA = "0x18843F590")]
		private static bool HSIJXKHTHCB(this RRObjectShapeSpline a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x843F120", Offset = "0x843D920", VA = "0x18843F120")]
		private static void GVYIEMUELRZ(this RRObjectShapeSpline a, int b, Vector3 c, Quaternion d, float e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x843F830", Offset = "0x843E030", VA = "0x18843F830")]
		public static Vector3 QQYLHLJXHNY(this RRObjectShapeSpline a, int b)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x843F010", Offset = "0x843D810", VA = "0x18843F010")]
		public static Quaternion CRRZGVSYWLV(this RRObjectShapeSpline a, int b)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x843F5C0", Offset = "0x843DDC0", VA = "0x18843F5C0")]
		public static Vector3 IVXVOISPMNQ(ShapeConfigFlags a, Vector3 b, Vector3? c, Vector3 d)
		{
			return default(Vector3);
		}
	}
}
namespace RecRoom.ObjectModel.RendererV1
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	internal interface KQUGUTPTICP
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void HTRRZJHDGJG(EntityQuery a, EntityManager b, HCMSPYQCTSA c, QXPDTJGGIJN d);
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	internal interface OPXXOVXSTEV
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		ComponentType WFAKYLOAGGY
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void LBKEPSAHCCU(EntityQuery a, WLURUBZSQIN b);

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void RSFWVOXZDVF(EntityQuery a, WLURUBZSQIN b);

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void YBYLVHTQPNB(WLURUBZSQIN a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	internal class RBOWKBRPQOO : KQUGUTPTICP
	{
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static readonly Log RKIUKOTABJV;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x843AFD0", Offset = "0x84397D0", VA = "0x18843AFD0", Slot = "4")]
		public void HTRRZJHDGJG(EntityQuery a, EntityManager b, HCMSPYQCTSA c, QXPDTJGGIJN d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		public RBOWKBRPQOO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	internal class UNGUWQAPFFM : KQUGUTPTICP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly SelectionEffectType UOHMRQOLGKS;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xAAC620", Offset = "0xAAAE20", VA = "0x180AAC620")]
		public UNGUWQAPFFM(SelectionEffectType a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x843DFF0", Offset = "0x843C7F0", VA = "0x18843DFF0", Slot = "4")]
		public void HTRRZJHDGJG(EntityQuery a, EntityManager b, HCMSPYQCTSA c, QXPDTJGGIJN d)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	internal class EEKSXTDMDGW : KQUGUTPTICP
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8429110", Offset = "0x8427910", VA = "0x188429110", Slot = "4")]
		public void HTRRZJHDGJG(EntityQuery a, EntityManager b, HCMSPYQCTSA c, QXPDTJGGIJN d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		public EEKSXTDMDGW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class HHXODSDRHTE : OPXXOVXSTEV
	{
		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public ComponentType WFAKYLOAGGY
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x842F820", Offset = "0x842E020", VA = "0x18842F820", Slot = "4")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x842F880", Offset = "0x842E080", VA = "0x18842F880", Slot = "5")]
		public void LBKEPSAHCCU(EntityQuery a, WLURUBZSQIN b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x842FB10", Offset = "0x842E310", VA = "0x18842FB10", Slot = "6")]
		public void RSFWVOXZDVF(EntityQuery a, WLURUBZSQIN b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x842FDA0", Offset = "0x842E5A0", VA = "0x18842FDA0", Slot = "7")]
		public void YBYLVHTQPNB(WLURUBZSQIN a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		public HHXODSDRHTE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class XSCLNUUFZTY : OPXXOVXSTEV
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public ComponentType WFAKYLOAGGY
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x843E7F0", Offset = "0x843CFF0", VA = "0x18843E7F0", Slot = "4")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x843E850", Offset = "0x843D050", VA = "0x18843E850", Slot = "5")]
		public void LBKEPSAHCCU(EntityQuery a, WLURUBZSQIN b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x843EAE0", Offset = "0x843D2E0", VA = "0x18843EAE0", Slot = "6")]
		public void RSFWVOXZDVF(EntityQuery a, WLURUBZSQIN b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x843ED70", Offset = "0x843D570", VA = "0x18843ED70", Slot = "7")]
		public void YBYLVHTQPNB(WLURUBZSQIN a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		public XSCLNUUFZTY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class UUGJGXTYSEG : OPXXOVXSTEV
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public ComponentType WFAKYLOAGGY
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x843E160", Offset = "0x843C960", VA = "0x18843E160", Slot = "4")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x843E1C0", Offset = "0x843C9C0", VA = "0x18843E1C0", Slot = "5")]
		public void LBKEPSAHCCU(EntityQuery a, WLURUBZSQIN b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x843E450", Offset = "0x843CC50", VA = "0x18843E450", Slot = "6")]
		public void RSFWVOXZDVF(EntityQuery a, WLURUBZSQIN b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x843E6E0", Offset = "0x843CEE0", VA = "0x18843E6E0", Slot = "7")]
		public void YBYLVHTQPNB(WLURUBZSQIN a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		public UUGJGXTYSEG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal class FGXDBUYYKBL : MQKDOERKHYD, IPQERUQWVJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private HCMSPYQCTSA FZZXZRNVKWC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private FJDFJMSRRCU GKVHXSOCUNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private QXPDTJGGIJN WVIZYBWKSMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private List<(EntityQuery query, KQUGUTPTICP adapter)> YIUYSKNDEAH;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x84293C0", Offset = "0x8427BC0", VA = "0x1884293C0", Slot = "15")]
		public virtual void InitReferences(BDQJEHGTRBM services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8429450", Offset = "0x8427C50", VA = "0x188429450", Slot = "5")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8429260", Offset = "0x8427A60", VA = "0x188429260")]
		private void FFYWADEJGXV(EntityQueryDesc a, KQUGUTPTICP b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8429640", Offset = "0x8427E40", VA = "0x188429640", Slot = "13")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x2B75B20", Offset = "0x2B74320", VA = "0x182B75B20")]
		[UnityEngine.Scripting.Preserve]
		public FGXDBUYYKBL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[SystemEnabledLifetime(Lifetime.LoadInstance)]
	internal class RenderShapeEffectsSystem : MQKDOERKHYD, IPQERUQWVJD
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		private class Effect
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public EntityQuery MZMQRGEMNHQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public EntityQuery IOGQKMHWLUK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public EntityQuery YLJLAITXFNX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public EntityQuery DQQSKXDULIX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public EntityQuery QOSKCNQDLCR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public EntityQuery EREMAEOECII;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public EntityQuery PIEHLUISJWW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public OPXXOVXSTEV WDRHJTIRZIV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public ComponentType PXGVDNFDTKU;

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			public Effect()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly Log RKIUKOTABJV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private HCMSPYQCTSA FZZXZRNVKWC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private QXPDTJGGIJN WVIZYBWKSMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private FJDFJMSRRCU GKVHXSOCUNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private List<Effect> YIUYSKNDEAH;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x843D600", Offset = "0x843BE00", VA = "0x18843D600", Slot = "14")]
		public void InitReferences(BDQJEHGTRBM services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x843D690", Offset = "0x843BE90", VA = "0x18843D690", Slot = "5")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x843D810", Offset = "0x843C010", VA = "0x18843D810", Slot = "13")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x843CA60", Offset = "0x843B260", VA = "0x18843CA60")]
		private void ECPDVRUYAZI(Effect a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x843CED0", Offset = "0x843B6D0", VA = "0x18843CED0")]
		private void FFYWADEJGXV(OPXXOVXSTEV a, ComponentType b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x2B75B20", Offset = "0x2B74320", VA = "0x182B75B20")]
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
	[RegisterService(typeof(QXPDTJGGIJN), new string[] { })]
	public class KJGGTFVVPOW : QXPDTJGGIJN
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public OutlineEffectType LXZSKRSKOIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xA9E110", Offset = "0xA9C910", VA = "0x180A9E110", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(OutlineEffectType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xAA9530", Offset = "0xAA7D30", VA = "0x180AA9530", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		public KJGGTFVVPOW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[RegisterService(typeof(UWWBYJKYBSL), new string[] { })]
	public class ZEIVDQUAHFO : UWWBYJKYBSL, GLRXGBAEILM, PFYTZJIIFSI, TNWCTSLULIM, XVYQGXFPXEO, TTDQLFCDEXA, TFZKCIODVYK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[DependsOn]
		private PHSLCENMBKR HZZKWCOZDNT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[DependsOn]
		private HCMSPYQCTSA FZZXZRNVKWC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		[DependsOn]
		private ONAYZPPBQDG NIUGJDRHITL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private EntityQuery NYPXMVTEIRO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private EntityQuery UQUJTYWVWTT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private bool EEXWHCBPFMX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private Entity SVFTZHCCNOQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private RootHandle OOOWOGCXONE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private Entity CYLIHXFIUAX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private RootHandle VUXKYIWWFSB;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private EntityManager IIRZUUTRTUH
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x84419F0", Offset = "0x84401F0", VA = "0x1884419F0")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public int OLYZTWZNFDJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x8441200", Offset = "0x843FA00", VA = "0x188441200", Slot = "7")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int NOCJXESJUKW
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x8441AC0", Offset = "0x84402C0", VA = "0x188441AC0", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x84410C0", Offset = "0x843F8C0", VA = "0x1884410C0", Slot = "4")]
		public bool EXYDORJJEDI(ObjectLocalId a, MutableRef b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x8440C60", Offset = "0x843F460", VA = "0x188440C60", Slot = "5")]
		public RootHandle DSKWHKOBPAU()
		{
			return default(RootHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8441350", Offset = "0x843FB50", VA = "0x188441350", Slot = "6")]
		public RootHandle OCMUIEHDVGL()
		{
			return default(RootHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x8441220", Offset = "0x843FA20", VA = "0x188441220", Slot = "9")]
		public void InitExternal(BDQJEHGTRBM services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x8440C20", Offset = "0x843F420", VA = "0x188440C20", Slot = "11")]
		public void BTTVCOLODYQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x8441720", Offset = "0x843FF20", VA = "0x188441720", Slot = "10")]
		public void OINRTVSEBTU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8441030", Offset = "0x843F830", VA = "0x188441030", Slot = "12")]
		private void EFSYMFFESBS(BDQJEHGTRBM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x10AFBA0", Offset = "0x10AE3A0", VA = "0x1810AFBA0", Slot = "13")]
		private void MIIBQCGEILO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		public ZEIVDQUAHFO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[RegisterService(typeof(UGLPLBZLSJU), new string[] { })]
	public class KLLKTBPNBDD : UGLPLBZLSJU
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x8431290", Offset = "0x842FA90", VA = "0x188431290", Slot = "4")]
		public void YSWBAIPNDKM(World a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8431320", Offset = "0x842FB20", VA = "0x188431320", Slot = "5")]
		public void ZICETSGXKDS(World a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x84310B0", Offset = "0x842F8B0", VA = "0x1884310B0", Slot = "6")]
		public ComponentSystemBase EQRKTESAKDZ(World a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x8431170", Offset = "0x842F970", VA = "0x188431170", Slot = "7")]
		public void HQOCEPYJBXF(World a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x8431230", Offset = "0x842FA30", VA = "0x188431230", Slot = "8")]
		public void SGYKGIDOFQG(World a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x84311D0", Offset = "0x842F9D0", VA = "0x1884311D0", Slot = "9")]
		public void ORXNCSJMZYH(World a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8431100", Offset = "0x842F900", VA = "0x188431100", Slot = "10")]
		public void GGZFKITVEVE(World a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x8430830", Offset = "0x842F030", VA = "0x188430830", Slot = "11")]
		public NativeParallelHashSet<ComponentTypeIndex> AKCPUGWXIUN()
		{
			return default(NativeParallelHashSet<ComponentTypeIndex>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		public KLLKTBPNBDD()
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
	public class RQJBPEVVVAX : IComponentData, ICloneable, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public KXLVYSPVNJF PFJAVEULQYA
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xAA1AA0", Offset = "0xAA02A0", VA = "0x180AA1AA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0xAA1620", Offset = "0xA9FE20", VA = "0x180AA1620")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x843B260", Offset = "0x8439A60", VA = "0x18843B260", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x843B1F0", Offset = "0x84399F0", VA = "0x18843B1F0", Slot = "4")]
		public object Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		[UnityEngine.Scripting.Preserve]
		public RQJBPEVVVAX()
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
		[Cpp2IlInjected.Address(RVA = "0xB431D0", Offset = "0xB419D0", VA = "0x180B431D0")]
		public static implicit operator RenderRootHandleData(RootHandle handle)
		{
			return default(RenderRootHandleData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public class MNSUBKZQWGG : ICleanupComponentData, IComponentData, ICloneable
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public SSHTJQDXJWC OSHOQBWFNDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xAA1AA0", Offset = "0xAA02A0", VA = "0x180AA1AA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xAA1620", Offset = "0xA9FE20", VA = "0x180AA1620")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8431B40", Offset = "0x8430340", VA = "0x188431B40", Slot = "4")]
		public object Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		[UnityEngine.Scripting.Preserve]
		public MNSUBKZQWGG()
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
		[Cpp2IlInjected.Address(RVA = "0xB431D0", Offset = "0xB419D0", VA = "0x180B431D0")]
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
		[Cpp2IlInjected.Address(RVA = "0xB431D0", Offset = "0xB419D0", VA = "0x180B431D0")]
		public static implicit operator ShapeRootHandleData(RootHandle handle)
		{
			return default(ShapeRootHandleData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class VVNPZIZMJVX : IComponentData, ICloneable, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public SKIPEFDZDRT OWRPDDNAQYS
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0xAA1AA0", Offset = "0xAA02A0", VA = "0x180AA1AA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0xAA1620", Offset = "0xA9FE20", VA = "0x180AA1620")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x843E7A0", Offset = "0x843CFA0", VA = "0x18843E7A0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x843E730", Offset = "0x843CF30", VA = "0x18843E730", Slot = "4")]
		public object Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		[UnityEngine.Scripting.Preserve]
		public VVNPZIZMJVX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public class GRUNPQLGHRU : QEQVPVQZQDY, KXLVYSPVNJF, HNZMDQFISIL, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public PrimitiveShapeMeshType THTZDEUVDAU
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xBDFD20", Offset = "0xBDE520", VA = "0x180BDFD20", Slot = "27")]
			[CompilerGenerated]
			get
			{
				return default(PrimitiveShapeMeshType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool PPBBWTUXFMS
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x1342630", Offset = "0x1340E30", VA = "0x181342630", Slot = "28")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public float3 EXPVVQNCITE
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0xFE38B0", Offset = "0xFE20B0", VA = "0x180FE38B0", Slot = "29")]
			[CompilerGenerated]
			get
			{
				return default(float3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x842AA50", Offset = "0x8429250", VA = "0x18842AA50")]
		public GRUNPQLGHRU(UniformTRS a, RRObject b, float c, float3 d, ShapeColor e, ShapeMaterial f, PrimitiveShapeMeshType g, float3 h, bool i)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x842A9F0", Offset = "0x84291F0", VA = "0x18842A9F0", Slot = "25")]
		public override UnityEngine.Hash128 ComputeHash()
		{
			return default(UnityEngine.Hash128);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "26")]
		public override void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class IYEHRCBLWVU : QEQVPVQZQDY, SKIPEFDZDRT, HNZMDQFISIL, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private NativeArray<CurvePointData> IPDDPUBOZRH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private readonly SplineParameterFlags NJCFNERVUGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private readonly float UQJWOTHQFUQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private readonly int UPXTSSTADIA;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool SPORLWOAUNN
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x842FF60", Offset = "0x842E760", VA = "0x18842FF60", Slot = "27")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool EFEPVFYBIZZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x842FF80", Offset = "0x842E780", VA = "0x18842FF80", Slot = "28")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool PHVSKUBHCUE
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x842FF70", Offset = "0x842E770", VA = "0x18842FF70", Slot = "31")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public int EVNRWQYFUGX
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xC21B60", Offset = "0xC20360", VA = "0x180C21B60", Slot = "32")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public float NWJKVLZDJIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xB39D90", Offset = "0xB38590", VA = "0x180B39D90", Slot = "29")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public int KGDUHTNMJHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xB61D30", Offset = "0xB60530", VA = "0x180B61D30", Slot = "30")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x842FEC0", Offset = "0x842E6C0", VA = "0x18842FEC0")]
		public IYEHRCBLWVU(UniformTRS a, RRObject b, float c, float3 d, ShapeColor e, ShapeMaterial f, SplineParameterFlags g, float h, int i, NativeArray<CurvePointData> j)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xC6A690", Offset = "0xC68E90", VA = "0x180C6A690", Slot = "33")]
		public NativeArray<CurvePointData> GetNativeCurvePoints()
		{
			return default(NativeArray<CurvePointData>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x842FDF0", Offset = "0x842E5F0", VA = "0x18842FDF0", Slot = "25")]
		public override UnityEngine.Hash128 ComputeHash()
		{
			return default(UnityEngine.Hash128);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "26")]
		public override void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class PrimitiveWrapper : SRXRINAIIBB, KXLVYSPVNJF, HNZMDQFISIL, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static readonly Log RKIUKOTABJV;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private static readonly Dictionary<PrimitiveShapeType, PrimitiveShapeMeshType> HGNFNULNQIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private PrimitiveShapeMeshType ZQCPHJTZZEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private bool IBZWNLORZVI;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private PrimitiveShapeMeshType OPHJFJDIURH
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xACF250", Offset = "0xACDA50", VA = "0x180ACF250", Slot = "28")]
			get
			{
				return default(PrimitiveShapeMeshType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private bool MSZRKFQNQCX
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xC20850", Offset = "0xC1F050", VA = "0x180C20850", Slot = "29")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public float3 EXPVVQNCITE
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x843AB90", Offset = "0x8439390", VA = "0x18843AB90", Slot = "30")]
			get
			{
				return default(float3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x843AB70", Offset = "0x8439370", VA = "0x18843AB70")]
		public PrimitiveWrapper(ObjectLocalId objectLocalId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x843A460", Offset = "0x8438C60", VA = "0x18843A460", Slot = "27")]
		public override UnityEngine.Hash128 ComputeHash()
		{
			return default(UnityEngine.Hash128);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x843A4B0", Offset = "0x8438CB0", VA = "0x18843A4B0", Slot = "26")]
		public override void Update()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class ZFXVOUVPPXA : JXUTGYSCVMT, SSHTJQDXJWC, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private GameObject BKAZXUIYUGV;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public GameObject GQVQNJZVHPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x8441DA0", Offset = "0x84405A0", VA = "0x188441DA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public RRTransform YTQQQFYHIEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x8441CA0", Offset = "0x84404A0", VA = "0x188441CA0", Slot = "15")]
			get
			{
				return default(RRTransform);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public RootFlags LDOYOYNQFTI
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x84420C0", Offset = "0x84408C0", VA = "0x1884420C0", Slot = "16")]
			get
			{
				return default(RootFlags);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x8441F80", Offset = "0x8440780", VA = "0x188441F80")]
		public ZFXVOUVPPXA(ObjectLocalId a, bool b = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x8441B10", Offset = "0x8440310", VA = "0x188441B10")]
		public void EXWLVURKEGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x8441CA0", Offset = "0x84404A0", VA = "0x188441CA0")]
		protected RRTransform QTGQHTXHILN()
		{
			return default(RRTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8441E30", Offset = "0x8440630", VA = "0x188441E30")]
		private static bool YZSKGOAMKDO(ObjectLocalId a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8441AE0", Offset = "0x84402E0", VA = "0x188441AE0", Slot = "18")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class JSZSIWUHVGF : SRXRINAIIBB, SKIPEFDZDRT, HNZMDQFISIL, IDisposable, ZJPAUBPLCZE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private NativeList<CurvePointData> IPDDPUBOZRH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private bool AGCDKPRHZZZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private bool MSBVNVAGSZJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private float UQJWOTHQFUQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private int UPXTSSTADIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private bool SBYPPUYISWY;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private bool DBOUSKSZKTQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0xC9C340", Offset = "0xC9AB40", VA = "0x180C9C340", Slot = "28")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		private bool RJXYSYDELZE
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x12DAE10", Offset = "0x12D9610", VA = "0x1812DAE10", Slot = "29")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private float OLJJHGZWUWD
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xAF0590", Offset = "0xAEED90", VA = "0x180AF0590", Slot = "30")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private int ZCTNOGAUVXH
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0xD11100", Offset = "0xD0F900", VA = "0x180D11100", Slot = "31")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		private bool HGUZIEQDMXH
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0xDE1860", Offset = "0xDE0060", VA = "0x180DE1860", Slot = "32")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private int XXWUQTTIFQQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x842FF90", Offset = "0x842E790", VA = "0x18842FF90", Slot = "33")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		private int MMESMRCUJAX
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x8430710", Offset = "0x842EF10", VA = "0x188430710", Slot = "38")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x8430800", Offset = "0x842F000", VA = "0x188430800")]
		public JSZSIWUHVGF(ObjectLocalId a, [Optional] NativeList<CurvePointData> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8430640", Offset = "0x842EE40", VA = "0x188430640", Slot = "26")]
		public override void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x842FFB0", Offset = "0x842E7B0", VA = "0x18842FFB0", Slot = "27")]
		public override UnityEngine.Hash128 ComputeHash()
		{
			return default(UnityEngine.Hash128);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x84300A0", Offset = "0x842E8A0", VA = "0x1884300A0", Slot = "25")]
		public override void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x84303C0", Offset = "0x842EBC0", VA = "0x1884303C0")]
		public void NRHNAFRDKVE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8430100", Offset = "0x842E900", VA = "0x188430100", Slot = "34")]
		public NativeArray<CurvePointData> GetNativeCurvePoints()
		{
			return default(NativeArray<CurvePointData>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x84302A0", Offset = "0x842EAA0", VA = "0x1884302A0", Slot = "35")]
		private Vector3 HJLMGCJHFRW(int a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x8430420", Offset = "0x842EC20", VA = "0x188430420", Slot = "36")]
		private Quaternion PCQHQXTUCPT(int a)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x8430450", Offset = "0x842EC50", VA = "0x188430450", Slot = "37")]
		private float SMLDVCTLUEN(int a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x84305D0", Offset = "0x842EDD0", VA = "0x1884305D0")]
		private NativeArray<Entity> TPLYQGJYLSF()
		{
			return default(NativeArray<Entity>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[SystemEnabledLifetime(Lifetime.LoadInstance)]
	internal sealed class ZKKIQRGXIWV : KIIPKSUDHAI
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x8442230", Offset = "0x8440A30", VA = "0x188442230", Slot = "15")]
		protected override ComponentSystemBase VXVCIIORMOX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x8442220", Offset = "0x8440A20", VA = "0x188442220", Slot = "13")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x84426C0", Offset = "0x8440EC0", VA = "0x1884426C0")]
		[UnityEngine.Scripting.Preserve]
		public ZKKIQRGXIWV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[DebugAlwaysUpdateSystem]
	public sealed class AddRemoveRenderRootSystem : MHJPKHMAAFN
	{
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private static readonly Log RKIUKOTABJV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private EntityQuery CCHHUTAVJEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private EntityQuery VRVDYDSTMOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private EntityQuery UOYQYXHUDCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private EntityQuery LLOZOERWKGV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private EntityQuery TJSDSYGQCDV;

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x8422380", Offset = "0x8420B80", VA = "0x188422380", Slot = "5")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x84226B0", Offset = "0x8420EB0", VA = "0x1884226B0", Slot = "13")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x8421E10", Offset = "0x8420610", VA = "0x188421E10")]
		private void IBJTFGYARGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x84226F0", Offset = "0x8420EF0", VA = "0x1884226F0")]
		private void QJJWJQSZCDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x8422190", Offset = "0x8420990", VA = "0x188422190")]
		private void OESYCNNMWVU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x8422820", Offset = "0x8421020", VA = "0x188422820")]
		private void RPWHVVWUIRE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x8422060", Offset = "0x8420860", VA = "0x188422060")]
		private void MKZXQAUAYQQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x8421DC0", Offset = "0x84205C0", VA = "0x188421DC0")]
		private NativeList<Entity> APCFSRRFPNC(NativeArray<Entity> a)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x8422010", Offset = "0x8420810", VA = "0x188422010")]
		private NativeList<Entity> IHAGEESEBVD(NativeArray<Entity> a)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x8422950", Offset = "0x8421150", VA = "0x188422950")]
		private void UNHYYJWCRKM(NativeArray<Entity> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x2E24A40", Offset = "0x2E23240", VA = "0x182E24A40")]
		[UnityEngine.Scripting.Preserve]
		public AddRemoveRenderRootSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[DebugAlwaysUpdateSystem]
	[CompilerGenerated]
	public sealed class AddRemoveShapeRenderersSystem : MHJPKHMAAFN, IPQERUQWVJD
	{
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private static readonly Log RKIUKOTABJV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private EntityQuery QKIHBCJZNRG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private EntityQuery CSKNSOJQJSI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private EntityQuery YLJLAITXFNX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private UWWBYJKYBSL YHCDIICHEQI;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x8423E70", Offset = "0x8422670", VA = "0x188423E70", Slot = "5")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x8423510", Offset = "0x8421D10", VA = "0x188423510", Slot = "15")]
		public override void InitReferences(BDQJEHGTRBM services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x8424020", Offset = "0x8422820", VA = "0x188424020", Slot = "13")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x8424040", Offset = "0x8422840", VA = "0x188424040")]
		private void SRELDIOHOEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x8423570", Offset = "0x8421D70", VA = "0x188423570")]
		private void MFFRRVFTHLG(NativeParallelHashSet<RootHandle> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x8422E50", Offset = "0x8421650", VA = "0x188422E50")]
		private void BRQHBQYKXHS(NativeParallelHashSet<RootHandle> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x8422A40", Offset = "0x8421240", VA = "0x188422A40")]
		private void BFUUJILXQZP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x8424410", Offset = "0x8422C10", VA = "0x188424410")]
		private bool TBLOPPZPFSD(Entity a, [Out] RootHandle b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x8423C30", Offset = "0x8422430", VA = "0x188423C30")]
		internal bool ORNLZSZKJSN(Entity a, [Out] RootHandle b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x2E24A40", Offset = "0x2E23240", VA = "0x182E24A40")]
		[UnityEngine.Scripting.Preserve]
		public AddRemoveShapeRenderersSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[DebugAlwaysUpdateSystem]
	public sealed class AddShapeWrapperSystem : MHJPKHMAAFN
	{
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private static readonly Log RKIUKOTABJV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private EntityQuery TZJBQNEIYTL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private EntityQuery LVGPOEFXVDL;

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x8424BA0", Offset = "0x84233A0", VA = "0x188424BA0", Slot = "5")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x8424CD0", Offset = "0x84234D0", VA = "0x188424CD0", Slot = "13")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x8424870", Offset = "0x8423070", VA = "0x188424870")]
		private void MFFRRVFTHLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x8424540", Offset = "0x8422D40", VA = "0x188424540")]
		private void BRQHBQYKXHS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x2E24A40", Offset = "0x2E23240", VA = "0x182E24A40")]
		[UnityEngine.Scripting.Preserve]
		public AddShapeWrapperSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	public class ApplyShapeModificationsToShapesAndRenderRootsSystem : MHJPKHMAAFN, IPQERUQWVJD
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
			[Cpp2IlInjected.Address(RVA = "0x8428FC0", Offset = "0x84277C0", VA = "0x188428FC0", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x8429020", Offset = "0x8427820", VA = "0x188429020")]
			private void SOJQMYDFFVI(EntityQueryInJob a, NativeList<Entity> b)
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
			[Cpp2IlInjected.Address(RVA = "0x8428AE0", Offset = "0x84272E0", VA = "0x188428AE0")]
			public void CURJQMNILPU([In] ArchetypeChunk chunk, int a, bool b, [In] v128 chunkEnabledMask)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x8428CB0", Offset = "0x84274B0", VA = "0x188428CB0", Slot = "4")]
			private void ZFCVRLDNVOO([In] ArchetypeChunk chunk, int a, bool b, [In] v128 chunkEnabledMask)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private static readonly Log RKIUKOTABJV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private EntityQuery BBIVUSLHEYK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private EntityQuery KYXXBBDBZDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private EntityQuery QQDLHTMBWRG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private EntityQuery SEQDXXWCDWG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private EntityQuery SMOATEIQBXB;

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x8424E70", Offset = "0x8423670", VA = "0x188424E70", Slot = "5")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x8425280", Offset = "0x8423A80", VA = "0x188425280", Slot = "13")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x8424D70", Offset = "0x8423570", VA = "0x188424D70")]
		private void EUMDYHKOBYR(NativeParallelHashSet<RootHandle> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x8425640", Offset = "0x8423E40", VA = "0x188425640")]
		private void SPSSMFHVLJX(NativeParallelHashSet<RootHandle> a, int b, int c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x2E24A40", Offset = "0x2E23240", VA = "0x182E24A40")]
		[UnityEngine.Scripting.Preserve]
		public ApplyShapeModificationsToShapesAndRenderRootsSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	public class ApplyShapeMoveBetweenBatchedMeshesSystem : MHJPKHMAAFN
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
			[Cpp2IlInjected.Address(RVA = "0x8428CC0", Offset = "0x84274C0", VA = "0x188428CC0")]
			public void CURJQMNILPU([In] ArchetypeChunk chunk, int a, bool b, [In] v128 chunkEnabledMask)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x8428FB0", Offset = "0x84277B0", VA = "0x188428FB0", Slot = "4")]
			private void ORSYPSKQCKV([In] ArchetypeChunk chunk, int a, bool b, [In] v128 chunkEnabledMask)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private static readonly Log RKIUKOTABJV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private EntityQuery XALWNGXBJHS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private EntityQuery YDGDNHOGMYE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private EntityQuery JTUTTPPBXOS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private EntityQuery XRFPBVFKOCS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private EntityQuery EEERUBXZLRN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private UWWBYJKYBSL SNUHWLPZTHS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private AddRemoveShapeRenderersSystem WLDTCEJDJSI;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x8426900", Offset = "0x8425100", VA = "0x188426900", Slot = "5")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x84268A0", Offset = "0x84250A0", VA = "0x1884268A0", Slot = "15")]
		public override void InitReferences(BDQJEHGTRBM services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x8426CC0", Offset = "0x84254C0", VA = "0x188426CC0", Slot = "13")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x84270D0", Offset = "0x84258D0", VA = "0x1884270D0")]
		private void QDVZPKVJPYM(NativeParallelHashSet<RootHandle> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x8427920", Offset = "0x8426120", VA = "0x188427920")]
		private void VFLAKBRZZJJ(NativeParallelHashSet<RootHandle> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x8425F10", Offset = "0x8424710", VA = "0x188425F10")]
		private void EEGQGBCLFOJ(NativeParallelHashSet<RootHandle> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x8425A60", Offset = "0x8424260", VA = "0x188425A60")]
		private void BOKFUVASNJJ(NativeParallelHashSet<RootHandle> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x8426380", Offset = "0x8424B80", VA = "0x188426380")]
		private void IWSQXQNMVBU(NativeParallelHashSet<RootHandle> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x8427DC0", Offset = "0x84265C0", VA = "0x188427DC0")]
		private void VRRIGHGFWKT(Entity a, ShapeHandle b, RootHandle c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x2E24A40", Offset = "0x2E23240", VA = "0x182E24A40")]
		[UnityEngine.Scripting.Preserve]
		public ApplyShapeMoveBetweenBatchedMeshesSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public sealed class AttachRenderProxyToEmbodiedContainerSystem : MHJPKHMAAFN
	{
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private static readonly Log RKIUKOTABJV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private EntityQuery LMMMAHGTVHU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private EntityQuery OFGJLYBYIEH;

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x8428030", Offset = "0x8426830", VA = "0x188428030", Slot = "5")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x8428250", Offset = "0x8426A50", VA = "0x188428250", Slot = "13")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x2E24A40", Offset = "0x2E23240", VA = "0x182E24A40")]
		[UnityEngine.Scripting.Preserve]
		public AttachRenderProxyToEmbodiedContainerSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public class QLPLRGVTGSL : MHJPKHMAAFN
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		[TypeManager.ForcedStableTypeHash(13972172025007325174uL)]
		private struct RemovedFromClusterLodTag : IComponentData
		{
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private EntityQuery IXTXVGJFAYD;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x843AC60", Offset = "0x8439460", VA = "0x18843AC60", Slot = "5")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x843AD90", Offset = "0x8439590", VA = "0x18843AD90", Slot = "13")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x2E24A40", Offset = "0x2E23240", VA = "0x182E24A40")]
		[UnityEngine.Scripting.Preserve]
		public QLPLRGVTGSL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[DebugAlwaysUpdateSystem]
	internal class RemoveShapeEffectsSystem : MHJPKHMAAFN
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		private class Effect
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public EntityQuery LIVIQNTFQRR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public EntityQuery OFIYLPJLKRC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public RemoveEffect OSATNNMJMFA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public ComponentType FUPUOKIYKKN;

			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			public Effect()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000037")]
		private delegate void RemoveEffect(NativeArray<ShapeHandle> handle, WLURUBZSQIN shapeEffectManager);

		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private static readonly Log RKIUKOTABJV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private List<Effect> YIUYSKNDEAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private FJDFJMSRRCU GKVHXSOCUNK;

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x843B8C0", Offset = "0x843A0C0", VA = "0x18843B8C0", Slot = "15")]
		public override void InitReferences(BDQJEHGTRBM services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x843BAF0", Offset = "0x843A2F0", VA = "0x18843BAF0", Slot = "5")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x843BDA0", Offset = "0x843A5A0", VA = "0x18843BDA0", Slot = "13")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x3A0BDA0", Offset = "0x3A0A5A0", VA = "0x183A0BDA0")]
		private void FFYWADEJGXV<a>(RemoveEffect a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x843C2C0", Offset = "0x843AAC0", VA = "0x18843C2C0")]
		private static void ULRSNDBIIBV(NativeArray<ShapeHandle> a, WLURUBZSQIN b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x843B920", Offset = "0x843A120", VA = "0x18843B920")]
		private static void KKOQYNJVYTR(NativeArray<ShapeHandle> a, WLURUBZSQIN b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x843B6F0", Offset = "0x8439EF0", VA = "0x18843B6F0")]
		private static void HUQECLCJKDF(NativeArray<ShapeHandle> a, WLURUBZSQIN b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x2E24A40", Offset = "0x2E23240", VA = "0x182E24A40")]
		[UnityEngine.Scripting.Preserve]
		public RemoveShapeEffectsSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[DebugAlwaysUpdateSystem]
	public sealed class RemoveShapesFromShapeRenderer : MHJPKHMAAFN
	{
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private static readonly Log RKIUKOTABJV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private EntityQuery QAQVGLXWEAR;

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x843C510", Offset = "0x843AD10", VA = "0x18843C510", Slot = "5")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x843C5D0", Offset = "0x843ADD0", VA = "0x18843C5D0", Slot = "13")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x2E24A40", Offset = "0x2E23240", VA = "0x182E24A40")]
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
		[Cpp2IlInjected.Address(RVA = "0x8428820", Offset = "0x8427020", VA = "0x188428820", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[RegisterService(typeof(FWMYYWYXLKW), new string[] { })]
	[ServiceLifetime(Lifetime.OMRoom)]
	internal class FWMYYWYXLKW : IPQERUQWVJD, XVYQGXFPXEO, TTDQLFCDEXA, TFZKCIODVYK
	{
		[Cpp2IlInjected.Token(Token = "0x200003C")]
		public readonly struct SplineMessageQueueScope : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000090")]
			private readonly FWMYYWYXLKW parent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			private readonly bool disposePointData;

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x181E680", Offset = "0x181CE80", VA = "0x18181E680")]
			public SplineMessageQueueScope(FWMYYWYXLKW parent, bool disposePointData)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x843DDB0", Offset = "0x843C5B0", VA = "0x18843DDB0")]
			public Queue<BakedSplinesMessage>.Enumerator GetEnumerator()
			{
				return default(Queue<BakedSplinesMessage>.Enumerator);
			}

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x843DB00", Offset = "0x843C300", VA = "0x18843DB00", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private static readonly Log RKIUKOTABJV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		[DependsOn]
		private ONAYZPPBQDG XHOCUIAHKIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		[DependsOn]
		private TRSIKZJHWYK DMSRCEMMMLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private List<NativeList<CurvePointData>> SZCBBLEEKAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private List<(Entity, List<GameObject>)> PAUIAXGOICQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private NativeList<ShapeHandle> GYQJXHXNIVZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private VJQDVNLRIIS<BakedSplinesMessage> AVLPATFGFBY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private VJQDVNLRIIS<BakedPrimitiveMessage> ZGCJZUHCZQU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private VJQDVNLRIIS<BakedShapeColliderMessage> HXXPYJXZHEV;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x8429D20", Offset = "0x8428520", VA = "0x188429D20", Slot = "4")]
		public void InitReferences(BDQJEHGTRBM services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x84298C0", Offset = "0x84280C0", VA = "0x1884298C0")]
		public void AEWFREJXDZG(NativeList<CurvePointData> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x842A830", Offset = "0x8429030", VA = "0x18842A830")]
		public void RZBTDUPCZZP(Entity a, [In] UQNUASLZIEC<GameObject> inColliders)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x842A7B0", Offset = "0x8428FB0", VA = "0x18842A7B0")]
		public void RSJJMCLKJXP(NativeList<ShapeHandle> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x8429F70", Offset = "0x8428770", VA = "0x188429F70")]
		public void ORXNCSJMZYH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x842A190", Offset = "0x8428990", VA = "0x18842A190")]
		public void QMLDUWQROSY(NUOTBWOORLZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x842A710", Offset = "0x8428F10", VA = "0x18842A710")]
		public JobHandle RBRFIRPKWEL([In] BakedSplinesMessage message, JobHandle a)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x842A670", Offset = "0x8428E70", VA = "0x18842A670")]
		public JobHandle RBRFIRPKWEL([In] BakedPrimitiveMessage message, JobHandle a)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x80CB330", Offset = "0x80C9B30", VA = "0x1880CB330")]
		public SplineMessageQueueScope AHFJRCKQKPU(bool a)
		{
			return default(SplineMessageQueueScope);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x8429CD0", Offset = "0x84284D0", VA = "0x188429CD0")]
		public MessageQueueScope<BakedPrimitiveMessage> ERZWEOCKAEI()
		{
			return default(MessageQueueScope<BakedPrimitiveMessage>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x8429F20", Offset = "0x8428720", VA = "0x188429F20")]
		public MessageQueueScope<BakedShapeColliderMessage> KCVJYRVRUNB()
		{
			return default(MessageQueueScope<BakedShapeColliderMessage>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x8429A40", Offset = "0x8428240", VA = "0x188429A40")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x8429960", Offset = "0x8428160", VA = "0x188429960", Slot = "5")]
		public void BTTVCOLODYQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x8429C60", Offset = "0x8428460", VA = "0x188429C60", Slot = "6")]
		private void EFSYMFFESBS(BDQJEHGTRBM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0xD48920", Offset = "0xD47120", VA = "0x180D48920", Slot = "7")]
		private void MIIBQCGEILO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		public FWMYYWYXLKW()
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
		[Cpp2IlInjected.Address(RVA = "0x84288B0", Offset = "0x84270B0", VA = "0x1884288B0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x84288C0", Offset = "0x84270C0", VA = "0x1884288C0")]
		public void Dispose(bool disposePointData)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[RegisterService(typeof(NXDAQCVKUYD), new string[] { })]
	[ServiceLifetime(Lifetime.LoadInstance)]
	internal class NXDAQCVKUYD : EEYQRLXJBSJ, TTDQLFCDEXA, TFZKCIODVYK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		[DependsOn]
		private FWMYYWYXLKW BPFYALYTPVI;

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x8431C00", Offset = "0x8430400", VA = "0x188431C00", Slot = "4")]
		public void ShutdownReferences()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x8431BB0", Offset = "0x84303B0", VA = "0x188431BB0", Slot = "5")]
		private void EFSYMFFESBS(BDQJEHGTRBM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0xC990B0", Offset = "0xC978B0", VA = "0x180C990B0", Slot = "6")]
		private void MIIBQCGEILO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		public NXDAQCVKUYD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[SystemEnabledLifetime(Lifetime.OMRoom)]
	[CompilerGenerated]
	public class PostDeserializeBakeShapesSystem : MHJPKHMAAFN, IPQERUQWVJD
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
			[Cpp2IlInjected.Address(RVA = "0x842AB60", Offset = "0x8429360", VA = "0x18842AB60")]
			public void CURJQMNILPU([In] ArchetypeChunk chunk, int a, bool b, [In] v128 chunkEnabledMask)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x842AEE0", Offset = "0x84296E0", VA = "0x18842AEE0", Slot = "4")]
			private void ORSYPSKQCKV([In] ArchetypeChunk chunk, int a, bool b, [In] v128 chunkEnabledMask)
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
			[Cpp2IlInjected.Address(RVA = "0x842AEF0", Offset = "0x84296F0", VA = "0x18842AEF0")]
			public void CURJQMNILPU([In] ArchetypeChunk chunk, int a, bool b, [In] v128 chunkEnabledMask)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x842B210", Offset = "0x8429A10", VA = "0x18842B210", Slot = "4")]
			private void ORSYPSKQCKV([In] ArchetypeChunk chunk, int a, bool b, [In] v128 chunkEnabledMask)
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
			[Cpp2IlInjected.Address(RVA = "0x8428990", Offset = "0x8427190", VA = "0x188428990")]
			public void CURJQMNILPU([In] ArchetypeChunk batchInChunk, int a, bool b, [In] v128 chunkEnabledMask)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x8428AD0", Offset = "0x84272D0", VA = "0x188428AD0", Slot = "4")]
			private void ORSYPSKQCKV([In] ArchetypeChunk chunk, int a, bool b, [In] v128 chunkEnabledMask)
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
				public float3 YGMTLZNOHMI
				{
					[Cpp2IlInjected.Token(Token = "0x600013E")]
					[Cpp2IlInjected.Address(RVA = "0x8431F90", Offset = "0x8430790", VA = "0x188431F90")]
					get
					{
						return default(float3);
					}
					[Cpp2IlInjected.Token(Token = "0x600013F")]
					[Cpp2IlInjected.Address(RVA = "0x8431F40", Offset = "0x8430740", VA = "0x188431F40")]
					set
					{
					}
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000046")]
			private interface TIMFDSGFSOV
			{
				[Cpp2IlInjected.Token(Token = "0x6000140")]
				[Cpp2IlInjected.Address(Slot = "0")]
				float3 UMVSHNJZBEH(quaternion a);
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000047")]
			private struct LegacyDirectionFromRotation : TIMFDSGFSOV
			{
				[Cpp2IlInjected.Token(Token = "0x6000141")]
				[Cpp2IlInjected.Address(RVA = "0x8431370", Offset = "0x842FB70", VA = "0x188431370", Slot = "5")]
				public float3 HKQKRHUTCBC(quaternion a)
				{
					return default(float3);
				}

				[Cpp2IlInjected.Token(Token = "0x6000142")]
				[Cpp2IlInjected.Address(RVA = "0x8431710", Offset = "0x842FF10", VA = "0x188431710", Slot = "4")]
				public float3 UMVSHNJZBEH(quaternion a)
				{
					return default(float3);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000048")]
			private struct NewDirectionFromRotation : TIMFDSGFSOV
			{
				[Cpp2IlInjected.Token(Token = "0x6000143")]
				[Cpp2IlInjected.Address(RVA = "0x8431C20", Offset = "0x8430420", VA = "0x188431C20", Slot = "4")]
				public float3 UMVSHNJZBEH(quaternion a)
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
			[Cpp2IlInjected.Address(RVA = "0x842B970", Offset = "0x842A170", VA = "0x18842B970")]
			public void CURJQMNILPU([In] ArchetypeChunk chunk, int a, bool b, [In] v128 chunkEnabledMask)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x842CEE0", Offset = "0x842B6E0", VA = "0x18842CEE0")]
			private void MBCSTSMVCMK(NativeList<PointSrcData> a, NativeList<CurvePointData> b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x842DE70", Offset = "0x842C670", VA = "0x18842DE70")]
			public static Vector3 MHWJSAIBJIV(Vector3 a, Vector3 b, Vector3 c)
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x842B770", Offset = "0x8429F70", VA = "0x18842B770")]
			public static quaternion BCMXRYGWWSW(float3 a, float3 b)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x842C660", Offset = "0x842AE60", VA = "0x18842C660")]
			private static quaternion JWJBQDTQPQK(float3 a, float b, quaternion c)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x842E620", Offset = "0x842CE20", VA = "0x18842E620")]
			private static float3 SYPQGJTPQBI(float3 a, float b, float3 c)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x842E350", Offset = "0x842CB50", VA = "0x18842E350")]
			private static quaternion MXZIMFATTYR(float3 a, float b)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x842BF30", Offset = "0x842A730", VA = "0x18842BF30")]
			private static CurvePointData EANJTBLNRYV(int a, NativeList<PointSrcData> b)
			{
				return default(CurvePointData);
			}

			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x3C20840", Offset = "0x3C1F040", VA = "0x183C20840")]
			private void PCXZOYCZFIW<a>(NativeArray<Entity> a, NativeList<PointSrcData> b, float c, a d) where a : struct, TIMFDSGFSOV
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x842E7F0", Offset = "0x842CFF0", VA = "0x18842E7F0")]
			private void YNOTERBJECP(NativeList<PointSrcData> a, NativeList<CurvePointData> b, float c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x842B7F0", Offset = "0x8429FF0", VA = "0x18842B7F0")]
			public static float CTRQZRBSXIK(float3 a, float3 b, float3 c)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x842CCF0", Offset = "0x842B4F0", VA = "0x18842CCF0")]
			private static quaternion Lerp(quaternion q1, quaternion q2, float t)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x842C4B0", Offset = "0x842ACB0", VA = "0x18842C4B0")]
			private static CurvePointData IPNLQTUCVAI(PointSrcData a)
			{
				return default(CurvePointData);
			}

			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x842C5D0", Offset = "0x842ADD0", VA = "0x18842C5D0")]
			private static CurvePointData IPNLQTUCVAI(float3 a, quaternion b, float c)
			{
				return default(CurvePointData);
			}

			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x842C260", Offset = "0x842AA60", VA = "0x18842C260")]
			private static bool EBDNRAJJUWL(float3 a, float b, [Out] float3 c)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x842E280", Offset = "0x842CA80", VA = "0x18842E280")]
			private static float3 MWOEODIEXJY(float3 a, float b)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x842E470", Offset = "0x842CC70", VA = "0x18842E470")]
			public static float3 PTAVZSQCYMM(quaternion a)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0x842C300", Offset = "0x842AB00", VA = "0x18842C300")]
			public static float3 HKQKRHUTCBC(quaternion a)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x842C890", Offset = "0x842B090", VA = "0x18842C890")]
			private static quaternion LEMIVCJDFKJ(quaternion a, float3 b)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x842B600", Offset = "0x8429E00", VA = "0x18842B600")]
			private static float Angle(float3 from, float3 to)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0x842E3E0", Offset = "0x842CBE0", VA = "0x18842E3E0", Slot = "4")]
			private void ORSYPSKQCKV([In] ArchetypeChunk chunk, int a, bool b, [In] v128 chunkEnabledMask)
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
			[Cpp2IlInjected.Address(RVA = "0x8432420", Offset = "0x8430C20", VA = "0x188432420")]
			private void NKONCBHSVYX(DynamicBuffer<LinkedEntityGroup> a, int b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(RVA = "0x8431FB0", Offset = "0x84307B0", VA = "0x188431FB0")]
			[CompilerGenerated]
			public void CURJQMNILPU([In] ArchetypeChunk chunk, int a, bool b, [In] v128 chunkEnabledMask)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x8432500", Offset = "0x8430D00", VA = "0x188432500", Slot = "4")]
			private void ORSYPSKQCKV([In] ArchetypeChunk chunk, int a, bool b, [In] v128 chunkEnabledMask)
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
			[Cpp2IlInjected.Address(RVA = "0x843DE60", Offset = "0x843C660", VA = "0x18843DE60")]
			private void NKONCBHSVYX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0x843DE50", Offset = "0x843C650", VA = "0x18843DE50", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x843DAB0", Offset = "0x843C2B0", VA = "0x18843DAB0")]
			private void NKONCBHSVYX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0x843DAA0", Offset = "0x843C2A0", VA = "0x18843DAA0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x842B230", Offset = "0x8429A30", VA = "0x18842B230")]
			private void NKONCBHSVYX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0x842B220", Offset = "0x8429A20", VA = "0x18842B220", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x842B400", Offset = "0x8429C00", VA = "0x18842B400")]
			private void NKONCBHSVYX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x842B3F0", Offset = "0x8429BF0", VA = "0x18842B3F0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x843B2C0", Offset = "0x8439AC0", VA = "0x18843B2C0")]
			private void NKONCBHSVYX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x843B2B0", Offset = "0x8439AB0", VA = "0x18843B2B0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x843DEC0", Offset = "0x843C6C0", VA = "0x18843DEC0")]
			public void POQULTDLAOT(SystemState a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private static readonly Log RKIUKOTABJV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private EntityQuery RGLSCVWQHUS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private EntityQuery KLPZQAUAPCU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private UBPAZUSFYSS BPQQLOPPWTY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private ONAYZPPBQDG XHOCUIAHKIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private FWMYYWYXLKW BPFYALYTPVI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private PostDeserializeECB RDXJPBMAENO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private TypeHandle ZDWEHMMFACL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private EntityQuery VTCKZEJUFJR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private EntityQuery VSXEBXPWVYI;

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x8433470", Offset = "0x8431C70", VA = "0x188433470", Slot = "15")]
		public override void InitReferences(BDQJEHGTRBM services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x8434620", Offset = "0x8432E20", VA = "0x188434620", Slot = "5")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x84346F0", Offset = "0x8432EF0", VA = "0x1884346F0", Slot = "6")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x8434750", Offset = "0x8432F50", VA = "0x188434750", Slot = "13")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x84348C0", Offset = "0x84330C0", VA = "0x1884348C0")]
		private JobHandle THZKCCESGMI(EntityQuery a, Entity b, JobHandle c)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x8432510", Offset = "0x8430D10", VA = "0x188432510")]
		private JobHandle FTXRMLVZHIQ(EntityQuery a, Entity b, JobHandle c)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x84336E0", Offset = "0x8431EE0", VA = "0x1884336E0")]
		private JobHandle PIIPYRMZMPZ(NativeArray<int> a, NativeList<CurvePointData> b, JobHandle c)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x8433510", Offset = "0x8431D10", VA = "0x188433510")]
		private JobHandle LHXAAEKYKWG(NativeList<CurvePointData> a, NativeArray<int> b, JobHandle c)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x8433BB0", Offset = "0x84323B0", VA = "0x188433BB0")]
		private JobHandle LQNZIAYCFEH(EntityQuery a, NativeList<RecRoom.Foundation.Collections.Range> b, NativeList<CurvePointData> c, NativeArray<int> d, JobHandle e)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x8434230", Offset = "0x8432A30", VA = "0x188434230")]
		private JobHandle NJEHJGXQMDF(EntityCommandBuffer a, JobHandle b)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x8434100", Offset = "0x8432900", VA = "0x188434100")]
		private JobHandle LVOEYIXEVIM(NativeArray<int> a, JobHandle b)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x8435160", Offset = "0x8433960", VA = "0x188435160")]
		private JobHandle VWNXWKBWDRP(EntityQuery a, [Out] NativeList<Entity> b, [Out] NativeList<Entity> c, [Out] NativeList<BakedPrimitiveData> d, [Out] NativeParallelHashSet<Entity> e, JobHandle f, Allocator g = Allocator.TempJob)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x8435870", Offset = "0x8434070", VA = "0x188435870")]
		private JobHandle ZFZPTHLNRSV(EntityQuery a, [Out] NativeList<Entity> b, [Out] NativeList<Entity> c, [Out] NativeList<RecRoom.Foundation.Collections.Range> d, [Out] NativeList<BakedSplineData> e, [Out] NativeParallelHashSet<Entity> f, JobHandle g, Allocator h = Allocator.TempJob)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x8432D80", Offset = "0x8431580", VA = "0x188432D80")]
		private JobHandle IWBUWMHXTRA(NativeList<Entity> a, NativeList<Entity> b, EntityCommandBuffer c, JobHandle d)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x8434BC0", Offset = "0x84333C0", VA = "0x188434BC0")]
		private JobHandle TSTWIQDTAKE(EntityQuery a, NativeList<BakedPrimitiveData> b, JobHandle c)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x8433790", Offset = "0x8431F90", VA = "0x188433790")]
		private static NativeParallelHashMap<int, PrimitiveShapeMeshType> LNTXQGAQMGC()
		{
			return default(NativeParallelHashMap<int, PrimitiveShapeMeshType>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x8435420", Offset = "0x8433C20", VA = "0x188435420")]
		private JobHandle YWIHFAJNSZY(EntityQuery a, NativeList<RecRoom.Foundation.Collections.Range> b, NativeList<CurvePointData> c, NativeList<BakedSplineData> d, JobHandle e)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x8434400", Offset = "0x8432C00", VA = "0x188434400")]
		private JobHandle OHTPYUZBIUB(EntityCommandBuffer.ParallelWriter a, JobHandle b)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x84336E0", Offset = "0x8431EE0", VA = "0x1884336E0")]
		private JobHandle KTLFVUCDZCX(NativeArray<int> a, NativeList<CurvePointData> b, JobHandle c)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x8433510", Offset = "0x8431D10", VA = "0x188433510")]
		private JobHandle KFDYKIECXCC(NativeList<CurvePointData> a, NativeArray<int> b, JobHandle c)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x8432C70", Offset = "0x8431470", VA = "0x188432C70")]
		private JobHandle IRKXPGGOKFT(EntityQueryInJob a, EntityTypeHandle b, ComponentTypeHandle<ParentData> c, NativeList<Entity> d, NativeList<Entity> e, NativeParallelHashSet<Entity> f, NativeList<BakedPrimitiveData> g, JobHandle h)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x84335B0", Offset = "0x8431DB0", VA = "0x1884335B0")]
		private JobHandle KFFDAEQNVRH(EntityQueryInJob a, EntityTypeHandle b, ComponentTypeHandle<ParentData> c, NativeList<Entity> d, NativeList<Entity> e, NativeParallelHashSet<Entity> f, NativeList<RecRoom.Foundation.Collections.Range> g, NativeList<BakedSplineData> h, JobHandle i)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x8435B40", Offset = "0x8434340", VA = "0x188435B40")]
		private JobHandle ZZJGYYJOIPA(NativeList<Entity> a, NativeList<Entity> b, EntityCommandBuffer c, BufferLookup<ChildBuffer> d, BufferLookup<AuthoredChildBuffer> e, JobHandle f)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x8433080", Offset = "0x8431880", VA = "0x188433080")]
		private void IYMAEQHVYUI(SystemState a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x8434590", Offset = "0x8432D90", VA = "0x188434590", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x2E24A40", Offset = "0x2E23240", VA = "0x182E24A40")]
		[UnityEngine.Scripting.Preserve]
		public PostDeserializeBakeShapesSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public class GVBGKTBHOEJ : MQKDOERKHYD, IPQERUQWVJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private FWMYYWYXLKW BPFYALYTPVI;

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x842AAF0", Offset = "0x84292F0", VA = "0x18842AAF0", Slot = "14")]
		public void InitReferences(BDQJEHGTRBM services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x842AB40", Offset = "0x8429340", VA = "0x18842AB40", Slot = "13")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x2B75B20", Offset = "0x2B74320", VA = "0x182B75B20")]
		[UnityEngine.Scripting.Preserve]
		public GVBGKTBHOEJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[SystemEnabledLifetime(Lifetime.LoadInstance)]
	[CompilerGenerated]
	public class PostLoadCreateBakedShapesWrappersSystem : MHJPKHMAAFN, IPQERUQWVJD
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
			public (Entity parent, Transform containerWrapper, NativeArray<T> descriptors) YGVORQRYTRG
			{
				[Cpp2IlInjected.Token(Token = "0x6000169")]
				[Cpp2IlInjected.Address(RVA = "0x40720C0", Offset = "0x40708C0", VA = "0x1840720C0")]
				get
				{
					return default((Entity, Transform, NativeArray<T>));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x40727E0", Offset = "0x4070FE0", VA = "0x1840727E0")]
			public DescriptorSetEnumerator(EntityManager entityManager, EntityDataArrays<T> set, NativeArray<EntityRemapUtility.EntityRemapInfo> entityRemapping)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x4030A30", Offset = "0x402F230", VA = "0x184030A30")]
			public DescriptorSetEnumerator<T> GetEnumerator()
			{
				return default(DescriptorSetEnumerator<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x4071A90", Offset = "0x4070290", VA = "0x184071A90")]
			public bool MoveNext()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private static readonly Log RKIUKOTABJV;

		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private static readonly Log GSLYABPAXFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private TRSIKZJHWYK DMSRCEMMMLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private FWMYYWYXLKW BPFYALYTPVI;

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x84367B0", Offset = "0x8434FB0", VA = "0x1884367B0", Slot = "15")]
		public override void InitReferences(BDQJEHGTRBM services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x8436100", Offset = "0x8434900", VA = "0x188436100")]
		public void GGZFKITVEVE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x8437D90", Offset = "0x8436590", VA = "0x188437D90", Slot = "13")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x8438B50", Offset = "0x8437350", VA = "0x188438B50")]
		private void SCCNKZYPJUA(BakedShapeColliderMessage a, Mesh[] b, NativeArray<EntityRemapUtility.EntityRemapInfo> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x38D8350", Offset = "0x38D6B50", VA = "0x1838D8350")]
		private DescriptorSetEnumerator<T> CFSAXRPWVEJ<T>(EntityDataArrays<T> a, NativeArray<EntityRemapUtility.EntityRemapInfo> b) where T : struct
		{
			return default(DescriptorSetEnumerator<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x843A040", Offset = "0x8438840", VA = "0x18843A040")]
		private void ZDMLFGAJLML(Transform a, NativeArray<SphereDescriptor> b, UQNUASLZIEC<GameObject> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x8436340", Offset = "0x8434B40", VA = "0x188436340")]
		private void IPAUMRJFXOZ(Transform a, NativeArray<BoxDescriptor> b, UQNUASLZIEC<GameObject> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x84379E0", Offset = "0x84361E0", VA = "0x1884379E0")]
		private void NBWGLUHWWXB(Transform a, NativeArray<CapsuleDescriptor> b, UQNUASLZIEC<GameObject> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x8435CF0", Offset = "0x84344F0", VA = "0x188435CF0")]
		private void EGKRDGJIDLV(Transform a, NativeArray<MeshDescriptor> b, Mesh[] c, UQNUASLZIEC<GameObject> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x8436130", Offset = "0x8434930", VA = "0x188436130")]
		private static void ILLHZEIFCIG(NativeParallelHashSet<Entity> a, NativeParallelHashSet<Entity> b, NativeArray<EntityRemapUtility.EntityRemapInfo> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x8439980", Offset = "0x8438180", VA = "0x188439980")]
		private static void SMGCPFRTPWY(NativeList<Entity> a, NativeArray<EntityRemapUtility.EntityRemapInfo> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x8436830", Offset = "0x8435030", VA = "0x188436830")]
		private NativeParallelHashMap<Entity, RenderRootHandleData> JTPXHWWKSCS(FWMYYWYXLKW.SplineMessageQueueScope a, MessageQueueScope<BakedPrimitiveMessage> b, List<GameObject> c)
		{
			return default(NativeParallelHashMap<Entity, RenderRootHandleData>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x8439A90", Offset = "0x8438290", VA = "0x188439A90")]
		private NativeArray<EntityRemapUtility.EntityRemapInfo> VRWJPOVFOLF(Entity a)
		{
			return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x84373F0", Offset = "0x8435BF0", VA = "0x1884373F0")]
		private void LSOMYYFNIEK(NativeList<Entity> a, NativeList<Entity> b, NativeParallelHashMap<Entity, RenderRootHandleData> c, NativeList<RecRoom.Foundation.Collections.Range> d, NativeList<CurvePointData> e, NativeList<BakedSplineData> f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x8439BA0", Offset = "0x84383A0", VA = "0x188439BA0")]
		private void WFOPEDSEIAI(NativeList<Entity> a, NativeList<Entity> b, NativeParallelHashMap<Entity, RenderRootHandleData> c, NativeList<BakedPrimitiveData> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x2E24A40", Offset = "0x2E23240", VA = "0x182E24A40")]
		[UnityEngine.Scripting.Preserve]
		public PostLoadCreateBakedShapesWrappersSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public abstract class YXEZGEXITVM : WJPIBYVOQQG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public readonly UniformTRS HIDNEJIUPLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private readonly RRObject HJMDDSQJNLB;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		private GameObject KWMQERUERKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0xA9F9A0", Offset = "0xA9E1A0", VA = "0x180A9F9A0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public UniformTRS YSKLWSGEOOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x84454C0", Offset = "0x8443CC0", VA = "0x1884454C0", Slot = "8")]
			get
			{
				return default(UniformTRS);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		private Vector3 XROSGNAWEBE
		{
			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0x8445620", Offset = "0x8443E20", VA = "0x188445620", Slot = "10")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		private Matrix4x4 KBHQZWJZRJY
		{
			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x84455E0", Offset = "0x8443DE0", VA = "0x1884455E0", Slot = "9")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		private Vector3 WSCXPJLCEWK
		{
			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x84457A0", Offset = "0x8443FA0", VA = "0x1884457A0", Slot = "4")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x8445720", Offset = "0x8443F20", VA = "0x188445720", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		private Quaternion RMQMRPXTJKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x8445760", Offset = "0x8443F60", VA = "0x188445760", Slot = "6")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x8445660", Offset = "0x8443E60", VA = "0x188445660", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		private Vector3 JWHZVFDJUJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x84455A0", Offset = "0x8443DA0", VA = "0x1884455A0", Slot = "11")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		private Vector3 UUXFCCJJLQQ
		{
			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x84456E0", Offset = "0x8443EE0", VA = "0x1884456E0", Slot = "13")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		private Vector3 YRABQVTWQCK
		{
			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x84456A0", Offset = "0x8443EA0", VA = "0x1884456A0", Slot = "14")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x84457E0", Offset = "0x8443FE0", VA = "0x1884457E0")]
		public YXEZGEXITVM(UniformTRS a, RRObject b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public abstract class QEQVPVQZQDY : YXEZGEXITVM, HNZMDQFISIL, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private readonly float RKICOEWLUSK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private readonly float3 DIVMRVJYBLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private readonly ShapeColor ZTDFGICVGZZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private readonly ShapeMaterial MOPXXNGUOKZ;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		private RRTransform OOMLMIZVTUI
		{
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x8443F40", Offset = "0x8442740", VA = "0x188443F40", Slot = "17")]
			get
			{
				return default(RRTransform);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		private UniformTRS QJJWDEVXOAE
		{
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x8443F80", Offset = "0x8442780", VA = "0x188443F80", Slot = "18")]
			get
			{
				return default(UniformTRS);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		private float GHDNQTBSPHJ
		{
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0xBAABC0", Offset = "0xBA93C0", VA = "0x180BAABC0", Slot = "19")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		private Vector3 YZRQXSYAEJW
		{
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x8443EF0", Offset = "0x84426F0", VA = "0x188443EF0", Slot = "20")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		private ShapeColor BJTQJDTUOWM
		{
			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0xD11100", Offset = "0xD0F900", VA = "0x180D11100", Slot = "21")]
			get
			{
				return default(ShapeColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		private ShapeMaterial EDIPPAYWOAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x13AC460", Offset = "0x13AAC60", VA = "0x1813AC460", Slot = "22")]
			get
			{
				return default(ShapeMaterial);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		private bool EGRONOLBWXV
		{
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0xAE90A0", Offset = "0xAE78A0", VA = "0x180AE90A0", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool SEAJNUYQXJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0xAE90A0", Offset = "0xAE78A0", VA = "0x180AE90A0", Slot = "15")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990")]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x8444060", Offset = "0x8442860", VA = "0x188444060")]
		protected QEQVPVQZQDY(UniformTRS a, RRObject b, float c, float3 d, ShapeColor e, ShapeMaterial f)
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
	public abstract class JXUTGYSCVMT : WJPIBYVOQQG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		protected readonly ObjectLocalId FKPPHCMEODP;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		protected RRObject RDTNZSDPYLC
		{
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x1075E70", Offset = "0x1074670", VA = "0x181075E70")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		protected Entity PUYIGWQPGXG
		{
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x8442FC0", Offset = "0x84417C0", VA = "0x188442FC0")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		protected ONAYZPPBQDG AFKEDAVVOGV
		{
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x8443A90", Offset = "0x8442290", VA = "0x188443A90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		protected EQEGGVHWOFO CPSGYPFYNRN
		{
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x8443A30", Offset = "0x8442230", VA = "0x188443A30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		protected JRXTOINJVYB DBQHIYWLHGS
		{
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x8443430", Offset = "0x8441C30", VA = "0x188443430")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		private GameObject KWMQERUERKI
		{
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x84434C0", Offset = "0x8441CC0", VA = "0x1884434C0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public UniformTRS YSKLWSGEOOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x10AC2A0", Offset = "0x10AAAA0", VA = "0x1810AC2A0", Slot = "8")]
			get
			{
				return default(UniformTRS);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		private Vector3 XROSGNAWEBE
		{
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x8443240", Offset = "0x8441A40", VA = "0x188443240", Slot = "10")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		private Matrix4x4 KBHQZWJZRJY
		{
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x84430D0", Offset = "0x84418D0", VA = "0x1884430D0", Slot = "9")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		private Vector3 WSCXPJLCEWK
		{
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x8443BC0", Offset = "0x84423C0", VA = "0x188443BC0", Slot = "4")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x8443930", Offset = "0x8442130", VA = "0x188443930", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		private Quaternion RMQMRPXTJKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x8443AA0", Offset = "0x84422A0", VA = "0x188443AA0", Slot = "6")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x8443330", Offset = "0x8441B30", VA = "0x188443330", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		private Vector3 JWHZVFDJUJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x8442FE0", Offset = "0x84417E0", VA = "0x188442FE0", Slot = "11")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		private Vector3 UUXFCCJJLQQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x8443710", Offset = "0x8441F10", VA = "0x188443710", Slot = "13")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		private Vector3 YRABQVTWQCK
		{
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x84434F0", Offset = "0x8441CF0", VA = "0x1884434F0", Slot = "14")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0xCC19B0", Offset = "0xCC01B0", VA = "0x180CC19B0")]
		protected JXUTGYSCVMT(ObjectLocalId a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x8443CF0", Offset = "0x84424F0", VA = "0x188443CF0")]
		public static implicit operator RRTransform(JXUTGYSCVMT t)
		{
			return default(RRTransform);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public static class ZMLXMOXQWLC
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x8445830", Offset = "0x8444030", VA = "0x188445830")]
		public static void NIXQMBDDVIF(NativeArray<Entity> a, EntityManager b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public static class VRZTRNBZIXJ
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x8444AA0", Offset = "0x84432A0", VA = "0x188444AA0")]
		public static void CUWTZNCYXAL(NativeArray<Entity> a, EntityManager b, NUOTBWOORLZ c, ONAYZPPBQDG d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x84451A0", Offset = "0x84439A0", VA = "0x1884451A0")]
		public static void ZRTAGKTSEKA(NativeArray<Entity> a, EntityManager b, NUOTBWOORLZ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x8444EC0", Offset = "0x84436C0", VA = "0x188444EC0")]
		public static NativeList<Entity> IHAGEESEBVD(NativeArray<Entity> a, EntityManager b)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x8444A70", Offset = "0x8443270", VA = "0x188444A70")]
		public static NativeList<Entity> APCFSRRFPNC(NativeArray<Entity> a, EntityManager b)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x8444EF0", Offset = "0x84436F0", VA = "0x188444EF0")]
		private static NativeList<Entity> IHAGEESEBVD(NativeArray<Entity> a, EntityManager b, bool c)
		{
			return default(NativeList<Entity>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public abstract class SRXRINAIIBB : JXUTGYSCVMT, HNZMDQFISIL, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private float RKICOEWLUSK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private Vector3 DIVMRVJYBLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private ShapeColor ZTDFGICVGZZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private ShapeMaterial MOPXXNGUOKZ;

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		protected EntityManager IIRZUUTRTUH
		{
			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x8444340", Offset = "0x8442B40", VA = "0x188444340")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		protected PHSLCENMBKR CLQAVDMRWSF
		{
			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x84442B0", Offset = "0x8442AB0", VA = "0x1884442B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		protected ShapeConfigData OTZKNGPEABQ
		{
			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x84440E0", Offset = "0x84428E0", VA = "0x1884440E0")]
			get
			{
				return default(ShapeConfigData);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		private RRTransform OOMLMIZVTUI
		{
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x8443CF0", Offset = "0x84424F0", VA = "0x188443CF0", Slot = "17")]
			get
			{
				return default(RRTransform);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		private float GHDNQTBSPHJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0xAEF770", Offset = "0xAEDF70", VA = "0x180AEF770", Slot = "19")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		private Vector3 YZRQXSYAEJW
		{
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x117DF00", Offset = "0x117C700", VA = "0x18117DF00", Slot = "20")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		private ShapeColor BJTQJDTUOWM
		{
			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0xAA4E00", Offset = "0xAA3600", VA = "0x180AA4E00", Slot = "21")]
			get
			{
				return default(ShapeColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		private ShapeMaterial EDIPPAYWOAA
		{
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0xB2E980", Offset = "0xB2D180", VA = "0x180B2E980", Slot = "22")]
			get
			{
				return default(ShapeMaterial);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		private UniformTRS QJJWDEVXOAE
		{
			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x10AC2A0", Offset = "0x10AAAA0", VA = "0x1810AC2A0", Slot = "18")]
			get
			{
				return default(UniformTRS);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public bool SEAJNUYQXJH
		{
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0xB02810", Offset = "0xB01010", VA = "0x180B02810", Slot = "15")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0xB03320", Offset = "0xB01B20", VA = "0x180B03320")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		private bool EGRONOLBWXV
		{
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0xAE90A0", Offset = "0xAE78A0", VA = "0x180AE90A0", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x8444680", Offset = "0x8442E80", VA = "0x188444680")]
		protected SRXRINAIIBB(ObjectLocalId a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "25")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x8444480", Offset = "0x8442C80", VA = "0x188444480", Slot = "26")]
		public virtual void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(Slot = "27")]
		public abstract UnityEngine.Hash128 ComputeHash();
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[SystemEnabledLifetime(Lifetime.LoadInstance)]
	public abstract class MHJPKHMAAFN : MQKDOERKHYD, IPQERUQWVJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		protected ONAYZPPBQDG NIUGJDRHITL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private HCMSPYQCTSA FZZXZRNVKWC;

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		protected NUOTBWOORLZ SESHUIQLFGS
		{
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x8443DE0", Offset = "0x84425E0", VA = "0x188443DE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		protected WLURUBZSQIN RTFKLEJHCYM
		{
			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x8443D20", Offset = "0x8442520", VA = "0x188443D20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		protected bool CYDNYNTHLGJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x8443E30", Offset = "0x8442630", VA = "0x188443E30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x8443D70", Offset = "0x8442570", VA = "0x188443D70", Slot = "15")]
		public virtual void InitReferences(BDQJEHGTRBM services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x2B75B20", Offset = "0x2B74320", VA = "0x182B75B20")]
		[UnityEngine.Scripting.Preserve]
		protected MHJPKHMAAFN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public static class IGMKOUAKCYG
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x8442D60", Offset = "0x8441560", VA = "0x188442D60")]
		public static void JLVOTFPIYLE(NativeArray<Entity> a, EntityManager b)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__3689917982
{
	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x8445AA0", Offset = "0x84442A0", VA = "0x188445AA0")]
	public static void JTEJSBRAGJR()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x8445A90", Offset = "0x8444290", VA = "0x188445A90")]
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
