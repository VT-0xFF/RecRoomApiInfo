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
		[Cpp2IlInjected.Address(RVA = "0xAF57C0", Offset = "0xAF47C0", VA = "0x180AF57C0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAF5A50", Offset = "0xAF4A50", VA = "0x180AF5A50")]
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
		[Cpp2IlInjected.Address(RVA = "0x8C51870", Offset = "0x8C50870", VA = "0x188C51870", Slot = "4")]
		public override void BPSMAKIBARY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xAF57C0", Offset = "0xAF47C0", VA = "0x180AF57C0")]
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
		private int[] DGVDDFJHVEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private ServiceBitset XRLFBVIQUFE;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xAD2F30", Offset = "0xAD1F30", VA = "0x180AD2F30", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8647500", Offset = "0x8646500", VA = "0x188647500", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8C69880", Offset = "0x8C68880", VA = "0x188C69880")]
		private void ZASTUGVTQWC(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8C69820", Offset = "0x8C68820", VA = "0x188C69820", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8C69B60", Offset = "0x8C68B60", VA = "0x188C69B60")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[DisallowMultipleComponent]
	public sealed class RigidbodyEx : MonoBehaviour, AHBTVTYSWLG, OLEOLWASEVR, ZGVDXNLKQCF
	{
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static readonly Log BFWRPCHQSUJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private bool UZMAJHCPTUP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private FUYIEYJKYTM EGXHIMNUEPP;

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
		private Transform BBRVWKAXTWT;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal FUYIEYJKYTM DKWRUAPMOZX
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x8C58D40", Offset = "0x8C57D40", VA = "0x188C58D40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private FUYIEYJKYTM VDIVIXNVFJL
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xAD2F30", Offset = "0xAD1F30", VA = "0x180AD2F30", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int OBHQZKBPHVY
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x8C5A4A0", Offset = "0x8C594A0", VA = "0x188C5A4A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RigidbodyEx MRNXKRDESOT
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x8C5A800", Offset = "0x8C59800", VA = "0x188C5A800")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx SYFXSLEPKPV
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x8C5A740", Offset = "0x8C59740", VA = "0x188C5A740")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RigidbodyEx CGKCNLBHYUH
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x8C5B400", Offset = "0x8C5A400", VA = "0x188C5B400")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x8C5C900", Offset = "0x8C5B900", VA = "0x188C5C900")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool DidStart
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x800BF00", Offset = "0x800AF00", VA = "0x18800BF00", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x800C050", Offset = "0x800B050", VA = "0x18800C050")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Transform PBSPRLEJMHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x237D570", Offset = "0x237C570", VA = "0x18237D570", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Transform TNCLXRCSGEQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x237D570", Offset = "0x237C570", VA = "0x18237D570", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Transform CTTVTDXBJHQ
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x237D570", Offset = "0x237C570", VA = "0x18237D570", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public TransformTrackRate VJGGPNQXSZS
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x8C5A500", Offset = "0x8C59500", VA = "0x188C5A500")]
			get
			{
				return default(TransformTrackRate);
			}
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x8C5C0B0", Offset = "0x8C5B0B0", VA = "0x188C5C0B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool KFGBTMRRIIN
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x8C5AB10", Offset = "0x8C59B10", VA = "0x188C5AB10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool NDIPECDBQMZ
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x8C5A620", Offset = "0x8C59620", VA = "0x188C5A620")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public IBLTTUOKYXC FDYPGTDTTCF
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x8C5AA50", Offset = "0x8C59A50", VA = "0x188C5AA50")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x8C5C270", Offset = "0x8C5B270", VA = "0x188C5C270")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public WOMIOHSHOXB OYMYIKHDGOA
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x8C5A9F0", Offset = "0x8C599F0", VA = "0x188C5A9F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x8C5C200", Offset = "0x8C5B200", VA = "0x188C5C200")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool OGSEEKMKHPQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x8C5A940", Offset = "0x8C59940", VA = "0x188C5A940")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Rigidbody JVMXVKOVXML
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x8C5A9A0", Offset = "0x8C599A0", VA = "0x188C5A9A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool TIVOZGLXMLQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x8C5A680", Offset = "0x8C59680", VA = "0x188C5A680")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x8C5C120", Offset = "0x8C5B120", VA = "0x188C5C120")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool YYNRCIJGQNN
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x176A5A0", Offset = "0x17695A0", VA = "0x18176A5A0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float RFAERVFGTGT
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x8C5B3A0", Offset = "0x8C5A3A0", VA = "0x188C5B3A0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float LPHWJFTMDZC
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x8C5B340", Offset = "0x8C5A340", VA = "0x188C5B340")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x8C5C890", Offset = "0x8C5B890", VA = "0x188C5C890")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public float YEPOCVSMHVH
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x8C5AD70", Offset = "0x8C59D70", VA = "0x188C5AD70")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x8C5C510", Offset = "0x8C5B510", VA = "0x188C5C510")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public float PETKNARFPAV
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x8C5AB70", Offset = "0x8C59B70", VA = "0x188C5AB70")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x8C5C2E0", Offset = "0x8C5B2E0", VA = "0x188C5C2E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public bool JTIRCNECTXS
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x8C5B950", Offset = "0x8C5A950", VA = "0x188C5B950")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x8C5CE40", Offset = "0x8C5BE40", VA = "0x188C5CE40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Vector3 NQCGURYIEHQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x8C5B120", Offset = "0x8C5A120", VA = "0x188C5B120")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x8C5C660", Offset = "0x8C5B660", VA = "0x188C5C660")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public Vector3 NJIXZKFHRDH
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x8C5BA90", Offset = "0x8C5AA90", VA = "0x188C5BA90")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public CollisionDetectionMode YKYHDIERYOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x8C5ACB0", Offset = "0x8C59CB0", VA = "0x188C5ACB0")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x8C5C430", Offset = "0x8C5B430", VA = "0x188C5C430")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public float YZURPXCJGPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x8C5A6E0", Offset = "0x8C596E0", VA = "0x188C5A6E0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x8C5C190", Offset = "0x8C5B190", VA = "0x188C5C190")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public RigidbodyConstraints KCFIWUVCKWJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x8C5AD10", Offset = "0x8C59D10", VA = "0x188C5AD10")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x8C5C4A0", Offset = "0x8C5B4A0", VA = "0x188C5C4A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public Vector3 AWDCRCDNIMX
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x8C5B4C0", Offset = "0x8C5A4C0", VA = "0x188C5B4C0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public Vector3 BNQGJUVLVHT
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x8C5B4C0", Offset = "0x8C5A4C0", VA = "0x188C5B4C0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x8C5CC20", Offset = "0x8C5BC20", VA = "0x188C5CC20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public float DCAUIAUNGHS
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x8C5B200", Offset = "0x8C5A200", VA = "0x188C5B200")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x8C5C740", Offset = "0x8C5B740", VA = "0x188C5C740")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public float UZMCIKQAQWJ
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x8C5B8F0", Offset = "0x8C5A8F0", VA = "0x188C5B8F0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x8C5CDD0", Offset = "0x8C5BDD0", VA = "0x188C5CDD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Quaternion XOYWVBHQYBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x8C5B5A0", Offset = "0x8C5A5A0", VA = "0x188C5B5A0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x8C5C9A0", Offset = "0x8C5B9A0", VA = "0x188C5C9A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Quaternion JYWDFTQQFQU
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x8C5B820", Offset = "0x8C5A820", VA = "0x188C5B820")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x8C5CD00", Offset = "0x8C5BD00", VA = "0x188C5CD00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector3 GAFSIHCAADI
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x8C5B670", Offset = "0x8C5A670", VA = "0x188C5B670")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x8C5CA70", Offset = "0x8C5BA70", VA = "0x188C5CA70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Quaternion XXSUIGNLRHR
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x8C5B750", Offset = "0x8C5A750", VA = "0x188C5B750")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x8C5CB50", Offset = "0x8C5BB50", VA = "0x188C5CB50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 IYYISIGJXUE
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x8C5B9B0", Offset = "0x8C5A9B0", VA = "0x188C5B9B0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x8C5CEB0", Offset = "0x8C5BEB0", VA = "0x188C5CEB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 UOODXFZUZLT
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x8C5B260", Offset = "0x8C5A260", VA = "0x188C5B260")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x8C5C7B0", Offset = "0x8C5B7B0", VA = "0x188C5C7B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector3 CZEJMCUDXMQ
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x8C5ABD0", Offset = "0x8C59BD0", VA = "0x188C5ABD0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x8C5C350", Offset = "0x8C5B350", VA = "0x188C5C350")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector3 AKMELODNQHR
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x8C5B040", Offset = "0x8C5A040", VA = "0x188C5B040")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x8C5C580", Offset = "0x8C5B580", VA = "0x188C5C580")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector3 DVZMIZOLQDY
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x8C5AF00", Offset = "0x8C59F00", VA = "0x188C5AF00")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Quaternion QKNQLTMXBYY
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x8C5AE30", Offset = "0x8C59E30", VA = "0x188C5AE30")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public Vector3 UJODXJFHOUI
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x8C5BC50", Offset = "0x8C5AC50", VA = "0x188C5BC50")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public Vector3 ZOCWHOZLBZO
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x8C5BB70", Offset = "0x8C5AB70", VA = "0x188C5BB70")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool YIAQVJIEJSU
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x8C5AFE0", Offset = "0x8C59FE0", VA = "0x188C5AFE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool KXZFDBAIBIR
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x8C5AAB0", Offset = "0x8C59AB0", VA = "0x188C5AAB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool OFWQFULTOVC
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x8C5A5C0", Offset = "0x8C595C0", VA = "0x188C5A5C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool OHKESVAALHZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x8C5A560", Offset = "0x8C59560", VA = "0x188C5A560")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool EKIUAVUGXNQ
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x8C5A440", Offset = "0x8C59440", VA = "0x188C5A440")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public bool DDBWEBYYWQV
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x8C5ADD0", Offset = "0x8C59DD0", VA = "0x188C5ADD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool PGQOURIKEMH
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xBA0720", Offset = "0xB9F720", VA = "0x180BA0720")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event RbexParentChangeAction IZSIWPKYLWH
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x8C5A360", Offset = "0x8C59360", VA = "0x188C5A360")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x8C5BFD0", Offset = "0x8C5AFD0", VA = "0x188C5BFD0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event RbexAction IZLTKLKAQIT
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x8C5A0D0", Offset = "0x8C590D0", VA = "0x188C5A0D0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x8C5BD30", Offset = "0x8C5AD30", VA = "0x188C5BD30")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event RbexAction BDCMNNALPYZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x8C5A130", Offset = "0x8C59130", VA = "0x188C5A130")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x8C5BDA0", Offset = "0x8C5ADA0", VA = "0x188C5BDA0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event RbexAction RLTVXSDWPXN
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x8C5A280", Offset = "0x8C59280", VA = "0x188C5A280")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x8C5BEF0", Offset = "0x8C5AEF0", VA = "0x188C5BEF0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<UpdateLOD, UpdateLOD> HQKBSYHLJCN
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x8C5A210", Offset = "0x8C59210", VA = "0x188C5A210")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x8C5BE80", Offset = "0x8C5AE80", VA = "0x188C5BE80")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event RbexAction VIOCEPHLTSI
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x8C5A2F0", Offset = "0x8C592F0", VA = "0x188C5A2F0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x8C5BF60", Offset = "0x8C5AF60", VA = "0x188C5BF60")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event RbexAction TQEAALABSUS
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x8C5A3D0", Offset = "0x8C593D0", VA = "0x188C5A3D0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x8C5C040", Offset = "0x8C5B040", VA = "0x188C5C040")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event RbexAction BDKAEFTTZJL
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x8C5A1A0", Offset = "0x8C591A0", VA = "0x188C5A1A0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x8C5BE10", Offset = "0x8C5AE10", VA = "0x188C5BE10")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xACDA30", Offset = "0xACCA30", VA = "0x180ACDA30", Slot = "8")]
		private void IVYDXJNVBEP(FUYIEYJKYTM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8C58CB0", Offset = "0x8C57CB0", VA = "0x188C58CB0", Slot = "9")]
		public RigidbodyExData GetData()
		{
			return default(RigidbodyExData);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8C57AA0", Offset = "0x8C56AA0", VA = "0x188C57AA0")]
		internal void AWWUDLPAUTU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8C59DF0", Offset = "0x8C58DF0", VA = "0x188C59DF0")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public void TestOverrideUnityRigidbody(Rigidbody rb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8C58A00", Offset = "0x8C57A00", VA = "0x188C58A00")]
		public AHBTVTYSWLG GetChild(int index)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x8C59AB0", Offset = "0x8C58AB0", VA = "0x188C59AB0")]
		public void SetInertiaTensor((Quaternion rot, Vector3 moments) tensor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x8C584E0", Offset = "0x8C574E0", VA = "0x188C584E0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x8C59D40", Offset = "0x8C58D40", VA = "0x188C59D40")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8C58D40", Offset = "0x8C57D40", VA = "0x188C58D40")]
		private FUYIEYJKYTM HCHHSFLIYGX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8C58880", Offset = "0x8C57880", VA = "0x188C58880")]
		private void GRLRHMOCTOZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8C59280", Offset = "0x8C58280", VA = "0x188C59280")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x8C591C0", Offset = "0x8C581C0", VA = "0x188C591C0")]
		public void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x8C57AA0", Offset = "0x8C56AA0", VA = "0x188C57AA0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8C59220", Offset = "0x8C58220", VA = "0x188C59220")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8C592E0", Offset = "0x8C582E0", VA = "0x188C592E0")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8C57B30", Offset = "0x8C56B30", VA = "0x188C57B30")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x8C59340", Offset = "0x8C58340", VA = "0x188C59340")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8C58820", Offset = "0x8C57820", VA = "0x188C58820")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x8C59160", Offset = "0x8C58160", VA = "0x188C59160")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x8C59C10", Offset = "0x8C58C10", VA = "0x188C59C10")]
		public void SetParent(RigidbodyEx value, bool isPhysicallyDetachedOnly = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x8C59650", Offset = "0x8C58650", VA = "0x188C59650")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8C58DF0", Offset = "0x8C57DF0", VA = "0x188C58DF0")]
		public bool IsRigidbodyAncestor(RigidbodyEx possibleAncestor)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8C58EF0", Offset = "0x8C57EF0", VA = "0x188C58EF0")]
		public bool IsRigidbodyDescendant(RigidbodyEx possibleDescendant)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8C57DA0", Offset = "0x8C56DA0", VA = "0x188C57DA0")]
		public void AddInterpolationRestriction(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8C593B0", Offset = "0x8C583B0", VA = "0x188C593B0")]
		public void RemoveInterpolationRestriction(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x8C57E10", Offset = "0x8C56E10", VA = "0x188C57E10")]
		public void AddKinematic(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x8C59420", Offset = "0x8C58420", VA = "0x188C59420")]
		public void RemoveKinematic(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x8C59B90", Offset = "0x8C58B90", VA = "0x188C59B90")]
		public void SetKinematic(object token, bool setKinematic)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x8C599B0", Offset = "0x8C589B0", VA = "0x188C599B0")]
		public void SetDiscontinuousPositionAndRotation(Vector3 newPosition, Quaternion newRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x8C598B0", Offset = "0x8C588B0", VA = "0x188C598B0")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 newLocalPosition, Quaternion newLocalRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x8C58BA0", Offset = "0x8C57BA0", VA = "0x188C58BA0")]
		public Vector3 GetConstrainedVelocity(Vector3 velocity)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x8C58A90", Offset = "0x8C57A90", VA = "0x188C58A90")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 angularVelocity)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8C57CB0", Offset = "0x8C56CB0", VA = "0x188C57CB0")]
		public void AddForce(Vector3 force, ForceMode forceMode = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x8C57BA0", Offset = "0x8C56BA0", VA = "0x188C57BA0")]
		public void AddForceAtPosition(Vector3 force, Vector3 position, ForceMode forceMode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8C57FE0", Offset = "0x8C56FE0", VA = "0x188C57FE0")]
		public void AddTorque(Vector3 torque, ForceMode forceMode = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x8C57E80", Offset = "0x8C56E80", VA = "0x188C57E80")]
		public void AddRelativeTorque(Vector3 torque, ForceMode forceMode = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8C59ED0", Offset = "0x8C58ED0", VA = "0x188C59ED0")]
		public Vector3 WorldToLocalVelocity(Vector3 worldVelocity)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8C59050", Offset = "0x8C58050", VA = "0x188C59050")]
		public Vector3 LocalToWorldVelocity(Vector3 localVelocity)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8C587C0", Offset = "0x8C577C0", VA = "0x188C587C0")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8C58760", Offset = "0x8C57760", VA = "0x188C58760")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8C58700", Offset = "0x8C57700", VA = "0x188C58700")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8C586A0", Offset = "0x8C576A0", VA = "0x188C586A0")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x8C597B0", Offset = "0x8C587B0", VA = "0x188C597B0")]
		public void ResetVelocityWorldSpace(Vector3 worldLinearVelocity, Vector3 worldAngularVelocity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x8C596B0", Offset = "0x8C586B0", VA = "0x188C596B0")]
		public void ResetVelocityLocalSpace(Vector3 localLinearVelocity, Vector3 localAngularVelocity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x8C59570", Offset = "0x8C58570", VA = "0x188C59570")]
		public void ResetLinearVelocityLocalSpace(Vector3 localLinearVelocity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x8C59D50", Offset = "0x8C58D50", VA = "0x188C59D50")]
		public bool SweepTest(Vector3 direction, [Out] RaycastHit hitInfo, float maxDistance)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x8C58FF0", Offset = "0x8C57FF0", VA = "0x188C58FF0")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x8C59CE0", Offset = "0x8C58CE0", VA = "0x188C59CE0")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x8C59E70", Offset = "0x8C58E70", VA = "0x188C59E70")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x8C57F70", Offset = "0x8C56F70", VA = "0x188C57F70")]
		public void AddShouldHaveUnityRigidbodyToken(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x8C59490", Offset = "0x8C58490", VA = "0x188C59490")]
		public void RemoveShouldHaveUnityRigidbodyToken(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x8C58370", Offset = "0x8C57370", VA = "0x188C58370")]
		public void ApplyForceVelocityChange(RbexImpulseType impulseType, Vector3 impulseDirection, float impulseSpeed, float impulseDirectionMaxSpeed = 8f, float impulseReflectiveRestitution = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x8C58270", Offset = "0x8C57270", VA = "0x188C58270")]
		public void ApplyAngularVelocityChange(RbexRotationType rotationType, Vector3 newAngularVelocity, float maxAngularSpeed = 1f / 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x8C58430", Offset = "0x8C57430", VA = "0x188C58430")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void ApplyTorqueAngularVelocityChangeDeprecated(RbexRotationType rotationType, Vector3 rotation, float maxSpeed = 7f, float multiplyingFactor = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x8C581A0", Offset = "0x8C571A0", VA = "0x188C581A0")]
		public bool AllowedScaleChange(float scaleFactor)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x8C580D0", Offset = "0x8C570D0", VA = "0x188C580D0")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx parentOverride, object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x8C59500", Offset = "0x8C58500", VA = "0x188C59500")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x8C59E60", Offset = "0x8C58E60", VA = "0x188C59E60", Slot = "13")]
		private void VPZYQKHLYXO(LTEGTZEKNTU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x8C5A060", Offset = "0x8C59060", VA = "0x188C5A060")]
		public RigidbodyEx()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x1299010", Offset = "0x1298010", VA = "0x181299010", Slot = "4")]
		private GameObject CBYWLKCHMLV()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0xAF83D0", Offset = "0xAF73D0", VA = "0x180AF83D0", Slot = "10")]
		private bool MYJWFGSQJIY()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	internal static class PGGVNRIAWGB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x8C543C0", Offset = "0x8C533C0", VA = "0x188C543C0")]
		public static FUYIEYJKYTM DKWRUAPMOZX(this RigidbodyEx a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[RegisterService(typeof(ILREYZAYNJV), new string[] { })]
	public class RigidbodyExManager : ILREYZAYNJV, AXDTJKLCJPD
	{
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static readonly Log HRODLTCIOIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private UWUJMCNAHKM FPQJJVNTAPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private FIMFBEIQTMD GTQXXAHUQXN;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public UWUJMCNAHKM ASHWMHVKKQR
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xACF720", Offset = "0xACE720", VA = "0x180ACF720", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public FIMFBEIQTMD RQKYQHOHYSH
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xACF7F0", Offset = "0xACE7F0", VA = "0x180ACF7F0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x8C579B0", Offset = "0x8C569B0", VA = "0x188C579B0", Slot = "7")]
		public void InitReferences(MEMEGXEKDDM services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x8C57880", Offset = "0x8C56880", VA = "0x188C57880", Slot = "6")]
		public FUYIEYJKYTM IMXHWTPVEFX(RigidbodyEx a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		public RigidbodyExManager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class PhysicsManager : SingletonMonoBehaviour<PhysicsManager>
	{
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static ZUUFDARDSJN UpdateAfterFixedUpdateRan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private int ZMXAEXNSUVR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private int EPCNWJDYMAT;

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x8C54430", Offset = "0x8C53430", VA = "0x188C54430")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x8C544B0", Offset = "0x8C534B0", VA = "0x188C544B0")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x8C54450", Offset = "0x8C53450", VA = "0x188C54450")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string message, [Optional] UnityEngine.Object context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string message, [Optional] UnityEngine.Object context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x8C545A0", Offset = "0x8C535A0", VA = "0x188C545A0")]
		public PhysicsManager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public static class OSMGFWXTPRN
	{
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		private class KULKAMCCTEH : IBLTTUOKYXC, IDisposable
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "7")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0xADB4B0", Offset = "0xADA4B0", VA = "0x180ADB4B0", Slot = "4")]
			public Vector3 JRWTUTHLBCC()
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0xADB4B0", Offset = "0xADA4B0", VA = "0x180ADB4B0", Slot = "5")]
			public Vector3 SRKOCNNUBJD()
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0xAE6390", Offset = "0xAE5390", VA = "0x180AE6390", Slot = "6")]
			public bool WLKRYKHWSAY(float a, float b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			public KULKAMCCTEH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public static IBLTTUOKYXC YJEQJXQLXBY
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x8C54300", Offset = "0x8C53300", VA = "0x188C54300")]
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
	public interface DBJPTXDNTEI
	{
		[Cpp2IlInjected.Token(Token = "0x17000039")]
		CollisionDetectionMode FBJGEILMVLB
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
		void ATTJZYAHFYJ(bool a);

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void AECPFXQLJEM(bool a);

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void SQRKTFILJWO(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool LIWPYJDBZHH(Vector3 a, [Out] RaycastHit b, float c);
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public interface SEPTSVZWEFP : IDisposable, APCQRKUFDVH
	{
		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		TransformTrackRate VJGGPNQXSZS
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		event Action<UpdateLOD, UpdateLOD> HQKBSYHLJCN;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void Awake();
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[ServiceLifetime(Lifetime.Application)]
	public interface FIMFBEIQTMD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		PTXSDCEKRJQ ADSZWSJQIOW(FUYIEYJKYTM a);

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		FXTQWLZMIBS JUSMMYSXVLO(FUYIEYJKYTM a);

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		VTWKHYUGUWB BZUNQQLNBUV(FUYIEYJKYTM a);

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		NZBWOPNKWOG JJEFHVJFVDE(FUYIEYJKYTM a);

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "4")]
		ZJNDDWRIIMG TVDTEJPVEVY(FUYIEYJKYTM a);

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "5")]
		SEPTSVZWEFP FZEGLHDHPSN(FUYIEYJKYTM a);

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "6")]
		GYNXKDBSODG VEVFLKRSQDK(FUYIEYJKYTM a);

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "7")]
		RUCOGLQCYDY YIHESHKXVHI(FUYIEYJKYTM a);

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "8")]
		DBJPTXDNTEI FDUFDPZCSZG(FUYIEYJKYTM a);

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "9")]
		AGBXMHTFSAT VMYFHJOYJJJ(FUYIEYJKYTM a);

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "10")]
		AEQXTEPJFYH EESYFGHYADB(FUYIEYJKYTM a, [In] RigidbodyExData data);

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "11")]
		APOKDZGZGNL PHTPNFALWMZ(FUYIEYJKYTM a, [In] RigidbodyExData data);

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "12")]
		IILMGYJKVNV RNXMLAVPMTR(FUYIEYJKYTM a, [In] RigidbodyExData data);

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "13")]
		WRARQCERPVP VEWIQDYNOLL(FUYIEYJKYTM a, [In] RigidbodyExData data);

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "14")]
		PBYHJXVWESJ DFKHYEDIOBP(FUYIEYJKYTM a, [In] RigidbodyExData data);

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "15")]
		FUYIEYJKYTM IMXHWTPVEFX(RigidbodyEx a, RigidbodyExData b, ILREYZAYNJV c);
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface RUCOGLQCYDY
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void FMALXWSEXRT(Vector3 a, ForceMode b = ForceMode.Force);

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void ACBBLCKPGBN(Vector3 a, Vector3 b, ForceMode c);

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void ZJWOXSISKCM(Vector3 a, ForceMode b = ForceMode.Force);

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void IDXWNMEBWIY(Vector3 a, ForceMode b = ForceMode.Force);
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface AGBXMHTFSAT
	{
		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		bool YUXMEOIJDUI
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
		void SQRKTFILJWO(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void GQOHVARTNSP(Rigidbody a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public interface PTXSDCEKRJQ : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		IReadOnlyList<FUYIEYJKYTM> QSEZLIHKKDV
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(Slot = "18")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		FUYIEYJKYTM SYFXSLEPKPV
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(Slot = "19")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		FUYIEYJKYTM YODRVKGPXDV
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(Slot = "20")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(Slot = "21")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		event RbexAction IZLTKLKAQIT;

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		event RbexAction BDCMNNALPYZ;

		[Cpp2IlInjected.Token(Token = "0x1400000C")]
		event RbexParentChangeAction RFMRJXTICHH;

		[Cpp2IlInjected.Token(Token = "0x1400000D")]
		event Action QKDGLFHPCOM;

		[Cpp2IlInjected.Token(Token = "0x1400000E")]
		event Action RDELHNGLQDD;

		[Cpp2IlInjected.Token(Token = "0x1400000F")]
		event Action<FUYIEYJKYTM> QVQICOWEDZG;

		[Cpp2IlInjected.Token(Token = "0x14000010")]
		event Action<FUYIEYJKYTM> FRVDYAKLKOH;

		[Cpp2IlInjected.Token(Token = "0x14000011")]
		event Action CFPLQRCINTO;

		[Cpp2IlInjected.Token(Token = "0x14000012")]
		event Action<FUYIEYJKYTM> WROHLLZLMSV;

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "22")]
		void SetParent(FUYIEYJKYTM newParent, bool isPhysicallyDetachedOnly = false);
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public interface VTWKHYUGUWB
	{
		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		Vector3 WXFFZKCKKEQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		Vector3 KSJCZXLGDUQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void GJDIVXFKMYS(FUYIEYJKYTM a, object b);

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void ENSFHXQSBQH(object a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public interface WRARQCERPVP
	{
		[Cpp2IlInjected.Token(Token = "0x17000041")]
		Vector3 MRFBCJVIBRI
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		Vector3 ONUVYMNJDSJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		float HMPRXVXBKHF
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		float LKXKKPGMOTC
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(Slot = "7")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		Vector3 JNUPSQBWKDI
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		Quaternion VVSCJNHLAWA
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000013")]
		event RbexAction STBRGTPQBZH;

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void BCNBYCUWGQA((Quaternion rot, Vector3 moments) tensor);

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(Slot = "11")]
		void FZARYHWTSVV();

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void NBYZDYHITYY();

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(Slot = "13")]
		void HXJRSISDISO();

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void SQRKTFILJWO(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void GQOHVARTNSP(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void OnDrawGizmosSelected();
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public interface IILMGYJKVNV
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Awake();

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void KPMYUFQUIJK(object a);

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void BAYJUDCCIDR(object a);

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void BONFJMJIAMX(FUYIEYJKYTM a);

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void UFGHJOSILJY(FUYIEYJKYTM a);

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void YDQVBAJLJNB();
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public interface GYNXKDBSODG
	{
		[Cpp2IlInjected.Token(Token = "0x17000047")]
		bool UEOMVOEOZUQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000014")]
		event RbexAction UPVPJIIAMNG;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void PZILTGHCYTB(object a);

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void AZNVJWZBCUU(object a);

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void RDLECXPDOOC(object a, bool b);

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void SQRKTFILJWO(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void GQOHVARTNSP(Rigidbody a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface APOKDZGZGNL : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000048")]
		bool KFGBTMRRIIN
		{
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		bool NDIPECDBQMZ
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000015")]
		event RbexAction QEVJOZFEHSW;

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void Awake();

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void NOQFFSAIRSR(FUYIEYJKYTM a);

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void JFBWOMIYXSB(FUYIEYJKYTM a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface PBYHJXVWESJ
	{
		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		bool TIVOZGLXMLQ
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		bool AZUZLIDXFAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		RigidbodyConstraints TQIDUCJNYGZ
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
		void SQRKTFILJWO(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void GQOHVARTNSP(Rigidbody a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface NZBWOPNKWOG
	{
		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		float MMJEIGMGBDD
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		float CBWPJIMZILD
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
		void SQRKTFILJWO(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void GQOHVARTNSP(Rigidbody a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public interface ZJNDDWRIIMG
	{
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		static bool AZJLIKKCUMO;

		[Cpp2IlInjected.Token(Token = "0x14000016")]
		event RbexAction EJOBFLRUPOG;

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void Awake();

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool EGHVZOWSDMO();

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void JBSSSPKXLDK();

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void Sleep();

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool FSPHXUZZUNI();

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool VSDIMQWJDOP();

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void IWEJGMNPHOZ(bool a);

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void EYEJSQGVYXE();
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public interface AEQXTEPJFYH
	{
		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		Rigidbody JVMXVKOVXML
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		bool KBEJXXOVYQG
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
		void VMXUXBGADVC(object a);

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void LKMJORGOFMD(object a);

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void TDLASUGLSBI();
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public interface FXTQWLZMIBS : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000051")]
		IBLTTUOKYXC FDYPGTDTTCF
		{
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		WOMIOHSHOXB OYMYIKHDGOA
		{
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		Vector3 WONQMRQGLQW
		{
			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(Slot = "5")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		Vector3 BQCPGSTLOOZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(Slot = "7")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		Vector3 UKOIJUGVDGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(Slot = "9")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		Vector3 AZRMBKJUCIX
		{
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(Slot = "11")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		float YZURPXCJGPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(Slot = "13")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		bool OGSEEKMKHPQ
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
		void ORWUGYWXRFS(object a);

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(Slot = "17")]
		void MTPGKHLFXNQ(RbexRotationType a, Vector3 b, float c = 1f / 0f);

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(Slot = "18")]
		void GGGGADFQKIH(RbexImpulseType a, Vector3 b, float c, float d = 8f, float e = 1f);

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(Slot = "19")]
		void ZFZTVIESIZL(RbexRotationType a, Vector3 b, float c = 7f, float d = 1f);

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(Slot = "20")]
		void MWTPDQNNZER();

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(Slot = "21")]
		void IUKBCDQIPOO();

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(Slot = "22")]
		void HCNWWIHBBYX();

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(Slot = "23")]
		void RZKURQWAUGP();

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(Slot = "24")]
		void SQRKTFILJWO(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(Slot = "25")]
		Vector3 TZGOJLBMHEE(Vector3 a);

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(Slot = "26")]
		void OBLWSIENCCD(object a);

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(Slot = "27")]
		void VQJCAXUEGAX(Vector3 a);

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(Slot = "28")]
		void PXOLKQPCRQK(Vector3 a, Vector3 b);

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(Slot = "29")]
		void HPBYHBEIFKH(Vector3 a, Vector3 b);

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(Slot = "30")]
		Vector3 WFXCUACKKWC(Vector3 a);

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(Slot = "31")]
		Vector3 GHQCCOHSZMM(Vector3 a);
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[ServiceLifetime(Lifetime.Application)]
	public interface UWUJMCNAHKM
	{
		[Cpp2IlInjected.Token(Token = "0x17000059")]
		bool QYZBXHAQRCL
		{
			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void IVVIWIOSDVP(string a);

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void SXCJIJZRRJW(RigidbodyEx a, Action b);

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		HNGTMTQNYBC UWWGKPSBUFB(int a);

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void LOORKRXKODD(Vector3 a, float b, Color c);
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[ServiceLifetime(Lifetime.Application)]
	public interface ILREYZAYNJV
	{
		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		UWUJMCNAHKM ASHWMHVKKQR
		{
			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		FIMFBEIQTMD RQKYQHOHYSH
		{
			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(Slot = "2")]
		FUYIEYJKYTM IMXHWTPVEFX(RigidbodyEx a);
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class THJLXNQARFP : FUYIEYJKYTM, IDisposable, IATIOMOQYXP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		internal readonly ILREYZAYNJV KJBHTHEXJCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		internal PTXSDCEKRJQ DHKPGYDLVNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		internal IILMGYJKVNV ELPMLUDGZKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		internal APOKDZGZGNL QONTVCNNCWN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		internal FXTQWLZMIBS IYYISIGJXUE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		internal VTWKHYUGUWB FDBMVCEVZOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		internal WRARQCERPVP BBONVWGFAHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		internal NZBWOPNKWOG RULMRPTWWPY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		internal AGBXMHTFSAT ZFPVMRXKKPR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		internal ZJNDDWRIIMG EYVNLPIEYJQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		internal SEPTSVZWEFP ZQDQYRXQUPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		internal GYNXKDBSODG DZDFUDZKJKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		internal RUCOGLQCYDY WZWDVXIMOFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		internal PBYHJXVWESJ XBGXQEGNCCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		internal AEQXTEPJFYH SQFEDHVWJVB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		internal DBJPTXDNTEI XJVDDOFFBPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		internal IDisposable GAGXBKXCCRF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private bool ECJRQVSVKGH;

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public ObjectLocalId NKHOCMYNMMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0xACBA90", Offset = "0xACAA90", VA = "0x180ACBA90", Slot = "22")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public AHBTVTYSWLG FMVYXTWCAPN
		{
			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0xB6B480", Offset = "0xB6A480", VA = "0x180B6B480", Slot = "24")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0xC275A0", Offset = "0xC265A0", VA = "0x180C275A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public GameObject WAWTMEODYUS
		{
			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0xAD3F00", Offset = "0xAD2F00", VA = "0x180AD3F00", Slot = "25")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0xAD3F60", Offset = "0xAD2F60", VA = "0x180AD3F60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public Transform TAMVZOUDDLX
		{
			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0xC75620", Offset = "0xC74620", VA = "0x180C75620", Slot = "26")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0xD83CD0", Offset = "0xD82CD0", VA = "0x180D83CD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public Rigidbody JVMXVKOVXML
		{
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x8C621E0", Offset = "0x8C611E0", VA = "0x188C621E0", Slot = "23")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public FUYIEYJKYTM YODRVKGPXDV
		{
			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x8C64A90", Offset = "0x8C63A90", VA = "0x188C64A90", Slot = "27")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x8C62440", Offset = "0x8C61440", VA = "0x188C62440", Slot = "28")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public int OBHQZKBPHVY
		{
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x8C63400", Offset = "0x8C62400", VA = "0x188C63400", Slot = "31")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public FUYIEYJKYTM SYFXSLEPKPV
		{
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x8C61690", Offset = "0x8C60690", VA = "0x188C61690", Slot = "29")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public bool YJTPNVLEYTP
		{
			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x8C63CE0", Offset = "0x8C62CE0", VA = "0x188C63CE0", Slot = "32")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public bool KFGBTMRRIIN
		{
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x8C65FF0", Offset = "0x8C64FF0", VA = "0x188C65FF0", Slot = "33")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public bool NDIPECDBQMZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x8C66180", Offset = "0x8C65180", VA = "0x188C66180", Slot = "34")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public IBLTTUOKYXC FDYPGTDTTCF
		{
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x8C61CC0", Offset = "0x8C60CC0", VA = "0x188C61CC0", Slot = "35")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x8C60B20", Offset = "0x8C5FB20", VA = "0x188C60B20", Slot = "36")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public WOMIOHSHOXB OYMYIKHDGOA
		{
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x8C639A0", Offset = "0x8C629A0", VA = "0x188C639A0", Slot = "37")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x8C63470", Offset = "0x8C62470", VA = "0x188C63470", Slot = "38")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public float YZURPXCJGPO
		{
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x8C659E0", Offset = "0x8C649E0", VA = "0x188C659E0", Slot = "39")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x8C65840", Offset = "0x8C64840", VA = "0x188C65840", Slot = "40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public Vector3 BQCPGSTLOOZ
		{
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x8C62630", Offset = "0x8C61630", VA = "0x188C62630", Slot = "41")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x8C61360", Offset = "0x8C60360", VA = "0x188C61360", Slot = "42")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public Vector3 AZRMBKJUCIX
		{
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x8C62F60", Offset = "0x8C61F60", VA = "0x188C62F60", Slot = "43")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x8C62550", Offset = "0x8C61550", VA = "0x188C62550", Slot = "44")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public Vector3 WONQMRQGLQW
		{
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x8C60610", Offset = "0x8C5F610", VA = "0x188C60610", Slot = "45")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x8C61BE0", Offset = "0x8C60BE0", VA = "0x188C61BE0", Slot = "46")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public Vector3 UKOIJUGVDGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x8C61F20", Offset = "0x8C60F20", VA = "0x188C61F20", Slot = "47")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x8C63AD0", Offset = "0x8C62AD0", VA = "0x188C63AD0", Slot = "48")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public bool OFWQFULTOVC
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x8C662A0", Offset = "0x8C652A0", VA = "0x188C662A0", Slot = "49")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public bool OHKESVAALHZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x8C622F0", Offset = "0x8C612F0", VA = "0x188C622F0", Slot = "50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public bool EKIUAVUGXNQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x8C66580", Offset = "0x8C65580", VA = "0x188C66580", Slot = "51")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public bool OGSEEKMKHPQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x8C60FC0", Offset = "0x8C5FFC0", VA = "0x188C60FC0", Slot = "52")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public Vector3 WXFFZKCKKEQ
		{
			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x8C65190", Offset = "0x8C64190", VA = "0x188C65190", Slot = "53")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public Vector3 KSJCZXLGDUQ
		{
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x8C66040", Offset = "0x8C65040", VA = "0x188C66040", Slot = "54")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public Vector3 MRFBCJVIBRI
		{
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x8C602B0", Offset = "0x8C5F2B0", VA = "0x188C602B0", Slot = "55")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x8C63540", Offset = "0x8C62540", VA = "0x188C63540", Slot = "56")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public Vector3 ONUVYMNJDSJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x8C639F0", Offset = "0x8C629F0", VA = "0x188C639F0", Slot = "57")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public float HMPRXVXBKHF
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x8C66450", Offset = "0x8C65450", VA = "0x188C66450", Slot = "58")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public float LKXKKPGMOTC
		{
			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x8C637B0", Offset = "0x8C627B0", VA = "0x188C637B0", Slot = "59")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x8C66120", Offset = "0x8C65120", VA = "0x188C66120", Slot = "60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public Vector3 JNUPSQBWKDI
		{
			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x8C61440", Offset = "0x8C60440", VA = "0x188C61440", Slot = "61")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public Quaternion VVSCJNHLAWA
		{
			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x8C64AE0", Offset = "0x8C63AE0", VA = "0x188C64AE0", Slot = "62")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public float MMJEIGMGBDD
		{
			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x8C62D50", Offset = "0x8C61D50", VA = "0x188C62D50", Slot = "64")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x8C666C0", Offset = "0x8C656C0", VA = "0x188C666C0", Slot = "65")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public float CBWPJIMZILD
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x8C661D0", Offset = "0x8C651D0", VA = "0x188C661D0", Slot = "66")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x8C624A0", Offset = "0x8C614A0", VA = "0x188C624A0", Slot = "67")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public bool YUXMEOIJDUI
		{
			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x8C63D40", Offset = "0x8C62D40", VA = "0x188C63D40", Slot = "68")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x8C62230", Offset = "0x8C61230", VA = "0x188C62230", Slot = "69")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public TransformTrackRate VJGGPNQXSZS
		{
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x8C62F10", Offset = "0x8C61F10", VA = "0x188C62F10", Slot = "70")]
			get
			{
				return default(TransformTrackRate);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x8C630A0", Offset = "0x8C620A0", VA = "0x188C630A0", Slot = "71")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public bool UEOMVOEOZUQ
		{
			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x8C649C0", Offset = "0x8C639C0", VA = "0x188C649C0", Slot = "72")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public Transform CTTVTDXBJHQ
		{
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0xC75620", Offset = "0xC74620", VA = "0x180C75620", Slot = "73")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public Vector3 DNYKYRVERXA
		{
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x8C65080", Offset = "0x8C64080", VA = "0x188C65080", Slot = "74")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x8C61830", Offset = "0x8C60830", VA = "0x188C61830", Slot = "75")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public float DCRKZRKUQGM
		{
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x8C608F0", Offset = "0x8C5F8F0", VA = "0x188C608F0", Slot = "76")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x8C62050", Offset = "0x8C61050", VA = "0x188C62050", Slot = "77")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public float ZSMUVPIFMJJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x8C63530", Offset = "0x8C62530", VA = "0x188C63530", Slot = "78")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x8C620E0", Offset = "0x8C610E0", VA = "0x188C620E0", Slot = "79")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public Quaternion YLJPVGDDFCP
		{
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x8C62DA0", Offset = "0x8C61DA0", VA = "0x188C62DA0", Slot = "80")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x8C636D0", Offset = "0x8C626D0", VA = "0x188C636D0", Slot = "81")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public Vector3 UDVUWYVSFGR
		{
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x8C640A0", Offset = "0x8C630A0", VA = "0x188C640A0", Slot = "82")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x8C62910", Offset = "0x8C61910", VA = "0x188C62910", Slot = "83")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public Quaternion NXUKGCINVQA
		{
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x8C60270", Offset = "0x8C5F270", VA = "0x188C60270", Slot = "84")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x8C64A60", Offset = "0x8C63A60", VA = "0x188C64A60", Slot = "85")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public RigidbodyConstraints TQIDUCJNYGZ
		{
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x8C66350", Offset = "0x8C65350", VA = "0x188C66350", Slot = "86")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x8C65B30", Offset = "0x8C64B30", VA = "0x188C65B30", Slot = "87")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public bool TIVOZGLXMLQ
		{
			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x8C619E0", Offset = "0x8C609E0", VA = "0x188C619E0", Slot = "88")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x8C65730", Offset = "0x8C64730", VA = "0x188C65730", Slot = "89")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public CollisionDetectionMode FBJGEILMVLB
		{
			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x8C65790", Offset = "0x8C64790", VA = "0x188C65790", Slot = "90")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x8C628B0", Offset = "0x8C618B0", VA = "0x188C628B0", Slot = "91")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public bool JTEVPNPYUBI
		{
			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x8C65B90", Offset = "0x8C64B90", VA = "0x188C65B90", Slot = "141")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public bool KXZFDBAIBIR
		{
			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0x8C64F00", Offset = "0x8C63F00", VA = "0x188C64F00", Slot = "92")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000017")]
		public event RbexAction IZLTKLKAQIT
		{
			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x8C63C80", Offset = "0x8C62C80", VA = "0x188C63C80", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x8C640E0", Offset = "0x8C630E0", VA = "0x188C640E0", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000018")]
		public event RbexAction BDCMNNALPYZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x8C62850", Offset = "0x8C61850", VA = "0x188C62850", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x8C61630", Offset = "0x8C60630", VA = "0x188C61630", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000019")]
		public event RbexParentChangeAction RFMRJXTICHH
		{
			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x8C63040", Offset = "0x8C62040", VA = "0x188C63040", Slot = "18")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x8C61B80", Offset = "0x8C60B80", VA = "0x188C61B80", Slot = "19")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001A")]
		public event RbexAction QEVJOZFEHSW
		{
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x8C63EE0", Offset = "0x8C62EE0", VA = "0x188C63EE0", Slot = "8")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x8C65130", Offset = "0x8C64130", VA = "0x188C65130", Slot = "9")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001B")]
		public event RbexAction RLTVXSDWPXN
		{
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x8C60210", Offset = "0x8C5F210", VA = "0x188C60210", Slot = "14")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x8C60F60", Offset = "0x8C5FF60", VA = "0x188C60F60", Slot = "15")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001C")]
		public event RbexAction EJOBFLRUPOG
		{
			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x8C64E50", Offset = "0x8C63E50", VA = "0x188C64E50", Slot = "16")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x8C656D0", Offset = "0x8C646D0", VA = "0x188C656D0", Slot = "17")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001D")]
		public event Action<UpdateLOD, UpdateLOD> HQKBSYHLJCN
		{
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x8C66660", Offset = "0x8C65660", VA = "0x188C66660", Slot = "20")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x8C60F00", Offset = "0x8C5FF00", VA = "0x188C60F00", Slot = "21")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001E")]
		public event RbexAction UPVPJIIAMNG
		{
			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x8C65600", Offset = "0x8C64600", VA = "0x188C65600", Slot = "12")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x8C63280", Offset = "0x8C62280", VA = "0x188C63280", Slot = "13")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001F")]
		public event RbexAction BDKAEFTTZJL
		{
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x8C653A0", Offset = "0x8C643A0", VA = "0x188C653A0", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x8C60A70", Offset = "0x8C5FA70", VA = "0x188C60A70", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x8C66720", Offset = "0x8C65720", VA = "0x188C66720")]
		public THJLXNQARFP(GameObject a, RigidbodyEx b, ILREYZAYNJV c, [In] RigidbodyExData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x8C60C10", Offset = "0x8C5FC10", VA = "0x188C60C10", Slot = "139")]
		protected virtual void CEKWWVMODKL(ILREYZAYNJV a, RigidbodyExData b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x8C616E0", Offset = "0x8C606E0", VA = "0x188C616E0", Slot = "140")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x8C603F0", Offset = "0x8C5F3F0", VA = "0x188C603F0", Slot = "93")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x8C64010", Offset = "0x8C63010", VA = "0x188C64010", Slot = "94")]
		public void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x8C63F60", Offset = "0x8C62F60", VA = "0x188C63F60", Slot = "95")]
		public void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x8C63F40", Offset = "0x8C62F40", VA = "0x188C63F40", Slot = "96")]
		public void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x8C62AD0", Offset = "0x8C61AD0", VA = "0x188C62AD0")]
		private void IWEJGMNPHOZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x8C63100", Offset = "0x8C62100", VA = "0x188C63100")]
		private void LIKATIPVNHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x8C65980", Offset = "0x8C64980", VA = "0x188C65980")]
		private void VSDIMQWJDOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x8C66220", Offset = "0x8C65220", VA = "0x188C66220", Slot = "30")]
		public FUYIEYJKYTM YNCZSYOYZBT(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x8C64BB0", Offset = "0x8C63BB0", VA = "0x188C64BB0", Slot = "98")]
		public void SetParent(FUYIEYJKYTM value, bool isPhysicallyDetachedOnly = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x8C62290", Offset = "0x8C61290", VA = "0x188C62290", Slot = "99")]
		public void HMXWEPWSYFM(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x8C634D0", Offset = "0x8C624D0", VA = "0x188C634D0", Slot = "100")]
		public void MJCUYUBJIJH(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x8C61E20", Offset = "0x8C60E20", VA = "0x188C61E20", Slot = "101")]
		public Vector3 GHQCCOHSZMM(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x8C65A30", Offset = "0x8C64A30", VA = "0x188C65A30", Slot = "102")]
		public Vector3 WFXCUACKKWC(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x8C64A10", Offset = "0x8C63A10", VA = "0x188C64A10", Slot = "103")]
		public void RZKURQWAUGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x8C62A80", Offset = "0x8C61A80", VA = "0x188C62A80", Slot = "104")]
		public void IUKBCDQIPOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x8C63900", Offset = "0x8C62900", VA = "0x188C63900", Slot = "105")]
		public void MWTPDQNNZER()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x8C62350", Offset = "0x8C61350", VA = "0x188C62350", Slot = "106")]
		public void HPBYHBEIFKH(Vector3 a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x8C64140", Offset = "0x8C63140", VA = "0x188C64140", Slot = "107")]
		public void PXOLKQPCRQK(Vector3 a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x8C658A0", Offset = "0x8C648A0", VA = "0x188C658A0", Slot = "108")]
		public void VQJCAXUEGAX(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x8C61D60", Offset = "0x8C60D60", VA = "0x188C61D60", Slot = "109")]
		public void GGGGADFQKIH(RbexImpulseType a, Vector3 b, float c, float d = 8f, float e = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x8C63800", Offset = "0x8C62800", VA = "0x188C63800", Slot = "110")]
		public void MTPGKHLFXNQ(RbexRotationType a, Vector3 b, float c = 1f / 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x8C663A0", Offset = "0x8C653A0", VA = "0x188C663A0", Slot = "111")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void ZFZTVIESIZL(RbexRotationType a, Vector3 b, float c = 7f, float d = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x8C65260", Offset = "0x8C64260", VA = "0x188C65260", Slot = "112")]
		public Vector3 TZGOJLBMHEE(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x8C618E0", Offset = "0x8C608E0", VA = "0x188C618E0", Slot = "113")]
		public Vector3 EUQTPDUZRVG(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x8C62000", Offset = "0x8C61000", VA = "0x188C62000", Slot = "114")]
		public void HCNWWIHBBYX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x8C65660", Offset = "0x8C64660", VA = "0x188C65660", Slot = "115")]
		public void UQNMSSKSAMT(FUYIEYJKYTM a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x8C662F0", Offset = "0x8C652F0", VA = "0x188C662F0", Slot = "116")]
		public void YTGTKEONWGA(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x8C60530", Offset = "0x8C5F530", VA = "0x188C60530", Slot = "63")]
		public void BCNBYCUWGQA((Quaternion rot, Vector3 moments) tensor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x8C63950", Offset = "0x8C62950", VA = "0x188C63950", Slot = "117")]
		public void NBYZDYHITYY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x8C61D10", Offset = "0x8C60D10", VA = "0x188C61D10", Slot = "118")]
		public void FZARYHWTSVV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x8C62500", Offset = "0x8C61500", VA = "0x188C62500", Slot = "119")]
		public void HXJRSISDISO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x8C617E0", Offset = "0x8C607E0", VA = "0x188C617E0", Slot = "120")]
		public bool EGHVZOWSDMO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x8C64C20", Offset = "0x8C63C20", VA = "0x188C64C20", Slot = "97")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x8C61A30", Offset = "0x8C60A30", VA = "0x188C61A30", Slot = "121")]
		public void EYEJSQGVYXE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x8C64230", Offset = "0x8C63230", VA = "0x188C64230", Slot = "122")]
		public void PZILTGHCYTB(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x8C60390", Offset = "0x8C5F390", VA = "0x188C60390", Slot = "123")]
		public void AZNVJWZBCUU(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x8C64420", Offset = "0x8C63420", VA = "0x188C64420", Slot = "124")]
		public void RDLECXPDOOC(object a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x8C606F0", Offset = "0x8C5F6F0", VA = "0x188C606F0", Slot = "125")]
		public void BLDFBSBSEQO(Vector3 a, Quaternion b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x8C642F0", Offset = "0x8C632F0", VA = "0x188C642F0", Slot = "126")]
		public void QZMMJJKIPBY(Vector3 a, Quaternion b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x8C64EB0", Offset = "0x8C63EB0", VA = "0x188C64EB0", Slot = "127")]
		public bool TRFWBIVVOQN(float a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x8C64290", Offset = "0x8C63290", VA = "0x188C64290", Slot = "128")]
		public void QVUFCPYVASC(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x8C62710", Offset = "0x8C61710", VA = "0x188C62710", Slot = "129")]
		public void IAJBCREUXLF(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x8C657E0", Offset = "0x8C647E0", VA = "0x188C657E0", Slot = "130")]
		public void VMXUXBGADVC(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x8C63220", Offset = "0x8C62220", VA = "0x188C63220", Slot = "131")]
		public void LKMJORGOFMD(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x8C61AA0", Offset = "0x8C60AA0", VA = "0x188C61AA0", Slot = "132")]
		public void FMALXWSEXRT(Vector3 a, ForceMode b = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x8C60100", Offset = "0x8C5F100", VA = "0x188C60100", Slot = "133")]
		public void ACBBLCKPGBN(Vector3 a, Vector3 b, ForceMode c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x8C664A0", Offset = "0x8C654A0", VA = "0x188C664A0", Slot = "134")]
		public void ZJWOXSISKCM(Vector3 a, ForceMode b = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x8C62770", Offset = "0x8C61770", VA = "0x188C62770", Slot = "135")]
		public void IDXWNMEBWIY(Vector3 a, ForceMode b = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x8C63180", Offset = "0x8C62180", VA = "0x188C63180", Slot = "136")]
		public bool LIWPYJDBZHH(Vector3 a, [Out] RaycastHit b, float c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x8C63FC0", Offset = "0x8C62FC0", VA = "0x188C63FC0", Slot = "137")]
		public void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x8C65360", Offset = "0x8C64360", VA = "0x188C65360", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x8C64490", Offset = "0x8C63490", VA = "0x188C64490")]
		private void RKJISMENNBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x8C61520", Offset = "0x8C60520", VA = "0x188C61520")]
		private void DGRPQPLHTTD(FUYIEYJKYTM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x8C64C70", Offset = "0x8C63C70", VA = "0x188C64C70")]
		private void TFYVWRQLFOW(FUYIEYJKYTM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x8C63620", Offset = "0x8C62620", VA = "0x188C63620")]
		private void MSGOXQQQDTX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x8C62950", Offset = "0x8C61950", VA = "0x188C62950")]
		private void IOXXRIZMPTS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x8C65450", Offset = "0x8C64450", VA = "0x188C65450")]
		private void UJKQUEWHCFA(FUYIEYJKYTM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x8C63BB0", Offset = "0x8C62BB0", VA = "0x188C63BB0")]
		private void NOQFFSAIRSR(FUYIEYJKYTM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x8C62E40", Offset = "0x8C61E40", VA = "0x188C62E40")]
		private void JFBWOMIYXSB(FUYIEYJKYTM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x8C63D90", Offset = "0x8C62D90", VA = "0x188C63D90")]
		private void ODNXTZOOTTK(AHBTVTYSWLG a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x8C64570", Offset = "0x8C63570", VA = "0x188C64570", Slot = "142")]
		protected virtual void RKTPKYGININ(AHBTVTYSWLG a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x8C65CD0", Offset = "0x8C64CD0", VA = "0x188C65CD0")]
		protected void WOWQCRTTTDX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x8C61010", Offset = "0x8C60010", VA = "0x188C61010")]
		protected void CTUGYPBTUFX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x8C632E0", Offset = "0x8C622E0", VA = "0x188C632E0")]
		private void LQYYBDABMRX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x8C60900", Offset = "0x8C5F900", VA = "0x188C60900")]
		private void BQOIRPMHSMM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	internal static class TISCBRZHHDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x8C66890", Offset = "0x8C65890", VA = "0x188C66890")]
		public static FUYIEYJKYTM GVAXASFEHVK(this FUYIEYJKYTM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x8C669A0", Offset = "0x8C659A0", VA = "0x188C669A0")]
		public static bool WJDXCVBYHEL(this FUYIEYJKYTM a, FUYIEYJKYTM b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x8C66A40", Offset = "0x8C65A40", VA = "0x188C66A40")]
		public static bool ZQFFCDPDIUJ(this FUYIEYJKYTM a, FUYIEYJKYTM b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x8C66950", Offset = "0x8C65950", VA = "0x188C66950")]
		public static AHBTVTYSWLG UJSACDPXDJL(this FUYIEYJKYTM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x8C66810", Offset = "0x8C65810", VA = "0x188C66810")]
		public static THJLXNQARFP Base(this FUYIEYJKYTM impl)
		{
			return null;
		}
	}
}
namespace RecRoom.Rbex.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class DQLLKGWDYLG : FIMFBEIQTMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x8C4DFD0", Offset = "0x8C4CFD0", VA = "0x188C4DFD0", Slot = "19")]
		public FUYIEYJKYTM IMXHWTPVEFX(RigidbodyEx a, RigidbodyExData b, ILREYZAYNJV c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0xACBA90", Offset = "0xACAA90", VA = "0x180ACBA90", Slot = "4")]
		public PTXSDCEKRJQ ADSZWSJQIOW(FUYIEYJKYTM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0xACBA90", Offset = "0xACAA90", VA = "0x180ACBA90", Slot = "5")]
		public FXTQWLZMIBS JUSMMYSXVLO(FUYIEYJKYTM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0xACBA90", Offset = "0xACAA90", VA = "0x180ACBA90", Slot = "6")]
		public VTWKHYUGUWB BZUNQQLNBUV(FUYIEYJKYTM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0xACBA90", Offset = "0xACAA90", VA = "0x180ACBA90", Slot = "7")]
		public NZBWOPNKWOG JJEFHVJFVDE(FUYIEYJKYTM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0xACBA90", Offset = "0xACAA90", VA = "0x180ACBA90", Slot = "8")]
		public ZJNDDWRIIMG TVDTEJPVEVY(FUYIEYJKYTM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0xACBA90", Offset = "0xACAA90", VA = "0x180ACBA90", Slot = "9")]
		public SEPTSVZWEFP FZEGLHDHPSN(FUYIEYJKYTM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0xACBA90", Offset = "0xACAA90", VA = "0x180ACBA90", Slot = "10")]
		public GYNXKDBSODG VEVFLKRSQDK(FUYIEYJKYTM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0xACBA90", Offset = "0xACAA90", VA = "0x180ACBA90", Slot = "11")]
		public RUCOGLQCYDY YIHESHKXVHI(FUYIEYJKYTM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0xACBA90", Offset = "0xACAA90", VA = "0x180ACBA90", Slot = "12")]
		public DBJPTXDNTEI FDUFDPZCSZG(FUYIEYJKYTM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0xACBA90", Offset = "0xACAA90", VA = "0x180ACBA90", Slot = "13")]
		public AGBXMHTFSAT VMYFHJOYJJJ(FUYIEYJKYTM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0xACBA90", Offset = "0xACAA90", VA = "0x180ACBA90")]
		public AEQXTEPJFYH EESYFGHYADB(FUYIEYJKYTM a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0xACBA90", Offset = "0xACAA90", VA = "0x180ACBA90")]
		public APOKDZGZGNL PHTPNFALWMZ(FUYIEYJKYTM a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0xACBA90", Offset = "0xACAA90", VA = "0x180ACBA90")]
		public IILMGYJKVNV RNXMLAVPMTR(FUYIEYJKYTM a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0xACBA90", Offset = "0xACAA90", VA = "0x180ACBA90")]
		public WRARQCERPVP VEWIQDYNOLL(FUYIEYJKYTM a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0xACBA90", Offset = "0xACAA90", VA = "0x180ACBA90")]
		public PBYHJXVWESJ DFKHYEDIOBP(FUYIEYJKYTM a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		public DQLLKGWDYLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0xACBA90", Offset = "0xACAA90", VA = "0x180ACBA90", Slot = "14")]
		private AEQXTEPJFYH FIPFLIUKBCT(FUYIEYJKYTM a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0xACBA90", Offset = "0xACAA90", VA = "0x180ACBA90", Slot = "15")]
		private APOKDZGZGNL SHDZWLBUUDH(FUYIEYJKYTM a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0xACBA90", Offset = "0xACAA90", VA = "0x180ACBA90", Slot = "16")]
		private IILMGYJKVNV UNETUUWWPFV(FUYIEYJKYTM a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0xACBA90", Offset = "0xACAA90", VA = "0x180ACBA90", Slot = "17")]
		private WRARQCERPVP NOOSUMYJPER(FUYIEYJKYTM a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0xACBA90", Offset = "0xACAA90", VA = "0x180ACBA90", Slot = "18")]
		private PBYHJXVWESJ EDIHUPHYVUJ(FUYIEYJKYTM a, [In] RigidbodyExData data)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[RegisterService(typeof(FIMFBEIQTMD), new string[] { })]
	public class KWVVAXQIDCZ : FIMFBEIQTMD, AXDTJKLCJPD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private readonly FIMFBEIQTMD WRUHXLDOWMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private readonly FIMFBEIQTMD SZBRAXSOIVP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private IDMDEIRNMLN KDAXZXHYSNA;

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		private FIMFBEIQTMD RQKYQHOHYSH
		{
			[Cpp2IlInjected.Token(Token = "0x600021F")]
			[Cpp2IlInjected.Address(RVA = "0x8C50D30", Offset = "0x8C4FD30", VA = "0x188C50D30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x8C511B0", Offset = "0x8C501B0", VA = "0x188C511B0", Slot = "20")]
		public void InitReferences(MEMEGXEKDDM services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x8C50C90", Offset = "0x8C4FC90", VA = "0x188C50C90", Slot = "4")]
		public PTXSDCEKRJQ ADSZWSJQIOW(FUYIEYJKYTM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x8C512A0", Offset = "0x8C502A0", VA = "0x188C512A0", Slot = "5")]
		public FXTQWLZMIBS JUSMMYSXVLO(FUYIEYJKYTM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x8C50D90", Offset = "0x8C4FD90", VA = "0x188C50D90", Slot = "6")]
		public VTWKHYUGUWB BZUNQQLNBUV(FUYIEYJKYTM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x8C51200", Offset = "0x8C50200", VA = "0x188C51200", Slot = "7")]
		public NZBWOPNKWOG JJEFHVJFVDE(FUYIEYJKYTM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x8C51550", Offset = "0x8C50550", VA = "0x188C51550", Slot = "8")]
		public ZJNDDWRIIMG TVDTEJPVEVY(FUYIEYJKYTM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x8C51030", Offset = "0x8C50030", VA = "0x188C51030", Slot = "9")]
		public SEPTSVZWEFP FZEGLHDHPSN(FUYIEYJKYTM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x8C515F0", Offset = "0x8C505F0", VA = "0x188C515F0", Slot = "10")]
		public GYNXKDBSODG VEVFLKRSQDK(FUYIEYJKYTM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x8C51730", Offset = "0x8C50730", VA = "0x188C51730", Slot = "11")]
		public RUCOGLQCYDY YIHESHKXVHI(FUYIEYJKYTM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x8C50F90", Offset = "0x8C4FF90", VA = "0x188C50F90", Slot = "12")]
		public DBJPTXDNTEI FDUFDPZCSZG(FUYIEYJKYTM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x8C51690", Offset = "0x8C50690", VA = "0x188C51690", Slot = "13")]
		public AGBXMHTFSAT VMYFHJOYJJJ(FUYIEYJKYTM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x8C50EE0", Offset = "0x8C4FEE0", VA = "0x188C50EE0")]
		public AEQXTEPJFYH EESYFGHYADB(FUYIEYJKYTM a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x8C513F0", Offset = "0x8C503F0", VA = "0x188C513F0")]
		public APOKDZGZGNL PHTPNFALWMZ(FUYIEYJKYTM a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x8C514A0", Offset = "0x8C504A0", VA = "0x188C514A0")]
		public IILMGYJKVNV RNXMLAVPMTR(FUYIEYJKYTM a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x8C51340", Offset = "0x8C50340", VA = "0x188C51340")]
		public WRARQCERPVP VEWIQDYNOLL(FUYIEYJKYTM a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x8C50E30", Offset = "0x8C4FE30", VA = "0x188C50E30")]
		public PBYHJXVWESJ DFKHYEDIOBP(FUYIEYJKYTM a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x8C510D0", Offset = "0x8C500D0", VA = "0x188C510D0", Slot = "19")]
		public FUYIEYJKYTM IMXHWTPVEFX(RigidbodyEx a, RigidbodyExData b, ILREYZAYNJV c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x8C517D0", Offset = "0x8C507D0", VA = "0x188C517D0")]
		public KWVVAXQIDCZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x8C50EE0", Offset = "0x8C4FEE0", VA = "0x188C50EE0", Slot = "14")]
		private AEQXTEPJFYH FIPFLIUKBCT(FUYIEYJKYTM a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x8C513F0", Offset = "0x8C503F0", VA = "0x188C513F0", Slot = "15")]
		private APOKDZGZGNL SHDZWLBUUDH(FUYIEYJKYTM a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x8C514A0", Offset = "0x8C504A0", VA = "0x188C514A0", Slot = "16")]
		private IILMGYJKVNV UNETUUWWPFV(FUYIEYJKYTM a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x8C51340", Offset = "0x8C50340", VA = "0x188C51340", Slot = "17")]
		private WRARQCERPVP NOOSUMYJPER(FUYIEYJKYTM a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x8C50E30", Offset = "0x8C4FE30", VA = "0x188C50E30", Slot = "18")]
		private PBYHJXVWESJ EDIHUPHYVUJ(FUYIEYJKYTM a, [In] RigidbodyExData data)
		{
			return null;
		}
	}
}
namespace RecRoom.Rbex.Legacy
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public interface CSOKJVMRZJJ : PTXSDCEKRJQ, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void VVRQOXRGJLG(FUYIEYJKYTM a);

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void OCKHIFKXLBV(FUYIEYJKYTM a);

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void WUYPDXTYTQC(FUYIEYJKYTM a);

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void TWHXRKIMLWT(FUYIEYJKYTM a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public interface GONGNEFKITK : VTWKHYUGUWB
	{
		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		XYEPYDHGFCI<FUYIEYJKYTM> LNKIFHJNLGH
		{
			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		FUYIEYJKYTM ZMYTYLLWWPR
		{
			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public interface DQJZYHWZRDI : WRARQCERPVP
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		(float, Vector3) IJMILNVQVAP(Rigidbody a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public interface OEJIKQOHRBS : APOKDZGZGNL, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		RRNetworkView NYVDZTMGCEA
		{
			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	internal sealed class GLTSPAKASCZ : DBJPTXDNTEI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private readonly THJLXNQARFP BBOWPLDTZJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private CollisionDetectionMode UEOWTFBCVBB;

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		private Rigidbody JVMXVKOVXML
		{
			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0x8C4F640", Offset = "0x8C4E640", VA = "0x188C4F640")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		public CollisionDetectionMode FBJGEILMVLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0x8C4F8E0", Offset = "0x8C4E8E0", VA = "0x188C4F8E0", Slot = "4")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0x8C4F690", Offset = "0x8C4E690", VA = "0x188C4F690", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x8C4F9F0", Offset = "0x8C4E9F0", VA = "0x188C4F9F0")]
		public GLTSPAKASCZ(FUYIEYJKYTM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x8C4F410", Offset = "0x8C4E410", VA = "0x188C4F410", Slot = "6")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x8C4F860", Offset = "0x8C4E860", VA = "0x188C4F860", Slot = "9")]
		public void SQRKTFILJWO(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x8C4F400", Offset = "0x8C4E400", VA = "0x188C4F400", Slot = "7")]
		public void ATTJZYAHFYJ(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x8C4F3F0", Offset = "0x8C4E3F0", VA = "0x188C4F3F0", Slot = "8")]
		public void AECPFXQLJEM(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x8C4F700", Offset = "0x8C4E700", VA = "0x188C4F700", Slot = "10")]
		public bool LIWPYJDBZHH(Vector3 a, [Out] RaycastHit b, float c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x8C4F520", Offset = "0x8C4E520", VA = "0x188C4F520")]
		private void GRVWFQNWMYT(bool a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public sealed class RKPEKDHEDFI : SEPTSVZWEFP, IDisposable, APCQRKUFDVH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly THJLXNQARFP BBOWPLDTZJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private TransformTrackRate BLJTGGLZESA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private HNGTMTQNYBC WTWDKZRBXTS;

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		public TransformTrackRate VJGGPNQXSZS
		{
			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0x8C54A20", Offset = "0x8C53A20", VA = "0x188C54A20", Slot = "6")]
			get
			{
				return default(TransformTrackRate);
			}
			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0x8C54B70", Offset = "0x8C53B70", VA = "0x188C54B70", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000092")]
		private Transform PKEMANVEPRF
		{
			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x8C54C40", Offset = "0x8C53C40", VA = "0x188C54C40", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000020")]
		public event Action<UpdateLOD, UpdateLOD> HQKBSYHLJCN
		{
			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0x8C54C60", Offset = "0x8C53C60", VA = "0x188C54C60", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0x8C54920", Offset = "0x8C53920", VA = "0x188C54920", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x8C54D10", Offset = "0x8C53D10", VA = "0x188C54D10")]
		public RKPEKDHEDFI(FUYIEYJKYTM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x8C546B0", Offset = "0x8C536B0", VA = "0x188C546B0", Slot = "8")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x8C549D0", Offset = "0x8C539D0", VA = "0x188C549D0", Slot = "9")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x1159230", Offset = "0x1158230", VA = "0x181159230", Slot = "11")]
		private void KUFLICYDZQU(UpdateLOD a, UpdateLOD b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "12")]
		private void PYWRKXKIHCY(bool a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class DQLLKGWDYLG : FIMFBEIQTMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x8C4DA50", Offset = "0x8C4CA50", VA = "0x188C4DA50", Slot = "4")]
		public PTXSDCEKRJQ ADSZWSJQIOW(FUYIEYJKYTM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E210", Offset = "0x8C4D210", VA = "0x188C4E210", Slot = "5")]
		public FXTQWLZMIBS JUSMMYSXVLO(FUYIEYJKYTM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x8C4DB30", Offset = "0x8C4CB30", VA = "0x188C4DB30", Slot = "6")]
		public VTWKHYUGUWB BZUNQQLNBUV(FUYIEYJKYTM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E1A0", Offset = "0x8C4D1A0", VA = "0x188C4E1A0", Slot = "7")]
		public NZBWOPNKWOG JJEFHVJFVDE(FUYIEYJKYTM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E7A0", Offset = "0x8C4D7A0", VA = "0x188C4E7A0", Slot = "8")]
		public ZJNDDWRIIMG TVDTEJPVEVY(FUYIEYJKYTM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x8C4DF10", Offset = "0x8C4CF10", VA = "0x188C4DF10", Slot = "9")]
		public SEPTSVZWEFP FZEGLHDHPSN(FUYIEYJKYTM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E860", Offset = "0x8C4D860", VA = "0x188C4E860", Slot = "10")]
		public GYNXKDBSODG VEVFLKRSQDK(FUYIEYJKYTM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x8C4EA30", Offset = "0x8C4DA30", VA = "0x188C4EA30", Slot = "11")]
		public RUCOGLQCYDY YIHESHKXVHI(FUYIEYJKYTM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x8C4DE50", Offset = "0x8C4CE50", VA = "0x188C4DE50", Slot = "12")]
		public DBJPTXDNTEI FDUFDPZCSZG(FUYIEYJKYTM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E970", Offset = "0x8C4D970", VA = "0x188C4E970", Slot = "13")]
		public AGBXMHTFSAT VMYFHJOYJJJ(FUYIEYJKYTM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x8C4DD20", Offset = "0x8C4CD20", VA = "0x188C4DD20")]
		public AEQXTEPJFYH EESYFGHYADB(FUYIEYJKYTM a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E4A0", Offset = "0x8C4D4A0", VA = "0x188C4E4A0")]
		public APOKDZGZGNL PHTPNFALWMZ(FUYIEYJKYTM a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E670", Offset = "0x8C4D670", VA = "0x188C4E670")]
		public IILMGYJKVNV RNXMLAVPMTR(FUYIEYJKYTM a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E320", Offset = "0x8C4D320", VA = "0x188C4E320")]
		public WRARQCERPVP VEWIQDYNOLL(FUYIEYJKYTM a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x8C4DC50", Offset = "0x8C4CC50", VA = "0x188C4DC50")]
		public PBYHJXVWESJ DFKHYEDIOBP(FUYIEYJKYTM a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E060", Offset = "0x8C4D060", VA = "0x188C4E060", Slot = "19")]
		public FUYIEYJKYTM IMXHWTPVEFX(RigidbodyEx a, RigidbodyExData b, ILREYZAYNJV c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		public DQLLKGWDYLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x8C4DD20", Offset = "0x8C4CD20", VA = "0x188C4DD20", Slot = "14")]
		private AEQXTEPJFYH FIPFLIUKBCT(FUYIEYJKYTM a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E790", Offset = "0x8C4D790", VA = "0x188C4E790", Slot = "15")]
		private APOKDZGZGNL SHDZWLBUUDH(FUYIEYJKYTM a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E670", Offset = "0x8C4D670", VA = "0x188C4E670", Slot = "16")]
		private IILMGYJKVNV UNETUUWWPFV(FUYIEYJKYTM a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E320", Offset = "0x8C4D320", VA = "0x188C4E320", Slot = "17")]
		private WRARQCERPVP NOOSUMYJPER(FUYIEYJKYTM a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x8C4DC50", Offset = "0x8C4CC50", VA = "0x188C4DC50", Slot = "18")]
		private PBYHJXVWESJ EDIHUPHYVUJ(FUYIEYJKYTM a, [In] RigidbodyExData data)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal sealed class UHXHLADPPTP : RUCOGLQCYDY
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private readonly THJLXNQARFP BBOWPLDTZJE;

		[Cpp2IlInjected.Token(Token = "0x17000093")]
		private Rigidbody JVMXVKOVXML
		{
			[Cpp2IlInjected.Token(Token = "0x6000268")]
			[Cpp2IlInjected.Address(RVA = "0x8C4F640", Offset = "0x8C4E640", VA = "0x188C4F640")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000094")]
		private bool UEOMVOEOZUQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000269")]
			[Cpp2IlInjected.Address(RVA = "0x8C67440", Offset = "0x8C66440", VA = "0x188C67440")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000095")]
		private bool YJTPNVLEYTP
		{
			[Cpp2IlInjected.Token(Token = "0x600026A")]
			[Cpp2IlInjected.Address(RVA = "0x8C4ED40", Offset = "0x8C4DD40", VA = "0x188C4ED40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000096")]
		private FUYIEYJKYTM YODRVKGPXDV
		{
			[Cpp2IlInjected.Token(Token = "0x600026B")]
			[Cpp2IlInjected.Address(RVA = "0x8C67490", Offset = "0x8C66490", VA = "0x188C67490")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x8C4F9F0", Offset = "0x8C4E9F0", VA = "0x188C4F9F0")]
		public UHXHLADPPTP(FUYIEYJKYTM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x8C66E20", Offset = "0x8C65E20", VA = "0x188C66E20", Slot = "4")]
		public void FMALXWSEXRT(Vector3 a, ForceMode b = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x8C674F0", Offset = "0x8C664F0", VA = "0x188C674F0")]
		private void SDVHEPSEOGI(Vector3 a, ForceMode b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x8C66BA0", Offset = "0x8C65BA0", VA = "0x188C66BA0", Slot = "5")]
		public void ACBBLCKPGBN(Vector3 a, Vector3 b, ForceMode c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x8C67750", Offset = "0x8C66750", VA = "0x188C67750", Slot = "6")]
		public void ZJWOXSISKCM(Vector3 a, ForceMode b = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x8C66F80", Offset = "0x8C65F80", VA = "0x188C66F80")]
		private void GEZXOYRZYXF(Vector3 a, ForceMode b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x8C671E0", Offset = "0x8C661E0", VA = "0x188C671E0", Slot = "7")]
		public void IDXWNMEBWIY(Vector3 a, ForceMode b = ForceMode.Force)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	internal sealed class ZLBGORNNSPK : AGBXMHTFSAT
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private readonly THJLXNQARFP BBOWPLDTZJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private bool JTIRCNECTXS;

		[Cpp2IlInjected.Token(Token = "0x17000097")]
		public bool YUXMEOIJDUI
		{
			[Cpp2IlInjected.Token(Token = "0x6000274")]
			[Cpp2IlInjected.Address(RVA = "0xC35BD0", Offset = "0xC34BD0", VA = "0x180C35BD0", Slot = "4")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000275")]
			[Cpp2IlInjected.Address(RVA = "0x8C696E0", Offset = "0x8C686E0", VA = "0x188C696E0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x8C4F9F0", Offset = "0x8C4E9F0", VA = "0x188C4F9F0")]
		public ZLBGORNNSPK(FUYIEYJKYTM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x8C697F0", Offset = "0x8C687F0", VA = "0x188C697F0", Slot = "6")]
		public void SQRKTFILJWO(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x8C69670", Offset = "0x8C68670", VA = "0x188C69670", Slot = "7")]
		public void GQOHVARTNSP(Rigidbody a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	internal sealed class RbexHierarchy : CSOKJVMRZJJ, PTXSDCEKRJQ, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private readonly FUYIEYJKYTM BBOWPLDTZJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private readonly List<FUYIEYJKYTM> QDWGXJAMGYI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private FUYIEYJKYTM EQMHNAKVRHZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private FUYIEYJKYTM CGKCNLBHYUH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private Transform ISLPFTCFTTU;

		[Cpp2IlInjected.Token(Token = "0x17000098")]
		private Transform TAMVZOUDDLX
		{
			[Cpp2IlInjected.Token(Token = "0x600028A")]
			[Cpp2IlInjected.Address(RVA = "0x8C56820", Offset = "0x8C55820", VA = "0x188C56820")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000099")]
		public FUYIEYJKYTM YODRVKGPXDV
		{
			[Cpp2IlInjected.Token(Token = "0x600028D")]
			[Cpp2IlInjected.Address(RVA = "0xACDCA0", Offset = "0xACCCA0", VA = "0x180ACDCA0", Slot = "28")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600028E")]
			[Cpp2IlInjected.Address(RVA = "0x8C56060", Offset = "0x8C55060", VA = "0x188C56060", Slot = "29")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009A")]
		public FUYIEYJKYTM SYFXSLEPKPV
		{
			[Cpp2IlInjected.Token(Token = "0x600028F")]
			[Cpp2IlInjected.Address(RVA = "0xACDCB0", Offset = "0xACCCB0", VA = "0x180ACDCB0", Slot = "27")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		public IReadOnlyList<FUYIEYJKYTM> QSEZLIHKKDV
		{
			[Cpp2IlInjected.Token(Token = "0x6000290")]
			[Cpp2IlInjected.Address(RVA = "0xACDF70", Offset = "0xACCF70", VA = "0x180ACDF70", Slot = "26")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000021")]
		public event RbexAction IZLTKLKAQIT
		{
			[Cpp2IlInjected.Token(Token = "0x6000278")]
			[Cpp2IlInjected.Address(RVA = "0x8C563A0", Offset = "0x8C553A0", VA = "0x188C563A0", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000279")]
			[Cpp2IlInjected.Address(RVA = "0x8C56590", Offset = "0x8C55590", VA = "0x188C56590", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000022")]
		public event RbexAction BDCMNNALPYZ
		{
			[Cpp2IlInjected.Token(Token = "0x600027A")]
			[Cpp2IlInjected.Address(RVA = "0x8C56110", Offset = "0x8C55110", VA = "0x188C56110", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600027B")]
			[Cpp2IlInjected.Address(RVA = "0x8C55D40", Offset = "0x8C54D40", VA = "0x188C55D40", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000023")]
		public event RbexParentChangeAction RFMRJXTICHH
		{
			[Cpp2IlInjected.Token(Token = "0x600027C")]
			[Cpp2IlInjected.Address(RVA = "0x8C56250", Offset = "0x8C55250", VA = "0x188C56250", Slot = "12")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600027D")]
			[Cpp2IlInjected.Address(RVA = "0x8C55FC0", Offset = "0x8C54FC0", VA = "0x188C55FC0", Slot = "13")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000024")]
		public event Action QKDGLFHPCOM
		{
			[Cpp2IlInjected.Token(Token = "0x600027E")]
			[Cpp2IlInjected.Address(RVA = "0x8C561B0", Offset = "0x8C551B0", VA = "0x188C561B0", Slot = "14")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600027F")]
			[Cpp2IlInjected.Address(RVA = "0x8C572B0", Offset = "0x8C562B0", VA = "0x188C572B0", Slot = "15")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000025")]
		public event Action RDELHNGLQDD
		{
			[Cpp2IlInjected.Token(Token = "0x6000280")]
			[Cpp2IlInjected.Address(RVA = "0x8C55A00", Offset = "0x8C54A00", VA = "0x188C55A00", Slot = "16")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000281")]
			[Cpp2IlInjected.Address(RVA = "0x8C55F20", Offset = "0x8C54F20", VA = "0x188C55F20", Slot = "17")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000026")]
		public event Action<FUYIEYJKYTM> QVQICOWEDZG
		{
			[Cpp2IlInjected.Token(Token = "0x6000282")]
			[Cpp2IlInjected.Address(RVA = "0x8C564E0", Offset = "0x8C554E0", VA = "0x188C564E0", Slot = "18")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000283")]
			[Cpp2IlInjected.Address(RVA = "0x8C56DF0", Offset = "0x8C55DF0", VA = "0x188C56DF0", Slot = "19")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000027")]
		public event Action<FUYIEYJKYTM> FRVDYAKLKOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000284")]
			[Cpp2IlInjected.Address(RVA = "0x8C562F0", Offset = "0x8C552F0", VA = "0x188C562F0", Slot = "20")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000285")]
			[Cpp2IlInjected.Address(RVA = "0x8C571C0", Offset = "0x8C561C0", VA = "0x188C571C0", Slot = "21")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000028")]
		public event Action CFPLQRCINTO
		{
			[Cpp2IlInjected.Token(Token = "0x6000286")]
			[Cpp2IlInjected.Address(RVA = "0x8C55E80", Offset = "0x8C54E80", VA = "0x188C55E80", Slot = "22")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000287")]
			[Cpp2IlInjected.Address(RVA = "0x8C56070", Offset = "0x8C55070", VA = "0x188C56070", Slot = "23")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000029")]
		public event Action<FUYIEYJKYTM> WROHLLZLMSV
		{
			[Cpp2IlInjected.Token(Token = "0x6000288")]
			[Cpp2IlInjected.Address(RVA = "0x8C55C90", Offset = "0x8C54C90", VA = "0x188C55C90", Slot = "24")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000289")]
			[Cpp2IlInjected.Address(RVA = "0x8C56770", Offset = "0x8C55770", VA = "0x188C56770", Slot = "25")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x8C577D0", Offset = "0x8C567D0", VA = "0x188C577D0")]
		public RbexHierarchy(FUYIEYJKYTM rbex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x8C55DE0", Offset = "0x8C54DE0", VA = "0x188C55DE0", Slot = "31")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x8C56880", Offset = "0x8C55880", VA = "0x188C56880", Slot = "30")]
		public void SetParent(FUYIEYJKYTM newParent, bool isPhysicallyDetachedOnly = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x8C57440", Offset = "0x8C56440", VA = "0x188C57440", Slot = "6")]
		public void WUYPDXTYTQC(FUYIEYJKYTM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x8C56EA0", Offset = "0x8C55EA0", VA = "0x188C56EA0", Slot = "7")]
		public void TWHXRKIMLWT(FUYIEYJKYTM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x8C57350", Offset = "0x8C56350", VA = "0x188C57350", Slot = "4")]
		public void VVRQOXRGJLG(FUYIEYJKYTM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x8C56440", Offset = "0x8C55440", VA = "0x188C56440", Slot = "5")]
		public void OCKHIFKXLBV(FUYIEYJKYTM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x8C57120", Offset = "0x8C56120", VA = "0x188C57120")]
		private void UMUYXPCMPJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x8C57270", Offset = "0x8C56270", VA = "0x188C57270")]
		private void VBJQHXCDLEB(FUYIEYJKYTM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x8C56630", Offset = "0x8C55630", VA = "0x188C56630")]
		private void QRNVEAIHTUW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x8C55B60", Offset = "0x8C54B60", VA = "0x188C55B60")]
		private void CIYWNDZDGIX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x8C576B0", Offset = "0x8C566B0", VA = "0x188C576B0")]
		private void YECBTZHSCBR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x8C55AA0", Offset = "0x8C54AA0", VA = "0x188C55AA0")]
		[CompilerGenerated]
		private object CDLVWFWASED()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	internal static class HAAKXVFAHAX
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x8C4FA80", Offset = "0x8C4EA80", VA = "0x188C4FA80")]
		public static CSOKJVMRZJJ SWYLICGKBPA(this FUYIEYJKYTM a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	internal sealed class HSCUAFGZXDI : GONGNEFKITK, VTWKHYUGUWB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly THJLXNQARFP BBOWPLDTZJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private readonly XYEPYDHGFCI<FUYIEYJKYTM> GATUVKTEWNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private bool DFZHAQSGBWM;

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		public XYEPYDHGFCI<FUYIEYJKYTM> LNKIFHJNLGH
		{
			[Cpp2IlInjected.Token(Token = "0x600029D")]
			[Cpp2IlInjected.Address(RVA = "0xACF7F0", Offset = "0xACE7F0", VA = "0x180ACF7F0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		public Vector3 WXFFZKCKKEQ
		{
			[Cpp2IlInjected.Token(Token = "0x600029E")]
			[Cpp2IlInjected.Address(RVA = "0x8C504F0", Offset = "0x8C4F4F0", VA = "0x188C504F0", Slot = "6")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		public Vector3 KSJCZXLGDUQ
		{
			[Cpp2IlInjected.Token(Token = "0x600029F")]
			[Cpp2IlInjected.Address(RVA = "0x8C505D0", Offset = "0x8C4F5D0", VA = "0x188C505D0", Slot = "7")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		private Vector3 WONQMRQGLQW
		{
			[Cpp2IlInjected.Token(Token = "0x60002A3")]
			[Cpp2IlInjected.Address(RVA = "0x8C4FC00", Offset = "0x8C4EC00", VA = "0x188C4FC00")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		public FUYIEYJKYTM ZMYTYLLWWPR
		{
			[Cpp2IlInjected.Token(Token = "0x60002A4")]
			[Cpp2IlInjected.Address(RVA = "0x8C50520", Offset = "0x8C4F520", VA = "0x188C50520", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x8C508D0", Offset = "0x8C4F8D0", VA = "0x188C508D0")]
		public HSCUAFGZXDI(FUYIEYJKYTM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x8C4FD40", Offset = "0x8C4ED40", VA = "0x188C4FD40", Slot = "8")]
		public void GJDIVXFKMYS(FUYIEYJKYTM a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x8C4FCE0", Offset = "0x8C4ECE0", VA = "0x188C4FCE0", Slot = "9")]
		public void ENSFHXQSBQH(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x8C50150", Offset = "0x8C4F150", VA = "0x188C50150")]
		private Vector3 TEZICMTOFVI()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x8C4FDB0", Offset = "0x8C4EDB0", VA = "0x188C4FDB0")]
		private void PKDOPLVKDOH(FUYIEYJKYTM a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	internal static class QGBHYPTHEZG
	{
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x8C545F0", Offset = "0x8C535F0", VA = "0x188C545F0")]
		public static GONGNEFKITK STUXBWEMBZT(this FUYIEYJKYTM a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	internal sealed class MFHSKNJHQYQ : DQJZYHWZRDI, WRARQCERPVP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private readonly THJLXNQARFP BBOWPLDTZJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private readonly OverridableVector3 BZMIBHJHDGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private readonly OverridableVector3 EGBYAFOOYMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private float LPHWJFTMDZC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private float RFAERVFGTGT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private Vector3 NQCGURYIEHQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private Vector3? DVZMIZOLQDY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private Quaternion? QKNQLTMXBYY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private bool VBPYTFBACBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private bool ZUIFYNIQWQI;

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		public Vector3 MRFBCJVIBRI
		{
			[Cpp2IlInjected.Token(Token = "0x60002AA")]
			[Cpp2IlInjected.Address(RVA = "0x1C61990", Offset = "0x1C60990", VA = "0x181C61990", Slot = "7")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60002AB")]
			[Cpp2IlInjected.Address(RVA = "0x8C52240", Offset = "0x8C51240", VA = "0x188C52240", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		public Vector3 ONUVYMNJDSJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002AC")]
			[Cpp2IlInjected.Address(RVA = "0x8C53580", Offset = "0x8C52580", VA = "0x188C53580", Slot = "9")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		public float HMPRXVXBKHF
		{
			[Cpp2IlInjected.Token(Token = "0x60002AD")]
			[Cpp2IlInjected.Address(RVA = "0xB1DBD0", Offset = "0xB1CBD0", VA = "0x180B1DBD0", Slot = "10")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60002AE")]
			[Cpp2IlInjected.Address(RVA = "0x8C53350", Offset = "0x8C52350", VA = "0x188C53350")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A4")]
		public float LKXKKPGMOTC
		{
			[Cpp2IlInjected.Token(Token = "0x60002AF")]
			[Cpp2IlInjected.Address(RVA = "0xB1DBE0", Offset = "0xB1CBE0", VA = "0x180B1DBE0", Slot = "11")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60002B0")]
			[Cpp2IlInjected.Address(RVA = "0x8C51FB0", Offset = "0x8C50FB0", VA = "0x188C51FB0", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		public Vector3 JNUPSQBWKDI
		{
			[Cpp2IlInjected.Token(Token = "0x60002B1")]
			[Cpp2IlInjected.Address(RVA = "0x8C51D40", Offset = "0x8C50D40", VA = "0x188C51D40", Slot = "13")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A6")]
		public Quaternion VVSCJNHLAWA
		{
			[Cpp2IlInjected.Token(Token = "0x60002B2")]
			[Cpp2IlInjected.Address(RVA = "0x8C53D20", Offset = "0x8C52D20", VA = "0x188C53D20", Slot = "14")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A7")]
		private Rigidbody JVMXVKOVXML
		{
			[Cpp2IlInjected.Token(Token = "0x60002BA")]
			[Cpp2IlInjected.Address(RVA = "0x8C522F0", Offset = "0x8C512F0", VA = "0x188C522F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400002A")]
		public event RbexAction STBRGTPQBZH
		{
			[Cpp2IlInjected.Token(Token = "0x60002A8")]
			[Cpp2IlInjected.Address(RVA = "0x8C53F80", Offset = "0x8C52F80", VA = "0x188C53F80", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60002A9")]
			[Cpp2IlInjected.Address(RVA = "0x8C53B60", Offset = "0x8C52B60", VA = "0x188C53B60", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x8C541A0", Offset = "0x8C531A0", VA = "0x188C541A0")]
		public MFHSKNJHQYQ(FUYIEYJKYTM a, [In] RigidbodyExData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x8C53460", Offset = "0x8C52460", VA = "0x188C53460", Slot = "17")]
		public void NBYZDYHITYY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x8C51ED0", Offset = "0x8C50ED0", VA = "0x188C51ED0", Slot = "16")]
		public void FZARYHWTSVV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x8C53EA0", Offset = "0x8C52EA0", VA = "0x188C53EA0", Slot = "19")]
		public void SQRKTFILJWO(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x8C52060", Offset = "0x8C51060", VA = "0x188C52060", Slot = "20")]
		public void GQOHVARTNSP(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x8C52340", Offset = "0x8C51340", VA = "0x188C52340", Slot = "18")]
		public void HXJRSISDISO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x8C536A0", Offset = "0x8C526A0", VA = "0x188C536A0", Slot = "21")]
		public void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x8C52240", Offset = "0x8C51240", VA = "0x188C52240")]
		private void GRCWAIZECPW(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x8C53C00", Offset = "0x8C52C00", VA = "0x188C53C00")]
		[Obsolete("This method is dangerous - the unity rigidbody is updated in a deferred manner and this world position may be stale")]
		private Vector3 SOGKJSXIHSH()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x8C53350", Offset = "0x8C52350", VA = "0x188C53350")]
		private void LYPAYIDZWON(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x8C51FB0", Offset = "0x8C50FB0", VA = "0x188C51FB0")]
		private void GPGDJRSXQXQ(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x8C51970", Offset = "0x8C50970", VA = "0x188C51970")]
		private Vector3 AURDSMIFZIA()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x8C51B10", Offset = "0x8C50B10", VA = "0x188C51B10", Slot = "15")]
		public void BCNBYCUWGQA((Quaternion rot, Vector3 moments) tensor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x8C54020", Offset = "0x8C53020", VA = "0x188C54020")]
		private Quaternion ZDSBFFDZTPQ()
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x8C53280", Offset = "0x8C52280", VA = "0x188C53280")]
		public void IJMILNVQVAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x8C524E0", Offset = "0x8C514E0", VA = "0x188C524E0", Slot = "4")]
		public (float, Vector3) IJMILNVQVAP(Rigidbody a)
		{
			return default((float, Vector3));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	internal static class HOJZXJKJGIC
	{
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x8C4FB40", Offset = "0x8C4EB40", VA = "0x188C4FB40")]
		public static DQJZYHWZRDI HSFYDPVBRTX(this FUYIEYJKYTM a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	internal sealed class VQNPXLUXCCU : IILMGYJKVNV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private readonly THJLXNQARFP BBOWPLDTZJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private readonly UOYNNJIMGKD DVYZQZHABKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private readonly RbexInterpolationMode MSIBVDBIYIS;

		[Cpp2IlInjected.Token(Token = "0x170000A8")]
		public bool FRTANNRDFQO
		{
			[Cpp2IlInjected.Token(Token = "0x60002C5")]
			[Cpp2IlInjected.Address(RVA = "0x18BBDD0", Offset = "0x18BADD0", VA = "0x1818BBDD0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A9")]
		public RbexInterpolationMode ZIVQKMULLMU
		{
			[Cpp2IlInjected.Token(Token = "0x60002C6")]
			[Cpp2IlInjected.Address(RVA = "0xADC530", Offset = "0xADB530", VA = "0x180ADC530", Slot = "11")]
			get
			{
				return default(RbexInterpolationMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x8C68E50", Offset = "0x8C67E50", VA = "0x188C68E50")]
		public VQNPXLUXCCU(FUYIEYJKYTM a, [In] RigidbodyExData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x8C68840", Offset = "0x8C67840", VA = "0x188C68840", Slot = "4")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x8C68DB0", Offset = "0x8C67DB0", VA = "0x188C68DB0")]
		private bool ZSROBLPSTTG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x8C68980", Offset = "0x8C67980", VA = "0x188C68980", Slot = "5")]
		public void KPMYUFQUIJK(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x8C68910", Offset = "0x8C67910", VA = "0x188C68910", Slot = "6")]
		public void BAYJUDCCIDR(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x8C68C80", Offset = "0x8C67C80", VA = "0x188C68C80", Slot = "9")]
		public void YDQVBAJLJNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x8C68B70", Offset = "0x8C67B70", VA = "0x188C68B70")]
		private void WRHJJXASNOQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x8C689B0", Offset = "0x8C679B0", VA = "0x188C689B0")]
		private void OGFELIXXKIU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x8C68B30", Offset = "0x8C67B30", VA = "0x188C68B30", Slot = "8")]
		public void UFGHJOSILJY(FUYIEYJKYTM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x8C68940", Offset = "0x8C67940", VA = "0x188C68940", Slot = "7")]
		public void BONFJMJIAMX(FUYIEYJKYTM a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	internal sealed class YINAKZHQQEP : GYNXKDBSODG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private readonly THJLXNQARFP BBOWPLDTZJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private readonly UOYNNJIMGKD GFLTIUMWRXM;

		[Cpp2IlInjected.Token(Token = "0x170000AA")]
		public bool UEOMVOEOZUQ
		{
			[Cpp2IlInjected.Token(Token = "0x60002D3")]
			[Cpp2IlInjected.Address(RVA = "0x8C693C0", Offset = "0x8C683C0", VA = "0x188C693C0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400002B")]
		public event RbexAction UPVPJIIAMNG
		{
			[Cpp2IlInjected.Token(Token = "0x60002D1")]
			[Cpp2IlInjected.Address(RVA = "0x8C694F0", Offset = "0x8C684F0", VA = "0x188C694F0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60002D2")]
			[Cpp2IlInjected.Address(RVA = "0x8C691C0", Offset = "0x8C681C0", VA = "0x188C691C0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x8C69590", Offset = "0x8C68590", VA = "0x188C69590")]
		public YINAKZHQQEP(FUYIEYJKYTM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x8C692A0", Offset = "0x8C682A0", VA = "0x188C692A0", Slot = "7")]
		public void PZILTGHCYTB(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x8C69180", Offset = "0x8C68180", VA = "0x188C69180", Slot = "8")]
		public void AZNVJWZBCUU(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x8C692B0", Offset = "0x8C682B0", VA = "0x188C692B0", Slot = "9")]
		public void RDLECXPDOOC(object a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x8C69260", Offset = "0x8C68260", VA = "0x188C69260", Slot = "12")]
		public void MHCYNETZDAU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x8C69470", Offset = "0x8C68470", VA = "0x188C69470", Slot = "10")]
		public void SQRKTFILJWO(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x8C69190", Offset = "0x8C68190", VA = "0x188C69190", Slot = "11")]
		public void GQOHVARTNSP(Rigidbody a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	internal sealed class UKRBHYNPNAS : OEJIKQOHRBS, APOKDZGZGNL, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private WeakReference<FUYIEYJKYTM> IZUYTZLUOFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private readonly THJLXNQARFP BBOWPLDTZJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private RRNetworkView MHJYCOKPMCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private bool ZRHEFUZLOAJ;

		[Cpp2IlInjected.Token(Token = "0x170000AB")]
		public RRNetworkView NYVDZTMGCEA
		{
			[Cpp2IlInjected.Token(Token = "0x60002DD")]
			[Cpp2IlInjected.Address(RVA = "0xAD2F30", Offset = "0xAD1F30", VA = "0x180AD2F30", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AC")]
		public bool KFGBTMRRIIN
		{
			[Cpp2IlInjected.Token(Token = "0x60002DE")]
			[Cpp2IlInjected.Address(RVA = "0x8C68690", Offset = "0x8C67690", VA = "0x188C68690", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AD")]
		public bool NDIPECDBQMZ
		{
			[Cpp2IlInjected.Token(Token = "0x60002DF")]
			[Cpp2IlInjected.Address(RVA = "0xB25800", Offset = "0xB24800", VA = "0x180B25800", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400002C")]
		public event RbexAction QEVJOZFEHSW
		{
			[Cpp2IlInjected.Token(Token = "0x60002DB")]
			[Cpp2IlInjected.Address(RVA = "0x8C68400", Offset = "0x8C67400", VA = "0x188C68400", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60002DC")]
			[Cpp2IlInjected.Address(RVA = "0x8C685F0", Offset = "0x8C675F0", VA = "0x188C685F0", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x8C686A0", Offset = "0x8C676A0", VA = "0x188C686A0")]
		public UKRBHYNPNAS(FUYIEYJKYTM a, [In] RigidbodyExData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x8C678B0", Offset = "0x8C668B0", VA = "0x188C678B0", Slot = "9")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x8C67B50", Offset = "0x8C66B50", VA = "0x188C67B50", Slot = "12")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x8C68270", Offset = "0x8C67270", VA = "0x188C68270", Slot = "10")]
		public void NOQFFSAIRSR(FUYIEYJKYTM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x8C680F0", Offset = "0x8C670F0", VA = "0x188C680F0", Slot = "11")]
		public void JFBWOMIYXSB(FUYIEYJKYTM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x8C679E0", Offset = "0x8C669E0", VA = "0x188C679E0")]
		private void BNLVRRXFSCH(RRNetworkView a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x8C684A0", Offset = "0x8C674A0", VA = "0x188C684A0")]
		private void SPLIKWWONZH(AHBTVTYSWLG a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x8C67E80", Offset = "0x8C66E80", VA = "0x188C67E80")]
		private void EOYRGCIAUDE(RRNetworkView a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	internal static class TZXMTCXWQHW
	{
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x8C66AE0", Offset = "0x8C65AE0", VA = "0x188C66AE0")]
		public static OEJIKQOHRBS Lifecycle(this FUYIEYJKYTM impl)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	internal sealed class VTWFUYNHIQU : PBYHJXVWESJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private readonly THJLXNQARFP BBOWPLDTZJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private RigidbodyConstraints KCFIWUVCKWJ;

		[Cpp2IlInjected.Token(Token = "0x170000AE")]
		public bool TIVOZGLXMLQ
		{
			[Cpp2IlInjected.Token(Token = "0x60002E9")]
			[Cpp2IlInjected.Address(RVA = "0xC3DC90", Offset = "0xC3CC90", VA = "0x180C3DC90", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002EA")]
			[Cpp2IlInjected.Address(RVA = "0xC3D6C0", Offset = "0xC3C6C0", VA = "0x180C3D6C0", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AF")]
		public bool AZUZLIDXFAB
		{
			[Cpp2IlInjected.Token(Token = "0x60002EB")]
			[Cpp2IlInjected.Address(RVA = "0xC3D5D0", Offset = "0xC3C5D0", VA = "0x180C3D5D0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002EC")]
			[Cpp2IlInjected.Address(RVA = "0xC3D6D0", Offset = "0xC3C6D0", VA = "0x180C3D6D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B0")]
		public RigidbodyConstraints TQIDUCJNYGZ
		{
			[Cpp2IlInjected.Token(Token = "0x60002ED")]
			[Cpp2IlInjected.Address(RVA = "0xAD05F0", Offset = "0xACF5F0", VA = "0x180AD05F0", Slot = "7")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x60002EE")]
			[Cpp2IlInjected.Address(RVA = "0x8C68FA0", Offset = "0x8C67FA0", VA = "0x188C68FA0", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x8C690D0", Offset = "0x8C680D0", VA = "0x188C690D0")]
		public VTWFUYNHIQU(FUYIEYJKYTM a, [In] RigidbodyExData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x8C68F70", Offset = "0x8C67F70", VA = "0x188C68F70", Slot = "9")]
		public void SQRKTFILJWO(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x8C68F40", Offset = "0x8C67F40", VA = "0x188C68F40", Slot = "10")]
		public void GQOHVARTNSP(Rigidbody a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	internal sealed class KOVIICFZTQH : NZBWOPNKWOG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private readonly FUYIEYJKYTM BBOWPLDTZJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private float YEPOCVSMHVH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private float PETKNARFPAV;

		[Cpp2IlInjected.Token(Token = "0x170000B1")]
		public float MMJEIGMGBDD
		{
			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0xB22640", Offset = "0xB21640", VA = "0x180B22640", Slot = "4")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60002F4")]
			[Cpp2IlInjected.Address(RVA = "0x8C50B80", Offset = "0x8C4FB80", VA = "0x188C50B80", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B2")]
		public float CBWPJIMZILD
		{
			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0xB228B0", Offset = "0xB218B0", VA = "0x180B228B0", Slot = "6")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60002F6")]
			[Cpp2IlInjected.Address(RVA = "0x8C50A60", Offset = "0x8C4FA60", VA = "0x188C50A60", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x8C50C50", Offset = "0x8C4FC50", VA = "0x188C50C50")]
		public KOVIICFZTQH(FUYIEYJKYTM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x8C50B30", Offset = "0x8C4FB30", VA = "0x188C50B30", Slot = "8")]
		public void SQRKTFILJWO(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x8C509C0", Offset = "0x8C4F9C0", VA = "0x188C509C0", Slot = "9")]
		public void GQOHVARTNSP(Rigidbody a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	internal sealed class RMIITHRFHPD : ZJNDDWRIIMG
	{
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private static readonly Log MMKGOGLMPHY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private readonly THJLXNQARFP BBOWPLDTZJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private bool ZVNGSLRGTQK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private bool IHUIPRAMAOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private int RUNJBZJHSNZ;

		[Cpp2IlInjected.Token(Token = "0x170000B3")]
		private Rigidbody JVMXVKOVXML
		{
			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0x8C522F0", Offset = "0x8C512F0", VA = "0x188C522F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B4")]
		private bool JTEVPNPYUBI
		{
			[Cpp2IlInjected.Token(Token = "0x60002FC")]
			[Cpp2IlInjected.Address(RVA = "0x8C558D0", Offset = "0x8C548D0", VA = "0x188C558D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B5")]
		private FUYIEYJKYTM YODRVKGPXDV
		{
			[Cpp2IlInjected.Token(Token = "0x60002FD")]
			[Cpp2IlInjected.Address(RVA = "0x8C55570", Offset = "0x8C54570", VA = "0x188C55570")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B6")]
		private bool YJTPNVLEYTP
		{
			[Cpp2IlInjected.Token(Token = "0x60002FE")]
			[Cpp2IlInjected.Address(RVA = "0x8C55510", Offset = "0x8C54510", VA = "0x188C55510")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400002D")]
		public event RbexAction EJOBFLRUPOG
		{
			[Cpp2IlInjected.Token(Token = "0x60002F9")]
			[Cpp2IlInjected.Address(RVA = "0x8C556A0", Offset = "0x8C546A0", VA = "0x188C556A0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0x8C55740", Offset = "0x8C54740", VA = "0x188C55740", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x8C55970", Offset = "0x8C54970", VA = "0x188C55970")]
		public RMIITHRFHPD(FUYIEYJKYTM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x8C54F60", Offset = "0x8C53F60", VA = "0x188C54F60", Slot = "6")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x8C55500", Offset = "0x8C54500", VA = "0x188C55500", Slot = "8")]
		public void JBSSSPKXLDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x8C54FF0", Offset = "0x8C53FF0", VA = "0x188C54FF0", Slot = "7")]
		public bool EGHVZOWSDMO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x8C555D0", Offset = "0x8C545D0", VA = "0x188C555D0", Slot = "9")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x8C55140", Offset = "0x8C54140", VA = "0x188C55140", Slot = "13")]
		public void EYEJSQGVYXE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x8C55250", Offset = "0x8C54250", VA = "0x188C55250", Slot = "12")]
		public void IWEJGMNPHOZ(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x8C551E0", Offset = "0x8C541E0", VA = "0x188C551E0", Slot = "10")]
		public bool FSPHXUZZUNI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x8C557E0", Offset = "0x8C547E0", VA = "0x188C557E0", Slot = "11")]
		public bool VSDIMQWJDOP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x8C54DA0", Offset = "0x8C53DA0", VA = "0x188C54DA0")]
		private bool AEFECNVEPFP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x8C55370", Offset = "0x8C54370", VA = "0x188C55370")]
		private void JAMMUMTJUUB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	internal sealed class EUFXKQCBLVY : AEQXTEPJFYH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private readonly THJLXNQARFP BBOWPLDTZJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private readonly UOYNNJIMGKD WXWIKHLFVZY;

		[Cpp2IlInjected.Token(Token = "0x170000B7")]
		public Rigidbody JVMXVKOVXML
		{
			[Cpp2IlInjected.Token(Token = "0x600030B")]
			[Cpp2IlInjected.Address(RVA = "0xAD05E0", Offset = "0xACF5E0", VA = "0x180AD05E0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600030C")]
			[Cpp2IlInjected.Address(RVA = "0xACDA20", Offset = "0xACCA20", VA = "0x180ACDA20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B8")]
		private bool YJTPNVLEYTP
		{
			[Cpp2IlInjected.Token(Token = "0x600030D")]
			[Cpp2IlInjected.Address(RVA = "0x8C4ED40", Offset = "0x8C4DD40", VA = "0x188C4ED40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B9")]
		public bool KBEJXXOVYQG
		{
			[Cpp2IlInjected.Token(Token = "0x6000310")]
			[Cpp2IlInjected.Address(RVA = "0x18BBDD0", Offset = "0x18BADD0", VA = "0x1818BBDD0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x8C4F2F0", Offset = "0x8C4E2F0", VA = "0x188C4F2F0")]
		public EUFXKQCBLVY(FUYIEYJKYTM a, [In] RigidbodyExData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x8C4EAF0", Offset = "0x8C4DAF0", VA = "0x188C4EAF0", Slot = "5")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x8C4F0D0", Offset = "0x8C4E0D0", VA = "0x188C4F0D0", Slot = "7")]
		public void VMXUXBGADVC(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x8C4ED10", Offset = "0x8C4DD10", VA = "0x188C4ED10", Slot = "8")]
		public void LKMJORGOFMD(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x8C4EDA0", Offset = "0x8C4DDA0", VA = "0x188C4EDA0", Slot = "9")]
		public void TDLASUGLSBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x8C4F100", Offset = "0x8C4E100", VA = "0x188C4F100", Slot = "10")]
		public void XCTWCLZCBOX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x8C4EB90", Offset = "0x8C4DB90", VA = "0x188C4EB90", Slot = "11")]
		public void FVNWEXUXIHA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	internal sealed class SITBBYJHIXD : FXTQWLZMIBS, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private readonly THJLXNQARFP BBOWPLDTZJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private readonly UOYNNJIMGKD IQYRDBXLMYL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private float XHBSRLBNACI;

		[Cpp2IlInjected.Token(Token = "0x170000BA")]
		public IBLTTUOKYXC FDYPGTDTTCF
		{
			[Cpp2IlInjected.Token(Token = "0x6000316")]
			[Cpp2IlInjected.Address(RVA = "0xAD2F30", Offset = "0xAD1F30", VA = "0x180AD2F30", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000317")]
			[Cpp2IlInjected.Address(RVA = "0xACDA30", Offset = "0xACCA30", VA = "0x180ACDA30", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		public WOMIOHSHOXB OYMYIKHDGOA
		{
			[Cpp2IlInjected.Token(Token = "0x6000318")]
			[Cpp2IlInjected.Address(RVA = "0xAD05B0", Offset = "0xACF5B0", VA = "0x180AD05B0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000319")]
			[Cpp2IlInjected.Address(RVA = "0xAD05C0", Offset = "0xACF5C0", VA = "0x180AD05C0", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BC")]
		public Vector3 WONQMRQGLQW
		{
			[Cpp2IlInjected.Token(Token = "0x600031A")]
			[Cpp2IlInjected.Address(RVA = "0x8C5D030", Offset = "0x8C5C030", VA = "0x188C5D030", Slot = "8")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600031B")]
			[Cpp2IlInjected.Address(RVA = "0x8C5D270", Offset = "0x8C5C270", VA = "0x188C5D270", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BD")]
		public Vector3 BQCPGSTLOOZ
		{
			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(RVA = "0x8C5E5F0", Offset = "0x8C5D5F0", VA = "0x188C5E5F0", Slot = "10")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600031D")]
			[Cpp2IlInjected.Address(RVA = "0x8C5D1E0", Offset = "0x8C5C1E0", VA = "0x188C5D1E0", Slot = "11")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BE")]
		public Vector3 UKOIJUGVDGO
		{
			[Cpp2IlInjected.Token(Token = "0x600031E")]
			[Cpp2IlInjected.Address(RVA = "0x8C5E030", Offset = "0x8C5D030", VA = "0x188C5E030", Slot = "12")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600031F")]
			[Cpp2IlInjected.Address(RVA = "0x8C5EEF0", Offset = "0x8C5DEF0", VA = "0x188C5EEF0", Slot = "13")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BF")]
		public Vector3 AZRMBKJUCIX
		{
			[Cpp2IlInjected.Token(Token = "0x6000320")]
			[Cpp2IlInjected.Address(RVA = "0x8C5E970", Offset = "0x8C5D970", VA = "0x188C5E970", Slot = "14")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0x8C5E5C0", Offset = "0x8C5D5C0", VA = "0x188C5E5C0", Slot = "15")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C0")]
		public float YZURPXCJGPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000322")]
			[Cpp2IlInjected.Address(RVA = "0xB22650", Offset = "0xB21650", VA = "0x180B22650", Slot = "16")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000323")]
			[Cpp2IlInjected.Address(RVA = "0x8C5EDE0", Offset = "0x8C5DDE0", VA = "0x188C5EDE0", Slot = "17")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C1")]
		public bool OGSEEKMKHPQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000324")]
			[Cpp2IlInjected.Address(RVA = "0x2377CF0", Offset = "0x2376CF0", VA = "0x182377CF0", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C2")]
		private RUCOGLQCYDY HBYSRELWTPQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000339")]
			[Cpp2IlInjected.Address(RVA = "0x81AD1C0", Offset = "0x81AC1C0", VA = "0x1881AD1C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C3")]
		private bool JTEVPNPYUBI
		{
			[Cpp2IlInjected.Token(Token = "0x600033A")]
			[Cpp2IlInjected.Address(RVA = "0x8C5FB80", Offset = "0x8C5EB80", VA = "0x188C5FB80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x8C60020", Offset = "0x8C5F020", VA = "0x188C60020")]
		public SITBBYJHIXD(FUYIEYJKYTM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x8C5CF90", Offset = "0x8C5BF90", VA = "0x188C5CF90", Slot = "19")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x8C5D210", Offset = "0x8C5C210", VA = "0x188C5D210", Slot = "36")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x8C5F190", Offset = "0x8C5E190", VA = "0x188C5F190", Slot = "28")]
		public void SQRKTFILJWO(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x168C920", Offset = "0x168B920", VA = "0x18168C920", Slot = "20")]
		public void ORWUGYWXRFS(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x168C4F0", Offset = "0x168B4F0", VA = "0x18168C4F0", Slot = "30")]
		public void OBLWSIENCCD(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x8C5D9D0", Offset = "0x8C5C9D0", VA = "0x188C5D9D0", Slot = "35")]
		public Vector3 GHQCCOHSZMM(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x8C5F9C0", Offset = "0x8C5E9C0", VA = "0x188C5F9C0", Slot = "34")]
		public Vector3 WFXCUACKKWC(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x8C5CF90", Offset = "0x8C5BF90", VA = "0x188C5CF90", Slot = "27")]
		public void RZKURQWAUGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x8C5E910", Offset = "0x8C5D910", VA = "0x188C5E910", Slot = "25")]
		public void IUKBCDQIPOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x8C5ED80", Offset = "0x8C5DD80", VA = "0x188C5ED80", Slot = "24")]
		public void MWTPDQNNZER()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x8C5E380", Offset = "0x8C5D380", VA = "0x188C5E380", Slot = "33")]
		public void HPBYHBEIFKH(Vector3 a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x8C5EFB0", Offset = "0x8C5DFB0", VA = "0x188C5EFB0", Slot = "32")]
		public void PXOLKQPCRQK(Vector3 a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x8C5F820", Offset = "0x8C5E820", VA = "0x188C5F820", Slot = "31")]
		public void VQJCAXUEGAX(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x8C5D330", Offset = "0x8C5C330", VA = "0x188C5D330", Slot = "22")]
		public void GGGGADFQKIH(RbexImpulseType a, Vector3 b, float c, float d = 8f, float e = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x8C5EB00", Offset = "0x8C5DB00", VA = "0x188C5EB00", Slot = "21")]
		public void MTPGKHLFXNQ(RbexRotationType a, Vector3 b, float c = 1f / 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x8C5FBA0", Offset = "0x8C5EBA0", VA = "0x188C5FBA0", Slot = "23")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void ZFZTVIESIZL(RbexRotationType a, Vector3 b, float c = 7f, float d = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x17F1390", Offset = "0x17F0390", VA = "0x1817F1390")]
		private static void ZPPNRRWEYOP(Vector3 a, Vector3 b, [Out] Vector3 c, [Out] Vector3 d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x8C5F450", Offset = "0x8C5E450", VA = "0x188C5F450", Slot = "29")]
		public Vector3 TZGOJLBMHEE(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x8C5E1F0", Offset = "0x8C5D1F0", VA = "0x188C5E1F0", Slot = "26")]
		public void HCNWWIHBBYX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x8C5EDE0", Offset = "0x8C5DDE0", VA = "0x188C5EDE0")]
		private void NAXZHCMBNTA(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x8C5E770", Offset = "0x8C5D770", VA = "0x188C5E770")]
		private void IGVMRHMCRDG(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x8C5F010", Offset = "0x8C5E010", VA = "0x188C5F010")]
		private Vector3 QRQYBTEVPKH()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x8C5F530", Offset = "0x8C5E530", VA = "0x188C5F530")]
		private void USCMZIHJDYP(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x8C5F2C0", Offset = "0x8C5E2C0", VA = "0x188C5F2C0")]
		private Vector3 SRKOCNNUBJD()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x8C5DBB0", Offset = "0x8C5CBB0", VA = "0x188C5DBB0")]
		private void GRSPSJIRCHH(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80")]
		private void CHANKBRITAS(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80")]
		private void FSDMHQTSLQU()
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
