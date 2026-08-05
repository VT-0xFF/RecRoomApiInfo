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
		[Cpp2IlInjected.Address(RVA = "0xD34090", Offset = "0xD33090", VA = "0x180D34090")]
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
		[Cpp2IlInjected.Address(RVA = "0xD34AA0", Offset = "0xD33AA0", VA = "0x180D34AA0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA1C2DC0", Offset = "0xA1C1DC0", VA = "0x18A1C2DC0", Slot = "4")]
		public override void SIFQFAPRLAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xD34090", Offset = "0xD33090", VA = "0x180D34090")]
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
			[Cpp2IlInjected.Address(RVA = "0xD0F400", Offset = "0xD0E400", VA = "0x180D0F400", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9BB0060", Offset = "0x9BAF060", VA = "0x189BB0060", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xA1DC820", Offset = "0xA1DB820", VA = "0x18A1DC820")]
		private void GVEYSKBSPJB(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xA1DCB00", Offset = "0xA1DBB00", VA = "0x18A1DCB00", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xA1DCB60", Offset = "0xA1DBB60", VA = "0x18A1DCB60")]
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
			[Cpp2IlInjected.Address(RVA = "0xA1CF150", Offset = "0xA1CE150", VA = "0x18A1CF150")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private LXUPYHZBZJT MMYEVIXSMCA
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xD0F400", Offset = "0xD0E400", VA = "0x180D0F400", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int OVJQGIMCWJT
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0xA1D0E60", Offset = "0xA1CFE60", VA = "0x18A1D0E60")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RigidbodyEx TBPCBVCLMHU
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0xA1D11C0", Offset = "0xA1D01C0", VA = "0x18A1D11C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx OFIFJQDFJXG
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xA1D1100", Offset = "0xA1D0100", VA = "0x18A1D1100")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RigidbodyEx PMPLOCZDTJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0xA1D1DC0", Offset = "0xA1D0DC0", VA = "0x18A1D1DC0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xA1D32C0", Offset = "0xA1D22C0", VA = "0x18A1D32C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool DidStart
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x9557A70", Offset = "0x9556A70", VA = "0x189557A70", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x9557BC0", Offset = "0x9556BC0", VA = "0x189557BC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Transform VVUQJWBKDSM
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x2605680", Offset = "0x2604680", VA = "0x182605680", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Transform ZHNBUFTLOVF
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x2605680", Offset = "0x2604680", VA = "0x182605680", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Transform YHXCWGCLCPJ
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x2605680", Offset = "0x2604680", VA = "0x182605680", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public TransformTrackRate QAIPJDPLKNB
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0xA1D0EC0", Offset = "0xA1CFEC0", VA = "0x18A1D0EC0")]
			get
			{
				return default(TransformTrackRate);
			}
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0xA1D2A70", Offset = "0xA1D1A70", VA = "0x18A1D2A70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool XKPOTKSKOSY
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0xA1D14D0", Offset = "0xA1D04D0", VA = "0x18A1D14D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool RHREZJRVEHQ
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0xA1D0FE0", Offset = "0xA1CFFE0", VA = "0x18A1D0FE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public DBBKETFETMV KOLYPESMRMG
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0xA1D1410", Offset = "0xA1D0410", VA = "0x18A1D1410")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0xA1D2C30", Offset = "0xA1D1C30", VA = "0x18A1D2C30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public HAIRCSDLSLS HEFJROZQYWZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0xA1D13B0", Offset = "0xA1D03B0", VA = "0x18A1D13B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0xA1D2BC0", Offset = "0xA1D1BC0", VA = "0x18A1D2BC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool LIMCAIRXPKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xA1D1300", Offset = "0xA1D0300", VA = "0x18A1D1300")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Rigidbody EUMMWSSQGSM
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xA1D1360", Offset = "0xA1D0360", VA = "0x18A1D1360")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool NKNFNYBZXXV
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xA1D1040", Offset = "0xA1D0040", VA = "0x18A1D1040")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xA1D2AE0", Offset = "0xA1D1AE0", VA = "0x18A1D2AE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool KJMEBHGONHM
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x1A2A0C0", Offset = "0x1A290C0", VA = "0x181A2A0C0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float KYXHKEHMMKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xA1D1D60", Offset = "0xA1D0D60", VA = "0x18A1D1D60")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float RQQQKIUSRDJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xA1D1D00", Offset = "0xA1D0D00", VA = "0x18A1D1D00")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xA1D3250", Offset = "0xA1D2250", VA = "0x18A1D3250")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public float KBZKPRCCATU
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xA1D1730", Offset = "0xA1D0730", VA = "0x18A1D1730")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0xA1D2ED0", Offset = "0xA1D1ED0", VA = "0x18A1D2ED0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public float PVEDKCRRUNO
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0xA1D1530", Offset = "0xA1D0530", VA = "0x18A1D1530")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0xA1D2CA0", Offset = "0xA1D1CA0", VA = "0x18A1D2CA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public bool CXZSEVKSYPF
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0xA1D2310", Offset = "0xA1D1310", VA = "0x18A1D2310")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0xA1D3800", Offset = "0xA1D2800", VA = "0x18A1D3800")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Vector3 VACERFKWSBR
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xA1D1AE0", Offset = "0xA1D0AE0", VA = "0x18A1D1AE0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xA1D3020", Offset = "0xA1D2020", VA = "0x18A1D3020")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public Vector3 JZSHLHSYOJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xA1D2450", Offset = "0xA1D1450", VA = "0x18A1D2450")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public CollisionDetectionMode XRUMAACSRHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xA1D1670", Offset = "0xA1D0670", VA = "0x18A1D1670")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xA1D2DF0", Offset = "0xA1D1DF0", VA = "0x18A1D2DF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public float KJTVCDHLYHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0xA1D10A0", Offset = "0xA1D00A0", VA = "0x18A1D10A0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xA1D2B50", Offset = "0xA1D1B50", VA = "0x18A1D2B50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public RigidbodyConstraints QOMPATWFYFC
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xA1D16D0", Offset = "0xA1D06D0", VA = "0x18A1D16D0")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xA1D2E60", Offset = "0xA1D1E60", VA = "0x18A1D2E60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public Vector3 BCOIHCTFKTY
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0xA1D1E80", Offset = "0xA1D0E80", VA = "0x18A1D1E80")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public Vector3 MAFMUEZRMSC
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0xA1D1E80", Offset = "0xA1D0E80", VA = "0x18A1D1E80")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0xA1D35E0", Offset = "0xA1D25E0", VA = "0x18A1D35E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public float SLHVMPYUQLT
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0xA1D1BC0", Offset = "0xA1D0BC0", VA = "0x18A1D1BC0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xA1D3100", Offset = "0xA1D2100", VA = "0x18A1D3100")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public float HCWWTCSMPIO
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xA1D22B0", Offset = "0xA1D12B0", VA = "0x18A1D22B0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xA1D3790", Offset = "0xA1D2790", VA = "0x18A1D3790")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Quaternion FLHRDZLCFVN
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0xA1D1F60", Offset = "0xA1D0F60", VA = "0x18A1D1F60")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xA1D3360", Offset = "0xA1D2360", VA = "0x18A1D3360")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Quaternion DXSNNAYZOPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xA1D21E0", Offset = "0xA1D11E0", VA = "0x18A1D21E0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xA1D36C0", Offset = "0xA1D26C0", VA = "0x18A1D36C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector3 USXCENKOOFV
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xA1D2030", Offset = "0xA1D1030", VA = "0x18A1D2030")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xA1D3430", Offset = "0xA1D2430", VA = "0x18A1D3430")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Quaternion WAWDUFDYJBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xA1D2110", Offset = "0xA1D1110", VA = "0x18A1D2110")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xA1D3510", Offset = "0xA1D2510", VA = "0x18A1D3510")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 ZWUMVCGUCFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0xA1D2370", Offset = "0xA1D1370", VA = "0x18A1D2370")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xA1D3870", Offset = "0xA1D2870", VA = "0x18A1D3870")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 ZEQCBLOAWIE
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0xA1D1C20", Offset = "0xA1D0C20", VA = "0x18A1D1C20")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xA1D3170", Offset = "0xA1D2170", VA = "0x18A1D3170")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector3 UMQPUGFSLIB
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xA1D1590", Offset = "0xA1D0590", VA = "0x18A1D1590")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0xA1D2D10", Offset = "0xA1D1D10", VA = "0x18A1D2D10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector3 VOMRLMHXONO
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xA1D1A00", Offset = "0xA1D0A00", VA = "0x18A1D1A00")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xA1D2F40", Offset = "0xA1D1F40", VA = "0x18A1D2F40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector3 WUEPDLUALNZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xA1D18C0", Offset = "0xA1D08C0", VA = "0x18A1D18C0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Quaternion LFKDVZTTNPX
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xA1D17F0", Offset = "0xA1D07F0", VA = "0x18A1D17F0")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public Vector3 CFGFBHCDTTT
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0xA1D2610", Offset = "0xA1D1610", VA = "0x18A1D2610")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public Vector3 ZVOXGZNGRRV
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0xA1D2530", Offset = "0xA1D1530", VA = "0x18A1D2530")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool SCIBNISOLBP
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0xA1D19A0", Offset = "0xA1D09A0", VA = "0x18A1D19A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool MRCGPFUHMWC
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0xA1D1470", Offset = "0xA1D0470", VA = "0x18A1D1470")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool JCPEEYMQIDD
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0xA1D0F80", Offset = "0xA1CFF80", VA = "0x18A1D0F80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool KZCJJPMQQYY
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0xA1D0F20", Offset = "0xA1CFF20", VA = "0x18A1D0F20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool NJUAISBZIJH
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xA1D0E00", Offset = "0xA1CFE00", VA = "0x18A1D0E00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public bool BLDACPZSOQQ
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xA1D1790", Offset = "0xA1D0790", VA = "0x18A1D1790")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool PWWECYVUCJM
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xE220E0", Offset = "0xE210E0", VA = "0x180E220E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event RbexParentChangeAction TFJVCLCBELW
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xA1D0D20", Offset = "0xA1CFD20", VA = "0x18A1D0D20")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xA1D2990", Offset = "0xA1D1990", VA = "0x18A1D2990")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event RbexAction YLNBUCLIBKU
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xA1D0A90", Offset = "0xA1CFA90", VA = "0x18A1D0A90")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xA1D26F0", Offset = "0xA1D16F0", VA = "0x18A1D26F0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event RbexAction OUJVHEBRGPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xA1D0AF0", Offset = "0xA1CFAF0", VA = "0x18A1D0AF0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xA1D2760", Offset = "0xA1D1760", VA = "0x18A1D2760")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event RbexAction EHAGBLPBDNE
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xA1D0C40", Offset = "0xA1CFC40", VA = "0x18A1D0C40")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xA1D28B0", Offset = "0xA1D18B0", VA = "0x18A1D28B0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<UpdateLOD, UpdateLOD> CSGCRCJQBEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xA1D0BD0", Offset = "0xA1CFBD0", VA = "0x18A1D0BD0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0xA1D2840", Offset = "0xA1D1840", VA = "0x18A1D2840")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event RbexAction OCHERKAHZFL
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0xA1D0CB0", Offset = "0xA1CFCB0", VA = "0x18A1D0CB0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xA1D2920", Offset = "0xA1D1920", VA = "0x18A1D2920")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event RbexAction JJDVOCOFONR
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0xA1D0D90", Offset = "0xA1CFD90", VA = "0x18A1D0D90")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0xA1D2A00", Offset = "0xA1D1A00", VA = "0x18A1D2A00")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event RbexAction JKNPYNIICDY
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0xA1D0B60", Offset = "0xA1CFB60", VA = "0x18A1D0B60")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0xA1D27D0", Offset = "0xA1D17D0", VA = "0x18A1D27D0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xD0C800", Offset = "0xD0B800", VA = "0x180D0C800", Slot = "8")]
		private void ICZJAOGXUDW(LXUPYHZBZJT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xA1CF4B0", Offset = "0xA1CE4B0", VA = "0x18A1CF4B0", Slot = "9")]
		public RigidbodyExData GetData()
		{
			return default(RigidbodyExData);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA1CF7A0", Offset = "0xA1CE7A0", VA = "0x18A1CF7A0")]
		internal void JYDCHMBEHBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA1D0630", Offset = "0xA1CF630", VA = "0x18A1D0630")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public void TestOverrideUnityRigidbody(Rigidbody rb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xA1CF200", Offset = "0xA1CE200", VA = "0x18A1CF200")]
		public OGYYXGOOHSH GetChild(int index)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xA1D0290", Offset = "0xA1CF290", VA = "0x18A1D0290")]
		public void SetInertiaTensor((Quaternion rot, Vector3 moments) tensor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xA1CEDA0", Offset = "0xA1CDDA0", VA = "0x18A1CEDA0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA1D0520", Offset = "0xA1CF520", VA = "0x18A1D0520")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xA1CF150", Offset = "0xA1CE150", VA = "0x18A1CF150")]
		private LXUPYHZBZJT FUCFVTCCCEO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xA1D06A0", Offset = "0xA1CF6A0", VA = "0x18A1D06A0")]
		private void WNCQWZWPKZY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xA1CFA60", Offset = "0xA1CEA60", VA = "0x18A1CFA60")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xA1CF9A0", Offset = "0xA1CE9A0", VA = "0x18A1CF9A0")]
		public void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0xA1CF7A0", Offset = "0xA1CE7A0", VA = "0x18A1CF7A0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xA1CFA00", Offset = "0xA1CEA00", VA = "0x18A1CFA00")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xA1CFAC0", Offset = "0xA1CEAC0", VA = "0x18A1CFAC0")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xA1CE390", Offset = "0xA1CD390", VA = "0x18A1CE390")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xA1CFB20", Offset = "0xA1CEB20", VA = "0x18A1CFB20")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xA1CF0F0", Offset = "0xA1CE0F0", VA = "0x18A1CF0F0")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xA1CF940", Offset = "0xA1CE940", VA = "0x18A1CF940")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xA1D03F0", Offset = "0xA1CF3F0", VA = "0x18A1D03F0")]
		public void SetParent(RigidbodyEx value, bool isPhysicallyDetachedOnly = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0xA1CFE30", Offset = "0xA1CEE30", VA = "0x18A1CFE30")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xA1CF540", Offset = "0xA1CE540", VA = "0x18A1CF540")]
		public bool IsRigidbodyAncestor(RigidbodyEx possibleAncestor)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xA1CF640", Offset = "0xA1CE640", VA = "0x18A1CF640")]
		public bool IsRigidbodyDescendant(RigidbodyEx possibleDescendant)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xA1CE600", Offset = "0xA1CD600", VA = "0x18A1CE600")]
		public void AddInterpolationRestriction(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0xA1CFB90", Offset = "0xA1CEB90", VA = "0x18A1CFB90")]
		public void RemoveInterpolationRestriction(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0xA1CE670", Offset = "0xA1CD670", VA = "0x18A1CE670")]
		public void AddKinematic(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0xA1CFC00", Offset = "0xA1CEC00", VA = "0x18A1CFC00")]
		public void RemoveKinematic(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0xA1D0370", Offset = "0xA1CF370", VA = "0x18A1D0370")]
		public void SetKinematic(object token, bool setKinematic)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0xA1D0190", Offset = "0xA1CF190", VA = "0x18A1D0190")]
		public void SetDiscontinuousPositionAndRotation(Vector3 newPosition, Quaternion newRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0xA1D0090", Offset = "0xA1CF090", VA = "0x18A1D0090")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 newLocalPosition, Quaternion newLocalRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0xA1CF3A0", Offset = "0xA1CE3A0", VA = "0x18A1CF3A0")]
		public Vector3 GetConstrainedVelocity(Vector3 velocity)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0xA1CF290", Offset = "0xA1CE290", VA = "0x18A1CF290")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 angularVelocity)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0xA1CE510", Offset = "0xA1CD510", VA = "0x18A1CE510")]
		public void AddForce(Vector3 force, ForceMode forceMode = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xA1CE400", Offset = "0xA1CD400", VA = "0x18A1CE400")]
		public void AddForceAtPosition(Vector3 force, Vector3 position, ForceMode forceMode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0xA1CE840", Offset = "0xA1CD840", VA = "0x18A1CE840")]
		public void AddTorque(Vector3 torque, ForceMode forceMode = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xA1CE6E0", Offset = "0xA1CD6E0", VA = "0x18A1CE6E0")]
		public void AddRelativeTorque(Vector3 torque, ForceMode forceMode = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0xA1D0880", Offset = "0xA1CF880", VA = "0x18A1D0880")]
		public Vector3 WorldToLocalVelocity(Vector3 worldVelocity)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xA1CF830", Offset = "0xA1CE830", VA = "0x18A1CF830")]
		public Vector3 LocalToWorldVelocity(Vector3 localVelocity)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xA1CF090", Offset = "0xA1CE090", VA = "0x18A1CF090")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xA1CF030", Offset = "0xA1CE030", VA = "0x18A1CF030")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0xA1CEFD0", Offset = "0xA1CDFD0", VA = "0x18A1CEFD0")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xA1CEF70", Offset = "0xA1CDF70", VA = "0x18A1CEF70")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xA1CFF90", Offset = "0xA1CEF90", VA = "0x18A1CFF90")]
		public void ResetVelocityWorldSpace(Vector3 worldLinearVelocity, Vector3 worldAngularVelocity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xA1CFE90", Offset = "0xA1CEE90", VA = "0x18A1CFE90")]
		public void ResetVelocityLocalSpace(Vector3 localLinearVelocity, Vector3 localAngularVelocity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0xA1CFD50", Offset = "0xA1CED50", VA = "0x18A1CFD50")]
		public void ResetLinearVelocityLocalSpace(Vector3 localLinearVelocity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xA1D0530", Offset = "0xA1CF530", VA = "0x18A1D0530")]
		public bool SweepTest(Vector3 direction, [Out] RaycastHit hitInfo, float maxDistance)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xA1CF740", Offset = "0xA1CE740", VA = "0x18A1CF740")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xA1D04C0", Offset = "0xA1CF4C0", VA = "0x18A1D04C0")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xA1D0820", Offset = "0xA1CF820", VA = "0x18A1D0820")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0xA1CE7D0", Offset = "0xA1CD7D0", VA = "0x18A1CE7D0")]
		public void AddShouldHaveUnityRigidbodyToken(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xA1CFC70", Offset = "0xA1CEC70", VA = "0x18A1CFC70")]
		public void RemoveShouldHaveUnityRigidbodyToken(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0xA1CEBD0", Offset = "0xA1CDBD0", VA = "0x18A1CEBD0")]
		public void ApplyForceVelocityChange(RbexImpulseType impulseType, Vector3 impulseDirection, float impulseSpeed, float impulseDirectionMaxSpeed = 8f, float impulseReflectiveRestitution = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0xA1CEAD0", Offset = "0xA1CDAD0", VA = "0x18A1CEAD0")]
		public void ApplyAngularVelocityChange(RbexRotationType rotationType, Vector3 newAngularVelocity, float maxAngularSpeed = 1f / 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0xA1CEC90", Offset = "0xA1CDC90", VA = "0x18A1CEC90")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void ApplyTorqueAngularVelocityChangeDeprecated(RbexRotationType rotationType, Vector3 rotation, float maxSpeed = 7f, float multiplyingFactor = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xA1CEA00", Offset = "0xA1CDA00", VA = "0x18A1CEA00")]
		public bool AllowedScaleChange(float scaleFactor)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xA1CE930", Offset = "0xA1CD930", VA = "0x18A1CE930")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx parentOverride, object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xA1CFCE0", Offset = "0xA1CECE0", VA = "0x18A1CFCE0")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x8DE58F0", Offset = "0x8DE48F0", VA = "0x188DE58F0", Slot = "13")]
		private void SEQRWQSPUKP(NSNTXJAOJGZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xA1D0A20", Offset = "0xA1CFA20", VA = "0x18A1D0A20")]
		public RigidbodyEx()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x15229C0", Offset = "0x15219C0", VA = "0x1815229C0", Slot = "4")]
		private GameObject LBTUSBOAYUC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0xD36320", Offset = "0xD35320", VA = "0x180D36320", Slot = "10")]
		private bool FSAWUCEYRAZ()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	internal static class BWRWKAVTNYY
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0xA1C0910", Offset = "0xA1BF910", VA = "0x18A1C0910")]
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
			[Cpp2IlInjected.Address(RVA = "0xD0F3C0", Offset = "0xD0E3C0", VA = "0x180D0F3C0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public WTDUGPZWXSI BWDHSISXXES
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0xA1CE0C0", Offset = "0xA1CD0C0", VA = "0x18A1CE0C0", Slot = "7")]
		public void InitReferences(PPCVAYWFABF services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0xA1CE130", Offset = "0xA1CD130", VA = "0x18A1CE130", Slot = "6")]
		public LXUPYHZBZJT RTYDXWLWRNM(RigidbodyEx a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
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
		[Cpp2IlInjected.Address(RVA = "0xA1CBFB0", Offset = "0xA1CAFB0", VA = "0x18A1CBFB0")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0xA1CC030", Offset = "0xA1CB030", VA = "0x18A1CC030")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0xA1CBFD0", Offset = "0xA1CAFD0", VA = "0x18A1CBFD0")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string message, [Optional] UnityEngine.Object context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string message, [Optional] UnityEngine.Object context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0xA1CC130", Offset = "0xA1CB130", VA = "0x18A1CC130")]
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
			[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "7")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0xD1A610", Offset = "0xD19610", VA = "0x180D1A610", Slot = "4")]
			public Vector3 CXYMNJQTGHL()
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0xD1A610", Offset = "0xD19610", VA = "0x180D1A610", Slot = "5")]
			public Vector3 YSJAWMVYBKU()
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0xD24DB0", Offset = "0xD23DB0", VA = "0x180D24DB0", Slot = "6")]
			public bool ZEEGGALKPBN(float a, float b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public UXFPXUSRCCM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public static DBBKETFETMV ETGGWVSGWPP
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0xA1DB7C0", Offset = "0xA1DA7C0", VA = "0x18A1DB7C0")]
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
			[Cpp2IlInjected.Address(RVA = "0xD0AFA0", Offset = "0xD09FA0", VA = "0x180D0AFA0", Slot = "22")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public OGYYXGOOHSH PCQWDGQGDIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0xDEFAF0", Offset = "0xDEEAF0", VA = "0x180DEFAF0", Slot = "24")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0xEA7E00", Offset = "0xEA6E00", VA = "0x180EA7E00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public GameObject DCEMLZFKLGR
		{
			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0xD0DC20", Offset = "0xD0CC20", VA = "0x180D0DC20", Slot = "25")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0xD0DB90", Offset = "0xD0CB90", VA = "0x180D0DB90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public Transform IBGMOBEIUDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0xEC7670", Offset = "0xEC6670", VA = "0x180EC7670", Slot = "26")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x1015330", Offset = "0x1014330", VA = "0x181015330")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public Rigidbody EUMMWSSQGSM
		{
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0xA1C85E0", Offset = "0xA1C75E0", VA = "0x18A1C85E0", Slot = "23")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public LXUPYHZBZJT LXEGSVYJGSM
		{
			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0xA1C8590", Offset = "0xA1C7590", VA = "0x18A1C8590", Slot = "27")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0xA1CAC90", Offset = "0xA1C9C90", VA = "0x18A1CAC90", Slot = "28")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public int OVJQGIMCWJT
		{
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0xA1C8B90", Offset = "0xA1C7B90", VA = "0x18A1C8B90", Slot = "31")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public LXUPYHZBZJT OFIFJQDFJXG
		{
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0xA1C6A70", Offset = "0xA1C5A70", VA = "0x18A1C6A70", Slot = "29")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public bool DOFZZALFMLC
		{
			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0xA1C7600", Offset = "0xA1C6600", VA = "0x18A1C7600", Slot = "32")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public bool XKPOTKSKOSY
		{
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0xA1C6680", Offset = "0xA1C5680", VA = "0x18A1C6680", Slot = "33")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public bool RHREZJRVEHQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0xA1C8E70", Offset = "0xA1C7E70", VA = "0x18A1C8E70", Slot = "34")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public DBBKETFETMV KOLYPESMRMG
		{
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0xA1CB2A0", Offset = "0xA1CA2A0", VA = "0x18A1CB2A0", Slot = "35")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0xA1C9FF0", Offset = "0xA1C8FF0", VA = "0x18A1C9FF0", Slot = "36")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public HAIRCSDLSLS HEFJROZQYWZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0xA1C9AA0", Offset = "0xA1C8AA0", VA = "0x18A1C9AA0", Slot = "37")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0xA1CA590", Offset = "0xA1C9590", VA = "0x18A1CA590", Slot = "38")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public float KJTVCDHLYHJ
		{
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0xA1CB350", Offset = "0xA1CA350", VA = "0x18A1CB350", Slot = "39")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0xA1C97E0", Offset = "0xA1C87E0", VA = "0x18A1C97E0", Slot = "40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public Vector3 MDEBPHEQMEU
		{
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0xA1C8AB0", Offset = "0xA1C7AB0", VA = "0x18A1C8AB0", Slot = "41")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0xA1C5FE0", Offset = "0xA1C4FE0", VA = "0x18A1C5FE0", Slot = "42")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public Vector3 TLYLWZDIHEM
		{
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0xA1C87C0", Offset = "0xA1C77C0", VA = "0x18A1C87C0", Slot = "43")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0xA1C58E0", Offset = "0xA1C48E0", VA = "0x18A1C58E0", Slot = "44")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public Vector3 ICEPCSIMYGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0xA1C7990", Offset = "0xA1C6990", VA = "0x18A1C7990", Slot = "45")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0xA1C6EF0", Offset = "0xA1C5EF0", VA = "0x18A1C6EF0", Slot = "46")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public Vector3 LDDNNQAATIV
		{
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0xA1C9090", Offset = "0xA1C8090", VA = "0x18A1C9090", Slot = "47")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0xA1C8190", Offset = "0xA1C7190", VA = "0x18A1C8190", Slot = "48")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public bool JCPEEYMQIDD
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0xA1CB100", Offset = "0xA1CA100", VA = "0x18A1CB100", Slot = "49")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public bool KZCJJPMQQYY
		{
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0xA1CABF0", Offset = "0xA1C9BF0", VA = "0x18A1CABF0", Slot = "50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public bool NJUAISBZIJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0xA1C7B50", Offset = "0xA1C6B50", VA = "0x18A1C7B50", Slot = "51")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public bool LIMCAIRXPKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0xA1C5C00", Offset = "0xA1C4C00", VA = "0x18A1C5C00", Slot = "52")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public Vector3 XKMDQDDFWQV
		{
			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0xA1C7C30", Offset = "0xA1C6C30", VA = "0x18A1C7C30", Slot = "53")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public Vector3 SZXZTHRYZSL
		{
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0xA1C9320", Offset = "0xA1C8320", VA = "0x18A1C9320", Slot = "54")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public Vector3 IZFYQQIUYRJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0xA1C6B20", Offset = "0xA1C5B20", VA = "0x18A1C6B20", Slot = "55")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0xA1C7A70", Offset = "0xA1C6A70", VA = "0x18A1C7A70", Slot = "56")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public Vector3 JROGDJXDQKE
		{
			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0xA1C8460", Offset = "0xA1C7460", VA = "0x18A1C8460", Slot = "57")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public float WRDRETNSTCQ
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0xA1C8FE0", Offset = "0xA1C7FE0", VA = "0x18A1C8FE0", Slot = "58")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public float WURUEBFLLOL
		{
			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0xA1C78F0", Offset = "0xA1C68F0", VA = "0x18A1C78F0", Slot = "59")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0xA1CA790", Offset = "0xA1C9790", VA = "0x18A1CA790", Slot = "60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public Vector3 LSZXGKRJVRR
		{
			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0xA1CBB60", Offset = "0xA1CAB60", VA = "0x18A1CBB60", Slot = "61")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public Quaternion GOCCYCVSGLD
		{
			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0xA1C8EC0", Offset = "0xA1C7EC0", VA = "0x18A1C8EC0", Slot = "62")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public float TEAHUUGNNOK
		{
			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0xA1C9FA0", Offset = "0xA1C8FA0", VA = "0x18A1C9FA0", Slot = "64")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0xA1C9780", Offset = "0xA1C8780", VA = "0x18A1C9780", Slot = "65")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public float STVEYJONKSE
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0xA1C7940", Offset = "0xA1C6940", VA = "0x18A1C7940", Slot = "66")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0xA1CA530", Offset = "0xA1C9530", VA = "0x18A1CA530", Slot = "67")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public bool OSWXTAUUJQX
		{
			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0xA1C6300", Offset = "0xA1C5300", VA = "0x18A1C6300", Slot = "68")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0xA1C8630", Offset = "0xA1C7630", VA = "0x18A1C8630", Slot = "69")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public TransformTrackRate QAIPJDPLKNB
		{
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0xA1C61E0", Offset = "0xA1C51E0", VA = "0x18A1C61E0", Slot = "70")]
			get
			{
				return default(TransformTrackRate);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0xA1C6230", Offset = "0xA1C5230", VA = "0x18A1C6230", Slot = "71")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public bool CBIJVKAZZYJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0xA1C9590", Offset = "0xA1C8590", VA = "0x18A1C9590", Slot = "72")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public Transform YHXCWGCLCPJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0xEC7670", Offset = "0xEC6670", VA = "0x180EC7670", Slot = "73")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public Vector3 CUJKMYEUBZJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0xA1C7660", Offset = "0xA1C6660", VA = "0x18A1C7660", Slot = "74")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0xA1CBD00", Offset = "0xA1CAD00", VA = "0x18A1CBD00", Slot = "75")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public float EFHRNQBDZAF
		{
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0xA1C67D0", Offset = "0xA1C57D0", VA = "0x18A1C67D0", Slot = "76")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0xA1C8D80", Offset = "0xA1C7D80", VA = "0x18A1C8D80", Slot = "77")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public float TLPBRAXDDKO
		{
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0xA1CBC90", Offset = "0xA1CAC90", VA = "0x18A1CBC90", Slot = "78")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0xA1C5C50", Offset = "0xA1C4C50", VA = "0x18A1C5C50", Slot = "79")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public Quaternion MNNDKHLHEHU
		{
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0xA1C9D00", Offset = "0xA1C8D00", VA = "0x18A1C9D00", Slot = "80")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0xA1C5A20", Offset = "0xA1C4A20", VA = "0x18A1C5A20", Slot = "81")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public Vector3 JOGSRQJMWZG
		{
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0xA1C8060", Offset = "0xA1C7060", VA = "0x18A1C8060", Slot = "82")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0xA1CB010", Offset = "0xA1CA010", VA = "0x18A1CB010", Slot = "83")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public Quaternion LFODOXUWQHP
		{
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0xA1CABB0", Offset = "0xA1C9BB0", VA = "0x18A1CABB0", Slot = "84")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0xA1CB150", Offset = "0xA1CA150", VA = "0x18A1CB150", Slot = "85")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public RigidbodyConstraints BRFYXOLZCXW
		{
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0xA1C8A60", Offset = "0xA1C7A60", VA = "0x18A1C8A60", Slot = "86")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0xA1C9A40", Offset = "0xA1C8A40", VA = "0x18A1C9A40", Slot = "87")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public bool NKNFNYBZXXV
		{
			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0xA1C8F90", Offset = "0xA1C7F90", VA = "0x18A1C8F90", Slot = "88")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0xA1CBE60", Offset = "0xA1CAE60", VA = "0x18A1CBE60", Slot = "89")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public CollisionDetectionMode NZWQSZICZJO
		{
			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0xA1C91F0", Offset = "0xA1C81F0", VA = "0x18A1C91F0", Slot = "90")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0xA1C95E0", Offset = "0xA1C85E0", VA = "0x18A1C95E0", Slot = "91")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public bool XGWXTLEZCYP
		{
			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0xA1C6480", Offset = "0xA1C5480", VA = "0x18A1C6480", Slot = "141")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public bool MRCGPFUHMWC
		{
			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0xA1C7770", Offset = "0xA1C6770", VA = "0x18A1C7770", Slot = "92")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000017")]
		public event RbexAction YLNBUCLIBKU
		{
			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0xA1C60C0", Offset = "0xA1C50C0", VA = "0x18A1C60C0", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0xA1C7710", Offset = "0xA1C6710", VA = "0x18A1C7710", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000018")]
		public event RbexAction OUJVHEBRGPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0xA1C8E10", Offset = "0xA1C7E10", VA = "0x18A1C8E10", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0xA1C9030", Offset = "0xA1C8030", VA = "0x18A1C9030", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000019")]
		public event RbexParentChangeAction KPKZLGALJHC
		{
			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0xA1C6620", Offset = "0xA1C5620", VA = "0x18A1C6620", Slot = "18")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0xA1CB2F0", Offset = "0xA1CA2F0", VA = "0x18A1CB2F0", Slot = "19")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001A")]
		public event RbexAction ITXXROJJITF
		{
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0xA1C9400", Offset = "0xA1C8400", VA = "0x18A1C9400", Slot = "8")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0xA1CB240", Offset = "0xA1CA240", VA = "0x18A1CB240", Slot = "9")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001B")]
		public event RbexAction EHAGBLPBDNE
		{
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0xA1C7410", Offset = "0xA1C6410", VA = "0x18A1C7410", Slot = "14")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0xA1C8690", Offset = "0xA1C7690", VA = "0x18A1C8690", Slot = "15")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001C")]
		public event RbexAction IFPNYWKNMIB
		{
			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0xA1C6E30", Offset = "0xA1C5E30", VA = "0x18A1C6E30", Slot = "16")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0xA1CACF0", Offset = "0xA1C9CF0", VA = "0x18A1CACF0", Slot = "17")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001D")]
		public event Action<UpdateLOD, UpdateLOD> CSGCRCJQBEM
		{
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0xA1C6AC0", Offset = "0xA1C5AC0", VA = "0x18A1C6AC0", Slot = "20")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0xA1CB180", Offset = "0xA1CA180", VA = "0x18A1CB180", Slot = "21")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001E")]
		public event RbexAction UEXVUWFUIRR
		{
			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0xA1C6120", Offset = "0xA1C5120", VA = "0x18A1C6120", Slot = "12")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0xA1C7550", Offset = "0xA1C6550", VA = "0x18A1C7550", Slot = "13")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001F")]
		public event RbexAction JKNPYNIICDY
		{
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0xA1CBDB0", Offset = "0xA1CADB0", VA = "0x18A1CBDB0", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0xA1CB050", Offset = "0xA1CA050", VA = "0x18A1CB050", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0xA1CBEC0", Offset = "0xA1CAEC0", VA = "0x18A1CBEC0")]
		public PTYPBTHHGDG(GameObject a, RigidbodyEx b, TXSHHVHGWNE c, [In] RigidbodyExData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0xA1CA860", Offset = "0xA1C9860", VA = "0x18A1CA860", Slot = "139")]
		protected virtual void TCUGAKWEKPC(TXSHHVHGWNE a, RigidbodyExData b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0xA1C66D0", Offset = "0xA1C56D0", VA = "0x18A1C66D0", Slot = "140")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0xA1C5D50", Offset = "0xA1C4D50", VA = "0x18A1C5D50", Slot = "93")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0xA1C99B0", Offset = "0xA1C89B0", VA = "0x18A1C99B0", Slot = "94")]
		public void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0xA1C9900", Offset = "0xA1C8900", VA = "0x18A1C9900", Slot = "95")]
		public void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0xA1C98E0", Offset = "0xA1C88E0", VA = "0x18A1C98E0", Slot = "96")]
		public void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0xA1C67E0", Offset = "0xA1C57E0", VA = "0x18A1C67E0")]
		private void EBBJEEVITQI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0xA1C6DB0", Offset = "0xA1C5DB0", VA = "0x18A1C6DB0")]
		private void EWBZXFQTRVT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0xA1C6E90", Offset = "0xA1C5E90", VA = "0x18A1C6E90")]
		private void EZCSABKDGIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0xA1C9170", Offset = "0xA1C8170", VA = "0x18A1C9170", Slot = "30")]
		public LXUPYHZBZJT NJFBOEXBSEC(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0xA1CA6D0", Offset = "0xA1C96D0", VA = "0x18A1CA6D0", Slot = "98")]
		public void SetParent(LXUPYHZBZJT value, bool isPhysicallyDetachedOnly = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0xA1CB1E0", Offset = "0xA1CA1E0", VA = "0x18A1CB1E0", Slot = "99")]
		public void WRQDVZSAQUJ(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0xA1C59C0", Offset = "0xA1C49C0", VA = "0x18A1C59C0", Slot = "100")]
		public void ALHGLJSLWJW(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0xA1CBA60", Offset = "0xA1CAA60", VA = "0x18A1CBA60", Slot = "101")]
		public Vector3 YPKMPNFBOFR(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0xA1C9AF0", Offset = "0xA1C8AF0", VA = "0x18A1C9AF0", Slot = "102")]
		public Vector3 QAIXHGLGTND(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0xA1CBC40", Offset = "0xA1CAC40", VA = "0x18A1CBC40", Slot = "103")]
		public void ZDKPEVDVEEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0xA1C8C00", Offset = "0xA1C7C00", VA = "0x18A1C8C00", Slot = "104")]
		public void LVVLWBMRZLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0xA1C8D30", Offset = "0xA1C7D30", VA = "0x18A1C8D30", Slot = "105")]
		public void MCQBNWMCNZI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0xA1C80A0", Offset = "0xA1C70A0", VA = "0x18A1C80A0", Slot = "106")]
		public void IHXJKMBIMTE(Vector3 a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0xA1C5EF0", Offset = "0xA1C4EF0", VA = "0x18A1C5EF0", Slot = "107")]
		public void BLHUQEBCBOP(Vector3 a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0xA1C8C50", Offset = "0xA1C7C50", VA = "0x18A1C8C50", Slot = "108")]
		public void MANMXVCYIEK(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0xA1CA0E0", Offset = "0xA1C90E0", VA = "0x18A1CA0E0", Slot = "109")]
		public void QZFKXASVYKM(RbexImpulseType a, Vector3 b, float c, float d = 8f, float e = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0xA1C9DA0", Offset = "0xA1C8DA0", VA = "0x18A1C9DA0", Slot = "110")]
		public void QKWMHBMXTOR(RbexRotationType a, Vector3 b, float c = 1f / 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0xA1CB600", Offset = "0xA1CA600", VA = "0x18A1CB600", Slot = "111")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void YCGZAVPWGQO(RbexRotationType a, Vector3 b, float c = 7f, float d = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0xA1C9EA0", Offset = "0xA1C8EA0", VA = "0x18A1C9EA0", Slot = "112")]
		public Vector3 QSJCZUUDSVN(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0xA1C5B00", Offset = "0xA1C4B00", VA = "0x18A1C5B00", Slot = "113")]
		public Vector3 AOXLURTOEVP(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0xA1C75B0", Offset = "0xA1C65B0", VA = "0x18A1C75B0", Slot = "114")]
		public void GNUDOOUXQAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0xA1CA7F0", Offset = "0xA1C97F0", VA = "0x18A1CA7F0", Slot = "115")]
		public void TAWPVMUYQXO(LXUPYHZBZJT a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0xA1C8000", Offset = "0xA1C7000", VA = "0x18A1C8000", Slot = "116")]
		public void IDTUFHGJOZT(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0xA1C9240", Offset = "0xA1C8240", VA = "0x18A1C9240", Slot = "63")]
		public void NPMABWUKGBF((Quaternion rot, Vector3 moments) tensor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0xA1C9890", Offset = "0xA1C8890", VA = "0x18A1C9890", Slot = "117")]
		public void OYEMNLQPEHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0xA1C8A10", Offset = "0xA1C7A10", VA = "0x18A1C8A10", Slot = "118")]
		public void LAPJFJGAHUC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0xA1C9840", Offset = "0xA1C8840", VA = "0x18A1C9840", Slot = "119")]
		public void OXLQGXAIGFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0xA1C8540", Offset = "0xA1C7540", VA = "0x18A1C8540", Slot = "120")]
		public bool JGCPBCSKBCV()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0xA1CA740", Offset = "0xA1C9740", VA = "0x18A1CA740", Slot = "97")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0xA1CA4C0", Offset = "0xA1C94C0", VA = "0x18A1CA4C0", Slot = "121")]
		public void RKYXLQNOLOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0xA1CBCA0", Offset = "0xA1CACA0", VA = "0x18A1CBCA0", Slot = "122")]
		public void ZVQCSLWDZWM(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0xA1C9720", Offset = "0xA1C8720", VA = "0x18A1C9720", Slot = "123")]
		public void OLXCXOCOVEZ(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0xA1C6290", Offset = "0xA1C5290", VA = "0x18A1C6290", Slot = "124")]
		public void DFZMGVMLCVL(object a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0xA1C7E00", Offset = "0xA1C6E00", VA = "0x18A1C7E00", Slot = "125")]
		public void IANYDHQMCBV(Vector3 a, Quaternion b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0xA1C6350", Offset = "0xA1C5350", VA = "0x18A1C6350", Slot = "126")]
		public void DNWLVXMFKVJ(Vector3 a, Quaternion b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0xA1C57E0", Offset = "0xA1C47E0", VA = "0x18A1C57E0", Slot = "127")]
		public bool AETYWSNIILY(float a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0xA1C5E90", Offset = "0xA1C4E90", VA = "0x18A1C5E90", Slot = "128")]
		public void BGYCNWQZPOH(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0xA1C6180", Offset = "0xA1C5180", VA = "0x18A1C6180", Slot = "129")]
		public void CUDKGZWQNNK(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0xA1CAB50", Offset = "0xA1C9B50", VA = "0x18A1CAB50", Slot = "130")]
		public void TFXFJGHHFHF(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0xA1C65C0", Offset = "0xA1C55C0", VA = "0x18A1C65C0", Slot = "131")]
		public void DTJULSXSPPU(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0xA1CAD50", Offset = "0xA1C9D50", VA = "0x18A1CAD50", Slot = "132")]
		public void USYWIONWZMS(Vector3 a, ForceMode b = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0xA1CB4F0", Offset = "0xA1CA4F0", VA = "0x18A1CB4F0", Slot = "133")]
		public void YAPLWXIDAZG(Vector3 a, Vector3 b, ForceMode c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0xA1CA5F0", Offset = "0xA1C95F0", VA = "0x18A1CA5F0", Slot = "134")]
		public void SZAHRAMMZXH(Vector3 a, ForceMode b = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0xA1C7470", Offset = "0xA1C6470", VA = "0x18A1C7470", Slot = "135")]
		public void GHUSPGJLABX(Vector3 a, ForceMode b = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0xA1C7D00", Offset = "0xA1C6D00", VA = "0x18A1C7D00", Slot = "136")]
		public bool HXXFZGWJNGE(Vector3 a, [Out] RaycastHit b, float c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0xA1C9960", Offset = "0xA1C8960", VA = "0x18A1C9960", Slot = "137")]
		public void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0xA1CAC50", Offset = "0xA1C9C50", VA = "0x18A1CAC50", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0xA1C9640", Offset = "0xA1C8640", VA = "0x18A1C9640")]
		private void OIDXDREMSHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0xA1C9BF0", Offset = "0xA1C8BF0", VA = "0x18A1C9BF0")]
		private void QCPFHMSHTJY(LXUPYHZBZJT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0xA1CAE30", Offset = "0xA1C9E30", VA = "0x18A1CAE30")]
		private void UXFHJGSAMKJ(LXUPYHZBZJT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0xA1C5830", Offset = "0xA1C4830", VA = "0x18A1C5830")]
		private void AFJMWNEGQUG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0xA1C9460", Offset = "0xA1C8460", VA = "0x18A1C9460")]
		private void ODVRXNQHCMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0xA1C6C00", Offset = "0xA1C5C00", VA = "0x18A1C6C00")]
		private void ETPSUOHODDV(LXUPYHZBZJT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0xA1C8270", Offset = "0xA1C7270", VA = "0x18A1C8270")]
		private void IPTSEZGPFEE(LXUPYHZBZJT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0xA1C86F0", Offset = "0xA1C76F0", VA = "0x18A1C86F0")]
		private void KBQMFYLCBTS(LXUPYHZBZJT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0xA1CB3A0", Offset = "0xA1CA3A0", VA = "0x18A1CB3A0")]
		private void XHKNEIJPFAJ(OGYYXGOOHSH a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0xA1C6FD0", Offset = "0xA1C5FD0", VA = "0x18A1C6FD0", Slot = "142")]
		protected virtual void GAZNJWHLUGC(OGYYXGOOHSH a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0xA1CA1A0", Offset = "0xA1C91A0", VA = "0x18A1CA1A0")]
		protected void RHWMUQLQBRK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0xA1CB710", Offset = "0xA1CA710", VA = "0x18A1CB710")]
		protected void YDRSQNMAEPW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0xA1C8340", Offset = "0xA1C7340", VA = "0x18A1C8340")]
		private void IWHYREMTCCW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0xA1C88A0", Offset = "0xA1C78A0", VA = "0x18A1C88A0")]
		private void KSFWWYKGGRF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	internal static class DOMVYLUGVPU
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0xA1C0AF0", Offset = "0xA1BFAF0", VA = "0x18A1C0AF0")]
		public static LXUPYHZBZJT JPCOOTYCPHR(this LXUPYHZBZJT a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0xA1C0980", Offset = "0xA1BF980", VA = "0x18A1C0980")]
		public static bool BHCQBJOERKC(this LXUPYHZBZJT a, LXUPYHZBZJT b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0xA1C0BB0", Offset = "0xA1BFBB0", VA = "0x18A1C0BB0")]
		public static bool SZXQDMUKRLK(this LXUPYHZBZJT a, LXUPYHZBZJT b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0xA1C0AA0", Offset = "0xA1BFAA0", VA = "0x18A1C0AA0")]
		public static OGYYXGOOHSH GKWVVVQMOHE(this LXUPYHZBZJT a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0xA1C0A20", Offset = "0xA1BFA20", VA = "0x18A1C0A20")]
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
		[Cpp2IlInjected.Address(RVA = "0xA1C19C0", Offset = "0xA1C09C0", VA = "0x18A1C19C0", Slot = "19")]
		public LXUPYHZBZJT RTYDXWLWRNM(RigidbodyEx a, RigidbodyExData b, TXSHHVHGWNE c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0xD0AFA0", Offset = "0xD09FA0", VA = "0x180D0AFA0", Slot = "4")]
		public NQKBXILZAUJ AEOWBCZJYDR(LXUPYHZBZJT a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0xD0AFA0", Offset = "0xD09FA0", VA = "0x180D0AFA0", Slot = "5")]
		public FIDNUJTSXPT HCOSETOVPHF(LXUPYHZBZJT a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0xD0AFA0", Offset = "0xD09FA0", VA = "0x180D0AFA0", Slot = "6")]
		public BCXHEVYETUK GTPWLZDLDPW(LXUPYHZBZJT a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0xD0AFA0", Offset = "0xD09FA0", VA = "0x180D0AFA0", Slot = "7")]
		public XTQQSIWUNAD JAYJFJCBXND(LXUPYHZBZJT a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0xD0AFA0", Offset = "0xD09FA0", VA = "0x180D0AFA0", Slot = "8")]
		public VAQXZSQRJSJ MZWOLCOWJQT(LXUPYHZBZJT a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0xD0AFA0", Offset = "0xD09FA0", VA = "0x180D0AFA0", Slot = "9")]
		public SBEFVAXGCFY OCAPGECIGWM(LXUPYHZBZJT a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0xD0AFA0", Offset = "0xD09FA0", VA = "0x180D0AFA0", Slot = "10")]
		public ADFYPFYYJTJ OCDTSIECVCR(LXUPYHZBZJT a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0xD0AFA0", Offset = "0xD09FA0", VA = "0x180D0AFA0", Slot = "11")]
		public CPTWJAIUUZT WZIXDBDJNVJ(LXUPYHZBZJT a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0xD0AFA0", Offset = "0xD09FA0", VA = "0x180D0AFA0", Slot = "12")]
		public HYNZHTJVJYV EPSLMPHOXHV(LXUPYHZBZJT a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0xD0AFA0", Offset = "0xD09FA0", VA = "0x180D0AFA0", Slot = "13")]
		public HJSVZQWCZSU UWOGCCWBZSC(LXUPYHZBZJT a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0xD0AFA0", Offset = "0xD09FA0", VA = "0x180D0AFA0")]
		public AFCZAFOTJDY OGFPGPDGXUA(LXUPYHZBZJT a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0xD0AFA0", Offset = "0xD09FA0", VA = "0x180D0AFA0")]
		public LLGCBUIDYLE DEUYBJBKGKE(LXUPYHZBZJT a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0xD0AFA0", Offset = "0xD09FA0", VA = "0x180D0AFA0")]
		public FFFMJOLTGZC VMKRPZSJBPQ(LXUPYHZBZJT a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0xD0AFA0", Offset = "0xD09FA0", VA = "0x180D0AFA0")]
		public ABJGSSFBSGY FLBXRNWIHHY(LXUPYHZBZJT a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0xD0AFA0", Offset = "0xD09FA0", VA = "0x180D0AFA0")]
		public IHWEUKEKZTG AWFTSRBVHWO(LXUPYHZBZJT a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
		public ETONMYGAMUJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0xD0AFA0", Offset = "0xD09FA0", VA = "0x180D0AFA0", Slot = "14")]
		private AFCZAFOTJDY YUPTTIWPIPG(LXUPYHZBZJT a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0xD0AFA0", Offset = "0xD09FA0", VA = "0x180D0AFA0", Slot = "15")]
		private LLGCBUIDYLE ZPXXPSYNDKI(LXUPYHZBZJT a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0xD0AFA0", Offset = "0xD09FA0", VA = "0x180D0AFA0", Slot = "16")]
		private FFFMJOLTGZC RUAEOWTOHBM(LXUPYHZBZJT a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0xD0AFA0", Offset = "0xD09FA0", VA = "0x180D0AFA0", Slot = "17")]
		private ABJGSSFBSGY SYJIIBGLGXE(LXUPYHZBZJT a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0xD0AFA0", Offset = "0xD09FA0", VA = "0x180D0AFA0", Slot = "18")]
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
			[Cpp2IlInjected.Address(RVA = "0xA1C48D0", Offset = "0xA1C38D0", VA = "0x18A1C48D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0xA1C4350", Offset = "0xA1C3350", VA = "0x18A1C4350", Slot = "20")]
		public void InitReferences(PPCVAYWFABF services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0xA1C3EC0", Offset = "0xA1C2EC0", VA = "0x18A1C3EC0", Slot = "4")]
		public NQKBXILZAUJ AEOWBCZJYDR(LXUPYHZBZJT a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0xA1C42B0", Offset = "0xA1C32B0", VA = "0x18A1C42B0", Slot = "5")]
		public FIDNUJTSXPT HCOSETOVPHF(LXUPYHZBZJT a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0xA1C4210", Offset = "0xA1C3210", VA = "0x18A1C4210", Slot = "6")]
		public BCXHEVYETUK GTPWLZDLDPW(LXUPYHZBZJT a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0xA1C43A0", Offset = "0xA1C33A0", VA = "0x18A1C43A0", Slot = "7")]
		public XTQQSIWUNAD JAYJFJCBXND(LXUPYHZBZJT a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0xA1C4440", Offset = "0xA1C3440", VA = "0x18A1C4440", Slot = "8")]
		public VAQXZSQRJSJ MZWOLCOWJQT(LXUPYHZBZJT a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0xA1C44E0", Offset = "0xA1C34E0", VA = "0x18A1C44E0", Slot = "9")]
		public SBEFVAXGCFY OCAPGECIGWM(LXUPYHZBZJT a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0xA1C4580", Offset = "0xA1C3580", VA = "0x18A1C4580", Slot = "10")]
		public ADFYPFYYJTJ OCDTSIECVCR(LXUPYHZBZJT a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0xA1C49D0", Offset = "0xA1C39D0", VA = "0x18A1C49D0", Slot = "11")]
		public CPTWJAIUUZT WZIXDBDJNVJ(LXUPYHZBZJT a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0xA1C40C0", Offset = "0xA1C30C0", VA = "0x18A1C40C0", Slot = "12")]
		public HYNZHTJVJYV EPSLMPHOXHV(LXUPYHZBZJT a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0xA1C4930", Offset = "0xA1C3930", VA = "0x18A1C4930", Slot = "13")]
		public HJSVZQWCZSU UWOGCCWBZSC(LXUPYHZBZJT a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0xA1C4620", Offset = "0xA1C3620", VA = "0x18A1C4620")]
		public AFCZAFOTJDY OGFPGPDGXUA(LXUPYHZBZJT a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0xA1C4010", Offset = "0xA1C3010", VA = "0x18A1C4010")]
		public LLGCBUIDYLE DEUYBJBKGKE(LXUPYHZBZJT a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0xA1C4820", Offset = "0xA1C3820", VA = "0x18A1C4820")]
		public FFFMJOLTGZC VMKRPZSJBPQ(LXUPYHZBZJT a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0xA1C4160", Offset = "0xA1C3160", VA = "0x18A1C4160")]
		public ABJGSSFBSGY FLBXRNWIHHY(LXUPYHZBZJT a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0xA1C3F60", Offset = "0xA1C2F60", VA = "0x18A1C3F60")]
		public IHWEUKEKZTG AWFTSRBVHWO(LXUPYHZBZJT a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0xA1C46D0", Offset = "0xA1C36D0", VA = "0x18A1C46D0", Slot = "19")]
		public LXUPYHZBZJT RTYDXWLWRNM(RigidbodyEx a, RigidbodyExData b, TXSHHVHGWNE c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0xA1C4A70", Offset = "0xA1C3A70", VA = "0x18A1C4A70")]
		public OWGUNCTTUDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0xA1C4620", Offset = "0xA1C3620", VA = "0x18A1C4620", Slot = "14")]
		private AFCZAFOTJDY YUPTTIWPIPG(LXUPYHZBZJT a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0xA1C4010", Offset = "0xA1C3010", VA = "0x18A1C4010", Slot = "15")]
		private LLGCBUIDYLE ZPXXPSYNDKI(LXUPYHZBZJT a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0xA1C4820", Offset = "0xA1C3820", VA = "0x18A1C4820", Slot = "16")]
		private FFFMJOLTGZC RUAEOWTOHBM(LXUPYHZBZJT a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0xA1C4160", Offset = "0xA1C3160", VA = "0x18A1C4160", Slot = "17")]
		private ABJGSSFBSGY SYJIIBGLGXE(LXUPYHZBZJT a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0xA1C3F60", Offset = "0xA1C2F60", VA = "0x18A1C3F60", Slot = "18")]
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
			[Cpp2IlInjected.Address(RVA = "0xA1D76B0", Offset = "0xA1D66B0", VA = "0x18A1D76B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		public CollisionDetectionMode NZWQSZICZJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0xA1D80E0", Offset = "0xA1D70E0", VA = "0x18A1D80E0", Slot = "4")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0xA1D81F0", Offset = "0xA1D71F0", VA = "0x18A1D81F0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0xA1C3070", Offset = "0xA1C2070", VA = "0x18A1C3070")]
		public UTMSZZATPOC(LXUPYHZBZJT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0xA1D7D50", Offset = "0xA1D6D50", VA = "0x18A1D7D50", Slot = "6")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0xA1D8260", Offset = "0xA1D7260", VA = "0x18A1D8260", Slot = "9")]
		public void SMDWCQWJFSZ(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0xA1D82E0", Offset = "0xA1D72E0", VA = "0x18A1D82E0", Slot = "7")]
		public void UFRYBKIKRJO(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0xA1D82F0", Offset = "0xA1D72F0", VA = "0x18A1D82F0", Slot = "8")]
		public void ZGFHBBRUKKH(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0xA1D7F80", Offset = "0xA1D6F80", VA = "0x18A1D7F80", Slot = "10")]
		public bool HXXFZGWJNGE(Vector3 a, [Out] RaycastHit b, float c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0xA1D7E60", Offset = "0xA1D6E60", VA = "0x18A1D7E60")]
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
			[Cpp2IlInjected.Address(RVA = "0xA1D65C0", Offset = "0xA1D55C0", VA = "0x18A1D65C0", Slot = "6")]
			get
			{
				return default(TransformTrackRate);
			}
			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0xA1D6710", Offset = "0xA1D5710", VA = "0x18A1D6710", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000092")]
		private Transform IDVIIKQTPWA
		{
			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0xA1D68E0", Offset = "0xA1D58E0", VA = "0x18A1D68E0", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000020")]
		public event Action<UpdateLOD, UpdateLOD> CSGCRCJQBEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0xA1D6830", Offset = "0xA1D5830", VA = "0x18A1D6830", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0xA1D6900", Offset = "0xA1D5900", VA = "0x18A1D6900", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0xA1D69B0", Offset = "0xA1D59B0", VA = "0x18A1D69B0")]
		public SUNFKJQTYAH(LXUPYHZBZJT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0xA1D6350", Offset = "0xA1D5350", VA = "0x18A1D6350", Slot = "8")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0xA1D67E0", Offset = "0xA1D57E0", VA = "0x18A1D67E0", Slot = "9")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x13F6450", Offset = "0x13F5450", VA = "0x1813F6450", Slot = "11")]
		private void CHAAODDTBNN(UpdateLOD a, UpdateLOD b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "12")]
		private void IPRAGVDYFNB(bool a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class ETONMYGAMUJ : WTDUGPZWXSI
	{
		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0xA1C0C50", Offset = "0xA1BFC50", VA = "0x18A1C0C50", Slot = "4")]
		public NQKBXILZAUJ AEOWBCZJYDR(LXUPYHZBZJT a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0xA1C1340", Offset = "0xA1C0340", VA = "0x18A1C1340", Slot = "5")]
		public FIDNUJTSXPT HCOSETOVPHF(LXUPYHZBZJT a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0xA1C1220", Offset = "0xA1C0220", VA = "0x18A1C1220", Slot = "6")]
		public BCXHEVYETUK GTPWLZDLDPW(LXUPYHZBZJT a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0xA1C1450", Offset = "0xA1C0450", VA = "0x18A1C1450", Slot = "7")]
		public XTQQSIWUNAD JAYJFJCBXND(LXUPYHZBZJT a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0xA1C14C0", Offset = "0xA1C04C0", VA = "0x18A1C14C0", Slot = "8")]
		public VAQXZSQRJSJ MZWOLCOWJQT(LXUPYHZBZJT a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0xA1C1580", Offset = "0xA1C0580", VA = "0x18A1C1580", Slot = "9")]
		public SBEFVAXGCFY OCAPGECIGWM(LXUPYHZBZJT a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0xA1C1640", Offset = "0xA1C0640", VA = "0x18A1C1640", Slot = "10")]
		public ADFYPFYYJTJ OCDTSIECVCR(LXUPYHZBZJT a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0xA1C1C30", Offset = "0xA1C0C30", VA = "0x18A1C1C30", Slot = "11")]
		public CPTWJAIUUZT WZIXDBDJNVJ(LXUPYHZBZJT a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0xA1C0FD0", Offset = "0xA1BFFD0", VA = "0x18A1C0FD0", Slot = "12")]
		public HYNZHTJVJYV EPSLMPHOXHV(LXUPYHZBZJT a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0xA1C1B70", Offset = "0xA1C0B70", VA = "0x18A1C1B70", Slot = "13")]
		public HJSVZQWCZSU UWOGCCWBZSC(LXUPYHZBZJT a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0xA1C1750", Offset = "0xA1C0750", VA = "0x18A1C1750")]
		public AFCZAFOTJDY OGFPGPDGXUA(LXUPYHZBZJT a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0xA1C0E00", Offset = "0xA1BFE00", VA = "0x18A1C0E00")]
		public LLGCBUIDYLE DEUYBJBKGKE(LXUPYHZBZJT a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0xA1C1A50", Offset = "0xA1C0A50", VA = "0x18A1C1A50")]
		public FFFMJOLTGZC VMKRPZSJBPQ(LXUPYHZBZJT a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0xA1C1090", Offset = "0xA1C0090", VA = "0x18A1C1090")]
		public ABJGSSFBSGY FLBXRNWIHHY(LXUPYHZBZJT a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0xA1C0D30", Offset = "0xA1BFD30", VA = "0x18A1C0D30")]
		public IHWEUKEKZTG AWFTSRBVHWO(LXUPYHZBZJT a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0xA1C1880", Offset = "0xA1C0880", VA = "0x18A1C1880", Slot = "19")]
		public LXUPYHZBZJT RTYDXWLWRNM(RigidbodyEx a, RigidbodyExData b, TXSHHVHGWNE c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
		public ETONMYGAMUJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0xA1C1750", Offset = "0xA1C0750", VA = "0x18A1C1750", Slot = "14")]
		private AFCZAFOTJDY YUPTTIWPIPG(LXUPYHZBZJT a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0xA1C1CF0", Offset = "0xA1C0CF0", VA = "0x18A1C1CF0", Slot = "15")]
		private LLGCBUIDYLE ZPXXPSYNDKI(LXUPYHZBZJT a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0xA1C1A50", Offset = "0xA1C0A50", VA = "0x18A1C1A50", Slot = "16")]
		private FFFMJOLTGZC RUAEOWTOHBM(LXUPYHZBZJT a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0xA1C1090", Offset = "0xA1C0090", VA = "0x18A1C1090", Slot = "17")]
		private ABJGSSFBSGY SYJIIBGLGXE(LXUPYHZBZJT a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0xA1C0D30", Offset = "0xA1BFD30", VA = "0x18A1C0D30", Slot = "18")]
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
			[Cpp2IlInjected.Address(RVA = "0xA1D76B0", Offset = "0xA1D66B0", VA = "0x18A1D76B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000094")]
		private bool CBIJVKAZZYJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000269")]
			[Cpp2IlInjected.Address(RVA = "0xA1D7700", Offset = "0xA1D6700", VA = "0x18A1D7700")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000095")]
		private bool DOFZZALFMLC
		{
			[Cpp2IlInjected.Token(Token = "0x600026A")]
			[Cpp2IlInjected.Address(RVA = "0xA1C1E90", Offset = "0xA1C0E90", VA = "0x18A1C1E90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000096")]
		private LXUPYHZBZJT LXEGSVYJGSM
		{
			[Cpp2IlInjected.Token(Token = "0x600026B")]
			[Cpp2IlInjected.Address(RVA = "0xA1D73F0", Offset = "0xA1D63F0", VA = "0x18A1D73F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0xA1C3070", Offset = "0xA1C2070", VA = "0x18A1C3070")]
		public TVNWSCQCDBC(LXUPYHZBZJT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0xA1D78B0", Offset = "0xA1D68B0", VA = "0x18A1D78B0", Slot = "4")]
		public void USYWIONWZMS(Vector3 a, ForceMode b = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0xA1D7190", Offset = "0xA1D6190", VA = "0x18A1D7190")]
		private void IGEEUTOEEQF(Vector3 a, ForceMode b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0xA1D7A10", Offset = "0xA1D6A10", VA = "0x18A1D7A10", Slot = "5")]
		public void YAPLWXIDAZG(Vector3 a, Vector3 b, ForceMode c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0xA1D7750", Offset = "0xA1D6750", VA = "0x18A1D7750", Slot = "6")]
		public void SZAHRAMMZXH(Vector3 a, ForceMode b = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0xA1D7450", Offset = "0xA1D6450", VA = "0x18A1D7450")]
		private void JLQVJZPBXSM(Vector3 a, ForceMode b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0xA1D6F30", Offset = "0xA1D5F30", VA = "0x18A1D6F30", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0xEBF620", Offset = "0xEBE620", VA = "0x180EBF620", Slot = "4")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000275")]
			[Cpp2IlInjected.Address(RVA = "0xA1C2EC0", Offset = "0xA1C1EC0", VA = "0x18A1C2EC0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0xA1C3070", Offset = "0xA1C2070", VA = "0x18A1C3070")]
		public NJYSCWYZFUF(LXUPYHZBZJT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0xA1C3040", Offset = "0xA1C2040", VA = "0x18A1C3040", Slot = "6")]
		public void SMDWCQWJFSZ(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0xA1C2FD0", Offset = "0xA1C1FD0", VA = "0x18A1C2FD0", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0xA1CC7B0", Offset = "0xA1CB7B0", VA = "0x18A1CC7B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000099")]
		public LXUPYHZBZJT LXEGSVYJGSM
		{
			[Cpp2IlInjected.Token(Token = "0x600028D")]
			[Cpp2IlInjected.Address(RVA = "0xD09730", Offset = "0xD08730", VA = "0x180D09730", Slot = "28")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600028E")]
			[Cpp2IlInjected.Address(RVA = "0xA1CDCE0", Offset = "0xA1CCCE0", VA = "0x18A1CDCE0", Slot = "29")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009A")]
		public LXUPYHZBZJT OFIFJQDFJXG
		{
			[Cpp2IlInjected.Token(Token = "0x600028F")]
			[Cpp2IlInjected.Address(RVA = "0xD09750", Offset = "0xD08750", VA = "0x180D09750", Slot = "27")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		public IReadOnlyList<LXUPYHZBZJT> VFZTJRIUBHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000290")]
			[Cpp2IlInjected.Address(RVA = "0xD09130", Offset = "0xD08130", VA = "0x180D09130", Slot = "26")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000021")]
		public event RbexAction YLNBUCLIBKU
		{
			[Cpp2IlInjected.Token(Token = "0x6000278")]
			[Cpp2IlInjected.Address(RVA = "0xA1CC520", Offset = "0xA1CB520", VA = "0x18A1CC520", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000279")]
			[Cpp2IlInjected.Address(RVA = "0xA1CC970", Offset = "0xA1CB970", VA = "0x18A1CC970", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000022")]
		public event RbexAction OUJVHEBRGPM
		{
			[Cpp2IlInjected.Token(Token = "0x600027A")]
			[Cpp2IlInjected.Address(RVA = "0xA1CCD10", Offset = "0xA1CBD10", VA = "0x18A1CCD10", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600027B")]
			[Cpp2IlInjected.Address(RVA = "0xA1CCDF0", Offset = "0xA1CBDF0", VA = "0x18A1CCDF0", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000023")]
		public event RbexParentChangeAction KPKZLGALJHC
		{
			[Cpp2IlInjected.Token(Token = "0x600027C")]
			[Cpp2IlInjected.Address(RVA = "0xA1CC670", Offset = "0xA1CB670", VA = "0x18A1CC670", Slot = "12")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600027D")]
			[Cpp2IlInjected.Address(RVA = "0xA1CDE20", Offset = "0xA1CCE20", VA = "0x18A1CDE20", Slot = "13")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000024")]
		public event Action TMMQHJCUGDD
		{
			[Cpp2IlInjected.Token(Token = "0x600027E")]
			[Cpp2IlInjected.Address(RVA = "0xA1CDB90", Offset = "0xA1CCB90", VA = "0x18A1CDB90", Slot = "14")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600027F")]
			[Cpp2IlInjected.Address(RVA = "0xA1CCC70", Offset = "0xA1CBC70", VA = "0x18A1CCC70", Slot = "15")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000025")]
		public event Action HXHBELZVDTU
		{
			[Cpp2IlInjected.Token(Token = "0x6000280")]
			[Cpp2IlInjected.Address(RVA = "0xA1CC810", Offset = "0xA1CB810", VA = "0x18A1CC810", Slot = "16")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000281")]
			[Cpp2IlInjected.Address(RVA = "0xA1CDF70", Offset = "0xA1CCF70", VA = "0x18A1CDF70", Slot = "17")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000026")]
		public event Action<LXUPYHZBZJT> ZILSWZCUUGX
		{
			[Cpp2IlInjected.Token(Token = "0x6000282")]
			[Cpp2IlInjected.Address(RVA = "0xA1CC330", Offset = "0xA1CB330", VA = "0x18A1CC330", Slot = "18")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000283")]
			[Cpp2IlInjected.Address(RVA = "0xA1CDC30", Offset = "0xA1CCC30", VA = "0x18A1CDC30", Slot = "19")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000027")]
		public event Action<LXUPYHZBZJT> ZVYLLUTFFLK
		{
			[Cpp2IlInjected.Token(Token = "0x6000284")]
			[Cpp2IlInjected.Address(RVA = "0xA1CDEC0", Offset = "0xA1CCEC0", VA = "0x18A1CDEC0", Slot = "20")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000285")]
			[Cpp2IlInjected.Address(RVA = "0xA1CCE90", Offset = "0xA1CBE90", VA = "0x18A1CCE90", Slot = "21")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000028")]
		public event Action FHOQKHPSETV
		{
			[Cpp2IlInjected.Token(Token = "0x6000286")]
			[Cpp2IlInjected.Address(RVA = "0xA1CCFE0", Offset = "0xA1CBFE0", VA = "0x18A1CCFE0", Slot = "22")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000287")]
			[Cpp2IlInjected.Address(RVA = "0xA1CCBD0", Offset = "0xA1CBBD0", VA = "0x18A1CCBD0", Slot = "23")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000029")]
		public event Action<LXUPYHZBZJT> SVJWKOWWXQQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000288")]
			[Cpp2IlInjected.Address(RVA = "0xA1CC5C0", Offset = "0xA1CB5C0", VA = "0x18A1CC5C0", Slot = "24")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000289")]
			[Cpp2IlInjected.Address(RVA = "0xA1CD080", Offset = "0xA1CC080", VA = "0x18A1CD080", Slot = "25")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0xA1CE010", Offset = "0xA1CD010", VA = "0x18A1CE010")]
		public RbexHierarchy(LXUPYHZBZJT rbex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0xA1CC710", Offset = "0xA1CB710", VA = "0x18A1CC710", Slot = "31")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0xA1CD620", Offset = "0xA1CC620", VA = "0x18A1CD620", Slot = "30")]
		public void SetParent(LXUPYHZBZJT newParent, bool isPhysicallyDetachedOnly = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0xA1CD130", Offset = "0xA1CC130", VA = "0x18A1CD130", Slot = "6")]
		public void SHCZWOOICNP(LXUPYHZBZJT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0xA1CD3A0", Offset = "0xA1CC3A0", VA = "0x18A1CD3A0", Slot = "7")]
		public void SXZFAMPUTNS(LXUPYHZBZJT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0xA1CC240", Offset = "0xA1CB240", VA = "0x18A1CC240", Slot = "4")]
		public void AZYZTCUIDGT(LXUPYHZBZJT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0xA1CCF40", Offset = "0xA1CBF40", VA = "0x18A1CCF40", Slot = "5")]
		public void ODGWVXJIHZI(LXUPYHZBZJT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0xA1CCB30", Offset = "0xA1CBB30", VA = "0x18A1CCB30")]
		private void JKIWDNRYGLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0xA1CCDB0", Offset = "0xA1CBDB0", VA = "0x18A1CCDB0")]
		private void MQPOOIDHNPG(LXUPYHZBZJT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0xA1CC3E0", Offset = "0xA1CB3E0", VA = "0x18A1CC3E0")]
		private void CHJURTWSTYJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0xA1CDCF0", Offset = "0xA1CCCF0", VA = "0x18A1CDCF0")]
		private void UYPRWNBICJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0xA1CCA10", Offset = "0xA1CBA10", VA = "0x18A1CCA10")]
		private void IIDYCPXELIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0xA1CC8B0", Offset = "0xA1CB8B0", VA = "0x18A1CC8B0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA1D7C90", Offset = "0xA1D6C90", VA = "0x18A1D7C90")]
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
			[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		public Vector3 XKMDQDDFWQV
		{
			[Cpp2IlInjected.Token(Token = "0x600029E")]
			[Cpp2IlInjected.Address(RVA = "0xA1C3580", Offset = "0xA1C2580", VA = "0x18A1C3580", Slot = "6")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		public Vector3 SZXZTHRYZSL
		{
			[Cpp2IlInjected.Token(Token = "0x600029F")]
			[Cpp2IlInjected.Address(RVA = "0xA1C3610", Offset = "0xA1C2610", VA = "0x18A1C3610", Slot = "7")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		private Vector3 ICEPCSIMYGD
		{
			[Cpp2IlInjected.Token(Token = "0x60002A3")]
			[Cpp2IlInjected.Address(RVA = "0xA1C34A0", Offset = "0xA1C24A0", VA = "0x18A1C34A0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		public LXUPYHZBZJT DMQLSXJGPVO
		{
			[Cpp2IlInjected.Token(Token = "0x60002A4")]
			[Cpp2IlInjected.Address(RVA = "0xA1C3D20", Offset = "0xA1C2D20", VA = "0x18A1C3D20", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0xA1C3DD0", Offset = "0xA1C2DD0", VA = "0x18A1C3DD0")]
		public OAFMDNLCBJZ(LXUPYHZBZJT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0xA1C3CB0", Offset = "0xA1C2CB0", VA = "0x18A1C3CB0", Slot = "8")]
		public void XYQXFHSLXHJ(LXUPYHZBZJT a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0xA1C35B0", Offset = "0xA1C25B0", VA = "0x18A1C35B0", Slot = "9")]
		public void KJSPAQXWVQU(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0xA1C3910", Offset = "0xA1C2910", VA = "0x18A1C3910")]
		private Vector3 PKJYRHEWVAV()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0xA1C3100", Offset = "0xA1C2100", VA = "0x18A1C3100")]
		private void CIHYXCUKXOO(LXUPYHZBZJT a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	internal static class QNQTMYTXCYZ
	{
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0xA1CC180", Offset = "0xA1CB180", VA = "0x18A1CC180")]
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
			[Cpp2IlInjected.Address(RVA = "0x1EF65B0", Offset = "0x1EF55B0", VA = "0x181EF65B0", Slot = "7")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60002AB")]
			[Cpp2IlInjected.Address(RVA = "0xA1D3C40", Offset = "0xA1D2C40", VA = "0x18A1D3C40", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		public Vector3 JROGDJXDQKE
		{
			[Cpp2IlInjected.Token(Token = "0x60002AC")]
			[Cpp2IlInjected.Address(RVA = "0xA1D3CF0", Offset = "0xA1D2CF0", VA = "0x18A1D3CF0", Slot = "9")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		public float WRDRETNSTCQ
		{
			[Cpp2IlInjected.Token(Token = "0x60002AD")]
			[Cpp2IlInjected.Address(RVA = "0xD5BDC0", Offset = "0xD5ADC0", VA = "0x180D5BDC0", Slot = "10")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60002AE")]
			[Cpp2IlInjected.Address(RVA = "0xA1D3B30", Offset = "0xA1D2B30", VA = "0x18A1D3B30")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A4")]
		public float WURUEBFLLOL
		{
			[Cpp2IlInjected.Token(Token = "0x60002AF")]
			[Cpp2IlInjected.Address(RVA = "0xD5BDD0", Offset = "0xD5ADD0", VA = "0x180D5BDD0", Slot = "11")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60002B0")]
			[Cpp2IlInjected.Address(RVA = "0xA1D3F90", Offset = "0xA1D2F90", VA = "0x18A1D3F90", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		public Vector3 LSZXGKRJVRR
		{
			[Cpp2IlInjected.Token(Token = "0x60002B1")]
			[Cpp2IlInjected.Address(RVA = "0xA1D6060", Offset = "0xA1D5060", VA = "0x18A1D6060", Slot = "13")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A6")]
		public Quaternion GOCCYCVSGLD
		{
			[Cpp2IlInjected.Token(Token = "0x60002B2")]
			[Cpp2IlInjected.Address(RVA = "0xA1D4120", Offset = "0xA1D3120", VA = "0x18A1D4120", Slot = "14")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A7")]
		private Rigidbody EUMMWSSQGSM
		{
			[Cpp2IlInjected.Token(Token = "0x60002BA")]
			[Cpp2IlInjected.Address(RVA = "0xA1C5220", Offset = "0xA1C4220", VA = "0x18A1C5220")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400002A")]
		public event RbexAction YCQZDDFZPPU
		{
			[Cpp2IlInjected.Token(Token = "0x60002A8")]
			[Cpp2IlInjected.Address(RVA = "0xA1D5FC0", Offset = "0xA1D4FC0", VA = "0x18A1D5FC0", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60002A9")]
			[Cpp2IlInjected.Address(RVA = "0xA1D50B0", Offset = "0xA1D40B0", VA = "0x18A1D50B0", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0xA1D61F0", Offset = "0xA1D51F0", VA = "0x18A1D61F0")]
		public SKBTNPXHJUH(LXUPYHZBZJT a, [In] RigidbodyExData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0xA1D4670", Offset = "0xA1D3670", VA = "0x18A1D4670", Slot = "17")]
		public void OYEMNLQPEHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0xA1D4040", Offset = "0xA1D3040", VA = "0x18A1D4040", Slot = "16")]
		public void LAPJFJGAHUC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0xA1D4E30", Offset = "0xA1D3E30", VA = "0x18A1D4E30", Slot = "19")]
		public void SMDWCQWJFSZ(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0xA1D4C50", Offset = "0xA1D3C50", VA = "0x18A1D4C50", Slot = "20")]
		public void SBBJNFQRYPU(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0xA1D44D0", Offset = "0xA1D34D0", VA = "0x18A1D44D0", Slot = "18")]
		public void OXLQGXAIGFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0xA1D4790", Offset = "0xA1D3790", VA = "0x18A1D4790", Slot = "21")]
		public void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0xA1D3C40", Offset = "0xA1D2C40", VA = "0x18A1D3C40")]
		private void QUJXDFPFGML(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0xA1D3A10", Offset = "0xA1D2A10", VA = "0x18A1D3A10")]
		[Obsolete("This method is dangerous - the unity rigidbody is updated in a deferred manner and this world position may be stale")]
		private Vector3 CCQHMDIXFPK()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0xA1D3B30", Offset = "0xA1D2B30", VA = "0x18A1D3B30")]
		private void DININTCDFPO(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0xA1D3F90", Offset = "0xA1D2F90", VA = "0x18A1D3F90")]
		private void KTPWFQPLKMT(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0xA1D4F10", Offset = "0xA1D3F10", VA = "0x18A1D4F10")]
		private Vector3 SUXMJAIKGED()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0xA1D42A0", Offset = "0xA1D32A0", VA = "0x18A1D42A0", Slot = "15")]
		public void NPMABWUKGBF((Quaternion rot, Vector3 moments) tensor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0xA1D3E10", Offset = "0xA1D2E10", VA = "0x18A1D3E10")]
		private Quaternion JZBISQYTRAR()
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0xA1D5EF0", Offset = "0xA1D4EF0", VA = "0x18A1D5EF0")]
		public void VHRIAWQLATM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0xA1D5150", Offset = "0xA1D4150", VA = "0x18A1D5150", Slot = "4")]
		public (float, Vector3) VHRIAWQLATM(Rigidbody a)
		{
			return default((float, Vector3));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	internal static class SJLJPHKCPEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0xA1D3950", Offset = "0xA1D2950", VA = "0x18A1D3950")]
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
			[Cpp2IlInjected.Address(RVA = "0x1B7F7D0", Offset = "0x1B7E7D0", VA = "0x181B7F7D0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A9")]
		public RbexInterpolationMode VCPJRYGHJXB
		{
			[Cpp2IlInjected.Token(Token = "0x60002C6")]
			[Cpp2IlInjected.Address(RVA = "0xD1B830", Offset = "0xD1A830", VA = "0x180D1B830", Slot = "11")]
			get
			{
				return default(RbexInterpolationMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0xA1C2CD0", Offset = "0xA1C1CD0", VA = "0x18A1C2CD0")]
		public LSONWYJENIF(LXUPYHZBZJT a, [In] RigidbodyExData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0xA1C26C0", Offset = "0xA1C16C0", VA = "0x18A1C26C0", Slot = "4")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0xA1C2790", Offset = "0xA1C1790", VA = "0x18A1C2790")]
		private bool CACVDIXJQER()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0xA1C28B0", Offset = "0xA1C18B0", VA = "0x18A1C28B0", Slot = "5")]
		public void OUMBAYJWNTF(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0xA1C28E0", Offset = "0xA1C18E0", VA = "0x18A1C28E0", Slot = "6")]
		public void PSBAGEZXJXE(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0xA1C2A20", Offset = "0xA1C1A20", VA = "0x18A1C2A20", Slot = "9")]
		public void TVQONGPDDXA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0xA1C2910", Offset = "0xA1C1910", VA = "0x18A1C2910")]
		private void TBHXRCHPIDT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0xA1C2B50", Offset = "0xA1C1B50", VA = "0x18A1C2B50")]
		private void ZDNKKORVCDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0xA1C2830", Offset = "0xA1C1830", VA = "0x18A1C2830", Slot = "8")]
		public void HUICRUBRLUV(LXUPYHZBZJT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0xA1C2870", Offset = "0xA1C1870", VA = "0x18A1C2870", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0xA1D6CD0", Offset = "0xA1D5CD0", VA = "0x18A1D6CD0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400002B")]
		public event RbexAction UEXVUWFUIRR
		{
			[Cpp2IlInjected.Token(Token = "0x60002D1")]
			[Cpp2IlInjected.Address(RVA = "0xA1D6A40", Offset = "0xA1D5A40", VA = "0x18A1D6A40", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60002D2")]
			[Cpp2IlInjected.Address(RVA = "0xA1D6BF0", Offset = "0xA1D5BF0", VA = "0x18A1D6BF0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0xA1D6E50", Offset = "0xA1D5E50", VA = "0x18A1D6E50")]
		public TBTBRSKXOGG(LXUPYHZBZJT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0xA1D6E40", Offset = "0xA1D5E40", VA = "0x18A1D6E40", Slot = "7")]
		public void ZVQCSLWDZWM(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0xA1D6D80", Offset = "0xA1D5D80", VA = "0x18A1D6D80", Slot = "8")]
		public void OLXCXOCOVEZ(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0xA1D6AE0", Offset = "0xA1D5AE0", VA = "0x18A1D6AE0", Slot = "9")]
		public void DFZMGVMLCVL(object a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0xA1D6C90", Offset = "0xA1D5C90", VA = "0x18A1D6C90", Slot = "12")]
		public void KVKQZFGQMKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0xA1D6DC0", Offset = "0xA1D5DC0", VA = "0x18A1D6DC0", Slot = "10")]
		public void SMDWCQWJFSZ(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0xA1D6D90", Offset = "0xA1D5D90", VA = "0x18A1D6D90", Slot = "11")]
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
			[Cpp2IlInjected.Address(RVA = "0xD0F400", Offset = "0xD0E400", VA = "0x180D0F400", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AC")]
		public bool XKPOTKSKOSY
		{
			[Cpp2IlInjected.Token(Token = "0x60002DE")]
			[Cpp2IlInjected.Address(RVA = "0xA1DBB10", Offset = "0xA1DAB10", VA = "0x18A1DBB10", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AD")]
		public bool RHREZJRVEHQ
		{
			[Cpp2IlInjected.Token(Token = "0x60002DF")]
			[Cpp2IlInjected.Address(RVA = "0xD69190", Offset = "0xD68190", VA = "0x180D69190", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400002C")]
		public event RbexAction ITXXROJJITF
		{
			[Cpp2IlInjected.Token(Token = "0x60002DB")]
			[Cpp2IlInjected.Address(RVA = "0xA1DC160", Offset = "0xA1DB160", VA = "0x18A1DC160", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60002DC")]
			[Cpp2IlInjected.Address(RVA = "0xA1DC5E0", Offset = "0xA1DB5E0", VA = "0x18A1DC5E0", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0xA1DC680", Offset = "0xA1DB680", VA = "0x18A1DC680")]
		public YSLEPNBYYVB(LXUPYHZBZJT a, [In] RigidbodyExData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0xA1DB890", Offset = "0xA1DA890", VA = "0x18A1DB890", Slot = "9")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0xA1DBB20", Offset = "0xA1DAB20", VA = "0x18A1DBB20", Slot = "12")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0xA1DBE50", Offset = "0xA1DAE50", VA = "0x18A1DBE50", Slot = "10")]
		public void IPTSEZGPFEE(LXUPYHZBZJT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0xA1DBFE0", Offset = "0xA1DAFE0", VA = "0x18A1DBFE0", Slot = "11")]
		public void KBQMFYLCBTS(LXUPYHZBZJT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0xA1DC200", Offset = "0xA1DB200", VA = "0x18A1DC200")]
		private void PNJFPQMSQGI(RRNetworkView a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0xA1DB9C0", Offset = "0xA1DA9C0", VA = "0x18A1DB9C0")]
		private void BBNIMRMYCHK(OGYYXGOOHSH a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0xA1DC370", Offset = "0xA1DB370", VA = "0x18A1DC370")]
		private void SCHEYODJHQJ(RRNetworkView a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	internal static class ITUKOOIUHEB
	{
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0xA1C1D00", Offset = "0xA1C0D00", VA = "0x18A1C1D00")]
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
			[Cpp2IlInjected.Address(RVA = "0xEB2930", Offset = "0xEB1930", VA = "0x180EB2930", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002EA")]
			[Cpp2IlInjected.Address(RVA = "0xED6F40", Offset = "0xED5F40", VA = "0x180ED6F40", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AF")]
		public bool VILIHWWNEAO
		{
			[Cpp2IlInjected.Token(Token = "0x60002EB")]
			[Cpp2IlInjected.Address(RVA = "0xED75E0", Offset = "0xED65E0", VA = "0x180ED75E0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002EC")]
			[Cpp2IlInjected.Address(RVA = "0xED7560", Offset = "0xED6560", VA = "0x180ED7560")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B0")]
		public RigidbodyConstraints BRFYXOLZCXW
		{
			[Cpp2IlInjected.Token(Token = "0x60002ED")]
			[Cpp2IlInjected.Address(RVA = "0xD127D0", Offset = "0xD117D0", VA = "0x180D127D0", Slot = "7")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x60002EE")]
			[Cpp2IlInjected.Address(RVA = "0xA1D85D0", Offset = "0xA1D75D0", VA = "0x18A1D85D0", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0xA1D8760", Offset = "0xA1D7760", VA = "0x18A1D8760")]
		public VOITZAYFQRR(LXUPYHZBZJT a, [In] RigidbodyExData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0xA1D8730", Offset = "0xA1D7730", VA = "0x18A1D8730", Slot = "9")]
		public void SMDWCQWJFSZ(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0xA1D8700", Offset = "0xA1D7700", VA = "0x18A1D8700", Slot = "10")]
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
			[Cpp2IlInjected.Address(RVA = "0xD632C0", Offset = "0xD622C0", VA = "0x180D632C0", Slot = "4")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60002F4")]
			[Cpp2IlInjected.Address(RVA = "0xA1D8300", Offset = "0xA1D7300", VA = "0x18A1D8300", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B2")]
		public float STVEYJONKSE
		{
			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0xD63240", Offset = "0xD62240", VA = "0x180D63240", Slot = "6")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60002F6")]
			[Cpp2IlInjected.Address(RVA = "0xA1D8470", Offset = "0xA1D7470", VA = "0x18A1D8470", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0xA1D8590", Offset = "0xA1D7590", VA = "0x18A1D8590")]
		public VDKMEUOLXWU(LXUPYHZBZJT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0xA1D8540", Offset = "0xA1D7540", VA = "0x18A1D8540", Slot = "8")]
		public void SMDWCQWJFSZ(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0xA1D83D0", Offset = "0xA1D73D0", VA = "0x18A1D83D0", Slot = "9")]
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
			[Cpp2IlInjected.Address(RVA = "0xA1C5220", Offset = "0xA1C4220", VA = "0x18A1C5220")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B4")]
		private bool XGWXTLEZCYP
		{
			[Cpp2IlInjected.Token(Token = "0x60002FC")]
			[Cpp2IlInjected.Address(RVA = "0xA1C4D30", Offset = "0xA1C3D30", VA = "0x18A1C4D30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B5")]
		private LXUPYHZBZJT LXEGSVYJGSM
		{
			[Cpp2IlInjected.Token(Token = "0x60002FD")]
			[Cpp2IlInjected.Address(RVA = "0xA1C51C0", Offset = "0xA1C41C0", VA = "0x18A1C51C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B6")]
		private bool DOFZZALFMLC
		{
			[Cpp2IlInjected.Token(Token = "0x60002FE")]
			[Cpp2IlInjected.Address(RVA = "0xA1C5010", Offset = "0xA1C4010", VA = "0x18A1C5010")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400002D")]
		public event RbexAction IFPNYWKNMIB
		{
			[Cpp2IlInjected.Token(Token = "0x60002F9")]
			[Cpp2IlInjected.Address(RVA = "0xA1C4E80", Offset = "0xA1C3E80", VA = "0x18A1C4E80", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0xA1C5610", Offset = "0xA1C4610", VA = "0x18A1C5610", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0xA1C5750", Offset = "0xA1C4750", VA = "0x18A1C5750")]
		public OYKIZDJUYWQ(LXUPYHZBZJT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0xA1C4B10", Offset = "0xA1C3B10", VA = "0x18A1C4B10", Slot = "6")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0xA1C56B0", Offset = "0xA1C46B0", VA = "0x18A1C56B0", Slot = "8")]
		public void VYEFYJZZCNR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0xA1C5070", Offset = "0xA1C4070", VA = "0x18A1C5070", Slot = "7")]
		public bool JGCPBCSKBCV()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0xA1C5540", Offset = "0xA1C4540", VA = "0x18A1C5540", Slot = "9")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0xA1C54A0", Offset = "0xA1C44A0", VA = "0x18A1C54A0", Slot = "13")]
		public void RKYXLQNOLOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0xA1C4D50", Offset = "0xA1C3D50", VA = "0x18A1C4D50", Slot = "12")]
		public void EBBJEEVITQI(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0xA1C5270", Offset = "0xA1C4270", VA = "0x18A1C5270", Slot = "10")]
		public bool JTGXIODXUYL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0xA1C4F20", Offset = "0xA1C3F20", VA = "0x18A1C4F20", Slot = "11")]
		public bool EZCSABKDGIO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0xA1C52E0", Offset = "0xA1C42E0", VA = "0x18A1C52E0")]
		private bool OADRYVKWYMM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0xA1C4BA0", Offset = "0xA1C3BA0", VA = "0x18A1C4BA0")]
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
			[Cpp2IlInjected.Address(RVA = "0xD0CE10", Offset = "0xD0BE10", VA = "0x180D0CE10", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600030C")]
			[Cpp2IlInjected.Address(RVA = "0xD0C7F0", Offset = "0xD0B7F0", VA = "0x180D0C7F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B8")]
		private bool DOFZZALFMLC
		{
			[Cpp2IlInjected.Token(Token = "0x600030D")]
			[Cpp2IlInjected.Address(RVA = "0xA1C1E90", Offset = "0xA1C0E90", VA = "0x18A1C1E90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B9")]
		public bool HAYPWHZEPMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000310")]
			[Cpp2IlInjected.Address(RVA = "0x1B7F7D0", Offset = "0x1B7E7D0", VA = "0x181B7F7D0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0xA1C25C0", Offset = "0xA1C15C0", VA = "0x18A1C25C0")]
		public KKEHUPUWHRX(LXUPYHZBZJT a, [In] RigidbodyExData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0xA1C1DC0", Offset = "0xA1C0DC0", VA = "0x18A1C1DC0", Slot = "5")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0xA1C23A0", Offset = "0xA1C13A0", VA = "0x18A1C23A0", Slot = "7")]
		public void TFXFJGHHFHF(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0xA1C1E60", Offset = "0xA1C0E60", VA = "0x18A1C1E60", Slot = "8")]
		public void DTJULSXSPPU(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0xA1C2070", Offset = "0xA1C1070", VA = "0x18A1C2070", Slot = "9")]
		public void REBXJJKYCZV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0xA1C23D0", Offset = "0xA1C13D0", VA = "0x18A1C23D0", Slot = "10")]
		public void WBCHPINQQGY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0xA1C1EF0", Offset = "0xA1C0EF0", VA = "0x18A1C1EF0", Slot = "11")]
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
			[Cpp2IlInjected.Address(RVA = "0xD0F400", Offset = "0xD0E400", VA = "0x180D0F400", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000317")]
			[Cpp2IlInjected.Address(RVA = "0xD0C800", Offset = "0xD0B800", VA = "0x180D0C800", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		public HAIRCSDLSLS HEFJROZQYWZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000318")]
			[Cpp2IlInjected.Address(RVA = "0xD0FCD0", Offset = "0xD0ECD0", VA = "0x180D0FCD0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000319")]
			[Cpp2IlInjected.Address(RVA = "0xD115A0", Offset = "0xD105A0", VA = "0x180D115A0", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BC")]
		public Vector3 ICEPCSIMYGD
		{
			[Cpp2IlInjected.Token(Token = "0x600031A")]
			[Cpp2IlInjected.Address(RVA = "0xA1D91F0", Offset = "0xA1D81F0", VA = "0x18A1D91F0", Slot = "8")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600031B")]
			[Cpp2IlInjected.Address(RVA = "0xA1D8CB0", Offset = "0xA1D7CB0", VA = "0x18A1D8CB0", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BD")]
		public Vector3 MDEBPHEQMEU
		{
			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(RVA = "0xA1D9840", Offset = "0xA1D8840", VA = "0x18A1D9840", Slot = "10")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600031D")]
			[Cpp2IlInjected.Address(RVA = "0xA1D8950", Offset = "0xA1D7950", VA = "0x18A1D8950", Slot = "11")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BE")]
		public Vector3 LDDNNQAATIV
		{
			[Cpp2IlInjected.Token(Token = "0x600031E")]
			[Cpp2IlInjected.Address(RVA = "0xA1D9C20", Offset = "0xA1D8C20", VA = "0x18A1D9C20", Slot = "12")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600031F")]
			[Cpp2IlInjected.Address(RVA = "0xA1D95F0", Offset = "0xA1D85F0", VA = "0x18A1D95F0", Slot = "13")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BF")]
		public Vector3 TLYLWZDIHEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000320")]
			[Cpp2IlInjected.Address(RVA = "0xA1D96B0", Offset = "0xA1D86B0", VA = "0x18A1D96B0", Slot = "14")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0xA1D8810", Offset = "0xA1D7810", VA = "0x18A1D8810", Slot = "15")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C0")]
		public float KJTVCDHLYHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000322")]
			[Cpp2IlInjected.Address(RVA = "0xD632D0", Offset = "0xD622D0", VA = "0x180D632D0", Slot = "16")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000323")]
			[Cpp2IlInjected.Address(RVA = "0xA1D8980", Offset = "0xA1D7980", VA = "0x18A1D8980", Slot = "17")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C1")]
		public bool LIMCAIRXPKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000324")]
			[Cpp2IlInjected.Address(RVA = "0x25FF790", Offset = "0x25FE790", VA = "0x1825FF790", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C2")]
		private CPTWJAIUUZT YQFDQFIJJDZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000339")]
			[Cpp2IlInjected.Address(RVA = "0x96FC7F0", Offset = "0x96FB7F0", VA = "0x1896FC7F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C3")]
		private bool XGWXTLEZCYP
		{
			[Cpp2IlInjected.Token(Token = "0x600033A")]
			[Cpp2IlInjected.Address(RVA = "0xA1D8A90", Offset = "0xA1D7A90", VA = "0x18A1D8A90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0xA1DB6E0", Offset = "0xA1DA6E0", VA = "0x18A1DB6E0")]
		public VPJLYCUOSPQ(LXUPYHZBZJT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0xA1D8840", Offset = "0xA1D7840", VA = "0x18A1D8840", Slot = "19")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0xA1D8AB0", Offset = "0xA1D7AB0", VA = "0x18A1D8AB0", Slot = "36")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0xA1DACD0", Offset = "0xA1D9CD0", VA = "0x18A1DACD0", Slot = "28")]
		public void SMDWCQWJFSZ(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x19251E0", Offset = "0x19241E0", VA = "0x1819251E0", Slot = "20")]
		public void HEJEBYMVYXB(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x19251C0", Offset = "0x19241C0", VA = "0x1819251C0", Slot = "30")]
		public void QSNFCIRMICO(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0xA1DB370", Offset = "0xA1DA370", VA = "0x18A1DB370", Slot = "35")]
		public Vector3 YPKMPNFBOFR(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0xA1D9DE0", Offset = "0xA1D8DE0", VA = "0x18A1D9DE0", Slot = "34")]
		public Vector3 QAIXHGLGTND(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0xA1D8840", Offset = "0xA1D7840", VA = "0x18A1D8840", Slot = "27")]
		public void ZDKPEVDVEEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0xA1D99C0", Offset = "0xA1D89C0", VA = "0x18A1D99C0", Slot = "25")]
		public void LVVLWBMRZLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0xA1D9BC0", Offset = "0xA1D8BC0", VA = "0x18A1D9BC0", Slot = "24")]
		public void MCQBNWMCNZI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0xA1D93B0", Offset = "0xA1D83B0", VA = "0x18A1D93B0", Slot = "33")]
		public void IHXJKMBIMTE(Vector3 a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0xA1D88F0", Offset = "0xA1D78F0", VA = "0x18A1D88F0", Slot = "32")]
		public void BLHUQEBCBOP(Vector3 a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0xA1D9A20", Offset = "0xA1D8A20", VA = "0x18A1D9A20", Slot = "31")]
		public void MANMXVCYIEK(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0xA1DA780", Offset = "0xA1D9780", VA = "0x18A1DA780", Slot = "22")]
		public void QZFKXASVYKM(RbexImpulseType a, Vector3 b, float c, float d = 8f, float e = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0xA1DA420", Offset = "0xA1D9420", VA = "0x18A1DA420", Slot = "21")]
		public void QKWMHBMXTOR(RbexRotationType a, Vector3 b, float c = 1f / 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0xA1DAF80", Offset = "0xA1D9F80", VA = "0x18A1DAF80", Slot = "23")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void YCGZAVPWGQO(RbexRotationType a, Vector3 b, float c = 7f, float d = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x1A6B1C0", Offset = "0x1A6A1C0", VA = "0x181A6B1C0")]
		private static void BUZGXAVFZVU(Vector3 a, Vector3 b, [Out] Vector3 c, [Out] Vector3 d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0xA1DA6A0", Offset = "0xA1D96A0", VA = "0x18A1DA6A0", Slot = "29")]
		public Vector3 QSJCZUUDSVN(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0xA1D8D70", Offset = "0xA1D7D70", VA = "0x18A1D8D70", Slot = "26")]
		public void GNUDOOUXQAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0xA1D8980", Offset = "0xA1D7980", VA = "0x18A1D8980")]
		private void DQHRVUGNXDF(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0xA1D8B10", Offset = "0xA1D7B10", VA = "0x18A1D8B10")]
		private void EHCAVWHPZMH(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0xA1DAE00", Offset = "0xA1D9E00", VA = "0x18A1DAE00")]
		private Vector3 XKOKWNCTBVC()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0xA1D8F00", Offset = "0xA1D7F00", VA = "0x18A1D8F00")]
		private void GOBTBHJHOZS(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0xA1DB550", Offset = "0xA1DA550", VA = "0x18A1DB550")]
		private Vector3 YSJAWMVYBKU()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0xA1D9FA0", Offset = "0xA1D8FA0", VA = "0x18A1D9FA0")]
		private void QJPGBJXYEZG(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90")]
		private void UBRINKVMLHJ(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90")]
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
