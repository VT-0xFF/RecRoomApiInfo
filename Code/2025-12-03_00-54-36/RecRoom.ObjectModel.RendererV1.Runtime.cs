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
		[Cpp2IlInjected.Address(RVA = "0xABFE50", Offset = "0xABEA50", VA = "0x180ABFE50")]
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
		[Cpp2IlInjected.Address(RVA = "0xABFE50", Offset = "0xABEA50", VA = "0x180ABFE50")]
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
		[Cpp2IlInjected.Address(RVA = "0x83C10A0", Offset = "0x83BFCA0", VA = "0x1883C10A0", Slot = "4")]
		public override void OGBNJYRINGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xABFE50", Offset = "0xABEA50", VA = "0x180ABFE50")]
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
		private int[] RXQWJMLBFSB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private ServiceBitset DXAPYCEYZZY;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xA98640", Offset = "0xA97240", VA = "0x180A98640", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8377000", Offset = "0x8375C00", VA = "0x188377000", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x83CFD90", Offset = "0x83CE990", VA = "0x1883CFD90")]
		private void JGBTHBSKOEG(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x83D02F0", Offset = "0x83CEEF0", VA = "0x1883D02F0", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x83D0350", Offset = "0x83CEF50", VA = "0x1883D0350")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class RRNLZYUDTEG
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x83CC4C0", Offset = "0x83CB0C0", VA = "0x1883CC4C0")]
		public static Quaternion PXYHZFCBXRV([In] this RRObjectSplinePoint splinePoint, [In] Vector3 direction)
		{
			return default(Quaternion);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class JRWELAHLUFL
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x83BFCC0", Offset = "0x83BE8C0", VA = "0x1883BFCC0")]
		public static bool UCHJXBGATUD(this RRObjectShapeSpline a, ShapeConfigFlags b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x83BFC90", Offset = "0x83BE890", VA = "0x1883BFC90")]
		public static bool TUBPIPSNIIT(this RRObjectShapeSpline a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x83BFD00", Offset = "0x83BE900", VA = "0x1883BFD00")]
		public static bool XGFSWYNSCGC(this RRObjectShapeSpline a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x83BE700", Offset = "0x83BD300", VA = "0x1883BE700")]
		public static void FDYWOMBATUJ(this RRObjectShapeSpline a, Vector3 b, Quaternion c, float d, bool e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x83BFF20", Offset = "0x83BEB20", VA = "0x1883BFF20")]
		public static void ZQGOSHWYKIZ(this RRObjectShapeSpline a, Vector3 b, Quaternion c, float d, int e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x83BE830", Offset = "0x83BD430", VA = "0x1883BE830")]
		public static void HDWCSFPJTSB(this RRObjectShapeSpline a, int b, Vector3 c, Quaternion d, float e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x83BE6B0", Offset = "0x83BD2B0", VA = "0x1883BE6B0")]
		public static void DLEBBIVPAIQ(this RRObjectShapeSpline a, Vector3 b, Quaternion c, float d, bool e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x83BEE10", Offset = "0x83BDA10", VA = "0x1883BEE10")]
		private static void OQKCMJIQAIB(this RRObjectShapeSpline a, Vector3 b, Quaternion c, float d, bool e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x83BE4F0", Offset = "0x83BD0F0", VA = "0x1883BE4F0")]
		private static void BYTKEEBQSYX(this RRObjectShapeSpline a, Vector3 b, Quaternion c, float d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x83BFD30", Offset = "0x83BE930", VA = "0x1883BFD30")]
		private static void XHWFMGJCSYD(this RRObjectShapeSpline a, int b, Vector3 c, Quaternion d, float e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x83BFC60", Offset = "0x83BE860", VA = "0x1883BFC60")]
		private static bool RUDUUPWHLUB(this RRObjectShapeSpline a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x83BE950", Offset = "0x83BD550", VA = "0x1883BE950")]
		private static void JGPVYWCSPKT(this RRObjectShapeSpline a, int b, Vector3 c, Quaternion d, float e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x83BF770", Offset = "0x83BE370", VA = "0x1883BF770")]
		public static Vector3 PVPMXRQOECO(this RRObjectShapeSpline a, int b)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x83BE3E0", Offset = "0x83BCFE0", VA = "0x1883BE3E0")]
		public static Quaternion BBYSLLKQPCX(this RRObjectShapeSpline a, int b)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x83BEBF0", Offset = "0x83BD7F0", VA = "0x1883BEBF0")]
		public static Vector3 NIYTPRVEBHM(ShapeConfigFlags a, Vector3 b, Vector3? c, Vector3 d)
		{
			return default(Vector3);
		}
	}
}
namespace RecRoom.ObjectModel.RendererV1
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	internal interface GLHQNCHNLUL
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void WPMNERROCOY(EntityQuery a, EntityManager b, NPBCYDBOKXW c, ZGUWCEMGOVJ d);
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	internal interface GGFMVAZUYBT
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		ComponentType WTLTZFKQOHK
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void OMQYDKRCTHC(EntityQuery a, ZSRZVAZPBAN b);

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void VSYAZTHUZBZ(EntityQuery a, ZSRZVAZPBAN b);

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void JAUNIGFHEQT(ZSRZVAZPBAN a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	internal class SAENNMGHSLA : GLHQNCHNLUL
	{
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static readonly Log JVTVAZRWBFB;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x83CEDD0", Offset = "0x83CD9D0", VA = "0x1883CEDD0", Slot = "4")]
		public void WPMNERROCOY(EntityQuery a, EntityManager b, NPBCYDBOKXW c, ZGUWCEMGOVJ d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public SAENNMGHSLA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	internal class EIEKCDPKDKG : GLHQNCHNLUL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly SelectionEffectType BZBYSNBZZQW;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xAA1F30", Offset = "0xAA0B30", VA = "0x180AA1F30")]
		public EIEKCDPKDKG(SelectionEffectType a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x83B7950", Offset = "0x83B6550", VA = "0x1883B7950", Slot = "4")]
		public void WPMNERROCOY(EntityQuery a, EntityManager b, NPBCYDBOKXW c, ZGUWCEMGOVJ d)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	internal class EORRWWEYCBA : GLHQNCHNLUL
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x83B7AC0", Offset = "0x83B66C0", VA = "0x1883B7AC0", Slot = "4")]
		public void WPMNERROCOY(EntityQuery a, EntityManager b, NPBCYDBOKXW c, ZGUWCEMGOVJ d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public EORRWWEYCBA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class NQUVTTSFUGO : GGFMVAZUYBT
	{
		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public ComponentType WTLTZFKQOHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x83C1DE0", Offset = "0x83C09E0", VA = "0x1883C1DE0", Slot = "4")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x83C1B40", Offset = "0x83C0740", VA = "0x1883C1B40", Slot = "5")]
		public void OMQYDKRCTHC(EntityQuery a, ZSRZVAZPBAN b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x83C1E40", Offset = "0x83C0A40", VA = "0x1883C1E40", Slot = "6")]
		public void VSYAZTHUZBZ(EntityQuery a, ZSRZVAZPBAN b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x83C1AF0", Offset = "0x83C06F0", VA = "0x1883C1AF0", Slot = "7")]
		public void JAUNIGFHEQT(ZSRZVAZPBAN a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public NQUVTTSFUGO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class QUFKFOVGGBU : GGFMVAZUYBT
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public ComponentType WTLTZFKQOHK
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x83CB490", Offset = "0x83CA090", VA = "0x1883CB490", Slot = "4")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x83CB1F0", Offset = "0x83C9DF0", VA = "0x1883CB1F0", Slot = "5")]
		public void OMQYDKRCTHC(EntityQuery a, ZSRZVAZPBAN b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x83CB4F0", Offset = "0x83CA0F0", VA = "0x1883CB4F0", Slot = "6")]
		public void VSYAZTHUZBZ(EntityQuery a, ZSRZVAZPBAN b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x83CB1A0", Offset = "0x83C9DA0", VA = "0x1883CB1A0", Slot = "7")]
		public void JAUNIGFHEQT(ZSRZVAZPBAN a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public QUFKFOVGGBU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class CLJWPANXNSC : GGFMVAZUYBT
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public ComponentType WTLTZFKQOHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x83B6E60", Offset = "0x83B5A60", VA = "0x1883B6E60", Slot = "4")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x83B6BC0", Offset = "0x83B57C0", VA = "0x1883B6BC0", Slot = "5")]
		public void OMQYDKRCTHC(EntityQuery a, ZSRZVAZPBAN b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x83B6EC0", Offset = "0x83B5AC0", VA = "0x1883B6EC0", Slot = "6")]
		public void VSYAZTHUZBZ(EntityQuery a, ZSRZVAZPBAN b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x83B6B70", Offset = "0x83B5770", VA = "0x1883B6B70", Slot = "7")]
		public void JAUNIGFHEQT(ZSRZVAZPBAN a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public CLJWPANXNSC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal class NCZKBRFPKWN : YRYAHHXHMLV, KWODXIHZOSZ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private NPBCYDBOKXW OKLMDKLKPBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private RMAWLSSLTVK SHBNZKEESYY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private ZGUWCEMGOVJ DXRXGEOSQPR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private List<(EntityQuery query, GLHQNCHNLUL adapter)> ADBZUEXKMTF;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x83C1490", Offset = "0x83C0090", VA = "0x1883C1490", Slot = "15")]
		public virtual void InitReferences(FRTNUJPZGKS services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x83C1520", Offset = "0x83C0120", VA = "0x1883C1520", Slot = "5")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x83C1990", Offset = "0x83C0590", VA = "0x1883C1990")]
		private void RJPLUSPXLKH(EntityQueryDesc a, GLHQNCHNLUL b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x83C1710", Offset = "0x83C0310", VA = "0x1883C1710", Slot = "13")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x2B5D980", Offset = "0x2B5C580", VA = "0x182B5D980")]
		[UnityEngine.Scripting.Preserve]
		public NCZKBRFPKWN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[SystemEnabledLifetime(Lifetime.LoadInstance)]
	internal class RenderShapeEffectsSystem : YRYAHHXHMLV, KWODXIHZOSZ
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		private class Effect
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public EntityQuery CPHKURFVPXU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public EntityQuery VTSLTXDEQEC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public EntityQuery NTMMJHSQTMV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public EntityQuery TIDFCWOXBUT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public EntityQuery FKUFFWAFXKV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public EntityQuery LYEUWBAHLAQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public EntityQuery HUNKMQHZEES;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public GGFMVAZUYBT PBSHOQCJKHX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public ComponentType UKZDPAEBTWI;

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public Effect()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly Log JVTVAZRWBFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private NPBCYDBOKXW OKLMDKLKPBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private ZGUWCEMGOVJ DXRXGEOSQPR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private RMAWLSSLTVK SHBNZKEESYY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private List<Effect> ADBZUEXKMTF;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x83CDD70", Offset = "0x83CC970", VA = "0x1883CDD70", Slot = "14")]
		public void InitReferences(FRTNUJPZGKS services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x83CDE00", Offset = "0x83CCA00", VA = "0x1883CDE00", Slot = "5")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x83CDF80", Offset = "0x83CCB80", VA = "0x1883CDF80", Slot = "13")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x83CE8C0", Offset = "0x83CD4C0", VA = "0x1883CE8C0")]
		private void WTAPMGVTUTI(Effect a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x83CE190", Offset = "0x83CCD90", VA = "0x1883CE190")]
		private void RJPLUSPXLKH(GGFMVAZUYBT a, ComponentType b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x2B5D980", Offset = "0x2B5C580", VA = "0x182B5D980")]
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
	[RegisterService(typeof(ZGUWCEMGOVJ), new string[] { })]
	public class XLNBZHRQFYW : ZGUWCEMGOVJ
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public OutlineEffectType LMTPRDODFKW
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xA95110", Offset = "0xA93D10", VA = "0x180A95110", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(OutlineEffectType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xAA2D20", Offset = "0xAA1920", VA = "0x180AA2D20", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public XLNBZHRQFYW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[RegisterService(typeof(YMWLXYRBIAP), new string[] { })]
	public class QXTYVQZFKHC : YMWLXYRBIAP, BIXNJLOAVRQ, KVDAJIKJIJC, GGXGSUREAZS, HJESUUHTFVQ, IQIQMYLKLGS, GWUWQZCMFZU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[DependsOn]
		private DCYCHNIZCRD YKYCUJBVBVX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[DependsOn]
		private NPBCYDBOKXW OKLMDKLKPBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		[DependsOn]
		private KYJOVNSGQOU KYDLRIVYHCV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private EntityQuery UKMDHWNTODG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private EntityQuery RSIXTBLLLFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private bool CDCGATQZZIT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private Entity VMPPVDLRZGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private RootHandle WQFBTEFVADM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private Entity IFPRCFCBMAT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private RootHandle ISUEMPAZDKF;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private EntityManager IAFZDHKKZKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x83CC3B0", Offset = "0x83CAFB0", VA = "0x1883CC3B0")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public int GXQLIXOTEAX
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x83CC240", Offset = "0x83CAE40", VA = "0x1883CC240", Slot = "7")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int LEEPQYQBMXA
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x83CBDF0", Offset = "0x83CA9F0", VA = "0x1883CBDF0", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x83CC260", Offset = "0x83CAE60", VA = "0x1883CC260", Slot = "4")]
		public bool ONEGVUONLIG(ObjectLocalId a, MutableRef b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x83CBF40", Offset = "0x83CAB40", VA = "0x1883CBF40", Slot = "5")]
		public RootHandle NNMGIIGAVLS()
		{
			return default(RootHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x83CB820", Offset = "0x83CA420", VA = "0x1883CB820", Slot = "6")]
		public RootHandle EDERZJDQUZN()
		{
			return default(RootHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x83CBE10", Offset = "0x83CAA10", VA = "0x1883CBE10", Slot = "9")]
		public void InitExternal(FRTNUJPZGKS services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x83CC480", Offset = "0x83CB080", VA = "0x1883CC480", Slot = "11")]
		public void PUBZWIFCMXS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x83CBB20", Offset = "0x83CA720", VA = "0x1883CBB20", Slot = "10")]
		public void FTKRTFERMFY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x83CB790", Offset = "0x83CA390", VA = "0x1883CB790", Slot = "12")]
		private void ECGVZCYOEDK(FRTNUJPZGKS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x109D220", Offset = "0x109BE20", VA = "0x18109D220", Slot = "13")]
		private void RXSKOFHNRCQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public QXTYVQZFKHC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[RegisterService(typeof(LCJBONQDWIC), new string[] { })]
	public class CCOZDZPJPNT : LCJBONQDWIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x83B6260", Offset = "0x83B4E60", VA = "0x1883B6260", Slot = "4")]
		public void PDNUNETUJKA(World a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x83B6150", Offset = "0x83B4D50", VA = "0x1883B6150", Slot = "5")]
		public void MPNVPTBVTJG(World a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x83B6100", Offset = "0x83B4D00", VA = "0x1883B6100", Slot = "6")]
		public ComponentSystemBase JLIZIYDLKBB(World a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x83B61A0", Offset = "0x83B4DA0", VA = "0x1883B61A0", Slot = "7")]
		public void NAYWQFXPPZF(World a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x83B6030", Offset = "0x83B4C30", VA = "0x1883B6030", Slot = "8")]
		public void CKGUWISNFCO(World a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x83B6200", Offset = "0x83B4E00", VA = "0x1883B6200", Slot = "9")]
		public void NVWTWYNPPMD(World a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x83B6090", Offset = "0x83B4C90", VA = "0x1883B6090", Slot = "10")]
		public void FLCRJLDQEGW(World a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x83B62F0", Offset = "0x83B4EF0", VA = "0x1883B62F0", Slot = "11")]
		public NativeParallelHashSet<ComponentTypeIndex> VLQOOQDLWMB()
		{
			return default(NativeParallelHashSet<ComponentTypeIndex>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public CCOZDZPJPNT()
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
	public class KITLOOLVPVB : IComponentData, ICloneable, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public KLWGPMMPZHN QMFHXRKKPKE
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xA974F0", Offset = "0xA960F0", VA = "0x180A974F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0xA974E0", Offset = "0xA960E0", VA = "0x180A974E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x83C0AC0", Offset = "0x83BF6C0", VA = "0x1883C0AC0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x83C0A50", Offset = "0x83BF650", VA = "0x1883C0A50", Slot = "4")]
		public object Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		[UnityEngine.Scripting.Preserve]
		public KITLOOLVPVB()
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
		[Cpp2IlInjected.Address(RVA = "0xB15960", Offset = "0xB14560", VA = "0x180B15960")]
		public static implicit operator RenderRootHandleData(RootHandle handle)
		{
			return default(RenderRootHandleData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public class IAAUSCSAXRI : ICleanupComponentData, IComponentData, ICloneable
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public QFRPELZEUNM PGLZYTMQCFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xA974F0", Offset = "0xA960F0", VA = "0x180A974F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xA974E0", Offset = "0xA960E0", VA = "0x180A974E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x83BD160", Offset = "0x83BBD60", VA = "0x1883BD160", Slot = "4")]
		public object Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		[UnityEngine.Scripting.Preserve]
		public IAAUSCSAXRI()
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
		[Cpp2IlInjected.Address(RVA = "0xB15960", Offset = "0xB14560", VA = "0x180B15960")]
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
		[Cpp2IlInjected.Address(RVA = "0xB15960", Offset = "0xB14560", VA = "0x180B15960")]
		public static implicit operator ShapeRootHandleData(RootHandle handle)
		{
			return default(ShapeRootHandleData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class JGFTFWCMKIJ : IComponentData, ICloneable, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public GELSQMPXNCN JFETAICIDCG
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0xA974F0", Offset = "0xA960F0", VA = "0x180A974F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0xA974E0", Offset = "0xA960E0", VA = "0x180A974E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x83BD240", Offset = "0x83BBE40", VA = "0x1883BD240", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x83BD1D0", Offset = "0x83BBDD0", VA = "0x1883BD1D0", Slot = "4")]
		public object Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		[UnityEngine.Scripting.Preserve]
		public JGFTFWCMKIJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public class ZRLVZMZSLZQ : WXNTWJSLSLU, KLWGPMMPZHN, QUUITLXOWYH, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public PrimitiveShapeMeshType VECJMTQCXMA
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xBAC640", Offset = "0xBAB240", VA = "0x180BAC640", Slot = "27")]
			[CompilerGenerated]
			get
			{
				return default(PrimitiveShapeMeshType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool FNHLJFUFGFQ
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x131CEE0", Offset = "0x131BAE0", VA = "0x18131CEE0", Slot = "28")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public float3 IHVVYLASSLQ
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0xFB7BB0", Offset = "0xFB67B0", VA = "0x180FB7BB0", Slot = "29")]
			[CompilerGenerated]
			get
			{
				return default(float3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x83CFCF0", Offset = "0x83CE8F0", VA = "0x1883CFCF0")]
		public ZRLVZMZSLZQ(UniformTRS a, RRObject b, float c, float3 d, ShapeColor e, ShapeMaterial f, PrimitiveShapeMeshType g, float3 h, bool i)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x83CFC90", Offset = "0x83CE890", VA = "0x1883CFC90", Slot = "25")]
		public override UnityEngine.Hash128 ComputeHash()
		{
			return default(UnityEngine.Hash128);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "26")]
		public override void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class LNUUNDJCHNU : WXNTWJSLSLU, GELSQMPXNCN, QUUITLXOWYH, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private NativeArray<CurvePointData> MOCSHNABMMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private readonly SplineParameterFlags PLRGPZIUHQT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private readonly float MXGWGXIIQFW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private readonly int CEQBPTXWZWA;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool ROCPEOPPHDR
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x83C0C80", Offset = "0x83BF880", VA = "0x1883C0C80", Slot = "27")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool NBQPOQNXRWP
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x83C0CA0", Offset = "0x83BF8A0", VA = "0x1883C0CA0", Slot = "28")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool CVNSFFXAYYQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x83C0C90", Offset = "0x83BF890", VA = "0x1883C0C90", Slot = "31")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public int YQRJJLAUFXN
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xBF9EA0", Offset = "0xBF8AA0", VA = "0x180BF9EA0", Slot = "32")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public float WNZWFQJXXVS
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xAFBA50", Offset = "0xAFA650", VA = "0x180AFBA50", Slot = "29")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public int TCKSLMMZLVK
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xB297F0", Offset = "0xB283F0", VA = "0x180B297F0", Slot = "30")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x83C0BE0", Offset = "0x83BF7E0", VA = "0x1883C0BE0")]
		public LNUUNDJCHNU(UniformTRS a, RRObject b, float c, float3 d, ShapeColor e, ShapeMaterial f, SplineParameterFlags g, float h, int i, NativeArray<CurvePointData> j)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xC1C8B0", Offset = "0xC1B4B0", VA = "0x180C1C8B0", Slot = "33")]
		public NativeArray<CurvePointData> GetNativeCurvePoints()
		{
			return default(NativeArray<CurvePointData>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x83C0B10", Offset = "0x83BF710", VA = "0x1883C0B10", Slot = "25")]
		public override UnityEngine.Hash128 ComputeHash()
		{
			return default(UnityEngine.Hash128);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "26")]
		public override void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class PrimitiveWrapper : NMDJIKMJJSH, KLWGPMMPZHN, QUUITLXOWYH, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static readonly Log JVTVAZRWBFB;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private static readonly Dictionary<PrimitiveShapeType, PrimitiveShapeMeshType> FDSWZQDBWLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private PrimitiveShapeMeshType CFXSUPGTUJS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private bool HWDDHIITZYG;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private PrimitiveShapeMeshType KJFHDSTPDKV
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xAC5FE0", Offset = "0xAC4BE0", VA = "0x180AC5FE0", Slot = "28")]
			get
			{
				return default(PrimitiveShapeMeshType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private bool HXYZJBHLZNB
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xBF19E0", Offset = "0xBF05E0", VA = "0x180BF19E0", Slot = "29")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public float3 IHVVYLASSLQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x83CB0D0", Offset = "0x83C9CD0", VA = "0x1883CB0D0", Slot = "30")]
			get
			{
				return default(float3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x83CB0B0", Offset = "0x83C9CB0", VA = "0x1883CB0B0")]
		public PrimitiveWrapper(ObjectLocalId objectLocalId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x83CA990", Offset = "0x83C9590", VA = "0x1883CA990", Slot = "27")]
		public override UnityEngine.Hash128 ComputeHash()
		{
			return default(UnityEngine.Hash128);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x83CA9E0", Offset = "0x83C95E0", VA = "0x1883CA9E0", Slot = "26")]
		public override void Update()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class YEDCOTNROWS : JEKQMNNGXTJ, QFRPELZEUNM, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private GameObject GJJQTTICADH;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public GameObject NDIXLSKEJMG
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x83CF550", Offset = "0x83CE150", VA = "0x1883CF550")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public RRTransform KTGNJTYBSTL
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x83CF7A0", Offset = "0x83CE3A0", VA = "0x1883CF7A0", Slot = "15")]
			get
			{
				return default(RRTransform);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public RootFlags ZCZTNQOXGPA
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x83CFB30", Offset = "0x83CE730", VA = "0x1883CFB30", Slot = "16")]
			get
			{
				return default(RootFlags);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x83CF9F0", Offset = "0x83CE5F0", VA = "0x1883CF9F0")]
		public YEDCOTNROWS(ObjectLocalId a, bool b = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x83CF5E0", Offset = "0x83CE1E0", VA = "0x1883CF5E0")]
		public void DVONODPYZLQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x83CF7A0", Offset = "0x83CE3A0", VA = "0x1883CF7A0")]
		protected RRTransform HEAQBMVFEFN()
		{
			return default(RRTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x83CF8A0", Offset = "0x83CE4A0", VA = "0x1883CF8A0")]
		private static bool TPJVBYGFIBG(ObjectLocalId a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x83CF770", Offset = "0x83CE370", VA = "0x1883CF770", Slot = "18")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class KHBLGXQCDEN : NMDJIKMJJSH, GELSQMPXNCN, QUUITLXOWYH, IDisposable, EFPEWGFKFOS
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private NativeList<CurvePointData> MOCSHNABMMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private bool LWKGBXQASKX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private bool WHKAYTUPGLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private float MXGWGXIIQFW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private int CEQBPTXWZWA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private bool WTESDMBLFPO;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private bool UEZCEBYCEJQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0xC6C260", Offset = "0xC6AE60", VA = "0x180C6C260", Slot = "28")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		private bool NWDEXBXFXPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x12B2CB0", Offset = "0x12B18B0", VA = "0x1812B2CB0", Slot = "29")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private float XCSOZORDJPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xAE6BE0", Offset = "0xAE57E0", VA = "0x180AE6BE0", Slot = "30")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private int YKJLVWALGDP
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0xCE3E50", Offset = "0xCE2A50", VA = "0x180CE3E50", Slot = "31")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		private bool VOILNNAUJKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0xDBC360", Offset = "0xDBAF60", VA = "0x180DBC360", Slot = "32")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private int ZTAIEJILFWQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x83C0520", Offset = "0x83BF120", VA = "0x1883C0520", Slot = "33")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		private int FXYTQJNSUJN
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x83C0930", Offset = "0x83BF530", VA = "0x1883C0930", Slot = "38")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x83C0A20", Offset = "0x83BF620", VA = "0x1883C0A20")]
		public KHBLGXQCDEN(ObjectLocalId a, [Optional] NativeList<CurvePointData> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x83C0860", Offset = "0x83BF460", VA = "0x1883C0860", Slot = "26")]
		public override void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x83C01B0", Offset = "0x83BEDB0", VA = "0x1883C01B0", Slot = "27")]
		public override UnityEngine.Hash128 ComputeHash()
		{
			return default(UnityEngine.Hash128);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x83C0430", Offset = "0x83BF030", VA = "0x1883C0430", Slot = "25")]
		public override void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x83C04C0", Offset = "0x83BF0C0", VA = "0x1883C04C0")]
		public void GFEHMWLWASW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x83C0540", Offset = "0x83BF140", VA = "0x1883C0540", Slot = "34")]
		public NativeArray<CurvePointData> GetNativeCurvePoints()
		{
			return default(NativeArray<CurvePointData>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x83C02A0", Offset = "0x83BEEA0", VA = "0x1883C02A0", Slot = "35")]
		private Vector3 DCDMHVYMFWA(int a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x83C0490", Offset = "0x83BF090", VA = "0x1883C0490", Slot = "36")]
		private Quaternion FEBINMVWITP(int a)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x83C06E0", Offset = "0x83BF2E0", VA = "0x1883C06E0", Slot = "37")]
		private float SFDDQOEWDFT(int a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x83C03C0", Offset = "0x83BEFC0", VA = "0x1883C03C0")]
		private NativeArray<Entity> DPGBEVDRNBT()
		{
			return default(NativeArray<Entity>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[SystemEnabledLifetime(Lifetime.LoadInstance)]
	internal sealed class FRXSOFBGDPT : WFEIAZQXPEU
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x83B7FF0", Offset = "0x83B6BF0", VA = "0x1883B7FF0", Slot = "15")]
		protected override ComponentSystemBase AYREDPEPCWL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x83B8480", Offset = "0x83B7080", VA = "0x1883B8480", Slot = "13")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x83B8490", Offset = "0x83B7090", VA = "0x1883B8490")]
		[UnityEngine.Scripting.Preserve]
		public FRXSOFBGDPT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[DebugAlwaysUpdateSystem]
	public sealed class AddRemoveRenderRootSystem : DEUGRXVOMNZ
	{
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private static readonly Log JVTVAZRWBFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private EntityQuery GMCURGVQUMS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private EntityQuery WKZXFCBKYKQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private EntityQuery QXIXNUPGOWG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private EntityQuery HXWRSZYTHWN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private EntityQuery VIDBWTPPXED;

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x83AF7E0", Offset = "0x83AE3E0", VA = "0x1883AF7E0", Slot = "5")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x83AFB10", Offset = "0x83AE710", VA = "0x1883AFB10", Slot = "13")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x83AF460", Offset = "0x83AE060", VA = "0x1883AF460")]
		private void GXBNQXNYSZI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x83AFEC0", Offset = "0x83AEAC0", VA = "0x1883AFEC0")]
		private void WXDLWUQQUDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x83AFCD0", Offset = "0x83AE8D0", VA = "0x1883AFCD0")]
		private void WVIGYZXQUIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x83AF660", Offset = "0x83AE260", VA = "0x1883AF660")]
		private void KUDRBWHCZAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x83AFB50", Offset = "0x83AE750", VA = "0x1883AFB50")]
		private void PWONBQLJGCQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x83AFC80", Offset = "0x83AE880", VA = "0x1883AFC80")]
		private NativeList<Entity> TSYQTXKUKOQ(NativeArray<Entity> a)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x83AF790", Offset = "0x83AE390", VA = "0x1883AF790")]
		private NativeList<Entity> LJFBVDCMGLP(NativeArray<Entity> a)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x83AF3F0", Offset = "0x83ADFF0", VA = "0x1883AF3F0")]
		private void BUPMBLAGVPO(NativeArray<Entity> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x2E10EC0", Offset = "0x2E0FAC0", VA = "0x182E10EC0")]
		[UnityEngine.Scripting.Preserve]
		public AddRemoveRenderRootSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[DebugAlwaysUpdateSystem]
	[CompilerGenerated]
	public sealed class AddRemoveShapeRenderersSystem : DEUGRXVOMNZ, KWODXIHZOSZ
	{
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private static readonly Log JVTVAZRWBFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private EntityQuery TKGAODERVWY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private EntityQuery UCJTMLGSYCQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private EntityQuery NTMMJHSQTMV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private YMWLXYRBIAP TSJULDEBTEA;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x83B08C0", Offset = "0x83AF4C0", VA = "0x1883B08C0", Slot = "5")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x83B0080", Offset = "0x83AEC80", VA = "0x1883B0080", Slot = "15")]
		public override void InitReferences(FRTNUJPZGKS services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x83B0A70", Offset = "0x83AF670", VA = "0x1883B0A70", Slot = "13")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x83B04F0", Offset = "0x83AF0F0", VA = "0x1883B04F0")]
		private void NVNKZKDBRJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x83B1150", Offset = "0x83AFD50", VA = "0x1883B1150")]
		private void RIJEMMDRLUI(NativeParallelHashSet<RootHandle> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x83B0A90", Offset = "0x83AF690", VA = "0x1883B0A90")]
		private void RAEXTSRFBYE(NativeParallelHashSet<RootHandle> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x83B00E0", Offset = "0x83AECE0", VA = "0x1883B00E0")]
		private void NTIKLSUXSLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x83B1810", Offset = "0x83B0410", VA = "0x1883B1810")]
		private bool WSEQLECKZBJ(Entity a, [Out] RootHandle b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x83B18C0", Offset = "0x83B04C0", VA = "0x1883B18C0")]
		internal bool ZKBTATVIRLP(Entity a, [Out] RootHandle b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x2E10EC0", Offset = "0x2E0FAC0", VA = "0x182E10EC0")]
		[UnityEngine.Scripting.Preserve]
		public AddRemoveShapeRenderersSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[DebugAlwaysUpdateSystem]
	public sealed class AddShapeWrapperSystem : DEUGRXVOMNZ
	{
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private static readonly Log JVTVAZRWBFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private EntityQuery RDYDDVETHWF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private EntityQuery QSYMPSKBGTD;

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x83B1B90", Offset = "0x83B0790", VA = "0x1883B1B90", Slot = "5")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x83B1CC0", Offset = "0x83B08C0", VA = "0x1883B1CC0", Slot = "13")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x83B2010", Offset = "0x83B0C10", VA = "0x1883B2010")]
		private void RIJEMMDRLUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x83B1CE0", Offset = "0x83B08E0", VA = "0x1883B1CE0")]
		private void RAEXTSRFBYE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x2E10EC0", Offset = "0x2E0FAC0", VA = "0x182E10EC0")]
		[UnityEngine.Scripting.Preserve]
		public AddShapeWrapperSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	public class ApplyShapeModificationsToShapesAndRenderRootsSystem : DEUGRXVOMNZ, KWODXIHZOSZ
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
			[Cpp2IlInjected.Address(RVA = "0x83B7790", Offset = "0x83B6390", VA = "0x1883B7790", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x83B77F0", Offset = "0x83B63F0", VA = "0x1883B77F0")]
			private void LLLQVPZMCLU(EntityQueryInJob a, NativeList<Entity> b)
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
			[Cpp2IlInjected.Address(RVA = "0x83B72C0", Offset = "0x83B5EC0", VA = "0x1883B72C0")]
			public void UPTKQERGVTY([In] ArchetypeChunk chunk, int a, bool b, [In] v128 chunkEnabledMask)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x83B72B0", Offset = "0x83B5EB0", VA = "0x1883B72B0", Slot = "4")]
			private void RFHMXFRYQIK([In] ArchetypeChunk chunk, int a, bool b, [In] v128 chunkEnabledMask)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private static readonly Log JVTVAZRWBFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private EntityQuery FXCMLDOFVIS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private EntityQuery JOORCYSZHUA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private EntityQuery USUXZDYRXWM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private EntityQuery MYIDDXORUEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private EntityQuery ASTPCGNJXZR;

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x83B23D0", Offset = "0x83B0FD0", VA = "0x1883B23D0", Slot = "5")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x83B27E0", Offset = "0x83B13E0", VA = "0x1883B27E0", Slot = "13")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x83B2F40", Offset = "0x83B1B40", VA = "0x1883B2F40")]
		private void SQLNYUCSYBP(NativeParallelHashSet<RootHandle> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x83B2BA0", Offset = "0x83B17A0", VA = "0x1883B2BA0")]
		private void PYFDJONGVQV(NativeParallelHashSet<RootHandle> a, int b, int c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x2E10EC0", Offset = "0x2E0FAC0", VA = "0x182E10EC0")]
		[UnityEngine.Scripting.Preserve]
		public ApplyShapeModificationsToShapesAndRenderRootsSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	public class ApplyShapeMoveBetweenBatchedMeshesSystem : DEUGRXVOMNZ
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
			[Cpp2IlInjected.Address(RVA = "0x83B7490", Offset = "0x83B6090", VA = "0x1883B7490")]
			public void UPTKQERGVTY([In] ArchetypeChunk chunk, int a, bool b, [In] v128 chunkEnabledMask)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x83B7780", Offset = "0x83B6380", VA = "0x1883B7780", Slot = "4")]
			private void ZILGFAKPEQV([In] ArchetypeChunk chunk, int a, bool b, [In] v128 chunkEnabledMask)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private static readonly Log JVTVAZRWBFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private EntityQuery CKHLCIGPNUM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private EntityQuery EDPBERAJGLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private EntityQuery FLMGMWBNEIW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private EntityQuery DFKOVNADHHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private EntityQuery QBBACVDBHFZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private YMWLXYRBIAP VDBXZYQLMJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private AddRemoveShapeRenderersSystem DKDIHDPIBEI;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x83B3B10", Offset = "0x83B2710", VA = "0x1883B3B10", Slot = "5")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x83B3600", Offset = "0x83B2200", VA = "0x1883B3600", Slot = "15")]
		public override void InitReferences(FRTNUJPZGKS services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x83B3ED0", Offset = "0x83B2AD0", VA = "0x1883B3ED0", Slot = "13")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x83B4DE0", Offset = "0x83B39E0", VA = "0x1883B4DE0")]
		private void ZTKTHPSGVLK(NativeParallelHashSet<RootHandle> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x83B42E0", Offset = "0x83B2EE0", VA = "0x1883B42E0")]
		private void SCBTYWCFEBJ(NativeParallelHashSet<RootHandle> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x83B4780", Offset = "0x83B3380", VA = "0x1883B4780")]
		private void WBLEGKINGQN(NativeParallelHashSet<RootHandle> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x83B3660", Offset = "0x83B2260", VA = "0x1883B3660")]
		private void MHJQUARFFKD(NativeParallelHashSet<RootHandle> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x83B30D0", Offset = "0x83B1CD0", VA = "0x1883B30D0")]
		private void FOYVOJZSVPM(NativeParallelHashSet<RootHandle> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x83B4BF0", Offset = "0x83B37F0", VA = "0x1883B4BF0")]
		private void YBPAORLRCKX(Entity a, ShapeHandle b, RootHandle c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x2E10EC0", Offset = "0x2E0FAC0", VA = "0x182E10EC0")]
		[UnityEngine.Scripting.Preserve]
		public ApplyShapeMoveBetweenBatchedMeshesSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public sealed class AttachRenderProxyToEmbodiedContainerSystem : DEUGRXVOMNZ
	{
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private static readonly Log JVTVAZRWBFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private EntityQuery TNZQVEKJQBQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private EntityQuery PIMDKXLRSKH;

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x83B56C0", Offset = "0x83B42C0", VA = "0x1883B56C0", Slot = "5")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x83B58E0", Offset = "0x83B44E0", VA = "0x1883B58E0", Slot = "13")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x2E10EC0", Offset = "0x2E0FAC0", VA = "0x182E10EC0")]
		[UnityEngine.Scripting.Preserve]
		public AttachRenderProxyToEmbodiedContainerSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public class FQIWAPZMHIH : DEUGRXVOMNZ
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		[TypeManager.ForcedStableTypeHash(13972172025007325174uL)]
		private struct RemovedFromClusterLodTag : IComponentData
		{
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private EntityQuery QTOFNIQPDMD;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x83B7C80", Offset = "0x83B6880", VA = "0x1883B7C80", Slot = "5")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x83B7DB0", Offset = "0x83B69B0", VA = "0x1883B7DB0", Slot = "13")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x2E10EC0", Offset = "0x2E0FAC0", VA = "0x182E10EC0")]
		[UnityEngine.Scripting.Preserve]
		public FQIWAPZMHIH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[DebugAlwaysUpdateSystem]
	internal class RemoveShapeEffectsSystem : DEUGRXVOMNZ
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		private class Effect
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public EntityQuery XILUQTLQHLV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public EntityQuery ZKIMYNPUQCE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public RemoveEffect RFGHVESUKAG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public ComponentType GCJLQXYGLIZ;

			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public Effect()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000037")]
		private delegate void RemoveEffect(NativeArray<ShapeHandle> handle, ZSRZVAZPBAN shapeEffectManager);

		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private static readonly Log JVTVAZRWBFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private List<Effect> ADBZUEXKMTF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private RMAWLSSLTVK SHBNZKEESYY;

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x83CCBB0", Offset = "0x83CB7B0", VA = "0x1883CCBB0", Slot = "15")]
		public override void InitReferences(FRTNUJPZGKS services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x83CCC10", Offset = "0x83CB810", VA = "0x1883CCC10", Slot = "5")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x83CCEC0", Offset = "0x83CBAC0", VA = "0x1883CCEC0", Slot = "13")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x3A23F10", Offset = "0x3A22B10", VA = "0x183A23F10")]
		private void RJPLUSPXLKH<a>(RemoveEffect a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x83CD5B0", Offset = "0x83CC1B0", VA = "0x1883CD5B0")]
		private static void WLGZFTCQPXR(NativeArray<ShapeHandle> a, ZSRZVAZPBAN b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x83CC9E0", Offset = "0x83CB5E0", VA = "0x1883CC9E0")]
		private static void HWJDPWHOGJB(NativeArray<ShapeHandle> a, ZSRZVAZPBAN b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x83CD3E0", Offset = "0x83CBFE0", VA = "0x1883CD3E0")]
		private static void UQWSWBTOKEH(NativeArray<ShapeHandle> a, ZSRZVAZPBAN b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x2E10EC0", Offset = "0x2E0FAC0", VA = "0x182E10EC0")]
		[UnityEngine.Scripting.Preserve]
		public RemoveShapeEffectsSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[DebugAlwaysUpdateSystem]
	public sealed class RemoveShapesFromShapeRenderer : DEUGRXVOMNZ
	{
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private static readonly Log JVTVAZRWBFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private EntityQuery ATPFXOXPQHP;

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x83CD810", Offset = "0x83CC410", VA = "0x1883CD810", Slot = "5")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x83CD8D0", Offset = "0x83CC4D0", VA = "0x1883CD8D0", Slot = "13")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x2E10EC0", Offset = "0x2E0FAC0", VA = "0x182E10EC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x83B5EC0", Offset = "0x83B4AC0", VA = "0x1883B5EC0", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[RegisterService(typeof(JPBIIDTSNHA), new string[] { })]
	[ServiceLifetime(Lifetime.OMRoom)]
	internal class JPBIIDTSNHA : KWODXIHZOSZ, HJESUUHTFVQ, IQIQMYLKLGS, GWUWQZCMFZU
	{
		[Cpp2IlInjected.Token(Token = "0x200003C")]
		public readonly struct SplineMessageQueueScope : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000090")]
			private readonly JPBIIDTSNHA parent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			private readonly bool disposePointData;

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x17F74B0", Offset = "0x17F60B0", VA = "0x1817F74B0")]
			public SplineMessageQueueScope(JPBIIDTSNHA parent, bool disposePointData)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x83CF310", Offset = "0x83CDF10", VA = "0x1883CF310")]
			public Queue<BakedSplinesMessage>.Enumerator GetEnumerator()
			{
				return default(Queue<BakedSplinesMessage>.Enumerator);
			}

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x83CF060", Offset = "0x83CDC60", VA = "0x1883CF060", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private static readonly Log JVTVAZRWBFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		[DependsOn]
		private KYJOVNSGQOU TFLBWJFSRDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		[DependsOn]
		private SYJMHYMULJQ LDSSSYTZBPX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private List<NativeList<CurvePointData>> CDTRZRSKQCX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private List<(Entity, List<GameObject>)> MNFXFVVSYQI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private NativeList<ShapeHandle> HYZKKPZLFJZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private KGZPWRXXJTU<BakedSplinesMessage> VWHUJFPOAYC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private KGZPWRXXJTU<BakedPrimitiveMessage> UGJTZLJKMNS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private KGZPWRXXJTU<BakedShapeColliderMessage> MHEKOMNYYCJ;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x83BDB40", Offset = "0x83BC740", VA = "0x1883BDB40", Slot = "4")]
		public void InitReferences(FRTNUJPZGKS services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x83BD290", Offset = "0x83BBE90", VA = "0x1883BD290")]
		public void CGCZPCHAOBW(NativeList<CurvePointData> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x83BDD40", Offset = "0x83BC940", VA = "0x1883BDD40")]
		public void LIZCTFGAURH(Entity a, [In] JLBGYMDGKTI<GameObject> inColliders)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x83BE190", Offset = "0x83BCD90", VA = "0x1883BE190")]
		public void VSARGQCWHIJ(NativeList<ShapeHandle> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x83BDE80", Offset = "0x83BCA80", VA = "0x1883BDE80")]
		public void NVWTWYNPPMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x83BD660", Offset = "0x83BC260", VA = "0x1883BD660")]
		public void HPPGNHDEXHG(AFQORLXDPBZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x83BE210", Offset = "0x83BCE10", VA = "0x1883BE210")]
		public JobHandle YTDVOUFKJBZ([In] BakedSplinesMessage message, JobHandle a)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x83BE2B0", Offset = "0x83BCEB0", VA = "0x1883BE2B0")]
		public JobHandle YTDVOUFKJBZ([In] BakedPrimitiveMessage message, JobHandle a)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x8050D40", Offset = "0x804F940", VA = "0x188050D40")]
		public SplineMessageQueueScope CCWAQBZFNYS(bool a)
		{
			return default(SplineMessageQueueScope);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x83BD330", Offset = "0x83BBF30", VA = "0x1883BD330")]
		public MessageQueueScope<BakedPrimitiveMessage> CVFNECRUVUQ()
		{
			return default(MessageQueueScope<BakedPrimitiveMessage>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x83BD610", Offset = "0x83BC210", VA = "0x1883BD610")]
		public MessageQueueScope<BakedShapeColliderMessage> GLTCARANBMT()
		{
			return default(MessageQueueScope<BakedShapeColliderMessage>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x83BD380", Offset = "0x83BBF80", VA = "0x1883BD380")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x83BE0B0", Offset = "0x83BCCB0", VA = "0x1883BE0B0", Slot = "5")]
		public void PUBZWIFCMXS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x83BD5A0", Offset = "0x83BC1A0", VA = "0x1883BD5A0", Slot = "6")]
		private void ECGVZCYOEDK(FRTNUJPZGKS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0xD19560", Offset = "0xD18160", VA = "0x180D19560", Slot = "7")]
		private void RXSKOFHNRCQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public JPBIIDTSNHA()
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
		[Cpp2IlInjected.Address(RVA = "0x83B5F50", Offset = "0x83B4B50", VA = "0x1883B5F50", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x83B5F60", Offset = "0x83B4B60", VA = "0x1883B5F60")]
		public void Dispose(bool disposePointData)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[RegisterService(typeof(DEAXDVQOQFF), new string[] { })]
	[ServiceLifetime(Lifetime.LoadInstance)]
	internal class DEAXDVQOQFF : DXKVHEDTUEV, IQIQMYLKLGS, GWUWQZCMFZU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		[DependsOn]
		private JPBIIDTSNHA WZSPBPMCRCC;

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x83B7930", Offset = "0x83B6530", VA = "0x1883B7930", Slot = "4")]
		public void ShutdownReferences()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x83B78E0", Offset = "0x83B64E0", VA = "0x1883B78E0", Slot = "5")]
		private void ECGVZCYOEDK(FRTNUJPZGKS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0xC6B6D0", Offset = "0xC6A2D0", VA = "0x180C6B6D0", Slot = "6")]
		private void RXSKOFHNRCQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public DEAXDVQOQFF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[SystemEnabledLifetime(Lifetime.OMRoom)]
	[CompilerGenerated]
	public class PostDeserializeBakeShapesSystem : DEUGRXVOMNZ, KWODXIHZOSZ
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
			[Cpp2IlInjected.Address(RVA = "0x83B84A0", Offset = "0x83B70A0", VA = "0x1883B84A0")]
			public void UPTKQERGVTY([In] ArchetypeChunk chunk, int a, bool b, [In] v128 chunkEnabledMask)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x83B8820", Offset = "0x83B7420", VA = "0x1883B8820", Slot = "4")]
			private void ZILGFAKPEQV([In] ArchetypeChunk chunk, int a, bool b, [In] v128 chunkEnabledMask)
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
			[Cpp2IlInjected.Address(RVA = "0x83B8830", Offset = "0x83B7430", VA = "0x1883B8830")]
			public void UPTKQERGVTY([In] ArchetypeChunk chunk, int a, bool b, [In] v128 chunkEnabledMask)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x83B8B50", Offset = "0x83B7750", VA = "0x1883B8B50", Slot = "4")]
			private void ZILGFAKPEQV([In] ArchetypeChunk chunk, int a, bool b, [In] v128 chunkEnabledMask)
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
			[Cpp2IlInjected.Address(RVA = "0x83B7160", Offset = "0x83B5D60", VA = "0x1883B7160")]
			public void UPTKQERGVTY([In] ArchetypeChunk batchInChunk, int a, bool b, [In] v128 chunkEnabledMask)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x83B72A0", Offset = "0x83B5EA0", VA = "0x1883B72A0", Slot = "4")]
			private void ZILGFAKPEQV([In] ArchetypeChunk chunk, int a, bool b, [In] v128 chunkEnabledMask)
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
				public float3 XUXLDJVATTG
				{
					[Cpp2IlInjected.Token(Token = "0x600013E")]
					[Cpp2IlInjected.Address(RVA = "0x83C2410", Offset = "0x83C1010", VA = "0x1883C2410")]
					get
					{
						return default(float3);
					}
					[Cpp2IlInjected.Token(Token = "0x600013F")]
					[Cpp2IlInjected.Address(RVA = "0x83C2430", Offset = "0x83C1030", VA = "0x1883C2430")]
					set
					{
					}
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000046")]
			private interface VCRKWFSVDNX
			{
				[Cpp2IlInjected.Token(Token = "0x6000140")]
				[Cpp2IlInjected.Address(Slot = "0")]
				float3 OYCDYBGUBOH(quaternion a);
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000047")]
			private struct LegacyDirectionFromRotation : VCRKWFSVDNX
			{
				[Cpp2IlInjected.Token(Token = "0x6000141")]
				[Cpp2IlInjected.Address(RVA = "0x83C0CF0", Offset = "0x83BF8F0", VA = "0x1883C0CF0", Slot = "5")]
				public float3 WMGVHWWVSWE(quaternion a)
				{
					return default(float3);
				}

				[Cpp2IlInjected.Token(Token = "0x6000142")]
				[Cpp2IlInjected.Address(RVA = "0x83C0CB0", Offset = "0x83BF8B0", VA = "0x1883C0CB0", Slot = "4")]
				public float3 OYCDYBGUBOH(quaternion a)
				{
					return default(float3);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000048")]
			private struct NewDirectionFromRotation : VCRKWFSVDNX
			{
				[Cpp2IlInjected.Token(Token = "0x6000143")]
				[Cpp2IlInjected.Address(RVA = "0x83C20E0", Offset = "0x83C0CE0", VA = "0x1883C20E0", Slot = "4")]
				public float3 OYCDYBGUBOH(quaternion a)
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
			[Cpp2IlInjected.Address(RVA = "0x83BC020", Offset = "0x83BAC20", VA = "0x1883BC020")]
			public void UPTKQERGVTY([In] ArchetypeChunk chunk, int a, bool b, [In] v128 chunkEnabledMask)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x83B8F40", Offset = "0x83B7B40", VA = "0x1883B8F40")]
			private void AYSLFHILXRY(NativeList<PointSrcData> a, NativeList<CurvePointData> b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x83BC940", Offset = "0x83BB540", VA = "0x1883BC940")]
			public static Vector3 WQZGCPYJCTH(Vector3 a, Vector3 b, Vector3 c)
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x83BA210", Offset = "0x83B8E10", VA = "0x1883BA210")]
			public static quaternion GKUQOEXCVES(float3 a, float3 b)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x83BBDF0", Offset = "0x83BA9F0", VA = "0x1883BBDF0")]
			private static quaternion TWIKCOYTDUO(float3 a, float b, quaternion c)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x83BA040", Offset = "0x83B8C40", VA = "0x1883BA040")]
			private static float3 BCJXOZLPDIK(float3 a, float b, float3 c)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x83BAA90", Offset = "0x83B9690", VA = "0x1883BAA90")]
			private static quaternion PMLGXQXFLDP(float3 a, float b)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x83BAB20", Offset = "0x83B9720", VA = "0x1883BAB20")]
			private static CurvePointData PTRDCIRNJFX(int a, NativeList<PointSrcData> b)
			{
				return default(CurvePointData);
			}

			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x3C213C0", Offset = "0x3C1FFC0", VA = "0x183C213C0")]
			private void ZOKXOMRFFUS<a>(NativeArray<Entity> a, NativeList<PointSrcData> b, float c, a d) where a : struct, VCRKWFSVDNX
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x83BAE50", Offset = "0x83B9A50", VA = "0x1883BAE50")]
			private void TGFDAMCFTLF(NativeList<PointSrcData> a, NativeList<CurvePointData> b, float c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x83BCD50", Offset = "0x83BB950", VA = "0x1883BCD50")]
			public static float WZEWTMKETBM(float3 a, float3 b, float3 c)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x83BA290", Offset = "0x83B8E90", VA = "0x1883BA290")]
			private static quaternion Lerp(quaternion q1, quaternion q2, float t)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x83BC670", Offset = "0x83BB270", VA = "0x1883BC670")]
			private static CurvePointData WIMAVFZYDOQ(PointSrcData a)
			{
				return default(CurvePointData);
			}

			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x83BC5E0", Offset = "0x83BB1E0", VA = "0x1883BC5E0")]
			private static CurvePointData WIMAVFZYDOQ(float3 a, quaternion b, float c)
			{
				return default(CurvePointData);
			}

			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x83BCED0", Offset = "0x83BBAD0", VA = "0x1883BCED0")]
			private static bool YIVSOICOIRZ(float3 a, float b, [Out] float3 c)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x83BCF70", Offset = "0x83BBB70", VA = "0x1883BCF70")]
			private static float3 YJIFNQTRYSW(float3 a, float b)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x83BA480", Offset = "0x83B9080", VA = "0x1883BA480")]
			public static float3 OFMQSCLWGPK(quaternion a)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0x83BC790", Offset = "0x83BB390", VA = "0x1883BC790")]
			public static float3 WMGVHWWVSWE(quaternion a)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x83BA630", Offset = "0x83B9230", VA = "0x1883BA630")]
			private static quaternion PLYRJPQXRSV(quaternion a, float3 b)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x83B9ED0", Offset = "0x83B8AD0", VA = "0x1883B9ED0")]
			private static float Angle(float3 from, float3 to)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0x83BD040", Offset = "0x83BBC40", VA = "0x1883BD040", Slot = "4")]
			private void ZILGFAKPEQV([In] ArchetypeChunk chunk, int a, bool b, [In] v128 chunkEnabledMask)
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
			[Cpp2IlInjected.Address(RVA = "0x83C2480", Offset = "0x83C1080", VA = "0x1883C2480")]
			private void GYCXPGIFQZF(DynamicBuffer<LinkedEntityGroup> a, int b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(RVA = "0x83C2560", Offset = "0x83C1160", VA = "0x1883C2560")]
			[CompilerGenerated]
			public void UPTKQERGVTY([In] ArchetypeChunk chunk, int a, bool b, [In] v128 chunkEnabledMask)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x83C29D0", Offset = "0x83C15D0", VA = "0x1883C29D0", Slot = "4")]
			private void ZILGFAKPEQV([In] ArchetypeChunk chunk, int a, bool b, [In] v128 chunkEnabledMask)
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
			[Cpp2IlInjected.Address(RVA = "0x83CF3C0", Offset = "0x83CDFC0", VA = "0x1883CF3C0")]
			private void GYCXPGIFQZF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0x83CF3B0", Offset = "0x83CDFB0", VA = "0x1883CF3B0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x83CF010", Offset = "0x83CDC10", VA = "0x1883CF010")]
			private void GYCXPGIFQZF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0x83CF000", Offset = "0x83CDC00", VA = "0x1883CF000", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x83B8B70", Offset = "0x83B7770", VA = "0x1883B8B70")]
			private void GYCXPGIFQZF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0x83B8B60", Offset = "0x83B7760", VA = "0x1883B8B60", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x83B8D40", Offset = "0x83B7940", VA = "0x1883B8D40")]
			private void GYCXPGIFQZF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x83B8D30", Offset = "0x83B7930", VA = "0x1883B8D30", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x83CC5B0", Offset = "0x83CB1B0", VA = "0x1883CC5B0")]
			private void GYCXPGIFQZF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x83CC5A0", Offset = "0x83CB1A0", VA = "0x1883CC5A0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x83CF420", Offset = "0x83CE020", VA = "0x1883CF420")]
			public void EKVWOYFSWOP(SystemState a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private static readonly Log JVTVAZRWBFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private EntityQuery ICVZCFYBTBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private EntityQuery IIQEXAKPEWE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private CVSJMOZSYJI NCFFDOSHBUW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private KYJOVNSGQOU TFLBWJFSRDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private JPBIIDTSNHA WZSPBPMCRCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private PostDeserializeECB NWUBZIPXICA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private TypeHandle SDMUWSROHTR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private EntityQuery CHQULRCEFDZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private EntityQuery CHLNOKIGVSQ;

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x83C3C30", Offset = "0x83C2830", VA = "0x1883C3C30", Slot = "15")]
		public override void InitReferences(FRTNUJPZGKS services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x83C4390", Offset = "0x83C2F90", VA = "0x1883C4390", Slot = "5")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x83C4460", Offset = "0x83C3060", VA = "0x1883C4460", Slot = "6")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x83C44C0", Offset = "0x83C30C0", VA = "0x1883C44C0", Slot = "13")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x83C5E40", Offset = "0x83C4A40", VA = "0x1883C5E40")]
		private JobHandle VULMHHYZRRO(EntityQuery a, Entity b, JobHandle c)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x83C3290", Offset = "0x83C1E90", VA = "0x1883C3290")]
		private JobHandle CCLKGADWAZG(EntityQuery a, Entity b, JobHandle c)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x83C4250", Offset = "0x83C2E50", VA = "0x1883C4250")]
		private JobHandle YKSTEIHYXDZ(NativeArray<int> a, NativeList<CurvePointData> b, JobHandle c)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x83C2DD0", Offset = "0x83C19D0", VA = "0x1883C2DD0")]
		private JobHandle BDSKAYAXUGS(NativeList<CurvePointData> a, NativeArray<int> b, JobHandle c)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x83C58F0", Offset = "0x83C44F0", VA = "0x1883C58F0")]
		private JobHandle VPDTUDFFIWL(EntityQuery a, NativeList<RecRoom.Foundation.Collections.Range> b, NativeList<CurvePointData> c, NativeArray<int> d, JobHandle e)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x83C4630", Offset = "0x83C3230", VA = "0x1883C4630")]
		private JobHandle QBWSPLQXSRF(EntityCommandBuffer a, JobHandle b)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x83C5370", Offset = "0x83C3F70", VA = "0x1883C5370")]
		private JobHandle SHVLZDKVVPC(NativeArray<int> a, JobHandle b)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x83C3E60", Offset = "0x83C2A60", VA = "0x1883C3E60")]
		private JobHandle MYMJWXETFMV(EntityQuery a, [Out] NativeList<Entity> b, [Out] NativeList<Entity> c, [Out] NativeList<BakedPrimitiveData> d, [Out] NativeParallelHashSet<Entity> e, JobHandle f, Allocator g = Allocator.TempJob)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x83C4DA0", Offset = "0x83C39A0", VA = "0x1883C4DA0")]
		private JobHandle QZUKZUXHNPX(EntityQuery a, [Out] NativeList<Entity> b, [Out] NativeList<Entity> c, [Out] NativeList<RecRoom.Foundation.Collections.Range> d, [Out] NativeList<BakedSplineData> e, [Out] NativeParallelHashSet<Entity> f, JobHandle g, Allocator h = Allocator.TempJob)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x83C5070", Offset = "0x83C3C70", VA = "0x1883C5070")]
		private JobHandle SABZXKGXCMK(NativeList<Entity> a, NativeList<Entity> b, EntityCommandBuffer c, JobHandle d)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x83C4800", Offset = "0x83C3400", VA = "0x1883C4800")]
		private JobHandle QPYOZVQWFMQ(EntityQuery a, NativeList<BakedPrimitiveData> b, JobHandle c)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x83C2E70", Offset = "0x83C1A70", VA = "0x1883C2E70")]
		private static NativeParallelHashMap<int, PrimitiveShapeMeshType> BRTKYAWRGEK()
		{
			return default(NativeParallelHashMap<int, PrimitiveShapeMeshType>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x83C54A0", Offset = "0x83C40A0", VA = "0x1883C54A0")]
		private JobHandle ULHCPZDHYWK(EntityQuery a, NativeList<RecRoom.Foundation.Collections.Range> b, NativeList<CurvePointData> c, NativeList<BakedSplineData> d, JobHandle e)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x83C3CD0", Offset = "0x83C28D0", VA = "0x1883C3CD0")]
		private JobHandle KLWXOTYAKNT(EntityCommandBuffer.ParallelWriter a, JobHandle b)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x83C4250", Offset = "0x83C2E50", VA = "0x1883C4250")]
		private JobHandle OCGYIHZNWEL(NativeArray<int> a, NativeList<CurvePointData> b, JobHandle c)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x83C2DD0", Offset = "0x83C19D0", VA = "0x1883C2DD0")]
		private JobHandle ELLQZRSZNNA(NativeList<CurvePointData> a, NativeArray<int> b, JobHandle c)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x83C3B20", Offset = "0x83C2720", VA = "0x1883C3B20")]
		private JobHandle EMNOMZFGZRT(EntityQueryInJob a, EntityTypeHandle b, ComponentTypeHandle<ParentData> c, NativeList<Entity> d, NativeList<Entity> e, NativeParallelHashSet<Entity> f, NativeList<BakedPrimitiveData> g, JobHandle h)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x83C39F0", Offset = "0x83C25F0", VA = "0x1883C39F0")]
		private JobHandle CYKMBRIKKON(EntityQueryInJob a, EntityTypeHandle b, ComponentTypeHandle<ParentData> c, NativeList<Entity> d, NativeList<Entity> e, NativeParallelHashSet<Entity> f, NativeList<RecRoom.Foundation.Collections.Range> g, NativeList<BakedSplineData> h, JobHandle i)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x83C4120", Offset = "0x83C2D20", VA = "0x1883C4120")]
		private JobHandle NNICSFNUYLM(NativeList<Entity> a, NativeList<Entity> b, EntityCommandBuffer c, BufferLookup<ChildBuffer> d, BufferLookup<AuthoredChildBuffer> e, JobHandle f)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x83C29E0", Offset = "0x83C15E0", VA = "0x1883C29E0")]
		private void AAMYQAJRMSQ(SystemState a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x83C4300", Offset = "0x83C2F00", VA = "0x1883C4300", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x2E10EC0", Offset = "0x2E0FAC0", VA = "0x182E10EC0")]
		[UnityEngine.Scripting.Preserve]
		public PostDeserializeBakeShapesSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public class FIBOPWUZCEF : YRYAHHXHMLV, KWODXIHZOSZ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private JPBIIDTSNHA WZSPBPMCRCC;

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x83B7C10", Offset = "0x83B6810", VA = "0x1883B7C10", Slot = "14")]
		public void InitReferences(FRTNUJPZGKS services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x83B7C60", Offset = "0x83B6860", VA = "0x1883B7C60", Slot = "13")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x2B5D980", Offset = "0x2B5C580", VA = "0x182B5D980")]
		[UnityEngine.Scripting.Preserve]
		public FIBOPWUZCEF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[SystemEnabledLifetime(Lifetime.LoadInstance)]
	[CompilerGenerated]
	public class PostLoadCreateBakedShapesWrappersSystem : DEUGRXVOMNZ, KWODXIHZOSZ
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
			public (Entity parent, Transform containerWrapper, NativeArray<T> descriptors) TBQKYITANEM
			{
				[Cpp2IlInjected.Token(Token = "0x6000169")]
				[Cpp2IlInjected.Address(RVA = "0x4068410", Offset = "0x4067010", VA = "0x184068410")]
				get
				{
					return default((Entity, Transform, NativeArray<T>));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x4068670", Offset = "0x4067270", VA = "0x184068670")]
			public DescriptorSetEnumerator(EntityManager entityManager, EntityDataArrays<T> set, NativeArray<EntityRemapUtility.EntityRemapInfo> entityRemapping)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x3FFD7C0", Offset = "0x3FFC3C0", VA = "0x183FFD7C0")]
			public DescriptorSetEnumerator<T> GetEnumerator()
			{
				return default(DescriptorSetEnumerator<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x4067920", Offset = "0x4066520", VA = "0x184067920")]
			public bool MoveNext()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private static readonly Log JVTVAZRWBFB;

		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private static readonly Log MRDSEKYCVOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private SYJMHYMULJQ LDSSSYTZBPX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private JPBIIDTSNHA WZSPBPMCRCC;

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x83C6610", Offset = "0x83C5210", VA = "0x1883C6610", Slot = "15")]
		public override void InitReferences(FRTNUJPZGKS services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x83C65E0", Offset = "0x83C51E0", VA = "0x1883C65E0")]
		public void FLCRJLDQEGW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x83C86E0", Offset = "0x83C72E0", VA = "0x1883C86E0", Slot = "13")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x83C94B0", Offset = "0x83C80B0", VA = "0x1883C94B0")]
		private void QCVQNYWQSCE(BakedShapeColliderMessage a, Mesh[] b, NativeArray<EntityRemapUtility.EntityRemapInfo> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x38F0F90", Offset = "0x38EFB90", VA = "0x1838F0F90")]
		private DescriptorSetEnumerator<T> QHBBZSRDYIJ<T>(EntityDataArrays<T> a, NativeArray<EntityRemapUtility.EntityRemapInfo> b) where T : struct
		{
			return default(DescriptorSetEnumerator<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x83C7030", Offset = "0x83C5C30", VA = "0x1883C7030")]
		private void NHFDRYBMJEX(Transform a, NativeArray<SphereDescriptor> b, JLBGYMDGKTI<GameObject> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x83C8270", Offset = "0x83C6E70", VA = "0x1883C8270")]
		private void OZTFYUHSGBD(Transform a, NativeArray<BoxDescriptor> b, JLBGYMDGKTI<GameObject> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x83C6690", Offset = "0x83C5290", VA = "0x1883C6690")]
		private void JTVAUQXAZHB(Transform a, NativeArray<CapsuleDescriptor> b, JLBGYMDGKTI<GameObject> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x83C61D0", Offset = "0x83C4DD0", VA = "0x1883C61D0")]
		private void BMGHROTXLFV(Transform a, NativeArray<MeshDescriptor> b, Mesh[] c, JLBGYMDGKTI<GameObject> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x83C8060", Offset = "0x83C6C60", VA = "0x1883C8060")]
		private static void OKHVXCGXWBY(NativeParallelHashSet<Entity> a, NativeParallelHashSet<Entity> b, NativeArray<EntityRemapUtility.EntityRemapInfo> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x83C7F50", Offset = "0x83C6B50", VA = "0x1883C7F50")]
		private static void OHLAFYJJHDC(NativeList<Entity> a, NativeArray<EntityRemapUtility.EntityRemapInfo> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x83C7390", Offset = "0x83C5F90", VA = "0x1883C7390")]
		private NativeParallelHashMap<Entity, RenderRootHandleData> ODZMINUBFDQ(JPBIIDTSNHA.SplineMessageQueueScope a, MessageQueueScope<BakedPrimitiveMessage> b, List<GameObject> c)
		{
			return default(NativeParallelHashMap<Entity, RenderRootHandleData>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x83CA320", Offset = "0x83C8F20", VA = "0x1883CA320")]
		private NativeArray<EntityRemapUtility.EntityRemapInfo> VBEFUGDLPUD(Entity a)
		{
			return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x83C6A40", Offset = "0x83C5640", VA = "0x1883C6A40")]
		private void KLXMWYSHCDQ(NativeList<Entity> a, NativeList<Entity> b, NativeParallelHashMap<Entity, RenderRootHandleData> c, NativeList<RecRoom.Foundation.Collections.Range> d, NativeList<CurvePointData> e, NativeList<BakedSplineData> f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x83CA430", Offset = "0x83C9030", VA = "0x1883CA430")]
		private void VWOSMDCTBJG(NativeList<Entity> a, NativeList<Entity> b, NativeParallelHashMap<Entity, RenderRootHandleData> c, NativeList<BakedPrimitiveData> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x2E10EC0", Offset = "0x2E0FAC0", VA = "0x182E10EC0")]
		[UnityEngine.Scripting.Preserve]
		public PostLoadCreateBakedShapesWrappersSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public abstract class WRJRELWFOHQ : DYMGSFIQJBU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public readonly UniformTRS ZZPOXHCMPEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private readonly RRObject NEAVNSGBNPF;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		private GameObject GQYVYDOXVDS
		{
			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0xA96160", Offset = "0xA94D60", VA = "0x180A96160", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public UniformTRS LHALBBWJFPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x83D2CA0", Offset = "0x83D18A0", VA = "0x1883D2CA0", Slot = "8")]
			get
			{
				return default(UniformTRS);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		private Vector3 UBDCRUHCIBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0x83D2F00", Offset = "0x83D1B00", VA = "0x1883D2F00", Slot = "10")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		private Matrix4x4 ZYAUUSEWIXM
		{
			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x83D2EC0", Offset = "0x83D1AC0", VA = "0x1883D2EC0", Slot = "9")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		private Vector3 FFJFGASGVGS
		{
			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x83D2E80", Offset = "0x83D1A80", VA = "0x1883D2E80", Slot = "4")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x83D2D80", Offset = "0x83D1980", VA = "0x1883D2D80", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		private Quaternion OVUURTGFCFF
		{
			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x83D2E00", Offset = "0x83D1A00", VA = "0x1883D2E00", Slot = "6")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x83D2DC0", Offset = "0x83D19C0", VA = "0x1883D2DC0", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		private Vector3 NFTAULKVNLL
		{
			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x83D2C60", Offset = "0x83D1860", VA = "0x1883D2C60", Slot = "11")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		private Vector3 RZRXLXEIQMA
		{
			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x83D2E40", Offset = "0x83D1A40", VA = "0x1883D2E40", Slot = "13")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		private Vector3 HRHCABWTQDM
		{
			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x83D2C20", Offset = "0x83D1820", VA = "0x1883D2C20", Slot = "14")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x83D2F40", Offset = "0x83D1B40", VA = "0x1883D2F40")]
		public WRJRELWFOHQ(UniformTRS a, RRObject b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public abstract class WXNTWJSLSLU : WRJRELWFOHQ, QUUITLXOWYH, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private readonly float QFDOHPXPBFU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private readonly float3 ICOCWHXNCBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private readonly ShapeColor KDUMAQXLSDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private readonly ShapeMaterial PKNHMNKSQNH;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		private RRTransform WPYKVJGNTBS
		{
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x83D2F90", Offset = "0x83D1B90", VA = "0x1883D2F90", Slot = "17")]
			get
			{
				return default(RRTransform);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		private UniformTRS OOBZVOOVMMA
		{
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x83D2FD0", Offset = "0x83D1BD0", VA = "0x1883D2FD0", Slot = "18")]
			get
			{
				return default(UniformTRS);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		private float UAVMKFVERLN
		{
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0xB7B060", Offset = "0xB79C60", VA = "0x180B7B060", Slot = "19")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		private Vector3 ZVOCFQORWVC
		{
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x83D30B0", Offset = "0x83D1CB0", VA = "0x1883D30B0", Slot = "20")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		private ShapeColor LNIPJHGQPGU
		{
			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0xCE3E50", Offset = "0xCE2A50", VA = "0x180CE3E50", Slot = "21")]
			get
			{
				return default(ShapeColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		private ShapeMaterial UHUBQBUTOAU
		{
			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x135B8A0", Offset = "0x135A4A0", VA = "0x18135B8A0", Slot = "22")]
			get
			{
				return default(ShapeMaterial);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		private bool DSSPLDZIWGL
		{
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0xAE0370", Offset = "0xADEF70", VA = "0x180AE0370", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool GXSZPCHBFWB
		{
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0xAE0370", Offset = "0xADEF70", VA = "0x180AE0370", Slot = "15")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150")]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x83D3100", Offset = "0x83D1D00", VA = "0x1883D3100")]
		protected WXNTWJSLSLU(UniformTRS a, RRObject b, float c, float3 d, ShapeColor e, ShapeMaterial f)
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
	public abstract class JEKQMNNGXTJ : DYMGSFIQJBU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		protected readonly ObjectLocalId NTPYLPFIYHD;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		protected RRObject REOMCTXHCAU
		{
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x1048850", Offset = "0x1047450", VA = "0x181048850")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		protected Entity BJRUIJDPOIQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x83D0D90", Offset = "0x83CF990", VA = "0x1883D0D90")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		protected KYJOVNSGQOU LISOFNMLTYB
		{
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x83D0A70", Offset = "0x83CF670", VA = "0x1883D0A70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		protected BDGHGJBLQTW USYEXNEGQTR
		{
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x83D1450", Offset = "0x83D0050", VA = "0x1883D1450")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		protected ILLIEDLHHJL KBRYJBKZNNA
		{
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x83D10F0", Offset = "0x83CFCF0", VA = "0x1883D10F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		private GameObject GQYVYDOXVDS
		{
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x83D1180", Offset = "0x83CFD80", VA = "0x1883D1180", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public UniformTRS LHALBBWJFPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x10831A0", Offset = "0x1081DA0", VA = "0x1810831A0", Slot = "8")]
			get
			{
				return default(UniformTRS);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		private Vector3 UBDCRUHCIBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x83D14B0", Offset = "0x83D00B0", VA = "0x1883D14B0", Slot = "10")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		private Matrix4x4 ZYAUUSEWIXM
		{
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x83D12E0", Offset = "0x83CFEE0", VA = "0x1883D12E0", Slot = "9")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		private Vector3 FFJFGASGVGS
		{
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x83D11B0", Offset = "0x83CFDB0", VA = "0x1883D11B0", Slot = "4")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x83D0B70", Offset = "0x83CF770", VA = "0x1883D0B70", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		private Quaternion OVUURTGFCFF
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x83D0DB0", Offset = "0x83CF9B0", VA = "0x1883D0DB0", Slot = "6")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x83D0C80", Offset = "0x83CF880", VA = "0x1883D0C80", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		private Vector3 NFTAULKVNLL
		{
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x83D0A80", Offset = "0x83CF680", VA = "0x1883D0A80", Slot = "11")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		private Vector3 RZRXLXEIQMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x83D0ED0", Offset = "0x83CFAD0", VA = "0x1883D0ED0", Slot = "13")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		private Vector3 HRHCABWTQDM
		{
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x83D0850", Offset = "0x83CF450", VA = "0x1883D0850", Slot = "14")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0xC92E30", Offset = "0xC91A30", VA = "0x180C92E30")]
		protected JEKQMNNGXTJ(ObjectLocalId a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x83D15A0", Offset = "0x83D01A0", VA = "0x1883D15A0")]
		public static implicit operator RRTransform(JEKQMNNGXTJ t)
		{
			return default(RRTransform);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public static class WJCZWAASUSY
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x83D29C0", Offset = "0x83D15C0", VA = "0x1883D29C0")]
		public static void FJNKHFQXSHH(NativeArray<Entity> a, EntityManager b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public static class SHPOSVZDSMD
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x83D1EA0", Offset = "0x83D0AA0", VA = "0x1883D1EA0")]
		public static void QUJGWNBFOQT(NativeArray<Entity> a, EntityManager b, AFQORLXDPBZ c, KYJOVNSGQOU d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x83D22C0", Offset = "0x83D0EC0", VA = "0x1883D22C0")]
		public static void TMBCKHITLFK(NativeArray<Entity> a, EntityManager b, AFQORLXDPBZ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x83D1E70", Offset = "0x83D0A70", VA = "0x1883D1E70")]
		public static NativeList<Entity> LJFBVDCMGLP(NativeArray<Entity> a, EntityManager b)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x83D25E0", Offset = "0x83D11E0", VA = "0x1883D25E0")]
		public static NativeList<Entity> TSYQTXKUKOQ(NativeArray<Entity> a, EntityManager b)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x83D1BC0", Offset = "0x83D07C0", VA = "0x1883D1BC0")]
		private static NativeList<Entity> LJFBVDCMGLP(NativeArray<Entity> a, EntityManager b, bool c)
		{
			return default(NativeList<Entity>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public abstract class NMDJIKMJJSH : JEKQMNNGXTJ, QUUITLXOWYH, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private float QFDOHPXPBFU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private Vector3 ICOCWHXNCBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private ShapeColor KDUMAQXLSDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private ShapeMaterial PKNHMNKSQNH;

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		protected EntityManager IAFZDHKKZKH
		{
			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x83D17A0", Offset = "0x83D03A0", VA = "0x1883D17A0")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		protected DCYCHNIZCRD OIVNZBYKWLP
		{
			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x83D18F0", Offset = "0x83D04F0", VA = "0x1883D18F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		protected ShapeConfigData HFJSMTBMYQO
		{
			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x83D15D0", Offset = "0x83D01D0", VA = "0x1883D15D0")]
			get
			{
				return default(ShapeConfigData);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		private RRTransform WPYKVJGNTBS
		{
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x83D15A0", Offset = "0x83D01A0", VA = "0x1883D15A0", Slot = "17")]
			get
			{
				return default(RRTransform);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		private float UAVMKFVERLN
		{
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0xAF2770", Offset = "0xAF1370", VA = "0x180AF2770", Slot = "19")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		private Vector3 ZVOCFQORWVC
		{
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x11544F0", Offset = "0x11530F0", VA = "0x1811544F0", Slot = "20")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		private ShapeColor LNIPJHGQPGU
		{
			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0xA9F8F0", Offset = "0xA9E4F0", VA = "0x180A9F8F0", Slot = "21")]
			get
			{
				return default(ShapeColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		private ShapeMaterial UHUBQBUTOAU
		{
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0xB108E0", Offset = "0xB0F4E0", VA = "0x180B108E0", Slot = "22")]
			get
			{
				return default(ShapeMaterial);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		private UniformTRS OOBZVOOVMMA
		{
			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x10831A0", Offset = "0x1081DA0", VA = "0x1810831A0", Slot = "18")]
			get
			{
				return default(UniformTRS);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public bool GXSZPCHBFWB
		{
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0xAF8F90", Offset = "0xAF7B90", VA = "0x180AF8F90", Slot = "15")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0xAF9300", Offset = "0xAF7F00", VA = "0x180AF9300")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		private bool DSSPLDZIWGL
		{
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0xAE0370", Offset = "0xADEF70", VA = "0x180AE0370", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x83D1B80", Offset = "0x83D0780", VA = "0x1883D1B80")]
		protected NMDJIKMJJSH(ObjectLocalId a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "25")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x83D1980", Offset = "0x83D0580", VA = "0x1883D1980", Slot = "26")]
		public virtual void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(Slot = "27")]
		public abstract UnityEngine.Hash128 ComputeHash();
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[SystemEnabledLifetime(Lifetime.LoadInstance)]
	public abstract class DEUGRXVOMNZ : YRYAHHXHMLV, KWODXIHZOSZ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		protected KYJOVNSGQOU KYDLRIVYHCV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private NPBCYDBOKXW OKLMDKLKPBM;

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		protected AFQORLXDPBZ BKDTWHAUHRI
		{
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x83D0420", Offset = "0x83CF020", VA = "0x1883D0420")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		protected ZSRZVAZPBAN OGHEWCIVEZO
		{
			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x83D05A0", Offset = "0x83CF1A0", VA = "0x1883D05A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		protected bool WXIHJSACRYR
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x83D0470", Offset = "0x83CF070", VA = "0x1883D0470")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x83D0530", Offset = "0x83CF130", VA = "0x1883D0530", Slot = "15")]
		public virtual void InitReferences(FRTNUJPZGKS services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x2B5D980", Offset = "0x2B5C580", VA = "0x182B5D980")]
		[UnityEngine.Scripting.Preserve]
		protected DEUGRXVOMNZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public static class DZLOKMEOWKG
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x83D05F0", Offset = "0x83CF1F0", VA = "0x1883D05F0")]
		public static void YBXAJKCTGSS(NativeArray<Entity> a, EntityManager b)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__2692564728
{
	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x83D3180", Offset = "0x83D1D80", VA = "0x1883D3180")]
	public static void ERMADPSHGQX()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x83D32F0", Offset = "0x83D1EF0", VA = "0x1883D32F0")]
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
