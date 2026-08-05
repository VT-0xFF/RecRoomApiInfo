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
	public class LogRegistrationIndex : DAMGOKPKJCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6F88FF0", Offset = "0x6F875F0", VA = "0x186F88FF0", Slot = "4")]
		public override void PIKNDMFIIPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x88C9F0", Offset = "0x88AFF0", VA = "0x18088C9F0")]
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
	public class _AssemblyIndex : KHGPJHOJOHH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private int[] localIndices0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private HODLKMJCPDK bitset0;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x866520", Offset = "0x864B20", VA = "0x180866520", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x14F1B90", Offset = "0x14F0190", VA = "0x1814F1B90", Slot = "5")]
		public override void GFCMAGCMMPB(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6F95130", Offset = "0x6F93730", VA = "0x186F95130")]
		private void CIONGDPCBDA(DMJKCLJBHON registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6F95440", Offset = "0x6F93A40", VA = "0x186F95440", Slot = "6")]
		public override void CKJFBMFKCLI(DMJKCLJBHON registry, [In] MIOEIJGFFCO filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350", Slot = "8")]
		public override void LOCAGFNGOIC(ADLFNLPBEEE registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6F954A0", Offset = "0x6F93AA0", VA = "0x186F954A0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[DisallowMultipleComponent]
	public sealed class RigidbodyEx : MonoBehaviour, GMBPJONDGEK
	{
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static readonly ICJNMGNJFIN HOCPLNFHBKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private bool LBCAACILHEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private APLBGFGJNCA IHNJICMAIFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[SerializeField]
		[NPPPEBEMIFD(CKKEEFADMDD.Self, false, false, false)]
		private Rigidbody unityRigidbody;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[SerializeField]
		[NPPPEBEMIFD(CKKEEFADMDD.SelfAndParent, true, false, false)]
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
		private JAFDOBAHKIN physicsInterpolation;

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
		internal APLBGFGJNCA HNAILNEMKEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x6F90770", Offset = "0x6F8ED70", VA = "0x186F90770")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private APLBGFGJNCA PPPAFAIGEDM
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x8657D0", Offset = "0x863DD0", VA = "0x1808657D0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int OBEGLHIDBFJ
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x6F92560", Offset = "0x6F90B60", VA = "0x186F92560")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RigidbodyEx NGHIDINCOLE
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x6F928C0", Offset = "0x6F90EC0", VA = "0x186F928C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx JJGALJKCIFK
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x6F92800", Offset = "0x6F90E00", VA = "0x186F92800")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RigidbodyEx HHMPHBNGMGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x6F93570", Offset = "0x6F91B70", VA = "0x186F93570")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x6F94AA0", Offset = "0x6F930A0", VA = "0x186F94AA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Transform OLKGLLBJDEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x88BDF0", Offset = "0x88A3F0", VA = "0x18088BDF0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Transform HPKOOIKHDEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x88BDF0", Offset = "0x88A3F0", VA = "0x18088BDF0", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public AHOPCOINALC MOCDPHINOGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x6F925C0", Offset = "0x6F90BC0", VA = "0x186F925C0")]
			get
			{
				return default(AHOPCOINALC);
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x6F94250", Offset = "0x6F92850", VA = "0x186F94250")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool LNOIEOBPGOA
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x6F92BD0", Offset = "0x6F911D0", VA = "0x186F92BD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool HLOCEFHJFJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x6F926E0", Offset = "0x6F90CE0", VA = "0x186F926E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public NBGFPCGNHAJ MDIDEKBEBLF
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x6F92B10", Offset = "0x6F91110", VA = "0x186F92B10")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x6F94410", Offset = "0x6F92A10", VA = "0x186F94410")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public GDLMMBKDOFD PDHMDHCJJAN
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x6F92AB0", Offset = "0x6F910B0", VA = "0x186F92AB0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6F943A0", Offset = "0x6F929A0", VA = "0x186F943A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool HMPBHMHCEBL
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x6F92A00", Offset = "0x6F91000", VA = "0x186F92A00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public Rigidbody IIPBAHLFLID
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x6F92A60", Offset = "0x6F91060", VA = "0x186F92A60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool NJHCAMDGLGE
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x6F92740", Offset = "0x6F90D40", VA = "0x186F92740")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x6F942C0", Offset = "0x6F928C0", VA = "0x186F942C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool HNHKKNPDDHM
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x669BF50", Offset = "0x669A550", VA = "0x18669BF50", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public float EBIBGLELPLK
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x6F93510", Offset = "0x6F91B10", VA = "0x186F93510")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public float EKONFELAOEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x6F934B0", Offset = "0x6F91AB0", VA = "0x186F934B0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x6F94A30", Offset = "0x6F93030", VA = "0x186F94A30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float EKDGABLHIEO
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x6F92E30", Offset = "0x6F91430", VA = "0x186F92E30")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x6F946B0", Offset = "0x6F92CB0", VA = "0x186F946B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float KCBCOJGBNPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x6F92C30", Offset = "0x6F91230", VA = "0x186F92C30")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x6F94480", Offset = "0x6F92A80", VA = "0x186F94480")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool NLGHMADHINI
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x6F93AF0", Offset = "0x6F920F0", VA = "0x186F93AF0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x6F94FE0", Offset = "0x6F935E0", VA = "0x186F94FE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public Vector3 JNPBMMPAEKG
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x6F93290", Offset = "0x6F91890", VA = "0x186F93290")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x6F94800", Offset = "0x6F92E00", VA = "0x186F94800")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Vector3 EAFKAPPODGL
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x6F93C30", Offset = "0x6F92230", VA = "0x186F93C30")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public CollisionDetectionMode PJOLJLIIGEN
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x6F92D70", Offset = "0x6F91370", VA = "0x186F92D70")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x6F945D0", Offset = "0x6F92BD0", VA = "0x186F945D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public float KHBCBMICPIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x6F927A0", Offset = "0x6F90DA0", VA = "0x186F927A0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x6F94330", Offset = "0x6F92930", VA = "0x186F94330")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public RigidbodyConstraints HBAOCIHDKOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x6F92DD0", Offset = "0x6F913D0", VA = "0x186F92DD0")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x6F94640", Offset = "0x6F92C40", VA = "0x186F94640")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public Vector3 FNOIONOPHKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x6F93630", Offset = "0x6F91C30", VA = "0x186F93630")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public Vector3 AIDMCMNAPCM
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x6F93630", Offset = "0x6F91C30", VA = "0x186F93630")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x6F94DC0", Offset = "0x6F933C0", VA = "0x186F94DC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float MMHPMHNOCBE
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x6F93370", Offset = "0x6F91970", VA = "0x186F93370")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x6F948E0", Offset = "0x6F92EE0", VA = "0x186F948E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float PPHEFDMHCNP
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x6F93A90", Offset = "0x6F92090", VA = "0x186F93A90")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x6F94F70", Offset = "0x6F93570", VA = "0x186F94F70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public Quaternion JOLFGKGNNCC
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x6F93710", Offset = "0x6F91D10", VA = "0x186F93710")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x6F94B40", Offset = "0x6F93140", VA = "0x186F94B40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public Quaternion KGNMJDNIGAC
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x6F939B0", Offset = "0x6F91FB0", VA = "0x186F939B0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x6F94EA0", Offset = "0x6F934A0", VA = "0x186F94EA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Vector3 MNHCHKLAEEO
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x6F937F0", Offset = "0x6F91DF0", VA = "0x186F937F0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x6F94C10", Offset = "0x6F93210", VA = "0x186F94C10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Quaternion DCFEGAMOEON
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x6F938D0", Offset = "0x6F91ED0", VA = "0x186F938D0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x6F94CF0", Offset = "0x6F932F0", VA = "0x186F94CF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector3 EFBILKIFBJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x6F93B50", Offset = "0x6F92150", VA = "0x186F93B50")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x6F95050", Offset = "0x6F93650", VA = "0x186F95050")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Vector3 JPHCCCIGOIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x6F933D0", Offset = "0x6F919D0", VA = "0x186F933D0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x6F94950", Offset = "0x6F92F50", VA = "0x186F94950")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 BEELOOCNBOF
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x6F92C90", Offset = "0x6F91290", VA = "0x186F92C90")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x6F944F0", Offset = "0x6F92AF0", VA = "0x186F944F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 ABBPNJFJIFG
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x6F931B0", Offset = "0x6F917B0", VA = "0x186F931B0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x6F94720", Offset = "0x6F92D20", VA = "0x186F94720")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector3 EHAKGOGHFPP
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x6F93070", Offset = "0x6F91670", VA = "0x186F93070")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Quaternion MALDBKLIIFF
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x6F92F90", Offset = "0x6F91590", VA = "0x186F92F90")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector3 FADALCGGBHP
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x6F93DF0", Offset = "0x6F923F0", VA = "0x186F93DF0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Vector3 HOFHPDKDLEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x6F93D10", Offset = "0x6F92310", VA = "0x186F93D10")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool PANMEHIHIBN
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x6F93150", Offset = "0x6F91750", VA = "0x186F93150")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool AFHIINLOJFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x6F92B70", Offset = "0x6F91170", VA = "0x186F92B70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool OFLEHEDDMGL
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x6F92680", Offset = "0x6F90C80", VA = "0x186F92680")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool AFEJNPNMCAI
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x6F92620", Offset = "0x6F90C20", VA = "0x186F92620")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool DFJDMNDBIML
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x6F92500", Offset = "0x6F90B00", VA = "0x186F92500")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool ACFFJECCDHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x6F92E90", Offset = "0x6F91490", VA = "0x186F92E90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool LMMCDOJHLCP
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x23E6600", Offset = "0x23E4C00", VA = "0x1823E6600")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event JHDGOPNJJCO CBDGDFADEIH
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x6F92420", Offset = "0x6F90A20", VA = "0x186F92420")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x6F94170", Offset = "0x6F92770", VA = "0x186F94170")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event HJNBIKAPNHI MEJFDLJMBHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x6F92190", Offset = "0x6F90790", VA = "0x186F92190")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x6F93ED0", Offset = "0x6F924D0", VA = "0x186F93ED0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event HJNBIKAPNHI CCIOFDBKGEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x6F921F0", Offset = "0x6F907F0", VA = "0x186F921F0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x6F93F40", Offset = "0x6F92540", VA = "0x186F93F40")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event HJNBIKAPNHI CGOADBPPEDL
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x6F92340", Offset = "0x6F90940", VA = "0x186F92340")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x6F94090", Offset = "0x6F92690", VA = "0x186F94090")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<HPJFBALBIOJ, HPJFBALBIOJ> FPKHALMDLDG
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x6F922D0", Offset = "0x6F908D0", VA = "0x186F922D0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x6F94020", Offset = "0x6F92620", VA = "0x186F94020")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event HJNBIKAPNHI CMIJJPBNMKC
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x6F923B0", Offset = "0x6F909B0", VA = "0x186F923B0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x6F94100", Offset = "0x6F92700", VA = "0x186F94100")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event HJNBIKAPNHI JACHILDJDFO
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x6F92490", Offset = "0x6F90A90", VA = "0x186F92490")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x6F941E0", Offset = "0x6F927E0", VA = "0x186F941E0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event HJNBIKAPNHI EFMEMIAAGBB
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6F92260", Offset = "0x6F90860", VA = "0x186F92260")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x6F93FB0", Offset = "0x6F925B0", VA = "0x186F93FB0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x864E00", Offset = "0x863400", VA = "0x180864E00", Slot = "8")]
		private void IHHELCMEMFA(APLBGFGJNCA LIGKCFOOPNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6F910F0", Offset = "0x6F8F6F0", VA = "0x186F910F0")]
		internal void JGDEBKGKMBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6F91EB0", Offset = "0x6F904B0", VA = "0x186F91EB0")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public void TestOverrideUnityRigidbody(Rigidbody EDIKCMCJLAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6F90A00", Offset = "0x6F8F000", VA = "0x186F90A00")]
		public GMBPJONDGEK GetChild(int LLPJHIPCNFD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6F91B80", Offset = "0x6F90180", VA = "0x186F91B80")]
		public void SetInertiaTensor((Quaternion rot, Vector3 moments) GIALOAJHHIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6F90700", Offset = "0x6F8ED00", VA = "0x186F90700")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6F90770", Offset = "0x6F8ED70", VA = "0x186F90770")]
		private APLBGFGJNCA COELCLPACBC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6F90CB0", Offset = "0x6F8F2B0", VA = "0x186F90CB0")]
		private void IPJLDPAJHCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6F91350", Offset = "0x6F8F950", VA = "0x186F91350")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6F910F0", Offset = "0x6F8F6F0", VA = "0x186F910F0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6F912F0", Offset = "0x6F8F8F0", VA = "0x186F912F0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6F913B0", Offset = "0x6F8F9B0", VA = "0x186F913B0")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6F8FDB0", Offset = "0x6F8E3B0", VA = "0x186F8FDB0")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object OEDJKICDDGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6F91410", Offset = "0x6F8FA10", VA = "0x186F91410")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object OEDJKICDDGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6F909A0", Offset = "0x6F8EFA0", VA = "0x186F909A0")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6F91290", Offset = "0x6F8F890", VA = "0x186F91290")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6F91CE0", Offset = "0x6F902E0", VA = "0x186F91CE0")]
		public void SetParent(RigidbodyEx CBAEIEAPLIH, bool FFPHPJEJBKL = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6F91720", Offset = "0x6F8FD20", VA = "0x186F91720")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6F90ED0", Offset = "0x6F8F4D0", VA = "0x186F90ED0")]
		public bool IsRigidbodyAncestor(RigidbodyEx GNFLHKHMMIL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6F90FB0", Offset = "0x6F8F5B0", VA = "0x186F90FB0")]
		public bool IsRigidbodyDescendant(RigidbodyEx NAPOIPGFDKM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x6F90020", Offset = "0x6F8E620", VA = "0x186F90020")]
		public void AddInterpolationRestriction(object OEDJKICDDGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6F91480", Offset = "0x6F8FA80", VA = "0x186F91480")]
		public void RemoveInterpolationRestriction(object OEDJKICDDGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x6F90090", Offset = "0x6F8E690", VA = "0x186F90090")]
		public void AddKinematic(object OEDJKICDDGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6F914F0", Offset = "0x6F8FAF0", VA = "0x186F914F0")]
		public void RemoveKinematic(object OEDJKICDDGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6F91C60", Offset = "0x6F90260", VA = "0x186F91C60")]
		public void SetKinematic(object OEDJKICDDGA, bool OKDLNAIMGHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6F91A80", Offset = "0x6F90080", VA = "0x186F91A80")]
		public void SetDiscontinuousPositionAndRotation(Vector3 JLPKCGDHNKG, Quaternion GDJCCIDIKIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6F91980", Offset = "0x6F8FF80", VA = "0x186F91980")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 KFJLMDEKNOI, Quaternion NPNKNILIGCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6F90BA0", Offset = "0x6F8F1A0", VA = "0x186F90BA0")]
		public Vector3 GetConstrainedVelocity(Vector3 EFBILKIFBJD)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6F90A90", Offset = "0x6F8F090", VA = "0x186F90A90")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 BEELOOCNBOF)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6F8FF30", Offset = "0x6F8E530", VA = "0x186F8FF30")]
		public void AddForce(Vector3 BAKDLGCFEEB, ForceMode CGHFFMJLLOB = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6F8FE20", Offset = "0x6F8E420", VA = "0x186F8FE20")]
		public void AddForceAtPosition(Vector3 BAKDLGCFEEB, Vector3 MOIICCIPACK, ForceMode CGHFFMJLLOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6F90260", Offset = "0x6F8E860", VA = "0x186F90260")]
		public void AddTorque(Vector3 OAEKPIGFLHH, ForceMode CGHFFMJLLOB = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6F90100", Offset = "0x6F8E700", VA = "0x186F90100")]
		public void AddRelativeTorque(Vector3 OAEKPIGFLHH, ForceMode CGHFFMJLLOB = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6F91F80", Offset = "0x6F90580", VA = "0x186F91F80")]
		public Vector3 WorldToLocalVelocity(Vector3 GAIBCOAKDKC)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6F91180", Offset = "0x6F8F780", VA = "0x186F91180")]
		public Vector3 LocalToWorldVelocity(Vector3 JPHCCCIGOIO)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6F90940", Offset = "0x6F8EF40", VA = "0x186F90940")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6F908E0", Offset = "0x6F8EEE0", VA = "0x186F908E0")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6F90880", Offset = "0x6F8EE80", VA = "0x186F90880")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6F90820", Offset = "0x6F8EE20", VA = "0x186F90820")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6F91880", Offset = "0x6F8FE80", VA = "0x186F91880")]
		public void ResetVelocityWorldSpace(Vector3 JLAGCBDIOCE, Vector3 EDDEDOBFGPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6F91780", Offset = "0x6F8FD80", VA = "0x186F91780")]
		public void ResetVelocityLocalSpace(Vector3 OBEPKPEDLHP, Vector3 ABBPNJFJIFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6F91640", Offset = "0x6F8FC40", VA = "0x186F91640")]
		public void ResetLinearVelocityLocalSpace(Vector3 OBEPKPEDLHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6F91E10", Offset = "0x6F90410", VA = "0x186F91E10")]
		public bool SweepTest(Vector3 KDJEBHMIDDA, [Out] RaycastHit AFHFMMLDFGN, float PNEKGHHAGPJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6F91090", Offset = "0x6F8F690", VA = "0x186F91090")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6F91DB0", Offset = "0x6F903B0", VA = "0x186F91DB0")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6F91F20", Offset = "0x6F90520", VA = "0x186F91F20")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6F901F0", Offset = "0x6F8E7F0", VA = "0x186F901F0")]
		public void AddShouldHaveUnityRigidbodyToken(object OEDJKICDDGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6F91560", Offset = "0x6F8FB60", VA = "0x186F91560")]
		public void RemoveShouldHaveUnityRigidbodyToken(object OEDJKICDDGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x6F90590", Offset = "0x6F8EB90", VA = "0x186F90590")]
		public void ApplyForceVelocityChange(IFHGOPCKPNL JGPGGDILHJP, Vector3 FOFCEMPLBMF, float PMHFDGEEHMA, float CKOJHMCFDFN = 8f, float DAPEKAPEIGC = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6F904F0", Offset = "0x6F8EAF0", VA = "0x186F904F0")]
		public void ApplyAngularVelocityChange(NDHCMAFIHCP DMCPDILGENE, Vector3 CCIKDGBKHJI, float PFIFJDPLMHF = float.PositiveInfinity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6F90650", Offset = "0x6F8EC50", VA = "0x186F90650")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void ApplyTorqueAngularVelocityChangeDeprecated(NDHCMAFIHCP DMCPDILGENE, Vector3 ADNGPFKNGFI, float NBNJNGGMAEO = 7f, float JPGDHDCNCHB = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6F90420", Offset = "0x6F8EA20", VA = "0x186F90420")]
		public bool AllowedScaleChange(float BELNDHOBICH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x6F90350", Offset = "0x6F8E950", VA = "0x186F90350")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx MMELNEJHCGH, object OEDJKICDDGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x6F915D0", Offset = "0x6F8FBD0", VA = "0x186F915D0")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object OEDJKICDDGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6F92120", Offset = "0x6F90720", VA = "0x186F92120")]
		public RigidbodyEx()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x9517E0", Offset = "0x94FDE0", VA = "0x1809517E0", Slot = "4")]
		private GameObject FPDGFGKJAJD()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x88BDF0", Offset = "0x88A3F0", VA = "0x18088BDF0", Slot = "5")]
		private Transform PFNKLFDFBGE()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal static class HNFFNLJKEPD
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6F7E560", Offset = "0x6F7CB60", VA = "0x186F7E560")]
	public static APLBGFGJNCA HNAILNEMKEH(this RigidbodyEx HOIOIPJLNDO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[CMLNAOLMFON(typeof(PCNLIDDLILB), new string[] { })]
public class GLBDGMPJCGL : PCNLIDDLILB, FDGJCDDLIFG
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static readonly ICJNMGNJFIN CAJBNIGHKAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private KAKGBKJOLAH DBHAELEMENJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private LDBMCKMJGJN AHBNABCBLNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private ONEPIAJLOFA LAFANBIDBOH;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public LDBMCKMJGJN OKAMCKPLNOF
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x866510", Offset = "0x864B10", VA = "0x180866510", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public ONEPIAJLOFA OJAANGDCNKL
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x8657D0", Offset = "0x863DD0", VA = "0x1808657D0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6F7D010", Offset = "0x6F7B610", VA = "0x186F7D010", Slot = "7")]
	public void InitReferences(HODPOPFOFDD PDKMAMNDBJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6F7CF80", Offset = "0x6F7B580", VA = "0x186F7CF80", Slot = "6")]
	public APLBGFGJNCA DJOBDPAJLOD(RigidbodyEx HOIOIPJLNDO, MIAGEIJEICK FHNKDHIILBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
	public GLBDGMPJCGL()
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class PhysicsManager : SingletonMonoBehaviour<PhysicsManager>
	{
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static BGECMLEGDCD UpdateAfterFixedUpdateRan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private int CCDAIKBDMMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int CHLPHLFPBPE;

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x6F8FC10", Offset = "0x6F8E210", VA = "0x186F8FC10")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6F8FC50", Offset = "0x6F8E250", VA = "0x186F8FC50")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x6F8FC30", Offset = "0x6F8E230", VA = "0x186F8FC30")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string NFOHONOFFAP, [Optional] UnityEngine.Object FFHIJMOJNAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string NFOHONOFFAP, [Optional] UnityEngine.Object FFHIJMOJNAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6F8FD60", Offset = "0x6F8E360", VA = "0x186F8FD60")]
		public PhysicsManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class BPGPFHCNHNI
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class OOOPBILHDOE : NBGFPCGNHAJ, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x872BC0", Offset = "0x8711C0", VA = "0x180872BC0", Slot = "4")]
		public Vector3 NFABBLEHBOJ()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x872BC0", Offset = "0x8711C0", VA = "0x180872BC0", Slot = "5")]
		public Vector3 HOCEDEBJEEI()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public OOOPBILHDOE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public static NBGFPCGNHAJ GHIDIDFAAIB
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x6F7B2E0", Offset = "0x6F798E0", VA = "0x186F7B2E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface AKBJNHGNECB
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	CollisionDetectionMode AIEMLBIPKKK
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
	void NJNJFFLKLJH();

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void AALDBFMNNDA(bool PANMEHIHIBN);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BJAKKKCFBND(bool PANMEHIHIBN);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GFNCMGKLDEI(Rigidbody IBPJGMDGDIO);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool CCOPMDDFIGI(Vector3 KDJEBHMIDDA, [Out] RaycastHit AFHFMMLDFGN, float PNEKGHHAGPJ);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface KMKPHBLDIIH : IDisposable, FGNAADCNCCK
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	AHOPCOINALC MOCDPHINOGF
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action<HPJFBALBIOJ, HPJFBALBIOJ> FPKHALMDLDG;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NJNJFFLKLJH();
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[PBELGAHGGLA(AFHNLDKMONP.Application)]
public interface ONEPIAJLOFA
{
	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	DMGGNDNGING OMFFAMKPKOE(APLBGFGJNCA LIGKCFOOPNO);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	HAINGGMEBCP JIIPKKBNDKE(APLBGFGJNCA LIGKCFOOPNO);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	CPFOCAOAKBF GJIGFCGBIJF(APLBGFGJNCA LIGKCFOOPNO);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	MCHAOOGFIAG JFKKLEBDCCF(APLBGFGJNCA LIGKCFOOPNO);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	CJEAPFBINIP APAJABFGLEM(APLBGFGJNCA LIGKCFOOPNO);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	KMKPHBLDIIH PPMFHCDOJPB(APLBGFGJNCA LIGKCFOOPNO);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "6")]
	OMFLJILKCBJ IKAPCKKANAN(APLBGFGJNCA LIGKCFOOPNO);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "7")]
	BNCMPGAJGPD JAHDMOFAMIC(APLBGFGJNCA LIGKCFOOPNO);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "8")]
	AKBJNHGNECB HNHFBNANCFG(APLBGFGJNCA LIGKCFOOPNO);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "9")]
	LLMHJHKEOMO PHJHFOBLDJB(APLBGFGJNCA LIGKCFOOPNO);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "10")]
	FNDLGAMMLDH JBDODAFFNKP(APLBGFGJNCA LIGKCFOOPNO, [In] MIAGEIJEICK FHNKDHIILBL);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "11")]
	NIDOBNBOINJ PDLNIGDNPPB(APLBGFGJNCA LIGKCFOOPNO, [In] MIAGEIJEICK FHNKDHIILBL);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "12")]
	BJEDNLOFOCD CJHNJJLCBBL(APLBGFGJNCA LIGKCFOOPNO, [In] MIAGEIJEICK FHNKDHIILBL);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "13")]
	MOALKNPEIEJ LHHFOALJJFI(APLBGFGJNCA LIGKCFOOPNO, [In] MIAGEIJEICK FHNKDHIILBL);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "14")]
	COKAFKIMNBP PNACPCHIFHK(APLBGFGJNCA LIGKCFOOPNO, [In] MIAGEIJEICK FHNKDHIILBL);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "15")]
	APLBGFGJNCA DJOBDPAJLOD(RigidbodyEx HOIOIPJLNDO, MIAGEIJEICK FHNKDHIILBL, PCNLIDDLILB MFNJBGPIIEN);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface BNCMPGAJGPD
{
	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JMNAKONBCGM(Vector3 BAKDLGCFEEB, ForceMode CGHFFMJLLOB = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BIAEKBICOOJ(Vector3 BAKDLGCFEEB, Vector3 MOIICCIPACK, ForceMode CGHFFMJLLOB);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KMGFCLKLIKC(Vector3 OAEKPIGFLHH, ForceMode CGHFFMJLLOB = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void AADNPNFECGO(Vector3 OAEKPIGFLHH, ForceMode CGHFFMJLLOB = ForceMode.Force);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface LLMHJHKEOMO
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	bool MAIOGPMEPHO
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
	void GFNCMGKLDEI(Rigidbody IBPJGMDGDIO);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EBGHPNDPMOJ(Rigidbody IBPJGMDGDIO);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface DMGGNDNGING : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	IReadOnlyList<APLBGFGJNCA> PNMELPFDNDF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	APLBGFGJNCA JJGALJKCIFK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	APLBGFGJNCA EGEBOODOFAP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event HJNBIKAPNHI MEJFDLJMBHA;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event HJNBIKAPNHI CCIOFDBKGEJ;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event JHDGOPNJJCO HEJFAKOONNE;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action PCMNEHBAIEF;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action FDAFOFJNFAH;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action<APLBGFGJNCA> FDKFJIJKDCF;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<APLBGFGJNCA> INMPJHKCHJI;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event Action HCNDPNJJECM;

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action<APLBGFGJNCA> GJMGPANENOF;

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void JBIJAJOHEMP(APLBGFGJNCA NAEADMGDGFI, bool FFPHPJEJBKL = false);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface CPFOCAOAKBF
{
	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	Vector3 EDCABHFAAFE
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	Vector3 IKDJAIOOJFG
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NLLPPNIMLMC(APLBGFGJNCA HHMPHBNGMGF, object OEDJKICDDGA);

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HNAPJGELACK(object OEDJKICDDGA);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface MOALKNPEIEJ
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	Vector3 LLCHMCEGACO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	Vector3 DMKBNHANJAP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	float BOLEMMHMCAB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	float JCPNADANAGB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	Vector3 OGIAMCOBEDN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	Quaternion ILIHBKBCLNO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event HJNBIKAPNHI DJBLLAAKELC;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void KDALBOFGHHC((Quaternion rot, Vector3 moments) GIALOAJHHIE);

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void BGIAMMFHOEJ();

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void JFEFDBPFKAI();

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void MFCGGLFKNLK();

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void GFNCMGKLDEI(Rigidbody IBPJGMDGDIO);

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void EBGHPNDPMOJ(Rigidbody IBPJGMDGDIO);

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void KAAHHJDKNAH();
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface BJEDNLOFOCD
{
	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NJNJFFLKLJH();

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OFKLKDCJGJA(object OEDJKICDDGA);

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HLGBADLIJGL(object OEDJKICDDGA);

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DCOKOEOLMOH(APLBGFGJNCA HOIOIPJLNDO);

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OAAGPJFOBLH(APLBGFGJNCA HOIOIPJLNDO);

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NEOGDEAKAHI();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface OMFLJILKCBJ
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	bool EJAIKGPDIBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event HJNBIKAPNHI OLEHIOMBLOL;

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CNBBAJCBBGF(object OEDJKICDDGA);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NLNABJAHOLE(object OEDJKICDDGA);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MEPPPGODBIL(object OEDJKICDDGA, bool OKDLNAIMGHJ);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void GFNCMGKLDEI(Rigidbody NEPLMIMPLJL);

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void EBGHPNDPMOJ(Rigidbody IBPJGMDGDIO);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface NIDOBNBOINJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000046")]
	bool LNOIEOBPGOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool HLOCEFHJFJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event HJNBIKAPNHI LLGAAAIHHIP;

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NJNJFFLKLJH();

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AADHAIMFKPJ(APLBGFGJNCA HHMPHBNGMGF);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BKPHMNCBNLA(APLBGFGJNCA HHMPHBNGMGF);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface COKAFKIMNBP
{
	[Cpp2IlInjected.Token(Token = "0x17000048")]
	bool NJHCAMDGLGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool CHIDPLOENAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	RigidbodyConstraints MNFAOBCAHEG
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
	void GFNCMGKLDEI(Rigidbody IBPJGMDGDIO);

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void EBGHPNDPMOJ(Rigidbody IBPJGMDGDIO);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface MCHAOOGFIAG
{
	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	float JGIJMIECAMO
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	float OINHMCCHBFI
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
	void GFNCMGKLDEI(Rigidbody IBPJGMDGDIO);

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void EBGHPNDPMOJ(Rigidbody IBPJGMDGDIO);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface CJEAPFBINIP
{
	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event HJNBIKAPNHI GFKOIMCPIOF;

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NJNJFFLKLJH();

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool AGBCHGFAEEO();

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CLMOPEFPGKC();

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KPCLKJCNCKL();

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void GPHBGJPMKAM();

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OGFNCOIHMFP();
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface FNDLGAMMLDH
{
	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	Rigidbody IIPBAHLFLID
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool BLNJFOECNGI
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NJNJFFLKLJH();

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EBGLEEGCKPH(object OEDJKICDDGA);

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JKEKIFFHNOK(object OEDJKICDDGA);

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GBOHOMNEGGD();
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface HAINGGMEBCP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	NBGFPCGNHAJ MDIDEKBEBLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	GDLMMBKDOFD PDHMDHCJJAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	Vector3 PFPOLMCKFGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	Vector3 LPLJJCMDAJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	Vector3 MGBDEJCEECD
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	Vector3 GGAIONLLBJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	float KHBCBMICPIE
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	bool HMPBHMHCEBL
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void NJNJFFLKLJH();

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void NKHPKHMPMFD(object OEDJKICDDGA);

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void IAAPNEJDAPI(NDHCMAFIHCP DMCPDILGENE, Vector3 CCIKDGBKHJI, float PFIFJDPLMHF = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void OHMJEBOOCPL(IFHGOPCKPNL JGPGGDILHJP, Vector3 FOFCEMPLBMF, float PMHFDGEEHMA, float CKOJHMCFDFN = 8f, float DAPEKAPEIGC = 1f);

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void JNLCOADNGGC(NDHCMAFIHCP DMCPDILGENE, Vector3 ADNGPFKNGFI, float NBNJNGGMAEO = 7f, float JPGDHDCNCHB = 1f);

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void HOBKCMKFCLE();

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void DANBDBPOFDB();

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void BFJGNAHHNLH();

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void DNCLFMGGGJH();

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void GFNCMGKLDEI(Rigidbody IBPJGMDGDIO);

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Vector3 AEKAOILCHOO(Vector3 EFBILKIFBJD);

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void FGBCFIADCKO(object OEDJKICDDGA);

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void PBEKBHIAIFL(Vector3 IJLKCHGFNBD);

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void OFGCKBHIDPB(Vector3 OBEPKPEDLHP, Vector3 ABBPNJFJIFG);

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void DEBGMMCHMJM(Vector3 JLAGCBDIOCE, Vector3 EDDEDOBFGPD);

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "30")]
	Vector3 GIBOAKBIOBF(Vector3 JPHCCCIGOIO);

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Vector3 FHOLLECDNPL(Vector3 GAIBCOAKDKC);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[PBELGAHGGLA(AFHNLDKMONP.Application)]
public interface LDBMCKMJGJN
{
	[Cpp2IlInjected.Token(Token = "0x17000057")]
	bool NJDNOICGBKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EMLMLPHLIAG(string JCBCIJOKIDD);

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EPHAFDIFEKD(RigidbodyEx HOIOIPJLNDO, Action OGLJLDNLGIJ);

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "3")]
	FHGHNLIPMAB MPKIJMFLMHC(int LALLPFHGAEP);

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KBNPFKIJOPM(Vector3 EAFKAPPODGL, float MDONPHAMBEA, Color MKAJENPGJDK);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[PBELGAHGGLA(AFHNLDKMONP.Application)]
public interface PCNLIDDLILB
{
	[Cpp2IlInjected.Token(Token = "0x17000058")]
	LDBMCKMJGJN OKAMCKPLNOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	ONEPIAJLOFA OJAANGDCNKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "2")]
	APLBGFGJNCA DJOBDPAJLOD(RigidbodyEx HOIOIPJLNDO, MIAGEIJEICK FHNKDHIILBL);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class LECKHBKBLIE : APLBGFGJNCA, IDisposable, LEKDOPKEOJI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	internal readonly PCNLIDDLILB MFNJBGPIIEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	internal DMGGNDNGING FNKICHMEFHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	internal BJEDNLOFOCD CIOAIAFPJAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	internal NIDOBNBOINJ OGJHIBPCAOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal HAINGGMEBCP EFBILKIFBJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal CPFOCAOAKBF EMECJJMCCCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	internal MOALKNPEIEJ PLCJPKCFCJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal MCHAOOGFIAG LKBCBNGFBOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal LLMHJHKEOMO PMOOMEKJEMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	internal CJEAPFBINIP LOGPMGIAPBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	internal KMKPHBLDIIH ENAEIPEJPHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	internal OMFLJILKCBJ AHEKEFLBCJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	internal BNCMPGAJGPD BAKDLGCFEEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	internal COKAFKIMNBP KKJJECDHAKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	internal FNDLGAMMLDH IBPJGMDGDIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	internal AKBJNHGNECB DDAPNDBFMIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	internal IDisposable EAMLDIDFNOH;

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public AAEGPHPJNLD PACDPOKOKAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x863360", Offset = "0x861960", VA = "0x180863360", Slot = "22")]
		get
		{
			return default(AAEGPHPJNLD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public GMBPJONDGEK LPFBGACKLHF
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x868A30", Offset = "0x867030", VA = "0x180868A30", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x868930", Offset = "0x866F30", VA = "0x180868930")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public GameObject CHNINBIEDNN
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x9F18C0", Offset = "0x9EFEC0", VA = "0x1809F18C0", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x9D08B0", Offset = "0x9CEEB0", VA = "0x1809D08B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public Transform ODNLGPAEKMF
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x6F85550", Offset = "0x6F83B50", VA = "0x186F85550", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public Rigidbody IIPBAHLFLID
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x6F87480", Offset = "0x6F85A80", VA = "0x186F87480", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public APLBGFGJNCA EGEBOODOFAP
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x6F84050", Offset = "0x6F82650", VA = "0x186F84050", Slot = "27")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x6F835E0", Offset = "0x6F81BE0", VA = "0x186F835E0", Slot = "28")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public int OBEGLHIDBFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x6F83250", Offset = "0x6F81850", VA = "0x186F83250", Slot = "31")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public APLBGFGJNCA JJGALJKCIFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x6F841A0", Offset = "0x6F827A0", VA = "0x186F841A0", Slot = "29")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public bool OGKMLGMAMJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x6F81CD0", Offset = "0x6F802D0", VA = "0x186F81CD0", Slot = "138")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public bool LNOIEOBPGOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x6F82CE0", Offset = "0x6F812E0", VA = "0x186F82CE0", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public bool HLOCEFHJFJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x6F85690", Offset = "0x6F83C90", VA = "0x186F85690", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public NBGFPCGNHAJ MDIDEKBEBLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x6F836A0", Offset = "0x6F81CA0", VA = "0x186F836A0", Slot = "34")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x6F83F00", Offset = "0x6F82500", VA = "0x186F83F00", Slot = "35")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public GDLMMBKDOFD PDHMDHCJJAN
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x6F84EF0", Offset = "0x6F834F0", VA = "0x186F84EF0", Slot = "36")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x6F82D30", Offset = "0x6F81330", VA = "0x186F82D30", Slot = "37")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public float KHBCBMICPIE
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x6F828D0", Offset = "0x6F80ED0", VA = "0x186F828D0", Slot = "38")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x6F846D0", Offset = "0x6F82CD0", VA = "0x186F846D0", Slot = "39")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public Vector3 LPLJJCMDAJF
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x6F842A0", Offset = "0x6F828A0", VA = "0x186F842A0", Slot = "40")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x6F86160", Offset = "0x6F84760", VA = "0x186F86160", Slot = "41")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public Vector3 GGAIONLLBJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x6F84F40", Offset = "0x6F83540", VA = "0x186F84F40", Slot = "42")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x6F83500", Offset = "0x6F81B00", VA = "0x186F83500", Slot = "43")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public Vector3 PFPOLMCKFGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x6F84730", Offset = "0x6F82D30", VA = "0x186F84730", Slot = "44")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x6F84470", Offset = "0x6F82A70", VA = "0x186F84470", Slot = "45")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public Vector3 MGBDEJCEECD
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x6F86350", Offset = "0x6F84950", VA = "0x186F86350", Slot = "46")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x6F84C30", Offset = "0x6F83230", VA = "0x186F84C30", Slot = "47")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public bool OFLEHEDDMGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x6F875B0", Offset = "0x6F85BB0", VA = "0x186F875B0", Slot = "139")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public bool AFEJNPNMCAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x6F84E40", Offset = "0x6F83440", VA = "0x186F84E40", Slot = "48")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public bool DFJDMNDBIML
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x6F82C00", Offset = "0x6F81200", VA = "0x186F82C00", Slot = "49")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public bool HMPBHMHCEBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x6F81DE0", Offset = "0x6F803E0", VA = "0x186F81DE0", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public Vector3 EDCABHFAAFE
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x6F81E30", Offset = "0x6F80430", VA = "0x186F81E30", Slot = "51")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public Vector3 IKDJAIOOJFG
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x6F874D0", Offset = "0x6F85AD0", VA = "0x186F874D0", Slot = "52")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public Vector3 LLCHMCEGACO
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x6F81F60", Offset = "0x6F80560", VA = "0x186F81F60", Slot = "53")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x6F83CA0", Offset = "0x6F822A0", VA = "0x186F83CA0", Slot = "54")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public Vector3 DMKBNHANJAP
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x6F86490", Offset = "0x6F84A90", VA = "0x186F86490", Slot = "55")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public float BOLEMMHMCAB
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x6F85250", Offset = "0x6F83850", VA = "0x186F85250", Slot = "56")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public float JCPNADANAGB
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x6F81C80", Offset = "0x6F80280", VA = "0x186F81C80", Slot = "57")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x6F84240", Offset = "0x6F82840", VA = "0x186F84240", Slot = "58")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public Vector3 OGIAMCOBEDN
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x6F82980", Offset = "0x6F80F80", VA = "0x186F82980", Slot = "59")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public Quaternion ILIHBKBCLNO
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x6F83AD0", Offset = "0x6F820D0", VA = "0x186F83AD0", Slot = "60")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public float JGIJMIECAMO
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x6F85D90", Offset = "0x6F84390", VA = "0x186F85D90", Slot = "62")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x6F86100", Offset = "0x6F84700", VA = "0x186F86100", Slot = "63")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public float OINHMCCHBFI
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x6F82DF0", Offset = "0x6F813F0", VA = "0x186F82DF0", Slot = "64")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x6F865D0", Offset = "0x6F84BD0", VA = "0x186F865D0", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public bool MAIOGPMEPHO
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x6F82040", Offset = "0x6F80640", VA = "0x186F82040", Slot = "66")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x6F82D90", Offset = "0x6F81390", VA = "0x186F82D90", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public AHOPCOINALC MOCDPHINOGF
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x6F86300", Offset = "0x6F84900", VA = "0x186F86300", Slot = "68")]
		get
		{
			return default(AHOPCOINALC);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x6F85630", Offset = "0x6F83C30", VA = "0x186F85630", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public bool EJAIKGPDIBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x6F82310", Offset = "0x6F80910", VA = "0x186F82310", Slot = "70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public Transform HPKOOIKHDEI
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x6F81AB0", Offset = "0x6F800B0", VA = "0x186F81AB0", Slot = "71")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public Vector3 OFCPGHABHFO
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x6F83F60", Offset = "0x6F82560", VA = "0x186F83F60", Slot = "72")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x6F85490", Offset = "0x6F83A90", VA = "0x186F85490", Slot = "73")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public float ENGNAMJBAEK
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x6F82660", Offset = "0x6F80C60", VA = "0x186F82660", Slot = "74")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x6F86E20", Offset = "0x6F85420", VA = "0x186F86E20", Slot = "75")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public float HDCDFFDAKOA
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x6F85AE0", Offset = "0x6F840E0", VA = "0x186F85AE0", Slot = "76")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x6F85BE0", Offset = "0x6F841E0", VA = "0x186F85BE0", Slot = "77")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public Quaternion HEDBLFNKKEE
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x6F86A50", Offset = "0x6F85050", VA = "0x186F86A50", Slot = "78")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x6F85FF0", Offset = "0x6F845F0", VA = "0x186F85FF0", Slot = "79")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public Vector3 ABAOOCCJCCH
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x6F841F0", Offset = "0x6F827F0", VA = "0x186F841F0", Slot = "80")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x6F85200", Offset = "0x6F83800", VA = "0x186F85200", Slot = "81")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public Quaternion JHHONLHGLCH
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x6F84010", Offset = "0x6F82610", VA = "0x186F84010", Slot = "82")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x6F86630", Offset = "0x6F84C30", VA = "0x186F86630", Slot = "83")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public RigidbodyConstraints MNFAOBCAHEG
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x6F86780", Offset = "0x6F84D80", VA = "0x186F86780", Slot = "84")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x6F86430", Offset = "0x6F84A30", VA = "0x186F86430", Slot = "85")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public bool NJHCAMDGLGE
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x6F82880", Offset = "0x6F80E80", VA = "0x186F82880", Slot = "86")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x6F84D80", Offset = "0x6F83380", VA = "0x186F84D80", Slot = "87")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public CollisionDetectionMode AIEMLBIPKKK
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x6F85F20", Offset = "0x6F84520", VA = "0x186F85F20", Slot = "88")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x6F869F0", Offset = "0x6F84FF0", VA = "0x186F869F0", Slot = "89")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public bool GGPIKHKADAE
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x6F85DE0", Offset = "0x6F843E0", VA = "0x186F85DE0", Slot = "140")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public bool AFHIINLOJFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x6F85020", Offset = "0x6F83620", VA = "0x186F85020", Slot = "90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event HJNBIKAPNHI MEJFDLJMBHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x6F832C0", Offset = "0x6F818C0", VA = "0x186F832C0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x6F83060", Offset = "0x6F81660", VA = "0x186F83060", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event HJNBIKAPNHI CCIOFDBKGEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x6F81950", Offset = "0x6F7FF50", VA = "0x186F81950", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x6F86B60", Offset = "0x6F85160", VA = "0x186F86B60", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event JHDGOPNJJCO HEJFAKOONNE
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x6F85D30", Offset = "0x6F84330", VA = "0x186F85D30", Slot = "18")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x6F830C0", Offset = "0x6F816C0", VA = "0x186F830C0", Slot = "19")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event HJNBIKAPNHI LLGAAAIHHIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x6F86DC0", Offset = "0x6F853C0", VA = "0x186F86DC0", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x6F86570", Offset = "0x6F84B70", VA = "0x186F86570", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event HJNBIKAPNHI CGOADBPPEDL
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x6F872C0", Offset = "0x6F858C0", VA = "0x186F872C0", Slot = "14")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x6F85380", Offset = "0x6F83980", VA = "0x186F85380", Slot = "15")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event HJNBIKAPNHI GFKOIMCPIOF
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x6F84550", Offset = "0x6F82B50", VA = "0x186F84550", Slot = "16")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x6F81F00", Offset = "0x6F80500", VA = "0x186F81F00", Slot = "17")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	public event Action<HPJFBALBIOJ, HPJFBALBIOJ> FPKHALMDLDG
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x6F86E90", Offset = "0x6F85490", VA = "0x186F86E90", Slot = "20")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x6F84BD0", Offset = "0x6F831D0", VA = "0x186F84BD0", Slot = "21")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event HJNBIKAPNHI OLEHIOMBLOL
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x6F82AB0", Offset = "0x6F810B0", VA = "0x186F82AB0", Slot = "12")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x6F83640", Offset = "0x6F81C40", VA = "0x186F83640", Slot = "13")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event HJNBIKAPNHI EFMEMIAAGBB
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x6F818A0", Offset = "0x6F7FEA0", VA = "0x186F818A0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x6F87320", Offset = "0x6F85920", VA = "0x186F87320", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x6F87640", Offset = "0x6F85C40", VA = "0x186F87640")]
	public LECKHBKBLIE(GameObject INALOLPJOHI, RigidbodyEx KHBLFNBEAMA, PCNLIDDLILB MFNJBGPIIEN, [In] MIAGEIJEICK FHNKDHIILBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x6F86EF0", Offset = "0x6F854F0", VA = "0x186F86EF0", Slot = "136")]
	protected virtual void PBDFIEEPJDP(PCNLIDDLILB MFNJBGPIIEN, MIAGEIJEICK FHNKDHIILBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x6F83120", Offset = "0x6F81720", VA = "0x186F83120", Slot = "137")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x6F867D0", Offset = "0x6F84DD0", VA = "0x186F867D0", Slot = "91")]
	public void NJNJFFLKLJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x6F81D90", Offset = "0x6F80390", VA = "0x186F81D90", Slot = "92")]
	public void ANKEHACNMHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x6F860E0", Offset = "0x6F846E0", VA = "0x186F860E0", Slot = "93")]
	public void LOHBDBMDNNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x6F85F70", Offset = "0x6F84570", VA = "0x186F85F70")]
	private void LKGMHCOOGEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x6F86970", Offset = "0x6F84F70", VA = "0x186F86970", Slot = "30")]
	public APLBGFGJNCA NNPIKIFMACD(int LLPJHIPCNFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x6F84D10", Offset = "0x6F83310", VA = "0x186F84D10", Slot = "95")]
	public void JBIJAJOHEMP(APLBGFGJNCA CBAEIEAPLIH, bool FFPHPJEJBKL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x6F86B00", Offset = "0x6F85100", VA = "0x186F86B00", Slot = "96")]
	public void OELMKIPJBIG(object OEDJKICDDGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x6F81D30", Offset = "0x6F80330", VA = "0x186F81D30", Slot = "97")]
	public void ALDPGBMDKBE(object OEDJKICDDGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x6F83BA0", Offset = "0x6F821A0", VA = "0x186F83BA0", Slot = "98")]
	public Vector3 FHOLLECDNPL(Vector3 GAIBCOAKDKC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x6F840A0", Offset = "0x6F826A0", VA = "0x186F840A0", Slot = "99")]
	public Vector3 GIBOAKBIOBF(Vector3 JPHCCCIGOIO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x6F81D90", Offset = "0x6F80390", VA = "0x186F81D90", Slot = "100")]
	public void DNCLFMGGGJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x6F82A60", Offset = "0x6F81060", VA = "0x186F82A60", Slot = "101")]
	public void DANBDBPOFDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x6F84380", Offset = "0x6F82980", VA = "0x186F84380", Slot = "102")]
	public void HOBKCMKFCLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x6F82B10", Offset = "0x6F81110", VA = "0x186F82B10", Slot = "103")]
	public void DEBGMMCHMJM(Vector3 JLAGCBDIOCE, Vector3 EDDEDOBFGPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x6F86BC0", Offset = "0x6F851C0", VA = "0x186F86BC0", Slot = "104")]
	public void OFGCKBHIDPB(Vector3 OBEPKPEDLHP, Vector3 ABBPNJFJIFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x6F871E0", Offset = "0x6F857E0", VA = "0x186F871E0", Slot = "105")]
	public void PBEKBHIAIFL(Vector3 IJLKCHGFNBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x6F86D00", Offset = "0x6F85300", VA = "0x186F86D00", Slot = "106")]
	public void OHMJEBOOCPL(IFHGOPCKPNL JGPGGDILHJP, Vector3 FOFCEMPLBMF, float PMHFDGEEHMA, float CKOJHMCFDFN = 8f, float DAPEKAPEIGC = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x6F843D0", Offset = "0x6F829D0", VA = "0x186F843D0", Slot = "107")]
	public void IAAPNEJDAPI(NDHCMAFIHCP DMCPDILGENE, Vector3 CCIKDGBKHJI, float PFIFJDPLMHF = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x6F853E0", Offset = "0x6F839E0", VA = "0x186F853E0", Slot = "108")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void JNLCOADNGGC(NDHCMAFIHCP DMCPDILGENE, Vector3 ADNGPFKNGFI, float NBNJNGGMAEO = 7f, float JPGDHDCNCHB = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x6F819B0", Offset = "0x6F7FFB0", VA = "0x186F819B0", Slot = "109")]
	public Vector3 AEKAOILCHOO(Vector3 CBAEIEAPLIH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x6F82560", Offset = "0x6F80B60", VA = "0x186F82560", Slot = "110")]
	public Vector3 CHGJLBAAOOC(Vector3 CBAEIEAPLIH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x6F82090", Offset = "0x6F80690", VA = "0x186F82090", Slot = "111")]
	public void BFJGNAHHNLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x6F83A60", Offset = "0x6F82060", VA = "0x186F83A60", Slot = "112")]
	public void FHGLNMDOHBB(APLBGFGJNCA MMELNEJHCGH, object OEDJKICDDGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x6F81840", Offset = "0x6F7FE40", VA = "0x186F81840", Slot = "113")]
	public void AAMDKFFGMMO(object OEDJKICDDGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x6F856E0", Offset = "0x6F83CE0", VA = "0x186F856E0", Slot = "61")]
	public void KDALBOFGHHC((Quaternion rot, Vector3 moments) GIALOAJHHIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x6F84EA0", Offset = "0x6F834A0", VA = "0x186F84EA0", Slot = "114")]
	public void JFEFDBPFKAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x6F820E0", Offset = "0x6F806E0", VA = "0x186F820E0", Slot = "115")]
	public void BGIAMMFHOEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x6F862B0", Offset = "0x6F848B0", VA = "0x186F862B0", Slot = "116")]
	public void MFCGGLFKNLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x6F81C30", Offset = "0x6F80230", VA = "0x186F81C30", Slot = "117")]
	public bool AGBCHGFAEEO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x6F85CE0", Offset = "0x6F842E0", VA = "0x186F85CE0", Slot = "94")]
	public void KPCLKJCNCKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x6F86CB0", Offset = "0x6F852B0", VA = "0x186F86CB0", Slot = "118")]
	public void OGFNCOIHMFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x6F82920", Offset = "0x6F80F20", VA = "0x186F82920", Slot = "119")]
	public void CNBBAJCBBGF(object OEDJKICDDGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x6F86910", Offset = "0x6F84F10", VA = "0x186F86910", Slot = "120")]
	public void NLNABJAHOLE(object OEDJKICDDGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x6F86240", Offset = "0x6F84840", VA = "0x186F86240", Slot = "121")]
	public void MEPPPGODBIL(object OEDJKICDDGA, bool OKDLNAIMGHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x6F82680", Offset = "0x6F80C80", VA = "0x186F82680", Slot = "122")]
	public void CJEDGLMMBDC(Vector3 JLPKCGDHNKG, Quaternion GDJCCIDIKIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x6F82E40", Offset = "0x6F81440", VA = "0x186F82E40", Slot = "123")]
	public void DLMGOANOKML(Vector3 KFJLMDEKNOI, Quaternion NPNKNILIGCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x6F84DE0", Offset = "0x6F833E0", VA = "0x186F84DE0", Slot = "124")]
	public bool JDDFJCGKFMK(float BELNDHOBICH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x6F84670", Offset = "0x6F82C70", VA = "0x186F84670", Slot = "125")]
	public void ICCHKCLABFP(object OEDJKICDDGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x6F82360", Offset = "0x6F80960", VA = "0x186F82360", Slot = "126")]
	public void BNCCABKMMOJ(object OEDJKICDDGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x6F831F0", Offset = "0x6F817F0", VA = "0x186F831F0", Slot = "127")]
	public void EBGLEEGCKPH(object OEDJKICDDGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x6F851A0", Offset = "0x6F837A0", VA = "0x186F851A0", Slot = "128")]
	public void JKEKIFFHNOK(object OEDJKICDDGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x6F852A0", Offset = "0x6F838A0", VA = "0x186F852A0", Slot = "129")]
	public void JMNAKONBCGM(Vector3 BAKDLGCFEEB, ForceMode CGHFFMJLLOB = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x6F82130", Offset = "0x6F80730", VA = "0x186F82130", Slot = "130")]
	public void BIAEKBICOOJ(Vector3 BAKDLGCFEEB, Vector3 MOIICCIPACK, ForceMode CGHFFMJLLOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x6F85B00", Offset = "0x6F84100", VA = "0x186F85B00", Slot = "131")]
	public void KMGFCLKLIKC(Vector3 OAEKPIGFLHH, ForceMode CGHFFMJLLOB = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x6F81760", Offset = "0x6F7FD60", VA = "0x186F81760", Slot = "132")]
	public void AADNPNFECGO(Vector3 OAEKPIGFLHH, ForceMode CGHFFMJLLOB = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x6F824C0", Offset = "0x6F80AC0", VA = "0x186F824C0", Slot = "133")]
	public bool CCOPMDDFIGI(Vector3 KDJEBHMIDDA, [Out] RaycastHit AFHFMMLDFGN, float PNEKGHHAGPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x6F855E0", Offset = "0x6F83BE0", VA = "0x186F855E0", Slot = "134")]
	public void KAAHHJDKNAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x6F87600", Offset = "0x6F85C00", VA = "0x186F87600", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x6F82F90", Offset = "0x6F81590", VA = "0x186F82F90")]
	private void DNABJCBKPPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x6F86670", Offset = "0x6F84C70", VA = "0x186F86670")]
	private void NDPJBGPCGLG(APLBGFGJNCA HHMPHBNGMGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x6F83320", Offset = "0x6F81920", VA = "0x186F83320")]
	private void EEJCCGALIEH(APLBGFGJNCA HHMPHBNGMGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x6F873D0", Offset = "0x6F859D0", VA = "0x186F873D0")]
	private void PEOKLMJIOBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x6F823C0", Offset = "0x6F809C0", VA = "0x186F823C0")]
	private void CBHAEOGGOOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x6F83D80", Offset = "0x6F82380", VA = "0x186F83D80")]
	private void FJMINJPLNHH(APLBGFGJNCA JDLKLHDHDEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x6F81690", Offset = "0x6F7FC90", VA = "0x186F81690")]
	private void AADHAIMFKPJ(APLBGFGJNCA HHMPHBNGMGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x6F82240", Offset = "0x6F80840", VA = "0x186F82240")]
	private void BKPHMNCBNLA(APLBGFGJNCA HHMPHBNGMGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x6F81AC0", Offset = "0x6F800C0", VA = "0x186F81AC0")]
	private void AFGMPPIGCEI(GMBPJONDGEK HHMPHBNGMGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x6F84810", Offset = "0x6F82E10", VA = "0x186F84810", Slot = "141")]
	protected virtual void ILAKKIPIAGM(GMBPJONDGEK HOIOIPJLNDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x6F857C0", Offset = "0x6F83DC0", VA = "0x186F857C0")]
	protected void KGDHOPDFPEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x6F836F0", Offset = "0x6F81CF0", VA = "0x186F836F0")]
	protected void ENOKBICIDGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x6F845B0", Offset = "0x6F82BB0", VA = "0x186F845B0", Slot = "142")]
	protected virtual IDisposable IBGPALCFHDD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal static class GHMPHGLPLOH
{
	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x6F7CE40", Offset = "0x6F7B440", VA = "0x186F7CE40")]
	public static APLBGFGJNCA FHOPLAEMONJ(this APLBGFGJNCA HOIOIPJLNDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x6F7CF00", Offset = "0x6F7B500", VA = "0x186F7CF00")]
	public static bool OENLCNBNGPJ(this APLBGFGJNCA HOIOIPJLNDO, APLBGFGJNCA GNFLHKHMMIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x6F7CD50", Offset = "0x6F7B350", VA = "0x186F7CD50")]
	public static bool BOBCHMKELHI(this APLBGFGJNCA HOIOIPJLNDO, APLBGFGJNCA NAPOIPGFDKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x6F7CD00", Offset = "0x6F7B300", VA = "0x186F7CD00")]
	public static GMBPJONDGEK ABONPMOLODD(this APLBGFGJNCA LIGKCFOOPNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x6F7CDD0", Offset = "0x6F7B3D0", VA = "0x186F7CDD0")]
	public static LECKHBKBLIE DGOBLDGGNIM(this APLBGFGJNCA LIGKCFOOPNO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class DGKDDAHJNMC : ONEPIAJLOFA
{
	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x6F7C750", Offset = "0x6F7AD50", VA = "0x186F7C750", Slot = "19")]
	public APLBGFGJNCA DJOBDPAJLOD(RigidbodyEx HOIOIPJLNDO, MIAGEIJEICK FHNKDHIILBL, PCNLIDDLILB MFNJBGPIIEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x863360", Offset = "0x861960", VA = "0x180863360", Slot = "4")]
	public DMGGNDNGING OMFFAMKPKOE(APLBGFGJNCA LIGKCFOOPNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x863360", Offset = "0x861960", VA = "0x180863360", Slot = "5")]
	public HAINGGMEBCP JIIPKKBNDKE(APLBGFGJNCA LIGKCFOOPNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x863360", Offset = "0x861960", VA = "0x180863360", Slot = "6")]
	public CPFOCAOAKBF GJIGFCGBIJF(APLBGFGJNCA LIGKCFOOPNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x863360", Offset = "0x861960", VA = "0x180863360", Slot = "7")]
	public MCHAOOGFIAG JFKKLEBDCCF(APLBGFGJNCA LIGKCFOOPNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x863360", Offset = "0x861960", VA = "0x180863360", Slot = "8")]
	public CJEAPFBINIP APAJABFGLEM(APLBGFGJNCA LIGKCFOOPNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x863360", Offset = "0x861960", VA = "0x180863360", Slot = "9")]
	public KMKPHBLDIIH PPMFHCDOJPB(APLBGFGJNCA LIGKCFOOPNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x863360", Offset = "0x861960", VA = "0x180863360", Slot = "10")]
	public OMFLJILKCBJ IKAPCKKANAN(APLBGFGJNCA LIGKCFOOPNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x863360", Offset = "0x861960", VA = "0x180863360", Slot = "11")]
	public BNCMPGAJGPD JAHDMOFAMIC(APLBGFGJNCA LIGKCFOOPNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x863360", Offset = "0x861960", VA = "0x180863360", Slot = "12")]
	public AKBJNHGNECB HNHFBNANCFG(APLBGFGJNCA LIGKCFOOPNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x863360", Offset = "0x861960", VA = "0x180863360", Slot = "13")]
	public LLMHJHKEOMO PHJHFOBLDJB(APLBGFGJNCA LIGKCFOOPNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x863360", Offset = "0x861960", VA = "0x180863360")]
	public FNDLGAMMLDH JBDODAFFNKP(APLBGFGJNCA LIGKCFOOPNO, [In] MIAGEIJEICK FHNKDHIILBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x863360", Offset = "0x861960", VA = "0x180863360")]
	public NIDOBNBOINJ PDLNIGDNPPB(APLBGFGJNCA LIGKCFOOPNO, [In] MIAGEIJEICK FHNKDHIILBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x863360", Offset = "0x861960", VA = "0x180863360")]
	public BJEDNLOFOCD CJHNJJLCBBL(APLBGFGJNCA LIGKCFOOPNO, [In] MIAGEIJEICK FHNKDHIILBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x863360", Offset = "0x861960", VA = "0x180863360")]
	public MOALKNPEIEJ LHHFOALJJFI(APLBGFGJNCA LIGKCFOOPNO, [In] MIAGEIJEICK FHNKDHIILBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x863360", Offset = "0x861960", VA = "0x180863360")]
	public COKAFKIMNBP PNACPCHIFHK(APLBGFGJNCA LIGKCFOOPNO, [In] MIAGEIJEICK FHNKDHIILBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
	public DGKDDAHJNMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x863360", Offset = "0x861960", VA = "0x180863360", Slot = "14")]
	private FNDLGAMMLDH EPLJPPJDEFK(APLBGFGJNCA LIGKCFOOPNO, [In] MIAGEIJEICK FHNKDHIILBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x863360", Offset = "0x861960", VA = "0x180863360", Slot = "15")]
	private NIDOBNBOINJ IILJPPOKJGM(APLBGFGJNCA LIGKCFOOPNO, [In] MIAGEIJEICK FHNKDHIILBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x863360", Offset = "0x861960", VA = "0x180863360", Slot = "16")]
	private BJEDNLOFOCD COGHFDIOKAE(APLBGFGJNCA LIGKCFOOPNO, [In] MIAGEIJEICK FHNKDHIILBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x863360", Offset = "0x861960", VA = "0x180863360", Slot = "17")]
	private MOALKNPEIEJ DNJDKOIFKLL(APLBGFGJNCA LIGKCFOOPNO, [In] MIAGEIJEICK FHNKDHIILBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x863360", Offset = "0x861960", VA = "0x180863360", Slot = "18")]
	private COKAFKIMNBP PMLAGJGBCAF(APLBGFGJNCA LIGKCFOOPNO, [In] MIAGEIJEICK FHNKDHIILBL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[CMLNAOLMFON(typeof(ONEPIAJLOFA), new string[] { })]
public class LFNDKOCAEHM : ONEPIAJLOFA, FDGJCDDLIFG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private readonly ONEPIAJLOFA MCOBLJHMGGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly ONEPIAJLOFA DJHMCIECKEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private KAKGBKJOLAH DBHAELEMENJ;

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	private ONEPIAJLOFA OJAANGDCNKL
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x6F87D30", Offset = "0x6F86330", VA = "0x186F87D30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x6F87D90", Offset = "0x6F86390", VA = "0x186F87D90", Slot = "20")]
	public void InitReferences(HODPOPFOFDD PDKMAMNDBJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x6F87FC0", Offset = "0x6F865C0", VA = "0x186F87FC0", Slot = "4")]
	public DMGGNDNGING OMFFAMKPKOE(APLBGFGJNCA LIGKCFOOPNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x6F87F20", Offset = "0x6F86520", VA = "0x186F87F20", Slot = "5")]
	public HAINGGMEBCP JIIPKKBNDKE(APLBGFGJNCA LIGKCFOOPNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x6F87AA0", Offset = "0x6F860A0", VA = "0x186F87AA0", Slot = "6")]
	public CPFOCAOAKBF GJIGFCGBIJF(APLBGFGJNCA LIGKCFOOPNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x6F87E80", Offset = "0x6F86480", VA = "0x186F87E80", Slot = "7")]
	public MCHAOOGFIAG JFKKLEBDCCF(APLBGFGJNCA LIGKCFOOPNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x6F87710", Offset = "0x6F85D10", VA = "0x186F87710", Slot = "8")]
	public CJEAPFBINIP APAJABFGLEM(APLBGFGJNCA LIGKCFOOPNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x6F881B0", Offset = "0x6F867B0", VA = "0x186F881B0", Slot = "9")]
	public KMKPHBLDIIH PPMFHCDOJPB(APLBGFGJNCA LIGKCFOOPNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x6F87C90", Offset = "0x6F86290", VA = "0x186F87C90", Slot = "10")]
	public OMFLJILKCBJ IKAPCKKANAN(APLBGFGJNCA LIGKCFOOPNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x6F87DE0", Offset = "0x6F863E0", VA = "0x186F87DE0", Slot = "11")]
	public BNCMPGAJGPD JAHDMOFAMIC(APLBGFGJNCA LIGKCFOOPNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x6F87B40", Offset = "0x6F86140", VA = "0x186F87B40", Slot = "12")]
	public AKBJNHGNECB HNHFBNANCFG(APLBGFGJNCA LIGKCFOOPNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x6F88060", Offset = "0x6F86660", VA = "0x186F88060", Slot = "13")]
	public LLMHJHKEOMO PHJHFOBLDJB(APLBGFGJNCA LIGKCFOOPNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x6F879F0", Offset = "0x6F85FF0", VA = "0x186F879F0")]
	public FNDLGAMMLDH JBDODAFFNKP(APLBGFGJNCA LIGKCFOOPNO, [In] MIAGEIJEICK FHNKDHIILBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x6F87BE0", Offset = "0x6F861E0", VA = "0x186F87BE0")]
	public NIDOBNBOINJ PDLNIGDNPPB(APLBGFGJNCA LIGKCFOOPNO, [In] MIAGEIJEICK FHNKDHIILBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x6F877B0", Offset = "0x6F85DB0", VA = "0x186F877B0")]
	public BJEDNLOFOCD CJHNJJLCBBL(APLBGFGJNCA LIGKCFOOPNO, [In] MIAGEIJEICK FHNKDHIILBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x6F87940", Offset = "0x6F85F40", VA = "0x186F87940")]
	public MOALKNPEIEJ LHHFOALJJFI(APLBGFGJNCA LIGKCFOOPNO, [In] MIAGEIJEICK FHNKDHIILBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x6F88100", Offset = "0x6F86700", VA = "0x186F88100")]
	public COKAFKIMNBP PNACPCHIFHK(APLBGFGJNCA LIGKCFOOPNO, [In] MIAGEIJEICK FHNKDHIILBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x6F87860", Offset = "0x6F85E60", VA = "0x186F87860", Slot = "19")]
	public APLBGFGJNCA DJOBDPAJLOD(RigidbodyEx HOIOIPJLNDO, MIAGEIJEICK FHNKDHIILBL, PCNLIDDLILB MFNJBGPIIEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x6F88250", Offset = "0x6F86850", VA = "0x186F88250")]
	public LFNDKOCAEHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x6F879F0", Offset = "0x6F85FF0", VA = "0x186F879F0", Slot = "14")]
	private FNDLGAMMLDH EPLJPPJDEFK(APLBGFGJNCA LIGKCFOOPNO, [In] MIAGEIJEICK FHNKDHIILBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x6F87BE0", Offset = "0x6F861E0", VA = "0x186F87BE0", Slot = "15")]
	private NIDOBNBOINJ IILJPPOKJGM(APLBGFGJNCA LIGKCFOOPNO, [In] MIAGEIJEICK FHNKDHIILBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x6F877B0", Offset = "0x6F85DB0", VA = "0x186F877B0", Slot = "16")]
	private BJEDNLOFOCD COGHFDIOKAE(APLBGFGJNCA LIGKCFOOPNO, [In] MIAGEIJEICK FHNKDHIILBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x6F87940", Offset = "0x6F85F40", VA = "0x186F87940", Slot = "17")]
	private MOALKNPEIEJ DNJDKOIFKLL(APLBGFGJNCA LIGKCFOOPNO, [In] MIAGEIJEICK FHNKDHIILBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x6F88100", Offset = "0x6F86700", VA = "0x186F88100", Slot = "18")]
	private COKAFKIMNBP PMLAGJGBCAF(APLBGFGJNCA LIGKCFOOPNO, [In] MIAGEIJEICK FHNKDHIILBL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface GIMFCGHBEBC : DMGGNDNGING, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GAMMKDIBDLH(APLBGFGJNCA HOIOIPJLNDO);

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AJAEINCGPLB(APLBGFGJNCA HOIOIPJLNDO);

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AHDHBDBFBBE(APLBGFGJNCA JDLKLHDHDEB);

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OMAFIMMNPKC(APLBGFGJNCA JDLKLHDHDEB);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface BEOONBKKLOK : CPFOCAOAKBF
{
	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	GPBEEAFKGJF<APLBGFGJNCA> ENAEOLFIFMN
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	APLBGFGJNCA JKFAJMIAILJ
	{
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface LGBOIHEGLDO : MOALKNPEIEJ
{
	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	(float, Vector3) KKEHCEGECGD(Rigidbody BEDHMMKOLOE);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface ANCLBLCMMBN : NIDOBNBOINJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	PhotonView AENNDLLJBBP
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal sealed class GNFHDNIIGIM : AKBJNHGNECB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly LECKHBKBLIE HOIOIPJLNDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private CollisionDetectionMode KLKDLLPLIJP;

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	private Rigidbody IIPBAHLFLID
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x6F7DEA0", Offset = "0x6F7C4A0", VA = "0x186F7DEA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public CollisionDetectionMode AIEMLBIPKKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x6F7E210", Offset = "0x6F7C810", VA = "0x186F7E210", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x6F7E430", Offset = "0x6F7CA30", VA = "0x186F7E430", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x6F7C9A0", Offset = "0x6F7AFA0", VA = "0x186F7C9A0")]
	public GNFHDNIIGIM(APLBGFGJNCA HOIOIPJLNDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x6F7E320", Offset = "0x6F7C920", VA = "0x186F7E320", Slot = "6")]
	public void NJNJFFLKLJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x6F7E070", Offset = "0x6F7C670", VA = "0x186F7E070", Slot = "9")]
	public void GFNCMGKLDEI(Rigidbody IBPJGMDGDIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x6F7DEF0", Offset = "0x6F7C4F0", VA = "0x186F7DEF0", Slot = "7")]
	public void AALDBFMNNDA(bool PANMEHIHIBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x6F7DF00", Offset = "0x6F7C500", VA = "0x186F7DF00", Slot = "8")]
	public void BJAKKKCFBND(bool PANMEHIHIBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x6F7DF10", Offset = "0x6F7C510", VA = "0x186F7DF10", Slot = "10")]
	public bool CCOPMDDFIGI(Vector3 KDJEBHMIDDA, [Out] RaycastHit AFHFMMLDFGN, float PNEKGHHAGPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x6F7E0F0", Offset = "0x6F7C6F0", VA = "0x186F7E0F0")]
	private void KNCKHKNAOJN(bool PANMEHIHIBN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class JIDGJGHFGAG : KMKPHBLDIIH, IDisposable, FGNAADCNCCK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly LECKHBKBLIE HOIOIPJLNDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private AHOPCOINALC IOFJEKKNLEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private FHGHNLIPMAB DMMAPDELJJK;

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public AHOPCOINALC MOCDPHINOGF
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x6F811A0", Offset = "0x6F7F7A0", VA = "0x186F811A0", Slot = "6")]
		get
		{
			return default(AHOPCOINALC);
		}
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x6F810D0", Offset = "0x6F7F6D0", VA = "0x186F810D0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	private Transform MIGHMBDINDI
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x6F81000", Offset = "0x6F7F600", VA = "0x186F81000", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	public event Action<HPJFBALBIOJ, HPJFBALBIOJ> FPKHALMDLDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x6F81550", Offset = "0x6F7FB50", VA = "0x186F81550", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x6F81020", Offset = "0x6F7F620", VA = "0x186F81020", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x6F81600", Offset = "0x6F7FC00", VA = "0x186F81600")]
	public JIDGJGHFGAG(APLBGFGJNCA HOIOIPJLNDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x6F812E0", Offset = "0x6F7F8E0", VA = "0x186F812E0", Slot = "8")]
	public void NJNJFFLKLJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x6F80FB0", Offset = "0x6F7F5B0", VA = "0x186F80FB0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x97B580", Offset = "0x979B80", VA = "0x18097B580", Slot = "11")]
	private void BOEPANBDJOK(HPJFBALBIOJ BBJCFJAGFJE, HPJFBALBIOJ BNCFEMNNLIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350", Slot = "12")]
	private void PAMHPOABJEB(bool CCMANGKMKPF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class APBPCDEOAND : ONEPIAJLOFA
{
	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A900", Offset = "0x6F78F00", VA = "0x186F7A900", Slot = "4")]
	public DMGGNDNGING OMFFAMKPKOE(APLBGFGJNCA LIGKCFOOPNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A7E0", Offset = "0x6F78DE0", VA = "0x186F7A7E0", Slot = "5")]
	public HAINGGMEBCP JIIPKKBNDKE(APLBGFGJNCA LIGKCFOOPNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A200", Offset = "0x6F78800", VA = "0x186F7A200", Slot = "6")]
	public CPFOCAOAKBF GJIGFCGBIJF(APLBGFGJNCA LIGKCFOOPNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A760", Offset = "0x6F78D60", VA = "0x186F7A760", Slot = "7")]
	public MCHAOOGFIAG JFKKLEBDCCF(APLBGFGJNCA LIGKCFOOPNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x6F79C10", Offset = "0x6F78210", VA = "0x186F79C10", Slot = "8")]
	public CJEAPFBINIP APAJABFGLEM(APLBGFGJNCA LIGKCFOOPNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x6F7AB90", Offset = "0x6F79190", VA = "0x186F7AB90", Slot = "9")]
	public KMKPHBLDIIH PPMFHCDOJPB(APLBGFGJNCA LIGKCFOOPNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A580", Offset = "0x6F78B80", VA = "0x186F7A580", Slot = "10")]
	public OMFLJILKCBJ IKAPCKKANAN(APLBGFGJNCA LIGKCFOOPNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A6A0", Offset = "0x6F78CA0", VA = "0x186F7A6A0", Slot = "11")]
	public BNCMPGAJGPD JAHDMOFAMIC(APLBGFGJNCA LIGKCFOOPNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A330", Offset = "0x6F78930", VA = "0x186F7A330", Slot = "12")]
	public AKBJNHGNECB HNHFBNANCFG(APLBGFGJNCA LIGKCFOOPNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A9F0", Offset = "0x6F78FF0", VA = "0x186F7A9F0", Slot = "13")]
	public LLMHJHKEOMO PHJHFOBLDJB(APLBGFGJNCA LIGKCFOOPNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A0C0", Offset = "0x6F786C0", VA = "0x186F7A0C0")]
	public FNDLGAMMLDH JBDODAFFNKP(APLBGFGJNCA LIGKCFOOPNO, [In] MIAGEIJEICK FHNKDHIILBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A3F0", Offset = "0x6F789F0", VA = "0x186F7A3F0")]
	public NIDOBNBOINJ PDLNIGDNPPB(APLBGFGJNCA LIGKCFOOPNO, [In] MIAGEIJEICK FHNKDHIILBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x6F79CE0", Offset = "0x6F782E0", VA = "0x186F79CE0")]
	public BJEDNLOFOCD CJHNJJLCBBL(APLBGFGJNCA LIGKCFOOPNO, [In] MIAGEIJEICK FHNKDHIILBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x6F79F30", Offset = "0x6F78530", VA = "0x186F79F30")]
	public MOALKNPEIEJ LHHFOALJJFI(APLBGFGJNCA LIGKCFOOPNO, [In] MIAGEIJEICK FHNKDHIILBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x6F7AAB0", Offset = "0x6F790B0", VA = "0x186F7AAB0")]
	public COKAFKIMNBP PNACPCHIFHK(APLBGFGJNCA LIGKCFOOPNO, [In] MIAGEIJEICK FHNKDHIILBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x6F79E10", Offset = "0x6F78410", VA = "0x186F79E10", Slot = "19")]
	public APLBGFGJNCA DJOBDPAJLOD(RigidbodyEx HOIOIPJLNDO, MIAGEIJEICK FHNKDHIILBL, PCNLIDDLILB MFNJBGPIIEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
	public APBPCDEOAND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A0C0", Offset = "0x6F786C0", VA = "0x186F7A0C0", Slot = "14")]
	private FNDLGAMMLDH EPLJPPJDEFK(APLBGFGJNCA LIGKCFOOPNO, [In] MIAGEIJEICK FHNKDHIILBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A3F0", Offset = "0x6F789F0", VA = "0x186F7A3F0", Slot = "15")]
	private NIDOBNBOINJ IILJPPOKJGM(APLBGFGJNCA LIGKCFOOPNO, [In] MIAGEIJEICK FHNKDHIILBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x6F79CE0", Offset = "0x6F782E0", VA = "0x186F79CE0", Slot = "16")]
	private BJEDNLOFOCD COGHFDIOKAE(APLBGFGJNCA LIGKCFOOPNO, [In] MIAGEIJEICK FHNKDHIILBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x6F79F30", Offset = "0x6F78530", VA = "0x186F79F30", Slot = "17")]
	private MOALKNPEIEJ DNJDKOIFKLL(APLBGFGJNCA LIGKCFOOPNO, [In] MIAGEIJEICK FHNKDHIILBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x6F7AAB0", Offset = "0x6F790B0", VA = "0x186F7AAB0", Slot = "18")]
	private COKAFKIMNBP PMLAGJGBCAF(APLBGFGJNCA LIGKCFOOPNO, [In] MIAGEIJEICK FHNKDHIILBL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal sealed class GMHBPIMDNBF : BNCMPGAJGPD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly LECKHBKBLIE HOIOIPJLNDO;

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	private Rigidbody IIPBAHLFLID
	{
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x6F7DEA0", Offset = "0x6F7C4A0", VA = "0x186F7DEA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	private bool EJAIKGPDIBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x6F7D670", Offset = "0x6F7BC70", VA = "0x186F7D670")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	private bool OGKMLGMAMJM
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x6F7D390", Offset = "0x6F7B990", VA = "0x186F7D390")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	private APLBGFGJNCA EGEBOODOFAP
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x6F7D920", Offset = "0x6F7BF20", VA = "0x186F7D920")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x6F7C9A0", Offset = "0x6F7AFA0", VA = "0x186F7C9A0")]
	public GMHBPIMDNBF(APLBGFGJNCA HOIOIPJLNDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x6F7DBE0", Offset = "0x6F7C1E0", VA = "0x186F7DBE0", Slot = "4")]
	public void JMNAKONBCGM(Vector3 BAKDLGCFEEB, ForceMode CGHFFMJLLOB = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x6F7D980", Offset = "0x6F7BF80", VA = "0x186F7D980")]
	private void ICJDOLFFBKN(Vector3 BAKDLGCFEEB, ForceMode CGHFFMJLLOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x6F7D3F0", Offset = "0x6F7B9F0", VA = "0x186F7D3F0", Slot = "5")]
	public void BIAEKBICOOJ(Vector3 BAKDLGCFEEB, Vector3 MOIICCIPACK, ForceMode CGHFFMJLLOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x6F7DD40", Offset = "0x6F7C340", VA = "0x186F7DD40", Slot = "6")]
	public void KMGFCLKLIKC(Vector3 OAEKPIGFLHH, ForceMode CGHFFMJLLOB = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x6F7D6C0", Offset = "0x6F7BCC0", VA = "0x186F7D6C0")]
	private void CKLIECOJBFF(Vector3 OAEKPIGFLHH, ForceMode CGHFFMJLLOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x6F7D130", Offset = "0x6F7B730", VA = "0x186F7D130", Slot = "7")]
	public void AADNPNFECGO(Vector3 OAEKPIGFLHH, ForceMode CGHFFMJLLOB = ForceMode.Force)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal sealed class EDMOALNEFNI : LLMHJHKEOMO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly LECKHBKBLIE HOIOIPJLNDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private bool NLGHMADHINI;

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public bool MAIOGPMEPHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x92FCA0", Offset = "0x92E2A0", VA = "0x18092FCA0", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x6F7C7F0", Offset = "0x6F7ADF0", VA = "0x186F7C7F0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x6F7C9A0", Offset = "0x6F7AFA0", VA = "0x186F7C9A0")]
	public EDMOALNEFNI(APLBGFGJNCA HOIOIPJLNDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x6F7C970", Offset = "0x6F7AF70", VA = "0x186F7C970", Slot = "6")]
	public void GFNCMGKLDEI(Rigidbody IBPJGMDGDIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x6F7C900", Offset = "0x6F7AF00", VA = "0x186F7C900", Slot = "7")]
	public void EBGHPNDPMOJ(Rigidbody IBPJGMDGDIO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal sealed class MHBCEOILOMI : GIMFCGHBEBC, DMGGNDNGING, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly APLBGFGJNCA HOIOIPJLNDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly List<APLBGFGJNCA> PGKMKEOHOAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private APLBGFGJNCA FMGEJNFFGHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private APLBGFGJNCA HHMPHBNGMGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private Transform FPCNDJBJCLH;

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	private Transform ODNLGPAEKMF
	{
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x6F8A6C0", Offset = "0x6F88CC0", VA = "0x186F8A6C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public APLBGFGJNCA EGEBOODOFAP
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x863E50", Offset = "0x862450", VA = "0x180863E50", Slot = "28")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x6F899C0", Offset = "0x6F87FC0", VA = "0x186F899C0", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public APLBGFGJNCA JJGALJKCIFK
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x863DD0", Offset = "0x8623D0", VA = "0x180863DD0", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public IReadOnlyList<APLBGFGJNCA> PNMELPFDNDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x863E00", Offset = "0x862400", VA = "0x180863E00", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000021")]
	public event HJNBIKAPNHI MEJFDLJMBHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x6F89920", Offset = "0x6F87F20", VA = "0x186F89920", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x6F89740", Offset = "0x6F87D40", VA = "0x186F89740", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000022")]
	public event HJNBIKAPNHI CCIOFDBKGEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x6F890C0", Offset = "0x6F876C0", VA = "0x186F890C0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x6F8AB00", Offset = "0x6F89100", VA = "0x186F8AB00", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000023")]
	public event JHDGOPNJJCO HEJFAKOONNE
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x6F8A7C0", Offset = "0x6F88DC0", VA = "0x186F8A7C0", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x6F897E0", Offset = "0x6F87DE0", VA = "0x186F897E0", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000024")]
	public event Action PCMNEHBAIEF
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x6F8A720", Offset = "0x6F88D20", VA = "0x186F8A720", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x6F8A9C0", Offset = "0x6F88FC0", VA = "0x186F8A9C0", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000025")]
	public event Action FDAFOFJNFAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x6F89BA0", Offset = "0x6F881A0", VA = "0x186F89BA0", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x6F8A860", Offset = "0x6F88E60", VA = "0x186F8A860", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000026")]
	public event Action<APLBGFGJNCA> FDKFJIJKDCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x6F89C40", Offset = "0x6F88240", VA = "0x186F89C40", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x6F8A090", Offset = "0x6F88690", VA = "0x186F8A090", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000027")]
	public event Action<APLBGFGJNCA> INMPJHKCHJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x6F8AE20", Offset = "0x6F89420", VA = "0x186F8AE20", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x6F89E00", Offset = "0x6F88400", VA = "0x186F89E00", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000028")]
	public event Action HCNDPNJJECM
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x6F8AA60", Offset = "0x6F89060", VA = "0x186F8AA60", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x6F896A0", Offset = "0x6F87CA0", VA = "0x186F896A0", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000029")]
	public event Action<APLBGFGJNCA> GJMGPANENOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x6F89EB0", Offset = "0x6F884B0", VA = "0x186F89EB0", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x6F894B0", Offset = "0x6F87AB0", VA = "0x186F894B0", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x6F8AED0", Offset = "0x6F894D0", VA = "0x186F8AED0")]
	public MHBCEOILOMI(APLBGFGJNCA HOIOIPJLNDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x6F89880", Offset = "0x6F87E80", VA = "0x186F89880", Slot = "31")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x6F8A140", Offset = "0x6F88740", VA = "0x186F8A140", Slot = "30")]
	public void JBIJAJOHEMP(APLBGFGJNCA NAEADMGDGFI, bool FFPHPJEJBKL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x6F89160", Offset = "0x6F87760", VA = "0x186F89160", Slot = "6")]
	public void AHDHBDBFBBE(APLBGFGJNCA JDLKLHDHDEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x6F8ABA0", Offset = "0x6F891A0", VA = "0x186F8ABA0", Slot = "7")]
	public void OMAFIMMNPKC(APLBGFGJNCA JDLKLHDHDEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x6F89CF0", Offset = "0x6F882F0", VA = "0x186F89CF0", Slot = "4")]
	public void GAMMKDIBDLH(APLBGFGJNCA HOIOIPJLNDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x6F893D0", Offset = "0x6F879D0", VA = "0x186F893D0", Slot = "5")]
	public void AJAEINCGPLB(APLBGFGJNCA HOIOIPJLNDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x6F89B00", Offset = "0x6F88100", VA = "0x186F89B00")]
	private void EPCICLNOMAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x6F89470", Offset = "0x6F87A70", VA = "0x186F89470")]
	private void ALIKKNONPMB(APLBGFGJNCA JDLKLHDHDEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x6F89560", Offset = "0x6F87B60", VA = "0x186F89560")]
	private void CEIOOEIFHDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x6F89F60", Offset = "0x6F88560", VA = "0x186F89F60")]
	private void GKDGKIINPEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x6F899D0", Offset = "0x6F87FD0", VA = "0x186F899D0")]
	private void EKGNEMEGABM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x6F8A900", Offset = "0x6F88F00", VA = "0x186F8A900")]
	[CompilerGenerated]
	private object LKDPEKJEOGN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal static class BKPAMOJHCCI
{
	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x6F7B220", Offset = "0x6F79820", VA = "0x186F7B220")]
	public static GIMFCGHBEBC DCNBNJDGLNB(this APLBGFGJNCA LIGKCFOOPNO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal sealed class CLLOGGJMHEJ : BEOONBKKLOK, CPFOCAOAKBF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly LECKHBKBLIE HOIOIPJLNDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly GPBEEAFKGJF<APLBGFGJNCA> PGIKKABNIGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private bool CCOBJIGCNGJ;

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public GPBEEAFKGJF<APLBGFGJNCA> ENAEOLFIFMN
	{
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x866510", Offset = "0x864B10", VA = "0x180866510", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public Vector3 EDCABHFAAFE
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x6F7BAD0", Offset = "0x6F7A0D0", VA = "0x186F7BAD0", Slot = "6")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public Vector3 IKDJAIOOJFG
	{
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x6F7C490", Offset = "0x6F7AA90", VA = "0x186F7C490", Slot = "7")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	private Vector3 PFPOLMCKFGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x6F7C280", Offset = "0x6F7A880", VA = "0x186F7C280")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public APLBGFGJNCA JKFAJMIAILJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x6F7C370", Offset = "0x6F7A970", VA = "0x186F7C370", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x6F7C650", Offset = "0x6F7AC50", VA = "0x186F7C650")]
	public CLLOGGJMHEJ(APLBGFGJNCA HOIOIPJLNDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x6F7C420", Offset = "0x6F7AA20", VA = "0x186F7C420", Slot = "8")]
	public void NLLPPNIMLMC(APLBGFGJNCA HHMPHBNGMGF, object OEDJKICDDGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x6F7C220", Offset = "0x6F7A820", VA = "0x186F7C220", Slot = "9")]
	public void HNAPJGELACK(object OEDJKICDDGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x6F7BB00", Offset = "0x6F7A100", VA = "0x186F7BB00")]
	private Vector3 DFNJOFKKKMN()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x6F7BE90", Offset = "0x6F7A490", VA = "0x186F7BE90")]
	private void FIBMKEEFDEG(APLBGFGJNCA PPFEHOPFFPG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal static class HDGEBAKCHEN
{
	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x6F7E4A0", Offset = "0x6F7CAA0", VA = "0x186F7E4A0")]
	public static BEOONBKKLOK DNOOMBLMDNF(this APLBGFGJNCA LIGKCFOOPNO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal sealed class IGKLCJDAICK : LGBOIHEGLDO, MOALKNPEIEJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private readonly LECKHBKBLIE HOIOIPJLNDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly OverridableVector3 DKANNPGKCGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly OverridableVector3 PHFKLNEEBDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private float EKONFELAOEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private float EBIBGLELPLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private Vector3 JNPBMMPAEKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private Vector3? EHAKGOGHFPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private Quaternion? MALDBKLIIFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private bool AGGKFLOKKFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private bool FOCCPPDMOAB;

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public Vector3 LLCHMCEGACO
	{
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0xD72B20", Offset = "0xD71120", VA = "0x180D72B20", Slot = "7")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x6F7F220", Offset = "0x6F7D820", VA = "0x186F7F220", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public Vector3 DMKBNHANJAP
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x6F80C60", Offset = "0x6F7F260", VA = "0x186F80C60", Slot = "9")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public float BOLEMMHMCAB
	{
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x8CDC90", Offset = "0x8CC290", VA = "0x1808CDC90", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x6F7E8A0", Offset = "0x6F7CEA0", VA = "0x186F7E8A0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public float JCPNADANAGB
	{
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x8CDDA0", Offset = "0x8CC3A0", VA = "0x1808CDDA0", Slot = "11")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x6F7E670", Offset = "0x6F7CC70", VA = "0x186F7E670", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public Vector3 OGIAMCOBEDN
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x6F7EC30", Offset = "0x6F7D230", VA = "0x186F7EC30", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public Quaternion ILIHBKBCLNO
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x6F7F0A0", Offset = "0x6F7D6A0", VA = "0x186F7F0A0", Slot = "14")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	private Rigidbody IIPBAHLFLID
	{
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x6F80E00", Offset = "0x6F7F400", VA = "0x186F80E00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002A")]
	public event HJNBIKAPNHI DJBLLAAKELC
	{
		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x6F7E5D0", Offset = "0x6F7CBD0", VA = "0x186F7E5D0", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x6F80D60", Offset = "0x6F7F360", VA = "0x186F80D60", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x6F80E50", Offset = "0x6F7F450", VA = "0x186F80E50")]
	public IGKLCJDAICK(APLBGFGJNCA HOIOIPJLNDO, [In] MIAGEIJEICK FHNKDHIILBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x6F7F3B0", Offset = "0x6F7D9B0", VA = "0x186F7F3B0", Slot = "17")]
	public void JFEFDBPFKAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x6F7E9B0", Offset = "0x6F7CFB0", VA = "0x186F7E9B0", Slot = "16")]
	public void BGIAMMFHOEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x6F7F2D0", Offset = "0x6F7D8D0", VA = "0x186F7F2D0", Slot = "19")]
	public void GFNCMGKLDEI(Rigidbody IBPJGMDGDIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x6F7EEB0", Offset = "0x6F7D4B0", VA = "0x186F7EEB0", Slot = "20")]
	public void EBGHPNDPMOJ(Rigidbody IBPJGMDGDIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x6F80AB0", Offset = "0x6F7F0B0", VA = "0x186F80AB0", Slot = "18")]
	public void MFCGGLFKNLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x6F7F560", Offset = "0x6F7DB60", VA = "0x186F7F560", Slot = "21")]
	public void KAAHHJDKNAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x6F7F220", Offset = "0x6F7D820", VA = "0x186F7F220")]
	private void KMEPLGFOBDL(Vector3 CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x6F7EDC0", Offset = "0x6F7D3C0", VA = "0x186F7EDC0")]
	[Obsolete("This method is dangerous - the unity rigidbody is updated in a deferred manner and this world position may be stale")]
	private Vector3 DMJNEEKPOKM()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x6F7E8A0", Offset = "0x6F7CEA0", VA = "0x186F7E8A0")]
	private void BONKGINCFCF(float CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x6F7E670", Offset = "0x6F7CC70", VA = "0x186F7E670")]
	private void ACAICLFONDI(float CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x6F7EA90", Offset = "0x6F7D090", VA = "0x186F7EA90")]
	private Vector3 BLLOCEOCBFA()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x6F7FA00", Offset = "0x6F7E000", VA = "0x186F7FA00", Slot = "15")]
	public void KDALBOFGHHC((Quaternion rot, Vector3 moments) GIALOAJHHIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x6F7E720", Offset = "0x6F7CD20", VA = "0x186F7E720")]
	private Quaternion AOJKNOHGEGL()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x6F809E0", Offset = "0x6F7EFE0", VA = "0x186F809E0")]
	public void KKEHCEGECGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x6F7FC30", Offset = "0x6F7E230", VA = "0x186F7FC30", Slot = "4")]
	public (float, Vector3) KKEHCEGECGD(Rigidbody BEDHMMKOLOE)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal static class AJADGEOJBNM
{
	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x6F79B50", Offset = "0x6F78150", VA = "0x186F79B50")]
	public static LGBOIHEGLDO NKODNOGEOHC(this APLBGFGJNCA LIGKCFOOPNO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal sealed class CLLEBNFLAEC : BJEDNLOFOCD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly LECKHBKBLIE HOIOIPJLNDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private readonly GENPGFDOLOA LJMHGABOBMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private readonly JAFDOBAHKIN KMDGACFHLDK;

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public bool NGAJEOEHEEF
	{
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0xEFAC50", Offset = "0xEF9250", VA = "0x180EFAC50", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public JAFDOBAHKIN BDHIHHHPNOP
	{
		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x8D8B10", Offset = "0x8D7110", VA = "0x1808D8B10", Slot = "11")]
		get
		{
			return default(JAFDOBAHKIN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x6F7B9D0", Offset = "0x6F79FD0", VA = "0x186F7B9D0")]
	public CLLEBNFLAEC(APLBGFGJNCA HOIOIPJLNDO, [In] MIAGEIJEICK FHNKDHIILBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x6F7B680", Offset = "0x6F79C80", VA = "0x186F7B680", Slot = "4")]
	public void NJNJFFLKLJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x6F7B750", Offset = "0x6F79D50", VA = "0x186F7B750")]
	private bool NLAFFKMPJGO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x6F7B830", Offset = "0x6F79E30", VA = "0x186F7B830", Slot = "5")]
	public void OFKLKDCJGJA(object OEDJKICDDGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x6F7B510", Offset = "0x6F79B10", VA = "0x186F7B510", Slot = "6")]
	public void HLGBADLIJGL(object OEDJKICDDGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x6F7B540", Offset = "0x6F79B40", VA = "0x186F7B540", Slot = "9")]
	public void NEOGDEAKAHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x6F7B3F0", Offset = "0x6F799F0", VA = "0x186F7B3F0")]
	private void EILCDOOMKEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x6F7B860", Offset = "0x6F79E60", VA = "0x186F7B860")]
	private void PLPOECPHELO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x6F7B7F0", Offset = "0x6F79DF0", VA = "0x186F7B7F0", Slot = "8")]
	public void OAAGPJFOBLH(APLBGFGJNCA HOIOIPJLNDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x6F7B3B0", Offset = "0x6F799B0", VA = "0x186F7B3B0", Slot = "7")]
	public void DCOKOEOLMOH(APLBGFGJNCA HOIOIPJLNDO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class BAJMODKBAKB : OMFLJILKCBJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly LECKHBKBLIE HOIOIPJLNDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly GENPGFDOLOA OKIGDEEOOMC;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public bool EJAIKGPDIBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x6F7AC60", Offset = "0x6F79260", VA = "0x186F7AC60", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002B")]
	public event HJNBIKAPNHI OLEHIOMBLOL
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x6F7AD20", Offset = "0x6F79320", VA = "0x186F7AD20", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x6F7ADF0", Offset = "0x6F793F0", VA = "0x186F7ADF0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x6F7B070", Offset = "0x6F79670", VA = "0x186F7B070")]
	public BAJMODKBAKB(APLBGFGJNCA HOIOIPJLNDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x6F7AD10", Offset = "0x6F79310", VA = "0x186F7AD10", Slot = "7")]
	public void CNBBAJCBBGF(object OEDJKICDDGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x6F7B060", Offset = "0x6F79660", VA = "0x186F7B060", Slot = "8")]
	public void NLNABJAHOLE(object OEDJKICDDGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x6F7AF10", Offset = "0x6F79510", VA = "0x186F7AF10", Slot = "9")]
	public void MEPPPGODBIL(object OEDJKICDDGA, bool OKDLNAIMGHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x6F7B020", Offset = "0x6F79620", VA = "0x186F7B020", Slot = "12")]
	public void NDFKGLEEOHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x6F7AE90", Offset = "0x6F79490", VA = "0x186F7AE90", Slot = "10")]
	public void GFNCMGKLDEI(Rigidbody NEPLMIMPLJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x6F7ADC0", Offset = "0x6F793C0", VA = "0x186F7ADC0", Slot = "11")]
	public void EBGHPNDPMOJ(Rigidbody IBPJGMDGDIO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal sealed class LNNFDCCIFMH : ANCLBLCMMBN, NIDOBNBOINJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly LECKHBKBLIE HOIOIPJLNDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private PhotonView MLBJOODCFMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private bool MGNNCHFFFHA;

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public PhotonView AENNDLLJBBP
	{
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x8657D0", Offset = "0x863DD0", VA = "0x1808657D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public bool LNOIEOBPGOA
	{
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x6F885E0", Offset = "0x6F86BE0", VA = "0x186F885E0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public bool HLOCEFHJFJC
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0xA774A0", Offset = "0xA75AA0", VA = "0x180A774A0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002C")]
	public event HJNBIKAPNHI LLGAAAIHHIP
	{
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x6F88E00", Offset = "0x6F87400", VA = "0x186F88E00", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x6F88C30", Offset = "0x6F87230", VA = "0x186F88C30", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x6F88EA0", Offset = "0x6F874A0", VA = "0x186F88EA0")]
	public LNNFDCCIFMH(APLBGFGJNCA HOIOIPJLNDO, [In] MIAGEIJEICK FHNKDHIILBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x6F88CD0", Offset = "0x6F872D0", VA = "0x186F88CD0", Slot = "9")]
	public void NJNJFFLKLJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x6F88600", Offset = "0x6F86C00", VA = "0x186F88600", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x6F88300", Offset = "0x6F86900", VA = "0x186F88300", Slot = "10")]
	public void AADHAIMFKPJ(APLBGFGJNCA HHMPHBNGMGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x6F88470", Offset = "0x6F86A70", VA = "0x186F88470", Slot = "11")]
	public void BKPHMNCBNLA(APLBGFGJNCA HHMPHBNGMGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x6F88AC0", Offset = "0x6F870C0", VA = "0x186F88AC0")]
	private void KDMECLOHCAD(PhotonView OMCFGNDBOHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x6F88970", Offset = "0x6F86F70", VA = "0x186F88970")]
	private void JJHELPFFANK(GMBPJONDGEK EGFEGHKEKCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x6F88700", Offset = "0x6F86D00", VA = "0x186F88700")]
	private void FENILEDHILM(PhotonView JMAEBPCOJKF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal static class BCPIDNGFOKF
{
	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x6F7B160", Offset = "0x6F79760", VA = "0x186F7B160")]
	public static ANCLBLCMMBN ELKOBPOKPDB(this APLBGFGJNCA LIGKCFOOPNO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal sealed class NCLMHJPEJCM : COKAFKIMNBP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly LECKHBKBLIE HOIOIPJLNDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private RigidbodyConstraints HBAOCIHDKOO;

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public bool NJHCAMDGLGE
	{
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0xCF94B0", Offset = "0xCF7AB0", VA = "0x180CF94B0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x4528460", Offset = "0x4526A60", VA = "0x184528460", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool CHIDPLOENAH
	{
		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0xF454E0", Offset = "0xF43AE0", VA = "0x180F454E0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x4528450", Offset = "0x4526A50", VA = "0x184528450")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public RigidbodyConstraints MNFAOBCAHEG
	{
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x8657F0", Offset = "0x863DF0", VA = "0x1808657F0", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x6F8AFF0", Offset = "0x6F895F0", VA = "0x186F8AFF0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x6F8B120", Offset = "0x6F89720", VA = "0x186F8B120")]
	public NCLMHJPEJCM(APLBGFGJNCA HOIOIPJLNDO, [In] MIAGEIJEICK FHNKDHIILBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x6F8AFC0", Offset = "0x6F895C0", VA = "0x186F8AFC0", Slot = "9")]
	public void GFNCMGKLDEI(Rigidbody IBPJGMDGDIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x6F8AF90", Offset = "0x6F89590", VA = "0x186F8AF90", Slot = "10")]
	public void EBGHPNDPMOJ(Rigidbody IBPJGMDGDIO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class FOPJHJJHBAC : MCHAOOGFIAG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly APLBGFGJNCA HOIOIPJLNDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private float EKDGABLHIEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private float KCBCOJGBNPD;

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public float JGIJMIECAMO
	{
		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x8CDE20", Offset = "0x8CC420", VA = "0x1808CDE20", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x6F7CB20", Offset = "0x6F7B120", VA = "0x186F7CB20", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public float OINHMCCHBFI
	{
		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x8CDDE0", Offset = "0x8CC3E0", VA = "0x1808CDDE0", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x6F7CBF0", Offset = "0x6F7B1F0", VA = "0x186F7CBF0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x6F7CCC0", Offset = "0x6F7B2C0", VA = "0x186F7CCC0")]
	public FOPJHJJHBAC(APLBGFGJNCA HOIOIPJLNDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x6F7CAD0", Offset = "0x6F7B0D0", VA = "0x186F7CAD0", Slot = "8")]
	public void GFNCMGKLDEI(Rigidbody IBPJGMDGDIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x6F7CA30", Offset = "0x6F7B030", VA = "0x186F7CA30", Slot = "9")]
	public void EBGHPNDPMOJ(Rigidbody IBPJGMDGDIO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal sealed class PMOPADIMCGC : CJEAPFBINIP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly LECKHBKBLIE HOIOIPJLNDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private bool ANOPKLCMAEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private bool PAPPHMNJMFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private int BMALGHDAPGD;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	private Rigidbody IIPBAHLFLID
	{
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x6F80E00", Offset = "0x6F7F400", VA = "0x186F80E00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	private bool GGPIKHKADAE
	{
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x6F8C390", Offset = "0x6F8A990", VA = "0x186F8C390")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	private APLBGFGJNCA EGEBOODOFAP
	{
		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x6F8BEB0", Offset = "0x6F8A4B0", VA = "0x186F8BEB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	private bool OGKMLGMAMJM
	{
		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x6F8BBC0", Offset = "0x6F8A1C0", VA = "0x186F8BBC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002D")]
	public event HJNBIKAPNHI GFKOIMCPIOF
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x6F8C250", Offset = "0x6F8A850", VA = "0x186F8C250", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x6F8BC20", Offset = "0x6F8A220", VA = "0x186F8BC20", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x6F8C4E0", Offset = "0x6F8AAE0", VA = "0x186F8C4E0")]
	public PMOPADIMCGC(APLBGFGJNCA HOIOIPJLNDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x6F8C3B0", Offset = "0x6F8A9B0", VA = "0x186F8C3B0", Slot = "6")]
	public void NJNJFFLKLJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x6F8BCC0", Offset = "0x6F8A2C0", VA = "0x186F8BCC0", Slot = "8")]
	public void CLMOPEFPGKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x6F8BA70", Offset = "0x6F8A070", VA = "0x186F8BA70", Slot = "7")]
	public bool AGBCHGFAEEO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x6F8C2F0", Offset = "0x6F8A8F0", VA = "0x186F8C2F0", Slot = "9")]
	public void KPCLKJCNCKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x6F8C440", Offset = "0x6F8AA40", VA = "0x186F8C440", Slot = "11")]
	public void OGFNCOIHMFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x6F8C0A0", Offset = "0x6F8A6A0", VA = "0x186F8C0A0", Slot = "10")]
	public void GPHBGJPMKAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x6F8BCD0", Offset = "0x6F8A2D0", VA = "0x186F8BCD0")]
	private bool EJIHMNEELBC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x6F8BF10", Offset = "0x6F8A510", VA = "0x186F8BF10")]
	private void GJIIEMKJHJH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class PBEKOKMAFHK : FNDLGAMMLDH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly LECKHBKBLIE HOIOIPJLNDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly GENPGFDOLOA MMNOCJKGDCF;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public Rigidbody IIPBAHLFLID
	{
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x8657D0", Offset = "0x863DD0", VA = "0x1808657D0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x864E00", Offset = "0x863400", VA = "0x180864E00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	private bool OGKMLGMAMJM
	{
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x6F7D390", Offset = "0x6F7B990", VA = "0x186F7D390")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public bool BLNJFOECNGI
	{
		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0xEFAC50", Offset = "0xEF9250", VA = "0x180EFAC50", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x6F8B960", Offset = "0x6F89F60", VA = "0x186F8B960")]
	public PBEKOKMAFHK(APLBGFGJNCA HOIOIPJLNDO, [In] MIAGEIJEICK FHNKDHIILBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x6F8B8C0", Offset = "0x6F89EC0", VA = "0x186F8B8C0", Slot = "5")]
	public void NJNJFFLKLJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x6F8B3B0", Offset = "0x6F899B0", VA = "0x186F8B3B0", Slot = "7")]
	public void EBGLEEGCKPH(object OEDJKICDDGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x6F8B710", Offset = "0x6F89D10", VA = "0x186F8B710", Slot = "8")]
	public void JKEKIFFHNOK(object OEDJKICDDGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x6F8B3E0", Offset = "0x6F899E0", VA = "0x186F8B3E0", Slot = "9")]
	public void GBOHOMNEGGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x6F8B1C0", Offset = "0x6F897C0", VA = "0x186F8B1C0", Slot = "10")]
	public void AEHKHLMOJIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x6F8B740", Offset = "0x6F89D40", VA = "0x186F8B740", Slot = "11")]
	public void MCDGINDEFFJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal sealed class PPKOBGEMEEM : HAINGGMEBCP, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private readonly LECKHBKBLIE HOIOIPJLNDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private readonly GENPGFDOLOA GIMFEPCILHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private float FHIFBAIDGGH;

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public NBGFPCGNHAJ MDIDEKBEBLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x866520", Offset = "0x864B20", VA = "0x180866520", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x866500", Offset = "0x864B00", VA = "0x180866500", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public GDLMMBKDOFD PDHMDHCJJAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x865820", Offset = "0x863E20", VA = "0x180865820", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x865800", Offset = "0x863E00", VA = "0x180865800", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public Vector3 PFPOLMCKFGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x6F8DE50", Offset = "0x6F8C450", VA = "0x186F8DE50", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x6F8DC80", Offset = "0x6F8C280", VA = "0x186F8DC80", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public Vector3 LPLJJCMDAJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x6F8D750", Offset = "0x6F8BD50", VA = "0x186F8D750", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x6F8EA40", Offset = "0x6F8D040", VA = "0x186F8EA40", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public Vector3 MGBDEJCEECD
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x6F8EA70", Offset = "0x6F8D070", VA = "0x186F8EA70", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x6F8DFB0", Offset = "0x6F8C5B0", VA = "0x186F8DFB0", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public Vector3 GGAIONLLBJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x6F8E070", Offset = "0x6F8C670", VA = "0x186F8E070", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x6F8CCB0", Offset = "0x6F8B2B0", VA = "0x186F8CCB0", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public float KHBCBMICPIE
	{
		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x8CDD00", Offset = "0x8CC300", VA = "0x1808CDD00", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x6F8DD40", Offset = "0x6F8C340", VA = "0x186F8DD40", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public bool HMPBHMHCEBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x18BD0F0", Offset = "0x18BB6F0", VA = "0x1818BD0F0", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	private BNCMPGAJGPD KHAJIAPPDOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x67C5DC0", Offset = "0x67C43C0", VA = "0x1867C5DC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	private bool GGPIKHKADAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x6F8EA20", Offset = "0x6F8D020", VA = "0x186F8EA20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x6F8FB20", Offset = "0x6F8E120", VA = "0x186F8FB20")]
	public PPKOBGEMEEM(APLBGFGJNCA HOIOIPJLNDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x6F8CBA0", Offset = "0x6F8B1A0", VA = "0x186F8CBA0", Slot = "19")]
	public void NJNJFFLKLJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x6F8CC50", Offset = "0x6F8B250", VA = "0x186F8CC50", Slot = "36")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x6F8CEC0", Offset = "0x6F8B4C0", VA = "0x186F8CEC0", Slot = "28")]
	public void GFNCMGKLDEI(Rigidbody IBPJGMDGDIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0xD367C0", Offset = "0xD34DC0", VA = "0x180D367C0", Slot = "20")]
	public void NKHPKHMPMFD(object OEDJKICDDGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0xD38B30", Offset = "0xD37130", VA = "0x180D38B30", Slot = "30")]
	public void FGBCFIADCKO(object OEDJKICDDGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x6F8CCE0", Offset = "0x6F8B2E0", VA = "0x186F8CCE0", Slot = "35")]
	public Vector3 FHOLLECDNPL(Vector3 GAIBCOAKDKC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x6F8CFF0", Offset = "0x6F8B5F0", VA = "0x186F8CFF0", Slot = "34")]
	public Vector3 GIBOAKBIOBF(Vector3 JPHCCCIGOIO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x6F8CBA0", Offset = "0x6F8B1A0", VA = "0x186F8CBA0", Slot = "27")]
	public void DNCLFMGGGJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x6F8C900", Offset = "0x6F8AF00", VA = "0x186F8C900", Slot = "25")]
	public void DANBDBPOFDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x6F8D870", Offset = "0x6F8BE70", VA = "0x186F8D870", Slot = "24")]
	public void HOBKCMKFCLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x6F8C960", Offset = "0x6F8AF60", VA = "0x186F8C960", Slot = "33")]
	public void DEBGMMCHMJM(Vector3 JLAGCBDIOCE, Vector3 EDDEDOBFGPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x6F8F110", Offset = "0x6F8D710", VA = "0x186F8F110", Slot = "32")]
	public void OFGCKBHIDPB(Vector3 OBEPKPEDLHP, Vector3 ABBPNJFJIFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x6F8F7E0", Offset = "0x6F8DDE0", VA = "0x186F8F7E0", Slot = "31")]
	public void PBEKBHIAIFL(Vector3 IJLKCHGFNBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x6F8F170", Offset = "0x6F8D770", VA = "0x186F8F170", Slot = "22")]
	public void OHMJEBOOCPL(IFHGOPCKPNL JGPGGDILHJP, Vector3 FOFCEMPLBMF, float PMHFDGEEHMA, float CKOJHMCFDFN = 8f, float DAPEKAPEIGC = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x6F8D9F0", Offset = "0x6F8BFF0", VA = "0x186F8D9F0", Slot = "21")]
	public void IAAPNEJDAPI(NDHCMAFIHCP DMCPDILGENE, Vector3 CCIKDGBKHJI, float PFIFJDPLMHF = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x6F8E630", Offset = "0x6F8CC30", VA = "0x186F8E630", Slot = "23")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void JNLCOADNGGC(NDHCMAFIHCP DMCPDILGENE, Vector3 ADNGPFKNGFI, float NBNJNGGMAEO = 7f, float JPGDHDCNCHB = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0xE44760", Offset = "0xE42D60", VA = "0x180E44760")]
	private static void DBKLNBIHJCD(Vector3 EFBILKIFBJD, Vector3 FFJHDFACBIE, [Out] Vector3 JEJOKJIPMCH, [Out] Vector3 MDEJIFBEFLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x6F8C570", Offset = "0x6F8AB70", VA = "0x186F8C570", Slot = "29")]
	public Vector3 AEKAOILCHOO(Vector3 EFBILKIFBJD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x6F8C650", Offset = "0x6F8AC50", VA = "0x186F8C650", Slot = "26")]
	public void BFJGNAHHNLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x6F8DD40", Offset = "0x6F8C340", VA = "0x186F8DD40")]
	private void PDAIEKECKEF(float CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x6F8F980", Offset = "0x6F8DF80", VA = "0x186F8F980")]
	private void PNAIHGPFHLH(Vector3 CCIKDGBKHJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x6F8C7E0", Offset = "0x6F8ADE0", VA = "0x186F8C7E0")]
	private Vector3 CELJBILIEHJ()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x6F8EBD0", Offset = "0x6F8D1D0", VA = "0x186F8EBD0")]
	private void MMNBDLLGIGF(Vector3 JPHCCCIGOIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x6F8D8D0", Offset = "0x6F8BED0", VA = "0x186F8D8D0")]
	private Vector3 HOCEDEBJEEI()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x6F8E1A0", Offset = "0x6F8C7A0", VA = "0x186F8E1A0")]
	private void JMINCOBPNIE(Vector3 CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x6F8D1B0", Offset = "0x6F8B7B0", VA = "0x186F8D1B0")]
	private void GIFJLFPNFDG(Vector3 JPHCCCIGOIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x6F8F060", Offset = "0x6F8D660", VA = "0x186F8F060")]
	private void ODONPJOMKCN()
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
