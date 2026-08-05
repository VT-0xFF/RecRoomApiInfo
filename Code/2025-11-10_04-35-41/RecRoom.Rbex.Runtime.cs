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
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xACEB80", Offset = "0xACDF80", VA = "0x180ACEB80")]
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
		[Cpp2IlInjected.Address(RVA = "0x8A42910", Offset = "0x8A41D10", VA = "0x188A42910", Slot = "4")]
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
		private int[] DTCBHPALRHU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
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
		[Cpp2IlInjected.Address(RVA = "0x8A59E90", Offset = "0x8A59290", VA = "0x188A59E90")]
		private void RGTQLMDRHIR(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8A5A170", Offset = "0x8A59570", VA = "0x188A5A170", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8A5A1D0", Offset = "0x8A595D0", VA = "0x188A5A1D0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[DisallowMultipleComponent]
	public sealed class RigidbodyEx : MonoBehaviour, JHZEISLHDPT, LEVUSGLELGY, KHQUFIVSEOW
	{
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static readonly Log HIMJTOFRVRK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private bool SFAKMDAVJNS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private MWIJDBIDZDF UQDUYDWTJXC;

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
		private Transform CRNRLDXFMBS;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal MWIJDBIDZDF WVIQKWFJGRC
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x8A46E60", Offset = "0x8A46260", VA = "0x188A46E60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private MWIJDBIDZDF KAPKAFEHERU
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xAAA820", Offset = "0xAA9C20", VA = "0x180AAA820", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int INVHDCFVKSP
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x8A49860", Offset = "0x8A48C60", VA = "0x188A49860")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RigidbodyEx WBNQCWROWQU
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x8A49BC0", Offset = "0x8A48FC0", VA = "0x188A49BC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx JNBRJWHHBWC
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x8A49B00", Offset = "0x8A48F00", VA = "0x188A49B00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RigidbodyEx ORUDLVOERZA
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x8A4A7C0", Offset = "0x8A49BC0", VA = "0x188A4A7C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x8A4BCC0", Offset = "0x8A4B0C0", VA = "0x188A4BCC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool DidStart
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x7E332F0", Offset = "0x7E326F0", VA = "0x187E332F0", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x7E33440", Offset = "0x7E32840", VA = "0x187E33440")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Transform WJCWXTHIKWC
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x22D00D0", Offset = "0x22CF4D0", VA = "0x1822D00D0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Transform LLDCXYZCHKZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x22D00D0", Offset = "0x22CF4D0", VA = "0x1822D00D0", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Transform JWILKKTGZHX
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x22D00D0", Offset = "0x22CF4D0", VA = "0x1822D00D0", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public TransformTrackRate CGDXYLOQKLD
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x8A498C0", Offset = "0x8A48CC0", VA = "0x188A498C0")]
			get
			{
				return default(TransformTrackRate);
			}
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x8A4B470", Offset = "0x8A4A870", VA = "0x188A4B470")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool KGYJMXFIELE
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x8A49ED0", Offset = "0x8A492D0", VA = "0x188A49ED0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool POVZQWAWTHG
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x8A499E0", Offset = "0x8A48DE0", VA = "0x188A499E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public VDZYKGMLTUT LRBGTFZTHLC
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x8A49E10", Offset = "0x8A49210", VA = "0x188A49E10")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x8A4B630", Offset = "0x8A4AA30", VA = "0x188A4B630")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public HBNPYSELDYW DCDYMVMWUSH
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x8A49DB0", Offset = "0x8A491B0", VA = "0x188A49DB0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x8A4B5C0", Offset = "0x8A4A9C0", VA = "0x188A4B5C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool PCFNUGIDUMT
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x8A49D00", Offset = "0x8A49100", VA = "0x188A49D00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Rigidbody QNEZXRYKHXI
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x8A49D60", Offset = "0x8A49160", VA = "0x188A49D60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool QQWMQEWJXOV
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x8A49A40", Offset = "0x8A48E40", VA = "0x188A49A40")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x8A4B4E0", Offset = "0x8A4A8E0", VA = "0x188A4B4E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool HNEGECRYVAU
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x16ACF20", Offset = "0x16AC320", VA = "0x1816ACF20", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float ABRPBAFJXOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x8A4A760", Offset = "0x8A49B60", VA = "0x188A4A760")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float FXJGUSVJCXD
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x8A4A700", Offset = "0x8A49B00", VA = "0x188A4A700")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x8A4BC50", Offset = "0x8A4B050", VA = "0x188A4BC50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public float ZOIOAXDUBXO
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x8A4A130", Offset = "0x8A49530", VA = "0x188A4A130")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x8A4B8D0", Offset = "0x8A4ACD0", VA = "0x188A4B8D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public float BIPBMRAJFZI
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x8A49F30", Offset = "0x8A49330", VA = "0x188A49F30")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x8A4B6A0", Offset = "0x8A4AAA0", VA = "0x188A4B6A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public bool FHONOYOSOWF
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x8A4AD10", Offset = "0x8A4A110", VA = "0x188A4AD10")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x8A4C200", Offset = "0x8A4B600", VA = "0x188A4C200")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Vector3 JDRTKWGZJEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x8A4A4E0", Offset = "0x8A498E0", VA = "0x188A4A4E0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x8A4BA20", Offset = "0x8A4AE20", VA = "0x188A4BA20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public Vector3 BERCTNPWMXU
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x8A4AE50", Offset = "0x8A4A250", VA = "0x188A4AE50")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public CollisionDetectionMode DQWWBJEFRFI
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x8A4A070", Offset = "0x8A49470", VA = "0x188A4A070")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x8A4B7F0", Offset = "0x8A4ABF0", VA = "0x188A4B7F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public float LTQZYTALBDT
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x8A49AA0", Offset = "0x8A48EA0", VA = "0x188A49AA0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x8A4B550", Offset = "0x8A4A950", VA = "0x188A4B550")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public RigidbodyConstraints CFTUEQWLWZY
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x8A4A0D0", Offset = "0x8A494D0", VA = "0x188A4A0D0")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x8A4B860", Offset = "0x8A4AC60", VA = "0x188A4B860")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public Vector3 FWAXVUVXZUQ
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x8A4A880", Offset = "0x8A49C80", VA = "0x188A4A880")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public Vector3 CVLVANUJLOM
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x8A4A880", Offset = "0x8A49C80", VA = "0x188A4A880")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x8A4BFE0", Offset = "0x8A4B3E0", VA = "0x188A4BFE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public float BSAFOFLJYBZ
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x8A4A5C0", Offset = "0x8A499C0", VA = "0x188A4A5C0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x8A4BB00", Offset = "0x8A4AF00", VA = "0x188A4BB00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public float RFRMBOABCOE
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x8A4ACB0", Offset = "0x8A4A0B0", VA = "0x188A4ACB0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x8A4C190", Offset = "0x8A4B590", VA = "0x188A4C190")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Quaternion JXMNWVFWIQZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x8A4A960", Offset = "0x8A49D60", VA = "0x188A4A960")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x8A4BD60", Offset = "0x8A4B160", VA = "0x188A4BD60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Quaternion DZXMDNOOIDT
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x8A4ABE0", Offset = "0x8A49FE0", VA = "0x188A4ABE0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x8A4C0C0", Offset = "0x8A4B4C0", VA = "0x188A4C0C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector3 FSTKAZYSFDX
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x8A4AA30", Offset = "0x8A49E30", VA = "0x188A4AA30")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x8A4BE30", Offset = "0x8A4B230", VA = "0x188A4BE30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Quaternion BXUJIHLGQQU
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x8A4AB10", Offset = "0x8A49F10", VA = "0x188A4AB10")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x8A4BF10", Offset = "0x8A4B310", VA = "0x188A4BF10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 NNESCWKTUIV
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x8A4AD70", Offset = "0x8A4A170", VA = "0x188A4AD70")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x8A4C270", Offset = "0x8A4B670", VA = "0x188A4C270")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 LNFDZPYIPAW
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x8A4A620", Offset = "0x8A49A20", VA = "0x188A4A620")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x8A4BB70", Offset = "0x8A4AF70", VA = "0x188A4BB70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector3 RBZBAUPMGLR
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x8A49F90", Offset = "0x8A49390", VA = "0x188A49F90")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x8A4B710", Offset = "0x8A4AB10", VA = "0x188A4B710")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector3 GNTPFSEHJVA
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x8A4A400", Offset = "0x8A49800", VA = "0x188A4A400")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x8A4B940", Offset = "0x8A4AD40", VA = "0x188A4B940")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector3 RRYYUZQLUHT
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x8A4A2C0", Offset = "0x8A496C0", VA = "0x188A4A2C0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Quaternion FNBELWEMTNV
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x8A4A1F0", Offset = "0x8A495F0", VA = "0x188A4A1F0")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public Vector3 EDLEVUZIYQP
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x8A4B010", Offset = "0x8A4A410", VA = "0x188A4B010")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public Vector3 LNYQVQWTNIR
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x8A4AF30", Offset = "0x8A4A330", VA = "0x188A4AF30")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool WFRISKWHTXF
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x8A4A3A0", Offset = "0x8A497A0", VA = "0x188A4A3A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool BPNQFULQQVO
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x8A49E70", Offset = "0x8A49270", VA = "0x188A49E70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool EHODYOLUUXJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x8A49980", Offset = "0x8A48D80", VA = "0x188A49980")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool XEUKYMICXNM
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x8A49920", Offset = "0x8A48D20", VA = "0x188A49920")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool KMTALXYSSXJ
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x8A49800", Offset = "0x8A48C00", VA = "0x188A49800")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public bool YJHFUMBCIFM
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x8A4A190", Offset = "0x8A49590", VA = "0x188A4A190")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool FTNBLRPOGMU
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xB0E690", Offset = "0xB0DA90", VA = "0x180B0E690")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event RbexParentChangeAction NOLFNFEXCKS
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x8A49720", Offset = "0x8A48B20", VA = "0x188A49720")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x8A4B390", Offset = "0x8A4A790", VA = "0x188A4B390")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event RbexAction UFVABTNCHJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x8A49490", Offset = "0x8A48890", VA = "0x188A49490")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x8A4B0F0", Offset = "0x8A4A4F0", VA = "0x188A4B0F0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event RbexAction YQSIFTORTNS
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x8A494F0", Offset = "0x8A488F0", VA = "0x188A494F0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x8A4B160", Offset = "0x8A4A560", VA = "0x188A4B160")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event RbexAction TANAEAFQUZO
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x8A49640", Offset = "0x8A48A40", VA = "0x188A49640")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x8A4B2B0", Offset = "0x8A4A6B0", VA = "0x188A4B2B0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<UpdateLOD, UpdateLOD> LDZEKXBNUKW
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x8A495D0", Offset = "0x8A489D0", VA = "0x188A495D0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x8A4B240", Offset = "0x8A4A640", VA = "0x188A4B240")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event RbexAction RTCVRRBHLTF
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x8A496B0", Offset = "0x8A48AB0", VA = "0x188A496B0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x8A4B320", Offset = "0x8A4A720", VA = "0x188A4B320")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event RbexAction QRLFQALWCQV
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x8A49790", Offset = "0x8A48B90", VA = "0x188A49790")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x8A4B400", Offset = "0x8A4A800", VA = "0x188A4B400")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event RbexAction IFTUUWQQREU
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x8A49560", Offset = "0x8A48960", VA = "0x188A49560")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x8A4B1D0", Offset = "0x8A4A5D0", VA = "0x188A4B1D0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xAA67D0", Offset = "0xAA5BD0", VA = "0x180AA67D0", Slot = "8")]
		private void YQAXXGWKEGC(MWIJDBIDZDF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8A48090", Offset = "0x8A47490", VA = "0x188A48090", Slot = "9")]
		public RigidbodyExData GetData()
		{
			return default(RigidbodyExData);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8A484F0", Offset = "0x8A478F0", VA = "0x188A484F0")]
		internal void OACTAJQAFMT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8A491C0", Offset = "0x8A485C0", VA = "0x188A491C0")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public void TestOverrideUnityRigidbody(Rigidbody rb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8A47DE0", Offset = "0x8A471E0", VA = "0x188A47DE0")]
		public JHZEISLHDPT GetChild(int index)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x8A48E80", Offset = "0x8A48280", VA = "0x188A48E80")]
		public void SetInertiaTensor((Quaternion rot, Vector3 moments) tensor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x8A478C0", Offset = "0x8A46CC0", VA = "0x188A478C0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x8A49110", Offset = "0x8A48510", VA = "0x188A49110")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8A46E60", Offset = "0x8A46260", VA = "0x188A46E60")]
		private MWIJDBIDZDF CXFBLRYFPHG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8A47C00", Offset = "0x8A47000", VA = "0x188A47C00")]
		private void DWRZVDJUYSA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8A48640", Offset = "0x8A47A40", VA = "0x188A48640")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x8A48580", Offset = "0x8A47980", VA = "0x188A48580")]
		public void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x8A484F0", Offset = "0x8A478F0", VA = "0x188A484F0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8A485E0", Offset = "0x8A479E0", VA = "0x188A485E0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8A486A0", Offset = "0x8A47AA0", VA = "0x188A486A0")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8A46F10", Offset = "0x8A46310", VA = "0x188A46F10")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x8A48710", Offset = "0x8A47B10", VA = "0x188A48710")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8A47D80", Offset = "0x8A47180", VA = "0x188A47D80")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x8A48490", Offset = "0x8A47890", VA = "0x188A48490")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x8A48FE0", Offset = "0x8A483E0", VA = "0x188A48FE0")]
		public void SetParent(RigidbodyEx value, bool isPhysicallyDetachedOnly = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x8A48A20", Offset = "0x8A47E20", VA = "0x188A48A20")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8A48120", Offset = "0x8A47520", VA = "0x188A48120")]
		public bool IsRigidbodyAncestor(RigidbodyEx possibleAncestor)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8A48220", Offset = "0x8A47620", VA = "0x188A48220")]
		public bool IsRigidbodyDescendant(RigidbodyEx possibleDescendant)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8A47180", Offset = "0x8A46580", VA = "0x188A47180")]
		public void AddInterpolationRestriction(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8A48780", Offset = "0x8A47B80", VA = "0x188A48780")]
		public void RemoveInterpolationRestriction(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x8A471F0", Offset = "0x8A465F0", VA = "0x188A471F0")]
		public void AddKinematic(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x8A487F0", Offset = "0x8A47BF0", VA = "0x188A487F0")]
		public void RemoveKinematic(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x8A48F60", Offset = "0x8A48360", VA = "0x188A48F60")]
		public void SetKinematic(object token, bool setKinematic)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x8A48D80", Offset = "0x8A48180", VA = "0x188A48D80")]
		public void SetDiscontinuousPositionAndRotation(Vector3 newPosition, Quaternion newRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x8A48C80", Offset = "0x8A48080", VA = "0x188A48C80")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 newLocalPosition, Quaternion newLocalRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x8A47F80", Offset = "0x8A47380", VA = "0x188A47F80")]
		public Vector3 GetConstrainedVelocity(Vector3 velocity)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x8A47E70", Offset = "0x8A47270", VA = "0x188A47E70")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 angularVelocity)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8A47090", Offset = "0x8A46490", VA = "0x188A47090")]
		public void AddForce(Vector3 force, ForceMode forceMode = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x8A46F80", Offset = "0x8A46380", VA = "0x188A46F80")]
		public void AddForceAtPosition(Vector3 force, Vector3 position, ForceMode forceMode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8A473C0", Offset = "0x8A467C0", VA = "0x188A473C0")]
		public void AddTorque(Vector3 torque, ForceMode forceMode = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x8A47260", Offset = "0x8A46660", VA = "0x188A47260")]
		public void AddRelativeTorque(Vector3 torque, ForceMode forceMode = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8A49290", Offset = "0x8A48690", VA = "0x188A49290")]
		public Vector3 WorldToLocalVelocity(Vector3 worldVelocity)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8A48380", Offset = "0x8A47780", VA = "0x188A48380")]
		public Vector3 LocalToWorldVelocity(Vector3 localVelocity)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8A47BA0", Offset = "0x8A46FA0", VA = "0x188A47BA0")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8A47B40", Offset = "0x8A46F40", VA = "0x188A47B40")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8A47AE0", Offset = "0x8A46EE0", VA = "0x188A47AE0")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8A47A80", Offset = "0x8A46E80", VA = "0x188A47A80")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x8A48B80", Offset = "0x8A47F80", VA = "0x188A48B80")]
		public void ResetVelocityWorldSpace(Vector3 worldLinearVelocity, Vector3 worldAngularVelocity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x8A48A80", Offset = "0x8A47E80", VA = "0x188A48A80")]
		public void ResetVelocityLocalSpace(Vector3 localLinearVelocity, Vector3 localAngularVelocity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x8A48940", Offset = "0x8A47D40", VA = "0x188A48940")]
		public void ResetLinearVelocityLocalSpace(Vector3 localLinearVelocity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x8A49120", Offset = "0x8A48520", VA = "0x188A49120")]
		public bool SweepTest(Vector3 direction, [Out] RaycastHit hitInfo, float maxDistance)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x8A48320", Offset = "0x8A47720", VA = "0x188A48320")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x8A490B0", Offset = "0x8A484B0", VA = "0x188A490B0")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x8A49230", Offset = "0x8A48630", VA = "0x188A49230")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x8A47350", Offset = "0x8A46750", VA = "0x188A47350")]
		public void AddShouldHaveUnityRigidbodyToken(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x8A48860", Offset = "0x8A47C60", VA = "0x188A48860")]
		public void RemoveShouldHaveUnityRigidbodyToken(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x8A47750", Offset = "0x8A46B50", VA = "0x188A47750")]
		public void ApplyForceVelocityChange(RbexImpulseType impulseType, Vector3 impulseDirection, float impulseSpeed, float impulseDirectionMaxSpeed = 8f, float impulseReflectiveRestitution = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x8A47650", Offset = "0x8A46A50", VA = "0x188A47650")]
		public void ApplyAngularVelocityChange(RbexRotationType rotationType, Vector3 newAngularVelocity, float maxAngularSpeed = 1f / 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x8A47810", Offset = "0x8A46C10", VA = "0x188A47810")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void ApplyTorqueAngularVelocityChangeDeprecated(RbexRotationType rotationType, Vector3 rotation, float maxSpeed = 7f, float multiplyingFactor = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x8A47580", Offset = "0x8A46980", VA = "0x188A47580")]
		public bool AllowedScaleChange(float scaleFactor)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x8A474B0", Offset = "0x8A468B0", VA = "0x188A474B0")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx parentOverride, object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x8A488D0", Offset = "0x8A47CD0", VA = "0x188A488D0")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x8A48700", Offset = "0x8A47B00", VA = "0x188A48700", Slot = "13")]
		private void QJNOLUHPVKN(MRSPDLXDOCP a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x8A49420", Offset = "0x8A48820", VA = "0x188A49420")]
		public RigidbodyEx()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x11E96E0", Offset = "0x11E8AE0", VA = "0x1811E96E0", Slot = "4")]
		private GameObject UYLCKQDNYBK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0xAD02D0", Offset = "0xACF6D0", VA = "0x180AD02D0", Slot = "10")]
		private bool IVAZYXBKTZJ()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	internal static class QHTFQLRJUOW
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x8A445A0", Offset = "0x8A439A0", VA = "0x188A445A0")]
		public static MWIJDBIDZDF WVIQKWFJGRC(this RigidbodyEx a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[RegisterService(typeof(DZKRLLHWCBC), new string[] { })]
	public class RigidbodyExManager : DZKRLLHWCBC, UFLUIPVILQU
	{
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static readonly Log HONKOTEDSFS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private HJBOKGILMOD GTVBHFZJJCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private ZLLWIIHAJDE ZKTPRDPAAQQ;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public HJBOKGILMOD OJXQDUAJVPU
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public ZLLWIIHAJDE VVRELEDZHCY
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x8A46C40", Offset = "0x8A46040", VA = "0x188A46C40", Slot = "7")]
		public void InitReferences(SAMXOKXXSFT services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x8A46CB0", Offset = "0x8A460B0", VA = "0x188A46CB0", Slot = "6")]
		public MWIJDBIDZDF UNBHERHVLNS(RigidbodyEx a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public RigidbodyExManager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class PhysicsManager : SingletonMonoBehaviour<PhysicsManager>
	{
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static NHBLQESUHLS UpdateAfterFixedUpdateRan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private int SUDVUNXRYQG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private int CCAXWHWSEXI;

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x8A443E0", Offset = "0x8A437E0", VA = "0x188A443E0")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x8A44460", Offset = "0x8A43860", VA = "0x188A44460")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x8A44400", Offset = "0x8A43800", VA = "0x188A44400")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string message, [Optional] UnityEngine.Object context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string message, [Optional] UnityEngine.Object context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x8A44550", Offset = "0x8A43950", VA = "0x188A44550")]
		public PhysicsManager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public static class JINIOFGWLPE
	{
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		private class ENOCVSCCMTY : VDZYKGMLTUT, IDisposable
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "7")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0xAB44B0", Offset = "0xAB38B0", VA = "0x180AB44B0", Slot = "4")]
			public Vector3 IFNKZXAPWLB()
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0xAB44B0", Offset = "0xAB38B0", VA = "0x180AB44B0", Slot = "5")]
			public Vector3 KJDVCHEIFHQ()
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0xABEDC0", Offset = "0xABE1C0", VA = "0x180ABEDC0", Slot = "6")]
			public bool DNXMWLUWZHX(float a, float b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public ENOCVSCCMTY()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public static VDZYKGMLTUT LIPIJQEDGFJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x8A42790", Offset = "0x8A41B90", VA = "0x188A42790")]
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
	public interface OVXBVHLSMBB
	{
		[Cpp2IlInjected.Token(Token = "0x17000039")]
		CollisionDetectionMode BUQBOMKWSUW
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
		void ISFOUVLLHCO(bool a);

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void UKMZQDXZACN(bool a);

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void HCYVTHGDDGP(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool GODKAIEGKGG(Vector3 a, [Out] RaycastHit b, float c);
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public interface KEYBYJOZPEI : IDisposable, JUXEBJYBFAS
	{
		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		TransformTrackRate CGDXYLOQKLD
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		event Action<UpdateLOD, UpdateLOD> LDZEKXBNUKW;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void Awake();
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[ServiceLifetime(Lifetime.Application)]
	public interface ZLLWIIHAJDE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		SCDTKWWSIZB NWGKVZRWKIV(MWIJDBIDZDF a);

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		MJAZKPXHZUH IAKXXKZYEQB(MWIJDBIDZDF a);

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		RBQFLJQXITG RZHDJNOUOTU(MWIJDBIDZDF a);

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		BWHJHDJYXXL ALDULDHWJLJ(MWIJDBIDZDF a);

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "4")]
		ILTJNVNSRQX IYPQOLXRZQB(MWIJDBIDZDF a);

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "5")]
		KEYBYJOZPEI BLXKNLKMQBM(MWIJDBIDZDF a);

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "6")]
		BIXXGTVQGNL WGBWRVOOEIX(MWIJDBIDZDF a);

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "7")]
		XNNZMDWKDCL LUEPGEKCHUN(MWIJDBIDZDF a);

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "8")]
		OVXBVHLSMBB IVWJCDNMFMZ(MWIJDBIDZDF a);

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "9")]
		GAVUHFWVDQC AXILJCSWGCU(MWIJDBIDZDF a);

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "10")]
		RVAQDSIPZAU HFSLMXYPYXA(MWIJDBIDZDF a, [In] RigidbodyExData data);

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "11")]
		NINZGGAFRVW PNTZWCAEQMW(MWIJDBIDZDF a, [In] RigidbodyExData data);

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "12")]
		JOTLTNAESSC MYLFNXUYGLS(MWIJDBIDZDF a, [In] RigidbodyExData data);

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "13")]
		WVZAHGAKZLM GIRAEIPMGYQ(MWIJDBIDZDF a, [In] RigidbodyExData data);

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "14")]
		MBLXQUTZUAK LVMDPTJTMOY(MWIJDBIDZDF a, [In] RigidbodyExData data);

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "15")]
		MWIJDBIDZDF UNBHERHVLNS(RigidbodyEx a, RigidbodyExData b, DZKRLLHWCBC c);
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface XNNZMDWKDCL
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void OJHCZMNXWZS(Vector3 a, ForceMode b = ForceMode.Force);

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void MFHPWYYEDLU(Vector3 a, Vector3 b, ForceMode c);

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void QONTKXGZROT(Vector3 a, ForceMode b = ForceMode.Force);

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void IUILABLYMAT(Vector3 a, ForceMode b = ForceMode.Force);
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface GAVUHFWVDQC
	{
		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		bool DSJHKGQLUHL
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
		void HCYVTHGDDGP(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void CJWOGKOXWPK(Rigidbody a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public interface SCDTKWWSIZB : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		IReadOnlyList<MWIJDBIDZDF> TLEJKUCJCCG
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(Slot = "18")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		MWIJDBIDZDF JNBRJWHHBWC
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(Slot = "19")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		MWIJDBIDZDF YSZAMEVATVQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(Slot = "20")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(Slot = "21")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		event RbexAction UFVABTNCHJA;

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		event RbexAction YQSIFTORTNS;

		[Cpp2IlInjected.Token(Token = "0x1400000C")]
		event RbexParentChangeAction SPYZLHERCQK;

		[Cpp2IlInjected.Token(Token = "0x1400000D")]
		event Action KSFESOUZWNB;

		[Cpp2IlInjected.Token(Token = "0x1400000E")]
		event Action VOFHPGHOTME;

		[Cpp2IlInjected.Token(Token = "0x1400000F")]
		event Action<MWIJDBIDZDF> KPFHYKEKNIN;

		[Cpp2IlInjected.Token(Token = "0x14000010")]
		event Action<MWIJDBIDZDF> IZFBYTMZSZQ;

		[Cpp2IlInjected.Token(Token = "0x14000011")]
		event Action XREAUUDWOEN;

		[Cpp2IlInjected.Token(Token = "0x14000012")]
		event Action<MWIJDBIDZDF> XOWXGNSXXDM;

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "22")]
		void SetParent(MWIJDBIDZDF newParent, bool isPhysicallyDetachedOnly = false);
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public interface RBQFLJQXITG
	{
		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		Vector3 DJBEWVCRZBZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		Vector3 IGAFVSWPCWR
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void OKKBOAGOFCF(MWIJDBIDZDF a, object b);

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void NNZREIXBJOS(object a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public interface WVZAHGAKZLM
	{
		[Cpp2IlInjected.Token(Token = "0x17000041")]
		Vector3 JVLPJAUZBDH
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		Vector3 TFTMCTTECYS
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		float LTXYVPLQEGK
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		float NEBHKMAZSPD
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(Slot = "7")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		Vector3 CUBUQBRLKCN
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		Quaternion FYCJLHUPUKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000013")]
		event RbexAction PGDUENDWDHO;

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void YCRIHYGOZAF((Quaternion rot, Vector3 moments) tensor);

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(Slot = "11")]
		void XTSXEAXJHCY();

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void WZAGCFBATJV();

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(Slot = "13")]
		void YCMGNIZKGPX();

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void HCYVTHGDDGP(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void CJWOGKOXWPK(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void OnDrawGizmosSelected();
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public interface JOTLTNAESSC
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Awake();

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void UJRPFGXFAMF(object a);

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void RCFFMHSKXBW(object a);

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void IFQLRXAIKHG(MWIJDBIDZDF a);

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void ANPJCEHELJZ(MWIJDBIDZDF a);

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void XNVEWKQOWBO();
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public interface BIXXGTVQGNL
	{
		[Cpp2IlInjected.Token(Token = "0x17000047")]
		bool EJXMOZGYWKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000014")]
		event RbexAction ZUXTCXUQVIJ;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void CRCHUBDAKHQ(object a);

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void ELXGXTJKQMP(object a);

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void HOSPLPTERRN(object a, bool b);

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void HCYVTHGDDGP(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void CJWOGKOXWPK(Rigidbody a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface NINZGGAFRVW : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000048")]
		bool KGYJMXFIELE
		{
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		bool POVZQWAWTHG
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000015")]
		event RbexAction HKMLKUBCHGJ;

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void Awake();

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void BUEGVYIRSFQ(MWIJDBIDZDF a);

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void GZKHAINJBIW(MWIJDBIDZDF a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface MBLXQUTZUAK
	{
		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		bool QQWMQEWJXOV
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		bool DHISTKRCSBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		RigidbodyConstraints UXRQCXKMIBY
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
		void HCYVTHGDDGP(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void CJWOGKOXWPK(Rigidbody a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface BWHJHDJYXXL
	{
		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		float JGTAUWLZKXC
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		float TOZQNNTDPRQ
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
		void HCYVTHGDDGP(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void CJWOGKOXWPK(Rigidbody a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public interface ILTJNVNSRQX
	{
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		static bool XCBQXOGZGBJ;

		[Cpp2IlInjected.Token(Token = "0x14000016")]
		event RbexAction MGDQBBFJNPN;

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void Awake();

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool OSBUHOXNNLB();

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void GLDGFBJDVPX();

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void Sleep();

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool UBFIHJBRJKR();

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool UUKGBGBBVOM();

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void EBNFZFMUEDM(bool a);

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void PHZGPXDVXYP();
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public interface RVAQDSIPZAU
	{
		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		Rigidbody QNEZXRYKHXI
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		bool FDIBEFIEIUP
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
		void LBTTOIQEHMV(object a);

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void UQNEFILOZIE(object a);

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void XXRCBYEGAUZ();
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public interface MJAZKPXHZUH : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000051")]
		VDZYKGMLTUT LRBGTFZTHLC
		{
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		HBNPYSELDYW DCDYMVMWUSH
		{
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		Vector3 GJPNWNLMIRP
		{
			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(Slot = "5")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		Vector3 CKYWBPNGQUK
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(Slot = "7")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		Vector3 DAIFPKLWRXR
		{
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(Slot = "9")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		Vector3 XZFWVRVTZTE
		{
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(Slot = "11")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		float LTQZYTALBDT
		{
			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(Slot = "13")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		bool PCFNUGIDUMT
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
		void MVSOKDQJQHH(object a);

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(Slot = "17")]
		void LNZOYVKXZHZ(RbexRotationType a, Vector3 b, float c = 1f / 0f);

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(Slot = "18")]
		void WEPRVJNKZCW(RbexImpulseType a, Vector3 b, float c, float d = 8f, float e = 1f);

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(Slot = "19")]
		void ZKWBPDUCICU(RbexRotationType a, Vector3 b, float c = 7f, float d = 1f);

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(Slot = "20")]
		void PJOXMHGLFQY();

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(Slot = "21")]
		void WLDDRETZDIV();

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(Slot = "22")]
		void PJXPHYOMJLG();

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(Slot = "23")]
		void BWEFLGWTBXW();

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(Slot = "24")]
		void HCYVTHGDDGP(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(Slot = "25")]
		Vector3 CNBKTKVKPYZ(Vector3 a);

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(Slot = "26")]
		void VNDIBRQNOYI(object a);

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(Slot = "27")]
		void XGBEWNLQOLC(Vector3 a);

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(Slot = "28")]
		void NZKWHSCZSZD(Vector3 a, Vector3 b);

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(Slot = "29")]
		void GDHMYKPNYFK(Vector3 a, Vector3 b);

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(Slot = "30")]
		Vector3 CIFCKWXAXST(Vector3 a);

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(Slot = "31")]
		Vector3 LRMLHJIINQB(Vector3 a);
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[ServiceLifetime(Lifetime.Application)]
	public interface HJBOKGILMOD
	{
		[Cpp2IlInjected.Token(Token = "0x17000059")]
		bool ATOWQOXXJUU
		{
			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void UVPSOSAMJPU(string a);

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void RHFGGWCISPX(RigidbodyEx a, Action b);

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		MDFTLYVXJZR BQGXJAISBPS(int a);

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void SXWTUMPSDNC(Vector3 a, float b, Color c);
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[ServiceLifetime(Lifetime.Application)]
	public interface DZKRLLHWCBC
	{
		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		HJBOKGILMOD OJXQDUAJVPU
		{
			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		ZLLWIIHAJDE VVRELEDZHCY
		{
			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(Slot = "2")]
		MWIJDBIDZDF UNBHERHVLNS(RigidbodyEx a);
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class THCJMJLYUAO : MWIJDBIDZDF, IDisposable, GWTKCITJUUU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		internal readonly DZKRLLHWCBC KYSGMPHMQKZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		internal SCDTKWWSIZB DTKCKNLSDVD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		internal JOTLTNAESSC GRDCZLAGEAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		internal NINZGGAFRVW ZSUVOFMNMGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		internal MJAZKPXHZUH NNESCWKTUIV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		internal RBQFLJQXITG XUMGPDMYKRE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		internal WVZAHGAKZLM KRGQKNUTTGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		internal BWHJHDJYXXL LYJIMUOFUHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		internal GAVUHFWVDQC WLTHMXGUWUE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		internal ILTJNVNSRQX CLJSOZRUPSB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		internal KEYBYJOZPEI ZBJLUPLXNXY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		internal BIXXGTVQGNL AEWWMSXDXFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		internal XNNZMDWKDCL KXEXXWCUEFT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		internal MBLXQUTZUAK WXCLVJMGWII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		internal RVAQDSIPZAU QMWPFSAKKGW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		internal OVXBVHLSMBB YOBSASTWGDT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		internal IDisposable EEMUEPUXRCQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private bool CJNIWHYXKKK;

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public ObjectLocalId NEWSTJSXLIU
		{
			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0xAA4920", Offset = "0xAA3D20", VA = "0x180AA4920", Slot = "22")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public JHZEISLHDPT UONFEXDYHIU
		{
			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0xB9E4B0", Offset = "0xB9D8B0", VA = "0x180B9E4B0", Slot = "24")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0xB9D910", Offset = "0xB9CD10", VA = "0x180B9D910")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public GameObject QYWBNTWUNOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A40", Offset = "0xAA5E40", VA = "0x180AA6A40", Slot = "25")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A70", Offset = "0xAA5E70", VA = "0x180AA6A70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public Transform SFEPHHTYQFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0xC24EE0", Offset = "0xC242E0", VA = "0x180C24EE0", Slot = "26")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0xCE6C10", Offset = "0xCE6010", VA = "0x180CE6C10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public Rigidbody QNEZXRYKHXI
		{
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x8A4D5E0", Offset = "0x8A4C9E0", VA = "0x188A4D5E0", Slot = "23")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public MWIJDBIDZDF YSZAMEVATVQ
		{
			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x8A4E490", Offset = "0x8A4D890", VA = "0x188A4E490", Slot = "27")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x8A4D460", Offset = "0x8A4C860", VA = "0x188A4D460", Slot = "28")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public int INVHDCFVKSP
		{
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x8A50F60", Offset = "0x8A50360", VA = "0x188A50F60", Slot = "31")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public MWIJDBIDZDF JNBRJWHHBWC
		{
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x8A4F5E0", Offset = "0x8A4E9E0", VA = "0x188A4F5E0", Slot = "29")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public bool WPVPLREWLPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x8A51D00", Offset = "0x8A51100", VA = "0x188A51D00", Slot = "32")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public bool KGYJMXFIELE
		{
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x8A50DA0", Offset = "0x8A501A0", VA = "0x188A50DA0", Slot = "33")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public bool POVZQWAWTHG
		{
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x8A51E50", Offset = "0x8A51250", VA = "0x188A51E50", Slot = "34")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public VDZYKGMLTUT LRBGTFZTHLC
		{
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x8A4FBE0", Offset = "0x8A4EFE0", VA = "0x188A4FBE0", Slot = "35")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x8A4EEA0", Offset = "0x8A4E2A0", VA = "0x188A4EEA0", Slot = "36")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public HBNPYSELDYW DCDYMVMWUSH
		{
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x8A4E370", Offset = "0x8A4D770", VA = "0x188A4E370", Slot = "37")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x8A4CFE0", Offset = "0x8A4C3E0", VA = "0x188A4CFE0", Slot = "38")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public float LTQZYTALBDT
		{
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x8A50450", Offset = "0x8A4F850", VA = "0x188A50450", Slot = "39")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x8A50FD0", Offset = "0x8A503D0", VA = "0x188A50FD0", Slot = "40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public Vector3 CKYWBPNGQUK
		{
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x8A52830", Offset = "0x8A51C30", VA = "0x188A52830", Slot = "41")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x8A51B10", Offset = "0x8A50F10", VA = "0x188A51B10", Slot = "42")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public Vector3 XZFWVRVTZTE
		{
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x8A4D220", Offset = "0x8A4C620", VA = "0x188A4D220", Slot = "43")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x8A4CE50", Offset = "0x8A4C250", VA = "0x188A4CE50", Slot = "44")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public Vector3 GJPNWNLMIRP
		{
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x8A4E5D0", Offset = "0x8A4D9D0", VA = "0x188A4E5D0", Slot = "45")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x8A4ECE0", Offset = "0x8A4E0E0", VA = "0x188A4ECE0", Slot = "46")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public Vector3 DAIFPKLWRXR
		{
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x8A51570", Offset = "0x8A50970", VA = "0x188A51570", Slot = "47")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x8A51030", Offset = "0x8A50430", VA = "0x188A51030", Slot = "48")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public bool EHODYOLUUXJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x8A4D410", Offset = "0x8A4C810", VA = "0x188A4D410", Slot = "49")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public bool XEUKYMICXNM
		{
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x8A51310", Offset = "0x8A50710", VA = "0x188A51310", Slot = "50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public bool KMTALXYSSXJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x8A4EDC0", Offset = "0x8A4E1C0", VA = "0x188A4EDC0", Slot = "51")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public bool PCFNUGIDUMT
		{
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x8A4C350", Offset = "0x8A4B750", VA = "0x188A4C350", Slot = "52")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public Vector3 DJBEWVCRZBZ
		{
			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x8A4C620", Offset = "0x8A4BA20", VA = "0x188A4C620", Slot = "53")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public Vector3 IGAFVSWPCWR
		{
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x8A522A0", Offset = "0x8A516A0", VA = "0x188A522A0", Slot = "54")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public Vector3 JVLPJAUZBDH
		{
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x8A4D040", Offset = "0x8A4C440", VA = "0x188A4D040", Slot = "55")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x8A4C4E0", Offset = "0x8A4B8E0", VA = "0x188A4C4E0", Slot = "56")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public Vector3 TFTMCTTECYS
		{
			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x8A4C400", Offset = "0x8A4B800", VA = "0x188A4C400", Slot = "57")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public float LTXYVPLQEGK
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x8A52030", Offset = "0x8A51430", VA = "0x188A52030", Slot = "58")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public float NEBHKMAZSPD
		{
			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x8A50D40", Offset = "0x8A50140", VA = "0x188A50D40", Slot = "59")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x8A51230", Offset = "0x8A50630", VA = "0x188A51230", Slot = "60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public Vector3 CUBUQBRLKCN
		{
			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x8A50630", Offset = "0x8A4FA30", VA = "0x188A50630", Slot = "61")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public Quaternion FYCJLHUPUKH
		{
			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x8A52460", Offset = "0x8A51860", VA = "0x188A52460", Slot = "62")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public float JGTAUWLZKXC
		{
			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x8A4D800", Offset = "0x8A4CC00", VA = "0x188A4D800", Slot = "64")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x8A52910", Offset = "0x8A51D10", VA = "0x188A52910", Slot = "65")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public float TOZQNNTDPRQ
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x8A4F3E0", Offset = "0x8A4E7E0", VA = "0x188A4F3E0", Slot = "66")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x8A52720", Offset = "0x8A51B20", VA = "0x188A52720", Slot = "67")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public bool DSJHKGQLUHL
		{
			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x8A4F480", Offset = "0x8A4E880", VA = "0x188A4F480", Slot = "68")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x8A4EC80", Offset = "0x8A4E080", VA = "0x188A4EC80", Slot = "69")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public TransformTrackRate CGDXYLOQKLD
		{
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x8A4F430", Offset = "0x8A4E830", VA = "0x188A4F430", Slot = "70")]
			get
			{
				return default(TransformTrackRate);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x8A51110", Offset = "0x8A50510", VA = "0x188A51110", Slot = "71")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public bool EJXMOZGYWKD
		{
			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x8A4D630", Offset = "0x8A4CA30", VA = "0x188A4D630", Slot = "72")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public Transform JWILKKTGZHX
		{
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0xC24EE0", Offset = "0xC242E0", VA = "0x180C24EE0", Slot = "73")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public Vector3 FBGWFBKYUIN
		{
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x8A503A0", Offset = "0x8A4F7A0", VA = "0x188A503A0", Slot = "74")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x8A509E0", Offset = "0x8A4FDE0", VA = "0x188A509E0", Slot = "75")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public float JFNFNHALNOT
		{
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x8A4D400", Offset = "0x8A4C800", VA = "0x188A4D400", Slot = "76")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x8A518F0", Offset = "0x8A50CF0", VA = "0x188A518F0", Slot = "77")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public float BCICBUXIYNK
		{
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x8A50D90", Offset = "0x8A50190", VA = "0x188A50D90", Slot = "78")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x8A4F630", Offset = "0x8A4EA30", VA = "0x188A4F630", Slot = "79")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public Quaternion HMGAGMHXMLK
		{
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x8A4CC80", Offset = "0x8A4C080", VA = "0x188A4CC80", Slot = "80")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x8A52380", Offset = "0x8A51780", VA = "0x188A52380", Slot = "81")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public Vector3 UJNTDLPNGHE
		{
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x8A52080", Offset = "0x8A51480", VA = "0x188A52080", Slot = "82")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x8A4E290", Offset = "0x8A4D690", VA = "0x188A4E290", Slot = "83")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public Quaternion ILSUHOUFHJR
		{
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x8A51290", Offset = "0x8A50690", VA = "0x188A51290", Slot = "84")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x8A50070", Offset = "0x8A4F470", VA = "0x188A50070", Slot = "85")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public RigidbodyConstraints UXRQCXKMIBY
		{
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x8A4E6B0", Offset = "0x8A4DAB0", VA = "0x188A4E6B0", Slot = "86")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x8A4EA80", Offset = "0x8A4DE80", VA = "0x188A4EA80", Slot = "87")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public bool QQWMQEWJXOV
		{
			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x8A4F530", Offset = "0x8A4E930", VA = "0x188A4F530", Slot = "88")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x8A50BD0", Offset = "0x8A4FFD0", VA = "0x188A50BD0", Slot = "89")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public CollisionDetectionMode BUQBOMKWSUW
		{
			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x8A51DB0", Offset = "0x8A511B0", VA = "0x188A51DB0", Slot = "90")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x8A4D4C0", Offset = "0x8A4C8C0", VA = "0x188A4D4C0", Slot = "91")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public bool HMKAPSXETUB
		{
			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x8A4DE60", Offset = "0x8A4D260", VA = "0x188A4DE60", Slot = "141")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public bool BPNQFULQQVO
		{
			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0x8A4D680", Offset = "0x8A4CA80", VA = "0x188A4D680", Slot = "92")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000017")]
		public event RbexAction UFVABTNCHJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x8A4CF80", Offset = "0x8A4C380", VA = "0x188A4CF80", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x8A4DD10", Offset = "0x8A4D110", VA = "0x188A4DD10", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000018")]
		public event RbexAction YQSIFTORTNS
		{
			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x8A4D580", Offset = "0x8A4C980", VA = "0x188A4D580", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x8A4EA20", Offset = "0x8A4DE20", VA = "0x188A4EA20", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000019")]
		public event RbexParentChangeAction SPYZLHERCQK
		{
			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x8A4C3A0", Offset = "0x8A4B7A0", VA = "0x188A4C3A0", Slot = "18")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x8A4F960", Offset = "0x8A4ED60", VA = "0x188A4F960", Slot = "19")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001A")]
		public event RbexAction HKMLKUBCHGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x8A4EC20", Offset = "0x8A4E020", VA = "0x188A4EC20", Slot = "8")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x8A52240", Offset = "0x8A51640", VA = "0x188A52240", Slot = "9")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001B")]
		public event RbexAction TANAEAFQUZO
		{
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x8A50C30", Offset = "0x8A50030", VA = "0x188A50C30", Slot = "14")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x8A50B70", Offset = "0x8A4FF70", VA = "0x188A50B70", Slot = "15")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001C")]
		public event RbexAction MGDQBBFJNPN
		{
			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x8A50580", Offset = "0x8A4F980", VA = "0x188A50580", Slot = "16")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x8A50980", Offset = "0x8A4FD80", VA = "0x188A50980", Slot = "17")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001D")]
		public event Action<UpdateLOD, UpdateLOD> LDZEKXBNUKW
		{
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x8A51EA0", Offset = "0x8A512A0", VA = "0x188A51EA0", Slot = "20")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x8A4CD20", Offset = "0x8A4C120", VA = "0x188A4CD20", Slot = "21")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001E")]
		public event RbexAction ZUXTCXUQVIJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x8A4F4D0", Offset = "0x8A4E8D0", VA = "0x188A4F4D0", Slot = "12")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x8A50340", Offset = "0x8A4F740", VA = "0x188A50340", Slot = "13")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001F")]
		public event RbexAction IFTUUWQQREU
		{
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x8A4FFC0", Offset = "0x8A4F3C0", VA = "0x188A4FFC0", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x8A52530", Offset = "0x8A51930", VA = "0x188A52530", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x8A52970", Offset = "0x8A51D70", VA = "0x188A52970")]
		public THCJMJLYUAO(GameObject a, RigidbodyEx b, DZKRLLHWCBC c, [In] RigidbodyExData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x8A4DFA0", Offset = "0x8A4D3A0", VA = "0x188A4DFA0", Slot = "139")]
		protected virtual void GFQZDFVJTIK(DZKRLLHWCBC a, RigidbodyExData b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x8A4D8B0", Offset = "0x8A4CCB0", VA = "0x188A4D8B0", Slot = "140")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x8A4C7F0", Offset = "0x8A4BBF0", VA = "0x188A4C7F0", Slot = "93")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x8A507E0", Offset = "0x8A4FBE0", VA = "0x188A507E0", Slot = "94")]
		public void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x8A50730", Offset = "0x8A4FB30", VA = "0x188A50730", Slot = "95")]
		public void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x8A50710", Offset = "0x8A4FB10", VA = "0x188A50710", Slot = "96")]
		public void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x8A4D9B0", Offset = "0x8A4CDB0", VA = "0x188A4D9B0")]
		private void EBNFZFMUEDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x8A4DC90", Offset = "0x8A4D090", VA = "0x188A4DC90")]
		private void ESPNETCMIGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x8A516B0", Offset = "0x8A50AB0", VA = "0x188A516B0")]
		private void UUKGBGBBVOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x8A4E4E0", Offset = "0x8A4D8E0", VA = "0x188A4E4E0", Slot = "30")]
		public MWIJDBIDZDF HNEJLTSOARG(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x8A51170", Offset = "0x8A50570", VA = "0x188A51170", Slot = "98")]
		public void SetParent(MWIJDBIDZDF value, bool isPhysicallyDetachedOnly = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x8A525E0", Offset = "0x8A519E0", VA = "0x188A525E0", Slot = "99")]
		public void ZGJQLXZMOVN(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x8A4EAE0", Offset = "0x8A4DEE0", VA = "0x188A4EAE0", Slot = "100")]
		public void ITULSOQBLLE(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x8A4F9C0", Offset = "0x8A4EDC0", VA = "0x188A4F9C0", Slot = "101")]
		public Vector3 LRMLHJIINQB(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x8A4D120", Offset = "0x8A4C520", VA = "0x188A4D120", Slot = "102")]
		public Vector3 CIFCKWXAXST(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x8A4CF30", Offset = "0x8A4C330", VA = "0x188A4CF30", Slot = "103")]
		public void BWEFLGWTBXW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x8A51D60", Offset = "0x8A51160", VA = "0x188A51D60", Slot = "104")]
		public void WLDDRETZDIV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x8A508E0", Offset = "0x8A4FCE0", VA = "0x188A508E0", Slot = "105")]
		public void PJOXMHGLFQY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x8A4DD70", Offset = "0x8A4D170", VA = "0x188A4DD70", Slot = "106")]
		public void GDHMYKPNYFK(Vector3 a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x8A50250", Offset = "0x8A4F650", VA = "0x188A50250", Slot = "107")]
		public void NZKWHSCZSZD(Vector3 a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x8A51F50", Offset = "0x8A51350", VA = "0x188A51F50", Slot = "108")]
		public void XGBEWNLQOLC(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x8A51A50", Offset = "0x8A50E50", VA = "0x188A51A50", Slot = "109")]
		public void WEPRVJNKZCW(RbexImpulseType a, Vector3 b, float c, float d = 8f, float e = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x8A4F860", Offset = "0x8A4EC60", VA = "0x188A4F860", Slot = "110")]
		public void LNZOYVKXZHZ(RbexRotationType a, Vector3 b, float c = 1f / 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x8A52780", Offset = "0x8A51B80", VA = "0x188A52780", Slot = "111")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void ZKWBPDUCICU(RbexRotationType a, Vector3 b, float c = 7f, float d = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x8A4D300", Offset = "0x8A4C700", VA = "0x188A4D300", Slot = "112")]
		public Vector3 CNBKTKVKPYZ(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x8A4C6F0", Offset = "0x8A4BAF0", VA = "0x188A4C6F0", Slot = "113")]
		public Vector3 APWNQULCBXF(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x8A50930", Offset = "0x8A4FD30", VA = "0x188A50930", Slot = "114")]
		public void PJXPHYOMJLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x8A519E0", Offset = "0x8A50DE0", VA = "0x188A519E0", Slot = "115")]
		public void VYVVXZRESCG(MWIJDBIDZDF a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x8A51980", Offset = "0x8A50D80", VA = "0x188A51980", Slot = "116")]
		public void VYBHMIWWNMX(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x8A52160", Offset = "0x8A51560", VA = "0x188A52160", Slot = "63")]
		public void YCRIHYGOZAF((Quaternion rot, Vector3 moments) tensor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x8A51F00", Offset = "0x8A51300", VA = "0x188A51F00", Slot = "117")]
		public void WZAGCFBATJV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x8A520C0", Offset = "0x8A514C0", VA = "0x188A520C0", Slot = "118")]
		public void XTSXEAXJHCY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x8A52110", Offset = "0x8A51510", VA = "0x188A52110", Slot = "119")]
		public void YCMGNIZKGPX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x8A505E0", Offset = "0x8A4F9E0", VA = "0x188A505E0", Slot = "120")]
		public bool OSBUHOXNNLB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x8A511E0", Offset = "0x8A505E0", VA = "0x188A511E0", Slot = "97")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x8A50870", Offset = "0x8A4FC70", VA = "0x188A50870", Slot = "121")]
		public void PHZGPXDVXYP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x8A4D520", Offset = "0x8A4C920", VA = "0x188A4D520", Slot = "122")]
		public void CRCHUBDAKHQ(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x8A4DC30", Offset = "0x8A4D030", VA = "0x188A4DC30", Slot = "123")]
		public void ELXGXTJKQMP(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x8A4E560", Offset = "0x8A4D960", VA = "0x188A4E560", Slot = "124")]
		public void HOSPLPTERRN(object a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x8A51370", Offset = "0x8A50770", VA = "0x188A51370", Slot = "125")]
		public void ULPNALVLYND(Vector3 a, Quaternion b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x8A4FD40", Offset = "0x8A4F140", VA = "0x188A4FD40", Slot = "126")]
		public void MKOKGCUYAUJ(Vector3 a, Quaternion b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x8A51E00", Offset = "0x8A51200", VA = "0x188A51E00", Slot = "127")]
		public bool WQBQWIFTSHK(float a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x8A4D850", Offset = "0x8A4CC50", VA = "0x188A4D850", Slot = "128")]
		public void DVMWDVAGVIJ(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x8A4C5C0", Offset = "0x8A4B9C0", VA = "0x188A4C5C0", Slot = "129")]
		public void AMKMFYSJONU(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x8A4F580", Offset = "0x8A4E980", VA = "0x188A4F580", Slot = "130")]
		public void LBTTOIQEHMV(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x8A51650", Offset = "0x8A50A50", VA = "0x188A51650", Slot = "131")]
		public void UQNEFILOZIE(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x8A504A0", Offset = "0x8A4F8A0", VA = "0x188A504A0", Slot = "132")]
		public void OJHCZMNXWZS(Vector3 a, ForceMode b = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x8A4FC30", Offset = "0x8A4F030", VA = "0x188A4FC30", Slot = "133")]
		public void MFHPWYYEDLU(Vector3 a, Vector3 b, ForceMode c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x8A50A90", Offset = "0x8A4FE90", VA = "0x188A50A90", Slot = "134")]
		public void QONTKXGZROT(Vector3 a, ForceMode b = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x8A4EB40", Offset = "0x8A4DF40", VA = "0x188A4EB40", Slot = "135")]
		public void IUILABLYMAT(Vector3 a, ForceMode b = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x8A4E2D0", Offset = "0x8A4D6D0", VA = "0x188A4E2D0", Slot = "136")]
		public bool GODKAIEGKGG(Vector3 a, [Out] RaycastHit b, float c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x8A50790", Offset = "0x8A4FB90", VA = "0x188A50790", Slot = "137")]
		public void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x8A512D0", Offset = "0x8A506D0", VA = "0x188A512D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x8A52640", Offset = "0x8A51A40", VA = "0x188A52640")]
		private void ZHGSKCBTOKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x8A51BF0", Offset = "0x8A50FF0", VA = "0x188A51BF0")]
		private void WGMGNLOGHBW(MWIJDBIDZDF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x8A51710", Offset = "0x8A50B10", VA = "0x188A51710")]
		private void VBSWIQCPUMT(MWIJDBIDZDF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x8A50C90", Offset = "0x8A50090", VA = "0x188A50C90")]
		private void SAMALTSACNW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x8A4F730", Offset = "0x8A4EB30", VA = "0x188A4F730")]
		private void LNOXFWJOPZD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x8A500A0", Offset = "0x8A4F4A0", VA = "0x188A500A0")]
		private void NOADKGKJSIB(MWIJDBIDZDF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x8A4CD80", Offset = "0x8A4C180", VA = "0x188A4CD80")]
		private void BUEGVYIRSFQ(MWIJDBIDZDF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x8A4E3C0", Offset = "0x8A4D7C0", VA = "0x188A4E3C0")]
		private void GZKHAINJBIW(MWIJDBIDZDF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x8A4FE70", Offset = "0x8A4F270", VA = "0x188A4FE70")]
		private void MLQXXISAOTN(JHZEISLHDPT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x8A4EF90", Offset = "0x8A4E390", VA = "0x188A4EF90", Slot = "142")]
		protected virtual void JUZBPSEPFXG(JHZEISLHDPT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x8A4E700", Offset = "0x8A4DB00", VA = "0x188A4E700")]
		protected void ILBHSIIEZMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x8A4C930", Offset = "0x8A4BD30", VA = "0x188A4C930")]
		protected void BJOGTUHNBWK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x8A4FAC0", Offset = "0x8A4EEC0", VA = "0x188A4FAC0")]
		private void LVVMIAECCQU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x8A50DF0", Offset = "0x8A501F0", VA = "0x188A50DF0")]
		private void SPYBLVOTBNL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	internal static class WBZXTWKDEWI
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x8A58720", Offset = "0x8A57B20", VA = "0x188A58720")]
		public static MWIJDBIDZDF FGITYLMUCRL(this MWIJDBIDZDF a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x8A585B0", Offset = "0x8A579B0", VA = "0x188A585B0")]
		public static bool AIILDITJBXS(this MWIJDBIDZDF a, MWIJDBIDZDF b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x8A587E0", Offset = "0x8A57BE0", VA = "0x188A587E0")]
		public static bool TZQKLELSZWS(this MWIJDBIDZDF a, MWIJDBIDZDF b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x8A58650", Offset = "0x8A57A50", VA = "0x188A58650")]
		public static JHZEISLHDPT AXREWFFODRW(this MWIJDBIDZDF a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x8A586A0", Offset = "0x8A57AA0", VA = "0x188A586A0")]
		public static THCJMJLYUAO Base(this MWIJDBIDZDF impl)
		{
			return null;
		}
	}
}
namespace RecRoom.Rbex.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class XSVTSUXDLUX : ZLLWIIHAJDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x8A59970", Offset = "0x8A58D70", VA = "0x188A59970", Slot = "19")]
		public MWIJDBIDZDF UNBHERHVLNS(RigidbodyEx a, RigidbodyExData b, DZKRLLHWCBC c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0xAA4920", Offset = "0xAA3D20", VA = "0x180AA4920", Slot = "4")]
		public SCDTKWWSIZB NWGKVZRWKIV(MWIJDBIDZDF a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0xAA4920", Offset = "0xAA3D20", VA = "0x180AA4920", Slot = "5")]
		public MJAZKPXHZUH IAKXXKZYEQB(MWIJDBIDZDF a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0xAA4920", Offset = "0xAA3D20", VA = "0x180AA4920", Slot = "6")]
		public RBQFLJQXITG RZHDJNOUOTU(MWIJDBIDZDF a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0xAA4920", Offset = "0xAA3D20", VA = "0x180AA4920", Slot = "7")]
		public BWHJHDJYXXL ALDULDHWJLJ(MWIJDBIDZDF a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0xAA4920", Offset = "0xAA3D20", VA = "0x180AA4920", Slot = "8")]
		public ILTJNVNSRQX IYPQOLXRZQB(MWIJDBIDZDF a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0xAA4920", Offset = "0xAA3D20", VA = "0x180AA4920", Slot = "9")]
		public KEYBYJOZPEI BLXKNLKMQBM(MWIJDBIDZDF a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0xAA4920", Offset = "0xAA3D20", VA = "0x180AA4920", Slot = "10")]
		public BIXXGTVQGNL WGBWRVOOEIX(MWIJDBIDZDF a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0xAA4920", Offset = "0xAA3D20", VA = "0x180AA4920", Slot = "11")]
		public XNNZMDWKDCL LUEPGEKCHUN(MWIJDBIDZDF a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0xAA4920", Offset = "0xAA3D20", VA = "0x180AA4920", Slot = "12")]
		public OVXBVHLSMBB IVWJCDNMFMZ(MWIJDBIDZDF a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0xAA4920", Offset = "0xAA3D20", VA = "0x180AA4920", Slot = "13")]
		public GAVUHFWVDQC AXILJCSWGCU(MWIJDBIDZDF a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0xAA4920", Offset = "0xAA3D20", VA = "0x180AA4920")]
		public RVAQDSIPZAU HFSLMXYPYXA(MWIJDBIDZDF a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0xAA4920", Offset = "0xAA3D20", VA = "0x180AA4920")]
		public NINZGGAFRVW PNTZWCAEQMW(MWIJDBIDZDF a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0xAA4920", Offset = "0xAA3D20", VA = "0x180AA4920")]
		public JOTLTNAESSC MYLFNXUYGLS(MWIJDBIDZDF a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0xAA4920", Offset = "0xAA3D20", VA = "0x180AA4920")]
		public WVZAHGAKZLM GIRAEIPMGYQ(MWIJDBIDZDF a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0xAA4920", Offset = "0xAA3D20", VA = "0x180AA4920")]
		public MBLXQUTZUAK LVMDPTJTMOY(MWIJDBIDZDF a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public XSVTSUXDLUX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0xAA4920", Offset = "0xAA3D20", VA = "0x180AA4920", Slot = "14")]
		private RVAQDSIPZAU HXWPZPKQBUC(MWIJDBIDZDF a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0xAA4920", Offset = "0xAA3D20", VA = "0x180AA4920", Slot = "15")]
		private NINZGGAFRVW GXXEOHJUXBI(MWIJDBIDZDF a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0xAA4920", Offset = "0xAA3D20", VA = "0x180AA4920", Slot = "16")]
		private JOTLTNAESSC LAPJVPAGJDG(MWIJDBIDZDF a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0xAA4920", Offset = "0xAA3D20", VA = "0x180AA4920", Slot = "17")]
		private WVZAHGAKZLM OMZXZHFOSTS(MWIJDBIDZDF a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0xAA4920", Offset = "0xAA3D20", VA = "0x180AA4920", Slot = "18")]
		private MBLXQUTZUAK FPTZMETLDUA(MWIJDBIDZDF a, [In] RigidbodyExData data)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[RegisterService(typeof(ZLLWIIHAJDE), new string[] { })]
	public class EMGVBCDIWKW : ZLLWIIHAJDE, UFLUIPVILQU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private readonly ZLLWIIHAJDE URECJNSLGLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private readonly ZLLWIIHAJDE IJAXFITURGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private CVPPYAMBGRC IBWYWOTAZKH;

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		private ZLLWIIHAJDE VVRELEDZHCY
		{
			[Cpp2IlInjected.Token(Token = "0x600021F")]
			[Cpp2IlInjected.Address(RVA = "0x8A3E9A0", Offset = "0x8A3DDA0", VA = "0x188A3E9A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x8A3EB40", Offset = "0x8A3DF40", VA = "0x188A3EB40", Slot = "20")]
		public void InitReferences(SAMXOKXXSFT services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x8A3ECE0", Offset = "0x8A3E0E0", VA = "0x188A3ECE0", Slot = "4")]
		public SCDTKWWSIZB NWGKVZRWKIV(MWIJDBIDZDF a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x8A3E900", Offset = "0x8A3DD00", VA = "0x188A3E900", Slot = "5")]
		public MJAZKPXHZUH IAKXXKZYEQB(MWIJDBIDZDF a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x8A3ED80", Offset = "0x8A3E180", VA = "0x188A3ED80", Slot = "6")]
		public RBQFLJQXITG RZHDJNOUOTU(MWIJDBIDZDF a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x8A3E460", Offset = "0x8A3D860", VA = "0x188A3E460", Slot = "7")]
		public BWHJHDJYXXL ALDULDHWJLJ(MWIJDBIDZDF a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x8A3EAA0", Offset = "0x8A3DEA0", VA = "0x188A3EAA0", Slot = "8")]
		public ILTJNVNSRQX IYPQOLXRZQB(MWIJDBIDZDF a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x8A3E5A0", Offset = "0x8A3D9A0", VA = "0x188A3E5A0", Slot = "9")]
		public KEYBYJOZPEI BLXKNLKMQBM(MWIJDBIDZDF a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x8A3EF00", Offset = "0x8A3E300", VA = "0x188A3EF00", Slot = "10")]
		public BIXXGTVQGNL WGBWRVOOEIX(MWIJDBIDZDF a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x8A3EC40", Offset = "0x8A3E040", VA = "0x188A3EC40", Slot = "11")]
		public XNNZMDWKDCL LUEPGEKCHUN(MWIJDBIDZDF a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x8A3EA00", Offset = "0x8A3DE00", VA = "0x188A3EA00", Slot = "12")]
		public OVXBVHLSMBB IVWJCDNMFMZ(MWIJDBIDZDF a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x8A3E500", Offset = "0x8A3D900", VA = "0x188A3E500", Slot = "13")]
		public GAVUHFWVDQC AXILJCSWGCU(MWIJDBIDZDF a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x8A3E850", Offset = "0x8A3DC50", VA = "0x188A3E850")]
		public RVAQDSIPZAU HFSLMXYPYXA(MWIJDBIDZDF a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x8A3E7A0", Offset = "0x8A3DBA0", VA = "0x188A3E7A0")]
		public NINZGGAFRVW PNTZWCAEQMW(MWIJDBIDZDF a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x8A3EB90", Offset = "0x8A3DF90", VA = "0x188A3EB90")]
		public JOTLTNAESSC MYLFNXUYGLS(MWIJDBIDZDF a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x8A3E6F0", Offset = "0x8A3DAF0", VA = "0x188A3E6F0")]
		public WVZAHGAKZLM GIRAEIPMGYQ(MWIJDBIDZDF a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x8A3E640", Offset = "0x8A3DA40", VA = "0x188A3E640")]
		public MBLXQUTZUAK LVMDPTJTMOY(MWIJDBIDZDF a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x8A3EE20", Offset = "0x8A3E220", VA = "0x188A3EE20", Slot = "19")]
		public MWIJDBIDZDF UNBHERHVLNS(RigidbodyEx a, RigidbodyExData b, DZKRLLHWCBC c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x8A3EFA0", Offset = "0x8A3E3A0", VA = "0x188A3EFA0")]
		public EMGVBCDIWKW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x8A3E850", Offset = "0x8A3DC50", VA = "0x188A3E850", Slot = "14")]
		private RVAQDSIPZAU HXWPZPKQBUC(MWIJDBIDZDF a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x8A3E7A0", Offset = "0x8A3DBA0", VA = "0x188A3E7A0", Slot = "15")]
		private NINZGGAFRVW GXXEOHJUXBI(MWIJDBIDZDF a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x8A3EB90", Offset = "0x8A3DF90", VA = "0x188A3EB90", Slot = "16")]
		private JOTLTNAESSC LAPJVPAGJDG(MWIJDBIDZDF a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x8A3E6F0", Offset = "0x8A3DAF0", VA = "0x188A3E6F0", Slot = "17")]
		private WVZAHGAKZLM OMZXZHFOSTS(MWIJDBIDZDF a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x8A3E640", Offset = "0x8A3DA40", VA = "0x188A3E640", Slot = "18")]
		private MBLXQUTZUAK FPTZMETLDUA(MWIJDBIDZDF a, [In] RigidbodyExData data)
		{
			return null;
		}
	}
}
namespace RecRoom.Rbex.Legacy
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public interface WQHHYGTPIBI : SCDTKWWSIZB, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void JGRLELRKPON(MWIJDBIDZDF a);

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void MVKDYJAGDFC(MWIJDBIDZDF a);

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void YUKIYCDQCGH(MWIJDBIDZDF a);

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void QZDXUVRSDFU(MWIJDBIDZDF a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public interface HYCDMYRPETL : RBQFLJQXITG
	{
		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		JIBNYOHEORT<MWIJDBIDZDF> MTNSFWHFHCA
		{
			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		MWIJDBIDZDF GOUTNTXNIDQ
		{
			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public interface PWONACWMATD : WVZAHGAKZLM
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		(float, Vector3) PIIMNQXVNFO(Rigidbody a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public interface ITAGKVSCAGN : NINZGGAFRVW, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		RRNetworkView MLKDMANEVLX
		{
			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	internal sealed class OXFVIBOYIRW : OVXBVHLSMBB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private readonly THCJMJLYUAO NUWRCYXCGDR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private CollisionDetectionMode GQUKVIEGIUI;

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		private Rigidbody QNEZXRYKHXI
		{
			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0x8A419D0", Offset = "0x8A40DD0", VA = "0x188A419D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		public CollisionDetectionMode BUQBOMKWSUW
		{
			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0x8A43BD0", Offset = "0x8A42FD0", VA = "0x188A43BD0", Slot = "4")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0x8A43840", Offset = "0x8A42C40", VA = "0x188A43840", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x8A3DEE0", Offset = "0x8A3D2E0", VA = "0x188A3DEE0")]
		public OXFVIBOYIRW(MWIJDBIDZDF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x8A43730", Offset = "0x8A42B30", VA = "0x188A43730", Slot = "6")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x8A43A10", Offset = "0x8A42E10", VA = "0x188A43A10", Slot = "9")]
		public void HCYVTHGDDGP(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x8A43A90", Offset = "0x8A42E90", VA = "0x188A43A90", Slot = "7")]
		public void ISFOUVLLHCO(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x8A43BC0", Offset = "0x8A42FC0", VA = "0x188A43BC0", Slot = "8")]
		public void UKMZQDXZACN(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x8A438B0", Offset = "0x8A42CB0", VA = "0x188A438B0", Slot = "10")]
		public bool GODKAIEGKGG(Vector3 a, [Out] RaycastHit b, float c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x8A43AA0", Offset = "0x8A42EA0", VA = "0x188A43AA0")]
		private void MSISAYDTXFQ(bool a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public sealed class QPIMUMMZPMR : KEYBYJOZPEI, IDisposable, JUXEBJYBFAS
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly THCJMJLYUAO NUWRCYXCGDR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private TransformTrackRate HGJDOABLMVP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private MDFTLYVXJZR OUTRPFLNAQF;

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		public TransformTrackRate CGDXYLOQKLD
		{
			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0x8A449A0", Offset = "0x8A43DA0", VA = "0x188A449A0", Slot = "6")]
			get
			{
				return default(TransformTrackRate);
			}
			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0x8A44AF0", Offset = "0x8A43EF0", VA = "0x188A44AF0", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000092")]
		private Transform EOSFFYUJOXQ
		{
			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x8A44980", Offset = "0x8A43D80", VA = "0x188A44980", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000020")]
		public event Action<UpdateLOD, UpdateLOD> LDZEKXBNUKW
		{
			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0x8A44BC0", Offset = "0x8A43FC0", VA = "0x188A44BC0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0x8A44880", Offset = "0x8A43C80", VA = "0x188A44880", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x8A44C70", Offset = "0x8A44070", VA = "0x188A44C70")]
		public QPIMUMMZPMR(MWIJDBIDZDF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x8A44610", Offset = "0x8A43A10", VA = "0x188A44610", Slot = "8")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x8A44930", Offset = "0x8A43D30", VA = "0x188A44930", Slot = "9")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x10A13C0", Offset = "0x10A07C0", VA = "0x1810A13C0", Slot = "11")]
		private void MNZQPRYLUBX(UpdateLOD a, UpdateLOD b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "12")]
		private void XRANXZLZJQJ(bool a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class XSVTSUXDLUX : ZLLWIIHAJDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x8A59770", Offset = "0x8A58B70", VA = "0x188A59770", Slot = "4")]
		public SCDTKWWSIZB NWGKVZRWKIV(MWIJDBIDZDF a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x8A59300", Offset = "0x8A58700", VA = "0x188A59300", Slot = "5")]
		public MJAZKPXHZUH IAKXXKZYEQB(MWIJDBIDZDF a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x8A59850", Offset = "0x8A58C50", VA = "0x188A59850", Slot = "6")]
		public RBQFLJQXITG RZHDJNOUOTU(MWIJDBIDZDF a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x8A58C10", Offset = "0x8A58010", VA = "0x188A58C10", Slot = "7")]
		public BWHJHDJYXXL ALDULDHWJLJ(MWIJDBIDZDF a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x8A594D0", Offset = "0x8A588D0", VA = "0x188A594D0", Slot = "8")]
		public ILTJNVNSRQX IYPQOLXRZQB(MWIJDBIDZDF a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x8A58D40", Offset = "0x8A58140", VA = "0x188A58D40", Slot = "9")]
		public KEYBYJOZPEI BLXKNLKMQBM(MWIJDBIDZDF a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x8A59B40", Offset = "0x8A58F40", VA = "0x188A59B40", Slot = "10")]
		public BIXXGTVQGNL WGBWRVOOEIX(MWIJDBIDZDF a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x8A596B0", Offset = "0x8A58AB0", VA = "0x188A596B0", Slot = "11")]
		public XNNZMDWKDCL LUEPGEKCHUN(MWIJDBIDZDF a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x8A59410", Offset = "0x8A58810", VA = "0x188A59410", Slot = "12")]
		public OVXBVHLSMBB IVWJCDNMFMZ(MWIJDBIDZDF a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x8A58C80", Offset = "0x8A58080", VA = "0x188A58C80", Slot = "13")]
		public GAVUHFWVDQC AXILJCSWGCU(MWIJDBIDZDF a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x8A591D0", Offset = "0x8A585D0", VA = "0x188A591D0")]
		public RVAQDSIPZAU HFSLMXYPYXA(MWIJDBIDZDF a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x8A59050", Offset = "0x8A58450", VA = "0x188A59050")]
		public NINZGGAFRVW PNTZWCAEQMW(MWIJDBIDZDF a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x8A59590", Offset = "0x8A58990", VA = "0x188A59590")]
		public JOTLTNAESSC MYLFNXUYGLS(MWIJDBIDZDF a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x8A58ED0", Offset = "0x8A582D0", VA = "0x188A58ED0")]
		public WVZAHGAKZLM GIRAEIPMGYQ(MWIJDBIDZDF a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x8A58E00", Offset = "0x8A58200", VA = "0x188A58E00")]
		public MBLXQUTZUAK LVMDPTJTMOY(MWIJDBIDZDF a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x8A59A00", Offset = "0x8A58E00", VA = "0x188A59A00", Slot = "19")]
		public MWIJDBIDZDF UNBHERHVLNS(RigidbodyEx a, RigidbodyExData b, DZKRLLHWCBC c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public XSVTSUXDLUX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x8A591D0", Offset = "0x8A585D0", VA = "0x188A591D0", Slot = "14")]
		private RVAQDSIPZAU HXWPZPKQBUC(MWIJDBIDZDF a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x8A59050", Offset = "0x8A58450", VA = "0x188A59050", Slot = "15")]
		private NINZGGAFRVW GXXEOHJUXBI(MWIJDBIDZDF a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x8A59590", Offset = "0x8A58990", VA = "0x188A59590", Slot = "16")]
		private JOTLTNAESSC LAPJVPAGJDG(MWIJDBIDZDF a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x8A58ED0", Offset = "0x8A582D0", VA = "0x188A58ED0", Slot = "17")]
		private WVZAHGAKZLM OMZXZHFOSTS(MWIJDBIDZDF a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x8A58E00", Offset = "0x8A58200", VA = "0x188A58E00", Slot = "18")]
		private MBLXQUTZUAK FPTZMETLDUA(MWIJDBIDZDF a, [In] RigidbodyExData data)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal sealed class GMQCRDCRMPE : XNNZMDWKDCL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private readonly THCJMJLYUAO NUWRCYXCGDR;

		[Cpp2IlInjected.Token(Token = "0x17000093")]
		private Rigidbody QNEZXRYKHXI
		{
			[Cpp2IlInjected.Token(Token = "0x6000268")]
			[Cpp2IlInjected.Address(RVA = "0x8A419D0", Offset = "0x8A40DD0", VA = "0x188A419D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000094")]
		private bool EJXMOZGYWKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000269")]
			[Cpp2IlInjected.Address(RVA = "0x8A41A20", Offset = "0x8A40E20", VA = "0x188A41A20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000095")]
		private bool WPVPLREWLPM
		{
			[Cpp2IlInjected.Token(Token = "0x600026A")]
			[Cpp2IlInjected.Address(RVA = "0x8A42730", Offset = "0x8A41B30", VA = "0x188A42730")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000096")]
		private MWIJDBIDZDF YSZAMEVATVQ
		{
			[Cpp2IlInjected.Token(Token = "0x600026B")]
			[Cpp2IlInjected.Address(RVA = "0x8A41A70", Offset = "0x8A40E70", VA = "0x188A41A70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x8A3DEE0", Offset = "0x8A3D2E0", VA = "0x188A3DEE0")]
		public GMQCRDCRMPE(MWIJDBIDZDF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x8A42210", Offset = "0x8A41610", VA = "0x188A42210", Slot = "4")]
		public void OJHCZMNXWZS(Vector3 a, ForceMode b = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x8A41D30", Offset = "0x8A41130", VA = "0x188A41D30")]
		private void LVMFQHGYMCD(Vector3 a, ForceMode b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x8A41F90", Offset = "0x8A41390", VA = "0x188A41F90", Slot = "5")]
		public void MFHPWYYEDLU(Vector3 a, Vector3 b, ForceMode c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x8A42370", Offset = "0x8A41770", VA = "0x188A42370", Slot = "6")]
		public void QONTKXGZROT(Vector3 a, ForceMode b = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x8A424D0", Offset = "0x8A418D0", VA = "0x188A424D0")]
		private void RGDYOUZCEEC(Vector3 a, ForceMode b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x8A41AD0", Offset = "0x8A40ED0", VA = "0x188A41AD0", Slot = "7")]
		public void IUILABLYMAT(Vector3 a, ForceMode b = ForceMode.Force)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	internal sealed class AZWJMXNFDIL : GAVUHFWVDQC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private readonly THCJMJLYUAO NUWRCYXCGDR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private bool FHONOYOSOWF;

		[Cpp2IlInjected.Token(Token = "0x17000097")]
		public bool DSJHKGQLUHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000274")]
			[Cpp2IlInjected.Address(RVA = "0xBC19C0", Offset = "0xBC0DC0", VA = "0x180BC19C0", Slot = "4")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000275")]
			[Cpp2IlInjected.Address(RVA = "0x8A3DDD0", Offset = "0x8A3D1D0", VA = "0x188A3DDD0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x8A3DEE0", Offset = "0x8A3D2E0", VA = "0x188A3DEE0")]
		public AZWJMXNFDIL(MWIJDBIDZDF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x8A3DDA0", Offset = "0x8A3D1A0", VA = "0x188A3DDA0", Slot = "6")]
		public void HCYVTHGDDGP(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x8A3DD30", Offset = "0x8A3D130", VA = "0x188A3DD30", Slot = "7")]
		public void CJWOGKOXWPK(Rigidbody a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	internal sealed class RbexHierarchy : WQHHYGTPIBI, SCDTKWWSIZB, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private readonly MWIJDBIDZDF NUWRCYXCGDR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private readonly List<MWIJDBIDZDF> QCAAVYCOZVT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private MWIJDBIDZDF XUVHPHBAVDY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private MWIJDBIDZDF ORUDLVOERZA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private Transform EUUILXDFPFX;

		[Cpp2IlInjected.Token(Token = "0x17000098")]
		private Transform SFEPHHTYQFE
		{
			[Cpp2IlInjected.Token(Token = "0x600028A")]
			[Cpp2IlInjected.Address(RVA = "0x8A45FE0", Offset = "0x8A453E0", VA = "0x188A45FE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000099")]
		public MWIJDBIDZDF YSZAMEVATVQ
		{
			[Cpp2IlInjected.Token(Token = "0x600028D")]
			[Cpp2IlInjected.Address(RVA = "0xAA5380", Offset = "0xAA4780", VA = "0x180AA5380", Slot = "28")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600028E")]
			[Cpp2IlInjected.Address(RVA = "0x8A44FC0", Offset = "0x8A443C0", VA = "0x188A44FC0", Slot = "29")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009A")]
		public MWIJDBIDZDF JNBRJWHHBWC
		{
			[Cpp2IlInjected.Token(Token = "0x600028F")]
			[Cpp2IlInjected.Address(RVA = "0xAA3120", Offset = "0xAA2520", VA = "0x180AA3120", Slot = "27")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		public IReadOnlyList<MWIJDBIDZDF> TLEJKUCJCCG
		{
			[Cpp2IlInjected.Token(Token = "0x6000290")]
			[Cpp2IlInjected.Address(RVA = "0xAA3380", Offset = "0xAA2780", VA = "0x180AA3380", Slot = "26")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000021")]
		public event RbexAction UFVABTNCHJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000278")]
			[Cpp2IlInjected.Address(RVA = "0x8A44F20", Offset = "0x8A44320", VA = "0x188A44F20", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000279")]
			[Cpp2IlInjected.Address(RVA = "0x8A45260", Offset = "0x8A44660", VA = "0x188A45260", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000022")]
		public event RbexAction YQSIFTORTNS
		{
			[Cpp2IlInjected.Token(Token = "0x600027A")]
			[Cpp2IlInjected.Address(RVA = "0x8A44FD0", Offset = "0x8A443D0", VA = "0x188A44FD0", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600027B")]
			[Cpp2IlInjected.Address(RVA = "0x8A453A0", Offset = "0x8A447A0", VA = "0x188A453A0", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000023")]
		public event RbexParentChangeAction SPYZLHERCQK
		{
			[Cpp2IlInjected.Token(Token = "0x600027C")]
			[Cpp2IlInjected.Address(RVA = "0x8A44DC0", Offset = "0x8A441C0", VA = "0x188A44DC0", Slot = "12")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600027D")]
			[Cpp2IlInjected.Address(RVA = "0x8A45710", Offset = "0x8A44B10", VA = "0x188A45710", Slot = "13")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000024")]
		public event Action KSFESOUZWNB
		{
			[Cpp2IlInjected.Token(Token = "0x600027E")]
			[Cpp2IlInjected.Address(RVA = "0x8A45300", Offset = "0x8A44700", VA = "0x188A45300", Slot = "14")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600027F")]
			[Cpp2IlInjected.Address(RVA = "0x8A46690", Offset = "0x8A45A90", VA = "0x188A46690", Slot = "15")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000025")]
		public event Action VOFHPGHOTME
		{
			[Cpp2IlInjected.Token(Token = "0x6000280")]
			[Cpp2IlInjected.Address(RVA = "0x8A45C20", Offset = "0x8A45020", VA = "0x188A45C20", Slot = "16")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000281")]
			[Cpp2IlInjected.Address(RVA = "0x8A45F40", Offset = "0x8A45340", VA = "0x188A45F40", Slot = "17")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000026")]
		public event Action<MWIJDBIDZDF> KPFHYKEKNIN
		{
			[Cpp2IlInjected.Token(Token = "0x6000282")]
			[Cpp2IlInjected.Address(RVA = "0x8A451B0", Offset = "0x8A445B0", VA = "0x188A451B0", Slot = "18")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000283")]
			[Cpp2IlInjected.Address(RVA = "0x8A45A20", Offset = "0x8A44E20", VA = "0x188A45A20", Slot = "19")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000027")]
		public event Action<MWIJDBIDZDF> IZFBYTMZSZQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000284")]
			[Cpp2IlInjected.Address(RVA = "0x8A458D0", Offset = "0x8A44CD0", VA = "0x188A458D0", Slot = "20")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000285")]
			[Cpp2IlInjected.Address(RVA = "0x8A45B70", Offset = "0x8A44F70", VA = "0x188A45B70", Slot = "21")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000028")]
		public event Action XREAUUDWOEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000286")]
			[Cpp2IlInjected.Address(RVA = "0x8A45110", Offset = "0x8A44510", VA = "0x188A45110", Slot = "22")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000287")]
			[Cpp2IlInjected.Address(RVA = "0x8A45AD0", Offset = "0x8A44ED0", VA = "0x188A45AD0", Slot = "23")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000029")]
		public event Action<MWIJDBIDZDF> XOWXGNSXXDM
		{
			[Cpp2IlInjected.Token(Token = "0x6000288")]
			[Cpp2IlInjected.Address(RVA = "0x8A46730", Offset = "0x8A45B30", VA = "0x188A46730", Slot = "24")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000289")]
			[Cpp2IlInjected.Address(RVA = "0x8A45660", Offset = "0x8A44A60", VA = "0x188A45660", Slot = "25")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x8A46B90", Offset = "0x8A45F90", VA = "0x188A46B90")]
		public RbexHierarchy(MWIJDBIDZDF rbex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x8A45070", Offset = "0x8A44470", VA = "0x188A45070", Slot = "31")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x8A46040", Offset = "0x8A45440", VA = "0x188A46040", Slot = "30")]
		public void SetParent(MWIJDBIDZDF newParent, bool isPhysicallyDetachedOnly = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x8A467E0", Offset = "0x8A45BE0", VA = "0x188A467E0", Slot = "6")]
		public void YUKIYCDQCGH(MWIJDBIDZDF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x8A45CC0", Offset = "0x8A450C0", VA = "0x188A45CC0", Slot = "7")]
		public void QZDXUVRSDFU(MWIJDBIDZDF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x8A45440", Offset = "0x8A44840", VA = "0x188A45440", Slot = "4")]
		public void JGRLELRKPON(MWIJDBIDZDF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x8A45980", Offset = "0x8A44D80", VA = "0x188A45980", Slot = "5")]
		public void MVKDYJAGDFC(MWIJDBIDZDF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x8A465B0", Offset = "0x8A459B0", VA = "0x188A465B0")]
		private void TMZIEECHPQX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x8A46650", Offset = "0x8A45A50", VA = "0x188A46650")]
		private void TQBLWHMVRWK(MWIJDBIDZDF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x8A46A50", Offset = "0x8A45E50", VA = "0x188A46A50")]
		private void YZOLQZTPPBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x8A45530", Offset = "0x8A44930", VA = "0x188A45530")]
		private void KUHSTURLTQA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x8A457B0", Offset = "0x8A44BB0", VA = "0x188A457B0")]
		private void MIYKOUKHGCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x8A44E60", Offset = "0x8A44260", VA = "0x188A44E60")]
		[CompilerGenerated]
		private object BXIDCQIGQHM()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	internal static class RMKNQDEOTJC
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x8A44D00", Offset = "0x8A44100", VA = "0x188A44D00")]
		public static WQHHYGTPIBI KWUYBNVJDUF(this MWIJDBIDZDF a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	internal sealed class TQPYGODRNTH : HYCDMYRPETL, RBQFLJQXITG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly THCJMJLYUAO NUWRCYXCGDR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private readonly JIBNYOHEORT<MWIJDBIDZDF> UBQFSAJWPJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private bool WAOLJUYGVLH;

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		public JIBNYOHEORT<MWIJDBIDZDF> MTNSFWHFHCA
		{
			[Cpp2IlInjected.Token(Token = "0x600029D")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		public Vector3 DJBEWVCRZBZ
		{
			[Cpp2IlInjected.Token(Token = "0x600029E")]
			[Cpp2IlInjected.Address(RVA = "0x8A52A60", Offset = "0x8A51E60", VA = "0x188A52A60", Slot = "6")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		public Vector3 IGAFVSWPCWR
		{
			[Cpp2IlInjected.Token(Token = "0x600029F")]
			[Cpp2IlInjected.Address(RVA = "0x8A53430", Offset = "0x8A52830", VA = "0x188A53430", Slot = "7")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		private Vector3 GJPNWNLMIRP
		{
			[Cpp2IlInjected.Token(Token = "0x60002A3")]
			[Cpp2IlInjected.Address(RVA = "0x8A52E30", Offset = "0x8A52230", VA = "0x188A52E30")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		public MWIJDBIDZDF GOUTNTXNIDQ
		{
			[Cpp2IlInjected.Token(Token = "0x60002A4")]
			[Cpp2IlInjected.Address(RVA = "0x8A52FE0", Offset = "0x8A523E0", VA = "0x188A52FE0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x8A53730", Offset = "0x8A52B30", VA = "0x188A53730")]
		public TQPYGODRNTH(MWIJDBIDZDF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x8A52F70", Offset = "0x8A52370", VA = "0x188A52F70", Slot = "8")]
		public void OKKBOAGOFCF(MWIJDBIDZDF a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x8A52F10", Offset = "0x8A52310", VA = "0x188A52F10", Slot = "9")]
		public void NNZREIXBJOS(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x8A52A90", Offset = "0x8A51E90", VA = "0x188A52A90")]
		private Vector3 GKBSSRDFQTN()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x8A53090", Offset = "0x8A52490", VA = "0x188A53090")]
		private void VZLNOCAFUYQ(MWIJDBIDZDF a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	internal static class WFABJVRVNNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x8A58880", Offset = "0x8A57C80", VA = "0x188A58880")]
		public static HYCDMYRPETL LCQSAXTGZXM(this MWIJDBIDZDF a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	internal sealed class FNAQROCQREV : PWONACWMATD, WVZAHGAKZLM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private readonly THCJMJLYUAO NUWRCYXCGDR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private readonly OverridableVector3 PZKAMCSGFVC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private readonly OverridableVector3 JOGQWZVXSOV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private float FXJGUSVJCXD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private float ABRPBAFJXOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private Vector3 JDRTKWGZJEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private Vector3? RRYYUZQLUHT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private Quaternion? FNBELWEMTNV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private bool AHUVEBZZGLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private bool NPIMOEHWMCL;

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		public Vector3 JVLPJAUZBDH
		{
			[Cpp2IlInjected.Token(Token = "0x60002AA")]
			[Cpp2IlInjected.Address(RVA = "0x1C74960", Offset = "0x1C73D60", VA = "0x181C74960", Slot = "7")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60002AB")]
			[Cpp2IlInjected.Address(RVA = "0x8A3F200", Offset = "0x8A3E600", VA = "0x188A3F200", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		public Vector3 TFTMCTTECYS
		{
			[Cpp2IlInjected.Token(Token = "0x60002AC")]
			[Cpp2IlInjected.Address(RVA = "0x8A3F0E0", Offset = "0x8A3E4E0", VA = "0x188A3F0E0", Slot = "9")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		public float LTXYVPLQEGK
		{
			[Cpp2IlInjected.Token(Token = "0x60002AD")]
			[Cpp2IlInjected.Address(RVA = "0xAF53B0", Offset = "0xAF47B0", VA = "0x180AF53B0", Slot = "10")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60002AE")]
			[Cpp2IlInjected.Address(RVA = "0x8A40C40", Offset = "0x8A40040", VA = "0x188A40C40")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A4")]
		public float NEBHKMAZSPD
		{
			[Cpp2IlInjected.Token(Token = "0x60002AF")]
			[Cpp2IlInjected.Address(RVA = "0xAF53C0", Offset = "0xAF47C0", VA = "0x180AF53C0", Slot = "11")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60002B0")]
			[Cpp2IlInjected.Address(RVA = "0x8A40D50", Offset = "0x8A40150", VA = "0x188A40D50", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		public Vector3 CUBUQBRLKCN
		{
			[Cpp2IlInjected.Token(Token = "0x60002B1")]
			[Cpp2IlInjected.Address(RVA = "0x8A3F6E0", Offset = "0x8A3EAE0", VA = "0x188A3F6E0", Slot = "13")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A6")]
		public Quaternion FYCJLHUPUKH
		{
			[Cpp2IlInjected.Token(Token = "0x60002B2")]
			[Cpp2IlInjected.Address(RVA = "0x8A41550", Offset = "0x8A40950", VA = "0x188A41550", Slot = "14")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A7")]
		private Rigidbody QNEZXRYKHXI
		{
			[Cpp2IlInjected.Token(Token = "0x60002BA")]
			[Cpp2IlInjected.Address(RVA = "0x8A3F490", Offset = "0x8A3E890", VA = "0x188A3F490")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400002A")]
		public event RbexAction PGDUENDWDHO
		{
			[Cpp2IlInjected.Token(Token = "0x60002A8")]
			[Cpp2IlInjected.Address(RVA = "0x8A40BA0", Offset = "0x8A3FFA0", VA = "0x188A40BA0", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60002A9")]
			[Cpp2IlInjected.Address(RVA = "0x8A3F040", Offset = "0x8A3E440", VA = "0x188A3F040", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x8A41870", Offset = "0x8A40C70", VA = "0x188A41870")]
		public FNAQROCQREV(MWIJDBIDZDF a, [In] RigidbodyExData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x8A40E00", Offset = "0x8A40200", VA = "0x188A40E00", Slot = "17")]
		public void WZAGCFBATJV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x8A410A0", Offset = "0x8A404A0", VA = "0x188A410A0", Slot = "16")]
		public void XTSXEAXJHCY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x8A3F4E0", Offset = "0x8A3E8E0", VA = "0x188A3F4E0", Slot = "19")]
		public void HCYVTHGDDGP(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x8A3F2B0", Offset = "0x8A3E6B0", VA = "0x188A3F2B0", Slot = "20")]
		public void CJWOGKOXWPK(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x8A41180", Offset = "0x8A40580", VA = "0x188A41180", Slot = "18")]
		public void YCMGNIZKGPX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x8A3F870", Offset = "0x8A3EC70", VA = "0x188A3F870", Slot = "21")]
		public void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x8A3F200", Offset = "0x8A3E600", VA = "0x188A3F200")]
		private void VAYORIWRUHL(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x8A3F5C0", Offset = "0x8A3E9C0", VA = "0x188A3F5C0")]
		[Obsolete("This method is dangerous - the unity rigidbody is updated in a deferred manner and this world position may be stale")]
		private Vector3 JKEALPQVZQK()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x8A40C40", Offset = "0x8A40040", VA = "0x188A40C40")]
		private void TVKHRXUBYEO(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x8A40D50", Offset = "0x8A40150", VA = "0x188A40D50")]
		private void WBQPGMPOQLT(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x8A416D0", Offset = "0x8A40AD0", VA = "0x188A416D0")]
		private Vector3 ZIJVKWQQVKF()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x8A41320", Offset = "0x8A40720", VA = "0x188A41320", Slot = "15")]
		public void YCRIHYGOZAF((Quaternion rot, Vector3 moments) tensor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x8A40F20", Offset = "0x8A40320", VA = "0x188A40F20")]
		private Quaternion XEUZFRAAPNJ()
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x8A40AD0", Offset = "0x8A3FED0", VA = "0x188A40AD0")]
		public void PIIMNQXVNFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x8A3FD30", Offset = "0x8A3F130", VA = "0x188A3FD30", Slot = "4")]
		public (float, Vector3) PIIMNQXVNFO(Rigidbody a)
		{
			return default((float, Vector3));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	internal static class LEMAUIQLPTF
	{
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x8A42850", Offset = "0x8A41C50", VA = "0x188A42850")]
		public static PWONACWMATD OLEBLBUNWMU(this MWIJDBIDZDF a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	internal sealed class OYUMAZWJIKD : JOTLTNAESSC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private readonly THCJMJLYUAO NUWRCYXCGDR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private readonly YPHQWUVMKZC TWZZWBBQVPY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private readonly RbexInterpolationMode WRWJVMJGKGL;

		[Cpp2IlInjected.Token(Token = "0x170000A8")]
		public bool VVXWWNPOHZV
		{
			[Cpp2IlInjected.Token(Token = "0x60002C5")]
			[Cpp2IlInjected.Address(RVA = "0x17FEAB0", Offset = "0x17FDEB0", VA = "0x1817FEAB0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A9")]
		public RbexInterpolationMode BALPIKTSLUR
		{
			[Cpp2IlInjected.Token(Token = "0x60002C6")]
			[Cpp2IlInjected.Address(RVA = "0xAB5660", Offset = "0xAB4A60", VA = "0x180AB5660", Slot = "11")]
			get
			{
				return default(RbexInterpolationMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x8A442F0", Offset = "0x8A436F0", VA = "0x188A442F0")]
		public OYUMAZWJIKD(MWIJDBIDZDF a, [In] RigidbodyExData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x8A43D20", Offset = "0x8A43120", VA = "0x188A43D20", Slot = "4")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x8A43DF0", Offset = "0x8A431F0", VA = "0x188A43DF0")]
		private bool HQLMCZIRETJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x8A44010", Offset = "0x8A43410", VA = "0x188A44010", Slot = "5")]
		public void UJRPFGXFAMF(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x8A43FE0", Offset = "0x8A433E0", VA = "0x188A43FE0", Slot = "6")]
		public void RCFFMHSKXBW(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x8A441C0", Offset = "0x8A435C0", VA = "0x188A441C0", Slot = "9")]
		public void XNVEWKQOWBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x8A43ED0", Offset = "0x8A432D0", VA = "0x188A43ED0")]
		private void NMBKCCBWWYP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x8A44040", Offset = "0x8A43440", VA = "0x188A44040")]
		private void VQZSNMZPKEX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x8A43CE0", Offset = "0x8A430E0", VA = "0x188A43CE0", Slot = "8")]
		public void ANPJCEHELJZ(MWIJDBIDZDF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x8A43E90", Offset = "0x8A43290", VA = "0x188A43E90", Slot = "7")]
		public void IFQLRXAIKHG(MWIJDBIDZDF a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	internal sealed class BQIXZJZWWYI : BIXXGTVQGNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private readonly THCJMJLYUAO NUWRCYXCGDR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private readonly YPHQWUVMKZC RADTKYPLCBX;

		[Cpp2IlInjected.Token(Token = "0x170000AA")]
		public bool EJXMOZGYWKD
		{
			[Cpp2IlInjected.Token(Token = "0x60002D3")]
			[Cpp2IlInjected.Address(RVA = "0x8A3DFB0", Offset = "0x8A3D3B0", VA = "0x188A3DFB0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400002B")]
		public event RbexAction ZUXTCXUQVIJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002D1")]
			[Cpp2IlInjected.Address(RVA = "0x8A3E240", Offset = "0x8A3D640", VA = "0x188A3E240", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60002D2")]
			[Cpp2IlInjected.Address(RVA = "0x8A3E2E0", Offset = "0x8A3D6E0", VA = "0x188A3E2E0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x8A3E380", Offset = "0x8A3D780", VA = "0x188A3E380")]
		public BQIXZJZWWYI(MWIJDBIDZDF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x8A3DFA0", Offset = "0x8A3D3A0", VA = "0x188A3DFA0", Slot = "7")]
		public void CRCHUBDAKHQ(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x8A3E0A0", Offset = "0x8A3D4A0", VA = "0x188A3E0A0", Slot = "8")]
		public void ELXGXTJKQMP(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x8A3E130", Offset = "0x8A3D530", VA = "0x188A3E130", Slot = "9")]
		public void HOSPLPTERRN(object a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x8A3E060", Offset = "0x8A3D460", VA = "0x188A3E060", Slot = "12")]
		public void ECQPCDDDTHT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x8A3E0B0", Offset = "0x8A3D4B0", VA = "0x188A3E0B0", Slot = "10")]
		public void HCYVTHGDDGP(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x8A3DF70", Offset = "0x8A3D370", VA = "0x188A3DF70", Slot = "11")]
		public void CJWOGKOXWPK(Rigidbody a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	internal sealed class UFZLWNVGYHT : ITAGKVSCAGN, NINZGGAFRVW, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private readonly THCJMJLYUAO NUWRCYXCGDR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private RRNetworkView JAYEYSKEVAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private bool HOXBZUVAJDW;

		[Cpp2IlInjected.Token(Token = "0x170000AB")]
		public RRNetworkView MLKDMANEVLX
		{
			[Cpp2IlInjected.Token(Token = "0x60002DD")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AC")]
		public bool KGYJMXFIELE
		{
			[Cpp2IlInjected.Token(Token = "0x60002DE")]
			[Cpp2IlInjected.Address(RVA = "0x8A54A40", Offset = "0x8A53E40", VA = "0x188A54A40", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AD")]
		public bool POVZQWAWTHG
		{
			[Cpp2IlInjected.Token(Token = "0x60002DF")]
			[Cpp2IlInjected.Address(RVA = "0xC75520", Offset = "0xC74920", VA = "0x180C75520", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400002C")]
		public event RbexAction HKMLKUBCHGJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002DB")]
			[Cpp2IlInjected.Address(RVA = "0x8A549A0", Offset = "0x8A53DA0", VA = "0x188A549A0", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60002DC")]
			[Cpp2IlInjected.Address(RVA = "0x8A54BA0", Offset = "0x8A53FA0", VA = "0x188A54BA0", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x8A54C40", Offset = "0x8A54040", VA = "0x188A54C40")]
		public UFZLWNVGYHT(MWIJDBIDZDF a, [In] RigidbodyExData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x8A540C0", Offset = "0x8A534C0", VA = "0x188A540C0", Slot = "9")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x8A544D0", Offset = "0x8A538D0", VA = "0x188A544D0", Slot = "12")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x8A54360", Offset = "0x8A53760", VA = "0x188A54360", Slot = "10")]
		public void BUEGVYIRSFQ(MWIJDBIDZDF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x8A54830", Offset = "0x8A53C30", VA = "0x188A54830", Slot = "11")]
		public void GZKHAINJBIW(MWIJDBIDZDF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x8A541F0", Offset = "0x8A535F0", VA = "0x188A541F0")]
		private void BNHSBNGWBUO(RRNetworkView a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x8A54A50", Offset = "0x8A53E50", VA = "0x188A54A50")]
		private void YIFCQRIFIZE(JHZEISLHDPT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x8A545C0", Offset = "0x8A539C0", VA = "0x188A545C0")]
		private void GIMHMELIKIP(RRNetworkView a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	internal static class NWHYFDIUKLZ
	{
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x8A42A10", Offset = "0x8A41E10", VA = "0x188A42A10")]
		public static ITAGKVSCAGN Lifecycle(this MWIJDBIDZDF impl)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	internal sealed class ZVBJFMEKEIZ : MBLXQUTZUAK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private readonly THCJMJLYUAO NUWRCYXCGDR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private RigidbodyConstraints CFTUEQWLWZY;

		[Cpp2IlInjected.Token(Token = "0x170000AE")]
		public bool QQWMQEWJXOV
		{
			[Cpp2IlInjected.Token(Token = "0x60002E9")]
			[Cpp2IlInjected.Address(RVA = "0xBC0680", Offset = "0xBBFA80", VA = "0x180BC0680", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002EA")]
			[Cpp2IlInjected.Address(RVA = "0xBC0B60", Offset = "0xBBFF60", VA = "0x180BC0B60", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AF")]
		public bool DHISTKRCSBC
		{
			[Cpp2IlInjected.Token(Token = "0x60002EB")]
			[Cpp2IlInjected.Address(RVA = "0xBBFFD0", Offset = "0xBBF3D0", VA = "0x180BBFFD0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002EC")]
			[Cpp2IlInjected.Address(RVA = "0xBBFFF0", Offset = "0xBBF3F0", VA = "0x180BBFFF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B0")]
		public RigidbodyConstraints UXRQCXKMIBY
		{
			[Cpp2IlInjected.Token(Token = "0x60002ED")]
			[Cpp2IlInjected.Address(RVA = "0xAAC980", Offset = "0xAABD80", VA = "0x180AAC980", Slot = "7")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x60002EE")]
			[Cpp2IlInjected.Address(RVA = "0x8A59CB0", Offset = "0x8A590B0", VA = "0x188A59CB0", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x8A59DE0", Offset = "0x8A591E0", VA = "0x188A59DE0")]
		public ZVBJFMEKEIZ(MWIJDBIDZDF a, [In] RigidbodyExData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x8A59C80", Offset = "0x8A59080", VA = "0x188A59C80", Slot = "9")]
		public void HCYVTHGDDGP(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x8A59C50", Offset = "0x8A59050", VA = "0x188A59C50", Slot = "10")]
		public void CJWOGKOXWPK(Rigidbody a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	internal sealed class WRZBRSFTMZU : BWHJHDJYXXL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private readonly MWIJDBIDZDF NUWRCYXCGDR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private float ZOIOAXDUBXO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private float BIPBMRAJFZI;

		[Cpp2IlInjected.Token(Token = "0x170000B1")]
		public float JGTAUWLZKXC
		{
			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0xB05AA0", Offset = "0xB04EA0", VA = "0x180B05AA0", Slot = "4")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60002F4")]
			[Cpp2IlInjected.Address(RVA = "0x8A58B00", Offset = "0x8A57F00", VA = "0x188A58B00", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B2")]
		public float TOZQNNTDPRQ
		{
			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0xB05E50", Offset = "0xB05250", VA = "0x180B05E50", Slot = "6")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60002F6")]
			[Cpp2IlInjected.Address(RVA = "0x8A58A30", Offset = "0x8A57E30", VA = "0x188A58A30", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x8A58BD0", Offset = "0x8A57FD0", VA = "0x188A58BD0")]
		public WRZBRSFTMZU(MWIJDBIDZDF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x8A589E0", Offset = "0x8A57DE0", VA = "0x188A589E0", Slot = "8")]
		public void HCYVTHGDDGP(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x8A58940", Offset = "0x8A57D40", VA = "0x188A58940", Slot = "9")]
		public void CJWOGKOXWPK(Rigidbody a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	internal sealed class OLPMGVCJWTM : ILTJNVNSRQX
	{
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static readonly Log NTYUNHOMEKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private readonly THCJMJLYUAO NUWRCYXCGDR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private bool ZTILYSWTQJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private bool PYOWSRSSBII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private int JIQEJBYIWWQ;

		[Cpp2IlInjected.Token(Token = "0x170000B3")]
		private Rigidbody QNEZXRYKHXI
		{
			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0x8A3F490", Offset = "0x8A3E890", VA = "0x188A3F490")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B4")]
		private bool HMKAPSXETUB
		{
			[Cpp2IlInjected.Token(Token = "0x60002FC")]
			[Cpp2IlInjected.Address(RVA = "0x8A42C80", Offset = "0x8A42080", VA = "0x188A42C80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B5")]
		private MWIJDBIDZDF YSZAMEVATVQ
		{
			[Cpp2IlInjected.Token(Token = "0x60002FD")]
			[Cpp2IlInjected.Address(RVA = "0x8A42CB0", Offset = "0x8A420B0", VA = "0x188A42CB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B6")]
		private bool WPVPLREWLPM
		{
			[Cpp2IlInjected.Token(Token = "0x60002FE")]
			[Cpp2IlInjected.Address(RVA = "0x8A43400", Offset = "0x8A42800", VA = "0x188A43400")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400002D")]
		public event RbexAction MGDQBBFJNPN
		{
			[Cpp2IlInjected.Token(Token = "0x60002F9")]
			[Cpp2IlInjected.Address(RVA = "0x8A42EA0", Offset = "0x8A422A0", VA = "0x188A42EA0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0x8A43130", Offset = "0x8A42530", VA = "0x188A43130", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x8A436A0", Offset = "0x8A42AA0", VA = "0x188A436A0")]
		public OLPMGVCJWTM(MWIJDBIDZDF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x8A42AD0", Offset = "0x8A41ED0", VA = "0x188A42AD0", Slot = "6")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x8A42CA0", Offset = "0x8A420A0", VA = "0x188A42CA0", Slot = "8")]
		public void GLDGFBJDVPX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x8A42F40", Offset = "0x8A42340", VA = "0x188A42F40", Slot = "7")]
		public bool OSBUHOXNNLB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x8A431D0", Offset = "0x8A425D0", VA = "0x188A431D0", Slot = "9")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x8A43090", Offset = "0x8A42490", VA = "0x188A43090", Slot = "13")]
		public void PHZGPXDVXYP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x8A42B60", Offset = "0x8A41F60", VA = "0x188A42B60", Slot = "12")]
		public void EBNFZFMUEDM(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x8A432A0", Offset = "0x8A426A0", VA = "0x188A432A0", Slot = "10")]
		public bool UBFIHJBRJKR()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x8A43310", Offset = "0x8A42710", VA = "0x188A43310", Slot = "11")]
		public bool UUKGBGBBVOM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x8A43460", Offset = "0x8A42860", VA = "0x188A43460")]
		private bool YESGVSHJRCK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x8A42D10", Offset = "0x8A42110", VA = "0x188A42D10")]
		private void JAYACVGAOME()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	internal sealed class UCVFAFXTGWL : RVAQDSIPZAU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private readonly THCJMJLYUAO NUWRCYXCGDR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private readonly YPHQWUVMKZC JTMMFXOICWT;

		[Cpp2IlInjected.Token(Token = "0x170000B7")]
		public Rigidbody QNEZXRYKHXI
		{
			[Cpp2IlInjected.Token(Token = "0x600030B")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600030C")]
			[Cpp2IlInjected.Address(RVA = "0xAA67C0", Offset = "0xAA5BC0", VA = "0x180AA67C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B8")]
		private bool WPVPLREWLPM
		{
			[Cpp2IlInjected.Token(Token = "0x600030D")]
			[Cpp2IlInjected.Address(RVA = "0x8A42730", Offset = "0x8A41B30", VA = "0x188A42730")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B9")]
		public bool FDIBEFIEIUP
		{
			[Cpp2IlInjected.Token(Token = "0x6000310")]
			[Cpp2IlInjected.Address(RVA = "0x17FEAB0", Offset = "0x17FDEB0", VA = "0x1817FEAB0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x8A53FC0", Offset = "0x8A533C0", VA = "0x188A53FC0")]
		public UCVFAFXTGWL(MWIJDBIDZDF a, [In] RigidbodyExData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x8A53820", Offset = "0x8A52C20", VA = "0x188A53820", Slot = "5")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x8A538C0", Offset = "0x8A52CC0", VA = "0x188A538C0", Slot = "7")]
		public void LBTTOIQEHMV(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x8A53AE0", Offset = "0x8A52EE0", VA = "0x188A53AE0", Slot = "8")]
		public void UQNEFILOZIE(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x8A53C90", Offset = "0x8A53090", VA = "0x188A53C90", Slot = "9")]
		public void XXRCBYEGAUZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x8A538F0", Offset = "0x8A52CF0", VA = "0x188A538F0", Slot = "10")]
		public void UOLXBEUQRBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x8A53B10", Offset = "0x8A52F10", VA = "0x188A53B10", Slot = "11")]
		public void UVERQFDYPXX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	internal sealed class VHARUGHJLKI : MJAZKPXHZUH, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private readonly THCJMJLYUAO NUWRCYXCGDR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private readonly YPHQWUVMKZC VRDJSSVFYAU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private float DTZLSGPCARD;

		[Cpp2IlInjected.Token(Token = "0x170000BA")]
		public VDZYKGMLTUT LRBGTFZTHLC
		{
			[Cpp2IlInjected.Token(Token = "0x6000316")]
			[Cpp2IlInjected.Address(RVA = "0xAAA820", Offset = "0xAA9C20", VA = "0x180AAA820", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000317")]
			[Cpp2IlInjected.Address(RVA = "0xAA67D0", Offset = "0xAA5BD0", VA = "0x180AA67D0", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		public HBNPYSELDYW DCDYMVMWUSH
		{
			[Cpp2IlInjected.Token(Token = "0x6000318")]
			[Cpp2IlInjected.Address(RVA = "0xAAA140", Offset = "0xAA9540", VA = "0x180AAA140", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000319")]
			[Cpp2IlInjected.Address(RVA = "0xAADB00", Offset = "0xAACF00", VA = "0x180AADB00", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BC")]
		public Vector3 GJPNWNLMIRP
		{
			[Cpp2IlInjected.Token(Token = "0x600031A")]
			[Cpp2IlInjected.Address(RVA = "0x8A55CD0", Offset = "0x8A550D0", VA = "0x188A55CD0", Slot = "8")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600031B")]
			[Cpp2IlInjected.Address(RVA = "0x8A562E0", Offset = "0x8A556E0", VA = "0x188A562E0", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BD")]
		public Vector3 CKYWBPNGQUK
		{
			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(RVA = "0x8A58350", Offset = "0x8A57750", VA = "0x188A58350", Slot = "10")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600031D")]
			[Cpp2IlInjected.Address(RVA = "0x8A57980", Offset = "0x8A56D80", VA = "0x188A57980", Slot = "11")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BE")]
		public Vector3 DAIFPKLWRXR
		{
			[Cpp2IlInjected.Token(Token = "0x600031E")]
			[Cpp2IlInjected.Address(RVA = "0x8A56CA0", Offset = "0x8A560A0", VA = "0x188A56CA0", Slot = "12")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600031F")]
			[Cpp2IlInjected.Address(RVA = "0x8A56BE0", Offset = "0x8A55FE0", VA = "0x188A56BE0", Slot = "13")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BF")]
		public Vector3 XZFWVRVTZTE
		{
			[Cpp2IlInjected.Token(Token = "0x6000320")]
			[Cpp2IlInjected.Address(RVA = "0x8A550E0", Offset = "0x8A544E0", VA = "0x188A550E0", Slot = "14")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0x8A54E40", Offset = "0x8A54240", VA = "0x188A54E40", Slot = "15")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C0")]
		public float LTQZYTALBDT
		{
			[Cpp2IlInjected.Token(Token = "0x6000322")]
			[Cpp2IlInjected.Address(RVA = "0xB05E60", Offset = "0xB05260", VA = "0x180B05E60", Slot = "16")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000323")]
			[Cpp2IlInjected.Address(RVA = "0x8A55350", Offset = "0x8A54750", VA = "0x188A55350", Slot = "17")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C1")]
		public bool PCFNUGIDUMT
		{
			[Cpp2IlInjected.Token(Token = "0x6000324")]
			[Cpp2IlInjected.Address(RVA = "0x22C4550", Offset = "0x22C3950", VA = "0x1822C4550", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C2")]
		private XNNZMDWKDCL AVCJCOZJYVL
		{
			[Cpp2IlInjected.Token(Token = "0x6000339")]
			[Cpp2IlInjected.Address(RVA = "0x7FCA6C0", Offset = "0x7FC9AC0", VA = "0x187FCA6C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C3")]
		private bool HMKAPSXETUB
		{
			[Cpp2IlInjected.Token(Token = "0x600033A")]
			[Cpp2IlInjected.Address(RVA = "0x8A55700", Offset = "0x8A54B00", VA = "0x188A55700")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x8A584D0", Offset = "0x8A578D0", VA = "0x188A584D0")]
		public VHARUGHJLKI(MWIJDBIDZDF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x8A54DA0", Offset = "0x8A541A0", VA = "0x188A54DA0", Slot = "19")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x8A55460", Offset = "0x8A54860", VA = "0x188A55460", Slot = "36")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x8A55720", Offset = "0x8A54B20", VA = "0x188A55720", Slot = "28")]
		public void HCYVTHGDDGP(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x15E5930", Offset = "0x15E4D30", VA = "0x1815E5930", Slot = "20")]
		public void MVSOKDQJQHH(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x15E6460", Offset = "0x15E5860", VA = "0x1815E6460", Slot = "30")]
		public void VNDIBRQNOYI(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x8A567B0", Offset = "0x8A55BB0", VA = "0x188A567B0", Slot = "35")]
		public Vector3 LRMLHJIINQB(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x8A54F20", Offset = "0x8A54320", VA = "0x188A54F20", Slot = "34")]
		public Vector3 CIFCKWXAXST(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x8A54DA0", Offset = "0x8A541A0", VA = "0x188A54DA0", Slot = "27")]
		public void BWEFLGWTBXW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x8A579B0", Offset = "0x8A56DB0", VA = "0x188A579B0", Slot = "25")]
		public void WLDDRETZDIV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x8A569F0", Offset = "0x8A55DF0", VA = "0x188A569F0", Slot = "24")]
		public void PJOXMHGLFQY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x8A554C0", Offset = "0x8A548C0", VA = "0x188A554C0", Slot = "33")]
		public void GDHMYKPNYFK(Vector3 a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x8A56990", Offset = "0x8A55D90", VA = "0x188A56990", Slot = "32")]
		public void NZKWHSCZSZD(Vector3 a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x8A57A10", Offset = "0x8A56E10", VA = "0x188A57A10", Slot = "31")]
		public void XGBEWNLQOLC(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x8A572E0", Offset = "0x8A566E0", VA = "0x188A572E0", Slot = "22")]
		public void WEPRVJNKZCW(RbexImpulseType a, Vector3 b, float c, float d = 8f, float e = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x8A56530", Offset = "0x8A55930", VA = "0x188A56530", Slot = "21")]
		public void LNZOYVKXZHZ(RbexRotationType a, Vector3 b, float c = 1f / 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x8A57ED0", Offset = "0x8A572D0", VA = "0x188A57ED0", Slot = "23")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void ZKWBPDUCICU(RbexRotationType a, Vector3 b, float c = 7f, float d = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x1709FF0", Offset = "0x17093F0", VA = "0x181709FF0")]
		private static void OLBEVGQPAQI(Vector3 a, Vector3 b, [Out] Vector3 c, [Out] Vector3 d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x8A55270", Offset = "0x8A54670", VA = "0x188A55270", Slot = "29")]
		public Vector3 CNBKTKVKPYZ(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x8A56A50", Offset = "0x8A55E50", VA = "0x188A56A50", Slot = "26")]
		public void PJXPHYOMJLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x8A55350", Offset = "0x8A54750", VA = "0x188A55350")]
		private void DQONUHVWQSR(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x8A57BB0", Offset = "0x8A56FB0", VA = "0x188A57BB0")]
		private void YAUWKIWITTH(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x8A57D50", Offset = "0x8A57150", VA = "0x188A57D50")]
		private Vector3 ZCFAHCPUKBE()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x8A55850", Offset = "0x8A54C50", VA = "0x188A55850")]
		private void IABRQVPSJPQ(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x8A563A0", Offset = "0x8A557A0", VA = "0x188A563A0")]
		private Vector3 KJDVCHEIFHQ()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x8A56E60", Offset = "0x8A56260", VA = "0x188A56E60")]
		private void VSCRGWTSTSW(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x8A55E80", Offset = "0x8A55280", VA = "0x188A55E80")]
		private void ITIVQTUDQCN(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x8A54E70", Offset = "0x8A54270", VA = "0x188A54E70")]
		private void BZQHLLPJXFJ()
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
