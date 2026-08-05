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
		[Cpp2IlInjected.Address(RVA = "0xAC7BE0", Offset = "0xAC69E0", VA = "0x180AC7BE0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAC7BE0", Offset = "0xAC69E0", VA = "0x180AC7BE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x867F2F0", Offset = "0x867E0F0", VA = "0x18867F2F0", Slot = "4")]
		public override void IPFDCTVTWHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xAC7BE0", Offset = "0xAC69E0", VA = "0x180AC7BE0")]
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
		private int[] DAADMOFRSKV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private ServiceBitset RDSSOODTNJI;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xAA0C00", Offset = "0xA9FA00", VA = "0x180AA0C00", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8637160", Offset = "0x8635F60", VA = "0x188637160", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8690260", Offset = "0x868F060", VA = "0x188690260")]
		private void ZZHVSKGGGUO(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8690200", Offset = "0x868F000", VA = "0x188690200", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x86907E0", Offset = "0x868F5E0", VA = "0x1886907E0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class TIQWHNUXVVM
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x868D970", Offset = "0x868C770", VA = "0x18868D970")]
		public static Quaternion XGWGSNUDKWP([In] this RRObjectSplinePoint splinePoint, [In] Vector3 direction)
		{
			return default(Quaternion);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class GCDYXQIOLJH
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8678860", Offset = "0x8677660", VA = "0x188678860")]
		public static bool RGPALKXXBGH(this RRObjectShapeSpline a, ShapeConfigFlags b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x86788A0", Offset = "0x86776A0", VA = "0x1886788A0")]
		public static bool RMPPDYFRLJF(this RRObjectShapeSpline a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8678250", Offset = "0x8677050", VA = "0x188678250")]
		public static bool GIGUMNSWHJY(this RRObjectShapeSpline a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8678120", Offset = "0x8676F20", VA = "0x188678120")]
		public static void FIDGGJOVFTL(this RRObjectShapeSpline a, Vector3 b, Quaternion c, float d, bool e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8678FB0", Offset = "0x8677DB0", VA = "0x188678FB0")]
		public static void VHAXIELVYFP(this RRObjectShapeSpline a, Vector3 b, Quaternion c, float d, int e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x86784A0", Offset = "0x86772A0", VA = "0x1886784A0")]
		public static void LCVXWLRUINP(this RRObjectShapeSpline a, int b, Vector3 c, Quaternion d, float e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x86780D0", Offset = "0x8676ED0", VA = "0x1886780D0")]
		public static void COIUQTAKQWU(this RRObjectShapeSpline a, Vector3 b, Quaternion c, float d, bool e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8679240", Offset = "0x8678040", VA = "0x188679240")]
		private static void XIHDEIYFMYB(this RRObjectShapeSpline a, Vector3 b, Quaternion c, float d, bool e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8677F10", Offset = "0x8676D10", VA = "0x188677F10")]
		private static void BHUWKMEWBAT(this RRObjectShapeSpline a, Vector3 b, Quaternion c, float d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x86788D0", Offset = "0x86776D0", VA = "0x1886788D0")]
		private static void ROUDUUMLGCP(this RRObjectShapeSpline a, int b, Vector3 c, Quaternion d, float e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8677EE0", Offset = "0x8676CE0", VA = "0x188677EE0")]
		private static bool AAKKKCXKMAF(this RRObjectShapeSpline a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x86785C0", Offset = "0x86773C0", VA = "0x1886785C0")]
		private static void LXOGOEVRHXR(this RRObjectShapeSpline a, int b, Vector3 c, Quaternion d, float e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8678AC0", Offset = "0x86778C0", VA = "0x188678AC0")]
		public static Vector3 SOXLNGSOHOS(this RRObjectShapeSpline a, int b)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8679BA0", Offset = "0x86789A0", VA = "0x188679BA0")]
		public static Quaternion ZWRCLPTRVNB(this RRObjectShapeSpline a, int b)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8678280", Offset = "0x8677080", VA = "0x188678280")]
		public static Vector3 KYCMJDIHOAO(ShapeConfigFlags a, Vector3 b, Vector3? c, Vector3 d)
		{
			return default(Vector3);
		}
	}
}
namespace RecRoom.ObjectModel.RendererV1
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	internal interface HNQMKYNKRIL
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void OYHOAKGRBDK(EntityQuery a, EntityManager b, MZPGVNSEBXC c, SHFEMKDTTNV d);
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	internal interface GVJMJLMMOHX
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		ComponentType XNQTBDZZQWM
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void ECZTPNUXIKQ(EntityQuery a, AZETBOSDKFP b);

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void RHZIIRXGVFJ(EntityQuery a, AZETBOSDKFP b);

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void AXMLLJMUCCX(AZETBOSDKFP a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	internal class KHBVRKGORLE : HNQMKYNKRIL
	{
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static readonly Log YLLVKVFSHML;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x867ECD0", Offset = "0x867DAD0", VA = "0x18867ECD0", Slot = "4")]
		public void OYHOAKGRBDK(EntityQuery a, EntityManager b, MZPGVNSEBXC c, SHFEMKDTTNV d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public KHBVRKGORLE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	internal class TOQMOKVATAS : HNQMKYNKRIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly SelectionEffectType OOCZHIIGLEG;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xAA3550", Offset = "0xAA2350", VA = "0x180AA3550")]
		public TOQMOKVATAS(SelectionEffectType a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x868DA50", Offset = "0x868C850", VA = "0x18868DA50", Slot = "4")]
		public void OYHOAKGRBDK(EntityQuery a, EntityManager b, MZPGVNSEBXC c, SHFEMKDTTNV d)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	internal class FHJFQVZYYUC : HNQMKYNKRIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8677D90", Offset = "0x8676B90", VA = "0x188677D90", Slot = "4")]
		public void OYHOAKGRBDK(EntityQuery a, EntityManager b, MZPGVNSEBXC c, SHFEMKDTTNV d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public FHJFQVZYYUC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class NFHTYIOKPDA : GVJMJLMMOHX
	{
		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public ComponentType XNQTBDZZQWM
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x867FC70", Offset = "0x867EA70", VA = "0x18867FC70", Slot = "4")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x867F730", Offset = "0x867E530", VA = "0x18867F730", Slot = "5")]
		public void ECZTPNUXIKQ(EntityQuery a, AZETBOSDKFP b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x867F9D0", Offset = "0x867E7D0", VA = "0x18867F9D0", Slot = "6")]
		public void RHZIIRXGVFJ(EntityQuery a, AZETBOSDKFP b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x867F6E0", Offset = "0x867E4E0", VA = "0x18867F6E0", Slot = "7")]
		public void AXMLLJMUCCX(AZETBOSDKFP a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public NFHTYIOKPDA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class ZFXIHZHOQLA : GVJMJLMMOHX
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public ComponentType XNQTBDZZQWM
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x86901A0", Offset = "0x868EFA0", VA = "0x1886901A0", Slot = "4")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x868FC60", Offset = "0x868EA60", VA = "0x18868FC60", Slot = "5")]
		public void ECZTPNUXIKQ(EntityQuery a, AZETBOSDKFP b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x868FF00", Offset = "0x868ED00", VA = "0x18868FF00", Slot = "6")]
		public void RHZIIRXGVFJ(EntityQuery a, AZETBOSDKFP b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x868FC10", Offset = "0x868EA10", VA = "0x18868FC10", Slot = "7")]
		public void AXMLLJMUCCX(AZETBOSDKFP a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public ZFXIHZHOQLA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class RCQMTYLYCBY : GVJMJLMMOHX
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public ComponentType XNQTBDZZQWM
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x868AD30", Offset = "0x8689B30", VA = "0x18868AD30", Slot = "4")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x868A7F0", Offset = "0x86895F0", VA = "0x18868A7F0", Slot = "5")]
		public void ECZTPNUXIKQ(EntityQuery a, AZETBOSDKFP b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x868AA90", Offset = "0x8689890", VA = "0x18868AA90", Slot = "6")]
		public void RHZIIRXGVFJ(EntityQuery a, AZETBOSDKFP b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x868A7A0", Offset = "0x86895A0", VA = "0x18868A7A0", Slot = "7")]
		public void AXMLLJMUCCX(AZETBOSDKFP a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public RCQMTYLYCBY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal class ATVYYIUXDEF : JPHEEIIEARZ, LYBXKQOLIUF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private MZPGVNSEBXC CHVUAIGFBDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private LDRPGSCOSRW JORKGGIBHCQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private SHFEMKDTTNV GVYZNUPHRWH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private List<(EntityQuery query, HNQMKYNKRIL adapter)> DSAIAJDIFVV;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x866F940", Offset = "0x866E740", VA = "0x18866F940", Slot = "15")]
		public virtual void InitReferences(YKMTYEBAAOC services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x866F9D0", Offset = "0x866E7D0", VA = "0x18866F9D0", Slot = "5")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x866FE50", Offset = "0x866EC50", VA = "0x18866FE50")]
		private void YSNUWEZWLKH(EntityQueryDesc a, HNQMKYNKRIL b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x866FBC0", Offset = "0x866E9C0", VA = "0x18866FBC0", Slot = "13")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x2DC7C40", Offset = "0x2DC6A40", VA = "0x182DC7C40")]
		[UnityEngine.Scripting.Preserve]
		public ATVYYIUXDEF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[SystemEnabledLifetime(Lifetime.LoadInstance)]
	internal class RenderShapeEffectsSystem : JPHEEIIEARZ, LYBXKQOLIUF
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		private class Effect
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public EntityQuery FZKZQATVXGG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public EntityQuery HYRDZIRFATM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public EntityQuery GLGFBCFXZJL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public EntityQuery UNWGXTLUTFR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public EntityQuery QICASYMAEIV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public EntityQuery LLSPZMDFMFS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public EntityQuery YEGFVLOFIOG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public GVJMJLMMOHX TNRDBJZYKJD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public ComponentType VLRILYTIWYI;

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
			public Effect()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly Log YLLVKVFSHML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private MZPGVNSEBXC CHVUAIGFBDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private SHFEMKDTTNV GVYZNUPHRWH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private LDRPGSCOSRW JORKGGIBHCQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private List<Effect> DSAIAJDIFVV;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x868C9E0", Offset = "0x868B7E0", VA = "0x18868C9E0", Slot = "14")]
		public void InitReferences(YKMTYEBAAOC services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x868CA70", Offset = "0x868B870", VA = "0x18868CA70", Slot = "5")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x868CBF0", Offset = "0x868B9F0", VA = "0x18868CBF0", Slot = "13")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x868C560", Offset = "0x868B360", VA = "0x18868C560")]
		private void FPDODXXZSPA(Effect a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x868CE00", Offset = "0x868BC00", VA = "0x18868CE00")]
		private void YSNUWEZWLKH(GVJMJLMMOHX a, ComponentType b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x2DC7C40", Offset = "0x2DC6A40", VA = "0x182DC7C40")]
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
	[RegisterService(typeof(SHFEMKDTTNV), new string[] { })]
	public class PDLAWZVIZPY : SHFEMKDTTNV
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public OutlineEffectType JUGDPPLGXRI
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xA9D110", Offset = "0xA9BF10", VA = "0x180A9D110", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(OutlineEffectType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xAAA950", Offset = "0xAA9750", VA = "0x180AAA950", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public PDLAWZVIZPY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[RegisterService(typeof(LQFCBWMLAAX), new string[] { })]
	public class WHQZQSJZSMI : LQFCBWMLAAX, WAKURPWFEEW, XBOLCYDYDAA, OZGSEXBXCXO, BQLXQKHZRWO, OQVTAWVSILE, CKMVDEYKLMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[DependsOn]
		private WONIJGYOYUN LTZPEJHEZIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[DependsOn]
		private MZPGVNSEBXC CHVUAIGFBDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		[DependsOn]
		private CRGTHIQPIZW XXADBSGXIEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private EntityQuery MWAQYAZTOEU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private EntityQuery XZSMSKCJVON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private bool XQXHMUVABZJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private Entity GURYJIQHGGY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private RootHandle CBIKEXBZXEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private Entity MFOXOTMSGSX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private RootHandle CBNPSDJQQQF;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private EntityManager HXWPISFIQHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x868E900", Offset = "0x868D700", VA = "0x18868E900")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public int QXSWVNCIDBR
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x868E9D0", Offset = "0x868D7D0", VA = "0x18868E9D0", Slot = "7")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int YPOGZFTPXQS
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x868E9F0", Offset = "0x868D7F0", VA = "0x18868E9F0", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x868E190", Offset = "0x868CF90", VA = "0x18868E190", Slot = "4")]
		public bool JFUXHDTHIOO(ObjectLocalId a, MutableRef b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x868DE90", Offset = "0x868CC90", VA = "0x18868DE90", Slot = "5")]
		public RootHandle JCPGYQJBDPC()
		{
			return default(RootHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x868E5C0", Offset = "0x868D3C0", VA = "0x18868E5C0", Slot = "6")]
		public RootHandle MEQKDHDHBLV()
		{
			return default(RootHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x868DD60", Offset = "0x868CB60", VA = "0x18868DD60", Slot = "9")]
		public void InitExternal(YKMTYEBAAOC services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x868E8C0", Offset = "0x868D6C0", VA = "0x18868E8C0", Slot = "11")]
		public void QDLPFTNMELS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x868E2E0", Offset = "0x868D0E0", VA = "0x18868E2E0", Slot = "10")]
		public void JKEMGOBUBBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x868EA10", Offset = "0x868D810", VA = "0x18868EA10", Slot = "12")]
		private void VROTAZPKECM(YKMTYEBAAOC a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x13EF800", Offset = "0x13EE600", VA = "0x1813EF800", Slot = "13")]
		private void WEWODNDDDHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public WHQZQSJZSMI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[RegisterService(typeof(KFSIQRCXFKK), new string[] { })]
	public class XJUEMGWVFKR : KFSIQRCXFKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x868F880", Offset = "0x868E680", VA = "0x18868F880", Slot = "4")]
		public void GDJPPJDZJTG(World a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x868F9D0", Offset = "0x868E7D0", VA = "0x18868F9D0", Slot = "5")]
		public void KYHRCBEUDZW(World a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x868FA20", Offset = "0x868E820", VA = "0x18868FA20", Slot = "6")]
		public ComponentSystemBase OYJOUMHXCZJ(World a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x868F910", Offset = "0x868E710", VA = "0x18868F910", Slot = "7")]
		public void JCBDACIERHR(World a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x868F820", Offset = "0x868E620", VA = "0x18868F820", Slot = "8")]
		public void EDQTCTQAAJM(World a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x868F970", Offset = "0x868E770", VA = "0x18868F970", Slot = "9")]
		public void JJYDXZXBYXJ(World a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x868F7B0", Offset = "0x868E5B0", VA = "0x18868F7B0", Slot = "10")]
		public void BETIWBFUTUG(World a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x868EF30", Offset = "0x868DD30", VA = "0x18868EF30", Slot = "11")]
		public NativeParallelHashSet<ComponentTypeIndex> AIADKSIWAKN()
		{
			return default(NativeParallelHashSet<ComponentTypeIndex>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public XJUEMGWVFKR()
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
	public class NMAYHLQYDBZ : IComponentData, ICloneable, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public UDCPQXYTPVB QIVQXNHHLZO
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xAA0BE0", Offset = "0xA9F9E0", VA = "0x180AA0BE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0xAA0FA0", Offset = "0xA9FDA0", VA = "0x180AA0FA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x867FD40", Offset = "0x867EB40", VA = "0x18867FD40", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x867FCD0", Offset = "0x867EAD0", VA = "0x18867FCD0", Slot = "4")]
		public object Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		[UnityEngine.Scripting.Preserve]
		public NMAYHLQYDBZ()
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
		[Cpp2IlInjected.Address(RVA = "0xE64C30", Offset = "0xE63A30", VA = "0x180E64C30")]
		public static implicit operator RenderRootHandleData(RootHandle handle)
		{
			return default(RenderRootHandleData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public class BLXFJPMWXRA : ICleanupComponentData, IComponentData, ICloneable
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public ZTDVRFUZKOK XFBMSAZLWIL
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xAA0BE0", Offset = "0xA9F9E0", VA = "0x180AA0BE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xAA0FA0", Offset = "0xA9FDA0", VA = "0x180AA0FA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8676A80", Offset = "0x8675880", VA = "0x188676A80", Slot = "4")]
		public object Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		[UnityEngine.Scripting.Preserve]
		public BLXFJPMWXRA()
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
		[Cpp2IlInjected.Address(RVA = "0xE64C30", Offset = "0xE63A30", VA = "0x180E64C30")]
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
		[Cpp2IlInjected.Address(RVA = "0xE64C30", Offset = "0xE63A30", VA = "0x180E64C30")]
		public static implicit operator ShapeRootHandleData(RootHandle handle)
		{
			return default(ShapeRootHandleData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class AJBVUBCUXJD : IComponentData, ICloneable, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public XAYFDJKSMND IMMVUYJXVZY
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0xAA0BE0", Offset = "0xA9F9E0", VA = "0x180AA0BE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0xAA0FA0", Offset = "0xA9FDA0", VA = "0x180AA0FA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x866F8F0", Offset = "0x866E6F0", VA = "0x18866F8F0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x866F880", Offset = "0x866E680", VA = "0x18866F880", Slot = "4")]
		public object Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		[UnityEngine.Scripting.Preserve]
		public AJBVUBCUXJD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public class FFEXUFYACXQ : JUFHTMVKHDQ, UDCPQXYTPVB, DEGCUYLQHBR, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public PrimitiveShapeMeshType DKFRHAUXOCI
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xF2E2E0", Offset = "0xF2D0E0", VA = "0x180F2E2E0", Slot = "27")]
			[CompilerGenerated]
			get
			{
				return default(PrimitiveShapeMeshType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool ITUDPBCSIPE
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x167FA50", Offset = "0x167E850", VA = "0x18167FA50", Slot = "28")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public float3 SSVDKOXEQKK
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x1312500", Offset = "0x1311300", VA = "0x181312500", Slot = "29")]
			[CompilerGenerated]
			get
			{
				return default(float3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x8677CF0", Offset = "0x8676AF0", VA = "0x188677CF0")]
		public FFEXUFYACXQ(UniformTRS a, RRObject b, float c, float3 d, ShapeColor e, ShapeMaterial f, PrimitiveShapeMeshType g, float3 h, bool i)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8677C90", Offset = "0x8676A90", VA = "0x188677C90", Slot = "25")]
		public override UnityEngine.Hash128 ComputeHash()
		{
			return default(UnityEngine.Hash128);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "26")]
		public override void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class YZGMNVOYAWO : JUFHTMVKHDQ, XAYFDJKSMND, DEGCUYLQHBR, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private NativeArray<CurvePointData> XSHVEGQJPQV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private readonly SplineParameterFlags KGZKRTVYYPR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private readonly float NQSDGXREDSA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private readonly int GKSQCOPETOQ;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool HRZTJMPZFTR
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x868FBE0", Offset = "0x868E9E0", VA = "0x18868FBE0", Slot = "27")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool EDXOGKZZQXR
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x868FC00", Offset = "0x868EA00", VA = "0x18868FC00", Slot = "28")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool XSIIHIYTHYU
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x868FBF0", Offset = "0x868E9F0", VA = "0x18868FBF0", Slot = "31")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public int NGSGQAQSBZB
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xF79CF0", Offset = "0xF78AF0", VA = "0x180F79CF0", Slot = "32")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public float WBVMCIWXHYM
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xE71E20", Offset = "0xE70C20", VA = "0x180E71E20", Slot = "29")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public int DSSTOCXMMII
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xE759C0", Offset = "0xE747C0", VA = "0x180E759C0", Slot = "30")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x868FB40", Offset = "0x868E940", VA = "0x18868FB40")]
		public YZGMNVOYAWO(UniformTRS a, RRObject b, float c, float3 d, ShapeColor e, ShapeMaterial f, SplineParameterFlags g, float h, int i, NativeArray<CurvePointData> j)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xF9C9D0", Offset = "0xF9B7D0", VA = "0x180F9C9D0", Slot = "33")]
		public NativeArray<CurvePointData> GetNativeCurvePoints()
		{
			return default(NativeArray<CurvePointData>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x868FA70", Offset = "0x868E870", VA = "0x18868FA70", Slot = "25")]
		public override UnityEngine.Hash128 ComputeHash()
		{
			return default(UnityEngine.Hash128);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "26")]
		public override void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class PrimitiveWrapper : FQMITKWICVF, UDCPQXYTPVB, DEGCUYLQHBR, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static readonly Log YLLVKVFSHML;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private static readonly Dictionary<PrimitiveShapeType, PrimitiveShapeMeshType> IYCVLJZUNXS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private PrimitiveShapeMeshType FGJLGOZRATG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private bool RKDIRDAYDDA;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private PrimitiveShapeMeshType UTJWDYEDZSV
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xACE7D0", Offset = "0xACD5D0", VA = "0x180ACE7D0", Slot = "28")]
			get
			{
				return default(PrimitiveShapeMeshType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private bool OCKIYCEQWLB
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xF72030", Offset = "0xF70E30", VA = "0x180F72030", Slot = "29")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public float3 SSVDKOXEQKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x8689580", Offset = "0x8688380", VA = "0x188689580", Slot = "30")]
			get
			{
				return default(float3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x8689560", Offset = "0x8688360", VA = "0x188689560")]
		public PrimitiveWrapper(ObjectLocalId objectLocalId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8688E40", Offset = "0x8687C40", VA = "0x188688E40", Slot = "27")]
		public override UnityEngine.Hash128 ComputeHash()
		{
			return default(UnityEngine.Hash128);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8688E90", Offset = "0x8687C90", VA = "0x188688E90", Slot = "26")]
		public override void Update()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class PKHROUMUOFM : EININLVGWHN, ZTDVRFUZKOK, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private GameObject VQINCARBAAF;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public GameObject LMMQGIQXTVU
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x8680440", Offset = "0x867F240", VA = "0x188680440")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public RRTransform VAENDOSSKUR
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x86804D0", Offset = "0x867F2D0", VA = "0x1886804D0", Slot = "15")]
			get
			{
				return default(RRTransform);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public RootFlags GCEGSUCRZMK
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x8680710", Offset = "0x867F510", VA = "0x188680710", Slot = "16")]
			get
			{
				return default(RootFlags);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x86805D0", Offset = "0x867F3D0", VA = "0x1886805D0")]
		public PKHROUMUOFM(ObjectLocalId a, bool b = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x86802B0", Offset = "0x867F0B0", VA = "0x1886802B0")]
		public void GRNEFWLTAGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x86804D0", Offset = "0x867F2D0", VA = "0x1886804D0")]
		protected RRTransform SDCDJWIRJHN()
		{
			return default(RRTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8680160", Offset = "0x867EF60", VA = "0x188680160")]
		private static bool FCPKYOYBAIY(ObjectLocalId a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8680130", Offset = "0x867EF30", VA = "0x188680130", Slot = "18")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class CJRTUPTOWBH : FQMITKWICVF, XAYFDJKSMND, DEGCUYLQHBR, IDisposable, ITNQEMQJPLY
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private NativeList<CurvePointData> XSHVEGQJPQV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private bool UDXRVQXZTLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private bool ZIPNNDZULZZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private float NQSDGXREDSA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private int GKSQCOPETOQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private bool GHQMKSGZUCM;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private bool ZTPSDOOLHNM
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0xFCD270", Offset = "0xFCC070", VA = "0x180FCD270", Slot = "28")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		private bool DODFVTWRMZU
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x1602B60", Offset = "0x1601960", VA = "0x181602B60", Slot = "29")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private float DTNFKGIQKNB
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xAEE1B0", Offset = "0xAECFB0", VA = "0x180AEE1B0", Slot = "30")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private int UEEWIOHZXBH
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0xB9FA80", Offset = "0xB9E880", VA = "0x180B9FA80", Slot = "31")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		private bool NPHGAZEXHLX
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x110D340", Offset = "0x110C140", VA = "0x18110D340", Slot = "32")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private int EJWNMQGKAOU
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x86770E0", Offset = "0x8675EE0", VA = "0x1886770E0", Slot = "33")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		private int FLSRBLOKRZB
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x8677170", Offset = "0x8675F70", VA = "0x188677170", Slot = "38")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x86774E0", Offset = "0x86762E0", VA = "0x1886774E0")]
		public CJRTUPTOWBH(ObjectLocalId a, [Optional] NativeList<CurvePointData> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8677260", Offset = "0x8676060", VA = "0x188677260", Slot = "26")]
		public override void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8676DE0", Offset = "0x8675BE0", VA = "0x188676DE0", Slot = "27")]
		public override UnityEngine.Hash128 ComputeHash()
		{
			return default(UnityEngine.Hash128);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8676ED0", Offset = "0x8675CD0", VA = "0x188676ED0", Slot = "25")]
		public override void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8677480", Offset = "0x8676280", VA = "0x188677480")]
		public void XMCOCCKKGTM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8676F30", Offset = "0x8675D30", VA = "0x188676F30", Slot = "34")]
		public NativeArray<CurvePointData> GetNativeCurvePoints()
		{
			return default(NativeArray<CurvePointData>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x8677330", Offset = "0x8676130", VA = "0x188677330", Slot = "35")]
		private Vector3 VVCATYBQRDW(int a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x8677450", Offset = "0x8676250", VA = "0x188677450", Slot = "36")]
		private Quaternion WJKDQBFRUSZ(int a)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x8676C60", Offset = "0x8675A60", VA = "0x188676C60", Slot = "37")]
		private float CHGOUWCKNVT(int a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x8677100", Offset = "0x8675F00", VA = "0x188677100")]
		private NativeArray<Entity> MZDZIHCNOJH()
		{
			return default(NativeArray<Entity>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[SystemEnabledLifetime(Lifetime.LoadInstance)]
	internal sealed class WMMQSWKIIWB : BQYTMZXUYQY
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x868EAB0", Offset = "0x868D8B0", VA = "0x18868EAB0", Slot = "15")]
		protected override ComponentSystemBase ZVKECGKHZYT()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x868EAA0", Offset = "0x868D8A0", VA = "0x18868EAA0", Slot = "13")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x868EF20", Offset = "0x868DD20", VA = "0x18868EF20")]
		[UnityEngine.Scripting.Preserve]
		public WMMQSWKIIWB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[DebugAlwaysUpdateSystem]
	public sealed class AddRemoveRenderRootSystem : XKQVSCNNLGT
	{
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private static readonly Log YLLVKVFSHML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private EntityQuery MSENGLIWTDY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private EntityQuery IWXABYMSSWI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private EntityQuery RDQWLVAKXGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private EntityQuery RYXBRGFKXEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private EntityQuery TBICYEDWIYX;

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x8670520", Offset = "0x866F320", VA = "0x188670520", Slot = "5")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x8670850", Offset = "0x866F650", VA = "0x188670850", Slot = "13")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x8670000", Offset = "0x866EE00", VA = "0x188670000")]
		private void FLEYTWDWFOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x86703F0", Offset = "0x866F1F0", VA = "0x1886703F0")]
		private void NSPLFFFYIWC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x8670890", Offset = "0x866F690", VA = "0x188670890")]
		private void TIKLVAFJUTE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x8670A80", Offset = "0x866F880", VA = "0x188670A80")]
		private void XXJEWWIYSKW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x8670200", Offset = "0x866F000", VA = "0x188670200")]
		private void HGALAIXSIZS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x866FFB0", Offset = "0x866EDB0", VA = "0x18866FFB0")]
		private NativeList<Entity> DPVABVBPXAY(NativeArray<Entity> a)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x86703A0", Offset = "0x866F1A0", VA = "0x1886703A0")]
		private NativeList<Entity> LHGGEPINSCZ(NativeArray<Entity> a)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x8670330", Offset = "0x866F130", VA = "0x188670330")]
		private void KQUIOQKGIOU(NativeArray<Entity> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x3079C30", Offset = "0x3078A30", VA = "0x183079C30")]
		[UnityEngine.Scripting.Preserve]
		public AddRemoveRenderRootSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[DebugAlwaysUpdateSystem]
	[CompilerGenerated]
	public sealed class AddRemoveShapeRenderersSystem : XKQVSCNNLGT, LYBXKQOLIUF
	{
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private static readonly Log YLLVKVFSHML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private EntityQuery MHBGAXPAIOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private EntityQuery YPTJBYTMIBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private EntityQuery GLGFBCFXZJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private LQFCBWMLAAX BNVMESBICCI;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x8671B40", Offset = "0x8670940", VA = "0x188671B40", Slot = "5")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x8671300", Offset = "0x8670100", VA = "0x188671300", Slot = "15")]
		public override void InitReferences(YKMTYEBAAOC services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x8671CF0", Offset = "0x8670AF0", VA = "0x188671CF0", Slot = "13")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x8671360", Offset = "0x8670160", VA = "0x188671360")]
		private void JDXMCRZSIZS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x8670C40", Offset = "0x866FA40", VA = "0x188670C40")]
		private void BRVBHELBGYM(NativeParallelHashSet<RootHandle> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x8672000", Offset = "0x8670E00", VA = "0x188672000")]
		private void RVFNQESVZSI(NativeParallelHashSet<RootHandle> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x8671730", Offset = "0x8670530", VA = "0x188671730")]
		private void OKXDZNZNPSV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x8671F50", Offset = "0x8670D50", VA = "0x188671F50")]
		private bool RMZNVPOJETZ(Entity a, [Out] RootHandle b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x8671D10", Offset = "0x8670B10", VA = "0x188671D10")]
		internal bool QQXBZVTIFVD(Entity a, [Out] RootHandle b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x3079C30", Offset = "0x3078A30", VA = "0x183079C30")]
		[UnityEngine.Scripting.Preserve]
		public AddRemoveShapeRenderersSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[DebugAlwaysUpdateSystem]
	public sealed class AddShapeWrapperSystem : XKQVSCNNLGT
	{
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private static readonly Log YLLVKVFSHML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private EntityQuery CPWFUZQZETX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private EntityQuery OERIJJKQVAF;

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x8672A80", Offset = "0x8671880", VA = "0x188672A80", Slot = "5")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x8672BB0", Offset = "0x86719B0", VA = "0x188672BB0", Slot = "13")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x8672750", Offset = "0x8671550", VA = "0x188672750")]
		private void BRVBHELBGYM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x8672BD0", Offset = "0x86719D0", VA = "0x188672BD0")]
		private void RVFNQESVZSI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x3079C30", Offset = "0x3078A30", VA = "0x183079C30")]
		[UnityEngine.Scripting.Preserve]
		public AddShapeWrapperSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	public class ApplyShapeModificationsToShapesAndRenderRootsSystem : XKQVSCNNLGT, LYBXKQOLIUF
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
			[Cpp2IlInjected.Address(RVA = "0x8677C30", Offset = "0x8676A30", VA = "0x188677C30", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x8677B40", Offset = "0x8676940", VA = "0x188677B40")]
			private void CVKUDWMCGVY(EntityQueryInJob a, NativeList<Entity> b)
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
			[Cpp2IlInjected.Address(RVA = "0x8677660", Offset = "0x8676460", VA = "0x188677660")]
			public void BZMZICJETYW([In] ArchetypeChunk chunk, int a, bool b, [In] v128 chunkEnabledMask)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x8677830", Offset = "0x8676630", VA = "0x188677830", Slot = "4")]
			private void XZKWBEBXABA([In] ArchetypeChunk chunk, int a, bool b, [In] v128 chunkEnabledMask)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private static readonly Log YLLVKVFSHML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private EntityQuery HODXILXGGPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private EntityQuery VSFZARTRYBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private EntityQuery HCOSHXGIWCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private EntityQuery VDWCWLKDTTA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private EntityQuery YWPPYYUJBQL;

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x8673430", Offset = "0x8672230", VA = "0x188673430", Slot = "5")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x8673840", Offset = "0x8672640", VA = "0x188673840", Slot = "13")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x8673330", Offset = "0x8672130", VA = "0x188673330")]
		private void NMHLYKGTFLH(NativeParallelHashSet<RootHandle> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x8672F90", Offset = "0x8671D90", VA = "0x188672F90")]
		private void NBLTRMZEJFL(NativeParallelHashSet<RootHandle> a, int b, int c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x3079C30", Offset = "0x3078A30", VA = "0x183079C30")]
		[UnityEngine.Scripting.Preserve]
		public ApplyShapeModificationsToShapesAndRenderRootsSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	public class ApplyShapeMoveBetweenBatchedMeshesSystem : XKQVSCNNLGT
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
			[Cpp2IlInjected.Address(RVA = "0x8677840", Offset = "0x8676640", VA = "0x188677840")]
			public void BZMZICJETYW([In] ArchetypeChunk chunk, int a, bool b, [In] v128 chunkEnabledMask)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x8677B30", Offset = "0x8676930", VA = "0x188677B30", Slot = "4")]
			private void NHJKRRDHZFX([In] ArchetypeChunk chunk, int a, bool b, [In] v128 chunkEnabledMask)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private static readonly Log YLLVKVFSHML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private EntityQuery ZJBFKFRIJKQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private EntityQuery TGLKIHQWOYQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private EntityQuery PDZZTJQCNTE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private EntityQuery MMTCPWLMNTI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private EntityQuery IHEXBZMOUHR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private LQFCBWMLAAX EJNPIEPCCFW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private AddRemoveShapeRenderersSystem PGPTYUASYVK;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x8675380", Offset = "0x8674180", VA = "0x188675380", Slot = "5")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x8674E80", Offset = "0x8673C80", VA = "0x188674E80", Slot = "15")]
		public override void InitReferences(YKMTYEBAAOC services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x8675740", Offset = "0x8674540", VA = "0x188675740", Slot = "13")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x8674630", Offset = "0x8673430", VA = "0x188674630")]
		private void ECSISVJGXTK(NativeParallelHashSet<RootHandle> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x8674EE0", Offset = "0x8673CE0", VA = "0x188674EE0")]
		private void NEIOIARTPEX(NativeParallelHashSet<RootHandle> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x8673CA0", Offset = "0x8672AA0", VA = "0x188673CA0")]
		private void BUKTTFSLKTX(NativeParallelHashSet<RootHandle> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x8675B50", Offset = "0x8674950", VA = "0x188675B50")]
		private void QLXVOPJVGTN(NativeParallelHashSet<RootHandle> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x8674100", Offset = "0x8672F00", VA = "0x188674100")]
		private void DFFEOGSDPTM(NativeParallelHashSet<RootHandle> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x8676000", Offset = "0x8674E00", VA = "0x188676000")]
		private void UFHHHFDTORJ(Entity a, ShapeHandle b, RootHandle c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x3079C30", Offset = "0x3078A30", VA = "0x183079C30")]
		[UnityEngine.Scripting.Preserve]
		public ApplyShapeMoveBetweenBatchedMeshesSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public sealed class AttachRenderProxyToEmbodiedContainerSystem : XKQVSCNNLGT
	{
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private static readonly Log YLLVKVFSHML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private EntityQuery XSTQIZWPQRY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private EntityQuery RJTFIYVBGSP;

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x8676280", Offset = "0x8675080", VA = "0x188676280", Slot = "5")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x86764A0", Offset = "0x86752A0", VA = "0x1886764A0", Slot = "13")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x3079C30", Offset = "0x3078A30", VA = "0x183079C30")]
		[UnityEngine.Scripting.Preserve]
		public AttachRenderProxyToEmbodiedContainerSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public class GGJWFHCMBFF : XKQVSCNNLGT
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		[TypeManager.ForcedStableTypeHash(13972172025007325174uL)]
		private struct RemovedFromClusterLodTag : IComponentData
		{
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private EntityQuery EPPHTKWGVPN;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x8679CB0", Offset = "0x8678AB0", VA = "0x188679CB0", Slot = "5")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x8679DE0", Offset = "0x8678BE0", VA = "0x188679DE0", Slot = "13")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x3079C30", Offset = "0x3078A30", VA = "0x183079C30")]
		[UnityEngine.Scripting.Preserve]
		public GGJWFHCMBFF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[DebugAlwaysUpdateSystem]
	internal class RemoveShapeEffectsSystem : XKQVSCNNLGT
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		private class Effect
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public EntityQuery VHGZXAMONID;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public EntityQuery IFKKEJQGYJG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public RemoveEffect HBHNLTCKNYC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public ComponentType FZFUBEKGHYR;

			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
			public Effect()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000037")]
		private delegate void RemoveEffect(NativeArray<ShapeHandle> handle, AZETBOSDKFP shapeEffectManager);

		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private static readonly Log YLLVKVFSHML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private List<Effect> DSAIAJDIFVV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private LDRPGSCOSRW JORKGGIBHCQ;

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x868B1D0", Offset = "0x8689FD0", VA = "0x18868B1D0", Slot = "15")]
		public override void InitReferences(YKMTYEBAAOC services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x868B230", Offset = "0x868A030", VA = "0x18868B230", Slot = "5")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x868B4E0", Offset = "0x868A2E0", VA = "0x18868B4E0", Slot = "13")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x3CD5790", Offset = "0x3CD4590", VA = "0x183CD5790")]
		private void YSNUWEZWLKH<a>(RemoveEffect a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x868BA00", Offset = "0x868A800", VA = "0x18868BA00")]
		private static void VVUDORPUUHF(NativeArray<ShapeHandle> a, AZETBOSDKFP b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x868BDA0", Offset = "0x868ABA0", VA = "0x18868BDA0")]
		private static void ZODQTIOEXHJ(NativeArray<ShapeHandle> a, AZETBOSDKFP b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x868BBD0", Offset = "0x868A9D0", VA = "0x18868BBD0")]
		private static void VXAQYJFEDKP(NativeArray<ShapeHandle> a, AZETBOSDKFP b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x3079C30", Offset = "0x3078A30", VA = "0x183079C30")]
		[UnityEngine.Scripting.Preserve]
		public RemoveShapeEffectsSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[DebugAlwaysUpdateSystem]
	public sealed class RemoveShapesFromShapeRenderer : XKQVSCNNLGT
	{
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private static readonly Log YLLVKVFSHML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private EntityQuery HTMBLQGSSGB;

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x868C000", Offset = "0x868AE00", VA = "0x18868C000", Slot = "5")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x868C0C0", Offset = "0x868AEC0", VA = "0x18868C0C0", Slot = "13")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x3079C30", Offset = "0x3078A30", VA = "0x183079C30")]
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
		[Cpp2IlInjected.Address(RVA = "0x8676AF0", Offset = "0x86758F0", VA = "0x188676AF0", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[RegisterService(typeof(QZBOVILZIFY), new string[] { })]
	[ServiceLifetime(Lifetime.OMRoom)]
	internal class QZBOVILZIFY : LYBXKQOLIUF, BQLXQKHZRWO, OQVTAWVSILE, CKMVDEYKLMG
	{
		[Cpp2IlInjected.Token(Token = "0x200003C")]
		public readonly struct SplineMessageQueueScope : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000090")]
			private readonly QZBOVILZIFY parent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			private readonly bool disposePointData;

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x1B29B00", Offset = "0x1B28900", VA = "0x181B29B00")]
			public SplineMessageQueueScope(QZBOVILZIFY parent, bool disposePointData)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x868D8D0", Offset = "0x868C6D0", VA = "0x18868D8D0")]
			public Queue<BakedSplinesMessage>.Enumerator GetEnumerator()
			{
				return default(Queue<BakedSplinesMessage>.Enumerator);
			}

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x868D620", Offset = "0x868C420", VA = "0x18868D620", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private static readonly Log YLLVKVFSHML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		[DependsOn]
		private CRGTHIQPIZW XPJUOURPMFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		[DependsOn]
		private VMAFCMFMTFQ LLQVXQBGCPT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private List<NativeList<CurvePointData>> PXRRBDSRMHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private List<(Entity, List<GameObject>)> WJYHRQOKFHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private NativeList<ShapeHandle> ROFWBRKKNOX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private AGHFXWZBGQG<BakedSplinesMessage> MOGWPVJZUTU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private AGHFXWZBGQG<BakedPrimitiveMessage> BPBKFSFOGJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private AGHFXWZBGQG<BakedShapeColliderMessage> SXRMKRTYALH;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x8689F60", Offset = "0x8688D60", VA = "0x188689F60", Slot = "4")]
		public void InitReferences(YKMTYEBAAOC services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x868A4C0", Offset = "0x86892C0", VA = "0x18868A4C0")]
		public void UBEKNQQPCLC(NativeList<CurvePointData> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x868A5D0", Offset = "0x86893D0", VA = "0x18868A5D0")]
		public void WGXLNBIPYJH(Entity a, [In] ZQUGSTHCVLE<GameObject> inColliders)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x8689DA0", Offset = "0x8688BA0", VA = "0x188689DA0")]
		public void DWFSLMFYEDP(NativeList<ShapeHandle> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x868A160", Offset = "0x8688F60", VA = "0x18868A160")]
		public void JJYDXZXBYXJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x86896A0", Offset = "0x86884A0", VA = "0x1886896A0")]
		public void BKNNILTEXOI(BJPSQZDWLRZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x8689E20", Offset = "0x8688C20", VA = "0x188689E20")]
		public JobHandle ELVXMLXYCLJ([In] BakedSplinesMessage message, JobHandle a)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x8689EC0", Offset = "0x8688CC0", VA = "0x188689EC0")]
		public JobHandle ELVXMLXYCLJ([In] BakedPrimitiveMessage message, JobHandle a)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x83097F0", Offset = "0x83085F0", VA = "0x1883097F0")]
		public SplineMessageQueueScope GELUGFSAGUG(bool a)
		{
			return default(SplineMessageQueueScope);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x868A390", Offset = "0x8689190", VA = "0x18868A390")]
		public MessageQueueScope<BakedPrimitiveMessage> NHQUVCLNYYM()
		{
			return default(MessageQueueScope<BakedPrimitiveMessage>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x8689650", Offset = "0x8688450", VA = "0x188689650")]
		public MessageQueueScope<BakedShapeColliderMessage> BJBOQYJDNAD()
		{
			return default(MessageQueueScope<BakedShapeColliderMessage>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x8689B80", Offset = "0x8688980", VA = "0x188689B80")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x868A3E0", Offset = "0x86891E0", VA = "0x18868A3E0", Slot = "5")]
		public void QDLPFTNMELS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x868A560", Offset = "0x8689360", VA = "0x18868A560", Slot = "6")]
		private void VROTAZPKECM(YKMTYEBAAOC a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x108FBC0", Offset = "0x108E9C0", VA = "0x18108FBC0", Slot = "7")]
		private void WEWODNDDDHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public QZBOVILZIFY()
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
		[Cpp2IlInjected.Address(RVA = "0x8676B80", Offset = "0x8675980", VA = "0x188676B80", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x8676B90", Offset = "0x8675990", VA = "0x188676B90")]
		public void Dispose(bool disposePointData)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[RegisterService(typeof(PHNBMUFAFUT), new string[] { })]
	[ServiceLifetime(Lifetime.LoadInstance)]
	internal class PHNBMUFAFUT : JFNNEAWOERD, OQVTAWVSILE, CKMVDEYKLMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		[DependsOn]
		private QZBOVILZIFY HPBIKVKOMKO;

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x86800C0", Offset = "0x867EEC0", VA = "0x1886800C0", Slot = "4")]
		public void ShutdownReferences()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x86800E0", Offset = "0x867EEE0", VA = "0x1886800E0", Slot = "5")]
		private void VROTAZPKECM(YKMTYEBAAOC a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0xFCB1A0", Offset = "0xFC9FA0", VA = "0x180FCB1A0", Slot = "6")]
		private void WEWODNDDDHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public PHNBMUFAFUT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[SystemEnabledLifetime(Lifetime.OMRoom)]
	[CompilerGenerated]
	public class PostDeserializeBakeShapesSystem : XKQVSCNNLGT, LYBXKQOLIUF
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
			[Cpp2IlInjected.Address(RVA = "0x867A020", Offset = "0x8678E20", VA = "0x18867A020")]
			public void BZMZICJETYW([In] ArchetypeChunk chunk, int a, bool b, [In] v128 chunkEnabledMask)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x867A3A0", Offset = "0x86791A0", VA = "0x18867A3A0", Slot = "4")]
			private void NHJKRRDHZFX([In] ArchetypeChunk chunk, int a, bool b, [In] v128 chunkEnabledMask)
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
			[Cpp2IlInjected.Address(RVA = "0x867A3B0", Offset = "0x86791B0", VA = "0x18867A3B0")]
			public void BZMZICJETYW([In] ArchetypeChunk chunk, int a, bool b, [In] v128 chunkEnabledMask)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x867A6D0", Offset = "0x86794D0", VA = "0x18867A6D0", Slot = "4")]
			private void NHJKRRDHZFX([In] ArchetypeChunk chunk, int a, bool b, [In] v128 chunkEnabledMask)
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
			[Cpp2IlInjected.Address(RVA = "0x8677510", Offset = "0x8676310", VA = "0x188677510")]
			public void BZMZICJETYW([In] ArchetypeChunk batchInChunk, int a, bool b, [In] v128 chunkEnabledMask)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x8677650", Offset = "0x8676450", VA = "0x188677650", Slot = "4")]
			private void NHJKRRDHZFX([In] ArchetypeChunk chunk, int a, bool b, [In] v128 chunkEnabledMask)
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
				public float3 GQQNTZVWPJC
				{
					[Cpp2IlInjected.Token(Token = "0x600013E")]
					[Cpp2IlInjected.Address(RVA = "0x86808E0", Offset = "0x867F6E0", VA = "0x1886808E0")]
					get
					{
						return default(float3);
					}
					[Cpp2IlInjected.Token(Token = "0x600013F")]
					[Cpp2IlInjected.Address(RVA = "0x8680900", Offset = "0x867F700", VA = "0x188680900")]
					set
					{
					}
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000046")]
			private interface GBZVWAOKLAZ
			{
				[Cpp2IlInjected.Token(Token = "0x6000140")]
				[Cpp2IlInjected.Address(Slot = "0")]
				float3 LTGAKIJGFWP(quaternion a);
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000047")]
			private struct LegacyDirectionFromRotation : GBZVWAOKLAZ
			{
				[Cpp2IlInjected.Token(Token = "0x6000141")]
				[Cpp2IlInjected.Address(RVA = "0x867EF40", Offset = "0x867DD40", VA = "0x18867EF40", Slot = "5")]
				public float3 WSLZBMLEXPG(quaternion a)
				{
					return default(float3);
				}

				[Cpp2IlInjected.Token(Token = "0x6000142")]
				[Cpp2IlInjected.Address(RVA = "0x867EF00", Offset = "0x867DD00", VA = "0x18867EF00", Slot = "4")]
				public float3 LTGAKIJGFWP(quaternion a)
				{
					return default(float3);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000048")]
			private struct NewDirectionFromRotation : GBZVWAOKLAZ
			{
				[Cpp2IlInjected.Token(Token = "0x6000143")]
				[Cpp2IlInjected.Address(RVA = "0x867FD90", Offset = "0x867EB90", VA = "0x18867FD90", Slot = "4")]
				public float3 LTGAKIJGFWP(quaternion a)
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
			[Cpp2IlInjected.Address(RVA = "0x867AD00", Offset = "0x8679B00", VA = "0x18867AD00")]
			public void BZMZICJETYW([In] ArchetypeChunk chunk, int a, bool b, [In] v128 chunkEnabledMask)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x867BAF0", Offset = "0x867A8F0", VA = "0x18867BAF0")]
			private void GSDEEYFQQHI(NativeList<PointSrcData> a, NativeList<CurvePointData> b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x867CE50", Offset = "0x867BC50", VA = "0x18867CE50")]
			public static Vector3 JZEZICZAWEN(Vector3 a, Vector3 b, Vector3 c)
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x867CA80", Offset = "0x867B880", VA = "0x18867CA80")]
			public static quaternion HIILCAPLZEC(float3 a, float3 b)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x867D690", Offset = "0x867C490", VA = "0x18867D690")]
			private static quaternion TUKBVEDHDEG(float3 a, float b, quaternion c)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x867CB00", Offset = "0x867B900", VA = "0x18867CB00")]
			private static float3 JDOVLBCVYNM(float3 a, float b, float3 c)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x867DA70", Offset = "0x867C870", VA = "0x18867DA70")]
			private static quaternion WHUSDEGDTLX(float3 a, float b)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x867B360", Offset = "0x867A160", VA = "0x18867B360")]
			private static CurvePointData DWVQPVBZIAF(int a, NativeList<PointSrcData> b)
			{
				return default(CurvePointData);
			}

			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x3F11580", Offset = "0x3F10380", VA = "0x183F11580")]
			private void DXRVZKEPATY<a>(NativeArray<Entity> a, NativeList<PointSrcData> b, float c, a d) where a : struct, GBZVWAOKLAZ
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x867DCB0", Offset = "0x867CAB0", VA = "0x18867DCB0")]
			private void XUYAJECISQX(NativeList<PointSrcData> a, NativeList<CurvePointData> b, float c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x867CCD0", Offset = "0x867BAD0", VA = "0x18867CCD0")]
			public static float JHTTHFEVQHM(float3 a, float3 b, float3 c)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x867D260", Offset = "0x867C060", VA = "0x18867D260")]
			private static quaternion Lerp(quaternion q1, quaternion q2, float t)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x867D570", Offset = "0x867C370", VA = "0x18867D570")]
			private static CurvePointData NKMKMPHFIAY(PointSrcData a)
			{
				return default(CurvePointData);
			}

			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x867D4E0", Offset = "0x867C2E0", VA = "0x18867D4E0")]
			private static CurvePointData NKMKMPHFIAY(float3 a, quaternion b, float c)
			{
				return default(CurvePointData);
			}

			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x867B2C0", Offset = "0x867A0C0", VA = "0x18867B2C0")]
			private static bool DFEVUNBJGBR(float3 a, float b, [Out] float3 c)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x867AC30", Offset = "0x8679A30", VA = "0x18867AC30")]
			private static float3 BBRTCSKXIXM(float3 a, float b)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x867D8C0", Offset = "0x867C6C0", VA = "0x18867D8C0")]
			public static float3 UHWYPENLWQA(quaternion a)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0x867DB00", Offset = "0x867C900", VA = "0x18867DB00")]
			public static float3 WSLZBMLEXPG(quaternion a)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x867B690", Offset = "0x867A490", VA = "0x18867B690")]
			private static quaternion DXAYAHWJVUJ(quaternion a, float3 b)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x867AAC0", Offset = "0x86798C0", VA = "0x18867AAC0")]
			private static float Angle(float3 from, float3 to)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0x867D450", Offset = "0x867C250", VA = "0x18867D450", Slot = "4")]
			private void NHJKRRDHZFX([In] ArchetypeChunk chunk, int a, bool b, [In] v128 chunkEnabledMask)
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
			[Cpp2IlInjected.Address(RVA = "0x8680DD0", Offset = "0x867FBD0", VA = "0x188680DD0")]
			private void VZKWSMEOHFB(DynamicBuffer<LinkedEntityGroup> a, int b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(RVA = "0x8680950", Offset = "0x867F750", VA = "0x188680950")]
			[CompilerGenerated]
			public void BZMZICJETYW([In] ArchetypeChunk chunk, int a, bool b, [In] v128 chunkEnabledMask)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x8680DC0", Offset = "0x867FBC0", VA = "0x188680DC0", Slot = "4")]
			private void NHJKRRDHZFX([In] ArchetypeChunk chunk, int a, bool b, [In] v128 chunkEnabledMask)
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
			[Cpp2IlInjected.Address(RVA = "0x868DBD0", Offset = "0x868C9D0", VA = "0x18868DBD0")]
			private void VZKWSMEOHFB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0x868DBC0", Offset = "0x868C9C0", VA = "0x18868DBC0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x868D5D0", Offset = "0x868C3D0", VA = "0x18868D5D0")]
			private void VZKWSMEOHFB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0x868D5C0", Offset = "0x868C3C0", VA = "0x18868D5C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x867A6F0", Offset = "0x86794F0", VA = "0x18867A6F0")]
			private void VZKWSMEOHFB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0x867A6E0", Offset = "0x86794E0", VA = "0x18867A6E0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x867A8C0", Offset = "0x86796C0", VA = "0x18867A8C0")]
			private void VZKWSMEOHFB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x867A8B0", Offset = "0x86796B0", VA = "0x18867A8B0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x868ADA0", Offset = "0x8689BA0", VA = "0x18868ADA0")]
			private void VZKWSMEOHFB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x868AD90", Offset = "0x8689B90", VA = "0x18868AD90", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x868DC30", Offset = "0x868CA30", VA = "0x18868DC30")]
			public void ZRDOSMDGGFB(SystemState a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private static readonly Log YLLVKVFSHML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private EntityQuery MGUZZMDNEGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private EntityQuery ABXOZNHUDTW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private GDYPKISYKAS KAPEIMIYNBU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private CRGTHIQPIZW XPJUOURPMFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private QZBOVILZIFY HPBIKVKOMKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private PostDeserializeECB OIHBXKTKMCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private TypeHandle ZFEIBEUDHWT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private EntityQuery SFRZXMMLYZR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private EntityQuery SFMTAFSOPOI;

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x8682220", Offset = "0x8681020", VA = "0x188682220", Slot = "15")]
		public override void InitReferences(YKMTYEBAAOC services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x8683780", Offset = "0x8682580", VA = "0x188683780", Slot = "5")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x8683850", Offset = "0x8682650", VA = "0x188683850", Slot = "6")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x86838B0", Offset = "0x86826B0", VA = "0x1886838B0", Slot = "13")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x8683F40", Offset = "0x8682D40", VA = "0x188683F40")]
		private JobHandle UOGWSSWUOYE(EntityQuery a, Entity b, JobHandle c)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x8682F90", Offset = "0x8681D90", VA = "0x188682F90")]
		private JobHandle OOBMKWVFQJG(EntityQuery a, Entity b, JobHandle c)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x8681B50", Offset = "0x8680950", VA = "0x188681B50")]
		private JobHandle ZYMRGLBZFMX(NativeArray<int> a, NativeList<CurvePointData> b, JobHandle c)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x86822C0", Offset = "0x86810C0", VA = "0x1886822C0")]
		private JobHandle JXCVJSLONCW(NativeList<CurvePointData> a, NativeArray<int> b, JobHandle c)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x8682360", Offset = "0x8681160", VA = "0x188682360")]
		private JobHandle KNBGUJHJVVZ(EntityQuery a, NativeList<RecRoom.Foundation.Collections.Range> b, NativeList<CurvePointData> c, NativeArray<int> d, JobHandle e)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x8682050", Offset = "0x8680E50", VA = "0x188682050")]
		private JobHandle INNZLAPYUPR(EntityCommandBuffer a, JobHandle b)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x8683E10", Offset = "0x8682C10", VA = "0x188683E10")]
		private JobHandle SLDJWDJSGFS(NativeArray<int> a, JobHandle b)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x8682CD0", Offset = "0x8681AD0", VA = "0x188682CD0")]
		private JobHandle NEHQACRDQKF(EntityQuery a, [Out] NativeList<Entity> b, [Out] NativeList<Entity> c, [Out] NativeList<BakedPrimitiveData> d, [Out] NativeParallelHashSet<Entity> e, JobHandle f, Allocator g = Allocator.TempJob)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x8680FE0", Offset = "0x867FDE0", VA = "0x188680FE0")]
		private JobHandle BGJGNZZURSJ(EntityQuery a, [Out] NativeList<Entity> b, [Out] NativeList<Entity> c, [Out] NativeList<RecRoom.Foundation.Collections.Range> d, [Out] NativeList<BakedSplineData> e, [Out] NativeParallelHashSet<Entity> f, JobHandle g, Allocator h = Allocator.TempJob)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x8681850", Offset = "0x8680650", VA = "0x188681850")]
		private JobHandle DDFHDKBRSSW(NativeList<Entity> a, NativeList<Entity> b, EntityCommandBuffer c, JobHandle d)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x86812B0", Offset = "0x86800B0", VA = "0x1886812B0")]
		private JobHandle CAZLGKYFCMM(EntityQuery a, NativeList<BakedPrimitiveData> b, JobHandle c)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x86828B0", Offset = "0x86816B0", VA = "0x1886828B0")]
		private static NativeParallelHashMap<int, PrimitiveShapeMeshType> LMBJQZQIYCW()
		{
			return default(NativeParallelHashMap<int, PrimitiveShapeMeshType>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x8681C00", Offset = "0x8680A00", VA = "0x188681C00")]
		private JobHandle FMHOVXZUFIC(EntityQuery a, NativeList<RecRoom.Foundation.Collections.Range> b, NativeList<CurvePointData> c, NativeList<BakedSplineData> d, JobHandle e)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x8684480", Offset = "0x8683280", VA = "0x188684480")]
		private JobHandle ZPSNAOCPQXX(EntityCommandBuffer.ParallelWriter a, JobHandle b)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x8681B50", Offset = "0x8680950", VA = "0x188681B50")]
		private JobHandle EBRBFFGOTAP(NativeArray<int> a, NativeList<CurvePointData> b, JobHandle c)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x86822C0", Offset = "0x86810C0", VA = "0x1886822C0")]
		private JobHandle PYOXSNEIGWC(NativeList<CurvePointData> a, NativeArray<int> b, JobHandle c)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x8684370", Offset = "0x8683170", VA = "0x188684370")]
		private JobHandle WKHUPWRDDAV(EntityQueryInJob a, EntityTypeHandle b, ComponentTypeHandle<ParentData> c, NativeList<Entity> d, NativeList<Entity> e, NativeParallelHashSet<Entity> f, NativeList<BakedPrimitiveData> g, JobHandle h)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x8684240", Offset = "0x8683040", VA = "0x188684240")]
		private JobHandle VEFHRMCJBNL(EntityQueryInJob a, EntityTypeHandle b, ComponentTypeHandle<ParentData> c, NativeList<Entity> d, NativeList<Entity> e, NativeParallelHashSet<Entity> f, NativeList<RecRoom.Foundation.Collections.Range> g, NativeList<BakedSplineData> h, JobHandle i)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x8680EB0", Offset = "0x867FCB0", VA = "0x188680EB0")]
		private JobHandle AAZKCWXXOSO(NativeList<Entity> a, NativeList<Entity> b, EntityCommandBuffer c, BufferLookup<ChildBuffer> d, BufferLookup<AuthoredChildBuffer> e, JobHandle f)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x8683A20", Offset = "0x8682820", VA = "0x188683A20")]
		private void PGUQMBZOKXW(SystemState a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x86836F0", Offset = "0x86824F0", VA = "0x1886836F0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x3079C30", Offset = "0x3078A30", VA = "0x183079C30")]
		[UnityEngine.Scripting.Preserve]
		public PostDeserializeBakeShapesSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public class PTBMCVLCZTD : JPHEEIIEARZ, LYBXKQOLIUF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private QZBOVILZIFY HPBIKVKOMKO;

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x8680870", Offset = "0x867F670", VA = "0x188680870", Slot = "14")]
		public void InitReferences(YKMTYEBAAOC services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x86808C0", Offset = "0x867F6C0", VA = "0x1886808C0", Slot = "13")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x2DC7C40", Offset = "0x2DC6A40", VA = "0x182DC7C40")]
		[UnityEngine.Scripting.Preserve]
		public PTBMCVLCZTD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[SystemEnabledLifetime(Lifetime.LoadInstance)]
	[CompilerGenerated]
	public class PostLoadCreateBakedShapesWrappersSystem : XKQVSCNNLGT, LYBXKQOLIUF
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
			public (Entity parent, Transform containerWrapper, NativeArray<T> descriptors) NGVXCXHTPEU
			{
				[Cpp2IlInjected.Token(Token = "0x6000169")]
				[Cpp2IlInjected.Address(RVA = "0x4356850", Offset = "0x4355650", VA = "0x184356850")]
				get
				{
					return default((Entity, Transform, NativeArray<T>));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x4356AB0", Offset = "0x43558B0", VA = "0x184356AB0")]
			public DescriptorSetEnumerator(EntityManager entityManager, EntityDataArrays<T> set, NativeArray<EntityRemapUtility.EntityRemapInfo> entityRemapping)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x43227D0", Offset = "0x43215D0", VA = "0x1843227D0")]
			public DescriptorSetEnumerator<T> GetEnumerator()
			{
				return default(DescriptorSetEnumerator<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x4355D60", Offset = "0x4354B60", VA = "0x184355D60")]
			public bool MoveNext()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private static readonly Log YLLVKVFSHML;

		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private static readonly Log VWVEQRCFCXB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private VMAFCMFMTFQ LLQVXQBGCPT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private QZBOVILZIFY HPBIKVKOMKO;

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x8686670", Offset = "0x8685470", VA = "0x188686670", Slot = "15")]
		public override void InitReferences(YKMTYEBAAOC services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x8685260", Offset = "0x8684060", VA = "0x188685260")]
		public void BETIWBFUTUG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x8686DE0", Offset = "0x8685BE0", VA = "0x188686DE0", Slot = "13")]
		[UnityEngine.Scripting.Preserve]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x8685800", Offset = "0x8684600", VA = "0x188685800")]
		private void HYVXIIJOTHW(BakedShapeColliderMessage a, Mesh[] b, NativeArray<EntityRemapUtility.EntityRemapInfo> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x3BC86E0", Offset = "0x3BC74E0", VA = "0x183BC86E0")]
		private DescriptorSetEnumerator<T> PUKLDWCICBH<T>(EntityDataArrays<T> a, NativeArray<EntityRemapUtility.EntityRemapInfo> b) where T : struct
		{
			return default(DescriptorSetEnumerator<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x8685290", Offset = "0x8684090", VA = "0x188685290")]
		private void BZLQLRECGLV(Transform a, NativeArray<SphereDescriptor> b, ZQUGSTHCVLE<GameObject> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x8688810", Offset = "0x8687610", VA = "0x188688810")]
		private void XOWDVDWUPJX(Transform a, NativeArray<BoxDescriptor> b, ZQUGSTHCVLE<GameObject> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x8687BC0", Offset = "0x86869C0", VA = "0x188687BC0")]
		private void RQGGRIWTRBN(Transform a, NativeArray<CapsuleDescriptor> b, ZQUGSTHCVLE<GameObject> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x8687F70", Offset = "0x8686D70", VA = "0x188687F70")]
		private void TCNXGZAYSSH(Transform a, NativeArray<MeshDescriptor> b, Mesh[] c, ZQUGSTHCVLE<GameObject> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x86855F0", Offset = "0x86843F0", VA = "0x1886855F0")]
		private static void GMTLBLXONBM(NativeParallelHashSet<Entity> a, NativeParallelHashSet<Entity> b, NativeArray<EntityRemapUtility.EntityRemapInfo> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x8688C70", Offset = "0x8687A70", VA = "0x188688C70")]
		private static void YNCTRIOLZEY(NativeList<Entity> a, NativeArray<EntityRemapUtility.EntityRemapInfo> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x86846A0", Offset = "0x86834A0", VA = "0x1886846A0")]
		private NativeParallelHashMap<Entity, RenderRootHandleData> AICSGEKXVLI(QZBOVILZIFY.SplineMessageQueueScope a, MessageQueueScope<BakedPrimitiveMessage> b, List<GameObject> c)
		{
			return default(NativeParallelHashMap<Entity, RenderRootHandleData>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x8686CD0", Offset = "0x8685AD0", VA = "0x188686CD0")]
		private NativeArray<EntityRemapUtility.EntityRemapInfo> OLDXPDHBEEH(Entity a)
		{
			return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x86866F0", Offset = "0x86854F0", VA = "0x1886866F0")]
		private void NYJETQPCGBE(NativeList<Entity> a, NativeList<Entity> b, NativeParallelHashMap<Entity, RenderRootHandleData> c, NativeList<RecRoom.Foundation.Collections.Range> d, NativeList<CurvePointData> e, NativeList<BakedSplineData> f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x8688380", Offset = "0x8687180", VA = "0x188688380")]
		private void WGVUGBJGXXS(NativeList<Entity> a, NativeList<Entity> b, NativeParallelHashMap<Entity, RenderRootHandleData> c, NativeList<BakedPrimitiveData> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x3079C30", Offset = "0x3078A30", VA = "0x183079C30")]
		[UnityEngine.Scripting.Preserve]
		public PostLoadCreateBakedShapesWrappersSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public abstract class BJSNNHAOVNI : XIQSHBEVKAK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public readonly UniformTRS ZLNKKLYAZVT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private readonly RRObject TNQRTSDCHDV;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		private GameObject NXCTSZFJHLS
		{
			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0xA9E190", Offset = "0xA9CF90", VA = "0x180A9E190", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public UniformTRS CAZVHWWWTPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x8690C90", Offset = "0x868FA90", VA = "0x188690C90", Slot = "8")]
			get
			{
				return default(UniformTRS);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		private Vector3 ODEJJLXZGYK
		{
			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0x8690DF0", Offset = "0x868FBF0", VA = "0x188690DF0", Slot = "10")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		private Matrix4x4 WKRBOXTQKGW
		{
			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x8690B90", Offset = "0x868F990", VA = "0x188690B90", Slot = "9")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		private Vector3 PVDWQOOPQWW
		{
			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x8690C10", Offset = "0x868FA10", VA = "0x188690C10", Slot = "4")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x8690D70", Offset = "0x868FB70", VA = "0x188690D70", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		private Quaternion AJYVDOOIILB
		{
			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x8690BD0", Offset = "0x868F9D0", VA = "0x188690BD0", Slot = "6")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x8690C50", Offset = "0x868FA50", VA = "0x188690C50", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		private Vector3 PMGXTXKCJMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x8690B50", Offset = "0x868F950", VA = "0x188690B50", Slot = "11")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		private Vector3 KVKCJNDAYDC
		{
			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x8690B10", Offset = "0x868F910", VA = "0x188690B10", Slot = "13")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		private Vector3 GYCCUOKSDLA
		{
			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x8690DB0", Offset = "0x868FBB0", VA = "0x188690DB0", Slot = "14")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x8690E30", Offset = "0x868FC30", VA = "0x188690E30")]
		public BJSNNHAOVNI(UniformTRS a, RRObject b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public abstract class JUFHTMVKHDQ : BJSNNHAOVNI, DEGCUYLQHBR, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private readonly float WJWHVAUUVEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private readonly float3 WUFOSCHCCBZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private readonly ShapeColor VEZSAEDSFUT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private readonly ShapeMaterial AACGXIKFRPP;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		private RRTransform CEHTVRCMFQU
		{
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x8692580", Offset = "0x8691380", VA = "0x188692580", Slot = "17")]
			get
			{
				return default(RRTransform);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		private UniformTRS PFZQCCYOWTS
		{
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x86924A0", Offset = "0x86912A0", VA = "0x1886924A0", Slot = "18")]
			get
			{
				return default(UniformTRS);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		private float SPOAROAXOKT
		{
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0xDF8D20", Offset = "0xDF7B20", VA = "0x180DF8D20", Slot = "19")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		private Vector3 MVWUADSXWGQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x8692450", Offset = "0x8691250", VA = "0x188692450", Slot = "20")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		private ShapeColor PJZOWOHPBLK
		{
			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0xB9FA80", Offset = "0xB9E880", VA = "0x180B9FA80", Slot = "21")]
			get
			{
				return default(ShapeColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		private ShapeMaterial BTBAHXUDFEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x1563DC0", Offset = "0x1562BC0", VA = "0x181563DC0", Slot = "22")]
			get
			{
				return default(ShapeMaterial);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		private bool PZOCPXRDSST
		{
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0xAE7F40", Offset = "0xAE6D40", VA = "0x180AE7F40", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool RPFPUJKWYUZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0xAE7F40", Offset = "0xAE6D40", VA = "0x180AE7F40", Slot = "15")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180")]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x86925C0", Offset = "0x86913C0", VA = "0x1886925C0")]
		protected JUFHTMVKHDQ(UniformTRS a, RRObject b, float c, float3 d, ShapeColor e, ShapeMaterial f)
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
	public abstract class EININLVGWHN : XIQSHBEVKAK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		protected readonly ObjectLocalId QVOCJURUVEV;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		protected RRObject CZUIQZSZEGY
		{
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x13B9CC0", Offset = "0x13B8AC0", VA = "0x1813B9CC0")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		protected Entity BOGVRXYXLGY
		{
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x8691360", Offset = "0x8690160", VA = "0x188691360")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		protected CRGTHIQPIZW OQAENTIHWXH
		{
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x86917A0", Offset = "0x86905A0", VA = "0x1886917A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		protected OZYDAXBPNCU EIGXMZDAUFF
		{
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x8691190", Offset = "0x868FF90", VA = "0x188691190")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		protected UCXYUXXQFIN EHNWRXLIRJI
		{
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x8691710", Offset = "0x8690510", VA = "0x188691710")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		private GameObject NXCTSZFJHLS
		{
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x86915D0", Offset = "0x86903D0", VA = "0x1886915D0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public UniformTRS CAZVHWWWTPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x13DB800", Offset = "0x13DA600", VA = "0x1813DB800", Slot = "8")]
			get
			{
				return default(UniformTRS);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		private Vector3 ODEJJLXZGYK
		{
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x8691AE0", Offset = "0x86908E0", VA = "0x188691AE0", Slot = "10")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		private Matrix4x4 WKRBOXTQKGW
		{
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x86911F0", Offset = "0x868FFF0", VA = "0x1886911F0", Slot = "9")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		private Vector3 PVDWQOOPQWW
		{
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x86914A0", Offset = "0x86902A0", VA = "0x1886914A0", Slot = "4")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x86917B0", Offset = "0x86905B0", VA = "0x1886917B0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		private Quaternion AJYVDOOIILB
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x8691380", Offset = "0x8690180", VA = "0x188691380", Slot = "6")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x8691600", Offset = "0x8690400", VA = "0x188691600", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		private Vector3 PMGXTXKCJMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x86910A0", Offset = "0x868FEA0", VA = "0x1886910A0", Slot = "11")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		private Vector3 KVKCJNDAYDC
		{
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x8690E80", Offset = "0x868FC80", VA = "0x188690E80", Slot = "13")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		private Vector3 GYCCUOKSDLA
		{
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x86918C0", Offset = "0x86906C0", VA = "0x1886918C0", Slot = "14")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0xFFD4C0", Offset = "0xFFC2C0", VA = "0x180FFD4C0")]
		protected EININLVGWHN(ObjectLocalId a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x8691BD0", Offset = "0x86909D0", VA = "0x188691BD0")]
		public static implicit operator RRTransform(EININLVGWHN t)
		{
			return default(RRTransform);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public static class ANVOKCKAIIE
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x86908B0", Offset = "0x868F6B0", VA = "0x1886908B0")]
		public static void DHYEZFUTTQB(NativeArray<Entity> a, EntityManager b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public static class ZHYIVTQGCGP
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x86931F0", Offset = "0x8691FF0", VA = "0x1886931F0")]
		public static void TARLCLYMWJZ(NativeArray<Entity> a, EntityManager b, BJPSQZDWLRZ c, CRGTHIQPIZW d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x8692ED0", Offset = "0x8691CD0", VA = "0x188692ED0")]
		public static void PIIFQXQMMAI(NativeArray<Entity> a, EntityManager b, BJPSQZDWLRZ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x8692BF0", Offset = "0x86919F0", VA = "0x188692BF0")]
		public static NativeList<Entity> LHGGEPINSCZ(NativeArray<Entity> a, EntityManager b)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x8692BC0", Offset = "0x86919C0", VA = "0x188692BC0")]
		public static NativeList<Entity> DPVABVBPXAY(NativeArray<Entity> a, EntityManager b)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x8692C20", Offset = "0x8691A20", VA = "0x188692C20")]
		private static NativeList<Entity> LHGGEPINSCZ(NativeArray<Entity> a, EntityManager b, bool c)
		{
			return default(NativeList<Entity>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public abstract class FQMITKWICVF : EININLVGWHN, DEGCUYLQHBR, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private float WJWHVAUUVEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private Vector3 WUFOSCHCCBZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private ShapeColor VEZSAEDSFUT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private ShapeMaterial AACGXIKFRPP;

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		protected EntityManager HXWPISFIQHB
		{
			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x8691C00", Offset = "0x8690A00", VA = "0x188691C00")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		protected WONIJGYOYUN YTCRBXLUSCB
		{
			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x8691D50", Offset = "0x8690B50", VA = "0x188691D50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		protected ShapeConfigData ZUVPDTAEWGC
		{
			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x8691FE0", Offset = "0x8690DE0", VA = "0x188691FE0")]
			get
			{
				return default(ShapeConfigData);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		private RRTransform CEHTVRCMFQU
		{
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x8691BD0", Offset = "0x86909D0", VA = "0x188691BD0", Slot = "17")]
			get
			{
				return default(RRTransform);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		private float SPOAROAXOKT
		{
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0xAF9280", Offset = "0xAF8080", VA = "0x180AF9280", Slot = "19")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		private Vector3 MVWUADSXWGQ
		{
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x14A3DA0", Offset = "0x14A2BA0", VA = "0x1814A3DA0", Slot = "20")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		private ShapeColor PJZOWOHPBLK
		{
			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0xAA7120", Offset = "0xAA5F20", VA = "0x180AA7120", Slot = "21")]
			get
			{
				return default(ShapeColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		private ShapeMaterial BTBAHXUDFEI
		{
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0xC4BE30", Offset = "0xC4AC30", VA = "0x180C4BE30", Slot = "22")]
			get
			{
				return default(ShapeMaterial);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		private UniformTRS PFZQCCYOWTS
		{
			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x13DB800", Offset = "0x13DA600", VA = "0x1813DB800", Slot = "18")]
			get
			{
				return default(UniformTRS);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public bool RPFPUJKWYUZ
		{
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0xB009E0", Offset = "0xAFF7E0", VA = "0x180B009E0", Slot = "15")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0xB01120", Offset = "0xAFFF20", VA = "0x180B01120")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		private bool PZOCPXRDSST
		{
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0xAE7F40", Offset = "0xAE6D40", VA = "0x180AE7F40", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x86921B0", Offset = "0x8690FB0", VA = "0x1886921B0")]
		protected FQMITKWICVF(ObjectLocalId a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "25")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x8691DE0", Offset = "0x8690BE0", VA = "0x188691DE0", Slot = "26")]
		public virtual void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(Slot = "27")]
		public abstract UnityEngine.Hash128 ComputeHash();
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[SystemEnabledLifetime(Lifetime.LoadInstance)]
	public abstract class XKQVSCNNLGT : JPHEEIIEARZ, LYBXKQOLIUF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		protected CRGTHIQPIZW XXADBSGXIEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private MZPGVNSEBXC CHVUAIGFBDA;

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		protected BJPSQZDWLRZ XOZZOHMVTIC
		{
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x8692B70", Offset = "0x8691970", VA = "0x188692B70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		protected AZETBOSDKFP TWKIEHNFAUI
		{
			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x8692A60", Offset = "0x8691860", VA = "0x188692A60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		protected bool SKQBPSUNSDP
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x8692AB0", Offset = "0x86918B0", VA = "0x188692AB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x86929F0", Offset = "0x86917F0", VA = "0x1886929F0", Slot = "15")]
		public virtual void InitReferences(YKMTYEBAAOC services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x2DC7C40", Offset = "0x2DC6A40", VA = "0x182DC7C40")]
		[UnityEngine.Scripting.Preserve]
		protected XKQVSCNNLGT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public static class JMNUPHRUFDI
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x86921F0", Offset = "0x8690FF0", VA = "0x1886921F0")]
		public static void SVOPUETLXVY(NativeArray<Entity> a, EntityManager b)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__3702368055
{
	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x8693620", Offset = "0x8692420", VA = "0x188693620")]
	public static void JFMNTDRBNOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x8693610", Offset = "0x8692410", VA = "0x188693610")]
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
