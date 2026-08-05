using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Logging.Attributes;
using RecRoom.Networking;
using RecRoom.ObjectModel;
using RecRoom.Utils.OverridableFields;
using UnityEngine;
using UnityEngine.Serialization;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_Rbex_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : CFJIINPOLDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x87AFF90", Offset = "0x87AE590", VA = "0x1887AFF90", Slot = "4")]
		public override void CCHHFLKMKEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA6F950", Offset = "0xA6DF50", VA = "0x180A6F950")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_Rbex_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private int[] localIndices0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private ServiceBitset bitset0;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xA47BE0", Offset = "0xA461E0", VA = "0x180A47BE0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8166190", Offset = "0x8164790", VA = "0x188166190", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x87B9F00", Offset = "0x87B8500", VA = "0x1887B9F00")]
		private void FKDKBEPAOOM(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x87BA210", Offset = "0x87B8810", VA = "0x1887BA210", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x87BA270", Offset = "0x87B8870", VA = "0x1887BA270")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[DisallowMultipleComponent]
	public sealed class RigidbodyEx : MonoBehaviour, KGNLHMPLHEM, ODGGGLKDEEB, CMENDJNMJBF
	{
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static readonly LHMKAIAPMBI FLOLNLEGEIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private bool IEDKACILPFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private KJMCALOBECF COCPPMIKKFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[PPBMPHDDNEA(CNNBEEFOMHL.Self, false, false, false)]
		[SerializeField]
		private Rigidbody unityRigidbody;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[SerializeField]
		[PPBMPHDDNEA(CNNBEEFOMHL.SelfAndParent, true, false, false)]
		private RRNetworkView rrNetworkView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[SerializeField]
		private OverridableVector3 precomputedCenterOfMass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[SerializeField]
		private OverridableVector3 customCenterOfMass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[SerializeField]
		[FormerlySerializedAs("forceNoInterpolation")]
		private PHONBPAKPKN physicsInterpolation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		[SerializeField]
		[Tooltip("If checked, this object's Unity Rigidbody will not be stripped when parenting the object to another RigidbodyEx. Only check this on objects that have a Unity Rigidbody by default and who need access to Unity physics events like OnTriggerEnter, OnCollisionEnter, etc. This is sometimes set via script instead of this flag.")]
		private bool keepUnityRigidbodyWhileParented;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5D")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[SerializeField]
		[Tooltip("If the RigidbodyEx has a parent that is being destroyed, this flag allows this RigidbodyEx to keep the parent set. The default behavior is thatthe parent property is set to null, resetting/clearing the existing parent when it is being destroyed.")]
		private bool keepParentOnParentDestroy;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5E")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[SerializeField]
		[HideInInspector]
		private bool hasUnityRigidbodyByDefault;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private Transform NIHFOINEKDF;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal KJMCALOBECF DMBMKBBNPKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x87B5570", Offset = "0x87B3B70", VA = "0x1887B5570")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private KJMCALOBECF LNPBGJKDPHM
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xA45140", Offset = "0xA43740", VA = "0x180A45140", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int FLLACKJMBDH
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x87B7410", Offset = "0x87B5A10", VA = "0x1887B7410")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RigidbodyEx JFHNMOPKLHD
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x87B7770", Offset = "0x87B5D70", VA = "0x1887B7770")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx JOCLBAADBME
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x87B76B0", Offset = "0x87B5CB0", VA = "0x1887B76B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RigidbodyEx NBIJLPJHNNE
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x87B8370", Offset = "0x87B6970", VA = "0x1887B8370")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x87B9870", Offset = "0x87B7E70", VA = "0x1887B9870")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool OJHFDJNPBGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x83DEAB0", Offset = "0x83DD0B0", VA = "0x1883DEAB0", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x83DEA30", Offset = "0x83DD030", VA = "0x1883DEA30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Transform DFOHJKCGEGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x2411F40", Offset = "0x2410540", VA = "0x182411F40", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Transform KGPNGGDHNMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x2411F40", Offset = "0x2410540", VA = "0x182411F40", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Transform EKICPBEHPHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x2411F40", Offset = "0x2410540", VA = "0x182411F40", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public CNFEEBNLJFN MGOHBGCOCLE
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x87B7470", Offset = "0x87B5A70", VA = "0x1887B7470")]
			get
			{
				return default(CNFEEBNLJFN);
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x87B9020", Offset = "0x87B7620", VA = "0x1887B9020")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool GKEDLOLAOJD
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x87B7A80", Offset = "0x87B6080", VA = "0x1887B7A80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool ICEMPBOOKEH
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x87B7590", Offset = "0x87B5B90", VA = "0x1887B7590")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public MJAJOILNJDL KJBKCIOGHJK
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x87B79C0", Offset = "0x87B5FC0", VA = "0x1887B79C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x87B91E0", Offset = "0x87B77E0", VA = "0x1887B91E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public IPBPHKFFBLO GNCKEPNHHLA
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x87B7960", Offset = "0x87B5F60", VA = "0x1887B7960")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x87B9170", Offset = "0x87B7770", VA = "0x1887B9170")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool DEKJBEEPNPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x87B78B0", Offset = "0x87B5EB0", VA = "0x1887B78B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Rigidbody AOLLOIANELI
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x87B7910", Offset = "0x87B5F10", VA = "0x1887B7910")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool HEKODFAGFLD
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x87B75F0", Offset = "0x87B5BF0", VA = "0x1887B75F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x87B9090", Offset = "0x87B7690", VA = "0x1887B9090")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool FNJDFNGBGBF
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x83E0810", Offset = "0x83DEE10", VA = "0x1883E0810", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float BOPCJONKHOA
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x87B8310", Offset = "0x87B6910", VA = "0x1887B8310")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float HOFHDHKPJLP
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x87B82B0", Offset = "0x87B68B0", VA = "0x1887B82B0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x87B9800", Offset = "0x87B7E00", VA = "0x1887B9800")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public float OIDFNHHAEBE
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x87B7CE0", Offset = "0x87B62E0", VA = "0x1887B7CE0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x87B9480", Offset = "0x87B7A80", VA = "0x1887B9480")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public float KMCPAMNNJNB
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x87B7AE0", Offset = "0x87B60E0", VA = "0x1887B7AE0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x87B9250", Offset = "0x87B7850", VA = "0x1887B9250")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public bool PDPJOOKCOPO
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x87B88C0", Offset = "0x87B6EC0", VA = "0x1887B88C0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x87B9DB0", Offset = "0x87B83B0", VA = "0x1887B9DB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Vector3 EJJIOPMHNFE
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x87B8090", Offset = "0x87B6690", VA = "0x1887B8090")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x87B95D0", Offset = "0x87B7BD0", VA = "0x1887B95D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public Vector3 OHICBPPECEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x87B8A00", Offset = "0x87B7000", VA = "0x1887B8A00")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public CollisionDetectionMode HBPEIOAEOLH
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x87B7C20", Offset = "0x87B6220", VA = "0x1887B7C20")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x87B93A0", Offset = "0x87B79A0", VA = "0x1887B93A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public float KONJLKJMJCK
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x87B7650", Offset = "0x87B5C50", VA = "0x1887B7650")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x87B9100", Offset = "0x87B7700", VA = "0x1887B9100")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public RigidbodyConstraints ONGNIJAFIJG
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x87B7C80", Offset = "0x87B6280", VA = "0x1887B7C80")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x87B9410", Offset = "0x87B7A10", VA = "0x1887B9410")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public Vector3 OJMOAFLPOMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x87B8430", Offset = "0x87B6A30", VA = "0x1887B8430")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public Vector3 FNJGBMAJNGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x87B8430", Offset = "0x87B6A30", VA = "0x1887B8430")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x87B9B90", Offset = "0x87B8190", VA = "0x1887B9B90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public float ADNFJIEHGHC
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x87B8170", Offset = "0x87B6770", VA = "0x1887B8170")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x87B96B0", Offset = "0x87B7CB0", VA = "0x1887B96B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public float JAPILAPJHEK
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x87B8860", Offset = "0x87B6E60", VA = "0x1887B8860")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x87B9D40", Offset = "0x87B8340", VA = "0x1887B9D40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Quaternion GOJHJJNEBAH
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x87B8510", Offset = "0x87B6B10", VA = "0x1887B8510")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x87B9910", Offset = "0x87B7F10", VA = "0x1887B9910")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Quaternion MOFKKEOHOBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x87B8790", Offset = "0x87B6D90", VA = "0x1887B8790")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x87B9C70", Offset = "0x87B8270", VA = "0x1887B9C70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector3 HGHJBNCEBKN
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x87B85E0", Offset = "0x87B6BE0", VA = "0x1887B85E0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x87B99E0", Offset = "0x87B7FE0", VA = "0x1887B99E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Quaternion LNJLGIKCPGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x87B86C0", Offset = "0x87B6CC0", VA = "0x1887B86C0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x87B9AC0", Offset = "0x87B80C0", VA = "0x1887B9AC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 OFCFOGHNCGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x87B8920", Offset = "0x87B6F20", VA = "0x1887B8920")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x87B9E20", Offset = "0x87B8420", VA = "0x1887B9E20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 AMBPKDHGONF
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x87B81D0", Offset = "0x87B67D0", VA = "0x1887B81D0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x87B9720", Offset = "0x87B7D20", VA = "0x1887B9720")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector3 BOPHMEPMHDE
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x87B7B40", Offset = "0x87B6140", VA = "0x1887B7B40")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x87B92C0", Offset = "0x87B78C0", VA = "0x1887B92C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector3 FKIKANGLALM
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x87B7FB0", Offset = "0x87B65B0", VA = "0x1887B7FB0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x87B94F0", Offset = "0x87B7AF0", VA = "0x1887B94F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector3 IOMBHEPGNNK
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x87B7E70", Offset = "0x87B6470", VA = "0x1887B7E70")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Quaternion HHJFGKOLDFM
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x87B7DA0", Offset = "0x87B63A0", VA = "0x1887B7DA0")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public Vector3 LIIIFFBJDPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x87B8BC0", Offset = "0x87B71C0", VA = "0x1887B8BC0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public Vector3 FCJKNKCLDPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x87B8AE0", Offset = "0x87B70E0", VA = "0x1887B8AE0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool BNFANHDEJGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x87B7F50", Offset = "0x87B6550", VA = "0x1887B7F50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool CAOKMKDOLFP
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x87B7A20", Offset = "0x87B6020", VA = "0x1887B7A20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool EFNEMHAAIPN
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x87B7530", Offset = "0x87B5B30", VA = "0x1887B7530")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool LPKNONELLNF
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x87B74D0", Offset = "0x87B5AD0", VA = "0x1887B74D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool IEPDCELLCEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x87B73B0", Offset = "0x87B59B0", VA = "0x1887B73B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public bool CKDBCKLKCDK
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x87B7D40", Offset = "0x87B6340", VA = "0x1887B7D40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool ICKKICKDNIH
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x25A1280", Offset = "0x259F880", VA = "0x1825A1280")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event CFAIFCIBAIO NEPFHEIEBMP
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x87B72D0", Offset = "0x87B58D0", VA = "0x1887B72D0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x87B8F40", Offset = "0x87B7540", VA = "0x1887B8F40")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event IBJOPKNCPIE JOMNOEOAHNP
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x87B7040", Offset = "0x87B5640", VA = "0x1887B7040")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x87B8CA0", Offset = "0x87B72A0", VA = "0x1887B8CA0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event IBJOPKNCPIE LLKDGIILKLP
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x87B70A0", Offset = "0x87B56A0", VA = "0x1887B70A0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x87B8D10", Offset = "0x87B7310", VA = "0x1887B8D10")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event IBJOPKNCPIE NJCIICKHHHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x87B71F0", Offset = "0x87B57F0", VA = "0x1887B71F0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x87B8E60", Offset = "0x87B7460", VA = "0x1887B8E60")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<LNDADOOHAMM, LNDADOOHAMM> NMFJEKGGLON
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x87B7180", Offset = "0x87B5780", VA = "0x1887B7180")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x87B8DF0", Offset = "0x87B73F0", VA = "0x1887B8DF0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event IBJOPKNCPIE DIPNDGKKKKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x87B7260", Offset = "0x87B5860", VA = "0x1887B7260")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x87B8ED0", Offset = "0x87B74D0", VA = "0x1887B8ED0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event IBJOPKNCPIE LDLAHBJKPEK
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x87B7340", Offset = "0x87B5940", VA = "0x1887B7340")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x87B8FB0", Offset = "0x87B75B0", VA = "0x1887B8FB0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event IBJOPKNCPIE JIHFGAOFDPI
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x87B7110", Offset = "0x87B5710", VA = "0x1887B7110")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x87B8D80", Offset = "0x87B7380", VA = "0x1887B8D80")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA451B0", Offset = "0xA437B0", VA = "0x180A451B0", Slot = "8")]
		private void LNMDGGFFCHD(KJMCALOBECF FIAONBPCJJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x87B5AB0", Offset = "0x87B40B0", VA = "0x1887B5AB0", Slot = "9")]
		public AEHFEICJLEG GetData()
		{
			return default(AEHFEICJLEG);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x87B5F20", Offset = "0x87B4520", VA = "0x1887B5F20")]
		internal void ODEGDKOKBBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x87B6D60", Offset = "0x87B5360", VA = "0x1887B6D60")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		public void TestOverrideUnityRigidbody(Rigidbody OJNHDOEHCKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x87B5800", Offset = "0x87B3E00", VA = "0x1887B5800")]
		public KGNLHMPLHEM GetChild(int KHMHPNKMLMD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x87B6A20", Offset = "0x87B5020", VA = "0x1887B6A20")]
		public void SetInertiaTensor((Quaternion rot, Vector3 moments) CGCPKONOFGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x87B53A0", Offset = "0x87B39A0", VA = "0x1887B53A0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x87B6CB0", Offset = "0x87B52B0", VA = "0x1887B6CB0")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x87B5570", Offset = "0x87B3B70", VA = "0x1887B5570")]
		private KJMCALOBECF BEFPCBIHDKD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x87B6130", Offset = "0x87B4730", VA = "0x1887B6130")]
		private void PNLBMDNIIGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x87B6070", Offset = "0x87B4670", VA = "0x1887B6070")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x87B5FB0", Offset = "0x87B45B0", VA = "0x1887B5FB0")]
		public void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x87B5F20", Offset = "0x87B4520", VA = "0x1887B5F20")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x87B6010", Offset = "0x87B4610", VA = "0x1887B6010")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x87B60D0", Offset = "0x87B46D0", VA = "0x1887B60D0")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x87B49F0", Offset = "0x87B2FF0", VA = "0x1887B49F0")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object DKFMAIJGPFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x87B62B0", Offset = "0x87B48B0", VA = "0x1887B62B0")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object DKFMAIJGPFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x87B57A0", Offset = "0x87B3DA0", VA = "0x1887B57A0")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x87B5EC0", Offset = "0x87B44C0", VA = "0x1887B5EC0")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x87B6B80", Offset = "0x87B5180", VA = "0x1887B6B80")]
		public void SetParent(RigidbodyEx KKGBKLFKCPO, bool NDGGHLKMBPJ = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x87B65C0", Offset = "0x87B4BC0", VA = "0x1887B65C0")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x87B5B50", Offset = "0x87B4150", VA = "0x1887B5B50")]
		public bool IsRigidbodyAncestor(RigidbodyEx GKCMBDHDPAA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x87B5C50", Offset = "0x87B4250", VA = "0x1887B5C50")]
		public bool IsRigidbodyDescendant(RigidbodyEx DMBNONNOPAP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x87B4C60", Offset = "0x87B3260", VA = "0x1887B4C60")]
		public void AddInterpolationRestriction(object DKFMAIJGPFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x87B6320", Offset = "0x87B4920", VA = "0x1887B6320")]
		public void RemoveInterpolationRestriction(object DKFMAIJGPFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x87B4CD0", Offset = "0x87B32D0", VA = "0x1887B4CD0")]
		public void AddKinematic(object DKFMAIJGPFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x87B6390", Offset = "0x87B4990", VA = "0x1887B6390")]
		public void RemoveKinematic(object DKFMAIJGPFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x87B6B00", Offset = "0x87B5100", VA = "0x1887B6B00")]
		public void SetKinematic(object DKFMAIJGPFL, bool PJBLBGNDEOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x87B6920", Offset = "0x87B4F20", VA = "0x1887B6920")]
		public void SetDiscontinuousPositionAndRotation(Vector3 EDIEACHMBOE, Quaternion OKJJFLANHCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x87B6820", Offset = "0x87B4E20", VA = "0x1887B6820")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 LEMEJCFGJPG, Quaternion JADFJJHPGEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x87B59A0", Offset = "0x87B3FA0", VA = "0x1887B59A0")]
		public Vector3 GetConstrainedVelocity(Vector3 OFCFOGHNCGN)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x87B5890", Offset = "0x87B3E90", VA = "0x1887B5890")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 BOPHMEPMHDE)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x87B4B70", Offset = "0x87B3170", VA = "0x1887B4B70")]
		public void AddForce(Vector3 KKBNDFNEENM, ForceMode CCCAMKIFFEK = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x87B4A60", Offset = "0x87B3060", VA = "0x1887B4A60")]
		public void AddForceAtPosition(Vector3 KKBNDFNEENM, Vector3 NHLFNDFGAHK, ForceMode CCCAMKIFFEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x87B4EA0", Offset = "0x87B34A0", VA = "0x1887B4EA0")]
		public void AddTorque(Vector3 PNINFNAAJFD, ForceMode CCCAMKIFFEK = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x87B4D40", Offset = "0x87B3340", VA = "0x1887B4D40")]
		public void AddRelativeTorque(Vector3 PNINFNAAJFD, ForceMode CCCAMKIFFEK = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x87B6E30", Offset = "0x87B5430", VA = "0x1887B6E30")]
		public Vector3 WorldToLocalVelocity(Vector3 LMKBILFPCNN)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x87B5DB0", Offset = "0x87B43B0", VA = "0x1887B5DB0")]
		public Vector3 LocalToWorldVelocity(Vector3 AMBPKDHGONF)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x87B5740", Offset = "0x87B3D40", VA = "0x1887B5740")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x87B56E0", Offset = "0x87B3CE0", VA = "0x1887B56E0")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x87B5680", Offset = "0x87B3C80", VA = "0x1887B5680")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x87B5620", Offset = "0x87B3C20", VA = "0x1887B5620")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x87B6720", Offset = "0x87B4D20", VA = "0x1887B6720")]
		public void ResetVelocityWorldSpace(Vector3 OMBFIEDHDAB, Vector3 MIBCMGLMBGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x87B6620", Offset = "0x87B4C20", VA = "0x1887B6620")]
		public void ResetVelocityLocalSpace(Vector3 MGMMJFCDLHO, Vector3 FKIKANGLALM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x87B64E0", Offset = "0x87B4AE0", VA = "0x1887B64E0")]
		public void ResetLinearVelocityLocalSpace(Vector3 MGMMJFCDLHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x87B6CC0", Offset = "0x87B52C0", VA = "0x1887B6CC0")]
		public bool SweepTest(Vector3 GJGHBLDDKFD, [Out] RaycastHit EBBBOJFKCOH, float AMEHFMMOAMH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x87B5D50", Offset = "0x87B4350", VA = "0x1887B5D50")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x87B6C50", Offset = "0x87B5250", VA = "0x1887B6C50")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x87B6DD0", Offset = "0x87B53D0", VA = "0x1887B6DD0")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x87B4E30", Offset = "0x87B3430", VA = "0x1887B4E30")]
		public void AddShouldHaveUnityRigidbodyToken(object DKFMAIJGPFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x87B6400", Offset = "0x87B4A00", VA = "0x1887B6400")]
		public void RemoveShouldHaveUnityRigidbodyToken(object DKFMAIJGPFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x87B5230", Offset = "0x87B3830", VA = "0x1887B5230")]
		public void ApplyForceVelocityChange(JKINPDBJECI FOGGOOKDANB, Vector3 ECHOKDNKMPC, float EPGAPBLIBEP, float PNMMNFPGPCG = 8f, float AIFIBMGEPIP = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x87B5130", Offset = "0x87B3730", VA = "0x1887B5130")]
		public void ApplyAngularVelocityChange(PKMLAHKLCAB FMNNFHFKKOM, Vector3 HOKDDCLKNCO, float FDOEOEDHBAF = float.PositiveInfinity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x87B52F0", Offset = "0x87B38F0", VA = "0x1887B52F0")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void ApplyTorqueAngularVelocityChangeDeprecated(PKMLAHKLCAB FMNNFHFKKOM, Vector3 CFFPEJBOBIA, float KNNDKDAPHBD = 7f, float EBHHKGCDOIB = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x87B5060", Offset = "0x87B3660", VA = "0x1887B5060")]
		public bool AllowedScaleChange(float OKDFECFEJGM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x87B4F90", Offset = "0x87B3590", VA = "0x1887B4F90")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx PAHOJJMFJGN, object DKFMAIJGPFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x87B6470", Offset = "0x87B4A70", VA = "0x1887B6470")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object DKFMAIJGPFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x87B5B40", Offset = "0x87B4140", VA = "0x1887B5B40", Slot = "13")]
		private void IMGMJLGLFKF(HPECJEKLOEK HILCMKALFIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x87B6FD0", Offset = "0x87B55D0", VA = "0x1887B6FD0")]
		public RigidbodyEx()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xAC4350", Offset = "0xAC2950", VA = "0x180AC4350", Slot = "4")]
		private GameObject IDNFJAGPIAA()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0xA71DD0", Offset = "0xA703D0", VA = "0x180A71DD0", Slot = "10")]
		private bool HIIIPJGJLMB()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal static class JPCNHMNIBCI
{
	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x87AC4C0", Offset = "0x87AAAC0", VA = "0x1887AC4C0")]
	public static KJMCALOBECF DMBMKBBNPKJ(this RigidbodyEx ALKKIHFIKDP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[RegisterService(typeof(JFFKGDNKPBG), new string[] { })]
public class GOJKLOJIJCN : JFFKGDNKPBG, JPODKHCGMPE
{
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly LHMKAIAPMBI NDJJBNFFFGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private NBDNOIPMIEH ACIHABPADPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private HCMIBJICIGH KIPDHBJPCFJ;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public NBDNOIPMIEH NPBKIMIDKGK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public HCMIBJICIGH ILCLGDBADDL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x87A7CA0", Offset = "0x87A62A0", VA = "0x1887A7CA0", Slot = "7")]
	public void InitReferences(MGPNAOEDNIM KIIAJJAGEIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x87A7D10", Offset = "0x87A6310", VA = "0x1887A7D10", Slot = "6")]
	public KJMCALOBECF NCKHGGNLDGJ(RigidbodyEx ALKKIHFIKDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public GOJKLOJIJCN()
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class PhysicsManager : SingletonMonoBehaviour<PhysicsManager>
	{
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static LGEBFGGIOJB UpdateAfterFixedUpdateRan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int JKOCHDOGOOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private int GCJPFMBFBOC;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x87B4850", Offset = "0x87B2E50", VA = "0x1887B4850")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x87B4890", Offset = "0x87B2E90", VA = "0x1887B4890")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x87B4870", Offset = "0x87B2E70", VA = "0x1887B4870")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string CJIMOMNMAGD, [Optional] UnityEngine.Object HILCMKALFIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string CJIMOMNMAGD, [Optional] UnityEngine.Object HILCMKALFIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x87B49A0", Offset = "0x87B2FA0", VA = "0x1887B49A0")]
		public PhysicsManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class DEICEHNCJEC
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class FEJLNDMJHDP : MJAJOILNJDL, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0xA559F0", Offset = "0xA53FF0", VA = "0x180A559F0", Slot = "4")]
		public Vector3 FKLALKFKICC()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0xA559F0", Offset = "0xA53FF0", VA = "0x180A559F0", Slot = "5")]
		public Vector3 HKFLDCKPPLD()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xA603F0", Offset = "0xA5E9F0", VA = "0x180A603F0", Slot = "6")]
		public bool OOFLDNJMHOP(float BNMINBKLIME, float LFAGHDNDEOL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public FEJLNDMJHDP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public static MJAJOILNJDL DOEIEHPBCEO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x87A5690", Offset = "0x87A3C90", VA = "0x1887A5690")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface EFLFFNGPEAG
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	CollisionDetectionMode EHGBNOBIOHO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JPNPNACFNCO();

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JGKGPGNILIC(bool BNFANHDEJGB);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IACNAHEHCPE(bool BNFANHDEJGB);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MGGOCMEMKAK(Rigidbody GPPACDEEKNJ);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool CDEGNLJIFMN(Vector3 GJGHBLDDKFD, [Out] RaycastHit EBBBOJFKCOH, float AMEHFMMOAMH);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface DOPBDGLDMOL : IDisposable, DJOKFDLOFME
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	CNFEEBNLJFN MGOHBGCOCLE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action<LNDADOOHAMM, LNDADOOHAMM> NMFJEKGGLON;

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JPNPNACFNCO();
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[ServiceLifetime(Lifetime.Application)]
public interface HCMIBJICIGH
{
	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MONFGFMMGOK BCDDAJMNCEO(KJMCALOBECF FIAONBPCJJK);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	BEFAFDJEHJB NIKAFFPBHHN(KJMCALOBECF FIAONBPCJJK);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	CMBEENEIOMB OPKBONCNKOD(KJMCALOBECF FIAONBPCJJK);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IFGFNJLIAFE MIMIEBFKBEP(KJMCALOBECF FIAONBPCJJK);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	HGLPIHPJLIE GHIAMEIPGFK(KJMCALOBECF FIAONBPCJJK);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	DOPBDGLDMOL BOGILHNAAPM(KJMCALOBECF FIAONBPCJJK);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	EJBKHGLAIFG HHDHMHLHNPC(KJMCALOBECF FIAONBPCJJK);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "7")]
	HGHNDMMNMJH HMGJKLBKEIC(KJMCALOBECF FIAONBPCJJK);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "8")]
	EFLFFNGPEAG HAHEIFJFAPA(KJMCALOBECF FIAONBPCJJK);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "9")]
	MBKDOMKMJNE EOICLNLFBDF(KJMCALOBECF FIAONBPCJJK);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "10")]
	FGDJKKPDMOO DADPBPGIPDP(KJMCALOBECF FIAONBPCJJK, [In] AEHFEICJLEG ACJFHCNBBBO);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "11")]
	OBHINKDPFLF HLCIOFPHKBI(KJMCALOBECF FIAONBPCJJK, [In] AEHFEICJLEG ACJFHCNBBBO);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "12")]
	GGAAAJEJDEF MNIEGJINFMB(KJMCALOBECF FIAONBPCJJK, [In] AEHFEICJLEG ACJFHCNBBBO);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "13")]
	MJFDIPNHEKF AHLNLDEMKOD(KJMCALOBECF FIAONBPCJJK, [In] AEHFEICJLEG ACJFHCNBBBO);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "14")]
	OKBLJHHOEFJ HDCCNKEFELC(KJMCALOBECF FIAONBPCJJK, [In] AEHFEICJLEG ACJFHCNBBBO);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "15")]
	KJMCALOBECF NCKHGGNLDGJ(RigidbodyEx ALKKIHFIKDP, AEHFEICJLEG ACJFHCNBBBO, JFFKGDNKPBG MIPDPIDNIBN);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface HGHNDMMNMJH
{
	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LGJPECALCNE(Vector3 KKBNDFNEENM, ForceMode CCCAMKIFFEK = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LMFLFHEKGGA(Vector3 KKBNDFNEENM, Vector3 NHLFNDFGAHK, ForceMode CCCAMKIFFEK);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MMLPGPOAMNO(Vector3 PNINFNAAJFD, ForceMode CCCAMKIFFEK = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FHFLJNMLPGN(Vector3 PNINFNAAJFD, ForceMode CCCAMKIFFEK = ForceMode.Force);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface MBKDOMKMJNE
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool KIMELNKGEOH
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MGGOCMEMKAK(Rigidbody GPPACDEEKNJ);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MDDDFGANMPF(Rigidbody GPPACDEEKNJ);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface MONFGFMMGOK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	IReadOnlyList<KJMCALOBECF> CNLIFHFENIG
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	KJMCALOBECF JOCLBAADBME
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	KJMCALOBECF GCMDLKAOFPF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event IBJOPKNCPIE JOMNOEOAHNP;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event IBJOPKNCPIE LLKDGIILKLP;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event CFAIFCIBAIO LBHMOJIBAAG;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action AMGABJOGBLD;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action IBINBCCJOGN;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action<KJMCALOBECF> AKNCJGMJBII;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<KJMCALOBECF> NGIHHMMKLKB;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event Action FOFFABIGKFL;

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action<KJMCALOBECF> MCNHNOLLGFG;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void KNEPPBFGJJO(KJMCALOBECF BADBAFBEKHJ, bool NDGGHLKMBPJ = false);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface CMBEENEIOMB
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	Vector3 MMIFFNNBOLO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	Vector3 MAFELFPNHAN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GBGEOBFKNCM(KJMCALOBECF NBIJLPJHNNE, object DKFMAIJGPFL);

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LLILGAJCKBM(object DKFMAIJGPFL);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface MJFDIPNHEKF
{
	[Cpp2IlInjected.Token(Token = "0x17000041")]
	Vector3 LHHCANCPEFO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	Vector3 EHHNFHGNBGC
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	float GMADLJBMDMN
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	float HLGEDMHJMGH
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	Vector3 NJILMMEDHAE
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	Quaternion OHGPMDHLAAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event IBJOPKNCPIE CHNGAKOHMLA;

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void EEFCCNMFBOF((Quaternion rot, Vector3 moments) CGCPKONOFGF);

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void KIDAJKBLJEN();

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void LFELPMNNODD();

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void KEBCPPFCMHF();

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void MGGOCMEMKAK(Rigidbody GPPACDEEKNJ);

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void MDDDFGANMPF(Rigidbody GPPACDEEKNJ);

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void ONCMLPOKMBK();
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface GGAAAJEJDEF
{
	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JPNPNACFNCO();

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NAHLNMNCMLP(object DKFMAIJGPFL);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IGADNBPFGEJ(object DKFMAIJGPFL);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MBEFMCKGHIM(KJMCALOBECF ALKKIHFIKDP);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OAGLIAPFFLN(KJMCALOBECF ALKKIHFIKDP);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NNIFHBANJAL();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface EJBKHGLAIFG
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool HLKDNGBMEHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event IBJOPKNCPIE KIJLJIHBNPL;

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MIDNGBHBBFF(object DKFMAIJGPFL);

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NEPDGGGEIHI(object DKFMAIJGPFL);

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AMAMAGGPGCK(object DKFMAIJGPFL, bool PJBLBGNDEOD);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void MGGOCMEMKAK(Rigidbody DLDHGDFMDNB);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void MDDDFGANMPF(Rigidbody GPPACDEEKNJ);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface OBHINKDPFLF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000048")]
	bool GKEDLOLAOJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool ICEMPBOOKEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event IBJOPKNCPIE ADFEEMIDPKF;

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JPNPNACFNCO();

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MMNFPLBAPLI(KJMCALOBECF NBIJLPJHNNE);

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void MKNEGKDAFPI(KJMCALOBECF NBIJLPJHNNE);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface OKBLJHHOEFJ
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	bool HEKODFAGFLD
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool PDBPNGNHNCI
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	RigidbodyConstraints FJCAHLOMPNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MGGOCMEMKAK(Rigidbody GPPACDEEKNJ);

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void MDDDFGANMPF(Rigidbody GPPACDEEKNJ);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface IFGFNJLIAFE
{
	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	float JBIBDAIFABP
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	float NFEEKMEAMML
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MGGOCMEMKAK(Rigidbody GPPACDEEKNJ);

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MDDDFGANMPF(Rigidbody GPPACDEEKNJ);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface HGLPIHPJLIE
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	static bool GDHLDKDMICL;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event IBJOPKNCPIE PGMDFIFMFPA;

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JPNPNACFNCO();

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool EBIFDFGHHKF();

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BPKNKPDCKFO();

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void ANEGIPGNHPK();

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool ADBKGEAHJLP();

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool CACCNINOMND();

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void KAPFKPODLFL(bool OAMIGNKBLII);

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void OCBPHJPKKED();
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface FGDJKKPDMOO
{
	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	Rigidbody AOLLOIANELI
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	bool MCNIKJMJAAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JPNPNACFNCO();

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GHAIAGLOMLE(object DKFMAIJGPFL);

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MILCNPIKOKP(object DKFMAIJGPFL);

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void ADAGCIPACAO();
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface BEFAFDJEHJB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000051")]
	MJAJOILNJDL KJBKCIOGHJK
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	IPBPHKFFBLO GNCKEPNHHLA
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	Vector3 OEOMMCEFOBI
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	Vector3 BFKLLHBBDEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	Vector3 EHFIENHFGIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	Vector3 CHPFEECDGGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	float KONJLKJMJCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	bool DEKJBEEPNPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void JPNPNACFNCO();

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void CLEADCDDLCH(object DKFMAIJGPFL);

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void EDLINEFOPPD(PKMLAHKLCAB FMNNFHFKKOM, Vector3 HOKDDCLKNCO, float FDOEOEDHBAF = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void HECHANHAPKA(JKINPDBJECI FOGGOOKDANB, Vector3 ECHOKDNKMPC, float EPGAPBLIBEP, float PNMMNFPGPCG = 8f, float AIFIBMGEPIP = 1f);

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void ANJLPPOBDJL(PKMLAHKLCAB FMNNFHFKKOM, Vector3 CFFPEJBOBIA, float KNNDKDAPHBD = 7f, float EBHHKGCDOIB = 1f);

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void NKFNDPLCMBN();

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void BEFPNKGEDNP();

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void OCPLIMNHADO();

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void EIFOBIMJAGC();

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void MGGOCMEMKAK(Rigidbody GPPACDEEKNJ);

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Vector3 JFBJCEJGNFB(Vector3 OFCFOGHNCGN);

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void ECJHCMEDENB(object DKFMAIJGPFL);

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void EEMAPOGAEKE(Vector3 BGCEGOALDCG);

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void NLELMACGJLN(Vector3 MGMMJFCDLHO, Vector3 FKIKANGLALM);

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void PALKGBIDBNA(Vector3 OMBFIEDHDAB, Vector3 MIBCMGLMBGC);

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "30")]
	Vector3 LBHKOCIKHGA(Vector3 AMBPKDHGONF);

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Vector3 CKABKLDEEOE(Vector3 LMKBILFPCNN);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[ServiceLifetime(Lifetime.Application)]
public interface NBDNOIPMIEH
{
	[Cpp2IlInjected.Token(Token = "0x17000059")]
	bool GNPEGBBGCMF
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LCLHCLDMALH(string NNDNCFBMBFL);

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OFLNKKPKBDC(RigidbodyEx ALKKIHFIKDP, Action CJDOILFHDJI);

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	KAIJBBJPFNN LJJMAOCCNNE(int LFGEOKGIAHJ);

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GEPJCEPDDIH(Vector3 OHICBPPECEJ, float OHOJHDEMDFA, Color HFIMNHFKOFL);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[ServiceLifetime(Lifetime.Application)]
public interface JFFKGDNKPBG
{
	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	NBDNOIPMIEH NPBKIMIDKGK
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	HCMIBJICIGH ILCLGDBADDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(Slot = "2")]
	KJMCALOBECF NCKHGGNLDGJ(RigidbodyEx ALKKIHFIKDP);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class CLOFJJADLBN : KJMCALOBECF, IDisposable, CNJCGLHEOAD
{
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public static bool BDNEBMGBCJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	internal readonly JFFKGDNKPBG MIPDPIDNIBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal MONFGFMMGOK BCEMINIMFEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal GGAAAJEJDEF GMJHLGKJJOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	internal OBHINKDPFLF GLLMOEOPEBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal BEFAFDJEHJB OFCFOGHNCGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal CMBEENEIOMB AJKFJGGCLJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	internal MJFDIPNHEKF MAILNPJLBJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	internal IFGFNJLIAFE POLIOBCOOHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	internal MBKDOMKMJNE JMGKBLCLPJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	internal HGLPIHPJLIE JABHMOPIJLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	internal DOPBDGLDMOL LKOPFLPLKPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	internal EJBKHGLAIFG AEGGHOIABEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	internal HGHNDMMNMJH KKBNDFNEENM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	internal OKBLJHHOEFJ AFBJPJHMPCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	internal FGDJKKPDMOO GPPACDEEKNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	internal EFLFFNGPEAG PPPAIFIECPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	internal IDisposable FDMKHNJAAHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private bool COILKELDAEI;

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public DAHJHHJGHIB DOMEJHDGAMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0xA46A00", Offset = "0xA45000", VA = "0x180A46A00", Slot = "22")]
		get
		{
			return default(DAHJHHJGHIB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public KGNLHMPLHEM MNEFNILIAGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0xAB0BF0", Offset = "0xAAF1F0", VA = "0x180AB0BF0", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0xF26510", Offset = "0xF24B10", VA = "0x180F26510")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public GameObject IOJHMLDNPHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0xA51E60", Offset = "0xA50460", VA = "0x180A51E60", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0xA51EE0", Offset = "0xA504E0", VA = "0x180A51EE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public Transform BDBOCHCKBIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xE23A60", Offset = "0xE22060", VA = "0x180E23A60", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0xF2B480", Offset = "0xF29A80", VA = "0x180F2B480")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public Rigidbody AOLLOIANELI
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x87A2320", Offset = "0x87A0920", VA = "0x1887A2320", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public KJMCALOBECF GCMDLKAOFPF
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x87A1790", Offset = "0x879FD90", VA = "0x1887A1790", Slot = "27")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x879F090", Offset = "0x879D690", VA = "0x18879F090", Slot = "28")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public int FLLACKJMBDH
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x879F410", Offset = "0x879DA10", VA = "0x18879F410", Slot = "31")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public KJMCALOBECF JOCLBAADBME
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x87A18F0", Offset = "0x879FEF0", VA = "0x1887A18F0", Slot = "29")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public bool IKAKALLGAEP
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x879EFD0", Offset = "0x879D5D0", VA = "0x18879EFD0", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public bool GKEDLOLAOJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x87A44E0", Offset = "0x87A2AE0", VA = "0x1887A44E0", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public bool ICEMPBOOKEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x87A5510", Offset = "0x87A3B10", VA = "0x1887A5510", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public MJAJOILNJDL KJBKCIOGHJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x879FA90", Offset = "0x879E090", VA = "0x18879FA90", Slot = "35")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x87A3AD0", Offset = "0x87A20D0", VA = "0x1887A3AD0", Slot = "36")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public IPBPHKFFBLO GNCKEPNHHLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x87A1840", Offset = "0x879FE40", VA = "0x1887A1840", Slot = "37")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x87A1B60", Offset = "0x87A0160", VA = "0x1887A1B60", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public float KONJLKJMJCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x879EF80", Offset = "0x879D580", VA = "0x18879EF80", Slot = "39")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x87A1890", Offset = "0x879FE90", VA = "0x1887A1890", Slot = "40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public Vector3 BFKLLHBBDEE
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x87A09F0", Offset = "0x879EFF0", VA = "0x1887A09F0", Slot = "41")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x87A4720", Offset = "0x87A2D20", VA = "0x1887A4720", Slot = "42")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public Vector3 CHPFEECDGGP
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x87A5010", Offset = "0x87A3610", VA = "0x1887A5010", Slot = "43")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x87A1510", Offset = "0x879FB10", VA = "0x1887A1510", Slot = "44")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public Vector3 OEOMMCEFOBI
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x87A3E70", Offset = "0x87A2470", VA = "0x1887A3E70", Slot = "45")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x87A2A40", Offset = "0x87A1040", VA = "0x1887A2A40", Slot = "46")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public Vector3 EHFIENHFGIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x87A2DB0", Offset = "0x87A13B0", VA = "0x1887A2DB0", Slot = "47")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x87A3330", Offset = "0x87A1930", VA = "0x1887A3330", Slot = "48")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public bool EFNEMHAAIPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x87A2BF0", Offset = "0x87A11F0", VA = "0x1887A2BF0", Slot = "49")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public bool LPKNONELLNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x87A0CE0", Offset = "0x879F2E0", VA = "0x1887A0CE0", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public bool IEPDCELLCEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x87A4640", Offset = "0x87A2C40", VA = "0x1887A4640", Slot = "51")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public bool DEKJBEEPNPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x87A4530", Offset = "0x87A2B30", VA = "0x1887A4530", Slot = "52")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public Vector3 MMIFFNNBOLO
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x879F960", Offset = "0x879DF60", VA = "0x18879F960", Slot = "53")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public Vector3 MAFELFPNHAN
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x87A2370", Offset = "0x87A0970", VA = "0x1887A2370", Slot = "54")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public Vector3 LHHCANCPEFO
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x87A0140", Offset = "0x879E740", VA = "0x1887A0140", Slot = "55")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x87A2550", Offset = "0x87A0B50", VA = "0x1887A2550", Slot = "56")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public Vector3 EHHNFHGNBGC
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x87A0060", Offset = "0x879E660", VA = "0x1887A0060", Slot = "57")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public float GMADLJBMDMN
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x87A1690", Offset = "0x879FC90", VA = "0x1887A1690", Slot = "58")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public float HLGEDMHJMGH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x87A2C90", Offset = "0x87A1290", VA = "0x1887A2C90", Slot = "59")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x87A4A40", Offset = "0x87A3040", VA = "0x1887A4A40", Slot = "60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public Vector3 NJILMMEDHAE
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x87A2080", Offset = "0x87A0680", VA = "0x1887A2080", Slot = "61")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public Quaternion OHGPMDHLAAH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x87A03D0", Offset = "0x879E9D0", VA = "0x1887A03D0", Slot = "62")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public float JBIBDAIFABP
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x87A2770", Offset = "0x87A0D70", VA = "0x1887A2770", Slot = "64")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x87A0320", Offset = "0x879E920", VA = "0x1887A0320", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public float NFEEKMEAMML
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x87A3030", Offset = "0x87A1630", VA = "0x1887A3030", Slot = "66")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x87A4BF0", Offset = "0x87A31F0", VA = "0x1887A4BF0", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public bool KIMELNKGEOH
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x87A2270", Offset = "0x87A0870", VA = "0x1887A2270", Slot = "68")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x87A0C80", Offset = "0x879F280", VA = "0x1887A0C80", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public CNFEEBNLJFN MGOHBGCOCLE
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x87A2160", Offset = "0x87A0760", VA = "0x1887A2160", Slot = "70")]
		get
		{
			return default(CNFEEBNLJFN);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x87A0B30", Offset = "0x879F130", VA = "0x1887A0B30", Slot = "71")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public bool HLKDNGBMEHB
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x879FE30", Offset = "0x879E430", VA = "0x18879FE30", Slot = "72")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public Transform EKICPBEHPHC
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0xE23A60", Offset = "0xE22060", VA = "0x180E23A60", Slot = "73")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public Vector3 OAIHMNHMDLD
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x879F310", Offset = "0x879D910", VA = "0x18879F310", Slot = "74")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x87A3D60", Offset = "0x87A2360", VA = "0x1887A3D60", Slot = "75")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public float EFEHBBKPJFD
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x879FCE0", Offset = "0x879E2E0", VA = "0x18879FCE0", Slot = "76")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x87A0B90", Offset = "0x879F190", VA = "0x1887A0B90", Slot = "77")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public float MDMNADBPKPM
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x87A3560", Offset = "0x87A1B60", VA = "0x1887A3560", Slot = "78")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x87A1C70", Offset = "0x87A0270", VA = "0x1887A1C70", Slot = "79")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public Quaternion LKJFNILHINF
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x87A1D70", Offset = "0x87A0370", VA = "0x1887A1D70", Slot = "80")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x879FB80", Offset = "0x879E180", VA = "0x18879FB80", Slot = "81")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public Vector3 DCMHMEMBABG
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x879FDF0", Offset = "0x879E3F0", VA = "0x18879FDF0", Slot = "82")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x87A15F0", Offset = "0x879FBF0", VA = "0x1887A15F0", Slot = "83")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public Quaternion DMNEFDLDHJA
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x879F8C0", Offset = "0x879DEC0", VA = "0x18879F8C0", Slot = "84")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x87A37D0", Offset = "0x87A1DD0", VA = "0x1887A37D0", Slot = "85")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public RigidbodyConstraints FJCAHLOMPNG
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x87A1A00", Offset = "0x87A0000", VA = "0x1887A1A00", Slot = "86")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x879F900", Offset = "0x879DF00", VA = "0x18879F900", Slot = "87")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public bool HEKODFAGFLD
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x87A2E90", Offset = "0x87A1490", VA = "0x1887A2E90", Slot = "88")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x87A17E0", Offset = "0x879FDE0", VA = "0x1887A17E0", Slot = "89")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public CollisionDetectionMode EHGBNOBIOHO
	{
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x87A16E0", Offset = "0x879FCE0", VA = "0x1887A16E0", Slot = "90")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x87A3D00", Offset = "0x87A2300", VA = "0x1887A3D00", Slot = "91")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public bool MAAOCEBLMNB
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x87A13D0", Offset = "0x879F9D0", VA = "0x1887A13D0", Slot = "141")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public bool CAOKMKDOLFP
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x879FEE0", Offset = "0x879E4E0", VA = "0x18879FEE0", Slot = "92")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event IBJOPKNCPIE JOMNOEOAHNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x879F860", Offset = "0x879DE60", VA = "0x18879F860", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x87A0AD0", Offset = "0x879F0D0", VA = "0x1887A0AD0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event IBJOPKNCPIE LLKDGIILKLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x87A1FC0", Offset = "0x87A05C0", VA = "0x1887A1FC0", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x87A21B0", Offset = "0x87A07B0", VA = "0x1887A21B0", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event CFAIFCIBAIO LBHMOJIBAAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x87A4AA0", Offset = "0x87A30A0", VA = "0x1887A4AA0", Slot = "18")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x87A2020", Offset = "0x87A0620", VA = "0x1887A2020", Slot = "19")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event IBJOPKNCPIE ADFEEMIDPKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x87A1630", Offset = "0x879FC30", VA = "0x1887A1630", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x879F800", Offset = "0x879DE00", VA = "0x18879F800", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event IBJOPKNCPIE NJCIICKHHHN
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x879F030", Offset = "0x879D630", VA = "0x18879F030", Slot = "14")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x879FE80", Offset = "0x879E480", VA = "0x18879FE80", Slot = "15")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event IBJOPKNCPIE PGMDFIFMFPA
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x87A1BC0", Offset = "0x87A01C0", VA = "0x1887A1BC0", Slot = "16")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x87A3990", Offset = "0x87A1F90", VA = "0x1887A3990", Slot = "17")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	public event Action<LNDADOOHAMM, LNDADOOHAMM> NMFJEKGGLON
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x87A0C20", Offset = "0x879F220", VA = "0x1887A0C20", Slot = "20")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x87A2210", Offset = "0x87A0810", VA = "0x1887A2210", Slot = "21")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event IBJOPKNCPIE KIJLJIHBNPL
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x87A3570", Offset = "0x87A1B70", VA = "0x1887A3570", Slot = "12")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x87A3160", Offset = "0x87A1760", VA = "0x1887A3160", Slot = "13")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event IBJOPKNCPIE JIHFGAOFDPI
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x87A11B0", Offset = "0x879F7B0", VA = "0x1887A11B0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x87A0D40", Offset = "0x879F340", VA = "0x1887A0D40", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x87A55A0", Offset = "0x87A3BA0", VA = "0x1887A55A0")]
	public CLOFJJADLBN(GameObject KGMBEOBCDCB, RigidbodyEx GIIIFIPBDPJ, JFFKGDNKPBG MIPDPIDNIBN, [In] AEHFEICJLEG ACJFHCNBBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x87A5220", Offset = "0x87A3820", VA = "0x1887A5220", Slot = "139")]
	protected virtual void PHANICPNFAG(JFFKGDNKPBG MIPDPIDNIBN, AEHFEICJLEG ACJFHCNBBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x87A0220", Offset = "0x879E820", VA = "0x1887A0220", Slot = "140")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x87A2630", Offset = "0x87A0C30", VA = "0x1887A2630", Slot = "93")]
	public void JPNPNACFNCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x879EEF0", Offset = "0x879D4F0", VA = "0x18879EEF0", Slot = "94")]
	public void AEFBOPMEEJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x87A0840", Offset = "0x879EE40", VA = "0x1887A0840", Slot = "95")]
	public void EGLADLOFENO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x879FC60", Offset = "0x879E260", VA = "0x18879FC60", Slot = "96")]
	public void CHHMHFNCKII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x87A27C0", Offset = "0x87A0DC0", VA = "0x1887A27C0")]
	private void KAPFKPODLFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x87A2B20", Offset = "0x87A1120", VA = "0x1887A2B20")]
	private void KDCCGNHLNDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x879FA30", Offset = "0x879E030", VA = "0x18879FA30")]
	private void CACCNINOMND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x87A1F40", Offset = "0x87A0540", VA = "0x1887A1F40", Slot = "30")]
	public KJMCALOBECF IDLOPLPDGLN(int KHMHPNKMLMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x87A2CE0", Offset = "0x87A12E0", VA = "0x1887A2CE0", Slot = "98")]
	public void KNEPPBFGJJO(KJMCALOBECF KKGBKLFKCPO, bool NDGGHLKMBPJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x87A2D50", Offset = "0x87A1350", VA = "0x1887A2D50", Slot = "99")]
	public void KNHKJJDGBFO(object DKFMAIJGPFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x87A31C0", Offset = "0x87A17C0", VA = "0x1887A31C0", Slot = "100")]
	public void LJEPLLPMEGD(object DKFMAIJGPFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x879FCF0", Offset = "0x879E2F0", VA = "0x18879FCF0", Slot = "101")]
	public Vector3 CKABKLDEEOE(Vector3 LMKBILFPCNN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x87A2EE0", Offset = "0x87A14E0", VA = "0x1887A2EE0", Slot = "102")]
	public Vector3 LBHKOCIKHGA(Vector3 AMBPKDHGONF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x87A08A0", Offset = "0x879EEA0", VA = "0x1887A08A0", Slot = "103")]
	public void EIFOBIMJAGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x879F3C0", Offset = "0x879D9C0", VA = "0x18879F3C0", Slot = "104")]
	public void BEFPNKGEDNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x87A3F50", Offset = "0x87A2550", VA = "0x1887A3F50", Slot = "105")]
	public void NKFNDPLCMBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x87A4B00", Offset = "0x87A3100", VA = "0x1887A4B00", Slot = "106")]
	public void PALKGBIDBNA(Vector3 OMBFIEDHDAB, Vector3 MIBCMGLMBGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x87A3FA0", Offset = "0x87A25A0", VA = "0x1887A3FA0", Slot = "107")]
	public void NLELMACGJLN(Vector3 MGMMJFCDLHO, Vector3 FKIKANGLALM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x87A0760", Offset = "0x879ED60", VA = "0x1887A0760", Slot = "108")]
	public void EEMAPOGAEKE(Vector3 BGCEGOALDCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x87A1940", Offset = "0x879FF40", VA = "0x1887A1940", Slot = "109")]
	public void HECHANHAPKA(JKINPDBJECI FOGGOOKDANB, Vector3 ECHOKDNKMPC, float EPGAPBLIBEP, float PNMMNFPGPCG = 8f, float AIFIBMGEPIP = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x87A0580", Offset = "0x879EB80", VA = "0x1887A0580", Slot = "110")]
	public void EDLINEFOPPD(PKMLAHKLCAB FMNNFHFKKOM, Vector3 HOKDDCLKNCO, float FDOEOEDHBAF = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x879F260", Offset = "0x879D860", VA = "0x18879F260", Slot = "111")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void ANJLPPOBDJL(PKMLAHKLCAB FMNNFHFKKOM, Vector3 CFFPEJBOBIA, float KNNDKDAPHBD = 7f, float EBHHKGCDOIB = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x87A2450", Offset = "0x87A0A50", VA = "0x1887A2450", Slot = "112")]
	public Vector3 JFBJCEJGNFB(Vector3 KKGBKLFKCPO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x87A08F0", Offset = "0x879EEF0", VA = "0x1887A08F0", Slot = "113")]
	public Vector3 EJELLMGKBFH(Vector3 KKGBKLFKCPO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x87A45F0", Offset = "0x87A2BF0", VA = "0x1887A45F0", Slot = "114")]
	public void OCPLIMNHADO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x87A3C90", Offset = "0x87A2290", VA = "0x1887A3C90", Slot = "115")]
	public void MNMEHCKKGEH(KJMCALOBECF PAHOJJMFJGN, object DKFMAIJGPFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x879FC80", Offset = "0x879E280", VA = "0x18879FC80", Slot = "116")]
	public void CHJMGNAJNKL(object DKFMAIJGPFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x87A0680", Offset = "0x879EC80", VA = "0x1887A0680", Slot = "63")]
	public void EEFCCNMFBOF((Quaternion rot, Vector3 moments) CGCPKONOFGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x87A2FE0", Offset = "0x87A15E0", VA = "0x1887A2FE0", Slot = "117")]
	public void LFELPMNNODD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x87A2C40", Offset = "0x87A1240", VA = "0x1887A2C40", Slot = "118")]
	public void KIDAJKBLJEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x87A2BA0", Offset = "0x87A11A0", VA = "0x1887A2BA0", Slot = "119")]
	public void KEBCPPFCMHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x87A0380", Offset = "0x879E980", VA = "0x1887A0380", Slot = "120")]
	public bool EBIFDFGHHKF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x879F210", Offset = "0x879D810", VA = "0x18879F210", Slot = "97")]
	public void ANEGIPGNHPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x87A4580", Offset = "0x87A2B80", VA = "0x1887A4580", Slot = "121")]
	public void OCBPHJPKKED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x87A3800", Offset = "0x87A1E00", VA = "0x1887A3800", Slot = "122")]
	public void MIDNGBHBBFF(object DKFMAIJGPFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x87A3E10", Offset = "0x87A2410", VA = "0x1887A3E10", Slot = "123")]
	public void NEPDGGGEIHI(object DKFMAIJGPFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x879F0F0", Offset = "0x879D6F0", VA = "0x18879F0F0", Slot = "124")]
	public void AMAMAGGPGCK(object DKFMAIJGPFL, bool PJBLBGNDEOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x87A35D0", Offset = "0x87A1BD0", VA = "0x1887A35D0", Slot = "125")]
	public void MCGJCGPEJCK(Vector3 EDIEACHMBOE, Quaternion OKJJFLANHCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x87A1080", Offset = "0x879F680", VA = "0x1887A1080", Slot = "126")]
	public void FIEDHPBHGNF(Vector3 LEMEJCFGJPG, Quaternion JADFJJHPGEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x87A1C20", Offset = "0x87A0220", VA = "0x1887A1C20", Slot = "127")]
	public bool HJIFBALEFOM(float OKDFECFEJGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x87A22C0", Offset = "0x87A08C0", VA = "0x1887A22C0", Slot = "128")]
	public void IPLANBIMJAM(object DKFMAIJGPFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x87A4FB0", Offset = "0x87A35B0", VA = "0x1887A4FB0", Slot = "129")]
	public void PGBMGLFPFNH(object DKFMAIJGPFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x87A1730", Offset = "0x879FD30", VA = "0x1887A1730", Slot = "130")]
	public void GHAIAGLOMLE(object DKFMAIJGPFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x87A3860", Offset = "0x87A1E60", VA = "0x1887A3860", Slot = "131")]
	public void MILCNPIKOKP(object DKFMAIJGPFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x87A3080", Offset = "0x87A1680", VA = "0x1887A3080", Slot = "132")]
	public void LGJPECALCNE(Vector3 KKBNDFNEENM, ForceMode CCCAMKIFFEK = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x87A3220", Offset = "0x87A1820", VA = "0x1887A3220", Slot = "133")]
	public void LMFLFHEKGGA(Vector3 KKBNDFNEENM, Vector3 NHLFNDFGAHK, ForceMode CCCAMKIFFEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x87A39F0", Offset = "0x87A1FF0", VA = "0x1887A39F0", Slot = "134")]
	public void MMLPGPOAMNO(Vector3 PNINFNAAJFD, ForceMode CCCAMKIFFEK = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x87A0FA0", Offset = "0x879F5A0", VA = "0x1887A0FA0", Slot = "135")]
	public void FHFLJNMLPGN(Vector3 PNINFNAAJFD, ForceMode CCCAMKIFFEK = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x879FAE0", Offset = "0x879E0E0", VA = "0x18879FAE0", Slot = "136")]
	public bool CDEGNLJIFMN(Vector3 GJGHBLDDKFD, [Out] RaycastHit EBBBOJFKCOH, float AMEHFMMOAMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x87A49F0", Offset = "0x87A2FF0", VA = "0x1887A49F0", Slot = "137")]
	public void ONCMLPOKMBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x87A5560", Offset = "0x87A3B60", VA = "0x1887A5560", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x87A04A0", Offset = "0x879EAA0", VA = "0x1887A04A0")]
	private void EDJOBCOCGAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x87A1A50", Offset = "0x87A0050", VA = "0x1887A1A50")]
	private void HJEBAOMEDMO(KJMCALOBECF NBIJLPJHNNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x87A4800", Offset = "0x87A2E00", VA = "0x1887A4800")]
	private void OLKLMONIOFN(KJMCALOBECF NBIJLPJHNNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x879F160", Offset = "0x879D760", VA = "0x18879F160")]
	private void AMJGCFMBAMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x87A50F0", Offset = "0x87A36F0", VA = "0x1887A50F0")]
	private void PGOHGFDDCHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x87A0DF0", Offset = "0x879F3F0", VA = "0x1887A0DF0")]
	private void FHFJDCAJJOA(KJMCALOBECF ADGIOGOLHAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x87A3BC0", Offset = "0x87A21C0", VA = "0x1887A3BC0")]
	private void MMNFPLBAPLI(KJMCALOBECF NBIJLPJHNNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x87A38C0", Offset = "0x87A1EC0", VA = "0x1887A38C0")]
	private void MKNEGKDAFPI(KJMCALOBECF NBIJLPJHNNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x87A3410", Offset = "0x87A1A10", VA = "0x1887A3410")]
	private void LMLFLHJALBC(KGNLHMPLHEM NBIJLPJHNNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x87A4090", Offset = "0x87A2690", VA = "0x1887A4090", Slot = "142")]
	protected virtual void NMAJICFBEOG(KGNLHMPLHEM ALKKIHFIKDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x87A4C50", Offset = "0x87A3250", VA = "0x1887A4C50")]
	protected void PCACPDHPCPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x879F480", Offset = "0x879DA80", VA = "0x18879F480")]
	protected void BIDNJEABAKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x87A1E10", Offset = "0x87A0410", VA = "0x1887A1E10")]
	private void ICJPMBHAPKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x87A1260", Offset = "0x879F860", VA = "0x1887A1260")]
	private void FJKEICHDFJB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal static class JIJABFECAIN
{
	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x87A8AF0", Offset = "0x87A70F0", VA = "0x1887A8AF0")]
	public static KJMCALOBECF OLIJOBPGJGG(this KJMCALOBECF ALKKIHFIKDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x87A8930", Offset = "0x87A6F30", VA = "0x1887A8930")]
	public static bool EJOGPJEOGHF(this KJMCALOBECF ALKKIHFIKDP, KJMCALOBECF GKCMBDHDPAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x87A8A50", Offset = "0x87A7050", VA = "0x1887A8A50")]
	public static bool MACANHJMIBJ(this KJMCALOBECF ALKKIHFIKDP, KJMCALOBECF DMBNONNOPAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x87A88E0", Offset = "0x87A6EE0", VA = "0x1887A88E0")]
	public static KGNLHMPLHEM CGLNHHKHNAG(this KJMCALOBECF FIAONBPCJJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x87A89D0", Offset = "0x87A6FD0", VA = "0x1887A89D0")]
	public static CLOFJJADLBN JKNCOIAHBLD(this KJMCALOBECF FIAONBPCJJK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class CBOBNGBIGOK : HCMIBJICIGH
{
	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x879E260", Offset = "0x879C860", VA = "0x18879E260", Slot = "19")]
	public KJMCALOBECF NCKHGGNLDGJ(RigidbodyEx ALKKIHFIKDP, AEHFEICJLEG ACJFHCNBBBO, JFFKGDNKPBG MIPDPIDNIBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0xA46A00", Offset = "0xA45000", VA = "0x180A46A00", Slot = "4")]
	public MONFGFMMGOK BCDDAJMNCEO(KJMCALOBECF FIAONBPCJJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0xA46A00", Offset = "0xA45000", VA = "0x180A46A00", Slot = "5")]
	public BEFAFDJEHJB NIKAFFPBHHN(KJMCALOBECF FIAONBPCJJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0xA46A00", Offset = "0xA45000", VA = "0x180A46A00", Slot = "6")]
	public CMBEENEIOMB OPKBONCNKOD(KJMCALOBECF FIAONBPCJJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0xA46A00", Offset = "0xA45000", VA = "0x180A46A00", Slot = "7")]
	public IFGFNJLIAFE MIMIEBFKBEP(KJMCALOBECF FIAONBPCJJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0xA46A00", Offset = "0xA45000", VA = "0x180A46A00", Slot = "8")]
	public HGLPIHPJLIE GHIAMEIPGFK(KJMCALOBECF FIAONBPCJJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0xA46A00", Offset = "0xA45000", VA = "0x180A46A00", Slot = "9")]
	public DOPBDGLDMOL BOGILHNAAPM(KJMCALOBECF FIAONBPCJJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0xA46A00", Offset = "0xA45000", VA = "0x180A46A00", Slot = "10")]
	public EJBKHGLAIFG HHDHMHLHNPC(KJMCALOBECF FIAONBPCJJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0xA46A00", Offset = "0xA45000", VA = "0x180A46A00", Slot = "11")]
	public HGHNDMMNMJH HMGJKLBKEIC(KJMCALOBECF FIAONBPCJJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0xA46A00", Offset = "0xA45000", VA = "0x180A46A00", Slot = "12")]
	public EFLFFNGPEAG HAHEIFJFAPA(KJMCALOBECF FIAONBPCJJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0xA46A00", Offset = "0xA45000", VA = "0x180A46A00", Slot = "13")]
	public MBKDOMKMJNE EOICLNLFBDF(KJMCALOBECF FIAONBPCJJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0xA46A00", Offset = "0xA45000", VA = "0x180A46A00")]
	public FGDJKKPDMOO DADPBPGIPDP(KJMCALOBECF FIAONBPCJJK, [In] AEHFEICJLEG ACJFHCNBBBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0xA46A00", Offset = "0xA45000", VA = "0x180A46A00")]
	public OBHINKDPFLF HLCIOFPHKBI(KJMCALOBECF FIAONBPCJJK, [In] AEHFEICJLEG ACJFHCNBBBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0xA46A00", Offset = "0xA45000", VA = "0x180A46A00")]
	public GGAAAJEJDEF MNIEGJINFMB(KJMCALOBECF FIAONBPCJJK, [In] AEHFEICJLEG ACJFHCNBBBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0xA46A00", Offset = "0xA45000", VA = "0x180A46A00")]
	public MJFDIPNHEKF AHLNLDEMKOD(KJMCALOBECF FIAONBPCJJK, [In] AEHFEICJLEG ACJFHCNBBBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0xA46A00", Offset = "0xA45000", VA = "0x180A46A00")]
	public OKBLJHHOEFJ HDCCNKEFELC(KJMCALOBECF FIAONBPCJJK, [In] AEHFEICJLEG ACJFHCNBBBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public CBOBNGBIGOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0xA46A00", Offset = "0xA45000", VA = "0x180A46A00", Slot = "14")]
	private FGDJKKPDMOO DMPCEGJAKEB(KJMCALOBECF FIAONBPCJJK, [In] AEHFEICJLEG ACJFHCNBBBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0xA46A00", Offset = "0xA45000", VA = "0x180A46A00", Slot = "15")]
	private OBHINKDPFLF LDELOALEFCO(KJMCALOBECF FIAONBPCJJK, [In] AEHFEICJLEG ACJFHCNBBBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0xA46A00", Offset = "0xA45000", VA = "0x180A46A00", Slot = "16")]
	private GGAAAJEJDEF CJHKILOKKOF(KJMCALOBECF FIAONBPCJJK, [In] AEHFEICJLEG ACJFHCNBBBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0xA46A00", Offset = "0xA45000", VA = "0x180A46A00", Slot = "17")]
	private MJFDIPNHEKF LFHAPLEJEIP(KJMCALOBECF FIAONBPCJJK, [In] AEHFEICJLEG ACJFHCNBBBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0xA46A00", Offset = "0xA45000", VA = "0x180A46A00", Slot = "18")]
	private OKBLJHHOEFJ FFMIPHEBFBC(KJMCALOBECF FIAONBPCJJK, [In] AEHFEICJLEG ACJFHCNBBBO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[RegisterService(typeof(HCMIBJICIGH), new string[] { })]
public class CHGLJNCCHEG : HCMIBJICIGH, JPODKHCGMPE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly HCMIBJICIGH GDDNGAJCCOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly HCMIBJICIGH JIDHBODOGAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private CGLAHCPNNAM FEBBLDONFFJ;

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	private HCMIBJICIGH ILCLGDBADDL
	{
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x879E4F0", Offset = "0x879CAF0", VA = "0x18879E4F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x879EB30", Offset = "0x879D130", VA = "0x18879EB30", Slot = "20")]
	public void InitReferences(MGPNAOEDNIM KIIAJJAGEIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x879E3B0", Offset = "0x879C9B0", VA = "0x18879E3B0", Slot = "4")]
	public MONFGFMMGOK BCDDAJMNCEO(KJMCALOBECF FIAONBPCJJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x879ED00", Offset = "0x879D300", VA = "0x18879ED00", Slot = "5")]
	public BEFAFDJEHJB NIKAFFPBHHN(KJMCALOBECF FIAONBPCJJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x879EDA0", Offset = "0x879D3A0", VA = "0x18879EDA0", Slot = "6")]
	public CMBEENEIOMB OPKBONCNKOD(KJMCALOBECF FIAONBPCJJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x879EB80", Offset = "0x879D180", VA = "0x18879EB80", Slot = "7")]
	public IFGFNJLIAFE MIMIEBFKBEP(KJMCALOBECF FIAONBPCJJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x879E800", Offset = "0x879CE00", VA = "0x18879E800", Slot = "8")]
	public HGLPIHPJLIE GHIAMEIPGFK(KJMCALOBECF FIAONBPCJJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x879E450", Offset = "0x879CA50", VA = "0x18879E450", Slot = "9")]
	public DOPBDGLDMOL BOGILHNAAPM(KJMCALOBECF FIAONBPCJJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x879E940", Offset = "0x879CF40", VA = "0x18879E940", Slot = "10")]
	public EJBKHGLAIFG HHDHMHLHNPC(KJMCALOBECF FIAONBPCJJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x879EA90", Offset = "0x879D090", VA = "0x18879EA90", Slot = "11")]
	public HGHNDMMNMJH HMGJKLBKEIC(KJMCALOBECF FIAONBPCJJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x879E8A0", Offset = "0x879CEA0", VA = "0x18879E8A0", Slot = "12")]
	public EFLFFNGPEAG HAHEIFJFAPA(KJMCALOBECF FIAONBPCJJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x879E6B0", Offset = "0x879CCB0", VA = "0x18879E6B0", Slot = "13")]
	public MBKDOMKMJNE EOICLNLFBDF(KJMCALOBECF FIAONBPCJJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x879E600", Offset = "0x879CC00", VA = "0x18879E600")]
	public FGDJKKPDMOO DADPBPGIPDP(KJMCALOBECF FIAONBPCJJK, [In] AEHFEICJLEG ACJFHCNBBBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x879E9E0", Offset = "0x879CFE0", VA = "0x18879E9E0")]
	public OBHINKDPFLF HLCIOFPHKBI(KJMCALOBECF FIAONBPCJJK, [In] AEHFEICJLEG ACJFHCNBBBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x879E550", Offset = "0x879CB50", VA = "0x18879E550")]
	public GGAAAJEJDEF MNIEGJINFMB(KJMCALOBECF FIAONBPCJJK, [In] AEHFEICJLEG ACJFHCNBBBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x879E300", Offset = "0x879C900", VA = "0x18879E300")]
	public MJFDIPNHEKF AHLNLDEMKOD(KJMCALOBECF FIAONBPCJJK, [In] AEHFEICJLEG ACJFHCNBBBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x879E750", Offset = "0x879CD50", VA = "0x18879E750")]
	public OKBLJHHOEFJ HDCCNKEFELC(KJMCALOBECF FIAONBPCJJK, [In] AEHFEICJLEG ACJFHCNBBBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x879EC20", Offset = "0x879D220", VA = "0x18879EC20", Slot = "19")]
	public KJMCALOBECF NCKHGGNLDGJ(RigidbodyEx ALKKIHFIKDP, AEHFEICJLEG ACJFHCNBBBO, JFFKGDNKPBG MIPDPIDNIBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x879EE40", Offset = "0x879D440", VA = "0x18879EE40")]
	public CHGLJNCCHEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x879E600", Offset = "0x879CC00", VA = "0x18879E600", Slot = "14")]
	private FGDJKKPDMOO DMPCEGJAKEB(KJMCALOBECF FIAONBPCJJK, [In] AEHFEICJLEG ACJFHCNBBBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x879E9E0", Offset = "0x879CFE0", VA = "0x18879E9E0", Slot = "15")]
	private OBHINKDPFLF LDELOALEFCO(KJMCALOBECF FIAONBPCJJK, [In] AEHFEICJLEG ACJFHCNBBBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x879E550", Offset = "0x879CB50", VA = "0x18879E550", Slot = "16")]
	private GGAAAJEJDEF CJHKILOKKOF(KJMCALOBECF FIAONBPCJJK, [In] AEHFEICJLEG ACJFHCNBBBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x879E300", Offset = "0x879C900", VA = "0x18879E300", Slot = "17")]
	private MJFDIPNHEKF LFHAPLEJEIP(KJMCALOBECF FIAONBPCJJK, [In] AEHFEICJLEG ACJFHCNBBBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x879E750", Offset = "0x879CD50", VA = "0x18879E750", Slot = "18")]
	private OKBLJHHOEFJ FFMIPHEBFBC(KJMCALOBECF FIAONBPCJJK, [In] AEHFEICJLEG ACJFHCNBBBO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface OFFGEMIEIFN : MONFGFMMGOK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NOFCKFLGCNH(KJMCALOBECF ALKKIHFIKDP);

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ELJKAGOPJIJ(KJMCALOBECF ALKKIHFIKDP);

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NKBPDBBKEAH(KJMCALOBECF ADGIOGOLHAO);

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JHPJPEGKFJA(KJMCALOBECF ADGIOGOLHAO);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface CKGOJGDJAIE : CMBEENEIOMB
{
	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	MAGBICPAAPJ<KJMCALOBECF> GJENBBOJPME
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	KJMCALOBECF NPINMACCFNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface NGLCKDONNEM : MJFDIPNHEKF
{
	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	(float, Vector3) MKAHCLHLNAA(Rigidbody GKCIHPJLKFF);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface GLOEDMBBKPC : OBHINKDPFLF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	RRNetworkView CFGIPNLJEMG
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal sealed class NIKFKEELIHL : EFLFFNGPEAG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly CLOFJJADLBN ALKKIHFIKDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private CollisionDetectionMode AFOAOPLOAGH;

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	private Rigidbody AOLLOIANELI
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x87AF6E0", Offset = "0x87ADCE0", VA = "0x1887AF6E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public CollisionDetectionMode EHGBNOBIOHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x87B3360", Offset = "0x87B1960", VA = "0x1887B3360", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x87B3620", Offset = "0x87B1C20", VA = "0x1887B3620", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x87A66D0", Offset = "0x87A4CD0", VA = "0x1887A66D0")]
	public NIKFKEELIHL(KJMCALOBECF ALKKIHFIKDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x87B3490", Offset = "0x87B1A90", VA = "0x1887B3490", Slot = "6")]
	public void JPNPNACFNCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x87B35A0", Offset = "0x87B1BA0", VA = "0x1887B35A0", Slot = "9")]
	public void MGGOCMEMKAK(Rigidbody GPPACDEEKNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x87B3480", Offset = "0x87B1A80", VA = "0x1887B3480", Slot = "7")]
	public void JGKGPGNILIC(bool BNFANHDEJGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x87B3470", Offset = "0x87B1A70", VA = "0x1887B3470", Slot = "8")]
	public void IACNAHEHCPE(bool BNFANHDEJGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x87B3200", Offset = "0x87B1800", VA = "0x1887B3200", Slot = "10")]
	public bool CDEGNLJIFMN(Vector3 GJGHBLDDKFD, [Out] RaycastHit EBBBOJFKCOH, float AMEHFMMOAMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x87B3690", Offset = "0x87B1C90", VA = "0x1887B3690")]
	private void PAHCAMKKPGA(bool BNFANHDEJGB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class EDNGHPHHLBG : DOPBDGLDMOL, IDisposable, DJOKFDLOFME
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly CLOFJJADLBN ALKKIHFIKDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private CNFEEBNLJFN KEHEEIMALEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private KAIJBBJPFNN IMKIPOHIAOB;

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public CNFEEBNLJFN MGOHBGCOCLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x87A6930", Offset = "0x87A4F30", VA = "0x1887A6930", Slot = "6")]
		get
		{
			return default(CNFEEBNLJFN);
		}
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x87A67B0", Offset = "0x87A4DB0", VA = "0x1887A67B0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	private Transform DEHDPMDNBNI
	{
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0xD95220", Offset = "0xD93820", VA = "0x180D95220", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	public event Action<LNDADOOHAMM, LNDADOOHAMM> NMFJEKGGLON
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x87A6880", Offset = "0x87A4E80", VA = "0x1887A6880", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x87A6A80", Offset = "0x87A5080", VA = "0x1887A6A80", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x87A6DA0", Offset = "0x87A53A0", VA = "0x1887A6DA0")]
	public EDNGHPHHLBG(KJMCALOBECF ALKKIHFIKDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x87A6B30", Offset = "0x87A5130", VA = "0x1887A6B30", Slot = "8")]
	public void JPNPNACFNCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x87A6760", Offset = "0x87A4D60", VA = "0x1887A6760", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x127FFD0", Offset = "0x127E5D0", VA = "0x18127FFD0", Slot = "11")]
	private void EPLPABKGPFM(LNDADOOHAMM IPEPMKFKJEC, LNDADOOHAMM BDLAAMPBEBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "12")]
	private void NHHLDNEFDMC(bool EPAEFBCGGBA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class NLDBDOFFINC : HCMIBJICIGH
{
	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x87B3950", Offset = "0x87B1F50", VA = "0x1887B3950", Slot = "4")]
	public MONFGFMMGOK BCDDAJMNCEO(KJMCALOBECF FIAONBPCJJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x87B45F0", Offset = "0x87B2BF0", VA = "0x1887B45F0", Slot = "5")]
	public BEFAFDJEHJB NIKAFFPBHHN(KJMCALOBECF FIAONBPCJJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x87B4720", Offset = "0x87B2D20", VA = "0x1887B4720", Slot = "6")]
	public CMBEENEIOMB OPKBONCNKOD(KJMCALOBECF FIAONBPCJJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x87B4420", Offset = "0x87B2A20", VA = "0x1887B4420", Slot = "7")]
	public IFGFNJLIAFE MIMIEBFKBEP(KJMCALOBECF FIAONBPCJJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x87B3F20", Offset = "0x87B2520", VA = "0x1887B3F20", Slot = "8")]
	public HGLPIHPJLIE GHIAMEIPGFK(KJMCALOBECF FIAONBPCJJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x87B3A40", Offset = "0x87B2040", VA = "0x1887B3A40", Slot = "9")]
	public DOPBDGLDMOL BOGILHNAAPM(KJMCALOBECF FIAONBPCJJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x87B40B0", Offset = "0x87B26B0", VA = "0x1887B40B0", Slot = "10")]
	public EJBKHGLAIFG HHDHMHLHNPC(KJMCALOBECF FIAONBPCJJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x87B4360", Offset = "0x87B2960", VA = "0x1887B4360", Slot = "11")]
	public HGHNDMMNMJH HMGJKLBKEIC(KJMCALOBECF FIAONBPCJJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x87B3FF0", Offset = "0x87B25F0", VA = "0x1887B3FF0", Slot = "12")]
	public EFLFFNGPEAG HAHEIFJFAPA(KJMCALOBECF FIAONBPCJJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x87B3D80", Offset = "0x87B2380", VA = "0x1887B3D80", Slot = "13")]
	public MBKDOMKMJNE EOICLNLFBDF(KJMCALOBECF FIAONBPCJJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x87B3C40", Offset = "0x87B2240", VA = "0x1887B3C40")]
	public FGDJKKPDMOO DADPBPGIPDP(KJMCALOBECF FIAONBPCJJK, [In] AEHFEICJLEG ACJFHCNBBBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x87B41D0", Offset = "0x87B27D0", VA = "0x1887B41D0")]
	public OBHINKDPFLF HLCIOFPHKBI(KJMCALOBECF FIAONBPCJJK, [In] AEHFEICJLEG ACJFHCNBBBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x87B3B10", Offset = "0x87B2110", VA = "0x1887B3B10")]
	public GGAAAJEJDEF MNIEGJINFMB(KJMCALOBECF FIAONBPCJJK, [In] AEHFEICJLEG ACJFHCNBBBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x87B37B0", Offset = "0x87B1DB0", VA = "0x1887B37B0")]
	public MJFDIPNHEKF AHLNLDEMKOD(KJMCALOBECF FIAONBPCJJK, [In] AEHFEICJLEG ACJFHCNBBBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x87B3E40", Offset = "0x87B2440", VA = "0x1887B3E40")]
	public OKBLJHHOEFJ HDCCNKEFELC(KJMCALOBECF FIAONBPCJJK, [In] AEHFEICJLEG ACJFHCNBBBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x87B44A0", Offset = "0x87B2AA0", VA = "0x1887B44A0", Slot = "19")]
	public KJMCALOBECF NCKHGGNLDGJ(RigidbodyEx ALKKIHFIKDP, AEHFEICJLEG ACJFHCNBBBO, JFFKGDNKPBG MIPDPIDNIBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public NLDBDOFFINC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x87B3C40", Offset = "0x87B2240", VA = "0x1887B3C40", Slot = "14")]
	private FGDJKKPDMOO DMPCEGJAKEB(KJMCALOBECF FIAONBPCJJK, [In] AEHFEICJLEG ACJFHCNBBBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x87B41D0", Offset = "0x87B27D0", VA = "0x1887B41D0", Slot = "15")]
	private OBHINKDPFLF LDELOALEFCO(KJMCALOBECF FIAONBPCJJK, [In] AEHFEICJLEG ACJFHCNBBBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x87B3B10", Offset = "0x87B2110", VA = "0x1887B3B10", Slot = "16")]
	private GGAAAJEJDEF CJHKILOKKOF(KJMCALOBECF FIAONBPCJJK, [In] AEHFEICJLEG ACJFHCNBBBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x87B37B0", Offset = "0x87B1DB0", VA = "0x1887B37B0", Slot = "17")]
	private MJFDIPNHEKF LFHAPLEJEIP(KJMCALOBECF FIAONBPCJJK, [In] AEHFEICJLEG ACJFHCNBBBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x87B3E40", Offset = "0x87B2440", VA = "0x1887B3E40", Slot = "18")]
	private OKBLJHHOEFJ FFMIPHEBFBC(KJMCALOBECF FIAONBPCJJK, [In] AEHFEICJLEG ACJFHCNBBBO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal sealed class LEFLAHGKDGM : HGHNDMMNMJH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly CLOFJJADLBN ALKKIHFIKDP;

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	private Rigidbody AOLLOIANELI
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x87AF6E0", Offset = "0x87ADCE0", VA = "0x1887AF6E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	private bool HLKDNGBMEHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x87AF170", Offset = "0x87AD770", VA = "0x1887AF170")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	private bool IKAKALLGAEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x87AF110", Offset = "0x87AD710", VA = "0x1887AF110")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	private KJMCALOBECF GCMDLKAOFPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x87AF680", Offset = "0x87ADC80", VA = "0x1887AF680")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x87A66D0", Offset = "0x87A4CD0", VA = "0x1887A66D0")]
	public LEFLAHGKDGM(KJMCALOBECF ALKKIHFIKDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x87AF730", Offset = "0x87ADD30", VA = "0x1887AF730", Slot = "4")]
	public void LGJPECALCNE(Vector3 KKBNDFNEENM, ForceMode CCCAMKIFFEK = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x87AF1C0", Offset = "0x87AD7C0", VA = "0x1887AF1C0")]
	private void DPGDKLNEAEC(Vector3 KKBNDFNEENM, ForceMode CCCAMKIFFEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x87AF890", Offset = "0x87ADE90", VA = "0x1887AF890", Slot = "5")]
	public void LMFLFHEKGGA(Vector3 KKBNDFNEENM, Vector3 NHLFNDFGAHK, ForceMode CCCAMKIFFEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x87AFB10", Offset = "0x87AE110", VA = "0x1887AFB10", Slot = "6")]
	public void MMLPGPOAMNO(Vector3 PNINFNAAJFD, ForceMode CCCAMKIFFEK = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x87AFC70", Offset = "0x87AE270", VA = "0x1887AFC70")]
	private void OMFLPPFJLKD(Vector3 PNINFNAAJFD, ForceMode CCCAMKIFFEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x87AF420", Offset = "0x87ADA20", VA = "0x1887AF420", Slot = "7")]
	public void FHFLJNMLPGN(Vector3 PNINFNAAJFD, ForceMode CCCAMKIFFEK = ForceMode.Force)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal sealed class DOFDJLNNMIB : MBKDOMKMJNE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly CLOFJJADLBN ALKKIHFIKDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private bool PDPJOOKCOPO;

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool KIMELNKGEOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0xAA5D80", Offset = "0xAA4380", VA = "0x180AA5D80", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x87A6520", Offset = "0x87A4B20", VA = "0x1887A6520", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x87A66D0", Offset = "0x87A4CD0", VA = "0x1887A66D0")]
	public DOFDJLNNMIB(KJMCALOBECF ALKKIHFIKDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x87A66A0", Offset = "0x87A4CA0", VA = "0x1887A66A0", Slot = "6")]
	public void MGGOCMEMKAK(Rigidbody GPPACDEEKNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x87A6630", Offset = "0x87A4C30", VA = "0x1887A6630", Slot = "7")]
	public void MDDDFGANMPF(Rigidbody GPPACDEEKNJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal sealed class KFGNOMDILPF : OFFGEMIEIFN, MONFGFMMGOK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly KJMCALOBECF ALKKIHFIKDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly List<KJMCALOBECF> IEAJDCAPOJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private KJMCALOBECF CMAFOEIBEKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private KJMCALOBECF NBIJLPJHNNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private Transform BMMLJPOINAF;

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	private Transform BDBOCHCKBIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x87AC5F0", Offset = "0x87AABF0", VA = "0x1887AC5F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public KJMCALOBECF GCMDLKAOFPF
	{
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0xA50E50", Offset = "0xA4F450", VA = "0x180A50E50", Slot = "28")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x87AC5E0", Offset = "0x87AABE0", VA = "0x1887AC5E0", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public KJMCALOBECF JOCLBAADBME
	{
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0xA449A0", Offset = "0xA42FA0", VA = "0x180A449A0", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public IReadOnlyList<KJMCALOBECF> CNLIFHFENIG
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0xA44990", Offset = "0xA42F90", VA = "0x180A44990", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000021")]
	public event IBJOPKNCPIE JOMNOEOAHNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x87AC8D0", Offset = "0x87AAED0", VA = "0x1887AC8D0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x87ACDE0", Offset = "0x87AB3E0", VA = "0x1887ACDE0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000022")]
	public event IBJOPKNCPIE LLKDGIILKLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x87ACFC0", Offset = "0x87AB5C0", VA = "0x1887ACFC0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x87AD1A0", Offset = "0x87AB7A0", VA = "0x1887AD1A0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000023")]
	public event CFAIFCIBAIO LBHMOJIBAAG
	{
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x87AE100", Offset = "0x87AC700", VA = "0x1887AE100", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x87AD100", Offset = "0x87AB700", VA = "0x1887AD100", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000024")]
	public event Action AMGABJOGBLD
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x87ACB60", Offset = "0x87AB160", VA = "0x1887ACB60", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x87ACF20", Offset = "0x87AB520", VA = "0x1887ACF20", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000025")]
	public event Action IBINBCCJOGN
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x87AD060", Offset = "0x87AB660", VA = "0x1887AD060", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x87AC650", Offset = "0x87AAC50", VA = "0x1887AC650", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000026")]
	public event Action<KJMCALOBECF> AKNCJGMJBII
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x87AC820", Offset = "0x87AAE20", VA = "0x1887AC820", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x87AD240", Offset = "0x87AB840", VA = "0x1887AD240", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000027")]
	public event Action<KJMCALOBECF> NGIHHMMKLKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x87AE050", Offset = "0x87AC650", VA = "0x1887AE050", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x87ADBA0", Offset = "0x87AC1A0", VA = "0x1887ADBA0", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000028")]
	public event Action FOFFABIGKFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x87ACE80", Offset = "0x87AB480", VA = "0x1887ACE80", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x87ACC00", Offset = "0x87AB200", VA = "0x1887ACC00", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000029")]
	public event Action<KJMCALOBECF> MCNHNOLLGFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x87AD570", Offset = "0x87ABB70", VA = "0x1887AD570", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x87AC530", Offset = "0x87AAB30", VA = "0x1887AC530", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x87AE320", Offset = "0x87AC920", VA = "0x1887AE320")]
	public KFGNOMDILPF(KJMCALOBECF ALKKIHFIKDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x87ACCA0", Offset = "0x87AB2A0", VA = "0x1887ACCA0", Slot = "31")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x87AD620", Offset = "0x87ABC20", VA = "0x1887AD620", Slot = "30")]
	public void KNEPPBFGJJO(KJMCALOBECF BADBAFBEKHJ, bool NDGGHLKMBPJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x87ADC50", Offset = "0x87AC250", VA = "0x1887ADC50", Slot = "6")]
	public void NKBPDBBKEAH(KJMCALOBECF ADGIOGOLHAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x87AD2F0", Offset = "0x87AB8F0", VA = "0x1887AD2F0", Slot = "7")]
	public void JHPJPEGKFJA(KJMCALOBECF ADGIOGOLHAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x87ADF60", Offset = "0x87AC560", VA = "0x1887ADF60", Slot = "4")]
	public void NOFCKFLGCNH(KJMCALOBECF ALKKIHFIKDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x87ACD40", Offset = "0x87AB340", VA = "0x1887ACD40", Slot = "5")]
	public void ELJKAGOPJIJ(KJMCALOBECF ALKKIHFIKDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x87ADEC0", Offset = "0x87AC4C0", VA = "0x1887ADEC0")]
	private void NMPEKCFEAIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x87AE2E0", Offset = "0x87AC8E0", VA = "0x1887AE2E0")]
	private void POGJOOEDIHD(KJMCALOBECF ADGIOGOLHAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x87AE1A0", Offset = "0x87AC7A0", VA = "0x1887AE1A0")]
	private void PDIFLPOFCCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x87ACA30", Offset = "0x87AB030", VA = "0x1887ACA30")]
	private void CEIENHBCJKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x87AC6F0", Offset = "0x87AACF0", VA = "0x1887AC6F0")]
	private void BJCBCAIFGAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x87AC970", Offset = "0x87AAF70", VA = "0x1887AC970")]
	[CompilerGenerated]
	private object BOMEKKPGMLO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal static class ANKKGJFEMGJ
{
	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x879E1A0", Offset = "0x879C7A0", VA = "0x18879E1A0")]
	public static OFFGEMIEIFN EJLDIIMBBEB(this KJMCALOBECF FIAONBPCJJK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal sealed class DMLGIPEJFEG : CKGOJGDJAIE, CMBEENEIOMB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly CLOFJJADLBN ALKKIHFIKDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly MAGBICPAAPJ<KJMCALOBECF> EAKAJFNBAIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private bool MJDODDKOHJB;

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public MAGBICPAAPJ<KJMCALOBECF> GJENBBOJPME
	{
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public Vector3 MMIFFNNBOLO
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x87A5760", Offset = "0x87A3D60", VA = "0x1887A5760", Slot = "6")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public Vector3 MAFELFPNHAN
	{
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x87A5BA0", Offset = "0x87A41A0", VA = "0x1887A5BA0", Slot = "7")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	private Vector3 OEOMMCEFOBI
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x87A6290", Offset = "0x87A4890", VA = "0x1887A6290")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public KJMCALOBECF NPINMACCFNF
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x87A6370", Offset = "0x87A4970", VA = "0x1887A6370", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x87A6420", Offset = "0x87A4A20", VA = "0x1887A6420")]
	public DMLGIPEJFEG(KJMCALOBECF ALKKIHFIKDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x87A5790", Offset = "0x87A3D90", VA = "0x1887A5790", Slot = "8")]
	public void GBGEOBFKNCM(KJMCALOBECF NBIJLPJHNNE, object DKFMAIJGPFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x87A5EA0", Offset = "0x87A44A0", VA = "0x1887A5EA0", Slot = "9")]
	public void LLILGAJCKBM(object DKFMAIJGPFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x87A5800", Offset = "0x87A3E00", VA = "0x1887A5800")]
	private Vector3 GDKCGFLAJBD()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x87A5F00", Offset = "0x87A4500", VA = "0x1887A5F00")]
	private void NBKGBDCHNHJ(KJMCALOBECF FJFMJNMCFLK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal static class GBOJJKAGECD
{
	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x87A6EF0", Offset = "0x87A54F0", VA = "0x1887A6EF0")]
	public static CKGOJGDJAIE CGEIPIHKIPP(this KJMCALOBECF FIAONBPCJJK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal sealed class NEEGPKBLMII : NGLCKDONNEM, MJFDIPNHEKF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly CLOFJJADLBN ALKKIHFIKDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly OverridableVector3 FFFCNAKBILH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly OverridableVector3 JAAELCGHBGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private float HOFHDHKPJLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private float BOPCJONKHOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private Vector3 EJJIOPMHNFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private Vector3? IOMBHEPGNNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private Quaternion? HHJFGKOLDFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private bool ILOKKCNBGKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private bool AOIBMECDGKM;

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public Vector3 LHHCANCPEFO
	{
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x17C0EF0", Offset = "0x17BF4F0", VA = "0x1817C0EF0", Slot = "7")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x87B0950", Offset = "0x87AEF50", VA = "0x1887B0950", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public Vector3 EHHNFHGNBGC
	{
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x87B0B10", Offset = "0x87AF110", VA = "0x1887B0B10", Slot = "9")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public float GMADLJBMDMN
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0xDBC6C0", Offset = "0xDBACC0", VA = "0x180DBC6C0", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x87B0A00", Offset = "0x87AF000", VA = "0x1887B0A00")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public float HLGEDMHJMGH
	{
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0xCBB6B0", Offset = "0xCB9CB0", VA = "0x180CBB6B0", Slot = "11")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x87B1150", Offset = "0x87AF750", VA = "0x1887B1150", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public Vector3 NJILMMEDHAE
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x87B12A0", Offset = "0x87AF8A0", VA = "0x1887B12A0", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public Quaternion OHGPMDHLAAH
	{
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x87B0C00", Offset = "0x87AF200", VA = "0x1887B0C00", Slot = "14")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	private Rigidbody AOLLOIANELI
	{
		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x87AECA0", Offset = "0x87AD2A0", VA = "0x1887AECA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002A")]
	public event IBJOPKNCPIE CHNGAKOHMLA
	{
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x87B3000", Offset = "0x87B1600", VA = "0x1887B3000", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x87B1200", Offset = "0x87AF800", VA = "0x1887B1200", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x87B30A0", Offset = "0x87B16A0", VA = "0x1887B30A0")]
	public NEEGPKBLMII(KJMCALOBECF ALKKIHFIKDP, [In] AEHFEICJLEG ACJFHCNBBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x87B17A0", Offset = "0x87AFDA0", VA = "0x1887B17A0", Slot = "17")]
	public void LFELPMNNODD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x87B16C0", Offset = "0x87AFCC0", VA = "0x1887B16C0", Slot = "16")]
	public void KIDAJKBLJEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x87B1AA0", Offset = "0x87B00A0", VA = "0x1887B1AA0", Slot = "19")]
	public void MGGOCMEMKAK(Rigidbody GPPACDEEKNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x87B18C0", Offset = "0x87AFEC0", VA = "0x1887B18C0", Slot = "20")]
	public void MDDDFGANMPF(Rigidbody GPPACDEEKNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x87B1430", Offset = "0x87AFA30", VA = "0x1887B1430", Slot = "18")]
	public void KEBCPPFCMHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x87B2B80", Offset = "0x87B1180", VA = "0x1887B2B80", Slot = "21")]
	public void ONCMLPOKMBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x87B0950", Offset = "0x87AEF50", VA = "0x1887B0950")]
	private void BGDGADMIIBI(Vector3 KKGBKLFKCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x87B15D0", Offset = "0x87AFBD0", VA = "0x1887B15D0")]
	[Obsolete("This method is dangerous - the unity rigidbody is updated in a deferred manner and this world position may be stale")]
	private Vector3 KECGCEGICAN()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x87B0A00", Offset = "0x87AF000", VA = "0x1887B0A00")]
	private void GBDOINEIPLE(float KKGBKLFKCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x87B1150", Offset = "0x87AF750", VA = "0x1887B1150")]
	private void FFDMKGIMOGF(float KKGBKLFKCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x87B0D80", Offset = "0x87AF380", VA = "0x1887B0D80")]
	private Vector3 EDCHBAIEGIO()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x87B0F20", Offset = "0x87AF520", VA = "0x1887B0F20", Slot = "15")]
	public void EEFCCNMFBOF((Quaternion rot, Vector3 moments) CGCPKONOFGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x87B1B80", Offset = "0x87B0180", VA = "0x1887B1B80")]
	private Quaternion MJEJIEKBLHO()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x87B2AB0", Offset = "0x87B10B0", VA = "0x1887B2AB0")]
	public void MKAHCLHLNAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x87B1D00", Offset = "0x87B0300", VA = "0x1887B1D00", Slot = "4")]
	public (float, Vector3) MKAHCLHLNAA(Rigidbody GKCIHPJLKFF)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal static class EELMCNILEFJ
{
	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x87A6E30", Offset = "0x87A5430", VA = "0x1887A6E30")]
	public static NGLCKDONNEM KHILCEFAIGI(this KJMCALOBECF FIAONBPCJJK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal sealed class AILENFJGBHO : GGAAAJEJDEF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly CLOFJJADLBN ALKKIHFIKDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly GAEGCDCBFLB FMILPENBDMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly PHONBPAKPKN FFFBJJCPKNN;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public bool JNIOILLGDLI
	{
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x199BA00", Offset = "0x199A000", VA = "0x18199BA00", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public PHONBPAKPKN IMPLNDBOMBL
	{
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0xAB1080", Offset = "0xAAF680", VA = "0x180AB1080", Slot = "11")]
		get
		{
			return default(PHONBPAKPKN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x879E0A0", Offset = "0x879C6A0", VA = "0x18879E0A0")]
	public AILENFJGBHO(KJMCALOBECF ALKKIHFIKDP, [In] AEHFEICJLEG ACJFHCNBBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x879DC60", Offset = "0x879C260", VA = "0x18879DC60", Slot = "4")]
	public void JPNPNACFNCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x879DBC0", Offset = "0x879C1C0", VA = "0x18879DBC0")]
	private bool IHIGMDLDLFM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x879DD70", Offset = "0x879C370", VA = "0x18879DD70", Slot = "5")]
	public void NAHLNMNCMLP(object DKFMAIJGPFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x879DB90", Offset = "0x879C190", VA = "0x18879DB90", Slot = "6")]
	public void IGADNBPFGEJ(object DKFMAIJGPFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x879DDA0", Offset = "0x879C3A0", VA = "0x18879DDA0", Slot = "9")]
	public void NNIFHBANJAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x879DA70", Offset = "0x879C070", VA = "0x18879DA70")]
	private void HBADKEJFNLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x879DF20", Offset = "0x879C520", VA = "0x18879DF20")]
	private void ODLHPAIPAFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x879DEE0", Offset = "0x879C4E0", VA = "0x18879DEE0", Slot = "8")]
	public void OAGLIAPFFLN(KJMCALOBECF ALKKIHFIKDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x879DD30", Offset = "0x879C330", VA = "0x18879DD30", Slot = "7")]
	public void MBEFMCKGHIM(KJMCALOBECF ALKKIHFIKDP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class IJKCJBGOBLA : EJBKHGLAIFG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly CLOFJJADLBN ALKKIHFIKDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly GAEGCDCBFLB NFAAMJJDPIE;

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public bool HLKDNGBMEHB
	{
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x87A8530", Offset = "0x87A6B30", VA = "0x1887A8530", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002B")]
	public event IBJOPKNCPIE KIJLJIHBNPL
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x87A8680", Offset = "0x87A6C80", VA = "0x1887A8680", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x87A85E0", Offset = "0x87A6BE0", VA = "0x1887A85E0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x87A87F0", Offset = "0x87A6DF0", VA = "0x1887A87F0")]
	public IJKCJBGOBLA(KJMCALOBECF ALKKIHFIKDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x87A87D0", Offset = "0x87A6DD0", VA = "0x1887A87D0", Slot = "7")]
	public void MIDNGBHBBFF(object DKFMAIJGPFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x87A87E0", Offset = "0x87A6DE0", VA = "0x1887A87E0", Slot = "8")]
	public void NEPDGGGEIHI(object DKFMAIJGPFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x87A83E0", Offset = "0x87A69E0", VA = "0x1887A83E0", Slot = "9")]
	public void AMAMAGGPGCK(object DKFMAIJGPFL, bool PJBLBGNDEOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x87A84F0", Offset = "0x87A6AF0", VA = "0x1887A84F0", Slot = "12")]
	public void BMOKKDAIGCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x87A8750", Offset = "0x87A6D50", VA = "0x1887A8750", Slot = "10")]
	public void MGGOCMEMKAK(Rigidbody DLDHGDFMDNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x87A8720", Offset = "0x87A6D20", VA = "0x1887A8720", Slot = "11")]
	public void MDDDFGANMPF(Rigidbody GPPACDEEKNJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal sealed class GEMFOMPDAIP : GLOEDMBBKPC, OBHINKDPFLF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly CLOFJJADLBN ALKKIHFIKDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private RRNetworkView PNENHMDGAJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private bool HPIIGNBGHAC;

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public RRNetworkView CFGIPNLJEMG
	{
		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0xA45140", Offset = "0xA43740", VA = "0x180A45140", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public bool GKEDLOLAOJD
	{
		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x87A7B30", Offset = "0x87A6130", VA = "0x1887A7B30", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool ICEMPBOOKEH
	{
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0xAB10A0", Offset = "0xAAF6A0", VA = "0x180AB10A0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002C")]
	public event IBJOPKNCPIE ADFEEMIDPKF
	{
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x87A73C0", Offset = "0x87A59C0", VA = "0x1887A73C0", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x87A6FB0", Offset = "0x87A55B0", VA = "0x1887A6FB0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x87A7B40", Offset = "0x87A6140", VA = "0x1887A7B40")]
	public GEMFOMPDAIP(KJMCALOBECF ALKKIHFIKDP, [In] AEHFEICJLEG ACJFHCNBBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x87A7720", Offset = "0x87A5D20", VA = "0x1887A7720", Slot = "9")]
	public void JPNPNACFNCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x87A7050", Offset = "0x87A5650", VA = "0x1887A7050", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x87A79C0", Offset = "0x87A5FC0", VA = "0x1887A79C0", Slot = "10")]
	public void MMNFPLBAPLI(KJMCALOBECF NBIJLPJHNNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x87A7850", Offset = "0x87A5E50", VA = "0x1887A7850", Slot = "11")]
	public void MKNEGKDAFPI(KJMCALOBECF NBIJLPJHNNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x87A7460", Offset = "0x87A5A60", VA = "0x1887A7460")]
	private void HELCDKEDAGL(RRNetworkView PALNPKLGOGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x87A75D0", Offset = "0x87A5BD0", VA = "0x1887A75D0")]
	private void HJECOJKJBIO(KGNLHMPLHEM MAJLIFPPHAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x87A7150", Offset = "0x87A5750", VA = "0x1887A7150")]
	private void FMJFLMANJNE(RRNetworkView CNOKJECDOEK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal static class LJEEJLNGBHN
{
	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x87AFED0", Offset = "0x87AE4D0", VA = "0x1887AFED0")]
	public static GLOEDMBBKPC ACIOEFMMCPM(this KJMCALOBECF FIAONBPCJJK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal sealed class IBPCLGLBHMF : OKBLJHHOEFJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly CLOFJJADLBN ALKKIHFIKDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private RigidbodyConstraints ONGNIJAFIJG;

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public bool HEKODFAGFLD
	{
		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0xAA58D0", Offset = "0xAA3ED0", VA = "0x180AA58D0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0xDF4C20", Offset = "0xDF3220", VA = "0x180DF4C20", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public bool PDBPNGNHNCI
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0xAB7D70", Offset = "0xAB6370", VA = "0x180AB7D70", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0xDF5190", Offset = "0xDF3790", VA = "0x180DF5190")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public RigidbodyConstraints FJCAHLOMPNG
	{
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0xA4C4A0", Offset = "0xA4AAA0", VA = "0x180A4C4A0", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x87A81A0", Offset = "0x87A67A0", VA = "0x1887A81A0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x87A8330", Offset = "0x87A6930", VA = "0x1887A8330")]
	public IBPCLGLBHMF(KJMCALOBECF ALKKIHFIKDP, [In] AEHFEICJLEG ACJFHCNBBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x87A8300", Offset = "0x87A6900", VA = "0x1887A8300", Slot = "9")]
	public void MGGOCMEMKAK(Rigidbody GPPACDEEKNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x87A82D0", Offset = "0x87A68D0", VA = "0x1887A82D0", Slot = "10")]
	public void MDDDFGANMPF(Rigidbody GPPACDEEKNJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class HMDINDEMIHP : IFGFNJLIAFE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly KJMCALOBECF ALKKIHFIKDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private float OIDFNHHAEBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private float KMCPAMNNJNB;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public float JBIBDAIFABP
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0xAA7CA0", Offset = "0xAA62A0", VA = "0x180AA7CA0", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x87A7ED0", Offset = "0x87A64D0", VA = "0x1887A7ED0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public float NFEEKMEAMML
	{
		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0xAA7C90", Offset = "0xAA6290", VA = "0x180AA7C90", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x87A8090", Offset = "0x87A6690", VA = "0x1887A8090", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x87A8160", Offset = "0x87A6760", VA = "0x1887A8160")]
	public HMDINDEMIHP(KJMCALOBECF ALKKIHFIKDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x87A8040", Offset = "0x87A6640", VA = "0x1887A8040", Slot = "8")]
	public void MGGOCMEMKAK(Rigidbody GPPACDEEKNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x87A7FA0", Offset = "0x87A65A0", VA = "0x1887A7FA0", Slot = "9")]
	public void MDDDFGANMPF(Rigidbody GPPACDEEKNJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal sealed class LAFBLIEGHBC : HGLPIHPJLIE
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static readonly LHMKAIAPMBI MMMKKOFDDFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly CLOFJJADLBN ALKKIHFIKDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private bool JEMKMKHONFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private bool FMIGHJHPLJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private int NELJHLEOKKO;

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	private Rigidbody AOLLOIANELI
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x87AECA0", Offset = "0x87AD2A0", VA = "0x1887AECA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	private bool MAAOCEBLMNB
	{
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x87AE9F0", Offset = "0x87ACFF0", VA = "0x1887AE9F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	private KJMCALOBECF GCMDLKAOFPF
	{
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x87AEA10", Offset = "0x87AD010", VA = "0x1887AEA10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	private bool IKAKALLGAEP
	{
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x87AE450", Offset = "0x87ACA50", VA = "0x1887AE450")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002D")]
	public event IBJOPKNCPIE PGMDFIFMFPA
	{
		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x87AEC00", Offset = "0x87AD200", VA = "0x1887AEC00", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x87AEEB0", Offset = "0x87AD4B0", VA = "0x1887AEEB0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x87AF080", Offset = "0x87AD680", VA = "0x1887AF080")]
	public LAFBLIEGHBC(KJMCALOBECF ALKKIHFIKDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x87AECF0", Offset = "0x87AD2F0", VA = "0x1887AECF0", Slot = "6")]
	public void JPNPNACFNCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x87AE550", Offset = "0x87ACB50", VA = "0x1887AE550", Slot = "8")]
	public void BPKNKPDCKFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x87AE620", Offset = "0x87ACC20", VA = "0x1887AE620", Slot = "7")]
	public bool EBIFDFGHHKF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x87AE4B0", Offset = "0x87ACAB0", VA = "0x1887AE4B0", Slot = "9")]
	public void ANEGIPGNHPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x87AEF50", Offset = "0x87AD550", VA = "0x1887AEF50", Slot = "13")]
	public void OCBPHJPKKED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x87AED80", Offset = "0x87AD380", VA = "0x1887AED80", Slot = "12")]
	public void KAPFKPODLFL(bool OAMIGNKBLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x87AE3E0", Offset = "0x87AC9E0", VA = "0x1887AE3E0", Slot = "10")]
	public bool ADBKGEAHJLP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x87AE560", Offset = "0x87ACB60", VA = "0x1887AE560", Slot = "11")]
	public bool CACCNINOMND()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x87AE770", Offset = "0x87ACD70", VA = "0x1887AE770")]
	private bool FLBOPKMPCHM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x87AEA70", Offset = "0x87AD070", VA = "0x1887AEA70")]
	private void GPADPEIIGGM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class MBPBFLGJEOC : FGDJKKPDMOO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly CLOFJJADLBN ALKKIHFIKDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly GAEGCDCBFLB NLGFCHAPMNA;

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public Rigidbody AOLLOIANELI
	{
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0xA45140", Offset = "0xA43740", VA = "0x180A45140", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0xA451B0", Offset = "0xA437B0", VA = "0x180A451B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	private bool IKAKALLGAEP
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x87AF110", Offset = "0x87AD710", VA = "0x1887AF110")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public bool MCNIKJMJAAA
	{
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x199BA00", Offset = "0x199A000", VA = "0x18199BA00", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x87B0840", Offset = "0x87AEE40", VA = "0x1887B0840")]
	public MBPBFLGJEOC(KJMCALOBECF ALKKIHFIKDP, [In] AEHFEICJLEG ACJFHCNBBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x87B0580", Offset = "0x87AEB80", VA = "0x1887B0580", Slot = "5")]
	public void JPNPNACFNCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x87B0550", Offset = "0x87AEB50", VA = "0x1887B0550", Slot = "7")]
	public void GHAIAGLOMLE(object DKFMAIJGPFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x87B0810", Offset = "0x87AEE10", VA = "0x1887B0810", Slot = "8")]
	public void MILCNPIKOKP(object DKFMAIJGPFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x87B00A0", Offset = "0x87AE6A0", VA = "0x1887B00A0", Slot = "9")]
	public void ADAGCIPACAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x87B0620", Offset = "0x87AEC20", VA = "0x1887B0620", Slot = "10")]
	public void MCGKILIEMOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x87B03D0", Offset = "0x87AE9D0", VA = "0x1887B03D0", Slot = "11")]
	public void CPPFDDCOFOK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal sealed class JONFPDFPEDI : BEFAFDJEHJB, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly CLOFJJADLBN ALKKIHFIKDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly GAEGCDCBFLB DCAHBMBBMAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private float DCJNHHFMMLG;

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public MJAJOILNJDL KJBKCIOGHJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0xA47BE0", Offset = "0xA461E0", VA = "0x180A47BE0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0xA47A10", Offset = "0xA46010", VA = "0x180A47A10", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public IPBPHKFFBLO GNCKEPNHHLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0xA49530", Offset = "0xA47B30", VA = "0x180A49530", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0xA49520", Offset = "0xA47B20", VA = "0x180A49520", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public Vector3 OEOMMCEFOBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x87ABA40", Offset = "0x87AA040", VA = "0x1887ABA40", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x87AB260", Offset = "0x87A9860", VA = "0x1887AB260", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public Vector3 BFKLLHBBDEE
	{
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x87A9B90", Offset = "0x87A8190", VA = "0x1887A9B90", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x87ABFD0", Offset = "0x87AA5D0", VA = "0x1887ABFD0", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public Vector3 EHFIENHFGIH
	{
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x87AB4C0", Offset = "0x87A9AC0", VA = "0x1887AB4C0", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x87AB850", Offset = "0x87A9E50", VA = "0x1887AB850", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public Vector3 CHPFEECDGGP
	{
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x87AC240", Offset = "0x87AA840", VA = "0x1887AC240", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x87AA2D0", Offset = "0x87A88D0", VA = "0x1887AA2D0", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public float KONJLKJMJCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0xAA0F70", Offset = "0xA9F570", VA = "0x180AA0F70", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x87AA780", Offset = "0x87A8D80", VA = "0x1887AA780", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public bool DEKJBEEPNPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x22C3A90", Offset = "0x22C2090", VA = "0x1822C3A90", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	private HGHNDMMNMJH BCJLJLJDMEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x7D276D0", Offset = "0x7D25CD0", VA = "0x187D276D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	private bool MAAOCEBLMNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x87AA2B0", Offset = "0x87A88B0", VA = "0x1887AA2B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x87AC3D0", Offset = "0x87AA9D0", VA = "0x1887AC3D0")]
	public JONFPDFPEDI(KJMCALOBECF ALKKIHFIKDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x87A9AE0", Offset = "0x87A80E0", VA = "0x1887A9AE0", Slot = "19")]
	public void JPNPNACFNCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x87A9660", Offset = "0x87A7C60", VA = "0x1887A9660", Slot = "36")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x87AB910", Offset = "0x87A9F10", VA = "0x1887AB910", Slot = "28")]
	public void MGGOCMEMKAK(Rigidbody GPPACDEEKNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x177BE70", Offset = "0x177A470", VA = "0x18177BE70", Slot = "20")]
	public void CLEADCDDLCH(object DKFMAIJGPFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x177A2B0", Offset = "0x17788B0", VA = "0x18177A2B0", Slot = "30")]
	public void ECJHCMEDENB(object DKFMAIJGPFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x87A9000", Offset = "0x87A7600", VA = "0x1887A9000", Slot = "35")]
	public Vector3 CKABKLDEEOE(Vector3 LMKBILFPCNN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x87AB690", Offset = "0x87A9C90", VA = "0x1887AB690", Slot = "34")]
	public Vector3 LBHKOCIKHGA(Vector3 AMBPKDHGONF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x87A9AE0", Offset = "0x87A80E0", VA = "0x1887A9AE0", Slot = "27")]
	public void EIFOBIMJAGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x87A8FA0", Offset = "0x87A75A0", VA = "0x1887A8FA0", Slot = "25")]
	public void BEFPNKGEDNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x87ABC00", Offset = "0x87AA200", VA = "0x1887ABC00", Slot = "24")]
	public void NKFNDPLCMBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x87AC000", Offset = "0x87AA600", VA = "0x1887AC000", Slot = "33")]
	public void PALKGBIDBNA(Vector3 OMBFIEDHDAB, Vector3 MIBCMGLMBGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x87ABC60", Offset = "0x87AA260", VA = "0x1887ABC60", Slot = "32")]
	public void NLELMACGJLN(Vector3 MGMMJFCDLHO, Vector3 FKIKANGLALM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x87A9940", Offset = "0x87A7F40", VA = "0x1887A9940", Slot = "31")]
	public void EEMAPOGAEKE(Vector3 BGCEGOALDCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x87AA890", Offset = "0x87A8E90", VA = "0x1887AA890", Slot = "22")]
	public void HECHANHAPKA(JKINPDBJECI FOGGOOKDANB, Vector3 ECHOKDNKMPC, float EPGAPBLIBEP, float PNMMNFPGPCG = 8f, float AIFIBMGEPIP = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x87A96C0", Offset = "0x87A7CC0", VA = "0x1887A96C0", Slot = "21")]
	public void EDLINEFOPPD(PKMLAHKLCAB FMNNFHFKKOM, Vector3 HOKDDCLKNCO, float FDOEOEDHBAF = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x87A8BB0", Offset = "0x87A71B0", VA = "0x1887A8BB0", Slot = "23")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void ANJLPPOBDJL(PKMLAHKLCAB FMNNFHFKKOM, Vector3 CFFPEJBOBIA, float KNNDKDAPHBD = 7f, float EBHHKGCDOIB = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x189AFA0", Offset = "0x18995A0", VA = "0x18189AFA0")]
	private static void IDAPFPKAILM(Vector3 OFCFOGHNCGN, Vector3 IFDADDNBHKB, [Out] Vector3 BMCOHFNPIPN, [Out] Vector3 KMOKIJCHALE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x87AB180", Offset = "0x87A9780", VA = "0x1887AB180", Slot = "29")]
	public Vector3 JFBJCEJGNFB(Vector3 OFCFOGHNCGN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x87ABE40", Offset = "0x87AA440", VA = "0x1887ABE40", Slot = "26")]
	public void OCPLIMNHADO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x87AA780", Offset = "0x87A8D80", VA = "0x1887AA780")]
	private void LPLCMKEKDFI(float KKGBKLFKCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x87AB320", Offset = "0x87A9920", VA = "0x1887AB320")]
	private void KEMFOEPJHAK(Vector3 HOKDDCLKNCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x87ABCC0", Offset = "0x87AA2C0", VA = "0x1887ABCC0")]
	private Vector3 NPMDNPHJPMG()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x87A91E0", Offset = "0x87A77E0", VA = "0x1887A91E0")]
	private void DMLKMNFMHKB(Vector3 AMBPKDHGONF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x87AAF40", Offset = "0x87A9540", VA = "0x1887AAF40")]
	private Vector3 HKFLDCKPPLD()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x87AA300", Offset = "0x87A8900", VA = "0x1887AA300")]
	private void FOPCPMDPHHM(Vector3 KKGBKLFKCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x87A9D10", Offset = "0x87A8310", VA = "0x1887A9D10")]
	private void FLGDENOEDMD(Vector3 AMBPKDHGONF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x87AB0D0", Offset = "0x87A96D0", VA = "0x1887AB0D0")]
	private void IBCIFONDEEN()
	{
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
