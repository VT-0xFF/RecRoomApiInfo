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
		[Cpp2IlInjected.Address(RVA = "0xD1E1A0", Offset = "0xD1D5A0", VA = "0x180D1E1A0")]
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
		[Cpp2IlInjected.Address(RVA = "0xD1EAB0", Offset = "0xD1DEB0", VA = "0x180D1EAB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F5D520", Offset = "0x9F5C920", VA = "0x189F5D520", Slot = "4")]
		public override void GZVUEGYMGMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xD1E1A0", Offset = "0xD1D5A0", VA = "0x180D1E1A0")]
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
		private int[] YTBMQLWISIW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private ServiceBitset TSFXVIKPUMV;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xCF4CF0", Offset = "0xCF40F0", VA = "0x180CF4CF0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9949190", Offset = "0x9948590", VA = "0x189949190", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x9F6C570", Offset = "0x9F6B970", VA = "0x189F6C570")]
		private void BAZLOGTATAR(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9F6C850", Offset = "0x9F6BC50", VA = "0x189F6C850", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9F6C8B0", Offset = "0x9F6BCB0", VA = "0x189F6C8B0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[DisallowMultipleComponent]
	public sealed class RigidbodyEx : MonoBehaviour, BADBXNYBQWB, PBUFILHXHAU, RGDMHXKKORI
	{
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static readonly Log VPLHLYXUBLW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private bool BBOYPIEWWBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private URSPHDVDGTJ UZYCQQXLHCU;

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
		private Transform TDHCJORHWXG;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal URSPHDVDGTJ XWQAUKEGHCU
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x9F65070", Offset = "0x9F64470", VA = "0x189F65070")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private URSPHDVDGTJ FBPLOIEAOKS
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xCF4CF0", Offset = "0xCF40F0", VA = "0x180CF4CF0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int TKCSMZEOUVJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x9F66270", Offset = "0x9F65670", VA = "0x189F66270")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RigidbodyEx IGUVOHGOVRW
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x9F665D0", Offset = "0x9F659D0", VA = "0x189F665D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx XJMGIEKJBLY
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x9F66510", Offset = "0x9F65910", VA = "0x189F66510")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RigidbodyEx SYLHKQLEBTU
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x9F671E0", Offset = "0x9F665E0", VA = "0x189F671E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x9F68710", Offset = "0x9F67B10", VA = "0x189F68710")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool DidStart
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x92FB4D0", Offset = "0x92FA8D0", VA = "0x1892FB4D0", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x92FB620", Offset = "0x92FAA20", VA = "0x1892FB620")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Transform YMEIVUOXKZE
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x25F14F0", Offset = "0x25F08F0", VA = "0x1825F14F0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Transform LDQSLDZRTBT
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x25F14F0", Offset = "0x25F08F0", VA = "0x1825F14F0", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Transform MRSJCBHJEAB
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x25F14F0", Offset = "0x25F08F0", VA = "0x1825F14F0", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public TransformTrackRate QCZNQYUQAEZ
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x9F662D0", Offset = "0x9F656D0", VA = "0x189F662D0")]
			get
			{
				return default(TransformTrackRate);
			}
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x9F67EC0", Offset = "0x9F672C0", VA = "0x189F67EC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool QQGQFHDBUDE
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x9F668E0", Offset = "0x9F65CE0", VA = "0x189F668E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool TEVMYHHAXTG
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x9F663F0", Offset = "0x9F657F0", VA = "0x189F663F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public IDDHGUAZWOL TCXKPVMHZJW
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x9F66820", Offset = "0x9F65C20", VA = "0x189F66820")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x9F68080", Offset = "0x9F67480", VA = "0x189F68080")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public HFHEIEPYUFA ZNHTNHSXOAD
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x9F667C0", Offset = "0x9F65BC0", VA = "0x189F667C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x9F68010", Offset = "0x9F67410", VA = "0x189F68010")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool CLVBSNZWGIT
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x9F66710", Offset = "0x9F65B10", VA = "0x189F66710")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Rigidbody UKJPIVGVHRU
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x9F66770", Offset = "0x9F65B70", VA = "0x189F66770")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool ZTOQUWHHEFT
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x9F66450", Offset = "0x9F65850", VA = "0x189F66450")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x9F67F30", Offset = "0x9F67330", VA = "0x189F67F30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool JEIMMTHXRHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x1A0F320", Offset = "0x1A0E720", VA = "0x181A0F320", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float LQOIEFXMXNQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x9F67180", Offset = "0x9F66580", VA = "0x189F67180")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float KOAWXTYFLLP
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x9F67120", Offset = "0x9F66520", VA = "0x189F67120")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x9F686A0", Offset = "0x9F67AA0", VA = "0x189F686A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public float AIDOFLHDHLO
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x9F66B40", Offset = "0x9F65F40", VA = "0x189F66B40")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x9F68320", Offset = "0x9F67720", VA = "0x189F68320")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public float RLQAQJMXMAO
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x9F66940", Offset = "0x9F65D40", VA = "0x189F66940")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x9F680F0", Offset = "0x9F674F0", VA = "0x189F680F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public bool FKDMYJKUUVP
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x9F67760", Offset = "0x9F66B60", VA = "0x189F67760")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x9F68C50", Offset = "0x9F68050", VA = "0x189F68C50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Vector3 WYZIWYNDWRP
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x9F66F00", Offset = "0x9F66300", VA = "0x189F66F00")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x9F68470", Offset = "0x9F67870", VA = "0x189F68470")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public Vector3 MQDRZQVTKXM
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x9F678A0", Offset = "0x9F66CA0", VA = "0x189F678A0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public CollisionDetectionMode RHYLCKRMWPA
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x9F66A80", Offset = "0x9F65E80", VA = "0x189F66A80")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x9F68240", Offset = "0x9F67640", VA = "0x189F68240")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public float UFRAKQYPUVL
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x9F664B0", Offset = "0x9F658B0", VA = "0x189F664B0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x9F67FA0", Offset = "0x9F673A0", VA = "0x189F67FA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public RigidbodyConstraints OLYLXFTGWLE
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x9F66AE0", Offset = "0x9F65EE0", VA = "0x189F66AE0")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x9F682B0", Offset = "0x9F676B0", VA = "0x189F682B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public Vector3 EFKYJHFZPKU
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x9F672A0", Offset = "0x9F666A0", VA = "0x189F672A0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public Vector3 FSHRPVIFDCM
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x9F672A0", Offset = "0x9F666A0", VA = "0x189F672A0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x9F68A30", Offset = "0x9F67E30", VA = "0x189F68A30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public float WEHSCOVAWKH
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x9F66FE0", Offset = "0x9F663E0", VA = "0x189F66FE0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x9F68550", Offset = "0x9F67950", VA = "0x189F68550")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public float TKXGVSEIFOI
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x9F67700", Offset = "0x9F66B00", VA = "0x189F67700")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x9F68BE0", Offset = "0x9F67FE0", VA = "0x189F68BE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Quaternion MWVEAHNZIYJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x9F67380", Offset = "0x9F66780", VA = "0x189F67380")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x9F687B0", Offset = "0x9F67BB0", VA = "0x189F687B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Quaternion JKNJTITRJVL
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x9F67620", Offset = "0x9F66A20", VA = "0x189F67620")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x9F68B10", Offset = "0x9F67F10", VA = "0x189F68B10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector3 NRQLMTBCYFP
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x9F67460", Offset = "0x9F66860", VA = "0x189F67460")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x9F68880", Offset = "0x9F67C80", VA = "0x189F68880")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Quaternion HMELNEALCUE
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x9F67540", Offset = "0x9F66940", VA = "0x189F67540")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x9F68960", Offset = "0x9F67D60", VA = "0x189F68960")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 JEFEUIESVAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x9F677C0", Offset = "0x9F66BC0", VA = "0x189F677C0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x9F68CC0", Offset = "0x9F680C0", VA = "0x189F68CC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 MCIFGUIFCXE
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x9F67040", Offset = "0x9F66440", VA = "0x189F67040")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x9F685C0", Offset = "0x9F679C0", VA = "0x189F685C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector3 XUAGLHGFZQT
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x9F669A0", Offset = "0x9F65DA0", VA = "0x189F669A0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x9F68160", Offset = "0x9F67560", VA = "0x189F68160")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector3 XQYZVDQYFZI
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x9F66E20", Offset = "0x9F66220", VA = "0x189F66E20")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x9F68390", Offset = "0x9F67790", VA = "0x189F68390")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector3 UPRIQFVYQFX
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x9F66CE0", Offset = "0x9F660E0", VA = "0x189F66CE0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Quaternion MCRBBJQTDFF
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x9F66C00", Offset = "0x9F66000", VA = "0x189F66C00")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public Vector3 OSIHQXWWFCP
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x9F67A60", Offset = "0x9F66E60", VA = "0x189F67A60")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public Vector3 SRSOVTEGNGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x9F67980", Offset = "0x9F66D80", VA = "0x189F67980")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool UNUXDVITQTB
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x9F66DC0", Offset = "0x9F661C0", VA = "0x189F66DC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool ENFNEUIDCAI
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x9F66880", Offset = "0x9F65C80", VA = "0x189F66880")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool LJTWWDLRETB
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x9F66390", Offset = "0x9F65790", VA = "0x189F66390")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool NFKODNJSAYS
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x9F66330", Offset = "0x9F65730", VA = "0x189F66330")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool WVXPRIINAUP
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x9F66210", Offset = "0x9F65610", VA = "0x189F66210")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public bool WSZZRFGJWLY
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x9F66BA0", Offset = "0x9F65FA0", VA = "0x189F66BA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool GVLREYKWGTW
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xE359D0", Offset = "0xE34DD0", VA = "0x180E359D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event RbexParentChangeAction BSSUEKPCIBU
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x9F66130", Offset = "0x9F65530", VA = "0x189F66130")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x9F67DE0", Offset = "0x9F671E0", VA = "0x189F67DE0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event RbexAction COPKXASEFFY
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x9F65EA0", Offset = "0x9F652A0", VA = "0x189F65EA0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x9F67B40", Offset = "0x9F66F40", VA = "0x189F67B40")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event RbexAction MYFHZKLSRBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x9F65F00", Offset = "0x9F65300", VA = "0x189F65F00")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x9F67BB0", Offset = "0x9F66FB0", VA = "0x189F67BB0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event RbexAction QYWHYAAAICM
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x9F66050", Offset = "0x9F65450", VA = "0x189F66050")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x9F67D00", Offset = "0x9F67100", VA = "0x189F67D00")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<UpdateLOD, UpdateLOD> BXAALPDQGDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x9F65FE0", Offset = "0x9F653E0", VA = "0x189F65FE0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x9F67C90", Offset = "0x9F67090", VA = "0x189F67C90")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event RbexAction BKZQJYFTCPJ
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x9F660C0", Offset = "0x9F654C0", VA = "0x189F660C0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x9F67D70", Offset = "0x9F67170", VA = "0x189F67D70")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event RbexAction OKSHCUZQSSZ
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x9F661A0", Offset = "0x9F655A0", VA = "0x189F661A0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x9F67E50", Offset = "0x9F67250", VA = "0x189F67E50")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event RbexAction QYASUSYRLHO
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x9F65F70", Offset = "0x9F65370", VA = "0x189F65F70")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x9F67C20", Offset = "0x9F67020", VA = "0x189F67C20")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xCF6640", Offset = "0xCF5A40", VA = "0x180CF6640", Slot = "8")]
		private void ZWTCJUKJTNA(URSPHDVDGTJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x9F64880", Offset = "0x9F63C80", VA = "0x189F64880", Slot = "9")]
		public RigidbodyExData GetData()
		{
			return default(RigidbodyExData);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9F64910", Offset = "0x9F63D10", VA = "0x189F64910")]
		internal void ISWLUXFUUAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x9F65BD0", Offset = "0x9F64FD0", VA = "0x189F65BD0")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public void TestOverrideUnityRigidbody(Rigidbody rb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9F645D0", Offset = "0x9F639D0", VA = "0x189F645D0")]
		public BADBXNYBQWB GetChild(int index)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x9F65890", Offset = "0x9F64C90", VA = "0x189F65890")]
		public void SetInertiaTensor((Quaternion rot, Vector3 moments) tensor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x9F64220", Offset = "0x9F63620", VA = "0x189F64220")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x9F65B20", Offset = "0x9F64F20", VA = "0x189F65B20")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x9F65070", Offset = "0x9F64470", VA = "0x189F65070")]
		private URSPHDVDGTJ YLJKGRIENSA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x9F64D70", Offset = "0x9F64170", VA = "0x189F64D70")]
		private void ORLMZSMEYLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x9F64FB0", Offset = "0x9F643B0", VA = "0x189F64FB0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x9F64EF0", Offset = "0x9F642F0", VA = "0x189F64EF0")]
		public void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x9F64910", Offset = "0x9F63D10", VA = "0x189F64910")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x9F64F50", Offset = "0x9F64350", VA = "0x189F64F50")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x9F65010", Offset = "0x9F64410", VA = "0x189F65010")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x9F638D0", Offset = "0x9F62CD0", VA = "0x189F638D0")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x9F65120", Offset = "0x9F64520", VA = "0x189F65120")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x9F64570", Offset = "0x9F63970", VA = "0x189F64570")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x9F64D10", Offset = "0x9F64110", VA = "0x189F64D10")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x9F659F0", Offset = "0x9F64DF0", VA = "0x189F659F0")]
		public void SetParent(RigidbodyEx value, bool isPhysicallyDetachedOnly = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x9F65430", Offset = "0x9F64830", VA = "0x189F65430")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x9F649A0", Offset = "0x9F63DA0", VA = "0x189F649A0")]
		public bool IsRigidbodyAncestor(RigidbodyEx possibleAncestor)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x9F64AA0", Offset = "0x9F63EA0", VA = "0x189F64AA0")]
		public bool IsRigidbodyDescendant(RigidbodyEx possibleDescendant)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x9F63B40", Offset = "0x9F62F40", VA = "0x189F63B40")]
		public void AddInterpolationRestriction(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x9F65190", Offset = "0x9F64590", VA = "0x189F65190")]
		public void RemoveInterpolationRestriction(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x9F63BB0", Offset = "0x9F62FB0", VA = "0x189F63BB0")]
		public void AddKinematic(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x9F65200", Offset = "0x9F64600", VA = "0x189F65200")]
		public void RemoveKinematic(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x9F65970", Offset = "0x9F64D70", VA = "0x189F65970")]
		public void SetKinematic(object token, bool setKinematic)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x9F65790", Offset = "0x9F64B90", VA = "0x189F65790")]
		public void SetDiscontinuousPositionAndRotation(Vector3 newPosition, Quaternion newRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x9F65690", Offset = "0x9F64A90", VA = "0x189F65690")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 newLocalPosition, Quaternion newLocalRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x9F64770", Offset = "0x9F63B70", VA = "0x189F64770")]
		public Vector3 GetConstrainedVelocity(Vector3 velocity)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x9F64660", Offset = "0x9F63A60", VA = "0x189F64660")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 angularVelocity)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x9F63A50", Offset = "0x9F62E50", VA = "0x189F63A50")]
		public void AddForce(Vector3 force, ForceMode forceMode = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x9F63940", Offset = "0x9F62D40", VA = "0x189F63940")]
		public void AddForceAtPosition(Vector3 force, Vector3 position, ForceMode forceMode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x9F63D80", Offset = "0x9F63180", VA = "0x189F63D80")]
		public void AddTorque(Vector3 torque, ForceMode forceMode = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x9F63C20", Offset = "0x9F63020", VA = "0x189F63C20")]
		public void AddRelativeTorque(Vector3 torque, ForceMode forceMode = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x9F65CA0", Offset = "0x9F650A0", VA = "0x189F65CA0")]
		public Vector3 WorldToLocalVelocity(Vector3 worldVelocity)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x9F64C00", Offset = "0x9F64000", VA = "0x189F64C00")]
		public Vector3 LocalToWorldVelocity(Vector3 localVelocity)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x9F64510", Offset = "0x9F63910", VA = "0x189F64510")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x9F644B0", Offset = "0x9F638B0", VA = "0x189F644B0")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x9F64450", Offset = "0x9F63850", VA = "0x189F64450")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x9F643F0", Offset = "0x9F637F0", VA = "0x189F643F0")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x9F65590", Offset = "0x9F64990", VA = "0x189F65590")]
		public void ResetVelocityWorldSpace(Vector3 worldLinearVelocity, Vector3 worldAngularVelocity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x9F65490", Offset = "0x9F64890", VA = "0x189F65490")]
		public void ResetVelocityLocalSpace(Vector3 localLinearVelocity, Vector3 localAngularVelocity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x9F65350", Offset = "0x9F64750", VA = "0x189F65350")]
		public void ResetLinearVelocityLocalSpace(Vector3 localLinearVelocity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x9F65B30", Offset = "0x9F64F30", VA = "0x189F65B30")]
		public bool SweepTest(Vector3 direction, [Out] RaycastHit hitInfo, float maxDistance)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x9F64BA0", Offset = "0x9F63FA0", VA = "0x189F64BA0")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x9F65AC0", Offset = "0x9F64EC0", VA = "0x189F65AC0")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x9F65C40", Offset = "0x9F65040", VA = "0x189F65C40")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x9F63D10", Offset = "0x9F63110", VA = "0x189F63D10")]
		public void AddShouldHaveUnityRigidbodyToken(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x9F65270", Offset = "0x9F64670", VA = "0x189F65270")]
		public void RemoveShouldHaveUnityRigidbodyToken(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x9F640B0", Offset = "0x9F634B0", VA = "0x189F640B0")]
		public void ApplyForceVelocityChange(RbexImpulseType impulseType, Vector3 impulseDirection, float impulseSpeed, float impulseDirectionMaxSpeed = 8f, float impulseReflectiveRestitution = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x9F64010", Offset = "0x9F63410", VA = "0x189F64010")]
		public void ApplyAngularVelocityChange(RbexRotationType rotationType, Vector3 newAngularVelocity, float maxAngularSpeed = 1f / 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x9F64170", Offset = "0x9F63570", VA = "0x189F64170")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void ApplyTorqueAngularVelocityChangeDeprecated(RbexRotationType rotationType, Vector3 rotation, float maxSpeed = 7f, float multiplyingFactor = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x9F63F40", Offset = "0x9F63340", VA = "0x189F63F40")]
		public bool AllowedScaleChange(float scaleFactor)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x9F63E70", Offset = "0x9F63270", VA = "0x189F63E70")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx parentOverride, object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x9F652E0", Offset = "0x9F646E0", VA = "0x189F652E0")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x8B97950", Offset = "0x8B96D50", VA = "0x188B97950", Slot = "13")]
		private void FFHAUBOMLON(QTUEFTEFCXF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x9F65E30", Offset = "0x9F65230", VA = "0x189F65E30")]
		public RigidbodyEx()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x15166E0", Offset = "0x1515AE0", VA = "0x1815166E0", Slot = "4")]
		private GameObject CQOTFVBLUYM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0xD214F0", Offset = "0xD208F0", VA = "0x180D214F0", Slot = "10")]
		private bool XZHRBZXTEGD()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	internal static class RIYINFRWSFI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x9F617C0", Offset = "0x9F60BC0", VA = "0x189F617C0")]
		public static URSPHDVDGTJ XWQAUKEGHCU(this RigidbodyEx a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[RegisterService(typeof(OPDVASMXSSY), new string[] { })]
	public class RigidbodyExManager : OPDVASMXSSY, HWCJESQYILK
	{
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static readonly Log GLGEGNAUXIQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private EVAKBSJADID YTLVACUUSYW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private MYDEZSBGEEG WJZFJWJSJCQ;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public EVAKBSJADID YGWTEAVAHFA
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xCF4CE0", Offset = "0xCF40E0", VA = "0x180CF4CE0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public MYDEZSBGEEG HGTGDDQFQXK
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x9F637E0", Offset = "0x9F62BE0", VA = "0x189F637E0", Slot = "7")]
		public void InitReferences(GEZRGCKOUXX services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x9F636B0", Offset = "0x9F62AB0", VA = "0x189F636B0", Slot = "6")]
		public URSPHDVDGTJ EKPKRACEEQA(RigidbodyEx a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
		public RigidbodyExManager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class PhysicsManager : SingletonMonoBehaviour<PhysicsManager>
	{
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static PZVGSBFXRHS UpdateAfterFixedUpdateRan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private int FBPERMILXTU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private int RLPDWVYHMIO;

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x9F5E6C0", Offset = "0x9F5DAC0", VA = "0x189F5E6C0")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x9F5E740", Offset = "0x9F5DB40", VA = "0x189F5E740")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x9F5E6E0", Offset = "0x9F5DAE0", VA = "0x189F5E6E0")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string message, [Optional] UnityEngine.Object context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string message, [Optional] UnityEngine.Object context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x9F5E830", Offset = "0x9F5DC30", VA = "0x189F5E830")]
		public PhysicsManager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public static class AVWBHNNYUOS
	{
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		private class TPEGEJLSQLA : IDDHGUAZWOL, IDisposable
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190", Slot = "7")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0xD044D0", Offset = "0xD038D0", VA = "0x180D044D0", Slot = "4")]
			public Vector3 QHAFLHJFCIX()
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0xD044D0", Offset = "0xD038D0", VA = "0x180D044D0", Slot = "5")]
			public Vector3 WCWRMZQLNKC()
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0xD0EDD0", Offset = "0xD0E1D0", VA = "0x180D0EDD0", Slot = "6")]
			public bool MWZNKBFZGMR(float a, float b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
			public TPEGEJLSQLA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public static IDDHGUAZWOL IBFUSALODBN
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x9F50CD0", Offset = "0x9F500D0", VA = "0x189F50CD0")]
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
	public interface TOMRCQCGWKH
	{
		[Cpp2IlInjected.Token(Token = "0x17000039")]
		CollisionDetectionMode JWOHTRHZZLU
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
		void QUPLSZBKCRM(bool a);

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void KFIVMTRDQVX(bool a);

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void ZBCMDVSWGQP(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool GRVHXKANIBA(Vector3 a, [Out] RaycastHit b, float c);
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public interface XPXLOPDNHII : IDisposable, GZDKSJNECPI
	{
		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		TransformTrackRate QCZNQYUQAEZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		event Action<UpdateLOD, UpdateLOD> BXAALPDQGDE;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void Awake();
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[ServiceLifetime(Lifetime.Application)]
	public interface MYDEZSBGEEG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		ABPPNKWDZXB URSPQFYGSZT(URSPHDVDGTJ a);

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		NZIHUDSLPRV TXRWDFGBGXD(URSPHDVDGTJ a);

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		VPNGXOBPVYY TLPAMXSEGLM(URSPHDVDGTJ a);

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		EFZVBULSGCJ NQONRMJFFZN(URSPHDVDGTJ a);

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "4")]
		JFQQXKOPLDR XTMJCFVQWAN(URSPHDVDGTJ a);

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "5")]
		XPXLOPDNHII WOHOHQXNURM(URSPHDVDGTJ a);

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "6")]
		JVJSTMHLGZD DTEAOWNWXTV(URSPHDVDGTJ a);

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "7")]
		EMYFGMLRIFJ NPDGCKFPWER(URSPHDVDGTJ a);

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "8")]
		TOMRCQCGWKH JDWUFTKMSOZ(URSPHDVDGTJ a);

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "9")]
		JXLAABBVTVI QDCOUTBULTO(URSPHDVDGTJ a);

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "10")]
		AZNEFAUWREM YUUNSESZEPY(URSPHDVDGTJ a, [In] RigidbodyExData data);

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "11")]
		BWVLOWJRLEQ ZJAJRYRMEFU(URSPHDVDGTJ a, [In] RigidbodyExData data);

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "12")]
		VJJVLNKTDOW ZMCPLNJXWZW(URSPHDVDGTJ a, [In] RigidbodyExData data);

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "13")]
		RZCYDGGXVUS JHKWAWZARKI(URSPHDVDGTJ a, [In] RigidbodyExData data);

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "14")]
		DKRIBMSIRNE UVHXTBCZQRS(URSPHDVDGTJ a, [In] RigidbodyExData data);

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "15")]
		URSPHDVDGTJ EKPKRACEEQA(RigidbodyEx a, RigidbodyExData b, OPDVASMXSSY c);
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface EMYFGMLRIFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void VDGXJVZKGKI(Vector3 a, ForceMode b = ForceMode.Force);

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void BGTRYJZWPHE(Vector3 a, Vector3 b, ForceMode c);

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void QQSLCNPDDQP(Vector3 a, ForceMode b = ForceMode.Force);

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void VNPXAONKXLR(Vector3 a, ForceMode b = ForceMode.Force);
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface JXLAABBVTVI
	{
		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		bool TRPLMMZBLYN
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
		void ZBCMDVSWGQP(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void JWZEKUEJHXO(Rigidbody a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public interface ABPPNKWDZXB : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		IReadOnlyList<URSPHDVDGTJ> WOFKEUEZLJU
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(Slot = "18")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		URSPHDVDGTJ XJMGIEKJBLY
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(Slot = "19")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		URSPHDVDGTJ RSMFOCGSZZY
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(Slot = "20")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(Slot = "21")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		event RbexAction COPKXASEFFY;

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		event RbexAction MYFHZKLSRBC;

		[Cpp2IlInjected.Token(Token = "0x1400000C")]
		event RbexParentChangeAction JAEYTIJGLAG;

		[Cpp2IlInjected.Token(Token = "0x1400000D")]
		event Action TORRDFBLPPB;

		[Cpp2IlInjected.Token(Token = "0x1400000E")]
		event Action VCDIKENNUZO;

		[Cpp2IlInjected.Token(Token = "0x1400000F")]
		event Action<URSPHDVDGTJ> FCWXFXQEDMF;

		[Cpp2IlInjected.Token(Token = "0x14000010")]
		event Action<URSPHDVDGTJ> QPNPXLRWCES;

		[Cpp2IlInjected.Token(Token = "0x14000011")]
		event Action BBNVYUXPUMF;

		[Cpp2IlInjected.Token(Token = "0x14000012")]
		event Action<URSPHDVDGTJ> MNONELUVLOW;

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "22")]
		void SetParent(URSPHDVDGTJ newParent, bool isPhysicallyDetachedOnly = false);
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public interface VPNGXOBPVYY
	{
		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		Vector3 JZZYNRWBPXN
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		Vector3 UZNZHILDYRD
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void PNWPTSAFJLL(URSPHDVDGTJ a, object b);

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void LVZUSSWPSNQ(object a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public interface RZCYDGGXVUS
	{
		[Cpp2IlInjected.Token(Token = "0x17000041")]
		Vector3 WXMWEVLVNUV
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		Vector3 PKWVFPLEWLM
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		float SQQIWIVUCOK
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		float WHJFJKCEHYV
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(Slot = "7")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		Vector3 NQODOFXJIWV
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		Quaternion NESEJZXJPKT
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000013")]
		event RbexAction AOMHBEHBMLS;

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void QVIPLBOFWLD((Quaternion rot, Vector3 moments) tensor);

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(Slot = "11")]
		void QCPAGHHOMSE();

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void KUIGOHPFLWT();

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(Slot = "13")]
		void EECWJYCHWKJ();

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void ZBCMDVSWGQP(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void JWZEKUEJHXO(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void OnDrawGizmosSelected();
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public interface VJJVLNKTDOW
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Awake();

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void QIKEGXHTJJX(object a);

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void SXPFMUAIOMU(object a);

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void TKMJFWJBDSE(URSPHDVDGTJ a);

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void KETPIUNEXJR(URSPHDVDGTJ a);

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void NOLZQXVWIMA();
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public interface JVJSTMHLGZD
	{
		[Cpp2IlInjected.Token(Token = "0x17000047")]
		bool LWUMTMYRXWH
		{
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000014")]
		event RbexAction IOOCVNZBWFT;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void EKKZDFDBKWK(object a);

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void WLCJKINUTIT(object a);

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void FMZHQWGRYSH(object a, bool b);

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void ZBCMDVSWGQP(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void JWZEKUEJHXO(Rigidbody a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface BWVLOWJRLEQ : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000048")]
		bool QQGQFHDBUDE
		{
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		bool TEVMYHHAXTG
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000015")]
		event RbexAction DAJDWHQDOUR;

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void Awake();

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void YFOGLRQIOTE(URSPHDVDGTJ a);

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void LTSBDDIITSK(URSPHDVDGTJ a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface DKRIBMSIRNE
	{
		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		bool ZTOQUWHHEFT
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		bool KBYNDOZILSM
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		RigidbodyConstraints GVDBGMOMEPE
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
		void ZBCMDVSWGQP(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void JWZEKUEJHXO(Rigidbody a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface EFZVBULSGCJ
	{
		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		float YNUGNPYEIYA
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		float EBLRXHYHGAG
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
		void ZBCMDVSWGQP(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void JWZEKUEJHXO(Rigidbody a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public interface JFQQXKOPLDR
	{
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		static bool YOQTJGCZOKX;

		[Cpp2IlInjected.Token(Token = "0x14000016")]
		event RbexAction BMPSQLCPXWX;

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void Awake();

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool TCSXBWLBQPF();

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void GGJCWZZXMSV();

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void Sleep();

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool RLNIMMFDKAJ();

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool LMUWTHBKLVO();

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void WPKCIMBMHZM(bool a);

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void HOZHVLOULRV();
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public interface AZNEFAUWREM
	{
		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		Rigidbody UKJPIVGVHRU
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		bool KACYWKWXBTV
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
		void PXCFFWKOAEJ(object a);

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void UXGPABDHEWM(object a);

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void BTZHJVAQAZP();
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public interface NZIHUDSLPRV : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000051")]
		IDDHGUAZWOL TCXKPVMHZJW
		{
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		HFHEIEPYUFA ZNHTNHSXOAD
		{
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		Vector3 QXERQLBXURP
		{
			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(Slot = "5")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		Vector3 XNWSMOJCOQS
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(Slot = "7")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		Vector3 HGAQXEXIGYL
		{
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(Slot = "9")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		Vector3 QDWNSCUTQZE
		{
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(Slot = "11")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		float UFRAKQYPUVL
		{
			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(Slot = "13")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		bool CLVBSNZWGIT
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
		void JZKAWCHVOJD(object a);

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(Slot = "17")]
		void GRQHAZMWWHF(RbexRotationType a, Vector3 b, float c = 1f / 0f);

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(Slot = "18")]
		void VHRZTUHXWKS(RbexImpulseType a, Vector3 b, float c, float d = 8f, float e = 1f);

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(Slot = "19")]
		void IFPWHNMDZVC(RbexRotationType a, Vector3 b, float c = 7f, float d = 1f);

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(Slot = "20")]
		void QTAZRUZXNUI();

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(Slot = "21")]
		void OSOTIPUFLJT();

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(Slot = "22")]
		void ZWYVPNPVJCA();

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(Slot = "23")]
		void ITKGGEWLPWQ();

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(Slot = "24")]
		void ZBCMDVSWGQP(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(Slot = "25")]
		Vector3 HIDEKTUGMXH(Vector3 a);

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(Slot = "26")]
		void PDDHDLROXBK(object a);

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(Slot = "27")]
		void TMKUKFEEEGE(Vector3 a);

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(Slot = "28")]
		void FXOABCNBUKJ(Vector3 a, Vector3 b);

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(Slot = "29")]
		void SYCDZWOYQLO(Vector3 a, Vector3 b);

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(Slot = "30")]
		Vector3 DRXXEGAWKEL(Vector3 a);

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(Slot = "31")]
		Vector3 ILSBOSDTUSB(Vector3 a);
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[ServiceLifetime(Lifetime.Application)]
	public interface EVAKBSJADID
	{
		[Cpp2IlInjected.Token(Token = "0x17000059")]
		bool SYZUYZYRBFS
		{
			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void WYXZOEZXIDA(string a);

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void BBVVXIKVZBH(RigidbodyEx a, Action b);

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		BXGMNKSANBR XQBJZDXWDSU(int a);

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void EGYLXBJLLPO(Vector3 a, float b, Color c);
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[ServiceLifetime(Lifetime.Application)]
	public interface OPDVASMXSSY
	{
		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		EVAKBSJADID YGWTEAVAHFA
		{
			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		MYDEZSBGEEG HGTGDDQFQXK
		{
			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(Slot = "2")]
		URSPHDVDGTJ EKPKRACEEQA(RigidbodyEx a);
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class HNPUCQYBPPM : URSPHDVDGTJ, IDisposable, QQPDYEXPNDC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		internal readonly OPDVASMXSSY KLZBIVRBXUZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		internal ABPPNKWDZXB ULSOVSMCUER;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		internal VJJVLNKTDOW HGXXUVPNZMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		internal BWVLOWJRLEQ DTUZFMEGAHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		internal NZIHUDSLPRV JEFEUIESVAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		internal VPNGXOBPVYY RSKHIVHBLPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		internal RZCYDGGXVUS KSADXDHYETW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		internal EFZVBULSGCJ EHPATTNEHTN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		internal JXLAABBVTVI KPZLYEGSXTS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		internal JFQQXKOPLDR RUZQLQDHYBX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		internal XPXLOPDNHII HQIVIURRSYC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		internal JVJSTMHLGZD LAOCPFIOHTR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		internal EMYFGMLRIFJ ZMCGLLCVKKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		internal DKRIBMSIRNE RBMYXQNEMUQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		internal AZNEFAUWREM ZPFZUCWMZLQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		internal TOMRCQCGWKH HNCVCANEREV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		internal IDisposable FBCCPFAGHPW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private bool CGVKSYOYQDI;

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public ObjectLocalId KIPUDTVRVRK
		{
			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0xCF41A0", Offset = "0xCF35A0", VA = "0x180CF41A0", Slot = "22")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public BADBXNYBQWB DZVSWPIGMMQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0xDCCCD0", Offset = "0xDCC0D0", VA = "0x180DCCCD0", Slot = "24")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0xE82D80", Offset = "0xE82180", VA = "0x180E82D80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public GameObject ZVZGOAWCMUD
		{
			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0xCFF1A0", Offset = "0xCFE5A0", VA = "0x180CFF1A0", Slot = "25")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0xCFF160", Offset = "0xCFE560", VA = "0x180CFF160")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public Transform OZMOQPUQRCW
		{
			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0xE97090", Offset = "0xE96490", VA = "0x180E97090", Slot = "26")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x100CF70", Offset = "0x100C370", VA = "0x18100CF70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public Rigidbody UKJPIVGVHRU
		{
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x9F539B0", Offset = "0x9F52DB0", VA = "0x189F539B0", Slot = "23")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public URSPHDVDGTJ RSMFOCGSZZY
		{
			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x9F56A80", Offset = "0x9F55E80", VA = "0x189F56A80", Slot = "27")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x9F55430", Offset = "0x9F54830", VA = "0x189F55430", Slot = "28")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public int TKCSMZEOUVJ
		{
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x9F587D0", Offset = "0x9F57BD0", VA = "0x189F587D0", Slot = "31")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public URSPHDVDGTJ XJMGIEKJBLY
		{
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x9F55230", Offset = "0x9F54630", VA = "0x189F55230", Slot = "29")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public bool OXHXFSMZAVM
		{
			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x9F56200", Offset = "0x9F55600", VA = "0x189F56200", Slot = "32")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public bool QQGQFHDBUDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x9F53680", Offset = "0x9F52A80", VA = "0x189F53680", Slot = "33")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public bool TEVMYHHAXTG
		{
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x9F586B0", Offset = "0x9F57AB0", VA = "0x189F586B0", Slot = "34")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public IDDHGUAZWOL TCXKPVMHZJW
		{
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x9F53C10", Offset = "0x9F53010", VA = "0x189F53C10", Slot = "35")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x9F55AC0", Offset = "0x9F54EC0", VA = "0x189F55AC0", Slot = "36")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public HFHEIEPYUFA ZNHTNHSXOAD
		{
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x9F557D0", Offset = "0x9F54BD0", VA = "0x189F557D0", Slot = "37")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x9F53BB0", Offset = "0x9F52FB0", VA = "0x189F53BB0", Slot = "38")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public float UFRAKQYPUVL
		{
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x9F53960", Offset = "0x9F52D60", VA = "0x189F53960", Slot = "39")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x9F58CE0", Offset = "0x9F580E0", VA = "0x189F58CE0", Slot = "40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public Vector3 XNWSMOJCOQS
		{
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x9F54030", Offset = "0x9F53430", VA = "0x189F54030", Slot = "41")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x9F554E0", Offset = "0x9F548E0", VA = "0x189F554E0", Slot = "42")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public Vector3 QDWNSCUTQZE
		{
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x9F550A0", Offset = "0x9F544A0", VA = "0x189F550A0", Slot = "43")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x9F58A30", Offset = "0x9F57E30", VA = "0x189F58A30", Slot = "44")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public Vector3 QXERQLBXURP
		{
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x9F56590", Offset = "0x9F55990", VA = "0x189F56590", Slot = "45")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x9F55DF0", Offset = "0x9F551F0", VA = "0x189F55DF0", Slot = "46")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public Vector3 HGAQXEXIGYL
		{
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x9F59100", Offset = "0x9F58500", VA = "0x189F59100", Slot = "47")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x9F55870", Offset = "0x9F54C70", VA = "0x189F55870", Slot = "48")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public bool LJTWWDLRETB
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x9F530C0", Offset = "0x9F524C0", VA = "0x189F530C0", Slot = "49")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public bool NFKODNJSAYS
		{
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x9F58590", Offset = "0x9F57990", VA = "0x189F58590", Slot = "50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public bool WVXPRIINAUP
		{
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x9F54320", Offset = "0x9F53720", VA = "0x189F54320", Slot = "51")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public bool CLVBSNZWGIT
		{
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x9F534D0", Offset = "0x9F528D0", VA = "0x189F534D0", Slot = "52")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public Vector3 JZZYNRWBPXN
		{
			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x9F55ED0", Offset = "0x9F552D0", VA = "0x189F55ED0", Slot = "53")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public Vector3 UZNZHILDYRD
		{
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x9F588A0", Offset = "0x9F57CA0", VA = "0x189F588A0", Slot = "54")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public Vector3 WXMWEVLVNUV
		{
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x9F57210", Offset = "0x9F56610", VA = "0x189F57210", Slot = "55")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x9F569A0", Offset = "0x9F55DA0", VA = "0x189F569A0", Slot = "56")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public Vector3 PKWVFPLEWLM
		{
			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x9F52EA0", Offset = "0x9F522A0", VA = "0x189F52EA0", Slot = "57")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public float SQQIWIVUCOK
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x9F55820", Offset = "0x9F54C20", VA = "0x189F55820", Slot = "58")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public float WHJFJKCEHYV
		{
			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x9F53730", Offset = "0x9F52B30", VA = "0x189F53730", Slot = "59")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x9F58C30", Offset = "0x9F58030", VA = "0x189F58C30", Slot = "60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public Vector3 NQODOFXJIWV
		{
			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x9F54F60", Offset = "0x9F54360", VA = "0x189F54F60", Slot = "61")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public Quaternion NESEJZXJPKT
		{
			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x9F59230", Offset = "0x9F58630", VA = "0x189F59230", Slot = "62")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public float YNUGNPYEIYA
		{
			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x9F578E0", Offset = "0x9F56CE0", VA = "0x189F578E0", Slot = "64")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x9F56CA0", Offset = "0x9F560A0", VA = "0x189F56CA0", Slot = "65")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public float EBLRXHYHGAG
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x9F53FE0", Offset = "0x9F533E0", VA = "0x189F53FE0", Slot = "66")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x9F57880", Offset = "0x9F56C80", VA = "0x189F57880", Slot = "67")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public bool TRPLMMZBLYN
		{
			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x9F57990", Offset = "0x9F56D90", VA = "0x189F57990", Slot = "68")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x9F57350", Offset = "0x9F56750", VA = "0x189F57350", Slot = "69")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public TransformTrackRate QCZNQYUQAEZ
		{
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x9F548D0", Offset = "0x9F53CD0", VA = "0x189F548D0", Slot = "70")]
			get
			{
				return default(TransformTrackRate);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x9F58840", Offset = "0x9F57C40", VA = "0x189F58840", Slot = "71")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public bool LWUMTMYRXWH
		{
			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x9F52E50", Offset = "0x9F52250", VA = "0x189F52E50", Slot = "72")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public Transform MRSJCBHJEAB
		{
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0xE97090", Offset = "0xE96490", VA = "0x180E97090", Slot = "73")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public Vector3 BTYJYWTVHPL
		{
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x9F57BE0", Offset = "0x9F56FE0", VA = "0x189F57BE0", Slot = "74")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x9F55950", Offset = "0x9F54D50", VA = "0x189F55950", Slot = "75")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public float HFNPOVKWQDV
		{
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x9F561F0", Offset = "0x9F555F0", VA = "0x189F561F0", Slot = "76")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x9F58500", Offset = "0x9F57900", VA = "0x189F58500", Slot = "77")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public float VCPAXLWATFW
		{
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x9F56C90", Offset = "0x9F56090", VA = "0x189F56C90", Slot = "78")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x9F53280", Offset = "0x9F52680", VA = "0x189F53280", Slot = "79")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public Quaternion ZKMWSXJIJWY
		{
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x9F547E0", Offset = "0x9F53BE0", VA = "0x189F547E0", Slot = "80")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x9F53520", Offset = "0x9F52920", VA = "0x189F53520", Slot = "81")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public Vector3 OXYBJKKQMBI
		{
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x9F575B0", Offset = "0x9F569B0", VA = "0x189F575B0", Slot = "82")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x9F54EB0", Offset = "0x9F542B0", VA = "0x189F54EB0", Slot = "83")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public Quaternion RGSBHVDCEST
		{
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x9F575F0", Offset = "0x9F569F0", VA = "0x189F575F0", Slot = "84")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x9F557A0", Offset = "0x9F54BA0", VA = "0x189F557A0", Slot = "85")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public RigidbodyConstraints GVDBGMOMEPE
		{
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x9F58980", Offset = "0x9F57D80", VA = "0x189F58980", Slot = "86")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x9F53A00", Offset = "0x9F52E00", VA = "0x189F53A00", Slot = "87")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public bool ZTOQUWHHEFT
		{
			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x9F58C90", Offset = "0x9F58090", VA = "0x189F58C90", Slot = "88")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x9F56190", Offset = "0x9F55590", VA = "0x189F56190", Slot = "89")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public CollisionDetectionMode JWOHTRHZZLU
		{
			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x9F55380", Offset = "0x9F54780", VA = "0x189F55380", Slot = "90")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x9F52DF0", Offset = "0x9F521F0", VA = "0x189F52DF0", Slot = "91")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public bool HDWETLJTBRH
		{
			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x9F55CB0", Offset = "0x9F550B0", VA = "0x189F55CB0", Slot = "141")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public bool ENFNEUIDCAI
		{
			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0x9F56360", Offset = "0x9F55760", VA = "0x189F56360", Slot = "92")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000017")]
		public event RbexAction COPKXASEFFY
		{
			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x9F56FD0", Offset = "0x9F563D0", VA = "0x189F56FD0", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x9F55040", Offset = "0x9F54440", VA = "0x189F55040", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000018")]
		public event RbexAction MYFHZKLSRBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x9F56940", Offset = "0x9F55D40", VA = "0x189F56940", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x9F56F10", Offset = "0x9F56310", VA = "0x189F56F10", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000019")]
		public event RbexParentChangeAction JAEYTIJGLAG
		{
			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x9F564E0", Offset = "0x9F558E0", VA = "0x189F564E0", Slot = "18")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x9F553D0", Offset = "0x9F547D0", VA = "0x189F553D0", Slot = "19")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001A")]
		public event RbexAction DAJDWHQDOUR
		{
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x9F56000", Offset = "0x9F55400", VA = "0x189F56000", Slot = "8")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x9F57930", Offset = "0x9F56D30", VA = "0x189F57930", Slot = "9")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001B")]
		public event RbexAction QYWHYAAAICM
		{
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x9F58050", Offset = "0x9F57450", VA = "0x189F58050", Slot = "14")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x9F54110", Offset = "0x9F53510", VA = "0x189F54110", Slot = "15")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001C")]
		public event RbexAction BMPSQLCPXWX
		{
			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x9F589D0", Offset = "0x9F57DD0", VA = "0x189F589D0", Slot = "16")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x9F58650", Offset = "0x9F57A50", VA = "0x189F58650", Slot = "17")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001D")]
		public event Action<UpdateLOD, UpdateLOD> BXAALPDQGDE
		{
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x9F53220", Offset = "0x9F52620", VA = "0x189F53220", Slot = "20")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x9F56130", Offset = "0x9F55530", VA = "0x189F56130", Slot = "21")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001E")]
		public event RbexAction IOOCVNZBWFT
		{
			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x9F58D40", Offset = "0x9F58140", VA = "0x189F58D40", Slot = "12")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x9F572F0", Offset = "0x9F566F0", VA = "0x189F572F0", Slot = "13")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001F")]
		public event RbexAction QYASUSYRLHO
		{
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x9F52D40", Offset = "0x9F52140", VA = "0x189F52D40", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x9F555C0", Offset = "0x9F549C0", VA = "0x189F555C0", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x9F59300", Offset = "0x9F58700", VA = "0x189F59300")]
		public HNPUCQYBPPM(GameObject a, RigidbodyEx b, OPDVASMXSSY c, [In] RigidbodyExData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x9F58DA0", Offset = "0x9F581A0", VA = "0x189F58DA0", Slot = "139")]
		protected virtual void ZMTUBOUQQGK(OPDVASMXSSY a, RigidbodyExData b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x9F53A60", Offset = "0x9F52E60", VA = "0x189F53A60", Slot = "140")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x9F52F80", Offset = "0x9F52380", VA = "0x189F52F80", Slot = "93")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x9F568B0", Offset = "0x9F55CB0", VA = "0x189F568B0", Slot = "94")]
		public void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x9F56800", Offset = "0x9F55C00", VA = "0x189F56800", Slot = "95")]
		public void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x9F567E0", Offset = "0x9F55BE0", VA = "0x189F567E0", Slot = "96")]
		public void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x9F57DD0", Offset = "0x9F571D0", VA = "0x189F57DD0")]
		private void WPKCIMBMHZM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x9F53600", Offset = "0x9F52A00", VA = "0x189F53600")]
		private void CPKZLYUOJSL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x9F55FA0", Offset = "0x9F553A0", VA = "0x189F55FA0")]
		private void LMUWTHBKLVO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x9F54400", Offset = "0x9F53800", VA = "0x189F54400", Slot = "30")]
		public URSPHDVDGTJ FLLGICGVJRS(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x9F574A0", Offset = "0x9F568A0", VA = "0x189F574A0", Slot = "98")]
		public void SetParent(URSPHDVDGTJ value, bool isPhysicallyDetachedOnly = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x9F585F0", Offset = "0x9F579F0", VA = "0x189F585F0", Slot = "99")]
		public void XWQDISYVRPN(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x9F56F70", Offset = "0x9F56370", VA = "0x189F56F70", Slot = "100")]
		public void RCKTEEIELNQ(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x9F55280", Offset = "0x9F54680", VA = "0x189F55280", Slot = "101")]
		public Vector3 ILSBOSDTUSB(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x9F53860", Offset = "0x9F52C60", VA = "0x189F53860", Slot = "102")]
		public Vector3 DRXXEGAWKEL(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x9F55490", Offset = "0x9F54890", VA = "0x189F55490", Slot = "103")]
		public void ITKGGEWLPWQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x9F56540", Offset = "0x9F55940", VA = "0x189F56540", Slot = "104")]
		public void OSOTIPUFLJT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x9F56DE0", Offset = "0x9F561E0", VA = "0x189F56DE0", Slot = "105")]
		public void QTAZRUZXNUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x9F573B0", Offset = "0x9F567B0", VA = "0x189F573B0", Slot = "106")]
		public void SYCDZWOYQLO(Vector3 a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x9F546F0", Offset = "0x9F53AF0", VA = "0x189F546F0", Slot = "107")]
		public void FXOABCNBUKJ(Vector3 a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x9F57630", Offset = "0x9F56A30", VA = "0x189F57630", Slot = "108")]
		public void TMKUKFEEEGE(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x9F57B20", Offset = "0x9F56F20", VA = "0x189F57B20", Slot = "109")]
		public void VHRZTUHXWKS(RbexImpulseType a, Vector3 b, float c, float d = 8f, float e = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x9F54920", Offset = "0x9F53D20", VA = "0x189F54920", Slot = "110")]
		public void GRQHAZMWWHF(RbexRotationType a, Vector3 b, float c = 1f / 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x9F55180", Offset = "0x9F54580", VA = "0x189F55180", Slot = "111")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void IFPWHNMDZVC(RbexRotationType a, Vector3 b, float c = 7f, float d = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x9F54DB0", Offset = "0x9F541B0", VA = "0x189F54DB0", Slot = "112")]
		public Vector3 HIDEKTUGMXH(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x9F56260", Offset = "0x9F55660", VA = "0x189F56260", Slot = "113")]
		public Vector3 NKYOVGAHBUD(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x9F591E0", Offset = "0x9F585E0", VA = "0x189F591E0", Slot = "114")]
		public void ZWYVPNPVJCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x9F59090", Offset = "0x9F58490", VA = "0x189F59090", Slot = "115")]
		public void ZOERQFBBTIG(URSPHDVDGTJ a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x9F536D0", Offset = "0x9F52AD0", VA = "0x189F536D0", Slot = "116")]
		public void DKLIEQQJTLZ(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x9F56E30", Offset = "0x9F56230", VA = "0x189F56E30", Slot = "63")]
		public void QVIPLBOFWLD((Quaternion rot, Vector3 moments) tensor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x9F55C60", Offset = "0x9F55060", VA = "0x189F55C60", Slot = "117")]
		public void KUIGOHPFLWT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x9F56B30", Offset = "0x9F55F30", VA = "0x189F56B30", Slot = "118")]
		public void QCPAGHHOMSE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x9F53B60", Offset = "0x9F52F60", VA = "0x189F53B60", Slot = "119")]
		public void EECWJYCHWKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x9F57560", Offset = "0x9F56960", VA = "0x189F57560", Slot = "120")]
		public bool TCSXBWLBQPF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x9F57510", Offset = "0x9F56910", VA = "0x189F57510", Slot = "97")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x9F54EF0", Offset = "0x9F542F0", VA = "0x189F54EF0", Slot = "121")]
		public void HOZHVLOULRV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x9F53F80", Offset = "0x9F53380", VA = "0x189F53F80", Slot = "122")]
		public void EKKZDFDBKWK(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x9F57D70", Offset = "0x9F57170", VA = "0x189F57D70", Slot = "123")]
		public void WLCJKINUTIT(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x9F54480", Offset = "0x9F53880", VA = "0x189F54480", Slot = "124")]
		public void FMZHQWGRYSH(object a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x9F544F0", Offset = "0x9F538F0", VA = "0x189F544F0", Slot = "125")]
		public void FURUWSSYAKB(Vector3 a, Quaternion b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x9F55670", Offset = "0x9F54A70", VA = "0x189F55670", Slot = "126")]
		public void JLAQSJTMOIB(Vector3 a, Quaternion b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x9F54880", Offset = "0x9F53C80", VA = "0x189F54880", Slot = "127")]
		public bool GCELKDMXQKM(float a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x9F55A60", Offset = "0x9F54E60", VA = "0x189F55A60", Slot = "128")]
		public void KQMYQPAVRHT(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x9F55A00", Offset = "0x9F54E00", VA = "0x189F55A00", Slot = "129")]
		public void KLMRAINRNMK(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x9F56AD0", Offset = "0x9F55ED0", VA = "0x189F56AD0", Slot = "130")]
		public void PXCFFWKOAEJ(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x9F579E0", Offset = "0x9F56DE0", VA = "0x189F579E0", Slot = "131")]
		public void UXGPABDHEWM(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x9F57A40", Offset = "0x9F56E40", VA = "0x189F57A40", Slot = "132")]
		public void VDGXJVZKGKI(Vector3 a, ForceMode b = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x9F53110", Offset = "0x9F52510", VA = "0x189F53110", Slot = "133")]
		public void BGTRYJZWPHE(Vector3 a, Vector3 b, ForceMode c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x9F56D00", Offset = "0x9F56100", VA = "0x189F56D00", Slot = "134")]
		public void QQSLCNPDDQP(Vector3 a, ForceMode b = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x9F57C90", Offset = "0x9F57090", VA = "0x189F57C90", Slot = "135")]
		public void VNPXAONKXLR(Vector3 a, ForceMode b = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x9F549C0", Offset = "0x9F53DC0", VA = "0x189F549C0", Slot = "136")]
		public bool GRVHXKANIBA(Vector3 a, [Out] RaycastHit b, float c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x9F56860", Offset = "0x9F55C60", VA = "0x189F56860", Slot = "137")]
		public void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x9F57840", Offset = "0x9F56C40", VA = "0x189F57840", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x9F53780", Offset = "0x9F52B80", VA = "0x189F53780")]
		private void DNOUMKEDFKQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x9F56B80", Offset = "0x9F55F80", VA = "0x189F56B80")]
		private void QCUNHVGGHCE(URSPHDVDGTJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x9F57030", Offset = "0x9F56430", VA = "0x189F57030")]
		private void RLJPWNONKHF(URSPHDVDGTJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x9F55BB0", Offset = "0x9F54FB0", VA = "0x189F55BB0")]
		private void KTOHNJNSRKQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x9F57710", Offset = "0x9F56B10", VA = "0x189F57710")]
		private void TYSJRKKTBXP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x9F54170", Offset = "0x9F53570", VA = "0x189F54170")]
		private void EQLWUUXXQDT(URSPHDVDGTJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x9F58700", Offset = "0x9F57B00", VA = "0x189F58700")]
		private void YFOGLRQIOTE(URSPHDVDGTJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x9F56060", Offset = "0x9F55460", VA = "0x189F56060")]
		private void LTSBDDIITSK(URSPHDVDGTJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x9F53380", Offset = "0x9F52780", VA = "0x189F53380")]
		private void BSLUBJJQOZJ(BADBXNYBQWB a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x9F580B0", Offset = "0x9F574B0", VA = "0x189F580B0", Slot = "142")]
		protected virtual void XGINVZBXLCY(BADBXNYBQWB a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x9F53C60", Offset = "0x9F53060", VA = "0x189F53C60")]
		protected void EIYMULTRMPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x9F54A60", Offset = "0x9F53E60", VA = "0x189F54A60")]
		protected void HCCYELZJLQW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x9F58B10", Offset = "0x9F57F10", VA = "0x189F58B10")]
		private void YYROGTZQWNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x9F56670", Offset = "0x9F55A70", VA = "0x189F56670")]
		private void OWKBJOFHKKN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	internal static class BGYKGGOXJHS
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x9F50FA0", Offset = "0x9F503A0", VA = "0x189F50FA0")]
		public static URSPHDVDGTJ SUGZKZSLAHX(this URSPHDVDGTJ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x9F50F00", Offset = "0x9F50300", VA = "0x189F50F00")]
		public static bool OAFCMWNWAJS(this URSPHDVDGTJ a, URSPHDVDGTJ b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x9F50E10", Offset = "0x9F50210", VA = "0x189F50E10")]
		public static bool DKBBWRNUFRM(this URSPHDVDGTJ a, URSPHDVDGTJ b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x9F50EB0", Offset = "0x9F502B0", VA = "0x189F50EB0")]
		public static BADBXNYBQWB NLJAPIMXDQA(this URSPHDVDGTJ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x9F50D90", Offset = "0x9F50190", VA = "0x189F50D90")]
		public static HNPUCQYBPPM Base(this URSPHDVDGTJ impl)
		{
			return null;
		}
	}
}
namespace RecRoom.Rbex.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class MEKSLLSPBJF : MYDEZSBGEEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x9F5D9A0", Offset = "0x9F5CDA0", VA = "0x189F5D9A0", Slot = "19")]
		public URSPHDVDGTJ EKPKRACEEQA(RigidbodyEx a, RigidbodyExData b, OPDVASMXSSY c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0xCF41A0", Offset = "0xCF35A0", VA = "0x180CF41A0", Slot = "4")]
		public ABPPNKWDZXB URSPQFYGSZT(URSPHDVDGTJ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0xCF41A0", Offset = "0xCF35A0", VA = "0x180CF41A0", Slot = "5")]
		public NZIHUDSLPRV TXRWDFGBGXD(URSPHDVDGTJ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0xCF41A0", Offset = "0xCF35A0", VA = "0x180CF41A0", Slot = "6")]
		public VPNGXOBPVYY TLPAMXSEGLM(URSPHDVDGTJ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0xCF41A0", Offset = "0xCF35A0", VA = "0x180CF41A0", Slot = "7")]
		public EFZVBULSGCJ NQONRMJFFZN(URSPHDVDGTJ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0xCF41A0", Offset = "0xCF35A0", VA = "0x180CF41A0", Slot = "8")]
		public JFQQXKOPLDR XTMJCFVQWAN(URSPHDVDGTJ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0xCF41A0", Offset = "0xCF35A0", VA = "0x180CF41A0", Slot = "9")]
		public XPXLOPDNHII WOHOHQXNURM(URSPHDVDGTJ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0xCF41A0", Offset = "0xCF35A0", VA = "0x180CF41A0", Slot = "10")]
		public JVJSTMHLGZD DTEAOWNWXTV(URSPHDVDGTJ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0xCF41A0", Offset = "0xCF35A0", VA = "0x180CF41A0", Slot = "11")]
		public EMYFGMLRIFJ NPDGCKFPWER(URSPHDVDGTJ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0xCF41A0", Offset = "0xCF35A0", VA = "0x180CF41A0", Slot = "12")]
		public TOMRCQCGWKH JDWUFTKMSOZ(URSPHDVDGTJ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0xCF41A0", Offset = "0xCF35A0", VA = "0x180CF41A0", Slot = "13")]
		public JXLAABBVTVI QDCOUTBULTO(URSPHDVDGTJ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0xCF41A0", Offset = "0xCF35A0", VA = "0x180CF41A0")]
		public AZNEFAUWREM YUUNSESZEPY(URSPHDVDGTJ a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0xCF41A0", Offset = "0xCF35A0", VA = "0x180CF41A0")]
		public BWVLOWJRLEQ ZJAJRYRMEFU(URSPHDVDGTJ a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0xCF41A0", Offset = "0xCF35A0", VA = "0x180CF41A0")]
		public VJJVLNKTDOW ZMCPLNJXWZW(URSPHDVDGTJ a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0xCF41A0", Offset = "0xCF35A0", VA = "0x180CF41A0")]
		public RZCYDGGXVUS JHKWAWZARKI(URSPHDVDGTJ a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0xCF41A0", Offset = "0xCF35A0", VA = "0x180CF41A0")]
		public DKRIBMSIRNE UVHXTBCZQRS(URSPHDVDGTJ a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
		public MEKSLLSPBJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0xCF41A0", Offset = "0xCF35A0", VA = "0x180CF41A0", Slot = "14")]
		private AZNEFAUWREM CSARDJODJXU(URSPHDVDGTJ a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0xCF41A0", Offset = "0xCF35A0", VA = "0x180CF41A0", Slot = "15")]
		private BWVLOWJRLEQ RCQUVFAUIAG(URSPHDVDGTJ a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0xCF41A0", Offset = "0xCF35A0", VA = "0x180CF41A0", Slot = "16")]
		private VJJVLNKTDOW YJTJYIKWKJO(URSPHDVDGTJ a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0xCF41A0", Offset = "0xCF35A0", VA = "0x180CF41A0", Slot = "17")]
		private RZCYDGGXVUS WXTRZCEVJKA(URSPHDVDGTJ a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0xCF41A0", Offset = "0xCF35A0", VA = "0x180CF41A0", Slot = "18")]
		private DKRIBMSIRNE TEXKLXBQCRS(URSPHDVDGTJ a, [In] RigidbodyExData data)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[RegisterService(typeof(MYDEZSBGEEG), new string[] { })]
	public class ZSILANQYIMC : MYDEZSBGEEG, HWCJESQYILK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private readonly MYDEZSBGEEG PKHUCFYJCKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private readonly MYDEZSBGEEG EHOWXODPAJY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private NCOIPWKUHNW MLSYECSPOQX;

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		private MYDEZSBGEEG HGTGDDQFQXK
		{
			[Cpp2IlInjected.Token(Token = "0x600021F")]
			[Cpp2IlInjected.Address(RVA = "0x9F6BEA0", Offset = "0x9F6B2A0", VA = "0x189F6BEA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BBC0", Offset = "0x9F6AFC0", VA = "0x189F6BBC0", Slot = "20")]
		public void InitReferences(GEZRGCKOUXX services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x9F6C240", Offset = "0x9F6B640", VA = "0x189F6C240", Slot = "4")]
		public ABPPNKWDZXB URSPQFYGSZT(URSPHDVDGTJ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x9F6C1A0", Offset = "0x9F6B5A0", VA = "0x189F6C1A0", Slot = "5")]
		public NZIHUDSLPRV TXRWDFGBGXD(URSPHDVDGTJ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x9F6C100", Offset = "0x9F6B500", VA = "0x189F6C100", Slot = "6")]
		public VPNGXOBPVYY TLPAMXSEGLM(URSPHDVDGTJ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BE00", Offset = "0x9F6B200", VA = "0x189F6BE00", Slot = "7")]
		public EFZVBULSGCJ NQONRMJFFZN(URSPHDVDGTJ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x9F6C380", Offset = "0x9F6B780", VA = "0x189F6C380", Slot = "8")]
		public JFQQXKOPLDR XTMJCFVQWAN(URSPHDVDGTJ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x9F6C2E0", Offset = "0x9F6B6E0", VA = "0x189F6C2E0", Slot = "9")]
		public XPXLOPDNHII WOHOHQXNURM(URSPHDVDGTJ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BA40", Offset = "0x9F6AE40", VA = "0x189F6BA40", Slot = "10")]
		public JVJSTMHLGZD DTEAOWNWXTV(URSPHDVDGTJ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD60", Offset = "0x9F6B160", VA = "0x189F6BD60", Slot = "11")]
		public EMYFGMLRIFJ NPDGCKFPWER(URSPHDVDGTJ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BC10", Offset = "0x9F6B010", VA = "0x189F6BC10", Slot = "12")]
		public TOMRCQCGWKH JDWUFTKMSOZ(URSPHDVDGTJ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BF00", Offset = "0x9F6B300", VA = "0x189F6BF00", Slot = "13")]
		public JXLAABBVTVI QDCOUTBULTO(URSPHDVDGTJ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x9F6B990", Offset = "0x9F6AD90", VA = "0x189F6B990")]
		public AZNEFAUWREM YUUNSESZEPY(URSPHDVDGTJ a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BFA0", Offset = "0x9F6B3A0", VA = "0x189F6BFA0")]
		public BWVLOWJRLEQ ZJAJRYRMEFU(URSPHDVDGTJ a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x9F6C420", Offset = "0x9F6B820", VA = "0x189F6C420")]
		public VJJVLNKTDOW ZMCPLNJXWZW(URSPHDVDGTJ a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BCB0", Offset = "0x9F6B0B0", VA = "0x189F6BCB0")]
		public RZCYDGGXVUS JHKWAWZARKI(URSPHDVDGTJ a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x9F6C050", Offset = "0x9F6B450", VA = "0x189F6C050")]
		public DKRIBMSIRNE UVHXTBCZQRS(URSPHDVDGTJ a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BAE0", Offset = "0x9F6AEE0", VA = "0x189F6BAE0", Slot = "19")]
		public URSPHDVDGTJ EKPKRACEEQA(RigidbodyEx a, RigidbodyExData b, OPDVASMXSSY c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x9F6C4D0", Offset = "0x9F6B8D0", VA = "0x189F6C4D0")]
		public ZSILANQYIMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x9F6B990", Offset = "0x9F6AD90", VA = "0x189F6B990", Slot = "14")]
		private AZNEFAUWREM CSARDJODJXU(URSPHDVDGTJ a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BFA0", Offset = "0x9F6B3A0", VA = "0x189F6BFA0", Slot = "15")]
		private BWVLOWJRLEQ RCQUVFAUIAG(URSPHDVDGTJ a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x9F6C420", Offset = "0x9F6B820", VA = "0x189F6C420", Slot = "16")]
		private VJJVLNKTDOW YJTJYIKWKJO(URSPHDVDGTJ a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BCB0", Offset = "0x9F6B0B0", VA = "0x189F6BCB0", Slot = "17")]
		private RZCYDGGXVUS WXTRZCEVJKA(URSPHDVDGTJ a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x9F6C050", Offset = "0x9F6B450", VA = "0x189F6C050", Slot = "18")]
		private DKRIBMSIRNE TEXKLXBQCRS(URSPHDVDGTJ a, [In] RigidbodyExData data)
		{
			return null;
		}
	}
}
namespace RecRoom.Rbex.Legacy
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public interface CLHRVQDEFHI : ABPPNKWDZXB, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void NKQFAMSGLEZ(URSPHDVDGTJ a);

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void RIZHQTJLGXC(URSPHDVDGTJ a);

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void UECFMXWBXIP(URSPHDVDGTJ a);

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void ONVUQTTAXVM(URSPHDVDGTJ a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public interface MZOFMWYBRKZ : VPNGXOBPVYY
	{
		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		PICNZNALMVD<URSPHDVDGTJ> HOSHOKMHJSA
		{
			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		URSPHDVDGTJ RENIPXGRYOK
		{
			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public interface TSBDVKRHXOJ : RZCYDGGXVUS
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		(float, Vector3) GKYJNQFKJTC(Rigidbody a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public interface YBWOMCINISV : BWVLOWJRLEQ, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		RRNetworkView ZOHODGZOGMR
		{
			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	internal sealed class QUCAVBITICM : TOMRCQCGWKH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private readonly HNPUCQYBPPM OHDFVYRXCOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private CollisionDetectionMode RIXMVYZJMGU;

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		private Rigidbody UKJPIVGVHRU
		{
			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0x9F61340", Offset = "0x9F60740", VA = "0x189F61340")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		public CollisionDetectionMode JWOHTRHZZLU
		{
			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0x9F614F0", Offset = "0x9F608F0", VA = "0x189F614F0", Slot = "4")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0x9F611C0", Offset = "0x9F605C0", VA = "0x189F611C0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x9F595A0", Offset = "0x9F589A0", VA = "0x189F595A0")]
		public QUCAVBITICM(URSPHDVDGTJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x9F61230", Offset = "0x9F60630", VA = "0x189F61230", Slot = "6")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x9F61740", Offset = "0x9F60B40", VA = "0x189F61740", Slot = "9")]
		public void ZBCMDVSWGQP(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x9F61730", Offset = "0x9F60B30", VA = "0x189F61730", Slot = "7")]
		public void QUPLSZBKCRM(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x9F61600", Offset = "0x9F60A00", VA = "0x189F61600", Slot = "8")]
		public void KFIVMTRDQVX(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x9F61390", Offset = "0x9F60790", VA = "0x189F61390", Slot = "10")]
		public bool GRVHXKANIBA(Vector3 a, [Out] RaycastHit b, float c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x9F61610", Offset = "0x9F60A10", VA = "0x189F61610")]
		private void KSEEEHQTWBE(bool a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public sealed class ZCWSANEKSHX : XPXLOPDNHII, IDisposable, GZDKSJNECPI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly HNPUCQYBPPM OHDFVYRXCOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private TransformTrackRate YYNGXVZWFWR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private BXGMNKSANBR IHIUATLIXXD;

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		public TransformTrackRate QCZNQYUQAEZ
		{
			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0x9F6B610", Offset = "0x9F6AA10", VA = "0x189F6B610", Slot = "6")]
			get
			{
				return default(TransformTrackRate);
			}
			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0x9F6B830", Offset = "0x9F6AC30", VA = "0x189F6B830", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000092")]
		private Transform HROVHGQYOIW
		{
			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x9F6B810", Offset = "0x9F6AC10", VA = "0x189F6B810", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000020")]
		public event Action<UpdateLOD, UpdateLOD> BXAALPDQGDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0x9F6B510", Offset = "0x9F6A910", VA = "0x189F6B510", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0x9F6B760", Offset = "0x9F6AB60", VA = "0x189F6B760", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x9F6B900", Offset = "0x9F6AD00", VA = "0x189F6B900")]
		public ZCWSANEKSHX(URSPHDVDGTJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x9F6B2A0", Offset = "0x9F6A6A0", VA = "0x189F6B2A0", Slot = "8")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x9F6B5C0", Offset = "0x9F6A9C0", VA = "0x189F6B5C0", Slot = "9")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x13BD760", Offset = "0x13BCB60", VA = "0x1813BD760", Slot = "11")]
		private void NIYCOXDJSUJ(UpdateLOD a, UpdateLOD b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190", Slot = "12")]
		private void AKKTBBVNNBH(bool a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class MEKSLLSPBJF : MYDEZSBGEEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x9F5E170", Offset = "0x9F5D570", VA = "0x189F5E170", Slot = "4")]
		public ABPPNKWDZXB URSPQFYGSZT(URSPHDVDGTJ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x9F5E060", Offset = "0x9F5D460", VA = "0x189F5E060", Slot = "5")]
		public NZIHUDSLPRV TXRWDFGBGXD(URSPHDVDGTJ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x9F5DF40", Offset = "0x9F5D340", VA = "0x189F5DF40", Slot = "6")]
		public VPNGXOBPVYY TLPAMXSEGLM(URSPHDVDGTJ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x9F5DD30", Offset = "0x9F5D130", VA = "0x189F5DD30", Slot = "7")]
		public EFZVBULSGCJ NQONRMJFFZN(URSPHDVDGTJ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x9F5E310", Offset = "0x9F5D710", VA = "0x189F5E310", Slot = "8")]
		public JFQQXKOPLDR XTMJCFVQWAN(URSPHDVDGTJ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x9F5E250", Offset = "0x9F5D650", VA = "0x189F5E250", Slot = "9")]
		public XPXLOPDNHII WOHOHQXNURM(URSPHDVDGTJ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x9F5D750", Offset = "0x9F5CB50", VA = "0x189F5D750", Slot = "10")]
		public JVJSTMHLGZD DTEAOWNWXTV(URSPHDVDGTJ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x9F5DC70", Offset = "0x9F5D070", VA = "0x189F5DC70", Slot = "11")]
		public EMYFGMLRIFJ NPDGCKFPWER(URSPHDVDGTJ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x9F5DA30", Offset = "0x9F5CE30", VA = "0x189F5DA30", Slot = "12")]
		public TOMRCQCGWKH JDWUFTKMSOZ(URSPHDVDGTJ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x9F5DDA0", Offset = "0x9F5D1A0", VA = "0x189F5DDA0", Slot = "13")]
		public JXLAABBVTVI QDCOUTBULTO(URSPHDVDGTJ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x9F5D620", Offset = "0x9F5CA20", VA = "0x189F5D620")]
		public AZNEFAUWREM YUUNSESZEPY(URSPHDVDGTJ a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x9F5E4F0", Offset = "0x9F5D8F0", VA = "0x189F5E4F0")]
		public BWVLOWJRLEQ ZJAJRYRMEFU(URSPHDVDGTJ a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x9F5E3D0", Offset = "0x9F5D7D0", VA = "0x189F5E3D0")]
		public VJJVLNKTDOW ZMCPLNJXWZW(URSPHDVDGTJ a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x9F5DAF0", Offset = "0x9F5CEF0", VA = "0x189F5DAF0")]
		public RZCYDGGXVUS JHKWAWZARKI(URSPHDVDGTJ a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x9F5DE70", Offset = "0x9F5D270", VA = "0x189F5DE70")]
		public DKRIBMSIRNE UVHXTBCZQRS(URSPHDVDGTJ a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x9F5D860", Offset = "0x9F5CC60", VA = "0x189F5D860", Slot = "19")]
		public URSPHDVDGTJ EKPKRACEEQA(RigidbodyEx a, RigidbodyExData b, OPDVASMXSSY c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
		public MEKSLLSPBJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x9F5D620", Offset = "0x9F5CA20", VA = "0x189F5D620", Slot = "14")]
		private AZNEFAUWREM CSARDJODJXU(URSPHDVDGTJ a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x9F5DE60", Offset = "0x9F5D260", VA = "0x189F5DE60", Slot = "15")]
		private BWVLOWJRLEQ RCQUVFAUIAG(URSPHDVDGTJ a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x9F5E3D0", Offset = "0x9F5D7D0", VA = "0x189F5E3D0", Slot = "16")]
		private VJJVLNKTDOW YJTJYIKWKJO(URSPHDVDGTJ a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x9F5DAF0", Offset = "0x9F5CEF0", VA = "0x189F5DAF0", Slot = "17")]
		private RZCYDGGXVUS WXTRZCEVJKA(URSPHDVDGTJ a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x9F5DE70", Offset = "0x9F5D270", VA = "0x189F5DE70", Slot = "18")]
		private DKRIBMSIRNE TEXKLXBQCRS(URSPHDVDGTJ a, [In] RigidbodyExData data)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal sealed class WZRZXTVKJSS : EMYFGMLRIFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private readonly HNPUCQYBPPM OHDFVYRXCOD;

		[Cpp2IlInjected.Token(Token = "0x17000093")]
		private Rigidbody UKJPIVGVHRU
		{
			[Cpp2IlInjected.Token(Token = "0x6000268")]
			[Cpp2IlInjected.Address(RVA = "0x9F61340", Offset = "0x9F60740", VA = "0x189F61340")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000094")]
		private bool LWUMTMYRXWH
		{
			[Cpp2IlInjected.Token(Token = "0x6000269")]
			[Cpp2IlInjected.Address(RVA = "0x9F68FE0", Offset = "0x9F683E0", VA = "0x189F68FE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000095")]
		private bool OXHXFSMZAVM
		{
			[Cpp2IlInjected.Token(Token = "0x600026A")]
			[Cpp2IlInjected.Address(RVA = "0x9F692B0", Offset = "0x9F686B0", VA = "0x189F692B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000096")]
		private URSPHDVDGTJ RSMFOCGSZZY
		{
			[Cpp2IlInjected.Token(Token = "0x600026B")]
			[Cpp2IlInjected.Address(RVA = "0x9F69310", Offset = "0x9F68710", VA = "0x189F69310")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x9F595A0", Offset = "0x9F589A0", VA = "0x189F595A0")]
		public WZRZXTVKJSS(URSPHDVDGTJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x9F69730", Offset = "0x9F68B30", VA = "0x189F69730", Slot = "4")]
		public void VDGXJVZKGKI(Vector3 a, ForceMode b = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x9F694D0", Offset = "0x9F688D0", VA = "0x189F694D0")]
		private void RZSFIBNGGCD(Vector3 a, ForceMode b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x9F69030", Offset = "0x9F68430", VA = "0x189F69030", Slot = "5")]
		public void BGTRYJZWPHE(Vector3 a, Vector3 b, ForceMode c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x9F69370", Offset = "0x9F68770", VA = "0x189F69370", Slot = "6")]
		public void QQSLCNPDDQP(Vector3 a, ForceMode b = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x9F69AF0", Offset = "0x9F68EF0", VA = "0x189F69AF0")]
		private void XFJISVJILUO(Vector3 a, ForceMode b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x9F69890", Offset = "0x9F68C90", VA = "0x189F69890", Slot = "7")]
		public void VNPXAONKXLR(Vector3 a, ForceMode b = ForceMode.Force)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	internal sealed class HNRYAFZMQWL : JXLAABBVTVI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private readonly HNPUCQYBPPM OHDFVYRXCOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private bool FKDMYJKUUVP;

		[Cpp2IlInjected.Token(Token = "0x17000097")]
		public bool TRPLMMZBLYN
		{
			[Cpp2IlInjected.Token(Token = "0x6000274")]
			[Cpp2IlInjected.Address(RVA = "0xEABB30", Offset = "0xEAAF30", VA = "0x180EABB30", Slot = "4")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000275")]
			[Cpp2IlInjected.Address(RVA = "0x9F59460", Offset = "0x9F58860", VA = "0x189F59460", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x9F595A0", Offset = "0x9F589A0", VA = "0x189F595A0")]
		public HNRYAFZMQWL(URSPHDVDGTJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x9F59570", Offset = "0x9F58970", VA = "0x189F59570", Slot = "6")]
		public void ZBCMDVSWGQP(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x9F593F0", Offset = "0x9F587F0", VA = "0x189F593F0", Slot = "7")]
		public void JWZEKUEJHXO(Rigidbody a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	internal sealed class RbexHierarchy : CLHRVQDEFHI, ABPPNKWDZXB, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private readonly URSPHDVDGTJ OHDFVYRXCOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private readonly List<URSPHDVDGTJ> NMDQUIZHWSN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private URSPHDVDGTJ JBSQCTQPIEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private URSPHDVDGTJ SYLHKQLEBTU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private Transform FNENUJKXAKZ;

		[Cpp2IlInjected.Token(Token = "0x17000098")]
		private Transform OZMOQPUQRCW
		{
			[Cpp2IlInjected.Token(Token = "0x600028A")]
			[Cpp2IlInjected.Address(RVA = "0x9F61CE0", Offset = "0x9F610E0", VA = "0x189F61CE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000099")]
		public URSPHDVDGTJ RSMFOCGSZZY
		{
			[Cpp2IlInjected.Token(Token = "0x600028D")]
			[Cpp2IlInjected.Address(RVA = "0xCF5540", Offset = "0xCF4940", VA = "0x180CF5540", Slot = "28")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600028E")]
			[Cpp2IlInjected.Address(RVA = "0x9F61E90", Offset = "0x9F61290", VA = "0x189F61E90", Slot = "29")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009A")]
		public URSPHDVDGTJ XJMGIEKJBLY
		{
			[Cpp2IlInjected.Token(Token = "0x600028F")]
			[Cpp2IlInjected.Address(RVA = "0xCF4DD0", Offset = "0xCF41D0", VA = "0x180CF4DD0", Slot = "27")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		public IReadOnlyList<URSPHDVDGTJ> WOFKEUEZLJU
		{
			[Cpp2IlInjected.Token(Token = "0x6000290")]
			[Cpp2IlInjected.Address(RVA = "0xCF8C40", Offset = "0xCF8040", VA = "0x180CF8C40", Slot = "26")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000021")]
		public event RbexAction COPKXASEFFY
		{
			[Cpp2IlInjected.Token(Token = "0x6000278")]
			[Cpp2IlInjected.Address(RVA = "0x9F62850", Offset = "0x9F61C50", VA = "0x189F62850", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000279")]
			[Cpp2IlInjected.Address(RVA = "0x9F61C40", Offset = "0x9F61040", VA = "0x189F61C40", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000022")]
		public event RbexAction MYFHZKLSRBC
		{
			[Cpp2IlInjected.Token(Token = "0x600027A")]
			[Cpp2IlInjected.Address(RVA = "0x9F625C0", Offset = "0x9F619C0", VA = "0x189F625C0", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600027B")]
			[Cpp2IlInjected.Address(RVA = "0x9F627B0", Offset = "0x9F61BB0", VA = "0x189F627B0", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000023")]
		public event RbexParentChangeAction JAEYTIJGLAG
		{
			[Cpp2IlInjected.Token(Token = "0x600027C")]
			[Cpp2IlInjected.Address(RVA = "0x9F622A0", Offset = "0x9F616A0", VA = "0x189F622A0", Slot = "12")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600027D")]
			[Cpp2IlInjected.Address(RVA = "0x9F61D40", Offset = "0x9F61140", VA = "0x189F61D40", Slot = "13")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000024")]
		public event Action TORRDFBLPPB
		{
			[Cpp2IlInjected.Token(Token = "0x600027E")]
			[Cpp2IlInjected.Address(RVA = "0x9F63230", Offset = "0x9F62630", VA = "0x189F63230", Slot = "14")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600027F")]
			[Cpp2IlInjected.Address(RVA = "0x9F634C0", Offset = "0x9F628C0", VA = "0x189F634C0", Slot = "15")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000025")]
		public event Action VCDIKENNUZO
		{
			[Cpp2IlInjected.Token(Token = "0x6000280")]
			[Cpp2IlInjected.Address(RVA = "0x9F61A40", Offset = "0x9F60E40", VA = "0x189F61A40", Slot = "16")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000281")]
			[Cpp2IlInjected.Address(RVA = "0x9F63560", Offset = "0x9F62960", VA = "0x189F63560", Slot = "17")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000026")]
		public event Action<URSPHDVDGTJ> FCWXFXQEDMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000282")]
			[Cpp2IlInjected.Address(RVA = "0x9F63410", Offset = "0x9F62810", VA = "0x189F63410", Slot = "18")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000283")]
			[Cpp2IlInjected.Address(RVA = "0x9F61B90", Offset = "0x9F60F90", VA = "0x189F61B90", Slot = "19")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000027")]
		public event Action<URSPHDVDGTJ> QPNPXLRWCES
		{
			[Cpp2IlInjected.Token(Token = "0x6000284")]
			[Cpp2IlInjected.Address(RVA = "0x9F61EA0", Offset = "0x9F612A0", VA = "0x189F61EA0", Slot = "20")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000285")]
			[Cpp2IlInjected.Address(RVA = "0x9F61DE0", Offset = "0x9F611E0", VA = "0x189F61DE0", Slot = "21")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000028")]
		public event Action BBNVYUXPUMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000286")]
			[Cpp2IlInjected.Address(RVA = "0x9F62110", Offset = "0x9F61510", VA = "0x189F62110", Slot = "22")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000287")]
			[Cpp2IlInjected.Address(RVA = "0x9F61F50", Offset = "0x9F61350", VA = "0x189F61F50", Slot = "23")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000029")]
		public event Action<URSPHDVDGTJ> MNONELUVLOW
		{
			[Cpp2IlInjected.Token(Token = "0x6000288")]
			[Cpp2IlInjected.Address(RVA = "0x9F61AE0", Offset = "0x9F60EE0", VA = "0x189F61AE0", Slot = "24")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000289")]
			[Cpp2IlInjected.Address(RVA = "0x9F62700", Offset = "0x9F61B00", VA = "0x189F62700", Slot = "25")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x9F63600", Offset = "0x9F62A00", VA = "0x189F63600")]
		public RbexHierarchy(URSPHDVDGTJ rbex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x9F61830", Offset = "0x9F60C30", VA = "0x189F61830", Slot = "31")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x9F62A50", Offset = "0x9F61E50", VA = "0x189F62A50", Slot = "30")]
		public void SetParent(URSPHDVDGTJ newParent, bool isPhysicallyDetachedOnly = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x9F62FC0", Offset = "0x9F623C0", VA = "0x189F62FC0", Slot = "6")]
		public void UECFMXWBXIP(URSPHDVDGTJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x9F62340", Offset = "0x9F61740", VA = "0x189F62340", Slot = "7")]
		public void ONVUQTTAXVM(URSPHDVDGTJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x9F621B0", Offset = "0x9F615B0", VA = "0x189F621B0", Slot = "4")]
		public void NKQFAMSGLEZ(URSPHDVDGTJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x9F628F0", Offset = "0x9F61CF0", VA = "0x189F628F0", Slot = "5")]
		public void RIZHQTJLGXC(URSPHDVDGTJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x9F62660", Offset = "0x9F61A60", VA = "0x189F62660")]
		private void PHQXGYYBKOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x9F61A00", Offset = "0x9F60E00", VA = "0x189F61A00")]
		private void EXRWECCIOHM(URSPHDVDGTJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x9F632D0", Offset = "0x9F626D0", VA = "0x189F632D0")]
		private void VMVHEJFFJTV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x9F618D0", Offset = "0x9F60CD0", VA = "0x189F618D0")]
		private void ETFQTDQSQUE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x9F61FF0", Offset = "0x9F613F0", VA = "0x189F61FF0")]
		private void KACWVBDYEAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x9F62990", Offset = "0x9F61D90", VA = "0x189F62990")]
		[CompilerGenerated]
		private object SOODCRNQWTU()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	internal static class XWGRGXTDKHK
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x9F6A450", Offset = "0x9F69850", VA = "0x189F6A450")]
		public static CLHRVQDEFHI YPQWMDZMOVP(this URSPHDVDGTJ a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	internal sealed class FMVIPOYFQKN : MZOFMWYBRKZ, VPNGXOBPVYY
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly HNPUCQYBPPM OHDFVYRXCOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private readonly PICNZNALMVD<URSPHDVDGTJ> ENVZDKFRPJS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private bool VVWLZVDKSLL;

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		public PICNZNALMVD<URSPHDVDGTJ> HOSHOKMHJSA
		{
			[Cpp2IlInjected.Token(Token = "0x600029D")]
			[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		public Vector3 JZZYNRWBPXN
		{
			[Cpp2IlInjected.Token(Token = "0x600029E")]
			[Cpp2IlInjected.Address(RVA = "0x9F527F0", Offset = "0x9F51BF0", VA = "0x189F527F0", Slot = "6")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		public Vector3 UZNZHILDYRD
		{
			[Cpp2IlInjected.Token(Token = "0x600029F")]
			[Cpp2IlInjected.Address(RVA = "0x9F52A90", Offset = "0x9F51E90", VA = "0x189F52A90", Slot = "7")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		private Vector3 QXERQLBXURP
		{
			[Cpp2IlInjected.Token(Token = "0x60002A3")]
			[Cpp2IlInjected.Address(RVA = "0x9F52880", Offset = "0x9F51C80", VA = "0x189F52880")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		public URSPHDVDGTJ RENIPXGRYOK
		{
			[Cpp2IlInjected.Token(Token = "0x60002A4")]
			[Cpp2IlInjected.Address(RVA = "0x9F529E0", Offset = "0x9F51DE0", VA = "0x189F529E0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x9F52C50", Offset = "0x9F52050", VA = "0x189F52C50")]
		public FMVIPOYFQKN(URSPHDVDGTJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x9F52970", Offset = "0x9F51D70", VA = "0x189F52970", Slot = "8")]
		public void PNWPTSAFJLL(URSPHDVDGTJ a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x9F52820", Offset = "0x9F51C20", VA = "0x189F52820", Slot = "9")]
		public void LVZUSSWPSNQ(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x9F520B0", Offset = "0x9F514B0", VA = "0x189F520B0")]
		private Vector3 EEOXMUVVORB()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x9F52450", Offset = "0x9F51850", VA = "0x189F52450")]
		private void KXUHHYKHPAM(URSPHDVDGTJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	internal static class AKKWBBOZLJR
	{
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x9F50C10", Offset = "0x9F50010", VA = "0x189F50C10")]
		public static MZOFMWYBRKZ XMIRQIPLHPE(this URSPHDVDGTJ a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	internal sealed class QJUKVLXITXX : TSBDVKRHXOJ, RZCYDGGXVUS
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private readonly HNPUCQYBPPM OHDFVYRXCOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private readonly OverridableVector3 ECXXEBSSXUM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private readonly OverridableVector3 TRWGMKXUSCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private float KOAWXTYFLLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private float LQOIEFXMXNQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private Vector3 WYZIWYNDWRP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private Vector3? UPRIQFVYQFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private Quaternion? MCRBBJQTDFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private bool JCLWWGXPAJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private bool FSBQBBFDDRJ;

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		public Vector3 WXMWEVLVNUV
		{
			[Cpp2IlInjected.Token(Token = "0x60002AA")]
			[Cpp2IlInjected.Address(RVA = "0x1EC7700", Offset = "0x1EC6B00", VA = "0x181EC7700", Slot = "7")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60002AB")]
			[Cpp2IlInjected.Address(RVA = "0x9F60710", Offset = "0x9F5FB10", VA = "0x189F60710", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		public Vector3 PKWVFPLEWLM
		{
			[Cpp2IlInjected.Token(Token = "0x60002AC")]
			[Cpp2IlInjected.Address(RVA = "0x9F5E880", Offset = "0x9F5DC80", VA = "0x189F5E880", Slot = "9")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		public float SQQIWIVUCOK
		{
			[Cpp2IlInjected.Token(Token = "0x60002AD")]
			[Cpp2IlInjected.Address(RVA = "0xD46060", Offset = "0xD45460", VA = "0x180D46060", Slot = "10")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60002AE")]
			[Cpp2IlInjected.Address(RVA = "0x9F60AD0", Offset = "0x9F5FED0", VA = "0x189F60AD0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A4")]
		public float WHJFJKCEHYV
		{
			[Cpp2IlInjected.Token(Token = "0x60002AF")]
			[Cpp2IlInjected.Address(RVA = "0xD46070", Offset = "0xD45470", VA = "0x180D46070", Slot = "11")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60002B0")]
			[Cpp2IlInjected.Address(RVA = "0x9F5FE00", Offset = "0x9F5F200", VA = "0x189F5FE00", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		public Vector3 NQODOFXJIWV
		{
			[Cpp2IlInjected.Token(Token = "0x60002B1")]
			[Cpp2IlInjected.Address(RVA = "0x9F5FC70", Offset = "0x9F5F070", VA = "0x189F5FC70", Slot = "13")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A6")]
		public Quaternion NESEJZXJPKT
		{
			[Cpp2IlInjected.Token(Token = "0x60002B2")]
			[Cpp2IlInjected.Address(RVA = "0x9F60EE0", Offset = "0x9F602E0", VA = "0x189F60EE0", Slot = "14")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A7")]
		private Rigidbody UKJPIVGVHRU
		{
			[Cpp2IlInjected.Token(Token = "0x60002BA")]
			[Cpp2IlInjected.Address(RVA = "0x9F5C560", Offset = "0x9F5B960", VA = "0x189F5C560")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400002A")]
		public event RbexAction AOMHBEHBMLS
		{
			[Cpp2IlInjected.Token(Token = "0x60002A8")]
			[Cpp2IlInjected.Address(RVA = "0x9F60D60", Offset = "0x9F60160", VA = "0x189F60D60", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60002A9")]
			[Cpp2IlInjected.Address(RVA = "0x9F601B0", Offset = "0x9F5F5B0", VA = "0x189F601B0", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x9F61060", Offset = "0x9F60460", VA = "0x189F61060")]
		public QJUKVLXITXX(URSPHDVDGTJ a, [In] RigidbodyExData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x9F60090", Offset = "0x9F5F490", VA = "0x189F60090", Slot = "17")]
		public void KUIGOHPFLWT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x9F607C0", Offset = "0x9F5FBC0", VA = "0x189F607C0", Slot = "16")]
		public void QCPAGHHOMSE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x9F60E00", Offset = "0x9F60200", VA = "0x189F60E00", Slot = "19")]
		public void ZBCMDVSWGQP(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x9F5FEB0", Offset = "0x9F5F2B0", VA = "0x189F5FEB0", Slot = "20")]
		public void JWZEKUEJHXO(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x9F5EAC0", Offset = "0x9F5DEC0", VA = "0x189F5EAC0", Slot = "18")]
		public void EECWJYCHWKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x9F60250", Offset = "0x9F5F650", VA = "0x189F60250", Slot = "21")]
		public void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x9F60710", Offset = "0x9F5FB10", VA = "0x189F60710")]
		private void YEXRLIKVYXT(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x9F5E9A0", Offset = "0x9F5DDA0", VA = "0x189F5E9A0")]
		[Obsolete("This method is dangerous - the unity rigidbody is updated in a deferred manner and this world position may be stale")]
		private Vector3 CTVQECRPKWS()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x9F60AD0", Offset = "0x9F5FED0", VA = "0x189F60AD0")]
		private void XNJRWRLNTJI(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x9F5FE00", Offset = "0x9F5F200", VA = "0x189F5FE00")]
		private void JRFTOSOGOJX(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x9F5EC60", Offset = "0x9F5E060", VA = "0x189F5EC60")]
		private Vector3 ESWMCGNPCVT()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x9F608A0", Offset = "0x9F5FCA0", VA = "0x189F608A0", Slot = "15")]
		public void QVIPLBOFWLD((Quaternion rot, Vector3 moments) tensor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x9F60BE0", Offset = "0x9F5FFE0", VA = "0x189F60BE0")]
		private Quaternion WKOLPICSHUL()
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x9F5FBA0", Offset = "0x9F5EFA0", VA = "0x189F5FBA0")]
		public void GKYJNQFKJTC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x9F5EE00", Offset = "0x9F5E200", VA = "0x189F5EE00", Slot = "4")]
		public (float, Vector3) GKYJNQFKJTC(Rigidbody a)
		{
			return default((float, Vector3));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	internal static class LZOXJHZHSBV
	{
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x9F5D460", Offset = "0x9F5C860", VA = "0x189F5D460")]
		public static TSBDVKRHXOJ JKQJCSXOLUQ(this URSPHDVDGTJ a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	internal sealed class XGVKKSILPDV : VJJVLNKTDOW
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private readonly HNPUCQYBPPM OHDFVYRXCOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private readonly WFSYYVMEPOE CVJABEVAIJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private readonly RbexInterpolationMode HRUJRGAQFPN;

		[Cpp2IlInjected.Token(Token = "0x170000A8")]
		public bool BZCCCOSUCMT
		{
			[Cpp2IlInjected.Token(Token = "0x60002C5")]
			[Cpp2IlInjected.Address(RVA = "0x1B61E40", Offset = "0x1B61240", VA = "0x181B61E40", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A9")]
		public RbexInterpolationMode HBFTZFMHXCV
		{
			[Cpp2IlInjected.Token(Token = "0x60002C6")]
			[Cpp2IlInjected.Address(RVA = "0xD05550", Offset = "0xD04950", VA = "0x180D05550", Slot = "11")]
			get
			{
				return default(RbexInterpolationMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x9F6A360", Offset = "0x9F69760", VA = "0x189F6A360")]
		public XGVKKSILPDV(URSPHDVDGTJ a, [In] RigidbodyExData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x9F69D50", Offset = "0x9F69150", VA = "0x189F69D50", Slot = "4")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x9F6A0A0", Offset = "0x9F694A0", VA = "0x189F6A0A0")]
		private bool QBFLARLXUTR()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x9F6A140", Offset = "0x9F69540", VA = "0x189F6A140", Slot = "5")]
		public void QIKEGXHTJJX(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x9F6A170", Offset = "0x9F69570", VA = "0x189F6A170", Slot = "6")]
		public void SXPFMUAIOMU(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x9F69F70", Offset = "0x9F69370", VA = "0x189F69F70", Slot = "9")]
		public void NOLZQXVWIMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x9F69E20", Offset = "0x9F69220", VA = "0x189F69E20")]
		private void CKNAOSWEPNR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x9F6A1E0", Offset = "0x9F695E0", VA = "0x189F6A1E0")]
		private void XGMSGNZNZFZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x9F69F30", Offset = "0x9F69330", VA = "0x189F69F30", Slot = "8")]
		public void KETPIUNEXJR(URSPHDVDGTJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x9F6A1A0", Offset = "0x9F695A0", VA = "0x189F6A1A0", Slot = "7")]
		public void TKMJFWJBDSE(URSPHDVDGTJ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	internal sealed class YBKUZOSXNWQ : JVJSTMHLGZD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private readonly HNPUCQYBPPM OHDFVYRXCOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private readonly WFSYYVMEPOE ZEZLCYMZLGJ;

		[Cpp2IlInjected.Token(Token = "0x170000AA")]
		public bool LWUMTMYRXWH
		{
			[Cpp2IlInjected.Token(Token = "0x60002D3")]
			[Cpp2IlInjected.Address(RVA = "0x9F6A510", Offset = "0x9F69910", VA = "0x189F6A510", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400002B")]
		public event RbexAction IOOCVNZBWFT
		{
			[Cpp2IlInjected.Token(Token = "0x60002D1")]
			[Cpp2IlInjected.Address(RVA = "0x9F6A880", Offset = "0x9F69C80", VA = "0x189F6A880", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60002D2")]
			[Cpp2IlInjected.Address(RVA = "0x9F6A710", Offset = "0x9F69B10", VA = "0x189F6A710", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x9F6A920", Offset = "0x9F69D20", VA = "0x189F6A920")]
		public YBKUZOSXNWQ(URSPHDVDGTJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x9F6A5C0", Offset = "0x9F699C0", VA = "0x189F6A5C0", Slot = "7")]
		public void EKKZDFDBKWK(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x9F6A7B0", Offset = "0x9F69BB0", VA = "0x189F6A7B0", Slot = "8")]
		public void WLCJKINUTIT(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x9F6A5D0", Offset = "0x9F699D0", VA = "0x189F6A5D0", Slot = "9")]
		public void FMZHQWGRYSH(object a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x9F6A7C0", Offset = "0x9F69BC0", VA = "0x189F6A7C0", Slot = "12")]
		public void ZAIRIOPUIAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x9F6A800", Offset = "0x9F69C00", VA = "0x189F6A800", Slot = "10")]
		public void ZBCMDVSWGQP(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x9F6A6E0", Offset = "0x9F69AE0", VA = "0x189F6A6E0", Slot = "11")]
		public void JWZEKUEJHXO(Rigidbody a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	internal sealed class BJNQCIVMCNX : YBWOMCINISV, BWVLOWJRLEQ, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private WeakReference<URSPHDVDGTJ> XWDLAOZYPAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private readonly HNPUCQYBPPM OHDFVYRXCOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private RRNetworkView XDJKGBXTLOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private bool HAJSKJUAOUA;

		[Cpp2IlInjected.Token(Token = "0x170000AB")]
		public RRNetworkView ZOHODGZOGMR
		{
			[Cpp2IlInjected.Token(Token = "0x60002DD")]
			[Cpp2IlInjected.Address(RVA = "0xCF4CF0", Offset = "0xCF40F0", VA = "0x180CF4CF0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AC")]
		public bool QQGQFHDBUDE
		{
			[Cpp2IlInjected.Token(Token = "0x60002DE")]
			[Cpp2IlInjected.Address(RVA = "0x9F512E0", Offset = "0x9F506E0", VA = "0x189F512E0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AD")]
		public bool TEVMYHHAXTG
		{
			[Cpp2IlInjected.Token(Token = "0x60002DF")]
			[Cpp2IlInjected.Address(RVA = "0xD4DA50", Offset = "0xD4CE50", VA = "0x180D4DA50", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400002C")]
		public event RbexAction DAJDWHQDOUR
		{
			[Cpp2IlInjected.Token(Token = "0x60002DB")]
			[Cpp2IlInjected.Address(RVA = "0x9F51A00", Offset = "0x9F50E00", VA = "0x189F51A00", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60002DC")]
			[Cpp2IlInjected.Address(RVA = "0x9F51C20", Offset = "0x9F51020", VA = "0x189F51C20", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x9F51E50", Offset = "0x9F51250", VA = "0x189F51E50")]
		public BJNQCIVMCNX(URSPHDVDGTJ a, [In] RigidbodyExData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x9F51060", Offset = "0x9F50460", VA = "0x189F51060", Slot = "9")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x9F512F0", Offset = "0x9F506F0", VA = "0x189F512F0", Slot = "12")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x9F51CC0", Offset = "0x9F510C0", VA = "0x189F51CC0", Slot = "10")]
		public void YFOGLRQIOTE(URSPHDVDGTJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x9F51AA0", Offset = "0x9F50EA0", VA = "0x189F51AA0", Slot = "11")]
		public void LTSBDDIITSK(URSPHDVDGTJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x9F51890", Offset = "0x9F50C90", VA = "0x189F51890")]
		private void JQOHMJIUXVU(RRNetworkView a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x9F51190", Offset = "0x9F50590", VA = "0x189F51190")]
		private void CJKMEGJZIQW(BADBXNYBQWB a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x9F51620", Offset = "0x9F50A20", VA = "0x189F51620")]
		private void GLHWEBLDGDB(RRNetworkView a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	internal static class EKBHJCMJHHN
	{
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x9F51FF0", Offset = "0x9F513F0", VA = "0x189F51FF0")]
		public static YBWOMCINISV Lifecycle(this URSPHDVDGTJ impl)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	internal sealed class STNPAPHXTNL : DKRIBMSIRNE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private readonly HNPUCQYBPPM OHDFVYRXCOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private RigidbodyConstraints OLYLXFTGWLE;

		[Cpp2IlInjected.Token(Token = "0x170000AE")]
		public bool ZTOQUWHHEFT
		{
			[Cpp2IlInjected.Token(Token = "0x60002E9")]
			[Cpp2IlInjected.Address(RVA = "0xE8DE30", Offset = "0xE8D230", VA = "0x180E8DE30", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002EA")]
			[Cpp2IlInjected.Address(RVA = "0xEC6240", Offset = "0xEC5640", VA = "0x180EC6240", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AF")]
		public bool KBYNDOZILSM
		{
			[Cpp2IlInjected.Token(Token = "0x60002EB")]
			[Cpp2IlInjected.Address(RVA = "0xEC6160", Offset = "0xEC5560", VA = "0x180EC6160", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002EC")]
			[Cpp2IlInjected.Address(RVA = "0xEC6230", Offset = "0xEC5630", VA = "0x180EC6230")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B0")]
		public RigidbodyConstraints GVDBGMOMEPE
		{
			[Cpp2IlInjected.Token(Token = "0x60002ED")]
			[Cpp2IlInjected.Address(RVA = "0xCF7B50", Offset = "0xCF6F50", VA = "0x180CF7B50", Slot = "7")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x60002EE")]
			[Cpp2IlInjected.Address(RVA = "0x9F68DA0", Offset = "0x9F681A0", VA = "0x189F68DA0", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x9F68F30", Offset = "0x9F68330", VA = "0x189F68F30")]
		public STNPAPHXTNL(URSPHDVDGTJ a, [In] RigidbodyExData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x9F68F00", Offset = "0x9F68300", VA = "0x189F68F00", Slot = "9")]
		public void ZBCMDVSWGQP(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x9F68ED0", Offset = "0x9F682D0", VA = "0x189F68ED0", Slot = "10")]
		public void JWZEKUEJHXO(Rigidbody a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	internal sealed class LOLRAJWNGYO : EFZVBULSGCJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private readonly URSPHDVDGTJ OHDFVYRXCOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private float AIDOFLHDHLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private float RLQAQJMXMAO;

		[Cpp2IlInjected.Token(Token = "0x170000B1")]
		public float YNUGNPYEIYA
		{
			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0xD4C5B0", Offset = "0xD4B9B0", VA = "0x180D4C5B0", Slot = "4")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60002F4")]
			[Cpp2IlInjected.Address(RVA = "0x9F5D230", Offset = "0x9F5C630", VA = "0x189F5D230", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B2")]
		public float EBLRXHYHGAG
		{
			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0xD4C5A0", Offset = "0xD4B9A0", VA = "0x180D4C5A0", Slot = "6")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60002F6")]
			[Cpp2IlInjected.Address(RVA = "0x9F5D300", Offset = "0x9F5C700", VA = "0x189F5D300", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x9F5D420", Offset = "0x9F5C820", VA = "0x189F5D420")]
		public LOLRAJWNGYO(URSPHDVDGTJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x9F5D3D0", Offset = "0x9F5C7D0", VA = "0x189F5D3D0", Slot = "8")]
		public void ZBCMDVSWGQP(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x9F5D190", Offset = "0x9F5C590", VA = "0x189F5D190", Slot = "9")]
		public void JWZEKUEJHXO(Rigidbody a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	internal sealed class LEWYWOEVFAG : JFQQXKOPLDR
	{
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private static readonly Log CLSMRUFNQAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private readonly HNPUCQYBPPM OHDFVYRXCOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private bool MSCPXFNCTOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private bool QYUFHRBQZQQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private int IECUBRNEXGU;

		[Cpp2IlInjected.Token(Token = "0x170000B3")]
		private Rigidbody UKJPIVGVHRU
		{
			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0x9F5C560", Offset = "0x9F5B960", VA = "0x189F5C560")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B4")]
		private bool HDWETLJTBRH
		{
			[Cpp2IlInjected.Token(Token = "0x60002FC")]
			[Cpp2IlInjected.Address(RVA = "0x9F5C660", Offset = "0x9F5BA60", VA = "0x189F5C660")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B5")]
		private URSPHDVDGTJ RSMFOCGSZZY
		{
			[Cpp2IlInjected.Token(Token = "0x60002FD")]
			[Cpp2IlInjected.Address(RVA = "0x9F5CB30", Offset = "0x9F5BF30", VA = "0x189F5CB30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B6")]
		private bool OXHXFSMZAVM
		{
			[Cpp2IlInjected.Token(Token = "0x60002FE")]
			[Cpp2IlInjected.Address(RVA = "0x9F5C900", Offset = "0x9F5BD00", VA = "0x189F5C900")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400002D")]
		public event RbexAction BMPSQLCPXWX
		{
			[Cpp2IlInjected.Token(Token = "0x60002F9")]
			[Cpp2IlInjected.Address(RVA = "0x9F5CFE0", Offset = "0x9F5C3E0", VA = "0x189F5CFE0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0x9F5CF40", Offset = "0x9F5C340", VA = "0x189F5CF40", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x9F5D100", Offset = "0x9F5C500", VA = "0x189F5D100")]
		public LEWYWOEVFAG(URSPHDVDGTJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x9F5C4D0", Offset = "0x9F5B8D0", VA = "0x189F5C4D0", Slot = "6")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x9F5C5B0", Offset = "0x9F5B9B0", VA = "0x189F5C5B0", Slot = "8")]
		public void GGJCWZZXMSV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x9F5CCD0", Offset = "0x9F5C0D0", VA = "0x189F5CCD0", Slot = "7")]
		public bool TCSXBWLBQPF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x9F5CC00", Offset = "0x9F5C000", VA = "0x189F5CC00", Slot = "9")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x9F5C5C0", Offset = "0x9F5B9C0", VA = "0x189F5C5C0", Slot = "13")]
		public void HOZHVLOULRV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x9F5CE20", Offset = "0x9F5C220", VA = "0x189F5CE20", Slot = "12")]
		public void WPKCIMBMHZM(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x9F5CB90", Offset = "0x9F5BF90", VA = "0x189F5CB90", Slot = "10")]
		public bool RLNIMMFDKAJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x9F5C680", Offset = "0x9F5BA80", VA = "0x189F5C680", Slot = "11")]
		public bool LMUWTHBKLVO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x9F5C960", Offset = "0x9F5BD60", VA = "0x189F5C960")]
		private bool NYCXKQGESZA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x9F5C770", Offset = "0x9F5BB70", VA = "0x189F5C770")]
		private void LYKOMGTAJFW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	internal sealed class YQDBNAPCGRN : AZNEFAUWREM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private readonly HNPUCQYBPPM OHDFVYRXCOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private readonly WFSYYVMEPOE CXGPFBWWSWL;

		[Cpp2IlInjected.Token(Token = "0x170000B7")]
		public Rigidbody UKJPIVGVHRU
		{
			[Cpp2IlInjected.Token(Token = "0x600030B")]
			[Cpp2IlInjected.Address(RVA = "0xCFB370", Offset = "0xCFA770", VA = "0x180CFB370", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600030C")]
			[Cpp2IlInjected.Address(RVA = "0xCF6630", Offset = "0xCF5A30", VA = "0x180CF6630")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B8")]
		private bool OXHXFSMZAVM
		{
			[Cpp2IlInjected.Token(Token = "0x600030D")]
			[Cpp2IlInjected.Address(RVA = "0x9F692B0", Offset = "0x9F686B0", VA = "0x189F692B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B9")]
		public bool KACYWKWXBTV
		{
			[Cpp2IlInjected.Token(Token = "0x6000310")]
			[Cpp2IlInjected.Address(RVA = "0x1B61E40", Offset = "0x1B61240", VA = "0x181B61E40", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x9F6B1A0", Offset = "0x9F6A5A0", VA = "0x189F6B1A0")]
		public YQDBNAPCGRN(URSPHDVDGTJ a, [In] RigidbodyExData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x9F6AA00", Offset = "0x9F69E00", VA = "0x189F6AA00", Slot = "5")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x9F6AFC0", Offset = "0x9F6A3C0", VA = "0x189F6AFC0", Slot = "7")]
		public void PXCFFWKOAEJ(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x9F6AFF0", Offset = "0x9F6A3F0", VA = "0x189F6AFF0", Slot = "8")]
		public void UXGPABDHEWM(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x9F6AAA0", Offset = "0x9F69EA0", VA = "0x189F6AAA0", Slot = "9")]
		public void BTZHJVAQAZP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x9F6ADD0", Offset = "0x9F6A1D0", VA = "0x189F6ADD0", Slot = "10")]
		public void LFLMSPLKWDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x9F6B020", Offset = "0x9F6A420", VA = "0x189F6B020", Slot = "11")]
		public void XDIWIXMUIHL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	internal sealed class JEMZDUHWBTG : NZIHUDSLPRV, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private readonly HNPUCQYBPPM OHDFVYRXCOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private readonly WFSYYVMEPOE ANGBYEQVUGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private float YYVOIMTYQOZ;

		[Cpp2IlInjected.Token(Token = "0x170000BA")]
		public IDDHGUAZWOL TCXKPVMHZJW
		{
			[Cpp2IlInjected.Token(Token = "0x6000316")]
			[Cpp2IlInjected.Address(RVA = "0xCF4CF0", Offset = "0xCF40F0", VA = "0x180CF4CF0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000317")]
			[Cpp2IlInjected.Address(RVA = "0xCF6640", Offset = "0xCF5A40", VA = "0x180CF6640", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		public HFHEIEPYUFA ZNHTNHSXOAD
		{
			[Cpp2IlInjected.Token(Token = "0x6000318")]
			[Cpp2IlInjected.Address(RVA = "0xCF4C60", Offset = "0xCF4060", VA = "0x180CF4C60", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000319")]
			[Cpp2IlInjected.Address(RVA = "0xCFD4D0", Offset = "0xCFC8D0", VA = "0x180CFD4D0", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BC")]
		public Vector3 QXERQLBXURP
		{
			[Cpp2IlInjected.Token(Token = "0x600031A")]
			[Cpp2IlInjected.Address(RVA = "0x9F5AEB0", Offset = "0x9F5A2B0", VA = "0x189F5AEB0", Slot = "8")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600031B")]
			[Cpp2IlInjected.Address(RVA = "0x9F5AC80", Offset = "0x9F5A080", VA = "0x189F5AC80", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BD")]
		public Vector3 XNWSMOJCOQS
		{
			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(RVA = "0x9F59A90", Offset = "0x9F58E90", VA = "0x189F59A90", Slot = "10")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600031D")]
			[Cpp2IlInjected.Address(RVA = "0x9F5AB70", Offset = "0x9F59F70", VA = "0x189F5AB70", Slot = "11")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BE")]
		public Vector3 HGAQXEXIGYL
		{
			[Cpp2IlInjected.Token(Token = "0x600031E")]
			[Cpp2IlInjected.Address(RVA = "0x9F5C110", Offset = "0x9F5B510", VA = "0x189F5C110", Slot = "12")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600031F")]
			[Cpp2IlInjected.Address(RVA = "0x9F5ABA0", Offset = "0x9F59FA0", VA = "0x189F5ABA0", Slot = "13")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BF")]
		public Vector3 QDWNSCUTQZE
		{
			[Cpp2IlInjected.Token(Token = "0x6000320")]
			[Cpp2IlInjected.Address(RVA = "0x9F59F70", Offset = "0x9F59370", VA = "0x189F59F70", Slot = "14")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0x9F5BFB0", Offset = "0x9F5B3B0", VA = "0x189F5BFB0", Slot = "15")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C0")]
		public float UFRAKQYPUVL
		{
			[Cpp2IlInjected.Token(Token = "0x6000322")]
			[Cpp2IlInjected.Address(RVA = "0xD4C5C0", Offset = "0xD4B9C0", VA = "0x180D4C5C0", Slot = "16")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000323")]
			[Cpp2IlInjected.Address(RVA = "0x9F5BBB0", Offset = "0x9F5AFB0", VA = "0x189F5BBB0", Slot = "17")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C1")]
		public bool CLVBSNZWGIT
		{
			[Cpp2IlInjected.Token(Token = "0x6000324")]
			[Cpp2IlInjected.Address(RVA = "0x25E5C70", Offset = "0x25E5070", VA = "0x1825E5C70", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C2")]
		private EMYFGMLRIFJ LOASHIEGNNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000339")]
			[Cpp2IlInjected.Address(RVA = "0x949FE00", Offset = "0x949F200", VA = "0x18949FE00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C3")]
		private bool HDWETLJTBRH
		{
			[Cpp2IlInjected.Token(Token = "0x600033A")]
			[Cpp2IlInjected.Address(RVA = "0x9F5AC60", Offset = "0x9F5A060", VA = "0x189F5AC60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x9F5C3F0", Offset = "0x9F5B7F0", VA = "0x189F5C3F0")]
		public JEMZDUHWBTG(URSPHDVDGTJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x9F59630", Offset = "0x9F58A30", VA = "0x189F59630", Slot = "19")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x9F59A30", Offset = "0x9F58E30", VA = "0x189F59A30", Slot = "36")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x9F5BFE0", Offset = "0x9F5B3E0", VA = "0x189F5BFE0", Slot = "28")]
		public void ZBCMDVSWGQP(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x1907A20", Offset = "0x1906E20", VA = "0x181907A20", Slot = "20")]
		public void JZKAWCHVOJD(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x1908400", Offset = "0x1907800", VA = "0x181908400", Slot = "30")]
		public void PDDHDLROXBK(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x9F5A990", Offset = "0x9F59D90", VA = "0x189F5A990", Slot = "35")]
		public Vector3 ILSBOSDTUSB(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x9F59870", Offset = "0x9F58C70", VA = "0x189F59870", Slot = "34")]
		public Vector3 DRXXEGAWKEL(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x9F59630", Offset = "0x9F58A30", VA = "0x189F59630", Slot = "27")]
		public void ITKGGEWLPWQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x9F5AE50", Offset = "0x9F5A250", VA = "0x189F5AE50", Slot = "25")]
		public void OSOTIPUFLJT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x9F5B000", Offset = "0x9F5A400", VA = "0x189F5B000", Slot = "24")]
		public void QTAZRUZXNUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x9F5B060", Offset = "0x9F5A460", VA = "0x189F5B060", Slot = "33")]
		public void SYCDZWOYQLO(Vector3 a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x9F59BB0", Offset = "0x9F58FB0", VA = "0x189F59BB0", Slot = "32")]
		public void FXOABCNBUKJ(Vector3 a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x9F5B2A0", Offset = "0x9F5A6A0", VA = "0x189F5B2A0", Slot = "31")]
		public void TMKUKFEEEGE(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x9F5B440", Offset = "0x9F5A840", VA = "0x189F5B440", Slot = "22")]
		public void VHRZTUHXWKS(RbexImpulseType a, Vector3 b, float c, float d = 8f, float e = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x9F59C10", Offset = "0x9F59010", VA = "0x189F59C10", Slot = "21")]
		public void GRQHAZMWWHF(RbexRotationType a, Vector3 b, float c = 1f / 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x9F5A090", Offset = "0x9F59490", VA = "0x189F5A090", Slot = "23")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void IFPWHNMDZVC(RbexRotationType a, Vector3 b, float c = 7f, float d = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x1A56A80", Offset = "0x1A55E80", VA = "0x181A56A80")]
		private static void CMKAWTPUVKQ(Vector3 a, Vector3 b, [Out] Vector3 c, [Out] Vector3 d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x9F59E90", Offset = "0x9F59290", VA = "0x189F59E90", Slot = "29")]
		public Vector3 HIDEKTUGMXH(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x9F5C260", Offset = "0x9F5B660", VA = "0x189F5C260", Slot = "26")]
		public void ZWYVPNPVJCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x9F5BBB0", Offset = "0x9F5AFB0", VA = "0x189F5BBB0")]
		private void XBNVARRGSVD(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x9F596D0", Offset = "0x9F58AD0", VA = "0x189F596D0")]
		private void BXPEUKXAZCB(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x9F5AD40", Offset = "0x9F5A140", VA = "0x189F5AD40")]
		private Vector3 OGYDUJFQMDQ()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x9F5BCC0", Offset = "0x9F5B0C0", VA = "0x189F5BCC0")]
		private void YPZEILERRCC(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x9F5BA90", Offset = "0x9F5AE90", VA = "0x189F5BA90")]
		private Vector3 WCWRMZQLNKC()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x9F5A510", Offset = "0x9F59910", VA = "0x189F5A510")]
		private void IHZCBBUJUAW(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190")]
		private void RYTJYPESZMF(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190")]
		private void PFAXJPERDBJ()
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
