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
		[Cpp2IlInjected.Address(RVA = "0xAE81C0", Offset = "0xAE6FC0", VA = "0x180AE81C0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAE8B60", Offset = "0xAE7960", VA = "0x180AE8B60")]
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
		[Cpp2IlInjected.Address(RVA = "0x8D4BCA0", Offset = "0x8D4AAA0", VA = "0x188D4BCA0", Slot = "4")]
		public override void PUOFOOQAOVA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xAE81C0", Offset = "0xAE6FC0", VA = "0x180AE81C0")]
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
		private int[] RBTJYOZOMSN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private ServiceBitset MXKLQTZDJEC;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F90", Offset = "0xABFD90", VA = "0x180AC0F90", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x87419F0", Offset = "0x87407F0", VA = "0x1887419F0", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8D5C1A0", Offset = "0x8D5AFA0", VA = "0x188D5C1A0")]
		private void GQKVENIQDUS(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8D5C480", Offset = "0x8D5B280", VA = "0x188D5C480", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8D5C4E0", Offset = "0x8D5B2E0", VA = "0x188D5C4E0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[DisallowMultipleComponent]
	public sealed class RigidbodyEx : MonoBehaviour, GDYMXZWVLQY, YFIQJDPXTBF, USNMZRQMMUB
	{
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static readonly Log UUZMPXLYLAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private bool OCUMNLAXPXR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private IQLOSMXEQPE RYNHOJUPOMN;

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
		private Transform RGWTYBDAKCH;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal IQLOSMXEQPE VXIBEOVSMYJ
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x8D521D0", Offset = "0x8D50FD0", VA = "0x188D521D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private IQLOSMXEQPE TDAARHCRYHD
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F90", Offset = "0xABFD90", VA = "0x180AC0F90", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int PBJRUJQBWLA
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x8D53550", Offset = "0x8D52350", VA = "0x188D53550")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RigidbodyEx YEADTHNZCEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x8D538B0", Offset = "0x8D526B0", VA = "0x188D538B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx NKNEDPIWGGX
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x8D537F0", Offset = "0x8D525F0", VA = "0x188D537F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RigidbodyEx HATHWVTRAGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x8D544C0", Offset = "0x8D532C0", VA = "0x188D544C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x8D559F0", Offset = "0x8D547F0", VA = "0x188D559F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool ZLBFHSBLVHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x813D600", Offset = "0x813C400", VA = "0x18813D600", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x813D750", Offset = "0x813C550", VA = "0x18813D750")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Transform LUTJRPOGMJP
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x2535FB0", Offset = "0x2534DB0", VA = "0x182535FB0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Transform YEHKKJNXZTG
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x2535FB0", Offset = "0x2534DB0", VA = "0x182535FB0", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Transform EOCZPHKJMMS
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x2535FB0", Offset = "0x2534DB0", VA = "0x182535FB0", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public TransformTrackRate KOGAJYHNSCI
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x8D535B0", Offset = "0x8D523B0", VA = "0x188D535B0")]
			get
			{
				return default(TransformTrackRate);
			}
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x8D551A0", Offset = "0x8D53FA0", VA = "0x188D551A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool KIZZGSRSATH
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x8D53BC0", Offset = "0x8D529C0", VA = "0x188D53BC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool OJMGCEJESPL
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x8D536D0", Offset = "0x8D524D0", VA = "0x188D536D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public TPQHYBXVCEA QLLABUJCDCN
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x8D53B00", Offset = "0x8D52900", VA = "0x188D53B00")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x8D55360", Offset = "0x8D54160", VA = "0x188D55360")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public XPPHMJGPLLF YWDVVAZVJEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x8D53AA0", Offset = "0x8D528A0", VA = "0x188D53AA0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x8D552F0", Offset = "0x8D540F0", VA = "0x188D552F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool IEPPXZXXNHQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x8D539F0", Offset = "0x8D527F0", VA = "0x188D539F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Rigidbody LYLSFVCJLUL
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x8D53A50", Offset = "0x8D52850", VA = "0x188D53A50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool RKTBCNSWZAS
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x8D53730", Offset = "0x8D52530", VA = "0x188D53730")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x8D55210", Offset = "0x8D54010", VA = "0x188D55210")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool AWPKMTHCTYD
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x19D0F20", Offset = "0x19CFD20", VA = "0x1819D0F20", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float DLSZJJWPDSD
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x8D54460", Offset = "0x8D53260", VA = "0x188D54460")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float VDJXWQZWZHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x8D54400", Offset = "0x8D53200", VA = "0x188D54400")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x8D55980", Offset = "0x8D54780", VA = "0x188D55980")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public float NYSLLNOUBUZ
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x8D53E20", Offset = "0x8D52C20", VA = "0x188D53E20")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x8D55600", Offset = "0x8D54400", VA = "0x188D55600")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public float CAAQRLYAQAJ
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x8D53C20", Offset = "0x8D52A20", VA = "0x188D53C20")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x8D553D0", Offset = "0x8D541D0", VA = "0x188D553D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public bool MHHIWXZHNPC
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x8D54A40", Offset = "0x8D53840", VA = "0x188D54A40")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x8D55F30", Offset = "0x8D54D30", VA = "0x188D55F30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Vector3 PGGIDMIUKKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x8D541E0", Offset = "0x8D52FE0", VA = "0x188D541E0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x8D55750", Offset = "0x8D54550", VA = "0x188D55750")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public Vector3 VFOMDGGOEQB
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x8D54B80", Offset = "0x8D53980", VA = "0x188D54B80")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public CollisionDetectionMode SPJERPOFGCP
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x8D53D60", Offset = "0x8D52B60", VA = "0x188D53D60")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x8D55520", Offset = "0x8D54320", VA = "0x188D55520")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public float GEKAIAQUVBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x8D53790", Offset = "0x8D52590", VA = "0x188D53790")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x8D55280", Offset = "0x8D54080", VA = "0x188D55280")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public RigidbodyConstraints VZRQTTPOYPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x8D53DC0", Offset = "0x8D52BC0", VA = "0x188D53DC0")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x8D55590", Offset = "0x8D54390", VA = "0x188D55590")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public Vector3 MSWZWVLJOAX
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x8D54580", Offset = "0x8D53380", VA = "0x188D54580")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public Vector3 SKREHUDEIJL
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x8D54580", Offset = "0x8D53380", VA = "0x188D54580")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x8D55D10", Offset = "0x8D54B10", VA = "0x188D55D10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public float HPWEFRDDPQE
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x8D542C0", Offset = "0x8D530C0", VA = "0x188D542C0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x8D55830", Offset = "0x8D54630", VA = "0x188D55830")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public float YAKHRLMAKKZ
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x8D549E0", Offset = "0x8D537E0", VA = "0x188D549E0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x8D55EC0", Offset = "0x8D54CC0", VA = "0x188D55EC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Quaternion VKABRAWLBOK
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x8D54660", Offset = "0x8D53460", VA = "0x188D54660")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x8D55A90", Offset = "0x8D54890", VA = "0x188D55A90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Quaternion NEFDZNRLXHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x8D54900", Offset = "0x8D53700", VA = "0x188D54900")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x8D55DF0", Offset = "0x8D54BF0", VA = "0x188D55DF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector3 ZFLQGTRSATI
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x8D54740", Offset = "0x8D53540", VA = "0x188D54740")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x8D55B60", Offset = "0x8D54960", VA = "0x188D55B60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Quaternion RCYSGTDDRXR
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x8D54820", Offset = "0x8D53620", VA = "0x188D54820")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x8D55C40", Offset = "0x8D54A40", VA = "0x188D55C40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 WBBWNCGQIJG
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x8D54AA0", Offset = "0x8D538A0", VA = "0x188D54AA0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x8D55FA0", Offset = "0x8D54DA0", VA = "0x188D55FA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 APNJIVTLRJP
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x8D54320", Offset = "0x8D53120", VA = "0x188D54320")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x8D558A0", Offset = "0x8D546A0", VA = "0x188D558A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector3 EVWWPZVKWMM
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x8D53C80", Offset = "0x8D52A80", VA = "0x188D53C80")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x8D55440", Offset = "0x8D54240", VA = "0x188D55440")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector3 MINGCQTWWST
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x8D54100", Offset = "0x8D52F00", VA = "0x188D54100")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x8D55670", Offset = "0x8D54470", VA = "0x188D55670")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector3 DXFXPNJSBZQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x8D53FC0", Offset = "0x8D52DC0", VA = "0x188D53FC0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Quaternion FTDOUQCYUDG
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x8D53EE0", Offset = "0x8D52CE0", VA = "0x188D53EE0")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public Vector3 SVSOOPEUNSI
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x8D54D40", Offset = "0x8D53B40", VA = "0x188D54D40")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public Vector3 UHONTRJSIFC
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x8D54C60", Offset = "0x8D53A60", VA = "0x188D54C60")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool USBJNZZBWPW
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x8D540A0", Offset = "0x8D52EA0", VA = "0x188D540A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool FNMQUUFGQCR
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x8D53B60", Offset = "0x8D52960", VA = "0x188D53B60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool TJHSJXBZSHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x8D53670", Offset = "0x8D52470", VA = "0x188D53670")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool ROVHRCIFMSP
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x8D53610", Offset = "0x8D52410", VA = "0x188D53610")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool KEAWZTBWULA
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x8D534F0", Offset = "0x8D522F0", VA = "0x188D534F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public bool QGRBCPMHCCZ
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x8D53E80", Offset = "0x8D52C80", VA = "0x188D53E80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool EBUTVQAGWPR
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xE2C170", Offset = "0xE2AF70", VA = "0x180E2C170")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event RbexParentChangeAction MHQKOLLMMAP
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x8D53410", Offset = "0x8D52210", VA = "0x188D53410")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x8D550C0", Offset = "0x8D53EC0", VA = "0x188D550C0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event RbexAction ZRLWMSYFNVF
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x8D53180", Offset = "0x8D51F80", VA = "0x188D53180")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x8D54E20", Offset = "0x8D53C20", VA = "0x188D54E20")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event RbexAction JLBGDFBJARL
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x8D531E0", Offset = "0x8D51FE0", VA = "0x188D531E0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x8D54E90", Offset = "0x8D53C90", VA = "0x188D54E90")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event RbexAction PBQNRLTAUNN
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x8D53330", Offset = "0x8D52130", VA = "0x188D53330")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x8D54FE0", Offset = "0x8D53DE0", VA = "0x188D54FE0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<UpdateLOD, UpdateLOD> EOUEQDCPNZX
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x8D532C0", Offset = "0x8D520C0", VA = "0x188D532C0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x8D54F70", Offset = "0x8D53D70", VA = "0x188D54F70")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event RbexAction SELAIFHWNBC
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x8D533A0", Offset = "0x8D521A0", VA = "0x188D533A0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x8D55050", Offset = "0x8D53E50", VA = "0x188D55050")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event RbexAction ZOHFCRBVPCC
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x8D53480", Offset = "0x8D52280", VA = "0x188D53480")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x8D55130", Offset = "0x8D53F30", VA = "0x188D55130")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event RbexAction ETFLWCFXNGJ
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x8D53250", Offset = "0x8D52050", VA = "0x188D53250")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x8D54F00", Offset = "0x8D53D00", VA = "0x188D54F00")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xAC0650", Offset = "0xABF450", VA = "0x180AC0650", Slot = "8")]
		private void RCBDGFGWMUL(IQLOSMXEQPE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8D51BE0", Offset = "0x8D509E0", VA = "0x188D51BE0", Slot = "9")]
		public RigidbodyExData GetData()
		{
			return default(RigidbodyExData);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8D50BA0", Offset = "0x8D4F9A0", VA = "0x188D50BA0")]
		internal void AEVTKTBTFXQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8D52EB0", Offset = "0x8D51CB0", VA = "0x188D52EB0")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public void TestOverrideUnityRigidbody(Rigidbody rb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8D51930", Offset = "0x8D50730", VA = "0x188D51930")]
		public GDYMXZWVLQY GetChild(int index)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x8D52B70", Offset = "0x8D51970", VA = "0x188D52B70")]
		public void SetInertiaTensor((Quaternion rot, Vector3 moments) tensor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x8D51580", Offset = "0x8D50380", VA = "0x188D51580")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x8D52E00", Offset = "0x8D51C00", VA = "0x188D52E00")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8D521D0", Offset = "0x8D50FD0", VA = "0x188D521D0")]
		private IQLOSMXEQPE WWUEQIJVCIT()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8D52280", Offset = "0x8D51080", VA = "0x188D52280")]
		private void RWFLESYWDGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8D52110", Offset = "0x8D50F10", VA = "0x188D52110")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x8D52050", Offset = "0x8D50E50", VA = "0x188D52050")]
		public void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x8D50BA0", Offset = "0x8D4F9A0", VA = "0x188D50BA0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8D520B0", Offset = "0x8D50EB0", VA = "0x188D520B0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8D52170", Offset = "0x8D50F70", VA = "0x188D52170")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8D50C30", Offset = "0x8D4FA30", VA = "0x188D50C30")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x8D52400", Offset = "0x8D51200", VA = "0x188D52400")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8D518D0", Offset = "0x8D506D0", VA = "0x188D518D0")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x8D51FF0", Offset = "0x8D50DF0", VA = "0x188D51FF0")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x8D52CD0", Offset = "0x8D51AD0", VA = "0x188D52CD0")]
		public void SetParent(RigidbodyEx value, bool isPhysicallyDetachedOnly = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x8D52710", Offset = "0x8D51510", VA = "0x188D52710")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8D51C70", Offset = "0x8D50A70", VA = "0x188D51C70")]
		public bool IsRigidbodyAncestor(RigidbodyEx possibleAncestor)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8D51D70", Offset = "0x8D50B70", VA = "0x188D51D70")]
		public bool IsRigidbodyDescendant(RigidbodyEx possibleDescendant)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8D50EA0", Offset = "0x8D4FCA0", VA = "0x188D50EA0")]
		public void AddInterpolationRestriction(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8D52470", Offset = "0x8D51270", VA = "0x188D52470")]
		public void RemoveInterpolationRestriction(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x8D50F10", Offset = "0x8D4FD10", VA = "0x188D50F10")]
		public void AddKinematic(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x8D524E0", Offset = "0x8D512E0", VA = "0x188D524E0")]
		public void RemoveKinematic(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x8D52C50", Offset = "0x8D51A50", VA = "0x188D52C50")]
		public void SetKinematic(object token, bool setKinematic)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x8D52A70", Offset = "0x8D51870", VA = "0x188D52A70")]
		public void SetDiscontinuousPositionAndRotation(Vector3 newPosition, Quaternion newRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x8D52970", Offset = "0x8D51770", VA = "0x188D52970")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 newLocalPosition, Quaternion newLocalRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x8D51AD0", Offset = "0x8D508D0", VA = "0x188D51AD0")]
		public Vector3 GetConstrainedVelocity(Vector3 velocity)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x8D519C0", Offset = "0x8D507C0", VA = "0x188D519C0")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 angularVelocity)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8D50DB0", Offset = "0x8D4FBB0", VA = "0x188D50DB0")]
		public void AddForce(Vector3 force, ForceMode forceMode = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x8D50CA0", Offset = "0x8D4FAA0", VA = "0x188D50CA0")]
		public void AddForceAtPosition(Vector3 force, Vector3 position, ForceMode forceMode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8D510E0", Offset = "0x8D4FEE0", VA = "0x188D510E0")]
		public void AddTorque(Vector3 torque, ForceMode forceMode = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x8D50F80", Offset = "0x8D4FD80", VA = "0x188D50F80")]
		public void AddRelativeTorque(Vector3 torque, ForceMode forceMode = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8D52F80", Offset = "0x8D51D80", VA = "0x188D52F80")]
		public Vector3 WorldToLocalVelocity(Vector3 worldVelocity)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8D51EE0", Offset = "0x8D50CE0", VA = "0x188D51EE0")]
		public Vector3 LocalToWorldVelocity(Vector3 localVelocity)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8D51870", Offset = "0x8D50670", VA = "0x188D51870")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8D51810", Offset = "0x8D50610", VA = "0x188D51810")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8D517B0", Offset = "0x8D505B0", VA = "0x188D517B0")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8D51750", Offset = "0x8D50550", VA = "0x188D51750")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x8D52870", Offset = "0x8D51670", VA = "0x188D52870")]
		public void ResetVelocityWorldSpace(Vector3 worldLinearVelocity, Vector3 worldAngularVelocity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x8D52770", Offset = "0x8D51570", VA = "0x188D52770")]
		public void ResetVelocityLocalSpace(Vector3 localLinearVelocity, Vector3 localAngularVelocity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x8D52630", Offset = "0x8D51430", VA = "0x188D52630")]
		public void ResetLinearVelocityLocalSpace(Vector3 localLinearVelocity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x8D52E10", Offset = "0x8D51C10", VA = "0x188D52E10")]
		public bool SweepTest(Vector3 direction, [Out] RaycastHit hitInfo, float maxDistance)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x8D51E70", Offset = "0x8D50C70", VA = "0x188D51E70")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x8D52DA0", Offset = "0x8D51BA0", VA = "0x188D52DA0")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x8D52F20", Offset = "0x8D51D20", VA = "0x188D52F20")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x8D51070", Offset = "0x8D4FE70", VA = "0x188D51070")]
		public void AddShouldHaveUnityRigidbodyToken(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x8D52550", Offset = "0x8D51350", VA = "0x188D52550")]
		public void RemoveShouldHaveUnityRigidbodyToken(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x8D51410", Offset = "0x8D50210", VA = "0x188D51410")]
		public void ApplyForceVelocityChange(RbexImpulseType impulseType, Vector3 impulseDirection, float impulseSpeed, float impulseDirectionMaxSpeed = 8f, float impulseReflectiveRestitution = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x8D51370", Offset = "0x8D50170", VA = "0x188D51370")]
		public void ApplyAngularVelocityChange(RbexRotationType rotationType, Vector3 newAngularVelocity, float maxAngularSpeed = 1f / 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x8D514D0", Offset = "0x8D502D0", VA = "0x188D514D0")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void ApplyTorqueAngularVelocityChangeDeprecated(RbexRotationType rotationType, Vector3 rotation, float maxSpeed = 7f, float multiplyingFactor = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x8D512A0", Offset = "0x8D500A0", VA = "0x188D512A0")]
		public bool AllowedScaleChange(float scaleFactor)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x8D511D0", Offset = "0x8D4FFD0", VA = "0x188D511D0")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx parentOverride, object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x8D525C0", Offset = "0x8D513C0", VA = "0x188D525C0")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x8D51ED0", Offset = "0x8D50CD0", VA = "0x188D51ED0", Slot = "13")]
		private void LHAQBBPOAMU(JSEALEMQFTE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x8D53110", Offset = "0x8D51F10", VA = "0x188D53110")]
		public RigidbodyEx()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0xB6E530", Offset = "0xB6D330", VA = "0x180B6E530", Slot = "4")]
		private GameObject IIMXDLSNPXB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0xAEA320", Offset = "0xAE9120", VA = "0x180AEA320", Slot = "10")]
		private bool DAKHPFERBOU()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	internal static class DHOEQSSLYEV
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x8D410A0", Offset = "0x8D3FEA0", VA = "0x188D410A0")]
		public static IQLOSMXEQPE VXIBEOVSMYJ(this RigidbodyEx a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[RegisterService(typeof(WXDBYWISUVR), new string[] { })]
	public class RigidbodyExManager : WXDBYWISUVR, IUKSRZVFRMZ
	{
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static readonly Log IRJSVORGEBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private VCTVAWKQSAU FFRQMGYVOAZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private SJEUYUORZHF RXKTVRFSXZN;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public VCTVAWKQSAU SNEHNJXCVIV
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public SJEUYUORZHF FAUWBUBESMD
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x8D50980", Offset = "0x8D4F780", VA = "0x188D50980", Slot = "7")]
		public void InitReferences(FCHQYTALOWK services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x8D509F0", Offset = "0x8D4F7F0", VA = "0x188D509F0", Slot = "6")]
		public IQLOSMXEQPE KABYPYFHTCZ(RigidbodyEx a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public RigidbodyExManager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class PhysicsManager : SingletonMonoBehaviour<PhysicsManager>
	{
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static DQHMEXLDKHB UpdateAfterFixedUpdateRan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private int ENWWNMKVMMT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private int GGPWBPOZGLV;

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x8D4E880", Offset = "0x8D4D680", VA = "0x188D4E880")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x8D4E900", Offset = "0x8D4D700", VA = "0x188D4E900")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x8D4E8A0", Offset = "0x8D4D6A0", VA = "0x188D4E8A0")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string message, [Optional] UnityEngine.Object context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string message, [Optional] UnityEngine.Object context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x8D4E9F0", Offset = "0x8D4D7F0", VA = "0x188D4E9F0")]
		public PhysicsManager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public static class ARBLXFXOOYD
	{
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		private class PIAYGGQBCOP : TPQHYBXVCEA, IDisposable
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "7")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0xACE450", Offset = "0xACD250", VA = "0x180ACE450", Slot = "4")]
			public Vector3 CIOGGOYMFEG()
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0xACE450", Offset = "0xACD250", VA = "0x180ACE450", Slot = "5")]
			public Vector3 ZJETCNNRZNT()
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0xAD8CA0", Offset = "0xAD7AA0", VA = "0x180AD8CA0", Slot = "6")]
			public bool LSGXQNWZLLO(float a, float b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public PIAYGGQBCOP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public static TPQHYBXVCEA UMBPAFXRVRA
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x8D40BA0", Offset = "0x8D3F9A0", VA = "0x188D40BA0")]
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
	public interface VDFNRILYUDG
	{
		[Cpp2IlInjected.Token(Token = "0x17000039")]
		CollisionDetectionMode XYZAJUGOTHR
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
		void ORIJLREMAVD(bool a);

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void GBGWGPTOJLO(bool a);

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void TOEZMFUKDBQ(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool JTKFPPLCFRL(Vector3 a, [Out] RaycastHit b, float c);
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public interface FFIJQMFXKAR : IDisposable, SPISOTIFQAV
	{
		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		TransformTrackRate KOGAJYHNSCI
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		event Action<UpdateLOD, UpdateLOD> EOUEQDCPNZX;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void Awake();
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[ServiceLifetime(Lifetime.Application)]
	public interface SJEUYUORZHF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		TZTEZWAGONU ETNNMIBYIDU(IQLOSMXEQPE a);

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		BVLWLVXGHOU BMCHKCSIIEQ(IQLOSMXEQPE a);

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		JQILPELHVDT GETTYURTTIV(IQLOSMXEQPE a);

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		HAMXNCHWVPQ GNGJGGBMDHM(IQLOSMXEQPE a);

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "4")]
		XIHYGGHCGEO OOSQREXXYIK(IQLOSMXEQPE a);

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "5")]
		FFIJQMFXKAR JPJSFKMMSZT(IQLOSMXEQPE a);

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "6")]
		YJVZTFZLWOA CRQGDHLGDBS(IQLOSMXEQPE a);

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "7")]
		YODEMQIHVZA AJNRSKONDAW(IQLOSMXEQPE a);

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "8")]
		VDFNRILYUDG XQPXBTJGMNW(IQLOSMXEQPE a);

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "9")]
		QBECMFVIFGT SAEYFDHOROH(IQLOSMXEQPE a);

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "10")]
		DVYOJNKRSOH VPWAOKJMEIP(IQLOSMXEQPE a, [In] RigidbodyExData data);

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "11")]
		HTRGPEPOPTT FZTBGBNURSZ(IQLOSMXEQPE a, [In] RigidbodyExData data);

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "12")]
		FQNUAFXQDBF ISDZDTJKALZ(IQLOSMXEQPE a, [In] RigidbodyExData data);

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "13")]
		FAXDCATHUYN IRJTBUHVAJH(IQLOSMXEQPE a, [In] RigidbodyExData data);

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "14")]
		OWLGPBGJMUN BWUMDHNXBWJ(IQLOSMXEQPE a, [In] RigidbodyExData data);

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "15")]
		IQLOSMXEQPE KABYPYFHTCZ(RigidbodyEx a, RigidbodyExData b, WXDBYWISUVR c);
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface YODEMQIHVZA
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void SWTRTRDVTVD(Vector3 a, ForceMode b = ForceMode.Force);

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void EHXZYDRIIFF(Vector3 a, Vector3 b, ForceMode c);

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void VVMMMZDTOAY(Vector3 a, ForceMode b = ForceMode.Force);

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void USHIUMMKMCU(Vector3 a, ForceMode b = ForceMode.Force);
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface QBECMFVIFGT
	{
		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		bool DAKABLWZVQI
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
		void TOEZMFUKDBQ(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void CGKVDMFFWEH(Rigidbody a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public interface TZTEZWAGONU : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		IReadOnlyList<IQLOSMXEQPE> QEPMXJBXWKH
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(Slot = "18")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		IQLOSMXEQPE NKNEDPIWGGX
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(Slot = "19")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		IQLOSMXEQPE IGSJTJYCBZZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(Slot = "20")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(Slot = "21")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		event RbexAction ZRLWMSYFNVF;

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		event RbexAction JLBGDFBJARL;

		[Cpp2IlInjected.Token(Token = "0x1400000C")]
		event RbexParentChangeAction ZODFISIYOEV;

		[Cpp2IlInjected.Token(Token = "0x1400000D")]
		event Action VATMTZKQZAE;

		[Cpp2IlInjected.Token(Token = "0x1400000E")]
		event Action WQZXORLUACF;

		[Cpp2IlInjected.Token(Token = "0x1400000F")]
		event Action<IQLOSMXEQPE> XYVLLDQAMUE;

		[Cpp2IlInjected.Token(Token = "0x14000010")]
		event Action<IQLOSMXEQPE> ZMMSTYNYYZZ;

		[Cpp2IlInjected.Token(Token = "0x14000011")]
		event Action AAUKDLCUFGA;

		[Cpp2IlInjected.Token(Token = "0x14000012")]
		event Action<IQLOSMXEQPE> HDSITCDTDCZ;

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "22")]
		void SetParent(IQLOSMXEQPE newParent, bool isPhysicallyDetachedOnly = false);
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public interface JQILPELHVDT
	{
		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		Vector3 NZUWMXHMJWA
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		Vector3 NNNLMOORXBG
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void LEEETDPUBYO(IQLOSMXEQPE a, object b);

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void BMXCCXJPQID(object a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public interface FAXDCATHUYN
	{
		[Cpp2IlInjected.Token(Token = "0x17000041")]
		Vector3 AXEUGRGNYUG
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		Vector3 QNINAVWDIHT
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		float SAZWGGEAXTR
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		float ZEFMEOEDTOY
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(Slot = "7")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		Vector3 LWRFODEVPFY
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		Quaternion SCLNYIMJZCE
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000013")]
		event RbexAction SJBOTYMTXYB;

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void AVHYVADFBGQ((Quaternion rot, Vector3 moments) tensor);

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(Slot = "11")]
		void EYRUDYQSZWH();

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void BBFCKZSWOKY();

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(Slot = "13")]
		void QBUPGVAOESG();

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void TOEZMFUKDBQ(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void CGKVDMFFWEH(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void OnDrawGizmosSelected();
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public interface FQNUAFXQDBF
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Awake();

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void GEULPSIFYPG(object a);

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void CLUEPTXMRDN(object a);

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void DWRGBHJNPGP(IQLOSMXEQPE a);

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void TVKPHKTFGMG(IQLOSMXEQPE a);

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void DGWPXJSVBZJ();
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public interface YJVZTFZLWOA
	{
		[Cpp2IlInjected.Token(Token = "0x17000047")]
		bool IXMTAWZSMUU
		{
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000014")]
		event RbexAction EPAOJVVYLSY;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void RXVDHDMKVUD(object a);

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void QNGWBZMYCDG(object a);

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void XJYMLZNFAFU(object a, bool b);

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void TOEZMFUKDBQ(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void CGKVDMFFWEH(Rigidbody a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface HTRGPEPOPTT : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000048")]
		bool KIZZGSRSATH
		{
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		bool OJMGCEJESPL
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000015")]
		event RbexAction UMZJHLNJBPU;

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void Awake();

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void EHKZYIDCFLX(IQLOSMXEQPE a);

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void DSBGFYTIKKV(IQLOSMXEQPE a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface OWLGPBGJMUN
	{
		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		bool RKTBCNSWZAS
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		bool YTPHZTRKDQR
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		RigidbodyConstraints ZZNDPAKCEMV
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
		void TOEZMFUKDBQ(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void CGKVDMFFWEH(Rigidbody a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface HAMXNCHWVPQ
	{
		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		float ZAPFRGRGMIF
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		float XTVIJLVUJGZ
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
		void TOEZMFUKDBQ(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void CGKVDMFFWEH(Rigidbody a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public interface XIHYGGHCGEO
	{
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		static bool QMKPAYPQYSC;

		[Cpp2IlInjected.Token(Token = "0x14000016")]
		event RbexAction JUWIFCNHEWK;

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void Awake();

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool MDBNRHUMEYC();

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void IOKXWUTMHFO();

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void Sleep();

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool HYUAHANRLMG();

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool FEXWPRZWKWL();

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void JPLBCAPTUMZ(bool a);

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void SPPGBOIMTQW();
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public interface DVYOJNKRSOH
	{
		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		Rigidbody LYLSFVCJLUL
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		bool UIYYICBHWQO
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
		void RHVNAXHJIII(object a);

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void ZXDRGCLXBDF(object a);

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void ZMMCZXEMGKG();
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public interface BVLWLVXGHOU : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000051")]
		TPQHYBXVCEA QLLABUJCDCN
		{
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		XPPHMJGPLLF YWDVVAZVJEI
		{
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		Vector3 DVFUTEPXRTY
		{
			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(Slot = "5")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		Vector3 SNLHSEGSKSZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(Slot = "7")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		Vector3 JEKLOACQCVU
		{
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(Slot = "9")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		Vector3 VGNNJDXULRJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(Slot = "11")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		float GEKAIAQUVBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(Slot = "13")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		bool IEPPXZXXNHQ
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
		void JDMHZQTHVZK(object a);

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(Slot = "17")]
		void DQNDSWQYHNI(RbexRotationType a, Vector3 b, float c = 1f / 0f);

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(Slot = "18")]
		void DWZRKRYIUGD(RbexImpulseType a, Vector3 b, float c, float d = 8f, float e = 1f);

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(Slot = "19")]
		void IBZFDEMKQUN(RbexRotationType a, Vector3 b, float c = 7f, float d = 1f);

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(Slot = "20")]
		void TTNPXHXBYBD();

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(Slot = "21")]
		void FEVTTANKFOW();

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(Slot = "22")]
		void NZGXMTNXECX();

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(Slot = "23")]
		void OEVZVDJNBBF();

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(Slot = "24")]
		void TOEZMFUKDBQ(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(Slot = "25")]
		Vector3 VEEYJMDVERW(Vector3 a);

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(Slot = "26")]
		void JRHXWSAWMFF(object a);

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(Slot = "27")]
		void IZZUETQUKXR(Vector3 a);

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(Slot = "28")]
		void GLRZINOHTSW(Vector3 a, Vector3 b);

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(Slot = "29")]
		void IQLJSAKGEXJ(Vector3 a, Vector3 b);

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(Slot = "30")]
		Vector3 DXKAJEUUKVM(Vector3 a);

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(Slot = "31")]
		Vector3 FEHJGEGGUAI(Vector3 a);
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[ServiceLifetime(Lifetime.Application)]
	public interface VCTVAWKQSAU
	{
		[Cpp2IlInjected.Token(Token = "0x17000059")]
		bool KMQRASKGGTN
		{
			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void RMVHACHBEFD(string a);

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void KKCVMRDBMJK(RigidbodyEx a, Action b);

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		QDTPAEHJLXK YYGFXTNJBPZ(int a);

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void KAMORCETSRP(Vector3 a, float b, Color c);
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[ServiceLifetime(Lifetime.Application)]
	public interface WXDBYWISUVR
	{
		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		VCTVAWKQSAU SNEHNJXCVIV
		{
			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		SJEUYUORZHF FAUWBUBESMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(Slot = "2")]
		IQLOSMXEQPE KABYPYFHTCZ(RigidbodyEx a);
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class HLSOFHFNATP : IQLOSMXEQPE, IDisposable, ZYJFBKSFGTX
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		internal readonly WXDBYWISUVR OHUMEPMNHVY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		internal TZTEZWAGONU IIJAVGMKBQG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		internal FQNUAFXQDBF ECITSIUNRBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		internal HTRGPEPOPTT FVAZTUEHCNX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		internal BVLWLVXGHOU WBBWNCGQIJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		internal JQILPELHVDT EAEISCXOACN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		internal FAXDCATHUYN VPBNNGOIITT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		internal HAMXNCHWVPQ RHQXEVJVGKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		internal QBECMFVIFGT DDRJGVGEJFZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		internal XIHYGGHCGEO YRFLPKQBDNU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		internal FFIJQMFXKAR KTXMXIVPBRH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		internal YJVZTFZLWOA EMZPAHNFDRS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		internal YODEMQIHVZA QSGBZSQITJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		internal OWLGPBGJMUN YYPPXHXQQER;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		internal DVYOJNKRSOH JBCULODEAUP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		internal VDFNRILYUDG VVXZNBULCDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		internal IDisposable OLKAYBWEVFR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private bool BXTPTFRWDXR;

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public ObjectLocalId IVAUJLECKMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0xABE8E0", Offset = "0xABD6E0", VA = "0x180ABE8E0", Slot = "22")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public GDYMXZWVLQY WPHJRVAMLEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0xB882D0", Offset = "0xB870D0", VA = "0x180B882D0", Slot = "24")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0xB88330", Offset = "0xB87130", VA = "0x180B88330")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public GameObject FEVRUSAGTIG
		{
			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0xAC7160", Offset = "0xAC5F60", VA = "0x180AC7160", Slot = "25")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0xAC7450", Offset = "0xAC6250", VA = "0x180AC7450")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public Transform ZCGASSMNTRL
		{
			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0xB88130", Offset = "0xB86F30", VA = "0x180B88130", Slot = "26")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0xB880C0", Offset = "0xB86EC0", VA = "0x180B880C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public Rigidbody LYLSFVCJLUL
		{
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x8D45470", Offset = "0x8D44270", VA = "0x188D45470", Slot = "23")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public IQLOSMXEQPE IGSJTJYCBZZ
		{
			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x8D47F90", Offset = "0x8D46D90", VA = "0x188D47F90", Slot = "27")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x8D47B50", Offset = "0x8D46950", VA = "0x188D47B50", Slot = "28")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public int PBJRUJQBWLA
		{
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x8D4A740", Offset = "0x8D49540", VA = "0x188D4A740", Slot = "31")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public IQLOSMXEQPE NKNEDPIWGGX
		{
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x8D454C0", Offset = "0x8D442C0", VA = "0x188D454C0", Slot = "29")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public bool MGSTXVDYFSV
		{
			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x8D46B00", Offset = "0x8D45900", VA = "0x188D46B00", Slot = "32")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public bool KIZZGSRSATH
		{
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x8D46950", Offset = "0x8D45750", VA = "0x188D46950", Slot = "33")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public bool OJMGCEJESPL
		{
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x8D44DC0", Offset = "0x8D43BC0", VA = "0x188D44DC0", Slot = "34")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public TPQHYBXVCEA QLLABUJCDCN
		{
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x8D45D50", Offset = "0x8D44B50", VA = "0x188D45D50", Slot = "35")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x8D487C0", Offset = "0x8D475C0", VA = "0x188D487C0", Slot = "36")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public XPPHMJGPLLF YWDVVAZVJEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x8D4A4A0", Offset = "0x8D492A0", VA = "0x188D4A4A0", Slot = "37")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x8D4A4F0", Offset = "0x8D492F0", VA = "0x188D4A4F0", Slot = "38")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public float GEKAIAQUVBG
		{
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x8D48590", Offset = "0x8D47390", VA = "0x188D48590", Slot = "39")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x8D451B0", Offset = "0x8D43FB0", VA = "0x188D451B0", Slot = "40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public Vector3 SNLHSEGSKSZ
		{
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x8D48680", Offset = "0x8D47480", VA = "0x188D48680", Slot = "41")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x8D48040", Offset = "0x8D46E40", VA = "0x188D48040", Slot = "42")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public Vector3 VGNNJDXULRJ
		{
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x8D465A0", Offset = "0x8D453A0", VA = "0x188D465A0", Slot = "43")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x8D49ED0", Offset = "0x8D48CD0", VA = "0x188D49ED0", Slot = "44")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public Vector3 DVFUTEPXRTY
		{
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x8D47340", Offset = "0x8D46140", VA = "0x188D47340", Slot = "45")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x8D4A550", Offset = "0x8D49350", VA = "0x188D4A550", Slot = "46")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public Vector3 JEKLOACQCVU
		{
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x8D4A3C0", Offset = "0x8D491C0", VA = "0x188D4A3C0", Slot = "47")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x8D49C50", Offset = "0x8D48A50", VA = "0x188D49C50", Slot = "48")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public bool TJHSJXBZSHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x8D469A0", Offset = "0x8D457A0", VA = "0x188D469A0", Slot = "49")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public bool ROVHRCIFMSP
		{
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x8D491C0", Offset = "0x8D47FC0", VA = "0x188D491C0", Slot = "50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public bool KEAWZTBWULA
		{
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x8D47DB0", Offset = "0x8D46BB0", VA = "0x188D47DB0", Slot = "51")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public bool IEPPXZXXNHQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x8D44940", Offset = "0x8D43740", VA = "0x188D44940", Slot = "52")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public Vector3 NZUWMXHMJWA
		{
			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x8D4A900", Offset = "0x8D49700", VA = "0x188D4A900", Slot = "53")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public Vector3 NNNLMOORXBG
		{
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x8D461B0", Offset = "0x8D44FB0", VA = "0x188D461B0", Slot = "54")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public Vector3 AXEUGRGNYUG
		{
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x8D47980", Offset = "0x8D46780", VA = "0x188D47980", Slot = "55")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x8D49B70", Offset = "0x8D48970", VA = "0x188D49B70", Slot = "56")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public Vector3 QNINAVWDIHT
		{
			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x8D47110", Offset = "0x8D45F10", VA = "0x188D47110", Slot = "57")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public float SAZWGGEAXTR
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x8D488B0", Offset = "0x8D476B0", VA = "0x188D488B0", Slot = "58")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public float ZEFMEOEDTOY
		{
			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x8D4AE30", Offset = "0x8D49C30", VA = "0x188D4AE30", Slot = "59")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x8D49D30", Offset = "0x8D48B30", VA = "0x188D49D30", Slot = "60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public Vector3 LWRFODEVPFY
		{
			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x8D49030", Offset = "0x8D47E30", VA = "0x188D49030", Slot = "61")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public Quaternion SCLNYIMJZCE
		{
			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x8D489C0", Offset = "0x8D477C0", VA = "0x188D489C0", Slot = "62")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public float ZAPFRGRGMIF
		{
			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x8D449F0", Offset = "0x8D437F0", VA = "0x188D449F0", Slot = "64")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x8D49A70", Offset = "0x8D48870", VA = "0x188D49A70", Slot = "65")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public float XTVIJLVUJGZ
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x8D485E0", Offset = "0x8D473E0", VA = "0x188D485E0", Slot = "66")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x8D471F0", Offset = "0x8D45FF0", VA = "0x188D471F0", Slot = "67")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public bool DAKABLWZVQI
		{
			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x8D49170", Offset = "0x8D47F70", VA = "0x188D49170", Slot = "68")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x8D48120", Offset = "0x8D46F20", VA = "0x188D48120", Slot = "69")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public TransformTrackRate KOGAJYHNSCI
		{
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x8D4A8B0", Offset = "0x8D496B0", VA = "0x188D4A8B0", Slot = "70")]
			get
			{
				return default(TransformTrackRate);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x8D47EE0", Offset = "0x8D46CE0", VA = "0x188D47EE0", Slot = "71")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public bool IXMTAWZSMUU
		{
			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x8D46AB0", Offset = "0x8D458B0", VA = "0x188D46AB0", Slot = "72")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public Transform EOCZPHKJMMS
		{
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0xB88130", Offset = "0xB86F30", VA = "0x180B88130", Slot = "73")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public Vector3 VTURVASEHGS
		{
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x8D45690", Offset = "0x8D44490", VA = "0x188D45690", Slot = "74")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x8D46C10", Offset = "0x8D45A10", VA = "0x188D46C10", Slot = "75")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public float QIBDAKMVXVC
		{
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x8D4A1C0", Offset = "0x8D48FC0", VA = "0x188D4A1C0", Slot = "76")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x8D45210", Offset = "0x8D44010", VA = "0x188D45210", Slot = "77")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public float PXKDFCBPUTF
		{
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x8D4A1D0", Offset = "0x8D48FD0", VA = "0x188D4A1D0", Slot = "78")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x8D4A1E0", Offset = "0x8D48FE0", VA = "0x188D4A1E0", Slot = "79")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public Quaternion JVZSZDWWIJF
		{
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x8D4A630", Offset = "0x8D49430", VA = "0x188D4A630", Slot = "80")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x8D463B0", Offset = "0x8D451B0", VA = "0x188D463B0", Slot = "81")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public Vector3 CXGUXRWHWJH
		{
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x8D48210", Offset = "0x8D47010", VA = "0x188D48210", Slot = "82")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x8D481D0", Offset = "0x8D46FD0", VA = "0x188D481D0", Slot = "83")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public Quaternion ULETLHGROGA
		{
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x8D4A110", Offset = "0x8D48F10", VA = "0x188D4A110", Slot = "84")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x8D47A60", Offset = "0x8D46860", VA = "0x188D47A60", Slot = "85")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public RigidbodyConstraints ZZNDPAKCEMV
		{
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x8D47560", Offset = "0x8D46360", VA = "0x188D47560", Slot = "86")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x8D46680", Offset = "0x8D45480", VA = "0x188D46680", Slot = "87")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public bool RKTBCNSWZAS
		{
			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x8D47F40", Offset = "0x8D46D40", VA = "0x188D47F40", Slot = "88")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x8D47420", Offset = "0x8D46220", VA = "0x188D47420", Slot = "89")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public CollisionDetectionMode XYZAJUGOTHR
		{
			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x8D46810", Offset = "0x8D45610", VA = "0x188D46810", Slot = "90")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x8D48A90", Offset = "0x8D47890", VA = "0x188D48A90", Slot = "91")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public bool IMUKVBRLOYS
		{
			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x8D493D0", Offset = "0x8D481D0", VA = "0x188D493D0", Slot = "141")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public bool FNMQUUFGQCR
		{
			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0x8D45510", Offset = "0x8D44310", VA = "0x188D45510", Slot = "92")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000017")]
		public event RbexAction ZRLWMSYFNVF
		{
			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x8D44990", Offset = "0x8D43790", VA = "0x188D44990", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x8D49D90", Offset = "0x8D48B90", VA = "0x188D49D90", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000018")]
		public event RbexAction JLBGDFBJARL
		{
			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x8D46A50", Offset = "0x8D45850", VA = "0x188D46A50", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x8D47A90", Offset = "0x8D46890", VA = "0x188D47A90", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000019")]
		public event RbexParentChangeAction ZODFISIYOEV
		{
			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x8D49FB0", Offset = "0x8D48DB0", VA = "0x188D49FB0", Slot = "18")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x8D497E0", Offset = "0x8D485E0", VA = "0x188D497E0", Slot = "19")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001A")]
		public event RbexAction UMZJHLNJBPU
		{
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x8D469F0", Offset = "0x8D457F0", VA = "0x188D469F0", Slot = "8")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x8D48900", Offset = "0x8D47700", VA = "0x188D48900", Slot = "9")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001B")]
		public event RbexAction PBQNRLTAUNN
		{
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x8D46540", Offset = "0x8D45340", VA = "0x188D46540", Slot = "14")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x8D46150", Offset = "0x8D44F50", VA = "0x188D46150", Slot = "15")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001C")]
		public event RbexAction JUWIFCNHEWK
		{
			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x8D47FE0", Offset = "0x8D46DE0", VA = "0x188D47FE0", Slot = "16")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x8D49220", Offset = "0x8D48020", VA = "0x188D49220", Slot = "17")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001D")]
		public event Action<UpdateLOD, UpdateLOD> EOUEQDCPNZX
		{
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x8D495E0", Offset = "0x8D483E0", VA = "0x188D495E0", Slot = "20")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x8D48960", Offset = "0x8D47760", VA = "0x188D48960", Slot = "21")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001E")]
		public event RbexAction EPAOJVVYLSY
		{
			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x8D49510", Offset = "0x8D48310", VA = "0x188D49510", Slot = "12")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x8D48250", Offset = "0x8D47050", VA = "0x188D48250", Slot = "13")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001F")]
		public event RbexAction ETFLWCFXNGJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x8D48300", Offset = "0x8D47100", VA = "0x188D48300", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x8D478D0", Offset = "0x8D466D0", VA = "0x188D478D0", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x8D4AEE0", Offset = "0x8D49CE0", VA = "0x188D4AEE0")]
		public HLSOFHFNATP(GameObject a, RigidbodyEx b, WXDBYWISUVR c, [In] RigidbodyExData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x8D48D40", Offset = "0x8D47B40", VA = "0x188D48D40", Slot = "139")]
		protected virtual void RQCHBDYJJUX(WXDBYWISUVR a, RigidbodyExData b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x8D45A70", Offset = "0x8D44870", VA = "0x188D45A70", Slot = "140")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x8D44C30", Offset = "0x8D43A30", VA = "0x188D44C30", Slot = "93")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x8D48500", Offset = "0x8D47300", VA = "0x188D48500", Slot = "94")]
		public void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x8D48450", Offset = "0x8D47250", VA = "0x188D48450", Slot = "95")]
		public void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x8D48430", Offset = "0x8D47230", VA = "0x188D48430", Slot = "96")]
		public void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x8D475B0", Offset = "0x8D463B0", VA = "0x188D475B0")]
		private void JPLBCAPTUMZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x8D45130", Offset = "0x8D43F30", VA = "0x188D45130")]
		private void BJCBAAEXSMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x8D460F0", Offset = "0x8D44EF0", VA = "0x188D460F0")]
		private void FEXWPRZWKWL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x8D483B0", Offset = "0x8D471B0", VA = "0x188D483B0", Slot = "30")]
		public IQLOSMXEQPE OYWOMKKTERP(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x8D49720", Offset = "0x8D48520", VA = "0x188D49720", Slot = "98")]
		public void SetParent(IQLOSMXEQPE value, bool isPhysicallyDetachedOnly = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x8D4AD20", Offset = "0x8D49B20", VA = "0x188D4AD20", Slot = "99")]
		public void YOFMLZKPSCK(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x8D49B10", Offset = "0x8D48910", VA = "0x188D49B10", Slot = "100")]
		public void UCELSNIOQFX(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x8D45FA0", Offset = "0x8D44DA0", VA = "0x188D45FA0", Slot = "101")]
		public Vector3 FEHJGEGGUAI(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x8D45970", Offset = "0x8D44770", VA = "0x188D45970", Slot = "102")]
		public Vector3 DXKAJEUUKVM(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x8D482B0", Offset = "0x8D470B0", VA = "0x188D482B0", Slot = "103")]
		public void OEVZVDJNBBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x8D460A0", Offset = "0x8D44EA0", VA = "0x188D460A0", Slot = "104")]
		public void FEVTTANKFOW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x8D49A20", Offset = "0x8D48820", VA = "0x188D49A20", Slot = "105")]
		public void TTNPXHXBYBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x8D47250", Offset = "0x8D46050", VA = "0x188D47250", Slot = "106")]
		public void IQLJSAKGEXJ(Vector3 a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x8D46860", Offset = "0x8D45660", VA = "0x188D46860", Slot = "107")]
		public void GLRZINOHTSW(Vector3 a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x8D47480", Offset = "0x8D46280", VA = "0x188D47480", Slot = "108")]
		public void IZZUETQUKXR(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x8D458B0", Offset = "0x8D446B0", VA = "0x188D458B0", Slot = "109")]
		public void DWZRKRYIUGD(RbexImpulseType a, Vector3 b, float c, float d = 8f, float e = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x8D45740", Offset = "0x8D44540", VA = "0x188D45740", Slot = "110")]
		public void DQNDSWQYHNI(RbexRotationType a, Vector3 b, float c = 1f / 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x8D46B60", Offset = "0x8D45960", VA = "0x188D46B60", Slot = "111")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void IBZFDEMKQUN(RbexRotationType a, Vector3 b, float c = 7f, float d = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x8D4A010", Offset = "0x8D48E10", VA = "0x188D4A010", Slot = "112")]
		public Vector3 VEEYJMDVERW(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x8D4A7B0", Offset = "0x8D495B0", VA = "0x188D4A7B0", Slot = "113")]
		public Vector3 XZKDQDAYVGE(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x8D48180", Offset = "0x8D46F80", VA = "0x188D48180", Slot = "114")]
		public void NZGXMTNXECX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x8D4A150", Offset = "0x8D48F50", VA = "0x188D4A150", Slot = "115")]
		public void VFVBMKGJZHZ(IQLOSMXEQPE a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x8D4ADD0", Offset = "0x8D49BD0", VA = "0x188D4ADD0", Slot = "116")]
		public void ZDSSQHNPIDG(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x8D44B50", Offset = "0x8D43950", VA = "0x188D44B50", Slot = "63")]
		public void AVHYVADFBGQ((Quaternion rot, Vector3 moments) tensor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x8D44D70", Offset = "0x8D43B70", VA = "0x188D44D70", Slot = "117")]
		public void BBFCKZSWOKY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x8D45DA0", Offset = "0x8D44BA0", VA = "0x188D45DA0", Slot = "118")]
		public void EYRUDYQSZWH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x8D48630", Offset = "0x8D47430", VA = "0x188D48630", Slot = "119")]
		public void QBUPGVAOESG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x8D47E90", Offset = "0x8D46C90", VA = "0x188D47E90", Slot = "120")]
		public bool MDBNRHUMEYC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x8D49790", Offset = "0x8D48590", VA = "0x188D49790", Slot = "97")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x8D49570", Offset = "0x8D48370", VA = "0x188D49570", Slot = "121")]
		public void SPPGBOIMTQW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x8D49110", Offset = "0x8D47F10", VA = "0x188D49110", Slot = "122")]
		public void RXVDHDMKVUD(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x8D48760", Offset = "0x8D47560", VA = "0x188D48760", Slot = "123")]
		public void QNGWBZMYCDG(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x8D4A6D0", Offset = "0x8D494D0", VA = "0x188D4A6D0", Slot = "124")]
		public void XJYMLZNFAFU(object a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x8D47BB0", Offset = "0x8D469B0", VA = "0x188D47BB0", Slot = "125")]
		public void LWPWQHEQIJU(Vector3 a, Quaternion b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x8D466E0", Offset = "0x8D454E0", VA = "0x188D466E0", Slot = "126")]
		public void GGYCUEPSVTM(Vector3 a, Quaternion b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x8D4AD80", Offset = "0x8D49B80", VA = "0x188D4AD80", Slot = "127")]
		public bool YQCDODQXNWV(float a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x8D47AF0", Offset = "0x8D468F0", VA = "0x188D47AF0", Slot = "128")]
		public void LGICOBXFXFI(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x8D452A0", Offset = "0x8D440A0", VA = "0x188D452A0", Slot = "129")]
		public void CBUALXGSVRB(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x8D48C10", Offset = "0x8D47A10", VA = "0x188D48C10", Slot = "130")]
		public void RHVNAXHJIII(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x8D4AE80", Offset = "0x8D49C80", VA = "0x188D4AE80", Slot = "131")]
		public void ZXDRGCLXBDF(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x8D49640", Offset = "0x8D48440", VA = "0x188D49640", Slot = "132")]
		public void SWTRTRDVTVD(Vector3 a, ForceMode b = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x8D45C40", Offset = "0x8D44A40", VA = "0x188D45C40", Slot = "133")]
		public void EHXZYDRIIFF(Vector3 a, Vector3 b, ForceMode c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x8D4A2E0", Offset = "0x8D490E0", VA = "0x188D4A2E0", Slot = "134")]
		public void VVMMMZDTOAY(Vector3 a, ForceMode b = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x8D49DF0", Offset = "0x8D48BF0", VA = "0x188D49DF0", Slot = "135")]
		public void USHIUMMKMCU(Vector3 a, ForceMode b = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x8D47830", Offset = "0x8D46630", VA = "0x188D47830", Slot = "136")]
		public bool JTKFPPLCFRL(Vector3 a, [Out] RaycastHit b, float c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x8D484B0", Offset = "0x8D472B0", VA = "0x188D484B0", Slot = "137")]
		public void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x8D49AD0", Offset = "0x8D488D0", VA = "0x188D49AD0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x8D48C70", Offset = "0x8D47A70", VA = "0x188D48C70")]
		private void ROIMUSYGFVR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x8D44A40", Offset = "0x8D43840", VA = "0x188D44A40")]
		private void APCHOGAFSAV(IQLOSMXEQPE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x8D49840", Offset = "0x8D48640", VA = "0x188D49840")]
		private void TPXKJNORDZQ(IQLOSMXEQPE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x8D46490", Offset = "0x8D45290", VA = "0x188D46490")]
		private void GBJXJLKVSCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x8D48AF0", Offset = "0x8D478F0", VA = "0x188D48AF0")]
		private void RHAJNMVNXII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x8D45DF0", Offset = "0x8D44BF0", VA = "0x188D45DF0")]
		private void FBDPDQQVNAG(IQLOSMXEQPE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x8D45B70", Offset = "0x8D44970", VA = "0x188D45B70")]
		private void EHKZYIDCFLX(IQLOSMXEQPE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x8D457E0", Offset = "0x8D445E0", VA = "0x188D457E0")]
		private void DSBGFYTIKKV(IQLOSMXEQPE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x8D49280", Offset = "0x8D48080", VA = "0x188D49280")]
		private void SGFYZQUBVFW(GDYMXZWVLQY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x8D46CC0", Offset = "0x8D45AC0", VA = "0x188D46CC0", Slot = "142")]
		protected virtual void IMLMSPCVEIJ(GDYMXZWVLQY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x8D44E10", Offset = "0x8D43C10", VA = "0x188D44E10")]
		protected void BIPKXPPNGKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x8D4A9D0", Offset = "0x8D497D0", VA = "0x188D4A9D0")]
		protected void YLRAQVVEPMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x8D46290", Offset = "0x8D45090", VA = "0x188D46290")]
		private void FPWPTHIRLFT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x8D45300", Offset = "0x8D44100", VA = "0x188D45300")]
		private void CDUSDUJNRQI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	internal static class CAXLNGIFFEX
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x8D40ED0", Offset = "0x8D3FCD0", VA = "0x188D40ED0")]
		public static IQLOSMXEQPE YGRVGQZQMYI(this IQLOSMXEQPE a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x8D40D20", Offset = "0x8D3FB20", VA = "0x188D40D20")]
		public static bool AWEUMFCMPRJ(this IQLOSMXEQPE a, IQLOSMXEQPE b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x8D40E30", Offset = "0x8D3FC30", VA = "0x188D40E30")]
		public static bool IPURUICQSTD(this IQLOSMXEQPE a, IQLOSMXEQPE b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x8D40F90", Offset = "0x8D3FD90", VA = "0x188D40F90")]
		public static GDYMXZWVLQY ZTRFMMWKPIN(this IQLOSMXEQPE a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x8D40DC0", Offset = "0x8D3FBC0", VA = "0x188D40DC0")]
		public static HLSOFHFNATP Base(this IQLOSMXEQPE impl)
		{
			return null;
		}
	}
}
namespace RecRoom.Rbex.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class NJMCDVSCRMQ : SJEUYUORZHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x8D4D510", Offset = "0x8D4C310", VA = "0x188D4D510", Slot = "19")]
		public IQLOSMXEQPE KABYPYFHTCZ(RigidbodyEx a, RigidbodyExData b, WXDBYWISUVR c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0xABE8E0", Offset = "0xABD6E0", VA = "0x180ABE8E0", Slot = "4")]
		public TZTEZWAGONU ETNNMIBYIDU(IQLOSMXEQPE a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0xABE8E0", Offset = "0xABD6E0", VA = "0x180ABE8E0", Slot = "5")]
		public BVLWLVXGHOU BMCHKCSIIEQ(IQLOSMXEQPE a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0xABE8E0", Offset = "0xABD6E0", VA = "0x180ABE8E0", Slot = "6")]
		public JQILPELHVDT GETTYURTTIV(IQLOSMXEQPE a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0xABE8E0", Offset = "0xABD6E0", VA = "0x180ABE8E0", Slot = "7")]
		public HAMXNCHWVPQ GNGJGGBMDHM(IQLOSMXEQPE a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0xABE8E0", Offset = "0xABD6E0", VA = "0x180ABE8E0", Slot = "8")]
		public XIHYGGHCGEO OOSQREXXYIK(IQLOSMXEQPE a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0xABE8E0", Offset = "0xABD6E0", VA = "0x180ABE8E0", Slot = "9")]
		public FFIJQMFXKAR JPJSFKMMSZT(IQLOSMXEQPE a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0xABE8E0", Offset = "0xABD6E0", VA = "0x180ABE8E0", Slot = "10")]
		public YJVZTFZLWOA CRQGDHLGDBS(IQLOSMXEQPE a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0xABE8E0", Offset = "0xABD6E0", VA = "0x180ABE8E0", Slot = "11")]
		public YODEMQIHVZA AJNRSKONDAW(IQLOSMXEQPE a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0xABE8E0", Offset = "0xABD6E0", VA = "0x180ABE8E0", Slot = "12")]
		public VDFNRILYUDG XQPXBTJGMNW(IQLOSMXEQPE a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0xABE8E0", Offset = "0xABD6E0", VA = "0x180ABE8E0", Slot = "13")]
		public QBECMFVIFGT SAEYFDHOROH(IQLOSMXEQPE a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0xABE8E0", Offset = "0xABD6E0", VA = "0x180ABE8E0")]
		public DVYOJNKRSOH VPWAOKJMEIP(IQLOSMXEQPE a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0xABE8E0", Offset = "0xABD6E0", VA = "0x180ABE8E0")]
		public HTRGPEPOPTT FZTBGBNURSZ(IQLOSMXEQPE a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0xABE8E0", Offset = "0xABD6E0", VA = "0x180ABE8E0")]
		public FQNUAFXQDBF ISDZDTJKALZ(IQLOSMXEQPE a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0xABE8E0", Offset = "0xABD6E0", VA = "0x180ABE8E0")]
		public FAXDCATHUYN IRJTBUHVAJH(IQLOSMXEQPE a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0xABE8E0", Offset = "0xABD6E0", VA = "0x180ABE8E0")]
		public OWLGPBGJMUN BWUMDHNXBWJ(IQLOSMXEQPE a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public NJMCDVSCRMQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0xABE8E0", Offset = "0xABD6E0", VA = "0x180ABE8E0", Slot = "14")]
		private DVYOJNKRSOH LGYQCVTPMCP(IQLOSMXEQPE a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0xABE8E0", Offset = "0xABD6E0", VA = "0x180ABE8E0", Slot = "15")]
		private HTRGPEPOPTT FSCPPLVHTIR(IQLOSMXEQPE a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0xABE8E0", Offset = "0xABD6E0", VA = "0x180ABE8E0", Slot = "16")]
		private FQNUAFXQDBF ZAMWXHVVIPF(IQLOSMXEQPE a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0xABE8E0", Offset = "0xABD6E0", VA = "0x180ABE8E0", Slot = "17")]
		private FAXDCATHUYN RKZBQXINGGB(IQLOSMXEQPE a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0xABE8E0", Offset = "0xABD6E0", VA = "0x180ABE8E0", Slot = "18")]
		private OWLGPBGJMUN AAJVGXWGKIN(IQLOSMXEQPE a, [In] RigidbodyExData data)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[RegisterService(typeof(SJEUYUORZHF), new string[] { })]
	public class YPOTOUSKKXL : SJEUYUORZHF, IUKSRZVFRMZ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private readonly SJEUYUORZHF BMDNGVVXXXW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private readonly SJEUYUORZHF FRERRZDHOTT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private FFSOIOWFVJN NQEHBSOZCES;

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		private SJEUYUORZHF FAUWBUBESMD
		{
			[Cpp2IlInjected.Token(Token = "0x600021F")]
			[Cpp2IlInjected.Address(RVA = "0x8D5BDD0", Offset = "0x8D5ABD0", VA = "0x188D5BDD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x8D5BA10", Offset = "0x8D5A810", VA = "0x188D5BA10", Slot = "20")]
		public void InitReferences(FCHQYTALOWK services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x8D5B620", Offset = "0x8D5A420", VA = "0x188D5B620", Slot = "4")]
		public TZTEZWAGONU ETNNMIBYIDU(IQLOSMXEQPE a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x8D5B4E0", Offset = "0x8D5A2E0", VA = "0x188D5B4E0", Slot = "5")]
		public BVLWLVXGHOU BMCHKCSIIEQ(IQLOSMXEQPE a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x8D5B770", Offset = "0x8D5A570", VA = "0x188D5B770", Slot = "6")]
		public JQILPELHVDT GETTYURTTIV(IQLOSMXEQPE a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x8D5B810", Offset = "0x8D5A610", VA = "0x188D5B810", Slot = "7")]
		public HAMXNCHWVPQ GNGJGGBMDHM(IQLOSMXEQPE a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x8D5BC90", Offset = "0x8D5AA90", VA = "0x188D5BC90", Slot = "8")]
		public XIHYGGHCGEO OOSQREXXYIK(IQLOSMXEQPE a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x8D5BA60", Offset = "0x8D5A860", VA = "0x188D5BA60", Slot = "9")]
		public FFIJQMFXKAR JPJSFKMMSZT(IQLOSMXEQPE a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x8D5B580", Offset = "0x8D5A380", VA = "0x188D5B580", Slot = "10")]
		public YJVZTFZLWOA CRQGDHLGDBS(IQLOSMXEQPE a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x8D5B440", Offset = "0x8D5A240", VA = "0x188D5B440", Slot = "11")]
		public YODEMQIHVZA AJNRSKONDAW(IQLOSMXEQPE a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x8D5BE30", Offset = "0x8D5AC30", VA = "0x188D5BE30", Slot = "12")]
		public VDFNRILYUDG XQPXBTJGMNW(IQLOSMXEQPE a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x8D5BD30", Offset = "0x8D5AB30", VA = "0x188D5BD30", Slot = "13")]
		public QBECMFVIFGT SAEYFDHOROH(IQLOSMXEQPE a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x8D5BBE0", Offset = "0x8D5A9E0", VA = "0x188D5BBE0")]
		public DVYOJNKRSOH VPWAOKJMEIP(IQLOSMXEQPE a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x8D5B6C0", Offset = "0x8D5A4C0", VA = "0x188D5B6C0")]
		public HTRGPEPOPTT FZTBGBNURSZ(IQLOSMXEQPE a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x8D5B960", Offset = "0x8D5A760", VA = "0x188D5B960")]
		public FQNUAFXQDBF ISDZDTJKALZ(IQLOSMXEQPE a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x8D5B8B0", Offset = "0x8D5A6B0", VA = "0x188D5B8B0")]
		public FAXDCATHUYN IRJTBUHVAJH(IQLOSMXEQPE a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x8D5B390", Offset = "0x8D5A190", VA = "0x188D5B390")]
		public OWLGPBGJMUN BWUMDHNXBWJ(IQLOSMXEQPE a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x8D5BB00", Offset = "0x8D5A900", VA = "0x188D5BB00", Slot = "19")]
		public IQLOSMXEQPE KABYPYFHTCZ(RigidbodyEx a, RigidbodyExData b, WXDBYWISUVR c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x8D5BED0", Offset = "0x8D5ACD0", VA = "0x188D5BED0")]
		public YPOTOUSKKXL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x8D5BBE0", Offset = "0x8D5A9E0", VA = "0x188D5BBE0", Slot = "14")]
		private DVYOJNKRSOH LGYQCVTPMCP(IQLOSMXEQPE a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x8D5B6C0", Offset = "0x8D5A4C0", VA = "0x188D5B6C0", Slot = "15")]
		private HTRGPEPOPTT FSCPPLVHTIR(IQLOSMXEQPE a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x8D5B960", Offset = "0x8D5A760", VA = "0x188D5B960", Slot = "16")]
		private FQNUAFXQDBF ZAMWXHVVIPF(IQLOSMXEQPE a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x8D5B8B0", Offset = "0x8D5A6B0", VA = "0x188D5B8B0", Slot = "17")]
		private FAXDCATHUYN RKZBQXINGGB(IQLOSMXEQPE a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x8D5B390", Offset = "0x8D5A190", VA = "0x188D5B390", Slot = "18")]
		private OWLGPBGJMUN AAJVGXWGKIN(IQLOSMXEQPE a, [In] RigidbodyExData data)
		{
			return null;
		}
	}
}
namespace RecRoom.Rbex.Legacy
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public interface JMXGRNWPBIT : TZTEZWAGONU, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void UBMOPDDJDKA(IQLOSMXEQPE a);

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void AHKDMPERGNB(IQLOSMXEQPE a);

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void GMDRYIUXQDY(IQLOSMXEQPE a);

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void ILTZEPWTOJB(IQLOSMXEQPE a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public interface DUKQNXPQCYQ : JQILPELHVDT
	{
		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		JLQZPQHBORG<IQLOSMXEQPE> OHDAZULXBXF
		{
			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		IQLOSMXEQPE HEPNOOQKPSP
		{
			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public interface KXEOBDSCVCK : FAXDCATHUYN
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		(float, Vector3) IRKHOAEWYTV(Rigidbody a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public interface YUFQPSJXKII : HTRGPEPOPTT, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		RRNetworkView HBVQPIVTZSA
		{
			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	internal sealed class AFLDFICDVPD : VDFNRILYUDG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private readonly HLSOFHFNATP QVRTYDABTIW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private CollisionDetectionMode WSLQGLTQBMD;

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		private Rigidbody LYLSFVCJLUL
		{
			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0x8D40620", Offset = "0x8D3F420", VA = "0x188D40620")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		public CollisionDetectionMode XYZAJUGOTHR
		{
			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0x8D407A0", Offset = "0x8D3F5A0", VA = "0x188D407A0", Slot = "4")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0x8D40A20", Offset = "0x8D3F820", VA = "0x188D40A20", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x8D40B10", Offset = "0x8D3F910", VA = "0x188D40B10")]
		public AFLDFICDVPD(IQLOSMXEQPE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x8D40510", Offset = "0x8D3F310", VA = "0x188D40510", Slot = "6")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x8D40A90", Offset = "0x8D3F890", VA = "0x188D40A90", Slot = "9")]
		public void TOEZMFUKDBQ(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x8D40A10", Offset = "0x8D3F810", VA = "0x188D40A10", Slot = "7")]
		public void ORIJLREMAVD(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x8D40790", Offset = "0x8D3F590", VA = "0x188D40790", Slot = "8")]
		public void GBGWGPTOJLO(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x8D408B0", Offset = "0x8D3F6B0", VA = "0x188D408B0", Slot = "10")]
		public bool JTKFPPLCFRL(Vector3 a, [Out] RaycastHit b, float c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x8D40670", Offset = "0x8D3F470", VA = "0x188D40670")]
		private void FWBWMDSLLFN(bool a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public sealed class GVQJKHZXIGC : FFIJQMFXKAR, IDisposable, SPISOTIFQAV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly HLSOFHFNATP QVRTYDABTIW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private TransformTrackRate WYYOKXBJDUQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private QDTPAEHJLXK EDPZYYPRMJC;

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		public TransformTrackRate KOGAJYHNSCI
		{
			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0x8D44770", Offset = "0x8D43570", VA = "0x188D44770", Slot = "6")]
			get
			{
				return default(TransformTrackRate);
			}
			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0x8D44520", Offset = "0x8D43320", VA = "0x188D44520", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000092")]
		private Transform FCHKGBEPLPB
		{
			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x8D446A0", Offset = "0x8D434A0", VA = "0x188D446A0", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000020")]
		public event Action<UpdateLOD, UpdateLOD> EOUEQDCPNZX
		{
			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0x8D446C0", Offset = "0x8D434C0", VA = "0x188D446C0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0x8D445F0", Offset = "0x8D433F0", VA = "0x188D445F0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x8D448B0", Offset = "0x8D436B0", VA = "0x188D448B0")]
		public GVQJKHZXIGC(IQLOSMXEQPE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x8D44260", Offset = "0x8D43060", VA = "0x188D44260", Slot = "8")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x8D444D0", Offset = "0x8D432D0", VA = "0x188D444D0", Slot = "9")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x13A3560", Offset = "0x13A2360", VA = "0x1813A3560", Slot = "11")]
		private void ZUUADIVKXOI(UpdateLOD a, UpdateLOD b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "12")]
		private void MKKLPKWWEWM(bool a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class NJMCDVSCRMQ : SJEUYUORZHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x8D4CDC0", Offset = "0x8D4BBC0", VA = "0x188D4CDC0", Slot = "4")]
		public TZTEZWAGONU ETNNMIBYIDU(IQLOSMXEQPE a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x8D4CBA0", Offset = "0x8D4B9A0", VA = "0x188D4CBA0", Slot = "5")]
		public BVLWLVXGHOU BMCHKCSIIEQ(IQLOSMXEQPE a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x8D4D020", Offset = "0x8D4BE20", VA = "0x188D4D020", Slot = "6")]
		public JQILPELHVDT GETTYURTTIV(IQLOSMXEQPE a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x8D4D140", Offset = "0x8D4BF40", VA = "0x188D4D140", Slot = "7")]
		public HAMXNCHWVPQ GNGJGGBMDHM(IQLOSMXEQPE a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x8D4D800", Offset = "0x8D4C600", VA = "0x188D4D800", Slot = "8")]
		public XIHYGGHCGEO OOSQREXXYIK(IQLOSMXEQPE a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x8D4D450", Offset = "0x8D4C250", VA = "0x188D4D450", Slot = "9")]
		public FFIJQMFXKAR JPJSFKMMSZT(IQLOSMXEQPE a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x8D4CCB0", Offset = "0x8D4BAB0", VA = "0x188D4CCB0", Slot = "10")]
		public YJVZTFZLWOA CRQGDHLGDBS(IQLOSMXEQPE a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x8D4CAE0", Offset = "0x8D4B8E0", VA = "0x188D4CAE0", Slot = "11")]
		public YODEMQIHVZA AJNRSKONDAW(IQLOSMXEQPE a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x8D4D980", Offset = "0x8D4C780", VA = "0x188D4D980", Slot = "12")]
		public VDFNRILYUDG XQPXBTJGMNW(IQLOSMXEQPE a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x8D4D8C0", Offset = "0x8D4C6C0", VA = "0x188D4D8C0", Slot = "13")]
		public QBECMFVIFGT SAEYFDHOROH(IQLOSMXEQPE a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x8D4D6E0", Offset = "0x8D4C4E0", VA = "0x188D4D6E0")]
		public DVYOJNKRSOH VPWAOKJMEIP(IQLOSMXEQPE a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x8D4CEA0", Offset = "0x8D4BCA0", VA = "0x188D4CEA0")]
		public HTRGPEPOPTT FZTBGBNURSZ(IQLOSMXEQPE a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x8D4D330", Offset = "0x8D4C130", VA = "0x188D4D330")]
		public FQNUAFXQDBF ISDZDTJKALZ(IQLOSMXEQPE a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x8D4D1B0", Offset = "0x8D4BFB0", VA = "0x188D4D1B0")]
		public FAXDCATHUYN IRJTBUHVAJH(IQLOSMXEQPE a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x8D4CA10", Offset = "0x8D4B810", VA = "0x188D4CA10")]
		public OWLGPBGJMUN BWUMDHNXBWJ(IQLOSMXEQPE a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x8D4D5A0", Offset = "0x8D4C3A0", VA = "0x188D4D5A0", Slot = "19")]
		public IQLOSMXEQPE KABYPYFHTCZ(RigidbodyEx a, RigidbodyExData b, WXDBYWISUVR c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public NJMCDVSCRMQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x8D4D6E0", Offset = "0x8D4C4E0", VA = "0x188D4D6E0", Slot = "14")]
		private DVYOJNKRSOH LGYQCVTPMCP(IQLOSMXEQPE a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x8D4CEA0", Offset = "0x8D4BCA0", VA = "0x188D4CEA0", Slot = "15")]
		private HTRGPEPOPTT FSCPPLVHTIR(IQLOSMXEQPE a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x8D4D330", Offset = "0x8D4C130", VA = "0x188D4D330", Slot = "16")]
		private FQNUAFXQDBF ZAMWXHVVIPF(IQLOSMXEQPE a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x8D4D1B0", Offset = "0x8D4BFB0", VA = "0x188D4D1B0", Slot = "17")]
		private FAXDCATHUYN RKZBQXINGGB(IQLOSMXEQPE a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x8D4CA10", Offset = "0x8D4B810", VA = "0x188D4CA10", Slot = "18")]
		private OWLGPBGJMUN AAJVGXWGKIN(IQLOSMXEQPE a, [In] RigidbodyExData data)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal sealed class UEJUZYBMBJD : YODEMQIHVZA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private readonly HLSOFHFNATP QVRTYDABTIW;

		[Cpp2IlInjected.Token(Token = "0x17000093")]
		private Rigidbody LYLSFVCJLUL
		{
			[Cpp2IlInjected.Token(Token = "0x6000268")]
			[Cpp2IlInjected.Address(RVA = "0x8D40620", Offset = "0x8D3F420", VA = "0x188D40620")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000094")]
		private bool IXMTAWZSMUU
		{
			[Cpp2IlInjected.Token(Token = "0x6000269")]
			[Cpp2IlInjected.Address(RVA = "0x8D57390", Offset = "0x8D56190", VA = "0x188D57390")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000095")]
		private bool MGSTXVDYFSV
		{
			[Cpp2IlInjected.Token(Token = "0x600026A")]
			[Cpp2IlInjected.Address(RVA = "0x8D56120", Offset = "0x8D54F20", VA = "0x188D56120")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000096")]
		private IQLOSMXEQPE IGSJTJYCBZZ
		{
			[Cpp2IlInjected.Token(Token = "0x600026B")]
			[Cpp2IlInjected.Address(RVA = "0x8D573E0", Offset = "0x8D561E0", VA = "0x188D573E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x8D40B10", Offset = "0x8D3F910", VA = "0x188D40B10")]
		public UEJUZYBMBJD(IQLOSMXEQPE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x8D57440", Offset = "0x8D56240", VA = "0x188D57440", Slot = "4")]
		public void SWTRTRDVTVD(Vector3 a, ForceMode b = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x8D56C50", Offset = "0x8D55A50", VA = "0x188D56C50")]
		private void AWCLSYOBCPG(Vector3 a, ForceMode b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x8D56EB0", Offset = "0x8D55CB0", VA = "0x188D56EB0", Slot = "5")]
		public void EHXZYDRIIFF(Vector3 a, Vector3 b, ForceMode c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x8D57800", Offset = "0x8D56600", VA = "0x188D57800", Slot = "6")]
		public void VVMMMZDTOAY(Vector3 a, ForceMode b = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x8D57130", Offset = "0x8D55F30", VA = "0x188D57130")]
		private void FTOZNWHGFCL(Vector3 a, ForceMode b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x8D575A0", Offset = "0x8D563A0", VA = "0x188D575A0", Slot = "7")]
		public void USHIUMMKMCU(Vector3 a, ForceMode b = ForceMode.Force)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	internal sealed class NKADCIYVTJS : QBECMFVIFGT
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private readonly HLSOFHFNATP QVRTYDABTIW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private bool MHHIWXZHNPC;

		[Cpp2IlInjected.Token(Token = "0x17000097")]
		public bool DAKABLWZVQI
		{
			[Cpp2IlInjected.Token(Token = "0x6000274")]
			[Cpp2IlInjected.Address(RVA = "0xB40C50", Offset = "0xB3FA50", VA = "0x180B40C50", Slot = "4")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000275")]
			[Cpp2IlInjected.Address(RVA = "0x8D4DAB0", Offset = "0x8D4C8B0", VA = "0x188D4DAB0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x8D40B10", Offset = "0x8D3F910", VA = "0x188D40B10")]
		public NKADCIYVTJS(IQLOSMXEQPE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x8D4DBC0", Offset = "0x8D4C9C0", VA = "0x188D4DBC0", Slot = "6")]
		public void TOEZMFUKDBQ(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x8D4DA40", Offset = "0x8D4C840", VA = "0x188D4DA40", Slot = "7")]
		public void CGKVDMFFWEH(Rigidbody a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	internal sealed class RbexHierarchy : JMXGRNWPBIT, TZTEZWAGONU, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private readonly IQLOSMXEQPE QVRTYDABTIW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private readonly List<IQLOSMXEQPE> OAREUBGJZOY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private IQLOSMXEQPE BSGUJACPZOT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private IQLOSMXEQPE HATHWVTRAGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private Transform IDAKOCKANZY;

		[Cpp2IlInjected.Token(Token = "0x17000098")]
		private Transform ZCGASSMNTRL
		{
			[Cpp2IlInjected.Token(Token = "0x600028A")]
			[Cpp2IlInjected.Address(RVA = "0x8D50530", Offset = "0x8D4F330", VA = "0x188D50530")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000099")]
		public IQLOSMXEQPE IGSJTJYCBZZ
		{
			[Cpp2IlInjected.Token(Token = "0x600028D")]
			[Cpp2IlInjected.Address(RVA = "0xAC50D0", Offset = "0xAC3ED0", VA = "0x180AC50D0", Slot = "28")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600028E")]
			[Cpp2IlInjected.Address(RVA = "0x8D4F920", Offset = "0x8D4E720", VA = "0x188D4F920", Slot = "29")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009A")]
		public IQLOSMXEQPE NKNEDPIWGGX
		{
			[Cpp2IlInjected.Token(Token = "0x600028F")]
			[Cpp2IlInjected.Address(RVA = "0xAC3410", Offset = "0xAC2210", VA = "0x180AC3410", Slot = "27")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		public IReadOnlyList<IQLOSMXEQPE> QEPMXJBXWKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000290")]
			[Cpp2IlInjected.Address(RVA = "0xAC31D0", Offset = "0xAC1FD0", VA = "0x180AC31D0", Slot = "26")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000021")]
		public event RbexAction ZRLWMSYFNVF
		{
			[Cpp2IlInjected.Token(Token = "0x6000278")]
			[Cpp2IlInjected.Address(RVA = "0x8D4EC50", Offset = "0x8D4DA50", VA = "0x188D4EC50", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000279")]
			[Cpp2IlInjected.Address(RVA = "0x8D503F0", Offset = "0x8D4F1F0", VA = "0x188D503F0", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000022")]
		public event RbexAction JLBGDFBJARL
		{
			[Cpp2IlInjected.Token(Token = "0x600027A")]
			[Cpp2IlInjected.Address(RVA = "0x8D4F330", Offset = "0x8D4E130", VA = "0x188D4F330", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600027B")]
			[Cpp2IlInjected.Address(RVA = "0x8D4F740", Offset = "0x8D4E540", VA = "0x188D4F740", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000023")]
		public event RbexParentChangeAction ZODFISIYOEV
		{
			[Cpp2IlInjected.Token(Token = "0x600027C")]
			[Cpp2IlInjected.Address(RVA = "0x8D50490", Offset = "0x8D4F290", VA = "0x188D50490", Slot = "12")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600027D")]
			[Cpp2IlInjected.Address(RVA = "0x8D50260", Offset = "0x8D4F060", VA = "0x188D50260", Slot = "13")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000024")]
		public event Action VATMTZKQZAE
		{
			[Cpp2IlInjected.Token(Token = "0x600027E")]
			[Cpp2IlInjected.Address(RVA = "0x8D4F880", Offset = "0x8D4E680", VA = "0x188D4F880", Slot = "14")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600027F")]
			[Cpp2IlInjected.Address(RVA = "0x8D4F7E0", Offset = "0x8D4E5E0", VA = "0x188D4F7E0", Slot = "15")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000025")]
		public event Action WQZXORLUACF
		{
			[Cpp2IlInjected.Token(Token = "0x6000280")]
			[Cpp2IlInjected.Address(RVA = "0x8D50830", Offset = "0x8D4F630", VA = "0x188D50830", Slot = "16")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000281")]
			[Cpp2IlInjected.Address(RVA = "0x8D4EE40", Offset = "0x8D4DC40", VA = "0x188D4EE40", Slot = "17")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000026")]
		public event Action<IQLOSMXEQPE> XYVLLDQAMUE
		{
			[Cpp2IlInjected.Token(Token = "0x6000282")]
			[Cpp2IlInjected.Address(RVA = "0x8D4ECF0", Offset = "0x8D4DAF0", VA = "0x188D4ECF0", Slot = "18")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000283")]
			[Cpp2IlInjected.Address(RVA = "0x8D4FA60", Offset = "0x8D4E860", VA = "0x188D4FA60", Slot = "19")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000027")]
		public event Action<IQLOSMXEQPE> ZMMSTYNYYZZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000284")]
			[Cpp2IlInjected.Address(RVA = "0x8D50780", Offset = "0x8D4F580", VA = "0x188D50780", Slot = "20")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000285")]
			[Cpp2IlInjected.Address(RVA = "0x8D4EBA0", Offset = "0x8D4D9A0", VA = "0x188D4EBA0", Slot = "21")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000028")]
		public event Action AAUKDLCUFGA
		{
			[Cpp2IlInjected.Token(Token = "0x6000286")]
			[Cpp2IlInjected.Address(RVA = "0x8D4EDA0", Offset = "0x8D4DBA0", VA = "0x188D4EDA0", Slot = "22")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000287")]
			[Cpp2IlInjected.Address(RVA = "0x8D50640", Offset = "0x8D4F440", VA = "0x188D50640", Slot = "23")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000029")]
		public event Action<IQLOSMXEQPE> HDSITCDTDCZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000288")]
			[Cpp2IlInjected.Address(RVA = "0x8D4F650", Offset = "0x8D4E450", VA = "0x188D4F650", Slot = "24")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000289")]
			[Cpp2IlInjected.Address(RVA = "0x8D50590", Offset = "0x8D4F390", VA = "0x188D50590", Slot = "25")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x8D508D0", Offset = "0x8D4F6D0", VA = "0x188D508D0")]
		public RbexHierarchy(IQLOSMXEQPE rbex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x8D4EEE0", Offset = "0x8D4DCE0", VA = "0x188D4EEE0", Slot = "31")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x8D4FCF0", Offset = "0x8D4EAF0", VA = "0x188D4FCF0", Slot = "30")]
		public void SetParent(IQLOSMXEQPE newParent, bool isPhysicallyDetachedOnly = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x8D4F0C0", Offset = "0x8D4DEC0", VA = "0x188D4F0C0", Slot = "6")]
		public void GMDRYIUXQDY(IQLOSMXEQPE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x8D4F3D0", Offset = "0x8D4E1D0", VA = "0x188D4F3D0", Slot = "7")]
		public void ILTZEPWTOJB(IQLOSMXEQPE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x8D50300", Offset = "0x8D4F100", VA = "0x188D50300", Slot = "4")]
		public void UBMOPDDJDKA(IQLOSMXEQPE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x8D4EB00", Offset = "0x8D4D900", VA = "0x188D4EB00", Slot = "5")]
		public void AHKDMPERGNB(IQLOSMXEQPE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x8D506E0", Offset = "0x8D4F4E0", VA = "0x188D506E0")]
		private void YEBYXDDRSKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x8D4F700", Offset = "0x8D4E500", VA = "0x188D4F700")]
		private void KGTCCNENHVH(IQLOSMXEQPE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x8D4EF80", Offset = "0x8D4DD80", VA = "0x188D4EF80")]
		private void FKYIRIRIEIS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x8D4F930", Offset = "0x8D4E730", VA = "0x188D4F930")]
		private void MKBJUPVIPHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x8D4FBD0", Offset = "0x8D4E9D0", VA = "0x188D4FBD0")]
		private void SHBBJACGMQT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x8D4FB10", Offset = "0x8D4E910", VA = "0x188D4FB10")]
		[CompilerGenerated]
		private object RXOLRRKUKCX()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	internal static class DJDFUXJNFVV
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x8D41110", Offset = "0x8D3FF10", VA = "0x188D41110")]
		public static JMXGRNWPBIT RJNDZUANLLI(this IQLOSMXEQPE a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	internal sealed class PRMUGNIPFEG : DUKQNXPQCYQ, JQILPELHVDT
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly HLSOFHFNATP QVRTYDABTIW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private readonly JLQZPQHBORG<IQLOSMXEQPE> HAUDMXDIXBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private bool HVTHNMOXGZC;

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		public JLQZPQHBORG<IQLOSMXEQPE> OHDAZULXBXF
		{
			[Cpp2IlInjected.Token(Token = "0x600029D")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		public Vector3 NZUWMXHMJWA
		{
			[Cpp2IlInjected.Token(Token = "0x600029E")]
			[Cpp2IlInjected.Address(RVA = "0x8D4E6B0", Offset = "0x8D4D4B0", VA = "0x188D4E6B0", Slot = "6")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		public Vector3 NNNLMOORXBG
		{
			[Cpp2IlInjected.Token(Token = "0x600029F")]
			[Cpp2IlInjected.Address(RVA = "0x8D4DC50", Offset = "0x8D4CA50", VA = "0x188D4DC50", Slot = "7")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		private Vector3 DVFUTEPXRTY
		{
			[Cpp2IlInjected.Token(Token = "0x60002A3")]
			[Cpp2IlInjected.Address(RVA = "0x8D4DE10", Offset = "0x8D4CC10", VA = "0x188D4DE10")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		public IQLOSMXEQPE HEPNOOQKPSP
		{
			[Cpp2IlInjected.Token(Token = "0x60002A4")]
			[Cpp2IlInjected.Address(RVA = "0x8D4E6E0", Offset = "0x8D4D4E0", VA = "0x188D4E6E0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x8D4E790", Offset = "0x8D4D590", VA = "0x188D4E790")]
		public PRMUGNIPFEG(IQLOSMXEQPE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x8D4DF00", Offset = "0x8D4CD00", VA = "0x188D4DF00", Slot = "8")]
		public void LEEETDPUBYO(IQLOSMXEQPE a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x8D4DBF0", Offset = "0x8D4C9F0", VA = "0x188D4DBF0", Slot = "9")]
		public void BMXCCXJPQID(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x8D4DF70", Offset = "0x8D4CD70", VA = "0x188D4DF70")]
		private Vector3 PLZVAYBMAQO()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x8D4E310", Offset = "0x8D4D110", VA = "0x188D4E310")]
		private void URSKRZMFAXB(IQLOSMXEQPE a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	internal static class BZNYTJKOIXC
	{
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x8D40C60", Offset = "0x8D3FA60", VA = "0x188D40C60")]
		public static DUKQNXPQCYQ KDAZLJATAEB(this IQLOSMXEQPE a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	internal sealed class EYBKJTNGTSI : KXEOBDSCVCK, FAXDCATHUYN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private readonly HLSOFHFNATP QVRTYDABTIW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private readonly OverridableVector3 CPAMOMCXWBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private readonly OverridableVector3 YVHGAIIYZBS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private float VDJXWQZWZHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private float DLSZJJWPDSD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private Vector3 PGGIDMIUKKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private Vector3? DXFXPNJSBZQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private Quaternion? FTDOUQCYUDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private bool CNUPQOSFFNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private bool PIKOAZLOKAY;

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		public Vector3 AXEUGRGNYUG
		{
			[Cpp2IlInjected.Token(Token = "0x60002AA")]
			[Cpp2IlInjected.Address(RVA = "0x1F43FB0", Offset = "0x1F42DB0", VA = "0x181F43FB0", Slot = "7")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60002AB")]
			[Cpp2IlInjected.Address(RVA = "0x8D43310", Offset = "0x8D42110", VA = "0x188D43310", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		public Vector3 QNINAVWDIHT
		{
			[Cpp2IlInjected.Token(Token = "0x60002AC")]
			[Cpp2IlInjected.Address(RVA = "0x8D41C80", Offset = "0x8D40A80", VA = "0x188D41C80", Slot = "9")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		public float SAZWGGEAXTR
		{
			[Cpp2IlInjected.Token(Token = "0x60002AD")]
			[Cpp2IlInjected.Address(RVA = "0xB0F550", Offset = "0xB0E350", VA = "0x180B0F550", Slot = "10")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60002AE")]
			[Cpp2IlInjected.Address(RVA = "0x8D418D0", Offset = "0x8D406D0", VA = "0x188D418D0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A4")]
		public float ZEFMEOEDTOY
		{
			[Cpp2IlInjected.Token(Token = "0x60002AF")]
			[Cpp2IlInjected.Address(RVA = "0xB0F560", Offset = "0xB0E360", VA = "0x180B0F560", Slot = "11")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60002B0")]
			[Cpp2IlInjected.Address(RVA = "0x8D436D0", Offset = "0x8D424D0", VA = "0x188D436D0", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		public Vector3 LWRFODEVPFY
		{
			[Cpp2IlInjected.Token(Token = "0x60002B1")]
			[Cpp2IlInjected.Address(RVA = "0x8D43540", Offset = "0x8D42340", VA = "0x188D43540", Slot = "13")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A6")]
		public Quaternion SCLNYIMJZCE
		{
			[Cpp2IlInjected.Token(Token = "0x60002B2")]
			[Cpp2IlInjected.Address(RVA = "0x8D433C0", Offset = "0x8D421C0", VA = "0x188D433C0", Slot = "14")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A7")]
		private Rigidbody LYLSFVCJLUL
		{
			[Cpp2IlInjected.Token(Token = "0x60002BA")]
			[Cpp2IlInjected.Address(RVA = "0x8D41880", Offset = "0x8D40680", VA = "0x188D41880")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400002A")]
		public event RbexAction SJBOTYMTXYB
		{
			[Cpp2IlInjected.Token(Token = "0x60002A8")]
			[Cpp2IlInjected.Address(RVA = "0x8D42C10", Offset = "0x8D41A10", VA = "0x188D42C10", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60002A9")]
			[Cpp2IlInjected.Address(RVA = "0x8D41AC0", Offset = "0x8D408C0", VA = "0x188D41AC0", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x8D43A00", Offset = "0x8D42800", VA = "0x188D43A00")]
		public EYBKJTNGTSI(IQLOSMXEQPE a, [In] RigidbodyExData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x8D41580", Offset = "0x8D40380", VA = "0x188D41580", Slot = "17")]
		public void BBFCKZSWOKY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x8D419E0", Offset = "0x8D407E0", VA = "0x188D419E0", Slot = "16")]
		public void EYRUDYQSZWH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x8D43780", Offset = "0x8D42580", VA = "0x188D43780", Slot = "19")]
		public void TOEZMFUKDBQ(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x8D416A0", Offset = "0x8D404A0", VA = "0x188D416A0", Slot = "20")]
		public void CGKVDMFFWEH(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x8D43170", Offset = "0x8D41F70", VA = "0x188D43170", Slot = "18")]
		public void QBUPGVAOESG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x8D42CB0", Offset = "0x8D41AB0", VA = "0x188D42CB0", Slot = "21")]
		public void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x8D43310", Offset = "0x8D42110", VA = "0x188D43310")]
		private void QVEVFMZJTRW(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x8D41B60", Offset = "0x8D40960", VA = "0x188D41B60")]
		[Obsolete("This method is dangerous - the unity rigidbody is updated in a deferred manner and this world position may be stale")]
		private Vector3 HCADGYKYCEX()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x8D418D0", Offset = "0x8D406D0", VA = "0x188D418D0")]
		private void ERIPKBLJCUB(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x8D436D0", Offset = "0x8D424D0", VA = "0x188D436D0")]
		private void TIICNKTDISC(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x8D43860", Offset = "0x8D42660", VA = "0x188D43860")]
		private Vector3 YVOLCJAASPO()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x8D411D0", Offset = "0x8D3FFD0", VA = "0x188D411D0", Slot = "15")]
		public void AVHYVADFBGQ((Quaternion rot, Vector3 moments) tensor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x8D41400", Offset = "0x8D40200", VA = "0x188D41400")]
		private Quaternion AXPHZYIUYSG()
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x8D42B40", Offset = "0x8D41940", VA = "0x188D42B40")]
		public void IRKHOAEWYTV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x8D41DA0", Offset = "0x8D40BA0", VA = "0x188D41DA0", Slot = "4")]
		public (float, Vector3) IRKHOAEWYTV(Rigidbody a)
		{
			return default((float, Vector3));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	internal static class DFHAMPWCDLY
	{
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x8D40FE0", Offset = "0x8D3FDE0", VA = "0x188D40FE0")]
		public static KXEOBDSCVCK RJTRGUDPZAV(this IQLOSMXEQPE a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	internal sealed class GDEKOSSNSTK : FQNUAFXQDBF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private readonly HLSOFHFNATP QVRTYDABTIW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private readonly MSAILQECLZZ SQXPYESFJHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private readonly RbexInterpolationMode UQRHARTMWPE;

		[Cpp2IlInjected.Token(Token = "0x170000A8")]
		public bool IBJIBQEBMRY
		{
			[Cpp2IlInjected.Token(Token = "0x60002C5")]
			[Cpp2IlInjected.Address(RVA = "0x1B02730", Offset = "0x1B01530", VA = "0x181B02730", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A9")]
		public RbexInterpolationMode CPOFFPFYKSE
		{
			[Cpp2IlInjected.Token(Token = "0x60002C6")]
			[Cpp2IlInjected.Address(RVA = "0xACF4D0", Offset = "0xACE2D0", VA = "0x180ACF4D0", Slot = "11")]
			get
			{
				return default(RbexInterpolationMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x8D44170", Offset = "0x8D42F70", VA = "0x188D44170")]
		public GDEKOSSNSTK(IQLOSMXEQPE a, [In] RigidbodyExData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x8D43B60", Offset = "0x8D42960", VA = "0x188D43B60", Slot = "4")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x8D43F10", Offset = "0x8D42D10", VA = "0x188D43F10")]
		private bool RNMATSBWBTO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x8D43DD0", Offset = "0x8D42BD0", VA = "0x188D43DD0", Slot = "5")]
		public void GEULPSIFYPG(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x8D43C30", Offset = "0x8D42A30", VA = "0x188D43C30", Slot = "6")]
		public void CLUEPTXMRDN(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x8D43C60", Offset = "0x8D42A60", VA = "0x188D43C60", Slot = "9")]
		public void DGWPXJSVBZJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x8D43E00", Offset = "0x8D42C00", VA = "0x188D43E00")]
		private void JOMNSZTZPHW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x8D43FF0", Offset = "0x8D42DF0", VA = "0x188D43FF0")]
		private void XYAWNLVWUYU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x8D43FB0", Offset = "0x8D42DB0", VA = "0x188D43FB0", Slot = "8")]
		public void TVKPHKTFGMG(IQLOSMXEQPE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x8D43D90", Offset = "0x8D42B90", VA = "0x188D43D90", Slot = "7")]
		public void DWRGBHJNPGP(IQLOSMXEQPE a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	internal sealed class WZVNRSKTPTF : YJVZTFZLWOA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private readonly HLSOFHFNATP QVRTYDABTIW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private readonly MSAILQECLZZ JTUHSYQABGW;

		[Cpp2IlInjected.Token(Token = "0x170000AA")]
		public bool IXMTAWZSMUU
		{
			[Cpp2IlInjected.Token(Token = "0x60002D3")]
			[Cpp2IlInjected.Address(RVA = "0x8D5AF10", Offset = "0x8D59D10", VA = "0x188D5AF10", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400002B")]
		public event RbexAction EPAOJVVYLSY
		{
			[Cpp2IlInjected.Token(Token = "0x60002D1")]
			[Cpp2IlInjected.Address(RVA = "0x8D5B080", Offset = "0x8D59E80", VA = "0x188D5B080", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60002D2")]
			[Cpp2IlInjected.Address(RVA = "0x8D5AFC0", Offset = "0x8D59DC0", VA = "0x188D5AFC0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x8D5B2B0", Offset = "0x8D5A0B0", VA = "0x188D5B2B0")]
		public WZVNRSKTPTF(IQLOSMXEQPE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x8D5B070", Offset = "0x8D59E70", VA = "0x188D5B070", Slot = "7")]
		public void RXVDHDMKVUD(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x8D5B060", Offset = "0x8D59E60", VA = "0x188D5B060", Slot = "8")]
		public void QNGWBZMYCDG(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x8D5B1A0", Offset = "0x8D59FA0", VA = "0x188D5B1A0", Slot = "9")]
		public void XJYMLZNFAFU(object a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x8D5AEA0", Offset = "0x8D59CA0", VA = "0x188D5AEA0", Slot = "12")]
		public void ANJECDYRIPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x8D5B120", Offset = "0x8D59F20", VA = "0x188D5B120", Slot = "10")]
		public void TOEZMFUKDBQ(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x8D5AEE0", Offset = "0x8D59CE0", VA = "0x188D5AEE0", Slot = "11")]
		public void CGKVDMFFWEH(Rigidbody a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	internal sealed class JREKIVLEXTU : YUFQPSJXKII, HTRGPEPOPTT, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private readonly HLSOFHFNATP QVRTYDABTIW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private RRNetworkView THVQYGYLLME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private bool EQZJLMQSKJH;

		[Cpp2IlInjected.Token(Token = "0x170000AB")]
		public RRNetworkView HBVQPIVTZSA
		{
			[Cpp2IlInjected.Token(Token = "0x60002DD")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D20", Offset = "0xAC0B20", VA = "0x180AC1D20", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AC")]
		public bool KIZZGSRSATH
		{
			[Cpp2IlInjected.Token(Token = "0x60002DE")]
			[Cpp2IlInjected.Address(RVA = "0x8D4B4D0", Offset = "0x8D4A2D0", VA = "0x188D4B4D0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AD")]
		public bool OJMGCEJESPL
		{
			[Cpp2IlInjected.Token(Token = "0x60002DF")]
			[Cpp2IlInjected.Address(RVA = "0xD79680", Offset = "0xD78480", VA = "0x180D79680", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400002C")]
		public event RbexAction UMZJHLNJBPU
		{
			[Cpp2IlInjected.Token(Token = "0x60002DB")]
			[Cpp2IlInjected.Address(RVA = "0x8D4B4E0", Offset = "0x8D4A2E0", VA = "0x188D4B4E0", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60002DC")]
			[Cpp2IlInjected.Address(RVA = "0x8D4B940", Offset = "0x8D4A740", VA = "0x188D4B940", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x8D4BB50", Offset = "0x8D4A950", VA = "0x188D4BB50")]
		public JREKIVLEXTU(IQLOSMXEQPE a, [In] RigidbodyExData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x8D4AFD0", Offset = "0x8D49DD0", VA = "0x188D4AFD0", Slot = "9")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x8D4B270", Offset = "0x8D4A070", VA = "0x188D4B270", Slot = "12")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x8D4B360", Offset = "0x8D4A160", VA = "0x188D4B360", Slot = "10")]
		public void EHKZYIDCFLX(IQLOSMXEQPE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x8D4B100", Offset = "0x8D49F00", VA = "0x188D4B100", Slot = "11")]
		public void DSBGFYTIKKV(IQLOSMXEQPE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x8D4B9E0", Offset = "0x8D4A7E0", VA = "0x188D4B9E0")]
		private void XXLPWTQARTJ(RRNetworkView a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x8D4B7F0", Offset = "0x8D4A5F0", VA = "0x188D4B7F0")]
		private void NXQLCPOLYTP(GDYMXZWVLQY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x8D4B580", Offset = "0x8D4A380", VA = "0x188D4B580")]
		private void JPKIKCOYMGW(RRNetworkView a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	internal static class QSORZPQNPCU
	{
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x8D4EA40", Offset = "0x8D4D840", VA = "0x188D4EA40")]
		public static YUFQPSJXKII Lifecycle(this IQLOSMXEQPE impl)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	internal sealed class YVYAUCTFICQ : OWLGPBGJMUN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private readonly HLSOFHFNATP QVRTYDABTIW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private RigidbodyConstraints VZRQTTPOYPH;

		[Cpp2IlInjected.Token(Token = "0x170000AE")]
		public bool RKTBCNSWZAS
		{
			[Cpp2IlInjected.Token(Token = "0x60002E9")]
			[Cpp2IlInjected.Address(RVA = "0xB856B0", Offset = "0xB844B0", VA = "0x180B856B0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002EA")]
			[Cpp2IlInjected.Address(RVA = "0xEBEC40", Offset = "0xEBDA40", VA = "0x180EBEC40", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AF")]
		public bool YTPHZTRKDQR
		{
			[Cpp2IlInjected.Token(Token = "0x60002EB")]
			[Cpp2IlInjected.Address(RVA = "0xB85700", Offset = "0xB84500", VA = "0x180B85700", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002EC")]
			[Cpp2IlInjected.Address(RVA = "0xEBEF90", Offset = "0xEBDD90", VA = "0x180EBEF90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B0")]
		public RigidbodyConstraints ZZNDPAKCEMV
		{
			[Cpp2IlInjected.Token(Token = "0x60002ED")]
			[Cpp2IlInjected.Address(RVA = "0xAC7B20", Offset = "0xAC6920", VA = "0x180AC7B20", Slot = "7")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x60002EE")]
			[Cpp2IlInjected.Address(RVA = "0x8D5BFA0", Offset = "0x8D5ADA0", VA = "0x188D5BFA0", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x8D5C100", Offset = "0x8D5AF00", VA = "0x188D5C100")]
		public YVYAUCTFICQ(IQLOSMXEQPE a, [In] RigidbodyExData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x8D5C0D0", Offset = "0x8D5AED0", VA = "0x188D5C0D0", Slot = "9")]
		public void TOEZMFUKDBQ(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x8D5BF70", Offset = "0x8D5AD70", VA = "0x188D5BF70", Slot = "10")]
		public void CGKVDMFFWEH(Rigidbody a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	internal sealed class TFRUDXMZUAT : HAMXNCHWVPQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private readonly IQLOSMXEQPE QVRTYDABTIW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private float NYSLLNOUBUZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private float CAAQRLYAQAJ;

		[Cpp2IlInjected.Token(Token = "0x170000B1")]
		public float ZAPFRGRGMIF
		{
			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0xB1A960", Offset = "0xB19760", VA = "0x180B1A960", Slot = "4")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60002F4")]
			[Cpp2IlInjected.Address(RVA = "0x8D56B40", Offset = "0x8D55940", VA = "0x188D56B40", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B2")]
		public float XTVIJLVUJGZ
		{
			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0xB1AB70", Offset = "0xB19970", VA = "0x180B1AB70", Slot = "6")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60002F6")]
			[Cpp2IlInjected.Address(RVA = "0x8D56A20", Offset = "0x8D55820", VA = "0x188D56A20", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x8D56C10", Offset = "0x8D55A10", VA = "0x188D56C10")]
		public TFRUDXMZUAT(IQLOSMXEQPE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x8D56AF0", Offset = "0x8D558F0", VA = "0x188D56AF0", Slot = "8")]
		public void TOEZMFUKDBQ(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x8D56980", Offset = "0x8D55780", VA = "0x188D56980", Slot = "9")]
		public void CGKVDMFFWEH(Rigidbody a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	internal sealed class MNKPQKJWEUF : XIHYGGHCGEO
	{
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static readonly Log AMIEKSUMBNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private readonly HLSOFHFNATP QVRTYDABTIW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private bool PRDDQXYNFCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private bool OLWDREDNKQP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private int GYVSHFYNLVF;

		[Cpp2IlInjected.Token(Token = "0x170000B3")]
		private Rigidbody LYLSFVCJLUL
		{
			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0x8D41880", Offset = "0x8D40680", VA = "0x188D41880")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B4")]
		private bool IMUKVBRLOYS
		{
			[Cpp2IlInjected.Token(Token = "0x60002FC")]
			[Cpp2IlInjected.Address(RVA = "0x8D4C770", Offset = "0x8D4B570", VA = "0x188D4C770")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B5")]
		private IQLOSMXEQPE IGSJTJYCBZZ
		{
			[Cpp2IlInjected.Token(Token = "0x60002FD")]
			[Cpp2IlInjected.Address(RVA = "0x8D4C5D0", Offset = "0x8D4B3D0", VA = "0x188D4C5D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B6")]
		private bool MGSTXVDYFSV
		{
			[Cpp2IlInjected.Token(Token = "0x60002FE")]
			[Cpp2IlInjected.Address(RVA = "0x8D4C2F0", Offset = "0x8D4B0F0", VA = "0x188D4C2F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400002D")]
		public event RbexAction JUWIFCNHEWK
		{
			[Cpp2IlInjected.Token(Token = "0x60002F9")]
			[Cpp2IlInjected.Address(RVA = "0x8D4C630", Offset = "0x8D4B430", VA = "0x188D4C630", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0x8D4C6D0", Offset = "0x8D4B4D0", VA = "0x188D4C6D0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x8D4C980", Offset = "0x8D4B780", VA = "0x188D4C980")]
		public MNKPQKJWEUF(IQLOSMXEQPE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x8D4BDA0", Offset = "0x8D4ABA0", VA = "0x188D4BDA0", Slot = "6")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x8D4C350", Offset = "0x8D4B150", VA = "0x188D4C350", Slot = "8")]
		public void IOKXWUTMHFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x8D4C480", Offset = "0x8D4B280", VA = "0x188D4C480", Slot = "7")]
		public bool MDBNRHUMEYC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x8D4C830", Offset = "0x8D4B630", VA = "0x188D4C830", Slot = "9")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x8D4C790", Offset = "0x8D4B590", VA = "0x188D4C790", Slot = "13")]
		public void SPPGBOIMTQW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x8D4C360", Offset = "0x8D4B160", VA = "0x188D4C360", Slot = "12")]
		public void JPLBCAPTUMZ(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x8D4C280", Offset = "0x8D4B080", VA = "0x188D4C280", Slot = "10")]
		public bool HYUAHANRLMG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x8D4C000", Offset = "0x8D4AE00", VA = "0x188D4C000", Slot = "11")]
		public bool FEXWPRZWKWL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x8D4BE30", Offset = "0x8D4AC30", VA = "0x188D4BE30")]
		private bool CIAMUSWQISJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x8D4C0F0", Offset = "0x8D4AEF0", VA = "0x188D4C0F0")]
		private void GBZNSQXKOFX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	internal sealed class SPBPFSQDVWG : DVYOJNKRSOH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private readonly HLSOFHFNATP QVRTYDABTIW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private readonly MSAILQECLZZ HPBJZVEKSSC;

		[Cpp2IlInjected.Token(Token = "0x170000B7")]
		public Rigidbody LYLSFVCJLUL
		{
			[Cpp2IlInjected.Token(Token = "0x600030B")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D20", Offset = "0xAC0B20", VA = "0x180AC1D20", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600030C")]
			[Cpp2IlInjected.Address(RVA = "0xAC0640", Offset = "0xABF440", VA = "0x180AC0640")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B8")]
		private bool MGSTXVDYFSV
		{
			[Cpp2IlInjected.Token(Token = "0x600030D")]
			[Cpp2IlInjected.Address(RVA = "0x8D56120", Offset = "0x8D54F20", VA = "0x188D56120")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B9")]
		public bool UIYYICBHWQO
		{
			[Cpp2IlInjected.Token(Token = "0x6000310")]
			[Cpp2IlInjected.Address(RVA = "0x1B02730", Offset = "0x1B01530", VA = "0x181B02730", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x8D56880", Offset = "0x8D55680", VA = "0x188D56880")]
		public SPBPFSQDVWG(IQLOSMXEQPE a, [In] RigidbodyExData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x8D56080", Offset = "0x8D54E80", VA = "0x188D56080", Slot = "5")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x8D564F0", Offset = "0x8D552F0", VA = "0x188D564F0", Slot = "7")]
		public void RHVNAXHJIII(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x8D56850", Offset = "0x8D55650", VA = "0x188D56850", Slot = "8")]
		public void ZXDRGCLXBDF(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x8D56520", Offset = "0x8D55320", VA = "0x188D56520", Slot = "9")]
		public void ZMMCZXEMGKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x8D56180", Offset = "0x8D54F80", VA = "0x188D56180", Slot = "10")]
		public void KUKHXWZJYOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x8D56370", Offset = "0x8D55170", VA = "0x188D56370", Slot = "11")]
		public void LWSBIAAAEZU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	internal sealed class WBKJTULIVPX : BVLWLVXGHOU, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private readonly HLSOFHFNATP QVRTYDABTIW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private readonly MSAILQECLZZ GSXHVGUWOSX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private float GZHXCUOYUSQ;

		[Cpp2IlInjected.Token(Token = "0x170000BA")]
		public TPQHYBXVCEA QLLABUJCDCN
		{
			[Cpp2IlInjected.Token(Token = "0x6000316")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F90", Offset = "0xABFD90", VA = "0x180AC0F90", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000317")]
			[Cpp2IlInjected.Address(RVA = "0xAC0650", Offset = "0xABF450", VA = "0x180AC0650", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		public XPPHMJGPLLF YWDVVAZVJEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000318")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F80", Offset = "0xABFD80", VA = "0x180AC0F80", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000319")]
			[Cpp2IlInjected.Address(RVA = "0xAC8C50", Offset = "0xAC7A50", VA = "0x180AC8C50", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BC")]
		public Vector3 DVFUTEPXRTY
		{
			[Cpp2IlInjected.Token(Token = "0x600031A")]
			[Cpp2IlInjected.Address(RVA = "0x8D594E0", Offset = "0x8D582E0", VA = "0x188D594E0", Slot = "8")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600031B")]
			[Cpp2IlInjected.Address(RVA = "0x8D5ABE0", Offset = "0x8D599E0", VA = "0x188D5ABE0", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BD")]
		public Vector3 SNLHSEGSKSZ
		{
			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(RVA = "0x8D59E10", Offset = "0x8D58C10", VA = "0x188D59E10", Slot = "10")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600031D")]
			[Cpp2IlInjected.Address(RVA = "0x8D597D0", Offset = "0x8D585D0", VA = "0x188D597D0", Slot = "11")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BE")]
		public Vector3 JEKLOACQCVU
		{
			[Cpp2IlInjected.Token(Token = "0x600031E")]
			[Cpp2IlInjected.Address(RVA = "0x8D5AA90", Offset = "0x8D59890", VA = "0x188D5AA90", Slot = "12")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600031F")]
			[Cpp2IlInjected.Address(RVA = "0x8D5A700", Offset = "0x8D59500", VA = "0x188D5A700", Slot = "13")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BF")]
		public Vector3 VGNNJDXULRJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000320")]
			[Cpp2IlInjected.Address(RVA = "0x8D58CA0", Offset = "0x8D57AA0", VA = "0x188D58CA0", Slot = "14")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0x8D5A980", Offset = "0x8D59780", VA = "0x188D5A980", Slot = "15")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C0")]
		public float GEKAIAQUVBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000322")]
			[Cpp2IlInjected.Address(RVA = "0xB1A860", Offset = "0xB19660", VA = "0x180B1A860", Slot = "16")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000323")]
			[Cpp2IlInjected.Address(RVA = "0x8D57E60", Offset = "0x8D56C60", VA = "0x188D57E60", Slot = "17")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C1")]
		public bool IEPPXZXXNHQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000324")]
			[Cpp2IlInjected.Address(RVA = "0x2530540", Offset = "0x252F340", VA = "0x182530540", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C2")]
		private YODEMQIHVZA GQDNELMYNZE
		{
			[Cpp2IlInjected.Token(Token = "0x6000339")]
			[Cpp2IlInjected.Address(RVA = "0x82DFB40", Offset = "0x82DE940", VA = "0x1882DFB40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C3")]
		private bool IMUKVBRLOYS
		{
			[Cpp2IlInjected.Token(Token = "0x600033A")]
			[Cpp2IlInjected.Address(RVA = "0x8D59F30", Offset = "0x8D58D30", VA = "0x188D59F30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x8D5ADC0", Offset = "0x8D59BC0", VA = "0x188D5ADC0")]
		public WBKJTULIVPX(IQLOSMXEQPE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x8D57DC0", Offset = "0x8D56BC0", VA = "0x188D57DC0", Slot = "19")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x8D58A00", Offset = "0x8D57800", VA = "0x188D58A00", Slot = "36")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x8D5A570", Offset = "0x8D59370", VA = "0x188D5A570", Slot = "28")]
		public void TOEZMFUKDBQ(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x18D7630", Offset = "0x18D6430", VA = "0x1818D7630", Slot = "20")]
		public void JDMHZQTHVZK(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x18D5C90", Offset = "0x18D4A90", VA = "0x1818D5C90", Slot = "30")]
		public void JRHXWSAWMFF(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x8D58A60", Offset = "0x8D57860", VA = "0x188D58A60", Slot = "35")]
		public Vector3 FEHJGEGGUAI(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x8D58840", Offset = "0x8D57640", VA = "0x188D58840", Slot = "34")]
		public Vector3 DXKAJEUUKVM(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x8D57DC0", Offset = "0x8D56BC0", VA = "0x188D57DC0", Slot = "27")]
		public void OEVZVDJNBBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x8D58C40", Offset = "0x8D57A40", VA = "0x188D58C40", Slot = "25")]
		public void FEVTTANKFOW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x8D5A6A0", Offset = "0x8D594A0", VA = "0x188D5A6A0", Slot = "24")]
		public void TTNPXHXBYBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x8D592A0", Offset = "0x8D580A0", VA = "0x188D592A0", Slot = "33")]
		public void IQLJSAKGEXJ(Vector3 a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x8D58DC0", Offset = "0x8D57BC0", VA = "0x188D58DC0", Slot = "32")]
		public void GLRZINOHTSW(Vector3 a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x8D59630", Offset = "0x8D58430", VA = "0x188D59630", Slot = "31")]
		public void IZZUETQUKXR(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x8D581F0", Offset = "0x8D56FF0", VA = "0x188D581F0", Slot = "22")]
		public void DWZRKRYIUGD(RbexImpulseType a, Vector3 b, float c, float d = 8f, float e = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x8D57F70", Offset = "0x8D56D70", VA = "0x188D57F70", Slot = "21")]
		public void DQNDSWQYHNI(RbexRotationType a, Vector3 b, float c = 1f / 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x8D58E20", Offset = "0x8D57C20", VA = "0x188D58E20", Slot = "23")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void IBZFDEMKQUN(RbexRotationType a, Vector3 b, float c = 7f, float d = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x1A126A0", Offset = "0x1A114A0", VA = "0x181A126A0")]
		private static void ECGIMVVBULV(Vector3 a, Vector3 b, [Out] Vector3 c, [Out] Vector3 d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x8D5A9B0", Offset = "0x8D597B0", VA = "0x188D5A9B0", Slot = "29")]
		public Vector3 VEEYJMDVERW(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x8D59C80", Offset = "0x8D58A80", VA = "0x188D59C80", Slot = "26")]
		public void NZGXMTNXECX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x8D57E60", Offset = "0x8D56C60", VA = "0x188D57E60")]
		private void CFKGKVQOXTQ(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x8D5A3D0", Offset = "0x8D591D0", VA = "0x188D5A3D0")]
		private void TMZQYHRICKM(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x8D5A7C0", Offset = "0x8D595C0", VA = "0x188D5A7C0")]
		private Vector3 UNDCKTYLGJV()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x8D59F50", Offset = "0x8D58D50", VA = "0x188D59F50")]
		private void SLTOJHNBDPZ(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x8D5ACA0", Offset = "0x8D59AA0", VA = "0x188D5ACA0")]
		private Vector3 ZJETCNNRZNT()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x8D59800", Offset = "0x8D58600", VA = "0x188D59800")]
		private void NXCIYSUJHCV(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x8D57960", Offset = "0x8D56760", VA = "0x188D57960")]
		private void ADPILJZQPFA(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x8D5A8D0", Offset = "0x8D596D0", VA = "0x188D5A8D0")]
		private void UPVKBUHWAMI()
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
