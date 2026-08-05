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
		[Cpp2IlInjected.Address(RVA = "0xD3AE50", Offset = "0xD39850", VA = "0x180D3AE50")]
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
		[Cpp2IlInjected.Address(RVA = "0xD3B3F0", Offset = "0xD39DF0", VA = "0x180D3B3F0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA193EE0", Offset = "0xA1928E0", VA = "0x18A193EE0", Slot = "4")]
		public override void WSFSWRIEDET()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xD3AE50", Offset = "0xD39850", VA = "0x180D3AE50")]
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
		private int[] YLRGDEQABQS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private ServiceBitset KVULHZCLSVL;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xD11C00", Offset = "0xD10600", VA = "0x180D11C00", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9B80530", Offset = "0x9B7EF30", VA = "0x189B80530", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xA1AC7D0", Offset = "0xA1AB1D0", VA = "0x18A1AC7D0")]
		private void AWUQDEJRHIB(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xA1ACAB0", Offset = "0xA1AB4B0", VA = "0x18A1ACAB0", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xA1ACB10", Offset = "0xA1AB510", VA = "0x18A1ACB10")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[DisallowMultipleComponent]
	public sealed class RigidbodyEx : MonoBehaviour, YHDDZOLJMSB, TVCKQLHYVUU, PVNROETDIYK
	{
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static readonly Log PDLJYJPLGBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private bool WWBQZVUWIYA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private QKWJAEPJXFJ NWESVTIDJKE;

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
		private Transform FMJMKQPLQXG;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal QKWJAEPJXFJ OSMSSPGHRIQ
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xA1A4A90", Offset = "0xA1A3490", VA = "0x18A1A4A90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private QKWJAEPJXFJ QJCMFPWTJCW
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xD11C00", Offset = "0xD10600", VA = "0x180D11C00", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int PJRJFPFLIKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0xA1A6800", Offset = "0xA1A5200", VA = "0x18A1A6800")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RigidbodyEx CNTDZRAJFAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0xA1A6B60", Offset = "0xA1A5560", VA = "0x18A1A6B60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx DVPPDBTFFRU
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xA1A6AA0", Offset = "0xA1A54A0", VA = "0x18A1A6AA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RigidbodyEx CVRJANTESXQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0xA1A7760", Offset = "0xA1A6160", VA = "0x18A1A7760")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xA1A8C60", Offset = "0xA1A7660", VA = "0x18A1A8C60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool DidStart
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x9524EF0", Offset = "0x95238F0", VA = "0x189524EF0", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x9525040", Offset = "0x9523A40", VA = "0x189525040")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Transform AAKCKIFEUAG
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x2623A30", Offset = "0x2622430", VA = "0x182623A30", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Transform EAGDHZXKKBH
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x2623A30", Offset = "0x2622430", VA = "0x182623A30", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Transform MCFYZDALZAF
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x2623A30", Offset = "0x2622430", VA = "0x182623A30", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public TransformTrackRate GFFTZLQIGUZ
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0xA1A6860", Offset = "0xA1A5260", VA = "0x18A1A6860")]
			get
			{
				return default(TransformTrackRate);
			}
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0xA1A8410", Offset = "0xA1A6E10", VA = "0x18A1A8410")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool JFPDTLGEIDE
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0xA1A6E70", Offset = "0xA1A5870", VA = "0x18A1A6E70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool WBPMVWTIPDO
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0xA1A6980", Offset = "0xA1A5380", VA = "0x18A1A6980")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public WVUHOKYUTXN YVBJYEAPPZW
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0xA1A6DB0", Offset = "0xA1A57B0", VA = "0x18A1A6DB0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0xA1A85D0", Offset = "0xA1A6FD0", VA = "0x18A1A85D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public RFDYMGDWISG YTBJYPKPQEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0xA1A6D50", Offset = "0xA1A5750", VA = "0x18A1A6D50")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0xA1A8560", Offset = "0xA1A6F60", VA = "0x18A1A8560")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool HWTSGYFCQVB
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xA1A6CA0", Offset = "0xA1A56A0", VA = "0x18A1A6CA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Rigidbody KMEPSQPZLEO
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xA1A6D00", Offset = "0xA1A5700", VA = "0x18A1A6D00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool THYSDCYKPXT
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xA1A69E0", Offset = "0xA1A53E0", VA = "0x18A1A69E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xA1A8480", Offset = "0xA1A6E80", VA = "0x18A1A8480")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool VMRMBHLZWYI
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x1A465C0", Offset = "0x1A44FC0", VA = "0x181A465C0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float VOCTFMWQBWW
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xA1A7700", Offset = "0xA1A6100", VA = "0x18A1A7700")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float HCZMOJFDWLL
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xA1A76A0", Offset = "0xA1A60A0", VA = "0x18A1A76A0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xA1A8BF0", Offset = "0xA1A75F0", VA = "0x18A1A8BF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public float LFQGISAEXBS
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xA1A70D0", Offset = "0xA1A5AD0", VA = "0x18A1A70D0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0xA1A8870", Offset = "0xA1A7270", VA = "0x18A1A8870")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public float KDPXDMPKSVU
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0xA1A6ED0", Offset = "0xA1A58D0", VA = "0x18A1A6ED0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0xA1A8640", Offset = "0xA1A7040", VA = "0x18A1A8640")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public bool OVVNPCWOXPH
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0xA1A7CB0", Offset = "0xA1A66B0", VA = "0x18A1A7CB0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0xA1A91A0", Offset = "0xA1A7BA0", VA = "0x18A1A91A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Vector3 QHNDMMBKOQZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xA1A7480", Offset = "0xA1A5E80", VA = "0x18A1A7480")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xA1A89C0", Offset = "0xA1A73C0", VA = "0x18A1A89C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public Vector3 MIFSMIDEPRE
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xA1A7DF0", Offset = "0xA1A67F0", VA = "0x18A1A7DF0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public CollisionDetectionMode MSVDAYBOMLY
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xA1A7010", Offset = "0xA1A5A10", VA = "0x18A1A7010")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xA1A8790", Offset = "0xA1A7190", VA = "0x18A1A8790")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public float ZWOPVWELUTX
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0xA1A6A40", Offset = "0xA1A5440", VA = "0x18A1A6A40")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xA1A84F0", Offset = "0xA1A6EF0", VA = "0x18A1A84F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public RigidbodyConstraints YAUDRAATSRI
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xA1A7070", Offset = "0xA1A5A70", VA = "0x18A1A7070")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xA1A8800", Offset = "0xA1A7200", VA = "0x18A1A8800")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public Vector3 OJLXQPBETMA
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0xA1A7820", Offset = "0xA1A6220", VA = "0x18A1A7820")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public Vector3 XHICQNQIQXG
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0xA1A7820", Offset = "0xA1A6220", VA = "0x18A1A7820")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0xA1A8F80", Offset = "0xA1A7980", VA = "0x18A1A8F80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public float ZFKTQZXLEVB
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0xA1A7560", Offset = "0xA1A5F60", VA = "0x18A1A7560")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xA1A8AA0", Offset = "0xA1A74A0", VA = "0x18A1A8AA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public float RKNEPKBDFVS
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xA1A7C50", Offset = "0xA1A6650", VA = "0x18A1A7C50")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xA1A9130", Offset = "0xA1A7B30", VA = "0x18A1A9130")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Quaternion ZJJFHKIDOMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0xA1A7900", Offset = "0xA1A6300", VA = "0x18A1A7900")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xA1A8D00", Offset = "0xA1A7700", VA = "0x18A1A8D00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Quaternion DXNQAETMYBX
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xA1A7B80", Offset = "0xA1A6580", VA = "0x18A1A7B80")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xA1A9060", Offset = "0xA1A7A60", VA = "0x18A1A9060")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector3 ZSORHCSITRT
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xA1A79D0", Offset = "0xA1A63D0", VA = "0x18A1A79D0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xA1A8DD0", Offset = "0xA1A77D0", VA = "0x18A1A8DD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Quaternion IRGNEDBMLXS
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xA1A7AB0", Offset = "0xA1A64B0", VA = "0x18A1A7AB0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xA1A8EB0", Offset = "0xA1A78B0", VA = "0x18A1A8EB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 EHHOXHMGZFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0xA1A7D10", Offset = "0xA1A6710", VA = "0x18A1A7D10")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xA1A9210", Offset = "0xA1A7C10", VA = "0x18A1A9210")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 BCNGMSINWIS
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0xA1A75C0", Offset = "0xA1A5FC0", VA = "0x18A1A75C0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xA1A8B10", Offset = "0xA1A7510", VA = "0x18A1A8B10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector3 AVJVENSEEUP
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xA1A6F30", Offset = "0xA1A5930", VA = "0x18A1A6F30")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0xA1A86B0", Offset = "0xA1A70B0", VA = "0x18A1A86B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector3 ETXMMFYJAAG
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xA1A73A0", Offset = "0xA1A5DA0", VA = "0x18A1A73A0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xA1A88E0", Offset = "0xA1A72E0", VA = "0x18A1A88E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector3 ZXCAOATCGMR
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xA1A7260", Offset = "0xA1A5C60", VA = "0x18A1A7260")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Quaternion HAHIZNJNUHF
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xA1A7190", Offset = "0xA1A5B90", VA = "0x18A1A7190")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public Vector3 CSLRZACPOHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0xA1A7FB0", Offset = "0xA1A69B0", VA = "0x18A1A7FB0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public Vector3 DEEZTYDZDER
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0xA1A7ED0", Offset = "0xA1A68D0", VA = "0x18A1A7ED0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool KDUCQGPHBSP
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0xA1A7340", Offset = "0xA1A5D40", VA = "0x18A1A7340")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool BDBRCQAMRPG
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0xA1A6E10", Offset = "0xA1A5810", VA = "0x18A1A6E10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool LTGDRGACLKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0xA1A6920", Offset = "0xA1A5320", VA = "0x18A1A6920")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool BUBWYSMVZAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0xA1A68C0", Offset = "0xA1A52C0", VA = "0x18A1A68C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool LVWKUFNGRDV
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xA1A67A0", Offset = "0xA1A51A0", VA = "0x18A1A67A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public bool KVRCQZJBEJM
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xA1A7130", Offset = "0xA1A5B30", VA = "0x18A1A7130")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool QWVJKLTWNYQ
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xE3CEA0", Offset = "0xE3B8A0", VA = "0x180E3CEA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event RbexParentChangeAction CXDUGPDGZVA
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xA1A66C0", Offset = "0xA1A50C0", VA = "0x18A1A66C0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xA1A8330", Offset = "0xA1A6D30", VA = "0x18A1A8330")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event RbexAction RIOECHADEBU
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xA1A6430", Offset = "0xA1A4E30", VA = "0x18A1A6430")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xA1A8090", Offset = "0xA1A6A90", VA = "0x18A1A8090")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event RbexAction QPDMSZBDOFG
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xA1A6490", Offset = "0xA1A4E90", VA = "0x18A1A6490")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xA1A8100", Offset = "0xA1A6B00", VA = "0x18A1A8100")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event RbexAction VZVWZZXUSDC
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xA1A65E0", Offset = "0xA1A4FE0", VA = "0x18A1A65E0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xA1A8250", Offset = "0xA1A6C50", VA = "0x18A1A8250")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<UpdateLOD, UpdateLOD> QEPRBJTSLKC
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xA1A6570", Offset = "0xA1A4F70", VA = "0x18A1A6570")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0xA1A81E0", Offset = "0xA1A6BE0", VA = "0x18A1A81E0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event RbexAction VGIKUADFNMT
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0xA1A6650", Offset = "0xA1A5050", VA = "0x18A1A6650")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xA1A82C0", Offset = "0xA1A6CC0", VA = "0x18A1A82C0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event RbexAction SMDEHUSTZUJ
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0xA1A6730", Offset = "0xA1A5130", VA = "0x18A1A6730")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0xA1A83A0", Offset = "0xA1A6DA0", VA = "0x18A1A83A0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event RbexAction YTGGJTOCZBC
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0xA1A6500", Offset = "0xA1A4F00", VA = "0x18A1A6500")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0xA1A8170", Offset = "0xA1A6B70", VA = "0x18A1A8170")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xD12070", Offset = "0xD10A70", VA = "0x180D12070", Slot = "8")]
		private void KFLJQQDBZPM(QKWJAEPJXFJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xA1A4E50", Offset = "0xA1A3850", VA = "0x18A1A4E50", Slot = "9")]
		public RigidbodyExData GetData()
		{
			return default(RigidbodyExData);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA1A4EE0", Offset = "0xA1A38E0", VA = "0x18A1A4EE0")]
		internal void HUWHBKDZYJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA1A6150", Offset = "0xA1A4B50", VA = "0x18A1A6150")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public void TestOverrideUnityRigidbody(Rigidbody rb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xA1A4BA0", Offset = "0xA1A35A0", VA = "0x18A1A4BA0")]
		public YHDDZOLJMSB GetChild(int index)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xA1A5DB0", Offset = "0xA1A47B0", VA = "0x18A1A5DB0")]
		public void SetInertiaTensor((Quaternion rot, Vector3 moments) tensor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xA1A4740", Offset = "0xA1A3140", VA = "0x18A1A4740")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA1A6040", Offset = "0xA1A4A40", VA = "0x18A1A6040")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xA1A4A90", Offset = "0xA1A3490", VA = "0x18A1A4A90")]
		private QKWJAEPJXFJ IUYYXHECONW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xA1A5A30", Offset = "0xA1A4430", VA = "0x18A1A5A30")]
		private void SRPDLCJVRSE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xA1A5400", Offset = "0xA1A3E00", VA = "0x18A1A5400")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xA1A5340", Offset = "0xA1A3D40", VA = "0x18A1A5340")]
		public void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0xA1A4EE0", Offset = "0xA1A38E0", VA = "0x18A1A4EE0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xA1A53A0", Offset = "0xA1A3DA0", VA = "0x18A1A53A0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xA1A5460", Offset = "0xA1A3E60", VA = "0x18A1A5460")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xA1A3D30", Offset = "0xA1A2730", VA = "0x18A1A3D30")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xA1A54C0", Offset = "0xA1A3EC0", VA = "0x18A1A54C0")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xA1A4B40", Offset = "0xA1A3540", VA = "0x18A1A4B40")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xA1A52E0", Offset = "0xA1A3CE0", VA = "0x18A1A52E0")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xA1A5F10", Offset = "0xA1A4910", VA = "0x18A1A5F10")]
		public void SetParent(RigidbodyEx value, bool isPhysicallyDetachedOnly = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0xA1A57D0", Offset = "0xA1A41D0", VA = "0x18A1A57D0")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xA1A4F70", Offset = "0xA1A3970", VA = "0x18A1A4F70")]
		public bool IsRigidbodyAncestor(RigidbodyEx possibleAncestor)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xA1A5070", Offset = "0xA1A3A70", VA = "0x18A1A5070")]
		public bool IsRigidbodyDescendant(RigidbodyEx possibleDescendant)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xA1A3FA0", Offset = "0xA1A29A0", VA = "0x18A1A3FA0")]
		public void AddInterpolationRestriction(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0xA1A5530", Offset = "0xA1A3F30", VA = "0x18A1A5530")]
		public void RemoveInterpolationRestriction(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0xA1A4010", Offset = "0xA1A2A10", VA = "0x18A1A4010")]
		public void AddKinematic(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0xA1A55A0", Offset = "0xA1A3FA0", VA = "0x18A1A55A0")]
		public void RemoveKinematic(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0xA1A5E90", Offset = "0xA1A4890", VA = "0x18A1A5E90")]
		public void SetKinematic(object token, bool setKinematic)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0xA1A5CB0", Offset = "0xA1A46B0", VA = "0x18A1A5CB0")]
		public void SetDiscontinuousPositionAndRotation(Vector3 newPosition, Quaternion newRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0xA1A5BB0", Offset = "0xA1A45B0", VA = "0x18A1A5BB0")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 newLocalPosition, Quaternion newLocalRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0xA1A4D40", Offset = "0xA1A3740", VA = "0x18A1A4D40")]
		public Vector3 GetConstrainedVelocity(Vector3 velocity)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0xA1A4C30", Offset = "0xA1A3630", VA = "0x18A1A4C30")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 angularVelocity)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0xA1A3EB0", Offset = "0xA1A28B0", VA = "0x18A1A3EB0")]
		public void AddForce(Vector3 force, ForceMode forceMode = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xA1A3DA0", Offset = "0xA1A27A0", VA = "0x18A1A3DA0")]
		public void AddForceAtPosition(Vector3 force, Vector3 position, ForceMode forceMode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0xA1A41E0", Offset = "0xA1A2BE0", VA = "0x18A1A41E0")]
		public void AddTorque(Vector3 torque, ForceMode forceMode = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xA1A4080", Offset = "0xA1A2A80", VA = "0x18A1A4080")]
		public void AddRelativeTorque(Vector3 torque, ForceMode forceMode = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0xA1A6220", Offset = "0xA1A4C20", VA = "0x18A1A6220")]
		public Vector3 WorldToLocalVelocity(Vector3 worldVelocity)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xA1A51D0", Offset = "0xA1A3BD0", VA = "0x18A1A51D0")]
		public Vector3 LocalToWorldVelocity(Vector3 localVelocity)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xA1A4A30", Offset = "0xA1A3430", VA = "0x18A1A4A30")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xA1A49D0", Offset = "0xA1A33D0", VA = "0x18A1A49D0")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0xA1A4970", Offset = "0xA1A3370", VA = "0x18A1A4970")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xA1A4910", Offset = "0xA1A3310", VA = "0x18A1A4910")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xA1A5930", Offset = "0xA1A4330", VA = "0x18A1A5930")]
		public void ResetVelocityWorldSpace(Vector3 worldLinearVelocity, Vector3 worldAngularVelocity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xA1A5830", Offset = "0xA1A4230", VA = "0x18A1A5830")]
		public void ResetVelocityLocalSpace(Vector3 localLinearVelocity, Vector3 localAngularVelocity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0xA1A56F0", Offset = "0xA1A40F0", VA = "0x18A1A56F0")]
		public void ResetLinearVelocityLocalSpace(Vector3 localLinearVelocity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xA1A6050", Offset = "0xA1A4A50", VA = "0x18A1A6050")]
		public bool SweepTest(Vector3 direction, [Out] RaycastHit hitInfo, float maxDistance)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xA1A5170", Offset = "0xA1A3B70", VA = "0x18A1A5170")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xA1A5FE0", Offset = "0xA1A49E0", VA = "0x18A1A5FE0")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xA1A61C0", Offset = "0xA1A4BC0", VA = "0x18A1A61C0")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0xA1A4170", Offset = "0xA1A2B70", VA = "0x18A1A4170")]
		public void AddShouldHaveUnityRigidbodyToken(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xA1A5610", Offset = "0xA1A4010", VA = "0x18A1A5610")]
		public void RemoveShouldHaveUnityRigidbodyToken(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0xA1A4570", Offset = "0xA1A2F70", VA = "0x18A1A4570")]
		public void ApplyForceVelocityChange(RbexImpulseType impulseType, Vector3 impulseDirection, float impulseSpeed, float impulseDirectionMaxSpeed = 8f, float impulseReflectiveRestitution = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0xA1A4470", Offset = "0xA1A2E70", VA = "0x18A1A4470")]
		public void ApplyAngularVelocityChange(RbexRotationType rotationType, Vector3 newAngularVelocity, float maxAngularSpeed = 1f / 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0xA1A4630", Offset = "0xA1A3030", VA = "0x18A1A4630")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void ApplyTorqueAngularVelocityChangeDeprecated(RbexRotationType rotationType, Vector3 rotation, float maxSpeed = 7f, float multiplyingFactor = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xA1A43A0", Offset = "0xA1A2DA0", VA = "0x18A1A43A0")]
		public bool AllowedScaleChange(float scaleFactor)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xA1A42D0", Offset = "0xA1A2CD0", VA = "0x18A1A42D0")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx parentOverride, object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xA1A5680", Offset = "0xA1A4080", VA = "0x18A1A5680")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x8DB5840", Offset = "0x8DB4240", VA = "0x188DB5840", Slot = "13")]
		private void ABHCDJDUKKB(QQYPAOLAOXV a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xA1A63C0", Offset = "0xA1A4DC0", VA = "0x18A1A63C0")]
		public RigidbodyEx()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x153B7A0", Offset = "0x153A1A0", VA = "0x18153B7A0", Slot = "4")]
		private GameObject GQYNAGGWWAE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0xD3D320", Offset = "0xD3BD20", VA = "0x180D3D320", Slot = "10")]
		private bool KGHEHBIBOPJ()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	internal static class FBAOXXPXYKO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0xA1918C0", Offset = "0xA1902C0", VA = "0x18A1918C0")]
		public static QKWJAEPJXFJ OSMSSPGHRIQ(this RigidbodyEx a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[RegisterService(typeof(WTGAJTVIDSE), new string[] { })]
	public class RigidbodyExManager : WTGAJTVIDSE, YMKBVOLYXIE
	{
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static readonly Log WVPIFBCBMJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private TXTLMDITMBF XYPHPWBDKDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private INBKNOCKMEO GNSIWEQJORW;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public TXTLMDITMBF DLIJRANVBBQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xD11BF0", Offset = "0xD105F0", VA = "0x180D11BF0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public INBKNOCKMEO SGFDLTKBDHG
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xD11BC0", Offset = "0xD105C0", VA = "0x180D11BC0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0xA1A3A60", Offset = "0xA1A2460", VA = "0x18A1A3A60", Slot = "7")]
		public void InitReferences(VBPLBVQDNMR services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0xA1A3AD0", Offset = "0xA1A24D0", VA = "0x18A1A3AD0", Slot = "6")]
		public QKWJAEPJXFJ PJQTIBFWLVK(RigidbodyEx a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public RigidbodyExManager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class PhysicsManager : SingletonMonoBehaviour<PhysicsManager>
	{
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static JOLHGBMRDLK UpdateAfterFixedUpdateRan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private int QBHUEKMMQEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private int IFGWEJNEXJY;

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0xA19DBD0", Offset = "0xA19C5D0", VA = "0x18A19DBD0")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0xA19DC50", Offset = "0xA19C650", VA = "0x18A19DC50")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0xA19DBF0", Offset = "0xA19C5F0", VA = "0x18A19DBF0")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string message, [Optional] UnityEngine.Object context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string message, [Optional] UnityEngine.Object context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0xA19DD50", Offset = "0xA19C750", VA = "0x18A19DD50")]
		public PhysicsManager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public static class MEDFZXNRUGS
	{
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		private class QMIXFIGKQWK : WVUHOKYUTXN, IDisposable
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "7")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0xD21460", Offset = "0xD1FE60", VA = "0x180D21460", Slot = "4")]
			public Vector3 ZQVCYSGDQST()
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0xD21460", Offset = "0xD1FE60", VA = "0x180D21460", Slot = "5")]
			public Vector3 BHCJUIKKXCK()
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0xD2BB70", Offset = "0xD2A570", VA = "0x180D2BB70", Slot = "6")]
			public bool LWSNRABZGIR(float a, float b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public QMIXFIGKQWK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public static WVUHOKYUTXN UQMQNWQTZRV
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0xA193FE0", Offset = "0xA1929E0", VA = "0x18A193FE0")]
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
	public interface GCBXFHPNZCL
	{
		[Cpp2IlInjected.Token(Token = "0x17000039")]
		CollisionDetectionMode SIREDEZKWKK
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
		void CQZRIDOYWJU(bool a);

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void QTWSBDZCDBD(bool a);

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void IYRYYPMRALZ(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool PFFLWBFLUIC(Vector3 a, [Out] RaycastHit b, float c);
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public interface ROFMRUVTMAM : IDisposable, PCQSWXWWJPE
	{
		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		TransformTrackRate GFFTZLQIGUZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		event Action<UpdateLOD, UpdateLOD> QEPRBJTSLKC;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void Awake();
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[ServiceLifetime(Lifetime.Application)]
	public interface INBKNOCKMEO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		KQPQJPMVRGD GARFAOFTKGR(QKWJAEPJXFJ a);

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		BWYMCIQBVZF FJFPXUIYYBX(QKWJAEPJXFJ a);

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		SYALCUWXMUM ULVNEMALHVU(QKWJAEPJXFJ a);

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		HEKBBSZZJLD RBMTWGRBSKX(QKWJAEPJXFJ a);

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "4")]
		FPZDPHQVNPJ WUENREYCJNH(QKWJAEPJXFJ a);

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "5")]
		ROFMRUVTMAM ACBYQMMUNCO(QKWJAEPJXFJ a);

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "6")]
		KDWLVJCYNQB SKXYSJCIIQX(QKWJAEPJXFJ a);

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "7")]
		CGVHWMHYFBN YTHOUHPXJYV(QKWJAEPJXFJ a);

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "8")]
		GCBXFHPNZCL VRVYGFPXIUV(QKWJAEPJXFJ a);

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "9")]
		ZFRELHXHUUG WQDDDVJOQIQ(QKWJAEPJXFJ a);

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "10")]
		JTGVBXJXUKE RSCOSKDWLNA(QKWJAEPJXFJ a, [In] RigidbodyExData data);

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "11")]
		WDKQISZFGMM NVHDNXFWTRY(QKWJAEPJXFJ a, [In] RigidbodyExData data);

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "12")]
		AUPZMBXNNVA LNOSVCZGVHO(QKWJAEPJXFJ a, [In] RigidbodyExData data);

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "13")]
		SFUBMWIOJPU MLSXVGYXARG(QKWJAEPJXFJ a, [In] RigidbodyExData data);

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "14")]
		DEFVXXTFABQ BNRELTXPYTW(QKWJAEPJXFJ a, [In] RigidbodyExData data);

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "15")]
		QKWJAEPJXFJ PJQTIBFWLVK(RigidbodyEx a, RigidbodyExData b, WTGAJTVIDSE c);
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface CGVHWMHYFBN
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void KTREOAGVOHW(Vector3 a, ForceMode b = ForceMode.Force);

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void BOOZXAYPSJE(Vector3 a, Vector3 b, ForceMode c);

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void IDIAHPYOYJB(Vector3 a, ForceMode b = ForceMode.Force);

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void JWDQHJPXVXR(Vector3 a, ForceMode b = ForceMode.Force);
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface ZFRELHXHUUG
	{
		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		bool BTFRLVKSEKV
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
		void IYRYYPMRALZ(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void JFBEYVNGVYM(Rigidbody a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public interface KQPQJPMVRGD : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		IReadOnlyList<QKWJAEPJXFJ> WOLRRISLOBQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(Slot = "18")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		QKWJAEPJXFJ DVPPDBTFFRU
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(Slot = "19")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		QKWJAEPJXFJ ZGGEFGSKGHA
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(Slot = "20")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(Slot = "21")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		event RbexAction RIOECHADEBU;

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		event RbexAction QPDMSZBDOFG;

		[Cpp2IlInjected.Token(Token = "0x1400000C")]
		event RbexParentChangeAction ZAMSAZCDZGS;

		[Cpp2IlInjected.Token(Token = "0x1400000D")]
		event Action GEDTHQFLUJB;

		[Cpp2IlInjected.Token(Token = "0x1400000E")]
		event Action SCRRYZSCRMM;

		[Cpp2IlInjected.Token(Token = "0x1400000F")]
		event Action<QKWJAEPJXFJ> VKJLNVMCROR;

		[Cpp2IlInjected.Token(Token = "0x14000010")]
		event Action<QKWJAEPJXFJ> ZAKVBBXPMOW;

		[Cpp2IlInjected.Token(Token = "0x14000011")]
		event Action QUUUECEJQPP;

		[Cpp2IlInjected.Token(Token = "0x14000012")]
		event Action<QKWJAEPJXFJ> AIGWOIDCYSK;

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "22")]
		void SetParent(QKWJAEPJXFJ newParent, bool isPhysicallyDetachedOnly = false);
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public interface SYALCUWXMUM
	{
		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		Vector3 BDTEOBHQHVB
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		Vector3 XQSIVSCDJBH
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void MQDLJSQKLLT(QKWJAEPJXFJ a, object b);

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void VLFIMCXGFYG(object a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public interface SFUBMWIOJPU
	{
		[Cpp2IlInjected.Token(Token = "0x17000041")]
		Vector3 DUIHMTFFOYR
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		Vector3 POMTXSZUWFA
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		float ZIHXXYDPYDA
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		float IPYMSUOTIZH
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(Slot = "7")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		Vector3 CGZXOJJXFHP
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		Quaternion IAVTIVKEGGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000013")]
		event RbexAction XADLZAIQNHW;

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void WVYCVGJYHKZ((Quaternion rot, Vector3 moments) tensor);

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(Slot = "11")]
		void XUKBQAFHGYA();

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void YUIIELZWBXR();

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(Slot = "13")]
		void UTKOWJRKKDP();

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void IYRYYPMRALZ(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void JFBEYVNGVYM(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void OnDrawGizmosSelected();
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public interface AUPZMBXNNVA
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Awake();

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void CPZHSNZCBQB(object a);

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void SVYAJRATTNW(object a);

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void MURJSCUWTHC(QKWJAEPJXFJ a);

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void KGEEVAWOLTF(QKWJAEPJXFJ a);

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void WSZVUNWPKOU();
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public interface KDWLVJCYNQB
	{
		[Cpp2IlInjected.Token(Token = "0x17000047")]
		bool WIEPRSEIEDR
		{
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000014")]
		event RbexAction YTYIHDDZFGV;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void XMSRXLHBREK(object a);

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void DFSIYEXFPXN(object a);

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void OBYZUVXNNRF(object a, bool b);

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void IYRYYPMRALZ(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void JFBEYVNGVYM(Rigidbody a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface WDKQISZFGMM : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000048")]
		bool JFPDTLGEIDE
		{
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		bool WBPMVWTIPDO
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000015")]
		event RbexAction YNKWLCSROWV;

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void Awake();

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void PEQIISHSXLY(QKWJAEPJXFJ a);

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void PRUTBBSDRCC(QKWJAEPJXFJ a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface DEFVXXTFABQ
	{
		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		bool THYSDCYKPXT
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		bool LATURWQMQEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		RigidbodyConstraints EZNDFAZTSZI
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
		void IYRYYPMRALZ(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void JFBEYVNGVYM(Rigidbody a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface HEKBBSZZJLD
	{
		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		float ZUXDFOHQRDG
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		float MFCIQCJBTJQ
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
		void IYRYYPMRALZ(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void JFBEYVNGVYM(Rigidbody a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public interface FPZDPHQVNPJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		static bool VZTTGJJNPHJ;

		[Cpp2IlInjected.Token(Token = "0x14000016")]
		event RbexAction OGOAFEVMMDB;

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void Awake();

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool VDZGZJQHPNV();

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void LXBLLQZOIXT();

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void Sleep();

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool DYNFUJBWTKR();

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool BIBIFEYVLAA();

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void RXQANEFISYS(bool a);

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void JLBTRDRXNMP();
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public interface JTGVBXJXUKE
	{
		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		Rigidbody KMEPSQPZLEO
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		bool RCIIHNLDPHN
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
		void HLCGERXTVMF(object a);

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void MNEOWEODBQM(object a);

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void GGORYLAPXKJ();
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public interface BWYMCIQBVZF : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000051")]
		WVUHOKYUTXN YVBJYEAPPZW
		{
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		RFDYMGDWISG YTBJYPKPQEL
		{
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		Vector3 BSEASMQNRBD
		{
			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(Slot = "5")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		Vector3 KBQMLTAIZYO
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(Slot = "7")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		Vector3 ZWTBMJSJWVZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(Slot = "9")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		Vector3 KYNAXETQPDU
		{
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(Slot = "11")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		float ZWOPVWELUTX
		{
			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(Slot = "13")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		bool HWTSGYFCQVB
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
		void XCUQQQZMVDD(object a);

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(Slot = "17")]
		void NCXSGWPIUIL(RbexRotationType a, Vector3 b, float c = 1f / 0f);

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(Slot = "18")]
		void HYTLDATUSKC(RbexImpulseType a, Vector3 b, float c, float d = 8f, float e = 1f);

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(Slot = "19")]
		void OSOWOPRZPTG(RbexRotationType a, Vector3 b, float c = 7f, float d = 1f);

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(Slot = "20")]
		void HHDHKIABFEQ();

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(Slot = "21")]
		void CKJMBCDCSDD();

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(Slot = "22")]
		void ZSMGXKTOFTW();

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(Slot = "23")]
		void JKWZYHQLLDG();

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(Slot = "24")]
		void IYRYYPMRALZ(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(Slot = "25")]
		Vector3 KBODHRPAEVT(Vector3 a);

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(Slot = "26")]
		void PICBYTTZGKU(object a);

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(Slot = "27")]
		void GYKLGATERSQ(Vector3 a);

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(Slot = "28")]
		void IUVRFJYBOSZ(Vector3 a, Vector3 b);

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(Slot = "29")]
		void PXQNGZKNRMQ(Vector3 a, Vector3 b);

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(Slot = "30")]
		Vector3 AEKZRDAVLDB(Vector3 a);

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(Slot = "31")]
		Vector3 USJKALWVPBH(Vector3 a);
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[ServiceLifetime(Lifetime.Application)]
	public interface TXTLMDITMBF
	{
		[Cpp2IlInjected.Token(Token = "0x17000059")]
		bool UOBAGHTKSAQ
		{
			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void OWXXFZWZRNQ(string a);

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void XQZLIIONDBH(RigidbodyEx a, Action b);

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		FSSDWGGYWWD PLUPQZNSWTW(int a);

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void UAYVZKFHUKU(Vector3 a, float b, Color c);
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[ServiceLifetime(Lifetime.Application)]
	public interface WTGAJTVIDSE
	{
		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		TXTLMDITMBF DLIJRANVBBQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		INBKNOCKMEO SGFDLTKBDHG
		{
			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(Slot = "2")]
		QKWJAEPJXFJ PJQTIBFWLVK(RigidbodyEx a);
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class MKMAZFGGDZY : QKWJAEPJXFJ, IDisposable, WBDFEOZNOSQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		internal readonly WTGAJTVIDSE VDDMESGPCMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		internal KQPQJPMVRGD EAYEHPCMKXD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		internal AUPZMBXNNVA ALHZEXVFBII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		internal WDKQISZFGMM XOPKYXXDEKW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		internal BWYMCIQBVZF EHHOXHMGZFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		internal SYALCUWXMUM MKIMEDXDVFY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		internal SFUBMWIOJPU AAMBFWPOCLW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		internal HEKBBSZZJLD EHWFPCOAXAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		internal ZFRELHXHUUG JHGPSWFZASI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		internal FPZDPHQVNPJ KMIYGEIFMDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		internal ROFMRUVTMAM KMZEGVDVCRA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		internal KDWLVJCYNQB MZTHLPWECRB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		internal CGVHWMHYFBN FIMSYNDRLPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		internal DEFVXXTFABQ LCKIMRUUUIQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		internal JTGVBXJXUKE CREUASBZZEW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		internal GCBXFHPNZCL ECISDWEBHKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		internal IDisposable KWHBNZYROMY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private bool THKTICQCUIO;

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public ObjectLocalId AZKQKUETGWM
		{
			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0xD11160", Offset = "0xD0FB60", VA = "0x180D11160", Slot = "22")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public YHDDZOLJMSB LDRVRWSGBXW
		{
			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0xDE9810", Offset = "0xDE8210", VA = "0x180DE9810", Slot = "24")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0xEA3500", Offset = "0xEA1F00", VA = "0x180EA3500")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public GameObject HSDZDWOXSYD
		{
			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0xD20440", Offset = "0xD1EE40", VA = "0x180D20440", Slot = "25")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0xD20450", Offset = "0xD1EE50", VA = "0x180D20450")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public Transform MFKEVDSZYGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0xEC1940", Offset = "0xEC0340", VA = "0x180EC1940", Slot = "26")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x101A5C0", Offset = "0x1018FC0", VA = "0x18101A5C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public Rigidbody KMEPSQPZLEO
		{
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0xA195100", Offset = "0xA193B00", VA = "0x18A195100", Slot = "23")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public QKWJAEPJXFJ ZGGEFGSKGHA
		{
			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0xA195600", Offset = "0xA194000", VA = "0x18A195600", Slot = "27")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0xA196630", Offset = "0xA195030", VA = "0x18A196630", Slot = "28")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public int PJRJFPFLIKH
		{
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0xA1974C0", Offset = "0xA195EC0", VA = "0x18A1974C0", Slot = "31")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public QKWJAEPJXFJ DVPPDBTFFRU
		{
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0xA19A490", Offset = "0xA198E90", VA = "0x18A19A490", Slot = "29")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public bool IOAXHOBNRTU
		{
			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0xA197630", Offset = "0xA196030", VA = "0x18A197630", Slot = "32")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public bool JFPDTLGEIDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0xA194D40", Offset = "0xA193740", VA = "0x18A194D40", Slot = "33")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public bool WBPMVWTIPDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0xA196020", Offset = "0xA194A20", VA = "0x18A196020", Slot = "34")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public WVUHOKYUTXN YVBJYEAPPZW
		{
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0xA198820", Offset = "0xA197220", VA = "0x18A198820", Slot = "35")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0xA19A690", Offset = "0xA199090", VA = "0x18A19A690", Slot = "36")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public RFDYMGDWISG YTBJYPKPQEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0xA196B90", Offset = "0xA195590", VA = "0x18A196B90", Slot = "37")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0xA196EB0", Offset = "0xA1958B0", VA = "0x18A196EB0", Slot = "38")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public float ZWOPVWELUTX
		{
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0xA199C50", Offset = "0xA198650", VA = "0x18A199C50", Slot = "39")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0xA194250", Offset = "0xA192C50", VA = "0x18A194250", Slot = "40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public Vector3 KBQMLTAIZYO
		{
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0xA196CE0", Offset = "0xA1956E0", VA = "0x18A196CE0", Slot = "41")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0xA1982C0", Offset = "0xA196CC0", VA = "0x18A1982C0", Slot = "42")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public Vector3 KYNAXETQPDU
		{
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0xA194880", Offset = "0xA193280", VA = "0x18A194880", Slot = "43")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0xA194B80", Offset = "0xA193580", VA = "0x18A194B80", Slot = "44")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public Vector3 BSEASMQNRBD
		{
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0xA198950", Offset = "0xA197350", VA = "0x18A198950", Slot = "45")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0xA194C60", Offset = "0xA193660", VA = "0x18A194C60", Slot = "46")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public Vector3 ZWTBMJSJWVZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0xA194660", Offset = "0xA193060", VA = "0x18A194660", Slot = "47")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0xA1992C0", Offset = "0xA197CC0", VA = "0x18A1992C0", Slot = "48")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public bool LTGDRGACLKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0xA1976F0", Offset = "0xA1960F0", VA = "0x18A1976F0", Slot = "49")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public bool BUBWYSMVZAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0xA194F60", Offset = "0xA193960", VA = "0x18A194F60", Slot = "50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public bool LVWKUFNGRDV
		{
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0xA1977C0", Offset = "0xA1961C0", VA = "0x18A1977C0", Slot = "51")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public bool HWTSGYFCQVB
		{
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0xA1993A0", Offset = "0xA197DA0", VA = "0x18A1993A0", Slot = "52")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public Vector3 BDTEOBHQHVB
		{
			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0xA194E40", Offset = "0xA193840", VA = "0x18A194E40", Slot = "53")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public Vector3 XQSIVSCDJBH
		{
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0xA199CF0", Offset = "0xA1986F0", VA = "0x18A199CF0", Slot = "54")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public Vector3 DUIHMTFFOYR
		{
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0xA198870", Offset = "0xA197270", VA = "0x18A198870", Slot = "55")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0xA195A50", Offset = "0xA194450", VA = "0x18A195A50", Slot = "56")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public Vector3 POMTXSZUWFA
		{
			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0xA195020", Offset = "0xA193A20", VA = "0x18A195020", Slot = "57")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public float ZIHXXYDPYDA
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0xA1951B0", Offset = "0xA193BB0", VA = "0x18A1951B0", Slot = "58")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public float IPYMSUOTIZH
		{
			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0xA198710", Offset = "0xA197110", VA = "0x18A198710", Slot = "59")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0xA199640", Offset = "0xA198040", VA = "0x18A199640", Slot = "60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public Vector3 CGZXOJJXFHP
		{
			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0xA196120", Offset = "0xA194B20", VA = "0x18A196120", Slot = "61")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public Quaternion IAVTIVKEGGP
		{
			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0xA1942B0", Offset = "0xA192CB0", VA = "0x18A1942B0", Slot = "62")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public float ZUXDFOHQRDG
		{
			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0xA195B30", Offset = "0xA194530", VA = "0x18A195B30", Slot = "64")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0xA197460", Offset = "0xA195E60", VA = "0x18A197460", Slot = "65")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public float MFCIQCJBTJQ
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0xA195650", Offset = "0xA194050", VA = "0x18A195650", Slot = "66")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0xA197B30", Offset = "0xA196530", VA = "0x18A197B30", Slot = "67")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public bool BTFRLVKSEKV
		{
			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0xA1996E0", Offset = "0xA1980E0", VA = "0x18A1996E0", Slot = "68")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0xA199880", Offset = "0xA198280", VA = "0x18A199880", Slot = "69")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public TransformTrackRate GFFTZLQIGUZ
		{
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0xA197580", Offset = "0xA195F80", VA = "0x18A197580", Slot = "70")]
			get
			{
				return default(TransformTrackRate);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0xA195E60", Offset = "0xA194860", VA = "0x18A195E60", Slot = "71")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public bool WIEPRSEIEDR
		{
			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0xA19A530", Offset = "0xA198F30", VA = "0x18A19A530", Slot = "72")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public Transform MCFYZDALZAF
		{
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0xEC1940", Offset = "0xEC0340", VA = "0x180EC1940", Slot = "73")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public Vector3 DUEENDPJJQB
		{
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0xA199210", Offset = "0xA197C10", VA = "0x18A199210", Slot = "74")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0xA195550", Offset = "0xA193F50", VA = "0x18A195550", Slot = "75")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public float SJIQQPDCMHV
		{
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0xA197DB0", Offset = "0xA1967B0", VA = "0x18A197DB0", Slot = "76")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0xA196690", Offset = "0xA195090", VA = "0x18A196690", Slot = "77")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public float WSLARIIVJKM
		{
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0xA196EA0", Offset = "0xA1958A0", VA = "0x18A196EA0", Slot = "78")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0xA19A0D0", Offset = "0xA198AD0", VA = "0x18A19A0D0", Slot = "79")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public Quaternion NBWFGXWVQCU
		{
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0xA197C00", Offset = "0xA196600", VA = "0x18A197C00", Slot = "80")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0xA1943E0", Offset = "0xA192DE0", VA = "0x18A1943E0", Slot = "81")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public Vector3 UAQIHVSIKOG
		{
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0xA199FD0", Offset = "0xA1989D0", VA = "0x18A199FD0", Slot = "82")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0xA194210", Offset = "0xA192C10", VA = "0x18A194210", Slot = "83")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public Quaternion UBMXPZFLWJF
		{
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0xA195950", Offset = "0xA194350", VA = "0x18A195950", Slot = "84")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0xA19A400", Offset = "0xA198E00", VA = "0x18A19A400", Slot = "85")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public RigidbodyConstraints EZNDFAZTSZI
		{
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0xA199F80", Offset = "0xA198980", VA = "0x18A199F80", Slot = "86")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0xA198760", Offset = "0xA197160", VA = "0x18A198760", Slot = "87")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public bool THYSDCYKPXT
		{
			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0xA199CA0", Offset = "0xA1986A0", VA = "0x18A199CA0", Slot = "88")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0xA1993F0", Offset = "0xA197DF0", VA = "0x18A1993F0", Slot = "89")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public CollisionDetectionMode SIREDEZKWKK
		{
			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0xA1956A0", Offset = "0xA1940A0", VA = "0x18A1956A0", Slot = "90")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0xA1957F0", Offset = "0xA1941F0", VA = "0x18A1957F0", Slot = "91")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public bool RVCHMUJRDDD
		{
			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0xA1944C0", Offset = "0xA192EC0", VA = "0x18A1944C0", Slot = "141")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public bool BDBRCQAMRPG
		{
			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0xA19A280", Offset = "0xA198C80", VA = "0x18A19A280", Slot = "92")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000017")]
		public event RbexAction RIOECHADEBU
		{
			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0xA195990", Offset = "0xA194390", VA = "0x18A195990", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0xA19A1D0", Offset = "0xA198BD0", VA = "0x18A19A1D0", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000018")]
		public event RbexAction QPDMSZBDOFG
		{
			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0xA194600", Offset = "0xA193000", VA = "0x18A194600", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0xA195E00", Offset = "0xA194800", VA = "0x18A195E00", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000019")]
		public event RbexParentChangeAction ZAMSAZCDZGS
		{
			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0xA1959F0", Offset = "0xA1943F0", VA = "0x18A1959F0", Slot = "18")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0xA1987C0", Offset = "0xA1971C0", VA = "0x18A1987C0", Slot = "19")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001A")]
		public event RbexAction YNKWLCSROWV
		{
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0xA199F20", Offset = "0xA198920", VA = "0x18A199F20", Slot = "8")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0xA19A430", Offset = "0xA198E30", VA = "0x18A19A430", Slot = "9")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001B")]
		public event RbexAction VZVWZZXUSDC
		{
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0xA19A010", Offset = "0xA198A10", VA = "0x18A19A010", Slot = "14")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0xA199450", Offset = "0xA197E50", VA = "0x18A199450", Slot = "15")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001C")]
		public event RbexAction OGOAFEVMMDB
		{
			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0xA198260", Offset = "0xA196C60", VA = "0x18A198260", Slot = "16")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0xA197690", Offset = "0xA196090", VA = "0x18A197690", Slot = "17")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001D")]
		public event Action<UpdateLOD, UpdateLOD> QEPRBJTSLKC
		{
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0xA1965D0", Offset = "0xA194FD0", VA = "0x18A1965D0", Slot = "20")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0xA194FC0", Offset = "0xA1939C0", VA = "0x18A194FC0", Slot = "21")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001E")]
		public event RbexAction YTYIHDDZFGV
		{
			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0xA19A580", Offset = "0xA198F80", VA = "0x18A19A580", Slot = "12")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0xA196370", Offset = "0xA194D70", VA = "0x18A196370", Slot = "13")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001F")]
		public event RbexAction YTGGJTOCZBC
		{
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0xA194AD0", Offset = "0xA1934D0", VA = "0x18A194AD0", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0xA194D90", Offset = "0xA193790", VA = "0x18A194D90", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0xA19A780", Offset = "0xA199180", VA = "0x18A19A780")]
		public MKMAZFGGDZY(GameObject a, RigidbodyEx b, WTGAJTVIDSE c, [In] RigidbodyExData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0xA195260", Offset = "0xA193C60", VA = "0x18A195260", Slot = "139")]
		protected virtual void DNNANFBXEAW(WTGAJTVIDSE a, RigidbodyExData b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0xA1956F0", Offset = "0xA1940F0", VA = "0x18A1956F0", Slot = "140")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0xA194740", Offset = "0xA193140", VA = "0x18A194740", Slot = "93")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0xA197E90", Offset = "0xA196890", VA = "0x18A197E90", Slot = "94")]
		public void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0xA197DE0", Offset = "0xA1967E0", VA = "0x18A197DE0", Slot = "95")]
		public void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0xA197DC0", Offset = "0xA1967C0", VA = "0x18A197DC0", Slot = "96")]
		public void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0xA198F80", Offset = "0xA197980", VA = "0x18A198F80")]
		private void RXQANEFISYS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0xA195EC0", Offset = "0xA1948C0", VA = "0x18A195EC0")]
		private void GOYPNLTSWBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0xA194960", Offset = "0xA193360", VA = "0x18A194960")]
		private void BIBIFEYVLAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0xA197740", Offset = "0xA196140", VA = "0x18A197740", Slot = "30")]
		public QKWJAEPJXFJ NACOHYJOFPG(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0xA199580", Offset = "0xA197F80", VA = "0x18A199580", Slot = "98")]
		public void SetParent(QKWJAEPJXFJ value, bool isPhysicallyDetachedOnly = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0xA194380", Offset = "0xA192D80", VA = "0x18A194380", Slot = "99")]
		public void AIXKSBWNICL(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0xA1940B0", Offset = "0xA192AB0", VA = "0x18A1940B0", Slot = "100")]
		public void ADTNFYMBHYS(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0xA199730", Offset = "0xA198130", VA = "0x18A199730", Slot = "101")]
		public Vector3 USJKALWVPBH(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0xA194110", Offset = "0xA192B10", VA = "0x18A194110", Slot = "102")]
		public Vector3 AEKZRDAVLDB(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0xA196810", Offset = "0xA195210", VA = "0x18A196810", Slot = "103")]
		public void JKWZYHQLLDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0xA194F10", Offset = "0xA193910", VA = "0x18A194F10", Slot = "104")]
		public void CKJMBCDCSDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0xA196070", Offset = "0xA194A70", VA = "0x18A196070", Slot = "105")]
		public void HHDHKIABFEQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0xA198470", Offset = "0xA196E70", VA = "0x18A198470", Slot = "106")]
		public void PXQNGZKNRMQ(Vector3 a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0xA196720", Offset = "0xA195120", VA = "0x18A196720", Slot = "107")]
		public void IUVRFJYBOSZ(Vector3 a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0xA195F40", Offset = "0xA194940", VA = "0x18A195F40", Slot = "108")]
		public void GYKLGATERSQ(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0xA1962B0", Offset = "0xA194CB0", VA = "0x18A1962B0", Slot = "109")]
		public void HYTLDATUSKC(RbexImpulseType a, Vector3 b, float c, float d = 8f, float e = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0xA1978A0", Offset = "0xA1962A0", VA = "0x18A1978A0", Slot = "110")]
		public void NCXSGWPIUIL(RbexRotationType a, Vector3 b, float c = 1f / 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0xA197CA0", Offset = "0xA1966A0", VA = "0x18A197CA0", Slot = "111")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void OSOWOPRZPTG(RbexRotationType a, Vector3 b, float c = 7f, float d = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0xA196BE0", Offset = "0xA1955E0", VA = "0x18A196BE0", Slot = "112")]
		public Vector3 KBODHRPAEVT(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0xA195850", Offset = "0xA194250", VA = "0x18A195850", Slot = "113")]
		public Vector3 EOIEYIPTGQP(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0xA19A640", Offset = "0xA199040", VA = "0x18A19A640", Slot = "114")]
		public void ZSMGXKTOFTW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0xA199EB0", Offset = "0xA1988B0", VA = "0x18A199EB0", Slot = "115")]
		public void WZWDRJZSJJU(QKWJAEPJXFJ a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0xA197AD0", Offset = "0xA1964D0", VA = "0x18A197AD0", Slot = "116")]
		public void NZKPXCGWLIX(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0xA199DD0", Offset = "0xA1987D0", VA = "0x18A199DD0", Slot = "63")]
		public void WVYCVGJYHKZ((Quaternion rot, Vector3 moments) tensor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0xA19A4E0", Offset = "0xA198EE0", VA = "0x18A19A4E0", Slot = "117")]
		public void YUIIELZWBXR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0xA19A230", Offset = "0xA198C30", VA = "0x18A19A230", Slot = "118")]
		public void XUKBQAFHGYA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0xA199830", Offset = "0xA198230", VA = "0x18A199830", Slot = "119")]
		public void UTKOWJRKKDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0xA1998E0", Offset = "0xA1982E0", VA = "0x18A1998E0", Slot = "120")]
		public bool VDZGZJQHPNV()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0xA1995F0", Offset = "0xA197FF0", VA = "0x18A1995F0", Slot = "97")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0xA196860", Offset = "0xA195260", VA = "0x18A196860", Slot = "121")]
		public void JLBTRDRXNMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0xA19A070", Offset = "0xA198A70", VA = "0x18A19A070", Slot = "122")]
		public void XMSRXLHBREK(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0xA195200", Offset = "0xA193C00", VA = "0x18A195200", Slot = "123")]
		public void DFSIYEXFPXN(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0xA197B90", Offset = "0xA196590", VA = "0x18A197B90", Slot = "124")]
		public void OBYZUVXNNRF(object a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0xA197260", Offset = "0xA195C60", VA = "0x18A197260", Slot = "125")]
		public void LRGSYVVIJNH(Vector3 a, Quaternion b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0xA195B80", Offset = "0xA194580", VA = "0x18A195B80", Slot = "126")]
		public void FYELTDJWKTL(Vector3 a, Quaternion b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0xA197530", Offset = "0xA195F30", VA = "0x18A197530", Slot = "127")]
		public bool MHODHRBCMMY(float a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0xA19A5E0", Offset = "0xA198FE0", VA = "0x18A19A5E0", Slot = "128")]
		public void ZQFSGMFGDSN(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0xA195150", Offset = "0xA193B50", VA = "0x18A195150", Slot = "129")]
		public void DAKTLGWHVUC(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0xA1960C0", Offset = "0xA194AC0", VA = "0x18A1960C0", Slot = "130")]
		public void HLCGERXTVMF(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0xA1975D0", Offset = "0xA195FD0", VA = "0x18A1975D0", Slot = "131")]
		public void MNEOWEODBQM(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0xA196DC0", Offset = "0xA1957C0", VA = "0x18A196DC0", Slot = "132")]
		public void KTREOAGVOHW(Vector3 a, ForceMode b = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0xA1949C0", Offset = "0xA1933C0", VA = "0x18A1949C0", Slot = "133")]
		public void BOOZXAYPSJE(Vector3 a, Vector3 b, ForceMode c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0xA1963D0", Offset = "0xA194DD0", VA = "0x18A1963D0", Slot = "134")]
		public void IDIAHPYOYJB(Vector3 a, ForceMode b = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0xA196AB0", Offset = "0xA1954B0", VA = "0x18A196AB0", Slot = "135")]
		public void JWDQHJPXVXR(Vector3 a, ForceMode b = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0xA197FF0", Offset = "0xA1969F0", VA = "0x18A197FF0", Slot = "136")]
		public bool PFFLWBFLUIC(Vector3 a, [Out] RaycastHit b, float c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0xA197E40", Offset = "0xA196840", VA = "0x18A197E40", Slot = "137")]
		public void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0xA1996A0", Offset = "0xA1980A0", VA = "0x18A1996A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0xA1994B0", Offset = "0xA197EB0", VA = "0x18A1994B0")]
		private void SZSMEJULUUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0xA198A30", Offset = "0xA197430", VA = "0x18A198A30")]
		private void RSASWAMAWDG(QKWJAEPJXFJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0xA1968D0", Offset = "0xA1952D0", VA = "0x18A1968D0")]
		private void JVVJEIAVLOD(QKWJAEPJXFJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0xA196200", Offset = "0xA194C00", VA = "0x18A196200")]
		private void HTFVYYEHWTC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0xA1979A0", Offset = "0xA1963A0", VA = "0x18A1979A0")]
		private void NNMOTWPSTSZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0xA198560", Offset = "0xA196F60", VA = "0x18A198560")]
		private void PYBNEQECZDP(QKWJAEPJXFJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0xA197F20", Offset = "0xA196920", VA = "0x18A197F20")]
		private void PEQIISHSXLY(QKWJAEPJXFJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0xA1983A0", Offset = "0xA196DA0", VA = "0x18A1983A0")]
		private void PRUTBBSDRCC(QKWJAEPJXFJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0xA195CB0", Offset = "0xA1946B0", VA = "0x18A195CB0")]
		private void GAPSPPRLHOT(YHDDZOLJMSB a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0xA198B40", Offset = "0xA197540", VA = "0x18A198B40", Slot = "142")]
		protected virtual void RTISDGJUQNW(YHDDZOLJMSB a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0xA199930", Offset = "0xA198330", VA = "0x18A199930")]
		protected void VERGACHFOWG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0xA196F10", Offset = "0xA195910", VA = "0x18A196F10")]
		protected void LQPACRFMARI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0xA1964B0", Offset = "0xA194EB0", VA = "0x18A1964B0")]
		private void IDPYCZBVMCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0xA1980F0", Offset = "0xA196AF0", VA = "0x18A1980F0")]
		private void PGAXMVLYGYR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	internal static class RBYPHLSEDOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0xA19ECB0", Offset = "0xA19D6B0", VA = "0x18A19ECB0")]
		public static QKWJAEPJXFJ QPKVACJUERD(this QKWJAEPJXFJ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0xA19EC10", Offset = "0xA19D610", VA = "0x18A19EC10")]
		public static bool KROGSXDQWKI(this QKWJAEPJXFJ a, QKWJAEPJXFJ b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0xA19EB70", Offset = "0xA19D570", VA = "0x18A19EB70")]
		public static bool DMWNLRVFOWW(this QKWJAEPJXFJ a, QKWJAEPJXFJ b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0xA19EB20", Offset = "0xA19D520", VA = "0x18A19EB20")]
		public static YHDDZOLJMSB CNIQEXDALQQ(this QKWJAEPJXFJ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0xA19EAB0", Offset = "0xA19D4B0", VA = "0x18A19EAB0")]
		public static MKMAZFGGDZY Base(this QKWJAEPJXFJ impl)
		{
			return null;
		}
	}
}
namespace RecRoom.Rbex.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class JYTYEONXEAL : INBKNOCKMEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0xA193770", Offset = "0xA192170", VA = "0x18A193770", Slot = "19")]
		public QKWJAEPJXFJ PJQTIBFWLVK(RigidbodyEx a, RigidbodyExData b, WTGAJTVIDSE c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0xD11160", Offset = "0xD0FB60", VA = "0x180D11160", Slot = "4")]
		public KQPQJPMVRGD GARFAOFTKGR(QKWJAEPJXFJ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0xD11160", Offset = "0xD0FB60", VA = "0x180D11160", Slot = "5")]
		public BWYMCIQBVZF FJFPXUIYYBX(QKWJAEPJXFJ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0xD11160", Offset = "0xD0FB60", VA = "0x180D11160", Slot = "6")]
		public SYALCUWXMUM ULVNEMALHVU(QKWJAEPJXFJ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0xD11160", Offset = "0xD0FB60", VA = "0x180D11160", Slot = "7")]
		public HEKBBSZZJLD RBMTWGRBSKX(QKWJAEPJXFJ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0xD11160", Offset = "0xD0FB60", VA = "0x180D11160", Slot = "8")]
		public FPZDPHQVNPJ WUENREYCJNH(QKWJAEPJXFJ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0xD11160", Offset = "0xD0FB60", VA = "0x180D11160", Slot = "9")]
		public ROFMRUVTMAM ACBYQMMUNCO(QKWJAEPJXFJ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0xD11160", Offset = "0xD0FB60", VA = "0x180D11160", Slot = "10")]
		public KDWLVJCYNQB SKXYSJCIIQX(QKWJAEPJXFJ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0xD11160", Offset = "0xD0FB60", VA = "0x180D11160", Slot = "11")]
		public CGVHWMHYFBN YTHOUHPXJYV(QKWJAEPJXFJ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0xD11160", Offset = "0xD0FB60", VA = "0x180D11160", Slot = "12")]
		public GCBXFHPNZCL VRVYGFPXIUV(QKWJAEPJXFJ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0xD11160", Offset = "0xD0FB60", VA = "0x180D11160", Slot = "13")]
		public ZFRELHXHUUG WQDDDVJOQIQ(QKWJAEPJXFJ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0xD11160", Offset = "0xD0FB60", VA = "0x180D11160")]
		public JTGVBXJXUKE RSCOSKDWLNA(QKWJAEPJXFJ a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0xD11160", Offset = "0xD0FB60", VA = "0x180D11160")]
		public WDKQISZFGMM NVHDNXFWTRY(QKWJAEPJXFJ a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0xD11160", Offset = "0xD0FB60", VA = "0x180D11160")]
		public AUPZMBXNNVA LNOSVCZGVHO(QKWJAEPJXFJ a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0xD11160", Offset = "0xD0FB60", VA = "0x180D11160")]
		public SFUBMWIOJPU MLSXVGYXARG(QKWJAEPJXFJ a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0xD11160", Offset = "0xD0FB60", VA = "0x180D11160")]
		public DEFVXXTFABQ BNRELTXPYTW(QKWJAEPJXFJ a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public JYTYEONXEAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0xD11160", Offset = "0xD0FB60", VA = "0x180D11160", Slot = "14")]
		private JTGVBXJXUKE JQDXXMEBIDI(QKWJAEPJXFJ a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0xD11160", Offset = "0xD0FB60", VA = "0x180D11160", Slot = "15")]
		private WDKQISZFGMM ECZISDAEMDA(QKWJAEPJXFJ a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0xD11160", Offset = "0xD0FB60", VA = "0x180D11160", Slot = "16")]
		private AUPZMBXNNVA LXSPCGXISNO(QKWJAEPJXFJ a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0xD11160", Offset = "0xD0FB60", VA = "0x180D11160", Slot = "17")]
		private SFUBMWIOJPU EWNWDXLKXXG(QKWJAEPJXFJ a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0xD11160", Offset = "0xD0FB60", VA = "0x180D11160", Slot = "18")]
		private DEFVXXTFABQ RNAGIKXUHQA(QKWJAEPJXFJ a, [In] RigidbodyExData data)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[RegisterService(typeof(INBKNOCKMEO), new string[] { })]
	public class QGVHVBKQBDA : INBKNOCKMEO, YMKBVOLYXIE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private readonly INBKNOCKMEO INNQHEASDIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private readonly INBKNOCKMEO KTMEYLLCJPY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private CADUTZOBWOA ENGPLZTHIAH;

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		private INBKNOCKMEO SGFDLTKBDHG
		{
			[Cpp2IlInjected.Token(Token = "0x600021F")]
			[Cpp2IlInjected.Address(RVA = "0xA19E5D0", Offset = "0xA19CFD0", VA = "0x18A19E5D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0xA19E190", Offset = "0xA19CB90", VA = "0x18A19E190", Slot = "20")]
		public void InitReferences(VBPLBVQDNMR services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0xA19E0F0", Offset = "0xA19CAF0", VA = "0x18A19E0F0", Slot = "4")]
		public KQPQJPMVRGD GARFAOFTKGR(QKWJAEPJXFJ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0xA19E050", Offset = "0xA19CA50", VA = "0x18A19E050", Slot = "5")]
		public BWYMCIQBVZF FJFPXUIYYBX(QKWJAEPJXFJ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0xA19E630", Offset = "0xA19D030", VA = "0x18A19E630", Slot = "6")]
		public SYALCUWXMUM ULVNEMALHVU(QKWJAEPJXFJ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0xA19E490", Offset = "0xA19CE90", VA = "0x18A19E490", Slot = "7")]
		public HEKBBSZZJLD RBMTWGRBSKX(QKWJAEPJXFJ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0xA19E810", Offset = "0xA19D210", VA = "0x18A19E810", Slot = "8")]
		public FPZDPHQVNPJ WUENREYCJNH(QKWJAEPJXFJ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0xA19DDA0", Offset = "0xA19C7A0", VA = "0x18A19DDA0", Slot = "9")]
		public ROFMRUVTMAM ACBYQMMUNCO(QKWJAEPJXFJ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0xA19E530", Offset = "0xA19CF30", VA = "0x18A19E530", Slot = "10")]
		public KDWLVJCYNQB SKXYSJCIIQX(QKWJAEPJXFJ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0xA19E8B0", Offset = "0xA19D2B0", VA = "0x18A19E8B0", Slot = "11")]
		public CGVHWMHYFBN YTHOUHPXJYV(QKWJAEPJXFJ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0xA19E6D0", Offset = "0xA19D0D0", VA = "0x18A19E6D0", Slot = "12")]
		public GCBXFHPNZCL VRVYGFPXIUV(QKWJAEPJXFJ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0xA19E770", Offset = "0xA19D170", VA = "0x18A19E770", Slot = "13")]
		public ZFRELHXHUUG WQDDDVJOQIQ(QKWJAEPJXFJ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0xA19E1E0", Offset = "0xA19CBE0", VA = "0x18A19E1E0")]
		public JTGVBXJXUKE RSCOSKDWLNA(QKWJAEPJXFJ a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0xA19DEF0", Offset = "0xA19C8F0", VA = "0x18A19DEF0")]
		public WDKQISZFGMM NVHDNXFWTRY(QKWJAEPJXFJ a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0xA19E290", Offset = "0xA19CC90", VA = "0x18A19E290")]
		public AUPZMBXNNVA LNOSVCZGVHO(QKWJAEPJXFJ a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0xA19DFA0", Offset = "0xA19C9A0", VA = "0x18A19DFA0")]
		public SFUBMWIOJPU MLSXVGYXARG(QKWJAEPJXFJ a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0xA19DE40", Offset = "0xA19C840", VA = "0x18A19DE40")]
		public DEFVXXTFABQ BNRELTXPYTW(QKWJAEPJXFJ a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0xA19E340", Offset = "0xA19CD40", VA = "0x18A19E340", Slot = "19")]
		public QKWJAEPJXFJ PJQTIBFWLVK(RigidbodyEx a, RigidbodyExData b, WTGAJTVIDSE c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0xA19E950", Offset = "0xA19D350", VA = "0x18A19E950")]
		public QGVHVBKQBDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0xA19E1E0", Offset = "0xA19CBE0", VA = "0x18A19E1E0", Slot = "14")]
		private JTGVBXJXUKE JQDXXMEBIDI(QKWJAEPJXFJ a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0xA19DEF0", Offset = "0xA19C8F0", VA = "0x18A19DEF0", Slot = "15")]
		private WDKQISZFGMM ECZISDAEMDA(QKWJAEPJXFJ a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0xA19E290", Offset = "0xA19CC90", VA = "0x18A19E290", Slot = "16")]
		private AUPZMBXNNVA LXSPCGXISNO(QKWJAEPJXFJ a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0xA19DFA0", Offset = "0xA19C9A0", VA = "0x18A19DFA0", Slot = "17")]
		private SFUBMWIOJPU EWNWDXLKXXG(QKWJAEPJXFJ a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0xA19DE40", Offset = "0xA19C840", VA = "0x18A19DE40", Slot = "18")]
		private DEFVXXTFABQ RNAGIKXUHQA(QKWJAEPJXFJ a, [In] RigidbodyExData data)
		{
			return null;
		}
	}
}
namespace RecRoom.Rbex.Legacy
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public interface IPXNOUCJOTM : KQPQJPMVRGD, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void NGOTFISRHYR(QKWJAEPJXFJ a);

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void RRJPMVXSIIA(QKWJAEPJXFJ a);

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void ZFPHBQWNLKT(QKWJAEPJXFJ a);

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void ANZZLQSVHGS(QKWJAEPJXFJ a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public interface BJYZTUVTIPT : SYALCUWXMUM
	{
		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		ONFKYHGHNKV<QKWJAEPJXFJ> EWJMZMOOCJW
		{
			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		QKWJAEPJXFJ LTQQRNJTZPU
		{
			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public interface VSULDIQKCAJ : SFUBMWIOJPU
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		(float, Vector3) YAVQLBZJYEM(Rigidbody a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public interface BHVRXNOOSLT : WDKQISZFGMM, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		RRNetworkView JIOYDIGLBZD
		{
			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	internal sealed class EMIDDUVFDEU : GCBXFHPNZCL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private readonly MKMAZFGGDZY NQQONXMARGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private CollisionDetectionMode ITNELHVDNKQ;

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		private Rigidbody KMEPSQPZLEO
		{
			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0xA1913E0", Offset = "0xA18FDE0", VA = "0x18A1913E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		public CollisionDetectionMode SIREDEZKWKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0xA191430", Offset = "0xA18FE30", VA = "0x18A191430", Slot = "4")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0xA191540", Offset = "0xA18FF40", VA = "0x18A191540", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0xA190D40", Offset = "0xA18F740", VA = "0x18A190D40")]
		public EMIDDUVFDEU(QKWJAEPJXFJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0xA1912C0", Offset = "0xA18FCC0", VA = "0x18A1912C0", Slot = "6")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0xA1915B0", Offset = "0xA18FFB0", VA = "0x18A1915B0", Slot = "9")]
		public void IYRYYPMRALZ(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0xA1913D0", Offset = "0xA18FDD0", VA = "0x18A1913D0", Slot = "7")]
		public void CQZRIDOYWJU(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0xA1918B0", Offset = "0xA1902B0", VA = "0x18A1918B0", Slot = "8")]
		public void QTWSBDZCDBD(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0xA191750", Offset = "0xA190150", VA = "0x18A191750", Slot = "10")]
		public bool PFFLWBFLUIC(Vector3 a, [Out] RaycastHit b, float c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0xA191630", Offset = "0xA190030", VA = "0x18A191630")]
		private void NYPNWTVDBJQ(bool a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public sealed class MTJPBROBUCR : ROFMRUVTMAM, IDisposable, PCQSWXWWJPE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly MKMAZFGGDZY NQQONXMARGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private TransformTrackRate AMMFQAYOWEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private FSSDWGGYWWD QHDOIZBRVGF;

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		public TransformTrackRate GFFTZLQIGUZ
		{
			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0xA19AD60", Offset = "0xA199760", VA = "0x18A19AD60", Slot = "6")]
			get
			{
				return default(TransformTrackRate);
			}
			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0xA19ABE0", Offset = "0xA1995E0", VA = "0x18A19ABE0", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000092")]
		private Transform GHEPXDFLYPI
		{
			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0xA19AEA0", Offset = "0xA1998A0", VA = "0x18A19AEA0", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000020")]
		public event Action<UpdateLOD, UpdateLOD> QEPRBJTSLKC
		{
			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0xA19ACB0", Offset = "0xA1996B0", VA = "0x18A19ACB0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0xA19AAE0", Offset = "0xA1994E0", VA = "0x18A19AAE0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0xA19AEC0", Offset = "0xA1998C0", VA = "0x18A19AEC0")]
		public MTJPBROBUCR(QKWJAEPJXFJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0xA19A870", Offset = "0xA199270", VA = "0x18A19A870", Slot = "8")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0xA19AB90", Offset = "0xA199590", VA = "0x18A19AB90", Slot = "9")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x13DABD0", Offset = "0x13D95D0", VA = "0x1813DABD0", Slot = "11")]
		private void NGWOSJXYWHL(UpdateLOD a, UpdateLOD b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "12")]
		private void DDZCRRXSOKZ(bool a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class JYTYEONXEAL : INBKNOCKMEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0xA193290", Offset = "0xA191C90", VA = "0x18A193290", Slot = "4")]
		public KQPQJPMVRGD GARFAOFTKGR(QKWJAEPJXFJ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0xA193180", Offset = "0xA191B80", VA = "0x18A193180", Slot = "5")]
		public BWYMCIQBVZF FJFPXUIYYBX(QKWJAEPJXFJ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0xA193AC0", Offset = "0xA1924C0", VA = "0x18A193AC0", Slot = "6")]
		public SYALCUWXMUM ULVNEMALHVU(QKWJAEPJXFJ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0xA193940", Offset = "0xA192340", VA = "0x18A193940", Slot = "7")]
		public HEKBBSZZJLD RBMTWGRBSKX(QKWJAEPJXFJ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0xA193D60", Offset = "0xA192760", VA = "0x18A193D60", Slot = "8")]
		public FPZDPHQVNPJ WUENREYCJNH(QKWJAEPJXFJ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0xA192E60", Offset = "0xA191860", VA = "0x18A192E60", Slot = "9")]
		public ROFMRUVTMAM ACBYQMMUNCO(QKWJAEPJXFJ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0xA1939B0", Offset = "0xA1923B0", VA = "0x18A1939B0", Slot = "10")]
		public KDWLVJCYNQB SKXYSJCIIQX(QKWJAEPJXFJ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0xA193E20", Offset = "0xA192820", VA = "0x18A193E20", Slot = "11")]
		public CGVHWMHYFBN YTHOUHPXJYV(QKWJAEPJXFJ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0xA193BE0", Offset = "0xA1925E0", VA = "0x18A193BE0", Slot = "12")]
		public GCBXFHPNZCL VRVYGFPXIUV(QKWJAEPJXFJ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0xA193CA0", Offset = "0xA1926A0", VA = "0x18A193CA0", Slot = "13")]
		public ZFRELHXHUUG WQDDDVJOQIQ(QKWJAEPJXFJ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0xA193370", Offset = "0xA191D70", VA = "0x18A193370")]
		public JTGVBXJXUKE RSCOSKDWLNA(QKWJAEPJXFJ a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0xA1935B0", Offset = "0xA191FB0", VA = "0x18A1935B0")]
		public WDKQISZFGMM NVHDNXFWTRY(QKWJAEPJXFJ a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0xA193490", Offset = "0xA191E90", VA = "0x18A193490")]
		public AUPZMBXNNVA LNOSVCZGVHO(QKWJAEPJXFJ a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0xA193000", Offset = "0xA191A00", VA = "0x18A193000")]
		public SFUBMWIOJPU MLSXVGYXARG(QKWJAEPJXFJ a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0xA192F20", Offset = "0xA191920", VA = "0x18A192F20")]
		public DEFVXXTFABQ BNRELTXPYTW(QKWJAEPJXFJ a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0xA193800", Offset = "0xA192200", VA = "0x18A193800", Slot = "19")]
		public QKWJAEPJXFJ PJQTIBFWLVK(RigidbodyEx a, RigidbodyExData b, WTGAJTVIDSE c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public JYTYEONXEAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0xA193370", Offset = "0xA191D70", VA = "0x18A193370", Slot = "14")]
		private JTGVBXJXUKE JQDXXMEBIDI(QKWJAEPJXFJ a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0xA192FF0", Offset = "0xA1919F0", VA = "0x18A192FF0", Slot = "15")]
		private WDKQISZFGMM ECZISDAEMDA(QKWJAEPJXFJ a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0xA193490", Offset = "0xA191E90", VA = "0x18A193490", Slot = "16")]
		private AUPZMBXNNVA LXSPCGXISNO(QKWJAEPJXFJ a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0xA193000", Offset = "0xA191A00", VA = "0x18A193000", Slot = "17")]
		private SFUBMWIOJPU EWNWDXLKXXG(QKWJAEPJXFJ a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0xA192F20", Offset = "0xA191920", VA = "0x18A192F20", Slot = "18")]
		private DEFVXXTFABQ RNAGIKXUHQA(QKWJAEPJXFJ a, [In] RigidbodyExData data)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal sealed class IAPPVXYCYOW : CGVHWMHYFBN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private readonly MKMAZFGGDZY NQQONXMARGH;

		[Cpp2IlInjected.Token(Token = "0x17000093")]
		private Rigidbody KMEPSQPZLEO
		{
			[Cpp2IlInjected.Token(Token = "0x6000268")]
			[Cpp2IlInjected.Address(RVA = "0xA1913E0", Offset = "0xA18FDE0", VA = "0x18A1913E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000094")]
		private bool WIEPRSEIEDR
		{
			[Cpp2IlInjected.Token(Token = "0x6000269")]
			[Cpp2IlInjected.Address(RVA = "0xA192E10", Offset = "0xA191810", VA = "0x18A192E10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000095")]
		private bool IOAXHOBNRTU
		{
			[Cpp2IlInjected.Token(Token = "0x600026A")]
			[Cpp2IlInjected.Address(RVA = "0xA192B50", Offset = "0xA191550", VA = "0x18A192B50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000096")]
		private QKWJAEPJXFJ ZGGEFGSKGHA
		{
			[Cpp2IlInjected.Token(Token = "0x600026B")]
			[Cpp2IlInjected.Address(RVA = "0xA1925D0", Offset = "0xA190FD0", VA = "0x18A1925D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0xA190D40", Offset = "0xA18F740", VA = "0x18A190D40")]
		public IAPPVXYCYOW(QKWJAEPJXFJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0xA1929F0", Offset = "0xA1913F0", VA = "0x18A1929F0", Slot = "4")]
		public void KTREOAGVOHW(Vector3 a, ForceMode b = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0xA192BB0", Offset = "0xA1915B0", VA = "0x18A192BB0")]
		private void SBEKSFWSBGH(Vector3 a, ForceMode b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0xA1920F0", Offset = "0xA190AF0", VA = "0x18A1920F0", Slot = "5")]
		public void BOOZXAYPSJE(Vector3 a, Vector3 b, ForceMode c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0xA192630", Offset = "0xA191030", VA = "0x18A192630", Slot = "6")]
		public void IDIAHPYOYJB(Vector3 a, ForceMode b = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0xA192370", Offset = "0xA190D70", VA = "0x18A192370")]
		private void CHHODYKWAHE(Vector3 a, ForceMode b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0xA192790", Offset = "0xA191190", VA = "0x18A192790", Slot = "7")]
		public void JWDQHJPXVXR(Vector3 a, ForceMode b = ForceMode.Force)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	internal sealed class BMFKZLLBDXV : ZFRELHXHUUG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private readonly MKMAZFGGDZY NQQONXMARGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private bool OVVNPCWOXPH;

		[Cpp2IlInjected.Token(Token = "0x17000097")]
		public bool BTFRLVKSEKV
		{
			[Cpp2IlInjected.Token(Token = "0x6000274")]
			[Cpp2IlInjected.Address(RVA = "0xEC57F0", Offset = "0xEC41F0", VA = "0x180EC57F0", Slot = "4")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000275")]
			[Cpp2IlInjected.Address(RVA = "0xA190C30", Offset = "0xA18F630", VA = "0x18A190C30", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0xA190D40", Offset = "0xA18F740", VA = "0x18A190D40")]
		public BMFKZLLBDXV(QKWJAEPJXFJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0xA190B90", Offset = "0xA18F590", VA = "0x18A190B90", Slot = "6")]
		public void IYRYYPMRALZ(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0xA190BC0", Offset = "0xA18F5C0", VA = "0x18A190BC0", Slot = "7")]
		public void JFBEYVNGVYM(Rigidbody a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	internal sealed class RbexHierarchy : IPXNOUCJOTM, KQPQJPMVRGD, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private readonly QKWJAEPJXFJ NQQONXMARGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private readonly List<QKWJAEPJXFJ> LHNFSOVXMMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private QKWJAEPJXFJ VQTHZPRYINY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private QKWJAEPJXFJ CVRJANTESXQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private Transform RPVFREMPUAV;

		[Cpp2IlInjected.Token(Token = "0x17000098")]
		private Transform MFKEVDSZYGC
		{
			[Cpp2IlInjected.Token(Token = "0x600028A")]
			[Cpp2IlInjected.Address(RVA = "0xA1A2050", Offset = "0xA1A0A50", VA = "0x18A1A2050")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000099")]
		public QKWJAEPJXFJ ZGGEFGSKGHA
		{
			[Cpp2IlInjected.Token(Token = "0x600028D")]
			[Cpp2IlInjected.Address(RVA = "0xD14190", Offset = "0xD12B90", VA = "0x180D14190", Slot = "28")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600028E")]
			[Cpp2IlInjected.Address(RVA = "0xA1A2530", Offset = "0xA1A0F30", VA = "0x18A1A2530", Slot = "29")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009A")]
		public QKWJAEPJXFJ DVPPDBTFFRU
		{
			[Cpp2IlInjected.Token(Token = "0x600028F")]
			[Cpp2IlInjected.Address(RVA = "0xD14200", Offset = "0xD12C00", VA = "0x180D14200", Slot = "27")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		public IReadOnlyList<QKWJAEPJXFJ> WOLRRISLOBQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000290")]
			[Cpp2IlInjected.Address(RVA = "0xD14490", Offset = "0xD12E90", VA = "0x180D14490", Slot = "26")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000021")]
		public event RbexAction RIOECHADEBU
		{
			[Cpp2IlInjected.Token(Token = "0x6000278")]
			[Cpp2IlInjected.Address(RVA = "0xA1A21F0", Offset = "0xA1A0BF0", VA = "0x18A1A21F0", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000279")]
			[Cpp2IlInjected.Address(RVA = "0xA1A3550", Offset = "0xA1A1F50", VA = "0x18A1A3550", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000022")]
		public event RbexAction QPDMSZBDOFG
		{
			[Cpp2IlInjected.Token(Token = "0x600027A")]
			[Cpp2IlInjected.Address(RVA = "0xA1A1F00", Offset = "0xA1A0900", VA = "0x18A1A1F00", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600027B")]
			[Cpp2IlInjected.Address(RVA = "0xA1A23E0", Offset = "0xA1A0DE0", VA = "0x18A1A23E0", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000023")]
		public event RbexParentChangeAction ZAMSAZCDZGS
		{
			[Cpp2IlInjected.Token(Token = "0x600027C")]
			[Cpp2IlInjected.Address(RVA = "0xA1A2290", Offset = "0xA1A0C90", VA = "0x18A1A2290", Slot = "12")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600027D")]
			[Cpp2IlInjected.Address(RVA = "0xA1A2AD0", Offset = "0xA1A14D0", VA = "0x18A1A2AD0", Slot = "13")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000024")]
		public event Action GEDTHQFLUJB
		{
			[Cpp2IlInjected.Token(Token = "0x600027E")]
			[Cpp2IlInjected.Address(RVA = "0xA1A25F0", Offset = "0xA1A0FF0", VA = "0x18A1A25F0", Slot = "14")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600027F")]
			[Cpp2IlInjected.Address(RVA = "0xA1A36A0", Offset = "0xA1A20A0", VA = "0x18A1A36A0", Slot = "15")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000025")]
		public event Action SCRRYZSCRMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000280")]
			[Cpp2IlInjected.Address(RVA = "0xA1A2150", Offset = "0xA1A0B50", VA = "0x18A1A2150", Slot = "16")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000281")]
			[Cpp2IlInjected.Address(RVA = "0xA1A2900", Offset = "0xA1A1300", VA = "0x18A1A2900", Slot = "17")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000026")]
		public event Action<QKWJAEPJXFJ> VKJLNVMCROR
		{
			[Cpp2IlInjected.Token(Token = "0x6000282")]
			[Cpp2IlInjected.Address(RVA = "0xA1A2540", Offset = "0xA1A0F40", VA = "0x18A1A2540", Slot = "18")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000283")]
			[Cpp2IlInjected.Address(RVA = "0xA1A1FA0", Offset = "0xA1A09A0", VA = "0x18A1A1FA0", Slot = "19")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000027")]
		public event Action<QKWJAEPJXFJ> ZAKVBBXPMOW
		{
			[Cpp2IlInjected.Token(Token = "0x6000284")]
			[Cpp2IlInjected.Address(RVA = "0xA1A2330", Offset = "0xA1A0D30", VA = "0x18A1A2330", Slot = "20")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000285")]
			[Cpp2IlInjected.Address(RVA = "0xA1A2480", Offset = "0xA1A0E80", VA = "0x18A1A2480", Slot = "21")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000028")]
		public event Action QUUUECEJQPP
		{
			[Cpp2IlInjected.Token(Token = "0x6000286")]
			[Cpp2IlInjected.Address(RVA = "0xA1A1BE0", Offset = "0xA1A05E0", VA = "0x18A1A1BE0", Slot = "22")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000287")]
			[Cpp2IlInjected.Address(RVA = "0xA1A34B0", Offset = "0xA1A1EB0", VA = "0x18A1A34B0", Slot = "23")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000029")]
		public event Action<QKWJAEPJXFJ> AIGWOIDCYSK
		{
			[Cpp2IlInjected.Token(Token = "0x6000288")]
			[Cpp2IlInjected.Address(RVA = "0xA1A35F0", Offset = "0xA1A1FF0", VA = "0x18A1A35F0", Slot = "24")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000289")]
			[Cpp2IlInjected.Address(RVA = "0xA1A2D30", Offset = "0xA1A1730", VA = "0x18A1A2D30", Slot = "25")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0xA1A39B0", Offset = "0xA1A23B0", VA = "0x18A1A39B0")]
		public RbexHierarchy(QKWJAEPJXFJ rbex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0xA1A20B0", Offset = "0xA1A0AB0", VA = "0x18A1A20B0", Slot = "31")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0xA1A2EA0", Offset = "0xA1A18A0", VA = "0x18A1A2EA0", Slot = "30")]
		public void SetParent(QKWJAEPJXFJ newParent, bool isPhysicallyDetachedOnly = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0xA1A3740", Offset = "0xA1A2140", VA = "0x18A1A3740", Slot = "6")]
		public void ZFPHBQWNLKT(QKWJAEPJXFJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0xA1A1C80", Offset = "0xA1A0680", VA = "0x18A1A1C80", Slot = "7")]
		public void ANZZLQSVHGS(QKWJAEPJXFJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0xA1A2690", Offset = "0xA1A1090", VA = "0x18A1A2690", Slot = "4")]
		public void NGOTFISRHYR(QKWJAEPJXFJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0xA1A2C90", Offset = "0xA1A1690", VA = "0x18A1A2C90", Slot = "5")]
		public void RRJPMVXSIIA(QKWJAEPJXFJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0xA1A3410", Offset = "0xA1A1E10", VA = "0x18A1A3410")]
		private void UNPGWBJDNLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0xA1A28C0", Offset = "0xA1A12C0", VA = "0x18A1A28C0")]
		private void PNFOXURKEEK(QKWJAEPJXFJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0xA1A2780", Offset = "0xA1A1180", VA = "0x18A1A2780")]
		private void NWWIMIMRLJZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0xA1A29A0", Offset = "0xA1A13A0", VA = "0x18A1A29A0")]
		private void PTIPFZADVMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0xA1A2B70", Offset = "0xA1A1570", VA = "0x18A1A2B70")]
		private void REMAVUSYMJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0xA1A2DE0", Offset = "0xA1A17E0", VA = "0x18A1A2DE0")]
		[CompilerGenerated]
		private object SUPCNOVSVJE()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	internal static class RAYUBUVUCLC
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0xA19E9F0", Offset = "0xA19D3F0", VA = "0x18A19E9F0")]
		public static IPXNOUCJOTM MTCGLBYSVBD(this QKWJAEPJXFJ a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	internal sealed class WIKFDFEDHPX : BJYZTUVTIPT, SYALCUWXMUM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly MKMAZFGGDZY NQQONXMARGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private readonly ONFKYHGHNKV<QKWJAEPJXFJ> MQVJRNTMGJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private bool NRYUHYHFTIF;

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		public ONFKYHGHNKV<QKWJAEPJXFJ> EWJMZMOOCJW
		{
			[Cpp2IlInjected.Token(Token = "0x600029D")]
			[Cpp2IlInjected.Address(RVA = "0xD11BC0", Offset = "0xD105C0", VA = "0x180D11BC0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		public Vector3 BDTEOBHQHVB
		{
			[Cpp2IlInjected.Token(Token = "0x600029E")]
			[Cpp2IlInjected.Address(RVA = "0xA1AA550", Offset = "0xA1A8F50", VA = "0x18A1AA550", Slot = "6")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		public Vector3 XQSIVSCDJBH
		{
			[Cpp2IlInjected.Token(Token = "0x600029F")]
			[Cpp2IlInjected.Address(RVA = "0xA1AAAE0", Offset = "0xA1A94E0", VA = "0x18A1AAAE0", Slot = "7")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		private Vector3 BSEASMQNRBD
		{
			[Cpp2IlInjected.Token(Token = "0x60002A3")]
			[Cpp2IlInjected.Address(RVA = "0xA1AA990", Offset = "0xA1A9390", VA = "0x18A1AA990")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		public QKWJAEPJXFJ LTQQRNJTZPU
		{
			[Cpp2IlInjected.Token(Token = "0x60002A4")]
			[Cpp2IlInjected.Address(RVA = "0xA1AB040", Offset = "0xA1A9A40", VA = "0x18A1AB040", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0xA1AB0F0", Offset = "0xA1A9AF0", VA = "0x18A1AB0F0")]
		public WIKFDFEDHPX(QKWJAEPJXFJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0xA1AA920", Offset = "0xA1A9320", VA = "0x18A1AA920", Slot = "8")]
		public void MQDLJSQKLLT(QKWJAEPJXFJ a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0xA1AAA80", Offset = "0xA1A9480", VA = "0x18A1AAA80", Slot = "9")]
		public void VLFIMCXGFYG(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0xA1AA580", Offset = "0xA1A8F80", VA = "0x18A1AA580")]
		private Vector3 FQTRYGCZCAT()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0xA1AACA0", Offset = "0xA1A96A0", VA = "0x18A1AACA0")]
		private void YAVLAXMGBJK(QKWJAEPJXFJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	internal static class XVCGTGNFKHB
	{
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0xA1ABA80", Offset = "0xA1AA480", VA = "0x18A1ABA80")]
		public static BJYZTUVTIPT DCCDCDHWGXI(this QKWJAEPJXFJ a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	internal sealed class MVMNHEUCYTT : VSULDIQKCAJ, SFUBMWIOJPU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private readonly MKMAZFGGDZY NQQONXMARGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private readonly OverridableVector3 SIIVLNKYHKY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private readonly OverridableVector3 MTNAOYJXIKV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private float HCZMOJFDWLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private float VOCTFMWQBWW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private Vector3 QHNDMMBKOQZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private Vector3? ZXCAOATCGMR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private Quaternion? HAHIZNJNUHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private bool TJSTYYYHVIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private bool KEJWJYDWNCX;

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		public Vector3 DUIHMTFFOYR
		{
			[Cpp2IlInjected.Token(Token = "0x60002AA")]
			[Cpp2IlInjected.Address(RVA = "0x1EFAD00", Offset = "0x1EF9700", VA = "0x181EFAD00", Slot = "7")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60002AB")]
			[Cpp2IlInjected.Address(RVA = "0xA19B590", Offset = "0xA199F90", VA = "0x18A19B590", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		public Vector3 POMTXSZUWFA
		{
			[Cpp2IlInjected.Token(Token = "0x60002AC")]
			[Cpp2IlInjected.Address(RVA = "0xA19B280", Offset = "0xA199C80", VA = "0x18A19B280", Slot = "9")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		public float ZIHXXYDPYDA
		{
			[Cpp2IlInjected.Token(Token = "0x60002AD")]
			[Cpp2IlInjected.Address(RVA = "0xD63810", Offset = "0xD62210", VA = "0x180D63810", Slot = "10")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60002AE")]
			[Cpp2IlInjected.Address(RVA = "0xA19B0D0", Offset = "0xA199AD0", VA = "0x18A19B0D0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A4")]
		public float IPYMSUOTIZH
		{
			[Cpp2IlInjected.Token(Token = "0x60002AF")]
			[Cpp2IlInjected.Address(RVA = "0xD63820", Offset = "0xD62220", VA = "0x180D63820", Slot = "11")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60002B0")]
			[Cpp2IlInjected.Address(RVA = "0xA19B640", Offset = "0xA19A040", VA = "0x18A19B640", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		public Vector3 CGZXOJJXFHP
		{
			[Cpp2IlInjected.Token(Token = "0x60002B1")]
			[Cpp2IlInjected.Address(RVA = "0xA19B6F0", Offset = "0xA19A0F0", VA = "0x18A19B6F0", Slot = "13")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A6")]
		public Quaternion IAVTIVKEGGP
		{
			[Cpp2IlInjected.Token(Token = "0x60002B2")]
			[Cpp2IlInjected.Address(RVA = "0xA19AF50", Offset = "0xA199950", VA = "0x18A19AF50", Slot = "14")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A7")]
		private Rigidbody KMEPSQPZLEO
		{
			[Cpp2IlInjected.Token(Token = "0x60002BA")]
			[Cpp2IlInjected.Address(RVA = "0xA19B3A0", Offset = "0xA199DA0", VA = "0x18A19B3A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400002A")]
		public event RbexAction XADLZAIQNHW
		{
			[Cpp2IlInjected.Token(Token = "0x60002A8")]
			[Cpp2IlInjected.Address(RVA = "0xA19B880", Offset = "0xA19A280", VA = "0x18A19B880", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60002A9")]
			[Cpp2IlInjected.Address(RVA = "0xA19B1E0", Offset = "0xA199BE0", VA = "0x18A19B1E0", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0xA19D780", Offset = "0xA19C180", VA = "0x18A19D780")]
		public MVMNHEUCYTT(QKWJAEPJXFJ a, [In] RigidbodyExData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0xA19D540", Offset = "0xA19BF40", VA = "0x18A19D540", Slot = "17")]
		public void YUIIELZWBXR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0xA19C5F0", Offset = "0xA19AFF0", VA = "0x18A19C5F0", Slot = "16")]
		public void XUKBQAFHGYA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0xA19BAA0", Offset = "0xA19A4A0", VA = "0x18A19BAA0", Slot = "19")]
		public void IYRYYPMRALZ(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0xA19BB80", Offset = "0xA19A580", VA = "0x18A19BB80", Slot = "20")]
		public void JFBEYVNGVYM(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0xA19C220", Offset = "0xA19AC20", VA = "0x18A19C220", Slot = "18")]
		public void UTKOWJRKKDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0xA19BD60", Offset = "0xA19A760", VA = "0x18A19BD60", Slot = "21")]
		public void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0xA19B590", Offset = "0xA199F90", VA = "0x18A19B590")]
		private void TNAMYYSHZMV(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0xA19D660", Offset = "0xA19C060", VA = "0x18A19D660")]
		[Obsolete("This method is dangerous - the unity rigidbody is updated in a deferred manner and this world position may be stale")]
		private Vector3 ZUACSRPPGGK()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0xA19B0D0", Offset = "0xA199AD0", VA = "0x18A19B0D0")]
		private void HXJEJSBPRXM(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0xA19B640", Offset = "0xA19A040", VA = "0x18A19B640")]
		private void HHLAMFMBUNX(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0xA19B3F0", Offset = "0xA199DF0", VA = "0x18A19B3F0")]
		private Vector3 ENXJCISASYV()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0xA19C3C0", Offset = "0xA19ADC0", VA = "0x18A19C3C0", Slot = "15")]
		public void WVYCVGJYHKZ((Quaternion rot, Vector3 moments) tensor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0xA19B920", Offset = "0xA19A320", VA = "0x18A19B920")]
		private Quaternion ILEWDBTYERN()
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0xA19D470", Offset = "0xA19BE70", VA = "0x18A19D470")]
		public void YAVQLBZJYEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0xA19C6D0", Offset = "0xA19B0D0", VA = "0x18A19C6D0", Slot = "4")]
		public (float, Vector3) YAVQLBZJYEM(Rigidbody a)
		{
			return default((float, Vector3));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	internal static class FCPVIVFYQRN
	{
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0xA191930", Offset = "0xA190330", VA = "0x18A191930")]
		public static VSULDIQKCAJ JAGPUJGIXEY(this QKWJAEPJXFJ a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	internal sealed class FJQEFUFDNAD : AUPZMBXNNVA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private readonly MKMAZFGGDZY NQQONXMARGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private readonly HFGUPORPTXK DKBQBJYAMZY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private readonly RbexInterpolationMode RKGVOLRZYMP;

		[Cpp2IlInjected.Token(Token = "0x170000A8")]
		public bool MUXKBSKMCRJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002C5")]
			[Cpp2IlInjected.Address(RVA = "0x1B8D480", Offset = "0x1B8BE80", VA = "0x181B8D480", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A9")]
		public RbexInterpolationMode EPJXKROSIIV
		{
			[Cpp2IlInjected.Token(Token = "0x60002C6")]
			[Cpp2IlInjected.Address(RVA = "0xD224F0", Offset = "0xD20EF0", VA = "0x180D224F0", Slot = "11")]
			get
			{
				return default(RbexInterpolationMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0xA192000", Offset = "0xA190A00", VA = "0x18A192000")]
		public FJQEFUFDNAD(QKWJAEPJXFJ a, [In] RigidbodyExData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0xA1919F0", Offset = "0xA1903F0", VA = "0x18A1919F0", Slot = "4")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0xA191C80", Offset = "0xA190680", VA = "0x18A191C80")]
		private bool RZOGLJTXKOD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0xA191AC0", Offset = "0xA1904C0", VA = "0x18A191AC0", Slot = "5")]
		public void CPZHSNZCBQB(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0xA191D20", Offset = "0xA190720", VA = "0x18A191D20", Slot = "6")]
		public void SVYAJRATTNW(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0xA191ED0", Offset = "0xA1908D0", VA = "0x18A191ED0", Slot = "9")]
		public void WSZVUNWPKOU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0xA191AF0", Offset = "0xA1904F0", VA = "0x18A191AF0")]
		private void DOSTBCPNRQL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0xA191D50", Offset = "0xA190750", VA = "0x18A191D50")]
		private void VIUVNHBFFZJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0xA191C00", Offset = "0xA190600", VA = "0x18A191C00", Slot = "8")]
		public void KGEEVAWOLTF(QKWJAEPJXFJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0xA191C40", Offset = "0xA190640", VA = "0x18A191C40", Slot = "7")]
		public void MURJSCUWTHC(QKWJAEPJXFJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	internal sealed class EGSVDAEFHGA : KDWLVJCYNQB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private readonly MKMAZFGGDZY NQQONXMARGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private readonly HFGUPORPTXK ZQHIFBNPFCB;

		[Cpp2IlInjected.Token(Token = "0x170000AA")]
		public bool WIEPRSEIEDR
		{
			[Cpp2IlInjected.Token(Token = "0x60002D3")]
			[Cpp2IlInjected.Address(RVA = "0xA191050", Offset = "0xA18FA50", VA = "0x18A191050", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400002B")]
		public event RbexAction YTYIHDDZFGV
		{
			[Cpp2IlInjected.Token(Token = "0x60002D1")]
			[Cpp2IlInjected.Address(RVA = "0xA191100", Offset = "0xA18FB00", VA = "0x18A191100", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60002D2")]
			[Cpp2IlInjected.Address(RVA = "0xA190DE0", Offset = "0xA18F7E0", VA = "0x18A190DE0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0xA1911E0", Offset = "0xA18FBE0", VA = "0x18A1911E0")]
		public EGSVDAEFHGA(QKWJAEPJXFJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0xA191040", Offset = "0xA18FA40", VA = "0x18A191040", Slot = "7")]
		public void XMSRXLHBREK(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0xA190DD0", Offset = "0xA18F7D0", VA = "0x18A190DD0", Slot = "8")]
		public void DFSIYEXFPXN(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0xA190F30", Offset = "0xA18F930", VA = "0x18A190F30", Slot = "9")]
		public void OBYZUVXNNRF(object a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0xA1911A0", Offset = "0xA18FBA0", VA = "0x18A1911A0", Slot = "12")]
		public void ZDWOXZWOHLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0xA190E80", Offset = "0xA18F880", VA = "0x18A190E80", Slot = "10")]
		public void IYRYYPMRALZ(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0xA190F00", Offset = "0xA18F900", VA = "0x18A190F00", Slot = "11")]
		public void JFBEYVNGVYM(Rigidbody a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	internal sealed class UHGYMWJCTGR : BHVRXNOOSLT, WDKQISZFGMM, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private WeakReference<QKWJAEPJXFJ> MXYCDSGSMXO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private readonly MKMAZFGGDZY NQQONXMARGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private RRNetworkView RQVXVLRYGGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private bool WIGVJAAQGOE;

		[Cpp2IlInjected.Token(Token = "0x170000AB")]
		public RRNetworkView JIOYDIGLBZD
		{
			[Cpp2IlInjected.Token(Token = "0x60002DD")]
			[Cpp2IlInjected.Address(RVA = "0xD11C00", Offset = "0xD10600", VA = "0x180D11C00", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AC")]
		public bool JFPDTLGEIDE
		{
			[Cpp2IlInjected.Token(Token = "0x60002DE")]
			[Cpp2IlInjected.Address(RVA = "0xA1A9840", Offset = "0xA1A8240", VA = "0x18A1A9840", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AD")]
		public bool WBPMVWTIPDO
		{
			[Cpp2IlInjected.Token(Token = "0x60002DF")]
			[Cpp2IlInjected.Address(RVA = "0xD6FAC0", Offset = "0xD6E4C0", VA = "0x180D6FAC0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400002C")]
		public event RbexAction YNKWLCSROWV
		{
			[Cpp2IlInjected.Token(Token = "0x60002DB")]
			[Cpp2IlInjected.Address(RVA = "0xA1AA270", Offset = "0xA1A8C70", VA = "0x18A1AA270", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60002DC")]
			[Cpp2IlInjected.Address(RVA = "0xA1AA310", Offset = "0xA1A8D10", VA = "0x18A1AA310", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0xA1AA3B0", Offset = "0xA1A8DB0", VA = "0x18A1AA3B0")]
		public UHGYMWJCTGR(QKWJAEPJXFJ a, [In] RigidbodyExData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0xA1A95C0", Offset = "0xA1A7FC0", VA = "0x18A1A95C0", Slot = "9")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0xA1A9850", Offset = "0xA1A8250", VA = "0x18A1A9850", Slot = "12")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0xA1A9B80", Offset = "0xA1A8580", VA = "0x18A1A9B80", Slot = "10")]
		public void PEQIISHSXLY(QKWJAEPJXFJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0xA1A9D10", Offset = "0xA1A8710", VA = "0x18A1A9D10", Slot = "11")]
		public void PRUTBBSDRCC(QKWJAEPJXFJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0xA1A9E90", Offset = "0xA1A8890", VA = "0x18A1A9E90")]
		private void TLAWLPPQLZU(RRNetworkView a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0xA1A96F0", Offset = "0xA1A80F0", VA = "0x18A1A96F0")]
		private void BGRTDMBSNNA(YHDDZOLJMSB a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0xA1AA000", Offset = "0xA1A8A00", VA = "0x18A1AA000")]
		private void UJSSTRFOFTF(RRNetworkView a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	internal static class NKOMQZSWAGD
	{
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0xA19D8E0", Offset = "0xA19C2E0", VA = "0x18A19D8E0")]
		public static BHVRXNOOSLT Lifecycle(this QKWJAEPJXFJ impl)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	internal sealed class OISYYHURZLP : DEFVXXTFABQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private readonly MKMAZFGGDZY NQQONXMARGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private RigidbodyConstraints YAUDRAATSRI;

		[Cpp2IlInjected.Token(Token = "0x170000AE")]
		public bool THYSDCYKPXT
		{
			[Cpp2IlInjected.Token(Token = "0x60002E9")]
			[Cpp2IlInjected.Address(RVA = "0xEAF1A0", Offset = "0xEADBA0", VA = "0x180EAF1A0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002EA")]
			[Cpp2IlInjected.Address(RVA = "0xEDB700", Offset = "0xEDA100", VA = "0x180EDB700", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AF")]
		public bool LATURWQMQEM
		{
			[Cpp2IlInjected.Token(Token = "0x60002EB")]
			[Cpp2IlInjected.Address(RVA = "0xEDB340", Offset = "0xED9D40", VA = "0x180EDB340", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002EC")]
			[Cpp2IlInjected.Address(RVA = "0xEDB8B0", Offset = "0xEDA2B0", VA = "0x180EDB8B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B0")]
		public RigidbodyConstraints EZNDFAZTSZI
		{
			[Cpp2IlInjected.Token(Token = "0x60002ED")]
			[Cpp2IlInjected.Address(RVA = "0xD1B420", Offset = "0xD19E20", VA = "0x180D1B420", Slot = "7")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x60002EE")]
			[Cpp2IlInjected.Address(RVA = "0xA19DA00", Offset = "0xA19C400", VA = "0x18A19DA00", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0xA19DB30", Offset = "0xA19C530", VA = "0x18A19DB30")]
		public OISYYHURZLP(QKWJAEPJXFJ a, [In] RigidbodyExData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0xA19D9A0", Offset = "0xA19C3A0", VA = "0x18A19D9A0", Slot = "9")]
		public void IYRYYPMRALZ(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0xA19D9D0", Offset = "0xA19C3D0", VA = "0x18A19D9D0", Slot = "10")]
		public void JFBEYVNGVYM(Rigidbody a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	internal sealed class SUSCHTQWBAS : HEKBBSZZJLD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private readonly QKWJAEPJXFJ NQQONXMARGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private float LFQGISAEXBS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private float KDPXDMPKSVU;

		[Cpp2IlInjected.Token(Token = "0x170000B1")]
		public float ZUXDFOHQRDG
		{
			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0xD68720", Offset = "0xD67120", VA = "0x180D68720", Slot = "4")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60002F4")]
			[Cpp2IlInjected.Address(RVA = "0xA1A93E0", Offset = "0xA1A7DE0", VA = "0x18A1A93E0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B2")]
		public float MFCIQCJBTJQ
		{
			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0xD68AF0", Offset = "0xD674F0", VA = "0x180D68AF0", Slot = "6")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60002F6")]
			[Cpp2IlInjected.Address(RVA = "0xA1A94B0", Offset = "0xA1A7EB0", VA = "0x18A1A94B0", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0xA1A9580", Offset = "0xA1A7F80", VA = "0x18A1A9580")]
		public SUSCHTQWBAS(QKWJAEPJXFJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0xA1A92F0", Offset = "0xA1A7CF0", VA = "0x18A1A92F0", Slot = "8")]
		public void IYRYYPMRALZ(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0xA1A9340", Offset = "0xA1A7D40", VA = "0x18A1A9340", Slot = "9")]
		public void JFBEYVNGVYM(Rigidbody a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	internal sealed class YIOGFYXSEMC : FPZDPHQVNPJ
	{
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private static readonly Log OZXGQWELGPR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private readonly MKMAZFGGDZY NQQONXMARGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private bool DVTLUAGSOEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private bool PXKNQOPEGYE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private int SZMTSLFSWRC;

		[Cpp2IlInjected.Token(Token = "0x170000B3")]
		private Rigidbody KMEPSQPZLEO
		{
			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0xA19B3A0", Offset = "0xA199DA0", VA = "0x18A19B3A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B4")]
		private bool RVCHMUJRDDD
		{
			[Cpp2IlInjected.Token(Token = "0x60002FC")]
			[Cpp2IlInjected.Address(RVA = "0xA1ABB40", Offset = "0xA1AA540", VA = "0x18A1ABB40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B5")]
		private QKWJAEPJXFJ ZGGEFGSKGHA
		{
			[Cpp2IlInjected.Token(Token = "0x60002FD")]
			[Cpp2IlInjected.Address(RVA = "0xA1ABCE0", Offset = "0xA1AA6E0", VA = "0x18A1ABCE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B6")]
		private bool IOAXHOBNRTU
		{
			[Cpp2IlInjected.Token(Token = "0x60002FE")]
			[Cpp2IlInjected.Address(RVA = "0xA1AC030", Offset = "0xA1AAA30", VA = "0x18A1AC030")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400002D")]
		public event RbexAction OGOAFEVMMDB
		{
			[Cpp2IlInjected.Token(Token = "0x60002F9")]
			[Cpp2IlInjected.Address(RVA = "0xA1AC130", Offset = "0xA1AAB30", VA = "0x18A1AC130", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0xA1AC090", Offset = "0xA1AAA90", VA = "0x18A1AC090", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0xA1AC740", Offset = "0xA1AB140", VA = "0x18A1AC740")]
		public YIOGFYXSEMC(QKWJAEPJXFJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0xA1ABB60", Offset = "0xA1AA560", VA = "0x18A1ABB60", Slot = "6")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0xA1AC020", Offset = "0xA1AAA20", VA = "0x18A1AC020", Slot = "8")]
		public void LXBLLQZOIXT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0xA1AC560", Offset = "0xA1AAF60", VA = "0x18A1AC560", Slot = "7")]
		public bool VDZGZJQHPNV()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0xA1AC490", Offset = "0xA1AAE90", VA = "0x18A1AC490", Slot = "9")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0xA1ABF80", Offset = "0xA1AA980", VA = "0x18A1ABF80", Slot = "13")]
		public void JLBTRDRXNMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0xA1AC360", Offset = "0xA1AAD60", VA = "0x18A1AC360", Slot = "12")]
		public void RXQANEFISYS(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0xA1ABD40", Offset = "0xA1AA740", VA = "0x18A1ABD40", Slot = "10")]
		public bool DYNFUJBWTKR()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0xA1ABBF0", Offset = "0xA1AA5F0", VA = "0x18A1ABBF0", Slot = "11")]
		public bool BIBIFEYVLAA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0xA1ABDB0", Offset = "0xA1AA7B0", VA = "0x18A1ABDB0")]
		private bool FYDJGFAYYSW()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0xA1AC1D0", Offset = "0xA1AABD0", VA = "0x18A1AC1D0")]
		private void RIZLVLYFSUM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	internal sealed class XFHOOFGWQFF : JTGVBXJXUKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private readonly MKMAZFGGDZY NQQONXMARGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private readonly HFGUPORPTXK VNAEFNZVWYH;

		[Cpp2IlInjected.Token(Token = "0x170000B7")]
		public Rigidbody KMEPSQPZLEO
		{
			[Cpp2IlInjected.Token(Token = "0x600030B")]
			[Cpp2IlInjected.Address(RVA = "0xD11BE0", Offset = "0xD105E0", VA = "0x180D11BE0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600030C")]
			[Cpp2IlInjected.Address(RVA = "0xD11C10", Offset = "0xD10610", VA = "0x180D11C10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B8")]
		private bool IOAXHOBNRTU
		{
			[Cpp2IlInjected.Token(Token = "0x600030D")]
			[Cpp2IlInjected.Address(RVA = "0xA192B50", Offset = "0xA191550", VA = "0x18A192B50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B9")]
		public bool RCIIHNLDPHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000310")]
			[Cpp2IlInjected.Address(RVA = "0x1B8D480", Offset = "0x1B8BE80", VA = "0x181B8D480", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0xA1AB980", Offset = "0xA1AA380", VA = "0x18A1AB980")]
		public XFHOOFGWQFF(QKWJAEPJXFJ a, [In] RigidbodyExData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0xA1AB1E0", Offset = "0xA1A9BE0", VA = "0x18A1AB1E0", Slot = "5")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0xA1AB7A0", Offset = "0xA1AA1A0", VA = "0x18A1AB7A0", Slot = "7")]
		public void HLCGERXTVMF(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0xA1AB7D0", Offset = "0xA1AA1D0", VA = "0x18A1AB7D0", Slot = "8")]
		public void MNEOWEODBQM(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0xA1AB470", Offset = "0xA1A9E70", VA = "0x18A1AB470", Slot = "9")]
		public void GGORYLAPXKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0xA1AB280", Offset = "0xA1A9C80", VA = "0x18A1AB280", Slot = "10")]
		public void DKETFIFUKRE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0xA1AB800", Offset = "0xA1AA200", VA = "0x18A1AB800", Slot = "11")]
		public void RXUOHUBUMGN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	internal sealed class RRKQLBSELAU : BWYMCIQBVZF, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private readonly MKMAZFGGDZY NQQONXMARGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private readonly HFGUPORPTXK QZZHIWCOSSQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private float BNBDVRBSPZH;

		[Cpp2IlInjected.Token(Token = "0x170000BA")]
		public WVUHOKYUTXN YVBJYEAPPZW
		{
			[Cpp2IlInjected.Token(Token = "0x6000316")]
			[Cpp2IlInjected.Address(RVA = "0xD11C00", Offset = "0xD10600", VA = "0x180D11C00", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000317")]
			[Cpp2IlInjected.Address(RVA = "0xD12070", Offset = "0xD10A70", VA = "0x180D12070", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		public RFDYMGDWISG YTBJYPKPQEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000318")]
			[Cpp2IlInjected.Address(RVA = "0xD12080", Offset = "0xD10A80", VA = "0x180D12080", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000319")]
			[Cpp2IlInjected.Address(RVA = "0xD11BA0", Offset = "0xD105A0", VA = "0x180D11BA0", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BC")]
		public Vector3 BSEASMQNRBD
		{
			[Cpp2IlInjected.Token(Token = "0x600031A")]
			[Cpp2IlInjected.Address(RVA = "0xA1A10F0", Offset = "0xA19FAF0", VA = "0x18A1A10F0", Slot = "8")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600031B")]
			[Cpp2IlInjected.Address(RVA = "0xA19F4E0", Offset = "0xA19DEE0", VA = "0x18A19F4E0", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BD")]
		public Vector3 KBQMLTAIZYO
		{
			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(RVA = "0xA1A0540", Offset = "0xA19EF40", VA = "0x18A1A0540", Slot = "10")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600031D")]
			[Cpp2IlInjected.Address(RVA = "0xA1A0CE0", Offset = "0xA19F6E0", VA = "0x18A1A0CE0", Slot = "11")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BE")]
		public Vector3 ZWTBMJSJWVZ
		{
			[Cpp2IlInjected.Token(Token = "0x600031E")]
			[Cpp2IlInjected.Address(RVA = "0xA19F060", Offset = "0xA19DA60", VA = "0x18A19F060", Slot = "12")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600031F")]
			[Cpp2IlInjected.Address(RVA = "0xA1A1240", Offset = "0xA19FC40", VA = "0x18A1A1240", Slot = "13")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BF")]
		public Vector3 KYNAXETQPDU
		{
			[Cpp2IlInjected.Token(Token = "0x6000320")]
			[Cpp2IlInjected.Address(RVA = "0xA19F270", Offset = "0xA19DC70", VA = "0x18A19F270", Slot = "14")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0xA19F4B0", Offset = "0xA19DEB0", VA = "0x18A19F4B0", Slot = "15")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C0")]
		public float ZWOPVWELUTX
		{
			[Cpp2IlInjected.Token(Token = "0x6000322")]
			[Cpp2IlInjected.Address(RVA = "0xD68AE0", Offset = "0xD674E0", VA = "0x180D68AE0", Slot = "16")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000323")]
			[Cpp2IlInjected.Address(RVA = "0xA19EF30", Offset = "0xA19D930", VA = "0x18A19EF30", Slot = "17")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C1")]
		public bool HWTSGYFCQVB
		{
			[Cpp2IlInjected.Token(Token = "0x6000324")]
			[Cpp2IlInjected.Address(RVA = "0x261DF80", Offset = "0x261C980", VA = "0x18261DF80", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C2")]
		private CGVHWMHYFBN KWWCZMFYSKZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000339")]
			[Cpp2IlInjected.Address(RVA = "0x96CD480", Offset = "0x96CBE80", VA = "0x1896CD480")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C3")]
		private bool RVCHMUJRDDD
		{
			[Cpp2IlInjected.Token(Token = "0x600033A")]
			[Cpp2IlInjected.Address(RVA = "0xA19F040", Offset = "0xA19DA40", VA = "0x18A19F040")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0xA1A1B00", Offset = "0xA1A0500", VA = "0x18A1A1B00")]
		public RRKQLBSELAU(QKWJAEPJXFJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0xA19F1C0", Offset = "0xA19DBC0", VA = "0x18A19F1C0", Slot = "19")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0xA19F720", Offset = "0xA19E120", VA = "0x18A19F720", Slot = "36")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0xA1A0330", Offset = "0xA19ED30", VA = "0x18A1A0330", Slot = "28")]
		public void IYRYYPMRALZ(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x1938F50", Offset = "0x1937950", VA = "0x181938F50", Slot = "20")]
		public void XCUQQQZMVDD(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x1936D50", Offset = "0x1935750", VA = "0x181936D50", Slot = "30")]
		public void PICBYTTZGKU(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0xA1A1300", Offset = "0xA19FD00", VA = "0x18A1A1300", Slot = "35")]
		public Vector3 USJKALWVPBH(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0xA19ED70", Offset = "0xA19D770", VA = "0x18A19ED70", Slot = "34")]
		public Vector3 AEKZRDAVLDB(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0xA19F1C0", Offset = "0xA19DBC0", VA = "0x18A19F1C0", Slot = "27")]
		public void JKWZYHQLLDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0xA19F5A0", Offset = "0xA19DFA0", VA = "0x18A19F5A0", Slot = "25")]
		public void CKJMBCDCSDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0xA19FC10", Offset = "0xA19E610", VA = "0x18A19FC10", Slot = "24")]
		public void HHDHKIABFEQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0xA1A0D10", Offset = "0xA19F710", VA = "0x18A1A0D10", Slot = "33")]
		public void PXQNGZKNRMQ(Vector3 a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0xA1A02D0", Offset = "0xA19ECD0", VA = "0x18A1A02D0", Slot = "32")]
		public void IUVRFJYBOSZ(Vector3 a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0xA19FA70", Offset = "0xA19E470", VA = "0x18A19FA70", Slot = "31")]
		public void GYKLGATERSQ(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0xA19FC70", Offset = "0xA19E670", VA = "0x18A19FC70", Slot = "22")]
		public void HYTLDATUSKC(RbexImpulseType a, Vector3 b, float c, float d = 8f, float e = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0xA1A0660", Offset = "0xA19F060", VA = "0x18A1A0660", Slot = "21")]
		public void NCXSGWPIUIL(RbexRotationType a, Vector3 b, float c = 1f / 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0xA1A08F0", Offset = "0xA19F2F0", VA = "0x18A1A08F0", Slot = "23")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void OSOWOPRZPTG(RbexRotationType a, Vector3 b, float c = 7f, float d = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x1A803D0", Offset = "0x1A7EDD0", VA = "0x181A803D0")]
		private static void AIQOXGATPBC(Vector3 a, Vector3 b, [Out] Vector3 c, [Out] Vector3 d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0xA1A0460", Offset = "0xA19EE60", VA = "0x18A1A0460", Slot = "29")]
		public Vector3 KBODHRPAEVT(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0xA1A1970", Offset = "0xA1A0370", VA = "0x18A1A1970", Slot = "26")]
		public void ZSMGXKTOFTW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0xA19EF30", Offset = "0xA19D930", VA = "0x18A19EF30")]
		private void WPAGDBRMKUV(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0xA1A0F50", Offset = "0xA19F950", VA = "0x18A1A0F50")]
		private void RNZJEARJBWZ(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0xA19F600", Offset = "0xA19E000", VA = "0x18A19F600")]
		private Vector3 CZLSXLLTUXY()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0xA19F780", Offset = "0xA19E180", VA = "0x18A19F780")]
		private void GTGRTOVRNEW(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0xA19F390", Offset = "0xA19DD90", VA = "0x18A19F390")]
		private Vector3 BHCJUIKKXCK()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0xA1A14E0", Offset = "0xA19FEE0", VA = "0x18A1A14E0")]
		private void ZGRLBVMTKCS(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150")]
		private void ZMGJOINMPEV(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150")]
		private void MYCKVUPUEWT()
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
