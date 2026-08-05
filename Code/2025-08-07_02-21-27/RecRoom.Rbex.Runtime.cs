using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.Attributes;
using RecRoom.Core;
using RecRoom.Core.Culling;
using RecRoom.DataLayer;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Foundation.Service;
using RecRoom.Logging;
using RecRoom.Logging.Attributes;
using RecRoom.Networking;
using RecRoom.NoEngine.DataStructures.Tokens;
using RecRoom.ObjectModel;
using RecRoom.Rbex;
using RecRoom.Utils.OverridableFields;
using UnityEngine;
using UnityEngine.Serialization;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xB3E190", Offset = "0xB3CD90", VA = "0x180B3E190")]
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
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xB3EE40", Offset = "0xB3DA40", VA = "0x180B3EE40")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace _LogRegistration.RecRoom_Rbex_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Obfuscation(ApplyToMembers = false)]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : RecRoom.Logging.LogRegistrationIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x91FC3D0", Offset = "0x91FAFD0", VA = "0x1891FC3D0", Slot = "4")]
		public override void Register()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xB3E190", Offset = "0xB3CD90", VA = "0x180B3E190")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_Rbex_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	[Obfuscation(ApplyToMembers = false)]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private int[] XIOCEUOZJGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private int[] XIIVHNVBZUY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private ServiceBitset MVEDDDGEAHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private ServiceBitset MVJKAKABJST;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xB13A50", Offset = "0xB12650", VA = "0x180B13A50", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x269CC00", Offset = "0x269B800", VA = "0x18269CC00", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x92129C0", Offset = "0x92115C0", VA = "0x1892129C0")]
		private void SGYKGOYOYBS(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9212B10", Offset = "0x9211710", VA = "0x189212B10")]
		private void SHDRDVSMHNB(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x92127E0", Offset = "0x92113E0", VA = "0x1892127E0", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9212DF0", Offset = "0x92119F0", VA = "0x189212DF0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[RegisterService(typeof(TIVJGIVYTUW), new string[] { "Ignore", "Mock" })]
	public class ATXOULZDRKJ : TIVJGIVYTUW
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool KXIHDYXAWBH
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xBF7030", Offset = "0xBF5C30", VA = "0x180BF7030", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "5")]
		public void NWQJZNRBKMH(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "6")]
		public void HKBERAJWAGC(RigidbodyEx a, Action b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xB16800", Offset = "0xB15400", VA = "0x180B16800", Slot = "7")]
		public BRLFXVSOLAS NRBZXOPXJKJ(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "8")]
		public void RBRZTWABGVF(Vector3 a, float b, Color c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public ATXOULZDRKJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[DisallowMultipleComponent]
	public sealed class RigidbodyEx : MonoBehaviour, SDMULJARPSS, QKMOLDHPCOF, PTPJAIETWZR
	{
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static readonly Log JPZFUOUUBDZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private bool LLJQFHOOIGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private VJGXMHXJSVW KSZMUGQCHCX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[SerializeField]
		[AutofillOptional(AutofillType.Self, false, false, false)]
		private Rigidbody unityRigidbody;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		[SerializeField]
		[AutofillOptional(AutofillType.SelfAndParent, true, false, false)]
		private RRNetworkView rrNetworkView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[SerializeField]
		private OverridableVector3 precomputedCenterOfMass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[SerializeField]
		private OverridableVector3 customCenterOfMass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		[SerializeField]
		[FormerlySerializedAs("forceNoInterpolation")]
		private RbexInterpolationMode physicsInterpolation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		[SerializeField]
		[TooltipAttribute("If checked, this object's Unity Rigidbody will not be stripped when parenting the object to another RigidbodyEx. Only check this on objects that have a Unity Rigidbody by default and who need access to Unity physics events like OnTriggerEnter, OnCollisionEnter, etc. This is sometimes set via script instead of this flag.")]
		private bool keepUnityRigidbodyWhileParented;

		[Cpp2IlInjected.FieldOffset(Offset = "0x65")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		[SerializeField]
		[TooltipAttribute("If the RigidbodyEx has a parent that is being destroyed, this flag allows this RigidbodyEx to keep the parent set. The default behavior is thatthe parent property is set to null, resetting/clearing the existing parent when it is being destroyed.")]
		private bool keepParentOnParentDestroy;

		[Cpp2IlInjected.FieldOffset(Offset = "0x66")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		[SerializeField]
		[HideInInspector]
		private bool hasUnityRigidbodyByDefault;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private Transform MPCGKMLBPBH;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		internal VJGXMHXJSVW NWWZNPHHTAT
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x9209680", Offset = "0x9208280", VA = "0x189209680")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private VJGXMHXJSVW XUNCJMDTYFZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xB131D0", Offset = "0xB11DD0", VA = "0x180B131D0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int XARHCUBFBQQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x920AFE0", Offset = "0x9209BE0", VA = "0x18920AFE0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx STWSMLZLBWJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x920B3A0", Offset = "0x9209FA0", VA = "0x18920B3A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RigidbodyEx DXAPXCCARDD
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x920B2E0", Offset = "0x9209EE0", VA = "0x18920B2E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public RigidbodyEx GUMKFVWGXHL
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x920BFA0", Offset = "0x920ABA0", VA = "0x18920BFA0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x920D4A0", Offset = "0x920C0A0", VA = "0x18920D4A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool ESOPMAEKFHE
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x85AEE40", Offset = "0x85ADA40", VA = "0x1885AEE40", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x85AEFB0", Offset = "0x85ADBB0", VA = "0x1885AEFB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Transform CVWZDLYBYWH
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x2825FE0", Offset = "0x2824BE0", VA = "0x182825FE0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Transform OOCNPVZRKPU
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x2825FE0", Offset = "0x2824BE0", VA = "0x182825FE0", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public Transform LWNDTJZFBSU
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x2825FE0", Offset = "0x2824BE0", VA = "0x182825FE0", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public TransformTrackRate CBNLXLSYODE
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x920B040", Offset = "0x9209C40", VA = "0x18920B040")]
			get
			{
				return default(TransformTrackRate);
			}
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x920CC50", Offset = "0x920B850", VA = "0x18920CC50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool TTOOCIHUSTN
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x920B6B0", Offset = "0x920A2B0", VA = "0x18920B6B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool BFDQKOWTRKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x920B1C0", Offset = "0x9209DC0", VA = "0x18920B1C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public OTOMQYRBXFI WXFZPZLGWYX
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x920B5F0", Offset = "0x920A1F0", VA = "0x18920B5F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x920CE10", Offset = "0x920BA10", VA = "0x18920CE10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public KMTQBZRQLZD MWWCGERNMFA
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x920B590", Offset = "0x920A190", VA = "0x18920B590")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x920CDA0", Offset = "0x920B9A0", VA = "0x18920CDA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool AKVAOCQGUNK
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x920B4E0", Offset = "0x920A0E0", VA = "0x18920B4E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Rigidbody UYFXLBSICUR
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x920B540", Offset = "0x920A140", VA = "0x18920B540")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool EMTUNSUCYTW
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x920B220", Offset = "0x9209E20", VA = "0x18920B220")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x920CCC0", Offset = "0x920B8C0", VA = "0x18920CCC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public bool MFADXQSIOWF
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x85AEFA0", Offset = "0x85ADBA0", VA = "0x1885AEFA0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float NSIPYYQXXCZ
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x920BF40", Offset = "0x920AB40", VA = "0x18920BF40")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public float PNTOKCZTJNY
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x920BEE0", Offset = "0x920AAE0", VA = "0x18920BEE0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x920D430", Offset = "0x920C030", VA = "0x18920D430")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public float SVDTCVQSKYL
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x920B910", Offset = "0x920A510", VA = "0x18920B910")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x920D0B0", Offset = "0x920BCB0", VA = "0x18920D0B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public float RDVSYCZAUNF
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x920B710", Offset = "0x920A310", VA = "0x18920B710")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x920CE80", Offset = "0x920BA80", VA = "0x18920CE80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public bool VNAKAMMQRGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x920C4F0", Offset = "0x920B0F0", VA = "0x18920C4F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x920D9E0", Offset = "0x920C5E0", VA = "0x18920D9E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public Vector3 MEEIZATYUQM
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x920BCC0", Offset = "0x920A8C0", VA = "0x18920BCC0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x920D200", Offset = "0x920BE00", VA = "0x18920D200")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public Vector3 TTGPYIJXRRV
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x920C630", Offset = "0x920B230", VA = "0x18920C630")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public CollisionDetectionMode RRFLYOGUMCB
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x920B850", Offset = "0x920A450", VA = "0x18920B850")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x920CFD0", Offset = "0x920BBD0", VA = "0x18920CFD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public float HKVLPYKZACW
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x920B280", Offset = "0x9209E80", VA = "0x18920B280")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x920CD30", Offset = "0x920B930", VA = "0x18920CD30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public RigidbodyConstraints XFSXWXUNYAT
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x920B8B0", Offset = "0x920A4B0", VA = "0x18920B8B0")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x920D040", Offset = "0x920BC40", VA = "0x18920D040")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public Vector3 VZNTAUMDVMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x920C060", Offset = "0x920AC60", VA = "0x18920C060")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public Vector3 QCNHHKRQKRZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x920C060", Offset = "0x920AC60", VA = "0x18920C060")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x920D7C0", Offset = "0x920C3C0", VA = "0x18920D7C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public float HHWKISAFTOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x920BDA0", Offset = "0x920A9A0", VA = "0x18920BDA0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x920D2E0", Offset = "0x920BEE0", VA = "0x18920D2E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public float VPXZKWVFZCL
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x920C490", Offset = "0x920B090", VA = "0x18920C490")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x920D970", Offset = "0x920C570", VA = "0x18920D970")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Quaternion YKMXCFJCNPG
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x920C140", Offset = "0x920AD40", VA = "0x18920C140")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x920D540", Offset = "0x920C140", VA = "0x18920D540")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Quaternion LOTERXSXKPY
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x920C3C0", Offset = "0x920AFC0", VA = "0x18920C3C0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x920D8A0", Offset = "0x920C4A0", VA = "0x18920D8A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Vector3 QEEOQQHRHMU
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x920C210", Offset = "0x920AE10", VA = "0x18920C210")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x920D610", Offset = "0x920C210", VA = "0x18920D610")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Quaternion PKOQTYLCZHT
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x920C2F0", Offset = "0x920AEF0", VA = "0x18920C2F0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x920D6F0", Offset = "0x920C2F0", VA = "0x18920D6F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 SHUANJMWXSC
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x920C550", Offset = "0x920B150", VA = "0x18920C550")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x920DA50", Offset = "0x920C650", VA = "0x18920DA50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector3 YKJZDOWTRZF
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x920BE00", Offset = "0x920AA00", VA = "0x18920BE00")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x920D350", Offset = "0x920BF50", VA = "0x18920D350")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector3 QZXDBDOOOFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x920B770", Offset = "0x920A370", VA = "0x18920B770")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x920CEF0", Offset = "0x920BAF0", VA = "0x18920CEF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector3 RPRVPGZNPVP
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x920BBE0", Offset = "0x920A7E0", VA = "0x18920BBE0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x920D120", Offset = "0x920BD20", VA = "0x18920D120")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Vector3 SAKQUTVRLWQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x920BAA0", Offset = "0x920A6A0", VA = "0x18920BAA0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public Quaternion GOLXKPRDHBY
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x920B9D0", Offset = "0x920A5D0", VA = "0x18920B9D0")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public Vector3 FTMMETLSGRY
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x920C7F0", Offset = "0x920B3F0", VA = "0x18920C7F0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public Vector3 LFUWCXJJVGW
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x920C710", Offset = "0x920B310", VA = "0x18920C710")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool DJSLVSZKYWK
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x920BB80", Offset = "0x920A780", VA = "0x18920BB80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool VESMGKKHZZJ
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x920B650", Offset = "0x920A250", VA = "0x18920B650")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool SFWWWPRJAJA
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x920B160", Offset = "0x9209D60", VA = "0x18920B160")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool OQQEWNEDHRX
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x920B100", Offset = "0x9209D00", VA = "0x18920B100")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public bool PWXNWVAIILG
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x920AF80", Offset = "0x9209B80", VA = "0x18920AF80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool OWDJHYUPRDR
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x920B970", Offset = "0x920A570", VA = "0x18920B970")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public bool VAIKGMZRCIN
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x20740E0", Offset = "0x2072CE0", VA = "0x1820740E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public IEnumerable<object> LFBRTOJCMRV
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x920B0A0", Offset = "0x9209CA0", VA = "0x18920B0A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event RbexParentChangeAction EBJEOPJEQWV
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x920AEA0", Offset = "0x9209AA0", VA = "0x18920AEA0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x920CB70", Offset = "0x920B770", VA = "0x18920CB70")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event RbexAction XMVXHFGJDPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x920AC10", Offset = "0x9209810", VA = "0x18920AC10")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x920C8D0", Offset = "0x920B4D0", VA = "0x18920C8D0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event RbexAction LZMSQWWVAMT
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x920AC70", Offset = "0x9209870", VA = "0x18920AC70")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x920C940", Offset = "0x920B540", VA = "0x18920C940")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event RbexAction MTFGNCCRUXX
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x920ADC0", Offset = "0x92099C0", VA = "0x18920ADC0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x920CA90", Offset = "0x920B690", VA = "0x18920CA90")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<UpdateLOD, UpdateLOD> EWXILSTNKDJ
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x920AD50", Offset = "0x9209950", VA = "0x18920AD50")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x920CA20", Offset = "0x920B620", VA = "0x18920CA20")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event RbexAction OAKIBDYDRLE
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x920AE30", Offset = "0x9209A30", VA = "0x18920AE30")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x920CB00", Offset = "0x920B700", VA = "0x18920CB00")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event RbexAction BHLACNXMTPS
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x920AF10", Offset = "0x9209B10", VA = "0x18920AF10")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x920CBE0", Offset = "0x920B7E0", VA = "0x18920CBE0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event RbexAction ZUFIPEPAUOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x920ACE0", Offset = "0x92098E0", VA = "0x18920ACE0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x920C9B0", Offset = "0x920B5B0", VA = "0x18920C9B0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xB180C0", Offset = "0xB16CC0", VA = "0x180B180C0", Slot = "8")]
		private void ULVDZHUIHUB(VJGXMHXJSVW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x9209180", Offset = "0x9207D80", VA = "0x189209180", Slot = "9")]
		public RigidbodyExData GetData()
		{
			return default(RigidbodyExData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x9209210", Offset = "0x9207E10", VA = "0x189209210")]
		internal void HMVATCVTJIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x920A930", Offset = "0x9209530", VA = "0x18920A930")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public void TestOverrideUnityRigidbody(Rigidbody rb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x9208ED0", Offset = "0x9207AD0", VA = "0x189208ED0")]
		public SDMULJARPSS GetChild(int index)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x920A5F0", Offset = "0x92091F0", VA = "0x18920A5F0")]
		public void SetInertiaTensor((Quaternion rot, Vector3 moments) tensor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x92089F0", Offset = "0x92075F0", VA = "0x1892089F0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x920A880", Offset = "0x9209480", VA = "0x18920A880")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x9209680", Offset = "0x9208280", VA = "0x189209680")]
		private VJGXMHXJSVW YLBMPQEYGEF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x92092A0", Offset = "0x9207EA0", VA = "0x1892092A0")]
		private void HRTIXRMSTIX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x9209C80", Offset = "0x9208880", VA = "0x189209C80")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x9209A80", Offset = "0x9208680", VA = "0x189209A80")]
		public void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x92098A0", Offset = "0x92084A0", VA = "0x1892098A0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x9209C20", Offset = "0x9208820", VA = "0x189209C20")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x9209E20", Offset = "0x9208A20", VA = "0x189209E20")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x9208040", Offset = "0x9206C40", VA = "0x189208040")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x9209E80", Offset = "0x9208A80", VA = "0x189209E80")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x9208E70", Offset = "0x9207A70", VA = "0x189208E70")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x9209840", Offset = "0x9208440", VA = "0x189209840")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x920A750", Offset = "0x9209350", VA = "0x18920A750")]
		public void SetParent(RigidbodyEx value, bool isPhysicallyDetachedOnly = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x920A190", Offset = "0x9208D90", VA = "0x18920A190")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x9209420", Offset = "0x9208020", VA = "0x189209420")]
		public bool IsRigidbodyAncestor(RigidbodyEx possibleAncestor)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x9209520", Offset = "0x9208120", VA = "0x189209520")]
		public bool IsRigidbodyDescendant(RigidbodyEx possibleDescendant)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x92082B0", Offset = "0x9206EB0", VA = "0x1892082B0")]
		public void AddInterpolationRestriction(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x9209EF0", Offset = "0x9208AF0", VA = "0x189209EF0")]
		public void RemoveInterpolationRestriction(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x9208320", Offset = "0x9206F20", VA = "0x189208320")]
		public void AddKinematic(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x9209F60", Offset = "0x9208B60", VA = "0x189209F60")]
		public void RemoveKinematic(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x920A6D0", Offset = "0x92092D0", VA = "0x18920A6D0")]
		public void SetKinematic(object token, bool setKinematic)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x920A4F0", Offset = "0x92090F0", VA = "0x18920A4F0")]
		public void SetDiscontinuousPositionAndRotation(Vector3 newPosition, Quaternion newRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x920A3F0", Offset = "0x9208FF0", VA = "0x18920A3F0")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 newLocalPosition, Quaternion newLocalRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x9209070", Offset = "0x9207C70", VA = "0x189209070")]
		public Vector3 GetConstrainedVelocity(Vector3 velocity)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x9208F60", Offset = "0x9207B60", VA = "0x189208F60")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 angularVelocity)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x92081C0", Offset = "0x9206DC0", VA = "0x1892081C0")]
		public void AddForce(Vector3 force, ForceMode forceMode = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x92080B0", Offset = "0x9206CB0", VA = "0x1892080B0")]
		public void AddForceAtPosition(Vector3 force, Vector3 position, ForceMode forceMode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x92084F0", Offset = "0x92070F0", VA = "0x1892084F0")]
		public void AddTorque(Vector3 torque, ForceMode forceMode = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x9208390", Offset = "0x9206F90", VA = "0x189208390")]
		public void AddRelativeTorque(Vector3 torque, ForceMode forceMode = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x920AA00", Offset = "0x9209600", VA = "0x18920AA00")]
		public Vector3 WorldToLocalVelocity(Vector3 worldVelocity)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x9209730", Offset = "0x9208330", VA = "0x189209730")]
		public Vector3 LocalToWorldVelocity(Vector3 localVelocity)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x9208E10", Offset = "0x9207A10", VA = "0x189208E10")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x9208DB0", Offset = "0x92079B0", VA = "0x189208DB0")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x9208D50", Offset = "0x9207950", VA = "0x189208D50")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x9208CF0", Offset = "0x92078F0", VA = "0x189208CF0")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x920A2F0", Offset = "0x9208EF0", VA = "0x18920A2F0")]
		public void ResetVelocityWorldSpace(Vector3 worldLinearVelocity, Vector3 worldAngularVelocity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x920A1F0", Offset = "0x9208DF0", VA = "0x18920A1F0")]
		public void ResetVelocityLocalSpace(Vector3 localLinearVelocity, Vector3 localAngularVelocity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x920A0B0", Offset = "0x9208CB0", VA = "0x18920A0B0")]
		public void ResetLinearVelocityLocalSpace(Vector3 localLinearVelocity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x920A890", Offset = "0x9209490", VA = "0x18920A890")]
		public bool SweepTest(Vector3 direction, [Out] RaycastHit hitInfo, float maxDistance)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x9209620", Offset = "0x9208220", VA = "0x189209620")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x920A820", Offset = "0x9209420", VA = "0x18920A820")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x920A9A0", Offset = "0x92095A0", VA = "0x18920A9A0")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x9208480", Offset = "0x9207080", VA = "0x189208480")]
		public void AddShouldHaveUnityRigidbodyToken(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x9209FD0", Offset = "0x9208BD0", VA = "0x189209FD0")]
		public void RemoveShouldHaveUnityRigidbodyToken(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x9208880", Offset = "0x9207480", VA = "0x189208880")]
		public void ApplyForceVelocityChange(RbexImpulseType impulseType, Vector3 impulseDirection, float impulseSpeed, float impulseDirectionMaxSpeed = 8f, float impulseReflectiveRestitution = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x9208780", Offset = "0x9207380", VA = "0x189208780")]
		public void ApplyAngularVelocityChange(RbexRotationType rotationType, Vector3 newAngularVelocity, float maxAngularSpeed = 1f / 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x9208940", Offset = "0x9207540", VA = "0x189208940")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void ApplyTorqueAngularVelocityChangeDeprecated(RbexRotationType rotationType, Vector3 rotation, float maxSpeed = 7f, float multiplyingFactor = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x92086B0", Offset = "0x92072B0", VA = "0x1892086B0")]
		public bool AllowedScaleChange(float scaleFactor)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x92085E0", Offset = "0x92071E0", VA = "0x1892085E0")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx parentOverride, object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x920A040", Offset = "0x9208C40", VA = "0x18920A040")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x8D4DF50", Offset = "0x8D4CB50", VA = "0x188D4DF50", Slot = "13")]
		private void ZIGFYDZFKDQ(XWQWSOJWOPS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x920ABA0", Offset = "0x92097A0", VA = "0x18920ABA0")]
		public RigidbodyEx()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0xBC8240", Offset = "0xBC6E40", VA = "0x180BC8240", Slot = "4")]
		private GameObject EXBYSNWRBXL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0xB40790", Offset = "0xB3F390", VA = "0x180B40790", Slot = "10")]
		private bool LQQJYPNELKO()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	internal static class ALRSXHIDBKD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x91F58F0", Offset = "0x91F44F0", VA = "0x1891F58F0")]
		public static VJGXMHXJSVW NWWZNPHHTAT(this RigidbodyEx a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[RegisterService(typeof(TSTWEOXDCJX), new string[] { })]
	public class RigidbodyExManager : TSTWEOXDCJX, PEEXKGKATXF
	{
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private static readonly Log DNBXSEXRPWR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private TIVJGIVYTUW CTKZLRUOMOT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private JJTGIRIQDEJ HXZJHGYAEZD;

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public TIVJGIVYTUW WYXWMMZBGZF
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0xB13A40", Offset = "0xB12640", VA = "0x180B13A40", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public JJTGIRIQDEJ ZOUMXACDANT
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x9207F40", Offset = "0x9206B40", VA = "0x189207F40", Slot = "7")]
		public void InitReferences(BVNDYEZSFBO services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x9207E10", Offset = "0x9206A10", VA = "0x189207E10", Slot = "6")]
		public VJGXMHXJSVW EGDZFVLJDUD(RigidbodyEx a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public RigidbodyExManager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class PhysicsManager : SingletonMonoBehaviour<PhysicsManager>
	{
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public static AQWXMNIFQIV UpdateAfterFixedUpdateRan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private int LTGLFTAEZBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private int YNMBNTMNFGZ;

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x9204E30", Offset = "0x9203A30", VA = "0x189204E30")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x9204EB0", Offset = "0x9203AB0", VA = "0x189204EB0")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x9204E50", Offset = "0x9203A50", VA = "0x189204E50")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string message, [Optional] UnityEngine.Object context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string message, [Optional] UnityEngine.Object context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x9204FB0", Offset = "0x9203BB0", VA = "0x189204FB0")]
		public PhysicsManager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public static class QOJUXTJRXWB
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		private class ITLUNNYRBWZ : OTOMQYRBXFI, IDisposable
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "7")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0xB24620", Offset = "0xB23220", VA = "0x180B24620", Slot = "4")]
			public Vector3 IHGBAYEQSYA()
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0xB24620", Offset = "0xB23220", VA = "0x180B24620", Slot = "5")]
			public Vector3 XYYROKZNGCL()
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0xB2EAD0", Offset = "0xB2D6D0", VA = "0x180B2EAD0", Slot = "6")]
			public bool EQUMPAKRLIS(float a, float b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public ITLUNNYRBWZ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public static OTOMQYRBXFI PYFMFEPGLJW
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x92051B0", Offset = "0x9203DB0", VA = "0x1892051B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}
	}
}
namespace RecRoom.Rbex
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public interface CBZLBVRACQG
	{
		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		CollisionDetectionMode KGYBFHKMZUZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void Awake();

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void IAXNIZSJDKP(bool a);

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void AQMXNDQIHBQ(bool a);

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void SLYFAQEHFXK(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool SEBZRIFIIOL(Vector3 a, [Out] RaycastHit b, float c);
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface LOLOWUHIZQX : IDisposable, TSDOMBQKPJV
	{
		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		TransformTrackRate CBNLXLSYODE
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		event Action<UpdateLOD, UpdateLOD> EWXILSTNKDJ;

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void Awake();
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[ServiceLifetime(Lifetime.Application)]
	public interface JJTGIRIQDEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		PUDSYZOXUZG FULSPTHCCII(VJGXMHXJSVW a);

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		MAHUHELQKQK TNENJGGHTZM(VJGXMHXJSVW a);

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		QVDLSNHORQH PVBBBQYYDDZ(VJGXMHXJSVW a);

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(Slot = "3")]
		KTAMILONBGI PURGHLETYPK(VJGXMHXJSVW a);

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "4")]
		LXFLPVDYESE VHAHHZWZZLG(VJGXMHXJSVW a);

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "5")]
		LOLOWUHIZQX QBUPVROSAGH(VJGXMHXJSVW a);

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(Slot = "6")]
		SASXJXQWDYK DIBJSVGNKXI(VJGXMHXJSVW a);

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(Slot = "7")]
		ZKVKFDITUUE VJZLGTFYFYY(VJGXMHXJSVW a);

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(Slot = "8")]
		CBZLBVRACQG YVWAVPQUSOC(VJGXMHXJSVW a);

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(Slot = "9")]
		JOHMEWMMAUN KFQJXPYOOLX(VJGXMHXJSVW a);

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(Slot = "10")]
		UHBYESJLXPX ORNCIVGSJND(VJGXMHXJSVW a, [In] RigidbodyExData data);

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(Slot = "11")]
		UYBNHAMFGSL BBKMVTFFKDZ(VJGXMHXJSVW a, [In] RigidbodyExData data);

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(Slot = "12")]
		NETYWGKBFDD ELSRPDDPSAV(VJGXMHXJSVW a, [In] RigidbodyExData data);

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(Slot = "13")]
		NUOZBEKXOFF WRVWQNZJNGH(VJGXMHXJSVW a, [In] RigidbodyExData data);

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "14")]
		IEAKDRPWBED WAUPXAIFEEH(VJGXMHXJSVW a, [In] RigidbodyExData data);

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(Slot = "15")]
		VJGXMHXJSVW EGDZFVLJDUD(RigidbodyEx a, RigidbodyExData b, TSTWEOXDCJX c);
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public interface ZKVKFDITUUE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void PIGDUUEVXWX(Vector3 a, ForceMode b = ForceMode.Force);

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void YLVMDYXFEPP(Vector3 a, Vector3 b, ForceMode c);

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void DGARRKSINKK(Vector3 a, ForceMode b = ForceMode.Force);

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void WPCRJOORFOK(Vector3 a, ForceMode b = ForceMode.Force);
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public interface JOHMEWMMAUN
	{
		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		bool RKTDPEGGFIO
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void SLYFAQEHFXK(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void GTUVJRMXRUB(Rigidbody a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public interface PUDSYZOXUZG : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		IReadOnlyList<VJGXMHXJSVW> RCSNJKPBFUZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(Slot = "18")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		VJGXMHXJSVW DXAPXCCARDD
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(Slot = "19")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		VJGXMHXJSVW MJTMBSVCHQR
		{
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(Slot = "20")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(Slot = "21")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		event RbexAction XMVXHFGJDPD;

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		event RbexAction LZMSQWWVAMT;

		[Cpp2IlInjected.Token(Token = "0x1400000C")]
		event RbexParentChangeAction BGUVDEHFKYD;

		[Cpp2IlInjected.Token(Token = "0x1400000D")]
		event Action LTVNXILVXQO;

		[Cpp2IlInjected.Token(Token = "0x1400000E")]
		event Action CWIKBFCOLAX;

		[Cpp2IlInjected.Token(Token = "0x1400000F")]
		event Action<VJGXMHXJSVW> IQJZYSTXAUC;

		[Cpp2IlInjected.Token(Token = "0x14000010")]
		event Action<VJGXMHXJSVW> YAABKGTYBBL;

		[Cpp2IlInjected.Token(Token = "0x14000011")]
		event Action DQELHWGEGLU;

		[Cpp2IlInjected.Token(Token = "0x14000012")]
		event Action<VJGXMHXJSVW> QKYRIBYMFQX;

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(Slot = "22")]
		void SetParent(VJGXMHXJSVW newParent, bool isPhysicallyDetachedOnly = false);
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public interface QVDLSNHORQH
	{
		[Cpp2IlInjected.Token(Token = "0x17000041")]
		Vector3 ECGPBOHHWSW
		{
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		Vector3 ORFUOSZNTTM
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void VNERPVILVWM(VJGXMHXJSVW a, object b);

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void MMWAPSHDDTL(object a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public interface NUOZBEKXOFF
	{
		[Cpp2IlInjected.Token(Token = "0x17000043")]
		Vector3 KIVIWAVSBHS
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		Vector3 AZSONQWKJCT
		{
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		float MVDYIULDOGF
		{
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		float FACNVUVCSBU
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(Slot = "7")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		Vector3 KKKOVTDHBTW
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		Quaternion JJSJCQZSRJI
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000013")]
		event RbexAction AOMIQOAMSHJ;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void ZZYAMYUXSHE((Quaternion rot, Vector3 moments) tensor);

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(Slot = "11")]
		void XYIVNWBQGIJ();

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void MDOQQSXKYZQ();

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(Slot = "13")]
		void DSLRGUOMRLS();

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void SLYFAQEHFXK(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void GTUVJRMXRUB(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void OnDrawGizmosSelected();
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface NETYWGKBFDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Awake();

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void DMOLPFSZBNE(object a);

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void ZOHQGTTJKSR(object a);

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void OXRNBJPIJNP(VJGXMHXJSVW a);

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void PYMIADQNWWA(VJGXMHXJSVW a);

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void BABSCZMVEMV();
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface SASXJXQWDYK
	{
		[Cpp2IlInjected.Token(Token = "0x17000049")]
		bool FJXVDNPRGNE
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		IEnumerable<object> XGQPYPSYUDF
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000014")]
		event RbexAction ISAOIEPOGAK;

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void NCQFELJJLAF(object a);

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void HFCDRWPUKAW(object a);

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void SCXMWOMWVKM(object a, bool b);

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void SLYFAQEHFXK(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void GTUVJRMXRUB(Rigidbody a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface UYBNHAMFGSL : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		bool TTOOCIHUSTN
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		bool BFDQKOWTRKD
		{
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000015")]
		event RbexAction GKOPYGNYTTS;

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void Awake();

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void WJPAHEJZQKP(VJGXMHXJSVW a);

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void BOICBJAOMOT(VJGXMHXJSVW a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public interface IEAKDRPWBED
	{
		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		bool EMTUNSUCYTW
		{
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		bool TADHLLZWAED
		{
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		RigidbodyConstraints HGDDXGFOIFZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(Slot = "4")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void SLYFAQEHFXK(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void GTUVJRMXRUB(Rigidbody a);
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public interface KTAMILONBGI
	{
		[Cpp2IlInjected.Token(Token = "0x17000050")]
		float HCXJIGKMEGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		float JGZFBAAOYPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void SLYFAQEHFXK(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void GTUVJRMXRUB(Rigidbody a);
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public interface LXFLPVDYESE
	{
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		static bool EDFRSBDLDHK;

		[Cpp2IlInjected.Token(Token = "0x14000016")]
		event RbexAction NPXFXXKXVZG;

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void Awake();

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool NPBKCYDOQZW();

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void HKVEXHYIRHA();

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void Sleep();

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool PSHFBTGGMEY();

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool SXXEBJPRQTP();

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void ACXFQBHLQGD(bool a);

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void WFOAUJEMXEU();
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public interface UHBYESJLXPX
	{
		[Cpp2IlInjected.Token(Token = "0x17000052")]
		Rigidbody UYFXLBSICUR
		{
			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		bool PGUWDBEZFDK
		{
			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void Awake();

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void GVJLHNNWPXQ(object a);

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void JDTCQTQFCWN(object a);

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void GVMVUVZUCJC();
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public interface MAHUHELQKQK : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000054")]
		OTOMQYRBXFI WXFZPZLGWYX
		{
			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		KMTQBZRQLZD MWWCGERNMFA
		{
			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		Vector3 ULFUNVSUSPG
		{
			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(Slot = "5")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		Vector3 GJZYQOZGDTR
		{
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(Slot = "7")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		Vector3 UFQTFOTHGJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(Slot = "9")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		Vector3 LPLGASCPCFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(Slot = "11")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		float HKVLPYKZACW
		{
			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(Slot = "13")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		bool AKVAOCQGUNK
		{
			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(Slot = "14")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void Awake();

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void PCCNHEIYPNY(object a);

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(Slot = "17")]
		void AVBJEINMKLS(RbexRotationType a, Vector3 b, float c = 1f / 0f);

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(Slot = "18")]
		void XZCQWDAJRMZ(RbexImpulseType a, Vector3 b, float c, float d = 8f, float e = 1f);

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(Slot = "19")]
		void AIRJEKIEAGD(RbexRotationType a, Vector3 b, float c = 7f, float d = 1f);

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(Slot = "20")]
		void GOWZTISMJAH();

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(Slot = "21")]
		void VCIEMHFRWIE();

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(Slot = "22")]
		void NUKAKVWGFEZ();

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(Slot = "23")]
		void LOZVTLBSINH();

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(Slot = "24")]
		void SLYFAQEHFXK(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(Slot = "25")]
		Vector3 JDJWJKZVBVY(Vector3 a);

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(Slot = "26")]
		void OCFOKWYWOFL(object a);

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(Slot = "27")]
		void YQCNNLQWZZX(Vector3 a);

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(Slot = "28")]
		void UGJGWNFEIZC(Vector3 a, Vector3 b);

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(Slot = "29")]
		void MVLLGENAJVD(Vector3 a, Vector3 b);

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(Slot = "30")]
		Vector3 OBIKNQBTVGI(Vector3 a);

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(Slot = "31")]
		Vector3 VQPXVYQXVPQ(Vector3 a);
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[ServiceLifetime(Lifetime.Application)]
	public interface TIVJGIVYTUW
	{
		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		bool KXIHDYXAWBH
		{
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void NWQJZNRBKMH(string a);

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void HKBERAJWAGC(RigidbodyEx a, Action b);

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		BRLFXVSOLAS NRBZXOPXJKJ(int a);

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void RBRZTWABGVF(Vector3 a, float b, Color c);
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[ServiceLifetime(Lifetime.Application)]
	public interface TSTWEOXDCJX
	{
		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		TIVJGIVYTUW WYXWMMZBGZF
		{
			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		JJTGIRIQDEJ ZOUMXACDANT
		{
			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(Slot = "2")]
		VJGXMHXJSVW EGDZFVLJDUD(RigidbodyEx a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class PHMUBKXKDQD : VJGXMHXJSVW, IDisposable, OXTQNJVQQNF
	{
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public static bool WWWLXSNKQRP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		internal readonly TSTWEOXDCJX ZHYWUYYWQFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		internal PUDSYZOXUZG GRZMMZHEFQU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		internal NETYWGKBFDD SNNGWBFSAOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		internal UYBNHAMFGSL KWFNLAIVEFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		internal MAHUHELQKQK SHUANJMWXSC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		internal QVDLSNHORQH EPZPTELJYYD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		internal NUOZBEKXOFF UCBFHJMEBGX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		internal KTAMILONBGI OJRPWOVHJCQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		internal JOHMEWMMAUN VTDQZCJMRCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		internal LXFLPVDYESE DAWHMEQBFYM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		internal LOLOWUHIZQX ZZKCKMVRZZF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		internal SASXJXQWDYK JWQFBKRYLHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		internal ZKVKFDITUUE XWDVOUQJKHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		internal IEAKDRPWBED OGJLRGNCADB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		internal UHBYESJLXPX BSTNCNBRBWJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		internal CBZLBVRACQG PKJLIRLWKFU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		internal IDisposable ZTTVKLTNDRH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private bool ZGIHRTLDXBL;

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public ObjectLocalId NWWJWJBCTSH
		{
			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0xB16800", Offset = "0xB15400", VA = "0x180B16800", Slot = "22")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public SDMULJARPSS QXZIHXDRAVT
		{
			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0xB74D50", Offset = "0xB73950", VA = "0x180B74D50", Slot = "24")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0xB73950", Offset = "0xB72550", VA = "0x180B73950")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public GameObject EGFDRJDHUWA
		{
			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0xB1B710", Offset = "0xB1A310", VA = "0x180B1B710", Slot = "25")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0xB1B740", Offset = "0xB1A340", VA = "0x180B1B740")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public Transform GZVGTXLLTNF
		{
			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0xB74D40", Offset = "0xB73940", VA = "0x180B74D40", Slot = "26")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0xBD41C0", Offset = "0xBD2DC0", VA = "0x180BD41C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public IEnumerable<object> ONJKMYKXROA
		{
			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x91FEDC0", Offset = "0x91FD9C0", VA = "0x1891FEDC0", Slot = "27")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public Rigidbody UYFXLBSICUR
		{
			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x9201760", Offset = "0x9200360", VA = "0x189201760", Slot = "23")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public VJGXMHXJSVW MJTMBSVCHQR
		{
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x9201FC0", Offset = "0x9200BC0", VA = "0x189201FC0", Slot = "28")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x91FE6A0", Offset = "0x91FD2A0", VA = "0x1891FE6A0", Slot = "29")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public int XARHCUBFBQQ
		{
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x91FE4B0", Offset = "0x91FD0B0", VA = "0x1891FE4B0", Slot = "32")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public VJGXMHXJSVW DXAPXCCARDD
		{
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x9203020", Offset = "0x9201C20", VA = "0x189203020", Slot = "30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public bool VDPFUYLNWQL
		{
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x91FF250", Offset = "0x91FDE50", VA = "0x1891FF250", Slot = "33")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public bool TTOOCIHUSTN
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x92008B0", Offset = "0x91FF4B0", VA = "0x1892008B0", Slot = "34")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public bool BFDQKOWTRKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x91FFD10", Offset = "0x91FE910", VA = "0x1891FFD10", Slot = "35")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public OTOMQYRBXFI WXFZPZLGWYX
		{
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x9202390", Offset = "0x9200F90", VA = "0x189202390", Slot = "36")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x9200FC0", Offset = "0x91FFBC0", VA = "0x189200FC0", Slot = "37")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public KMTQBZRQLZD MWWCGERNMFA
		{
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x92016B0", Offset = "0x92002B0", VA = "0x1892016B0", Slot = "38")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x9200030", Offset = "0x91FEC30", VA = "0x189200030", Slot = "39")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public float HKVLPYKZACW
		{
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x9201980", Offset = "0x9200580", VA = "0x189201980", Slot = "40")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x92036F0", Offset = "0x92022F0", VA = "0x1892036F0", Slot = "41")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public Vector3 GJZYQOZGDTR
		{
			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x92001F0", Offset = "0x91FEDF0", VA = "0x1892001F0", Slot = "42")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0x92007D0", Offset = "0x91FF3D0", VA = "0x1892007D0", Slot = "43")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public Vector3 LPLGASCPCFD
		{
			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x92026B0", Offset = "0x92012B0", VA = "0x1892026B0", Slot = "44")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x91FE070", Offset = "0x91FCC70", VA = "0x1891FE070", Slot = "45")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public Vector3 ULFUNVSUSPG
		{
			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x91FFBE0", Offset = "0x91FE7E0", VA = "0x1891FFBE0", Slot = "46")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x9202F40", Offset = "0x9201B40", VA = "0x189202F40", Slot = "47")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public Vector3 UFQTFOTHGJO
		{
			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x9202260", Offset = "0x9200E60", VA = "0x189202260", Slot = "48")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x91FF8D0", Offset = "0x91FE4D0", VA = "0x1891FF8D0", Slot = "49")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public bool SFWWWPRJAJA
		{
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x91FE520", Offset = "0x91FD120", VA = "0x1891FE520", Slot = "50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public bool OQQEWNEDHRX
		{
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x92013A0", Offset = "0x91FFFA0", VA = "0x1892013A0", Slot = "51")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public bool PWXNWVAIILG
		{
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x91FE5C0", Offset = "0x91FD1C0", VA = "0x1891FE5C0", Slot = "52")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public bool AKVAOCQGUNK
		{
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x91FE380", Offset = "0x91FCF80", VA = "0x1891FE380", Slot = "53")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public Vector3 ECGPBOHHWSW
		{
			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0x92003E0", Offset = "0x91FEFE0", VA = "0x1892003E0", Slot = "54")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public Vector3 ORFUOSZNTTM
		{
			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x9201EE0", Offset = "0x9200AE0", VA = "0x189201EE0", Slot = "55")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public Vector3 KIVIWAVSBHS
		{
			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x9203150", Offset = "0x9201D50", VA = "0x189203150", Slot = "56")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x9203340", Offset = "0x9201F40", VA = "0x189203340", Slot = "57")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public Vector3 AZSONQWKJCT
		{
			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x91FEE70", Offset = "0x91FDA70", VA = "0x1891FEE70", Slot = "58")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public float MVDYIULDOGF
		{
			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x9202130", Offset = "0x9200D30", VA = "0x189202130", Slot = "59")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public float FACNVUVCSBU
		{
			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x92017F0", Offset = "0x92003F0", VA = "0x1892017F0", Slot = "60")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x91FDC90", Offset = "0x91FC890", VA = "0x1891FDC90", Slot = "61")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public Vector3 KKKOVTDHBTW
		{
			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x9203420", Offset = "0x9202020", VA = "0x189203420", Slot = "62")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public Quaternion JJSJCQZSRJI
		{
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x91FF6B0", Offset = "0x91FE2B0", VA = "0x1891FF6B0", Slot = "63")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public float HCXJIGKMEGH
		{
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x9200DC0", Offset = "0x91FF9C0", VA = "0x189200DC0", Slot = "65")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x91FED60", Offset = "0x91FD960", VA = "0x1891FED60", Slot = "66")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public float JGZFBAAOYPB
		{
			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x91FFDC0", Offset = "0x91FE9C0", VA = "0x1891FFDC0", Slot = "67")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x92028F0", Offset = "0x92014F0", VA = "0x1892028F0", Slot = "68")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public bool RKTDPEGGFIO
		{
			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x9200570", Offset = "0x91FF170", VA = "0x189200570", Slot = "69")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x9201650", Offset = "0x9200250", VA = "0x189201650", Slot = "70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public TransformTrackRate CBNLXLSYODE
		{
			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x92019D0", Offset = "0x92005D0", VA = "0x1892019D0", Slot = "71")]
			get
			{
				return default(TransformTrackRate);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x9201700", Offset = "0x9200300", VA = "0x189201700", Slot = "72")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public bool FJXVDNPRGNE
		{
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x91FF2B0", Offset = "0x91FDEB0", VA = "0x1891FF2B0", Slot = "73")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public Transform LWNDTJZFBSU
		{
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0xB74D40", Offset = "0xB73940", VA = "0x180B74D40", Slot = "74")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public Vector3 EQTWTLMMIIA
		{
			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x91FE700", Offset = "0x91FD300", VA = "0x1891FE700", Slot = "75")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x9200D10", Offset = "0x91FF910", VA = "0x189200D10", Slot = "76")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public float JGLJZPQEFWS
		{
			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x92026A0", Offset = "0x92012A0", VA = "0x1892026A0", Slot = "77")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x91FF840", Offset = "0x91FE440", VA = "0x1891FF840", Slot = "78")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public float BPQFRDQATYN
		{
			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x9201640", Offset = "0x9200240", VA = "0x189201640", Slot = "79")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x91FFAE0", Offset = "0x91FE6E0", VA = "0x1891FFAE0", Slot = "80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public Quaternion GSRSZCJWLFP
		{
			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x91FF300", Offset = "0x91FDF00", VA = "0x1891FF300", Slot = "81")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x91FFE10", Offset = "0x91FEA10", VA = "0x1891FFE10", Slot = "82")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public Vector3 JITWWCSUOYD
		{
			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x9201360", Offset = "0x91FFF60", VA = "0x189201360", Slot = "83")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0x92017B0", Offset = "0x92003B0", VA = "0x1892017B0", Slot = "84")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public Quaternion CVDXFZWARDM
		{
			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x9203750", Offset = "0x9202350", VA = "0x189203750", Slot = "85")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x9202620", Offset = "0x9201220", VA = "0x189202620", Slot = "86")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public RigidbodyConstraints HGDDXGFOIFZ
		{
			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0x9202340", Offset = "0x9200F40", VA = "0x189202340", Slot = "87")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0x9201150", Offset = "0x91FFD50", VA = "0x189201150", Slot = "88")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		public bool EMTUNSUCYTW
		{
			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0x92010B0", Offset = "0x91FFCB0", VA = "0x1892010B0", Slot = "89")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0x9202890", Offset = "0x9201490", VA = "0x189202890", Slot = "90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		public CollisionDetectionMode KGYBFHKMZUZ
		{
			[Cpp2IlInjected.Token(Token = "0x60001FE")]
			[Cpp2IlInjected.Address(RVA = "0x9203840", Offset = "0x9202440", VA = "0x189203840", Slot = "91")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x60001FF")]
			[Cpp2IlInjected.Address(RVA = "0x91FE1B0", Offset = "0x91FCDB0", VA = "0x1891FE1B0", Slot = "92")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		public bool GXBSSXFMSLC
		{
			[Cpp2IlInjected.Token(Token = "0x6000201")]
			[Cpp2IlInjected.Address(RVA = "0x9201840", Offset = "0x9200440", VA = "0x189201840", Slot = "142")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		public bool VESMGKKHZZJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000202")]
			[Cpp2IlInjected.Address(RVA = "0x91FEFB0", Offset = "0x91FDBB0", VA = "0x1891FEFB0", Slot = "93")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000017")]
		public event RbexAction XMVXHFGJDPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x91FD580", Offset = "0x91FC180", VA = "0x1891FD580", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x91FFEF0", Offset = "0x91FEAF0", VA = "0x1891FFEF0", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000018")]
		public event RbexAction LZMSQWWVAMT
		{
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x9201D70", Offset = "0x9200970", VA = "0x189201D70", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x9200F00", Offset = "0x91FFB00", VA = "0x189200F00", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000019")]
		public event RbexParentChangeAction BGUVDEHFKYD
		{
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x9200C60", Offset = "0x91FF860", VA = "0x189200C60", Slot = "18")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x9201300", Offset = "0x91FFF00", VA = "0x189201300", Slot = "19")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001A")]
		public event RbexAction GKOPYGNYTTS
		{
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x91FEE10", Offset = "0x91FDA10", VA = "0x1891FEE10", Slot = "8")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x9202180", Offset = "0x9200D80", VA = "0x189202180", Slot = "9")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001B")]
		public event RbexAction MTFGNCCRUXX
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x91FE150", Offset = "0x91FCD50", VA = "0x1891FE150", Slot = "14")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x91FEF50", Offset = "0x91FDB50", VA = "0x1891FEF50", Slot = "15")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001C")]
		public event RbexAction NPXFXXKXVZG
		{
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x9202950", Offset = "0x9201550", VA = "0x189202950", Slot = "16")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x91FFD60", Offset = "0x91FE960", VA = "0x1891FFD60", Slot = "17")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001D")]
		public event Action<UpdateLOD, UpdateLOD> EWXILSTNKDJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x92005C0", Offset = "0x91FF1C0", VA = "0x1892005C0", Slot = "20")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x9200510", Offset = "0x91FF110", VA = "0x189200510", Slot = "21")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001E")]
		public event RbexAction ISAOIEPOGAK
		{
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x91FF7E0", Offset = "0x91FE3E0", VA = "0x1891FF7E0", Slot = "12")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x9200770", Offset = "0x91FF370", VA = "0x189200770", Slot = "13")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001F")]
		public event RbexAction ZUFIPEPAUOP
		{
			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x9203790", Offset = "0x9202390", VA = "0x189203790", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x91FEC50", Offset = "0x91FD850", VA = "0x1891FEC50", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x9203970", Offset = "0x9202570", VA = "0x189203970")]
		public PHMUBKXKDQD(GameObject a, RigidbodyEx b, TSTWEOXDCJX c, [In] RigidbodyExData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x91FD690", Offset = "0x91FC290", VA = "0x1891FD690", Slot = "140")]
		protected virtual void AKJNSBOXUPT(TSTWEOXDCJX a, RigidbodyExData b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x91FEB50", Offset = "0x91FD750", VA = "0x1891FEB50", Slot = "141")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x91FDB50", Offset = "0x91FC750", VA = "0x1891FDB50", Slot = "94")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x92014D0", Offset = "0x92000D0", VA = "0x1892014D0", Slot = "95")]
		public void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x9201420", Offset = "0x9200020", VA = "0x189201420", Slot = "96")]
		public void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x9201400", Offset = "0x9200000", VA = "0x189201400", Slot = "97")]
		public void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x91FD2F0", Offset = "0x91FBEF0", VA = "0x1891FD2F0")]
		private void ACXFQBHLQGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x92021E0", Offset = "0x9200DE0", VA = "0x1892021E0")]
		private void TLZTRBLQPTW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x9202010", Offset = "0x9200C10", VA = "0x189202010")]
		private void SXXEBJPRQTP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x91FE7B0", Offset = "0x91FD3B0", VA = "0x1891FE7B0", Slot = "31")]
		public VJGXMHXJSVW DXJFPLEAZKP(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x9202070", Offset = "0x9200C70", VA = "0x189202070", Slot = "99")]
		public void SetParent(VJGXMHXJSVW value, bool isPhysicallyDetachedOnly = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x92004B0", Offset = "0x91FF0B0", VA = "0x1892004B0", Slot = "100")]
		public void JQQCWDTLCGQ(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x91FF650", Offset = "0x91FE250", VA = "0x1891FF650", Slot = "101")]
		public void HDICOFCDPFR(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x9202790", Offset = "0x9201390", VA = "0x189202790", Slot = "102")]
		public Vector3 VQPXVYQXVPQ(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x9201200", Offset = "0x91FFE00", VA = "0x189201200", Slot = "103")]
		public Vector3 OBIKNQBTVGI(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x9200900", Offset = "0x91FF500", VA = "0x189200900", Slot = "104")]
		public void LOZVTLBSINH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x9202650", Offset = "0x9201250", VA = "0x189202650", Slot = "105")]
		public void VCIEMHFRWIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x91FF3A0", Offset = "0x91FDFA0", VA = "0x1891FF3A0", Slot = "106")]
		public void GOWZTISMJAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x9200E10", Offset = "0x91FFA10", VA = "0x189200E10", Slot = "107")]
		public void MVLLGENAJVD(Vector3 a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x9202530", Offset = "0x9201130", VA = "0x189202530", Slot = "108")]
		public void UGJGWNFEIZC(Vector3 a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x9203610", Offset = "0x9202210", VA = "0x189203610", Slot = "109")]
		public void YQCNNLQWZZX(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x9203280", Offset = "0x9201E80", VA = "0x189203280", Slot = "110")]
		public void XZCQWDAJRMZ(RbexImpulseType a, Vector3 b, float c, float d = 8f, float e = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x91FD9F0", Offset = "0x91FC5F0", VA = "0x1891FD9F0", Slot = "111")]
		public void AVBJEINMKLS(RbexRotationType a, Vector3 b, float c = 1f / 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x91FD5E0", Offset = "0x91FC1E0", VA = "0x1891FD5E0", Slot = "112")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void AIRJEKIEAGD(RbexRotationType a, Vector3 b, float c = 7f, float d = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x9200090", Offset = "0x91FEC90", VA = "0x189200090", Slot = "113")]
		public Vector3 JDJWJKZVBVY(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x91FDF70", Offset = "0x91FCB70", VA = "0x1891FDF70", Slot = "114")]
		public Vector3 CENKGVHQSQC(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x92011B0", Offset = "0x91FFDB0", VA = "0x1892011B0", Slot = "115")]
		public void NUKAKVWGFEZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x91FD980", Offset = "0x91FC580", VA = "0x1891FD980", Slot = "116")]
		public void ASHNAVSNVKB(VJGXMHXJSVW a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x91FDAF0", Offset = "0x91FC6F0", VA = "0x1891FDAF0", Slot = "117")]
		public void AXGILGEDDDQ(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x9203890", Offset = "0x9202490", VA = "0x189203890", Slot = "64")]
		public void ZZYAMYUXSHE((Quaternion rot, Vector3 moments) tensor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x9200CC0", Offset = "0x91FF8C0", VA = "0x189200CC0", Slot = "118")]
		public void MDOQQSXKYZQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x9203230", Offset = "0x9201E30", VA = "0x189203230", Slot = "119")]
		public void XYIVNWBQGIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x91FE570", Offset = "0x91FD170", VA = "0x1891FE570", Slot = "120")]
		public void DSLRGUOMRLS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x9201100", Offset = "0x91FFD00", VA = "0x189201100", Slot = "121")]
		public bool NPBKCYDOQZW()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x92020E0", Offset = "0x9200CE0", VA = "0x1892020E0", Slot = "98")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x9202E00", Offset = "0x9201A00", VA = "0x189202E00", Slot = "122")]
		public void WFOAUJEMXEU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x9200F60", Offset = "0x91FFB60", VA = "0x189200F60", Slot = "123")]
		public void NCQFELJJLAF(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x91FF780", Offset = "0x91FE380", VA = "0x1891FF780", Slot = "124")]
		public void HFCDRWPUKAW(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x9201DD0", Offset = "0x92009D0", VA = "0x189201DD0", Slot = "125")]
		public void SCXMWOMWVKM(object a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x91FF450", Offset = "0x91FE050", VA = "0x1891FF450", Slot = "126")]
		public void HBXRQTSFUAM(Vector3 a, Quaternion b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x91FF9B0", Offset = "0x91FE5B0", VA = "0x1891FF9B0", Slot = "127")]
		public void HTFOSQEAXIQ(Vector3 a, Quaternion b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x91FFCC0", Offset = "0x91FE8C0", VA = "0x1891FFCC0", Slot = "128")]
		public bool IJHOSSEIIFN(float a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x91FED00", Offset = "0x91FD900", VA = "0x1891FED00", Slot = "129")]
		public void EJINPVQTTLS(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x9202420", Offset = "0x9201020", VA = "0x189202420", Slot = "130")]
		public void UAPTZHFXJCN(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x91FF3F0", Offset = "0x91FDFF0", VA = "0x1891FF3F0", Slot = "131")]
		public void GVJLHNNWPXQ(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x9200190", Offset = "0x91FED90", VA = "0x189200190", Slot = "132")]
		public void JDTCQTQFCWN(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x9201560", Offset = "0x9200160", VA = "0x189201560", Slot = "133")]
		public void PIGDUUEVXWX(Vector3 a, ForceMode b = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x9203500", Offset = "0x9202100", VA = "0x189203500", Slot = "134")]
		public void YLVMDYXFEPP(Vector3 a, Vector3 b, ForceMode c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x91FE3D0", Offset = "0x91FCFD0", VA = "0x1891FE3D0", Slot = "135")]
		public void DGARRKSINKK(Vector3 a, ForceMode b = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x9203070", Offset = "0x9201C70", VA = "0x189203070", Slot = "136")]
		public void WPCRJOORFOK(Vector3 a, ForceMode b = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x9201E40", Offset = "0x9200A40", VA = "0x189201E40", Slot = "137")]
		public bool SEBZRIFIIOL(Vector3 a, [Out] RaycastHit b, float c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x9201480", Offset = "0x9200080", VA = "0x189201480", Slot = "138")]
		public void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x92023E0", Offset = "0x9200FE0", VA = "0x1892023E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x91FFF50", Offset = "0x91FEB50", VA = "0x1891FFF50")]
		private void IURGJHEKZEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x92002D0", Offset = "0x91FEED0", VA = "0x1892002D0")]
		private void JODLTXPHREP(VJGXMHXJSVW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x9200950", Offset = "0x91FF550", VA = "0x189200950")]
		private void LQNTMZENRXS(VJGXMHXJSVW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x9202480", Offset = "0x9201080", VA = "0x189202480")]
		private void UBDLSVZWJGT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x9200B30", Offset = "0x91FF730", VA = "0x189200B30")]
		private void LWLNEHYOKMW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x91FDDC0", Offset = "0x91FC9C0", VA = "0x1891FDDC0")]
		private void BXGWSZWJJQQ(VJGXMHXJSVW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x9202E70", Offset = "0x9201A70", VA = "0x189202E70")]
		private void WJPAHEJZQKP(VJGXMHXJSVW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x91FDCF0", Offset = "0x91FC8F0", VA = "0x1891FDCF0")]
		private void BOICBJAOMOT(VJGXMHXJSVW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x9200620", Offset = "0x91FF220", VA = "0x189200620")]
		private void KNIQHZWWLKS(SDMULJARPSS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x92029B0", Offset = "0x92015B0", VA = "0x1892029B0", Slot = "143")]
		protected virtual void WFJQTJAISZJ(SDMULJARPSS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x91FE830", Offset = "0x91FD430", VA = "0x1891FE830")]
		protected void DXQYXZEMBKT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x9201A20", Offset = "0x9200620", VA = "0x189201A20")]
		protected void RXVRTBSXGVF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x91FF130", Offset = "0x91FDD30", VA = "0x1891FF130")]
		private void FYDVZRWJXAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x91FE210", Offset = "0x91FCE10", VA = "0x1891FE210")]
		private void CVFPNWRYAYW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	internal static class ARNFOKVHDIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x91F5AD0", Offset = "0x91F46D0", VA = "0x1891F5AD0")]
		public static VJGXMHXJSVW PGXKSUXUMVQ(this VJGXMHXJSVW a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x91F5A30", Offset = "0x91F4630", VA = "0x1891F5A30")]
		public static bool JIVTSCDXMCF(this VJGXMHXJSVW a, VJGXMHXJSVW b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x91F5B90", Offset = "0x91F4790", VA = "0x1891F5B90")]
		public static bool WUMSRNTPVET(this VJGXMHXJSVW a, VJGXMHXJSVW b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x91F59E0", Offset = "0x91F45E0", VA = "0x1891F59E0")]
		public static SDMULJARPSS DXKEMICZDNN(this VJGXMHXJSVW a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x91F5960", Offset = "0x91F4560", VA = "0x1891F5960")]
		public static PHMUBKXKDQD Base(this VJGXMHXJSVW impl)
		{
			return null;
		}
	}
}
namespace RecRoom.Rbex.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class EWDRWOFCECC : JJTGIRIQDEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x91F6250", Offset = "0x91F4E50", VA = "0x1891F6250", Slot = "19")]
		public VJGXMHXJSVW EGDZFVLJDUD(RigidbodyEx a, RigidbodyExData b, TSTWEOXDCJX c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0xB16800", Offset = "0xB15400", VA = "0x180B16800", Slot = "4")]
		public PUDSYZOXUZG FULSPTHCCII(VJGXMHXJSVW a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0xB16800", Offset = "0xB15400", VA = "0x180B16800", Slot = "5")]
		public MAHUHELQKQK TNENJGGHTZM(VJGXMHXJSVW a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0xB16800", Offset = "0xB15400", VA = "0x180B16800", Slot = "6")]
		public QVDLSNHORQH PVBBBQYYDDZ(VJGXMHXJSVW a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0xB16800", Offset = "0xB15400", VA = "0x180B16800", Slot = "7")]
		public KTAMILONBGI PURGHLETYPK(VJGXMHXJSVW a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0xB16800", Offset = "0xB15400", VA = "0x180B16800", Slot = "8")]
		public LXFLPVDYESE VHAHHZWZZLG(VJGXMHXJSVW a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0xB16800", Offset = "0xB15400", VA = "0x180B16800", Slot = "9")]
		public LOLOWUHIZQX QBUPVROSAGH(VJGXMHXJSVW a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0xB16800", Offset = "0xB15400", VA = "0x180B16800", Slot = "10")]
		public SASXJXQWDYK DIBJSVGNKXI(VJGXMHXJSVW a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0xB16800", Offset = "0xB15400", VA = "0x180B16800", Slot = "11")]
		public ZKVKFDITUUE VJZLGTFYFYY(VJGXMHXJSVW a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0xB16800", Offset = "0xB15400", VA = "0x180B16800", Slot = "12")]
		public CBZLBVRACQG YVWAVPQUSOC(VJGXMHXJSVW a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0xB16800", Offset = "0xB15400", VA = "0x180B16800", Slot = "13")]
		public JOHMEWMMAUN KFQJXPYOOLX(VJGXMHXJSVW a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0xB16800", Offset = "0xB15400", VA = "0x180B16800")]
		public UHBYESJLXPX ORNCIVGSJND(VJGXMHXJSVW a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0xB16800", Offset = "0xB15400", VA = "0x180B16800")]
		public UYBNHAMFGSL BBKMVTFFKDZ(VJGXMHXJSVW a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0xB16800", Offset = "0xB15400", VA = "0x180B16800")]
		public NETYWGKBFDD ELSRPDDPSAV(VJGXMHXJSVW a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0xB16800", Offset = "0xB15400", VA = "0x180B16800")]
		public NUOZBEKXOFF WRVWQNZJNGH(VJGXMHXJSVW a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0xB16800", Offset = "0xB15400", VA = "0x180B16800")]
		public IEAKDRPWBED WAUPXAIFEEH(VJGXMHXJSVW a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public EWDRWOFCECC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0xB16800", Offset = "0xB15400", VA = "0x180B16800", Slot = "14")]
		private UHBYESJLXPX ENXARHOCLUR(VJGXMHXJSVW a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0xB16800", Offset = "0xB15400", VA = "0x180B16800", Slot = "15")]
		private UYBNHAMFGSL LQZCWFKWMWP(VJGXMHXJSVW a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0xB16800", Offset = "0xB15400", VA = "0x180B16800", Slot = "16")]
		private NETYWGKBFDD KYJOJXLEBGR(VJGXMHXJSVW a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0xB16800", Offset = "0xB15400", VA = "0x180B16800", Slot = "17")]
		private NUOZBEKXOFF UHHNCJXFPEH(VJGXMHXJSVW a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0xB16800", Offset = "0xB15400", VA = "0x180B16800", Slot = "18")]
		private IEAKDRPWBED JBMFKDPZWQL(VJGXMHXJSVW a, [In] RigidbodyExData data)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[RegisterService(typeof(JJTGIRIQDEJ), new string[] { })]
	public class PADVLJTVWWX : JJTGIRIQDEJ, PEEXKGKATXF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private readonly JJTGIRIQDEJ NSKMMBUTGCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private readonly JJTGIRIQDEJ DDWVGWMZEFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private AVQNPROTHWR RILKSEVEHDC;

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		private JJTGIRIQDEJ ZOUMXACDANT
		{
			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0x91FCF10", Offset = "0x91FBB10", VA = "0x1891FCF10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x91FC900", Offset = "0x91FB500", VA = "0x1891FC900", Slot = "20")]
		public void InitReferences(BVNDYEZSFBO services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x91FC860", Offset = "0x91FB460", VA = "0x1891FC860", Slot = "4")]
		public PUDSYZOXUZG FULSPTHCCII(VJGXMHXJSVW a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x91FCC80", Offset = "0x91FB880", VA = "0x1891FCC80", Slot = "5")]
		public MAHUHELQKQK TNENJGGHTZM(VJGXMHXJSVW a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x91FCB40", Offset = "0x91FB740", VA = "0x1891FCB40", Slot = "6")]
		public QVDLSNHORQH PVBBBQYYDDZ(VJGXMHXJSVW a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x91FCAA0", Offset = "0x91FB6A0", VA = "0x1891FCAA0", Slot = "7")]
		public KTAMILONBGI PURGHLETYPK(VJGXMHXJSVW a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x91FCDD0", Offset = "0x91FB9D0", VA = "0x1891FCDD0", Slot = "8")]
		public LXFLPVDYESE VHAHHZWZZLG(VJGXMHXJSVW a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x91FCBE0", Offset = "0x91FB7E0", VA = "0x1891FCBE0", Slot = "9")]
		public LOLOWUHIZQX QBUPVROSAGH(VJGXMHXJSVW a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x91FC580", Offset = "0x91FB180", VA = "0x1891FC580", Slot = "10")]
		public SASXJXQWDYK DIBJSVGNKXI(VJGXMHXJSVW a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x91FCE70", Offset = "0x91FBA70", VA = "0x1891FCE70", Slot = "11")]
		public ZKVKFDITUUE VJZLGTFYFYY(VJGXMHXJSVW a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x91FCF70", Offset = "0x91FBB70", VA = "0x1891FCF70", Slot = "12")]
		public CBZLBVRACQG YVWAVPQUSOC(VJGXMHXJSVW a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x91FCA00", Offset = "0x91FB600", VA = "0x1891FCA00", Slot = "13")]
		public JOHMEWMMAUN KFQJXPYOOLX(VJGXMHXJSVW a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x91FC7B0", Offset = "0x91FB3B0", VA = "0x1891FC7B0")]
		public UHBYESJLXPX ORNCIVGSJND(VJGXMHXJSVW a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x91FC4D0", Offset = "0x91FB0D0", VA = "0x1891FC4D0")]
		public UYBNHAMFGSL BBKMVTFFKDZ(VJGXMHXJSVW a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x91FC700", Offset = "0x91FB300", VA = "0x1891FC700")]
		public NETYWGKBFDD ELSRPDDPSAV(VJGXMHXJSVW a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x91FCD20", Offset = "0x91FB920", VA = "0x1891FCD20")]
		public NUOZBEKXOFF WRVWQNZJNGH(VJGXMHXJSVW a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x91FC950", Offset = "0x91FB550", VA = "0x1891FC950")]
		public IEAKDRPWBED WAUPXAIFEEH(VJGXMHXJSVW a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x91FC620", Offset = "0x91FB220", VA = "0x1891FC620", Slot = "19")]
		public VJGXMHXJSVW EGDZFVLJDUD(RigidbodyEx a, RigidbodyExData b, TSTWEOXDCJX c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x91FD010", Offset = "0x91FBC10", VA = "0x1891FD010")]
		public PADVLJTVWWX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x91FC7B0", Offset = "0x91FB3B0", VA = "0x1891FC7B0", Slot = "14")]
		private UHBYESJLXPX ENXARHOCLUR(VJGXMHXJSVW a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x91FC4D0", Offset = "0x91FB0D0", VA = "0x1891FC4D0", Slot = "15")]
		private UYBNHAMFGSL LQZCWFKWMWP(VJGXMHXJSVW a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x91FC700", Offset = "0x91FB300", VA = "0x1891FC700", Slot = "16")]
		private NETYWGKBFDD KYJOJXLEBGR(VJGXMHXJSVW a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x91FCD20", Offset = "0x91FB920", VA = "0x1891FCD20", Slot = "17")]
		private NUOZBEKXOFF UHHNCJXFPEH(VJGXMHXJSVW a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x91FC950", Offset = "0x91FB550", VA = "0x1891FC950", Slot = "18")]
		private IEAKDRPWBED JBMFKDPZWQL(VJGXMHXJSVW a, [In] RigidbodyExData data)
		{
			return null;
		}
	}
}
namespace RecRoom.Rbex.Legacy
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public interface OCKAWYCUQPT : PUDSYZOXUZG, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void DOINHEJLOPM(VJGXMHXJSVW a);

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void DVRNWIKJOKB(VJGXMHXJSVW a);

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void ZSCXBETFMWM(VJGXMHXJSVW a);

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void VMLBMRJXYKB(VJGXMHXJSVW a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public interface CAUKGKETUHQ : QVDLSNHORQH
	{
		[Cpp2IlInjected.Token(Token = "0x17000090")]
		UINTHXZVVDQ<VJGXMHXJSVW> IJRDXHEZISV
		{
			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		VJGXMHXJSVW EYXLIJWOIZH
		{
			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public interface ZCEAOSYOLBO : NUOZBEKXOFF
	{
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		(float, Vector3) LAQZOUEDCMN(Rigidbody a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public interface CNYDDSTVESO : UYBNHAMFGSL, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000092")]
		RRNetworkView WCHMNYLTLHY
		{
			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	internal sealed class GCSKQOSSUWP : CBZLBVRACQG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private readonly PHMUBKXKDQD MYJGWBTYYFW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private CollisionDetectionMode KZYOOSKFSAF;

		[Cpp2IlInjected.Token(Token = "0x17000093")]
		private Rigidbody UYFXLBSICUR
		{
			[Cpp2IlInjected.Token(Token = "0x600024E")]
			[Cpp2IlInjected.Address(RVA = "0x91F72D0", Offset = "0x91F5ED0", VA = "0x1891F72D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000094")]
		public CollisionDetectionMode KGYBFHKMZUZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0x91F7500", Offset = "0x91F6100", VA = "0x1891F7500", Slot = "4")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x91F7130", Offset = "0x91F5D30", VA = "0x1891F7130", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x91F7610", Offset = "0x91F6210", VA = "0x1891F7610")]
		public GCSKQOSSUWP(VJGXMHXJSVW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x91F7020", Offset = "0x91F5C20", VA = "0x1891F7020", Slot = "6")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x91F7480", Offset = "0x91F6080", VA = "0x1891F7480", Slot = "9")]
		public void SLYFAQEHFXK(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x91F71A0", Offset = "0x91F5DA0", VA = "0x1891F71A0", Slot = "7")]
		public void IAXNIZSJDKP(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x91F7010", Offset = "0x91F5C10", VA = "0x1891F7010", Slot = "8")]
		public void AQMXNDQIHBQ(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x91F7320", Offset = "0x91F5F20", VA = "0x1891F7320", Slot = "10")]
		public bool SEBZRIFIIOL(Vector3 a, [Out] RaycastHit b, float c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x91F71B0", Offset = "0x91F5DB0", VA = "0x1891F71B0")]
		private void PXTBJGMGQRT(bool a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public sealed class PPPXMPNBKDG : LOLOWUHIZQX, IDisposable, TSDOMBQKPJV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly PHMUBKXKDQD MYJGWBTYYFW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TransformTrackRate LQYVUJXJZXY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private BRLFXVSOLAS MKIMLIRYKHU;

		[Cpp2IlInjected.Token(Token = "0x17000095")]
		public TransformTrackRate CBNLXLSYODE
		{
			[Cpp2IlInjected.Token(Token = "0x600025A")]
			[Cpp2IlInjected.Address(RVA = "0x9204C30", Offset = "0x9203830", VA = "0x189204C30", Slot = "6")]
			get
			{
				return default(TransformTrackRate);
			}
			[Cpp2IlInjected.Token(Token = "0x600025B")]
			[Cpp2IlInjected.Address(RVA = "0x9204B60", Offset = "0x9203760", VA = "0x189204B60", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000096")]
		private Transform OMTHFUVPKPD
		{
			[Cpp2IlInjected.Token(Token = "0x600025C")]
			[Cpp2IlInjected.Address(RVA = "0x9204D80", Offset = "0x9203980", VA = "0x189204D80", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000020")]
		public event Action<UpdateLOD, UpdateLOD> EWXILSTNKDJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000258")]
			[Cpp2IlInjected.Address(RVA = "0x9204AB0", Offset = "0x92036B0", VA = "0x189204AB0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000259")]
			[Cpp2IlInjected.Address(RVA = "0x9204A00", Offset = "0x9203600", VA = "0x189204A00", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x9204DA0", Offset = "0x92039A0", VA = "0x189204DA0")]
		public PPPXMPNBKDG(VJGXMHXJSVW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x9204740", Offset = "0x9203340", VA = "0x189204740", Slot = "8")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x92049B0", Offset = "0x92035B0", VA = "0x1892049B0", Slot = "9")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x1466910", Offset = "0x1465510", VA = "0x181466910", Slot = "11")]
		private void YLGKCXCJSFM(UpdateLOD a, UpdateLOD b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "12")]
		private void ECOFUVGNEDQ(bool a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class EWDRWOFCECC : JJTGIRIQDEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x91F6670", Offset = "0x91F5270", VA = "0x1891F6670", Slot = "4")]
		public PUDSYZOXUZG FULSPTHCCII(VJGXMHXJSVW a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x91F6B30", Offset = "0x91F5730", VA = "0x1891F6B30", Slot = "5")]
		public MAHUHELQKQK TNENJGGHTZM(VJGXMHXJSVW a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x91F6950", Offset = "0x91F5550", VA = "0x1891F6950", Slot = "6")]
		public QVDLSNHORQH PVBBBQYYDDZ(VJGXMHXJSVW a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x91F68E0", Offset = "0x91F54E0", VA = "0x1891F68E0", Slot = "7")]
		public KTAMILONBGI PURGHLETYPK(VJGXMHXJSVW a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x91F6DD0", Offset = "0x91F59D0", VA = "0x1891F6DD0", Slot = "8")]
		public LXFLPVDYESE VHAHHZWZZLG(VJGXMHXJSVW a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x91F6A70", Offset = "0x91F5670", VA = "0x1891F6A70", Slot = "9")]
		public LOLOWUHIZQX QBUPVROSAGH(VJGXMHXJSVW a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x91F6140", Offset = "0x91F4D40", VA = "0x1891F6140", Slot = "10")]
		public SASXJXQWDYK DIBJSVGNKXI(VJGXMHXJSVW a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x91F6E90", Offset = "0x91F5A90", VA = "0x1891F6E90", Slot = "11")]
		public ZKVKFDITUUE VJZLGTFYFYY(VJGXMHXJSVW a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x91F6F50", Offset = "0x91F5B50", VA = "0x1891F6F50", Slot = "12")]
		public CBZLBVRACQG YVWAVPQUSOC(VJGXMHXJSVW a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x91F6820", Offset = "0x91F5420", VA = "0x1891F6820", Slot = "13")]
		public JOHMEWMMAUN KFQJXPYOOLX(VJGXMHXJSVW a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x91F6540", Offset = "0x91F5140", VA = "0x1891F6540")]
		public UHBYESJLXPX ORNCIVGSJND(VJGXMHXJSVW a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x91F5FC0", Offset = "0x91F4BC0", VA = "0x1891F5FC0")]
		public UYBNHAMFGSL BBKMVTFFKDZ(VJGXMHXJSVW a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x91F6420", Offset = "0x91F5020", VA = "0x1891F6420")]
		public NETYWGKBFDD ELSRPDDPSAV(VJGXMHXJSVW a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x91F6C40", Offset = "0x91F5840", VA = "0x1891F6C40")]
		public NUOZBEKXOFF WRVWQNZJNGH(VJGXMHXJSVW a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x91F6750", Offset = "0x91F5350", VA = "0x1891F6750")]
		public IEAKDRPWBED WAUPXAIFEEH(VJGXMHXJSVW a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x91F62E0", Offset = "0x91F4EE0", VA = "0x1891F62E0", Slot = "19")]
		public VJGXMHXJSVW EGDZFVLJDUD(RigidbodyEx a, RigidbodyExData b, TSTWEOXDCJX c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public EWDRWOFCECC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x91F6540", Offset = "0x91F5140", VA = "0x1891F6540", Slot = "14")]
		private UHBYESJLXPX ENXARHOCLUR(VJGXMHXJSVW a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x91F5FC0", Offset = "0x91F4BC0", VA = "0x1891F5FC0", Slot = "15")]
		private UYBNHAMFGSL LQZCWFKWMWP(VJGXMHXJSVW a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x91F6420", Offset = "0x91F5020", VA = "0x1891F6420", Slot = "16")]
		private NETYWGKBFDD KYJOJXLEBGR(VJGXMHXJSVW a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x91F6C40", Offset = "0x91F5840", VA = "0x1891F6C40", Slot = "17")]
		private NUOZBEKXOFF UHHNCJXFPEH(VJGXMHXJSVW a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x91F6750", Offset = "0x91F5350", VA = "0x1891F6750", Slot = "18")]
		private IEAKDRPWBED JBMFKDPZWQL(VJGXMHXJSVW a, [In] RigidbodyExData data)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	internal sealed class RLNNWIEVJDB : ZKVKFDITUUE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private readonly PHMUBKXKDQD MYJGWBTYYFW;

		[Cpp2IlInjected.Token(Token = "0x17000097")]
		private Rigidbody UYFXLBSICUR
		{
			[Cpp2IlInjected.Token(Token = "0x6000278")]
			[Cpp2IlInjected.Address(RVA = "0x91F72D0", Offset = "0x91F5ED0", VA = "0x1891F72D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000098")]
		private bool FJXVDNPRGNE
		{
			[Cpp2IlInjected.Token(Token = "0x6000279")]
			[Cpp2IlInjected.Address(RVA = "0x92053E0", Offset = "0x9203FE0", VA = "0x1892053E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000099")]
		private bool VDPFUYLNWQL
		{
			[Cpp2IlInjected.Token(Token = "0x600027A")]
			[Cpp2IlInjected.Address(RVA = "0x91FB660", Offset = "0x91FA260", VA = "0x1891FB660")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009A")]
		private VJGXMHXJSVW MJTMBSVCHQR
		{
			[Cpp2IlInjected.Token(Token = "0x600027B")]
			[Cpp2IlInjected.Address(RVA = "0x9205A50", Offset = "0x9204650", VA = "0x189205A50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x91F7610", Offset = "0x91F6210", VA = "0x1891F7610")]
		public RLNNWIEVJDB(VJGXMHXJSVW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x9205690", Offset = "0x9204290", VA = "0x189205690", Slot = "4")]
		public void PIGDUUEVXWX(Vector3 a, ForceMode b = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x9205430", Offset = "0x9204030", VA = "0x189205430")]
		private void JHXYMWPTMWC(Vector3 a, ForceMode b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x9205D10", Offset = "0x9204910", VA = "0x189205D10", Slot = "5")]
		public void YLVMDYXFEPP(Vector3 a, Vector3 b, ForceMode c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x9205280", Offset = "0x9203E80", VA = "0x189205280", Slot = "6")]
		public void DGARRKSINKK(Vector3 a, ForceMode b = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x92057F0", Offset = "0x92043F0", VA = "0x1892057F0")]
		private void PRKXNERAISV(Vector3 a, ForceMode b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x9205AB0", Offset = "0x92046B0", VA = "0x189205AB0", Slot = "7")]
		public void WPCRJOORFOK(Vector3 a, ForceMode b = ForceMode.Force)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	internal sealed class QFTBYJOZDSO : JOHMEWMMAUN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private readonly PHMUBKXKDQD MYJGWBTYYFW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private bool VNAKAMMQRGC;

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		public bool RKTDPEGGFIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000284")]
			[Cpp2IlInjected.Address(RVA = "0xB69420", Offset = "0xB68020", VA = "0x180B69420", Slot = "4")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000285")]
			[Cpp2IlInjected.Address(RVA = "0x9205070", Offset = "0x9203C70", VA = "0x189205070", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x91F7610", Offset = "0x91F6210", VA = "0x1891F7610")]
		public QFTBYJOZDSO(VJGXMHXJSVW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x9205180", Offset = "0x9203D80", VA = "0x189205180", Slot = "6")]
		public void SLYFAQEHFXK(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x9205000", Offset = "0x9203C00", VA = "0x189205000", Slot = "7")]
		public void GTUVJRMXRUB(Rigidbody a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	internal sealed class RbexHierarchy : OCKAWYCUQPT, PUDSYZOXUZG, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private readonly VJGXMHXJSVW MYJGWBTYYFW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private readonly List<VJGXMHXJSVW> CFHJBPKTKGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private VJGXMHXJSVW PPGZRRIGXVH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private VJGXMHXJSVW GUMKFVWGXHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private Transform IVOYGNDLKAU;

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		private Transform GZVGTXLLTNF
		{
			[Cpp2IlInjected.Token(Token = "0x600029A")]
			[Cpp2IlInjected.Address(RVA = "0x9206520", Offset = "0x9205120", VA = "0x189206520")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		public VJGXMHXJSVW MJTMBSVCHQR
		{
			[Cpp2IlInjected.Token(Token = "0x600029D")]
			[Cpp2IlInjected.Address(RVA = "0xB131F0", Offset = "0xB11DF0", VA = "0x180B131F0", Slot = "28")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600029E")]
			[Cpp2IlInjected.Address(RVA = "0x9206280", Offset = "0x9204E80", VA = "0x189206280", Slot = "29")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		public VJGXMHXJSVW DXAPXCCARDD
		{
			[Cpp2IlInjected.Token(Token = "0x600029F")]
			[Cpp2IlInjected.Address(RVA = "0xB13280", Offset = "0xB11E80", VA = "0x180B13280", Slot = "27")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		public IReadOnlyList<VJGXMHXJSVW> RCSNJKPBFUZ
		{
			[Cpp2IlInjected.Token(Token = "0x60002A0")]
			[Cpp2IlInjected.Address(RVA = "0xB14930", Offset = "0xB13530", VA = "0x180B14930", Slot = "26")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000021")]
		public event RbexAction XMVXHFGJDPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000288")]
			[Cpp2IlInjected.Address(RVA = "0x9205F90", Offset = "0x9204B90", VA = "0x189205F90", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000289")]
			[Cpp2IlInjected.Address(RVA = "0x9206580", Offset = "0x9205180", VA = "0x189206580", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000022")]
		public event RbexAction LZMSQWWVAMT
		{
			[Cpp2IlInjected.Token(Token = "0x600028A")]
			[Cpp2IlInjected.Address(RVA = "0x9206E80", Offset = "0x9205A80", VA = "0x189206E80", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600028B")]
			[Cpp2IlInjected.Address(RVA = "0x92069D0", Offset = "0x92055D0", VA = "0x1892069D0", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000023")]
		public event RbexParentChangeAction BGUVDEHFKYD
		{
			[Cpp2IlInjected.Token(Token = "0x600028C")]
			[Cpp2IlInjected.Address(RVA = "0x9206810", Offset = "0x9205410", VA = "0x189206810", Slot = "12")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600028D")]
			[Cpp2IlInjected.Address(RVA = "0x9206B10", Offset = "0x9205710", VA = "0x189206B10", Slot = "13")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000024")]
		public event Action LTVNXILVXQO
		{
			[Cpp2IlInjected.Token(Token = "0x600028E")]
			[Cpp2IlInjected.Address(RVA = "0x9206DE0", Offset = "0x92059E0", VA = "0x189206DE0", Slot = "14")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600028F")]
			[Cpp2IlInjected.Address(RVA = "0x9206620", Offset = "0x9205220", VA = "0x189206620", Slot = "15")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000025")]
		public event Action CWIKBFCOLAX
		{
			[Cpp2IlInjected.Token(Token = "0x6000290")]
			[Cpp2IlInjected.Address(RVA = "0x9206480", Offset = "0x9205080", VA = "0x189206480", Slot = "16")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000291")]
			[Cpp2IlInjected.Address(RVA = "0x9206A70", Offset = "0x9205670", VA = "0x189206A70", Slot = "17")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000026")]
		public event Action<VJGXMHXJSVW> IQJZYSTXAUC
		{
			[Cpp2IlInjected.Token(Token = "0x6000292")]
			[Cpp2IlInjected.Address(RVA = "0x92060E0", Offset = "0x9204CE0", VA = "0x1892060E0", Slot = "18")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000293")]
			[Cpp2IlInjected.Address(RVA = "0x92066C0", Offset = "0x92052C0", VA = "0x1892066C0", Slot = "19")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000027")]
		public event Action<VJGXMHXJSVW> YAABKGTYBBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000294")]
			[Cpp2IlInjected.Address(RVA = "0x9206BF0", Offset = "0x92057F0", VA = "0x189206BF0", Slot = "20")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000295")]
			[Cpp2IlInjected.Address(RVA = "0x9206030", Offset = "0x9204C30", VA = "0x189206030", Slot = "21")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000028")]
		public event Action DQELHWGEGLU
		{
			[Cpp2IlInjected.Token(Token = "0x6000296")]
			[Cpp2IlInjected.Address(RVA = "0x9207490", Offset = "0x9206090", VA = "0x189207490", Slot = "22")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000297")]
			[Cpp2IlInjected.Address(RVA = "0x9207A50", Offset = "0x9206650", VA = "0x189207A50", Slot = "23")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000029")]
		public event Action<VJGXMHXJSVW> QKYRIBYMFQX
		{
			[Cpp2IlInjected.Token(Token = "0x6000298")]
			[Cpp2IlInjected.Address(RVA = "0x9207720", Offset = "0x9206320", VA = "0x189207720", Slot = "24")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000299")]
			[Cpp2IlInjected.Address(RVA = "0x92063D0", Offset = "0x9204FD0", VA = "0x1892063D0", Slot = "25")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x9207D60", Offset = "0x9206960", VA = "0x189207D60")]
		public RbexHierarchy(VJGXMHXJSVW rbex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x9206330", Offset = "0x9204F30", VA = "0x189206330", Slot = "31")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x9206F20", Offset = "0x9205B20", VA = "0x189206F20", Slot = "30")]
		public void SetParent(VJGXMHXJSVW newParent, bool isPhysicallyDetachedOnly = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x9207AF0", Offset = "0x92066F0", VA = "0x189207AF0", Slot = "6")]
		public void ZSCXBETFMWM(VJGXMHXJSVW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x92077D0", Offset = "0x92063D0", VA = "0x1892077D0", Slot = "7")]
		public void VMLBMRJXYKB(VJGXMHXJSVW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x9206190", Offset = "0x9204D90", VA = "0x189206190", Slot = "4")]
		public void DOINHEJLOPM(VJGXMHXJSVW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x9206290", Offset = "0x9204E90", VA = "0x189206290", Slot = "5")]
		public void DVRNWIKJOKB(VJGXMHXJSVW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x9206770", Offset = "0x9205370", VA = "0x189206770")]
		private void LRCTCZWGBOU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x9206BB0", Offset = "0x92057B0", VA = "0x189206BB0")]
		private void OJOEFEKICLJ(VJGXMHXJSVW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x9206CA0", Offset = "0x92058A0", VA = "0x189206CA0")]
		private void QRGZFMGZFIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x92075F0", Offset = "0x92061F0", VA = "0x1892075F0")]
		private void TTBTUQLPEBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x92068B0", Offset = "0x92054B0", VA = "0x1892068B0")]
		private void MFNNEOXHEEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x9207530", Offset = "0x9206130", VA = "0x189207530")]
		[CompilerGenerated]
		private object TEPFABFQUFT()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	internal static class TBOLBDAIEXX
	{
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x920EC00", Offset = "0x920D800", VA = "0x18920EC00")]
		public static OCKAWYCUQPT JKSJSTSUDBS(this VJGXMHXJSVW a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	internal sealed class GVUVBTGDNLC : CAUKGKETUHQ, QVDLSNHORQH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private readonly PHMUBKXKDQD MYJGWBTYYFW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private readonly UINTHXZVVDQ<VJGXMHXJSVW> NEGALYPLEHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private bool OEOWTFSBYFE;

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		public UINTHXZVVDQ<VJGXMHXJSVW> IJRDXHEZISV
		{
			[Cpp2IlInjected.Token(Token = "0x60002AD")]
			[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		public Vector3 ECGPBOHHWSW
		{
			[Cpp2IlInjected.Token(Token = "0x60002AE")]
			[Cpp2IlInjected.Address(RVA = "0x91F7C90", Offset = "0x91F6890", VA = "0x1891F7C90", Slot = "6")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		public Vector3 ORFUOSZNTTM
		{
			[Cpp2IlInjected.Token(Token = "0x60002AF")]
			[Cpp2IlInjected.Address(RVA = "0x91F80C0", Offset = "0x91F6CC0", VA = "0x1891F80C0", Slot = "7")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		private Vector3 ULFUNVSUSPG
		{
			[Cpp2IlInjected.Token(Token = "0x60002B3")]
			[Cpp2IlInjected.Address(RVA = "0x91F7BB0", Offset = "0x91F67B0", VA = "0x1891F7BB0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A4")]
		public VJGXMHXJSVW EYXLIJWOIZH
		{
			[Cpp2IlInjected.Token(Token = "0x60002B4")]
			[Cpp2IlInjected.Address(RVA = "0x91F7B00", Offset = "0x91F6700", VA = "0x1891F7B00", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x91F8430", Offset = "0x91F7030", VA = "0x1891F8430")]
		public GVUVBTGDNLC(VJGXMHXJSVW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x91F83C0", Offset = "0x91F6FC0", VA = "0x1891F83C0", Slot = "8")]
		public void VNERPVILVWM(VJGXMHXJSVW a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x91F8060", Offset = "0x91F6C60", VA = "0x1891F8060", Slot = "9")]
		public void MMWAPSHDDTL(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x91F7CC0", Offset = "0x91F68C0", VA = "0x1891F7CC0")]
		private Vector3 KHCINGGVFOY()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x91F7760", Offset = "0x91F6360", VA = "0x1891F7760")]
		private void ESPJLFIQBGB(VJGXMHXJSVW a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	internal static class GNZQULENGIW
	{
		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x91F76A0", Offset = "0x91F62A0", VA = "0x1891F76A0")]
		public static CAUKGKETUHQ FFFPGZNWLPZ(this VJGXMHXJSVW a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	internal sealed class HFQZJGVCKIG : ZCEAOSYOLBO, NUOZBEKXOFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private readonly PHMUBKXKDQD MYJGWBTYYFW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private readonly OverridableVector3 IXJLKWRXXHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private readonly OverridableVector3 BLYNJMODBYC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private float PNTOKCZTJNY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private float NSIPYYQXXCZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private Vector3 MEEIZATYUQM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private Vector3? SAKQUTVRLWQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private Quaternion? GOLXKPRDHBY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private bool XNTXFFBPFBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private bool LSFSIHFFWBU;

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		public Vector3 KIVIWAVSBHS
		{
			[Cpp2IlInjected.Token(Token = "0x60002BA")]
			[Cpp2IlInjected.Address(RVA = "0x226DD50", Offset = "0x226C950", VA = "0x18226DD50", Slot = "7")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60002BB")]
			[Cpp2IlInjected.Address(RVA = "0x91FA690", Offset = "0x91F9290", VA = "0x1891FA690", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A6")]
		public Vector3 AZSONQWKJCT
		{
			[Cpp2IlInjected.Token(Token = "0x60002BC")]
			[Cpp2IlInjected.Address(RVA = "0x91F8910", Offset = "0x91F7510", VA = "0x1891F8910", Slot = "9")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A7")]
		public float MVDYIULDOGF
		{
			[Cpp2IlInjected.Token(Token = "0x60002BD")]
			[Cpp2IlInjected.Address(RVA = "0xB64FF0", Offset = "0xB63BF0", VA = "0x180B64FF0", Slot = "10")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60002BE")]
			[Cpp2IlInjected.Address(RVA = "0x91FA450", Offset = "0x91F9050", VA = "0x1891FA450")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A8")]
		public float FACNVUVCSBU
		{
			[Cpp2IlInjected.Token(Token = "0x60002BF")]
			[Cpp2IlInjected.Address(RVA = "0xB65000", Offset = "0xB63C00", VA = "0x180B65000", Slot = "11")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60002C0")]
			[Cpp2IlInjected.Address(RVA = "0x91F86C0", Offset = "0x91F72C0", VA = "0x1891F86C0", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A9")]
		public Vector3 KKKOVTDHBTW
		{
			[Cpp2IlInjected.Token(Token = "0x60002C1")]
			[Cpp2IlInjected.Address(RVA = "0x91FA9A0", Offset = "0x91F95A0", VA = "0x1891FA9A0", Slot = "13")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AA")]
		public Quaternion JJSJCQZSRJI
		{
			[Cpp2IlInjected.Token(Token = "0x60002C2")]
			[Cpp2IlInjected.Address(RVA = "0x91F8C10", Offset = "0x91F7810", VA = "0x1891F8C10", Slot = "14")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AB")]
		private Rigidbody UYFXLBSICUR
		{
			[Cpp2IlInjected.Token(Token = "0x60002CA")]
			[Cpp2IlInjected.Address(RVA = "0x91FA560", Offset = "0x91F9160", VA = "0x1891FA560")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400002A")]
		public event RbexAction AOMIQOAMSHJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002B8")]
			[Cpp2IlInjected.Address(RVA = "0x91F9D30", Offset = "0x91F8930", VA = "0x1891F9D30", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60002B9")]
			[Cpp2IlInjected.Address(RVA = "0x91F9EF0", Offset = "0x91F8AF0", VA = "0x1891F9EF0", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x91FAD60", Offset = "0x91F9960", VA = "0x1891FAD60")]
		public HFQZJGVCKIG(VJGXMHXJSVW a, [In] RigidbodyExData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x91F9DD0", Offset = "0x91F89D0", VA = "0x1891F9DD0", Slot = "17")]
		public void MDOQQSXKYZQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x91FA8C0", Offset = "0x91F94C0", VA = "0x1891FA8C0", Slot = "16")]
		public void XYIVNWBQGIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x91FA5B0", Offset = "0x91F91B0", VA = "0x1891FA5B0", Slot = "19")]
		public void SLYFAQEHFXK(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x91F8A30", Offset = "0x91F7630", VA = "0x1891F8A30", Slot = "20")]
		public void GTUVJRMXRUB(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x91F8770", Offset = "0x91F7370", VA = "0x1891F8770", Slot = "18")]
		public void DSLRGUOMRLS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x91F9F90", Offset = "0x91F8B90", VA = "0x1891F9F90", Slot = "21")]
		public void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x91FA690", Offset = "0x91F9290", VA = "0x1891FA690")]
		private void SYOAJMJKVCC(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x91F9C10", Offset = "0x91F8810", VA = "0x1891F9C10")]
		[Obsolete("This method is dangerous - the unity rigidbody is updated in a deferred manner and this world position may be stale")]
		private Vector3 LLMTFYPFHBD()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x91FA450", Offset = "0x91F9050", VA = "0x1891FA450")]
		private void UOBXDXJZUCD(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x91F86C0", Offset = "0x91F72C0", VA = "0x1891F86C0")]
		private void UWDLCPLQXIY(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x91F8520", Offset = "0x91F7120", VA = "0x1891F8520")]
		private Vector3 AHSSHGXFRFQ()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x91FAB30", Offset = "0x91F9730", VA = "0x1891FAB30", Slot = "15")]
		public void ZZYAMYUXSHE((Quaternion rot, Vector3 moments) tensor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x91FA740", Offset = "0x91F9340", VA = "0x1891FA740")]
		private Quaternion WIMEDJERVNG()
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x91F9B40", Offset = "0x91F8740", VA = "0x1891F9B40")]
		public void LAQZOUEDCMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x91F8D90", Offset = "0x91F7990", VA = "0x1891F8D90", Slot = "4")]
		public (float, Vector3) LAQZOUEDCMN(Rigidbody a)
		{
			return default((float, Vector3));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	internal static class YNSBCBJNSTO
	{
		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x9212720", Offset = "0x9211320", VA = "0x189212720")]
		public static ZCEAOSYOLBO HMTSLOYQGNN(this VJGXMHXJSVW a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	internal sealed class ILLYJEZYGUO : NETYWGKBFDD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private readonly PHMUBKXKDQD MYJGWBTYYFW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private readonly SVJYJIPYDON ABWYCQVRJFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private readonly RbexInterpolationMode NIOPKAOCOFW;

		[Cpp2IlInjected.Token(Token = "0x170000AC")]
		public bool KRAGBZKTGJS
		{
			[Cpp2IlInjected.Token(Token = "0x60002D5")]
			[Cpp2IlInjected.Address(RVA = "0x1E11980", Offset = "0x1E10580", VA = "0x181E11980", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AD")]
		public RbexInterpolationMode ZPLJYBKEGKG
		{
			[Cpp2IlInjected.Token(Token = "0x60002D6")]
			[Cpp2IlInjected.Address(RVA = "0xB256B0", Offset = "0xB242B0", VA = "0x180B256B0", Slot = "11")]
			get
			{
				return default(RbexInterpolationMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x91FB4D0", Offset = "0x91FA0D0", VA = "0x1891FB4D0")]
		public ILLYJEZYGUO(VJGXMHXJSVW a, [In] RigidbodyExData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x91FAEC0", Offset = "0x91F9AC0", VA = "0x1891FAEC0", Slot = "4")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x91FB2F0", Offset = "0x91F9EF0", VA = "0x1891FB2F0")]
		private bool QQSSPWHEAQW()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x91FB0C0", Offset = "0x91F9CC0", VA = "0x1891FB0C0", Slot = "5")]
		public void DMOLPFSZBNE(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x91FB4A0", Offset = "0x91FA0A0", VA = "0x1891FB4A0", Slot = "6")]
		public void ZOHQGTTJKSR(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x91FAF90", Offset = "0x91F9B90", VA = "0x1891FAF90", Slot = "9")]
		public void BABSCZMVEMV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x91FB390", Offset = "0x91F9F90", VA = "0x1891FB390")]
		private void XLAKJNVDFIS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x91FB0F0", Offset = "0x91F9CF0", VA = "0x1891FB0F0")]
		private void MZCBKBOXDFU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x91FB2B0", Offset = "0x91F9EB0", VA = "0x1891FB2B0", Slot = "8")]
		public void PYMIADQNWWA(VJGXMHXJSVW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x91FB270", Offset = "0x91F9E70", VA = "0x1891FB270", Slot = "7")]
		public void OXRNBJPIJNP(VJGXMHXJSVW a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	internal sealed class IWKPVXBLVGN : SASXJXQWDYK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private readonly PHMUBKXKDQD MYJGWBTYYFW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private readonly SVJYJIPYDON PALRHQKVGIY;

		[Cpp2IlInjected.Token(Token = "0x170000AE")]
		public bool FJXVDNPRGNE
		{
			[Cpp2IlInjected.Token(Token = "0x60002E3")]
			[Cpp2IlInjected.Address(RVA = "0x91FBEC0", Offset = "0x91FAAC0", VA = "0x1891FBEC0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AF")]
		public IEnumerable<object> XGQPYPSYUDF
		{
			[Cpp2IlInjected.Token(Token = "0x60002E4")]
			[Cpp2IlInjected.Address(RVA = "0x91FC100", Offset = "0x91FAD00", VA = "0x1891FC100", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400002B")]
		public event RbexAction ISAOIEPOGAK
		{
			[Cpp2IlInjected.Token(Token = "0x60002E1")]
			[Cpp2IlInjected.Address(RVA = "0x91FBFB0", Offset = "0x91FABB0", VA = "0x1891FBFB0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60002E2")]
			[Cpp2IlInjected.Address(RVA = "0x91FC050", Offset = "0x91FAC50", VA = "0x1891FC050", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x91FC2F0", Offset = "0x91FAEF0", VA = "0x1891FC2F0")]
		public IWKPVXBLVGN(VJGXMHXJSVW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x91FC0F0", Offset = "0x91FACF0", VA = "0x1891FC0F0", Slot = "8")]
		public void NCQFELJJLAF(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x91FBFA0", Offset = "0x91FABA0", VA = "0x1891FBFA0", Slot = "9")]
		public void HFCDRWPUKAW(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x91FC160", Offset = "0x91FAD60", VA = "0x1891FC160", Slot = "10")]
		public void SCXMWOMWVKM(object a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x91FC120", Offset = "0x91FAD20", VA = "0x1891FC120", Slot = "13")]
		public void PUMZIYWIOAS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x91FC270", Offset = "0x91FAE70", VA = "0x1891FC270", Slot = "11")]
		public void SLYFAQEHFXK(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x91FBF70", Offset = "0x91FAB70", VA = "0x1891FBF70", Slot = "12")]
		public void GTUVJRMXRUB(Rigidbody a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	internal sealed class PIUSDQDAZIA : CNYDDSTVESO, UYBNHAMFGSL, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private readonly PHMUBKXKDQD MYJGWBTYYFW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private RRNetworkView UKHNPDUPPFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private bool NMRRDPFICJB;

		[Cpp2IlInjected.Token(Token = "0x170000B0")]
		public RRNetworkView WCHMNYLTLHY
		{
			[Cpp2IlInjected.Token(Token = "0x60002EE")]
			[Cpp2IlInjected.Address(RVA = "0xB18810", Offset = "0xB17410", VA = "0x180B18810", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B1")]
		public bool TTOOCIHUSTN
		{
			[Cpp2IlInjected.Token(Token = "0x60002EF")]
			[Cpp2IlInjected.Address(RVA = "0x9204150", Offset = "0x9202D50", VA = "0x189204150", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B2")]
		public bool BFDQKOWTRKD
		{
			[Cpp2IlInjected.Token(Token = "0x60002F0")]
			[Cpp2IlInjected.Address(RVA = "0xDD0FC0", Offset = "0xDCFBC0", VA = "0x180DD0FC0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400002C")]
		public event RbexAction GKOPYGNYTTS
		{
			[Cpp2IlInjected.Token(Token = "0x60002EC")]
			[Cpp2IlInjected.Address(RVA = "0x9203F60", Offset = "0x9202B60", VA = "0x189203F60", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60002ED")]
			[Cpp2IlInjected.Address(RVA = "0x92043D0", Offset = "0x9202FD0", VA = "0x1892043D0", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x92045E0", Offset = "0x92031E0", VA = "0x1892045E0")]
		public PIUSDQDAZIA(VJGXMHXJSVW a, [In] RigidbodyExData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x9203A60", Offset = "0x9202660", VA = "0x189203A60", Slot = "9")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x9203D00", Offset = "0x9202900", VA = "0x189203D00", Slot = "12")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x9204470", Offset = "0x9203070", VA = "0x189204470", Slot = "10")]
		public void WJPAHEJZQKP(VJGXMHXJSVW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x9203B90", Offset = "0x9202790", VA = "0x189203B90", Slot = "11")]
		public void BOICBJAOMOT(VJGXMHXJSVW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x9203DF0", Offset = "0x92029F0", VA = "0x189203DF0")]
		private void EXUUSCSUSKF(RRNetworkView a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x9204000", Offset = "0x9202C00", VA = "0x189204000")]
		private void KHPYSYDVHSD(SDMULJARPSS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x9204160", Offset = "0x9202D60", VA = "0x189204160")]
		private void TAXCCFJQKUE(RRNetworkView a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	internal static class BVAIMSQTYNE
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x91F5F00", Offset = "0x91F4B00", VA = "0x1891F5F00")]
		public static CNYDDSTVESO Lifecycle(this VJGXMHXJSVW impl)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	internal sealed class PFVCRYMWXDY : IEAKDRPWBED
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private readonly PHMUBKXKDQD MYJGWBTYYFW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private RigidbodyConstraints XFSXWXUNYAT;

		[Cpp2IlInjected.Token(Token = "0x170000B3")]
		public bool EMTUNSUCYTW
		{
			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0xBE1AA0", Offset = "0xBE06A0", VA = "0x180BE1AA0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0xF1F840", Offset = "0xF1E440", VA = "0x180F1F840", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B4")]
		public bool TADHLLZWAED
		{
			[Cpp2IlInjected.Token(Token = "0x60002FC")]
			[Cpp2IlInjected.Address(RVA = "0xBE1AF0", Offset = "0xBE06F0", VA = "0x180BE1AF0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002FD")]
			[Cpp2IlInjected.Address(RVA = "0xF1EDA0", Offset = "0xF1D9A0", VA = "0x180F1EDA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B5")]
		public RigidbodyConstraints HGDDXGFOIFZ
		{
			[Cpp2IlInjected.Token(Token = "0x60002FE")]
			[Cpp2IlInjected.Address(RVA = "0xB1D780", Offset = "0xB1C380", VA = "0x180B1D780", Slot = "7")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x60002FF")]
			[Cpp2IlInjected.Address(RVA = "0x91FD0E0", Offset = "0x91FBCE0", VA = "0x1891FD0E0", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x91FD240", Offset = "0x91FBE40", VA = "0x1891FD240")]
		public PFVCRYMWXDY(VJGXMHXJSVW a, [In] RigidbodyExData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x91FD210", Offset = "0x91FBE10", VA = "0x1891FD210", Slot = "9")]
		public void SLYFAQEHFXK(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x91FD0B0", Offset = "0x91FBCB0", VA = "0x1891FD0B0", Slot = "10")]
		public void GTUVJRMXRUB(Rigidbody a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	internal sealed class BHPVQCOFFZH : KTAMILONBGI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private readonly VJGXMHXJSVW MYJGWBTYYFW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private float SVDTCVQSKYL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private float RDVSYCZAUNF;

		[Cpp2IlInjected.Token(Token = "0x170000B6")]
		public float HCXJIGKMEGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000304")]
			[Cpp2IlInjected.Address(RVA = "0xB77D20", Offset = "0xB76920", VA = "0x180B77D20", Slot = "4")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000305")]
			[Cpp2IlInjected.Address(RVA = "0x91F5C30", Offset = "0x91F4830", VA = "0x1891F5C30", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B7")]
		public float JGZFBAAOYPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000306")]
			[Cpp2IlInjected.Address(RVA = "0xB77A50", Offset = "0xB76650", VA = "0x180B77A50", Slot = "6")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000307")]
			[Cpp2IlInjected.Address(RVA = "0x91F5DF0", Offset = "0x91F49F0", VA = "0x1891F5DF0", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x91F5EC0", Offset = "0x91F4AC0", VA = "0x1891F5EC0")]
		public BHPVQCOFFZH(VJGXMHXJSVW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x91F5DA0", Offset = "0x91F49A0", VA = "0x1891F5DA0", Slot = "8")]
		public void SLYFAQEHFXK(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x91F5D00", Offset = "0x91F4900", VA = "0x1891F5D00", Slot = "9")]
		public void GTUVJRMXRUB(Rigidbody a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	internal sealed class SBCROLNYCAD : LXFLPVDYESE
	{
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static readonly Log MYGBWUSWPUQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private readonly PHMUBKXKDQD MYJGWBTYYFW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private bool NYZLKQNGLFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private bool NDYEJJLKNCV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private int ZICSPJSOJEB;

		[Cpp2IlInjected.Token(Token = "0x170000B8")]
		private Rigidbody UYFXLBSICUR
		{
			[Cpp2IlInjected.Token(Token = "0x600030C")]
			[Cpp2IlInjected.Address(RVA = "0x91FA560", Offset = "0x91F9160", VA = "0x1891FA560")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B9")]
		private bool GXBSSXFMSLC
		{
			[Cpp2IlInjected.Token(Token = "0x600030D")]
			[Cpp2IlInjected.Address(RVA = "0x920DFC0", Offset = "0x920CBC0", VA = "0x18920DFC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BA")]
		private VJGXMHXJSVW MJTMBSVCHQR
		{
			[Cpp2IlInjected.Token(Token = "0x600030E")]
			[Cpp2IlInjected.Address(RVA = "0x920E260", Offset = "0x920CE60", VA = "0x18920E260")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		private bool VDPFUYLNWQL
		{
			[Cpp2IlInjected.Token(Token = "0x600030F")]
			[Cpp2IlInjected.Address(RVA = "0x920DCF0", Offset = "0x920C8F0", VA = "0x18920DCF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400002D")]
		public event RbexAction NPXFXXKXVZG
		{
			[Cpp2IlInjected.Token(Token = "0x600030A")]
			[Cpp2IlInjected.Address(RVA = "0x920E830", Offset = "0x920D430", VA = "0x18920E830", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600030B")]
			[Cpp2IlInjected.Address(RVA = "0x920DD60", Offset = "0x920C960", VA = "0x18920DD60", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x920EB70", Offset = "0x920D770", VA = "0x18920EB70")]
		public SBCROLNYCAD(VJGXMHXJSVW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x920DC60", Offset = "0x920C860", VA = "0x18920DC60", Slot = "6")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x920DD50", Offset = "0x920C950", VA = "0x18920DD50", Slot = "8")]
		public void HKVEXHYIRHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x920DE00", Offset = "0x920CA00", VA = "0x18920DE00", Slot = "7")]
		public bool NPBKCYDOQZW()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x920E470", Offset = "0x920D070", VA = "0x18920E470", Slot = "9")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x920E8D0", Offset = "0x920D4D0", VA = "0x18920E8D0", Slot = "13")]
		public void WFOAUJEMXEU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x920DB30", Offset = "0x920C730", VA = "0x18920DB30", Slot = "12")]
		public void ACXFQBHLQGD(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x920DF50", Offset = "0x920CB50", VA = "0x18920DF50", Slot = "10")]
		public bool PSHFBTGGMEY()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x920E2C0", Offset = "0x920CEC0", VA = "0x18920E2C0", Slot = "11")]
		public bool SXXEBJPRQTP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x920DFE0", Offset = "0x920CBE0", VA = "0x18920DFE0")]
		private bool RZJFYMOIYNJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x920E6A0", Offset = "0x920D2A0", VA = "0x18920E6A0")]
		private void VHGAAABUUSP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	internal sealed class ISTAXFZMSYI : UHBYESJLXPX
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private readonly PHMUBKXKDQD MYJGWBTYYFW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private readonly SVJYJIPYDON BNQGOMGTVIY;

		[Cpp2IlInjected.Token(Token = "0x170000BC")]
		public Rigidbody UYFXLBSICUR
		{
			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0xB18810", Offset = "0xB17410", VA = "0x180B18810", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000322")]
			[Cpp2IlInjected.Address(RVA = "0xB180B0", Offset = "0xB16CB0", VA = "0x180B180B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BD")]
		private bool VDPFUYLNWQL
		{
			[Cpp2IlInjected.Token(Token = "0x6000323")]
			[Cpp2IlInjected.Address(RVA = "0x91FB660", Offset = "0x91FA260", VA = "0x1891FB660")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BE")]
		public bool PGUWDBEZFDK
		{
			[Cpp2IlInjected.Token(Token = "0x6000326")]
			[Cpp2IlInjected.Address(RVA = "0x1E11980", Offset = "0x1E10580", VA = "0x181E11980", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x91FBDC0", Offset = "0x91FA9C0", VA = "0x1891FBDC0")]
		public ISTAXFZMSYI(VJGXMHXJSVW a, [In] RigidbodyExData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x91FB5C0", Offset = "0x91FA1C0", VA = "0x1891FB5C0", Slot = "5")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x91FB6C0", Offset = "0x91FA2C0", VA = "0x1891FB6C0", Slot = "7")]
		public void GVJLHNNWPXQ(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x91FBA20", Offset = "0x91FA620", VA = "0x1891FBA20", Slot = "8")]
		public void JDTCQTQFCWN(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x91FB6F0", Offset = "0x91FA2F0", VA = "0x1891FB6F0", Slot = "9")]
		public void GVMVUVZUCJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x91FBBD0", Offset = "0x91FA7D0", VA = "0x1891FBBD0", Slot = "10")]
		public void YTGHVGXRGGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x91FBA50", Offset = "0x91FA650", VA = "0x1891FBA50", Slot = "11")]
		public void VXUNWUHTSJK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	internal sealed class VZUTOGHILUX : MAHUHELQKQK, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private readonly PHMUBKXKDQD MYJGWBTYYFW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private readonly SVJYJIPYDON KSFCTPRFAYN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private float IDSDAOBXRGK;

		[Cpp2IlInjected.Token(Token = "0x170000BF")]
		public OTOMQYRBXFI WXFZPZLGWYX
		{
			[Cpp2IlInjected.Token(Token = "0x600032C")]
			[Cpp2IlInjected.Address(RVA = "0xB131D0", Offset = "0xB11DD0", VA = "0x180B131D0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600032D")]
			[Cpp2IlInjected.Address(RVA = "0xB180C0", Offset = "0xB16CC0", VA = "0x180B180C0", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C0")]
		public KMTQBZRQLZD MWWCGERNMFA
		{
			[Cpp2IlInjected.Token(Token = "0x600032E")]
			[Cpp2IlInjected.Address(RVA = "0xB13140", Offset = "0xB11D40", VA = "0x180B13140", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600032F")]
			[Cpp2IlInjected.Address(RVA = "0xB1ACA0", Offset = "0xB198A0", VA = "0x180B1ACA0", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C1")]
		public Vector3 ULFUNVSUSPG
		{
			[Cpp2IlInjected.Token(Token = "0x6000330")]
			[Cpp2IlInjected.Address(RVA = "0x9210590", Offset = "0x920F190", VA = "0x189210590", Slot = "8")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000331")]
			[Cpp2IlInjected.Address(RVA = "0x9211BA0", Offset = "0x92107A0", VA = "0x189211BA0", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C2")]
		public Vector3 GJZYQOZGDTR
		{
			[Cpp2IlInjected.Token(Token = "0x6000332")]
			[Cpp2IlInjected.Address(RVA = "0x9210830", Offset = "0x920F430", VA = "0x189210830", Slot = "10")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000333")]
			[Cpp2IlInjected.Address(RVA = "0x9210C00", Offset = "0x920F800", VA = "0x189210C00", Slot = "11")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C3")]
		public Vector3 UFQTFOTHGJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000334")]
			[Cpp2IlInjected.Address(RVA = "0x9211310", Offset = "0x920FF10", VA = "0x189211310", Slot = "12")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000335")]
			[Cpp2IlInjected.Address(RVA = "0x9210050", Offset = "0x920EC50", VA = "0x189210050", Slot = "13")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C4")]
		public Vector3 LPLGASCPCFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000336")]
			[Cpp2IlInjected.Address(RVA = "0x92115A0", Offset = "0x92101A0", VA = "0x1892115A0", Slot = "14")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000337")]
			[Cpp2IlInjected.Address(RVA = "0x920FAE0", Offset = "0x920E6E0", VA = "0x18920FAE0", Slot = "15")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C5")]
		public float HKVLPYKZACW
		{
			[Cpp2IlInjected.Token(Token = "0x6000338")]
			[Cpp2IlInjected.Address(RVA = "0xB77D10", Offset = "0xB76910", VA = "0x180B77D10", Slot = "16")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000339")]
			[Cpp2IlInjected.Address(RVA = "0x9211A90", Offset = "0x9210690", VA = "0x189211A90", Slot = "17")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C6")]
		public bool AKVAOCQGUNK
		{
			[Cpp2IlInjected.Token(Token = "0x600033A")]
			[Cpp2IlInjected.Address(RVA = "0x281F630", Offset = "0x281E230", VA = "0x18281F630", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C7")]
		private ZKVKFDITUUE UHQIOLMDBEQ
		{
			[Cpp2IlInjected.Token(Token = "0x600034F")]
			[Cpp2IlInjected.Address(RVA = "0x8749520", Offset = "0x8748120", VA = "0x188749520")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C8")]
		private bool GXBSSXFMSLC
		{
			[Cpp2IlInjected.Token(Token = "0x6000350")]
			[Cpp2IlInjected.Address(RVA = "0x92111C0", Offset = "0x920FDC0", VA = "0x1892111C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x9212640", Offset = "0x9211240", VA = "0x189212640")]
		public VZUTOGHILUX(VJGXMHXJSVW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x920F5D0", Offset = "0x920E1D0", VA = "0x18920F5D0", Slot = "19")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x920FB10", Offset = "0x920E710", VA = "0x18920FB10", Slot = "36")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x92111E0", Offset = "0x920FDE0", VA = "0x1892111E0", Slot = "28")]
		public void SLYFAQEHFXK(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x19C28B0", Offset = "0x19C14B0", VA = "0x1819C28B0", Slot = "20")]
		public void PCCNHEIYPNY(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x19C4780", Offset = "0x19C3380", VA = "0x1819C4780", Slot = "30")]
		public void OCFOKWYWOFL(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x9211730", Offset = "0x9210330", VA = "0x189211730", Slot = "35")]
		public Vector3 VQPXVYQXVPQ(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x9211000", Offset = "0x920FC00", VA = "0x189211000", Slot = "34")]
		public Vector3 OBIKNQBTVGI(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x920F5D0", Offset = "0x920E1D0", VA = "0x18920F5D0", Slot = "27")]
		public void LOZVTLBSINH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x9211540", Offset = "0x9210140", VA = "0x189211540", Slot = "25")]
		public void VCIEMHFRWIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x920FB70", Offset = "0x920E770", VA = "0x18920FB70", Slot = "24")]
		public void GOWZTISMJAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x9210C30", Offset = "0x920F830", VA = "0x189210C30", Slot = "33")]
		public void MVLLGENAJVD(Vector3 a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x92114E0", Offset = "0x92100E0", VA = "0x1892114E0", Slot = "32")]
		public void UGJGWNFEIZC(Vector3 a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x92124A0", Offset = "0x92110A0", VA = "0x1892124A0", Slot = "31")]
		public void YQCNNLQWZZX(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x9211DF0", Offset = "0x92109F0", VA = "0x189211DF0", Slot = "22")]
		public void XZCQWDAJRMZ(RbexImpulseType a, Vector3 b, float c, float d = 8f, float e = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x920F350", Offset = "0x920DF50", VA = "0x18920F350", Slot = "21")]
		public void AVBJEINMKLS(RbexRotationType a, Vector3 b, float c = 1f / 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x920EF60", Offset = "0x920DB60", VA = "0x18920EF60", Slot = "23")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void AIRJEKIEAGD(RbexRotationType a, Vector3 b, float c = 7f, float d = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x1D3E5F0", Offset = "0x1D3D1F0", VA = "0x181D3E5F0")]
		private static void YAQDGWTNYQJ(Vector3 a, Vector3 b, [Out] Vector3 c, [Out] Vector3 d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x9210750", Offset = "0x920F350", VA = "0x189210750", Slot = "29")]
		public Vector3 JDJWJKZVBVY(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x9210E70", Offset = "0x920FA70", VA = "0x189210E70", Slot = "26")]
		public void NUKAKVWGFEZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x9211A90", Offset = "0x9210690", VA = "0x189211A90")]
		private void WHPHWYBDFGI(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x9210A60", Offset = "0x920F660", VA = "0x189210A60")]
		private void KTEPZJORMVM(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x9211910", Offset = "0x9210510", VA = "0x189211910")]
		private Vector3 VSONPNUBBLL()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x920FBD0", Offset = "0x920E7D0", VA = "0x18920FBD0")]
		private void HEDPZPVMULL(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x9211C60", Offset = "0x9210860", VA = "0x189211C60")]
		private Vector3 XYYROKZNGCL()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x9210110", Offset = "0x920ED10", VA = "0x189210110")]
		private void IFGWRHFKJTJ(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x920F680", Offset = "0x920E280", VA = "0x18920F680")]
		private void BXFPVUOJQSA(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x92109B0", Offset = "0x920F5B0", VA = "0x1892109B0")]
		private void KIHNJPBJENU()
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
