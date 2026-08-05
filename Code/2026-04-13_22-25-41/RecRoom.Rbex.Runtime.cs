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
		[Cpp2IlInjected.Address(RVA = "0xD18E40", Offset = "0xD17840", VA = "0x180D18E40")]
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
		[Cpp2IlInjected.Address(RVA = "0xD19850", Offset = "0xD18250", VA = "0x180D19850")]
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
		[Cpp2IlInjected.Address(RVA = "0xA020070", Offset = "0xA01EA70", VA = "0x18A020070", Slot = "4")]
		public override void SIFQFAPRLAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xD18E40", Offset = "0xD17840", VA = "0x180D18E40")]
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
		private int[] FEHXVDYRGKU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private ServiceBitset GXKYIJVMEXV;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xCF4350", Offset = "0xCF2D50", VA = "0x180CF4350", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9A0D270", Offset = "0x9A0BC70", VA = "0x189A0D270", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xA039AA0", Offset = "0xA0384A0", VA = "0x18A039AA0")]
		private void GVEYSKBSPJB(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xA039D80", Offset = "0xA038780", VA = "0x18A039D80", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xA039DE0", Offset = "0xA0387E0", VA = "0x18A039DE0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[DisallowMultipleComponent]
	public sealed class RigidbodyEx : MonoBehaviour, OGYYXGOOHSH, AWBPBYERTJE, SZLHTNPOQJO
	{
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static readonly Log YEJETRVZVPU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private bool CXGKRNUTEHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private LXUPYHZBZJT FJDSZVDTKHM;

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
		private Transform XFIJVIXCQYS;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal LXUPYHZBZJT MTTLIERDGIO
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xA02C3F0", Offset = "0xA02ADF0", VA = "0x18A02C3F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private LXUPYHZBZJT MMYEVIXSMCA
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xCF4350", Offset = "0xCF2D50", VA = "0x180CF4350", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int OVJQGIMCWJT
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0xA02E100", Offset = "0xA02CB00", VA = "0x18A02E100")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RigidbodyEx TBPCBVCLMHU
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0xA02E460", Offset = "0xA02CE60", VA = "0x18A02E460")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx OFIFJQDFJXG
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xA02E3A0", Offset = "0xA02CDA0", VA = "0x18A02E3A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RigidbodyEx PMPLOCZDTJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0xA02F060", Offset = "0xA02DA60", VA = "0x18A02F060")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xA030560", Offset = "0xA02EF60", VA = "0x18A030560")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool DidStart
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x93B5070", Offset = "0x93B3A70", VA = "0x1893B5070", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x93B51C0", Offset = "0x93B3BC0", VA = "0x1893B51C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Transform VVUQJWBKDSM
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x25EA890", Offset = "0x25E9290", VA = "0x1825EA890", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Transform ZHNBUFTLOVF
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x25EA890", Offset = "0x25E9290", VA = "0x1825EA890", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Transform YHXCWGCLCPJ
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x25EA890", Offset = "0x25E9290", VA = "0x1825EA890", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public TransformTrackRate QAIPJDPLKNB
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0xA02E160", Offset = "0xA02CB60", VA = "0x18A02E160")]
			get
			{
				return default(TransformTrackRate);
			}
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0xA02FD10", Offset = "0xA02E710", VA = "0x18A02FD10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool XKPOTKSKOSY
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0xA02E770", Offset = "0xA02D170", VA = "0x18A02E770")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool RHREZJRVEHQ
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0xA02E280", Offset = "0xA02CC80", VA = "0x18A02E280")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public DBBKETFETMV KOLYPESMRMG
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0xA02E6B0", Offset = "0xA02D0B0", VA = "0x18A02E6B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0xA02FED0", Offset = "0xA02E8D0", VA = "0x18A02FED0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public HAIRCSDLSLS HEFJROZQYWZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0xA02E650", Offset = "0xA02D050", VA = "0x18A02E650")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0xA02FE60", Offset = "0xA02E860", VA = "0x18A02FE60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool LIMCAIRXPKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xA02E5A0", Offset = "0xA02CFA0", VA = "0x18A02E5A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Rigidbody EUMMWSSQGSM
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xA02E600", Offset = "0xA02D000", VA = "0x18A02E600")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool NKNFNYBZXXV
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xA02E2E0", Offset = "0xA02CCE0", VA = "0x18A02E2E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xA02FD80", Offset = "0xA02E780", VA = "0x18A02FD80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool KJMEBHGONHM
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x1A0DD10", Offset = "0x1A0C710", VA = "0x181A0DD10", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float KYXHKEHMMKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xA02F000", Offset = "0xA02DA00", VA = "0x18A02F000")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float RQQQKIUSRDJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xA02EFA0", Offset = "0xA02D9A0", VA = "0x18A02EFA0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xA0304F0", Offset = "0xA02EEF0", VA = "0x18A0304F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public float KBZKPRCCATU
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xA02E9D0", Offset = "0xA02D3D0", VA = "0x18A02E9D0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0xA030170", Offset = "0xA02EB70", VA = "0x18A030170")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public float PVEDKCRRUNO
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0xA02E7D0", Offset = "0xA02D1D0", VA = "0x18A02E7D0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0xA02FF40", Offset = "0xA02E940", VA = "0x18A02FF40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public bool CXZSEVKSYPF
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0xA02F5B0", Offset = "0xA02DFB0", VA = "0x18A02F5B0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0xA030AA0", Offset = "0xA02F4A0", VA = "0x18A030AA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Vector3 VACERFKWSBR
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xA02ED80", Offset = "0xA02D780", VA = "0x18A02ED80")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xA0302C0", Offset = "0xA02ECC0", VA = "0x18A0302C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public Vector3 JZSHLHSYOJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xA02F6F0", Offset = "0xA02E0F0", VA = "0x18A02F6F0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public CollisionDetectionMode XRUMAACSRHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xA02E910", Offset = "0xA02D310", VA = "0x18A02E910")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xA030090", Offset = "0xA02EA90", VA = "0x18A030090")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public float KJTVCDHLYHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0xA02E340", Offset = "0xA02CD40", VA = "0x18A02E340")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xA02FDF0", Offset = "0xA02E7F0", VA = "0x18A02FDF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public RigidbodyConstraints QOMPATWFYFC
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xA02E970", Offset = "0xA02D370", VA = "0x18A02E970")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xA030100", Offset = "0xA02EB00", VA = "0x18A030100")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public Vector3 BCOIHCTFKTY
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0xA02F120", Offset = "0xA02DB20", VA = "0x18A02F120")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public Vector3 MAFMUEZRMSC
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0xA02F120", Offset = "0xA02DB20", VA = "0x18A02F120")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0xA030880", Offset = "0xA02F280", VA = "0x18A030880")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public float SLHVMPYUQLT
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0xA02EE60", Offset = "0xA02D860", VA = "0x18A02EE60")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xA0303A0", Offset = "0xA02EDA0", VA = "0x18A0303A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public float HCWWTCSMPIO
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xA02F550", Offset = "0xA02DF50", VA = "0x18A02F550")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xA030A30", Offset = "0xA02F430", VA = "0x18A030A30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Quaternion FLHRDZLCFVN
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0xA02F200", Offset = "0xA02DC00", VA = "0x18A02F200")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xA030600", Offset = "0xA02F000", VA = "0x18A030600")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Quaternion DXSNNAYZOPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xA02F480", Offset = "0xA02DE80", VA = "0x18A02F480")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xA030960", Offset = "0xA02F360", VA = "0x18A030960")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector3 USXCENKOOFV
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xA02F2D0", Offset = "0xA02DCD0", VA = "0x18A02F2D0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xA0306D0", Offset = "0xA02F0D0", VA = "0x18A0306D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Quaternion WAWDUFDYJBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xA02F3B0", Offset = "0xA02DDB0", VA = "0x18A02F3B0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xA0307B0", Offset = "0xA02F1B0", VA = "0x18A0307B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 ZWUMVCGUCFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0xA02F610", Offset = "0xA02E010", VA = "0x18A02F610")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xA030B10", Offset = "0xA02F510", VA = "0x18A030B10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 ZEQCBLOAWIE
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0xA02EEC0", Offset = "0xA02D8C0", VA = "0x18A02EEC0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xA030410", Offset = "0xA02EE10", VA = "0x18A030410")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector3 UMQPUGFSLIB
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xA02E830", Offset = "0xA02D230", VA = "0x18A02E830")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0xA02FFB0", Offset = "0xA02E9B0", VA = "0x18A02FFB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector3 VOMRLMHXONO
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xA02ECA0", Offset = "0xA02D6A0", VA = "0x18A02ECA0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xA0301E0", Offset = "0xA02EBE0", VA = "0x18A0301E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector3 WUEPDLUALNZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xA02EB60", Offset = "0xA02D560", VA = "0x18A02EB60")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Quaternion LFKDVZTTNPX
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xA02EA90", Offset = "0xA02D490", VA = "0x18A02EA90")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public Vector3 CFGFBHCDTTT
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0xA02F8B0", Offset = "0xA02E2B0", VA = "0x18A02F8B0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public Vector3 ZVOXGZNGRRV
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0xA02F7D0", Offset = "0xA02E1D0", VA = "0x18A02F7D0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool SCIBNISOLBP
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0xA02EC40", Offset = "0xA02D640", VA = "0x18A02EC40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool MRCGPFUHMWC
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0xA02E710", Offset = "0xA02D110", VA = "0x18A02E710")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool JCPEEYMQIDD
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0xA02E220", Offset = "0xA02CC20", VA = "0x18A02E220")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool KZCJJPMQQYY
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0xA02E1C0", Offset = "0xA02CBC0", VA = "0x18A02E1C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool NJUAISBZIJH
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xA02E0A0", Offset = "0xA02CAA0", VA = "0x18A02E0A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public bool BLDACPZSOQQ
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xA02EA30", Offset = "0xA02D430", VA = "0x18A02EA30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool PWWECYVUCJM
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xE06A00", Offset = "0xE05400", VA = "0x180E06A00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event RbexParentChangeAction TFJVCLCBELW
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xA02DFC0", Offset = "0xA02C9C0", VA = "0x18A02DFC0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xA02FC30", Offset = "0xA02E630", VA = "0x18A02FC30")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event RbexAction YLNBUCLIBKU
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xA02DD30", Offset = "0xA02C730", VA = "0x18A02DD30")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xA02F990", Offset = "0xA02E390", VA = "0x18A02F990")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event RbexAction OUJVHEBRGPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xA02DD90", Offset = "0xA02C790", VA = "0x18A02DD90")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xA02FA00", Offset = "0xA02E400", VA = "0x18A02FA00")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event RbexAction EHAGBLPBDNE
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xA02DEE0", Offset = "0xA02C8E0", VA = "0x18A02DEE0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xA02FB50", Offset = "0xA02E550", VA = "0x18A02FB50")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<UpdateLOD, UpdateLOD> CSGCRCJQBEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xA02DE70", Offset = "0xA02C870", VA = "0x18A02DE70")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0xA02FAE0", Offset = "0xA02E4E0", VA = "0x18A02FAE0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event RbexAction OCHERKAHZFL
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0xA02DF50", Offset = "0xA02C950", VA = "0x18A02DF50")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xA02FBC0", Offset = "0xA02E5C0", VA = "0x18A02FBC0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event RbexAction JJDVOCOFONR
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0xA02E030", Offset = "0xA02CA30", VA = "0x18A02E030")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0xA02FCA0", Offset = "0xA02E6A0", VA = "0x18A02FCA0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event RbexAction JKNPYNIICDY
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0xA02DE00", Offset = "0xA02C800", VA = "0x18A02DE00")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0xA02FA70", Offset = "0xA02E470", VA = "0x18A02FA70")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xCF1780", Offset = "0xCF0180", VA = "0x180CF1780", Slot = "8")]
		private void ICZJAOGXUDW(LXUPYHZBZJT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xA02C750", Offset = "0xA02B150", VA = "0x18A02C750", Slot = "9")]
		public RigidbodyExData GetData()
		{
			return default(RigidbodyExData);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA02CA40", Offset = "0xA02B440", VA = "0x18A02CA40")]
		internal void JYDCHMBEHBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA02D8D0", Offset = "0xA02C2D0", VA = "0x18A02D8D0")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public void TestOverrideUnityRigidbody(Rigidbody rb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xA02C4A0", Offset = "0xA02AEA0", VA = "0x18A02C4A0")]
		public OGYYXGOOHSH GetChild(int index)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xA02D530", Offset = "0xA02BF30", VA = "0x18A02D530")]
		public void SetInertiaTensor((Quaternion rot, Vector3 moments) tensor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xA02C040", Offset = "0xA02AA40", VA = "0x18A02C040")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA02D7C0", Offset = "0xA02C1C0", VA = "0x18A02D7C0")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xA02C3F0", Offset = "0xA02ADF0", VA = "0x18A02C3F0")]
		private LXUPYHZBZJT FUCFVTCCCEO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xA02D940", Offset = "0xA02C340", VA = "0x18A02D940")]
		private void WNCQWZWPKZY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xA02CD00", Offset = "0xA02B700", VA = "0x18A02CD00")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xA02CC40", Offset = "0xA02B640", VA = "0x18A02CC40")]
		public void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0xA02CA40", Offset = "0xA02B440", VA = "0x18A02CA40")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xA02CCA0", Offset = "0xA02B6A0", VA = "0x18A02CCA0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xA02CD60", Offset = "0xA02B760", VA = "0x18A02CD60")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xA02B630", Offset = "0xA02A030", VA = "0x18A02B630")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xA02CDC0", Offset = "0xA02B7C0", VA = "0x18A02CDC0")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xA02C390", Offset = "0xA02AD90", VA = "0x18A02C390")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xA02CBE0", Offset = "0xA02B5E0", VA = "0x18A02CBE0")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xA02D690", Offset = "0xA02C090", VA = "0x18A02D690")]
		public void SetParent(RigidbodyEx value, bool isPhysicallyDetachedOnly = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0xA02D0D0", Offset = "0xA02BAD0", VA = "0x18A02D0D0")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xA02C7E0", Offset = "0xA02B1E0", VA = "0x18A02C7E0")]
		public bool IsRigidbodyAncestor(RigidbodyEx possibleAncestor)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xA02C8E0", Offset = "0xA02B2E0", VA = "0x18A02C8E0")]
		public bool IsRigidbodyDescendant(RigidbodyEx possibleDescendant)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xA02B8A0", Offset = "0xA02A2A0", VA = "0x18A02B8A0")]
		public void AddInterpolationRestriction(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0xA02CE30", Offset = "0xA02B830", VA = "0x18A02CE30")]
		public void RemoveInterpolationRestriction(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0xA02B910", Offset = "0xA02A310", VA = "0x18A02B910")]
		public void AddKinematic(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0xA02CEA0", Offset = "0xA02B8A0", VA = "0x18A02CEA0")]
		public void RemoveKinematic(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0xA02D610", Offset = "0xA02C010", VA = "0x18A02D610")]
		public void SetKinematic(object token, bool setKinematic)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0xA02D430", Offset = "0xA02BE30", VA = "0x18A02D430")]
		public void SetDiscontinuousPositionAndRotation(Vector3 newPosition, Quaternion newRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0xA02D330", Offset = "0xA02BD30", VA = "0x18A02D330")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 newLocalPosition, Quaternion newLocalRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0xA02C640", Offset = "0xA02B040", VA = "0x18A02C640")]
		public Vector3 GetConstrainedVelocity(Vector3 velocity)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0xA02C530", Offset = "0xA02AF30", VA = "0x18A02C530")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 angularVelocity)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0xA02B7B0", Offset = "0xA02A1B0", VA = "0x18A02B7B0")]
		public void AddForce(Vector3 force, ForceMode forceMode = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xA02B6A0", Offset = "0xA02A0A0", VA = "0x18A02B6A0")]
		public void AddForceAtPosition(Vector3 force, Vector3 position, ForceMode forceMode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0xA02BAE0", Offset = "0xA02A4E0", VA = "0x18A02BAE0")]
		public void AddTorque(Vector3 torque, ForceMode forceMode = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xA02B980", Offset = "0xA02A380", VA = "0x18A02B980")]
		public void AddRelativeTorque(Vector3 torque, ForceMode forceMode = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0xA02DB20", Offset = "0xA02C520", VA = "0x18A02DB20")]
		public Vector3 WorldToLocalVelocity(Vector3 worldVelocity)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xA02CAD0", Offset = "0xA02B4D0", VA = "0x18A02CAD0")]
		public Vector3 LocalToWorldVelocity(Vector3 localVelocity)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xA02C330", Offset = "0xA02AD30", VA = "0x18A02C330")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xA02C2D0", Offset = "0xA02ACD0", VA = "0x18A02C2D0")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0xA02C270", Offset = "0xA02AC70", VA = "0x18A02C270")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xA02C210", Offset = "0xA02AC10", VA = "0x18A02C210")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xA02D230", Offset = "0xA02BC30", VA = "0x18A02D230")]
		public void ResetVelocityWorldSpace(Vector3 worldLinearVelocity, Vector3 worldAngularVelocity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xA02D130", Offset = "0xA02BB30", VA = "0x18A02D130")]
		public void ResetVelocityLocalSpace(Vector3 localLinearVelocity, Vector3 localAngularVelocity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0xA02CFF0", Offset = "0xA02B9F0", VA = "0x18A02CFF0")]
		public void ResetLinearVelocityLocalSpace(Vector3 localLinearVelocity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xA02D7D0", Offset = "0xA02C1D0", VA = "0x18A02D7D0")]
		public bool SweepTest(Vector3 direction, [Out] RaycastHit hitInfo, float maxDistance)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xA02C9E0", Offset = "0xA02B3E0", VA = "0x18A02C9E0")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xA02D760", Offset = "0xA02C160", VA = "0x18A02D760")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xA02DAC0", Offset = "0xA02C4C0", VA = "0x18A02DAC0")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0xA02BA70", Offset = "0xA02A470", VA = "0x18A02BA70")]
		public void AddShouldHaveUnityRigidbodyToken(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xA02CF10", Offset = "0xA02B910", VA = "0x18A02CF10")]
		public void RemoveShouldHaveUnityRigidbodyToken(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0xA02BE70", Offset = "0xA02A870", VA = "0x18A02BE70")]
		public void ApplyForceVelocityChange(RbexImpulseType impulseType, Vector3 impulseDirection, float impulseSpeed, float impulseDirectionMaxSpeed = 8f, float impulseReflectiveRestitution = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0xA02BD70", Offset = "0xA02A770", VA = "0x18A02BD70")]
		public void ApplyAngularVelocityChange(RbexRotationType rotationType, Vector3 newAngularVelocity, float maxAngularSpeed = 1f / 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0xA02BF30", Offset = "0xA02A930", VA = "0x18A02BF30")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void ApplyTorqueAngularVelocityChangeDeprecated(RbexRotationType rotationType, Vector3 rotation, float maxSpeed = 7f, float multiplyingFactor = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xA02BCA0", Offset = "0xA02A6A0", VA = "0x18A02BCA0")]
		public bool AllowedScaleChange(float scaleFactor)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xA02BBD0", Offset = "0xA02A5D0", VA = "0x18A02BBD0")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx parentOverride, object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xA02CF80", Offset = "0xA02B980", VA = "0x18A02CF80")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x8C45940", Offset = "0x8C44340", VA = "0x188C45940", Slot = "13")]
		private void SEQRWQSPUKP(NSNTXJAOJGZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xA02DCC0", Offset = "0xA02C6C0", VA = "0x18A02DCC0")]
		public RigidbodyEx()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x15063B0", Offset = "0x1504DB0", VA = "0x1815063B0", Slot = "4")]
		private GameObject LBTUSBOAYUC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0xD1B0D0", Offset = "0xD19AD0", VA = "0x180D1B0D0", Slot = "10")]
		private bool FSAWUCEYRAZ()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	internal static class BWRWKAVTNYY
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0xA01DC00", Offset = "0xA01C600", VA = "0x18A01DC00")]
		public static LXUPYHZBZJT MTTLIERDGIO(this RigidbodyEx a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[RegisterService(typeof(TXSHHVHGWNE), new string[] { })]
	public class RigidbodyExManager : TXSHHVHGWNE, DTRQAXWKVLM
	{
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static readonly Log KZEIFDHBWKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private UHCTUQBJOJP KJXKMHFLTOY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private WTDUGPZWXSI JVWVJIYFRQC;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public UHCTUQBJOJP SEGKMBYZWXC
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xCF4310", Offset = "0xCF2D10", VA = "0x180CF4310", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public WTDUGPZWXSI BWDHSISXXES
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0xA02B360", Offset = "0xA029D60", VA = "0x18A02B360", Slot = "7")]
		public void InitReferences(PPCVAYWFABF services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0xA02B3D0", Offset = "0xA029DD0", VA = "0x18A02B3D0", Slot = "6")]
		public LXUPYHZBZJT RTYDXWLWRNM(RigidbodyEx a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
		public RigidbodyExManager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class PhysicsManager : SingletonMonoBehaviour<PhysicsManager>
	{
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static YZDETVQVLVA UpdateAfterFixedUpdateRan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private int NGHNWVWUUEQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private int OHAQKCTRARG;

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0xA029250", Offset = "0xA027C50", VA = "0x18A029250")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0xA0292D0", Offset = "0xA027CD0", VA = "0x18A0292D0")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0xA029270", Offset = "0xA027C70", VA = "0x18A029270")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEE930", VA = "0x180CEFF30")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string message, [Optional] UnityEngine.Object context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEE930", VA = "0x180CEFF30")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string message, [Optional] UnityEngine.Object context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0xA0293D0", Offset = "0xA027DD0", VA = "0x18A0293D0")]
		public PhysicsManager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public static class WZYXCWGWADS
	{
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		private class UXFPXUSRCCM : DBBKETFETMV, IDisposable
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEE930", VA = "0x180CEFF30", Slot = "7")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0xCFF450", Offset = "0xCFDE50", VA = "0x180CFF450", Slot = "4")]
			public Vector3 CXYMNJQTGHL()
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0xCFF450", Offset = "0xCFDE50", VA = "0x180CFF450", Slot = "5")]
			public Vector3 YSJAWMVYBKU()
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0xD09BA0", Offset = "0xD085A0", VA = "0x180D09BA0", Slot = "6")]
			public bool ZEEGGALKPBN(float a, float b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
			public UXFPXUSRCCM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public static DBBKETFETMV ETGGWVSGWPP
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0xA038A40", Offset = "0xA037440", VA = "0x18A038A40")]
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
	public interface HYNZHTJVJYV
	{
		[Cpp2IlInjected.Token(Token = "0x17000039")]
		CollisionDetectionMode NZWQSZICZJO
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
		void UFRYBKIKRJO(bool a);

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void ZGFHBBRUKKH(bool a);

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void SMDWCQWJFSZ(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool HXXFZGWJNGE(Vector3 a, [Out] RaycastHit b, float c);
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public interface SBEFVAXGCFY : IDisposable, SBSVZTMKGKU
	{
		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		TransformTrackRate QAIPJDPLKNB
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		event Action<UpdateLOD, UpdateLOD> CSGCRCJQBEM;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void Awake();
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[ServiceLifetime(Lifetime.Application)]
	public interface WTDUGPZWXSI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		NQKBXILZAUJ AEOWBCZJYDR(LXUPYHZBZJT a);

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		FIDNUJTSXPT HCOSETOVPHF(LXUPYHZBZJT a);

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		BCXHEVYETUK GTPWLZDLDPW(LXUPYHZBZJT a);

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		XTQQSIWUNAD JAYJFJCBXND(LXUPYHZBZJT a);

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "4")]
		VAQXZSQRJSJ MZWOLCOWJQT(LXUPYHZBZJT a);

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "5")]
		SBEFVAXGCFY OCAPGECIGWM(LXUPYHZBZJT a);

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "6")]
		ADFYPFYYJTJ OCDTSIECVCR(LXUPYHZBZJT a);

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "7")]
		CPTWJAIUUZT WZIXDBDJNVJ(LXUPYHZBZJT a);

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "8")]
		HYNZHTJVJYV EPSLMPHOXHV(LXUPYHZBZJT a);

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "9")]
		HJSVZQWCZSU UWOGCCWBZSC(LXUPYHZBZJT a);

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "10")]
		AFCZAFOTJDY OGFPGPDGXUA(LXUPYHZBZJT a, [In] RigidbodyExData data);

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "11")]
		LLGCBUIDYLE DEUYBJBKGKE(LXUPYHZBZJT a, [In] RigidbodyExData data);

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "12")]
		FFFMJOLTGZC VMKRPZSJBPQ(LXUPYHZBZJT a, [In] RigidbodyExData data);

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "13")]
		ABJGSSFBSGY FLBXRNWIHHY(LXUPYHZBZJT a, [In] RigidbodyExData data);

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "14")]
		IHWEUKEKZTG AWFTSRBVHWO(LXUPYHZBZJT a, [In] RigidbodyExData data);

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "15")]
		LXUPYHZBZJT RTYDXWLWRNM(RigidbodyEx a, RigidbodyExData b, TXSHHVHGWNE c);
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface CPTWJAIUUZT
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void USYWIONWZMS(Vector3 a, ForceMode b = ForceMode.Force);

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void YAPLWXIDAZG(Vector3 a, Vector3 b, ForceMode c);

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void SZAHRAMMZXH(Vector3 a, ForceMode b = ForceMode.Force);

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void GHUSPGJLABX(Vector3 a, ForceMode b = ForceMode.Force);
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface HJSVZQWCZSU
	{
		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		bool OSWXTAUUJQX
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
		void SMDWCQWJFSZ(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void SBBJNFQRYPU(Rigidbody a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public interface NQKBXILZAUJ : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		IReadOnlyList<LXUPYHZBZJT> VFZTJRIUBHO
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(Slot = "18")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		LXUPYHZBZJT OFIFJQDFJXG
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(Slot = "19")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		LXUPYHZBZJT LXEGSVYJGSM
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(Slot = "20")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(Slot = "21")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		event RbexAction YLNBUCLIBKU;

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		event RbexAction OUJVHEBRGPM;

		[Cpp2IlInjected.Token(Token = "0x1400000C")]
		event RbexParentChangeAction KPKZLGALJHC;

		[Cpp2IlInjected.Token(Token = "0x1400000D")]
		event Action TMMQHJCUGDD;

		[Cpp2IlInjected.Token(Token = "0x1400000E")]
		event Action HXHBELZVDTU;

		[Cpp2IlInjected.Token(Token = "0x1400000F")]
		event Action<LXUPYHZBZJT> ZILSWZCUUGX;

		[Cpp2IlInjected.Token(Token = "0x14000010")]
		event Action<LXUPYHZBZJT> ZVYLLUTFFLK;

		[Cpp2IlInjected.Token(Token = "0x14000011")]
		event Action FHOQKHPSETV;

		[Cpp2IlInjected.Token(Token = "0x14000012")]
		event Action<LXUPYHZBZJT> SVJWKOWWXQQ;

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "22")]
		void SetParent(LXUPYHZBZJT newParent, bool isPhysicallyDetachedOnly = false);
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public interface BCXHEVYETUK
	{
		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		Vector3 XKMDQDDFWQV
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		Vector3 SZXZTHRYZSL
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void XYQXFHSLXHJ(LXUPYHZBZJT a, object b);

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void KJSPAQXWVQU(object a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public interface ABJGSSFBSGY
	{
		[Cpp2IlInjected.Token(Token = "0x17000041")]
		Vector3 IZFYQQIUYRJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		Vector3 JROGDJXDQKE
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		float WRDRETNSTCQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		float WURUEBFLLOL
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(Slot = "7")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		Vector3 LSZXGKRJVRR
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		Quaternion GOCCYCVSGLD
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000013")]
		event RbexAction YCQZDDFZPPU;

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void NPMABWUKGBF((Quaternion rot, Vector3 moments) tensor);

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(Slot = "11")]
		void LAPJFJGAHUC();

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void OYEMNLQPEHP();

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(Slot = "13")]
		void OXLQGXAIGFJ();

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void SMDWCQWJFSZ(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void SBBJNFQRYPU(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void OnDrawGizmosSelected();
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public interface FFFMJOLTGZC
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Awake();

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void OUMBAYJWNTF(object a);

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void PSBAGEZXJXE(object a);

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void MAVVSTNHKPI(LXUPYHZBZJT a);

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void HUICRUBRLUV(LXUPYHZBZJT a);

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void TVQONGPDDXA();
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public interface ADFYPFYYJTJ
	{
		[Cpp2IlInjected.Token(Token = "0x17000047")]
		bool CBIJVKAZZYJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000014")]
		event RbexAction UEXVUWFUIRR;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void ZVQCSLWDZWM(object a);

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void OLXCXOCOVEZ(object a);

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void DFZMGVMLCVL(object a, bool b);

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void SMDWCQWJFSZ(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void SBBJNFQRYPU(Rigidbody a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface LLGCBUIDYLE : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000048")]
		bool XKPOTKSKOSY
		{
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		bool RHREZJRVEHQ
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000015")]
		event RbexAction ITXXROJJITF;

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void Awake();

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void IPTSEZGPFEE(LXUPYHZBZJT a);

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void KBQMFYLCBTS(LXUPYHZBZJT a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface IHWEUKEKZTG
	{
		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		bool NKNFNYBZXXV
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		bool VILIHWWNEAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		RigidbodyConstraints BRFYXOLZCXW
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
		void SMDWCQWJFSZ(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void SBBJNFQRYPU(Rigidbody a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface XTQQSIWUNAD
	{
		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		float TEAHUUGNNOK
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		float STVEYJONKSE
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
		void SMDWCQWJFSZ(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void SBBJNFQRYPU(Rigidbody a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public interface VAQXZSQRJSJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		static bool DMJHZTVMVXD;

		[Cpp2IlInjected.Token(Token = "0x14000016")]
		event RbexAction IFPNYWKNMIB;

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void Awake();

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool JGCPBCSKBCV();

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void VYEFYJZZCNR();

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void Sleep();

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool JTGXIODXUYL();

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool EZCSABKDGIO();

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void EBBJEEVITQI(bool a);

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void RKYXLQNOLOF();
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public interface AFCZAFOTJDY
	{
		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		Rigidbody EUMMWSSQGSM
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		bool HAYPWHZEPMF
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
		void TFXFJGHHFHF(object a);

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void DTJULSXSPPU(object a);

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void REBXJJKYCZV();
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public interface FIDNUJTSXPT : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000051")]
		DBBKETFETMV KOLYPESMRMG
		{
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		HAIRCSDLSLS HEFJROZQYWZ
		{
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		Vector3 ICEPCSIMYGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(Slot = "5")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		Vector3 MDEBPHEQMEU
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(Slot = "7")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		Vector3 LDDNNQAATIV
		{
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(Slot = "9")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		Vector3 TLYLWZDIHEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(Slot = "11")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		float KJTVCDHLYHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(Slot = "13")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		bool LIMCAIRXPKJ
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
		void HEJEBYMVYXB(object a);

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(Slot = "17")]
		void QKWMHBMXTOR(RbexRotationType a, Vector3 b, float c = 1f / 0f);

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(Slot = "18")]
		void QZFKXASVYKM(RbexImpulseType a, Vector3 b, float c, float d = 8f, float e = 1f);

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(Slot = "19")]
		void YCGZAVPWGQO(RbexRotationType a, Vector3 b, float c = 7f, float d = 1f);

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(Slot = "20")]
		void MCQBNWMCNZI();

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(Slot = "21")]
		void LVVLWBMRZLB();

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(Slot = "22")]
		void GNUDOOUXQAG();

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(Slot = "23")]
		void ZDKPEVDVEEK();

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(Slot = "24")]
		void SMDWCQWJFSZ(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(Slot = "25")]
		Vector3 QSJCZUUDSVN(Vector3 a);

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(Slot = "26")]
		void QSNFCIRMICO(object a);

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(Slot = "27")]
		void MANMXVCYIEK(Vector3 a);

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(Slot = "28")]
		void BLHUQEBCBOP(Vector3 a, Vector3 b);

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(Slot = "29")]
		void IHXJKMBIMTE(Vector3 a, Vector3 b);

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(Slot = "30")]
		Vector3 QAIXHGLGTND(Vector3 a);

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(Slot = "31")]
		Vector3 YPKMPNFBOFR(Vector3 a);
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[ServiceLifetime(Lifetime.Application)]
	public interface UHCTUQBJOJP
	{
		[Cpp2IlInjected.Token(Token = "0x17000059")]
		bool EMOCWMLUNDY
		{
			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void PBIBRQCHPMY(string a);

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void KBFAYAUNTPZ(RigidbodyEx a, Action b);

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		ROTQQCMUGGZ CCYWKJBUZXE(int a);

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void VHCSOJHHOYS(Vector3 a, float b, Color c);
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[ServiceLifetime(Lifetime.Application)]
	public interface TXSHHVHGWNE
	{
		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		UHCTUQBJOJP SEGKMBYZWXC
		{
			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		WTDUGPZWXSI BWDHSISXXES
		{
			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(Slot = "2")]
		LXUPYHZBZJT RTYDXWLWRNM(RigidbodyEx a);
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class PTYPBTHHGDG : LXUPYHZBZJT, IDisposable, ILLCEKFPVYO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		internal readonly TXSHHVHGWNE KNEJFULKYYP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		internal NQKBXILZAUJ KXZKIDBFGVR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		internal FFFMJOLTGZC APYUIQDHHFQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		internal LLGCBUIDYLE TKPLKJWYPJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		internal FIDNUJTSXPT ZWUMVCGUCFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		internal BCXHEVYETUK IMRVJHGMPFW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		internal ABJGSSFBSGY NPIQRJMFLVA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		internal XTQQSIWUNAD HQRURKTRFUR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		internal HJSVZQWCZSU YUXKGLIXDXE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		internal VAQXZSQRJSJ IMBZGNEMDVF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		internal SBEFVAXGCFY NYEAKQPFKXG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		internal ADFYPFYYJTJ UMBJRYYZKKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		internal CPTWJAIUUZT DKLZYUOHXZV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		internal IHWEUKEKZTG YBTKWBNCQVI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		internal AFCZAFOTJDY OBAWQHPNQDS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		internal HYNZHTJVJYV IZRMOGBBRKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		internal IDisposable QFELQRIOMXU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private bool PAAUSKRORWY;

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public ObjectLocalId NLCFJQSWBVE
		{
			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF40", Offset = "0xCEE940", VA = "0x180CEFF40", Slot = "22")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public OGYYXGOOHSH PCQWDGQGDIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0xDD4470", Offset = "0xDD2E70", VA = "0x180DD4470", Slot = "24")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0xE8C640", Offset = "0xE8B040", VA = "0x180E8C640")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public GameObject DCEMLZFKLGR
		{
			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0xCF2B90", Offset = "0xCF1590", VA = "0x180CF2B90", Slot = "25")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0xCF2B00", Offset = "0xCF1500", VA = "0x180CF2B00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public Transform IBGMOBEIUDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0xEABE80", Offset = "0xEAA880", VA = "0x180EABE80", Slot = "26")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0xFF9820", Offset = "0xFF8220", VA = "0x180FF9820")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public Rigidbody EUMMWSSQGSM
		{
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0xA025890", Offset = "0xA024290", VA = "0x18A025890", Slot = "23")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public LXUPYHZBZJT LXEGSVYJGSM
		{
			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0xA025840", Offset = "0xA024240", VA = "0x18A025840", Slot = "27")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0xA027F30", Offset = "0xA026930", VA = "0x18A027F30", Slot = "28")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public int OVJQGIMCWJT
		{
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0xA025E40", Offset = "0xA024840", VA = "0x18A025E40", Slot = "31")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public LXUPYHZBZJT OFIFJQDFJXG
		{
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0xA023D20", Offset = "0xA022720", VA = "0x18A023D20", Slot = "29")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public bool DOFZZALFMLC
		{
			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0xA0248B0", Offset = "0xA0232B0", VA = "0x18A0248B0", Slot = "32")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public bool XKPOTKSKOSY
		{
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0xA023930", Offset = "0xA022330", VA = "0x18A023930", Slot = "33")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public bool RHREZJRVEHQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0xA026120", Offset = "0xA024B20", VA = "0x18A026120", Slot = "34")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public DBBKETFETMV KOLYPESMRMG
		{
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0xA028540", Offset = "0xA026F40", VA = "0x18A028540", Slot = "35")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0xA027290", Offset = "0xA025C90", VA = "0x18A027290", Slot = "36")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public HAIRCSDLSLS HEFJROZQYWZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0xA026D40", Offset = "0xA025740", VA = "0x18A026D40", Slot = "37")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0xA027830", Offset = "0xA026230", VA = "0x18A027830", Slot = "38")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public float KJTVCDHLYHJ
		{
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0xA0285F0", Offset = "0xA026FF0", VA = "0x18A0285F0", Slot = "39")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0xA026A80", Offset = "0xA025480", VA = "0x18A026A80", Slot = "40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public Vector3 MDEBPHEQMEU
		{
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0xA025D60", Offset = "0xA024760", VA = "0x18A025D60", Slot = "41")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0xA023290", Offset = "0xA021C90", VA = "0x18A023290", Slot = "42")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public Vector3 TLYLWZDIHEM
		{
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0xA025A70", Offset = "0xA024470", VA = "0x18A025A70", Slot = "43")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0xA022B90", Offset = "0xA021590", VA = "0x18A022B90", Slot = "44")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public Vector3 ICEPCSIMYGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0xA024C40", Offset = "0xA023640", VA = "0x18A024C40", Slot = "45")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0xA0241A0", Offset = "0xA022BA0", VA = "0x18A0241A0", Slot = "46")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public Vector3 LDDNNQAATIV
		{
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0xA026340", Offset = "0xA024D40", VA = "0x18A026340", Slot = "47")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0xA025440", Offset = "0xA023E40", VA = "0x18A025440", Slot = "48")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public bool JCPEEYMQIDD
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0xA0283A0", Offset = "0xA026DA0", VA = "0x18A0283A0", Slot = "49")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public bool KZCJJPMQQYY
		{
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0xA027E90", Offset = "0xA026890", VA = "0x18A027E90", Slot = "50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public bool NJUAISBZIJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0xA024E00", Offset = "0xA023800", VA = "0x18A024E00", Slot = "51")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public bool LIMCAIRXPKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0xA022EB0", Offset = "0xA0218B0", VA = "0x18A022EB0", Slot = "52")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public Vector3 XKMDQDDFWQV
		{
			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0xA024EE0", Offset = "0xA0238E0", VA = "0x18A024EE0", Slot = "53")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public Vector3 SZXZTHRYZSL
		{
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0xA0265D0", Offset = "0xA024FD0", VA = "0x18A0265D0", Slot = "54")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public Vector3 IZFYQQIUYRJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0xA023DD0", Offset = "0xA0227D0", VA = "0x18A023DD0", Slot = "55")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0xA024D20", Offset = "0xA023720", VA = "0x18A024D20", Slot = "56")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public Vector3 JROGDJXDQKE
		{
			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0xA025710", Offset = "0xA024110", VA = "0x18A025710", Slot = "57")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public float WRDRETNSTCQ
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0xA026290", Offset = "0xA024C90", VA = "0x18A026290", Slot = "58")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public float WURUEBFLLOL
		{
			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0xA024BA0", Offset = "0xA0235A0", VA = "0x18A024BA0", Slot = "59")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0xA027A30", Offset = "0xA026430", VA = "0x18A027A30", Slot = "60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public Vector3 LSZXGKRJVRR
		{
			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0xA028E00", Offset = "0xA027800", VA = "0x18A028E00", Slot = "61")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public Quaternion GOCCYCVSGLD
		{
			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0xA026170", Offset = "0xA024B70", VA = "0x18A026170", Slot = "62")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public float TEAHUUGNNOK
		{
			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0xA027240", Offset = "0xA025C40", VA = "0x18A027240", Slot = "64")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0xA026A20", Offset = "0xA025420", VA = "0x18A026A20", Slot = "65")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public float STVEYJONKSE
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0xA024BF0", Offset = "0xA0235F0", VA = "0x18A024BF0", Slot = "66")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0xA0277D0", Offset = "0xA0261D0", VA = "0x18A0277D0", Slot = "67")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public bool OSWXTAUUJQX
		{
			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0xA0235B0", Offset = "0xA021FB0", VA = "0x18A0235B0", Slot = "68")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0xA0258E0", Offset = "0xA0242E0", VA = "0x18A0258E0", Slot = "69")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public TransformTrackRate QAIPJDPLKNB
		{
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0xA023490", Offset = "0xA021E90", VA = "0x18A023490", Slot = "70")]
			get
			{
				return default(TransformTrackRate);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0xA0234E0", Offset = "0xA021EE0", VA = "0x18A0234E0", Slot = "71")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public bool CBIJVKAZZYJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0xA026840", Offset = "0xA025240", VA = "0x18A026840", Slot = "72")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public Transform YHXCWGCLCPJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0xEABE80", Offset = "0xEAA880", VA = "0x180EABE80", Slot = "73")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public Vector3 CUJKMYEUBZJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0xA024910", Offset = "0xA023310", VA = "0x18A024910", Slot = "74")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0xA028FA0", Offset = "0xA0279A0", VA = "0x18A028FA0", Slot = "75")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public float EFHRNQBDZAF
		{
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0xA023A80", Offset = "0xA022480", VA = "0x18A023A80", Slot = "76")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0xA026030", Offset = "0xA024A30", VA = "0x18A026030", Slot = "77")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public float TLPBRAXDDKO
		{
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0xA028F30", Offset = "0xA027930", VA = "0x18A028F30", Slot = "78")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0xA022F00", Offset = "0xA021900", VA = "0x18A022F00", Slot = "79")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public Quaternion MNNDKHLHEHU
		{
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0xA026FA0", Offset = "0xA0259A0", VA = "0x18A026FA0", Slot = "80")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0xA022CD0", Offset = "0xA0216D0", VA = "0x18A022CD0", Slot = "81")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public Vector3 JOGSRQJMWZG
		{
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0xA025310", Offset = "0xA023D10", VA = "0x18A025310", Slot = "82")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0xA0282B0", Offset = "0xA026CB0", VA = "0x18A0282B0", Slot = "83")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public Quaternion LFODOXUWQHP
		{
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0xA027E50", Offset = "0xA026850", VA = "0x18A027E50", Slot = "84")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0xA0283F0", Offset = "0xA026DF0", VA = "0x18A0283F0", Slot = "85")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public RigidbodyConstraints BRFYXOLZCXW
		{
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0xA025D10", Offset = "0xA024710", VA = "0x18A025D10", Slot = "86")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0xA026CE0", Offset = "0xA0256E0", VA = "0x18A026CE0", Slot = "87")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public bool NKNFNYBZXXV
		{
			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0xA026240", Offset = "0xA024C40", VA = "0x18A026240", Slot = "88")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0xA029100", Offset = "0xA027B00", VA = "0x18A029100", Slot = "89")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public CollisionDetectionMode NZWQSZICZJO
		{
			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0xA0264A0", Offset = "0xA024EA0", VA = "0x18A0264A0", Slot = "90")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0xA026890", Offset = "0xA025290", VA = "0x18A026890", Slot = "91")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public bool XGWXTLEZCYP
		{
			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0xA023730", Offset = "0xA022130", VA = "0x18A023730", Slot = "141")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public bool MRCGPFUHMWC
		{
			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0xA024A20", Offset = "0xA023420", VA = "0x18A024A20", Slot = "92")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000017")]
		public event RbexAction YLNBUCLIBKU
		{
			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0xA023370", Offset = "0xA021D70", VA = "0x18A023370", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0xA0249C0", Offset = "0xA0233C0", VA = "0x18A0249C0", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000018")]
		public event RbexAction OUJVHEBRGPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0xA0260C0", Offset = "0xA024AC0", VA = "0x18A0260C0", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0xA0262E0", Offset = "0xA024CE0", VA = "0x18A0262E0", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000019")]
		public event RbexParentChangeAction KPKZLGALJHC
		{
			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0xA0238D0", Offset = "0xA0222D0", VA = "0x18A0238D0", Slot = "18")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0xA028590", Offset = "0xA026F90", VA = "0x18A028590", Slot = "19")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001A")]
		public event RbexAction ITXXROJJITF
		{
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0xA0266B0", Offset = "0xA0250B0", VA = "0x18A0266B0", Slot = "8")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0xA0284E0", Offset = "0xA026EE0", VA = "0x18A0284E0", Slot = "9")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001B")]
		public event RbexAction EHAGBLPBDNE
		{
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0xA0246C0", Offset = "0xA0230C0", VA = "0x18A0246C0", Slot = "14")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0xA025940", Offset = "0xA024340", VA = "0x18A025940", Slot = "15")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001C")]
		public event RbexAction IFPNYWKNMIB
		{
			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0xA0240E0", Offset = "0xA022AE0", VA = "0x18A0240E0", Slot = "16")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0xA027F90", Offset = "0xA026990", VA = "0x18A027F90", Slot = "17")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001D")]
		public event Action<UpdateLOD, UpdateLOD> CSGCRCJQBEM
		{
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0xA023D70", Offset = "0xA022770", VA = "0x18A023D70", Slot = "20")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0xA028420", Offset = "0xA026E20", VA = "0x18A028420", Slot = "21")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001E")]
		public event RbexAction UEXVUWFUIRR
		{
			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0xA0233D0", Offset = "0xA021DD0", VA = "0x18A0233D0", Slot = "12")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0xA024800", Offset = "0xA023200", VA = "0x18A024800", Slot = "13")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001F")]
		public event RbexAction JKNPYNIICDY
		{
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0xA029050", Offset = "0xA027A50", VA = "0x18A029050", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0xA0282F0", Offset = "0xA026CF0", VA = "0x18A0282F0", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0xA029160", Offset = "0xA027B60", VA = "0x18A029160")]
		public PTYPBTHHGDG(GameObject a, RigidbodyEx b, TXSHHVHGWNE c, [In] RigidbodyExData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0xA027B00", Offset = "0xA026500", VA = "0x18A027B00", Slot = "139")]
		protected virtual void TCUGAKWEKPC(TXSHHVHGWNE a, RigidbodyExData b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0xA023980", Offset = "0xA022380", VA = "0x18A023980", Slot = "140")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0xA023000", Offset = "0xA021A00", VA = "0x18A023000", Slot = "93")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0xA026C50", Offset = "0xA025650", VA = "0x18A026C50", Slot = "94")]
		public void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0xA026BA0", Offset = "0xA0255A0", VA = "0x18A026BA0", Slot = "95")]
		public void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0xA026B80", Offset = "0xA025580", VA = "0x18A026B80", Slot = "96")]
		public void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0xA023A90", Offset = "0xA022490", VA = "0x18A023A90")]
		private void EBBJEEVITQI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0xA024060", Offset = "0xA022A60", VA = "0x18A024060")]
		private void EWBZXFQTRVT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0xA024140", Offset = "0xA022B40", VA = "0x18A024140")]
		private void EZCSABKDGIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0xA026420", Offset = "0xA024E20", VA = "0x18A026420", Slot = "30")]
		public LXUPYHZBZJT NJFBOEXBSEC(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0xA027970", Offset = "0xA026370", VA = "0x18A027970", Slot = "98")]
		public void SetParent(LXUPYHZBZJT value, bool isPhysicallyDetachedOnly = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0xA028480", Offset = "0xA026E80", VA = "0x18A028480", Slot = "99")]
		public void WRQDVZSAQUJ(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0xA022C70", Offset = "0xA021670", VA = "0x18A022C70", Slot = "100")]
		public void ALHGLJSLWJW(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0xA028D00", Offset = "0xA027700", VA = "0x18A028D00", Slot = "101")]
		public Vector3 YPKMPNFBOFR(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0xA026D90", Offset = "0xA025790", VA = "0x18A026D90", Slot = "102")]
		public Vector3 QAIXHGLGTND(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0xA028EE0", Offset = "0xA0278E0", VA = "0x18A028EE0", Slot = "103")]
		public void ZDKPEVDVEEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0xA025EB0", Offset = "0xA0248B0", VA = "0x18A025EB0", Slot = "104")]
		public void LVVLWBMRZLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0xA025FE0", Offset = "0xA0249E0", VA = "0x18A025FE0", Slot = "105")]
		public void MCQBNWMCNZI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0xA025350", Offset = "0xA023D50", VA = "0x18A025350", Slot = "106")]
		public void IHXJKMBIMTE(Vector3 a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0xA0231A0", Offset = "0xA021BA0", VA = "0x18A0231A0", Slot = "107")]
		public void BLHUQEBCBOP(Vector3 a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0xA025F00", Offset = "0xA024900", VA = "0x18A025F00", Slot = "108")]
		public void MANMXVCYIEK(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0xA027380", Offset = "0xA025D80", VA = "0x18A027380", Slot = "109")]
		public void QZFKXASVYKM(RbexImpulseType a, Vector3 b, float c, float d = 8f, float e = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0xA027040", Offset = "0xA025A40", VA = "0x18A027040", Slot = "110")]
		public void QKWMHBMXTOR(RbexRotationType a, Vector3 b, float c = 1f / 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0xA0288A0", Offset = "0xA0272A0", VA = "0x18A0288A0", Slot = "111")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void YCGZAVPWGQO(RbexRotationType a, Vector3 b, float c = 7f, float d = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0xA027140", Offset = "0xA025B40", VA = "0x18A027140", Slot = "112")]
		public Vector3 QSJCZUUDSVN(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0xA022DB0", Offset = "0xA0217B0", VA = "0x18A022DB0", Slot = "113")]
		public Vector3 AOXLURTOEVP(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0xA024860", Offset = "0xA023260", VA = "0x18A024860", Slot = "114")]
		public void GNUDOOUXQAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0xA027A90", Offset = "0xA026490", VA = "0x18A027A90", Slot = "115")]
		public void TAWPVMUYQXO(LXUPYHZBZJT a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0xA0252B0", Offset = "0xA023CB0", VA = "0x18A0252B0", Slot = "116")]
		public void IDTUFHGJOZT(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0xA0264F0", Offset = "0xA024EF0", VA = "0x18A0264F0", Slot = "63")]
		public void NPMABWUKGBF((Quaternion rot, Vector3 moments) tensor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0xA026B30", Offset = "0xA025530", VA = "0x18A026B30", Slot = "117")]
		public void OYEMNLQPEHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0xA025CC0", Offset = "0xA0246C0", VA = "0x18A025CC0", Slot = "118")]
		public void LAPJFJGAHUC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0xA026AE0", Offset = "0xA0254E0", VA = "0x18A026AE0", Slot = "119")]
		public void OXLQGXAIGFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0xA0257F0", Offset = "0xA0241F0", VA = "0x18A0257F0", Slot = "120")]
		public bool JGCPBCSKBCV()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0xA0279E0", Offset = "0xA0263E0", VA = "0x18A0279E0", Slot = "97")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0xA027760", Offset = "0xA026160", VA = "0x18A027760", Slot = "121")]
		public void RKYXLQNOLOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0xA028F40", Offset = "0xA027940", VA = "0x18A028F40", Slot = "122")]
		public void ZVQCSLWDZWM(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0xA0269C0", Offset = "0xA0253C0", VA = "0x18A0269C0", Slot = "123")]
		public void OLXCXOCOVEZ(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0xA023540", Offset = "0xA021F40", VA = "0x18A023540", Slot = "124")]
		public void DFZMGVMLCVL(object a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0xA0250B0", Offset = "0xA023AB0", VA = "0x18A0250B0", Slot = "125")]
		public void IANYDHQMCBV(Vector3 a, Quaternion b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0xA023600", Offset = "0xA022000", VA = "0x18A023600", Slot = "126")]
		public void DNWLVXMFKVJ(Vector3 a, Quaternion b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0xA022A90", Offset = "0xA021490", VA = "0x18A022A90", Slot = "127")]
		public bool AETYWSNIILY(float a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0xA023140", Offset = "0xA021B40", VA = "0x18A023140", Slot = "128")]
		public void BGYCNWQZPOH(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0xA023430", Offset = "0xA021E30", VA = "0x18A023430", Slot = "129")]
		public void CUDKGZWQNNK(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0xA027DF0", Offset = "0xA0267F0", VA = "0x18A027DF0", Slot = "130")]
		public void TFXFJGHHFHF(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0xA023870", Offset = "0xA022270", VA = "0x18A023870", Slot = "131")]
		public void DTJULSXSPPU(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0xA027FF0", Offset = "0xA0269F0", VA = "0x18A027FF0", Slot = "132")]
		public void USYWIONWZMS(Vector3 a, ForceMode b = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0xA028790", Offset = "0xA027190", VA = "0x18A028790", Slot = "133")]
		public void YAPLWXIDAZG(Vector3 a, Vector3 b, ForceMode c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0xA027890", Offset = "0xA026290", VA = "0x18A027890", Slot = "134")]
		public void SZAHRAMMZXH(Vector3 a, ForceMode b = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0xA024720", Offset = "0xA023120", VA = "0x18A024720", Slot = "135")]
		public void GHUSPGJLABX(Vector3 a, ForceMode b = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0xA024FB0", Offset = "0xA0239B0", VA = "0x18A024FB0", Slot = "136")]
		public bool HXXFZGWJNGE(Vector3 a, [Out] RaycastHit b, float c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0xA026C00", Offset = "0xA025600", VA = "0x18A026C00", Slot = "137")]
		public void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0xA027EF0", Offset = "0xA0268F0", VA = "0x18A027EF0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0xA0268F0", Offset = "0xA0252F0", VA = "0x18A0268F0")]
		private void OIDXDREMSHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0xA026E90", Offset = "0xA025890", VA = "0x18A026E90")]
		private void QCPFHMSHTJY(LXUPYHZBZJT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0xA0280D0", Offset = "0xA026AD0", VA = "0x18A0280D0")]
		private void UXFHJGSAMKJ(LXUPYHZBZJT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0xA022AE0", Offset = "0xA0214E0", VA = "0x18A022AE0")]
		private void AFJMWNEGQUG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0xA026710", Offset = "0xA025110", VA = "0x18A026710")]
		private void ODVRXNQHCMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0xA023EB0", Offset = "0xA0228B0", VA = "0x18A023EB0")]
		private void ETPSUOHODDV(LXUPYHZBZJT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0xA025520", Offset = "0xA023F20", VA = "0x18A025520")]
		private void IPTSEZGPFEE(LXUPYHZBZJT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0xA0259A0", Offset = "0xA0243A0", VA = "0x18A0259A0")]
		private void KBQMFYLCBTS(LXUPYHZBZJT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0xA028640", Offset = "0xA027040", VA = "0x18A028640")]
		private void XHKNEIJPFAJ(OGYYXGOOHSH a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0xA024280", Offset = "0xA022C80", VA = "0x18A024280", Slot = "142")]
		protected virtual void GAZNJWHLUGC(OGYYXGOOHSH a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0xA027440", Offset = "0xA025E40", VA = "0x18A027440")]
		protected void RHWMUQLQBRK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0xA0289B0", Offset = "0xA0273B0", VA = "0x18A0289B0")]
		protected void YDRSQNMAEPW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0xA0255F0", Offset = "0xA023FF0", VA = "0x18A0255F0")]
		private void IWHYREMTCCW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0xA025B50", Offset = "0xA024550", VA = "0x18A025B50")]
		private void KSFWWYKGGRF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	internal static class DOMVYLUGVPU
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0xA01DDD0", Offset = "0xA01C7D0", VA = "0x18A01DDD0")]
		public static LXUPYHZBZJT JPCOOTYCPHR(this LXUPYHZBZJT a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0xA01DC70", Offset = "0xA01C670", VA = "0x18A01DC70")]
		public static bool BHCQBJOERKC(this LXUPYHZBZJT a, LXUPYHZBZJT b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0xA01DE90", Offset = "0xA01C890", VA = "0x18A01DE90")]
		public static bool SZXQDMUKRLK(this LXUPYHZBZJT a, LXUPYHZBZJT b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0xA01DD80", Offset = "0xA01C780", VA = "0x18A01DD80")]
		public static OGYYXGOOHSH GKWVVVQMOHE(this LXUPYHZBZJT a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0xA01DD10", Offset = "0xA01C710", VA = "0x18A01DD10")]
		public static PTYPBTHHGDG Base(this LXUPYHZBZJT impl)
		{
			return null;
		}
	}
}
namespace RecRoom.Rbex.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class ETONMYGAMUJ : WTDUGPZWXSI
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0xA01EC70", Offset = "0xA01D670", VA = "0x18A01EC70", Slot = "19")]
		public LXUPYHZBZJT RTYDXWLWRNM(RigidbodyEx a, RigidbodyExData b, TXSHHVHGWNE c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF40", Offset = "0xCEE940", VA = "0x180CEFF40", Slot = "4")]
		public NQKBXILZAUJ AEOWBCZJYDR(LXUPYHZBZJT a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF40", Offset = "0xCEE940", VA = "0x180CEFF40", Slot = "5")]
		public FIDNUJTSXPT HCOSETOVPHF(LXUPYHZBZJT a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF40", Offset = "0xCEE940", VA = "0x180CEFF40", Slot = "6")]
		public BCXHEVYETUK GTPWLZDLDPW(LXUPYHZBZJT a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF40", Offset = "0xCEE940", VA = "0x180CEFF40", Slot = "7")]
		public XTQQSIWUNAD JAYJFJCBXND(LXUPYHZBZJT a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF40", Offset = "0xCEE940", VA = "0x180CEFF40", Slot = "8")]
		public VAQXZSQRJSJ MZWOLCOWJQT(LXUPYHZBZJT a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF40", Offset = "0xCEE940", VA = "0x180CEFF40", Slot = "9")]
		public SBEFVAXGCFY OCAPGECIGWM(LXUPYHZBZJT a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF40", Offset = "0xCEE940", VA = "0x180CEFF40", Slot = "10")]
		public ADFYPFYYJTJ OCDTSIECVCR(LXUPYHZBZJT a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF40", Offset = "0xCEE940", VA = "0x180CEFF40", Slot = "11")]
		public CPTWJAIUUZT WZIXDBDJNVJ(LXUPYHZBZJT a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF40", Offset = "0xCEE940", VA = "0x180CEFF40", Slot = "12")]
		public HYNZHTJVJYV EPSLMPHOXHV(LXUPYHZBZJT a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF40", Offset = "0xCEE940", VA = "0x180CEFF40", Slot = "13")]
		public HJSVZQWCZSU UWOGCCWBZSC(LXUPYHZBZJT a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF40", Offset = "0xCEE940", VA = "0x180CEFF40")]
		public AFCZAFOTJDY OGFPGPDGXUA(LXUPYHZBZJT a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF40", Offset = "0xCEE940", VA = "0x180CEFF40")]
		public LLGCBUIDYLE DEUYBJBKGKE(LXUPYHZBZJT a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF40", Offset = "0xCEE940", VA = "0x180CEFF40")]
		public FFFMJOLTGZC VMKRPZSJBPQ(LXUPYHZBZJT a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF40", Offset = "0xCEE940", VA = "0x180CEFF40")]
		public ABJGSSFBSGY FLBXRNWIHHY(LXUPYHZBZJT a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF40", Offset = "0xCEE940", VA = "0x180CEFF40")]
		public IHWEUKEKZTG AWFTSRBVHWO(LXUPYHZBZJT a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
		public ETONMYGAMUJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF40", Offset = "0xCEE940", VA = "0x180CEFF40", Slot = "14")]
		private AFCZAFOTJDY YUPTTIWPIPG(LXUPYHZBZJT a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF40", Offset = "0xCEE940", VA = "0x180CEFF40", Slot = "15")]
		private LLGCBUIDYLE ZPXXPSYNDKI(LXUPYHZBZJT a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF40", Offset = "0xCEE940", VA = "0x180CEFF40", Slot = "16")]
		private FFFMJOLTGZC RUAEOWTOHBM(LXUPYHZBZJT a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF40", Offset = "0xCEE940", VA = "0x180CEFF40", Slot = "17")]
		private ABJGSSFBSGY SYJIIBGLGXE(LXUPYHZBZJT a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF40", Offset = "0xCEE940", VA = "0x180CEFF40", Slot = "18")]
		private IHWEUKEKZTG XMCYAIIKVDM(LXUPYHZBZJT a, [In] RigidbodyExData data)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[RegisterService(typeof(WTDUGPZWXSI), new string[] { })]
	public class OWGUNCTTUDK : WTDUGPZWXSI, DTRQAXWKVLM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private readonly WTDUGPZWXSI HKDACAFVBGX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private readonly WTDUGPZWXSI CPAYGTRCYSA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private PLVWZTFMBVA WHGLCRXLQEF;

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		private WTDUGPZWXSI BWDHSISXXES
		{
			[Cpp2IlInjected.Token(Token = "0x600021F")]
			[Cpp2IlInjected.Address(RVA = "0xA021B80", Offset = "0xA020580", VA = "0x18A021B80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0xA021600", Offset = "0xA020000", VA = "0x18A021600", Slot = "20")]
		public void InitReferences(PPCVAYWFABF services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0xA021170", Offset = "0xA01FB70", VA = "0x18A021170", Slot = "4")]
		public NQKBXILZAUJ AEOWBCZJYDR(LXUPYHZBZJT a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0xA021560", Offset = "0xA01FF60", VA = "0x18A021560", Slot = "5")]
		public FIDNUJTSXPT HCOSETOVPHF(LXUPYHZBZJT a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0xA0214C0", Offset = "0xA01FEC0", VA = "0x18A0214C0", Slot = "6")]
		public BCXHEVYETUK GTPWLZDLDPW(LXUPYHZBZJT a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0xA021650", Offset = "0xA020050", VA = "0x18A021650", Slot = "7")]
		public XTQQSIWUNAD JAYJFJCBXND(LXUPYHZBZJT a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0xA0216F0", Offset = "0xA0200F0", VA = "0x18A0216F0", Slot = "8")]
		public VAQXZSQRJSJ MZWOLCOWJQT(LXUPYHZBZJT a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0xA021790", Offset = "0xA020190", VA = "0x18A021790", Slot = "9")]
		public SBEFVAXGCFY OCAPGECIGWM(LXUPYHZBZJT a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0xA021830", Offset = "0xA020230", VA = "0x18A021830", Slot = "10")]
		public ADFYPFYYJTJ OCDTSIECVCR(LXUPYHZBZJT a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0xA021C80", Offset = "0xA020680", VA = "0x18A021C80", Slot = "11")]
		public CPTWJAIUUZT WZIXDBDJNVJ(LXUPYHZBZJT a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0xA021370", Offset = "0xA01FD70", VA = "0x18A021370", Slot = "12")]
		public HYNZHTJVJYV EPSLMPHOXHV(LXUPYHZBZJT a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0xA021BE0", Offset = "0xA0205E0", VA = "0x18A021BE0", Slot = "13")]
		public HJSVZQWCZSU UWOGCCWBZSC(LXUPYHZBZJT a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0xA0218D0", Offset = "0xA0202D0", VA = "0x18A0218D0")]
		public AFCZAFOTJDY OGFPGPDGXUA(LXUPYHZBZJT a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0xA0212C0", Offset = "0xA01FCC0", VA = "0x18A0212C0")]
		public LLGCBUIDYLE DEUYBJBKGKE(LXUPYHZBZJT a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0xA021AD0", Offset = "0xA0204D0", VA = "0x18A021AD0")]
		public FFFMJOLTGZC VMKRPZSJBPQ(LXUPYHZBZJT a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0xA021410", Offset = "0xA01FE10", VA = "0x18A021410")]
		public ABJGSSFBSGY FLBXRNWIHHY(LXUPYHZBZJT a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0xA021210", Offset = "0xA01FC10", VA = "0x18A021210")]
		public IHWEUKEKZTG AWFTSRBVHWO(LXUPYHZBZJT a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0xA021980", Offset = "0xA020380", VA = "0x18A021980", Slot = "19")]
		public LXUPYHZBZJT RTYDXWLWRNM(RigidbodyEx a, RigidbodyExData b, TXSHHVHGWNE c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0xA021D20", Offset = "0xA020720", VA = "0x18A021D20")]
		public OWGUNCTTUDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0xA0218D0", Offset = "0xA0202D0", VA = "0x18A0218D0", Slot = "14")]
		private AFCZAFOTJDY YUPTTIWPIPG(LXUPYHZBZJT a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0xA0212C0", Offset = "0xA01FCC0", VA = "0x18A0212C0", Slot = "15")]
		private LLGCBUIDYLE ZPXXPSYNDKI(LXUPYHZBZJT a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0xA021AD0", Offset = "0xA0204D0", VA = "0x18A021AD0", Slot = "16")]
		private FFFMJOLTGZC RUAEOWTOHBM(LXUPYHZBZJT a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0xA021410", Offset = "0xA01FE10", VA = "0x18A021410", Slot = "17")]
		private ABJGSSFBSGY SYJIIBGLGXE(LXUPYHZBZJT a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0xA021210", Offset = "0xA01FC10", VA = "0x18A021210", Slot = "18")]
		private IHWEUKEKZTG XMCYAIIKVDM(LXUPYHZBZJT a, [In] RigidbodyExData data)
		{
			return null;
		}
	}
}
namespace RecRoom.Rbex.Legacy
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public interface KZWEZASRUOM : NQKBXILZAUJ, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void AZYZTCUIDGT(LXUPYHZBZJT a);

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void ODGWVXJIHZI(LXUPYHZBZJT a);

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void SHCZWOOICNP(LXUPYHZBZJT a);

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void SXZFAMPUTNS(LXUPYHZBZJT a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public interface WLVGHHIBBSD : BCXHEVYETUK
	{
		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		VQKXWVKLBEP<LXUPYHZBZJT> MLISGCOADCG
		{
			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		LXUPYHZBZJT DMQLSXJGPVO
		{
			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public interface VVUABGCSELB : ABJGSSFBSGY
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		(float, Vector3) VHRIAWQLATM(Rigidbody a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public interface VTYXRYWUZAT : LLGCBUIDYLE, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		RRNetworkView ZRBHEYPJALJ
		{
			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	internal sealed class UTMSZZATPOC : HYNZHTJVJYV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private readonly PTYPBTHHGDG WGQNBVLMTNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private CollisionDetectionMode PKCWNBDTYPM;

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		private Rigidbody EUMMWSSQGSM
		{
			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0xA034940", Offset = "0xA033340", VA = "0x18A034940")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		public CollisionDetectionMode NZWQSZICZJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0xA035370", Offset = "0xA033D70", VA = "0x18A035370", Slot = "4")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0xA035480", Offset = "0xA033E80", VA = "0x18A035480", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0xA020320", Offset = "0xA01ED20", VA = "0x18A020320")]
		public UTMSZZATPOC(LXUPYHZBZJT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0xA034FE0", Offset = "0xA0339E0", VA = "0x18A034FE0", Slot = "6")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0xA0354F0", Offset = "0xA033EF0", VA = "0x18A0354F0", Slot = "9")]
		public void SMDWCQWJFSZ(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0xA035570", Offset = "0xA033F70", VA = "0x18A035570", Slot = "7")]
		public void UFRYBKIKRJO(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0xA035580", Offset = "0xA033F80", VA = "0x18A035580", Slot = "8")]
		public void ZGFHBBRUKKH(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0xA035210", Offset = "0xA033C10", VA = "0x18A035210", Slot = "10")]
		public bool HXXFZGWJNGE(Vector3 a, [Out] RaycastHit b, float c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0xA0350F0", Offset = "0xA033AF0", VA = "0x18A0350F0")]
		private void HVUULOSQOTG(bool a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public sealed class SUNFKJQTYAH : SBEFVAXGCFY, IDisposable, SBSVZTMKGKU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly PTYPBTHHGDG WGQNBVLMTNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private TransformTrackRate UUJEZIOYIIT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private ROTQQCMUGGZ RSILDSVDTVZ;

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		public TransformTrackRate QAIPJDPLKNB
		{
			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0xA033860", Offset = "0xA032260", VA = "0x18A033860", Slot = "6")]
			get
			{
				return default(TransformTrackRate);
			}
			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0xA0339A0", Offset = "0xA0323A0", VA = "0x18A0339A0", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000092")]
		private Transform IDVIIKQTPWA
		{
			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0xA033B70", Offset = "0xA032570", VA = "0x18A033B70", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000020")]
		public event Action<UpdateLOD, UpdateLOD> CSGCRCJQBEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0xA033AC0", Offset = "0xA0324C0", VA = "0x18A033AC0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0xA033B90", Offset = "0xA032590", VA = "0x18A033B90", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0xA033C40", Offset = "0xA032640", VA = "0x18A033C40")]
		public SUNFKJQTYAH(LXUPYHZBZJT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0xA0335F0", Offset = "0xA031FF0", VA = "0x18A0335F0", Slot = "8")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0xA033A70", Offset = "0xA032470", VA = "0x18A033A70", Slot = "9")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x13DA190", Offset = "0x13D8B90", VA = "0x1813DA190", Slot = "11")]
		private void CHAAODDTBNN(UpdateLOD a, UpdateLOD b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEE930", VA = "0x180CEFF30", Slot = "12")]
		private void IPRAGVDYFNB(bool a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class ETONMYGAMUJ : WTDUGPZWXSI
	{
		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0xA01DF30", Offset = "0xA01C930", VA = "0x18A01DF30", Slot = "4")]
		public NQKBXILZAUJ AEOWBCZJYDR(LXUPYHZBZJT a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0xA01E600", Offset = "0xA01D000", VA = "0x18A01E600", Slot = "5")]
		public FIDNUJTSXPT HCOSETOVPHF(LXUPYHZBZJT a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0xA01E4E0", Offset = "0xA01CEE0", VA = "0x18A01E4E0", Slot = "6")]
		public BCXHEVYETUK GTPWLZDLDPW(LXUPYHZBZJT a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0xA01E710", Offset = "0xA01D110", VA = "0x18A01E710", Slot = "7")]
		public XTQQSIWUNAD JAYJFJCBXND(LXUPYHZBZJT a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0xA01E780", Offset = "0xA01D180", VA = "0x18A01E780", Slot = "8")]
		public VAQXZSQRJSJ MZWOLCOWJQT(LXUPYHZBZJT a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0xA01E840", Offset = "0xA01D240", VA = "0x18A01E840", Slot = "9")]
		public SBEFVAXGCFY OCAPGECIGWM(LXUPYHZBZJT a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0xA01E900", Offset = "0xA01D300", VA = "0x18A01E900", Slot = "10")]
		public ADFYPFYYJTJ OCDTSIECVCR(LXUPYHZBZJT a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0xA01EEE0", Offset = "0xA01D8E0", VA = "0x18A01EEE0", Slot = "11")]
		public CPTWJAIUUZT WZIXDBDJNVJ(LXUPYHZBZJT a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0xA01E2A0", Offset = "0xA01CCA0", VA = "0x18A01E2A0", Slot = "12")]
		public HYNZHTJVJYV EPSLMPHOXHV(LXUPYHZBZJT a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0xA01EE20", Offset = "0xA01D820", VA = "0x18A01EE20", Slot = "13")]
		public HJSVZQWCZSU UWOGCCWBZSC(LXUPYHZBZJT a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0xA01EA10", Offset = "0xA01D410", VA = "0x18A01EA10")]
		public AFCZAFOTJDY OGFPGPDGXUA(LXUPYHZBZJT a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0xA01E0E0", Offset = "0xA01CAE0", VA = "0x18A01E0E0")]
		public LLGCBUIDYLE DEUYBJBKGKE(LXUPYHZBZJT a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0xA01ED00", Offset = "0xA01D700", VA = "0x18A01ED00")]
		public FFFMJOLTGZC VMKRPZSJBPQ(LXUPYHZBZJT a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0xA01E360", Offset = "0xA01CD60", VA = "0x18A01E360")]
		public ABJGSSFBSGY FLBXRNWIHHY(LXUPYHZBZJT a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0xA01E010", Offset = "0xA01CA10", VA = "0x18A01E010")]
		public IHWEUKEKZTG AWFTSRBVHWO(LXUPYHZBZJT a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0xA01EB30", Offset = "0xA01D530", VA = "0x18A01EB30", Slot = "19")]
		public LXUPYHZBZJT RTYDXWLWRNM(RigidbodyEx a, RigidbodyExData b, TXSHHVHGWNE c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
		public ETONMYGAMUJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0xA01EA10", Offset = "0xA01D410", VA = "0x18A01EA10", Slot = "14")]
		private AFCZAFOTJDY YUPTTIWPIPG(LXUPYHZBZJT a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0xA01EFA0", Offset = "0xA01D9A0", VA = "0x18A01EFA0", Slot = "15")]
		private LLGCBUIDYLE ZPXXPSYNDKI(LXUPYHZBZJT a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0xA01ED00", Offset = "0xA01D700", VA = "0x18A01ED00", Slot = "16")]
		private FFFMJOLTGZC RUAEOWTOHBM(LXUPYHZBZJT a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0xA01E360", Offset = "0xA01CD60", VA = "0x18A01E360", Slot = "17")]
		private ABJGSSFBSGY SYJIIBGLGXE(LXUPYHZBZJT a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0xA01E010", Offset = "0xA01CA10", VA = "0x18A01E010", Slot = "18")]
		private IHWEUKEKZTG XMCYAIIKVDM(LXUPYHZBZJT a, [In] RigidbodyExData data)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal sealed class TVNWSCQCDBC : CPTWJAIUUZT
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private readonly PTYPBTHHGDG WGQNBVLMTNL;

		[Cpp2IlInjected.Token(Token = "0x17000093")]
		private Rigidbody EUMMWSSQGSM
		{
			[Cpp2IlInjected.Token(Token = "0x6000268")]
			[Cpp2IlInjected.Address(RVA = "0xA034940", Offset = "0xA033340", VA = "0x18A034940")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000094")]
		private bool CBIJVKAZZYJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000269")]
			[Cpp2IlInjected.Address(RVA = "0xA034990", Offset = "0xA033390", VA = "0x18A034990")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000095")]
		private bool DOFZZALFMLC
		{
			[Cpp2IlInjected.Token(Token = "0x600026A")]
			[Cpp2IlInjected.Address(RVA = "0xA01F140", Offset = "0xA01DB40", VA = "0x18A01F140")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000096")]
		private LXUPYHZBZJT LXEGSVYJGSM
		{
			[Cpp2IlInjected.Token(Token = "0x600026B")]
			[Cpp2IlInjected.Address(RVA = "0xA034680", Offset = "0xA033080", VA = "0x18A034680")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0xA020320", Offset = "0xA01ED20", VA = "0x18A020320")]
		public TVNWSCQCDBC(LXUPYHZBZJT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0xA034B40", Offset = "0xA033540", VA = "0x18A034B40", Slot = "4")]
		public void USYWIONWZMS(Vector3 a, ForceMode b = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0xA034420", Offset = "0xA032E20", VA = "0x18A034420")]
		private void IGEEUTOEEQF(Vector3 a, ForceMode b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0xA034CA0", Offset = "0xA0336A0", VA = "0x18A034CA0", Slot = "5")]
		public void YAPLWXIDAZG(Vector3 a, Vector3 b, ForceMode c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0xA0349E0", Offset = "0xA0333E0", VA = "0x18A0349E0", Slot = "6")]
		public void SZAHRAMMZXH(Vector3 a, ForceMode b = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0xA0346E0", Offset = "0xA0330E0", VA = "0x18A0346E0")]
		private void JLQVJZPBXSM(Vector3 a, ForceMode b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0xA0341C0", Offset = "0xA032BC0", VA = "0x18A0341C0", Slot = "7")]
		public void GHUSPGJLABX(Vector3 a, ForceMode b = ForceMode.Force)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	internal sealed class NJYSCWYZFUF : HJSVZQWCZSU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private readonly PTYPBTHHGDG WGQNBVLMTNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private bool CXZSEVKSYPF;

		[Cpp2IlInjected.Token(Token = "0x17000097")]
		public bool OSWXTAUUJQX
		{
			[Cpp2IlInjected.Token(Token = "0x6000274")]
			[Cpp2IlInjected.Address(RVA = "0xEA3E30", Offset = "0xEA2830", VA = "0x180EA3E30", Slot = "4")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000275")]
			[Cpp2IlInjected.Address(RVA = "0xA020170", Offset = "0xA01EB70", VA = "0x18A020170", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0xA020320", Offset = "0xA01ED20", VA = "0x18A020320")]
		public NJYSCWYZFUF(LXUPYHZBZJT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0xA0202F0", Offset = "0xA01ECF0", VA = "0x18A0202F0", Slot = "6")]
		public void SMDWCQWJFSZ(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0xA020280", Offset = "0xA01EC80", VA = "0x18A020280", Slot = "7")]
		public void SBBJNFQRYPU(Rigidbody a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	internal sealed class RbexHierarchy : KZWEZASRUOM, NQKBXILZAUJ, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private readonly LXUPYHZBZJT WGQNBVLMTNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private readonly List<LXUPYHZBZJT> MMOXRKKOZUD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private LXUPYHZBZJT CNBVPAWZDFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private LXUPYHZBZJT PMPLOCZDTJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private Transform PXFVEKFSIOL;

		[Cpp2IlInjected.Token(Token = "0x17000098")]
		private Transform IBGMOBEIUDO
		{
			[Cpp2IlInjected.Token(Token = "0x600028A")]
			[Cpp2IlInjected.Address(RVA = "0xA029A50", Offset = "0xA028450", VA = "0x18A029A50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000099")]
		public LXUPYHZBZJT LXEGSVYJGSM
		{
			[Cpp2IlInjected.Token(Token = "0x600028D")]
			[Cpp2IlInjected.Address(RVA = "0xCEE720", Offset = "0xCED120", VA = "0x180CEE720", Slot = "28")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600028E")]
			[Cpp2IlInjected.Address(RVA = "0xA02AF80", Offset = "0xA029980", VA = "0x18A02AF80", Slot = "29")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009A")]
		public LXUPYHZBZJT OFIFJQDFJXG
		{
			[Cpp2IlInjected.Token(Token = "0x600028F")]
			[Cpp2IlInjected.Address(RVA = "0xCEE740", Offset = "0xCED140", VA = "0x180CEE740", Slot = "27")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		public IReadOnlyList<LXUPYHZBZJT> VFZTJRIUBHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000290")]
			[Cpp2IlInjected.Address(RVA = "0xCEE130", Offset = "0xCECB30", VA = "0x180CEE130", Slot = "26")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000021")]
		public event RbexAction YLNBUCLIBKU
		{
			[Cpp2IlInjected.Token(Token = "0x6000278")]
			[Cpp2IlInjected.Address(RVA = "0xA0297C0", Offset = "0xA0281C0", VA = "0x18A0297C0", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000279")]
			[Cpp2IlInjected.Address(RVA = "0xA029C10", Offset = "0xA028610", VA = "0x18A029C10", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000022")]
		public event RbexAction OUJVHEBRGPM
		{
			[Cpp2IlInjected.Token(Token = "0x600027A")]
			[Cpp2IlInjected.Address(RVA = "0xA029FB0", Offset = "0xA0289B0", VA = "0x18A029FB0", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600027B")]
			[Cpp2IlInjected.Address(RVA = "0xA02A090", Offset = "0xA028A90", VA = "0x18A02A090", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000023")]
		public event RbexParentChangeAction KPKZLGALJHC
		{
			[Cpp2IlInjected.Token(Token = "0x600027C")]
			[Cpp2IlInjected.Address(RVA = "0xA029910", Offset = "0xA028310", VA = "0x18A029910", Slot = "12")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600027D")]
			[Cpp2IlInjected.Address(RVA = "0xA02B0C0", Offset = "0xA029AC0", VA = "0x18A02B0C0", Slot = "13")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000024")]
		public event Action TMMQHJCUGDD
		{
			[Cpp2IlInjected.Token(Token = "0x600027E")]
			[Cpp2IlInjected.Address(RVA = "0xA02AE30", Offset = "0xA029830", VA = "0x18A02AE30", Slot = "14")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600027F")]
			[Cpp2IlInjected.Address(RVA = "0xA029F10", Offset = "0xA028910", VA = "0x18A029F10", Slot = "15")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000025")]
		public event Action HXHBELZVDTU
		{
			[Cpp2IlInjected.Token(Token = "0x6000280")]
			[Cpp2IlInjected.Address(RVA = "0xA029AB0", Offset = "0xA0284B0", VA = "0x18A029AB0", Slot = "16")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000281")]
			[Cpp2IlInjected.Address(RVA = "0xA02B210", Offset = "0xA029C10", VA = "0x18A02B210", Slot = "17")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000026")]
		public event Action<LXUPYHZBZJT> ZILSWZCUUGX
		{
			[Cpp2IlInjected.Token(Token = "0x6000282")]
			[Cpp2IlInjected.Address(RVA = "0xA0295D0", Offset = "0xA027FD0", VA = "0x18A0295D0", Slot = "18")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000283")]
			[Cpp2IlInjected.Address(RVA = "0xA02AED0", Offset = "0xA0298D0", VA = "0x18A02AED0", Slot = "19")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000027")]
		public event Action<LXUPYHZBZJT> ZVYLLUTFFLK
		{
			[Cpp2IlInjected.Token(Token = "0x6000284")]
			[Cpp2IlInjected.Address(RVA = "0xA02B160", Offset = "0xA029B60", VA = "0x18A02B160", Slot = "20")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000285")]
			[Cpp2IlInjected.Address(RVA = "0xA02A130", Offset = "0xA028B30", VA = "0x18A02A130", Slot = "21")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000028")]
		public event Action FHOQKHPSETV
		{
			[Cpp2IlInjected.Token(Token = "0x6000286")]
			[Cpp2IlInjected.Address(RVA = "0xA02A280", Offset = "0xA028C80", VA = "0x18A02A280", Slot = "22")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000287")]
			[Cpp2IlInjected.Address(RVA = "0xA029E70", Offset = "0xA028870", VA = "0x18A029E70", Slot = "23")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000029")]
		public event Action<LXUPYHZBZJT> SVJWKOWWXQQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000288")]
			[Cpp2IlInjected.Address(RVA = "0xA029860", Offset = "0xA028260", VA = "0x18A029860", Slot = "24")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000289")]
			[Cpp2IlInjected.Address(RVA = "0xA02A320", Offset = "0xA028D20", VA = "0x18A02A320", Slot = "25")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0xA02B2B0", Offset = "0xA029CB0", VA = "0x18A02B2B0")]
		public RbexHierarchy(LXUPYHZBZJT rbex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0xA0299B0", Offset = "0xA0283B0", VA = "0x18A0299B0", Slot = "31")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0xA02A8C0", Offset = "0xA0292C0", VA = "0x18A02A8C0", Slot = "30")]
		public void SetParent(LXUPYHZBZJT newParent, bool isPhysicallyDetachedOnly = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0xA02A3D0", Offset = "0xA028DD0", VA = "0x18A02A3D0", Slot = "6")]
		public void SHCZWOOICNP(LXUPYHZBZJT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0xA02A640", Offset = "0xA029040", VA = "0x18A02A640", Slot = "7")]
		public void SXZFAMPUTNS(LXUPYHZBZJT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0xA0294E0", Offset = "0xA027EE0", VA = "0x18A0294E0", Slot = "4")]
		public void AZYZTCUIDGT(LXUPYHZBZJT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0xA02A1E0", Offset = "0xA028BE0", VA = "0x18A02A1E0", Slot = "5")]
		public void ODGWVXJIHZI(LXUPYHZBZJT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0xA029DD0", Offset = "0xA0287D0", VA = "0x18A029DD0")]
		private void JKIWDNRYGLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0xA02A050", Offset = "0xA028A50", VA = "0x18A02A050")]
		private void MQPOOIDHNPG(LXUPYHZBZJT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0xA029680", Offset = "0xA028080", VA = "0x18A029680")]
		private void CHJURTWSTYJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0xA02AF90", Offset = "0xA029990", VA = "0x18A02AF90")]
		private void UYPRWNBICJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0xA029CB0", Offset = "0xA0286B0", VA = "0x18A029CB0")]
		private void IIDYCPXELIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0xA029B50", Offset = "0xA028550", VA = "0x18A029B50")]
		[CompilerGenerated]
		private object GTANLCALDFK()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	internal static class UEEJRWTGJWG
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0xA034F20", Offset = "0xA033920", VA = "0x18A034F20")]
		public static KZWEZASRUOM SSIKHXUTKDV(this LXUPYHZBZJT a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	internal sealed class OAFMDNLCBJZ : WLVGHHIBBSD, BCXHEVYETUK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly PTYPBTHHGDG WGQNBVLMTNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private readonly VQKXWVKLBEP<LXUPYHZBZJT> DWCTFEINHLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private bool KVSCJZWYALB;

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		public VQKXWVKLBEP<LXUPYHZBZJT> MLISGCOADCG
		{
			[Cpp2IlInjected.Token(Token = "0x600029D")]
			[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		public Vector3 XKMDQDDFWQV
		{
			[Cpp2IlInjected.Token(Token = "0x600029E")]
			[Cpp2IlInjected.Address(RVA = "0xA020830", Offset = "0xA01F230", VA = "0x18A020830", Slot = "6")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		public Vector3 SZXZTHRYZSL
		{
			[Cpp2IlInjected.Token(Token = "0x600029F")]
			[Cpp2IlInjected.Address(RVA = "0xA0208C0", Offset = "0xA01F2C0", VA = "0x18A0208C0", Slot = "7")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		private Vector3 ICEPCSIMYGD
		{
			[Cpp2IlInjected.Token(Token = "0x60002A3")]
			[Cpp2IlInjected.Address(RVA = "0xA020750", Offset = "0xA01F150", VA = "0x18A020750")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		public LXUPYHZBZJT DMQLSXJGPVO
		{
			[Cpp2IlInjected.Token(Token = "0x60002A4")]
			[Cpp2IlInjected.Address(RVA = "0xA020FD0", Offset = "0xA01F9D0", VA = "0x18A020FD0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0xA021080", Offset = "0xA01FA80", VA = "0x18A021080")]
		public OAFMDNLCBJZ(LXUPYHZBZJT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0xA020F60", Offset = "0xA01F960", VA = "0x18A020F60", Slot = "8")]
		public void XYQXFHSLXHJ(LXUPYHZBZJT a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0xA020860", Offset = "0xA01F260", VA = "0x18A020860", Slot = "9")]
		public void KJSPAQXWVQU(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0xA020BC0", Offset = "0xA01F5C0", VA = "0x18A020BC0")]
		private Vector3 PKJYRHEWVAV()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0xA0203B0", Offset = "0xA01EDB0", VA = "0x18A0203B0")]
		private void CIHYXCUKXOO(LXUPYHZBZJT a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	internal static class QNQTMYTXCYZ
	{
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0xA029420", Offset = "0xA027E20", VA = "0x18A029420")]
		public static WLVGHHIBBSD AUWTYOUEPTK(this LXUPYHZBZJT a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	internal sealed class SKBTNPXHJUH : VVUABGCSELB, ABJGSSFBSGY
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private readonly PTYPBTHHGDG WGQNBVLMTNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private readonly OverridableVector3 NLAISIVWVTM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private readonly OverridableVector3 LXSTGPBVFZN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private float RQQQKIUSRDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private float KYXHKEHMMKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private Vector3 VACERFKWSBR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private Vector3? WUEPDLUALNZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private Quaternion? LFKDVZTTNPX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private bool TFNWGLMHOJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private bool MPMGKFZUPEF;

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		public Vector3 IZFYQQIUYRJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002AA")]
			[Cpp2IlInjected.Address(RVA = "0x1EDA3C0", Offset = "0x1ED8DC0", VA = "0x181EDA3C0", Slot = "7")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60002AB")]
			[Cpp2IlInjected.Address(RVA = "0xA030EE0", Offset = "0xA02F8E0", VA = "0x18A030EE0", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		public Vector3 JROGDJXDQKE
		{
			[Cpp2IlInjected.Token(Token = "0x60002AC")]
			[Cpp2IlInjected.Address(RVA = "0xA030F90", Offset = "0xA02F990", VA = "0x18A030F90", Slot = "9")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		public float WRDRETNSTCQ
		{
			[Cpp2IlInjected.Token(Token = "0x60002AD")]
			[Cpp2IlInjected.Address(RVA = "0xD40A60", Offset = "0xD3F460", VA = "0x180D40A60", Slot = "10")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60002AE")]
			[Cpp2IlInjected.Address(RVA = "0xA030DD0", Offset = "0xA02F7D0", VA = "0x18A030DD0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A4")]
		public float WURUEBFLLOL
		{
			[Cpp2IlInjected.Token(Token = "0x60002AF")]
			[Cpp2IlInjected.Address(RVA = "0xD40A70", Offset = "0xD3F470", VA = "0x180D40A70", Slot = "11")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60002B0")]
			[Cpp2IlInjected.Address(RVA = "0xA031230", Offset = "0xA02FC30", VA = "0x18A031230", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		public Vector3 LSZXGKRJVRR
		{
			[Cpp2IlInjected.Token(Token = "0x60002B1")]
			[Cpp2IlInjected.Address(RVA = "0xA033300", Offset = "0xA031D00", VA = "0x18A033300", Slot = "13")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A6")]
		public Quaternion GOCCYCVSGLD
		{
			[Cpp2IlInjected.Token(Token = "0x60002B2")]
			[Cpp2IlInjected.Address(RVA = "0xA0313C0", Offset = "0xA02FDC0", VA = "0x18A0313C0", Slot = "14")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A7")]
		private Rigidbody EUMMWSSQGSM
		{
			[Cpp2IlInjected.Token(Token = "0x60002BA")]
			[Cpp2IlInjected.Address(RVA = "0xA0224D0", Offset = "0xA020ED0", VA = "0x18A0224D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400002A")]
		public event RbexAction YCQZDDFZPPU
		{
			[Cpp2IlInjected.Token(Token = "0x60002A8")]
			[Cpp2IlInjected.Address(RVA = "0xA033260", Offset = "0xA031C60", VA = "0x18A033260", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60002A9")]
			[Cpp2IlInjected.Address(RVA = "0xA032350", Offset = "0xA030D50", VA = "0x18A032350", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0xA033490", Offset = "0xA031E90", VA = "0x18A033490")]
		public SKBTNPXHJUH(LXUPYHZBZJT a, [In] RigidbodyExData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0xA031910", Offset = "0xA030310", VA = "0x18A031910", Slot = "17")]
		public void OYEMNLQPEHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0xA0312E0", Offset = "0xA02FCE0", VA = "0x18A0312E0", Slot = "16")]
		public void LAPJFJGAHUC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0xA0320D0", Offset = "0xA030AD0", VA = "0x18A0320D0", Slot = "19")]
		public void SMDWCQWJFSZ(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0xA031EF0", Offset = "0xA0308F0", VA = "0x18A031EF0", Slot = "20")]
		public void SBBJNFQRYPU(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0xA031770", Offset = "0xA030170", VA = "0x18A031770", Slot = "18")]
		public void OXLQGXAIGFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0xA031A30", Offset = "0xA030430", VA = "0x18A031A30", Slot = "21")]
		public void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0xA030EE0", Offset = "0xA02F8E0", VA = "0x18A030EE0")]
		private void QUJXDFPFGML(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0xA030CB0", Offset = "0xA02F6B0", VA = "0x18A030CB0")]
		[Obsolete("This method is dangerous - the unity rigidbody is updated in a deferred manner and this world position may be stale")]
		private Vector3 CCQHMDIXFPK()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0xA030DD0", Offset = "0xA02F7D0", VA = "0x18A030DD0")]
		private void DININTCDFPO(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0xA031230", Offset = "0xA02FC30", VA = "0x18A031230")]
		private void KTPWFQPLKMT(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0xA0321B0", Offset = "0xA030BB0", VA = "0x18A0321B0")]
		private Vector3 SUXMJAIKGED()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0xA031540", Offset = "0xA02FF40", VA = "0x18A031540", Slot = "15")]
		public void NPMABWUKGBF((Quaternion rot, Vector3 moments) tensor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0xA0310B0", Offset = "0xA02FAB0", VA = "0x18A0310B0")]
		private Quaternion JZBISQYTRAR()
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0xA033190", Offset = "0xA031B90", VA = "0x18A033190")]
		public void VHRIAWQLATM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0xA0323F0", Offset = "0xA030DF0", VA = "0x18A0323F0", Slot = "4")]
		public (float, Vector3) VHRIAWQLATM(Rigidbody a)
		{
			return default((float, Vector3));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	internal static class SJLJPHKCPEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0xA030BF0", Offset = "0xA02F5F0", VA = "0x18A030BF0")]
		public static VVUABGCSELB JLEWPTMTEPI(this LXUPYHZBZJT a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	internal sealed class LSONWYJENIF : FFFMJOLTGZC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private readonly PTYPBTHHGDG WGQNBVLMTNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private readonly SMMLEVHGFEC RFHTJYMJWCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private readonly RbexInterpolationMode WJBPLMVLSAR;

		[Cpp2IlInjected.Token(Token = "0x170000A8")]
		public bool FUNAPTGQPFD
		{
			[Cpp2IlInjected.Token(Token = "0x60002C5")]
			[Cpp2IlInjected.Address(RVA = "0x1B62FA0", Offset = "0x1B619A0", VA = "0x181B62FA0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A9")]
		public RbexInterpolationMode VCPJRYGHJXB
		{
			[Cpp2IlInjected.Token(Token = "0x60002C6")]
			[Cpp2IlInjected.Address(RVA = "0xD00670", Offset = "0xCFF070", VA = "0x180D00670", Slot = "11")]
			get
			{
				return default(RbexInterpolationMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0xA01FF80", Offset = "0xA01E980", VA = "0x18A01FF80")]
		public LSONWYJENIF(LXUPYHZBZJT a, [In] RigidbodyExData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0xA01F970", Offset = "0xA01E370", VA = "0x18A01F970", Slot = "4")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0xA01FA40", Offset = "0xA01E440", VA = "0x18A01FA40")]
		private bool CACVDIXJQER()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0xA01FB60", Offset = "0xA01E560", VA = "0x18A01FB60", Slot = "5")]
		public void OUMBAYJWNTF(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0xA01FB90", Offset = "0xA01E590", VA = "0x18A01FB90", Slot = "6")]
		public void PSBAGEZXJXE(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0xA01FCD0", Offset = "0xA01E6D0", VA = "0x18A01FCD0", Slot = "9")]
		public void TVQONGPDDXA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0xA01FBC0", Offset = "0xA01E5C0", VA = "0x18A01FBC0")]
		private void TBHXRCHPIDT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0xA01FE00", Offset = "0xA01E800", VA = "0x18A01FE00")]
		private void ZDNKKORVCDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0xA01FAE0", Offset = "0xA01E4E0", VA = "0x18A01FAE0", Slot = "8")]
		public void HUICRUBRLUV(LXUPYHZBZJT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0xA01FB20", Offset = "0xA01E520", VA = "0x18A01FB20", Slot = "7")]
		public void MAVVSTNHKPI(LXUPYHZBZJT a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	internal sealed class TBTBRSKXOGG : ADFYPFYYJTJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private readonly PTYPBTHHGDG WGQNBVLMTNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private readonly SMMLEVHGFEC BMVWQNGPKZN;

		[Cpp2IlInjected.Token(Token = "0x170000AA")]
		public bool CBIJVKAZZYJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002D3")]
			[Cpp2IlInjected.Address(RVA = "0xA033F60", Offset = "0xA032960", VA = "0x18A033F60", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400002B")]
		public event RbexAction UEXVUWFUIRR
		{
			[Cpp2IlInjected.Token(Token = "0x60002D1")]
			[Cpp2IlInjected.Address(RVA = "0xA033CD0", Offset = "0xA0326D0", VA = "0x18A033CD0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60002D2")]
			[Cpp2IlInjected.Address(RVA = "0xA033E80", Offset = "0xA032880", VA = "0x18A033E80", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0xA0340E0", Offset = "0xA032AE0", VA = "0x18A0340E0")]
		public TBTBRSKXOGG(LXUPYHZBZJT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0xA0340D0", Offset = "0xA032AD0", VA = "0x18A0340D0", Slot = "7")]
		public void ZVQCSLWDZWM(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0xA034010", Offset = "0xA032A10", VA = "0x18A034010", Slot = "8")]
		public void OLXCXOCOVEZ(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0xA033D70", Offset = "0xA032770", VA = "0x18A033D70", Slot = "9")]
		public void DFZMGVMLCVL(object a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0xA033F20", Offset = "0xA032920", VA = "0x18A033F20", Slot = "12")]
		public void KVKQZFGQMKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0xA034050", Offset = "0xA032A50", VA = "0x18A034050", Slot = "10")]
		public void SMDWCQWJFSZ(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0xA034020", Offset = "0xA032A20", VA = "0x18A034020", Slot = "11")]
		public void SBBJNFQRYPU(Rigidbody a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	internal sealed class YSLEPNBYYVB : VTYXRYWUZAT, LLGCBUIDYLE, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private WeakReference<LXUPYHZBZJT> WKFXURVQXKW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private readonly PTYPBTHHGDG WGQNBVLMTNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private RRNetworkView LXBHNWSAMFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private bool FVQIONLRDWO;

		[Cpp2IlInjected.Token(Token = "0x170000AB")]
		public RRNetworkView ZRBHEYPJALJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002DD")]
			[Cpp2IlInjected.Address(RVA = "0xCF4350", Offset = "0xCF2D50", VA = "0x180CF4350", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AC")]
		public bool XKPOTKSKOSY
		{
			[Cpp2IlInjected.Token(Token = "0x60002DE")]
			[Cpp2IlInjected.Address(RVA = "0xA038D90", Offset = "0xA037790", VA = "0x18A038D90", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AD")]
		public bool RHREZJRVEHQ
		{
			[Cpp2IlInjected.Token(Token = "0x60002DF")]
			[Cpp2IlInjected.Address(RVA = "0xD4DD70", Offset = "0xD4C770", VA = "0x180D4DD70", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400002C")]
		public event RbexAction ITXXROJJITF
		{
			[Cpp2IlInjected.Token(Token = "0x60002DB")]
			[Cpp2IlInjected.Address(RVA = "0xA0393E0", Offset = "0xA037DE0", VA = "0x18A0393E0", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60002DC")]
			[Cpp2IlInjected.Address(RVA = "0xA039860", Offset = "0xA038260", VA = "0x18A039860", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0xA039900", Offset = "0xA038300", VA = "0x18A039900")]
		public YSLEPNBYYVB(LXUPYHZBZJT a, [In] RigidbodyExData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0xA038B10", Offset = "0xA037510", VA = "0x18A038B10", Slot = "9")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0xA038DA0", Offset = "0xA0377A0", VA = "0x18A038DA0", Slot = "12")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0xA0390D0", Offset = "0xA037AD0", VA = "0x18A0390D0", Slot = "10")]
		public void IPTSEZGPFEE(LXUPYHZBZJT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0xA039260", Offset = "0xA037C60", VA = "0x18A039260", Slot = "11")]
		public void KBQMFYLCBTS(LXUPYHZBZJT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0xA039480", Offset = "0xA037E80", VA = "0x18A039480")]
		private void PNJFPQMSQGI(RRNetworkView a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0xA038C40", Offset = "0xA037640", VA = "0x18A038C40")]
		private void BBNIMRMYCHK(OGYYXGOOHSH a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0xA0395F0", Offset = "0xA037FF0", VA = "0x18A0395F0")]
		private void SCHEYODJHQJ(RRNetworkView a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	internal static class ITUKOOIUHEB
	{
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0xA01EFB0", Offset = "0xA01D9B0", VA = "0x18A01EFB0")]
		public static VTYXRYWUZAT Lifecycle(this LXUPYHZBZJT impl)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	internal sealed class VOITZAYFQRR : IHWEUKEKZTG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private readonly PTYPBTHHGDG WGQNBVLMTNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private RigidbodyConstraints QOMPATWFYFC;

		[Cpp2IlInjected.Token(Token = "0x170000AE")]
		public bool NKNFNYBZXXV
		{
			[Cpp2IlInjected.Token(Token = "0x60002E9")]
			[Cpp2IlInjected.Address(RVA = "0xE97170", Offset = "0xE95B70", VA = "0x180E97170", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002EA")]
			[Cpp2IlInjected.Address(RVA = "0xEBB6F0", Offset = "0xEBA0F0", VA = "0x180EBB6F0", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AF")]
		public bool VILIHWWNEAO
		{
			[Cpp2IlInjected.Token(Token = "0x60002EB")]
			[Cpp2IlInjected.Address(RVA = "0xEBBD90", Offset = "0xEBA790", VA = "0x180EBBD90", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002EC")]
			[Cpp2IlInjected.Address(RVA = "0xEBBD10", Offset = "0xEBA710", VA = "0x180EBBD10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B0")]
		public RigidbodyConstraints BRFYXOLZCXW
		{
			[Cpp2IlInjected.Token(Token = "0x60002ED")]
			[Cpp2IlInjected.Address(RVA = "0xCF76D0", Offset = "0xCF60D0", VA = "0x180CF76D0", Slot = "7")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x60002EE")]
			[Cpp2IlInjected.Address(RVA = "0xA035860", Offset = "0xA034260", VA = "0x18A035860", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0xA0359F0", Offset = "0xA0343F0", VA = "0x18A0359F0")]
		public VOITZAYFQRR(LXUPYHZBZJT a, [In] RigidbodyExData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0xA0359C0", Offset = "0xA0343C0", VA = "0x18A0359C0", Slot = "9")]
		public void SMDWCQWJFSZ(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0xA035990", Offset = "0xA034390", VA = "0x18A035990", Slot = "10")]
		public void SBBJNFQRYPU(Rigidbody a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	internal sealed class VDKMEUOLXWU : XTQQSIWUNAD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private readonly LXUPYHZBZJT WGQNBVLMTNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private float KBZKPRCCATU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private float PVEDKCRRUNO;

		[Cpp2IlInjected.Token(Token = "0x170000B1")]
		public float TEAHUUGNNOK
		{
			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0xD47F00", Offset = "0xD46900", VA = "0x180D47F00", Slot = "4")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60002F4")]
			[Cpp2IlInjected.Address(RVA = "0xA035590", Offset = "0xA033F90", VA = "0x18A035590", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B2")]
		public float STVEYJONKSE
		{
			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0xD47E80", Offset = "0xD46880", VA = "0x180D47E80", Slot = "6")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60002F6")]
			[Cpp2IlInjected.Address(RVA = "0xA035700", Offset = "0xA034100", VA = "0x18A035700", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0xA035820", Offset = "0xA034220", VA = "0x18A035820")]
		public VDKMEUOLXWU(LXUPYHZBZJT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0xA0357D0", Offset = "0xA0341D0", VA = "0x18A0357D0", Slot = "8")]
		public void SMDWCQWJFSZ(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0xA035660", Offset = "0xA034060", VA = "0x18A035660", Slot = "9")]
		public void SBBJNFQRYPU(Rigidbody a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	internal sealed class OYKIZDJUYWQ : VAQXZSQRJSJ
	{
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private static readonly Log UGYCWXTIJBX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private readonly PTYPBTHHGDG WGQNBVLMTNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private bool XKKENTWTOTZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private bool XDIGIRETGWS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private int TTYTVXANQHM;

		[Cpp2IlInjected.Token(Token = "0x170000B3")]
		private Rigidbody EUMMWSSQGSM
		{
			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0xA0224D0", Offset = "0xA020ED0", VA = "0x18A0224D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B4")]
		private bool XGWXTLEZCYP
		{
			[Cpp2IlInjected.Token(Token = "0x60002FC")]
			[Cpp2IlInjected.Address(RVA = "0xA021FE0", Offset = "0xA0209E0", VA = "0x18A021FE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B5")]
		private LXUPYHZBZJT LXEGSVYJGSM
		{
			[Cpp2IlInjected.Token(Token = "0x60002FD")]
			[Cpp2IlInjected.Address(RVA = "0xA022470", Offset = "0xA020E70", VA = "0x18A022470")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B6")]
		private bool DOFZZALFMLC
		{
			[Cpp2IlInjected.Token(Token = "0x60002FE")]
			[Cpp2IlInjected.Address(RVA = "0xA0222C0", Offset = "0xA020CC0", VA = "0x18A0222C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400002D")]
		public event RbexAction IFPNYWKNMIB
		{
			[Cpp2IlInjected.Token(Token = "0x60002F9")]
			[Cpp2IlInjected.Address(RVA = "0xA022130", Offset = "0xA020B30", VA = "0x18A022130", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0xA0228C0", Offset = "0xA0212C0", VA = "0x18A0228C0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0xA022A00", Offset = "0xA021400", VA = "0x18A022A00")]
		public OYKIZDJUYWQ(LXUPYHZBZJT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0xA021DC0", Offset = "0xA0207C0", VA = "0x18A021DC0", Slot = "6")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0xA022960", Offset = "0xA021360", VA = "0x18A022960", Slot = "8")]
		public void VYEFYJZZCNR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0xA022320", Offset = "0xA020D20", VA = "0x18A022320", Slot = "7")]
		public bool JGCPBCSKBCV()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0xA0227F0", Offset = "0xA0211F0", VA = "0x18A0227F0", Slot = "9")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0xA022750", Offset = "0xA021150", VA = "0x18A022750", Slot = "13")]
		public void RKYXLQNOLOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0xA022000", Offset = "0xA020A00", VA = "0x18A022000", Slot = "12")]
		public void EBBJEEVITQI(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0xA022520", Offset = "0xA020F20", VA = "0x18A022520", Slot = "10")]
		public bool JTGXIODXUYL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0xA0221D0", Offset = "0xA020BD0", VA = "0x18A0221D0", Slot = "11")]
		public bool EZCSABKDGIO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0xA022590", Offset = "0xA020F90", VA = "0x18A022590")]
		private bool OADRYVKWYMM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0xA021E50", Offset = "0xA020850", VA = "0x18A021E50")]
		private void DEWDBVAFQZQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	internal sealed class KKEHUPUWHRX : AFCZAFOTJDY
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private readonly PTYPBTHHGDG WGQNBVLMTNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private readonly SMMLEVHGFEC WYGVAEWOAQZ;

		[Cpp2IlInjected.Token(Token = "0x170000B7")]
		public Rigidbody EUMMWSSQGSM
		{
			[Cpp2IlInjected.Token(Token = "0x600030B")]
			[Cpp2IlInjected.Address(RVA = "0xCF1D90", Offset = "0xCF0790", VA = "0x180CF1D90", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600030C")]
			[Cpp2IlInjected.Address(RVA = "0xCF1770", Offset = "0xCF0170", VA = "0x180CF1770")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B8")]
		private bool DOFZZALFMLC
		{
			[Cpp2IlInjected.Token(Token = "0x600030D")]
			[Cpp2IlInjected.Address(RVA = "0xA01F140", Offset = "0xA01DB40", VA = "0x18A01F140")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B9")]
		public bool HAYPWHZEPMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000310")]
			[Cpp2IlInjected.Address(RVA = "0x1B62FA0", Offset = "0x1B619A0", VA = "0x181B62FA0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0xA01F870", Offset = "0xA01E270", VA = "0x18A01F870")]
		public KKEHUPUWHRX(LXUPYHZBZJT a, [In] RigidbodyExData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0xA01F070", Offset = "0xA01DA70", VA = "0x18A01F070", Slot = "5")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0xA01F650", Offset = "0xA01E050", VA = "0x18A01F650", Slot = "7")]
		public void TFXFJGHHFHF(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0xA01F110", Offset = "0xA01DB10", VA = "0x18A01F110", Slot = "8")]
		public void DTJULSXSPPU(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0xA01F320", Offset = "0xA01DD20", VA = "0x18A01F320", Slot = "9")]
		public void REBXJJKYCZV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0xA01F680", Offset = "0xA01E080", VA = "0x18A01F680", Slot = "10")]
		public void WBCHPINQQGY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0xA01F1A0", Offset = "0xA01DBA0", VA = "0x18A01F1A0", Slot = "11")]
		public void JWLDTXTNMRB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	internal sealed class VPJLYCUOSPQ : FIDNUJTSXPT, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private readonly PTYPBTHHGDG WGQNBVLMTNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private readonly SMMLEVHGFEC EKQLOYAKLBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private float TMGDMPCATPV;

		[Cpp2IlInjected.Token(Token = "0x170000BA")]
		public DBBKETFETMV KOLYPESMRMG
		{
			[Cpp2IlInjected.Token(Token = "0x6000316")]
			[Cpp2IlInjected.Address(RVA = "0xCF4350", Offset = "0xCF2D50", VA = "0x180CF4350", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000317")]
			[Cpp2IlInjected.Address(RVA = "0xCF1780", Offset = "0xCF0180", VA = "0x180CF1780", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		public HAIRCSDLSLS HEFJROZQYWZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000318")]
			[Cpp2IlInjected.Address(RVA = "0xCF4C20", Offset = "0xCF3620", VA = "0x180CF4C20", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000319")]
			[Cpp2IlInjected.Address(RVA = "0xCF64C0", Offset = "0xCF4EC0", VA = "0x180CF64C0", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BC")]
		public Vector3 ICEPCSIMYGD
		{
			[Cpp2IlInjected.Token(Token = "0x600031A")]
			[Cpp2IlInjected.Address(RVA = "0xA036470", Offset = "0xA034E70", VA = "0x18A036470", Slot = "8")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600031B")]
			[Cpp2IlInjected.Address(RVA = "0xA035F30", Offset = "0xA034930", VA = "0x18A035F30", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BD")]
		public Vector3 MDEBPHEQMEU
		{
			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(RVA = "0xA036AC0", Offset = "0xA0354C0", VA = "0x18A036AC0", Slot = "10")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600031D")]
			[Cpp2IlInjected.Address(RVA = "0xA035BD0", Offset = "0xA0345D0", VA = "0x18A035BD0", Slot = "11")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BE")]
		public Vector3 LDDNNQAATIV
		{
			[Cpp2IlInjected.Token(Token = "0x600031E")]
			[Cpp2IlInjected.Address(RVA = "0xA036EA0", Offset = "0xA0358A0", VA = "0x18A036EA0", Slot = "12")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600031F")]
			[Cpp2IlInjected.Address(RVA = "0xA036870", Offset = "0xA035270", VA = "0x18A036870", Slot = "13")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BF")]
		public Vector3 TLYLWZDIHEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000320")]
			[Cpp2IlInjected.Address(RVA = "0xA036930", Offset = "0xA035330", VA = "0x18A036930", Slot = "14")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0xA035A90", Offset = "0xA034490", VA = "0x18A035A90", Slot = "15")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C0")]
		public float KJTVCDHLYHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000322")]
			[Cpp2IlInjected.Address(RVA = "0xD47F10", Offset = "0xD46910", VA = "0x180D47F10", Slot = "16")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000323")]
			[Cpp2IlInjected.Address(RVA = "0xA035C00", Offset = "0xA034600", VA = "0x18A035C00", Slot = "17")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C1")]
		public bool LIMCAIRXPKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000324")]
			[Cpp2IlInjected.Address(RVA = "0x25E49C0", Offset = "0x25E33C0", VA = "0x1825E49C0", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C2")]
		private CPTWJAIUUZT YQFDQFIJJDZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000339")]
			[Cpp2IlInjected.Address(RVA = "0x9559F30", Offset = "0x9558930", VA = "0x189559F30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C3")]
		private bool XGWXTLEZCYP
		{
			[Cpp2IlInjected.Token(Token = "0x600033A")]
			[Cpp2IlInjected.Address(RVA = "0xA035D10", Offset = "0xA034710", VA = "0x18A035D10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0xA038960", Offset = "0xA037360", VA = "0x18A038960")]
		public VPJLYCUOSPQ(LXUPYHZBZJT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0xA035AC0", Offset = "0xA0344C0", VA = "0x18A035AC0", Slot = "19")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0xA035D30", Offset = "0xA034730", VA = "0x18A035D30", Slot = "36")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0xA037F50", Offset = "0xA036950", VA = "0x18A037F50", Slot = "28")]
		public void SMDWCQWJFSZ(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x1908F00", Offset = "0x1907900", VA = "0x181908F00", Slot = "20")]
		public void HEJEBYMVYXB(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x1908EE0", Offset = "0x19078E0", VA = "0x181908EE0", Slot = "30")]
		public void QSNFCIRMICO(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0xA0385F0", Offset = "0xA036FF0", VA = "0x18A0385F0", Slot = "35")]
		public Vector3 YPKMPNFBOFR(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0xA037060", Offset = "0xA035A60", VA = "0x18A037060", Slot = "34")]
		public Vector3 QAIXHGLGTND(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0xA035AC0", Offset = "0xA0344C0", VA = "0x18A035AC0", Slot = "27")]
		public void ZDKPEVDVEEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0xA036C40", Offset = "0xA035640", VA = "0x18A036C40", Slot = "25")]
		public void LVVLWBMRZLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0xA036E40", Offset = "0xA035840", VA = "0x18A036E40", Slot = "24")]
		public void MCQBNWMCNZI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0xA036630", Offset = "0xA035030", VA = "0x18A036630", Slot = "33")]
		public void IHXJKMBIMTE(Vector3 a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0xA035B70", Offset = "0xA034570", VA = "0x18A035B70", Slot = "32")]
		public void BLHUQEBCBOP(Vector3 a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0xA036CA0", Offset = "0xA0356A0", VA = "0x18A036CA0", Slot = "31")]
		public void MANMXVCYIEK(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0xA037A00", Offset = "0xA036400", VA = "0x18A037A00", Slot = "22")]
		public void QZFKXASVYKM(RbexImpulseType a, Vector3 b, float c, float d = 8f, float e = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0xA0376A0", Offset = "0xA0360A0", VA = "0x18A0376A0", Slot = "21")]
		public void QKWMHBMXTOR(RbexRotationType a, Vector3 b, float c = 1f / 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0xA038200", Offset = "0xA036C00", VA = "0x18A038200", Slot = "23")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void YCGZAVPWGQO(RbexRotationType a, Vector3 b, float c = 7f, float d = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x1A4ED90", Offset = "0x1A4D790", VA = "0x181A4ED90")]
		private static void BUZGXAVFZVU(Vector3 a, Vector3 b, [Out] Vector3 c, [Out] Vector3 d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0xA037920", Offset = "0xA036320", VA = "0x18A037920", Slot = "29")]
		public Vector3 QSJCZUUDSVN(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0xA035FF0", Offset = "0xA0349F0", VA = "0x18A035FF0", Slot = "26")]
		public void GNUDOOUXQAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0xA035C00", Offset = "0xA034600", VA = "0x18A035C00")]
		private void DQHRVUGNXDF(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0xA035D90", Offset = "0xA034790", VA = "0x18A035D90")]
		private void EHCAVWHPZMH(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0xA038080", Offset = "0xA036A80", VA = "0x18A038080")]
		private Vector3 XKOKWNCTBVC()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0xA036180", Offset = "0xA034B80", VA = "0x18A036180")]
		private void GOBTBHJHOZS(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0xA0387D0", Offset = "0xA0371D0", VA = "0x18A0387D0")]
		private Vector3 YSJAWMVYBKU()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0xA037220", Offset = "0xA035C20", VA = "0x18A037220")]
		private void QJPGBJXYEZG(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEE930", VA = "0x180CEFF30")]
		private void UBRINKVMLHJ(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEE930", VA = "0x180CEFF30")]
		private void CCOXGBMIEPD()
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
