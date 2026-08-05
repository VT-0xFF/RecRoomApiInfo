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
		[Cpp2IlInjected.Address(RVA = "0xAD08C0", Offset = "0xACEEC0", VA = "0x180AD08C0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD0990", Offset = "0xACEF90", VA = "0x180AD0990")]
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
		[Cpp2IlInjected.Address(RVA = "0x8CCE670", Offset = "0x8CCCC70", VA = "0x188CCE670", Slot = "4")]
		public override void KQPXXDZDTRT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xAD08C0", Offset = "0xACEEC0", VA = "0x180AD08C0")]
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
		private int[] TPUBNGGXPOQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private ServiceBitset EHSYFWCIGXF;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xAAFED0", Offset = "0xAAE4D0", VA = "0x180AAFED0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x86BE6A0", Offset = "0x86BCCA0", VA = "0x1886BE6A0", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8CD9D80", Offset = "0x8CD8380", VA = "0x188CD9D80")]
		private void UAFZRFJIDZJ(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8CD9D20", Offset = "0x8CD8320", VA = "0x188CD9D20", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8CDA060", Offset = "0x8CD8660", VA = "0x188CDA060")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[DisallowMultipleComponent]
	public sealed class RigidbodyEx : MonoBehaviour, RDQYEZMSIPZ, UVPGGFUQPUW, WCDUUKVIGQY
	{
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static readonly Log JGSEPCGLIKS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private bool XBUFGNCZZNQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private RVJCLYOAPLX ZHRZKBZASWG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[SerializeField]
		[AutofillOptional(AutofillType.Self, false, false, false)]
		private Rigidbody unityRigidbody;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[SerializeField]
		[AutofillOptional(AutofillType.SelfAndParent, true, false, false)]
		private RRNetworkView rrNetworkView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[SerializeField]
		private OverridableVector3 precomputedCenterOfMass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[SerializeField]
		private OverridableVector3 customCenterOfMass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		[SerializeField]
		[FormerlySerializedAs("forceNoInterpolation")]
		private RbexInterpolationMode physicsInterpolation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[SerializeField]
		[TooltipAttribute("If checked, this object's Unity Rigidbody will not be stripped when parenting the object to another RigidbodyEx. Only check this on objects that have a Unity Rigidbody by default and who need access to Unity physics events like OnTriggerEnter, OnCollisionEnter, etc. This is sometimes set via script instead of this flag.")]
		private bool keepUnityRigidbodyWhileParented;

		[Cpp2IlInjected.FieldOffset(Offset = "0x65")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[SerializeField]
		[TooltipAttribute("If the RigidbodyEx has a parent that is being destroyed, this flag allows this RigidbodyEx to keep the parent set. The default behavior is thatthe parent property is set to null, resetting/clearing the existing parent when it is being destroyed.")]
		private bool keepParentOnParentDestroy;

		[Cpp2IlInjected.FieldOffset(Offset = "0x66")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		[SerializeField]
		[HideInInspector]
		private bool hasUnityRigidbodyByDefault;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private Transform ZZAAVYBJAGG;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal RVJCLYOAPLX QLSILRZRARE
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x8CD37E0", Offset = "0x8CD1DE0", VA = "0x188CD37E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private RVJCLYOAPLX AJFIHRBKAHW
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xAAFED0", Offset = "0xAAE4D0", VA = "0x180AAFED0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int HUHKTJRFZGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x8CD56C0", Offset = "0x8CD3CC0", VA = "0x188CD56C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RigidbodyEx ZAQIOZDUTOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x8CD5A20", Offset = "0x8CD4020", VA = "0x188CD5A20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx KXNQQKPTVYU
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x8CD5960", Offset = "0x8CD3F60", VA = "0x188CD5960")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RigidbodyEx SEJYAKTRJIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x8CD6620", Offset = "0x8CD4C20", VA = "0x188CD6620")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x8CD7B20", Offset = "0x8CD6120", VA = "0x188CD7B20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool DidStart
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x80BA520", Offset = "0x80B8B20", VA = "0x1880BA520", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x80BA670", Offset = "0x80B8C70", VA = "0x1880BA670")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Transform FXOQWRPSRBW
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x2573610", Offset = "0x2571C10", VA = "0x182573610", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Transform RVXPBHAWTGX
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x2573610", Offset = "0x2571C10", VA = "0x182573610", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Transform MYGXPCYGXQL
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x2573610", Offset = "0x2571C10", VA = "0x182573610", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public TransformTrackRate LFJLPSMNURZ
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x8CD5720", Offset = "0x8CD3D20", VA = "0x188CD5720")]
			get
			{
				return default(TransformTrackRate);
			}
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x8CD72D0", Offset = "0x8CD58D0", VA = "0x188CD72D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool RYZUWNDXRMY
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x8CD5D30", Offset = "0x8CD4330", VA = "0x188CD5D30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool TSBYLEBGUPQ
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x8CD5840", Offset = "0x8CD3E40", VA = "0x188CD5840")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public GWZOVDSJQAJ ENBNSDCTZAO
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x8CD5C70", Offset = "0x8CD4270", VA = "0x188CD5C70")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x8CD7490", Offset = "0x8CD5A90", VA = "0x188CD7490")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public XTLAQFBHGWM NKUSKFWRICR
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x8CD5C10", Offset = "0x8CD4210", VA = "0x188CD5C10")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x8CD7420", Offset = "0x8CD5A20", VA = "0x188CD7420")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool DTONGYNCRVD
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x8CD5B60", Offset = "0x8CD4160", VA = "0x188CD5B60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Rigidbody VRSPXEIIPIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x8CD5BC0", Offset = "0x8CD41C0", VA = "0x188CD5BC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool OJIQCIDCODR
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x8CD58A0", Offset = "0x8CD3EA0", VA = "0x188CD58A0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x8CD7340", Offset = "0x8CD5940", VA = "0x188CD7340")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool MACVPJFZWSK
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x1A06510", Offset = "0x1A04B10", VA = "0x181A06510", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float LGMRODGTAIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x8CD65C0", Offset = "0x8CD4BC0", VA = "0x188CD65C0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float UVTXKJXGLOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x8CD6560", Offset = "0x8CD4B60", VA = "0x188CD6560")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x8CD7AB0", Offset = "0x8CD60B0", VA = "0x188CD7AB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public float CXYEINRWRYG
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x8CD5F90", Offset = "0x8CD4590", VA = "0x188CD5F90")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x8CD7730", Offset = "0x8CD5D30", VA = "0x188CD7730")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public float VGZTVEKWMHK
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x8CD5D90", Offset = "0x8CD4390", VA = "0x188CD5D90")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x8CD7500", Offset = "0x8CD5B00", VA = "0x188CD7500")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public bool JLCWORLMOFZ
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x8CD6B70", Offset = "0x8CD5170", VA = "0x188CD6B70")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x8CD8060", Offset = "0x8CD6660", VA = "0x188CD8060")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Vector3 YCVFJFISDCL
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x8CD6340", Offset = "0x8CD4940", VA = "0x188CD6340")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x8CD7880", Offset = "0x8CD5E80", VA = "0x188CD7880")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public Vector3 SACEDOKRRGQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x8CD6CB0", Offset = "0x8CD52B0", VA = "0x188CD6CB0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public CollisionDetectionMode VGQVSOPRSGY
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x8CD5ED0", Offset = "0x8CD44D0", VA = "0x188CD5ED0")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x8CD7650", Offset = "0x8CD5C50", VA = "0x188CD7650")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public float FPFKHWYFMQX
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x8CD5900", Offset = "0x8CD3F00", VA = "0x188CD5900")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x8CD73B0", Offset = "0x8CD59B0", VA = "0x188CD73B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public RigidbodyConstraints UEMMTZWHGLW
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x8CD5F30", Offset = "0x8CD4530", VA = "0x188CD5F30")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x8CD76C0", Offset = "0x8CD5CC0", VA = "0x188CD76C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public Vector3 HQOCHFPNQNU
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x8CD66E0", Offset = "0x8CD4CE0", VA = "0x188CD66E0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public Vector3 XAKOYUIGXJA
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x8CD66E0", Offset = "0x8CD4CE0", VA = "0x188CD66E0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x8CD7E40", Offset = "0x8CD6440", VA = "0x188CD7E40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public float EYSNZGYRZEV
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x8CD6420", Offset = "0x8CD4A20", VA = "0x188CD6420")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x8CD7960", Offset = "0x8CD5F60", VA = "0x188CD7960")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public float VEAWSRCGCOO
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x8CD6B10", Offset = "0x8CD5110", VA = "0x188CD6B10")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x8CD7FF0", Offset = "0x8CD65F0", VA = "0x188CD7FF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Quaternion HKDATLHTXBN
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x8CD67C0", Offset = "0x8CD4DC0", VA = "0x188CD67C0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x8CD7BC0", Offset = "0x8CD61C0", VA = "0x188CD7BC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Quaternion EFIQCWNCFGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x8CD6A40", Offset = "0x8CD5040", VA = "0x188CD6A40")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x8CD7F20", Offset = "0x8CD6520", VA = "0x188CD7F20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector3 RJRDGEJOILZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x8CD6890", Offset = "0x8CD4E90", VA = "0x188CD6890")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x8CD7C90", Offset = "0x8CD6290", VA = "0x188CD7C90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Quaternion BCUWDNQBKUK
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x8CD6970", Offset = "0x8CD4F70", VA = "0x188CD6970")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x8CD7D70", Offset = "0x8CD6370", VA = "0x188CD7D70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 AHCIWLGYJPR
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x8CD6BD0", Offset = "0x8CD51D0", VA = "0x188CD6BD0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x8CD80D0", Offset = "0x8CD66D0", VA = "0x188CD80D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 PORZPMHQZUY
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x8CD6480", Offset = "0x8CD4A80", VA = "0x188CD6480")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x8CD79D0", Offset = "0x8CD5FD0", VA = "0x188CD79D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector3 TVAHISVZYJT
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x8CD5DF0", Offset = "0x8CD43F0", VA = "0x188CD5DF0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x8CD7570", Offset = "0x8CD5B70", VA = "0x188CD7570")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector3 DHXJBSOFPQU
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x8CD6260", Offset = "0x8CD4860", VA = "0x188CD6260")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x8CD77A0", Offset = "0x8CD5DA0", VA = "0x188CD77A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector3 JDXMOLBEQZF
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x8CD6120", Offset = "0x8CD4720", VA = "0x188CD6120")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Quaternion EMSBALTHREN
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x8CD6050", Offset = "0x8CD4650", VA = "0x188CD6050")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public Vector3 WATESJJGLTD
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x8CD6E70", Offset = "0x8CD5470", VA = "0x188CD6E70")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public Vector3 RMROSJGEQET
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x8CD6D90", Offset = "0x8CD5390", VA = "0x188CD6D90")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool GQRKVRUDNUJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x8CD6200", Offset = "0x8CD4800", VA = "0x188CD6200")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool DHOGBUZFGDA
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x8CD5CD0", Offset = "0x8CD42D0", VA = "0x188CD5CD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool KWFBGIOLEIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x8CD57E0", Offset = "0x8CD3DE0", VA = "0x188CD57E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool EHFCNEEPFCQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x8CD5780", Offset = "0x8CD3D80", VA = "0x188CD5780")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool KUSDVIFWQSN
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x8CD5660", Offset = "0x8CD3C60", VA = "0x188CD5660")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public bool GSRWGIRJDRC
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x8CD5FF0", Offset = "0x8CD45F0", VA = "0x188CD5FF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool UPIAPPMCHTM
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xE76BC0", Offset = "0xE751C0", VA = "0x180E76BC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event RbexParentChangeAction CFKQIMSLVHS
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x8CD5580", Offset = "0x8CD3B80", VA = "0x188CD5580")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x8CD71F0", Offset = "0x8CD57F0", VA = "0x188CD71F0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event RbexAction XBSNUORLFIY
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x8CD52F0", Offset = "0x8CD38F0", VA = "0x188CD52F0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x8CD6F50", Offset = "0x8CD5550", VA = "0x188CD6F50")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event RbexAction JIJKHZKMUPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x8CD5350", Offset = "0x8CD3950", VA = "0x188CD5350")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x8CD6FC0", Offset = "0x8CD55C0", VA = "0x188CD6FC0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event RbexAction REYSTJINLEW
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x8CD54A0", Offset = "0x8CD3AA0", VA = "0x188CD54A0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x8CD7110", Offset = "0x8CD5710", VA = "0x188CD7110")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<UpdateLOD, UpdateLOD> JSASWVDUFKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x8CD5430", Offset = "0x8CD3A30", VA = "0x188CD5430")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x8CD70A0", Offset = "0x8CD56A0", VA = "0x188CD70A0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event RbexAction UFJOJQVKBBT
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x8CD5510", Offset = "0x8CD3B10", VA = "0x188CD5510")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x8CD7180", Offset = "0x8CD5780", VA = "0x188CD7180")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event RbexAction JSHQFOCSKQD
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x8CD55F0", Offset = "0x8CD3BF0", VA = "0x188CD55F0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x8CD7260", Offset = "0x8CD5860", VA = "0x188CD7260")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event RbexAction LNDYYFCXCXA
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x8CD53C0", Offset = "0x8CD39C0", VA = "0x188CD53C0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x8CD7030", Offset = "0x8CD5630", VA = "0x188CD7030")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xAA8690", Offset = "0xAA6C90", VA = "0x180AA8690", Slot = "8")]
		private void AEDDOKYYFIA(RVJCLYOAPLX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8CD3F30", Offset = "0x8CD2530", VA = "0x188CD3F30", Slot = "9")]
		public RigidbodyExData GetData()
		{
			return default(RigidbodyExData);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8CD3BF0", Offset = "0x8CD21F0", VA = "0x188CD3BF0")]
		internal void GVGTGIWPRVD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8CD5020", Offset = "0x8CD3620", VA = "0x188CD5020")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public void TestOverrideUnityRigidbody(Rigidbody rb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8CD3C80", Offset = "0x8CD2280", VA = "0x188CD3C80")]
		public RDQYEZMSIPZ GetChild(int index)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x8CD4C80", Offset = "0x8CD3280", VA = "0x188CD4C80")]
		public void SetInertiaTensor((Quaternion rot, Vector3 moments) tensor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x8CD3610", Offset = "0x8CD1C10", VA = "0x188CD3610")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x8CD4F10", Offset = "0x8CD3510", VA = "0x188CD4F10")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8CD37E0", Offset = "0x8CD1DE0", VA = "0x188CD37E0")]
		private RVJCLYOAPLX BWSYXIDAVAC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8CD3A70", Offset = "0x8CD2070", VA = "0x188CD3A70")]
		private void FTYJJGFKYMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8CD4450", Offset = "0x8CD2A50", VA = "0x188CD4450")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x8CD4390", Offset = "0x8CD2990", VA = "0x188CD4390")]
		public void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x8CD3BF0", Offset = "0x8CD21F0", VA = "0x188CD3BF0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8CD43F0", Offset = "0x8CD29F0", VA = "0x188CD43F0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8CD44B0", Offset = "0x8CD2AB0", VA = "0x188CD44B0")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8CD2C00", Offset = "0x8CD1200", VA = "0x188CD2C00")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x8CD4510", Offset = "0x8CD2B10", VA = "0x188CD4510")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8CD3A10", Offset = "0x8CD2010", VA = "0x188CD3A10")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x8CD4330", Offset = "0x8CD2930", VA = "0x188CD4330")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x8CD4DE0", Offset = "0x8CD33E0", VA = "0x188CD4DE0")]
		public void SetParent(RigidbodyEx value, bool isPhysicallyDetachedOnly = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x8CD4820", Offset = "0x8CD2E20", VA = "0x188CD4820")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8CD3FC0", Offset = "0x8CD25C0", VA = "0x188CD3FC0")]
		public bool IsRigidbodyAncestor(RigidbodyEx possibleAncestor)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8CD40C0", Offset = "0x8CD26C0", VA = "0x188CD40C0")]
		public bool IsRigidbodyDescendant(RigidbodyEx possibleDescendant)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8CD2E70", Offset = "0x8CD1470", VA = "0x188CD2E70")]
		public void AddInterpolationRestriction(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8CD4580", Offset = "0x8CD2B80", VA = "0x188CD4580")]
		public void RemoveInterpolationRestriction(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x8CD2EE0", Offset = "0x8CD14E0", VA = "0x188CD2EE0")]
		public void AddKinematic(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x8CD45F0", Offset = "0x8CD2BF0", VA = "0x188CD45F0")]
		public void RemoveKinematic(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x8CD4D60", Offset = "0x8CD3360", VA = "0x188CD4D60")]
		public void SetKinematic(object token, bool setKinematic)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x8CD4B80", Offset = "0x8CD3180", VA = "0x188CD4B80")]
		public void SetDiscontinuousPositionAndRotation(Vector3 newPosition, Quaternion newRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x8CD4A80", Offset = "0x8CD3080", VA = "0x188CD4A80")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 newLocalPosition, Quaternion newLocalRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x8CD3E20", Offset = "0x8CD2420", VA = "0x188CD3E20")]
		public Vector3 GetConstrainedVelocity(Vector3 velocity)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x8CD3D10", Offset = "0x8CD2310", VA = "0x188CD3D10")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 angularVelocity)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8CD2D80", Offset = "0x8CD1380", VA = "0x188CD2D80")]
		public void AddForce(Vector3 force, ForceMode forceMode = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x8CD2C70", Offset = "0x8CD1270", VA = "0x188CD2C70")]
		public void AddForceAtPosition(Vector3 force, Vector3 position, ForceMode forceMode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8CD30B0", Offset = "0x8CD16B0", VA = "0x188CD30B0")]
		public void AddTorque(Vector3 torque, ForceMode forceMode = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x8CD2F50", Offset = "0x8CD1550", VA = "0x188CD2F50")]
		public void AddRelativeTorque(Vector3 torque, ForceMode forceMode = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8CD50F0", Offset = "0x8CD36F0", VA = "0x188CD50F0")]
		public Vector3 WorldToLocalVelocity(Vector3 worldVelocity)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8CD4220", Offset = "0x8CD2820", VA = "0x188CD4220")]
		public Vector3 LocalToWorldVelocity(Vector3 localVelocity)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8CD39B0", Offset = "0x8CD1FB0", VA = "0x188CD39B0")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8CD3950", Offset = "0x8CD1F50", VA = "0x188CD3950")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8CD38F0", Offset = "0x8CD1EF0", VA = "0x188CD38F0")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8CD3890", Offset = "0x8CD1E90", VA = "0x188CD3890")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x8CD4980", Offset = "0x8CD2F80", VA = "0x188CD4980")]
		public void ResetVelocityWorldSpace(Vector3 worldLinearVelocity, Vector3 worldAngularVelocity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x8CD4880", Offset = "0x8CD2E80", VA = "0x188CD4880")]
		public void ResetVelocityLocalSpace(Vector3 localLinearVelocity, Vector3 localAngularVelocity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x8CD4740", Offset = "0x8CD2D40", VA = "0x188CD4740")]
		public void ResetLinearVelocityLocalSpace(Vector3 localLinearVelocity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x8CD4F20", Offset = "0x8CD3520", VA = "0x188CD4F20")]
		public bool SweepTest(Vector3 direction, [Out] RaycastHit hitInfo, float maxDistance)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x8CD41C0", Offset = "0x8CD27C0", VA = "0x188CD41C0")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x8CD4EB0", Offset = "0x8CD34B0", VA = "0x188CD4EB0")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x8CD5090", Offset = "0x8CD3690", VA = "0x188CD5090")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x8CD3040", Offset = "0x8CD1640", VA = "0x188CD3040")]
		public void AddShouldHaveUnityRigidbodyToken(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x8CD4660", Offset = "0x8CD2C60", VA = "0x188CD4660")]
		public void RemoveShouldHaveUnityRigidbodyToken(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x8CD3440", Offset = "0x8CD1A40", VA = "0x188CD3440")]
		public void ApplyForceVelocityChange(RbexImpulseType impulseType, Vector3 impulseDirection, float impulseSpeed, float impulseDirectionMaxSpeed = 8f, float impulseReflectiveRestitution = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x8CD3340", Offset = "0x8CD1940", VA = "0x188CD3340")]
		public void ApplyAngularVelocityChange(RbexRotationType rotationType, Vector3 newAngularVelocity, float maxAngularSpeed = 1f / 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x8CD3500", Offset = "0x8CD1B00", VA = "0x188CD3500")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void ApplyTorqueAngularVelocityChangeDeprecated(RbexRotationType rotationType, Vector3 rotation, float maxSpeed = 7f, float multiplyingFactor = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x8CD3270", Offset = "0x8CD1870", VA = "0x188CD3270")]
		public bool AllowedScaleChange(float scaleFactor)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x8CD31A0", Offset = "0x8CD17A0", VA = "0x188CD31A0")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx parentOverride, object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x8CD46D0", Offset = "0x8CD2CD0", VA = "0x188CD46D0")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x8CD37D0", Offset = "0x8CD1DD0", VA = "0x188CD37D0", Slot = "13")]
		private void BOZJFYSAXGL(RODATQHQXLX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x8CD5280", Offset = "0x8CD3880", VA = "0x188CD5280")]
		public RigidbodyEx()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0xBBA5D0", Offset = "0xBB8BD0", VA = "0x180BBA5D0", Slot = "4")]
		private GameObject CCVZOSSMDRM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0xAD30B0", Offset = "0xAD16B0", VA = "0x180AD30B0", Slot = "10")]
		private bool FBHCIIFSLTL()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	internal static class JTRVWENJRXK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x8CCBC00", Offset = "0x8CCA200", VA = "0x188CCBC00")]
		public static RVJCLYOAPLX QLSILRZRARE(this RigidbodyEx a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[RegisterService(typeof(TYSHKOYFMJE), new string[] { })]
	public class RigidbodyExManager : TYSHKOYFMJE, UTOILWCTUPI
	{
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static readonly Log WOAZIZZDVRE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private GKOHKAIKSPT FZDXDPPJXPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private IAEDZMQDMFW BGYFHTBILSW;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public GKOHKAIKSPT TUDUSUBOTJK
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAA9CB0", VA = "0x180AAB6B0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public IAEDZMQDMFW VONKGWNJIJE
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x8CD2B10", Offset = "0x8CD1110", VA = "0x188CD2B10", Slot = "7")]
		public void InitReferences(XRIYJCZWKCD services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x8CD2940", Offset = "0x8CD0F40", VA = "0x188CD2940", Slot = "6")]
		public RVJCLYOAPLX DTVWHLJDNBE(RigidbodyEx a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public RigidbodyExManager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class PhysicsManager : SingletonMonoBehaviour<PhysicsManager>
	{
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static ENIVEIKFIDY UpdateAfterFixedUpdateRan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private int FQGMEQVHHRS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private int KXLAUSEDLUE;

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x8CD0900", Offset = "0x8CCEF00", VA = "0x188CD0900")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x8CD0980", Offset = "0x8CCEF80", VA = "0x188CD0980")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x8CD0920", Offset = "0x8CCEF20", VA = "0x188CD0920")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string message, [Optional] UnityEngine.Object context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string message, [Optional] UnityEngine.Object context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x8CD0A70", Offset = "0x8CCF070", VA = "0x188CD0A70")]
		public PhysicsManager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public static class JTLROBRFNZC
	{
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		private class DFTTKZPBJWA : GWZOVDSJQAJ, IDisposable
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "7")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0xAB65F0", Offset = "0xAB4BF0", VA = "0x180AB65F0", Slot = "4")]
			public Vector3 QDEEGOZNVJD()
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0xAB65F0", Offset = "0xAB4BF0", VA = "0x180AB65F0", Slot = "5")]
			public Vector3 OKEJMUWZDTS()
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0xAC1350", Offset = "0xABF950", VA = "0x180AC1350", Slot = "6")]
			public bool IUSMPRUIDXJ(float a, float b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public DFTTKZPBJWA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public static GWZOVDSJQAJ XICMDTMPXGV
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x8CCBB40", Offset = "0x8CCA140", VA = "0x188CCBB40")]
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
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public interface TFZWLFYJYQR
	{
		[Cpp2IlInjected.Token(Token = "0x17000039")]
		CollisionDetectionMode IBRRXADKWGA
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void Awake();

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void POGNEBSJIUU(bool a);

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void QNBALZTOJJN(bool a);

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void ZVKKKTRCJBD(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool RHOKRHCVZQI(Vector3 a, [Out] RaycastHit b, float c);
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public interface BEVDNHVFTHQ : IDisposable, VUNEHBLTFAM
	{
		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		TransformTrackRate LFJLPSMNURZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		event Action<UpdateLOD, UpdateLOD> JSASWVDUFKI;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void Awake();
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[ServiceLifetime(Lifetime.Application)]
	public interface IAEDZMQDMFW
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		ZLBHJFTKGJP RYLPHYZXNID(RVJCLYOAPLX a);

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		SKWLMCVUKGZ GWELHXMHLBJ(RVJCLYOAPLX a);

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		EHIYEIIUDTM FXUDKMZBEGE(RVJCLYOAPLX a);

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		TZSCBQPDMZN FYETCDMSZVL(RVJCLYOAPLX a);

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "4")]
		RSCFVADDZAV UCQQUUYQFHF(RVJCLYOAPLX a);

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "5")]
		BEVDNHVFTHQ KXEGIJZKXTO(RVJCLYOAPLX a);

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "6")]
		FKUWDWOVKZZ FBFXCUFUJDP(RVJCLYOAPLX a);

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "7")]
		VINEMBIXZEB CJUJDPCUMMX(RVJCLYOAPLX a);

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "8")]
		TFZWLFYJYQR OIVILGECYRF(RVJCLYOAPLX a);

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "9")]
		MMDDAMPKZMI WTNSYHLZPVE(RVJCLYOAPLX a);

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "10")]
		BPZLJWRJIWW ATKUHIEHYDW(RVJCLYOAPLX a, [In] RigidbodyExData data);

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "11")]
		RTQKKKCRVPA OXWXIHYQRFS(RVJCLYOAPLX a, [In] RigidbodyExData data);

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "12")]
		ULOOGXWJXJW EAPSJDRQKTE(RVJCLYOAPLX a, [In] RigidbodyExData data);

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "13")]
		FQLHGFIAXKM NZYSIMCPBNE(RVJCLYOAPLX a, [In] RigidbodyExData data);

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "14")]
		USAKKBDPQSE KFPQUPOQGDA(RVJCLYOAPLX a, [In] RigidbodyExData data);

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "15")]
		RVJCLYOAPLX DTVWHLJDNBE(RigidbodyEx a, RigidbodyExData b, TYSHKOYFMJE c);
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface VINEMBIXZEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void ZHAAVPZLZNI(Vector3 a, ForceMode b = ForceMode.Force);

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void UZTITFQJZGI(Vector3 a, Vector3 b, ForceMode c);

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void FUHXARLNTCR(Vector3 a, ForceMode b = ForceMode.Force);

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void UWZTPEUMPYV(Vector3 a, ForceMode b = ForceMode.Force);
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface MMDDAMPKZMI
	{
		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		bool UBADDGEUNTB
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void ZVKKKTRCJBD(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void AOKHSYMWGWW(Rigidbody a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public interface ZLBHJFTKGJP : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		IReadOnlyList<RVJCLYOAPLX> PPZATSLBMJO
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(Slot = "18")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		RVJCLYOAPLX KXNQQKPTVYU
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(Slot = "19")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		RVJCLYOAPLX VTVCVRULVZC
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(Slot = "20")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(Slot = "21")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		event RbexAction XBSNUORLFIY;

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		event RbexAction JIJKHZKMUPE;

		[Cpp2IlInjected.Token(Token = "0x1400000C")]
		event RbexParentChangeAction FZIHJZHWBZO;

		[Cpp2IlInjected.Token(Token = "0x1400000D")]
		event Action LBHWJZRNHKZ;

		[Cpp2IlInjected.Token(Token = "0x1400000E")]
		event Action ATFGYMTCMUW;

		[Cpp2IlInjected.Token(Token = "0x1400000F")]
		event Action<RVJCLYOAPLX> ZLLLFLTOJJN;

		[Cpp2IlInjected.Token(Token = "0x14000010")]
		event Action<RVJCLYOAPLX> ZXXSJADUXBW;

		[Cpp2IlInjected.Token(Token = "0x14000011")]
		event Action XCDZFYSGCJJ;

		[Cpp2IlInjected.Token(Token = "0x14000012")]
		event Action<RVJCLYOAPLX> JXMPDXCRXBW;

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "22")]
		void SetParent(RVJCLYOAPLX newParent, bool isPhysicallyDetachedOnly = false);
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public interface EHIYEIIUDTM
	{
		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		Vector3 WVDERJFXLHT
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		Vector3 UUPZSHGJAQT
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void EEKULKBKTJF(RVJCLYOAPLX a, object b);

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void DFJXMEPCRRC(object a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public interface FQLHGFIAXKM
	{
		[Cpp2IlInjected.Token(Token = "0x17000041")]
		Vector3 JQMBINHTMOX
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		Vector3 ZNIPXSKVBVK
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		float ZOGHTOAMTPW
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		float NEVEOTWGTWL
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(Slot = "7")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		Vector3 KPNWERTDQVV
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		Quaternion BTMHZDZPTEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000013")]
		event RbexAction JSNYKKROGOC;

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void GIVGAKBJRFB((Quaternion rot, Vector3 moments) tensor);

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(Slot = "11")]
		void ZYICHSWFPIK();

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void VOLQCZQRAXX();

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(Slot = "13")]
		void UXEZXRLAETN();

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void ZVKKKTRCJBD(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void AOKHSYMWGWW(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void OnDrawGizmosSelected();
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public interface ULOOGXWJXJW
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Awake();

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void FFGILZADZJJ(object a);

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void IQHCJXUOCSS(object a);

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void LNKQUMKXDWG(RVJCLYOAPLX a);

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void TQBEPDBTRSZ(RVJCLYOAPLX a);

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void KYIYECYQYNQ();
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public interface FKUWDWOVKZZ
	{
		[Cpp2IlInjected.Token(Token = "0x17000047")]
		bool XMOTNJSXNOF
		{
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000014")]
		event RbexAction MMRAAZNVBBN;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void UQHHDEMYSNC(object a);

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void GNIPAXTFFRH(object a);

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void WDSUTKKKOXH(object a, bool b);

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void ZVKKKTRCJBD(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void AOKHSYMWGWW(Rigidbody a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface RTQKKKCRVPA : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000048")]
		bool RYZUWNDXRMY
		{
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		bool TSBYLEBGUPQ
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000015")]
		event RbexAction LMQTYIKWJBV;

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void Awake();

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void NEATZKLVLVK(RVJCLYOAPLX a);

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void PFYQNFIMJMA(RVJCLYOAPLX a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface USAKKBDPQSE
	{
		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		bool OJIQCIDCODR
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		bool OSCFERLNNOW
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		RigidbodyConstraints UEXBILMUHCU
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(Slot = "4")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void ZVKKKTRCJBD(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void AOKHSYMWGWW(Rigidbody a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface TZSCBQPDMZN
	{
		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		float TFNROOJRIYS
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		float KRJDZBDSTUM
		{
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void ZVKKKTRCJBD(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void AOKHSYMWGWW(Rigidbody a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public interface RSCFVADDZAV
	{
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		static bool VZAEHIZJLEZ;

		[Cpp2IlInjected.Token(Token = "0x14000016")]
		event RbexAction RLSMFOUTABP;

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void Awake();

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool GBLVPQIMCEV();

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void AENKOIIYPXJ();

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void Sleep();

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool MCDRAVLDNDB();

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool BVTUYQYDARE();

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void BYBTTGMUFUQ(bool a);

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void WXNQIESLXQB();
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public interface BPZLJWRJIWW
	{
		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		Rigidbody VRSPXEIIPIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		bool SADHAXDELBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void Awake();

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void XLEVRRHIHKP(object a);

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void IWTOHCEWFXU(object a);

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void AHIPWWSMQGD();
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public interface SKWLMCVUKGZ : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000051")]
		GWZOVDSJQAJ ENBNSDCTZAO
		{
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		XTLAQFBHGWM NKUSKFWRICR
		{
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		Vector3 MIZTDCUUJAT
		{
			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(Slot = "5")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		Vector3 GUXZBVKNDMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(Slot = "7")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		Vector3 NTQHGGLVDWZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(Slot = "9")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		Vector3 ZNYZYPOGLSI
		{
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(Slot = "11")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		float FPFKHWYFMQX
		{
			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(Slot = "13")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		bool DTONGYNCRVD
		{
			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(Slot = "14")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void Awake();

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void TQWHBYNVZXV(object a);

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(Slot = "17")]
		void WIASDOLUIXD(RbexRotationType a, Vector3 b, float c = 1f / 0f);

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(Slot = "18")]
		void KWVASTHJFQE(RbexImpulseType a, Vector3 b, float c, float d = 8f, float e = 1f);

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(Slot = "19")]
		void FTIQBIMRMLI(RbexRotationType a, Vector3 b, float c = 7f, float d = 1f);

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(Slot = "20")]
		void FBWEYOMQCDY();

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(Slot = "21")]
		void IBMFXXKGQQT();

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(Slot = "22")]
		void ESINSQNCERM();

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(Slot = "23")]
		void TZTJZYFQYLU();

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(Slot = "24")]
		void ZVKKKTRCJBD(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(Slot = "25")]
		Vector3 GUDIQEGSVRZ(Vector3 a);

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(Slot = "26")]
		void DMYJCFGBAWG(object a);

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(Slot = "27")]
		void QBLYPYRLXVE(Vector3 a);

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(Slot = "28")]
		void ZBUQCOEYNNB(Vector3 a, Vector3 b);

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(Slot = "29")]
		void EZGSSGBAMSW(Vector3 a, Vector3 b);

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(Slot = "30")]
		Vector3 SPLSVTCBSAZ(Vector3 a);

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(Slot = "31")]
		Vector3 DNSNNGPNWBB(Vector3 a);
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[ServiceLifetime(Lifetime.Application)]
	public interface GKOHKAIKSPT
	{
		[Cpp2IlInjected.Token(Token = "0x17000059")]
		bool QTSGZHOKJGC
		{
			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void VZWWJLOLDVG(string a);

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void GGVSTKBRVGD(RigidbodyEx a, Action b);

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		JLYTYYSRFKV JDNWBSPXEKK(int a);

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void VEDNYXQZBJE(Vector3 a, float b, Color c);
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[ServiceLifetime(Lifetime.Application)]
	public interface TYSHKOYFMJE
	{
		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		GKOHKAIKSPT TUDUSUBOTJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		IAEDZMQDMFW VONKGWNJIJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(Slot = "2")]
		RVJCLYOAPLX DTVWHLJDNBE(RigidbodyEx a);
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class DUNPNXBIWKA : RVJCLYOAPLX, IDisposable, LTJLUSLDRAG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		internal readonly TYSHKOYFMJE TKPCNEHSYAX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		internal ZLBHJFTKGJP SEZQIJPYBYX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		internal ULOOGXWJXJW AHPYZZIFXSG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		internal RTQKKKCRVPA WVGDXMSDLLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		internal SKWLMCVUKGZ AHCIWLGYJPR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		internal EHIYEIIUDTM CBYTOWDAYXG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		internal FQLHGFIAXKM HZQUQTOABVY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		internal TZSCBQPDMZN ZXDPRHHAYJT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		internal MMDDAMPKZMI DKFDRPXIXSW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		internal RSCFVADDZAV CTVSHJVFPXR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		internal BEVDNHVFTHQ GSOSLCLWBFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		internal FKUWDWOVKZZ MUPAWUFXQUV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		internal VINEMBIXZEB EQNXKTCJWXF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		internal USAKKBDPQSE ZKGUTXZPEHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		internal BPZLJWRJIWW AMWYNJENHXW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		internal TFZWLFYJYQR ABBKVNWIQHV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		internal IDisposable RBQADMTDCGW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private bool YCYDJWYBGOE;

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public ObjectLocalId JTDQUATOHKS
		{
			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0xAA6860", Offset = "0xAA4E60", VA = "0x180AA6860", Slot = "22")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public RDQYEZMSIPZ WGZFOQFQUNM
		{
			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0xBD1370", Offset = "0xBCF970", VA = "0x180BD1370", Slot = "24")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0xBD1270", Offset = "0xBCF870", VA = "0x180BD1270")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public GameObject OIIVGYXZJKR
		{
			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0xAA9E40", Offset = "0xAA8440", VA = "0x180AA9E40", Slot = "25")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0xAAA150", Offset = "0xAA8750", VA = "0x180AAA150")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public Transform HBZICNJLAVK
		{
			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0xBD1290", Offset = "0xBCF890", VA = "0x180BD1290", Slot = "26")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0xBD1390", Offset = "0xBCF990", VA = "0x180BD1390")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public Rigidbody VRSPXEIIPIE
		{
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x8CC39F0", Offset = "0x8CC1FF0", VA = "0x188CC39F0", Slot = "23")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public RVJCLYOAPLX VTVCVRULVZC
		{
			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x8CC25E0", Offset = "0x8CC0BE0", VA = "0x188CC25E0", Slot = "27")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x8CC5A50", Offset = "0x8CC4050", VA = "0x188CC5A50", Slot = "28")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public int HUHKTJRFZGF
		{
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x8CC6160", Offset = "0x8CC4760", VA = "0x188CC6160", Slot = "31")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public RVJCLYOAPLX KXNQQKPTVYU
		{
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x8CC53B0", Offset = "0x8CC39B0", VA = "0x188CC53B0", Slot = "29")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public bool NXIOQPKZSPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x8CC4240", Offset = "0x8CC2840", VA = "0x188CC4240", Slot = "32")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public bool RYZUWNDXRMY
		{
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x8CC5690", Offset = "0x8CC3C90", VA = "0x188CC5690", Slot = "33")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public bool TSBYLEBGUPQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x8CC7660", Offset = "0x8CC5C60", VA = "0x188CC7660", Slot = "34")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public GWZOVDSJQAJ ENBNSDCTZAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x8CC24E0", Offset = "0x8CC0AE0", VA = "0x188CC24E0", Slot = "35")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x8CC7B40", Offset = "0x8CC6140", VA = "0x188CC7B40", Slot = "36")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public XTLAQFBHGWM NKUSKFWRICR
		{
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x8CC5A00", Offset = "0x8CC4000", VA = "0x188CC5A00", Slot = "37")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x8CC74D0", Offset = "0x8CC5AD0", VA = "0x188CC74D0", Slot = "38")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public float FPFKHWYFMQX
		{
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x8CC5720", Offset = "0x8CC3D20", VA = "0x188CC5720", Slot = "39")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x8CC67C0", Offset = "0x8CC4DC0", VA = "0x188CC67C0", Slot = "40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public Vector3 GUXZBVKNDMI
		{
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x8CC36F0", Offset = "0x8CC1CF0", VA = "0x188CC36F0", Slot = "41")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x8CC3340", Offset = "0x8CC1940", VA = "0x188CC3340", Slot = "42")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public Vector3 ZNYZYPOGLSI
		{
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x8CC7530", Offset = "0x8CC5B30", VA = "0x188CC7530", Slot = "43")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x8CC43D0", Offset = "0x8CC29D0", VA = "0x188CC43D0", Slot = "44")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public Vector3 MIZTDCUUJAT
		{
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x8CC38C0", Offset = "0x8CC1EC0", VA = "0x188CC38C0", Slot = "45")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x8CC42F0", Offset = "0x8CC28F0", VA = "0x188CC42F0", Slot = "46")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public Vector3 NTQHGGLVDWZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x8CC6F50", Offset = "0x8CC5550", VA = "0x188CC6F50", Slot = "47")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x8CC49A0", Offset = "0x8CC2FA0", VA = "0x188CC49A0", Slot = "48")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public bool KWFBGIOLEIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x8CC5030", Offset = "0x8CC3630", VA = "0x188CC5030", Slot = "49")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public bool EHFCNEEPFCQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x8CC61D0", Offset = "0x8CC47D0", VA = "0x188CC61D0", Slot = "50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public bool KUSDVIFWQSN
		{
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x8CC2BD0", Offset = "0x8CC11D0", VA = "0x188CC2BD0", Slot = "51")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public bool DTONGYNCRVD
		{
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x8CC3C80", Offset = "0x8CC2280", VA = "0x188CC3C80", Slot = "52")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public Vector3 WVDERJFXLHT
		{
			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x8CC6080", Offset = "0x8CC4680", VA = "0x188CC6080", Slot = "53")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public Vector3 UUPZSHGJAQT
		{
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x8CC3480", Offset = "0x8CC1A80", VA = "0x188CC3480", Slot = "54")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public Vector3 JQMBINHTMOX
		{
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x8CC2CB0", Offset = "0x8CC12B0", VA = "0x188CC2CB0", Slot = "55")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x8CC21A0", Offset = "0x8CC07A0", VA = "0x188CC21A0", Slot = "56")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public Vector3 ZNIPXSKVBVK
		{
			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x8CC2630", Offset = "0x8CC0C30", VA = "0x188CC2630", Slot = "57")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public float ZOGHTOAMTPW
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x8CC7CA0", Offset = "0x8CC62A0", VA = "0x188CC7CA0", Slot = "58")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public float NEVEOTWGTWL
		{
			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x8CC1E90", Offset = "0x8CC0490", VA = "0x188CC1E90", Slot = "59")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x8CC7EF0", Offset = "0x8CC64F0", VA = "0x188CC7EF0", Slot = "60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public Vector3 KPNWERTDQVV
		{
			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x8CC2400", Offset = "0x8CC0A00", VA = "0x188CC2400", Slot = "61")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public Quaternion BTMHZDZPTEF
		{
			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x8CC2AA0", Offset = "0x8CC10A0", VA = "0x188CC2AA0", Slot = "62")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public float TFNROOJRIYS
		{
			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x8CC5EF0", Offset = "0x8CC44F0", VA = "0x188CC5EF0", Slot = "64")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x8CC46E0", Offset = "0x8CC2CE0", VA = "0x188CC46E0", Slot = "65")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public float KRJDZBDSTUM
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x8CC4950", Offset = "0x8CC2F50", VA = "0x188CC4950", Slot = "66")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x8CC6760", Offset = "0x8CC4D60", VA = "0x188CC6760", Slot = "67")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public bool UBADDGEUNTB
		{
			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x8CC55E0", Offset = "0x8CC3BE0", VA = "0x188CC55E0", Slot = "68")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x8CC5080", Offset = "0x8CC3680", VA = "0x188CC5080", Slot = "69")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public TransformTrackRate LFJLPSMNURZ
		{
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x8CC4A80", Offset = "0x8CC3080", VA = "0x188CC4A80", Slot = "70")]
			get
			{
				return default(TransformTrackRate);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x8CC6700", Offset = "0x8CC4D00", VA = "0x188CC6700", Slot = "71")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public bool XMOTNJSXNOF
		{
			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x8CC6650", Offset = "0x8CC4C50", VA = "0x188CC6650", Slot = "72")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public Transform MYGXPCYGXQL
		{
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0xBD1290", Offset = "0xBCF890", VA = "0x180BD1290", Slot = "73")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public Vector3 IJHLHASXSDR
		{
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x8CC2530", Offset = "0x8CC0B30", VA = "0x188CC2530", Slot = "74")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x8CC4F30", Offset = "0x8CC3530", VA = "0x188CC4F30", Slot = "75")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public float NDKFOHCPKUB
		{
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x8CC6150", Offset = "0x8CC4750", VA = "0x188CC6150", Slot = "76")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x8CC6D90", Offset = "0x8CC5390", VA = "0x188CC6D90", Slot = "77")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public float LBPVVEIKGNU
		{
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x8CC7C30", Offset = "0x8CC6230", VA = "0x188CC7C30", Slot = "78")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x8CC4BE0", Offset = "0x8CC31E0", VA = "0x188CC4BE0", Slot = "79")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public Quaternion YLZSVHOHRDQ
		{
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x8CC1FC0", Offset = "0x8CC05C0", VA = "0x188CC1FC0", Slot = "80")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x8CC7E10", Offset = "0x8CC6410", VA = "0x188CC7E10", Slot = "81")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public Vector3 RAMBHLEETFC
		{
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x8CC56E0", Offset = "0x8CC3CE0", VA = "0x188CC56E0", Slot = "82")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x8CC5200", Offset = "0x8CC3800", VA = "0x188CC5200", Slot = "83")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public Quaternion VZKKPJCUJMB
		{
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x8CC52A0", Offset = "0x8CC38A0", VA = "0x188CC52A0", Slot = "84")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x8CC1E60", Offset = "0x8CC0460", VA = "0x188CC1E60", Slot = "85")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public RigidbodyConstraints UEXBILMUHCU
		{
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x8CC2A50", Offset = "0x8CC1050", VA = "0x188CC2A50", Slot = "86")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x8CC66A0", Offset = "0x8CC4CA0", VA = "0x188CC66A0", Slot = "87")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public bool OJIQCIDCODR
		{
			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x8CC4FE0", Offset = "0x8CC35E0", VA = "0x188CC4FE0", Slot = "88")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x8CC7DB0", Offset = "0x8CC63B0", VA = "0x188CC7DB0", Slot = "89")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public CollisionDetectionMode IBRRXADKWGA
		{
			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x8CC3B50", Offset = "0x8CC2150", VA = "0x188CC3B50", Slot = "90")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x8CC4740", Offset = "0x8CC2D40", VA = "0x188CC4740", Slot = "91")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public bool DJFFBZGTYVN
		{
			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x8CC35B0", Offset = "0x8CC1BB0", VA = "0x188CC35B0", Slot = "141")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public bool DHOGBUZFGDA
		{
			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0x8CC2280", Offset = "0x8CC0880", VA = "0x188CC2280", Slot = "92")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000017")]
		public event RbexAction XBSNUORLFIY
		{
			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x8CC5630", Offset = "0x8CC3C30", VA = "0x188CC5630", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x8CC69E0", Offset = "0x8CC4FE0", VA = "0x188CC69E0", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000018")]
		public event RbexAction JIJKHZKMUPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x8CC7D50", Offset = "0x8CC6350", VA = "0x188CC7D50", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x8CC7C40", Offset = "0x8CC6240", VA = "0x188CC7C40", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000019")]
		public event RbexParentChangeAction FZIHJZHWBZO
		{
			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x8CC4000", Offset = "0x8CC2600", VA = "0x188CC4000", Slot = "18")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x8CC6020", Offset = "0x8CC4620", VA = "0x188CC6020", Slot = "19")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001A")]
		public event RbexAction LMQTYIKWJBV
		{
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x8CC4680", Offset = "0x8CC2C80", VA = "0x188CC4680", Slot = "8")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x8CC4ED0", Offset = "0x8CC34D0", VA = "0x188CC4ED0", Slot = "9")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001B")]
		public event RbexAction REYSTJINLEW
		{
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x8CC4CE0", Offset = "0x8CC32E0", VA = "0x188CC4CE0", Slot = "14")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x8CC32E0", Offset = "0x8CC18E0", VA = "0x188CC32E0", Slot = "15")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001C")]
		public event RbexAction RLSMFOUTABP
		{
			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x8CC4E70", Offset = "0x8CC3470", VA = "0x188CC4E70", Slot = "16")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x8CC5240", Offset = "0x8CC3840", VA = "0x188CC5240", Slot = "17")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001D")]
		public event Action<UpdateLOD, UpdateLOD> JSASWVDUFKI
		{
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x8CC71D0", Offset = "0x8CC57D0", VA = "0x188CC71D0", Slot = "20")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x8CC5770", Offset = "0x8CC3D70", VA = "0x188CC5770", Slot = "21")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001E")]
		public event RbexAction MMRAAZNVBBN
		{
			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x8CC3180", Offset = "0x8CC1780", VA = "0x188CC3180", Slot = "12")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x8CC7030", Offset = "0x8CC5630", VA = "0x188CC7030", Slot = "13")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001F")]
		public event RbexAction LNDYYFCXCXA
		{
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x8CC7120", Offset = "0x8CC5720", VA = "0x188CC7120", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x8CC7F50", Offset = "0x8CC6550", VA = "0x188CC7F50", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x8CC84D0", Offset = "0x8CC6AD0", VA = "0x188CC84D0")]
		public DUNPNXBIWKA(GameObject a, RigidbodyEx b, TYSHKOYFMJE c, [In] RigidbodyExData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x8CC2E90", Offset = "0x8CC1490", VA = "0x188CC2E90", Slot = "139")]
		protected virtual void DTDAONBWOTC(TYSHKOYFMJE a, RigidbodyExData b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x8CC31E0", Offset = "0x8CC17E0", VA = "0x188CC31E0", Slot = "140")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x8CC2060", Offset = "0x8CC0660", VA = "0x188CC2060", Slot = "93")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x8CC58A0", Offset = "0x8CC3EA0", VA = "0x188CC58A0", Slot = "94")]
		public void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x8CC57F0", Offset = "0x8CC3DF0", VA = "0x188CC57F0", Slot = "95")]
		public void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x8CC57D0", Offset = "0x8CC3DD0", VA = "0x188CC57D0", Slot = "96")]
		public void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x8CC27D0", Offset = "0x8CC0DD0", VA = "0x188CC27D0")]
		private void BYBTTGMUFUQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x8CC41C0", Offset = "0x8CC27C0", VA = "0x188CC41C0")]
		private void HFJGHDNMMQJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x8CC2770", Offset = "0x8CC0D70", VA = "0x188CC2770")]
		private void BVTUYQYDARE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x8CC7770", Offset = "0x8CC5D70", VA = "0x188CC7770", Slot = "30")]
		public RVJCLYOAPLX WGPJQHWBOJY(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x8CC6920", Offset = "0x8CC4F20", VA = "0x188CC6920", Slot = "98")]
		public void SetParent(RVJCLYOAPLX value, bool isPhysicallyDetachedOnly = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x8CC8000", Offset = "0x8CC6600", VA = "0x188CC8000", Slot = "99")]
		public void YSERHPILTAF(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x8CC2B70", Offset = "0x8CC1170", VA = "0x188CC2B70", Slot = "100")]
		public void CLRHTBBQZTW(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x8CC2D90", Offset = "0x8CC1390", VA = "0x188CC2D90", Slot = "101")]
		public Vector3 DNSNNGPNWBB(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x8CC6820", Offset = "0x8CC4E20", VA = "0x188CC6820", Slot = "102")]
		public Vector3 SPLSVTCBSAZ(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x8CC7090", Offset = "0x8CC5690", VA = "0x188CC7090", Slot = "103")]
		public void TZTJZYFQYLU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x8CC42A0", Offset = "0x8CC28A0", VA = "0x188CC42A0", Slot = "104")]
		public void IBMFXXKGQQT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x8CC39A0", Offset = "0x8CC1FA0", VA = "0x188CC39A0", Slot = "105")]
		public void FBWEYOMQCDY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x8CC37D0", Offset = "0x8CC1DD0", VA = "0x188CC37D0", Slot = "106")]
		public void EZGSSGBAMSW(Vector3 a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x8CC82B0", Offset = "0x8CC68B0", VA = "0x188CC82B0", Slot = "107")]
		public void ZBUQCOEYNNB(Vector3 a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x8CC5F40", Offset = "0x8CC4540", VA = "0x188CC5F40", Slot = "108")]
		public void QBLYPYRLXVE(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x8CC4D40", Offset = "0x8CC3340", VA = "0x188CC4D40", Slot = "109")]
		public void KWVASTHJFQE(RbexImpulseType a, Vector3 b, float c, float d = 8f, float e = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x8CC77F0", Offset = "0x8CC5DF0", VA = "0x188CC77F0", Slot = "110")]
		public void WIASDOLUIXD(RbexRotationType a, Vector3 b, float c = 1f / 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x8CC3A40", Offset = "0x8CC2040", VA = "0x188CC3A40", Slot = "111")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void FTIQBIMRMLI(RbexRotationType a, Vector3 b, float c = 7f, float d = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x8CC40C0", Offset = "0x8CC26C0", VA = "0x188CC40C0", Slot = "112")]
		public Vector3 GUDIQEGSVRZ(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x8CC8060", Offset = "0x8CC6660", VA = "0x188CC8060", Slot = "113")]
		public Vector3 YXVODMJIFYF(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x8CC3560", Offset = "0x8CC1B60", VA = "0x188CC3560", Slot = "114")]
		public void ESINSQNCERM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x8CC4E00", Offset = "0x8CC3400", VA = "0x188CC4E00", Slot = "115")]
		public void LCIPSZVQGWY(RVJCLYOAPLX a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x8CC1E00", Offset = "0x8CC0400", VA = "0x188CC1E00", Slot = "116")]
		public void AJWNTRARDIB(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x8CC3F20", Offset = "0x8CC2520", VA = "0x188CC3F20", Slot = "63")]
		public void GIVGAKBJRFB((Quaternion rot, Vector3 moments) tensor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x8CC7610", Offset = "0x8CC5C10", VA = "0x188CC7610", Slot = "117")]
		public void VOLQCZQRAXX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x8CC8480", Offset = "0x8CC6A80", VA = "0x188CC8480", Slot = "118")]
		public void ZYICHSWFPIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x8CC7370", Offset = "0x8CC5970", VA = "0x188CC7370", Slot = "119")]
		public void UXEZXRLAETN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x8CC3CD0", Offset = "0x8CC22D0", VA = "0x188CC3CD0", Slot = "120")]
		public bool GBLVPQIMCEV()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x8CC6990", Offset = "0x8CC4F90", VA = "0x188CC6990", Slot = "97")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x8CC7AD0", Offset = "0x8CC60D0", VA = "0x188CC7AD0", Slot = "121")]
		public void WXNQIESLXQB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x8CC7230", Offset = "0x8CC5830", VA = "0x188CC7230", Slot = "122")]
		public void UQHHDEMYSNC(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x8CC4060", Offset = "0x8CC2660", VA = "0x188CC4060", Slot = "123")]
		public void GNIPAXTFFRH(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x8CC7700", Offset = "0x8CC5D00", VA = "0x188CC7700", Slot = "124")]
		public void WDSUTKKKOXH(object a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x8CC3D20", Offset = "0x8CC2320", VA = "0x188CC3D20", Slot = "125")]
		public void GCZLGOGFKEX(Vector3 a, Quaternion b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x8CC6E20", Offset = "0x8CC5420", VA = "0x188CC6E20", Slot = "126")]
		public void TRLKQMDOURJ(Vector3 a, Quaternion b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x8CC76B0", Offset = "0x8CC5CB0", VA = "0x188CC76B0", Slot = "127")]
		public bool WBTPNXYAYMW(float a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x8CC2710", Offset = "0x8CC0D10", VA = "0x188CC2710", Slot = "128")]
		public void BPBHDMDYFJR(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x8CC3420", Offset = "0x8CC1A20", VA = "0x188CC3420", Slot = "129")]
		public void EKYPSVZFXZK(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x8CC7CF0", Offset = "0x8CC62F0", VA = "0x188CC7CF0", Slot = "130")]
		public void XLEVRRHIHKP(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x8CC44B0", Offset = "0x8CC2AB0", VA = "0x188CC44B0", Slot = "131")]
		public void IWTOHCEWFXU(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x8CC83A0", Offset = "0x8CC69A0", VA = "0x188CC83A0", Slot = "132")]
		public void ZHAAVPZLZNI(Vector3 a, ForceMode b = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x8CC73C0", Offset = "0x8CC59C0", VA = "0x188CC73C0", Slot = "133")]
		public void UZTITFQJZGI(Vector3 a, Vector3 b, ForceMode c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x8CC3BA0", Offset = "0x8CC21A0", VA = "0x188CC3BA0", Slot = "134")]
		public void FUHXARLNTCR(Vector3 a, ForceMode b = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x8CC7290", Offset = "0x8CC5890", VA = "0x188CC7290", Slot = "135")]
		public void UWZTPEUMPYV(Vector3 a, ForceMode b = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x8CC6230", Offset = "0x8CC4830", VA = "0x188CC6230", Slot = "136")]
		public bool RHOKRHCVZQI(Vector3 a, [Out] RaycastHit b, float c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x8CC5850", Offset = "0x8CC3E50", VA = "0x188CC5850", Slot = "137")]
		public void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x8CC70E0", Offset = "0x8CC56E0", VA = "0x188CC70E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x8CC1EE0", Offset = "0x8CC04E0", VA = "0x188CC1EE0")]
		private void ASKDGLAEXRY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x8CC4AD0", Offset = "0x8CC30D0", VA = "0x188CC4AD0")]
		private void KSPLCHJPNCO(RVJCLYOAPLX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x8CC78F0", Offset = "0x8CC5EF0", VA = "0x188CC78F0")]
		private void WUCZFAPAEDX(RVJCLYOAPLX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x8CC5400", Offset = "0x8CC3A00", VA = "0x188CC5400")]
		private void NGARRAACUJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x8CC54B0", Offset = "0x8CC3AB0", VA = "0x188CC54B0")]
		private void NJROCICRLVZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x8CC47A0", Offset = "0x8CC2DA0", VA = "0x188CC47A0")]
		private void KIJLVZSFOXR(RVJCLYOAPLX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x8CC52E0", Offset = "0x8CC38E0", VA = "0x188CC52E0")]
		private void NEATZKLVLVK(RVJCLYOAPLX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x8CC5930", Offset = "0x8CC3F30", VA = "0x188CC5930")]
		private void PFYQNFIMJMA(RVJCLYOAPLX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x8CC8160", Offset = "0x8CC6760", VA = "0x188CC8160")]
		private void YYIXHHHCUGR(RDQYEZMSIPZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x8CC5AB0", Offset = "0x8CC40B0", VA = "0x188CC5AB0", Slot = "142")]
		protected virtual void QALOMIHVJDU(RDQYEZMSIPZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x8CC6330", Offset = "0x8CC4930", VA = "0x188CC6330")]
		protected void RNEGMCBVHFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x8CC6A40", Offset = "0x8CC5040", VA = "0x188CC6A40")]
		protected void TDNMOXGNPMY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x8CC50E0", Offset = "0x8CC36E0", VA = "0x188CC50E0")]
		private void MQGEACKSFVM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x8CC4510", Offset = "0x8CC2B10", VA = "0x188CC4510")]
		private void IXNKKMDTMAH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	internal static class HBTNRCHBQKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x8CCA930", Offset = "0x8CC8F30", VA = "0x188CCA930")]
		public static RVJCLYOAPLX HUSUCJKZDBN(this RVJCLYOAPLX a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x8CCA890", Offset = "0x8CC8E90", VA = "0x188CCA890")]
		public static bool EEEPJFLAPAG(this RVJCLYOAPLX a, RVJCLYOAPLX b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x8CCA770", Offset = "0x8CC8D70", VA = "0x188CCA770")]
		public static bool AQZGEVPJEJS(this RVJCLYOAPLX a, RVJCLYOAPLX b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x8CCA9F0", Offset = "0x8CC8FF0", VA = "0x188CCA9F0")]
		public static RDQYEZMSIPZ KUXQXNJOCMK(this RVJCLYOAPLX a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x8CCA810", Offset = "0x8CC8E10", VA = "0x188CCA810")]
		public static DUNPNXBIWKA Base(this RVJCLYOAPLX impl)
		{
			return null;
		}
	}
}
namespace RecRoom.Rbex.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class HHDBAGOLFKZ : IAEDZMQDMFW
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x8CCAD70", Offset = "0x8CC9370", VA = "0x188CCAD70", Slot = "19")]
		public RVJCLYOAPLX DTVWHLJDNBE(RigidbodyEx a, RigidbodyExData b, TYSHKOYFMJE c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0xAA6860", Offset = "0xAA4E60", VA = "0x180AA6860", Slot = "4")]
		public ZLBHJFTKGJP RYLPHYZXNID(RVJCLYOAPLX a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0xAA6860", Offset = "0xAA4E60", VA = "0x180AA6860", Slot = "5")]
		public SKWLMCVUKGZ GWELHXMHLBJ(RVJCLYOAPLX a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0xAA6860", Offset = "0xAA4E60", VA = "0x180AA6860", Slot = "6")]
		public EHIYEIIUDTM FXUDKMZBEGE(RVJCLYOAPLX a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0xAA6860", Offset = "0xAA4E60", VA = "0x180AA6860", Slot = "7")]
		public TZSCBQPDMZN FYETCDMSZVL(RVJCLYOAPLX a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0xAA6860", Offset = "0xAA4E60", VA = "0x180AA6860", Slot = "8")]
		public RSCFVADDZAV UCQQUUYQFHF(RVJCLYOAPLX a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0xAA6860", Offset = "0xAA4E60", VA = "0x180AA6860", Slot = "9")]
		public BEVDNHVFTHQ KXEGIJZKXTO(RVJCLYOAPLX a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0xAA6860", Offset = "0xAA4E60", VA = "0x180AA6860", Slot = "10")]
		public FKUWDWOVKZZ FBFXCUFUJDP(RVJCLYOAPLX a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0xAA6860", Offset = "0xAA4E60", VA = "0x180AA6860", Slot = "11")]
		public VINEMBIXZEB CJUJDPCUMMX(RVJCLYOAPLX a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0xAA6860", Offset = "0xAA4E60", VA = "0x180AA6860", Slot = "12")]
		public TFZWLFYJYQR OIVILGECYRF(RVJCLYOAPLX a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0xAA6860", Offset = "0xAA4E60", VA = "0x180AA6860", Slot = "13")]
		public MMDDAMPKZMI WTNSYHLZPVE(RVJCLYOAPLX a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0xAA6860", Offset = "0xAA4E60", VA = "0x180AA6860")]
		public BPZLJWRJIWW ATKUHIEHYDW(RVJCLYOAPLX a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0xAA6860", Offset = "0xAA4E60", VA = "0x180AA6860")]
		public RTQKKKCRVPA OXWXIHYQRFS(RVJCLYOAPLX a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0xAA6860", Offset = "0xAA4E60", VA = "0x180AA6860")]
		public ULOOGXWJXJW EAPSJDRQKTE(RVJCLYOAPLX a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0xAA6860", Offset = "0xAA4E60", VA = "0x180AA6860")]
		public FQLHGFIAXKM NZYSIMCPBNE(RVJCLYOAPLX a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0xAA6860", Offset = "0xAA4E60", VA = "0x180AA6860")]
		public USAKKBDPQSE KFPQUPOQGDA(RVJCLYOAPLX a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public HHDBAGOLFKZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0xAA6860", Offset = "0xAA4E60", VA = "0x180AA6860", Slot = "14")]
		private BPZLJWRJIWW INYXVSONDKU(RVJCLYOAPLX a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0xAA6860", Offset = "0xAA4E60", VA = "0x180AA6860", Slot = "15")]
		private RTQKKKCRVPA HXPOPRMWDKI(RVJCLYOAPLX a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0xAA6860", Offset = "0xAA4E60", VA = "0x180AA6860", Slot = "16")]
		private ULOOGXWJXJW TIHOQXWKKQC(RVJCLYOAPLX a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0xAA6860", Offset = "0xAA4E60", VA = "0x180AA6860", Slot = "17")]
		private FQLHGFIAXKM FIJAQEFASAK(RVJCLYOAPLX a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0xAA6860", Offset = "0xAA4E60", VA = "0x180AA6860", Slot = "18")]
		private USAKKBDPQSE EEAVRRERWYG(RVJCLYOAPLX a, [In] RigidbodyExData data)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[RegisterService(typeof(IAEDZMQDMFW), new string[] { })]
	public class EXXZNGVCFYU : IAEDZMQDMFW, UTOILWCTUPI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private readonly IAEDZMQDMFW HQUBRSUKCWD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private readonly IAEDZMQDMFW GEKSRNOPIGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private BTOFDOWGUHY ZKGGQSCWDBX;

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		private IAEDZMQDMFW VONKGWNJIJE
		{
			[Cpp2IlInjected.Token(Token = "0x600021F")]
			[Cpp2IlInjected.Address(RVA = "0x8CC8E90", Offset = "0x8CC7490", VA = "0x188CC8E90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x8CC8DA0", Offset = "0x8CC73A0", VA = "0x188CC8DA0", Slot = "20")]
		public void InitReferences(XRIYJCZWKCD services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x8CC8F90", Offset = "0x8CC7590", VA = "0x188CC8F90", Slot = "4")]
		public ZLBHJFTKGJP RYLPHYZXNID(RVJCLYOAPLX a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x8CC8C50", Offset = "0x8CC7250", VA = "0x188CC8C50", Slot = "5")]
		public SKWLMCVUKGZ GWELHXMHLBJ(RVJCLYOAPLX a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x8CC8B10", Offset = "0x8CC7110", VA = "0x188CC8B10", Slot = "6")]
		public EHIYEIIUDTM FXUDKMZBEGE(RVJCLYOAPLX a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x8CC8BB0", Offset = "0x8CC71B0", VA = "0x188CC8BB0", Slot = "7")]
		public TZSCBQPDMZN FYETCDMSZVL(RVJCLYOAPLX a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x8CC9030", Offset = "0x8CC7630", VA = "0x188CC9030", Slot = "8")]
		public RSCFVADDZAV UCQQUUYQFHF(RVJCLYOAPLX a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x8CC8DF0", Offset = "0x8CC73F0", VA = "0x188CC8DF0", Slot = "9")]
		public BEVDNHVFTHQ KXEGIJZKXTO(RVJCLYOAPLX a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x8CC89C0", Offset = "0x8CC6FC0", VA = "0x188CC89C0", Slot = "10")]
		public FKUWDWOVKZZ FBFXCUFUJDP(RVJCLYOAPLX a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x8CC8670", Offset = "0x8CC6C70", VA = "0x188CC8670", Slot = "11")]
		public VINEMBIXZEB CJUJDPCUMMX(RVJCLYOAPLX a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x8CC8EF0", Offset = "0x8CC74F0", VA = "0x188CC8EF0", Slot = "12")]
		public TFZWLFYJYQR OIVILGECYRF(RVJCLYOAPLX a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x8CC90D0", Offset = "0x8CC76D0", VA = "0x188CC90D0", Slot = "13")]
		public MMDDAMPKZMI WTNSYHLZPVE(RVJCLYOAPLX a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x8CC85C0", Offset = "0x8CC6BC0", VA = "0x188CC85C0")]
		public BPZLJWRJIWW ATKUHIEHYDW(RVJCLYOAPLX a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x8CC8CF0", Offset = "0x8CC72F0", VA = "0x188CC8CF0")]
		public RTQKKKCRVPA OXWXIHYQRFS(RVJCLYOAPLX a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x8CC8860", Offset = "0x8CC6E60", VA = "0x188CC8860")]
		public ULOOGXWJXJW EAPSJDRQKTE(RVJCLYOAPLX a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x8CC8A60", Offset = "0x8CC7060", VA = "0x188CC8A60")]
		public FQLHGFIAXKM NZYSIMCPBNE(RVJCLYOAPLX a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x8CC8910", Offset = "0x8CC6F10", VA = "0x188CC8910")]
		public USAKKBDPQSE KFPQUPOQGDA(RVJCLYOAPLX a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x8CC8710", Offset = "0x8CC6D10", VA = "0x188CC8710", Slot = "19")]
		public RVJCLYOAPLX DTVWHLJDNBE(RigidbodyEx a, RigidbodyExData b, TYSHKOYFMJE c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x8CC9170", Offset = "0x8CC7770", VA = "0x188CC9170")]
		public EXXZNGVCFYU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x8CC85C0", Offset = "0x8CC6BC0", VA = "0x188CC85C0", Slot = "14")]
		private BPZLJWRJIWW INYXVSONDKU(RVJCLYOAPLX a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x8CC8CF0", Offset = "0x8CC72F0", VA = "0x188CC8CF0", Slot = "15")]
		private RTQKKKCRVPA HXPOPRMWDKI(RVJCLYOAPLX a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x8CC8860", Offset = "0x8CC6E60", VA = "0x188CC8860", Slot = "16")]
		private ULOOGXWJXJW TIHOQXWKKQC(RVJCLYOAPLX a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x8CC8A60", Offset = "0x8CC7060", VA = "0x188CC8A60", Slot = "17")]
		private FQLHGFIAXKM FIJAQEFASAK(RVJCLYOAPLX a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x8CC8910", Offset = "0x8CC6F10", VA = "0x188CC8910", Slot = "18")]
		private USAKKBDPQSE EEAVRRERWYG(RVJCLYOAPLX a, [In] RigidbodyExData data)
		{
			return null;
		}
	}
}
namespace RecRoom.Rbex.Legacy
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public interface LDNXXNBSELK : ZLBHJFTKGJP, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void REAOVRDITKT(RVJCLYOAPLX a);

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void MPFOCSTHCIG(RVJCLYOAPLX a);

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void YCEGZWUQJPX(RVJCLYOAPLX a);

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void AQPQZHYDJZC(RVJCLYOAPLX a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public interface JKWYXFDIXCL : EHIYEIIUDTM
	{
		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		QSVINNIMTKL<RVJCLYOAPLX> JZNZDFWHXMS
		{
			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		RVJCLYOAPLX PITGFUSQEUM
		{
			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public interface EKTSVULOVXN : FQLHGFIAXKM
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		(float, Vector3) FUAPTVCCAQK(Rigidbody a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public interface QHLSFNYZQEP : RTQKKKCRVPA, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		RRNetworkView YMIJOQZXKDZ
		{
			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	internal sealed class GQKHELGIGXM : TFZWLFYJYQR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private readonly DUNPNXBIWKA RJCALRJYTQV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private CollisionDetectionMode AIHNCAWXZIW;

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		private Rigidbody VRSPXEIIPIE
		{
			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0x8CCA1F0", Offset = "0x8CC87F0", VA = "0x188CCA1F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		public CollisionDetectionMode IBRRXADKWGA
		{
			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0x8CCA240", Offset = "0x8CC8840", VA = "0x188CCA240", Slot = "4")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0x8CCA350", Offset = "0x8CC8950", VA = "0x188CCA350", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x8CCA6E0", Offset = "0x8CC8CE0", VA = "0x188CCA6E0")]
		public GQKHELGIGXM(RVJCLYOAPLX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x8CCA0E0", Offset = "0x8CC86E0", VA = "0x188CCA0E0", Slot = "6")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x8CCA660", Offset = "0x8CC8C60", VA = "0x188CCA660", Slot = "9")]
		public void ZVKKKTRCJBD(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x8CCA3C0", Offset = "0x8CC89C0", VA = "0x188CCA3C0", Slot = "7")]
		public void POGNEBSJIUU(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x8CCA4F0", Offset = "0x8CC8AF0", VA = "0x188CCA4F0", Slot = "8")]
		public void QNBALZTOJJN(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x8CCA500", Offset = "0x8CC8B00", VA = "0x188CCA500", Slot = "10")]
		public bool RHOKRHCVZQI(Vector3 a, [Out] RaycastHit b, float c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x8CCA3D0", Offset = "0x8CC89D0", VA = "0x188CCA3D0")]
		private void PXZIQQSYXJO(bool a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public sealed class NPFYSJQIHSX : BEVDNHVFTHQ, IDisposable, VUNEHBLTFAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly DUNPNXBIWKA RJCALRJYTQV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private TransformTrackRate XNZICZAGFHR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private JLYTYYSRFKV UCVOQQSHJHV;

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		public TransformTrackRate LFJLPSMNURZ
		{
			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0x8CD04D0", Offset = "0x8CCEAD0", VA = "0x188CD04D0", Slot = "6")]
			get
			{
				return default(TransformTrackRate);
			}
			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0x8CD06D0", Offset = "0x8CCECD0", VA = "0x188CD06D0", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000092")]
		private Transform TVKVIXLWXRC
		{
			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x8CD0850", Offset = "0x8CCEE50", VA = "0x188CD0850", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000020")]
		public event Action<UpdateLOD, UpdateLOD> JSASWVDUFKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0x8CD07A0", Offset = "0x8CCEDA0", VA = "0x188CD07A0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0x8CD0620", Offset = "0x8CCEC20", VA = "0x188CD0620", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x8CD0870", Offset = "0x8CCEE70", VA = "0x188CD0870")]
		public NPFYSJQIHSX(RVJCLYOAPLX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x8CD0210", Offset = "0x8CCE810", VA = "0x188CD0210", Slot = "8")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x8CD0480", Offset = "0x8CCEA80", VA = "0x188CD0480", Slot = "9")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x13FD810", Offset = "0x13FBE10", VA = "0x1813FD810", Slot = "11")]
		private void AYWHULMVISX(UpdateLOD a, UpdateLOD b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "12")]
		private void ZZPQTENAQJV(bool a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class HHDBAGOLFKZ : IAEDZMQDMFW
	{
		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x8CCB820", Offset = "0x8CC9E20", VA = "0x188CCB820", Slot = "4")]
		public ZLBHJFTKGJP RYLPHYZXNID(RVJCLYOAPLX a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x8CCB410", Offset = "0x8CC9A10", VA = "0x188CCB410", Slot = "5")]
		public SKWLMCVUKGZ GWELHXMHLBJ(RVJCLYOAPLX a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x8CCB280", Offset = "0x8CC9880", VA = "0x188CCB280", Slot = "6")]
		public EHIYEIIUDTM FXUDKMZBEGE(RVJCLYOAPLX a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x8CCB3A0", Offset = "0x8CC99A0", VA = "0x188CCB3A0", Slot = "7")]
		public TZSCBQPDMZN FYETCDMSZVL(RVJCLYOAPLX a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x8CCB900", Offset = "0x8CC9F00", VA = "0x188CCB900", Slot = "8")]
		public RSCFVADDZAV UCQQUUYQFHF(RVJCLYOAPLX a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x8CCB6A0", Offset = "0x8CC9CA0", VA = "0x188CCB6A0", Slot = "9")]
		public BEVDNHVFTHQ KXEGIJZKXTO(RVJCLYOAPLX a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x8CCAFF0", Offset = "0x8CC95F0", VA = "0x188CCAFF0", Slot = "10")]
		public FKUWDWOVKZZ FBFXCUFUJDP(RVJCLYOAPLX a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x8CCAB70", Offset = "0x8CC9170", VA = "0x188CCAB70", Slot = "11")]
		public VINEMBIXZEB CJUJDPCUMMX(RVJCLYOAPLX a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x8CCB760", Offset = "0x8CC9D60", VA = "0x188CCB760", Slot = "12")]
		public TFZWLFYJYQR OIVILGECYRF(RVJCLYOAPLX a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x8CCB9C0", Offset = "0x8CC9FC0", VA = "0x188CCB9C0", Slot = "13")]
		public MMDDAMPKZMI WTNSYHLZPVE(RVJCLYOAPLX a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x8CCAA40", Offset = "0x8CC9040", VA = "0x188CCAA40")]
		public BPZLJWRJIWW ATKUHIEHYDW(RVJCLYOAPLX a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x8CCB520", Offset = "0x8CC9B20", VA = "0x188CCB520")]
		public RTQKKKCRVPA OXWXIHYQRFS(RVJCLYOAPLX a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x8CCAE00", Offset = "0x8CC9400", VA = "0x188CCAE00")]
		public ULOOGXWJXJW EAPSJDRQKTE(RVJCLYOAPLX a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x8CCB100", Offset = "0x8CC9700", VA = "0x188CCB100")]
		public FQLHGFIAXKM NZYSIMCPBNE(RVJCLYOAPLX a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x8CCAF20", Offset = "0x8CC9520", VA = "0x188CCAF20")]
		public USAKKBDPQSE KFPQUPOQGDA(RVJCLYOAPLX a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x8CCAC30", Offset = "0x8CC9230", VA = "0x188CCAC30", Slot = "19")]
		public RVJCLYOAPLX DTVWHLJDNBE(RigidbodyEx a, RigidbodyExData b, TYSHKOYFMJE c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public HHDBAGOLFKZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x8CCAA40", Offset = "0x8CC9040", VA = "0x188CCAA40", Slot = "14")]
		private BPZLJWRJIWW INYXVSONDKU(RVJCLYOAPLX a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x8CCB520", Offset = "0x8CC9B20", VA = "0x188CCB520", Slot = "15")]
		private RTQKKKCRVPA HXPOPRMWDKI(RVJCLYOAPLX a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x8CCAE00", Offset = "0x8CC9400", VA = "0x188CCAE00", Slot = "16")]
		private ULOOGXWJXJW TIHOQXWKKQC(RVJCLYOAPLX a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x8CCB100", Offset = "0x8CC9700", VA = "0x188CCB100", Slot = "17")]
		private FQLHGFIAXKM FIJAQEFASAK(RVJCLYOAPLX a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x8CCAF20", Offset = "0x8CC9520", VA = "0x188CCAF20", Slot = "18")]
		private USAKKBDPQSE EEAVRRERWYG(RVJCLYOAPLX a, [In] RigidbodyExData data)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal sealed class USGLUIGPCYA : VINEMBIXZEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private readonly DUNPNXBIWKA RJCALRJYTQV;

		[Cpp2IlInjected.Token(Token = "0x17000093")]
		private Rigidbody VRSPXEIIPIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000268")]
			[Cpp2IlInjected.Address(RVA = "0x8CCA1F0", Offset = "0x8CC87F0", VA = "0x188CCA1F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000094")]
		private bool XMOTNJSXNOF
		{
			[Cpp2IlInjected.Token(Token = "0x6000269")]
			[Cpp2IlInjected.Address(RVA = "0x8CD8690", Offset = "0x8CD6C90", VA = "0x188CD8690")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000095")]
		private bool NXIOQPKZSPK
		{
			[Cpp2IlInjected.Token(Token = "0x600026A")]
			[Cpp2IlInjected.Address(RVA = "0x8CC9D30", Offset = "0x8CC8330", VA = "0x188CC9D30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000096")]
		private RVJCLYOAPLX VTVCVRULVZC
		{
			[Cpp2IlInjected.Token(Token = "0x600026B")]
			[Cpp2IlInjected.Address(RVA = "0x8CD84D0", Offset = "0x8CD6AD0", VA = "0x188CD84D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x8CCA6E0", Offset = "0x8CC8CE0", VA = "0x188CCA6E0")]
		public USGLUIGPCYA(RVJCLYOAPLX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x8CD8E20", Offset = "0x8CD7420", VA = "0x188CD8E20", Slot = "4")]
		public void ZHAAVPZLZNI(Vector3 a, ForceMode b = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x8CD8BC0", Offset = "0x8CD71C0", VA = "0x188CD8BC0")]
		private void WVKXOUQBNZH(Vector3 a, ForceMode b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x8CD8940", Offset = "0x8CD6F40", VA = "0x188CD8940", Slot = "5")]
		public void UZTITFQJZGI(Vector3 a, Vector3 b, ForceMode c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x8CD8530", Offset = "0x8CD6B30", VA = "0x188CD8530", Slot = "6")]
		public void FUHXARLNTCR(Vector3 a, ForceMode b = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x8CD8270", Offset = "0x8CD6870", VA = "0x188CD8270")]
		private void BBTVSBBYAMU(Vector3 a, ForceMode b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x8CD86E0", Offset = "0x8CD6CE0", VA = "0x188CD86E0", Slot = "7")]
		public void UWZTPEUMPYV(Vector3 a, ForceMode b = ForceMode.Force)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	internal sealed class WGGYBZUMONH : MMDDAMPKZMI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private readonly DUNPNXBIWKA RJCALRJYTQV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private bool JLCWORLMOFZ;

		[Cpp2IlInjected.Token(Token = "0x17000097")]
		public bool UBADDGEUNTB
		{
			[Cpp2IlInjected.Token(Token = "0x6000274")]
			[Cpp2IlInjected.Address(RVA = "0xB90C00", Offset = "0xB8F200", VA = "0x180B90C00", Slot = "4")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000275")]
			[Cpp2IlInjected.Address(RVA = "0x8CD8FF0", Offset = "0x8CD75F0", VA = "0x188CD8FF0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x8CCA6E0", Offset = "0x8CC8CE0", VA = "0x188CCA6E0")]
		public WGGYBZUMONH(RVJCLYOAPLX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x8CD9100", Offset = "0x8CD7700", VA = "0x188CD9100", Slot = "6")]
		public void ZVKKKTRCJBD(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x8CD8F80", Offset = "0x8CD7580", VA = "0x188CD8F80", Slot = "7")]
		public void AOKHSYMWGWW(Rigidbody a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	internal sealed class RbexHierarchy : LDNXXNBSELK, ZLBHJFTKGJP, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private readonly RVJCLYOAPLX RJCALRJYTQV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private readonly List<RVJCLYOAPLX> JTMQUOASIIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private RVJCLYOAPLX UPYDKJXZEYI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private RVJCLYOAPLX SEJYAKTRJIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private Transform RVXUNDYBEXB;

		[Cpp2IlInjected.Token(Token = "0x17000098")]
		private Transform HBZICNJLAVK
		{
			[Cpp2IlInjected.Token(Token = "0x600028A")]
			[Cpp2IlInjected.Address(RVA = "0x8CD2330", Offset = "0x8CD0930", VA = "0x188CD2330")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000099")]
		public RVJCLYOAPLX VTVCVRULVZC
		{
			[Cpp2IlInjected.Token(Token = "0x600028D")]
			[Cpp2IlInjected.Address(RVA = "0xAACA90", Offset = "0xAAB090", VA = "0x180AACA90", Slot = "28")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600028E")]
			[Cpp2IlInjected.Address(RVA = "0x8CD17C0", Offset = "0x8CCFDC0", VA = "0x188CD17C0", Slot = "29")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009A")]
		public RVJCLYOAPLX KXNQQKPTVYU
		{
			[Cpp2IlInjected.Token(Token = "0x600028F")]
			[Cpp2IlInjected.Address(RVA = "0xAACA50", Offset = "0xAAB050", VA = "0x180AACA50", Slot = "27")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		public IReadOnlyList<RVJCLYOAPLX> PPZATSLBMJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000290")]
			[Cpp2IlInjected.Address(RVA = "0xAACD50", Offset = "0xAAB350", VA = "0x180AACD50", Slot = "26")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000021")]
		public event RbexAction XBSNUORLFIY
		{
			[Cpp2IlInjected.Token(Token = "0x6000278")]
			[Cpp2IlInjected.Address(RVA = "0x8CD1680", Offset = "0x8CCFC80", VA = "0x188CD1680", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000279")]
			[Cpp2IlInjected.Address(RVA = "0x8CD20B0", Offset = "0x8CD06B0", VA = "0x188CD20B0", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000022")]
		public event RbexAction JIJKHZKMUPE
		{
			[Cpp2IlInjected.Token(Token = "0x600027A")]
			[Cpp2IlInjected.Address(RVA = "0x8CD24D0", Offset = "0x8CD0AD0", VA = "0x188CD24D0", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600027B")]
			[Cpp2IlInjected.Address(RVA = "0x8CD2430", Offset = "0x8CD0A30", VA = "0x188CD2430", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000023")]
		public event RbexParentChangeAction FZIHJZHWBZO
		{
			[Cpp2IlInjected.Token(Token = "0x600027C")]
			[Cpp2IlInjected.Address(RVA = "0x8CD1220", Offset = "0x8CCF820", VA = "0x188CD1220", Slot = "12")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600027D")]
			[Cpp2IlInjected.Address(RVA = "0x8CD1870", Offset = "0x8CCFE70", VA = "0x188CD1870", Slot = "13")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000024")]
		public event Action LBHWJZRNHKZ
		{
			[Cpp2IlInjected.Token(Token = "0x600027E")]
			[Cpp2IlInjected.Address(RVA = "0x8CD17D0", Offset = "0x8CCFDD0", VA = "0x188CD17D0", Slot = "14")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600027F")]
			[Cpp2IlInjected.Address(RVA = "0x8CD2290", Offset = "0x8CD0890", VA = "0x188CD2290", Slot = "15")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000025")]
		public event Action ATFGYMTCMUW
		{
			[Cpp2IlInjected.Token(Token = "0x6000280")]
			[Cpp2IlInjected.Address(RVA = "0x8CD1720", Offset = "0x8CCFD20", VA = "0x188CD1720", Slot = "16")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000281")]
			[Cpp2IlInjected.Address(RVA = "0x8CD1AA0", Offset = "0x8CD00A0", VA = "0x188CD1AA0", Slot = "17")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000026")]
		public event Action<RVJCLYOAPLX> ZLLLFLTOJJN
		{
			[Cpp2IlInjected.Token(Token = "0x6000282")]
			[Cpp2IlInjected.Address(RVA = "0x8CD0DF0", Offset = "0x8CCF3F0", VA = "0x188CD0DF0", Slot = "18")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000283")]
			[Cpp2IlInjected.Address(RVA = "0x8CD27E0", Offset = "0x8CD0DE0", VA = "0x188CD27E0", Slot = "19")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000027")]
		public event Action<RVJCLYOAPLX> ZXXSJADUXBW
		{
			[Cpp2IlInjected.Token(Token = "0x6000284")]
			[Cpp2IlInjected.Address(RVA = "0x8CD0F80", Offset = "0x8CCF580", VA = "0x188CD0F80", Slot = "20")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000285")]
			[Cpp2IlInjected.Address(RVA = "0x8CD1480", Offset = "0x8CCFA80", VA = "0x188CD1480", Slot = "21")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000028")]
		public event Action XCDZFYSGCJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000286")]
			[Cpp2IlInjected.Address(RVA = "0x8CD13E0", Offset = "0x8CCF9E0", VA = "0x188CD13E0", Slot = "22")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000287")]
			[Cpp2IlInjected.Address(RVA = "0x8CD2390", Offset = "0x8CD0990", VA = "0x188CD2390", Slot = "23")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000029")]
		public event Action<RVJCLYOAPLX> JXMPDXCRXBW
		{
			[Cpp2IlInjected.Token(Token = "0x6000288")]
			[Cpp2IlInjected.Address(RVA = "0x8CD1530", Offset = "0x8CCFB30", VA = "0x188CD1530", Slot = "24")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000289")]
			[Cpp2IlInjected.Address(RVA = "0x8CD0AC0", Offset = "0x8CCF0C0", VA = "0x188CD0AC0", Slot = "25")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x8CD2890", Offset = "0x8CD0E90", VA = "0x188CD2890")]
		public RbexHierarchy(RVJCLYOAPLX rbex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x8CD0EE0", Offset = "0x8CCF4E0", VA = "0x188CD0EE0", Slot = "31")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x8CD1B40", Offset = "0x8CD0140", VA = "0x188CD1B40", Slot = "30")]
		public void SetParent(RVJCLYOAPLX newParent, bool isPhysicallyDetachedOnly = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x8CD2570", Offset = "0x8CD0B70", VA = "0x188CD2570", Slot = "6")]
		public void YCEGZWUQJPX(RVJCLYOAPLX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x8CD0B70", Offset = "0x8CCF170", VA = "0x188CD0B70", Slot = "7")]
		public void AQPQZHYDJZC(RVJCLYOAPLX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x8CD1910", Offset = "0x8CCFF10", VA = "0x188CD1910", Slot = "4")]
		public void REAOVRDITKT(RVJCLYOAPLX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x8CD15E0", Offset = "0x8CCFBE0", VA = "0x188CD15E0", Slot = "5")]
		public void MPFOCSTHCIG(RVJCLYOAPLX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x8CD1A00", Offset = "0x8CD0000", VA = "0x188CD1A00")]
		private void RJNJZGGXMHT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x8CD0EA0", Offset = "0x8CCF4A0", VA = "0x188CD0EA0")]
		private void DPFDOAQEDQU(RVJCLYOAPLX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x8CD2150", Offset = "0x8CD0750", VA = "0x188CD2150")]
		private void ULUVTSYOFQZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x8CD1030", Offset = "0x8CCF630", VA = "0x188CD1030")]
		private void GKOCTYBZYAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x8CD12C0", Offset = "0x8CCF8C0", VA = "0x188CD12C0")]
		private void IBBSRTTXWXA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x8CD1160", Offset = "0x8CCF760", VA = "0x188CD1160")]
		[CompilerGenerated]
		private object GKSBGHYUOOU()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	internal static class SIZFXMEBCTA
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x8CD81B0", Offset = "0x8CD67B0", VA = "0x188CD81B0")]
		public static LDNXXNBSELK FSUFSPBZXFF(this RVJCLYOAPLX a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	internal sealed class NEGOWHOAMBF : JKWYXFDIXCL, EHIYEIIUDTM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly DUNPNXBIWKA RJCALRJYTQV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private readonly QSVINNIMTKL<RVJCLYOAPLX> DOHRUEDQWJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private bool NLTCKNEYFFB;

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		public QSVINNIMTKL<RVJCLYOAPLX> JZNZDFWHXMS
		{
			[Cpp2IlInjected.Token(Token = "0x600029D")]
			[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		public Vector3 WVDERJFXLHT
		{
			[Cpp2IlInjected.Token(Token = "0x600029E")]
			[Cpp2IlInjected.Address(RVA = "0x8CCECD0", Offset = "0x8CCD2D0", VA = "0x188CCECD0", Slot = "6")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		public Vector3 UUPZSHGJAQT
		{
			[Cpp2IlInjected.Token(Token = "0x600029F")]
			[Cpp2IlInjected.Address(RVA = "0x8CCE8F0", Offset = "0x8CCCEF0", VA = "0x188CCE8F0", Slot = "7")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		private Vector3 MIZTDCUUJAT
		{
			[Cpp2IlInjected.Token(Token = "0x60002A3")]
			[Cpp2IlInjected.Address(RVA = "0x8CCEBF0", Offset = "0x8CCD1F0", VA = "0x188CCEBF0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		public RVJCLYOAPLX PITGFUSQEUM
		{
			[Cpp2IlInjected.Token(Token = "0x60002A4")]
			[Cpp2IlInjected.Address(RVA = "0x8CCE7D0", Offset = "0x8CCCDD0", VA = "0x188CCE7D0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x8CCF440", Offset = "0x8CCDA40", VA = "0x188CCF440")]
		public NEGOWHOAMBF(RVJCLYOAPLX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x8CCE880", Offset = "0x8CCCE80", VA = "0x188CCE880", Slot = "8")]
		public void EEKULKBKTJF(RVJCLYOAPLX a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x8CCE770", Offset = "0x8CCCD70", VA = "0x188CCE770", Slot = "9")]
		public void DFJXMEPCRRC(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x8CCED00", Offset = "0x8CCD300", VA = "0x188CCED00")]
		private Vector3 SDOOUSVMSHT()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x8CCF0A0", Offset = "0x8CCD6A0", VA = "0x188CCF0A0")]
		private void WCWQZLLZMVU(RVJCLYOAPLX a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	internal static class FEZLBIWDFRL
	{
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x8CC94E0", Offset = "0x8CC7AE0", VA = "0x188CC94E0")]
		public static JKWYXFDIXCL LCFYYHLTDKU(this RVJCLYOAPLX a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	internal sealed class KBASWAISGQL : EKTSVULOVXN, FQLHGFIAXKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private readonly DUNPNXBIWKA RJCALRJYTQV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private readonly OverridableVector3 RKEZBLUHUGS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private readonly OverridableVector3 UWKNUXICHFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private float UVTXKJXGLOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private float LGMRODGTAIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private Vector3 YCVFJFISDCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private Vector3? JDXMOLBEQZF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private Quaternion? EMSBALTHREN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private bool WWRJEGPDPEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private bool YDQEQWBMHNT;

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		public Vector3 JQMBINHTMOX
		{
			[Cpp2IlInjected.Token(Token = "0x60002AA")]
			[Cpp2IlInjected.Address(RVA = "0x1F9D8F0", Offset = "0x1F9BEF0", VA = "0x181F9D8F0", Slot = "7")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60002AB")]
			[Cpp2IlInjected.Address(RVA = "0x8CCBF60", Offset = "0x8CCA560", VA = "0x188CCBF60", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		public Vector3 ZNIPXSKVBVK
		{
			[Cpp2IlInjected.Token(Token = "0x60002AC")]
			[Cpp2IlInjected.Address(RVA = "0x8CCC1A0", Offset = "0x8CCA7A0", VA = "0x188CCC1A0", Slot = "9")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		public float ZOGHTOAMTPW
		{
			[Cpp2IlInjected.Token(Token = "0x60002AD")]
			[Cpp2IlInjected.Address(RVA = "0xAF6B20", Offset = "0xAF5120", VA = "0x180AF6B20", Slot = "10")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60002AE")]
			[Cpp2IlInjected.Address(RVA = "0x8CCBC70", Offset = "0x8CCA270", VA = "0x188CCBC70")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A4")]
		public float NEVEOTWGTWL
		{
			[Cpp2IlInjected.Token(Token = "0x60002AF")]
			[Cpp2IlInjected.Address(RVA = "0xAF6B30", Offset = "0xAF5130", VA = "0x180AF6B30", Slot = "11")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60002B0")]
			[Cpp2IlInjected.Address(RVA = "0x8CCDF20", Offset = "0x8CCC520", VA = "0x188CCDF20", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		public Vector3 KPNWERTDQVV
		{
			[Cpp2IlInjected.Token(Token = "0x60002B1")]
			[Cpp2IlInjected.Address(RVA = "0x8CCC010", Offset = "0x8CCA610", VA = "0x188CCC010", Slot = "13")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A6")]
		public Quaternion BTMHZDZPTEF
		{
			[Cpp2IlInjected.Token(Token = "0x60002B2")]
			[Cpp2IlInjected.Address(RVA = "0x8CCC2C0", Offset = "0x8CCA8C0", VA = "0x188CCC2C0", Slot = "14")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A7")]
		private Rigidbody VRSPXEIIPIE
		{
			[Cpp2IlInjected.Token(Token = "0x60002BA")]
			[Cpp2IlInjected.Address(RVA = "0x8CC1480", Offset = "0x8CBFA80", VA = "0x188CC1480")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400002A")]
		public event RbexAction JSNYKKROGOC
		{
			[Cpp2IlInjected.Token(Token = "0x60002A8")]
			[Cpp2IlInjected.Address(RVA = "0x8CCDD00", Offset = "0x8CCC300", VA = "0x188CCDD00", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60002A9")]
			[Cpp2IlInjected.Address(RVA = "0x8CCD680", Offset = "0x8CCBC80", VA = "0x188CCD680", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x8CCE450", Offset = "0x8CCCA50", VA = "0x188CCE450")]
		public KBASWAISGQL(RVJCLYOAPLX a, [In] RigidbodyExData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x8CCE170", Offset = "0x8CCC770", VA = "0x188CCE170", Slot = "17")]
		public void VOLQCZQRAXX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x8CCE370", Offset = "0x8CCC970", VA = "0x188CCE370", Slot = "16")]
		public void ZYICHSWFPIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x8CCE290", Offset = "0x8CCC890", VA = "0x188CCE290", Slot = "19")]
		public void ZVKKKTRCJBD(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x8CCBD80", Offset = "0x8CCA380", VA = "0x188CCBD80", Slot = "20")]
		public void AOKHSYMWGWW(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x8CCDFD0", Offset = "0x8CCC5D0", VA = "0x188CCDFD0", Slot = "18")]
		public void UXEZXRLAETN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x8CCD840", Offset = "0x8CCBE40", VA = "0x188CCD840", Slot = "21")]
		public void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x8CCBF60", Offset = "0x8CCA560", VA = "0x188CCBF60")]
		private void ULXWENTOBTJ(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x8CCD720", Offset = "0x8CCBD20", VA = "0x188CCD720")]
		[Obsolete("This method is dangerous - the unity rigidbody is updated in a deferred manner and this world position may be stale")]
		private Vector3 LTIODYKCYOY()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x8CCBC70", Offset = "0x8CCA270", VA = "0x188CCBC70")]
		private void ADYZTIADLTW(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x8CCDF20", Offset = "0x8CCC520", VA = "0x188CCDF20")]
		private void UMMVYOUZIVZ(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x8CCD4E0", Offset = "0x8CCBAE0", VA = "0x188CCD4E0")]
		private Vector3 HDNRAXITAGX()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x8CCD2B0", Offset = "0x8CCB8B0", VA = "0x188CCD2B0", Slot = "15")]
		public void GIVGAKBJRFB((Quaternion rot, Vector3 moments) tensor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x8CCDDA0", Offset = "0x8CCC3A0", VA = "0x188CCDDA0")]
		private Quaternion RICSACBUTFH()
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x8CCC440", Offset = "0x8CCAA40", VA = "0x188CCC440")]
		public void FUAPTVCCAQK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x8CCC510", Offset = "0x8CCAB10", VA = "0x188CCC510", Slot = "4")]
		public (float, Vector3) FUAPTVCCAQK(Rigidbody a)
		{
			return default((float, Vector3));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	internal static class HTMQRCHPZDL
	{
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x8CCBA80", Offset = "0x8CCA080", VA = "0x188CCBA80")]
		public static EKTSVULOVXN RWITBUVZGJE(this RVJCLYOAPLX a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	internal sealed class XMIMXHAVLSJ : ULOOGXWJXJW
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private readonly DUNPNXBIWKA RJCALRJYTQV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private readonly ZCBRZWUWSEW RXJNBQGNIGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private readonly RbexInterpolationMode CYHLTEGJCHD;

		[Cpp2IlInjected.Token(Token = "0x170000A8")]
		public bool BZWZMAMLBKJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002C5")]
			[Cpp2IlInjected.Address(RVA = "0x1B4C3A0", Offset = "0x1B4A9A0", VA = "0x181B4C3A0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A9")]
		public RbexInterpolationMode YEYCFIUEXSL
		{
			[Cpp2IlInjected.Token(Token = "0x60002C6")]
			[Cpp2IlInjected.Address(RVA = "0xAB7670", Offset = "0xAB5C70", VA = "0x180AB7670", Slot = "11")]
			get
			{
				return default(RbexInterpolationMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x8CD9740", Offset = "0x8CD7D40", VA = "0x188CD9740")]
		public XMIMXHAVLSJ(RVJCLYOAPLX a, [In] RigidbodyExData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x8CD9130", Offset = "0x8CD7730", VA = "0x188CD9130", Slot = "4")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x8CD9200", Offset = "0x8CD7800", VA = "0x188CD9200")]
		private bool CVBZGASVTCB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x8CD9420", Offset = "0x8CD7A20", VA = "0x188CD9420", Slot = "5")]
		public void FFGILZADZJJ(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x8CD9560", Offset = "0x8CD7B60", VA = "0x188CD9560", Slot = "6")]
		public void IQHCJXUOCSS(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x8CD9590", Offset = "0x8CD7B90", VA = "0x188CD9590", Slot = "9")]
		public void KYIYECYQYNQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x8CD9450", Offset = "0x8CD7A50", VA = "0x188CD9450")]
		private void FTRWXEYSFMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x8CD92A0", Offset = "0x8CD78A0", VA = "0x188CD92A0")]
		private void ERZWTDJTYXL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x8CD9700", Offset = "0x8CD7D00", VA = "0x188CD9700", Slot = "8")]
		public void TQBEPDBTRSZ(RVJCLYOAPLX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x8CD96C0", Offset = "0x8CD7CC0", VA = "0x188CD96C0", Slot = "7")]
		public void LNKQUMKXDWG(RVJCLYOAPLX a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	internal sealed class ZUURDHODTQG : FKUWDWOVKZZ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private readonly DUNPNXBIWKA RJCALRJYTQV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private readonly ZCBRZWUWSEW FZRGTZAGRMT;

		[Cpp2IlInjected.Token(Token = "0x170000AA")]
		public bool XMOTNJSXNOF
		{
			[Cpp2IlInjected.Token(Token = "0x60002D3")]
			[Cpp2IlInjected.Address(RVA = "0x8CD9910", Offset = "0x8CD7F10", VA = "0x188CD9910", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400002B")]
		public event RbexAction MMRAAZNVBBN
		{
			[Cpp2IlInjected.Token(Token = "0x60002D1")]
			[Cpp2IlInjected.Address(RVA = "0x8CD9860", Offset = "0x8CD7E60", VA = "0x188CD9860", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60002D2")]
			[Cpp2IlInjected.Address(RVA = "0x8CD99C0", Offset = "0x8CD7FC0", VA = "0x188CD99C0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x8CD9C40", Offset = "0x8CD8240", VA = "0x188CD9C40")]
		public ZUURDHODTQG(RVJCLYOAPLX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x8CD9A60", Offset = "0x8CD8060", VA = "0x188CD9A60", Slot = "7")]
		public void UQHHDEMYSNC(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x8CD9900", Offset = "0x8CD7F00", VA = "0x188CD9900", Slot = "8")]
		public void GNIPAXTFFRH(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x8CD9A70", Offset = "0x8CD8070", VA = "0x188CD9A70", Slot = "9")]
		public void WDSUTKKKOXH(object a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x8CD9B80", Offset = "0x8CD8180", VA = "0x188CD9B80", Slot = "12")]
		public void XBTYTTONDXZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x8CD9BC0", Offset = "0x8CD81C0", VA = "0x188CD9BC0", Slot = "10")]
		public void ZVKKKTRCJBD(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x8CD9830", Offset = "0x8CD7E30", VA = "0x188CD9830", Slot = "11")]
		public void AOKHSYMWGWW(Rigidbody a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	internal sealed class NOLIQZXQWVR : QHLSFNYZQEP, RTQKKKCRVPA, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private readonly DUNPNXBIWKA RJCALRJYTQV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private RRNetworkView UBOIQWABRMT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private bool ZIBDHCGCWMG;

		[Cpp2IlInjected.Token(Token = "0x170000AB")]
		public RRNetworkView YMIJOQZXKDZ
		{
			[Cpp2IlInjected.Token(Token = "0x60002DD")]
			[Cpp2IlInjected.Address(RVA = "0xAA7750", Offset = "0xAA5D50", VA = "0x180AA7750", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AC")]
		public bool RYZUWNDXRMY
		{
			[Cpp2IlInjected.Token(Token = "0x60002DE")]
			[Cpp2IlInjected.Address(RVA = "0x8CCFDC0", Offset = "0x8CCE3C0", VA = "0x188CCFDC0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AD")]
		public bool TSBYLEBGUPQ
		{
			[Cpp2IlInjected.Token(Token = "0x60002DF")]
			[Cpp2IlInjected.Address(RVA = "0xCB5800", Offset = "0xCB3E00", VA = "0x180CB5800", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400002C")]
		public event RbexAction LMQTYIKWJBV
		{
			[Cpp2IlInjected.Token(Token = "0x60002DB")]
			[Cpp2IlInjected.Address(RVA = "0x8CCF8A0", Offset = "0x8CCDEA0", VA = "0x188CCF8A0", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60002DC")]
			[Cpp2IlInjected.Address(RVA = "0x8CCF940", Offset = "0x8CCDF40", VA = "0x188CCF940", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x8CD00B0", Offset = "0x8CCE6B0", VA = "0x188CD00B0")]
		public NOLIQZXQWVR(RVJCLYOAPLX a, [In] RigidbodyExData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x8CCF530", Offset = "0x8CCDB30", VA = "0x188CCF530", Slot = "9")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x8CCF660", Offset = "0x8CCDC60", VA = "0x188CCF660", Slot = "12")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x8CCF9E0", Offset = "0x8CCDFE0", VA = "0x188CCF9E0", Slot = "10")]
		public void NEATZKLVLVK(RVJCLYOAPLX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x8CCFDD0", Offset = "0x8CCE3D0", VA = "0x188CCFDD0", Slot = "11")]
		public void PFYQNFIMJMA(RVJCLYOAPLX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x8CCFF40", Offset = "0x8CCE540", VA = "0x188CCFF40")]
		private void WFODRPIUYQM(RRNetworkView a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x8CCF750", Offset = "0x8CCDD50", VA = "0x188CCF750")]
		private void IDYBBMCVRKA(RDQYEZMSIPZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x8CCFB50", Offset = "0x8CCE150", VA = "0x188CCFB50")]
		private void NFPPUCNKHGN(RRNetworkView a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	internal static class KOUNWMSXPXT
	{
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x8CCE5B0", Offset = "0x8CCCBB0", VA = "0x188CCE5B0")]
		public static QHLSFNYZQEP Lifecycle(this RVJCLYOAPLX impl)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	internal sealed class GDBJYQHEMED : USAKKBDPQSE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private readonly DUNPNXBIWKA RJCALRJYTQV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private RigidbodyConstraints UEMMTZWHGLW;

		[Cpp2IlInjected.Token(Token = "0x170000AE")]
		public bool OJIQCIDCODR
		{
			[Cpp2IlInjected.Token(Token = "0x60002E9")]
			[Cpp2IlInjected.Address(RVA = "0xBDF360", Offset = "0xBDD960", VA = "0x180BDF360", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002EA")]
			[Cpp2IlInjected.Address(RVA = "0xF38CA0", Offset = "0xF372A0", VA = "0x180F38CA0", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AF")]
		public bool OSCFERLNNOW
		{
			[Cpp2IlInjected.Token(Token = "0x60002EB")]
			[Cpp2IlInjected.Address(RVA = "0xBDF3B0", Offset = "0xBDD9B0", VA = "0x180BDF3B0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002EC")]
			[Cpp2IlInjected.Address(RVA = "0xF383D0", Offset = "0xF369D0", VA = "0x180F383D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B0")]
		public RigidbodyConstraints UEXBILMUHCU
		{
			[Cpp2IlInjected.Token(Token = "0x60002ED")]
			[Cpp2IlInjected.Address(RVA = "0xAAA9D0", Offset = "0xAA8FD0", VA = "0x180AAA9D0", Slot = "7")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x60002EE")]
			[Cpp2IlInjected.Address(RVA = "0x8CC95D0", Offset = "0x8CC7BD0", VA = "0x188CC95D0", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x8CC9730", Offset = "0x8CC7D30", VA = "0x188CC9730")]
		public GDBJYQHEMED(RVJCLYOAPLX a, [In] RigidbodyExData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x8CC9700", Offset = "0x8CC7D00", VA = "0x188CC9700", Slot = "9")]
		public void ZVKKKTRCJBD(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x8CC95A0", Offset = "0x8CC7BA0", VA = "0x188CC95A0", Slot = "10")]
		public void AOKHSYMWGWW(Rigidbody a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	internal sealed class EYBUOBGKESI : TZSCBQPDMZN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private readonly RVJCLYOAPLX RJCALRJYTQV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private float CXYEINRWRYG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private float VGZTVEKWMHK;

		[Cpp2IlInjected.Token(Token = "0x170000B1")]
		public float TFNROOJRIYS
		{
			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0xAFB3D0", Offset = "0xAF99D0", VA = "0x180AFB3D0", Slot = "4")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60002F4")]
			[Cpp2IlInjected.Address(RVA = "0x8CC92B0", Offset = "0x8CC78B0", VA = "0x188CC92B0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B2")]
		public float KRJDZBDSTUM
		{
			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0xAFB310", Offset = "0xAF9910", VA = "0x180AFB310", Slot = "6")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60002F6")]
			[Cpp2IlInjected.Address(RVA = "0x8CC9380", Offset = "0x8CC7980", VA = "0x188CC9380", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x8CC94A0", Offset = "0x8CC7AA0", VA = "0x188CC94A0")]
		public EYBUOBGKESI(RVJCLYOAPLX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x8CC9450", Offset = "0x8CC7A50", VA = "0x188CC9450", Slot = "8")]
		public void ZVKKKTRCJBD(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x8CC9210", Offset = "0x8CC7810", VA = "0x188CC9210", Slot = "9")]
		public void AOKHSYMWGWW(Rigidbody a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	internal sealed class DKNVEULXVII : RSCFVADDZAV
	{
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static readonly Log SHNQQFKDHRP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private readonly DUNPNXBIWKA RJCALRJYTQV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private bool XOJGWEQEJUT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private bool MYPBFMEBKDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private int GRLXXBOZTXI;

		[Cpp2IlInjected.Token(Token = "0x170000B3")]
		private Rigidbody VRSPXEIIPIE
		{
			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0x8CC1480", Offset = "0x8CBFA80", VA = "0x188CC1480")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B4")]
		private bool DJFFBZGTYVN
		{
			[Cpp2IlInjected.Token(Token = "0x60002FC")]
			[Cpp2IlInjected.Address(RVA = "0x8CC1460", Offset = "0x8CBFA60", VA = "0x188CC1460")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B5")]
		private RVJCLYOAPLX VTVCVRULVZC
		{
			[Cpp2IlInjected.Token(Token = "0x60002FD")]
			[Cpp2IlInjected.Address(RVA = "0x8CC11F0", Offset = "0x8CBF7F0", VA = "0x188CC11F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B6")]
		private bool NXIOQPKZSPK
		{
			[Cpp2IlInjected.Token(Token = "0x60002FE")]
			[Cpp2IlInjected.Address(RVA = "0x8CC1620", Offset = "0x8CBFC20", VA = "0x188CC1620")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400002D")]
		public event RbexAction RLSMFOUTABP
		{
			[Cpp2IlInjected.Token(Token = "0x60002F9")]
			[Cpp2IlInjected.Address(RVA = "0x8CC1680", Offset = "0x8CBFC80", VA = "0x188CC1680", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0x8CC1790", Offset = "0x8CBFD90", VA = "0x188CC1790", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x8CC1D70", Offset = "0x8CC0370", VA = "0x188CC1D70")]
		public DKNVEULXVII(RVJCLYOAPLX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x8CC1160", Offset = "0x8CBF760", VA = "0x188CC1160", Slot = "6")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x8CC1150", Offset = "0x8CBF750", VA = "0x188CC1150", Slot = "8")]
		public void AENKOIIYPXJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x8CC14D0", Offset = "0x8CBFAD0", VA = "0x188CC14D0", Slot = "7")]
		public bool GBLVPQIMCEV()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x8CC19F0", Offset = "0x8CBFFF0", VA = "0x188CC19F0", Slot = "9")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x8CC1C50", Offset = "0x8CC0250", VA = "0x188CC1C50", Slot = "13")]
		public void WXNQIESLXQB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x8CC1340", Offset = "0x8CBF940", VA = "0x188CC1340", Slot = "12")]
		public void BYBTTGMUFUQ(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x8CC1720", Offset = "0x8CBFD20", VA = "0x188CC1720", Slot = "10")]
		public bool MCDRAVLDNDB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x8CC1250", Offset = "0x8CBF850", VA = "0x188CC1250", Slot = "11")]
		public bool BVTUYQYDARE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x8CC1830", Offset = "0x8CBFE30", VA = "0x188CC1830")]
		private bool QHWPGMXFPYY()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x8CC1AC0", Offset = "0x8CC00C0", VA = "0x188CC1AC0")]
		private void VZIPVAOYMYK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	internal sealed class GNPHNTMJAYN : BPZLJWRJIWW
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private readonly DUNPNXBIWKA RJCALRJYTQV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private readonly ZCBRZWUWSEW MPUXKLFSOAJ;

		[Cpp2IlInjected.Token(Token = "0x170000B7")]
		public Rigidbody VRSPXEIIPIE
		{
			[Cpp2IlInjected.Token(Token = "0x600030B")]
			[Cpp2IlInjected.Address(RVA = "0xAA7750", Offset = "0xAA5D50", VA = "0x180AA7750", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600030C")]
			[Cpp2IlInjected.Address(RVA = "0xAA7770", Offset = "0xAA5D70", VA = "0x180AA7770")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B8")]
		private bool NXIOQPKZSPK
		{
			[Cpp2IlInjected.Token(Token = "0x600030D")]
			[Cpp2IlInjected.Address(RVA = "0x8CC9D30", Offset = "0x8CC8330", VA = "0x188CC9D30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B9")]
		public bool SADHAXDELBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000310")]
			[Cpp2IlInjected.Address(RVA = "0x1B4C3A0", Offset = "0x1B4A9A0", VA = "0x181B4C3A0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x8CC9FE0", Offset = "0x8CC85E0", VA = "0x188CC9FE0")]
		public GNPHNTMJAYN(RVJCLYOAPLX a, [In] RigidbodyExData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x8CC9C90", Offset = "0x8CC8290", VA = "0x188CC9C90", Slot = "5")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x8CC9FB0", Offset = "0x8CC85B0", VA = "0x188CC9FB0", Slot = "7")]
		public void XLEVRRHIHKP(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x8CC9D90", Offset = "0x8CC8390", VA = "0x188CC9D90", Slot = "8")]
		public void IWTOHCEWFXU(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x8CC97E0", Offset = "0x8CC7DE0", VA = "0x188CC97E0", Slot = "9")]
		public void AHIPWWSMQGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x8CC9DC0", Offset = "0x8CC83C0", VA = "0x188CC9DC0", Slot = "10")]
		public void THUYGTMVMNS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x8CC9B10", Offset = "0x8CC8110", VA = "0x188CC9B10", Slot = "11")]
		public void AVQWJEGTBEX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	internal sealed class DJDXUHJMDPE : SKWLMCVUKGZ, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private readonly DUNPNXBIWKA RJCALRJYTQV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private readonly ZCBRZWUWSEW KSFYREKCXRU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private float OJUDUFLQWGL;

		[Cpp2IlInjected.Token(Token = "0x170000BA")]
		public GWZOVDSJQAJ ENBNSDCTZAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000316")]
			[Cpp2IlInjected.Address(RVA = "0xAAFED0", Offset = "0xAAE4D0", VA = "0x180AAFED0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000317")]
			[Cpp2IlInjected.Address(RVA = "0xAA8690", Offset = "0xAA6C90", VA = "0x180AA8690", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		public XTLAQFBHGWM NKUSKFWRICR
		{
			[Cpp2IlInjected.Token(Token = "0x6000318")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6C0", Offset = "0xAA9CC0", VA = "0x180AAB6C0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000319")]
			[Cpp2IlInjected.Address(RVA = "0xAAA9B0", Offset = "0xAA8FB0", VA = "0x180AAA9B0", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BC")]
		public Vector3 MIZTDCUUJAT
		{
			[Cpp2IlInjected.Token(Token = "0x600031A")]
			[Cpp2IlInjected.Address(RVA = "0x8CBE440", Offset = "0x8CBCA40", VA = "0x188CBE440", Slot = "8")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600031B")]
			[Cpp2IlInjected.Address(RVA = "0x8CBEC10", Offset = "0x8CBD210", VA = "0x188CBEC10", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BD")]
		public Vector3 GUXZBVKNDMI
		{
			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(RVA = "0x8CBE080", Offset = "0x8CBC680", VA = "0x188CBE080", Slot = "10")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600031D")]
			[Cpp2IlInjected.Address(RVA = "0x8CBDEA0", Offset = "0x8CBC4A0", VA = "0x188CBDEA0", Slot = "11")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BE")]
		public Vector3 NTQHGGLVDWZ
		{
			[Cpp2IlInjected.Token(Token = "0x600031E")]
			[Cpp2IlInjected.Address(RVA = "0x8CBF980", Offset = "0x8CBDF80", VA = "0x188CBF980", Slot = "12")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600031F")]
			[Cpp2IlInjected.Address(RVA = "0x8CBED00", Offset = "0x8CBD300", VA = "0x188CBED00", Slot = "13")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BF")]
		public Vector3 ZNYZYPOGLSI
		{
			[Cpp2IlInjected.Token(Token = "0x6000320")]
			[Cpp2IlInjected.Address(RVA = "0x8CC05A0", Offset = "0x8CBEBA0", VA = "0x188CC05A0", Slot = "14")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0x8CBECD0", Offset = "0x8CBD2D0", VA = "0x188CBECD0", Slot = "15")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C0")]
		public float FPFKHWYFMQX
		{
			[Cpp2IlInjected.Token(Token = "0x6000322")]
			[Cpp2IlInjected.Address(RVA = "0xAFB210", Offset = "0xAF9810", VA = "0x180AFB210", Slot = "16")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000323")]
			[Cpp2IlInjected.Address(RVA = "0x8CBDB50", Offset = "0x8CBC150", VA = "0x188CBDB50", Slot = "17")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C1")]
		public bool DTONGYNCRVD
		{
			[Cpp2IlInjected.Token(Token = "0x6000324")]
			[Cpp2IlInjected.Address(RVA = "0x256DDB0", Offset = "0x256C3B0", VA = "0x18256DDB0", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C2")]
		private VINEMBIXZEB OSQMGAFUCHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000339")]
			[Cpp2IlInjected.Address(RVA = "0x82605C0", Offset = "0x825EBC0", VA = "0x1882605C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C3")]
		private bool DJFFBZGTYVN
		{
			[Cpp2IlInjected.Token(Token = "0x600033A")]
			[Cpp2IlInjected.Address(RVA = "0x8CBE060", Offset = "0x8CBC660", VA = "0x188CBE060")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x8CC1070", Offset = "0x8CBF670", VA = "0x188CC1070")]
		public DJDXUHJMDPE(RVJCLYOAPLX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x8CBDAB0", Offset = "0x8CBC0B0", VA = "0x188CBDAB0", Slot = "19")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x8CBDE40", Offset = "0x8CBC440", VA = "0x188CBDE40", Slot = "36")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x8CC0F40", Offset = "0x8CBF540", VA = "0x188CC0F40", Slot = "28")]
		public void ZVKKKTRCJBD(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x1944930", Offset = "0x1942F30", VA = "0x181944930", Slot = "20")]
		public void TQWHBYNVZXV(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x1944910", Offset = "0x1942F10", VA = "0x181944910", Slot = "30")]
		public void DMYJCFGBAWG(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x8CBDC60", Offset = "0x8CBC260", VA = "0x188CBDC60", Slot = "35")]
		public Vector3 DNSNNGPNWBB(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x8CBF7C0", Offset = "0x8CBDDC0", VA = "0x188CBF7C0", Slot = "34")]
		public Vector3 SPLSVTCBSAZ(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x8CBDAB0", Offset = "0x8CBC0B0", VA = "0x188CBDAB0", Slot = "27")]
		public void TZTJZYFQYLU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x8CBEBB0", Offset = "0x8CBD1B0", VA = "0x188CBEBB0", Slot = "25")]
		public void IBMFXXKGQQT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x8CBE5F0", Offset = "0x8CBCBF0", VA = "0x188CBE5F0", Slot = "24")]
		public void FBWEYOMQCDY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x8CBE200", Offset = "0x8CBC800", VA = "0x188CBE200", Slot = "33")]
		public void EZGSSGBAMSW(Vector3 a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x8CC0EE0", Offset = "0x8CBF4E0", VA = "0x188CC0EE0", Slot = "32")]
		public void ZBUQCOEYNNB(Vector3 a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x8CBF620", Offset = "0x8CBDC20", VA = "0x188CBF620", Slot = "31")]
		public void QBLYPYRLXVE(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x8CBEDC0", Offset = "0x8CBD3C0", VA = "0x188CBEDC0", Slot = "22")]
		public void KWVASTHJFQE(RbexImpulseType a, Vector3 b, float c, float d = 8f, float e = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x8CC0BB0", Offset = "0x8CBF1B0", VA = "0x188CC0BB0", Slot = "21")]
		public void WIASDOLUIXD(RbexRotationType a, Vector3 b, float c = 1f / 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x8CBE650", Offset = "0x8CBCC50", VA = "0x188CBE650", Slot = "23")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void FTIQBIMRMLI(RbexRotationType a, Vector3 b, float c = 7f, float d = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x1A7BE80", Offset = "0x1A7A480", VA = "0x181A7BE80")]
		private static void FKGHZOUGZHQ(Vector3 a, Vector3 b, [Out] Vector3 c, [Out] Vector3 d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x8CBEAD0", Offset = "0x8CBD0D0", VA = "0x188CBEAD0", Slot = "29")]
		public Vector3 GUDIQEGSVRZ(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x8CBDED0", Offset = "0x8CBC4D0", VA = "0x188CBDED0", Slot = "26")]
		public void ESINSQNCERM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x8CBDB50", Offset = "0x8CBC150", VA = "0x188CBDB50")]
		private void CSZQJSOKLDF(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x8CBF2F0", Offset = "0x8CBD8F0", VA = "0x188CBF2F0")]
		private void NXWNEOOWEZZ(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x8CBFB40", Offset = "0x8CBE140", VA = "0x188CBFB40")]
		private Vector3 TZAUPNLKCLS()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x8CBFCC0", Offset = "0x8CBE2C0", VA = "0x188CBFCC0")]
		private void UPFIPXMDBAY(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x8CBF490", Offset = "0x8CBDA90", VA = "0x188CBF490")]
		private Vector3 OKEJMUWZDTS()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x8CC0730", Offset = "0x8CBED30", VA = "0x188CC0730")]
		private void VTQEOLYPXRK(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x8CC0140", Offset = "0x8CBE740", VA = "0x188CC0140")]
		private void URIKKVSJINJ(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x8CC0E30", Offset = "0x8CBF430", VA = "0x188CC0E30")]
		private void XXZLIDLCHNT()
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
