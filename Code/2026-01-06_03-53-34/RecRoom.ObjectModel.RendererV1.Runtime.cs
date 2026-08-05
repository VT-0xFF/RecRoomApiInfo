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
		[Cpp2IlInjected.Address(RVA = "0xAE07F0", Offset = "0xADF1F0", VA = "0x180AE07F0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAE07F0", Offset = "0xADF1F0", VA = "0x180AE07F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8534A40", Offset = "0x8533440", VA = "0x188534A40", Slot = "4")]
		public override void JIBLBJTHOBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xAE07F0", Offset = "0xADF1F0", VA = "0x180AE07F0")]
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
			[Cpp2IlInjected.Address(RVA = "0xAB85B0", Offset = "0xAB6FB0", VA = "0x180AB85B0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x84ED650", Offset = "0x84EC050", VA = "0x1884ED650", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8545880", Offset = "0x8544280", VA = "0x188545880")]
		private void ANRTHLCVEKO(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8545DE0", Offset = "0x85447E0", VA = "0x188545DE0", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8545E40", Offset = "0x8544840", VA = "0x188545E40")]
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
		[Cpp2IlInjected.Address(RVA = "0x8543EC0", Offset = "0x85428C0", VA = "0x188543EC0")]
		public static Quaternion KUSOYILMOHZ([In] this RRObjectSplinePoint splinePoint, [In] Vector3 direction)
		{
			return default(Quaternion);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class XYGCJQKKCEZ
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8543280", Offset = "0x8541C80", VA = "0x188543280")]
		public static bool WWOGEWKQVJV(this RRObjectShapeSpline a, ShapeConfigFlags b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8543250", Offset = "0x8541C50", VA = "0x188543250")]
		public static bool WCQIUXIJZPV(this RRObjectShapeSpline a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x85432C0", Offset = "0x8541CC0", VA = "0x1885432C0")]
		public static bool XCKXJXVNSEC(this RRObjectShapeSpline a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8542260", Offset = "0x8540C60", VA = "0x188542260")]
		public static void BYCGTMRAOTD(this RRObjectShapeSpline a, Vector3 b, Quaternion c, float d, bool e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x85432F0", Offset = "0x8541CF0", VA = "0x1885432F0")]
		public static void YQIVWPQUZFX(this RRObjectShapeSpline a, Vector3 b, Quaternion c, float d, int e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8542140", Offset = "0x8540B40", VA = "0x188542140")]
		public static void AREYZTWRTAZ(this RRObjectShapeSpline a, int b, Vector3 c, Quaternion d, float e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8542B60", Offset = "0x8541560", VA = "0x188542B60")]
		public static void JJACJVJENXC(this RRObjectShapeSpline a, Vector3 b, Quaternion c, float d, bool e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8543570", Offset = "0x8541F70", VA = "0x188543570")]
		private static void YTVZICHZSBT(this RRObjectShapeSpline a, Vector3 b, Quaternion c, float d, bool e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x85430A0", Offset = "0x8541AA0", VA = "0x1885430A0")]
		private static void TJVSTWRETCT(this RRObjectShapeSpline a, Vector3 b, Quaternion c, float d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8542730", Offset = "0x8541130", VA = "0x188542730")]
		private static void HAYQFAGRHED(this RRObjectShapeSpline a, int b, Vector3 c, Quaternion d, float e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8542910", Offset = "0x8541310", VA = "0x188542910")]
		private static bool HSIJXKHTHCB(this RRObjectShapeSpline a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x85424A0", Offset = "0x8540EA0", VA = "0x1885424A0")]
		private static void GVYIEMUELRZ(this RRObjectShapeSpline a, int b, Vector3 c, Quaternion d, float e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8542BB0", Offset = "0x85415B0", VA = "0x188542BB0")]
		public static Vector3 QQYLHLJXHNY(this RRObjectShapeSpline a, int b)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8542390", Offset = "0x8540D90", VA = "0x188542390")]
		public static Quaternion CRRZGVSYWLV(this RRObjectShapeSpline a, int b)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8542940", Offset = "0x8541340", VA = "0x188542940")]
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
		[Cpp2IlInjected.Address(RVA = "0x853E300", Offset = "0x853CD00", VA = "0x18853E300", Slot = "4")]
		public void HTRRZJHDGJG(EntityQuery a, EntityManager b, HCMSPYQCTSA c, QXPDTJGGIJN d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAC34F0", Offset = "0xAC1EF0", VA = "0x180AC34F0")]
		public UNGUWQAPFFM(SelectionEffectType a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x8541330", Offset = "0x853FD30", VA = "0x188541330", Slot = "4")]
		public void HTRRZJHDGJG(EntityQuery a, EntityManager b, HCMSPYQCTSA c, QXPDTJGGIJN d)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	internal class EEKSXTDMDGW : KQUGUTPTICP
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x852C3D0", Offset = "0x852ADD0", VA = "0x18852C3D0", Slot = "4")]
		public void HTRRZJHDGJG(EntityQuery a, EntityManager b, HCMSPYQCTSA c, QXPDTJGGIJN d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x8532AF0", Offset = "0x85314F0", VA = "0x188532AF0", Slot = "4")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8532B50", Offset = "0x8531550", VA = "0x188532B50", Slot = "5")]
		public void LBKEPSAHCCU(EntityQuery a, WLURUBZSQIN b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8532DF0", Offset = "0x85317F0", VA = "0x188532DF0", Slot = "6")]
		public void RSFWVOXZDVF(EntityQuery a, WLURUBZSQIN b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8533090", Offset = "0x8531A90", VA = "0x188533090", Slot = "7")]
		public void YBYLVHTQPNB(WLURUBZSQIN a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x8541B50", Offset = "0x8540550", VA = "0x188541B50", Slot = "4")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8541BB0", Offset = "0x85405B0", VA = "0x188541BB0", Slot = "5")]
		public void LBKEPSAHCCU(EntityQuery a, WLURUBZSQIN b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8541E50", Offset = "0x8540850", VA = "0x188541E50", Slot = "6")]
		public void RSFWVOXZDVF(EntityQuery a, WLURUBZSQIN b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x85420F0", Offset = "0x8540AF0", VA = "0x1885420F0", Slot = "7")]
		public void YBYLVHTQPNB(WLURUBZSQIN a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x85414A0", Offset = "0x853FEA0", VA = "0x1885414A0", Slot = "4")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8541500", Offset = "0x853FF00", VA = "0x188541500", Slot = "5")]
		public void LBKEPSAHCCU(EntityQuery a, WLURUBZSQIN b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x85417A0", Offset = "0x85401A0", VA = "0x1885417A0", Slot = "6")]
		public void RSFWVOXZDVF(EntityQuery a, WLURUBZSQIN b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8541A40", Offset = "0x8540440", VA = "0x188541A40", Slot = "7")]
		public void YBYLVHTQPNB(WLURUBZSQIN a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x852C680", Offset = "0x852B080", VA = "0x18852C680", Slot = "15")]
		public virtual void InitReferences(BDQJEHGTRBM services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x852C710", Offset = "0x852B110", VA = "0x18852C710", Slot = "5")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x852C520", Offset = "0x852AF20", VA = "0x18852C520")]
		private void FFYWADEJGXV(EntityQueryDesc a, KQUGUTPTICP b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x852C900", Offset = "0x852B300", VA = "0x18852C900", Slot = "13")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x2B87B90", Offset = "0x2B86590", VA = "0x182B87B90")]
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
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8540940", Offset = "0x853F340", VA = "0x188540940", Slot = "14")]
		public void InitReferences(BDQJEHGTRBM services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x85409D0", Offset = "0x853F3D0", VA = "0x1885409D0", Slot = "5")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8540B50", Offset = "0x853F550", VA = "0x188540B50", Slot = "13")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x853FD90", Offset = "0x853E790", VA = "0x18853FD90")]
		private void ECPDVRUYAZI(Effect a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8540210", Offset = "0x853EC10", VA = "0x188540210")]
		private void FFYWADEJGXV(OPXXOVXSTEV a, ComponentType b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x2B87B90", Offset = "0x2B86590", VA = "0x182B87B90")]
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
			[Cpp2IlInjected.Address(RVA = "0xAB5110", Offset = "0xAB3B10", VA = "0x180AB5110", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(OutlineEffectType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xAC0440", Offset = "0xABEE40", VA = "0x180AC0440", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x8544BC0", Offset = "0x85435C0", VA = "0x188544BC0")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public int OLYZTWZNFDJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x85444B0", Offset = "0x8542EB0", VA = "0x1885444B0", Slot = "7")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int NOCJXESJUKW
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x8544C90", Offset = "0x8543690", VA = "0x188544C90", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x8544360", Offset = "0x8542D60", VA = "0x188544360", Slot = "4")]
		public bool EXYDORJJEDI(ObjectLocalId a, MutableRef b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x8543FE0", Offset = "0x85429E0", VA = "0x188543FE0", Slot = "5")]
		public RootHandle DSKWHKOBPAU()
		{
			return default(RootHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8544600", Offset = "0x8543000", VA = "0x188544600", Slot = "6")]
		public RootHandle OCMUIEHDVGL()
		{
			return default(RootHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x85444D0", Offset = "0x8542ED0", VA = "0x1885444D0", Slot = "9")]
		public void InitExternal(BDQJEHGTRBM services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x8543FA0", Offset = "0x85429A0", VA = "0x188543FA0", Slot = "11")]
		public void BTTVCOLODYQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x85448F0", Offset = "0x85432F0", VA = "0x1885448F0", Slot = "10")]
		public void OINRTVSEBTU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x85442D0", Offset = "0x8542CD0", VA = "0x1885442D0", Slot = "12")]
		private void EFSYMFFESBS(BDQJEHGTRBM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x10C73B0", Offset = "0x10C5DB0", VA = "0x1810C73B0", Slot = "13")]
		private void MIIBQCGEILO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public ZEIVDQUAHFO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[RegisterService(typeof(UGLPLBZLSJU), new string[] { })]
	public class KLLKTBPNBDD : UGLPLBZLSJU
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x8534580", Offset = "0x8532F80", VA = "0x188534580", Slot = "4")]
		public void YSWBAIPNDKM(World a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8534610", Offset = "0x8533010", VA = "0x188534610", Slot = "5")]
		public void ZICETSGXKDS(World a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x85343A0", Offset = "0x8532DA0", VA = "0x1885343A0", Slot = "6")]
		public ComponentSystemBase EQRKTESAKDZ(World a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x8534460", Offset = "0x8532E60", VA = "0x188534460", Slot = "7")]
		public void HQOCEPYJBXF(World a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x8534520", Offset = "0x8532F20", VA = "0x188534520", Slot = "8")]
		public void SGYKGIDOFQG(World a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x85344C0", Offset = "0x8532EC0", VA = "0x1885344C0", Slot = "9")]
		public void ORXNCSJMZYH(World a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x85343F0", Offset = "0x8532DF0", VA = "0x1885343F0", Slot = "10")]
		public void GGZFKITVEVE(World a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x8533B20", Offset = "0x8532520", VA = "0x188533B20", Slot = "11")]
		public NativeParallelHashSet<ComponentTypeIndex> AKCPUGWXIUN()
		{
			return default(NativeParallelHashSet<ComponentTypeIndex>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
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
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0xAB85E0", Offset = "0xAB6FE0", VA = "0x180AB85E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x853E590", Offset = "0x853CF90", VA = "0x18853E590", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x853E520", Offset = "0x853CF20", VA = "0x18853E520", Slot = "4")]
		public object Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0xB5A370", Offset = "0xB58D70", VA = "0x180B5A370")]
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
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xAB85E0", Offset = "0xAB6FE0", VA = "0x180AB85E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8534E30", Offset = "0x8533830", VA = "0x188534E30", Slot = "4")]
		public object Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0xB5A370", Offset = "0xB58D70", VA = "0x180B5A370")]
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
		[Cpp2IlInjected.Address(RVA = "0xB5A370", Offset = "0xB58D70", VA = "0x180B5A370")]
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
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0xAB85E0", Offset = "0xAB6FE0", VA = "0x180AB85E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x8541B00", Offset = "0x8540500", VA = "0x188541B00", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8541A90", Offset = "0x8540490", VA = "0x188541A90", Slot = "4")]
		public object Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
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
			[Cpp2IlInjected.Address(RVA = "0xBF6EC0", Offset = "0xBF58C0", VA = "0x180BF6EC0", Slot = "27")]
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
			[Cpp2IlInjected.Address(RVA = "0x1359EF0", Offset = "0x13588F0", VA = "0x181359EF0", Slot = "28")]
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
			[Cpp2IlInjected.Address(RVA = "0xFFB060", Offset = "0xFF9A60", VA = "0x180FFB060", Slot = "29")]
			[CompilerGenerated]
			get
			{
				return default(float3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x852DD20", Offset = "0x852C720", VA = "0x18852DD20")]
		public GRUNPQLGHRU(UniformTRS a, RRObject b, float c, float3 d, ShapeColor e, ShapeMaterial f, PrimitiveShapeMeshType g, float3 h, bool i)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x852DCC0", Offset = "0x852C6C0", VA = "0x18852DCC0", Slot = "25")]
		public override UnityEngine.Hash128 ComputeHash()
		{
			return default(UnityEngine.Hash128);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xAB6970", Offset = "0xAB5370", VA = "0x180AB6970", Slot = "26")]
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
			[Cpp2IlInjected.Address(RVA = "0x8533250", Offset = "0x8531C50", VA = "0x188533250", Slot = "27")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool EFEPVFYBIZZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x8533270", Offset = "0x8531C70", VA = "0x188533270", Slot = "28")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool PHVSKUBHCUE
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x8533260", Offset = "0x8531C60", VA = "0x188533260", Slot = "31")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public int EVNRWQYFUGX
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xC38D30", Offset = "0xC37730", VA = "0x180C38D30", Slot = "32")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public float NWJKVLZDJIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xB50EE0", Offset = "0xB4F8E0", VA = "0x180B50EE0", Slot = "29")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public int KGDUHTNMJHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xB78EE0", Offset = "0xB778E0", VA = "0x180B78EE0", Slot = "30")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x85331B0", Offset = "0x8531BB0", VA = "0x1885331B0")]
		public IYEHRCBLWVU(UniformTRS a, RRObject b, float c, float3 d, ShapeColor e, ShapeMaterial f, SplineParameterFlags g, float h, int i, NativeArray<CurvePointData> j)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xC81A70", Offset = "0xC80470", VA = "0x180C81A70", Slot = "33")]
		public NativeArray<CurvePointData> GetNativeCurvePoints()
		{
			return default(NativeArray<CurvePointData>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x85330E0", Offset = "0x8531AE0", VA = "0x1885330E0", Slot = "25")]
		public override UnityEngine.Hash128 ComputeHash()
		{
			return default(UnityEngine.Hash128);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xAB6970", Offset = "0xAB5370", VA = "0x180AB6970", Slot = "26")]
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
			[Cpp2IlInjected.Address(RVA = "0xAE61A0", Offset = "0xAE4BA0", VA = "0x180AE61A0", Slot = "28")]
			get
			{
				return default(PrimitiveShapeMeshType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private bool MSZRKFQNQCX
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xC37A20", Offset = "0xC36420", VA = "0x180C37A20", Slot = "29")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public float3 EXPVVQNCITE
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x853DEC0", Offset = "0x853C8C0", VA = "0x18853DEC0", Slot = "30")]
			get
			{
				return default(float3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x853DEA0", Offset = "0x853C8A0", VA = "0x18853DEA0")]
		public PrimitiveWrapper(ObjectLocalId objectLocalId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x853D780", Offset = "0x853C180", VA = "0x18853D780", Slot = "27")]
		public override UnityEngine.Hash128 ComputeHash()
		{
			return default(UnityEngine.Hash128);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x853D7D0", Offset = "0x853C1D0", VA = "0x18853D7D0", Slot = "26")]
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
			[Cpp2IlInjected.Address(RVA = "0x8544F70", Offset = "0x8543970", VA = "0x188544F70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public RRTransform YTQQQFYHIEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x8544E70", Offset = "0x8543870", VA = "0x188544E70", Slot = "15")]
			get
			{
				return default(RRTransform);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public RootFlags LDOYOYNQFTI
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x8545290", Offset = "0x8543C90", VA = "0x188545290", Slot = "16")]
			get
			{
				return default(RootFlags);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x8545150", Offset = "0x8543B50", VA = "0x188545150")]
		public ZFXVOUVPPXA(ObjectLocalId a, bool b = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x8544CE0", Offset = "0x85436E0", VA = "0x188544CE0")]
		public void EXWLVURKEGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x8544E70", Offset = "0x8543870", VA = "0x188544E70")]
		protected RRTransform QTGQHTXHILN()
		{
			return default(RRTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8545000", Offset = "0x8543A00", VA = "0x188545000")]
		private static bool YZSKGOAMKDO(ObjectLocalId a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8544CB0", Offset = "0x85436B0", VA = "0x188544CB0", Slot = "18")]
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
			[Cpp2IlInjected.Address(RVA = "0xCB3680", Offset = "0xCB2080", VA = "0x180CB3680", Slot = "28")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		private bool RJXYSYDELZE
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x12F29A0", Offset = "0x12F13A0", VA = "0x1812F29A0", Slot = "29")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private float OLJJHGZWUWD
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xB076B0", Offset = "0xB060B0", VA = "0x180B076B0", Slot = "30")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private int ZCTNOGAUVXH
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0xD28600", Offset = "0xD27000", VA = "0x180D28600", Slot = "31")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		private bool HGUZIEQDMXH
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0xDF8FA0", Offset = "0xDF79A0", VA = "0x180DF8FA0", Slot = "32")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private int XXWUQTTIFQQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x8533280", Offset = "0x8531C80", VA = "0x188533280", Slot = "33")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		private int MMESMRCUJAX
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x8533A00", Offset = "0x8532400", VA = "0x188533A00", Slot = "38")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x8533AF0", Offset = "0x85324F0", VA = "0x188533AF0")]
		public JSZSIWUHVGF(ObjectLocalId a, [Optional] NativeList<CurvePointData> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8533930", Offset = "0x8532330", VA = "0x188533930", Slot = "26")]
		public override void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x85332A0", Offset = "0x8531CA0", VA = "0x1885332A0", Slot = "27")]
		public override UnityEngine.Hash128 ComputeHash()
		{
			return default(UnityEngine.Hash128);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8533390", Offset = "0x8531D90", VA = "0x188533390", Slot = "25")]
		public override void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x85336B0", Offset = "0x85320B0", VA = "0x1885336B0")]
		public void NRHNAFRDKVE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x85333F0", Offset = "0x8531DF0", VA = "0x1885333F0", Slot = "34")]
		public NativeArray<CurvePointData> GetNativeCurvePoints()
		{
			return default(NativeArray<CurvePointData>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x8533590", Offset = "0x8531F90", VA = "0x188533590", Slot = "35")]
		private Vector3 HJLMGCJHFRW(int a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x8533710", Offset = "0x8532110", VA = "0x188533710", Slot = "36")]
		private Quaternion PCQHQXTUCPT(int a)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x8533740", Offset = "0x8532140", VA = "0x188533740", Slot = "37")]
		private float SMLDVCTLUEN(int a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x85338C0", Offset = "0x85322C0", VA = "0x1885338C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8545400", Offset = "0x8543E00", VA = "0x188545400", Slot = "15")]
		protected override ComponentSystemBase VXVCIIORMOX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x85453F0", Offset = "0x8543DF0", VA = "0x1885453F0", Slot = "13")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x8545870", Offset = "0x8544270", VA = "0x188545870")]
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
		[Cpp2IlInjected.Address(RVA = "0x8525620", Offset = "0x8524020", VA = "0x188525620", Slot = "5")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x8525950", Offset = "0x8524350", VA = "0x188525950", Slot = "13")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x85250B0", Offset = "0x8523AB0", VA = "0x1885250B0")]
		private void IBJTFGYARGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x8525990", Offset = "0x8524390", VA = "0x188525990")]
		private void QJJWJQSZCDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x8525430", Offset = "0x8523E30", VA = "0x188525430")]
		private void OESYCNNMWVU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x8525AC0", Offset = "0x85244C0", VA = "0x188525AC0")]
		private void RPWHVVWUIRE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x8525300", Offset = "0x8523D00", VA = "0x188525300")]
		private void MKZXQAUAYQQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x8525060", Offset = "0x8523A60", VA = "0x188525060")]
		private NativeList<Entity> APCFSRRFPNC(NativeArray<Entity> a)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x85252B0", Offset = "0x8523CB0", VA = "0x1885252B0")]
		private NativeList<Entity> IHAGEESEBVD(NativeArray<Entity> a)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x8525BF0", Offset = "0x85245F0", VA = "0x188525BF0")]
		private void UNHYYJWCRKM(NativeArray<Entity> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x2E39A00", Offset = "0x2E38400", VA = "0x182E39A00")]
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
		[Cpp2IlInjected.Address(RVA = "0x8527110", Offset = "0x8525B10", VA = "0x188527110", Slot = "5")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x85267B0", Offset = "0x85251B0", VA = "0x1885267B0", Slot = "15")]
		public override void InitReferences(BDQJEHGTRBM services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x85272C0", Offset = "0x8525CC0", VA = "0x1885272C0", Slot = "13")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x85272E0", Offset = "0x8525CE0", VA = "0x1885272E0")]
		private void SRELDIOHOEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x8526810", Offset = "0x8525210", VA = "0x188526810")]
		private void MFFRRVFTHLG(NativeParallelHashSet<RootHandle> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x85260F0", Offset = "0x8524AF0", VA = "0x1885260F0")]
		private void BRQHBQYKXHS(NativeParallelHashSet<RootHandle> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x8525CE0", Offset = "0x85246E0", VA = "0x188525CE0")]
		private void BFUUJILXQZP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x85276C0", Offset = "0x85260C0", VA = "0x1885276C0")]
		private bool TBLOPPZPFSD(Entity a, [Out] RootHandle b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x8526ED0", Offset = "0x85258D0", VA = "0x188526ED0")]
		internal bool ORNLZSZKJSN(Entity a, [Out] RootHandle b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x2E39A00", Offset = "0x2E38400", VA = "0x182E39A00")]
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
		[Cpp2IlInjected.Address(RVA = "0x8527E50", Offset = "0x8526850", VA = "0x188527E50", Slot = "5")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x8527F80", Offset = "0x8526980", VA = "0x188527F80", Slot = "13")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x8527B20", Offset = "0x8526520", VA = "0x188527B20")]
		private void MFFRRVFTHLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x85277F0", Offset = "0x85261F0", VA = "0x1885277F0")]
		private void BRQHBQYKXHS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x2E39A00", Offset = "0x2E38400", VA = "0x182E39A00")]
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
			[Cpp2IlInjected.Address(RVA = "0x852C280", Offset = "0x852AC80", VA = "0x18852C280", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x852C2E0", Offset = "0x852ACE0", VA = "0x18852C2E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x852BDA0", Offset = "0x852A7A0", VA = "0x18852BDA0")]
			public void CURJQMNILPU([In] ArchetypeChunk chunk, int a, bool b, [In] v128 chunkEnabledMask)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x852BF70", Offset = "0x852A970", VA = "0x18852BF70", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x8528120", Offset = "0x8526B20", VA = "0x188528120", Slot = "5")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x8528530", Offset = "0x8526F30", VA = "0x188528530", Slot = "13")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x8528020", Offset = "0x8526A20", VA = "0x188528020")]
		private void EUMDYHKOBYR(NativeParallelHashSet<RootHandle> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x8528900", Offset = "0x8527300", VA = "0x188528900")]
		private void SPSSMFHVLJX(NativeParallelHashSet<RootHandle> a, int b, int c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x2E39A00", Offset = "0x2E38400", VA = "0x182E39A00")]
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
			[Cpp2IlInjected.Address(RVA = "0x852BF80", Offset = "0x852A980", VA = "0x18852BF80")]
			public void CURJQMNILPU([In] ArchetypeChunk chunk, int a, bool b, [In] v128 chunkEnabledMask)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x852C270", Offset = "0x852AC70", VA = "0x18852C270", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x8529BC0", Offset = "0x85285C0", VA = "0x188529BC0", Slot = "5")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x8529B60", Offset = "0x8528560", VA = "0x188529B60", Slot = "15")]
		public override void InitReferences(BDQJEHGTRBM services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x8529F80", Offset = "0x8528980", VA = "0x188529F80", Slot = "13")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x852A390", Offset = "0x8528D90", VA = "0x18852A390")]
		private void QDVZPKVJPYM(NativeParallelHashSet<RootHandle> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x852ABE0", Offset = "0x85295E0", VA = "0x18852ABE0")]
		private void VFLAKBRZZJJ(NativeParallelHashSet<RootHandle> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x85291D0", Offset = "0x8527BD0", VA = "0x1885291D0")]
		private void EEGQGBCLFOJ(NativeParallelHashSet<RootHandle> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x8528D20", Offset = "0x8527720", VA = "0x188528D20")]
		private void BOKFUVASNJJ(NativeParallelHashSet<RootHandle> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x8529640", Offset = "0x8528040", VA = "0x188529640")]
		private void IWSQXQNMVBU(NativeParallelHashSet<RootHandle> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x852B080", Offset = "0x8529A80", VA = "0x18852B080")]
		private void VRRIGHGFWKT(Entity a, ShapeHandle b, RootHandle c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x2E39A00", Offset = "0x2E38400", VA = "0x182E39A00")]
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
		[Cpp2IlInjected.Address(RVA = "0x852B2F0", Offset = "0x8529CF0", VA = "0x18852B2F0", Slot = "5")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x852B510", Offset = "0x8529F10", VA = "0x18852B510", Slot = "13")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x2E39A00", Offset = "0x2E38400", VA = "0x182E39A00")]
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
		[Cpp2IlInjected.Address(RVA = "0x853DF90", Offset = "0x853C990", VA = "0x18853DF90", Slot = "5")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x853E0C0", Offset = "0x853CAC0", VA = "0x18853E0C0", Slot = "13")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x2E39A00", Offset = "0x2E38400", VA = "0x182E39A00")]
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
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x853EBF0", Offset = "0x853D5F0", VA = "0x18853EBF0", Slot = "15")]
		public override void InitReferences(BDQJEHGTRBM services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x853EE20", Offset = "0x853D820", VA = "0x18853EE20", Slot = "5")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x853F0D0", Offset = "0x853DAD0", VA = "0x18853F0D0", Slot = "13")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x3A24590", Offset = "0x3A22F90", VA = "0x183A24590")]
		private void FFYWADEJGXV<a>(RemoveEffect a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x853F5F0", Offset = "0x853DFF0", VA = "0x18853F5F0")]
		private static void ULRSNDBIIBV(NativeArray<ShapeHandle> a, WLURUBZSQIN b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x853EC50", Offset = "0x853D650", VA = "0x18853EC50")]
		private static void KKOQYNJVYTR(NativeArray<ShapeHandle> a, WLURUBZSQIN b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x853EA20", Offset = "0x853D420", VA = "0x18853EA20")]
		private static void HUQECLCJKDF(NativeArray<ShapeHandle> a, WLURUBZSQIN b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x2E39A00", Offset = "0x2E38400", VA = "0x182E39A00")]
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
		[Cpp2IlInjected.Address(RVA = "0x853F840", Offset = "0x853E240", VA = "0x18853F840", Slot = "5")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x853F900", Offset = "0x853E300", VA = "0x18853F900", Slot = "13")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x2E39A00", Offset = "0x2E38400", VA = "0x182E39A00")]
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
		[Cpp2IlInjected.Address(RVA = "0x852BAE0", Offset = "0x852A4E0", VA = "0x18852BAE0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x1836260", Offset = "0x1834C60", VA = "0x181836260")]
			public SplineMessageQueueScope(FWMYYWYXLKW parent, bool disposePointData)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x85410F0", Offset = "0x853FAF0", VA = "0x1885410F0")]
			public Queue<BakedSplinesMessage>.Enumerator GetEnumerator()
			{
				return default(Queue<BakedSplinesMessage>.Enumerator);
			}

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x8540E40", Offset = "0x853F840", VA = "0x188540E40", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x852CFE0", Offset = "0x852B9E0", VA = "0x18852CFE0", Slot = "4")]
		public void InitReferences(BDQJEHGTRBM services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x852CB80", Offset = "0x852B580", VA = "0x18852CB80")]
		public void AEWFREJXDZG(NativeList<CurvePointData> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x852DB00", Offset = "0x852C500", VA = "0x18852DB00")]
		public void RZBTDUPCZZP(Entity a, [In] UQNUASLZIEC<GameObject> inColliders)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x852DA80", Offset = "0x852C480", VA = "0x18852DA80")]
		public void RSJJMCLKJXP(NativeList<ShapeHandle> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x852D230", Offset = "0x852BC30", VA = "0x18852D230")]
		public void ORXNCSJMZYH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x852D460", Offset = "0x852BE60", VA = "0x18852D460")]
		public void QMLDUWQROSY(NUOTBWOORLZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x852D9E0", Offset = "0x852C3E0", VA = "0x18852D9E0")]
		public JobHandle RBRFIRPKWEL([In] BakedSplinesMessage message, JobHandle a)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x852D940", Offset = "0x852C340", VA = "0x18852D940")]
		public JobHandle RBRFIRPKWEL([In] BakedPrimitiveMessage message, JobHandle a)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x81CF1B0", Offset = "0x81CDBB0", VA = "0x1881CF1B0")]
		public SplineMessageQueueScope AHFJRCKQKPU(bool a)
		{
			return default(SplineMessageQueueScope);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x852CF90", Offset = "0x852B990", VA = "0x18852CF90")]
		public MessageQueueScope<BakedPrimitiveMessage> ERZWEOCKAEI()
		{
			return default(MessageQueueScope<BakedPrimitiveMessage>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x852D1E0", Offset = "0x852BBE0", VA = "0x18852D1E0")]
		public MessageQueueScope<BakedShapeColliderMessage> KCVJYRVRUNB()
		{
			return default(MessageQueueScope<BakedShapeColliderMessage>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x852CD00", Offset = "0x852B700", VA = "0x18852CD00")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x852CC20", Offset = "0x852B620", VA = "0x18852CC20", Slot = "5")]
		public void BTTVCOLODYQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x852CF20", Offset = "0x852B920", VA = "0x18852CF20", Slot = "6")]
		private void EFSYMFFESBS(BDQJEHGTRBM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0xD5FF40", Offset = "0xD5E940", VA = "0x180D5FF40", Slot = "7")]
		private void MIIBQCGEILO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x852BB70", Offset = "0x852A570", VA = "0x18852BB70", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x852BB80", Offset = "0x852A580", VA = "0x18852BB80")]
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
		[Cpp2IlInjected.Address(RVA = "0x8534EF0", Offset = "0x85338F0", VA = "0x188534EF0", Slot = "4")]
		public void ShutdownReferences()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x8534EA0", Offset = "0x85338A0", VA = "0x188534EA0", Slot = "5")]
		private void EFSYMFFESBS(BDQJEHGTRBM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0xCB03D0", Offset = "0xCAEDD0", VA = "0x180CB03D0", Slot = "6")]
		private void MIIBQCGEILO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x852DE30", Offset = "0x852C830", VA = "0x18852DE30")]
			public void CURJQMNILPU([In] ArchetypeChunk chunk, int a, bool b, [In] v128 chunkEnabledMask)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x852E1B0", Offset = "0x852CBB0", VA = "0x18852E1B0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x852E1C0", Offset = "0x852CBC0", VA = "0x18852E1C0")]
			public void CURJQMNILPU([In] ArchetypeChunk chunk, int a, bool b, [In] v128 chunkEnabledMask)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x852E4E0", Offset = "0x852CEE0", VA = "0x18852E4E0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x852BC50", Offset = "0x852A650", VA = "0x18852BC50")]
			public void CURJQMNILPU([In] ArchetypeChunk batchInChunk, int a, bool b, [In] v128 chunkEnabledMask)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x852BD90", Offset = "0x852A790", VA = "0x18852BD90", Slot = "4")]
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
					[Cpp2IlInjected.Address(RVA = "0x8535280", Offset = "0x8533C80", VA = "0x188535280")]
					get
					{
						return default(float3);
					}
					[Cpp2IlInjected.Token(Token = "0x600013F")]
					[Cpp2IlInjected.Address(RVA = "0x8535230", Offset = "0x8533C30", VA = "0x188535230")]
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
				[Cpp2IlInjected.Address(RVA = "0x8534660", Offset = "0x8533060", VA = "0x188534660", Slot = "5")]
				public float3 HKQKRHUTCBC(quaternion a)
				{
					return default(float3);
				}

				[Cpp2IlInjected.Token(Token = "0x6000142")]
				[Cpp2IlInjected.Address(RVA = "0x8534A00", Offset = "0x8533400", VA = "0x188534A00", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x8534F10", Offset = "0x8533910", VA = "0x188534F10", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x852EC40", Offset = "0x852D640", VA = "0x18852EC40")]
			public void CURJQMNILPU([In] ArchetypeChunk chunk, int a, bool b, [In] v128 chunkEnabledMask)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x85301B0", Offset = "0x852EBB0", VA = "0x1885301B0")]
			private void MBCSTSMVCMK(NativeList<PointSrcData> a, NativeList<CurvePointData> b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x8531140", Offset = "0x852FB40", VA = "0x188531140")]
			public static Vector3 MHWJSAIBJIV(Vector3 a, Vector3 b, Vector3 c)
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x852EA40", Offset = "0x852D440", VA = "0x18852EA40")]
			public static quaternion BCMXRYGWWSW(float3 a, float3 b)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x852F930", Offset = "0x852E330", VA = "0x18852F930")]
			private static quaternion JWJBQDTQPQK(float3 a, float b, quaternion c)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x85318F0", Offset = "0x85302F0", VA = "0x1885318F0")]
			private static float3 SYPQGJTPQBI(float3 a, float b, float3 c)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x8531620", Offset = "0x8530020", VA = "0x188531620")]
			private static quaternion MXZIMFATTYR(float3 a, float b)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x852F200", Offset = "0x852DC00", VA = "0x18852F200")]
			private static CurvePointData EANJTBLNRYV(int a, NativeList<PointSrcData> b)
			{
				return default(CurvePointData);
			}

			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x3C378C0", Offset = "0x3C362C0", VA = "0x183C378C0")]
			private void PCXZOYCZFIW<a>(NativeArray<Entity> a, NativeList<PointSrcData> b, float c, a d) where a : struct, TIMFDSGFSOV
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x8531AC0", Offset = "0x85304C0", VA = "0x188531AC0")]
			private void YNOTERBJECP(NativeList<PointSrcData> a, NativeList<CurvePointData> b, float c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x852EAC0", Offset = "0x852D4C0", VA = "0x18852EAC0")]
			public static float CTRQZRBSXIK(float3 a, float3 b, float3 c)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x852FFC0", Offset = "0x852E9C0", VA = "0x18852FFC0")]
			private static quaternion Lerp(quaternion q1, quaternion q2, float t)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x852F780", Offset = "0x852E180", VA = "0x18852F780")]
			private static CurvePointData IPNLQTUCVAI(PointSrcData a)
			{
				return default(CurvePointData);
			}

			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x852F8A0", Offset = "0x852E2A0", VA = "0x18852F8A0")]
			private static CurvePointData IPNLQTUCVAI(float3 a, quaternion b, float c)
			{
				return default(CurvePointData);
			}

			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x852F530", Offset = "0x852DF30", VA = "0x18852F530")]
			private static bool EBDNRAJJUWL(float3 a, float b, [Out] float3 c)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x8531550", Offset = "0x852FF50", VA = "0x188531550")]
			private static float3 MWOEODIEXJY(float3 a, float b)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x8531740", Offset = "0x8530140", VA = "0x188531740")]
			public static float3 PTAVZSQCYMM(quaternion a)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0x852F5D0", Offset = "0x852DFD0", VA = "0x18852F5D0")]
			public static float3 HKQKRHUTCBC(quaternion a)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x852FB60", Offset = "0x852E560", VA = "0x18852FB60")]
			private static quaternion LEMIVCJDFKJ(quaternion a, float3 b)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x852E8D0", Offset = "0x852D2D0", VA = "0x18852E8D0")]
			private static float Angle(float3 from, float3 to)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0x85316B0", Offset = "0x85300B0", VA = "0x1885316B0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x8535710", Offset = "0x8534110", VA = "0x188535710")]
			private void NKONCBHSVYX(DynamicBuffer<LinkedEntityGroup> a, int b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(RVA = "0x85352A0", Offset = "0x8533CA0", VA = "0x1885352A0")]
			[CompilerGenerated]
			public void CURJQMNILPU([In] ArchetypeChunk chunk, int a, bool b, [In] v128 chunkEnabledMask)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x85357F0", Offset = "0x85341F0", VA = "0x1885357F0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x85411A0", Offset = "0x853FBA0", VA = "0x1885411A0")]
			private void NKONCBHSVYX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0x8541190", Offset = "0x853FB90", VA = "0x188541190", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x8540DF0", Offset = "0x853F7F0", VA = "0x188540DF0")]
			private void NKONCBHSVYX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0x8540DE0", Offset = "0x853F7E0", VA = "0x188540DE0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x852E500", Offset = "0x852CF00", VA = "0x18852E500")]
			private void NKONCBHSVYX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0x852E4F0", Offset = "0x852CEF0", VA = "0x18852E4F0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x852E6D0", Offset = "0x852D0D0", VA = "0x18852E6D0")]
			private void NKONCBHSVYX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x852E6C0", Offset = "0x852D0C0", VA = "0x18852E6C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x853E5F0", Offset = "0x853CFF0", VA = "0x18853E5F0")]
			private void NKONCBHSVYX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x853E5E0", Offset = "0x853CFE0", VA = "0x18853E5E0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x8541200", Offset = "0x853FC00", VA = "0x188541200")]
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
		[Cpp2IlInjected.Address(RVA = "0x8536760", Offset = "0x8535160", VA = "0x188536760", Slot = "15")]
		public override void InitReferences(BDQJEHGTRBM services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x8537910", Offset = "0x8536310", VA = "0x188537910", Slot = "5")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x85379E0", Offset = "0x85363E0", VA = "0x1885379E0", Slot = "6")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x8537A40", Offset = "0x8536440", VA = "0x188537A40", Slot = "13")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x8537BB0", Offset = "0x85365B0", VA = "0x188537BB0")]
		private JobHandle THZKCCESGMI(EntityQuery a, Entity b, JobHandle c)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x8535800", Offset = "0x8534200", VA = "0x188535800")]
		private JobHandle FTXRMLVZHIQ(EntityQuery a, Entity b, JobHandle c)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x85369D0", Offset = "0x85353D0", VA = "0x1885369D0")]
		private JobHandle PIIPYRMZMPZ(NativeArray<int> a, NativeList<CurvePointData> b, JobHandle c)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x8536800", Offset = "0x8535200", VA = "0x188536800")]
		private JobHandle LHXAAEKYKWG(NativeList<CurvePointData> a, NativeArray<int> b, JobHandle c)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x8536EA0", Offset = "0x85358A0", VA = "0x188536EA0")]
		private JobHandle LQNZIAYCFEH(EntityQuery a, NativeList<RecRoom.Foundation.Collections.Range> b, NativeList<CurvePointData> c, NativeArray<int> d, JobHandle e)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x8537520", Offset = "0x8535F20", VA = "0x188537520")]
		private JobHandle NJEHJGXQMDF(EntityCommandBuffer a, JobHandle b)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x85373F0", Offset = "0x8535DF0", VA = "0x1885373F0")]
		private JobHandle LVOEYIXEVIM(NativeArray<int> a, JobHandle b)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x8538450", Offset = "0x8536E50", VA = "0x188538450")]
		private JobHandle VWNXWKBWDRP(EntityQuery a, [Out] NativeList<Entity> b, [Out] NativeList<Entity> c, [Out] NativeList<BakedPrimitiveData> d, [Out] NativeParallelHashSet<Entity> e, JobHandle f, Allocator g = Allocator.TempJob)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x8538B60", Offset = "0x8537560", VA = "0x188538B60")]
		private JobHandle ZFZPTHLNRSV(EntityQuery a, [Out] NativeList<Entity> b, [Out] NativeList<Entity> c, [Out] NativeList<RecRoom.Foundation.Collections.Range> d, [Out] NativeList<BakedSplineData> e, [Out] NativeParallelHashSet<Entity> f, JobHandle g, Allocator h = Allocator.TempJob)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x8536070", Offset = "0x8534A70", VA = "0x188536070")]
		private JobHandle IWBUWMHXTRA(NativeList<Entity> a, NativeList<Entity> b, EntityCommandBuffer c, JobHandle d)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x8537EB0", Offset = "0x85368B0", VA = "0x188537EB0")]
		private JobHandle TSTWIQDTAKE(EntityQuery a, NativeList<BakedPrimitiveData> b, JobHandle c)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x8536A80", Offset = "0x8535480", VA = "0x188536A80")]
		private static NativeParallelHashMap<int, PrimitiveShapeMeshType> LNTXQGAQMGC()
		{
			return default(NativeParallelHashMap<int, PrimitiveShapeMeshType>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x8538710", Offset = "0x8537110", VA = "0x188538710")]
		private JobHandle YWIHFAJNSZY(EntityQuery a, NativeList<RecRoom.Foundation.Collections.Range> b, NativeList<CurvePointData> c, NativeList<BakedSplineData> d, JobHandle e)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x85376F0", Offset = "0x85360F0", VA = "0x1885376F0")]
		private JobHandle OHTPYUZBIUB(EntityCommandBuffer.ParallelWriter a, JobHandle b)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x85369D0", Offset = "0x85353D0", VA = "0x1885369D0")]
		private JobHandle KTLFVUCDZCX(NativeArray<int> a, NativeList<CurvePointData> b, JobHandle c)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x8536800", Offset = "0x8535200", VA = "0x188536800")]
		private JobHandle KFDYKIECXCC(NativeList<CurvePointData> a, NativeArray<int> b, JobHandle c)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x8535F60", Offset = "0x8534960", VA = "0x188535F60")]
		private JobHandle IRKXPGGOKFT(EntityQueryInJob a, EntityTypeHandle b, ComponentTypeHandle<ParentData> c, NativeList<Entity> d, NativeList<Entity> e, NativeParallelHashSet<Entity> f, NativeList<BakedPrimitiveData> g, JobHandle h)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x85368A0", Offset = "0x85352A0", VA = "0x1885368A0")]
		private JobHandle KFFDAEQNVRH(EntityQueryInJob a, EntityTypeHandle b, ComponentTypeHandle<ParentData> c, NativeList<Entity> d, NativeList<Entity> e, NativeParallelHashSet<Entity> f, NativeList<RecRoom.Foundation.Collections.Range> g, NativeList<BakedSplineData> h, JobHandle i)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x8538E30", Offset = "0x8537830", VA = "0x188538E30")]
		private JobHandle ZZJGYYJOIPA(NativeList<Entity> a, NativeList<Entity> b, EntityCommandBuffer c, BufferLookup<ChildBuffer> d, BufferLookup<AuthoredChildBuffer> e, JobHandle f)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x8536370", Offset = "0x8534D70", VA = "0x188536370")]
		private void IYMAEQHVYUI(SystemState a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x8537880", Offset = "0x8536280", VA = "0x188537880", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x2E39A00", Offset = "0x2E38400", VA = "0x182E39A00")]
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
		[Cpp2IlInjected.Address(RVA = "0x852DDC0", Offset = "0x852C7C0", VA = "0x18852DDC0", Slot = "14")]
		public void InitReferences(BDQJEHGTRBM services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x852DE10", Offset = "0x852C810", VA = "0x18852DE10", Slot = "13")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x2B87B90", Offset = "0x2B86590", VA = "0x182B87B90")]
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
				[Cpp2IlInjected.Address(RVA = "0x409CD30", Offset = "0x409B730", VA = "0x18409CD30")]
				get
				{
					return default((Entity, Transform, NativeArray<T>));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x409D450", Offset = "0x409BE50", VA = "0x18409D450")]
			public DescriptorSetEnumerator(EntityManager entityManager, EntityDataArrays<T> set, NativeArray<EntityRemapUtility.EntityRemapInfo> entityRemapping)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x4059AA0", Offset = "0x40584A0", VA = "0x184059AA0")]
			public DescriptorSetEnumerator<T> GetEnumerator()
			{
				return default(DescriptorSetEnumerator<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x409C6F0", Offset = "0x409B0F0", VA = "0x18409C6F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8539AB0", Offset = "0x85384B0", VA = "0x188539AB0", Slot = "15")]
		public override void InitReferences(BDQJEHGTRBM services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x85393F0", Offset = "0x8537DF0", VA = "0x1885393F0")]
		public void GGZFKITVEVE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x853B0A0", Offset = "0x8539AA0", VA = "0x18853B0A0", Slot = "13")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x853BE70", Offset = "0x853A870", VA = "0x18853BE70")]
		private void SCCNKZYPJUA(BakedShapeColliderMessage a, Mesh[] b, NativeArray<EntityRemapUtility.EntityRemapInfo> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x38F3840", Offset = "0x38F2240", VA = "0x1838F3840")]
		private DescriptorSetEnumerator<T> CFSAXRPWVEJ<T>(EntityDataArrays<T> a, NativeArray<EntityRemapUtility.EntityRemapInfo> b) where T : struct
		{
			return default(DescriptorSetEnumerator<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x853D360", Offset = "0x853BD60", VA = "0x18853D360")]
		private void ZDMLFGAJLML(Transform a, NativeArray<SphereDescriptor> b, UQNUASLZIEC<GameObject> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x8539640", Offset = "0x8538040", VA = "0x188539640")]
		private void IPAUMRJFXOZ(Transform a, NativeArray<BoxDescriptor> b, UQNUASLZIEC<GameObject> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x853ACF0", Offset = "0x85396F0", VA = "0x18853ACF0")]
		private void NBWGLUHWWXB(Transform a, NativeArray<CapsuleDescriptor> b, UQNUASLZIEC<GameObject> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x8538FE0", Offset = "0x85379E0", VA = "0x188538FE0")]
		private void EGKRDGJIDLV(Transform a, NativeArray<MeshDescriptor> b, Mesh[] c, UQNUASLZIEC<GameObject> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x8539420", Offset = "0x8537E20", VA = "0x188539420")]
		private static void ILLHZEIFCIG(NativeParallelHashSet<Entity> a, NativeParallelHashSet<Entity> b, NativeArray<EntityRemapUtility.EntityRemapInfo> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x853CCA0", Offset = "0x853B6A0", VA = "0x18853CCA0")]
		private static void SMGCPFRTPWY(NativeList<Entity> a, NativeArray<EntityRemapUtility.EntityRemapInfo> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x8539B30", Offset = "0x8538530", VA = "0x188539B30")]
		private NativeParallelHashMap<Entity, RenderRootHandleData> JTPXHWWKSCS(FWMYYWYXLKW.SplineMessageQueueScope a, MessageQueueScope<BakedPrimitiveMessage> b, List<GameObject> c)
		{
			return default(NativeParallelHashMap<Entity, RenderRootHandleData>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x853CDB0", Offset = "0x853B7B0", VA = "0x18853CDB0")]
		private NativeArray<EntityRemapUtility.EntityRemapInfo> VRWJPOVFOLF(Entity a)
		{
			return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x853A6F0", Offset = "0x85390F0", VA = "0x18853A6F0")]
		private void LSOMYYFNIEK(NativeList<Entity> a, NativeList<Entity> b, NativeParallelHashMap<Entity, RenderRootHandleData> c, NativeList<RecRoom.Foundation.Collections.Range> d, NativeList<CurvePointData> e, NativeList<BakedSplineData> f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x853CEC0", Offset = "0x853B8C0", VA = "0x18853CEC0")]
		private void WFOPEDSEIAI(NativeList<Entity> a, NativeList<Entity> b, NativeParallelHashMap<Entity, RenderRootHandleData> c, NativeList<BakedPrimitiveData> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x2E39A00", Offset = "0x2E38400", VA = "0x182E39A00")]
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
			[Cpp2IlInjected.Address(RVA = "0xAB6980", Offset = "0xAB5380", VA = "0x180AB6980", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public UniformTRS YSKLWSGEOOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x85486A0", Offset = "0x85470A0", VA = "0x1885486A0", Slot = "8")]
			get
			{
				return default(UniformTRS);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		private Vector3 XROSGNAWEBE
		{
			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0x8548800", Offset = "0x8547200", VA = "0x188548800", Slot = "10")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		private Matrix4x4 KBHQZWJZRJY
		{
			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x85487C0", Offset = "0x85471C0", VA = "0x1885487C0", Slot = "9")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		private Vector3 WSCXPJLCEWK
		{
			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x8548980", Offset = "0x8547380", VA = "0x188548980", Slot = "4")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x8548900", Offset = "0x8547300", VA = "0x188548900", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		private Quaternion RMQMRPXTJKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x8548940", Offset = "0x8547340", VA = "0x188548940", Slot = "6")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x8548840", Offset = "0x8547240", VA = "0x188548840", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		private Vector3 JWHZVFDJUJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x8548780", Offset = "0x8547180", VA = "0x188548780", Slot = "11")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		private Vector3 UUXFCCJJLQQ
		{
			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x85488C0", Offset = "0x85472C0", VA = "0x1885488C0", Slot = "13")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		private Vector3 YRABQVTWQCK
		{
			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x8548880", Offset = "0x8547280", VA = "0x188548880", Slot = "14")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x85489C0", Offset = "0x85473C0", VA = "0x1885489C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x8547110", Offset = "0x8545B10", VA = "0x188547110", Slot = "17")]
			get
			{
				return default(RRTransform);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		private UniformTRS QJJWDEVXOAE
		{
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x8547150", Offset = "0x8545B50", VA = "0x188547150", Slot = "18")]
			get
			{
				return default(UniformTRS);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		private float GHDNQTBSPHJ
		{
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0xBC1D00", Offset = "0xBC0700", VA = "0x180BC1D00", Slot = "19")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		private Vector3 YZRQXSYAEJW
		{
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x85470C0", Offset = "0x8545AC0", VA = "0x1885470C0", Slot = "20")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		private ShapeColor BJTQJDTUOWM
		{
			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0xD28600", Offset = "0xD27000", VA = "0x180D28600", Slot = "21")]
			get
			{
				return default(ShapeColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		private ShapeMaterial EDIPPAYWOAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x13C3A10", Offset = "0x13C2410", VA = "0x1813C3A10", Slot = "22")]
			get
			{
				return default(ShapeMaterial);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		private bool EGRONOLBWXV
		{
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0xB00160", Offset = "0xAFEB60", VA = "0x180B00160", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool SEAJNUYQXJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0xB00160", Offset = "0xAFEB60", VA = "0x180B00160", Slot = "15")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0xAB6970", Offset = "0xAB5370", VA = "0x180AB6970")]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x8547230", Offset = "0x8545C30", VA = "0x188547230")]
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
			[Cpp2IlInjected.Address(RVA = "0x108D6F0", Offset = "0x108C0F0", VA = "0x18108D6F0")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		protected Entity PUYIGWQPGXG
		{
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x8546170", Offset = "0x8544B70", VA = "0x188546170")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		protected ONAYZPPBQDG AFKEDAVVOGV
		{
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x8546C60", Offset = "0x8545660", VA = "0x188546C60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		protected EQEGGVHWOFO CPSGYPFYNRN
		{
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x8546C00", Offset = "0x8545600", VA = "0x188546C00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		protected JRXTOINJVYB DBQHIYWLHGS
		{
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x85465F0", Offset = "0x8544FF0", VA = "0x1885465F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		private GameObject KWMQERUERKI
		{
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x8546680", Offset = "0x8545080", VA = "0x188546680", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public UniformTRS YSKLWSGEOOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x10C3A50", Offset = "0x10C2450", VA = "0x1810C3A50", Slot = "8")]
			get
			{
				return default(UniformTRS);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		private Vector3 XROSGNAWEBE
		{
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x85463F0", Offset = "0x8544DF0", VA = "0x1885463F0", Slot = "10")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		private Matrix4x4 KBHQZWJZRJY
		{
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x8546280", Offset = "0x8544C80", VA = "0x188546280", Slot = "9")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		private Vector3 WSCXPJLCEWK
		{
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x8546D90", Offset = "0x8545790", VA = "0x188546D90", Slot = "4")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x8546AF0", Offset = "0x85454F0", VA = "0x188546AF0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		private Quaternion RMQMRPXTJKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x8546C70", Offset = "0x8545670", VA = "0x188546C70", Slot = "6")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x85464E0", Offset = "0x8544EE0", VA = "0x1885464E0", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		private Vector3 JWHZVFDJUJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x8546190", Offset = "0x8544B90", VA = "0x188546190", Slot = "11")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		private Vector3 UUXFCCJJLQQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x85468D0", Offset = "0x85452D0", VA = "0x1885468D0", Slot = "13")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		private Vector3 YRABQVTWQCK
		{
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x85466B0", Offset = "0x85450B0", VA = "0x1885466B0", Slot = "14")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0xCD8C40", Offset = "0xCD7640", VA = "0x180CD8C40")]
		protected JXUTGYSCVMT(ObjectLocalId a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x8546EC0", Offset = "0x85458C0", VA = "0x188546EC0")]
		public static implicit operator RRTransform(JXUTGYSCVMT t)
		{
			return default(RRTransform);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public static class ZMLXMOXQWLC
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x8548A10", Offset = "0x8547410", VA = "0x188548A10")]
		public static void NIXQMBDDVIF(NativeArray<Entity> a, EntityManager b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public static class VRZTRNBZIXJ
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x8547C80", Offset = "0x8546680", VA = "0x188547C80")]
		public static void CUWTZNCYXAL(NativeArray<Entity> a, EntityManager b, NUOTBWOORLZ c, ONAYZPPBQDG d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x8548380", Offset = "0x8546D80", VA = "0x188548380")]
		public static void ZRTAGKTSEKA(NativeArray<Entity> a, EntityManager b, NUOTBWOORLZ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x85480A0", Offset = "0x8546AA0", VA = "0x1885480A0")]
		public static NativeList<Entity> IHAGEESEBVD(NativeArray<Entity> a, EntityManager b)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x8547C50", Offset = "0x8546650", VA = "0x188547C50")]
		public static NativeList<Entity> APCFSRRFPNC(NativeArray<Entity> a, EntityManager b)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x85480D0", Offset = "0x8546AD0", VA = "0x1885480D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x8547510", Offset = "0x8545F10", VA = "0x188547510")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		protected PHSLCENMBKR CLQAVDMRWSF
		{
			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x8547480", Offset = "0x8545E80", VA = "0x188547480")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		protected ShapeConfigData OTZKNGPEABQ
		{
			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x85472B0", Offset = "0x8545CB0", VA = "0x1885472B0")]
			get
			{
				return default(ShapeConfigData);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		private RRTransform OOMLMIZVTUI
		{
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x8546EC0", Offset = "0x85458C0", VA = "0x188546EC0", Slot = "17")]
			get
			{
				return default(RRTransform);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		private float GHDNQTBSPHJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0xB06880", Offset = "0xB05280", VA = "0x180B06880", Slot = "19")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		private Vector3 YZRQXSYAEJW
		{
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x1195E20", Offset = "0x1194820", VA = "0x181195E20", Slot = "20")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		private ShapeColor BJTQJDTUOWM
		{
			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0xABBD70", Offset = "0xABA770", VA = "0x180ABBD70", Slot = "21")]
			get
			{
				return default(ShapeColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		private ShapeMaterial EDIPPAYWOAA
		{
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0xB45A80", Offset = "0xB44480", VA = "0x180B45A80", Slot = "22")]
			get
			{
				return default(ShapeMaterial);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		private UniformTRS QJJWDEVXOAE
		{
			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x10C3A50", Offset = "0x10C2450", VA = "0x1810C3A50", Slot = "18")]
			get
			{
				return default(UniformTRS);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public bool SEAJNUYQXJH
		{
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0xB199C0", Offset = "0xB183C0", VA = "0x180B199C0", Slot = "15")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0xB1A4D0", Offset = "0xB18ED0", VA = "0x180B1A4D0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		private bool EGRONOLBWXV
		{
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0xB00160", Offset = "0xAFEB60", VA = "0x180B00160", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x8547860", Offset = "0x8546260", VA = "0x188547860")]
		protected SRXRINAIIBB(ObjectLocalId a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0xAB6970", Offset = "0xAB5370", VA = "0x180AB6970", Slot = "25")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x8547660", Offset = "0x8546060", VA = "0x188547660", Slot = "26")]
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
			[Cpp2IlInjected.Address(RVA = "0x8546FB0", Offset = "0x85459B0", VA = "0x188546FB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		protected WLURUBZSQIN RTFKLEJHCYM
		{
			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x8546EF0", Offset = "0x85458F0", VA = "0x188546EF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		protected bool CYDNYNTHLGJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x8547000", Offset = "0x8545A00", VA = "0x188547000")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x8546F40", Offset = "0x8545940", VA = "0x188546F40", Slot = "15")]
		public virtual void InitReferences(BDQJEHGTRBM services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x2B87B90", Offset = "0x2B86590", VA = "0x182B87B90")]
		[UnityEngine.Scripting.Preserve]
		protected MHJPKHMAAFN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public static class IGMKOUAKCYG
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x8545F10", Offset = "0x8544910", VA = "0x188545F10")]
		public static void JLVOTFPIYLE(NativeArray<Entity> a, EntityManager b)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__245627889
{
	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x8548C80", Offset = "0x8547680", VA = "0x188548C80")]
	public static void JTEJSBRAGJR()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x8548C70", Offset = "0x8547670", VA = "0x188548C70")]
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
