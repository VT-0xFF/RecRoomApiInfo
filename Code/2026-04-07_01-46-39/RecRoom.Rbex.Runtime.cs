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
		[Cpp2IlInjected.Address(RVA = "0xD1F100", Offset = "0xD1E100", VA = "0x180D1F100")]
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
		[Cpp2IlInjected.Address(RVA = "0xD1F390", Offset = "0xD1E390", VA = "0x180D1F390")]
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
		[Cpp2IlInjected.Address(RVA = "0xA187890", Offset = "0xA186890", VA = "0x18A187890", Slot = "4")]
		public override void OTSRDIPIITJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xD1F100", Offset = "0xD1E100", VA = "0x180D1F100")]
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
		private int[] DFSWPDPJVFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private ServiceBitset QBNLPBWZQQF;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xCF4360", Offset = "0xCF3360", VA = "0x180CF4360", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9B6C7F0", Offset = "0x9B6B7F0", VA = "0x189B6C7F0", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xA198FB0", Offset = "0xA197FB0", VA = "0x18A198FB0")]
		private void ROXZSJHBEXH(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xA199290", Offset = "0xA198290", VA = "0x18A199290", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xA1992F0", Offset = "0xA1982F0", VA = "0x18A1992F0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[DisallowMultipleComponent]
	public sealed class RigidbodyEx : MonoBehaviour, ZKNRSSQMNPD, AQNYQLPECPC, VRGZXMUEKSG
	{
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static readonly Log RDAITJQXAVG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private bool FXVOVLZMGDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private ILGARLMTLIL SPUCJVYZSLW;

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
		private Transform TIOYRJIMVEI;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal ILGARLMTLIL XQCTBFPOVUA
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xA193630", Offset = "0xA192630", VA = "0x18A193630")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private ILGARLMTLIL GWUTAUDSPAK
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xCF4360", Offset = "0xCF3360", VA = "0x180CF4360", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int FYSSYHOJLWD
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0xA195340", Offset = "0xA194340", VA = "0x18A195340")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RigidbodyEx SIAFIBGHDSE
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0xA1956A0", Offset = "0xA1946A0", VA = "0x18A1956A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx OTBMMIANHVU
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xA1955E0", Offset = "0xA1945E0", VA = "0x18A1955E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RigidbodyEx KPYZQONRQFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0xA1962A0", Offset = "0xA1952A0", VA = "0x18A1962A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xA1977A0", Offset = "0xA1967A0", VA = "0x18A1977A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool DidStart
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x9514710", Offset = "0x9513710", VA = "0x189514710", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x9514860", Offset = "0x9513860", VA = "0x189514860")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Transform HMYJRBLVWEO
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x25EFAE0", Offset = "0x25EEAE0", VA = "0x1825EFAE0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Transform EREBQLFDJPX
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x25EFAE0", Offset = "0x25EEAE0", VA = "0x1825EFAE0", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Transform BTUQNQNRAWN
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x25EFAE0", Offset = "0x25EEAE0", VA = "0x1825EFAE0", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public TransformTrackRate ICFISROOEQZ
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0xA1953A0", Offset = "0xA1943A0", VA = "0x18A1953A0")]
			get
			{
				return default(TransformTrackRate);
			}
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0xA196F50", Offset = "0xA195F50", VA = "0x18A196F50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool ACVKLIDTRQG
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0xA1959B0", Offset = "0xA1949B0", VA = "0x18A1959B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool MQPWBNLGCJW
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0xA1954C0", Offset = "0xA1944C0", VA = "0x18A1954C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public PMLHAPSUBFJ TZXRMFIXXWE
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0xA1958F0", Offset = "0xA1948F0", VA = "0x18A1958F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0xA197110", Offset = "0xA196110", VA = "0x18A197110")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public BEZDMGXLQFQ ZWHTJXACTAP
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0xA195890", Offset = "0xA194890", VA = "0x18A195890")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0xA1970A0", Offset = "0xA1960A0", VA = "0x18A1970A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool LEUQMXSJXOT
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xA1957E0", Offset = "0xA1947E0", VA = "0x18A1957E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Rigidbody QGAIQBZDQPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xA195840", Offset = "0xA194840", VA = "0x18A195840")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool NARFOTVPSDX
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xA195520", Offset = "0xA194520", VA = "0x18A195520")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xA196FC0", Offset = "0xA195FC0", VA = "0x18A196FC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool IVMAGWWSYDK
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x1A1D420", Offset = "0x1A1C420", VA = "0x181A1D420", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float VYAFBTREGZE
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xA196240", Offset = "0xA195240", VA = "0x18A196240")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float WRWGMGGIKJX
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xA1961E0", Offset = "0xA1951E0", VA = "0x18A1961E0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xA197730", Offset = "0xA196730", VA = "0x18A197730")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public float WKPKJJVEZZK
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xA195C10", Offset = "0xA194C10", VA = "0x18A195C10")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0xA1973B0", Offset = "0xA1963B0", VA = "0x18A1973B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public float JWSCKCYXHZA
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0xA195A10", Offset = "0xA194A10", VA = "0x18A195A10")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0xA197180", Offset = "0xA196180", VA = "0x18A197180")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public bool DSSBCFBCUIZ
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0xA1967F0", Offset = "0xA1957F0", VA = "0x18A1967F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0xA197CE0", Offset = "0xA196CE0", VA = "0x18A197CE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Vector3 ZSIQEQSGKHD
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xA195FC0", Offset = "0xA194FC0", VA = "0x18A195FC0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xA197500", Offset = "0xA196500", VA = "0x18A197500")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public Vector3 DMAZKEOSTLQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xA196930", Offset = "0xA195930", VA = "0x18A196930")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public CollisionDetectionMode EAEIJZUUPEC
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xA195B50", Offset = "0xA194B50", VA = "0x18A195B50")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xA1972D0", Offset = "0xA1962D0", VA = "0x18A1972D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public float CBLNIGZTQQF
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0xA195580", Offset = "0xA194580", VA = "0x18A195580")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xA197030", Offset = "0xA196030", VA = "0x18A197030")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public RigidbodyConstraints YYBRRIZIJWS
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xA195BB0", Offset = "0xA194BB0", VA = "0x18A195BB0")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xA197340", Offset = "0xA196340", VA = "0x18A197340")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public Vector3 ZHLSTTNWGZS
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0xA196360", Offset = "0xA195360", VA = "0x18A196360")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public Vector3 OJJFBNWGVCE
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0xA196360", Offset = "0xA195360", VA = "0x18A196360")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0xA197AC0", Offset = "0xA196AC0", VA = "0x18A197AC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public float JUUPWOBQSCP
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0xA1960A0", Offset = "0xA1950A0", VA = "0x18A1960A0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xA1975E0", Offset = "0xA1965E0", VA = "0x18A1975E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public float UBEJVXLOWVW
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xA196790", Offset = "0xA195790", VA = "0x18A196790")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xA197C70", Offset = "0xA196C70", VA = "0x18A197C70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Quaternion CZRKXGZINSR
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0xA196440", Offset = "0xA195440", VA = "0x18A196440")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xA197840", Offset = "0xA196840", VA = "0x18A197840")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Quaternion WUCQXEQEMOF
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xA1966C0", Offset = "0xA1956C0", VA = "0x18A1966C0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xA197BA0", Offset = "0xA196BA0", VA = "0x18A197BA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector3 PYRLFAPHWUR
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xA196510", Offset = "0xA195510", VA = "0x18A196510")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xA197910", Offset = "0xA196910", VA = "0x18A197910")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Quaternion RZBTCIIIKME
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xA1965F0", Offset = "0xA1955F0", VA = "0x18A1965F0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xA1979F0", Offset = "0xA1969F0", VA = "0x18A1979F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 CYGFHHFNFMZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0xA196850", Offset = "0xA195850", VA = "0x18A196850")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xA197D50", Offset = "0xA196D50", VA = "0x18A197D50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 IAOWMDAFBDI
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0xA196100", Offset = "0xA195100", VA = "0x18A196100")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xA197650", Offset = "0xA196650", VA = "0x18A197650")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector3 SIJCAEUHDBJ
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xA195A70", Offset = "0xA194A70", VA = "0x18A195A70")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0xA1971F0", Offset = "0xA1961F0", VA = "0x18A1971F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector3 UWUFNAAVSZU
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xA195EE0", Offset = "0xA194EE0", VA = "0x18A195EE0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xA197420", Offset = "0xA196420", VA = "0x18A197420")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector3 KSLYIJEFQZP
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xA195DA0", Offset = "0xA194DA0", VA = "0x18A195DA0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Quaternion FMLHZYXHKJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xA195CD0", Offset = "0xA194CD0", VA = "0x18A195CD0")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public Vector3 LYBTPCIWADR
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0xA196AF0", Offset = "0xA195AF0", VA = "0x18A196AF0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public Vector3 DTDDWARYDLD
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0xA196A10", Offset = "0xA195A10", VA = "0x18A196A10")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool EWZAZKFZPNJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0xA195E80", Offset = "0xA194E80", VA = "0x18A195E80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool TJSOBUFMDIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0xA195950", Offset = "0xA194950", VA = "0x18A195950")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool YFFOZPUFQQH
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0xA195460", Offset = "0xA194460", VA = "0x18A195460")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool RBUSOTKWJMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0xA195400", Offset = "0xA194400", VA = "0x18A195400")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool XCENQRHRJFJ
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xA1952E0", Offset = "0xA1942E0", VA = "0x18A1952E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public bool XWUMBDSPGDA
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xA195C70", Offset = "0xA194C70", VA = "0x18A195C70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool CCWOSPTXWCA
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xE06980", Offset = "0xE05980", VA = "0x180E06980")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event RbexParentChangeAction CEGNJVDZRVI
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xA195200", Offset = "0xA194200", VA = "0x18A195200")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xA196E70", Offset = "0xA195E70", VA = "0x18A196E70")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event RbexAction RFDAIXCOTNI
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xA194F70", Offset = "0xA193F70", VA = "0x18A194F70")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xA196BD0", Offset = "0xA195BD0", VA = "0x18A196BD0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event RbexAction YCYGARIGOMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xA194FD0", Offset = "0xA193FD0", VA = "0x18A194FD0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xA196C40", Offset = "0xA195C40", VA = "0x18A196C40")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event RbexAction XTRRPJVQKDC
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xA195120", Offset = "0xA194120", VA = "0x18A195120")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xA196D90", Offset = "0xA195D90", VA = "0x18A196D90")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<UpdateLOD, UpdateLOD> DNKGSBVGHEO
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xA1950B0", Offset = "0xA1940B0", VA = "0x18A1950B0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0xA196D20", Offset = "0xA195D20", VA = "0x18A196D20")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event RbexAction ARAWXPUTFLN
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0xA195190", Offset = "0xA194190", VA = "0x18A195190")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xA196E00", Offset = "0xA195E00", VA = "0x18A196E00")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event RbexAction VCTYYKOPJAR
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0xA195270", Offset = "0xA194270", VA = "0x18A195270")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0xA196EE0", Offset = "0xA195EE0", VA = "0x18A196EE0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event RbexAction LMFBQUDAGFG
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0xA195040", Offset = "0xA194040", VA = "0x18A195040")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0xA196CB0", Offset = "0xA195CB0", VA = "0x18A196CB0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xCF4880", Offset = "0xCF3880", VA = "0x180CF4880", Slot = "8")]
		private void TYBJVFXOZRQ(ILGARLMTLIL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xA193990", Offset = "0xA192990", VA = "0x18A193990", Slot = "9")]
		public RigidbodyExData GetData()
		{
			return default(RigidbodyExData);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA193F70", Offset = "0xA192F70", VA = "0x18A193F70")]
		internal void QNVCTWRBIEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA194C90", Offset = "0xA193C90", VA = "0x18A194C90")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public void TestOverrideUnityRigidbody(Rigidbody rb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xA1936E0", Offset = "0xA1926E0", VA = "0x18A1936E0")]
		public ZKNRSSQMNPD GetChild(int index)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xA1948F0", Offset = "0xA1938F0", VA = "0x18A1948F0")]
		public void SetInertiaTensor((Quaternion rot, Vector3 moments) tensor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xA193280", Offset = "0xA192280", VA = "0x18A193280")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA194B80", Offset = "0xA193B80", VA = "0x18A194B80")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xA193630", Offset = "0xA192630", VA = "0x18A193630")]
		private ILGARLMTLIL GWQXGOJAWRO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xA193C80", Offset = "0xA192C80", VA = "0x18A193C80")]
		private void KWSQHQMQIDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xA1940C0", Offset = "0xA1930C0", VA = "0x18A1940C0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xA194000", Offset = "0xA193000", VA = "0x18A194000")]
		public void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0xA193F70", Offset = "0xA192F70", VA = "0x18A193F70")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xA194060", Offset = "0xA193060", VA = "0x18A194060")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xA194120", Offset = "0xA193120", VA = "0x18A194120")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xA192870", Offset = "0xA191870", VA = "0x18A192870")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xA194180", Offset = "0xA193180", VA = "0x18A194180")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xA1935D0", Offset = "0xA1925D0", VA = "0x18A1935D0")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xA193F10", Offset = "0xA192F10", VA = "0x18A193F10")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xA194A50", Offset = "0xA193A50", VA = "0x18A194A50")]
		public void SetParent(RigidbodyEx value, bool isPhysicallyDetachedOnly = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0xA194490", Offset = "0xA193490", VA = "0x18A194490")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xA193A20", Offset = "0xA192A20", VA = "0x18A193A20")]
		public bool IsRigidbodyAncestor(RigidbodyEx possibleAncestor)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xA193B20", Offset = "0xA192B20", VA = "0x18A193B20")]
		public bool IsRigidbodyDescendant(RigidbodyEx possibleDescendant)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xA192AE0", Offset = "0xA191AE0", VA = "0x18A192AE0")]
		public void AddInterpolationRestriction(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0xA1941F0", Offset = "0xA1931F0", VA = "0x18A1941F0")]
		public void RemoveInterpolationRestriction(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0xA192B50", Offset = "0xA191B50", VA = "0x18A192B50")]
		public void AddKinematic(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0xA194260", Offset = "0xA193260", VA = "0x18A194260")]
		public void RemoveKinematic(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0xA1949D0", Offset = "0xA1939D0", VA = "0x18A1949D0")]
		public void SetKinematic(object token, bool setKinematic)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0xA1947F0", Offset = "0xA1937F0", VA = "0x18A1947F0")]
		public void SetDiscontinuousPositionAndRotation(Vector3 newPosition, Quaternion newRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0xA1946F0", Offset = "0xA1936F0", VA = "0x18A1946F0")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 newLocalPosition, Quaternion newLocalRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0xA193880", Offset = "0xA192880", VA = "0x18A193880")]
		public Vector3 GetConstrainedVelocity(Vector3 velocity)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0xA193770", Offset = "0xA192770", VA = "0x18A193770")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 angularVelocity)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0xA1929F0", Offset = "0xA1919F0", VA = "0x18A1929F0")]
		public void AddForce(Vector3 force, ForceMode forceMode = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xA1928E0", Offset = "0xA1918E0", VA = "0x18A1928E0")]
		public void AddForceAtPosition(Vector3 force, Vector3 position, ForceMode forceMode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0xA192D20", Offset = "0xA191D20", VA = "0x18A192D20")]
		public void AddTorque(Vector3 torque, ForceMode forceMode = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xA192BC0", Offset = "0xA191BC0", VA = "0x18A192BC0")]
		public void AddRelativeTorque(Vector3 torque, ForceMode forceMode = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0xA194D60", Offset = "0xA193D60", VA = "0x18A194D60")]
		public Vector3 WorldToLocalVelocity(Vector3 worldVelocity)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xA193E00", Offset = "0xA192E00", VA = "0x18A193E00")]
		public Vector3 LocalToWorldVelocity(Vector3 localVelocity)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xA193570", Offset = "0xA192570", VA = "0x18A193570")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xA193510", Offset = "0xA192510", VA = "0x18A193510")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0xA1934B0", Offset = "0xA1924B0", VA = "0x18A1934B0")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xA193450", Offset = "0xA192450", VA = "0x18A193450")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xA1945F0", Offset = "0xA1935F0", VA = "0x18A1945F0")]
		public void ResetVelocityWorldSpace(Vector3 worldLinearVelocity, Vector3 worldAngularVelocity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xA1944F0", Offset = "0xA1934F0", VA = "0x18A1944F0")]
		public void ResetVelocityLocalSpace(Vector3 localLinearVelocity, Vector3 localAngularVelocity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0xA1943B0", Offset = "0xA1933B0", VA = "0x18A1943B0")]
		public void ResetLinearVelocityLocalSpace(Vector3 localLinearVelocity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xA194B90", Offset = "0xA193B90", VA = "0x18A194B90")]
		public bool SweepTest(Vector3 direction, [Out] RaycastHit hitInfo, float maxDistance)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xA193C20", Offset = "0xA192C20", VA = "0x18A193C20")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xA194B20", Offset = "0xA193B20", VA = "0x18A194B20")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xA194D00", Offset = "0xA193D00", VA = "0x18A194D00")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0xA192CB0", Offset = "0xA191CB0", VA = "0x18A192CB0")]
		public void AddShouldHaveUnityRigidbodyToken(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xA1942D0", Offset = "0xA1932D0", VA = "0x18A1942D0")]
		public void RemoveShouldHaveUnityRigidbodyToken(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0xA1930B0", Offset = "0xA1920B0", VA = "0x18A1930B0")]
		public void ApplyForceVelocityChange(RbexImpulseType impulseType, Vector3 impulseDirection, float impulseSpeed, float impulseDirectionMaxSpeed = 8f, float impulseReflectiveRestitution = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0xA192FB0", Offset = "0xA191FB0", VA = "0x18A192FB0")]
		public void ApplyAngularVelocityChange(RbexRotationType rotationType, Vector3 newAngularVelocity, float maxAngularSpeed = 1f / 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0xA193170", Offset = "0xA192170", VA = "0x18A193170")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void ApplyTorqueAngularVelocityChangeDeprecated(RbexRotationType rotationType, Vector3 rotation, float maxSpeed = 7f, float multiplyingFactor = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xA192EE0", Offset = "0xA191EE0", VA = "0x18A192EE0")]
		public bool AllowedScaleChange(float scaleFactor)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xA192E10", Offset = "0xA191E10", VA = "0x18A192E10")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx parentOverride, object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xA194340", Offset = "0xA193340", VA = "0x18A194340")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x8DA27D0", Offset = "0x8DA17D0", VA = "0x188DA27D0", Slot = "13")]
		private void OEIDYTPWOHP(LUXUOCKLUHV a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xA194F00", Offset = "0xA193F00", VA = "0x18A194F00")]
		public RigidbodyEx()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x150C510", Offset = "0x150B510", VA = "0x18150C510", Slot = "4")]
		private GameObject RGCYQIQZRWE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0xD212D0", Offset = "0xD202D0", VA = "0x180D212D0", Slot = "10")]
		private bool EPQPELERXNZ()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	internal static class YLYQIXVGBEO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0xA198E80", Offset = "0xA197E80", VA = "0x18A198E80")]
		public static ILGARLMTLIL XQCTBFPOVUA(this RigidbodyEx a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[RegisterService(typeof(TKGZAEVETJO), new string[] { })]
	public class RigidbodyExManager : TKGZAEVETJO, FEPVKGQXMPS
	{
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static readonly Log NSTUKEGGGWA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private RHGKESAJJSH EHXZKUBIMDY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private ZNKUBNNNAEW JBEQKPLEKCE;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public RHGKESAJJSH KLSEBVMTENM
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xCF4120", Offset = "0xCF3120", VA = "0x180CF4120", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public ZNKUBNNNAEW TXYRDWRRRWY
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0xA1925A0", Offset = "0xA1915A0", VA = "0x18A1925A0", Slot = "7")]
		public void InitReferences(GLSTNWKFOLX services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0xA192610", Offset = "0xA191610", VA = "0x18A192610", Slot = "6")]
		public ILGARLMTLIL NYRELCTHBHW(RigidbodyEx a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		public RigidbodyExManager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class PhysicsManager : SingletonMonoBehaviour<PhysicsManager>
	{
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static FYRDCSIKYKI UpdateAfterFixedUpdateRan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private int CRGRENNTJCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private int ZCCXSXKAMEW;

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0xA188DA0", Offset = "0xA187DA0", VA = "0x18A188DA0")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0xA188E20", Offset = "0xA187E20", VA = "0x18A188E20")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0xA188DC0", Offset = "0xA187DC0", VA = "0x18A188DC0")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string message, [Optional] UnityEngine.Object context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string message, [Optional] UnityEngine.Object context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0xA188F20", Offset = "0xA187F20", VA = "0x18A188F20")]
		public PhysicsManager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public static class NYFUJTZQPQK
	{
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		private class MYUFFHKHGIW : PMLHAPSUBFJ, IDisposable
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "7")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0xD05610", Offset = "0xD04610", VA = "0x180D05610", Slot = "4")]
			public Vector3 NMKRBNRFJDV()
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0xD05610", Offset = "0xD04610", VA = "0x180D05610", Slot = "5")]
			public Vector3 ITPANRDLRGC()
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0xD0FC20", Offset = "0xD0EC20", VA = "0x180D0FC20", Slot = "6")]
			public bool LFEDPXNLESF(float a, float b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public MYUFFHKHGIW()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public static PMLHAPSUBFJ QRRCORZMLPJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0xA188610", Offset = "0xA187610", VA = "0x18A188610")]
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
	public interface AWYAYARGVFF
	{
		[Cpp2IlInjected.Token(Token = "0x17000039")]
		CollisionDetectionMode PKOXOCLHCPQ
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
		void QPJYMBPXXZI(bool a);

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void YZREATBQSJH(bool a);

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void IHZDNEVHYFV(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool KHCQECXVRPI(Vector3 a, [Out] RaycastHit b, float c);
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public interface AQNRDQHPPOU : IDisposable, KYTNRHJJHPE
	{
		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		TransformTrackRate ICFISROOEQZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		event Action<UpdateLOD, UpdateLOD> DNKGSBVGHEO;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void Awake();
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[ServiceLifetime(Lifetime.Application)]
	public interface ZNKUBNNNAEW
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		PRACVVKJIAD LJBPHJFVJJX(ILGARLMTLIL a);

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		LWHEDSVATFN JVFAAGUGYDT(ILGARLMTLIL a);

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		XMNUJWTNKWA EUVCNYGQDMG(ILGARLMTLIL a);

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		ZRIOIJCOPVP KXNPMKVEBIX(ILGARLMTLIL a);

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "4")]
		IZKWDLOPYTF DKLDZAFRCWR(ILGARLMTLIL a);

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "5")]
		AQNRDQHPPOU QGKREIFDPLU(ILGARLMTLIL a);

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "6")]
		KFDCYDZXMDP TNLVDABXLOX(ILGARLMTLIL a);

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "7")]
		FQHAKQFSQFJ XLMZZYYFSWF(ILGARLMTLIL a);

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "8")]
		AWYAYARGVFF XHPANWDIPVX(ILGARLMTLIL a);

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "9")]
		YKWTOGHBMSK NQLREKTYZBS(ILGARLMTLIL a);

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "10")]
		EXJBSVNRWPK QOLSQWLHWOS(ILGARLMTLIL a, [In] RigidbodyExData data);

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "11")]
		DRXZXIEZDHK EGESNZFJBHM(ILGARLMTLIL a, [In] RigidbodyExData data);

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "12")]
		PUTBWMRLSPY ZVNVDRVEXMU(ILGARLMTLIL a, [In] RigidbodyExData data);

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "13")]
		CIEDVOAJZHM WBJXXPNKDUE(ILGARLMTLIL a, [In] RigidbodyExData data);

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "14")]
		JBOJCWNYFZU ZRTWCXGWOHO(ILGARLMTLIL a, [In] RigidbodyExData data);

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "15")]
		ILGARLMTLIL NYRELCTHBHW(RigidbodyEx a, RigidbodyExData b, TKGZAEVETJO c);
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface FQHAKQFSQFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void PBLSISEZSPW(Vector3 a, ForceMode b = ForceMode.Force);

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void UYKXLVTRRUK(Vector3 a, Vector3 b, ForceMode c);

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void BDIEUJEHSCH(Vector3 a, ForceMode b = ForceMode.Force);

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void MIJHMKJFXDB(Vector3 a, ForceMode b = ForceMode.Force);
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface YKWTOGHBMSK
	{
		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		bool DINTYYEPLEN
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
		void IHZDNEVHYFV(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void JWUHDIYEPYE(Rigidbody a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public interface PRACVVKJIAD : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		IReadOnlyList<ILGARLMTLIL> EVCFLBUFVWC
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(Slot = "18")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		ILGARLMTLIL OTBMMIANHVU
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(Slot = "19")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		ILGARLMTLIL QVPRBHQGWTI
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(Slot = "20")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(Slot = "21")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		event RbexAction RFDAIXCOTNI;

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		event RbexAction YCYGARIGOMI;

		[Cpp2IlInjected.Token(Token = "0x1400000C")]
		event RbexParentChangeAction HBQEEIXQNRM;

		[Cpp2IlInjected.Token(Token = "0x1400000D")]
		event Action PIOMRIICWRB;

		[Cpp2IlInjected.Token(Token = "0x1400000E")]
		event Action EGXDKWAQZNC;

		[Cpp2IlInjected.Token(Token = "0x1400000F")]
		event Action<ILGARLMTLIL> XDBXNBEFEMB;

		[Cpp2IlInjected.Token(Token = "0x14000010")]
		event Action<ILGARLMTLIL> QHHBMTOPEPM;

		[Cpp2IlInjected.Token(Token = "0x14000011")]
		event Action MJVKWZLWMXX;

		[Cpp2IlInjected.Token(Token = "0x14000012")]
		event Action<ILGARLMTLIL> EMDEGWLRILI;

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "22")]
		void SetParent(ILGARLMTLIL newParent, bool isPhysicallyDetachedOnly = false);
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public interface XMNUJWTNKWA
	{
		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		Vector3 KPUEMWVUONV
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		Vector3 EFZQLSWLJCN
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void UNXEEAKIKXP(ILGARLMTLIL a, object b);

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void LVFFQDEAHPI(object a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public interface CIEDVOAJZHM
	{
		[Cpp2IlInjected.Token(Token = "0x17000041")]
		Vector3 QWATCCKAWUR
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		Vector3 PYREPYKMEKW
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		float HITIEXJSMXQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		float CMCOQCCYGYB
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(Slot = "7")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		Vector3 JUEZHWMACIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		Quaternion SKYLZADQFLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000013")]
		event RbexAction YBHBWDHLFYU;

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void DWBCFACUSMJ((Quaternion rot, Vector3 moments) tensor);

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(Slot = "11")]
		void GQDGTNPRVDW();

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void XUXWLKJZEML();

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(Slot = "13")]
		void YRSYPIGFEEF();

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void IHZDNEVHYFV(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void JWUHDIYEPYE(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void OnDrawGizmosSelected();
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public interface PUTBWMRLSPY
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Awake();

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void QGRINZJPHUZ(object a);

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void GDBFQMQWTEI(object a);

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void NHYFIDLAYRK(ILGARLMTLIL a);

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void LALXNOVDXQL(ILGARLMTLIL a);

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void HZPTOSMOGNG();
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public interface KFDCYDZXMDP
	{
		[Cpp2IlInjected.Token(Token = "0x17000047")]
		bool CJTZZJEKODZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000014")]
		event RbexAction KUIMSZLTPKV;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void AJVUKMEXMLI(object a);

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void JBLBTIWABUL(object a);

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void EPPKXSKDCNZ(object a, bool b);

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void IHZDNEVHYFV(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void JWUHDIYEPYE(Rigidbody a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface DRXZXIEZDHK : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000048")]
		bool ACVKLIDTRQG
		{
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		bool MQPWBNLGCJW
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000015")]
		event RbexAction YRCPZMOVYQJ;

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void Awake();

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void HCDHOCLKZUG(ILGARLMTLIL a);

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void DWRDRQPSBAO(ILGARLMTLIL a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface JBOJCWNYFZU
	{
		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		bool NARFOTVPSDX
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		bool PRUMFNUXAHG
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		RigidbodyConstraints JJZOSIQMEDE
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
		void IHZDNEVHYFV(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void JWUHDIYEPYE(Rigidbody a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface ZRIOIJCOPVP
	{
		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		float HVINMNNTFXW
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		float KBOUNHVVUVU
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
		void IHZDNEVHYFV(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void JWUHDIYEPYE(Rigidbody a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public interface IZKWDLOPYTF
	{
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		static bool IMATHJWEANB;

		[Cpp2IlInjected.Token(Token = "0x14000016")]
		event RbexAction HOBOAEGMSHR;

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void Awake();

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool XYSVULGKTGD();

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void RDWQBAFCVPP();

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void Sleep();

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool FBJPFDHSJPX();

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool LNLETBLWCSY();

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void WCNCTSITEOG(bool a);

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void YNIOIMIDNQX();
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public interface EXJBSVNRWPK
	{
		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		Rigidbody QGAIQBZDQPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		bool MEMOCHUEAMP
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
		void SAWLWTMEMXT(object a);

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void IVKHRDNGGAQ(object a);

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void GLCHDSATOVP();
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public interface LWHEDSVATFN : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000051")]
		PMLHAPSUBFJ TZXRMFIXXWE
		{
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		BEZDMGXLQFQ ZWHTJXACTAP
		{
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		Vector3 NPOJEZMRFSZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(Slot = "5")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		Vector3 TUAHNIEKLNU
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(Slot = "7")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		Vector3 UVVCXXROUBR
		{
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(Slot = "9")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		Vector3 DDZBNUOYPRY
		{
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(Slot = "11")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		float CBLNIGZTQQF
		{
			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(Slot = "13")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		bool LEUQMXSJXOT
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
		void JOVNNJUAIIF(object a);

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(Slot = "17")]
		void YMBLVAOKJWL(RbexRotationType a, Vector3 b, float c = 1f / 0f);

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(Slot = "18")]
		void WIAIVLVWCKS(RbexImpulseType a, Vector3 b, float c, float d = 8f, float e = 1f);

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(Slot = "19")]
		void QNGFIYDHQAA(RbexRotationType a, Vector3 b, float c = 7f, float d = 1f);

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(Slot = "20")]
		void PSHYMKVXIOA();

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(Slot = "21")]
		void TZYMGPPEKXL();

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(Slot = "22")]
		void QQQFCCDEKHK();

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(Slot = "23")]
		void GPQLSGJPULC();

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(Slot = "24")]
		void IHZDNEVHYFV(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(Slot = "25")]
		Vector3 KNPHONAZKOZ(Vector3 a);

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(Slot = "26")]
		void ORNEPLATWZO(object a);

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(Slot = "27")]
		void XNAKEQYFVRC(Vector3 a);

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(Slot = "28")]
		void VYGUHRWBIYV(Vector3 a, Vector3 b);

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(Slot = "29")]
		void AGKDPXRROMM(Vector3 a, Vector3 b);

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(Slot = "30")]
		Vector3 TJDRHKSWKNZ(Vector3 a);

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(Slot = "31")]
		Vector3 SOSROYBJVTL(Vector3 a);
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[ServiceLifetime(Lifetime.Application)]
	public interface RHGKESAJJSH
	{
		[Cpp2IlInjected.Token(Token = "0x17000059")]
		bool LFYSLFRZSEQ
		{
			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void BQIKJOXPHPE(string a);

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void UJDTBARITSF(RigidbodyEx a, Action b);

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		ROSSOIWDWST RCAQCDBWBHC(int a);

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void DQYAMANOPKQ(Vector3 a, float b, Color c);
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[ServiceLifetime(Lifetime.Application)]
	public interface TKGZAEVETJO
	{
		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		RHGKESAJJSH KLSEBVMTENM
		{
			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		ZNKUBNNNAEW TXYRDWRRRWY
		{
			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(Slot = "2")]
		ILGARLMTLIL NYRELCTHBHW(RigidbodyEx a);
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class QBRSGAMKJKG : ILGARLMTLIL, IDisposable, XHHGAKUJSQE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		internal readonly TKGZAEVETJO RVAMSININVX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		internal PRACVVKJIAD GREKCHRVGOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		internal PUTBWMRLSPY KJVGFVDRSIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		internal DRXZXIEZDHK GKIPHIXYXNU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		internal LWHEDSVATFN CYGFHHFNFMZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		internal XMNUJWTNKWA JUEKKZNPXLU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		internal CIEDVOAJZHM UGYBGLEJXTK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		internal ZRIOIJCOPVP VPKXZIHHENV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		internal YKWTOGHBMSK HJKEFBHQVBW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		internal IZKWDLOPYTF WMJTLNSZAAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		internal AQNRDQHPPOU QMJLBHJOKYC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		internal KFDCYDZXMDP ONUWGTBNHMX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		internal FQHAKQFSQFJ TIJLEMMLXEZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		internal JBOJCWNYFZU HPZHXHRUOFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		internal EXJBSVNRWPK THNNDBQPXLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		internal AWYAYARGVFF RHPMQTLVVOR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		internal IDisposable JGLPKNOUKXS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private bool CIXLCNESFCG;

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public ObjectLocalId TOKRGEUQPKY
		{
			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0xCF6210", Offset = "0xCF5210", VA = "0x180CF6210", Slot = "22")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public ZKNRSSQMNPD INZMSHGEKYI
		{
			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0xDD3B70", Offset = "0xDD2B70", VA = "0x180DD3B70", Slot = "24")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0xE94400", Offset = "0xE93400", VA = "0x180E94400")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public GameObject EAFOXCIWXIX
		{
			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0xCFA5A0", Offset = "0xCF95A0", VA = "0x180CFA5A0", Slot = "25")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0xCFA580", Offset = "0xCF9580", VA = "0x180CFA580")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public Transform KXYMJCOORZI
		{
			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0xEA8080", Offset = "0xEA7080", VA = "0x180EA8080", Slot = "26")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x1014F90", Offset = "0x1013F90", VA = "0x181014F90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public Rigidbody QGAIQBZDQPM
		{
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0xA18AAD0", Offset = "0xA189AD0", VA = "0x18A18AAD0", Slot = "23")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public ILGARLMTLIL QVPRBHQGWTI
		{
			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0xA18B040", Offset = "0xA18A040", VA = "0x18A18B040", Slot = "27")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0xA18A800", Offset = "0xA189800", VA = "0x18A18A800", Slot = "28")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public int FYSSYHOJLWD
		{
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0xA18C930", Offset = "0xA18B930", VA = "0x18A18C930", Slot = "31")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public ILGARLMTLIL OTBMMIANHVU
		{
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0xA18C9A0", Offset = "0xA18B9A0", VA = "0x18A18C9A0", Slot = "29")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public bool BWSTFYAYCNE
		{
			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0xA18CC50", Offset = "0xA18BC50", VA = "0x18A18CC50", Slot = "32")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public bool ACVKLIDTRQG
		{
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0xA18ADF0", Offset = "0xA189DF0", VA = "0x18A18ADF0", Slot = "33")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public bool MQPWBNLGCJW
		{
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0xA18CEE0", Offset = "0xA18BEE0", VA = "0x18A18CEE0", Slot = "34")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public PMLHAPSUBFJ TZXRMFIXXWE
		{
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0xA18C390", Offset = "0xA18B390", VA = "0x18A18C390", Slot = "35")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0xA18ECC0", Offset = "0xA18DCC0", VA = "0x18A18ECC0", Slot = "36")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public BEZDMGXLQFQ ZWHTJXACTAP
		{
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0xA18EE90", Offset = "0xA18DE90", VA = "0x18A18EE90", Slot = "37")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0xA18D2B0", Offset = "0xA18C2B0", VA = "0x18A18D2B0", Slot = "38")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public float CBLNIGZTQQF
		{
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0xA18A310", Offset = "0xA189310", VA = "0x18A18A310", Slot = "39")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0xA18C120", Offset = "0xA18B120", VA = "0x18A18C120", Slot = "40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public Vector3 TUAHNIEKLNU
		{
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0xA18B5B0", Offset = "0xA18A5B0", VA = "0x18A18B5B0", Slot = "41")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0xA18AC30", Offset = "0xA189C30", VA = "0x18A18AC30", Slot = "42")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public Vector3 DDZBNUOYPRY
		{
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0xA18CB70", Offset = "0xA18BB70", VA = "0x18A18CB70", Slot = "43")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0xA18B1C0", Offset = "0xA18A1C0", VA = "0x18A18B1C0", Slot = "44")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public Vector3 NPOJEZMRFSZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0xA189F60", Offset = "0xA188F60", VA = "0x18A189F60", Slot = "45")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0xA18C040", Offset = "0xA18B040", VA = "0x18A18C040", Slot = "46")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public Vector3 UVVCXXROUBR
		{
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0xA18D1D0", Offset = "0xA18C1D0", VA = "0x18A18D1D0", Slot = "47")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0xA18EDB0", Offset = "0xA18DDB0", VA = "0x18A18EDB0", Slot = "48")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public bool YFFOZPUFQQH
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0xA18B690", Offset = "0xA18A690", VA = "0x18A18B690", Slot = "49")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public bool RBUSOTKWJMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0xA189170", Offset = "0xA188170", VA = "0x18A189170", Slot = "50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public bool XCENQRHRJFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0xA18BF60", Offset = "0xA18AF60", VA = "0x18A18BF60", Slot = "51")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public bool LEUQMXSJXOT
		{
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0xA18DB20", Offset = "0xA18CB20", VA = "0x18A18DB20", Slot = "52")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public Vector3 KPUEMWVUONV
		{
			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0xA18C860", Offset = "0xA18B860", VA = "0x18A18C860", Slot = "53")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public Vector3 EFZQLSWLJCN
		{
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0xA18CD00", Offset = "0xA18BD00", VA = "0x18A18CD00", Slot = "54")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public Vector3 QWATCCKAWUR
		{
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0xA18A6B0", Offset = "0xA1896B0", VA = "0x18A18A6B0", Slot = "55")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0xA189AD0", Offset = "0xA188AD0", VA = "0x18A189AD0", Slot = "56")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public Vector3 PYREPYKMEKW
		{
			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0xA18AD10", Offset = "0xA189D10", VA = "0x18A18AD10", Slot = "57")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public float HITIEXJSMXQ
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0xA18BBC0", Offset = "0xA18ABC0", VA = "0x18A18BBC0", Slot = "58")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public float CMCOQCCYGYB
		{
			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0xA18AE40", Offset = "0xA189E40", VA = "0x18A18AE40", Slot = "59")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0xA18F590", Offset = "0xA18E590", VA = "0x18A18F590", Slot = "60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public Vector3 JUEZHWMACIJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0xA18D360", Offset = "0xA18C360", VA = "0x18A18D360", Slot = "61")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public Quaternion SKYLZADQFLB
		{
			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0xA18AF30", Offset = "0xA189F30", VA = "0x18A18AF30", Slot = "62")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public float HVINMNNTFXW
		{
			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0xA18DDF0", Offset = "0xA18CDF0", VA = "0x18A18DDF0", Slot = "64")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0xA18A0A0", Offset = "0xA1890A0", VA = "0x18A18A0A0", Slot = "65")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public float KBOUNHVVUVU
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0xA18D5A0", Offset = "0xA18C5A0", VA = "0x18A18D5A0", Slot = "66")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0xA18A250", Offset = "0xA189250", VA = "0x18A18A250", Slot = "67")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public bool DINTYYEPLEN
		{
			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0xA18CCB0", Offset = "0xA18BCB0", VA = "0x18A18CCB0", Slot = "68")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0xA18A510", Offset = "0xA189510", VA = "0x18A18A510", Slot = "69")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public TransformTrackRate ICFISROOEQZ
		{
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0xA18F170", Offset = "0xA18E170", VA = "0x18A18F170", Slot = "70")]
			get
			{
				return default(TransformTrackRate);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0xA18AA70", Offset = "0xA189A70", VA = "0x18A18AA70", Slot = "71")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public bool CJTZZJEKODZ
		{
			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0xA18C760", Offset = "0xA18B760", VA = "0x18A18C760", Slot = "72")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public Transform BTUQNQNRAWN
		{
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0xEA8080", Offset = "0xEA7080", VA = "0x180EA8080", Slot = "73")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public Vector3 DJGKDVSJTSV
		{
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0xA18C7B0", Offset = "0xA18B7B0", VA = "0x18A18C7B0", Slot = "74")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0xA18E0E0", Offset = "0xA18D0E0", VA = "0x18A18E0E0", Slot = "75")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public float ZWFPQWIOONB
		{
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0xA18CB00", Offset = "0xA18BB00", VA = "0x18A18CB00", Slot = "76")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0xA18E640", Offset = "0xA18D640", VA = "0x18A18E640", Slot = "77")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public float WBUSWXZRGRS
		{
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0xA1892C0", Offset = "0xA1882C0", VA = "0x18A1892C0", Slot = "78")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0xA18B740", Offset = "0xA18A740", VA = "0x18A18B740", Slot = "79")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public Quaternion KGPRAWPZZKQ
		{
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0xA18E7E0", Offset = "0xA18D7E0", VA = "0x18A18E7E0", Slot = "80")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0xA18A8D0", Offset = "0xA1898D0", VA = "0x18A18A8D0", Slot = "81")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public Vector3 ELYIHVHAUZQ
		{
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0xA18E600", Offset = "0xA18D600", VA = "0x18A18E600", Slot = "82")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0xA18B000", Offset = "0xA18A000", VA = "0x18A18B000", Slot = "83")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public Quaternion UDGWMEZVTAL
		{
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0xA18A670", Offset = "0xA189670", VA = "0x18A18A670", Slot = "84")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0xA18CAD0", Offset = "0xA18BAD0", VA = "0x18A18CAD0", Slot = "85")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public RigidbodyConstraints JJZOSIQMEDE
		{
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0xA189C10", Offset = "0xA188C10", VA = "0x18A189C10", Slot = "86")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0xA18A2B0", Offset = "0xA1892B0", VA = "0x18A18A2B0", Slot = "87")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public bool NARFOTVPSDX
		{
			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0xA18F4E0", Offset = "0xA18E4E0", VA = "0x18A18F4E0", Slot = "88")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0xA18C700", Offset = "0xA18B700", VA = "0x18A18C700", Slot = "89")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public CollisionDetectionMode PKOXOCLHCPQ
		{
			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0xA18F070", Offset = "0xA18E070", VA = "0x18A18F070", Slot = "90")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0xA18CB10", Offset = "0xA18BB10", VA = "0x18A18CB10", Slot = "91")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public bool IERYJHXJYYN
		{
			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0xA18D5F0", Offset = "0xA18C5F0", VA = "0x18A18D5F0", Slot = "141")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public bool TJSOBUFMDIE
		{
			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0xA18E480", Offset = "0xA18D480", VA = "0x18A18E480", Slot = "92")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000017")]
		public event RbexAction RFDAIXCOTNI
		{
			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0xA18F010", Offset = "0xA18E010", VA = "0x18A18F010", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0xA18A9B0", Offset = "0xA1899B0", VA = "0x18A18A9B0", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000018")]
		public event RbexAction YCYGARIGOMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0xA18DAC0", Offset = "0xA18CAC0", VA = "0x18A18DAC0", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0xA18B160", Offset = "0xA18A160", VA = "0x18A18B160", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000019")]
		public event RbexParentChangeAction HBQEEIXQNRM
		{
			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0xA18D730", Offset = "0xA18C730", VA = "0x18A18D730", Slot = "18")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0xA18C4E0", Offset = "0xA18B4E0", VA = "0x18A18C4E0", Slot = "19")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001A")]
		public event RbexAction YRCPZMOVYQJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0xA18DCD0", Offset = "0xA18CCD0", VA = "0x18A18DCD0", Slot = "8")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0xA18CF30", Offset = "0xA18BF30", VA = "0x18A18CF30", Slot = "9")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001B")]
		public event RbexAction XTRRPJVQKDC
		{
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0xA18ABD0", Offset = "0xA189BD0", VA = "0x18A18ABD0", Slot = "14")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0xA1892D0", Offset = "0xA1882D0", VA = "0x18A1892D0", Slot = "15")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001C")]
		public event RbexAction HOBOAEGMSHR
		{
			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0xA18F110", Offset = "0xA18E110", VA = "0x18A18F110", Slot = "16")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0xA189BB0", Offset = "0xA188BB0", VA = "0x18A189BB0", Slot = "17")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001D")]
		public event Action<UpdateLOD, UpdateLOD> DNKGSBVGHEO
		{
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0xA18AA10", Offset = "0xA189A10", VA = "0x18A18AA10", Slot = "20")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0xA18DB70", Offset = "0xA18CB70", VA = "0x18A18DB70", Slot = "21")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001E")]
		public event RbexAction KUIMSZLTPKV
		{
			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0xA18F5F0", Offset = "0xA18E5F0", VA = "0x18A18F5F0", Slot = "12")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0xA189F00", Offset = "0xA188F00", VA = "0x18A189F00", Slot = "13")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001F")]
		public event RbexAction LMFBQUDAGFG
		{
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0xA18AB20", Offset = "0xA189B20", VA = "0x18A18AB20", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0xA18DE40", Offset = "0xA18CE40", VA = "0x18A18DE40", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0xA18F650", Offset = "0xA18E650", VA = "0x18A18F650")]
		public QBRSGAMKJKG(GameObject a, RigidbodyEx b, TKGZAEVETJO c, [In] RigidbodyExData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0xA18E190", Offset = "0xA18D190", VA = "0x18A18E190", Slot = "139")]
		protected virtual void UFSDEDAVHQK(TKGZAEVETJO a, RigidbodyExData b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0xA18A570", Offset = "0xA189570", VA = "0x18A18A570", Slot = "140")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0xA189850", Offset = "0xA188850", VA = "0x18A189850", Slot = "93")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0xA18D060", Offset = "0xA18C060", VA = "0x18A18D060", Slot = "94")]
		public void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0xA18CFB0", Offset = "0xA18BFB0", VA = "0x18A18CFB0", Slot = "95")]
		public void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0xA18CF90", Offset = "0xA18BF90", VA = "0x18A18CF90", Slot = "96")]
		public void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0xA18E970", Offset = "0xA18D970", VA = "0x18A18E970")]
		private void WCNCTSITEOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0xA1897D0", Offset = "0xA1887D0", VA = "0x18A1897D0")]
		private void APPDWNSKYZB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0xA18C6A0", Offset = "0xA18B6A0", VA = "0x18A18C6A0")]
		private void LNLETBLWCSY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0xA18B530", Offset = "0xA18A530", VA = "0x18A18B530", Slot = "30")]
		public ILGARLMTLIL IBOQKRTVWGU(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0xA18DD30", Offset = "0xA18CD30", VA = "0x18A18DD30", Slot = "98")]
		public void SetParent(ILGARLMTLIL value, bool isPhysicallyDetachedOnly = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0xA18DFF0", Offset = "0xA18CFF0", VA = "0x18A18DFF0", Slot = "99")]
		public void TPXBMQEIFPN(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0xA18F530", Offset = "0xA18E530", VA = "0x18A18F530", Slot = "100")]
		public void ZERZPFMBMZE(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0xA18DBD0", Offset = "0xA18CBD0", VA = "0x18A18DBD0", Slot = "101")]
		public Vector3 SOSROYBJVTL(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0xA18DEF0", Offset = "0xA18CEF0", VA = "0x18A18DEF0", Slot = "102")]
		public Vector3 TJDRHKSWKNZ(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0xA18AE90", Offset = "0xA189E90", VA = "0x18A18AE90", Slot = "103")]
		public void GPQLSGJPULC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0xA18E050", Offset = "0xA18D050", VA = "0x18A18E050", Slot = "104")]
		public void TZYMGPPEKXL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0xA18D310", Offset = "0xA18C310", VA = "0x18A18D310", Slot = "105")]
		public void PSHYMKVXIOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0xA1891D0", Offset = "0xA1881D0", VA = "0x18A1891D0", Slot = "106")]
		public void AGKDPXRROMM(Vector3 a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0xA18E880", Offset = "0xA18D880", VA = "0x18A18E880", Slot = "107")]
		public void VYGUHRWBIYV(Vector3 a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0xA18EF30", Offset = "0xA18DF30", VA = "0x18A18EF30", Slot = "108")]
		public void XNAKEQYFVRC(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0xA18EC00", Offset = "0xA18DC00", VA = "0x18A18EC00", Slot = "109")]
		public void WIAIVLVWCKS(RbexImpulseType a, Vector3 b, float c, float d = 8f, float e = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0xA18F320", Offset = "0xA18E320", VA = "0x18A18F320", Slot = "110")]
		public void YMBLVAOKJWL(RbexRotationType a, Vector3 b, float c = 1f / 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0xA18D440", Offset = "0xA18C440", VA = "0x18A18D440", Slot = "111")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void QNGFIYDHQAA(RbexRotationType a, Vector3 b, float c = 7f, float d = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0xA18C540", Offset = "0xA18B540", VA = "0x18A18C540", Slot = "112")]
		public Vector3 KNPHONAZKOZ(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0xA18CDE0", Offset = "0xA18BDE0", VA = "0x18A18CDE0", Slot = "113")]
		public Vector3 OKMRQLMKNUD(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0xA18D550", Offset = "0xA18C550", VA = "0x18A18D550", Slot = "114")]
		public void QQQFCCDEKHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0xA18A790", Offset = "0xA189790", VA = "0x18A18A790", Slot = "115")]
		public void EGRRBNHNMFY(ILGARLMTLIL a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0xA18C640", Offset = "0xA18B640", VA = "0x18A18C640", Slot = "116")]
		public void KQRICJZRUHF(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0xA18A360", Offset = "0xA189360", VA = "0x18A18A360", Slot = "63")]
		public void DWBCFACUSMJ((Quaternion rot, Vector3 moments) tensor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0xA18F0C0", Offset = "0xA18E0C0", VA = "0x18A18F0C0", Slot = "117")]
		public void XUXWLKJZEML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0xA18AEE0", Offset = "0xA189EE0", VA = "0x18A18AEE0", Slot = "118")]
		public void GQDGTNPRVDW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0xA18F490", Offset = "0xA18E490", VA = "0x18A18F490", Slot = "119")]
		public void YRSYPIGFEEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0xA18F1C0", Offset = "0xA18E1C0", VA = "0x18A18F1C0", Slot = "120")]
		public bool XYSVULGKTGD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0xA18DDA0", Offset = "0xA18CDA0", VA = "0x18A18DDA0", Slot = "97")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0xA18F420", Offset = "0xA18E420", VA = "0x18A18F420", Slot = "121")]
		public void YNIOIMIDNQX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0xA189770", Offset = "0xA188770", VA = "0x18A189770", Slot = "122")]
		public void AJVUKMEXMLI(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0xA18B840", Offset = "0xA18A840", VA = "0x18A18B840", Slot = "123")]
		public void JBLBTIWABUL(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0xA18A860", Offset = "0xA189860", VA = "0x18A18A860", Slot = "124")]
		public void EPPKXSKDCNZ(object a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0xA188F70", Offset = "0xA187F70", VA = "0x18A188F70", Slot = "125")]
		public void AEJGUKVXDKV(Vector3 a, Quaternion b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0xA189C60", Offset = "0xA188C60", VA = "0x18A189C60", Slot = "126")]
		public void CEQCDTHHBUN(Vector3 a, Quaternion b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0xA18EEE0", Offset = "0xA18DEE0", VA = "0x18A18EEE0", Slot = "127")]
		public bool XEAMKKHNQQI(float a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0xA18A040", Offset = "0xA189040", VA = "0x18A18A040", Slot = "128")]
		public void DMHLTKCFDKV(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0xA189A70", Offset = "0xA188A70", VA = "0x18A189A70", Slot = "129")]
		public void BFZHICMHHMK(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0xA18DA60", Offset = "0xA18CA60", VA = "0x18A18DA60", Slot = "130")]
		public void SAWLWTMEMXT(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0xA18B6E0", Offset = "0xA18A6E0", VA = "0x18A18B6E0", Slot = "131")]
		public void IVKHRDNGGAQ(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0xA18D0F0", Offset = "0xA18C0F0", VA = "0x18A18D0F0", Slot = "132")]
		public void PBLSISEZSPW(Vector3 a, ForceMode b = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0xA18E6D0", Offset = "0xA18D6D0", VA = "0x18A18E6D0", Slot = "133")]
		public void UYKXLVTRRUK(Vector3 a, Vector3 b, ForceMode c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0xA189990", Offset = "0xA188990", VA = "0x18A189990", Slot = "134")]
		public void BDIEUJEHSCH(Vector3 a, ForceMode b = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0xA18C9F0", Offset = "0xA18B9F0", VA = "0x18A18C9F0", Slot = "135")]
		public void MIJHMKJFXDB(Vector3 a, ForceMode b = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0xA18C3E0", Offset = "0xA18B3E0", VA = "0x18A18C3E0", Slot = "136")]
		public bool KHCQECXVRPI(Vector3 a, [Out] RaycastHit b, float c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0xA18D010", Offset = "0xA18C010", VA = "0x18A18D010", Slot = "137")]
		public void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0xA18E0A0", Offset = "0xA18D0A0", VA = "0x18A18E0A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0xA18C2B0", Offset = "0xA18B2B0", VA = "0x18A18C2B0")]
		private void KFBAWNOCVDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0xA18F210", Offset = "0xA18E210", VA = "0x18A18F210")]
		private void YERJZEQMKHO(ILGARLMTLIL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0xA18B2A0", Offset = "0xA18A2A0", VA = "0x18A18B2A0")]
		private void HQPXWGMQGKH(ILGARLMTLIL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0xA18B480", Offset = "0xA18A480", VA = "0x18A18B480")]
		private void IASDBYDJJQE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0xA18C180", Offset = "0xA18B180", VA = "0x18A18C180")]
		private void KASZLUCHYBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0xA18D790", Offset = "0xA18C790", VA = "0x18A18D790")]
		private void RVUZOBDTHKJ(ILGARLMTLIL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0xA18B090", Offset = "0xA18A090", VA = "0x18A18B090")]
		private void HCDHOCLKZUG(ILGARLMTLIL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0xA18A440", Offset = "0xA189440", VA = "0x18A18A440")]
		private void DWRDRQPSBAO(ILGARLMTLIL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0xA18A100", Offset = "0xA189100", VA = "0x18A18A100")]
		private void DPUXOGJUMZZ(ZKNRSSQMNPD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0xA189330", Offset = "0xA188330", VA = "0x18A189330", Slot = "142")]
		protected virtual void AJNHRWCIEAI(ZKNRSSQMNPD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0xA18B8A0", Offset = "0xA18A8A0", VA = "0x18A18B8A0")]
		protected void JFWRKBGDCRY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0xA18BC10", Offset = "0xA18AC10", VA = "0x18A18BC10")]
		protected void JKXOBRQEKKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0xA18D940", Offset = "0xA18C940", VA = "0x18A18D940")]
		private void RXCGRGEPYHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0xA189D90", Offset = "0xA188D90", VA = "0x18A189D90")]
		private void COOZRSCCBCB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	internal static class RXDCGXEOSCQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0xA1904D0", Offset = "0xA18F4D0", VA = "0x18A1904D0")]
		public static ILGARLMTLIL CGZWOPGHAKB(this ILGARLMTLIL a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0xA1905E0", Offset = "0xA18F5E0", VA = "0x18A1905E0")]
		public static bool STGKCWYMHTK(this ILGARLMTLIL a, ILGARLMTLIL b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0xA190680", Offset = "0xA18F680", VA = "0x18A190680")]
		public static bool ZRMIGQHTNXQ(this ILGARLMTLIL a, ILGARLMTLIL b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0xA190590", Offset = "0xA18F590", VA = "0x18A190590")]
		public static ZKNRSSQMNPD GMSPLMLAOMM(this ILGARLMTLIL a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0xA190450", Offset = "0xA18F450", VA = "0x18A190450")]
		public static QBRSGAMKJKG Base(this ILGARLMTLIL impl)
		{
			return null;
		}
	}
}
namespace RecRoom.Rbex.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class EWHUFEIPACX : ZNKUBNNNAEW
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0xA182000", Offset = "0xA181000", VA = "0x18A182000", Slot = "19")]
		public ILGARLMTLIL NYRELCTHBHW(RigidbodyEx a, RigidbodyExData b, TKGZAEVETJO c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0xCF6210", Offset = "0xCF5210", VA = "0x180CF6210", Slot = "4")]
		public PRACVVKJIAD LJBPHJFVJJX(ILGARLMTLIL a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0xCF6210", Offset = "0xCF5210", VA = "0x180CF6210", Slot = "5")]
		public LWHEDSVATFN JVFAAGUGYDT(ILGARLMTLIL a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0xCF6210", Offset = "0xCF5210", VA = "0x180CF6210", Slot = "6")]
		public XMNUJWTNKWA EUVCNYGQDMG(ILGARLMTLIL a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0xCF6210", Offset = "0xCF5210", VA = "0x180CF6210", Slot = "7")]
		public ZRIOIJCOPVP KXNPMKVEBIX(ILGARLMTLIL a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0xCF6210", Offset = "0xCF5210", VA = "0x180CF6210", Slot = "8")]
		public IZKWDLOPYTF DKLDZAFRCWR(ILGARLMTLIL a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0xCF6210", Offset = "0xCF5210", VA = "0x180CF6210", Slot = "9")]
		public AQNRDQHPPOU QGKREIFDPLU(ILGARLMTLIL a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0xCF6210", Offset = "0xCF5210", VA = "0x180CF6210", Slot = "10")]
		public KFDCYDZXMDP TNLVDABXLOX(ILGARLMTLIL a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0xCF6210", Offset = "0xCF5210", VA = "0x180CF6210", Slot = "11")]
		public FQHAKQFSQFJ XLMZZYYFSWF(ILGARLMTLIL a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0xCF6210", Offset = "0xCF5210", VA = "0x180CF6210", Slot = "12")]
		public AWYAYARGVFF XHPANWDIPVX(ILGARLMTLIL a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0xCF6210", Offset = "0xCF5210", VA = "0x180CF6210", Slot = "13")]
		public YKWTOGHBMSK NQLREKTYZBS(ILGARLMTLIL a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0xCF6210", Offset = "0xCF5210", VA = "0x180CF6210")]
		public EXJBSVNRWPK QOLSQWLHWOS(ILGARLMTLIL a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0xCF6210", Offset = "0xCF5210", VA = "0x180CF6210")]
		public DRXZXIEZDHK EGESNZFJBHM(ILGARLMTLIL a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0xCF6210", Offset = "0xCF5210", VA = "0x180CF6210")]
		public PUTBWMRLSPY ZVNVDRVEXMU(ILGARLMTLIL a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0xCF6210", Offset = "0xCF5210", VA = "0x180CF6210")]
		public CIEDVOAJZHM WBJXXPNKDUE(ILGARLMTLIL a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0xCF6210", Offset = "0xCF5210", VA = "0x180CF6210")]
		public JBOJCWNYFZU ZRTWCXGWOHO(ILGARLMTLIL a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		public EWHUFEIPACX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0xCF6210", Offset = "0xCF5210", VA = "0x180CF6210", Slot = "14")]
		private EXJBSVNRWPK FHJWUYUFZTE(ILGARLMTLIL a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0xCF6210", Offset = "0xCF5210", VA = "0x180CF6210", Slot = "15")]
		private DRXZXIEZDHK HXYWATLHUGK(ILGARLMTLIL a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0xCF6210", Offset = "0xCF5210", VA = "0x180CF6210", Slot = "16")]
		private PUTBWMRLSPY UKZEQAUWWLS(ILGARLMTLIL a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0xCF6210", Offset = "0xCF5210", VA = "0x180CF6210", Slot = "17")]
		private CIEDVOAJZHM OFOPKGCITMU(ILGARLMTLIL a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0xCF6210", Offset = "0xCF5210", VA = "0x180CF6210", Slot = "18")]
		private JBOJCWNYFZU EEJPCVTIMHW(ILGARLMTLIL a, [In] RigidbodyExData data)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[RegisterService(typeof(ZNKUBNNNAEW), new string[] { })]
	public class LCUFNDPBTJE : ZNKUBNNNAEW, FEPVKGQXMPS
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private readonly ZNKUBNNNAEW FYHFTLAWMVL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private readonly ZNKUBNNNAEW IPOKGEMUTKS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private YMDQYKCOUVK KTEZKRUAOKT;

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		private ZNKUBNNNAEW TXYRDWRRRWY
		{
			[Cpp2IlInjected.Token(Token = "0x600021F")]
			[Cpp2IlInjected.Address(RVA = "0xA187220", Offset = "0xA186220", VA = "0x18A187220")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0xA186D50", Offset = "0xA185D50", VA = "0x18A186D50", Slot = "20")]
		public void InitReferences(GLSTNWKFOLX services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0xA186EE0", Offset = "0xA185EE0", VA = "0x18A186EE0", Slot = "4")]
		public PRACVVKJIAD LJBPHJFVJJX(ILGARLMTLIL a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0xA186DA0", Offset = "0xA185DA0", VA = "0x18A186DA0", Slot = "5")]
		public LWHEDSVATFN JVFAAGUGYDT(ILGARLMTLIL a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0xA186C00", Offset = "0xA185C00", VA = "0x18A186C00", Slot = "6")]
		public XMNUJWTNKWA EUVCNYGQDMG(ILGARLMTLIL a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0xA186E40", Offset = "0xA185E40", VA = "0x18A186E40", Slot = "7")]
		public ZRIOIJCOPVP KXNPMKVEBIX(ILGARLMTLIL a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0xA186A00", Offset = "0xA185A00", VA = "0x18A186A00", Slot = "8")]
		public IZKWDLOPYTF DKLDZAFRCWR(ILGARLMTLIL a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0xA187280", Offset = "0xA186280", VA = "0x18A187280", Slot = "9")]
		public AQNRDQHPPOU QGKREIFDPLU(ILGARLMTLIL a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0xA187320", Offset = "0xA186320", VA = "0x18A187320", Slot = "10")]
		public KFDCYDZXMDP TNLVDABXLOX(ILGARLMTLIL a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0xA187510", Offset = "0xA186510", VA = "0x18A187510", Slot = "11")]
		public FQHAKQFSQFJ XLMZZYYFSWF(ILGARLMTLIL a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0xA187470", Offset = "0xA186470", VA = "0x18A187470", Slot = "12")]
		public AWYAYARGVFF XHPANWDIPVX(ILGARLMTLIL a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0xA186F80", Offset = "0xA185F80", VA = "0x18A186F80", Slot = "13")]
		public YKWTOGHBMSK NQLREKTYZBS(ILGARLMTLIL a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0xA186CA0", Offset = "0xA185CA0", VA = "0x18A186CA0")]
		public EXJBSVNRWPK QOLSQWLHWOS(ILGARLMTLIL a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0xA186B50", Offset = "0xA185B50", VA = "0x18A186B50")]
		public DRXZXIEZDHK EGESNZFJBHM(ILGARLMTLIL a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0xA1873C0", Offset = "0xA1863C0", VA = "0x18A1873C0")]
		public PUTBWMRLSPY ZVNVDRVEXMU(ILGARLMTLIL a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0xA187170", Offset = "0xA186170", VA = "0x18A187170")]
		public CIEDVOAJZHM WBJXXPNKDUE(ILGARLMTLIL a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0xA186AA0", Offset = "0xA185AA0", VA = "0x18A186AA0")]
		public JBOJCWNYFZU ZRTWCXGWOHO(ILGARLMTLIL a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0xA187020", Offset = "0xA186020", VA = "0x18A187020", Slot = "19")]
		public ILGARLMTLIL NYRELCTHBHW(RigidbodyEx a, RigidbodyExData b, TKGZAEVETJO c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0xA1875B0", Offset = "0xA1865B0", VA = "0x18A1875B0")]
		public LCUFNDPBTJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0xA186CA0", Offset = "0xA185CA0", VA = "0x18A186CA0", Slot = "14")]
		private EXJBSVNRWPK FHJWUYUFZTE(ILGARLMTLIL a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0xA186B50", Offset = "0xA185B50", VA = "0x18A186B50", Slot = "15")]
		private DRXZXIEZDHK HXYWATLHUGK(ILGARLMTLIL a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0xA1873C0", Offset = "0xA1863C0", VA = "0x18A1873C0", Slot = "16")]
		private PUTBWMRLSPY UKZEQAUWWLS(ILGARLMTLIL a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0xA187170", Offset = "0xA186170", VA = "0x18A187170", Slot = "17")]
		private CIEDVOAJZHM OFOPKGCITMU(ILGARLMTLIL a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0xA186AA0", Offset = "0xA185AA0", VA = "0x18A186AA0", Slot = "18")]
		private JBOJCWNYFZU EEJPCVTIMHW(ILGARLMTLIL a, [In] RigidbodyExData data)
		{
			return null;
		}
	}
}
namespace RecRoom.Rbex.Legacy
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public interface COPNJISUQSG : PRACVVKJIAD, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void ZGUAUCXGOAN(ILGARLMTLIL a);

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void CFZBTFRSLGI(ILGARLMTLIL a);

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void OUIPXCJDSZR(ILGARLMTLIL a);

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void OQJDGLMFZAG(ILGARLMTLIL a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public interface ZOBSAMQYBCJ : XMNUJWTNKWA
	{
		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		HQJEVANLDBX<ILGARLMTLIL> YPBWGGNGYUQ
		{
			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		ILGARLMTLIL LJMNSADUXSG
		{
			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public interface HSAHZPQCFGB : CIEDVOAJZHM
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		(float, Vector3) LCLSHPOMJQI(Rigidbody a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public interface ABHMHWKRRPX : DRXZXIEZDHK, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		RRNetworkView FHJWQXSAXOB
		{
			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	internal sealed class PNJMGIALTWA : AWYAYARGVFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private readonly QBRSGAMKJKG QLJFUPCUZNR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private CollisionDetectionMode DPXNJPPAQNO;

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		private Rigidbody QGAIQBZDQPM
		{
			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0xA1888B0", Offset = "0xA1878B0", VA = "0x18A1888B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		public CollisionDetectionMode PKOXOCLHCPQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0xA188C80", Offset = "0xA187C80", VA = "0x18A188C80", Slot = "4")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0xA188C00", Offset = "0xA187C00", VA = "0x18A188C00", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0xA187800", Offset = "0xA186800", VA = "0x18A187800")]
		public PNJMGIALTWA(ILGARLMTLIL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0xA1887A0", Offset = "0xA1877A0", VA = "0x18A1887A0", Slot = "6")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0xA188A20", Offset = "0xA187A20", VA = "0x18A188A20", Slot = "9")]
		public void IHZDNEVHYFV(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0xA188C70", Offset = "0xA187C70", VA = "0x18A188C70", Slot = "7")]
		public void QPJYMBPXXZI(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0xA188D90", Offset = "0xA187D90", VA = "0x18A188D90", Slot = "8")]
		public void YZREATBQSJH(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0xA188AA0", Offset = "0xA187AA0", VA = "0x18A188AA0", Slot = "10")]
		public bool KHCQECXVRPI(Vector3 a, [Out] RaycastHit b, float c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0xA188900", Offset = "0xA187900", VA = "0x18A188900")]
		private void FIKBWTBUWEW(bool a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public sealed class JGADWCVWAKZ : AQNRDQHPPOU, IDisposable, KYTNRHJJHPE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly QBRSGAMKJKG QLJFUPCUZNR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private TransformTrackRate FZTLVHGXGLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private ROSSOIWDWST DFYHHNZGGZL;

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		public TransformTrackRate ICFISROOEQZ
		{
			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0xA1865E0", Offset = "0xA1855E0", VA = "0x18A1865E0", Slot = "6")]
			get
			{
				return default(TransformTrackRate);
			}
			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0xA186440", Offset = "0xA185440", VA = "0x18A186440", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000092")]
		private Transform TFMVZRKJFUS
		{
			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0xA186510", Offset = "0xA185510", VA = "0x18A186510", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000020")]
		public event Action<UpdateLOD, UpdateLOD> DNKGSBVGHEO
		{
			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0xA186390", Offset = "0xA185390", VA = "0x18A186390", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0xA186530", Offset = "0xA185530", VA = "0x18A186530", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0xA186730", Offset = "0xA185730", VA = "0x18A186730")]
		public JGADWCVWAKZ(ILGARLMTLIL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0xA1860D0", Offset = "0xA1850D0", VA = "0x18A1860D0", Slot = "8")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0xA186340", Offset = "0xA185340", VA = "0x18A186340", Slot = "9")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x13C9CF0", Offset = "0x13C8CF0", VA = "0x1813C9CF0", Slot = "11")]
		private void ZWWPDZPPHQF(UpdateLOD a, UpdateLOD b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "12")]
		private void SMLXRDTCDAJ(bool a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class EWHUFEIPACX : ZNKUBNNNAEW
	{
		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0xA181D20", Offset = "0xA180D20", VA = "0x18A181D20", Slot = "4")]
		public PRACVVKJIAD LJBPHJFVJJX(ILGARLMTLIL a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0xA181BA0", Offset = "0xA180BA0", VA = "0x18A181BA0", Slot = "5")]
		public LWHEDSVATFN JVFAAGUGYDT(ILGARLMTLIL a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0xA181940", Offset = "0xA180940", VA = "0x18A181940", Slot = "6")]
		public XMNUJWTNKWA EUVCNYGQDMG(ILGARLMTLIL a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0xA181CB0", Offset = "0xA180CB0", VA = "0x18A181CB0", Slot = "7")]
		public ZRIOIJCOPVP KXNPMKVEBIX(ILGARLMTLIL a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0xA1815E0", Offset = "0xA1805E0", VA = "0x18A1815E0", Slot = "8")]
		public IZKWDLOPYTF DKLDZAFRCWR(ILGARLMTLIL a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0xA182220", Offset = "0xA181220", VA = "0x18A182220", Slot = "9")]
		public AQNRDQHPPOU QGKREIFDPLU(ILGARLMTLIL a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0xA1822E0", Offset = "0xA1812E0", VA = "0x18A1822E0", Slot = "10")]
		public KFDCYDZXMDP TNLVDABXLOX(ILGARLMTLIL a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0xA1825D0", Offset = "0xA1815D0", VA = "0x18A1825D0", Slot = "11")]
		public FQHAKQFSQFJ XLMZZYYFSWF(ILGARLMTLIL a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0xA182510", Offset = "0xA181510", VA = "0x18A182510", Slot = "12")]
		public AWYAYARGVFF XHPANWDIPVX(ILGARLMTLIL a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0xA181E00", Offset = "0xA180E00", VA = "0x18A181E00", Slot = "13")]
		public YKWTOGHBMSK NQLREKTYZBS(ILGARLMTLIL a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0xA181A60", Offset = "0xA180A60", VA = "0x18A181A60")]
		public EXJBSVNRWPK QOLSQWLHWOS(ILGARLMTLIL a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0xA181770", Offset = "0xA180770", VA = "0x18A181770")]
		public DRXZXIEZDHK EGESNZFJBHM(ILGARLMTLIL a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0xA1823F0", Offset = "0xA1813F0", VA = "0x18A1823F0")]
		public PUTBWMRLSPY ZVNVDRVEXMU(ILGARLMTLIL a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0xA182090", Offset = "0xA181090", VA = "0x18A182090")]
		public CIEDVOAJZHM WBJXXPNKDUE(ILGARLMTLIL a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0xA1816A0", Offset = "0xA1806A0", VA = "0x18A1816A0")]
		public JBOJCWNYFZU ZRTWCXGWOHO(ILGARLMTLIL a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0xA181EC0", Offset = "0xA180EC0", VA = "0x18A181EC0", Slot = "19")]
		public ILGARLMTLIL NYRELCTHBHW(RigidbodyEx a, RigidbodyExData b, TKGZAEVETJO c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		public EWHUFEIPACX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0xA181A60", Offset = "0xA180A60", VA = "0x18A181A60", Slot = "14")]
		private EXJBSVNRWPK FHJWUYUFZTE(ILGARLMTLIL a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0xA181B90", Offset = "0xA180B90", VA = "0x18A181B90", Slot = "15")]
		private DRXZXIEZDHK HXYWATLHUGK(ILGARLMTLIL a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0xA1823F0", Offset = "0xA1813F0", VA = "0x18A1823F0", Slot = "16")]
		private PUTBWMRLSPY UKZEQAUWWLS(ILGARLMTLIL a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0xA182090", Offset = "0xA181090", VA = "0x18A182090", Slot = "17")]
		private CIEDVOAJZHM OFOPKGCITMU(ILGARLMTLIL a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0xA1816A0", Offset = "0xA1806A0", VA = "0x18A1816A0", Slot = "18")]
		private JBOJCWNYFZU EEJPCVTIMHW(ILGARLMTLIL a, [In] RigidbodyExData data)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal sealed class QVQPKYUROFQ : FQHAKQFSQFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private readonly QBRSGAMKJKG QLJFUPCUZNR;

		[Cpp2IlInjected.Token(Token = "0x17000093")]
		private Rigidbody QGAIQBZDQPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000268")]
			[Cpp2IlInjected.Address(RVA = "0xA1888B0", Offset = "0xA1878B0", VA = "0x18A1888B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000094")]
		private bool CJTZZJEKODZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000269")]
			[Cpp2IlInjected.Address(RVA = "0xA18F900", Offset = "0xA18E900", VA = "0x18A18F900")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000095")]
		private bool BWSTFYAYCNE
		{
			[Cpp2IlInjected.Token(Token = "0x600026A")]
			[Cpp2IlInjected.Address(RVA = "0xA17E5D0", Offset = "0xA17D5D0", VA = "0x18A17E5D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000096")]
		private ILGARLMTLIL QVPRBHQGWTI
		{
			[Cpp2IlInjected.Token(Token = "0x600026B")]
			[Cpp2IlInjected.Address(RVA = "0xA18F8A0", Offset = "0xA18E8A0", VA = "0x18A18F8A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0xA187800", Offset = "0xA186800", VA = "0x18A187800")]
		public QVQPKYUROFQ(ILGARLMTLIL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0xA18FE10", Offset = "0xA18EE10", VA = "0x18A18FE10", Slot = "4")]
		public void PBLSISEZSPW(Vector3 a, ForceMode b = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0xA18FBB0", Offset = "0xA18EBB0", VA = "0x18A18FBB0")]
		private void OIRYKHYNFNJ(Vector3 a, ForceMode b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0xA1901D0", Offset = "0xA18F1D0", VA = "0x18A1901D0", Slot = "5")]
		public void UYKXLVTRRUK(Vector3 a, Vector3 b, ForceMode c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0xA18F740", Offset = "0xA18E740", VA = "0x18A18F740", Slot = "6")]
		public void BDIEUJEHSCH(Vector3 a, ForceMode b = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0xA18FF70", Offset = "0xA18EF70", VA = "0x18A18FF70")]
		private void URJKBLIHSLM(Vector3 a, ForceMode b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0xA18F950", Offset = "0xA18E950", VA = "0x18A18F950", Slot = "7")]
		public void MIJHMKJFXDB(Vector3 a, ForceMode b = ForceMode.Force)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	internal sealed class LPMBPNALYTJ : YKWTOGHBMSK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private readonly QBRSGAMKJKG QLJFUPCUZNR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private bool DSSBCFBCUIZ;

		[Cpp2IlInjected.Token(Token = "0x17000097")]
		public bool DINTYYEPLEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000274")]
			[Cpp2IlInjected.Address(RVA = "0xEBB680", Offset = "0xEBA680", VA = "0x180EBB680", Slot = "4")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000275")]
			[Cpp2IlInjected.Address(RVA = "0xA187650", Offset = "0xA186650", VA = "0x18A187650", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0xA187800", Offset = "0xA186800", VA = "0x18A187800")]
		public LPMBPNALYTJ(ILGARLMTLIL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0xA187760", Offset = "0xA186760", VA = "0x18A187760", Slot = "6")]
		public void IHZDNEVHYFV(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0xA187790", Offset = "0xA186790", VA = "0x18A187790", Slot = "7")]
		public void JWUHDIYEPYE(Rigidbody a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	internal sealed class RbexHierarchy : COPNJISUQSG, PRACVVKJIAD, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private readonly ILGARLMTLIL QLJFUPCUZNR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private readonly List<ILGARLMTLIL> GGXQYPPXVSJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private ILGARLMTLIL DIIJJEHZBXI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private ILGARLMTLIL KPYZQONRQFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private Transform QUBNJTJENON;

		[Cpp2IlInjected.Token(Token = "0x17000098")]
		private Transform KXYMJCOORZI
		{
			[Cpp2IlInjected.Token(Token = "0x600028A")]
			[Cpp2IlInjected.Address(RVA = "0xA1919B0", Offset = "0xA1909B0", VA = "0x18A1919B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000099")]
		public ILGARLMTLIL QVPRBHQGWTI
		{
			[Cpp2IlInjected.Token(Token = "0x600028D")]
			[Cpp2IlInjected.Address(RVA = "0xCF7B60", Offset = "0xCF6B60", VA = "0x180CF7B60", Slot = "28")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600028E")]
			[Cpp2IlInjected.Address(RVA = "0xA190A70", Offset = "0xA18FA70", VA = "0x18A190A70", Slot = "29")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009A")]
		public ILGARLMTLIL OTBMMIANHVU
		{
			[Cpp2IlInjected.Token(Token = "0x600028F")]
			[Cpp2IlInjected.Address(RVA = "0xCF7BE0", Offset = "0xCF6BE0", VA = "0x180CF7BE0", Slot = "27")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		public IReadOnlyList<ILGARLMTLIL> EVCFLBUFVWC
		{
			[Cpp2IlInjected.Token(Token = "0x6000290")]
			[Cpp2IlInjected.Address(RVA = "0xCF7B90", Offset = "0xCF6B90", VA = "0x180CF7B90", Slot = "26")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000021")]
		public event RbexAction RFDAIXCOTNI
		{
			[Cpp2IlInjected.Token(Token = "0x6000278")]
			[Cpp2IlInjected.Address(RVA = "0xA1922C0", Offset = "0xA1912C0", VA = "0x18A1922C0", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000279")]
			[Cpp2IlInjected.Address(RVA = "0xA190BD0", Offset = "0xA18FBD0", VA = "0x18A190BD0", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000022")]
		public event RbexAction YCYGARIGOMI
		{
			[Cpp2IlInjected.Token(Token = "0x600027A")]
			[Cpp2IlInjected.Address(RVA = "0xA191C00", Offset = "0xA190C00", VA = "0x18A191C00", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600027B")]
			[Cpp2IlInjected.Address(RVA = "0xA190D20", Offset = "0xA18FD20", VA = "0x18A190D20", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000023")]
		public event RbexParentChangeAction HBQEEIXQNRM
		{
			[Cpp2IlInjected.Token(Token = "0x600027C")]
			[Cpp2IlInjected.Address(RVA = "0xA191B60", Offset = "0xA190B60", VA = "0x18A191B60", Slot = "12")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600027D")]
			[Cpp2IlInjected.Address(RVA = "0xA191060", Offset = "0xA190060", VA = "0x18A191060", Slot = "13")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000024")]
		public event Action PIOMRIICWRB
		{
			[Cpp2IlInjected.Token(Token = "0x600027E")]
			[Cpp2IlInjected.Address(RVA = "0xA190E70", Offset = "0xA18FE70", VA = "0x18A190E70", Slot = "14")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600027F")]
			[Cpp2IlInjected.Address(RVA = "0xA190A80", Offset = "0xA18FA80", VA = "0x18A190A80", Slot = "15")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000025")]
		public event Action EGXDKWAQZNC
		{
			[Cpp2IlInjected.Token(Token = "0x6000280")]
			[Cpp2IlInjected.Address(RVA = "0xA190720", Offset = "0xA18F720", VA = "0x18A190720", Slot = "16")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000281")]
			[Cpp2IlInjected.Address(RVA = "0xA191AC0", Offset = "0xA190AC0", VA = "0x18A191AC0", Slot = "17")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000026")]
		public event Action<ILGARLMTLIL> XDBXNBEFEMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000282")]
			[Cpp2IlInjected.Address(RVA = "0xA190C70", Offset = "0xA18FC70", VA = "0x18A190C70", Slot = "18")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000283")]
			[Cpp2IlInjected.Address(RVA = "0xA191A10", Offset = "0xA190A10", VA = "0x18A191A10", Slot = "19")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000027")]
		public event Action<ILGARLMTLIL> QHHBMTOPEPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000284")]
			[Cpp2IlInjected.Address(RVA = "0xA190F10", Offset = "0xA18FF10", VA = "0x18A190F10", Slot = "20")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000285")]
			[Cpp2IlInjected.Address(RVA = "0xA192210", Offset = "0xA191210", VA = "0x18A192210", Slot = "21")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000028")]
		public event Action MJVKWZLWMXX
		{
			[Cpp2IlInjected.Token(Token = "0x6000286")]
			[Cpp2IlInjected.Address(RVA = "0xA190FC0", Offset = "0xA18FFC0", VA = "0x18A190FC0", Slot = "22")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000287")]
			[Cpp2IlInjected.Address(RVA = "0xA192360", Offset = "0xA191360", VA = "0x18A192360", Slot = "23")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000029")]
		public event Action<ILGARLMTLIL> EMDEGWLRILI
		{
			[Cpp2IlInjected.Token(Token = "0x6000288")]
			[Cpp2IlInjected.Address(RVA = "0xA190DC0", Offset = "0xA18FDC0", VA = "0x18A190DC0", Slot = "24")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000289")]
			[Cpp2IlInjected.Address(RVA = "0xA190B20", Offset = "0xA18FB20", VA = "0x18A190B20", Slot = "25")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0xA1924F0", Offset = "0xA1914F0", VA = "0x18A1924F0")]
		public RbexHierarchy(ILGARLMTLIL rbex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0xA1909D0", Offset = "0xA18F9D0", VA = "0x18A1909D0", Slot = "31")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0xA191CA0", Offset = "0xA190CA0", VA = "0x18A191CA0", Slot = "30")]
		public void SetParent(ILGARLMTLIL newParent, bool isPhysicallyDetachedOnly = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0xA191740", Offset = "0xA190740", VA = "0x18A191740", Slot = "6")]
		public void OUIPXCJDSZR(ILGARLMTLIL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0xA1914C0", Offset = "0xA1904C0", VA = "0x18A1914C0", Slot = "7")]
		public void OQJDGLMFZAG(ILGARLMTLIL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0xA192400", Offset = "0xA191400", VA = "0x18A192400", Slot = "4")]
		public void ZGUAUCXGOAN(ILGARLMTLIL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0xA1907C0", Offset = "0xA18F7C0", VA = "0x18A1907C0", Slot = "5")]
		public void CFZBTFRSLGI(ILGARLMTLIL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0xA191420", Offset = "0xA190420", VA = "0x18A191420")]
		private void NPJSHJTNVQP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0xA190990", Offset = "0xA18F990", VA = "0x18A190990")]
		private void DUKEARLBIJA(ILGARLMTLIL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0xA1912E0", Offset = "0xA1902E0", VA = "0x18A1912E0")]
		private void MMUMOASDPZZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0xA190860", Offset = "0xA18F860", VA = "0x18A190860")]
		private void COVSUFPQOKY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0xA191100", Offset = "0xA190100", VA = "0x18A191100")]
		private void LAGSNGIOMWA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0xA191220", Offset = "0xA190220", VA = "0x18A191220")]
		[CompilerGenerated]
		private object MCWYYUTAGBA()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	internal static class OTFXQNSYYZO
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0xA1886E0", Offset = "0xA1876E0", VA = "0x18A1886E0")]
		public static COPNJISUQSG KVCRSTFFBFD(this ILGARLMTLIL a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	internal sealed class CZFAZFGHGXL : ZOBSAMQYBCJ, XMNUJWTNKWA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly QBRSGAMKJKG QLJFUPCUZNR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private readonly HQJEVANLDBX<ILGARLMTLIL> GSLXJTYELAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private bool KEYVMTWZRWR;

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		public HQJEVANLDBX<ILGARLMTLIL> YPBWGGNGYUQ
		{
			[Cpp2IlInjected.Token(Token = "0x600029D")]
			[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		public Vector3 KPUEMWVUONV
		{
			[Cpp2IlInjected.Token(Token = "0x600029E")]
			[Cpp2IlInjected.Address(RVA = "0xA17D5D0", Offset = "0xA17C5D0", VA = "0x18A17D5D0", Slot = "6")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		public Vector3 EFZQLSWLJCN
		{
			[Cpp2IlInjected.Token(Token = "0x600029F")]
			[Cpp2IlInjected.Address(RVA = "0xA17D660", Offset = "0xA17C660", VA = "0x18A17D660", Slot = "7")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		private Vector3 NPOJEZMRFSZ
		{
			[Cpp2IlInjected.Token(Token = "0x60002A3")]
			[Cpp2IlInjected.Address(RVA = "0xA17D150", Offset = "0xA17C150", VA = "0x18A17D150")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		public ILGARLMTLIL LJMNSADUXSG
		{
			[Cpp2IlInjected.Token(Token = "0x60002A4")]
			[Cpp2IlInjected.Address(RVA = "0xA17D0A0", Offset = "0xA17C0A0", VA = "0x18A17D0A0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0xA17DD70", Offset = "0xA17CD70", VA = "0x18A17DD70")]
		public CZFAZFGHGXL(ILGARLMTLIL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0xA17D960", Offset = "0xA17C960", VA = "0x18A17D960", Slot = "8")]
		public void UNXEEAKIKXP(ILGARLMTLIL a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0xA17D600", Offset = "0xA17C600", VA = "0x18A17D600", Slot = "9")]
		public void LVFFQDEAHPI(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0xA17D230", Offset = "0xA17C230", VA = "0x18A17D230")]
		private Vector3 INESKUIOCRR()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0xA17D9D0", Offset = "0xA17C9D0", VA = "0x18A17D9D0")]
		private void WWJQCBILCLK(ILGARLMTLIL a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	internal static class UDGUHZBLKHR
	{
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0xA197E30", Offset = "0xA196E30", VA = "0x18A197E30")]
		public static ZOBSAMQYBCJ CCTRXPGRNPU(this ILGARLMTLIL a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	internal sealed class ETTERVXDIXT : HSAHZPQCFGB, CIEDVOAJZHM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private readonly QBRSGAMKJKG QLJFUPCUZNR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private readonly OverridableVector3 BBZMKWXAZAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private readonly OverridableVector3 JUKXGKZANZT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private float WRWGMGGIKJX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private float VYAFBTREGZE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private Vector3 ZSIQEQSGKHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private Vector3? KSLYIJEFQZP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private Quaternion? FMLHZYXHKJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private bool OGXIILIFIVU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private bool VFDNXGAIXNR;

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		public Vector3 QWATCCKAWUR
		{
			[Cpp2IlInjected.Token(Token = "0x60002AA")]
			[Cpp2IlInjected.Address(RVA = "0x1EC49B0", Offset = "0x1EC39B0", VA = "0x181EC49B0", Slot = "7")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60002AB")]
			[Cpp2IlInjected.Address(RVA = "0xA17EDF0", Offset = "0xA17DDF0", VA = "0x18A17EDF0", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		public Vector3 PYREPYKMEKW
		{
			[Cpp2IlInjected.Token(Token = "0x60002AC")]
			[Cpp2IlInjected.Address(RVA = "0xA17F2A0", Offset = "0xA17E2A0", VA = "0x18A17F2A0", Slot = "9")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		public float HITIEXJSMXQ
		{
			[Cpp2IlInjected.Token(Token = "0x60002AD")]
			[Cpp2IlInjected.Address(RVA = "0xD47610", Offset = "0xD46610", VA = "0x180D47610", Slot = "10")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60002AE")]
			[Cpp2IlInjected.Address(RVA = "0xA180DA0", Offset = "0xA17FDA0", VA = "0x18A180DA0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A4")]
		public float CMCOQCCYGYB
		{
			[Cpp2IlInjected.Token(Token = "0x60002AF")]
			[Cpp2IlInjected.Address(RVA = "0xD47620", Offset = "0xD46620", VA = "0x180D47620", Slot = "11")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60002B0")]
			[Cpp2IlInjected.Address(RVA = "0xA180F50", Offset = "0xA17FF50", VA = "0x18A180F50", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		public Vector3 JUEZHWMACIJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002B1")]
			[Cpp2IlInjected.Address(RVA = "0xA180C10", Offset = "0xA17FC10", VA = "0x18A180C10", Slot = "13")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A6")]
		public Quaternion SKYLZADQFLB
		{
			[Cpp2IlInjected.Token(Token = "0x60002B2")]
			[Cpp2IlInjected.Address(RVA = "0xA17F4A0", Offset = "0xA17E4A0", VA = "0x18A17F4A0", Slot = "14")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A7")]
		private Rigidbody QGAIQBZDQPM
		{
			[Cpp2IlInjected.Token(Token = "0x60002BA")]
			[Cpp2IlInjected.Address(RVA = "0xA17F250", Offset = "0xA17E250", VA = "0x18A17F250")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400002A")]
		public event RbexAction YBHBWDHLFYU
		{
			[Cpp2IlInjected.Token(Token = "0x60002A8")]
			[Cpp2IlInjected.Address(RVA = "0xA1813E0", Offset = "0xA1803E0", VA = "0x18A1813E0", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60002A9")]
			[Cpp2IlInjected.Address(RVA = "0xA180EB0", Offset = "0xA17FEB0", VA = "0x18A180EB0", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0xA181480", Offset = "0xA180480", VA = "0x18A181480")]
		public ETTERVXDIXT(ILGARLMTLIL a, [In] RigidbodyExData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0xA181000", Offset = "0xA180000", VA = "0x18A181000", Slot = "17")]
		public void XUXWLKJZEML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0xA17F3C0", Offset = "0xA17E3C0", VA = "0x18A17F3C0", Slot = "16")]
		public void GQDGTNPRVDW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0xA17F620", Offset = "0xA17E620", VA = "0x18A17F620", Slot = "19")]
		public void IHZDNEVHYFV(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0xA17F700", Offset = "0xA17E700", VA = "0x18A17F700", Slot = "20")]
		public void JWUHDIYEPYE(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0xA181120", Offset = "0xA180120", VA = "0x18A181120", Slot = "18")]
		public void YRSYPIGFEEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0xA180750", Offset = "0xA17F750", VA = "0x18A180750", Slot = "21")]
		public void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0xA17EDF0", Offset = "0xA17DDF0", VA = "0x18A17EDF0")]
		private void XXISBHBZYJH(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0xA1812C0", Offset = "0xA1802C0", VA = "0x18A1812C0")]
		[Obsolete("This method is dangerous - the unity rigidbody is updated in a deferred manner and this world position may be stale")]
		private Vector3 YSYVLKIBJXE()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0xA180DA0", Offset = "0xA17FDA0", VA = "0x18A180DA0")]
		private void REHOGOSKVNY(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0xA180F50", Offset = "0xA17FF50", VA = "0x18A180F50")]
		private void UCONBFQTNCB(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0xA17EC50", Offset = "0xA17DC50", VA = "0x18A17EC50")]
		private Vector3 BFUWLMYCVYZ()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0xA17F020", Offset = "0xA17E020", VA = "0x18A17F020", Slot = "15")]
		public void DWBCFACUSMJ((Quaternion rot, Vector3 moments) tensor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0xA17EEA0", Offset = "0xA17DEA0", VA = "0x18A17EEA0")]
		private Quaternion DSMAWKYZKHB()
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0xA17F8E0", Offset = "0xA17E8E0", VA = "0x18A17F8E0")]
		public void LCLSHPOMJQI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0xA17F9B0", Offset = "0xA17E9B0", VA = "0x18A17F9B0", Slot = "4")]
		public (float, Vector3) LCLSHPOMJQI(Rigidbody a)
		{
			return default((float, Vector3));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	internal static class ZMFZQKHTSDZ
	{
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0xA198EF0", Offset = "0xA197EF0", VA = "0x18A198EF0")]
		public static HSAHZPQCFGB OCRWJDUTTSE(this ILGARLMTLIL a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	internal sealed class IMJYTDBHGNN : PUTBWMRLSPY
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private readonly QBRSGAMKJKG QLJFUPCUZNR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private readonly XIHSQHDZBEQ CQANITBOOTM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private readonly RbexInterpolationMode JCZORQRNVPN;

		[Cpp2IlInjected.Token(Token = "0x170000A8")]
		public bool QWKWDHFXMEL
		{
			[Cpp2IlInjected.Token(Token = "0x60002C5")]
			[Cpp2IlInjected.Address(RVA = "0x1B5B600", Offset = "0x1B5A600", VA = "0x181B5B600", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A9")]
		public RbexInterpolationMode PMVUTXWAKMV
		{
			[Cpp2IlInjected.Token(Token = "0x60002C6")]
			[Cpp2IlInjected.Address(RVA = "0xD066A0", Offset = "0xD056A0", VA = "0x180D066A0", Slot = "11")]
			get
			{
				return default(RbexInterpolationMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0xA185FE0", Offset = "0xA184FE0", VA = "0x18A185FE0")]
		public IMJYTDBHGNN(ILGARLMTLIL a, [In] RigidbodyExData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0xA185AE0", Offset = "0xA184AE0", VA = "0x18A185AE0", Slot = "4")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0xA185BB0", Offset = "0xA184BB0", VA = "0x18A185BB0")]
		private bool EHCVKKDVIFF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0xA185FB0", Offset = "0xA184FB0", VA = "0x18A185FB0", Slot = "5")]
		public void QGRINZJPHUZ(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0xA185C50", Offset = "0xA184C50", VA = "0x18A185C50", Slot = "6")]
		public void GDBFQMQWTEI(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0xA185E00", Offset = "0xA184E00", VA = "0x18A185E00", Slot = "9")]
		public void HZPTOSMOGNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0xA1859D0", Offset = "0xA1849D0", VA = "0x18A1859D0")]
		private void ATHFRONNUTR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0xA185C80", Offset = "0xA184C80", VA = "0x18A185C80")]
		private void HIMQDYXPGHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0xA185F30", Offset = "0xA184F30", VA = "0x18A185F30", Slot = "8")]
		public void LALXNOVDXQL(ILGARLMTLIL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0xA185F70", Offset = "0xA184F70", VA = "0x18A185F70", Slot = "7")]
		public void NHYFIDLAYRK(ILGARLMTLIL a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	internal sealed class EGJKEKIDIVG : KFDCYDZXMDP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private readonly QBRSGAMKJKG QLJFUPCUZNR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private readonly XIHSQHDZBEQ ZLYPJEPRQYJ;

		[Cpp2IlInjected.Token(Token = "0x170000AA")]
		public bool CJTZZJEKODZ
		{
			[Cpp2IlInjected.Token(Token = "0x60002D3")]
			[Cpp2IlInjected.Address(RVA = "0xA17EA20", Offset = "0xA17DA20", VA = "0x18A17EA20", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400002B")]
		public event RbexAction KUIMSZLTPKV
		{
			[Cpp2IlInjected.Token(Token = "0x60002D1")]
			[Cpp2IlInjected.Address(RVA = "0xA17EAD0", Offset = "0xA17DAD0", VA = "0x18A17EAD0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60002D2")]
			[Cpp2IlInjected.Address(RVA = "0xA17E770", Offset = "0xA17D770", VA = "0x18A17E770", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0xA17EB70", Offset = "0xA17DB70", VA = "0x18A17EB70")]
		public EGJKEKIDIVG(ILGARLMTLIL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0xA17E760", Offset = "0xA17D760", VA = "0x18A17E760", Slot = "7")]
		public void AJVUKMEXMLI(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0xA17E9E0", Offset = "0xA17D9E0", VA = "0x18A17E9E0", Slot = "8")]
		public void JBLBTIWABUL(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0xA17E810", Offset = "0xA17D810", VA = "0x18A17E810", Slot = "9")]
		public void EPPKXSKDCNZ(object a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0xA17E920", Offset = "0xA17D920", VA = "0x18A17E920", Slot = "12")]
		public void GVXKPNKUKBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0xA17E960", Offset = "0xA17D960", VA = "0x18A17E960", Slot = "10")]
		public void IHZDNEVHYFV(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0xA17E9F0", Offset = "0xA17D9F0", VA = "0x18A17E9F0", Slot = "11")]
		public void JWUHDIYEPYE(Rigidbody a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	internal sealed class VFKMJIXNYTT : ABHMHWKRRPX, DRXZXIEZDHK, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private WeakReference<ILGARLMTLIL> JOJZWSTQZGU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private readonly QBRSGAMKJKG QLJFUPCUZNR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private RRNetworkView DWLOMKPVJPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private bool TVQLUSYVBEU;

		[Cpp2IlInjected.Token(Token = "0x170000AB")]
		public RRNetworkView FHJWQXSAXOB
		{
			[Cpp2IlInjected.Token(Token = "0x60002DD")]
			[Cpp2IlInjected.Address(RVA = "0xCF4360", Offset = "0xCF3360", VA = "0x180CF4360", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AC")]
		public bool ACVKLIDTRQG
		{
			[Cpp2IlInjected.Token(Token = "0x60002DE")]
			[Cpp2IlInjected.Address(RVA = "0xA198640", Offset = "0xA197640", VA = "0x18A198640", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AD")]
		public bool MQPWBNLGCJW
		{
			[Cpp2IlInjected.Token(Token = "0x60002DF")]
			[Cpp2IlInjected.Address(RVA = "0xD4F720", Offset = "0xD4E720", VA = "0x180D4F720", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400002C")]
		public event RbexAction YRCPZMOVYQJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002DB")]
			[Cpp2IlInjected.Address(RVA = "0xA198880", Offset = "0xA197880", VA = "0x18A198880", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60002DC")]
			[Cpp2IlInjected.Address(RVA = "0xA1987E0", Offset = "0xA1977E0", VA = "0x18A1987E0", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0xA198CE0", Offset = "0xA197CE0", VA = "0x18A198CE0")]
		public VFKMJIXNYTT(ILGARLMTLIL a, [In] RigidbodyExData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0xA197EF0", Offset = "0xA196EF0", VA = "0x18A197EF0", Slot = "9")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0xA198310", Offset = "0xA197310", VA = "0x18A198310", Slot = "12")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0xA198650", Offset = "0xA197650", VA = "0x18A198650", Slot = "10")]
		public void HCDHOCLKZUG(ILGARLMTLIL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0xA198190", Offset = "0xA197190", VA = "0x18A198190", Slot = "11")]
		public void DWRDRQPSBAO(ILGARLMTLIL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0xA198020", Offset = "0xA197020", VA = "0x18A198020")]
		private void BGWDUHEOTIO(RRNetworkView a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0xA198B90", Offset = "0xA197B90", VA = "0x18A198B90")]
		private void ZVBXBCFKMAW(ZKNRSSQMNPD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0xA198920", Offset = "0xA197920", VA = "0x18A198920")]
		private void SZWXIUBMRWX(RRNetworkView a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	internal static class FFROYXZPZXN
	{
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0xA182690", Offset = "0xA181690", VA = "0x18A182690")]
		public static ABHMHWKRRPX Lifecycle(this ILGARLMTLIL impl)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	internal sealed class KQKGPATWOCN : JBOJCWNYFZU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private readonly QBRSGAMKJKG QLJFUPCUZNR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private RigidbodyConstraints YYBRRIZIJWS;

		[Cpp2IlInjected.Token(Token = "0x170000AE")]
		public bool NARFOTVPSDX
		{
			[Cpp2IlInjected.Token(Token = "0x60002E9")]
			[Cpp2IlInjected.Address(RVA = "0xE9D7B0", Offset = "0xE9C7B0", VA = "0x180E9D7B0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002EA")]
			[Cpp2IlInjected.Address(RVA = "0xED4590", Offset = "0xED3590", VA = "0x180ED4590", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AF")]
		public bool PRUMFNUXAHG
		{
			[Cpp2IlInjected.Token(Token = "0x60002EB")]
			[Cpp2IlInjected.Address(RVA = "0xED4680", Offset = "0xED3680", VA = "0x180ED4680", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002EC")]
			[Cpp2IlInjected.Address(RVA = "0xED4110", Offset = "0xED3110", VA = "0x180ED4110")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B0")]
		public RigidbodyConstraints JJZOSIQMEDE
		{
			[Cpp2IlInjected.Token(Token = "0x60002ED")]
			[Cpp2IlInjected.Address(RVA = "0xD01380", Offset = "0xD00380", VA = "0x180D01380", Slot = "7")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x60002EE")]
			[Cpp2IlInjected.Address(RVA = "0xA1867C0", Offset = "0xA1857C0", VA = "0x18A1867C0", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0xA186950", Offset = "0xA185950", VA = "0x18A186950")]
		public KQKGPATWOCN(ILGARLMTLIL a, [In] RigidbodyExData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0xA1868F0", Offset = "0xA1858F0", VA = "0x18A1868F0", Slot = "9")]
		public void IHZDNEVHYFV(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0xA186920", Offset = "0xA185920", VA = "0x18A186920", Slot = "10")]
		public void JWUHDIYEPYE(Rigidbody a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	internal sealed class HUKZEEUULJQ : ZRIOIJCOPVP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private readonly ILGARLMTLIL QLJFUPCUZNR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private float WKPKJJVEZZK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private float JWSCKCYXHZA;

		[Cpp2IlInjected.Token(Token = "0x170000B1")]
		public float HVINMNNTFXW
		{
			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0xD463B0", Offset = "0xD453B0", VA = "0x180D463B0", Slot = "4")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60002F4")]
			[Cpp2IlInjected.Address(RVA = "0xA182750", Offset = "0xA181750", VA = "0x18A182750", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B2")]
		public float KBOUNHVVUVU
		{
			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0xD45FE0", Offset = "0xD44FE0", VA = "0x180D45FE0", Slot = "6")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60002F6")]
			[Cpp2IlInjected.Address(RVA = "0xA182820", Offset = "0xA181820", VA = "0x18A182820", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0xA1829E0", Offset = "0xA1819E0", VA = "0x18A1829E0")]
		public HUKZEEUULJQ(ILGARLMTLIL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0xA1828F0", Offset = "0xA1818F0", VA = "0x18A1828F0", Slot = "8")]
		public void IHZDNEVHYFV(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0xA182940", Offset = "0xA181940", VA = "0x18A182940", Slot = "9")]
		public void JWUHDIYEPYE(Rigidbody a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	internal sealed class MFHOMBRDRIO : IZKWDLOPYTF
	{
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private static readonly Log IMXOTHIRIBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private readonly QBRSGAMKJKG QLJFUPCUZNR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private bool KJZCCLRPVMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private bool JHMOXWONLMQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private int EJFZIJPNLZG;

		[Cpp2IlInjected.Token(Token = "0x170000B3")]
		private Rigidbody QGAIQBZDQPM
		{
			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0xA17F250", Offset = "0xA17E250", VA = "0x18A17F250")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B4")]
		private bool IERYJHXJYYN
		{
			[Cpp2IlInjected.Token(Token = "0x60002FC")]
			[Cpp2IlInjected.Address(RVA = "0xA188030", Offset = "0xA187030", VA = "0x18A188030")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B5")]
		private ILGARLMTLIL QVPRBHQGWTI
		{
			[Cpp2IlInjected.Token(Token = "0x60002FD")]
			[Cpp2IlInjected.Address(RVA = "0xA187CF0", Offset = "0xA186CF0", VA = "0x18A187CF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B6")]
		private bool BWSTFYAYCNE
		{
			[Cpp2IlInjected.Token(Token = "0x60002FE")]
			[Cpp2IlInjected.Address(RVA = "0xA187FD0", Offset = "0xA186FD0", VA = "0x18A187FD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400002D")]
		public event RbexAction HOBOAEGMSHR
		{
			[Cpp2IlInjected.Token(Token = "0x60002F9")]
			[Cpp2IlInjected.Address(RVA = "0xA188260", Offset = "0xA187260", VA = "0x18A188260", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0xA187A20", Offset = "0xA186A20", VA = "0x18A187A20", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0xA188580", Offset = "0xA187580", VA = "0x18A188580")]
		public MFHOMBRDRIO(ILGARLMTLIL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0xA187990", Offset = "0xA186990", VA = "0x18A187990", Slot = "6")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0xA188050", Offset = "0xA187050", VA = "0x18A188050", Slot = "8")]
		public void RDWQBAFCVPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0xA188300", Offset = "0xA187300", VA = "0x18A188300", Slot = "7")]
		public bool XYSVULGKTGD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0xA188060", Offset = "0xA187060", VA = "0x18A188060", Slot = "9")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0xA188450", Offset = "0xA187450", VA = "0x18A188450", Slot = "13")]
		public void YNIOIMIDNQX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0xA188130", Offset = "0xA187130", VA = "0x18A188130", Slot = "12")]
		public void WCNCTSITEOG(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0xA187C80", Offset = "0xA186C80", VA = "0x18A187C80", Slot = "10")]
		public bool FBJPFDHSJPX()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0xA187EE0", Offset = "0xA186EE0", VA = "0x18A187EE0", Slot = "11")]
		public bool LNLETBLWCSY()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0xA187AC0", Offset = "0xA186AC0", VA = "0x18A187AC0")]
		private bool CNUZPUWTUDU()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0xA187D50", Offset = "0xA186D50", VA = "0x18A187D50")]
		private void LLJOMQAWENS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	internal sealed class DCEJJSXJFUD : EXJBSVNRWPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private readonly QBRSGAMKJKG QLJFUPCUZNR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private readonly XIHSQHDZBEQ EAKQZVSDEPZ;

		[Cpp2IlInjected.Token(Token = "0x170000B7")]
		public Rigidbody QGAIQBZDQPM
		{
			[Cpp2IlInjected.Token(Token = "0x600030B")]
			[Cpp2IlInjected.Address(RVA = "0xCF4150", Offset = "0xCF3150", VA = "0x180CF4150", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600030C")]
			[Cpp2IlInjected.Address(RVA = "0xCF4850", Offset = "0xCF3850", VA = "0x180CF4850")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B8")]
		private bool BWSTFYAYCNE
		{
			[Cpp2IlInjected.Token(Token = "0x600030D")]
			[Cpp2IlInjected.Address(RVA = "0xA17E5D0", Offset = "0xA17D5D0", VA = "0x18A17E5D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B9")]
		public bool MEMOCHUEAMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000310")]
			[Cpp2IlInjected.Address(RVA = "0x1B5B600", Offset = "0x1B5A600", VA = "0x181B5B600", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0xA17E660", Offset = "0xA17D660", VA = "0x18A17E660")]
		public DCEJJSXJFUD(ILGARLMTLIL a, [In] RigidbodyExData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0xA17DE60", Offset = "0xA17CE60", VA = "0x18A17DE60", Slot = "5")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0xA17E630", Offset = "0xA17D630", VA = "0x18A17E630", Slot = "7")]
		public void SAWLWTMEMXT(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0xA17E230", Offset = "0xA17D230", VA = "0x18A17E230", Slot = "8")]
		public void IVKHRDNGGAQ(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0xA17DF00", Offset = "0xA17CF00", VA = "0x18A17DF00", Slot = "9")]
		public void GLCHDSATOVP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0xA17E260", Offset = "0xA17D260", VA = "0x18A17E260", Slot = "10")]
		public void MLBTJJPMDNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0xA17E450", Offset = "0xA17D450", VA = "0x18A17E450", Slot = "11")]
		public void MMUIYIIOMHT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	internal sealed class ILZSJMFBTTO : LWHEDSVATFN, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private readonly QBRSGAMKJKG QLJFUPCUZNR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private readonly XIHSQHDZBEQ CZDYHOXJDNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private float DMZMMEEXBAR;

		[Cpp2IlInjected.Token(Token = "0x170000BA")]
		public PMLHAPSUBFJ TZXRMFIXXWE
		{
			[Cpp2IlInjected.Token(Token = "0x6000316")]
			[Cpp2IlInjected.Address(RVA = "0xCF4360", Offset = "0xCF3360", VA = "0x180CF4360", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000317")]
			[Cpp2IlInjected.Address(RVA = "0xCF4880", Offset = "0xCF3880", VA = "0x180CF4880", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		public BEZDMGXLQFQ ZWHTJXACTAP
		{
			[Cpp2IlInjected.Token(Token = "0x6000318")]
			[Cpp2IlInjected.Address(RVA = "0xCFC320", Offset = "0xCFB320", VA = "0x180CFC320", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000319")]
			[Cpp2IlInjected.Address(RVA = "0xD02500", Offset = "0xD01500", VA = "0x180D02500", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BC")]
		public Vector3 NPOJEZMRFSZ
		{
			[Cpp2IlInjected.Token(Token = "0x600031A")]
			[Cpp2IlInjected.Address(RVA = "0xA182D10", Offset = "0xA181D10", VA = "0x18A182D10", Slot = "8")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600031B")]
			[Cpp2IlInjected.Address(RVA = "0xA183660", Offset = "0xA182660", VA = "0x18A183660", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BD")]
		public Vector3 TUAHNIEKLNU
		{
			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(RVA = "0xA183350", Offset = "0xA182350", VA = "0x18A183350", Slot = "10")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600031D")]
			[Cpp2IlInjected.Address(RVA = "0xA182F30", Offset = "0xA181F30", VA = "0x18A182F30", Slot = "11")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BE")]
		public Vector3 UVVCXXROUBR
		{
			[Cpp2IlInjected.Token(Token = "0x600031E")]
			[Cpp2IlInjected.Address(RVA = "0xA183E20", Offset = "0xA182E20", VA = "0x18A183E20", Slot = "12")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600031F")]
			[Cpp2IlInjected.Address(RVA = "0xA184F90", Offset = "0xA183F90", VA = "0x18A184F90", Slot = "13")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BF")]
		public Vector3 DDZBNUOYPRY
		{
			[Cpp2IlInjected.Token(Token = "0x6000320")]
			[Cpp2IlInjected.Address(RVA = "0xA1839A0", Offset = "0xA1829A0", VA = "0x18A1839A0", Slot = "14")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0xA1830E0", Offset = "0xA1820E0", VA = "0x18A1830E0", Slot = "15")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C0")]
		public float CBLNIGZTQQF
		{
			[Cpp2IlInjected.Token(Token = "0x6000322")]
			[Cpp2IlInjected.Address(RVA = "0xD46190", Offset = "0xD45190", VA = "0x180D46190", Slot = "16")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000323")]
			[Cpp2IlInjected.Address(RVA = "0xA183110", Offset = "0xA182110", VA = "0x18A183110", Slot = "17")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C1")]
		public bool LEUQMXSJXOT
		{
			[Cpp2IlInjected.Token(Token = "0x6000324")]
			[Cpp2IlInjected.Address(RVA = "0x25E9CE0", Offset = "0x25E8CE0", VA = "0x1825E9CE0", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C2")]
		private FQHAKQFSQFJ DKLZZTPWCPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000339")]
			[Cpp2IlInjected.Address(RVA = "0x96B80D0", Offset = "0x96B70D0", VA = "0x1896B80D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C3")]
		private bool IERYJHXJYYN
		{
			[Cpp2IlInjected.Token(Token = "0x600033A")]
			[Cpp2IlInjected.Address(RVA = "0xA1845C0", Offset = "0xA1835C0", VA = "0x18A1845C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0xA1858F0", Offset = "0xA1848F0", VA = "0x18A1858F0")]
		public ILZSJMFBTTO(ILGARLMTLIL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0xA182C60", Offset = "0xA181C60", VA = "0x18A182C60", Slot = "19")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0xA182ED0", Offset = "0xA181ED0", VA = "0x18A182ED0", Slot = "36")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0xA183220", Offset = "0xA182220", VA = "0x18A183220", Slot = "28")]
		public void IHZDNEVHYFV(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x1905AF0", Offset = "0x1904AF0", VA = "0x181905AF0", Slot = "20")]
		public void JOVNNJUAIIF(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x1905DD0", Offset = "0x1904DD0", VA = "0x181905DD0", Slot = "30")]
		public void ORNEPLATWZO(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0xA1845E0", Offset = "0xA1835E0", VA = "0x18A1845E0", Slot = "35")]
		public Vector3 SOSROYBJVTL(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0xA1847C0", Offset = "0xA1837C0", VA = "0x18A1847C0", Slot = "34")]
		public Vector3 TJDRHKSWKNZ(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0xA182C60", Offset = "0xA181C60", VA = "0x18A182C60", Slot = "27")]
		public void GPQLSGJPULC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0xA184980", Offset = "0xA183980", VA = "0x18A184980", Slot = "25")]
		public void TZYMGPPEKXL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0xA183FE0", Offset = "0xA182FE0", VA = "0x18A183FE0", Slot = "24")]
		public void PSHYMKVXIOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0xA182A20", Offset = "0xA181A20", VA = "0x18A182A20", Slot = "33")]
		public void AGKDPXRROMM(Vector3 a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0xA1849E0", Offset = "0xA1839E0", VA = "0x18A1849E0", Slot = "32")]
		public void VYGUHRWBIYV(Vector3 a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0xA1854D0", Offset = "0xA1844D0", VA = "0x18A1854D0", Slot = "31")]
		public void XNAKEQYFVRC(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0xA184A40", Offset = "0xA183A40", VA = "0x18A184A40", Slot = "22")]
		public void WIAIVLVWCKS(RbexImpulseType a, Vector3 b, float c, float d = 8f, float e = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0xA185670", Offset = "0xA184670", VA = "0x18A185670", Slot = "21")]
		public void YMBLVAOKJWL(RbexRotationType a, Vector3 b, float c = 1f / 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0xA184040", Offset = "0xA183040", VA = "0x18A184040", Slot = "23")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void QNGFIYDHQAA(RbexRotationType a, Vector3 b, float c = 7f, float d = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x1A68E60", Offset = "0x1A67E60", VA = "0x181A68E60")]
		private static void WGPSHOYDPWA(Vector3 a, Vector3 b, [Out] Vector3 c, [Out] Vector3 d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0xA1838C0", Offset = "0xA1828C0", VA = "0x18A1838C0", Slot = "29")]
		public Vector3 KNPHONAZKOZ(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0xA184430", Offset = "0xA183430", VA = "0x18A184430", Slot = "26")]
		public void QQQFCCDEKHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0xA183110", Offset = "0xA182110", VA = "0x18A183110")]
		private void IDXFKKFGJVP(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0xA183720", Offset = "0xA182720", VA = "0x18A183720")]
		private void KGOAROCMFZT(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0xA182F60", Offset = "0xA181F60", VA = "0x18A182F60")]
		private Vector3 GFVYBPORWLI()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0xA183B30", Offset = "0xA182B30", VA = "0x18A183B30")]
		private void OHFACOIIHGS(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0xA1834D0", Offset = "0xA1824D0", VA = "0x18A1834D0")]
		private Vector3 ITPANRDLRGC()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0xA185050", Offset = "0xA184050", VA = "0x18A185050")]
		private void XHJBJREDTZY(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200")]
		private void INASJMJPCON(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200")]
		private void RNUALQNLVUL()
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
