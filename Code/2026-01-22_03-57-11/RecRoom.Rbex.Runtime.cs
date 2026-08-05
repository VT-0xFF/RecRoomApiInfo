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
		[Cpp2IlInjected.Address(RVA = "0xAD7680", Offset = "0xAD5E80", VA = "0x180AD7680")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD7850", Offset = "0xAD6050", VA = "0x180AD7850")]
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
		[Cpp2IlInjected.Address(RVA = "0x8ABE060", Offset = "0x8ABC860", VA = "0x188ABE060", Slot = "4")]
		public override void JPLRKQDWIBU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xAD7680", Offset = "0xAD5E80", VA = "0x180AD7680")]
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
		private int[] GGRLHWHSZPT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private ServiceBitset ERVRXHKVDYW;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xAAD0F0", Offset = "0xAAB8F0", VA = "0x180AAD0F0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x84A6090", Offset = "0x84A4890", VA = "0x1884A6090", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8AC8280", Offset = "0x8AC6A80", VA = "0x188AC8280")]
		private void LJCGTCDSEAS(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8AC8560", Offset = "0x8AC6D60", VA = "0x188AC8560", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8AC85C0", Offset = "0x8AC6DC0", VA = "0x188AC85C0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[DisallowMultipleComponent]
	public sealed class RigidbodyEx : MonoBehaviour, CSFUYHSFTRK, UUABPUADKWL, EDCHCMGEZQJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static readonly Log EINUZVRDADX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private bool HFIZUVLDJBZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private KCFXUMCPMEW HYKNJZXIWBX;

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
		private Transform USWIOGGZUMX;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal KCFXUMCPMEW VYKXYSPHZOV
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x8AC49E0", Offset = "0x8AC31E0", VA = "0x188AC49E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private KCFXUMCPMEW NZCHROCZXFX
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xAAD0F0", Offset = "0xAAB8F0", VA = "0x180AAD0F0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int ZYWTLNHSZCK
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x8AC56D0", Offset = "0x8AC3ED0", VA = "0x188AC56D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RigidbodyEx YBOOLLWXJMX
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x8AC5A30", Offset = "0x8AC4230", VA = "0x188AC5A30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx PUSUXZYIEUP
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x8AC5970", Offset = "0x8AC4170", VA = "0x188AC5970")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RigidbodyEx PKLBYNGIDZN
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x8AC6630", Offset = "0x8AC4E30", VA = "0x188AC6630")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x8AC7B30", Offset = "0x8AC6330", VA = "0x188AC7B30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool DidStart
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x7E8B8A0", Offset = "0x7E8A0A0", VA = "0x187E8B8A0", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x7E8B9F0", Offset = "0x7E8A1F0", VA = "0x187E8B9F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Transform IBPLMINYERD
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x2357040", Offset = "0x2355840", VA = "0x182357040", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Transform UEZVDZEJSYM
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x2357040", Offset = "0x2355840", VA = "0x182357040", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Transform AXBWBIRWQWK
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x2357040", Offset = "0x2355840", VA = "0x182357040", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public TransformTrackRate GFITEATAJJS
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x8AC5730", Offset = "0x8AC3F30", VA = "0x188AC5730")]
			get
			{
				return default(TransformTrackRate);
			}
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x8AC72E0", Offset = "0x8AC5AE0", VA = "0x188AC72E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool NTJLJSEQBCZ
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x8AC5D40", Offset = "0x8AC4540", VA = "0x188AC5D40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool YCTRVLEUCOR
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x8AC5850", Offset = "0x8AC4050", VA = "0x188AC5850")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public URFBIYRPPUA UPWGPIMLPQV
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x8AC5C80", Offset = "0x8AC4480", VA = "0x188AC5C80")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x8AC74A0", Offset = "0x8AC5CA0", VA = "0x188AC74A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public KHHLPOITIKH LBXQSVZEMZW
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x8AC5C20", Offset = "0x8AC4420", VA = "0x188AC5C20")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x8AC7430", Offset = "0x8AC5C30", VA = "0x188AC7430")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool WHUXSGFFTHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x8AC5B70", Offset = "0x8AC4370", VA = "0x188AC5B70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Rigidbody KZZPYUWZQUT
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x8AC5BD0", Offset = "0x8AC43D0", VA = "0x188AC5BD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool XNSYEZHAWPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x8AC58B0", Offset = "0x8AC40B0", VA = "0x188AC58B0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x8AC7350", Offset = "0x8AC5B50", VA = "0x188AC7350")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool HVKPGSOAZTZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x173F0D0", Offset = "0x173D8D0", VA = "0x18173F0D0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float DHQLBPXSRVB
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x8AC65D0", Offset = "0x8AC4DD0", VA = "0x188AC65D0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float UFSYCOCOEME
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x8AC6570", Offset = "0x8AC4D70", VA = "0x188AC6570")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x8AC7AC0", Offset = "0x8AC62C0", VA = "0x188AC7AC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public float MVZRCCBOGMZ
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x8AC5FA0", Offset = "0x8AC47A0", VA = "0x188AC5FA0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x8AC7740", Offset = "0x8AC5F40", VA = "0x188AC7740")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public float PWDSBDXWGZD
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x8AC5DA0", Offset = "0x8AC45A0", VA = "0x188AC5DA0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x8AC7510", Offset = "0x8AC5D10", VA = "0x188AC7510")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public bool YQVXYJJFOWU
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x8AC6B80", Offset = "0x8AC5380", VA = "0x188AC6B80")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x8AC8070", Offset = "0x8AC6870", VA = "0x188AC8070")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Vector3 XUYTJXIQJUG
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x8AC6350", Offset = "0x8AC4B50", VA = "0x188AC6350")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x8AC7890", Offset = "0x8AC6090", VA = "0x188AC7890")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public Vector3 ZQMKGJUMGVL
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x8AC6CC0", Offset = "0x8AC54C0", VA = "0x188AC6CC0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public CollisionDetectionMode SILHOZFGTUD
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x8AC5EE0", Offset = "0x8AC46E0", VA = "0x188AC5EE0")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x8AC7660", Offset = "0x8AC5E60", VA = "0x188AC7660")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public float KZQWAJUTWVG
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x8AC5910", Offset = "0x8AC4110", VA = "0x188AC5910")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x8AC73C0", Offset = "0x8AC5BC0", VA = "0x188AC73C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public RigidbodyConstraints PYOZIUIHCLD
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x8AC5F40", Offset = "0x8AC4740", VA = "0x188AC5F40")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x8AC76D0", Offset = "0x8AC5ED0", VA = "0x188AC76D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public Vector3 BGHLWEAPDOT
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x8AC66F0", Offset = "0x8AC4EF0", VA = "0x188AC66F0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public Vector3 WEPZOIMTVWB
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x8AC66F0", Offset = "0x8AC4EF0", VA = "0x188AC66F0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x8AC7E50", Offset = "0x8AC6650", VA = "0x188AC7E50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public float TQKMLRGCKZC
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x8AC6430", Offset = "0x8AC4C30", VA = "0x188AC6430")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x8AC7970", Offset = "0x8AC6170", VA = "0x188AC7970")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public float RHZQVZKTTYN
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x8AC6B20", Offset = "0x8AC5320", VA = "0x188AC6B20")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x8AC8000", Offset = "0x8AC6800", VA = "0x188AC8000")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Quaternion XEKRPWLLSNE
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x8AC67D0", Offset = "0x8AC4FD0", VA = "0x188AC67D0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x8AC7BD0", Offset = "0x8AC63D0", VA = "0x188AC7BD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Quaternion ICBMQPLKSQM
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x8AC6A50", Offset = "0x8AC5250", VA = "0x188AC6A50")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x8AC7F30", Offset = "0x8AC6730", VA = "0x188AC7F30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector3 TSAZQUCEFBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x8AC68A0", Offset = "0x8AC50A0", VA = "0x188AC68A0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x8AC7CA0", Offset = "0x8AC64A0", VA = "0x188AC7CA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Quaternion TSXOYXPHQWL
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x8AC6980", Offset = "0x8AC5180", VA = "0x188AC6980")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x8AC7D80", Offset = "0x8AC6580", VA = "0x188AC7D80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 QIPXIFWGIMU
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x8AC6BE0", Offset = "0x8AC53E0", VA = "0x188AC6BE0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x8AC80E0", Offset = "0x8AC68E0", VA = "0x188AC80E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 TWWYMSKJIYJ
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x8AC6490", Offset = "0x8AC4C90", VA = "0x188AC6490")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x8AC79E0", Offset = "0x8AC61E0", VA = "0x188AC79E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector3 HEMUGKKIUMI
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x8AC5E00", Offset = "0x8AC4600", VA = "0x188AC5E00")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x8AC7580", Offset = "0x8AC5D80", VA = "0x188AC7580")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector3 RDONRFBIZDB
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x8AC6270", Offset = "0x8AC4A70", VA = "0x188AC6270")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x8AC77B0", Offset = "0x8AC5FB0", VA = "0x188AC77B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector3 HWRJAJOPBEO
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x8AC6130", Offset = "0x8AC4930", VA = "0x188AC6130")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Quaternion NIFXULDTLLO
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x8AC6060", Offset = "0x8AC4860", VA = "0x188AC6060")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public Vector3 IFVOSYRPZHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x8AC6E80", Offset = "0x8AC5680", VA = "0x188AC6E80")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public Vector3 DUIEMLINFWQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x8AC6DA0", Offset = "0x8AC55A0", VA = "0x188AC6DA0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool DEXMMARJQZG
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x8AC6210", Offset = "0x8AC4A10", VA = "0x188AC6210")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool EKFYOKZYXUV
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x8AC5CE0", Offset = "0x8AC44E0", VA = "0x188AC5CE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool VZBGJJIMZAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x8AC57F0", Offset = "0x8AC3FF0", VA = "0x188AC57F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool TJRTPRQNFBR
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x8AC5790", Offset = "0x8AC3F90", VA = "0x188AC5790")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool HYOAWBJMQJI
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x8AC5670", Offset = "0x8AC3E70", VA = "0x188AC5670")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public bool QBSPIGAVIPT
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x8AC6000", Offset = "0x8AC4800", VA = "0x188AC6000")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool XBJSXLTIPVF
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xB895B0", Offset = "0xB87DB0", VA = "0x180B895B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event RbexParentChangeAction NRPQYRFSUZZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x8AC5590", Offset = "0x8AC3D90", VA = "0x188AC5590")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x8AC7200", Offset = "0x8AC5A00", VA = "0x188AC7200")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event RbexAction WGZXGOMOCVN
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x8AC5300", Offset = "0x8AC3B00", VA = "0x188AC5300")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x8AC6F60", Offset = "0x8AC5760", VA = "0x188AC6F60")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event RbexAction JULWETWZKIR
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x8AC5360", Offset = "0x8AC3B60", VA = "0x188AC5360")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x8AC6FD0", Offset = "0x8AC57D0", VA = "0x188AC6FD0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event RbexAction ZITAUSZTNIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x8AC54B0", Offset = "0x8AC3CB0", VA = "0x188AC54B0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x8AC7120", Offset = "0x8AC5920", VA = "0x188AC7120")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<UpdateLOD, UpdateLOD> HAFSXKFNVMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x8AC5440", Offset = "0x8AC3C40", VA = "0x188AC5440")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x8AC70B0", Offset = "0x8AC58B0", VA = "0x188AC70B0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event RbexAction KBKZHAXRZWM
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x8AC5520", Offset = "0x8AC3D20", VA = "0x188AC5520")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x8AC7190", Offset = "0x8AC5990", VA = "0x188AC7190")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event RbexAction DDXIWIGBNDM
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x8AC5600", Offset = "0x8AC3E00", VA = "0x188AC5600")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x8AC7270", Offset = "0x8AC5A70", VA = "0x188AC7270")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event RbexAction VSFDSEPITSF
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x8AC53D0", Offset = "0x8AC3BD0", VA = "0x188AC53D0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x8AC7040", Offset = "0x8AC5840", VA = "0x188AC7040")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xAB0170", Offset = "0xAAE970", VA = "0x180AB0170", Slot = "8")]
		private void LTTYCAFDOFF(KCFXUMCPMEW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8AC3C80", Offset = "0x8AC2480", VA = "0x188AC3C80", Slot = "9")]
		public RigidbodyExData GetData()
		{
			return default(RigidbodyExData);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8AC3F70", Offset = "0x8AC2770", VA = "0x188AC3F70")]
		internal void KSGLXAOHRQK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8AC5030", Offset = "0x8AC3830", VA = "0x188AC5030")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public void TestOverrideUnityRigidbody(Rigidbody rb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8AC39D0", Offset = "0x8AC21D0", VA = "0x188AC39D0")]
		public CSFUYHSFTRK GetChild(int index)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x8AC4C90", Offset = "0x8AC3490", VA = "0x188AC4C90")]
		public void SetInertiaTensor((Quaternion rot, Vector3 moments) tensor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x8AC3620", Offset = "0x8AC1E20", VA = "0x188AC3620")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x8AC4F20", Offset = "0x8AC3720", VA = "0x188AC4F20")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8AC49E0", Offset = "0x8AC31E0", VA = "0x188AC49E0")]
		private KCFXUMCPMEW SJSGQHHKZXN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8AC42F0", Offset = "0x8AC2AF0", VA = "0x188AC42F0")]
		private void RUCBQSMBUXH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8AC4230", Offset = "0x8AC2A30", VA = "0x188AC4230")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x8AC4170", Offset = "0x8AC2970", VA = "0x188AC4170")]
		public void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x8AC3F70", Offset = "0x8AC2770", VA = "0x188AC3F70")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8AC41D0", Offset = "0x8AC29D0", VA = "0x188AC41D0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8AC4290", Offset = "0x8AC2A90", VA = "0x188AC4290")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8AC2C10", Offset = "0x8AC1410", VA = "0x188AC2C10")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x8AC4470", Offset = "0x8AC2C70", VA = "0x188AC4470")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8AC3970", Offset = "0x8AC2170", VA = "0x188AC3970")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x8AC4110", Offset = "0x8AC2910", VA = "0x188AC4110")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x8AC4DF0", Offset = "0x8AC35F0", VA = "0x188AC4DF0")]
		public void SetParent(RigidbodyEx value, bool isPhysicallyDetachedOnly = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x8AC4780", Offset = "0x8AC2F80", VA = "0x188AC4780")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8AC3D10", Offset = "0x8AC2510", VA = "0x188AC3D10")]
		public bool IsRigidbodyAncestor(RigidbodyEx possibleAncestor)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8AC3E10", Offset = "0x8AC2610", VA = "0x188AC3E10")]
		public bool IsRigidbodyDescendant(RigidbodyEx possibleDescendant)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8AC2E80", Offset = "0x8AC1680", VA = "0x188AC2E80")]
		public void AddInterpolationRestriction(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8AC44E0", Offset = "0x8AC2CE0", VA = "0x188AC44E0")]
		public void RemoveInterpolationRestriction(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x8AC2EF0", Offset = "0x8AC16F0", VA = "0x188AC2EF0")]
		public void AddKinematic(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x8AC4550", Offset = "0x8AC2D50", VA = "0x188AC4550")]
		public void RemoveKinematic(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x8AC4D70", Offset = "0x8AC3570", VA = "0x188AC4D70")]
		public void SetKinematic(object token, bool setKinematic)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x8AC4B90", Offset = "0x8AC3390", VA = "0x188AC4B90")]
		public void SetDiscontinuousPositionAndRotation(Vector3 newPosition, Quaternion newRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x8AC4A90", Offset = "0x8AC3290", VA = "0x188AC4A90")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 newLocalPosition, Quaternion newLocalRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x8AC3B70", Offset = "0x8AC2370", VA = "0x188AC3B70")]
		public Vector3 GetConstrainedVelocity(Vector3 velocity)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x8AC3A60", Offset = "0x8AC2260", VA = "0x188AC3A60")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 angularVelocity)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8AC2D90", Offset = "0x8AC1590", VA = "0x188AC2D90")]
		public void AddForce(Vector3 force, ForceMode forceMode = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x8AC2C80", Offset = "0x8AC1480", VA = "0x188AC2C80")]
		public void AddForceAtPosition(Vector3 force, Vector3 position, ForceMode forceMode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8AC30C0", Offset = "0x8AC18C0", VA = "0x188AC30C0")]
		public void AddTorque(Vector3 torque, ForceMode forceMode = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x8AC2F60", Offset = "0x8AC1760", VA = "0x188AC2F60")]
		public void AddRelativeTorque(Vector3 torque, ForceMode forceMode = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8AC5100", Offset = "0x8AC3900", VA = "0x188AC5100")]
		public Vector3 WorldToLocalVelocity(Vector3 worldVelocity)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8AC4000", Offset = "0x8AC2800", VA = "0x188AC4000")]
		public Vector3 LocalToWorldVelocity(Vector3 localVelocity)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8AC3910", Offset = "0x8AC2110", VA = "0x188AC3910")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8AC38B0", Offset = "0x8AC20B0", VA = "0x188AC38B0")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8AC3850", Offset = "0x8AC2050", VA = "0x188AC3850")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8AC37F0", Offset = "0x8AC1FF0", VA = "0x188AC37F0")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x8AC48E0", Offset = "0x8AC30E0", VA = "0x188AC48E0")]
		public void ResetVelocityWorldSpace(Vector3 worldLinearVelocity, Vector3 worldAngularVelocity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x8AC47E0", Offset = "0x8AC2FE0", VA = "0x188AC47E0")]
		public void ResetVelocityLocalSpace(Vector3 localLinearVelocity, Vector3 localAngularVelocity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x8AC46A0", Offset = "0x8AC2EA0", VA = "0x188AC46A0")]
		public void ResetLinearVelocityLocalSpace(Vector3 localLinearVelocity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x8AC4F30", Offset = "0x8AC3730", VA = "0x188AC4F30")]
		public bool SweepTest(Vector3 direction, [Out] RaycastHit hitInfo, float maxDistance)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x8AC3F10", Offset = "0x8AC2710", VA = "0x188AC3F10")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x8AC4EC0", Offset = "0x8AC36C0", VA = "0x188AC4EC0")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x8AC50A0", Offset = "0x8AC38A0", VA = "0x188AC50A0")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x8AC3050", Offset = "0x8AC1850", VA = "0x188AC3050")]
		public void AddShouldHaveUnityRigidbodyToken(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x8AC45C0", Offset = "0x8AC2DC0", VA = "0x188AC45C0")]
		public void RemoveShouldHaveUnityRigidbodyToken(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x8AC3450", Offset = "0x8AC1C50", VA = "0x188AC3450")]
		public void ApplyForceVelocityChange(RbexImpulseType impulseType, Vector3 impulseDirection, float impulseSpeed, float impulseDirectionMaxSpeed = 8f, float impulseReflectiveRestitution = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x8AC3350", Offset = "0x8AC1B50", VA = "0x188AC3350")]
		public void ApplyAngularVelocityChange(RbexRotationType rotationType, Vector3 newAngularVelocity, float maxAngularSpeed = 1f / 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x8AC3510", Offset = "0x8AC1D10", VA = "0x188AC3510")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void ApplyTorqueAngularVelocityChangeDeprecated(RbexRotationType rotationType, Vector3 rotation, float maxSpeed = 7f, float multiplyingFactor = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x8AC3280", Offset = "0x8AC1A80", VA = "0x188AC3280")]
		public bool AllowedScaleChange(float scaleFactor)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x8AC31B0", Offset = "0x8AC19B0", VA = "0x188AC31B0")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx parentOverride, object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x8AC4630", Offset = "0x8AC2E30", VA = "0x188AC4630")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x8AC2C00", Offset = "0x8AC1400", VA = "0x188AC2C00", Slot = "13")]
		private void ADUQWHDSEBO(ZZGKOUTYAVY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x8AC5290", Offset = "0x8AC3A90", VA = "0x188AC5290")]
		public RigidbodyEx()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x127AB40", Offset = "0x1279340", VA = "0x18127AB40", Slot = "4")]
		private GameObject YRYVPPMQZZJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0xADA470", Offset = "0xAD8C70", VA = "0x180ADA470", Slot = "10")]
		private bool VJMNVISDHZK()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	internal static class FUDNSBZEJCR
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x8ABB3E0", Offset = "0x8AB9BE0", VA = "0x188ABB3E0")]
		public static KCFXUMCPMEW VYKXYSPHZOV(this RigidbodyEx a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[RegisterService(typeof(ZFHSIHJPIZV), new string[] { })]
	public class RigidbodyExManager : ZFHSIHJPIZV, NDLMBBFOQSV
	{
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static readonly Log WKLAFLLOLVN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private UPTLOSEBHVK UBLEZUXYRFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private ACJUUDGBBPJ TFWEGQJMNQD;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public UPTLOSEBHVK PXMXJJKOWOR
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xAACAC0", Offset = "0xAAB2C0", VA = "0x180AACAC0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public ACJUUDGBBPJ VJIPUDGVYDR
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xAACA70", Offset = "0xAAB270", VA = "0x180AACA70", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x8AC2940", Offset = "0x8AC1140", VA = "0x188AC2940", Slot = "7")]
		public void InitReferences(MZUBMRWQSAC services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x8AC29B0", Offset = "0x8AC11B0", VA = "0x188AC29B0", Slot = "6")]
		public KCFXUMCPMEW TZIRVECOOAV(RigidbodyEx a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		public RigidbodyExManager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class PhysicsManager : SingletonMonoBehaviour<PhysicsManager>
	{
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static XOOCNKBZGKP UpdateAfterFixedUpdateRan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private int DPPEUBNTPQT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private int DRBXAQZLLBZ;

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x8ABFAB0", Offset = "0x8ABE2B0", VA = "0x188ABFAB0")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x8ABFB30", Offset = "0x8ABE330", VA = "0x188ABFB30")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x8ABFAD0", Offset = "0x8ABE2D0", VA = "0x188ABFAD0")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string message, [Optional] UnityEngine.Object context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string message, [Optional] UnityEngine.Object context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x8ABFC20", Offset = "0x8ABE420", VA = "0x188ABFC20")]
		public PhysicsManager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public static class OAMHNEYVYRF
	{
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		private class QBJGSAMKXQL : URFBIYRPPUA, IDisposable
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "7")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0xABD440", Offset = "0xABBC40", VA = "0x180ABD440", Slot = "4")]
			public Vector3 MBADHEMNUSK()
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0xABD440", Offset = "0xABBC40", VA = "0x180ABD440", Slot = "5")]
			public Vector3 CRIZQNFQEPP()
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0xAC7BA0", Offset = "0xAC63A0", VA = "0x180AC7BA0", Slot = "6")]
			public bool NGTPPSFJEWA(float a, float b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public QBJGSAMKXQL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public static URFBIYRPPUA BENGDIJTXTI
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x8ABEAA0", Offset = "0x8ABD2A0", VA = "0x188ABEAA0")]
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
	public interface OQZILHVPXOY
	{
		[Cpp2IlInjected.Token(Token = "0x17000039")]
		CollisionDetectionMode ZKUPIUCJZXV
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
		void ECEPGIHUYLL(bool a);

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void TDGAKSTGFGE(bool a);

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void TVVGGWJARMG(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool XQUTBHAWBQB(Vector3 a, [Out] RaycastHit b, float c);
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public interface GCAKZFBQRQB : IDisposable, QKLXQYHXXNL
	{
		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		TransformTrackRate GFITEATAJJS
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		event Action<UpdateLOD, UpdateLOD> HAFSXKFNVMF;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void Awake();
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[ServiceLifetime(Lifetime.Application)]
	public interface ACJUUDGBBPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		WCYQGCLDDOC VNWWFXRSVPE(KCFXUMCPMEW a);

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		BXBITBABXKA DRMIVOACVPC(KCFXUMCPMEW a);

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		EFSYUOMQKCN FADVOJOXQAV(KCFXUMCPMEW a);

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		EFDEPUUANJQ RZLNFDGSPOC(KCFXUMCPMEW a);

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "4")]
		LPGZOIBPVVU HFSLBVFAYUG(KCFXUMCPMEW a);

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "5")]
		GCAKZFBQRQB IHTDEQCDHRD(KCFXUMCPMEW a);

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "6")]
		KSZTPFCZMTC OFCBMDWTUZK(KCFXUMCPMEW a);

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "7")]
		UYDITCYYVQG OSWUDTFDAXI(KCFXUMCPMEW a);

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "8")]
		OQZILHVPXOY AFFYUDEPBPC(KCFXUMCPMEW a);

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "9")]
		RDTKIPQQRVB CQMMKARWMJJ(KCFXUMCPMEW a);

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "10")]
		MQEDLLPVLMT VZGSASKAVSL(KCFXUMCPMEW a, [In] RigidbodyExData data);

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "11")]
		JRFWRDYSFSZ EIAMZAIJOPH(KCFXUMCPMEW a, [In] RigidbodyExData data);

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "12")]
		BIYDIZDMADJ MSAUQAPZLAH(KCFXUMCPMEW a, [In] RigidbodyExData data);

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "13")]
		DMDWVMLYSNP WWEVCMWVECZ(KCFXUMCPMEW a, [In] RigidbodyExData data);

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "14")]
		AFEYQHWEQMJ ORYMFEEUFMR(KCFXUMCPMEW a, [In] RigidbodyExData data);

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "15")]
		KCFXUMCPMEW TZIRVECOOAV(RigidbodyEx a, RigidbodyExData b, ZFHSIHJPIZV c);
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface UYDITCYYVQG
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void WPXTKJOXWGZ(Vector3 a, ForceMode b = ForceMode.Force);

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void QBXQEJWLRXJ(Vector3 a, Vector3 b, ForceMode c);

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void OCNOMMRBKGY(Vector3 a, ForceMode b = ForceMode.Force);

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void UZAAFJTBTKU(Vector3 a, ForceMode b = ForceMode.Force);
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface RDTKIPQQRVB
	{
		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		bool ZDRJBUTWAYQ
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
		void TVVGGWJARMG(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void RXJVNBVWDRN(Rigidbody a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public interface WCYQGCLDDOC : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		IReadOnlyList<KCFXUMCPMEW> ALCKLGXMEQH
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(Slot = "18")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		KCFXUMCPMEW PUSUXZYIEUP
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(Slot = "19")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		KCFXUMCPMEW LUZXDGFNRIX
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(Slot = "20")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(Slot = "21")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		event RbexAction WGZXGOMOCVN;

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		event RbexAction JULWETWZKIR;

		[Cpp2IlInjected.Token(Token = "0x1400000C")]
		event RbexParentChangeAction ZUGRGVVLUMJ;

		[Cpp2IlInjected.Token(Token = "0x1400000D")]
		event Action ZCNDRSZSEAM;

		[Cpp2IlInjected.Token(Token = "0x1400000E")]
		event Action QIMJXSVSGDX;

		[Cpp2IlInjected.Token(Token = "0x1400000F")]
		event Action<KCFXUMCPMEW> SXYUQSURFOI;

		[Cpp2IlInjected.Token(Token = "0x14000010")]
		event Action<KCFXUMCPMEW> PCQHWSUJMZV;

		[Cpp2IlInjected.Token(Token = "0x14000011")]
		event Action SREVJWXYFTC;

		[Cpp2IlInjected.Token(Token = "0x14000012")]
		event Action<KCFXUMCPMEW> RMXSPNMEHVH;

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "22")]
		void SetParent(KCFXUMCPMEW newParent, bool isPhysicallyDetachedOnly = false);
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public interface EFSYUOMQKCN
	{
		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		Vector3 HLLOTYUYZSU
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		Vector3 AMJTMNIIVKQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void SBAEZBXPCBE(KCFXUMCPMEW a, object b);

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void HADFHIFJZPF(object a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public interface DMDWVMLYSNP
	{
		[Cpp2IlInjected.Token(Token = "0x17000041")]
		Vector3 PZLHCVPMVLQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		Vector3 KTNQBTXQNEZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		float NAAXVPFYAUP
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		float XLIFLXKNOJS
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(Slot = "7")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		Vector3 VMDUPMYJMRA
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		Quaternion RCANEXIIULS
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000013")]
		event RbexAction BTAZSIRPDPH;

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void QSBXUDHMGOA((Quaternion rot, Vector3 moments) tensor);

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(Slot = "11")]
		void NFPVABQYXXJ();

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void HLPLLOBFRRC();

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(Slot = "13")]
		void XSLTZWPDBDE();

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void TVVGGWJARMG(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void RXJVNBVWDRN(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void OnDrawGizmosSelected();
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public interface BIYDIZDMADJ
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Awake();

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void VROUICKXTXW(object a);

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void PCMBINFPXQH(object a);

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void RWZKIRCWNLZ(KCFXUMCPMEW a);

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void XWCYTYGEZQW(KCFXUMCPMEW a);

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void WWXUUPCBNDB();
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public interface KSZTPFCZMTC
	{
		[Cpp2IlInjected.Token(Token = "0x17000047")]
		bool VGTBCFGYYRO
		{
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000014")]
		event RbexAction RXBREEHNZTC;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void QOYUWQXNMRR(object a);

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void YNSFSUVTQHS(object a);

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void FVQDXJJBWWG(object a, bool b);

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void TVVGGWJARMG(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void RXJVNBVWDRN(Rigidbody a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface JRFWRDYSFSZ : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000048")]
		bool NTJLJSEQBCZ
		{
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		bool YCTRVLEUCOR
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000015")]
		event RbexAction EVQNVPIJSQC;

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void Awake();

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void XINNDDBIWJD(KCFXUMCPMEW a);

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void FFYMVTYPVQJ(KCFXUMCPMEW a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface AFEYQHWEQMJ
	{
		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		bool XNSYEZHAWPM
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		bool UKLSYGQYQQZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		RigidbodyConstraints ABXTYPHYPLX
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
		void TVVGGWJARMG(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void RXJVNBVWDRN(Rigidbody a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface EFDEPUUANJQ
	{
		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		float YOGAWRHUNFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		float ATZZTYKAKMF
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
		void TVVGGWJARMG(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void RXJVNBVWDRN(Rigidbody a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public interface LPGZOIBPVVU
	{
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		static bool JZSERRYIBPA;

		[Cpp2IlInjected.Token(Token = "0x14000016")]
		event RbexAction ONHGMNQQKRY;

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void Awake();

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool MQGIXWISZSG();

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void DSRHWURTWYA();

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void Sleep();

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool GCGEZQXNRNI();

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool OXEUXRTHKRJ();

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void TSDLVYPWTHL(bool a);

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void PNJTSCXQOYG();
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public interface MQEDLLPVLMT
	{
		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		Rigidbody KZZPYUWZQUT
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		bool XYTDIQMSCSO
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
		void KWOWYEDSTYQ(object a);

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void FZIXPIBGRHB(object a);

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void PRRICTXEYNE();
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public interface BXBITBABXKA : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000051")]
		URFBIYRPPUA UPWGPIMLPQV
		{
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		KHHLPOITIKH LBXQSVZEMZW
		{
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		Vector3 AYHEGTBGIHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(Slot = "5")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		Vector3 LQPZBJRYMGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(Slot = "7")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		Vector3 FSSWKICRZXY
		{
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(Slot = "9")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		Vector3 OTSTNQZHDKL
		{
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(Slot = "11")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		float KZQWAJUTWVG
		{
			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(Slot = "13")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		bool WHUXSGFFTHE
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
		void RKOSNROAMFC(object a);

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(Slot = "17")]
		void VZVFBDLQSMS(RbexRotationType a, Vector3 b, float c = 1f / 0f);

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(Slot = "18")]
		void LOVHGHSVAVZ(RbexImpulseType a, Vector3 b, float c, float d = 8f, float e = 1f);

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(Slot = "19")]
		void PMIAGTGSUMJ(RbexRotationType a, Vector3 b, float c = 7f, float d = 1f);

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(Slot = "20")]
		void MQMHPCFOIUZ();

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(Slot = "21")]
		void NWOCEJPIFTQ();

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(Slot = "22")]
		void EVUEGXNXVEL();

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(Slot = "23")]
		void HYTPCBNMYJV();

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(Slot = "24")]
		void TVVGGWJARMG(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(Slot = "25")]
		Vector3 PZKZBGJXENC(Vector3 a);

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(Slot = "26")]
		void WRFALFEZLXR(object a);

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(Slot = "27")]
		void KXWYNAOAZNN(Vector3 a);

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(Slot = "28")]
		void GJIHNAWIUOO(Vector3 a, Vector3 b);

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(Slot = "29")]
		void NMQVSFHNGSP(Vector3 a, Vector3 b);

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(Slot = "30")]
		Vector3 SVSHVTIPYVQ(Vector3 a);

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(Slot = "31")]
		Vector3 KJLJOJSXVLC(Vector3 a);
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[ServiceLifetime(Lifetime.Application)]
	public interface UPTLOSEBHVK
	{
		[Cpp2IlInjected.Token(Token = "0x17000059")]
		bool DAIXLKJXJFJ
		{
			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void LVVQGEDKJWZ(string a);

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void YFJWOJLEHSI(RigidbodyEx a, Action b);

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		QVTUMJXBDFS RQNIXSMHGWT(int a);

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void HPTADOXIOKB(Vector3 a, float b, Color c);
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[ServiceLifetime(Lifetime.Application)]
	public interface ZFHSIHJPIZV
	{
		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		UPTLOSEBHVK PXMXJJKOWOR
		{
			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		ACJUUDGBBPJ VJIPUDGVYDR
		{
			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(Slot = "2")]
		KCFXUMCPMEW TZIRVECOOAV(RigidbodyEx a);
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class ARLKEPXCFYV : KCFXUMCPMEW, IDisposable, FSLQNJSTNCJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		internal readonly ZFHSIHJPIZV XUASIQOBWVI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		internal WCYQGCLDDOC YPAOUVLYFVI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		internal BIYDIZDMADJ SWVIRLLJXCT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		internal JRFWRDYSFSZ FIRVBREUWRL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		internal BXBITBABXKA QIPXIFWGIMU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		internal EFSYUOMQKCN GSKAEKQTLON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		internal DMDWVMLYSNP ZVKJKNLQAIV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		internal EFDEPUUANJQ ZGWRVPRZCLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		internal RDTKIPQQRVB BBBKYOSTYOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		internal LPGZOIBPVVU CRBRBGKZOEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		internal GCAKZFBQRQB VSLRUOGJKPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		internal KSZTPFCZMTC MRJBRUVERMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		internal UYDITCYYVQG VNETEMPXNXE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		internal AFEYQHWEQMJ HAGKPCHCPBX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		internal MQEDLLPVLMT PANSLUOCPOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		internal OQZILHVPXOY SQWJHLRNZOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		internal IDisposable CFLFYOABNMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private bool ORHOSGLZXCP;

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public ObjectLocalId ONXJZYPRQIV
		{
			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0xAAEAE0", Offset = "0xAAD2E0", VA = "0x180AAEAE0", Slot = "22")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public CSFUYHSFTRK KABWPROKRTF
		{
			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0xB48810", Offset = "0xB47010", VA = "0x180B48810", Slot = "24")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0xC081D0", Offset = "0xC069D0", VA = "0x180C081D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public GameObject RBWUDBYGUBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0xAAC190", Offset = "0xAAA990", VA = "0x180AAC190", Slot = "25")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0xAAC450", Offset = "0xAAAC50", VA = "0x180AAC450")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public Transform DXRDVXAOKAF
		{
			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0xC601C0", Offset = "0xC5E9C0", VA = "0x180C601C0", Slot = "26")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0xD61240", Offset = "0xD5FA40", VA = "0x180D61240")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public Rigidbody KZZPYUWZQUT
		{
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x8AADB50", Offset = "0x8AAC350", VA = "0x188AADB50", Slot = "23")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public KCFXUMCPMEW LUZXDGFNRIX
		{
			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x8AAF040", Offset = "0x8AAD840", VA = "0x188AAF040", Slot = "27")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x8AB0880", Offset = "0x8AAF080", VA = "0x188AB0880", Slot = "28")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public int ZYWTLNHSZCK
		{
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x8AB1590", Offset = "0x8AAFD90", VA = "0x188AB1590", Slot = "31")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public KCFXUMCPMEW PUSUXZYIEUP
		{
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x8AB00F0", Offset = "0x8AAE8F0", VA = "0x188AB00F0", Slot = "29")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public bool TCQRIIPANGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x8AB0140", Offset = "0x8AAE940", VA = "0x188AB0140", Slot = "32")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public bool NTJLJSEQBCZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x8AB1A50", Offset = "0x8AB0250", VA = "0x188AB1A50", Slot = "33")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public bool YCTRVLEUCOR
		{
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x8AB1B90", Offset = "0x8AB0390", VA = "0x188AB1B90", Slot = "34")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public URFBIYRPPUA UPWGPIMLPQV
		{
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x8AB28F0", Offset = "0x8AB10F0", VA = "0x188AB28F0", Slot = "35")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x8AB1D80", Offset = "0x8AB0580", VA = "0x188AB1D80", Slot = "36")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public KHHLPOITIKH LBXQSVZEMZW
		{
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x8AB1720", Offset = "0x8AAFF20", VA = "0x188AB1720", Slot = "37")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x8AB1BE0", Offset = "0x8AB03E0", VA = "0x188AB1BE0", Slot = "38")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public float KZQWAJUTWVG
		{
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x8AAE050", Offset = "0x8AAC850", VA = "0x188AAE050", Slot = "39")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x8AAFBF0", Offset = "0x8AAE3F0", VA = "0x188AAFBF0", Slot = "40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public Vector3 LQPZBJRYMGF
		{
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x8AB0320", Offset = "0x8AAEB20", VA = "0x188AB0320", Slot = "41")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x8AAF600", Offset = "0x8AADE00", VA = "0x188AAF600", Slot = "42")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public Vector3 OTSTNQZHDKL
		{
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x8AAFC50", Offset = "0x8AAE450", VA = "0x188AAFC50", Slot = "43")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x8AB2640", Offset = "0x8AB0E40", VA = "0x188AB2640", Slot = "44")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public Vector3 AYHEGTBGIHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x8AAF520", Offset = "0x8AADD20", VA = "0x188AAF520", Slot = "45")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x8AAE4B0", Offset = "0x8AACCB0", VA = "0x188AAE4B0", Slot = "46")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public Vector3 FSSWKICRZXY
		{
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x8AAE850", Offset = "0x8AAD050", VA = "0x188AAE850", Slot = "47")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x8AAF840", Offset = "0x8AAE040", VA = "0x188AAF840", Slot = "48")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public bool VZBGJJIMZAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x8AADED0", Offset = "0x8AAC6D0", VA = "0x188AADED0", Slot = "49")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public bool TJRTPRQNFBR
		{
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x8AADF20", Offset = "0x8AAC720", VA = "0x188AADF20", Slot = "50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public bool HYOAWBJMQJI
		{
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x8AAEF60", Offset = "0x8AAD760", VA = "0x188AAEF60", Slot = "51")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public bool WHUXSGFFTHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x8AAEE10", Offset = "0x8AAD610", VA = "0x188AAEE10", Slot = "52")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public Vector3 HLLOTYUYZSU
		{
			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x8AB0F00", Offset = "0x8AAF700", VA = "0x188AB0F00", Slot = "53")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public Vector3 AMJTMNIIVKQ
		{
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x8AACFE0", Offset = "0x8AAB7E0", VA = "0x188AACFE0", Slot = "54")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public Vector3 PZLHCVPMVLQ
		{
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x8AAFE50", Offset = "0x8AAE650", VA = "0x188AAFE50", Slot = "55")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x8AB0CE0", Offset = "0x8AAF4E0", VA = "0x188AB0CE0", Slot = "56")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public Vector3 KTNQBTXQNEZ
		{
			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x8AAF9D0", Offset = "0x8AAE1D0", VA = "0x188AAF9D0", Slot = "57")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public float NAAXVPFYAUP
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x8AAE3C0", Offset = "0x8AACBC0", VA = "0x188AAE3C0", Slot = "58")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public float XLIFLXKNOJS
		{
			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x8AB0400", Offset = "0x8AAEC00", VA = "0x188AB0400", Slot = "59")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x8AB1660", Offset = "0x8AAFE60", VA = "0x188AB1660", Slot = "60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public Vector3 VMDUPMYJMRA
		{
			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x8AAE770", Offset = "0x8AACF70", VA = "0x188AAE770", Slot = "61")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public Quaternion RCANEXIIULS
		{
			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x8AAED40", Offset = "0x8AAD540", VA = "0x188AAED40", Slot = "62")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public float YOGAWRHUNFD
		{
			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x8AAE460", Offset = "0x8AACC60", VA = "0x188AAE460", Slot = "64")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x8AACC20", Offset = "0x8AAB420", VA = "0x188AACC20", Slot = "65")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public float ATZZTYKAKMF
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x8AB1B40", Offset = "0x8AB0340", VA = "0x188AB1B40", Slot = "66")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x8AB1C40", Offset = "0x8AB0440", VA = "0x188AB1C40", Slot = "67")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public bool ZDRJBUTWAYQ
		{
			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x8AB07D0", Offset = "0x8AAEFD0", VA = "0x188AB07D0", Slot = "68")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x8AAD350", Offset = "0x8AABB50", VA = "0x188AAD350", Slot = "69")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public TransformTrackRate GFITEATAJJS
		{
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x8AAECF0", Offset = "0x8AAD4F0", VA = "0x188AAECF0", Slot = "70")]
			get
			{
				return default(TransformTrackRate);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x8AB23E0", Offset = "0x8AB0BE0", VA = "0x188AB23E0", Slot = "71")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public bool VGTBCFGYYRO
		{
			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x8AB0450", Offset = "0x8AAEC50", VA = "0x188AB0450", Slot = "72")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public Transform AXBWBIRWQWK
		{
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0xC601C0", Offset = "0xC5E9C0", VA = "0x180C601C0", Slot = "73")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public Vector3 CVZIDAFCKYO
		{
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x8AACE70", Offset = "0x8AAB670", VA = "0x188AACE70", Slot = "74")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x8AAE170", Offset = "0x8AAC970", VA = "0x188AAE170", Slot = "75")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public float QFKHHNSSPTK
		{
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x8AB23D0", Offset = "0x8AB0BD0", VA = "0x188AB23D0", Slot = "76")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x8AAC7E0", Offset = "0x8AAAFE0", VA = "0x188AAC7E0", Slot = "77")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public float HZERHYXVXFZ
		{
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x8AB1770", Offset = "0x8AAFF70", VA = "0x188AB1770", Slot = "78")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x8AADD80", Offset = "0x8AAC580", VA = "0x188AADD80", Slot = "79")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public Quaternion ZXBBMPBMRTB
		{
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x8AAEC50", Offset = "0x8AAD450", VA = "0x188AAEC50", Slot = "80")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x8AB0E20", Offset = "0x8AAF620", VA = "0x188AB0E20", Slot = "81")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public Vector3 ZKKEMCLBMNL
		{
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x8AAD4C0", Offset = "0x8AABCC0", VA = "0x188AAD4C0", Slot = "82")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x8AAFE10", Offset = "0x8AAE610", VA = "0x188AAFE10", Slot = "83")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public Quaternion XAYRGDAOOUY
		{
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x8AB0FD0", Offset = "0x8AAF7D0", VA = "0x188AB0FD0", Slot = "84")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x8AAD500", Offset = "0x8AABD00", VA = "0x188AAD500", Slot = "85")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public RigidbodyConstraints ABXTYPHYPLX
		{
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x8AB1A00", Offset = "0x8AB0200", VA = "0x188AB1A00", Slot = "86")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x8AB2890", Offset = "0x8AB1090", VA = "0x188AB2890", Slot = "87")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public bool XNSYEZHAWPM
		{
			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x8AB0780", Offset = "0x8AAEF80", VA = "0x188AB0780", Slot = "88")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x8AB1600", Offset = "0x8AAFE00", VA = "0x188AB1600", Slot = "89")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public CollisionDetectionMode ZKUPIUCJZXV
		{
			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x8AB2840", Offset = "0x8AB1040", VA = "0x188AB2840", Slot = "90")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x8AB0DC0", Offset = "0x8AAF5C0", VA = "0x188AB0DC0", Slot = "91")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public bool ZOKSRSIJABM
		{
			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x8AACD30", Offset = "0x8AAB530", VA = "0x188AACD30", Slot = "141")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public bool EKFYOKZYXUV
		{
			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0x8AAD1D0", Offset = "0x8AAB9D0", VA = "0x188AAD1D0", Slot = "92")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000017")]
		public event RbexAction WGZXGOMOCVN
		{
			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x8AB0C80", Offset = "0x8AAF480", VA = "0x188AB0C80", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x8AB22A0", Offset = "0x8AB0AA0", VA = "0x188AB22A0", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000018")]
		public event RbexAction JULWETWZKIR
		{
			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x8AB2E30", Offset = "0x8AB1630", VA = "0x188AB2E30", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x8AB16C0", Offset = "0x8AAFEC0", VA = "0x188AB16C0", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000019")]
		public event RbexParentChangeAction ZUGRGVVLUMJ
		{
			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x8AAE310", Offset = "0x8AACB10", VA = "0x188AAE310", Slot = "18")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x8AAD170", Offset = "0x8AAB970", VA = "0x188AAD170", Slot = "19")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001A")]
		public event RbexAction EVQNVPIJSQC
		{
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x8AAF780", Offset = "0x8AADF80", VA = "0x188AAF780", Slot = "8")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x8AACF80", Offset = "0x8AAB780", VA = "0x188AACF80", Slot = "9")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001B")]
		public event RbexAction ZITAUSZTNIP
		{
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x8AAF1D0", Offset = "0x8AAD9D0", VA = "0x188AAF1D0", Slot = "14")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x8AAF970", Offset = "0x8AAE170", VA = "0x188AAF970", Slot = "15")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001C")]
		public event RbexAction ONHGMNQQKRY
		{
			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x8AAF7E0", Offset = "0x8AADFE0", VA = "0x188AAF7E0", Slot = "16")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x8AB0C20", Offset = "0x8AAF420", VA = "0x188AB0C20", Slot = "17")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001D")]
		public event Action<UpdateLOD, UpdateLOD> HAFSXKFNVMF
		{
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x8AB2990", Offset = "0x8AB1190", VA = "0x188AB2990", Slot = "20")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x8AB1AA0", Offset = "0x8AB02A0", VA = "0x188AB1AA0", Slot = "21")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001E")]
		public event RbexAction RXBREEHNZTC
		{
			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x8AADCA0", Offset = "0x8AAC4A0", VA = "0x188AADCA0", Slot = "12")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x8AAD6E0", Offset = "0x8AABEE0", VA = "0x188AAD6E0", Slot = "13")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001F")]
		public event RbexAction VSFDSEPITSF
		{
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x8AB2440", Offset = "0x8AB0C40", VA = "0x188AB2440", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x8AACC80", Offset = "0x8AAB480", VA = "0x188AACC80", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x8AB2E90", Offset = "0x8AB1690", VA = "0x188AB2E90")]
		public ARLKEPXCFYV(GameObject a, RigidbodyEx b, ZFHSIHJPIZV c, [In] RigidbodyExData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x8AAD740", Offset = "0x8AABF40", VA = "0x188AAD740", Slot = "139")]
		protected virtual void DOJLXOINBPN(ZFHSIHJPIZV a, RigidbodyExData b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x8AADBA0", Offset = "0x8AAC3A0", VA = "0x188AADBA0", Slot = "140")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x8AAC870", Offset = "0x8AAB070", VA = "0x188AAC870", Slot = "93")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x8AB0060", Offset = "0x8AAE860", VA = "0x188AB0060", Slot = "94")]
		public void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x8AAFFB0", Offset = "0x8AAE7B0", VA = "0x188AAFFB0", Slot = "95")]
		public void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x8AAFF90", Offset = "0x8AAE790", VA = "0x188AAFF90", Slot = "96")]
		public void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x8AB1780", Offset = "0x8AAFF80", VA = "0x188AB1780")]
		private void TSDLVYPWTHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x8AB1FE0", Offset = "0x8AB07E0", VA = "0x188AB1FE0")]
		private void VZHAOHAIBOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x8AAFF30", Offset = "0x8AAE730", VA = "0x188AAFF30")]
		private void OXEUXRTHKRJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x8AADD00", Offset = "0x8AAC500", VA = "0x188AADD00", Slot = "30")]
		public KCFXUMCPMEW EUAUGMRHMOZ(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x8AB1180", Offset = "0x8AAF980", VA = "0x188AB1180", Slot = "98")]
		public void SetParent(KCFXUMCPMEW value, bool isPhysicallyDetachedOnly = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x8AB27E0", Offset = "0x8AB0FE0", VA = "0x188AB27E0", Slot = "99")]
		public void YULRDXEPUTU(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x8AB0BC0", Offset = "0x8AAF3C0", VA = "0x188AB0BC0", Slot = "100")]
		public void REEVRZXFOSB(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x8AAEE60", Offset = "0x8AAD660", VA = "0x188AAEE60", Slot = "101")]
		public Vector3 KJLJOJSXVLC(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x8AB1080", Offset = "0x8AAF880", VA = "0x188AB1080", Slot = "102")]
		public Vector3 SVSHVTIPYVQ(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x8AAE410", Offset = "0x8AACC10", VA = "0x188AAE410", Slot = "103")]
		public void HYTPCBNMYJV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x8AAFBA0", Offset = "0x8AAE3A0", VA = "0x188AAFBA0", Slot = "104")]
		public void NWOCEJPIFTQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x8AAF730", Offset = "0x8AADF30", VA = "0x188AAF730", Slot = "105")]
		public void MQMHPCFOIUZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x8AAFAB0", Offset = "0x8AAE2B0", VA = "0x188AAFAB0", Slot = "106")]
		public void NMQVSFHNGSP(Vector3 a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x8AAE220", Offset = "0x8AACA20", VA = "0x188AAE220", Slot = "107")]
		public void GJIHNAWIUOO(Vector3 a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x8AAF0F0", Offset = "0x8AAD8F0", VA = "0x188AAF0F0", Slot = "108")]
		public void KXWYNAOAZNN(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x8AAF330", Offset = "0x8AADB30", VA = "0x188AAF330", Slot = "109")]
		public void LOVHGHSVAVZ(RbexImpulseType a, Vector3 b, float c, float d = 8f, float e = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x8AB2060", Offset = "0x8AB0860", VA = "0x188AB2060", Slot = "110")]
		public void VZVFBDLQSMS(RbexRotationType a, Vector3 b, float c = 1f / 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x8AB01A0", Offset = "0x8AAE9A0", VA = "0x188AB01A0", Slot = "111")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void PMIAGTGSUMJ(RbexRotationType a, Vector3 b, float c = 7f, float d = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x8AB0570", Offset = "0x8AAED70", VA = "0x188AB0570", Slot = "112")]
		public Vector3 PZKZBGJXENC(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x8AAF230", Offset = "0x8AADA30", VA = "0x188AAF230", Slot = "113")]
		public Vector3 LJGHFDIKKNW(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x8AADE80", Offset = "0x8AAC680", VA = "0x188AADE80", Slot = "114")]
		public void EVUEGXNXVEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x8AB1010", Offset = "0x8AAF810", VA = "0x188AB1010", Slot = "115")]
		public void SVDPBVZFXED(KCFXUMCPMEW a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x8AB2720", Offset = "0x8AB0F20", VA = "0x188AB2720", Slot = "116")]
		public void YIYYDOMWUSM(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x8AB08E0", Offset = "0x8AAF0E0", VA = "0x188AB08E0", Slot = "63")]
		public void QSBXUDHMGOA((Quaternion rot, Vector3 moments) tensor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x8AAE370", Offset = "0x8AACB70", VA = "0x188AAE370", Slot = "117")]
		public void HLPLLOBFRRC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x8AAF920", Offset = "0x8AAE120", VA = "0x188AAF920", Slot = "118")]
		public void NFPVABQYXXJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x8AB25F0", Offset = "0x8AB0DF0", VA = "0x188AB25F0", Slot = "119")]
		public void XSLTZWPDBDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x8AAF6E0", Offset = "0x8AADEE0", VA = "0x188AAF6E0", Slot = "120")]
		public bool MQGIXWISZSG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x8AB11F0", Offset = "0x8AAF9F0", VA = "0x188AB11F0", Slot = "97")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x8AB02B0", Offset = "0x8AAEAB0", VA = "0x188AB02B0", Slot = "121")]
		public void PNJTSCXQOYG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x8AB0820", Offset = "0x8AAF020", VA = "0x188AB0820", Slot = "122")]
		public void QOYUWQXNMRR(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x8AB2780", Offset = "0x8AB0F80", VA = "0x188AB2780", Slot = "123")]
		public void YNSFSUVTQHS(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x8AAE0A0", Offset = "0x8AAC8A0", VA = "0x188AAE0A0", Slot = "124")]
		public void FVQDXJJBWWG(object a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x8AB09C0", Offset = "0x8AAF1C0", VA = "0x188AB09C0", Slot = "125")]
		public void QVNOACGURNM(Vector3 a, Quaternion b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x8AAF3F0", Offset = "0x8AADBF0", VA = "0x188AAF3F0", Slot = "126")]
		public void LTEUORCSCXE(Vector3 a, Quaternion b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x8AB2940", Offset = "0x8AB1140", VA = "0x188AB2940", Slot = "127")]
		public bool ZJIUJWBBFOR(float a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x8AACF20", Offset = "0x8AAB720", VA = "0x188AACF20", Slot = "128")]
		public void CDNDOBBDUCW(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x8AB2160", Offset = "0x8AB0960", VA = "0x188AB2160", Slot = "129")]
		public void WLTSRUYLWQD(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x8AAF090", Offset = "0x8AAD890", VA = "0x188AAF090", Slot = "130")]
		public void KWOWYEDSTYQ(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x8AAE110", Offset = "0x8AAC910", VA = "0x188AAE110", Slot = "131")]
		public void FZIXPIBGRHB(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x8AB21C0", Offset = "0x8AB09C0", VA = "0x188AB21C0", Slot = "132")]
		public void WPXTKJOXWGZ(Vector3 a, ForceMode b = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x8AB0670", Offset = "0x8AAEE70", VA = "0x188AB0670", Slot = "133")]
		public void QBXQEJWLRXJ(Vector3 a, Vector3 b, ForceMode c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x8AAFD30", Offset = "0x8AAE530", VA = "0x188AAFD30", Slot = "134")]
		public void OCNOMMRBKGY(Vector3 a, ForceMode b = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x8AB1CA0", Offset = "0x8AB04A0", VA = "0x188AB1CA0", Slot = "135")]
		public void UZAAFJTBTKU(Vector3 a, ForceMode b = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x8AB24F0", Offset = "0x8AB0CF0", VA = "0x188AB24F0", Slot = "136")]
		public bool XQUTBHAWBQB(Vector3 a, [Out] RaycastHit b, float c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x8AB0010", Offset = "0x8AAE810", VA = "0x188AB0010", Slot = "137")]
		public void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x8AB1B00", Offset = "0x8AB0300", VA = "0x188AB1B00", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x8AB04A0", Offset = "0x8AAECA0", VA = "0x188AB04A0")]
		private void PTSCIHTHNPZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x8AAD3B0", Offset = "0x8AABBB0", VA = "0x188AAD3B0")]
		private void DCWSDDDPSNX(KCFXUMCPMEW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x8AAE590", Offset = "0x8AACD90", VA = "0x188AAE590")]
		private void ILPWEAJGTPA(KCFXUMCPMEW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x8AAD0C0", Offset = "0x8AAB8C0", VA = "0x188AAD0C0")]
		private void CKYBURCHUYN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x8AAC9B0", Offset = "0x8AAB1B0", VA = "0x188AAC9B0")]
		private void BBRHWWQMVHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x8AAD530", Offset = "0x8AABD30", VA = "0x188AAD530")]
		private void DMLFUWIDIKK(KCFXUMCPMEW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x8AB2300", Offset = "0x8AB0B00", VA = "0x188AB2300")]
		private void XINNDDBIWJD(KCFXUMCPMEW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x8AADF80", Offset = "0x8AAC780", VA = "0x188AADF80")]
		private void FFYMVTYPVQJ(KCFXUMCPMEW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x8AACAD0", Offset = "0x8AAB2D0", VA = "0x188AACAD0")]
		private void BJULLMYTWPK(CSFUYHSFTRK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x8AB29F0", Offset = "0x8AB11F0", VA = "0x188AB29F0", Slot = "142")]
		protected virtual void ZUGWEFNPEJT(CSFUYHSFTRK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x8AAE930", Offset = "0x8AAD130", VA = "0x188AAE930")]
		protected void IOJHNVKQACJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x8AB1240", Offset = "0x8AAFA40", VA = "0x188AB1240")]
		protected void TAMZSOYNWHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x8AADA30", Offset = "0x8AAC230", VA = "0x188AADA30")]
		private void DTLQVODYOVL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x8AB1E70", Offset = "0x8AB0670", VA = "0x188AB1E70")]
		private void VPYDZYLNCXK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	internal static class PWDGTLKEAQP
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x8ABF950", Offset = "0x8ABE150", VA = "0x188ABF950")]
		public static KCFXUMCPMEW PNVAAMTHMOI(this KCFXUMCPMEW a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x8ABFA10", Offset = "0x8ABE210", VA = "0x188ABFA10")]
		public static bool YDSUIVUUJXR(this KCFXUMCPMEW a, KCFXUMCPMEW b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x8ABF8B0", Offset = "0x8ABE0B0", VA = "0x188ABF8B0")]
		public static bool CUINQBQGPUJ(this KCFXUMCPMEW a, KCFXUMCPMEW b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x8ABF7F0", Offset = "0x8ABDFF0", VA = "0x188ABF7F0")]
		public static CSFUYHSFTRK ARLJXGXTWUV(this KCFXUMCPMEW a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x8ABF840", Offset = "0x8ABE040", VA = "0x188ABF840")]
		public static ARLKEPXCFYV Base(this KCFXUMCPMEW impl)
		{
			return null;
		}
	}
}
namespace RecRoom.Rbex.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class GTGPQPFRHNS : ACJUUDGBBPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x8ABCE20", Offset = "0x8ABB620", VA = "0x188ABCE20", Slot = "19")]
		public KCFXUMCPMEW TZIRVECOOAV(RigidbodyEx a, RigidbodyExData b, ZFHSIHJPIZV c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAE0", Offset = "0xAAD2E0", VA = "0x180AAEAE0", Slot = "4")]
		public WCYQGCLDDOC VNWWFXRSVPE(KCFXUMCPMEW a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAE0", Offset = "0xAAD2E0", VA = "0x180AAEAE0", Slot = "5")]
		public BXBITBABXKA DRMIVOACVPC(KCFXUMCPMEW a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAE0", Offset = "0xAAD2E0", VA = "0x180AAEAE0", Slot = "6")]
		public EFSYUOMQKCN FADVOJOXQAV(KCFXUMCPMEW a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAE0", Offset = "0xAAD2E0", VA = "0x180AAEAE0", Slot = "7")]
		public EFDEPUUANJQ RZLNFDGSPOC(KCFXUMCPMEW a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAE0", Offset = "0xAAD2E0", VA = "0x180AAEAE0", Slot = "8")]
		public LPGZOIBPVVU HFSLBVFAYUG(KCFXUMCPMEW a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAE0", Offset = "0xAAD2E0", VA = "0x180AAEAE0", Slot = "9")]
		public GCAKZFBQRQB IHTDEQCDHRD(KCFXUMCPMEW a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAE0", Offset = "0xAAD2E0", VA = "0x180AAEAE0", Slot = "10")]
		public KSZTPFCZMTC OFCBMDWTUZK(KCFXUMCPMEW a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAE0", Offset = "0xAAD2E0", VA = "0x180AAEAE0", Slot = "11")]
		public UYDITCYYVQG OSWUDTFDAXI(KCFXUMCPMEW a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAE0", Offset = "0xAAD2E0", VA = "0x180AAEAE0", Slot = "12")]
		public OQZILHVPXOY AFFYUDEPBPC(KCFXUMCPMEW a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAE0", Offset = "0xAAD2E0", VA = "0x180AAEAE0", Slot = "13")]
		public RDTKIPQQRVB CQMMKARWMJJ(KCFXUMCPMEW a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAE0", Offset = "0xAAD2E0", VA = "0x180AAEAE0")]
		public MQEDLLPVLMT VZGSASKAVSL(KCFXUMCPMEW a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAE0", Offset = "0xAAD2E0", VA = "0x180AAEAE0")]
		public JRFWRDYSFSZ EIAMZAIJOPH(KCFXUMCPMEW a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAE0", Offset = "0xAAD2E0", VA = "0x180AAEAE0")]
		public BIYDIZDMADJ MSAUQAPZLAH(KCFXUMCPMEW a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAE0", Offset = "0xAAD2E0", VA = "0x180AAEAE0")]
		public DMDWVMLYSNP WWEVCMWVECZ(KCFXUMCPMEW a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAE0", Offset = "0xAAD2E0", VA = "0x180AAEAE0")]
		public AFEYQHWEQMJ ORYMFEEUFMR(KCFXUMCPMEW a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		public GTGPQPFRHNS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAE0", Offset = "0xAAD2E0", VA = "0x180AAEAE0", Slot = "14")]
		private MQEDLLPVLMT RLCHRPMMQBV(KCFXUMCPMEW a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAE0", Offset = "0xAAD2E0", VA = "0x180AAEAE0", Slot = "15")]
		private JRFWRDYSFSZ RHCZQDKMUSN(KCFXUMCPMEW a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAE0", Offset = "0xAAD2E0", VA = "0x180AAEAE0", Slot = "16")]
		private BIYDIZDMADJ YMATDILTUWT(KCFXUMCPMEW a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAE0", Offset = "0xAAD2E0", VA = "0x180AAEAE0", Slot = "17")]
		private DMDWVMLYSNP GAVBMOMJJXX(KCFXUMCPMEW a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAE0", Offset = "0xAAD2E0", VA = "0x180AAEAE0", Slot = "18")]
		private AFEYQHWEQMJ WAUWHZLYUCN(KCFXUMCPMEW a, [In] RigidbodyExData data)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[RegisterService(typeof(ACJUUDGBBPJ), new string[] { })]
	public class GBLHIHNIJNH : ACJUUDGBBPJ, NDLMBBFOQSV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private readonly ACJUUDGBBPJ FZEUPPXOIQM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private readonly ACJUUDGBBPJ BZOLIQSAUYN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private SIUPUANAAPB YIICPDFLTQC;

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		private ACJUUDGBBPJ VJIPUDGVYDR
		{
			[Cpp2IlInjected.Token(Token = "0x600021F")]
			[Cpp2IlInjected.Address(RVA = "0x8ABBFA0", Offset = "0x8ABA7A0", VA = "0x188ABBFA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x8ABB970", Offset = "0x8ABA170", VA = "0x188ABB970", Slot = "20")]
		public void InitReferences(MZUBMRWQSAC services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x8ABBF00", Offset = "0x8ABA700", VA = "0x188ABBF00", Slot = "4")]
		public WCYQGCLDDOC VNWWFXRSVPE(KCFXUMCPMEW a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x8ABB590", Offset = "0x8AB9D90", VA = "0x188ABB590", Slot = "5")]
		public BXBITBABXKA DRMIVOACVPC(KCFXUMCPMEW a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x8ABB6E0", Offset = "0x8AB9EE0", VA = "0x188ABB6E0", Slot = "6")]
		public EFSYUOMQKCN FADVOJOXQAV(KCFXUMCPMEW a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x8ABBD10", Offset = "0x8ABA510", VA = "0x188ABBD10", Slot = "7")]
		public EFDEPUUANJQ RZLNFDGSPOC(KCFXUMCPMEW a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x8ABB830", Offset = "0x8ABA030", VA = "0x188ABB830", Slot = "8")]
		public LPGZOIBPVVU HFSLBVFAYUG(KCFXUMCPMEW a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x8ABB8D0", Offset = "0x8ABA0D0", VA = "0x188ABB8D0", Slot = "9")]
		public GCAKZFBQRQB IHTDEQCDHRD(KCFXUMCPMEW a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x8ABBA70", Offset = "0x8ABA270", VA = "0x188ABBA70", Slot = "10")]
		public KSZTPFCZMTC OFCBMDWTUZK(KCFXUMCPMEW a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x8ABBBC0", Offset = "0x8ABA3C0", VA = "0x188ABBBC0", Slot = "11")]
		public UYDITCYYVQG OSWUDTFDAXI(KCFXUMCPMEW a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x8ABB450", Offset = "0x8AB9C50", VA = "0x188ABB450", Slot = "12")]
		public OQZILHVPXOY AFFYUDEPBPC(KCFXUMCPMEW a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x8ABB4F0", Offset = "0x8AB9CF0", VA = "0x188ABB4F0", Slot = "13")]
		public RDTKIPQQRVB CQMMKARWMJJ(KCFXUMCPMEW a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x8ABBC60", Offset = "0x8ABA460", VA = "0x188ABBC60")]
		public MQEDLLPVLMT VZGSASKAVSL(KCFXUMCPMEW a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x8ABB630", Offset = "0x8AB9E30", VA = "0x188ABB630")]
		public JRFWRDYSFSZ EIAMZAIJOPH(KCFXUMCPMEW a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x8ABB9C0", Offset = "0x8ABA1C0", VA = "0x188ABB9C0")]
		public BIYDIZDMADJ MSAUQAPZLAH(KCFXUMCPMEW a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x8ABB780", Offset = "0x8AB9F80", VA = "0x188ABB780")]
		public DMDWVMLYSNP WWEVCMWVECZ(KCFXUMCPMEW a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x8ABBB10", Offset = "0x8ABA310", VA = "0x188ABBB10")]
		public AFEYQHWEQMJ ORYMFEEUFMR(KCFXUMCPMEW a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x8ABBDB0", Offset = "0x8ABA5B0", VA = "0x188ABBDB0", Slot = "19")]
		public KCFXUMCPMEW TZIRVECOOAV(RigidbodyEx a, RigidbodyExData b, ZFHSIHJPIZV c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x8ABC000", Offset = "0x8ABA800", VA = "0x188ABC000")]
		public GBLHIHNIJNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x8ABBC60", Offset = "0x8ABA460", VA = "0x188ABBC60", Slot = "14")]
		private MQEDLLPVLMT RLCHRPMMQBV(KCFXUMCPMEW a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x8ABB630", Offset = "0x8AB9E30", VA = "0x188ABB630", Slot = "15")]
		private JRFWRDYSFSZ RHCZQDKMUSN(KCFXUMCPMEW a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x8ABB9C0", Offset = "0x8ABA1C0", VA = "0x188ABB9C0", Slot = "16")]
		private BIYDIZDMADJ YMATDILTUWT(KCFXUMCPMEW a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x8ABB780", Offset = "0x8AB9F80", VA = "0x188ABB780", Slot = "17")]
		private DMDWVMLYSNP GAVBMOMJJXX(KCFXUMCPMEW a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x8ABBB10", Offset = "0x8ABA310", VA = "0x188ABBB10", Slot = "18")]
		private AFEYQHWEQMJ WAUWHZLYUCN(KCFXUMCPMEW a, [In] RigidbodyExData data)
		{
			return null;
		}
	}
}
namespace RecRoom.Rbex.Legacy
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public interface RHILHRQPTCT : WCYQGCLDDOC, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void FHTUHGKCEBC(KCFXUMCPMEW a);

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void YIVTPKWEMNF(KCFXUMCPMEW a);

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void VBGCYYKPHPI(KCFXUMCPMEW a);

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void REFIMFPACUH(KCFXUMCPMEW a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public interface MGMJSLGDMDG : EFSYUOMQKCN
	{
		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		WWHARXTEPTC<KCFXUMCPMEW> ECXDHCVDUJZ
		{
			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		KCFXUMCPMEW GJRQYTCUBST
		{
			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public interface LALNEHFDMJM : DMDWVMLYSNP
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		(float, Vector3) QLCUIKDFLDN(Rigidbody a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public interface CUDLGVCZIJC : JRFWRDYSFSZ, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		RRNetworkView HBDQETEECNS
		{
			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	internal sealed class MLGLCUTUIZH : OQZILHVPXOY
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private readonly ARLKEPXCFYV PWZFQDMMKMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private CollisionDetectionMode DCYYQRGQEUT;

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		private Rigidbody KZZPYUWZQUT
		{
			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0x8ABA5F0", Offset = "0x8AB8DF0", VA = "0x188ABA5F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		public CollisionDetectionMode ZKUPIUCJZXV
		{
			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0x8ABE600", Offset = "0x8ABCE00", VA = "0x188ABE600", Slot = "4")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0x8ABE3A0", Offset = "0x8ABCBA0", VA = "0x188ABE3A0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x8ABB350", Offset = "0x8AB9B50", VA = "0x188ABB350")]
		public MLGLCUTUIZH(KCFXUMCPMEW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE160", Offset = "0x8ABC960", VA = "0x188ABE160", Slot = "6")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE420", Offset = "0x8ABCC20", VA = "0x188ABE420", Slot = "9")]
		public void TVVGGWJARMG(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE270", Offset = "0x8ABCA70", VA = "0x188ABE270", Slot = "7")]
		public void ECEPGIHUYLL(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE410", Offset = "0x8ABCC10", VA = "0x188ABE410", Slot = "8")]
		public void TDGAKSTGFGE(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE4A0", Offset = "0x8ABCCA0", VA = "0x188ABE4A0", Slot = "10")]
		public bool XQUTBHAWBQB(Vector3 a, [Out] RaycastHit b, float c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE280", Offset = "0x8ABCA80", VA = "0x188ABE280")]
		private void MUBNWAQLSTJ(bool a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public sealed class JSMUDDDUPLY : GCAKZFBQRQB, IDisposable, QKLXQYHXXNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly ARLKEPXCFYV PWZFQDMMKMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private TransformTrackRate CQUTBKDMLVS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private QVTUMJXBDFS MLJYJNIZGCE;

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		public TransformTrackRate GFITEATAJJS
		{
			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0x8ABDC40", Offset = "0x8ABC440", VA = "0x188ABDC40", Slot = "6")]
			get
			{
				return default(TransformTrackRate);
			}
			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0x8ABDE50", Offset = "0x8ABC650", VA = "0x188ABDE50", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000092")]
		private Transform FXWVJBJWVJJ
		{
			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x8ABDD80", Offset = "0x8ABC580", VA = "0x188ABDD80", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000020")]
		public event Action<UpdateLOD, UpdateLOD> HAFSXKFNVMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0x8ABDF20", Offset = "0x8ABC720", VA = "0x188ABDF20", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0x8ABDDA0", Offset = "0x8ABC5A0", VA = "0x188ABDDA0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x8ABDFD0", Offset = "0x8ABC7D0", VA = "0x188ABDFD0")]
		public JSMUDDDUPLY(KCFXUMCPMEW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x8ABD980", Offset = "0x8ABC180", VA = "0x188ABD980", Slot = "8")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x8ABDBF0", Offset = "0x8ABC3F0", VA = "0x188ABDBF0", Slot = "9")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x111CEB0", Offset = "0x111B6B0", VA = "0x18111CEB0", Slot = "11")]
		private void EPNDBKBGKXG(UpdateLOD a, UpdateLOD b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "12")]
		private void FPRWEETOWQM(bool a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class GTGPQPFRHNS : ACJUUDGBBPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x8ABCFF0", Offset = "0x8ABB7F0", VA = "0x188ABCFF0", Slot = "4")]
		public WCYQGCLDDOC VNWWFXRSVPE(KCFXUMCPMEW a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x8ABC220", Offset = "0x8ABAA20", VA = "0x188ABC220", Slot = "5")]
		public BXBITBABXKA DRMIVOACVPC(KCFXUMCPMEW a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x8ABC4B0", Offset = "0x8ABACB0", VA = "0x188ABC4B0", Slot = "6")]
		public EFSYUOMQKCN FADVOJOXQAV(KCFXUMCPMEW a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x8ABCDB0", Offset = "0x8ABB5B0", VA = "0x188ABCDB0", Slot = "7")]
		public EFDEPUUANJQ RZLNFDGSPOC(KCFXUMCPMEW a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x8ABC750", Offset = "0x8ABAF50", VA = "0x188ABC750", Slot = "8")]
		public LPGZOIBPVVU HFSLBVFAYUG(KCFXUMCPMEW a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x8ABC810", Offset = "0x8ABB010", VA = "0x188ABC810", Slot = "9")]
		public GCAKZFBQRQB IHTDEQCDHRD(KCFXUMCPMEW a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x8ABC9F0", Offset = "0x8ABB1F0", VA = "0x188ABC9F0", Slot = "10")]
		public KSZTPFCZMTC OFCBMDWTUZK(KCFXUMCPMEW a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x8ABCBD0", Offset = "0x8ABB3D0", VA = "0x188ABCBD0", Slot = "11")]
		public UYDITCYYVQG OSWUDTFDAXI(KCFXUMCPMEW a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x8ABC0A0", Offset = "0x8ABA8A0", VA = "0x188ABC0A0", Slot = "12")]
		public OQZILHVPXOY AFFYUDEPBPC(KCFXUMCPMEW a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x8ABC160", Offset = "0x8ABA960", VA = "0x188ABC160", Slot = "13")]
		public RDTKIPQQRVB CQMMKARWMJJ(KCFXUMCPMEW a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x8ABCC90", Offset = "0x8ABB490", VA = "0x188ABCC90")]
		public MQEDLLPVLMT VZGSASKAVSL(KCFXUMCPMEW a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x8ABC330", Offset = "0x8ABAB30", VA = "0x188ABC330")]
		public JRFWRDYSFSZ EIAMZAIJOPH(KCFXUMCPMEW a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x8ABC8D0", Offset = "0x8ABB0D0", VA = "0x188ABC8D0")]
		public BIYDIZDMADJ MSAUQAPZLAH(KCFXUMCPMEW a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x8ABC5D0", Offset = "0x8ABADD0", VA = "0x188ABC5D0")]
		public DMDWVMLYSNP WWEVCMWVECZ(KCFXUMCPMEW a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x8ABCB00", Offset = "0x8ABB300", VA = "0x188ABCB00")]
		public AFEYQHWEQMJ ORYMFEEUFMR(KCFXUMCPMEW a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x8ABCEB0", Offset = "0x8ABB6B0", VA = "0x188ABCEB0", Slot = "19")]
		public KCFXUMCPMEW TZIRVECOOAV(RigidbodyEx a, RigidbodyExData b, ZFHSIHJPIZV c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		public GTGPQPFRHNS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x8ABCC90", Offset = "0x8ABB490", VA = "0x188ABCC90", Slot = "14")]
		private MQEDLLPVLMT RLCHRPMMQBV(KCFXUMCPMEW a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x8ABC330", Offset = "0x8ABAB30", VA = "0x188ABC330", Slot = "15")]
		private JRFWRDYSFSZ RHCZQDKMUSN(KCFXUMCPMEW a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x8ABC8D0", Offset = "0x8ABB0D0", VA = "0x188ABC8D0", Slot = "16")]
		private BIYDIZDMADJ YMATDILTUWT(KCFXUMCPMEW a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x8ABC5D0", Offset = "0x8ABADD0", VA = "0x188ABC5D0", Slot = "17")]
		private DMDWVMLYSNP GAVBMOMJJXX(KCFXUMCPMEW a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x8ABCB00", Offset = "0x8ABB300", VA = "0x188ABCB00", Slot = "18")]
		private AFEYQHWEQMJ WAUWHZLYUCN(KCFXUMCPMEW a, [In] RigidbodyExData data)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal sealed class FJMNXMPQMVL : UYDITCYYVQG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private readonly ARLKEPXCFYV PWZFQDMMKMG;

		[Cpp2IlInjected.Token(Token = "0x17000093")]
		private Rigidbody KZZPYUWZQUT
		{
			[Cpp2IlInjected.Token(Token = "0x6000268")]
			[Cpp2IlInjected.Address(RVA = "0x8ABA5F0", Offset = "0x8AB8DF0", VA = "0x188ABA5F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000094")]
		private bool VGTBCFGYYRO
		{
			[Cpp2IlInjected.Token(Token = "0x6000269")]
			[Cpp2IlInjected.Address(RVA = "0x8ABACC0", Offset = "0x8AB94C0", VA = "0x188ABACC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000095")]
		private bool TCQRIIPANGB
		{
			[Cpp2IlInjected.Token(Token = "0x600026A")]
			[Cpp2IlInjected.Address(RVA = "0x8ABA160", Offset = "0x8AB8960", VA = "0x188ABA160")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000096")]
		private KCFXUMCPMEW LUZXDGFNRIX
		{
			[Cpp2IlInjected.Token(Token = "0x600026B")]
			[Cpp2IlInjected.Address(RVA = "0x8ABA8A0", Offset = "0x8AB90A0", VA = "0x188ABA8A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x8ABB350", Offset = "0x8AB9B50", VA = "0x188ABB350")]
		public FJMNXMPQMVL(KCFXUMCPMEW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x8ABB1F0", Offset = "0x8AB99F0", VA = "0x188ABB1F0", Slot = "4")]
		public void WPXTKJOXWGZ(Vector3 a, ForceMode b = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x8ABA640", Offset = "0x8AB8E40", VA = "0x188ABA640")]
		private void HVLPVNHNTYU(Vector3 a, ForceMode b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x8ABAD10", Offset = "0x8AB9510", VA = "0x188ABAD10", Slot = "5")]
		public void QBXQEJWLRXJ(Vector3 a, Vector3 b, ForceMode c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x8ABAB60", Offset = "0x8AB9360", VA = "0x188ABAB60", Slot = "6")]
		public void OCNOMMRBKGY(Vector3 a, ForceMode b = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x8ABA900", Offset = "0x8AB9100", VA = "0x188ABA900")]
		private void NIJNIYEFRPN(Vector3 a, ForceMode b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x8ABAF90", Offset = "0x8AB9790", VA = "0x188ABAF90", Slot = "7")]
		public void UZAAFJTBTKU(Vector3 a, ForceMode b = ForceMode.Force)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	internal sealed class JLUMHMCQZCE : RDTKIPQQRVB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private readonly ARLKEPXCFYV PWZFQDMMKMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private bool YQVXYJJFOWU;

		[Cpp2IlInjected.Token(Token = "0x17000097")]
		public bool ZDRJBUTWAYQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000274")]
			[Cpp2IlInjected.Address(RVA = "0xC19AA0", Offset = "0xC182A0", VA = "0x180C19AA0", Slot = "4")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000275")]
			[Cpp2IlInjected.Address(RVA = "0x8ABD7D0", Offset = "0x8ABBFD0", VA = "0x188ABD7D0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x8ABB350", Offset = "0x8AB9B50", VA = "0x188ABB350")]
		public JLUMHMCQZCE(KCFXUMCPMEW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x8ABD950", Offset = "0x8ABC150", VA = "0x188ABD950", Slot = "6")]
		public void TVVGGWJARMG(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x8ABD8E0", Offset = "0x8ABC0E0", VA = "0x188ABD8E0", Slot = "7")]
		public void RXJVNBVWDRN(Rigidbody a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	internal sealed class RbexHierarchy : RHILHRQPTCT, WCYQGCLDDOC, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private readonly KCFXUMCPMEW PWZFQDMMKMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private readonly List<KCFXUMCPMEW> TKTODPKOUNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private KCFXUMCPMEW GCIIEAQCVVB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private KCFXUMCPMEW PKLBYNGIDZN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private Transform FOPKAMIXHZM;

		[Cpp2IlInjected.Token(Token = "0x17000098")]
		private Transform DXRDVXAOKAF
		{
			[Cpp2IlInjected.Token(Token = "0x600028A")]
			[Cpp2IlInjected.Address(RVA = "0x8AC23F0", Offset = "0x8AC0BF0", VA = "0x188AC23F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000099")]
		public KCFXUMCPMEW LUZXDGFNRIX
		{
			[Cpp2IlInjected.Token(Token = "0x600028D")]
			[Cpp2IlInjected.Address(RVA = "0xAB4120", Offset = "0xAB2920", VA = "0x180AB4120", Slot = "28")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600028E")]
			[Cpp2IlInjected.Address(RVA = "0x8AC16E0", Offset = "0x8ABFEE0", VA = "0x188AC16E0", Slot = "29")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009A")]
		public KCFXUMCPMEW PUSUXZYIEUP
		{
			[Cpp2IlInjected.Token(Token = "0x600028F")]
			[Cpp2IlInjected.Address(RVA = "0xAB4130", Offset = "0xAB2930", VA = "0x180AB4130", Slot = "27")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		public IReadOnlyList<KCFXUMCPMEW> ALCKLGXMEQH
		{
			[Cpp2IlInjected.Token(Token = "0x6000290")]
			[Cpp2IlInjected.Address(RVA = "0xAB3270", Offset = "0xAB1A70", VA = "0x180AB3270", Slot = "26")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000021")]
		public event RbexAction WGZXGOMOCVN
		{
			[Cpp2IlInjected.Token(Token = "0x6000278")]
			[Cpp2IlInjected.Address(RVA = "0x8AC1970", Offset = "0x8AC0170", VA = "0x188AC1970", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000279")]
			[Cpp2IlInjected.Address(RVA = "0x8AC24F0", Offset = "0x8AC0CF0", VA = "0x188AC24F0", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000022")]
		public event RbexAction JULWETWZKIR
		{
			[Cpp2IlInjected.Token(Token = "0x600027A")]
			[Cpp2IlInjected.Address(RVA = "0x8AC27F0", Offset = "0x8AC0FF0", VA = "0x188AC27F0", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600027B")]
			[Cpp2IlInjected.Address(RVA = "0x8AC1F80", Offset = "0x8AC0780", VA = "0x188AC1F80", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000023")]
		public event RbexParentChangeAction ZUGRGVVLUMJ
		{
			[Cpp2IlInjected.Token(Token = "0x600027C")]
			[Cpp2IlInjected.Address(RVA = "0x8AC11B0", Offset = "0x8ABF9B0", VA = "0x188AC11B0", Slot = "12")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600027D")]
			[Cpp2IlInjected.Address(RVA = "0x8AC0B70", Offset = "0x8ABF370", VA = "0x188AC0B70", Slot = "13")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000024")]
		public event Action ZCNDRSZSEAM
		{
			[Cpp2IlInjected.Token(Token = "0x600027E")]
			[Cpp2IlInjected.Address(RVA = "0x8AC2450", Offset = "0x8AC0C50", VA = "0x188AC2450", Slot = "14")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600027F")]
			[Cpp2IlInjected.Address(RVA = "0x8AC0D60", Offset = "0x8ABF560", VA = "0x188AC0D60", Slot = "15")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000025")]
		public event Action QIMJXSVSGDX
		{
			[Cpp2IlInjected.Token(Token = "0x6000280")]
			[Cpp2IlInjected.Address(RVA = "0x8AC0E00", Offset = "0x8ABF600", VA = "0x188AC0E00", Slot = "16")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000281")]
			[Cpp2IlInjected.Address(RVA = "0x8AC1640", Offset = "0x8ABFE40", VA = "0x188AC1640", Slot = "17")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000026")]
		public event Action<KCFXUMCPMEW> SXYUQSURFOI
		{
			[Cpp2IlInjected.Token(Token = "0x6000282")]
			[Cpp2IlInjected.Address(RVA = "0x8AC0AC0", Offset = "0x8ABF2C0", VA = "0x188AC0AC0", Slot = "18")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000283")]
			[Cpp2IlInjected.Address(RVA = "0x8AC0F90", Offset = "0x8ABF790", VA = "0x188AC0F90", Slot = "19")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000027")]
		public event Action<KCFXUMCPMEW> PCQHWSUJMZV
		{
			[Cpp2IlInjected.Token(Token = "0x6000284")]
			[Cpp2IlInjected.Address(RVA = "0x8AC2020", Offset = "0x8AC0820", VA = "0x188AC2020", Slot = "20")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000285")]
			[Cpp2IlInjected.Address(RVA = "0x8AC0C10", Offset = "0x8ABF410", VA = "0x188AC0C10", Slot = "21")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000028")]
		public event Action SREVJWXYFTC
		{
			[Cpp2IlInjected.Token(Token = "0x6000286")]
			[Cpp2IlInjected.Address(RVA = "0x8AC1420", Offset = "0x8ABFC20", VA = "0x188AC1420", Slot = "22")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000287")]
			[Cpp2IlInjected.Address(RVA = "0x8AC1250", Offset = "0x8ABFA50", VA = "0x188AC1250", Slot = "23")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000029")]
		public event Action<KCFXUMCPMEW> RMXSPNMEHVH
		{
			[Cpp2IlInjected.Token(Token = "0x6000288")]
			[Cpp2IlInjected.Address(RVA = "0x8AC1100", Offset = "0x8ABF900", VA = "0x188AC1100", Slot = "24")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000289")]
			[Cpp2IlInjected.Address(RVA = "0x8AC20D0", Offset = "0x8AC08D0", VA = "0x188AC20D0", Slot = "25")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x8AC2890", Offset = "0x8AC1090", VA = "0x188AC2890")]
		public RbexHierarchy(KCFXUMCPMEW rbex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x8AC0CC0", Offset = "0x8ABF4C0", VA = "0x188AC0CC0", Slot = "31")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x8AC1A10", Offset = "0x8AC0210", VA = "0x188AC1A10", Slot = "30")]
		public void SetParent(KCFXUMCPMEW newParent, bool isPhysicallyDetachedOnly = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x8AC2180", Offset = "0x8AC0980", VA = "0x188AC2180", Slot = "6")]
		public void VBGCYYKPHPI(KCFXUMCPMEW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x8AC16F0", Offset = "0x8ABFEF0", VA = "0x188AC16F0", Slot = "7")]
		public void REFIMFPACUH(KCFXUMCPMEW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x8AC0EA0", Offset = "0x8ABF6A0", VA = "0x188AC0EA0", Slot = "4")]
		public void FHTUHGKCEBC(KCFXUMCPMEW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x8AC2590", Offset = "0x8AC0D90", VA = "0x188AC2590", Slot = "5")]
		public void YIVTPKWEMNF(KCFXUMCPMEW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x8AC2630", Offset = "0x8AC0E30", VA = "0x188AC2630")]
		private void ZVTTVFKRMRM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x8AC14C0", Offset = "0x8ABFCC0", VA = "0x188AC14C0")]
		private void MTZCYAGYZSJ(KCFXUMCPMEW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x8AC1500", Offset = "0x8ABFD00", VA = "0x188AC1500")]
		private void NJLJJTIHLRQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x8AC12F0", Offset = "0x8ABFAF0", VA = "0x188AC12F0")]
		private void IBLIKRXAHZN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x8AC26D0", Offset = "0x8AC0ED0", VA = "0x188AC26D0")]
		private void ZXZZKGQXPBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x8AC1040", Offset = "0x8ABF840", VA = "0x188AC1040")]
		[CompilerGenerated]
		private object GEBFFWGGQAP()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	internal static class NLUNHGERAXB
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE9E0", Offset = "0x8ABD1E0", VA = "0x188ABE9E0")]
		public static RHILHRQPTCT BBLNRNJTPHU(this KCFXUMCPMEW a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	internal sealed class OLRFRZFMDCO : MGMJSLGDMDG, EFSYUOMQKCN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly ARLKEPXCFYV PWZFQDMMKMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private readonly WWHARXTEPTC<KCFXUMCPMEW> MGMXCWGPXYX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private bool WKNXYNSVIEQ;

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		public WWHARXTEPTC<KCFXUMCPMEW> ECXDHCVDUJZ
		{
			[Cpp2IlInjected.Token(Token = "0x600029D")]
			[Cpp2IlInjected.Address(RVA = "0xAACA70", Offset = "0xAAB270", VA = "0x180AACA70", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		public Vector3 HLLOTYUYZSU
		{
			[Cpp2IlInjected.Token(Token = "0x600029E")]
			[Cpp2IlInjected.Address(RVA = "0x8ABF620", Offset = "0x8ABDE20", VA = "0x188ABF620", Slot = "6")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		public Vector3 AMJTMNIIVKQ
		{
			[Cpp2IlInjected.Token(Token = "0x600029F")]
			[Cpp2IlInjected.Address(RVA = "0x8ABEB60", Offset = "0x8ABD360", VA = "0x188ABEB60", Slot = "7")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		private Vector3 AYHEGTBGIHA
		{
			[Cpp2IlInjected.Token(Token = "0x60002A3")]
			[Cpp2IlInjected.Address(RVA = "0x8ABF4C0", Offset = "0x8ABDCC0", VA = "0x188ABF4C0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		public KCFXUMCPMEW GJRQYTCUBST
		{
			[Cpp2IlInjected.Token(Token = "0x60002A4")]
			[Cpp2IlInjected.Address(RVA = "0x8ABF650", Offset = "0x8ABDE50", VA = "0x188ABF650", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x8ABF700", Offset = "0x8ABDF00", VA = "0x188ABF700")]
		public OLRFRZFMDCO(KCFXUMCPMEW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x8ABF5B0", Offset = "0x8ABDDB0", VA = "0x188ABF5B0", Slot = "8")]
		public void SBAEZBXPCBE(KCFXUMCPMEW a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x8ABF0C0", Offset = "0x8ABD8C0", VA = "0x188ABF0C0", Slot = "9")]
		public void HADFHIFJZPF(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x8ABF120", Offset = "0x8ABD920", VA = "0x188ABF120")]
		private Vector3 HQYRRUVGOBI()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x8ABED20", Offset = "0x8ABD520", VA = "0x188ABED20")]
		private void DDKRKUMTVJN(KCFXUMCPMEW a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	internal static class QNCEVEPMBVG
	{
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x8AC0A00", Offset = "0x8ABF200", VA = "0x188AC0A00")]
		public static MGMJSLGDMDG YHFLXQSOFUR(this KCFXUMCPMEW a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	internal sealed class CTQNJRQWYOY : LALNEHFDMJM, DMDWVMLYSNP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private readonly ARLKEPXCFYV PWZFQDMMKMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private readonly OverridableVector3 ITHDDXUKPHR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private readonly OverridableVector3 ALDPDARAOOY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private float UFSYCOCOEME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private float DHQLBPXSRVB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private Vector3 XUYTJXIQJUG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private Vector3? HWRJAJOPBEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private Quaternion? NIFXULDTLLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private bool NOGXJEQIPRH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private bool AGZIMLUELPS;

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		public Vector3 PZLHCVPMVLQ
		{
			[Cpp2IlInjected.Token(Token = "0x60002AA")]
			[Cpp2IlInjected.Address(RVA = "0x1C2F540", Offset = "0x1C2DD40", VA = "0x181C2F540", Slot = "7")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60002AB")]
			[Cpp2IlInjected.Address(RVA = "0x8AB4F50", Offset = "0x8AB3750", VA = "0x188AB4F50", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		public Vector3 KTNQBTXQNEZ
		{
			[Cpp2IlInjected.Token(Token = "0x60002AC")]
			[Cpp2IlInjected.Address(RVA = "0x8AB3A60", Offset = "0x8AB2260", VA = "0x188AB3A60", Slot = "9")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		public float NAAXVPFYAUP
		{
			[Cpp2IlInjected.Token(Token = "0x60002AD")]
			[Cpp2IlInjected.Address(RVA = "0xAFE380", Offset = "0xAFCB80", VA = "0x180AFE380", Slot = "10")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60002AE")]
			[Cpp2IlInjected.Address(RVA = "0x8AB31B0", Offset = "0x8AB19B0", VA = "0x188AB31B0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A4")]
		public float XLIFLXKNOJS
		{
			[Cpp2IlInjected.Token(Token = "0x60002AF")]
			[Cpp2IlInjected.Address(RVA = "0xAFE390", Offset = "0xAFCB90", VA = "0x180AFE390", Slot = "11")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60002B0")]
			[Cpp2IlInjected.Address(RVA = "0x8AB5530", Offset = "0x8AB3D30", VA = "0x188AB5530", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		public Vector3 VMDUPMYJMRA
		{
			[Cpp2IlInjected.Token(Token = "0x60002B1")]
			[Cpp2IlInjected.Address(RVA = "0x8AB35D0", Offset = "0x8AB1DD0", VA = "0x188AB35D0", Slot = "13")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A6")]
		public Quaternion RCANEXIIULS
		{
			[Cpp2IlInjected.Token(Token = "0x60002B2")]
			[Cpp2IlInjected.Address(RVA = "0x8AB3760", Offset = "0x8AB1F60", VA = "0x188AB3760", Slot = "14")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A7")]
		private Rigidbody KZZPYUWZQUT
		{
			[Cpp2IlInjected.Token(Token = "0x60002BA")]
			[Cpp2IlInjected.Address(RVA = "0x8AB32C0", Offset = "0x8AB1AC0", VA = "0x188AB32C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400002A")]
		public event RbexAction BTAZSIRPDPH
		{
			[Cpp2IlInjected.Token(Token = "0x60002A8")]
			[Cpp2IlInjected.Address(RVA = "0x8AB38E0", Offset = "0x8AB20E0", VA = "0x188AB38E0", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60002A9")]
			[Cpp2IlInjected.Address(RVA = "0x8AB3B80", Offset = "0x8AB2380", VA = "0x188AB3B80", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x8AB59E0", Offset = "0x8AB41E0", VA = "0x188AB59E0")]
		public CTQNJRQWYOY(KCFXUMCPMEW a, [In] RigidbodyExData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x8AB34B0", Offset = "0x8AB1CB0", VA = "0x188AB34B0", Slot = "17")]
		public void HLPLLOBFRRC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x8AB3980", Offset = "0x8AB2180", VA = "0x188AB3980", Slot = "16")]
		public void NFPVABQYXXJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x8AB55E0", Offset = "0x8AB3DE0", VA = "0x188AB55E0", Slot = "19")]
		public void TVVGGWJARMG(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x8AB5230", Offset = "0x8AB3A30", VA = "0x188AB5230", Slot = "20")]
		public void RXJVNBVWDRN(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x8AB5840", Offset = "0x8AB4040", VA = "0x188AB5840", Slot = "18")]
		public void XSLTZWPDBDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x8AB3C20", Offset = "0x8AB2420", VA = "0x188AB3C20", Slot = "21")]
		public void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x8AB4F50", Offset = "0x8AB3750", VA = "0x188AB4F50")]
		private void QOUDRWQEKMI(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x8AB5410", Offset = "0x8AB3C10", VA = "0x188AB5410")]
		[Obsolete("This method is dangerous - the unity rigidbody is updated in a deferred manner and this world position may be stale")]
		private Vector3 SNFHRERAVFF()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x8AB31B0", Offset = "0x8AB19B0", VA = "0x188AB31B0")]
		private void ATCPSTFOCSB(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x8AB5530", Offset = "0x8AB3D30", VA = "0x188AB5530")]
		private void YQKPIDBOCVA(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x8AB3310", Offset = "0x8AB1B10", VA = "0x188AB3310")]
		private Vector3 DUIGYYQUOIY()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x8AB5000", Offset = "0x8AB3800", VA = "0x188AB5000", Slot = "15")]
		public void QSBXUDHMGOA((Quaternion rot, Vector3 moments) tensor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x8AB56C0", Offset = "0x8AB3EC0", VA = "0x188AB56C0")]
		private Quaternion VDEIEONLIIO()
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x8AB4E80", Offset = "0x8AB3680", VA = "0x188AB4E80")]
		public void QLCUIKDFLDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x8AB40E0", Offset = "0x8AB28E0", VA = "0x188AB40E0", Slot = "4")]
		public (float, Vector3) QLCUIKDFLDN(Rigidbody a)
		{
			return default((float, Vector3));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	internal static class TNOEZPLXZTE
	{
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x8AC81C0", Offset = "0x8AC69C0", VA = "0x188AC81C0")]
		public static LALNEHFDMJM IKLTSFRMHPD(this KCFXUMCPMEW a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	internal sealed class HABRVFBJQLW : BIYDIZDMADJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private readonly ARLKEPXCFYV PWZFQDMMKMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private readonly VIJGXVWMDWL DRULMBQRTGR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private readonly RbexInterpolationMode RLIUCHHCCTA;

		[Cpp2IlInjected.Token(Token = "0x170000A8")]
		public bool ZLDCHQSSHSW
		{
			[Cpp2IlInjected.Token(Token = "0x60002C5")]
			[Cpp2IlInjected.Address(RVA = "0x1884390", Offset = "0x1882B90", VA = "0x181884390", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A9")]
		public RbexInterpolationMode SQMPCVEDKCA
		{
			[Cpp2IlInjected.Token(Token = "0x60002C6")]
			[Cpp2IlInjected.Address(RVA = "0xABE4C0", Offset = "0xABCCC0", VA = "0x180ABE4C0", Slot = "11")]
			get
			{
				return default(RbexInterpolationMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x8ABD6E0", Offset = "0x8ABBEE0", VA = "0x188ABD6E0")]
		public HABRVFBJQLW(KCFXUMCPMEW a, [In] RigidbodyExData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x8ABD170", Offset = "0x8ABB970", VA = "0x188ABD170", Slot = "4")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x8ABD0D0", Offset = "0x8ABB8D0", VA = "0x188ABD0D0")]
		private bool AJNZDOGCZKM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x8ABD540", Offset = "0x8ABBD40", VA = "0x188ABD540", Slot = "5")]
		public void VROUICKXTXW(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x8ABD4D0", Offset = "0x8ABBCD0", VA = "0x188ABD4D0", Slot = "6")]
		public void PCMBINFPXQH(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x8ABD570", Offset = "0x8ABBD70", VA = "0x188ABD570", Slot = "9")]
		public void WWXUUPCBNDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x8ABD240", Offset = "0x8ABBA40", VA = "0x188ABD240")]
		private void JLTNBGWFGQE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x8ABD350", Offset = "0x8ABBB50", VA = "0x188ABD350")]
		private void JZEQQRSHVDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x8ABD6A0", Offset = "0x8ABBEA0", VA = "0x188ABD6A0", Slot = "8")]
		public void XWCYTYGEZQW(KCFXUMCPMEW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x8ABD500", Offset = "0x8ABBD00", VA = "0x188ABD500", Slot = "7")]
		public void RWZKIRCWNLZ(KCFXUMCPMEW a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	internal sealed class AMRKHTYQKPN : KSZTPFCZMTC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private readonly ARLKEPXCFYV PWZFQDMMKMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private readonly VIJGXVWMDWL OKHWTGKBRPY;

		[Cpp2IlInjected.Token(Token = "0x170000AA")]
		public bool VGTBCFGYYRO
		{
			[Cpp2IlInjected.Token(Token = "0x60002D3")]
			[Cpp2IlInjected.Address(RVA = "0x8AAC540", Offset = "0x8AAAD40", VA = "0x188AAC540", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400002B")]
		public event RbexAction RXBREEHNZTC
		{
			[Cpp2IlInjected.Token(Token = "0x60002D1")]
			[Cpp2IlInjected.Address(RVA = "0x8AAC390", Offset = "0x8AAAB90", VA = "0x188AAC390", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60002D2")]
			[Cpp2IlInjected.Address(RVA = "0x8AAC2F0", Offset = "0x8AAAAF0", VA = "0x188AAC2F0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x8AAC700", Offset = "0x8AAAF00", VA = "0x188AAC700")]
		public AMRKHTYQKPN(KCFXUMCPMEW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x8AAC5F0", Offset = "0x8AAADF0", VA = "0x188AAC5F0", Slot = "7")]
		public void QOYUWQXNMRR(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x8AAC6B0", Offset = "0x8AAAEB0", VA = "0x188AAC6B0", Slot = "8")]
		public void YNSFSUVTQHS(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x8AAC430", Offset = "0x8AAAC30", VA = "0x188AAC430", Slot = "9")]
		public void FVQDXJJBWWG(object a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x8AAC6C0", Offset = "0x8AAAEC0", VA = "0x188AAC6C0", Slot = "12")]
		public void ZOGRZKROHSM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x8AAC630", Offset = "0x8AAAE30", VA = "0x188AAC630", Slot = "10")]
		public void TVVGGWJARMG(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x8AAC600", Offset = "0x8AAAE00", VA = "0x188AAC600", Slot = "11")]
		public void RXJVNBVWDRN(Rigidbody a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	internal sealed class QLVNYBBOCIC : CUDLGVCZIJC, JRFWRDYSFSZ, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private readonly ARLKEPXCFYV PWZFQDMMKMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private RRNetworkView NWGMBUIZVQQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private bool JEHYDDHAXPT;

		[Cpp2IlInjected.Token(Token = "0x170000AB")]
		public RRNetworkView HBDQETEECNS
		{
			[Cpp2IlInjected.Token(Token = "0x60002DD")]
			[Cpp2IlInjected.Address(RVA = "0xAB1210", Offset = "0xAAFA10", VA = "0x180AB1210", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AC")]
		public bool NTJLJSEQBCZ
		{
			[Cpp2IlInjected.Token(Token = "0x60002DE")]
			[Cpp2IlInjected.Address(RVA = "0x8AC0670", Offset = "0x8ABEE70", VA = "0x188AC0670", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AD")]
		public bool YCTRVLEUCOR
		{
			[Cpp2IlInjected.Token(Token = "0x60002DF")]
			[Cpp2IlInjected.Address(RVA = "0xCD7980", Offset = "0xCD6180", VA = "0x180CD7980", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400002C")]
		public event RbexAction EVQNVPIJSQC
		{
			[Cpp2IlInjected.Token(Token = "0x60002DB")]
			[Cpp2IlInjected.Address(RVA = "0x8AC0460", Offset = "0x8ABEC60", VA = "0x188AC0460", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60002DC")]
			[Cpp2IlInjected.Address(RVA = "0x8ABFDA0", Offset = "0x8ABE5A0", VA = "0x188ABFDA0", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x8AC07F0", Offset = "0x8ABEFF0", VA = "0x188AC07F0")]
		public QLVNYBBOCIC(KCFXUMCPMEW a, [In] RigidbodyExData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x8ABFC70", Offset = "0x8ABE470", VA = "0x188ABFC70", Slot = "9")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x8ABFE40", Offset = "0x8ABE640", VA = "0x188ABFE40", Slot = "12")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x8AC0680", Offset = "0x8ABEE80", VA = "0x188AC0680", Slot = "10")]
		public void XINNDDBIWJD(KCFXUMCPMEW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x8AC0080", Offset = "0x8ABE880", VA = "0x188AC0080", Slot = "11")]
		public void FFYMVTYPVQJ(KCFXUMCPMEW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x8AC0500", Offset = "0x8ABED00", VA = "0x188AC0500")]
		private void TEBTUQJJHPF(RRNetworkView a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x8ABFF30", Offset = "0x8ABE730", VA = "0x188ABFF30")]
		private void FDTQZZJQINX(CSFUYHSFTRK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x8AC01F0", Offset = "0x8ABE9F0", VA = "0x188AC01F0")]
		private void GOSMVJXYEXI(RRNetworkView a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	internal static class QMELRNCYFDG
	{
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x8AC0940", Offset = "0x8ABF140", VA = "0x188AC0940")]
		public static CUDLGVCZIJC Lifecycle(this KCFXUMCPMEW impl)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	internal sealed class CGANECNDSQY : AFEYQHWEQMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private readonly ARLKEPXCFYV PWZFQDMMKMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private RigidbodyConstraints PYOZIUIHCLD;

		[Cpp2IlInjected.Token(Token = "0x170000AE")]
		public bool XNSYEZHAWPM
		{
			[Cpp2IlInjected.Token(Token = "0x60002E9")]
			[Cpp2IlInjected.Address(RVA = "0xC2B730", Offset = "0xC29F30", VA = "0x180C2B730", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002EA")]
			[Cpp2IlInjected.Address(RVA = "0xC2B2F0", Offset = "0xC29AF0", VA = "0x180C2B2F0", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AF")]
		public bool UKLSYGQYQQZ
		{
			[Cpp2IlInjected.Token(Token = "0x60002EB")]
			[Cpp2IlInjected.Address(RVA = "0xC2B6A0", Offset = "0xC29EA0", VA = "0x180C2B6A0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002EC")]
			[Cpp2IlInjected.Address(RVA = "0xC2B800", Offset = "0xC2A000", VA = "0x180C2B800")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B0")]
		public RigidbodyConstraints ABXTYPHYPLX
		{
			[Cpp2IlInjected.Token(Token = "0x60002ED")]
			[Cpp2IlInjected.Address(RVA = "0xAB1200", Offset = "0xAAFA00", VA = "0x180AB1200", Slot = "7")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x60002EE")]
			[Cpp2IlInjected.Address(RVA = "0x8AB2FE0", Offset = "0x8AB17E0", VA = "0x188AB2FE0", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x8AB3110", Offset = "0x8AB1910", VA = "0x188AB3110")]
		public CGANECNDSQY(KCFXUMCPMEW a, [In] RigidbodyExData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x8AB2FB0", Offset = "0x8AB17B0", VA = "0x188AB2FB0", Slot = "9")]
		public void TVVGGWJARMG(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x8AB2F80", Offset = "0x8AB1780", VA = "0x188AB2F80", Slot = "10")]
		public void RXJVNBVWDRN(Rigidbody a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	internal sealed class MXUNYKWSWAP : EFDEPUUANJQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private readonly KCFXUMCPMEW PWZFQDMMKMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private float MVZRCCBOGMZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private float PWDSBDXWGZD;

		[Cpp2IlInjected.Token(Token = "0x170000B1")]
		public float YOGAWRHUNFD
		{
			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0xB05C20", Offset = "0xB04420", VA = "0x180B05C20", Slot = "4")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60002F4")]
			[Cpp2IlInjected.Address(RVA = "0x8ABE710", Offset = "0x8ABCF10", VA = "0x188ABE710", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B2")]
		public float ATZZTYKAKMF
		{
			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0xB05CA0", Offset = "0xB044A0", VA = "0x180B05CA0", Slot = "6")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60002F6")]
			[Cpp2IlInjected.Address(RVA = "0x8ABE8D0", Offset = "0x8ABD0D0", VA = "0x188ABE8D0", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE9A0", Offset = "0x8ABD1A0", VA = "0x188ABE9A0")]
		public MXUNYKWSWAP(KCFXUMCPMEW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE880", Offset = "0x8ABD080", VA = "0x188ABE880", Slot = "8")]
		public void TVVGGWJARMG(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE7E0", Offset = "0x8ABCFE0", VA = "0x188ABE7E0", Slot = "9")]
		public void RXJVNBVWDRN(Rigidbody a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	internal sealed class DHPPFYANIUZ : LPGZOIBPVVU
	{
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static readonly Log TZHNUCZNPHU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private readonly ARLKEPXCFYV PWZFQDMMKMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private bool ZGIANOWMXSC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private bool WQIRJTLJHQP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private int MMWXYJOHKRV;

		[Cpp2IlInjected.Token(Token = "0x170000B3")]
		private Rigidbody KZZPYUWZQUT
		{
			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0x8AB32C0", Offset = "0x8AB1AC0", VA = "0x188AB32C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B4")]
		private bool ZOKSRSIJABM
		{
			[Cpp2IlInjected.Token(Token = "0x60002FC")]
			[Cpp2IlInjected.Address(RVA = "0x8AB92A0", Offset = "0x8AB7AA0", VA = "0x188AB92A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B5")]
		private KCFXUMCPMEW LUZXDGFNRIX
		{
			[Cpp2IlInjected.Token(Token = "0x60002FD")]
			[Cpp2IlInjected.Address(RVA = "0x8AB9510", Offset = "0x8AB7D10", VA = "0x188AB9510")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B6")]
		private bool TCQRIIPANGB
		{
			[Cpp2IlInjected.Token(Token = "0x60002FE")]
			[Cpp2IlInjected.Address(RVA = "0x8AB9850", Offset = "0x8AB8050", VA = "0x188AB9850")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400002D")]
		public event RbexAction ONHGMNQQKRY
		{
			[Cpp2IlInjected.Token(Token = "0x60002F9")]
			[Cpp2IlInjected.Address(RVA = "0x8AB96C0", Offset = "0x8AB7EC0", VA = "0x188AB96C0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0x8AB9950", Offset = "0x8AB8150", VA = "0x188AB9950", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x8AB9C60", Offset = "0x8AB8460", VA = "0x188AB9C60")]
		public DHPPFYANIUZ(KCFXUMCPMEW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x8AB9210", Offset = "0x8AB7A10", VA = "0x188AB9210", Slot = "6")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x8AB9490", Offset = "0x8AB7C90", VA = "0x188AB9490", Slot = "8")]
		public void DSRHWURTWYA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x8AB9570", Offset = "0x8AB7D70", VA = "0x188AB9570", Slot = "7")]
		public bool MQGIXWISZSG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x8AB99F0", Offset = "0x8AB81F0", VA = "0x188AB99F0", Slot = "9")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x8AB98B0", Offset = "0x8AB80B0", VA = "0x188AB98B0", Slot = "13")]
		public void PNJTSCXQOYG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x8AB9AC0", Offset = "0x8AB82C0", VA = "0x188AB9AC0", Slot = "12")]
		public void TSDLVYPWTHL(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x8AB94A0", Offset = "0x8AB7CA0", VA = "0x188AB94A0", Slot = "10")]
		public bool GCGEZQXNRNI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x8AB9760", Offset = "0x8AB7F60", VA = "0x188AB9760", Slot = "11")]
		public bool OXEUXRTHKRJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x8AB92C0", Offset = "0x8AB7AC0", VA = "0x188AB92C0")]
		private bool CVUJTDRFPFD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x8AB9080", Offset = "0x8AB7880", VA = "0x188AB9080")]
		private void AFBFCLJCKQF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	internal sealed class FFWNNQEDRKC : MQEDLLPVLMT
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private readonly ARLKEPXCFYV PWZFQDMMKMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private readonly VIJGXVWMDWL UPMMZXMMUFI;

		[Cpp2IlInjected.Token(Token = "0x170000B7")]
		public Rigidbody KZZPYUWZQUT
		{
			[Cpp2IlInjected.Token(Token = "0x600030B")]
			[Cpp2IlInjected.Address(RVA = "0xAB1210", Offset = "0xAAFA10", VA = "0x180AB1210", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600030C")]
			[Cpp2IlInjected.Address(RVA = "0xAB0160", Offset = "0xAAE960", VA = "0x180AB0160")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B8")]
		private bool TCQRIIPANGB
		{
			[Cpp2IlInjected.Token(Token = "0x600030D")]
			[Cpp2IlInjected.Address(RVA = "0x8ABA160", Offset = "0x8AB8960", VA = "0x188ABA160")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B9")]
		public bool XYTDIQMSCSO
		{
			[Cpp2IlInjected.Token(Token = "0x6000310")]
			[Cpp2IlInjected.Address(RVA = "0x1884390", Offset = "0x1882B90", VA = "0x181884390", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x8ABA4F0", Offset = "0x8AB8CF0", VA = "0x188ABA4F0")]
		public FFWNNQEDRKC(KCFXUMCPMEW a, [In] RigidbodyExData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x8AB9CF0", Offset = "0x8AB84F0", VA = "0x188AB9CF0", Slot = "5")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x8ABA130", Offset = "0x8AB8930", VA = "0x188ABA130", Slot = "7")]
		public void KWOWYEDSTYQ(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x8AB9F80", Offset = "0x8AB8780", VA = "0x188AB9F80", Slot = "8")]
		public void FZIXPIBGRHB(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x8ABA1C0", Offset = "0x8AB89C0", VA = "0x188ABA1C0", Slot = "9")]
		public void PRRICTXEYNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x8AB9D90", Offset = "0x8AB8590", VA = "0x188AB9D90", Slot = "10")]
		public void DEZRHEBZLTR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x8AB9FB0", Offset = "0x8AB87B0", VA = "0x188AB9FB0", Slot = "11")]
		public void GFOWBIOICMK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	internal sealed class DGRIIWVDABT : BXBITBABXKA, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private readonly ARLKEPXCFYV PWZFQDMMKMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private readonly VIJGXVWMDWL ZFAYWMKQHPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private float HHEINXPYNUM;

		[Cpp2IlInjected.Token(Token = "0x170000BA")]
		public URFBIYRPPUA UPWGPIMLPQV
		{
			[Cpp2IlInjected.Token(Token = "0x6000316")]
			[Cpp2IlInjected.Address(RVA = "0xAAD0F0", Offset = "0xAAB8F0", VA = "0x180AAD0F0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000317")]
			[Cpp2IlInjected.Address(RVA = "0xAB0170", Offset = "0xAAE970", VA = "0x180AB0170", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		public KHHLPOITIKH LBXQSVZEMZW
		{
			[Cpp2IlInjected.Token(Token = "0x6000318")]
			[Cpp2IlInjected.Address(RVA = "0xAAD100", Offset = "0xAAB900", VA = "0x180AAD100", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000319")]
			[Cpp2IlInjected.Address(RVA = "0xAB1230", Offset = "0xAAFA30", VA = "0x180AB1230", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BC")]
		public Vector3 AYHEGTBGIHA
		{
			[Cpp2IlInjected.Token(Token = "0x600031A")]
			[Cpp2IlInjected.Address(RVA = "0x8AB7170", Offset = "0x8AB5970", VA = "0x188AB7170", Slot = "8")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600031B")]
			[Cpp2IlInjected.Address(RVA = "0x8AB63F0", Offset = "0x8AB4BF0", VA = "0x188AB63F0", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BD")]
		public Vector3 LQPZBJRYMGF
		{
			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(RVA = "0x8AB7E10", Offset = "0x8AB6610", VA = "0x188AB7E10", Slot = "10")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600031D")]
			[Cpp2IlInjected.Address(RVA = "0x8AB72C0", Offset = "0x8AB5AC0", VA = "0x188AB72C0", Slot = "11")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BE")]
		public Vector3 FSSWKICRZXY
		{
			[Cpp2IlInjected.Token(Token = "0x600031E")]
			[Cpp2IlInjected.Address(RVA = "0x8AB64B0", Offset = "0x8AB4CB0", VA = "0x188AB64B0", Slot = "12")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600031F")]
			[Cpp2IlInjected.Address(RVA = "0x8AB7350", Offset = "0x8AB5B50", VA = "0x188AB7350", Slot = "13")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BF")]
		public Vector3 OTSTNQZHDKL
		{
			[Cpp2IlInjected.Token(Token = "0x6000320")]
			[Cpp2IlInjected.Address(RVA = "0x8AB77C0", Offset = "0x8AB5FC0", VA = "0x188AB77C0", Slot = "14")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0x8AB8F70", Offset = "0x8AB7770", VA = "0x188AB8F70", Slot = "15")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C0")]
		public float KZQWAJUTWVG
		{
			[Cpp2IlInjected.Token(Token = "0x6000322")]
			[Cpp2IlInjected.Address(RVA = "0xB05C10", Offset = "0xB04410", VA = "0x180B05C10", Slot = "16")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000323")]
			[Cpp2IlInjected.Address(RVA = "0x8AB76B0", Offset = "0x8AB5EB0", VA = "0x188AB76B0", Slot = "17")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C1")]
		public bool WHUXSGFFTHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000324")]
			[Cpp2IlInjected.Address(RVA = "0x2350CB0", Offset = "0x234F4B0", VA = "0x182350CB0", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C2")]
		private UYDITCYYVQG GOFUGINGXKW
		{
			[Cpp2IlInjected.Token(Token = "0x6000339")]
			[Cpp2IlInjected.Address(RVA = "0x8025120", Offset = "0x8023920", VA = "0x188025120")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C3")]
		private bool ZOKSRSIJABM
		{
			[Cpp2IlInjected.Token(Token = "0x600033A")]
			[Cpp2IlInjected.Address(RVA = "0x8AB5BE0", Offset = "0x8AB43E0", VA = "0x188AB5BE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x8AB8FA0", Offset = "0x8AB77A0", VA = "0x188AB8FA0")]
		public DGRIIWVDABT(KCFXUMCPMEW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x8AB5B40", Offset = "0x8AB4340", VA = "0x188AB5B40", Slot = "19")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x8AB61A0", Offset = "0x8AB49A0", VA = "0x188AB61A0", Slot = "36")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x8AB8AB0", Offset = "0x8AB72B0", VA = "0x188AB8AB0", Slot = "28")]
		public void TVVGGWJARMG(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x1666BD0", Offset = "0x16653D0", VA = "0x181666BD0", Slot = "20")]
		public void RKOSNROAMFC(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x1666E80", Offset = "0x1665680", VA = "0x181666E80", Slot = "30")]
		public void WRFALFEZLXR(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x8AB6600", Offset = "0x8AB4E00", VA = "0x188AB6600", Slot = "35")]
		public Vector3 KJLJOJSXVLC(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x8AB88F0", Offset = "0x8AB70F0", VA = "0x188AB88F0", Slot = "34")]
		public Vector3 SVSHVTIPYVQ(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x8AB5B40", Offset = "0x8AB4340", VA = "0x188AB5B40", Slot = "27")]
		public void HYTPCBNMYJV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x8AB7650", Offset = "0x8AB5E50", VA = "0x188AB7650", Slot = "25")]
		public void NWOCEJPIFTQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x8AB72F0", Offset = "0x8AB5AF0", VA = "0x188AB72F0", Slot = "24")]
		public void MQMHPCFOIUZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x8AB7410", Offset = "0x8AB5C10", VA = "0x188AB7410", Slot = "33")]
		public void NMQVSFHNGSP(Vector3 a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x8AB6390", Offset = "0x8AB4B90", VA = "0x188AB6390", Slot = "32")]
		public void GJIHNAWIUOO(Vector3 a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x8AB67E0", Offset = "0x8AB4FE0", VA = "0x188AB67E0", Slot = "31")]
		public void KXWYNAOAZNN(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x8AB6B20", Offset = "0x8AB5320", VA = "0x188AB6B20", Slot = "22")]
		public void LOVHGHSVAVZ(RbexImpulseType a, Vector3 b, float c, float d = 8f, float e = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x8AB8CF0", Offset = "0x8AB74F0", VA = "0x188AB8CF0", Slot = "21")]
		public void VZVFBDLQSMS(RbexRotationType a, Vector3 b, float c = 1f / 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x8AB7990", Offset = "0x8AB6190", VA = "0x188AB7990", Slot = "23")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void PMIAGTGSUMJ(RbexRotationType a, Vector3 b, float c = 7f, float d = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x17BF170", Offset = "0x17BD970", VA = "0x1817BF170")]
		private static void QYFOJAUPHFZ(Vector3 a, Vector3 b, [Out] Vector3 c, [Out] Vector3 d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x8AB7F30", Offset = "0x8AB6730", VA = "0x188AB7F30", Slot = "29")]
		public Vector3 PZKZBGJXENC(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x8AB6200", Offset = "0x8AB4A00", VA = "0x188AB6200", Slot = "26")]
		public void EVUEGXNXVEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x8AB76B0", Offset = "0x8AB5EB0", VA = "0x188AB76B0")]
		private void VUJMWEMOZMK(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x8AB6980", Offset = "0x8AB5180", VA = "0x188AB6980")]
		private void LHTMQVRGQRC(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x8AB8BE0", Offset = "0x8AB73E0", VA = "0x188AB8BE0")]
		private Vector3 VOKEFOLJBNN()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x8AB8010", Offset = "0x8AB6810", VA = "0x188AB8010")]
		private void RWCCRAUECJV(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x8AB5C00", Offset = "0x8AB4400", VA = "0x188AB5C00")]
		private Vector3 CRIZQNFQEPP()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x8AB5D20", Offset = "0x8AB4520", VA = "0x188AB5D20")]
		private void CRPSOERSESF(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x8AB8490", Offset = "0x8AB6C90", VA = "0x188AB8490")]
		private void SKWWXTRFWGG(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x8AB78E0", Offset = "0x8AB60E0", VA = "0x188AB78E0")]
		private void PCABSDZSQYM()
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
