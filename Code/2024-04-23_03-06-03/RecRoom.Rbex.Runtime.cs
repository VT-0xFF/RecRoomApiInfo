using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Photon.Pun;
using RecRoom;
using RecRoom.DataLayer.Attributes;
using RecRoom.Logging.Attributes;
using RecRoom.Utils.OverridableFields;
using UnityEngine;
using UnityEngine.Serialization;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_Rbex_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : PPFIOIJOILA
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x68979F0", Offset = "0x68969F0", VA = "0x1868979F0", Slot = "4")]
		public override void GGEFLGLPFBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7EACF0", Offset = "0x7E9CF0", VA = "0x1807EACF0")]
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
	public class _AssemblyIndex : CDBADINMILA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private int[] localIndices0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private FHIBGGCBLGM bitset0;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x7C3F20", Offset = "0x7C2F20", VA = "0x1807C3F20", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x136C890", Offset = "0x136B890", VA = "0x18136C890", Slot = "5")]
		public override void PCDBKALOINM(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x689E440", Offset = "0x689D440", VA = "0x18689E440")]
		private void PGAGGJGHCFI(ONLPPOONLNB registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x689E3E0", Offset = "0x689D3E0", VA = "0x18689E3E0", Slot = "6")]
		public override void LKKAGAMGGHO(ONLPPOONLNB registry, [In] NOJHENBCIAB filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0", Slot = "8")]
		public override void OEBDDKFLPEG(LILEGJCEJGA registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x689E750", Offset = "0x689D750", VA = "0x18689E750")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[DisallowMultipleComponent]
	public sealed class RigidbodyEx : MonoBehaviour, KMOJNPOCKBC
	{
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static readonly NDLEKAMCBHL FKDKPGCLBKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private bool PDNENJPONME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private BOJDJCGCFMG OCAJNDMMDLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[SerializeField]
		[IELENNDBCLM(PHHCCEMPGEN.Self, false, false, false)]
		private Rigidbody unityRigidbody;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[SerializeField]
		[IELENNDBCLM(PHHCCEMPGEN.SelfAndParent, true, false, false)]
		private PhotonView photonView;

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
		private KDOAGIGOPNE physicsInterpolation;

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

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal BOJDJCGCFMG MOIDKEPIEEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x6899E20", Offset = "0x6898E20", VA = "0x186899E20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private BOJDJCGCFMG AKPIEINABDA
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x7C2D60", Offset = "0x7C1D60", VA = "0x1807C2D60", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int EDAKNKJNJME
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x689B810", Offset = "0x689A810", VA = "0x18689B810")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RigidbodyEx JBLLCANBPAH
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x689BB70", Offset = "0x689AB70", VA = "0x18689BB70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx NNCBLFAOELK
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x689BAB0", Offset = "0x689AAB0", VA = "0x18689BAB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RigidbodyEx NNHBJFPLAAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x689C820", Offset = "0x689B820", VA = "0x18689C820")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x689DD50", Offset = "0x689CD50", VA = "0x18689DD50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Transform HDOBGLCPOIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x7E9A90", Offset = "0x7E8A90", VA = "0x1807E9A90", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Transform ADFIPMCFPOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x7E9A90", Offset = "0x7E8A90", VA = "0x1807E9A90", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public HLEHOHIHLOC EDJEBEDGABJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x689B870", Offset = "0x689A870", VA = "0x18689B870")]
			get
			{
				return default(HLEHOHIHLOC);
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x689D500", Offset = "0x689C500", VA = "0x18689D500")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool ECGJJHKFHFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x689BE80", Offset = "0x689AE80", VA = "0x18689BE80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool HCNGLELBJAH
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x689B990", Offset = "0x689A990", VA = "0x18689B990")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public BGLLLMAKHCH LIBOIILFAKL
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x689BDC0", Offset = "0x689ADC0", VA = "0x18689BDC0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x689D6C0", Offset = "0x689C6C0", VA = "0x18689D6C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public EADDLCIMNLA HLMFNPADCNG
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x689BD60", Offset = "0x689AD60", VA = "0x18689BD60")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x689D650", Offset = "0x689C650", VA = "0x18689D650")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool LEDPLHBJICL
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x689BCB0", Offset = "0x689ACB0", VA = "0x18689BCB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public Rigidbody FDIPIHCLHPM
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x689BD10", Offset = "0x689AD10", VA = "0x18689BD10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool KJNJAAONODH
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x689B9F0", Offset = "0x689A9F0", VA = "0x18689B9F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x689D570", Offset = "0x689C570", VA = "0x18689D570")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool JADDMCIFKEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x601D2F0", Offset = "0x601C2F0", VA = "0x18601D2F0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public float PADHCFJLLNL
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x689C7C0", Offset = "0x689B7C0", VA = "0x18689C7C0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public float PNOIJOAKOEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x689C760", Offset = "0x689B760", VA = "0x18689C760")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x689DCE0", Offset = "0x689CCE0", VA = "0x18689DCE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float MFCKJHGMLFA
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x689C0E0", Offset = "0x689B0E0", VA = "0x18689C0E0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x689D960", Offset = "0x689C960", VA = "0x18689D960")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float KLAECCBPPOI
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x689BEE0", Offset = "0x689AEE0", VA = "0x18689BEE0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x689D730", Offset = "0x689C730", VA = "0x18689D730")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool ABOANMONEBK
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x689CDA0", Offset = "0x689BDA0", VA = "0x18689CDA0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x689E290", Offset = "0x689D290", VA = "0x18689E290")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public Vector3 CHMNBEACIEG
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x689C540", Offset = "0x689B540", VA = "0x18689C540")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x689DAB0", Offset = "0x689CAB0", VA = "0x18689DAB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Vector3 OFMJBDJAIMC
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x689CEE0", Offset = "0x689BEE0", VA = "0x18689CEE0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public CollisionDetectionMode OJHLAIGOINP
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x689C020", Offset = "0x689B020", VA = "0x18689C020")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x689D880", Offset = "0x689C880", VA = "0x18689D880")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public float DLPJBFBAGPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x689BA50", Offset = "0x689AA50", VA = "0x18689BA50")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x689D5E0", Offset = "0x689C5E0", VA = "0x18689D5E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public RigidbodyConstraints LDMDMBPNDBF
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x689C080", Offset = "0x689B080", VA = "0x18689C080")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x689D8F0", Offset = "0x689C8F0", VA = "0x18689D8F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public Vector3 MNFOEECONHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x689C8E0", Offset = "0x689B8E0", VA = "0x18689C8E0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public Vector3 JICIILHPMJP
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x689C8E0", Offset = "0x689B8E0", VA = "0x18689C8E0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x689E070", Offset = "0x689D070", VA = "0x18689E070")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float MHKKHPKKOCE
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x689C620", Offset = "0x689B620", VA = "0x18689C620")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x689DB90", Offset = "0x689CB90", VA = "0x18689DB90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float FDOKALIJFPE
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x689CD40", Offset = "0x689BD40", VA = "0x18689CD40")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x689E220", Offset = "0x689D220", VA = "0x18689E220")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public Quaternion AHBCJHDLAHA
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x689C9C0", Offset = "0x689B9C0", VA = "0x18689C9C0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x689DDF0", Offset = "0x689CDF0", VA = "0x18689DDF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public Quaternion KHEFMFCHIAM
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x689CC60", Offset = "0x689BC60", VA = "0x18689CC60")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x689E150", Offset = "0x689D150", VA = "0x18689E150")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Vector3 IDDHIILDENJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x689CAA0", Offset = "0x689BAA0", VA = "0x18689CAA0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x689DEC0", Offset = "0x689CEC0", VA = "0x18689DEC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Quaternion EBNOAMALGIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x689CB80", Offset = "0x689BB80", VA = "0x18689CB80")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x689DFA0", Offset = "0x689CFA0", VA = "0x18689DFA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector3 KKLIKHAJECJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x689CE00", Offset = "0x689BE00", VA = "0x18689CE00")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x689E300", Offset = "0x689D300", VA = "0x18689E300")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Vector3 EALHJCELKMC
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x689C680", Offset = "0x689B680", VA = "0x18689C680")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x689DC00", Offset = "0x689CC00", VA = "0x18689DC00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 DNLKJNNJFNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x689BF40", Offset = "0x689AF40", VA = "0x18689BF40")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x689D7A0", Offset = "0x689C7A0", VA = "0x18689D7A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 KMLMDMHBLNP
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x689C460", Offset = "0x689B460", VA = "0x18689C460")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x689D9D0", Offset = "0x689C9D0", VA = "0x18689D9D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector3 FJMKIPCPEGP
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x689C320", Offset = "0x689B320", VA = "0x18689C320")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Quaternion GAGDFKFHNKA
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x689C240", Offset = "0x689B240", VA = "0x18689C240")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector3 KAAEHHEMCHJ
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x689D0A0", Offset = "0x689C0A0", VA = "0x18689D0A0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Vector3 PDIAACCALOI
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x689CFC0", Offset = "0x689BFC0", VA = "0x18689CFC0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool POEHINHMGLP
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x689C400", Offset = "0x689B400", VA = "0x18689C400")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool AJCGGKDIPDC
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x689BE20", Offset = "0x689AE20", VA = "0x18689BE20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool GELHPFANFAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x689B930", Offset = "0x689A930", VA = "0x18689B930")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool GOKKHBFMOBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x689B8D0", Offset = "0x689A8D0", VA = "0x18689B8D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool KHOLFIBMOJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x689B7B0", Offset = "0x689A7B0", VA = "0x18689B7B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool CAIFPGLOLAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x689C140", Offset = "0x689B140", VA = "0x18689C140")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool OLODGLIPGPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x538C890", Offset = "0x538B890", VA = "0x18538C890")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event CBDBCCOAADF GDPHOGGHJPC
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x689B6D0", Offset = "0x689A6D0", VA = "0x18689B6D0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x689D420", Offset = "0x689C420", VA = "0x18689D420")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event DGOFPGGNFJP JFHNFKPPMEC
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x689B440", Offset = "0x689A440", VA = "0x18689B440")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x689D180", Offset = "0x689C180", VA = "0x18689D180")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event DGOFPGGNFJP HMPCCEAHOEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x689B4A0", Offset = "0x689A4A0", VA = "0x18689B4A0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x689D1F0", Offset = "0x689C1F0", VA = "0x18689D1F0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event DGOFPGGNFJP MDPNGGMBOHD
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x689B5F0", Offset = "0x689A5F0", VA = "0x18689B5F0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x689D340", Offset = "0x689C340", VA = "0x18689D340")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<DCFIIAFEJOH, DCFIIAFEJOH> IFLHJOAAPEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x689B580", Offset = "0x689A580", VA = "0x18689B580")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x689D2D0", Offset = "0x689C2D0", VA = "0x18689D2D0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event DGOFPGGNFJP AEGHEEJFHBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x689B660", Offset = "0x689A660", VA = "0x18689B660")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x689D3B0", Offset = "0x689C3B0", VA = "0x18689D3B0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event DGOFPGGNFJP MFKKCLMAKCL
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x689B740", Offset = "0x689A740", VA = "0x18689B740")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x689D490", Offset = "0x689C490", VA = "0x18689D490")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event DGOFPGGNFJP GFDECECHNDK
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x689B510", Offset = "0x689A510", VA = "0x18689B510")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x689D260", Offset = "0x689C260", VA = "0x18689D260")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7C1DE0", Offset = "0x7C0DE0", VA = "0x1807C1DE0", Slot = "8")]
		private void APPMHKBEOPJ(BOJDJCGCFMG OFFMGNOKEOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x689A3A0", Offset = "0x68993A0", VA = "0x18689A3A0")]
		internal void KELONKFNMHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x689B160", Offset = "0x689A160", VA = "0x18689B160")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public void TestOverrideUnityRigidbody(Rigidbody EJDMIIBAALL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6899ED0", Offset = "0x6898ED0", VA = "0x186899ED0")]
		public KMOJNPOCKBC GetChild(int GPEHCABDGEJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x689AE30", Offset = "0x6899E30", VA = "0x18689AE30")]
		public void SetInertiaTensor((Quaternion rot, Vector3 moments) AFGCIFLCAMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x68999B0", Offset = "0x68989B0", VA = "0x1868999B0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6899E20", Offset = "0x6898E20", VA = "0x186899E20")]
		private BOJDJCGCFMG OONJPMNAKGA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6899A20", Offset = "0x6898A20", VA = "0x186899A20")]
		private void CPHLHCOPMDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x689A600", Offset = "0x6899600", VA = "0x18689A600")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x689A3A0", Offset = "0x68993A0", VA = "0x18689A3A0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x689A5A0", Offset = "0x68995A0", VA = "0x18689A5A0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x689A660", Offset = "0x6899660", VA = "0x18689A660")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6899060", Offset = "0x6898060", VA = "0x186899060")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object KONODCHOCOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x689A6C0", Offset = "0x68996C0", VA = "0x18689A6C0")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object KONODCHOCOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6899DC0", Offset = "0x6898DC0", VA = "0x186899DC0")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x689A540", Offset = "0x6899540", VA = "0x18689A540")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x689AF90", Offset = "0x6899F90", VA = "0x18689AF90")]
		public void SetParent(RigidbodyEx LDGMLLMKHLF, bool MKBGEMOIAJC = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x689A9D0", Offset = "0x68999D0", VA = "0x18689A9D0")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x689A180", Offset = "0x6899180", VA = "0x18689A180")]
		public bool IsRigidbodyAncestor(RigidbodyEx HBLGGCLJPGF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x689A260", Offset = "0x6899260", VA = "0x18689A260")]
		public bool IsRigidbodyDescendant(RigidbodyEx MKKHDDGHMMD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x68992D0", Offset = "0x68982D0", VA = "0x1868992D0")]
		public void AddInterpolationRestriction(object KONODCHOCOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x689A730", Offset = "0x6899730", VA = "0x18689A730")]
		public void RemoveInterpolationRestriction(object KONODCHOCOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x6899340", Offset = "0x6898340", VA = "0x186899340")]
		public void AddKinematic(object KONODCHOCOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x689A7A0", Offset = "0x68997A0", VA = "0x18689A7A0")]
		public void RemoveKinematic(object KONODCHOCOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x689AF10", Offset = "0x6899F10", VA = "0x18689AF10")]
		public void SetKinematic(object KONODCHOCOG, bool DALNOEDDEKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x689AD30", Offset = "0x6899D30", VA = "0x18689AD30")]
		public void SetDiscontinuousPositionAndRotation(Vector3 CMEGFIPCBCA, Quaternion DHACMNNFPAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x689AC30", Offset = "0x6899C30", VA = "0x18689AC30")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 NIPGJDJBIOA, Quaternion GHLENEHONEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x689A070", Offset = "0x6899070", VA = "0x18689A070")]
		public Vector3 GetConstrainedVelocity(Vector3 KKLIKHAJECJ)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6899F60", Offset = "0x6898F60", VA = "0x186899F60")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 DNLKJNNJFNH)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x68991E0", Offset = "0x68981E0", VA = "0x1868991E0")]
		public void AddForce(Vector3 CLNMAALIOEC, ForceMode LBNNCFGJHGI = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x68990D0", Offset = "0x68980D0", VA = "0x1868990D0")]
		public void AddForceAtPosition(Vector3 CLNMAALIOEC, Vector3 BJIKBOECFPB, ForceMode LBNNCFGJHGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6899510", Offset = "0x6898510", VA = "0x186899510")]
		public void AddTorque(Vector3 KAPPHDNKKED, ForceMode LBNNCFGJHGI = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x68993B0", Offset = "0x68983B0", VA = "0x1868993B0")]
		public void AddRelativeTorque(Vector3 KAPPHDNKKED, ForceMode LBNNCFGJHGI = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x689B230", Offset = "0x689A230", VA = "0x18689B230")]
		public Vector3 WorldToLocalVelocity(Vector3 EHDONMPNJKF)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x689A430", Offset = "0x6899430", VA = "0x18689A430")]
		public Vector3 LocalToWorldVelocity(Vector3 EALHJCELKMC)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6899D60", Offset = "0x6898D60", VA = "0x186899D60")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6899D00", Offset = "0x6898D00", VA = "0x186899D00")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6899CA0", Offset = "0x6898CA0", VA = "0x186899CA0")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6899C40", Offset = "0x6898C40", VA = "0x186899C40")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x689AB30", Offset = "0x6899B30", VA = "0x18689AB30")]
		public void ResetVelocityWorldSpace(Vector3 GEFAOGEPMNH, Vector3 DHJFGPMFDHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x689AA30", Offset = "0x6899A30", VA = "0x18689AA30")]
		public void ResetVelocityLocalSpace(Vector3 AOILAALLFEL, Vector3 KMLMDMHBLNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x689A8F0", Offset = "0x68998F0", VA = "0x18689A8F0")]
		public void ResetLinearVelocityLocalSpace(Vector3 AOILAALLFEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x689B0C0", Offset = "0x689A0C0", VA = "0x18689B0C0")]
		public bool SweepTest(Vector3 PFFNCAKFCDH, [Out] RaycastHit LABCFOAKNEI, float MPDLEMGFFNF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x689A340", Offset = "0x6899340", VA = "0x18689A340")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x689B060", Offset = "0x689A060", VA = "0x18689B060")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x689B1D0", Offset = "0x689A1D0", VA = "0x18689B1D0")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x68994A0", Offset = "0x68984A0", VA = "0x1868994A0")]
		public void AddShouldHaveUnityRigidbodyToken(object KONODCHOCOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x689A810", Offset = "0x6899810", VA = "0x18689A810")]
		public void RemoveShouldHaveUnityRigidbodyToken(object KONODCHOCOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x6899840", Offset = "0x6898840", VA = "0x186899840")]
		public void ApplyForceVelocityChange(MEKFJPELAOM MMJDJKINIEI, Vector3 JJCDAOEEONM, float APHKJGDFGHN, float FPIBBDFFLEM = 8f, float DMLBKDPKECC = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x68997A0", Offset = "0x68987A0", VA = "0x1868997A0")]
		public void ApplyAngularVelocityChange(FNFFNOPGDAE BIGJKOCLOKM, Vector3 PKJJGHKMLBD, float JGGJJDNDNCC = float.PositiveInfinity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6899900", Offset = "0x6898900", VA = "0x186899900")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void ApplyTorqueAngularVelocityChangeDeprecated(FNFFNOPGDAE BIGJKOCLOKM, Vector3 CKCOAEGKOKA, float GPACIKBBBFF = 7f, float KCOELLNBOPI = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x68996D0", Offset = "0x68986D0", VA = "0x1868996D0")]
		public bool AllowedScaleChange(float FOHBFABOGNJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x6899600", Offset = "0x6898600", VA = "0x186899600")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx GBOPLKAOBPK, object KONODCHOCOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x689A880", Offset = "0x6899880", VA = "0x18689A880")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object KONODCHOCOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x689B3D0", Offset = "0x689A3D0", VA = "0x18689B3D0")]
		public RigidbodyEx()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x883CE0", Offset = "0x882CE0", VA = "0x180883CE0", Slot = "4")]
		private GameObject FOJHGBFLHJP()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x7E9A90", Offset = "0x7E8A90", VA = "0x1807E9A90", Slot = "5")]
		private Transform CCNLDKEIEJM()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal static class FJPLGMGDHPC
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x688B1F0", Offset = "0x688A1F0", VA = "0x18688B1F0")]
	public static BOJDJCGCFMG MOIDKEPIEEH(this RigidbodyEx IHACPEDFDJO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[KGDCKDGHHEL(typeof(KKEBIBJADNL), new string[] { })]
public class DHHCHLEJACH : KKEBIBJADNL, IDCMJKJGJOM
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static readonly NDLEKAMCBHL LAGKGKDNMJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private PGLBABFJBHF HBDJFLKKDBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private AIPNOPJCCJE AKJKFGAFELN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private LBNABDEFMOC HDFECEPFGHD;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public AIPNOPJCCJE BNJIHDAPCGF
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x7C29D0", Offset = "0x7C19D0", VA = "0x1807C29D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public LBNABDEFMOC MNNHLHGGHCD
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x7C2D60", Offset = "0x7C1D60", VA = "0x1807C2D60", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6889CA0", Offset = "0x6888CA0", VA = "0x186889CA0", Slot = "7")]
	public void InitReferences(DHADIMIDLEJ JIMAIACHILI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6889D30", Offset = "0x6888D30", VA = "0x186889D30", Slot = "6")]
	public BOJDJCGCFMG KMIOFGJIBLJ(RigidbodyEx IHACPEDFDJO, KGDPENLDKCN GPKMLHOONCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
	public DHHCHLEJACH()
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class PhysicsManager : SingletonMonoBehaviour<PhysicsManager>
	{
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static ONDMBBPPJJI UpdateAfterFixedUpdateRan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private int OEOKMMBCNJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int BBDHDOHDPIL;

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x6898EC0", Offset = "0x6897EC0", VA = "0x186898EC0")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6898F00", Offset = "0x6897F00", VA = "0x186898F00")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x6898EE0", Offset = "0x6897EE0", VA = "0x186898EE0")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string JJJNODJJIFK, [Optional] UnityEngine.Object DFKOHNJAKHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string JJJNODJJIFK, [Optional] UnityEngine.Object DFKOHNJAKHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6899010", Offset = "0x6898010", VA = "0x186899010")]
		public PhysicsManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class JPKODCAFALE
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class KILKEPBCDMD : BGLLLMAKHCH, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7D0950", Offset = "0x7CF950", VA = "0x1807D0950", Slot = "4")]
		public Vector3 KJNJHIEFCOC()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x7D0950", Offset = "0x7CF950", VA = "0x1807D0950", Slot = "5")]
		public Vector3 BKICNKODLMK()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public KILKEPBCDMD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public static BGLLLMAKHCH FKGBAMNFFAD
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x6896660", Offset = "0x6895660", VA = "0x186896660")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface HABJELOAKJM
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	CollisionDetectionMode NDGMOPBCDFL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KLABGHMFFPK();

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OKEJALEGAKA(bool POEHINHMGLP);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HOLPMFOJGKP(bool POEHINHMGLP);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OKKIHGNIDLB(Rigidbody PEFEIMLIJIA);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool NOBMCNKALEC(Vector3 PFFNCAKFCDH, [Out] RaycastHit LABCFOAKNEI, float MPDLEMGFFNF);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface ACAKANMOKAE : IDisposable, DCPODHBBNDM
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	HLEHOHIHLOC EDJEBEDGABJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action<DCFIIAFEJOH, DCFIIAFEJOH> IFLHJOAAPEF;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KLABGHMFFPK();
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[CDGCFHBGICH(DOECOPLPHCH.Application)]
public interface LBNABDEFMOC
{
	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CFAGADDOLCN DHODPCBCEMO(BOJDJCGCFMG OFFMGNOKEOO);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GIBJNCAOGPN JHDOEFMKNIL(BOJDJCGCFMG OFFMGNOKEOO);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	AGLILLCNOIA BDEIELGLHDF(BOJDJCGCFMG OFFMGNOKEOO);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	MMCFELEGMIA KAIBDNDEDOA(BOJDJCGCFMG OFFMGNOKEOO);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	PCAPEOIGBNK BIDOJCDIKFG(BOJDJCGCFMG OFFMGNOKEOO);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	ACAKANMOKAE OAPFLJLHBFH(BOJDJCGCFMG OFFMGNOKEOO);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "6")]
	KDMCCJIINBG DNNCNBBMAFC(BOJDJCGCFMG OFFMGNOKEOO);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "7")]
	HLGBPGDLDIH DOHKCCLPALM(BOJDJCGCFMG OFFMGNOKEOO);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "8")]
	HABJELOAKJM GPEGODBMNMH(BOJDJCGCFMG OFFMGNOKEOO);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "9")]
	FFLPPNLELDE ENEBJPAENOF(BOJDJCGCFMG OFFMGNOKEOO);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "10")]
	NIOEOOMBGLD KJDEAPKNBCH(BOJDJCGCFMG OFFMGNOKEOO, [In] KGDPENLDKCN GPKMLHOONCL);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "11")]
	LOJNGOGILDG HFHLMPPGBAL(BOJDJCGCFMG OFFMGNOKEOO, [In] KGDPENLDKCN GPKMLHOONCL);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "12")]
	HFLKLNMIGEN BPEGIABJEBE(BOJDJCGCFMG OFFMGNOKEOO, [In] KGDPENLDKCN GPKMLHOONCL);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "13")]
	LGCIGMPCLMM BOCIKOOGPAL(BOJDJCGCFMG OFFMGNOKEOO, [In] KGDPENLDKCN GPKMLHOONCL);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "14")]
	MNJBAMCMDMO BHMPLPMGGBB(BOJDJCGCFMG OFFMGNOKEOO, [In] KGDPENLDKCN GPKMLHOONCL);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "15")]
	BOJDJCGCFMG KMIOFGJIBLJ(RigidbodyEx IHACPEDFDJO, KGDPENLDKCN GPKMLHOONCL, KKEBIBJADNL PGDDBCEFICD);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface HLGBPGDLDIH
{
	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PGKGPOKEDFA(Vector3 CLNMAALIOEC, ForceMode LBNNCFGJHGI = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JDKDMOJNKJF(Vector3 CLNMAALIOEC, Vector3 BJIKBOECFPB, ForceMode LBNNCFGJHGI);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PFKDPNCLGPF(Vector3 KAPPHDNKKED, ForceMode LBNNCFGJHGI = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HDFKIGIDKIK(Vector3 KAPPHDNKKED, ForceMode LBNNCFGJHGI = ForceMode.Force);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface FFLPPNLELDE
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	bool BPKCKECFMIF
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OKKIHGNIDLB(Rigidbody PEFEIMLIJIA);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GEDDPLFBHFE(Rigidbody PEFEIMLIJIA);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface CFAGADDOLCN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	IReadOnlyList<BOJDJCGCFMG> HACDLBFGDJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	BOJDJCGCFMG NNCBLFAOELK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	BOJDJCGCFMG MILAJCEOCBC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event DGOFPGGNFJP JFHNFKPPMEC;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event DGOFPGGNFJP HMPCCEAHOEA;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event CBDBCCOAADF HCLIALJDDKI;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action PEOHKNNNIEC;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action DBAMGFMINDH;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action<BOJDJCGCFMG> JHAFEJOKEHG;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<BOJDJCGCFMG> DDIBJFFGLNL;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event Action BCKAFFBACME;

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action<BOJDJCGCFMG> INGIMJLHHOK;

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void OEOFJMNAFOJ(BOJDJCGCFMG GFOFKCGAIPE, bool MKBGEMOIAJC = false);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface AGLILLCNOIA
{
	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	Vector3 NFNLBCAFKLM
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	Vector3 OLPICLBCHEC
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IHJKJOFDCEI(BOJDJCGCFMG NNHBJFPLAAA, object KONODCHOCOG);

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CIHLANBEHAM(object KONODCHOCOG);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface LGCIGMPCLMM
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	Vector3 AKGFLCJGLGG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	Vector3 ALFJLBFCNPA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	float JJJAFIFADHM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	float OBPCCJIKNGB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	Vector3 FMGJIJKKMJH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	Quaternion MGCGHGJEPIF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event DGOFPGGNFJP KFAHGMNGGME;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void CACBNOKEGDD((Quaternion rot, Vector3 moments) AFGCIFLCAMM);

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void MEMEKBFDJIA();

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void DNPAFIBIPED();

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void PGAPFLHOLLI();

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void OKKIHGNIDLB(Rigidbody PEFEIMLIJIA);

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void GEDDPLFBHFE(Rigidbody PEFEIMLIJIA);

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void GPBBJKIHELB();
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface HFLKLNMIGEN
{
	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KLABGHMFFPK();

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OJDPKNFGEHN(object KONODCHOCOG);

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ABPOEFEKAJB(object KONODCHOCOG);

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ECNAGKMCEBB(BOJDJCGCFMG IHACPEDFDJO);

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NFJBJAKGNID(BOJDJCGCFMG IHACPEDFDJO);

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GNOBEOILMIF();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface KDMCCJIINBG
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	bool EIEMCPKOECE
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event DGOFPGGNFJP JLKABBMECML;

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LKKLCJKCPGN(object KONODCHOCOG);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ILMFNMCMDMF(object KONODCHOCOG);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NBOPJNDAAAI(object KONODCHOCOG, bool DALNOEDDEKB);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OKKIHGNIDLB(Rigidbody JPKDDDJNLCK);

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void GEDDPLFBHFE(Rigidbody PEFEIMLIJIA);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface LOJNGOGILDG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000046")]
	bool ECGJJHKFHFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool HCNGLELBJAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event DGOFPGGNFJP KIOKNGMJMPL;

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KLABGHMFFPK();

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LFCNFELFJDK(BOJDJCGCFMG NNHBJFPLAAA);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LCOGPJFPGFK(BOJDJCGCFMG NNHBJFPLAAA);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface MNJBAMCMDMO
{
	[Cpp2IlInjected.Token(Token = "0x17000048")]
	bool KJNJAAONODH
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool LOMLHPEKCCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	RigidbodyConstraints CHMNFEIOEOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OKKIHGNIDLB(Rigidbody PEFEIMLIJIA);

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void GEDDPLFBHFE(Rigidbody PEFEIMLIJIA);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface MMCFELEGMIA
{
	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	float BIJOGJPJFHF
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	float AKNGIKMOIAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OKKIHGNIDLB(Rigidbody PEFEIMLIJIA);

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GEDDPLFBHFE(Rigidbody PEFEIMLIJIA);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface PCAPEOIGBNK
{
	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event DGOFPGGNFJP ANNJEHCBGGA;

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KLABGHMFFPK();

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool FKBLMGOIBCC();

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GMPEIANMIIJ();

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LJLGIJFOGKH();

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LHGKKDCJCBN();

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void HMJJMGLGKAF();
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface NIOEOOMBGLD
{
	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	Rigidbody FDIPIHCLHPM
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool EBMBLMBHHFM
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KLABGHMFFPK();

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GBIEFGOKLIL(object KONODCHOCOG);

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IDJCOCMHAEG(object KONODCHOCOG);

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LPIMLMKKMGB();

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void IEDHBHDKLLF();
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface GIBJNCAOGPN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	BGLLLMAKHCH LIBOIILFAKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	EADDLCIMNLA HLMFNPADCNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	Vector3 HENBBEFCDFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	Vector3 GNIJNDIJCHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	Vector3 BNHEIIAPBHA
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	Vector3 GLOADELBEAM
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	float DLPJBFBAGPH
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	bool LEDPLHBJICL
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void KLABGHMFFPK();

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void KAJALDFIMCI(object KONODCHOCOG);

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void PPJIHGGOEEG(FNFFNOPGDAE BIGJKOCLOKM, Vector3 PKJJGHKMLBD, float JGGJJDNDNCC = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void FEBHEIBFEHM(MEKFJPELAOM MMJDJKINIEI, Vector3 JJCDAOEEONM, float APHKJGDFGHN, float FPIBBDFFLEM = 8f, float DMLBKDPKECC = 1f);

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void ECMFHAEHEHN(FNFFNOPGDAE BIGJKOCLOKM, Vector3 CKCOAEGKOKA, float GPACIKBBBFF = 7f, float KCOELLNBOPI = 1f);

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void OCMGPNCLHDE();

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void NBFLDFHDMAO();

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void NNABBBGCDDE();

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void CNBLDBEPIJO();

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void OKKIHGNIDLB(Rigidbody PEFEIMLIJIA);

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Vector3 AHHIJEOIOIL(Vector3 KKLIKHAJECJ);

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void ELIBGPPJCNG(object KONODCHOCOG);

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void DBGNEKAAJMN(Vector3 LJLBLGLLKLB);

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void NMHNLHDMDNG(Vector3 AOILAALLFEL, Vector3 KMLMDMHBLNP);

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void LAALPFGIDKP(Vector3 GEFAOGEPMNH, Vector3 DHJFGPMFDHA);

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "30")]
	Vector3 KFDJIPPCPAC(Vector3 EALHJCELKMC);

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Vector3 PCDPBCIHPMF(Vector3 EHDONMPNJKF);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[CDGCFHBGICH(DOECOPLPHCH.Application)]
public interface AIPNOPJCCJE
{
	[Cpp2IlInjected.Token(Token = "0x17000057")]
	bool CLNJDIKLKLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JGJGIMEPDGF(string FKMKCMGJCIN);

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HNJELGLGJFG(RigidbodyEx IHACPEDFDJO, Action LNMJHEPMAAO);

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(Slot = "3")]
	NKHDPGBKMGF IPGNOLMCNJL(int GHDMKFPFKKL);

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BFJFOAOGILA(Vector3 OFMJBDJAIMC, float OAJBIMIEEME, Color IODHIPGGADP);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[CDGCFHBGICH(DOECOPLPHCH.Application)]
public interface KKEBIBJADNL
{
	[Cpp2IlInjected.Token(Token = "0x17000058")]
	AIPNOPJCCJE BNJIHDAPCGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	LBNABDEFMOC MNNHLHGGHCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "2")]
	BOJDJCGCFMG KMIOFGJIBLJ(RigidbodyEx IHACPEDFDJO, KGDPENLDKCN GPKMLHOONCL);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class JJBHMLOENNP : BOJDJCGCFMG, IDisposable, BAHONCBBMJM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	internal readonly KKEBIBJADNL PGDDBCEFICD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	internal CFAGADDOLCN KGKFKMCFLBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	internal HFLKLNMIGEN KOCLKLDBGPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	internal LOJNGOGILDG GIEBCJFEIMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal GIBJNCAOGPN KKLIKHAJECJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal AGLILLCNOIA GOGFKJNDKKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	internal LGCIGMPCLMM JJJHCLGKADB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal MMCFELEGMIA IDMCMKABOLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal FFLPPNLELDE PKIJJHGLJGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	internal PCAPEOIGBNK LJALHELCMFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	internal ACAKANMOKAE BFEICGENILN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	internal KDMCCJIINBG NMGOPCHLNNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	internal HLGBPGDLDIH CLNMAALIOEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	internal MNJBAMCMDMO CPGABNACACN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	internal NIOEOOMBGLD PEFEIMLIJIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	internal HABJELOAKJM DDNLAHDIGLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	internal IDisposable KEEODFBMMHE;

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public NOFNFJEBPPG ONFNEGMNIMD
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x7C06D0", Offset = "0x7BF6D0", VA = "0x1807C06D0", Slot = "22")]
		get
		{
			return default(NOFNFJEBPPG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public KMOJNPOCKBC HGAHPJBABJC
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x7CB7A0", Offset = "0x7CA7A0", VA = "0x1807CB7A0", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x7CB840", Offset = "0x7CA840", VA = "0x1807CB840")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public GameObject GJCLDNHCHFN
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x889620", Offset = "0x888620", VA = "0x180889620", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x889740", Offset = "0x888740", VA = "0x180889740")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public Transform EAHPGDBNGDI
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x6892AF0", Offset = "0x6891AF0", VA = "0x186892AF0", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public Rigidbody FDIPIHCLHPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x6893820", Offset = "0x6892820", VA = "0x186893820", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public BOJDJCGCFMG MILAJCEOCBC
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x6890970", Offset = "0x688F970", VA = "0x186890970", Slot = "27")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x68962E0", Offset = "0x68952E0", VA = "0x1868962E0", Slot = "28")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public int EDAKNKJNJME
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x6894BA0", Offset = "0x6893BA0", VA = "0x186894BA0", Slot = "31")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public BOJDJCGCFMG NNCBLFAOELK
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x6890920", Offset = "0x688F920", VA = "0x186890920", Slot = "29")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public bool ABHAFFOKCAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x6894CD0", Offset = "0x6893CD0", VA = "0x186894CD0", Slot = "138")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public bool ECGJJHKFHFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x6890F80", Offset = "0x688FF80", VA = "0x186890F80", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public bool HCNGLELBJAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x6893160", Offset = "0x6892160", VA = "0x186893160", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public BGLLLMAKHCH LIBOIILFAKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x6893870", Offset = "0x6892870", VA = "0x186893870", Slot = "34")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x6892070", Offset = "0x6891070", VA = "0x186892070", Slot = "35")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public EADDLCIMNLA HLMFNPADCNG
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x6891A20", Offset = "0x6890A20", VA = "0x186891A20", Slot = "36")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x6892010", Offset = "0x6891010", VA = "0x186892010", Slot = "37")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public float DLPJBFBAGPH
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x6894B50", Offset = "0x6893B50", VA = "0x186894B50", Slot = "38")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x68949E0", Offset = "0x68939E0", VA = "0x1868949E0", Slot = "39")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public Vector3 GNIJNDIJCHH
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x6893390", Offset = "0x6892390", VA = "0x186893390", Slot = "40")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x68928A0", Offset = "0x68918A0", VA = "0x1868928A0", Slot = "41")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public Vector3 GLOADELBEAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x68952C0", Offset = "0x68942C0", VA = "0x1868952C0", Slot = "42")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x68938C0", Offset = "0x68928C0", VA = "0x1868938C0", Slot = "43")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public Vector3 HENBBEFCDFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x6890B20", Offset = "0x688FB20", VA = "0x186890B20", Slot = "44")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x6895010", Offset = "0x6894010", VA = "0x186895010", Slot = "45")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public Vector3 BNHEIIAPBHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x6892C60", Offset = "0x6891C60", VA = "0x186892C60", Slot = "46")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x6891940", Offset = "0x6890940", VA = "0x186891940", Slot = "47")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public bool GELHPFANFAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x6894940", Offset = "0x6893940", VA = "0x186894940", Slot = "139")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public bool GOKKHBFMOBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x6893580", Offset = "0x6892580", VA = "0x186893580", Slot = "48")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public bool KHOLFIBMOJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x6895C10", Offset = "0x6894C10", VA = "0x186895C10", Slot = "49")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public bool LEDPLHBJICL
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x6890A70", Offset = "0x688FA70", VA = "0x186890A70", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public Vector3 NFNLBCAFKLM
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x6892FD0", Offset = "0x6891FD0", VA = "0x186892FD0", Slot = "51")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public Vector3 OLPICLBCHEC
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x6892B80", Offset = "0x6891B80", VA = "0x186892B80", Slot = "52")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public Vector3 AKGFLCJGLGG
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x6894260", Offset = "0x6893260", VA = "0x186894260", Slot = "53")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x6895AD0", Offset = "0x6894AD0", VA = "0x186895AD0", Slot = "54")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public Vector3 ALFJLBFCNPA
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x68914D0", Offset = "0x68904D0", VA = "0x1868914D0", Slot = "55")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public float JJJAFIFADHM
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x68953A0", Offset = "0x68943A0", VA = "0x1868953A0", Slot = "56")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public float OBPCCJIKNGB
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x6893690", Offset = "0x6892690", VA = "0x186893690", Slot = "57")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x6891F70", Offset = "0x6890F70", VA = "0x186891F70", Slot = "58")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public Vector3 FMGJIJKKMJH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x68936E0", Offset = "0x68926E0", VA = "0x1868936E0", Slot = "59")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public Quaternion MGCGHGJEPIF
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x6890D80", Offset = "0x688FD80", VA = "0x186890D80", Slot = "60")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public float BIJOGJPJFHF
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x6893AB0", Offset = "0x6892AB0", VA = "0x186893AB0", Slot = "62")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x6894040", Offset = "0x6893040", VA = "0x186894040", Slot = "63")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public float AKNGIKMOIAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x6895270", Offset = "0x6894270", VA = "0x186895270", Slot = "64")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x68920D0", Offset = "0x68910D0", VA = "0x1868920D0", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public bool BPKCKECFMIF
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x6893640", Offset = "0x6892640", VA = "0x186893640", Slot = "66")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x68948E0", Offset = "0x68938E0", VA = "0x1868948E0", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public HLEHOHIHLOC EDJEBEDGABJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x6893280", Offset = "0x6892280", VA = "0x186893280", Slot = "68")]
		get
		{
			return default(HLEHOHIHLOC);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x68917D0", Offset = "0x68907D0", VA = "0x1868917D0", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public bool EIEMCPKOECE
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x68905B0", Offset = "0x688F5B0", VA = "0x1868905B0", Slot = "70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public Transform ADFIPMCFPOO
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x6893470", Offset = "0x6892470", VA = "0x186893470", Slot = "71")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public Vector3 MBMPBKDBNKA
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x6891890", Offset = "0x6890890", VA = "0x186891890", Slot = "72")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x6895630", Offset = "0x6894630", VA = "0x186895630", Slot = "73")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public float NHENDHLPPAI
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x6893EE0", Offset = "0x6892EE0", VA = "0x186893EE0", Slot = "74")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x68907B0", Offset = "0x688F7B0", VA = "0x1868907B0", Slot = "75")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public float LOCPNBPMDDF
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x68948C0", Offset = "0x68938C0", VA = "0x1868948C0", Slot = "76")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x68961E0", Offset = "0x68951E0", VA = "0x1868961E0", Slot = "77")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public Quaternion LAKOFGKCADA
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x68909C0", Offset = "0x688F9C0", VA = "0x1868909C0", Slot = "78")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x68916E0", Offset = "0x68906E0", VA = "0x1868916E0", Slot = "79")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public Vector3 OBJFNILBNAE
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x6894990", Offset = "0x6893990", VA = "0x186894990", Slot = "80")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x6894580", Offset = "0x6893580", VA = "0x186894580", Slot = "81")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public Quaternion KFGIAIMBKPH
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x6890770", Offset = "0x688F770", VA = "0x186890770", Slot = "82")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x6891FD0", Offset = "0x6890FD0", VA = "0x186891FD0", Slot = "83")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public RigidbodyConstraints CHMNFEIOEOL
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x6890E50", Offset = "0x688FE50", VA = "0x186890E50", Slot = "84")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x6894340", Offset = "0x6893340", VA = "0x186894340", Slot = "85")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public bool KJNJAAONODH
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x68927A0", Offset = "0x68917A0", VA = "0x1868927A0", Slot = "86")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x68944C0", Offset = "0x68934C0", VA = "0x1868944C0", Slot = "87")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public CollisionDetectionMode NDGMOPBCDFL
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x6891B70", Offset = "0x6890B70", VA = "0x186891B70", Slot = "88")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x6892310", Offset = "0x6891310", VA = "0x186892310", Slot = "89")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public bool MBCGJIMNDLB
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x6891390", Offset = "0x6890390", VA = "0x186891390", Slot = "140")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public bool AJCGGKDIPDC
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x6895DF0", Offset = "0x6894DF0", VA = "0x186895DF0", Slot = "90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event DGOFPGGNFJP JFHNFKPPMEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x6896050", Offset = "0x6895050", VA = "0x186896050", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x68930A0", Offset = "0x68920A0", VA = "0x1868930A0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event DGOFPGGNFJP HMPCCEAHOEA
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x6890C60", Offset = "0x688FC60", VA = "0x186890C60", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x6892A30", Offset = "0x6891A30", VA = "0x186892A30", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event CBDBCCOAADF HCLIALJDDKI
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x6890600", Offset = "0x688F600", VA = "0x186890600", Slot = "18")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x6893100", Offset = "0x6892100", VA = "0x186893100", Slot = "19")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event DGOFPGGNFJP KIOKNGMJMPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x68964F0", Offset = "0x68954F0", VA = "0x1868964F0", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x6890AC0", Offset = "0x688FAC0", VA = "0x186890AC0", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event DGOFPGGNFJP MDPNGGMBOHD
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x6891E60", Offset = "0x6890E60", VA = "0x186891E60", Slot = "14")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x6895BB0", Offset = "0x6894BB0", VA = "0x186895BB0", Slot = "15")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event DGOFPGGNFJP ANNJEHCBGGA
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x68955D0", Offset = "0x68945D0", VA = "0x1868955D0", Slot = "16")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x6891830", Offset = "0x6890830", VA = "0x186891830", Slot = "17")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	public event Action<DCFIIAFEJOH, DCFIIAFEJOH> IFLHJOAAPEF
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x6894C10", Offset = "0x6893C10", VA = "0x186894C10", Slot = "20")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x6894A40", Offset = "0x6893A40", VA = "0x186894A40", Slot = "21")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event DGOFPGGNFJP JLKABBMECML
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x6890C00", Offset = "0x688FC00", VA = "0x186890C00", Slot = "12")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x6894C70", Offset = "0x6893C70", VA = "0x186894C70", Slot = "13")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event DGOFPGGNFJP GFDECECHNDK
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x6891A70", Offset = "0x6890A70", VA = "0x186891A70", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x6893B00", Offset = "0x6892B00", VA = "0x186893B00", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x6896590", Offset = "0x6895590", VA = "0x186896590")]
	public JJBHMLOENNP(GameObject HOHLOJNOGCD, RigidbodyEx PCNOHKBBPGE, KKEBIBJADNL PGDDBCEFICD, [In] KGDPENLDKCN GPKMLHOONCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x68945D0", Offset = "0x68935D0", VA = "0x1868945D0", Slot = "136")]
	protected virtual void LNMEDKNACAK(KKEBIBJADNL PGDDBCEFICD, KGDPENLDKCN GPKMLHOONCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x6891BC0", Offset = "0x6890BC0", VA = "0x186891BC0", Slot = "137")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x6893F00", Offset = "0x6892F00", VA = "0x186893F00", Slot = "91")]
	public void KLABGHMFFPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x68915B0", Offset = "0x68905B0", VA = "0x1868915B0", Slot = "92")]
	public void IFFBACPBNDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x6894FF0", Offset = "0x6893FF0", VA = "0x186894FF0", Slot = "93")]
	public void NHILPMPKHGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x6892980", Offset = "0x6891980", VA = "0x186892980")]
	private void FMNLHEPNJBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x6893E60", Offset = "0x6892E60", VA = "0x186893E60", Slot = "30")]
	public BOJDJCGCFMG KHDHHNMCMKL(int GPEHCABDGEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x6895740", Offset = "0x6894740", VA = "0x186895740", Slot = "95")]
	public void OEOFJMNAFOJ(BOJDJCGCFMG LDGMLLMKHLF, bool MKBGEMOIAJC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x6891C90", Offset = "0x6890C90", VA = "0x186891C90", Slot = "96")]
	public void EBLINJOMMLD(object KONODCHOCOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x68927F0", Offset = "0x68917F0", VA = "0x1868927F0", Slot = "97")]
	public void FIFANNIAEBO(object KONODCHOCOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x6895CF0", Offset = "0x6894CF0", VA = "0x186895CF0", Slot = "98")]
	public Vector3 PCDPBCIHPMF(Vector3 EHDONMPNJKF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x6893D60", Offset = "0x6892D60", VA = "0x186893D60", Slot = "99")]
	public Vector3 KFDJIPPCPAC(Vector3 EALHJCELKMC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x68915B0", Offset = "0x68905B0", VA = "0x1868915B0", Slot = "100")]
	public void CNBLDBEPIJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x6894F30", Offset = "0x6893F30", VA = "0x186894F30", Slot = "101")]
	public void NBFLDFHDMAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x68956F0", Offset = "0x68946F0", VA = "0x1868956F0", Slot = "102")]
	public void OCMGPNCLHDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x68940A0", Offset = "0x68930A0", VA = "0x1868940A0", Slot = "103")]
	public void LAALPFGIDKP(Vector3 GEFAOGEPMNH, Vector3 DHJFGPMFDHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x68953F0", Offset = "0x68943F0", VA = "0x1868953F0", Slot = "104")]
	public void NMHNLHDMDNG(Vector3 AOILAALLFEL, Vector3 KMLMDMHBLNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x6891600", Offset = "0x6890600", VA = "0x186891600", Slot = "105")]
	public void DBGNEKAAJMN(Vector3 LJLBLGLLKLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x6892370", Offset = "0x6891370", VA = "0x186892370", Slot = "106")]
	public void FEBHEIBFEHM(MEKFJPELAOM MMJDJKINIEI, Vector3 JJCDAOEEONM, float APHKJGDFGHN, float FPIBBDFFLEM = 8f, float DMLBKDPKECC = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x6896450", Offset = "0x6895450", VA = "0x186896450", Slot = "107")]
	public void PPJIHGGOEEG(FNFFNOPGDAE BIGJKOCLOKM, Vector3 PKJJGHKMLBD, float JGGJJDNDNCC = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x6891EC0", Offset = "0x6890EC0", VA = "0x186891EC0", Slot = "108")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void ECMFHAEHEHN(FNFFNOPGDAE BIGJKOCLOKM, Vector3 CKCOAEGKOKA, float GPACIKBBBFF = 7f, float KCOELLNBOPI = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x6890820", Offset = "0x688F820", VA = "0x186890820", Slot = "109")]
	public Vector3 AHHIJEOIOIL(Vector3 LDGMLLMKHLF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x6893480", Offset = "0x6892480", VA = "0x186893480", Slot = "110")]
	public Vector3 IAIOKFDJFOI(Vector3 LDGMLLMKHLF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x68954E0", Offset = "0x68944E0", VA = "0x1868954E0", Slot = "111")]
	public void NNABBBGCDDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x6893320", Offset = "0x6892320", VA = "0x186893320", Slot = "112")]
	public void HNFKCCCCKML(BOJDJCGCFMG GBOPLKAOBPK, object KONODCHOCOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x68963F0", Offset = "0x68953F0", VA = "0x1868963F0", Slot = "113")]
	public void PNIGGPGGNJB(object KONODCHOCOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x6890EA0", Offset = "0x688FEA0", VA = "0x186890EA0", Slot = "61")]
	public void CACBNOKEGDD((Quaternion rot, Vector3 moments) AFGCIFLCAMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x6891B20", Offset = "0x6890B20", VA = "0x186891B20", Slot = "114")]
	public void DNPAFIBIPED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x6894B00", Offset = "0x6893B00", VA = "0x186894B00", Slot = "115")]
	public void MEMEKBFDJIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x68960B0", Offset = "0x68950B0", VA = "0x1868960B0", Slot = "116")]
	public void PGAPFLHOLLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x6892850", Offset = "0x6891850", VA = "0x186892850", Slot = "117")]
	public bool FKBLMGOIBCC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x6894470", Offset = "0x6893470", VA = "0x186894470", Slot = "94")]
	public void LJLGIJFOGKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x68932D0", Offset = "0x68922D0", VA = "0x1868932D0", Slot = "118")]
	public void HMJJMGLGKAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x6894520", Offset = "0x6893520", VA = "0x186894520", Slot = "119")]
	public void LKKLCJKCPGN(object KONODCHOCOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x68937C0", Offset = "0x68927C0", VA = "0x1868937C0", Slot = "120")]
	public void ILMFNMCMDMF(object KONODCHOCOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x6894F80", Offset = "0x6893F80", VA = "0x186894F80", Slot = "121")]
	public void NBOPJNDAAAI(object KONODCHOCOG, bool DALNOEDDEKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x6894D30", Offset = "0x6893D30", VA = "0x186894D30", Slot = "122")]
	public void MPFPILCPKOL(Vector3 CMEGFIPCBCA, Quaternion DHACMNNFPAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x6893BB0", Offset = "0x6892BB0", VA = "0x186893BB0", Slot = "123")]
	public void KBLCFEOGFLA(Vector3 NIPGJDJBIOA, Quaternion GHLENEHONEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x6892A90", Offset = "0x6891A90", VA = "0x186892A90", Slot = "124")]
	public bool FOBJJPOFAAC(float FOHBFABOGNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x6893D00", Offset = "0x6892D00", VA = "0x186893D00", Slot = "125")]
	public void KEBJJEPGHJJ(object KONODCHOCOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x6894AA0", Offset = "0x6893AA0", VA = "0x186894AA0", Slot = "126")]
	public void MCIDAFBPLMF(object KONODCHOCOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x6892D40", Offset = "0x6891D40", VA = "0x186892D40", Slot = "127")]
	public void GBIEFGOKLIL(object KONODCHOCOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x68935E0", Offset = "0x68925E0", VA = "0x1868935E0", Slot = "128")]
	public void IDJCOCMHAEG(object KONODCHOCOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x6896100", Offset = "0x6895100", VA = "0x186896100", Slot = "129")]
	public void PGKGPOKEDFA(Vector3 CLNMAALIOEC, ForceMode LBNNCFGJHGI = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x68939A0", Offset = "0x68929A0", VA = "0x1868939A0", Slot = "130")]
	public void JDKDMOJNKJF(Vector3 CLNMAALIOEC, Vector3 BJIKBOECFPB, ForceMode LBNNCFGJHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x6895F70", Offset = "0x6894F70", VA = "0x186895F70", Slot = "131")]
	public void PFKDPNCLGPF(Vector3 KAPPHDNKKED, ForceMode LBNNCFGJHGI = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x6892EF0", Offset = "0x6891EF0", VA = "0x186892EF0", Slot = "132")]
	public void HDFKIGIDKIK(Vector3 KAPPHDNKKED, ForceMode LBNNCFGJHGI = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x6895530", Offset = "0x6894530", VA = "0x186895530", Slot = "133")]
	public bool NOBMCNKALEC(Vector3 PFFNCAKFCDH, [Out] RaycastHit LABCFOAKNEI, float MPDLEMGFFNF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x6892EA0", Offset = "0x6891EA0", VA = "0x186892EA0", Slot = "134")]
	public void GPBBJKIHELB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x6896550", Offset = "0x6895550", VA = "0x186896550", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x68931B0", Offset = "0x68921B0", VA = "0x1868931B0")]
	private void HLCHOLBHAJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x6890660", Offset = "0x688F660", VA = "0x186890660")]
	private void AEJIPIKHOEL(BOJDJCGCFMG NNHBJFPLAAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x6892130", Offset = "0x6891130", VA = "0x186892130")]
	private void FBHOHHLCKFP(BOJDJCGCFMG NNHBJFPLAAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x6896340", Offset = "0x6895340", VA = "0x186896340")]
	private void PLCFMGHAGIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x6892DA0", Offset = "0x6891DA0", VA = "0x186892DA0")]
	private void GOHKKLGAHHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x68950F0", Offset = "0x68940F0", VA = "0x1868950F0")]
	private void NJNEIKPEBDJ(BOJDJCGCFMG MPEJBEONEKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x68943A0", Offset = "0x68933A0", VA = "0x1868943A0")]
	private void LFCNFELFJDK(BOJDJCGCFMG NNHBJFPLAAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x6894190", Offset = "0x6893190", VA = "0x186894190")]
	private void LCOGPJFPGFK(BOJDJCGCFMG NNHBJFPLAAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x6891CF0", Offset = "0x6890CF0", VA = "0x186891CF0")]
	private void EBMEJMINDKE(KMOJNPOCKBC NNHBJFPLAAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x6890FD0", Offset = "0x688FFD0", VA = "0x186890FD0", Slot = "141")]
	protected virtual void CGLIEAEFFDM(KMOJNPOCKBC IHACPEDFDJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x68957B0", Offset = "0x68947B0", VA = "0x1868957B0")]
	protected void OHPFALFKKFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x6892430", Offset = "0x6891430", VA = "0x186892430")]
	protected void FGBDLAMHJGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x6890CC0", Offset = "0x688FCC0", VA = "0x186890CC0", Slot = "142")]
	protected virtual IDisposable BNLGFFHLPEC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal static class CADDGLEFKKC
{
	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x6883460", Offset = "0x6882460", VA = "0x186883460")]
	public static BOJDJCGCFMG PCMEMBMMFBE(this BOJDJCGCFMG IHACPEDFDJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x68833E0", Offset = "0x68823E0", VA = "0x1868833E0")]
	public static bool PAOAHBMIBJH(this BOJDJCGCFMG IHACPEDFDJO, BOJDJCGCFMG HBLGGCLJPGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x68832F0", Offset = "0x68822F0", VA = "0x1868832F0")]
	public static bool JKLMCEDEDDB(this BOJDJCGCFMG IHACPEDFDJO, BOJDJCGCFMG MKKHDDGHMMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x68832A0", Offset = "0x68822A0", VA = "0x1868832A0")]
	public static KMOJNPOCKBC FDJGCMDKLAI(this BOJDJCGCFMG OFFMGNOKEOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x6883370", Offset = "0x6882370", VA = "0x186883370")]
	public static JJBHMLOENNP KPBINOIDFEP(this BOJDJCGCFMG OFFMGNOKEOO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class MNCFNBPODDA : LBNABDEFMOC
{
	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x6897AC0", Offset = "0x6896AC0", VA = "0x186897AC0", Slot = "19")]
	public BOJDJCGCFMG KMIOFGJIBLJ(RigidbodyEx IHACPEDFDJO, KGDPENLDKCN GPKMLHOONCL, KKEBIBJADNL PGDDBCEFICD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x7C06D0", Offset = "0x7BF6D0", VA = "0x1807C06D0", Slot = "4")]
	public CFAGADDOLCN DHODPCBCEMO(BOJDJCGCFMG OFFMGNOKEOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x7C06D0", Offset = "0x7BF6D0", VA = "0x1807C06D0", Slot = "5")]
	public GIBJNCAOGPN JHDOEFMKNIL(BOJDJCGCFMG OFFMGNOKEOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x7C06D0", Offset = "0x7BF6D0", VA = "0x1807C06D0", Slot = "6")]
	public AGLILLCNOIA BDEIELGLHDF(BOJDJCGCFMG OFFMGNOKEOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x7C06D0", Offset = "0x7BF6D0", VA = "0x1807C06D0", Slot = "7")]
	public MMCFELEGMIA KAIBDNDEDOA(BOJDJCGCFMG OFFMGNOKEOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x7C06D0", Offset = "0x7BF6D0", VA = "0x1807C06D0", Slot = "8")]
	public PCAPEOIGBNK BIDOJCDIKFG(BOJDJCGCFMG OFFMGNOKEOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x7C06D0", Offset = "0x7BF6D0", VA = "0x1807C06D0", Slot = "9")]
	public ACAKANMOKAE OAPFLJLHBFH(BOJDJCGCFMG OFFMGNOKEOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x7C06D0", Offset = "0x7BF6D0", VA = "0x1807C06D0", Slot = "10")]
	public KDMCCJIINBG DNNCNBBMAFC(BOJDJCGCFMG OFFMGNOKEOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x7C06D0", Offset = "0x7BF6D0", VA = "0x1807C06D0", Slot = "11")]
	public HLGBPGDLDIH DOHKCCLPALM(BOJDJCGCFMG OFFMGNOKEOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x7C06D0", Offset = "0x7BF6D0", VA = "0x1807C06D0", Slot = "12")]
	public HABJELOAKJM GPEGODBMNMH(BOJDJCGCFMG OFFMGNOKEOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x7C06D0", Offset = "0x7BF6D0", VA = "0x1807C06D0", Slot = "13")]
	public FFLPPNLELDE ENEBJPAENOF(BOJDJCGCFMG OFFMGNOKEOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x7C06D0", Offset = "0x7BF6D0", VA = "0x1807C06D0")]
	public NIOEOOMBGLD KJDEAPKNBCH(BOJDJCGCFMG OFFMGNOKEOO, [In] KGDPENLDKCN GPKMLHOONCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x7C06D0", Offset = "0x7BF6D0", VA = "0x1807C06D0")]
	public LOJNGOGILDG HFHLMPPGBAL(BOJDJCGCFMG OFFMGNOKEOO, [In] KGDPENLDKCN GPKMLHOONCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x7C06D0", Offset = "0x7BF6D0", VA = "0x1807C06D0")]
	public HFLKLNMIGEN BPEGIABJEBE(BOJDJCGCFMG OFFMGNOKEOO, [In] KGDPENLDKCN GPKMLHOONCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x7C06D0", Offset = "0x7BF6D0", VA = "0x1807C06D0")]
	public LGCIGMPCLMM BOCIKOOGPAL(BOJDJCGCFMG OFFMGNOKEOO, [In] KGDPENLDKCN GPKMLHOONCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x7C06D0", Offset = "0x7BF6D0", VA = "0x1807C06D0")]
	public MNJBAMCMDMO BHMPLPMGGBB(BOJDJCGCFMG OFFMGNOKEOO, [In] KGDPENLDKCN GPKMLHOONCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
	public MNCFNBPODDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x7C06D0", Offset = "0x7BF6D0", VA = "0x1807C06D0", Slot = "14")]
	private NIOEOOMBGLD MBMFAPCGHBL(BOJDJCGCFMG OFFMGNOKEOO, [In] KGDPENLDKCN GPKMLHOONCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x7C06D0", Offset = "0x7BF6D0", VA = "0x1807C06D0", Slot = "15")]
	private LOJNGOGILDG IJMAMFKBKDK(BOJDJCGCFMG OFFMGNOKEOO, [In] KGDPENLDKCN GPKMLHOONCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x7C06D0", Offset = "0x7BF6D0", VA = "0x1807C06D0", Slot = "16")]
	private HFLKLNMIGEN MDCANGNCAKJ(BOJDJCGCFMG OFFMGNOKEOO, [In] KGDPENLDKCN GPKMLHOONCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x7C06D0", Offset = "0x7BF6D0", VA = "0x1807C06D0", Slot = "17")]
	private LGCIGMPCLMM CPJCOBPKGBG(BOJDJCGCFMG OFFMGNOKEOO, [In] KGDPENLDKCN GPKMLHOONCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x7C06D0", Offset = "0x7BF6D0", VA = "0x1807C06D0", Slot = "18")]
	private MNJBAMCMDMO JMDFFICDEKE(BOJDJCGCFMG OFFMGNOKEOO, [In] KGDPENLDKCN GPKMLHOONCL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[KGDCKDGHHEL(typeof(LBNABDEFMOC), new string[] { })]
public class BHIACHCBIOD : LBNABDEFMOC, IDCMJKJGJOM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private readonly LBNABDEFMOC HJLKJCEIFCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly LBNABDEFMOC KAGECFGHMEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private PGLBABFJBHF HBDJFLKKDBI;

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	private LBNABDEFMOC MNNHLHGGHCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x68830F0", Offset = "0x68820F0", VA = "0x1868830F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x6882DD0", Offset = "0x6881DD0", VA = "0x186882DD0", Slot = "20")]
	public void InitReferences(DHADIMIDLEJ JIMAIACHILI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x6882A00", Offset = "0x6881A00", VA = "0x186882A00", Slot = "4")]
	public CFAGADDOLCN DHODPCBCEMO(BOJDJCGCFMG OFFMGNOKEOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x6882E20", Offset = "0x6881E20", VA = "0x186882E20", Slot = "5")]
	public GIBJNCAOGPN JHDOEFMKNIL(BOJDJCGCFMG OFFMGNOKEOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x68826B0", Offset = "0x68816B0", VA = "0x1868826B0", Slot = "6")]
	public AGLILLCNOIA BDEIELGLHDF(BOJDJCGCFMG OFFMGNOKEOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x6882EC0", Offset = "0x6881EC0", VA = "0x186882EC0", Slot = "7")]
	public MMCFELEGMIA KAIBDNDEDOA(BOJDJCGCFMG OFFMGNOKEOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x6882800", Offset = "0x6881800", VA = "0x186882800", Slot = "8")]
	public PCAPEOIGBNK BIDOJCDIKFG(BOJDJCGCFMG OFFMGNOKEOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x6883150", Offset = "0x6882150", VA = "0x186883150", Slot = "9")]
	public ACAKANMOKAE OAPFLJLHBFH(BOJDJCGCFMG OFFMGNOKEOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x6882AA0", Offset = "0x6881AA0", VA = "0x186882AA0", Slot = "10")]
	public KDMCCJIINBG DNNCNBBMAFC(BOJDJCGCFMG OFFMGNOKEOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x6882B40", Offset = "0x6881B40", VA = "0x186882B40", Slot = "11")]
	public HLGBPGDLDIH DOHKCCLPALM(BOJDJCGCFMG OFFMGNOKEOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x6882C80", Offset = "0x6881C80", VA = "0x186882C80", Slot = "12")]
	public HABJELOAKJM GPEGODBMNMH(BOJDJCGCFMG OFFMGNOKEOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x6882BE0", Offset = "0x6881BE0", VA = "0x186882BE0", Slot = "13")]
	public FFLPPNLELDE ENEBJPAENOF(BOJDJCGCFMG OFFMGNOKEOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x6882F60", Offset = "0x6881F60", VA = "0x186882F60")]
	public NIOEOOMBGLD KJDEAPKNBCH(BOJDJCGCFMG OFFMGNOKEOO, [In] KGDPENLDKCN GPKMLHOONCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x6882D20", Offset = "0x6881D20", VA = "0x186882D20")]
	public LOJNGOGILDG HFHLMPPGBAL(BOJDJCGCFMG OFFMGNOKEOO, [In] KGDPENLDKCN GPKMLHOONCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x6882950", Offset = "0x6881950", VA = "0x186882950")]
	public HFLKLNMIGEN BPEGIABJEBE(BOJDJCGCFMG OFFMGNOKEOO, [In] KGDPENLDKCN GPKMLHOONCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x68828A0", Offset = "0x68818A0", VA = "0x1868828A0")]
	public LGCIGMPCLMM BOCIKOOGPAL(BOJDJCGCFMG OFFMGNOKEOO, [In] KGDPENLDKCN GPKMLHOONCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x6882750", Offset = "0x6881750", VA = "0x186882750")]
	public MNJBAMCMDMO BHMPLPMGGBB(BOJDJCGCFMG OFFMGNOKEOO, [In] KGDPENLDKCN GPKMLHOONCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x6883010", Offset = "0x6882010", VA = "0x186883010", Slot = "19")]
	public BOJDJCGCFMG KMIOFGJIBLJ(RigidbodyEx IHACPEDFDJO, KGDPENLDKCN GPKMLHOONCL, KKEBIBJADNL PGDDBCEFICD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x68831F0", Offset = "0x68821F0", VA = "0x1868831F0")]
	public BHIACHCBIOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x6882F60", Offset = "0x6881F60", VA = "0x186882F60", Slot = "14")]
	private NIOEOOMBGLD MBMFAPCGHBL(BOJDJCGCFMG OFFMGNOKEOO, [In] KGDPENLDKCN GPKMLHOONCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x6882D20", Offset = "0x6881D20", VA = "0x186882D20", Slot = "15")]
	private LOJNGOGILDG IJMAMFKBKDK(BOJDJCGCFMG OFFMGNOKEOO, [In] KGDPENLDKCN GPKMLHOONCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x6882950", Offset = "0x6881950", VA = "0x186882950", Slot = "16")]
	private HFLKLNMIGEN MDCANGNCAKJ(BOJDJCGCFMG OFFMGNOKEOO, [In] KGDPENLDKCN GPKMLHOONCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x68828A0", Offset = "0x68818A0", VA = "0x1868828A0", Slot = "17")]
	private LGCIGMPCLMM CPJCOBPKGBG(BOJDJCGCFMG OFFMGNOKEOO, [In] KGDPENLDKCN GPKMLHOONCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x6882750", Offset = "0x6881750", VA = "0x186882750", Slot = "18")]
	private MNJBAMCMDMO JMDFFICDEKE(BOJDJCGCFMG OFFMGNOKEOO, [In] KGDPENLDKCN GPKMLHOONCL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface ABAJFJLBMCJ : CFAGADDOLCN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JGINDGHHPNF(BOJDJCGCFMG IHACPEDFDJO);

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EHCKGLIGMOF(BOJDJCGCFMG IHACPEDFDJO);

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LECHGLGCMIE(BOJDJCGCFMG MPEJBEONEKJ);

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GECPGLNIJPK(BOJDJCGCFMG MPEJBEONEKJ);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface ODIKHJBBLFI : AGLILLCNOIA
{
	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	GFHPGBHCKKB<BOJDJCGCFMG> FNEMFMCKMOE
	{
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	BOJDJCGCFMG AMEAHGLOGKE
	{
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface CDGGBNDAAGE : LGCIGMPCLMM
{
	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	(float, Vector3) AINADFMJBNE(Rigidbody MLFHDMLAAEP);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface MBONELPFGCM : LOJNGOGILDG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	PhotonView CBJMADCOBMA
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal sealed class OKJCAPEDLOG : HABJELOAKJM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly JJBHMLOENNP IHACPEDFDJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private CollisionDetectionMode LEHMFANBACM;

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	private Rigidbody FDIPIHCLHPM
	{
		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x6888320", Offset = "0x6887320", VA = "0x186888320")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public CollisionDetectionMode NDGMOPBCDFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x6898970", Offset = "0x6897970", VA = "0x186898970", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x6898A80", Offset = "0x6897A80", VA = "0x186898A80", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x6888B70", Offset = "0x6887B70", VA = "0x186888B70")]
	public OKJCAPEDLOG(BOJDJCGCFMG IHACPEDFDJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x6898B00", Offset = "0x6897B00", VA = "0x186898B00", Slot = "6")]
	public void KLABGHMFFPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x6898D80", Offset = "0x6897D80", VA = "0x186898D80", Slot = "9")]
	public void OKKIHGNIDLB(Rigidbody PEFEIMLIJIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x6898D70", Offset = "0x6897D70", VA = "0x186898D70", Slot = "7")]
	public void OKEJALEGAKA(bool POEHINHMGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x6898AF0", Offset = "0x6897AF0", VA = "0x186898AF0", Slot = "8")]
	public void HOLPMFOJGKP(bool POEHINHMGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x6898C10", Offset = "0x6897C10", VA = "0x186898C10", Slot = "10")]
	public bool NOBMCNKALEC(Vector3 PFFNCAKFCDH, [Out] RaycastHit LABCFOAKNEI, float MPDLEMGFFNF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x6898850", Offset = "0x6897850", VA = "0x186898850")]
	private void BJMDEFPHKFN(bool POEHINHMGLP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class FKILJGCLMMF : ACAKANMOKAE, IDisposable, DCPODHBBNDM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly JJBHMLOENNP IHACPEDFDJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private HLEHOHIHLOC BODMFIHOOJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private NKHDPGBKMGF CEDPKJDFCKB;

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public HLEHOHIHLOC EDJEBEDGABJ
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x688B380", Offset = "0x688A380", VA = "0x18688B380", Slot = "6")]
		get
		{
			return default(HLEHOHIHLOC);
		}
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x688B260", Offset = "0x688A260", VA = "0x18688B260", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	private Transform FLKBPHGAIKA
	{
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x688B4C0", Offset = "0x688A4C0", VA = "0x18688B4C0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	public event Action<DCFIIAFEJOH, DCFIIAFEJOH> IFLHJOAAPEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x688B800", Offset = "0x688A800", VA = "0x18688B800", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x688B750", Offset = "0x688A750", VA = "0x18688B750", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x688B8B0", Offset = "0x688A8B0", VA = "0x18688B8B0")]
	public FKILJGCLMMF(BOJDJCGCFMG IHACPEDFDJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x688B4E0", Offset = "0x688A4E0", VA = "0x18688B4E0", Slot = "8")]
	public void KLABGHMFFPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x688B330", Offset = "0x688A330", VA = "0x18688B330", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x82DD20", Offset = "0x82CD20", VA = "0x18082DD20", Slot = "11")]
	private void NJEMNPEDEBP(DCFIIAFEJOH DLKCHFLMBPI, DCFIIAFEJOH MDINEFDHNJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0", Slot = "12")]
	private void JCIJKHFJFFP(bool DMOGIMEKMMF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class LPAIGGIGIAE : LBNABDEFMOC
{
	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x6896F40", Offset = "0x6895F40", VA = "0x186896F40", Slot = "4")]
	public CFAGADDOLCN DHODPCBCEMO(BOJDJCGCFMG OFFMGNOKEOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x6897520", Offset = "0x6896520", VA = "0x186897520", Slot = "5")]
	public GIBJNCAOGPN JHDOEFMKNIL(BOJDJCGCFMG OFFMGNOKEOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x68969A0", Offset = "0x68959A0", VA = "0x1868969A0", Slot = "6")]
	public AGLILLCNOIA BDEIELGLHDF(BOJDJCGCFMG OFFMGNOKEOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x6897640", Offset = "0x6896640", VA = "0x186897640", Slot = "7")]
	public MMCFELEGMIA KAIBDNDEDOA(BOJDJCGCFMG OFFMGNOKEOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x6896BB0", Offset = "0x6895BB0", VA = "0x186896BB0", Slot = "8")]
	public PCAPEOIGBNK BIDOJCDIKFG(BOJDJCGCFMG OFFMGNOKEOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x6897920", Offset = "0x6896920", VA = "0x186897920", Slot = "9")]
	public ACAKANMOKAE OAPFLJLHBFH(BOJDJCGCFMG OFFMGNOKEOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x6897030", Offset = "0x6896030", VA = "0x186897030", Slot = "10")]
	public KDMCCJIINBG DNNCNBBMAFC(BOJDJCGCFMG OFFMGNOKEOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x6897150", Offset = "0x6896150", VA = "0x186897150", Slot = "11")]
	public HLGBPGDLDIH DOHKCCLPALM(BOJDJCGCFMG OFFMGNOKEOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x68972D0", Offset = "0x68962D0", VA = "0x1868972D0", Slot = "12")]
	public HABJELOAKJM GPEGODBMNMH(BOJDJCGCFMG OFFMGNOKEOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x6897210", Offset = "0x6896210", VA = "0x186897210", Slot = "13")]
	public FFLPPNLELDE ENEBJPAENOF(BOJDJCGCFMG OFFMGNOKEOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x68976C0", Offset = "0x68966C0", VA = "0x1868976C0")]
	public NIOEOOMBGLD KJDEAPKNBCH(BOJDJCGCFMG OFFMGNOKEOO, [In] KGDPENLDKCN GPKMLHOONCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x6897390", Offset = "0x6896390", VA = "0x186897390")]
	public LOJNGOGILDG HFHLMPPGBAL(BOJDJCGCFMG OFFMGNOKEOO, [In] KGDPENLDKCN GPKMLHOONCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x6896E10", Offset = "0x6895E10", VA = "0x186896E10")]
	public HFLKLNMIGEN BPEGIABJEBE(BOJDJCGCFMG OFFMGNOKEOO, [In] KGDPENLDKCN GPKMLHOONCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x6896C80", Offset = "0x6895C80", VA = "0x186896C80")]
	public LGCIGMPCLMM BOCIKOOGPAL(BOJDJCGCFMG OFFMGNOKEOO, [In] KGDPENLDKCN GPKMLHOONCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x6896AD0", Offset = "0x6895AD0", VA = "0x186896AD0")]
	public MNJBAMCMDMO BHMPLPMGGBB(BOJDJCGCFMG OFFMGNOKEOO, [In] KGDPENLDKCN GPKMLHOONCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x6897800", Offset = "0x6896800", VA = "0x186897800", Slot = "19")]
	public BOJDJCGCFMG KMIOFGJIBLJ(RigidbodyEx IHACPEDFDJO, KGDPENLDKCN GPKMLHOONCL, KKEBIBJADNL PGDDBCEFICD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
	public LPAIGGIGIAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x68976C0", Offset = "0x68966C0", VA = "0x1868976C0", Slot = "14")]
	private NIOEOOMBGLD MBMFAPCGHBL(BOJDJCGCFMG OFFMGNOKEOO, [In] KGDPENLDKCN GPKMLHOONCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x6897390", Offset = "0x6896390", VA = "0x186897390", Slot = "15")]
	private LOJNGOGILDG IJMAMFKBKDK(BOJDJCGCFMG OFFMGNOKEOO, [In] KGDPENLDKCN GPKMLHOONCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x6896E10", Offset = "0x6895E10", VA = "0x186896E10", Slot = "16")]
	private HFLKLNMIGEN MDCANGNCAKJ(BOJDJCGCFMG OFFMGNOKEOO, [In] KGDPENLDKCN GPKMLHOONCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x6896C80", Offset = "0x6895C80", VA = "0x186896C80", Slot = "17")]
	private LGCIGMPCLMM CPJCOBPKGBG(BOJDJCGCFMG OFFMGNOKEOO, [In] KGDPENLDKCN GPKMLHOONCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x6896AD0", Offset = "0x6895AD0", VA = "0x186896AD0", Slot = "18")]
	private MNJBAMCMDMO JMDFFICDEKE(BOJDJCGCFMG OFFMGNOKEOO, [In] KGDPENLDKCN GPKMLHOONCL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal sealed class DAICPAANGPC : HLGBPGDLDIH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly JJBHMLOENNP IHACPEDFDJO;

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	private Rigidbody FDIPIHCLHPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x6888320", Offset = "0x6887320", VA = "0x186888320")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	private bool EIEMCPKOECE
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x6887DB0", Offset = "0x6886DB0", VA = "0x186887DB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	private bool ABHAFFOKCAG
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x68885F0", Offset = "0x68875F0", VA = "0x1868885F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	private BOJDJCGCFMG MILAJCEOCBC
	{
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x6887E00", Offset = "0x6886E00", VA = "0x186887E00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x6888B70", Offset = "0x6887B70", VA = "0x186888B70")]
	public DAICPAANGPC(BOJDJCGCFMG IHACPEDFDJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x68887B0", Offset = "0x68877B0", VA = "0x1868887B0", Slot = "4")]
	public void PGKGPOKEDFA(Vector3 CLNMAALIOEC, ForceMode LBNNCFGJHGI = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x6888910", Offset = "0x6887910", VA = "0x186888910")]
	private void PPJKJOLEGJA(Vector3 CLNMAALIOEC, ForceMode LBNNCFGJHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x6888370", Offset = "0x6887370", VA = "0x186888370", Slot = "5")]
	public void JDKDMOJNKJF(Vector3 CLNMAALIOEC, Vector3 BJIKBOECFPB, ForceMode LBNNCFGJHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x6888650", Offset = "0x6887650", VA = "0x186888650", Slot = "6")]
	public void PFKDPNCLGPF(Vector3 KAPPHDNKKED, ForceMode LBNNCFGJHGI = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x6887E60", Offset = "0x6886E60", VA = "0x186887E60")]
	private void BIGHCLPFCBD(Vector3 KAPPHDNKKED, ForceMode LBNNCFGJHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x68880C0", Offset = "0x68870C0", VA = "0x1868880C0", Slot = "7")]
	public void HDFKIGIDKIK(Vector3 KAPPHDNKKED, ForceMode LBNNCFGJHGI = ForceMode.Force)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal sealed class KONODEPHLFP : FFLPPNLELDE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly JJBHMLOENNP IHACPEDFDJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private bool ABOANMONEBK;

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public bool BPKCKECFMIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x82BFE0", Offset = "0x82AFE0", VA = "0x18082BFE0", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x68967A0", Offset = "0x68957A0", VA = "0x1868967A0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x6888B70", Offset = "0x6887B70", VA = "0x186888B70")]
	public KONODEPHLFP(BOJDJCGCFMG IHACPEDFDJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x68968B0", Offset = "0x68958B0", VA = "0x1868968B0", Slot = "6")]
	public void OKKIHGNIDLB(Rigidbody PEFEIMLIJIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x6896730", Offset = "0x6895730", VA = "0x186896730", Slot = "7")]
	public void GEDDPLFBHFE(Rigidbody PEFEIMLIJIA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal sealed class COIKGKNGCGL : ABAJFJLBMCJ, CFAGADDOLCN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly BOJDJCGCFMG IHACPEDFDJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly List<BOJDJCGCFMG> BKDDKAEDABJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private BOJDJCGCFMG OPFDMIOAEHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private BOJDJCGCFMG NNHBJFPLAAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private Transform DIPJFNEBEHI;

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	private Transform EAHPGDBNGDI
	{
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x6886780", Offset = "0x6885780", VA = "0x186886780")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public BOJDJCGCFMG MILAJCEOCBC
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x7C7960", Offset = "0x7C6960", VA = "0x1807C7960", Slot = "28")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x6887CE0", Offset = "0x6886CE0", VA = "0x186887CE0", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public BOJDJCGCFMG NNCBLFAOELK
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x7C7980", Offset = "0x7C6980", VA = "0x1807C7980", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public IReadOnlyList<BOJDJCGCFMG> HACDLBFGDJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x7C7930", Offset = "0x7C6930", VA = "0x1807C7930", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000021")]
	public event DGOFPGGNFJP JFHNFKPPMEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x6887C40", Offset = "0x6886C40", VA = "0x186887C40", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x6886B00", Offset = "0x6885B00", VA = "0x186886B00", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000022")]
	public event DGOFPGGNFJP HMPCCEAHOEA
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x6886040", Offset = "0x6885040", VA = "0x186886040", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x68866E0", Offset = "0x68856E0", VA = "0x1868866E0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000023")]
	public event CBDBCCOAADF HCLIALJDDKI
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x6885F00", Offset = "0x6884F00", VA = "0x186885F00", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x6886BA0", Offset = "0x6885BA0", VA = "0x186886BA0", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000024")]
	public event Action PEOHKNNNIEC
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x6885FA0", Offset = "0x6884FA0", VA = "0x186885FA0", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x6887AF0", Offset = "0x6886AF0", VA = "0x186887AF0", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000025")]
	public event Action DBAMGFMINDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x6886310", Offset = "0x6885310", VA = "0x186886310", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x6887420", Offset = "0x6886420", VA = "0x186887420", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000026")]
	public event Action<BOJDJCGCFMG> JHAFEJOKEHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x6886C40", Offset = "0x6885C40", VA = "0x186886C40", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x68874C0", Offset = "0x68864C0", VA = "0x1868874C0", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000027")]
	public event Action<BOJDJCGCFMG> DDIBJFFGLNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x6886260", Offset = "0x6885260", VA = "0x186886260", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x68863B0", Offset = "0x68853B0", VA = "0x1868863B0", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000028")]
	public event Action BCKAFFBACME
	{
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x6886640", Offset = "0x6885640", VA = "0x186886640", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x6886A60", Offset = "0x6885A60", VA = "0x186886A60", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000029")]
	public event Action<BOJDJCGCFMG> INGIMJLHHOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x6887B90", Offset = "0x6886B90", VA = "0x186887B90", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x6886EE0", Offset = "0x6885EE0", VA = "0x186886EE0", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x6887CF0", Offset = "0x6886CF0", VA = "0x186887CF0")]
	public COIKGKNGCGL(BOJDJCGCFMG IHACPEDFDJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x6886460", Offset = "0x6885460", VA = "0x186886460", Slot = "31")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x6887570", Offset = "0x6886570", VA = "0x186887570", Slot = "30")]
	public void OEOFJMNAFOJ(BOJDJCGCFMG GFOFKCGAIPE, bool MKBGEMOIAJC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x68871B0", Offset = "0x68861B0", VA = "0x1868871B0", Slot = "6")]
	public void LECHGLGCMIE(BOJDJCGCFMG MPEJBEONEKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x68867E0", Offset = "0x68857E0", VA = "0x1868867E0", Slot = "7")]
	public void GECPGLNIJPK(BOJDJCGCFMG MPEJBEONEKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x6886F90", Offset = "0x6885F90", VA = "0x186886F90", Slot = "4")]
	public void JGINDGHHPNF(BOJDJCGCFMG IHACPEDFDJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x68865A0", Offset = "0x68855A0", VA = "0x1868865A0", Slot = "5")]
	public void EHCKGLIGMOF(BOJDJCGCFMG IHACPEDFDJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x6886500", Offset = "0x6885500", VA = "0x186886500")]
	private void EAJHPLDBJCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x68860E0", Offset = "0x68850E0", VA = "0x1868860E0")]
	private void BMBHABJPCCG(BOJDJCGCFMG MPEJBEONEKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x6886120", Offset = "0x6885120", VA = "0x186886120")]
	private void BMNJBILPBKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x6887080", Offset = "0x6886080", VA = "0x186887080")]
	private void LBGCLCCBJPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x6886DB0", Offset = "0x6885DB0", VA = "0x186886DB0")]
	private void HPMLFLBPJAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x6886CF0", Offset = "0x6885CF0", VA = "0x186886CF0")]
	[CompilerGenerated]
	private object HNJOCFCOMGO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal static class AGJDBKAENNH
{
	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x68825F0", Offset = "0x68815F0", VA = "0x1868825F0")]
	public static ABAJFJLBMCJ MLNDOKBLGCB(this BOJDJCGCFMG OFFMGNOKEOO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal sealed class DMOHHICBAKD : ODIKHJBBLFI, AGLILLCNOIA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly JJBHMLOENNP IHACPEDFDJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly GFHPGBHCKKB<BOJDJCGCFMG> GNIOCHKDAOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private bool LKAJHDJFGOA;

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public GFHPGBHCKKB<BOJDJCGCFMG> FNEMFMCKMOE
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x7C29D0", Offset = "0x7C19D0", VA = "0x1807C29D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public Vector3 NFNLBCAFKLM
	{
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x688A4F0", Offset = "0x68894F0", VA = "0x18688A4F0", Slot = "6")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public Vector3 OLPICLBCHEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x688A330", Offset = "0x6889330", VA = "0x18688A330", Slot = "7")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	private Vector3 HENBBEFCDFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x6889E50", Offset = "0x6888E50", VA = "0x186889E50")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public BOJDJCGCFMG AMEAHGLOGKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x688A520", Offset = "0x6889520", VA = "0x18688A520", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x688A9D0", Offset = "0x68899D0", VA = "0x18688A9D0")]
	public DMOHHICBAKD(BOJDJCGCFMG IHACPEDFDJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x688A5D0", Offset = "0x68895D0", VA = "0x18688A5D0", Slot = "8")]
	public void IHJKJOFDCEI(BOJDJCGCFMG NNHBJFPLAAA, object KONODCHOCOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x6889F40", Offset = "0x6888F40", VA = "0x186889F40", Slot = "9")]
	public void CIHLANBEHAM(object KONODCHOCOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x688A640", Offset = "0x6889640", VA = "0x18688A640")]
	private Vector3 JALMIHHKGIF()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x6889FA0", Offset = "0x6888FA0", VA = "0x186889FA0")]
	private void ECPHHBEKGFP(BOJDJCGCFMG BDLBBJKNHPG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal static class FOHBGNGIHLG
{
	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x688B940", Offset = "0x688A940", VA = "0x18688B940")]
	public static ODIKHJBBLFI IAINPLNLDEF(this BOJDJCGCFMG OFFMGNOKEOO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal sealed class CFGDLEFIIEJ : CDGGBNDAAGE, LGCIGMPCLMM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private readonly JJBHMLOENNP IHACPEDFDJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly OverridableVector3 FCDBGFFMOFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly OverridableVector3 BBBLGHEEJOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private float PNOIJOAKOEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private float PADHCFJLLNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private Vector3 CHMNBEACIEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private Vector3? FJMKIPCPEGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private Quaternion? GAGDFKFHNKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private bool KFGJFCAGDEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private bool KCDPJNKPFLK;

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public Vector3 AKGFLCJGLGG
	{
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0xBE7D10", Offset = "0xBE6D10", VA = "0x180BE7D10", Slot = "7")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x68854C0", Offset = "0x68844C0", VA = "0x1868854C0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public Vector3 ALFJLBFCNPA
	{
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x6884AD0", Offset = "0x6883AD0", VA = "0x186884AD0", Slot = "9")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public float JJJAFIFADHM
	{
		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x125CC40", Offset = "0x125BC40", VA = "0x18125CC40", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x68843A0", Offset = "0x68833A0", VA = "0x1868843A0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public float OBPCCJIKNGB
	{
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0xC77620", Offset = "0xC76620", VA = "0x180C77620", Slot = "11")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x6884D80", Offset = "0x6883D80", VA = "0x186884D80", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public Vector3 FMGJIJKKMJH
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x6885610", Offset = "0x6884610", VA = "0x186885610", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public Quaternion MGCGHGJEPIF
	{
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x68845A0", Offset = "0x68835A0", VA = "0x1868845A0", Slot = "14")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	private Rigidbody FDIPIHCLHPM
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x68857A0", Offset = "0x68847A0", VA = "0x1868857A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002A")]
	public event DGOFPGGNFJP KFAHGMNGGME
	{
		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x6885570", Offset = "0x6884570", VA = "0x186885570", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x68857F0", Offset = "0x68847F0", VA = "0x1868857F0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x6885DA0", Offset = "0x6884DA0", VA = "0x186885DA0")]
	public CFGDLEFIIEJ(BOJDJCGCFMG IHACPEDFDJO, [In] KGDPENLDKCN GPKMLHOONCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x6884BD0", Offset = "0x6883BD0", VA = "0x186884BD0", Slot = "17")]
	public void DNPAFIBIPED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x6885890", Offset = "0x6884890", VA = "0x186885890", Slot = "16")]
	public void MEMEKBFDJIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x6885B10", Offset = "0x6884B10", VA = "0x186885B10", Slot = "19")]
	public void OKKIHGNIDLB(Rigidbody PEFEIMLIJIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x6884E30", Offset = "0x6883E30", VA = "0x186884E30", Slot = "20")]
	public void GEDDPLFBHFE(Rigidbody PEFEIMLIJIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x6885BF0", Offset = "0x6884BF0", VA = "0x186885BF0", Slot = "18")]
	public void PGAPFLHOLLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x6885020", Offset = "0x6884020", VA = "0x186885020", Slot = "21")]
	public void GPBBJKIHELB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x68854C0", Offset = "0x68844C0", VA = "0x1868854C0")]
	private void HAJKIABENII(Vector3 LDGMLLMKHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x68844B0", Offset = "0x68834B0", VA = "0x1868844B0")]
	[Obsolete("This method is dangerous - the unity rigidbody is updated in a deferred manner and this world position may be stale")]
	private Vector3 APDNOMENBKE()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x68843A0", Offset = "0x68833A0", VA = "0x1868843A0")]
	private void OHIHKEAGOBK(float LDGMLLMKHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x6884D80", Offset = "0x6883D80", VA = "0x186884D80")]
	private void OICMHIHEGAC(float LDGMLLMKHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x6885970", Offset = "0x6884970", VA = "0x186885970")]
	private Vector3 NJJNNDCFCDH()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x6884720", Offset = "0x6883720", VA = "0x186884720", Slot = "15")]
	public void CACBNOKEGDD((Quaternion rot, Vector3 moments) AFGCIFLCAMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x6884950", Offset = "0x6883950", VA = "0x186884950")]
	private Quaternion CDPKJEPLHNJ()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x6883520", Offset = "0x6882520", VA = "0x186883520")]
	public void AINADFMJBNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x68835F0", Offset = "0x68825F0", VA = "0x1868835F0", Slot = "4")]
	public (float, Vector3) AINADFMJBNE(Rigidbody MLFHDMLAAEP)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal static class LFCBEHJJKJE
{
	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x68968E0", Offset = "0x68958E0", VA = "0x1868968E0")]
	public static CDGGBNDAAGE GEJMDNJLLGJ(this BOJDJCGCFMG OFFMGNOKEOO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal sealed class FENOJJPKMON : HFLKLNMIGEN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly JJBHMLOENNP IHACPEDFDJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private readonly EEABDCAPAGK NKCFANAPJIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private readonly KDOAGIGOPNE IIEIOLOGIHI;

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public bool KNDHACGGMGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0xDB0B30", Offset = "0xDAFB30", VA = "0x180DB0B30", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public KDOAGIGOPNE JPEPPDNFLFG
	{
		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x96ECB0", Offset = "0x96DCB0", VA = "0x18096ECB0", Slot = "11")]
		get
		{
			return default(KDOAGIGOPNE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x688B0F0", Offset = "0x688A0F0", VA = "0x18688B0F0")]
	public FENOJJPKMON(BOJDJCGCFMG IHACPEDFDJO, [In] KGDPENLDKCN GPKMLHOONCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x688AFB0", Offset = "0x6889FB0", VA = "0x18688AFB0", Slot = "4")]
	public void KLABGHMFFPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x688AB00", Offset = "0x6889B00", VA = "0x18688AB00")]
	private bool BJHJPKINCGA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x688B0C0", Offset = "0x688A0C0", VA = "0x18688B0C0", Slot = "5")]
	public void OJDPKNFGEHN(object KONODCHOCOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x688AAD0", Offset = "0x6889AD0", VA = "0x18688AAD0", Slot = "6")]
	public void ABPOEFEKAJB(object KONODCHOCOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x688AD50", Offset = "0x6889D50", VA = "0x18688AD50", Slot = "9")]
	public void GNOBEOILMIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x688AE90", Offset = "0x6889E90", VA = "0x18688AE90")]
	private void HBKJMBJEPLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x688ABA0", Offset = "0x6889BA0", VA = "0x18688ABA0")]
	private void CCADJFCJOGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x688B080", Offset = "0x688A080", VA = "0x18688B080", Slot = "8")]
	public void NFJBJAKGNID(BOJDJCGCFMG IHACPEDFDJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x688AD10", Offset = "0x6889D10", VA = "0x18688AD10", Slot = "7")]
	public void ECNAGKMCEBB(BOJDJCGCFMG IHACPEDFDJO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class JAEENGNEFFJ : KDMCCJIINBG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly JJBHMLOENNP IHACPEDFDJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly EEABDCAPAGK MCLJPOOFPCD;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public bool EIEMCPKOECE
	{
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x688FDE0", Offset = "0x688EDE0", VA = "0x18688FDE0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002B")]
	public event DGOFPGGNFJP JLKABBMECML
	{
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x688FE90", Offset = "0x688EE90", VA = "0x18688FE90", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x688FFC0", Offset = "0x688EFC0", VA = "0x18688FFC0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x68901F0", Offset = "0x688F1F0", VA = "0x1868901F0")]
	public JAEENGNEFFJ(BOJDJCGCFMG IHACPEDFDJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x688FFB0", Offset = "0x688EFB0", VA = "0x18688FFB0", Slot = "7")]
	public void LKKLCJKCPGN(object KONODCHOCOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x688FFA0", Offset = "0x688EFA0", VA = "0x18688FFA0", Slot = "8")]
	public void ILMFNMCMDMF(object KONODCHOCOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x6890060", Offset = "0x688F060", VA = "0x186890060", Slot = "9")]
	public void NBOPJNDAAAI(object KONODCHOCOG, bool DALNOEDDEKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x688FF60", Offset = "0x688EF60", VA = "0x18688FF60", Slot = "12")]
	public void GPFNAEECCEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x6890170", Offset = "0x688F170", VA = "0x186890170", Slot = "10")]
	public void OKKIHGNIDLB(Rigidbody JPKDDDJNLCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x688FF30", Offset = "0x688EF30", VA = "0x18688FF30", Slot = "11")]
	public void GEDDPLFBHFE(Rigidbody PEFEIMLIJIA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal sealed class NPPPJJEHBMC : MBONELPFGCM, LOJNGOGILDG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly JJBHMLOENNP IHACPEDFDJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private PhotonView ACBFHDGPGOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private bool MPLFDPEPOPH;

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public PhotonView CBJMADCOBMA
	{
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x7C2D60", Offset = "0x7C1D60", VA = "0x1807C2D60", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public bool ECGJJHKFHFE
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x6897C00", Offset = "0x6896C00", VA = "0x186897C00", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public bool HCNGLELBJAH
	{
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x9057B0", Offset = "0x9047B0", VA = "0x1809057B0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002C")]
	public event DGOFPGGNFJP KIOKNGMJMPL
	{
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x6898660", Offset = "0x6897660", VA = "0x186898660", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x6897B60", Offset = "0x6896B60", VA = "0x186897B60", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x6898700", Offset = "0x6897700", VA = "0x186898700")]
	public NPPPJJEHBMC(BOJDJCGCFMG IHACPEDFDJO, [In] KGDPENLDKCN GPKMLHOONCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x6898250", Offset = "0x6897250", VA = "0x186898250", Slot = "9")]
	public void KLABGHMFFPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x6897C20", Offset = "0x6896C20", VA = "0x186897C20", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x68984F0", Offset = "0x68974F0", VA = "0x1868984F0", Slot = "10")]
	public void LFCNFELFJDK(BOJDJCGCFMG NNHBJFPLAAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x6898380", Offset = "0x6897380", VA = "0x186898380", Slot = "11")]
	public void LCOGPJFPGFK(BOJDJCGCFMG NNHBJFPLAAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x6897F90", Offset = "0x6896F90", VA = "0x186897F90")]
	private void EOPBBDINLDE(PhotonView BDMNGJMCCGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x6898100", Offset = "0x6897100", VA = "0x186898100")]
	private void IKNECEMBCPH(KMOJNPOCKBC MCCGOMHPDLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x6897D20", Offset = "0x6896D20", VA = "0x186897D20")]
	private void EJCEFAJAKFE(PhotonView PNJCJCCOMCJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal static class POPDACKPGKH
{
	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x6898E00", Offset = "0x6897E00", VA = "0x186898E00")]
	public static MBONELPFGCM HIMGNABPKBC(this BOJDJCGCFMG OFFMGNOKEOO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal sealed class HGNNBBNIFFL : MNJBAMCMDMO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly JJBHMLOENNP IHACPEDFDJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private RigidbodyConstraints LDMDMBPNDBF;

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public bool KJNJAAONODH
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0xB83310", Offset = "0xB82310", VA = "0x180B83310", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x4098760", Offset = "0x4097760", VA = "0x184098760", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool LOMLHPEKCCD
	{
		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0xE02640", Offset = "0xE01640", VA = "0x180E02640", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x4098750", Offset = "0x4097750", VA = "0x184098750")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public RigidbodyConstraints CHMNFEIOEOL
	{
		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x7C5830", Offset = "0x7C4830", VA = "0x1807C5830", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x688C530", Offset = "0x688B530", VA = "0x18688C530", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x688C690", Offset = "0x688B690", VA = "0x18688C690")]
	public HGNNBBNIFFL(BOJDJCGCFMG IHACPEDFDJO, [In] KGDPENLDKCN GPKMLHOONCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x688C660", Offset = "0x688B660", VA = "0x18688C660", Slot = "9")]
	public void OKKIHGNIDLB(Rigidbody PEFEIMLIJIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x688C500", Offset = "0x688B500", VA = "0x18688C500", Slot = "10")]
	public void GEDDPLFBHFE(Rigidbody PEFEIMLIJIA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class JEDHJEBDBEO : MMCFELEGMIA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly BOJDJCGCFMG IHACPEDFDJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private float MFCKJHGMLFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private float KLAECCBPPOI;

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public float BIJOGJPJFHF
	{
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x9471F0", Offset = "0x9461F0", VA = "0x1809471F0", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x6890450", Offset = "0x688F450", VA = "0x186890450", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public float AKNGIKMOIAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0xA007F0", Offset = "0x9FF7F0", VA = "0x180A007F0", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x68902E0", Offset = "0x688F2E0", VA = "0x1868902E0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x6890570", Offset = "0x688F570", VA = "0x186890570")]
	public JEDHJEBDBEO(BOJDJCGCFMG IHACPEDFDJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x6890520", Offset = "0x688F520", VA = "0x186890520", Slot = "8")]
	public void OKKIHGNIDLB(Rigidbody PEFEIMLIJIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x68903B0", Offset = "0x688F3B0", VA = "0x1868903B0", Slot = "9")]
	public void GEDDPLFBHFE(Rigidbody PEFEIMLIJIA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal sealed class GLMKJMGOPFI : PCAPEOIGBNK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly JJBHMLOENNP IHACPEDFDJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private bool MKGKMGHKDHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private bool EJJHJIPJLMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private int BNKMMOPEJOB;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	private Rigidbody FDIPIHCLHPM
	{
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x68857A0", Offset = "0x68847A0", VA = "0x1868857A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	private bool MBCGJIMNDLB
	{
		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x688BC40", Offset = "0x688AC40", VA = "0x18688BC40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	private BOJDJCGCFMG MILAJCEOCBC
	{
		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x688BBE0", Offset = "0x688ABE0", VA = "0x18688BBE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	private bool ABHAFFOKCAG
	{
		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x688C370", Offset = "0x688B370", VA = "0x18688C370")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002D")]
	public event DGOFPGGNFJP ANNJEHCBGGA
	{
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x688C3D0", Offset = "0x688B3D0", VA = "0x18688C3D0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x688BC60", Offset = "0x688AC60", VA = "0x18688BC60", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x688C470", Offset = "0x688B470", VA = "0x18688C470")]
	public GLMKJMGOPFI(BOJDJCGCFMG IHACPEDFDJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x688BF00", Offset = "0x688AF00", VA = "0x18688BF00", Slot = "6")]
	public void KLABGHMFFPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x688BE50", Offset = "0x688AE50", VA = "0x18688BE50", Slot = "8")]
	public void GMPEIANMIIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x688BD00", Offset = "0x688AD00", VA = "0x18688BD00", Slot = "7")]
	public bool FKBLMGOIBCC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x688C2D0", Offset = "0x688B2D0", VA = "0x18688C2D0", Slot = "9")]
	public void LJLGIJFOGKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x688BE60", Offset = "0x688AE60", VA = "0x18688BE60", Slot = "11")]
	public void HMJJMGLGKAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x688C120", Offset = "0x688B120", VA = "0x18688C120", Slot = "10")]
	public void LHGKKDCJCBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x688BA00", Offset = "0x688AA00", VA = "0x18688BA00")]
	private bool APAIPCNKFBL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x688BF90", Offset = "0x688AF90", VA = "0x18688BF90")]
	private void KNJBFLDAOBF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class DBADEDNOFEP : NIOEOOMBGLD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly JJBHMLOENNP IHACPEDFDJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly EEABDCAPAGK GIEDCCKJFGO;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public Rigidbody FDIPIHCLHPM
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x7C2D60", Offset = "0x7C1D60", VA = "0x1807C2D60", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x7C1DE0", Offset = "0x7C0DE0", VA = "0x1807C1DE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	private bool ABHAFFOKCAG
	{
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x68885F0", Offset = "0x68875F0", VA = "0x1868885F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public bool EBMBLMBHHFM
	{
		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0xDB0B30", Offset = "0xDAFB30", VA = "0x180DB0B30", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x6889B90", Offset = "0x6888B90", VA = "0x186889B90")]
	public DBADEDNOFEP(BOJDJCGCFMG IHACPEDFDJO, [In] KGDPENLDKCN GPKMLHOONCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x68897C0", Offset = "0x68887C0", VA = "0x1868897C0", Slot = "5")]
	public void KLABGHMFFPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x6888FA0", Offset = "0x6887FA0", VA = "0x186888FA0", Slot = "7")]
	public void GBIEFGOKLIL(object KONODCHOCOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x6889150", Offset = "0x6888150", VA = "0x186889150", Slot = "8")]
	public void IDJCOCMHAEG(object KONODCHOCOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x6889860", Offset = "0x6888860", VA = "0x186889860", Slot = "9")]
	public void LPIMLMKKMGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x6888DB0", Offset = "0x6887DB0", VA = "0x186888DB0", Slot = "11")]
	public void FIHCLOFBHAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x6888FD0", Offset = "0x6887FD0", VA = "0x186888FD0", Slot = "12")]
	public void HJJLJKFFNEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x6889180", Offset = "0x6888180", VA = "0x186889180", Slot = "10")]
	public void IEDHBHDKLLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x6888C00", Offset = "0x6887C00", VA = "0x186888C00")]
	private void BJAECECNPDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x6889610", Offset = "0x6888610", VA = "0x186889610")]
	private void IMKKPNDKDFK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal sealed class IBIMFHDMHMC : GIBJNCAOGPN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private readonly JJBHMLOENNP IHACPEDFDJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private readonly EEABDCAPAGK FDGIFIOJKMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private float HKINPFHGEHD;

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public BGLLLMAKHCH LIBOIILFAKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x7C3F20", Offset = "0x7C2F20", VA = "0x1807C3F20", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x7C3D80", Offset = "0x7C2D80", VA = "0x1807C3D80", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public EADDLCIMNLA HLMFNPADCNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x7C5860", Offset = "0x7C4860", VA = "0x1807C5860", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x7C5840", Offset = "0x7C4840", VA = "0x1807C5840", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public Vector3 HENBBEFCDFN
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x688D250", Offset = "0x688C250", VA = "0x18688D250", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x688F310", Offset = "0x688E310", VA = "0x18688F310", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public Vector3 GNIJNDIJCHH
	{
		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x688ECB0", Offset = "0x688DCB0", VA = "0x18688ECB0", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x688EB20", Offset = "0x688DB20", VA = "0x18688EB20", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public Vector3 BNHEIIAPBHA
	{
		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x688EB50", Offset = "0x688DB50", VA = "0x18688EB50", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x688DE80", Offset = "0x688CE80", VA = "0x18688DE80", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public Vector3 GLOADELBEAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x688F3D0", Offset = "0x688E3D0", VA = "0x18688F3D0", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x688EE80", Offset = "0x688DE80", VA = "0x18688EE80", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public float DLPJBFBAGPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x9874F0", Offset = "0x9864F0", VA = "0x1809874F0", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x688D840", Offset = "0x688C840", VA = "0x18688D840", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public bool LEDPLHBJICL
	{
		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x1760570", Offset = "0x175F570", VA = "0x181760570", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	private HLGBPGDLDIH ONGIKIGOFCO
	{
		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x615CE10", Offset = "0x615BE10", VA = "0x18615CE10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	private bool MBCGJIMNDLB
	{
		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x688DA70", Offset = "0x688CA70", VA = "0x18688DA70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x688FCF0", Offset = "0x688ECF0", VA = "0x18688FCF0")]
	public IBIMFHDMHMC(BOJDJCGCFMG IHACPEDFDJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x688DA90", Offset = "0x688CA90", VA = "0x18688DA90", Slot = "19")]
	public void KLABGHMFFPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x688E060", Offset = "0x688D060", VA = "0x18688E060", Slot = "36")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x688F750", Offset = "0x688E750", VA = "0x18688F750", Slot = "28")]
	public void OKKIHGNIDLB(Rigidbody PEFEIMLIJIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0xBC2810", Offset = "0xBC1810", VA = "0x180BC2810", Slot = "20")]
	public void KAJALDFIMCI(object KONODCHOCOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0xBC3A10", Offset = "0xBC2A10", VA = "0x180BC3A10", Slot = "30")]
	public void ELIBGPPJCNG(object KONODCHOCOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x688F880", Offset = "0x688E880", VA = "0x18688F880", Slot = "35")]
	public Vector3 PCDPBCIHPMF(Vector3 EHDONMPNJKF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x688EEB0", Offset = "0x688DEB0", VA = "0x18688EEB0", Slot = "34")]
	public Vector3 KFDJIPPCPAC(Vector3 EALHJCELKMC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x688DA90", Offset = "0x688CA90", VA = "0x18688DA90", Slot = "27")]
	public void CNBLDBEPIJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x688F2B0", Offset = "0x688E2B0", VA = "0x18688F2B0", Slot = "25")]
	public void NBFLDFHDMAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x688F6F0", Offset = "0x688E6F0", VA = "0x18688F6F0", Slot = "24")]
	public void OCMGPNCLHDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x688F070", Offset = "0x688E070", VA = "0x18688F070", Slot = "33")]
	public void LAALPFGIDKP(Vector3 GEFAOGEPMNH, Vector3 DHJFGPMFDHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x688F500", Offset = "0x688E500", VA = "0x18688F500", Slot = "32")]
	public void NMHNLHDMDNG(Vector3 AOILAALLFEL, Vector3 KMLMDMHBLNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x688DB40", Offset = "0x688CB40", VA = "0x18688DB40", Slot = "31")]
	public void DBGNEKAAJMN(Vector3 LJLBLGLLKLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x688E4B0", Offset = "0x688D4B0", VA = "0x18688E4B0", Slot = "22")]
	public void FEBHEIBFEHM(MEKFJPELAOM MMJDJKINIEI, Vector3 JJCDAOEEONM, float APHKJGDFGHN, float FPIBBDFFLEM = 8f, float DMLBKDPKECC = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x688FA60", Offset = "0x688EA60", VA = "0x18688FA60", Slot = "21")]
	public void PPJIHGGOEEG(FNFFNOPGDAE BIGJKOCLOKM, Vector3 PKJJGHKMLBD, float JGGJJDNDNCC = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x688E0C0", Offset = "0x688D0C0", VA = "0x18688E0C0", Slot = "23")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void ECMFHAEHEHN(FNFFNOPGDAE BIGJKOCLOKM, Vector3 CKCOAEGKOKA, float GPACIKBBBFF = 7f, float KCOELLNBOPI = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0xCBE450", Offset = "0xCBD450", VA = "0x180CBE450")]
	private static void BKNAPKEBONA(Vector3 KKLIKHAJECJ, Vector3 KMBEHGBELJC, [Out] Vector3 GOFKGJBIKHD, [Out] Vector3 BKEDMPAACMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x688CCE0", Offset = "0x688BCE0", VA = "0x18688CCE0", Slot = "29")]
	public Vector3 AHHIJEOIOIL(Vector3 KKLIKHAJECJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x688F560", Offset = "0x688E560", VA = "0x18688F560", Slot = "26")]
	public void NNABBBGCDDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x688D840", Offset = "0x688C840", VA = "0x18688D840")]
	private void BIMPCCIGFMD(float LDGMLLMKHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x688DCE0", Offset = "0x688CCE0", VA = "0x18688DCE0")]
	private void DHGMKOKFNPB(Vector3 PKJJGHKMLBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x688DF40", Offset = "0x688CF40", VA = "0x18688DF40")]
	private Vector3 DNJGLAMNLNJ()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x688D3B0", Offset = "0x688C3B0", VA = "0x18688D3B0")]
	private void BHCEECKBEIP(Vector3 EALHJCELKMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x688D950", Offset = "0x688C950", VA = "0x18688D950")]
	private Vector3 BKICNKODLMK()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x688CDC0", Offset = "0x688BDC0", VA = "0x18688CDC0")]
	private void BDADJPANPNB(Vector3 LDGMLLMKHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x688C730", Offset = "0x688B730", VA = "0x18688C730")]
	private void AGCKPEGBLJB(Vector3 EALHJCELKMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x688EDD0", Offset = "0x688DDD0", VA = "0x18688EDD0")]
	private void IJKMKOHDNHJ()
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
